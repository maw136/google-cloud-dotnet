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

namespace GoogleCSharpSnippets
{
    // [START gkemulticloud_v1_generated_AzureClusters_CreateAzureClient_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.GkeMultiCloud.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedAzureClustersClientSnippets
    {
        /// <summary>Snippet for CreateAzureClient</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateAzureClientRequestObject()
        {
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            CreateAzureClientRequest request = new CreateAzureClientRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AzureClient = new AzureClient(),
                ValidateOnly = false,
                AzureClientId = "",
            };
            // Make the request
            Operation<AzureClient, OperationMetadata> response = azureClustersClient.CreateAzureClient(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureClient, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureClient result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureClient, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureClient(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureClient retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gkemulticloud_v1_generated_AzureClusters_CreateAzureClient_sync]
}
