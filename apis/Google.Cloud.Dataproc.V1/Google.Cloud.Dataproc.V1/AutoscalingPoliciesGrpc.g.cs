// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dataproc/v1/autoscaling_policies.proto
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
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Dataproc.V1 {
  /// <summary>
  /// The API interface for managing autoscaling policies in the
  /// Dataproc API.
  /// </summary>
  public static partial class AutoscalingPolicyService
  {
    static readonly string __ServiceName = "google.cloud.dataproc.v1.AutoscalingPolicyService";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.CreateAutoscalingPolicyRequest> __Marshaller_google_cloud_dataproc_v1_CreateAutoscalingPolicyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.CreateAutoscalingPolicyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> __Marshaller_google_cloud_dataproc_v1_AutoscalingPolicy = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.AutoscalingPolicy.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.UpdateAutoscalingPolicyRequest> __Marshaller_google_cloud_dataproc_v1_UpdateAutoscalingPolicyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.UpdateAutoscalingPolicyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.GetAutoscalingPolicyRequest> __Marshaller_google_cloud_dataproc_v1_GetAutoscalingPolicyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.GetAutoscalingPolicyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesRequest> __Marshaller_google_cloud_dataproc_v1_ListAutoscalingPoliciesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesResponse> __Marshaller_google_cloud_dataproc_v1_ListAutoscalingPoliciesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataproc.V1.DeleteAutoscalingPolicyRequest> __Marshaller_google_cloud_dataproc_v1_DeleteAutoscalingPolicyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataproc.V1.DeleteAutoscalingPolicyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataproc.V1.CreateAutoscalingPolicyRequest, global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> __Method_CreateAutoscalingPolicy = new grpc::Method<global::Google.Cloud.Dataproc.V1.CreateAutoscalingPolicyRequest, global::Google.Cloud.Dataproc.V1.AutoscalingPolicy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateAutoscalingPolicy",
        __Marshaller_google_cloud_dataproc_v1_CreateAutoscalingPolicyRequest,
        __Marshaller_google_cloud_dataproc_v1_AutoscalingPolicy);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataproc.V1.UpdateAutoscalingPolicyRequest, global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> __Method_UpdateAutoscalingPolicy = new grpc::Method<global::Google.Cloud.Dataproc.V1.UpdateAutoscalingPolicyRequest, global::Google.Cloud.Dataproc.V1.AutoscalingPolicy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateAutoscalingPolicy",
        __Marshaller_google_cloud_dataproc_v1_UpdateAutoscalingPolicyRequest,
        __Marshaller_google_cloud_dataproc_v1_AutoscalingPolicy);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataproc.V1.GetAutoscalingPolicyRequest, global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> __Method_GetAutoscalingPolicy = new grpc::Method<global::Google.Cloud.Dataproc.V1.GetAutoscalingPolicyRequest, global::Google.Cloud.Dataproc.V1.AutoscalingPolicy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAutoscalingPolicy",
        __Marshaller_google_cloud_dataproc_v1_GetAutoscalingPolicyRequest,
        __Marshaller_google_cloud_dataproc_v1_AutoscalingPolicy);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesRequest, global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesResponse> __Method_ListAutoscalingPolicies = new grpc::Method<global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesRequest, global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListAutoscalingPolicies",
        __Marshaller_google_cloud_dataproc_v1_ListAutoscalingPoliciesRequest,
        __Marshaller_google_cloud_dataproc_v1_ListAutoscalingPoliciesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataproc.V1.DeleteAutoscalingPolicyRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteAutoscalingPolicy = new grpc::Method<global::Google.Cloud.Dataproc.V1.DeleteAutoscalingPolicyRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteAutoscalingPolicy",
        __Marshaller_google_cloud_dataproc_v1_DeleteAutoscalingPolicyRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dataproc.V1.AutoscalingPoliciesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AutoscalingPolicyService</summary>
    [grpc::BindServiceMethod(typeof(AutoscalingPolicyService), "BindService")]
    public abstract partial class AutoscalingPolicyServiceBase
    {
      /// <summary>
      /// Creates new autoscaling policy.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> CreateAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.CreateAutoscalingPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates (replaces) autoscaling policy.
      ///
      /// Disabled check for update_mask, because all updates will be full
      /// replacements.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> UpdateAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.UpdateAutoscalingPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves autoscaling policy.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> GetAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.GetAutoscalingPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists autoscaling policies in the project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesResponse> ListAutoscalingPolicies(global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes an autoscaling policy. It is an error to delete an autoscaling
      /// policy that is in use by one or more clusters.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.DeleteAutoscalingPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AutoscalingPolicyService</summary>
    public partial class AutoscalingPolicyServiceClient : grpc::ClientBase<AutoscalingPolicyServiceClient>
    {
      /// <summary>Creates a new client for AutoscalingPolicyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AutoscalingPolicyServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AutoscalingPolicyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AutoscalingPolicyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AutoscalingPolicyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AutoscalingPolicyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates new autoscaling policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.AutoscalingPolicy CreateAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.CreateAutoscalingPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAutoscalingPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates new autoscaling policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.AutoscalingPolicy CreateAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.CreateAutoscalingPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateAutoscalingPolicy, null, options, request);
      }
      /// <summary>
      /// Creates new autoscaling policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> CreateAutoscalingPolicyAsync(global::Google.Cloud.Dataproc.V1.CreateAutoscalingPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAutoscalingPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates new autoscaling policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> CreateAutoscalingPolicyAsync(global::Google.Cloud.Dataproc.V1.CreateAutoscalingPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateAutoscalingPolicy, null, options, request);
      }
      /// <summary>
      /// Updates (replaces) autoscaling policy.
      ///
      /// Disabled check for update_mask, because all updates will be full
      /// replacements.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.AutoscalingPolicy UpdateAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.UpdateAutoscalingPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAutoscalingPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates (replaces) autoscaling policy.
      ///
      /// Disabled check for update_mask, because all updates will be full
      /// replacements.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.AutoscalingPolicy UpdateAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.UpdateAutoscalingPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateAutoscalingPolicy, null, options, request);
      }
      /// <summary>
      /// Updates (replaces) autoscaling policy.
      ///
      /// Disabled check for update_mask, because all updates will be full
      /// replacements.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> UpdateAutoscalingPolicyAsync(global::Google.Cloud.Dataproc.V1.UpdateAutoscalingPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAutoscalingPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates (replaces) autoscaling policy.
      ///
      /// Disabled check for update_mask, because all updates will be full
      /// replacements.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> UpdateAutoscalingPolicyAsync(global::Google.Cloud.Dataproc.V1.UpdateAutoscalingPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateAutoscalingPolicy, null, options, request);
      }
      /// <summary>
      /// Retrieves autoscaling policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.AutoscalingPolicy GetAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.GetAutoscalingPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAutoscalingPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves autoscaling policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.AutoscalingPolicy GetAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.GetAutoscalingPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAutoscalingPolicy, null, options, request);
      }
      /// <summary>
      /// Retrieves autoscaling policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> GetAutoscalingPolicyAsync(global::Google.Cloud.Dataproc.V1.GetAutoscalingPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAutoscalingPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves autoscaling policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.AutoscalingPolicy> GetAutoscalingPolicyAsync(global::Google.Cloud.Dataproc.V1.GetAutoscalingPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAutoscalingPolicy, null, options, request);
      }
      /// <summary>
      /// Lists autoscaling policies in the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesResponse ListAutoscalingPolicies(global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAutoscalingPolicies(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists autoscaling policies in the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesResponse ListAutoscalingPolicies(global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListAutoscalingPolicies, null, options, request);
      }
      /// <summary>
      /// Lists autoscaling policies in the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesResponse> ListAutoscalingPoliciesAsync(global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAutoscalingPoliciesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists autoscaling policies in the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesResponse> ListAutoscalingPoliciesAsync(global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListAutoscalingPolicies, null, options, request);
      }
      /// <summary>
      /// Deletes an autoscaling policy. It is an error to delete an autoscaling
      /// policy that is in use by one or more clusters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.DeleteAutoscalingPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAutoscalingPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes an autoscaling policy. It is an error to delete an autoscaling
      /// policy that is in use by one or more clusters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteAutoscalingPolicy(global::Google.Cloud.Dataproc.V1.DeleteAutoscalingPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteAutoscalingPolicy, null, options, request);
      }
      /// <summary>
      /// Deletes an autoscaling policy. It is an error to delete an autoscaling
      /// policy that is in use by one or more clusters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAutoscalingPolicyAsync(global::Google.Cloud.Dataproc.V1.DeleteAutoscalingPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAutoscalingPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes an autoscaling policy. It is an error to delete an autoscaling
      /// policy that is in use by one or more clusters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAutoscalingPolicyAsync(global::Google.Cloud.Dataproc.V1.DeleteAutoscalingPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteAutoscalingPolicy, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override AutoscalingPolicyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AutoscalingPolicyServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(AutoscalingPolicyServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateAutoscalingPolicy, serviceImpl.CreateAutoscalingPolicy)
          .AddMethod(__Method_UpdateAutoscalingPolicy, serviceImpl.UpdateAutoscalingPolicy)
          .AddMethod(__Method_GetAutoscalingPolicy, serviceImpl.GetAutoscalingPolicy)
          .AddMethod(__Method_ListAutoscalingPolicies, serviceImpl.ListAutoscalingPolicies)
          .AddMethod(__Method_DeleteAutoscalingPolicy, serviceImpl.DeleteAutoscalingPolicy).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AutoscalingPolicyServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateAutoscalingPolicy, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataproc.V1.CreateAutoscalingPolicyRequest, global::Google.Cloud.Dataproc.V1.AutoscalingPolicy>(serviceImpl.CreateAutoscalingPolicy));
      serviceBinder.AddMethod(__Method_UpdateAutoscalingPolicy, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataproc.V1.UpdateAutoscalingPolicyRequest, global::Google.Cloud.Dataproc.V1.AutoscalingPolicy>(serviceImpl.UpdateAutoscalingPolicy));
      serviceBinder.AddMethod(__Method_GetAutoscalingPolicy, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataproc.V1.GetAutoscalingPolicyRequest, global::Google.Cloud.Dataproc.V1.AutoscalingPolicy>(serviceImpl.GetAutoscalingPolicy));
      serviceBinder.AddMethod(__Method_ListAutoscalingPolicies, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesRequest, global::Google.Cloud.Dataproc.V1.ListAutoscalingPoliciesResponse>(serviceImpl.ListAutoscalingPolicies));
      serviceBinder.AddMethod(__Method_DeleteAutoscalingPolicy, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataproc.V1.DeleteAutoscalingPolicyRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteAutoscalingPolicy));
    }

  }
}
#endregion
