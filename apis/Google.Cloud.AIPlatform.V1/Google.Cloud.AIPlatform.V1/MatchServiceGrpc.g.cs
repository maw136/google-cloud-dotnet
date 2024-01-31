// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/match_service.proto
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

namespace Google.Cloud.AIPlatform.V1 {
  /// <summary>
  /// MatchService is a Google managed service for efficient vector similarity
  /// search at scale.
  /// </summary>
  public static partial class MatchService
  {
    static readonly string __ServiceName = "google.cloud.aiplatform.v1.MatchService";

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
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.FindNeighborsRequest> __Marshaller_google_cloud_aiplatform_v1_FindNeighborsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.FindNeighborsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.FindNeighborsResponse> __Marshaller_google_cloud_aiplatform_v1_FindNeighborsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.FindNeighborsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsRequest> __Marshaller_google_cloud_aiplatform_v1_ReadIndexDatapointsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsResponse> __Marshaller_google_cloud_aiplatform_v1_ReadIndexDatapointsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.FindNeighborsRequest, global::Google.Cloud.AIPlatform.V1.FindNeighborsResponse> __Method_FindNeighbors = new grpc::Method<global::Google.Cloud.AIPlatform.V1.FindNeighborsRequest, global::Google.Cloud.AIPlatform.V1.FindNeighborsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FindNeighbors",
        __Marshaller_google_cloud_aiplatform_v1_FindNeighborsRequest,
        __Marshaller_google_cloud_aiplatform_v1_FindNeighborsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsRequest, global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsResponse> __Method_ReadIndexDatapoints = new grpc::Method<global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsRequest, global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadIndexDatapoints",
        __Marshaller_google_cloud_aiplatform_v1_ReadIndexDatapointsRequest,
        __Marshaller_google_cloud_aiplatform_v1_ReadIndexDatapointsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.AIPlatform.V1.MatchServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MatchService</summary>
    [grpc::BindServiceMethod(typeof(MatchService), "BindService")]
    public abstract partial class MatchServiceBase
    {
      /// <summary>
      /// Finds the nearest neighbors of each vector within the request.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AIPlatform.V1.FindNeighborsResponse> FindNeighbors(global::Google.Cloud.AIPlatform.V1.FindNeighborsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Reads the datapoints/vectors of the given IDs.
      /// A maximum of 1000 datapoints can be retrieved in a batch.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsResponse> ReadIndexDatapoints(global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MatchService</summary>
    public partial class MatchServiceClient : grpc::ClientBase<MatchServiceClient>
    {
      /// <summary>Creates a new client for MatchService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MatchServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MatchService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MatchServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MatchServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MatchServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Finds the nearest neighbors of each vector within the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1.FindNeighborsResponse FindNeighbors(global::Google.Cloud.AIPlatform.V1.FindNeighborsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FindNeighbors(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Finds the nearest neighbors of each vector within the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1.FindNeighborsResponse FindNeighbors(global::Google.Cloud.AIPlatform.V1.FindNeighborsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FindNeighbors, null, options, request);
      }
      /// <summary>
      /// Finds the nearest neighbors of each vector within the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.FindNeighborsResponse> FindNeighborsAsync(global::Google.Cloud.AIPlatform.V1.FindNeighborsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FindNeighborsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Finds the nearest neighbors of each vector within the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.FindNeighborsResponse> FindNeighborsAsync(global::Google.Cloud.AIPlatform.V1.FindNeighborsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FindNeighbors, null, options, request);
      }
      /// <summary>
      /// Reads the datapoints/vectors of the given IDs.
      /// A maximum of 1000 datapoints can be retrieved in a batch.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsResponse ReadIndexDatapoints(global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadIndexDatapoints(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reads the datapoints/vectors of the given IDs.
      /// A maximum of 1000 datapoints can be retrieved in a batch.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsResponse ReadIndexDatapoints(global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadIndexDatapoints, null, options, request);
      }
      /// <summary>
      /// Reads the datapoints/vectors of the given IDs.
      /// A maximum of 1000 datapoints can be retrieved in a batch.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsResponse> ReadIndexDatapointsAsync(global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadIndexDatapointsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reads the datapoints/vectors of the given IDs.
      /// A maximum of 1000 datapoints can be retrieved in a batch.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsResponse> ReadIndexDatapointsAsync(global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadIndexDatapoints, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override MatchServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MatchServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(MatchServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_FindNeighbors, serviceImpl.FindNeighbors)
          .AddMethod(__Method_ReadIndexDatapoints, serviceImpl.ReadIndexDatapoints).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MatchServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_FindNeighbors, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1.FindNeighborsRequest, global::Google.Cloud.AIPlatform.V1.FindNeighborsResponse>(serviceImpl.FindNeighbors));
      serviceBinder.AddMethod(__Method_ReadIndexDatapoints, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsRequest, global::Google.Cloud.AIPlatform.V1.ReadIndexDatapointsResponse>(serviceImpl.ReadIndexDatapoints));
    }

  }
}
#endregion
