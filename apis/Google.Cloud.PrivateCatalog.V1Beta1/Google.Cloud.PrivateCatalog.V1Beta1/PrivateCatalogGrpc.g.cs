// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/privatecatalog/v1beta1/private_catalog.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
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

namespace Google.Cloud.PrivateCatalog.V1Beta1 {
  /// <summary>
  /// `PrivateCatalog` allows catalog consumers to retrieve `Catalog`, `Product`
  /// and `Version` resources under a target resource context.
  ///
  /// `Catalog` is computed based on the [Association][]s linked to the target
  /// resource and its ancestors. Each association's
  /// [google.cloud.privatecatalogproducer.v1beta.Catalog][] is transformed into a
  /// `Catalog`. If multiple associations have the same parent
  /// [google.cloud.privatecatalogproducer.v1beta.Catalog][], they are
  /// de-duplicated into one `Catalog`. Users must have
  /// `cloudprivatecatalog.catalogTargets.get` IAM permission on the resource
  /// context in order to access catalogs. `Catalog` contains the resource name and
  /// a subset of data of the original
  /// [google.cloud.privatecatalogproducer.v1beta.Catalog][].
  ///
  /// `Product` is child resource of the catalog. A `Product` contains the resource
  /// name and a subset of the data of the original
  /// [google.cloud.privatecatalogproducer.v1beta.Product][].
  ///
  /// `Version` is child resource of the product. A `Version` contains the resource
  /// name and a subset of the data of the original
  /// [google.cloud.privatecatalogproducer.v1beta.Version][].
  /// </summary>
  public static partial class PrivateCatalog
  {
    static readonly string __ServiceName = "google.cloud.privatecatalog.v1beta1.PrivateCatalog";

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
    static readonly grpc::Marshaller<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsRequest> __Marshaller_google_cloud_privatecatalog_v1beta1_SearchCatalogsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsResponse> __Marshaller_google_cloud_privatecatalog_v1beta1_SearchCatalogsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsRequest> __Marshaller_google_cloud_privatecatalog_v1beta1_SearchProductsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsResponse> __Marshaller_google_cloud_privatecatalog_v1beta1_SearchProductsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsRequest> __Marshaller_google_cloud_privatecatalog_v1beta1_SearchVersionsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsResponse> __Marshaller_google_cloud_privatecatalog_v1beta1_SearchVersionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsRequest, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsResponse> __Method_SearchCatalogs = new grpc::Method<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsRequest, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchCatalogs",
        __Marshaller_google_cloud_privatecatalog_v1beta1_SearchCatalogsRequest,
        __Marshaller_google_cloud_privatecatalog_v1beta1_SearchCatalogsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsRequest, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsResponse> __Method_SearchProducts = new grpc::Method<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsRequest, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchProducts",
        __Marshaller_google_cloud_privatecatalog_v1beta1_SearchProductsRequest,
        __Marshaller_google_cloud_privatecatalog_v1beta1_SearchProductsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsRequest, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsResponse> __Method_SearchVersions = new grpc::Method<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsRequest, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchVersions",
        __Marshaller_google_cloud_privatecatalog_v1beta1_SearchVersionsRequest,
        __Marshaller_google_cloud_privatecatalog_v1beta1_SearchVersionsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.PrivateCatalog.V1Beta1.PrivateCatalogReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PrivateCatalog</summary>
    [grpc::BindServiceMethod(typeof(PrivateCatalog), "BindService")]
    public abstract partial class PrivateCatalogBase
    {
      /// <summary>
      /// Search [Catalog][google.cloud.privatecatalog.v1beta1.Catalog] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsResponse> SearchCatalogs(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Search [Product][google.cloud.privatecatalog.v1beta1.Product] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsResponse> SearchProducts(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Search [Version][google.cloud.privatecatalog.v1beta1.Version] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsResponse> SearchVersions(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PrivateCatalog</summary>
    public partial class PrivateCatalogClient : grpc::ClientBase<PrivateCatalogClient>
    {
      /// <summary>Creates a new client for PrivateCatalog</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PrivateCatalogClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PrivateCatalog that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PrivateCatalogClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PrivateCatalogClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PrivateCatalogClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Search [Catalog][google.cloud.privatecatalog.v1beta1.Catalog] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsResponse SearchCatalogs(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchCatalogs(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Search [Catalog][google.cloud.privatecatalog.v1beta1.Catalog] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsResponse SearchCatalogs(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchCatalogs, null, options, request);
      }
      /// <summary>
      /// Search [Catalog][google.cloud.privatecatalog.v1beta1.Catalog] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsResponse> SearchCatalogsAsync(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchCatalogsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Search [Catalog][google.cloud.privatecatalog.v1beta1.Catalog] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsResponse> SearchCatalogsAsync(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchCatalogs, null, options, request);
      }
      /// <summary>
      /// Search [Product][google.cloud.privatecatalog.v1beta1.Product] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsResponse SearchProducts(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchProducts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Search [Product][google.cloud.privatecatalog.v1beta1.Product] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsResponse SearchProducts(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchProducts, null, options, request);
      }
      /// <summary>
      /// Search [Product][google.cloud.privatecatalog.v1beta1.Product] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsResponse> SearchProductsAsync(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchProductsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Search [Product][google.cloud.privatecatalog.v1beta1.Product] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsResponse> SearchProductsAsync(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchProducts, null, options, request);
      }
      /// <summary>
      /// Search [Version][google.cloud.privatecatalog.v1beta1.Version] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsResponse SearchVersions(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchVersions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Search [Version][google.cloud.privatecatalog.v1beta1.Version] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsResponse SearchVersions(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchVersions, null, options, request);
      }
      /// <summary>
      /// Search [Version][google.cloud.privatecatalog.v1beta1.Version] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsResponse> SearchVersionsAsync(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchVersionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Search [Version][google.cloud.privatecatalog.v1beta1.Version] resources that consumers have access to, within the
      /// scope of the consumer cloud resource hierarchy context.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsResponse> SearchVersionsAsync(global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchVersions, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override PrivateCatalogClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PrivateCatalogClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PrivateCatalogBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SearchCatalogs, serviceImpl.SearchCatalogs)
          .AddMethod(__Method_SearchProducts, serviceImpl.SearchProducts)
          .AddMethod(__Method_SearchVersions, serviceImpl.SearchVersions).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PrivateCatalogBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SearchCatalogs, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsRequest, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchCatalogsResponse>(serviceImpl.SearchCatalogs));
      serviceBinder.AddMethod(__Method_SearchProducts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsRequest, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchProductsResponse>(serviceImpl.SearchProducts));
      serviceBinder.AddMethod(__Method_SearchVersions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsRequest, global::Google.Cloud.PrivateCatalog.V1Beta1.SearchVersionsResponse>(serviceImpl.SearchVersions));
    }

  }
}
#endregion
