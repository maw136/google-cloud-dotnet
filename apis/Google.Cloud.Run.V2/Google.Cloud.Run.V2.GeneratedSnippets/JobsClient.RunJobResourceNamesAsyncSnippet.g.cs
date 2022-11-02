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

#pragma warning disable CS8981

namespace Google.Cloud.Run.V2.Snippets
{
    // [START run_v2_generated_Jobs_RunJob_async_flattened_resourceNames]
    using Google.LongRunning;
    using System.Threading.Tasks;
    using gcrv = Google.Cloud.Run.V2;

    public sealed partial class GeneratedJobsClientSnippets
    {
        /// <summary>Snippet for RunJobAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task RunJobResourceNamesAsync()
        {
            // Create client
            JobsClient jobsClient = await JobsClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Operation<Execution, Execution> response = await jobsClient.RunJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Execution, Execution> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, Execution> retrievedResponse = await jobsClient.PollOnceRunJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END run_v2_generated_Jobs_RunJob_async_flattened_resourceNames]
}
