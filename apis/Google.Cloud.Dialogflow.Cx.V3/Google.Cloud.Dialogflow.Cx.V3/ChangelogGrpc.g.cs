// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/cx/v3/changelog.proto
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
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Dialogflow.Cx.V3 {
  /// <summary>
  /// Service for managing [Changelogs][google.cloud.dialogflow.cx.v3.Changelog].
  /// </summary>
  public static partial class Changelogs
  {
    static readonly string __ServiceName = "google.cloud.dialogflow.cx.v3.Changelogs";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsRequest> __Marshaller_google_cloud_dialogflow_cx_v3_ListChangelogsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsResponse> __Marshaller_google_cloud_dialogflow_cx_v3_ListChangelogsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.GetChangelogRequest> __Marshaller_google_cloud_dialogflow_cx_v3_GetChangelogRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.GetChangelogRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.Changelog> __Marshaller_google_cloud_dialogflow_cx_v3_Changelog = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.Cx.V3.Changelog.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsResponse> __Method_ListChangelogs = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListChangelogs",
        __Marshaller_google_cloud_dialogflow_cx_v3_ListChangelogsRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_ListChangelogsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetChangelogRequest, global::Google.Cloud.Dialogflow.Cx.V3.Changelog> __Method_GetChangelog = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetChangelogRequest, global::Google.Cloud.Dialogflow.Cx.V3.Changelog>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetChangelog",
        __Marshaller_google_cloud_dialogflow_cx_v3_GetChangelogRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Changelog);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dialogflow.Cx.V3.ChangelogReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Changelogs</summary>
    [grpc::BindServiceMethod(typeof(Changelogs), "BindService")]
    public abstract partial class ChangelogsBase
    {
      /// <summary>
      /// Returns the list of Changelogs.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsResponse> ListChangelogs(global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves the specified Changelog.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Changelog> GetChangelog(global::Google.Cloud.Dialogflow.Cx.V3.GetChangelogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Changelogs</summary>
    public partial class ChangelogsClient : grpc::ClientBase<ChangelogsClient>
    {
      /// <summary>Creates a new client for Changelogs</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ChangelogsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Changelogs that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ChangelogsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ChangelogsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ChangelogsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the list of Changelogs.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsResponse ListChangelogs(global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListChangelogs(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of Changelogs.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsResponse ListChangelogs(global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListChangelogs, null, options, request);
      }
      /// <summary>
      /// Returns the list of Changelogs.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsResponse> ListChangelogsAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListChangelogsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of Changelogs.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsResponse> ListChangelogsAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListChangelogs, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified Changelog.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Changelog GetChangelog(global::Google.Cloud.Dialogflow.Cx.V3.GetChangelogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetChangelog(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified Changelog.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Changelog GetChangelog(global::Google.Cloud.Dialogflow.Cx.V3.GetChangelogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetChangelog, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified Changelog.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Changelog> GetChangelogAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetChangelogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetChangelogAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified Changelog.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Changelog> GetChangelogAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetChangelogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetChangelog, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ChangelogsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ChangelogsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ChangelogsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListChangelogs, serviceImpl.ListChangelogs)
          .AddMethod(__Method_GetChangelog, serviceImpl.GetChangelog).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ChangelogsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListChangelogs, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListChangelogsResponse>(serviceImpl.ListChangelogs));
      serviceBinder.AddMethod(__Method_GetChangelog, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.GetChangelogRequest, global::Google.Cloud.Dialogflow.Cx.V3.Changelog>(serviceImpl.GetChangelog));
    }

  }
}
#endregion
