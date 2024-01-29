// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/container.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/container.proto</summary>
  public static partial class ContainerReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/container.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContainerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEvY29udGFpbmVyLnBy",
            "b3RvEh5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIudjEaKmdvb2dsZS9j",
            "bG91ZC9zZWN1cml0eWNlbnRlci92MS9sYWJlbC5wcm90byJvCglDb250YWlu",
            "ZXISDAoEbmFtZRgBIAEoCRILCgN1cmkYAiABKAkSEAoIaW1hZ2VfaWQYAyAB",
            "KAkSNQoGbGFiZWxzGAQgAygLMiUuZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2Vu",
            "dGVyLnYxLkxhYmVsQugBCiJjb20uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2Vu",
            "dGVyLnYxQg5Db250YWluZXJQcm90b1ABWkpjbG91ZC5nb29nbGUuY29tL2dv",
            "L3NlY3VyaXR5Y2VudGVyL2FwaXYxL3NlY3VyaXR5Y2VudGVycGI7c2VjdXJp",
            "dHljZW50ZXJwYqoCHkdvb2dsZS5DbG91ZC5TZWN1cml0eUNlbnRlci5WMcoC",
            "Hkdvb2dsZVxDbG91ZFxTZWN1cml0eUNlbnRlclxWMeoCIUdvb2dsZTo6Q2xv",
            "dWQ6OlNlY3VyaXR5Q2VudGVyOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.SecurityCenter.V1.LabelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.Container), global::Google.Cloud.SecurityCenter.V1.Container.Parser, new[]{ "Name", "Uri", "ImageId", "Labels" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container associated with the finding.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Container : pb::IMessage<Container>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Container> _parser = new pb::MessageParser<Container>(() => new Container());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Container> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.ContainerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Container() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Container(Container other) : this() {
      name_ = other.name_;
      uri_ = other.uri_;
      imageId_ = other.imageId_;
      labels_ = other.labels_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Container Clone() {
      return new Container(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of the container.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uri" field.</summary>
    public const int UriFieldNumber = 2;
    private string uri_ = "";
    /// <summary>
    /// Container image URI provided when configuring a pod or container. This
    /// string can identify a container image version using mutable tags.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Uri {
      get { return uri_; }
      set {
        uri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "image_id" field.</summary>
    public const int ImageIdFieldNumber = 3;
    private string imageId_ = "";
    /// <summary>
    /// Optional container image ID, if provided by the container runtime. Uniquely
    /// identifies the container image launched using a container image digest.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ImageId {
      get { return imageId_; }
      set {
        imageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Cloud.SecurityCenter.V1.Label> _repeated_labels_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Cloud.SecurityCenter.V1.Label.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.Label> labels_ = new pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.Label>();
    /// <summary>
    /// Container labels, as provided by the container runtime.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.Label> Labels {
      get { return labels_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Container);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Container other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Uri != other.Uri) return false;
      if (ImageId != other.ImageId) return false;
      if(!labels_.Equals(other.labels_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Uri.Length != 0) hash ^= Uri.GetHashCode();
      if (ImageId.Length != 0) hash ^= ImageId.GetHashCode();
      hash ^= labels_.GetHashCode();
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
      if (Uri.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uri);
      }
      if (ImageId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ImageId);
      }
      labels_.WriteTo(output, _repeated_labels_codec);
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
      if (Uri.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uri);
      }
      if (ImageId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ImageId);
      }
      labels_.WriteTo(ref output, _repeated_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Uri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
      }
      if (ImageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageId);
      }
      size += labels_.CalculateSize(_repeated_labels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Container other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Uri.Length != 0) {
        Uri = other.Uri;
      }
      if (other.ImageId.Length != 0) {
        ImageId = other.ImageId;
      }
      labels_.Add(other.labels_);
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
            Uri = input.ReadString();
            break;
          }
          case 26: {
            ImageId = input.ReadString();
            break;
          }
          case 34: {
            labels_.AddEntriesFrom(input, _repeated_labels_codec);
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
            Uri = input.ReadString();
            break;
          }
          case 26: {
            ImageId = input.ReadString();
            break;
          }
          case 34: {
            labels_.AddEntriesFrom(ref input, _repeated_labels_codec);
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
