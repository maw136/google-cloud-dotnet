// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/v2/knowledge_base.proto
// </auto-generated>
// Original file comments:
// Copyright 2022 Google LLC
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
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Dialogflow.V2 {
  /// <summary>
  /// Service for managing [KnowledgeBases][google.cloud.dialogflow.v2.KnowledgeBase].
  /// </summary>
  public static partial class KnowledgeBases
  {
    static readonly string __ServiceName = "google.cloud.dialogflow.v2.KnowledgeBases";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesRequest> __Marshaller_google_cloud_dialogflow_v2_ListKnowledgeBasesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesResponse> __Marshaller_google_cloud_dialogflow_v2_ListKnowledgeBasesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.GetKnowledgeBaseRequest> __Marshaller_google_cloud_dialogflow_v2_GetKnowledgeBaseRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2.GetKnowledgeBaseRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.KnowledgeBase> __Marshaller_google_cloud_dialogflow_v2_KnowledgeBase = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2.KnowledgeBase.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.CreateKnowledgeBaseRequest> __Marshaller_google_cloud_dialogflow_v2_CreateKnowledgeBaseRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2.CreateKnowledgeBaseRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.DeleteKnowledgeBaseRequest> __Marshaller_google_cloud_dialogflow_v2_DeleteKnowledgeBaseRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2.DeleteKnowledgeBaseRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2.UpdateKnowledgeBaseRequest> __Marshaller_google_cloud_dialogflow_v2_UpdateKnowledgeBaseRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2.UpdateKnowledgeBaseRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesRequest, global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesResponse> __Method_ListKnowledgeBases = new grpc::Method<global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesRequest, global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListKnowledgeBases",
        __Marshaller_google_cloud_dialogflow_v2_ListKnowledgeBasesRequest,
        __Marshaller_google_cloud_dialogflow_v2_ListKnowledgeBasesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2.GetKnowledgeBaseRequest, global::Google.Cloud.Dialogflow.V2.KnowledgeBase> __Method_GetKnowledgeBase = new grpc::Method<global::Google.Cloud.Dialogflow.V2.GetKnowledgeBaseRequest, global::Google.Cloud.Dialogflow.V2.KnowledgeBase>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetKnowledgeBase",
        __Marshaller_google_cloud_dialogflow_v2_GetKnowledgeBaseRequest,
        __Marshaller_google_cloud_dialogflow_v2_KnowledgeBase);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2.CreateKnowledgeBaseRequest, global::Google.Cloud.Dialogflow.V2.KnowledgeBase> __Method_CreateKnowledgeBase = new grpc::Method<global::Google.Cloud.Dialogflow.V2.CreateKnowledgeBaseRequest, global::Google.Cloud.Dialogflow.V2.KnowledgeBase>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateKnowledgeBase",
        __Marshaller_google_cloud_dialogflow_v2_CreateKnowledgeBaseRequest,
        __Marshaller_google_cloud_dialogflow_v2_KnowledgeBase);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2.DeleteKnowledgeBaseRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteKnowledgeBase = new grpc::Method<global::Google.Cloud.Dialogflow.V2.DeleteKnowledgeBaseRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteKnowledgeBase",
        __Marshaller_google_cloud_dialogflow_v2_DeleteKnowledgeBaseRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2.UpdateKnowledgeBaseRequest, global::Google.Cloud.Dialogflow.V2.KnowledgeBase> __Method_UpdateKnowledgeBase = new grpc::Method<global::Google.Cloud.Dialogflow.V2.UpdateKnowledgeBaseRequest, global::Google.Cloud.Dialogflow.V2.KnowledgeBase>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateKnowledgeBase",
        __Marshaller_google_cloud_dialogflow_v2_UpdateKnowledgeBaseRequest,
        __Marshaller_google_cloud_dialogflow_v2_KnowledgeBase);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dialogflow.V2.KnowledgeBaseReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of KnowledgeBases</summary>
    [grpc::BindServiceMethod(typeof(KnowledgeBases), "BindService")]
    public abstract partial class KnowledgeBasesBase
    {
      /// <summary>
      /// Returns the list of all knowledge bases of the specified agent.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesResponse> ListKnowledgeBases(global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves the specified knowledge base.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.V2.KnowledgeBase> GetKnowledgeBase(global::Google.Cloud.Dialogflow.V2.GetKnowledgeBaseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a knowledge base.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.V2.KnowledgeBase> CreateKnowledgeBase(global::Google.Cloud.Dialogflow.V2.CreateKnowledgeBaseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the specified knowledge base.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteKnowledgeBase(global::Google.Cloud.Dialogflow.V2.DeleteKnowledgeBaseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates the specified knowledge base.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.V2.KnowledgeBase> UpdateKnowledgeBase(global::Google.Cloud.Dialogflow.V2.UpdateKnowledgeBaseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for KnowledgeBases</summary>
    public partial class KnowledgeBasesClient : grpc::ClientBase<KnowledgeBasesClient>
    {
      /// <summary>Creates a new client for KnowledgeBases</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public KnowledgeBasesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for KnowledgeBases that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public KnowledgeBasesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected KnowledgeBasesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected KnowledgeBasesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the list of all knowledge bases of the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesResponse ListKnowledgeBases(global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListKnowledgeBases(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all knowledge bases of the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesResponse ListKnowledgeBases(global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListKnowledgeBases, null, options, request);
      }
      /// <summary>
      /// Returns the list of all knowledge bases of the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesResponse> ListKnowledgeBasesAsync(global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListKnowledgeBasesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all knowledge bases of the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesResponse> ListKnowledgeBasesAsync(global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListKnowledgeBases, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2.KnowledgeBase GetKnowledgeBase(global::Google.Cloud.Dialogflow.V2.GetKnowledgeBaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKnowledgeBase(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2.KnowledgeBase GetKnowledgeBase(global::Google.Cloud.Dialogflow.V2.GetKnowledgeBaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetKnowledgeBase, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.KnowledgeBase> GetKnowledgeBaseAsync(global::Google.Cloud.Dialogflow.V2.GetKnowledgeBaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKnowledgeBaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.KnowledgeBase> GetKnowledgeBaseAsync(global::Google.Cloud.Dialogflow.V2.GetKnowledgeBaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetKnowledgeBase, null, options, request);
      }
      /// <summary>
      /// Creates a knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2.KnowledgeBase CreateKnowledgeBase(global::Google.Cloud.Dialogflow.V2.CreateKnowledgeBaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateKnowledgeBase(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2.KnowledgeBase CreateKnowledgeBase(global::Google.Cloud.Dialogflow.V2.CreateKnowledgeBaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateKnowledgeBase, null, options, request);
      }
      /// <summary>
      /// Creates a knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.KnowledgeBase> CreateKnowledgeBaseAsync(global::Google.Cloud.Dialogflow.V2.CreateKnowledgeBaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateKnowledgeBaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.KnowledgeBase> CreateKnowledgeBaseAsync(global::Google.Cloud.Dialogflow.V2.CreateKnowledgeBaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateKnowledgeBase, null, options, request);
      }
      /// <summary>
      /// Deletes the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteKnowledgeBase(global::Google.Cloud.Dialogflow.V2.DeleteKnowledgeBaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteKnowledgeBase(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteKnowledgeBase(global::Google.Cloud.Dialogflow.V2.DeleteKnowledgeBaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteKnowledgeBase, null, options, request);
      }
      /// <summary>
      /// Deletes the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteKnowledgeBaseAsync(global::Google.Cloud.Dialogflow.V2.DeleteKnowledgeBaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteKnowledgeBaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteKnowledgeBaseAsync(global::Google.Cloud.Dialogflow.V2.DeleteKnowledgeBaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteKnowledgeBase, null, options, request);
      }
      /// <summary>
      /// Updates the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2.KnowledgeBase UpdateKnowledgeBase(global::Google.Cloud.Dialogflow.V2.UpdateKnowledgeBaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateKnowledgeBase(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2.KnowledgeBase UpdateKnowledgeBase(global::Google.Cloud.Dialogflow.V2.UpdateKnowledgeBaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateKnowledgeBase, null, options, request);
      }
      /// <summary>
      /// Updates the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.KnowledgeBase> UpdateKnowledgeBaseAsync(global::Google.Cloud.Dialogflow.V2.UpdateKnowledgeBaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateKnowledgeBaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified knowledge base.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2.KnowledgeBase> UpdateKnowledgeBaseAsync(global::Google.Cloud.Dialogflow.V2.UpdateKnowledgeBaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateKnowledgeBase, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override KnowledgeBasesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new KnowledgeBasesClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(KnowledgeBasesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListKnowledgeBases, serviceImpl.ListKnowledgeBases)
          .AddMethod(__Method_GetKnowledgeBase, serviceImpl.GetKnowledgeBase)
          .AddMethod(__Method_CreateKnowledgeBase, serviceImpl.CreateKnowledgeBase)
          .AddMethod(__Method_DeleteKnowledgeBase, serviceImpl.DeleteKnowledgeBase)
          .AddMethod(__Method_UpdateKnowledgeBase, serviceImpl.UpdateKnowledgeBase).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, KnowledgeBasesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListKnowledgeBases, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesRequest, global::Google.Cloud.Dialogflow.V2.ListKnowledgeBasesResponse>(serviceImpl.ListKnowledgeBases));
      serviceBinder.AddMethod(__Method_GetKnowledgeBase, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2.GetKnowledgeBaseRequest, global::Google.Cloud.Dialogflow.V2.KnowledgeBase>(serviceImpl.GetKnowledgeBase));
      serviceBinder.AddMethod(__Method_CreateKnowledgeBase, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2.CreateKnowledgeBaseRequest, global::Google.Cloud.Dialogflow.V2.KnowledgeBase>(serviceImpl.CreateKnowledgeBase));
      serviceBinder.AddMethod(__Method_DeleteKnowledgeBase, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2.DeleteKnowledgeBaseRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteKnowledgeBase));
      serviceBinder.AddMethod(__Method_UpdateKnowledgeBase, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2.UpdateKnowledgeBaseRequest, global::Google.Cloud.Dialogflow.V2.KnowledgeBase>(serviceImpl.UpdateKnowledgeBase));
    }

  }
}
#endregion
