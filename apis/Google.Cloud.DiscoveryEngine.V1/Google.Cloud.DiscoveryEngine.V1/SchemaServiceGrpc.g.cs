// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/discoveryengine/v1/schema_service.proto
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

namespace Google.Cloud.DiscoveryEngine.V1 {
  /// <summary>
  /// Service for managing [Schema][google.cloud.discoveryengine.v1.Schema]s.
  /// </summary>
  public static partial class SchemaService
  {
    static readonly string __ServiceName = "google.cloud.discoveryengine.v1.SchemaService";

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
    static readonly grpc::Marshaller<global::Google.Cloud.DiscoveryEngine.V1.GetSchemaRequest> __Marshaller_google_cloud_discoveryengine_v1_GetSchemaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.DiscoveryEngine.V1.GetSchemaRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.DiscoveryEngine.V1.Schema> __Marshaller_google_cloud_discoveryengine_v1_Schema = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.DiscoveryEngine.V1.Schema.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.DiscoveryEngine.V1.ListSchemasRequest> __Marshaller_google_cloud_discoveryengine_v1_ListSchemasRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.DiscoveryEngine.V1.ListSchemasRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.DiscoveryEngine.V1.ListSchemasResponse> __Marshaller_google_cloud_discoveryengine_v1_ListSchemasResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.DiscoveryEngine.V1.ListSchemasResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.DiscoveryEngine.V1.CreateSchemaRequest> __Marshaller_google_cloud_discoveryengine_v1_CreateSchemaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.DiscoveryEngine.V1.CreateSchemaRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.DiscoveryEngine.V1.UpdateSchemaRequest> __Marshaller_google_cloud_discoveryengine_v1_UpdateSchemaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.DiscoveryEngine.V1.UpdateSchemaRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.DiscoveryEngine.V1.DeleteSchemaRequest> __Marshaller_google_cloud_discoveryengine_v1_DeleteSchemaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.DiscoveryEngine.V1.DeleteSchemaRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.DiscoveryEngine.V1.GetSchemaRequest, global::Google.Cloud.DiscoveryEngine.V1.Schema> __Method_GetSchema = new grpc::Method<global::Google.Cloud.DiscoveryEngine.V1.GetSchemaRequest, global::Google.Cloud.DiscoveryEngine.V1.Schema>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSchema",
        __Marshaller_google_cloud_discoveryengine_v1_GetSchemaRequest,
        __Marshaller_google_cloud_discoveryengine_v1_Schema);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.DiscoveryEngine.V1.ListSchemasRequest, global::Google.Cloud.DiscoveryEngine.V1.ListSchemasResponse> __Method_ListSchemas = new grpc::Method<global::Google.Cloud.DiscoveryEngine.V1.ListSchemasRequest, global::Google.Cloud.DiscoveryEngine.V1.ListSchemasResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListSchemas",
        __Marshaller_google_cloud_discoveryengine_v1_ListSchemasRequest,
        __Marshaller_google_cloud_discoveryengine_v1_ListSchemasResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.DiscoveryEngine.V1.CreateSchemaRequest, global::Google.LongRunning.Operation> __Method_CreateSchema = new grpc::Method<global::Google.Cloud.DiscoveryEngine.V1.CreateSchemaRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateSchema",
        __Marshaller_google_cloud_discoveryengine_v1_CreateSchemaRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.DiscoveryEngine.V1.UpdateSchemaRequest, global::Google.LongRunning.Operation> __Method_UpdateSchema = new grpc::Method<global::Google.Cloud.DiscoveryEngine.V1.UpdateSchemaRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateSchema",
        __Marshaller_google_cloud_discoveryengine_v1_UpdateSchemaRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.DiscoveryEngine.V1.DeleteSchemaRequest, global::Google.LongRunning.Operation> __Method_DeleteSchema = new grpc::Method<global::Google.Cloud.DiscoveryEngine.V1.DeleteSchemaRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteSchema",
        __Marshaller_google_cloud_discoveryengine_v1_DeleteSchemaRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.DiscoveryEngine.V1.SchemaServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SchemaService</summary>
    [grpc::BindServiceMethod(typeof(SchemaService), "BindService")]
    public abstract partial class SchemaServiceBase
    {
      /// <summary>
      /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.DiscoveryEngine.V1.Schema> GetSchema(global::Google.Cloud.DiscoveryEngine.V1.GetSchemaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.DiscoveryEngine.V1.ListSchemasResponse> ListSchemas(global::Google.Cloud.DiscoveryEngine.V1.ListSchemasRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateSchema(global::Google.Cloud.DiscoveryEngine.V1.CreateSchemaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> UpdateSchema(global::Google.Cloud.DiscoveryEngine.V1.UpdateSchemaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> DeleteSchema(global::Google.Cloud.DiscoveryEngine.V1.DeleteSchemaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SchemaService</summary>
    public partial class SchemaServiceClient : grpc::ClientBase<SchemaServiceClient>
    {
      /// <summary>Creates a new client for SchemaService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SchemaServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SchemaService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SchemaServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SchemaServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SchemaServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.DiscoveryEngine.V1.Schema GetSchema(global::Google.Cloud.DiscoveryEngine.V1.GetSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSchema(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.DiscoveryEngine.V1.Schema GetSchema(global::Google.Cloud.DiscoveryEngine.V1.GetSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSchema, null, options, request);
      }
      /// <summary>
      /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.DiscoveryEngine.V1.Schema> GetSchemaAsync(global::Google.Cloud.DiscoveryEngine.V1.GetSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSchemaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.DiscoveryEngine.V1.Schema> GetSchemaAsync(global::Google.Cloud.DiscoveryEngine.V1.GetSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSchema, null, options, request);
      }
      /// <summary>
      /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.DiscoveryEngine.V1.ListSchemasResponse ListSchemas(global::Google.Cloud.DiscoveryEngine.V1.ListSchemasRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListSchemas(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.DiscoveryEngine.V1.ListSchemasResponse ListSchemas(global::Google.Cloud.DiscoveryEngine.V1.ListSchemasRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListSchemas, null, options, request);
      }
      /// <summary>
      /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.DiscoveryEngine.V1.ListSchemasResponse> ListSchemasAsync(global::Google.Cloud.DiscoveryEngine.V1.ListSchemasRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListSchemasAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.DiscoveryEngine.V1.ListSchemasResponse> ListSchemasAsync(global::Google.Cloud.DiscoveryEngine.V1.ListSchemasRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListSchemas, null, options, request);
      }
      /// <summary>
      /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateSchema(global::Google.Cloud.DiscoveryEngine.V1.CreateSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateSchema(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateSchema(global::Google.Cloud.DiscoveryEngine.V1.CreateSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateSchema, null, options, request);
      }
      /// <summary>
      /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateSchemaAsync(global::Google.Cloud.DiscoveryEngine.V1.CreateSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateSchemaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateSchemaAsync(global::Google.Cloud.DiscoveryEngine.V1.CreateSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateSchema, null, options, request);
      }
      /// <summary>
      /// Updates a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation UpdateSchema(global::Google.Cloud.DiscoveryEngine.V1.UpdateSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateSchema(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation UpdateSchema(global::Google.Cloud.DiscoveryEngine.V1.UpdateSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateSchema, null, options, request);
      }
      /// <summary>
      /// Updates a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateSchemaAsync(global::Google.Cloud.DiscoveryEngine.V1.UpdateSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateSchemaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateSchemaAsync(global::Google.Cloud.DiscoveryEngine.V1.UpdateSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateSchema, null, options, request);
      }
      /// <summary>
      /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation DeleteSchema(global::Google.Cloud.DiscoveryEngine.V1.DeleteSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteSchema(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation DeleteSchema(global::Google.Cloud.DiscoveryEngine.V1.DeleteSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteSchema, null, options, request);
      }
      /// <summary>
      /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteSchemaAsync(global::Google.Cloud.DiscoveryEngine.V1.DeleteSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteSchemaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteSchemaAsync(global::Google.Cloud.DiscoveryEngine.V1.DeleteSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteSchema, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override SchemaServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SchemaServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SchemaServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetSchema, serviceImpl.GetSchema)
          .AddMethod(__Method_ListSchemas, serviceImpl.ListSchemas)
          .AddMethod(__Method_CreateSchema, serviceImpl.CreateSchema)
          .AddMethod(__Method_UpdateSchema, serviceImpl.UpdateSchema)
          .AddMethod(__Method_DeleteSchema, serviceImpl.DeleteSchema).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SchemaServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetSchema, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.DiscoveryEngine.V1.GetSchemaRequest, global::Google.Cloud.DiscoveryEngine.V1.Schema>(serviceImpl.GetSchema));
      serviceBinder.AddMethod(__Method_ListSchemas, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.DiscoveryEngine.V1.ListSchemasRequest, global::Google.Cloud.DiscoveryEngine.V1.ListSchemasResponse>(serviceImpl.ListSchemas));
      serviceBinder.AddMethod(__Method_CreateSchema, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.DiscoveryEngine.V1.CreateSchemaRequest, global::Google.LongRunning.Operation>(serviceImpl.CreateSchema));
      serviceBinder.AddMethod(__Method_UpdateSchema, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.DiscoveryEngine.V1.UpdateSchemaRequest, global::Google.LongRunning.Operation>(serviceImpl.UpdateSchema));
      serviceBinder.AddMethod(__Method_DeleteSchema, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.DiscoveryEngine.V1.DeleteSchemaRequest, global::Google.LongRunning.Operation>(serviceImpl.DeleteSchema));
    }

  }
}
#endregion
