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
using gctv = Google.Cloud.Tasks.V2Beta3;
using sys = System;

namespace Google.Cloud.Tasks.V2Beta3
{
    /// <summary>Resource name for the <c>Queue</c> resource.</summary>
    public sealed partial class QueueName : gax::IResourceName, sys::IEquatable<QueueName>
    {
        /// <summary>The possible contents of <see cref="QueueName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/queues/{queue}</c>.
            /// </summary>
            ProjectLocationQueue = 1,
        }

        private static gax::PathTemplate s_projectLocationQueue = new gax::PathTemplate("projects/{project}/locations/{location}/queues/{queue}");

        /// <summary>Creates a <see cref="QueueName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="QueueName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static QueueName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new QueueName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="QueueName"/> with the pattern <c>projects/{project}/locations/{location}/queues/{queue}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queueId">The <c>Queue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QueueName"/> constructed from the provided ids.</returns>
        public static QueueName FromProjectLocationQueue(string projectId, string locationId, string queueId) =>
            new QueueName(ResourceNameType.ProjectLocationQueue, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), queueId: gax::GaxPreconditions.CheckNotNullOrEmpty(queueId, nameof(queueId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QueueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/queues/{queue}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queueId">The <c>Queue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QueueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/queues/{queue}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string queueId) =>
            FormatProjectLocationQueue(projectId, locationId, queueId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QueueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/queues/{queue}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queueId">The <c>Queue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QueueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/queues/{queue}</c>.
        /// </returns>
        public static string FormatProjectLocationQueue(string projectId, string locationId, string queueId) =>
            s_projectLocationQueue.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(queueId, nameof(queueId)));

        /// <summary>Parses the given resource name string into a new <see cref="QueueName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/queues/{queue}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="queueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QueueName"/> if successful.</returns>
        public static QueueName Parse(string queueName) => Parse(queueName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QueueName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/queues/{queue}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="queueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="QueueName"/> if successful.</returns>
        public static QueueName Parse(string queueName, bool allowUnparsed) =>
            TryParse(queueName, allowUnparsed, out QueueName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QueueName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/queues/{queue}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="queueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QueueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string queueName, out QueueName result) => TryParse(queueName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QueueName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/queues/{queue}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="queueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QueueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string queueName, bool allowUnparsed, out QueueName result)
        {
            gax::GaxPreconditions.CheckNotNull(queueName, nameof(queueName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationQueue.TryParseName(queueName, out resourceName))
            {
                result = FromProjectLocationQueue(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(queueName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private QueueName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string queueId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            QueueId = queueId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="QueueName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/queues/{queue}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queueId">The <c>Queue</c> ID. Must not be <c>null</c> or empty.</param>
        public QueueName(string projectId, string locationId, string queueId) : this(ResourceNameType.ProjectLocationQueue, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), queueId: gax::GaxPreconditions.CheckNotNullOrEmpty(queueId, nameof(queueId)))
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
        /// The <c>Queue</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string QueueId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationQueue: return s_projectLocationQueue.Expand(ProjectId, LocationId, QueueId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QueueName);

        /// <inheritdoc/>
        public bool Equals(QueueName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(QueueName a, QueueName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(QueueName a, QueueName b) => !(a == b);
    }

    public partial class Queue
    {
        /// <summary>
        /// <see cref="gctv::QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::QueueName QueueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::QueueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
