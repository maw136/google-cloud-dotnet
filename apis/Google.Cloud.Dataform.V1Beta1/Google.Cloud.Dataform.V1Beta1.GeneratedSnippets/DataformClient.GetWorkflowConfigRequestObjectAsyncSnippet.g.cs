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
    // [START dataform_v1beta1_generated_Dataform_GetWorkflowConfig_async]
    using Google.Cloud.Dataform.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataformClientSnippets
    {
        /// <summary>Snippet for GetWorkflowConfigAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task GetWorkflowConfigRequestObjectAsync()
        {
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkflowConfigRequest request = new GetWorkflowConfigRequest
            {
                WorkflowConfigName = WorkflowConfigName.FromProjectLocationRepositoryWorkflowConfig("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_CONFIG]"),
            };
            // Make the request
            WorkflowConfig response = await dataformClient.GetWorkflowConfigAsync(request);
        }
    }
    // [END dataform_v1beta1_generated_Dataform_GetWorkflowConfig_async]
}
