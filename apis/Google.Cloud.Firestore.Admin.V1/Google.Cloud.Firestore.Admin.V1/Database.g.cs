// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/firestore/admin/v1/database.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Firestore.Admin.V1 {

  /// <summary>Holder for reflection information generated from google/firestore/admin/v1/database.proto</summary>
  public static partial class DatabaseReflection {

    #region Descriptor
    /// <summary>File descriptor for google/firestore/admin/v1/database.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DatabaseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvZmlyZXN0b3JlL2FkbWluL3YxL2RhdGFiYXNlLnByb3RvEhln",
            "b29nbGUuZmlyZXN0b3JlLmFkbWluLnYxGh9nb29nbGUvYXBpL2ZpZWxkX2Jl",
            "aGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGh5nb29n",
            "bGUvcHJvdG9idWYvZHVyYXRpb24ucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8i3ggKCERhdGFiYXNlEgwKBG5hbWUYASABKAkSEwoL",
            "bG9jYXRpb25faWQYCSABKAkSPgoEdHlwZRgKIAEoDjIwLmdvb2dsZS5maXJl",
            "c3RvcmUuYWRtaW4udjEuRGF0YWJhc2UuRGF0YWJhc2VUeXBlEk0KEGNvbmN1",
            "cnJlbmN5X21vZGUYDyABKA4yMy5nb29nbGUuZmlyZXN0b3JlLmFkbWluLnYx",
            "LkRhdGFiYXNlLkNvbmN1cnJlbmN5TW9kZRJAChh2ZXJzaW9uX3JldGVudGlv",
            "bl9wZXJpb2QYESABKAsyGS5nb29nbGUucHJvdG9idWYuRHVyYXRpb25CA+BB",
            "AxI+ChVlYXJsaWVzdF92ZXJzaW9uX3RpbWUYEiABKAsyGi5nb29nbGUucHJv",
            "dG9idWYuVGltZXN0YW1wQgPgQQMSbAohcG9pbnRfaW5fdGltZV9yZWNvdmVy",
            "eV9lbmFibGVtZW50GBUgASgOMkEuZ29vZ2xlLmZpcmVzdG9yZS5hZG1pbi52",
            "MS5EYXRhYmFzZS5Qb2ludEluVGltZVJlY292ZXJ5RW5hYmxlbWVudBJhChth",
            "cHBfZW5naW5lX2ludGVncmF0aW9uX21vZGUYEyABKA4yPC5nb29nbGUuZmly",
            "ZXN0b3JlLmFkbWluLnYxLkRhdGFiYXNlLkFwcEVuZ2luZUludGVncmF0aW9u",
            "TW9kZRIXCgprZXlfcHJlZml4GBQgASgJQgPgQQMSDAoEZXRhZxhjIAEoCSJX",
            "CgxEYXRhYmFzZVR5cGUSHQoZREFUQUJBU0VfVFlQRV9VTlNQRUNJRklFRBAA",
            "EhQKEEZJUkVTVE9SRV9OQVRJVkUQARISCg5EQVRBU1RPUkVfTU9ERRACIncK",
            "D0NvbmN1cnJlbmN5TW9kZRIgChxDT05DVVJSRU5DWV9NT0RFX1VOU1BFQ0lG",
            "SUVEEAASDgoKT1BUSU1JU1RJQxABEg8KC1BFU1NJTUlTVElDEAISIQodT1BU",
            "SU1JU1RJQ19XSVRIX0VOVElUWV9HUk9VUFMQAyKbAQodUG9pbnRJblRpbWVS",
            "ZWNvdmVyeUVuYWJsZW1lbnQSMQotUE9JTlRfSU5fVElNRV9SRUNPVkVSWV9F",
            "TkFCTEVNRU5UX1VOU1BFQ0lGSUVEEAASIgoeUE9JTlRfSU5fVElNRV9SRUNP",
            "VkVSWV9FTkFCTEVEEAESIwofUE9JTlRfSU5fVElNRV9SRUNPVkVSWV9ESVNB",
            "QkxFRBACImIKGEFwcEVuZ2luZUludGVncmF0aW9uTW9kZRIrCidBUFBfRU5H",
            "SU5FX0lOVEVHUkFUSU9OX01PREVfVU5TUEVDSUZJRUQQABILCgdFTkFCTEVE",
            "EAESDAoIRElTQUJMRUQQAjpS6kFPCiFmaXJlc3RvcmUuZ29vZ2xlYXBpcy5j",
            "b20vRGF0YWJhc2USJ3Byb2plY3RzL3twcm9qZWN0fS9kYXRhYmFzZXMve2Rh",
            "dGFiYXNlfVIBAULcAQodY29tLmdvb2dsZS5maXJlc3RvcmUuYWRtaW4udjFC",
            "DURhdGFiYXNlUHJvdG9QAVo5Y2xvdWQuZ29vZ2xlLmNvbS9nby9maXJlc3Rv",
            "cmUvYXBpdjEvYWRtaW4vYWRtaW5wYjthZG1pbnBiogIER0NGU6oCH0dvb2ds",
            "ZS5DbG91ZC5GaXJlc3RvcmUuQWRtaW4uVjHKAh9Hb29nbGVcQ2xvdWRcRmly",
            "ZXN0b3JlXEFkbWluXFYx6gIjR29vZ2xlOjpDbG91ZDo6RmlyZXN0b3JlOjpB",
            "ZG1pbjo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Database), global::Google.Cloud.Firestore.Admin.V1.Database.Parser, new[]{ "Name", "LocationId", "Type", "ConcurrencyMode", "VersionRetentionPeriod", "EarliestVersionTime", "PointInTimeRecoveryEnablement", "AppEngineIntegrationMode", "KeyPrefix", "Etag" }, null, new[]{ typeof(global::Google.Cloud.Firestore.Admin.V1.Database.Types.DatabaseType), typeof(global::Google.Cloud.Firestore.Admin.V1.Database.Types.ConcurrencyMode), typeof(global::Google.Cloud.Firestore.Admin.V1.Database.Types.PointInTimeRecoveryEnablement), typeof(global::Google.Cloud.Firestore.Admin.V1.Database.Types.AppEngineIntegrationMode) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Cloud Firestore Database.
  /// Currently only one database is allowed per cloud project; this database
  /// must have a `database_id` of '(default)'.
  /// </summary>
  public sealed partial class Database : pb::IMessage<Database>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Database> _parser = new pb::MessageParser<Database>(() => new Database());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Database> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Firestore.Admin.V1.DatabaseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Database() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Database(Database other) : this() {
      name_ = other.name_;
      locationId_ = other.locationId_;
      type_ = other.type_;
      concurrencyMode_ = other.concurrencyMode_;
      versionRetentionPeriod_ = other.versionRetentionPeriod_ != null ? other.versionRetentionPeriod_.Clone() : null;
      earliestVersionTime_ = other.earliestVersionTime_ != null ? other.earliestVersionTime_.Clone() : null;
      pointInTimeRecoveryEnablement_ = other.pointInTimeRecoveryEnablement_;
      appEngineIntegrationMode_ = other.appEngineIntegrationMode_;
      keyPrefix_ = other.keyPrefix_;
      etag_ = other.etag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Database Clone() {
      return new Database(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The resource name of the Database.
    /// Format: `projects/{project}/databases/{database}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "location_id" field.</summary>
    public const int LocationIdFieldNumber = 9;
    private string locationId_ = "";
    /// <summary>
    /// The location of the database. Available locations are listed at
    /// https://cloud.google.com/firestore/docs/locations.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LocationId {
      get { return locationId_; }
      set {
        locationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 10;
    private global::Google.Cloud.Firestore.Admin.V1.Database.Types.DatabaseType type_ = global::Google.Cloud.Firestore.Admin.V1.Database.Types.DatabaseType.Unspecified;
    /// <summary>
    /// The type of the database.
    /// See https://cloud.google.com/datastore/docs/firestore-or-datastore for
    /// information about how to choose.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Firestore.Admin.V1.Database.Types.DatabaseType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "concurrency_mode" field.</summary>
    public const int ConcurrencyModeFieldNumber = 15;
    private global::Google.Cloud.Firestore.Admin.V1.Database.Types.ConcurrencyMode concurrencyMode_ = global::Google.Cloud.Firestore.Admin.V1.Database.Types.ConcurrencyMode.Unspecified;
    /// <summary>
    /// The concurrency control mode to use for this database.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Firestore.Admin.V1.Database.Types.ConcurrencyMode ConcurrencyMode {
      get { return concurrencyMode_; }
      set {
        concurrencyMode_ = value;
      }
    }

    /// <summary>Field number for the "version_retention_period" field.</summary>
    public const int VersionRetentionPeriodFieldNumber = 17;
    private global::Google.Protobuf.WellKnownTypes.Duration versionRetentionPeriod_;
    /// <summary>
    /// Output only. The period during which past versions of data are retained in
    /// the database.
    ///
    /// Any [read][google.firestore.v1.GetDocumentRequest.read_time]
    /// or [query][google.firestore.v1.ListDocumentsRequest.read_time] can specify
    /// a `read_time` within this window, and will read the state of the database
    /// at that time.
    ///
    /// If the PITR feature is enabled, the retention period is 7 days. Otherwise,
    /// the retention period is 1 hour.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration VersionRetentionPeriod {
      get { return versionRetentionPeriod_; }
      set {
        versionRetentionPeriod_ = value;
      }
    }

    /// <summary>Field number for the "earliest_version_time" field.</summary>
    public const int EarliestVersionTimeFieldNumber = 18;
    private global::Google.Protobuf.WellKnownTypes.Timestamp earliestVersionTime_;
    /// <summary>
    /// Output only. The earliest timestamp at which older versions of the data can
    /// be read from the database. See [version_retention_period] above; this field
    /// is populated with `now - version_retention_period`.
    ///
    /// This value is continuously updated, and becomes stale the moment it is
    /// queried. If you are using this value to recover data, make sure to account
    /// for the time from the moment when the value is queried to the moment when
    /// you initiate the recovery.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EarliestVersionTime {
      get { return earliestVersionTime_; }
      set {
        earliestVersionTime_ = value;
      }
    }

    /// <summary>Field number for the "point_in_time_recovery_enablement" field.</summary>
    public const int PointInTimeRecoveryEnablementFieldNumber = 21;
    private global::Google.Cloud.Firestore.Admin.V1.Database.Types.PointInTimeRecoveryEnablement pointInTimeRecoveryEnablement_ = global::Google.Cloud.Firestore.Admin.V1.Database.Types.PointInTimeRecoveryEnablement.Unspecified;
    /// <summary>
    /// Whether to enable the PITR feature on this database.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Firestore.Admin.V1.Database.Types.PointInTimeRecoveryEnablement PointInTimeRecoveryEnablement {
      get { return pointInTimeRecoveryEnablement_; }
      set {
        pointInTimeRecoveryEnablement_ = value;
      }
    }

    /// <summary>Field number for the "app_engine_integration_mode" field.</summary>
    public const int AppEngineIntegrationModeFieldNumber = 19;
    private global::Google.Cloud.Firestore.Admin.V1.Database.Types.AppEngineIntegrationMode appEngineIntegrationMode_ = global::Google.Cloud.Firestore.Admin.V1.Database.Types.AppEngineIntegrationMode.Unspecified;
    /// <summary>
    /// The App Engine integration mode to use for this database.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Firestore.Admin.V1.Database.Types.AppEngineIntegrationMode AppEngineIntegrationMode {
      get { return appEngineIntegrationMode_; }
      set {
        appEngineIntegrationMode_ = value;
      }
    }

    /// <summary>Field number for the "key_prefix" field.</summary>
    public const int KeyPrefixFieldNumber = 20;
    private string keyPrefix_ = "";
    /// <summary>
    /// Output only. The key_prefix for this database. This key_prefix is used, in
    /// combination with the project id ("&lt;key prefix>~&lt;project id>") to construct
    /// the application id that is returned from the Cloud Datastore APIs in Google
    /// App Engine first generation runtimes.
    ///
    /// This value may be empty in which case the appid to use for URL-encoded keys
    /// is the project_id (eg: foo instead of v~foo).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string KeyPrefix {
      get { return keyPrefix_; }
      set {
        keyPrefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 99;
    private string etag_ = "";
    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Database);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Database other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (LocationId != other.LocationId) return false;
      if (Type != other.Type) return false;
      if (ConcurrencyMode != other.ConcurrencyMode) return false;
      if (!object.Equals(VersionRetentionPeriod, other.VersionRetentionPeriod)) return false;
      if (!object.Equals(EarliestVersionTime, other.EarliestVersionTime)) return false;
      if (PointInTimeRecoveryEnablement != other.PointInTimeRecoveryEnablement) return false;
      if (AppEngineIntegrationMode != other.AppEngineIntegrationMode) return false;
      if (KeyPrefix != other.KeyPrefix) return false;
      if (Etag != other.Etag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (LocationId.Length != 0) hash ^= LocationId.GetHashCode();
      if (Type != global::Google.Cloud.Firestore.Admin.V1.Database.Types.DatabaseType.Unspecified) hash ^= Type.GetHashCode();
      if (ConcurrencyMode != global::Google.Cloud.Firestore.Admin.V1.Database.Types.ConcurrencyMode.Unspecified) hash ^= ConcurrencyMode.GetHashCode();
      if (versionRetentionPeriod_ != null) hash ^= VersionRetentionPeriod.GetHashCode();
      if (earliestVersionTime_ != null) hash ^= EarliestVersionTime.GetHashCode();
      if (PointInTimeRecoveryEnablement != global::Google.Cloud.Firestore.Admin.V1.Database.Types.PointInTimeRecoveryEnablement.Unspecified) hash ^= PointInTimeRecoveryEnablement.GetHashCode();
      if (AppEngineIntegrationMode != global::Google.Cloud.Firestore.Admin.V1.Database.Types.AppEngineIntegrationMode.Unspecified) hash ^= AppEngineIntegrationMode.GetHashCode();
      if (KeyPrefix.Length != 0) hash ^= KeyPrefix.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
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
      if (LocationId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(LocationId);
      }
      if (Type != global::Google.Cloud.Firestore.Admin.V1.Database.Types.DatabaseType.Unspecified) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Type);
      }
      if (ConcurrencyMode != global::Google.Cloud.Firestore.Admin.V1.Database.Types.ConcurrencyMode.Unspecified) {
        output.WriteRawTag(120);
        output.WriteEnum((int) ConcurrencyMode);
      }
      if (versionRetentionPeriod_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(VersionRetentionPeriod);
      }
      if (earliestVersionTime_ != null) {
        output.WriteRawTag(146, 1);
        output.WriteMessage(EarliestVersionTime);
      }
      if (AppEngineIntegrationMode != global::Google.Cloud.Firestore.Admin.V1.Database.Types.AppEngineIntegrationMode.Unspecified) {
        output.WriteRawTag(152, 1);
        output.WriteEnum((int) AppEngineIntegrationMode);
      }
      if (KeyPrefix.Length != 0) {
        output.WriteRawTag(162, 1);
        output.WriteString(KeyPrefix);
      }
      if (PointInTimeRecoveryEnablement != global::Google.Cloud.Firestore.Admin.V1.Database.Types.PointInTimeRecoveryEnablement.Unspecified) {
        output.WriteRawTag(168, 1);
        output.WriteEnum((int) PointInTimeRecoveryEnablement);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(154, 6);
        output.WriteString(Etag);
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
      if (LocationId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(LocationId);
      }
      if (Type != global::Google.Cloud.Firestore.Admin.V1.Database.Types.DatabaseType.Unspecified) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Type);
      }
      if (ConcurrencyMode != global::Google.Cloud.Firestore.Admin.V1.Database.Types.ConcurrencyMode.Unspecified) {
        output.WriteRawTag(120);
        output.WriteEnum((int) ConcurrencyMode);
      }
      if (versionRetentionPeriod_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(VersionRetentionPeriod);
      }
      if (earliestVersionTime_ != null) {
        output.WriteRawTag(146, 1);
        output.WriteMessage(EarliestVersionTime);
      }
      if (AppEngineIntegrationMode != global::Google.Cloud.Firestore.Admin.V1.Database.Types.AppEngineIntegrationMode.Unspecified) {
        output.WriteRawTag(152, 1);
        output.WriteEnum((int) AppEngineIntegrationMode);
      }
      if (KeyPrefix.Length != 0) {
        output.WriteRawTag(162, 1);
        output.WriteString(KeyPrefix);
      }
      if (PointInTimeRecoveryEnablement != global::Google.Cloud.Firestore.Admin.V1.Database.Types.PointInTimeRecoveryEnablement.Unspecified) {
        output.WriteRawTag(168, 1);
        output.WriteEnum((int) PointInTimeRecoveryEnablement);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(154, 6);
        output.WriteString(Etag);
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
      if (LocationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LocationId);
      }
      if (Type != global::Google.Cloud.Firestore.Admin.V1.Database.Types.DatabaseType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (ConcurrencyMode != global::Google.Cloud.Firestore.Admin.V1.Database.Types.ConcurrencyMode.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ConcurrencyMode);
      }
      if (versionRetentionPeriod_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(VersionRetentionPeriod);
      }
      if (earliestVersionTime_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(EarliestVersionTime);
      }
      if (PointInTimeRecoveryEnablement != global::Google.Cloud.Firestore.Admin.V1.Database.Types.PointInTimeRecoveryEnablement.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) PointInTimeRecoveryEnablement);
      }
      if (AppEngineIntegrationMode != global::Google.Cloud.Firestore.Admin.V1.Database.Types.AppEngineIntegrationMode.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) AppEngineIntegrationMode);
      }
      if (KeyPrefix.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(KeyPrefix);
      }
      if (Etag.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Database other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.LocationId.Length != 0) {
        LocationId = other.LocationId;
      }
      if (other.Type != global::Google.Cloud.Firestore.Admin.V1.Database.Types.DatabaseType.Unspecified) {
        Type = other.Type;
      }
      if (other.ConcurrencyMode != global::Google.Cloud.Firestore.Admin.V1.Database.Types.ConcurrencyMode.Unspecified) {
        ConcurrencyMode = other.ConcurrencyMode;
      }
      if (other.versionRetentionPeriod_ != null) {
        if (versionRetentionPeriod_ == null) {
          VersionRetentionPeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        VersionRetentionPeriod.MergeFrom(other.VersionRetentionPeriod);
      }
      if (other.earliestVersionTime_ != null) {
        if (earliestVersionTime_ == null) {
          EarliestVersionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EarliestVersionTime.MergeFrom(other.EarliestVersionTime);
      }
      if (other.PointInTimeRecoveryEnablement != global::Google.Cloud.Firestore.Admin.V1.Database.Types.PointInTimeRecoveryEnablement.Unspecified) {
        PointInTimeRecoveryEnablement = other.PointInTimeRecoveryEnablement;
      }
      if (other.AppEngineIntegrationMode != global::Google.Cloud.Firestore.Admin.V1.Database.Types.AppEngineIntegrationMode.Unspecified) {
        AppEngineIntegrationMode = other.AppEngineIntegrationMode;
      }
      if (other.KeyPrefix.Length != 0) {
        KeyPrefix = other.KeyPrefix;
      }
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
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
          case 74: {
            LocationId = input.ReadString();
            break;
          }
          case 80: {
            Type = (global::Google.Cloud.Firestore.Admin.V1.Database.Types.DatabaseType) input.ReadEnum();
            break;
          }
          case 120: {
            ConcurrencyMode = (global::Google.Cloud.Firestore.Admin.V1.Database.Types.ConcurrencyMode) input.ReadEnum();
            break;
          }
          case 138: {
            if (versionRetentionPeriod_ == null) {
              VersionRetentionPeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(VersionRetentionPeriod);
            break;
          }
          case 146: {
            if (earliestVersionTime_ == null) {
              EarliestVersionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EarliestVersionTime);
            break;
          }
          case 152: {
            AppEngineIntegrationMode = (global::Google.Cloud.Firestore.Admin.V1.Database.Types.AppEngineIntegrationMode) input.ReadEnum();
            break;
          }
          case 162: {
            KeyPrefix = input.ReadString();
            break;
          }
          case 168: {
            PointInTimeRecoveryEnablement = (global::Google.Cloud.Firestore.Admin.V1.Database.Types.PointInTimeRecoveryEnablement) input.ReadEnum();
            break;
          }
          case 794: {
            Etag = input.ReadString();
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
          case 74: {
            LocationId = input.ReadString();
            break;
          }
          case 80: {
            Type = (global::Google.Cloud.Firestore.Admin.V1.Database.Types.DatabaseType) input.ReadEnum();
            break;
          }
          case 120: {
            ConcurrencyMode = (global::Google.Cloud.Firestore.Admin.V1.Database.Types.ConcurrencyMode) input.ReadEnum();
            break;
          }
          case 138: {
            if (versionRetentionPeriod_ == null) {
              VersionRetentionPeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(VersionRetentionPeriod);
            break;
          }
          case 146: {
            if (earliestVersionTime_ == null) {
              EarliestVersionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EarliestVersionTime);
            break;
          }
          case 152: {
            AppEngineIntegrationMode = (global::Google.Cloud.Firestore.Admin.V1.Database.Types.AppEngineIntegrationMode) input.ReadEnum();
            break;
          }
          case 162: {
            KeyPrefix = input.ReadString();
            break;
          }
          case 168: {
            PointInTimeRecoveryEnablement = (global::Google.Cloud.Firestore.Admin.V1.Database.Types.PointInTimeRecoveryEnablement) input.ReadEnum();
            break;
          }
          case 794: {
            Etag = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Database message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The type of the database.
      /// See https://cloud.google.com/datastore/docs/firestore-or-datastore for
      /// information about how to choose.
      ///
      /// Mode changes are only allowed if the database is empty.
      /// </summary>
      public enum DatabaseType {
        /// <summary>
        /// The default value. This value is used if the database type is omitted.
        /// </summary>
        [pbr::OriginalName("DATABASE_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Firestore Native Mode
        /// </summary>
        [pbr::OriginalName("FIRESTORE_NATIVE")] FirestoreNative = 1,
        /// <summary>
        /// Firestore in Datastore Mode.
        /// </summary>
        [pbr::OriginalName("DATASTORE_MODE")] DatastoreMode = 2,
      }

      /// <summary>
      /// The type of concurrency control mode for transactions.
      /// </summary>
      public enum ConcurrencyMode {
        /// <summary>
        /// Not used.
        /// </summary>
        [pbr::OriginalName("CONCURRENCY_MODE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Use optimistic concurrency control by default. This mode is available
        /// for Cloud Firestore databases.
        /// </summary>
        [pbr::OriginalName("OPTIMISTIC")] Optimistic = 1,
        /// <summary>
        /// Use pessimistic concurrency control by default. This mode is available
        /// for Cloud Firestore databases.
        ///
        /// This is the default setting for Cloud Firestore.
        /// </summary>
        [pbr::OriginalName("PESSIMISTIC")] Pessimistic = 2,
        /// <summary>
        /// Use optimistic concurrency control with entity groups by default.
        ///
        /// This is the only available mode for Cloud Datastore.
        ///
        /// This mode is also available for Cloud Firestore with Datastore Mode but
        /// is not recommended.
        /// </summary>
        [pbr::OriginalName("OPTIMISTIC_WITH_ENTITY_GROUPS")] OptimisticWithEntityGroups = 3,
      }

      /// <summary>
      /// Point In Time Recovery feature enablement.
      /// </summary>
      public enum PointInTimeRecoveryEnablement {
        /// <summary>
        /// Not used.
        /// </summary>
        [pbr::OriginalName("POINT_IN_TIME_RECOVERY_ENABLEMENT_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Reads are supported on selected versions of the data from within the past
        /// 7 days:
        ///
        /// * Reads against any timestamp within the past hour
        /// * Reads against 1-minute snapshots beyond 1 hour and within 7 days
        ///
        /// `version_retention_period` and `earliest_version_time` can be
        /// used to determine the supported versions.
        /// </summary>
        [pbr::OriginalName("POINT_IN_TIME_RECOVERY_ENABLED")] PointInTimeRecoveryEnabled = 1,
        /// <summary>
        /// Reads are supported on any version of the data from within the past 1
        /// hour.
        /// </summary>
        [pbr::OriginalName("POINT_IN_TIME_RECOVERY_DISABLED")] PointInTimeRecoveryDisabled = 2,
      }

      /// <summary>
      /// The type of App Engine integration mode.
      /// </summary>
      public enum AppEngineIntegrationMode {
        /// <summary>
        /// Not used.
        /// </summary>
        [pbr::OriginalName("APP_ENGINE_INTEGRATION_MODE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// If an App Engine application exists in the same region as this database,
        /// App Engine configuration will impact this database. This includes
        /// disabling of the application &amp; database, as well as disabling writes to
        /// the database.
        /// </summary>
        [pbr::OriginalName("ENABLED")] Enabled = 1,
        /// <summary>
        /// App Engine has no effect on the ability of this database to serve
        /// requests.
        ///
        /// This is the default setting for databases created with the Firestore API.
        /// </summary>
        [pbr::OriginalName("DISABLED")] Disabled = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
