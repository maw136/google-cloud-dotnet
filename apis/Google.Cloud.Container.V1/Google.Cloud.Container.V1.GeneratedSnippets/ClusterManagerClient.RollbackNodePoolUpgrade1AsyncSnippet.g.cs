// Copyright 2023 Google LLC
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

namespace Google.Cloud.Container.V1.Snippets
{
    // [START container_v1_generated_ClusterManager_RollbackNodePoolUpgrade_async_flattened1]
    using Google.Cloud.Container.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedClusterManagerClientSnippets
    {
        /// <summary>Snippet for RollbackNodePoolUpgradeAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task RollbackNodePoolUpgrade1Async()
        {
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string zone = "";
            string clusterId = "";
            string nodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation response = await clusterManagerClient.RollbackNodePoolUpgradeAsync(projectId, zone, clusterId, nodePoolId);
#pragma warning restore CS0612
        }
    }
    // [END container_v1_generated_ClusterManager_RollbackNodePoolUpgrade_async_flattened1]
}
