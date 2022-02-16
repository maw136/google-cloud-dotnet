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
    // [START appengine_v1_generated_Applications_RepairApplication_sync]
    using Google.Cloud.AppEngine.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedApplicationsClientSnippets
    {
        /// <summary>Snippet for RepairApplication</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void RepairApplicationRequestObject()
        {
            // Create client
            ApplicationsClient applicationsClient = ApplicationsClient.Create();
            // Initialize request argument(s)
            RepairApplicationRequest request = new RepairApplicationRequest { Name = "", };
            // Make the request
            Operation<Application, OperationMetadataV1> response = applicationsClient.RepairApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadataV1> retrievedResponse = applicationsClient.PollOnceRepairApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END appengine_v1_generated_Applications_RepairApplication_sync]
}
