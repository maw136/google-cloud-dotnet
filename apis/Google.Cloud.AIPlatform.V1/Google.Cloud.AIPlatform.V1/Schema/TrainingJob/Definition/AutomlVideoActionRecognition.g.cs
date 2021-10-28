// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_video_action_recognition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_video_action_recognition.proto</summary>
  public static partial class AutomlVideoActionRecognitionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_video_action_recognition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AutomlVideoActionRecognitionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cl5nb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvdHJhaW5pbmdq",
            "b2IvZGVmaW5pdGlvbi9hdXRvbWxfdmlkZW9fYWN0aW9uX3JlY29nbml0aW9u",
            "LnByb3RvEjhnb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5zY2hlbWEudHJh",
            "aW5pbmdqb2IuZGVmaW5pdGlvbhocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5w",
            "cm90byKMAQocQXV0b01sVmlkZW9BY3Rpb25SZWNvZ25pdGlvbhJsCgZpbnB1",
            "dHMYASABKAsyXC5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5zY2hlbWEu",
            "dHJhaW5pbmdqb2IuZGVmaW5pdGlvbi5BdXRvTWxWaWRlb0FjdGlvblJlY29n",
            "bml0aW9uSW5wdXRzIqoCCiJBdXRvTWxWaWRlb0FjdGlvblJlY29nbml0aW9u",
            "SW5wdXRzEnoKCm1vZGVsX3R5cGUYASABKA4yZi5nb29nbGUuY2xvdWQuYWlw",
            "bGF0Zm9ybS52MS5zY2hlbWEudHJhaW5pbmdqb2IuZGVmaW5pdGlvbi5BdXRv",
            "TWxWaWRlb0FjdGlvblJlY29nbml0aW9uSW5wdXRzLk1vZGVsVHlwZSKHAQoJ",
            "TW9kZWxUeXBlEhoKFk1PREVMX1RZUEVfVU5TUEVDSUZJRUQQABIJCgVDTE9V",
            "RBABEhYKEk1PQklMRV9WRVJTQVRJTEVfMRACEh0KGU1PQklMRV9KRVRTT05f",
            "VkVSU0FUSUxFXzEQAxIcChhNT0JJTEVfQ09SQUxfVkVSU0FUSUxFXzEQBEL+",
            "Ago8Y29tLmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxLnNjaGVtYS50cmFp",
            "bmluZ2pvYi5kZWZpbml0aW9uQiFBdXRvTUxWaWRlb0FjdGlvblJlY29nbml0",
            "aW9uUHJvdG9QAVpiZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9jbG91ZC9haXBsYXRmb3JtL3YxL3NjaGVtYS90cmFpbmluZ2pvYi9k",
            "ZWZpbml0aW9uO2RlZmluaXRpb26qAjhHb29nbGUuQ2xvdWQuQUlQbGF0Zm9y",
            "bS5WMS5TY2hlbWEuVHJhaW5pbmdKb2IuRGVmaW5pdGlvbsoCOEdvb2dsZVxD",
            "bG91ZFxBSVBsYXRmb3JtXFYxXFNjaGVtYVxUcmFpbmluZ0pvYlxEZWZpbml0",
            "aW9u6gI+R29vZ2xlOjpDbG91ZDo6QUlQbGF0Zm9ybTo6VjE6OlNjaGVtYTo6",
            "VHJhaW5pbmdKb2I6OkRlZmluaXRpb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognition), global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognition.Parser, new[]{ "Inputs" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs), global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Parser, new[]{ "ModelType" }, null, new[]{ typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Types.ModelType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A TrainingJob that trains and uploads an AutoML Video Action Recognition
  /// Model.
  /// </summary>
  public sealed partial class AutoMlVideoActionRecognition : pb::IMessage<AutoMlVideoActionRecognition>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AutoMlVideoActionRecognition> _parser = new pb::MessageParser<AutoMlVideoActionRecognition>(() => new AutoMlVideoActionRecognition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AutoMlVideoActionRecognition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutomlVideoActionRecognitionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoActionRecognition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoActionRecognition(AutoMlVideoActionRecognition other) : this() {
      inputs_ = other.inputs_ != null ? other.inputs_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoActionRecognition Clone() {
      return new AutoMlVideoActionRecognition(this);
    }

    /// <summary>Field number for the "inputs" field.</summary>
    public const int InputsFieldNumber = 1;
    private global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs inputs_;
    /// <summary>
    /// The input parameters of this TrainingJob.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs Inputs {
      get { return inputs_; }
      set {
        inputs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AutoMlVideoActionRecognition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AutoMlVideoActionRecognition other) {
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
    public void MergeFrom(AutoMlVideoActionRecognition other) {
      if (other == null) {
        return;
      }
      if (other.inputs_ != null) {
        if (inputs_ == null) {
          Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs();
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
              Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs();
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
              Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs();
            }
            input.ReadMessage(Inputs);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AutoMlVideoActionRecognitionInputs : pb::IMessage<AutoMlVideoActionRecognitionInputs>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AutoMlVideoActionRecognitionInputs> _parser = new pb::MessageParser<AutoMlVideoActionRecognitionInputs>(() => new AutoMlVideoActionRecognitionInputs());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AutoMlVideoActionRecognitionInputs> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutomlVideoActionRecognitionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoActionRecognitionInputs() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoActionRecognitionInputs(AutoMlVideoActionRecognitionInputs other) : this() {
      modelType_ = other.modelType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoActionRecognitionInputs Clone() {
      return new AutoMlVideoActionRecognitionInputs(this);
    }

    /// <summary>Field number for the "model_type" field.</summary>
    public const int ModelTypeFieldNumber = 1;
    private global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Types.ModelType modelType_ = global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Types.ModelType.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Types.ModelType ModelType {
      get { return modelType_; }
      set {
        modelType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AutoMlVideoActionRecognitionInputs);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AutoMlVideoActionRecognitionInputs other) {
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
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Types.ModelType.Unspecified) hash ^= ModelType.GetHashCode();
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
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Types.ModelType.Unspecified) {
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
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Types.ModelType.Unspecified) {
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
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Types.ModelType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModelType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AutoMlVideoActionRecognitionInputs other) {
      if (other == null) {
        return;
      }
      if (other.ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Types.ModelType.Unspecified) {
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
            ModelType = (global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Types.ModelType) input.ReadEnum();
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
            ModelType = (global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoActionRecognitionInputs.Types.ModelType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AutoMlVideoActionRecognitionInputs message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum ModelType {
        /// <summary>
        /// Should not be set.
        /// </summary>
        [pbr::OriginalName("MODEL_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// A model best tailored to be used within Google Cloud, and which c annot
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
        /// <summary>
        /// A model that, in addition to being available within Google Cloud, can
        /// also be exported (see ModelService.ExportModel) as a TensorFlow or
        /// TensorFlow Lite model and used on a Coral device afterwards.
        /// </summary>
        [pbr::OriginalName("MOBILE_CORAL_VERSATILE_1")] MobileCoralVersatile1 = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
