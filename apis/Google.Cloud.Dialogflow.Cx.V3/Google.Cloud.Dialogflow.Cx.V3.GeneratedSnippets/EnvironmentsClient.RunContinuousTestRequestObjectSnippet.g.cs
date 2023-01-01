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

namespace Google.Cloud.Dialogflow.Cx.V3.Snippets
{
    // [START dialogflow_v3_generated_Environments_RunContinuousTest_sync]
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.LongRunning;

    public sealed partial class GeneratedEnvironmentsClientSnippets
    {
        /// <summary>Snippet for RunContinuousTest</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void RunContinuousTestRequestObject()
        {
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            RunContinuousTestRequest request = new RunContinuousTestRequest
            {
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            Operation<RunContinuousTestResponse, RunContinuousTestMetadata> response = environmentsClient.RunContinuousTest(request);

            // Poll until the returned long-running operation is complete
            Operation<RunContinuousTestResponse, RunContinuousTestMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunContinuousTestResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunContinuousTestResponse, RunContinuousTestMetadata> retrievedResponse = environmentsClient.PollOnceRunContinuousTest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunContinuousTestResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dialogflow_v3_generated_Environments_RunContinuousTest_sync]
}
