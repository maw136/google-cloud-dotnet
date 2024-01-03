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
    // [START clouddeploy_v1_generated_CloudDeploy_GetCustomTargetType_sync_flattened_resourceNames]
    using Google.Cloud.Deploy.V1;

    public sealed partial class GeneratedCloudDeployClientSnippets
    {
        /// <summary>Snippet for GetCustomTargetType</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void GetCustomTargetTypeResourceNames()
        {
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CustomTargetTypeName name = CustomTargetTypeName.FromProjectLocationCustomTargetType("[PROJECT]", "[LOCATION]", "[CUSTOM_TARGET_TYPE]");
            // Make the request
            CustomTargetType response = cloudDeployClient.GetCustomTargetType(name);
        }
    }
    // [END clouddeploy_v1_generated_CloudDeploy_GetCustomTargetType_sync_flattened_resourceNames]
}
