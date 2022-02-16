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

namespace Google.Cloud.WebSecurityScanner.V1.Snippets
{
    // [START websecurityscanner_v1_generated_WebSecurityScanner_UpdateScanConfig_async]
    using Google.Cloud.WebSecurityScanner.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedWebSecurityScannerClientSnippets
    {
        /// <summary>Snippet for UpdateScanConfigAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateScanConfigRequestObjectAsync()
        {
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateScanConfigRequest request = new UpdateScanConfigRequest
            {
                ScanConfig = new ScanConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ScanConfig response = await webSecurityScannerClient.UpdateScanConfigAsync(request);
        }
    }
    // [END websecurityscanner_v1_generated_WebSecurityScanner_UpdateScanConfig_async]
}
