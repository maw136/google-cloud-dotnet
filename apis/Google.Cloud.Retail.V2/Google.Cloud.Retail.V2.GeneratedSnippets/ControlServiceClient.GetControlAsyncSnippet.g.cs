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

namespace Google.Cloud.Retail.V2.Snippets
{
    // [START retail_v2_generated_ControlService_GetControl_async_flattened]
    using Google.Cloud.Retail.V2;
    using System.Threading.Tasks;

    public sealed partial class GeneratedControlServiceClientSnippets
    {
        /// <summary>Snippet for GetControlAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetControlAsync()
        {
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/controls/[CONTROL]";
            // Make the request
            Control response = await controlServiceClient.GetControlAsync(name);
        }
    }
    // [END retail_v2_generated_ControlService_GetControl_async_flattened]
}
