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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="RegionNetworkEndpointGroupsClient"/> instances.</summary>
    public sealed partial class RegionNetworkEndpointGroupsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionNetworkEndpointGroupsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionNetworkEndpointGroupsSettings"/>.</returns>
        public static RegionNetworkEndpointGroupsSettings GetDefault() => new RegionNetworkEndpointGroupsSettings();

        /// <summary>
        /// Constructs a new <see cref="RegionNetworkEndpointGroupsSettings"/> object with default settings.
        /// </summary>
        public RegionNetworkEndpointGroupsSettings()
        {
        }

        private RegionNetworkEndpointGroupsSettings(RegionNetworkEndpointGroupsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegionNetworkEndpointGroupsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionNetworkEndpointGroupsClient.Delete</c> and <c>RegionNetworkEndpointGroupsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionNetworkEndpointGroupsClient.Delete</c> and
        /// <c>RegionNetworkEndpointGroupsClient.DeleteAsync</c>.
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
        /// <c>RegionNetworkEndpointGroupsClient.Get</c> and <c>RegionNetworkEndpointGroupsClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionNetworkEndpointGroupsClient.Insert</c> and <c>RegionNetworkEndpointGroupsClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionNetworkEndpointGroupsClient.Insert</c> and
        /// <c>RegionNetworkEndpointGroupsClient.InsertAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionNetworkEndpointGroupsClient.List</c> and <c>RegionNetworkEndpointGroupsClient.ListAsync</c>.
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

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionNetworkEndpointGroupsSettings"/> object.</returns>
        public RegionNetworkEndpointGroupsSettings Clone() => new RegionNetworkEndpointGroupsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionNetworkEndpointGroupsClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class RegionNetworkEndpointGroupsClientBuilder : gaxgrpc::ClientBuilderBase<RegionNetworkEndpointGroupsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionNetworkEndpointGroupsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegionNetworkEndpointGroupsClientBuilder() : base(RegionNetworkEndpointGroupsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegionNetworkEndpointGroupsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionNetworkEndpointGroupsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionNetworkEndpointGroupsClient Build()
        {
            RegionNetworkEndpointGroupsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionNetworkEndpointGroupsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionNetworkEndpointGroupsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionNetworkEndpointGroupsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionNetworkEndpointGroupsClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<RegionNetworkEndpointGroupsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionNetworkEndpointGroupsClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionNetworkEndpointGroupsClient.ChannelPool;
    }

    /// <summary>RegionNetworkEndpointGroups client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionNetworkEndpointGroups API.
    /// </remarks>
    public abstract partial class RegionNetworkEndpointGroupsClient
    {
        /// <summary>
        /// The default endpoint for the RegionNetworkEndpointGroups service, which is a host of
        /// "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionNetworkEndpointGroups scopes.</summary>
        /// <remarks>
        /// The default RegionNetworkEndpointGroups scopes are:
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

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RegionNetworkEndpointGroups.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegionNetworkEndpointGroupsClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionNetworkEndpointGroupsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionNetworkEndpointGroupsClient"/>.</returns>
        public static stt::Task<RegionNetworkEndpointGroupsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionNetworkEndpointGroupsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionNetworkEndpointGroupsClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionNetworkEndpointGroupsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionNetworkEndpointGroupsClient"/>.</returns>
        public static RegionNetworkEndpointGroupsClient Create() => new RegionNetworkEndpointGroupsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionNetworkEndpointGroupsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionNetworkEndpointGroupsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegionNetworkEndpointGroupsClient"/>.</returns>
        internal static RegionNetworkEndpointGroupsClient Create(grpccore::CallInvoker callInvoker, RegionNetworkEndpointGroupsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient grpcClient = new RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient(callInvoker);
            return new RegionNetworkEndpointGroupsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RegionNetworkEndpointGroups client</summary>
        public virtual RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionNetworkEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
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
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group to delete. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string region, string networkEndpointGroup, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(networkEndpointGroup, nameof(networkEndpointGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group to delete. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string networkEndpointGroup, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(networkEndpointGroup, nameof(networkEndpointGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group to delete. It should comply with RFC1035.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string networkEndpointGroup, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, networkEndpointGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NetworkEndpointGroup Get(GetRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkEndpointGroup> GetAsync(GetRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkEndpointGroup> GetAsync(GetRegionNetworkEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NetworkEndpointGroup Get(string project, string region, string networkEndpointGroup, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(networkEndpointGroup, nameof(networkEndpointGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkEndpointGroup> GetAsync(string project, string region, string networkEndpointGroup, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(networkEndpointGroup, nameof(networkEndpointGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkEndpointGroup> GetAsync(string project, string region, string networkEndpointGroup, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, networkEndpointGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionNetworkEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
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
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where you want to create the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroupResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, string region, NetworkEndpointGroup networkEndpointGroupResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupResource = gax::GaxPreconditions.CheckNotNull(networkEndpointGroupResource, nameof(networkEndpointGroupResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where you want to create the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroupResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, NetworkEndpointGroup networkEndpointGroupResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupResource = gax::GaxPreconditions.CheckNotNull(networkEndpointGroupResource, nameof(networkEndpointGroupResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where you want to create the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroupResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, NetworkEndpointGroup networkEndpointGroupResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, networkEndpointGroupResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> List(ListRegionNetworkEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> ListAsync(ListRegionNetworkEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
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
        /// <returns>A pageable sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListRegionNetworkEndpointGroupsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListRegionNetworkEndpointGroupsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>RegionNetworkEndpointGroups client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionNetworkEndpointGroups API.
    /// </remarks>
    public sealed partial class RegionNetworkEndpointGroupsClientImpl : RegionNetworkEndpointGroupsClient
    {
        private readonly gaxgrpc::ApiCall<DeleteRegionNetworkEndpointGroupRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetRegionNetworkEndpointGroupRequest, NetworkEndpointGroup> _callGet;

        private readonly gaxgrpc::ApiCall<InsertRegionNetworkEndpointGroupRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListRegionNetworkEndpointGroupsRequest, NetworkEndpointGroupList> _callList;

        /// <summary>
        /// Constructs a client wrapper for the RegionNetworkEndpointGroups service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RegionNetworkEndpointGroupsSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegionNetworkEndpointGroupsClientImpl(RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient grpcClient, RegionNetworkEndpointGroupsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegionNetworkEndpointGroupsSettings effectiveSettings = settings ?? RegionNetworkEndpointGroupsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.InsertOperationsSettings, logger);
            _callDelete = clientHelper.BuildApiCall<DeleteRegionNetworkEndpointGroupRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("network_endpoint_group", request => request.NetworkEndpointGroup);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetRegionNetworkEndpointGroupRequest, NetworkEndpointGroup>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("network_endpoint_group", request => request.NetworkEndpointGroup);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertRegionNetworkEndpointGroupRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListRegionNetworkEndpointGroupsRequest, NetworkEndpointGroupList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteRegionNetworkEndpointGroupRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionNetworkEndpointGroupRequest, NetworkEndpointGroup> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertRegionNetworkEndpointGroupRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRegionNetworkEndpointGroupsRequest, NetworkEndpointGroupList> call);

        partial void OnConstruction(RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient grpcClient, RegionNetworkEndpointGroupsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionNetworkEndpointGroups client</summary>
        public override RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient GrpcClient { get; }

        partial void Modify_DeleteRegionNetworkEndpointGroupRequest(ref DeleteRegionNetworkEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRegionNetworkEndpointGroupRequest(ref GetRegionNetworkEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRegionNetworkEndpointGroupRequest(ref InsertRegionNetworkEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionNetworkEndpointGroupsRequest(ref ListRegionNetworkEndpointGroupsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NetworkEndpointGroup Get(GetRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NetworkEndpointGroup> GetAsync(GetRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public override gax::PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> List(ListRegionNetworkEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionNetworkEndpointGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionNetworkEndpointGroupsRequest, NetworkEndpointGroupList, NetworkEndpointGroup>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> ListAsync(ListRegionNetworkEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionNetworkEndpointGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionNetworkEndpointGroupsRequest, NetworkEndpointGroupList, NetworkEndpointGroup>(_callList, request, callSettings);
        }
    }

    public partial class ListRegionNetworkEndpointGroupsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public static partial class RegionNetworkEndpointGroups
    {
        public partial class RegionNetworkEndpointGroupsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to RegionOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForRegionOperations() =>
                RegionOperations.RegionOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
