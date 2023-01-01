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

namespace Google.Cloud.BigQuery.Reservation.V1.Snippets
{
    // [START bigqueryreservation_v1_generated_ReservationService_DeleteCapacityCommitment_sync]
    using Google.Cloud.BigQuery.Reservation.V1;

    public sealed partial class GeneratedReservationServiceClientSnippets
    {
        /// <summary>Snippet for DeleteCapacityCommitment</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void DeleteCapacityCommitmentRequestObject()
        {
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            DeleteCapacityCommitmentRequest request = new DeleteCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                Force = false,
            };
            // Make the request
            reservationServiceClient.DeleteCapacityCommitment(request);
        }
    }
    // [END bigqueryreservation_v1_generated_ReservationService_DeleteCapacityCommitment_sync]
}
