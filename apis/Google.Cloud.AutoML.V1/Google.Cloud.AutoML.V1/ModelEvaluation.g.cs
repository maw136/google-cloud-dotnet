// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/model_evaluation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/model_evaluation.proto</summary>
  public static partial class ModelEvaluationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/model_evaluation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModelEvaluationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvY2xvdWQvYXV0b21sL3YxL21vZGVsX2V2YWx1YXRpb24ucHJv",
            "dG8SFmdvb2dsZS5jbG91ZC5hdXRvbWwudjEaGWdvb2dsZS9hcGkvcmVzb3Vy",
            "Y2UucHJvdG8aK2dvb2dsZS9jbG91ZC9hdXRvbWwvdjEvY2xhc3NpZmljYXRp",
            "b24ucHJvdG8aJmdvb2dsZS9jbG91ZC9hdXRvbWwvdjEvZGV0ZWN0aW9uLnBy",
            "b3RvGixnb29nbGUvY2xvdWQvYXV0b21sL3YxL3RleHRfZXh0cmFjdGlvbi5w",
            "cm90bxorZ29vZ2xlL2Nsb3VkL2F1dG9tbC92MS90ZXh0X3NlbnRpbWVudC5w",
            "cm90bxooZ29vZ2xlL2Nsb3VkL2F1dG9tbC92MS90cmFuc2xhdGlvbi5wcm90",
            "bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byK+BgoPTW9kZWxF",
            "dmFsdWF0aW9uEmQKIWNsYXNzaWZpY2F0aW9uX2V2YWx1YXRpb25fbWV0cmlj",
            "cxgIIAEoCzI3Lmdvb2dsZS5jbG91ZC5hdXRvbWwudjEuQ2xhc3NpZmljYXRp",
            "b25FdmFsdWF0aW9uTWV0cmljc0gAEl4KHnRyYW5zbGF0aW9uX2V2YWx1YXRp",
            "b25fbWV0cmljcxgJIAEoCzI0Lmdvb2dsZS5jbG91ZC5hdXRvbWwudjEuVHJh",
            "bnNsYXRpb25FdmFsdWF0aW9uTWV0cmljc0gAEnIKKWltYWdlX29iamVjdF9k",
            "ZXRlY3Rpb25fZXZhbHVhdGlvbl9tZXRyaWNzGAwgASgLMj0uZ29vZ2xlLmNs",
            "b3VkLmF1dG9tbC52MS5JbWFnZU9iamVjdERldGVjdGlvbkV2YWx1YXRpb25N",
            "ZXRyaWNzSAASYwohdGV4dF9zZW50aW1lbnRfZXZhbHVhdGlvbl9tZXRyaWNz",
            "GAsgASgLMjYuZ29vZ2xlLmNsb3VkLmF1dG9tbC52MS5UZXh0U2VudGltZW50",
            "RXZhbHVhdGlvbk1ldHJpY3NIABJlCiJ0ZXh0X2V4dHJhY3Rpb25fZXZhbHVh",
            "dGlvbl9tZXRyaWNzGA0gASgLMjcuZ29vZ2xlLmNsb3VkLmF1dG9tbC52MS5U",
            "ZXh0RXh0cmFjdGlvbkV2YWx1YXRpb25NZXRyaWNzSAASDAoEbmFtZRgBIAEo",
            "CRIaChJhbm5vdGF0aW9uX3NwZWNfaWQYAiABKAkSFAoMZGlzcGxheV9uYW1l",
            "GA8gASgJEi8KC2NyZWF0ZV90aW1lGAUgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcBIfChdldmFsdWF0ZWRfZXhhbXBsZV9jb3VudBgGIAEoBTqH",
            "AepBgwEKJWF1dG9tbC5nb29nbGVhcGlzLmNvbS9Nb2RlbEV2YWx1YXRpb24S",
            "WnByb2plY3RzL3twcm9qZWN0fS9sb2NhdGlvbnMve2xvY2F0aW9ufS9tb2Rl",
            "bHMve21vZGVsfS9tb2RlbEV2YWx1YXRpb25zL3ttb2RlbF9ldmFsdWF0aW9u",
            "fUIJCgdtZXRyaWNzQqoBChpjb20uZ29vZ2xlLmNsb3VkLmF1dG9tbC52MVAB",
            "Wjxnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3Vk",
            "L2F1dG9tbC92MTthdXRvbWyqAhZHb29nbGUuQ2xvdWQuQXV0b01MLlYxygIW",
            "R29vZ2xlXENsb3VkXEF1dG9NbFxWMeoCGUdvb2dsZTo6Q2xvdWQ6OkF1dG9N",
            "TDo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AutoML.V1.ClassificationReflection.Descriptor, global::Google.Cloud.AutoML.V1.DetectionReflection.Descriptor, global::Google.Cloud.AutoML.V1.TextExtractionReflection.Descriptor, global::Google.Cloud.AutoML.V1.TextSentimentReflection.Descriptor, global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.ModelEvaluation), global::Google.Cloud.AutoML.V1.ModelEvaluation.Parser, new[]{ "ClassificationEvaluationMetrics", "TranslationEvaluationMetrics", "ImageObjectDetectionEvaluationMetrics", "TextSentimentEvaluationMetrics", "TextExtractionEvaluationMetrics", "Name", "AnnotationSpecId", "DisplayName", "CreateTime", "EvaluatedExampleCount" }, new[]{ "Metrics" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Evaluation results of a model.
  /// </summary>
  public sealed partial class ModelEvaluation : pb::IMessage<ModelEvaluation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ModelEvaluation> _parser = new pb::MessageParser<ModelEvaluation>(() => new ModelEvaluation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ModelEvaluation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.ModelEvaluationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModelEvaluation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModelEvaluation(ModelEvaluation other) : this() {
      name_ = other.name_;
      annotationSpecId_ = other.annotationSpecId_;
      displayName_ = other.displayName_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      evaluatedExampleCount_ = other.evaluatedExampleCount_;
      switch (other.MetricsCase) {
        case MetricsOneofCase.ClassificationEvaluationMetrics:
          ClassificationEvaluationMetrics = other.ClassificationEvaluationMetrics.Clone();
          break;
        case MetricsOneofCase.TranslationEvaluationMetrics:
          TranslationEvaluationMetrics = other.TranslationEvaluationMetrics.Clone();
          break;
        case MetricsOneofCase.ImageObjectDetectionEvaluationMetrics:
          ImageObjectDetectionEvaluationMetrics = other.ImageObjectDetectionEvaluationMetrics.Clone();
          break;
        case MetricsOneofCase.TextSentimentEvaluationMetrics:
          TextSentimentEvaluationMetrics = other.TextSentimentEvaluationMetrics.Clone();
          break;
        case MetricsOneofCase.TextExtractionEvaluationMetrics:
          TextExtractionEvaluationMetrics = other.TextExtractionEvaluationMetrics.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModelEvaluation Clone() {
      return new ModelEvaluation(this);
    }

    /// <summary>Field number for the "classification_evaluation_metrics" field.</summary>
    public const int ClassificationEvaluationMetricsFieldNumber = 8;
    /// <summary>
    /// Model evaluation metrics for image, text, video and tables
    /// classification.
    /// Tables problem is considered a classification when the target column
    /// is CATEGORY DataType.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics ClassificationEvaluationMetrics {
      get { return metricsCase_ == MetricsOneofCase.ClassificationEvaluationMetrics ? (global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics) metrics_ : null; }
      set {
        metrics_ = value;
        metricsCase_ = value == null ? MetricsOneofCase.None : MetricsOneofCase.ClassificationEvaluationMetrics;
      }
    }

    /// <summary>Field number for the "translation_evaluation_metrics" field.</summary>
    public const int TranslationEvaluationMetricsFieldNumber = 9;
    /// <summary>
    /// Model evaluation metrics for translation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AutoML.V1.TranslationEvaluationMetrics TranslationEvaluationMetrics {
      get { return metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics ? (global::Google.Cloud.AutoML.V1.TranslationEvaluationMetrics) metrics_ : null; }
      set {
        metrics_ = value;
        metricsCase_ = value == null ? MetricsOneofCase.None : MetricsOneofCase.TranslationEvaluationMetrics;
      }
    }

    /// <summary>Field number for the "image_object_detection_evaluation_metrics" field.</summary>
    public const int ImageObjectDetectionEvaluationMetricsFieldNumber = 12;
    /// <summary>
    /// Model evaluation metrics for image object detection.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AutoML.V1.ImageObjectDetectionEvaluationMetrics ImageObjectDetectionEvaluationMetrics {
      get { return metricsCase_ == MetricsOneofCase.ImageObjectDetectionEvaluationMetrics ? (global::Google.Cloud.AutoML.V1.ImageObjectDetectionEvaluationMetrics) metrics_ : null; }
      set {
        metrics_ = value;
        metricsCase_ = value == null ? MetricsOneofCase.None : MetricsOneofCase.ImageObjectDetectionEvaluationMetrics;
      }
    }

    /// <summary>Field number for the "text_sentiment_evaluation_metrics" field.</summary>
    public const int TextSentimentEvaluationMetricsFieldNumber = 11;
    /// <summary>
    /// Evaluation metrics for text sentiment models.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AutoML.V1.TextSentimentEvaluationMetrics TextSentimentEvaluationMetrics {
      get { return metricsCase_ == MetricsOneofCase.TextSentimentEvaluationMetrics ? (global::Google.Cloud.AutoML.V1.TextSentimentEvaluationMetrics) metrics_ : null; }
      set {
        metrics_ = value;
        metricsCase_ = value == null ? MetricsOneofCase.None : MetricsOneofCase.TextSentimentEvaluationMetrics;
      }
    }

    /// <summary>Field number for the "text_extraction_evaluation_metrics" field.</summary>
    public const int TextExtractionEvaluationMetricsFieldNumber = 13;
    /// <summary>
    /// Evaluation metrics for text extraction models.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics TextExtractionEvaluationMetrics {
      get { return metricsCase_ == MetricsOneofCase.TextExtractionEvaluationMetrics ? (global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics) metrics_ : null; }
      set {
        metrics_ = value;
        metricsCase_ = value == null ? MetricsOneofCase.None : MetricsOneofCase.TextExtractionEvaluationMetrics;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Resource name of the model evaluation.
    /// Format:
    /// `projects/{project_id}/locations/{location_id}/models/{model_id}/modelEvaluations/{model_evaluation_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "annotation_spec_id" field.</summary>
    public const int AnnotationSpecIdFieldNumber = 2;
    private string annotationSpecId_ = "";
    /// <summary>
    /// Output only. The ID of the annotation spec that the model evaluation applies to. The
    /// The ID is empty for the overall model evaluation.
    /// For Tables annotation specs in the dataset do not exist and this ID is
    /// always not set, but for CLASSIFICATION
    /// [prediction_type-s][google.cloud.automl.v1.TablesModelMetadata.prediction_type]
    /// the
    /// [display_name][google.cloud.automl.v1.ModelEvaluation.display_name]
    /// field is used.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AnnotationSpecId {
      get { return annotationSpecId_; }
      set {
        annotationSpecId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 15;
    private string displayName_ = "";
    /// <summary>
    /// Output only. The value of
    /// [display_name][google.cloud.automl.v1.AnnotationSpec.display_name]
    /// at the moment when the model was trained. Because this field returns a
    /// value at model training time, for different models trained from the same
    /// dataset, the values may differ, since display names could had been changed
    /// between the two model's trainings. For Tables CLASSIFICATION
    /// [prediction_type-s][google.cloud.automl.v1.TablesModelMetadata.prediction_type]
    /// distinct values of the target column at the moment of the model evaluation
    /// are populated here.
    /// The display_name is empty for the overall model evaluation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this model evaluation was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "evaluated_example_count" field.</summary>
    public const int EvaluatedExampleCountFieldNumber = 6;
    private int evaluatedExampleCount_;
    /// <summary>
    /// Output only. The number of examples used for model evaluation, i.e. for
    /// which ground truth from time of model creation is compared against the
    /// predicted annotations created by the model.
    /// For overall ModelEvaluation (i.e. with annotation_spec_id not set) this is
    /// the total number of all examples used for evaluation.
    /// Otherwise, this is the count of examples that according to the ground
    /// truth were annotated by the
    /// [annotation_spec_id][google.cloud.automl.v1.ModelEvaluation.annotation_spec_id].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EvaluatedExampleCount {
      get { return evaluatedExampleCount_; }
      set {
        evaluatedExampleCount_ = value;
      }
    }

    private object metrics_;
    /// <summary>Enum of possible cases for the "metrics" oneof.</summary>
    public enum MetricsOneofCase {
      None = 0,
      ClassificationEvaluationMetrics = 8,
      TranslationEvaluationMetrics = 9,
      ImageObjectDetectionEvaluationMetrics = 12,
      TextSentimentEvaluationMetrics = 11,
      TextExtractionEvaluationMetrics = 13,
    }
    private MetricsOneofCase metricsCase_ = MetricsOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetricsOneofCase MetricsCase {
      get { return metricsCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMetrics() {
      metricsCase_ = MetricsOneofCase.None;
      metrics_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ModelEvaluation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ModelEvaluation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ClassificationEvaluationMetrics, other.ClassificationEvaluationMetrics)) return false;
      if (!object.Equals(TranslationEvaluationMetrics, other.TranslationEvaluationMetrics)) return false;
      if (!object.Equals(ImageObjectDetectionEvaluationMetrics, other.ImageObjectDetectionEvaluationMetrics)) return false;
      if (!object.Equals(TextSentimentEvaluationMetrics, other.TextSentimentEvaluationMetrics)) return false;
      if (!object.Equals(TextExtractionEvaluationMetrics, other.TextExtractionEvaluationMetrics)) return false;
      if (Name != other.Name) return false;
      if (AnnotationSpecId != other.AnnotationSpecId) return false;
      if (DisplayName != other.DisplayName) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (EvaluatedExampleCount != other.EvaluatedExampleCount) return false;
      if (MetricsCase != other.MetricsCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (metricsCase_ == MetricsOneofCase.ClassificationEvaluationMetrics) hash ^= ClassificationEvaluationMetrics.GetHashCode();
      if (metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics) hash ^= TranslationEvaluationMetrics.GetHashCode();
      if (metricsCase_ == MetricsOneofCase.ImageObjectDetectionEvaluationMetrics) hash ^= ImageObjectDetectionEvaluationMetrics.GetHashCode();
      if (metricsCase_ == MetricsOneofCase.TextSentimentEvaluationMetrics) hash ^= TextSentimentEvaluationMetrics.GetHashCode();
      if (metricsCase_ == MetricsOneofCase.TextExtractionEvaluationMetrics) hash ^= TextExtractionEvaluationMetrics.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (AnnotationSpecId.Length != 0) hash ^= AnnotationSpecId.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (EvaluatedExampleCount != 0) hash ^= EvaluatedExampleCount.GetHashCode();
      hash ^= (int) metricsCase_;
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
      if (AnnotationSpecId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AnnotationSpecId);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (EvaluatedExampleCount != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(EvaluatedExampleCount);
      }
      if (metricsCase_ == MetricsOneofCase.ClassificationEvaluationMetrics) {
        output.WriteRawTag(66);
        output.WriteMessage(ClassificationEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics) {
        output.WriteRawTag(74);
        output.WriteMessage(TranslationEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.TextSentimentEvaluationMetrics) {
        output.WriteRawTag(90);
        output.WriteMessage(TextSentimentEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.ImageObjectDetectionEvaluationMetrics) {
        output.WriteRawTag(98);
        output.WriteMessage(ImageObjectDetectionEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.TextExtractionEvaluationMetrics) {
        output.WriteRawTag(106);
        output.WriteMessage(TextExtractionEvaluationMetrics);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(122);
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
      if (AnnotationSpecId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AnnotationSpecId);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (EvaluatedExampleCount != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(EvaluatedExampleCount);
      }
      if (metricsCase_ == MetricsOneofCase.ClassificationEvaluationMetrics) {
        output.WriteRawTag(66);
        output.WriteMessage(ClassificationEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics) {
        output.WriteRawTag(74);
        output.WriteMessage(TranslationEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.TextSentimentEvaluationMetrics) {
        output.WriteRawTag(90);
        output.WriteMessage(TextSentimentEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.ImageObjectDetectionEvaluationMetrics) {
        output.WriteRawTag(98);
        output.WriteMessage(ImageObjectDetectionEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.TextExtractionEvaluationMetrics) {
        output.WriteRawTag(106);
        output.WriteMessage(TextExtractionEvaluationMetrics);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(122);
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
      if (metricsCase_ == MetricsOneofCase.ClassificationEvaluationMetrics) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClassificationEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TranslationEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.ImageObjectDetectionEvaluationMetrics) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ImageObjectDetectionEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.TextSentimentEvaluationMetrics) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TextSentimentEvaluationMetrics);
      }
      if (metricsCase_ == MetricsOneofCase.TextExtractionEvaluationMetrics) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TextExtractionEvaluationMetrics);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (AnnotationSpecId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AnnotationSpecId);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (EvaluatedExampleCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvaluatedExampleCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ModelEvaluation other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.AnnotationSpecId.Length != 0) {
        AnnotationSpecId = other.AnnotationSpecId;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.EvaluatedExampleCount != 0) {
        EvaluatedExampleCount = other.EvaluatedExampleCount;
      }
      switch (other.MetricsCase) {
        case MetricsOneofCase.ClassificationEvaluationMetrics:
          if (ClassificationEvaluationMetrics == null) {
            ClassificationEvaluationMetrics = new global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics();
          }
          ClassificationEvaluationMetrics.MergeFrom(other.ClassificationEvaluationMetrics);
          break;
        case MetricsOneofCase.TranslationEvaluationMetrics:
          if (TranslationEvaluationMetrics == null) {
            TranslationEvaluationMetrics = new global::Google.Cloud.AutoML.V1.TranslationEvaluationMetrics();
          }
          TranslationEvaluationMetrics.MergeFrom(other.TranslationEvaluationMetrics);
          break;
        case MetricsOneofCase.ImageObjectDetectionEvaluationMetrics:
          if (ImageObjectDetectionEvaluationMetrics == null) {
            ImageObjectDetectionEvaluationMetrics = new global::Google.Cloud.AutoML.V1.ImageObjectDetectionEvaluationMetrics();
          }
          ImageObjectDetectionEvaluationMetrics.MergeFrom(other.ImageObjectDetectionEvaluationMetrics);
          break;
        case MetricsOneofCase.TextSentimentEvaluationMetrics:
          if (TextSentimentEvaluationMetrics == null) {
            TextSentimentEvaluationMetrics = new global::Google.Cloud.AutoML.V1.TextSentimentEvaluationMetrics();
          }
          TextSentimentEvaluationMetrics.MergeFrom(other.TextSentimentEvaluationMetrics);
          break;
        case MetricsOneofCase.TextExtractionEvaluationMetrics:
          if (TextExtractionEvaluationMetrics == null) {
            TextExtractionEvaluationMetrics = new global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics();
          }
          TextExtractionEvaluationMetrics.MergeFrom(other.TextExtractionEvaluationMetrics);
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            AnnotationSpecId = input.ReadString();
            break;
          }
          case 42: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 48: {
            EvaluatedExampleCount = input.ReadInt32();
            break;
          }
          case 66: {
            global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics subBuilder = new global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics();
            if (metricsCase_ == MetricsOneofCase.ClassificationEvaluationMetrics) {
              subBuilder.MergeFrom(ClassificationEvaluationMetrics);
            }
            input.ReadMessage(subBuilder);
            ClassificationEvaluationMetrics = subBuilder;
            break;
          }
          case 74: {
            global::Google.Cloud.AutoML.V1.TranslationEvaluationMetrics subBuilder = new global::Google.Cloud.AutoML.V1.TranslationEvaluationMetrics();
            if (metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics) {
              subBuilder.MergeFrom(TranslationEvaluationMetrics);
            }
            input.ReadMessage(subBuilder);
            TranslationEvaluationMetrics = subBuilder;
            break;
          }
          case 90: {
            global::Google.Cloud.AutoML.V1.TextSentimentEvaluationMetrics subBuilder = new global::Google.Cloud.AutoML.V1.TextSentimentEvaluationMetrics();
            if (metricsCase_ == MetricsOneofCase.TextSentimentEvaluationMetrics) {
              subBuilder.MergeFrom(TextSentimentEvaluationMetrics);
            }
            input.ReadMessage(subBuilder);
            TextSentimentEvaluationMetrics = subBuilder;
            break;
          }
          case 98: {
            global::Google.Cloud.AutoML.V1.ImageObjectDetectionEvaluationMetrics subBuilder = new global::Google.Cloud.AutoML.V1.ImageObjectDetectionEvaluationMetrics();
            if (metricsCase_ == MetricsOneofCase.ImageObjectDetectionEvaluationMetrics) {
              subBuilder.MergeFrom(ImageObjectDetectionEvaluationMetrics);
            }
            input.ReadMessage(subBuilder);
            ImageObjectDetectionEvaluationMetrics = subBuilder;
            break;
          }
          case 106: {
            global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics subBuilder = new global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics();
            if (metricsCase_ == MetricsOneofCase.TextExtractionEvaluationMetrics) {
              subBuilder.MergeFrom(TextExtractionEvaluationMetrics);
            }
            input.ReadMessage(subBuilder);
            TextExtractionEvaluationMetrics = subBuilder;
            break;
          }
          case 122: {
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
            AnnotationSpecId = input.ReadString();
            break;
          }
          case 42: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 48: {
            EvaluatedExampleCount = input.ReadInt32();
            break;
          }
          case 66: {
            global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics subBuilder = new global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics();
            if (metricsCase_ == MetricsOneofCase.ClassificationEvaluationMetrics) {
              subBuilder.MergeFrom(ClassificationEvaluationMetrics);
            }
            input.ReadMessage(subBuilder);
            ClassificationEvaluationMetrics = subBuilder;
            break;
          }
          case 74: {
            global::Google.Cloud.AutoML.V1.TranslationEvaluationMetrics subBuilder = new global::Google.Cloud.AutoML.V1.TranslationEvaluationMetrics();
            if (metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics) {
              subBuilder.MergeFrom(TranslationEvaluationMetrics);
            }
            input.ReadMessage(subBuilder);
            TranslationEvaluationMetrics = subBuilder;
            break;
          }
          case 90: {
            global::Google.Cloud.AutoML.V1.TextSentimentEvaluationMetrics subBuilder = new global::Google.Cloud.AutoML.V1.TextSentimentEvaluationMetrics();
            if (metricsCase_ == MetricsOneofCase.TextSentimentEvaluationMetrics) {
              subBuilder.MergeFrom(TextSentimentEvaluationMetrics);
            }
            input.ReadMessage(subBuilder);
            TextSentimentEvaluationMetrics = subBuilder;
            break;
          }
          case 98: {
            global::Google.Cloud.AutoML.V1.ImageObjectDetectionEvaluationMetrics subBuilder = new global::Google.Cloud.AutoML.V1.ImageObjectDetectionEvaluationMetrics();
            if (metricsCase_ == MetricsOneofCase.ImageObjectDetectionEvaluationMetrics) {
              subBuilder.MergeFrom(ImageObjectDetectionEvaluationMetrics);
            }
            input.ReadMessage(subBuilder);
            ImageObjectDetectionEvaluationMetrics = subBuilder;
            break;
          }
          case 106: {
            global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics subBuilder = new global::Google.Cloud.AutoML.V1.TextExtractionEvaluationMetrics();
            if (metricsCase_ == MetricsOneofCase.TextExtractionEvaluationMetrics) {
              subBuilder.MergeFrom(TextExtractionEvaluationMetrics);
            }
            input.ReadMessage(subBuilder);
            TextExtractionEvaluationMetrics = subBuilder;
            break;
          }
          case 122: {
            DisplayName = input.ReadString();
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
