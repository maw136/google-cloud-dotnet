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

namespace Google.Cloud.Tasks.V2Beta3.Snippets
{
    // [START cloudtasks_v2beta3_generated_CloudTasks_DeleteQueue_sync]
    using Google.Cloud.Tasks.V2Beta3;

    public sealed partial class GeneratedCloudTasksClientSnippets
    {
        /// <summary>Snippet for DeleteQueue</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeleteQueueRequestObject()
        {
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            cloudTasksClient.DeleteQueue(request);
        }
    }
    // [END cloudtasks_v2beta3_generated_CloudTasks_DeleteQueue_sync]
}
