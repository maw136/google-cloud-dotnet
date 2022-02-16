// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.AIPlatform.V1.Snippets
{
    // [START aiplatform_v1_generated_MetadataService_AddContextArtifactsAndExecutions_async_flattened_resourceNames]
    using Google.Cloud.AIPlatform.V1;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedMetadataServiceClientSnippets
    {
        /// <summary>Snippet for AddContextArtifactsAndExecutionsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task AddContextArtifactsAndExecutionsResourceNamesAsync()
        {
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContextName context = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            IEnumerable<ArtifactName> artifacts = new ArtifactName[]
            {
                ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            IEnumerable<ExecutionName> executions = new ExecutionName[]
            {
                ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            // Make the request
            AddContextArtifactsAndExecutionsResponse response = await metadataServiceClient.AddContextArtifactsAndExecutionsAsync(context, artifacts, executions);
        }
    }
    // [END aiplatform_v1_generated_MetadataService_AddContextArtifactsAndExecutions_async_flattened_resourceNames]
}
