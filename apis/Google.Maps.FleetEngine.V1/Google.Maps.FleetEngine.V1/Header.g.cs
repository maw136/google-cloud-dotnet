// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/fleetengine/v1/header.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.FleetEngine.V1 {

  /// <summary>Holder for reflection information generated from google/maps/fleetengine/v1/header.proto</summary>
  public static partial class HeaderReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/fleetengine/v1/header.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeaderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidnb29nbGUvbWFwcy9mbGVldGVuZ2luZS92MS9oZWFkZXIucHJvdG8SE21h",
            "cHMuZmxlZXRlbmdpbmUudjEaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3Iu",
            "cHJvdG8ihgQKDVJlcXVlc3RIZWFkZXISFQoNbGFuZ3VhZ2VfY29kZRgBIAEo",
            "CRIYCgtyZWdpb25fY29kZRgCIAEoCUID4EECEhMKC3Nka192ZXJzaW9uGAMg",
            "ASgJEhIKCm9zX3ZlcnNpb24YBCABKAkSFAoMZGV2aWNlX21vZGVsGAUgASgJ",
            "EjwKCHNka190eXBlGAYgASgOMioubWFwcy5mbGVldGVuZ2luZS52MS5SZXF1",
            "ZXN0SGVhZGVyLlNka1R5cGUSGAoQbWFwc19zZGtfdmVyc2lvbhgHIAEoCRIX",
            "Cg9uYXZfc2RrX3ZlcnNpb24YCCABKAkSPQoIcGxhdGZvcm0YCSABKA4yKy5t",
            "YXBzLmZsZWV0ZW5naW5lLnYxLlJlcXVlc3RIZWFkZXIuUGxhdGZvcm0SFAoM",
            "bWFudWZhY3R1cmVyGAogASgJEhkKEWFuZHJvaWRfYXBpX2xldmVsGAsgASgF",
            "EhAKCHRyYWNlX2lkGAwgASgJIk0KB1Nka1R5cGUSGAoUU0RLX1RZUEVfVU5T",
            "UEVDSUZJRUQQABIMCghDT05TVU1FUhABEgoKBkRSSVZFUhACEg4KCkpBVkFT",
            "Q1JJUFQQAyJDCghQbGF0Zm9ybRIYChRQTEFURk9STV9VTlNQRUNJRklFRBAA",
            "EgsKB0FORFJPSUQQARIHCgNJT1MQAhIHCgNXRUIQA0KSAQoaZ29vZ2xlLm1h",
            "cHMuZmxlZXRlbmdpbmUudjFCB0hlYWRlcnNQAVpGY2xvdWQuZ29vZ2xlLmNv",
            "bS9nby9tYXBzL2ZsZWV0ZW5naW5lL2FwaXYxL2ZsZWV0ZW5naW5lcGI7Zmxl",
            "ZXRlbmdpbmVwYqICA0NGRaoCGkdvb2dsZS5NYXBzLkZsZWV0RW5naW5lLlYx",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.FleetEngine.V1.RequestHeader), global::Google.Maps.FleetEngine.V1.RequestHeader.Parser, new[]{ "LanguageCode", "RegionCode", "SdkVersion", "OsVersion", "DeviceModel", "SdkType", "MapsSdkVersion", "NavSdkVersion", "Platform", "Manufacturer", "AndroidApiLevel", "TraceId" }, null, new[]{ typeof(global::Google.Maps.FleetEngine.V1.RequestHeader.Types.SdkType), typeof(global::Google.Maps.FleetEngine.V1.RequestHeader.Types.Platform) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A RequestHeader contains fields common to all Fleet Engine RPC requests.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RequestHeader : pb::IMessage<RequestHeader>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RequestHeader> _parser = new pb::MessageParser<RequestHeader>(() => new RequestHeader());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RequestHeader> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.FleetEngine.V1.HeaderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestHeader() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestHeader(RequestHeader other) : this() {
      languageCode_ = other.languageCode_;
      regionCode_ = other.regionCode_;
      sdkVersion_ = other.sdkVersion_;
      osVersion_ = other.osVersion_;
      deviceModel_ = other.deviceModel_;
      sdkType_ = other.sdkType_;
      mapsSdkVersion_ = other.mapsSdkVersion_;
      navSdkVersion_ = other.navSdkVersion_;
      platform_ = other.platform_;
      manufacturer_ = other.manufacturer_;
      androidApiLevel_ = other.androidApiLevel_;
      traceId_ = other.traceId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestHeader Clone() {
      return new RequestHeader(this);
    }

    /// <summary>Field number for the "language_code" field.</summary>
    public const int LanguageCodeFieldNumber = 1;
    private string languageCode_ = "";
    /// <summary>
    /// The BCP-47 language code, such as en-US or sr-Latn. For more information,
    /// see http://www.unicode.org/reports/tr35/#Unicode_locale_identifier. If none
    /// is specified, the response may be in any language, with a preference for
    /// English if such a name exists. Field value example: `en-US`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LanguageCode {
      get { return languageCode_; }
      set {
        languageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "region_code" field.</summary>
    public const int RegionCodeFieldNumber = 2;
    private string regionCode_ = "";
    /// <summary>
    /// Required. CLDR region code of the region where the request originates.
    /// Field value example: `US`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RegionCode {
      get { return regionCode_; }
      set {
        regionCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sdk_version" field.</summary>
    public const int SdkVersionFieldNumber = 3;
    private string sdkVersion_ = "";
    /// <summary>
    /// Version of the calling SDK, if applicable.
    /// The version format is "major.minor.patch", example: `1.1.2`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SdkVersion {
      get { return sdkVersion_; }
      set {
        sdkVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "os_version" field.</summary>
    public const int OsVersionFieldNumber = 4;
    private string osVersion_ = "";
    /// <summary>
    /// Version of the operating system on which the calling SDK is running.
    /// Field value examples: `4.4.1`, `12.1`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OsVersion {
      get { return osVersion_; }
      set {
        osVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "device_model" field.</summary>
    public const int DeviceModelFieldNumber = 5;
    private string deviceModel_ = "";
    /// <summary>
    /// Model of the device on which the calling SDK is running.
    /// Field value examples: `iPhone12,1`, `SM-G920F`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DeviceModel {
      get { return deviceModel_; }
      set {
        deviceModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sdk_type" field.</summary>
    public const int SdkTypeFieldNumber = 6;
    private global::Google.Maps.FleetEngine.V1.RequestHeader.Types.SdkType sdkType_ = global::Google.Maps.FleetEngine.V1.RequestHeader.Types.SdkType.Unspecified;
    /// <summary>
    /// The type of SDK sending the request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.FleetEngine.V1.RequestHeader.Types.SdkType SdkType {
      get { return sdkType_; }
      set {
        sdkType_ = value;
      }
    }

    /// <summary>Field number for the "maps_sdk_version" field.</summary>
    public const int MapsSdkVersionFieldNumber = 7;
    private string mapsSdkVersion_ = "";
    /// <summary>
    /// Version of the MapSDK which the calling SDK depends on, if applicable.
    /// The version format is "major.minor.patch", example: `5.2.1`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MapsSdkVersion {
      get { return mapsSdkVersion_; }
      set {
        mapsSdkVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "nav_sdk_version" field.</summary>
    public const int NavSdkVersionFieldNumber = 8;
    private string navSdkVersion_ = "";
    /// <summary>
    /// Version of the NavSDK which the calling SDK depends on, if applicable.
    /// The version format is "major.minor.patch", example: `2.1.0`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NavSdkVersion {
      get { return navSdkVersion_; }
      set {
        navSdkVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 9;
    private global::Google.Maps.FleetEngine.V1.RequestHeader.Types.Platform platform_ = global::Google.Maps.FleetEngine.V1.RequestHeader.Types.Platform.Unspecified;
    /// <summary>
    /// Platform of the calling SDK.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.FleetEngine.V1.RequestHeader.Types.Platform Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "manufacturer" field.</summary>
    public const int ManufacturerFieldNumber = 10;
    private string manufacturer_ = "";
    /// <summary>
    /// Manufacturer of the Android device from the calling SDK, only applicable
    /// for the Android SDKs.
    /// Field value example: `Samsung`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Manufacturer {
      get { return manufacturer_; }
      set {
        manufacturer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "android_api_level" field.</summary>
    public const int AndroidApiLevelFieldNumber = 11;
    private int androidApiLevel_;
    /// <summary>
    /// Android API level of the calling SDK, only applicable for the Android SDKs.
    /// Field value example: `23`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int AndroidApiLevel {
      get { return androidApiLevel_; }
      set {
        androidApiLevel_ = value;
      }
    }

    /// <summary>Field number for the "trace_id" field.</summary>
    public const int TraceIdFieldNumber = 12;
    private string traceId_ = "";
    /// <summary>
    /// Optional ID that can be provided for logging purposes in order to identify
    /// the request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TraceId {
      get { return traceId_; }
      set {
        traceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RequestHeader);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RequestHeader other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LanguageCode != other.LanguageCode) return false;
      if (RegionCode != other.RegionCode) return false;
      if (SdkVersion != other.SdkVersion) return false;
      if (OsVersion != other.OsVersion) return false;
      if (DeviceModel != other.DeviceModel) return false;
      if (SdkType != other.SdkType) return false;
      if (MapsSdkVersion != other.MapsSdkVersion) return false;
      if (NavSdkVersion != other.NavSdkVersion) return false;
      if (Platform != other.Platform) return false;
      if (Manufacturer != other.Manufacturer) return false;
      if (AndroidApiLevel != other.AndroidApiLevel) return false;
      if (TraceId != other.TraceId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LanguageCode.Length != 0) hash ^= LanguageCode.GetHashCode();
      if (RegionCode.Length != 0) hash ^= RegionCode.GetHashCode();
      if (SdkVersion.Length != 0) hash ^= SdkVersion.GetHashCode();
      if (OsVersion.Length != 0) hash ^= OsVersion.GetHashCode();
      if (DeviceModel.Length != 0) hash ^= DeviceModel.GetHashCode();
      if (SdkType != global::Google.Maps.FleetEngine.V1.RequestHeader.Types.SdkType.Unspecified) hash ^= SdkType.GetHashCode();
      if (MapsSdkVersion.Length != 0) hash ^= MapsSdkVersion.GetHashCode();
      if (NavSdkVersion.Length != 0) hash ^= NavSdkVersion.GetHashCode();
      if (Platform != global::Google.Maps.FleetEngine.V1.RequestHeader.Types.Platform.Unspecified) hash ^= Platform.GetHashCode();
      if (Manufacturer.Length != 0) hash ^= Manufacturer.GetHashCode();
      if (AndroidApiLevel != 0) hash ^= AndroidApiLevel.GetHashCode();
      if (TraceId.Length != 0) hash ^= TraceId.GetHashCode();
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
      if (LanguageCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LanguageCode);
      }
      if (RegionCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RegionCode);
      }
      if (SdkVersion.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SdkVersion);
      }
      if (OsVersion.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OsVersion);
      }
      if (DeviceModel.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DeviceModel);
      }
      if (SdkType != global::Google.Maps.FleetEngine.V1.RequestHeader.Types.SdkType.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) SdkType);
      }
      if (MapsSdkVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(MapsSdkVersion);
      }
      if (NavSdkVersion.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(NavSdkVersion);
      }
      if (Platform != global::Google.Maps.FleetEngine.V1.RequestHeader.Types.Platform.Unspecified) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Platform);
      }
      if (Manufacturer.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Manufacturer);
      }
      if (AndroidApiLevel != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(AndroidApiLevel);
      }
      if (TraceId.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(TraceId);
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
      if (LanguageCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LanguageCode);
      }
      if (RegionCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RegionCode);
      }
      if (SdkVersion.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SdkVersion);
      }
      if (OsVersion.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OsVersion);
      }
      if (DeviceModel.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DeviceModel);
      }
      if (SdkType != global::Google.Maps.FleetEngine.V1.RequestHeader.Types.SdkType.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) SdkType);
      }
      if (MapsSdkVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(MapsSdkVersion);
      }
      if (NavSdkVersion.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(NavSdkVersion);
      }
      if (Platform != global::Google.Maps.FleetEngine.V1.RequestHeader.Types.Platform.Unspecified) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Platform);
      }
      if (Manufacturer.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Manufacturer);
      }
      if (AndroidApiLevel != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(AndroidApiLevel);
      }
      if (TraceId.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(TraceId);
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
      if (LanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageCode);
      }
      if (RegionCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RegionCode);
      }
      if (SdkVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SdkVersion);
      }
      if (OsVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OsVersion);
      }
      if (DeviceModel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceModel);
      }
      if (SdkType != global::Google.Maps.FleetEngine.V1.RequestHeader.Types.SdkType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SdkType);
      }
      if (MapsSdkVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MapsSdkVersion);
      }
      if (NavSdkVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NavSdkVersion);
      }
      if (Platform != global::Google.Maps.FleetEngine.V1.RequestHeader.Types.Platform.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      if (Manufacturer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Manufacturer);
      }
      if (AndroidApiLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AndroidApiLevel);
      }
      if (TraceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TraceId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RequestHeader other) {
      if (other == null) {
        return;
      }
      if (other.LanguageCode.Length != 0) {
        LanguageCode = other.LanguageCode;
      }
      if (other.RegionCode.Length != 0) {
        RegionCode = other.RegionCode;
      }
      if (other.SdkVersion.Length != 0) {
        SdkVersion = other.SdkVersion;
      }
      if (other.OsVersion.Length != 0) {
        OsVersion = other.OsVersion;
      }
      if (other.DeviceModel.Length != 0) {
        DeviceModel = other.DeviceModel;
      }
      if (other.SdkType != global::Google.Maps.FleetEngine.V1.RequestHeader.Types.SdkType.Unspecified) {
        SdkType = other.SdkType;
      }
      if (other.MapsSdkVersion.Length != 0) {
        MapsSdkVersion = other.MapsSdkVersion;
      }
      if (other.NavSdkVersion.Length != 0) {
        NavSdkVersion = other.NavSdkVersion;
      }
      if (other.Platform != global::Google.Maps.FleetEngine.V1.RequestHeader.Types.Platform.Unspecified) {
        Platform = other.Platform;
      }
      if (other.Manufacturer.Length != 0) {
        Manufacturer = other.Manufacturer;
      }
      if (other.AndroidApiLevel != 0) {
        AndroidApiLevel = other.AndroidApiLevel;
      }
      if (other.TraceId.Length != 0) {
        TraceId = other.TraceId;
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
            LanguageCode = input.ReadString();
            break;
          }
          case 18: {
            RegionCode = input.ReadString();
            break;
          }
          case 26: {
            SdkVersion = input.ReadString();
            break;
          }
          case 34: {
            OsVersion = input.ReadString();
            break;
          }
          case 42: {
            DeviceModel = input.ReadString();
            break;
          }
          case 48: {
            SdkType = (global::Google.Maps.FleetEngine.V1.RequestHeader.Types.SdkType) input.ReadEnum();
            break;
          }
          case 58: {
            MapsSdkVersion = input.ReadString();
            break;
          }
          case 66: {
            NavSdkVersion = input.ReadString();
            break;
          }
          case 72: {
            Platform = (global::Google.Maps.FleetEngine.V1.RequestHeader.Types.Platform) input.ReadEnum();
            break;
          }
          case 82: {
            Manufacturer = input.ReadString();
            break;
          }
          case 88: {
            AndroidApiLevel = input.ReadInt32();
            break;
          }
          case 98: {
            TraceId = input.ReadString();
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
            LanguageCode = input.ReadString();
            break;
          }
          case 18: {
            RegionCode = input.ReadString();
            break;
          }
          case 26: {
            SdkVersion = input.ReadString();
            break;
          }
          case 34: {
            OsVersion = input.ReadString();
            break;
          }
          case 42: {
            DeviceModel = input.ReadString();
            break;
          }
          case 48: {
            SdkType = (global::Google.Maps.FleetEngine.V1.RequestHeader.Types.SdkType) input.ReadEnum();
            break;
          }
          case 58: {
            MapsSdkVersion = input.ReadString();
            break;
          }
          case 66: {
            NavSdkVersion = input.ReadString();
            break;
          }
          case 72: {
            Platform = (global::Google.Maps.FleetEngine.V1.RequestHeader.Types.Platform) input.ReadEnum();
            break;
          }
          case 82: {
            Manufacturer = input.ReadString();
            break;
          }
          case 88: {
            AndroidApiLevel = input.ReadInt32();
            break;
          }
          case 98: {
            TraceId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the RequestHeader message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible types of SDK.
      /// </summary>
      public enum SdkType {
        /// <summary>
        /// The default value. This value is used if the `sdk_type` is omitted.
        /// </summary>
        [pbr::OriginalName("SDK_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The calling SDK is Consumer.
        /// </summary>
        [pbr::OriginalName("CONSUMER")] Consumer = 1,
        /// <summary>
        /// The calling SDK is Driver.
        /// </summary>
        [pbr::OriginalName("DRIVER")] Driver = 2,
        /// <summary>
        /// The calling SDK is JavaScript.
        /// </summary>
        [pbr::OriginalName("JAVASCRIPT")] Javascript = 3,
      }

      /// <summary>
      /// The platform of the calling SDK.
      /// </summary>
      public enum Platform {
        /// <summary>
        /// The default value. This value is used if the platform is omitted.
        /// </summary>
        [pbr::OriginalName("PLATFORM_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The request is coming from Android.
        /// </summary>
        [pbr::OriginalName("ANDROID")] Android = 1,
        /// <summary>
        /// The request is coming from iOS.
        /// </summary>
        [pbr::OriginalName("IOS")] Ios = 2,
        /// <summary>
        /// The request is coming from the web.
        /// </summary>
        [pbr::OriginalName("WEB")] Web = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
