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

namespace Google.Cloud.Bigtable.Admin.V2.Snippets
{
    // [START bigtableadmin_v2_generated_BigtableTableAdmin_SnapshotTable_async_flattened]
    using Google.Cloud.Bigtable.Admin.V2;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBigtableTableAdminClientSnippets
    {
        /// <summary>Snippet for SnapshotTableAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task SnapshotTableAsync()
        {
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            string cluster = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            string snapshotId = "";
            string description = "";
            // Make the request
            Operation<Snapshot, SnapshotTableMetadata> response = await bigtableTableAdminClient.SnapshotTableAsync(name, cluster, snapshotId, description);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, SnapshotTableMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, SnapshotTableMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceSnapshotTableAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END bigtableadmin_v2_generated_BigtableTableAdmin_SnapshotTable_async_flattened]
}
