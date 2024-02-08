// Copyright 2024 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START dialogflow_v3_generated_EntityTypes_ImportEntityTypes_async]
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedEntityTypesClientSnippets
    {
        /// <summary>Snippet for ImportEntityTypesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ImportEntityTypesRequestObjectAsync()
        {
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            ImportEntityTypesRequest request = new ImportEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityTypesUri = "",
                MergeOption = ImportEntityTypesRequest.Types.MergeOption.Unspecified,
                TargetEntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
            };
            // Make the request
            Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> response = await entityTypesClient.ImportEntityTypesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportEntityTypesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> retrievedResponse = await entityTypesClient.PollOnceImportEntityTypesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportEntityTypesResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dialogflow_v3_generated_EntityTypes_ImportEntityTypes_async]
}
