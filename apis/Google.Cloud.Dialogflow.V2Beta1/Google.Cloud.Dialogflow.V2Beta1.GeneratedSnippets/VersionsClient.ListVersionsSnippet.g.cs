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

#pragma warning disable CS8981

namespace Google.Cloud.Dialogflow.V2Beta1.Snippets
{
    // [START dialogflow_v2beta1_generated_Versions_ListVersions_sync_flattened]
    using Google.Api.Gax;
    using System;
    using gcdv = Google.Cloud.Dialogflow.V2Beta1;

    public sealed partial class GeneratedVersionsClientSnippets
    {
        /// <summary>Snippet for ListVersions</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void ListVersions()
        {
            // Create client
            VersionsClient versionsClient = VersionsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            // Make the request
            PagedEnumerable<ListVersionsResponse, gcdv::Version> response = versionsClient.ListVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Version> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END dialogflow_v2beta1_generated_Versions_ListVersions_sync_flattened]
}
