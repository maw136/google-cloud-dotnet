// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/optimization/v1/fleet_routing.proto
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
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Optimization.V1 {
  /// <summary>
  /// A service for optimizing vehicle tours.
  ///
  /// Validity of certain types of fields:
  ///
  ///   * `google.protobuf.Timestamp`
  ///     * Times are in Unix time: seconds since 1970-01-01T00:00:00+00:00.
  ///     * seconds must be in [0, 253402300799],
  ///       i.e. in [1970-01-01T00:00:00+00:00, 9999-12-31T23:59:59+00:00].
  ///     * nanos must be unset or set to 0.
  ///   * `google.protobuf.Duration`
  ///     * seconds must be in [0, 253402300799],
  ///       i.e. in [1970-01-01T00:00:00+00:00, 9999-12-31T23:59:59+00:00].
  ///     * nanos must be unset or set to 0.
  ///   * `google.type.LatLng`
  ///     * latitude must be in [-90.0, 90.0].
  ///     * longitude must be in [-180.0, 180.0].
  ///     * at least one of latitude and longitude must be non-zero.
  /// </summary>
  public static partial class FleetRouting
  {
    static readonly string __ServiceName = "google.cloud.optimization.v1.FleetRouting";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Optimization.V1.OptimizeToursRequest> __Marshaller_google_cloud_optimization_v1_OptimizeToursRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Optimization.V1.OptimizeToursRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Optimization.V1.OptimizeToursResponse> __Marshaller_google_cloud_optimization_v1_OptimizeToursResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Optimization.V1.OptimizeToursResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Optimization.V1.BatchOptimizeToursRequest> __Marshaller_google_cloud_optimization_v1_BatchOptimizeToursRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Optimization.V1.BatchOptimizeToursRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Optimization.V1.OptimizeToursRequest, global::Google.Cloud.Optimization.V1.OptimizeToursResponse> __Method_OptimizeTours = new grpc::Method<global::Google.Cloud.Optimization.V1.OptimizeToursRequest, global::Google.Cloud.Optimization.V1.OptimizeToursResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OptimizeTours",
        __Marshaller_google_cloud_optimization_v1_OptimizeToursRequest,
        __Marshaller_google_cloud_optimization_v1_OptimizeToursResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Optimization.V1.BatchOptimizeToursRequest, global::Google.LongRunning.Operation> __Method_BatchOptimizeTours = new grpc::Method<global::Google.Cloud.Optimization.V1.BatchOptimizeToursRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BatchOptimizeTours",
        __Marshaller_google_cloud_optimization_v1_BatchOptimizeToursRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Optimization.V1.FleetRoutingReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FleetRouting</summary>
    [grpc::BindServiceMethod(typeof(FleetRouting), "BindService")]
    public abstract partial class FleetRoutingBase
    {
      /// <summary>
      /// Sends an `OptimizeToursRequest` containing a `ShipmentModel` and returns an
      /// `OptimizeToursResponse` containing `ShipmentRoute`s, which are a set of
      /// routes to be performed by vehicles minimizing the overall cost.
      ///
      /// A `ShipmentModel` model consists mainly of `Shipment`s that need to be
      /// carried out and `Vehicle`s that can be used to transport the `Shipment`s.
      /// The `ShipmentRoute`s assign `Shipment`s to `Vehicle`s. More specifically,
      /// they assign a series of `Visit`s to each vehicle, where a `Visit`
      /// corresponds to a `VisitRequest`, which is a pickup or delivery for a
      /// `Shipment`.
      ///
      /// The goal is to provide an assignment of `ShipmentRoute`s to `Vehicle`s that
      /// minimizes the total cost where cost has many components defined in the
      /// `ShipmentModel`.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Optimization.V1.OptimizeToursResponse> OptimizeTours(global::Google.Cloud.Optimization.V1.OptimizeToursRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
      /// messages as a batch.
      ///
      /// This method is a Long Running Operation (LRO). The inputs for optimization
      /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
      /// messages) are read/written from/to Cloud Storage in user-specified
      /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
      /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
      /// containing `ShipmentRoute`s, which are a set of routes to be performed by
      /// vehicles minimizing the overall cost.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> BatchOptimizeTours(global::Google.Cloud.Optimization.V1.BatchOptimizeToursRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FleetRouting</summary>
    public partial class FleetRoutingClient : grpc::ClientBase<FleetRoutingClient>
    {
      /// <summary>Creates a new client for FleetRouting</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FleetRoutingClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FleetRouting that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FleetRoutingClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FleetRoutingClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FleetRoutingClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends an `OptimizeToursRequest` containing a `ShipmentModel` and returns an
      /// `OptimizeToursResponse` containing `ShipmentRoute`s, which are a set of
      /// routes to be performed by vehicles minimizing the overall cost.
      ///
      /// A `ShipmentModel` model consists mainly of `Shipment`s that need to be
      /// carried out and `Vehicle`s that can be used to transport the `Shipment`s.
      /// The `ShipmentRoute`s assign `Shipment`s to `Vehicle`s. More specifically,
      /// they assign a series of `Visit`s to each vehicle, where a `Visit`
      /// corresponds to a `VisitRequest`, which is a pickup or delivery for a
      /// `Shipment`.
      ///
      /// The goal is to provide an assignment of `ShipmentRoute`s to `Vehicle`s that
      /// minimizes the total cost where cost has many components defined in the
      /// `ShipmentModel`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Optimization.V1.OptimizeToursResponse OptimizeTours(global::Google.Cloud.Optimization.V1.OptimizeToursRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OptimizeTours(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends an `OptimizeToursRequest` containing a `ShipmentModel` and returns an
      /// `OptimizeToursResponse` containing `ShipmentRoute`s, which are a set of
      /// routes to be performed by vehicles minimizing the overall cost.
      ///
      /// A `ShipmentModel` model consists mainly of `Shipment`s that need to be
      /// carried out and `Vehicle`s that can be used to transport the `Shipment`s.
      /// The `ShipmentRoute`s assign `Shipment`s to `Vehicle`s. More specifically,
      /// they assign a series of `Visit`s to each vehicle, where a `Visit`
      /// corresponds to a `VisitRequest`, which is a pickup or delivery for a
      /// `Shipment`.
      ///
      /// The goal is to provide an assignment of `ShipmentRoute`s to `Vehicle`s that
      /// minimizes the total cost where cost has many components defined in the
      /// `ShipmentModel`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Optimization.V1.OptimizeToursResponse OptimizeTours(global::Google.Cloud.Optimization.V1.OptimizeToursRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OptimizeTours, null, options, request);
      }
      /// <summary>
      /// Sends an `OptimizeToursRequest` containing a `ShipmentModel` and returns an
      /// `OptimizeToursResponse` containing `ShipmentRoute`s, which are a set of
      /// routes to be performed by vehicles minimizing the overall cost.
      ///
      /// A `ShipmentModel` model consists mainly of `Shipment`s that need to be
      /// carried out and `Vehicle`s that can be used to transport the `Shipment`s.
      /// The `ShipmentRoute`s assign `Shipment`s to `Vehicle`s. More specifically,
      /// they assign a series of `Visit`s to each vehicle, where a `Visit`
      /// corresponds to a `VisitRequest`, which is a pickup or delivery for a
      /// `Shipment`.
      ///
      /// The goal is to provide an assignment of `ShipmentRoute`s to `Vehicle`s that
      /// minimizes the total cost where cost has many components defined in the
      /// `ShipmentModel`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Optimization.V1.OptimizeToursResponse> OptimizeToursAsync(global::Google.Cloud.Optimization.V1.OptimizeToursRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OptimizeToursAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends an `OptimizeToursRequest` containing a `ShipmentModel` and returns an
      /// `OptimizeToursResponse` containing `ShipmentRoute`s, which are a set of
      /// routes to be performed by vehicles minimizing the overall cost.
      ///
      /// A `ShipmentModel` model consists mainly of `Shipment`s that need to be
      /// carried out and `Vehicle`s that can be used to transport the `Shipment`s.
      /// The `ShipmentRoute`s assign `Shipment`s to `Vehicle`s. More specifically,
      /// they assign a series of `Visit`s to each vehicle, where a `Visit`
      /// corresponds to a `VisitRequest`, which is a pickup or delivery for a
      /// `Shipment`.
      ///
      /// The goal is to provide an assignment of `ShipmentRoute`s to `Vehicle`s that
      /// minimizes the total cost where cost has many components defined in the
      /// `ShipmentModel`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Optimization.V1.OptimizeToursResponse> OptimizeToursAsync(global::Google.Cloud.Optimization.V1.OptimizeToursRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OptimizeTours, null, options, request);
      }
      /// <summary>
      /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
      /// messages as a batch.
      ///
      /// This method is a Long Running Operation (LRO). The inputs for optimization
      /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
      /// messages) are read/written from/to Cloud Storage in user-specified
      /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
      /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
      /// containing `ShipmentRoute`s, which are a set of routes to be performed by
      /// vehicles minimizing the overall cost.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation BatchOptimizeTours(global::Google.Cloud.Optimization.V1.BatchOptimizeToursRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BatchOptimizeTours(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
      /// messages as a batch.
      ///
      /// This method is a Long Running Operation (LRO). The inputs for optimization
      /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
      /// messages) are read/written from/to Cloud Storage in user-specified
      /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
      /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
      /// containing `ShipmentRoute`s, which are a set of routes to be performed by
      /// vehicles minimizing the overall cost.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation BatchOptimizeTours(global::Google.Cloud.Optimization.V1.BatchOptimizeToursRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BatchOptimizeTours, null, options, request);
      }
      /// <summary>
      /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
      /// messages as a batch.
      ///
      /// This method is a Long Running Operation (LRO). The inputs for optimization
      /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
      /// messages) are read/written from/to Cloud Storage in user-specified
      /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
      /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
      /// containing `ShipmentRoute`s, which are a set of routes to be performed by
      /// vehicles minimizing the overall cost.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> BatchOptimizeToursAsync(global::Google.Cloud.Optimization.V1.BatchOptimizeToursRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BatchOptimizeToursAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
      /// messages as a batch.
      ///
      /// This method is a Long Running Operation (LRO). The inputs for optimization
      /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
      /// messages) are read/written from/to Cloud Storage in user-specified
      /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
      /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
      /// containing `ShipmentRoute`s, which are a set of routes to be performed by
      /// vehicles minimizing the overall cost.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> BatchOptimizeToursAsync(global::Google.Cloud.Optimization.V1.BatchOptimizeToursRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BatchOptimizeTours, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override FleetRoutingClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FleetRoutingClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(FleetRoutingBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_OptimizeTours, serviceImpl.OptimizeTours)
          .AddMethod(__Method_BatchOptimizeTours, serviceImpl.BatchOptimizeTours).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FleetRoutingBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_OptimizeTours, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Optimization.V1.OptimizeToursRequest, global::Google.Cloud.Optimization.V1.OptimizeToursResponse>(serviceImpl.OptimizeTours));
      serviceBinder.AddMethod(__Method_BatchOptimizeTours, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Optimization.V1.BatchOptimizeToursRequest, global::Google.LongRunning.Operation>(serviceImpl.BatchOptimizeTours));
    }

  }
}
#endregion
