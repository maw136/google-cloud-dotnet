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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.OrgPolicy.V2
{
    /// <summary>Settings for <see cref="OrgPolicyClient"/> instances.</summary>
    public sealed partial class OrgPolicySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OrgPolicySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OrgPolicySettings"/>.</returns>
        public static OrgPolicySettings GetDefault() => new OrgPolicySettings();

        /// <summary>Constructs a new <see cref="OrgPolicySettings"/> object with default settings.</summary>
        public OrgPolicySettings()
        {
        }

        private OrgPolicySettings(OrgPolicySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListConstraintsSettings = existing.ListConstraintsSettings;
            ListPoliciesSettings = existing.ListPoliciesSettings;
            GetPolicySettings = existing.GetPolicySettings;
            GetEffectivePolicySettings = existing.GetEffectivePolicySettings;
            CreatePolicySettings = existing.CreatePolicySettings;
            UpdatePolicySettings = existing.UpdatePolicySettings;
            DeletePolicySettings = existing.DeletePolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(OrgPolicySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrgPolicyClient.ListConstraints</c> and <c>OrgPolicyClient.ListConstraintsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConstraintsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrgPolicyClient.ListPolicies</c> and <c>OrgPolicyClient.ListPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>OrgPolicyClient.GetPolicy</c>
        ///  and <c>OrgPolicyClient.GetPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrgPolicyClient.GetEffectivePolicy</c> and <c>OrgPolicyClient.GetEffectivePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEffectivePolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrgPolicyClient.CreatePolicy</c> and <c>OrgPolicyClient.CreatePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrgPolicyClient.UpdatePolicy</c> and <c>OrgPolicyClient.UpdatePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrgPolicyClient.DeletePolicy</c> and <c>OrgPolicyClient.DeletePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OrgPolicySettings"/> object.</returns>
        public OrgPolicySettings Clone() => new OrgPolicySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OrgPolicyClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class OrgPolicyClientBuilder : gaxgrpc::ClientBuilderBase<OrgPolicyClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OrgPolicySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OrgPolicyClientBuilder() : base(OrgPolicyClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OrgPolicyClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OrgPolicyClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OrgPolicyClient Build()
        {
            OrgPolicyClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OrgPolicyClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OrgPolicyClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OrgPolicyClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OrgPolicyClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<OrgPolicyClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OrgPolicyClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OrgPolicyClient.ChannelPool;
    }

    /// <summary>OrgPolicy client wrapper, for convenient use.</summary>
    /// <remarks>
    /// An interface for managing organization policies.
    /// 
    /// The Cloud Org Policy service provides a simple mechanism for organizations to
    /// restrict the allowed configurations across their entire Cloud Resource
    /// hierarchy.
    /// 
    /// You can use a `policy` to configure restrictions in Cloud resources. For
    /// example, you can enforce a `policy` that restricts which Google
    /// Cloud Platform APIs can be activated in a certain part of your resource
    /// hierarchy, or prevents serial port access to VM instances in a particular
    /// folder.
    /// 
    /// `Policies` are inherited down through the resource hierarchy. A `policy`
    /// applied to a parent resource automatically applies to all its child resources
    /// unless overridden with a `policy` lower in the hierarchy.
    /// 
    /// A `constraint` defines an aspect of a resource's configuration that can be
    /// controlled by an organization's policy administrator. `Policies` are a
    /// collection of `constraints` that defines their allowable configuration on a
    /// particular resource and its child resources.
    /// </remarks>
    public abstract partial class OrgPolicyClient
    {
        /// <summary>
        /// The default endpoint for the OrgPolicy service, which is a host of "orgpolicy.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "orgpolicy.googleapis.com:443";

        /// <summary>The default OrgPolicy scopes.</summary>
        /// <remarks>
        /// The default OrgPolicy scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OrgPolicy.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OrgPolicyClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="OrgPolicyClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OrgPolicyClient"/>.</returns>
        public static stt::Task<OrgPolicyClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OrgPolicyClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OrgPolicyClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="OrgPolicyClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OrgPolicyClient"/>.</returns>
        public static OrgPolicyClient Create() => new OrgPolicyClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OrgPolicyClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OrgPolicySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OrgPolicyClient"/>.</returns>
        internal static OrgPolicyClient Create(grpccore::CallInvoker callInvoker, OrgPolicySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OrgPolicy.OrgPolicyClient grpcClient = new OrgPolicy.OrgPolicyClient(callInvoker);
            return new OrgPolicyClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OrgPolicy client</summary>
        public virtual OrgPolicy.OrgPolicyClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Constraint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConstraintsResponse, Constraint> ListConstraints(ListConstraintsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Constraint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConstraintsResponse, Constraint> ListConstraintsAsync(ListConstraintsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the constraint. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="Constraint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConstraintsResponse, Constraint> ListConstraints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConstraints(new ListConstraintsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the constraint. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Constraint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConstraintsResponse, Constraint> ListConstraintsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConstraintsAsync(new ListConstraintsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the constraint. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="Constraint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConstraintsResponse, Constraint> ListConstraints(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConstraints(new ListConstraintsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the constraint. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Constraint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConstraintsResponse, Constraint> ListConstraintsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConstraintsAsync(new ListConstraintsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the constraint. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="Constraint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConstraintsResponse, Constraint> ListConstraints(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConstraints(new ListConstraintsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the constraint. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Constraint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConstraintsResponse, Constraint> ListConstraintsAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConstraintsAsync(new ListConstraintsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the constraint. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="Constraint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConstraintsResponse, Constraint> ListConstraints(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConstraints(new ListConstraintsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the constraint. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Constraint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConstraintsResponse, Constraint> ListConstraintsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConstraintsAsync(new ListConstraintsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The target Cloud resource that parents the set of constraints and policies
        /// that will be returned from this call. Must be in one of the following
        /// forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPolicies(new ListPoliciesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The target Cloud resource that parents the set of constraints and policies
        /// that will be returned from this call. Must be in one of the following
        /// forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPoliciesAsync(new ListPoliciesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The target Cloud resource that parents the set of constraints and policies
        /// that will be returned from this call. Must be in one of the following
        /// forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPolicies(new ListPoliciesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The target Cloud resource that parents the set of constraints and policies
        /// that will be returned from this call. Must be in one of the following
        /// forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPoliciesAsync(new ListPoliciesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The target Cloud resource that parents the set of constraints and policies
        /// that will be returned from this call. Must be in one of the following
        /// forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPolicies(new ListPoliciesRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The target Cloud resource that parents the set of constraints and policies
        /// that will be returned from this call. Must be in one of the following
        /// forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPoliciesAsync(new ListPoliciesRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The target Cloud resource that parents the set of constraints and policies
        /// that will be returned from this call. Must be in one of the following
        /// forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPolicies(new ListPoliciesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The target Cloud resource that parents the set of constraints and policies
        /// that will be returned from this call. Must be in one of the following
        /// forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPoliciesAsync(new ListPoliciesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a `Policy` on a resource.
        /// 
        /// If no `Policy` is set on the resource, NOT_FOUND is returned. The
        /// `etag` value can be used with `UpdatePolicy()` to update a
        /// `Policy` during read-modify-write.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetPolicy(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a `Policy` on a resource.
        /// 
        /// If no `Policy` is set on the resource, NOT_FOUND is returned. The
        /// `etag` value can be used with `UpdatePolicy()` to update a
        /// `Policy` during read-modify-write.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a `Policy` on a resource.
        /// 
        /// If no `Policy` is set on the resource, NOT_FOUND is returned. The
        /// `etag` value can be used with `UpdatePolicy()` to update a
        /// `Policy` during read-modify-write.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a `Policy` on a resource.
        /// 
        /// If no `Policy` is set on the resource, NOT_FOUND is returned. The
        /// `etag` value can be used with `UpdatePolicy()` to update a
        /// `Policy` during read-modify-write.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy. See `Policy` for naming requirements.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicy(new GetPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `Policy` on a resource.
        /// 
        /// If no `Policy` is set on the resource, NOT_FOUND is returned. The
        /// `etag` value can be used with `UpdatePolicy()` to update a
        /// `Policy` during read-modify-write.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy. See `Policy` for naming requirements.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyAsync(new GetPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `Policy` on a resource.
        /// 
        /// If no `Policy` is set on the resource, NOT_FOUND is returned. The
        /// `etag` value can be used with `UpdatePolicy()` to update a
        /// `Policy` during read-modify-write.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy. See `Policy` for naming requirements.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a `Policy` on a resource.
        /// 
        /// If no `Policy` is set on the resource, NOT_FOUND is returned. The
        /// `etag` value can be used with `UpdatePolicy()` to update a
        /// `Policy` during read-modify-write.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy. See `Policy` for naming requirements.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetPolicy(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicy(new GetPolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `Policy` on a resource.
        /// 
        /// If no `Policy` is set on the resource, NOT_FOUND is returned. The
        /// `etag` value can be used with `UpdatePolicy()` to update a
        /// `Policy` during read-modify-write.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy. See `Policy` for naming requirements.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyAsync(new GetPolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `Policy` on a resource.
        /// 
        /// If no `Policy` is set on the resource, NOT_FOUND is returned. The
        /// `etag` value can be used with `UpdatePolicy()` to update a
        /// `Policy` during read-modify-write.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy. See `Policy` for naming requirements.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(PolicyName name, st::CancellationToken cancellationToken) =>
            GetPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging
        /// `Policies` in the resource hierarchy and evaluating conditions. The
        /// returned `Policy` will not have an `etag` or `condition` set because it is
        /// a computed `Policy` across multiple resources.
        /// Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
        /// not be expanded.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetEffectivePolicy(GetEffectivePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging
        /// `Policies` in the resource hierarchy and evaluating conditions. The
        /// returned `Policy` will not have an `etag` or `condition` set because it is
        /// a computed `Policy` across multiple resources.
        /// Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
        /// not be expanded.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetEffectivePolicyAsync(GetEffectivePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging
        /// `Policies` in the resource hierarchy and evaluating conditions. The
        /// returned `Policy` will not have an `etag` or `condition` set because it is
        /// a computed `Policy` across multiple resources.
        /// Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
        /// not be expanded.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetEffectivePolicyAsync(GetEffectivePolicyRequest request, st::CancellationToken cancellationToken) =>
            GetEffectivePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging
        /// `Policies` in the resource hierarchy and evaluating conditions. The
        /// returned `Policy` will not have an `etag` or `condition` set because it is
        /// a computed `Policy` across multiple resources.
        /// Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
        /// not be expanded.
        /// </summary>
        /// <param name="name">
        /// Required. The effective policy to compute. See `Policy` for naming rules.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetEffectivePolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectivePolicy(new GetEffectivePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging
        /// `Policies` in the resource hierarchy and evaluating conditions. The
        /// returned `Policy` will not have an `etag` or `condition` set because it is
        /// a computed `Policy` across multiple resources.
        /// Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
        /// not be expanded.
        /// </summary>
        /// <param name="name">
        /// Required. The effective policy to compute. See `Policy` for naming rules.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetEffectivePolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectivePolicyAsync(new GetEffectivePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging
        /// `Policies` in the resource hierarchy and evaluating conditions. The
        /// returned `Policy` will not have an `etag` or `condition` set because it is
        /// a computed `Policy` across multiple resources.
        /// Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
        /// not be expanded.
        /// </summary>
        /// <param name="name">
        /// Required. The effective policy to compute. See `Policy` for naming rules.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetEffectivePolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetEffectivePolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging
        /// `Policies` in the resource hierarchy and evaluating conditions. The
        /// returned `Policy` will not have an `etag` or `condition` set because it is
        /// a computed `Policy` across multiple resources.
        /// Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
        /// not be expanded.
        /// </summary>
        /// <param name="name">
        /// Required. The effective policy to compute. See `Policy` for naming rules.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetEffectivePolicy(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectivePolicy(new GetEffectivePolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging
        /// `Policies` in the resource hierarchy and evaluating conditions. The
        /// returned `Policy` will not have an `etag` or `condition` set because it is
        /// a computed `Policy` across multiple resources.
        /// Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
        /// not be expanded.
        /// </summary>
        /// <param name="name">
        /// Required. The effective policy to compute. See `Policy` for naming rules.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetEffectivePolicyAsync(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectivePolicyAsync(new GetEffectivePolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging
        /// `Policies` in the resource hierarchy and evaluating conditions. The
        /// returned `Policy` will not have an `etag` or `condition` set because it is
        /// a computed `Policy` across multiple resources.
        /// Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
        /// not be expanded.
        /// </summary>
        /// <param name="name">
        /// Required. The effective policy to compute. See `Policy` for naming rules.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetEffectivePolicyAsync(PolicyName name, st::CancellationToken cancellationToken) =>
            GetEffectivePolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy CreatePolicy(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(CreatePolicyRequest request, st::CancellationToken cancellationToken) =>
            CreatePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy CreatePolicy(string parent, Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicy(new CreatePolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(string parent, Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyAsync(new CreatePolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(string parent, Policy policy, st::CancellationToken cancellationToken) =>
            CreatePolicyAsync(parent, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy CreatePolicy(gagr::ProjectName parent, Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicy(new CreatePolicyRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(gagr::ProjectName parent, Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyAsync(new CreatePolicyRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(gagr::ProjectName parent, Policy policy, st::CancellationToken cancellationToken) =>
            CreatePolicyAsync(parent, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy CreatePolicy(gagr::FolderName parent, Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicy(new CreatePolicyRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(gagr::FolderName parent, Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyAsync(new CreatePolicyRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(gagr::FolderName parent, Policy policy, st::CancellationToken cancellationToken) =>
            CreatePolicyAsync(parent, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy CreatePolicy(gagr::OrganizationName parent, Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicy(new CreatePolicyRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(gagr::OrganizationName parent, Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyAsync(new CreatePolicyRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that will parent the new Policy. Must be in one of the
        /// following forms:
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
        /// </param>
        /// <param name="policy">
        /// Required. `Policy` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(gagr::OrganizationName parent, Policy policy, st::CancellationToken cancellationToken) =>
            CreatePolicyAsync(parent, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or the policy do not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the policy
        /// 
        /// Note: the supplied policy will perform a full overwrite of all
        /// fields.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy UpdatePolicy(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or the policy do not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the policy
        /// 
        /// Note: the supplied policy will perform a full overwrite of all
        /// fields.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or the policy do not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the policy
        /// 
        /// Note: the supplied policy will perform a full overwrite of all
        /// fields.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(UpdatePolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdatePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or the policy do not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the policy
        /// 
        /// Note: the supplied policy will perform a full overwrite of all
        /// fields.
        /// </summary>
        /// <param name="policy">
        /// Required. `Policy` to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy UpdatePolicy(Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePolicy(new UpdatePolicyRequest
            {
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or the policy do not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the policy
        /// 
        /// Note: the supplied policy will perform a full overwrite of all
        /// fields.
        /// </summary>
        /// <param name="policy">
        /// Required. `Policy` to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePolicyAsync(new UpdatePolicyRequest
            {
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or the policy do not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the policy
        /// 
        /// Note: the supplied policy will perform a full overwrite of all
        /// fields.
        /// </summary>
        /// <param name="policy">
        /// Required. `Policy` to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(Policy policy, st::CancellationToken cancellationToken) =>
            UpdatePolicyAsync(policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or Org Policy does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePolicy(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or Org Policy does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or Org Policy does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(DeletePolicyRequest request, st::CancellationToken cancellationToken) =>
            DeletePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or Org Policy does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the policy to delete.
        /// See `Policy` for naming rules.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicy(new DeletePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or Org Policy does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the policy to delete.
        /// See `Policy` for naming rules.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyAsync(new DeletePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or Org Policy does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the policy to delete.
        /// See `Policy` for naming rules.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or Org Policy does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the policy to delete.
        /// See `Policy` for naming rules.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePolicy(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicy(new DeletePolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or Org Policy does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the policy to delete.
        /// See `Policy` for naming rules.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyAsync(new DeletePolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or Org Policy does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the policy to delete.
        /// See `Policy` for naming rules.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(PolicyName name, st::CancellationToken cancellationToken) =>
            DeletePolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>OrgPolicy client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// An interface for managing organization policies.
    /// 
    /// The Cloud Org Policy service provides a simple mechanism for organizations to
    /// restrict the allowed configurations across their entire Cloud Resource
    /// hierarchy.
    /// 
    /// You can use a `policy` to configure restrictions in Cloud resources. For
    /// example, you can enforce a `policy` that restricts which Google
    /// Cloud Platform APIs can be activated in a certain part of your resource
    /// hierarchy, or prevents serial port access to VM instances in a particular
    /// folder.
    /// 
    /// `Policies` are inherited down through the resource hierarchy. A `policy`
    /// applied to a parent resource automatically applies to all its child resources
    /// unless overridden with a `policy` lower in the hierarchy.
    /// 
    /// A `constraint` defines an aspect of a resource's configuration that can be
    /// controlled by an organization's policy administrator. `Policies` are a
    /// collection of `constraints` that defines their allowable configuration on a
    /// particular resource and its child resources.
    /// </remarks>
    public sealed partial class OrgPolicyClientImpl : OrgPolicyClient
    {
        private readonly gaxgrpc::ApiCall<ListConstraintsRequest, ListConstraintsResponse> _callListConstraints;

        private readonly gaxgrpc::ApiCall<ListPoliciesRequest, ListPoliciesResponse> _callListPolicies;

        private readonly gaxgrpc::ApiCall<GetPolicyRequest, Policy> _callGetPolicy;

        private readonly gaxgrpc::ApiCall<GetEffectivePolicyRequest, Policy> _callGetEffectivePolicy;

        private readonly gaxgrpc::ApiCall<CreatePolicyRequest, Policy> _callCreatePolicy;

        private readonly gaxgrpc::ApiCall<UpdatePolicyRequest, Policy> _callUpdatePolicy;

        private readonly gaxgrpc::ApiCall<DeletePolicyRequest, wkt::Empty> _callDeletePolicy;

        /// <summary>
        /// Constructs a client wrapper for the OrgPolicy service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OrgPolicySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OrgPolicyClientImpl(OrgPolicy.OrgPolicyClient grpcClient, OrgPolicySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OrgPolicySettings effectiveSettings = settings ?? OrgPolicySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callListConstraints = clientHelper.BuildApiCall<ListConstraintsRequest, ListConstraintsResponse>("ListConstraints", grpcClient.ListConstraintsAsync, grpcClient.ListConstraints, effectiveSettings.ListConstraintsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConstraints);
            Modify_ListConstraintsApiCall(ref _callListConstraints);
            _callListPolicies = clientHelper.BuildApiCall<ListPoliciesRequest, ListPoliciesResponse>("ListPolicies", grpcClient.ListPoliciesAsync, grpcClient.ListPolicies, effectiveSettings.ListPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPolicies);
            Modify_ListPoliciesApiCall(ref _callListPolicies);
            _callGetPolicy = clientHelper.BuildApiCall<GetPolicyRequest, Policy>("GetPolicy", grpcClient.GetPolicyAsync, grpcClient.GetPolicy, effectiveSettings.GetPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPolicy);
            Modify_GetPolicyApiCall(ref _callGetPolicy);
            _callGetEffectivePolicy = clientHelper.BuildApiCall<GetEffectivePolicyRequest, Policy>("GetEffectivePolicy", grpcClient.GetEffectivePolicyAsync, grpcClient.GetEffectivePolicy, effectiveSettings.GetEffectivePolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEffectivePolicy);
            Modify_GetEffectivePolicyApiCall(ref _callGetEffectivePolicy);
            _callCreatePolicy = clientHelper.BuildApiCall<CreatePolicyRequest, Policy>("CreatePolicy", grpcClient.CreatePolicyAsync, grpcClient.CreatePolicy, effectiveSettings.CreatePolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePolicy);
            Modify_CreatePolicyApiCall(ref _callCreatePolicy);
            _callUpdatePolicy = clientHelper.BuildApiCall<UpdatePolicyRequest, Policy>("UpdatePolicy", grpcClient.UpdatePolicyAsync, grpcClient.UpdatePolicy, effectiveSettings.UpdatePolicySettings).WithGoogleRequestParam("policy.name", request => request.Policy?.Name);
            Modify_ApiCall(ref _callUpdatePolicy);
            Modify_UpdatePolicyApiCall(ref _callUpdatePolicy);
            _callDeletePolicy = clientHelper.BuildApiCall<DeletePolicyRequest, wkt::Empty>("DeletePolicy", grpcClient.DeletePolicyAsync, grpcClient.DeletePolicy, effectiveSettings.DeletePolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePolicy);
            Modify_DeletePolicyApiCall(ref _callDeletePolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListConstraintsApiCall(ref gaxgrpc::ApiCall<ListConstraintsRequest, ListConstraintsResponse> call);

        partial void Modify_ListPoliciesApiCall(ref gaxgrpc::ApiCall<ListPoliciesRequest, ListPoliciesResponse> call);

        partial void Modify_GetPolicyApiCall(ref gaxgrpc::ApiCall<GetPolicyRequest, Policy> call);

        partial void Modify_GetEffectivePolicyApiCall(ref gaxgrpc::ApiCall<GetEffectivePolicyRequest, Policy> call);

        partial void Modify_CreatePolicyApiCall(ref gaxgrpc::ApiCall<CreatePolicyRequest, Policy> call);

        partial void Modify_UpdatePolicyApiCall(ref gaxgrpc::ApiCall<UpdatePolicyRequest, Policy> call);

        partial void Modify_DeletePolicyApiCall(ref gaxgrpc::ApiCall<DeletePolicyRequest, wkt::Empty> call);

        partial void OnConstruction(OrgPolicy.OrgPolicyClient grpcClient, OrgPolicySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OrgPolicy client</summary>
        public override OrgPolicy.OrgPolicyClient GrpcClient { get; }

        partial void Modify_ListConstraintsRequest(ref ListConstraintsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPoliciesRequest(ref ListPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPolicyRequest(ref GetPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEffectivePolicyRequest(ref GetEffectivePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePolicyRequest(ref CreatePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePolicyRequest(ref UpdatePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePolicyRequest(ref DeletePolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Constraint"/> resources.</returns>
        public override gax::PagedEnumerable<ListConstraintsResponse, Constraint> ListConstraints(ListConstraintsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConstraintsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConstraintsRequest, ListConstraintsResponse, Constraint>(_callListConstraints, request, callSettings);
        }

        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Constraint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConstraintsResponse, Constraint> ListConstraintsAsync(ListConstraintsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConstraintsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConstraintsRequest, ListConstraintsResponse, Constraint>(_callListConstraints, request, callSettings);
        }

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public override gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPoliciesRequest, ListPoliciesResponse, Policy>(_callListPolicies, request, callSettings);
        }

        /// <summary>
        /// Retrieves all of the `Policies` that exist on a particular resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPoliciesRequest, ListPoliciesResponse, Policy>(_callListPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets a `Policy` on a resource.
        /// 
        /// If no `Policy` is set on the resource, NOT_FOUND is returned. The
        /// `etag` value can be used with `UpdatePolicy()` to update a
        /// `Policy` during read-modify-write.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetPolicy(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyRequest(ref request, ref callSettings);
            return _callGetPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a `Policy` on a resource.
        /// 
        /// If no `Policy` is set on the resource, NOT_FOUND is returned. The
        /// `etag` value can be used with `UpdatePolicy()` to update a
        /// `Policy` during read-modify-write.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyRequest(ref request, ref callSettings);
            return _callGetPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging
        /// `Policies` in the resource hierarchy and evaluating conditions. The
        /// returned `Policy` will not have an `etag` or `condition` set because it is
        /// a computed `Policy` across multiple resources.
        /// Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
        /// not be expanded.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetEffectivePolicy(GetEffectivePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEffectivePolicyRequest(ref request, ref callSettings);
            return _callGetEffectivePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging
        /// `Policies` in the resource hierarchy and evaluating conditions. The
        /// returned `Policy` will not have an `etag` or `condition` set because it is
        /// a computed `Policy` across multiple resources.
        /// Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
        /// not be expanded.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetEffectivePolicyAsync(GetEffectivePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEffectivePolicyRequest(ref request, ref callSettings);
            return _callGetEffectivePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy CreatePolicy(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyRequest(ref request, ref callSettings);
            return _callCreatePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
        /// policy already exists on the given Cloud resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> CreatePolicyAsync(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyRequest(ref request, ref callSettings);
            return _callCreatePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or the policy do not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the policy
        /// 
        /// Note: the supplied policy will perform a full overwrite of all
        /// fields.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy UpdatePolicy(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyRequest(ref request, ref callSettings);
            return _callUpdatePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or the policy do not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the policy
        /// 
        /// Note: the supplied policy will perform a full overwrite of all
        /// fields.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> UpdatePolicyAsync(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyRequest(ref request, ref callSettings);
            return _callUpdatePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or Org Policy does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePolicy(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyRequest(ref request, ref callSettings);
            _callDeletePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Policy.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// constraint or Org Policy does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePolicyAsync(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyRequest(ref request, ref callSettings);
            return _callDeletePolicy.Async(request, callSettings);
        }
    }

    public partial class ListConstraintsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConstraintsResponse : gaxgrpc::IPageResponse<Constraint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Constraint> GetEnumerator() => Constraints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPoliciesResponse : gaxgrpc::IPageResponse<Policy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Policy> GetEnumerator() => Policies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
