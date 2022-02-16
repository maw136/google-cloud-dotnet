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
    // [START dialogflow_v2_generated_KnowledgeBases_DeleteKnowledgeBase_async]
    using Google.Cloud.Dialogflow.V2;
    using System.Threading.Tasks;

    public sealed partial class GeneratedKnowledgeBasesClientSnippets
    {
        /// <summary>Snippet for DeleteKnowledgeBaseAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task DeleteKnowledgeBaseRequestObjectAsync()
        {
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteKnowledgeBaseRequest request = new DeleteKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                Force = false,
            };
            // Make the request
            await knowledgeBasesClient.DeleteKnowledgeBaseAsync(request);
        }
    }
    // [END dialogflow_v2_generated_KnowledgeBases_DeleteKnowledgeBase_async]
}
