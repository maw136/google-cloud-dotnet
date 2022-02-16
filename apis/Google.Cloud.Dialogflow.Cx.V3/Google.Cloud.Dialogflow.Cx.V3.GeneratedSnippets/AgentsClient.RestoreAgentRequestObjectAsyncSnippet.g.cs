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
    // [START dialogflow_v3_generated_Agents_RestoreAgent_async]
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAgentsClientSnippets
    {
        /// <summary>Snippet for RestoreAgentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task RestoreAgentRequestObjectAsync()
        {
            // Create client
            AgentsClient agentsClient = await AgentsClient.CreateAsync();
            // Initialize request argument(s)
            RestoreAgentRequest request = new RestoreAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                AgentUri = "",
                RestoreOption = RestoreAgentRequest.Types.RestoreOption.Unspecified,
            };
            // Make the request
            Operation<Empty, Struct> response = await agentsClient.RestoreAgentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await agentsClient.PollOnceRestoreAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dialogflow_v3_generated_Agents_RestoreAgent_async]
}
