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
using gcav = Google.Cloud.AIPlatform.V1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>ModelEvaluation</c> resource.</summary>
    public sealed partial class ModelEvaluationName : gax::IResourceName, sys::IEquatable<ModelEvaluationName>
    {
        /// <summary>The possible contents of <see cref="ModelEvaluationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}</c>.
            /// </summary>
            ProjectLocationModelEvaluation = 1,
        }

        private static gax::PathTemplate s_projectLocationModelEvaluation = new gax::PathTemplate("projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}");

        /// <summary>Creates a <see cref="ModelEvaluationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ModelEvaluationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ModelEvaluationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ModelEvaluationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ModelEvaluationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ModelEvaluationName"/> constructed from the provided ids.</returns>
        public static ModelEvaluationName FromProjectLocationModelEvaluation(string projectId, string locationId, string modelId, string evaluationId) =>
            new ModelEvaluationName(ResourceNameType.ProjectLocationModelEvaluation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelEvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ModelEvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string modelId, string evaluationId) =>
            FormatProjectLocationModelEvaluation(projectId, locationId, modelId, evaluationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelEvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ModelEvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}</c>.
        /// </returns>
        public static string FormatProjectLocationModelEvaluation(string projectId, string locationId, string modelId, string evaluationId) =>
            s_projectLocationModelEvaluation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ModelEvaluationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="modelEvaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ModelEvaluationName"/> if successful.</returns>
        public static ModelEvaluationName Parse(string modelEvaluationName) => Parse(modelEvaluationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ModelEvaluationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelEvaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ModelEvaluationName"/> if successful.</returns>
        public static ModelEvaluationName Parse(string modelEvaluationName, bool allowUnparsed) =>
            TryParse(modelEvaluationName, allowUnparsed, out ModelEvaluationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelEvaluationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="modelEvaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelEvaluationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelEvaluationName, out ModelEvaluationName result) =>
            TryParse(modelEvaluationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelEvaluationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelEvaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelEvaluationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelEvaluationName, bool allowUnparsed, out ModelEvaluationName result)
        {
            gax::GaxPreconditions.CheckNotNull(modelEvaluationName, nameof(modelEvaluationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationModelEvaluation.TryParseName(modelEvaluationName, out resourceName))
            {
                result = FromProjectLocationModelEvaluation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(modelEvaluationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ModelEvaluationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string evaluationId = null, string locationId = null, string modelId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EvaluationId = evaluationId;
            LocationId = locationId;
            ModelId = modelId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ModelEvaluationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        public ModelEvaluationName(string projectId, string locationId, string modelId, string evaluationId) : this(ResourceNameType.ProjectLocationModelEvaluation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)))
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
        /// The <c>Evaluation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EvaluationId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Model</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ModelId { get; }

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
                case ResourceNameType.ProjectLocationModelEvaluation: return s_projectLocationModelEvaluation.Expand(ProjectId, LocationId, ModelId, EvaluationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ModelEvaluationName);

        /// <inheritdoc/>
        public bool Equals(ModelEvaluationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ModelEvaluationName a, ModelEvaluationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ModelEvaluationName a, ModelEvaluationName b) => !(a == b);
    }

    public partial class ModelEvaluation
    {
        /// <summary>
        /// <see cref="gcav::ModelEvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ModelEvaluationName ModelEvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelEvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
