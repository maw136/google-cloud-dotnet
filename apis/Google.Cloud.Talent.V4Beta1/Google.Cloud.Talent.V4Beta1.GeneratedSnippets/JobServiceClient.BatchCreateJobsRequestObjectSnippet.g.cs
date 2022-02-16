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

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    // [START jobs_v4beta1_generated_JobService_BatchCreateJobs_sync]
    using Google.Cloud.Talent.V4Beta1;
    using Google.LongRunning;

    public sealed partial class GeneratedJobServiceClientSnippets
    {
        /// <summary>Snippet for BatchCreateJobs</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void BatchCreateJobsRequestObject()
        {
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateJobsRequest request = new BatchCreateJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Jobs = { new Job(), },
            };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = jobServiceClient.BatchCreateJobs(request);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = jobServiceClient.PollOnceBatchCreateJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END jobs_v4beta1_generated_JobService_BatchCreateJobs_sync]
}
