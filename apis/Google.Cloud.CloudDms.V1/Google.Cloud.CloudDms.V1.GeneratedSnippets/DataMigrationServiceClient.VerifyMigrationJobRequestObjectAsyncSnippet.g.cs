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

namespace Google.Cloud.CloudDms.V1.Snippets
{
    // [START datamigration_v1_generated_DataMigrationService_VerifyMigrationJob_async]
    using Google.Cloud.CloudDms.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataMigrationServiceClientSnippets
    {
        /// <summary>Snippet for VerifyMigrationJobAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task VerifyMigrationJobRequestObjectAsync()
        {
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            VerifyMigrationJobRequest request = new VerifyMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.VerifyMigrationJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceVerifyMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END datamigration_v1_generated_DataMigrationService_VerifyMigrationJob_async]
}
