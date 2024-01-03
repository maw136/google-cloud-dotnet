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
using gcsv = Google.Cloud.ServiceUsage.V1;
using sys = System;

namespace Google.Cloud.ServiceUsage.V1
{
    /// <summary>Resource name for the <c>Service</c> resource.</summary>
    public sealed partial class ServiceName : gax::IResourceName, sys::IEquatable<ServiceName>
    {
        /// <summary>The possible contents of <see cref="ServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/services/{service}</c>.</summary>
            ProjectService = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/services/{service}</c>.</summary>
            FolderService = 2,

            /// <summary>A resource name with pattern <c>organizations/{organization}/services/{service}</c>.</summary>
            OrganizationService = 3,
        }

        private static gax::PathTemplate s_projectService = new gax::PathTemplate("projects/{project}/services/{service}");

        private static gax::PathTemplate s_folderService = new gax::PathTemplate("folders/{folder}/services/{service}");

        private static gax::PathTemplate s_organizationService = new gax::PathTemplate("organizations/{organization}/services/{service}");

        /// <summary>Creates a <see cref="ServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceName"/> with the pattern <c>projects/{project}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceName"/> constructed from the provided ids.</returns>
        public static ServiceName FromProjectService(string projectId, string serviceId) =>
            new ServiceName(ResourceNameType.ProjectService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Creates a <see cref="ServiceName"/> with the pattern <c>folders/{folder}/services/{service}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceName"/> constructed from the provided ids.</returns>
        public static ServiceName FromFolderService(string folderId, string serviceId) =>
            new ServiceName(ResourceNameType.FolderService, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Creates a <see cref="ServiceName"/> with the pattern <c>organizations/{organization}/services/{service}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceName"/> constructed from the provided ids.</returns>
        public static ServiceName FromOrganizationService(string organizationId, string serviceId) =>
            new ServiceName(ResourceNameType.OrganizationService, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/services/{service}</c>.
        /// </returns>
        public static string Format(string projectId, string serviceId) => FormatProjectService(projectId, serviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/services/{service}</c>.
        /// </returns>
        public static string FormatProjectService(string projectId, string serviceId) =>
            s_projectService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>folders/{folder}/services/{service}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>folders/{folder}/services/{service}</c>.
        /// </returns>
        public static string FormatFolderService(string folderId, string serviceId) =>
            s_folderService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>organizations/{organization}/services/{service}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>organizations/{organization}/services/{service}</c>.
        /// </returns>
        public static string FormatOrganizationService(string organizationId, string serviceId) =>
            s_organizationService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>Parses the given resource name string into a new <see cref="ServiceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/services/{service}</c></description></item>
        /// <item><description><c>folders/{folder}/services/{service}</c></description></item>
        /// <item><description><c>organizations/{organization}/services/{service}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName) => Parse(serviceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/services/{service}</c></description></item>
        /// <item><description><c>folders/{folder}/services/{service}</c></description></item>
        /// <item><description><c>organizations/{organization}/services/{service}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName, bool allowUnparsed) =>
            TryParse(serviceName, allowUnparsed, out ServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/services/{service}</c></description></item>
        /// <item><description><c>folders/{folder}/services/{service}</c></description></item>
        /// <item><description><c>organizations/{organization}/services/{service}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, out ServiceName result) => TryParse(serviceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/services/{service}</c></description></item>
        /// <item><description><c>folders/{folder}/services/{service}</c></description></item>
        /// <item><description><c>organizations/{organization}/services/{service}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, bool allowUnparsed, out ServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectService.TryParseName(serviceName, out resourceName))
            {
                result = FromProjectService(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderService.TryParseName(serviceName, out resourceName))
            {
                result = FromFolderService(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationService.TryParseName(serviceName, out resourceName))
            {
                result = FromOrganizationService(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string organizationId = null, string projectId = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceName"/> class from the component parts of pattern
        /// <c>projects/{project}/services/{service}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceName(string projectId, string serviceId) : this(ResourceNameType.ProjectService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Service</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ServiceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectService: return s_projectService.Expand(ProjectId, ServiceId);
                case ResourceNameType.FolderService: return s_folderService.Expand(FolderId, ServiceId);
                case ResourceNameType.OrganizationService: return s_organizationService.Expand(OrganizationId, ServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceName);

        /// <inheritdoc/>
        public bool Equals(ServiceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ServiceName a, ServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ServiceName a, ServiceName b) => !(a == b);
    }

    public partial class Service
    {
        /// <summary>
        /// <see cref="gcsv::ServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::ServiceName ServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::ServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
