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

namespace Google.Cloud.Ids.V1.Snippets
{
    // [START ids_v1_generated_IDS_CreateEndpoint_sync_flattened]
    using Google.Cloud.Ids.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedIDSClientSnippets
    {
        /// <summary>Snippet for CreateEndpoint</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateEndpoint()
        {
            // Create client
            IDSClient iDSClient = IDSClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Operation<Endpoint, OperationMetadata> response = iDSClient.CreateEndpoint(parent, endpoint, endpointId);

            // Poll until the returned long-running operation is complete
            Operation<Endpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Endpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Endpoint, OperationMetadata> retrievedResponse = iDSClient.PollOnceCreateEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Endpoint retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END ids_v1_generated_IDS_CreateEndpoint_sync_flattened]
}
