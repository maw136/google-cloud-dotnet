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
    // [START discoveryengine_v1beta_generated_DataStoreService_CreateDataStore_async]
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataStoreServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataStoreAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateDataStoreRequestObjectAsync()
        {
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataStoreRequest request = new CreateDataStoreRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                DataStore = new DataStore(),
                DataStoreId = "",
                CreateAdvancedSiteSearch = false,
            };
            // Make the request
            Operation<DataStore, CreateDataStoreMetadata> response = await dataStoreServiceClient.CreateDataStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DataStore, CreateDataStoreMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataStore, CreateDataStoreMetadata> retrievedResponse = await dataStoreServiceClient.PollOnceCreateDataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataStore retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END discoveryengine_v1beta_generated_DataStoreService_CreateDataStore_async]
}
