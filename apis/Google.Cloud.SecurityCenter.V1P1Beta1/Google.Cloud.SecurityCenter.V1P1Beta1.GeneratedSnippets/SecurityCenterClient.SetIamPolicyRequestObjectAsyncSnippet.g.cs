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
    // [START securitycenter_v1p1beta1_generated_SecurityCenter_SetIamPolicy_async]
    using Google.Api.Gax;
    using Google.Cloud.Iam.V1;
    using Google.Cloud.SecurityCenter.V1P1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSecurityCenterClientSnippets
    {
        /// <summary>Snippet for SetIamPolicyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await securityCenterClient.SetIamPolicyAsync(request);
        }
    }
    // [END securitycenter_v1p1beta1_generated_SecurityCenter_SetIamPolicy_async]
}
