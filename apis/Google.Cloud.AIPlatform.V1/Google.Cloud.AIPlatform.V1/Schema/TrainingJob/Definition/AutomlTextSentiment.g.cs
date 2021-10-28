// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_text_sentiment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_text_sentiment.proto</summary>
  public static partial class AutomlTextSentimentReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/trainingjob/definition/automl_text_sentiment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AutomlTextSentimentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClRnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvdHJhaW5pbmdq",
            "b2IvZGVmaW5pdGlvbi9hdXRvbWxfdGV4dF9zZW50aW1lbnQucHJvdG8SOGdv",
            "b2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxLnNjaGVtYS50cmFpbmluZ2pvYi5k",
            "ZWZpbml0aW9uGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvInoKE0F1",
            "dG9NbFRleHRTZW50aW1lbnQSYwoGaW5wdXRzGAEgASgLMlMuZ29vZ2xlLmNs",
            "b3VkLmFpcGxhdGZvcm0udjEuc2NoZW1hLnRyYWluaW5nam9iLmRlZmluaXRp",
            "b24uQXV0b01sVGV4dFNlbnRpbWVudElucHV0cyIyChlBdXRvTWxUZXh0U2Vu",
            "dGltZW50SW5wdXRzEhUKDXNlbnRpbWVudF9tYXgYASABKAVC9QIKPGNvbS5n",
            "b29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5zY2hlbWEudHJhaW5pbmdqb2Iu",
            "ZGVmaW5pdGlvbkIYQXV0b01MVGV4dFNlbnRpbWVudFByb3RvUAFaYmdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvYWlwbGF0",
            "Zm9ybS92MS9zY2hlbWEvdHJhaW5pbmdqb2IvZGVmaW5pdGlvbjtkZWZpbml0",
            "aW9uqgI4R29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0uVjEuU2NoZW1hLlRyYWlu",
            "aW5nSm9iLkRlZmluaXRpb27KAjhHb29nbGVcQ2xvdWRcQUlQbGF0Zm9ybVxW",
            "MVxTY2hlbWFcVHJhaW5pbmdKb2JcRGVmaW5pdGlvbuoCPkdvb2dsZTo6Q2xv",
            "dWQ6OkFJUGxhdGZvcm06OlYxOjpTY2hlbWE6OlRyYWluaW5nSm9iOjpEZWZp",
            "bml0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlTextSentiment), global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlTextSentiment.Parser, new[]{ "Inputs" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlTextSentimentInputs), global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlTextSentimentInputs.Parser, new[]{ "SentimentMax" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A TrainingJob that trains and uploads an AutoML Text Sentiment Model.
  /// </summary>
  public sealed partial class AutoMlTextSentiment : pb::IMessage<AutoMlTextSentiment>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AutoMlTextSentiment> _parser = new pb::MessageParser<AutoMlTextSentiment>(() => new AutoMlTextSentiment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AutoMlTextSentiment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutomlTextSentimentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlTextSentiment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlTextSentiment(AutoMlTextSentiment other) : this() {
      inputs_ = other.inputs_ != null ? other.inputs_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlTextSentiment Clone() {
      return new AutoMlTextSentiment(this);
    }

    /// <summary>Field number for the "inputs" field.</summary>
    public const int InputsFieldNumber = 1;
    private global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlTextSentimentInputs inputs_;
    /// <summary>
    /// The input parameters of this TrainingJob.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlTextSentimentInputs Inputs {
      get { return inputs_; }
      set {
        inputs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AutoMlTextSentiment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AutoMlTextSentiment other) {
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
    public void MergeFrom(AutoMlTextSentiment other) {
      if (other == null) {
        return;
      }
      if (other.inputs_ != null) {
        if (inputs_ == null) {
          Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlTextSentimentInputs();
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
              Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlTextSentimentInputs();
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
              Inputs = new global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutoMlTextSentimentInputs();
            }
            input.ReadMessage(Inputs);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AutoMlTextSentimentInputs : pb::IMessage<AutoMlTextSentimentInputs>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AutoMlTextSentimentInputs> _parser = new pb::MessageParser<AutoMlTextSentimentInputs>(() => new AutoMlTextSentimentInputs());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AutoMlTextSentimentInputs> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.AutomlTextSentimentReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlTextSentimentInputs() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlTextSentimentInputs(AutoMlTextSentimentInputs other) : this() {
      sentimentMax_ = other.sentimentMax_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AutoMlTextSentimentInputs Clone() {
      return new AutoMlTextSentimentInputs(this);
    }

    /// <summary>Field number for the "sentiment_max" field.</summary>
    public const int SentimentMaxFieldNumber = 1;
    private int sentimentMax_;
    /// <summary>
    /// A sentiment is expressed as an integer ordinal, where higher value
    /// means a more positive sentiment. The range of sentiments that will be used
    /// is between 0 and sentimentMax (inclusive on both ends), and all the values
    /// in the range must be represented in the dataset before a model can be
    /// created.
    /// Only the Annotations with this sentimentMax will be used for training.
    /// sentimentMax value must be between 1 and 10 (inclusive).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SentimentMax {
      get { return sentimentMax_; }
      set {
        sentimentMax_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AutoMlTextSentimentInputs);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AutoMlTextSentimentInputs other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SentimentMax != other.SentimentMax) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SentimentMax != 0) hash ^= SentimentMax.GetHashCode();
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
      if (SentimentMax != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SentimentMax);
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
      if (SentimentMax != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SentimentMax);
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
      if (SentimentMax != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SentimentMax);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AutoMlTextSentimentInputs other) {
      if (other == null) {
        return;
      }
      if (other.SentimentMax != 0) {
        SentimentMax = other.SentimentMax;
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
            SentimentMax = input.ReadInt32();
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
            SentimentMax = input.ReadInt32();
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
