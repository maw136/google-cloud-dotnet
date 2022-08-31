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

namespace Google.Cloud.Dialogflow.V2Beta1.Snippets
{
    // [START dialogflow_v2beta1_generated_ConversationProfiles_CreateConversationProfile_sync_flattened_resourceNames1]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Dialogflow.V2Beta1;

    public sealed partial class GeneratedConversationProfilesClientSnippets
    {
        /// <summary>Snippet for CreateConversationProfile</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateConversationProfileResourceNames1()
        {
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            ConversationProfile conversationProfile = new ConversationProfile();
            // Make the request
            ConversationProfile response = conversationProfilesClient.CreateConversationProfile(parent, conversationProfile);
        }
    }
    // [END dialogflow_v2beta1_generated_ConversationProfiles_CreateConversationProfile_sync_flattened_resourceNames1]
}
