// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/functions/v1/operations.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Functions.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/functions/v1/operations.proto</summary>
  public static partial class OperationsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/functions/v1/operations.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperationsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipnb29nbGUvY2xvdWQvZnVuY3Rpb25zL3YxL29wZXJhdGlvbnMucHJvdG8S",
            "GWdvb2dsZS5jbG91ZC5mdW5jdGlvbnMudjEaGWdvb2dsZS9wcm90b2J1Zi9h",
            "bnkucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8aHGdv",
            "b2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i2wEKE09wZXJhdGlvbk1ldGFk",
            "YXRhVjESDgoGdGFyZ2V0GAEgASgJEjYKBHR5cGUYAiABKA4yKC5nb29nbGUu",
            "Y2xvdWQuZnVuY3Rpb25zLnYxLk9wZXJhdGlvblR5cGUSJQoHcmVxdWVzdBgD",
            "IAEoCzIULmdvb2dsZS5wcm90b2J1Zi5BbnkSEgoKdmVyc2lvbl9pZBgEIAEo",
            "AxIvCgt1cGRhdGVfdGltZRgFIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1l",
            "c3RhbXASEAoIYnVpbGRfaWQYBiABKAkqaQoNT3BlcmF0aW9uVHlwZRIZChVP",
            "UEVSQVRJT05fVU5TUEVDSUZJRUQQABITCg9DUkVBVEVfRlVOQ1RJT04QARIT",
            "Cg9VUERBVEVfRlVOQ1RJT04QAhITCg9ERUxFVEVfRlVOQ1RJT04QA0J/Ch1j",
            "b20uZ29vZ2xlLmNsb3VkLmZ1bmN0aW9ucy52MUIYRnVuY3Rpb25zT3BlcmF0",
            "aW9uc1Byb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvY2xvdWQvZnVuY3Rpb25zL3YxO2Z1bmN0aW9uc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.Functions.V1.OperationType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Functions.V1.OperationMetadataV1), global::Google.Cloud.Functions.V1.OperationMetadataV1.Parser, new[]{ "Target", "Type", "Request", "VersionId", "UpdateTime", "BuildId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// A type of an operation.
  /// </summary>
  public enum OperationType {
    /// <summary>
    /// Unknown operation type.
    /// </summary>
    [pbr::OriginalName("OPERATION_UNSPECIFIED")] OperationUnspecified = 0,
    /// <summary>
    /// Triggered by CreateFunction call
    /// </summary>
    [pbr::OriginalName("CREATE_FUNCTION")] CreateFunction = 1,
    /// <summary>
    /// Triggered by UpdateFunction call
    /// </summary>
    [pbr::OriginalName("UPDATE_FUNCTION")] UpdateFunction = 2,
    /// <summary>
    /// Triggered by DeleteFunction call.
    /// </summary>
    [pbr::OriginalName("DELETE_FUNCTION")] DeleteFunction = 3,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Metadata describing an [Operation][google.longrunning.Operation]
  /// </summary>
  public sealed partial class OperationMetadataV1 : pb::IMessage<OperationMetadataV1>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OperationMetadataV1> _parser = new pb::MessageParser<OperationMetadataV1>(() => new OperationMetadataV1());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OperationMetadataV1> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Functions.V1.OperationsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadataV1() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadataV1(OperationMetadataV1 other) : this() {
      target_ = other.target_;
      type_ = other.type_;
      request_ = other.request_ != null ? other.request_.Clone() : null;
      versionId_ = other.versionId_;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      buildId_ = other.buildId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadataV1 Clone() {
      return new OperationMetadataV1(this);
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 1;
    private string target_ = "";
    /// <summary>
    /// Target of the operation - for example
    /// `projects/project-1/locations/region-1/functions/function-1`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Target {
      get { return target_; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Google.Cloud.Functions.V1.OperationType type_ = global::Google.Cloud.Functions.V1.OperationType.OperationUnspecified;
    /// <summary>
    /// Type of operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Functions.V1.OperationType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "request" field.</summary>
    public const int RequestFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Any request_;
    /// <summary>
    /// The original request that started the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Any Request {
      get { return request_; }
      set {
        request_ = value;
      }
    }

    /// <summary>Field number for the "version_id" field.</summary>
    public const int VersionIdFieldNumber = 4;
    private long versionId_;
    /// <summary>
    /// Version id of the function created or updated by an API call.
    /// This field is only populated for Create and Update operations.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long VersionId {
      get { return versionId_; }
      set {
        versionId_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// The last update timestamp of the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "build_id" field.</summary>
    public const int BuildIdFieldNumber = 6;
    private string buildId_ = "";
    /// <summary>
    /// The Cloud Build ID of the function created or updated by an API call.
    /// This field is only populated for Create and Update operations.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BuildId {
      get { return buildId_; }
      set {
        buildId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OperationMetadataV1);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OperationMetadataV1 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Target != other.Target) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(Request, other.Request)) return false;
      if (VersionId != other.VersionId) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (BuildId != other.BuildId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Target.Length != 0) hash ^= Target.GetHashCode();
      if (Type != global::Google.Cloud.Functions.V1.OperationType.OperationUnspecified) hash ^= Type.GetHashCode();
      if (request_ != null) hash ^= Request.GetHashCode();
      if (VersionId != 0L) hash ^= VersionId.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (BuildId.Length != 0) hash ^= BuildId.GetHashCode();
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
      if (Target.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Target);
      }
      if (Type != global::Google.Cloud.Functions.V1.OperationType.OperationUnspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (request_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Request);
      }
      if (VersionId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(VersionId);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpdateTime);
      }
      if (BuildId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(BuildId);
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
      if (Target.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Target);
      }
      if (Type != global::Google.Cloud.Functions.V1.OperationType.OperationUnspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (request_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Request);
      }
      if (VersionId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(VersionId);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpdateTime);
      }
      if (BuildId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(BuildId);
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
      if (Target.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Target);
      }
      if (Type != global::Google.Cloud.Functions.V1.OperationType.OperationUnspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (request_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Request);
      }
      if (VersionId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(VersionId);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (BuildId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuildId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OperationMetadataV1 other) {
      if (other == null) {
        return;
      }
      if (other.Target.Length != 0) {
        Target = other.Target;
      }
      if (other.Type != global::Google.Cloud.Functions.V1.OperationType.OperationUnspecified) {
        Type = other.Type;
      }
      if (other.request_ != null) {
        if (request_ == null) {
          Request = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Request.MergeFrom(other.Request);
      }
      if (other.VersionId != 0L) {
        VersionId = other.VersionId;
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.BuildId.Length != 0) {
        BuildId = other.BuildId;
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
            Target = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Google.Cloud.Functions.V1.OperationType) input.ReadEnum();
            break;
          }
          case 26: {
            if (request_ == null) {
              Request = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Request);
            break;
          }
          case 32: {
            VersionId = input.ReadInt64();
            break;
          }
          case 42: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 50: {
            BuildId = input.ReadString();
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
            Target = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Google.Cloud.Functions.V1.OperationType) input.ReadEnum();
            break;
          }
          case 26: {
            if (request_ == null) {
              Request = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Request);
            break;
          }
          case 32: {
            VersionId = input.ReadInt64();
            break;
          }
          case 42: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 50: {
            BuildId = input.ReadString();
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
