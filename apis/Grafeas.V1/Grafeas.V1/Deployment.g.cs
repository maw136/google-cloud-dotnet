// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: grafeas/v1/deployment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grafeas.V1 {

  /// <summary>Holder for reflection information generated from grafeas/v1/deployment.proto</summary>
  public static partial class DeploymentReflection {

    #region Descriptor
    /// <summary>File descriptor for grafeas/v1/deployment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeploymentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtncmFmZWFzL3YxL2RlcGxveW1lbnQucHJvdG8SCmdyYWZlYXMudjEaH2dv",
            "b2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8iJgoORGVwbG95bWVudE5v",
            "dGUSFAoMcmVzb3VyY2VfdXJpGAEgAygJIscCChREZXBsb3ltZW50T2NjdXJy",
            "ZW5jZRISCgp1c2VyX2VtYWlsGAEgASgJEi8KC2RlcGxveV90aW1lGAIgASgL",
            "MhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIxCg11bmRlcGxveV90aW1l",
            "GAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIOCgZjb25maWcY",
            "BCABKAkSDwoHYWRkcmVzcxgFIAEoCRIUCgxyZXNvdXJjZV91cmkYBiADKAkS",
            "OwoIcGxhdGZvcm0YByABKA4yKS5ncmFmZWFzLnYxLkRlcGxveW1lbnRPY2N1",
            "cnJlbmNlLlBsYXRmb3JtIkMKCFBsYXRmb3JtEhgKFFBMQVRGT1JNX1VOU1BF",
            "Q0lGSUVEEAASBwoDR0tFEAESCAoERkxFWBACEgoKBkNVU1RPTRADQlEKDWlv",
            "LmdyYWZlYXMudjFQAVo4Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9ncmFmZWFzL3YxO2dyYWZlYXOiAgNHUkFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.DeploymentNote), global::Grafeas.V1.DeploymentNote.Parser, new[]{ "ResourceUri" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.DeploymentOccurrence), global::Grafeas.V1.DeploymentOccurrence.Parser, new[]{ "UserEmail", "DeployTime", "UndeployTime", "Config", "Address", "ResourceUri", "Platform" }, null, new[]{ typeof(global::Grafeas.V1.DeploymentOccurrence.Types.Platform) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An artifact that can be deployed in some runtime.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DeploymentNote : pb::IMessage<DeploymentNote>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DeploymentNote> _parser = new pb::MessageParser<DeploymentNote>(() => new DeploymentNote());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DeploymentNote> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.DeploymentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeploymentNote() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeploymentNote(DeploymentNote other) : this() {
      resourceUri_ = other.resourceUri_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeploymentNote Clone() {
      return new DeploymentNote(this);
    }

    /// <summary>Field number for the "resource_uri" field.</summary>
    public const int ResourceUriFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_resourceUri_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> resourceUri_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Required. Resource URI for the artifact being deployed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ResourceUri {
      get { return resourceUri_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DeploymentNote);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DeploymentNote other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!resourceUri_.Equals(other.resourceUri_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= resourceUri_.GetHashCode();
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
      resourceUri_.WriteTo(output, _repeated_resourceUri_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      resourceUri_.WriteTo(ref output, _repeated_resourceUri_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += resourceUri_.CalculateSize(_repeated_resourceUri_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DeploymentNote other) {
      if (other == null) {
        return;
      }
      resourceUri_.Add(other.resourceUri_);
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
            resourceUri_.AddEntriesFrom(input, _repeated_resourceUri_codec);
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
            resourceUri_.AddEntriesFrom(ref input, _repeated_resourceUri_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The period during which some deployable was active in a runtime.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DeploymentOccurrence : pb::IMessage<DeploymentOccurrence>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DeploymentOccurrence> _parser = new pb::MessageParser<DeploymentOccurrence>(() => new DeploymentOccurrence());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DeploymentOccurrence> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.DeploymentReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeploymentOccurrence() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeploymentOccurrence(DeploymentOccurrence other) : this() {
      userEmail_ = other.userEmail_;
      deployTime_ = other.deployTime_ != null ? other.deployTime_.Clone() : null;
      undeployTime_ = other.undeployTime_ != null ? other.undeployTime_.Clone() : null;
      config_ = other.config_;
      address_ = other.address_;
      resourceUri_ = other.resourceUri_.Clone();
      platform_ = other.platform_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeploymentOccurrence Clone() {
      return new DeploymentOccurrence(this);
    }

    /// <summary>Field number for the "user_email" field.</summary>
    public const int UserEmailFieldNumber = 1;
    private string userEmail_ = "";
    /// <summary>
    /// Identity of the user that triggered this deployment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserEmail {
      get { return userEmail_; }
      set {
        userEmail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deploy_time" field.</summary>
    public const int DeployTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp deployTime_;
    /// <summary>
    /// Required. Beginning of the lifetime of this deployment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp DeployTime {
      get { return deployTime_; }
      set {
        deployTime_ = value;
      }
    }

    /// <summary>Field number for the "undeploy_time" field.</summary>
    public const int UndeployTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp undeployTime_;
    /// <summary>
    /// End of the lifetime of this deployment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UndeployTime {
      get { return undeployTime_; }
      set {
        undeployTime_ = value;
      }
    }

    /// <summary>Field number for the "config" field.</summary>
    public const int ConfigFieldNumber = 4;
    private string config_ = "";
    /// <summary>
    /// Configuration used to create this deployment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Config {
      get { return config_; }
      set {
        config_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 5;
    private string address_ = "";
    /// <summary>
    /// Address of the runtime element hosting this deployment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resource_uri" field.</summary>
    public const int ResourceUriFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _repeated_resourceUri_codec
        = pb::FieldCodec.ForString(50);
    private readonly pbc::RepeatedField<string> resourceUri_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. Resource URI for the artifact being deployed taken from
    /// the deployable field with the same name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ResourceUri {
      get { return resourceUri_; }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 7;
    private global::Grafeas.V1.DeploymentOccurrence.Types.Platform platform_ = global::Grafeas.V1.DeploymentOccurrence.Types.Platform.Unspecified;
    /// <summary>
    /// Platform hosting this deployment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Grafeas.V1.DeploymentOccurrence.Types.Platform Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DeploymentOccurrence);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DeploymentOccurrence other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserEmail != other.UserEmail) return false;
      if (!object.Equals(DeployTime, other.DeployTime)) return false;
      if (!object.Equals(UndeployTime, other.UndeployTime)) return false;
      if (Config != other.Config) return false;
      if (Address != other.Address) return false;
      if(!resourceUri_.Equals(other.resourceUri_)) return false;
      if (Platform != other.Platform) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UserEmail.Length != 0) hash ^= UserEmail.GetHashCode();
      if (deployTime_ != null) hash ^= DeployTime.GetHashCode();
      if (undeployTime_ != null) hash ^= UndeployTime.GetHashCode();
      if (Config.Length != 0) hash ^= Config.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      hash ^= resourceUri_.GetHashCode();
      if (Platform != global::Grafeas.V1.DeploymentOccurrence.Types.Platform.Unspecified) hash ^= Platform.GetHashCode();
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
      if (UserEmail.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserEmail);
      }
      if (deployTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DeployTime);
      }
      if (undeployTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(UndeployTime);
      }
      if (Config.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Config);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Address);
      }
      resourceUri_.WriteTo(output, _repeated_resourceUri_codec);
      if (Platform != global::Grafeas.V1.DeploymentOccurrence.Types.Platform.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Platform);
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
      if (UserEmail.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserEmail);
      }
      if (deployTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DeployTime);
      }
      if (undeployTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(UndeployTime);
      }
      if (Config.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Config);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Address);
      }
      resourceUri_.WriteTo(ref output, _repeated_resourceUri_codec);
      if (Platform != global::Grafeas.V1.DeploymentOccurrence.Types.Platform.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Platform);
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
      if (UserEmail.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserEmail);
      }
      if (deployTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DeployTime);
      }
      if (undeployTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UndeployTime);
      }
      if (Config.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Config);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      size += resourceUri_.CalculateSize(_repeated_resourceUri_codec);
      if (Platform != global::Grafeas.V1.DeploymentOccurrence.Types.Platform.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DeploymentOccurrence other) {
      if (other == null) {
        return;
      }
      if (other.UserEmail.Length != 0) {
        UserEmail = other.UserEmail;
      }
      if (other.deployTime_ != null) {
        if (deployTime_ == null) {
          DeployTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        DeployTime.MergeFrom(other.DeployTime);
      }
      if (other.undeployTime_ != null) {
        if (undeployTime_ == null) {
          UndeployTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UndeployTime.MergeFrom(other.UndeployTime);
      }
      if (other.Config.Length != 0) {
        Config = other.Config;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      resourceUri_.Add(other.resourceUri_);
      if (other.Platform != global::Grafeas.V1.DeploymentOccurrence.Types.Platform.Unspecified) {
        Platform = other.Platform;
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
            UserEmail = input.ReadString();
            break;
          }
          case 18: {
            if (deployTime_ == null) {
              DeployTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DeployTime);
            break;
          }
          case 26: {
            if (undeployTime_ == null) {
              UndeployTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UndeployTime);
            break;
          }
          case 34: {
            Config = input.ReadString();
            break;
          }
          case 42: {
            Address = input.ReadString();
            break;
          }
          case 50: {
            resourceUri_.AddEntriesFrom(input, _repeated_resourceUri_codec);
            break;
          }
          case 56: {
            Platform = (global::Grafeas.V1.DeploymentOccurrence.Types.Platform) input.ReadEnum();
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
            UserEmail = input.ReadString();
            break;
          }
          case 18: {
            if (deployTime_ == null) {
              DeployTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DeployTime);
            break;
          }
          case 26: {
            if (undeployTime_ == null) {
              UndeployTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UndeployTime);
            break;
          }
          case 34: {
            Config = input.ReadString();
            break;
          }
          case 42: {
            Address = input.ReadString();
            break;
          }
          case 50: {
            resourceUri_.AddEntriesFrom(ref input, _repeated_resourceUri_codec);
            break;
          }
          case 56: {
            Platform = (global::Grafeas.V1.DeploymentOccurrence.Types.Platform) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DeploymentOccurrence message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Types of platforms.
      /// </summary>
      public enum Platform {
        /// <summary>
        /// Unknown.
        /// </summary>
        [pbr::OriginalName("PLATFORM_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Google Container Engine.
        /// </summary>
        [pbr::OriginalName("GKE")] Gke = 1,
        /// <summary>
        /// Google App Engine: Flexible Environment.
        /// </summary>
        [pbr::OriginalName("FLEX")] Flex = 2,
        /// <summary>
        /// Custom user-defined platform.
        /// </summary>
        [pbr::OriginalName("CUSTOM")] Custom = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
