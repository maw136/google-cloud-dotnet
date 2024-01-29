// Copyright 2024 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Settings for <see cref="CompletionServiceClient"/> instances.</summary>
    public sealed partial class CompletionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CompletionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CompletionServiceSettings"/>.</returns>
        public static CompletionServiceSettings GetDefault() => new CompletionServiceSettings();

        /// <summary>Constructs a new <see cref="CompletionServiceSettings"/> object with default settings.</summary>
        public CompletionServiceSettings()
        {
        }

        private CompletionServiceSettings(CompletionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CompleteQuerySettings = existing.CompleteQuerySettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CompletionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompletionServiceClient.CompleteQuery</c> and <c>CompletionServiceClient.CompleteQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CompleteQuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CompletionServiceSettings"/> object.</returns>
        public CompletionServiceSettings Clone() => new CompletionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CompletionServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CompletionServiceClientBuilder : gaxgrpc::ClientBuilderBase<CompletionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CompletionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CompletionServiceClientBuilder() : base(CompletionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CompletionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CompletionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CompletionServiceClient Build()
        {
            CompletionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CompletionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CompletionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CompletionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CompletionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CompletionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CompletionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CompletionServiceClient.ChannelPool;
    }

    /// <summary>CompletionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for Auto-Completion.
    /// </remarks>
    public abstract partial class CompletionServiceClient
    {
        /// <summary>
        /// The default endpoint for the CompletionService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default CompletionService scopes.</summary>
        /// <remarks>
        /// The default CompletionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CompletionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CompletionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CompletionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CompletionServiceClient"/>.</returns>
        public static stt::Task<CompletionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CompletionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CompletionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CompletionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CompletionServiceClient"/>.</returns>
        public static CompletionServiceClient Create() => new CompletionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CompletionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CompletionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CompletionServiceClient"/>.</returns>
        internal static CompletionServiceClient Create(grpccore::CallInvoker callInvoker, CompletionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CompletionService.CompletionServiceClient grpcClient = new CompletionService.CompletionServiceClient(callInvoker);
            return new CompletionServiceClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC CompletionService client</summary>
        public virtual CompletionService.CompletionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Completes the specified user input with keyword suggestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompleteQueryResponse CompleteQuery(CompleteQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Completes the specified user input with keyword suggestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompleteQueryResponse> CompleteQueryAsync(CompleteQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Completes the specified user input with keyword suggestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompleteQueryResponse> CompleteQueryAsync(CompleteQueryRequest request, st::CancellationToken cancellationToken) =>
            CompleteQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CompletionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for Auto-Completion.
    /// </remarks>
    public sealed partial class CompletionServiceClientImpl : CompletionServiceClient
    {
        private readonly gaxgrpc::ApiCall<CompleteQueryRequest, CompleteQueryResponse> _callCompleteQuery;

        /// <summary>
        /// Constructs a client wrapper for the CompletionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CompletionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CompletionServiceClientImpl(CompletionService.CompletionServiceClient grpcClient, CompletionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CompletionServiceSettings effectiveSettings = settings ?? CompletionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCompleteQuery = clientHelper.BuildApiCall<CompleteQueryRequest, CompleteQueryResponse>("CompleteQuery", grpcClient.CompleteQueryAsync, grpcClient.CompleteQuery, effectiveSettings.CompleteQuerySettings).WithGoogleRequestParam("data_store", request => request.DataStore);
            Modify_ApiCall(ref _callCompleteQuery);
            Modify_CompleteQueryApiCall(ref _callCompleteQuery);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CompleteQueryApiCall(ref gaxgrpc::ApiCall<CompleteQueryRequest, CompleteQueryResponse> call);

        partial void OnConstruction(CompletionService.CompletionServiceClient grpcClient, CompletionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CompletionService client</summary>
        public override CompletionService.CompletionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CompleteQueryRequest(ref CompleteQueryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Completes the specified user input with keyword suggestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CompleteQueryResponse CompleteQuery(CompleteQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteQueryRequest(ref request, ref callSettings);
            return _callCompleteQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Completes the specified user input with keyword suggestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CompleteQueryResponse> CompleteQueryAsync(CompleteQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteQueryRequest(ref request, ref callSettings);
            return _callCompleteQuery.Async(request, callSettings);
        }
    }

    public static partial class CompletionService
    {
        public partial class CompletionServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
