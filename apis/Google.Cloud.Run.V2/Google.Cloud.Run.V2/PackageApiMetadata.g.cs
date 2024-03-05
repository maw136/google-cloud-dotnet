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
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.Run.V2
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Run.V2", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v2/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("Ki4vdjIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v2/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("Ei4vdjIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v2/{name=projects/*/locations/*}/operations" }
                    proto::ByteString.FromBase64("EiwvdjIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9ucw==")
                },
                {
                    "google.longrunning.Operations.WaitOperation",
                    // { "post": "/v2/{name=projects/*/locations/*/operations/*}:wait", "body": "*" }
                    proto::ByteString.FromBase64("IjMvdjIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OndhaXQ6ASo=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return gcl::LocationsReflection.Descriptor;
            yield return ConditionReflection.Descriptor;
            yield return ExecutionReflection.Descriptor;
            yield return ExecutionTemplateReflection.Descriptor;
            yield return JobReflection.Descriptor;
            yield return K8SMinReflection.Descriptor;
            yield return RevisionReflection.Descriptor;
            yield return RevisionTemplateReflection.Descriptor;
            yield return ServiceReflection.Descriptor;
            yield return StatusReflection.Descriptor;
            yield return TaskReflection.Descriptor;
            yield return TaskTemplateReflection.Descriptor;
            yield return TrafficTargetReflection.Descriptor;
            yield return VendorSettingsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
