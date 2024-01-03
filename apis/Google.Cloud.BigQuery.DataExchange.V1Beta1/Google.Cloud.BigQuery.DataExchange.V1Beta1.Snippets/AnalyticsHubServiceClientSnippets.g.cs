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
    using Google.Cloud.BigQuery.DataExchange.V1Beta1;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAnalyticsHubServiceClientSnippets
    {
        /// <summary>Snippet for ListDataExchanges</summary>
        public void ListDataExchangesRequestObject()
        {
            // Snippet: ListDataExchanges(ListDataExchangesRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            ListDataExchangesRequest request = new ListDataExchangesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListDataExchangesResponse, DataExchange> response = analyticsHubServiceClient.ListDataExchanges(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataExchange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataExchangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataExchange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataExchange> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataExchange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataExchangesAsync</summary>
        public async Task ListDataExchangesRequestObjectAsync()
        {
            // Snippet: ListDataExchangesAsync(ListDataExchangesRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataExchangesRequest request = new ListDataExchangesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDataExchangesResponse, DataExchange> response = analyticsHubServiceClient.ListDataExchangesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataExchange item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataExchangesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataExchange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataExchange> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataExchange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataExchanges</summary>
        public void ListDataExchanges()
        {
            // Snippet: ListDataExchanges(string, string, int?, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDataExchangesResponse, DataExchange> response = analyticsHubServiceClient.ListDataExchanges(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataExchange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataExchangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataExchange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataExchange> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataExchange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataExchangesAsync</summary>
        public async Task ListDataExchangesAsync()
        {
            // Snippet: ListDataExchangesAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDataExchangesResponse, DataExchange> response = analyticsHubServiceClient.ListDataExchangesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataExchange item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataExchangesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataExchange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataExchange> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataExchange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataExchanges</summary>
        public void ListDataExchangesResourceNames()
        {
            // Snippet: ListDataExchanges(LocationName, string, int?, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDataExchangesResponse, DataExchange> response = analyticsHubServiceClient.ListDataExchanges(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataExchange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataExchangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataExchange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataExchange> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataExchange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataExchangesAsync</summary>
        public async Task ListDataExchangesResourceNamesAsync()
        {
            // Snippet: ListDataExchangesAsync(LocationName, string, int?, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDataExchangesResponse, DataExchange> response = analyticsHubServiceClient.ListDataExchangesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataExchange item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataExchangesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataExchange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataExchange> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataExchange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgDataExchanges</summary>
        public void ListOrgDataExchangesRequestObject()
        {
            // Snippet: ListOrgDataExchanges(ListOrgDataExchangesRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            ListOrgDataExchangesRequest request = new ListOrgDataExchangesRequest { Organization = "", };
            // Make the request
            PagedEnumerable<ListOrgDataExchangesResponse, DataExchange> response = analyticsHubServiceClient.ListOrgDataExchanges(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataExchange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrgDataExchangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataExchange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataExchange> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataExchange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgDataExchangesAsync</summary>
        public async Task ListOrgDataExchangesRequestObjectAsync()
        {
            // Snippet: ListOrgDataExchangesAsync(ListOrgDataExchangesRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOrgDataExchangesRequest request = new ListOrgDataExchangesRequest { Organization = "", };
            // Make the request
            PagedAsyncEnumerable<ListOrgDataExchangesResponse, DataExchange> response = analyticsHubServiceClient.ListOrgDataExchangesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataExchange item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrgDataExchangesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataExchange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataExchange> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataExchange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgDataExchanges</summary>
        public void ListOrgDataExchanges()
        {
            // Snippet: ListOrgDataExchanges(string, string, int?, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            string organization = "";
            // Make the request
            PagedEnumerable<ListOrgDataExchangesResponse, DataExchange> response = analyticsHubServiceClient.ListOrgDataExchanges(organization);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataExchange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrgDataExchangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataExchange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataExchange> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataExchange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgDataExchangesAsync</summary>
        public async Task ListOrgDataExchangesAsync()
        {
            // Snippet: ListOrgDataExchangesAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string organization = "";
            // Make the request
            PagedAsyncEnumerable<ListOrgDataExchangesResponse, DataExchange> response = analyticsHubServiceClient.ListOrgDataExchangesAsync(organization);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataExchange item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrgDataExchangesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataExchange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataExchange> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataExchange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDataExchange</summary>
        public void GetDataExchangeRequestObject()
        {
            // Snippet: GetDataExchange(GetDataExchangeRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            GetDataExchangeRequest request = new GetDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            // Make the request
            DataExchange response = analyticsHubServiceClient.GetDataExchange(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataExchangeAsync</summary>
        public async Task GetDataExchangeRequestObjectAsync()
        {
            // Snippet: GetDataExchangeAsync(GetDataExchangeRequest, CallSettings)
            // Additional: GetDataExchangeAsync(GetDataExchangeRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataExchangeRequest request = new GetDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            // Make the request
            DataExchange response = await analyticsHubServiceClient.GetDataExchangeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataExchange</summary>
        public void GetDataExchange()
        {
            // Snippet: GetDataExchange(string, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]";
            // Make the request
            DataExchange response = analyticsHubServiceClient.GetDataExchange(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataExchangeAsync</summary>
        public async Task GetDataExchangeAsync()
        {
            // Snippet: GetDataExchangeAsync(string, CallSettings)
            // Additional: GetDataExchangeAsync(string, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]";
            // Make the request
            DataExchange response = await analyticsHubServiceClient.GetDataExchangeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataExchange</summary>
        public void GetDataExchangeResourceNames()
        {
            // Snippet: GetDataExchange(DataExchangeName, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            DataExchangeName name = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]");
            // Make the request
            DataExchange response = analyticsHubServiceClient.GetDataExchange(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataExchangeAsync</summary>
        public async Task GetDataExchangeResourceNamesAsync()
        {
            // Snippet: GetDataExchangeAsync(DataExchangeName, CallSettings)
            // Additional: GetDataExchangeAsync(DataExchangeName, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataExchangeName name = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]");
            // Make the request
            DataExchange response = await analyticsHubServiceClient.GetDataExchangeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDataExchange</summary>
        public void CreateDataExchangeRequestObject()
        {
            // Snippet: CreateDataExchange(CreateDataExchangeRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            CreateDataExchangeRequest request = new CreateDataExchangeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataExchangeId = "",
                DataExchange = new DataExchange(),
            };
            // Make the request
            DataExchange response = analyticsHubServiceClient.CreateDataExchange(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataExchangeAsync</summary>
        public async Task CreateDataExchangeRequestObjectAsync()
        {
            // Snippet: CreateDataExchangeAsync(CreateDataExchangeRequest, CallSettings)
            // Additional: CreateDataExchangeAsync(CreateDataExchangeRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataExchangeRequest request = new CreateDataExchangeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataExchangeId = "",
                DataExchange = new DataExchange(),
            };
            // Make the request
            DataExchange response = await analyticsHubServiceClient.CreateDataExchangeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataExchange</summary>
        public void CreateDataExchange()
        {
            // Snippet: CreateDataExchange(string, DataExchange, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DataExchange dataExchange = new DataExchange();
            // Make the request
            DataExchange response = analyticsHubServiceClient.CreateDataExchange(parent, dataExchange);
            // End snippet
        }

        /// <summary>Snippet for CreateDataExchangeAsync</summary>
        public async Task CreateDataExchangeAsync()
        {
            // Snippet: CreateDataExchangeAsync(string, DataExchange, CallSettings)
            // Additional: CreateDataExchangeAsync(string, DataExchange, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DataExchange dataExchange = new DataExchange();
            // Make the request
            DataExchange response = await analyticsHubServiceClient.CreateDataExchangeAsync(parent, dataExchange);
            // End snippet
        }

        /// <summary>Snippet for CreateDataExchange</summary>
        public void CreateDataExchangeResourceNames()
        {
            // Snippet: CreateDataExchange(LocationName, DataExchange, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DataExchange dataExchange = new DataExchange();
            // Make the request
            DataExchange response = analyticsHubServiceClient.CreateDataExchange(parent, dataExchange);
            // End snippet
        }

        /// <summary>Snippet for CreateDataExchangeAsync</summary>
        public async Task CreateDataExchangeResourceNamesAsync()
        {
            // Snippet: CreateDataExchangeAsync(LocationName, DataExchange, CallSettings)
            // Additional: CreateDataExchangeAsync(LocationName, DataExchange, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DataExchange dataExchange = new DataExchange();
            // Make the request
            DataExchange response = await analyticsHubServiceClient.CreateDataExchangeAsync(parent, dataExchange);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataExchange</summary>
        public void UpdateDataExchangeRequestObject()
        {
            // Snippet: UpdateDataExchange(UpdateDataExchangeRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataExchangeRequest request = new UpdateDataExchangeRequest
            {
                UpdateMask = new FieldMask(),
                DataExchange = new DataExchange(),
            };
            // Make the request
            DataExchange response = analyticsHubServiceClient.UpdateDataExchange(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataExchangeAsync</summary>
        public async Task UpdateDataExchangeRequestObjectAsync()
        {
            // Snippet: UpdateDataExchangeAsync(UpdateDataExchangeRequest, CallSettings)
            // Additional: UpdateDataExchangeAsync(UpdateDataExchangeRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataExchangeRequest request = new UpdateDataExchangeRequest
            {
                UpdateMask = new FieldMask(),
                DataExchange = new DataExchange(),
            };
            // Make the request
            DataExchange response = await analyticsHubServiceClient.UpdateDataExchangeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataExchange</summary>
        public void UpdateDataExchange()
        {
            // Snippet: UpdateDataExchange(DataExchange, FieldMask, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            DataExchange dataExchange = new DataExchange();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataExchange response = analyticsHubServiceClient.UpdateDataExchange(dataExchange, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataExchangeAsync</summary>
        public async Task UpdateDataExchangeAsync()
        {
            // Snippet: UpdateDataExchangeAsync(DataExchange, FieldMask, CallSettings)
            // Additional: UpdateDataExchangeAsync(DataExchange, FieldMask, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataExchange dataExchange = new DataExchange();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataExchange response = await analyticsHubServiceClient.UpdateDataExchangeAsync(dataExchange, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataExchange</summary>
        public void DeleteDataExchangeRequestObject()
        {
            // Snippet: DeleteDataExchange(DeleteDataExchangeRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataExchangeRequest request = new DeleteDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            // Make the request
            analyticsHubServiceClient.DeleteDataExchange(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataExchangeAsync</summary>
        public async Task DeleteDataExchangeRequestObjectAsync()
        {
            // Snippet: DeleteDataExchangeAsync(DeleteDataExchangeRequest, CallSettings)
            // Additional: DeleteDataExchangeAsync(DeleteDataExchangeRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataExchangeRequest request = new DeleteDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            // Make the request
            await analyticsHubServiceClient.DeleteDataExchangeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataExchange</summary>
        public void DeleteDataExchange()
        {
            // Snippet: DeleteDataExchange(string, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]";
            // Make the request
            analyticsHubServiceClient.DeleteDataExchange(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataExchangeAsync</summary>
        public async Task DeleteDataExchangeAsync()
        {
            // Snippet: DeleteDataExchangeAsync(string, CallSettings)
            // Additional: DeleteDataExchangeAsync(string, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]";
            // Make the request
            await analyticsHubServiceClient.DeleteDataExchangeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataExchange</summary>
        public void DeleteDataExchangeResourceNames()
        {
            // Snippet: DeleteDataExchange(DataExchangeName, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            DataExchangeName name = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]");
            // Make the request
            analyticsHubServiceClient.DeleteDataExchange(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataExchangeAsync</summary>
        public async Task DeleteDataExchangeResourceNamesAsync()
        {
            // Snippet: DeleteDataExchangeAsync(DataExchangeName, CallSettings)
            // Additional: DeleteDataExchangeAsync(DataExchangeName, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataExchangeName name = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]");
            // Make the request
            await analyticsHubServiceClient.DeleteDataExchangeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListListings</summary>
        public void ListListingsRequestObject()
        {
            // Snippet: ListListings(ListListingsRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            ListListingsRequest request = new ListListingsRequest
            {
                ParentAsDataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            // Make the request
            PagedEnumerable<ListListingsResponse, Listing> response = analyticsHubServiceClient.ListListings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Listing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListListingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Listing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Listing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Listing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListListingsAsync</summary>
        public async Task ListListingsRequestObjectAsync()
        {
            // Snippet: ListListingsAsync(ListListingsRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListListingsRequest request = new ListListingsRequest
            {
                ParentAsDataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListListingsResponse, Listing> response = analyticsHubServiceClient.ListListingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Listing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListListingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Listing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Listing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Listing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListListings</summary>
        public void ListListings()
        {
            // Snippet: ListListings(string, string, int?, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]";
            // Make the request
            PagedEnumerable<ListListingsResponse, Listing> response = analyticsHubServiceClient.ListListings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Listing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListListingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Listing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Listing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Listing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListListingsAsync</summary>
        public async Task ListListingsAsync()
        {
            // Snippet: ListListingsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]";
            // Make the request
            PagedAsyncEnumerable<ListListingsResponse, Listing> response = analyticsHubServiceClient.ListListingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Listing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListListingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Listing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Listing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Listing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListListings</summary>
        public void ListListingsResourceNames()
        {
            // Snippet: ListListings(DataExchangeName, string, int?, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            DataExchangeName parent = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]");
            // Make the request
            PagedEnumerable<ListListingsResponse, Listing> response = analyticsHubServiceClient.ListListings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Listing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListListingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Listing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Listing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Listing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListListingsAsync</summary>
        public async Task ListListingsResourceNamesAsync()
        {
            // Snippet: ListListingsAsync(DataExchangeName, string, int?, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataExchangeName parent = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]");
            // Make the request
            PagedAsyncEnumerable<ListListingsResponse, Listing> response = analyticsHubServiceClient.ListListingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Listing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListListingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Listing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Listing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Listing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetListing</summary>
        public void GetListingRequestObject()
        {
            // Snippet: GetListing(GetListingRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            GetListingRequest request = new GetListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            // Make the request
            Listing response = analyticsHubServiceClient.GetListing(request);
            // End snippet
        }

        /// <summary>Snippet for GetListingAsync</summary>
        public async Task GetListingRequestObjectAsync()
        {
            // Snippet: GetListingAsync(GetListingRequest, CallSettings)
            // Additional: GetListingAsync(GetListingRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetListingRequest request = new GetListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            // Make the request
            Listing response = await analyticsHubServiceClient.GetListingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetListing</summary>
        public void GetListing()
        {
            // Snippet: GetListing(string, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]/listings/[LISTING]";
            // Make the request
            Listing response = analyticsHubServiceClient.GetListing(name);
            // End snippet
        }

        /// <summary>Snippet for GetListingAsync</summary>
        public async Task GetListingAsync()
        {
            // Snippet: GetListingAsync(string, CallSettings)
            // Additional: GetListingAsync(string, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]/listings/[LISTING]";
            // Make the request
            Listing response = await analyticsHubServiceClient.GetListingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetListing</summary>
        public void GetListingResourceNames()
        {
            // Snippet: GetListing(ListingName, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            ListingName name = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]");
            // Make the request
            Listing response = analyticsHubServiceClient.GetListing(name);
            // End snippet
        }

        /// <summary>Snippet for GetListingAsync</summary>
        public async Task GetListingResourceNamesAsync()
        {
            // Snippet: GetListingAsync(ListingName, CallSettings)
            // Additional: GetListingAsync(ListingName, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListingName name = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]");
            // Make the request
            Listing response = await analyticsHubServiceClient.GetListingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateListing</summary>
        public void CreateListingRequestObject()
        {
            // Snippet: CreateListing(CreateListingRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            CreateListingRequest request = new CreateListingRequest
            {
                ParentAsDataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                ListingId = "",
                Listing = new Listing(),
            };
            // Make the request
            Listing response = analyticsHubServiceClient.CreateListing(request);
            // End snippet
        }

        /// <summary>Snippet for CreateListingAsync</summary>
        public async Task CreateListingRequestObjectAsync()
        {
            // Snippet: CreateListingAsync(CreateListingRequest, CallSettings)
            // Additional: CreateListingAsync(CreateListingRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateListingRequest request = new CreateListingRequest
            {
                ParentAsDataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                ListingId = "",
                Listing = new Listing(),
            };
            // Make the request
            Listing response = await analyticsHubServiceClient.CreateListingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateListing</summary>
        public void CreateListing()
        {
            // Snippet: CreateListing(string, Listing, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]";
            Listing listing = new Listing();
            // Make the request
            Listing response = analyticsHubServiceClient.CreateListing(parent, listing);
            // End snippet
        }

        /// <summary>Snippet for CreateListingAsync</summary>
        public async Task CreateListingAsync()
        {
            // Snippet: CreateListingAsync(string, Listing, CallSettings)
            // Additional: CreateListingAsync(string, Listing, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]";
            Listing listing = new Listing();
            // Make the request
            Listing response = await analyticsHubServiceClient.CreateListingAsync(parent, listing);
            // End snippet
        }

        /// <summary>Snippet for CreateListing</summary>
        public void CreateListingResourceNames()
        {
            // Snippet: CreateListing(DataExchangeName, Listing, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            DataExchangeName parent = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]");
            Listing listing = new Listing();
            // Make the request
            Listing response = analyticsHubServiceClient.CreateListing(parent, listing);
            // End snippet
        }

        /// <summary>Snippet for CreateListingAsync</summary>
        public async Task CreateListingResourceNamesAsync()
        {
            // Snippet: CreateListingAsync(DataExchangeName, Listing, CallSettings)
            // Additional: CreateListingAsync(DataExchangeName, Listing, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataExchangeName parent = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]");
            Listing listing = new Listing();
            // Make the request
            Listing response = await analyticsHubServiceClient.CreateListingAsync(parent, listing);
            // End snippet
        }

        /// <summary>Snippet for UpdateListing</summary>
        public void UpdateListingRequestObject()
        {
            // Snippet: UpdateListing(UpdateListingRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            UpdateListingRequest request = new UpdateListingRequest
            {
                UpdateMask = new FieldMask(),
                Listing = new Listing(),
            };
            // Make the request
            Listing response = analyticsHubServiceClient.UpdateListing(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateListingAsync</summary>
        public async Task UpdateListingRequestObjectAsync()
        {
            // Snippet: UpdateListingAsync(UpdateListingRequest, CallSettings)
            // Additional: UpdateListingAsync(UpdateListingRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateListingRequest request = new UpdateListingRequest
            {
                UpdateMask = new FieldMask(),
                Listing = new Listing(),
            };
            // Make the request
            Listing response = await analyticsHubServiceClient.UpdateListingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateListing</summary>
        public void UpdateListing()
        {
            // Snippet: UpdateListing(Listing, FieldMask, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            Listing listing = new Listing();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Listing response = analyticsHubServiceClient.UpdateListing(listing, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateListingAsync</summary>
        public async Task UpdateListingAsync()
        {
            // Snippet: UpdateListingAsync(Listing, FieldMask, CallSettings)
            // Additional: UpdateListingAsync(Listing, FieldMask, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            Listing listing = new Listing();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Listing response = await analyticsHubServiceClient.UpdateListingAsync(listing, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteListing</summary>
        public void DeleteListingRequestObject()
        {
            // Snippet: DeleteListing(DeleteListingRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            DeleteListingRequest request = new DeleteListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            // Make the request
            analyticsHubServiceClient.DeleteListing(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteListingAsync</summary>
        public async Task DeleteListingRequestObjectAsync()
        {
            // Snippet: DeleteListingAsync(DeleteListingRequest, CallSettings)
            // Additional: DeleteListingAsync(DeleteListingRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteListingRequest request = new DeleteListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            // Make the request
            await analyticsHubServiceClient.DeleteListingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteListing</summary>
        public void DeleteListing()
        {
            // Snippet: DeleteListing(string, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]/listings/[LISTING]";
            // Make the request
            analyticsHubServiceClient.DeleteListing(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteListingAsync</summary>
        public async Task DeleteListingAsync()
        {
            // Snippet: DeleteListingAsync(string, CallSettings)
            // Additional: DeleteListingAsync(string, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]/listings/[LISTING]";
            // Make the request
            await analyticsHubServiceClient.DeleteListingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteListing</summary>
        public void DeleteListingResourceNames()
        {
            // Snippet: DeleteListing(ListingName, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            ListingName name = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]");
            // Make the request
            analyticsHubServiceClient.DeleteListing(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteListingAsync</summary>
        public async Task DeleteListingResourceNamesAsync()
        {
            // Snippet: DeleteListingAsync(ListingName, CallSettings)
            // Additional: DeleteListingAsync(ListingName, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListingName name = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]");
            // Make the request
            await analyticsHubServiceClient.DeleteListingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SubscribeListing</summary>
        public void SubscribeListingRequestObject()
        {
            // Snippet: SubscribeListing(SubscribeListingRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            SubscribeListingRequest request = new SubscribeListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DestinationDataset = new DestinationDataset(),
            };
            // Make the request
            SubscribeListingResponse response = analyticsHubServiceClient.SubscribeListing(request);
            // End snippet
        }

        /// <summary>Snippet for SubscribeListingAsync</summary>
        public async Task SubscribeListingRequestObjectAsync()
        {
            // Snippet: SubscribeListingAsync(SubscribeListingRequest, CallSettings)
            // Additional: SubscribeListingAsync(SubscribeListingRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubscribeListingRequest request = new SubscribeListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DestinationDataset = new DestinationDataset(),
            };
            // Make the request
            SubscribeListingResponse response = await analyticsHubServiceClient.SubscribeListingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SubscribeListing</summary>
        public void SubscribeListing()
        {
            // Snippet: SubscribeListing(string, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]/listings/[LISTING]";
            // Make the request
            SubscribeListingResponse response = analyticsHubServiceClient.SubscribeListing(name);
            // End snippet
        }

        /// <summary>Snippet for SubscribeListingAsync</summary>
        public async Task SubscribeListingAsync()
        {
            // Snippet: SubscribeListingAsync(string, CallSettings)
            // Additional: SubscribeListingAsync(string, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataExchanges/[DATA_EXCHANGE]/listings/[LISTING]";
            // Make the request
            SubscribeListingResponse response = await analyticsHubServiceClient.SubscribeListingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SubscribeListing</summary>
        public void SubscribeListingResourceNames()
        {
            // Snippet: SubscribeListing(ListingName, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            ListingName name = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]");
            // Make the request
            SubscribeListingResponse response = analyticsHubServiceClient.SubscribeListing(name);
            // End snippet
        }

        /// <summary>Snippet for SubscribeListingAsync</summary>
        public async Task SubscribeListingResourceNamesAsync()
        {
            // Snippet: SubscribeListingAsync(ListingName, CallSettings)
            // Additional: SubscribeListingAsync(ListingName, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListingName name = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]");
            // Make the request
            SubscribeListingResponse response = await analyticsHubServiceClient.SubscribeListingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = analyticsHubServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await analyticsHubServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = analyticsHubServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await analyticsHubServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = AnalyticsHubServiceClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = analyticsHubServiceClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await analyticsHubServiceClient.TestIamPermissionsAsync(request);
            // End snippet
        }
    }
}
