// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/bigtable/v2/response_params.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Bigtable.V2 {

  /// <summary>Holder for reflection information generated from google/bigtable/v2/response_params.proto</summary>
  public static partial class ResponseParamsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/bigtable/v2/response_params.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResponseParamsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvYmlndGFibGUvdjIvcmVzcG9uc2VfcGFyYW1zLnByb3RvEhJn",
            "b29nbGUuYmlndGFibGUudjIiWgoOUmVzcG9uc2VQYXJhbXMSFAoHem9uZV9p",
            "ZBgBIAEoCUgAiAEBEhcKCmNsdXN0ZXJfaWQYAiABKAlIAYgBAUIKCghfem9u",
            "ZV9pZEINCgtfY2x1c3Rlcl9pZEK/AQoWY29tLmdvb2dsZS5iaWd0YWJsZS52",
            "MkITUmVzcG9uc2VQYXJhbXNQcm90b1ABWjpnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2JpZ3RhYmxlL3YyO2JpZ3RhYmxlqgIYR29v",
            "Z2xlLkNsb3VkLkJpZ3RhYmxlLlYyygIYR29vZ2xlXENsb3VkXEJpZ3RhYmxl",
            "XFYy6gIbR29vZ2xlOjpDbG91ZDo6QmlndGFibGU6OlYyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Bigtable.V2.ResponseParams), global::Google.Cloud.Bigtable.V2.ResponseParams.Parser, new[]{ "ZoneId", "ClusterId" }, new[]{ "ZoneId", "ClusterId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Response metadata proto
  /// This is an experimental feature that will be used to get zone_id and
  /// cluster_id from response trailers to tag the metrics. This should not be
  /// used by customers directly
  /// </summary>
  public sealed partial class ResponseParams : pb::IMessage<ResponseParams>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResponseParams> _parser = new pb::MessageParser<ResponseParams>(() => new ResponseParams());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResponseParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Bigtable.V2.ResponseParamsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResponseParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResponseParams(ResponseParams other) : this() {
      zoneId_ = other.zoneId_;
      clusterId_ = other.clusterId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResponseParams Clone() {
      return new ResponseParams(this);
    }

    /// <summary>Field number for the "zone_id" field.</summary>
    public const int ZoneIdFieldNumber = 1;
    private readonly static string ZoneIdDefaultValue = "";

    private string zoneId_;
    /// <summary>
    /// The cloud bigtable zone associated with the cluster.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ZoneId {
      get { return zoneId_ ?? ZoneIdDefaultValue; }
      set {
        zoneId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "zone_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasZoneId {
      get { return zoneId_ != null; }
    }
    /// <summary>Clears the value of the "zone_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearZoneId() {
      zoneId_ = null;
    }

    /// <summary>Field number for the "cluster_id" field.</summary>
    public const int ClusterIdFieldNumber = 2;
    private readonly static string ClusterIdDefaultValue = "";

    private string clusterId_;
    /// <summary>
    /// Identifier for a cluster that represents set of
    /// bigtable resources.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClusterId {
      get { return clusterId_ ?? ClusterIdDefaultValue; }
      set {
        clusterId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "cluster_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasClusterId {
      get { return clusterId_ != null; }
    }
    /// <summary>Clears the value of the "cluster_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearClusterId() {
      clusterId_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResponseParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResponseParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ZoneId != other.ZoneId) return false;
      if (ClusterId != other.ClusterId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasZoneId) hash ^= ZoneId.GetHashCode();
      if (HasClusterId) hash ^= ClusterId.GetHashCode();
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
      if (HasZoneId) {
        output.WriteRawTag(10);
        output.WriteString(ZoneId);
      }
      if (HasClusterId) {
        output.WriteRawTag(18);
        output.WriteString(ClusterId);
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
      if (HasZoneId) {
        output.WriteRawTag(10);
        output.WriteString(ZoneId);
      }
      if (HasClusterId) {
        output.WriteRawTag(18);
        output.WriteString(ClusterId);
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
      if (HasZoneId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ZoneId);
      }
      if (HasClusterId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClusterId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResponseParams other) {
      if (other == null) {
        return;
      }
      if (other.HasZoneId) {
        ZoneId = other.ZoneId;
      }
      if (other.HasClusterId) {
        ClusterId = other.ClusterId;
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
            ZoneId = input.ReadString();
            break;
          }
          case 18: {
            ClusterId = input.ReadString();
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
            ZoneId = input.ReadString();
            break;
          }
          case 18: {
            ClusterId = input.ReadString();
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
