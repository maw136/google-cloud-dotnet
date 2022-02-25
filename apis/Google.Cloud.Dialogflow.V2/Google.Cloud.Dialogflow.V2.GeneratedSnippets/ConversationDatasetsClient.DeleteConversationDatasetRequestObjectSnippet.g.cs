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

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    // [START dialogflow_v2_generated_ConversationDatasets_DeleteConversationDataset_sync]
    using Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedConversationDatasetsClientSnippets
    {
        /// <summary>Snippet for DeleteConversationDataset</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeleteConversationDatasetRequestObject()
        {
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            DeleteConversationDatasetRequest request = new DeleteConversationDatasetRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
            };
            // Make the request
            Operation<Empty, DeleteConversationDatasetOperationMetadata> response = conversationDatasetsClient.DeleteConversationDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteConversationDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteConversationDatasetOperationMetadata> retrievedResponse = conversationDatasetsClient.PollOnceDeleteConversationDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dialogflow_v2_generated_ConversationDatasets_DeleteConversationDataset_sync]
}
