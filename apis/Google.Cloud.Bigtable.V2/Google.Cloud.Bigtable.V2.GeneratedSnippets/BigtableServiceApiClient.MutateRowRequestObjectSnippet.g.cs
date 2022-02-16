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

namespace Google.Cloud.Bigtable.V2.Snippets
{
    // [START bigtable_v2_generated_BigtableServiceApi_MutateRow_sync]
    using Google.Cloud.Bigtable.Common.V2;
    using Google.Cloud.Bigtable.V2;
    using Google.Protobuf;

    public sealed partial class GeneratedBigtableServiceApiClientSnippets
    {
        /// <summary>Snippet for MutateRow</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void MutateRowRequestObject()
        {
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Mutations = { new Mutation(), },
                AppProfileId = "",
            };
            // Make the request
            MutateRowResponse response = bigtableServiceApiClient.MutateRow(request);
        }
    }
    // [END bigtable_v2_generated_BigtableServiceApi_MutateRow_sync]
}
