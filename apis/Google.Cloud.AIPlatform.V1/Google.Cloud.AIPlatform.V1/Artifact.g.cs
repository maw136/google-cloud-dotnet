// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/artifact.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/artifact.proto</summary>
  public static partial class ArtifactReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/artifact.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArtifactReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9hcnRpZmFjdC5wcm90bxIa",
            "Z29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEaHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8a",
            "GWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aJmdvb2dsZS9jbG91ZC9haXBs",
            "YXRmb3JtL3YxL3ZhbHVlLnByb3RvGhxnb29nbGUvcHJvdG9idWYvc3RydWN0",
            "LnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIpQFCghB",
            "cnRpZmFjdBIRCgRuYW1lGAEgASgJQgPgQQMSFAoMZGlzcGxheV9uYW1lGAIg",
            "ASgJEgsKA3VyaRgGIAEoCRIMCgRldGFnGAkgASgJEkAKBmxhYmVscxgKIAMo",
            "CzIwLmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxLkFydGlmYWN0LkxhYmVs",
            "c0VudHJ5EjQKC2NyZWF0ZV90aW1lGAsgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcEID4EEDEjQKC3VwZGF0ZV90aW1lGAwgASgLMhouZ29vZ2xl",
            "LnByb3RvYnVmLlRpbWVzdGFtcEID4EEDEjkKBXN0YXRlGA0gASgOMiouZ29v",
            "Z2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuQXJ0aWZhY3QuU3RhdGUSFAoMc2No",
            "ZW1hX3RpdGxlGA4gASgJEhYKDnNjaGVtYV92ZXJzaW9uGA8gASgJEikKCG1l",
            "dGFkYXRhGBAgASgLMhcuZ29vZ2xlLnByb3RvYnVmLlN0cnVjdBITCgtkZXNj",
            "cmlwdGlvbhgRIAEoCRotCgtMYWJlbHNFbnRyeRILCgNrZXkYASABKAkSDQoF",
            "dmFsdWUYAiABKAk6AjgBIjUKBVN0YXRlEhUKEVNUQVRFX1VOU1BFQ0lGSUVE",
            "EAASCwoHUEVORElORxABEggKBExJVkUQAjqGAepBggEKImFpcGxhdGZvcm0u",
            "Z29vZ2xlYXBpcy5jb20vQXJ0aWZhY3QSXHByb2plY3RzL3twcm9qZWN0fS9s",
            "b2NhdGlvbnMve2xvY2F0aW9ufS9tZXRhZGF0YVN0b3Jlcy97bWV0YWRhdGFf",
            "c3RvcmV9L2FydGlmYWN0cy97YXJ0aWZhY3R9QtEBCh5jb20uZ29vZ2xlLmNs",
            "b3VkLmFpcGxhdGZvcm0udjFCDUFydGlmYWN0UHJvdG9QAVpEZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9haXBsYXRmb3Jt",
            "L3YxO2FpcGxhdGZvcm2qAhpHb29nbGUuQ2xvdWQuQUlQbGF0Zm9ybS5WMcoC",
            "Gkdvb2dsZVxDbG91ZFxBSVBsYXRmb3JtXFYx6gIdR29vZ2xlOjpDbG91ZDo6",
            "QUlQbGF0Zm9ybTo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.ValueReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Artifact), global::Google.Cloud.AIPlatform.V1.Artifact.Parser, new[]{ "Name", "DisplayName", "Uri", "Etag", "Labels", "CreateTime", "UpdateTime", "State", "SchemaTitle", "SchemaVersion", "Metadata", "Description" }, null, new[]{ typeof(global::Google.Cloud.AIPlatform.V1.Artifact.Types.State) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Instance of a general artifact.
  /// </summary>
  public sealed partial class Artifact : pb::IMessage<Artifact>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Artifact> _parser = new pb::MessageParser<Artifact>(() => new Artifact());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Artifact> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.ArtifactReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Artifact() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Artifact(Artifact other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      uri_ = other.uri_;
      etag_ = other.etag_;
      labels_ = other.labels_.Clone();
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      state_ = other.state_;
      schemaTitle_ = other.schemaTitle_;
      schemaVersion_ = other.schemaVersion_;
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Artifact Clone() {
      return new Artifact(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. The resource name of the Artifact.
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
    /// User provided display name of the Artifact.
    /// May be up to 128 Unicode characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uri" field.</summary>
    public const int UriFieldNumber = 6;
    private string uri_ = "";
    /// <summary>
    /// The uniform resource identifier of the artifact file.
    /// May be empty if there is no actual artifact file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Uri {
      get { return uri_; }
      set {
        uri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 9;
    private string etag_ = "";
    /// <summary>
    /// An eTag used to perform consistent read-modify-write updates. If not set, a
    /// blind "overwrite" update happens.
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
    public const int LabelsFieldNumber = 10;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 82);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// The labels with user-defined metadata to organize your Artifacts.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    /// No more than 64 user labels can be associated with one Artifact (System
    /// labels are excluded).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 11;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this Artifact was created.
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
    public const int UpdateTimeFieldNumber = 12;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Timestamp when this Artifact was last updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 13;
    private global::Google.Cloud.AIPlatform.V1.Artifact.Types.State state_ = global::Google.Cloud.AIPlatform.V1.Artifact.Types.State.Unspecified;
    /// <summary>
    /// The state of this Artifact. This is a property of the Artifact, and does
    /// not imply or capture any ongoing process. This property is managed by
    /// clients (such as Vertex AI Pipelines), and the system does not prescribe
    /// or check the validity of state transitions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.Artifact.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "schema_title" field.</summary>
    public const int SchemaTitleFieldNumber = 14;
    private string schemaTitle_ = "";
    /// <summary>
    /// The title of the schema describing the metadata.
    ///
    /// Schema title and version is expected to be registered in earlier Create
    /// Schema calls. And both are used together as unique identifiers to identify
    /// schemas within the local metadata store.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SchemaTitle {
      get { return schemaTitle_; }
      set {
        schemaTitle_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "schema_version" field.</summary>
    public const int SchemaVersionFieldNumber = 15;
    private string schemaVersion_ = "";
    /// <summary>
    /// The version of the schema in schema_name to use.
    ///
    /// Schema title and version is expected to be registered in earlier Create
    /// Schema calls. And both are used together as unique identifiers to identify
    /// schemas within the local metadata store.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SchemaVersion {
      get { return schemaVersion_; }
      set {
        schemaVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 16;
    private global::Google.Protobuf.WellKnownTypes.Struct metadata_;
    /// <summary>
    /// Properties of the Artifact.
    /// The size of this field should not exceed 200KB.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Struct Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 17;
    private string description_ = "";
    /// <summary>
    /// Description of the Artifact
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Artifact);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Artifact other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Uri != other.Uri) return false;
      if (Etag != other.Etag) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (State != other.State) return false;
      if (SchemaTitle != other.SchemaTitle) return false;
      if (SchemaVersion != other.SchemaVersion) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Uri.Length != 0) hash ^= Uri.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (State != global::Google.Cloud.AIPlatform.V1.Artifact.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (SchemaTitle.Length != 0) hash ^= SchemaTitle.GetHashCode();
      if (SchemaVersion.Length != 0) hash ^= SchemaVersion.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
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
      if (Uri.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Uri);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Etag);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (createTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(UpdateTime);
      }
      if (State != global::Google.Cloud.AIPlatform.V1.Artifact.Types.State.Unspecified) {
        output.WriteRawTag(104);
        output.WriteEnum((int) State);
      }
      if (SchemaTitle.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(SchemaTitle);
      }
      if (SchemaVersion.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(SchemaVersion);
      }
      if (metadata_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(Metadata);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(138, 1);
        output.WriteString(Description);
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Uri.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Uri);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Etag);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (createTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(UpdateTime);
      }
      if (State != global::Google.Cloud.AIPlatform.V1.Artifact.Types.State.Unspecified) {
        output.WriteRawTag(104);
        output.WriteEnum((int) State);
      }
      if (SchemaTitle.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(SchemaTitle);
      }
      if (SchemaVersion.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(SchemaVersion);
      }
      if (metadata_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(Metadata);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(138, 1);
        output.WriteString(Description);
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
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Uri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
      }
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (State != global::Google.Cloud.AIPlatform.V1.Artifact.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (SchemaTitle.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SchemaTitle);
      }
      if (SchemaVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SchemaVersion);
      }
      if (metadata_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      if (Description.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Artifact other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Uri.Length != 0) {
        Uri = other.Uri;
      }
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      labels_.Add(other.labels_);
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
      if (other.State != global::Google.Cloud.AIPlatform.V1.Artifact.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.SchemaTitle.Length != 0) {
        SchemaTitle = other.SchemaTitle;
      }
      if (other.SchemaVersion.Length != 0) {
        SchemaVersion = other.SchemaVersion;
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          Metadata = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
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
            DisplayName = input.ReadString();
            break;
          }
          case 50: {
            Uri = input.ReadString();
            break;
          }
          case 74: {
            Etag = input.ReadString();
            break;
          }
          case 82: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 90: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 98: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 104: {
            State = (global::Google.Cloud.AIPlatform.V1.Artifact.Types.State) input.ReadEnum();
            break;
          }
          case 114: {
            SchemaTitle = input.ReadString();
            break;
          }
          case 122: {
            SchemaVersion = input.ReadString();
            break;
          }
          case 130: {
            if (metadata_ == null) {
              Metadata = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 138: {
            Description = input.ReadString();
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
          case 50: {
            Uri = input.ReadString();
            break;
          }
          case 74: {
            Etag = input.ReadString();
            break;
          }
          case 82: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 90: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 98: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 104: {
            State = (global::Google.Cloud.AIPlatform.V1.Artifact.Types.State) input.ReadEnum();
            break;
          }
          case 114: {
            SchemaTitle = input.ReadString();
            break;
          }
          case 122: {
            SchemaVersion = input.ReadString();
            break;
          }
          case 130: {
            if (metadata_ == null) {
              Metadata = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 138: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Artifact message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Describes the state of the Artifact.
      /// </summary>
      public enum State {
        /// <summary>
        /// Unspecified state for the Artifact.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// A state used by systems like Vertex AI Pipelines to indicate that the
        /// underlying data item represented by this Artifact is being created.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 1,
        /// <summary>
        /// A state indicating that the Artifact should exist, unless something
        /// external to the system deletes it.
        /// </summary>
        [pbr::OriginalName("LIVE")] Live = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
