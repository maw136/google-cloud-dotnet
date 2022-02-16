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

namespace Google.Cloud.Firestore.Admin.V1.Snippets
{
    // [START firestore_v1_generated_FirestoreAdmin_UpdateField_async]
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;
    using gcfav = Google.Cloud.Firestore.Admin.V1;

    public sealed partial class GeneratedFirestoreAdminClientSnippets
    {
        /// <summary>Snippet for UpdateFieldAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateFieldRequestObjectAsync()
        {
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFieldRequest request = new UpdateFieldRequest
            {
                Field = new gcfav::Field(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcfav::Field, FieldOperationMetadata> response = await firestoreAdminClient.UpdateFieldAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Field, FieldOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcfav::Field result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Field, FieldOperationMetadata> retrievedResponse = await firestoreAdminClient.PollOnceUpdateFieldAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Field retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END firestore_v1_generated_FirestoreAdmin_UpdateField_async]
}
