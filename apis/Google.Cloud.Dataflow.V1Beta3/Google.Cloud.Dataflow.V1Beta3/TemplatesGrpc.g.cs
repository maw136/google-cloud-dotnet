// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/dataflow/v1beta3/templates.proto
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

namespace Google.Cloud.Dataflow.V1Beta3 {
  /// <summary>
  /// Provides a method to create Cloud Dataflow jobs from templates.
  /// </summary>
  public static partial class TemplatesService
  {
    static readonly string __ServiceName = "google.dataflow.v1beta3.TemplatesService";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Dataflow.V1Beta3.CreateJobFromTemplateRequest> __Marshaller_google_dataflow_v1beta3_CreateJobFromTemplateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataflow.V1Beta3.CreateJobFromTemplateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataflow.V1Beta3.Job> __Marshaller_google_dataflow_v1beta3_Job = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataflow.V1Beta3.Job.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateRequest> __Marshaller_google_dataflow_v1beta3_LaunchTemplateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateResponse> __Marshaller_google_dataflow_v1beta3_LaunchTemplateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataflow.V1Beta3.GetTemplateRequest> __Marshaller_google_dataflow_v1beta3_GetTemplateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataflow.V1Beta3.GetTemplateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataflow.V1Beta3.GetTemplateResponse> __Marshaller_google_dataflow_v1beta3_GetTemplateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataflow.V1Beta3.GetTemplateResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataflow.V1Beta3.CreateJobFromTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.Job> __Method_CreateJobFromTemplate = new grpc::Method<global::Google.Cloud.Dataflow.V1Beta3.CreateJobFromTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.Job>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateJobFromTemplate",
        __Marshaller_google_dataflow_v1beta3_CreateJobFromTemplateRequest,
        __Marshaller_google_dataflow_v1beta3_Job);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateResponse> __Method_LaunchTemplate = new grpc::Method<global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LaunchTemplate",
        __Marshaller_google_dataflow_v1beta3_LaunchTemplateRequest,
        __Marshaller_google_dataflow_v1beta3_LaunchTemplateResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataflow.V1Beta3.GetTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.GetTemplateResponse> __Method_GetTemplate = new grpc::Method<global::Google.Cloud.Dataflow.V1Beta3.GetTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.GetTemplateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTemplate",
        __Marshaller_google_dataflow_v1beta3_GetTemplateRequest,
        __Marshaller_google_dataflow_v1beta3_GetTemplateResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dataflow.V1Beta3.TemplatesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TemplatesService</summary>
    [grpc::BindServiceMethod(typeof(TemplatesService), "BindService")]
    public abstract partial class TemplatesServiceBase
    {
      /// <summary>
      /// Creates a Cloud Dataflow job from a template.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataflow.V1Beta3.Job> CreateJobFromTemplate(global::Google.Cloud.Dataflow.V1Beta3.CreateJobFromTemplateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Launch a template.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateResponse> LaunchTemplate(global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get the template associated with a template.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataflow.V1Beta3.GetTemplateResponse> GetTemplate(global::Google.Cloud.Dataflow.V1Beta3.GetTemplateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TemplatesService</summary>
    public partial class TemplatesServiceClient : grpc::ClientBase<TemplatesServiceClient>
    {
      /// <summary>Creates a new client for TemplatesService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public TemplatesServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TemplatesService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public TemplatesServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected TemplatesServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected TemplatesServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates a Cloud Dataflow job from a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataflow.V1Beta3.Job CreateJobFromTemplate(global::Google.Cloud.Dataflow.V1Beta3.CreateJobFromTemplateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateJobFromTemplate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a Cloud Dataflow job from a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataflow.V1Beta3.Job CreateJobFromTemplate(global::Google.Cloud.Dataflow.V1Beta3.CreateJobFromTemplateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateJobFromTemplate, null, options, request);
      }
      /// <summary>
      /// Creates a Cloud Dataflow job from a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataflow.V1Beta3.Job> CreateJobFromTemplateAsync(global::Google.Cloud.Dataflow.V1Beta3.CreateJobFromTemplateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateJobFromTemplateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a Cloud Dataflow job from a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataflow.V1Beta3.Job> CreateJobFromTemplateAsync(global::Google.Cloud.Dataflow.V1Beta3.CreateJobFromTemplateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateJobFromTemplate, null, options, request);
      }
      /// <summary>
      /// Launch a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateResponse LaunchTemplate(global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LaunchTemplate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Launch a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateResponse LaunchTemplate(global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LaunchTemplate, null, options, request);
      }
      /// <summary>
      /// Launch a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateResponse> LaunchTemplateAsync(global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LaunchTemplateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Launch a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateResponse> LaunchTemplateAsync(global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LaunchTemplate, null, options, request);
      }
      /// <summary>
      /// Get the template associated with a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataflow.V1Beta3.GetTemplateResponse GetTemplate(global::Google.Cloud.Dataflow.V1Beta3.GetTemplateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTemplate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get the template associated with a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataflow.V1Beta3.GetTemplateResponse GetTemplate(global::Google.Cloud.Dataflow.V1Beta3.GetTemplateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTemplate, null, options, request);
      }
      /// <summary>
      /// Get the template associated with a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataflow.V1Beta3.GetTemplateResponse> GetTemplateAsync(global::Google.Cloud.Dataflow.V1Beta3.GetTemplateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTemplateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get the template associated with a template.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataflow.V1Beta3.GetTemplateResponse> GetTemplateAsync(global::Google.Cloud.Dataflow.V1Beta3.GetTemplateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTemplate, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override TemplatesServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TemplatesServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(TemplatesServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateJobFromTemplate, serviceImpl.CreateJobFromTemplate)
          .AddMethod(__Method_LaunchTemplate, serviceImpl.LaunchTemplate)
          .AddMethod(__Method_GetTemplate, serviceImpl.GetTemplate).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TemplatesServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateJobFromTemplate, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataflow.V1Beta3.CreateJobFromTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.Job>(serviceImpl.CreateJobFromTemplate));
      serviceBinder.AddMethod(__Method_LaunchTemplate, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.LaunchTemplateResponse>(serviceImpl.LaunchTemplate));
      serviceBinder.AddMethod(__Method_GetTemplate, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataflow.V1Beta3.GetTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.GetTemplateResponse>(serviceImpl.GetTemplate));
    }

  }
  /// <summary>
  /// Provides a service for Flex templates. This feature is not ready yet.
  /// </summary>
  public static partial class FlexTemplatesService
  {
    static readonly string __ServiceName = "google.dataflow.v1beta3.FlexTemplatesService";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateRequest> __Marshaller_google_dataflow_v1beta3_LaunchFlexTemplateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateResponse> __Marshaller_google_dataflow_v1beta3_LaunchFlexTemplateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateResponse> __Method_LaunchFlexTemplate = new grpc::Method<global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LaunchFlexTemplate",
        __Marshaller_google_dataflow_v1beta3_LaunchFlexTemplateRequest,
        __Marshaller_google_dataflow_v1beta3_LaunchFlexTemplateResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dataflow.V1Beta3.TemplatesReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of FlexTemplatesService</summary>
    [grpc::BindServiceMethod(typeof(FlexTemplatesService), "BindService")]
    public abstract partial class FlexTemplatesServiceBase
    {
      /// <summary>
      /// Launch a job with a FlexTemplate.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateResponse> LaunchFlexTemplate(global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FlexTemplatesService</summary>
    public partial class FlexTemplatesServiceClient : grpc::ClientBase<FlexTemplatesServiceClient>
    {
      /// <summary>Creates a new client for FlexTemplatesService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FlexTemplatesServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FlexTemplatesService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FlexTemplatesServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FlexTemplatesServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FlexTemplatesServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Launch a job with a FlexTemplate.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateResponse LaunchFlexTemplate(global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LaunchFlexTemplate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Launch a job with a FlexTemplate.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateResponse LaunchFlexTemplate(global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LaunchFlexTemplate, null, options, request);
      }
      /// <summary>
      /// Launch a job with a FlexTemplate.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateResponse> LaunchFlexTemplateAsync(global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LaunchFlexTemplateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Launch a job with a FlexTemplate.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateResponse> LaunchFlexTemplateAsync(global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LaunchFlexTemplate, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override FlexTemplatesServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FlexTemplatesServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(FlexTemplatesServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_LaunchFlexTemplate, serviceImpl.LaunchFlexTemplate).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FlexTemplatesServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_LaunchFlexTemplate, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateRequest, global::Google.Cloud.Dataflow.V1Beta3.LaunchFlexTemplateResponse>(serviceImpl.LaunchFlexTemplate));
    }

  }
}
#endregion
