// Copyright 2021 Google LLC
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

namespace Google.Cloud.Channel.V1.Snippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCloudChannelServiceClientSnippets
    {
        /// <summary>Snippet for ListCustomers</summary>
        public void ListCustomersRequestObject()
        {
            // Snippet: ListCustomers(ListCustomersRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ListCustomersRequest request = new ListCustomersRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListCustomersResponse, Customer> response = cloudChannelServiceClient.ListCustomers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Customer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Customer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Customer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Customer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomers</summary>
        public async Task ListCustomersRequestObjectAsync()
        {
            // Snippet: ListCustomersAsync(ListCustomersRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomersRequest request = new ListCustomersRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListCustomersResponse, Customer> response = cloudChannelServiceClient.ListCustomersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Customer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Customer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Customer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Customer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCustomer</summary>
        public void GetCustomerRequestObject()
        {
            // Snippet: GetCustomer(GetCustomerRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerRequest request = new GetCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            // Make the request
            Customer response = cloudChannelServiceClient.GetCustomer(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAsync</summary>
        public async Task GetCustomerRequestObjectAsync()
        {
            // Snippet: GetCustomerAsync(GetCustomerRequest, CallSettings)
            // Additional: GetCustomerAsync(GetCustomerRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerRequest request = new GetCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            // Make the request
            Customer response = await cloudChannelServiceClient.GetCustomerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomer</summary>
        public void GetCustomer()
        {
            // Snippet: GetCustomer(string, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/customers/[CUSTOMER]";
            // Make the request
            Customer response = cloudChannelServiceClient.GetCustomer(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAsync</summary>
        public async Task GetCustomerAsync()
        {
            // Snippet: GetCustomerAsync(string, CallSettings)
            // Additional: GetCustomerAsync(string, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/customers/[CUSTOMER]";
            // Make the request
            Customer response = await cloudChannelServiceClient.GetCustomerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomer</summary>
        public void GetCustomerResourceNames()
        {
            // Snippet: GetCustomer(CustomerName, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            CustomerName name = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]");
            // Make the request
            Customer response = cloudChannelServiceClient.GetCustomer(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAsync</summary>
        public async Task GetCustomerResourceNamesAsync()
        {
            // Snippet: GetCustomerAsync(CustomerName, CallSettings)
            // Additional: GetCustomerAsync(CustomerName, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerName name = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]");
            // Make the request
            Customer response = await cloudChannelServiceClient.GetCustomerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CheckCloudIdentityAccountsExist</summary>
        public void CheckCloudIdentityAccountsExistRequestObject()
        {
            // Snippet: CheckCloudIdentityAccountsExist(CheckCloudIdentityAccountsExistRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            CheckCloudIdentityAccountsExistRequest request = new CheckCloudIdentityAccountsExistRequest
            {
                Parent = "",
                Domain = "",
            };
            // Make the request
            CheckCloudIdentityAccountsExistResponse response = cloudChannelServiceClient.CheckCloudIdentityAccountsExist(request);
            // End snippet
        }

        /// <summary>Snippet for CheckCloudIdentityAccountsExistAsync</summary>
        public async Task CheckCloudIdentityAccountsExistRequestObjectAsync()
        {
            // Snippet: CheckCloudIdentityAccountsExistAsync(CheckCloudIdentityAccountsExistRequest, CallSettings)
            // Additional: CheckCloudIdentityAccountsExistAsync(CheckCloudIdentityAccountsExistRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CheckCloudIdentityAccountsExistRequest request = new CheckCloudIdentityAccountsExistRequest
            {
                Parent = "",
                Domain = "",
            };
            // Make the request
            CheckCloudIdentityAccountsExistResponse response = await cloudChannelServiceClient.CheckCloudIdentityAccountsExistAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomer</summary>
        public void CreateCustomerRequestObject()
        {
            // Snippet: CreateCustomer(CreateCustomerRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            CreateCustomerRequest request = new CreateCustomerRequest
            {
                Parent = "",
                Customer = new Customer(),
            };
            // Make the request
            Customer response = cloudChannelServiceClient.CreateCustomer(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomerAsync</summary>
        public async Task CreateCustomerRequestObjectAsync()
        {
            // Snippet: CreateCustomerAsync(CreateCustomerRequest, CallSettings)
            // Additional: CreateCustomerAsync(CreateCustomerRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCustomerRequest request = new CreateCustomerRequest
            {
                Parent = "",
                Customer = new Customer(),
            };
            // Make the request
            Customer response = await cloudChannelServiceClient.CreateCustomerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomer</summary>
        public void UpdateCustomerRequestObject()
        {
            // Snippet: UpdateCustomer(UpdateCustomerRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            UpdateCustomerRequest request = new UpdateCustomerRequest
            {
                Customer = new Customer(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Customer response = cloudChannelServiceClient.UpdateCustomer(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomerAsync</summary>
        public async Task UpdateCustomerRequestObjectAsync()
        {
            // Snippet: UpdateCustomerAsync(UpdateCustomerRequest, CallSettings)
            // Additional: UpdateCustomerAsync(UpdateCustomerRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCustomerRequest request = new UpdateCustomerRequest
            {
                Customer = new Customer(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Customer response = await cloudChannelServiceClient.UpdateCustomerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomer</summary>
        public void DeleteCustomerRequestObject()
        {
            // Snippet: DeleteCustomer(DeleteCustomerRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            DeleteCustomerRequest request = new DeleteCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            // Make the request
            cloudChannelServiceClient.DeleteCustomer(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomerAsync</summary>
        public async Task DeleteCustomerRequestObjectAsync()
        {
            // Snippet: DeleteCustomerAsync(DeleteCustomerRequest, CallSettings)
            // Additional: DeleteCustomerAsync(DeleteCustomerRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCustomerRequest request = new DeleteCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            // Make the request
            await cloudChannelServiceClient.DeleteCustomerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomer</summary>
        public void DeleteCustomer()
        {
            // Snippet: DeleteCustomer(string, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/customers/[CUSTOMER]";
            // Make the request
            cloudChannelServiceClient.DeleteCustomer(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomerAsync</summary>
        public async Task DeleteCustomerAsync()
        {
            // Snippet: DeleteCustomerAsync(string, CallSettings)
            // Additional: DeleteCustomerAsync(string, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/customers/[CUSTOMER]";
            // Make the request
            await cloudChannelServiceClient.DeleteCustomerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomer</summary>
        public void DeleteCustomerResourceNames()
        {
            // Snippet: DeleteCustomer(CustomerName, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            CustomerName name = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]");
            // Make the request
            cloudChannelServiceClient.DeleteCustomer(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomerAsync</summary>
        public async Task DeleteCustomerResourceNamesAsync()
        {
            // Snippet: DeleteCustomerAsync(CustomerName, CallSettings)
            // Additional: DeleteCustomerAsync(CustomerName, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerName name = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]");
            // Make the request
            await cloudChannelServiceClient.DeleteCustomerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ProvisionCloudIdentity</summary>
        public void ProvisionCloudIdentityRequestObject()
        {
            // Snippet: ProvisionCloudIdentity(ProvisionCloudIdentityRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ProvisionCloudIdentityRequest request = new ProvisionCloudIdentityRequest
            {
                CustomerAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                CloudIdentityInfo = new CloudIdentityInfo(),
                User = new AdminUser(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Customer, OperationMetadata> response = cloudChannelServiceClient.ProvisionCloudIdentity(request);

            // Poll until the returned long-running operation is complete
            Operation<Customer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Customer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Customer, OperationMetadata> retrievedResponse = cloudChannelServiceClient.PollOnceProvisionCloudIdentity(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Customer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProvisionCloudIdentityAsync</summary>
        public async Task ProvisionCloudIdentityRequestObjectAsync()
        {
            // Snippet: ProvisionCloudIdentityAsync(ProvisionCloudIdentityRequest, CallSettings)
            // Additional: ProvisionCloudIdentityAsync(ProvisionCloudIdentityRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProvisionCloudIdentityRequest request = new ProvisionCloudIdentityRequest
            {
                CustomerAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                CloudIdentityInfo = new CloudIdentityInfo(),
                User = new AdminUser(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Customer, OperationMetadata> response = await cloudChannelServiceClient.ProvisionCloudIdentityAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Customer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Customer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Customer, OperationMetadata> retrievedResponse = await cloudChannelServiceClient.PollOnceProvisionCloudIdentityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Customer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEntitlements</summary>
        public void ListEntitlementsRequestObject()
        {
            // Snippet: ListEntitlements(ListEntitlementsRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                ParentAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            // Make the request
            PagedEnumerable<ListEntitlementsResponse, Entitlement> response = cloudChannelServiceClient.ListEntitlements(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entitlement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitlementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlements</summary>
        public async Task ListEntitlementsRequestObjectAsync()
        {
            // Snippet: ListEntitlementsAsync(ListEntitlementsRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                ParentAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> response = cloudChannelServiceClient.ListEntitlementsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entitlement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitlementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferableSkus</summary>
        public void ListTransferableSkusRequestObject()
        {
            // Snippet: ListTransferableSkus(ListTransferableSkusRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ListTransferableSkusRequest request = new ListTransferableSkusRequest
            {
                Parent = "",
                CloudIdentityId = "",
                AuthToken = "",
                LanguageCode = "",
                CustomerName = "",
            };
            // Make the request
            PagedEnumerable<ListTransferableSkusResponse, TransferableSku> response = cloudChannelServiceClient.ListTransferableSkus(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransferableSku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransferableSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferableSku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferableSku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferableSku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferableSkus</summary>
        public async Task ListTransferableSkusRequestObjectAsync()
        {
            // Snippet: ListTransferableSkusAsync(ListTransferableSkusRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferableSkusRequest request = new ListTransferableSkusRequest
            {
                Parent = "",
                CloudIdentityId = "",
                AuthToken = "",
                LanguageCode = "",
                CustomerName = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTransferableSkusResponse, TransferableSku> response = cloudChannelServiceClient.ListTransferableSkusAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransferableSku item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransferableSkusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferableSku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferableSku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferableSku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferableOffers</summary>
        public void ListTransferableOffersRequestObject()
        {
            // Snippet: ListTransferableOffers(ListTransferableOffersRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ListTransferableOffersRequest request = new ListTransferableOffersRequest
            {
                Parent = "",
                CloudIdentityId = "",
                CustomerName = "",
                Sku = "",
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListTransferableOffersResponse, TransferableOffer> response = cloudChannelServiceClient.ListTransferableOffers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransferableOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransferableOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferableOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferableOffer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferableOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferableOffers</summary>
        public async Task ListTransferableOffersRequestObjectAsync()
        {
            // Snippet: ListTransferableOffersAsync(ListTransferableOffersRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferableOffersRequest request = new ListTransferableOffersRequest
            {
                Parent = "",
                CloudIdentityId = "",
                CustomerName = "",
                Sku = "",
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTransferableOffersResponse, TransferableOffer> response = cloudChannelServiceClient.ListTransferableOffersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransferableOffer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransferableOffersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferableOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferableOffer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferableOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEntitlement</summary>
        public void GetEntitlementRequestObject()
        {
            // Snippet: GetEntitlement(GetEntitlementRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            GetEntitlementRequest request = new GetEntitlementRequest
            {
                EntitlementName = EntitlementName.FromAccountCustomerEntitlement("[ACCOUNT]", "[CUSTOMER]", "[ENTITLEMENT]"),
            };
            // Make the request
            Entitlement response = cloudChannelServiceClient.GetEntitlement(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntitlementAsync</summary>
        public async Task GetEntitlementRequestObjectAsync()
        {
            // Snippet: GetEntitlementAsync(GetEntitlementRequest, CallSettings)
            // Additional: GetEntitlementAsync(GetEntitlementRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEntitlementRequest request = new GetEntitlementRequest
            {
                EntitlementName = EntitlementName.FromAccountCustomerEntitlement("[ACCOUNT]", "[CUSTOMER]", "[ENTITLEMENT]"),
            };
            // Make the request
            Entitlement response = await cloudChannelServiceClient.GetEntitlementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlement</summary>
        public void CreateEntitlementRequestObject()
        {
            // Snippet: CreateEntitlement(CreateEntitlementRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            CreateEntitlementRequest request = new CreateEntitlementRequest
            {
                ParentAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                Entitlement = new Entitlement(),
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = cloudChannelServiceClient.CreateEntitlement(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = cloudChannelServiceClient.PollOnceCreateEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlementAsync</summary>
        public async Task CreateEntitlementRequestObjectAsync()
        {
            // Snippet: CreateEntitlementAsync(CreateEntitlementRequest, CallSettings)
            // Additional: CreateEntitlementAsync(CreateEntitlementRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEntitlementRequest request = new CreateEntitlementRequest
            {
                ParentAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                Entitlement = new Entitlement(),
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await cloudChannelServiceClient.CreateEntitlementAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await cloudChannelServiceClient.PollOnceCreateEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ChangeParameters</summary>
        public void ChangeParametersRequestObject()
        {
            // Snippet: ChangeParameters(ChangeParametersRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ChangeParametersRequest request = new ChangeParametersRequest
            {
                Name = "",
                Parameters = { new Parameter(), },
                RequestId = "",
                PurchaseOrderId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = cloudChannelServiceClient.ChangeParameters(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = cloudChannelServiceClient.PollOnceChangeParameters(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ChangeParametersAsync</summary>
        public async Task ChangeParametersRequestObjectAsync()
        {
            // Snippet: ChangeParametersAsync(ChangeParametersRequest, CallSettings)
            // Additional: ChangeParametersAsync(ChangeParametersRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChangeParametersRequest request = new ChangeParametersRequest
            {
                Name = "",
                Parameters = { new Parameter(), },
                RequestId = "",
                PurchaseOrderId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await cloudChannelServiceClient.ChangeParametersAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await cloudChannelServiceClient.PollOnceChangeParametersAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ChangeRenewalSettings</summary>
        public void ChangeRenewalSettingsRequestObject()
        {
            // Snippet: ChangeRenewalSettings(ChangeRenewalSettingsRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ChangeRenewalSettingsRequest request = new ChangeRenewalSettingsRequest
            {
                Name = "",
                RenewalSettings = new RenewalSettings(),
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = cloudChannelServiceClient.ChangeRenewalSettings(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = cloudChannelServiceClient.PollOnceChangeRenewalSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ChangeRenewalSettingsAsync</summary>
        public async Task ChangeRenewalSettingsRequestObjectAsync()
        {
            // Snippet: ChangeRenewalSettingsAsync(ChangeRenewalSettingsRequest, CallSettings)
            // Additional: ChangeRenewalSettingsAsync(ChangeRenewalSettingsRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChangeRenewalSettingsRequest request = new ChangeRenewalSettingsRequest
            {
                Name = "",
                RenewalSettings = new RenewalSettings(),
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await cloudChannelServiceClient.ChangeRenewalSettingsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await cloudChannelServiceClient.PollOnceChangeRenewalSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ChangeOffer</summary>
        public void ChangeOfferRequestObject()
        {
            // Snippet: ChangeOffer(ChangeOfferRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ChangeOfferRequest request = new ChangeOfferRequest
            {
                Name = "",
                OfferAsOfferName = OfferName.FromAccountOffer("[ACCOUNT]", "[OFFER]"),
                Parameters = { new Parameter(), },
                PurchaseOrderId = "",
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = cloudChannelServiceClient.ChangeOffer(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = cloudChannelServiceClient.PollOnceChangeOffer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ChangeOfferAsync</summary>
        public async Task ChangeOfferRequestObjectAsync()
        {
            // Snippet: ChangeOfferAsync(ChangeOfferRequest, CallSettings)
            // Additional: ChangeOfferAsync(ChangeOfferRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChangeOfferRequest request = new ChangeOfferRequest
            {
                Name = "",
                OfferAsOfferName = OfferName.FromAccountOffer("[ACCOUNT]", "[OFFER]"),
                Parameters = { new Parameter(), },
                PurchaseOrderId = "",
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await cloudChannelServiceClient.ChangeOfferAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await cloudChannelServiceClient.PollOnceChangeOfferAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartPaidService</summary>
        public void StartPaidServiceRequestObject()
        {
            // Snippet: StartPaidService(StartPaidServiceRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            StartPaidServiceRequest request = new StartPaidServiceRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = cloudChannelServiceClient.StartPaidService(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = cloudChannelServiceClient.PollOnceStartPaidService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartPaidServiceAsync</summary>
        public async Task StartPaidServiceRequestObjectAsync()
        {
            // Snippet: StartPaidServiceAsync(StartPaidServiceRequest, CallSettings)
            // Additional: StartPaidServiceAsync(StartPaidServiceRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartPaidServiceRequest request = new StartPaidServiceRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await cloudChannelServiceClient.StartPaidServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await cloudChannelServiceClient.PollOnceStartPaidServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendEntitlement</summary>
        public void SuspendEntitlementRequestObject()
        {
            // Snippet: SuspendEntitlement(SuspendEntitlementRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            SuspendEntitlementRequest request = new SuspendEntitlementRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = cloudChannelServiceClient.SuspendEntitlement(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = cloudChannelServiceClient.PollOnceSuspendEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendEntitlementAsync</summary>
        public async Task SuspendEntitlementRequestObjectAsync()
        {
            // Snippet: SuspendEntitlementAsync(SuspendEntitlementRequest, CallSettings)
            // Additional: SuspendEntitlementAsync(SuspendEntitlementRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            SuspendEntitlementRequest request = new SuspendEntitlementRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await cloudChannelServiceClient.SuspendEntitlementAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await cloudChannelServiceClient.PollOnceSuspendEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelEntitlement</summary>
        public void CancelEntitlementRequestObject()
        {
            // Snippet: CancelEntitlement(CancelEntitlementRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            CancelEntitlementRequest request = new CancelEntitlementRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudChannelServiceClient.CancelEntitlement(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudChannelServiceClient.PollOnceCancelEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelEntitlementAsync</summary>
        public async Task CancelEntitlementRequestObjectAsync()
        {
            // Snippet: CancelEntitlementAsync(CancelEntitlementRequest, CallSettings)
            // Additional: CancelEntitlementAsync(CancelEntitlementRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelEntitlementRequest request = new CancelEntitlementRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudChannelServiceClient.CancelEntitlementAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudChannelServiceClient.PollOnceCancelEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateEntitlement</summary>
        public void ActivateEntitlementRequestObject()
        {
            // Snippet: ActivateEntitlement(ActivateEntitlementRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ActivateEntitlementRequest request = new ActivateEntitlementRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = cloudChannelServiceClient.ActivateEntitlement(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = cloudChannelServiceClient.PollOnceActivateEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateEntitlementAsync</summary>
        public async Task ActivateEntitlementRequestObjectAsync()
        {
            // Snippet: ActivateEntitlementAsync(ActivateEntitlementRequest, CallSettings)
            // Additional: ActivateEntitlementAsync(ActivateEntitlementRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ActivateEntitlementRequest request = new ActivateEntitlementRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await cloudChannelServiceClient.ActivateEntitlementAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await cloudChannelServiceClient.PollOnceActivateEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TransferEntitlements</summary>
        public void TransferEntitlementsRequestObject()
        {
            // Snippet: TransferEntitlements(TransferEntitlementsRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            TransferEntitlementsRequest request = new TransferEntitlementsRequest
            {
                Parent = "",
                Entitlements = { new Entitlement(), },
                AuthToken = "",
                RequestId = "",
            };
            // Make the request
            Operation<TransferEntitlementsResponse, OperationMetadata> response = cloudChannelServiceClient.TransferEntitlements(request);

            // Poll until the returned long-running operation is complete
            Operation<TransferEntitlementsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TransferEntitlementsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TransferEntitlementsResponse, OperationMetadata> retrievedResponse = cloudChannelServiceClient.PollOnceTransferEntitlements(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TransferEntitlementsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TransferEntitlementsAsync</summary>
        public async Task TransferEntitlementsRequestObjectAsync()
        {
            // Snippet: TransferEntitlementsAsync(TransferEntitlementsRequest, CallSettings)
            // Additional: TransferEntitlementsAsync(TransferEntitlementsRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferEntitlementsRequest request = new TransferEntitlementsRequest
            {
                Parent = "",
                Entitlements = { new Entitlement(), },
                AuthToken = "",
                RequestId = "",
            };
            // Make the request
            Operation<TransferEntitlementsResponse, OperationMetadata> response = await cloudChannelServiceClient.TransferEntitlementsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TransferEntitlementsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TransferEntitlementsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TransferEntitlementsResponse, OperationMetadata> retrievedResponse = await cloudChannelServiceClient.PollOnceTransferEntitlementsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TransferEntitlementsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TransferEntitlementsToGoogle</summary>
        public void TransferEntitlementsToGoogleRequestObject()
        {
            // Snippet: TransferEntitlementsToGoogle(TransferEntitlementsToGoogleRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            TransferEntitlementsToGoogleRequest request = new TransferEntitlementsToGoogleRequest
            {
                Parent = "",
                Entitlements = { new Entitlement(), },
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudChannelServiceClient.TransferEntitlementsToGoogle(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudChannelServiceClient.PollOnceTransferEntitlementsToGoogle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TransferEntitlementsToGoogleAsync</summary>
        public async Task TransferEntitlementsToGoogleRequestObjectAsync()
        {
            // Snippet: TransferEntitlementsToGoogleAsync(TransferEntitlementsToGoogleRequest, CallSettings)
            // Additional: TransferEntitlementsToGoogleAsync(TransferEntitlementsToGoogleRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferEntitlementsToGoogleRequest request = new TransferEntitlementsToGoogleRequest
            {
                Parent = "",
                Entitlements = { new Entitlement(), },
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudChannelServiceClient.TransferEntitlementsToGoogleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudChannelServiceClient.PollOnceTransferEntitlementsToGoogleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListChannelPartnerLinks</summary>
        public void ListChannelPartnerLinksRequestObject()
        {
            // Snippet: ListChannelPartnerLinks(ListChannelPartnerLinksRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ListChannelPartnerLinksRequest request = new ListChannelPartnerLinksRequest
            {
                Parent = "",
                View = ChannelPartnerLinkView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListChannelPartnerLinksResponse, ChannelPartnerLink> response = cloudChannelServiceClient.ListChannelPartnerLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChannelPartnerLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelPartnerLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelPartnerLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelPartnerLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelPartnerLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelPartnerLinks</summary>
        public async Task ListChannelPartnerLinksRequestObjectAsync()
        {
            // Snippet: ListChannelPartnerLinksAsync(ListChannelPartnerLinksRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListChannelPartnerLinksRequest request = new ListChannelPartnerLinksRequest
            {
                Parent = "",
                View = ChannelPartnerLinkView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListChannelPartnerLinksResponse, ChannelPartnerLink> response = cloudChannelServiceClient.ListChannelPartnerLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ChannelPartnerLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelPartnerLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelPartnerLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelPartnerLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelPartnerLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetChannelPartnerLink</summary>
        public void GetChannelPartnerLinkRequestObject()
        {
            // Snippet: GetChannelPartnerLink(GetChannelPartnerLinkRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            GetChannelPartnerLinkRequest request = new GetChannelPartnerLinkRequest
            {
                Name = "",
                View = ChannelPartnerLinkView.Unspecified,
            };
            // Make the request
            ChannelPartnerLink response = cloudChannelServiceClient.GetChannelPartnerLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetChannelPartnerLinkAsync</summary>
        public async Task GetChannelPartnerLinkRequestObjectAsync()
        {
            // Snippet: GetChannelPartnerLinkAsync(GetChannelPartnerLinkRequest, CallSettings)
            // Additional: GetChannelPartnerLinkAsync(GetChannelPartnerLinkRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetChannelPartnerLinkRequest request = new GetChannelPartnerLinkRequest
            {
                Name = "",
                View = ChannelPartnerLinkView.Unspecified,
            };
            // Make the request
            ChannelPartnerLink response = await cloudChannelServiceClient.GetChannelPartnerLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateChannelPartnerLink</summary>
        public void CreateChannelPartnerLinkRequestObject()
        {
            // Snippet: CreateChannelPartnerLink(CreateChannelPartnerLinkRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            CreateChannelPartnerLinkRequest request = new CreateChannelPartnerLinkRequest
            {
                Parent = "",
                ChannelPartnerLink = new ChannelPartnerLink(),
                Domain = "",
            };
            // Make the request
            ChannelPartnerLink response = cloudChannelServiceClient.CreateChannelPartnerLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateChannelPartnerLinkAsync</summary>
        public async Task CreateChannelPartnerLinkRequestObjectAsync()
        {
            // Snippet: CreateChannelPartnerLinkAsync(CreateChannelPartnerLinkRequest, CallSettings)
            // Additional: CreateChannelPartnerLinkAsync(CreateChannelPartnerLinkRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateChannelPartnerLinkRequest request = new CreateChannelPartnerLinkRequest
            {
                Parent = "",
                ChannelPartnerLink = new ChannelPartnerLink(),
                Domain = "",
            };
            // Make the request
            ChannelPartnerLink response = await cloudChannelServiceClient.CreateChannelPartnerLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateChannelPartnerLink</summary>
        public void UpdateChannelPartnerLinkRequestObject()
        {
            // Snippet: UpdateChannelPartnerLink(UpdateChannelPartnerLinkRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            UpdateChannelPartnerLinkRequest request = new UpdateChannelPartnerLinkRequest
            {
                Name = "",
                ChannelPartnerLink = new ChannelPartnerLink(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ChannelPartnerLink response = cloudChannelServiceClient.UpdateChannelPartnerLink(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateChannelPartnerLinkAsync</summary>
        public async Task UpdateChannelPartnerLinkRequestObjectAsync()
        {
            // Snippet: UpdateChannelPartnerLinkAsync(UpdateChannelPartnerLinkRequest, CallSettings)
            // Additional: UpdateChannelPartnerLinkAsync(UpdateChannelPartnerLinkRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateChannelPartnerLinkRequest request = new UpdateChannelPartnerLinkRequest
            {
                Name = "",
                ChannelPartnerLink = new ChannelPartnerLink(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ChannelPartnerLink response = await cloudChannelServiceClient.UpdateChannelPartnerLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListProducts</summary>
        public void ListProductsRequestObject()
        {
            // Snippet: ListProducts(ListProductsRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                Account = "",
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = cloudChannelServiceClient.ListProducts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProducts</summary>
        public async Task ListProductsRequestObjectAsync()
        {
            // Snippet: ListProductsAsync(ListProductsRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                Account = "",
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = cloudChannelServiceClient.ListProductsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkus</summary>
        public void ListSkusRequestObject()
        {
            // Snippet: ListSkus(ListSkusRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsProductName = ProductName.FromProduct("[PRODUCT]"),
                Account = "",
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListSkusResponse, Sku> response = cloudChannelServiceClient.ListSkus(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkus</summary>
        public async Task ListSkusRequestObjectAsync()
        {
            // Snippet: ListSkusAsync(ListSkusRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsProductName = ProductName.FromProduct("[PRODUCT]"),
                Account = "",
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSkusResponse, Sku> response = cloudChannelServiceClient.ListSkusAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Sku item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSkusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOffers</summary>
        public void ListOffersRequestObject()
        {
            // Snippet: ListOffers(ListOffersRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ListOffersRequest request = new ListOffersRequest
            {
                Parent = "",
                Filter = "",
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListOffersResponse, Offer> response = cloudChannelServiceClient.ListOffers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Offer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Offer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Offer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Offer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOffers</summary>
        public async Task ListOffersRequestObjectAsync()
        {
            // Snippet: ListOffersAsync(ListOffersRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOffersRequest request = new ListOffersRequest
            {
                Parent = "",
                Filter = "",
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListOffersResponse, Offer> response = cloudChannelServiceClient.ListOffersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Offer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOffersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Offer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Offer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Offer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPurchasableSkus</summary>
        public void ListPurchasableSkusRequestObject()
        {
            // Snippet: ListPurchasableSkus(ListPurchasableSkusRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ListPurchasableSkusRequest request = new ListPurchasableSkusRequest
            {
                CustomerAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                CreateEntitlementPurchase = new ListPurchasableSkusRequest.Types.CreateEntitlementPurchase(),
                ChangeOfferPurchase = new ListPurchasableSkusRequest.Types.ChangeOfferPurchase(),
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListPurchasableSkusResponse, PurchasableSku> response = cloudChannelServiceClient.ListPurchasableSkus(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PurchasableSku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPurchasableSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PurchasableSku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PurchasableSku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PurchasableSku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPurchasableSkus</summary>
        public async Task ListPurchasableSkusRequestObjectAsync()
        {
            // Snippet: ListPurchasableSkusAsync(ListPurchasableSkusRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPurchasableSkusRequest request = new ListPurchasableSkusRequest
            {
                CustomerAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                CreateEntitlementPurchase = new ListPurchasableSkusRequest.Types.CreateEntitlementPurchase(),
                ChangeOfferPurchase = new ListPurchasableSkusRequest.Types.ChangeOfferPurchase(),
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPurchasableSkusResponse, PurchasableSku> response = cloudChannelServiceClient.ListPurchasableSkusAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PurchasableSku item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPurchasableSkusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PurchasableSku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PurchasableSku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PurchasableSku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPurchasableOffers</summary>
        public void ListPurchasableOffersRequestObject()
        {
            // Snippet: ListPurchasableOffers(ListPurchasableOffersRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ListPurchasableOffersRequest request = new ListPurchasableOffersRequest
            {
                CustomerAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                CreateEntitlementPurchase = new ListPurchasableOffersRequest.Types.CreateEntitlementPurchase(),
                ChangeOfferPurchase = new ListPurchasableOffersRequest.Types.ChangeOfferPurchase(),
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListPurchasableOffersResponse, PurchasableOffer> response = cloudChannelServiceClient.ListPurchasableOffers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PurchasableOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPurchasableOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PurchasableOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PurchasableOffer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PurchasableOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPurchasableOffers</summary>
        public async Task ListPurchasableOffersRequestObjectAsync()
        {
            // Snippet: ListPurchasableOffersAsync(ListPurchasableOffersRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPurchasableOffersRequest request = new ListPurchasableOffersRequest
            {
                CustomerAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                CreateEntitlementPurchase = new ListPurchasableOffersRequest.Types.CreateEntitlementPurchase(),
                ChangeOfferPurchase = new ListPurchasableOffersRequest.Types.ChangeOfferPurchase(),
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPurchasableOffersResponse, PurchasableOffer> response = cloudChannelServiceClient.ListPurchasableOffersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PurchasableOffer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPurchasableOffersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PurchasableOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PurchasableOffer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PurchasableOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RegisterSubscriber</summary>
        public void RegisterSubscriberRequestObject()
        {
            // Snippet: RegisterSubscriber(RegisterSubscriberRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            RegisterSubscriberRequest request = new RegisterSubscriberRequest
            {
                Account = "",
                ServiceAccount = "",
            };
            // Make the request
            RegisterSubscriberResponse response = cloudChannelServiceClient.RegisterSubscriber(request);
            // End snippet
        }

        /// <summary>Snippet for RegisterSubscriberAsync</summary>
        public async Task RegisterSubscriberRequestObjectAsync()
        {
            // Snippet: RegisterSubscriberAsync(RegisterSubscriberRequest, CallSettings)
            // Additional: RegisterSubscriberAsync(RegisterSubscriberRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            RegisterSubscriberRequest request = new RegisterSubscriberRequest
            {
                Account = "",
                ServiceAccount = "",
            };
            // Make the request
            RegisterSubscriberResponse response = await cloudChannelServiceClient.RegisterSubscriberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UnregisterSubscriber</summary>
        public void UnregisterSubscriberRequestObject()
        {
            // Snippet: UnregisterSubscriber(UnregisterSubscriberRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            UnregisterSubscriberRequest request = new UnregisterSubscriberRequest
            {
                Account = "",
                ServiceAccount = "",
            };
            // Make the request
            UnregisterSubscriberResponse response = cloudChannelServiceClient.UnregisterSubscriber(request);
            // End snippet
        }

        /// <summary>Snippet for UnregisterSubscriberAsync</summary>
        public async Task UnregisterSubscriberRequestObjectAsync()
        {
            // Snippet: UnregisterSubscriberAsync(UnregisterSubscriberRequest, CallSettings)
            // Additional: UnregisterSubscriberAsync(UnregisterSubscriberRequest, CancellationToken)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            UnregisterSubscriberRequest request = new UnregisterSubscriberRequest
            {
                Account = "",
                ServiceAccount = "",
            };
            // Make the request
            UnregisterSubscriberResponse response = await cloudChannelServiceClient.UnregisterSubscriberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListSubscribers</summary>
        public void ListSubscribersRequestObject()
        {
            // Snippet: ListSubscribers(ListSubscribersRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            ListSubscribersRequest request = new ListSubscribersRequest { Account = "", };
            // Make the request
            PagedEnumerable<ListSubscribersResponse, string> response = cloudChannelServiceClient.ListSubscribers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscribersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscribers</summary>
        public async Task ListSubscribersRequestObjectAsync()
        {
            // Snippet: ListSubscribersAsync(ListSubscribersRequest, CallSettings)
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = await CloudChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSubscribersRequest request = new ListSubscribersRequest { Account = "", };
            // Make the request
            PagedAsyncEnumerable<ListSubscribersResponse, string> response = cloudChannelServiceClient.ListSubscribersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubscribersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
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
