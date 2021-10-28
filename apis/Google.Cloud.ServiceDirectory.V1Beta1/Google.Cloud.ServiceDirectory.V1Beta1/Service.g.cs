// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/servicedirectory/v1beta1/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ServiceDirectory.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/servicedirectory/v1beta1/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/servicedirectory/v1beta1/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvc2VydmljZWRpcmVjdG9yeS92MWJldGExL3NlcnZp",
            "Y2UucHJvdG8SJWdvb2dsZS5jbG91ZC5zZXJ2aWNlZGlyZWN0b3J5LnYxYmV0",
            "YTEaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9h",
            "cGkvcmVzb3VyY2UucHJvdG8aNGdvb2dsZS9jbG91ZC9zZXJ2aWNlZGlyZWN0",
            "b3J5L3YxYmV0YTEvZW5kcG9pbnQucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i",
            "2AMKB1NlcnZpY2USEQoEbmFtZRgBIAEoCUID4EEFElMKCG1ldGFkYXRhGAIg",
            "AygLMjwuZ29vZ2xlLmNsb3VkLnNlcnZpY2VkaXJlY3RvcnkudjFiZXRhMS5T",
            "ZXJ2aWNlLk1ldGFkYXRhRW50cnlCA+BBARJHCgllbmRwb2ludHMYAyADKAsy",
            "Ly5nb29nbGUuY2xvdWQuc2VydmljZWRpcmVjdG9yeS52MWJldGExLkVuZHBv",
            "aW50QgPgQQMSNAoLY3JlYXRlX3RpbWUYBiABKAsyGi5nb29nbGUucHJvdG9i",
            "dWYuVGltZXN0YW1wQgPgQQMSNAoLdXBkYXRlX3RpbWUYByABKAsyGi5nb29n",
            "bGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMaLwoNTWV0YWRhdGFFbnRyeRIL",
            "CgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgBOn/qQXwKJ3NlcnZpY2Vk",
            "aXJlY3RvcnkuZ29vZ2xlYXBpcy5jb20vU2VydmljZRJRcHJvamVjdHMve3By",
            "b2plY3R9L2xvY2F0aW9ucy97bG9jYXRpb259L25hbWVzcGFjZXMve25hbWVz",
            "cGFjZX0vc2VydmljZXMve3NlcnZpY2V9QpACCiljb20uZ29vZ2xlLmNsb3Vk",
            "LnNlcnZpY2VkaXJlY3RvcnkudjFiZXRhMUIMU2VydmljZVByb3RvUAFaVWdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvc2Vy",
            "dmljZWRpcmVjdG9yeS92MWJldGExO3NlcnZpY2VkaXJlY3Rvcnn4AQGqAiVH",
            "b29nbGUuQ2xvdWQuU2VydmljZURpcmVjdG9yeS5WMUJldGExygIlR29vZ2xl",
            "XENsb3VkXFNlcnZpY2VEaXJlY3RvcnlcVjFiZXRhMeoCKEdvb2dsZTo6Q2xv",
            "dWQ6OlNlcnZpY2VEaXJlY3Rvcnk6OlYxYmV0YTFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.ServiceDirectory.V1Beta1.EndpointReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ServiceDirectory.V1Beta1.Service), global::Google.Cloud.ServiceDirectory.V1Beta1.Service.Parser, new[]{ "Name", "Metadata", "Endpoints", "CreateTime", "UpdateTime" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An individual service. A service contains a name and optional metadata.
  /// A service must exist before
  /// [endpoints][google.cloud.servicedirectory.v1beta1.Endpoint] can be
  /// added to it.
  /// </summary>
  public sealed partial class Service : pb::IMessage<Service>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Service> _parser = new pb::MessageParser<Service>(() => new Service());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Service> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ServiceDirectory.V1Beta1.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Service() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Service(Service other) : this() {
      name_ = other.name_;
      metadata_ = other.metadata_.Clone();
      endpoints_ = other.endpoints_.Clone();
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Service Clone() {
      return new Service(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Immutable. The resource name for the service in the format
    /// `projects/*/locations/*/namespaces/*/services/*`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_metadata_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 18);
    private readonly pbc::MapField<string, string> metadata_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. Metadata for the service. This data can be consumed by service
    /// clients.
    ///
    /// Restrictions:
    ///
    /// *   The entire metadata dictionary may contain up to 2000 characters,
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

    /// <summary>Field number for the "endpoints" field.</summary>
    public const int EndpointsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint> _repeated_endpoints_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint> endpoints_ = new pbc::RepeatedField<global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint>();
    /// <summary>
    /// Output only. Endpoints associated with this service. Returned on
    /// [LookupService.ResolveService][google.cloud.servicedirectory.v1beta1.LookupService.ResolveService]. Control plane clients should use
    /// [RegistrationService.ListEndpoints][google.cloud.servicedirectory.v1beta1.RegistrationService.ListEndpoints].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.ServiceDirectory.V1Beta1.Endpoint> Endpoints {
      get { return endpoints_; }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The timestamp when the service was created.
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
    /// Output only. The timestamp when the service was last updated. Note: endpoints being
    /// created/deleted/updated within the service are not considered service
    /// updates for the purpose of this timestamp.
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
      return Equals(other as Service);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Service other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!Metadata.Equals(other.Metadata)) return false;
      if(!endpoints_.Equals(other.endpoints_)) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= Metadata.GetHashCode();
      hash ^= endpoints_.GetHashCode();
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
      metadata_.WriteTo(output, _map_metadata_codec);
      endpoints_.WriteTo(output, _repeated_endpoints_codec);
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
      metadata_.WriteTo(ref output, _map_metadata_codec);
      endpoints_.WriteTo(ref output, _repeated_endpoints_codec);
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
      size += metadata_.CalculateSize(_map_metadata_codec);
      size += endpoints_.CalculateSize(_repeated_endpoints_codec);
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
    public void MergeFrom(Service other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      metadata_.Add(other.metadata_);
      endpoints_.Add(other.endpoints_);
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
            metadata_.AddEntriesFrom(input, _map_metadata_codec);
            break;
          }
          case 26: {
            endpoints_.AddEntriesFrom(input, _repeated_endpoints_codec);
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
            metadata_.AddEntriesFrom(ref input, _map_metadata_codec);
            break;
          }
          case 26: {
            endpoints_.AddEntriesFrom(ref input, _repeated_endpoints_codec);
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
