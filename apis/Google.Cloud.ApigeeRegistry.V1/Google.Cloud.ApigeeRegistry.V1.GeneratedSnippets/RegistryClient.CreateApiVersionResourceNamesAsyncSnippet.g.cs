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
    // [START apigeeregistry_v1_generated_Registry_CreateApiVersion_async_flattened_resourceNames]
    using Google.Cloud.ApigeeRegistry.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRegistryClientSnippets
    {
        /// <summary>Snippet for CreateApiVersionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateApiVersionResourceNamesAsync()
        {
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            ApiVersion apiVersion = new ApiVersion();
            string apiVersionId = "";
            // Make the request
            ApiVersion response = await registryClient.CreateApiVersionAsync(parent, apiVersion, apiVersionId);
        }
    }
    // [END apigeeregistry_v1_generated_Registry_CreateApiVersion_async_flattened_resourceNames]
}