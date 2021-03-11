// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: leave.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace leaveDemo {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class leave
  {
    static readonly string __ServiceName = "leaveDemo.leave";

    static readonly grpc::Marshaller<global::leaveDemo.GetUserInfoRequest> __Marshaller_leaveDemo_GetUserInfoRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::leaveDemo.GetUserInfoRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::leaveDemo.GetUserInfoListResponse> __Marshaller_leaveDemo_GetUserInfoListResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::leaveDemo.GetUserInfoListResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::leaveDemo.GetUserInfoResponse> __Marshaller_leaveDemo_GetUserInfoResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::leaveDemo.GetUserInfoResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::leaveDemo.ApplyRequest> __Marshaller_leaveDemo_ApplyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::leaveDemo.ApplyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::leaveDemo.ResponseMessage> __Marshaller_leaveDemo_ResponseMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::leaveDemo.ResponseMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::leaveDemo.ApproveRequest> __Marshaller_leaveDemo_ApproveRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::leaveDemo.ApproveRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::leaveDemo.GetUserInfoRequest, global::leaveDemo.GetUserInfoListResponse> __Method_GetUserInfoList = new grpc::Method<global::leaveDemo.GetUserInfoRequest, global::leaveDemo.GetUserInfoListResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserInfoList",
        __Marshaller_leaveDemo_GetUserInfoRequest,
        __Marshaller_leaveDemo_GetUserInfoListResponse);

    static readonly grpc::Method<global::leaveDemo.GetUserInfoRequest, global::leaveDemo.GetUserInfoResponse> __Method_GetUserInfo = new grpc::Method<global::leaveDemo.GetUserInfoRequest, global::leaveDemo.GetUserInfoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserInfo",
        __Marshaller_leaveDemo_GetUserInfoRequest,
        __Marshaller_leaveDemo_GetUserInfoResponse);

    static readonly grpc::Method<global::leaveDemo.ApplyRequest, global::leaveDemo.ResponseMessage> __Method_Apply = new grpc::Method<global::leaveDemo.ApplyRequest, global::leaveDemo.ResponseMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Apply",
        __Marshaller_leaveDemo_ApplyRequest,
        __Marshaller_leaveDemo_ResponseMessage);

    static readonly grpc::Method<global::leaveDemo.ApproveRequest, global::leaveDemo.ResponseMessage> __Method_Approve = new grpc::Method<global::leaveDemo.ApproveRequest, global::leaveDemo.ResponseMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Approve",
        __Marshaller_leaveDemo_ApproveRequest,
        __Marshaller_leaveDemo_ResponseMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::leaveDemo.LeaveReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of leave</summary>
    [grpc::BindServiceMethod(typeof(leave), "BindService")]
    public abstract partial class leaveBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::leaveDemo.GetUserInfoListResponse> GetUserInfoList(global::leaveDemo.GetUserInfoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::leaveDemo.GetUserInfoResponse> GetUserInfo(global::leaveDemo.GetUserInfoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::leaveDemo.ResponseMessage> Apply(global::leaveDemo.ApplyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::leaveDemo.ResponseMessage> Approve(global::leaveDemo.ApproveRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for leave</summary>
    public partial class leaveClient : grpc::ClientBase<leaveClient>
    {
      /// <summary>Creates a new client for leave</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public leaveClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for leave that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public leaveClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected leaveClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected leaveClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::leaveDemo.GetUserInfoListResponse GetUserInfoList(global::leaveDemo.GetUserInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserInfoList(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::leaveDemo.GetUserInfoListResponse GetUserInfoList(global::leaveDemo.GetUserInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUserInfoList, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::leaveDemo.GetUserInfoListResponse> GetUserInfoListAsync(global::leaveDemo.GetUserInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserInfoListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::leaveDemo.GetUserInfoListResponse> GetUserInfoListAsync(global::leaveDemo.GetUserInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUserInfoList, null, options, request);
      }
      public virtual global::leaveDemo.GetUserInfoResponse GetUserInfo(global::leaveDemo.GetUserInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::leaveDemo.GetUserInfoResponse GetUserInfo(global::leaveDemo.GetUserInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUserInfo, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::leaveDemo.GetUserInfoResponse> GetUserInfoAsync(global::leaveDemo.GetUserInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::leaveDemo.GetUserInfoResponse> GetUserInfoAsync(global::leaveDemo.GetUserInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUserInfo, null, options, request);
      }
      public virtual global::leaveDemo.ResponseMessage Apply(global::leaveDemo.ApplyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Apply(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::leaveDemo.ResponseMessage Apply(global::leaveDemo.ApplyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Apply, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::leaveDemo.ResponseMessage> ApplyAsync(global::leaveDemo.ApplyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ApplyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::leaveDemo.ResponseMessage> ApplyAsync(global::leaveDemo.ApplyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Apply, null, options, request);
      }
      public virtual global::leaveDemo.ResponseMessage Approve(global::leaveDemo.ApproveRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Approve(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::leaveDemo.ResponseMessage Approve(global::leaveDemo.ApproveRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Approve, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::leaveDemo.ResponseMessage> ApproveAsync(global::leaveDemo.ApproveRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ApproveAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::leaveDemo.ResponseMessage> ApproveAsync(global::leaveDemo.ApproveRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Approve, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override leaveClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new leaveClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(leaveBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetUserInfoList, serviceImpl.GetUserInfoList)
          .AddMethod(__Method_GetUserInfo, serviceImpl.GetUserInfo)
          .AddMethod(__Method_Apply, serviceImpl.Apply)
          .AddMethod(__Method_Approve, serviceImpl.Approve).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, leaveBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetUserInfoList, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::leaveDemo.GetUserInfoRequest, global::leaveDemo.GetUserInfoListResponse>(serviceImpl.GetUserInfoList));
      serviceBinder.AddMethod(__Method_GetUserInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::leaveDemo.GetUserInfoRequest, global::leaveDemo.GetUserInfoResponse>(serviceImpl.GetUserInfo));
      serviceBinder.AddMethod(__Method_Apply, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::leaveDemo.ApplyRequest, global::leaveDemo.ResponseMessage>(serviceImpl.Apply));
      serviceBinder.AddMethod(__Method_Approve, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::leaveDemo.ApproveRequest, global::leaveDemo.ResponseMessage>(serviceImpl.Approve));
    }

  }
}
#endregion
