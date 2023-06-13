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
using gccv = Google.Cloud.Connectors.V1;
using sys = System;

namespace Google.Cloud.Connectors.V1
{
    /// <summary>Resource name for the <c>RuntimeConfig</c> resource.</summary>
    public sealed partial class RuntimeConfigName : gax::IResourceName, sys::IEquatable<RuntimeConfigName>
    {
        /// <summary>The possible contents of <see cref="RuntimeConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/runtimeConfig</c>.
            /// </summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/runtimeConfig");

        /// <summary>Creates a <see cref="RuntimeConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RuntimeConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RuntimeConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RuntimeConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RuntimeConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/runtimeConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RuntimeConfigName"/> constructed from the provided ids.</returns>
        public static RuntimeConfigName FromProjectLocation(string projectId, string locationId) =>
            new RuntimeConfigName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuntimeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/runtimeConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RuntimeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/runtimeConfig</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuntimeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/runtimeConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RuntimeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/runtimeConfig</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RuntimeConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/runtimeConfig</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="runtimeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RuntimeConfigName"/> if successful.</returns>
        public static RuntimeConfigName Parse(string runtimeConfigName) => Parse(runtimeConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RuntimeConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/runtimeConfig</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="runtimeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RuntimeConfigName"/> if successful.</returns>
        public static RuntimeConfigName Parse(string runtimeConfigName, bool allowUnparsed) =>
            TryParse(runtimeConfigName, allowUnparsed, out RuntimeConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RuntimeConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/runtimeConfig</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="runtimeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuntimeConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string runtimeConfigName, out RuntimeConfigName result) =>
            TryParse(runtimeConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RuntimeConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/runtimeConfig</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="runtimeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuntimeConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string runtimeConfigName, bool allowUnparsed, out RuntimeConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(runtimeConfigName, nameof(runtimeConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(runtimeConfigName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(runtimeConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RuntimeConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RuntimeConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/runtimeConfig</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public RuntimeConfigName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RuntimeConfigName);

        /// <inheritdoc/>
        public bool Equals(RuntimeConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RuntimeConfigName a, RuntimeConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RuntimeConfigName a, RuntimeConfigName b) => !(a == b);
    }

    public partial class GetRuntimeConfigRequest
    {
        /// <summary>
        /// <see cref="gccv::RuntimeConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RuntimeConfigName RuntimeConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RuntimeConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RuntimeConfig
    {
        /// <summary>
        /// <see cref="gccv::RuntimeConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RuntimeConfigName RuntimeConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RuntimeConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
