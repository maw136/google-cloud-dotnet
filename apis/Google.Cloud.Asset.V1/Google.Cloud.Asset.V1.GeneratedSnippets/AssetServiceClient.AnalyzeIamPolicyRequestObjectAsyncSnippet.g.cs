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

namespace Google.Cloud.Asset.V1.Snippets
{
    // [START cloudasset_v1_generated_AssetService_AnalyzeIamPolicy_async]
    using Google.Cloud.Asset.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAssetServiceClientSnippets
    {
        /// <summary>Snippet for AnalyzeIamPolicyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task AnalyzeIamPolicyRequestObjectAsync()
        {
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeIamPolicyRequest request = new AnalyzeIamPolicyRequest
            {
                AnalysisQuery = new IamPolicyAnalysisQuery(),
                ExecutionTimeout = new Duration(),
                SavedAnalysisQuery = "",
            };
            // Make the request
            AnalyzeIamPolicyResponse response = await assetServiceClient.AnalyzeIamPolicyAsync(request);
        }
    }
    // [END cloudasset_v1_generated_AssetService_AnalyzeIamPolicy_async]
}
