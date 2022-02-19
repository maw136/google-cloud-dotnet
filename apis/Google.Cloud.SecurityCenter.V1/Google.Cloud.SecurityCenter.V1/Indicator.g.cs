// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/indicator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/indicator.proto</summary>
  public static partial class IndicatorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/indicator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IndicatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEvaW5kaWNhdG9yLnBy",
            "b3RvEh5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIudjEiMgoJSW5kaWNh",
            "dG9yEhQKDGlwX2FkZHJlc3NlcxgBIAMoCRIPCgdkb21haW5zGAIgAygJQuoB",
            "CiJjb20uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYxQg5JbmRpY2F0",
            "b3JQcm90b1ABWkxnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Nsb3VkL3NlY3VyaXR5Y2VudGVyL3YxO3NlY3VyaXR5Y2VudGVyqgIe",
            "R29vZ2xlLkNsb3VkLlNlY3VyaXR5Q2VudGVyLlYxygIeR29vZ2xlXENsb3Vk",
            "XFNlY3VyaXR5Q2VudGVyXFYx6gIhR29vZ2xlOjpDbG91ZDo6U2VjdXJpdHlD",
            "ZW50ZXI6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.Indicator), global::Google.Cloud.SecurityCenter.V1.Indicator.Parser, new[]{ "IpAddresses", "Domains" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents what's commonly known as an Indicator of compromise (IoC) in
  /// computer forensics. This is an artifact observed on a network or in an
  /// operating system that, with high confidence, indicates a computer intrusion.
  /// Reference: https://en.wikipedia.org/wiki/Indicator_of_compromise
  /// </summary>
  public sealed partial class Indicator : pb::IMessage<Indicator>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Indicator> _parser = new pb::MessageParser<Indicator>(() => new Indicator());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Indicator> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.IndicatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Indicator() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Indicator(Indicator other) : this() {
      ipAddresses_ = other.ipAddresses_.Clone();
      domains_ = other.domains_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Indicator Clone() {
      return new Indicator(this);
    }

    /// <summary>Field number for the "ip_addresses" field.</summary>
    public const int IpAddressesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_ipAddresses_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> ipAddresses_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// List of ip addresses associated to the Finding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> IpAddresses {
      get { return ipAddresses_; }
    }

    /// <summary>Field number for the "domains" field.</summary>
    public const int DomainsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_domains_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> domains_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// List of domains associated to the Finding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Domains {
      get { return domains_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Indicator);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Indicator other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!ipAddresses_.Equals(other.ipAddresses_)) return false;
      if(!domains_.Equals(other.domains_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= ipAddresses_.GetHashCode();
      hash ^= domains_.GetHashCode();
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
      ipAddresses_.WriteTo(output, _repeated_ipAddresses_codec);
      domains_.WriteTo(output, _repeated_domains_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      ipAddresses_.WriteTo(ref output, _repeated_ipAddresses_codec);
      domains_.WriteTo(ref output, _repeated_domains_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += ipAddresses_.CalculateSize(_repeated_ipAddresses_codec);
      size += domains_.CalculateSize(_repeated_domains_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Indicator other) {
      if (other == null) {
        return;
      }
      ipAddresses_.Add(other.ipAddresses_);
      domains_.Add(other.domains_);
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
            ipAddresses_.AddEntriesFrom(input, _repeated_ipAddresses_codec);
            break;
          }
          case 18: {
            domains_.AddEntriesFrom(input, _repeated_domains_codec);
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
            ipAddresses_.AddEntriesFrom(ref input, _repeated_ipAddresses_codec);
            break;
          }
          case 18: {
            domains_.AddEntriesFrom(ref input, _repeated_domains_codec);
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
