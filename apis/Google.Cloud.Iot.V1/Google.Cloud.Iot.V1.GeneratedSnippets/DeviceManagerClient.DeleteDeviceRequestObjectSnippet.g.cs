// Copyright 2023 Google LLC
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
    // [START cloudiot_v1_generated_DeviceManager_DeleteDevice_sync]
    using Google.Cloud.Iot.V1;

    public sealed partial class GeneratedDeviceManagerClientSnippets
    {
        /// <summary>Snippet for DeleteDevice</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void DeleteDeviceRequestObject()
        {
            // Create client
            DeviceManagerClient deviceManagerClient = DeviceManagerClient.Create();
            // Initialize request argument(s)
            DeleteDeviceRequest request = new DeleteDeviceRequest
            {
                DeviceName = DeviceName.FromProjectLocationRegistryDevice("[PROJECT]", "[LOCATION]", "[REGISTRY]", "[DEVICE]"),
            };
            // Make the request
            deviceManagerClient.DeleteDevice(request);
        }
    }
    // [END cloudiot_v1_generated_DeviceManager_DeleteDevice_sync]
}
