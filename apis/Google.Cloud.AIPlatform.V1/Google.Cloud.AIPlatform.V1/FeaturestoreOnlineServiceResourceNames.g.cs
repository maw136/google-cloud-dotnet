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

namespace Google.Cloud.AIPlatform.V1
{
    public partial class WriteFeatureValuesRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="EntityType"/> resource name property.
        /// </summary>
        public EntityTypeName EntityTypeAsEntityTypeName
        {
            get => string.IsNullOrEmpty(EntityType) ? null : EntityTypeName.Parse(EntityType, allowUnparsed: true);
            set => EntityType = value?.ToString() ?? "";
        }
    }

    public partial class ReadFeatureValuesRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="EntityType"/> resource name property.
        /// </summary>
        public EntityTypeName EntityTypeAsEntityTypeName
        {
            get => string.IsNullOrEmpty(EntityType) ? null : EntityTypeName.Parse(EntityType, allowUnparsed: true);
            set => EntityType = value?.ToString() ?? "";
        }
    }

    public partial class StreamingReadFeatureValuesRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="EntityType"/> resource name property.
        /// </summary>
        public EntityTypeName EntityTypeAsEntityTypeName
        {
            get => string.IsNullOrEmpty(EntityType) ? null : EntityTypeName.Parse(EntityType, allowUnparsed: true);
            set => EntityType = value?.ToString() ?? "";
        }
    }
}
