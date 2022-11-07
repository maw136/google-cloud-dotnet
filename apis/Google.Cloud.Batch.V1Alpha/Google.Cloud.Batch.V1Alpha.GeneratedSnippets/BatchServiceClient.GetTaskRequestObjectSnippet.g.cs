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

namespace Google.Cloud.Batch.V1Alpha.Snippets
{
    // [START batch_v1alpha_generated_BatchService_GetTask_sync]
    using Google.Cloud.Batch.V1Alpha;

    public sealed partial class GeneratedBatchServiceClientSnippets
    {
        /// <summary>Snippet for GetTask</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void GetTaskRequestObject()
        {
            // Create client
            BatchServiceClient batchServiceClient = BatchServiceClient.Create();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
            };
            // Make the request
            Task response = batchServiceClient.GetTask(request);
        }
    }
    // [END batch_v1alpha_generated_BatchService_GetTask_sync]
}
