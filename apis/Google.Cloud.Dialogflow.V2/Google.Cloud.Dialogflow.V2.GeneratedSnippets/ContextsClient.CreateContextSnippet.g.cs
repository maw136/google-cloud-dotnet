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

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    // [START dialogflow_v2_generated_Contexts_CreateContext_sync_flattened]
    using Google.Cloud.Dialogflow.V2;

    public sealed partial class GeneratedContextsClientSnippets
    {
        /// <summary>Snippet for CreateContext</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateContext()
        {
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/sessions/[SESSION]";
            Context context = new Context();
            // Make the request
            Context response = contextsClient.CreateContext(parent, context);
        }
    }
    // [END dialogflow_v2_generated_Contexts_CreateContext_sync_flattened]
}
