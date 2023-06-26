// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/bigtable/v2/feature_flags.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Bigtable.V2 {

  /// <summary>Holder for reflection information generated from google/bigtable/v2/feature_flags.proto</summary>
  public static partial class FeatureFlagsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/bigtable/v2/feature_flags.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeatureFlagsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvYmlndGFibGUvdjIvZmVhdHVyZV9mbGFncy5wcm90bxISZ29v",
            "Z2xlLmJpZ3RhYmxlLnYyIkUKDEZlYXR1cmVGbGFncxIVCg1yZXZlcnNlX3Nj",
            "YW5zGAEgASgIEh4KFm11dGF0ZV9yb3dzX3JhdGVfbGltaXQYAyABKAhCvQEK",
            "FmNvbS5nb29nbGUuYmlndGFibGUudjJCEUZlYXR1cmVGbGFnc1Byb3RvUAFa",
            "Omdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYmlndGFi",
            "bGUvdjI7YmlndGFibGWqAhhHb29nbGUuQ2xvdWQuQmlndGFibGUuVjLKAhhH",
            "b29nbGVcQ2xvdWRcQmlndGFibGVcVjLqAhtHb29nbGU6OkNsb3VkOjpCaWd0",
            "YWJsZTo6VjJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Bigtable.V2.FeatureFlags), global::Google.Cloud.Bigtable.V2.FeatureFlags.Parser, new[]{ "ReverseScans", "MutateRowsRateLimit" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Feature flags supported by a client.
  /// This is intended to be sent as part of request metadata to assure the server
  /// that certain behaviors are safe to enable. This proto is meant to be
  /// serialized and websafe-base64 encoded under the `bigtable-features` metadata
  /// key. The value will remain constant for the lifetime of a client and due to
  /// HTTP2's HPACK compression, the request overhead will be tiny.
  /// This is an internal implementation detail and should not be used by endusers
  /// directly.
  /// </summary>
  public sealed partial class FeatureFlags : pb::IMessage<FeatureFlags>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeatureFlags> _parser = new pb::MessageParser<FeatureFlags>(() => new FeatureFlags());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeatureFlags> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Bigtable.V2.FeatureFlagsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureFlags() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureFlags(FeatureFlags other) : this() {
      reverseScans_ = other.reverseScans_;
      mutateRowsRateLimit_ = other.mutateRowsRateLimit_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureFlags Clone() {
      return new FeatureFlags(this);
    }

    /// <summary>Field number for the "reverse_scans" field.</summary>
    public const int ReverseScansFieldNumber = 1;
    private bool reverseScans_;
    /// <summary>
    /// Notify the server that the client supports reverse scans. The server will
    /// reject ReadRowsRequests with the reverse bit set when this is absent.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ReverseScans {
      get { return reverseScans_; }
      set {
        reverseScans_ = value;
      }
    }

    /// <summary>Field number for the "mutate_rows_rate_limit" field.</summary>
    public const int MutateRowsRateLimitFieldNumber = 3;
    private bool mutateRowsRateLimit_;
    /// <summary>
    /// Notify the server that the client enables batch write flow control by
    /// requesting RateLimitInfo from MutateRowsResponse.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MutateRowsRateLimit {
      get { return mutateRowsRateLimit_; }
      set {
        mutateRowsRateLimit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeatureFlags);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeatureFlags other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReverseScans != other.ReverseScans) return false;
      if (MutateRowsRateLimit != other.MutateRowsRateLimit) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ReverseScans != false) hash ^= ReverseScans.GetHashCode();
      if (MutateRowsRateLimit != false) hash ^= MutateRowsRateLimit.GetHashCode();
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
      if (ReverseScans != false) {
        output.WriteRawTag(8);
        output.WriteBool(ReverseScans);
      }
      if (MutateRowsRateLimit != false) {
        output.WriteRawTag(24);
        output.WriteBool(MutateRowsRateLimit);
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
      if (ReverseScans != false) {
        output.WriteRawTag(8);
        output.WriteBool(ReverseScans);
      }
      if (MutateRowsRateLimit != false) {
        output.WriteRawTag(24);
        output.WriteBool(MutateRowsRateLimit);
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
      if (ReverseScans != false) {
        size += 1 + 1;
      }
      if (MutateRowsRateLimit != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeatureFlags other) {
      if (other == null) {
        return;
      }
      if (other.ReverseScans != false) {
        ReverseScans = other.ReverseScans;
      }
      if (other.MutateRowsRateLimit != false) {
        MutateRowsRateLimit = other.MutateRowsRateLimit;
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
            ReverseScans = input.ReadBool();
            break;
          }
          case 24: {
            MutateRowsRateLimit = input.ReadBool();
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
            ReverseScans = input.ReadBool();
            break;
          }
          case 24: {
            MutateRowsRateLimit = input.ReadBool();
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
