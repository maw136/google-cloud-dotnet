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

namespace Google.Cloud.Dialogflow.Cx.V3.Snippets
{
    // [START dialogflow_v3_generated_Pages_CreatePage_async_flattened_resourceNames]
    using Google.Cloud.Dialogflow.Cx.V3;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPagesClientSnippets
    {
        /// <summary>Snippet for CreatePageAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreatePageResourceNamesAsync()
        {
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            FlowName parent = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            Page page = new Page();
            // Make the request
            Page response = await pagesClient.CreatePageAsync(parent, page);
        }
    }
    // [END dialogflow_v3_generated_Pages_CreatePage_async_flattened_resourceNames]
}
