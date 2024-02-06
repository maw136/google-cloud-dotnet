// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/tensorboard_run.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/tensorboard_run.proto</summary>
  public static partial class TensorboardRunReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/tensorboard_run.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TensorboardRunReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS90ZW5zb3Jib2FyZF9ydW4u",
            "cHJvdG8SGmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxGh9nb29nbGUvYXBp",
            "L2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnBy",
            "b3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIt0DCg5UZW5z",
            "b3Jib2FyZFJ1bhIRCgRuYW1lGAEgASgJQgPgQQMSGQoMZGlzcGxheV9uYW1l",
            "GAIgASgJQgPgQQISEwoLZGVzY3JpcHRpb24YAyABKAkSNAoLY3JlYXRlX3Rp",
            "bWUYBiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMSNAoL",
            "dXBkYXRlX3RpbWUYByABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "QgPgQQMSRgoGbGFiZWxzGAggAygLMjYuZ29vZ2xlLmNsb3VkLmFpcGxhdGZv",
            "cm0udjEuVGVuc29yYm9hcmRSdW4uTGFiZWxzRW50cnkSDAoEZXRhZxgJIAEo",
            "CRotCgtMYWJlbHNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6",
            "AjgBOpYB6kGSAQooYWlwbGF0Zm9ybS5nb29nbGVhcGlzLmNvbS9UZW5zb3Ji",
            "b2FyZFJ1bhJmcHJvamVjdHMve3Byb2plY3R9L2xvY2F0aW9ucy97bG9jYXRp",
            "b259L3RlbnNvcmJvYXJkcy97dGVuc29yYm9hcmR9L2V4cGVyaW1lbnRzL3tl",
            "eHBlcmltZW50fS9ydW5zL3tydW59QtEBCh5jb20uZ29vZ2xlLmNsb3VkLmFp",
            "cGxhdGZvcm0udjFCE1RlbnNvcmJvYXJkUnVuUHJvdG9QAVo+Y2xvdWQuZ29v",
            "Z2xlLmNvbS9nby9haXBsYXRmb3JtL2FwaXYxL2FpcGxhdGZvcm1wYjthaXBs",
            "YXRmb3JtcGKqAhpHb29nbGUuQ2xvdWQuQUlQbGF0Zm9ybS5WMcoCGkdvb2ds",
            "ZVxDbG91ZFxBSVBsYXRmb3JtXFYx6gIdR29vZ2xlOjpDbG91ZDo6QUlQbGF0",
            "Zm9ybTo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.TensorboardRun), global::Google.Cloud.AIPlatform.V1.TensorboardRun.Parser, new[]{ "Name", "DisplayName", "Description", "CreateTime", "UpdateTime", "Labels", "Etag" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// TensorboardRun maps to a specific execution of a training job with a given
  /// set of hyperparameter values, model definition, dataset, etc
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TensorboardRun : pb::IMessage<TensorboardRun>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TensorboardRun> _parser = new pb::MessageParser<TensorboardRun>(() => new TensorboardRun());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TensorboardRun> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.TensorboardRunReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TensorboardRun() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TensorboardRun(TensorboardRun other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      labels_ = other.labels_.Clone();
      etag_ = other.etag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TensorboardRun Clone() {
      return new TensorboardRun(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Name of the TensorboardRun.
    /// Format:
    /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
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
    /// Required. User provided name of this TensorboardRun.
    /// This value must be unique among all TensorboardRuns
    /// belonging to the same parent TensorboardExperiment.
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
    /// Description of this TensorboardRun.
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
    public const int CreateTimeFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this TensorboardRun was created.
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
    public const int UpdateTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Timestamp when this TensorboardRun was last updated.
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
    public const int LabelsFieldNumber = 8;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 66);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// The labels with user-defined metadata to organize your TensorboardRuns.
    ///
    /// This field will be used to filter and visualize Runs in the Tensorboard UI.
    /// For example, a Vertex AI training job can set a label
    /// aiplatform.googleapis.com/training_job_id=xxxxx to all the runs created
    /// within that job. An end user can set a label experiment_id=xxxxx for all
    /// the runs produced in a Jupyter notebook. These runs can be grouped by a
    /// label value and visualized together in the Tensorboard UI.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    /// No more than 64 user labels can be associated with one TensorboardRun
    /// (System labels are excluded).
    ///
    /// See https://goo.gl/xmQnxf for more information and examples of labels.
    /// System reserved label keys are prefixed with "aiplatform.googleapis.com/"
    /// and are immutable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 9;
    private string etag_ = "";
    /// <summary>
    /// Used to perform a consistent read-modify-write updates. If not set, a blind
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TensorboardRun);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TensorboardRun other) {
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
        output.WriteRawTag(50);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Etag);
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
        output.WriteRawTag(50);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Etag);
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TensorboardRun other) {
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
          case 50: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 58: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 66: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 74: {
            Etag = input.ReadString();
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
          case 50: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 58: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 66: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 74: {
            Etag = input.ReadString();
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
