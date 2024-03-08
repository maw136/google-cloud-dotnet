// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v2/source.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v2/source.proto</summary>
  public static partial class SourceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v2/source.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjIvc291cmNlLnByb3Rv",
            "Eh5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIudjIaGWdvb2dsZS9hcGkv",
            "cmVzb3VyY2UucHJvdG8i/QEKBlNvdXJjZRIMCgRuYW1lGAEgASgJEhQKDGRp",
            "c3BsYXlfbmFtZRgCIAEoCRITCgtkZXNjcmlwdGlvbhgDIAEoCRIWCg5jYW5v",
            "bmljYWxfbmFtZRgEIAEoCTqhAepBnQEKJHNlY3VyaXR5Y2VudGVyLmdvb2ds",
            "ZWFwaXMuY29tL1NvdXJjZRItb3JnYW5pemF0aW9ucy97b3JnYW5pemF0aW9u",
            "fS9zb3VyY2VzL3tzb3VyY2V9EiFmb2xkZXJzL3tmb2xkZXJ9L3NvdXJjZXMv",
            "e3NvdXJjZX0SI3Byb2plY3RzL3twcm9qZWN0fS9zb3VyY2VzL3tzb3VyY2V9",
            "QuUBCiJjb20uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYyQgtTb3Vy",
            "Y2VQcm90b1ABWkpjbG91ZC5nb29nbGUuY29tL2dvL3NlY3VyaXR5Y2VudGVy",
            "L2FwaXYyL3NlY3VyaXR5Y2VudGVycGI7c2VjdXJpdHljZW50ZXJwYqoCHkdv",
            "b2dsZS5DbG91ZC5TZWN1cml0eUNlbnRlci5WMsoCHkdvb2dsZVxDbG91ZFxT",
            "ZWN1cml0eUNlbnRlclxWMuoCIUdvb2dsZTo6Q2xvdWQ6OlNlY3VyaXR5Q2Vu",
            "dGVyOjpWMmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V2.Source), global::Google.Cloud.SecurityCenter.V2.Source.Parser, new[]{ "Name", "DisplayName", "Description", "CanonicalName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Security Command Center finding source. A finding source
  /// is an entity or a mechanism that can produce a finding. A source is like a
  /// container of findings that come from the same scanner, logger, monitor, and
  /// other tools.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Source : pb::IMessage<Source>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Source> _parser = new pb::MessageParser<Source>(() => new Source());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Source> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V2.SourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Source() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Source(Source other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      canonicalName_ = other.canonicalName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Source Clone() {
      return new Source(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The relative resource name of this source. See:
    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
    /// Example:
    /// "organizations/{organization_id}/sources/{source_id}"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// The source's display name.
    /// A source's display name must be unique amongst its siblings, for example,
    /// two sources with the same parent can't share the same display name.
    /// The display name must have a length between 1 and 64 characters
    /// (inclusive).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    /// The description of the source (max of 1024 characters).
    /// Example:
    /// "Web Security Scanner is a web security scanner for common
    /// vulnerabilities in App Engine applications. It can automatically
    /// scan and detect four common vulnerabilities, including cross-site-scripting
    /// (XSS), Flash injection, mixed content (HTTP in HTTPS), and
    /// outdated or insecure libraries."
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "canonical_name" field.</summary>
    public const int CanonicalNameFieldNumber = 4;
    private string canonicalName_ = "";
    /// <summary>
    /// The canonical name of the finding source. It's either
    /// "organizations/{organization_id}/sources/{source_id}",
    /// "folders/{folder_id}/sources/{source_id}", or
    /// "projects/{project_number}/sources/{source_id}",
    /// depending on the closest CRM ancestor of the resource associated with the
    /// finding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CanonicalName {
      get { return canonicalName_; }
      set {
        canonicalName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Source);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Source other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Description != other.Description) return false;
      if (CanonicalName != other.CanonicalName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (CanonicalName.Length != 0) hash ^= CanonicalName.GetHashCode();
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (CanonicalName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CanonicalName);
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (CanonicalName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CanonicalName);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (CanonicalName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CanonicalName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Source other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.CanonicalName.Length != 0) {
        CanonicalName = other.CanonicalName;
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
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 34: {
            CanonicalName = input.ReadString();
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
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 34: {
            CanonicalName = input.ReadString();
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
