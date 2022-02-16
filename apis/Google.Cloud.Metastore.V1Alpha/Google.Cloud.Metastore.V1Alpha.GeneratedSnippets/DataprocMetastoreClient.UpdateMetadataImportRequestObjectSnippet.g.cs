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

namespace Google.Cloud.Metastore.V1Alpha.Snippets
{
    // [START metastore_v1alpha_generated_DataprocMetastore_UpdateMetadataImport_sync]
    using Google.Cloud.Metastore.V1Alpha;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedDataprocMetastoreClientSnippets
    {
        /// <summary>Snippet for UpdateMetadataImport</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateMetadataImportRequestObject()
        {
            // Create client
            DataprocMetastoreClient dataprocMetastoreClient = DataprocMetastoreClient.Create();
            // Initialize request argument(s)
            UpdateMetadataImportRequest request = new UpdateMetadataImportRequest
            {
                UpdateMask = new FieldMask(),
                MetadataImport = new MetadataImport(),
                RequestId = "",
            };
            // Make the request
            Operation<MetadataImport, OperationMetadata> response = dataprocMetastoreClient.UpdateMetadataImport(request);

            // Poll until the returned long-running operation is complete
            Operation<MetadataImport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MetadataImport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MetadataImport, OperationMetadata> retrievedResponse = dataprocMetastoreClient.PollOnceUpdateMetadataImport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MetadataImport retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END metastore_v1alpha_generated_DataprocMetastore_UpdateMetadataImport_sync]
}
