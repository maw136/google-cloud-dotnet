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
using gmfdv = Google.Maps.FleetEngine.Delivery.V1;
using sys = System;

namespace Google.Maps.FleetEngine.Delivery.V1
{
    /// <summary>Resource name for the <c>TaskTrackingInfo</c> resource.</summary>
    public sealed partial class TaskTrackingInfoName : gax::IResourceName, sys::IEquatable<TaskTrackingInfoName>
    {
        /// <summary>The possible contents of <see cref="TaskTrackingInfoName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>providers/{provider}/taskTrackingInfo/{tracking}</c>.</summary>
            ProviderTracking = 1,
        }

        private static gax::PathTemplate s_providerTracking = new gax::PathTemplate("providers/{provider}/taskTrackingInfo/{tracking}");

        /// <summary>Creates a <see cref="TaskTrackingInfoName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TaskTrackingInfoName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TaskTrackingInfoName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TaskTrackingInfoName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TaskTrackingInfoName"/> with the pattern
        /// <c>providers/{provider}/taskTrackingInfo/{tracking}</c>.
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trackingId">The <c>Tracking</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TaskTrackingInfoName"/> constructed from the provided ids.</returns>
        public static TaskTrackingInfoName FromProviderTracking(string providerId, string trackingId) =>
            new TaskTrackingInfoName(ResourceNameType.ProviderTracking, providerId: gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), trackingId: gax::GaxPreconditions.CheckNotNullOrEmpty(trackingId, nameof(trackingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaskTrackingInfoName"/> with pattern
        /// <c>providers/{provider}/taskTrackingInfo/{tracking}</c>.
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trackingId">The <c>Tracking</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaskTrackingInfoName"/> with pattern
        /// <c>providers/{provider}/taskTrackingInfo/{tracking}</c>.
        /// </returns>
        public static string Format(string providerId, string trackingId) => FormatProviderTracking(providerId, trackingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaskTrackingInfoName"/> with pattern
        /// <c>providers/{provider}/taskTrackingInfo/{tracking}</c>.
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trackingId">The <c>Tracking</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaskTrackingInfoName"/> with pattern
        /// <c>providers/{provider}/taskTrackingInfo/{tracking}</c>.
        /// </returns>
        public static string FormatProviderTracking(string providerId, string trackingId) =>
            s_providerTracking.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(trackingId, nameof(trackingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TaskTrackingInfoName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>providers/{provider}/taskTrackingInfo/{tracking}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="taskTrackingInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TaskTrackingInfoName"/> if successful.</returns>
        public static TaskTrackingInfoName Parse(string taskTrackingInfoName) => Parse(taskTrackingInfoName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TaskTrackingInfoName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>providers/{provider}/taskTrackingInfo/{tracking}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="taskTrackingInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TaskTrackingInfoName"/> if successful.</returns>
        public static TaskTrackingInfoName Parse(string taskTrackingInfoName, bool allowUnparsed) =>
            TryParse(taskTrackingInfoName, allowUnparsed, out TaskTrackingInfoName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TaskTrackingInfoName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>providers/{provider}/taskTrackingInfo/{tracking}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="taskTrackingInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TaskTrackingInfoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taskTrackingInfoName, out TaskTrackingInfoName result) =>
            TryParse(taskTrackingInfoName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TaskTrackingInfoName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>providers/{provider}/taskTrackingInfo/{tracking}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="taskTrackingInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TaskTrackingInfoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taskTrackingInfoName, bool allowUnparsed, out TaskTrackingInfoName result)
        {
            gax::GaxPreconditions.CheckNotNull(taskTrackingInfoName, nameof(taskTrackingInfoName));
            gax::TemplatedResourceName resourceName;
            if (s_providerTracking.TryParseName(taskTrackingInfoName, out resourceName))
            {
                result = FromProviderTracking(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(taskTrackingInfoName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TaskTrackingInfoName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string providerId = null, string trackingId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProviderId = providerId;
            TrackingId = trackingId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TaskTrackingInfoName"/> class from the component parts of pattern
        /// <c>providers/{provider}/taskTrackingInfo/{tracking}</c>
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trackingId">The <c>Tracking</c> ID. Must not be <c>null</c> or empty.</param>
        public TaskTrackingInfoName(string providerId, string trackingId) : this(ResourceNameType.ProviderTracking, providerId: gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), trackingId: gax::GaxPreconditions.CheckNotNullOrEmpty(trackingId, nameof(trackingId)))
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
        /// The <c>Provider</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProviderId { get; }

        /// <summary>
        /// The <c>Tracking</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TrackingId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProviderTracking: return s_providerTracking.Expand(ProviderId, TrackingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TaskTrackingInfoName);

        /// <inheritdoc/>
        public bool Equals(TaskTrackingInfoName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TaskTrackingInfoName a, TaskTrackingInfoName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TaskTrackingInfoName a, TaskTrackingInfoName b) => !(a == b);
    }

    public partial class TaskTrackingInfo
    {
        /// <summary>
        /// <see cref="gmfdv::TaskTrackingInfoName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmfdv::TaskTrackingInfoName TaskTrackingInfoName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmfdv::TaskTrackingInfoName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
