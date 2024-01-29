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
    /// <summary>Resource name for the <c>DeliveryVehicle</c> resource.</summary>
    public sealed partial class DeliveryVehicleName : gax::IResourceName, sys::IEquatable<DeliveryVehicleName>
    {
        /// <summary>The possible contents of <see cref="DeliveryVehicleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>providers/{provider}/deliveryVehicles/{vehicle}</c>.</summary>
            ProviderVehicle = 1,
        }

        private static gax::PathTemplate s_providerVehicle = new gax::PathTemplate("providers/{provider}/deliveryVehicles/{vehicle}");

        /// <summary>Creates a <see cref="DeliveryVehicleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeliveryVehicleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeliveryVehicleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeliveryVehicleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeliveryVehicleName"/> with the pattern
        /// <c>providers/{provider}/deliveryVehicles/{vehicle}</c>.
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vehicleId">The <c>Vehicle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DeliveryVehicleName"/> constructed from the provided ids.</returns>
        public static DeliveryVehicleName FromProviderVehicle(string providerId, string vehicleId) =>
            new DeliveryVehicleName(ResourceNameType.ProviderVehicle, providerId: gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), vehicleId: gax::GaxPreconditions.CheckNotNullOrEmpty(vehicleId, nameof(vehicleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeliveryVehicleName"/> with pattern
        /// <c>providers/{provider}/deliveryVehicles/{vehicle}</c>.
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vehicleId">The <c>Vehicle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeliveryVehicleName"/> with pattern
        /// <c>providers/{provider}/deliveryVehicles/{vehicle}</c>.
        /// </returns>
        public static string Format(string providerId, string vehicleId) => FormatProviderVehicle(providerId, vehicleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeliveryVehicleName"/> with pattern
        /// <c>providers/{provider}/deliveryVehicles/{vehicle}</c>.
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vehicleId">The <c>Vehicle</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeliveryVehicleName"/> with pattern
        /// <c>providers/{provider}/deliveryVehicles/{vehicle}</c>.
        /// </returns>
        public static string FormatProviderVehicle(string providerId, string vehicleId) =>
            s_providerVehicle.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(vehicleId, nameof(vehicleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeliveryVehicleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>providers/{provider}/deliveryVehicles/{vehicle}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="deliveryVehicleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeliveryVehicleName"/> if successful.</returns>
        public static DeliveryVehicleName Parse(string deliveryVehicleName) => Parse(deliveryVehicleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeliveryVehicleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>providers/{provider}/deliveryVehicles/{vehicle}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deliveryVehicleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DeliveryVehicleName"/> if successful.</returns>
        public static DeliveryVehicleName Parse(string deliveryVehicleName, bool allowUnparsed) =>
            TryParse(deliveryVehicleName, allowUnparsed, out DeliveryVehicleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeliveryVehicleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>providers/{provider}/deliveryVehicles/{vehicle}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="deliveryVehicleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeliveryVehicleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deliveryVehicleName, out DeliveryVehicleName result) =>
            TryParse(deliveryVehicleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeliveryVehicleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>providers/{provider}/deliveryVehicles/{vehicle}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deliveryVehicleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeliveryVehicleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deliveryVehicleName, bool allowUnparsed, out DeliveryVehicleName result)
        {
            gax::GaxPreconditions.CheckNotNull(deliveryVehicleName, nameof(deliveryVehicleName));
            gax::TemplatedResourceName resourceName;
            if (s_providerVehicle.TryParseName(deliveryVehicleName, out resourceName))
            {
                result = FromProviderVehicle(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(deliveryVehicleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DeliveryVehicleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string providerId = null, string vehicleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProviderId = providerId;
            VehicleId = vehicleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeliveryVehicleName"/> class from the component parts of pattern
        /// <c>providers/{provider}/deliveryVehicles/{vehicle}</c>
        /// </summary>
        /// <param name="providerId">The <c>Provider</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vehicleId">The <c>Vehicle</c> ID. Must not be <c>null</c> or empty.</param>
        public DeliveryVehicleName(string providerId, string vehicleId) : this(ResourceNameType.ProviderVehicle, providerId: gax::GaxPreconditions.CheckNotNullOrEmpty(providerId, nameof(providerId)), vehicleId: gax::GaxPreconditions.CheckNotNullOrEmpty(vehicleId, nameof(vehicleId)))
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
        /// The <c>Vehicle</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VehicleId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProviderVehicle: return s_providerVehicle.Expand(ProviderId, VehicleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DeliveryVehicleName);

        /// <inheritdoc/>
        public bool Equals(DeliveryVehicleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DeliveryVehicleName a, DeliveryVehicleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DeliveryVehicleName a, DeliveryVehicleName b) => !(a == b);
    }

    public partial class DeliveryVehicle
    {
        /// <summary>
        /// <see cref="gmfdv::DeliveryVehicleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmfdv::DeliveryVehicleName DeliveryVehicleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmfdv::DeliveryVehicleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
