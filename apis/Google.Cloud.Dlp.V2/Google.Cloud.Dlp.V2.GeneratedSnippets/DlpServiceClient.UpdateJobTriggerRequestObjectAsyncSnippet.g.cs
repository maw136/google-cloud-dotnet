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

namespace Google.Cloud.Dlp.V2.Snippets
{
    // [START dlp_v2_generated_DlpService_UpdateJobTrigger_async]
    using Google.Cloud.Dlp.V2;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDlpServiceClientSnippets
    {
        /// <summary>Snippet for UpdateJobTriggerAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateJobTriggerRequestObjectAsync()
        {
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                JobTrigger = new JobTrigger(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            JobTrigger response = await dlpServiceClient.UpdateJobTriggerAsync(request);
        }
    }
    // [END dlp_v2_generated_DlpService_UpdateJobTrigger_async]
}
