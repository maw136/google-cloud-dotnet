// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/devtools/artifactregistry/v1/settings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ArtifactRegistry.V1 {

  /// <summary>Holder for reflection information generated from google/devtools/artifactregistry/v1/settings.proto</summary>
  public static partial class SettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/devtools/artifactregistry/v1/settings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvZGV2dG9vbHMvYXJ0aWZhY3RyZWdpc3RyeS92MS9zZXR0aW5n",
            "cy5wcm90bxIjZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEa",
            "H2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkv",
            "cmVzb3VyY2UucHJvdG8aIGdvb2dsZS9wcm90b2J1Zi9maWVsZF9tYXNrLnBy",
            "b3RvIpADCg9Qcm9qZWN0U2V0dGluZ3MSDAoEbmFtZRgBIAEoCRJnChhsZWdh",
            "Y3lfcmVkaXJlY3Rpb25fc3RhdGUYAiABKA4yRS5nb29nbGUuZGV2dG9vbHMu",
            "YXJ0aWZhY3RyZWdpc3RyeS52MS5Qcm9qZWN0U2V0dGluZ3MuUmVkaXJlY3Rp",
            "b25TdGF0ZSKrAQoQUmVkaXJlY3Rpb25TdGF0ZRIhCh1SRURJUkVDVElPTl9T",
            "VEFURV9VTlNQRUNJRklFRBAAEiQKIFJFRElSRUNUSU9OX0ZST01fR0NSX0lP",
            "X0RJU0FCTEVEEAESIwofUkVESVJFQ1RJT05fRlJPTV9HQ1JfSU9fRU5BQkxF",
            "RBACEikKIVJFRElSRUNUSU9OX0ZST01fR0NSX0lPX0ZJTkFMSVpFRBADGgII",
            "ATpY6kFVCi9hcnRpZmFjdHJlZ2lzdHJ5Lmdvb2dsZWFwaXMuY29tL1Byb2pl",
            "Y3RTZXR0aW5ncxIicHJvamVjdHMve3Byb2plY3R9L3Byb2plY3RTZXR0aW5n",
            "cyJiChlHZXRQcm9qZWN0U2V0dGluZ3NSZXF1ZXN0EkUKBG5hbWUYASABKAlC",
            "N+BBAvpBMQovYXJ0aWZhY3RyZWdpc3RyeS5nb29nbGVhcGlzLmNvbS9Qcm9q",
            "ZWN0U2V0dGluZ3MinwEKHFVwZGF0ZVByb2plY3RTZXR0aW5nc1JlcXVlc3QS",
            "TgoQcHJvamVjdF9zZXR0aW5ncxgCIAEoCzI0Lmdvb2dsZS5kZXZ0b29scy5h",
            "cnRpZmFjdHJlZ2lzdHJ5LnYxLlByb2plY3RTZXR0aW5ncxIvCgt1cGRhdGVf",
            "bWFzaxgDIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE1hc2tC+wEKJ2Nv",
            "bS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MUINU2V0dGlu",
            "Z3NQcm90b1ABWlNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2RldnRvb2xzL2FydGlmYWN0cmVnaXN0cnkvdjE7YXJ0aWZhY3RyZWdp",
            "c3RyeaoCIEdvb2dsZS5DbG91ZC5BcnRpZmFjdFJlZ2lzdHJ5LlYxygIgR29v",
            "Z2xlXENsb3VkXEFydGlmYWN0UmVnaXN0cnlcVjHqAiNHb29nbGU6OkNsb3Vk",
            "OjpBcnRpZmFjdFJlZ2lzdHJ5OjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings), global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Parser, new[]{ "Name", "LegacyRedirectionState" }, null, new[]{ typeof(global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Types.RedirectionState) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ArtifactRegistry.V1.GetProjectSettingsRequest), global::Google.Cloud.ArtifactRegistry.V1.GetProjectSettingsRequest.Parser, new[]{ "Name" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ArtifactRegistry.V1.UpdateProjectSettingsRequest), global::Google.Cloud.ArtifactRegistry.V1.UpdateProjectSettingsRequest.Parser, new[]{ "ProjectSettings", "UpdateMask" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The Artifact Registry settings that apply to a Project.
  /// </summary>
  public sealed partial class ProjectSettings : pb::IMessage<ProjectSettings>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProjectSettings> _parser = new pb::MessageParser<ProjectSettings>(() => new ProjectSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProjectSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ArtifactRegistry.V1.SettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectSettings(ProjectSettings other) : this() {
      name_ = other.name_;
      legacyRedirectionState_ = other.legacyRedirectionState_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectSettings Clone() {
      return new ProjectSettings(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of the project's settings.
    ///
    /// Always of the form:
    /// projects/{project-id}/projectSettings
    ///
    /// In update request: never set
    /// In response: always set
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "legacy_redirection_state" field.</summary>
    public const int LegacyRedirectionStateFieldNumber = 2;
    private global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Types.RedirectionState legacyRedirectionState_ = global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Types.RedirectionState.Unspecified;
    /// <summary>
    /// The redirection state of the legacy repositories in this project.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Types.RedirectionState LegacyRedirectionState {
      get { return legacyRedirectionState_; }
      set {
        legacyRedirectionState_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProjectSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProjectSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (LegacyRedirectionState != other.LegacyRedirectionState) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (LegacyRedirectionState != global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Types.RedirectionState.Unspecified) hash ^= LegacyRedirectionState.GetHashCode();
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
      if (LegacyRedirectionState != global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Types.RedirectionState.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) LegacyRedirectionState);
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
      if (LegacyRedirectionState != global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Types.RedirectionState.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) LegacyRedirectionState);
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
      if (LegacyRedirectionState != global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Types.RedirectionState.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LegacyRedirectionState);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProjectSettings other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.LegacyRedirectionState != global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Types.RedirectionState.Unspecified) {
        LegacyRedirectionState = other.LegacyRedirectionState;
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
          case 16: {
            LegacyRedirectionState = (global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Types.RedirectionState) input.ReadEnum();
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
          case 16: {
            LegacyRedirectionState = (global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings.Types.RedirectionState) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ProjectSettings message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The possible redirection states for legacy repositories.
      /// </summary>
      public enum RedirectionState {
        /// <summary>
        /// No redirection status has been set.
        /// </summary>
        [pbr::OriginalName("REDIRECTION_STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Redirection is disabled.
        /// </summary>
        [pbr::OriginalName("REDIRECTION_FROM_GCR_IO_DISABLED")] RedirectionFromGcrIoDisabled = 1,
        /// <summary>
        /// Redirection is enabled.
        /// </summary>
        [pbr::OriginalName("REDIRECTION_FROM_GCR_IO_ENABLED")] RedirectionFromGcrIoEnabled = 2,
        /// <summary>
        /// Redirection is enabled, and has been finalized so cannot be reverted.
        /// </summary>
        [pbr::OriginalName("REDIRECTION_FROM_GCR_IO_FINALIZED")] RedirectionFromGcrIoFinalized = 3,
      }

    }
    #endregion

  }

  /// <summary>
  /// Gets the redirection status for a project.
  /// </summary>
  public sealed partial class GetProjectSettingsRequest : pb::IMessage<GetProjectSettingsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetProjectSettingsRequest> _parser = new pb::MessageParser<GetProjectSettingsRequest>(() => new GetProjectSettingsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetProjectSettingsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ArtifactRegistry.V1.SettingsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetProjectSettingsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetProjectSettingsRequest(GetProjectSettingsRequest other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetProjectSettingsRequest Clone() {
      return new GetProjectSettingsRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. The name of the projectSettings resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetProjectSettingsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetProjectSettingsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetProjectSettingsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Sets the settings of the project.
  /// </summary>
  public sealed partial class UpdateProjectSettingsRequest : pb::IMessage<UpdateProjectSettingsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpdateProjectSettingsRequest> _parser = new pb::MessageParser<UpdateProjectSettingsRequest>(() => new UpdateProjectSettingsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpdateProjectSettingsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ArtifactRegistry.V1.SettingsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateProjectSettingsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateProjectSettingsRequest(UpdateProjectSettingsRequest other) : this() {
      projectSettings_ = other.projectSettings_ != null ? other.projectSettings_.Clone() : null;
      updateMask_ = other.updateMask_ != null ? other.updateMask_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateProjectSettingsRequest Clone() {
      return new UpdateProjectSettingsRequest(this);
    }

    /// <summary>Field number for the "project_settings" field.</summary>
    public const int ProjectSettingsFieldNumber = 2;
    private global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings projectSettings_;
    /// <summary>
    /// The project settings.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings ProjectSettings {
      get { return projectSettings_; }
      set {
        projectSettings_ = value;
      }
    }

    /// <summary>Field number for the "update_mask" field.</summary>
    public const int UpdateMaskFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
    /// <summary>
    /// Field mask to support partial updates.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.FieldMask UpdateMask {
      get { return updateMask_; }
      set {
        updateMask_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpdateProjectSettingsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpdateProjectSettingsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ProjectSettings, other.ProjectSettings)) return false;
      if (!object.Equals(UpdateMask, other.UpdateMask)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (projectSettings_ != null) hash ^= ProjectSettings.GetHashCode();
      if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
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
      if (projectSettings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ProjectSettings);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(UpdateMask);
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
      if (projectSettings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ProjectSettings);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(UpdateMask);
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
      if (projectSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProjectSettings);
      }
      if (updateMask_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateMask);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpdateProjectSettingsRequest other) {
      if (other == null) {
        return;
      }
      if (other.projectSettings_ != null) {
        if (projectSettings_ == null) {
          ProjectSettings = new global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings();
        }
        ProjectSettings.MergeFrom(other.ProjectSettings);
      }
      if (other.updateMask_ != null) {
        if (updateMask_ == null) {
          UpdateMask = new global::Google.Protobuf.WellKnownTypes.FieldMask();
        }
        UpdateMask.MergeFrom(other.UpdateMask);
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
          case 18: {
            if (projectSettings_ == null) {
              ProjectSettings = new global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings();
            }
            input.ReadMessage(ProjectSettings);
            break;
          }
          case 26: {
            if (updateMask_ == null) {
              UpdateMask = new global::Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
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
          case 18: {
            if (projectSettings_ == null) {
              ProjectSettings = new global::Google.Cloud.ArtifactRegistry.V1.ProjectSettings();
            }
            input.ReadMessage(ProjectSettings);
            break;
          }
          case 26: {
            if (updateMask_ == null) {
              UpdateMask = new global::Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
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
