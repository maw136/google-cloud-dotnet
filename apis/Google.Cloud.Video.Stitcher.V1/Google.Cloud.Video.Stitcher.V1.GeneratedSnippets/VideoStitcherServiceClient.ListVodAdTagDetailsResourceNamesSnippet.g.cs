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

namespace Google.Cloud.Video.Stitcher.V1.Snippets
{
    // [START videostitcher_v1_generated_VideoStitcherService_ListVodAdTagDetails_sync_flattened_resourceNames]
    using Google.Api.Gax;
    using Google.Cloud.Video.Stitcher.V1;
    using System;

    public sealed partial class GeneratedVideoStitcherServiceClientSnippets
    {
        /// <summary>Snippet for ListVodAdTagDetails</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ListVodAdTagDetailsResourceNames()
        {
            // Create client
            VideoStitcherServiceClient videoStitcherServiceClient = VideoStitcherServiceClient.Create();
            // Initialize request argument(s)
            VodSessionName parent = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]");
            // Make the request
            PagedEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> response = videoStitcherServiceClient.ListVodAdTagDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VodAdTagDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVodAdTagDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VodAdTagDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VodAdTagDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VodAdTagDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END videostitcher_v1_generated_VideoStitcherService_ListVodAdTagDetails_sync_flattened_resourceNames]
}
