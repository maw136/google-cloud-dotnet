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

namespace Google.Cloud.GkeBackup.V1.Snippets
{
    // [START gkebackup_v1_generated_BackupForGKE_GetBackupPlan_sync]
    using Google.Cloud.GkeBackup.V1;

    public sealed partial class GeneratedBackupForGKEClientSnippets
    {
        /// <summary>Snippet for GetBackupPlan</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetBackupPlanRequestObject()
        {
            // Create client
            BackupForGKEClient backupForGKEClient = BackupForGKEClient.Create();
            // Initialize request argument(s)
            GetBackupPlanRequest request = new GetBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
            };
            // Make the request
            BackupPlan response = backupForGKEClient.GetBackupPlan(request);
        }
    }
    // [END gkebackup_v1_generated_BackupForGKE_GetBackupPlan_sync]
}
