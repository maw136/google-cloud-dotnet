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

namespace Google.Cloud.Deploy.V1.Snippets
{
    // [START clouddeploy_v1_generated_CloudDeploy_RetryJob_async_flattened]
    using Google.Cloud.Deploy.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCloudDeployClientSnippets
    {
        /// <summary>Snippet for RetryJobAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task RetryJobAsync()
        {
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string rollout = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            string phaseId = "";
            string jobId = "";
            // Make the request
            RetryJobResponse response = await cloudDeployClient.RetryJobAsync(rollout, phaseId, jobId);
        }
    }
    // [END clouddeploy_v1_generated_CloudDeploy_RetryJob_async_flattened]
}
