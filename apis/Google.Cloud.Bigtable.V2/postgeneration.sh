#!/bin/bash

set -e

# Undo the changes in googleapis
# (Do this first so that if we have any failures in the remaining steps)
git -C $GOOGLEAPIS checkout google/bigtable/v2/bigtable.proto
git -C $GOOGLEAPIS checkout google/bigtable/v2/bigtable_grpc_service_config.json
git -C $GOOGLEAPIS checkout google/bigtable/v2/bigtable_v2.yaml

# Apply changes required due to the service renaming
sed -i s/BigtableServiceApi.BigtableServiceApiClient/Bigtable.BigtableClient/g Google.Cloud.Bigtable.V2/BigtableServiceApiClient.g.cs
sed -i s/BigtableServiceApi.Descriptor/Bigtable.Descriptor/g Google.Cloud.Bigtable.V2/BigtableServiceApiClient.g.cs

# Fix up the metadata
sed -i 's/"BigtableServiceApi": {/"Bigtable": {/g' gapic_metadata.json

# Fix up the snippet metadata (carefully)
sed -i 's/v2.BigtableServiceApi/v2.Bigtable/g' Google.Cloud.Bigtable.V2.GeneratedSnippets/snippet_metadata_google.bigtable.v2.json
sed -i 's/generated_BigtableServiceApi/generated_Bigtable/g' Google.Cloud.Bigtable.V2.GeneratedSnippets/snippet_metadata_google.bigtable.v2.json
sed -i 's/"shortName": "BigtableServiceApi"/"shortName": "Bigtable"/g' Google.Cloud.Bigtable.V2.GeneratedSnippets/snippet_metadata_google.bigtable.v2.json

# Generate BigtableClient
dotnet run --project Google.Cloud.Bigtable.V2.GenerateClient \
  Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.csproj \
  BigtableServiceApiClient \
  BigtableClient
