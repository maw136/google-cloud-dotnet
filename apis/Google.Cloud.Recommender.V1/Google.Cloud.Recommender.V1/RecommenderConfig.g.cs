// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/recommender/v1/recommender_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Recommender.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/recommender/v1/recommender_config.proto</summary>
  public static partial class RecommenderConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/recommender/v1/recommender_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RecommenderConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvY2xvdWQvcmVjb21tZW5kZXIvdjEvcmVjb21tZW5kZXJfY29u",
            "ZmlnLnByb3RvEhtnb29nbGUuY2xvdWQucmVjb21tZW5kZXIudjEaH2dvb2ds",
            "ZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3Vy",
            "Y2UucHJvdG8aHGdvb2dsZS9wcm90b2J1Zi9zdHJ1Y3QucHJvdG8aH2dvb2ds",
            "ZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8irQUKEVJlY29tbWVuZGVyQ29u",
            "ZmlnEgwKBG5hbWUYASABKAkSXwodcmVjb21tZW5kZXJfZ2VuZXJhdGlvbl9j",
            "b25maWcYAiABKAsyOC5nb29nbGUuY2xvdWQucmVjb21tZW5kZXIudjEuUmVj",
            "b21tZW5kZXJHZW5lcmF0aW9uQ29uZmlnEgwKBGV0YWcYAyABKAkSLwoLdXBk",
            "YXRlX3RpbWUYBCABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEhsK",
            "C3JldmlzaW9uX2lkGAUgASgJQgbgQQXgQQMSVAoLYW5ub3RhdGlvbnMYBiAD",
            "KAsyPy5nb29nbGUuY2xvdWQucmVjb21tZW5kZXIudjEuUmVjb21tZW5kZXJD",
            "b25maWcuQW5ub3RhdGlvbnNFbnRyeRIUCgxkaXNwbGF5X25hbWUYByABKAka",
            "MgoQQW5ub3RhdGlvbnNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiAB",
            "KAk6AjgBOqwC6kGoAgoscmVjb21tZW5kZXIuZ29vZ2xlYXBpcy5jb20vUmVj",
            "b21tZW5kZXJDb25maWcSSXByb2plY3RzL3twcm9qZWN0fS9sb2NhdGlvbnMv",
            "e2xvY2F0aW9ufS9yZWNvbW1lbmRlcnMve3JlY29tbWVuZGVyfS9jb25maWcS",
            "U29yZ2FuaXphdGlvbnMve29yZ2FuaXphdGlvbn0vbG9jYXRpb25zL3tsb2Nh",
            "dGlvbn0vcmVjb21tZW5kZXJzL3tyZWNvbW1lbmRlcn0vY29uZmlnElhiaWxs",
            "aW5nQWNjb3VudHMve2JpbGxpbmdfYWNjb3VudH0vbG9jYXRpb25zL3tsb2Nh",
            "dGlvbn0vcmVjb21tZW5kZXJzL3tyZWNvbW1lbmRlcn0vY29uZmlnIkYKG1Jl",
            "Y29tbWVuZGVyR2VuZXJhdGlvbkNvbmZpZxInCgZwYXJhbXMYASABKAsyFy5n",
            "b29nbGUucHJvdG9idWYuU3RydWN0QqMBCh9jb20uZ29vZ2xlLmNsb3VkLnJl",
            "Y29tbWVuZGVyLnYxQhZSZWNvbW1lbmRlckNvbmZpZ1Byb3RvUAFaQWNsb3Vk",
            "Lmdvb2dsZS5jb20vZ28vcmVjb21tZW5kZXIvYXBpdjEvcmVjb21tZW5kZXJw",
            "YjtyZWNvbW1lbmRlcnBiogIEQ1JFQ6oCG0dvb2dsZS5DbG91ZC5SZWNvbW1l",
            "bmRlci5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Recommender.V1.RecommenderConfig), global::Google.Cloud.Recommender.V1.RecommenderConfig.Parser, new[]{ "Name", "RecommenderGenerationConfig", "Etag", "UpdateTime", "RevisionId", "Annotations", "DisplayName" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Recommender.V1.RecommenderGenerationConfig), global::Google.Cloud.Recommender.V1.RecommenderGenerationConfig.Parser, new[]{ "Params" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration for a Recommender.
  /// </summary>
  public sealed partial class RecommenderConfig : pb::IMessage<RecommenderConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RecommenderConfig> _parser = new pb::MessageParser<RecommenderConfig>(() => new RecommenderConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RecommenderConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Recommender.V1.RecommenderConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommenderConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommenderConfig(RecommenderConfig other) : this() {
      name_ = other.name_;
      recommenderGenerationConfig_ = other.recommenderGenerationConfig_ != null ? other.recommenderGenerationConfig_.Clone() : null;
      etag_ = other.etag_;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      revisionId_ = other.revisionId_;
      annotations_ = other.annotations_.Clone();
      displayName_ = other.displayName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommenderConfig Clone() {
      return new RecommenderConfig(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of recommender config.
    /// Eg,
    /// projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "recommender_generation_config" field.</summary>
    public const int RecommenderGenerationConfigFieldNumber = 2;
    private global::Google.Cloud.Recommender.V1.RecommenderGenerationConfig recommenderGenerationConfig_;
    /// <summary>
    /// RecommenderGenerationConfig which configures the Generation of
    /// recommendations for this recommender.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Recommender.V1.RecommenderGenerationConfig RecommenderGenerationConfig {
      get { return recommenderGenerationConfig_; }
      set {
        recommenderGenerationConfig_ = value;
      }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 3;
    private string etag_ = "";
    /// <summary>
    /// Fingerprint of the RecommenderConfig. Provides optimistic locking when
    /// updating.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Last time when the config was updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "revision_id" field.</summary>
    public const int RevisionIdFieldNumber = 5;
    private string revisionId_ = "";
    /// <summary>
    /// Output only. Immutable. The revision ID of the config.
    /// A new revision is committed whenever the config is changed in any way.
    /// The format is an 8-character hexadecimal string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RevisionId {
      get { return revisionId_; }
      set {
        revisionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "annotations" field.</summary>
    public const int AnnotationsFieldNumber = 6;
    private static readonly pbc::MapField<string, string>.Codec _map_annotations_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 50);
    private readonly pbc::MapField<string, string> annotations_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Allows clients to store small amounts of arbitrary data. Annotations must
    /// follow the Kubernetes syntax.
    /// The total size of all keys and values combined is limited to 256k.
    /// Key can have 2 segments: prefix (optional) and name (required),
    /// separated by a slash (/).
    /// Prefix must be a DNS subdomain.
    /// Name must be 63 characters or less, begin and end with alphanumerics,
    /// with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Annotations {
      get { return annotations_; }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 7;
    private string displayName_ = "";
    /// <summary>
    /// A user-settable field to provide a human-readable name to be used in user
    /// interfaces.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RecommenderConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RecommenderConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(RecommenderGenerationConfig, other.RecommenderGenerationConfig)) return false;
      if (Etag != other.Etag) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (RevisionId != other.RevisionId) return false;
      if (!Annotations.Equals(other.Annotations)) return false;
      if (DisplayName != other.DisplayName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (recommenderGenerationConfig_ != null) hash ^= RecommenderGenerationConfig.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (RevisionId.Length != 0) hash ^= RevisionId.GetHashCode();
      hash ^= Annotations.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
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
      if (recommenderGenerationConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RecommenderGenerationConfig);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Etag);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
      }
      if (RevisionId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RevisionId);
      }
      annotations_.WriteTo(output, _map_annotations_codec);
      if (DisplayName.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DisplayName);
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
      if (recommenderGenerationConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RecommenderGenerationConfig);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Etag);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
      }
      if (RevisionId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RevisionId);
      }
      annotations_.WriteTo(ref output, _map_annotations_codec);
      if (DisplayName.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DisplayName);
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
      if (recommenderGenerationConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RecommenderGenerationConfig);
      }
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (RevisionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RevisionId);
      }
      size += annotations_.CalculateSize(_map_annotations_codec);
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RecommenderConfig other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.recommenderGenerationConfig_ != null) {
        if (recommenderGenerationConfig_ == null) {
          RecommenderGenerationConfig = new global::Google.Cloud.Recommender.V1.RecommenderGenerationConfig();
        }
        RecommenderGenerationConfig.MergeFrom(other.RecommenderGenerationConfig);
      }
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.RevisionId.Length != 0) {
        RevisionId = other.RevisionId;
      }
      annotations_.MergeFrom(other.annotations_);
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
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
            if (recommenderGenerationConfig_ == null) {
              RecommenderGenerationConfig = new global::Google.Cloud.Recommender.V1.RecommenderGenerationConfig();
            }
            input.ReadMessage(RecommenderGenerationConfig);
            break;
          }
          case 26: {
            Etag = input.ReadString();
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
            RevisionId = input.ReadString();
            break;
          }
          case 50: {
            annotations_.AddEntriesFrom(input, _map_annotations_codec);
            break;
          }
          case 58: {
            DisplayName = input.ReadString();
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
            if (recommenderGenerationConfig_ == null) {
              RecommenderGenerationConfig = new global::Google.Cloud.Recommender.V1.RecommenderGenerationConfig();
            }
            input.ReadMessage(RecommenderGenerationConfig);
            break;
          }
          case 26: {
            Etag = input.ReadString();
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
            RevisionId = input.ReadString();
            break;
          }
          case 50: {
            annotations_.AddEntriesFrom(ref input, _map_annotations_codec);
            break;
          }
          case 58: {
            DisplayName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// A Configuration to customize the generation of recommendations.
  /// Eg, customizing the lookback period considered when generating a
  /// recommendation.
  /// </summary>
  public sealed partial class RecommenderGenerationConfig : pb::IMessage<RecommenderGenerationConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RecommenderGenerationConfig> _parser = new pb::MessageParser<RecommenderGenerationConfig>(() => new RecommenderGenerationConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RecommenderGenerationConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Recommender.V1.RecommenderConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommenderGenerationConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommenderGenerationConfig(RecommenderGenerationConfig other) : this() {
      params_ = other.params_ != null ? other.params_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommenderGenerationConfig Clone() {
      return new RecommenderGenerationConfig(this);
    }

    /// <summary>Field number for the "params" field.</summary>
    public const int ParamsFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Struct params_;
    /// <summary>
    /// Parameters for this RecommenderGenerationConfig. These configs can be used
    /// by or are applied to all subtypes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Struct Params {
      get { return params_; }
      set {
        params_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RecommenderGenerationConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RecommenderGenerationConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Params, other.Params)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (params_ != null) hash ^= Params.GetHashCode();
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
      if (params_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Params);
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
      if (params_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Params);
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
      if (params_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Params);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RecommenderGenerationConfig other) {
      if (other == null) {
        return;
      }
      if (other.params_ != null) {
        if (params_ == null) {
          Params = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Params.MergeFrom(other.Params);
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
            if (params_ == null) {
              Params = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Params);
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
            if (params_ == null) {
              Params = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Params);
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
