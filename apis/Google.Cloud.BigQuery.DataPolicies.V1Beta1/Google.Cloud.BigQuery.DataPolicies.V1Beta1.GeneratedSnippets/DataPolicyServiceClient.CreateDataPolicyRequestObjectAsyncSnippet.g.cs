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

namespace Google.Cloud.BigQuery.DataPolicies.V1Beta1.Snippets
{
    // [START bigquerydatapolicy_v1beta1_generated_DataPolicyService_CreateDataPolicy_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.BigQuery.DataPolicies.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataPolicyServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataPolicyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateDataPolicyRequestObjectAsync()
        {
            // Create client
            DataPolicyServiceClient dataPolicyServiceClient = await DataPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataPolicyRequest request = new CreateDataPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataPolicy = new DataPolicy(),
            };
            // Make the request
            DataPolicy response = await dataPolicyServiceClient.CreateDataPolicyAsync(request);
        }
    }
    // [END bigquerydatapolicy_v1beta1_generated_DataPolicyService_CreateDataPolicy_async]
}
