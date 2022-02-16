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

namespace Google.Cloud.ManagedIdentities.V1.Snippets
{
    // [START managedidentities_v1_generated_ManagedIdentitiesService_GetDomain_sync]
    using Google.Cloud.ManagedIdentities.V1;

    public sealed partial class GeneratedManagedIdentitiesServiceClientSnippets
    {
        /// <summary>Snippet for GetDomain</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetDomainRequestObject()
        {
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            GetDomainRequest request = new GetDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            Domain response = managedIdentitiesServiceClient.GetDomain(request);
        }
    }
    // [END managedidentities_v1_generated_ManagedIdentitiesService_GetDomain_sync]
}
