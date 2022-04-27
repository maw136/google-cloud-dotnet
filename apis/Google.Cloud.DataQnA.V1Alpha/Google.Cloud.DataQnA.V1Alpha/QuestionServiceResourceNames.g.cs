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
using gcdv = Google.Cloud.DataQnA.V1Alpha;

namespace Google.Cloud.DataQnA.V1Alpha
{
    public partial class GetQuestionRequest
    {
        /// <summary>
        /// <see cref="gcdv::QuestionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::QuestionName QuestionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::QuestionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateQuestionRequest
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

    public partial class GetUserFeedbackRequest
    {
        /// <summary>
        /// <see cref="gcdv::UserFeedbackName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::UserFeedbackName UserFeedbackName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::UserFeedbackName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
