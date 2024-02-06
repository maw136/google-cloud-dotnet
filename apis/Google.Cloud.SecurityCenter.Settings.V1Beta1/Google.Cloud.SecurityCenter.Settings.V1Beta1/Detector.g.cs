// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/settings/v1beta1/detector.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.Settings.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/settings/v1beta1/detector.proto</summary>
  public static partial class DetectorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/settings/v1beta1/detector.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DetectorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvc2V0dGluZ3MvdjFiZXRh",
            "MS9kZXRlY3Rvci5wcm90bxIsZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVy",
            "LnNldHRpbmdzLnYxYmV0YTEaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3Iu",
            "cHJvdG8aQ2dvb2dsZS9jbG91ZC9zZWN1cml0eWNlbnRlci9zZXR0aW5ncy92",
            "MWJldGExL2JpbGxpbmdfc2V0dGluZ3MucHJvdG8irQEKCERldGVjdG9yEhUK",
            "CGRldGVjdG9yGAEgASgJQgPgQQMSFgoJY29tcG9uZW50GAIgASgJQgPgQQMS",
            "VAoMYmlsbGluZ190aWVyGAMgASgOMjkuZ29vZ2xlLmNsb3VkLnNlY3VyaXR5",
            "Y2VudGVyLnNldHRpbmdzLnYxYmV0YTEuQmlsbGluZ1RpZXJCA+BBAxIcCg9k",
            "ZXRlY3Rvcl9sYWJlbHMYBCADKAlCA+BBA0KmAgowY29tLmdvb2dsZS5jbG91",
            "ZC5zZWN1cml0eWNlbnRlci5zZXR0aW5ncy52MWJldGExQg5EZXRlY3RvcnNQ",
            "cm90b1ABWkxjbG91ZC5nb29nbGUuY29tL2dvL3NlY3VyaXR5Y2VudGVyL3Nl",
            "dHRpbmdzL2FwaXYxYmV0YTEvc2V0dGluZ3NwYjtzZXR0aW5nc3Bi+AEBqgIs",
            "R29vZ2xlLkNsb3VkLlNlY3VyaXR5Q2VudGVyLlNldHRpbmdzLlYxQmV0YTHK",
            "AixHb29nbGVcQ2xvdWRcU2VjdXJpdHlDZW50ZXJcU2V0dGluZ3NcVjFiZXRh",
            "MeoCMEdvb2dsZTo6Q2xvdWQ6OlNlY3VyaXR5Q2VudGVyOjpTZXR0aW5nczo6",
            "VjFiZXRhMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingSettingsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Detector), global::Google.Cloud.SecurityCenter.Settings.V1Beta1.Detector.Parser, new[]{ "Detector_", "Component", "BillingTier", "DetectorLabels" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Detector is a set of detectors or scanners act as individual checks done
  /// within a component e.g. bad IP, bad domains, IAM anomaly, cryptomining, open
  /// firewall, etc. Detector is independent of Organization, meaning each detector
  /// must be defined for a given Security Center component under a specified
  /// billing tier. Organizations can configure the list of detectors based on
  /// their subscribed billing tier.
  ///
  /// Defines a detector, its billing tier and any applicable labels.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Detector : pb::IMessage<Detector>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Detector> _parser = new pb::MessageParser<Detector>(() => new Detector());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Detector> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.Settings.V1Beta1.DetectorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Detector() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Detector(Detector other) : this() {
      detector_ = other.detector_;
      component_ = other.component_;
      billingTier_ = other.billingTier_;
      detectorLabels_ = other.detectorLabels_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Detector Clone() {
      return new Detector(this);
    }

    /// <summary>Field number for the "detector" field.</summary>
    public const int Detector_FieldNumber = 1;
    private string detector_ = "";
    /// <summary>
    /// Output only. Detector Identifier
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Detector_ {
      get { return detector_; }
      set {
        detector_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "component" field.</summary>
    public const int ComponentFieldNumber = 2;
    private string component_ = "";
    /// <summary>
    /// Output only. Component that supports detector type.  Multiple components may support the
    /// same detector.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Component {
      get { return component_; }
      set {
        component_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "billing_tier" field.</summary>
    public const int BillingTierFieldNumber = 3;
    private global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier billingTier_ = global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified;
    /// <summary>
    /// Output only. The billing tier may be different for a detector of the same name in
    /// another component.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier BillingTier {
      get { return billingTier_; }
      set {
        billingTier_ = value;
      }
    }

    /// <summary>Field number for the "detector_labels" field.</summary>
    public const int DetectorLabelsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_detectorLabels_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> detectorLabels_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. Google curated detector labels. These are alphanumeric tags that are not
    /// necessarily human readable. Labels can be used to group detectors together
    /// in the future. An example might be tagging all detectors “PCI” that help
    /// with PCI compliance.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> DetectorLabels {
      get { return detectorLabels_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Detector);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Detector other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Detector_ != other.Detector_) return false;
      if (Component != other.Component) return false;
      if (BillingTier != other.BillingTier) return false;
      if(!detectorLabels_.Equals(other.detectorLabels_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Detector_.Length != 0) hash ^= Detector_.GetHashCode();
      if (Component.Length != 0) hash ^= Component.GetHashCode();
      if (BillingTier != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified) hash ^= BillingTier.GetHashCode();
      hash ^= detectorLabels_.GetHashCode();
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
      if (Detector_.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Detector_);
      }
      if (Component.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Component);
      }
      if (BillingTier != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) BillingTier);
      }
      detectorLabels_.WriteTo(output, _repeated_detectorLabels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Detector_.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Detector_);
      }
      if (Component.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Component);
      }
      if (BillingTier != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) BillingTier);
      }
      detectorLabels_.WriteTo(ref output, _repeated_detectorLabels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Detector_.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Detector_);
      }
      if (Component.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Component);
      }
      if (BillingTier != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BillingTier);
      }
      size += detectorLabels_.CalculateSize(_repeated_detectorLabels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Detector other) {
      if (other == null) {
        return;
      }
      if (other.Detector_.Length != 0) {
        Detector_ = other.Detector_;
      }
      if (other.Component.Length != 0) {
        Component = other.Component;
      }
      if (other.BillingTier != global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier.Unspecified) {
        BillingTier = other.BillingTier;
      }
      detectorLabels_.Add(other.detectorLabels_);
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
            Detector_ = input.ReadString();
            break;
          }
          case 18: {
            Component = input.ReadString();
            break;
          }
          case 24: {
            BillingTier = (global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier) input.ReadEnum();
            break;
          }
          case 34: {
            detectorLabels_.AddEntriesFrom(input, _repeated_detectorLabels_codec);
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
            Detector_ = input.ReadString();
            break;
          }
          case 18: {
            Component = input.ReadString();
            break;
          }
          case 24: {
            BillingTier = (global::Google.Cloud.SecurityCenter.Settings.V1Beta1.BillingTier) input.ReadEnum();
            break;
          }
          case 34: {
            detectorLabels_.AddEntriesFrom(ref input, _repeated_detectorLabels_codec);
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
