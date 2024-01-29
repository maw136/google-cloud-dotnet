// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/workflows/v1beta/workflows.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
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

namespace Google.Cloud.Workflows.V1Beta {
  /// <summary>
  /// Workflows is used to deploy and execute workflow programs.
  /// Workflows makes sure the program executes reliably, despite hardware and
  /// networking interruptions.
  /// </summary>
  public static partial class Workflows
  {
    static readonly string __ServiceName = "google.cloud.workflows.v1beta.Workflows";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.V1Beta.ListWorkflowsRequest> __Marshaller_google_cloud_workflows_v1beta_ListWorkflowsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.V1Beta.ListWorkflowsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.V1Beta.ListWorkflowsResponse> __Marshaller_google_cloud_workflows_v1beta_ListWorkflowsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.V1Beta.ListWorkflowsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.V1Beta.GetWorkflowRequest> __Marshaller_google_cloud_workflows_v1beta_GetWorkflowRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.V1Beta.GetWorkflowRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.V1Beta.Workflow> __Marshaller_google_cloud_workflows_v1beta_Workflow = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.V1Beta.Workflow.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.V1Beta.CreateWorkflowRequest> __Marshaller_google_cloud_workflows_v1beta_CreateWorkflowRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.V1Beta.CreateWorkflowRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.V1Beta.DeleteWorkflowRequest> __Marshaller_google_cloud_workflows_v1beta_DeleteWorkflowRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.V1Beta.DeleteWorkflowRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Workflows.V1Beta.UpdateWorkflowRequest> __Marshaller_google_cloud_workflows_v1beta_UpdateWorkflowRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Workflows.V1Beta.UpdateWorkflowRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Workflows.V1Beta.ListWorkflowsRequest, global::Google.Cloud.Workflows.V1Beta.ListWorkflowsResponse> __Method_ListWorkflows = new grpc::Method<global::Google.Cloud.Workflows.V1Beta.ListWorkflowsRequest, global::Google.Cloud.Workflows.V1Beta.ListWorkflowsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListWorkflows",
        __Marshaller_google_cloud_workflows_v1beta_ListWorkflowsRequest,
        __Marshaller_google_cloud_workflows_v1beta_ListWorkflowsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Workflows.V1Beta.GetWorkflowRequest, global::Google.Cloud.Workflows.V1Beta.Workflow> __Method_GetWorkflow = new grpc::Method<global::Google.Cloud.Workflows.V1Beta.GetWorkflowRequest, global::Google.Cloud.Workflows.V1Beta.Workflow>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetWorkflow",
        __Marshaller_google_cloud_workflows_v1beta_GetWorkflowRequest,
        __Marshaller_google_cloud_workflows_v1beta_Workflow);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Workflows.V1Beta.CreateWorkflowRequest, global::Google.LongRunning.Operation> __Method_CreateWorkflow = new grpc::Method<global::Google.Cloud.Workflows.V1Beta.CreateWorkflowRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateWorkflow",
        __Marshaller_google_cloud_workflows_v1beta_CreateWorkflowRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Workflows.V1Beta.DeleteWorkflowRequest, global::Google.LongRunning.Operation> __Method_DeleteWorkflow = new grpc::Method<global::Google.Cloud.Workflows.V1Beta.DeleteWorkflowRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteWorkflow",
        __Marshaller_google_cloud_workflows_v1beta_DeleteWorkflowRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Workflows.V1Beta.UpdateWorkflowRequest, global::Google.LongRunning.Operation> __Method_UpdateWorkflow = new grpc::Method<global::Google.Cloud.Workflows.V1Beta.UpdateWorkflowRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateWorkflow",
        __Marshaller_google_cloud_workflows_v1beta_UpdateWorkflowRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Workflows.V1Beta.WorkflowsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Workflows</summary>
    [grpc::BindServiceMethod(typeof(Workflows), "BindService")]
    public abstract partial class WorkflowsBase
    {
      /// <summary>
      /// Lists Workflows in a given project and location.
      /// The default order is not specified.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Workflows.V1Beta.ListWorkflowsResponse> ListWorkflows(global::Google.Cloud.Workflows.V1Beta.ListWorkflowsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets details of a single Workflow.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Workflows.V1Beta.Workflow> GetWorkflow(global::Google.Cloud.Workflows.V1Beta.GetWorkflowRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a new workflow. If a workflow with the specified name already
      /// exists in the specified project and location, the long running operation
      /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateWorkflow(global::Google.Cloud.Workflows.V1Beta.CreateWorkflowRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a workflow with the specified name.
      /// This method also cancels and deletes all running executions of the
      /// workflow.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> DeleteWorkflow(global::Google.Cloud.Workflows.V1Beta.DeleteWorkflowRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates an existing workflow.
      /// Running this method has no impact on already running executions of the
      /// workflow. A new revision of the workflow may be created as a result of a
      /// successful update operation. In that case, such revision will be used
      /// in new workflow executions.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> UpdateWorkflow(global::Google.Cloud.Workflows.V1Beta.UpdateWorkflowRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Workflows</summary>
    public partial class WorkflowsClient : grpc::ClientBase<WorkflowsClient>
    {
      /// <summary>Creates a new client for Workflows</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public WorkflowsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Workflows that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public WorkflowsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected WorkflowsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected WorkflowsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists Workflows in a given project and location.
      /// The default order is not specified.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Workflows.V1Beta.ListWorkflowsResponse ListWorkflows(global::Google.Cloud.Workflows.V1Beta.ListWorkflowsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListWorkflows(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists Workflows in a given project and location.
      /// The default order is not specified.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Workflows.V1Beta.ListWorkflowsResponse ListWorkflows(global::Google.Cloud.Workflows.V1Beta.ListWorkflowsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListWorkflows, null, options, request);
      }
      /// <summary>
      /// Lists Workflows in a given project and location.
      /// The default order is not specified.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.V1Beta.ListWorkflowsResponse> ListWorkflowsAsync(global::Google.Cloud.Workflows.V1Beta.ListWorkflowsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListWorkflowsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists Workflows in a given project and location.
      /// The default order is not specified.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.V1Beta.ListWorkflowsResponse> ListWorkflowsAsync(global::Google.Cloud.Workflows.V1Beta.ListWorkflowsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListWorkflows, null, options, request);
      }
      /// <summary>
      /// Gets details of a single Workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Workflows.V1Beta.Workflow GetWorkflow(global::Google.Cloud.Workflows.V1Beta.GetWorkflowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWorkflow(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets details of a single Workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Workflows.V1Beta.Workflow GetWorkflow(global::Google.Cloud.Workflows.V1Beta.GetWorkflowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetWorkflow, null, options, request);
      }
      /// <summary>
      /// Gets details of a single Workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.V1Beta.Workflow> GetWorkflowAsync(global::Google.Cloud.Workflows.V1Beta.GetWorkflowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWorkflowAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets details of a single Workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Workflows.V1Beta.Workflow> GetWorkflowAsync(global::Google.Cloud.Workflows.V1Beta.GetWorkflowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetWorkflow, null, options, request);
      }
      /// <summary>
      /// Creates a new workflow. If a workflow with the specified name already
      /// exists in the specified project and location, the long running operation
      /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateWorkflow(global::Google.Cloud.Workflows.V1Beta.CreateWorkflowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateWorkflow(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new workflow. If a workflow with the specified name already
      /// exists in the specified project and location, the long running operation
      /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation CreateWorkflow(global::Google.Cloud.Workflows.V1Beta.CreateWorkflowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateWorkflow, null, options, request);
      }
      /// <summary>
      /// Creates a new workflow. If a workflow with the specified name already
      /// exists in the specified project and location, the long running operation
      /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateWorkflowAsync(global::Google.Cloud.Workflows.V1Beta.CreateWorkflowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateWorkflowAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new workflow. If a workflow with the specified name already
      /// exists in the specified project and location, the long running operation
      /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateWorkflowAsync(global::Google.Cloud.Workflows.V1Beta.CreateWorkflowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateWorkflow, null, options, request);
      }
      /// <summary>
      /// Deletes a workflow with the specified name.
      /// This method also cancels and deletes all running executions of the
      /// workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation DeleteWorkflow(global::Google.Cloud.Workflows.V1Beta.DeleteWorkflowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteWorkflow(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a workflow with the specified name.
      /// This method also cancels and deletes all running executions of the
      /// workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation DeleteWorkflow(global::Google.Cloud.Workflows.V1Beta.DeleteWorkflowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteWorkflow, null, options, request);
      }
      /// <summary>
      /// Deletes a workflow with the specified name.
      /// This method also cancels and deletes all running executions of the
      /// workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteWorkflowAsync(global::Google.Cloud.Workflows.V1Beta.DeleteWorkflowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteWorkflowAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a workflow with the specified name.
      /// This method also cancels and deletes all running executions of the
      /// workflow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteWorkflowAsync(global::Google.Cloud.Workflows.V1Beta.DeleteWorkflowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteWorkflow, null, options, request);
      }
      /// <summary>
      /// Updates an existing workflow.
      /// Running this method has no impact on already running executions of the
      /// workflow. A new revision of the workflow may be created as a result of a
      /// successful update operation. In that case, such revision will be used
      /// in new workflow executions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation UpdateWorkflow(global::Google.Cloud.Workflows.V1Beta.UpdateWorkflowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateWorkflow(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an existing workflow.
      /// Running this method has no impact on already running executions of the
      /// workflow. A new revision of the workflow may be created as a result of a
      /// successful update operation. In that case, such revision will be used
      /// in new workflow executions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation UpdateWorkflow(global::Google.Cloud.Workflows.V1Beta.UpdateWorkflowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateWorkflow, null, options, request);
      }
      /// <summary>
      /// Updates an existing workflow.
      /// Running this method has no impact on already running executions of the
      /// workflow. A new revision of the workflow may be created as a result of a
      /// successful update operation. In that case, such revision will be used
      /// in new workflow executions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateWorkflowAsync(global::Google.Cloud.Workflows.V1Beta.UpdateWorkflowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateWorkflowAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an existing workflow.
      /// Running this method has no impact on already running executions of the
      /// workflow. A new revision of the workflow may be created as a result of a
      /// successful update operation. In that case, such revision will be used
      /// in new workflow executions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateWorkflowAsync(global::Google.Cloud.Workflows.V1Beta.UpdateWorkflowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateWorkflow, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override WorkflowsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WorkflowsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(WorkflowsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListWorkflows, serviceImpl.ListWorkflows)
          .AddMethod(__Method_GetWorkflow, serviceImpl.GetWorkflow)
          .AddMethod(__Method_CreateWorkflow, serviceImpl.CreateWorkflow)
          .AddMethod(__Method_DeleteWorkflow, serviceImpl.DeleteWorkflow)
          .AddMethod(__Method_UpdateWorkflow, serviceImpl.UpdateWorkflow).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WorkflowsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListWorkflows, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Workflows.V1Beta.ListWorkflowsRequest, global::Google.Cloud.Workflows.V1Beta.ListWorkflowsResponse>(serviceImpl.ListWorkflows));
      serviceBinder.AddMethod(__Method_GetWorkflow, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Workflows.V1Beta.GetWorkflowRequest, global::Google.Cloud.Workflows.V1Beta.Workflow>(serviceImpl.GetWorkflow));
      serviceBinder.AddMethod(__Method_CreateWorkflow, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Workflows.V1Beta.CreateWorkflowRequest, global::Google.LongRunning.Operation>(serviceImpl.CreateWorkflow));
      serviceBinder.AddMethod(__Method_DeleteWorkflow, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Workflows.V1Beta.DeleteWorkflowRequest, global::Google.LongRunning.Operation>(serviceImpl.DeleteWorkflow));
      serviceBinder.AddMethod(__Method_UpdateWorkflow, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Workflows.V1Beta.UpdateWorkflowRequest, global::Google.LongRunning.Operation>(serviceImpl.UpdateWorkflow));
    }

  }
}
#endregion
