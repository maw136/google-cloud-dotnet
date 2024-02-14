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
    // [START composer_v1_generated_Environments_CreateUserWorkloadsSecret_sync_flattened]
    using Google.Cloud.Orchestration.Airflow.Service.V1;

    public sealed partial class GeneratedEnvironmentsClientSnippets
    {
        /// <summary>Snippet for CreateUserWorkloadsSecret</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateUserWorkloadsSecret()
        {
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]";
            UserWorkloadsSecret userWorkloadsSecret = new UserWorkloadsSecret();
            // Make the request
            UserWorkloadsSecret response = environmentsClient.CreateUserWorkloadsSecret(parent, userWorkloadsSecret);
        }
    }
    // [END composer_v1_generated_Environments_CreateUserWorkloadsSecret_sync_flattened]
}
