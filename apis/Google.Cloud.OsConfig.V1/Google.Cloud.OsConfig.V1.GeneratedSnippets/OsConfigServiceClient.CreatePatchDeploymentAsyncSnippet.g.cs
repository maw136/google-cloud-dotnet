// Copyright 2023 Google LLC
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

namespace Google.Cloud.OsConfig.V1.Snippets
{
    // [START osconfig_v1_generated_OsConfigService_CreatePatchDeployment_async_flattened]
    using Google.Cloud.OsConfig.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedOsConfigServiceClientSnippets
    {
        /// <summary>Snippet for CreatePatchDeploymentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreatePatchDeploymentAsync()
        {
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            PatchDeployment patchDeployment = new PatchDeployment();
            string patchDeploymentId = "";
            // Make the request
            PatchDeployment response = await osConfigServiceClient.CreatePatchDeploymentAsync(parent, patchDeployment, patchDeploymentId);
        }
    }
    // [END osconfig_v1_generated_OsConfigService_CreatePatchDeployment_async_flattened]
}
