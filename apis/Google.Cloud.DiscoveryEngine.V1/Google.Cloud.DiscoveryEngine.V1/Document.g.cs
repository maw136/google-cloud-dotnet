// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/discoveryengine/v1/document.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DiscoveryEngine.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/discoveryengine/v1/document.proto</summary>
  public static partial class DocumentReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/discoveryengine/v1/document.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DocumentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvY2xvdWQvZGlzY292ZXJ5ZW5naW5lL3YxL2RvY3VtZW50LnBy",
            "b3RvEh9nb29nbGUuY2xvdWQuZGlzY292ZXJ5ZW5naW5lLnYxGh9nb29nbGUv",
            "YXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNl",
            "LnByb3RvGhxnb29nbGUvcHJvdG9idWYvc3RydWN0LnByb3RvIo8FCghEb2N1",
            "bWVudBIuCgtzdHJ1Y3RfZGF0YRgEIAEoCzIXLmdvb2dsZS5wcm90b2J1Zi5T",
            "dHJ1Y3RIABITCglqc29uX2RhdGEYBSABKAlIABIRCgRuYW1lGAEgASgJQgPg",
            "QQUSDwoCaWQYAiABKAlCA+BBBRIRCglzY2hlbWFfaWQYAyABKAkSQgoHY29u",
            "dGVudBgKIAEoCzIxLmdvb2dsZS5jbG91ZC5kaXNjb3ZlcnllbmdpbmUudjEu",
            "RG9jdW1lbnQuQ29udGVudBIaChJwYXJlbnRfZG9jdW1lbnRfaWQYByABKAkS",
            "OQoTZGVyaXZlZF9zdHJ1Y3RfZGF0YRgGIAEoCzIXLmdvb2dsZS5wcm90b2J1",
            "Zi5TdHJ1Y3RCA+BBAxpLCgdDb250ZW50EhMKCXJhd19ieXRlcxgCIAEoDEgA",
            "Eg0KA3VyaRgDIAEoCUgAEhEKCW1pbWVfdHlwZRgBIAEoCUIJCgdjb250ZW50",
            "OpYC6kGSAgonZGlzY292ZXJ5ZW5naW5lLmdvb2dsZWFwaXMuY29tL0RvY3Vt",
            "ZW50EmZwcm9qZWN0cy97cHJvamVjdH0vbG9jYXRpb25zL3tsb2NhdGlvbn0v",
            "ZGF0YVN0b3Jlcy97ZGF0YV9zdG9yZX0vYnJhbmNoZXMve2JyYW5jaH0vZG9j",
            "dW1lbnRzL3tkb2N1bWVudH0Sf3Byb2plY3RzL3twcm9qZWN0fS9sb2NhdGlv",
            "bnMve2xvY2F0aW9ufS9jb2xsZWN0aW9ucy97Y29sbGVjdGlvbn0vZGF0YVN0",
            "b3Jlcy97ZGF0YV9zdG9yZX0vYnJhbmNoZXMve2JyYW5jaH0vZG9jdW1lbnRz",
            "L3tkb2N1bWVudH1CBgoEZGF0YUKAAgojY29tLmdvb2dsZS5jbG91ZC5kaXNj",
            "b3ZlcnllbmdpbmUudjFCDURvY3VtZW50UHJvdG9QAVpNY2xvdWQuZ29vZ2xl",
            "LmNvbS9nby9kaXNjb3ZlcnllbmdpbmUvYXBpdjEvZGlzY292ZXJ5ZW5naW5l",
            "cGI7ZGlzY292ZXJ5ZW5naW5lcGKiAg9ESVNDT1ZFUllFTkdJTkWqAh9Hb29n",
            "bGUuQ2xvdWQuRGlzY292ZXJ5RW5naW5lLlYxygIfR29vZ2xlXENsb3VkXERp",
            "c2NvdmVyeUVuZ2luZVxWMeoCIkdvb2dsZTo6Q2xvdWQ6OkRpc2NvdmVyeUVu",
            "Z2luZTo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DiscoveryEngine.V1.Document), global::Google.Cloud.DiscoveryEngine.V1.Document.Parser, new[]{ "StructData", "JsonData", "Name", "Id", "SchemaId", "Content", "ParentDocumentId", "DerivedStructData" }, new[]{ "Data" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DiscoveryEngine.V1.Document.Types.Content), global::Google.Cloud.DiscoveryEngine.V1.Document.Types.Content.Parser, new[]{ "RawBytes", "Uri", "MimeType" }, new[]{ "Content" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Document captures all raw metadata information of items to be recommended or
  /// searched.
  /// </summary>
  public sealed partial class Document : pb::IMessage<Document>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Document> _parser = new pb::MessageParser<Document>(() => new Document());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Document> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DiscoveryEngine.V1.DocumentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Document() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Document(Document other) : this() {
      name_ = other.name_;
      id_ = other.id_;
      schemaId_ = other.schemaId_;
      content_ = other.content_ != null ? other.content_.Clone() : null;
      parentDocumentId_ = other.parentDocumentId_;
      derivedStructData_ = other.derivedStructData_ != null ? other.derivedStructData_.Clone() : null;
      switch (other.DataCase) {
        case DataOneofCase.StructData:
          StructData = other.StructData.Clone();
          break;
        case DataOneofCase.JsonData:
          JsonData = other.JsonData;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Document Clone() {
      return new Document(this);
    }

    /// <summary>Field number for the "struct_data" field.</summary>
    public const int StructDataFieldNumber = 4;
    /// <summary>
    /// The structured JSON data for the document. It should conform to the
    /// registered [Schema.schema][google.cloud.discoveryengine.v1.Schema.schema]
    /// or an `INVALID_ARGUMENT` error is thrown.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Struct StructData {
      get { return dataCase_ == DataOneofCase.StructData ? (global::Google.Protobuf.WellKnownTypes.Struct) data_ : null; }
      set {
        data_ = value;
        dataCase_ = value == null ? DataOneofCase.None : DataOneofCase.StructData;
      }
    }

    /// <summary>Field number for the "json_data" field.</summary>
    public const int JsonDataFieldNumber = 5;
    /// <summary>
    /// The JSON string representation of the document. It should conform to the
    /// registered [Schema.schema][google.cloud.discoveryengine.v1.Schema.schema]
    /// or an `INVALID_ARGUMENT` error is thrown.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JsonData {
      get { return HasJsonData ? (string) data_ : ""; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        dataCase_ = DataOneofCase.JsonData;
      }
    }
    /// <summary>Gets whether the "json_data" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasJsonData {
      get { return dataCase_ == DataOneofCase.JsonData; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "json_data" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearJsonData() {
      if (HasJsonData) {
        ClearData();
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Immutable. The full resource name of the document.
    /// Format:
    /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document_id}`.
    ///
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    /// <summary>
    /// Immutable. The identifier of the document.
    ///
    /// Id should conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
    /// standard with a length limit of 63 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "schema_id" field.</summary>
    public const int SchemaIdFieldNumber = 3;
    private string schemaId_ = "";
    /// <summary>
    /// The identifier of the schema located in the same data store.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SchemaId {
      get { return schemaId_; }
      set {
        schemaId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 10;
    private global::Google.Cloud.DiscoveryEngine.V1.Document.Types.Content content_;
    /// <summary>
    /// The unstructured data linked to this document. Content must be set if this
    /// document is under a
    /// `CONTENT_REQUIRED` data store.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DiscoveryEngine.V1.Document.Types.Content Content {
      get { return content_; }
      set {
        content_ = value;
      }
    }

    /// <summary>Field number for the "parent_document_id" field.</summary>
    public const int ParentDocumentIdFieldNumber = 7;
    private string parentDocumentId_ = "";
    /// <summary>
    /// The identifier of the parent document. Currently supports at most two level
    /// document hierarchy.
    ///
    /// Id should conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
    /// standard with a length limit of 63 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ParentDocumentId {
      get { return parentDocumentId_; }
      set {
        parentDocumentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "derived_struct_data" field.</summary>
    public const int DerivedStructDataFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Struct derivedStructData_;
    /// <summary>
    /// Output only. This field is OUTPUT_ONLY.
    /// It contains derived data that are not in the original input document.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Struct DerivedStructData {
      get { return derivedStructData_; }
      set {
        derivedStructData_ = value;
      }
    }

    private object data_;
    /// <summary>Enum of possible cases for the "data" oneof.</summary>
    public enum DataOneofCase {
      None = 0,
      StructData = 4,
      JsonData = 5,
    }
    private DataOneofCase dataCase_ = DataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataOneofCase DataCase {
      get { return dataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearData() {
      dataCase_ = DataOneofCase.None;
      data_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Document);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Document other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(StructData, other.StructData)) return false;
      if (JsonData != other.JsonData) return false;
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (SchemaId != other.SchemaId) return false;
      if (!object.Equals(Content, other.Content)) return false;
      if (ParentDocumentId != other.ParentDocumentId) return false;
      if (!object.Equals(DerivedStructData, other.DerivedStructData)) return false;
      if (DataCase != other.DataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (dataCase_ == DataOneofCase.StructData) hash ^= StructData.GetHashCode();
      if (HasJsonData) hash ^= JsonData.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (SchemaId.Length != 0) hash ^= SchemaId.GetHashCode();
      if (content_ != null) hash ^= Content.GetHashCode();
      if (ParentDocumentId.Length != 0) hash ^= ParentDocumentId.GetHashCode();
      if (derivedStructData_ != null) hash ^= DerivedStructData.GetHashCode();
      hash ^= (int) dataCase_;
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
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (SchemaId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SchemaId);
      }
      if (dataCase_ == DataOneofCase.StructData) {
        output.WriteRawTag(34);
        output.WriteMessage(StructData);
      }
      if (HasJsonData) {
        output.WriteRawTag(42);
        output.WriteString(JsonData);
      }
      if (derivedStructData_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(DerivedStructData);
      }
      if (ParentDocumentId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ParentDocumentId);
      }
      if (content_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Content);
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
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (SchemaId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SchemaId);
      }
      if (dataCase_ == DataOneofCase.StructData) {
        output.WriteRawTag(34);
        output.WriteMessage(StructData);
      }
      if (HasJsonData) {
        output.WriteRawTag(42);
        output.WriteString(JsonData);
      }
      if (derivedStructData_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(DerivedStructData);
      }
      if (ParentDocumentId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ParentDocumentId);
      }
      if (content_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Content);
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
      if (dataCase_ == DataOneofCase.StructData) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StructData);
      }
      if (HasJsonData) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JsonData);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (SchemaId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SchemaId);
      }
      if (content_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Content);
      }
      if (ParentDocumentId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ParentDocumentId);
      }
      if (derivedStructData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DerivedStructData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Document other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.SchemaId.Length != 0) {
        SchemaId = other.SchemaId;
      }
      if (other.content_ != null) {
        if (content_ == null) {
          Content = new global::Google.Cloud.DiscoveryEngine.V1.Document.Types.Content();
        }
        Content.MergeFrom(other.Content);
      }
      if (other.ParentDocumentId.Length != 0) {
        ParentDocumentId = other.ParentDocumentId;
      }
      if (other.derivedStructData_ != null) {
        if (derivedStructData_ == null) {
          DerivedStructData = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        DerivedStructData.MergeFrom(other.DerivedStructData);
      }
      switch (other.DataCase) {
        case DataOneofCase.StructData:
          if (StructData == null) {
            StructData = new global::Google.Protobuf.WellKnownTypes.Struct();
          }
          StructData.MergeFrom(other.StructData);
          break;
        case DataOneofCase.JsonData:
          JsonData = other.JsonData;
          break;
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
            Id = input.ReadString();
            break;
          }
          case 26: {
            SchemaId = input.ReadString();
            break;
          }
          case 34: {
            global::Google.Protobuf.WellKnownTypes.Struct subBuilder = new global::Google.Protobuf.WellKnownTypes.Struct();
            if (dataCase_ == DataOneofCase.StructData) {
              subBuilder.MergeFrom(StructData);
            }
            input.ReadMessage(subBuilder);
            StructData = subBuilder;
            break;
          }
          case 42: {
            JsonData = input.ReadString();
            break;
          }
          case 50: {
            if (derivedStructData_ == null) {
              DerivedStructData = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(DerivedStructData);
            break;
          }
          case 58: {
            ParentDocumentId = input.ReadString();
            break;
          }
          case 82: {
            if (content_ == null) {
              Content = new global::Google.Cloud.DiscoveryEngine.V1.Document.Types.Content();
            }
            input.ReadMessage(Content);
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
            Id = input.ReadString();
            break;
          }
          case 26: {
            SchemaId = input.ReadString();
            break;
          }
          case 34: {
            global::Google.Protobuf.WellKnownTypes.Struct subBuilder = new global::Google.Protobuf.WellKnownTypes.Struct();
            if (dataCase_ == DataOneofCase.StructData) {
              subBuilder.MergeFrom(StructData);
            }
            input.ReadMessage(subBuilder);
            StructData = subBuilder;
            break;
          }
          case 42: {
            JsonData = input.ReadString();
            break;
          }
          case 50: {
            if (derivedStructData_ == null) {
              DerivedStructData = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(DerivedStructData);
            break;
          }
          case 58: {
            ParentDocumentId = input.ReadString();
            break;
          }
          case 82: {
            if (content_ == null) {
              Content = new global::Google.Cloud.DiscoveryEngine.V1.Document.Types.Content();
            }
            input.ReadMessage(Content);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Document message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Unstructured data linked to this document.
      /// </summary>
      public sealed partial class Content : pb::IMessage<Content>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Content> _parser = new pb::MessageParser<Content>(() => new Content());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Content> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.DiscoveryEngine.V1.Document.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Content() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Content(Content other) : this() {
          mimeType_ = other.mimeType_;
          switch (other.ContentCase) {
            case ContentOneofCase.RawBytes:
              RawBytes = other.RawBytes;
              break;
            case ContentOneofCase.Uri:
              Uri = other.Uri;
              break;
          }

          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Content Clone() {
          return new Content(this);
        }

        /// <summary>Field number for the "raw_bytes" field.</summary>
        public const int RawBytesFieldNumber = 2;
        /// <summary>
        /// The content represented as a stream of bytes. The maximum length is
        /// 1,000,000 bytes (1 MB / ~0.95 MiB).
        ///
        /// Note: As with all `bytes` fields, this field is represented as pure
        /// binary in Protocol Buffers and base64-encoded string in JSON. For
        /// example, `abc123!?$*&amp;()'-=@~` should be represented as
        /// `YWJjMTIzIT8kKiYoKSctPUB+` in JSON. See
        /// https://developers.google.com/protocol-buffers/docs/proto3#json.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pb::ByteString RawBytes {
          get { return HasRawBytes ? (pb::ByteString) content_ : pb::ByteString.Empty; }
          set {
            content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            contentCase_ = ContentOneofCase.RawBytes;
          }
        }
        /// <summary>Gets whether the "raw_bytes" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasRawBytes {
          get { return contentCase_ == ContentOneofCase.RawBytes; }
        }
        /// <summary> Clears the value of the oneof if it's currently set to "raw_bytes" </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearRawBytes() {
          if (HasRawBytes) {
            ClearContent();
          }
        }

        /// <summary>Field number for the "uri" field.</summary>
        public const int UriFieldNumber = 3;
        /// <summary>
        /// The URI of the content. Only Cloud Storage URIs (e.g.
        /// `gs://bucket-name/path/to/file`) are supported. The maximum file size
        /// is 100 MB.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Uri {
          get { return HasUri ? (string) content_ : ""; }
          set {
            content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            contentCase_ = ContentOneofCase.Uri;
          }
        }
        /// <summary>Gets whether the "uri" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasUri {
          get { return contentCase_ == ContentOneofCase.Uri; }
        }
        /// <summary> Clears the value of the oneof if it's currently set to "uri" </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearUri() {
          if (HasUri) {
            ClearContent();
          }
        }

        /// <summary>Field number for the "mime_type" field.</summary>
        public const int MimeTypeFieldNumber = 1;
        private string mimeType_ = "";
        /// <summary>
        /// The MIME type of the content. Supported types:
        ///
        /// * `application/pdf` (PDF)
        /// * `text/html` (HTML)
        ///
        /// See https://www.iana.org/assignments/media-types/media-types.xhtml.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string MimeType {
          get { return mimeType_; }
          set {
            mimeType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        private object content_;
        /// <summary>Enum of possible cases for the "content" oneof.</summary>
        public enum ContentOneofCase {
          None = 0,
          RawBytes = 2,
          Uri = 3,
        }
        private ContentOneofCase contentCase_ = ContentOneofCase.None;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ContentOneofCase ContentCase {
          get { return contentCase_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearContent() {
          contentCase_ = ContentOneofCase.None;
          content_ = null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Content);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Content other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (RawBytes != other.RawBytes) return false;
          if (Uri != other.Uri) return false;
          if (MimeType != other.MimeType) return false;
          if (ContentCase != other.ContentCase) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (HasRawBytes) hash ^= RawBytes.GetHashCode();
          if (HasUri) hash ^= Uri.GetHashCode();
          if (MimeType.Length != 0) hash ^= MimeType.GetHashCode();
          hash ^= (int) contentCase_;
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
          if (MimeType.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(MimeType);
          }
          if (HasRawBytes) {
            output.WriteRawTag(18);
            output.WriteBytes(RawBytes);
          }
          if (HasUri) {
            output.WriteRawTag(26);
            output.WriteString(Uri);
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
          if (MimeType.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(MimeType);
          }
          if (HasRawBytes) {
            output.WriteRawTag(18);
            output.WriteBytes(RawBytes);
          }
          if (HasUri) {
            output.WriteRawTag(26);
            output.WriteString(Uri);
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
          if (HasRawBytes) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(RawBytes);
          }
          if (HasUri) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
          }
          if (MimeType.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(MimeType);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Content other) {
          if (other == null) {
            return;
          }
          if (other.MimeType.Length != 0) {
            MimeType = other.MimeType;
          }
          switch (other.ContentCase) {
            case ContentOneofCase.RawBytes:
              RawBytes = other.RawBytes;
              break;
            case ContentOneofCase.Uri:
              Uri = other.Uri;
              break;
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
                MimeType = input.ReadString();
                break;
              }
              case 18: {
                RawBytes = input.ReadBytes();
                break;
              }
              case 26: {
                Uri = input.ReadString();
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
                MimeType = input.ReadString();
                break;
              }
              case 18: {
                RawBytes = input.ReadBytes();
                break;
              }
              case 26: {
                Uri = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
