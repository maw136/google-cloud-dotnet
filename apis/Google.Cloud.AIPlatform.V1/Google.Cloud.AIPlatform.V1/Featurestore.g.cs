// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/featurestore.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/featurestore.proto</summary>
  public static partial class FeaturestoreReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/featurestore.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeaturestoreReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9mZWF0dXJlc3RvcmUucHJv",
            "dG8SGmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxGh9nb29nbGUvYXBpL2Zp",
            "ZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3Rv",
            "GjBnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9lbmNyeXB0aW9uX3NwZWMu",
            "cHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8aHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i6AUKDEZlYXR1cmVzdG9yZRIRCgRu",
            "YW1lGAEgASgJQgPgQQMSNAoLY3JlYXRlX3RpbWUYAyABKAsyGi5nb29nbGUu",
            "cHJvdG9idWYuVGltZXN0YW1wQgPgQQMSNAoLdXBkYXRlX3RpbWUYBCABKAsy",
            "Gi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMSEQoEZXRhZxgFIAEo",
            "CUID4EEBEkkKBmxhYmVscxgGIAMoCzI0Lmdvb2dsZS5jbG91ZC5haXBsYXRm",
            "b3JtLnYxLkZlYXR1cmVzdG9yZS5MYWJlbHNFbnRyeUID4EEBEmAKFW9ubGlu",
            "ZV9zZXJ2aW5nX2NvbmZpZxgHIAEoCzI8Lmdvb2dsZS5jbG91ZC5haXBsYXRm",
            "b3JtLnYxLkZlYXR1cmVzdG9yZS5PbmxpbmVTZXJ2aW5nQ29uZmlnQgPgQQIS",
            "QgoFc3RhdGUYCCABKA4yLi5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5G",
            "ZWF0dXJlc3RvcmUuU3RhdGVCA+BBAxJICg9lbmNyeXB0aW9uX3NwZWMYCiAB",
            "KAsyKi5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5FbmNyeXB0aW9uU3Bl",
            "Y0ID4EEBGi8KE09ubGluZVNlcnZpbmdDb25maWcSGAoQZml4ZWRfbm9kZV9j",
            "b3VudBgCIAEoBRotCgtMYWJlbHNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFs",
            "dWUYAiABKAk6AjgBIjgKBVN0YXRlEhUKEVNUQVRFX1VOU1BFQ0lGSUVEEAAS",
            "CgoGU1RBQkxFEAESDAoIVVBEQVRJTkcQAjpx6kFuCiZhaXBsYXRmb3JtLmdv",
            "b2dsZWFwaXMuY29tL0ZlYXR1cmVzdG9yZRJEcHJvamVjdHMve3Byb2plY3R9",
            "L2xvY2F0aW9ucy97bG9jYXRpb259L2ZlYXR1cmVzdG9yZXMve2ZlYXR1cmVz",
            "dG9yZX1C1QEKHmNvbS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MUIRRmVh",
            "dHVyZXN0b3JlUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9jbG91ZC9haXBsYXRmb3JtL3YxO2FpcGxhdGZvcm2qAhpH",
            "b29nbGUuQ2xvdWQuQUlQbGF0Zm9ybS5WMcoCGkdvb2dsZVxDbG91ZFxBSVBs",
            "YXRmb3JtXFYx6gIdR29vZ2xlOjpDbG91ZDo6QUlQbGF0Zm9ybTo6VjFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.EncryptionSpecReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Featurestore), global::Google.Cloud.AIPlatform.V1.Featurestore.Parser, new[]{ "Name", "CreateTime", "UpdateTime", "Etag", "Labels", "OnlineServingConfig", "State", "EncryptionSpec" }, null, new[]{ typeof(global::Google.Cloud.AIPlatform.V1.Featurestore.Types.State) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Featurestore.Types.OnlineServingConfig), global::Google.Cloud.AIPlatform.V1.Featurestore.Types.OnlineServingConfig.Parser, new[]{ "FixedNodeCount" }, null, null, null, null),
            null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Vertex Feature Store provides a centralized repository for organizing,
  /// storing, and serving ML features. The Featurestore is a top-level container
  /// for your features and their values.
  /// </summary>
  public sealed partial class Featurestore : pb::IMessage<Featurestore>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Featurestore> _parser = new pb::MessageParser<Featurestore>(() => new Featurestore());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Featurestore> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.FeaturestoreReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Featurestore() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Featurestore(Featurestore other) : this() {
      name_ = other.name_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      etag_ = other.etag_;
      labels_ = other.labels_.Clone();
      onlineServingConfig_ = other.onlineServingConfig_ != null ? other.onlineServingConfig_.Clone() : null;
      state_ = other.state_;
      encryptionSpec_ = other.encryptionSpec_ != null ? other.encryptionSpec_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Featurestore Clone() {
      return new Featurestore(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Name of the Featurestore. Format:
    /// `projects/{project}/locations/{location}/featurestores/{featurestore}`
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
    /// Output only. Timestamp when this Featurestore was created.
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
    /// Output only. Timestamp when this Featurestore was last updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 5;
    private string etag_ = "";
    /// <summary>
    /// Optional. Used to perform consistent read-modify-write updates. If not set, a blind
    /// "overwrite" update happens.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 6;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 50);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. The labels with user-defined metadata to organize your Featurestore.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    ///
    /// See https://goo.gl/xmQnxf for more information on and examples of labels.
    /// No more than 64 user labels can be associated with one Featurestore(System
    /// labels are excluded)."
    /// System reserved label keys are prefixed with "aiplatform.googleapis.com/"
    /// and are immutable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "online_serving_config" field.</summary>
    public const int OnlineServingConfigFieldNumber = 7;
    private global::Google.Cloud.AIPlatform.V1.Featurestore.Types.OnlineServingConfig onlineServingConfig_;
    /// <summary>
    /// Required. Config for online serving resources.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.Featurestore.Types.OnlineServingConfig OnlineServingConfig {
      get { return onlineServingConfig_; }
      set {
        onlineServingConfig_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 8;
    private global::Google.Cloud.AIPlatform.V1.Featurestore.Types.State state_ = global::Google.Cloud.AIPlatform.V1.Featurestore.Types.State.Unspecified;
    /// <summary>
    /// Output only. State of the featurestore.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.Featurestore.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "encryption_spec" field.</summary>
    public const int EncryptionSpecFieldNumber = 10;
    private global::Google.Cloud.AIPlatform.V1.EncryptionSpec encryptionSpec_;
    /// <summary>
    /// Optional. Customer-managed encryption key spec for data storage. If set, both of the
    /// online and offline data storage will be secured by this key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.EncryptionSpec EncryptionSpec {
      get { return encryptionSpec_; }
      set {
        encryptionSpec_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Featurestore);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Featurestore other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (Etag != other.Etag) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (!object.Equals(OnlineServingConfig, other.OnlineServingConfig)) return false;
      if (State != other.State) return false;
      if (!object.Equals(EncryptionSpec, other.EncryptionSpec)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (onlineServingConfig_ != null) hash ^= OnlineServingConfig.GetHashCode();
      if (State != global::Google.Cloud.AIPlatform.V1.Featurestore.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (encryptionSpec_ != null) hash ^= EncryptionSpec.GetHashCode();
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
      if (Etag.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Etag);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (onlineServingConfig_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(OnlineServingConfig);
      }
      if (State != global::Google.Cloud.AIPlatform.V1.Featurestore.Types.State.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) State);
      }
      if (encryptionSpec_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(EncryptionSpec);
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
      if (Etag.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Etag);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (onlineServingConfig_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(OnlineServingConfig);
      }
      if (State != global::Google.Cloud.AIPlatform.V1.Featurestore.Types.State.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) State);
      }
      if (encryptionSpec_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(EncryptionSpec);
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
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (onlineServingConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OnlineServingConfig);
      }
      if (State != global::Google.Cloud.AIPlatform.V1.Featurestore.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (encryptionSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EncryptionSpec);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Featurestore other) {
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
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      labels_.Add(other.labels_);
      if (other.onlineServingConfig_ != null) {
        if (onlineServingConfig_ == null) {
          OnlineServingConfig = new global::Google.Cloud.AIPlatform.V1.Featurestore.Types.OnlineServingConfig();
        }
        OnlineServingConfig.MergeFrom(other.OnlineServingConfig);
      }
      if (other.State != global::Google.Cloud.AIPlatform.V1.Featurestore.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.encryptionSpec_ != null) {
        if (encryptionSpec_ == null) {
          EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
        }
        EncryptionSpec.MergeFrom(other.EncryptionSpec);
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
            Etag = input.ReadString();
            break;
          }
          case 50: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 58: {
            if (onlineServingConfig_ == null) {
              OnlineServingConfig = new global::Google.Cloud.AIPlatform.V1.Featurestore.Types.OnlineServingConfig();
            }
            input.ReadMessage(OnlineServingConfig);
            break;
          }
          case 64: {
            State = (global::Google.Cloud.AIPlatform.V1.Featurestore.Types.State) input.ReadEnum();
            break;
          }
          case 82: {
            if (encryptionSpec_ == null) {
              EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
            }
            input.ReadMessage(EncryptionSpec);
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
            Etag = input.ReadString();
            break;
          }
          case 50: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 58: {
            if (onlineServingConfig_ == null) {
              OnlineServingConfig = new global::Google.Cloud.AIPlatform.V1.Featurestore.Types.OnlineServingConfig();
            }
            input.ReadMessage(OnlineServingConfig);
            break;
          }
          case 64: {
            State = (global::Google.Cloud.AIPlatform.V1.Featurestore.Types.State) input.ReadEnum();
            break;
          }
          case 82: {
            if (encryptionSpec_ == null) {
              EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
            }
            input.ReadMessage(EncryptionSpec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Featurestore message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible states a Featurestore can have.
      /// </summary>
      public enum State {
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// State when the Featurestore configuration is not being updated and the
        /// fields reflect the current configuration of the Featurestore. The
        /// Featurestore is usable in this state.
        /// </summary>
        [pbr::OriginalName("STABLE")] Stable = 1,
        /// <summary>
        /// State when the Featurestore configuration is being updated and the fields
        /// reflect the updated configuration of the Featurestore, not the current
        /// one. For example, `online_serving_config.fixed_node_count` can take
        /// minutes to update. While the update is in progress, the Featurestore
        /// will be in the UPDATING state and the value of `fixed_node_count` will be
        /// the updated value. Until the update completes, the actual number of nodes
        /// can still be the original value of `fixed_node_count`. The Featurestore
        /// is still usable in this state.
        /// </summary>
        [pbr::OriginalName("UPDATING")] Updating = 2,
      }

      /// <summary>
      /// OnlineServingConfig specifies the details for provisioning online serving
      /// resources.
      /// </summary>
      public sealed partial class OnlineServingConfig : pb::IMessage<OnlineServingConfig>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<OnlineServingConfig> _parser = new pb::MessageParser<OnlineServingConfig>(() => new OnlineServingConfig());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<OnlineServingConfig> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.AIPlatform.V1.Featurestore.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public OnlineServingConfig() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public OnlineServingConfig(OnlineServingConfig other) : this() {
          fixedNodeCount_ = other.fixedNodeCount_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public OnlineServingConfig Clone() {
          return new OnlineServingConfig(this);
        }

        /// <summary>Field number for the "fixed_node_count" field.</summary>
        public const int FixedNodeCountFieldNumber = 2;
        private int fixedNodeCount_;
        /// <summary>
        /// The number of nodes for each cluster. The number of nodes will not
        /// scale automatically but can be scaled manually by providing different
        /// values when updating.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int FixedNodeCount {
          get { return fixedNodeCount_; }
          set {
            fixedNodeCount_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as OnlineServingConfig);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(OnlineServingConfig other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (FixedNodeCount != other.FixedNodeCount) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (FixedNodeCount != 0) hash ^= FixedNodeCount.GetHashCode();
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
          if (FixedNodeCount != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(FixedNodeCount);
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
          if (FixedNodeCount != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(FixedNodeCount);
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
          if (FixedNodeCount != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(FixedNodeCount);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(OnlineServingConfig other) {
          if (other == null) {
            return;
          }
          if (other.FixedNodeCount != 0) {
            FixedNodeCount = other.FixedNodeCount;
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
              case 16: {
                FixedNodeCount = input.ReadInt32();
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
              case 16: {
                FixedNodeCount = input.ReadInt32();
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
