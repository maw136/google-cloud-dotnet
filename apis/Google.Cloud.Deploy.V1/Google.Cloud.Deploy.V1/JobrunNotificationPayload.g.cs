// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/deploy/v1/jobrun_notification_payload.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Deploy.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/deploy/v1/jobrun_notification_payload.proto</summary>
  public static partial class JobrunNotificationPayloadReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/deploy/v1/jobrun_notification_payload.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JobrunNotificationPayloadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvY2xvdWQvZGVwbG95L3YxL2pvYnJ1bl9ub3RpZmljYXRpb25f",
            "cGF5bG9hZC5wcm90bxIWZ29vZ2xlLmNsb3VkLmRlcGxveS52MRomZ29vZ2xl",
            "L2Nsb3VkL2RlcGxveS92MS9sb2dfZW51bXMucHJvdG8i3AEKF0pvYlJ1bk5v",
            "dGlmaWNhdGlvbkV2ZW50Eg8KB21lc3NhZ2UYASABKAkSDwoHam9iX3J1bhgC",
            "IAEoCRIUCgxwaXBlbGluZV91aWQYAyABKAkSEwoLcmVsZWFzZV91aWQYBCAB",
            "KAkSDwoHcmVsZWFzZRgIIAEoCRITCgtyb2xsb3V0X3VpZBgFIAEoCRIPCgdy",
            "b2xsb3V0GAkgASgJEhEKCXRhcmdldF9pZBgGIAEoCRIqCgR0eXBlGAcgASgO",
            "MhwuZ29vZ2xlLmNsb3VkLmRlcGxveS52MS5UeXBlQnIKGmNvbS5nb29nbGUu",
            "Y2xvdWQuZGVwbG95LnYxQh5Kb2JSdW5Ob3RpZmljYXRpb25QYXlsb2FkUHJv",
            "dG9QAVoyY2xvdWQuZ29vZ2xlLmNvbS9nby9kZXBsb3kvYXBpdjEvZGVwbG95",
            "cGI7ZGVwbG95cGJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.Deploy.V1.LogEnumsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Deploy.V1.JobRunNotificationEvent), global::Google.Cloud.Deploy.V1.JobRunNotificationEvent.Parser, new[]{ "Message", "JobRun", "PipelineUid", "ReleaseUid", "Release", "RolloutUid", "Rollout", "TargetId", "Type" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Payload proto for "clouddeploy.googleapis.com/jobrun_notification"
  /// Platform Log event that describes the failure to send JobRun resource update
  /// Pub/Sub notification.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class JobRunNotificationEvent : pb::IMessage<JobRunNotificationEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JobRunNotificationEvent> _parser = new pb::MessageParser<JobRunNotificationEvent>(() => new JobRunNotificationEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JobRunNotificationEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Deploy.V1.JobrunNotificationPayloadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JobRunNotificationEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JobRunNotificationEvent(JobRunNotificationEvent other) : this() {
      message_ = other.message_;
      jobRun_ = other.jobRun_;
      pipelineUid_ = other.pipelineUid_;
      releaseUid_ = other.releaseUid_;
      release_ = other.release_;
      rolloutUid_ = other.rolloutUid_;
      rollout_ = other.rollout_;
      targetId_ = other.targetId_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JobRunNotificationEvent Clone() {
      return new JobRunNotificationEvent(this);
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

    /// <summary>Field number for the "job_run" field.</summary>
    public const int JobRunFieldNumber = 2;
    private string jobRun_ = "";
    /// <summary>
    /// The name of the `JobRun`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JobRun {
      get { return jobRun_; }
      set {
        jobRun_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pipeline_uid" field.</summary>
    public const int PipelineUidFieldNumber = 3;
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
    public const int ReleaseUidFieldNumber = 4;
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

    /// <summary>Field number for the "rollout_uid" field.</summary>
    public const int RolloutUidFieldNumber = 5;
    private string rolloutUid_ = "";
    /// <summary>
    /// Unique identifier of the `Rollout`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RolloutUid {
      get { return rolloutUid_; }
      set {
        rolloutUid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rollout" field.</summary>
    public const int RolloutFieldNumber = 9;
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

    /// <summary>Field number for the "target_id" field.</summary>
    public const int TargetIdFieldNumber = 6;
    private string targetId_ = "";
    /// <summary>
    /// ID of the `Target`.
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JobRunNotificationEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JobRunNotificationEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (JobRun != other.JobRun) return false;
      if (PipelineUid != other.PipelineUid) return false;
      if (ReleaseUid != other.ReleaseUid) return false;
      if (Release != other.Release) return false;
      if (RolloutUid != other.RolloutUid) return false;
      if (Rollout != other.Rollout) return false;
      if (TargetId != other.TargetId) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (JobRun.Length != 0) hash ^= JobRun.GetHashCode();
      if (PipelineUid.Length != 0) hash ^= PipelineUid.GetHashCode();
      if (ReleaseUid.Length != 0) hash ^= ReleaseUid.GetHashCode();
      if (Release.Length != 0) hash ^= Release.GetHashCode();
      if (RolloutUid.Length != 0) hash ^= RolloutUid.GetHashCode();
      if (Rollout.Length != 0) hash ^= Rollout.GetHashCode();
      if (TargetId.Length != 0) hash ^= TargetId.GetHashCode();
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) hash ^= Type.GetHashCode();
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
      if (JobRun.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(JobRun);
      }
      if (PipelineUid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PipelineUid);
      }
      if (ReleaseUid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ReleaseUid);
      }
      if (RolloutUid.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RolloutUid);
      }
      if (TargetId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TargetId);
      }
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Type);
      }
      if (Release.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Release);
      }
      if (Rollout.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Rollout);
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
      if (JobRun.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(JobRun);
      }
      if (PipelineUid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PipelineUid);
      }
      if (ReleaseUid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ReleaseUid);
      }
      if (RolloutUid.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RolloutUid);
      }
      if (TargetId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TargetId);
      }
      if (Type != global::Google.Cloud.Deploy.V1.Type.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Type);
      }
      if (Release.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Release);
      }
      if (Rollout.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Rollout);
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
      if (JobRun.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JobRun);
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
      if (RolloutUid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RolloutUid);
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JobRunNotificationEvent other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.JobRun.Length != 0) {
        JobRun = other.JobRun;
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
      if (other.RolloutUid.Length != 0) {
        RolloutUid = other.RolloutUid;
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
            JobRun = input.ReadString();
            break;
          }
          case 26: {
            PipelineUid = input.ReadString();
            break;
          }
          case 34: {
            ReleaseUid = input.ReadString();
            break;
          }
          case 42: {
            RolloutUid = input.ReadString();
            break;
          }
          case 50: {
            TargetId = input.ReadString();
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
          case 74: {
            Rollout = input.ReadString();
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
            JobRun = input.ReadString();
            break;
          }
          case 26: {
            PipelineUid = input.ReadString();
            break;
          }
          case 34: {
            ReleaseUid = input.ReadString();
            break;
          }
          case 42: {
            RolloutUid = input.ReadString();
            break;
          }
          case 50: {
            TargetId = input.ReadString();
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
          case 74: {
            Rollout = input.ReadString();
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
