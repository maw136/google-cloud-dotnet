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

namespace Google.Cloud.VMMigration.V1.Snippets
{
    // [START vmmigration_v1_generated_VmMigration_StartMigration_sync_flattened]
    using Google.Cloud.VMMigration.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedVmMigrationClientSnippets
    {
        /// <summary>Snippet for StartMigration</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void StartMigration()
        {
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            string migratingVm = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/migratingVms/[MIGRATING_VM]";
            // Make the request
            Operation<StartMigrationResponse, OperationMetadata> response = vmMigrationClient.StartMigration(migratingVm);

            // Poll until the returned long-running operation is complete
            Operation<StartMigrationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartMigrationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartMigrationResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceStartMigration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartMigrationResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END vmmigration_v1_generated_VmMigration_StartMigration_sync_flattened]
}
