// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/beyondcorp/clientgateways/v1/client_gateways_service.proto
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

namespace Google.Cloud.BeyondCorp.ClientGateways.V1 {
  /// <summary>
  /// API Overview:
  ///
  /// The `beyondcorp.googleapis.com` service implements the Google Cloud
  /// BeyondCorp API.
  ///
  /// Data Model:
  ///
  /// The ClientGatewaysService exposes the following resources:
  ///
  /// * Client Gateways, named as follows:
  ///   `projects/{project_id}/locations/{location_id}/clientGateways/{client_gateway_id}`.
  /// </summary>
  public static partial class ClientGatewaysService
  {
    static readonly string __ServiceName = "google.cloud.beyondcorp.clientgateways.v1.ClientGatewaysService";

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
    static readonly grpc::Marshaller<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysRequest> __Marshaller_google_cloud_beyondcorp_clientgateways_v1_ListClientGatewaysRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysResponse> __Marshaller_google_cloud_beyondcorp_clientgateways_v1_ListClientGatewaysResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.BeyondCorp.ClientGateways.V1.GetClientGatewayRequest> __Marshaller_google_cloud_beyondcorp_clientgateways_v1_GetClientGatewayRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.BeyondCorp.ClientGateways.V1.GetClientGatewayRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway> __Marshaller_google_cloud_beyondcorp_clientgateways_v1_ClientGateway = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.BeyondCorp.ClientGateways.V1.CreateClientGatewayRequest> __Marshaller_google_cloud_beyondcorp_clientgateways_v1_CreateClientGatewayRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.BeyondCorp.ClientGateways.V1.CreateClientGatewayRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.BeyondCorp.ClientGateways.V1.DeleteClientGatewayRequest> __Marshaller_google_cloud_beyondcorp_clientgateways_v1_DeleteClientGatewayRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.BeyondCorp.ClientGateways.V1.DeleteClientGatewayRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysRequest, global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysResponse> __Method_ListClientGateways = new grpc::Method<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysRequest, global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListClientGateways",
        __Marshaller_google_cloud_beyondcorp_clientgateways_v1_ListClientGatewaysRequest,
        __Marshaller_google_cloud_beyondcorp_clientgateways_v1_ListClientGatewaysResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.BeyondCorp.ClientGateways.V1.GetClientGatewayRequest, global::Google.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway> __Method_GetClientGateway = new grpc::Method<global::Google.Cloud.BeyondCorp.ClientGateways.V1.GetClientGatewayRequest, global::Google.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetClientGateway",
        __Marshaller_google_cloud_beyondcorp_clientgateways_v1_GetClientGatewayRequest,
        __Marshaller_google_cloud_beyondcorp_clientgateways_v1_ClientGateway);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.BeyondCorp.ClientGateways.V1.CreateClientGatewayRequest, global::Google.LongRunning.Operation> __Method_CreateClientGateway = new grpc::Method<global::Google.Cloud.BeyondCorp.ClientGateways.V1.CreateClientGatewayRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateClientGateway",
        __Marshaller_google_cloud_beyondcorp_clientgateways_v1_CreateClientGatewayRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.BeyondCorp.ClientGateways.V1.DeleteClientGatewayRequest, global::Google.LongRunning.Operation> __Method_DeleteClientGateway = new grpc::Method<global::Google.Cloud.BeyondCorp.ClientGateways.V1.DeleteClientGatewayRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteClientGateway",
        __Marshaller_google_cloud_beyondcorp_clientgateways_v1_DeleteClientGatewayRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.BeyondCorp.ClientGateways.V1.ClientGatewaysServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ClientGatewaysService</summary>
    [grpc::BindServiceMethod(typeof(ClientGatewaysService), "BindService")]
    public abstract partial class ClientGatewaysServiceBase
    {
      /// <summary>
      /// Lists ClientGateways in a given project and location.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysResponse> ListClientGateways(global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets details of a single ClientGateway.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway> GetClientGateway(global::Google.Cloud.BeyondCorp.ClientGateways.V1.GetClientGatewayRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a new ClientGateway in a given project and location.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateClientGateway(global::Google.Cloud.BeyondCorp.ClientGateways.V1.CreateClientGatewayRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a single ClientGateway.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> DeleteClientGateway(global::Google.Cloud.BeyondCorp.ClientGateways.V1.DeleteClientGatewayRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ClientGatewaysService</summary>
    public partial class ClientGatewaysServiceClient : grpc::ClientBase<ClientGatewaysServiceClient>
    {
      /// <summary>Creates a new client for ClientGatewaysService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ClientGatewaysServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ClientGatewaysService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ClientGatewaysServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ClientGatewaysServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ClientGatewaysServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists ClientGateways in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysResponse ListClientGateways(global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListClientGateways(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists ClientGateways in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysResponse ListClientGateways(global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListClientGateways, null, options, request);
      }
      /// <summary>
      /// Lists ClientGateways in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysResponse> ListClientGatewaysAsync(global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListClientGatewaysAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists ClientGateways in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysResponse> ListClientGatewaysAsync(global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListClientGateways, null, options, request);
      }
      /// <summary>
      /// Gets details of a single ClientGateway.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway GetClientGateway(global::Google.Cloud.BeyondCorp.ClientGateways.V1.GetClientGatewayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetClientGateway(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets details of a single ClientGateway.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway GetClientGateway(global::Google.Cloud.BeyondCorp.ClientGateways.V1.GetClientGatewayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetClientGateway, null, options, request);
      }
      /// <summary>
      /// Gets details of a single ClientGateway.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway> GetClientGatewayAsync(global::Google.Cloud.BeyondCorp.ClientGateways.V1.GetClientGatewayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetClientGatewayAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets details of a single ClientGateway.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway> GetClientGatewayAsync(global::Google.Cloud.BeyondCorp.ClientGateways.V1.GetClientGatewayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetClientGateway, null, options, request);
      }
      /// <summary>
      /// Creates a new ClientGateway in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateClientGateway(global::Google.Cloud.BeyondCorp.ClientGateways.V1.CreateClientGatewayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateClientGateway(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new ClientGateway in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateClientGateway(global::Google.Cloud.BeyondCorp.ClientGateways.V1.CreateClientGatewayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateClientGateway, null, options, request);
      }
      /// <summary>
      /// Creates a new ClientGateway in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateClientGatewayAsync(global::Google.Cloud.BeyondCorp.ClientGateways.V1.CreateClientGatewayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateClientGatewayAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new ClientGateway in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateClientGatewayAsync(global::Google.Cloud.BeyondCorp.ClientGateways.V1.CreateClientGatewayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateClientGateway, null, options, request);
      }
      /// <summary>
      /// Deletes a single ClientGateway.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation DeleteClientGateway(global::Google.Cloud.BeyondCorp.ClientGateways.V1.DeleteClientGatewayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteClientGateway(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a single ClientGateway.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation DeleteClientGateway(global::Google.Cloud.BeyondCorp.ClientGateways.V1.DeleteClientGatewayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteClientGateway, null, options, request);
      }
      /// <summary>
      /// Deletes a single ClientGateway.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteClientGatewayAsync(global::Google.Cloud.BeyondCorp.ClientGateways.V1.DeleteClientGatewayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteClientGatewayAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a single ClientGateway.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteClientGatewayAsync(global::Google.Cloud.BeyondCorp.ClientGateways.V1.DeleteClientGatewayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteClientGateway, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ClientGatewaysServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ClientGatewaysServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ClientGatewaysServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListClientGateways, serviceImpl.ListClientGateways)
          .AddMethod(__Method_GetClientGateway, serviceImpl.GetClientGateway)
          .AddMethod(__Method_CreateClientGateway, serviceImpl.CreateClientGateway)
          .AddMethod(__Method_DeleteClientGateway, serviceImpl.DeleteClientGateway).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ClientGatewaysServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListClientGateways, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysRequest, global::Google.Cloud.BeyondCorp.ClientGateways.V1.ListClientGatewaysResponse>(serviceImpl.ListClientGateways));
      serviceBinder.AddMethod(__Method_GetClientGateway, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.BeyondCorp.ClientGateways.V1.GetClientGatewayRequest, global::Google.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway>(serviceImpl.GetClientGateway));
      serviceBinder.AddMethod(__Method_CreateClientGateway, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.BeyondCorp.ClientGateways.V1.CreateClientGatewayRequest, global::Google.LongRunning.Operation>(serviceImpl.CreateClientGateway));
      serviceBinder.AddMethod(__Method_DeleteClientGateway, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.BeyondCorp.ClientGateways.V1.DeleteClientGatewayRequest, global::Google.LongRunning.Operation>(serviceImpl.DeleteClientGateway));
    }

  }
}
#endregion
