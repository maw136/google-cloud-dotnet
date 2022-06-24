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

namespace Google.Cloud.Recommender.V1.Snippets
{
    // [START recommender_v1_generated_Recommender_UpdateInsightTypeConfig_async_flattened]
    using Google.Cloud.Recommender.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRecommenderClientSnippets
    {
        /// <summary>Snippet for UpdateInsightTypeConfigAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateInsightTypeConfigAsync()
        {
            // Create client
            RecommenderClient recommenderClient = await RecommenderClient.CreateAsync();
            // Initialize request argument(s)
            InsightTypeConfig insightTypeConfig = new InsightTypeConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            InsightTypeConfig response = await recommenderClient.UpdateInsightTypeConfigAsync(insightTypeConfig, updateMask);
        }
    }
    // [END recommender_v1_generated_Recommender_UpdateInsightTypeConfig_async_flattened]
}
