// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/orchestration/airflow/service/v1/operations.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Orchestration.Airflow.Service.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/orchestration/airflow/service/v1/operations.proto</summary>
  public static partial class OperationsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/orchestration/airflow/service/v1/operations.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperationsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvY2xvdWQvb3JjaGVzdHJhdGlvbi9haXJmbG93L3NlcnZpY2Uv",
            "djEvb3BlcmF0aW9ucy5wcm90bxItZ29vZ2xlLmNsb3VkLm9yY2hlc3RyYXRp",
            "b24uYWlyZmxvdy5zZXJ2aWNlLnYxGh9nb29nbGUvcHJvdG9idWYvdGltZXN0",
            "YW1wLnByb3RvIocEChFPcGVyYXRpb25NZXRhZGF0YRJVCgVzdGF0ZRgBIAEo",
            "DjJGLmdvb2dsZS5jbG91ZC5vcmNoZXN0cmF0aW9uLmFpcmZsb3cuc2Vydmlj",
            "ZS52MS5PcGVyYXRpb25NZXRhZGF0YS5TdGF0ZRJdCg5vcGVyYXRpb25fdHlw",
            "ZRgCIAEoDjJFLmdvb2dsZS5jbG91ZC5vcmNoZXN0cmF0aW9uLmFpcmZsb3cu",
            "c2VydmljZS52MS5PcGVyYXRpb25NZXRhZGF0YS5UeXBlEhAKCHJlc291cmNl",
            "GAMgASgJEhUKDXJlc291cmNlX3V1aWQYBCABKAkSLwoLY3JlYXRlX3RpbWUY",
            "BSABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEiwKCGVuZF90aW1l",
            "GAYgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcCJnCgVTdGF0ZRIV",
            "ChFTVEFURV9VTlNQRUNJRklFRBAAEgsKB1BFTkRJTkcQARILCgdSVU5OSU5H",
            "EAISDQoJU1VDQ0VFREVEEAMSDgoKU1VDQ0VTU0ZVTBADEgoKBkZBSUxFRBAE",
            "GgIQASJLCgRUeXBlEhQKEFRZUEVfVU5TUEVDSUZJRUQQABIKCgZDUkVBVEUQ",
            "ARIKCgZERUxFVEUQAhIKCgZVUERBVEUQAxIJCgVDSEVDSxAEQpwBCjFjb20u",
            "Z29vZ2xlLmNsb3VkLm9yY2hlc3RyYXRpb24uYWlyZmxvdy5zZXJ2aWNlLnYx",
            "Qg9PcGVyYXRpb25zUHJvdG9QAVpUZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9jbG91ZC9vcmNoZXN0cmF0aW9uL2FpcmZsb3cvc2Vy",
            "dmljZS92MTtzZXJ2aWNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata), global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Parser, new[]{ "State", "OperationType", "Resource", "ResourceUuid", "CreateTime", "EndTime" }, null, new[]{ typeof(global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.State), typeof(global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.Type) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Metadata describing an operation.
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
      get { return global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationsReflection.Descriptor.MessageTypes[0]; }
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
      state_ = other.state_;
      operationType_ = other.operationType_;
      resource_ = other.resource_;
      resourceUuid_ = other.resourceUuid_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      endTime_ = other.endTime_ != null ? other.endTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata Clone() {
      return new OperationMetadata(this);
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 1;
    private global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.State state_ = global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.State.Unspecified;
    /// <summary>
    /// Output only. The current operation state.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "operation_type" field.</summary>
    public const int OperationTypeFieldNumber = 2;
    private global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.Type operationType_ = global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.Type.Unspecified;
    /// <summary>
    /// Output only. The type of operation being performed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.Type OperationType {
      get { return operationType_; }
      set {
        operationType_ = value;
      }
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 3;
    private string resource_ = "";
    /// <summary>
    /// Output only. The resource being operated on, as a [relative resource name](
    /// /apis/design/resource_names#relative_resource_name).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Resource {
      get { return resource_; }
      set {
        resource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resource_uuid" field.</summary>
    public const int ResourceUuidFieldNumber = 4;
    private string resourceUuid_ = "";
    /// <summary>
    /// Output only. The UUID of the resource being operated on.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceUuid {
      get { return resourceUuid_; }
      set {
        resourceUuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The time the operation was submitted to the server.
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
    public const int EndTimeFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    /// Output only. The time when the operation terminated, regardless of its success.
    /// This field is unset if the operation is still ongoing.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
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
      if (State != other.State) return false;
      if (OperationType != other.OperationType) return false;
      if (Resource != other.Resource) return false;
      if (ResourceUuid != other.ResourceUuid) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (State != global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (OperationType != global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.Type.Unspecified) hash ^= OperationType.GetHashCode();
      if (Resource.Length != 0) hash ^= Resource.GetHashCode();
      if (ResourceUuid.Length != 0) hash ^= ResourceUuid.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
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
      if (State != global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.State.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) State);
      }
      if (OperationType != global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.Type.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) OperationType);
      }
      if (Resource.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Resource);
      }
      if (ResourceUuid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ResourceUuid);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(EndTime);
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
      if (State != global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.State.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) State);
      }
      if (OperationType != global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.Type.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) OperationType);
      }
      if (Resource.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Resource);
      }
      if (ResourceUuid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ResourceUuid);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(EndTime);
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
      if (State != global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (OperationType != global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.Type.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OperationType);
      }
      if (Resource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Resource);
      }
      if (ResourceUuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceUuid);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
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
      if (other.State != global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.OperationType != global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.Type.Unspecified) {
        OperationType = other.OperationType;
      }
      if (other.Resource.Length != 0) {
        Resource = other.Resource;
      }
      if (other.ResourceUuid.Length != 0) {
        ResourceUuid = other.ResourceUuid;
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
          case 8: {
            State = (global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.State) input.ReadEnum();
            break;
          }
          case 16: {
            OperationType = (global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.Type) input.ReadEnum();
            break;
          }
          case 26: {
            Resource = input.ReadString();
            break;
          }
          case 34: {
            ResourceUuid = input.ReadString();
            break;
          }
          case 42: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 50: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
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
          case 8: {
            State = (global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.State) input.ReadEnum();
            break;
          }
          case 16: {
            OperationType = (global::Google.Cloud.Orchestration.Airflow.Service.V1.OperationMetadata.Types.Type) input.ReadEnum();
            break;
          }
          case 26: {
            Resource = input.ReadString();
            break;
          }
          case 34: {
            ResourceUuid = input.ReadString();
            break;
          }
          case 42: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 50: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the OperationMetadata message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// An enum describing the overall state of an operation.
      /// </summary>
      public enum State {
        /// <summary>
        /// Unused.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The operation has been created but is not yet started.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 1,
        /// <summary>
        /// The operation is underway.
        /// </summary>
        [pbr::OriginalName("RUNNING")] Running = 2,
        /// <summary>
        /// The operation completed successfully.
        /// </summary>
        [pbr::OriginalName("SUCCEEDED")] Succeeded = 3,
        [pbr::OriginalName("SUCCESSFUL", PreferredAlias = false)] Successful = 3,
        /// <summary>
        /// The operation is no longer running but did not succeed.
        /// </summary>
        [pbr::OriginalName("FAILED")] Failed = 4,
      }

      /// <summary>
      /// Type of longrunning operation.
      /// </summary>
      public enum Type {
        /// <summary>
        /// Unused.
        /// </summary>
        [pbr::OriginalName("TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// A resource creation operation.
        /// </summary>
        [pbr::OriginalName("CREATE")] Create = 1,
        /// <summary>
        /// A resource deletion operation.
        /// </summary>
        [pbr::OriginalName("DELETE")] Delete = 2,
        /// <summary>
        /// A resource update operation.
        /// </summary>
        [pbr::OriginalName("UPDATE")] Update = 3,
        /// <summary>
        /// A resource check operation.
        /// </summary>
        [pbr::OriginalName("CHECK")] Check = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
