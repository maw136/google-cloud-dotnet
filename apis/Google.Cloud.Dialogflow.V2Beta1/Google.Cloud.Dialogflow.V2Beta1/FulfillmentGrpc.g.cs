// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/v2beta1/fulfillment.proto
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

namespace Google.Cloud.Dialogflow.V2Beta1 {
  /// <summary>
  /// Service for managing [Fulfillments][google.cloud.dialogflow.v2beta1.Fulfillment].
  /// </summary>
  public static partial class Fulfillments
  {
    static readonly string __ServiceName = "google.cloud.dialogflow.v2beta1.Fulfillments";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2Beta1.GetFulfillmentRequest> __Marshaller_google_cloud_dialogflow_v2beta1_GetFulfillmentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2Beta1.GetFulfillmentRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment> __Marshaller_google_cloud_dialogflow_v2beta1_Fulfillment = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2Beta1.UpdateFulfillmentRequest> __Marshaller_google_cloud_dialogflow_v2beta1_UpdateFulfillmentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2Beta1.UpdateFulfillmentRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2Beta1.GetFulfillmentRequest, global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment> __Method_GetFulfillment = new grpc::Method<global::Google.Cloud.Dialogflow.V2Beta1.GetFulfillmentRequest, global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFulfillment",
        __Marshaller_google_cloud_dialogflow_v2beta1_GetFulfillmentRequest,
        __Marshaller_google_cloud_dialogflow_v2beta1_Fulfillment);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2Beta1.UpdateFulfillmentRequest, global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment> __Method_UpdateFulfillment = new grpc::Method<global::Google.Cloud.Dialogflow.V2Beta1.UpdateFulfillmentRequest, global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateFulfillment",
        __Marshaller_google_cloud_dialogflow_v2beta1_UpdateFulfillmentRequest,
        __Marshaller_google_cloud_dialogflow_v2beta1_Fulfillment);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dialogflow.V2Beta1.FulfillmentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Fulfillments</summary>
    [grpc::BindServiceMethod(typeof(Fulfillments), "BindService")]
    public abstract partial class FulfillmentsBase
    {
      /// <summary>
      /// Retrieves the fulfillment.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment> GetFulfillment(global::Google.Cloud.Dialogflow.V2Beta1.GetFulfillmentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates the fulfillment.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment> UpdateFulfillment(global::Google.Cloud.Dialogflow.V2Beta1.UpdateFulfillmentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Fulfillments</summary>
    public partial class FulfillmentsClient : grpc::ClientBase<FulfillmentsClient>
    {
      /// <summary>Creates a new client for Fulfillments</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FulfillmentsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Fulfillments that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FulfillmentsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FulfillmentsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FulfillmentsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Retrieves the fulfillment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment GetFulfillment(global::Google.Cloud.Dialogflow.V2Beta1.GetFulfillmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFulfillment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the fulfillment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment GetFulfillment(global::Google.Cloud.Dialogflow.V2Beta1.GetFulfillmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFulfillment, null, options, request);
      }
      /// <summary>
      /// Retrieves the fulfillment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment> GetFulfillmentAsync(global::Google.Cloud.Dialogflow.V2Beta1.GetFulfillmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFulfillmentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the fulfillment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment> GetFulfillmentAsync(global::Google.Cloud.Dialogflow.V2Beta1.GetFulfillmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFulfillment, null, options, request);
      }
      /// <summary>
      /// Updates the fulfillment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment UpdateFulfillment(global::Google.Cloud.Dialogflow.V2Beta1.UpdateFulfillmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateFulfillment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the fulfillment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment UpdateFulfillment(global::Google.Cloud.Dialogflow.V2Beta1.UpdateFulfillmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateFulfillment, null, options, request);
      }
      /// <summary>
      /// Updates the fulfillment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment> UpdateFulfillmentAsync(global::Google.Cloud.Dialogflow.V2Beta1.UpdateFulfillmentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateFulfillmentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the fulfillment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment> UpdateFulfillmentAsync(global::Google.Cloud.Dialogflow.V2Beta1.UpdateFulfillmentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateFulfillment, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override FulfillmentsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FulfillmentsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(FulfillmentsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFulfillment, serviceImpl.GetFulfillment)
          .AddMethod(__Method_UpdateFulfillment, serviceImpl.UpdateFulfillment).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FulfillmentsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetFulfillment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2Beta1.GetFulfillmentRequest, global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment>(serviceImpl.GetFulfillment));
      serviceBinder.AddMethod(__Method_UpdateFulfillment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2Beta1.UpdateFulfillmentRequest, global::Google.Cloud.Dialogflow.V2Beta1.Fulfillment>(serviceImpl.UpdateFulfillment));
    }

  }
}
#endregion
