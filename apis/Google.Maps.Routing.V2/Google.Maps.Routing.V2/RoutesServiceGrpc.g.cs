// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/routing/v2/routes_service.proto
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

namespace Google.Maps.Routing.V2 {
  /// <summary>
  /// The Routes API.
  /// </summary>
  public static partial class Routes
  {
    static readonly string __ServiceName = "google.maps.routing.v2.Routes";

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
    static readonly grpc::Marshaller<global::Google.Maps.Routing.V2.ComputeRoutesRequest> __Marshaller_google_maps_routing_v2_ComputeRoutesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Routing.V2.ComputeRoutesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Maps.Routing.V2.ComputeRoutesResponse> __Marshaller_google_maps_routing_v2_ComputeRoutesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Routing.V2.ComputeRoutesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Maps.Routing.V2.ComputeRouteMatrixRequest> __Marshaller_google_maps_routing_v2_ComputeRouteMatrixRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Routing.V2.ComputeRouteMatrixRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Maps.Routing.V2.RouteMatrixElement> __Marshaller_google_maps_routing_v2_RouteMatrixElement = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Routing.V2.RouteMatrixElement.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Maps.Routing.V2.ComputeRoutesRequest, global::Google.Maps.Routing.V2.ComputeRoutesResponse> __Method_ComputeRoutes = new grpc::Method<global::Google.Maps.Routing.V2.ComputeRoutesRequest, global::Google.Maps.Routing.V2.ComputeRoutesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ComputeRoutes",
        __Marshaller_google_maps_routing_v2_ComputeRoutesRequest,
        __Marshaller_google_maps_routing_v2_ComputeRoutesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Maps.Routing.V2.ComputeRouteMatrixRequest, global::Google.Maps.Routing.V2.RouteMatrixElement> __Method_ComputeRouteMatrix = new grpc::Method<global::Google.Maps.Routing.V2.ComputeRouteMatrixRequest, global::Google.Maps.Routing.V2.RouteMatrixElement>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ComputeRouteMatrix",
        __Marshaller_google_maps_routing_v2_ComputeRouteMatrixRequest,
        __Marshaller_google_maps_routing_v2_RouteMatrixElement);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Maps.Routing.V2.RoutesServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Routes</summary>
    [grpc::BindServiceMethod(typeof(Routes), "BindService")]
    public abstract partial class RoutesBase
    {
      /// <summary>
      /// Returns the primary route along with optional alternate routes, given a set
      /// of terminal and intermediate waypoints.
      ///
      /// **NOTE:** This method requires that you specify a response field mask in
      /// the input. You can provide the response field mask by using URL parameter
      /// `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
      /// (see the [available URL parameters and
      /// headers](https://cloud.google.com/apis/docs/system-parameters). The value
      /// is a comma separated list of field paths. See detailed documentation about
      /// [how to construct the field
      /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
      ///
      /// For example, in this method:
      ///
      /// * Field mask of all available fields (for manual inspection):
      ///   `X-Goog-FieldMask: *`
      /// * Field mask of Route-level duration, distance, and polyline (an example
      /// production setup):
      ///   `X-Goog-FieldMask:
      ///   routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
      ///
      /// Google discourage the use of the wildcard (`*`) response field mask, or
      /// specifying the field mask at the top level (`routes`), because:
      ///
      /// * Selecting only the fields that you need helps our server save computation
      /// cycles, allowing us to return the result to you with a lower latency.
      /// * Selecting only the fields that you need
      /// in your production job ensures stable latency performance. We might add
      /// more response fields in the future, and those new fields might require
      /// extra computation time. If you select all fields, or if you select all
      /// fields at the top level, then you might experience performance degradation
      /// because any new field we add will be automatically included in the
      /// response.
      /// * Selecting only the fields that you need results in a smaller response
      /// size, and thus higher network throughput.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Maps.Routing.V2.ComputeRoutesResponse> ComputeRoutes(global::Google.Maps.Routing.V2.ComputeRoutesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Takes in a list of origins and destinations and returns a stream containing
      /// route information for each combination of origin and destination.
      ///
      /// **NOTE:** This method requires that you specify a response field mask in
      /// the input. You can provide the response field mask by using the URL
      /// parameter `$fields` or `fields`, or by using the HTTP/gRPC header
      /// `X-Goog-FieldMask` (see the [available URL parameters and
      /// headers](https://cloud.google.com/apis/docs/system-parameters). The value
      /// is a comma separated list of field paths. See this detailed documentation
      /// about [how to construct the field
      /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
      ///
      /// For example, in this method:
      ///
      /// * Field mask of all available fields (for manual inspection):
      ///   `X-Goog-FieldMask: *`
      /// * Field mask of route durations, distances, element status, condition, and
      ///   element indices (an example production setup):
      ///   `X-Goog-FieldMask:
      ///   originIndex,destinationIndex,status,condition,distanceMeters,duration`
      ///
      /// It is critical that you include `status` in your field mask as otherwise
      /// all messages will appear to be OK. Google discourages the use of the
      /// wildcard (`*`) response field mask, because:
      ///
      /// * Selecting only the fields that you need helps our server save computation
      /// cycles, allowing us to return the result to you with a lower latency.
      /// * Selecting only the fields that you need in your production job ensures
      /// stable latency performance. We might add more response fields in the
      /// future, and those new fields might require extra computation time. If you
      /// select all fields, or if you select all fields at the top level, then you
      /// might experience performance degradation because any new field we add will
      /// be automatically included in the response.
      /// * Selecting only the fields that you need results in a smaller response
      /// size, and thus higher network throughput.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ComputeRouteMatrix(global::Google.Maps.Routing.V2.ComputeRouteMatrixRequest request, grpc::IServerStreamWriter<global::Google.Maps.Routing.V2.RouteMatrixElement> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Routes</summary>
    public partial class RoutesClient : grpc::ClientBase<RoutesClient>
    {
      /// <summary>Creates a new client for Routes</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public RoutesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Routes that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public RoutesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected RoutesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected RoutesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the primary route along with optional alternate routes, given a set
      /// of terminal and intermediate waypoints.
      ///
      /// **NOTE:** This method requires that you specify a response field mask in
      /// the input. You can provide the response field mask by using URL parameter
      /// `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
      /// (see the [available URL parameters and
      /// headers](https://cloud.google.com/apis/docs/system-parameters). The value
      /// is a comma separated list of field paths. See detailed documentation about
      /// [how to construct the field
      /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
      ///
      /// For example, in this method:
      ///
      /// * Field mask of all available fields (for manual inspection):
      ///   `X-Goog-FieldMask: *`
      /// * Field mask of Route-level duration, distance, and polyline (an example
      /// production setup):
      ///   `X-Goog-FieldMask:
      ///   routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
      ///
      /// Google discourage the use of the wildcard (`*`) response field mask, or
      /// specifying the field mask at the top level (`routes`), because:
      ///
      /// * Selecting only the fields that you need helps our server save computation
      /// cycles, allowing us to return the result to you with a lower latency.
      /// * Selecting only the fields that you need
      /// in your production job ensures stable latency performance. We might add
      /// more response fields in the future, and those new fields might require
      /// extra computation time. If you select all fields, or if you select all
      /// fields at the top level, then you might experience performance degradation
      /// because any new field we add will be automatically included in the
      /// response.
      /// * Selecting only the fields that you need results in a smaller response
      /// size, and thus higher network throughput.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Maps.Routing.V2.ComputeRoutesResponse ComputeRoutes(global::Google.Maps.Routing.V2.ComputeRoutesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ComputeRoutes(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the primary route along with optional alternate routes, given a set
      /// of terminal and intermediate waypoints.
      ///
      /// **NOTE:** This method requires that you specify a response field mask in
      /// the input. You can provide the response field mask by using URL parameter
      /// `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
      /// (see the [available URL parameters and
      /// headers](https://cloud.google.com/apis/docs/system-parameters). The value
      /// is a comma separated list of field paths. See detailed documentation about
      /// [how to construct the field
      /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
      ///
      /// For example, in this method:
      ///
      /// * Field mask of all available fields (for manual inspection):
      ///   `X-Goog-FieldMask: *`
      /// * Field mask of Route-level duration, distance, and polyline (an example
      /// production setup):
      ///   `X-Goog-FieldMask:
      ///   routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
      ///
      /// Google discourage the use of the wildcard (`*`) response field mask, or
      /// specifying the field mask at the top level (`routes`), because:
      ///
      /// * Selecting only the fields that you need helps our server save computation
      /// cycles, allowing us to return the result to you with a lower latency.
      /// * Selecting only the fields that you need
      /// in your production job ensures stable latency performance. We might add
      /// more response fields in the future, and those new fields might require
      /// extra computation time. If you select all fields, or if you select all
      /// fields at the top level, then you might experience performance degradation
      /// because any new field we add will be automatically included in the
      /// response.
      /// * Selecting only the fields that you need results in a smaller response
      /// size, and thus higher network throughput.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Maps.Routing.V2.ComputeRoutesResponse ComputeRoutes(global::Google.Maps.Routing.V2.ComputeRoutesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ComputeRoutes, null, options, request);
      }
      /// <summary>
      /// Returns the primary route along with optional alternate routes, given a set
      /// of terminal and intermediate waypoints.
      ///
      /// **NOTE:** This method requires that you specify a response field mask in
      /// the input. You can provide the response field mask by using URL parameter
      /// `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
      /// (see the [available URL parameters and
      /// headers](https://cloud.google.com/apis/docs/system-parameters). The value
      /// is a comma separated list of field paths. See detailed documentation about
      /// [how to construct the field
      /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
      ///
      /// For example, in this method:
      ///
      /// * Field mask of all available fields (for manual inspection):
      ///   `X-Goog-FieldMask: *`
      /// * Field mask of Route-level duration, distance, and polyline (an example
      /// production setup):
      ///   `X-Goog-FieldMask:
      ///   routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
      ///
      /// Google discourage the use of the wildcard (`*`) response field mask, or
      /// specifying the field mask at the top level (`routes`), because:
      ///
      /// * Selecting only the fields that you need helps our server save computation
      /// cycles, allowing us to return the result to you with a lower latency.
      /// * Selecting only the fields that you need
      /// in your production job ensures stable latency performance. We might add
      /// more response fields in the future, and those new fields might require
      /// extra computation time. If you select all fields, or if you select all
      /// fields at the top level, then you might experience performance degradation
      /// because any new field we add will be automatically included in the
      /// response.
      /// * Selecting only the fields that you need results in a smaller response
      /// size, and thus higher network throughput.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Maps.Routing.V2.ComputeRoutesResponse> ComputeRoutesAsync(global::Google.Maps.Routing.V2.ComputeRoutesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ComputeRoutesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the primary route along with optional alternate routes, given a set
      /// of terminal and intermediate waypoints.
      ///
      /// **NOTE:** This method requires that you specify a response field mask in
      /// the input. You can provide the response field mask by using URL parameter
      /// `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
      /// (see the [available URL parameters and
      /// headers](https://cloud.google.com/apis/docs/system-parameters). The value
      /// is a comma separated list of field paths. See detailed documentation about
      /// [how to construct the field
      /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
      ///
      /// For example, in this method:
      ///
      /// * Field mask of all available fields (for manual inspection):
      ///   `X-Goog-FieldMask: *`
      /// * Field mask of Route-level duration, distance, and polyline (an example
      /// production setup):
      ///   `X-Goog-FieldMask:
      ///   routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
      ///
      /// Google discourage the use of the wildcard (`*`) response field mask, or
      /// specifying the field mask at the top level (`routes`), because:
      ///
      /// * Selecting only the fields that you need helps our server save computation
      /// cycles, allowing us to return the result to you with a lower latency.
      /// * Selecting only the fields that you need
      /// in your production job ensures stable latency performance. We might add
      /// more response fields in the future, and those new fields might require
      /// extra computation time. If you select all fields, or if you select all
      /// fields at the top level, then you might experience performance degradation
      /// because any new field we add will be automatically included in the
      /// response.
      /// * Selecting only the fields that you need results in a smaller response
      /// size, and thus higher network throughput.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Maps.Routing.V2.ComputeRoutesResponse> ComputeRoutesAsync(global::Google.Maps.Routing.V2.ComputeRoutesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ComputeRoutes, null, options, request);
      }
      /// <summary>
      /// Takes in a list of origins and destinations and returns a stream containing
      /// route information for each combination of origin and destination.
      ///
      /// **NOTE:** This method requires that you specify a response field mask in
      /// the input. You can provide the response field mask by using the URL
      /// parameter `$fields` or `fields`, or by using the HTTP/gRPC header
      /// `X-Goog-FieldMask` (see the [available URL parameters and
      /// headers](https://cloud.google.com/apis/docs/system-parameters). The value
      /// is a comma separated list of field paths. See this detailed documentation
      /// about [how to construct the field
      /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
      ///
      /// For example, in this method:
      ///
      /// * Field mask of all available fields (for manual inspection):
      ///   `X-Goog-FieldMask: *`
      /// * Field mask of route durations, distances, element status, condition, and
      ///   element indices (an example production setup):
      ///   `X-Goog-FieldMask:
      ///   originIndex,destinationIndex,status,condition,distanceMeters,duration`
      ///
      /// It is critical that you include `status` in your field mask as otherwise
      /// all messages will appear to be OK. Google discourages the use of the
      /// wildcard (`*`) response field mask, because:
      ///
      /// * Selecting only the fields that you need helps our server save computation
      /// cycles, allowing us to return the result to you with a lower latency.
      /// * Selecting only the fields that you need in your production job ensures
      /// stable latency performance. We might add more response fields in the
      /// future, and those new fields might require extra computation time. If you
      /// select all fields, or if you select all fields at the top level, then you
      /// might experience performance degradation because any new field we add will
      /// be automatically included in the response.
      /// * Selecting only the fields that you need results in a smaller response
      /// size, and thus higher network throughput.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Google.Maps.Routing.V2.RouteMatrixElement> ComputeRouteMatrix(global::Google.Maps.Routing.V2.ComputeRouteMatrixRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ComputeRouteMatrix(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Takes in a list of origins and destinations and returns a stream containing
      /// route information for each combination of origin and destination.
      ///
      /// **NOTE:** This method requires that you specify a response field mask in
      /// the input. You can provide the response field mask by using the URL
      /// parameter `$fields` or `fields`, or by using the HTTP/gRPC header
      /// `X-Goog-FieldMask` (see the [available URL parameters and
      /// headers](https://cloud.google.com/apis/docs/system-parameters). The value
      /// is a comma separated list of field paths. See this detailed documentation
      /// about [how to construct the field
      /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
      ///
      /// For example, in this method:
      ///
      /// * Field mask of all available fields (for manual inspection):
      ///   `X-Goog-FieldMask: *`
      /// * Field mask of route durations, distances, element status, condition, and
      ///   element indices (an example production setup):
      ///   `X-Goog-FieldMask:
      ///   originIndex,destinationIndex,status,condition,distanceMeters,duration`
      ///
      /// It is critical that you include `status` in your field mask as otherwise
      /// all messages will appear to be OK. Google discourages the use of the
      /// wildcard (`*`) response field mask, because:
      ///
      /// * Selecting only the fields that you need helps our server save computation
      /// cycles, allowing us to return the result to you with a lower latency.
      /// * Selecting only the fields that you need in your production job ensures
      /// stable latency performance. We might add more response fields in the
      /// future, and those new fields might require extra computation time. If you
      /// select all fields, or if you select all fields at the top level, then you
      /// might experience performance degradation because any new field we add will
      /// be automatically included in the response.
      /// * Selecting only the fields that you need results in a smaller response
      /// size, and thus higher network throughput.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Google.Maps.Routing.V2.RouteMatrixElement> ComputeRouteMatrix(global::Google.Maps.Routing.V2.ComputeRouteMatrixRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ComputeRouteMatrix, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override RoutesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RoutesClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(RoutesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ComputeRoutes, serviceImpl.ComputeRoutes)
          .AddMethod(__Method_ComputeRouteMatrix, serviceImpl.ComputeRouteMatrix).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RoutesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ComputeRoutes, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Maps.Routing.V2.ComputeRoutesRequest, global::Google.Maps.Routing.V2.ComputeRoutesResponse>(serviceImpl.ComputeRoutes));
      serviceBinder.AddMethod(__Method_ComputeRouteMatrix, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Maps.Routing.V2.ComputeRouteMatrixRequest, global::Google.Maps.Routing.V2.RouteMatrixElement>(serviceImpl.ComputeRouteMatrix));
    }

  }
}
#endregion