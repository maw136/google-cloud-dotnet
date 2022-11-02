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

namespace Google.Cloud.Run.V2.Snippets
{
    // [START run_v2_generated_Jobs_CreateJob_sync_flattened]
    using Google.Cloud.Run.V2;
    using Google.LongRunning;

    public sealed partial class GeneratedJobsClientSnippets
    {
        /// <summary>Snippet for CreateJob</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateJob()
        {
            // Create client
            JobsClient jobsClient = JobsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Job job = new Job();
            string jobId = "";
            // Make the request
            Operation<Job, Job> response = jobsClient.CreateJob(parent, job, jobId);

            // Poll until the returned long-running operation is complete
            Operation<Job, Job> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Job, Job> retrievedResponse = jobsClient.PollOnceCreateJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Job retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END run_v2_generated_Jobs_CreateJob_sync_flattened]
}
