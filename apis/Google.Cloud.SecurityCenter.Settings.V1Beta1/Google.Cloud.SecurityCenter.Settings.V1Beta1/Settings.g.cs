// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/settings/v1beta1/settings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
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
            "bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLhCwoIU2V0dGluZ3MS",
            "DAoEbmFtZRgBIAEoCRJXChBiaWxsaW5nX3NldHRpbmdzGAIgASgLMj0uZ29v",
            "Z2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnNldHRpbmdzLnYxYmV0YTEuQmls",
            "bGluZ1NldHRpbmdzElUKBXN0YXRlGAMgASgOMkYuZ29vZ2xlLmNsb3VkLnNl",
            "Y3VyaXR5Y2VudGVyLnNldHRpbmdzLnYxYmV0YTEuU2V0dGluZ3MuT25ib2Fy",
            "ZGluZ1N0YXRlEiAKE29yZ19zZXJ2aWNlX2FjY291bnQYBSABKAlCA+BBAxJR",
            "Cg1zaW5rX3NldHRpbmdzGAYgASgLMjouZ29vZ2xlLmNsb3VkLnNlY3VyaXR5",
            "Y2VudGVyLnNldHRpbmdzLnYxYmV0YTEuU2lua1NldHRpbmdzEmkKEmNvbXBv",
            "bmVudF9zZXR0aW5ncxgHIAMoCzJNLmdvb2dsZS5jbG91ZC5zZWN1cml0eWNl",
            "bnRlci5zZXR0aW5ncy52MWJldGExLlNldHRpbmdzLkNvbXBvbmVudFNldHRp",
            "bmdzRW50cnkScgoXZGV0ZWN0b3JfZ3JvdXBfc2V0dGluZ3MYCCADKAsyUS5n",
            "b29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIuc2V0dGluZ3MudjFiZXRhMS5T",
            "ZXR0aW5ncy5EZXRlY3Rvckdyb3VwU2V0dGluZ3NFbnRyeRIMCgRldGFnGAkg",
            "ASgJEjQKC3VwZGF0ZV90aW1lGAogASgLMhouZ29vZ2xlLnByb3RvYnVmLlRp",
            "bWVzdGFtcEID4EEDGm4KFURldGVjdG9yR3JvdXBTZXR0aW5ncxJVCgVzdGF0",
            "ZRgBIAEoDjJGLmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci5zZXR0aW5n",
            "cy52MWJldGExLkNvbXBvbmVudEVuYWJsZW1lbnRTdGF0ZRp5ChZDb21wb25l",
            "bnRTZXR0aW5nc0VudHJ5EgsKA2tleRgBIAEoCRJOCgV2YWx1ZRgCIAEoCzI/",
            "Lmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci5zZXR0aW5ncy52MWJldGEx",
            "LkNvbXBvbmVudFNldHRpbmdzOgI4ARqKAQoaRGV0ZWN0b3JHcm91cFNldHRp",
            "bmdzRW50cnkSCwoDa2V5GAEgASgJElsKBXZhbHVlGAIgASgLMkwuZ29vZ2xl",
            "LmNsb3VkLnNlY3VyaXR5Y2VudGVyLnNldHRpbmdzLnYxYmV0YTEuU2V0dGlu",
            "Z3MuRGV0ZWN0b3JHcm91cFNldHRpbmdzOgI4ASK1AQoPT25ib2FyZGluZ1N0",
            "YXRlEiAKHE9OQk9BUkRJTkdfU1RBVEVfVU5TUEVDSUZJRUQQABILCgdFTkFC",
            "TEVEEAESDAoIRElTQUJMRUQQAhIUChBCSUxMSU5HX1NFTEVDVEVEEAMSFgoS",
            "UFJPVklERVJTX1NFTEVDVEVEEAQSFgoSUkVTT1VSQ0VTX1NFTEVDVEVEEAUS",
            "HwobT1JHX1NFUlZJQ0VfQUNDT1VOVF9DUkVBVEVEEAY6zgLqQcoCCiZzZWN1",
            "cml0eWNlbnRlci5nb29nbGVhcGlzLmNvbS9TZXR0aW5ncxIlb3JnYW5pemF0",
            "aW9ucy97b3JnYW5pemF0aW9ufS9zZXR0aW5ncxIZZm9sZGVycy97Zm9sZGVy",
            "fS9zZXR0aW5ncxIbcHJvamVjdHMve3Byb2plY3R9L3NldHRpbmdzEkNwcm9q",
            "ZWN0cy97cHJvamVjdH0vbG9jYXRpb25zL3tsb2NhdGlvbn0vY2x1c3RlcnMv",
            "e2NsdXN0ZXJ9L3NldHRpbmdzEj9wcm9qZWN0cy97cHJvamVjdH0vcmVnaW9u",
            "cy97cmVnaW9ufS9jbHVzdGVycy97Y2x1c3Rlcn0vc2V0dGluZ3MSO3Byb2pl",
            "Y3RzL3twcm9qZWN0fS96b25lcy97em9uZX0vY2x1c3RlcnMve2NsdXN0ZXJ9",
            "L3NldHRpbmdzQq0CCjBjb20uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVy",
            "LnNldHRpbmdzLnYxYmV0YTFCDVNldHRpbmdzUHJvdG9QAVpUZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9zZWN1cml0eWNl",
            "bnRlci9zZXR0aW5ncy92MWJldGExO3NldHRpbmdz+AEBqgIsR29vZ2xlLkNs",
            "b3VkLlNlY3VyaXR5Q2VudGVyLlNldHRpbmdzLlYxQmV0YTHKAixHb29nbGVc",
            "Q2xvdWRcU2VjdXJpdHlDZW50ZXJcU2V0dGluZ3NcVjFiZXRhMeoCMEdvb2ds",
            "ZTo6Q2xvdWQ6OlNlY3VyaXR5Q2VudGVyOjpTZXR0aW5nczo6VjFiZXRhMWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingSettingsReflection.Descriptor, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.ComponentSettingsReflection.Descriptor, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.SinkSettingsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
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
      componentSettings_.Add(other.componentSettings_);
      detectorGroupSettings_.Add(other.detectorGroupSettings_);
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
