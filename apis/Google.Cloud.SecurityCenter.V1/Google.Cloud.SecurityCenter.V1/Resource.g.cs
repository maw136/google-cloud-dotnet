// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/resource.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/resource.proto</summary>
  public static partial class ResourceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/resource.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEvcmVzb3VyY2UucHJv",
            "dG8SHmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52MRofZ29vZ2xlL2Fw",
            "aS9maWVsZF9iZWhhdmlvci5wcm90bxorZ29vZ2xlL2Nsb3VkL3NlY3VyaXR5",
            "Y2VudGVyL3YxL2ZvbGRlci5wcm90byLXAQoIUmVzb3VyY2USDAoEbmFtZRgB",
            "IAEoCRIUCgxkaXNwbGF5X25hbWUYCCABKAkSDAoEdHlwZRgGIAEoCRIPCgdw",
            "cm9qZWN0GAIgASgJEhwKFHByb2plY3RfZGlzcGxheV9uYW1lGAMgASgJEg4K",
            "BnBhcmVudBgEIAEoCRIbChNwYXJlbnRfZGlzcGxheV9uYW1lGAUgASgJEj0K",
            "B2ZvbGRlcnMYByADKAsyJi5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIu",
            "djEuRm9sZGVyQgTiQQEDQucBCiJjb20uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5",
            "Y2VudGVyLnYxQg1SZXNvdXJjZVByb3RvUAFaSmNsb3VkLmdvb2dsZS5jb20v",
            "Z28vc2VjdXJpdHljZW50ZXIvYXBpdjEvc2VjdXJpdHljZW50ZXJwYjtzZWN1",
            "cml0eWNlbnRlcnBiqgIeR29vZ2xlLkNsb3VkLlNlY3VyaXR5Q2VudGVyLlYx",
            "ygIeR29vZ2xlXENsb3VkXFNlY3VyaXR5Q2VudGVyXFYx6gIhR29vZ2xlOjpD",
            "bG91ZDo6U2VjdXJpdHlDZW50ZXI6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Cloud.SecurityCenter.V1.FolderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.Resource), global::Google.Cloud.SecurityCenter.V1.Resource.Parser, new[]{ "Name", "DisplayName", "Type", "Project", "ProjectDisplayName", "Parent", "ParentDisplayName", "Folders" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Information related to the Google Cloud resource.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Resource : pb::IMessage<Resource>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Resource> _parser = new pb::MessageParser<Resource>(() => new Resource());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Resource> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.ResourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Resource() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Resource(Resource other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      type_ = other.type_;
      project_ = other.project_;
      projectDisplayName_ = other.projectDisplayName_;
      parent_ = other.parent_;
      parentDisplayName_ = other.parentDisplayName_;
      folders_ = other.folders_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Resource Clone() {
      return new Resource(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The full resource name of the resource. See:
    /// https://cloud.google.com/apis/design/resource_names#full_resource_name
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
    public const int DisplayNameFieldNumber = 8;
    private string displayName_ = "";
    /// <summary>
    /// The human readable name of the resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 6;
    private string type_ = "";
    /// <summary>
    /// The full resource type of the resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "project" field.</summary>
    public const int ProjectFieldNumber = 2;
    private string project_ = "";
    /// <summary>
    /// The full resource name of project that the resource belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Project {
      get { return project_; }
      set {
        project_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "project_display_name" field.</summary>
    public const int ProjectDisplayNameFieldNumber = 3;
    private string projectDisplayName_ = "";
    /// <summary>
    /// The project ID that the resource belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProjectDisplayName {
      get { return projectDisplayName_; }
      set {
        projectDisplayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 4;
    private string parent_ = "";
    /// <summary>
    /// The full resource name of resource's parent.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parent_display_name" field.</summary>
    public const int ParentDisplayNameFieldNumber = 5;
    private string parentDisplayName_ = "";
    /// <summary>
    /// The human readable name of resource's parent.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ParentDisplayName {
      get { return parentDisplayName_; }
      set {
        parentDisplayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "folders" field.</summary>
    public const int FoldersFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Google.Cloud.SecurityCenter.V1.Folder> _repeated_folders_codec
        = pb::FieldCodec.ForMessage(58, global::Google.Cloud.SecurityCenter.V1.Folder.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.Folder> folders_ = new pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.Folder>();
    /// <summary>
    /// Output only. Contains a Folder message for each folder in the assets
    /// ancestry. The first folder is the deepest nested folder, and the last
    /// folder is the folder directly under the Organization.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.Folder> Folders {
      get { return folders_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Resource);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Resource other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Type != other.Type) return false;
      if (Project != other.Project) return false;
      if (ProjectDisplayName != other.ProjectDisplayName) return false;
      if (Parent != other.Parent) return false;
      if (ParentDisplayName != other.ParentDisplayName) return false;
      if(!folders_.Equals(other.folders_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Project.Length != 0) hash ^= Project.GetHashCode();
      if (ProjectDisplayName.Length != 0) hash ^= ProjectDisplayName.GetHashCode();
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (ParentDisplayName.Length != 0) hash ^= ParentDisplayName.GetHashCode();
      hash ^= folders_.GetHashCode();
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
      if (Project.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Project);
      }
      if (ProjectDisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProjectDisplayName);
      }
      if (Parent.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Parent);
      }
      if (ParentDisplayName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ParentDisplayName);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Type);
      }
      folders_.WriteTo(output, _repeated_folders_codec);
      if (DisplayName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(DisplayName);
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
      if (Project.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Project);
      }
      if (ProjectDisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProjectDisplayName);
      }
      if (Parent.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Parent);
      }
      if (ParentDisplayName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ParentDisplayName);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Type);
      }
      folders_.WriteTo(ref output, _repeated_folders_codec);
      if (DisplayName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(DisplayName);
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
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Project.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Project);
      }
      if (ProjectDisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProjectDisplayName);
      }
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (ParentDisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ParentDisplayName);
      }
      size += folders_.CalculateSize(_repeated_folders_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Resource other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Project.Length != 0) {
        Project = other.Project;
      }
      if (other.ProjectDisplayName.Length != 0) {
        ProjectDisplayName = other.ProjectDisplayName;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.ParentDisplayName.Length != 0) {
        ParentDisplayName = other.ParentDisplayName;
      }
      folders_.Add(other.folders_);
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
            Project = input.ReadString();
            break;
          }
          case 26: {
            ProjectDisplayName = input.ReadString();
            break;
          }
          case 34: {
            Parent = input.ReadString();
            break;
          }
          case 42: {
            ParentDisplayName = input.ReadString();
            break;
          }
          case 50: {
            Type = input.ReadString();
            break;
          }
          case 58: {
            folders_.AddEntriesFrom(input, _repeated_folders_codec);
            break;
          }
          case 66: {
            DisplayName = input.ReadString();
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
            Project = input.ReadString();
            break;
          }
          case 26: {
            ProjectDisplayName = input.ReadString();
            break;
          }
          case 34: {
            Parent = input.ReadString();
            break;
          }
          case 42: {
            ParentDisplayName = input.ReadString();
            break;
          }
          case 50: {
            Type = input.ReadString();
            break;
          }
          case 58: {
            folders_.AddEntriesFrom(ref input, _repeated_folders_codec);
            break;
          }
          case 66: {
            DisplayName = input.ReadString();
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
