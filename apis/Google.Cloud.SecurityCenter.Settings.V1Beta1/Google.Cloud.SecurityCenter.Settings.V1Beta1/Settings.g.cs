// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/settings/v1beta1/settings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.Settings.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/settings/v1beta1/settings.proto</summary>
  public static partial class SettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/settings/v1beta1/settings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvc2V0dGluZ3MvdjFiZXRh",
            "MS9zZXR0aW5ncy5wcm90bxIsZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVy",
            "LnNldHRpbmdzLnYxYmV0YTEaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3Iu",
            "cHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aQ2dvb2dsZS9jbG91",
            "ZC9zZWN1cml0eWNlbnRlci9zZXR0aW5ncy92MWJldGExL2JpbGxpbmdfc2V0",
            "dGluZ3MucHJvdG8aRWdvb2dsZS9jbG91ZC9zZWN1cml0eWNlbnRlci9zZXR0",
            "aW5ncy92MWJldGExL2NvbXBvbmVudF9zZXR0aW5ncy5wcm90bxpAZ29vZ2xl",
            "L2Nsb3VkL3NlY3VyaXR5Y2VudGVyL3NldHRpbmdzL3YxYmV0YTEvc2lua19z",
            "ZXR0aW5ncy5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90",
            "byLjCwoIU2V0dGluZ3MSDAoEbmFtZRgBIAEoCRJXChBiaWxsaW5nX3NldHRp",
            "bmdzGAIgASgLMj0uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnNldHRp",
            "bmdzLnYxYmV0YTEuQmlsbGluZ1NldHRpbmdzElUKBXN0YXRlGAMgASgOMkYu",
            "Z29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnNldHRpbmdzLnYxYmV0YTEu",
            "U2V0dGluZ3MuT25ib2FyZGluZ1N0YXRlEiEKE29yZ19zZXJ2aWNlX2FjY291",
            "bnQYBSABKAlCBOJBAQMSUQoNc2lua19zZXR0aW5ncxgGIAEoCzI6Lmdvb2ds",
            "ZS5jbG91ZC5zZWN1cml0eWNlbnRlci5zZXR0aW5ncy52MWJldGExLlNpbmtT",
            "ZXR0aW5ncxJpChJjb21wb25lbnRfc2V0dGluZ3MYByADKAsyTS5nb29nbGUu",
            "Y2xvdWQuc2VjdXJpdHljZW50ZXIuc2V0dGluZ3MudjFiZXRhMS5TZXR0aW5n",
            "cy5Db21wb25lbnRTZXR0aW5nc0VudHJ5EnIKF2RldGVjdG9yX2dyb3VwX3Nl",
            "dHRpbmdzGAggAygLMlEuZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnNl",
            "dHRpbmdzLnYxYmV0YTEuU2V0dGluZ3MuRGV0ZWN0b3JHcm91cFNldHRpbmdz",
            "RW50cnkSDAoEZXRhZxgJIAEoCRI1Cgt1cGRhdGVfdGltZRgKIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCBOJBAQMabgoVRGV0ZWN0b3JHcm91",
            "cFNldHRpbmdzElUKBXN0YXRlGAEgASgOMkYuZ29vZ2xlLmNsb3VkLnNlY3Vy",
            "aXR5Y2VudGVyLnNldHRpbmdzLnYxYmV0YTEuQ29tcG9uZW50RW5hYmxlbWVu",
            "dFN0YXRlGnkKFkNvbXBvbmVudFNldHRpbmdzRW50cnkSCwoDa2V5GAEgASgJ",
            "Ek4KBXZhbHVlGAIgASgLMj8uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVy",
            "LnNldHRpbmdzLnYxYmV0YTEuQ29tcG9uZW50U2V0dGluZ3M6AjgBGooBChpE",
            "ZXRlY3Rvckdyb3VwU2V0dGluZ3NFbnRyeRILCgNrZXkYASABKAkSWwoFdmFs",
            "dWUYAiABKAsyTC5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIuc2V0dGlu",
            "Z3MudjFiZXRhMS5TZXR0aW5ncy5EZXRlY3Rvckdyb3VwU2V0dGluZ3M6AjgB",
            "IrUBCg9PbmJvYXJkaW5nU3RhdGUSIAocT05CT0FSRElOR19TVEFURV9VTlNQ",
            "RUNJRklFRBAAEgsKB0VOQUJMRUQQARIMCghESVNBQkxFRBACEhQKEEJJTExJ",
            "TkdfU0VMRUNURUQQAxIWChJQUk9WSURFUlNfU0VMRUNURUQQBBIWChJSRVNP",
            "VVJDRVNfU0VMRUNURUQQBRIfChtPUkdfU0VSVklDRV9BQ0NPVU5UX0NSRUFU",
            "RUQQBjrOAupBygIKJnNlY3VyaXR5Y2VudGVyLmdvb2dsZWFwaXMuY29tL1Nl",
            "dHRpbmdzEiVvcmdhbml6YXRpb25zL3tvcmdhbml6YXRpb259L3NldHRpbmdz",
            "Ehlmb2xkZXJzL3tmb2xkZXJ9L3NldHRpbmdzEhtwcm9qZWN0cy97cHJvamVj",
            "dH0vc2V0dGluZ3MSQ3Byb2plY3RzL3twcm9qZWN0fS9sb2NhdGlvbnMve2xv",
            "Y2F0aW9ufS9jbHVzdGVycy97Y2x1c3Rlcn0vc2V0dGluZ3MSP3Byb2plY3Rz",
            "L3twcm9qZWN0fS9yZWdpb25zL3tyZWdpb259L2NsdXN0ZXJzL3tjbHVzdGVy",
            "fS9zZXR0aW5ncxI7cHJvamVjdHMve3Byb2plY3R9L3pvbmVzL3t6b25lfS9j",
            "bHVzdGVycy97Y2x1c3Rlcn0vc2V0dGluZ3NCpQIKMGNvbS5nb29nbGUuY2xv",
            "dWQuc2VjdXJpdHljZW50ZXIuc2V0dGluZ3MudjFiZXRhMUINU2V0dGluZ3NQ",
            "cm90b1ABWkxjbG91ZC5nb29nbGUuY29tL2dvL3NlY3VyaXR5Y2VudGVyL3Nl",
            "dHRpbmdzL2FwaXYxYmV0YTEvc2V0dGluZ3NwYjtzZXR0aW5nc3Bi+AEBqgIs",
            "R29vZ2xlLkNsb3VkLlNlY3VyaXR5Q2VudGVyLlNldHRpbmdzLlYxQmV0YTHK",
            "AixHb29nbGVcQ2xvdWRcU2VjdXJpdHlDZW50ZXJcU2V0dGluZ3NcVjFiZXRh",
            "MeoCMEdvb2dsZTo6Q2xvdWQ6OlNlY3VyaXR5Q2VudGVyOjpTZXR0aW5nczo6",
            "VjFiZXRhMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingSettingsReflection.Descriptor, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentSettingsReflection.Descriptor, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.SinkSettingsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings), global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Parser, new[]{ "Name", "BillingSettings", "State", "OrgServiceAccount", "SinkSettings", "ComponentSettings", "DetectorGroupSettings", "Etag", "UpdateTime" }, null, new[]{ typeof(global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.OnboardingState) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.DetectorGroupSettings), global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.DetectorGroupSettings.Parser, new[]{ "State" }, null, null, null, null),
            null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Common configuration settings for all of Security Center.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Settings : pb::IMessage<Settings>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Settings> _parser = new pb::MessageParser<Settings>(() => new Settings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Settings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.Settings.V1Beta1.SettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Settings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Settings(Settings other) : this() {
      name_ = other.name_;
      billingSettings_ = other.billingSettings_ != null ? other.billingSettings_.Clone() : null;
      state_ = other.state_;
      orgServiceAccount_ = other.orgServiceAccount_;
      sinkSettings_ = other.sinkSettings_ != null ? other.sinkSettings_.Clone() : null;
      componentSettings_ = other.componentSettings_.Clone();
      detectorGroupSettings_ = other.detectorGroupSettings_.Clone();
      etag_ = other.etag_;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Settings Clone() {
      return new Settings(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The relative resource name of the settings resource.
    /// Formats:
    ///  * `organizations/{organization}/settings`
    ///  * `folders/{folder}/settings`
    ///  * `projects/{project}/settings`
    ///  * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
    ///  * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
    ///  * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "billing_settings" field.</summary>
    public const int BillingSettingsFieldNumber = 2;
    private global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingSettings billingSettings_;
    /// <summary>
    /// Billing settings
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingSettings BillingSettings {
      get { return billingSettings_; }
      set {
        billingSettings_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 3;
    private global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.OnboardingState state_ = global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.OnboardingState.Unspecified;
    /// <summary>
    /// An enum representing the current on boarding state of SCC.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.OnboardingState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "org_service_account" field.</summary>
    public const int OrgServiceAccountFieldNumber = 5;
    private string orgServiceAccount_ = "";
    /// <summary>
    /// Output only. The organization-level service account to be used for security center
    /// components. The component must have permission to "act as" the service
    /// account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OrgServiceAccount {
      get { return orgServiceAccount_; }
      set {
        orgServiceAccount_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sink_settings" field.</summary>
    public const int SinkSettingsFieldNumber = 6;
    private global::Google.Cloud.SecurityCenter.Settings.V1Beta1.SinkSettings sinkSettings_;
    /// <summary>
    /// Sink settings.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.Settings.V1Beta1.SinkSettings SinkSettings {
      get { return sinkSettings_; }
      set {
        sinkSettings_ = value;
      }
    }

    /// <summary>Field number for the "component_settings" field.</summary>
    public const int ComponentSettingsFieldNumber = 7;
    private static readonly pbc::MapField<string, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentSettings>.Codec _map_componentSettings_codec
        = new pbc::MapField<string, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentSettings>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentSettings.Parser), 58);
    private readonly pbc::MapField<string, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentSettings> componentSettings_ = new pbc::MapField<string, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentSettings>();
    /// <summary>
    /// The settings for detectors and/or scanners.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentSettings> ComponentSettings {
      get { return componentSettings_; }
    }

    /// <summary>Field number for the "detector_group_settings" field.</summary>
    public const int DetectorGroupSettingsFieldNumber = 8;
    private static readonly pbc::MapField<string, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.DetectorGroupSettings>.Codec _map_detectorGroupSettings_codec
        = new pbc::MapField<string, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.DetectorGroupSettings>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.DetectorGroupSettings.Parser), 66);
    private readonly pbc::MapField<string, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.DetectorGroupSettings> detectorGroupSettings_ = new pbc::MapField<string, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.DetectorGroupSettings>();
    /// <summary>
    /// Detector group settings for all Security Center components.
    /// The key is the name of the detector group and the value is the settings for
    /// that group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.DetectorGroupSettings> DetectorGroupSettings {
      get { return detectorGroupSettings_; }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 9;
    private string etag_ = "";
    /// <summary>
    /// A fingerprint used for optimistic concurrency. If none is provided
    /// on updates then the existing metadata will be blindly overwritten.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 10;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. The time these settings were last updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Settings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Settings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(BillingSettings, other.BillingSettings)) return false;
      if (State != other.State) return false;
      if (OrgServiceAccount != other.OrgServiceAccount) return false;
      if (!object.Equals(SinkSettings, other.SinkSettings)) return false;
      if (!ComponentSettings.Equals(other.ComponentSettings)) return false;
      if (!DetectorGroupSettings.Equals(other.DetectorGroupSettings)) return false;
      if (Etag != other.Etag) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (billingSettings_ != null) hash ^= BillingSettings.GetHashCode();
      if (State != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.OnboardingState.Unspecified) hash ^= State.GetHashCode();
      if (OrgServiceAccount.Length != 0) hash ^= OrgServiceAccount.GetHashCode();
      if (sinkSettings_ != null) hash ^= SinkSettings.GetHashCode();
      hash ^= ComponentSettings.GetHashCode();
      hash ^= DetectorGroupSettings.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
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
      if (billingSettings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BillingSettings);
      }
      if (State != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.OnboardingState.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) State);
      }
      if (OrgServiceAccount.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OrgServiceAccount);
      }
      if (sinkSettings_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SinkSettings);
      }
      componentSettings_.WriteTo(output, _map_componentSettings_codec);
      detectorGroupSettings_.WriteTo(output, _map_detectorGroupSettings_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Etag);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(UpdateTime);
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
      if (billingSettings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BillingSettings);
      }
      if (State != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.OnboardingState.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) State);
      }
      if (OrgServiceAccount.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OrgServiceAccount);
      }
      if (sinkSettings_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SinkSettings);
      }
      componentSettings_.WriteTo(ref output, _map_componentSettings_codec);
      detectorGroupSettings_.WriteTo(ref output, _map_detectorGroupSettings_codec);
      if (Etag.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Etag);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(UpdateTime);
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
      if (billingSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BillingSettings);
      }
      if (State != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.OnboardingState.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (OrgServiceAccount.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OrgServiceAccount);
      }
      if (sinkSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SinkSettings);
      }
      size += componentSettings_.CalculateSize(_map_componentSettings_codec);
      size += detectorGroupSettings_.CalculateSize(_map_detectorGroupSettings_codec);
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Settings other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.billingSettings_ != null) {
        if (billingSettings_ == null) {
          BillingSettings = new global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingSettings();
        }
        BillingSettings.MergeFrom(other.BillingSettings);
      }
      if (other.State != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.OnboardingState.Unspecified) {
        State = other.State;
      }
      if (other.OrgServiceAccount.Length != 0) {
        OrgServiceAccount = other.OrgServiceAccount;
      }
      if (other.sinkSettings_ != null) {
        if (sinkSettings_ == null) {
          SinkSettings = new global::Google.Cloud.SecurityCenter.Settings.V1Beta1.SinkSettings();
        }
        SinkSettings.MergeFrom(other.SinkSettings);
      }
      componentSettings_.MergeFrom(other.componentSettings_);
      detectorGroupSettings_.MergeFrom(other.detectorGroupSettings_);
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
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
            if (billingSettings_ == null) {
              BillingSettings = new global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingSettings();
            }
            input.ReadMessage(BillingSettings);
            break;
          }
          case 24: {
            State = (global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.OnboardingState) input.ReadEnum();
            break;
          }
          case 42: {
            OrgServiceAccount = input.ReadString();
            break;
          }
          case 50: {
            if (sinkSettings_ == null) {
              SinkSettings = new global::Google.Cloud.SecurityCenter.Settings.V1Beta1.SinkSettings();
            }
            input.ReadMessage(SinkSettings);
            break;
          }
          case 58: {
            componentSettings_.AddEntriesFrom(input, _map_componentSettings_codec);
            break;
          }
          case 66: {
            detectorGroupSettings_.AddEntriesFrom(input, _map_detectorGroupSettings_codec);
            break;
          }
          case 74: {
            Etag = input.ReadString();
            break;
          }
          case 82: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
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
            if (billingSettings_ == null) {
              BillingSettings = new global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingSettings();
            }
            input.ReadMessage(BillingSettings);
            break;
          }
          case 24: {
            State = (global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Types.OnboardingState) input.ReadEnum();
            break;
          }
          case 42: {
            OrgServiceAccount = input.ReadString();
            break;
          }
          case 50: {
            if (sinkSettings_ == null) {
              SinkSettings = new global::Google.Cloud.SecurityCenter.Settings.V1Beta1.SinkSettings();
            }
            input.ReadMessage(SinkSettings);
            break;
          }
          case 58: {
            componentSettings_.AddEntriesFrom(ref input, _map_componentSettings_codec);
            break;
          }
          case 66: {
            detectorGroupSettings_.AddEntriesFrom(ref input, _map_detectorGroupSettings_codec);
            break;
          }
          case 74: {
            Etag = input.ReadString();
            break;
          }
          case 82: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Settings message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Defines the onboarding states for SCC
      ///
      /// Potentially is just an indicator that a user has reviewed some subset of
      /// our configuration surface, even if it's still currently set to its
      /// API-default state.
      /// </summary>
      public enum OnboardingState {
        /// <summary>
        /// No onboarding state has been set. Should not be seen in practice, but
        /// should be functionally equivalent to DISABLED.
        /// </summary>
        [pbr::OriginalName("ONBOARDING_STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// SCC is fully on boarded
        /// </summary>
        [pbr::OriginalName("ENABLED")] Enabled = 1,
        /// <summary>
        /// SCC has been disabled after being on boarded
        /// </summary>
        [pbr::OriginalName("DISABLED")] Disabled = 2,
        /// <summary>
        /// SCC's onboarding tier has been explicitly set
        /// </summary>
        [pbr::OriginalName("BILLING_SELECTED")] BillingSelected = 3,
        /// <summary>
        /// SCC's CTD FindingsProviders have been chosen
        /// </summary>
        [pbr::OriginalName("PROVIDERS_SELECTED")] ProvidersSelected = 4,
        /// <summary>
        /// SCC's Service-Resource mappings have been set
        /// </summary>
        [pbr::OriginalName("RESOURCES_SELECTED")] ResourcesSelected = 5,
        /// <summary>
        /// SCC's core Service Account was created
        /// </summary>
        [pbr::OriginalName("ORG_SERVICE_ACCOUNT_CREATED")] OrgServiceAccountCreated = 6,
      }

      /// <summary>
      /// The DetectorGroupSettings define the configuration for a detector group.
      /// </summary>
      [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
      public sealed partial class DetectorGroupSettings : pb::IMessage<DetectorGroupSettings>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<DetectorGroupSettings> _parser = new pb::MessageParser<DetectorGroupSettings>(() => new DetectorGroupSettings());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<DetectorGroupSettings> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Settings.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DetectorGroupSettings() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DetectorGroupSettings(DetectorGroupSettings other) : this() {
          state_ = other.state_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DetectorGroupSettings Clone() {
          return new DetectorGroupSettings(this);
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 1;
        private global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentEnablementState state_ = global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentEnablementState.Unspecified;
        /// <summary>
        /// The state determines if the group is enabled or not.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentEnablementState State {
          get { return state_; }
          set {
            state_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as DetectorGroupSettings);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(DetectorGroupSettings other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (State != other.State) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (State != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentEnablementState.Unspecified) hash ^= State.GetHashCode();
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
          if (State != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentEnablementState.Unspecified) {
            output.WriteRawTag(8);
            output.WriteEnum((int) State);
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
          if (State != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentEnablementState.Unspecified) {
            output.WriteRawTag(8);
            output.WriteEnum((int) State);
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
          if (State != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentEnablementState.Unspecified) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(DetectorGroupSettings other) {
          if (other == null) {
            return;
          }
          if (other.State != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentEnablementState.Unspecified) {
            State = other.State;
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
              case 8: {
                State = (global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentEnablementState) input.ReadEnum();
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
              case 8: {
                State = (global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentEnablementState) input.ReadEnum();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
