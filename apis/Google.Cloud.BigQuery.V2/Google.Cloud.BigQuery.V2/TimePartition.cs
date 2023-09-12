﻿// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Bigquery.v2.Data;
using System;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Convenience methods for creating <see cref="TimePartitioning"/>.
    /// </summary>
    public static class TimePartition
    {
        /// <summary>
        /// Returns a daily partitioning scheme with an optional per-partition expiration.
        /// </summary>
        /// <param name="expiration">The expiration duration for each partition, if any.</param>
        /// <returns>A <see cref="TimePartitioning"/> representing a daily partitioning.</returns>
        public static TimePartitioning CreateDailyPartitioning(TimeSpan? expiration) =>
            CreateDailyPartitioning(expiration, null);

        /// <summary>
        /// Returns a daily partitioning scheme with an optional per-partition expiration, and a field name.
        /// </summary>
        /// <param name="expiration">The expiration duration for each partition, if any.</param>
        /// <param name="field">The field name to partition by, if any. If this is null, the table will be
        /// partitioned by a pseudo-column called _PARTITIONTIME.</param>
        /// <returns>A <see cref="TimePartitioning"/> representing a daily partitioning.</returns>
        public static TimePartitioning CreateDailyPartitioning(TimeSpan? expiration, string field)
        {
            var ret = new TimePartitioning { Type = "DAY", Field = field };
            if (expiration != null)
            {
                ret.ExpirationMs = (long)expiration.Value.TotalMilliseconds;
            }
            return ret;
        }
    }
}
