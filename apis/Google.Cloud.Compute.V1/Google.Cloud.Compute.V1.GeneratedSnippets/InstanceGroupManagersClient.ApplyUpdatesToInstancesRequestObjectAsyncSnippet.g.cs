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

namespace Google.Cloud.Compute.V1.Snippets
{
    // [START compute_v1_generated_InstanceGroupManagers_ApplyUpdatesToInstances_async]
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    public sealed partial class GeneratedInstanceGroupManagersClientSnippets
    {
        /// <summary>Snippet for ApplyUpdatesToInstancesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ApplyUpdatesToInstancesRequestObjectAsync()
        {
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ApplyUpdatesToInstancesInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.ApplyUpdatesToInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceApplyUpdatesToInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END compute_v1_generated_InstanceGroupManagers_ApplyUpdatesToInstances_async]
}
