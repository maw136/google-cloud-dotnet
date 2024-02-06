// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/datacatalog/v1/timestamps.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DataCatalog.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/datacatalog/v1/timestamps.proto</summary>
  public static partial class TimestampsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/datacatalog/v1/timestamps.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TimestampsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvY2xvdWQvZGF0YWNhdGFsb2cvdjEvdGltZXN0YW1wcy5wcm90",
            "bxIbZ29vZ2xlLmNsb3VkLmRhdGFjYXRhbG9nLnYxGh9nb29nbGUvYXBpL2Zp",
            "ZWxkX2JlaGF2aW9yLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1w",
            "LnByb3RvIqoBChBTeXN0ZW1UaW1lc3RhbXBzEi8KC2NyZWF0ZV90aW1lGAEg",
            "ASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIvCgt1cGRhdGVfdGlt",
            "ZRgCIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASNAoLZXhwaXJl",
            "X3RpbWUYAyABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQNC",
            "xgEKH2NvbS5nb29nbGUuY2xvdWQuZGF0YWNhdGFsb2cudjFQAVpBY2xvdWQu",
            "Z29vZ2xlLmNvbS9nby9kYXRhY2F0YWxvZy9hcGl2MS9kYXRhY2F0YWxvZ3Bi",
            "O2RhdGFjYXRhbG9ncGL4AQGqAhtHb29nbGUuQ2xvdWQuRGF0YUNhdGFsb2cu",
            "VjHKAhtHb29nbGVcQ2xvdWRcRGF0YUNhdGFsb2dcVjHqAh5Hb29nbGU6OkNs",
            "b3VkOjpEYXRhQ2F0YWxvZzo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.SystemTimestamps), global::Google.Cloud.DataCatalog.V1.SystemTimestamps.Parser, new[]{ "CreateTime", "UpdateTime", "ExpireTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Timestamps associated with this resource in a particular system.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SystemTimestamps : pb::IMessage<SystemTimestamps>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SystemTimestamps> _parser = new pb::MessageParser<SystemTimestamps>(() => new SystemTimestamps());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SystemTimestamps> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.TimestampsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SystemTimestamps() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SystemTimestamps(SystemTimestamps other) : this() {
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      expireTime_ = other.expireTime_ != null ? other.expireTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SystemTimestamps Clone() {
      return new SystemTimestamps(this);
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Creation timestamp of the resource within the given system.
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
    public const int UpdateTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Timestamp of the last modification of the resource or its metadata within
    /// a given system.
    ///
    /// Note: Depending on the source system, not every modification updates this
    /// timestamp.
    /// For example, BigQuery timestamps every metadata modification but not data
    /// or permission changes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "expire_time" field.</summary>
    public const int ExpireTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp expireTime_;
    /// <summary>
    /// Output only. Expiration timestamp of the resource within the given system.
    ///
    /// Currently only applicable to BigQuery resources.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ExpireTime {
      get { return expireTime_; }
      set {
        expireTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SystemTimestamps);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SystemTimestamps other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!object.Equals(ExpireTime, other.ExpireTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (expireTime_ != null) hash ^= ExpireTime.GetHashCode();
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
      if (createTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateTime);
      }
      if (expireTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ExpireTime);
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
      if (createTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateTime);
      }
      if (expireTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ExpireTime);
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
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (expireTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpireTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SystemTimestamps other) {
      if (other == null) {
        return;
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
      if (other.expireTime_ != null) {
        if (expireTime_ == null) {
          ExpireTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ExpireTime.MergeFrom(other.ExpireTime);
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
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 18: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 26: {
            if (expireTime_ == null) {
              ExpireTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpireTime);
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
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 18: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 26: {
            if (expireTime_ == null) {
              ExpireTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpireTime);
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
