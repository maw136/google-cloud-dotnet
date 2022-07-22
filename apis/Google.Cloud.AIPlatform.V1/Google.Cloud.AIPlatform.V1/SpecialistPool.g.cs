// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/specialist_pool.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/specialist_pool.proto</summary>
  public static partial class SpecialistPoolReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/specialist_pool.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpecialistPoolReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zcGVjaWFsaXN0X3Bvb2wu",
            "cHJvdG8SGmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxGh9nb29nbGUvYXBp",
            "L2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnBy",
            "b3RvIs4CCg5TcGVjaWFsaXN0UG9vbBIRCgRuYW1lGAEgASgJQgPgQQISGQoM",
            "ZGlzcGxheV9uYW1lGAIgASgJQgPgQQISJgoZc3BlY2lhbGlzdF9tYW5hZ2Vy",
            "c19jb3VudBgDIAEoBUID4EEDEiEKGXNwZWNpYWxpc3RfbWFuYWdlcl9lbWFp",
            "bHMYBCADKAkSJwoacGVuZGluZ19kYXRhX2xhYmVsaW5nX2pvYnMYBSADKAlC",
            "A+BBAxIgChhzcGVjaWFsaXN0X3dvcmtlcl9lbWFpbHMYByADKAk6eOpBdQoo",
            "YWlwbGF0Zm9ybS5nb29nbGVhcGlzLmNvbS9TcGVjaWFsaXN0UG9vbBJJcHJv",
            "amVjdHMve3Byb2plY3R9L2xvY2F0aW9ucy97bG9jYXRpb259L3NwZWNpYWxp",
            "c3RQb29scy97c3BlY2lhbGlzdF9wb29sfULXAQoeY29tLmdvb2dsZS5jbG91",
            "ZC5haXBsYXRmb3JtLnYxQhNTcGVjaWFsaXN0UG9vbFByb3RvUAFaRGdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvYWlwbGF0",
            "Zm9ybS92MTthaXBsYXRmb3JtqgIaR29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0u",
            "VjHKAhpHb29nbGVcQ2xvdWRcQUlQbGF0Zm9ybVxWMeoCHUdvb2dsZTo6Q2xv",
            "dWQ6OkFJUGxhdGZvcm06OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.SpecialistPool), global::Google.Cloud.AIPlatform.V1.SpecialistPool.Parser, new[]{ "Name", "DisplayName", "SpecialistManagersCount", "SpecialistManagerEmails", "PendingDataLabelingJobs", "SpecialistWorkerEmails" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// SpecialistPool represents customers' own workforce to work on their data
  /// labeling jobs. It includes a group of specialist managers and workers.
  /// Managers are responsible for managing the workers in this pool as well as
  /// customers' data labeling jobs associated with this pool. Customers create
  /// specialist pool as well as start data labeling jobs on Cloud, managers and
  /// workers handle the jobs using CrowdCompute console.
  /// </summary>
  public sealed partial class SpecialistPool : pb::IMessage<SpecialistPool>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpecialistPool> _parser = new pb::MessageParser<SpecialistPool>(() => new SpecialistPool());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpecialistPool> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.SpecialistPoolReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpecialistPool() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpecialistPool(SpecialistPool other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      specialistManagersCount_ = other.specialistManagersCount_;
      specialistManagerEmails_ = other.specialistManagerEmails_.Clone();
      pendingDataLabelingJobs_ = other.pendingDataLabelingJobs_.Clone();
      specialistWorkerEmails_ = other.specialistWorkerEmails_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpecialistPool Clone() {
      return new SpecialistPool(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. The resource name of the SpecialistPool.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Required. The user-defined name of the SpecialistPool.
    /// The name can be up to 128 characters long and can be consist of any UTF-8
    /// characters.
    /// This field should be unique on project-level.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "specialist_managers_count" field.</summary>
    public const int SpecialistManagersCountFieldNumber = 3;
    private int specialistManagersCount_;
    /// <summary>
    /// Output only. The number of managers in this SpecialistPool.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SpecialistManagersCount {
      get { return specialistManagersCount_; }
      set {
        specialistManagersCount_ = value;
      }
    }

    /// <summary>Field number for the "specialist_manager_emails" field.</summary>
    public const int SpecialistManagerEmailsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_specialistManagerEmails_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> specialistManagerEmails_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The email addresses of the managers in the SpecialistPool.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> SpecialistManagerEmails {
      get { return specialistManagerEmails_; }
    }

    /// <summary>Field number for the "pending_data_labeling_jobs" field.</summary>
    public const int PendingDataLabelingJobsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_pendingDataLabelingJobs_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> pendingDataLabelingJobs_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. The resource name of the pending data labeling jobs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> PendingDataLabelingJobs {
      get { return pendingDataLabelingJobs_; }
    }

    /// <summary>Field number for the "specialist_worker_emails" field.</summary>
    public const int SpecialistWorkerEmailsFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _repeated_specialistWorkerEmails_codec
        = pb::FieldCodec.ForString(58);
    private readonly pbc::RepeatedField<string> specialistWorkerEmails_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The email addresses of workers in the SpecialistPool.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> SpecialistWorkerEmails {
      get { return specialistWorkerEmails_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpecialistPool);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpecialistPool other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (SpecialistManagersCount != other.SpecialistManagersCount) return false;
      if(!specialistManagerEmails_.Equals(other.specialistManagerEmails_)) return false;
      if(!pendingDataLabelingJobs_.Equals(other.pendingDataLabelingJobs_)) return false;
      if(!specialistWorkerEmails_.Equals(other.specialistWorkerEmails_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (SpecialistManagersCount != 0) hash ^= SpecialistManagersCount.GetHashCode();
      hash ^= specialistManagerEmails_.GetHashCode();
      hash ^= pendingDataLabelingJobs_.GetHashCode();
      hash ^= specialistWorkerEmails_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (SpecialistManagersCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SpecialistManagersCount);
      }
      specialistManagerEmails_.WriteTo(output, _repeated_specialistManagerEmails_codec);
      pendingDataLabelingJobs_.WriteTo(output, _repeated_pendingDataLabelingJobs_codec);
      specialistWorkerEmails_.WriteTo(output, _repeated_specialistWorkerEmails_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (SpecialistManagersCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SpecialistManagersCount);
      }
      specialistManagerEmails_.WriteTo(ref output, _repeated_specialistManagerEmails_codec);
      pendingDataLabelingJobs_.WriteTo(ref output, _repeated_pendingDataLabelingJobs_codec);
      specialistWorkerEmails_.WriteTo(ref output, _repeated_specialistWorkerEmails_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (SpecialistManagersCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SpecialistManagersCount);
      }
      size += specialistManagerEmails_.CalculateSize(_repeated_specialistManagerEmails_codec);
      size += pendingDataLabelingJobs_.CalculateSize(_repeated_pendingDataLabelingJobs_codec);
      size += specialistWorkerEmails_.CalculateSize(_repeated_specialistWorkerEmails_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpecialistPool other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.SpecialistManagersCount != 0) {
        SpecialistManagersCount = other.SpecialistManagersCount;
      }
      specialistManagerEmails_.Add(other.specialistManagerEmails_);
      pendingDataLabelingJobs_.Add(other.pendingDataLabelingJobs_);
      specialistWorkerEmails_.Add(other.specialistWorkerEmails_);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 24: {
            SpecialistManagersCount = input.ReadInt32();
            break;
          }
          case 34: {
            specialistManagerEmails_.AddEntriesFrom(input, _repeated_specialistManagerEmails_codec);
            break;
          }
          case 42: {
            pendingDataLabelingJobs_.AddEntriesFrom(input, _repeated_pendingDataLabelingJobs_codec);
            break;
          }
          case 58: {
            specialistWorkerEmails_.AddEntriesFrom(input, _repeated_specialistWorkerEmails_codec);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 24: {
            SpecialistManagersCount = input.ReadInt32();
            break;
          }
          case 34: {
            specialistManagerEmails_.AddEntriesFrom(ref input, _repeated_specialistManagerEmails_codec);
            break;
          }
          case 42: {
            pendingDataLabelingJobs_.AddEntriesFrom(ref input, _repeated_pendingDataLabelingJobs_codec);
            break;
          }
          case 58: {
            specialistWorkerEmails_.AddEntriesFrom(ref input, _repeated_specialistWorkerEmails_codec);
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
