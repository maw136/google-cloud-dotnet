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

namespace Google.Cloud.ApiGateway.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcav = Google.Cloud.ApiGateway.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedApiGatewayServiceClientSnippets
    {
        /// <summary>Snippet for ListGateways</summary>
        public void ListGatewaysRequestObject()
        {
            // Snippet: ListGateways(ListGatewaysRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            ListGatewaysRequest request = new ListGatewaysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListGatewaysResponse, Gateway> response = apiGatewayServiceClient.ListGateways(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Gateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaysAsync</summary>
        public async Task ListGatewaysRequestObjectAsync()
        {
            // Snippet: ListGatewaysAsync(ListGatewaysRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGatewaysRequest request = new ListGatewaysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListGatewaysResponse, Gateway> response = apiGatewayServiceClient.ListGatewaysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Gateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGateways</summary>
        public void ListGateways()
        {
            // Snippet: ListGateways(string, string, int?, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListGatewaysResponse, Gateway> response = apiGatewayServiceClient.ListGateways(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Gateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaysAsync</summary>
        public async Task ListGatewaysAsync()
        {
            // Snippet: ListGatewaysAsync(string, string, int?, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListGatewaysResponse, Gateway> response = apiGatewayServiceClient.ListGatewaysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Gateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGateways</summary>
        public void ListGatewaysResourceNames()
        {
            // Snippet: ListGateways(LocationName, string, int?, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListGatewaysResponse, Gateway> response = apiGatewayServiceClient.ListGateways(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Gateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGatewaysAsync</summary>
        public async Task ListGatewaysResourceNamesAsync()
        {
            // Snippet: ListGatewaysAsync(LocationName, string, int?, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListGatewaysResponse, Gateway> response = apiGatewayServiceClient.ListGatewaysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Gateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Gateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Gateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Gateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGateway</summary>
        public void GetGatewayRequestObject()
        {
            // Snippet: GetGateway(GetGatewayRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            GetGatewayRequest request = new GetGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            // Make the request
            Gateway response = apiGatewayServiceClient.GetGateway(request);
            // End snippet
        }

        /// <summary>Snippet for GetGatewayAsync</summary>
        public async Task GetGatewayRequestObjectAsync()
        {
            // Snippet: GetGatewayAsync(GetGatewayRequest, CallSettings)
            // Additional: GetGatewayAsync(GetGatewayRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGatewayRequest request = new GetGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            // Make the request
            Gateway response = await apiGatewayServiceClient.GetGatewayAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGateway</summary>
        public void GetGateway()
        {
            // Snippet: GetGateway(string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]";
            // Make the request
            Gateway response = apiGatewayServiceClient.GetGateway(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewayAsync</summary>
        public async Task GetGatewayAsync()
        {
            // Snippet: GetGatewayAsync(string, CallSettings)
            // Additional: GetGatewayAsync(string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]";
            // Make the request
            Gateway response = await apiGatewayServiceClient.GetGatewayAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGateway</summary>
        public void GetGatewayResourceNames()
        {
            // Snippet: GetGateway(GatewayName, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            GatewayName name = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]");
            // Make the request
            Gateway response = apiGatewayServiceClient.GetGateway(name);
            // End snippet
        }

        /// <summary>Snippet for GetGatewayAsync</summary>
        public async Task GetGatewayResourceNamesAsync()
        {
            // Snippet: GetGatewayAsync(GatewayName, CallSettings)
            // Additional: GetGatewayAsync(GatewayName, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            GatewayName name = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]");
            // Make the request
            Gateway response = await apiGatewayServiceClient.GetGatewayAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGateway</summary>
        public void CreateGatewayRequestObject()
        {
            // Snippet: CreateGateway(CreateGatewayRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            CreateGatewayRequest request = new CreateGatewayRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GatewayId = "",
                Gateway = new Gateway(),
            };
            // Make the request
            Operation<Gateway, OperationMetadata> response = apiGatewayServiceClient.CreateGateway(request);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceCreateGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewayAsync</summary>
        public async Task CreateGatewayRequestObjectAsync()
        {
            // Snippet: CreateGatewayAsync(CreateGatewayRequest, CallSettings)
            // Additional: CreateGatewayAsync(CreateGatewayRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGatewayRequest request = new CreateGatewayRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GatewayId = "",
                Gateway = new Gateway(),
            };
            // Make the request
            Operation<Gateway, OperationMetadata> response = await apiGatewayServiceClient.CreateGatewayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceCreateGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGateway</summary>
        public void CreateGateway()
        {
            // Snippet: CreateGateway(string, Gateway, string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Gateway gateway = new Gateway();
            string gatewayId = "";
            // Make the request
            Operation<Gateway, OperationMetadata> response = apiGatewayServiceClient.CreateGateway(parent, gateway, gatewayId);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceCreateGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewayAsync</summary>
        public async Task CreateGatewayAsync()
        {
            // Snippet: CreateGatewayAsync(string, Gateway, string, CallSettings)
            // Additional: CreateGatewayAsync(string, Gateway, string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Gateway gateway = new Gateway();
            string gatewayId = "";
            // Make the request
            Operation<Gateway, OperationMetadata> response = await apiGatewayServiceClient.CreateGatewayAsync(parent, gateway, gatewayId);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceCreateGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGateway</summary>
        public void CreateGatewayResourceNames()
        {
            // Snippet: CreateGateway(LocationName, Gateway, string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Gateway gateway = new Gateway();
            string gatewayId = "";
            // Make the request
            Operation<Gateway, OperationMetadata> response = apiGatewayServiceClient.CreateGateway(parent, gateway, gatewayId);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceCreateGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGatewayAsync</summary>
        public async Task CreateGatewayResourceNamesAsync()
        {
            // Snippet: CreateGatewayAsync(LocationName, Gateway, string, CallSettings)
            // Additional: CreateGatewayAsync(LocationName, Gateway, string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Gateway gateway = new Gateway();
            string gatewayId = "";
            // Make the request
            Operation<Gateway, OperationMetadata> response = await apiGatewayServiceClient.CreateGatewayAsync(parent, gateway, gatewayId);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceCreateGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGateway</summary>
        public void UpdateGatewayRequestObject()
        {
            // Snippet: UpdateGateway(UpdateGatewayRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            UpdateGatewayRequest request = new UpdateGatewayRequest
            {
                UpdateMask = new FieldMask(),
                Gateway = new Gateway(),
            };
            // Make the request
            Operation<Gateway, OperationMetadata> response = apiGatewayServiceClient.UpdateGateway(request);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceUpdateGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewayAsync</summary>
        public async Task UpdateGatewayRequestObjectAsync()
        {
            // Snippet: UpdateGatewayAsync(UpdateGatewayRequest, CallSettings)
            // Additional: UpdateGatewayAsync(UpdateGatewayRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGatewayRequest request = new UpdateGatewayRequest
            {
                UpdateMask = new FieldMask(),
                Gateway = new Gateway(),
            };
            // Make the request
            Operation<Gateway, OperationMetadata> response = await apiGatewayServiceClient.UpdateGatewayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceUpdateGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGateway</summary>
        public void UpdateGateway()
        {
            // Snippet: UpdateGateway(Gateway, FieldMask, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            Gateway gateway = new Gateway();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Gateway, OperationMetadata> response = apiGatewayServiceClient.UpdateGateway(gateway, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceUpdateGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGatewayAsync</summary>
        public async Task UpdateGatewayAsync()
        {
            // Snippet: UpdateGatewayAsync(Gateway, FieldMask, CallSettings)
            // Additional: UpdateGatewayAsync(Gateway, FieldMask, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            Gateway gateway = new Gateway();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Gateway, OperationMetadata> response = await apiGatewayServiceClient.UpdateGatewayAsync(gateway, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceUpdateGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGateway</summary>
        public void DeleteGatewayRequestObject()
        {
            // Snippet: DeleteGateway(DeleteGatewayRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            DeleteGatewayRequest request = new DeleteGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = apiGatewayServiceClient.DeleteGateway(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceDeleteGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewayAsync</summary>
        public async Task DeleteGatewayRequestObjectAsync()
        {
            // Snippet: DeleteGatewayAsync(DeleteGatewayRequest, CallSettings)
            // Additional: DeleteGatewayAsync(DeleteGatewayRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGatewayRequest request = new DeleteGatewayRequest
            {
                GatewayName = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiGatewayServiceClient.DeleteGatewayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceDeleteGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGateway</summary>
        public void DeleteGateway()
        {
            // Snippet: DeleteGateway(string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = apiGatewayServiceClient.DeleteGateway(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceDeleteGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewayAsync</summary>
        public async Task DeleteGatewayAsync()
        {
            // Snippet: DeleteGatewayAsync(string, CallSettings)
            // Additional: DeleteGatewayAsync(string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gateways/[GATEWAY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiGatewayServiceClient.DeleteGatewayAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceDeleteGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGateway</summary>
        public void DeleteGatewayResourceNames()
        {
            // Snippet: DeleteGateway(GatewayName, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            GatewayName name = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = apiGatewayServiceClient.DeleteGateway(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceDeleteGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGatewayAsync</summary>
        public async Task DeleteGatewayResourceNamesAsync()
        {
            // Snippet: DeleteGatewayAsync(GatewayName, CallSettings)
            // Additional: DeleteGatewayAsync(GatewayName, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            GatewayName name = GatewayName.FromProjectLocationGateway("[PROJECT]", "[LOCATION]", "[GATEWAY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiGatewayServiceClient.DeleteGatewayAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceDeleteGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListApis</summary>
        public void ListApisRequestObject()
        {
            // Snippet: ListApis(ListApisRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            ListApisRequest request = new ListApisRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListApisResponse, gcav::Api> response = apiGatewayServiceClient.ListApis(request);

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
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListApisRequest request = new ListApisRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApisResponse, gcav::Api> response = apiGatewayServiceClient.ListApisAsync(request);

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
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListApisResponse, gcav::Api> response = apiGatewayServiceClient.ListApis(parent);

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
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListApisResponse, gcav::Api> response = apiGatewayServiceClient.ListApisAsync(parent);

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
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListApisResponse, gcav::Api> response = apiGatewayServiceClient.ListApis(parent);

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
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListApisResponse, gcav::Api> response = apiGatewayServiceClient.ListApisAsync(parent);

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
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
            };
            // Make the request
            gcav::Api response = apiGatewayServiceClient.GetApi(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiAsync</summary>
        public async Task GetApiRequestObjectAsync()
        {
            // Snippet: GetApiAsync(GetApiRequest, CallSettings)
            // Additional: GetApiAsync(GetApiRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
            };
            // Make the request
            gcav::Api response = await apiGatewayServiceClient.GetApiAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApi</summary>
        public void GetApi()
        {
            // Snippet: GetApi(string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/apis/[API]";
            // Make the request
            gcav::Api response = apiGatewayServiceClient.GetApi(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiAsync</summary>
        public async Task GetApiAsync()
        {
            // Snippet: GetApiAsync(string, CallSettings)
            // Additional: GetApiAsync(string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/apis/[API]";
            // Make the request
            gcav::Api response = await apiGatewayServiceClient.GetApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApi</summary>
        public void GetApiResourceNames()
        {
            // Snippet: GetApi(ApiName, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            ApiName name = ApiName.FromProjectApi("[PROJECT]", "[API]");
            // Make the request
            gcav::Api response = apiGatewayServiceClient.GetApi(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiAsync</summary>
        public async Task GetApiResourceNamesAsync()
        {
            // Snippet: GetApiAsync(ApiName, CallSettings)
            // Additional: GetApiAsync(ApiName, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApiName name = ApiName.FromProjectApi("[PROJECT]", "[API]");
            // Make the request
            gcav::Api response = await apiGatewayServiceClient.GetApiAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateApi</summary>
        public void CreateApiRequestObject()
        {
            // Snippet: CreateApi(CreateApiRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            CreateApiRequest request = new CreateApiRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ApiId = "",
                Api = new gcav::Api(),
            };
            // Make the request
            Operation<gcav::Api, OperationMetadata> response = apiGatewayServiceClient.CreateApi(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Api, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Api result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Api, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceCreateApi(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Api retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiAsync</summary>
        public async Task CreateApiRequestObjectAsync()
        {
            // Snippet: CreateApiAsync(CreateApiRequest, CallSettings)
            // Additional: CreateApiAsync(CreateApiRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateApiRequest request = new CreateApiRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ApiId = "",
                Api = new gcav::Api(),
            };
            // Make the request
            Operation<gcav::Api, OperationMetadata> response = await apiGatewayServiceClient.CreateApiAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Api, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Api result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Api, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceCreateApiAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Api retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApi</summary>
        public void CreateApi()
        {
            // Snippet: CreateApi(string, Api, string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            Operation<gcav::Api, OperationMetadata> response = apiGatewayServiceClient.CreateApi(parent, api, apiId);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Api, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Api result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Api, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceCreateApi(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Api retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiAsync</summary>
        public async Task CreateApiAsync()
        {
            // Snippet: CreateApiAsync(string, Api, string, CallSettings)
            // Additional: CreateApiAsync(string, Api, string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            Operation<gcav::Api, OperationMetadata> response = await apiGatewayServiceClient.CreateApiAsync(parent, api, apiId);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Api, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Api result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Api, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceCreateApiAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Api retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApi</summary>
        public void CreateApiResourceNames()
        {
            // Snippet: CreateApi(LocationName, Api, string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            Operation<gcav::Api, OperationMetadata> response = apiGatewayServiceClient.CreateApi(parent, api, apiId);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Api, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Api result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Api, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceCreateApi(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Api retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiAsync</summary>
        public async Task CreateApiResourceNamesAsync()
        {
            // Snippet: CreateApiAsync(LocationName, Api, string, CallSettings)
            // Additional: CreateApiAsync(LocationName, Api, string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Api api = new gcav::Api();
            string apiId = "";
            // Make the request
            Operation<gcav::Api, OperationMetadata> response = await apiGatewayServiceClient.CreateApiAsync(parent, api, apiId);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Api, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Api result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Api, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceCreateApiAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Api retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApi</summary>
        public void UpdateApiRequestObject()
        {
            // Snippet: UpdateApi(UpdateApiRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            UpdateApiRequest request = new UpdateApiRequest
            {
                UpdateMask = new FieldMask(),
                Api = new gcav::Api(),
            };
            // Make the request
            Operation<gcav::Api, OperationMetadata> response = apiGatewayServiceClient.UpdateApi(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Api, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Api result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Api, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceUpdateApi(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Api retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApiAsync</summary>
        public async Task UpdateApiRequestObjectAsync()
        {
            // Snippet: UpdateApiAsync(UpdateApiRequest, CallSettings)
            // Additional: UpdateApiAsync(UpdateApiRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApiRequest request = new UpdateApiRequest
            {
                UpdateMask = new FieldMask(),
                Api = new gcav::Api(),
            };
            // Make the request
            Operation<gcav::Api, OperationMetadata> response = await apiGatewayServiceClient.UpdateApiAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Api, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Api result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Api, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceUpdateApiAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Api retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApi</summary>
        public void UpdateApi()
        {
            // Snippet: UpdateApi(Api, FieldMask, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            gcav::Api api = new gcav::Api();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcav::Api, OperationMetadata> response = apiGatewayServiceClient.UpdateApi(api, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Api, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Api result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Api, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceUpdateApi(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Api retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApiAsync</summary>
        public async Task UpdateApiAsync()
        {
            // Snippet: UpdateApiAsync(Api, FieldMask, CallSettings)
            // Additional: UpdateApiAsync(Api, FieldMask, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcav::Api api = new gcav::Api();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcav::Api, OperationMetadata> response = await apiGatewayServiceClient.UpdateApiAsync(api, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Api, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Api result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Api, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceUpdateApiAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Api retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApi</summary>
        public void DeleteApiRequestObject()
        {
            // Snippet: DeleteApi(DeleteApiRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            DeleteApiRequest request = new DeleteApiRequest
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = apiGatewayServiceClient.DeleteApi(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceDeleteApi(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApiAsync</summary>
        public async Task DeleteApiRequestObjectAsync()
        {
            // Snippet: DeleteApiAsync(DeleteApiRequest, CallSettings)
            // Additional: DeleteApiAsync(DeleteApiRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApiRequest request = new DeleteApiRequest
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiGatewayServiceClient.DeleteApiAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceDeleteApiAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApi</summary>
        public void DeleteApi()
        {
            // Snippet: DeleteApi(string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/apis/[API]";
            // Make the request
            Operation<Empty, OperationMetadata> response = apiGatewayServiceClient.DeleteApi(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceDeleteApi(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApiAsync</summary>
        public async Task DeleteApiAsync()
        {
            // Snippet: DeleteApiAsync(string, CallSettings)
            // Additional: DeleteApiAsync(string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/apis/[API]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiGatewayServiceClient.DeleteApiAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceDeleteApiAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApi</summary>
        public void DeleteApiResourceNames()
        {
            // Snippet: DeleteApi(ApiName, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            ApiName name = ApiName.FromProjectApi("[PROJECT]", "[API]");
            // Make the request
            Operation<Empty, OperationMetadata> response = apiGatewayServiceClient.DeleteApi(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceDeleteApi(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApiAsync</summary>
        public async Task DeleteApiResourceNamesAsync()
        {
            // Snippet: DeleteApiAsync(ApiName, CallSettings)
            // Additional: DeleteApiAsync(ApiName, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApiName name = ApiName.FromProjectApi("[PROJECT]", "[API]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiGatewayServiceClient.DeleteApiAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceDeleteApiAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListApiConfigs</summary>
        public void ListApiConfigsRequestObject()
        {
            // Snippet: ListApiConfigs(ListApiConfigsRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            ListApiConfigsRequest request = new ListApiConfigsRequest
            {
                ParentAsApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListApiConfigsResponse, ApiConfig> response = apiGatewayServiceClient.ListApiConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiConfigsAsync</summary>
        public async Task ListApiConfigsRequestObjectAsync()
        {
            // Snippet: ListApiConfigsAsync(ListApiConfigsRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListApiConfigsRequest request = new ListApiConfigsRequest
            {
                ParentAsApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApiConfigsResponse, ApiConfig> response = apiGatewayServiceClient.ListApiConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiConfigs</summary>
        public void ListApiConfigs()
        {
            // Snippet: ListApiConfigs(string, string, int?, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/global/apis/[API]";
            // Make the request
            PagedEnumerable<ListApiConfigsResponse, ApiConfig> response = apiGatewayServiceClient.ListApiConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiConfigsAsync</summary>
        public async Task ListApiConfigsAsync()
        {
            // Snippet: ListApiConfigsAsync(string, string, int?, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/global/apis/[API]";
            // Make the request
            PagedAsyncEnumerable<ListApiConfigsResponse, ApiConfig> response = apiGatewayServiceClient.ListApiConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiConfigs</summary>
        public void ListApiConfigsResourceNames()
        {
            // Snippet: ListApiConfigs(ApiName, string, int?, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectApi("[PROJECT]", "[API]");
            // Make the request
            PagedEnumerable<ListApiConfigsResponse, ApiConfig> response = apiGatewayServiceClient.ListApiConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApiConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApiConfigsAsync</summary>
        public async Task ListApiConfigsResourceNamesAsync()
        {
            // Snippet: ListApiConfigsAsync(ApiName, string, int?, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectApi("[PROJECT]", "[API]");
            // Make the request
            PagedAsyncEnumerable<ListApiConfigsResponse, ApiConfig> response = apiGatewayServiceClient.ListApiConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApiConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApiConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetApiConfig</summary>
        public void GetApiConfigRequestObject()
        {
            // Snippet: GetApiConfig(GetApiConfigRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            GetApiConfigRequest request = new GetApiConfigRequest
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
                View = GetApiConfigRequest.Types.ConfigView.Unspecified,
            };
            // Make the request
            ApiConfig response = apiGatewayServiceClient.GetApiConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiConfigAsync</summary>
        public async Task GetApiConfigRequestObjectAsync()
        {
            // Snippet: GetApiConfigAsync(GetApiConfigRequest, CallSettings)
            // Additional: GetApiConfigAsync(GetApiConfigRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetApiConfigRequest request = new GetApiConfigRequest
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
                View = GetApiConfigRequest.Types.ConfigView.Unspecified,
            };
            // Make the request
            ApiConfig response = await apiGatewayServiceClient.GetApiConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiConfig</summary>
        public void GetApiConfig()
        {
            // Snippet: GetApiConfig(string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/apis/[API]/configs/[API_CONFIG]";
            // Make the request
            ApiConfig response = apiGatewayServiceClient.GetApiConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiConfigAsync</summary>
        public async Task GetApiConfigAsync()
        {
            // Snippet: GetApiConfigAsync(string, CallSettings)
            // Additional: GetApiConfigAsync(string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/apis/[API]/configs/[API_CONFIG]";
            // Make the request
            ApiConfig response = await apiGatewayServiceClient.GetApiConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiConfig</summary>
        public void GetApiConfigResourceNames()
        {
            // Snippet: GetApiConfig(ApiConfigName, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            ApiConfigName name = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]");
            // Make the request
            ApiConfig response = apiGatewayServiceClient.GetApiConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiConfigAsync</summary>
        public async Task GetApiConfigResourceNamesAsync()
        {
            // Snippet: GetApiConfigAsync(ApiConfigName, CallSettings)
            // Additional: GetApiConfigAsync(ApiConfigName, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApiConfigName name = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]");
            // Make the request
            ApiConfig response = await apiGatewayServiceClient.GetApiConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateApiConfig</summary>
        public void CreateApiConfigRequestObject()
        {
            // Snippet: CreateApiConfig(CreateApiConfigRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            CreateApiConfigRequest request = new CreateApiConfigRequest
            {
                ParentAsApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
                ApiConfigId = "",
                ApiConfig = new ApiConfig(),
            };
            // Make the request
            Operation<ApiConfig, OperationMetadata> response = apiGatewayServiceClient.CreateApiConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<ApiConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ApiConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiConfig, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceCreateApiConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiConfigAsync</summary>
        public async Task CreateApiConfigRequestObjectAsync()
        {
            // Snippet: CreateApiConfigAsync(CreateApiConfigRequest, CallSettings)
            // Additional: CreateApiConfigAsync(CreateApiConfigRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateApiConfigRequest request = new CreateApiConfigRequest
            {
                ParentAsApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
                ApiConfigId = "",
                ApiConfig = new ApiConfig(),
            };
            // Make the request
            Operation<ApiConfig, OperationMetadata> response = await apiGatewayServiceClient.CreateApiConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ApiConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ApiConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiConfig, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceCreateApiConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiConfig</summary>
        public void CreateApiConfig()
        {
            // Snippet: CreateApiConfig(string, ApiConfig, string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/global/apis/[API]";
            ApiConfig apiConfig = new ApiConfig();
            string apiConfigId = "";
            // Make the request
            Operation<ApiConfig, OperationMetadata> response = apiGatewayServiceClient.CreateApiConfig(parent, apiConfig, apiConfigId);

            // Poll until the returned long-running operation is complete
            Operation<ApiConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ApiConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiConfig, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceCreateApiConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiConfigAsync</summary>
        public async Task CreateApiConfigAsync()
        {
            // Snippet: CreateApiConfigAsync(string, ApiConfig, string, CallSettings)
            // Additional: CreateApiConfigAsync(string, ApiConfig, string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/global/apis/[API]";
            ApiConfig apiConfig = new ApiConfig();
            string apiConfigId = "";
            // Make the request
            Operation<ApiConfig, OperationMetadata> response = await apiGatewayServiceClient.CreateApiConfigAsync(parent, apiConfig, apiConfigId);

            // Poll until the returned long-running operation is complete
            Operation<ApiConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ApiConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiConfig, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceCreateApiConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiConfig</summary>
        public void CreateApiConfigResourceNames()
        {
            // Snippet: CreateApiConfig(ApiName, ApiConfig, string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectApi("[PROJECT]", "[API]");
            ApiConfig apiConfig = new ApiConfig();
            string apiConfigId = "";
            // Make the request
            Operation<ApiConfig, OperationMetadata> response = apiGatewayServiceClient.CreateApiConfig(parent, apiConfig, apiConfigId);

            // Poll until the returned long-running operation is complete
            Operation<ApiConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ApiConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiConfig, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceCreateApiConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiConfigAsync</summary>
        public async Task CreateApiConfigResourceNamesAsync()
        {
            // Snippet: CreateApiConfigAsync(ApiName, ApiConfig, string, CallSettings)
            // Additional: CreateApiConfigAsync(ApiName, ApiConfig, string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApiName parent = ApiName.FromProjectApi("[PROJECT]", "[API]");
            ApiConfig apiConfig = new ApiConfig();
            string apiConfigId = "";
            // Make the request
            Operation<ApiConfig, OperationMetadata> response = await apiGatewayServiceClient.CreateApiConfigAsync(parent, apiConfig, apiConfigId);

            // Poll until the returned long-running operation is complete
            Operation<ApiConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ApiConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiConfig, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceCreateApiConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApiConfig</summary>
        public void UpdateApiConfigRequestObject()
        {
            // Snippet: UpdateApiConfig(UpdateApiConfigRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            UpdateApiConfigRequest request = new UpdateApiConfigRequest
            {
                UpdateMask = new FieldMask(),
                ApiConfig = new ApiConfig(),
            };
            // Make the request
            Operation<ApiConfig, OperationMetadata> response = apiGatewayServiceClient.UpdateApiConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<ApiConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ApiConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiConfig, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceUpdateApiConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApiConfigAsync</summary>
        public async Task UpdateApiConfigRequestObjectAsync()
        {
            // Snippet: UpdateApiConfigAsync(UpdateApiConfigRequest, CallSettings)
            // Additional: UpdateApiConfigAsync(UpdateApiConfigRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApiConfigRequest request = new UpdateApiConfigRequest
            {
                UpdateMask = new FieldMask(),
                ApiConfig = new ApiConfig(),
            };
            // Make the request
            Operation<ApiConfig, OperationMetadata> response = await apiGatewayServiceClient.UpdateApiConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ApiConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ApiConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiConfig, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceUpdateApiConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApiConfig</summary>
        public void UpdateApiConfig()
        {
            // Snippet: UpdateApiConfig(ApiConfig, FieldMask, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            ApiConfig apiConfig = new ApiConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ApiConfig, OperationMetadata> response = apiGatewayServiceClient.UpdateApiConfig(apiConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ApiConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ApiConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiConfig, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceUpdateApiConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApiConfigAsync</summary>
        public async Task UpdateApiConfigAsync()
        {
            // Snippet: UpdateApiConfigAsync(ApiConfig, FieldMask, CallSettings)
            // Additional: UpdateApiConfigAsync(ApiConfig, FieldMask, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApiConfig apiConfig = new ApiConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ApiConfig, OperationMetadata> response = await apiGatewayServiceClient.UpdateApiConfigAsync(apiConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ApiConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ApiConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiConfig, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceUpdateApiConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApiConfig</summary>
        public void DeleteApiConfigRequestObject()
        {
            // Snippet: DeleteApiConfig(DeleteApiConfigRequest, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            DeleteApiConfigRequest request = new DeleteApiConfigRequest
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = apiGatewayServiceClient.DeleteApiConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceDeleteApiConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApiConfigAsync</summary>
        public async Task DeleteApiConfigRequestObjectAsync()
        {
            // Snippet: DeleteApiConfigAsync(DeleteApiConfigRequest, CallSettings)
            // Additional: DeleteApiConfigAsync(DeleteApiConfigRequest, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApiConfigRequest request = new DeleteApiConfigRequest
            {
                ApiConfigName = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiGatewayServiceClient.DeleteApiConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceDeleteApiConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApiConfig</summary>
        public void DeleteApiConfig()
        {
            // Snippet: DeleteApiConfig(string, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/apis/[API]/configs/[API_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = apiGatewayServiceClient.DeleteApiConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceDeleteApiConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApiConfigAsync</summary>
        public async Task DeleteApiConfigAsync()
        {
            // Snippet: DeleteApiConfigAsync(string, CallSettings)
            // Additional: DeleteApiConfigAsync(string, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/apis/[API]/configs/[API_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiGatewayServiceClient.DeleteApiConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceDeleteApiConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApiConfig</summary>
        public void DeleteApiConfigResourceNames()
        {
            // Snippet: DeleteApiConfig(ApiConfigName, CallSettings)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            ApiConfigName name = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = apiGatewayServiceClient.DeleteApiConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiGatewayServiceClient.PollOnceDeleteApiConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApiConfigAsync</summary>
        public async Task DeleteApiConfigResourceNamesAsync()
        {
            // Snippet: DeleteApiConfigAsync(ApiConfigName, CallSettings)
            // Additional: DeleteApiConfigAsync(ApiConfigName, CancellationToken)
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApiConfigName name = ApiConfigName.FromProjectApiApiConfig("[PROJECT]", "[API]", "[API_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiGatewayServiceClient.DeleteApiConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceDeleteApiConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
