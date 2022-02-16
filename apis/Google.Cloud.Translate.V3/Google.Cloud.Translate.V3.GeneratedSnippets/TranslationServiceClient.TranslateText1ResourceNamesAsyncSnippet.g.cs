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

namespace Google.Cloud.Translate.V3.Snippets
{
    // [START translate_v3_generated_TranslationService_TranslateText_async_flattened1_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Translate.V3;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedTranslationServiceClientSnippets
    {
        /// <summary>Snippet for TranslateTextAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task TranslateText1ResourceNamesAsync()
        {
            // Create client
            TranslationServiceClient translationServiceClient = await TranslationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string targetLanguageCode = "";
            IEnumerable<string> contents = new string[] { "", };
            // Make the request
            TranslateTextResponse response = await translationServiceClient.TranslateTextAsync(parent, targetLanguageCode, contents);
        }
    }
    // [END translate_v3_generated_TranslationService_TranslateText_async_flattened1_resourceNames]
}
