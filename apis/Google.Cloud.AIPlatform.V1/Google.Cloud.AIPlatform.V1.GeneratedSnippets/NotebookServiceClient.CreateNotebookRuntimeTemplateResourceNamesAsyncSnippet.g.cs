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
    // [START aiplatform_v1_generated_NotebookService_CreateNotebookRuntimeTemplate_async_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedNotebookServiceClientSnippets
    {
        /// <summary>Snippet for CreateNotebookRuntimeTemplateAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateNotebookRuntimeTemplateResourceNamesAsync()
        {
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NotebookRuntimeTemplate notebookRuntimeTemplate = new NotebookRuntimeTemplate();
            string notebookRuntimeTemplateId = "";
            // Make the request
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> response = await notebookServiceClient.CreateNotebookRuntimeTemplateAsync(parent, notebookRuntimeTemplate, notebookRuntimeTemplateId);

            // Poll until the returned long-running operation is complete
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NotebookRuntimeTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateNotebookRuntimeTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NotebookRuntimeTemplate retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_NotebookService_CreateNotebookRuntimeTemplate_async_flattened_resourceNames]
}
