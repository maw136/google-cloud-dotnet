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

namespace Google.Cloud.Dialogflow.Cx.V3.Snippets
{
    // [START dialogflow_v3_generated_TestCases_RunTestCase_async]
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedTestCasesClientSnippets
    {
        /// <summary>Snippet for RunTestCaseAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task RunTestCaseRequestObjectAsync()
        {
            // Create client
            TestCasesClient testCasesClient = await TestCasesClient.CreateAsync();
            // Initialize request argument(s)
            RunTestCaseRequest request = new RunTestCaseRequest
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            Operation<RunTestCaseResponse, RunTestCaseMetadata> response = await testCasesClient.RunTestCaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RunTestCaseResponse, RunTestCaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunTestCaseResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunTestCaseResponse, RunTestCaseMetadata> retrievedResponse = await testCasesClient.PollOnceRunTestCaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunTestCaseResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dialogflow_v3_generated_TestCases_RunTestCase_async]
}
