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

namespace Google.Cloud.Dataplex.V1.Snippets
{
    // [START dataplex_v1_generated_DataScanService_UpdateDataScan_async_flattened]
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    public sealed partial class GeneratedDataScanServiceClientSnippets
    {
        /// <summary>Snippet for UpdateDataScanAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateDataScanAsync()
        {
            // Create client
            DataScanServiceClient dataScanServiceClient = await DataScanServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataScan dataScan = new DataScan();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DataScan, OperationMetadata> response = await dataScanServiceClient.UpdateDataScanAsync(dataScan, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DataScan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataScan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataScan, OperationMetadata> retrievedResponse = await dataScanServiceClient.PollOnceUpdateDataScanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataScan retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dataplex_v1_generated_DataScanService_UpdateDataScan_async_flattened]
}
