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

namespace Google.Cloud.ApigeeRegistry.V1.Snippets
{
    // [START apigeeregistry_v1_generated_Registry_CreateApiDeployment_async]
    using Google.Cloud.ApigeeRegistry.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRegistryClientSnippets
    {
        /// <summary>Snippet for CreateApiDeploymentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateApiDeploymentRequestObjectAsync()
        {
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateApiDeploymentRequest request = new CreateApiDeploymentRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiDeployment = new ApiDeployment(),
                ApiDeploymentId = "",
            };
            // Make the request
            ApiDeployment response = await registryClient.CreateApiDeploymentAsync(request);
        }
    }
    // [END apigeeregistry_v1_generated_Registry_CreateApiDeployment_async]
}
