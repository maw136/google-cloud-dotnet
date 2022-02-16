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

namespace Google.Cloud.BigQuery.Reservation.V1.Snippets
{
    // [START bigqueryreservation_v1_generated_ReservationService_MoveAssignment_sync]
    using Google.Cloud.BigQuery.Reservation.V1;

    public sealed partial class GeneratedReservationServiceClientSnippets
    {
        /// <summary>Snippet for MoveAssignment</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void MoveAssignmentRequestObject()
        {
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            MoveAssignmentRequest request = new MoveAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                DestinationIdAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            Assignment response = reservationServiceClient.MoveAssignment(request);
        }
    }
    // [END bigqueryreservation_v1_generated_ReservationService_MoveAssignment_sync]
}
