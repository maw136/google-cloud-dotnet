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

namespace Google.Cloud.Memcache.V1Beta2.Snippets
{
    // [START memcache_v1beta2_generated_CloudMemcache_CreateInstance_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Memcache.V1Beta2;
    using Google.LongRunning;

    public sealed partial class GeneratedCloudMemcacheClientSnippets
    {
        /// <summary>Snippet for CreateInstance</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateInstanceRequestObject()
        {
            // Create client
            CloudMemcacheClient cloudMemcacheClient = CloudMemcacheClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InstanceId = "",
                Resource = new Instance(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudMemcacheClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudMemcacheClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END memcache_v1beta2_generated_CloudMemcache_CreateInstance_sync]
}
