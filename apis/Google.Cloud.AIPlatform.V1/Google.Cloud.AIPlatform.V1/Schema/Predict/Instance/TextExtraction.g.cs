// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/predict/instance/text_extraction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.Predict.Instance {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/predict/instance/text_extraction.proto</summary>
  public static partial class TextExtractionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/predict/instance/text_extraction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TextExtractionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckhnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9p",
            "bnN0YW5jZS90ZXh0X2V4dHJhY3Rpb24ucHJvdG8SMmdvb2dsZS5jbG91ZC5h",
            "aXBsYXRmb3JtLnYxLnNjaGVtYS5wcmVkaWN0Lmluc3RhbmNlIlMKIFRleHRF",
            "eHRyYWN0aW9uUHJlZGljdGlvbkluc3RhbmNlEg8KB2NvbnRlbnQYASABKAkS",
            "EQoJbWltZV90eXBlGAIgASgJEgsKA2tleRgDIAEoCULiAgo2Y29tLmdvb2ds",
            "ZS5jbG91ZC5haXBsYXRmb3JtLnYxLnNjaGVtYS5wcmVkaWN0Lmluc3RhbmNl",
            "QiVUZXh0RXh0cmFjdGlvblByZWRpY3Rpb25JbnN0YW5jZVByb3RvUAFaWmdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvYWlw",
            "bGF0Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9pbnN0YW5jZTtpbnN0YW5jZaoC",
            "Mkdvb2dsZS5DbG91ZC5BSVBsYXRmb3JtLlYxLlNjaGVtYS5QcmVkaWN0Lklu",
            "c3RhbmNlygIyR29vZ2xlXENsb3VkXEFJUGxhdGZvcm1cVjFcU2NoZW1hXFBy",
            "ZWRpY3RcSW5zdGFuY2XqAjhHb29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpW",
            "MTo6U2NoZW1hOjpQcmVkaWN0OjpJbnN0YW5jZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.TextExtractionPredictionInstance), global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.TextExtractionPredictionInstance.Parser, new[]{ "Content", "MimeType", "Key" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction input format for Text Extraction.
  /// </summary>
  public sealed partial class TextExtractionPredictionInstance : pb::IMessage<TextExtractionPredictionInstance>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TextExtractionPredictionInstance> _parser = new pb::MessageParser<TextExtractionPredictionInstance>(() => new TextExtractionPredictionInstance());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TextExtractionPredictionInstance> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.TextExtractionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextExtractionPredictionInstance() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextExtractionPredictionInstance(TextExtractionPredictionInstance other) : this() {
      content_ = other.content_;
      mimeType_ = other.mimeType_;
      key_ = other.key_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextExtractionPredictionInstance Clone() {
      return new TextExtractionPredictionInstance(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private string content_ = "";
    /// <summary>
    /// The text snippet to make the predictions on.
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
    /// The MIME type of the text snippet. The supported MIME types are listed
    /// below.
    /// - text/plain
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MimeType {
      get { return mimeType_; }
      set {
        mimeType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 3;
    private string key_ = "";
    /// <summary>
    /// This field is only used for batch prediction. If a key is provided, the
    /// batch prediction result will by mapped to this key. If omitted, then the
    /// batch prediction result will contain the entire input instance. Vertex AI
    /// will not check if keys in the request are duplicates, so it is up to the
    /// caller to ensure the keys are unique.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TextExtractionPredictionInstance);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TextExtractionPredictionInstance other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (MimeType != other.MimeType) return false;
      if (Key != other.Key) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (MimeType.Length != 0) hash ^= MimeType.GetHashCode();
      if (Key.Length != 0) hash ^= Key.GetHashCode();
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
      if (Key.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Key);
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
      if (Key.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Key);
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
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TextExtractionPredictionInstance other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.MimeType.Length != 0) {
        MimeType = other.MimeType;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
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
          case 26: {
            Key = input.ReadString();
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
          case 26: {
            Key = input.ReadString();
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
