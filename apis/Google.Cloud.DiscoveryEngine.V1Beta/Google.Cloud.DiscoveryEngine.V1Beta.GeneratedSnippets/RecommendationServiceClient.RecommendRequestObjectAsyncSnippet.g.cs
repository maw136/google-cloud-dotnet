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

namespace Google.Cloud.DiscoveryEngine.V1Beta.Snippets
{
    // [START discoveryengine_v1beta_generated_RecommendationService_Recommend_async]
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRecommendationServiceClientSnippets
    {
        /// <summary>Snippet for RecommendAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task RecommendRequestObjectAsync()
        {
            // Create client
            RecommendationServiceClient recommendationServiceClient = await RecommendationServiceClient.CreateAsync();
            // Initialize request argument(s)
            RecommendRequest request = new RecommendRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
                UserEvent = new UserEvent(),
                PageSize = 0,
                Filter = "",
                ValidateOnly = false,
                Params = { { "", new Value() }, },
            };
            // Make the request
            RecommendResponse response = await recommendationServiceClient.RecommendAsync(request);
        }
    }
    // [END discoveryengine_v1beta_generated_RecommendationService_Recommend_async]
}
