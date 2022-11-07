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

namespace Google.Cloud.Security.PrivateCA.V1Beta1.Snippets
{
    // [START privateca_v1beta1_generated_CertificateAuthorityService_RestoreCertificateAuthority_async_flattened_resourceNames]
    using Google.Cloud.Security.PrivateCA.V1Beta1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCertificateAuthorityServiceClientSnippets
    {
        /// <summary>Snippet for RestoreCertificateAuthorityAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task RestoreCertificateAuthorityResourceNamesAsync()
        {
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.RestoreCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceRestoreCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END privateca_v1beta1_generated_CertificateAuthorityService_RestoreCertificateAuthority_async_flattened_resourceNames]
}
