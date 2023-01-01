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
using gagr = Google.Api.Gax.ResourceNames;
using gcrv = Google.Cloud.RecaptchaEnterprise.V1Beta1;
using sys = System;

namespace Google.Cloud.RecaptchaEnterprise.V1Beta1
{
    /// <summary>Resource name for the <c>Assessment</c> resource.</summary>
    public sealed partial class AssessmentName : gax::IResourceName, sys::IEquatable<AssessmentName>
    {
        /// <summary>The possible contents of <see cref="AssessmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/assessments/{assessment}</c>.</summary>
            ProjectAssessment = 1,
        }

        private static gax::PathTemplate s_projectAssessment = new gax::PathTemplate("projects/{project}/assessments/{assessment}");

        /// <summary>Creates a <see cref="AssessmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssessmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssessmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssessmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssessmentName"/> with the pattern <c>projects/{project}/assessments/{assessment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assessmentId">The <c>Assessment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssessmentName"/> constructed from the provided ids.</returns>
        public static AssessmentName FromProjectAssessment(string projectId, string assessmentId) =>
            new AssessmentName(ResourceNameType.ProjectAssessment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), assessmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(assessmentId, nameof(assessmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssessmentName"/> with pattern
        /// <c>projects/{project}/assessments/{assessment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assessmentId">The <c>Assessment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssessmentName"/> with pattern
        /// <c>projects/{project}/assessments/{assessment}</c>.
        /// </returns>
        public static string Format(string projectId, string assessmentId) => FormatProjectAssessment(projectId, assessmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssessmentName"/> with pattern
        /// <c>projects/{project}/assessments/{assessment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assessmentId">The <c>Assessment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssessmentName"/> with pattern
        /// <c>projects/{project}/assessments/{assessment}</c>.
        /// </returns>
        public static string FormatProjectAssessment(string projectId, string assessmentId) =>
            s_projectAssessment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assessmentId, nameof(assessmentId)));

        /// <summary>Parses the given resource name string into a new <see cref="AssessmentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/assessments/{assessment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assessmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssessmentName"/> if successful.</returns>
        public static AssessmentName Parse(string assessmentName) => Parse(assessmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssessmentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/assessments/{assessment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assessmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssessmentName"/> if successful.</returns>
        public static AssessmentName Parse(string assessmentName, bool allowUnparsed) =>
            TryParse(assessmentName, allowUnparsed, out AssessmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssessmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/assessments/{assessment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assessmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssessmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assessmentName, out AssessmentName result) =>
            TryParse(assessmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssessmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/assessments/{assessment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assessmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssessmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assessmentName, bool allowUnparsed, out AssessmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(assessmentName, nameof(assessmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectAssessment.TryParseName(assessmentName, out resourceName))
            {
                result = FromProjectAssessment(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assessmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AssessmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assessmentId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssessmentId = assessmentId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssessmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/assessments/{assessment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assessmentId">The <c>Assessment</c> ID. Must not be <c>null</c> or empty.</param>
        public AssessmentName(string projectId, string assessmentId) : this(ResourceNameType.ProjectAssessment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), assessmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(assessmentId, nameof(assessmentId)))
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
        /// The <c>Assessment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssessmentId { get; }

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
                case ResourceNameType.ProjectAssessment: return s_projectAssessment.Expand(ProjectId, AssessmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssessmentName);

        /// <inheritdoc/>
        public bool Equals(AssessmentName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AssessmentName a, AssessmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AssessmentName a, AssessmentName b) => !(a == b);
    }

    public partial class CreateAssessmentRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AnnotateAssessmentRequest
    {
        /// <summary>
        /// <see cref="gcrv::AssessmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::AssessmentName AssessmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::AssessmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Assessment
    {
        /// <summary>
        /// <see cref="gcrv::AssessmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::AssessmentName AssessmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::AssessmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
