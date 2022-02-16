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

namespace Google.Cloud.Speech.V1.Snippets
{
    // [START speech_v1_generated_Speech_LongRunningRecognize_async]
    using Google.Cloud.Speech.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSpeechClientSnippets
    {
        /// <summary>Snippet for LongRunningRecognizeAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task LongRunningRecognizeRequestObjectAsync()
        {
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            LongRunningRecognizeRequest request = new LongRunningRecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
                OutputConfig = new TranscriptOutputConfig(),
            };
            // Make the request
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> response = await speechClient.LongRunningRecognizeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LongRunningRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> retrievedResponse = await speechClient.PollOnceLongRunningRecognizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LongRunningRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END speech_v1_generated_Speech_LongRunningRecognize_async]
}
