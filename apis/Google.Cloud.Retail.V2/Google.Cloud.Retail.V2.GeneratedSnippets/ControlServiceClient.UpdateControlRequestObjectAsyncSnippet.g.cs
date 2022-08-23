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
    // [START retail_v2_generated_ControlService_UpdateControl_async]
    using Google.Cloud.Retail.V2;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedControlServiceClientSnippets
    {
        /// <summary>Snippet for UpdateControlAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateControlRequestObjectAsync()
        {
            // Create client
            ControlServiceClient controlServiceClient = await ControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateControlRequest request = new UpdateControlRequest
            {
                Control = new Control(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Control response = await controlServiceClient.UpdateControlAsync(request);
        }
    }
    // [END retail_v2_generated_ControlService_UpdateControl_async]
}
