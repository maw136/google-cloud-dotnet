// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/text_extraction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/text_extraction.proto</summary>
  public static partial class TextExtractionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/text_extraction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TextExtractionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvY2xvdWQvYXV0b21sL3YxL3RleHRfZXh0cmFjdGlvbi5wcm90",
            "bxIWZ29vZ2xlLmNsb3VkLmF1dG9tbC52MRocZ29vZ2xlL2FwaS9hbm5vdGF0",
            "aW9ucy5wcm90bxopZ29vZ2xlL2Nsb3VkL2F1dG9tbC92MS90ZXh0X3NlZ21l",
            "bnQucHJvdG8idAoYVGV4dEV4dHJhY3Rpb25Bbm5vdGF0aW9uEjsKDHRleHRf",
            "c2VnbWVudBgDIAEoCzIjLmdvb2dsZS5jbG91ZC5hdXRvbWwudjEuVGV4dFNl",
            "Z21lbnRIABINCgVzY29yZRgBIAEoAkIMCgphbm5vdGF0aW9uIpICCh9UZXh0",
            "RXh0cmFjdGlvbkV2YWx1YXRpb25NZXRyaWNzEg4KBmF1X3ByYxgBIAEoAhJy",
            "Chpjb25maWRlbmNlX21ldHJpY3NfZW50cmllcxgCIAMoCzJOLmdvb2dsZS5j",
            "bG91ZC5hdXRvbWwudjEuVGV4dEV4dHJhY3Rpb25FdmFsdWF0aW9uTWV0cmlj",
            "cy5Db25maWRlbmNlTWV0cmljc0VudHJ5GmsKFkNvbmZpZGVuY2VNZXRyaWNz",
            "RW50cnkSHAoUY29uZmlkZW5jZV90aHJlc2hvbGQYASABKAISDgoGcmVjYWxs",
            "GAMgASgCEhEKCXByZWNpc2lvbhgEIAEoAhIQCghmMV9zY29yZRgFIAEoAkKq",
            "AQoaY29tLmdvb2dsZS5jbG91ZC5hdXRvbWwudjFQAVo8Z29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9hdXRvbWwvdjE7YXV0",
            "b21sqgIWR29vZ2xlLkNsb3VkLkF1dG9NTC5WMcoCFkdvb2dsZVxDbG91ZFxB",
            "dXRvTWxcVjHqAhlHb29nbGU6OkNsb3VkOjpBdXRvTUw6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Cloud.AutoML.V1.TextSegmentReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TextExtractionAnnotation), global::Google.Cloud.AutoML.V1.TextExtractionAnnotation.Parser, new[]{ "TextSegment", "Score" }, new[]{ "Annotation" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics), global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics.Parser, new[]{ "AuPrc", "ConfidenceMetricsEntries" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics.Types.ConfidenceMetricsEntry), global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics.Types.ConfidenceMetricsEntry.Parser, new[]{ "ConfidenceThreshold", "Recall", "Precision", "F1Score" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Annotation for identifying spans of text.
  /// </summary>
  public sealed partial class TextExtractionAnnotation : pb::IMessage<TextExtractionAnnotation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TextExtractionAnnotation> _parser = new pb::MessageParser<TextExtractionAnnotation>(() => new TextExtractionAnnotation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TextExtractionAnnotation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TextExtractionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextExtractionAnnotation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextExtractionAnnotation(TextExtractionAnnotation other) : this() {
      score_ = other.score_;
      switch (other.AnnotationCase) {
        case AnnotationOneofCase.TextSegment:
          TextSegment = other.TextSegment.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextExtractionAnnotation Clone() {
      return new TextExtractionAnnotation(this);
    }

    /// <summary>Field number for the "text_segment" field.</summary>
    public const int TextSegmentFieldNumber = 3;
    /// <summary>
    /// An entity annotation will set this, which is the part of the original
    /// text to which the annotation pertains.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AutoML.V1.TextSegment TextSegment {
      get { return annotationCase_ == AnnotationOneofCase.TextSegment ? (global::Google.Cloud.AutoML.V1.TextSegment) annotation_ : null; }
      set {
        annotation_ = value;
        annotationCase_ = value == null ? AnnotationOneofCase.None : AnnotationOneofCase.TextSegment;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 1;
    private float score_;
    /// <summary>
    /// Output only. A confidence estimate between 0.0 and 1.0. A higher value
    /// means greater confidence in correctness of the annotation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    private object annotation_;
    /// <summary>Enum of possible cases for the "annotation" oneof.</summary>
    public enum AnnotationOneofCase {
      None = 0,
      TextSegment = 3,
    }
    private AnnotationOneofCase annotationCase_ = AnnotationOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnnotationOneofCase AnnotationCase {
      get { return annotationCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAnnotation() {
      annotationCase_ = AnnotationOneofCase.None;
      annotation_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TextExtractionAnnotation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TextExtractionAnnotation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TextSegment, other.TextSegment)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Score, other.Score)) return false;
      if (AnnotationCase != other.AnnotationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (annotationCase_ == AnnotationOneofCase.TextSegment) hash ^= TextSegment.GetHashCode();
      if (Score != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Score);
      hash ^= (int) annotationCase_;
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
      if (Score != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Score);
      }
      if (annotationCase_ == AnnotationOneofCase.TextSegment) {
        output.WriteRawTag(26);
        output.WriteMessage(TextSegment);
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
      if (Score != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Score);
      }
      if (annotationCase_ == AnnotationOneofCase.TextSegment) {
        output.WriteRawTag(26);
        output.WriteMessage(TextSegment);
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
      if (annotationCase_ == AnnotationOneofCase.TextSegment) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TextSegment);
      }
      if (Score != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TextExtractionAnnotation other) {
      if (other == null) {
        return;
      }
      if (other.Score != 0F) {
        Score = other.Score;
      }
      switch (other.AnnotationCase) {
        case AnnotationOneofCase.TextSegment:
          if (TextSegment == null) {
            TextSegment = new global::Google.Cloud.AutoML.V1.TextSegment();
          }
          TextSegment.MergeFrom(other.TextSegment);
          break;
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
          case 13: {
            Score = input.ReadFloat();
            break;
          }
          case 26: {
            global::Google.Cloud.AutoML.V1.TextSegment subBuilder = new global::Google.Cloud.AutoML.V1.TextSegment();
            if (annotationCase_ == AnnotationOneofCase.TextSegment) {
              subBuilder.MergeFrom(TextSegment);
            }
            input.ReadMessage(subBuilder);
            TextSegment = subBuilder;
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
          case 13: {
            Score = input.ReadFloat();
            break;
          }
          case 26: {
            global::Google.Cloud.AutoML.V1.TextSegment subBuilder = new global::Google.Cloud.AutoML.V1.TextSegment();
            if (annotationCase_ == AnnotationOneofCase.TextSegment) {
              subBuilder.MergeFrom(TextSegment);
            }
            input.ReadMessage(subBuilder);
            TextSegment = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Model evaluation metrics for text extraction problems.
  /// </summary>
  public sealed partial class TextExtractionEvaluationMetrics : pb::IMessage<TextExtractionEvaluationMetrics>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TextExtractionEvaluationMetrics> _parser = new pb::MessageParser<TextExtractionEvaluationMetrics>(() => new TextExtractionEvaluationMetrics());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TextExtractionEvaluationMetrics> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TextExtractionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextExtractionEvaluationMetrics() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextExtractionEvaluationMetrics(TextExtractionEvaluationMetrics other) : this() {
      auPrc_ = other.auPrc_;
      confidenceMetricsEntries_ = other.confidenceMetricsEntries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextExtractionEvaluationMetrics Clone() {
      return new TextExtractionEvaluationMetrics(this);
    }

    /// <summary>Field number for the "au_prc" field.</summary>
    public const int AuPrcFieldNumber = 1;
    private float auPrc_;
    /// <summary>
    /// Output only. The Area under precision recall curve metric.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float AuPrc {
      get { return auPrc_; }
      set {
        auPrc_ = value;
      }
    }

    /// <summary>Field number for the "confidence_metrics_entries" field.</summary>
    public const int ConfidenceMetricsEntriesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics.Types.ConfidenceMetricsEntry> _repeated_confidenceMetricsEntries_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics.Types.ConfidenceMetricsEntry.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics.Types.ConfidenceMetricsEntry> confidenceMetricsEntries_ = new pbc::RepeatedField<global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics.Types.ConfidenceMetricsEntry>();
    /// <summary>
    /// Output only. Metrics that have confidence thresholds.
    /// Precision-recall curve can be derived from it.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics.Types.ConfidenceMetricsEntry> ConfidenceMetricsEntries {
      get { return confidenceMetricsEntries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TextExtractionEvaluationMetrics);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TextExtractionEvaluationMetrics other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AuPrc, other.AuPrc)) return false;
      if(!confidenceMetricsEntries_.Equals(other.confidenceMetricsEntries_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AuPrc != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AuPrc);
      hash ^= confidenceMetricsEntries_.GetHashCode();
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
      if (AuPrc != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(AuPrc);
      }
      confidenceMetricsEntries_.WriteTo(output, _repeated_confidenceMetricsEntries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (AuPrc != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(AuPrc);
      }
      confidenceMetricsEntries_.WriteTo(ref output, _repeated_confidenceMetricsEntries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (AuPrc != 0F) {
        size += 1 + 4;
      }
      size += confidenceMetricsEntries_.CalculateSize(_repeated_confidenceMetricsEntries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TextExtractionEvaluationMetrics other) {
      if (other == null) {
        return;
      }
      if (other.AuPrc != 0F) {
        AuPrc = other.AuPrc;
      }
      confidenceMetricsEntries_.Add(other.confidenceMetricsEntries_);
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
          case 13: {
            AuPrc = input.ReadFloat();
            break;
          }
          case 18: {
            confidenceMetricsEntries_.AddEntriesFrom(input, _repeated_confidenceMetricsEntries_codec);
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
          case 13: {
            AuPrc = input.ReadFloat();
            break;
          }
          case 18: {
            confidenceMetricsEntries_.AddEntriesFrom(ref input, _repeated_confidenceMetricsEntries_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TextExtractionEvaluationMetrics message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Metrics for a single confidence threshold.
      /// </summary>
      public sealed partial class ConfidenceMetricsEntry : pb::IMessage<ConfidenceMetricsEntry>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<ConfidenceMetricsEntry> _parser = new pb::MessageParser<ConfidenceMetricsEntry>(() => new ConfidenceMetricsEntry());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<ConfidenceMetricsEntry> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ConfidenceMetricsEntry() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ConfidenceMetricsEntry(ConfidenceMetricsEntry other) : this() {
          confidenceThreshold_ = other.confidenceThreshold_;
          recall_ = other.recall_;
          precision_ = other.precision_;
          f1Score_ = other.f1Score_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ConfidenceMetricsEntry Clone() {
          return new ConfidenceMetricsEntry(this);
        }

        /// <summary>Field number for the "confidence_threshold" field.</summary>
        public const int ConfidenceThresholdFieldNumber = 1;
        private float confidenceThreshold_;
        /// <summary>
        /// Output only. The confidence threshold value used to compute the metrics.
        /// Only annotations with score of at least this threshold are considered to
        /// be ones the model would return.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public float ConfidenceThreshold {
          get { return confidenceThreshold_; }
          set {
            confidenceThreshold_ = value;
          }
        }

        /// <summary>Field number for the "recall" field.</summary>
        public const int RecallFieldNumber = 3;
        private float recall_;
        /// <summary>
        /// Output only. Recall under the given confidence threshold.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public float Recall {
          get { return recall_; }
          set {
            recall_ = value;
          }
        }

        /// <summary>Field number for the "precision" field.</summary>
        public const int PrecisionFieldNumber = 4;
        private float precision_;
        /// <summary>
        /// Output only. Precision under the given confidence threshold.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public float Precision {
          get { return precision_; }
          set {
            precision_ = value;
          }
        }

        /// <summary>Field number for the "f1_score" field.</summary>
        public const int F1ScoreFieldNumber = 5;
        private float f1Score_;
        /// <summary>
        /// Output only. The harmonic mean of recall and precision.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public float F1Score {
          get { return f1Score_; }
          set {
            f1Score_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as ConfidenceMetricsEntry);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(ConfidenceMetricsEntry other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ConfidenceThreshold, other.ConfidenceThreshold)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Recall, other.Recall)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Precision, other.Precision)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(F1Score, other.F1Score)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (ConfidenceThreshold != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ConfidenceThreshold);
          if (Recall != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Recall);
          if (Precision != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Precision);
          if (F1Score != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(F1Score);
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
          if (ConfidenceThreshold != 0F) {
            output.WriteRawTag(13);
            output.WriteFloat(ConfidenceThreshold);
          }
          if (Recall != 0F) {
            output.WriteRawTag(29);
            output.WriteFloat(Recall);
          }
          if (Precision != 0F) {
            output.WriteRawTag(37);
            output.WriteFloat(Precision);
          }
          if (F1Score != 0F) {
            output.WriteRawTag(45);
            output.WriteFloat(F1Score);
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
          if (ConfidenceThreshold != 0F) {
            output.WriteRawTag(13);
            output.WriteFloat(ConfidenceThreshold);
          }
          if (Recall != 0F) {
            output.WriteRawTag(29);
            output.WriteFloat(Recall);
          }
          if (Precision != 0F) {
            output.WriteRawTag(37);
            output.WriteFloat(Precision);
          }
          if (F1Score != 0F) {
            output.WriteRawTag(45);
            output.WriteFloat(F1Score);
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
          if (ConfidenceThreshold != 0F) {
            size += 1 + 4;
          }
          if (Recall != 0F) {
            size += 1 + 4;
          }
          if (Precision != 0F) {
            size += 1 + 4;
          }
          if (F1Score != 0F) {
            size += 1 + 4;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(ConfidenceMetricsEntry other) {
          if (other == null) {
            return;
          }
          if (other.ConfidenceThreshold != 0F) {
            ConfidenceThreshold = other.ConfidenceThreshold;
          }
          if (other.Recall != 0F) {
            Recall = other.Recall;
          }
          if (other.Precision != 0F) {
            Precision = other.Precision;
          }
          if (other.F1Score != 0F) {
            F1Score = other.F1Score;
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
              case 13: {
                ConfidenceThreshold = input.ReadFloat();
                break;
              }
              case 29: {
                Recall = input.ReadFloat();
                break;
              }
              case 37: {
                Precision = input.ReadFloat();
                break;
              }
              case 45: {
                F1Score = input.ReadFloat();
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
              case 13: {
                ConfidenceThreshold = input.ReadFloat();
                break;
              }
              case 29: {
                Recall = input.ReadFloat();
                break;
              }
              case 37: {
                Precision = input.ReadFloat();
                break;
              }
              case 45: {
                F1Score = input.ReadFloat();
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
