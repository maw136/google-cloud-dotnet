// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/predict/instance/image_classification.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.Predict.Instance {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/predict/instance/image_classification.proto</summary>
  public static partial class ImageClassificationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/predict/instance/image_classification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImageClassificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck1nb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9p",
            "bnN0YW5jZS9pbWFnZV9jbGFzc2lmaWNhdGlvbi5wcm90bxIyZ29vZ2xlLmNs",
            "b3VkLmFpcGxhdGZvcm0udjEuc2NoZW1hLnByZWRpY3QuaW5zdGFuY2UiSwol",
            "SW1hZ2VDbGFzc2lmaWNhdGlvblByZWRpY3Rpb25JbnN0YW5jZRIPCgdjb250",
            "ZW50GAEgASgJEhEKCW1pbWVfdHlwZRgCIAEoCULnAgo2Y29tLmdvb2dsZS5j",
            "bG91ZC5haXBsYXRmb3JtLnYxLnNjaGVtYS5wcmVkaWN0Lmluc3RhbmNlQipJ",
            "bWFnZUNsYXNzaWZpY2F0aW9uUHJlZGljdGlvbkluc3RhbmNlUHJvdG9QAVpa",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9h",
            "aXBsYXRmb3JtL3YxL3NjaGVtYS9wcmVkaWN0L2luc3RhbmNlO2luc3RhbmNl",
            "qgIyR29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0uVjEuU2NoZW1hLlByZWRpY3Qu",
            "SW5zdGFuY2XKAjJHb29nbGVcQ2xvdWRcQUlQbGF0Zm9ybVxWMVxTY2hlbWFc",
            "UHJlZGljdFxJbnN0YW5jZeoCOEdvb2dsZTo6Q2xvdWQ6OkFJUGxhdGZvcm06",
            "OlYxOjpTY2hlbWE6OlByZWRpY3Q6Okluc3RhbmNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.ImageClassificationPredictionInstance), global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.ImageClassificationPredictionInstance.Parser, new[]{ "Content", "MimeType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction input format for Image Classification.
  /// </summary>
  public sealed partial class ImageClassificationPredictionInstance : pb::IMessage<ImageClassificationPredictionInstance>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ImageClassificationPredictionInstance> _parser = new pb::MessageParser<ImageClassificationPredictionInstance>(() => new ImageClassificationPredictionInstance());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ImageClassificationPredictionInstance> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.ImageClassificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageClassificationPredictionInstance() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageClassificationPredictionInstance(ImageClassificationPredictionInstance other) : this() {
      content_ = other.content_;
      mimeType_ = other.mimeType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageClassificationPredictionInstance Clone() {
      return new ImageClassificationPredictionInstance(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private string content_ = "";
    /// <summary>
    /// The image bytes or Cloud Storage URI to make the prediction on.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mime_type" field.</summary>
    public const int MimeTypeFieldNumber = 2;
    private string mimeType_ = "";
    /// <summary>
    /// The MIME type of the content of the image. Only the images in below listed
    /// MIME types are supported.
    /// - image/jpeg
    /// - image/gif
    /// - image/png
    /// - image/webp
    /// - image/bmp
    /// - image/tiff
    /// - image/vnd.microsoft.icon
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MimeType {
      get { return mimeType_; }
      set {
        mimeType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ImageClassificationPredictionInstance);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ImageClassificationPredictionInstance other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (MimeType != other.MimeType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (MimeType.Length != 0) hash ^= MimeType.GetHashCode();
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
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (MimeType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MimeType);
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
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (MimeType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MimeType);
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
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (MimeType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MimeType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ImageClassificationPredictionInstance other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.MimeType.Length != 0) {
        MimeType = other.MimeType;
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
            Content = input.ReadString();
            break;
          }
          case 18: {
            MimeType = input.ReadString();
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
            Content = input.ReadString();
            break;
          }
          case 18: {
            MimeType = input.ReadString();
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
