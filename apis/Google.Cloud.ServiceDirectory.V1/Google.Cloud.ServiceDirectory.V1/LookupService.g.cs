// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/servicedirectory/v1/lookup_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ServiceDirectory.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/servicedirectory/v1/lookup_service.proto</summary>
  public static partial class LookupServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/servicedirectory/v1/lookup_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LookupServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvY2xvdWQvc2VydmljZWRpcmVjdG9yeS92MS9sb29rdXBfc2Vy",
            "dmljZS5wcm90bxIgZ29vZ2xlLmNsb3VkLnNlcnZpY2VkaXJlY3RvcnkudjEa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aF2dvb2dsZS9hcGkvY2xp",
            "ZW50LnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhln",
            "b29nbGUvYXBpL3Jlc291cmNlLnByb3RvGi5nb29nbGUvY2xvdWQvc2Vydmlj",
            "ZWRpcmVjdG9yeS92MS9zZXJ2aWNlLnByb3RvIpABChVSZXNvbHZlU2Vydmlj",
            "ZVJlcXVlc3QSPQoEbmFtZRgBIAEoCUIv4EEC+kEpCidzZXJ2aWNlZGlyZWN0",
            "b3J5Lmdvb2dsZWFwaXMuY29tL1NlcnZpY2USGgoNbWF4X2VuZHBvaW50cxgC",
            "IAEoBUID4EEBEhwKD2VuZHBvaW50X2ZpbHRlchgDIAEoCUID4EEBIlQKFlJl",
            "c29sdmVTZXJ2aWNlUmVzcG9uc2USOgoHc2VydmljZRgBIAEoCzIpLmdvb2ds",
            "ZS5jbG91ZC5zZXJ2aWNlZGlyZWN0b3J5LnYxLlNlcnZpY2UyuAIKDUxvb2t1",
            "cFNlcnZpY2US0QEKDlJlc29sdmVTZXJ2aWNlEjcuZ29vZ2xlLmNsb3VkLnNl",
            "cnZpY2VkaXJlY3RvcnkudjEuUmVzb2x2ZVNlcnZpY2VSZXF1ZXN0GjguZ29v",
            "Z2xlLmNsb3VkLnNlcnZpY2VkaXJlY3RvcnkudjEuUmVzb2x2ZVNlcnZpY2VS",
            "ZXNwb25zZSJMgtPkkwJGIkEvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlv",
            "bnMvKi9uYW1lc3BhY2VzLyovc2VydmljZXMvKn06cmVzb2x2ZToBKhpTykEf",
            "c2VydmljZWRpcmVjdG9yeS5nb29nbGVhcGlzLmNvbdJBLmh0dHBzOi8vd3d3",
            "Lmdvb2dsZWFwaXMuY29tL2F1dGgvY2xvdWQtcGxhdGZvcm1C/QEKJGNvbS5n",
            "b29nbGUuY2xvdWQuc2VydmljZWRpcmVjdG9yeS52MUISTG9va3VwU2Vydmlj",
            "ZVByb3RvUAFaUGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFw",
            "aXMvY2xvdWQvc2VydmljZWRpcmVjdG9yeS92MTtzZXJ2aWNlZGlyZWN0b3J5",
            "+AEBqgIgR29vZ2xlLkNsb3VkLlNlcnZpY2VEaXJlY3RvcnkuVjHKAiBHb29n",
            "bGVcQ2xvdWRcU2VydmljZURpcmVjdG9yeVxWMeoCI0dvb2dsZTo6Q2xvdWQ6",
            "OlNlcnZpY2VEaXJlY3Rvcnk6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.ServiceDirectory.V1.ServiceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ServiceDirectory.V1.ResolveServiceRequest), global::Google.Cloud.ServiceDirectory.V1.ResolveServiceRequest.Parser, new[]{ "Name", "MaxEndpoints", "EndpointFilter" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ServiceDirectory.V1.ResolveServiceResponse), global::Google.Cloud.ServiceDirectory.V1.ResolveServiceResponse.Parser, new[]{ "Service" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message for
  /// [LookupService.ResolveService][google.cloud.servicedirectory.v1.LookupService.ResolveService].
  /// Looks up a service by its name, returns the service and its endpoints.
  /// </summary>
  public sealed partial class ResolveServiceRequest : pb::IMessage<ResolveServiceRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResolveServiceRequest> _parser = new pb::MessageParser<ResolveServiceRequest>(() => new ResolveServiceRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResolveServiceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ServiceDirectory.V1.LookupServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResolveServiceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResolveServiceRequest(ResolveServiceRequest other) : this() {
      name_ = other.name_;
      maxEndpoints_ = other.maxEndpoints_;
      endpointFilter_ = other.endpointFilter_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResolveServiceRequest Clone() {
      return new ResolveServiceRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. The name of the service to resolve.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "max_endpoints" field.</summary>
    public const int MaxEndpointsFieldNumber = 2;
    private int maxEndpoints_;
    /// <summary>
    /// Optional. The maximum number of endpoints to return. Defaults to 25.
    /// Maximum is 100. If a value less than one is specified, the Default is used.
    /// If a value greater than the Maximum is specified, the Maximum is used.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxEndpoints {
      get { return maxEndpoints_; }
      set {
        maxEndpoints_ = value;
      }
    }

    /// <summary>Field number for the "endpoint_filter" field.</summary>
    public const int EndpointFilterFieldNumber = 3;
    private string endpointFilter_ = "";
    /// <summary>
    /// Optional. The filter applied to the endpoints of the resolved service.
    ///
    /// General filter string syntax:
    /// &lt;field> &lt;operator> &lt;value> (&lt;logical connector>)
    /// &lt;field> can be "name" or "metadata.&lt;key>" for map field.
    /// &lt;operator> can be "&lt;, >, &lt;=, >=, !=, =, :". Of which ":" means HAS and is
    /// roughly the same as "=".
    /// &lt;value> must be the same data type as the field.
    /// &lt;logical connector> can be "AND, OR, NOT".
    ///
    /// Examples of valid filters:
    /// * "metadata.owner" returns Endpoints that have a label with the
    ///   key "owner", this is the same as "metadata:owner"
    /// * "metadata.protocol=gRPC" returns Endpoints that have key/value
    ///   "protocol=gRPC"
    /// * "metadata.owner!=sd AND metadata.foo=bar" returns
    ///   Endpoints that have "owner" field in metadata with a value that is not
    ///   "sd" AND have the key/value foo=bar.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EndpointFilter {
      get { return endpointFilter_; }
      set {
        endpointFilter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResolveServiceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResolveServiceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (MaxEndpoints != other.MaxEndpoints) return false;
      if (EndpointFilter != other.EndpointFilter) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (MaxEndpoints != 0) hash ^= MaxEndpoints.GetHashCode();
      if (EndpointFilter.Length != 0) hash ^= EndpointFilter.GetHashCode();
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
      if (MaxEndpoints != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxEndpoints);
      }
      if (EndpointFilter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(EndpointFilter);
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
      if (MaxEndpoints != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxEndpoints);
      }
      if (EndpointFilter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(EndpointFilter);
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
      if (MaxEndpoints != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxEndpoints);
      }
      if (EndpointFilter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EndpointFilter);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResolveServiceRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.MaxEndpoints != 0) {
        MaxEndpoints = other.MaxEndpoints;
      }
      if (other.EndpointFilter.Length != 0) {
        EndpointFilter = other.EndpointFilter;
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
          case 16: {
            MaxEndpoints = input.ReadInt32();
            break;
          }
          case 26: {
            EndpointFilter = input.ReadString();
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
          case 16: {
            MaxEndpoints = input.ReadInt32();
            break;
          }
          case 26: {
            EndpointFilter = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The response message for
  /// [LookupService.ResolveService][google.cloud.servicedirectory.v1.LookupService.ResolveService].
  /// </summary>
  public sealed partial class ResolveServiceResponse : pb::IMessage<ResolveServiceResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResolveServiceResponse> _parser = new pb::MessageParser<ResolveServiceResponse>(() => new ResolveServiceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResolveServiceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ServiceDirectory.V1.LookupServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResolveServiceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResolveServiceResponse(ResolveServiceResponse other) : this() {
      service_ = other.service_ != null ? other.service_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResolveServiceResponse Clone() {
      return new ResolveServiceResponse(this);
    }

    /// <summary>Field number for the "service" field.</summary>
    public const int ServiceFieldNumber = 1;
    private global::Google.Cloud.ServiceDirectory.V1.Service service_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.ServiceDirectory.V1.Service Service {
      get { return service_; }
      set {
        service_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResolveServiceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResolveServiceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Service, other.Service)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (service_ != null) hash ^= Service.GetHashCode();
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
      if (service_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Service);
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
      if (service_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Service);
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
      if (service_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Service);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResolveServiceResponse other) {
      if (other == null) {
        return;
      }
      if (other.service_ != null) {
        if (service_ == null) {
          Service = new global::Google.Cloud.ServiceDirectory.V1.Service();
        }
        Service.MergeFrom(other.Service);
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
            if (service_ == null) {
              Service = new global::Google.Cloud.ServiceDirectory.V1.Service();
            }
            input.ReadMessage(Service);
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
            if (service_ == null) {
              Service = new global::Google.Cloud.ServiceDirectory.V1.Service();
            }
            input.ReadMessage(Service);
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
