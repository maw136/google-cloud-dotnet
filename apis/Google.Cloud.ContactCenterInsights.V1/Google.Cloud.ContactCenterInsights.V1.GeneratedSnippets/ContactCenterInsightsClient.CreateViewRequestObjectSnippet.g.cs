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
    // [START contactcenterinsights_v1_generated_ContactCenterInsights_CreateView_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ContactCenterInsights.V1;

    public sealed partial class GeneratedContactCenterInsightsClientSnippets
    {
        /// <summary>Snippet for CreateView</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateViewRequestObject()
        {
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            CreateViewRequest request = new CreateViewRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                View = new View(),
            };
            // Make the request
            View response = contactCenterInsightsClient.CreateView(request);
        }
    }
    // [END contactcenterinsights_v1_generated_ContactCenterInsights_CreateView_sync]
}
