// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/devtools/cloudbuild/v2/cloudbuild.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.CloudBuild.V2 {

  /// <summary>Holder for reflection information generated from google/devtools/cloudbuild/v2/cloudbuild.proto</summary>
  public static partial class CloudbuildReflection {

    #region Descriptor
    /// <summary>File descriptor for google/devtools/cloudbuild/v2/cloudbuild.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CloudbuildReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvZGV2dG9vbHMvY2xvdWRidWlsZC92Mi9jbG91ZGJ1aWxkLnBy",
            "b3RvEh1nb29nbGUuZGV2dG9vbHMuY2xvdWRidWlsZC52MhocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8a",
            "H2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkv",
            "cmVzb3VyY2UucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJv",
            "dG8igAIKEU9wZXJhdGlvbk1ldGFkYXRhEjQKC2NyZWF0ZV90aW1lGAEgASgL",
            "MhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEID4EEDEjEKCGVuZF90aW1l",
            "GAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEID4EEDEhMKBnRh",
            "cmdldBgDIAEoCUID4EEDEhEKBHZlcmIYBCABKAlCA+BBAxIbCg5zdGF0dXNf",
            "bWVzc2FnZRgFIAEoCUID4EEDEiMKFnJlcXVlc3RlZF9jYW5jZWxsYXRpb24Y",
            "BiABKAhCA+BBAxIYCgthcGlfdmVyc2lvbhgHIAEoCUID4EEDIpICCiJSdW5X",
            "b3JrZmxvd0N1c3RvbU9wZXJhdGlvbk1ldGFkYXRhEjQKC2NyZWF0ZV90aW1l",
            "GAEgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEID4EEDEjEKCGVu",
            "ZF90aW1lGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEID4EED",
            "EhEKBHZlcmIYAyABKAlCA+BBAxIjChZyZXF1ZXN0ZWRfY2FuY2VsbGF0aW9u",
            "GAQgASgIQgPgQQMSGAoLYXBpX3ZlcnNpb24YBSABKAlCA+BBAxITCgZ0YXJn",
            "ZXQYBiABKAlCA+BBAxIcCg9waXBlbGluZV9ydW5faWQYByABKAlCA+BBA0Kx",
            "BQodZ29vZ2xlLmRldnRvb2xzLmNsb3VkYnVpbGQudjJCD0Nsb3VkQnVpbGRQ",
            "cm90b1ABWkdnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2RldnRvb2xzL2Nsb3VkYnVpbGQvdjI7Y2xvdWRidWlsZKICA0dDQqoCGkdv",
            "b2dsZS5DbG91ZC5DbG91ZEJ1aWxkLlYyygIVR29vZ2xlXENsb3VkXEJ1aWxk",
            "XFYy6gIYR29vZ2xlOjpDbG91ZDo6QnVpbGQ6OlYy6kFOCh5jb21wdXRlLmdv",
            "b2dsZWFwaXMuY29tL05ldHdvcmsSLHByb2plY3RzL3twcm9qZWN0fS9nbG9i",
            "YWwvbmV0d29ya3Mve25ldHdvcmt96kFZCiFpYW0uZ29vZ2xlYXBpcy5jb20v",
            "U2VydmljZUFjY291bnQSNHByb2plY3RzL3twcm9qZWN0fS9zZXJ2aWNlQWNj",
            "b3VudHMve3NlcnZpY2VfYWNjb3VudH3qQUoKI3NlY3JldG1hbmFnZXIuZ29v",
            "Z2xlYXBpcy5jb20vU2VjcmV0EiNwcm9qZWN0cy97cHJvamVjdH0vc2VjcmV0",
            "cy97c2VjcmV0fepBZAoqc2VjcmV0bWFuYWdlci5nb29nbGVhcGlzLmNvbS9T",
            "ZWNyZXRWZXJzaW9uEjZwcm9qZWN0cy97cHJvamVjdH0vc2VjcmV0cy97c2Vj",
            "cmV0fS92ZXJzaW9ucy97dmVyc2lvbn3qQXwKMGNsb3VkYnVpbGQuZ29vZ2xl",
            "YXBpcy5jb20vZ2l0aHViRW50ZXJwcmlzZUNvbmZpZxJIcHJvamVjdHMve3By",
            "b2plY3R9L2xvY2F0aW9ucy97bG9jYXRpb259L2dpdGh1YkVudGVycHJpc2VD",
            "b25maWdzL3tjb25maWd9YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.CloudBuild.V2.OperationMetadata), global::Google.Cloud.CloudBuild.V2.OperationMetadata.Parser, new[]{ "CreateTime", "EndTime", "Target", "Verb", "StatusMessage", "RequestedCancellation", "ApiVersion" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.CloudBuild.V2.RunWorkflowCustomOperationMetadata), global::Google.Cloud.CloudBuild.V2.RunWorkflowCustomOperationMetadata.Parser, new[]{ "CreateTime", "EndTime", "Verb", "RequestedCancellation", "ApiVersion", "Target", "PipelineRunId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents the metadata of the long-running operation.
  /// </summary>
  public sealed partial class OperationMetadata : pb::IMessage<OperationMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OperationMetadata> _parser = new pb::MessageParser<OperationMetadata>(() => new OperationMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OperationMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.CloudBuild.V2.CloudbuildReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata(OperationMetadata other) : this() {
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      endTime_ = other.endTime_ != null ? other.endTime_.Clone() : null;
      target_ = other.target_;
      verb_ = other.verb_;
      statusMessage_ = other.statusMessage_;
      requestedCancellation_ = other.requestedCancellation_;
      apiVersion_ = other.apiVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata Clone() {
      return new OperationMetadata(this);
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The time the operation was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    /// Output only. The time the operation finished running.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 3;
    private string target_ = "";
    /// <summary>
    /// Output only. Server-defined resource path for the target of the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Target {
      get { return target_; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "verb" field.</summary>
    public const int VerbFieldNumber = 4;
    private string verb_ = "";
    /// <summary>
    /// Output only. Name of the verb executed by the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Verb {
      get { return verb_; }
      set {
        verb_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status_message" field.</summary>
    public const int StatusMessageFieldNumber = 5;
    private string statusMessage_ = "";
    /// <summary>
    /// Output only. Human-readable status of the operation, if any.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StatusMessage {
      get { return statusMessage_; }
      set {
        statusMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "requested_cancellation" field.</summary>
    public const int RequestedCancellationFieldNumber = 6;
    private bool requestedCancellation_;
    /// <summary>
    /// Output only. Identifies whether the user has requested cancellation
    /// of the operation. Operations that have successfully been cancelled
    /// have [Operation.error][] value with a
    /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
    /// `Code.CANCELLED`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool RequestedCancellation {
      get { return requestedCancellation_; }
      set {
        requestedCancellation_ = value;
      }
    }

    /// <summary>Field number for the "api_version" field.</summary>
    public const int ApiVersionFieldNumber = 7;
    private string apiVersion_ = "";
    /// <summary>
    /// Output only. API version used to start the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ApiVersion {
      get { return apiVersion_; }
      set {
        apiVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OperationMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OperationMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      if (Target != other.Target) return false;
      if (Verb != other.Verb) return false;
      if (StatusMessage != other.StatusMessage) return false;
      if (RequestedCancellation != other.RequestedCancellation) return false;
      if (ApiVersion != other.ApiVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
      if (Target.Length != 0) hash ^= Target.GetHashCode();
      if (Verb.Length != 0) hash ^= Verb.GetHashCode();
      if (StatusMessage.Length != 0) hash ^= StatusMessage.GetHashCode();
      if (RequestedCancellation != false) hash ^= RequestedCancellation.GetHashCode();
      if (ApiVersion.Length != 0) hash ^= ApiVersion.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (createTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreateTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EndTime);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Target);
      }
      if (Verb.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Verb);
      }
      if (StatusMessage.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StatusMessage);
      }
      if (RequestedCancellation != false) {
        output.WriteRawTag(48);
        output.WriteBool(RequestedCancellation);
      }
      if (ApiVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ApiVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (createTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreateTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EndTime);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Target);
      }
      if (Verb.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Verb);
      }
      if (StatusMessage.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StatusMessage);
      }
      if (RequestedCancellation != false) {
        output.WriteRawTag(48);
        output.WriteBool(RequestedCancellation);
      }
      if (ApiVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ApiVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
      }
      if (Target.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Target);
      }
      if (Verb.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Verb);
      }
      if (StatusMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatusMessage);
      }
      if (RequestedCancellation != false) {
        size += 1 + 1;
      }
      if (ApiVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OperationMetadata other) {
      if (other == null) {
        return;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.endTime_ != null) {
        if (endTime_ == null) {
          EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndTime.MergeFrom(other.EndTime);
      }
      if (other.Target.Length != 0) {
        Target = other.Target;
      }
      if (other.Verb.Length != 0) {
        Verb = other.Verb;
      }
      if (other.StatusMessage.Length != 0) {
        StatusMessage = other.StatusMessage;
      }
      if (other.RequestedCancellation != false) {
        RequestedCancellation = other.RequestedCancellation;
      }
      if (other.ApiVersion.Length != 0) {
        ApiVersion = other.ApiVersion;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 18: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 26: {
            Target = input.ReadString();
            break;
          }
          case 34: {
            Verb = input.ReadString();
            break;
          }
          case 42: {
            StatusMessage = input.ReadString();
            break;
          }
          case 48: {
            RequestedCancellation = input.ReadBool();
            break;
          }
          case 58: {
            ApiVersion = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 18: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 26: {
            Target = input.ReadString();
            break;
          }
          case 34: {
            Verb = input.ReadString();
            break;
          }
          case 42: {
            StatusMessage = input.ReadString();
            break;
          }
          case 48: {
            RequestedCancellation = input.ReadBool();
            break;
          }
          case 58: {
            ApiVersion = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Represents the custom metadata of the RunWorkflow long-running operation.
  /// </summary>
  public sealed partial class RunWorkflowCustomOperationMetadata : pb::IMessage<RunWorkflowCustomOperationMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RunWorkflowCustomOperationMetadata> _parser = new pb::MessageParser<RunWorkflowCustomOperationMetadata>(() => new RunWorkflowCustomOperationMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RunWorkflowCustomOperationMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.CloudBuild.V2.CloudbuildReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RunWorkflowCustomOperationMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RunWorkflowCustomOperationMetadata(RunWorkflowCustomOperationMetadata other) : this() {
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      endTime_ = other.endTime_ != null ? other.endTime_.Clone() : null;
      verb_ = other.verb_;
      requestedCancellation_ = other.requestedCancellation_;
      apiVersion_ = other.apiVersion_;
      target_ = other.target_;
      pipelineRunId_ = other.pipelineRunId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RunWorkflowCustomOperationMetadata Clone() {
      return new RunWorkflowCustomOperationMetadata(this);
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The time the operation was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    /// Output only. The time the operation finished running.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "verb" field.</summary>
    public const int VerbFieldNumber = 3;
    private string verb_ = "";
    /// <summary>
    /// Output only. Name of the verb executed by the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Verb {
      get { return verb_; }
      set {
        verb_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "requested_cancellation" field.</summary>
    public const int RequestedCancellationFieldNumber = 4;
    private bool requestedCancellation_;
    /// <summary>
    /// Output only. Identifies whether the user has requested cancellation
    /// of the operation. Operations that have successfully been cancelled
    /// have [Operation.error][] value with a
    /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
    /// `Code.CANCELLED`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool RequestedCancellation {
      get { return requestedCancellation_; }
      set {
        requestedCancellation_ = value;
      }
    }

    /// <summary>Field number for the "api_version" field.</summary>
    public const int ApiVersionFieldNumber = 5;
    private string apiVersion_ = "";
    /// <summary>
    /// Output only. API version used to start the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ApiVersion {
      get { return apiVersion_; }
      set {
        apiVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 6;
    private string target_ = "";
    /// <summary>
    /// Output only. Server-defined resource path for the target of the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Target {
      get { return target_; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pipeline_run_id" field.</summary>
    public const int PipelineRunIdFieldNumber = 7;
    private string pipelineRunId_ = "";
    /// <summary>
    /// Output only. ID of the pipeline run created by RunWorkflow.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PipelineRunId {
      get { return pipelineRunId_; }
      set {
        pipelineRunId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RunWorkflowCustomOperationMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RunWorkflowCustomOperationMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      if (Verb != other.Verb) return false;
      if (RequestedCancellation != other.RequestedCancellation) return false;
      if (ApiVersion != other.ApiVersion) return false;
      if (Target != other.Target) return false;
      if (PipelineRunId != other.PipelineRunId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
      if (Verb.Length != 0) hash ^= Verb.GetHashCode();
      if (RequestedCancellation != false) hash ^= RequestedCancellation.GetHashCode();
      if (ApiVersion.Length != 0) hash ^= ApiVersion.GetHashCode();
      if (Target.Length != 0) hash ^= Target.GetHashCode();
      if (PipelineRunId.Length != 0) hash ^= PipelineRunId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (createTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreateTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EndTime);
      }
      if (Verb.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Verb);
      }
      if (RequestedCancellation != false) {
        output.WriteRawTag(32);
        output.WriteBool(RequestedCancellation);
      }
      if (ApiVersion.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ApiVersion);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Target);
      }
      if (PipelineRunId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(PipelineRunId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (createTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreateTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EndTime);
      }
      if (Verb.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Verb);
      }
      if (RequestedCancellation != false) {
        output.WriteRawTag(32);
        output.WriteBool(RequestedCancellation);
      }
      if (ApiVersion.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ApiVersion);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Target);
      }
      if (PipelineRunId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(PipelineRunId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
      }
      if (Verb.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Verb);
      }
      if (RequestedCancellation != false) {
        size += 1 + 1;
      }
      if (ApiVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiVersion);
      }
      if (Target.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Target);
      }
      if (PipelineRunId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PipelineRunId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RunWorkflowCustomOperationMetadata other) {
      if (other == null) {
        return;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.endTime_ != null) {
        if (endTime_ == null) {
          EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndTime.MergeFrom(other.EndTime);
      }
      if (other.Verb.Length != 0) {
        Verb = other.Verb;
      }
      if (other.RequestedCancellation != false) {
        RequestedCancellation = other.RequestedCancellation;
      }
      if (other.ApiVersion.Length != 0) {
        ApiVersion = other.ApiVersion;
      }
      if (other.Target.Length != 0) {
        Target = other.Target;
      }
      if (other.PipelineRunId.Length != 0) {
        PipelineRunId = other.PipelineRunId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 18: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 26: {
            Verb = input.ReadString();
            break;
          }
          case 32: {
            RequestedCancellation = input.ReadBool();
            break;
          }
          case 42: {
            ApiVersion = input.ReadString();
            break;
          }
          case 50: {
            Target = input.ReadString();
            break;
          }
          case 58: {
            PipelineRunId = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 18: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 26: {
            Verb = input.ReadString();
            break;
          }
          case 32: {
            RequestedCancellation = input.ReadBool();
            break;
          }
          case 42: {
            ApiVersion = input.ReadString();
            break;
          }
          case 50: {
            Target = input.ReadString();
            break;
          }
          case 58: {
            PipelineRunId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
