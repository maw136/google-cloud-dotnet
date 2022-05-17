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
using gcgv = Google.Cloud.GkeBackup.V1;
using sys = System;

namespace Google.Cloud.GkeBackup.V1
{
    /// <summary>Resource name for the <c>RestorePlan</c> resource.</summary>
    public sealed partial class RestorePlanName : gax::IResourceName, sys::IEquatable<RestorePlanName>
    {
        /// <summary>The possible contents of <see cref="RestorePlanName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}</c>.
            /// </summary>
            ProjectLocationRestorePlan = 1,
        }

        private static gax::PathTemplate s_projectLocationRestorePlan = new gax::PathTemplate("projects/{project}/locations/{location}/restorePlans/{restore_plan}");

        /// <summary>Creates a <see cref="RestorePlanName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RestorePlanName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RestorePlanName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RestorePlanName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RestorePlanName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RestorePlanName"/> constructed from the provided ids.</returns>
        public static RestorePlanName FromProjectLocationRestorePlan(string projectId, string locationId, string restorePlanId) =>
            new RestorePlanName(ResourceNameType.ProjectLocationRestorePlan, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restorePlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RestorePlanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RestorePlanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string restorePlanId) =>
            FormatProjectLocationRestorePlan(projectId, locationId, restorePlanId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RestorePlanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RestorePlanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}</c>.
        /// </returns>
        public static string FormatProjectLocationRestorePlan(string projectId, string locationId, string restorePlanId) =>
            s_projectLocationRestorePlan.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)));

        /// <summary>Parses the given resource name string into a new <see cref="RestorePlanName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/restorePlans/{restore_plan}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="restorePlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RestorePlanName"/> if successful.</returns>
        public static RestorePlanName Parse(string restorePlanName) => Parse(restorePlanName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RestorePlanName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/restorePlans/{restore_plan}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="restorePlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RestorePlanName"/> if successful.</returns>
        public static RestorePlanName Parse(string restorePlanName, bool allowUnparsed) =>
            TryParse(restorePlanName, allowUnparsed, out RestorePlanName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RestorePlanName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/restorePlans/{restore_plan}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="restorePlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RestorePlanName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string restorePlanName, out RestorePlanName result) =>
            TryParse(restorePlanName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RestorePlanName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/restorePlans/{restore_plan}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="restorePlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RestorePlanName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string restorePlanName, bool allowUnparsed, out RestorePlanName result)
        {
            gax::GaxPreconditions.CheckNotNull(restorePlanName, nameof(restorePlanName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRestorePlan.TryParseName(restorePlanName, out resourceName))
            {
                result = FromProjectLocationRestorePlan(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(restorePlanName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RestorePlanName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string restorePlanId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RestorePlanId = restorePlanId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RestorePlanName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/restorePlans/{restore_plan}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanId">The <c>RestorePlan</c> ID. Must not be <c>null</c> or empty.</param>
        public RestorePlanName(string projectId, string locationId, string restorePlanId) : this(ResourceNameType.ProjectLocationRestorePlan, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restorePlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)))
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
                case ResourceNameType.ProjectLocationRestorePlan: return s_projectLocationRestorePlan.Expand(ProjectId, LocationId, RestorePlanId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RestorePlanName);

        /// <inheritdoc/>
        public bool Equals(RestorePlanName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RestorePlanName a, RestorePlanName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RestorePlanName a, RestorePlanName b) => !(a == b);
    }

    public partial class RestorePlan
    {
        /// <summary>
        /// <see cref="gcgv::RestorePlanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::RestorePlanName RestorePlanName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::RestorePlanName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BackupPlanName"/>-typed view over the <see cref="BackupPlan"/> resource name property.
        /// </summary>
        public BackupPlanName BackupPlanAsBackupPlanName
        {
            get => string.IsNullOrEmpty(BackupPlan) ? null : BackupPlanName.Parse(BackupPlan, allowUnparsed: true);
            set => BackupPlan = value?.ToString() ?? "";
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
