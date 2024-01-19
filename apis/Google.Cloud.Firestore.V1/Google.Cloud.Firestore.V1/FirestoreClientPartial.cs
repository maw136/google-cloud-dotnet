// Copyright 2019, Google Inc. All rights reserved.
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using System;

namespace Google.Cloud.Firestore.V1
{
    // Partial classes to expose FirestoreSettings
    public partial class FirestoreClient
    {
        /// <summary>
        /// Returns the effective <see cref="CallSettings"/> used for each API call.
        /// This can be used to create a modified instance of <see cref="CallSettings"/> to pass
        /// for a single API request.
        /// </summary>
        public virtual FirestoreSettings Settings { get; protected set; }
    }

    public partial class FirestoreClientImpl
    {
        partial void OnConstruction(Firestore.FirestoreClient grpcClient, FirestoreSettings effectiveSettings, ClientHelper clientHelper)
        {
            Settings = effectiveSettings;
        }
    }

    // Support for FirestoreDbBuilder.
    public sealed partial class FirestoreClientBuilder : ClientBuilderBase<FirestoreClient>
    {
        /// <summary>
        /// Creates a <see cref="FirestoreClientBuilder"/> by copying common settings from another builder.
        /// This method is intended for use in Google.Cloud.Firestore with FirestoreDbBuilder. It will
        /// work in other scenarios, but is usually not necessary.
        /// </summary>
        /// <typeparam name="T">The client type of the builder.</typeparam>
        /// <param name="builder">The builder to copy settings from. Must not be null.</param>
        /// <returns>A FirestoreClientBuilder with common settings from <paramref name="builder"/>.</returns>
        public static FirestoreClientBuilder FromOtherBuilder<T>(ClientBuilderBase<T> builder)
        {
            GaxPreconditions.CheckNotNull(builder, nameof(builder));
            var ret = new FirestoreClientBuilder();
            ret.CopyCommonSettings(builder);
            return ret;
        }
    }
}
