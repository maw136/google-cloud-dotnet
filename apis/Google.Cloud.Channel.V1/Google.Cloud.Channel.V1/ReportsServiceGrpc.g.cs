// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/channel/v1/reports_service.proto
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
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Channel.V1 {
  /// <summary>
  /// CloudChannelReportsService lets Google Cloud resellers and
  /// distributors retrieve and combine a variety of data in Cloud Channel for
  /// multiple products (Google Cloud, Google Voice, and Google Workspace.)
  ///
  /// Deprecated: This service is being deprecated. Please use [Export Channel
  /// Services data to
  /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
  /// instead.
  /// </summary>
  [global::System.ObsoleteAttribute]
  public static partial class CloudChannelReportsService
  {
    static readonly string __ServiceName = "google.cloud.channel.v1.CloudChannelReportsService";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Channel.V1.RunReportJobRequest> __Marshaller_google_cloud_channel_v1_RunReportJobRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Channel.V1.RunReportJobRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Channel.V1.FetchReportResultsRequest> __Marshaller_google_cloud_channel_v1_FetchReportResultsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Channel.V1.FetchReportResultsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Channel.V1.FetchReportResultsResponse> __Marshaller_google_cloud_channel_v1_FetchReportResultsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Channel.V1.FetchReportResultsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Channel.V1.ListReportsRequest> __Marshaller_google_cloud_channel_v1_ListReportsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Channel.V1.ListReportsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Channel.V1.ListReportsResponse> __Marshaller_google_cloud_channel_v1_ListReportsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Channel.V1.ListReportsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Channel.V1.RunReportJobRequest, global::Google.LongRunning.Operation> __Method_RunReportJob = new grpc::Method<global::Google.Cloud.Channel.V1.RunReportJobRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RunReportJob",
        __Marshaller_google_cloud_channel_v1_RunReportJobRequest,
        __Marshaller_google_longrunning_Operation);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Channel.V1.FetchReportResultsRequest, global::Google.Cloud.Channel.V1.FetchReportResultsResponse> __Method_FetchReportResults = new grpc::Method<global::Google.Cloud.Channel.V1.FetchReportResultsRequest, global::Google.Cloud.Channel.V1.FetchReportResultsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FetchReportResults",
        __Marshaller_google_cloud_channel_v1_FetchReportResultsRequest,
        __Marshaller_google_cloud_channel_v1_FetchReportResultsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Channel.V1.ListReportsRequest, global::Google.Cloud.Channel.V1.ListReportsResponse> __Method_ListReports = new grpc::Method<global::Google.Cloud.Channel.V1.ListReportsRequest, global::Google.Cloud.Channel.V1.ListReportsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListReports",
        __Marshaller_google_cloud_channel_v1_ListReportsRequest,
        __Marshaller_google_cloud_channel_v1_ListReportsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Channel.V1.ReportsServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CloudChannelReportsService</summary>
    [global::System.ObsoleteAttribute]
    [grpc::BindServiceMethod(typeof(CloudChannelReportsService), "BindService")]
    public abstract partial class CloudChannelReportsServiceBase
    {
      /// <summary>
      /// Begins generation of data for a given report. The report
      /// identifier is a UID (for example, `613bf59q`).
      ///
      /// Possible error codes:
      ///
      /// * PERMISSION_DENIED: The user doesn't have access to this report.
      /// * INVALID_ARGUMENT: Required request parameters are missing
      ///   or invalid.
      /// * NOT_FOUND: The report identifier was not found.
      /// * INTERNAL: Any non-user error related to a technical issue
      ///   in the backend. Contact Cloud Channel support.
      /// * UNKNOWN: Any non-user error related to a technical issue
      ///   in the backend. Contact Cloud Channel support.
      ///
      /// Return value:
      /// The ID of a long-running operation.
      ///
      /// To get the results of the operation, call the GetOperation method of
      /// CloudChannelOperationsService. The Operation metadata contains an
      /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
      ///
      /// To get the results of report generation, call
      /// [CloudChannelReportsService.FetchReportResults][google.cloud.channel.v1.CloudChannelReportsService.FetchReportResults]
      /// with the
      /// [RunReportJobResponse.report_job][google.cloud.channel.v1.RunReportJobResponse.report_job].
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> RunReportJob(global::Google.Cloud.Channel.V1.RunReportJobRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves data generated by
      /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Channel.V1.FetchReportResultsResponse> FetchReportResults(global::Google.Cloud.Channel.V1.FetchReportResultsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists the reports that RunReportJob can run. These reports include an ID,
      /// a description, and the list of columns that will be in the result.
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Channel.V1.ListReportsResponse> ListReports(global::Google.Cloud.Channel.V1.ListReportsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CloudChannelReportsService</summary>
    [global::System.ObsoleteAttribute]
    public partial class CloudChannelReportsServiceClient : grpc::ClientBase<CloudChannelReportsServiceClient>
    {
      /// <summary>Creates a new client for CloudChannelReportsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CloudChannelReportsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CloudChannelReportsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CloudChannelReportsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CloudChannelReportsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CloudChannelReportsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Begins generation of data for a given report. The report
      /// identifier is a UID (for example, `613bf59q`).
      ///
      /// Possible error codes:
      ///
      /// * PERMISSION_DENIED: The user doesn't have access to this report.
      /// * INVALID_ARGUMENT: Required request parameters are missing
      ///   or invalid.
      /// * NOT_FOUND: The report identifier was not found.
      /// * INTERNAL: Any non-user error related to a technical issue
      ///   in the backend. Contact Cloud Channel support.
      /// * UNKNOWN: Any non-user error related to a technical issue
      ///   in the backend. Contact Cloud Channel support.
      ///
      /// Return value:
      /// The ID of a long-running operation.
      ///
      /// To get the results of the operation, call the GetOperation method of
      /// CloudChannelOperationsService. The Operation metadata contains an
      /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
      ///
      /// To get the results of report generation, call
      /// [CloudChannelReportsService.FetchReportResults][google.cloud.channel.v1.CloudChannelReportsService.FetchReportResults]
      /// with the
      /// [RunReportJobResponse.report_job][google.cloud.channel.v1.RunReportJobResponse.report_job].
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation RunReportJob(global::Google.Cloud.Channel.V1.RunReportJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunReportJob(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Begins generation of data for a given report. The report
      /// identifier is a UID (for example, `613bf59q`).
      ///
      /// Possible error codes:
      ///
      /// * PERMISSION_DENIED: The user doesn't have access to this report.
      /// * INVALID_ARGUMENT: Required request parameters are missing
      ///   or invalid.
      /// * NOT_FOUND: The report identifier was not found.
      /// * INTERNAL: Any non-user error related to a technical issue
      ///   in the backend. Contact Cloud Channel support.
      /// * UNKNOWN: Any non-user error related to a technical issue
      ///   in the backend. Contact Cloud Channel support.
      ///
      /// Return value:
      /// The ID of a long-running operation.
      ///
      /// To get the results of the operation, call the GetOperation method of
      /// CloudChannelOperationsService. The Operation metadata contains an
      /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
      ///
      /// To get the results of report generation, call
      /// [CloudChannelReportsService.FetchReportResults][google.cloud.channel.v1.CloudChannelReportsService.FetchReportResults]
      /// with the
      /// [RunReportJobResponse.report_job][google.cloud.channel.v1.RunReportJobResponse.report_job].
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation RunReportJob(global::Google.Cloud.Channel.V1.RunReportJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RunReportJob, null, options, request);
      }
      /// <summary>
      /// Begins generation of data for a given report. The report
      /// identifier is a UID (for example, `613bf59q`).
      ///
      /// Possible error codes:
      ///
      /// * PERMISSION_DENIED: The user doesn't have access to this report.
      /// * INVALID_ARGUMENT: Required request parameters are missing
      ///   or invalid.
      /// * NOT_FOUND: The report identifier was not found.
      /// * INTERNAL: Any non-user error related to a technical issue
      ///   in the backend. Contact Cloud Channel support.
      /// * UNKNOWN: Any non-user error related to a technical issue
      ///   in the backend. Contact Cloud Channel support.
      ///
      /// Return value:
      /// The ID of a long-running operation.
      ///
      /// To get the results of the operation, call the GetOperation method of
      /// CloudChannelOperationsService. The Operation metadata contains an
      /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
      ///
      /// To get the results of report generation, call
      /// [CloudChannelReportsService.FetchReportResults][google.cloud.channel.v1.CloudChannelReportsService.FetchReportResults]
      /// with the
      /// [RunReportJobResponse.report_job][google.cloud.channel.v1.RunReportJobResponse.report_job].
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RunReportJobAsync(global::Google.Cloud.Channel.V1.RunReportJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunReportJobAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Begins generation of data for a given report. The report
      /// identifier is a UID (for example, `613bf59q`).
      ///
      /// Possible error codes:
      ///
      /// * PERMISSION_DENIED: The user doesn't have access to this report.
      /// * INVALID_ARGUMENT: Required request parameters are missing
      ///   or invalid.
      /// * NOT_FOUND: The report identifier was not found.
      /// * INTERNAL: Any non-user error related to a technical issue
      ///   in the backend. Contact Cloud Channel support.
      /// * UNKNOWN: Any non-user error related to a technical issue
      ///   in the backend. Contact Cloud Channel support.
      ///
      /// Return value:
      /// The ID of a long-running operation.
      ///
      /// To get the results of the operation, call the GetOperation method of
      /// CloudChannelOperationsService. The Operation metadata contains an
      /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
      ///
      /// To get the results of report generation, call
      /// [CloudChannelReportsService.FetchReportResults][google.cloud.channel.v1.CloudChannelReportsService.FetchReportResults]
      /// with the
      /// [RunReportJobResponse.report_job][google.cloud.channel.v1.RunReportJobResponse.report_job].
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RunReportJobAsync(global::Google.Cloud.Channel.V1.RunReportJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RunReportJob, null, options, request);
      }
      /// <summary>
      /// Retrieves data generated by
      /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Channel.V1.FetchReportResultsResponse FetchReportResults(global::Google.Cloud.Channel.V1.FetchReportResultsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchReportResults(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves data generated by
      /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Channel.V1.FetchReportResultsResponse FetchReportResults(global::Google.Cloud.Channel.V1.FetchReportResultsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FetchReportResults, null, options, request);
      }
      /// <summary>
      /// Retrieves data generated by
      /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Channel.V1.FetchReportResultsResponse> FetchReportResultsAsync(global::Google.Cloud.Channel.V1.FetchReportResultsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchReportResultsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves data generated by
      /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Channel.V1.FetchReportResultsResponse> FetchReportResultsAsync(global::Google.Cloud.Channel.V1.FetchReportResultsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FetchReportResults, null, options, request);
      }
      /// <summary>
      /// Lists the reports that RunReportJob can run. These reports include an ID,
      /// a description, and the list of columns that will be in the result.
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Channel.V1.ListReportsResponse ListReports(global::Google.Cloud.Channel.V1.ListReportsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListReports(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the reports that RunReportJob can run. These reports include an ID,
      /// a description, and the list of columns that will be in the result.
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Channel.V1.ListReportsResponse ListReports(global::Google.Cloud.Channel.V1.ListReportsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListReports, null, options, request);
      }
      /// <summary>
      /// Lists the reports that RunReportJob can run. These reports include an ID,
      /// a description, and the list of columns that will be in the result.
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Channel.V1.ListReportsResponse> ListReportsAsync(global::Google.Cloud.Channel.V1.ListReportsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListReportsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the reports that RunReportJob can run. These reports include an ID,
      /// a description, and the list of columns that will be in the result.
      ///
      /// Deprecated: Please use [Export Channel Services data to
      /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
      /// instead.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.ObsoleteAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Channel.V1.ListReportsResponse> ListReportsAsync(global::Google.Cloud.Channel.V1.ListReportsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListReports, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CloudChannelReportsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CloudChannelReportsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CloudChannelReportsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RunReportJob, serviceImpl.RunReportJob)
          .AddMethod(__Method_FetchReportResults, serviceImpl.FetchReportResults)
          .AddMethod(__Method_ListReports, serviceImpl.ListReports).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CloudChannelReportsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RunReportJob, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Channel.V1.RunReportJobRequest, global::Google.LongRunning.Operation>(serviceImpl.RunReportJob));
      serviceBinder.AddMethod(__Method_FetchReportResults, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Channel.V1.FetchReportResultsRequest, global::Google.Cloud.Channel.V1.FetchReportResultsResponse>(serviceImpl.FetchReportResults));
      serviceBinder.AddMethod(__Method_ListReports, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Channel.V1.ListReportsRequest, global::Google.Cloud.Channel.V1.ListReportsResponse>(serviceImpl.ListReports));
    }

  }
}
#endregion
