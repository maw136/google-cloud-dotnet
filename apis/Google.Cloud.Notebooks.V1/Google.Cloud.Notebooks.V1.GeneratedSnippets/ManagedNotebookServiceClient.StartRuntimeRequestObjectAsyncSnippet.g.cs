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

namespace Google.Cloud.Notebooks.V1.Snippets
{
    // [START notebooks_v1_generated_ManagedNotebookService_StartRuntime_async]
    using Google.Cloud.Notebooks.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedManagedNotebookServiceClientSnippets
    {
        /// <summary>Snippet for StartRuntimeAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task StartRuntimeRequestObjectAsync()
        {
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartRuntimeRequest request = new StartRuntimeRequest { Name = "", };
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.StartRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceStartRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END notebooks_v1_generated_ManagedNotebookService_StartRuntime_async]
}
