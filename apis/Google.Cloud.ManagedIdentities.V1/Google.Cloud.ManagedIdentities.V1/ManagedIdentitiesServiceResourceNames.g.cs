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
using gagr = Google.Api.Gax.ResourceNames;
using gcmv = Google.Cloud.ManagedIdentities.V1;

namespace Google.Cloud.ManagedIdentities.V1
{
    public partial class CreateMicrosoftAdDomainRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ResetAdminPasswordRequest
    {
        /// <summary>
        /// <see cref="gcmv::DomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::DomainName DomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::DomainName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDomainsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDomainRequest
    {
        /// <summary>
        /// <see cref="gcmv::DomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::DomainName DomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::DomainName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDomainRequest
    {
        /// <summary>
        /// <see cref="gcmv::DomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::DomainName DomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::DomainName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AttachTrustRequest
    {
        /// <summary>
        /// <see cref="gcmv::DomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::DomainName DomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::DomainName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReconfigureTrustRequest
    {
        /// <summary>
        /// <see cref="gcmv::DomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::DomainName DomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::DomainName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DetachTrustRequest
    {
        /// <summary>
        /// <see cref="gcmv::DomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::DomainName DomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::DomainName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ValidateTrustRequest
    {
        /// <summary>
        /// <see cref="gcmv::DomainName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::DomainName DomainName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::DomainName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
