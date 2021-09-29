// Copyright 2021 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
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

namespace Google.Cloud.OsConfig.V1Alpha
{
    /// <summary>Settings for <see cref="OsConfigZonalServiceClient"/> instances.</summary>
    public sealed partial class OsConfigZonalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OsConfigZonalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OsConfigZonalServiceSettings"/>.</returns>
        public static OsConfigZonalServiceSettings GetDefault() => new OsConfigZonalServiceSettings();

        /// <summary>Constructs a new <see cref="OsConfigZonalServiceSettings"/> object with default settings.</summary>
        public OsConfigZonalServiceSettings()
        {
        }

        private OsConfigZonalServiceSettings(OsConfigZonalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateOSPolicyAssignmentSettings = existing.CreateOSPolicyAssignmentSettings;
            CreateOSPolicyAssignmentOperationsSettings = existing.CreateOSPolicyAssignmentOperationsSettings.Clone();
            UpdateOSPolicyAssignmentSettings = existing.UpdateOSPolicyAssignmentSettings;
            UpdateOSPolicyAssignmentOperationsSettings = existing.UpdateOSPolicyAssignmentOperationsSettings.Clone();
            GetOSPolicyAssignmentSettings = existing.GetOSPolicyAssignmentSettings;
            ListOSPolicyAssignmentsSettings = existing.ListOSPolicyAssignmentsSettings;
            ListOSPolicyAssignmentRevisionsSettings = existing.ListOSPolicyAssignmentRevisionsSettings;
            DeleteOSPolicyAssignmentSettings = existing.DeleteOSPolicyAssignmentSettings;
            DeleteOSPolicyAssignmentOperationsSettings = existing.DeleteOSPolicyAssignmentOperationsSettings.Clone();
            GetInstanceOSPoliciesComplianceSettings = existing.GetInstanceOSPoliciesComplianceSettings;
            ListInstanceOSPoliciesCompliancesSettings = existing.ListInstanceOSPoliciesCompliancesSettings;
            GetInventorySettings = existing.GetInventorySettings;
            ListInventoriesSettings = existing.ListInventoriesSettings;
            GetVulnerabilityReportSettings = existing.GetVulnerabilityReportSettings;
            ListVulnerabilityReportsSettings = existing.ListVulnerabilityReportsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OsConfigZonalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.CreateOSPolicyAssignment</c> and
        /// <c>OsConfigZonalServiceClient.CreateOSPolicyAssignmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateOSPolicyAssignmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OsConfigZonalServiceClient.CreateOSPolicyAssignment</c> and
        /// <c>OsConfigZonalServiceClient.CreateOSPolicyAssignmentAsync</c>.
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
        public lro::OperationsSettings CreateOSPolicyAssignmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.UpdateOSPolicyAssignment</c> and
        /// <c>OsConfigZonalServiceClient.UpdateOSPolicyAssignmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateOSPolicyAssignmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OsConfigZonalServiceClient.UpdateOSPolicyAssignment</c> and
        /// <c>OsConfigZonalServiceClient.UpdateOSPolicyAssignmentAsync</c>.
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
        public lro::OperationsSettings UpdateOSPolicyAssignmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.GetOSPolicyAssignment</c> and
        /// <c>OsConfigZonalServiceClient.GetOSPolicyAssignmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOSPolicyAssignmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.ListOSPolicyAssignments</c> and
        /// <c>OsConfigZonalServiceClient.ListOSPolicyAssignmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOSPolicyAssignmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.ListOSPolicyAssignmentRevisions</c> and
        /// <c>OsConfigZonalServiceClient.ListOSPolicyAssignmentRevisionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOSPolicyAssignmentRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.DeleteOSPolicyAssignment</c> and
        /// <c>OsConfigZonalServiceClient.DeleteOSPolicyAssignmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteOSPolicyAssignmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OsConfigZonalServiceClient.DeleteOSPolicyAssignment</c> and
        /// <c>OsConfigZonalServiceClient.DeleteOSPolicyAssignmentAsync</c>.
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
        public lro::OperationsSettings DeleteOSPolicyAssignmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.GetInstanceOSPoliciesCompliance</c> and
        /// <c>OsConfigZonalServiceClient.GetInstanceOSPoliciesComplianceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceOSPoliciesComplianceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.ListInstanceOSPoliciesCompliances</c> and
        /// <c>OsConfigZonalServiceClient.ListInstanceOSPoliciesCompliancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstanceOSPoliciesCompliancesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.GetInventory</c> and <c>OsConfigZonalServiceClient.GetInventoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInventorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.ListInventories</c> and <c>OsConfigZonalServiceClient.ListInventoriesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInventoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.GetVulnerabilityReport</c> and
        /// <c>OsConfigZonalServiceClient.GetVulnerabilityReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVulnerabilityReportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.ListVulnerabilityReports</c> and
        /// <c>OsConfigZonalServiceClient.ListVulnerabilityReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVulnerabilityReportsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OsConfigZonalServiceSettings"/> object.</returns>
        public OsConfigZonalServiceSettings Clone() => new OsConfigZonalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OsConfigZonalServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class OsConfigZonalServiceClientBuilder : gaxgrpc::ClientBuilderBase<OsConfigZonalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OsConfigZonalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OsConfigZonalServiceClientBuilder()
        {
            UseJwtAccessWithScopes = OsConfigZonalServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref OsConfigZonalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OsConfigZonalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OsConfigZonalServiceClient Build()
        {
            OsConfigZonalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OsConfigZonalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OsConfigZonalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OsConfigZonalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OsConfigZonalServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<OsConfigZonalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OsConfigZonalServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => OsConfigZonalServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => OsConfigZonalServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OsConfigZonalServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>OsConfigZonalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Zonal OS Config API
    /// 
    /// The OS Config service is the server-side component that allows users to
    /// manage package installations and patch jobs for Compute Engine VM instances.
    /// </remarks>
    public abstract partial class OsConfigZonalServiceClient
    {
        /// <summary>
        /// The default endpoint for the OsConfigZonalService service, which is a host of "osconfig.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "osconfig.googleapis.com:443";

        /// <summary>The default OsConfigZonalService scopes.</summary>
        /// <remarks>
        /// The default OsConfigZonalService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
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
        /// Asynchronously creates a <see cref="OsConfigZonalServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="OsConfigZonalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OsConfigZonalServiceClient"/>.</returns>
        public static stt::Task<OsConfigZonalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OsConfigZonalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OsConfigZonalServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="OsConfigZonalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OsConfigZonalServiceClient"/>.</returns>
        public static OsConfigZonalServiceClient Create() => new OsConfigZonalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OsConfigZonalServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OsConfigZonalServiceSettings"/>.</param>
        /// <returns>The created <see cref="OsConfigZonalServiceClient"/>.</returns>
        internal static OsConfigZonalServiceClient Create(grpccore::CallInvoker callInvoker, OsConfigZonalServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OsConfigZonalService.OsConfigZonalServiceClient grpcClient = new OsConfigZonalService.OsConfigZonalServiceClient(callInvoker);
            return new OsConfigZonalServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC OsConfigZonalService client</summary>
        public virtual OsConfigZonalService.OsConfigZonalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create an OS policy assignment.
        /// 
        /// This method also creates the first revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> CreateOSPolicyAssignment(CreateOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an OS policy assignment.
        /// 
        /// This method also creates the first revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> CreateOSPolicyAssignmentAsync(CreateOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an OS policy assignment.
        /// 
        /// This method also creates the first revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> CreateOSPolicyAssignmentAsync(CreateOSPolicyAssignmentRequest request, st::CancellationToken cancellationToken) =>
            CreateOSPolicyAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateOSPolicyAssignment</c>.</summary>
        public virtual lro::OperationsClient CreateOSPolicyAssignmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateOSPolicyAssignment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> PollOnceCreateOSPolicyAssignment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOSPolicyAssignmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateOSPolicyAssignment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> PollOnceCreateOSPolicyAssignmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOSPolicyAssignmentOperationsClient, callSettings);

        /// <summary>
        /// Create an OS policy assignment.
        /// 
        /// This method also creates the first revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name in the form:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="osPolicyAssignment">
        /// Required. The OS policy assignment to be created.
        /// </param>
        /// <param name="osPolicyAssignmentId">
        /// Required. The logical name of the OS policy assignment in the project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> CreateOSPolicyAssignment(string parent, OSPolicyAssignment osPolicyAssignment, string osPolicyAssignmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOSPolicyAssignment(new CreateOSPolicyAssignmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OsPolicyAssignment = gax::GaxPreconditions.CheckNotNull(osPolicyAssignment, nameof(osPolicyAssignment)),
                OsPolicyAssignmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(osPolicyAssignmentId, nameof(osPolicyAssignmentId)),
            }, callSettings);

        /// <summary>
        /// Create an OS policy assignment.
        /// 
        /// This method also creates the first revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name in the form:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="osPolicyAssignment">
        /// Required. The OS policy assignment to be created.
        /// </param>
        /// <param name="osPolicyAssignmentId">
        /// Required. The logical name of the OS policy assignment in the project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> CreateOSPolicyAssignmentAsync(string parent, OSPolicyAssignment osPolicyAssignment, string osPolicyAssignmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOSPolicyAssignmentAsync(new CreateOSPolicyAssignmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OsPolicyAssignment = gax::GaxPreconditions.CheckNotNull(osPolicyAssignment, nameof(osPolicyAssignment)),
                OsPolicyAssignmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(osPolicyAssignmentId, nameof(osPolicyAssignmentId)),
            }, callSettings);

