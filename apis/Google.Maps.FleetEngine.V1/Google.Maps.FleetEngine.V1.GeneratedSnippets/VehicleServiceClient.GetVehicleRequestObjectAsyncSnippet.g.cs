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
    // [START fleetengine_v1_generated_VehicleService_GetVehicle_async]
    using Google.Maps.FleetEngine.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedVehicleServiceClientSnippets
    {
        /// <summary>Snippet for GetVehicleAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task GetVehicleRequestObjectAsync()
        {
            // Create client
            VehicleServiceClient vehicleServiceClient = await VehicleServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetVehicleRequest request = new GetVehicleRequest
            {
                Header = new RequestHeader(),
                VehicleName = VehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
                CurrentRouteSegmentVersion = new Timestamp(),
                WaypointsVersion = new Timestamp(),
            };
            // Make the request
            Vehicle response = await vehicleServiceClient.GetVehicleAsync(request);
        }
    }
    // [END fleetengine_v1_generated_VehicleService_GetVehicle_async]
}
