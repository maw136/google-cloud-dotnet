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
    // [START run_v2_generated_Tasks_GetTask_async]
    using System.Threading.Tasks;
    using gcrv = Google.Cloud.Run.V2;

    public sealed partial class GeneratedTasksClientSnippets
    {
        /// <summary>Snippet for GetTaskAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetTaskRequestObjectAsync()
        {
            // Create client
            TasksClient tasksClient = await TasksClient.CreateAsync();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobExecutionTask("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]", "[TASK]"),
            };
            // Make the request
            gcrv::Task response = await tasksClient.GetTaskAsync(request);
        }
    }
    // [END run_v2_generated_Tasks_GetTask_async]
}
