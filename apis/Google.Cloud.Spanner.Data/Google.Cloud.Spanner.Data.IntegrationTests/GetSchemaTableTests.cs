// Copyright 2018 Google LLC
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

using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(AllTypesTableFixture))]
    [CommonTestDiagnostics]
    public class GetSchemaTableTests
    {
        private readonly AllTypesTableFixture _fixture;

        // On emulator, the types defined in SchemaTestUnsupportedData are skipped from tests.
        // The table also contains the `K` column that is the primary key.
        internal int ExpectedRowCountOnEmulator => SchemaTestData.Count() + 1;

        // On production, the types defined in both SchemaTestUnsupportedData and SchemaTestData are executed.
        // The table also contains the `K` column that is the primary key.
        internal int ExpectedRowCountOnProduction => SchemaTestUnsupportedData.Count() + SchemaTestData.Count() + 1;

        public GetSchemaTableTests(AllTypesTableFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task GetSchemaTable_Default_ReturnsNull()
        {
            using (var connection = _fixture.GetConnection())
            {
                var command = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName}");
                using (var reader = await command.ExecuteReaderAsync())
                {
                    Assert.Null(reader.GetSchemaTable());
                }
            }
        }

        // TODO: xUnit v3 supports traits for DataAttributes. Use that instead of Skip when we migrate.
        [SkippableTheory]
        [MemberData(nameof(SchemaTestData))]
        [MemberData(nameof(SchemaTestUnsupportedData))]
        public async Task GetSchemaTable_WithFlagEnabled_ReturnsSchema(string columnName, System.Type type, SpannerDbType spannerDbType)
        {
            Skip.If(_fixture.RunningOnEmulator && (SpannerDbType.Json.Equals(spannerDbType) || SpannerDbType.ArrayOf(SpannerDbType.Json).Equals(spannerDbType)), "The emulator does not support the JSON type");
            string selectQuery = $"SELECT {columnName} FROM {_fixture.TableName}";
            await GetSchemaTable_WithFlagEnabled_ReturnsSchema_Impl(columnName, type, spannerDbType, _fixture.ConnectionString, selectQuery);
        }

        // These SpannerDbTypes are not supported on emulator.
        public static TheoryData<string, System.Type, SpannerDbType> SchemaTestUnsupportedData { get; } =
            new TheoryData<string, System.Type, SpannerDbType>
            {
                { "JsonValue", typeof(string), SpannerDbType.Json },
                { "JsonArrayValue", typeof(List<string>), SpannerDbType.ArrayOf(SpannerDbType.Json) }
            };

        // These SpannerDbTypes are supported on emulator.
        public static TheoryData<string, System.Type, SpannerDbType> SchemaTestData { get; } =
            new TheoryData<string, System.Type, SpannerDbType>
            {
                // Base types.
                { "BoolValue", typeof(bool), SpannerDbType.Bool },
                { "Int64Value", typeof(long), SpannerDbType.Int64 },
                { "Float64Value", typeof(double), SpannerDbType.Float64 },
                { "NumericValue", typeof(SpannerNumeric), SpannerDbType.Numeric },
                { "StringValue", typeof(string), SpannerDbType.String },
                { "BytesValue", typeof(byte[]), SpannerDbType.Bytes },
                { "TimestampValue", typeof(DateTime), SpannerDbType.Timestamp },
                { "DateValue", typeof(DateTime), SpannerDbType.Date },
                // Array types.
                { "BoolArrayValue", typeof(List<bool>), SpannerDbType.ArrayOf(SpannerDbType.Bool) },
                { "Int64ArrayValue", typeof(List<long>), SpannerDbType.ArrayOf(SpannerDbType.Int64) },
                { "Float64ArrayValue", typeof(List<double>), SpannerDbType.ArrayOf(SpannerDbType.Float64) },
                { "NumericArrayValue", typeof(List<SpannerNumeric>), SpannerDbType.ArrayOf(SpannerDbType.Numeric) },
                { "StringArrayValue", typeof(List<string>), SpannerDbType.ArrayOf(SpannerDbType.String) },
                { "Base64ArrayValue", typeof(List<byte[]>), SpannerDbType.ArrayOf(SpannerDbType.Bytes) },
                { "BytesArrayValue", typeof(List<byte[]>), SpannerDbType.ArrayOf(SpannerDbType.Bytes) },
                { "TimestampArrayValue", typeof(List<DateTime>), SpannerDbType.ArrayOf(SpannerDbType.Timestamp) },
                { "DateArrayValue", typeof(List<DateTime>), SpannerDbType.ArrayOf(SpannerDbType.Date) }
            };

        internal static async Task GetSchemaTable_WithFlagEnabled_ReturnsSchema_Impl(string columnName, System.Type type, SpannerDbType spannerDbType, string connectionString, string selectQuery)
        {
            using var connection = new SpannerConnection($"{connectionString};EnableGetSchemaTable=true");
            var command = connection.CreateSelectCommand(selectQuery);
            using var reader = await command.ExecuteReaderAsync();
            var table = reader.GetSchemaTable();
            Assert.Equal(1, table.Rows.Count);

            var row = table.Rows[0];
            Assert.Equal(columnName, (string) row["ColumnName"]);
            Assert.Equal(0, (int) row["ColumnOrdinal"]);
            Assert.Equal(type, row["DataType"]);
            Assert.Equal(spannerDbType, (SpannerDbType) row["ProviderType"]);
            // These fields are (currently) not filled as Spanner does not provided enough
            // information to fill them.
            Assert.True(row.IsNull("ColumnSize"));
            Assert.True(row.IsNull("NumericPrecision"));
            Assert.True(row.IsNull("NumericScale"));
        }

        [Fact]
        public async Task GetSchemaTable_WithFlagEnabled_ReturnsColumnOrdinals()
        {
            using (var connection = new SpannerConnection($"{_fixture.ConnectionString};EnableGetSchemaTable=true"))
            {
                var command = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName}");
                using (var reader = await command.ExecuteReaderAsync())
                {
                    var table = reader.GetSchemaTable();
                    var expectedRowCount = _fixture.RunningOnEmulator ? ExpectedRowCountOnEmulator : ExpectedRowCountOnProduction;
                    Assert.Equal(expectedRowCount, table.Rows.Count);
                    for (var ordinal = 1; ordinal < expectedRowCount; ordinal++)
                    {
                        var row = table.Rows[ordinal];
                        Assert.Equal(ordinal, (int) row["ColumnOrdinal"]);
                    }
                }
            }
        }
    }
}
