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
    // [START fleetengine_v1_generated_TripService_GetTrip_sync]
    using Google.Maps.FleetEngine.V1;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedTripServiceClientSnippets
    {
        /// <summary>Snippet for GetTrip</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void GetTripRequestObject()
        {
            // Create client
            TripServiceClient tripServiceClient = TripServiceClient.Create();
            // Initialize request argument(s)
            GetTripRequest request = new GetTripRequest
            {
                Header = new RequestHeader(),
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                CurrentRouteSegmentVersion = new Timestamp(),
                RemainingWaypointsVersion = new Timestamp(),
                RouteFormatType = PolylineFormatType.UnknownFormatType,
                CurrentRouteSegmentTrafficVersion = new Timestamp(),
                RemainingWaypointsRouteVersion = new Timestamp(),
                View = TripView.Unspecified,
            };
            // Make the request
            Trip response = tripServiceClient.GetTrip(request);
        }
    }
    // [END fleetengine_v1_generated_TripService_GetTrip_sync]
}
