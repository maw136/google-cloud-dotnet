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

namespace Google.Cloud.EssentialContacts.V1.Snippets
{
    // [START essentialcontacts_v1_generated_EssentialContactsService_SendTestMessage_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.EssentialContacts.V1;

    public sealed partial class GeneratedEssentialContactsServiceClientSnippets
    {
        /// <summary>Snippet for SendTestMessage</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void SendTestMessageRequestObject()
        {
            // Create client
            EssentialContactsServiceClient essentialContactsServiceClient = EssentialContactsServiceClient.Create();
            // Initialize request argument(s)
            SendTestMessageRequest request = new SendTestMessageRequest
            {
                ContactsAsContactNames =
                {
                    ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                },
                ResourceAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NotificationCategory = NotificationCategory.Unspecified,
            };
            // Make the request
            essentialContactsServiceClient.SendTestMessage(request);
        }
    }
    // [END essentialcontacts_v1_generated_EssentialContactsService_SendTestMessage_sync]
}
