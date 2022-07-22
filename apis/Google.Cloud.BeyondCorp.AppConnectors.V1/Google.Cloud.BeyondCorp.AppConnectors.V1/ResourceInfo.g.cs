// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/beyondcorp/appconnectors/v1/resource_info.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.BeyondCorp.AppConnectors.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/beyondcorp/appconnectors/v1/resource_info.proto</summary>
  public static partial class ResourceInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/beyondcorp/appconnectors/v1/resource_info.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResourceInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvY2xvdWQvYmV5b25kY29ycC9hcHBjb25uZWN0b3JzL3YxL3Jl",
            "c291cmNlX2luZm8ucHJvdG8SKGdvb2dsZS5jbG91ZC5iZXlvbmRjb3JwLmFw",
            "cGNvbm5lY3RvcnMudjEaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJv",
            "dG8aGWdvb2dsZS9wcm90b2J1Zi9hbnkucHJvdG8aH2dvb2dsZS9wcm90b2J1",
            "Zi90aW1lc3RhbXAucHJvdG8i/gEKDFJlc291cmNlSW5mbxIPCgJpZBgBIAEo",
            "CUID4EECEkYKBnN0YXR1cxgCIAEoDjI2Lmdvb2dsZS5jbG91ZC5iZXlvbmRj",
            "b3JwLmFwcGNvbm5lY3RvcnMudjEuSGVhbHRoU3RhdHVzEiYKCHJlc291cmNl",
            "GAMgASgLMhQuZ29vZ2xlLnByb3RvYnVmLkFueRIoCgR0aW1lGAQgASgLMhou",
            "Z29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBJDCgNzdWIYBSADKAsyNi5nb29n",
            "bGUuY2xvdWQuYmV5b25kY29ycC5hcHBjb25uZWN0b3JzLnYxLlJlc291cmNl",
            "SW5mbyppCgxIZWFsdGhTdGF0dXMSHQoZSEVBTFRIX1NUQVRVU19VTlNQRUNJ",
            "RklFRBAAEgsKB0hFQUxUSFkQARINCglVTkhFQUxUSFkQAhIQCgxVTlJFU1BP",
            "TlNJVkUQAxIMCghERUdSQURFRBAEQp8CCixjb20uZ29vZ2xlLmNsb3VkLmJl",
            "eW9uZGNvcnAuYXBwY29ubmVjdG9ycy52MUIRUmVzb3VyY2VJbmZvUHJvdG9Q",
            "AVpVZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91",
            "ZC9iZXlvbmRjb3JwL2FwcGNvbm5lY3RvcnMvdjE7YXBwY29ubmVjdG9yc6oC",
            "KEdvb2dsZS5DbG91ZC5CZXlvbmRDb3JwLkFwcENvbm5lY3RvcnMuVjHKAihH",
            "b29nbGVcQ2xvdWRcQmV5b25kQ29ycFxBcHBDb25uZWN0b3JzXFYx6gIsR29v",
            "Z2xlOjpDbG91ZDo6QmV5b25kQ29ycDo6QXBwQ29ubmVjdG9yczo6VjFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.BeyondCorp.AppConnectors.V1.HealthStatus), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.BeyondCorp.AppConnectors.V1.ResourceInfo), global::Google.Cloud.BeyondCorp.AppConnectors.V1.ResourceInfo.Parser, new[]{ "Id", "Status", "Resource", "Time", "Sub" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// HealthStatus represents the health status.
  /// </summary>
  public enum HealthStatus {
    /// <summary>
    /// Health status is unknown: not initialized or failed to retrieve.
    /// </summary>
    [pbr::OriginalName("HEALTH_STATUS_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The resource is healthy.
    /// </summary>
    [pbr::OriginalName("HEALTHY")] Healthy = 1,
    /// <summary>
    /// The resource is unhealthy.
    /// </summary>
    [pbr::OriginalName("UNHEALTHY")] Unhealthy = 2,
    /// <summary>
    /// The resource is unresponsive.
    /// </summary>
    [pbr::OriginalName("UNRESPONSIVE")] Unresponsive = 3,
    /// <summary>
    /// Some sub-resources are UNHEALTHY.
    /// </summary>
    [pbr::OriginalName("DEGRADED")] Degraded = 4,
  }

  #endregion

  #region Messages
  /// <summary>
  /// ResourceInfo represents the information/status of an app connector resource.
  /// Such as:
  /// - remote_agent
  ///   - container
  ///     - runtime
  ///     - appgateway
  ///       - appconnector
  ///         - appconnection
  ///           - tunnel
  ///       - logagent
  /// </summary>
  public sealed partial class ResourceInfo : pb::IMessage<ResourceInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResourceInfo> _parser = new pb::MessageParser<ResourceInfo>(() => new ResourceInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResourceInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.BeyondCorp.AppConnectors.V1.ResourceInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceInfo(ResourceInfo other) : this() {
      id_ = other.id_;
      status_ = other.status_;
      resource_ = other.resource_ != null ? other.resource_.Clone() : null;
      time_ = other.time_ != null ? other.time_.Clone() : null;
      sub_ = other.sub_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceInfo Clone() {
      return new ResourceInfo(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// Required. Unique Id for the resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::Google.Cloud.BeyondCorp.AppConnectors.V1.HealthStatus status_ = global::Google.Cloud.BeyondCorp.AppConnectors.V1.HealthStatus.Unspecified;
    /// <summary>
    /// Overall health status. Overall status is derived based on the status of
    /// each sub level resources.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.BeyondCorp.AppConnectors.V1.HealthStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Any resource_;
    /// <summary>
    /// Specific details for the resource. This is for internal use only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Any Resource {
      get { return resource_; }
      set {
        resource_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp time_;
    /// <summary>
    /// The timestamp to collect the info. It is suggested to be set by
    /// the topmost level resource only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "sub" field.</summary>
    public const int SubFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Cloud.BeyondCorp.AppConnectors.V1.ResourceInfo> _repeated_sub_codec
        = pb::FieldCodec.ForMessage(42, global::Google.Cloud.BeyondCorp.AppConnectors.V1.ResourceInfo.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.BeyondCorp.AppConnectors.V1.ResourceInfo> sub_ = new pbc::RepeatedField<global::Google.Cloud.BeyondCorp.AppConnectors.V1.ResourceInfo>();
    /// <summary>
    /// List of Info for the sub level resources.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.BeyondCorp.AppConnectors.V1.ResourceInfo> Sub {
      get { return sub_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResourceInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResourceInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(Resource, other.Resource)) return false;
      if (!object.Equals(Time, other.Time)) return false;
      if(!sub_.Equals(other.sub_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Status != global::Google.Cloud.BeyondCorp.AppConnectors.V1.HealthStatus.Unspecified) hash ^= Status.GetHashCode();
      if (resource_ != null) hash ^= Resource.GetHashCode();
      if (time_ != null) hash ^= Time.GetHashCode();
      hash ^= sub_.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Status != global::Google.Cloud.BeyondCorp.AppConnectors.V1.HealthStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (resource_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Resource);
      }
      if (time_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Time);
      }
      sub_.WriteTo(output, _repeated_sub_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Status != global::Google.Cloud.BeyondCorp.AppConnectors.V1.HealthStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (resource_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Resource);
      }
      if (time_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Time);
      }
      sub_.WriteTo(ref output, _repeated_sub_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Status != global::Google.Cloud.BeyondCorp.AppConnectors.V1.HealthStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (resource_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Resource);
      }
      if (time_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Time);
      }
      size += sub_.CalculateSize(_repeated_sub_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResourceInfo other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Status != global::Google.Cloud.BeyondCorp.AppConnectors.V1.HealthStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.resource_ != null) {
        if (resource_ == null) {
          Resource = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Resource.MergeFrom(other.Resource);
      }
      if (other.time_ != null) {
        if (time_ == null) {
          Time = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Time.MergeFrom(other.Time);
      }
      sub_.Add(other.sub_);
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
            Id = input.ReadString();
            break;
          }
          case 16: {
            Status = (global::Google.Cloud.BeyondCorp.AppConnectors.V1.HealthStatus) input.ReadEnum();
            break;
          }
          case 26: {
            if (resource_ == null) {
              Resource = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Resource);
            break;
          }
          case 34: {
            if (time_ == null) {
              Time = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Time);
            break;
          }
          case 42: {
            sub_.AddEntriesFrom(input, _repeated_sub_codec);
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
            Id = input.ReadString();
            break;
          }
          case 16: {
            Status = (global::Google.Cloud.BeyondCorp.AppConnectors.V1.HealthStatus) input.ReadEnum();
            break;
          }
          case 26: {
            if (resource_ == null) {
              Resource = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Resource);
            break;
          }
          case 34: {
            if (time_ == null) {
              Time = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Time);
            break;
          }
          case 42: {
            sub_.AddEntriesFrom(ref input, _repeated_sub_codec);
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
