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
    // [START places_v1_generated_Places_SearchText_sync]
    using Google.Maps.Places.V1;

    public sealed partial class GeneratedPlacesClientSnippets
    {
        /// <summary>Snippet for SearchText</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void SearchTextRequestObject()
        {
            // Create client
            PlacesClient placesClient = PlacesClient.Create();
            // Initialize request argument(s)
            SearchTextRequest request = new SearchTextRequest
            {
                TextQuery = "",
                LanguageCode = "",
                RegionCode = "",
                RankPreference = SearchTextRequest.Types.RankPreference.Unspecified,
                IncludedType = "",
                OpenNow = false,
                MinRating = 0,
                MaxResultCount = 0,
                PriceLevels =
                {
                    PriceLevel.Unspecified,
                },
                StrictTypeFiltering = false,
                LocationBias = new SearchTextRequest.Types.LocationBias(),
                LocationRestriction = new SearchTextRequest.Types.LocationRestriction(),
            };
            // Make the request
            SearchTextResponse response = placesClient.SearchText(request);
        }
    }
    // [END places_v1_generated_Places_SearchText_sync]
}
