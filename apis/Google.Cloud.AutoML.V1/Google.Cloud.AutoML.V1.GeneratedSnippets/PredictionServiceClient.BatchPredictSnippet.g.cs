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

namespace Google.Cloud.AutoML.V1.Snippets
{
    // [START automl_v1_generated_PredictionService_BatchPredict_sync_flattened]
    using Google.Cloud.AutoML.V1;
    using Google.LongRunning;
    using System.Collections.Generic;

    public sealed partial class GeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for BatchPredict</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void BatchPredict()
        {
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            BatchPredictInputConfig inputConfig = new BatchPredictInputConfig();
            BatchPredictOutputConfig outputConfig = new BatchPredictOutputConfig();
            IDictionary<string, string> @params = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            Operation<BatchPredictResult, OperationMetadata> response = predictionServiceClient.BatchPredict(name, inputConfig, outputConfig, @params);

            // Poll until the returned long-running operation is complete
            Operation<BatchPredictResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchPredictResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchPredictResult, OperationMetadata> retrievedResponse = predictionServiceClient.PollOnceBatchPredict(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchPredictResult retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END automl_v1_generated_PredictionService_BatchPredict_sync_flattened]
}
