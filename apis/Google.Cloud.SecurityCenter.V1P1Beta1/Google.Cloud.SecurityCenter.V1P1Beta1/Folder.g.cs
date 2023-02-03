// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1p1beta1/folder.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1P1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1p1beta1/folder.proto</summary>
  public static partial class FolderReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1p1beta1/folder.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FolderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjFwMWJldGExL2ZvbGRl",
            "ci5wcm90bxIlZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYxcDFiZXRh",
            "MSJHCgZGb2xkZXISFwoPcmVzb3VyY2VfZm9sZGVyGAEgASgJEiQKHHJlc291",
            "cmNlX2ZvbGRlcl9kaXNwbGF5X25hbWUYAiABKAlCiAIKKWNvbS5nb29nbGUu",
            "Y2xvdWQuc2VjdXJpdHljZW50ZXIudjFwMWJldGExQgtGb2xkZXJQcm90b1AB",
            "WlFjbG91ZC5nb29nbGUuY29tL2dvL3NlY3VyaXR5Y2VudGVyL2FwaXYxcDFi",
            "ZXRhMS9zZWN1cml0eWNlbnRlcnBiO3NlY3VyaXR5Y2VudGVycGKqAiVHb29n",
            "bGUuQ2xvdWQuU2VjdXJpdHlDZW50ZXIuVjFQMUJldGExygIlR29vZ2xlXENs",
            "b3VkXFNlY3VyaXR5Q2VudGVyXFYxcDFiZXRhMeoCKEdvb2dsZTo6Q2xvdWQ6",
            "OlNlY3VyaXR5Q2VudGVyOjpWMXAxQmV0YTFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.Folder), global::Google.Cloud.SecurityCenter.V1P1Beta1.Folder.Parser, new[]{ "ResourceFolder", "ResourceFolderDisplayName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message that contains the resource name and display name of a folder
  /// resource.
  /// </summary>
  public sealed partial class Folder : pb::IMessage<Folder>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Folder> _parser = new pb::MessageParser<Folder>(() => new Folder());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Folder> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1P1Beta1.FolderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Folder() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Folder(Folder other) : this() {
      resourceFolder_ = other.resourceFolder_;
      resourceFolderDisplayName_ = other.resourceFolderDisplayName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Folder Clone() {
      return new Folder(this);
    }

    /// <summary>Field number for the "resource_folder" field.</summary>
    public const int ResourceFolderFieldNumber = 1;
    private string resourceFolder_ = "";
    /// <summary>
    /// Full resource name of this folder. See:
    /// https://cloud.google.com/apis/design/resource_names#full_resource_name
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceFolder {
      get { return resourceFolder_; }
      set {
        resourceFolder_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resource_folder_display_name" field.</summary>
    public const int ResourceFolderDisplayNameFieldNumber = 2;
    private string resourceFolderDisplayName_ = "";
    /// <summary>
    /// The user defined display name for this folder.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceFolderDisplayName {
      get { return resourceFolderDisplayName_; }
      set {
        resourceFolderDisplayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Folder);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Folder other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceFolder != other.ResourceFolder) return false;
      if (ResourceFolderDisplayName != other.ResourceFolderDisplayName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceFolder.Length != 0) hash ^= ResourceFolder.GetHashCode();
      if (ResourceFolderDisplayName.Length != 0) hash ^= ResourceFolderDisplayName.GetHashCode();
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
      if (ResourceFolder.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceFolder);
      }
      if (ResourceFolderDisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ResourceFolderDisplayName);
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
      if (ResourceFolder.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceFolder);
      }
      if (ResourceFolderDisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ResourceFolderDisplayName);
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
      if (ResourceFolder.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceFolder);
      }
      if (ResourceFolderDisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceFolderDisplayName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Folder other) {
      if (other == null) {
        return;
      }
      if (other.ResourceFolder.Length != 0) {
        ResourceFolder = other.ResourceFolder;
      }
      if (other.ResourceFolderDisplayName.Length != 0) {
        ResourceFolderDisplayName = other.ResourceFolderDisplayName;
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
            ResourceFolder = input.ReadString();
            break;
          }
          case 18: {
            ResourceFolderDisplayName = input.ReadString();
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
            ResourceFolder = input.ReadString();
            break;
          }
          case 18: {
            ResourceFolderDisplayName = input.ReadString();
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
