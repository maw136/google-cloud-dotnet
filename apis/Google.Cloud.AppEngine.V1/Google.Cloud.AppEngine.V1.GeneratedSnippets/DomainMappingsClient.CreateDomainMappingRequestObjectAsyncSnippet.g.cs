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

namespace Google.Cloud.AppEngine.V1.Snippets
{
    // [START appengine_v1_generated_DomainMappings_CreateDomainMapping_async]
    using Google.Cloud.AppEngine.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDomainMappingsClientSnippets
    {
        /// <summary>Snippet for CreateDomainMappingAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateDomainMappingRequestObjectAsync()
        {
            // Create client
            DomainMappingsClient domainMappingsClient = await DomainMappingsClient.CreateAsync();
            // Initialize request argument(s)
            CreateDomainMappingRequest request = new CreateDomainMappingRequest
            {
                Parent = "",
                DomainMapping = new DomainMapping(),
                OverrideStrategy = DomainOverrideStrategy.UnspecifiedDomainOverrideStrategy,
            };
            // Make the request
            Operation<DomainMapping, OperationMetadataV1> response = await domainMappingsClient.CreateDomainMappingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DomainMapping, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DomainMapping result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DomainMapping, OperationMetadataV1> retrievedResponse = await domainMappingsClient.PollOnceCreateDomainMappingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DomainMapping retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END appengine_v1_generated_DomainMappings_CreateDomainMapping_async]
}
