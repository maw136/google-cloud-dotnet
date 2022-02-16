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

namespace Google.Cloud.OsConfig.V1.Snippets
{
    // [START osconfig_v1_generated_OsConfigService_ExecutePatchJob_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.OsConfig.V1;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedOsConfigServiceClientSnippets
    {
        /// <summary>Snippet for ExecutePatchJob</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ExecutePatchJobRequestObject()
        {
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ExecutePatchJobRequest request = new ExecutePatchJobRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Description = "",
                PatchConfig = new PatchConfig(),
                Duration = new Duration(),
                DryRun = false,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "",
                Rollout = new PatchRollout(),
            };
            // Make the request
            PatchJob response = osConfigServiceClient.ExecutePatchJob(request);
        }
    }
    // [END osconfig_v1_generated_OsConfigService_ExecutePatchJob_sync]
}
