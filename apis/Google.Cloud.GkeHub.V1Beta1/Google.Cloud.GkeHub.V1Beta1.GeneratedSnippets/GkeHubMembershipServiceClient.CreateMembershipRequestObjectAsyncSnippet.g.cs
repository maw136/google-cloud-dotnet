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

namespace Google.Cloud.GkeHub.V1Beta1.Snippets
{
    // [START gkehub_v1beta1_generated_GkeHubMembershipService_CreateMembership_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.GkeHub.V1Beta1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGkeHubMembershipServiceClientSnippets
    {
        /// <summary>Snippet for CreateMembershipAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateMembershipRequestObjectAsync()
        {
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = await GkeHubMembershipServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMembershipRequest request = new CreateMembershipRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MembershipId = "",
                Resource = new Membership(),
                RequestId = "",
            };
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubMembershipServiceClient.CreateMembershipAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubMembershipServiceClient.PollOnceCreateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gkehub_v1beta1_generated_GkeHubMembershipService_CreateMembership_async]
}
