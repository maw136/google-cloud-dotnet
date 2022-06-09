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

namespace Google.Cloud.Batch.V1.Snippets
{
    // [START batch_v1_generated_BatchService_GetTask_async_flattened_resourceNames]
    using System.Threading.Tasks;
    using gcbv = Google.Cloud.Batch.V1;

    public sealed partial class GeneratedBatchServiceClientSnippets
    {
        /// <summary>Snippet for GetTaskAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetTaskResourceNamesAsync()
        {
            // Create client
            BatchServiceClient batchServiceClient = await BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]");
            // Make the request
            gcbv::Task response = await batchServiceClient.GetTaskAsync(name);
        }
    }
    // [END batch_v1_generated_BatchService_GetTask_async_flattened_resourceNames]
}
