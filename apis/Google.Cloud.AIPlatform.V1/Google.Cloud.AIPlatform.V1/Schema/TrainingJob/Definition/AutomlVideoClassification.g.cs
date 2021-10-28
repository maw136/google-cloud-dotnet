// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_video_classification.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_video_classification.proto</summary>
  public static partial class AutomlVideoClassificationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_video_classification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AutomlVideoClassificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Clpnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvdHJhaW5pbmdq",
            "b2IvZGVmaW5pdGlvbi9hdXRvbWxfdmlkZW9fY2xhc3NpZmljYXRpb24ucHJv",
            "dG8SOGdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxLnNjaGVtYS50cmFpbmlu",
            "Z2pvYi5kZWZpbml0aW9uGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3Rv",
            "IoYBChlBdXRvTWxWaWRlb0NsYXNzaWZpY2F0aW9uEmkKBmlucHV0cxgBIAEo",
            "CzJZLmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxLnNjaGVtYS50cmFpbmlu",
            "Z2pvYi5kZWZpbml0aW9uLkF1dG9NbFZpZGVvQ2xhc3NpZmljYXRpb25JbnB1",
            "dHMihQIKH0F1dG9NbFZpZGVvQ2xhc3NpZmljYXRpb25JbnB1dHMSdwoKbW9k",
            "ZWxfdHlwZRgBIAEoDjJjLmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxLnNj",
            "aGVtYS50cmFpbmluZ2pvYi5kZWZpbml0aW9uLkF1dG9NbFZpZGVvQ2xhc3Np",
            "ZmljYXRpb25JbnB1dHMuTW9kZWxUeXBlImkKCU1vZGVsVHlwZRIaChZNT0RF",
            "TF9UWVBFX1VOU1BFQ0lGSUVEEAASCQoFQ0xPVUQQARIWChJNT0JJTEVfVkVS",
            "U0FUSUxFXzEQAhIdChlNT0JJTEVfSkVUU09OX1ZFUlNBVElMRV8xEANC+wIK",
            "PGNvbS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5zY2hlbWEudHJhaW5p",
            "bmdqb2IuZGVmaW5pdGlvbkIeQXV0b01MVmlkZW9DbGFzc2lmaWNhdGlvblBy",
            "b3RvUAFaYmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "Y2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvdHJhaW5pbmdqb2IvZGVmaW5p",
            "dGlvbjtkZWZpbml0aW9uqgI4R29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0uVjEu",
            "U2NoZW1hLlRyYWluaW5nSm9iLkRlZmluaXRpb27KAjhHb29nbGVcQ2xvdWRc",
            "QUlQbGF0Zm9ybVxWMVxTY2hlbWFcVHJhaW5pbmdKb2JcRGVmaW5pdGlvbuoC",
            "Pkdvb2dsZTo6Q2xvdWQ6OkFJUGxhdGZvcm06OlYxOjpTY2hlbWE6OlRyYWlu",
            "aW5nSm9iOjpEZWZpbml0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassification), global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassification.Parser, new[]{ "Inputs" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs), global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Parser, new[]{ "ModelType" }, null, new[]{ typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Types.ModelType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A TrainingJob that trains and uploads an AutoML Video Classification Model.
  /// </summary>
  public sealed partial class AutoMlVideoClassification : pb::IMessage<AutoMlVideoClassification>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AutoMlVideoClassification> _parser = new pb::MessageParser<AutoMlVideoClassification>(() => new AutoMlVideoClassification());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AutoMlVideoClassification> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutomlVideoClassificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoClassification() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoClassification(AutoMlVideoClassification other) : this() {
      inputs_ = other.inputs_ != null ? other.inputs_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoClassification Clone() {
      return new AutoMlVideoClassification(this);
    }

    /// <summary>Field number for the "inputs" field.</summary>
    public const int InputsFieldNumber = 1;
    private global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs inputs_;
    /// <summary>
    /// The input parameters of this TrainingJob.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs Inputs {
      get { return inputs_; }
      set {
        inputs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AutoMlVideoClassification);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AutoMlVideoClassification other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Inputs, other.Inputs)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (inputs_ != null) hash ^= Inputs.GetHashCode();
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
      if (inputs_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Inputs);
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
      if (inputs_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Inputs);
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
      if (inputs_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Inputs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AutoMlVideoClassification other) {
      if (other == null) {
        return;
      }
      if (other.inputs_ != null) {
        if (inputs_ == null) {
          Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs();
        }
        Inputs.MergeFrom(other.Inputs);
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
            if (inputs_ == null) {
              Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs();
            }
            input.ReadMessage(Inputs);
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
            if (inputs_ == null) {
              Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs();
            }
            input.ReadMessage(Inputs);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AutoMlVideoClassificationInputs : pb::IMessage<AutoMlVideoClassificationInputs>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AutoMlVideoClassificationInputs> _parser = new pb::MessageParser<AutoMlVideoClassificationInputs>(() => new AutoMlVideoClassificationInputs());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AutoMlVideoClassificationInputs> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutomlVideoClassificationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoClassificationInputs() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoClassificationInputs(AutoMlVideoClassificationInputs other) : this() {
      modelType_ = other.modelType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoClassificationInputs Clone() {
      return new AutoMlVideoClassificationInputs(this);
    }

    /// <summary>Field number for the "model_type" field.</summary>
    public const int ModelTypeFieldNumber = 1;
    private global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Types.ModelType modelType_ = global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Types.ModelType.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Types.ModelType ModelType {
      get { return modelType_; }
      set {
        modelType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AutoMlVideoClassificationInputs);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AutoMlVideoClassificationInputs other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModelType != other.ModelType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Types.ModelType.Unspecified) hash ^= ModelType.GetHashCode();
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
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Types.ModelType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ModelType);
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
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Types.ModelType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ModelType);
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
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Types.ModelType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModelType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AutoMlVideoClassificationInputs other) {
      if (other == null) {
        return;
      }
      if (other.ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Types.ModelType.Unspecified) {
        ModelType = other.ModelType;
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
          case 8: {
            ModelType = (global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Types.ModelType) input.ReadEnum();
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
          case 8: {
            ModelType = (global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoClassificationInputs.Types.ModelType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AutoMlVideoClassificationInputs message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum ModelType {
        /// <summary>
        /// Should not be set.
        /// </summary>
        [pbr::OriginalName("MODEL_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// A model best tailored to be used within Google Cloud, and which cannot
        /// be exported. Default.
        /// </summary>
        [pbr::OriginalName("CLOUD")] Cloud = 1,
        /// <summary>
        /// A model that, in addition to being available within Google Cloud, can
        /// also be exported (see ModelService.ExportModel) as a TensorFlow or
        /// TensorFlow Lite model and used on a mobile or edge device afterwards.
        /// </summary>
        [pbr::OriginalName("MOBILE_VERSATILE_1")] MobileVersatile1 = 2,
        /// <summary>
        /// A model that, in addition to being available within Google Cloud, can
        /// also be exported (see ModelService.ExportModel) to a Jetson device
        /// afterwards.
        /// </summary>
        [pbr::OriginalName("MOBILE_JETSON_VERSATILE_1")] MobileJetsonVersatile1 = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
