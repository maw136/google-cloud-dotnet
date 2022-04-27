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
using gcdv = Google.Cloud.DocumentAI.V1Beta3;
using sys = System;

namespace Google.Cloud.DocumentAI.V1Beta3
{
    /// <summary>Resource name for the <c>ProcessorType</c> resource.</summary>
    public sealed partial class ProcessorTypeName : gax::IResourceName, sys::IEquatable<ProcessorTypeName>
    {
        /// <summary>The possible contents of <see cref="ProcessorTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/processorTypes/{processor_type}</c>
            /// .
            /// </summary>
            ProjectLocationProcessorType = 1,
        }

        private static gax::PathTemplate s_projectLocationProcessorType = new gax::PathTemplate("projects/{project}/locations/{location}/processorTypes/{processor_type}");

        /// <summary>Creates a <see cref="ProcessorTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProcessorTypeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProcessorTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProcessorTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProcessorTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/processorTypes/{processor_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorTypeId">The <c>ProcessorType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProcessorTypeName"/> constructed from the provided ids.</returns>
        public static ProcessorTypeName FromProjectLocationProcessorType(string projectId, string locationId, string processorTypeId) =>
            new ProcessorTypeName(ResourceNameType.ProjectLocationProcessorType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorTypeId, nameof(processorTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessorTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processorTypes/{processor_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorTypeId">The <c>ProcessorType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessorTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processorTypes/{processor_type}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string processorTypeId) =>
            FormatProjectLocationProcessorType(projectId, locationId, processorTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessorTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processorTypes/{processor_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorTypeId">The <c>ProcessorType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessorTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processorTypes/{processor_type}</c>.
        /// </returns>
        public static string FormatProjectLocationProcessorType(string projectId, string locationId, string processorTypeId) =>
            s_projectLocationProcessorType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processorTypeId, nameof(processorTypeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProcessorTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processorTypes/{processor_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="processorTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProcessorTypeName"/> if successful.</returns>
        public static ProcessorTypeName Parse(string processorTypeName) => Parse(processorTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProcessorTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processorTypes/{processor_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processorTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProcessorTypeName"/> if successful.</returns>
        public static ProcessorTypeName Parse(string processorTypeName, bool allowUnparsed) =>
            TryParse(processorTypeName, allowUnparsed, out ProcessorTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessorTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processorTypes/{processor_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="processorTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessorTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processorTypeName, out ProcessorTypeName result) =>
            TryParse(processorTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessorTypeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processorTypes/{processor_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processorTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessorTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processorTypeName, bool allowUnparsed, out ProcessorTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(processorTypeName, nameof(processorTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProcessorType.TryParseName(processorTypeName, out resourceName))
            {
                result = FromProjectLocationProcessorType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(processorTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProcessorTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string processorTypeId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProcessorTypeId = processorTypeId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProcessorTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/processorTypes/{processor_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorTypeId">The <c>ProcessorType</c> ID. Must not be <c>null</c> or empty.</param>
        public ProcessorTypeName(string projectId, string locationId, string processorTypeId) : this(ResourceNameType.ProjectLocationProcessorType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorTypeId, nameof(processorTypeId)))
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
        /// The <c>ProcessorType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProcessorTypeId { get; }

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
                case ResourceNameType.ProjectLocationProcessorType: return s_projectLocationProcessorType.Expand(ProjectId, LocationId, ProcessorTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProcessorTypeName);

        /// <inheritdoc/>
        public bool Equals(ProcessorTypeName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ProcessorTypeName a, ProcessorTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ProcessorTypeName a, ProcessorTypeName b) => !(a == b);
    }

    public partial class ProcessorType
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorTypeName ProcessorTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
