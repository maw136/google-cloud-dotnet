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

namespace Google.Cloud.ContactCenterInsights.V1.Snippets
{
    // [START contactcenterinsights_v1_generated_ContactCenterInsights_CreateIssueModel_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ContactCenterInsights.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedContactCenterInsightsClientSnippets
    {
        /// <summary>Snippet for CreateIssueModelAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateIssueModelRequestObjectAsync()
        {
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            CreateIssueModelRequest request = new CreateIssueModelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                IssueModel = new IssueModel(),
            };
            // Make the request
            Operation<IssueModel, CreateIssueModelMetadata> response = await contactCenterInsightsClient.CreateIssueModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<IssueModel, CreateIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IssueModel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueModel, CreateIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceCreateIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueModel retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END contactcenterinsights_v1_generated_ContactCenterInsights_CreateIssueModel_async]
}
