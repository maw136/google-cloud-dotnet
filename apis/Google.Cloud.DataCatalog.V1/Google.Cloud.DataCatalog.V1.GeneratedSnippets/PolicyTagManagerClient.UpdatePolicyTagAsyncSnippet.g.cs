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

namespace Google.Cloud.DataCatalog.V1.Snippets
{
    // [START datacatalog_v1_generated_PolicyTagManager_UpdatePolicyTag_async_flattened]
    using Google.Cloud.DataCatalog.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPolicyTagManagerClientSnippets
    {
        /// <summary>Snippet for UpdatePolicyTagAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdatePolicyTagAsync()
        {
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            PolicyTag policyTag = new PolicyTag();
            // Make the request
            PolicyTag response = await policyTagManagerClient.UpdatePolicyTagAsync(policyTag);
        }
    }
    // [END datacatalog_v1_generated_PolicyTagManager_UpdatePolicyTag_async_flattened]
}
