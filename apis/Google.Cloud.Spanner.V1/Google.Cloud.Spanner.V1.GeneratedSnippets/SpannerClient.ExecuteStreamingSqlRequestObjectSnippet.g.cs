// Copyright 2023 Google LLC
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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START spanner_v1_generated_Spanner_ExecuteStreamingSql_sync]
    using Google.Api.Gax.Grpc;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;
    using gcsv = Google.Cloud.Spanner.V1;

    public sealed partial class GeneratedSpannerClientSnippets
    {
        /// <summary>Snippet for ExecuteStreamingSql</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ExecuteStreamingSqlRequestObject()
        {
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::ExecuteSqlRequest request = new gcsv::ExecuteSqlRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Sql = "",
                Params = new Struct(),
                ParamTypes =
                {
                    {
                        "",
                        new gcsv::Type()
                    },
                },
                ResumeToken = ByteString.Empty,
                QueryMode = gcsv::ExecuteSqlRequest.Types.QueryMode.Normal,
                PartitionToken = ByteString.Empty,
                Seqno = 0L,
                QueryOptions = new gcsv::ExecuteSqlRequest.Types.QueryOptions(),
                RequestOptions = new gcsv::RequestOptions(),
                DataBoostEnabled = false,
            };
            // Make the request, returning a streaming response
            gcsv::SpannerClient.ExecuteStreamingSqlStream response = spannerClient.ExecuteStreamingSql(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcsv::PartialResultSet> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcsv::PartialResultSet responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END spanner_v1_generated_Spanner_ExecuteStreamingSql_sync]
}
