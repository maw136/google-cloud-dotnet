// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/servicecontrol/v1/service_controller.proto
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

namespace Google.Cloud.ServiceControl.V1 {
  /// <summary>
  /// [Google Service Control API](/service-control/overview)
  ///
  /// Lets clients check and report operations against a [managed
  /// service](https://cloud.google.com/service-management/reference/rpc/google.api/servicemanagement.v1#google.api.servicemanagement.v1.ManagedService).
  /// </summary>
  public static partial class ServiceController
  {
    static readonly string __ServiceName = "google.api.servicecontrol.v1.ServiceController";

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
    static readonly grpc::Marshaller<global::Google.Cloud.ServiceControl.V1.CheckRequest> __Marshaller_google_api_servicecontrol_v1_CheckRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ServiceControl.V1.CheckRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ServiceControl.V1.CheckResponse> __Marshaller_google_api_servicecontrol_v1_CheckResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ServiceControl.V1.CheckResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ServiceControl.V1.ReportRequest> __Marshaller_google_api_servicecontrol_v1_ReportRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ServiceControl.V1.ReportRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.ServiceControl.V1.ReportResponse> __Marshaller_google_api_servicecontrol_v1_ReportResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ServiceControl.V1.ReportResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.ServiceControl.V1.CheckRequest, global::Google.Cloud.ServiceControl.V1.CheckResponse> __Method_Check = new grpc::Method<global::Google.Cloud.ServiceControl.V1.CheckRequest, global::Google.Cloud.ServiceControl.V1.CheckResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Check",
        __Marshaller_google_api_servicecontrol_v1_CheckRequest,
        __Marshaller_google_api_servicecontrol_v1_CheckResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.ServiceControl.V1.ReportRequest, global::Google.Cloud.ServiceControl.V1.ReportResponse> __Method_Report = new grpc::Method<global::Google.Cloud.ServiceControl.V1.ReportRequest, global::Google.Cloud.ServiceControl.V1.ReportResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Report",
        __Marshaller_google_api_servicecontrol_v1_ReportRequest,
        __Marshaller_google_api_servicecontrol_v1_ReportResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.ServiceControl.V1.ServiceControllerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ServiceController</summary>
    [grpc::BindServiceMethod(typeof(ServiceController), "BindService")]
    public abstract partial class ServiceControllerBase
    {
      /// <summary>
      /// Checks whether an operation on a service should be allowed to proceed
      /// based on the configuration of the service and related policies. It must be
      /// called before the operation is executed.
      ///
      /// If feasible, the client should cache the check results and reuse them for
      /// 60 seconds. In case of any server errors, the client should rely on the
      /// cached results for much longer time to avoid outage.
      /// WARNING: There is general 60s delay for the configuration and policy
      /// propagation, therefore callers MUST NOT depend on the `Check` method having
      /// the latest policy information.
      ///
      /// NOTE: the [CheckRequest][google.api.servicecontrol.v1.CheckRequest] has
      /// the size limit (wire-format byte size) of 1MB.
      ///
      /// This method requires the `servicemanagement.services.check` permission
      /// on the specified service. For more information, see
      /// [Cloud IAM](https://cloud.google.com/iam).
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ServiceControl.V1.CheckResponse> Check(global::Google.Cloud.ServiceControl.V1.CheckRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Reports operation results to Google Service Control, such as logs and
      /// metrics. It should be called after an operation is completed.
      ///
      /// If feasible, the client should aggregate reporting data for up to 5
      /// seconds to reduce API traffic. Limiting aggregation to 5 seconds is to
      /// reduce data loss during client crashes. Clients should carefully choose
      /// the aggregation time window to avoid data loss risk more than 0.01%
      /// for business and compliance reasons.
      ///
      /// NOTE: the [ReportRequest][google.api.servicecontrol.v1.ReportRequest] has
      /// the size limit (wire-format byte size) of 1MB.
      ///
      /// This method requires the `servicemanagement.services.report` permission
      /// on the specified service. For more information, see
      /// [Google Cloud IAM](https://cloud.google.com/iam).
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ServiceControl.V1.ReportResponse> Report(global::Google.Cloud.ServiceControl.V1.ReportRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ServiceController</summary>
    public partial class ServiceControllerClient : grpc::ClientBase<ServiceControllerClient>
    {
      /// <summary>Creates a new client for ServiceController</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ServiceControllerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ServiceController that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ServiceControllerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ServiceControllerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ServiceControllerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Checks whether an operation on a service should be allowed to proceed
      /// based on the configuration of the service and related policies. It must be
      /// called before the operation is executed.
      ///
      /// If feasible, the client should cache the check results and reuse them for
      /// 60 seconds. In case of any server errors, the client should rely on the
      /// cached results for much longer time to avoid outage.
      /// WARNING: There is general 60s delay for the configuration and policy
      /// propagation, therefore callers MUST NOT depend on the `Check` method having
      /// the latest policy information.
      ///
      /// NOTE: the [CheckRequest][google.api.servicecontrol.v1.CheckRequest] has
      /// the size limit (wire-format byte size) of 1MB.
      ///
      /// This method requires the `servicemanagement.services.check` permission
      /// on the specified service. For more information, see
      /// [Cloud IAM](https://cloud.google.com/iam).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ServiceControl.V1.CheckResponse Check(global::Google.Cloud.ServiceControl.V1.CheckRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Check(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Checks whether an operation on a service should be allowed to proceed
      /// based on the configuration of the service and related policies. It must be
      /// called before the operation is executed.
      ///
      /// If feasible, the client should cache the check results and reuse them for
      /// 60 seconds. In case of any server errors, the client should rely on the
      /// cached results for much longer time to avoid outage.
      /// WARNING: There is general 60s delay for the configuration and policy
      /// propagation, therefore callers MUST NOT depend on the `Check` method having
      /// the latest policy information.
      ///
      /// NOTE: the [CheckRequest][google.api.servicecontrol.v1.CheckRequest] has
      /// the size limit (wire-format byte size) of 1MB.
      ///
      /// This method requires the `servicemanagement.services.check` permission
      /// on the specified service. For more information, see
      /// [Cloud IAM](https://cloud.google.com/iam).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ServiceControl.V1.CheckResponse Check(global::Google.Cloud.ServiceControl.V1.CheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Check, null, options, request);
      }
      /// <summary>
      /// Checks whether an operation on a service should be allowed to proceed
      /// based on the configuration of the service and related policies. It must be
      /// called before the operation is executed.
      ///
      /// If feasible, the client should cache the check results and reuse them for
      /// 60 seconds. In case of any server errors, the client should rely on the
      /// cached results for much longer time to avoid outage.
      /// WARNING: There is general 60s delay for the configuration and policy
      /// propagation, therefore callers MUST NOT depend on the `Check` method having
      /// the latest policy information.
      ///
      /// NOTE: the [CheckRequest][google.api.servicecontrol.v1.CheckRequest] has
      /// the size limit (wire-format byte size) of 1MB.
      ///
      /// This method requires the `servicemanagement.services.check` permission
      /// on the specified service. For more information, see
      /// [Cloud IAM](https://cloud.google.com/iam).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ServiceControl.V1.CheckResponse> CheckAsync(global::Google.Cloud.ServiceControl.V1.CheckRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Checks whether an operation on a service should be allowed to proceed
      /// based on the configuration of the service and related policies. It must be
      /// called before the operation is executed.
      ///
      /// If feasible, the client should cache the check results and reuse them for
      /// 60 seconds. In case of any server errors, the client should rely on the
      /// cached results for much longer time to avoid outage.
      /// WARNING: There is general 60s delay for the configuration and policy
      /// propagation, therefore callers MUST NOT depend on the `Check` method having
      /// the latest policy information.
      ///
      /// NOTE: the [CheckRequest][google.api.servicecontrol.v1.CheckRequest] has
      /// the size limit (wire-format byte size) of 1MB.
      ///
      /// This method requires the `servicemanagement.services.check` permission
      /// on the specified service. For more information, see
      /// [Cloud IAM](https://cloud.google.com/iam).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ServiceControl.V1.CheckResponse> CheckAsync(global::Google.Cloud.ServiceControl.V1.CheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Check, null, options, request);
      }
      /// <summary>
      /// Reports operation results to Google Service Control, such as logs and
      /// metrics. It should be called after an operation is completed.
      ///
      /// If feasible, the client should aggregate reporting data for up to 5
      /// seconds to reduce API traffic. Limiting aggregation to 5 seconds is to
      /// reduce data loss during client crashes. Clients should carefully choose
      /// the aggregation time window to avoid data loss risk more than 0.01%
      /// for business and compliance reasons.
      ///
      /// NOTE: the [ReportRequest][google.api.servicecontrol.v1.ReportRequest] has
      /// the size limit (wire-format byte size) of 1MB.
      ///
      /// This method requires the `servicemanagement.services.report` permission
      /// on the specified service. For more information, see
      /// [Google Cloud IAM](https://cloud.google.com/iam).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ServiceControl.V1.ReportResponse Report(global::Google.Cloud.ServiceControl.V1.ReportRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Report(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reports operation results to Google Service Control, such as logs and
      /// metrics. It should be called after an operation is completed.
      ///
      /// If feasible, the client should aggregate reporting data for up to 5
      /// seconds to reduce API traffic. Limiting aggregation to 5 seconds is to
      /// reduce data loss during client crashes. Clients should carefully choose
      /// the aggregation time window to avoid data loss risk more than 0.01%
      /// for business and compliance reasons.
      ///
      /// NOTE: the [ReportRequest][google.api.servicecontrol.v1.ReportRequest] has
      /// the size limit (wire-format byte size) of 1MB.
      ///
      /// This method requires the `servicemanagement.services.report` permission
      /// on the specified service. For more information, see
      /// [Google Cloud IAM](https://cloud.google.com/iam).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.ServiceControl.V1.ReportResponse Report(global::Google.Cloud.ServiceControl.V1.ReportRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Report, null, options, request);
      }
      /// <summary>
      /// Reports operation results to Google Service Control, such as logs and
      /// metrics. It should be called after an operation is completed.
      ///
      /// If feasible, the client should aggregate reporting data for up to 5
      /// seconds to reduce API traffic. Limiting aggregation to 5 seconds is to
      /// reduce data loss during client crashes. Clients should carefully choose
      /// the aggregation time window to avoid data loss risk more than 0.01%
      /// for business and compliance reasons.
      ///
      /// NOTE: the [ReportRequest][google.api.servicecontrol.v1.ReportRequest] has
      /// the size limit (wire-format byte size) of 1MB.
      ///
      /// This method requires the `servicemanagement.services.report` permission
      /// on the specified service. For more information, see
      /// [Google Cloud IAM](https://cloud.google.com/iam).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ServiceControl.V1.ReportResponse> ReportAsync(global::Google.Cloud.ServiceControl.V1.ReportRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReportAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reports operation results to Google Service Control, such as logs and
      /// metrics. It should be called after an operation is completed.
      ///
      /// If feasible, the client should aggregate reporting data for up to 5
      /// seconds to reduce API traffic. Limiting aggregation to 5 seconds is to
      /// reduce data loss during client crashes. Clients should carefully choose
      /// the aggregation time window to avoid data loss risk more than 0.01%
      /// for business and compliance reasons.
      ///
      /// NOTE: the [ReportRequest][google.api.servicecontrol.v1.ReportRequest] has
      /// the size limit (wire-format byte size) of 1MB.
      ///
      /// This method requires the `servicemanagement.services.report` permission
      /// on the specified service. For more information, see
      /// [Google Cloud IAM](https://cloud.google.com/iam).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ServiceControl.V1.ReportResponse> ReportAsync(global::Google.Cloud.ServiceControl.V1.ReportRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Report, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ServiceControllerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ServiceControllerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ServiceControllerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Check, serviceImpl.Check)
          .AddMethod(__Method_Report, serviceImpl.Report).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ServiceControllerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Check, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ServiceControl.V1.CheckRequest, global::Google.Cloud.ServiceControl.V1.CheckResponse>(serviceImpl.Check));
      serviceBinder.AddMethod(__Method_Report, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ServiceControl.V1.ReportRequest, global::Google.Cloud.ServiceControl.V1.ReportResponse>(serviceImpl.Report));
    }

  }
}
#endregion
