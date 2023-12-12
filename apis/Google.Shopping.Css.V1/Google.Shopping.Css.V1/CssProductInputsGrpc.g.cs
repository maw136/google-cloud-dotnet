// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/shopping/css/v1/css_product_inputs.proto
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

namespace Google.Shopping.Css.V1 {
  /// <summary>
  /// Service to use CssProductInput resource.
  /// This service helps to insert/update/delete CSS Products.
  /// </summary>
  public static partial class CssProductInputsService
  {
    static readonly string __ServiceName = "google.shopping.css.v1.CssProductInputsService";

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
    static readonly grpc::Marshaller<global::Google.Shopping.Css.V1.InsertCssProductInputRequest> __Marshaller_google_shopping_css_v1_InsertCssProductInputRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Css.V1.InsertCssProductInputRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Css.V1.CssProductInput> __Marshaller_google_shopping_css_v1_CssProductInput = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Css.V1.CssProductInput.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Css.V1.DeleteCssProductInputRequest> __Marshaller_google_shopping_css_v1_DeleteCssProductInputRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Css.V1.DeleteCssProductInputRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Css.V1.InsertCssProductInputRequest, global::Google.Shopping.Css.V1.CssProductInput> __Method_InsertCssProductInput = new grpc::Method<global::Google.Shopping.Css.V1.InsertCssProductInputRequest, global::Google.Shopping.Css.V1.CssProductInput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "InsertCssProductInput",
        __Marshaller_google_shopping_css_v1_InsertCssProductInputRequest,
        __Marshaller_google_shopping_css_v1_CssProductInput);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Css.V1.DeleteCssProductInputRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteCssProductInput = new grpc::Method<global::Google.Shopping.Css.V1.DeleteCssProductInputRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCssProductInput",
        __Marshaller_google_shopping_css_v1_DeleteCssProductInputRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Shopping.Css.V1.CssProductInputsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CssProductInputsService</summary>
    [grpc::BindServiceMethod(typeof(CssProductInputsService), "BindService")]
    public abstract partial class CssProductInputsServiceBase
    {
      /// <summary>
      /// Uploads a CssProductInput to your CSS Center account. If an
      /// input with the same contentLanguage, identity, feedLabel and feedId already
      /// exists, this method replaces that entry.
      ///
      /// After inserting, updating, or deleting a CSS Product input, it may
      /// take several minutes before the processed CSS Product can be retrieved.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Css.V1.CssProductInput> InsertCssProductInput(global::Google.Shopping.Css.V1.InsertCssProductInputRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a CSS Product input from your CSS Center account.
      ///
      /// After a delete it may take several minutes until the input is no longer
      /// available.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCssProductInput(global::Google.Shopping.Css.V1.DeleteCssProductInputRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CssProductInputsService</summary>
    public partial class CssProductInputsServiceClient : grpc::ClientBase<CssProductInputsServiceClient>
    {
      /// <summary>Creates a new client for CssProductInputsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CssProductInputsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CssProductInputsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CssProductInputsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CssProductInputsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CssProductInputsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Uploads a CssProductInput to your CSS Center account. If an
      /// input with the same contentLanguage, identity, feedLabel and feedId already
      /// exists, this method replaces that entry.
      ///
      /// After inserting, updating, or deleting a CSS Product input, it may
      /// take several minutes before the processed CSS Product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Css.V1.CssProductInput InsertCssProductInput(global::Google.Shopping.Css.V1.InsertCssProductInputRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertCssProductInput(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Uploads a CssProductInput to your CSS Center account. If an
      /// input with the same contentLanguage, identity, feedLabel and feedId already
      /// exists, this method replaces that entry.
      ///
      /// After inserting, updating, or deleting a CSS Product input, it may
      /// take several minutes before the processed CSS Product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Css.V1.CssProductInput InsertCssProductInput(global::Google.Shopping.Css.V1.InsertCssProductInputRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_InsertCssProductInput, null, options, request);
      }
      /// <summary>
      /// Uploads a CssProductInput to your CSS Center account. If an
      /// input with the same contentLanguage, identity, feedLabel and feedId already
      /// exists, this method replaces that entry.
      ///
      /// After inserting, updating, or deleting a CSS Product input, it may
      /// take several minutes before the processed CSS Product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Css.V1.CssProductInput> InsertCssProductInputAsync(global::Google.Shopping.Css.V1.InsertCssProductInputRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertCssProductInputAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Uploads a CssProductInput to your CSS Center account. If an
      /// input with the same contentLanguage, identity, feedLabel and feedId already
      /// exists, this method replaces that entry.
      ///
      /// After inserting, updating, or deleting a CSS Product input, it may
      /// take several minutes before the processed CSS Product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Css.V1.CssProductInput> InsertCssProductInputAsync(global::Google.Shopping.Css.V1.InsertCssProductInputRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_InsertCssProductInput, null, options, request);
      }
      /// <summary>
      /// Deletes a CSS Product input from your CSS Center account.
      ///
      /// After a delete it may take several minutes until the input is no longer
      /// available.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteCssProductInput(global::Google.Shopping.Css.V1.DeleteCssProductInputRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCssProductInput(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a CSS Product input from your CSS Center account.
      ///
      /// After a delete it may take several minutes until the input is no longer
      /// available.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteCssProductInput(global::Google.Shopping.Css.V1.DeleteCssProductInputRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteCssProductInput, null, options, request);
      }
      /// <summary>
      /// Deletes a CSS Product input from your CSS Center account.
      ///
      /// After a delete it may take several minutes until the input is no longer
      /// available.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCssProductInputAsync(global::Google.Shopping.Css.V1.DeleteCssProductInputRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCssProductInputAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a CSS Product input from your CSS Center account.
      ///
      /// After a delete it may take several minutes until the input is no longer
      /// available.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCssProductInputAsync(global::Google.Shopping.Css.V1.DeleteCssProductInputRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteCssProductInput, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CssProductInputsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CssProductInputsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CssProductInputsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_InsertCssProductInput, serviceImpl.InsertCssProductInput)
          .AddMethod(__Method_DeleteCssProductInput, serviceImpl.DeleteCssProductInput).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CssProductInputsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_InsertCssProductInput, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Css.V1.InsertCssProductInputRequest, global::Google.Shopping.Css.V1.CssProductInput>(serviceImpl.InsertCssProductInput));
      serviceBinder.AddMethod(__Method_DeleteCssProductInput, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Css.V1.DeleteCssProductInputRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteCssProductInput));
    }

  }
}
#endregion
