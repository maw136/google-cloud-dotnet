// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Tools.Common;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class UpdateDependenciesCommand : CommandBase
    {
        public UpdateDependenciesCommand()
            : base("update-dependencies", "Updates dependencies for all APIs (or those changed in the previous commit, with --owlbot)", 0, 1, "[--owlbot]")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            var catalog = ApiCatalog.Load();
            var apiNames = catalog.CreateIdHashSet();

            var apisToUpdate = catalog.Apis;

            if (args.Length == 1)
            {
                if (args[0] != "--owlbot")
                {
                    throw new UserErrorException("Only valid argument for update-dependencies is --owlbot.");
                }
                apisToUpdate = FindApisToUpdateFromPreviousCommit(catalog);
                // Don't even bother checking if we don't have any updates.
                if (apisToUpdate.Count == 0)
                {
                    return;
                }
            }

            foreach (var api in apisToUpdate)
            {
                GenerateProjectsCommand.UpdateDependencies(catalog, api);
                var layout = DirectoryLayout.ForApi(api.Id);
                GenerateProjectsCommand.GenerateMetadataFile(layout.SourceDirectory, api);
                GenerateProjectsCommand.GenerateProjects(layout.SourceDirectory, api, apiNames);
            }
            string formatted = catalog.FormatJson();
            string currentFileContent = File.ReadAllText(ApiCatalog.CatalogPath);
            if (currentFileContent == formatted)
            {
                Console.WriteLine("No dependencies were updated.");
            }
            else
            {
                File.WriteAllText(ApiCatalog.CatalogPath, formatted);
                Console.WriteLine("Updated apis.json");
            }
        }

        private static List<ApiMetadata> FindApisToUpdateFromPreviousCommit(ApiCatalog catalog)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            using var repo = new Repository(root);
            // OwlBot will be post-processing a new commit from either OwlBot itself or
            // release-please; we want to find out what the API catalog looked like in
            // the parent commit.
            var headCommit = repo.Head.Tip;
            var parentCommit = headCommit.Parents.First();
            var headApisJson = headCommit.Tree["apis/apis.json"].Target;
            var parentApisJson = parentCommit.Tree["apis/apis.json"].Target;

            // Let's not even bother parsing if apis.json hasn't changed.
            if (headApisJson.Sha == parentApisJson.Sha)
            {
                return new();
            }

            var text = ((Blob) parentApisJson).GetContentText();
            var oldCatalog = ApiCatalog.FromJson(text);

            // We only want to check for dependency updates in APIs that have changed *and* aren't patch releases.
            var apisToUpdate = catalog.Apis
                .Where(api => oldCatalog.TryGetApi(api.Id, out var oldApi) && api.Version != oldApi.Version && api.StructuredVersion.Patch == 0)
                .ToList();
            if (apisToUpdate.Any())
            {
                Console.WriteLine("Checking for dependency updates in:");
                foreach (var api in apisToUpdate)
                {
                    Console.WriteLine($"  {api.Id}");
                }
            }
            return apisToUpdate;
        }
    }
}
