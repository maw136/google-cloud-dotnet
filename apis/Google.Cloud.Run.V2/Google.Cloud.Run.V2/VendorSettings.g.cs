// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/run/v2/vendor_settings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Run.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/run/v2/vendor_settings.proto</summary>
  public static partial class VendorSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/run/v2/vendor_settings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VendorSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvY2xvdWQvcnVuL3YyL3ZlbmRvcl9zZXR0aW5ncy5wcm90bxIT",
            "Z29vZ2xlLmNsb3VkLnJ1bi52MhoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90",
            "byLUAQoJVnBjQWNjZXNzEjoKCWNvbm5lY3RvchgBIAEoCUIn+kEkCiJ2cGNh",
            "Y2Nlc3MuZ29vZ2xlYXBpcy5jb20vQ29ubmVjdG9yEjgKBmVncmVzcxgCIAEo",
            "DjIoLmdvb2dsZS5jbG91ZC5ydW4udjIuVnBjQWNjZXNzLlZwY0VncmVzcyJR",
            "CglWcGNFZ3Jlc3MSGgoWVlBDX0VHUkVTU19VTlNQRUNJRklFRBAAEg8KC0FM",
            "TF9UUkFGRklDEAESFwoTUFJJVkFURV9SQU5HRVNfT05MWRACImEKE0JpbmFy",
            "eUF1dGhvcml6YXRpb24SFQoLdXNlX2RlZmF1bHQYASABKAhIABIgChhicmVh",
            "a2dsYXNzX2p1c3RpZmljYXRpb24YAiABKAlCEQoPYmluYXV0aHpfbWV0aG9k",
            "IkkKD1JldmlzaW9uU2NhbGluZxIaChJtaW5faW5zdGFuY2VfY291bnQYASAB",
            "KAUSGgoSbWF4X2luc3RhbmNlX2NvdW50GAIgASgFKpkBCg5JbmdyZXNzVHJh",
            "ZmZpYxIfChtJTkdSRVNTX1RSQUZGSUNfVU5TUEVDSUZJRUQQABIXChNJTkdS",
            "RVNTX1RSQUZGSUNfQUxMEAESIQodSU5HUkVTU19UUkFGRklDX0lOVEVSTkFM",
            "X09OTFkQAhIqCiZJTkdSRVNTX1RSQUZGSUNfSU5URVJOQUxfTE9BRF9CQUxB",
            "TkNFUhADKoABChRFeGVjdXRpb25FbnZpcm9ubWVudBIlCiFFWEVDVVRJT05f",
            "RU5WSVJPTk1FTlRfVU5TUEVDSUZJRUQQABIhCh1FWEVDVVRJT05fRU5WSVJP",
            "Tk1FTlRfREVGQVVMVBABEh4KGkVYRUNVVElPTl9FTlZJUk9OTUVOVF9HRU4y",
            "EAJCaAoXY29tLmdvb2dsZS5jbG91ZC5ydW4udjJCE1ZlbmRvclNldHRpbmdz",
            "UHJvdG9QAVo2Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9jbG91ZC9ydW4vdjI7cnVuYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.Run.V2.IngressTraffic), typeof(global::Google.Cloud.Run.V2.ExecutionEnvironment), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Run.V2.VpcAccess), global::Google.Cloud.Run.V2.VpcAccess.Parser, new[]{ "Connector", "Egress" }, null, new[]{ typeof(global::Google.Cloud.Run.V2.VpcAccess.Types.VpcEgress) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Run.V2.BinaryAuthorization), global::Google.Cloud.Run.V2.BinaryAuthorization.Parser, new[]{ "UseDefault", "BreakglassJustification" }, new[]{ "BinauthzMethod" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Run.V2.RevisionScaling), global::Google.Cloud.Run.V2.RevisionScaling.Parser, new[]{ "MinInstanceCount", "MaxInstanceCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Allowed ingress traffic for the Container.
  /// </summary>
  public enum IngressTraffic {
    /// <summary>
    /// Unspecified
    /// </summary>
    [pbr::OriginalName("INGRESS_TRAFFIC_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// All inbound traffic is allowed.
    /// </summary>
    [pbr::OriginalName("INGRESS_TRAFFIC_ALL")] All = 1,
    /// <summary>
    /// Only internal traffic is allowed.
    /// </summary>
    [pbr::OriginalName("INGRESS_TRAFFIC_INTERNAL_ONLY")] InternalOnly = 2,
    /// <summary>
    /// Both internal and Google Cloud Load Balancer traffic is allowed.
    /// </summary>
    [pbr::OriginalName("INGRESS_TRAFFIC_INTERNAL_LOAD_BALANCER")] InternalLoadBalancer = 3,
  }

  /// <summary>
  /// Alternatives for execution environments.
  /// </summary>
  public enum ExecutionEnvironment {
    /// <summary>
    /// Unspecified
    /// </summary>
    [pbr::OriginalName("EXECUTION_ENVIRONMENT_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Uses the Google-default environment.
    /// </summary>
    [pbr::OriginalName("EXECUTION_ENVIRONMENT_DEFAULT")] Default = 1,
    /// <summary>
    /// Uses Second Generation environment.
    /// </summary>
    [pbr::OriginalName("EXECUTION_ENVIRONMENT_GEN2")] Gen2 = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  /// VPC Access settings. For more information on creating a VPC Connector, visit
  /// https://cloud.google.com/vpc/docs/configure-serverless-vpc-access For
  /// information on how to configure Cloud Run with an existing VPC Connector,
  /// visit https://cloud.google.com/run/docs/configuring/connecting-vpc
  /// </summary>
  public sealed partial class VpcAccess : pb::IMessage<VpcAccess>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VpcAccess> _parser = new pb::MessageParser<VpcAccess>(() => new VpcAccess());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VpcAccess> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Run.V2.VendorSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VpcAccess() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VpcAccess(VpcAccess other) : this() {
      connector_ = other.connector_;
      egress_ = other.egress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VpcAccess Clone() {
      return new VpcAccess(this);
    }

    /// <summary>Field number for the "connector" field.</summary>
    public const int ConnectorFieldNumber = 1;
    private string connector_ = "";
    /// <summary>
    /// VPC Access connector name.
    /// Format: projects/{project}/locations/{location}/connectors/{connector}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Connector {
      get { return connector_; }
      set {
        connector_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "egress" field.</summary>
    public const int EgressFieldNumber = 2;
    private global::Google.Cloud.Run.V2.VpcAccess.Types.VpcEgress egress_ = global::Google.Cloud.Run.V2.VpcAccess.Types.VpcEgress.Unspecified;
    /// <summary>
    /// Traffic VPC egress settings.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Run.V2.VpcAccess.Types.VpcEgress Egress {
      get { return egress_; }
      set {
        egress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VpcAccess);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VpcAccess other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Connector != other.Connector) return false;
      if (Egress != other.Egress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Connector.Length != 0) hash ^= Connector.GetHashCode();
      if (Egress != global::Google.Cloud.Run.V2.VpcAccess.Types.VpcEgress.Unspecified) hash ^= Egress.GetHashCode();
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
      if (Connector.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Connector);
      }
      if (Egress != global::Google.Cloud.Run.V2.VpcAccess.Types.VpcEgress.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Egress);
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
      if (Connector.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Connector);
      }
      if (Egress != global::Google.Cloud.Run.V2.VpcAccess.Types.VpcEgress.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Egress);
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
      if (Connector.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Connector);
      }
      if (Egress != global::Google.Cloud.Run.V2.VpcAccess.Types.VpcEgress.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Egress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VpcAccess other) {
      if (other == null) {
        return;
      }
      if (other.Connector.Length != 0) {
        Connector = other.Connector;
      }
      if (other.Egress != global::Google.Cloud.Run.V2.VpcAccess.Types.VpcEgress.Unspecified) {
        Egress = other.Egress;
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
            Connector = input.ReadString();
            break;
          }
          case 16: {
            Egress = (global::Google.Cloud.Run.V2.VpcAccess.Types.VpcEgress) input.ReadEnum();
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
            Connector = input.ReadString();
            break;
          }
          case 16: {
            Egress = (global::Google.Cloud.Run.V2.VpcAccess.Types.VpcEgress) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the VpcAccess message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Egress options for VPC access.
      /// </summary>
      public enum VpcEgress {
        /// <summary>
        /// Unspecified
        /// </summary>
        [pbr::OriginalName("VPC_EGRESS_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// All outbound traffic is routed through the VPC connector.
        /// </summary>
        [pbr::OriginalName("ALL_TRAFFIC")] AllTraffic = 1,
        /// <summary>
        /// Only private IP ranges are routed through the VPC connector.
        /// </summary>
        [pbr::OriginalName("PRIVATE_RANGES_ONLY")] PrivateRangesOnly = 2,
      }

    }
    #endregion

  }

  /// <summary>
  /// Settings for Binary Authorization feature.
  /// </summary>
  public sealed partial class BinaryAuthorization : pb::IMessage<BinaryAuthorization>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BinaryAuthorization> _parser = new pb::MessageParser<BinaryAuthorization>(() => new BinaryAuthorization());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BinaryAuthorization> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Run.V2.VendorSettingsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BinaryAuthorization() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BinaryAuthorization(BinaryAuthorization other) : this() {
      breakglassJustification_ = other.breakglassJustification_;
      switch (other.BinauthzMethodCase) {
        case BinauthzMethodOneofCase.UseDefault:
          UseDefault = other.UseDefault;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BinaryAuthorization Clone() {
      return new BinaryAuthorization(this);
    }

    /// <summary>Field number for the "use_default" field.</summary>
    public const int UseDefaultFieldNumber = 1;
    /// <summary>
    /// If True, indicates to use the default project's binary authorization
    /// policy. If False, binary authorization will be disabled.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UseDefault {
      get { return binauthzMethodCase_ == BinauthzMethodOneofCase.UseDefault ? (bool) binauthzMethod_ : false; }
      set {
        binauthzMethod_ = value;
        binauthzMethodCase_ = BinauthzMethodOneofCase.UseDefault;
      }
    }

    /// <summary>Field number for the "breakglass_justification" field.</summary>
    public const int BreakglassJustificationFieldNumber = 2;
    private string breakglassJustification_ = "";
    /// <summary>
    /// If present, indicates to use Breakglass using this justification.
    /// If use_default is False, then it must be empty.
    /// For more information on breakglass, see
    /// https://cloud.google.com/binary-authorization/docs/using-breakglass
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BreakglassJustification {
      get { return breakglassJustification_; }
      set {
        breakglassJustification_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private object binauthzMethod_;
    /// <summary>Enum of possible cases for the "binauthz_method" oneof.</summary>
    public enum BinauthzMethodOneofCase {
      None = 0,
      UseDefault = 1,
    }
    private BinauthzMethodOneofCase binauthzMethodCase_ = BinauthzMethodOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BinauthzMethodOneofCase BinauthzMethodCase {
      get { return binauthzMethodCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBinauthzMethod() {
      binauthzMethodCase_ = BinauthzMethodOneofCase.None;
      binauthzMethod_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BinaryAuthorization);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BinaryAuthorization other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UseDefault != other.UseDefault) return false;
      if (BreakglassJustification != other.BreakglassJustification) return false;
      if (BinauthzMethodCase != other.BinauthzMethodCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (binauthzMethodCase_ == BinauthzMethodOneofCase.UseDefault) hash ^= UseDefault.GetHashCode();
      if (BreakglassJustification.Length != 0) hash ^= BreakglassJustification.GetHashCode();
      hash ^= (int) binauthzMethodCase_;
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
      if (binauthzMethodCase_ == BinauthzMethodOneofCase.UseDefault) {
        output.WriteRawTag(8);
        output.WriteBool(UseDefault);
      }
      if (BreakglassJustification.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BreakglassJustification);
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
      if (binauthzMethodCase_ == BinauthzMethodOneofCase.UseDefault) {
        output.WriteRawTag(8);
        output.WriteBool(UseDefault);
      }
      if (BreakglassJustification.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BreakglassJustification);
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
      if (binauthzMethodCase_ == BinauthzMethodOneofCase.UseDefault) {
        size += 1 + 1;
      }
      if (BreakglassJustification.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BreakglassJustification);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BinaryAuthorization other) {
      if (other == null) {
        return;
      }
      if (other.BreakglassJustification.Length != 0) {
        BreakglassJustification = other.BreakglassJustification;
      }
      switch (other.BinauthzMethodCase) {
        case BinauthzMethodOneofCase.UseDefault:
          UseDefault = other.UseDefault;
          break;
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
            UseDefault = input.ReadBool();
            break;
          }
          case 18: {
            BreakglassJustification = input.ReadString();
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
            UseDefault = input.ReadBool();
            break;
          }
          case 18: {
            BreakglassJustification = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Settings for revision-level scaling settings.
  /// </summary>
  public sealed partial class RevisionScaling : pb::IMessage<RevisionScaling>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RevisionScaling> _parser = new pb::MessageParser<RevisionScaling>(() => new RevisionScaling());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RevisionScaling> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Run.V2.VendorSettingsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RevisionScaling() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RevisionScaling(RevisionScaling other) : this() {
      minInstanceCount_ = other.minInstanceCount_;
      maxInstanceCount_ = other.maxInstanceCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RevisionScaling Clone() {
      return new RevisionScaling(this);
    }

    /// <summary>Field number for the "min_instance_count" field.</summary>
    public const int MinInstanceCountFieldNumber = 1;
    private int minInstanceCount_;
    /// <summary>
    /// Minimum number of serving instances that this resource should have.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MinInstanceCount {
      get { return minInstanceCount_; }
      set {
        minInstanceCount_ = value;
      }
    }

    /// <summary>Field number for the "max_instance_count" field.</summary>
    public const int MaxInstanceCountFieldNumber = 2;
    private int maxInstanceCount_;
    /// <summary>
    /// Maximum number of serving instances that this resource should have.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxInstanceCount {
      get { return maxInstanceCount_; }
      set {
        maxInstanceCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RevisionScaling);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RevisionScaling other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MinInstanceCount != other.MinInstanceCount) return false;
      if (MaxInstanceCount != other.MaxInstanceCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MinInstanceCount != 0) hash ^= MinInstanceCount.GetHashCode();
      if (MaxInstanceCount != 0) hash ^= MaxInstanceCount.GetHashCode();
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
      if (MinInstanceCount != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(MinInstanceCount);
      }
      if (MaxInstanceCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxInstanceCount);
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
      if (MinInstanceCount != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(MinInstanceCount);
      }
      if (MaxInstanceCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxInstanceCount);
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
      if (MinInstanceCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MinInstanceCount);
      }
      if (MaxInstanceCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxInstanceCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RevisionScaling other) {
      if (other == null) {
        return;
      }
      if (other.MinInstanceCount != 0) {
        MinInstanceCount = other.MinInstanceCount;
      }
      if (other.MaxInstanceCount != 0) {
        MaxInstanceCount = other.MaxInstanceCount;
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
            MinInstanceCount = input.ReadInt32();
            break;
          }
          case 16: {
            MaxInstanceCount = input.ReadInt32();
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
            MinInstanceCount = input.ReadInt32();
            break;
          }
          case 16: {
            MaxInstanceCount = input.ReadInt32();
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
