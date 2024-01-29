// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/translation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/translation.proto</summary>
  public static partial class TranslationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/translation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TranslationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvYXV0b21sL3YxL3RyYW5zbGF0aW9uLnByb3RvEhZn",
            "b29nbGUuY2xvdWQuYXV0b21sLnYxGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2",
            "aW9yLnByb3RvGidnb29nbGUvY2xvdWQvYXV0b21sL3YxL2RhdGFfaXRlbXMu",
            "cHJvdG8iZAoaVHJhbnNsYXRpb25EYXRhc2V0TWV0YWRhdGESIgoUc291cmNl",
            "X2xhbmd1YWdlX2NvZGUYASABKAlCBOJBAQISIgoUdGFyZ2V0X2xhbmd1YWdl",
            "X2NvZGUYAiABKAlCBOJBAQIiSwocVHJhbnNsYXRpb25FdmFsdWF0aW9uTWV0",
            "cmljcxISCgpibGV1X3Njb3JlGAEgASgBEhcKD2Jhc2VfYmxldV9zY29yZRgC",
            "IAEoASJqChhUcmFuc2xhdGlvbk1vZGVsTWV0YWRhdGESEgoKYmFzZV9tb2Rl",
            "bBgBIAEoCRIcChRzb3VyY2VfbGFuZ3VhZ2VfY29kZRgCIAEoCRIcChR0YXJn",
            "ZXRfbGFuZ3VhZ2VfY29kZRgDIAEoCSJYChVUcmFuc2xhdGlvbkFubm90YXRp",
            "b24SPwoSdHJhbnNsYXRlZF9jb250ZW50GAEgASgLMiMuZ29vZ2xlLmNsb3Vk",
            "LmF1dG9tbC52MS5UZXh0U25pcHBldEKyAQoaY29tLmdvb2dsZS5jbG91ZC5h",
            "dXRvbWwudjFCEFRyYW5zbGF0aW9uUHJvdG9QAVoyY2xvdWQuZ29vZ2xlLmNv",
            "bS9nby9hdXRvbWwvYXBpdjEvYXV0b21scGI7YXV0b21scGKqAhZHb29nbGUu",
            "Q2xvdWQuQXV0b01MLlYxygIWR29vZ2xlXENsb3VkXEF1dG9NbFxWMeoCGUdv",
            "b2dsZTo6Q2xvdWQ6OkF1dG9NTDo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Cloud.AutoML.V1.DataItemsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TranslationDatasetMetadata), global::Google.Cloud.AutoML.V1.TranslationDatasetMetadata.Parser, new[]{ "SourceLanguageCode", "TargetLanguageCode" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TranslationEvaluationMetrics), global::Google.Cloud.AutoML.V1.TranslationEvaluationMetrics.Parser, new[]{ "BleuScore", "BaseBleuScore" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TranslationModelMetadata), global::Google.Cloud.AutoML.V1.TranslationModelMetadata.Parser, new[]{ "BaseModel", "SourceLanguageCode", "TargetLanguageCode" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TranslationAnnotation), global::Google.Cloud.AutoML.V1.TranslationAnnotation.Parser, new[]{ "TranslatedContent" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Dataset metadata that is specific to translation.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TranslationDatasetMetadata : pb::IMessage<TranslationDatasetMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TranslationDatasetMetadata> _parser = new pb::MessageParser<TranslationDatasetMetadata>(() => new TranslationDatasetMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TranslationDatasetMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationDatasetMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationDatasetMetadata(TranslationDatasetMetadata other) : this() {
      sourceLanguageCode_ = other.sourceLanguageCode_;
      targetLanguageCode_ = other.targetLanguageCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationDatasetMetadata Clone() {
      return new TranslationDatasetMetadata(this);
    }

    /// <summary>Field number for the "source_language_code" field.</summary>
    public const int SourceLanguageCodeFieldNumber = 1;
    private string sourceLanguageCode_ = "";
    /// <summary>
    /// Required. The BCP-47 language code of the source language.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SourceLanguageCode {
      get { return sourceLanguageCode_; }
      set {
        sourceLanguageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_language_code" field.</summary>
    public const int TargetLanguageCodeFieldNumber = 2;
    private string targetLanguageCode_ = "";
    /// <summary>
    /// Required. The BCP-47 language code of the target language.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TargetLanguageCode {
      get { return targetLanguageCode_; }
      set {
        targetLanguageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TranslationDatasetMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TranslationDatasetMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceLanguageCode != other.SourceLanguageCode) return false;
      if (TargetLanguageCode != other.TargetLanguageCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceLanguageCode.Length != 0) hash ^= SourceLanguageCode.GetHashCode();
      if (TargetLanguageCode.Length != 0) hash ^= TargetLanguageCode.GetHashCode();
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
      if (SourceLanguageCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SourceLanguageCode);
      }
      if (TargetLanguageCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TargetLanguageCode);
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
      if (SourceLanguageCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SourceLanguageCode);
      }
      if (TargetLanguageCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TargetLanguageCode);
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
      if (SourceLanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceLanguageCode);
      }
      if (TargetLanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetLanguageCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TranslationDatasetMetadata other) {
      if (other == null) {
        return;
      }
      if (other.SourceLanguageCode.Length != 0) {
        SourceLanguageCode = other.SourceLanguageCode;
      }
      if (other.TargetLanguageCode.Length != 0) {
        TargetLanguageCode = other.TargetLanguageCode;
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
            SourceLanguageCode = input.ReadString();
            break;
          }
          case 18: {
            TargetLanguageCode = input.ReadString();
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
            SourceLanguageCode = input.ReadString();
            break;
          }
          case 18: {
            TargetLanguageCode = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Evaluation metrics for the dataset.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TranslationEvaluationMetrics : pb::IMessage<TranslationEvaluationMetrics>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TranslationEvaluationMetrics> _parser = new pb::MessageParser<TranslationEvaluationMetrics>(() => new TranslationEvaluationMetrics());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TranslationEvaluationMetrics> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationEvaluationMetrics() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationEvaluationMetrics(TranslationEvaluationMetrics other) : this() {
      bleuScore_ = other.bleuScore_;
      baseBleuScore_ = other.baseBleuScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationEvaluationMetrics Clone() {
      return new TranslationEvaluationMetrics(this);
    }

    /// <summary>Field number for the "bleu_score" field.</summary>
    public const int BleuScoreFieldNumber = 1;
    private double bleuScore_;
    /// <summary>
    /// Output only. BLEU score.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double BleuScore {
      get { return bleuScore_; }
      set {
        bleuScore_ = value;
      }
    }

    /// <summary>Field number for the "base_bleu_score" field.</summary>
    public const int BaseBleuScoreFieldNumber = 2;
    private double baseBleuScore_;
    /// <summary>
    /// Output only. BLEU score for base model.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double BaseBleuScore {
      get { return baseBleuScore_; }
      set {
        baseBleuScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TranslationEvaluationMetrics);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TranslationEvaluationMetrics other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BleuScore, other.BleuScore)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BaseBleuScore, other.BaseBleuScore)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BleuScore != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BleuScore);
      if (BaseBleuScore != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BaseBleuScore);
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
      if (BleuScore != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(BleuScore);
      }
      if (BaseBleuScore != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(BaseBleuScore);
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
      if (BleuScore != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(BleuScore);
      }
      if (BaseBleuScore != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(BaseBleuScore);
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
      if (BleuScore != 0D) {
        size += 1 + 8;
      }
      if (BaseBleuScore != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TranslationEvaluationMetrics other) {
      if (other == null) {
        return;
      }
      if (other.BleuScore != 0D) {
        BleuScore = other.BleuScore;
      }
      if (other.BaseBleuScore != 0D) {
        BaseBleuScore = other.BaseBleuScore;
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
          case 9: {
            BleuScore = input.ReadDouble();
            break;
          }
          case 17: {
            BaseBleuScore = input.ReadDouble();
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
          case 9: {
            BleuScore = input.ReadDouble();
            break;
          }
          case 17: {
            BaseBleuScore = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Model metadata that is specific to translation.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TranslationModelMetadata : pb::IMessage<TranslationModelMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TranslationModelMetadata> _parser = new pb::MessageParser<TranslationModelMetadata>(() => new TranslationModelMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TranslationModelMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationModelMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationModelMetadata(TranslationModelMetadata other) : this() {
      baseModel_ = other.baseModel_;
      sourceLanguageCode_ = other.sourceLanguageCode_;
      targetLanguageCode_ = other.targetLanguageCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationModelMetadata Clone() {
      return new TranslationModelMetadata(this);
    }

    /// <summary>Field number for the "base_model" field.</summary>
    public const int BaseModelFieldNumber = 1;
    private string baseModel_ = "";
    /// <summary>
    /// The resource name of the model to use as a baseline to train the custom
    /// model. If unset, we use the default base model provided by Google
    /// Translate. Format:
    /// `projects/{project_id}/locations/{location_id}/models/{model_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BaseModel {
      get { return baseModel_; }
      set {
        baseModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source_language_code" field.</summary>
    public const int SourceLanguageCodeFieldNumber = 2;
    private string sourceLanguageCode_ = "";
    /// <summary>
    /// Output only. Inferred from the dataset.
    /// The source language (The BCP-47 language code) that is used for training.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SourceLanguageCode {
      get { return sourceLanguageCode_; }
      set {
        sourceLanguageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_language_code" field.</summary>
    public const int TargetLanguageCodeFieldNumber = 3;
    private string targetLanguageCode_ = "";
    /// <summary>
    /// Output only. The target language (The BCP-47 language code) that is used
    /// for training.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TargetLanguageCode {
      get { return targetLanguageCode_; }
      set {
        targetLanguageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TranslationModelMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TranslationModelMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BaseModel != other.BaseModel) return false;
      if (SourceLanguageCode != other.SourceLanguageCode) return false;
      if (TargetLanguageCode != other.TargetLanguageCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BaseModel.Length != 0) hash ^= BaseModel.GetHashCode();
      if (SourceLanguageCode.Length != 0) hash ^= SourceLanguageCode.GetHashCode();
      if (TargetLanguageCode.Length != 0) hash ^= TargetLanguageCode.GetHashCode();
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
      if (BaseModel.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BaseModel);
      }
      if (SourceLanguageCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SourceLanguageCode);
      }
      if (TargetLanguageCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TargetLanguageCode);
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
      if (BaseModel.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BaseModel);
      }
      if (SourceLanguageCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SourceLanguageCode);
      }
      if (TargetLanguageCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TargetLanguageCode);
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
      if (BaseModel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BaseModel);
      }
      if (SourceLanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceLanguageCode);
      }
      if (TargetLanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetLanguageCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TranslationModelMetadata other) {
      if (other == null) {
        return;
      }
      if (other.BaseModel.Length != 0) {
        BaseModel = other.BaseModel;
      }
      if (other.SourceLanguageCode.Length != 0) {
        SourceLanguageCode = other.SourceLanguageCode;
      }
      if (other.TargetLanguageCode.Length != 0) {
        TargetLanguageCode = other.TargetLanguageCode;
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
            BaseModel = input.ReadString();
            break;
          }
          case 18: {
            SourceLanguageCode = input.ReadString();
            break;
          }
          case 26: {
            TargetLanguageCode = input.ReadString();
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
            BaseModel = input.ReadString();
            break;
          }
          case 18: {
            SourceLanguageCode = input.ReadString();
            break;
          }
          case 26: {
            TargetLanguageCode = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Annotation details specific to translation.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TranslationAnnotation : pb::IMessage<TranslationAnnotation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TranslationAnnotation> _parser = new pb::MessageParser<TranslationAnnotation>(() => new TranslationAnnotation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TranslationAnnotation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationAnnotation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationAnnotation(TranslationAnnotation other) : this() {
      translatedContent_ = other.translatedContent_ != null ? other.translatedContent_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TranslationAnnotation Clone() {
      return new TranslationAnnotation(this);
    }

    /// <summary>Field number for the "translated_content" field.</summary>
    public const int TranslatedContentFieldNumber = 1;
    private global::Google.Cloud.AutoML.V1.TextSnippet translatedContent_;
    /// <summary>
    /// Output only . The translated content.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AutoML.V1.TextSnippet TranslatedContent {
      get { return translatedContent_; }
      set {
        translatedContent_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TranslationAnnotation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TranslationAnnotation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TranslatedContent, other.TranslatedContent)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (translatedContent_ != null) hash ^= TranslatedContent.GetHashCode();
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
      if (translatedContent_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TranslatedContent);
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
      if (translatedContent_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TranslatedContent);
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
      if (translatedContent_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TranslatedContent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TranslationAnnotation other) {
      if (other == null) {
        return;
      }
      if (other.translatedContent_ != null) {
        if (translatedContent_ == null) {
          TranslatedContent = new global::Google.Cloud.AutoML.V1.TextSnippet();
        }
        TranslatedContent.MergeFrom(other.TranslatedContent);
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
            if (translatedContent_ == null) {
              TranslatedContent = new global::Google.Cloud.AutoML.V1.TextSnippet();
            }
            input.ReadMessage(TranslatedContent);
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
            if (translatedContent_ == null) {
              TranslatedContent = new global::Google.Cloud.AutoML.V1.TextSnippet();
            }
            input.ReadMessage(TranslatedContent);
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
