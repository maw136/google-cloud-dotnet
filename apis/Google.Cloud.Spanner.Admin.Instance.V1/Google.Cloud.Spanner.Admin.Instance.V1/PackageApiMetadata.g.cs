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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Spanner.Admin.Instance.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/instances/*/databases/*/operations/*}:cancel", "additionalBindings": [ { "post": "/v1/{name=projects/*/instances/*/operations/*}:cancel" } ] }
                    proto::ByteString.FromBase64("IkEvdjEve25hbWU9cHJvamVjdHMvKi9pbnN0YW5jZXMvKi9kYXRhYmFzZXMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbFo3IjUvdjEve25hbWU9cHJvamVjdHMvKi9pbnN0YW5jZXMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbA==")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1/{name=projects/*/instances/*/databases/*/operations/*}", "additionalBindings": [ { "delete": "/v1/{name=projects/*/instances/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("KjovdjEve25hbWU9cHJvamVjdHMvKi9pbnN0YW5jZXMvKi9kYXRhYmFzZXMvKi9vcGVyYXRpb25zLyp9WjAqLi92MS97bmFtZT1wcm9qZWN0cy8qL2luc3RhbmNlcy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/instances/*/databases/*/operations/*}", "additionalBindings": [ { "get": "/v1/{name=projects/*/instances/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EjovdjEve25hbWU9cHJvamVjdHMvKi9pbnN0YW5jZXMvKi9kYXRhYmFzZXMvKi9vcGVyYXRpb25zLyp9WjASLi92MS97bmFtZT1wcm9qZWN0cy8qL2luc3RhbmNlcy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*/instances/*/databases/*/operations}", "additionalBindings": [ { "get": "/v1/{name=projects/*/instances/*/operations}" } ] }
                    proto::ByteString.FromBase64("EjgvdjEve25hbWU9cHJvamVjdHMvKi9pbnN0YW5jZXMvKi9kYXRhYmFzZXMvKi9vcGVyYXRpb25zfVouEiwvdjEve25hbWU9cHJvamVjdHMvKi9pbnN0YW5jZXMvKi9vcGVyYXRpb25zfQ==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return CommonReflection.Descriptor;
            yield return SpannerInstanceAdminReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
