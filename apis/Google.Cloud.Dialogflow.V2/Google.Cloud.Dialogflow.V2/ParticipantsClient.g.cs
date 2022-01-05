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
    /// <summary>Settings for <see cref="ParticipantsClient"/> instances.</summary>
    public sealed partial class ParticipantsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ParticipantsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ParticipantsSettings"/>.</returns>
        public static ParticipantsSettings GetDefault() => new ParticipantsSettings();

        /// <summary>Constructs a new <see cref="ParticipantsSettings"/> object with default settings.</summary>
        public ParticipantsSettings()
        {
        }

        private ParticipantsSettings(ParticipantsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateParticipantSettings = existing.CreateParticipantSettings;
            GetParticipantSettings = existing.GetParticipantSettings;
            ListParticipantsSettings = existing.ListParticipantsSettings;
            UpdateParticipantSettings = existing.UpdateParticipantSettings;
            AnalyzeContentSettings = existing.AnalyzeContentSettings;
            SuggestArticlesSettings = existing.SuggestArticlesSettings;
            SuggestFaqAnswersSettings = existing.SuggestFaqAnswersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ParticipantsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.CreateParticipant</c> and <c>ParticipantsClient.CreateParticipantAsync</c>.
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
        public gaxgrpc::CallSettings CreateParticipantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.GetParticipant</c> and <c>ParticipantsClient.GetParticipantAsync</c>.
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
        public gaxgrpc::CallSettings GetParticipantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.ListParticipants</c> and <c>ParticipantsClient.ListParticipantsAsync</c>.
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
        public gaxgrpc::CallSettings ListParticipantsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.UpdateParticipant</c> and <c>ParticipantsClient.UpdateParticipantAsync</c>.
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
        public gaxgrpc::CallSettings UpdateParticipantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.AnalyzeContent</c> and <c>ParticipantsClient.AnalyzeContentAsync</c>.
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
        /// <item><description>Timeout: 220 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnalyzeContentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(220000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.SuggestArticles</c> and <c>ParticipantsClient.SuggestArticlesAsync</c>.
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
        public gaxgrpc::CallSettings SuggestArticlesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.SuggestFaqAnswers</c> and <c>ParticipantsClient.SuggestFaqAnswersAsync</c>.
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
        public gaxgrpc::CallSettings SuggestFaqAnswersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ParticipantsSettings"/> object.</returns>
        public ParticipantsSettings Clone() => new ParticipantsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ParticipantsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ParticipantsClientBuilder : gaxgrpc::ClientBuilderBase<ParticipantsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ParticipantsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ParticipantsClientBuilder()
        {
            UseJwtAccessWithScopes = ParticipantsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ParticipantsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ParticipantsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ParticipantsClient Build()
        {
            ParticipantsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ParticipantsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ParticipantsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ParticipantsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ParticipantsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ParticipantsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ParticipantsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ParticipantsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ParticipantsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ParticipantsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Participants client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Participants][google.cloud.dialogflow.v2.Participant].
    /// </remarks>
    public abstract partial class ParticipantsClient
    {
        /// <summary>
        /// The default endpoint for the Participants service, which is a host of "dialogflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Participants scopes.</summary>
        /// <remarks>
        /// The default Participants scopes are:
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
        /// Asynchronously creates a <see cref="ParticipantsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ParticipantsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ParticipantsClient"/>.</returns>
        public static stt::Task<ParticipantsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ParticipantsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ParticipantsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ParticipantsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ParticipantsClient"/>.</returns>
        public static ParticipantsClient Create() => new ParticipantsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ParticipantsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ParticipantsSettings"/>.</param>
        /// <returns>The created <see cref="ParticipantsClient"/>.</returns>
        internal static ParticipantsClient Create(grpccore::CallInvoker callInvoker, ParticipantsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Participants.ParticipantsClient grpcClient = new Participants.ParticipantsClient(callInvoker);
            return new ParticipantsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Participants client</summary>
        public virtual Participants.ParticipantsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant CreateParticipant(CreateParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(CreateParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(CreateParticipantRequest request, st::CancellationToken cancellationToken) =>
            CreateParticipantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant CreateParticipant(string parent, Participant participant, gaxgrpc::CallSettings callSettings = null) =>
            CreateParticipant(new CreateParticipantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
            }, callSettings);

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(string parent, Participant participant, gaxgrpc::CallSettings callSettings = null) =>
            CreateParticipantAsync(new CreateParticipantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
            }, callSettings);

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(string parent, Participant participant, st::CancellationToken cancellationToken) =>
            CreateParticipantAsync(parent, participant, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant CreateParticipant(ConversationName parent, Participant participant, gaxgrpc::CallSettings callSettings = null) =>
            CreateParticipant(new CreateParticipantRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
            }, callSettings);

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(ConversationName parent, Participant participant, gaxgrpc::CallSettings callSettings = null) =>
            CreateParticipantAsync(new CreateParticipantRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
            }, callSettings);

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(ConversationName parent, Participant participant, st::CancellationToken cancellationToken) =>
            CreateParticipantAsync(parent, participant, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant GetParticipant(GetParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(GetParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(GetParticipantRequest request, st::CancellationToken cancellationToken) =>
            GetParticipantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/{Project ID}/locations/{Location ID}/conversations/{Conversation
        /// ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant GetParticipant(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipant(new GetParticipantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/{Project ID}/locations/{Location ID}/conversations/{Conversation
        /// ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipantAsync(new GetParticipantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/{Project ID}/locations/{Location ID}/conversations/{Conversation
        /// ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(string name, st::CancellationToken cancellationToken) =>
            GetParticipantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/{Project ID}/locations/{Location ID}/conversations/{Conversation
        /// ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant GetParticipant(ParticipantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipant(new GetParticipantRequest
            {
                ParticipantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/{Project ID}/locations/{Location ID}/conversations/{Conversation
        /// ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(ParticipantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipantAsync(new GetParticipantRequest
            {
                ParticipantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/{Project ID}/locations/{Location ID}/conversations/{Conversation
        /// ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(ParticipantName name, st::CancellationToken cancellationToken) =>
            GetParticipantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParticipantsResponse, Participant> ListParticipants(ListParticipantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParticipantsResponse, Participant> ListParticipantsAsync(ListParticipantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation to list all participants from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;`.
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
        /// <returns>A pageable sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParticipantsResponse, Participant> ListParticipants(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListParticipants(new ListParticipantsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation to list all participants from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParticipantsResponse, Participant> ListParticipantsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListParticipantsAsync(new ListParticipantsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation to list all participants from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;`.
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
        /// <returns>A pageable sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParticipantsResponse, Participant> ListParticipants(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListParticipants(new ListParticipantsRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation to list all participants from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParticipantsResponse, Participant> ListParticipantsAsync(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListParticipantsAsync(new ListParticipantsRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant UpdateParticipant(UpdateParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> UpdateParticipantAsync(UpdateParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> UpdateParticipantAsync(UpdateParticipantRequest request, st::CancellationToken cancellationToken) =>
            UpdateParticipantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="participant">
        /// Required. The participant to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to specify which fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant UpdateParticipant(Participant participant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParticipant(new UpdateParticipantRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="participant">
        /// Required. The participant to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to specify which fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> UpdateParticipantAsync(Participant participant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParticipantAsync(new UpdateParticipantRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="participant">
        /// Required. The participant to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to specify which fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> UpdateParticipantAsync(Participant participant, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateParticipantAsync(participant, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(AnalyzeContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(AnalyzeContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(AnalyzeContentRequest request, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(string participant, TextInput textInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContent(new AnalyzeContentRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNullOrEmpty(participant, nameof(participant)),
                TextInput = textInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(string participant, TextInput textInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContentAsync(new AnalyzeContentRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNullOrEmpty(participant, nameof(participant)),
                TextInput = textInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(string participant, TextInput textInput, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(participant, textInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(ParticipantName participant, TextInput textInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContent(new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                TextInput = textInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(ParticipantName participant, TextInput textInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContentAsync(new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                TextInput = textInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(ParticipantName participant, TextInput textInput, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(participant, textInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(string participant, EventInput eventInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContent(new AnalyzeContentRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNullOrEmpty(participant, nameof(participant)),
                EventInput = eventInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(string participant, EventInput eventInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContentAsync(new AnalyzeContentRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNullOrEmpty(participant, nameof(participant)),
                EventInput = eventInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(string participant, EventInput eventInput, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(participant, eventInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(ParticipantName participant, EventInput eventInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContent(new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                EventInput = eventInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(ParticipantName participant, EventInput eventInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContentAsync(new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                EventInput = eventInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(ParticipantName participant, EventInput eventInput, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(participant, eventInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestArticlesResponse SuggestArticles(SuggestArticlesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(SuggestArticlesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(SuggestArticlesRequest request, st::CancellationToken cancellationToken) =>
            SuggestArticlesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestArticlesResponse SuggestArticles(string parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestArticles(new SuggestArticlesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestArticlesAsync(new SuggestArticlesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(string parent, st::CancellationToken cancellationToken) =>
            SuggestArticlesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestArticlesResponse SuggestArticles(ParticipantName parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestArticles(new SuggestArticlesRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(ParticipantName parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestArticlesAsync(new SuggestArticlesRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(ParticipantName parent, st::CancellationToken cancellationToken) =>
            SuggestArticlesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestFaqAnswersResponse SuggestFaqAnswers(SuggestFaqAnswersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(SuggestFaqAnswersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(SuggestFaqAnswersRequest request, st::CancellationToken cancellationToken) =>
            SuggestFaqAnswersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestFaqAnswersResponse SuggestFaqAnswers(string parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestFaqAnswers(new SuggestFaqAnswersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestFaqAnswersAsync(new SuggestFaqAnswersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(string parent, st::CancellationToken cancellationToken) =>
            SuggestFaqAnswersAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestFaqAnswersResponse SuggestFaqAnswers(ParticipantName parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestFaqAnswers(new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(ParticipantName parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestFaqAnswersAsync(new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/{Project ID}/locations/{Location
        /// ID&amp;gt;/conversations/&amp;lt;Conversation ID&amp;gt;/participants/&amp;lt;Participant ID&amp;gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(ParticipantName parent, st::CancellationToken cancellationToken) =>
            SuggestFaqAnswersAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Participants client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Participants][google.cloud.dialogflow.v2.Participant].
    /// </remarks>
    public sealed partial class ParticipantsClientImpl : ParticipantsClient
    {
        private readonly gaxgrpc::ApiCall<CreateParticipantRequest, Participant> _callCreateParticipant;

        private readonly gaxgrpc::ApiCall<GetParticipantRequest, Participant> _callGetParticipant;

        private readonly gaxgrpc::ApiCall<ListParticipantsRequest, ListParticipantsResponse> _callListParticipants;

        private readonly gaxgrpc::ApiCall<UpdateParticipantRequest, Participant> _callUpdateParticipant;

        private readonly gaxgrpc::ApiCall<AnalyzeContentRequest, AnalyzeContentResponse> _callAnalyzeContent;

        private readonly gaxgrpc::ApiCall<SuggestArticlesRequest, SuggestArticlesResponse> _callSuggestArticles;

        private readonly gaxgrpc::ApiCall<SuggestFaqAnswersRequest, SuggestFaqAnswersResponse> _callSuggestFaqAnswers;

        /// <summary>
        /// Constructs a client wrapper for the Participants service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ParticipantsSettings"/> used within this client.</param>
        public ParticipantsClientImpl(Participants.ParticipantsClient grpcClient, ParticipantsSettings settings)
        {
            GrpcClient = grpcClient;
            ParticipantsSettings effectiveSettings = settings ?? ParticipantsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateParticipant = clientHelper.BuildApiCall<CreateParticipantRequest, Participant>(grpcClient.CreateParticipantAsync, grpcClient.CreateParticipant, effectiveSettings.CreateParticipantSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateParticipant);
            Modify_CreateParticipantApiCall(ref _callCreateParticipant);
            _callGetParticipant = clientHelper.BuildApiCall<GetParticipantRequest, Participant>(grpcClient.GetParticipantAsync, grpcClient.GetParticipant, effectiveSettings.GetParticipantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetParticipant);
            Modify_GetParticipantApiCall(ref _callGetParticipant);
            _callListParticipants = clientHelper.BuildApiCall<ListParticipantsRequest, ListParticipantsResponse>(grpcClient.ListParticipantsAsync, grpcClient.ListParticipants, effectiveSettings.ListParticipantsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListParticipants);
            Modify_ListParticipantsApiCall(ref _callListParticipants);
            _callUpdateParticipant = clientHelper.BuildApiCall<UpdateParticipantRequest, Participant>(grpcClient.UpdateParticipantAsync, grpcClient.UpdateParticipant, effectiveSettings.UpdateParticipantSettings).WithGoogleRequestParam("participant.name", request => request.Participant?.Name);
            Modify_ApiCall(ref _callUpdateParticipant);
            Modify_UpdateParticipantApiCall(ref _callUpdateParticipant);
            _callAnalyzeContent = clientHelper.BuildApiCall<AnalyzeContentRequest, AnalyzeContentResponse>(grpcClient.AnalyzeContentAsync, grpcClient.AnalyzeContent, effectiveSettings.AnalyzeContentSettings).WithGoogleRequestParam("participant", request => request.Participant);
            Modify_ApiCall(ref _callAnalyzeContent);
            Modify_AnalyzeContentApiCall(ref _callAnalyzeContent);
            _callSuggestArticles = clientHelper.BuildApiCall<SuggestArticlesRequest, SuggestArticlesResponse>(grpcClient.SuggestArticlesAsync, grpcClient.SuggestArticles, effectiveSettings.SuggestArticlesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSuggestArticles);
            Modify_SuggestArticlesApiCall(ref _callSuggestArticles);
            _callSuggestFaqAnswers = clientHelper.BuildApiCall<SuggestFaqAnswersRequest, SuggestFaqAnswersResponse>(grpcClient.SuggestFaqAnswersAsync, grpcClient.SuggestFaqAnswers, effectiveSettings.SuggestFaqAnswersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSuggestFaqAnswers);
            Modify_SuggestFaqAnswersApiCall(ref _callSuggestFaqAnswers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateParticipantApiCall(ref gaxgrpc::ApiCall<CreateParticipantRequest, Participant> call);

        partial void Modify_GetParticipantApiCall(ref gaxgrpc::ApiCall<GetParticipantRequest, Participant> call);

        partial void Modify_ListParticipantsApiCall(ref gaxgrpc::ApiCall<ListParticipantsRequest, ListParticipantsResponse> call);

        partial void Modify_UpdateParticipantApiCall(ref gaxgrpc::ApiCall<UpdateParticipantRequest, Participant> call);

        partial void Modify_AnalyzeContentApiCall(ref gaxgrpc::ApiCall<AnalyzeContentRequest, AnalyzeContentResponse> call);

        partial void Modify_SuggestArticlesApiCall(ref gaxgrpc::ApiCall<SuggestArticlesRequest, SuggestArticlesResponse> call);

        partial void Modify_SuggestFaqAnswersApiCall(ref gaxgrpc::ApiCall<SuggestFaqAnswersRequest, SuggestFaqAnswersResponse> call);

        partial void OnConstruction(Participants.ParticipantsClient grpcClient, ParticipantsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Participants client</summary>
        public override Participants.ParticipantsClient GrpcClient { get; }

        partial void Modify_CreateParticipantRequest(ref CreateParticipantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetParticipantRequest(ref GetParticipantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListParticipantsRequest(ref ListParticipantsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateParticipantRequest(ref UpdateParticipantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnalyzeContentRequest(ref AnalyzeContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuggestArticlesRequest(ref SuggestArticlesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuggestFaqAnswersRequest(ref SuggestFaqAnswersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Participant CreateParticipant(CreateParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateParticipantRequest(ref request, ref callSettings);
            return _callCreateParticipant.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Participant> CreateParticipantAsync(CreateParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateParticipantRequest(ref request, ref callSettings);
            return _callCreateParticipant.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Participant GetParticipant(GetParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParticipantRequest(ref request, ref callSettings);
            return _callGetParticipant.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Participant> GetParticipantAsync(GetParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParticipantRequest(ref request, ref callSettings);
            return _callGetParticipant.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Participant"/> resources.</returns>
        public override gax::PagedEnumerable<ListParticipantsResponse, Participant> ListParticipants(ListParticipantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListParticipantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListParticipantsRequest, ListParticipantsResponse, Participant>(_callListParticipants, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Participant"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListParticipantsResponse, Participant> ListParticipantsAsync(ListParticipantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListParticipantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListParticipantsRequest, ListParticipantsResponse, Participant>(_callListParticipants, request, callSettings);
        }

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Participant UpdateParticipant(UpdateParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateParticipantRequest(ref request, ref callSettings);
            return _callUpdateParticipant.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Participant> UpdateParticipantAsync(UpdateParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateParticipantRequest(ref request, ref callSettings);
            return _callUpdateParticipant.Async(request, callSettings);
        }

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzeContentResponse AnalyzeContent(AnalyzeContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeContentRequest(ref request, ref callSettings);
            return _callAnalyzeContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(AnalyzeContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeContentRequest(ref request, ref callSettings);
            return _callAnalyzeContent.Async(request, callSettings);
        }

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestArticlesResponse SuggestArticles(SuggestArticlesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestArticlesRequest(ref request, ref callSettings);
            return _callSuggestArticles.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(SuggestArticlesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestArticlesRequest(ref request, ref callSettings);
            return _callSuggestArticles.Async(request, callSettings);
        }

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestFaqAnswersResponse SuggestFaqAnswers(SuggestFaqAnswersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestFaqAnswersRequest(ref request, ref callSettings);
            return _callSuggestFaqAnswers.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(SuggestFaqAnswersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestFaqAnswersRequest(ref request, ref callSettings);
            return _callSuggestFaqAnswers.Async(request, callSettings);
        }
    }

    public partial class ListParticipantsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListParticipantsResponse : gaxgrpc::IPageResponse<Participant>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Participant> GetEnumerator() => Participants.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
