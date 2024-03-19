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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START dataplex_v1_generated_CatalogService_UpdateAspectType_async]
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    public sealed partial class GeneratedCatalogServiceClientSnippets
    {
        /// <summary>Snippet for UpdateAspectTypeAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateAspectTypeRequestObjectAsync()
        {
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateAspectTypeRequest request = new gcdv::UpdateAspectTypeRequest
            {
                AspectType = new gcdv::AspectType(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::AspectType, gcdv::OperationMetadata> response = await catalogServiceClient.UpdateAspectTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::AspectType, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::AspectType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::AspectType, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceUpdateAspectTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::AspectType retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dataplex_v1_generated_CatalogService_UpdateAspectType_async]
}
