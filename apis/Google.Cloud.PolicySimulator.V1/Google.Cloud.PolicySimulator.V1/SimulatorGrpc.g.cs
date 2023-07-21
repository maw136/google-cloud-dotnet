// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/policysimulator/v1/simulator.proto
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

namespace Google.Cloud.PolicySimulator.V1 {
  /// <summary>
  /// Policy Simulator API service.
  ///
  /// Policy Simulator is a collection of endpoints for creating, running, and
  /// viewing a [Replay][google.cloud.policysimulator.v1.Replay]. A
  /// [Replay][google.cloud.policysimulator.v1.Replay] is a type of simulation that
  /// lets you see how your principals' access to resources might change if you
  /// changed your IAM policy.
  ///
  /// During a [Replay][google.cloud.policysimulator.v1.Replay], Policy Simulator
  /// re-evaluates, or replays, past access attempts under both the current policy
  /// and  your proposed policy, and compares those results to determine how your
  /// principals' access might change under the proposed policy.
  /// </summary>
  public static partial class Simulator
  {
    static readonly string __ServiceName = "google.cloud.policysimulator.v1.Simulator";

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
    static readonly grpc::Marshaller<global::Google.Cloud.PolicySimulator.V1.GetReplayRequest> __Marshaller_google_cloud_policysimulator_v1_GetReplayRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PolicySimulator.V1.GetReplayRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.PolicySimulator.V1.Replay> __Marshaller_google_cloud_policysimulator_v1_Replay = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PolicySimulator.V1.Replay.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.PolicySimulator.V1.CreateReplayRequest> __Marshaller_google_cloud_policysimulator_v1_CreateReplayRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PolicySimulator.V1.CreateReplayRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.PolicySimulator.V1.ListReplayResultsRequest> __Marshaller_google_cloud_policysimulator_v1_ListReplayResultsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PolicySimulator.V1.ListReplayResultsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.PolicySimulator.V1.ListReplayResultsResponse> __Marshaller_google_cloud_policysimulator_v1_ListReplayResultsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PolicySimulator.V1.ListReplayResultsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.PolicySimulator.V1.GetReplayRequest, global::Google.Cloud.PolicySimulator.V1.Replay> __Method_GetReplay = new grpc::Method<global::Google.Cloud.PolicySimulator.V1.GetReplayRequest, global::Google.Cloud.PolicySimulator.V1.Replay>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetReplay",
        __Marshaller_google_cloud_policysimulator_v1_GetReplayRequest,
        __Marshaller_google_cloud_policysimulator_v1_Replay);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.PolicySimulator.V1.CreateReplayRequest, global::Google.LongRunning.Operation> __Method_CreateReplay = new grpc::Method<global::Google.Cloud.PolicySimulator.V1.CreateReplayRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateReplay",
        __Marshaller_google_cloud_policysimulator_v1_CreateReplayRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.PolicySimulator.V1.ListReplayResultsRequest, global::Google.Cloud.PolicySimulator.V1.ListReplayResultsResponse> __Method_ListReplayResults = new grpc::Method<global::Google.Cloud.PolicySimulator.V1.ListReplayResultsRequest, global::Google.Cloud.PolicySimulator.V1.ListReplayResultsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListReplayResults",
        __Marshaller_google_cloud_policysimulator_v1_ListReplayResultsRequest,
        __Marshaller_google_cloud_policysimulator_v1_ListReplayResultsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.PolicySimulator.V1.SimulatorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Simulator</summary>
    [grpc::BindServiceMethod(typeof(Simulator), "BindService")]
    public abstract partial class SimulatorBase
    {
      /// <summary>
      /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
      /// `Replay` is available for at least 7 days.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.PolicySimulator.V1.Replay> GetReplay(global::Google.Cloud.PolicySimulator.V1.GetReplayRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
      /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateReplay(global::Google.Cloud.PolicySimulator.V1.CreateReplayRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists the results of running a
      /// [Replay][google.cloud.policysimulator.v1.Replay].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.PolicySimulator.V1.ListReplayResultsResponse> ListReplayResults(global::Google.Cloud.PolicySimulator.V1.ListReplayResultsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Simulator</summary>
    public partial class SimulatorClient : grpc::ClientBase<SimulatorClient>
    {
      /// <summary>Creates a new client for Simulator</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SimulatorClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Simulator that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SimulatorClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SimulatorClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SimulatorClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
      /// `Replay` is available for at least 7 days.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.PolicySimulator.V1.Replay GetReplay(global::Google.Cloud.PolicySimulator.V1.GetReplayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetReplay(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
      /// `Replay` is available for at least 7 days.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.PolicySimulator.V1.Replay GetReplay(global::Google.Cloud.PolicySimulator.V1.GetReplayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReplay, null, options, request);
      }
      /// <summary>
      /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
      /// `Replay` is available for at least 7 days.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PolicySimulator.V1.Replay> GetReplayAsync(global::Google.Cloud.PolicySimulator.V1.GetReplayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetReplayAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
      /// `Replay` is available for at least 7 days.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PolicySimulator.V1.Replay> GetReplayAsync(global::Google.Cloud.PolicySimulator.V1.GetReplayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReplay, null, options, request);
      }
      /// <summary>
      /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
      /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateReplay(global::Google.Cloud.PolicySimulator.V1.CreateReplayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateReplay(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
      /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateReplay(global::Google.Cloud.PolicySimulator.V1.CreateReplayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateReplay, null, options, request);
      }
      /// <summary>
      /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
      /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateReplayAsync(global::Google.Cloud.PolicySimulator.V1.CreateReplayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateReplayAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
      /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateReplayAsync(global::Google.Cloud.PolicySimulator.V1.CreateReplayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateReplay, null, options, request);
      }
      /// <summary>
      /// Lists the results of running a
      /// [Replay][google.cloud.policysimulator.v1.Replay].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.PolicySimulator.V1.ListReplayResultsResponse ListReplayResults(global::Google.Cloud.PolicySimulator.V1.ListReplayResultsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListReplayResults(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the results of running a
      /// [Replay][google.cloud.policysimulator.v1.Replay].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.PolicySimulator.V1.ListReplayResultsResponse ListReplayResults(global::Google.Cloud.PolicySimulator.V1.ListReplayResultsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListReplayResults, null, options, request);
      }
      /// <summary>
      /// Lists the results of running a
      /// [Replay][google.cloud.policysimulator.v1.Replay].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PolicySimulator.V1.ListReplayResultsResponse> ListReplayResultsAsync(global::Google.Cloud.PolicySimulator.V1.ListReplayResultsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListReplayResultsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the results of running a
      /// [Replay][google.cloud.policysimulator.v1.Replay].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PolicySimulator.V1.ListReplayResultsResponse> ListReplayResultsAsync(global::Google.Cloud.PolicySimulator.V1.ListReplayResultsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListReplayResults, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override SimulatorClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SimulatorClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SimulatorBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetReplay, serviceImpl.GetReplay)
          .AddMethod(__Method_CreateReplay, serviceImpl.CreateReplay)
          .AddMethod(__Method_ListReplayResults, serviceImpl.ListReplayResults).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SimulatorBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetReplay, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PolicySimulator.V1.GetReplayRequest, global::Google.Cloud.PolicySimulator.V1.Replay>(serviceImpl.GetReplay));
      serviceBinder.AddMethod(__Method_CreateReplay, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PolicySimulator.V1.CreateReplayRequest, global::Google.LongRunning.Operation>(serviceImpl.CreateReplay));
      serviceBinder.AddMethod(__Method_ListReplayResults, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PolicySimulator.V1.ListReplayResultsRequest, global::Google.Cloud.PolicySimulator.V1.ListReplayResultsResponse>(serviceImpl.ListReplayResults));
    }

  }
}
#endregion
