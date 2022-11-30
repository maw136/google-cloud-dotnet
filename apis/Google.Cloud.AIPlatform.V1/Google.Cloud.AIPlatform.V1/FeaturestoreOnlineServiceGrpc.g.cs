// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/featurestore_online_service.proto
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

namespace Google.Cloud.AIPlatform.V1 {
  /// <summary>
  /// A service for serving online feature values.
  /// </summary>
  public static partial class FeaturestoreOnlineServingService
  {
    static readonly string __ServiceName = "google.cloud.aiplatform.v1.FeaturestoreOnlineServingService";

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
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesRequest> __Marshaller_google_cloud_aiplatform_v1_ReadFeatureValuesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse> __Marshaller_google_cloud_aiplatform_v1_ReadFeatureValuesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.StreamingReadFeatureValuesRequest> __Marshaller_google_cloud_aiplatform_v1_StreamingReadFeatureValuesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.StreamingReadFeatureValuesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesRequest> __Marshaller_google_cloud_aiplatform_v1_WriteFeatureValuesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesResponse> __Marshaller_google_cloud_aiplatform_v1_WriteFeatureValuesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse> __Method_ReadFeatureValues = new grpc::Method<global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadFeatureValues",
        __Marshaller_google_cloud_aiplatform_v1_ReadFeatureValuesRequest,
        __Marshaller_google_cloud_aiplatform_v1_ReadFeatureValuesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.StreamingReadFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse> __Method_StreamingReadFeatureValues = new grpc::Method<global::Google.Cloud.AIPlatform.V1.StreamingReadFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "StreamingReadFeatureValues",
        __Marshaller_google_cloud_aiplatform_v1_StreamingReadFeatureValuesRequest,
        __Marshaller_google_cloud_aiplatform_v1_ReadFeatureValuesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesResponse> __Method_WriteFeatureValues = new grpc::Method<global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "WriteFeatureValues",
        __Marshaller_google_cloud_aiplatform_v1_WriteFeatureValuesRequest,
        __Marshaller_google_cloud_aiplatform_v1_WriteFeatureValuesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.AIPlatform.V1.FeaturestoreOnlineServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FeaturestoreOnlineServingService</summary>
    [grpc::BindServiceMethod(typeof(FeaturestoreOnlineServingService), "BindService")]
    public abstract partial class FeaturestoreOnlineServingServiceBase
    {
      /// <summary>
      /// Reads Feature values of a specific entity of an EntityType. For reading
      /// feature values of multiple entities of an EntityType, please use
      /// StreamingReadFeatureValues.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse> ReadFeatureValues(global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Reads Feature values for multiple entities. Depending on their size, data
      /// for different entities may be broken
      /// up across multiple responses.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task StreamingReadFeatureValues(global::Google.Cloud.AIPlatform.V1.StreamingReadFeatureValuesRequest request, grpc::IServerStreamWriter<global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Writes Feature values of one or more entities of an EntityType.
      ///
      /// The Feature values are merged into existing entities if any. The Feature
      /// values to be written must have timestamp within the online storage
      /// retention.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesResponse> WriteFeatureValues(global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FeaturestoreOnlineServingService</summary>
    public partial class FeaturestoreOnlineServingServiceClient : grpc::ClientBase<FeaturestoreOnlineServingServiceClient>
    {
      /// <summary>Creates a new client for FeaturestoreOnlineServingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FeaturestoreOnlineServingServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FeaturestoreOnlineServingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FeaturestoreOnlineServingServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FeaturestoreOnlineServingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FeaturestoreOnlineServingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Reads Feature values of a specific entity of an EntityType. For reading
      /// feature values of multiple entities of an EntityType, please use
      /// StreamingReadFeatureValues.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse ReadFeatureValues(global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadFeatureValues(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reads Feature values of a specific entity of an EntityType. For reading
      /// feature values of multiple entities of an EntityType, please use
      /// StreamingReadFeatureValues.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse ReadFeatureValues(global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadFeatureValues, null, options, request);
      }
      /// <summary>
      /// Reads Feature values of a specific entity of an EntityType. For reading
      /// feature values of multiple entities of an EntityType, please use
      /// StreamingReadFeatureValues.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse> ReadFeatureValuesAsync(global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadFeatureValuesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reads Feature values of a specific entity of an EntityType. For reading
      /// feature values of multiple entities of an EntityType, please use
      /// StreamingReadFeatureValues.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse> ReadFeatureValuesAsync(global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadFeatureValues, null, options, request);
      }
      /// <summary>
      /// Reads Feature values for multiple entities. Depending on their size, data
      /// for different entities may be broken
      /// up across multiple responses.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse> StreamingReadFeatureValues(global::Google.Cloud.AIPlatform.V1.StreamingReadFeatureValuesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamingReadFeatureValues(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reads Feature values for multiple entities. Depending on their size, data
      /// for different entities may be broken
      /// up across multiple responses.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse> StreamingReadFeatureValues(global::Google.Cloud.AIPlatform.V1.StreamingReadFeatureValuesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_StreamingReadFeatureValues, null, options, request);
      }
      /// <summary>
      /// Writes Feature values of one or more entities of an EntityType.
      ///
      /// The Feature values are merged into existing entities if any. The Feature
      /// values to be written must have timestamp within the online storage
      /// retention.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesResponse WriteFeatureValues(global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return WriteFeatureValues(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Writes Feature values of one or more entities of an EntityType.
      ///
      /// The Feature values are merged into existing entities if any. The Feature
      /// values to be written must have timestamp within the online storage
      /// retention.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesResponse WriteFeatureValues(global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_WriteFeatureValues, null, options, request);
      }
      /// <summary>
      /// Writes Feature values of one or more entities of an EntityType.
      ///
      /// The Feature values are merged into existing entities if any. The Feature
      /// values to be written must have timestamp within the online storage
      /// retention.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesResponse> WriteFeatureValuesAsync(global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return WriteFeatureValuesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Writes Feature values of one or more entities of an EntityType.
      ///
      /// The Feature values are merged into existing entities if any. The Feature
      /// values to be written must have timestamp within the online storage
      /// retention.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesResponse> WriteFeatureValuesAsync(global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_WriteFeatureValues, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override FeaturestoreOnlineServingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FeaturestoreOnlineServingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(FeaturestoreOnlineServingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadFeatureValues, serviceImpl.ReadFeatureValues)
          .AddMethod(__Method_StreamingReadFeatureValues, serviceImpl.StreamingReadFeatureValues)
          .AddMethod(__Method_WriteFeatureValues, serviceImpl.WriteFeatureValues).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FeaturestoreOnlineServingServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ReadFeatureValues, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse>(serviceImpl.ReadFeatureValues));
      serviceBinder.AddMethod(__Method_StreamingReadFeatureValues, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Cloud.AIPlatform.V1.StreamingReadFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1.ReadFeatureValuesResponse>(serviceImpl.StreamingReadFeatureValues));
      serviceBinder.AddMethod(__Method_WriteFeatureValues, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1.WriteFeatureValuesResponse>(serviceImpl.WriteFeatureValues));
    }

  }
}
#endregion
