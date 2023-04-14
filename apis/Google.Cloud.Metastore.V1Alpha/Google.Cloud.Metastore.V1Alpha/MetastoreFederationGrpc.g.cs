// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/metastore/v1alpha/metastore_federation.proto
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

namespace Google.Cloud.Metastore.V1Alpha {
  /// <summary>
  /// Configures and manages metastore federation services.
  /// Dataproc Metastore Federation Service allows federating a collection of
  /// backend metastores like BigQuery, Dataplex Lakes, and other Dataproc
  /// Metastores. The Federation Service exposes a gRPC URL through which metadata
  /// from the backend metastores are served at query time.
  ///
  /// The Dataproc Metastore Federation API defines the following resource model:
  /// * The service works with a collection of Google Cloud projects.
  /// * Each project has a collection of available locations.
  /// * Each location has a collection of federations.
  /// * Dataproc Metastore Federations are resources with names of the
  /// form:
  /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
  /// </summary>
  public static partial class DataprocMetastoreFederation
  {
    static readonly string __ServiceName = "google.cloud.metastore.v1alpha.DataprocMetastoreFederation";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Metastore.V1Alpha.ListFederationsRequest> __Marshaller_google_cloud_metastore_v1alpha_ListFederationsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Metastore.V1Alpha.ListFederationsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Metastore.V1Alpha.ListFederationsResponse> __Marshaller_google_cloud_metastore_v1alpha_ListFederationsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Metastore.V1Alpha.ListFederationsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Metastore.V1Alpha.GetFederationRequest> __Marshaller_google_cloud_metastore_v1alpha_GetFederationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Metastore.V1Alpha.GetFederationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Metastore.V1Alpha.Federation> __Marshaller_google_cloud_metastore_v1alpha_Federation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Metastore.V1Alpha.Federation.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Metastore.V1Alpha.CreateFederationRequest> __Marshaller_google_cloud_metastore_v1alpha_CreateFederationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Metastore.V1Alpha.CreateFederationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Metastore.V1Alpha.UpdateFederationRequest> __Marshaller_google_cloud_metastore_v1alpha_UpdateFederationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Metastore.V1Alpha.UpdateFederationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Metastore.V1Alpha.DeleteFederationRequest> __Marshaller_google_cloud_metastore_v1alpha_DeleteFederationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Metastore.V1Alpha.DeleteFederationRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Metastore.V1Alpha.ListFederationsRequest, global::Google.Cloud.Metastore.V1Alpha.ListFederationsResponse> __Method_ListFederations = new grpc::Method<global::Google.Cloud.Metastore.V1Alpha.ListFederationsRequest, global::Google.Cloud.Metastore.V1Alpha.ListFederationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListFederations",
        __Marshaller_google_cloud_metastore_v1alpha_ListFederationsRequest,
        __Marshaller_google_cloud_metastore_v1alpha_ListFederationsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Metastore.V1Alpha.GetFederationRequest, global::Google.Cloud.Metastore.V1Alpha.Federation> __Method_GetFederation = new grpc::Method<global::Google.Cloud.Metastore.V1Alpha.GetFederationRequest, global::Google.Cloud.Metastore.V1Alpha.Federation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFederation",
        __Marshaller_google_cloud_metastore_v1alpha_GetFederationRequest,
        __Marshaller_google_cloud_metastore_v1alpha_Federation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Metastore.V1Alpha.CreateFederationRequest, global::Google.LongRunning.Operation> __Method_CreateFederation = new grpc::Method<global::Google.Cloud.Metastore.V1Alpha.CreateFederationRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateFederation",
        __Marshaller_google_cloud_metastore_v1alpha_CreateFederationRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Metastore.V1Alpha.UpdateFederationRequest, global::Google.LongRunning.Operation> __Method_UpdateFederation = new grpc::Method<global::Google.Cloud.Metastore.V1Alpha.UpdateFederationRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateFederation",
        __Marshaller_google_cloud_metastore_v1alpha_UpdateFederationRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Metastore.V1Alpha.DeleteFederationRequest, global::Google.LongRunning.Operation> __Method_DeleteFederation = new grpc::Method<global::Google.Cloud.Metastore.V1Alpha.DeleteFederationRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteFederation",
        __Marshaller_google_cloud_metastore_v1alpha_DeleteFederationRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Metastore.V1Alpha.MetastoreFederationReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DataprocMetastoreFederation</summary>
    [grpc::BindServiceMethod(typeof(DataprocMetastoreFederation), "BindService")]
    public abstract partial class DataprocMetastoreFederationBase
    {
      /// <summary>
      /// Lists federations in a project and location.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Metastore.V1Alpha.ListFederationsResponse> ListFederations(global::Google.Cloud.Metastore.V1Alpha.ListFederationsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets the details of a single federation.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Metastore.V1Alpha.Federation> GetFederation(global::Google.Cloud.Metastore.V1Alpha.GetFederationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a metastore federation in a project and location.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateFederation(global::Google.Cloud.Metastore.V1Alpha.CreateFederationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates the fields of a federation.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> UpdateFederation(global::Google.Cloud.Metastore.V1Alpha.UpdateFederationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a single federation.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> DeleteFederation(global::Google.Cloud.Metastore.V1Alpha.DeleteFederationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DataprocMetastoreFederation</summary>
    public partial class DataprocMetastoreFederationClient : grpc::ClientBase<DataprocMetastoreFederationClient>
    {
      /// <summary>Creates a new client for DataprocMetastoreFederation</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DataprocMetastoreFederationClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DataprocMetastoreFederation that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DataprocMetastoreFederationClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DataprocMetastoreFederationClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DataprocMetastoreFederationClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists federations in a project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Metastore.V1Alpha.ListFederationsResponse ListFederations(global::Google.Cloud.Metastore.V1Alpha.ListFederationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListFederations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists federations in a project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Metastore.V1Alpha.ListFederationsResponse ListFederations(global::Google.Cloud.Metastore.V1Alpha.ListFederationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListFederations, null, options, request);
      }
      /// <summary>
      /// Lists federations in a project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Metastore.V1Alpha.ListFederationsResponse> ListFederationsAsync(global::Google.Cloud.Metastore.V1Alpha.ListFederationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListFederationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists federations in a project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Metastore.V1Alpha.ListFederationsResponse> ListFederationsAsync(global::Google.Cloud.Metastore.V1Alpha.ListFederationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListFederations, null, options, request);
      }
      /// <summary>
      /// Gets the details of a single federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Metastore.V1Alpha.Federation GetFederation(global::Google.Cloud.Metastore.V1Alpha.GetFederationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFederation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the details of a single federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Metastore.V1Alpha.Federation GetFederation(global::Google.Cloud.Metastore.V1Alpha.GetFederationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFederation, null, options, request);
      }
      /// <summary>
      /// Gets the details of a single federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Metastore.V1Alpha.Federation> GetFederationAsync(global::Google.Cloud.Metastore.V1Alpha.GetFederationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFederationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the details of a single federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Metastore.V1Alpha.Federation> GetFederationAsync(global::Google.Cloud.Metastore.V1Alpha.GetFederationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFederation, null, options, request);
      }
      /// <summary>
      /// Creates a metastore federation in a project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateFederation(global::Google.Cloud.Metastore.V1Alpha.CreateFederationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateFederation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a metastore federation in a project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateFederation(global::Google.Cloud.Metastore.V1Alpha.CreateFederationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateFederation, null, options, request);
      }
      /// <summary>
      /// Creates a metastore federation in a project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateFederationAsync(global::Google.Cloud.Metastore.V1Alpha.CreateFederationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateFederationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a metastore federation in a project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateFederationAsync(global::Google.Cloud.Metastore.V1Alpha.CreateFederationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateFederation, null, options, request);
      }
      /// <summary>
      /// Updates the fields of a federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation UpdateFederation(global::Google.Cloud.Metastore.V1Alpha.UpdateFederationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateFederation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the fields of a federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation UpdateFederation(global::Google.Cloud.Metastore.V1Alpha.UpdateFederationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateFederation, null, options, request);
      }
      /// <summary>
      /// Updates the fields of a federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateFederationAsync(global::Google.Cloud.Metastore.V1Alpha.UpdateFederationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateFederationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the fields of a federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateFederationAsync(global::Google.Cloud.Metastore.V1Alpha.UpdateFederationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateFederation, null, options, request);
      }
      /// <summary>
      /// Deletes a single federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation DeleteFederation(global::Google.Cloud.Metastore.V1Alpha.DeleteFederationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteFederation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a single federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation DeleteFederation(global::Google.Cloud.Metastore.V1Alpha.DeleteFederationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteFederation, null, options, request);
      }
      /// <summary>
      /// Deletes a single federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteFederationAsync(global::Google.Cloud.Metastore.V1Alpha.DeleteFederationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteFederationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a single federation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteFederationAsync(global::Google.Cloud.Metastore.V1Alpha.DeleteFederationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteFederation, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override DataprocMetastoreFederationClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DataprocMetastoreFederationClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(DataprocMetastoreFederationBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListFederations, serviceImpl.ListFederations)
          .AddMethod(__Method_GetFederation, serviceImpl.GetFederation)
          .AddMethod(__Method_CreateFederation, serviceImpl.CreateFederation)
          .AddMethod(__Method_UpdateFederation, serviceImpl.UpdateFederation)
          .AddMethod(__Method_DeleteFederation, serviceImpl.DeleteFederation).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DataprocMetastoreFederationBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListFederations, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Metastore.V1Alpha.ListFederationsRequest, global::Google.Cloud.Metastore.V1Alpha.ListFederationsResponse>(serviceImpl.ListFederations));
      serviceBinder.AddMethod(__Method_GetFederation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Metastore.V1Alpha.GetFederationRequest, global::Google.Cloud.Metastore.V1Alpha.Federation>(serviceImpl.GetFederation));
      serviceBinder.AddMethod(__Method_CreateFederation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Metastore.V1Alpha.CreateFederationRequest, global::Google.LongRunning.Operation>(serviceImpl.CreateFederation));
      serviceBinder.AddMethod(__Method_UpdateFederation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Metastore.V1Alpha.UpdateFederationRequest, global::Google.LongRunning.Operation>(serviceImpl.UpdateFederation));
      serviceBinder.AddMethod(__Method_DeleteFederation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Metastore.V1Alpha.DeleteFederationRequest, global::Google.LongRunning.Operation>(serviceImpl.DeleteFederation));
    }

  }
}
#endregion
