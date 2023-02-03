// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/deploy/v1/rollout_notification_payload.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Deploy.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/deploy/v1/rollout_notification_payload.proto</summary>
  public static partial class RolloutNotificationPayloadReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/deploy/v1/rollout_notification_payload.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RolloutNotificationPayloadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvY2xvdWQvZGVwbG95L3YxL3JvbGxvdXRfbm90aWZpY2F0aW9u",
            "X3BheWxvYWQucHJvdG8SFmdvb2dsZS5jbG91ZC5kZXBsb3kudjEaJmdvb2ds",
            "ZS9jbG91ZC9kZXBsb3kvdjEvbG9nX2VudW1zLnByb3RvIqYBChhSb2xsb3V0",
            "Tm90aWZpY2F0aW9uRXZlbnQSDwoHbWVzc2FnZRgBIAEoCRIUCgxwaXBlbGlu",
            "ZV91aWQYAiABKAkSEwoLcmVsZWFzZV91aWQYAyABKAkSDwoHcm9sbG91dBgE",
            "IAEoCRIqCgR0eXBlGAUgASgOMhwuZ29vZ2xlLmNsb3VkLmRlcGxveS52MS5U",
            "eXBlEhEKCXRhcmdldF9pZBgGIAEoCUJzChpjb20uZ29vZ2xlLmNsb3VkLmRl",
            "cGxveS52MUIfUm9sbG91dE5vdGlmaWNhdGlvblBheWxvYWRQcm90b1ABWjJj",
            "bG91ZC5nb29nbGUuY29tL2dvL2RlcGxveS9hcGl2MS9kZXBsb3lwYjtkZXBs",
            "b3lwYmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.Deploy.V1.LogEnumsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Deploy.V1.RolloutNotificationEvent), global::Google.Cloud.Deploy.V1.RolloutNotificationEvent.Parser, new[]{ "Message", "PipelineUid", "ReleaseUid", "Rollout", "Type", "TargetId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Payload proto for "clouddeploy.googleapis.com/rollout_notification"
  /// Platform Log event that describes the failure to send rollout status change
  /// Pub/Sub notification.
  /// </summary>
  public sealed partial class RolloutNotificationEvent : pb::IMessage<RolloutNotificationEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RolloutNotificationEvent> _parser = new pb::MessageParser<RolloutNotificationEvent>(() => new RolloutNotificationEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RolloutNotificationEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Deploy.V1.RolloutNotificationPayloadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RolloutNotificationEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RolloutNotificationEvent(RolloutNotificationEvent other) : this() {
      message_ = other.message_;
      pipelineUid_ = other.pipelineUid_;
      releaseUid_ = other.releaseUid_;
      rollout_ = other.rollout_;
      type_ = other.type_;
      targetId_ = other.targetId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RolloutNotificationEvent Clone() {
      return new RolloutNotificationEvent(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    /// <summary>
    /// Debug message for when a notification fails to send.
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
    public const int PipelineUidFieldNumber = 2;
    private string pipelineUid_ = "";
    /// <summary>
    /// Unique identifier of the `DeliveryPipeline`.
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
    public const int ReleaseUidFieldNumber = 3;
    private string releaseUid_ = "";
    /// <summary>
    /// Unique identifier of the `Release`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ReleaseUid {
      get { return releaseUid_; }
      set {
        releaseUid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rollout" field.</summary>
    public const int RolloutFieldNumber = 4;
    private string rollout_ = "";
    /// <summary>
    /// The name of the `Rollout`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Rollout {
      get { return rollout_; }
      set {
        rollout_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 5;
    private global::Google.Cloud.Deploy.V1.Type type_ = global::Google.Cloud.Deploy.V1.Type.Unspecified;
    /// <summary>
    /// Type of this notification, e.g. for a Pub/Sub failure.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Deploy.V1.Type Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "target_id" field.</summary>
    public const int TargetIdFieldNumber = 6;
    private string targetId_ = "";
    /// <summary>
    /// ID of the `Target` that the rollout is deployed to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TargetId {
      get { return targetId_; }
      set {
        targetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RolloutNotificationEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RolloutNotificationEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (PipelineUid != other.PipelineUid) return false;
      if (ReleaseUid != other.ReleaseUid) return false;
      if (Rollout != other.Rollout) return false;
      if (Type != other.Type) return false;
      if (TargetId != other.TargetId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (PipelineUid.Length != 0) hash ^= PipelineUid.GetHashCode();
      if (ReleaseUid.Length != 0) hash ^= ReleaseUid.GetHashCode();
      if (Rollout.Length != 0) hash ^= Rollout.GetHashCode();
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) hash ^= Type.GetHashCode();
      if (TargetId.Length != 0) hash ^= TargetId.GetHashCode();
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
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (PipelineUid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PipelineUid);
      }
      if (ReleaseUid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ReleaseUid);
      }
      if (Rollout.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Rollout);
      }
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Type);
      }
      if (TargetId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TargetId);
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
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (PipelineUid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PipelineUid);
      }
      if (ReleaseUid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ReleaseUid);
      }
      if (Rollout.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Rollout);
      }
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Type);
      }
      if (TargetId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TargetId);
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
      if (Rollout.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Rollout);
      }
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (TargetId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RolloutNotificationEvent other) {
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
      if (other.Rollout.Length != 0) {
        Rollout = other.Rollout;
      }
      if (other.Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        Type = other.Type;
      }
      if (other.TargetId.Length != 0) {
        TargetId = other.TargetId;
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
            Message = input.ReadString();
            break;
          }
          case 18: {
            PipelineUid = input.ReadString();
            break;
          }
          case 26: {
            ReleaseUid = input.ReadString();
            break;
          }
          case 34: {
            Rollout = input.ReadString();
            break;
          }
          case 40: {
            Type = (global::Google.Cloud.Deploy.V1.Type) input.ReadEnum();
            break;
          }
          case 50: {
            TargetId = input.ReadString();
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
            Message = input.ReadString();
            break;
          }
          case 18: {
            PipelineUid = input.ReadString();
            break;
          }
          case 26: {
            ReleaseUid = input.ReadString();
            break;
          }
          case 34: {
            Rollout = input.ReadString();
            break;
          }
          case 40: {
            Type = (global::Google.Cloud.Deploy.V1.Type) input.ReadEnum();
            break;
          }
          case 50: {
            TargetId = input.ReadString();
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
