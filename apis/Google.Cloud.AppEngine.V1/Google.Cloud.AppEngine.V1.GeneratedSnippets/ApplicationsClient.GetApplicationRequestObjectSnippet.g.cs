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

namespace Google.Cloud.AppEngine.V1.Snippets
{
    // [START appengine_v1_generated_Applications_GetApplication_sync]
    using Google.Cloud.AppEngine.V1;

    public sealed partial class GeneratedApplicationsClientSnippets
    {
        /// <summary>Snippet for GetApplication</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetApplicationRequestObject()
        {
            // Create client
            ApplicationsClient applicationsClient = ApplicationsClient.Create();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest { Name = "", };
            // Make the request
            Application response = applicationsClient.GetApplication(request);
        }
    }
    // [END appengine_v1_generated_Applications_GetApplication_sync]
}
