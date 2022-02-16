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

namespace Google.Cloud.RecaptchaEnterprise.V1.Snippets
{
    // [START recaptchaenterprise_v1_generated_RecaptchaEnterpriseService_SearchRelatedAccountGroupMemberships_sync_flattened]
    using Google.Api.Gax;
    using Google.Cloud.RecaptchaEnterprise.V1;
    using Google.Protobuf;
    using System;

    public sealed partial class GeneratedRecaptchaEnterpriseServiceClientSnippets
    {
        /// <summary>Snippet for SearchRelatedAccountGroupMemberships</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void SearchRelatedAccountGroupMemberships()
        {
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/relatedaccountgroups/[RELATEDACCOUNTGROUP]";
            ByteString hashedAccountId = ByteString.Empty;
            // Make the request
            PagedEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.SearchRelatedAccountGroupMemberships(parent, hashedAccountId);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RelatedAccountGroupMembership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchRelatedAccountGroupMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END recaptchaenterprise_v1_generated_RecaptchaEnterpriseService_SearchRelatedAccountGroupMemberships_sync_flattened]
}
