// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/datacatalog/v1/common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DataCatalog.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/datacatalog/v1/common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/datacatalog/v1/common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvZGF0YWNhdGFsb2cvdjEvY29tbW9uLnByb3RvEhtn",
            "b29nbGUuY2xvdWQuZGF0YWNhdGFsb2cudjEaH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8iUQoPUGVyc29uYWxEZXRhaWxzEg8KB3N0YXJyZWQY",
            "ASABKAgSLQoJc3Rhcl90aW1lGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRp",
            "bWVzdGFtcCp7ChBJbnRlZ3JhdGVkU3lzdGVtEiEKHUlOVEVHUkFURURfU1lT",
            "VEVNX1VOU1BFQ0lGSUVEEAASDAoIQklHUVVFUlkQARIQCgxDTE9VRF9QVUJT",
            "VUIQAhIWChJEQVRBUFJPQ19NRVRBU1RPUkUQAxIMCghEQVRBUExFWBAEQssB",
            "Ch9jb20uZ29vZ2xlLmNsb3VkLmRhdGFjYXRhbG9nLnYxUAFaRmdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvZGF0YWNhdGFs",
            "b2cvdjE7ZGF0YWNhdGFsb2f4AQGqAhtHb29nbGUuQ2xvdWQuRGF0YUNhdGFs",
            "b2cuVjHKAhtHb29nbGVcQ2xvdWRcRGF0YUNhdGFsb2dcVjHqAh5Hb29nbGU6",
            "OkNsb3VkOjpEYXRhQ2F0YWxvZzo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.DataCatalog.V1.IntegratedSystem), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.PersonalDetails), global::Google.Cloud.DataCatalog.V1.PersonalDetails.Parser, new[]{ "Starred", "StarTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// This enum lists all the systems that Data Catalog integrates with.
  /// </summary>
  public enum IntegratedSystem {
    /// <summary>
    /// Default unknown system.
    /// </summary>
    [pbr::OriginalName("INTEGRATED_SYSTEM_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// BigQuery.
    /// </summary>
    [pbr::OriginalName("BIGQUERY")] Bigquery = 1,
    /// <summary>
    /// Cloud Pub/Sub.
    /// </summary>
    [pbr::OriginalName("CLOUD_PUBSUB")] CloudPubsub = 2,
    /// <summary>
    /// Dataproc Metastore.
    /// </summary>
    [pbr::OriginalName("DATAPROC_METASTORE")] DataprocMetastore = 3,
    /// <summary>
    /// Dataplex.
    /// </summary>
    [pbr::OriginalName("DATAPLEX")] Dataplex = 4,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Entry metadata relevant only to the user and private to them.
  /// </summary>
  public sealed partial class PersonalDetails : pb::IMessage<PersonalDetails>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PersonalDetails> _parser = new pb::MessageParser<PersonalDetails>(() => new PersonalDetails());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PersonalDetails> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersonalDetails() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersonalDetails(PersonalDetails other) : this() {
      starred_ = other.starred_;
      starTime_ = other.starTime_ != null ? other.starTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersonalDetails Clone() {
      return new PersonalDetails(this);
    }

    /// <summary>Field number for the "starred" field.</summary>
    public const int StarredFieldNumber = 1;
    private bool starred_;
    /// <summary>
    /// True if the entry is starred by the user; false otherwise.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Starred {
      get { return starred_; }
      set {
        starred_ = value;
      }
    }

    /// <summary>Field number for the "star_time" field.</summary>
    public const int StarTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp starTime_;
    /// <summary>
    /// Set if the entry is starred; unset otherwise.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StarTime {
      get { return starTime_; }
      set {
        starTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PersonalDetails);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PersonalDetails other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Starred != other.Starred) return false;
      if (!object.Equals(StarTime, other.StarTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Starred != false) hash ^= Starred.GetHashCode();
      if (starTime_ != null) hash ^= StarTime.GetHashCode();
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
      if (Starred != false) {
        output.WriteRawTag(8);
        output.WriteBool(Starred);
      }
      if (starTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StarTime);
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
      if (Starred != false) {
        output.WriteRawTag(8);
        output.WriteBool(Starred);
      }
      if (starTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StarTime);
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
      if (Starred != false) {
        size += 1 + 1;
      }
      if (starTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StarTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PersonalDetails other) {
      if (other == null) {
        return;
      }
      if (other.Starred != false) {
        Starred = other.Starred;
      }
      if (other.starTime_ != null) {
        if (starTime_ == null) {
          StarTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StarTime.MergeFrom(other.StarTime);
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
            Starred = input.ReadBool();
            break;
          }
          case 18: {
            if (starTime_ == null) {
              StarTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StarTime);
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
            Starred = input.ReadBool();
            break;
          }
          case 18: {
            if (starTime_ == null) {
              StarTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StarTime);
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
