// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/deploy/v1/rollout_update_payload.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Deploy.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/deploy/v1/rollout_update_payload.proto</summary>
  public static partial class RolloutUpdatePayloadReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/deploy/v1/rollout_update_payload.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RolloutUpdatePayloadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvZGVwbG95L3YxL3JvbGxvdXRfdXBkYXRlX3BheWxv",
            "YWQucHJvdG8SFmdvb2dsZS5jbG91ZC5kZXBsb3kudjEaJmdvb2dsZS9jbG91",
            "ZC9kZXBsb3kvdjEvbG9nX2VudW1zLnByb3RvIpcEChJSb2xsb3V0VXBkYXRl",
            "RXZlbnQSDwoHbWVzc2FnZRgGIAEoCRIUCgxwaXBlbGluZV91aWQYASABKAkS",
            "EwoLcmVsZWFzZV91aWQYAiABKAkSDwoHcmVsZWFzZRgIIAEoCRIPCgdyb2xs",
            "b3V0GAMgASgJEhEKCXRhcmdldF9pZBgEIAEoCRIqCgR0eXBlGAcgASgOMhwu",
            "Z29vZ2xlLmNsb3VkLmRlcGxveS52MS5UeXBlElkKE3JvbGxvdXRfdXBkYXRl",
            "X3R5cGUYBSABKA4yPC5nb29nbGUuY2xvdWQuZGVwbG95LnYxLlJvbGxvdXRV",
            "cGRhdGVFdmVudC5Sb2xsb3V0VXBkYXRlVHlwZSKIAgoRUm9sbG91dFVwZGF0",
            "ZVR5cGUSIwofUk9MTE9VVF9VUERBVEVfVFlQRV9VTlNQRUNJRklFRBAAEgsK",
            "B1BFTkRJTkcQARITCg9QRU5ESU5HX1JFTEVBU0UQAhIPCgtJTl9QUk9HUkVT",
            "UxADEg4KCkNBTkNFTExJTkcQBBINCglDQU5DRUxMRUQQBRIKCgZIQUxURUQQ",
            "BhINCglTVUNDRUVERUQQBxIKCgZGQUlMRUQQCBIVChFBUFBST1ZBTF9SRVFV",
            "SVJFRBAJEgwKCEFQUFJPVkVEEAoSDAoIUkVKRUNURUQQCxIUChBBRFZBTkNF",
            "X1JFUVVJUkVEEAwSDAoIQURWQU5DRUQQDUJtChpjb20uZ29vZ2xlLmNsb3Vk",
            "LmRlcGxveS52MUIZUm9sbG91dFVwZGF0ZVBheWxvYWRQcm90b1ABWjJjbG91",
            "ZC5nb29nbGUuY29tL2dvL2RlcGxveS9hcGl2MS9kZXBsb3lwYjtkZXBsb3lw",
            "YmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.Deploy.V1.LogEnumsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Deploy.V1.RolloutUpdateEvent), global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Parser, new[]{ "Message", "PipelineUid", "ReleaseUid", "Release", "Rollout", "TargetId", "Type", "RolloutUpdateType" }, null, new[]{ typeof(global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Types.RolloutUpdateType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Payload proto for "clouddeploy.googleapis.com/rollout_update"
  /// Platform Log event that describes the rollout update event.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RolloutUpdateEvent : pb::IMessage<RolloutUpdateEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RolloutUpdateEvent> _parser = new pb::MessageParser<RolloutUpdateEvent>(() => new RolloutUpdateEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RolloutUpdateEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Deploy.V1.RolloutUpdatePayloadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RolloutUpdateEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RolloutUpdateEvent(RolloutUpdateEvent other) : this() {
      message_ = other.message_;
      pipelineUid_ = other.pipelineUid_;
      releaseUid_ = other.releaseUid_;
      release_ = other.release_;
      rollout_ = other.rollout_;
      targetId_ = other.targetId_;
      type_ = other.type_;
      rolloutUpdateType_ = other.rolloutUpdateType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RolloutUpdateEvent Clone() {
      return new RolloutUpdateEvent(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 6;
    private string message_ = "";
    /// <summary>
    /// Debug message for when a rollout update event occurs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pipeline_uid" field.</summary>
    public const int PipelineUidFieldNumber = 1;
    private string pipelineUid_ = "";
    /// <summary>
    /// Unique identifier of the pipeline.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PipelineUid {
      get { return pipelineUid_; }
      set {
        pipelineUid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "release_uid" field.</summary>
    public const int ReleaseUidFieldNumber = 2;
    private string releaseUid_ = "";
    /// <summary>
    /// Unique identifier of the release.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ReleaseUid {
      get { return releaseUid_; }
      set {
        releaseUid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "release" field.</summary>
    public const int ReleaseFieldNumber = 8;
    private string release_ = "";
    /// <summary>
    /// The name of the `Release`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Release {
      get { return release_; }
      set {
        release_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rollout" field.</summary>
    public const int RolloutFieldNumber = 3;
    private string rollout_ = "";
    /// <summary>
    /// The name of the rollout.
    /// rollout_uid is not in this log message because we write some of these log
    /// messages at rollout creation time, before we've generated the uid.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Rollout {
      get { return rollout_; }
      set {
        rollout_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_id" field.</summary>
    public const int TargetIdFieldNumber = 4;
    private string targetId_ = "";
    /// <summary>
    /// ID of the target.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TargetId {
      get { return targetId_; }
      set {
        targetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 7;
    private global::Google.Cloud.Deploy.V1.Type type_ = global::Google.Cloud.Deploy.V1.Type.Unspecified;
    /// <summary>
    /// Type of this notification, e.g. for a rollout update event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Deploy.V1.Type Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "rollout_update_type" field.</summary>
    public const int RolloutUpdateTypeFieldNumber = 5;
    private global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Types.RolloutUpdateType rolloutUpdateType_ = global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Types.RolloutUpdateType.Unspecified;
    /// <summary>
    /// The type of the rollout update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Types.RolloutUpdateType RolloutUpdateType {
      get { return rolloutUpdateType_; }
      set {
        rolloutUpdateType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RolloutUpdateEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RolloutUpdateEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (PipelineUid != other.PipelineUid) return false;
      if (ReleaseUid != other.ReleaseUid) return false;
      if (Release != other.Release) return false;
      if (Rollout != other.Rollout) return false;
      if (TargetId != other.TargetId) return false;
      if (Type != other.Type) return false;
      if (RolloutUpdateType != other.RolloutUpdateType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (PipelineUid.Length != 0) hash ^= PipelineUid.GetHashCode();
      if (ReleaseUid.Length != 0) hash ^= ReleaseUid.GetHashCode();
      if (Release.Length != 0) hash ^= Release.GetHashCode();
      if (Rollout.Length != 0) hash ^= Rollout.GetHashCode();
      if (TargetId.Length != 0) hash ^= TargetId.GetHashCode();
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) hash ^= Type.GetHashCode();
      if (RolloutUpdateType != global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Types.RolloutUpdateType.Unspecified) hash ^= RolloutUpdateType.GetHashCode();
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
      if (PipelineUid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PipelineUid);
      }
      if (ReleaseUid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ReleaseUid);
      }
      if (Rollout.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Rollout);
      }
      if (TargetId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TargetId);
      }
      if (RolloutUpdateType != global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Types.RolloutUpdateType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) RolloutUpdateType);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Message);
      }
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Type);
      }
      if (Release.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Release);
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
      if (PipelineUid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PipelineUid);
      }
      if (ReleaseUid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ReleaseUid);
      }
      if (Rollout.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Rollout);
      }
      if (TargetId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TargetId);
      }
      if (RolloutUpdateType != global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Types.RolloutUpdateType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) RolloutUpdateType);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Message);
      }
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Type);
      }
      if (Release.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Release);
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
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (PipelineUid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PipelineUid);
      }
      if (ReleaseUid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReleaseUid);
      }
      if (Release.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Release);
      }
      if (Rollout.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Rollout);
      }
      if (TargetId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetId);
      }
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (RolloutUpdateType != global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Types.RolloutUpdateType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RolloutUpdateType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RolloutUpdateEvent other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.PipelineUid.Length != 0) {
        PipelineUid = other.PipelineUid;
      }
      if (other.ReleaseUid.Length != 0) {
        ReleaseUid = other.ReleaseUid;
      }
      if (other.Release.Length != 0) {
        Release = other.Release;
      }
      if (other.Rollout.Length != 0) {
        Rollout = other.Rollout;
      }
      if (other.TargetId.Length != 0) {
        TargetId = other.TargetId;
      }
      if (other.Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        Type = other.Type;
      }
      if (other.RolloutUpdateType != global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Types.RolloutUpdateType.Unspecified) {
        RolloutUpdateType = other.RolloutUpdateType;
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
            PipelineUid = input.ReadString();
            break;
          }
          case 18: {
            ReleaseUid = input.ReadString();
            break;
          }
          case 26: {
            Rollout = input.ReadString();
            break;
          }
          case 34: {
            TargetId = input.ReadString();
            break;
          }
          case 40: {
            RolloutUpdateType = (global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Types.RolloutUpdateType) input.ReadEnum();
            break;
          }
          case 50: {
            Message = input.ReadString();
            break;
          }
          case 56: {
            Type = (global::Google.Cloud.Deploy.V1.Type) input.ReadEnum();
            break;
          }
          case 66: {
            Release = input.ReadString();
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
            PipelineUid = input.ReadString();
            break;
          }
          case 18: {
            ReleaseUid = input.ReadString();
            break;
          }
          case 26: {
            Rollout = input.ReadString();
            break;
          }
          case 34: {
            TargetId = input.ReadString();
            break;
          }
          case 40: {
            RolloutUpdateType = (global::Google.Cloud.Deploy.V1.RolloutUpdateEvent.Types.RolloutUpdateType) input.ReadEnum();
            break;
          }
          case 50: {
            Message = input.ReadString();
            break;
          }
          case 56: {
            Type = (global::Google.Cloud.Deploy.V1.Type) input.ReadEnum();
            break;
          }
          case 66: {
            Release = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the RolloutUpdateEvent message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// RolloutUpdateType indicates the type of the rollout update.
      /// </summary>
      public enum RolloutUpdateType {
        /// <summary>
        /// Rollout update type unspecified.
        /// </summary>
        [pbr::OriginalName("ROLLOUT_UPDATE_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// rollout state updated to pending.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 1,
        /// <summary>
        /// Rollout state updated to pending release.
        /// </summary>
        [pbr::OriginalName("PENDING_RELEASE")] PendingRelease = 2,
        /// <summary>
        /// Rollout state updated to in progress.
        /// </summary>
        [pbr::OriginalName("IN_PROGRESS")] InProgress = 3,
        /// <summary>
        /// Rollout state updated to cancelling.
        /// </summary>
        [pbr::OriginalName("CANCELLING")] Cancelling = 4,
        /// <summary>
        /// Rollout state updated to cancelled.
        /// </summary>
        [pbr::OriginalName("CANCELLED")] Cancelled = 5,
        /// <summary>
        /// Rollout state updated to halted.
        /// </summary>
        [pbr::OriginalName("HALTED")] Halted = 6,
        /// <summary>
        /// Rollout state updated to succeeded.
        /// </summary>
        [pbr::OriginalName("SUCCEEDED")] Succeeded = 7,
        /// <summary>
        /// Rollout state updated to failed.
        /// </summary>
        [pbr::OriginalName("FAILED")] Failed = 8,
        /// <summary>
        /// Rollout requires approval.
        /// </summary>
        [pbr::OriginalName("APPROVAL_REQUIRED")] ApprovalRequired = 9,
        /// <summary>
        /// Rollout has been approved.
        /// </summary>
        [pbr::OriginalName("APPROVED")] Approved = 10,
        /// <summary>
        /// Rollout has been rejected.
        /// </summary>
        [pbr::OriginalName("REJECTED")] Rejected = 11,
        /// <summary>
        /// Rollout requires advance to the next phase.
        /// </summary>
        [pbr::OriginalName("ADVANCE_REQUIRED")] AdvanceRequired = 12,
        /// <summary>
        /// Rollout has been advanced.
        /// </summary>
        [pbr::OriginalName("ADVANCED")] Advanced = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
