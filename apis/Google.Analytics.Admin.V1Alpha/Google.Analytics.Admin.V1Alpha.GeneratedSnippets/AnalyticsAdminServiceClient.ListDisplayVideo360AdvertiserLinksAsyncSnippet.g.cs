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

namespace Google.Analytics.Admin.V1Alpha.Snippets
{
    // [START analyticsadmin_v1alpha_generated_AnalyticsAdminService_ListDisplayVideo360AdvertiserLinks_async_flattened]
    using Google.Analytics.Admin.V1Alpha;
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAnalyticsAdminServiceClientSnippets
    {
        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinksAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ListDisplayVideo360AdvertiserLinksAsync()
        {
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DisplayVideo360AdvertiserLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDisplayVideo360AdvertiserLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END analyticsadmin_v1alpha_generated_AnalyticsAdminService_ListDisplayVideo360AdvertiserLinks_async_flattened]
}
