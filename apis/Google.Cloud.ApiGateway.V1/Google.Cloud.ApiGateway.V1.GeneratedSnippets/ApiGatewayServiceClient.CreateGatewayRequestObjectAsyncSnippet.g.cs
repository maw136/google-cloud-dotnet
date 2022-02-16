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

namespace Google.Cloud.ApiGateway.V1.Snippets
{
    // [START apigateway_v1_generated_ApiGatewayService_CreateGateway_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ApiGateway.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedApiGatewayServiceClientSnippets
    {
        /// <summary>Snippet for CreateGatewayAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateGatewayRequestObjectAsync()
        {
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGatewayRequest request = new CreateGatewayRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GatewayId = "",
                Gateway = new Gateway(),
            };
            // Make the request
            Operation<Gateway, OperationMetadata> response = await apiGatewayServiceClient.CreateGatewayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Gateway, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Gateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Gateway, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceCreateGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Gateway retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END apigateway_v1_generated_ApiGatewayService_CreateGateway_async]
}
