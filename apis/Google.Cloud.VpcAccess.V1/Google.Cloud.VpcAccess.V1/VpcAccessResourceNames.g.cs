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

using gax = Google.Api.Gax;
using gagr = Google.Api.Gax.ResourceNames;
using gcvv = Google.Cloud.VpcAccess.V1;
using sys = System;

namespace Google.Cloud.VpcAccess.V1
{
    /// <summary>Resource name for the <c>Connector</c> resource.</summary>
    public sealed partial class ConnectorName : gax::IResourceName, sys::IEquatable<ConnectorName>
    {
        /// <summary>The possible contents of <see cref="ConnectorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/connectors/{connector}</c>.
            /// </summary>
            ProjectLocationConnector = 1,
        }

        private static gax::PathTemplate s_projectLocationConnector = new gax::PathTemplate("projects/{project}/locations/{location}/connectors/{connector}");

        /// <summary>Creates a <see cref="ConnectorName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConnectorName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConnectorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConnectorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConnectorName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/connectors/{connector}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectorId">The <c>Connector</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConnectorName"/> constructed from the provided ids.</returns>
        public static ConnectorName FromProjectLocationConnector(string projectId, string locationId, string connectorId) =>
            new ConnectorName(ResourceNameType.ProjectLocationConnector, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectorId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectors/{connector}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectorId">The <c>Connector</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectors/{connector}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string connectorId) =>
            FormatProjectLocationConnector(projectId, locationId, connectorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectors/{connector}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectorId">The <c>Connector</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectors/{connector}</c>.
        /// </returns>
        public static string FormatProjectLocationConnector(string projectId, string locationId, string connectorId) =>
            s_projectLocationConnector.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)));

        /// <summary>Parses the given resource name string into a new <see cref="ConnectorName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/connectors/{connector}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConnectorName"/> if successful.</returns>
        public static ConnectorName Parse(string connectorName) => Parse(connectorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConnectorName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/connectors/{connector}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConnectorName"/> if successful.</returns>
        public static ConnectorName Parse(string connectorName, bool allowUnparsed) =>
            TryParse(connectorName, allowUnparsed, out ConnectorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/connectors/{connector}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectorName, out ConnectorName result) => TryParse(connectorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectorName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/connectors/{connector}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectorName, bool allowUnparsed, out ConnectorName result)
        {
            gax::GaxPreconditions.CheckNotNull(connectorName, nameof(connectorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConnector.TryParseName(connectorName, out resourceName))
            {
                result = FromProjectLocationConnector(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(connectorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConnectorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string connectorId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConnectorId = connectorId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConnectorName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/connectors/{connector}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectorId">The <c>Connector</c> ID. Must not be <c>null</c> or empty.</param>
        public ConnectorName(string projectId, string locationId, string connectorId) : this(ResourceNameType.ProjectLocationConnector, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectorId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)))
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
        /// The <c>Connector</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ConnectorId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationConnector: return s_projectLocationConnector.Expand(ProjectId, LocationId, ConnectorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConnectorName);

        /// <inheritdoc/>
        public bool Equals(ConnectorName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ConnectorName a, ConnectorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ConnectorName a, ConnectorName b) => !(a == b);
    }

    public partial class Connector
    {
        /// <summary>
        /// <see cref="gcvv::ConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ConnectorName ConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateConnectorRequest
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

    public partial class GetConnectorRequest
    {
        /// <summary>
        /// <see cref="gcvv::ConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ConnectorName ConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConnectorsRequest
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

    public partial class DeleteConnectorRequest
    {
        /// <summary>
        /// <see cref="gcvv::ConnectorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ConnectorName ConnectorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ConnectorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class OperationMetadata
    {
        /// <summary>
        /// <see cref="ConnectorName"/>-typed view over the <see cref="Target"/> resource name property.
        /// </summary>
        public ConnectorName TargetAsConnectorName
        {
            get => string.IsNullOrEmpty(Target) ? null : ConnectorName.Parse(Target, allowUnparsed: true);
            set => Target = value?.ToString() ?? "";
        }
    }
}
