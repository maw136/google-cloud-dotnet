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

#pragma warning disable CS8981

namespace Google.Cloud.ApigeeRegistry.V1.Snippets
{
    using Google.Api;
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcav = Google.Cloud.ApigeeRegistry.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegistryClientSnippets
    {
        /// <summary>Snippet for ListApis</summary>
        public void ListApisRequestObject()
        {
            // Snippet: ListApis(ListApisRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ListApisRequest request = new ListApisRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListApisResponse, gcav::Api> response = registryClient.ListApis(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Api item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApisResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApisAsync</summary>
        public async Task ListApisRequestObjectAsync()
        {
            // Snippet: ListApisAsync(ListApisRequest, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListApisRequest request = new ListApisRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApisResponse, gcav::Api> response = registryClient.ListApisAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Api item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApisResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApis</summary>
        public void ListApis()
        {
            // Snippet: ListApis(string, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListApisResponse, gcav::Api> response = registryClient.ListApis(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Api item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApisResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApisAsync</summary>
        public async Task ListApisAsync()
        {
            // Snippet: ListApisAsync(string, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListApisResponse, gcav::Api> response = registryClient.ListApisAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Api item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApisResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApis</summary>
        public void ListApisResourceNames()
        {
            // Snippet: ListApis(LocationName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListApisResponse, gcav::Api> response = registryClient.ListApis(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Api item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApisResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApisAsync</summary>
        public async Task ListApisResourceNamesAsync()
        {
            // Snippet: ListApisAsync(LocationName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListApisResponse, gcav::Api> response = registryClient.ListApisAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Api item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApisResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Api item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Api> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Api item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetApi</summary>
        public void GetApiRequestObject()
        {
            // Snippet: GetApi(GetApiRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            // Make the request
            gcav::Api response = registryClient.GetApi(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiAsync</summary>
        public async Task GetApiRequestObjectAsync()
        {
            // Snippet: GetApiAsync(GetApiRequest, CallSettings)
            // Additional: GetApiAsync(GetApiRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            // Make the request
            gcav::Api response = await registryClient.GetApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApi</summary>
        public void GetApi()
        {
            // Snippet: GetApi(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            gcav::Api response = registryClient.GetApi(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiAsync</summary>
        public async Task GetApiAsync()
        {
            // Snippet: GetApiAsync(string, CallSettings)
            // Additional: GetApiAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            gcav::Api response = await registryClient.GetApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApi</summary>
        public void GetApiResourceNames()
        {
            // Snippet: GetApi(ApiName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiName name = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            gcav::Api response = registryClient.GetApi(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiAsync</summary>
        public async Task GetApiResourceNamesAsync()
        {
            // Snippet: GetApiAsync(ApiName, CallSettings)
            // Additional: GetApiAsync(ApiName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiName name = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            gcav::Api response = await registryClient.GetApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateApi</summary>
        public void CreateApiRequestObject()
        {
            // Snippet: CreateApi(CreateApiRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            CreateApiRequest request = new CreateApiRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Api = new gcav::Api(),
                ApiId = "",
            };
            // Make the request
            gcav::Api response = registryClient.CreateApi(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApiAsync</summary>
        public async Task CreateApiRequestObjectAsync()
        {
            // Snippet: CreateApiAsync(CreateApiRequest, CallSettings)
            // Additional: CreateApiAsync(CreateApiRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateApiRequest request = new CreateApiRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Api = new gcav::Api(),
                ApiId = "",
            };
            // Make the request
            gcav::Api response = await registryClient.CreateApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApi</summary>
        public void CreateApi()
        {
            // Snippet: CreateApi(string, Api, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            gcav::Api response = registryClient.CreateApi(parent, api, apiId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiAsync</summary>
        public async Task CreateApiAsync()
        {
            // Snippet: CreateApiAsync(string, Api, string, CallSettings)
            // Additional: CreateApiAsync(string, Api, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            gcav::Api response = await registryClient.CreateApiAsync(parent, api, apiId);
            // End snippet
        }

        /// <summary>Snippet for CreateApi</summary>
        public void CreateApiResourceNames()
        {
            // Snippet: CreateApi(LocationName, Api, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            gcav::Api response = registryClient.CreateApi(parent, api, apiId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiAsync</summary>
        public async Task CreateApiResourceNamesAsync()
        {
            // Snippet: CreateApiAsync(LocationName, Api, string, CallSettings)
            // Additional: CreateApiAsync(LocationName, Api, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            gcav::Api response = await registryClient.CreateApiAsync(parent, api, apiId);
            // End snippet
        }

        /// <summary>Snippet for UpdateApi</summary>
        public void UpdateApiRequestObject()
        {
            // Snippet: UpdateApi(UpdateApiRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            UpdateApiRequest request = new UpdateApiRequest
            {
                Api = new gcav::Api(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            gcav::Api response = registryClient.UpdateApi(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiAsync</summary>
        public async Task UpdateApiRequestObjectAsync()
        {
            // Snippet: UpdateApiAsync(UpdateApiRequest, CallSettings)
            // Additional: UpdateApiAsync(UpdateApiRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApiRequest request = new UpdateApiRequest
            {
                Api = new gcav::Api(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            gcav::Api response = await registryClient.UpdateApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApi</summary>
        public void UpdateApi()
        {
            // Snippet: UpdateApi(Api, FieldMask, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            gcav::Api api = new gcav::Api();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Api response = registryClient.UpdateApi(api, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiAsync</summary>
        public async Task UpdateApiAsync()
        {
            // Snippet: UpdateApiAsync(Api, FieldMask, CallSettings)
            // Additional: UpdateApiAsync(Api, FieldMask, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::Api api = new gcav::Api();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Api response = await registryClient.UpdateApiAsync(api, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteApi</summary>
        public void DeleteApiRequestObject()
        {
            // Snippet: DeleteApi(DeleteApiRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            DeleteApiRequest request = new DeleteApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            // Make the request
            registryClient.DeleteApi(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiAsync</summary>
        public async Task DeleteApiRequestObjectAsync()
        {
            // Snippet: DeleteApiAsync(DeleteApiRequest, CallSettings)
            // Additional: DeleteApiAsync(DeleteApiRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApiRequest request = new DeleteApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            // Make the request
            await registryClient.DeleteApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApi</summary>
        public void DeleteApi()
        {
            // Snippet: DeleteApi(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            registryClient.DeleteApi(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiAsync</summary>
        public async Task DeleteApiAsync()
        {
            // Snippet: DeleteApiAsync(string, CallSettings)
            // Additional: DeleteApiAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            await registryClient.DeleteApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApi</summary>
        public void DeleteApiResourceNames()
        {
            // Snippet: DeleteApi(ApiName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiName name = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            registryClient.DeleteApi(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiAsync</summary>
        public async Task DeleteApiResourceNamesAsync()
        {
            // Snippet: DeleteApiAsync(ApiName, CallSettings)
            // Additional: DeleteApiAsync(ApiName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiName name = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            await registryClient.DeleteApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListApiVersions</summary>
        public void ListApiVersionsRequestObject()
        {
            // Snippet: ListApiVersions(ListApiVersionsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ListApiVersionsRequest request = new ListApiVersionsRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListApiVersionsResponse, ApiVersion> response = registryClient.ListApiVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiVersionsAsync</summary>
        public async Task ListApiVersionsRequestObjectAsync()
        {
            // Snippet: ListApiVersionsAsync(ListApiVersionsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListApiVersionsRequest request = new ListApiVersionsRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApiVersionsResponse, ApiVersion> response = registryClient.ListApiVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiVersions</summary>
        public void ListApiVersions()
        {
            // Snippet: ListApiVersions(string, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            PagedEnumerable<ListApiVersionsResponse, ApiVersion> response = registryClient.ListApiVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiVersionsAsync</summary>
        public async Task ListApiVersionsAsync()
        {
            // Snippet: ListApiVersionsAsync(string, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            PagedAsyncEnumerable<ListApiVersionsResponse, ApiVersion> response = registryClient.ListApiVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiVersions</summary>
        public void ListApiVersionsResourceNames()
        {
            // Snippet: ListApiVersions(ApiName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            PagedEnumerable<ListApiVersionsResponse, ApiVersion> response = registryClient.ListApiVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiVersionsAsync</summary>
        public async Task ListApiVersionsResourceNamesAsync()
        {
            // Snippet: ListApiVersionsAsync(ApiName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            PagedAsyncEnumerable<ListApiVersionsResponse, ApiVersion> response = registryClient.ListApiVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetApiVersion</summary>
        public void GetApiVersionRequestObject()
        {
            // Snippet: GetApiVersion(GetApiVersionRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            GetApiVersionRequest request = new GetApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            // Make the request
            ApiVersion response = registryClient.GetApiVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiVersionAsync</summary>
        public async Task GetApiVersionRequestObjectAsync()
        {
            // Snippet: GetApiVersionAsync(GetApiVersionRequest, CallSettings)
            // Additional: GetApiVersionAsync(GetApiVersionRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetApiVersionRequest request = new GetApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            // Make the request
            ApiVersion response = await registryClient.GetApiVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiVersion</summary>
        public void GetApiVersion()
        {
            // Snippet: GetApiVersion(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            ApiVersion response = registryClient.GetApiVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiVersionAsync</summary>
        public async Task GetApiVersionAsync()
        {
            // Snippet: GetApiVersionAsync(string, CallSettings)
            // Additional: GetApiVersionAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            ApiVersion response = await registryClient.GetApiVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiVersion</summary>
        public void GetApiVersionResourceNames()
        {
            // Snippet: GetApiVersion(ApiVersionName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiVersionName name = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            ApiVersion response = registryClient.GetApiVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiVersionAsync</summary>
        public async Task GetApiVersionResourceNamesAsync()
        {
            // Snippet: GetApiVersionAsync(ApiVersionName, CallSettings)
            // Additional: GetApiVersionAsync(ApiVersionName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiVersionName name = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            ApiVersion response = await registryClient.GetApiVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateApiVersion</summary>
        public void CreateApiVersionRequestObject()
        {
            // Snippet: CreateApiVersion(CreateApiVersionRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            CreateApiVersionRequest request = new CreateApiVersionRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiVersion = new ApiVersion(),
                ApiVersionId = "",
            };
            // Make the request
            ApiVersion response = registryClient.CreateApiVersion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApiVersionAsync</summary>
        public async Task CreateApiVersionRequestObjectAsync()
        {
            // Snippet: CreateApiVersionAsync(CreateApiVersionRequest, CallSettings)
            // Additional: CreateApiVersionAsync(CreateApiVersionRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateApiVersionRequest request = new CreateApiVersionRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiVersion = new ApiVersion(),
                ApiVersionId = "",
            };
            // Make the request
            ApiVersion response = await registryClient.CreateApiVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApiVersion</summary>
        public void CreateApiVersion()
        {
            // Snippet: CreateApiVersion(string, ApiVersion, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            ApiVersion apiVersion = new ApiVersion();
            string apiVersionId = "";
            // Make the request
            ApiVersion response = registryClient.CreateApiVersion(parent, apiVersion, apiVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiVersionAsync</summary>
        public async Task CreateApiVersionAsync()
        {
            // Snippet: CreateApiVersionAsync(string, ApiVersion, string, CallSettings)
            // Additional: CreateApiVersionAsync(string, ApiVersion, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            ApiVersion apiVersion = new ApiVersion();
            string apiVersionId = "";
            // Make the request
            ApiVersion response = await registryClient.CreateApiVersionAsync(parent, apiVersion, apiVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiVersion</summary>
        public void CreateApiVersionResourceNames()
        {
            // Snippet: CreateApiVersion(ApiName, ApiVersion, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            ApiVersion apiVersion = new ApiVersion();
            string apiVersionId = "";
            // Make the request
            ApiVersion response = registryClient.CreateApiVersion(parent, apiVersion, apiVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiVersionAsync</summary>
        public async Task CreateApiVersionResourceNamesAsync()
        {
            // Snippet: CreateApiVersionAsync(ApiName, ApiVersion, string, CallSettings)
            // Additional: CreateApiVersionAsync(ApiName, ApiVersion, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            ApiVersion apiVersion = new ApiVersion();
            string apiVersionId = "";
            // Make the request
            ApiVersion response = await registryClient.CreateApiVersionAsync(parent, apiVersion, apiVersionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiVersion</summary>
        public void UpdateApiVersionRequestObject()
        {
            // Snippet: UpdateApiVersion(UpdateApiVersionRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            UpdateApiVersionRequest request = new UpdateApiVersionRequest
            {
                ApiVersion = new ApiVersion(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            ApiVersion response = registryClient.UpdateApiVersion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiVersionAsync</summary>
        public async Task UpdateApiVersionRequestObjectAsync()
        {
            // Snippet: UpdateApiVersionAsync(UpdateApiVersionRequest, CallSettings)
            // Additional: UpdateApiVersionAsync(UpdateApiVersionRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApiVersionRequest request = new UpdateApiVersionRequest
            {
                ApiVersion = new ApiVersion(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            ApiVersion response = await registryClient.UpdateApiVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiVersion</summary>
        public void UpdateApiVersion()
        {
            // Snippet: UpdateApiVersion(ApiVersion, FieldMask, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiVersion apiVersion = new ApiVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ApiVersion response = registryClient.UpdateApiVersion(apiVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiVersionAsync</summary>
        public async Task UpdateApiVersionAsync()
        {
            // Snippet: UpdateApiVersionAsync(ApiVersion, FieldMask, CallSettings)
            // Additional: UpdateApiVersionAsync(ApiVersion, FieldMask, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiVersion apiVersion = new ApiVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ApiVersion response = await registryClient.UpdateApiVersionAsync(apiVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiVersion</summary>
        public void DeleteApiVersionRequestObject()
        {
            // Snippet: DeleteApiVersion(DeleteApiVersionRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            DeleteApiVersionRequest request = new DeleteApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            // Make the request
            registryClient.DeleteApiVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiVersionAsync</summary>
        public async Task DeleteApiVersionRequestObjectAsync()
        {
            // Snippet: DeleteApiVersionAsync(DeleteApiVersionRequest, CallSettings)
            // Additional: DeleteApiVersionAsync(DeleteApiVersionRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApiVersionRequest request = new DeleteApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            // Make the request
            await registryClient.DeleteApiVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiVersion</summary>
        public void DeleteApiVersion()
        {
            // Snippet: DeleteApiVersion(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            registryClient.DeleteApiVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiVersionAsync</summary>
        public async Task DeleteApiVersionAsync()
        {
            // Snippet: DeleteApiVersionAsync(string, CallSettings)
            // Additional: DeleteApiVersionAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            await registryClient.DeleteApiVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiVersion</summary>
        public void DeleteApiVersionResourceNames()
        {
            // Snippet: DeleteApiVersion(ApiVersionName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiVersionName name = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            registryClient.DeleteApiVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiVersionAsync</summary>
        public async Task DeleteApiVersionResourceNamesAsync()
        {
            // Snippet: DeleteApiVersionAsync(ApiVersionName, CallSettings)
            // Additional: DeleteApiVersionAsync(ApiVersionName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiVersionName name = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            await registryClient.DeleteApiVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListApiSpecs</summary>
        public void ListApiSpecsRequestObject()
        {
            // Snippet: ListApiSpecs(ListApiSpecsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ListApiSpecsRequest request = new ListApiSpecsRequest
            {
                ParentAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListApiSpecsResponse, ApiSpec> response = registryClient.ListApiSpecs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiSpec item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiSpecsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiSpec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiSpec> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiSpec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiSpecsAsync</summary>
        public async Task ListApiSpecsRequestObjectAsync()
        {
            // Snippet: ListApiSpecsAsync(ListApiSpecsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListApiSpecsRequest request = new ListApiSpecsRequest
            {
                ParentAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApiSpecsResponse, ApiSpec> response = registryClient.ListApiSpecsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiSpec item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiSpecsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiSpec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiSpec> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiSpec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiSpecs</summary>
        public void ListApiSpecs()
        {
            // Snippet: ListApiSpecs(string, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            PagedEnumerable<ListApiSpecsResponse, ApiSpec> response = registryClient.ListApiSpecs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiSpec item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiSpecsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiSpec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiSpec> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiSpec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiSpecsAsync</summary>
        public async Task ListApiSpecsAsync()
        {
            // Snippet: ListApiSpecsAsync(string, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            // Make the request
            PagedAsyncEnumerable<ListApiSpecsResponse, ApiSpec> response = registryClient.ListApiSpecsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiSpec item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiSpecsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiSpec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiSpec> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiSpec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiSpecs</summary>
        public void ListApiSpecsResourceNames()
        {
            // Snippet: ListApiSpecs(ApiVersionName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiVersionName parent = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            PagedEnumerable<ListApiSpecsResponse, ApiSpec> response = registryClient.ListApiSpecs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiSpec item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiSpecsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiSpec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiSpec> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiSpec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiSpecsAsync</summary>
        public async Task ListApiSpecsResourceNamesAsync()
        {
            // Snippet: ListApiSpecsAsync(ApiVersionName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiVersionName parent = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            PagedAsyncEnumerable<ListApiSpecsResponse, ApiSpec> response = registryClient.ListApiSpecsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiSpec item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiSpecsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiSpec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiSpec> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiSpec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetApiSpec</summary>
        public void GetApiSpecRequestObject()
        {
            // Snippet: GetApiSpec(GetApiSpecRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            GetApiSpecRequest request = new GetApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            ApiSpec response = registryClient.GetApiSpec(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiSpecAsync</summary>
        public async Task GetApiSpecRequestObjectAsync()
        {
            // Snippet: GetApiSpecAsync(GetApiSpecRequest, CallSettings)
            // Additional: GetApiSpecAsync(GetApiSpecRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetApiSpecRequest request = new GetApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            ApiSpec response = await registryClient.GetApiSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiSpec</summary>
        public void GetApiSpec()
        {
            // Snippet: GetApiSpec(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            ApiSpec response = registryClient.GetApiSpec(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiSpecAsync</summary>
        public async Task GetApiSpecAsync()
        {
            // Snippet: GetApiSpecAsync(string, CallSettings)
            // Additional: GetApiSpecAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            ApiSpec response = await registryClient.GetApiSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiSpec</summary>
        public void GetApiSpecResourceNames()
        {
            // Snippet: GetApiSpec(ApiSpecName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiSpecName name = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            ApiSpec response = registryClient.GetApiSpec(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiSpecAsync</summary>
        public async Task GetApiSpecResourceNamesAsync()
        {
            // Snippet: GetApiSpecAsync(ApiSpecName, CallSettings)
            // Additional: GetApiSpecAsync(ApiSpecName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiSpecName name = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            ApiSpec response = await registryClient.GetApiSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiSpecContents</summary>
        public void GetApiSpecContentsRequestObject()
        {
            // Snippet: GetApiSpecContents(GetApiSpecContentsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            GetApiSpecContentsRequest request = new GetApiSpecContentsRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            HttpBody response = registryClient.GetApiSpecContents(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiSpecContentsAsync</summary>
        public async Task GetApiSpecContentsRequestObjectAsync()
        {
            // Snippet: GetApiSpecContentsAsync(GetApiSpecContentsRequest, CallSettings)
            // Additional: GetApiSpecContentsAsync(GetApiSpecContentsRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetApiSpecContentsRequest request = new GetApiSpecContentsRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            HttpBody response = await registryClient.GetApiSpecContentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiSpecContents</summary>
        public void GetApiSpecContents()
        {
            // Snippet: GetApiSpecContents(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            HttpBody response = registryClient.GetApiSpecContents(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiSpecContentsAsync</summary>
        public async Task GetApiSpecContentsAsync()
        {
            // Snippet: GetApiSpecContentsAsync(string, CallSettings)
            // Additional: GetApiSpecContentsAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            HttpBody response = await registryClient.GetApiSpecContentsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiSpecContents</summary>
        public void GetApiSpecContentsResourceNames()
        {
            // Snippet: GetApiSpecContents(ApiSpecName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiSpecName name = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            HttpBody response = registryClient.GetApiSpecContents(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiSpecContentsAsync</summary>
        public async Task GetApiSpecContentsResourceNamesAsync()
        {
            // Snippet: GetApiSpecContentsAsync(ApiSpecName, CallSettings)
            // Additional: GetApiSpecContentsAsync(ApiSpecName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiSpecName name = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            HttpBody response = await registryClient.GetApiSpecContentsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateApiSpec</summary>
        public void CreateApiSpecRequestObject()
        {
            // Snippet: CreateApiSpec(CreateApiSpecRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            CreateApiSpecRequest request = new CreateApiSpecRequest
            {
                ParentAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                ApiSpec = new ApiSpec(),
                ApiSpecId = "",
            };
            // Make the request
            ApiSpec response = registryClient.CreateApiSpec(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApiSpecAsync</summary>
        public async Task CreateApiSpecRequestObjectAsync()
        {
            // Snippet: CreateApiSpecAsync(CreateApiSpecRequest, CallSettings)
            // Additional: CreateApiSpecAsync(CreateApiSpecRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateApiSpecRequest request = new CreateApiSpecRequest
            {
                ParentAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                ApiSpec = new ApiSpec(),
                ApiSpecId = "",
            };
            // Make the request
            ApiSpec response = await registryClient.CreateApiSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApiSpec</summary>
        public void CreateApiSpec()
        {
            // Snippet: CreateApiSpec(string, ApiSpec, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            ApiSpec apiSpec = new ApiSpec();
            string apiSpecId = "";
            // Make the request
            ApiSpec response = registryClient.CreateApiSpec(parent, apiSpec, apiSpecId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiSpecAsync</summary>
        public async Task CreateApiSpecAsync()
        {
            // Snippet: CreateApiSpecAsync(string, ApiSpec, string, CallSettings)
            // Additional: CreateApiSpecAsync(string, ApiSpec, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]";
            ApiSpec apiSpec = new ApiSpec();
            string apiSpecId = "";
            // Make the request
            ApiSpec response = await registryClient.CreateApiSpecAsync(parent, apiSpec, apiSpecId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiSpec</summary>
        public void CreateApiSpecResourceNames()
        {
            // Snippet: CreateApiSpec(ApiVersionName, ApiSpec, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiVersionName parent = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            ApiSpec apiSpec = new ApiSpec();
            string apiSpecId = "";
            // Make the request
            ApiSpec response = registryClient.CreateApiSpec(parent, apiSpec, apiSpecId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiSpecAsync</summary>
        public async Task CreateApiSpecResourceNamesAsync()
        {
            // Snippet: CreateApiSpecAsync(ApiVersionName, ApiSpec, string, CallSettings)
            // Additional: CreateApiSpecAsync(ApiVersionName, ApiSpec, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiVersionName parent = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            ApiSpec apiSpec = new ApiSpec();
            string apiSpecId = "";
            // Make the request
            ApiSpec response = await registryClient.CreateApiSpecAsync(parent, apiSpec, apiSpecId);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiSpec</summary>
        public void UpdateApiSpecRequestObject()
        {
            // Snippet: UpdateApiSpec(UpdateApiSpecRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            UpdateApiSpecRequest request = new UpdateApiSpecRequest
            {
                ApiSpec = new ApiSpec(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            ApiSpec response = registryClient.UpdateApiSpec(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiSpecAsync</summary>
        public async Task UpdateApiSpecRequestObjectAsync()
        {
            // Snippet: UpdateApiSpecAsync(UpdateApiSpecRequest, CallSettings)
            // Additional: UpdateApiSpecAsync(UpdateApiSpecRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApiSpecRequest request = new UpdateApiSpecRequest
            {
                ApiSpec = new ApiSpec(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            ApiSpec response = await registryClient.UpdateApiSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiSpec</summary>
        public void UpdateApiSpec()
        {
            // Snippet: UpdateApiSpec(ApiSpec, FieldMask, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiSpec apiSpec = new ApiSpec();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ApiSpec response = registryClient.UpdateApiSpec(apiSpec, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiSpecAsync</summary>
        public async Task UpdateApiSpecAsync()
        {
            // Snippet: UpdateApiSpecAsync(ApiSpec, FieldMask, CallSettings)
            // Additional: UpdateApiSpecAsync(ApiSpec, FieldMask, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiSpec apiSpec = new ApiSpec();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ApiSpec response = await registryClient.UpdateApiSpecAsync(apiSpec, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpec</summary>
        public void DeleteApiSpecRequestObject()
        {
            // Snippet: DeleteApiSpec(DeleteApiSpecRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            DeleteApiSpecRequest request = new DeleteApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Force = false,
            };
            // Make the request
            registryClient.DeleteApiSpec(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpecAsync</summary>
        public async Task DeleteApiSpecRequestObjectAsync()
        {
            // Snippet: DeleteApiSpecAsync(DeleteApiSpecRequest, CallSettings)
            // Additional: DeleteApiSpecAsync(DeleteApiSpecRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApiSpecRequest request = new DeleteApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Force = false,
            };
            // Make the request
            await registryClient.DeleteApiSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpec</summary>
        public void DeleteApiSpec()
        {
            // Snippet: DeleteApiSpec(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            registryClient.DeleteApiSpec(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpecAsync</summary>
        public async Task DeleteApiSpecAsync()
        {
            // Snippet: DeleteApiSpecAsync(string, CallSettings)
            // Additional: DeleteApiSpecAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            await registryClient.DeleteApiSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpec</summary>
        public void DeleteApiSpecResourceNames()
        {
            // Snippet: DeleteApiSpec(ApiSpecName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiSpecName name = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            registryClient.DeleteApiSpec(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpecAsync</summary>
        public async Task DeleteApiSpecResourceNamesAsync()
        {
            // Snippet: DeleteApiSpecAsync(ApiSpecName, CallSettings)
            // Additional: DeleteApiSpecAsync(ApiSpecName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiSpecName name = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            await registryClient.DeleteApiSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for TagApiSpecRevision</summary>
        public void TagApiSpecRevisionRequestObject()
        {
            // Snippet: TagApiSpecRevision(TagApiSpecRevisionRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            TagApiSpecRevisionRequest request = new TagApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Tag = "",
            };
            // Make the request
            ApiSpec response = registryClient.TagApiSpecRevision(request);
            // End snippet
        }

        /// <summary>Snippet for TagApiSpecRevisionAsync</summary>
        public async Task TagApiSpecRevisionRequestObjectAsync()
        {
            // Snippet: TagApiSpecRevisionAsync(TagApiSpecRevisionRequest, CallSettings)
            // Additional: TagApiSpecRevisionAsync(TagApiSpecRevisionRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            TagApiSpecRevisionRequest request = new TagApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Tag = "",
            };
            // Make the request
            ApiSpec response = await registryClient.TagApiSpecRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListApiSpecRevisions</summary>
        public void ListApiSpecRevisionsRequestObject()
        {
            // Snippet: ListApiSpecRevisions(ListApiSpecRevisionsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ListApiSpecRevisionsRequest request = new ListApiSpecRevisionsRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            PagedEnumerable<ListApiSpecRevisionsResponse, ApiSpec> response = registryClient.ListApiSpecRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiSpec item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiSpecRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiSpec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiSpec> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiSpec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiSpecRevisionsAsync</summary>
        public async Task ListApiSpecRevisionsRequestObjectAsync()
        {
            // Snippet: ListApiSpecRevisionsAsync(ListApiSpecRevisionsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListApiSpecRevisionsRequest request = new ListApiSpecRevisionsRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListApiSpecRevisionsResponse, ApiSpec> response = registryClient.ListApiSpecRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiSpec item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiSpecRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiSpec item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiSpec> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiSpec item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RollbackApiSpec</summary>
        public void RollbackApiSpecRequestObject()
        {
            // Snippet: RollbackApiSpec(RollbackApiSpecRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            RollbackApiSpecRequest request = new RollbackApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                RevisionId = "",
            };
            // Make the request
            ApiSpec response = registryClient.RollbackApiSpec(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackApiSpecAsync</summary>
        public async Task RollbackApiSpecRequestObjectAsync()
        {
            // Snippet: RollbackApiSpecAsync(RollbackApiSpecRequest, CallSettings)
            // Additional: RollbackApiSpecAsync(RollbackApiSpecRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            RollbackApiSpecRequest request = new RollbackApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                RevisionId = "",
            };
            // Make the request
            ApiSpec response = await registryClient.RollbackApiSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpecRevision</summary>
        public void DeleteApiSpecRevisionRequestObject()
        {
            // Snippet: DeleteApiSpecRevision(DeleteApiSpecRevisionRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            DeleteApiSpecRevisionRequest request = new DeleteApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            ApiSpec response = registryClient.DeleteApiSpecRevision(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpecRevisionAsync</summary>
        public async Task DeleteApiSpecRevisionRequestObjectAsync()
        {
            // Snippet: DeleteApiSpecRevisionAsync(DeleteApiSpecRevisionRequest, CallSettings)
            // Additional: DeleteApiSpecRevisionAsync(DeleteApiSpecRevisionRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApiSpecRevisionRequest request = new DeleteApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            // Make the request
            ApiSpec response = await registryClient.DeleteApiSpecRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpecRevision</summary>
        public void DeleteApiSpecRevision()
        {
            // Snippet: DeleteApiSpecRevision(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            ApiSpec response = registryClient.DeleteApiSpecRevision(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpecRevisionAsync</summary>
        public async Task DeleteApiSpecRevisionAsync()
        {
            // Snippet: DeleteApiSpecRevisionAsync(string, CallSettings)
            // Additional: DeleteApiSpecRevisionAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/versions/[VERSION]/specs/[SPEC]";
            // Make the request
            ApiSpec response = await registryClient.DeleteApiSpecRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpecRevision</summary>
        public void DeleteApiSpecRevisionResourceNames()
        {
            // Snippet: DeleteApiSpecRevision(ApiSpecName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiSpecName name = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            ApiSpec response = registryClient.DeleteApiSpecRevision(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiSpecRevisionAsync</summary>
        public async Task DeleteApiSpecRevisionResourceNamesAsync()
        {
            // Snippet: DeleteApiSpecRevisionAsync(ApiSpecName, CallSettings)
            // Additional: DeleteApiSpecRevisionAsync(ApiSpecName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiSpecName name = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            ApiSpec response = await registryClient.DeleteApiSpecRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListApiDeployments</summary>
        public void ListApiDeploymentsRequestObject()
        {
            // Snippet: ListApiDeployments(ListApiDeploymentsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ListApiDeploymentsRequest request = new ListApiDeploymentsRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListApiDeploymentsResponse, ApiDeployment> response = registryClient.ListApiDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiDeploymentsAsync</summary>
        public async Task ListApiDeploymentsRequestObjectAsync()
        {
            // Snippet: ListApiDeploymentsAsync(ListApiDeploymentsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListApiDeploymentsRequest request = new ListApiDeploymentsRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApiDeploymentsResponse, ApiDeployment> response = registryClient.ListApiDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiDeployments</summary>
        public void ListApiDeployments()
        {
            // Snippet: ListApiDeployments(string, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            PagedEnumerable<ListApiDeploymentsResponse, ApiDeployment> response = registryClient.ListApiDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiDeploymentsAsync</summary>
        public async Task ListApiDeploymentsAsync()
        {
            // Snippet: ListApiDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            // Make the request
            PagedAsyncEnumerable<ListApiDeploymentsResponse, ApiDeployment> response = registryClient.ListApiDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiDeployments</summary>
        public void ListApiDeploymentsResourceNames()
        {
            // Snippet: ListApiDeployments(ApiName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            PagedEnumerable<ListApiDeploymentsResponse, ApiDeployment> response = registryClient.ListApiDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiDeploymentsAsync</summary>
        public async Task ListApiDeploymentsResourceNamesAsync()
        {
            // Snippet: ListApiDeploymentsAsync(ApiName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            PagedAsyncEnumerable<ListApiDeploymentsResponse, ApiDeployment> response = registryClient.ListApiDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetApiDeployment</summary>
        public void GetApiDeploymentRequestObject()
        {
            // Snippet: GetApiDeployment(GetApiDeploymentRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            GetApiDeploymentRequest request = new GetApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            // Make the request
            ApiDeployment response = registryClient.GetApiDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiDeploymentAsync</summary>
        public async Task GetApiDeploymentRequestObjectAsync()
        {
            // Snippet: GetApiDeploymentAsync(GetApiDeploymentRequest, CallSettings)
            // Additional: GetApiDeploymentAsync(GetApiDeploymentRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetApiDeploymentRequest request = new GetApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            // Make the request
            ApiDeployment response = await registryClient.GetApiDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiDeployment</summary>
        public void GetApiDeployment()
        {
            // Snippet: GetApiDeployment(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/deployments/[DEPLOYMENT]";
            // Make the request
            ApiDeployment response = registryClient.GetApiDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiDeploymentAsync</summary>
        public async Task GetApiDeploymentAsync()
        {
            // Snippet: GetApiDeploymentAsync(string, CallSettings)
            // Additional: GetApiDeploymentAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/deployments/[DEPLOYMENT]";
            // Make the request
            ApiDeployment response = await registryClient.GetApiDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiDeployment</summary>
        public void GetApiDeploymentResourceNames()
        {
            // Snippet: GetApiDeployment(ApiDeploymentName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiDeploymentName name = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]");
            // Make the request
            ApiDeployment response = registryClient.GetApiDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiDeploymentAsync</summary>
        public async Task GetApiDeploymentResourceNamesAsync()
        {
            // Snippet: GetApiDeploymentAsync(ApiDeploymentName, CallSettings)
            // Additional: GetApiDeploymentAsync(ApiDeploymentName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiDeploymentName name = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]");
            // Make the request
            ApiDeployment response = await registryClient.GetApiDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateApiDeployment</summary>
        public void CreateApiDeploymentRequestObject()
        {
            // Snippet: CreateApiDeployment(CreateApiDeploymentRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            CreateApiDeploymentRequest request = new CreateApiDeploymentRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiDeployment = new ApiDeployment(),
                ApiDeploymentId = "",
            };
            // Make the request
            ApiDeployment response = registryClient.CreateApiDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApiDeploymentAsync</summary>
        public async Task CreateApiDeploymentRequestObjectAsync()
        {
            // Snippet: CreateApiDeploymentAsync(CreateApiDeploymentRequest, CallSettings)
            // Additional: CreateApiDeploymentAsync(CreateApiDeploymentRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateApiDeploymentRequest request = new CreateApiDeploymentRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiDeployment = new ApiDeployment(),
                ApiDeploymentId = "",
            };
            // Make the request
            ApiDeployment response = await registryClient.CreateApiDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApiDeployment</summary>
        public void CreateApiDeployment()
        {
            // Snippet: CreateApiDeployment(string, ApiDeployment, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            ApiDeployment apiDeployment = new ApiDeployment();
            string apiDeploymentId = "";
            // Make the request
            ApiDeployment response = registryClient.CreateApiDeployment(parent, apiDeployment, apiDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiDeploymentAsync</summary>
        public async Task CreateApiDeploymentAsync()
        {
            // Snippet: CreateApiDeploymentAsync(string, ApiDeployment, string, CallSettings)
            // Additional: CreateApiDeploymentAsync(string, ApiDeployment, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]";
            ApiDeployment apiDeployment = new ApiDeployment();
            string apiDeploymentId = "";
            // Make the request
            ApiDeployment response = await registryClient.CreateApiDeploymentAsync(parent, apiDeployment, apiDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiDeployment</summary>
        public void CreateApiDeploymentResourceNames()
        {
            // Snippet: CreateApiDeployment(ApiName, ApiDeployment, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            ApiDeployment apiDeployment = new ApiDeployment();
            string apiDeploymentId = "";
            // Make the request
            ApiDeployment response = registryClient.CreateApiDeployment(parent, apiDeployment, apiDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateApiDeploymentAsync</summary>
        public async Task CreateApiDeploymentResourceNamesAsync()
        {
            // Snippet: CreateApiDeploymentAsync(ApiName, ApiDeployment, string, CallSettings)
            // Additional: CreateApiDeploymentAsync(ApiName, ApiDeployment, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            ApiDeployment apiDeployment = new ApiDeployment();
            string apiDeploymentId = "";
            // Make the request
            ApiDeployment response = await registryClient.CreateApiDeploymentAsync(parent, apiDeployment, apiDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiDeployment</summary>
        public void UpdateApiDeploymentRequestObject()
        {
            // Snippet: UpdateApiDeployment(UpdateApiDeploymentRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            UpdateApiDeploymentRequest request = new UpdateApiDeploymentRequest
            {
                ApiDeployment = new ApiDeployment(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            ApiDeployment response = registryClient.UpdateApiDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiDeploymentAsync</summary>
        public async Task UpdateApiDeploymentRequestObjectAsync()
        {
            // Snippet: UpdateApiDeploymentAsync(UpdateApiDeploymentRequest, CallSettings)
            // Additional: UpdateApiDeploymentAsync(UpdateApiDeploymentRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApiDeploymentRequest request = new UpdateApiDeploymentRequest
            {
                ApiDeployment = new ApiDeployment(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            ApiDeployment response = await registryClient.UpdateApiDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiDeployment</summary>
        public void UpdateApiDeployment()
        {
            // Snippet: UpdateApiDeployment(ApiDeployment, FieldMask, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiDeployment apiDeployment = new ApiDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ApiDeployment response = registryClient.UpdateApiDeployment(apiDeployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateApiDeploymentAsync</summary>
        public async Task UpdateApiDeploymentAsync()
        {
            // Snippet: UpdateApiDeploymentAsync(ApiDeployment, FieldMask, CallSettings)
            // Additional: UpdateApiDeploymentAsync(ApiDeployment, FieldMask, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiDeployment apiDeployment = new ApiDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ApiDeployment response = await registryClient.UpdateApiDeploymentAsync(apiDeployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeployment</summary>
        public void DeleteApiDeploymentRequestObject()
        {
            // Snippet: DeleteApiDeployment(DeleteApiDeploymentRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            DeleteApiDeploymentRequest request = new DeleteApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Force = false,
            };
            // Make the request
            registryClient.DeleteApiDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeploymentAsync</summary>
        public async Task DeleteApiDeploymentRequestObjectAsync()
        {
            // Snippet: DeleteApiDeploymentAsync(DeleteApiDeploymentRequest, CallSettings)
            // Additional: DeleteApiDeploymentAsync(DeleteApiDeploymentRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApiDeploymentRequest request = new DeleteApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Force = false,
            };
            // Make the request
            await registryClient.DeleteApiDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeployment</summary>
        public void DeleteApiDeployment()
        {
            // Snippet: DeleteApiDeployment(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/deployments/[DEPLOYMENT]";
            // Make the request
            registryClient.DeleteApiDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeploymentAsync</summary>
        public async Task DeleteApiDeploymentAsync()
        {
            // Snippet: DeleteApiDeploymentAsync(string, CallSettings)
            // Additional: DeleteApiDeploymentAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/deployments/[DEPLOYMENT]";
            // Make the request
            await registryClient.DeleteApiDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeployment</summary>
        public void DeleteApiDeploymentResourceNames()
        {
            // Snippet: DeleteApiDeployment(ApiDeploymentName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiDeploymentName name = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]");
            // Make the request
            registryClient.DeleteApiDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeploymentAsync</summary>
        public async Task DeleteApiDeploymentResourceNamesAsync()
        {
            // Snippet: DeleteApiDeploymentAsync(ApiDeploymentName, CallSettings)
            // Additional: DeleteApiDeploymentAsync(ApiDeploymentName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiDeploymentName name = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]");
            // Make the request
            await registryClient.DeleteApiDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for TagApiDeploymentRevision</summary>
        public void TagApiDeploymentRevisionRequestObject()
        {
            // Snippet: TagApiDeploymentRevision(TagApiDeploymentRevisionRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            TagApiDeploymentRevisionRequest request = new TagApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Tag = "",
            };
            // Make the request
            ApiDeployment response = registryClient.TagApiDeploymentRevision(request);
            // End snippet
        }

        /// <summary>Snippet for TagApiDeploymentRevisionAsync</summary>
        public async Task TagApiDeploymentRevisionRequestObjectAsync()
        {
            // Snippet: TagApiDeploymentRevisionAsync(TagApiDeploymentRevisionRequest, CallSettings)
            // Additional: TagApiDeploymentRevisionAsync(TagApiDeploymentRevisionRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            TagApiDeploymentRevisionRequest request = new TagApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Tag = "",
            };
            // Make the request
            ApiDeployment response = await registryClient.TagApiDeploymentRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListApiDeploymentRevisions</summary>
        public void ListApiDeploymentRevisionsRequestObject()
        {
            // Snippet: ListApiDeploymentRevisions(ListApiDeploymentRevisionsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ListApiDeploymentRevisionsRequest request = new ListApiDeploymentRevisionsRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            // Make the request
            PagedEnumerable<ListApiDeploymentRevisionsResponse, ApiDeployment> response = registryClient.ListApiDeploymentRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiDeploymentRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiDeploymentRevisionsAsync</summary>
        public async Task ListApiDeploymentRevisionsRequestObjectAsync()
        {
            // Snippet: ListApiDeploymentRevisionsAsync(ListApiDeploymentRevisionsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListApiDeploymentRevisionsRequest request = new ListApiDeploymentRevisionsRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListApiDeploymentRevisionsResponse, ApiDeployment> response = registryClient.ListApiDeploymentRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiDeploymentRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RollbackApiDeployment</summary>
        public void RollbackApiDeploymentRequestObject()
        {
            // Snippet: RollbackApiDeployment(RollbackApiDeploymentRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            RollbackApiDeploymentRequest request = new RollbackApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                RevisionId = "",
            };
            // Make the request
            ApiDeployment response = registryClient.RollbackApiDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackApiDeploymentAsync</summary>
        public async Task RollbackApiDeploymentRequestObjectAsync()
        {
            // Snippet: RollbackApiDeploymentAsync(RollbackApiDeploymentRequest, CallSettings)
            // Additional: RollbackApiDeploymentAsync(RollbackApiDeploymentRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            RollbackApiDeploymentRequest request = new RollbackApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                RevisionId = "",
            };
            // Make the request
            ApiDeployment response = await registryClient.RollbackApiDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeploymentRevision</summary>
        public void DeleteApiDeploymentRevisionRequestObject()
        {
            // Snippet: DeleteApiDeploymentRevision(DeleteApiDeploymentRevisionRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            DeleteApiDeploymentRevisionRequest request = new DeleteApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            // Make the request
            ApiDeployment response = registryClient.DeleteApiDeploymentRevision(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeploymentRevisionAsync</summary>
        public async Task DeleteApiDeploymentRevisionRequestObjectAsync()
        {
            // Snippet: DeleteApiDeploymentRevisionAsync(DeleteApiDeploymentRevisionRequest, CallSettings)
            // Additional: DeleteApiDeploymentRevisionAsync(DeleteApiDeploymentRevisionRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApiDeploymentRevisionRequest request = new DeleteApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            // Make the request
            ApiDeployment response = await registryClient.DeleteApiDeploymentRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeploymentRevision</summary>
        public void DeleteApiDeploymentRevision()
        {
            // Snippet: DeleteApiDeploymentRevision(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/deployments/[DEPLOYMENT]";
            // Make the request
            ApiDeployment response = registryClient.DeleteApiDeploymentRevision(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeploymentRevisionAsync</summary>
        public async Task DeleteApiDeploymentRevisionAsync()
        {
            // Snippet: DeleteApiDeploymentRevisionAsync(string, CallSettings)
            // Additional: DeleteApiDeploymentRevisionAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apis/[API]/deployments/[DEPLOYMENT]";
            // Make the request
            ApiDeployment response = await registryClient.DeleteApiDeploymentRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeploymentRevision</summary>
        public void DeleteApiDeploymentRevisionResourceNames()
        {
            // Snippet: DeleteApiDeploymentRevision(ApiDeploymentName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiDeploymentName name = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]");
            // Make the request
            ApiDeployment response = registryClient.DeleteApiDeploymentRevision(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteApiDeploymentRevisionAsync</summary>
        public async Task DeleteApiDeploymentRevisionResourceNamesAsync()
        {
            // Snippet: DeleteApiDeploymentRevisionAsync(ApiDeploymentName, CallSettings)
            // Additional: DeleteApiDeploymentRevisionAsync(ApiDeploymentName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiDeploymentName name = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]");
            // Make the request
            ApiDeployment response = await registryClient.DeleteApiDeploymentRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifactsRequestObject()
        {
            // Snippet: ListArtifacts(ListArtifactsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifacts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsRequestObjectAsync()
        {
            // Snippet: ListArtifactsAsync(ListArtifactsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifactsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifacts()
        {
            // Snippet: ListArtifacts(string, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsAsync()
        {
            // Snippet: ListArtifactsAsync(string, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifactsResourceNames1()
        {
            // Snippet: ListArtifacts(LocationName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsResourceNames1Async()
        {
            // Snippet: ListArtifactsAsync(LocationName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifactsResourceNames2()
        {
            // Snippet: ListArtifacts(ApiName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsResourceNames2Async()
        {
            // Snippet: ListArtifactsAsync(ApiName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifactsResourceNames3()
        {
            // Snippet: ListArtifacts(ApiVersionName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiVersionName parent = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsResourceNames3Async()
        {
            // Snippet: ListArtifactsAsync(ApiVersionName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiVersionName parent = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifactsResourceNames4()
        {
            // Snippet: ListArtifacts(ApiSpecName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiSpecName parent = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsResourceNames4Async()
        {
            // Snippet: ListArtifactsAsync(ApiSpecName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiSpecName parent = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifactsResourceNames5()
        {
            // Snippet: ListArtifacts(ApiDeploymentName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiDeploymentName parent = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]");
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsResourceNames5Async()
        {
            // Snippet: ListArtifactsAsync(ApiDeploymentName, string, int?, CallSettings)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiDeploymentName parent = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]");
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response = registryClient.ListArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetArtifact</summary>
        public void GetArtifactRequestObject()
        {
            // Snippet: GetArtifact(GetArtifactRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            // Make the request
            Artifact response = registryClient.GetArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactAsync</summary>
        public async Task GetArtifactRequestObjectAsync()
        {
            // Snippet: GetArtifactAsync(GetArtifactRequest, CallSettings)
            // Additional: GetArtifactAsync(GetArtifactRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            // Make the request
            Artifact response = await registryClient.GetArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetArtifact</summary>
        public void GetArtifact()
        {
            // Snippet: GetArtifact(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/artifacts/[ARTIFACT]";
            // Make the request
            Artifact response = registryClient.GetArtifact(name);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactAsync</summary>
        public async Task GetArtifactAsync()
        {
            // Snippet: GetArtifactAsync(string, CallSettings)
            // Additional: GetArtifactAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/artifacts/[ARTIFACT]";
            // Make the request
            Artifact response = await registryClient.GetArtifactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetArtifact</summary>
        public void GetArtifactResourceNames()
        {
            // Snippet: GetArtifact(ArtifactName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ArtifactName name = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]");
            // Make the request
            Artifact response = registryClient.GetArtifact(name);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactAsync</summary>
        public async Task GetArtifactResourceNamesAsync()
        {
            // Snippet: GetArtifactAsync(ArtifactName, CallSettings)
            // Additional: GetArtifactAsync(ArtifactName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ArtifactName name = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]");
            // Make the request
            Artifact response = await registryClient.GetArtifactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactContents</summary>
        public void GetArtifactContentsRequestObject()
        {
            // Snippet: GetArtifactContents(GetArtifactContentsRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            GetArtifactContentsRequest request = new GetArtifactContentsRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            // Make the request
            HttpBody response = registryClient.GetArtifactContents(request);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactContentsAsync</summary>
        public async Task GetArtifactContentsRequestObjectAsync()
        {
            // Snippet: GetArtifactContentsAsync(GetArtifactContentsRequest, CallSettings)
            // Additional: GetArtifactContentsAsync(GetArtifactContentsRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetArtifactContentsRequest request = new GetArtifactContentsRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            // Make the request
            HttpBody response = await registryClient.GetArtifactContentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactContents</summary>
        public void GetArtifactContents()
        {
            // Snippet: GetArtifactContents(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/artifacts/[ARTIFACT]";
            // Make the request
            HttpBody response = registryClient.GetArtifactContents(name);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactContentsAsync</summary>
        public async Task GetArtifactContentsAsync()
        {
            // Snippet: GetArtifactContentsAsync(string, CallSettings)
            // Additional: GetArtifactContentsAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/artifacts/[ARTIFACT]";
            // Make the request
            HttpBody response = await registryClient.GetArtifactContentsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactContents</summary>
        public void GetArtifactContentsResourceNames()
        {
            // Snippet: GetArtifactContents(ArtifactName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ArtifactName name = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]");
            // Make the request
            HttpBody response = registryClient.GetArtifactContents(name);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactContentsAsync</summary>
        public async Task GetArtifactContentsResourceNamesAsync()
        {
            // Snippet: GetArtifactContentsAsync(ArtifactName, CallSettings)
            // Additional: GetArtifactContentsAsync(ArtifactName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ArtifactName name = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]");
            // Make the request
            HttpBody response = await registryClient.GetArtifactContentsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifactRequestObject()
        {
            // Snippet: CreateArtifact(CreateArtifactRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "",
            };
            // Make the request
            Artifact response = registryClient.CreateArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactRequestObjectAsync()
        {
            // Snippet: CreateArtifactAsync(CreateArtifactRequest, CallSettings)
            // Additional: CreateArtifactAsync(CreateArtifactRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "",
            };
            // Make the request
            Artifact response = await registryClient.CreateArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifact()
        {
            // Snippet: CreateArtifact(string, Artifact, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = registryClient.CreateArtifact(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactAsync()
        {
            // Snippet: CreateArtifactAsync(string, Artifact, string, CallSettings)
            // Additional: CreateArtifactAsync(string, Artifact, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = await registryClient.CreateArtifactAsync(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifactResourceNames1()
        {
            // Snippet: CreateArtifact(LocationName, Artifact, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = registryClient.CreateArtifact(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactResourceNames1Async()
        {
            // Snippet: CreateArtifactAsync(LocationName, Artifact, string, CallSettings)
            // Additional: CreateArtifactAsync(LocationName, Artifact, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = await registryClient.CreateArtifactAsync(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifactResourceNames2()
        {
            // Snippet: CreateArtifact(ApiName, Artifact, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = registryClient.CreateArtifact(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactResourceNames2Async()
        {
            // Snippet: CreateArtifactAsync(ApiName, Artifact, string, CallSettings)
            // Additional: CreateArtifactAsync(ApiName, Artifact, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = await registryClient.CreateArtifactAsync(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifactResourceNames3()
        {
            // Snippet: CreateArtifact(ApiVersionName, Artifact, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiVersionName parent = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = registryClient.CreateArtifact(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactResourceNames3Async()
        {
            // Snippet: CreateArtifactAsync(ApiVersionName, Artifact, string, CallSettings)
            // Additional: CreateArtifactAsync(ApiVersionName, Artifact, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiVersionName parent = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = await registryClient.CreateArtifactAsync(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifactResourceNames4()
        {
            // Snippet: CreateArtifact(ApiSpecName, Artifact, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiSpecName parent = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = registryClient.CreateArtifact(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactResourceNames4Async()
        {
            // Snippet: CreateArtifactAsync(ApiSpecName, Artifact, string, CallSettings)
            // Additional: CreateArtifactAsync(ApiSpecName, Artifact, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiSpecName parent = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = await registryClient.CreateArtifactAsync(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifactResourceNames5()
        {
            // Snippet: CreateArtifact(ApiDeploymentName, Artifact, string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ApiDeploymentName parent = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = registryClient.CreateArtifact(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactResourceNames5Async()
        {
            // Snippet: CreateArtifactAsync(ApiDeploymentName, Artifact, string, CallSettings)
            // Additional: CreateArtifactAsync(ApiDeploymentName, Artifact, string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ApiDeploymentName parent = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = await registryClient.CreateArtifactAsync(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for ReplaceArtifact</summary>
        public void ReplaceArtifactRequestObject()
        {
            // Snippet: ReplaceArtifact(ReplaceArtifactRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ReplaceArtifactRequest request = new ReplaceArtifactRequest
            {
                Artifact = new Artifact(),
            };
            // Make the request
            Artifact response = registryClient.ReplaceArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for ReplaceArtifactAsync</summary>
        public async Task ReplaceArtifactRequestObjectAsync()
        {
            // Snippet: ReplaceArtifactAsync(ReplaceArtifactRequest, CallSettings)
            // Additional: ReplaceArtifactAsync(ReplaceArtifactRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ReplaceArtifactRequest request = new ReplaceArtifactRequest
            {
                Artifact = new Artifact(),
            };
            // Make the request
            Artifact response = await registryClient.ReplaceArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReplaceArtifact</summary>
        public void ReplaceArtifact()
        {
            // Snippet: ReplaceArtifact(Artifact, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            Artifact artifact = new Artifact();
            // Make the request
            Artifact response = registryClient.ReplaceArtifact(artifact);
            // End snippet
        }

        /// <summary>Snippet for ReplaceArtifactAsync</summary>
        public async Task ReplaceArtifactAsync()
        {
            // Snippet: ReplaceArtifactAsync(Artifact, CallSettings)
            // Additional: ReplaceArtifactAsync(Artifact, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            Artifact artifact = new Artifact();
            // Make the request
            Artifact response = await registryClient.ReplaceArtifactAsync(artifact);
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifact</summary>
        public void DeleteArtifactRequestObject()
        {
            // Snippet: DeleteArtifact(DeleteArtifactRequest, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            // Make the request
            registryClient.DeleteArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifactAsync</summary>
        public async Task DeleteArtifactRequestObjectAsync()
        {
            // Snippet: DeleteArtifactAsync(DeleteArtifactRequest, CallSettings)
            // Additional: DeleteArtifactAsync(DeleteArtifactRequest, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            // Make the request
            await registryClient.DeleteArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifact</summary>
        public void DeleteArtifact()
        {
            // Snippet: DeleteArtifact(string, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/artifacts/[ARTIFACT]";
            // Make the request
            registryClient.DeleteArtifact(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifactAsync</summary>
        public async Task DeleteArtifactAsync()
        {
            // Snippet: DeleteArtifactAsync(string, CallSettings)
            // Additional: DeleteArtifactAsync(string, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/artifacts/[ARTIFACT]";
            // Make the request
            await registryClient.DeleteArtifactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifact</summary>
        public void DeleteArtifactResourceNames()
        {
            // Snippet: DeleteArtifact(ArtifactName, CallSettings)
            // Create client
            RegistryClient registryClient = RegistryClient.Create();
            // Initialize request argument(s)
            ArtifactName name = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]");
            // Make the request
            registryClient.DeleteArtifact(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifactAsync</summary>
        public async Task DeleteArtifactResourceNamesAsync()
        {
            // Snippet: DeleteArtifactAsync(ArtifactName, CallSettings)
            // Additional: DeleteArtifactAsync(ArtifactName, CancellationToken)
            // Create client
            RegistryClient registryClient = await RegistryClient.CreateAsync();
            // Initialize request argument(s)
            ArtifactName name = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]");
            // Make the request
            await registryClient.DeleteArtifactAsync(name);
            // End snippet
        }
    }
}
