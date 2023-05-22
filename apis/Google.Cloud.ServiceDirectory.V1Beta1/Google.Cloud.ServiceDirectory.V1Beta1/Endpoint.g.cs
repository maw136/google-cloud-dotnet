// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/servicedirectory/v1beta1/endpoint.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ServiceDirectory.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/servicedirectory/v1beta1/endpoint.proto</summary>
  public static partial class EndpointReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/servicedirectory/v1beta1/endpoint.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EndpointReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvY2xvdWQvc2VydmljZWRpcmVjdG9yeS92MWJldGExL2VuZHBv",
            "aW50LnByb3RvEiVnb29nbGUuY2xvdWQuc2VydmljZWRpcmVjdG9yeS52MWJl",
            "dGExGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUv",
            "YXBpL3Jlc291cmNlLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1w",
            "LnByb3RvIpQECghFbmRwb2ludBIRCgRuYW1lGAEgASgJQgPgQQUSFAoHYWRk",
            "cmVzcxgCIAEoCUID4EEBEhEKBHBvcnQYAyABKAVCA+BBARJUCghtZXRhZGF0",
            "YRgEIAMoCzI9Lmdvb2dsZS5jbG91ZC5zZXJ2aWNlZGlyZWN0b3J5LnYxYmV0",
            "YTEuRW5kcG9pbnQuTWV0YWRhdGFFbnRyeUID4EEBEkAKB25ldHdvcmsYBSAB",
            "KAlCL+BBBfpBKQonc2VydmljZWRpcmVjdG9yeS5nb29nbGVhcGlzLmNvbS9O",
            "ZXR3b3JrEjQKC2NyZWF0ZV90aW1lGAYgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcEID4EEDEjQKC3VwZGF0ZV90aW1lGAcgASgLMhouZ29vZ2xl",
            "LnByb3RvYnVmLlRpbWVzdGFtcEID4EEDGi8KDU1ldGFkYXRhRW50cnkSCwoD",
            "a2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ATqWAepBkgEKKHNlcnZpY2Vk",
            "aXJlY3RvcnkuZ29vZ2xlYXBpcy5jb20vRW5kcG9pbnQSZnByb2plY3RzL3tw",
            "cm9qZWN0fS9sb2NhdGlvbnMve2xvY2F0aW9ufS9uYW1lc3BhY2VzL3tuYW1l",
            "c3BhY2V9L3NlcnZpY2VzL3tzZXJ2aWNlfS9lbmRwb2ludHMve2VuZHBvaW50",
            "fUL1AgopY29tLmdvb2dsZS5jbG91ZC5zZXJ2aWNlZGlyZWN0b3J5LnYxYmV0",
            "YTFCDUVuZHBvaW50UHJvdG9QAVpVY2xvdWQuZ29vZ2xlLmNvbS9nby9zZXJ2",
            "aWNlZGlyZWN0b3J5L2FwaXYxYmV0YTEvc2VydmljZWRpcmVjdG9yeXBiO3Nl",
            "cnZpY2VkaXJlY3RvcnlwYvgBAaoCJUdvb2dsZS5DbG91ZC5TZXJ2aWNlRGly",
            "ZWN0b3J5LlYxQmV0YTHKAiVHb29nbGVcQ2xvdWRcU2VydmljZURpcmVjdG9y",
            "eVxWMWJldGEx6gIoR29vZ2xlOjpDbG91ZDo6U2VydmljZURpcmVjdG9yeTo6",
            "VjFiZXRhMepBYQonc2VydmljZWRpcmVjdG9yeS5nb29nbGVhcGlzLmNvbS9O",
            "ZXR3b3JrEjZwcm9qZWN0cy97cHJvamVjdH0vbG9jYXRpb25zL2dsb2JhbC9u",
            "ZXR3b3Jrcy97bmV0d29ya31iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint), global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint.Parser, new[]{ "Name", "Address", "Port", "Metadata", "Network", "CreateTime", "UpdateTime" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An individual endpoint that provides a
  /// [service][google.cloud.servicedirectory.v1beta1.Service]. The service must
  /// already exist to create an endpoint.
  /// </summary>
  public sealed partial class Endpoint : pb::IMessage<Endpoint>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Endpoint> _parser = new pb::MessageParser<Endpoint>(() => new Endpoint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Endpoint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ServiceDirectory.V1Beta1.EndpointReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Endpoint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Endpoint(Endpoint other) : this() {
      name_ = other.name_;
      address_ = other.address_;
      port_ = other.port_;
      metadata_ = other.metadata_.Clone();
      network_ = other.network_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Endpoint Clone() {
      return new Endpoint(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Immutable. The resource name for the endpoint in the format
    /// `projects/*/locations/*/namespaces/*/services/*/endpoints/*`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 2;
    private string address_ = "";
    /// <summary>
    /// Optional. An IPv4 or IPv6 address. Service Directory rejects bad addresses like:
    ///
    /// *   `8.8.8`
    /// *   `8.8.8.8:53`
    /// *   `test:bad:address`
    /// *   `[::1]`
    /// *   `[::1]:8080`
    ///
    /// Limited to 45 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "port" field.</summary>
    public const int PortFieldNumber = 3;
    private int port_;
    /// <summary>
    /// Optional. Service Directory rejects values outside of `[0, 65535]`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Port {
      get { return port_; }
      set {
        port_ = value;
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 4;
    private static readonly pbc::MapField<string, string>.Codec _map_metadata_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 34);
    private readonly pbc::MapField<string, string> metadata_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. Metadata for the endpoint. This data can be consumed by service
    /// clients.
    ///
    /// Restrictions:
    ///
    /// *   The entire metadata dictionary may contain up to 512 characters,
    ///     spread accoss all key-value pairs. Metadata that goes beyond this
    ///     limit are rejected
    /// *   Valid metadata keys have two segments: an optional prefix and name,
    ///     separated by a slash (/). The name segment is required and must be 63
    ///     characters or less, beginning and ending with an alphanumeric character
    ///     ([a-z0-9A-Z]) with dashes (-), underscores (_), dots (.), and
    ///     alphanumerics between. The prefix is optional. If specified, the prefix
    ///     must be a DNS subdomain: a series of DNS labels separated by dots (.),
    ///     not longer than 253 characters in total, followed by a slash (/).
    ///     Metadata that fails to meet these requirements are rejected
    /// *   The `(*.)google.com/` and `(*.)googleapis.com/` prefixes are reserved
    ///     for system metadata managed by Service Directory. If the user tries
    ///     to write to these keyspaces, those entries are silently ignored by
    ///     the system
    ///
    /// Note: This field is equivalent to the `annotations` field in the v1 API.
    /// They have the same syntax and read/write to the same location in Service
    /// Directory.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Metadata {
      get { return metadata_; }
    }

    /// <summary>Field number for the "network" field.</summary>
    public const int NetworkFieldNumber = 5;
    private string network_ = "";
    /// <summary>
    /// Immutable. The Google Compute Engine network (VPC) of the endpoint in the format
    /// `projects/&lt;project number>/locations/global/networks/*`.
    ///
    /// The project must be specified by project number (project id is rejected).
    /// Incorrectly formatted networks are rejected, but no other validation
    /// is performed on this field (ex. network or project existence, reachability,
    /// or permissions).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Network {
      get { return network_; }
      set {
        network_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The timestamp when the endpoint was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. The timestamp when the endpoint was last updated.
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
      return Equals(other as Endpoint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Endpoint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Address != other.Address) return false;
      if (Port != other.Port) return false;
      if (!Metadata.Equals(other.Metadata)) return false;
      if (Network != other.Network) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (Port != 0) hash ^= Port.GetHashCode();
      hash ^= Metadata.GetHashCode();
      if (Network.Length != 0) hash ^= Network.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
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
      if (Address.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Address);
      }
      if (Port != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Port);
      }
      metadata_.WriteTo(output, _map_metadata_codec);
      if (Network.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Network);
      }
      if (createTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(58);
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
      if (Address.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Address);
      }
      if (Port != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Port);
      }
      metadata_.WriteTo(ref output, _map_metadata_codec);
      if (Network.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Network);
      }
      if (createTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(58);
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
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (Port != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Port);
      }
      size += metadata_.CalculateSize(_map_metadata_codec);
      if (Network.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Network);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
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
    public void MergeFrom(Endpoint other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      if (other.Port != 0) {
        Port = other.Port;
      }
      metadata_.MergeFrom(other.metadata_);
      if (other.Network.Length != 0) {
        Network = other.Network;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
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
            Address = input.ReadString();
            break;
          }
          case 24: {
            Port = input.ReadInt32();
            break;
          }
          case 34: {
            metadata_.AddEntriesFrom(input, _map_metadata_codec);
            break;
          }
          case 42: {
            Network = input.ReadString();
            break;
          }
          case 50: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 58: {
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
            Address = input.ReadString();
            break;
          }
          case 24: {
            Port = input.ReadInt32();
            break;
          }
          case 34: {
            metadata_.AddEntriesFrom(ref input, _map_metadata_codec);
            break;
          }
          case 42: {
            Network = input.ReadString();
            break;
          }
          case 50: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 58: {
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

  }

  #endregion

}

#endregion Designer generated code
