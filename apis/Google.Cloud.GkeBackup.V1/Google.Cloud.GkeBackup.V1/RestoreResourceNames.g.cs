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
using gcgv = Google.Cloud.GkeBackup.V1;
using sys = System;

namespace Google.Cloud.GkeBackup.V1
{
    /// <summary>Resource name for the <c>Restore</c> resource.</summary>
    public sealed partial class RestoreName : gax::IResourceName, sys::IEquatable<RestoreName>
    {
        /// <summary>The possible contents of <see cref="RestoreName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}</c>.
            /// </summary>
            ProjectLocationRestorePlanRestore = 1,
        }

        private static gax::PathTemplate s_projectLocationRestorePlanRestore = new gax::PathTemplate("projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}");

        /// <summary>Creates a <see cref="RestoreName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RestoreName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RestoreName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RestoreName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RestoreName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreId">The <c>Restore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RestoreName"/> constructed from the provided ids.</returns>
        public static RestoreName FromProjectLocationRestorePlanRestore(string projectId, string locationId, string restorePlanId, string restoreId) =>
            new RestoreName(ResourceNameType.ProjectLocationRestorePlanRestore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restorePlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)), restoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(restoreId, nameof(restoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RestoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreId">The <c>Restore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RestoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string restorePlanId, string restoreId) =>
            FormatProjectLocationRestorePlanRestore(projectId, locationId, restorePlanId, restoreId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RestoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreId">The <c>Restore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RestoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}</c>.
        /// </returns>
        public static string FormatProjectLocationRestorePlanRestore(string projectId, string locationId, string restorePlanId, string restoreId) =>
            s_projectLocationRestorePlanRestore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)), gax::GaxPreconditions.CheckNotNullOrEmpty(restoreId, nameof(restoreId)));

        /// <summary>Parses the given resource name string into a new <see cref="RestoreName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="restoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RestoreName"/> if successful.</returns>
        public static RestoreName Parse(string restoreName) => Parse(restoreName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RestoreName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="restoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RestoreName"/> if successful.</returns>
        public static RestoreName Parse(string restoreName, bool allowUnparsed) =>
            TryParse(restoreName, allowUnparsed, out RestoreName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RestoreName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="restoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RestoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string restoreName, out RestoreName result) => TryParse(restoreName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RestoreName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="restoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RestoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string restoreName, bool allowUnparsed, out RestoreName result)
        {
            gax::GaxPreconditions.CheckNotNull(restoreName, nameof(restoreName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRestorePlanRestore.TryParseName(restoreName, out resourceName))
            {
                result = FromProjectLocationRestorePlanRestore(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(restoreName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RestoreName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string restoreId = null, string restorePlanId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RestoreId = restoreId;
            RestorePlanId = restorePlanId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RestoreName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}/restores/{restore}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreId">The <c>Restore</c> ID. Must not be <c>null</c> or empty.</param>
        public RestoreName(string projectId, string locationId, string restorePlanId, string restoreId) : this(ResourceNameType.ProjectLocationRestorePlanRestore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restorePlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)), restoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(restoreId, nameof(restoreId)))
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

        /// <summary>
        /// The <c>Restore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RestoreId { get; }

        /// <summary>
        /// The <c>RestorePlan</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RestorePlanId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRestorePlanRestore: return s_projectLocationRestorePlanRestore.Expand(ProjectId, LocationId, RestorePlanId, RestoreId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RestoreName);

        /// <inheritdoc/>
        public bool Equals(RestoreName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RestoreName a, RestoreName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RestoreName a, RestoreName b) => !(a == b);
    }

    public partial class Restore
    {
        /// <summary>
        /// <see cref="gcgv::RestoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::RestoreName RestoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::RestoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="BackupName"/>-typed view over the <see cref="Backup"/> resource name property.</summary>
        public BackupName BackupAsBackupName
        {
            get => string.IsNullOrEmpty(Backup) ? null : BackupName.Parse(Backup, allowUnparsed: true);
            set => Backup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Cluster"/> resource name property.
        /// </summary>
        public ClusterName ClusterAsClusterName
        {
            get => string.IsNullOrEmpty(Cluster) ? null : ClusterName.Parse(Cluster, allowUnparsed: true);
            set => Cluster = value?.ToString() ?? "";
        }
    }
}
