// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1p1beta1/organization_settings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1P1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1p1beta1/organization_settings.proto</summary>
  public static partial class OrganizationSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1p1beta1/organization_settings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OrganizationSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjFwMWJldGExL29yZ2Fu",
            "aXphdGlvbl9zZXR0aW5ncy5wcm90bxIlZ29vZ2xlLmNsb3VkLnNlY3VyaXR5",
            "Y2VudGVyLnYxcDFiZXRhMRoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byKs",
            "BAoUT3JnYW5pemF0aW9uU2V0dGluZ3MSDAoEbmFtZRgBIAEoCRIeChZlbmFi",
            "bGVfYXNzZXRfZGlzY292ZXJ5GAIgASgIEnAKFmFzc2V0X2Rpc2NvdmVyeV9j",
            "b25maWcYAyABKAsyUC5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIudjFw",
            "MWJldGExLk9yZ2FuaXphdGlvblNldHRpbmdzLkFzc2V0RGlzY292ZXJ5Q29u",
            "ZmlnGocCChRBc3NldERpc2NvdmVyeUNvbmZpZxITCgtwcm9qZWN0X2lkcxgB",
            "IAMoCRJ2Cg5pbmNsdXNpb25fbW9kZRgCIAEoDjJeLmdvb2dsZS5jbG91ZC5z",
            "ZWN1cml0eWNlbnRlci52MXAxYmV0YTEuT3JnYW5pemF0aW9uU2V0dGluZ3Mu",
            "QXNzZXREaXNjb3ZlcnlDb25maWcuSW5jbHVzaW9uTW9kZRISCgpmb2xkZXJf",
            "aWRzGAMgAygJIk4KDUluY2x1c2lvbk1vZGUSHgoaSU5DTFVTSU9OX01PREVf",
            "VU5TUEVDSUZJRUQQABIQCgxJTkNMVURFX09OTFkQARILCgdFWENMVURFEAI6",
            "aupBZwoyc2VjdXJpdHljZW50ZXIuZ29vZ2xlYXBpcy5jb20vT3JnYW5pemF0",
            "aW9uU2V0dGluZ3MSMW9yZ2FuaXphdGlvbnMve29yZ2FuaXphdGlvbn0vb3Jn",
            "YW5pemF0aW9uU2V0dGluZ3NC+wEKKWNvbS5nb29nbGUuY2xvdWQuc2VjdXJp",
            "dHljZW50ZXIudjFwMWJldGExUAFaUWNsb3VkLmdvb2dsZS5jb20vZ28vc2Vj",
            "dXJpdHljZW50ZXIvYXBpdjFwMWJldGExL3NlY3VyaXR5Y2VudGVycGI7c2Vj",
            "dXJpdHljZW50ZXJwYqoCJUdvb2dsZS5DbG91ZC5TZWN1cml0eUNlbnRlci5W",
            "MVAxQmV0YTHKAiVHb29nbGVcQ2xvdWRcU2VjdXJpdHlDZW50ZXJcVjFwMWJl",
            "dGEx6gIoR29vZ2xlOjpDbG91ZDo6U2VjdXJpdHlDZW50ZXI6OlYxcDFiZXRh",
            "MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings), global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Parser, new[]{ "Name", "EnableAssetDiscovery", "AssetDiscoveryConfig" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig), global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Parser, new[]{ "ProjectIds", "InclusionMode", "FolderIds" }, null, new[]{ typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Types.InclusionMode) }, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// User specified settings that are attached to the Security Command
  /// Center organization.
  /// </summary>
  public sealed partial class OrganizationSettings : pb::IMessage<OrganizationSettings>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OrganizationSettings> _parser = new pb::MessageParser<OrganizationSettings>(() => new OrganizationSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OrganizationSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OrganizationSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OrganizationSettings(OrganizationSettings other) : this() {
      name_ = other.name_;
      enableAssetDiscovery_ = other.enableAssetDiscovery_;
      assetDiscoveryConfig_ = other.assetDiscoveryConfig_ != null ? other.assetDiscoveryConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OrganizationSettings Clone() {
      return new OrganizationSettings(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The relative resource name of the settings. See:
    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
    /// Example:
    /// "organizations/{organization_id}/organizationSettings".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "enable_asset_discovery" field.</summary>
    public const int EnableAssetDiscoveryFieldNumber = 2;
    private bool enableAssetDiscovery_;
    /// <summary>
    /// A flag that indicates if Asset Discovery should be enabled. If the flag is
    /// set to `true`, then discovery of assets will occur. If it is set to `false,
    /// all historical assets will remain, but discovery of future assets will not
    /// occur.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EnableAssetDiscovery {
      get { return enableAssetDiscovery_; }
      set {
        enableAssetDiscovery_ = value;
      }
    }

    /// <summary>Field number for the "asset_discovery_config" field.</summary>
    public const int AssetDiscoveryConfigFieldNumber = 3;
    private global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig assetDiscoveryConfig_;
    /// <summary>
    /// The configuration used for Asset Discovery runs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig AssetDiscoveryConfig {
      get { return assetDiscoveryConfig_; }
      set {
        assetDiscoveryConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OrganizationSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OrganizationSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (EnableAssetDiscovery != other.EnableAssetDiscovery) return false;
      if (!object.Equals(AssetDiscoveryConfig, other.AssetDiscoveryConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (EnableAssetDiscovery != false) hash ^= EnableAssetDiscovery.GetHashCode();
      if (assetDiscoveryConfig_ != null) hash ^= AssetDiscoveryConfig.GetHashCode();
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
      if (EnableAssetDiscovery != false) {
        output.WriteRawTag(16);
        output.WriteBool(EnableAssetDiscovery);
      }
      if (assetDiscoveryConfig_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AssetDiscoveryConfig);
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
      if (EnableAssetDiscovery != false) {
        output.WriteRawTag(16);
        output.WriteBool(EnableAssetDiscovery);
      }
      if (assetDiscoveryConfig_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AssetDiscoveryConfig);
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
      if (EnableAssetDiscovery != false) {
        size += 1 + 1;
      }
      if (assetDiscoveryConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AssetDiscoveryConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OrganizationSettings other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.EnableAssetDiscovery != false) {
        EnableAssetDiscovery = other.EnableAssetDiscovery;
      }
      if (other.assetDiscoveryConfig_ != null) {
        if (assetDiscoveryConfig_ == null) {
          AssetDiscoveryConfig = new global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig();
        }
        AssetDiscoveryConfig.MergeFrom(other.AssetDiscoveryConfig);
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
            EnableAssetDiscovery = input.ReadBool();
            break;
          }
          case 26: {
            if (assetDiscoveryConfig_ == null) {
              AssetDiscoveryConfig = new global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig();
            }
            input.ReadMessage(AssetDiscoveryConfig);
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
            EnableAssetDiscovery = input.ReadBool();
            break;
          }
          case 26: {
            if (assetDiscoveryConfig_ == null) {
              AssetDiscoveryConfig = new global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig();
            }
            input.ReadMessage(AssetDiscoveryConfig);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the OrganizationSettings message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The configuration used for Asset Discovery runs.
      /// </summary>
      public sealed partial class AssetDiscoveryConfig : pb::IMessage<AssetDiscoveryConfig>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<AssetDiscoveryConfig> _parser = new pb::MessageParser<AssetDiscoveryConfig>(() => new AssetDiscoveryConfig());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<AssetDiscoveryConfig> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public AssetDiscoveryConfig() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public AssetDiscoveryConfig(AssetDiscoveryConfig other) : this() {
          projectIds_ = other.projectIds_.Clone();
          inclusionMode_ = other.inclusionMode_;
          folderIds_ = other.folderIds_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public AssetDiscoveryConfig Clone() {
          return new AssetDiscoveryConfig(this);
        }

        /// <summary>Field number for the "project_ids" field.</summary>
        public const int ProjectIdsFieldNumber = 1;
        private static readonly pb::FieldCodec<string> _repeated_projectIds_codec
            = pb::FieldCodec.ForString(10);
        private readonly pbc::RepeatedField<string> projectIds_ = new pbc::RepeatedField<string>();
        /// <summary>
        /// The project ids to use for filtering asset discovery.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<string> ProjectIds {
          get { return projectIds_; }
        }

        /// <summary>Field number for the "inclusion_mode" field.</summary>
        public const int InclusionModeFieldNumber = 2;
        private global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Types.InclusionMode inclusionMode_ = global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Types.InclusionMode.Unspecified;
        /// <summary>
        /// The mode to use for filtering asset discovery.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Types.InclusionMode InclusionMode {
          get { return inclusionMode_; }
          set {
            inclusionMode_ = value;
          }
        }

        /// <summary>Field number for the "folder_ids" field.</summary>
        public const int FolderIdsFieldNumber = 3;
        private static readonly pb::FieldCodec<string> _repeated_folderIds_codec
            = pb::FieldCodec.ForString(26);
        private readonly pbc::RepeatedField<string> folderIds_ = new pbc::RepeatedField<string>();
        /// <summary>
        /// The folder ids to use for filtering asset discovery.
        /// It consists of only digits, e.g., 756619654966.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<string> FolderIds {
          get { return folderIds_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as AssetDiscoveryConfig);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(AssetDiscoveryConfig other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!projectIds_.Equals(other.projectIds_)) return false;
          if (InclusionMode != other.InclusionMode) return false;
          if(!folderIds_.Equals(other.folderIds_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= projectIds_.GetHashCode();
          if (InclusionMode != global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Types.InclusionMode.Unspecified) hash ^= InclusionMode.GetHashCode();
          hash ^= folderIds_.GetHashCode();
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
          projectIds_.WriteTo(output, _repeated_projectIds_codec);
          if (InclusionMode != global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Types.InclusionMode.Unspecified) {
            output.WriteRawTag(16);
            output.WriteEnum((int) InclusionMode);
          }
          folderIds_.WriteTo(output, _repeated_folderIds_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          projectIds_.WriteTo(ref output, _repeated_projectIds_codec);
          if (InclusionMode != global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Types.InclusionMode.Unspecified) {
            output.WriteRawTag(16);
            output.WriteEnum((int) InclusionMode);
          }
          folderIds_.WriteTo(ref output, _repeated_folderIds_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          size += projectIds_.CalculateSize(_repeated_projectIds_codec);
          if (InclusionMode != global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Types.InclusionMode.Unspecified) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) InclusionMode);
          }
          size += folderIds_.CalculateSize(_repeated_folderIds_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(AssetDiscoveryConfig other) {
          if (other == null) {
            return;
          }
          projectIds_.Add(other.projectIds_);
          if (other.InclusionMode != global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Types.InclusionMode.Unspecified) {
            InclusionMode = other.InclusionMode;
          }
          folderIds_.Add(other.folderIds_);
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
                projectIds_.AddEntriesFrom(input, _repeated_projectIds_codec);
                break;
              }
              case 16: {
                InclusionMode = (global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Types.InclusionMode) input.ReadEnum();
                break;
              }
              case 26: {
                folderIds_.AddEntriesFrom(input, _repeated_folderIds_codec);
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
                projectIds_.AddEntriesFrom(ref input, _repeated_projectIds_codec);
                break;
              }
              case 16: {
                InclusionMode = (global::Google.Cloud.SecurityCenter.V1P1Beta1.OrganizationSettings.Types.AssetDiscoveryConfig.Types.InclusionMode) input.ReadEnum();
                break;
              }
              case 26: {
                folderIds_.AddEntriesFrom(ref input, _repeated_folderIds_codec);
                break;
              }
            }
          }
        }
        #endif

        #region Nested types
        /// <summary>Container for nested types declared in the AssetDiscoveryConfig message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types {
          /// <summary>
          /// The mode of inclusion when running Asset Discovery.
          /// Asset discovery can be limited by explicitly identifying projects to be
          /// included or excluded. If INCLUDE_ONLY is set, then only those projects
          /// within the organization and their children are discovered during asset
          /// discovery. If EXCLUDE is set, then projects that don't match those
          /// projects are discovered during asset discovery. If neither are set, then
          /// all projects within the organization are discovered during asset
          /// discovery.
          /// </summary>
          public enum InclusionMode {
            /// <summary>
            /// Unspecified. Setting the mode with this value will disable
            /// inclusion/exclusion filtering for Asset Discovery.
            /// </summary>
            [pbr::OriginalName("INCLUSION_MODE_UNSPECIFIED")] Unspecified = 0,
            /// <summary>
            /// Asset Discovery will capture only the resources within the projects
            /// specified. All other resources will be ignored.
            /// </summary>
            [pbr::OriginalName("INCLUDE_ONLY")] IncludeOnly = 1,
            /// <summary>
            /// Asset Discovery will ignore all resources under the projects specified.
            /// All other resources will be retrieved.
            /// </summary>
            [pbr::OriginalName("EXCLUDE")] Exclude = 2,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
