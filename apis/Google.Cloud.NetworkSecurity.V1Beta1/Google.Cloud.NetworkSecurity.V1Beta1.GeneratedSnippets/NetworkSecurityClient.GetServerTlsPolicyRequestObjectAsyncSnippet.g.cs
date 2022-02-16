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

namespace Google.Cloud.NetworkSecurity.V1Beta1.Snippets
{
    // [START networksecurity_v1beta1_generated_NetworkSecurity_GetServerTlsPolicy_async]
    using Google.Cloud.NetworkSecurity.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedNetworkSecurityClientSnippets
    {
        /// <summary>Snippet for GetServerTlsPolicyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetServerTlsPolicyRequestObjectAsync()
        {
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            GetServerTlsPolicyRequest request = new GetServerTlsPolicyRequest
            {
                ServerTlsPolicyName = ServerTlsPolicyName.FromProjectLocationServerTlsPolicy("[PROJECT]", "[LOCATION]", "[SERVER_TLS_POLICY]"),
            };
            // Make the request
            ServerTlsPolicy response = await networkSecurityClient.GetServerTlsPolicyAsync(request);
        }
    }
    // [END networksecurity_v1beta1_generated_NetworkSecurity_GetServerTlsPolicy_async]
}
