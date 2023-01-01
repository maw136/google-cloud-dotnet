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

namespace Google.Analytics.Data.V1Beta.Snippets
{
    // [START analyticsdata_v1beta_generated_BetaAnalyticsData_CheckCompatibility_sync]
    using Google.Analytics.Data.V1Beta;

    public sealed partial class GeneratedBetaAnalyticsDataClientSnippets
    {
        /// <summary>Snippet for CheckCompatibility</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CheckCompatibilityRequestObject()
        {
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            CheckCompatibilityRequest request = new CheckCompatibilityRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                CompatibilityFilter = Compatibility.Unspecified,
            };
            // Make the request
            CheckCompatibilityResponse response = betaAnalyticsDataClient.CheckCompatibility(request);
        }
    }
    // [END analyticsdata_v1beta_generated_BetaAnalyticsData_CheckCompatibility_sync]
}
