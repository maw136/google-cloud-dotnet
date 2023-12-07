// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/places/v1/places_service.proto
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

namespace Google.Maps.Places.V1 {
  /// <summary>
  /// Service definition for the Places API.
  /// Note: every request actually requires a field mask set outside of
  /// the request proto (all/'*', is not assumed).  That can be set via either a
  /// side channel (SystemParameterContext) over RPC, or a header
  /// (X-Goog-FieldMask) over HTTP. See:
  /// https://cloud.google.com/apis/docs/system-parameters
  /// </summary>
  public static partial class Places
  {
    static readonly string __ServiceName = "google.maps.places.v1.Places";

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
    static readonly grpc::Marshaller<global::Google.Maps.Places.V1.SearchNearbyRequest> __Marshaller_google_maps_places_v1_SearchNearbyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Places.V1.SearchNearbyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Maps.Places.V1.SearchNearbyResponse> __Marshaller_google_maps_places_v1_SearchNearbyResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Places.V1.SearchNearbyResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Maps.Places.V1.SearchTextRequest> __Marshaller_google_maps_places_v1_SearchTextRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Places.V1.SearchTextRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Maps.Places.V1.SearchTextResponse> __Marshaller_google_maps_places_v1_SearchTextResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Places.V1.SearchTextResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Maps.Places.V1.GetPhotoMediaRequest> __Marshaller_google_maps_places_v1_GetPhotoMediaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Places.V1.GetPhotoMediaRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Maps.Places.V1.PhotoMedia> __Marshaller_google_maps_places_v1_PhotoMedia = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Places.V1.PhotoMedia.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Maps.Places.V1.GetPlaceRequest> __Marshaller_google_maps_places_v1_GetPlaceRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Places.V1.GetPlaceRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Maps.Places.V1.Place> __Marshaller_google_maps_places_v1_Place = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Maps.Places.V1.Place.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Maps.Places.V1.SearchNearbyRequest, global::Google.Maps.Places.V1.SearchNearbyResponse> __Method_SearchNearby = new grpc::Method<global::Google.Maps.Places.V1.SearchNearbyRequest, global::Google.Maps.Places.V1.SearchNearbyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchNearby",
        __Marshaller_google_maps_places_v1_SearchNearbyRequest,
        __Marshaller_google_maps_places_v1_SearchNearbyResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Maps.Places.V1.SearchTextRequest, global::Google.Maps.Places.V1.SearchTextResponse> __Method_SearchText = new grpc::Method<global::Google.Maps.Places.V1.SearchTextRequest, global::Google.Maps.Places.V1.SearchTextResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchText",
        __Marshaller_google_maps_places_v1_SearchTextRequest,
        __Marshaller_google_maps_places_v1_SearchTextResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Maps.Places.V1.GetPhotoMediaRequest, global::Google.Maps.Places.V1.PhotoMedia> __Method_GetPhotoMedia = new grpc::Method<global::Google.Maps.Places.V1.GetPhotoMediaRequest, global::Google.Maps.Places.V1.PhotoMedia>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPhotoMedia",
        __Marshaller_google_maps_places_v1_GetPhotoMediaRequest,
        __Marshaller_google_maps_places_v1_PhotoMedia);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Maps.Places.V1.GetPlaceRequest, global::Google.Maps.Places.V1.Place> __Method_GetPlace = new grpc::Method<global::Google.Maps.Places.V1.GetPlaceRequest, global::Google.Maps.Places.V1.Place>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPlace",
        __Marshaller_google_maps_places_v1_GetPlaceRequest,
        __Marshaller_google_maps_places_v1_Place);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Maps.Places.V1.PlacesServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Places</summary>
    [grpc::BindServiceMethod(typeof(Places), "BindService")]
    public abstract partial class PlacesBase
    {
      /// <summary>
      /// Search for places near locations.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Maps.Places.V1.SearchNearbyResponse> SearchNearby(global::Google.Maps.Places.V1.SearchNearbyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Text query based place search.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Maps.Places.V1.SearchTextResponse> SearchText(global::Google.Maps.Places.V1.SearchTextRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get a photo media with a photo reference string.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Maps.Places.V1.PhotoMedia> GetPhotoMedia(global::Google.Maps.Places.V1.GetPhotoMediaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get place details with a place id (in a name) string.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Maps.Places.V1.Place> GetPlace(global::Google.Maps.Places.V1.GetPlaceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Places</summary>
    public partial class PlacesClient : grpc::ClientBase<PlacesClient>
    {
      /// <summary>Creates a new client for Places</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PlacesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Places that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PlacesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PlacesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PlacesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Search for places near locations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Maps.Places.V1.SearchNearbyResponse SearchNearby(global::Google.Maps.Places.V1.SearchNearbyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchNearby(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Search for places near locations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Maps.Places.V1.SearchNearbyResponse SearchNearby(global::Google.Maps.Places.V1.SearchNearbyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchNearby, null, options, request);
      }
      /// <summary>
      /// Search for places near locations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Maps.Places.V1.SearchNearbyResponse> SearchNearbyAsync(global::Google.Maps.Places.V1.SearchNearbyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchNearbyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Search for places near locations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Maps.Places.V1.SearchNearbyResponse> SearchNearbyAsync(global::Google.Maps.Places.V1.SearchNearbyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchNearby, null, options, request);
      }
      /// <summary>
      /// Text query based place search.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Maps.Places.V1.SearchTextResponse SearchText(global::Google.Maps.Places.V1.SearchTextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchText(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Text query based place search.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Maps.Places.V1.SearchTextResponse SearchText(global::Google.Maps.Places.V1.SearchTextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchText, null, options, request);
      }
      /// <summary>
      /// Text query based place search.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Maps.Places.V1.SearchTextResponse> SearchTextAsync(global::Google.Maps.Places.V1.SearchTextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchTextAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Text query based place search.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Maps.Places.V1.SearchTextResponse> SearchTextAsync(global::Google.Maps.Places.V1.SearchTextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchText, null, options, request);
      }
      /// <summary>
      /// Get a photo media with a photo reference string.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Maps.Places.V1.PhotoMedia GetPhotoMedia(global::Google.Maps.Places.V1.GetPhotoMediaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPhotoMedia(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a photo media with a photo reference string.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Maps.Places.V1.PhotoMedia GetPhotoMedia(global::Google.Maps.Places.V1.GetPhotoMediaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPhotoMedia, null, options, request);
      }
      /// <summary>
      /// Get a photo media with a photo reference string.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Maps.Places.V1.PhotoMedia> GetPhotoMediaAsync(global::Google.Maps.Places.V1.GetPhotoMediaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPhotoMediaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get a photo media with a photo reference string.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Maps.Places.V1.PhotoMedia> GetPhotoMediaAsync(global::Google.Maps.Places.V1.GetPhotoMediaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPhotoMedia, null, options, request);
      }
      /// <summary>
      /// Get place details with a place id (in a name) string.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Maps.Places.V1.Place GetPlace(global::Google.Maps.Places.V1.GetPlaceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPlace(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get place details with a place id (in a name) string.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Maps.Places.V1.Place GetPlace(global::Google.Maps.Places.V1.GetPlaceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPlace, null, options, request);
      }
      /// <summary>
      /// Get place details with a place id (in a name) string.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Maps.Places.V1.Place> GetPlaceAsync(global::Google.Maps.Places.V1.GetPlaceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPlaceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get place details with a place id (in a name) string.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Maps.Places.V1.Place> GetPlaceAsync(global::Google.Maps.Places.V1.GetPlaceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPlace, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override PlacesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PlacesClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PlacesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SearchNearby, serviceImpl.SearchNearby)
          .AddMethod(__Method_SearchText, serviceImpl.SearchText)
          .AddMethod(__Method_GetPhotoMedia, serviceImpl.GetPhotoMedia)
          .AddMethod(__Method_GetPlace, serviceImpl.GetPlace).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PlacesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SearchNearby, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Maps.Places.V1.SearchNearbyRequest, global::Google.Maps.Places.V1.SearchNearbyResponse>(serviceImpl.SearchNearby));
      serviceBinder.AddMethod(__Method_SearchText, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Maps.Places.V1.SearchTextRequest, global::Google.Maps.Places.V1.SearchTextResponse>(serviceImpl.SearchText));
      serviceBinder.AddMethod(__Method_GetPhotoMedia, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Maps.Places.V1.GetPhotoMediaRequest, global::Google.Maps.Places.V1.PhotoMedia>(serviceImpl.GetPhotoMedia));
      serviceBinder.AddMethod(__Method_GetPlace, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Maps.Places.V1.GetPlaceRequest, global::Google.Maps.Places.V1.Place>(serviceImpl.GetPlace));
    }

  }
}
#endregion
