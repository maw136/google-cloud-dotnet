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

#pragma warning disable CS8981

namespace Google.Cloud.Dataplex.V1.Snippets
{
    // [START dataplex_v1_generated_DataplexService_CreateEnvironment_async]
    using Google.LongRunning;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    public sealed partial class GeneratedDataplexServiceClientSnippets
    {
        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateEnvironmentRequestObjectAsync()
        {
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEnvironmentRequest request = new CreateEnvironmentRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                EnvironmentId = "",
                Environment = new Environment(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Environment, OperationMetadata> response = await dataplexServiceClient.CreateEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Environment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Environment, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Environment retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dataplex_v1_generated_DataplexService_CreateEnvironment_async]
}
