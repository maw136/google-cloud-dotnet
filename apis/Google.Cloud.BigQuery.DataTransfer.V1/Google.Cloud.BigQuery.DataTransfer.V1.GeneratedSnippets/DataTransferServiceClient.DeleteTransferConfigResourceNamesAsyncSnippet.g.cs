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

namespace Google.Cloud.BigQuery.DataTransfer.V1.Snippets
{
    // [START bigquerydatatransfer_v1_generated_DataTransferService_DeleteTransferConfig_async_flattened_resourceNames]
    using Google.Cloud.BigQuery.DataTransfer.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataTransferServiceClientSnippets
    {
        /// <summary>Snippet for DeleteTransferConfigAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task DeleteTransferConfigResourceNamesAsync()
        {
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferConfigName name = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]");
            // Make the request
            await dataTransferServiceClient.DeleteTransferConfigAsync(name);
        }
    }
    // [END bigquerydatatransfer_v1_generated_DataTransferService_DeleteTransferConfig_async_flattened_resourceNames]
}
