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

namespace GoogleCSharpSnippets
{
    // [START accesscontextmanager_v1_generated_AccessContextManager_UpdateGcpUserAccessBinding_async_flattened]
    using Google.Identity.AccessContextManager.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAccessContextManagerClientSnippets
    {
        /// <summary>Snippet for UpdateGcpUserAccessBindingAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateGcpUserAccessBindingAsync()
        {
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            GcpUserAccessBinding gcpUserAccessBinding = new GcpUserAccessBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> response = await accessContextManagerClient.UpdateGcpUserAccessBindingAsync(gcpUserAccessBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GcpUserAccessBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GcpUserAccessBinding, GcpUserAccessBindingOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceUpdateGcpUserAccessBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GcpUserAccessBinding retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END accesscontextmanager_v1_generated_AccessContextManager_UpdateGcpUserAccessBinding_async_flattened]
}
