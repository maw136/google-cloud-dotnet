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

namespace Google.Cloud.Redis.V1Beta1.Snippets
{
    // [START redis_v1beta1_generated_CloudRedis_GetInstance_async_flattened]
    using Google.Cloud.Redis.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCloudRedisClientSnippets
    {
        /// <summary>Snippet for GetInstanceAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetInstanceAsync()
        {
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = await cloudRedisClient.GetInstanceAsync(name);
        }
    }
    // [END redis_v1beta1_generated_CloudRedis_GetInstance_async_flattened]
}
