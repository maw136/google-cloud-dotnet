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

namespace Google.Cloud.Bigtable.Admin.V2.Snippets
{
    // [START bigtableadmin_v2_generated_BigtableInstanceAdmin_GetInstance_async]
    using Google.Cloud.Bigtable.Admin.V2;
    using Google.Cloud.Bigtable.Common.V2;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBigtableInstanceAdminClientSnippets
    {
        /// <summary>Snippet for GetInstanceAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await bigtableInstanceAdminClient.GetInstanceAsync(request);
        }
    }
    // [END bigtableadmin_v2_generated_BigtableInstanceAdmin_GetInstance_async]
}
