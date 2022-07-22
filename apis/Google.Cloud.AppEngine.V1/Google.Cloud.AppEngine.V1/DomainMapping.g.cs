// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/appengine/v1/domain_mapping.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AppEngine.V1 {

  /// <summary>Holder for reflection information generated from google/appengine/v1/domain_mapping.proto</summary>
  public static partial class DomainMappingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/appengine/v1/domain_mapping.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DomainMappingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvYXBwZW5naW5lL3YxL2RvbWFpbl9tYXBwaW5nLnByb3RvEhNn",
            "b29nbGUuYXBwZW5naW5lLnYxIqABCg1Eb21haW5NYXBwaW5nEgwKBG5hbWUY",
            "ASABKAkSCgoCaWQYAiABKAkSNgoMc3NsX3NldHRpbmdzGAMgASgLMiAuZ29v",
            "Z2xlLmFwcGVuZ2luZS52MS5Tc2xTZXR0aW5ncxI9ChByZXNvdXJjZV9yZWNv",
            "cmRzGAQgAygLMiMuZ29vZ2xlLmFwcGVuZ2luZS52MS5SZXNvdXJjZVJlY29y",
            "ZCLzAQoLU3NsU2V0dGluZ3MSFgoOY2VydGlmaWNhdGVfaWQYASABKAkSTwoT",
            "c3NsX21hbmFnZW1lbnRfdHlwZRgDIAEoDjIyLmdvb2dsZS5hcHBlbmdpbmUu",
            "djEuU3NsU2V0dGluZ3MuU3NsTWFuYWdlbWVudFR5cGUSJgoecGVuZGluZ19t",
            "YW5hZ2VkX2NlcnRpZmljYXRlX2lkGAQgASgJIlMKEVNzbE1hbmFnZW1lbnRU",
            "eXBlEiMKH1NTTF9NQU5BR0VNRU5UX1RZUEVfVU5TUEVDSUZJRUQQABINCglB",
            "VVRPTUFUSUMQARIKCgZNQU5VQUwQAiKzAQoOUmVzb3VyY2VSZWNvcmQSDAoE",
            "bmFtZRgBIAEoCRIOCgZycmRhdGEYAiABKAkSPAoEdHlwZRgDIAEoDjIuLmdv",
            "b2dsZS5hcHBlbmdpbmUudjEuUmVzb3VyY2VSZWNvcmQuUmVjb3JkVHlwZSJF",
            "CgpSZWNvcmRUeXBlEhsKF1JFQ09SRF9UWVBFX1VOU1BFQ0lGSUVEEAASBQoB",
            "QRABEggKBEFBQUEQAhIJCgVDTkFNRRADQsQBChdjb20uZ29vZ2xlLmFwcGVu",
            "Z2luZS52MUISRG9tYWluTWFwcGluZ1Byb3RvUAFaPGdvb2dsZS5nb2xhbmcu",
            "b3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYXBwZW5naW5lL3YxO2FwcGVuZ2lu",
            "ZaoCGUdvb2dsZS5DbG91ZC5BcHBFbmdpbmUuVjHKAhlHb29nbGVcQ2xvdWRc",
            "QXBwRW5naW5lXFYx6gIcR29vZ2xlOjpDbG91ZDo6QXBwRW5naW5lOjpWMWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AppEngine.V1.DomainMapping), global::Google.Cloud.AppEngine.V1.DomainMapping.Parser, new[]{ "Name", "Id", "SslSettings", "ResourceRecords" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AppEngine.V1.SslSettings), global::Google.Cloud.AppEngine.V1.SslSettings.Parser, new[]{ "CertificateId", "SslManagementType", "PendingManagedCertificateId" }, null, new[]{ typeof(global::Google.Cloud.AppEngine.V1.SslSettings.Types.SslManagementType) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AppEngine.V1.ResourceRecord), global::Google.Cloud.AppEngine.V1.ResourceRecord.Parser, new[]{ "Name", "Rrdata", "Type" }, null, new[]{ typeof(global::Google.Cloud.AppEngine.V1.ResourceRecord.Types.RecordType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A domain serving an App Engine application.
  /// </summary>
  public sealed partial class DomainMapping : pb::IMessage<DomainMapping>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DomainMapping> _parser = new pb::MessageParser<DomainMapping>(() => new DomainMapping());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DomainMapping> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AppEngine.V1.DomainMappingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DomainMapping() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DomainMapping(DomainMapping other) : this() {
      name_ = other.name_;
      id_ = other.id_;
      sslSettings_ = other.sslSettings_ != null ? other.sslSettings_.Clone() : null;
      resourceRecords_ = other.resourceRecords_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DomainMapping Clone() {
      return new DomainMapping(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Full path to the `DomainMapping` resource in the API. Example:
    /// `apps/myapp/domainMapping/example.com`.
    ///
    /// @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    /// <summary>
    /// Relative name of the domain serving the application. Example:
    /// `example.com`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ssl_settings" field.</summary>
    public const int SslSettingsFieldNumber = 3;
    private global::Google.Cloud.AppEngine.V1.SslSettings sslSettings_;
    /// <summary>
    /// SSL configuration for this domain. If unconfigured, this domain will not
    /// serve with SSL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AppEngine.V1.SslSettings SslSettings {
      get { return sslSettings_; }
      set {
        sslSettings_ = value;
      }
    }

    /// <summary>Field number for the "resource_records" field.</summary>
    public const int ResourceRecordsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Cloud.AppEngine.V1.ResourceRecord> _repeated_resourceRecords_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Cloud.AppEngine.V1.ResourceRecord.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.AppEngine.V1.ResourceRecord> resourceRecords_ = new pbc::RepeatedField<global::Google.Cloud.AppEngine.V1.ResourceRecord>();
    /// <summary>
    /// The resource records required to configure this domain mapping. These
    /// records must be added to the domain's DNS configuration in order to
    /// serve the application via this domain mapping.
    ///
    /// @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.AppEngine.V1.ResourceRecord> ResourceRecords {
      get { return resourceRecords_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DomainMapping);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DomainMapping other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (!object.Equals(SslSettings, other.SslSettings)) return false;
      if(!resourceRecords_.Equals(other.resourceRecords_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (sslSettings_ != null) hash ^= SslSettings.GetHashCode();
      hash ^= resourceRecords_.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (sslSettings_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SslSettings);
      }
      resourceRecords_.WriteTo(output, _repeated_resourceRecords_codec);
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
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (sslSettings_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SslSettings);
      }
      resourceRecords_.WriteTo(ref output, _repeated_resourceRecords_codec);
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
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (sslSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SslSettings);
      }
      size += resourceRecords_.CalculateSize(_repeated_resourceRecords_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DomainMapping other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.sslSettings_ != null) {
        if (sslSettings_ == null) {
          SslSettings = new global::Google.Cloud.AppEngine.V1.SslSettings();
        }
        SslSettings.MergeFrom(other.SslSettings);
      }
      resourceRecords_.Add(other.resourceRecords_);
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
            Id = input.ReadString();
            break;
          }
          case 26: {
            if (sslSettings_ == null) {
              SslSettings = new global::Google.Cloud.AppEngine.V1.SslSettings();
            }
            input.ReadMessage(SslSettings);
            break;
          }
          case 34: {
            resourceRecords_.AddEntriesFrom(input, _repeated_resourceRecords_codec);
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
            Id = input.ReadString();
            break;
          }
          case 26: {
            if (sslSettings_ == null) {
              SslSettings = new global::Google.Cloud.AppEngine.V1.SslSettings();
            }
            input.ReadMessage(SslSettings);
            break;
          }
          case 34: {
            resourceRecords_.AddEntriesFrom(ref input, _repeated_resourceRecords_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// SSL configuration for a `DomainMapping` resource.
  /// </summary>
  public sealed partial class SslSettings : pb::IMessage<SslSettings>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SslSettings> _parser = new pb::MessageParser<SslSettings>(() => new SslSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SslSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AppEngine.V1.DomainMappingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SslSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SslSettings(SslSettings other) : this() {
      certificateId_ = other.certificateId_;
      sslManagementType_ = other.sslManagementType_;
      pendingManagedCertificateId_ = other.pendingManagedCertificateId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SslSettings Clone() {
      return new SslSettings(this);
    }

    /// <summary>Field number for the "certificate_id" field.</summary>
    public const int CertificateIdFieldNumber = 1;
    private string certificateId_ = "";
    /// <summary>
    /// ID of the `AuthorizedCertificate` resource configuring SSL for the
    /// application. Clearing this field will remove SSL support.
    ///
    /// By default, a managed certificate is automatically created for every
    /// domain mapping. To omit SSL support or to configure SSL manually, specify
    /// `SslManagementType.MANUAL` on a `CREATE` or `UPDATE` request. You must
    /// be authorized to administer the `AuthorizedCertificate` resource to
    /// manually map it to a `DomainMapping` resource.
    /// Example: `12345`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CertificateId {
      get { return certificateId_; }
      set {
        certificateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ssl_management_type" field.</summary>
    public const int SslManagementTypeFieldNumber = 3;
    private global::Google.Cloud.AppEngine.V1.SslSettings.Types.SslManagementType sslManagementType_ = global::Google.Cloud.AppEngine.V1.SslSettings.Types.SslManagementType.Unspecified;
    /// <summary>
    /// SSL management type for this domain. If `AUTOMATIC`, a managed certificate
    /// is automatically provisioned. If `MANUAL`, `certificate_id` must be
    /// manually specified in order to configure SSL for this domain.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AppEngine.V1.SslSettings.Types.SslManagementType SslManagementType {
      get { return sslManagementType_; }
      set {
        sslManagementType_ = value;
      }
    }

    /// <summary>Field number for the "pending_managed_certificate_id" field.</summary>
    public const int PendingManagedCertificateIdFieldNumber = 4;
    private string pendingManagedCertificateId_ = "";
    /// <summary>
    /// ID of the managed `AuthorizedCertificate` resource currently being
    /// provisioned, if applicable. Until the new managed certificate has been
    /// successfully provisioned, the previous SSL state will be preserved. Once
    /// the provisioning process completes, the `certificate_id` field will reflect
    /// the new managed certificate and this field will be left empty. To remove
    /// SSL support while there is still a pending managed certificate, clear the
    /// `certificate_id` field with an `UpdateDomainMappingRequest`.
    ///
    /// @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PendingManagedCertificateId {
      get { return pendingManagedCertificateId_; }
      set {
        pendingManagedCertificateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SslSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SslSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CertificateId != other.CertificateId) return false;
      if (SslManagementType != other.SslManagementType) return false;
      if (PendingManagedCertificateId != other.PendingManagedCertificateId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CertificateId.Length != 0) hash ^= CertificateId.GetHashCode();
      if (SslManagementType != global::Google.Cloud.AppEngine.V1.SslSettings.Types.SslManagementType.Unspecified) hash ^= SslManagementType.GetHashCode();
      if (PendingManagedCertificateId.Length != 0) hash ^= PendingManagedCertificateId.GetHashCode();
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
      if (CertificateId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CertificateId);
      }
      if (SslManagementType != global::Google.Cloud.AppEngine.V1.SslSettings.Types.SslManagementType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) SslManagementType);
      }
      if (PendingManagedCertificateId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PendingManagedCertificateId);
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
      if (CertificateId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CertificateId);
      }
      if (SslManagementType != global::Google.Cloud.AppEngine.V1.SslSettings.Types.SslManagementType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) SslManagementType);
      }
      if (PendingManagedCertificateId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PendingManagedCertificateId);
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
      if (CertificateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CertificateId);
      }
      if (SslManagementType != global::Google.Cloud.AppEngine.V1.SslSettings.Types.SslManagementType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SslManagementType);
      }
      if (PendingManagedCertificateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PendingManagedCertificateId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SslSettings other) {
      if (other == null) {
        return;
      }
      if (other.CertificateId.Length != 0) {
        CertificateId = other.CertificateId;
      }
      if (other.SslManagementType != global::Google.Cloud.AppEngine.V1.SslSettings.Types.SslManagementType.Unspecified) {
        SslManagementType = other.SslManagementType;
      }
      if (other.PendingManagedCertificateId.Length != 0) {
        PendingManagedCertificateId = other.PendingManagedCertificateId;
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
            CertificateId = input.ReadString();
            break;
          }
          case 24: {
            SslManagementType = (global::Google.Cloud.AppEngine.V1.SslSettings.Types.SslManagementType) input.ReadEnum();
            break;
          }
          case 34: {
            PendingManagedCertificateId = input.ReadString();
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
            CertificateId = input.ReadString();
            break;
          }
          case 24: {
            SslManagementType = (global::Google.Cloud.AppEngine.V1.SslSettings.Types.SslManagementType) input.ReadEnum();
            break;
          }
          case 34: {
            PendingManagedCertificateId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the SslSettings message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The SSL management type for this domain.
      /// </summary>
      public enum SslManagementType {
        /// <summary>
        /// Defaults to `AUTOMATIC`.
        /// </summary>
        [pbr::OriginalName("SSL_MANAGEMENT_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// SSL support for this domain is configured automatically. The mapped SSL
        /// certificate will be automatically renewed.
        /// </summary>
        [pbr::OriginalName("AUTOMATIC")] Automatic = 1,
        /// <summary>
        /// SSL support for this domain is configured manually by the user. Either
        /// the domain has no SSL support or a user-obtained SSL certificate has been
        /// explictly mapped to this domain.
        /// </summary>
        [pbr::OriginalName("MANUAL")] Manual = 2,
      }

    }
    #endregion

  }

  /// <summary>
  /// A DNS resource record.
  /// </summary>
  public sealed partial class ResourceRecord : pb::IMessage<ResourceRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResourceRecord> _parser = new pb::MessageParser<ResourceRecord>(() => new ResourceRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResourceRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AppEngine.V1.DomainMappingReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceRecord(ResourceRecord other) : this() {
      name_ = other.name_;
      rrdata_ = other.rrdata_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceRecord Clone() {
      return new ResourceRecord(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Relative name of the object affected by this record. Only applicable for
    /// `CNAME` records. Example: 'www'.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rrdata" field.</summary>
    public const int RrdataFieldNumber = 2;
    private string rrdata_ = "";
    /// <summary>
    /// Data for this record. Values vary by record type, as defined in RFC 1035
    /// (section 5) and RFC 1034 (section 3.6.1).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Rrdata {
      get { return rrdata_; }
      set {
        rrdata_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Cloud.AppEngine.V1.ResourceRecord.Types.RecordType type_ = global::Google.Cloud.AppEngine.V1.ResourceRecord.Types.RecordType.Unspecified;
    /// <summary>
    /// Resource record type. Example: `AAAA`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AppEngine.V1.ResourceRecord.Types.RecordType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResourceRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResourceRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Rrdata != other.Rrdata) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Rrdata.Length != 0) hash ^= Rrdata.GetHashCode();
      if (Type != global::Google.Cloud.AppEngine.V1.ResourceRecord.Types.RecordType.Unspecified) hash ^= Type.GetHashCode();
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
      if (Rrdata.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Rrdata);
      }
      if (Type != global::Google.Cloud.AppEngine.V1.ResourceRecord.Types.RecordType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
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
      if (Rrdata.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Rrdata);
      }
      if (Type != global::Google.Cloud.AppEngine.V1.ResourceRecord.Types.RecordType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
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
      if (Rrdata.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Rrdata);
      }
      if (Type != global::Google.Cloud.AppEngine.V1.ResourceRecord.Types.RecordType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResourceRecord other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Rrdata.Length != 0) {
        Rrdata = other.Rrdata;
      }
      if (other.Type != global::Google.Cloud.AppEngine.V1.ResourceRecord.Types.RecordType.Unspecified) {
        Type = other.Type;
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
            Rrdata = input.ReadString();
            break;
          }
          case 24: {
            Type = (global::Google.Cloud.AppEngine.V1.ResourceRecord.Types.RecordType) input.ReadEnum();
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
            Rrdata = input.ReadString();
            break;
          }
          case 24: {
            Type = (global::Google.Cloud.AppEngine.V1.ResourceRecord.Types.RecordType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ResourceRecord message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// A resource record type.
      /// </summary>
      public enum RecordType {
        /// <summary>
        /// An unknown resource record.
        /// </summary>
        [pbr::OriginalName("RECORD_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// An A resource record. Data is an IPv4 address.
        /// </summary>
        [pbr::OriginalName("A")] A = 1,
        /// <summary>
        /// An AAAA resource record. Data is an IPv6 address.
        /// </summary>
        [pbr::OriginalName("AAAA")] Aaaa = 2,
        /// <summary>
        /// A CNAME resource record. Data is a domain name to be aliased.
        /// </summary>
        [pbr::OriginalName("CNAME")] Cname = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
