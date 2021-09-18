// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/bigquery/storage/v1/protobuf.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.BigQuery.Storage.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/bigquery/storage/v1/protobuf.proto</summary>
  public static partial class ProtobufReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/bigquery/storage/v1/protobuf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtobufReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvYmlncXVlcnkvc3RvcmFnZS92MS9wcm90b2J1Zi5w",
            "cm90bxIgZ29vZ2xlLmNsb3VkLmJpZ3F1ZXJ5LnN0b3JhZ2UudjEaIGdvb2ds",
            "ZS9wcm90b2J1Zi9kZXNjcmlwdG9yLnByb3RvIkkKC1Byb3RvU2NoZW1hEjoK",
            "EHByb3RvX2Rlc2NyaXB0b3IYASABKAsyIC5nb29nbGUucHJvdG9idWYuRGVz",
            "Y3JpcHRvclByb3RvIiQKCVByb3RvUm93cxIXCg9zZXJpYWxpemVkX3Jvd3MY",
            "ASADKAxCxgEKJGNvbS5nb29nbGUuY2xvdWQuYmlncXVlcnkuc3RvcmFnZS52",
            "MUINUHJvdG9CdWZQcm90b1ABWkdnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Nsb3VkL2JpZ3F1ZXJ5L3N0b3JhZ2UvdjE7c3RvcmFn",
            "ZaoCIEdvb2dsZS5DbG91ZC5CaWdRdWVyeS5TdG9yYWdlLlYxygIgR29vZ2xl",
            "XENsb3VkXEJpZ1F1ZXJ5XFN0b3JhZ2VcVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.BigQuery.Storage.V1.ProtoSchema), global::Google.Cloud.BigQuery.Storage.V1.ProtoSchema.Parser, new[]{ "ProtoDescriptor" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.BigQuery.Storage.V1.ProtoRows), global::Google.Cloud.BigQuery.Storage.V1.ProtoRows.Parser, new[]{ "SerializedRows" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// ProtoSchema describes the schema of the serialized protocol buffer data rows.
  /// </summary>
  public sealed partial class ProtoSchema : pb::IMessage<ProtoSchema>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProtoSchema> _parser = new pb::MessageParser<ProtoSchema>(() => new ProtoSchema());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProtoSchema> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.BigQuery.Storage.V1.ProtobufReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoSchema() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoSchema(ProtoSchema other) : this() {
      protoDescriptor_ = other.protoDescriptor_ != null ? other.protoDescriptor_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoSchema Clone() {
      return new ProtoSchema(this);
    }

    /// <summary>Field number for the "proto_descriptor" field.</summary>
    public const int ProtoDescriptorFieldNumber = 1;
    private global::Google.Protobuf.Reflection.DescriptorProto protoDescriptor_;
    /// <summary>
    /// Descriptor for input message.  The provided descriptor must be self
    /// contained, such that data rows sent can be fully decoded using only the
    /// single descriptor.  For data rows that are compositions of multiple
    /// independent messages, this means the descriptor may need to be transformed
    /// to only use nested types:
    /// https://developers.google.com/protocol-buffers/docs/proto#nested
    ///
    /// For additional information for how proto types and values map onto BigQuery
    /// see: https://cloud.google.com/bigquery/docs/write-api#data_type_conversions
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.Reflection.DescriptorProto ProtoDescriptor {
      get { return protoDescriptor_; }
      set {
        protoDescriptor_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProtoSchema);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProtoSchema other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ProtoDescriptor, other.ProtoDescriptor)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (protoDescriptor_ != null) hash ^= ProtoDescriptor.GetHashCode();
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
      if (protoDescriptor_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ProtoDescriptor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (protoDescriptor_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ProtoDescriptor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (protoDescriptor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProtoDescriptor);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProtoSchema other) {
      if (other == null) {
        return;
      }
      if (other.protoDescriptor_ != null) {
        if (protoDescriptor_ == null) {
          ProtoDescriptor = new global::Google.Protobuf.Reflection.DescriptorProto();
        }
        ProtoDescriptor.MergeFrom(other.ProtoDescriptor);
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
            if (protoDescriptor_ == null) {
              ProtoDescriptor = new global::Google.Protobuf.Reflection.DescriptorProto();
            }
            input.ReadMessage(ProtoDescriptor);
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
            if (protoDescriptor_ == null) {
              ProtoDescriptor = new global::Google.Protobuf.Reflection.DescriptorProto();
            }
            input.ReadMessage(ProtoDescriptor);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ProtoRows : pb::IMessage<ProtoRows>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProtoRows> _parser = new pb::MessageParser<ProtoRows>(() => new ProtoRows());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProtoRows> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.BigQuery.Storage.V1.ProtobufReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoRows() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoRows(ProtoRows other) : this() {
      serializedRows_ = other.serializedRows_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProtoRows Clone() {
      return new ProtoRows(this);
    }

    /// <summary>Field number for the "serialized_rows" field.</summary>
    public const int SerializedRowsFieldNumber = 1;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_serializedRows_codec
        = pb::FieldCodec.ForBytes(10);
    private readonly pbc::RepeatedField<pb::ByteString> serializedRows_ = new pbc::RepeatedField<pb::ByteString>();
    /// <summary>
    /// A sequence of rows serialized as a Protocol Buffer.
    ///
    /// See https://developers.google.com/protocol-buffers/docs/overview for more
    /// information on deserializing this field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<pb::ByteString> SerializedRows {
      get { return serializedRows_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProtoRows);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProtoRows other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!serializedRows_.Equals(other.serializedRows_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= serializedRows_.GetHashCode();
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
      serializedRows_.WriteTo(output, _repeated_serializedRows_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      serializedRows_.WriteTo(ref output, _repeated_serializedRows_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += serializedRows_.CalculateSize(_repeated_serializedRows_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProtoRows other) {
      if (other == null) {
        return;
      }
      serializedRows_.Add(other.serializedRows_);
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
            serializedRows_.AddEntriesFrom(input, _repeated_serializedRows_codec);
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
            serializedRows_.AddEntriesFrom(ref input, _repeated_serializedRows_codec);
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
