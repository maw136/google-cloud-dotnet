// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_video_object_tracking.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_video_object_tracking.proto</summary>
  public static partial class AutomlVideoObjectTrackingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_video_object_tracking.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AutomlVideoObjectTrackingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cltnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvdHJhaW5pbmdq",
            "b2IvZGVmaW5pdGlvbi9hdXRvbWxfdmlkZW9fb2JqZWN0X3RyYWNraW5nLnBy",
            "b3RvEjhnb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5zY2hlbWEudHJhaW5p",
            "bmdqb2IuZGVmaW5pdGlvbhocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "byKGAQoZQXV0b01sVmlkZW9PYmplY3RUcmFja2luZxJpCgZpbnB1dHMYASAB",
            "KAsyWS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5zY2hlbWEudHJhaW5p",
            "bmdqb2IuZGVmaW5pdGlvbi5BdXRvTWxWaWRlb09iamVjdFRyYWNraW5nSW5w",
            "dXRzIuUCCh9BdXRvTWxWaWRlb09iamVjdFRyYWNraW5nSW5wdXRzEncKCm1v",
            "ZGVsX3R5cGUYASABKA4yYy5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5z",
            "Y2hlbWEudHJhaW5pbmdqb2IuZGVmaW5pdGlvbi5BdXRvTWxWaWRlb09iamVj",
            "dFRyYWNraW5nSW5wdXRzLk1vZGVsVHlwZSLIAQoJTW9kZWxUeXBlEhoKFk1P",
            "REVMX1RZUEVfVU5TUEVDSUZJRUQQABIJCgVDTE9VRBABEhYKEk1PQklMRV9W",
            "RVJTQVRJTEVfMRACEhwKGE1PQklMRV9DT1JBTF9WRVJTQVRJTEVfMRADEh4K",
            "Gk1PQklMRV9DT1JBTF9MT1dfTEFURU5DWV8xEAQSHQoZTU9CSUxFX0pFVFNP",
            "Tl9WRVJTQVRJTEVfMRAFEh8KG01PQklMRV9KRVRTT05fTE9XX0xBVEVOQ1lf",
            "MRAGQvsCCjxjb20uZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuc2NoZW1h",
            "LnRyYWluaW5nam9iLmRlZmluaXRpb25CHkF1dG9NTFZpZGVvT2JqZWN0VHJh",
            "Y2tpbmdQcm90b1ABWmJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2Nsb3VkL2FpcGxhdGZvcm0vdjEvc2NoZW1hL3RyYWluaW5nam9i",
            "L2RlZmluaXRpb247ZGVmaW5pdGlvbqoCOEdvb2dsZS5DbG91ZC5BSVBsYXRm",
            "b3JtLlYxLlNjaGVtYS5UcmFpbmluZ0pvYi5EZWZpbml0aW9uygI4R29vZ2xl",
            "XENsb3VkXEFJUGxhdGZvcm1cVjFcU2NoZW1hXFRyYWluaW5nSm9iXERlZmlu",
            "aXRpb27qAj5Hb29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMTo6U2NoZW1h",
            "OjpUcmFpbmluZ0pvYjo6RGVmaW5pdGlvbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTracking), global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTracking.Parser, new[]{ "Inputs" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs), global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Parser, new[]{ "ModelType" }, null, new[]{ typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Types.ModelType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A TrainingJob that trains and uploads an AutoML Video ObjectTracking Model.
  /// </summary>
  public sealed partial class AutoMlVideoObjectTracking : pb::IMessage<AutoMlVideoObjectTracking>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AutoMlVideoObjectTracking> _parser = new pb::MessageParser<AutoMlVideoObjectTracking>(() => new AutoMlVideoObjectTracking());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AutoMlVideoObjectTracking> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutomlVideoObjectTrackingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoObjectTracking() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoObjectTracking(AutoMlVideoObjectTracking other) : this() {
      inputs_ = other.inputs_ != null ? other.inputs_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoObjectTracking Clone() {
      return new AutoMlVideoObjectTracking(this);
    }

    /// <summary>Field number for the "inputs" field.</summary>
    public const int InputsFieldNumber = 1;
    private global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs inputs_;
    /// <summary>
    /// The input parameters of this TrainingJob.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs Inputs {
      get { return inputs_; }
      set {
        inputs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AutoMlVideoObjectTracking);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AutoMlVideoObjectTracking other) {
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
    public void MergeFrom(AutoMlVideoObjectTracking other) {
      if (other == null) {
        return;
      }
      if (other.inputs_ != null) {
        if (inputs_ == null) {
          Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs();
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
              Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs();
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
              Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs();
            }
            input.ReadMessage(Inputs);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AutoMlVideoObjectTrackingInputs : pb::IMessage<AutoMlVideoObjectTrackingInputs>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AutoMlVideoObjectTrackingInputs> _parser = new pb::MessageParser<AutoMlVideoObjectTrackingInputs>(() => new AutoMlVideoObjectTrackingInputs());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AutoMlVideoObjectTrackingInputs> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutomlVideoObjectTrackingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoObjectTrackingInputs() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoObjectTrackingInputs(AutoMlVideoObjectTrackingInputs other) : this() {
      modelType_ = other.modelType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlVideoObjectTrackingInputs Clone() {
      return new AutoMlVideoObjectTrackingInputs(this);
    }

    /// <summary>Field number for the "model_type" field.</summary>
    public const int ModelTypeFieldNumber = 1;
    private global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Types.ModelType modelType_ = global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Types.ModelType.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Types.ModelType ModelType {
      get { return modelType_; }
      set {
        modelType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AutoMlVideoObjectTrackingInputs);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AutoMlVideoObjectTrackingInputs other) {
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
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Types.ModelType.Unspecified) hash ^= ModelType.GetHashCode();
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
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Types.ModelType.Unspecified) {
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
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Types.ModelType.Unspecified) {
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
      if (ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Types.ModelType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModelType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AutoMlVideoObjectTrackingInputs other) {
      if (other == null) {
        return;
      }
      if (other.ModelType != global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Types.ModelType.Unspecified) {
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
            ModelType = (global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Types.ModelType) input.ReadEnum();
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
            ModelType = (global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlVideoObjectTrackingInputs.Types.ModelType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AutoMlVideoObjectTrackingInputs message type.</summary>
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
        /// A versatile model that is meant to be exported (see
        /// ModelService.ExportModel) and used on a Google Coral device.
        /// </summary>
        [pbr::OriginalName("MOBILE_CORAL_VERSATILE_1")] MobileCoralVersatile1 = 3,
        /// <summary>
        /// A model that trades off quality for low latency, to be exported (see
        /// ModelService.ExportModel) and used on a Google Coral device.
        /// </summary>
        [pbr::OriginalName("MOBILE_CORAL_LOW_LATENCY_1")] MobileCoralLowLatency1 = 4,
        /// <summary>
        /// A versatile model that is meant to be exported (see
        /// ModelService.ExportModel) and used on an NVIDIA Jetson device.
        /// </summary>
        [pbr::OriginalName("MOBILE_JETSON_VERSATILE_1")] MobileJetsonVersatile1 = 5,
        /// <summary>
        /// A model that trades off quality for low latency, to be exported (see
        /// ModelService.ExportModel) and used on an NVIDIA Jetson device.
        /// </summary>
        [pbr::OriginalName("MOBILE_JETSON_LOW_LATENCY_1")] MobileJetsonLowLatency1 = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
