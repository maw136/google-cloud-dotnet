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

namespace Google.Cloud.SecurityCenter.V1P1Beta1.Snippets
{
    // [START securitycenter_v1p1beta1_generated_SecurityCenter_CreateFinding_sync_flattened2_resourceNames]
    using Google.Cloud.SecurityCenter.V1P1Beta1;

    public sealed partial class GeneratedSecurityCenterClientSnippets
    {
        /// <summary>Snippet for CreateFinding</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateFinding2ResourceNames()
        {
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            Finding finding = new Finding();
            string findingId = "";
            // Make the request
            Finding response = securityCenterClient.CreateFinding(parent, finding, findingId);
        }
    }
    // [END securitycenter_v1p1beta1_generated_SecurityCenter_CreateFinding_sync_flattened2_resourceNames]
}
