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

namespace Google.Cloud.AssuredWorkloads.V1Beta1.Snippets
{
    // [START assuredworkloads_v1beta1_generated_AssuredWorkloadsService_UpdateWorkload_async]
    using Google.Cloud.AssuredWorkloads.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAssuredWorkloadsServiceClientSnippets
    {
        /// <summary>Snippet for UpdateWorkloadAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateWorkloadRequestObjectAsync()
        {
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWorkloadRequest request = new UpdateWorkloadRequest
            {
                Workload = new Workload(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Workload response = await assuredWorkloadsServiceClient.UpdateWorkloadAsync(request);
        }
    }
    // [END assuredworkloads_v1beta1_generated_AssuredWorkloadsService_UpdateWorkload_async]
}
