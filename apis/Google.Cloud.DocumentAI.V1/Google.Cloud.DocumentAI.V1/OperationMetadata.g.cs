// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/documentai/v1/operation_metadata.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DocumentAI.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/documentai/v1/operation_metadata.proto</summary>
  public static partial class OperationMetadataReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/documentai/v1/operation_metadata.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperationMetadataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvZG9jdW1lbnRhaS92MS9vcGVyYXRpb25fbWV0YWRh",
            "dGEucHJvdG8SGmdvb2dsZS5jbG91ZC5kb2N1bWVudGFpLnYxGh9nb29nbGUv",
            "cHJvdG9idWYvdGltZXN0YW1wLnByb3RvIsMCChdDb21tb25PcGVyYXRpb25N",
            "ZXRhZGF0YRJICgVzdGF0ZRgBIAEoDjI5Lmdvb2dsZS5jbG91ZC5kb2N1bWVu",
            "dGFpLnYxLkNvbW1vbk9wZXJhdGlvbk1ldGFkYXRhLlN0YXRlEhUKDXN0YXRl",
            "X21lc3NhZ2UYAiABKAkSLwoLY3JlYXRlX3RpbWUYAyABKAsyGi5nb29nbGUu",
            "cHJvdG9idWYuVGltZXN0YW1wEi8KC3VwZGF0ZV90aW1lGAQgASgLMhouZ29v",
            "Z2xlLnByb3RvYnVmLlRpbWVzdGFtcCJlCgVTdGF0ZRIVChFTVEFURV9VTlNQ",
            "RUNJRklFRBAAEgsKB1JVTk5JTkcQARIOCgpDQU5DRUxMSU5HEAISDQoJU1VD",
            "Q0VFREVEEAMSCgoGRkFJTEVEEAQSDQoJQ0FOQ0VMTEVEEAVC2gEKHmNvbS5n",
            "b29nbGUuY2xvdWQuZG9jdW1lbnRhaS52MUIWT3BlcmF0aW9uTWV0YWRhdGFQ",
            "cm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Nsb3VkL2RvY3VtZW50YWkvdjE7ZG9jdW1lbnRhaaoCGkdvb2dsZS5DbG91",
            "ZC5Eb2N1bWVudEFJLlYxygIaR29vZ2xlXENsb3VkXERvY3VtZW50QUlcVjHq",
            "Ah1Hb29nbGU6OkNsb3VkOjpEb2N1bWVudEFJOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata), global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Parser, new[]{ "State", "StateMessage", "CreateTime", "UpdateTime" }, null, new[]{ typeof(global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Types.State) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The common metadata for long running operations.
  /// </summary>
  public sealed partial class CommonOperationMetadata : pb::IMessage<CommonOperationMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CommonOperationMetadata> _parser = new pb::MessageParser<CommonOperationMetadata>(() => new CommonOperationMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CommonOperationMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DocumentAI.V1.OperationMetadataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonOperationMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonOperationMetadata(CommonOperationMetadata other) : this() {
      state_ = other.state_;
      stateMessage_ = other.stateMessage_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonOperationMetadata Clone() {
      return new CommonOperationMetadata(this);
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 1;
    private global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Types.State state_ = global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Types.State.Unspecified;
    /// <summary>
    /// The state of the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "state_message" field.</summary>
    public const int StateMessageFieldNumber = 2;
    private string stateMessage_ = "";
    /// <summary>
    /// A message providing more details about the current state of processing.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StateMessage {
      get { return stateMessage_; }
      set {
        stateMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// The creation time of the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// The last update time of the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CommonOperationMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CommonOperationMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (State != other.State) return false;
      if (StateMessage != other.StateMessage) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (State != global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (StateMessage.Length != 0) hash ^= StateMessage.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
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
      if (State != global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Types.State.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) State);
      }
      if (StateMessage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StateMessage);
      }
      if (createTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
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
      if (State != global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Types.State.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) State);
      }
      if (StateMessage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StateMessage);
      }
      if (createTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
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
      if (State != global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (StateMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StateMessage);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CommonOperationMetadata other) {
      if (other == null) {
        return;
      }
      if (other.State != global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.StateMessage.Length != 0) {
        StateMessage = other.StateMessage;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
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
            State = (global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Types.State) input.ReadEnum();
            break;
          }
          case 18: {
            StateMessage = input.ReadString();
            break;
          }
          case 26: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 34: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
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
            State = (global::Google.Cloud.DocumentAI.V1.CommonOperationMetadata.Types.State) input.ReadEnum();
            break;
          }
          case 18: {
            StateMessage = input.ReadString();
            break;
          }
          case 26: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 34: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CommonOperationMetadata message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// State of the longrunning operation.
      /// </summary>
      public enum State {
        /// <summary>
        /// Unspecified state.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Operation is still running.
        /// </summary>
        [pbr::OriginalName("RUNNING")] Running = 1,
        /// <summary>
        /// Operation is being cancelled.
        /// </summary>
        [pbr::OriginalName("CANCELLING")] Cancelling = 2,
        /// <summary>
        /// Operation succeeded.
        /// </summary>
        [pbr::OriginalName("SUCCEEDED")] Succeeded = 3,
        /// <summary>
        /// Operation failed.
        /// </summary>
        [pbr::OriginalName("FAILED")] Failed = 4,
        /// <summary>
        /// Operation is cancelled.
        /// </summary>
        [pbr::OriginalName("CANCELLED")] Cancelled = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
