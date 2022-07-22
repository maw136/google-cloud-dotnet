// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/entity_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/entity_type.proto</summary>
  public static partial class EntityTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/entity_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9lbnRpdHlfdHlwZS5wcm90",
            "bxIaZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEaH2dvb2dsZS9hcGkvZmll",
            "bGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8a",
            "OGdvb2dsZS9jbG91ZC9haXBsYXRmb3JtL3YxL2ZlYXR1cmVzdG9yZV9tb25p",
            "dG9yaW5nLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3Rv",
            "IpcECgpFbnRpdHlUeXBlEhEKBG5hbWUYASABKAlCA+BBBRIYCgtkZXNjcmlw",
            "dGlvbhgCIAEoCUID4EEBEjQKC2NyZWF0ZV90aW1lGAMgASgLMhouZ29vZ2xl",
            "LnByb3RvYnVmLlRpbWVzdGFtcEID4EEDEjQKC3VwZGF0ZV90aW1lGAQgASgL",
            "MhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEID4EEDEkcKBmxhYmVscxgG",
            "IAMoCzIyLmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxLkVudGl0eVR5cGUu",
            "TGFiZWxzRW50cnlCA+BBARIRCgRldGFnGAcgASgJQgPgQQESWAoRbW9uaXRv",
            "cmluZ19jb25maWcYCCABKAsyOC5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52",
            "MS5GZWF0dXJlc3RvcmVNb25pdG9yaW5nQ29uZmlnQgPgQQEaLQoLTGFiZWxz",
            "RW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ATqKAepBhgEK",
            "JGFpcGxhdGZvcm0uZ29vZ2xlYXBpcy5jb20vRW50aXR5VHlwZRJecHJvamVj",
            "dHMve3Byb2plY3R9L2xvY2F0aW9ucy97bG9jYXRpb259L2ZlYXR1cmVzdG9y",
            "ZXMve2ZlYXR1cmVzdG9yZX0vZW50aXR5VHlwZXMve2VudGl0eV90eXBlfULT",
            "AQoeY29tLmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxQg9FbnRpdHlUeXBl",
            "UHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9jbG91ZC9haXBsYXRmb3JtL3YxO2FpcGxhdGZvcm2qAhpHb29nbGUuQ2xv",
            "dWQuQUlQbGF0Zm9ybS5WMcoCGkdvb2dsZVxDbG91ZFxBSVBsYXRmb3JtXFYx",
            "6gIdR29vZ2xlOjpDbG91ZDo6QUlQbGF0Zm9ybTo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.FeaturestoreMonitoringReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.EntityType), global::Google.Cloud.AIPlatform.V1.EntityType.Parser, new[]{ "Name", "Description", "CreateTime", "UpdateTime", "Labels", "Etag", "MonitoringConfig" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An entity type is a type of object in a system that needs to be modeled and
  /// have stored information about. For example, driver is an entity type, and
  /// driver0 is an instance of an entity type driver.
  /// </summary>
  public sealed partial class EntityType : pb::IMessage<EntityType>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityType> _parser = new pb::MessageParser<EntityType>(() => new EntityType());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityType> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.EntityTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityType() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityType(EntityType other) : this() {
      name_ = other.name_;
      description_ = other.description_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      labels_ = other.labels_.Clone();
      etag_ = other.etag_;
      monitoringConfig_ = other.monitoringConfig_ != null ? other.monitoringConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityType Clone() {
      return new EntityType(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Immutable. Name of the EntityType.
    /// Format:
    /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
    ///
    /// The last part entity_type is assigned by the client. The entity_type can be
    /// up to 64 characters long and can consist only of ASCII Latin letters A-Z
    /// and a-z and underscore(_), and ASCII digits 0-9 starting with a letter. The
    /// value will be unique given a featurestore.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    /// <summary>
    /// Optional. Description of the EntityType.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this EntityType was created.
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
    /// Output only. Timestamp when this EntityType was most recently updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 6;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 50);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. The labels with user-defined metadata to organize your EntityTypes.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    ///
    /// See https://goo.gl/xmQnxf for more information on and examples of labels.
    /// No more than 64 user labels can be associated with one EntityType (System
    /// labels are excluded)."
    /// System reserved label keys are prefixed with "aiplatform.googleapis.com/"
    /// and are immutable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 7;
    private string etag_ = "";
    /// <summary>
    /// Optional. Used to perform a consistent read-modify-write updates. If not set, a blind
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

    /// <summary>Field number for the "monitoring_config" field.</summary>
    public const int MonitoringConfigFieldNumber = 8;
    private global::Google.Cloud.AIPlatform.V1.FeaturestoreMonitoringConfig monitoringConfig_;
    /// <summary>
    /// Optional. The default monitoring configuration for all Features with value type
    /// ([Feature.ValueType][google.cloud.aiplatform.v1.Feature.ValueType]) BOOL, STRING, DOUBLE or INT64 under this
    /// EntityType.
    ///
    /// If this is populated with
    /// [FeaturestoreMonitoringConfig.monitoring_interval] specified, snapshot
    /// analysis monitoring is enabled. Otherwise, snapshot analysis monitoring is
    /// disabled.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.FeaturestoreMonitoringConfig MonitoringConfig {
      get { return monitoringConfig_; }
      set {
        monitoringConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityType);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityType other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (Etag != other.Etag) return false;
      if (!object.Equals(MonitoringConfig, other.MonitoringConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      if (monitoringConfig_ != null) hash ^= MonitoringConfig.GetHashCode();
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
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (createTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Etag);
      }
      if (monitoringConfig_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MonitoringConfig);
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
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (createTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Etag);
      }
      if (monitoringConfig_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MonitoringConfig);
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
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      if (monitoringConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MonitoringConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityType other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
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
      labels_.Add(other.labels_);
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      if (other.monitoringConfig_ != null) {
        if (monitoringConfig_ == null) {
          MonitoringConfig = new global::Google.Cloud.AIPlatform.V1.FeaturestoreMonitoringConfig();
        }
        MonitoringConfig.MergeFrom(other.MonitoringConfig);
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
            Description = input.ReadString();
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
          case 50: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 58: {
            Etag = input.ReadString();
            break;
          }
          case 66: {
            if (monitoringConfig_ == null) {
              MonitoringConfig = new global::Google.Cloud.AIPlatform.V1.FeaturestoreMonitoringConfig();
            }
            input.ReadMessage(MonitoringConfig);
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
            Description = input.ReadString();
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
          case 50: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 58: {
            Etag = input.ReadString();
            break;
          }
          case 66: {
            if (monitoringConfig_ == null) {
              MonitoringConfig = new global::Google.Cloud.AIPlatform.V1.FeaturestoreMonitoringConfig();
            }
            input.ReadMessage(MonitoringConfig);
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
