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

namespace GoogleCSharpSnippets
{
    // [START mapsplatformdatasets_v1alpha_generated_MapsPlatformDatasetsV1Alpha_UpdateDatasetMetadata_async_flattened]
    using Google.Maps.MapsPlatformDatasets.V1Alpha;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedMapsPlatformDatasetsV1AlphaClientSnippets
    {
        /// <summary>Snippet for UpdateDatasetMetadataAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateDatasetMetadataAsync()
        {
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Dataset response = await mapsPlatformDatasetsV1AlphaClient.UpdateDatasetMetadataAsync(dataset, updateMask);
        }
    }
    // [END mapsplatformdatasets_v1alpha_generated_MapsPlatformDatasetsV1Alpha_UpdateDatasetMetadata_async_flattened]
}
