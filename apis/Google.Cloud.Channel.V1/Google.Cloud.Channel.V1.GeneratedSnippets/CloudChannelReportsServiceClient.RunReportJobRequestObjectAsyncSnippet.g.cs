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
    // [START cloudchannel_v1_generated_CloudChannelReportsService_RunReportJob_async]
    using Google.Cloud.Channel.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCloudChannelReportsServiceClientSnippets
    {
        /// <summary>Snippet for RunReportJobAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task RunReportJobRequestObjectAsync()
        {
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = await CloudChannelReportsServiceClient.CreateAsync();
            // Initialize request argument(s)
#pragma warning disable CS0612
            RunReportJobRequest request = new RunReportJobRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<RunReportJobResponse, OperationMetadata> response = await cloudChannelReportsServiceClient.RunReportJobAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<RunReportJobResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            RunReportJobResponse result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<RunReportJobResponse, OperationMetadata> retrievedResponse = await cloudChannelReportsServiceClient.PollOnceRunReportJobAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                RunReportJobResponse retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
            }
        }
    }
    // [END cloudchannel_v1_generated_CloudChannelReportsService_RunReportJob_async]
}
