// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/settings/v1beta1/billing_settings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.Settings.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/settings/v1beta1/billing_settings.proto</summary>
  public static partial class BillingSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/settings/v1beta1/billing_settings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BillingSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvc2V0dGluZ3MvdjFiZXRh",
            "MS9iaWxsaW5nX3NldHRpbmdzLnByb3RvEixnb29nbGUuY2xvdWQuc2VjdXJp",
            "dHljZW50ZXIuc2V0dGluZ3MudjFiZXRhMRofZ29vZ2xlL2FwaS9maWVsZF9i",
            "ZWhhdmlvci5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90",
            "byKoAgoPQmlsbGluZ1NldHRpbmdzElQKDGJpbGxpbmdfdGllchgBIAEoDjI5",
            "Lmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci5zZXR0aW5ncy52MWJldGEx",
            "LkJpbGxpbmdUaWVyQgPgQQMSVAoMYmlsbGluZ190eXBlGAIgASgOMjkuZ29v",
            "Z2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnNldHRpbmdzLnYxYmV0YTEuQmls",
            "bGluZ1R5cGVCA+BBAxIzCgpzdGFydF90aW1lGAMgASgLMhouZ29vZ2xlLnBy",
            "b3RvYnVmLlRpbWVzdGFtcEID4EEDEjQKC2V4cGlyZV90aW1lGAQgASgLMhou",
            "Z29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEID4EEDKkYKC0JpbGxpbmdUaWVy",
            "EhwKGEJJTExJTkdfVElFUl9VTlNQRUNJRklFRBAAEgwKCFNUQU5EQVJEEAES",
            "CwoHUFJFTUlVTRACKmAKC0JpbGxpbmdUeXBlEhwKGEJJTExJTkdfVFlQRV9V",
            "TlNQRUNJRklFRBAAEhAKDFNVQlNDUklQVElPThABEhYKElRSSUFMX1NVQlND",
            "UklQVElPThACEgkKBUFMUEhBEANCtAIKMGNvbS5nb29nbGUuY2xvdWQuc2Vj",
            "dXJpdHljZW50ZXIuc2V0dGluZ3MudjFiZXRhMUIUQmlsbGluZ1NldHRpbmdz",
            "UHJvdG9QAVpUZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9jbG91ZC9zZWN1cml0eWNlbnRlci9zZXR0aW5ncy92MWJldGExO3NldHRp",
            "bmdz+AEBqgIsR29vZ2xlLkNsb3VkLlNlY3VyaXR5Q2VudGVyLlNldHRpbmdz",
            "LlYxQmV0YTHKAixHb29nbGVcQ2xvdWRcU2VjdXJpdHlDZW50ZXJcU2V0dGlu",
            "Z3NcVjFiZXRhMeoCMEdvb2dsZTo6Q2xvdWQ6OlNlY3VyaXR5Q2VudGVyOjpT",
            "ZXR0aW5nczo6VjFiZXRhMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier), typeof(global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingSettings), global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingSettings.Parser, new[]{ "BillingTier", "BillingType", "StartTime", "ExpireTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Billing tier options
  /// </summary>
  public enum BillingTier {
    /// <summary>
    /// Default value. This value is unused.
    /// </summary>
    [pbr::OriginalName("BILLING_TIER_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The standard billing tier.
    /// </summary>
    [pbr::OriginalName("STANDARD")] Standard = 1,
    /// <summary>
    /// The premium billing tier.
    /// </summary>
    [pbr::OriginalName("PREMIUM")] Premium = 2,
  }

  /// <summary>
  /// Billing type
  /// </summary>
  public enum BillingType {
    /// <summary>
    /// Default billing type
    /// </summary>
    [pbr::OriginalName("BILLING_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Subscription for Premium billing tier
    /// </summary>
    [pbr::OriginalName("SUBSCRIPTION")] Subscription = 1,
    /// <summary>
    /// Trial subscription for Premium billing tier
    /// </summary>
    [pbr::OriginalName("TRIAL_SUBSCRIPTION")] TrialSubscription = 2,
    /// <summary>
    /// Alpha customer for Premium billing tier
    /// </summary>
    [pbr::OriginalName("ALPHA")] Alpha = 3,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Billing settings
  /// </summary>
  public sealed partial class BillingSettings : pb::IMessage<BillingSettings>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BillingSettings> _parser = new pb::MessageParser<BillingSettings>(() => new BillingSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BillingSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BillingSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BillingSettings(BillingSettings other) : this() {
      billingTier_ = other.billingTier_;
      billingType_ = other.billingType_;
      startTime_ = other.startTime_ != null ? other.startTime_.Clone() : null;
      expireTime_ = other.expireTime_ != null ? other.expireTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BillingSettings Clone() {
      return new BillingSettings(this);
    }

    /// <summary>Field number for the "billing_tier" field.</summary>
    public const int BillingTierFieldNumber = 1;
    private global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier billingTier_ = global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified;
    /// <summary>
    /// Output only. Billing tier selected by customer
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier BillingTier {
      get { return billingTier_; }
      set {
        billingTier_ = value;
      }
    }

    /// <summary>Field number for the "billing_type" field.</summary>
    public const int BillingTypeFieldNumber = 2;
    private global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingType billingType_ = global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingType.Unspecified;
    /// <summary>
    /// Output only. Type of billing method
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingType BillingType {
      get { return billingType_; }
      set {
        billingType_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startTime_;
    /// <summary>
    /// Output only. The absolute point in time when the subscription became effective.
    /// Can be compared to expire_time value to determine full contract duration
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "expire_time" field.</summary>
    public const int ExpireTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp expireTime_;
    /// <summary>
    /// Output only. The absolute point in time when the subscription expires.
    ///
    /// If this field is populated and billing_tier is STANDARD, this is
    /// indication of a point in the _past_ when a PREMIUM access ended.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ExpireTime {
      get { return expireTime_; }
      set {
        expireTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BillingSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BillingSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BillingTier != other.BillingTier) return false;
      if (BillingType != other.BillingType) return false;
      if (!object.Equals(StartTime, other.StartTime)) return false;
      if (!object.Equals(ExpireTime, other.ExpireTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BillingTier != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified) hash ^= BillingTier.GetHashCode();
      if (BillingType != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingType.Unspecified) hash ^= BillingType.GetHashCode();
      if (startTime_ != null) hash ^= StartTime.GetHashCode();
      if (expireTime_ != null) hash ^= ExpireTime.GetHashCode();
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
      if (BillingTier != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) BillingTier);
      }
      if (BillingType != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) BillingType);
      }
      if (startTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(StartTime);
      }
      if (expireTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ExpireTime);
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
      if (BillingTier != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) BillingTier);
      }
      if (BillingType != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) BillingType);
      }
      if (startTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(StartTime);
      }
      if (expireTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ExpireTime);
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
      if (BillingTier != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BillingTier);
      }
      if (BillingType != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BillingType);
      }
      if (startTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartTime);
      }
      if (expireTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpireTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BillingSettings other) {
      if (other == null) {
        return;
      }
      if (other.BillingTier != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified) {
        BillingTier = other.BillingTier;
      }
      if (other.BillingType != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingType.Unspecified) {
        BillingType = other.BillingType;
      }
      if (other.startTime_ != null) {
        if (startTime_ == null) {
          StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartTime.MergeFrom(other.StartTime);
      }
      if (other.expireTime_ != null) {
        if (expireTime_ == null) {
          ExpireTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ExpireTime.MergeFrom(other.ExpireTime);
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
            BillingTier = (global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier) input.ReadEnum();
            break;
          }
          case 16: {
            BillingType = (global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingType) input.ReadEnum();
            break;
          }
          case 26: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 34: {
            if (expireTime_ == null) {
              ExpireTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpireTime);
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
            BillingTier = (global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier) input.ReadEnum();
            break;
          }
          case 16: {
            BillingType = (global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingType) input.ReadEnum();
            break;
          }
          case 26: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 34: {
            if (expireTime_ == null) {
              ExpireTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpireTime);
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
