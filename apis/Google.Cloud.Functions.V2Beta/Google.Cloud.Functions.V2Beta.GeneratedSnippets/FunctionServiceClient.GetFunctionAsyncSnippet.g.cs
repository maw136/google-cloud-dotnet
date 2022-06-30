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

namespace Google.Cloud.Functions.V2Beta.Snippets
{
    // [START cloudfunctions_v2beta_generated_FunctionService_GetFunction_async_flattened]
    using Google.Cloud.Functions.V2Beta;
    using System.Threading.Tasks;

    public sealed partial class GeneratedFunctionServiceClientSnippets
    {
        /// <summary>Snippet for GetFunctionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetFunctionAsync()
        {
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            // Make the request
            Function response = await functionServiceClient.GetFunctionAsync(name);
        }
    }
    // [END cloudfunctions_v2beta_generated_FunctionService_GetFunction_async_flattened]
}
