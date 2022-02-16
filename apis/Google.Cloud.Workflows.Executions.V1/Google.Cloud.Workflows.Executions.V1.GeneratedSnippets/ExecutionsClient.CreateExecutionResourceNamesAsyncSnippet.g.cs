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

namespace Google.Cloud.Workflows.Executions.V1.Snippets
{
    // [START workflowexecutions_v1_generated_Executions_CreateExecution_async_flattened_resourceNames]
    using Google.Cloud.Workflows.Common.V1;
    using Google.Cloud.Workflows.Executions.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedExecutionsClientSnippets
    {
        /// <summary>Snippet for CreateExecutionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateExecutionResourceNamesAsync()
        {
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowName parent = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            Execution execution = new Execution();
            // Make the request
            Execution response = await executionsClient.CreateExecutionAsync(parent, execution);
        }
    }
    // [END workflowexecutions_v1_generated_Executions_CreateExecution_async_flattened_resourceNames]
}
