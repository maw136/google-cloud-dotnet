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
using lro = Google.LongRunning;
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

namespace Google.Cloud.Video.LiveStream.V1
{
    /// <summary>Settings for <see cref="LivestreamServiceClient"/> instances.</summary>
    public sealed partial class LivestreamServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LivestreamServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LivestreamServiceSettings"/>.</returns>
        public static LivestreamServiceSettings GetDefault() => new LivestreamServiceSettings();

        /// <summary>Constructs a new <see cref="LivestreamServiceSettings"/> object with default settings.</summary>
        public LivestreamServiceSettings()
        {
        }

        private LivestreamServiceSettings(LivestreamServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateChannelSettings = existing.CreateChannelSettings;
            CreateChannelOperationsSettings = existing.CreateChannelOperationsSettings.Clone();
            ListChannelsSettings = existing.ListChannelsSettings;
            GetChannelSettings = existing.GetChannelSettings;
            DeleteChannelSettings = existing.DeleteChannelSettings;
            DeleteChannelOperationsSettings = existing.DeleteChannelOperationsSettings.Clone();
            UpdateChannelSettings = existing.UpdateChannelSettings;
            UpdateChannelOperationsSettings = existing.UpdateChannelOperationsSettings.Clone();
            StartChannelSettings = existing.StartChannelSettings;
            StartChannelOperationsSettings = existing.StartChannelOperationsSettings.Clone();
            StopChannelSettings = existing.StopChannelSettings;
            StopChannelOperationsSettings = existing.StopChannelOperationsSettings.Clone();
            CreateInputSettings = existing.CreateInputSettings;
            CreateInputOperationsSettings = existing.CreateInputOperationsSettings.Clone();
            ListInputsSettings = existing.ListInputsSettings;
            GetInputSettings = existing.GetInputSettings;
            DeleteInputSettings = existing.DeleteInputSettings;
            DeleteInputOperationsSettings = existing.DeleteInputOperationsSettings.Clone();
            UpdateInputSettings = existing.UpdateInputSettings;
            UpdateInputOperationsSettings = existing.UpdateInputOperationsSettings.Clone();
            CreateEventSettings = existing.CreateEventSettings;
            ListEventsSettings = existing.ListEventsSettings;
            GetEventSettings = existing.GetEventSettings;
            DeleteEventSettings = existing.DeleteEventSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LivestreamServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.CreateChannel</c> and <c>LivestreamServiceClient.CreateChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateChannelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LivestreamServiceClient.CreateChannel</c> and
        /// <c>LivestreamServiceClient.CreateChannelAsync</c>.
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
        public lro::OperationsSettings CreateChannelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.ListChannels</c> and <c>LivestreamServiceClient.ListChannelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListChannelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.GetChannel</c> and <c>LivestreamServiceClient.GetChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetChannelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.DeleteChannel</c> and <c>LivestreamServiceClient.DeleteChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteChannelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LivestreamServiceClient.DeleteChannel</c> and
        /// <c>LivestreamServiceClient.DeleteChannelAsync</c>.
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
        public lro::OperationsSettings DeleteChannelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.UpdateChannel</c> and <c>LivestreamServiceClient.UpdateChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateChannelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LivestreamServiceClient.UpdateChannel</c> and
        /// <c>LivestreamServiceClient.UpdateChannelAsync</c>.
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
        public lro::OperationsSettings UpdateChannelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.StartChannel</c> and <c>LivestreamServiceClient.StartChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartChannelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LivestreamServiceClient.StartChannel</c> and
        /// <c>LivestreamServiceClient.StartChannelAsync</c>.
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
        public lro::OperationsSettings StartChannelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.StopChannel</c> and <c>LivestreamServiceClient.StopChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopChannelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LivestreamServiceClient.StopChannel</c> and
        /// <c>LivestreamServiceClient.StopChannelAsync</c>.
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
        public lro::OperationsSettings StopChannelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.CreateInput</c> and <c>LivestreamServiceClient.CreateInputAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInputSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LivestreamServiceClient.CreateInput</c> and
        /// <c>LivestreamServiceClient.CreateInputAsync</c>.
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
        public lro::OperationsSettings CreateInputOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.ListInputs</c> and <c>LivestreamServiceClient.ListInputsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInputsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.GetInput</c> and <c>LivestreamServiceClient.GetInputAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInputSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.DeleteInput</c> and <c>LivestreamServiceClient.DeleteInputAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInputSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LivestreamServiceClient.DeleteInput</c> and
        /// <c>LivestreamServiceClient.DeleteInputAsync</c>.
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
        public lro::OperationsSettings DeleteInputOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.UpdateInput</c> and <c>LivestreamServiceClient.UpdateInputAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInputSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LivestreamServiceClient.UpdateInput</c> and
        /// <c>LivestreamServiceClient.UpdateInputAsync</c>.
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
        public lro::OperationsSettings UpdateInputOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.CreateEvent</c> and <c>LivestreamServiceClient.CreateEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEventSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.ListEvents</c> and <c>LivestreamServiceClient.ListEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.GetEvent</c> and <c>LivestreamServiceClient.GetEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LivestreamServiceClient.DeleteEvent</c> and <c>LivestreamServiceClient.DeleteEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEventSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LivestreamServiceSettings"/> object.</returns>
        public LivestreamServiceSettings Clone() => new LivestreamServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LivestreamServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LivestreamServiceClientBuilder : gaxgrpc::ClientBuilderBase<LivestreamServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LivestreamServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LivestreamServiceClientBuilder() : base(LivestreamServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LivestreamServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LivestreamServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LivestreamServiceClient Build()
        {
            LivestreamServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LivestreamServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LivestreamServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LivestreamServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LivestreamServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<LivestreamServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LivestreamServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LivestreamServiceClient.ChannelPool;
    }

    /// <summary>LivestreamService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Using Live Stream API, you can generate live streams in the various
    /// renditions and streaming formats. The streaming format include HTTP Live
    /// Streaming (HLS) and Dynamic Adaptive Streaming over HTTP (DASH). You can send
    /// a source stream in the various ways, including Real-Time Messaging
    /// Protocol (RTMP) and Secure Reliable Transport (SRT).
    /// </remarks>
    public abstract partial class LivestreamServiceClient
    {
        /// <summary>
        /// The default endpoint for the LivestreamService service, which is a host of "livestream.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "livestream.googleapis.com:443";

        /// <summary>The default LivestreamService scopes.</summary>
        /// <remarks>
        /// The default LivestreamService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LivestreamService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LivestreamServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LivestreamServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LivestreamServiceClient"/>.</returns>
        public static stt::Task<LivestreamServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LivestreamServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LivestreamServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LivestreamServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LivestreamServiceClient"/>.</returns>
        public static LivestreamServiceClient Create() => new LivestreamServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LivestreamServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LivestreamServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LivestreamServiceClient"/>.</returns>
        internal static LivestreamServiceClient Create(grpccore::CallInvoker callInvoker, LivestreamServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LivestreamService.LivestreamServiceClient grpcClient = new LivestreamService.LivestreamServiceClient(callInvoker);
            return new LivestreamServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LivestreamService client</summary>
        public virtual LivestreamService.LivestreamServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a channel with the provided unique ID in the specified
        /// region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> CreateChannel(CreateChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a channel with the provided unique ID in the specified
        /// region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(CreateChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a channel with the provided unique ID in the specified
        /// region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(CreateChannelRequest request, st::CancellationToken cancellationToken) =>
            CreateChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateChannel</c>.</summary>
        public virtual lro::OperationsClient CreateChannelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> PollOnceCreateChannel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Channel, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateChannelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> PollOnceCreateChannelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Channel, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateChannelOperationsClient, callSettings);

        /// <summary>
        /// Creates a channel with the provided unique ID in the specified
        /// region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="channel">
        /// Required. The channel resource to be created.
        /// </param>
        /// <param name="channelId">
        /// Required. The ID of the channel resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> CreateChannel(string parent, Channel channel, string channelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannel(new CreateChannelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Channel = gax::GaxPreconditions.CheckNotNull(channel, nameof(channel)),
                ChannelId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)),
            }, callSettings);

        /// <summary>
        /// Creates a channel with the provided unique ID in the specified
        /// region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="channel">
        /// Required. The channel resource to be created.
        /// </param>
        /// <param name="channelId">
        /// Required. The ID of the channel resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(string parent, Channel channel, string channelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelAsync(new CreateChannelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Channel = gax::GaxPreconditions.CheckNotNull(channel, nameof(channel)),
                ChannelId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)),
            }, callSettings);

        /// <summary>
        /// Creates a channel with the provided unique ID in the specified
        /// region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="channel">
        /// Required. The channel resource to be created.
        /// </param>
        /// <param name="channelId">
        /// Required. The ID of the channel resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(string parent, Channel channel, string channelId, st::CancellationToken cancellationToken) =>
            CreateChannelAsync(parent, channel, channelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a channel with the provided unique ID in the specified
        /// region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="channel">
        /// Required. The channel resource to be created.
        /// </param>
        /// <param name="channelId">
        /// Required. The ID of the channel resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> CreateChannel(gagr::LocationName parent, Channel channel, string channelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannel(new CreateChannelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Channel = gax::GaxPreconditions.CheckNotNull(channel, nameof(channel)),
                ChannelId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)),
            }, callSettings);

        /// <summary>
        /// Creates a channel with the provided unique ID in the specified
        /// region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="channel">
        /// Required. The channel resource to be created.
        /// </param>
        /// <param name="channelId">
        /// Required. The ID of the channel resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(gagr::LocationName parent, Channel channel, string channelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelAsync(new CreateChannelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Channel = gax::GaxPreconditions.CheckNotNull(channel, nameof(channel)),
                ChannelId = gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)),
            }, callSettings);

        /// <summary>
        /// Creates a channel with the provided unique ID in the specified
        /// region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="channel">
        /// Required. The channel resource to be created.
        /// </param>
        /// <param name="channelId">
        /// Required. The ID of the channel resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(gagr::LocationName parent, Channel channel, string channelId, st::CancellationToken cancellationToken) =>
            CreateChannelAsync(parent, channel, channelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of all channels in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelsResponse, Channel> ListChannels(ListChannelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all channels in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelsResponse, Channel> ListChannelsAsync(ListChannelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all channels in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelsResponse, Channel> ListChannels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListChannels(new ListChannelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of all channels in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelsResponse, Channel> ListChannelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListChannelsAsync(new ListChannelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of all channels in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelsResponse, Channel> ListChannels(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListChannels(new ListChannelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of all channels in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Channel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelsResponse, Channel> ListChannelsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListChannelsAsync(new ListChannelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Channel GetChannel(GetChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(GetChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(GetChannelRequest request, st::CancellationToken cancellationToken) =>
            GetChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Channel GetChannel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannel(new GetChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelAsync(new GetChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(string name, st::CancellationToken cancellationToken) =>
            GetChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Channel GetChannel(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannel(new GetChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelAsync(new GetChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Channel> GetChannelAsync(ChannelName name, st::CancellationToken cancellationToken) =>
            GetChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteChannel(DeleteChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteChannelAsync(DeleteChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteChannelAsync(DeleteChannelRequest request, st::CancellationToken cancellationToken) =>
            DeleteChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteChannel</c>.</summary>
        public virtual lro::OperationsClient DeleteChannelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteChannel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteChannelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteChannelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteChannelOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteChannel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannel(new DeleteChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteChannelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelAsync(new DeleteChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteChannelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteChannel(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannel(new DeleteChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteChannelAsync(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelAsync(new DeleteChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteChannelAsync(ChannelName name, st::CancellationToken cancellationToken) =>
            DeleteChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> UpdateChannel(UpdateChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> UpdateChannelAsync(UpdateChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> UpdateChannelAsync(UpdateChannelRequest request, st::CancellationToken cancellationToken) =>
            UpdateChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateChannel</c>.</summary>
        public virtual lro::OperationsClient UpdateChannelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> PollOnceUpdateChannel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Channel, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateChannelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> PollOnceUpdateChannelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Channel, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateChannelOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified channel.
        /// </summary>
        /// <param name="channel">
        /// Required. The channel resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the Channel
        /// resource by the update. You can only update the following fields:
        /// 
        /// * [`inputAttachments`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#inputattachment)
        /// * [`output`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#output)
        /// * [`elementaryStreams`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#ElementaryStream)
        /// * [`muxStreams`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#muxstream)
        /// * [`manifests`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#Manifest)
        /// * [`spritesheets`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#spritesheet)
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Channel, OperationMetadata> UpdateChannel(Channel channel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateChannel(new UpdateChannelRequest
            {
                UpdateMask = updateMask,
                Channel = gax::GaxPreconditions.CheckNotNull(channel, nameof(channel)),
            }, callSettings);

        /// <summary>
        /// Updates the specified channel.
        /// </summary>
        /// <param name="channel">
        /// Required. The channel resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the Channel
        /// resource by the update. You can only update the following fields:
        /// 
        /// * [`inputAttachments`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#inputattachment)
        /// * [`output`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#output)
        /// * [`elementaryStreams`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#ElementaryStream)
        /// * [`muxStreams`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#muxstream)
        /// * [`manifests`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#Manifest)
        /// * [`spritesheets`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#spritesheet)
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> UpdateChannelAsync(Channel channel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateChannelAsync(new UpdateChannelRequest
            {
                UpdateMask = updateMask,
                Channel = gax::GaxPreconditions.CheckNotNull(channel, nameof(channel)),
            }, callSettings);

        /// <summary>
        /// Updates the specified channel.
        /// </summary>
        /// <param name="channel">
        /// Required. The channel resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the Channel
        /// resource by the update. You can only update the following fields:
        /// 
        /// * [`inputAttachments`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#inputattachment)
        /// * [`output`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#output)
        /// * [`elementaryStreams`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#ElementaryStream)
        /// * [`muxStreams`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#muxstream)
        /// * [`manifests`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#Manifest)
        /// * [`spritesheets`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.channels#spritesheet)
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Channel, OperationMetadata>> UpdateChannelAsync(Channel channel, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateChannelAsync(channel, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts the specified channel. Part of the video pipeline will be created
        /// only when the StartChannel request is received by the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelOperationResponse, OperationMetadata> StartChannel(StartChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts the specified channel. Part of the video pipeline will be created
        /// only when the StartChannel request is received by the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StartChannelAsync(StartChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts the specified channel. Part of the video pipeline will be created
        /// only when the StartChannel request is received by the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StartChannelAsync(StartChannelRequest request, st::CancellationToken cancellationToken) =>
            StartChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartChannel</c>.</summary>
        public virtual lro::OperationsClient StartChannelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ChannelOperationResponse, OperationMetadata> PollOnceStartChannel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ChannelOperationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartChannelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> PollOnceStartChannelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ChannelOperationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartChannelOperationsClient, callSettings);

        /// <summary>
        /// Starts the specified channel. Part of the video pipeline will be created
        /// only when the StartChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelOperationResponse, OperationMetadata> StartChannel(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartChannel(new StartChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts the specified channel. Part of the video pipeline will be created
        /// only when the StartChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StartChannelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartChannelAsync(new StartChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts the specified channel. Part of the video pipeline will be created
        /// only when the StartChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StartChannelAsync(string name, st::CancellationToken cancellationToken) =>
            StartChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts the specified channel. Part of the video pipeline will be created
        /// only when the StartChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelOperationResponse, OperationMetadata> StartChannel(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            StartChannel(new StartChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts the specified channel. Part of the video pipeline will be created
        /// only when the StartChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StartChannelAsync(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            StartChannelAsync(new StartChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts the specified channel. Part of the video pipeline will be created
        /// only when the StartChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StartChannelAsync(ChannelName name, st::CancellationToken cancellationToken) =>
            StartChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops the specified channel. Part of the video pipeline will be released
        /// when the StopChannel request is received by the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelOperationResponse, OperationMetadata> StopChannel(StopChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops the specified channel. Part of the video pipeline will be released
        /// when the StopChannel request is received by the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StopChannelAsync(StopChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops the specified channel. Part of the video pipeline will be released
        /// when the StopChannel request is received by the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StopChannelAsync(StopChannelRequest request, st::CancellationToken cancellationToken) =>
            StopChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopChannel</c>.</summary>
        public virtual lro::OperationsClient StopChannelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ChannelOperationResponse, OperationMetadata> PollOnceStopChannel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ChannelOperationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopChannelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopChannel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> PollOnceStopChannelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ChannelOperationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopChannelOperationsClient, callSettings);

        /// <summary>
        /// Stops the specified channel. Part of the video pipeline will be released
        /// when the StopChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelOperationResponse, OperationMetadata> StopChannel(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopChannel(new StopChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the specified channel. Part of the video pipeline will be released
        /// when the StopChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StopChannelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopChannelAsync(new StopChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the specified channel. Part of the video pipeline will be released
        /// when the StopChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StopChannelAsync(string name, st::CancellationToken cancellationToken) =>
            StopChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops the specified channel. Part of the video pipeline will be released
        /// when the StopChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ChannelOperationResponse, OperationMetadata> StopChannel(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            StopChannel(new StopChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the specified channel. Part of the video pipeline will be released
        /// when the StopChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StopChannelAsync(ChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            StopChannelAsync(new StopChannelRequest
            {
                ChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the specified channel. Part of the video pipeline will be released
        /// when the StopChannel request is received by the server.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the channel resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StopChannelAsync(ChannelName name, st::CancellationToken cancellationToken) =>
            StopChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an input with the provided unique ID in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Input, OperationMetadata> CreateInput(CreateInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an input with the provided unique ID in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> CreateInputAsync(CreateInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an input with the provided unique ID in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> CreateInputAsync(CreateInputRequest request, st::CancellationToken cancellationToken) =>
            CreateInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInput</c>.</summary>
        public virtual lro::OperationsClient CreateInputOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Input, OperationMetadata> PollOnceCreateInput(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Input, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInputOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> PollOnceCreateInputAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Input, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInputOperationsClient, callSettings);

        /// <summary>
        /// Creates an input with the provided unique ID in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="input">
        /// Required. The input resource to be created.
        /// </param>
        /// <param name="inputId">
        /// Required. The ID of the input resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Input, OperationMetadata> CreateInput(string parent, Input input, string inputId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInput(new CreateInputRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Input = gax::GaxPreconditions.CheckNotNull(input, nameof(input)),
                InputId = gax::GaxPreconditions.CheckNotNullOrEmpty(inputId, nameof(inputId)),
            }, callSettings);

        /// <summary>
        /// Creates an input with the provided unique ID in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="input">
        /// Required. The input resource to be created.
        /// </param>
        /// <param name="inputId">
        /// Required. The ID of the input resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> CreateInputAsync(string parent, Input input, string inputId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInputAsync(new CreateInputRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Input = gax::GaxPreconditions.CheckNotNull(input, nameof(input)),
                InputId = gax::GaxPreconditions.CheckNotNullOrEmpty(inputId, nameof(inputId)),
            }, callSettings);

        /// <summary>
        /// Creates an input with the provided unique ID in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="input">
        /// Required. The input resource to be created.
        /// </param>
        /// <param name="inputId">
        /// Required. The ID of the input resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> CreateInputAsync(string parent, Input input, string inputId, st::CancellationToken cancellationToken) =>
            CreateInputAsync(parent, input, inputId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an input with the provided unique ID in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="input">
        /// Required. The input resource to be created.
        /// </param>
        /// <param name="inputId">
        /// Required. The ID of the input resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Input, OperationMetadata> CreateInput(gagr::LocationName parent, Input input, string inputId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInput(new CreateInputRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Input = gax::GaxPreconditions.CheckNotNull(input, nameof(input)),
                InputId = gax::GaxPreconditions.CheckNotNullOrEmpty(inputId, nameof(inputId)),
            }, callSettings);

        /// <summary>
        /// Creates an input with the provided unique ID in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="input">
        /// Required. The input resource to be created.
        /// </param>
        /// <param name="inputId">
        /// Required. The ID of the input resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> CreateInputAsync(gagr::LocationName parent, Input input, string inputId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInputAsync(new CreateInputRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Input = gax::GaxPreconditions.CheckNotNull(input, nameof(input)),
                InputId = gax::GaxPreconditions.CheckNotNullOrEmpty(inputId, nameof(inputId)),
            }, callSettings);

        /// <summary>
        /// Creates an input with the provided unique ID in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="input">
        /// Required. The input resource to be created.
        /// </param>
        /// <param name="inputId">
        /// Required. The ID of the input resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> CreateInputAsync(gagr::LocationName parent, Input input, string inputId, st::CancellationToken cancellationToken) =>
            CreateInputAsync(parent, input, inputId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of all inputs in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Input"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInputsResponse, Input> ListInputs(ListInputsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all inputs in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Input"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInputsResponse, Input> ListInputsAsync(ListInputsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all inputs in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Input"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInputsResponse, Input> ListInputs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInputs(new ListInputsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of all inputs in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Input"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInputsResponse, Input> ListInputsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInputsAsync(new ListInputsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of all inputs in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Input"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInputsResponse, Input> ListInputs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInputs(new ListInputsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of all inputs in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location for the resource, in the form of:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Input"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInputsResponse, Input> ListInputsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInputsAsync(new ListInputsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Input GetInput(GetInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Input> GetInputAsync(GetInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Input> GetInputAsync(GetInputRequest request, st::CancellationToken cancellationToken) =>
            GetInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Input GetInput(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInput(new GetInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Input> GetInputAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInputAsync(new GetInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Input> GetInputAsync(string name, st::CancellationToken cancellationToken) =>
            GetInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Input GetInput(InputName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInput(new GetInputRequest
            {
                InputName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Input> GetInputAsync(InputName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInputAsync(new GetInputRequest
            {
                InputName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Input> GetInputAsync(InputName name, st::CancellationToken cancellationToken) =>
            GetInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInput(DeleteInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInputAsync(DeleteInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInputAsync(DeleteInputRequest request, st::CancellationToken cancellationToken) =>
            DeleteInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInput</c>.</summary>
        public virtual lro::OperationsClient DeleteInputOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInput(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInputOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInputAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInputOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInput(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInput(new DeleteInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInputAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInputAsync(new DeleteInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInputAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInput(InputName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInput(new DeleteInputRequest
            {
                InputName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInputAsync(InputName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInputAsync(new DeleteInputRequest
            {
                InputName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the input resource, in the form of:
        /// `projects/{project}/locations/{location}/inputs/{inputId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInputAsync(InputName name, st::CancellationToken cancellationToken) =>
            DeleteInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Input, OperationMetadata> UpdateInput(UpdateInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> UpdateInputAsync(UpdateInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> UpdateInputAsync(UpdateInputRequest request, st::CancellationToken cancellationToken) =>
            UpdateInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInput</c>.</summary>
        public virtual lro::OperationsClient UpdateInputOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Input, OperationMetadata> PollOnceUpdateInput(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Input, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInputOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInput</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> PollOnceUpdateInputAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Input, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInputOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="input">
        /// Required. The input resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the Input
        /// resource by the update. You can only update the following fields:
        /// 
        /// * [`preprocessingConfig`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.inputs#PreprocessingConfig)
        /// * [`securityRules`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.inputs#SecurityRule)
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Input, OperationMetadata> UpdateInput(Input input, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInput(new UpdateInputRequest
            {
                UpdateMask = updateMask,
                Input = gax::GaxPreconditions.CheckNotNull(input, nameof(input)),
            }, callSettings);

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="input">
        /// Required. The input resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the Input
        /// resource by the update. You can only update the following fields:
        /// 
        /// * [`preprocessingConfig`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.inputs#PreprocessingConfig)
        /// * [`securityRules`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.inputs#SecurityRule)
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> UpdateInputAsync(Input input, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInputAsync(new UpdateInputRequest
            {
                UpdateMask = updateMask,
                Input = gax::GaxPreconditions.CheckNotNull(input, nameof(input)),
            }, callSettings);

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="input">
        /// Required. The input resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the Input
        /// resource by the update. You can only update the following fields:
        /// 
        /// * [`preprocessingConfig`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.inputs#PreprocessingConfig)
        /// * [`securityRules`](https://cloud.google.com/livestream/docs/reference/rest/v1/projects.locations.inputs#SecurityRule)
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Input, OperationMetadata>> UpdateInputAsync(Input input, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInputAsync(input, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an event with the provided unique ID in the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Event CreateEvent(CreateEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an event with the provided unique ID in the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> CreateEventAsync(CreateEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an event with the provided unique ID in the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> CreateEventAsync(CreateEventRequest request, st::CancellationToken cancellationToken) =>
            CreateEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an event with the provided unique ID in the specified channel.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent channel for the resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="event">
        /// Required. The event resource to be created.
        /// </param>
        /// <param name="eventId">
        /// Required. The ID of the event resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Event CreateEvent(string parent, Event @event, string eventId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvent(new CreateEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
                EventId = gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)),
            }, callSettings);

        /// <summary>
        /// Creates an event with the provided unique ID in the specified channel.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent channel for the resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="event">
        /// Required. The event resource to be created.
        /// </param>
        /// <param name="eventId">
        /// Required. The ID of the event resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> CreateEventAsync(string parent, Event @event, string eventId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEventAsync(new CreateEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
                EventId = gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)),
            }, callSettings);

        /// <summary>
        /// Creates an event with the provided unique ID in the specified channel.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent channel for the resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="event">
        /// Required. The event resource to be created.
        /// </param>
        /// <param name="eventId">
        /// Required. The ID of the event resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> CreateEventAsync(string parent, Event @event, string eventId, st::CancellationToken cancellationToken) =>
            CreateEventAsync(parent, @event, eventId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an event with the provided unique ID in the specified channel.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent channel for the resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="event">
        /// Required. The event resource to be created.
        /// </param>
        /// <param name="eventId">
        /// Required. The ID of the event resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Event CreateEvent(ChannelName parent, Event @event, string eventId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvent(new CreateEventRequest
            {
                ParentAsChannelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
                EventId = gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)),
            }, callSettings);

        /// <summary>
        /// Creates an event with the provided unique ID in the specified channel.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent channel for the resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="event">
        /// Required. The event resource to be created.
        /// </param>
        /// <param name="eventId">
        /// Required. The ID of the event resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> CreateEventAsync(ChannelName parent, Event @event, string eventId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEventAsync(new CreateEventRequest
            {
                ParentAsChannelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
                EventId = gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)),
            }, callSettings);

        /// <summary>
        /// Creates an event with the provided unique ID in the specified channel.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent channel for the resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
        /// </param>
        /// <param name="event">
        /// Required. The event resource to be created.
        /// </param>
        /// <param name="eventId">
        /// Required. The ID of the event resource to be created.
        /// This value must be 1-63 characters, begin and end with `[a-z0-9]`,
        /// could contain dashes (-) in between.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> CreateEventAsync(ChannelName parent, Event @event, string eventId, st::CancellationToken cancellationToken) =>
            CreateEventAsync(parent, @event, eventId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of all events in the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, Event> ListEvents(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all events in the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, Event> ListEventsAsync(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all events in the specified channel.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent channel for the resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
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
        /// <returns>A pageable sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, Event> ListEvents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvents(new ListEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of all events in the specified channel.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent channel for the resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, Event> ListEventsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEventsAsync(new ListEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of all events in the specified channel.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent channel for the resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
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
        /// <returns>A pageable sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, Event> ListEvents(ChannelName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvents(new ListEventsRequest
            {
                ParentAsChannelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of all events in the specified channel.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent channel for the resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, Event> ListEventsAsync(ChannelName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEventsAsync(new ListEventsRequest
            {
                ParentAsChannelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the specified event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Event GetEvent(GetEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(GetEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(GetEventRequest request, st::CancellationToken cancellationToken) =>
            GetEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Event GetEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvent(new GetEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEventAsync(new GetEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(string name, st::CancellationToken cancellationToken) =>
            GetEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Event GetEvent(EventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvent(new GetEventRequest
            {
                EventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(EventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEventAsync(new GetEventRequest
            {
                EventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(EventName name, st::CancellationToken cancellationToken) =>
            GetEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvent(DeleteEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventAsync(DeleteEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventAsync(DeleteEventRequest request, st::CancellationToken cancellationToken) =>
            DeleteEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvent(new DeleteEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEventAsync(new DeleteEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvent(EventName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvent(new DeleteEventRequest
            {
                EventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventAsync(EventName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEventAsync(new DeleteEventRequest
            {
                EventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the event resource, in the form of:
        /// `projects/{project}/locations/{location}/channels/{channelId}/events/{eventId}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventAsync(EventName name, st::CancellationToken cancellationToken) =>
            DeleteEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LivestreamService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Using Live Stream API, you can generate live streams in the various
    /// renditions and streaming formats. The streaming format include HTTP Live
    /// Streaming (HLS) and Dynamic Adaptive Streaming over HTTP (DASH). You can send
    /// a source stream in the various ways, including Real-Time Messaging
    /// Protocol (RTMP) and Secure Reliable Transport (SRT).
    /// </remarks>
    public sealed partial class LivestreamServiceClientImpl : LivestreamServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateChannelRequest, lro::Operation> _callCreateChannel;

        private readonly gaxgrpc::ApiCall<ListChannelsRequest, ListChannelsResponse> _callListChannels;

        private readonly gaxgrpc::ApiCall<GetChannelRequest, Channel> _callGetChannel;

        private readonly gaxgrpc::ApiCall<DeleteChannelRequest, lro::Operation> _callDeleteChannel;

        private readonly gaxgrpc::ApiCall<UpdateChannelRequest, lro::Operation> _callUpdateChannel;

        private readonly gaxgrpc::ApiCall<StartChannelRequest, lro::Operation> _callStartChannel;

        private readonly gaxgrpc::ApiCall<StopChannelRequest, lro::Operation> _callStopChannel;

        private readonly gaxgrpc::ApiCall<CreateInputRequest, lro::Operation> _callCreateInput;

        private readonly gaxgrpc::ApiCall<ListInputsRequest, ListInputsResponse> _callListInputs;

        private readonly gaxgrpc::ApiCall<GetInputRequest, Input> _callGetInput;

        private readonly gaxgrpc::ApiCall<DeleteInputRequest, lro::Operation> _callDeleteInput;

        private readonly gaxgrpc::ApiCall<UpdateInputRequest, lro::Operation> _callUpdateInput;

        private readonly gaxgrpc::ApiCall<CreateEventRequest, Event> _callCreateEvent;

        private readonly gaxgrpc::ApiCall<ListEventsRequest, ListEventsResponse> _callListEvents;

        private readonly gaxgrpc::ApiCall<GetEventRequest, Event> _callGetEvent;

        private readonly gaxgrpc::ApiCall<DeleteEventRequest, wkt::Empty> _callDeleteEvent;

        /// <summary>
        /// Constructs a client wrapper for the LivestreamService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LivestreamServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LivestreamServiceClientImpl(LivestreamService.LivestreamServiceClient grpcClient, LivestreamServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LivestreamServiceSettings effectiveSettings = settings ?? LivestreamServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            CreateChannelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateChannelOperationsSettings, logger);
            DeleteChannelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteChannelOperationsSettings, logger);
            UpdateChannelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateChannelOperationsSettings, logger);
            StartChannelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartChannelOperationsSettings, logger);
            StopChannelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopChannelOperationsSettings, logger);
            CreateInputOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInputOperationsSettings, logger);
            DeleteInputOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInputOperationsSettings, logger);
            UpdateInputOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInputOperationsSettings, logger);
            _callCreateChannel = clientHelper.BuildApiCall<CreateChannelRequest, lro::Operation>("CreateChannel", grpcClient.CreateChannelAsync, grpcClient.CreateChannel, effectiveSettings.CreateChannelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateChannel);
            Modify_CreateChannelApiCall(ref _callCreateChannel);
            _callListChannels = clientHelper.BuildApiCall<ListChannelsRequest, ListChannelsResponse>("ListChannels", grpcClient.ListChannelsAsync, grpcClient.ListChannels, effectiveSettings.ListChannelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListChannels);
            Modify_ListChannelsApiCall(ref _callListChannels);
            _callGetChannel = clientHelper.BuildApiCall<GetChannelRequest, Channel>("GetChannel", grpcClient.GetChannelAsync, grpcClient.GetChannel, effectiveSettings.GetChannelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetChannel);
            Modify_GetChannelApiCall(ref _callGetChannel);
            _callDeleteChannel = clientHelper.BuildApiCall<DeleteChannelRequest, lro::Operation>("DeleteChannel", grpcClient.DeleteChannelAsync, grpcClient.DeleteChannel, effectiveSettings.DeleteChannelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteChannel);
            Modify_DeleteChannelApiCall(ref _callDeleteChannel);
            _callUpdateChannel = clientHelper.BuildApiCall<UpdateChannelRequest, lro::Operation>("UpdateChannel", grpcClient.UpdateChannelAsync, grpcClient.UpdateChannel, effectiveSettings.UpdateChannelSettings).WithGoogleRequestParam("channel.name", request => request.Channel?.Name);
            Modify_ApiCall(ref _callUpdateChannel);
            Modify_UpdateChannelApiCall(ref _callUpdateChannel);
            _callStartChannel = clientHelper.BuildApiCall<StartChannelRequest, lro::Operation>("StartChannel", grpcClient.StartChannelAsync, grpcClient.StartChannel, effectiveSettings.StartChannelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartChannel);
            Modify_StartChannelApiCall(ref _callStartChannel);
            _callStopChannel = clientHelper.BuildApiCall<StopChannelRequest, lro::Operation>("StopChannel", grpcClient.StopChannelAsync, grpcClient.StopChannel, effectiveSettings.StopChannelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopChannel);
            Modify_StopChannelApiCall(ref _callStopChannel);
            _callCreateInput = clientHelper.BuildApiCall<CreateInputRequest, lro::Operation>("CreateInput", grpcClient.CreateInputAsync, grpcClient.CreateInput, effectiveSettings.CreateInputSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInput);
            Modify_CreateInputApiCall(ref _callCreateInput);
            _callListInputs = clientHelper.BuildApiCall<ListInputsRequest, ListInputsResponse>("ListInputs", grpcClient.ListInputsAsync, grpcClient.ListInputs, effectiveSettings.ListInputsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInputs);
            Modify_ListInputsApiCall(ref _callListInputs);
            _callGetInput = clientHelper.BuildApiCall<GetInputRequest, Input>("GetInput", grpcClient.GetInputAsync, grpcClient.GetInput, effectiveSettings.GetInputSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInput);
            Modify_GetInputApiCall(ref _callGetInput);
            _callDeleteInput = clientHelper.BuildApiCall<DeleteInputRequest, lro::Operation>("DeleteInput", grpcClient.DeleteInputAsync, grpcClient.DeleteInput, effectiveSettings.DeleteInputSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInput);
            Modify_DeleteInputApiCall(ref _callDeleteInput);
            _callUpdateInput = clientHelper.BuildApiCall<UpdateInputRequest, lro::Operation>("UpdateInput", grpcClient.UpdateInputAsync, grpcClient.UpdateInput, effectiveSettings.UpdateInputSettings).WithGoogleRequestParam("input.name", request => request.Input?.Name);
            Modify_ApiCall(ref _callUpdateInput);
            Modify_UpdateInputApiCall(ref _callUpdateInput);
            _callCreateEvent = clientHelper.BuildApiCall<CreateEventRequest, Event>("CreateEvent", grpcClient.CreateEventAsync, grpcClient.CreateEvent, effectiveSettings.CreateEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEvent);
            Modify_CreateEventApiCall(ref _callCreateEvent);
            _callListEvents = clientHelper.BuildApiCall<ListEventsRequest, ListEventsResponse>("ListEvents", grpcClient.ListEventsAsync, grpcClient.ListEvents, effectiveSettings.ListEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvents);
            Modify_ListEventsApiCall(ref _callListEvents);
            _callGetEvent = clientHelper.BuildApiCall<GetEventRequest, Event>("GetEvent", grpcClient.GetEventAsync, grpcClient.GetEvent, effectiveSettings.GetEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvent);
            Modify_GetEventApiCall(ref _callGetEvent);
            _callDeleteEvent = clientHelper.BuildApiCall<DeleteEventRequest, wkt::Empty>("DeleteEvent", grpcClient.DeleteEventAsync, grpcClient.DeleteEvent, effectiveSettings.DeleteEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEvent);
            Modify_DeleteEventApiCall(ref _callDeleteEvent);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateChannelApiCall(ref gaxgrpc::ApiCall<CreateChannelRequest, lro::Operation> call);

        partial void Modify_ListChannelsApiCall(ref gaxgrpc::ApiCall<ListChannelsRequest, ListChannelsResponse> call);

        partial void Modify_GetChannelApiCall(ref gaxgrpc::ApiCall<GetChannelRequest, Channel> call);

        partial void Modify_DeleteChannelApiCall(ref gaxgrpc::ApiCall<DeleteChannelRequest, lro::Operation> call);

        partial void Modify_UpdateChannelApiCall(ref gaxgrpc::ApiCall<UpdateChannelRequest, lro::Operation> call);

        partial void Modify_StartChannelApiCall(ref gaxgrpc::ApiCall<StartChannelRequest, lro::Operation> call);

        partial void Modify_StopChannelApiCall(ref gaxgrpc::ApiCall<StopChannelRequest, lro::Operation> call);

        partial void Modify_CreateInputApiCall(ref gaxgrpc::ApiCall<CreateInputRequest, lro::Operation> call);

        partial void Modify_ListInputsApiCall(ref gaxgrpc::ApiCall<ListInputsRequest, ListInputsResponse> call);

        partial void Modify_GetInputApiCall(ref gaxgrpc::ApiCall<GetInputRequest, Input> call);

        partial void Modify_DeleteInputApiCall(ref gaxgrpc::ApiCall<DeleteInputRequest, lro::Operation> call);

        partial void Modify_UpdateInputApiCall(ref gaxgrpc::ApiCall<UpdateInputRequest, lro::Operation> call);

        partial void Modify_CreateEventApiCall(ref gaxgrpc::ApiCall<CreateEventRequest, Event> call);

        partial void Modify_ListEventsApiCall(ref gaxgrpc::ApiCall<ListEventsRequest, ListEventsResponse> call);

        partial void Modify_GetEventApiCall(ref gaxgrpc::ApiCall<GetEventRequest, Event> call);

        partial void Modify_DeleteEventApiCall(ref gaxgrpc::ApiCall<DeleteEventRequest, wkt::Empty> call);

        partial void OnConstruction(LivestreamService.LivestreamServiceClient grpcClient, LivestreamServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LivestreamService client</summary>
        public override LivestreamService.LivestreamServiceClient GrpcClient { get; }

        partial void Modify_CreateChannelRequest(ref CreateChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListChannelsRequest(ref ListChannelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetChannelRequest(ref GetChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteChannelRequest(ref DeleteChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateChannelRequest(ref UpdateChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartChannelRequest(ref StartChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopChannelRequest(ref StopChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInputRequest(ref CreateInputRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInputsRequest(ref ListInputsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInputRequest(ref GetInputRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInputRequest(ref DeleteInputRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInputRequest(ref UpdateInputRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEventRequest(ref CreateEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEventsRequest(ref ListEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEventRequest(ref GetEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEventRequest(ref DeleteEventRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateChannel</c>.</summary>
        public override lro::OperationsClient CreateChannelOperationsClient { get; }

        /// <summary>
        /// Creates a channel with the provided unique ID in the specified
        /// region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Channel, OperationMetadata> CreateChannel(CreateChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChannelRequest(ref request, ref callSettings);
            return new lro::Operation<Channel, OperationMetadata>(_callCreateChannel.Sync(request, callSettings), CreateChannelOperationsClient);
        }

        /// <summary>
        /// Creates a channel with the provided unique ID in the specified
        /// region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Channel, OperationMetadata>> CreateChannelAsync(CreateChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChannelRequest(ref request, ref callSettings);
            return new lro::Operation<Channel, OperationMetadata>(await _callCreateChannel.Async(request, callSettings).ConfigureAwait(false), CreateChannelOperationsClient);
        }

        /// <summary>
        /// Returns a list of all channels in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Channel"/> resources.</returns>
        public override gax::PagedEnumerable<ListChannelsResponse, Channel> ListChannels(ListChannelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChannelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListChannelsRequest, ListChannelsResponse, Channel>(_callListChannels, request, callSettings);
        }

        /// <summary>
        /// Returns a list of all channels in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Channel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListChannelsResponse, Channel> ListChannelsAsync(ListChannelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChannelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListChannelsRequest, ListChannelsResponse, Channel>(_callListChannels, request, callSettings);
        }

        /// <summary>
        /// Returns the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Channel GetChannel(GetChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChannelRequest(ref request, ref callSettings);
            return _callGetChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Channel> GetChannelAsync(GetChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChannelRequest(ref request, ref callSettings);
            return _callGetChannel.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteChannel</c>.</summary>
        public override lro::OperationsClient DeleteChannelOperationsClient { get; }

        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteChannel(DeleteChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteChannelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteChannel.Sync(request, callSettings), DeleteChannelOperationsClient);
        }

        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteChannelAsync(DeleteChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteChannelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteChannel.Async(request, callSettings).ConfigureAwait(false), DeleteChannelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateChannel</c>.</summary>
        public override lro::OperationsClient UpdateChannelOperationsClient { get; }

        /// <summary>
        /// Updates the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Channel, OperationMetadata> UpdateChannel(UpdateChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateChannelRequest(ref request, ref callSettings);
            return new lro::Operation<Channel, OperationMetadata>(_callUpdateChannel.Sync(request, callSettings), UpdateChannelOperationsClient);
        }

        /// <summary>
        /// Updates the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Channel, OperationMetadata>> UpdateChannelAsync(UpdateChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateChannelRequest(ref request, ref callSettings);
            return new lro::Operation<Channel, OperationMetadata>(await _callUpdateChannel.Async(request, callSettings).ConfigureAwait(false), UpdateChannelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartChannel</c>.</summary>
        public override lro::OperationsClient StartChannelOperationsClient { get; }

        /// <summary>
        /// Starts the specified channel. Part of the video pipeline will be created
        /// only when the StartChannel request is received by the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ChannelOperationResponse, OperationMetadata> StartChannel(StartChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartChannelRequest(ref request, ref callSettings);
            return new lro::Operation<ChannelOperationResponse, OperationMetadata>(_callStartChannel.Sync(request, callSettings), StartChannelOperationsClient);
        }

        /// <summary>
        /// Starts the specified channel. Part of the video pipeline will be created
        /// only when the StartChannel request is received by the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StartChannelAsync(StartChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartChannelRequest(ref request, ref callSettings);
            return new lro::Operation<ChannelOperationResponse, OperationMetadata>(await _callStartChannel.Async(request, callSettings).ConfigureAwait(false), StartChannelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopChannel</c>.</summary>
        public override lro::OperationsClient StopChannelOperationsClient { get; }

        /// <summary>
        /// Stops the specified channel. Part of the video pipeline will be released
        /// when the StopChannel request is received by the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ChannelOperationResponse, OperationMetadata> StopChannel(StopChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopChannelRequest(ref request, ref callSettings);
            return new lro::Operation<ChannelOperationResponse, OperationMetadata>(_callStopChannel.Sync(request, callSettings), StopChannelOperationsClient);
        }

        /// <summary>
        /// Stops the specified channel. Part of the video pipeline will be released
        /// when the StopChannel request is received by the server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ChannelOperationResponse, OperationMetadata>> StopChannelAsync(StopChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopChannelRequest(ref request, ref callSettings);
            return new lro::Operation<ChannelOperationResponse, OperationMetadata>(await _callStopChannel.Async(request, callSettings).ConfigureAwait(false), StopChannelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateInput</c>.</summary>
        public override lro::OperationsClient CreateInputOperationsClient { get; }

        /// <summary>
        /// Creates an input with the provided unique ID in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Input, OperationMetadata> CreateInput(CreateInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInputRequest(ref request, ref callSettings);
            return new lro::Operation<Input, OperationMetadata>(_callCreateInput.Sync(request, callSettings), CreateInputOperationsClient);
        }

        /// <summary>
        /// Creates an input with the provided unique ID in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Input, OperationMetadata>> CreateInputAsync(CreateInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInputRequest(ref request, ref callSettings);
            return new lro::Operation<Input, OperationMetadata>(await _callCreateInput.Async(request, callSettings).ConfigureAwait(false), CreateInputOperationsClient);
        }

        /// <summary>
        /// Returns a list of all inputs in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Input"/> resources.</returns>
        public override gax::PagedEnumerable<ListInputsResponse, Input> ListInputs(ListInputsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInputsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInputsRequest, ListInputsResponse, Input>(_callListInputs, request, callSettings);
        }

        /// <summary>
        /// Returns a list of all inputs in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Input"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInputsResponse, Input> ListInputsAsync(ListInputsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInputsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInputsRequest, ListInputsResponse, Input>(_callListInputs, request, callSettings);
        }

        /// <summary>
        /// Returns the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Input GetInput(GetInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInputRequest(ref request, ref callSettings);
            return _callGetInput.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Input> GetInputAsync(GetInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInputRequest(ref request, ref callSettings);
            return _callGetInput.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteInput</c>.</summary>
        public override lro::OperationsClient DeleteInputOperationsClient { get; }

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInput(DeleteInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInputRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInput.Sync(request, callSettings), DeleteInputOperationsClient);
        }

        /// <summary>
        /// Deletes the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInputAsync(DeleteInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInputRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInput.Async(request, callSettings).ConfigureAwait(false), DeleteInputOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInput</c>.</summary>
        public override lro::OperationsClient UpdateInputOperationsClient { get; }

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Input, OperationMetadata> UpdateInput(UpdateInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInputRequest(ref request, ref callSettings);
            return new lro::Operation<Input, OperationMetadata>(_callUpdateInput.Sync(request, callSettings), UpdateInputOperationsClient);
        }

        /// <summary>
        /// Updates the specified input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Input, OperationMetadata>> UpdateInputAsync(UpdateInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInputRequest(ref request, ref callSettings);
            return new lro::Operation<Input, OperationMetadata>(await _callUpdateInput.Async(request, callSettings).ConfigureAwait(false), UpdateInputOperationsClient);
        }

        /// <summary>
        /// Creates an event with the provided unique ID in the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Event CreateEvent(CreateEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEventRequest(ref request, ref callSettings);
            return _callCreateEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an event with the provided unique ID in the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Event> CreateEventAsync(CreateEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEventRequest(ref request, ref callSettings);
            return _callCreateEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all events in the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Event"/> resources.</returns>
        public override gax::PagedEnumerable<ListEventsResponse, Event> ListEvents(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEventsRequest, ListEventsResponse, Event>(_callListEvents, request, callSettings);
        }

        /// <summary>
        /// Returns a list of all events in the specified channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Event"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEventsResponse, Event> ListEventsAsync(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEventsRequest, ListEventsResponse, Event>(_callListEvents, request, callSettings);
        }

        /// <summary>
        /// Returns the specified event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Event GetEvent(GetEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEventRequest(ref request, ref callSettings);
            return _callGetEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Event> GetEventAsync(GetEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEventRequest(ref request, ref callSettings);
            return _callGetEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEvent(DeleteEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEventRequest(ref request, ref callSettings);
            _callDeleteEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEventAsync(DeleteEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEventRequest(ref request, ref callSettings);
            return _callDeleteEvent.Async(request, callSettings);
        }
    }

    public partial class ListChannelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInputsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEventsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListChannelsResponse : gaxgrpc::IPageResponse<Channel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Channel> GetEnumerator() => Channels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInputsResponse : gaxgrpc::IPageResponse<Input>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Input> GetEnumerator() => Inputs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEventsResponse : gaxgrpc::IPageResponse<Event>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Event> GetEnumerator() => Events.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class LivestreamService
    {
        public partial class LivestreamServiceClient
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
