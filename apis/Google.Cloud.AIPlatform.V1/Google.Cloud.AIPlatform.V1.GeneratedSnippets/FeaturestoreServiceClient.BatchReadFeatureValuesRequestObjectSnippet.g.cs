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

namespace Google.Cloud.AIPlatform.V1.Snippets
{
    // [START aiplatform_v1_generated_FeaturestoreService_BatchReadFeatureValues_sync]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedFeaturestoreServiceClientSnippets
    {
        /// <summary>Snippet for BatchReadFeatureValues</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void BatchReadFeatureValuesRequestObject()
        {
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            BatchReadFeatureValuesRequest request = new BatchReadFeatureValuesRequest
            {
                FeaturestoreAsFeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                CsvReadInstances = new CsvSource(),
                Destination = new FeatureValueDestination(),
                EntityTypeSpecs =
                {
                    new BatchReadFeatureValuesRequest.Types.EntityTypeSpec(),
                },
                PassThroughFields =
                {
                    new BatchReadFeatureValuesRequest.Types.PassThroughField(),
                },
                StartTime = new Timestamp(),
            };
            // Make the request
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> response = featurestoreServiceClient.BatchReadFeatureValues(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchReadFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceBatchReadFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchReadFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_FeaturestoreService_BatchReadFeatureValues_sync]
}
