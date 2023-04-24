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

namespace GoogleCSharpSnippets
{
    // [START storageinsights_v1_generated_StorageInsights_GetReportConfig_async_flattened_resourceNames]
    using Google.Cloud.StorageInsights.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedStorageInsightsClientSnippets
    {
        /// <summary>Snippet for GetReportConfigAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task GetReportConfigResourceNamesAsync()
        {
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ReportConfigName name = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            ReportConfig response = await storageInsightsClient.GetReportConfigAsync(name);
        }
    }
    // [END storageinsights_v1_generated_StorageInsights_GetReportConfig_async_flattened_resourceNames]
}
