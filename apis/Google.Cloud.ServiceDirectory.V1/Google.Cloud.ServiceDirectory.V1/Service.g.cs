// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/servicedirectory/v1/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ServiceDirectory.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/servicedirectory/v1/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/servicedirectory/v1/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvY2xvdWQvc2VydmljZWRpcmVjdG9yeS92MS9zZXJ2aWNlLnBy",
            "b3RvEiBnb29nbGUuY2xvdWQuc2VydmljZWRpcmVjdG9yeS52MRofZ29vZ2xl",
            "L2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJj",
            "ZS5wcm90bxovZ29vZ2xlL2Nsb3VkL3NlcnZpY2VkaXJlY3RvcnkvdjEvZW5k",
            "cG9pbnQucHJvdG8i6wIKB1NlcnZpY2USEQoEbmFtZRgBIAEoCUID4EEFElQK",
            "C2Fubm90YXRpb25zGAQgAygLMjouZ29vZ2xlLmNsb3VkLnNlcnZpY2VkaXJl",
            "Y3RvcnkudjEuU2VydmljZS5Bbm5vdGF0aW9uc0VudHJ5QgPgQQESQgoJZW5k",
            "cG9pbnRzGAMgAygLMiouZ29vZ2xlLmNsb3VkLnNlcnZpY2VkaXJlY3Rvcnku",
            "djEuRW5kcG9pbnRCA+BBAxoyChBBbm5vdGF0aW9uc0VudHJ5EgsKA2tleRgB",
            "IAEoCRINCgV2YWx1ZRgCIAEoCToCOAE6f+pBfAonc2VydmljZWRpcmVjdG9y",
            "eS5nb29nbGVhcGlzLmNvbS9TZXJ2aWNlElFwcm9qZWN0cy97cHJvamVjdH0v",
            "bG9jYXRpb25zL3tsb2NhdGlvbn0vbmFtZXNwYWNlcy97bmFtZXNwYWNlfS9z",
            "ZXJ2aWNlcy97c2VydmljZX1C9wEKJGNvbS5nb29nbGUuY2xvdWQuc2Vydmlj",
            "ZWRpcmVjdG9yeS52MUIMU2VydmljZVByb3RvUAFaUGNsb3VkLmdvb2dsZS5j",
            "b20vZ28vc2VydmljZWRpcmVjdG9yeS9hcGl2MS9zZXJ2aWNlZGlyZWN0b3J5",
            "cGI7c2VydmljZWRpcmVjdG9yeXBi+AEBqgIgR29vZ2xlLkNsb3VkLlNlcnZp",
            "Y2VEaXJlY3RvcnkuVjHKAiBHb29nbGVcQ2xvdWRcU2VydmljZURpcmVjdG9y",
            "eVxWMeoCI0dvb2dsZTo6Q2xvdWQ6OlNlcnZpY2VEaXJlY3Rvcnk6OlYxYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.ServiceDirectory.V1.EndpointReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ServiceDirectory.V1.Service), global::Google.Cloud.ServiceDirectory.V1.Service.Parser, new[]{ "Name", "Annotations", "Endpoints" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An individual service. A service contains a name and optional metadata.
  /// A service must exist before
  /// [endpoints][google.cloud.servicedirectory.v1.Endpoint] can be
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
      get { return global::Google.Cloud.ServiceDirectory.V1.ServiceReflection.Descriptor.MessageTypes[0]; }
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
      annotations_ = other.annotations_.Clone();
      endpoints_ = other.endpoints_.Clone();
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

    /// <summary>Field number for the "annotations" field.</summary>
    public const int AnnotationsFieldNumber = 4;
    private static readonly pbc::MapField<string, string>.Codec _map_annotations_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 34);
    private readonly pbc::MapField<string, string> annotations_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. Annotations for the service. This data can be consumed by service
    /// clients.
    /// Restrictions:
    ///  - The entire annotations dictionary may contain up to 2000 characters,
    ///    spread accoss all key-value pairs. Annotations that goes beyond any
    ///    these limits will be rejected.
    ///  - Valid annotation keys have two segments: an optional prefix and name,
    ///    separated by a slash (/). The name segment is required and must be 63
    ///    characters or less, beginning and ending with an alphanumeric character
    ///    ([a-z0-9A-Z]) with dashes (-), underscores (_), dots (.), and
    ///    alphanumerics between. The prefix is optional. If specified, the prefix
    ///    must be a DNS subdomain: a series of DNS labels separated by dots (.),
    ///    not longer than 253 characters in total, followed by a slash (/).
    ///    Annotations that fails to meet these requirements will be rejected.
    ///  - The '(*.)google.com/' and '(*.)googleapis.com/' prefixes are reserved
    ///    for system annotations managed by Service Directory. If the user tries
    ///    to write to these keyspaces, those entries will be silently ignored by
    ///    the system.
    /// Note: This field is equivalent to the 'metadata' field in the v1beta1 API.
    /// They have the same syntax and read/write to the same location in Service
    /// Directory.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Annotations {
      get { return annotations_; }
    }

    /// <summary>Field number for the "endpoints" field.</summary>
    public const int EndpointsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Cloud.ServiceDirectory.V1.Endpoint> _repeated_endpoints_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Cloud.ServiceDirectory.V1.Endpoint.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.ServiceDirectory.V1.Endpoint> endpoints_ = new pbc::RepeatedField<global::Google.Cloud.ServiceDirectory.V1.Endpoint>();
    /// <summary>
    /// Output only. Endpoints associated with this service. Returned on
    /// LookupService.Resolve. Control plane clients should use
    /// RegistrationService.ListEndpoints.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.ServiceDirectory.V1.Endpoint> Endpoints {
      get { return endpoints_; }
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
      if (!Annotations.Equals(other.Annotations)) return false;
      if(!endpoints_.Equals(other.endpoints_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= Annotations.GetHashCode();
      hash ^= endpoints_.GetHashCode();
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
      endpoints_.WriteTo(output, _repeated_endpoints_codec);
      annotations_.WriteTo(output, _map_annotations_codec);
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
      endpoints_.WriteTo(ref output, _repeated_endpoints_codec);
      annotations_.WriteTo(ref output, _map_annotations_codec);
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
      size += annotations_.CalculateSize(_map_annotations_codec);
      size += endpoints_.CalculateSize(_repeated_endpoints_codec);
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
      annotations_.MergeFrom(other.annotations_);
      endpoints_.Add(other.endpoints_);
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
          case 26: {
            endpoints_.AddEntriesFrom(input, _repeated_endpoints_codec);
            break;
          }
          case 34: {
            annotations_.AddEntriesFrom(input, _map_annotations_codec);
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
          case 26: {
            endpoints_.AddEntriesFrom(ref input, _repeated_endpoints_codec);
            break;
          }
          case 34: {
            annotations_.AddEntriesFrom(ref input, _map_annotations_codec);
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
