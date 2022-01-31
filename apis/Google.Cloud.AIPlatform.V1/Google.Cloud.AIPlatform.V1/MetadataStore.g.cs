// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/metadata_store.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/metadata_store.proto</summary>
  public static partial class MetadataStoreReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/metadata_store.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetadataStoreReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9tZXRhZGF0YV9zdG9yZS5w",
            "cm90bxIaZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEaHGdvb2dsZS9hcGkv",
            "YW5ub3RhdGlvbnMucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3Iu",
            "cHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aMGdvb2dsZS9jbG91",
            "ZC9haXBsYXRmb3JtL3YxL2VuY3J5cHRpb25fc3BlYy5wcm90bxofZ29vZ2xl",
            "L3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byLnAwoNTWV0YWRhdGFTdG9yZRIR",
            "CgRuYW1lGAEgASgJQgPgQQMSNAoLY3JlYXRlX3RpbWUYAyABKAsyGi5nb29n",
            "bGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMSNAoLdXBkYXRlX3RpbWUYBCAB",
            "KAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMSQwoPZW5jcnlw",
            "dGlvbl9zcGVjGAUgASgLMiouZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEu",
            "RW5jcnlwdGlvblNwZWMSEwoLZGVzY3JpcHRpb24YBiABKAkSUAoFc3RhdGUY",
            "ByABKAsyPC5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5NZXRhZGF0YVN0",
            "b3JlLk1ldGFkYXRhU3RvcmVTdGF0ZUID4EEDGjQKEk1ldGFkYXRhU3RvcmVT",
            "dGF0ZRIeChZkaXNrX3V0aWxpemF0aW9uX2J5dGVzGAEgASgDOnXqQXIKJ2Fp",
            "cGxhdGZvcm0uZ29vZ2xlYXBpcy5jb20vTWV0YWRhdGFTdG9yZRJHcHJvamVj",
            "dHMve3Byb2plY3R9L2xvY2F0aW9ucy97bG9jYXRpb259L21ldGFkYXRhU3Rv",
            "cmVzL3ttZXRhZGF0YV9zdG9yZX1C0QEKHmNvbS5nb29nbGUuY2xvdWQuYWlw",
            "bGF0Zm9ybS52MUINTWV0YWRhdGFQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL2FpcGxhdGZvcm0vdjE7YWlw",
            "bGF0Zm9ybaoCGkdvb2dsZS5DbG91ZC5BSVBsYXRmb3JtLlYxygIaR29vZ2xl",
            "XENsb3VkXEFJUGxhdGZvcm1cVjHqAh1Hb29nbGU6OkNsb3VkOjpBSVBsYXRm",
            "b3JtOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.EncryptionSpecReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.MetadataStore), global::Google.Cloud.AIPlatform.V1.MetadataStore.Parser, new[]{ "Name", "CreateTime", "UpdateTime", "EncryptionSpec", "Description", "State" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.MetadataStore.Types.MetadataStoreState), global::Google.Cloud.AIPlatform.V1.MetadataStore.Types.MetadataStoreState.Parser, new[]{ "DiskUtilizationBytes" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Instance of a metadata store. Contains a set of metadata that can be
  /// queried.
  /// </summary>
  public sealed partial class MetadataStore : pb::IMessage<MetadataStore>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MetadataStore> _parser = new pb::MessageParser<MetadataStore>(() => new MetadataStore());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MetadataStore> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.MetadataStoreReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetadataStore() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetadataStore(MetadataStore other) : this() {
      name_ = other.name_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      encryptionSpec_ = other.encryptionSpec_ != null ? other.encryptionSpec_.Clone() : null;
      description_ = other.description_;
      state_ = other.state_ != null ? other.state_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetadataStore Clone() {
      return new MetadataStore(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. The resource name of the MetadataStore instance.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this MetadataStore was created.
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
    /// Output only. Timestamp when this MetadataStore was last updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "encryption_spec" field.</summary>
    public const int EncryptionSpecFieldNumber = 5;
    private global::Google.Cloud.AIPlatform.V1.EncryptionSpec encryptionSpec_;
    /// <summary>
    /// Customer-managed encryption key spec for a Metadata Store. If set, this
    /// Metadata Store and all sub-resources of this Metadata Store are secured
    /// using this key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.EncryptionSpec EncryptionSpec {
      get { return encryptionSpec_; }
      set {
        encryptionSpec_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 6;
    private string description_ = "";
    /// <summary>
    /// Description of the MetadataStore.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 7;
    private global::Google.Cloud.AIPlatform.V1.MetadataStore.Types.MetadataStoreState state_;
    /// <summary>
    /// Output only. State information of the MetadataStore.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.MetadataStore.Types.MetadataStoreState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MetadataStore);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MetadataStore other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!object.Equals(EncryptionSpec, other.EncryptionSpec)) return false;
      if (Description != other.Description) return false;
      if (!object.Equals(State, other.State)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (encryptionSpec_ != null) hash ^= EncryptionSpec.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (state_ != null) hash ^= State.GetHashCode();
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
      if (createTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
      }
      if (encryptionSpec_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EncryptionSpec);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Description);
      }
      if (state_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(State);
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
      if (createTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
      }
      if (encryptionSpec_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EncryptionSpec);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Description);
      }
      if (state_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(State);
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
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (encryptionSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EncryptionSpec);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (state_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MetadataStore other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
      if (other.encryptionSpec_ != null) {
        if (encryptionSpec_ == null) {
          EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
        }
        EncryptionSpec.MergeFrom(other.EncryptionSpec);
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.state_ != null) {
        if (state_ == null) {
          State = new global::Google.Cloud.AIPlatform.V1.MetadataStore.Types.MetadataStoreState();
        }
        State.MergeFrom(other.State);
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
          case 42: {
            if (encryptionSpec_ == null) {
              EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
            }
            input.ReadMessage(EncryptionSpec);
            break;
          }
          case 50: {
            Description = input.ReadString();
            break;
          }
          case 58: {
            if (state_ == null) {
              State = new global::Google.Cloud.AIPlatform.V1.MetadataStore.Types.MetadataStoreState();
            }
            input.ReadMessage(State);
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
          case 42: {
            if (encryptionSpec_ == null) {
              EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
            }
            input.ReadMessage(EncryptionSpec);
            break;
          }
          case 50: {
            Description = input.ReadString();
            break;
          }
          case 58: {
            if (state_ == null) {
              State = new global::Google.Cloud.AIPlatform.V1.MetadataStore.Types.MetadataStoreState();
            }
            input.ReadMessage(State);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the MetadataStore message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Represents state information for a MetadataStore.
      /// </summary>
      public sealed partial class MetadataStoreState : pb::IMessage<MetadataStoreState>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<MetadataStoreState> _parser = new pb::MessageParser<MetadataStoreState>(() => new MetadataStoreState());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<MetadataStoreState> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.AIPlatform.V1.MetadataStore.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public MetadataStoreState() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public MetadataStoreState(MetadataStoreState other) : this() {
          diskUtilizationBytes_ = other.diskUtilizationBytes_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public MetadataStoreState Clone() {
          return new MetadataStoreState(this);
        }

        /// <summary>Field number for the "disk_utilization_bytes" field.</summary>
        public const int DiskUtilizationBytesFieldNumber = 1;
        private long diskUtilizationBytes_;
        /// <summary>
        /// The disk utilization of the MetadataStore in bytes.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long DiskUtilizationBytes {
          get { return diskUtilizationBytes_; }
          set {
            diskUtilizationBytes_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as MetadataStoreState);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(MetadataStoreState other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (DiskUtilizationBytes != other.DiskUtilizationBytes) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (DiskUtilizationBytes != 0L) hash ^= DiskUtilizationBytes.GetHashCode();
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
          if (DiskUtilizationBytes != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(DiskUtilizationBytes);
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
          if (DiskUtilizationBytes != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(DiskUtilizationBytes);
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
          if (DiskUtilizationBytes != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(DiskUtilizationBytes);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(MetadataStoreState other) {
          if (other == null) {
            return;
          }
          if (other.DiskUtilizationBytes != 0L) {
            DiskUtilizationBytes = other.DiskUtilizationBytes;
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
                DiskUtilizationBytes = input.ReadInt64();
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
                DiskUtilizationBytes = input.ReadInt64();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
