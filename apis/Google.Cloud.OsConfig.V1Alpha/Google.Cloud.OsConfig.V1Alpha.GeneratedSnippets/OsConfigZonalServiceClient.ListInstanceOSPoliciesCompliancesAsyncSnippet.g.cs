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

namespace Google.Cloud.OsConfig.V1Alpha.Snippets
{
    // [START osconfig_v1alpha_generated_OsConfigZonalService_ListInstanceOSPoliciesCompliances_async_flattened]
    using Google.Api.Gax;
    using Google.Cloud.OsConfig.V1Alpha;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public sealed partial class GeneratedOsConfigZonalServiceClientSnippets
    {
        /// <summary>Snippet for ListInstanceOSPoliciesCompliancesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ListInstanceOSPoliciesCompliancesAsync()
        {
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> response = osConfigZonalServiceClient.ListInstanceOSPoliciesCompliancesAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((InstanceOSPoliciesCompliance item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListInstanceOSPoliciesCompliancesResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (InstanceOSPoliciesCompliance item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<InstanceOSPoliciesCompliance> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (InstanceOSPoliciesCompliance item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END osconfig_v1alpha_generated_OsConfigZonalService_ListInstanceOSPoliciesCompliances_async_flattened]
}
