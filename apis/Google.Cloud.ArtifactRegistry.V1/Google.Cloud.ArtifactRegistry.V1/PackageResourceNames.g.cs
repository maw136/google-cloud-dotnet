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
using gcav = Google.Cloud.ArtifactRegistry.V1;
using sys = System;

namespace Google.Cloud.ArtifactRegistry.V1
{
    /// <summary>Resource name for the <c>Package</c> resource.</summary>
    public sealed partial class PackageName : gax::IResourceName, sys::IEquatable<PackageName>
    {
        /// <summary>The possible contents of <see cref="PackageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}</c>.
            /// </summary>
            ProjectLocationRepositoryPackage = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryPackage = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/packages/{package}");

        /// <summary>Creates a <see cref="PackageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PackageName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PackageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PackageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PackageName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="packageId">The <c>Package</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PackageName"/> constructed from the provided ids.</returns>
        public static PackageName FromProjectLocationRepositoryPackage(string projectId, string locationId, string repositoryId, string packageId) =>
            new PackageName(ResourceNameType.ProjectLocationRepositoryPackage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), packageId: gax::GaxPreconditions.CheckNotNullOrEmpty(packageId, nameof(packageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="packageId">The <c>Package</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string packageId) =>
            FormatProjectLocationRepositoryPackage(projectId, locationId, repositoryId, packageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="packageId">The <c>Package</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryPackage(string projectId, string locationId, string repositoryId, string packageId) =>
            s_projectLocationRepositoryPackage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(packageId, nameof(packageId)));

        /// <summary>Parses the given resource name string into a new <see cref="PackageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="packageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PackageName"/> if successful.</returns>
        public static PackageName Parse(string packageName) => Parse(packageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PackageName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="packageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PackageName"/> if successful.</returns>
        public static PackageName Parse(string packageName, bool allowUnparsed) =>
            TryParse(packageName, allowUnparsed, out PackageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PackageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="packageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PackageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string packageName, out PackageName result) => TryParse(packageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PackageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="packageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PackageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string packageName, bool allowUnparsed, out PackageName result)
        {
            gax::GaxPreconditions.CheckNotNull(packageName, nameof(packageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryPackage.TryParseName(packageName, out resourceName))
            {
                result = FromProjectLocationRepositoryPackage(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(packageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PackageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string packageId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PackageId = packageId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PackageName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="packageId">The <c>Package</c> ID. Must not be <c>null</c> or empty.</param>
        public PackageName(string projectId, string locationId, string repositoryId, string packageId) : this(ResourceNameType.ProjectLocationRepositoryPackage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), packageId: gax::GaxPreconditions.CheckNotNullOrEmpty(packageId, nameof(packageId)))
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
        /// The <c>Package</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PackageId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Repository</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RepositoryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRepositoryPackage: return s_projectLocationRepositoryPackage.Expand(ProjectId, LocationId, RepositoryId, PackageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PackageName);

        /// <inheritdoc/>
        public bool Equals(PackageName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(PackageName a, PackageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(PackageName a, PackageName b) => !(a == b);
    }

    public partial class Package
    {
        /// <summary>
        /// <see cref="gcav::PackageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PackageName PackageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PackageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPackagesRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPackageRequest
    {
        /// <summary>
        /// <see cref="gcav::PackageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PackageName PackageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PackageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeletePackageRequest
    {
        /// <summary>
        /// <see cref="gcav::PackageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PackageName PackageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PackageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
