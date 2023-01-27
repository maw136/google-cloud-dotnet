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
using gax = Google.Api.Gax;
using gagr = Google.Api.Gax.ResourceNames;
using gcvv = Google.Cloud.VmwareEngine.V1;
using sys = System;

namespace Google.Cloud.VmwareEngine.V1
{
    /// <summary>Resource name for the <c>Network</c> resource.</summary>
    public sealed partial class NetworkName : gax::IResourceName, sys::IEquatable<NetworkName>
    {
        /// <summary>The possible contents of <see cref="NetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/global/networks/{network}</c>.</summary>
            ProjectNetwork = 1,
        }

        private static gax::PathTemplate s_projectNetwork = new gax::PathTemplate("projects/{project}/global/networks/{network}");

        /// <summary>Creates a <see cref="NetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkName"/> with the pattern <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkName"/> constructed from the provided ids.</returns>
        public static NetworkName FromProjectNetwork(string projectId, string networkId) =>
            new NetworkName(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string Format(string projectId, string networkId) => FormatProjectNetwork(projectId, networkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string FormatProjectNetwork(string projectId, string networkId) =>
            s_projectNetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>Parses the given resource name string into a new <see cref="NetworkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName) => Parse(networkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName, bool allowUnparsed) =>
            TryParse(networkName, allowUnparsed, out NetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, out NetworkName result) => TryParse(networkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, bool allowUnparsed, out NetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkName, nameof(networkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNetwork.TryParseName(networkName, out resourceName))
            {
                result = FromProjectNetwork(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkId = networkId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkName"/> class from the component parts of pattern
        /// <c>projects/{project}/global/networks/{network}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkName(string projectId, string networkId) : this(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Network</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNetwork: return s_projectNetwork.Expand(ProjectId, NetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworkName);

        /// <inheritdoc/>
        public bool Equals(NetworkName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(NetworkName a, NetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(NetworkName a, NetworkName b) => !(a == b);
    }

    public partial class ListPrivateCloudsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPrivateCloudRequest
    {
        /// <summary>
        /// <see cref="gcvv::PrivateCloudName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::PrivateCloudName PrivateCloudName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::PrivateCloudName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePrivateCloudRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePrivateCloudRequest
    {
        /// <summary>
        /// <see cref="gcvv::PrivateCloudName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::PrivateCloudName PrivateCloudName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::PrivateCloudName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UndeletePrivateCloudRequest
    {
        /// <summary>
        /// <see cref="gcvv::PrivateCloudName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::PrivateCloudName PrivateCloudName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::PrivateCloudName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListClustersRequest
    {
        /// <summary>
        /// <see cref="PrivateCloudName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PrivateCloudName ParentAsPrivateCloudName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PrivateCloudName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetClusterRequest
    {
        /// <summary>
        /// <see cref="gcvv::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateClusterRequest
    {
        /// <summary>
        /// <see cref="PrivateCloudName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PrivateCloudName ParentAsPrivateCloudName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PrivateCloudName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteClusterRequest
    {
        /// <summary>
        /// <see cref="gcvv::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSubnetsRequest
    {
        /// <summary>
        /// <see cref="PrivateCloudName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PrivateCloudName ParentAsPrivateCloudName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PrivateCloudName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListNodeTypesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetNodeTypeRequest
    {
        /// <summary>
        /// <see cref="gcvv::NodeTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::NodeTypeName NodeTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::NodeTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ShowNsxCredentialsRequest
    {
        /// <summary>
        /// <see cref="PrivateCloudName"/>-typed view over the <see cref="PrivateCloud"/> resource name property.
        /// </summary>
        public PrivateCloudName PrivateCloudAsPrivateCloudName
        {
            get => string.IsNullOrEmpty(PrivateCloud) ? null : PrivateCloudName.Parse(PrivateCloud, allowUnparsed: true);
            set => PrivateCloud = value?.ToString() ?? "";
        }
    }

    public partial class ShowVcenterCredentialsRequest
    {
        /// <summary>
        /// <see cref="PrivateCloudName"/>-typed view over the <see cref="PrivateCloud"/> resource name property.
        /// </summary>
        public PrivateCloudName PrivateCloudAsPrivateCloudName
        {
            get => string.IsNullOrEmpty(PrivateCloud) ? null : PrivateCloudName.Parse(PrivateCloud, allowUnparsed: true);
            set => PrivateCloud = value?.ToString() ?? "";
        }
    }

    public partial class ResetNsxCredentialsRequest
    {
        /// <summary>
        /// <see cref="PrivateCloudName"/>-typed view over the <see cref="PrivateCloud"/> resource name property.
        /// </summary>
        public PrivateCloudName PrivateCloudAsPrivateCloudName
        {
            get => string.IsNullOrEmpty(PrivateCloud) ? null : PrivateCloudName.Parse(PrivateCloud, allowUnparsed: true);
            set => PrivateCloud = value?.ToString() ?? "";
        }
    }

    public partial class ResetVcenterCredentialsRequest
    {
        /// <summary>
        /// <see cref="PrivateCloudName"/>-typed view over the <see cref="PrivateCloud"/> resource name property.
        /// </summary>
        public PrivateCloudName PrivateCloudAsPrivateCloudName
        {
            get => string.IsNullOrEmpty(PrivateCloud) ? null : PrivateCloudName.Parse(PrivateCloud, allowUnparsed: true);
            set => PrivateCloud = value?.ToString() ?? "";
        }
    }

    public partial class ListHcxActivationKeysRequest
    {
        /// <summary>
        /// <see cref="PrivateCloudName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PrivateCloudName ParentAsPrivateCloudName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PrivateCloudName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetHcxActivationKeyRequest
    {
        /// <summary>
        /// <see cref="gcvv::HcxActivationKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::HcxActivationKeyName HcxActivationKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::HcxActivationKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateHcxActivationKeyRequest
    {
        /// <summary>
        /// <see cref="PrivateCloudName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PrivateCloudName ParentAsPrivateCloudName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PrivateCloudName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListNetworkPoliciesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetNetworkPolicyRequest
    {
        /// <summary>
        /// <see cref="gcvv::NetworkPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::NetworkPolicyName NetworkPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::NetworkPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateNetworkPolicyRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteNetworkPolicyRequest
    {
        /// <summary>
        /// <see cref="gcvv::NetworkPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::NetworkPolicyName NetworkPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::NetworkPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateVmwareEngineNetworkRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteVmwareEngineNetworkRequest
    {
        /// <summary>
        /// <see cref="gcvv::VmwareEngineNetworkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::VmwareEngineNetworkName VmwareEngineNetworkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::VmwareEngineNetworkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetVmwareEngineNetworkRequest
    {
        /// <summary>
        /// <see cref="gcvv::VmwareEngineNetworkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::VmwareEngineNetworkName VmwareEngineNetworkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::VmwareEngineNetworkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListVmwareEngineNetworksRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
