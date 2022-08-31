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
    // [START dialogflow_v2beta1_generated_Documents_ReloadDocument_async_flattened_resourceNames]
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDocumentsClientSnippets
    {
        /// <summary>Snippet for ReloadDocumentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ReloadDocumentResourceNamesAsync()
        {
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]");
            GcsSource gcsSource = new GcsSource();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = await documentsClient.ReloadDocumentAsync(name, gcsSource);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceReloadDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dialogflow_v2beta1_generated_Documents_ReloadDocument_async_flattened_resourceNames]
}
