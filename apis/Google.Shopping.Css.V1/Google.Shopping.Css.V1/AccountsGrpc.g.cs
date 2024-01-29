// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/shopping/css/v1/accounts.proto
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

namespace Google.Shopping.Css.V1 {
  /// <summary>
  /// Service for managing CSS/MC account information.
  /// </summary>
  public static partial class AccountsService
  {
    static readonly string __ServiceName = "google.shopping.css.v1.AccountsService";

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
    static readonly grpc::Marshaller<global::Google.Shopping.Css.V1.ListChildAccountsRequest> __Marshaller_google_shopping_css_v1_ListChildAccountsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Css.V1.ListChildAccountsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Css.V1.ListChildAccountsResponse> __Marshaller_google_shopping_css_v1_ListChildAccountsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Css.V1.ListChildAccountsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Css.V1.GetAccountRequest> __Marshaller_google_shopping_css_v1_GetAccountRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Css.V1.GetAccountRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Css.V1.Account> __Marshaller_google_shopping_css_v1_Account = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Css.V1.Account.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Css.V1.UpdateAccountLabelsRequest> __Marshaller_google_shopping_css_v1_UpdateAccountLabelsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Css.V1.UpdateAccountLabelsRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Css.V1.ListChildAccountsRequest, global::Google.Shopping.Css.V1.ListChildAccountsResponse> __Method_ListChildAccounts = new grpc::Method<global::Google.Shopping.Css.V1.ListChildAccountsRequest, global::Google.Shopping.Css.V1.ListChildAccountsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListChildAccounts",
        __Marshaller_google_shopping_css_v1_ListChildAccountsRequest,
        __Marshaller_google_shopping_css_v1_ListChildAccountsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Css.V1.GetAccountRequest, global::Google.Shopping.Css.V1.Account> __Method_GetAccount = new grpc::Method<global::Google.Shopping.Css.V1.GetAccountRequest, global::Google.Shopping.Css.V1.Account>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAccount",
        __Marshaller_google_shopping_css_v1_GetAccountRequest,
        __Marshaller_google_shopping_css_v1_Account);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Css.V1.UpdateAccountLabelsRequest, global::Google.Shopping.Css.V1.Account> __Method_UpdateLabels = new grpc::Method<global::Google.Shopping.Css.V1.UpdateAccountLabelsRequest, global::Google.Shopping.Css.V1.Account>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateLabels",
        __Marshaller_google_shopping_css_v1_UpdateAccountLabelsRequest,
        __Marshaller_google_shopping_css_v1_Account);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Shopping.Css.V1.AccountsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AccountsService</summary>
    [grpc::BindServiceMethod(typeof(AccountsService), "BindService")]
    public abstract partial class AccountsServiceBase
    {
      /// <summary>
      /// Lists all the accounts under the specified CSS account ID, and
      /// optionally filters by label ID and account name.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Css.V1.ListChildAccountsResponse> ListChildAccounts(global::Google.Shopping.Css.V1.ListChildAccountsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves a single CSS/MC account by ID.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Css.V1.Account> GetAccount(global::Google.Shopping.Css.V1.GetAccountRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates labels assigned to CSS/MC accounts by a CSS domain.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Css.V1.Account> UpdateLabels(global::Google.Shopping.Css.V1.UpdateAccountLabelsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AccountsService</summary>
    public partial class AccountsServiceClient : grpc::ClientBase<AccountsServiceClient>
    {
      /// <summary>Creates a new client for AccountsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AccountsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AccountsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AccountsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AccountsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AccountsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists all the accounts under the specified CSS account ID, and
      /// optionally filters by label ID and account name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Css.V1.ListChildAccountsResponse ListChildAccounts(global::Google.Shopping.Css.V1.ListChildAccountsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListChildAccounts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all the accounts under the specified CSS account ID, and
      /// optionally filters by label ID and account name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Css.V1.ListChildAccountsResponse ListChildAccounts(global::Google.Shopping.Css.V1.ListChildAccountsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListChildAccounts, null, options, request);
      }
      /// <summary>
      /// Lists all the accounts under the specified CSS account ID, and
      /// optionally filters by label ID and account name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Css.V1.ListChildAccountsResponse> ListChildAccountsAsync(global::Google.Shopping.Css.V1.ListChildAccountsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListChildAccountsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all the accounts under the specified CSS account ID, and
      /// optionally filters by label ID and account name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Css.V1.ListChildAccountsResponse> ListChildAccountsAsync(global::Google.Shopping.Css.V1.ListChildAccountsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListChildAccounts, null, options, request);
      }
      /// <summary>
      /// Retrieves a single CSS/MC account by ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Css.V1.Account GetAccount(global::Google.Shopping.Css.V1.GetAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves a single CSS/MC account by ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Css.V1.Account GetAccount(global::Google.Shopping.Css.V1.GetAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAccount, null, options, request);
      }
      /// <summary>
      /// Retrieves a single CSS/MC account by ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Css.V1.Account> GetAccountAsync(global::Google.Shopping.Css.V1.GetAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves a single CSS/MC account by ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Css.V1.Account> GetAccountAsync(global::Google.Shopping.Css.V1.GetAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAccount, null, options, request);
      }
      /// <summary>
      /// Updates labels assigned to CSS/MC accounts by a CSS domain.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Css.V1.Account UpdateLabels(global::Google.Shopping.Css.V1.UpdateAccountLabelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateLabels(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates labels assigned to CSS/MC accounts by a CSS domain.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Css.V1.Account UpdateLabels(global::Google.Shopping.Css.V1.UpdateAccountLabelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateLabels, null, options, request);
      }
      /// <summary>
      /// Updates labels assigned to CSS/MC accounts by a CSS domain.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Css.V1.Account> UpdateLabelsAsync(global::Google.Shopping.Css.V1.UpdateAccountLabelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateLabelsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates labels assigned to CSS/MC accounts by a CSS domain.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Css.V1.Account> UpdateLabelsAsync(global::Google.Shopping.Css.V1.UpdateAccountLabelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateLabels, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override AccountsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AccountsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(AccountsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListChildAccounts, serviceImpl.ListChildAccounts)
          .AddMethod(__Method_GetAccount, serviceImpl.GetAccount)
          .AddMethod(__Method_UpdateLabels, serviceImpl.UpdateLabels).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AccountsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListChildAccounts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Css.V1.ListChildAccountsRequest, global::Google.Shopping.Css.V1.ListChildAccountsResponse>(serviceImpl.ListChildAccounts));
      serviceBinder.AddMethod(__Method_GetAccount, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Css.V1.GetAccountRequest, global::Google.Shopping.Css.V1.Account>(serviceImpl.GetAccount));
      serviceBinder.AddMethod(__Method_UpdateLabels, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Css.V1.UpdateAccountLabelsRequest, global::Google.Shopping.Css.V1.Account>(serviceImpl.UpdateLabels));
    }

  }
}
#endregion
