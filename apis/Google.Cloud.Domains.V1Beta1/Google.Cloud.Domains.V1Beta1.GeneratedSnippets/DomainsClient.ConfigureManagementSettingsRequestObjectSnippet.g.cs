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

namespace Google.Cloud.Domains.V1Beta1.Snippets
{
    // [START domains_v1beta1_generated_Domains_ConfigureManagementSettings_sync]
    using Google.Cloud.Domains.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedDomainsClientSnippets
    {
        /// <summary>Snippet for ConfigureManagementSettings</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ConfigureManagementSettingsRequestObject()
        {
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            ConfigureManagementSettingsRequest request = new ConfigureManagementSettingsRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                ManagementSettings = new ManagementSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ConfigureManagementSettings(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceConfigureManagementSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END domains_v1beta1_generated_Domains_ConfigureManagementSettings_sync]
}
