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

namespace Google.Cloud.GkeMultiCloud.V1.Snippets
{
    // [START gkemulticloud_v1_generated_AzureClusters_CreateAzureCluster_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.GkeMultiCloud.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedAzureClustersClientSnippets
    {
        /// <summary>Snippet for CreateAzureCluster</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateAzureClusterRequestObject()
        {
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            CreateAzureClusterRequest request = new CreateAzureClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AzureCluster = new AzureCluster(),
                AzureClusterId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AzureCluster, OperationMetadata> response = azureClustersClient.CreateAzureCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureCluster, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureCluster retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gkemulticloud_v1_generated_AzureClusters_CreateAzureCluster_sync]
}
