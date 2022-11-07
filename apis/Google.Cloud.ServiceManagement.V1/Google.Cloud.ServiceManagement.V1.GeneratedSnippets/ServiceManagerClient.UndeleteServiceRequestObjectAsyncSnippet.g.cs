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

namespace Google.Cloud.ServiceManagement.V1.Snippets
{
    // [START servicemanagement_v1_generated_ServiceManager_UndeleteService_async]
    using Google.Cloud.ServiceManagement.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedServiceManagerClientSnippets
    {
        /// <summary>Snippet for UndeleteServiceAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UndeleteServiceRequestObjectAsync()
        {
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteServiceRequest request = new UndeleteServiceRequest { ServiceName = "", };
            // Make the request
            Operation<UndeleteServiceResponse, OperationMetadata> response = await serviceManagerClient.UndeleteServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeleteServiceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeleteServiceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeleteServiceResponse, OperationMetadata> retrievedResponse = await serviceManagerClient.PollOnceUndeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeleteServiceResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END servicemanagement_v1_generated_ServiceManager_UndeleteService_async]
}