        /// <summary>
        /// Create an OS policy assignment.
        /// 
        /// This method also creates the first revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name in the form:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="osPolicyAssignment">
        /// Required. The OS policy assignment to be created.
        /// </param>
        /// <param name="osPolicyAssignmentId">
        /// Required. The logical name of the OS policy assignment in the project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> CreateOSPolicyAssignmentAsync(string parent, OSPolicyAssignment osPolicyAssignment, string osPolicyAssignmentId, st::CancellationToken cancellationToken) =>
            CreateOSPolicyAssignmentAsync(parent, osPolicyAssignment, osPolicyAssignmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an OS policy assignment.
        /// 
        /// This method also creates the first revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name in the form:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="osPolicyAssignment">
        /// Required. The OS policy assignment to be created.
        /// </param>
        /// <param name="osPolicyAssignmentId">
        /// Required. The logical name of the OS policy assignment in the project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> CreateOSPolicyAssignment(gagr::LocationName parent, OSPolicyAssignment osPolicyAssignment, string osPolicyAssignmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOSPolicyAssignment(new CreateOSPolicyAssignmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OsPolicyAssignment = gax::GaxPreconditions.CheckNotNull(osPolicyAssignment, nameof(osPolicyAssignment)),
                OsPolicyAssignmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(osPolicyAssignmentId, nameof(osPolicyAssignmentId)),
            }, callSettings);

        /// <summary>
        /// Create an OS policy assignment.
        /// 
        /// This method also creates the first revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name in the form:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="osPolicyAssignment">
        /// Required. The OS policy assignment to be created.
        /// </param>
        /// <param name="osPolicyAssignmentId">
        /// Required. The logical name of the OS policy assignment in the project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> CreateOSPolicyAssignmentAsync(gagr::LocationName parent, OSPolicyAssignment osPolicyAssignment, string osPolicyAssignmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOSPolicyAssignmentAsync(new CreateOSPolicyAssignmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OsPolicyAssignment = gax::GaxPreconditions.CheckNotNull(osPolicyAssignment, nameof(osPolicyAssignment)),
                OsPolicyAssignmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(osPolicyAssignmentId, nameof(osPolicyAssignmentId)),
            }, callSettings);

        /// <summary>
        /// Create an OS policy assignment.
        /// 
        /// This method also creates the first revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name in the form:
        /// projects/{project}/locations/{location}
        /// </param>
        /// <param name="osPolicyAssignment">
        /// Required. The OS policy assignment to be created.
        /// </param>
        /// <param name="osPolicyAssignmentId">
        /// Required. The logical name of the OS policy assignment in the project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> CreateOSPolicyAssignmentAsync(gagr::LocationName parent, OSPolicyAssignment osPolicyAssignment, string osPolicyAssignmentId, st::CancellationToken cancellationToken) =>
            CreateOSPolicyAssignmentAsync(parent, osPolicyAssignment, osPolicyAssignmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update an existing OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> UpdateOSPolicyAssignment(UpdateOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an existing OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> UpdateOSPolicyAssignmentAsync(UpdateOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an existing OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> UpdateOSPolicyAssignmentAsync(UpdateOSPolicyAssignmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateOSPolicyAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateOSPolicyAssignment</c>.</summary>
        public virtual lro::OperationsClient UpdateOSPolicyAssignmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateOSPolicyAssignment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> PollOnceUpdateOSPolicyAssignment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOSPolicyAssignmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateOSPolicyAssignment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> PollOnceUpdateOSPolicyAssignmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOSPolicyAssignmentOperationsClient, callSettings);

        /// <summary>
        /// Update an existing OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="osPolicyAssignment">
        /// Required. The updated OS policy assignment.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that controls which fields of the assignment should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> UpdateOSPolicyAssignment(OSPolicyAssignment osPolicyAssignment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOSPolicyAssignment(new UpdateOSPolicyAssignmentRequest
            {
                OsPolicyAssignment = gax::GaxPreconditions.CheckNotNull(osPolicyAssignment, nameof(osPolicyAssignment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an existing OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="osPolicyAssignment">
        /// Required. The updated OS policy assignment.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that controls which fields of the assignment should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> UpdateOSPolicyAssignmentAsync(OSPolicyAssignment osPolicyAssignment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOSPolicyAssignmentAsync(new UpdateOSPolicyAssignmentRequest
            {
                OsPolicyAssignment = gax::GaxPreconditions.CheckNotNull(osPolicyAssignment, nameof(osPolicyAssignment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an existing OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="osPolicyAssignment">
        /// Required. The updated OS policy assignment.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that controls which fields of the assignment should be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> UpdateOSPolicyAssignmentAsync(OSPolicyAssignment osPolicyAssignment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateOSPolicyAssignmentAsync(osPolicyAssignment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve an existing OS policy assignment.
        /// 
        /// This method always returns the latest revision. In order to retrieve a
        /// previous revision of the assignment, also provide the revision ID in the
        /// `name` parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OSPolicyAssignment GetOSPolicyAssignment(GetOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve an existing OS policy assignment.
        /// 
        /// This method always returns the latest revision. In order to retrieve a
        /// previous revision of the assignment, also provide the revision ID in the
        /// `name` parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OSPolicyAssignment> GetOSPolicyAssignmentAsync(GetOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve an existing OS policy assignment.
        /// 
        /// This method always returns the latest revision. In order to retrieve a
        /// previous revision of the assignment, also provide the revision ID in the
        /// `name` parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OSPolicyAssignment> GetOSPolicyAssignmentAsync(GetOSPolicyAssignmentRequest request, st::CancellationToken cancellationToken) =>
            GetOSPolicyAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve an existing OS policy assignment.
        /// 
        /// This method always returns the latest revision. In order to retrieve a
        /// previous revision of the assignment, also provide the revision ID in the
        /// `name` parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of OS policy assignment.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}@{revisionId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OSPolicyAssignment GetOSPolicyAssignment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOSPolicyAssignment(new GetOSPolicyAssignmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an existing OS policy assignment.
        /// 
        /// This method always returns the latest revision. In order to retrieve a
        /// previous revision of the assignment, also provide the revision ID in the
        /// `name` parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of OS policy assignment.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}@{revisionId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OSPolicyAssignment> GetOSPolicyAssignmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOSPolicyAssignmentAsync(new GetOSPolicyAssignmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an existing OS policy assignment.
        /// 
        /// This method always returns the latest revision. In order to retrieve a
        /// previous revision of the assignment, also provide the revision ID in the
        /// `name` parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of OS policy assignment.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}@{revisionId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OSPolicyAssignment> GetOSPolicyAssignmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetOSPolicyAssignmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve an existing OS policy assignment.
        /// 
        /// This method always returns the latest revision. In order to retrieve a
        /// previous revision of the assignment, also provide the revision ID in the
        /// `name` parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of OS policy assignment.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}@{revisionId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OSPolicyAssignment GetOSPolicyAssignment(OSPolicyAssignmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOSPolicyAssignment(new GetOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an existing OS policy assignment.
        /// 
        /// This method always returns the latest revision. In order to retrieve a
        /// previous revision of the assignment, also provide the revision ID in the
        /// `name` parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of OS policy assignment.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}@{revisionId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OSPolicyAssignment> GetOSPolicyAssignmentAsync(OSPolicyAssignmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOSPolicyAssignmentAsync(new GetOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an existing OS policy assignment.
        /// 
        /// This method always returns the latest revision. In order to retrieve a
        /// previous revision of the assignment, also provide the revision ID in the
        /// `name` parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of OS policy assignment.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}@{revisionId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OSPolicyAssignment> GetOSPolicyAssignmentAsync(OSPolicyAssignmentName name, st::CancellationToken cancellationToken) =>
            GetOSPolicyAssignmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List the OS policy assignments under the parent resource.
        /// 
        /// For each OS policy assignment, the latest revision is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> ListOSPolicyAssignments(ListOSPolicyAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the OS policy assignments under the parent resource.
        /// 
        /// For each OS policy assignment, the latest revision is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> ListOSPolicyAssignmentsAsync(ListOSPolicyAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the OS policy assignments under the parent resource.
        /// 
        /// For each OS policy assignment, the latest revision is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> ListOSPolicyAssignments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListOSPolicyAssignments(new ListOSPolicyAssignmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List the OS policy assignments under the parent resource.
        /// 
        /// For each OS policy assignment, the latest revision is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> ListOSPolicyAssignmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListOSPolicyAssignmentsAsync(new ListOSPolicyAssignmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List the OS policy assignments under the parent resource.
        /// 
        /// For each OS policy assignment, the latest revision is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> ListOSPolicyAssignments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListOSPolicyAssignments(new ListOSPolicyAssignmentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List the OS policy assignments under the parent resource.
        /// 
        /// For each OS policy assignment, the latest revision is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> ListOSPolicyAssignmentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListOSPolicyAssignmentsAsync(new ListOSPolicyAssignmentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List the OS policy assignment revisions for a given OS policy assignment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> ListOSPolicyAssignmentRevisions(ListOSPolicyAssignmentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the OS policy assignment revisions for a given OS policy assignment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> ListOSPolicyAssignmentRevisionsAsync(ListOSPolicyAssignmentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the OS policy assignment revisions for a given OS policy assignment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OS policy assignment to list revisions for.
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
        /// <returns>A pageable sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> ListOSPolicyAssignmentRevisions(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListOSPolicyAssignmentRevisions(new ListOSPolicyAssignmentRevisionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List the OS policy assignment revisions for a given OS policy assignment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OS policy assignment to list revisions for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> ListOSPolicyAssignmentRevisionsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListOSPolicyAssignmentRevisionsAsync(new ListOSPolicyAssignmentRevisionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List the OS policy assignment revisions for a given OS policy assignment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OS policy assignment to list revisions for.
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
        /// <returns>A pageable sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> ListOSPolicyAssignmentRevisions(OSPolicyAssignmentName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListOSPolicyAssignmentRevisions(new ListOSPolicyAssignmentRevisionsRequest
            {
                OSPolicyAssignmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List the OS policy assignment revisions for a given OS policy assignment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OS policy assignment to list revisions for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> ListOSPolicyAssignmentRevisionsAsync(OSPolicyAssignmentName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListOSPolicyAssignmentRevisionsAsync(new ListOSPolicyAssignmentRevisionsRequest
            {
                OSPolicyAssignmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Delete the OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// If the LRO completes and is not cancelled, all revisions associated with
        /// the OS policy assignment are deleted.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata> DeleteOSPolicyAssignment(DeleteOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// If the LRO completes and is not cancelled, all revisions associated with
        /// the OS policy assignment are deleted.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>> DeleteOSPolicyAssignmentAsync(DeleteOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// If the LRO completes and is not cancelled, all revisions associated with
        /// the OS policy assignment are deleted.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>> DeleteOSPolicyAssignmentAsync(DeleteOSPolicyAssignmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteOSPolicyAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteOSPolicyAssignment</c>.</summary>
        public virtual lro::OperationsClient DeleteOSPolicyAssignmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteOSPolicyAssignment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata> PollOnceDeleteOSPolicyAssignment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOSPolicyAssignmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteOSPolicyAssignment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>> PollOnceDeleteOSPolicyAssignmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOSPolicyAssignmentOperationsClient, callSettings);

        /// <summary>
        /// Delete the OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// If the LRO completes and is not cancelled, all revisions associated with
        /// the OS policy assignment are deleted.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OS policy assignment to be deleted
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata> DeleteOSPolicyAssignment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOSPolicyAssignment(new DeleteOSPolicyAssignmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// If the LRO completes and is not cancelled, all revisions associated with
        /// the OS policy assignment are deleted.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OS policy assignment to be deleted
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>> DeleteOSPolicyAssignmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOSPolicyAssignmentAsync(new DeleteOSPolicyAssignmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// If the LRO completes and is not cancelled, all revisions associated with
        /// the OS policy assignment are deleted.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OS policy assignment to be deleted
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>> DeleteOSPolicyAssignmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteOSPolicyAssignmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// If the LRO completes and is not cancelled, all revisions associated with
        /// the OS policy assignment are deleted.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OS policy assignment to be deleted
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata> DeleteOSPolicyAssignment(OSPolicyAssignmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOSPolicyAssignment(new DeleteOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// If the LRO completes and is not cancelled, all revisions associated with
        /// the OS policy assignment are deleted.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OS policy assignment to be deleted
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>> DeleteOSPolicyAssignmentAsync(OSPolicyAssignmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOSPolicyAssignmentAsync(new DeleteOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// If the LRO completes and is not cancelled, all revisions associated with
        /// the OS policy assignment are deleted.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OS policy assignment to be deleted
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>> DeleteOSPolicyAssignmentAsync(OSPolicyAssignmentName name, st::CancellationToken cancellationToken) =>
            DeleteOSPolicyAssignmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get OS policies compliance data for the specified Compute Engine VM
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceOSPoliciesCompliance GetInstanceOSPoliciesCompliance(GetInstanceOSPoliciesComplianceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get OS policies compliance data for the specified Compute Engine VM
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceOSPoliciesCompliance> GetInstanceOSPoliciesComplianceAsync(GetInstanceOSPoliciesComplianceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get OS policies compliance data for the specified Compute Engine VM
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceOSPoliciesCompliance> GetInstanceOSPoliciesComplianceAsync(GetInstanceOSPoliciesComplianceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceOSPoliciesComplianceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get OS policies compliance data for the specified Compute Engine VM
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for instance OS policies compliance resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}`
        /// 
        /// For `{project}`, either Compute Engine project-number or project-id can be
        /// provided.
        /// For `{instance}`, either Compute Engine VM instance-id or instance-name can
        /// be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceOSPoliciesCompliance GetInstanceOSPoliciesCompliance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceOSPoliciesCompliance(new GetInstanceOSPoliciesComplianceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get OS policies compliance data for the specified Compute Engine VM
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for instance OS policies compliance resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}`
        /// 
        /// For `{project}`, either Compute Engine project-number or project-id can be
        /// provided.
        /// For `{instance}`, either Compute Engine VM instance-id or instance-name can
        /// be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceOSPoliciesCompliance> GetInstanceOSPoliciesComplianceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceOSPoliciesComplianceAsync(new GetInstanceOSPoliciesComplianceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get OS policies compliance data for the specified Compute Engine VM
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for instance OS policies compliance resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}`
        /// 
        /// For `{project}`, either Compute Engine project-number or project-id can be
        /// provided.
        /// For `{instance}`, either Compute Engine VM instance-id or instance-name can
        /// be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceOSPoliciesCompliance> GetInstanceOSPoliciesComplianceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceOSPoliciesComplianceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get OS policies compliance data for the specified Compute Engine VM
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for instance OS policies compliance resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}`
        /// 
        /// For `{project}`, either Compute Engine project-number or project-id can be
        /// provided.
        /// For `{instance}`, either Compute Engine VM instance-id or instance-name can
        /// be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceOSPoliciesCompliance GetInstanceOSPoliciesCompliance(InstanceOSPoliciesComplianceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceOSPoliciesCompliance(new GetInstanceOSPoliciesComplianceRequest
            {
                InstanceOSPoliciesComplianceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get OS policies compliance data for the specified Compute Engine VM
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for instance OS policies compliance resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}`
        /// 
        /// For `{project}`, either Compute Engine project-number or project-id can be
        /// provided.
        /// For `{instance}`, either Compute Engine VM instance-id or instance-name can
        /// be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceOSPoliciesCompliance> GetInstanceOSPoliciesComplianceAsync(InstanceOSPoliciesComplianceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceOSPoliciesComplianceAsync(new GetInstanceOSPoliciesComplianceRequest
            {
                InstanceOSPoliciesComplianceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get OS policies compliance data for the specified Compute Engine VM
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for instance OS policies compliance resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}`
        /// 
        /// For `{project}`, either Compute Engine project-number or project-id can be
        /// provided.
        /// For `{instance}`, either Compute Engine VM instance-id or instance-name can
        /// be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceOSPoliciesCompliance> GetInstanceOSPoliciesComplianceAsync(InstanceOSPoliciesComplianceName name, st::CancellationToken cancellationToken) =>
            GetInstanceOSPoliciesComplianceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List OS policies compliance data for all Compute Engine VM instances in the
        /// specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceOSPoliciesCompliance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> ListInstanceOSPoliciesCompliances(ListInstanceOSPoliciesCompliancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List OS policies compliance data for all Compute Engine VM instances in the
        /// specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceOSPoliciesCompliance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> ListInstanceOSPoliciesCompliancesAsync(ListInstanceOSPoliciesCompliancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List OS policies compliance data for all Compute Engine VM instances in the
        /// specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// For `{project}`, either Compute Engine project-number or project-id can be
        /// provided.
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
        /// <returns>A pageable sequence of <see cref="InstanceOSPoliciesCompliance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> ListInstanceOSPoliciesCompliances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstanceOSPoliciesCompliances(new ListInstanceOSPoliciesCompliancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List OS policies compliance data for all Compute Engine VM instances in the
        /// specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// For `{project}`, either Compute Engine project-number or project-id can be
        /// provided.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceOSPoliciesCompliance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> ListInstanceOSPoliciesCompliancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstanceOSPoliciesCompliancesAsync(new ListInstanceOSPoliciesCompliancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List OS policies compliance data for all Compute Engine VM instances in the
        /// specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// For `{project}`, either Compute Engine project-number or project-id can be
        /// provided.
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
        /// <returns>A pageable sequence of <see cref="InstanceOSPoliciesCompliance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> ListInstanceOSPoliciesCompliances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstanceOSPoliciesCompliances(new ListInstanceOSPoliciesCompliancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List OS policies compliance data for all Compute Engine VM instances in the
        /// specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}`
        /// 
        /// For `{project}`, either Compute Engine project-number or project-id can be
        /// provided.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceOSPoliciesCompliance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> ListInstanceOSPoliciesCompliancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstanceOSPoliciesCompliancesAsync(new ListInstanceOSPoliciesCompliancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Inventory GetInventory(GetInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(GetInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(GetInventoryRequest request, st::CancellationToken cancellationToken) =>
            GetInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Inventory GetInventory(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInventory(new GetInventoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInventoryAsync(new GetInventoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetInventoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Inventory GetInventory(InventoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInventory(new GetInventoryRequest
            {
                InventoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(InventoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInventoryAsync(new GetInventoryRequest
            {
                InventoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(InventoryName name, st::CancellationToken cancellationToken) =>
            GetInventoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInventoriesResponse, Inventory> ListInventories(ListInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInventoriesResponse, Inventory> ListInventoriesAsync(ListInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be
        /// provided. For `{instance}`, only hyphen or dash character is supported to
        /// list inventories across VMs.
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
        /// <returns>A pageable sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInventoriesResponse, Inventory> ListInventories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInventories(new ListInventoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be
        /// provided. For `{instance}`, only hyphen or dash character is supported to
        /// list inventories across VMs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInventoriesResponse, Inventory> ListInventoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInventoriesAsync(new ListInventoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be
        /// provided. For `{instance}`, only hyphen or dash character is supported to
        /// list inventories across VMs.
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
        /// <returns>A pageable sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInventoriesResponse, Inventory> ListInventories(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInventories(new ListInventoriesRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be
        /// provided. For `{instance}`, only hyphen or dash character is supported to
        /// list inventories across VMs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInventoriesResponse, Inventory> ListInventoriesAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInventoriesAsync(new ListInventoriesRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VulnerabilityReport GetVulnerabilityReport(GetVulnerabilityReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(GetVulnerabilityReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(GetVulnerabilityReportRequest request, st::CancellationToken cancellationToken) =>
            GetVulnerabilityReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VulnerabilityReport GetVulnerabilityReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityReport(new GetVulnerabilityReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityReportAsync(new GetVulnerabilityReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(string name, st::CancellationToken cancellationToken) =>
            GetVulnerabilityReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VulnerabilityReport GetVulnerabilityReport(VulnerabilityReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityReport(new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(VulnerabilityReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityReportAsync(new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(VulnerabilityReportName name, st::CancellationToken cancellationToken) =>
            GetVulnerabilityReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReports(ListVulnerabilityReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReportsAsync(ListVulnerabilityReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, only `-` character is supported to list vulnerability
        /// reports across VMs.
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
        /// <returns>A pageable sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReports(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVulnerabilityReports(new ListVulnerabilityReportsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, only `-` character is supported to list vulnerability
        /// reports across VMs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReportsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVulnerabilityReportsAsync(new ListVulnerabilityReportsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, only `-` character is supported to list vulnerability
        /// reports across VMs.
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
        /// <returns>A pageable sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReports(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVulnerabilityReports(new ListVulnerabilityReportsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, only `-` character is supported to list vulnerability
        /// reports across VMs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReportsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVulnerabilityReportsAsync(new ListVulnerabilityReportsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>OsConfigZonalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Zonal OS Config API
    /// 
    /// The OS Config service is the server-side component that allows users to
    /// manage package installations and patch jobs for Compute Engine VM instances.
    /// </remarks>
    public sealed partial class OsConfigZonalServiceClientImpl : OsConfigZonalServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateOSPolicyAssignmentRequest, lro::Operation> _callCreateOSPolicyAssignment;

        private readonly gaxgrpc::ApiCall<UpdateOSPolicyAssignmentRequest, lro::Operation> _callUpdateOSPolicyAssignment;

        private readonly gaxgrpc::ApiCall<GetOSPolicyAssignmentRequest, OSPolicyAssignment> _callGetOSPolicyAssignment;

        private readonly gaxgrpc::ApiCall<ListOSPolicyAssignmentsRequest, ListOSPolicyAssignmentsResponse> _callListOSPolicyAssignments;

        private readonly gaxgrpc::ApiCall<ListOSPolicyAssignmentRevisionsRequest, ListOSPolicyAssignmentRevisionsResponse> _callListOSPolicyAssignmentRevisions;

        private readonly gaxgrpc::ApiCall<DeleteOSPolicyAssignmentRequest, lro::Operation> _callDeleteOSPolicyAssignment;

        private readonly gaxgrpc::ApiCall<GetInstanceOSPoliciesComplianceRequest, InstanceOSPoliciesCompliance> _callGetInstanceOSPoliciesCompliance;

        private readonly gaxgrpc::ApiCall<ListInstanceOSPoliciesCompliancesRequest, ListInstanceOSPoliciesCompliancesResponse> _callListInstanceOSPoliciesCompliances;

        private readonly gaxgrpc::ApiCall<GetInventoryRequest, Inventory> _callGetInventory;

        private readonly gaxgrpc::ApiCall<ListInventoriesRequest, ListInventoriesResponse> _callListInventories;

        private readonly gaxgrpc::ApiCall<GetVulnerabilityReportRequest, VulnerabilityReport> _callGetVulnerabilityReport;

        private readonly gaxgrpc::ApiCall<ListVulnerabilityReportsRequest, ListVulnerabilityReportsResponse> _callListVulnerabilityReports;

        /// <summary>
        /// Constructs a client wrapper for the OsConfigZonalService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OsConfigZonalServiceSettings"/> used within this client.</param>
        public OsConfigZonalServiceClientImpl(OsConfigZonalService.OsConfigZonalServiceClient grpcClient, OsConfigZonalServiceSettings settings)
        {
            GrpcClient = grpcClient;
            OsConfigZonalServiceSettings effectiveSettings = settings ?? OsConfigZonalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateOSPolicyAssignmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateOSPolicyAssignmentOperationsSettings);
            UpdateOSPolicyAssignmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateOSPolicyAssignmentOperationsSettings);
            DeleteOSPolicyAssignmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteOSPolicyAssignmentOperationsSettings);
            _callCreateOSPolicyAssignment = clientHelper.BuildApiCall<CreateOSPolicyAssignmentRequest, lro::Operation>(grpcClient.CreateOSPolicyAssignmentAsync, grpcClient.CreateOSPolicyAssignment, effectiveSettings.CreateOSPolicyAssignmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOSPolicyAssignment);
            Modify_CreateOSPolicyAssignmentApiCall(ref _callCreateOSPolicyAssignment);
            _callUpdateOSPolicyAssignment = clientHelper.BuildApiCall<UpdateOSPolicyAssignmentRequest, lro::Operation>(grpcClient.UpdateOSPolicyAssignmentAsync, grpcClient.UpdateOSPolicyAssignment, effectiveSettings.UpdateOSPolicyAssignmentSettings).WithGoogleRequestParam("os_policy_assignment.name", request => request.OsPolicyAssignment?.Name);
            Modify_ApiCall(ref _callUpdateOSPolicyAssignment);
            Modify_UpdateOSPolicyAssignmentApiCall(ref _callUpdateOSPolicyAssignment);
            _callGetOSPolicyAssignment = clientHelper.BuildApiCall<GetOSPolicyAssignmentRequest, OSPolicyAssignment>(grpcClient.GetOSPolicyAssignmentAsync, grpcClient.GetOSPolicyAssignment, effectiveSettings.GetOSPolicyAssignmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOSPolicyAssignment);
            Modify_GetOSPolicyAssignmentApiCall(ref _callGetOSPolicyAssignment);
            _callListOSPolicyAssignments = clientHelper.BuildApiCall<ListOSPolicyAssignmentsRequest, ListOSPolicyAssignmentsResponse>(grpcClient.ListOSPolicyAssignmentsAsync, grpcClient.ListOSPolicyAssignments, effectiveSettings.ListOSPolicyAssignmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOSPolicyAssignments);
            Modify_ListOSPolicyAssignmentsApiCall(ref _callListOSPolicyAssignments);
            _callListOSPolicyAssignmentRevisions = clientHelper.BuildApiCall<ListOSPolicyAssignmentRevisionsRequest, ListOSPolicyAssignmentRevisionsResponse>(grpcClient.ListOSPolicyAssignmentRevisionsAsync, grpcClient.ListOSPolicyAssignmentRevisions, effectiveSettings.ListOSPolicyAssignmentRevisionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListOSPolicyAssignmentRevisions);
            Modify_ListOSPolicyAssignmentRevisionsApiCall(ref _callListOSPolicyAssignmentRevisions);
            _callDeleteOSPolicyAssignment = clientHelper.BuildApiCall<DeleteOSPolicyAssignmentRequest, lro::Operation>(grpcClient.DeleteOSPolicyAssignmentAsync, grpcClient.DeleteOSPolicyAssignment, effectiveSettings.DeleteOSPolicyAssignmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteOSPolicyAssignment);
            Modify_DeleteOSPolicyAssignmentApiCall(ref _callDeleteOSPolicyAssignment);
            _callGetInstanceOSPoliciesCompliance = clientHelper.BuildApiCall<GetInstanceOSPoliciesComplianceRequest, InstanceOSPoliciesCompliance>(grpcClient.GetInstanceOSPoliciesComplianceAsync, grpcClient.GetInstanceOSPoliciesCompliance, effectiveSettings.GetInstanceOSPoliciesComplianceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstanceOSPoliciesCompliance);
            Modify_GetInstanceOSPoliciesComplianceApiCall(ref _callGetInstanceOSPoliciesCompliance);
            _callListInstanceOSPoliciesCompliances = clientHelper.BuildApiCall<ListInstanceOSPoliciesCompliancesRequest, ListInstanceOSPoliciesCompliancesResponse>(grpcClient.ListInstanceOSPoliciesCompliancesAsync, grpcClient.ListInstanceOSPoliciesCompliances, effectiveSettings.ListInstanceOSPoliciesCompliancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstanceOSPoliciesCompliances);
            Modify_ListInstanceOSPoliciesCompliancesApiCall(ref _callListInstanceOSPoliciesCompliances);
            _callGetInventory = clientHelper.BuildApiCall<GetInventoryRequest, Inventory>(grpcClient.GetInventoryAsync, grpcClient.GetInventory, effectiveSettings.GetInventorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInventory);
            Modify_GetInventoryApiCall(ref _callGetInventory);
            _callListInventories = clientHelper.BuildApiCall<ListInventoriesRequest, ListInventoriesResponse>(grpcClient.ListInventoriesAsync, grpcClient.ListInventories, effectiveSettings.ListInventoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInventories);
            Modify_ListInventoriesApiCall(ref _callListInventories);
            _callGetVulnerabilityReport = clientHelper.BuildApiCall<GetVulnerabilityReportRequest, VulnerabilityReport>(grpcClient.GetVulnerabilityReportAsync, grpcClient.GetVulnerabilityReport, effectiveSettings.GetVulnerabilityReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVulnerabilityReport);
            Modify_GetVulnerabilityReportApiCall(ref _callGetVulnerabilityReport);
            _callListVulnerabilityReports = clientHelper.BuildApiCall<ListVulnerabilityReportsRequest, ListVulnerabilityReportsResponse>(grpcClient.ListVulnerabilityReportsAsync, grpcClient.ListVulnerabilityReports, effectiveSettings.ListVulnerabilityReportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVulnerabilityReports);
            Modify_ListVulnerabilityReportsApiCall(ref _callListVulnerabilityReports);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateOSPolicyAssignmentApiCall(ref gaxgrpc::ApiCall<CreateOSPolicyAssignmentRequest, lro::Operation> call);

        partial void Modify_UpdateOSPolicyAssignmentApiCall(ref gaxgrpc::ApiCall<UpdateOSPolicyAssignmentRequest, lro::Operation> call);

        partial void Modify_GetOSPolicyAssignmentApiCall(ref gaxgrpc::ApiCall<GetOSPolicyAssignmentRequest, OSPolicyAssignment> call);

        partial void Modify_ListOSPolicyAssignmentsApiCall(ref gaxgrpc::ApiCall<ListOSPolicyAssignmentsRequest, ListOSPolicyAssignmentsResponse> call);

        partial void Modify_ListOSPolicyAssignmentRevisionsApiCall(ref gaxgrpc::ApiCall<ListOSPolicyAssignmentRevisionsRequest, ListOSPolicyAssignmentRevisionsResponse> call);

        partial void Modify_DeleteOSPolicyAssignmentApiCall(ref gaxgrpc::ApiCall<DeleteOSPolicyAssignmentRequest, lro::Operation> call);

        partial void Modify_GetInstanceOSPoliciesComplianceApiCall(ref gaxgrpc::ApiCall<GetInstanceOSPoliciesComplianceRequest, InstanceOSPoliciesCompliance> call);

        partial void Modify_ListInstanceOSPoliciesCompliancesApiCall(ref gaxgrpc::ApiCall<ListInstanceOSPoliciesCompliancesRequest, ListInstanceOSPoliciesCompliancesResponse> call);

        partial void Modify_GetInventoryApiCall(ref gaxgrpc::ApiCall<GetInventoryRequest, Inventory> call);

        partial void Modify_ListInventoriesApiCall(ref gaxgrpc::ApiCall<ListInventoriesRequest, ListInventoriesResponse> call);

        partial void Modify_GetVulnerabilityReportApiCall(ref gaxgrpc::ApiCall<GetVulnerabilityReportRequest, VulnerabilityReport> call);

        partial void Modify_ListVulnerabilityReportsApiCall(ref gaxgrpc::ApiCall<ListVulnerabilityReportsRequest, ListVulnerabilityReportsResponse> call);

        partial void OnConstruction(OsConfigZonalService.OsConfigZonalServiceClient grpcClient, OsConfigZonalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OsConfigZonalService client</summary>
        public override OsConfigZonalService.OsConfigZonalServiceClient GrpcClient { get; }

        partial void Modify_CreateOSPolicyAssignmentRequest(ref CreateOSPolicyAssignmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateOSPolicyAssignmentRequest(ref UpdateOSPolicyAssignmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOSPolicyAssignmentRequest(ref GetOSPolicyAssignmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOSPolicyAssignmentsRequest(ref ListOSPolicyAssignmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOSPolicyAssignmentRevisionsRequest(ref ListOSPolicyAssignmentRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteOSPolicyAssignmentRequest(ref DeleteOSPolicyAssignmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceOSPoliciesComplianceRequest(ref GetInstanceOSPoliciesComplianceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstanceOSPoliciesCompliancesRequest(ref ListInstanceOSPoliciesCompliancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInventoryRequest(ref GetInventoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInventoriesRequest(ref ListInventoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVulnerabilityReportRequest(ref GetVulnerabilityReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVulnerabilityReportsRequest(ref ListVulnerabilityReportsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateOSPolicyAssignment</c>.</summary>
        public override lro::OperationsClient CreateOSPolicyAssignmentOperationsClient { get; }

        /// <summary>
        /// Create an OS policy assignment.
        /// 
        /// This method also creates the first revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> CreateOSPolicyAssignment(CreateOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOSPolicyAssignmentRequest(ref request, ref callSettings);
            return new lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>(_callCreateOSPolicyAssignment.Sync(request, callSettings), CreateOSPolicyAssignmentOperationsClient);
        }

        /// <summary>
        /// Create an OS policy assignment.
        /// 
        /// This method also creates the first revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> CreateOSPolicyAssignmentAsync(CreateOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOSPolicyAssignmentRequest(ref request, ref callSettings);
            return new lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>(await _callCreateOSPolicyAssignment.Async(request, callSettings).ConfigureAwait(false), CreateOSPolicyAssignmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateOSPolicyAssignment</c>.</summary>
        public override lro::OperationsClient UpdateOSPolicyAssignmentOperationsClient { get; }

        /// <summary>
        /// Update an existing OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata> UpdateOSPolicyAssignment(UpdateOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOSPolicyAssignmentRequest(ref request, ref callSettings);
            return new lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>(_callUpdateOSPolicyAssignment.Sync(request, callSettings), UpdateOSPolicyAssignmentOperationsClient);
        }

        /// <summary>
        /// Update an existing OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>> UpdateOSPolicyAssignmentAsync(UpdateOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOSPolicyAssignmentRequest(ref request, ref callSettings);
            return new lro::Operation<OSPolicyAssignment, OSPolicyAssignmentOperationMetadata>(await _callUpdateOSPolicyAssignment.Async(request, callSettings).ConfigureAwait(false), UpdateOSPolicyAssignmentOperationsClient);
        }

        /// <summary>
        /// Retrieve an existing OS policy assignment.
        /// 
        /// This method always returns the latest revision. In order to retrieve a
        /// previous revision of the assignment, also provide the revision ID in the
        /// `name` parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OSPolicyAssignment GetOSPolicyAssignment(GetOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOSPolicyAssignmentRequest(ref request, ref callSettings);
            return _callGetOSPolicyAssignment.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve an existing OS policy assignment.
        /// 
        /// This method always returns the latest revision. In order to retrieve a
        /// previous revision of the assignment, also provide the revision ID in the
        /// `name` parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OSPolicyAssignment> GetOSPolicyAssignmentAsync(GetOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOSPolicyAssignmentRequest(ref request, ref callSettings);
            return _callGetOSPolicyAssignment.Async(request, callSettings);
        }

        /// <summary>
        /// List the OS policy assignments under the parent resource.
        /// 
        /// For each OS policy assignment, the latest revision is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public override gax::PagedEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> ListOSPolicyAssignments(ListOSPolicyAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOSPolicyAssignmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOSPolicyAssignmentsRequest, ListOSPolicyAssignmentsResponse, OSPolicyAssignment>(_callListOSPolicyAssignments, request, callSettings);
        }

        /// <summary>
        /// List the OS policy assignments under the parent resource.
        /// 
        /// For each OS policy assignment, the latest revision is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOSPolicyAssignmentsResponse, OSPolicyAssignment> ListOSPolicyAssignmentsAsync(ListOSPolicyAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOSPolicyAssignmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOSPolicyAssignmentsRequest, ListOSPolicyAssignmentsResponse, OSPolicyAssignment>(_callListOSPolicyAssignments, request, callSettings);
        }

        /// <summary>
        /// List the OS policy assignment revisions for a given OS policy assignment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public override gax::PagedEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> ListOSPolicyAssignmentRevisions(ListOSPolicyAssignmentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOSPolicyAssignmentRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOSPolicyAssignmentRevisionsRequest, ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment>(_callListOSPolicyAssignmentRevisions, request, callSettings);
        }

        /// <summary>
        /// List the OS policy assignment revisions for a given OS policy assignment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OSPolicyAssignment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment> ListOSPolicyAssignmentRevisionsAsync(ListOSPolicyAssignmentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOSPolicyAssignmentRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOSPolicyAssignmentRevisionsRequest, ListOSPolicyAssignmentRevisionsResponse, OSPolicyAssignment>(_callListOSPolicyAssignmentRevisions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteOSPolicyAssignment</c>.</summary>
        public override lro::OperationsClient DeleteOSPolicyAssignmentOperationsClient { get; }

        /// <summary>
        /// Delete the OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// If the LRO completes and is not cancelled, all revisions associated with
        /// the OS policy assignment are deleted.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata> DeleteOSPolicyAssignment(DeleteOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOSPolicyAssignmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>(_callDeleteOSPolicyAssignment.Sync(request, callSettings), DeleteOSPolicyAssignmentOperationsClient);
        }

        /// <summary>
        /// Delete the OS policy assignment.
        /// 
        /// This method creates a new revision of the OS policy assignment.
        /// 
        /// This method returns a long running operation (LRO) that contains the
        /// rollout details. The rollout can be cancelled by cancelling the LRO.
        /// 
        /// If the LRO completes and is not cancelled, all revisions associated with
        /// the OS policy assignment are deleted.
        /// 
        /// For more information, see [Method:
        /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>> DeleteOSPolicyAssignmentAsync(DeleteOSPolicyAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOSPolicyAssignmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OSPolicyAssignmentOperationMetadata>(await _callDeleteOSPolicyAssignment.Async(request, callSettings).ConfigureAwait(false), DeleteOSPolicyAssignmentOperationsClient);
        }

        /// <summary>
        /// Get OS policies compliance data for the specified Compute Engine VM
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstanceOSPoliciesCompliance GetInstanceOSPoliciesCompliance(GetInstanceOSPoliciesComplianceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceOSPoliciesComplianceRequest(ref request, ref callSettings);
            return _callGetInstanceOSPoliciesCompliance.Sync(request, callSettings);
        }

        /// <summary>
        /// Get OS policies compliance data for the specified Compute Engine VM
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstanceOSPoliciesCompliance> GetInstanceOSPoliciesComplianceAsync(GetInstanceOSPoliciesComplianceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceOSPoliciesComplianceRequest(ref request, ref callSettings);
            return _callGetInstanceOSPoliciesCompliance.Async(request, callSettings);
        }

        /// <summary>
        /// List OS policies compliance data for all Compute Engine VM instances in the
        /// specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceOSPoliciesCompliance"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> ListInstanceOSPoliciesCompliances(ListInstanceOSPoliciesCompliancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceOSPoliciesCompliancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstanceOSPoliciesCompliancesRequest, ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance>(_callListInstanceOSPoliciesCompliances, request, callSettings);
        }

        /// <summary>
        /// List OS policies compliance data for all Compute Engine VM instances in the
        /// specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceOSPoliciesCompliance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance> ListInstanceOSPoliciesCompliancesAsync(ListInstanceOSPoliciesCompliancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceOSPoliciesCompliancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstanceOSPoliciesCompliancesRequest, ListInstanceOSPoliciesCompliancesResponse, InstanceOSPoliciesCompliance>(_callListInstanceOSPoliciesCompliances, request, callSettings);
        }

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Inventory GetInventory(GetInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInventoryRequest(ref request, ref callSettings);
            return _callGetInventory.Sync(request, callSettings);
        }

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Inventory> GetInventoryAsync(GetInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInventoryRequest(ref request, ref callSettings);
            return _callGetInventory.Async(request, callSettings);
        }

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Inventory"/> resources.</returns>
        public override gax::PagedEnumerable<ListInventoriesResponse, Inventory> ListInventories(ListInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInventoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInventoriesRequest, ListInventoriesResponse, Inventory>(_callListInventories, request, callSettings);
        }

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Inventory"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInventoriesResponse, Inventory> ListInventoriesAsync(ListInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInventoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInventoriesRequest, ListInventoriesResponse, Inventory>(_callListInventories, request, callSettings);
        }

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VulnerabilityReport GetVulnerabilityReport(GetVulnerabilityReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVulnerabilityReportRequest(ref request, ref callSettings);
            return _callGetVulnerabilityReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(GetVulnerabilityReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVulnerabilityReportRequest(ref request, ref callSettings);
            return _callGetVulnerabilityReport.Async(request, callSettings);
        }

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public override gax::PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReports(ListVulnerabilityReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVulnerabilityReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVulnerabilityReportsRequest, ListVulnerabilityReportsResponse, VulnerabilityReport>(_callListVulnerabilityReports, request, callSettings);
        }

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReportsAsync(ListVulnerabilityReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVulnerabilityReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVulnerabilityReportsRequest, ListVulnerabilityReportsResponse, VulnerabilityReport>(_callListVulnerabilityReports, request, callSettings);
        }
    }

    public partial class ListOSPolicyAssignmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOSPolicyAssignmentRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstanceOSPoliciesCompliancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInventoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVulnerabilityReportsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOSPolicyAssignmentsResponse : gaxgrpc::IPageResponse<OSPolicyAssignment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OSPolicyAssignment> GetEnumerator() => OsPolicyAssignments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListOSPolicyAssignmentRevisionsResponse : gaxgrpc::IPageResponse<OSPolicyAssignment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OSPolicyAssignment> GetEnumerator() => OsPolicyAssignments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstanceOSPoliciesCompliancesResponse : gaxgrpc::IPageResponse<InstanceOSPoliciesCompliance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InstanceOSPoliciesCompliance> GetEnumerator() =>
            InstanceOsPoliciesCompliances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInventoriesResponse : gaxgrpc::IPageResponse<Inventory>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Inventory> GetEnumerator() => Inventories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVulnerabilityReportsResponse : gaxgrpc::IPageResponse<VulnerabilityReport>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VulnerabilityReport> GetEnumerator() => VulnerabilityReports.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class OsConfigZonalService
    {
        public partial class OsConfigZonalServiceClient
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
