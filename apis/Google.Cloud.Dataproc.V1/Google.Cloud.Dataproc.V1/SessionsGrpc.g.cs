// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dataproc/v1/sessions.proto
// </auto-generated>
// Original file comments:
// Copyright 2023 Google LLC
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
//
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Dataproc.V1 {
  /// <summary>
  /// The `SessionController` provides methods to manage interactive sessions.
  /// </summary>
  public static partial class SessionController
  {
    static readonly string __ServiceName = "google.cloud.dataproc.v1.SessionController";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.CreateSessionRequest> __Marshaller_google_cloud_dataproc_v1_CreateSessionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.CreateSessionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.GetSessionRequest> __Marshaller_google_cloud_dataproc_v1_GetSessionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.GetSessionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.Session> __Marshaller_google_cloud_dataproc_v1_Session = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.Session.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.ListSessionsRequest> __Marshaller_google_cloud_dataproc_v1_ListSessionsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.ListSessionsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.ListSessionsResponse> __Marshaller_google_cloud_dataproc_v1_ListSessionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.ListSessionsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.TerminateSessionRequest> __Marshaller_google_cloud_dataproc_v1_TerminateSessionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.TerminateSessionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.DeleteSessionRequest> __Marshaller_google_cloud_dataproc_v1_DeleteSessionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.DeleteSessionRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataproc.V1.CreateSessionRequest, global::Google.LongRunning.Operation> __Method_CreateSession = new grpc::Method<global::Google.Cloud.Dataproc.V1.CreateSessionRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateSession",
        __Marshaller_google_cloud_dataproc_v1_CreateSessionRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataproc.V1.GetSessionRequest, global::Google.Cloud.Dataproc.V1.Session> __Method_GetSession = new grpc::Method<global::Google.Cloud.Dataproc.V1.GetSessionRequest, global::Google.Cloud.Dataproc.V1.Session>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSession",
        __Marshaller_google_cloud_dataproc_v1_GetSessionRequest,
        __Marshaller_google_cloud_dataproc_v1_Session);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataproc.V1.ListSessionsRequest, global::Google.Cloud.Dataproc.V1.ListSessionsResponse> __Method_ListSessions = new grpc::Method<global::Google.Cloud.Dataproc.V1.ListSessionsRequest, global::Google.Cloud.Dataproc.V1.ListSessionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListSessions",
        __Marshaller_google_cloud_dataproc_v1_ListSessionsRequest,
        __Marshaller_google_cloud_dataproc_v1_ListSessionsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataproc.V1.TerminateSessionRequest, global::Google.LongRunning.Operation> __Method_TerminateSession = new grpc::Method<global::Google.Cloud.Dataproc.V1.TerminateSessionRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TerminateSession",
        __Marshaller_google_cloud_dataproc_v1_TerminateSessionRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataproc.V1.DeleteSessionRequest, global::Google.LongRunning.Operation> __Method_DeleteSession = new grpc::Method<global::Google.Cloud.Dataproc.V1.DeleteSessionRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteSession",
        __Marshaller_google_cloud_dataproc_v1_DeleteSessionRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dataproc.V1.SessionsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SessionController</summary>
    [grpc::BindServiceMethod(typeof(SessionController), "BindService")]
    public abstract partial class SessionControllerBase
    {
      /// <summary>
      /// Create an interactive session asynchronously.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateSession(global::Google.Cloud.Dataproc.V1.CreateSessionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets the resource representation for an interactive session.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataproc.V1.Session> GetSession(global::Google.Cloud.Dataproc.V1.GetSessionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists interactive sessions.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataproc.V1.ListSessionsResponse> ListSessions(global::Google.Cloud.Dataproc.V1.ListSessionsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Terminates the interactive session.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> TerminateSession(global::Google.Cloud.Dataproc.V1.TerminateSessionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the interactive session resource. If the session is not in terminal
      /// state, it is terminated, and then deleted.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> DeleteSession(global::Google.Cloud.Dataproc.V1.DeleteSessionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SessionController</summary>
    public partial class SessionControllerClient : grpc::ClientBase<SessionControllerClient>
    {
      /// <summary>Creates a new client for SessionController</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SessionControllerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SessionController that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SessionControllerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SessionControllerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SessionControllerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Create an interactive session asynchronously.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateSession(global::Google.Cloud.Dataproc.V1.CreateSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateSession(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create an interactive session asynchronously.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateSession(global::Google.Cloud.Dataproc.V1.CreateSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateSession, null, options, request);
      }
      /// <summary>
      /// Create an interactive session asynchronously.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateSessionAsync(global::Google.Cloud.Dataproc.V1.CreateSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateSessionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create an interactive session asynchronously.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateSessionAsync(global::Google.Cloud.Dataproc.V1.CreateSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateSession, null, options, request);
      }
      /// <summary>
      /// Gets the resource representation for an interactive session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.Session GetSession(global::Google.Cloud.Dataproc.V1.GetSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSession(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the resource representation for an interactive session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.Session GetSession(global::Google.Cloud.Dataproc.V1.GetSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSession, null, options, request);
      }
      /// <summary>
      /// Gets the resource representation for an interactive session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.Session> GetSessionAsync(global::Google.Cloud.Dataproc.V1.GetSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSessionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the resource representation for an interactive session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.Session> GetSessionAsync(global::Google.Cloud.Dataproc.V1.GetSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSession, null, options, request);
      }
      /// <summary>
      /// Lists interactive sessions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.ListSessionsResponse ListSessions(global::Google.Cloud.Dataproc.V1.ListSessionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListSessions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists interactive sessions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.ListSessionsResponse ListSessions(global::Google.Cloud.Dataproc.V1.ListSessionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListSessions, null, options, request);
      }
      /// <summary>
      /// Lists interactive sessions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.ListSessionsResponse> ListSessionsAsync(global::Google.Cloud.Dataproc.V1.ListSessionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListSessionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists interactive sessions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.ListSessionsResponse> ListSessionsAsync(global::Google.Cloud.Dataproc.V1.ListSessionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListSessions, null, options, request);
      }
      /// <summary>
      /// Terminates the interactive session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation TerminateSession(global::Google.Cloud.Dataproc.V1.TerminateSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TerminateSession(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Terminates the interactive session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation TerminateSession(global::Google.Cloud.Dataproc.V1.TerminateSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_TerminateSession, null, options, request);
      }
      /// <summary>
      /// Terminates the interactive session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> TerminateSessionAsync(global::Google.Cloud.Dataproc.V1.TerminateSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TerminateSessionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Terminates the interactive session.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> TerminateSessionAsync(global::Google.Cloud.Dataproc.V1.TerminateSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_TerminateSession, null, options, request);
      }
      /// <summary>
      /// Deletes the interactive session resource. If the session is not in terminal
      /// state, it is terminated, and then deleted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation DeleteSession(global::Google.Cloud.Dataproc.V1.DeleteSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteSession(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the interactive session resource. If the session is not in terminal
      /// state, it is terminated, and then deleted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation DeleteSession(global::Google.Cloud.Dataproc.V1.DeleteSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteSession, null, options, request);
      }
      /// <summary>
      /// Deletes the interactive session resource. If the session is not in terminal
      /// state, it is terminated, and then deleted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteSessionAsync(global::Google.Cloud.Dataproc.V1.DeleteSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteSessionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the interactive session resource. If the session is not in terminal
      /// state, it is terminated, and then deleted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteSessionAsync(global::Google.Cloud.Dataproc.V1.DeleteSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteSession, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override SessionControllerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SessionControllerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SessionControllerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateSession, serviceImpl.CreateSession)
          .AddMethod(__Method_GetSession, serviceImpl.GetSession)
          .AddMethod(__Method_ListSessions, serviceImpl.ListSessions)
          .AddMethod(__Method_TerminateSession, serviceImpl.TerminateSession)
          .AddMethod(__Method_DeleteSession, serviceImpl.DeleteSession).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SessionControllerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateSession, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataproc.V1.CreateSessionRequest, global::Google.LongRunning.Operation>(serviceImpl.CreateSession));
      serviceBinder.AddMethod(__Method_GetSession, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataproc.V1.GetSessionRequest, global::Google.Cloud.Dataproc.V1.Session>(serviceImpl.GetSession));
      serviceBinder.AddMethod(__Method_ListSessions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataproc.V1.ListSessionsRequest, global::Google.Cloud.Dataproc.V1.ListSessionsResponse>(serviceImpl.ListSessions));
      serviceBinder.AddMethod(__Method_TerminateSession, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataproc.V1.TerminateSessionRequest, global::Google.LongRunning.Operation>(serviceImpl.TerminateSession));
      serviceBinder.AddMethod(__Method_DeleteSession, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataproc.V1.DeleteSessionRequest, global::Google.LongRunning.Operation>(serviceImpl.DeleteSession));
    }

  }
}
#endregion
