// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/servicedirectory/v1beta1/lookup_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ServiceDirectory.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/servicedirectory/v1beta1/lookup_service.proto</summary>
  public static partial class LookupServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/servicedirectory/v1beta1/lookup_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LookupServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvY2xvdWQvc2VydmljZWRpcmVjdG9yeS92MWJldGExL2xvb2t1",
            "cF9zZXJ2aWNlLnByb3RvEiVnb29nbGUuY2xvdWQuc2VydmljZWRpcmVjdG9y",
            "eS52MWJldGExGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGh9nb29n",
            "bGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291",
            "cmNlLnByb3RvGjNnb29nbGUvY2xvdWQvc2VydmljZWRpcmVjdG9yeS92MWJl",
            "dGExL3NlcnZpY2UucHJvdG8aF2dvb2dsZS9hcGkvY2xpZW50LnByb3RvIpAB",
            "ChVSZXNvbHZlU2VydmljZVJlcXVlc3QSPQoEbmFtZRgBIAEoCUIv4EEC+kEp",
            "CidzZXJ2aWNlZGlyZWN0b3J5Lmdvb2dsZWFwaXMuY29tL1NlcnZpY2USGgoN",
            "bWF4X2VuZHBvaW50cxgCIAEoBUID4EEBEhwKD2VuZHBvaW50X2ZpbHRlchgD",
            "IAEoCUID4EEBIlkKFlJlc29sdmVTZXJ2aWNlUmVzcG9uc2USPwoHc2Vydmlj",
            "ZRgBIAEoCzIuLmdvb2dsZS5jbG91ZC5zZXJ2aWNlZGlyZWN0b3J5LnYxYmV0",
            "YTEuU2VydmljZTLHAgoNTG9va3VwU2VydmljZRLgAQoOUmVzb2x2ZVNlcnZp",
            "Y2USPC5nb29nbGUuY2xvdWQuc2VydmljZWRpcmVjdG9yeS52MWJldGExLlJl",
            "c29sdmVTZXJ2aWNlUmVxdWVzdBo9Lmdvb2dsZS5jbG91ZC5zZXJ2aWNlZGly",
            "ZWN0b3J5LnYxYmV0YTEuUmVzb2x2ZVNlcnZpY2VSZXNwb25zZSJRgtPkkwJL",
            "IkYvdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL25hbWVz",
            "cGFjZXMvKi9zZXJ2aWNlcy8qfTpyZXNvbHZlOgEqGlPKQR9zZXJ2aWNlZGly",
            "ZWN0b3J5Lmdvb2dsZWFwaXMuY29t0kEuaHR0cHM6Ly93d3cuZ29vZ2xlYXBp",
            "cy5jb20vYXV0aC9jbG91ZC1wbGF0Zm9ybUKWAgopY29tLmdvb2dsZS5jbG91",
            "ZC5zZXJ2aWNlZGlyZWN0b3J5LnYxYmV0YTFCEkxvb2t1cFNlcnZpY2VQcm90",
            "b1ABWlVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Ns",
            "b3VkL3NlcnZpY2VkaXJlY3RvcnkvdjFiZXRhMTtzZXJ2aWNlZGlyZWN0b3J5",
            "+AEBqgIlR29vZ2xlLkNsb3VkLlNlcnZpY2VEaXJlY3RvcnkuVjFCZXRhMcoC",
            "JUdvb2dsZVxDbG91ZFxTZXJ2aWNlRGlyZWN0b3J5XFYxYmV0YTHqAihHb29n",
            "bGU6OkNsb3VkOjpTZXJ2aWNlRGlyZWN0b3J5OjpWMWJldGExYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.ServiceDirectory.V1Beta1.ServiceReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ServiceDirectory.V1Beta1.ResolveServiceRequest), global::Google.Cloud.ServiceDirectory.V1Beta1.ResolveServiceRequest.Parser, new[]{ "Name", "MaxEndpoints", "EndpointFilter" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ServiceDirectory.V1Beta1.ResolveServiceResponse), global::Google.Cloud.ServiceDirectory.V1Beta1.ResolveServiceResponse.Parser, new[]{ "Service" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message for [LookupService.ResolveService][google.cloud.servicedirectory.v1beta1.LookupService.ResolveService].
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
    public static pb::MessageParser<ResolveServiceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ServiceDirectory.V1Beta1.LookupServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveServiceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveServiceRequest(ResolveServiceRequest other) : this() {
      name_ = other.name_;
      maxEndpoints_ = other.maxEndpoints_;
      endpointFilter_ = other.endpointFilter_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    /// Optional. The maximum number of endpoints to return. Defaults to 25. Maximum is 100.
    /// If a value less than one is specified, the Default is used.
    /// If a value greater than the Maximum is specified, the Maximum is used.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    /// General `filter` string syntax:
    /// `&lt;field> &lt;operator> &lt;value> (&lt;logical connector>)`
    ///
    /// *   `&lt;field>` can be `name`, `address`, `port`, or `metadata.&lt;key>` for
    ///     map field
    /// *   `&lt;operator>` can be `&lt;`, `>`, `&lt;=`, `>=`, `!=`, `=`, `:`. Of which `:`
    ///     means `HAS`, and is roughly the same as `=`
    /// *   `&lt;value>` must be the same data type as field
    /// *   `&lt;logical connector>` can be `AND`, `OR`, `NOT`
    ///
    /// Examples of valid filters:
    ///
    /// *   `metadata.owner` returns endpoints that have a annotation with the key
    ///     `owner`, this is the same as `metadata:owner`
    /// *   `metadata.protocol=gRPC` returns endpoints that have key/value
    ///     `protocol=gRPC`
    /// *   `address=192.108.1.105` returns endpoints that have this address
    /// *   `port>8080` returns endpoints that have port number larger than 8080
    /// *
    /// `name>projects/my-project/locations/us-east1/namespaces/my-namespace/services/my-service/endpoints/endpoint-c`
    ///     returns endpoints that have name that is alphabetically later than the
    ///     string, so "endpoint-e" is returned but "endpoint-a" is not
    /// *   `metadata.owner!=sd AND metadata.foo=bar` returns endpoints that have
    ///     `owner` in annotation key but value is not `sd` AND have key/value
    ///      `foo=bar`
    /// *   `doesnotexist.foo=bar` returns an empty list. Note that endpoint
    ///     doesn't have a field called "doesnotexist". Since the filter does not
    ///     match any endpoint, it returns no results
    ///
    /// For more information about filtering, see
    /// [API Filtering](https://aip.dev/160).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EndpointFilter {
      get { return endpointFilter_; }
      set {
        endpointFilter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResolveServiceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
  /// The response message for [LookupService.ResolveService][google.cloud.servicedirectory.v1beta1.LookupService.ResolveService].
  /// </summary>
  public sealed partial class ResolveServiceResponse : pb::IMessage<ResolveServiceResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResolveServiceResponse> _parser = new pb::MessageParser<ResolveServiceResponse>(() => new ResolveServiceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResolveServiceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ServiceDirectory.V1Beta1.LookupServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveServiceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveServiceResponse(ResolveServiceResponse other) : this() {
      service_ = other.service_ != null ? other.service_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveServiceResponse Clone() {
      return new ResolveServiceResponse(this);
    }

    /// <summary>Field number for the "service" field.</summary>
    public const int ServiceFieldNumber = 1;
    private global::Google.Cloud.ServiceDirectory.V1Beta1.Service service_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.ServiceDirectory.V1Beta1.Service Service {
      get { return service_; }
      set {
        service_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResolveServiceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public override int GetHashCode() {
      int hash = 1;
      if (service_ != null) hash ^= Service.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public void MergeFrom(ResolveServiceResponse other) {
      if (other == null) {
        return;
      }
      if (other.service_ != null) {
        if (service_ == null) {
          Service = new global::Google.Cloud.ServiceDirectory.V1Beta1.Service();
        }
        Service.MergeFrom(other.Service);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
              Service = new global::Google.Cloud.ServiceDirectory.V1Beta1.Service();
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
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (service_ == null) {
              Service = new global::Google.Cloud.ServiceDirectory.V1Beta1.Service();
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
