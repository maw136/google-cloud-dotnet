﻿// Copyright 2021 Google LLC
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

using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>CreateModelExtractJob</c> operations.
    /// </summary>
    public sealed class CreateModelExtractJobOptions : JobCreationOptions
    {
        /// <summary>
        /// The model format to use for output. If this is unspecified,
        /// the default is to create a Tensorflow SavedModel.
        /// </summary>
        public ModelFormat? DestinationFormat { get; set; }

        internal void ModifyRequest(JobConfigurationExtract extract)
        {
            if (DestinationFormat != null)
            {
                extract.DestinationFormat = EnumMap.ToApiValue(DestinationFormat.Value);
            }
        }
    }
}
