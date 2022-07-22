// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/predict/params/image_object_detection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.Predict.Params {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/predict/params/image_object_detection.proto</summary>
  public static partial class ImageObjectDetectionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/predict/params/image_object_detection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImageObjectDetectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck1nb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9w",
            "YXJhbXMvaW1hZ2Vfb2JqZWN0X2RldGVjdGlvbi5wcm90bxIwZ29vZ2xlLmNs",
            "b3VkLmFpcGxhdGZvcm0udjEuc2NoZW1hLnByZWRpY3QucGFyYW1zGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvIl0KJEltYWdlT2JqZWN0RGV0ZWN0",
            "aW9uUHJlZGljdGlvblBhcmFtcxIcChRjb25maWRlbmNlX3RocmVzaG9sZBgB",
            "IAEoAhIXCg9tYXhfcHJlZGljdGlvbnMYAiABKAVC2gIKNGNvbS5nb29nbGUu",
            "Y2xvdWQuYWlwbGF0Zm9ybS52MS5zY2hlbWEucHJlZGljdC5wYXJhbXNCKUlt",
            "YWdlT2JqZWN0RGV0ZWN0aW9uUHJlZGljdGlvblBhcmFtc1Byb3RvUAFaVmdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvYWlw",
            "bGF0Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9wYXJhbXM7cGFyYW1zqgIwR29v",
            "Z2xlLkNsb3VkLkFJUGxhdGZvcm0uVjEuU2NoZW1hLlByZWRpY3QuUGFyYW1z",
            "ygIwR29vZ2xlXENsb3VkXEFJUGxhdGZvcm1cVjFcU2NoZW1hXFByZWRpY3Rc",
            "UGFyYW1z6gI2R29vZ2xlOjpDbG91ZDo6QUlQbGF0Zm9ybTo6VjE6OlNjaGVt",
            "YTo6UHJlZGljdDo6UGFyYW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.Predict.Params.ImageObjectDetectionPredictionParams), global::Google.Cloud.AIPlatform.V1.Schema.Predict.Params.ImageObjectDetectionPredictionParams.Parser, new[]{ "ConfidenceThreshold", "MaxPredictions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction model parameters for Image Object Detection.
  /// </summary>
  public sealed partial class ImageObjectDetectionPredictionParams : pb::IMessage<ImageObjectDetectionPredictionParams>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ImageObjectDetectionPredictionParams> _parser = new pb::MessageParser<ImageObjectDetectionPredictionParams>(() => new ImageObjectDetectionPredictionParams());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ImageObjectDetectionPredictionParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.Predict.Params.ImageObjectDetectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageObjectDetectionPredictionParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageObjectDetectionPredictionParams(ImageObjectDetectionPredictionParams other) : this() {
      confidenceThreshold_ = other.confidenceThreshold_;
      maxPredictions_ = other.maxPredictions_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageObjectDetectionPredictionParams Clone() {
      return new ImageObjectDetectionPredictionParams(this);
    }

    /// <summary>Field number for the "confidence_threshold" field.</summary>
    public const int ConfidenceThresholdFieldNumber = 1;
    private float confidenceThreshold_;
    /// <summary>
    /// The Model only returns predictions with at least this confidence score.
    /// Default value is 0.0
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float ConfidenceThreshold {
      get { return confidenceThreshold_; }
      set {
        confidenceThreshold_ = value;
      }
    }

    /// <summary>Field number for the "max_predictions" field.</summary>
    public const int MaxPredictionsFieldNumber = 2;
    private int maxPredictions_;
    /// <summary>
    /// The Model only returns up to that many top, by confidence score,
    /// predictions per instance. Note that number of returned predictions is also
    /// limited by metadata's predictionsLimit. Default value is 10.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxPredictions {
      get { return maxPredictions_; }
      set {
        maxPredictions_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ImageObjectDetectionPredictionParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ImageObjectDetectionPredictionParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ConfidenceThreshold, other.ConfidenceThreshold)) return false;
      if (MaxPredictions != other.MaxPredictions) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfidenceThreshold != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ConfidenceThreshold);
      if (MaxPredictions != 0) hash ^= MaxPredictions.GetHashCode();
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
      if (MaxPredictions != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxPredictions);
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
      if (MaxPredictions != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxPredictions);
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
      if (MaxPredictions != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxPredictions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ImageObjectDetectionPredictionParams other) {
      if (other == null) {
        return;
      }
      if (other.ConfidenceThreshold != 0F) {
        ConfidenceThreshold = other.ConfidenceThreshold;
      }
      if (other.MaxPredictions != 0) {
        MaxPredictions = other.MaxPredictions;
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
          case 16: {
            MaxPredictions = input.ReadInt32();
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
          case 16: {
            MaxPredictions = input.ReadInt32();
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
