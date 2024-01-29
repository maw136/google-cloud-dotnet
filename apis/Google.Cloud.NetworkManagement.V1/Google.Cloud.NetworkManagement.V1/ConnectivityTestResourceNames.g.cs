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
using gcnv = Google.Cloud.NetworkManagement.V1;
using sys = System;

namespace Google.Cloud.NetworkManagement.V1
{
    /// <summary>Resource name for the <c>ConnectivityTest</c> resource.</summary>
    public sealed partial class ConnectivityTestName : gax::IResourceName, sys::IEquatable<ConnectivityTestName>
    {
        /// <summary>The possible contents of <see cref="ConnectivityTestName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/global/connectivityTests/{test}</c>.
            /// </summary>
            ProjectTest = 1,
        }

        private static gax::PathTemplate s_projectTest = new gax::PathTemplate("projects/{project}/locations/global/connectivityTests/{test}");

        /// <summary>Creates a <see cref="ConnectivityTestName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConnectivityTestName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConnectivityTestName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConnectivityTestName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConnectivityTestName"/> with the pattern
        /// <c>projects/{project}/locations/global/connectivityTests/{test}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testId">The <c>Test</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConnectivityTestName"/> constructed from the provided ids.</returns>
        public static ConnectivityTestName FromProjectTest(string projectId, string testId) =>
            new ConnectivityTestName(ResourceNameType.ProjectTest, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), testId: gax::GaxPreconditions.CheckNotNullOrEmpty(testId, nameof(testId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectivityTestName"/> with pattern
        /// <c>projects/{project}/locations/global/connectivityTests/{test}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testId">The <c>Test</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectivityTestName"/> with pattern
        /// <c>projects/{project}/locations/global/connectivityTests/{test}</c>.
        /// </returns>
        public static string Format(string projectId, string testId) => FormatProjectTest(projectId, testId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectivityTestName"/> with pattern
        /// <c>projects/{project}/locations/global/connectivityTests/{test}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testId">The <c>Test</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectivityTestName"/> with pattern
        /// <c>projects/{project}/locations/global/connectivityTests/{test}</c>.
        /// </returns>
        public static string FormatProjectTest(string projectId, string testId) =>
            s_projectTest.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(testId, nameof(testId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConnectivityTestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/global/connectivityTests/{test}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="connectivityTestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConnectivityTestName"/> if successful.</returns>
        public static ConnectivityTestName Parse(string connectivityTestName) => Parse(connectivityTestName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConnectivityTestName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/global/connectivityTests/{test}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectivityTestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConnectivityTestName"/> if successful.</returns>
        public static ConnectivityTestName Parse(string connectivityTestName, bool allowUnparsed) =>
            TryParse(connectivityTestName, allowUnparsed, out ConnectivityTestName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectivityTestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/global/connectivityTests/{test}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="connectivityTestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectivityTestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectivityTestName, out ConnectivityTestName result) =>
            TryParse(connectivityTestName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectivityTestName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/global/connectivityTests/{test}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectivityTestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectivityTestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectivityTestName, bool allowUnparsed, out ConnectivityTestName result)
        {
            gax::GaxPreconditions.CheckNotNull(connectivityTestName, nameof(connectivityTestName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTest.TryParseName(connectivityTestName, out resourceName))
            {
                result = FromProjectTest(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(connectivityTestName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConnectivityTestName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string testId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            TestId = testId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConnectivityTestName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/global/connectivityTests/{test}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testId">The <c>Test</c> ID. Must not be <c>null</c> or empty.</param>
        public ConnectivityTestName(string projectId, string testId) : this(ResourceNameType.ProjectTest, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), testId: gax::GaxPreconditions.CheckNotNullOrEmpty(testId, nameof(testId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Test</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TestId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTest: return s_projectTest.Expand(ProjectId, TestId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConnectivityTestName);

        /// <inheritdoc/>
        public bool Equals(ConnectivityTestName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConnectivityTestName a, ConnectivityTestName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConnectivityTestName a, ConnectivityTestName b) => !(a == b);
    }

    public partial class ConnectivityTest
    {
        /// <summary>
        /// <see cref="gcnv::ConnectivityTestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ConnectivityTestName ConnectivityTestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ConnectivityTestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
