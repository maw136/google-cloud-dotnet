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

namespace GoogleCSharpSnippets
{
    // [START bigtableadmin_v2_generated_BigtableInstanceAdmin_UpdateCluster_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Bigtable.Admin.V2;
    using Google.LongRunning;

    public sealed partial class GeneratedBigtableInstanceAdminClientSnippets
    {
        /// <summary>Snippet for UpdateCluster</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void UpdateClusterRequestObject()
        {
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            Cluster request = new Cluster
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                State = Cluster.Types.State.NotKnown,
                ServeNodes = 0,
                DefaultStorageType = StorageType.Unspecified,
                EncryptionConfig = new Cluster.Types.EncryptionConfig(),
                ClusterConfig = new Cluster.Types.ClusterConfig(),
            };
            // Make the request
            Operation<Cluster, UpdateClusterMetadata> response = bigtableInstanceAdminClient.UpdateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, UpdateClusterMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, UpdateClusterMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOnceUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END bigtableadmin_v2_generated_BigtableInstanceAdmin_UpdateCluster_sync]
}
