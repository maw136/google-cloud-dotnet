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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Settings for <see cref="IntentsClient"/> instances.</summary>
    public sealed partial class IntentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IntentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IntentsSettings"/>.</returns>
        public static IntentsSettings GetDefault() => new IntentsSettings();

        /// <summary>Constructs a new <see cref="IntentsSettings"/> object with default settings.</summary>
        public IntentsSettings()
        {
        }

        private IntentsSettings(IntentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListIntentsSettings = existing.ListIntentsSettings;
            GetIntentSettings = existing.GetIntentSettings;
            CreateIntentSettings = existing.CreateIntentSettings;
            UpdateIntentSettings = existing.UpdateIntentSettings;
            DeleteIntentSettings = existing.DeleteIntentSettings;
            BatchUpdateIntentsSettings = existing.BatchUpdateIntentsSettings;
            BatchUpdateIntentsOperationsSettings = existing.BatchUpdateIntentsOperationsSettings.Clone();
            BatchDeleteIntentsSettings = existing.BatchDeleteIntentsSettings;
            BatchDeleteIntentsOperationsSettings = existing.BatchDeleteIntentsOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(IntentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IntentsClient.ListIntents</c>
        ///  and <c>IntentsClient.ListIntentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIntentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IntentsClient.GetIntent</c>
        /// and <c>IntentsClient.GetIntentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIntentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IntentsClient.CreateIntent</c>
        ///  and <c>IntentsClient.CreateIntentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateIntentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IntentsClient.UpdateIntent</c>
        ///  and <c>IntentsClient.UpdateIntentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateIntentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IntentsClient.DeleteIntent</c>
        ///  and <c>IntentsClient.DeleteIntentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIntentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IntentsClient.BatchUpdateIntents</c> and <c>IntentsClient.BatchUpdateIntentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateIntentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>IntentsClient.BatchUpdateIntents</c> and
        /// <c>IntentsClient.BatchUpdateIntentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchUpdateIntentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IntentsClient.BatchDeleteIntents</c> and <c>IntentsClient.BatchDeleteIntentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteIntentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>IntentsClient.BatchDeleteIntents</c> and
        /// <c>IntentsClient.BatchDeleteIntentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchDeleteIntentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IntentsSettings"/> object.</returns>
        public IntentsSettings Clone() => new IntentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IntentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class IntentsClientBuilder : gaxgrpc::ClientBuilderBase<IntentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IntentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IntentsClientBuilder()
        {
            UseJwtAccessWithScopes = IntentsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref IntentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IntentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IntentsClient Build()
        {
            IntentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IntentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IntentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IntentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IntentsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<IntentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IntentsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => IntentsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => IntentsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IntentsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Intents client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Intents][google.cloud.dialogflow.v2.Intent].
    /// </remarks>
    public abstract partial class IntentsClient
    {
        /// <summary>
        /// The default endpoint for the Intents service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Intents scopes.</summary>
        /// <remarks>
        /// The default Intents scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="IntentsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="IntentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IntentsClient"/>.</returns>
        public static stt::Task<IntentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IntentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IntentsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="IntentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IntentsClient"/>.</returns>
        public static IntentsClient Create() => new IntentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IntentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IntentsSettings"/>.</param>
        /// <returns>The created <see cref="IntentsClient"/>.</returns>
        internal static IntentsClient Create(grpccore::CallInvoker callInvoker, IntentsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Intents.IntentsClient grpcClient = new Intents.IntentsClient(callInvoker);
            return new IntentsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Intents client</summary>
        public virtual Intents.IntentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Intent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(ListIntentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Intent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(ListIntentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/{Project ID}/agent` or `projects/{Project
        /// ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent`.
        /// 
        /// Alternatively, you can specify the environment to list intents for.
        /// Format: `projects/{Project ID}/agent/environments/{Environment ID}`
        /// or `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/agent/environments/&amp;lt;Environment ID&amp;gt;`.
        /// Note: training phrases of the intents will not be returned for non-draft
        /// environment.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Intent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIntents(new ListIntentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/{Project ID}/agent` or `projects/{Project
        /// ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent`.
        /// 
        /// Alternatively, you can specify the environment to list intents for.
        /// Format: `projects/{Project ID}/agent/environments/{Environment ID}`
        /// or `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/agent/environments/&amp;lt;Environment ID&amp;gt;`.
        /// Note: training phrases of the intents will not be returned for non-draft
        /// environment.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Intent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIntentsAsync(new ListIntentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/{Project ID}/agent` or `projects/{Project
        /// ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent`.
        /// 
        /// Alternatively, you can specify the environment to list intents for.
        /// Format: `projects/{Project ID}/agent/environments/{Environment ID}`
        /// or `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/agent/environments/&amp;lt;Environment ID&amp;gt;`.
        /// Note: training phrases of the intents will not be returned for non-draft
        /// environment.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Intent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIntents(new ListIntentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/{Project ID}/agent` or `projects/{Project
        /// ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent`.
        /// 
        /// Alternatively, you can specify the environment to list intents for.
        /// Format: `projects/{Project ID}/agent/environments/{Environment ID}`
        /// or `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/agent/environments/&amp;lt;Environment ID&amp;gt;`.
        /// Note: training phrases of the intents will not be returned for non-draft
        /// environment.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Intent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIntentsAsync(new ListIntentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/{Project ID}/agent` or `projects/{Project
        /// ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent`.
        /// 
        /// Alternatively, you can specify the environment to list intents for.
        /// Format: `projects/{Project ID}/agent/environments/{Environment ID}`
        /// or `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/agent/environments/&amp;lt;Environment ID&amp;gt;`.
        /// Note: training phrases of the intents will not be returned for non-draft
        /// environment.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Intent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(string parent, string languageCode, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIntents(new ListIntentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LanguageCode = languageCode ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/{Project ID}/agent` or `projects/{Project
        /// ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent`.
        /// 
        /// Alternatively, you can specify the environment to list intents for.
        /// Format: `projects/{Project ID}/agent/environments/{Environment ID}`
        /// or `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/agent/environments/&amp;lt;Environment ID&amp;gt;`.
        /// Note: training phrases of the intents will not be returned for non-draft
        /// environment.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Intent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(string parent, string languageCode, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIntentsAsync(new ListIntentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LanguageCode = languageCode ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/{Project ID}/agent` or `projects/{Project
        /// ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent`.
        /// 
        /// Alternatively, you can specify the environment to list intents for.
        /// Format: `projects/{Project ID}/agent/environments/{Environment ID}`
        /// or `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/agent/environments/&amp;lt;Environment ID&amp;gt;`.
        /// Note: training phrases of the intents will not be returned for non-draft
        /// environment.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Intent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(AgentName parent, string languageCode, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIntents(new ListIntentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LanguageCode = languageCode ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/{Project ID}/agent` or `projects/{Project
        /// ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent`.
        /// 
        /// Alternatively, you can specify the environment to list intents for.
        /// Format: `projects/{Project ID}/agent/environments/{Environment ID}`
        /// or `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/agent/environments/&amp;lt;Environment ID&amp;gt;`.
        /// Note: training phrases of the intents will not be returned for non-draft
        /// environment.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Intent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(AgentName parent, string languageCode, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIntentsAsync(new ListIntentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LanguageCode = languageCode ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent GetIntent(GetIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> GetIntentAsync(GetIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> GetIntentAsync(GetIntentRequest request, st::CancellationToken cancellationToken) =>
            GetIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent GetIntent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIntent(new GetIntentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> GetIntentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIntentAsync(new GetIntentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> GetIntentAsync(string name, st::CancellationToken cancellationToken) =>
            GetIntentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent GetIntent(IntentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIntent(new GetIntentRequest
            {
                IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> GetIntentAsync(IntentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIntentAsync(new GetIntentRequest
            {
                IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> GetIntentAsync(IntentName name, st::CancellationToken cancellationToken) =>
            GetIntentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent GetIntent(string name, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetIntent(new GetIntentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> GetIntentAsync(string name, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetIntentAsync(new GetIntentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> GetIntentAsync(string name, string languageCode, st::CancellationToken cancellationToken) =>
            GetIntentAsync(name, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent GetIntent(IntentName name, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetIntent(new GetIntentRequest
            {
                IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> GetIntentAsync(IntentName name, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetIntentAsync(new GetIntentRequest
            {
                IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> GetIntentAsync(IntentName name, string languageCode, st::CancellationToken cancellationToken) =>
            GetIntentAsync(name, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent CreateIntent(CreateIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> CreateIntentAsync(CreateIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> CreateIntentAsync(CreateIntentRequest request, st::CancellationToken cancellationToken) =>
            CreateIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent CreateIntent(string parent, Intent intent, gaxgrpc::CallSettings callSettings = null) =>
            CreateIntent(new CreateIntentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
            }, callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> CreateIntentAsync(string parent, Intent intent, gaxgrpc::CallSettings callSettings = null) =>
            CreateIntentAsync(new CreateIntentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
            }, callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> CreateIntentAsync(string parent, Intent intent, st::CancellationToken cancellationToken) =>
            CreateIntentAsync(parent, intent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent CreateIntent(AgentName parent, Intent intent, gaxgrpc::CallSettings callSettings = null) =>
            CreateIntent(new CreateIntentRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
            }, callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> CreateIntentAsync(AgentName parent, Intent intent, gaxgrpc::CallSettings callSettings = null) =>
            CreateIntentAsync(new CreateIntentRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
            }, callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> CreateIntentAsync(AgentName parent, Intent intent, st::CancellationToken cancellationToken) =>
            CreateIntentAsync(parent, intent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent CreateIntent(string parent, Intent intent, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            CreateIntent(new CreateIntentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> CreateIntentAsync(string parent, Intent intent, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            CreateIntentAsync(new CreateIntentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> CreateIntentAsync(string parent, Intent intent, string languageCode, st::CancellationToken cancellationToken) =>
            CreateIntentAsync(parent, intent, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent CreateIntent(AgentName parent, Intent intent, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            CreateIntent(new CreateIntentRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> CreateIntentAsync(AgentName parent, Intent intent, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            CreateIntentAsync(new CreateIntentRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> CreateIntentAsync(AgentName parent, Intent intent, string languageCode, st::CancellationToken cancellationToken) =>
            CreateIntentAsync(parent, intent, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified intent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent UpdateIntent(UpdateIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified intent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> UpdateIntentAsync(UpdateIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified intent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> UpdateIntentAsync(UpdateIntentRequest request, st::CancellationToken cancellationToken) =>
            UpdateIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified intent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent UpdateIntent(Intent intent, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIntent(new UpdateIntentRequest
            {
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Updates the specified intent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> UpdateIntentAsync(Intent intent, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIntentAsync(new UpdateIntentRequest
            {
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Updates the specified intent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> UpdateIntentAsync(Intent intent, string languageCode, st::CancellationToken cancellationToken) =>
            UpdateIntentAsync(intent, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified intent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Intent UpdateIntent(Intent intent, string languageCode, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIntent(new UpdateIntentRequest
            {
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                LanguageCode = languageCode ?? "",
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified intent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> UpdateIntentAsync(Intent intent, string languageCode, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIntentAsync(new UpdateIntentRequest
            {
                Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                LanguageCode = languageCode ?? "",
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified intent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Intent> UpdateIntentAsync(Intent intent, string languageCode, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateIntentAsync(intent, languageCode, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteIntent(DeleteIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIntentAsync(DeleteIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIntentAsync(DeleteIntentRequest request, st::CancellationToken cancellationToken) =>
            DeleteIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteIntent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIntent(new DeleteIntentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIntentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIntentAsync(new DeleteIntentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIntentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIntentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteIntent(IntentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIntent(new DeleteIntentRequest
            {
                IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIntentAsync(IntentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIntentAsync(new DeleteIntentRequest
            {
                IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/{Project ID}/agent/intents/{Intent ID}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIntentAsync(IntentName name, st::CancellationToken cancellationToken) =>
            DeleteIntentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchUpdateIntentsResponse, wkt::Struct> BatchUpdateIntents(BatchUpdateIntentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> BatchUpdateIntentsAsync(BatchUpdateIntentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> BatchUpdateIntentsAsync(BatchUpdateIntentsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateIntentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchUpdateIntents</c>.</summary>
        public virtual lro::OperationsClient BatchUpdateIntentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchUpdateIntents</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchUpdateIntentsResponse, wkt::Struct> PollOnceBatchUpdateIntents(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchUpdateIntentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchUpdateIntents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> PollOnceBatchUpdateIntentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchUpdateIntentsOperationsClient, callSettings);

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchUri">
        /// The URI to a Google Cloud Storage file containing intents to update or
        /// create. The file format can either be a serialized proto (of IntentBatch
        /// type) or JSON object. Note: The URI must start with "gs://".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchUpdateIntentsResponse, wkt::Struct> BatchUpdateIntents(string parent, string intentBatchUri, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateIntents(new BatchUpdateIntentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IntentBatchUri = intentBatchUri ?? "",
            }, callSettings);

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchUri">
        /// The URI to a Google Cloud Storage file containing intents to update or
        /// create. The file format can either be a serialized proto (of IntentBatch
        /// type) or JSON object. Note: The URI must start with "gs://".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> BatchUpdateIntentsAsync(string parent, string intentBatchUri, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateIntentsAsync(new BatchUpdateIntentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IntentBatchUri = intentBatchUri ?? "",
            }, callSettings);

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchUri">
        /// The URI to a Google Cloud Storage file containing intents to update or
        /// create. The file format can either be a serialized proto (of IntentBatch
        /// type) or JSON object. Note: The URI must start with "gs://".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> BatchUpdateIntentsAsync(string parent, string intentBatchUri, st::CancellationToken cancellationToken) =>
            BatchUpdateIntentsAsync(parent, intentBatchUri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchUri">
        /// The URI to a Google Cloud Storage file containing intents to update or
        /// create. The file format can either be a serialized proto (of IntentBatch
        /// type) or JSON object. Note: The URI must start with "gs://".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchUpdateIntentsResponse, wkt::Struct> BatchUpdateIntents(AgentName parent, string intentBatchUri, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateIntents(new BatchUpdateIntentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IntentBatchUri = intentBatchUri ?? "",
            }, callSettings);

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchUri">
        /// The URI to a Google Cloud Storage file containing intents to update or
        /// create. The file format can either be a serialized proto (of IntentBatch
        /// type) or JSON object. Note: The URI must start with "gs://".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> BatchUpdateIntentsAsync(AgentName parent, string intentBatchUri, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateIntentsAsync(new BatchUpdateIntentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IntentBatchUri = intentBatchUri ?? "",
            }, callSettings);

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchUri">
        /// The URI to a Google Cloud Storage file containing intents to update or
        /// create. The file format can either be a serialized proto (of IntentBatch
        /// type) or JSON object. Note: The URI must start with "gs://".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> BatchUpdateIntentsAsync(AgentName parent, string intentBatchUri, st::CancellationToken cancellationToken) =>
            BatchUpdateIntentsAsync(parent, intentBatchUri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchInline">
        /// The collection of intents to update or create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchUpdateIntentsResponse, wkt::Struct> BatchUpdateIntents(string parent, IntentBatch intentBatchInline, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateIntents(new BatchUpdateIntentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IntentBatchInline = intentBatchInline,
            }, callSettings);

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchInline">
        /// The collection of intents to update or create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> BatchUpdateIntentsAsync(string parent, IntentBatch intentBatchInline, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateIntentsAsync(new BatchUpdateIntentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IntentBatchInline = intentBatchInline,
            }, callSettings);

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchInline">
        /// The collection of intents to update or create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> BatchUpdateIntentsAsync(string parent, IntentBatch intentBatchInline, st::CancellationToken cancellationToken) =>
            BatchUpdateIntentsAsync(parent, intentBatchInline, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchInline">
        /// The collection of intents to update or create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchUpdateIntentsResponse, wkt::Struct> BatchUpdateIntents(AgentName parent, IntentBatch intentBatchInline, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateIntents(new BatchUpdateIntentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IntentBatchInline = intentBatchInline,
            }, callSettings);

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchInline">
        /// The collection of intents to update or create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> BatchUpdateIntentsAsync(AgentName parent, IntentBatch intentBatchInline, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateIntentsAsync(new BatchUpdateIntentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IntentBatchInline = intentBatchInline,
            }, callSettings);

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to update or create intents in.
        /// Format: `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intentBatchInline">
        /// The collection of intents to update or create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> BatchUpdateIntentsAsync(AgentName parent, IntentBatch intentBatchInline, st::CancellationToken cancellationToken) =>
            BatchUpdateIntentsAsync(parent, intentBatchInline, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteIntents(BatchDeleteIntentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteIntentsAsync(BatchDeleteIntentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteIntentsAsync(BatchDeleteIntentsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteIntentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchDeleteIntents</c>.</summary>
        public virtual lro::OperationsClient BatchDeleteIntentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchDeleteIntents</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> PollOnceBatchDeleteIntents(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteIntentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchDeleteIntents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> PollOnceBatchDeleteIntentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteIntentsOperationsClient, callSettings);

        /// <summary>
        /// Deletes intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteIntents(string parent, scg::IEnumerable<Intent> intents, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteIntents(new BatchDeleteIntentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Intents =
                {
                    gax::GaxPreconditions.CheckNotNull(intents, nameof(intents)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteIntentsAsync(string parent, scg::IEnumerable<Intent> intents, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteIntentsAsync(new BatchDeleteIntentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Intents =
                {
                    gax::GaxPreconditions.CheckNotNull(intents, nameof(intents)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteIntentsAsync(string parent, scg::IEnumerable<Intent> intents, st::CancellationToken cancellationToken) =>
            BatchDeleteIntentsAsync(parent, intents, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteIntents(AgentName parent, scg::IEnumerable<Intent> intents, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteIntents(new BatchDeleteIntentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Intents =
                {
                    gax::GaxPreconditions.CheckNotNull(intents, nameof(intents)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteIntentsAsync(AgentName parent, scg::IEnumerable<Intent> intents, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteIntentsAsync(new BatchDeleteIntentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Intents =
                {
                    gax::GaxPreconditions.CheckNotNull(intents, nameof(intents)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/{Project ID}/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteIntentsAsync(AgentName parent, scg::IEnumerable<Intent> intents, st::CancellationToken cancellationToken) =>
            BatchDeleteIntentsAsync(parent, intents, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Intents client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Intents][google.cloud.dialogflow.v2.Intent].
    /// </remarks>
    public sealed partial class IntentsClientImpl : IntentsClient
    {
        private readonly gaxgrpc::ApiCall<ListIntentsRequest, ListIntentsResponse> _callListIntents;

        private readonly gaxgrpc::ApiCall<GetIntentRequest, Intent> _callGetIntent;

        private readonly gaxgrpc::ApiCall<CreateIntentRequest, Intent> _callCreateIntent;

        private readonly gaxgrpc::ApiCall<UpdateIntentRequest, Intent> _callUpdateIntent;

        private readonly gaxgrpc::ApiCall<DeleteIntentRequest, wkt::Empty> _callDeleteIntent;

        private readonly gaxgrpc::ApiCall<BatchUpdateIntentsRequest, lro::Operation> _callBatchUpdateIntents;

        private readonly gaxgrpc::ApiCall<BatchDeleteIntentsRequest, lro::Operation> _callBatchDeleteIntents;

        /// <summary>
        /// Constructs a client wrapper for the Intents service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IntentsSettings"/> used within this client.</param>
        public IntentsClientImpl(Intents.IntentsClient grpcClient, IntentsSettings settings)
        {
            GrpcClient = grpcClient;
            IntentsSettings effectiveSettings = settings ?? IntentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            BatchUpdateIntentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchUpdateIntentsOperationsSettings);
            BatchDeleteIntentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchDeleteIntentsOperationsSettings);
            _callListIntents = clientHelper.BuildApiCall<ListIntentsRequest, ListIntentsResponse>(grpcClient.ListIntentsAsync, grpcClient.ListIntents, effectiveSettings.ListIntentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIntents);
            Modify_ListIntentsApiCall(ref _callListIntents);
            _callGetIntent = clientHelper.BuildApiCall<GetIntentRequest, Intent>(grpcClient.GetIntentAsync, grpcClient.GetIntent, effectiveSettings.GetIntentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIntent);
            Modify_GetIntentApiCall(ref _callGetIntent);
            _callCreateIntent = clientHelper.BuildApiCall<CreateIntentRequest, Intent>(grpcClient.CreateIntentAsync, grpcClient.CreateIntent, effectiveSettings.CreateIntentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIntent);
            Modify_CreateIntentApiCall(ref _callCreateIntent);
            _callUpdateIntent = clientHelper.BuildApiCall<UpdateIntentRequest, Intent>(grpcClient.UpdateIntentAsync, grpcClient.UpdateIntent, effectiveSettings.UpdateIntentSettings).WithGoogleRequestParam("intent.name", request => request.Intent?.Name);
            Modify_ApiCall(ref _callUpdateIntent);
            Modify_UpdateIntentApiCall(ref _callUpdateIntent);
            _callDeleteIntent = clientHelper.BuildApiCall<DeleteIntentRequest, wkt::Empty>(grpcClient.DeleteIntentAsync, grpcClient.DeleteIntent, effectiveSettings.DeleteIntentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIntent);
            Modify_DeleteIntentApiCall(ref _callDeleteIntent);
            _callBatchUpdateIntents = clientHelper.BuildApiCall<BatchUpdateIntentsRequest, lro::Operation>(grpcClient.BatchUpdateIntentsAsync, grpcClient.BatchUpdateIntents, effectiveSettings.BatchUpdateIntentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateIntents);
            Modify_BatchUpdateIntentsApiCall(ref _callBatchUpdateIntents);
            _callBatchDeleteIntents = clientHelper.BuildApiCall<BatchDeleteIntentsRequest, lro::Operation>(grpcClient.BatchDeleteIntentsAsync, grpcClient.BatchDeleteIntents, effectiveSettings.BatchDeleteIntentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteIntents);
            Modify_BatchDeleteIntentsApiCall(ref _callBatchDeleteIntents);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListIntentsApiCall(ref gaxgrpc::ApiCall<ListIntentsRequest, ListIntentsResponse> call);

        partial void Modify_GetIntentApiCall(ref gaxgrpc::ApiCall<GetIntentRequest, Intent> call);

        partial void Modify_CreateIntentApiCall(ref gaxgrpc::ApiCall<CreateIntentRequest, Intent> call);

        partial void Modify_UpdateIntentApiCall(ref gaxgrpc::ApiCall<UpdateIntentRequest, Intent> call);

        partial void Modify_DeleteIntentApiCall(ref gaxgrpc::ApiCall<DeleteIntentRequest, wkt::Empty> call);

        partial void Modify_BatchUpdateIntentsApiCall(ref gaxgrpc::ApiCall<BatchUpdateIntentsRequest, lro::Operation> call);

        partial void Modify_BatchDeleteIntentsApiCall(ref gaxgrpc::ApiCall<BatchDeleteIntentsRequest, lro::Operation> call);

        partial void OnConstruction(Intents.IntentsClient grpcClient, IntentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Intents client</summary>
        public override Intents.IntentsClient GrpcClient { get; }

        partial void Modify_ListIntentsRequest(ref ListIntentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIntentRequest(ref GetIntentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateIntentRequest(ref CreateIntentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIntentRequest(ref UpdateIntentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIntentRequest(ref DeleteIntentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateIntentsRequest(ref BatchUpdateIntentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteIntentsRequest(ref BatchDeleteIntentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Intent"/> resources.</returns>
        public override gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(ListIntentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIntentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIntentsRequest, ListIntentsResponse, Intent>(_callListIntents, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Intent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(ListIntentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIntentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIntentsRequest, ListIntentsResponse, Intent>(_callListIntents, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Intent GetIntent(GetIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIntentRequest(ref request, ref callSettings);
            return _callGetIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Intent> GetIntentAsync(GetIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIntentRequest(ref request, ref callSettings);
            return _callGetIntent.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Intent CreateIntent(CreateIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIntentRequest(ref request, ref callSettings);
            return _callCreateIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an intent in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Intent> CreateIntentAsync(CreateIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIntentRequest(ref request, ref callSettings);
            return _callCreateIntent.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified intent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Intent UpdateIntent(UpdateIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIntentRequest(ref request, ref callSettings);
            return _callUpdateIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified intent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Intent> UpdateIntentAsync(UpdateIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIntentRequest(ref request, ref callSettings);
            return _callUpdateIntent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteIntent(DeleteIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIntentRequest(ref request, ref callSettings);
            _callDeleteIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteIntentAsync(DeleteIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIntentRequest(ref request, ref callSettings);
            return _callDeleteIntent.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchUpdateIntents</c>.</summary>
        public override lro::OperationsClient BatchUpdateIntentsOperationsClient { get; }

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchUpdateIntentsResponse, wkt::Struct> BatchUpdateIntents(BatchUpdateIntentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateIntentsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>(_callBatchUpdateIntents.Sync(request, callSettings), BatchUpdateIntentsOperationsClient);
        }

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>> BatchUpdateIntentsAsync(BatchUpdateIntentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateIntentsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchUpdateIntentsResponse, wkt::Struct>(await _callBatchUpdateIntents.Async(request, callSettings).ConfigureAwait(false), BatchUpdateIntentsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchDeleteIntents</c>.</summary>
        public override lro::OperationsClient BatchDeleteIntentsOperationsClient { get; }

        /// <summary>
        /// Deletes intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteIntents(BatchDeleteIntentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteIntentsRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(_callBatchDeleteIntents.Sync(request, callSettings), BatchDeleteIntentsOperationsClient);
        }

        /// <summary>
        /// Deletes intents in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteIntentsAsync(BatchDeleteIntentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteIntentsRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(await _callBatchDeleteIntents.Async(request, callSettings).ConfigureAwait(false), BatchDeleteIntentsOperationsClient);
        }
    }

    public partial class ListIntentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIntentsResponse : gaxgrpc::IPageResponse<Intent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Intent> GetEnumerator() => Intents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Intents
    {
        public partial class IntentsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
