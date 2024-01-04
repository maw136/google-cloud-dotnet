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
    // [START firestore_v1_generated_Firestore_RunQuery_sync]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Firestore.V1;
    using Google.Protobuf;
    using System.Threading.Tasks;

    public sealed partial class GeneratedFirestoreClientSnippets
    {
        /// <summary>Snippet for RunQuery</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task RunQueryRequestObject()
        {
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            RunQueryRequest request = new RunQueryRequest
            {
                Parent = "",
                StructuredQuery = new StructuredQuery(),
                Transaction = ByteString.Empty,
                Mode = QueryMode.Normal,
            };
            // Make the request, returning a streaming response
            using FirestoreClient.RunQueryStream response = firestoreClient.RunQuery(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<RunQueryResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                RunQueryResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END firestore_v1_generated_Firestore_RunQuery_sync]
}
