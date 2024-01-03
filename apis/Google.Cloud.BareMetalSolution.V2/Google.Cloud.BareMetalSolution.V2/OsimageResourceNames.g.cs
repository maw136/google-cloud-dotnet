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
using gax = Google.Api.Gax;
using gagr = Google.Api.Gax.ResourceNames;
using gcbv = Google.Cloud.BareMetalSolution.V2;
using sys = System;

namespace Google.Cloud.BareMetalSolution.V2
{
    /// <summary>Resource name for the <c>OsImage</c> resource.</summary>
    public sealed partial class OsImageName : gax::IResourceName, sys::IEquatable<OsImageName>
    {
        /// <summary>The possible contents of <see cref="OsImageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/osImages/{os_image}</c>.
            /// </summary>
            ProjectLocationOsImage = 1,
        }

        private static gax::PathTemplate s_projectLocationOsImage = new gax::PathTemplate("projects/{project}/locations/{location}/osImages/{os_image}");

        /// <summary>Creates a <see cref="OsImageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OsImageName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OsImageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OsImageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OsImageName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/osImages/{os_image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="osImageId">The <c>OsImage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OsImageName"/> constructed from the provided ids.</returns>
        public static OsImageName FromProjectLocationOsImage(string projectId, string locationId, string osImageId) =>
            new OsImageName(ResourceNameType.ProjectLocationOsImage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), osImageId: gax::GaxPreconditions.CheckNotNullOrEmpty(osImageId, nameof(osImageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OsImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/osImages/{os_image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="osImageId">The <c>OsImage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OsImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/osImages/{os_image}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string osImageId) =>
            FormatProjectLocationOsImage(projectId, locationId, osImageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OsImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/osImages/{os_image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="osImageId">The <c>OsImage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OsImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/osImages/{os_image}</c>.
        /// </returns>
        public static string FormatProjectLocationOsImage(string projectId, string locationId, string osImageId) =>
            s_projectLocationOsImage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(osImageId, nameof(osImageId)));

        /// <summary>Parses the given resource name string into a new <see cref="OsImageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/osImages/{os_image}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="osImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OsImageName"/> if successful.</returns>
        public static OsImageName Parse(string osImageName) => Parse(osImageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OsImageName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/osImages/{os_image}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="osImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OsImageName"/> if successful.</returns>
        public static OsImageName Parse(string osImageName, bool allowUnparsed) =>
            TryParse(osImageName, allowUnparsed, out OsImageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OsImageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/osImages/{os_image}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="osImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OsImageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string osImageName, out OsImageName result) => TryParse(osImageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OsImageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/osImages/{os_image}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="osImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OsImageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string osImageName, bool allowUnparsed, out OsImageName result)
        {
            gax::GaxPreconditions.CheckNotNull(osImageName, nameof(osImageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOsImage.TryParseName(osImageName, out resourceName))
            {
                result = FromProjectLocationOsImage(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(osImageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OsImageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string osImageId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OsImageId = osImageId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OsImageName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/osImages/{os_image}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="osImageId">The <c>OsImage</c> ID. Must not be <c>null</c> or empty.</param>
        public OsImageName(string projectId, string locationId, string osImageId) : this(ResourceNameType.ProjectLocationOsImage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), osImageId: gax::GaxPreconditions.CheckNotNullOrEmpty(osImageId, nameof(osImageId)))
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
        /// The <c>OsImage</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OsImageId { get; }

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
                case ResourceNameType.ProjectLocationOsImage: return s_projectLocationOsImage.Expand(ProjectId, LocationId, OsImageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OsImageName);

        /// <inheritdoc/>
        public bool Equals(OsImageName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(OsImageName a, OsImageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(OsImageName a, OsImageName b) => !(a == b);
    }

    public partial class OSImage
    {
        /// <summary>
        /// <see cref="gcbv::OsImageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::OsImageName OsImageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::OsImageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListOSImagesRequest
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
