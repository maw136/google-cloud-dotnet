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

using lro = Google.LongRunning;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="BackendBucketsClient"/> instances.</summary>
    public sealed partial class BackendBucketsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BackendBucketsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BackendBucketsSettings"/>.</returns>
        public static BackendBucketsSettings GetDefault() => new BackendBucketsSettings();

        /// <summary>Constructs a new <see cref="BackendBucketsSettings"/> object with default settings.</summary>
        public BackendBucketsSettings()
        {
        }

        private BackendBucketsSettings(BackendBucketsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AddSignedUrlKeySettings = existing.AddSignedUrlKeySettings;
            AddSignedUrlKeyOperationsSettings = existing.AddSignedUrlKeyOperationsSettings.Clone();
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            DeleteSignedUrlKeySettings = existing.DeleteSignedUrlKeySettings;
            DeleteSignedUrlKeyOperationsSettings = existing.DeleteSignedUrlKeyOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            PatchOperationsSettings = existing.PatchOperationsSettings.Clone();
            UpdateSettings = existing.UpdateSettings;
            UpdateOperationsSettings = existing.UpdateOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(BackendBucketsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackendBucketsClient.AddSignedUrlKey</c> and <c>BackendBucketsClient.AddSignedUrlKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddSignedUrlKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackendBucketsClient.AddSignedUrlKey</c> and
        /// <c>BackendBucketsClient.AddSignedUrlKeyAsync</c>.
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
        public lro::OperationsSettings AddSignedUrlKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackendBucketsClient.Delete</c>
        ///  and <c>BackendBucketsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackendBucketsClient.Delete</c> and
        /// <c>BackendBucketsClient.DeleteAsync</c>.
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
        public lro::OperationsSettings DeleteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackendBucketsClient.DeleteSignedUrlKey</c> and <c>BackendBucketsClient.DeleteSignedUrlKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSignedUrlKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackendBucketsClient.DeleteSignedUrlKey</c> and
        /// <c>BackendBucketsClient.DeleteSignedUrlKeyAsync</c>.
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
        public lro::OperationsSettings DeleteSignedUrlKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackendBucketsClient.Get</c>
        ///  and <c>BackendBucketsClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackendBucketsClient.Insert</c>
        ///  and <c>BackendBucketsClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackendBucketsClient.Insert</c> and
        /// <c>BackendBucketsClient.InsertAsync</c>.
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
        public lro::OperationsSettings InsertOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackendBucketsClient.List</c>
        ///  and <c>BackendBucketsClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackendBucketsClient.Patch</c>
        ///  and <c>BackendBucketsClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackendBucketsClient.Patch</c> and
        /// <c>BackendBucketsClient.PatchAsync</c>.
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
        public lro::OperationsSettings PatchOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackendBucketsClient.Update</c>
        ///  and <c>BackendBucketsClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackendBucketsClient.Update</c> and
        /// <c>BackendBucketsClient.UpdateAsync</c>.
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
        public lro::OperationsSettings UpdateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BackendBucketsSettings"/> object.</returns>
        public BackendBucketsSettings Clone() => new BackendBucketsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BackendBucketsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class BackendBucketsClientBuilder : gaxgrpc::ClientBuilderBase<BackendBucketsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BackendBucketsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BackendBucketsClientBuilder()
        {
            UseJwtAccessWithScopes = BackendBucketsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref BackendBucketsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BackendBucketsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BackendBucketsClient Build()
        {
            BackendBucketsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BackendBucketsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BackendBucketsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BackendBucketsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BackendBucketsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<BackendBucketsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BackendBucketsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => BackendBucketsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BackendBucketsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BackendBucketsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>BackendBuckets client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The BackendBuckets API.
    /// </remarks>
    public abstract partial class BackendBucketsClient
    {
        /// <summary>
        /// The default endpoint for the BackendBuckets service, which is a host of "compute.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default BackendBuckets scopes.</summary>
        /// <remarks>
        /// The default BackendBuckets scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
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
        /// Asynchronously creates a <see cref="BackendBucketsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BackendBucketsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BackendBucketsClient"/>.</returns>
        public static stt::Task<BackendBucketsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BackendBucketsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BackendBucketsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BackendBucketsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BackendBucketsClient"/>.</returns>
        public static BackendBucketsClient Create() => new BackendBucketsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BackendBucketsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BackendBucketsSettings"/>.</param>
        /// <returns>The created <see cref="BackendBucketsClient"/>.</returns>
        internal static BackendBucketsClient Create(grpccore::CallInvoker callInvoker, BackendBucketsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BackendBuckets.BackendBucketsClient grpcClient = new BackendBuckets.BackendBucketsClient(callInvoker);
            return new BackendBucketsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC BackendBuckets client</summary>
        public virtual BackendBuckets.BackendBucketsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddSignedUrlKey(AddSignedUrlKeyBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddSignedUrlKeyAsync(AddSignedUrlKeyBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddSignedUrlKeyAsync(AddSignedUrlKeyBackendBucketRequest request, st::CancellationToken cancellationToken) =>
            AddSignedUrlKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddSignedUrlKey</c>.</summary>
        public virtual lro::OperationsClient AddSignedUrlKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddSignedUrlKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceAddSignedUrlKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddSignedUrlKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddSignedUrlKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceAddSignedUrlKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddSignedUrlKeyOperationsClient, callSettings);

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="signedUrlKeyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddSignedUrlKey(string project, string backendBucket, SignedUrlKey signedUrlKeyResource, gaxgrpc::CallSettings callSettings = null) =>
            AddSignedUrlKey(new AddSignedUrlKeyBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SignedUrlKeyResource = gax::GaxPreconditions.CheckNotNull(signedUrlKeyResource, nameof(signedUrlKeyResource)),
            }, callSettings);

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="signedUrlKeyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddSignedUrlKeyAsync(string project, string backendBucket, SignedUrlKey signedUrlKeyResource, gaxgrpc::CallSettings callSettings = null) =>
            AddSignedUrlKeyAsync(new AddSignedUrlKeyBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SignedUrlKeyResource = gax::GaxPreconditions.CheckNotNull(signedUrlKeyResource, nameof(signedUrlKeyResource)),
            }, callSettings);

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="signedUrlKeyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddSignedUrlKeyAsync(string project, string backendBucket, SignedUrlKey signedUrlKeyResource, st::CancellationToken cancellationToken) =>
            AddSignedUrlKeyAsync(project, backendBucket, signedUrlKeyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified BackendBucket resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified BackendBucket resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified BackendBucket resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteBackendBucketRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public virtual lro::OperationsClient DeleteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDelete(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDeleteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified BackendBucket resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string backendBucket, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified BackendBucket resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string backendBucket, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified BackendBucket resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string backendBucket, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, backendBucket, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> DeleteSignedUrlKey(DeleteSignedUrlKeyBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendBucketRequest request, st::CancellationToken cancellationToken) =>
            DeleteSignedUrlKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSignedUrlKey</c>.</summary>
        public virtual lro::OperationsClient DeleteSignedUrlKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSignedUrlKey</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDeleteSignedUrlKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSignedUrlKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSignedUrlKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDeleteSignedUrlKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSignedUrlKeyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="keyName">
        /// The name of the Signed URL Key to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> DeleteSignedUrlKey(string project, string backendBucket, string keyName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSignedUrlKey(new DeleteSignedUrlKeyBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                KeyName = gax::GaxPreconditions.CheckNotNullOrEmpty(keyName, nameof(keyName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="keyName">
        /// The name of the Signed URL Key to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteSignedUrlKeyAsync(string project, string backendBucket, string keyName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSignedUrlKeyAsync(new DeleteSignedUrlKeyBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                KeyName = gax::GaxPreconditions.CheckNotNullOrEmpty(keyName, nameof(keyName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="keyName">
        /// The name of the Signed URL Key to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteSignedUrlKeyAsync(string project, string backendBucket, string keyName, st::CancellationToken cancellationToken) =>
            DeleteSignedUrlKeyAsync(project, backendBucket, keyName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified BackendBucket resource. Gets a list of available backend buckets by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackendBucket Get(GetBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified BackendBucket resource. Gets a list of available backend buckets by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendBucket> GetAsync(GetBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified BackendBucket resource. Gets a list of available backend buckets by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendBucket> GetAsync(GetBackendBucketRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified BackendBucket resource. Gets a list of available backend buckets by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackendBucket Get(string project, string backendBucket, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Returns the specified BackendBucket resource. Gets a list of available backend buckets by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendBucket> GetAsync(string project, string backendBucket, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Returns the specified BackendBucket resource. Gets a list of available backend buckets by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendBucket> GetAsync(string project, string backendBucket, st::CancellationToken cancellationToken) =>
            GetAsync(project, backendBucket, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a BackendBucket resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a BackendBucket resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a BackendBucket resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertBackendBucketRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public virtual lro::OperationsClient InsertOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceInsert(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceInsertAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Creates a BackendBucket resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucketResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, BackendBucket backendBucketResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertBackendBucketRequest
            {
                BackendBucketResource = gax::GaxPreconditions.CheckNotNull(backendBucketResource, nameof(backendBucketResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Creates a BackendBucket resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucketResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, BackendBucket backendBucketResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertBackendBucketRequest
            {
                BackendBucketResource = gax::GaxPreconditions.CheckNotNull(backendBucketResource, nameof(backendBucketResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Creates a BackendBucket resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucketResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, BackendBucket backendBucketResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, backendBucketResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of BackendBucket resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackendBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<BackendBucketList, BackendBucket> List(ListBackendBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of BackendBucket resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackendBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<BackendBucketList, BackendBucket> ListAsync(ListBackendBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of BackendBucket resources available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable sequence of <see cref="BackendBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<BackendBucketList, BackendBucket> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListBackendBucketsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the list of BackendBucket resources available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackendBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<BackendBucketList, BackendBucket> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListBackendBucketsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(PatchBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchBackendBucketRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public virtual lro::OperationsClient PatchOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOncePatch(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOncePatchAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to patch.
        /// </param>
        /// <param name="backendBucketResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(string project, string backendBucket, BackendBucket backendBucketResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                BackendBucketResource = gax::GaxPreconditions.CheckNotNull(backendBucketResource, nameof(backendBucketResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to patch.
        /// </param>
        /// <param name="backendBucketResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string backendBucket, BackendBucket backendBucketResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                BackendBucketResource = gax::GaxPreconditions.CheckNotNull(backendBucketResource, nameof(backendBucketResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to patch.
        /// </param>
        /// <param name="backendBucketResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string backendBucket, BackendBucket backendBucketResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, backendBucket, backendBucketResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(UpdateBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateBackendBucketRequest request, st::CancellationToken cancellationToken) =>
            UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public virtual lro::OperationsClient UpdateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Update</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceUpdate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Update</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceUpdateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to update.
        /// </param>
        /// <param name="backendBucketResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(string project, string backendBucket, BackendBucket backendBucketResource, gaxgrpc::CallSettings callSettings = null) =>
            Update(new UpdateBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                BackendBucketResource = gax::GaxPreconditions.CheckNotNull(backendBucketResource, nameof(backendBucketResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to update.
        /// </param>
        /// <param name="backendBucketResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string backendBucket, BackendBucket backendBucketResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsync(new UpdateBackendBucketRequest
            {
                BackendBucket = gax::GaxPreconditions.CheckNotNullOrEmpty(backendBucket, nameof(backendBucket)),
                BackendBucketResource = gax::GaxPreconditions.CheckNotNull(backendBucketResource, nameof(backendBucketResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendBucket">
        /// Name of the BackendBucket resource to update.
        /// </param>
        /// <param name="backendBucketResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string backendBucket, BackendBucket backendBucketResource, st::CancellationToken cancellationToken) =>
            UpdateAsync(project, backendBucket, backendBucketResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BackendBuckets client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The BackendBuckets API.
    /// </remarks>
    public sealed partial class BackendBucketsClientImpl : BackendBucketsClient
    {
        private readonly gaxgrpc::ApiCall<AddSignedUrlKeyBackendBucketRequest, Operation> _callAddSignedUrlKey;

        private readonly gaxgrpc::ApiCall<DeleteBackendBucketRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<DeleteSignedUrlKeyBackendBucketRequest, Operation> _callDeleteSignedUrlKey;

        private readonly gaxgrpc::ApiCall<GetBackendBucketRequest, BackendBucket> _callGet;

        private readonly gaxgrpc::ApiCall<InsertBackendBucketRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListBackendBucketsRequest, BackendBucketList> _callList;

        private readonly gaxgrpc::ApiCall<PatchBackendBucketRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<UpdateBackendBucketRequest, Operation> _callUpdate;

        /// <summary>
        /// Constructs a client wrapper for the BackendBuckets service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BackendBucketsSettings"/> used within this client.</param>
        public BackendBucketsClientImpl(BackendBuckets.BackendBucketsClient grpcClient, BackendBucketsSettings settings)
        {
            GrpcClient = grpcClient;
            BackendBucketsSettings effectiveSettings = settings ?? BackendBucketsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            AddSignedUrlKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.AddSignedUrlKeyOperationsSettings);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.DeleteOperationsSettings);
            DeleteSignedUrlKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.DeleteSignedUrlKeyOperationsSettings);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.InsertOperationsSettings);
            PatchOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.PatchOperationsSettings);
            UpdateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.UpdateOperationsSettings);
            _callAddSignedUrlKey = clientHelper.BuildApiCall<AddSignedUrlKeyBackendBucketRequest, Operation>(grpcClient.AddSignedUrlKeyAsync, grpcClient.AddSignedUrlKey, effectiveSettings.AddSignedUrlKeySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_bucket", request => request.BackendBucket);
            Modify_ApiCall(ref _callAddSignedUrlKey);
            Modify_AddSignedUrlKeyApiCall(ref _callAddSignedUrlKey);
            _callDelete = clientHelper.BuildApiCall<DeleteBackendBucketRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_bucket", request => request.BackendBucket);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callDeleteSignedUrlKey = clientHelper.BuildApiCall<DeleteSignedUrlKeyBackendBucketRequest, Operation>(grpcClient.DeleteSignedUrlKeyAsync, grpcClient.DeleteSignedUrlKey, effectiveSettings.DeleteSignedUrlKeySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_bucket", request => request.BackendBucket);
            Modify_ApiCall(ref _callDeleteSignedUrlKey);
            Modify_DeleteSignedUrlKeyApiCall(ref _callDeleteSignedUrlKey);
            _callGet = clientHelper.BuildApiCall<GetBackendBucketRequest, BackendBucket>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_bucket", request => request.BackendBucket);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertBackendBucketRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListBackendBucketsRequest, BackendBucketList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchBackendBucketRequest, Operation>(grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_bucket", request => request.BackendBucket);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callUpdate = clientHelper.BuildApiCall<UpdateBackendBucketRequest, Operation>(grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_bucket", request => request.BackendBucket);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AddSignedUrlKeyApiCall(ref gaxgrpc::ApiCall<AddSignedUrlKeyBackendBucketRequest, Operation> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteBackendBucketRequest, Operation> call);

        partial void Modify_DeleteSignedUrlKeyApiCall(ref gaxgrpc::ApiCall<DeleteSignedUrlKeyBackendBucketRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetBackendBucketRequest, BackendBucket> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertBackendBucketRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListBackendBucketsRequest, BackendBucketList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchBackendBucketRequest, Operation> call);

        partial void Modify_UpdateApiCall(ref gaxgrpc::ApiCall<UpdateBackendBucketRequest, Operation> call);

        partial void OnConstruction(BackendBuckets.BackendBucketsClient grpcClient, BackendBucketsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BackendBuckets client</summary>
        public override BackendBuckets.BackendBucketsClient GrpcClient { get; }

        partial void Modify_AddSignedUrlKeyBackendBucketRequest(ref AddSignedUrlKeyBackendBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackendBucketRequest(ref DeleteBackendBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSignedUrlKeyBackendBucketRequest(ref DeleteSignedUrlKeyBackendBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackendBucketRequest(ref GetBackendBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertBackendBucketRequest(ref InsertBackendBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackendBucketsRequest(ref ListBackendBucketsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchBackendBucketRequest(ref PatchBackendBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackendBucketRequest(ref UpdateBackendBucketRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>AddSignedUrlKey</c>.</summary>
        public override lro::OperationsClient AddSignedUrlKeyOperationsClient { get; }

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddSignedUrlKey(AddSignedUrlKeyBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddSignedUrlKeyBackendBucketRequest(ref request, ref callSettings);
            Operation response = _callAddSignedUrlKey.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddSignedUrlKeyOperationsClient);
        }

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddSignedUrlKeyAsync(AddSignedUrlKeyBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddSignedUrlKeyBackendBucketRequest(ref request, ref callSettings);
            Operation response = await _callAddSignedUrlKey.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddSignedUrlKeyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified BackendBucket resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackendBucketRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified BackendBucket resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackendBucketRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSignedUrlKey</c>.</summary>
        public override lro::OperationsClient DeleteSignedUrlKeyOperationsClient { get; }

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> DeleteSignedUrlKey(DeleteSignedUrlKeyBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSignedUrlKeyBackendBucketRequest(ref request, ref callSettings);
            Operation response = _callDeleteSignedUrlKey.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteSignedUrlKeyOperationsClient);
        }

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSignedUrlKeyBackendBucketRequest(ref request, ref callSettings);
            Operation response = await _callDeleteSignedUrlKey.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteSignedUrlKeyOperationsClient);
        }

        /// <summary>
        /// Returns the specified BackendBucket resource. Gets a list of available backend buckets by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BackendBucket Get(GetBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackendBucketRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified BackendBucket resource. Gets a list of available backend buckets by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackendBucket> GetAsync(GetBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackendBucketRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a BackendBucket resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertBackendBucketRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a BackendBucket resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertBackendBucketRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves the list of BackendBucket resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackendBucket"/> resources.</returns>
        public override gax::PagedEnumerable<BackendBucketList, BackendBucket> List(ListBackendBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackendBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackendBucketsRequest, BackendBucketList, BackendBucket>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of BackendBucket resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackendBucket"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<BackendBucketList, BackendBucket> ListAsync(ListBackendBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackendBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackendBucketsRequest, BackendBucketList, BackendBucket>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public override lro::OperationsClient PatchOperationsClient { get; }

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Patch(PatchBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchBackendBucketRequest(ref request, ref callSettings);
            Operation response = _callPatch.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchBackendBucketRequest(ref request, ref callSettings);
            Operation response = await _callPatch.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public override lro::OperationsClient UpdateOperationsClient { get; }

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Update(UpdateBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackendBucketRequest(ref request, ref callSettings);
            Operation response = _callUpdate.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }

        /// <summary>
        /// Updates the specified BackendBucket resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateBackendBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackendBucketRequest(ref request, ref callSettings);
            Operation response = await _callUpdate.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }
    }

    public partial class ListBackendBucketsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class BackendBucketList : gaxgrpc::IPageResponse<BackendBucket>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackendBucket> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BackendBuckets
    {
        public partial class BackendBucketsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to GlobalOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForGlobalOperations() =>
                GlobalOperations.GlobalOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
