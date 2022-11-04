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

namespace Google.Cloud.Eventarc.V1.Snippets
{
    // [START eventarc_v1_generated_Eventarc_UpdateGoogleChannelConfig_async]
    using Google.Cloud.Eventarc.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedEventarcClientSnippets
    {
        /// <summary>Snippet for UpdateGoogleChannelConfigAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateGoogleChannelConfigRequestObjectAsync()
        {
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGoogleChannelConfigRequest request = new UpdateGoogleChannelConfigRequest
            {
                GoogleChannelConfig = new GoogleChannelConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GoogleChannelConfig response = await eventarcClient.UpdateGoogleChannelConfigAsync(request);
        }
    }
    // [END eventarc_v1_generated_Eventarc_UpdateGoogleChannelConfig_async]
}
