// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/documentai/v1beta3/processor.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DocumentAI.V1Beta3 {

  /// <summary>Holder for reflection information generated from google/cloud/documentai/v1beta3/processor.proto</summary>
  public static partial class ProcessorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/documentai/v1beta3/processor.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProcessorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvZG9jdW1lbnRhaS92MWJldGEzL3Byb2Nlc3Nvci5w",
            "cm90bxIfZ29vZ2xlLmNsb3VkLmRvY3VtZW50YWkudjFiZXRhMxofZ29vZ2xl",
            "L2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJj",
            "ZS5wcm90bxoxZ29vZ2xlL2Nsb3VkL2RvY3VtZW50YWkvdjFiZXRhMy9kb2N1",
            "bWVudF9pby5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90",
            "bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKBBAoJUHJvY2Vzc29y",
            "EhQKBG5hbWUYASABKAlCBuBBBeBBAxIMCgR0eXBlGAIgASgJEhQKDGRpc3Bs",
            "YXlfbmFtZRgDIAEoCRJECgVzdGF0ZRgEIAEoDjIwLmdvb2dsZS5jbG91ZC5k",
            "b2N1bWVudGFpLnYxYmV0YTMuUHJvY2Vzc29yLlN0YXRlQgPgQQMSIQoZZGVm",
            "YXVsdF9wcm9jZXNzb3JfdmVyc2lvbhgJIAEoCRIgChBwcm9jZXNzX2VuZHBv",
            "aW50GAYgASgJQgbgQQPgQQUSLwoLY3JlYXRlX3RpbWUYByABKAsyGi5nb29n",
            "bGUucHJvdG9idWYuVGltZXN0YW1wEhQKDGttc19rZXlfbmFtZRgIIAEoCSJ+",
            "CgVTdGF0ZRIVChFTVEFURV9VTlNQRUNJRklFRBAAEgsKB0VOQUJMRUQQARIM",
            "CghESVNBQkxFRBACEgwKCEVOQUJMSU5HEAMSDQoJRElTQUJMSU5HEAQSDAoI",
            "Q1JFQVRJTkcQBRIKCgZGQUlMRUQQBhIMCghERUxFVElORxAHOmjqQWUKI2Rv",
            "Y3VtZW50YWkuZ29vZ2xlYXBpcy5jb20vUHJvY2Vzc29yEj5wcm9qZWN0cy97",
            "cHJvamVjdH0vbG9jYXRpb25zL3tsb2NhdGlvbn0vcHJvY2Vzc29ycy97cHJv",
            "Y2Vzc29yfULwAQojY29tLmdvb2dsZS5jbG91ZC5kb2N1bWVudGFpLnYxYmV0",
            "YTNCE0RvY3VtZW50QWlQcm9jZXNzb3JQAVpJZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9kb2N1bWVudGFpL3YxYmV0YTM7",
            "ZG9jdW1lbnRhaaoCH0dvb2dsZS5DbG91ZC5Eb2N1bWVudEFJLlYxQmV0YTPK",
            "Ah9Hb29nbGVcQ2xvdWRcRG9jdW1lbnRBSVxWMWJldGEz6gIiR29vZ2xlOjpD",
            "bG91ZDo6RG9jdW1lbnRBSTo6VjFiZXRhM2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.DocumentAI.V1Beta3.DocumentIoReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DocumentAI.V1Beta3.Processor), global::Google.Cloud.DocumentAI.V1Beta3.Processor.Parser, new[]{ "Name", "Type", "DisplayName", "State", "DefaultProcessorVersion", "ProcessEndpoint", "CreateTime", "KmsKeyName" }, null, new[]{ typeof(global::Google.Cloud.DocumentAI.V1Beta3.Processor.Types.State) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The first-class citizen for DocumentAI. Each processor defines how to extract
  /// structural information from a document.
  /// </summary>
  public sealed partial class Processor : pb::IMessage<Processor>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Processor> _parser = new pb::MessageParser<Processor>(() => new Processor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Processor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DocumentAI.V1Beta3.ProcessorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Processor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Processor(Processor other) : this() {
      name_ = other.name_;
      type_ = other.type_;
      displayName_ = other.displayName_;
      state_ = other.state_;
      defaultProcessorVersion_ = other.defaultProcessorVersion_;
      processEndpoint_ = other.processEndpoint_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      kmsKeyName_ = other.kmsKeyName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Processor Clone() {
      return new Processor(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Immutable. The resource name of the processor.
    /// Format: projects/{project}/locations/{location}/processors/{processor}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private string type_ = "";
    /// <summary>
    /// The processor type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 3;
    private string displayName_ = "";
    /// <summary>
    /// The display name of the processor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private global::Google.Cloud.DocumentAI.V1Beta3.Processor.Types.State state_ = global::Google.Cloud.DocumentAI.V1Beta3.Processor.Types.State.Unspecified;
    /// <summary>
    /// Output only. The state of the processor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DocumentAI.V1Beta3.Processor.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "default_processor_version" field.</summary>
    public const int DefaultProcessorVersionFieldNumber = 9;
    private string defaultProcessorVersion_ = "";
    /// <summary>
    /// The default processor version.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DefaultProcessorVersion {
      get { return defaultProcessorVersion_; }
      set {
        defaultProcessorVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "process_endpoint" field.</summary>
    public const int ProcessEndpointFieldNumber = 6;
    private string processEndpoint_ = "";
    /// <summary>
    /// Output only. Immutable. The http endpoint that can be called to invoke processing.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProcessEndpoint {
      get { return processEndpoint_; }
      set {
        processEndpoint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// The time the processor was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "kms_key_name" field.</summary>
    public const int KmsKeyNameFieldNumber = 8;
    private string kmsKeyName_ = "";
    /// <summary>
    /// The KMS key used for encryption/decryption in CMEK scenarios.
    /// See https://cloud.google.com/security-key-management.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string KmsKeyName {
      get { return kmsKeyName_; }
      set {
        kmsKeyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Processor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Processor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      if (DisplayName != other.DisplayName) return false;
      if (State != other.State) return false;
      if (DefaultProcessorVersion != other.DefaultProcessorVersion) return false;
      if (ProcessEndpoint != other.ProcessEndpoint) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (KmsKeyName != other.KmsKeyName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (State != global::Google.Cloud.DocumentAI.V1Beta3.Processor.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (DefaultProcessorVersion.Length != 0) hash ^= DefaultProcessorVersion.GetHashCode();
      if (ProcessEndpoint.Length != 0) hash ^= ProcessEndpoint.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (KmsKeyName.Length != 0) hash ^= KmsKeyName.GetHashCode();
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
      if (Type.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
      }
      if (State != global::Google.Cloud.DocumentAI.V1Beta3.Processor.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      if (ProcessEndpoint.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ProcessEndpoint);
      }
      if (createTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CreateTime);
      }
      if (KmsKeyName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(KmsKeyName);
      }
      if (DefaultProcessorVersion.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(DefaultProcessorVersion);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
      }
      if (State != global::Google.Cloud.DocumentAI.V1Beta3.Processor.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      if (ProcessEndpoint.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ProcessEndpoint);
      }
      if (createTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CreateTime);
      }
      if (KmsKeyName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(KmsKeyName);
      }
      if (DefaultProcessorVersion.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(DefaultProcessorVersion);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (State != global::Google.Cloud.DocumentAI.V1Beta3.Processor.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (DefaultProcessorVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DefaultProcessorVersion);
      }
      if (ProcessEndpoint.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProcessEndpoint);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (KmsKeyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KmsKeyName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Processor other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.State != global::Google.Cloud.DocumentAI.V1Beta3.Processor.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.DefaultProcessorVersion.Length != 0) {
        DefaultProcessorVersion = other.DefaultProcessorVersion;
      }
      if (other.ProcessEndpoint.Length != 0) {
        ProcessEndpoint = other.ProcessEndpoint;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.KmsKeyName.Length != 0) {
        KmsKeyName = other.KmsKeyName;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Type = input.ReadString();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
            break;
          }
          case 32: {
            State = (global::Google.Cloud.DocumentAI.V1Beta3.Processor.Types.State) input.ReadEnum();
            break;
          }
          case 50: {
            ProcessEndpoint = input.ReadString();
            break;
          }
          case 58: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 66: {
            KmsKeyName = input.ReadString();
            break;
          }
          case 74: {
            DefaultProcessorVersion = input.ReadString();
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
            Type = input.ReadString();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
            break;
          }
          case 32: {
            State = (global::Google.Cloud.DocumentAI.V1Beta3.Processor.Types.State) input.ReadEnum();
            break;
          }
          case 50: {
            ProcessEndpoint = input.ReadString();
            break;
          }
          case 58: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 66: {
            KmsKeyName = input.ReadString();
            break;
          }
          case 74: {
            DefaultProcessorVersion = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Processor message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The possible states of the processor.
      /// </summary>
      public enum State {
        /// <summary>
        /// The processor is in an unspecified state.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The processor is enabled.
        /// </summary>
        [pbr::OriginalName("ENABLED")] Enabled = 1,
        /// <summary>
        /// The processor is disabled.
        /// </summary>
        [pbr::OriginalName("DISABLED")] Disabled = 2,
        /// <summary>
        /// The processor is being enabled, will become ENABLED if successful.
        /// </summary>
        [pbr::OriginalName("ENABLING")] Enabling = 3,
        /// <summary>
        /// The processor is being disabled, will become DISABLED if successful.
        /// </summary>
        [pbr::OriginalName("DISABLING")] Disabling = 4,
        /// <summary>
        /// The processor is being created.
        /// </summary>
        [pbr::OriginalName("CREATING")] Creating = 5,
        /// <summary>
        /// The processor failed during creation.
        /// </summary>
        [pbr::OriginalName("FAILED")] Failed = 6,
        /// <summary>
        /// The processor is being deleted, will be removed if successful.
        /// </summary>
        [pbr::OriginalName("DELETING")] Deleting = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
