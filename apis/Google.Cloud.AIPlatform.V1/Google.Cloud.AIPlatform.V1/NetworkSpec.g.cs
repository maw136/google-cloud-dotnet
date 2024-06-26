// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/network_spec.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/network_spec.proto</summary>
  public static partial class NetworkSpecReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/network_spec.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NetworkSpecReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9uZXR3b3JrX3NwZWMucHJv",
            "dG8SGmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxGhlnb29nbGUvYXBpL3Jl",
            "c291cmNlLnByb3RvIp8BCgtOZXR3b3JrU3BlYxIeChZlbmFibGVfaW50ZXJu",
            "ZXRfYWNjZXNzGAEgASgIEjQKB25ldHdvcmsYAiABKAlCI/pBIAoeY29tcHV0",
            "ZS5nb29nbGVhcGlzLmNvbS9OZXR3b3JrEjoKCnN1Ym5ldHdvcmsYAyABKAlC",
            "JvpBIwohY29tcHV0ZS5nb29nbGVhcGlzLmNvbS9TdWJuZXR3b3JrQrICCh5j",
            "b20uZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjFCEE5ldHdvcmtTcGVjUHJv",
            "dG9QAVo+Y2xvdWQuZ29vZ2xlLmNvbS9nby9haXBsYXRmb3JtL2FwaXYxL2Fp",
            "cGxhdGZvcm1wYjthaXBsYXRmb3JtcGKqAhpHb29nbGUuQ2xvdWQuQUlQbGF0",
            "Zm9ybS5WMcoCGkdvb2dsZVxDbG91ZFxBSVBsYXRmb3JtXFYx6gIdR29vZ2xl",
            "OjpDbG91ZDo6QUlQbGF0Zm9ybTo6VjHqQWEKIWNvbXB1dGUuZ29vZ2xlYXBp",
            "cy5jb20vU3VibmV0d29yaxI8cHJvamVjdHMve3Byb2plY3R9L3JlZ2lvbnMv",
            "e3JlZ2lvbn0vc3VibmV0d29ya3Mve3N1Ym5ldHdvcmt9YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.NetworkSpec), global::Google.Cloud.AIPlatform.V1.NetworkSpec.Parser, new[]{ "EnableInternetAccess", "Network", "Subnetwork" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Network spec.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NetworkSpec : pb::IMessage<NetworkSpec>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NetworkSpec> _parser = new pb::MessageParser<NetworkSpec>(() => new NetworkSpec());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NetworkSpec> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.NetworkSpecReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NetworkSpec() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NetworkSpec(NetworkSpec other) : this() {
      enableInternetAccess_ = other.enableInternetAccess_;
      network_ = other.network_;
      subnetwork_ = other.subnetwork_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NetworkSpec Clone() {
      return new NetworkSpec(this);
    }

    /// <summary>Field number for the "enable_internet_access" field.</summary>
    public const int EnableInternetAccessFieldNumber = 1;
    private bool enableInternetAccess_;
    /// <summary>
    /// Whether to enable public internet access. Default false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EnableInternetAccess {
      get { return enableInternetAccess_; }
      set {
        enableInternetAccess_ = value;
      }
    }

    /// <summary>Field number for the "network" field.</summary>
    public const int NetworkFieldNumber = 2;
    private string network_ = "";
    /// <summary>
    /// The full name of the Google Compute Engine
    /// [network](https://cloud.google.com//compute/docs/networks-and-firewalls#networks)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Network {
      get { return network_; }
      set {
        network_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "subnetwork" field.</summary>
    public const int SubnetworkFieldNumber = 3;
    private string subnetwork_ = "";
    /// <summary>
    /// The name of the subnet that this instance is in.
    /// Format:
    /// `projects/{project_id_or_number}/regions/{region}/subnetworks/{subnetwork_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Subnetwork {
      get { return subnetwork_; }
      set {
        subnetwork_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NetworkSpec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NetworkSpec other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnableInternetAccess != other.EnableInternetAccess) return false;
      if (Network != other.Network) return false;
      if (Subnetwork != other.Subnetwork) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EnableInternetAccess != false) hash ^= EnableInternetAccess.GetHashCode();
      if (Network.Length != 0) hash ^= Network.GetHashCode();
      if (Subnetwork.Length != 0) hash ^= Subnetwork.GetHashCode();
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
      if (EnableInternetAccess != false) {
        output.WriteRawTag(8);
        output.WriteBool(EnableInternetAccess);
      }
      if (Network.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Network);
      }
      if (Subnetwork.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Subnetwork);
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
      if (EnableInternetAccess != false) {
        output.WriteRawTag(8);
        output.WriteBool(EnableInternetAccess);
      }
      if (Network.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Network);
      }
      if (Subnetwork.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Subnetwork);
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
      if (EnableInternetAccess != false) {
        size += 1 + 1;
      }
      if (Network.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Network);
      }
      if (Subnetwork.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Subnetwork);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NetworkSpec other) {
      if (other == null) {
        return;
      }
      if (other.EnableInternetAccess != false) {
        EnableInternetAccess = other.EnableInternetAccess;
      }
      if (other.Network.Length != 0) {
        Network = other.Network;
      }
      if (other.Subnetwork.Length != 0) {
        Subnetwork = other.Subnetwork;
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
            EnableInternetAccess = input.ReadBool();
            break;
          }
          case 18: {
            Network = input.ReadString();
            break;
          }
          case 26: {
            Subnetwork = input.ReadString();
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
            EnableInternetAccess = input.ReadBool();
            break;
          }
          case 18: {
            Network = input.ReadString();
            break;
          }
          case 26: {
            Subnetwork = input.ReadString();
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
