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

namespace Google.Cloud.AssuredWorkloads.V1.Snippets
{
    // [START assuredworkloads_v1_generated_AssuredWorkloadsService_GetViolation_async]
    using Google.Cloud.AssuredWorkloads.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAssuredWorkloadsServiceClientSnippets
    {
        /// <summary>Snippet for GetViolationAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetViolationRequestObjectAsync()
        {
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetViolationRequest request = new GetViolationRequest
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
            };
            // Make the request
            Violation response = await assuredWorkloadsServiceClient.GetViolationAsync(request);
        }
    }
    // [END assuredworkloads_v1_generated_AssuredWorkloadsService_GetViolation_async]
}
