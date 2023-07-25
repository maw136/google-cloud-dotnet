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

namespace GoogleCSharpSnippets
{
    // [START dataplex_v1_generated_DataTaxonomyService_CreateDataAttributeBinding_async_flattened]
    using Google.LongRunning;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    public sealed partial class GeneratedDataTaxonomyServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataAttributeBindingAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateDataAttributeBindingAsync()
        {
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::DataAttributeBinding dataAttributeBinding = new gcdv::DataAttributeBinding();
            string dataAttributeBindingId = "";
            // Make the request
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.CreateDataAttributeBindingAsync(parent, dataAttributeBinding, dataAttributeBindingId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAttributeBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceCreateDataAttributeBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dataplex_v1_generated_DataTaxonomyService_CreateDataAttributeBinding_async_flattened]
}
