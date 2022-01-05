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

namespace Google.Cloud.DataCatalog.V1
{
    public partial class TableSpec
    {
        /// <summary>
        /// <see cref="EntryName"/>-typed view over the <see cref="GroupedEntry"/> resource name property.
        /// </summary>
        public EntryName GroupedEntryAsEntryName
        {
            get => string.IsNullOrEmpty(GroupedEntry) ? null : EntryName.Parse(GroupedEntry, allowUnparsed: true);
            set => GroupedEntry = value?.ToString() ?? "";
        }
    }

    public partial class BigQueryDateShardedSpec
    {
        /// <summary><see cref="EntryName"/>-typed view over the <see cref="Dataset"/> resource name property.</summary>
        public EntryName DatasetAsEntryName
        {
            get => string.IsNullOrEmpty(Dataset) ? null : EntryName.Parse(Dataset, allowUnparsed: true);
            set => Dataset = value?.ToString() ?? "";
        }
    }
}
