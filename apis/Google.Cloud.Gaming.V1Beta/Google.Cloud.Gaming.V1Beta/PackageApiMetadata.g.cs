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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.Gaming.V1Beta
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Gaming.V1Beta", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1beta/{name=projects/*/locations/*/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IjkvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfTpjYW5jZWw6ASo=")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1beta/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("KjIvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1beta/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("EjIvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1beta/{name=projects/*/locations/*}/operations" }
                    proto::ByteString.FromBase64("EjAvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyp9L29wZXJhdGlvbnM=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return CommonReflection.Descriptor;
            yield return GameServerClustersReflection.Descriptor;
            yield return GameServerClustersServiceReflection.Descriptor;
            yield return GameServerConfigsReflection.Descriptor;
            yield return GameServerConfigsServiceReflection.Descriptor;
            yield return GameServerDeploymentsReflection.Descriptor;
            yield return GameServerDeploymentsServiceReflection.Descriptor;
            yield return RealmsReflection.Descriptor;
            yield return RealmsServiceReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
