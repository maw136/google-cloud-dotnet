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

namespace Google.Cloud.Trace.V2.Snippets
{
    // [START cloudtrace_v2_generated_TraceService_BatchWriteSpans_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Trace.V2;
    using System.Collections.Generic;

    public sealed partial class GeneratedTraceServiceClientSnippets
    {
        /// <summary>Snippet for BatchWriteSpans</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void BatchWriteSpansResourceNames()
        {
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            IEnumerable<Span> spans = new Span[] { new Span(), };
            // Make the request
            traceServiceClient.BatchWriteSpans(name, spans);
        }
    }
    // [END cloudtrace_v2_generated_TraceService_BatchWriteSpans_sync_flattened_resourceNames]
}
