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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Kms.Inventory.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedKeyTrackingServiceClientSnippets
    {
        /// <summary>Snippet for GetProtectedResourcesSummary</summary>
        public void GetProtectedResourcesSummaryRequestObject()
        {
            // Snippet: GetProtectedResourcesSummary(GetProtectedResourcesSummaryRequest, CallSettings)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = KeyTrackingServiceClient.Create();
            // Initialize request argument(s)
            GetProtectedResourcesSummaryRequest request = new GetProtectedResourcesSummaryRequest
            {
                ProtectedResourcesSummaryName = ProtectedResourcesSummaryName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            ProtectedResourcesSummary response = keyTrackingServiceClient.GetProtectedResourcesSummary(request);
            // End snippet
        }

        /// <summary>Snippet for GetProtectedResourcesSummaryAsync</summary>
        public async Task GetProtectedResourcesSummaryRequestObjectAsync()
        {
            // Snippet: GetProtectedResourcesSummaryAsync(GetProtectedResourcesSummaryRequest, CallSettings)
            // Additional: GetProtectedResourcesSummaryAsync(GetProtectedResourcesSummaryRequest, CancellationToken)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = await KeyTrackingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProtectedResourcesSummaryRequest request = new GetProtectedResourcesSummaryRequest
            {
                ProtectedResourcesSummaryName = ProtectedResourcesSummaryName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            ProtectedResourcesSummary response = await keyTrackingServiceClient.GetProtectedResourcesSummaryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProtectedResourcesSummary</summary>
        public void GetProtectedResourcesSummary()
        {
            // Snippet: GetProtectedResourcesSummary(string, CallSettings)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = KeyTrackingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/protectedResourcesSummary";
            // Make the request
            ProtectedResourcesSummary response = keyTrackingServiceClient.GetProtectedResourcesSummary(name);
            // End snippet
        }

        /// <summary>Snippet for GetProtectedResourcesSummaryAsync</summary>
        public async Task GetProtectedResourcesSummaryAsync()
        {
            // Snippet: GetProtectedResourcesSummaryAsync(string, CallSettings)
            // Additional: GetProtectedResourcesSummaryAsync(string, CancellationToken)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = await KeyTrackingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/protectedResourcesSummary";
            // Make the request
            ProtectedResourcesSummary response = await keyTrackingServiceClient.GetProtectedResourcesSummaryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProtectedResourcesSummary</summary>
        public void GetProtectedResourcesSummaryResourceNames()
        {
            // Snippet: GetProtectedResourcesSummary(ProtectedResourcesSummaryName, CallSettings)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = KeyTrackingServiceClient.Create();
            // Initialize request argument(s)
            ProtectedResourcesSummaryName name = ProtectedResourcesSummaryName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            // Make the request
            ProtectedResourcesSummary response = keyTrackingServiceClient.GetProtectedResourcesSummary(name);
            // End snippet
        }

        /// <summary>Snippet for GetProtectedResourcesSummaryAsync</summary>
        public async Task GetProtectedResourcesSummaryResourceNamesAsync()
        {
            // Snippet: GetProtectedResourcesSummaryAsync(ProtectedResourcesSummaryName, CallSettings)
            // Additional: GetProtectedResourcesSummaryAsync(ProtectedResourcesSummaryName, CancellationToken)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = await KeyTrackingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProtectedResourcesSummaryName name = ProtectedResourcesSummaryName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            // Make the request
            ProtectedResourcesSummary response = await keyTrackingServiceClient.GetProtectedResourcesSummaryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SearchProtectedResources</summary>
        public void SearchProtectedResourcesRequestObject()
        {
            // Snippet: SearchProtectedResources(SearchProtectedResourcesRequest, CallSettings)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = KeyTrackingServiceClient.Create();
            // Initialize request argument(s)
            SearchProtectedResourcesRequest request = new SearchProtectedResourcesRequest
            {
                CryptoKeyAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ScopeAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                ResourceTypes = { "", },
            };
            // Make the request
            PagedEnumerable<SearchProtectedResourcesResponse, ProtectedResource> response = keyTrackingServiceClient.SearchProtectedResources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProtectedResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchProtectedResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProtectedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProtectedResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProtectedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchProtectedResourcesAsync</summary>
        public async Task SearchProtectedResourcesRequestObjectAsync()
        {
            // Snippet: SearchProtectedResourcesAsync(SearchProtectedResourcesRequest, CallSettings)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = await KeyTrackingServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchProtectedResourcesRequest request = new SearchProtectedResourcesRequest
            {
                CryptoKeyAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ScopeAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                ResourceTypes = { "", },
            };
            // Make the request
            PagedAsyncEnumerable<SearchProtectedResourcesResponse, ProtectedResource> response = keyTrackingServiceClient.SearchProtectedResourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProtectedResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchProtectedResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProtectedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProtectedResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProtectedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchProtectedResources</summary>
        public void SearchProtectedResources()
        {
            // Snippet: SearchProtectedResources(string, string, string, int?, CallSettings)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = KeyTrackingServiceClient.Create();
            // Initialize request argument(s)
            string scope = "organizations/[ORGANIZATION]";
            string cryptoKey = "a/wildcard/resource";
            // Make the request
            PagedEnumerable<SearchProtectedResourcesResponse, ProtectedResource> response = keyTrackingServiceClient.SearchProtectedResources(scope, cryptoKey);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProtectedResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchProtectedResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProtectedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProtectedResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProtectedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchProtectedResourcesAsync</summary>
        public async Task SearchProtectedResourcesAsync()
        {
            // Snippet: SearchProtectedResourcesAsync(string, string, string, int?, CallSettings)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = await KeyTrackingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "organizations/[ORGANIZATION]";
            string cryptoKey = "a/wildcard/resource";
            // Make the request
            PagedAsyncEnumerable<SearchProtectedResourcesResponse, ProtectedResource> response = keyTrackingServiceClient.SearchProtectedResourcesAsync(scope, cryptoKey);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProtectedResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchProtectedResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProtectedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProtectedResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProtectedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchProtectedResources</summary>
        public void SearchProtectedResourcesResourceNames()
        {
            // Snippet: SearchProtectedResources(OrganizationName, IResourceName, string, int?, CallSettings)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = KeyTrackingServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName scope = OrganizationName.FromOrganization("[ORGANIZATION]");
            IResourceName cryptoKey = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<SearchProtectedResourcesResponse, ProtectedResource> response = keyTrackingServiceClient.SearchProtectedResources(scope, cryptoKey);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProtectedResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchProtectedResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProtectedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProtectedResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProtectedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchProtectedResourcesAsync</summary>
        public async Task SearchProtectedResourcesResourceNamesAsync()
        {
            // Snippet: SearchProtectedResourcesAsync(OrganizationName, IResourceName, string, int?, CallSettings)
            // Create client
            KeyTrackingServiceClient keyTrackingServiceClient = await KeyTrackingServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName scope = OrganizationName.FromOrganization("[ORGANIZATION]");
            IResourceName cryptoKey = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<SearchProtectedResourcesResponse, ProtectedResource> response = keyTrackingServiceClient.SearchProtectedResourcesAsync(scope, cryptoKey);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProtectedResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchProtectedResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProtectedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProtectedResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProtectedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
