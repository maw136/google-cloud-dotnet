// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/devtools/containeranalysis/v1/containeranalysis.proto
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

namespace Google.Cloud.DevTools.ContainerAnalysis.V1 {
  /// <summary>
  /// Retrieves analysis results of Cloud components such as Docker container
  /// images. The Container Analysis API is an implementation of the
  /// [Grafeas](https://grafeas.io) API.
  ///
  /// Analysis results are stored as a series of occurrences. An `Occurrence`
  /// contains information about a specific analysis instance on a resource. An
  /// occurrence refers to a `Note`. A note contains details describing the
  /// analysis and is generally stored in a separate project, called a `Provider`.
  /// Multiple occurrences can refer to the same note.
  ///
  /// For example, an SSL vulnerability could affect multiple images. In this case,
  /// there would be one note for the vulnerability and an occurrence for each
  /// image with the vulnerability referring to that note.
  /// </summary>
  public static partial class ContainerAnalysis
  {
    static readonly string __ServiceName = "google.devtools.containeranalysis.v1.ContainerAnalysis";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.SetIamPolicyRequest> __Marshaller_google_iam_v1_SetIamPolicyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Iam.V1.SetIamPolicyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.Policy> __Marshaller_google_iam_v1_Policy = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Iam.V1.Policy.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.GetIamPolicyRequest> __Marshaller_google_iam_v1_GetIamPolicyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Iam.V1.GetIamPolicyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.TestIamPermissionsRequest> __Marshaller_google_iam_v1_TestIamPermissionsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Iam.V1.TestIamPermissionsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> __Marshaller_google_iam_v1_TestIamPermissionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Iam.V1.TestIamPermissionsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.DevTools.ContainerAnalysis.V1.GetVulnerabilityOccurrencesSummaryRequest> __Marshaller_google_devtools_containeranalysis_v1_GetVulnerabilityOccurrencesSummaryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.DevTools.ContainerAnalysis.V1.GetVulnerabilityOccurrencesSummaryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.DevTools.ContainerAnalysis.V1.VulnerabilityOccurrencesSummary> __Marshaller_google_devtools_containeranalysis_v1_VulnerabilityOccurrencesSummary = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.DevTools.ContainerAnalysis.V1.VulnerabilityOccurrencesSummary.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Iam.V1.SetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy> __Method_SetIamPolicy = new grpc::Method<global::Google.Cloud.Iam.V1.SetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetIamPolicy",
        __Marshaller_google_iam_v1_SetIamPolicyRequest,
        __Marshaller_google_iam_v1_Policy);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Iam.V1.GetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy> __Method_GetIamPolicy = new grpc::Method<global::Google.Cloud.Iam.V1.GetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetIamPolicy",
        __Marshaller_google_iam_v1_GetIamPolicyRequest,
        __Marshaller_google_iam_v1_Policy);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Iam.V1.TestIamPermissionsRequest, global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> __Method_TestIamPermissions = new grpc::Method<global::Google.Cloud.Iam.V1.TestIamPermissionsRequest, global::Google.Cloud.Iam.V1.TestIamPermissionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TestIamPermissions",
        __Marshaller_google_iam_v1_TestIamPermissionsRequest,
        __Marshaller_google_iam_v1_TestIamPermissionsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.DevTools.ContainerAnalysis.V1.GetVulnerabilityOccurrencesSummaryRequest, global::Google.Cloud.DevTools.ContainerAnalysis.V1.VulnerabilityOccurrencesSummary> __Method_GetVulnerabilityOccurrencesSummary = new grpc::Method<global::Google.Cloud.DevTools.ContainerAnalysis.V1.GetVulnerabilityOccurrencesSummaryRequest, global::Google.Cloud.DevTools.ContainerAnalysis.V1.VulnerabilityOccurrencesSummary>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetVulnerabilityOccurrencesSummary",
        __Marshaller_google_devtools_containeranalysis_v1_GetVulnerabilityOccurrencesSummaryRequest,
        __Marshaller_google_devtools_containeranalysis_v1_VulnerabilityOccurrencesSummary);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.DevTools.ContainerAnalysis.V1.ContaineranalysisReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ContainerAnalysis</summary>
    [grpc::BindServiceMethod(typeof(ContainerAnalysis), "BindService")]
    public abstract partial class ContainerAnalysisBase
    {
      /// <summary>
      /// Sets the access control policy on the specified note or occurrence.
      /// Requires `containeranalysis.notes.setIamPolicy` or
      /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
      /// a note or an occurrence, respectively.
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Iam.V1.Policy> SetIamPolicy(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets the access control policy for a note or an occurrence resource.
      /// Requires `containeranalysis.notes.setIamPolicy` or
      /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
      /// a note or occurrence, respectively.
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Iam.V1.Policy> GetIamPolicy(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the permissions that a caller has on the specified note or
      /// occurrence. Requires list permission on the project (for example,
      /// `containeranalysis.notes.list`).
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> TestIamPermissions(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets a summary of the number and severity of occurrences.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.DevTools.ContainerAnalysis.V1.VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummary(global::Google.Cloud.DevTools.ContainerAnalysis.V1.GetVulnerabilityOccurrencesSummaryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ContainerAnalysis</summary>
    public partial class ContainerAnalysisClient : grpc::ClientBase<ContainerAnalysisClient>
    {
      /// <summary>Creates a new client for ContainerAnalysis</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ContainerAnalysisClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ContainerAnalysis that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ContainerAnalysisClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ContainerAnalysisClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ContainerAnalysisClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sets the access control policy on the specified note or occurrence.
      /// Requires `containeranalysis.notes.setIamPolicy` or
      /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
      /// a note or an occurrence, respectively.
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Iam.V1.Policy SetIamPolicy(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetIamPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sets the access control policy on the specified note or occurrence.
      /// Requires `containeranalysis.notes.setIamPolicy` or
      /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
      /// a note or an occurrence, respectively.
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Iam.V1.Policy SetIamPolicy(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Sets the access control policy on the specified note or occurrence.
      /// Requires `containeranalysis.notes.setIamPolicy` or
      /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
      /// a note or an occurrence, respectively.
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.Policy> SetIamPolicyAsync(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetIamPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sets the access control policy on the specified note or occurrence.
      /// Requires `containeranalysis.notes.setIamPolicy` or
      /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
      /// a note or an occurrence, respectively.
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.Policy> SetIamPolicyAsync(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Gets the access control policy for a note or an occurrence resource.
      /// Requires `containeranalysis.notes.setIamPolicy` or
      /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
      /// a note or occurrence, respectively.
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Iam.V1.Policy GetIamPolicy(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetIamPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the access control policy for a note or an occurrence resource.
      /// Requires `containeranalysis.notes.setIamPolicy` or
      /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
      /// a note or occurrence, respectively.
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Iam.V1.Policy GetIamPolicy(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Gets the access control policy for a note or an occurrence resource.
      /// Requires `containeranalysis.notes.setIamPolicy` or
      /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
      /// a note or occurrence, respectively.
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.Policy> GetIamPolicyAsync(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetIamPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the access control policy for a note or an occurrence resource.
      /// Requires `containeranalysis.notes.setIamPolicy` or
      /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
      /// a note or occurrence, respectively.
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.Policy> GetIamPolicyAsync(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Returns the permissions that a caller has on the specified note or
      /// occurrence. Requires list permission on the project (for example,
      /// `containeranalysis.notes.list`).
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Iam.V1.TestIamPermissionsResponse TestIamPermissions(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TestIamPermissions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the permissions that a caller has on the specified note or
      /// occurrence. Requires list permission on the project (for example,
      /// `containeranalysis.notes.list`).
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Iam.V1.TestIamPermissionsResponse TestIamPermissions(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_TestIamPermissions, null, options, request);
      }
      /// <summary>
      /// Returns the permissions that a caller has on the specified note or
      /// occurrence. Requires list permission on the project (for example,
      /// `containeranalysis.notes.list`).
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> TestIamPermissionsAsync(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TestIamPermissionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the permissions that a caller has on the specified note or
      /// occurrence. Requires list permission on the project (for example,
      /// `containeranalysis.notes.list`).
      ///
      /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
      /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
      /// occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> TestIamPermissionsAsync(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_TestIamPermissions, null, options, request);
      }
      /// <summary>
      /// Gets a summary of the number and severity of occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.DevTools.ContainerAnalysis.V1.VulnerabilityOccurrencesSummary GetVulnerabilityOccurrencesSummary(global::Google.Cloud.DevTools.ContainerAnalysis.V1.GetVulnerabilityOccurrencesSummaryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetVulnerabilityOccurrencesSummary(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a summary of the number and severity of occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.DevTools.ContainerAnalysis.V1.VulnerabilityOccurrencesSummary GetVulnerabilityOccurrencesSummary(global::Google.Cloud.DevTools.ContainerAnalysis.V1.GetVulnerabilityOccurrencesSummaryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetVulnerabilityOccurrencesSummary, null, options, request);
      }
      /// <summary>
      /// Gets a summary of the number and severity of occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.DevTools.ContainerAnalysis.V1.VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(global::Google.Cloud.DevTools.ContainerAnalysis.V1.GetVulnerabilityOccurrencesSummaryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetVulnerabilityOccurrencesSummaryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a summary of the number and severity of occurrences.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.DevTools.ContainerAnalysis.V1.VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(global::Google.Cloud.DevTools.ContainerAnalysis.V1.GetVulnerabilityOccurrencesSummaryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetVulnerabilityOccurrencesSummary, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ContainerAnalysisClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ContainerAnalysisClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ContainerAnalysisBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SetIamPolicy, serviceImpl.SetIamPolicy)
          .AddMethod(__Method_GetIamPolicy, serviceImpl.GetIamPolicy)
          .AddMethod(__Method_TestIamPermissions, serviceImpl.TestIamPermissions)
          .AddMethod(__Method_GetVulnerabilityOccurrencesSummary, serviceImpl.GetVulnerabilityOccurrencesSummary).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ContainerAnalysisBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SetIamPolicy, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Iam.V1.SetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(serviceImpl.SetIamPolicy));
      serviceBinder.AddMethod(__Method_GetIamPolicy, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Iam.V1.GetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(serviceImpl.GetIamPolicy));
      serviceBinder.AddMethod(__Method_TestIamPermissions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Iam.V1.TestIamPermissionsRequest, global::Google.Cloud.Iam.V1.TestIamPermissionsResponse>(serviceImpl.TestIamPermissions));
      serviceBinder.AddMethod(__Method_GetVulnerabilityOccurrencesSummary, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.DevTools.ContainerAnalysis.V1.GetVulnerabilityOccurrencesSummaryRequest, global::Google.Cloud.DevTools.ContainerAnalysis.V1.VulnerabilityOccurrencesSummary>(serviceImpl.GetVulnerabilityOccurrencesSummary));
    }

  }
}
#endregion
