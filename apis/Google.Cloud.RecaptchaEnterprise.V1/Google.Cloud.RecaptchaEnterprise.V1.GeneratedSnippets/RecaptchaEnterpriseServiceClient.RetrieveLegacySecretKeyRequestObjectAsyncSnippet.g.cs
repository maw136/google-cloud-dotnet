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

namespace Google.Cloud.RecaptchaEnterprise.V1.Snippets
{
    // [START recaptchaenterprise_v1_generated_RecaptchaEnterpriseService_RetrieveLegacySecretKey_async]
    using Google.Cloud.RecaptchaEnterprise.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRecaptchaEnterpriseServiceClientSnippets
    {
        /// <summary>Snippet for RetrieveLegacySecretKeyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task RetrieveLegacySecretKeyRequestObjectAsync()
        {
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveLegacySecretKeyRequest request = new RetrieveLegacySecretKeyRequest
            {
                KeyAsKeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            RetrieveLegacySecretKeyResponse response = await recaptchaEnterpriseServiceClient.RetrieveLegacySecretKeyAsync(request);
        }
    }
    // [END recaptchaenterprise_v1_generated_RecaptchaEnterpriseService_RetrieveLegacySecretKey_async]
}
