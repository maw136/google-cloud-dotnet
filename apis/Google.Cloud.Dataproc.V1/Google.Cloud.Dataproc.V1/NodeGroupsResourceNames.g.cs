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
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.Dataproc.V1;
using sys = System;

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Resource name for the <c>ClusterRegion</c> resource.</summary>
    public sealed partial class ClusterRegionName : gax::IResourceName, sys::IEquatable<ClusterRegionName>
    {
        /// <summary>The possible contents of <see cref="ClusterRegionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/regions/{region}/clusters/{cluster}</c>.
            /// </summary>
            ProjectRegionCluster = 1,
        }

        private static gax::PathTemplate s_projectRegionCluster = new gax::PathTemplate("projects/{project}/regions/{region}/clusters/{cluster}");

        /// <summary>Creates a <see cref="ClusterRegionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ClusterRegionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ClusterRegionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ClusterRegionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ClusterRegionName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ClusterRegionName"/> constructed from the provided ids.</returns>
        public static ClusterRegionName FromProjectRegionCluster(string projectId, string regionId, string clusterId) =>
            new ClusterRegionName(ResourceNameType.ProjectRegionCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClusterRegionName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClusterRegionName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string clusterId) =>
            FormatProjectRegionCluster(projectId, regionId, clusterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClusterRegionName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClusterRegionName"/> with pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}</c>.
        /// </returns>
        public static string FormatProjectRegionCluster(string projectId, string regionId, string clusterId) =>
            s_projectRegionCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ClusterRegionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/clusters/{cluster}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="clusterRegionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ClusterRegionName"/> if successful.</returns>
        public static ClusterRegionName Parse(string clusterRegionName) => Parse(clusterRegionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ClusterRegionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/clusters/{cluster}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clusterRegionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ClusterRegionName"/> if successful.</returns>
        public static ClusterRegionName Parse(string clusterRegionName, bool allowUnparsed) =>
            TryParse(clusterRegionName, allowUnparsed, out ClusterRegionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClusterRegionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/clusters/{cluster}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="clusterRegionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClusterRegionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clusterRegionName, out ClusterRegionName result) =>
            TryParse(clusterRegionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClusterRegionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/clusters/{cluster}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clusterRegionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClusterRegionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clusterRegionName, bool allowUnparsed, out ClusterRegionName result)
        {
            gax::GaxPreconditions.CheckNotNull(clusterRegionName, nameof(clusterRegionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionCluster.TryParseName(clusterRegionName, out resourceName))
            {
                result = FromProjectRegionCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(clusterRegionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ClusterRegionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string projectId = null, string regionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            ProjectId = projectId;
            RegionId = regionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ClusterRegionName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/clusters/{cluster}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        public ClusterRegionName(string projectId, string regionId, string clusterId) : this(ResourceNameType.ProjectRegionCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)))
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
        /// The <c>Cluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClusterId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionCluster: return s_projectRegionCluster.Expand(ProjectId, RegionId, ClusterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ClusterRegionName);

        /// <inheritdoc/>
        public bool Equals(ClusterRegionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ClusterRegionName a, ClusterRegionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ClusterRegionName a, ClusterRegionName b) => !(a == b);
    }

    public partial class CreateNodeGroupRequest
    {
        /// <summary>
        /// <see cref="ClusterRegionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterRegionName ParentAsClusterRegionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterRegionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetNodeGroupRequest
    {
        /// <summary>
        /// <see cref="gcdv::NodeGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::NodeGroupName NodeGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::NodeGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
