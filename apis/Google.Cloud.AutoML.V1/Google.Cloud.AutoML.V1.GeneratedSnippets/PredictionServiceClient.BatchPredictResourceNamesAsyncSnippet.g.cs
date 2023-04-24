// Copyright 2023 Google LLC
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
    // [START automl_v1_generated_PredictionService_BatchPredict_async_flattened_resourceNames]
    using Google.Cloud.AutoML.V1;
    using Google.LongRunning;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for BatchPredictAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task BatchPredictResourceNamesAsync()
        {
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            BatchPredictInputConfig inputConfig = new BatchPredictInputConfig();
            BatchPredictOutputConfig outputConfig = new BatchPredictOutputConfig();
            IDictionary<string, string> @params = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            Operation<BatchPredictResult, OperationMetadata> response = await predictionServiceClient.BatchPredictAsync(name, inputConfig, outputConfig, @params);

            // Poll until the returned long-running operation is complete
            Operation<BatchPredictResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchPredictResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchPredictResult, OperationMetadata> retrievedResponse = await predictionServiceClient.PollOnceBatchPredictAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchPredictResult retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END automl_v1_generated_PredictionService_BatchPredict_async_flattened_resourceNames]
}
