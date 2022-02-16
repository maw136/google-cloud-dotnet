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
    // [START memcache_v1beta2_generated_CloudMemcache_ApplySoftwareUpdate_sync_flattened]
    using Google.Cloud.Memcache.V1Beta2;
    using Google.LongRunning;
    using System.Collections.Generic;

    public sealed partial class GeneratedCloudMemcacheClientSnippets
    {
        /// <summary>Snippet for ApplySoftwareUpdate</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ApplySoftwareUpdate()
        {
            // Create client
            CloudMemcacheClient cloudMemcacheClient = CloudMemcacheClient.Create();
            // Initialize request argument(s)
            string instance = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            IEnumerable<string> nodeIds = new string[] { "", };
            bool applyAll = false;
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudMemcacheClient.ApplySoftwareUpdate(instance, nodeIds, applyAll);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudMemcacheClient.PollOnceApplySoftwareUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END memcache_v1beta2_generated_CloudMemcache_ApplySoftwareUpdate_sync_flattened]
}
