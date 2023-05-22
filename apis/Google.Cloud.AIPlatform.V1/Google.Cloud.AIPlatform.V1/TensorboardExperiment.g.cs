// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/tensorboard_experiment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/tensorboard_experiment.proto</summary>
  public static partial class TensorboardExperimentReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/tensorboard_experiment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TensorboardExperimentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS90ZW5zb3Jib2FyZF9leHBl",
            "cmltZW50LnByb3RvEhpnb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MRofZ29v",
            "Z2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNv",
            "dXJjZS5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byL3",
            "AwoVVGVuc29yYm9hcmRFeHBlcmltZW50EhEKBG5hbWUYASABKAlCA+BBAxIU",
            "CgxkaXNwbGF5X25hbWUYAiABKAkSEwoLZGVzY3JpcHRpb24YAyABKAkSNAoL",
            "Y3JlYXRlX3RpbWUYBCABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "QgPgQQMSNAoLdXBkYXRlX3RpbWUYBSABKAsyGi5nb29nbGUucHJvdG9idWYu",
            "VGltZXN0YW1wQgPgQQMSTQoGbGFiZWxzGAYgAygLMj0uZ29vZ2xlLmNsb3Vk",
            "LmFpcGxhdGZvcm0udjEuVGVuc29yYm9hcmRFeHBlcmltZW50LkxhYmVsc0Vu",
            "dHJ5EgwKBGV0YWcYByABKAkSEwoGc291cmNlGAggASgJQgPgQQUaLQoLTGFi",
            "ZWxzRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ATqSAepB",
            "jgEKL2FpcGxhdGZvcm0uZ29vZ2xlYXBpcy5jb20vVGVuc29yYm9hcmRFeHBl",
            "cmltZW50Eltwcm9qZWN0cy97cHJvamVjdH0vbG9jYXRpb25zL3tsb2NhdGlv",
            "bn0vdGVuc29yYm9hcmRzL3t0ZW5zb3Jib2FyZH0vZXhwZXJpbWVudHMve2V4",
            "cGVyaW1lbnR9QtgBCh5jb20uZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjFC",
            "GlRlbnNvcmJvYXJkRXhwZXJpbWVudFByb3RvUAFaPmNsb3VkLmdvb2dsZS5j",
            "b20vZ28vYWlwbGF0Zm9ybS9hcGl2MS9haXBsYXRmb3JtcGI7YWlwbGF0Zm9y",
            "bXBiqgIaR29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0uVjHKAhpHb29nbGVcQ2xv",
            "dWRcQUlQbGF0Zm9ybVxWMeoCHUdvb2dsZTo6Q2xvdWQ6OkFJUGxhdGZvcm06",
            "OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.TensorboardExperiment), global::Google.Cloud.AIPlatform.V1.TensorboardExperiment.Parser, new[]{ "Name", "DisplayName", "Description", "CreateTime", "UpdateTime", "Labels", "Etag", "Source" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A TensorboardExperiment is a group of TensorboardRuns, that are typically the
  /// results of a training job run, in a Tensorboard.
  /// </summary>
  public sealed partial class TensorboardExperiment : pb::IMessage<TensorboardExperiment>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TensorboardExperiment> _parser = new pb::MessageParser<TensorboardExperiment>(() => new TensorboardExperiment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TensorboardExperiment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.TensorboardExperimentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TensorboardExperiment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TensorboardExperiment(TensorboardExperiment other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      labels_ = other.labels_.Clone();
      etag_ = other.etag_;
      source_ = other.source_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TensorboardExperiment Clone() {
      return new TensorboardExperiment(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Name of the TensorboardExperiment.
    /// Format:
    /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
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
    /// User provided name of this TensorboardExperiment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    /// Description of this TensorboardExperiment.
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
    public const int CreateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this TensorboardExperiment was created.
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
    public const int UpdateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Timestamp when this TensorboardExperiment was last updated.
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
    /// The labels with user-defined metadata to organize your Datasets.
    ///
    /// Label keys and values cannot be longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    /// No more than 64 user labels can be associated with one Dataset (System
    /// labels are excluded).
    ///
    /// See https://goo.gl/xmQnxf for more information and examples of labels.
    /// System reserved label keys are prefixed with `aiplatform.googleapis.com/`
    /// and are immutable. The following system labels exist for each Dataset:
    ///
    /// * `aiplatform.googleapis.com/dataset_metadata_schema`: output only. Its
    ///    value is the
    ///    [metadata_schema's][google.cloud.aiplatform.v1.Dataset.metadata_schema_uri]
    ///    title.
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
    /// Used to perform consistent read-modify-write updates. If not set, a blind
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

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 8;
    private string source_ = "";
    /// <summary>
    /// Immutable. Source of the TensorboardExperiment. Example: a custom training
    /// job.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Source {
      get { return source_; }
      set {
        source_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TensorboardExperiment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TensorboardExperiment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Description != other.Description) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (Etag != other.Etag) return false;
      if (Source != other.Source) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      if (Source.Length != 0) hash ^= Source.GetHashCode();
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
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Etag);
      }
      if (Source.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Source);
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
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Etag);
      }
      if (Source.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Source);
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
      if (Source.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Source);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TensorboardExperiment other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
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
      labels_.MergeFrom(other.labels_);
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      if (other.Source.Length != 0) {
        Source = other.Source;
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
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
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
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 58: {
            Etag = input.ReadString();
            break;
          }
          case 66: {
            Source = input.ReadString();
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
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
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
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 58: {
            Etag = input.ReadString();
            break;
          }
          case 66: {
            Source = input.ReadString();
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
