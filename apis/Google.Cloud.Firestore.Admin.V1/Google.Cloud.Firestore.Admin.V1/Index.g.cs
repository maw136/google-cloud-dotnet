// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/firestore/admin/v1/index.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Firestore.Admin.V1 {

  /// <summary>Holder for reflection information generated from google/firestore/admin/v1/index.proto</summary>
  public static partial class IndexReflection {

    #region Descriptor
    /// <summary>File descriptor for google/firestore/admin/v1/index.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IndexReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVnb29nbGUvZmlyZXN0b3JlL2FkbWluL3YxL2luZGV4LnByb3RvEhlnb29n",
            "bGUuZmlyZXN0b3JlLmFkbWluLnYxGhlnb29nbGUvYXBpL3Jlc291cmNlLnBy",
            "b3RvIqwHCgVJbmRleBIMCgRuYW1lGAEgASgJEkAKC3F1ZXJ5X3Njb3BlGAIg",
            "ASgOMisuZ29vZ2xlLmZpcmVzdG9yZS5hZG1pbi52MS5JbmRleC5RdWVyeVNj",
            "b3BlEjwKCWFwaV9zY29wZRgFIAEoDjIpLmdvb2dsZS5maXJlc3RvcmUuYWRt",
            "aW4udjEuSW5kZXguQXBpU2NvcGUSOwoGZmllbGRzGAMgAygLMisuZ29vZ2xl",
            "LmZpcmVzdG9yZS5hZG1pbi52MS5JbmRleC5JbmRleEZpZWxkEjUKBXN0YXRl",
            "GAQgASgOMiYuZ29vZ2xlLmZpcmVzdG9yZS5hZG1pbi52MS5JbmRleC5TdGF0",
            "ZRq9AgoKSW5kZXhGaWVsZBISCgpmaWVsZF9wYXRoGAEgASgJEkIKBW9yZGVy",
            "GAIgASgOMjEuZ29vZ2xlLmZpcmVzdG9yZS5hZG1pbi52MS5JbmRleC5JbmRl",
            "eEZpZWxkLk9yZGVySAASTwoMYXJyYXlfY29uZmlnGAMgASgOMjcuZ29vZ2xl",
            "LmZpcmVzdG9yZS5hZG1pbi52MS5JbmRleC5JbmRleEZpZWxkLkFycmF5Q29u",
            "ZmlnSAAiPQoFT3JkZXISFQoRT1JERVJfVU5TUEVDSUZJRUQQABINCglBU0NF",
            "TkRJTkcQARIOCgpERVNDRU5ESU5HEAIiOQoLQXJyYXlDb25maWcSHAoYQVJS",
            "QVlfQ09ORklHX1VOU1BFQ0lGSUVEEAASDAoIQ09OVEFJTlMQAUIMCgp2YWx1",
            "ZV9tb2RlImkKClF1ZXJ5U2NvcGUSGwoXUVVFUllfU0NPUEVfVU5TUEVDSUZJ",
            "RUQQABIOCgpDT0xMRUNUSU9OEAESFAoQQ09MTEVDVElPTl9HUk9VUBACEhgK",
            "FENPTExFQ1RJT05fUkVDVVJTSVZFEAMiLwoIQXBpU2NvcGUSCwoHQU5ZX0FQ",
            "SRAAEhYKEkRBVEFTVE9SRV9NT0RFX0FQSRABIkkKBVN0YXRlEhUKEVNUQVRF",
            "X1VOU1BFQ0lGSUVEEAASDAoIQ1JFQVRJTkcQARIJCgVSRUFEWRACEhAKDE5F",
            "RURTX1JFUEFJUhADOnrqQXcKHmZpcmVzdG9yZS5nb29nbGVhcGlzLmNvbS9J",
            "bmRleBJVcHJvamVjdHMve3Byb2plY3R9L2RhdGFiYXNlcy97ZGF0YWJhc2V9",
            "L2NvbGxlY3Rpb25Hcm91cHMve2NvbGxlY3Rpb259L2luZGV4ZXMve2luZGV4",
            "fULZAQodY29tLmdvb2dsZS5maXJlc3RvcmUuYWRtaW4udjFCCkluZGV4UHJv",
            "dG9QAVo5Y2xvdWQuZ29vZ2xlLmNvbS9nby9maXJlc3RvcmUvYXBpdjEvYWRt",
            "aW4vYWRtaW5wYjthZG1pbnBiogIER0NGU6oCH0dvb2dsZS5DbG91ZC5GaXJl",
            "c3RvcmUuQWRtaW4uVjHKAh9Hb29nbGVcQ2xvdWRcRmlyZXN0b3JlXEFkbWlu",
            "XFYx6gIjR29vZ2xlOjpDbG91ZDo6RmlyZXN0b3JlOjpBZG1pbjo6VjFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Index), global::Google.Cloud.Firestore.Admin.V1.Index.Parser, new[]{ "Name", "QueryScope", "ApiScope", "Fields", "State" }, null, new[]{ typeof(global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope), typeof(global::Google.Cloud.Firestore.Admin.V1.Index.Types.ApiScope), typeof(global::Google.Cloud.Firestore.Admin.V1.Index.Types.State) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField), global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Parser, new[]{ "FieldPath", "Order", "ArrayConfig" }, new[]{ "ValueMode" }, new[]{ typeof(global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.Order), typeof(global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.ArrayConfig) }, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Cloud Firestore indexes enable simple and complex queries against
  /// documents in a database.
  /// </summary>
  public sealed partial class Index : pb::IMessage<Index>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Index> _parser = new pb::MessageParser<Index>(() => new Index());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Index> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Firestore.Admin.V1.IndexReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Index() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Index(Index other) : this() {
      name_ = other.name_;
      queryScope_ = other.queryScope_;
      apiScope_ = other.apiScope_;
      fields_ = other.fields_.Clone();
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Index Clone() {
      return new Index(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. A server defined name for this index.
    /// The form of this name for composite indexes will be:
    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{composite_index_id}`
    /// For single field indexes, this field will be empty.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "query_scope" field.</summary>
    public const int QueryScopeFieldNumber = 2;
    private global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope queryScope_ = global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope.Unspecified;
    /// <summary>
    /// Indexes with a collection query scope specified allow queries
    /// against a collection that is the child of a specific document, specified at
    /// query time, and that has the same collection id.
    ///
    /// Indexes with a collection group query scope specified allow queries against
    /// all collections descended from a specific document, specified at query
    /// time, and that have the same collection id as this index.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope QueryScope {
      get { return queryScope_; }
      set {
        queryScope_ = value;
      }
    }

    /// <summary>Field number for the "api_scope" field.</summary>
    public const int ApiScopeFieldNumber = 5;
    private global::Google.Cloud.Firestore.Admin.V1.Index.Types.ApiScope apiScope_ = global::Google.Cloud.Firestore.Admin.V1.Index.Types.ApiScope.AnyApi;
    /// <summary>
    /// The API scope supported by this index.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Firestore.Admin.V1.Index.Types.ApiScope ApiScope {
      get { return apiScope_; }
      set {
        apiScope_ = value;
      }
    }

    /// <summary>Field number for the "fields" field.</summary>
    public const int FieldsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField> _repeated_fields_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField> fields_ = new pbc::RepeatedField<global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField>();
    /// <summary>
    /// The fields supported by this index.
    ///
    /// For composite indexes, this requires a minimum of 2 and a maximum of 100
    /// fields. The last field entry is always for the field path `__name__`. If,
    /// on creation, `__name__` was not specified as the last field, it will be
    /// added automatically with the same direction as that of the last field
    /// defined. If the final field in a composite index is not directional, the
    /// `__name__` will be ordered ASCENDING (unless explicitly specified).
    ///
    /// For single field indexes, this will always be exactly one entry with a
    /// field path equal to the field path of the associated field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField> Fields {
      get { return fields_; }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private global::Google.Cloud.Firestore.Admin.V1.Index.Types.State state_ = global::Google.Cloud.Firestore.Admin.V1.Index.Types.State.Unspecified;
    /// <summary>
    /// Output only. The serving state of the index.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Firestore.Admin.V1.Index.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Index);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Index other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (QueryScope != other.QueryScope) return false;
      if (ApiScope != other.ApiScope) return false;
      if(!fields_.Equals(other.fields_)) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (QueryScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope.Unspecified) hash ^= QueryScope.GetHashCode();
      if (ApiScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.ApiScope.AnyApi) hash ^= ApiScope.GetHashCode();
      hash ^= fields_.GetHashCode();
      if (State != global::Google.Cloud.Firestore.Admin.V1.Index.Types.State.Unspecified) hash ^= State.GetHashCode();
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
      if (QueryScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) QueryScope);
      }
      fields_.WriteTo(output, _repeated_fields_codec);
      if (State != global::Google.Cloud.Firestore.Admin.V1.Index.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      if (ApiScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.ApiScope.AnyApi) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ApiScope);
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
      if (QueryScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) QueryScope);
      }
      fields_.WriteTo(ref output, _repeated_fields_codec);
      if (State != global::Google.Cloud.Firestore.Admin.V1.Index.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      if (ApiScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.ApiScope.AnyApi) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ApiScope);
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
      if (QueryScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) QueryScope);
      }
      if (ApiScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.ApiScope.AnyApi) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ApiScope);
      }
      size += fields_.CalculateSize(_repeated_fields_codec);
      if (State != global::Google.Cloud.Firestore.Admin.V1.Index.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Index other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.QueryScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope.Unspecified) {
        QueryScope = other.QueryScope;
      }
      if (other.ApiScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.ApiScope.AnyApi) {
        ApiScope = other.ApiScope;
      }
      fields_.Add(other.fields_);
      if (other.State != global::Google.Cloud.Firestore.Admin.V1.Index.Types.State.Unspecified) {
        State = other.State;
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
            QueryScope = (global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope) input.ReadEnum();
            break;
          }
          case 26: {
            fields_.AddEntriesFrom(input, _repeated_fields_codec);
            break;
          }
          case 32: {
            State = (global::Google.Cloud.Firestore.Admin.V1.Index.Types.State) input.ReadEnum();
            break;
          }
          case 40: {
            ApiScope = (global::Google.Cloud.Firestore.Admin.V1.Index.Types.ApiScope) input.ReadEnum();
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
            QueryScope = (global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope) input.ReadEnum();
            break;
          }
          case 26: {
            fields_.AddEntriesFrom(ref input, _repeated_fields_codec);
            break;
          }
          case 32: {
            State = (global::Google.Cloud.Firestore.Admin.V1.Index.Types.State) input.ReadEnum();
            break;
          }
          case 40: {
            ApiScope = (global::Google.Cloud.Firestore.Admin.V1.Index.Types.ApiScope) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Index message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Query Scope defines the scope at which a query is run. This is specified on
      /// a StructuredQuery's `from` field.
      /// </summary>
      public enum QueryScope {
        /// <summary>
        /// The query scope is unspecified. Not a valid option.
        /// </summary>
        [pbr::OriginalName("QUERY_SCOPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Indexes with a collection query scope specified allow queries
        /// against a collection that is the child of a specific document, specified
        /// at query time, and that has the collection id specified by the index.
        /// </summary>
        [pbr::OriginalName("COLLECTION")] Collection = 1,
        /// <summary>
        /// Indexes with a collection group query scope specified allow queries
        /// against all collections that has the collection id specified by the
        /// index.
        /// </summary>
        [pbr::OriginalName("COLLECTION_GROUP")] CollectionGroup = 2,
        /// <summary>
        /// Include all the collections's ancestor in the index. Only available for
        /// Datastore Mode databases.
        /// </summary>
        [pbr::OriginalName("COLLECTION_RECURSIVE")] CollectionRecursive = 3,
      }

      /// <summary>
      /// API Scope defines the APIs (Firestore Native, or Firestore in
      /// Datastore Mode) that are supported for queries.
      /// </summary>
      public enum ApiScope {
        /// <summary>
        /// The index can only be used by the Firestore Native query API.
        /// This is the default.
        /// </summary>
        [pbr::OriginalName("ANY_API")] AnyApi = 0,
        /// <summary>
        /// The index can only be used by the Firestore in Datastore Mode query API.
        /// </summary>
        [pbr::OriginalName("DATASTORE_MODE_API")] DatastoreModeApi = 1,
      }

      /// <summary>
      /// The state of an index. During index creation, an index will be in the
      /// `CREATING` state. If the index is created successfully, it will transition
      /// to the `READY` state. If the index creation encounters a problem, the index
      /// will transition to the `NEEDS_REPAIR` state.
      /// </summary>
      public enum State {
        /// <summary>
        /// The state is unspecified.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The index is being created.
        /// There is an active long-running operation for the index.
        /// The index is updated when writing a document.
        /// Some index data may exist.
        /// </summary>
        [pbr::OriginalName("CREATING")] Creating = 1,
        /// <summary>
        /// The index is ready to be used.
        /// The index is updated when writing a document.
        /// The index is fully populated from all stored documents it applies to.
        /// </summary>
        [pbr::OriginalName("READY")] Ready = 2,
        /// <summary>
        /// The index was being created, but something went wrong.
        /// There is no active long-running operation for the index,
        /// and the most recently finished long-running operation failed.
        /// The index is not updated when writing a document.
        /// Some index data may exist.
        /// Use the google.longrunning.Operations API to determine why the operation
        /// that last attempted to create this index failed, then re-create the
        /// index.
        /// </summary>
        [pbr::OriginalName("NEEDS_REPAIR")] NeedsRepair = 3,
      }

      /// <summary>
      /// A field in an index.
      /// The field_path describes which field is indexed, the value_mode describes
      /// how the field value is indexed.
      /// </summary>
      public sealed partial class IndexField : pb::IMessage<IndexField>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<IndexField> _parser = new pb::MessageParser<IndexField>(() => new IndexField());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<IndexField> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Firestore.Admin.V1.Index.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public IndexField() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public IndexField(IndexField other) : this() {
          fieldPath_ = other.fieldPath_;
          switch (other.ValueModeCase) {
            case ValueModeOneofCase.Order:
              Order = other.Order;
              break;
            case ValueModeOneofCase.ArrayConfig:
              ArrayConfig = other.ArrayConfig;
              break;
          }

          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public IndexField Clone() {
          return new IndexField(this);
        }

        /// <summary>Field number for the "field_path" field.</summary>
        public const int FieldPathFieldNumber = 1;
        private string fieldPath_ = "";
        /// <summary>
        /// Can be __name__.
        /// For single field indexes, this must match the name of the field or may
        /// be omitted.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string FieldPath {
          get { return fieldPath_; }
          set {
            fieldPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "order" field.</summary>
        public const int OrderFieldNumber = 2;
        /// <summary>
        /// Indicates that this field supports ordering by the specified order or
        /// comparing using =, !=, &lt;, &lt;=, >, >=.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.Order Order {
          get { return HasOrder ? (global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.Order) valueMode_ : global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.Order.Unspecified; }
          set {
            valueMode_ = value;
            valueModeCase_ = ValueModeOneofCase.Order;
          }
        }
        /// <summary>Gets whether the "order" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasOrder {
          get { return valueModeCase_ == ValueModeOneofCase.Order; }
        }
        /// <summary> Clears the value of the oneof if it's currently set to "order" </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearOrder() {
          if (HasOrder) {
            ClearValueMode();
          }
        }

        /// <summary>Field number for the "array_config" field.</summary>
        public const int ArrayConfigFieldNumber = 3;
        /// <summary>
        /// Indicates that this field supports operations on `array_value`s.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.ArrayConfig ArrayConfig {
          get { return HasArrayConfig ? (global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.ArrayConfig) valueMode_ : global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.ArrayConfig.Unspecified; }
          set {
            valueMode_ = value;
            valueModeCase_ = ValueModeOneofCase.ArrayConfig;
          }
        }
        /// <summary>Gets whether the "array_config" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasArrayConfig {
          get { return valueModeCase_ == ValueModeOneofCase.ArrayConfig; }
        }
        /// <summary> Clears the value of the oneof if it's currently set to "array_config" </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearArrayConfig() {
          if (HasArrayConfig) {
            ClearValueMode();
          }
        }

        private object valueMode_;
        /// <summary>Enum of possible cases for the "value_mode" oneof.</summary>
        public enum ValueModeOneofCase {
          None = 0,
          Order = 2,
          ArrayConfig = 3,
        }
        private ValueModeOneofCase valueModeCase_ = ValueModeOneofCase.None;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ValueModeOneofCase ValueModeCase {
          get { return valueModeCase_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearValueMode() {
          valueModeCase_ = ValueModeOneofCase.None;
          valueMode_ = null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as IndexField);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(IndexField other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (FieldPath != other.FieldPath) return false;
          if (Order != other.Order) return false;
          if (ArrayConfig != other.ArrayConfig) return false;
          if (ValueModeCase != other.ValueModeCase) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (FieldPath.Length != 0) hash ^= FieldPath.GetHashCode();
          if (HasOrder) hash ^= Order.GetHashCode();
          if (HasArrayConfig) hash ^= ArrayConfig.GetHashCode();
          hash ^= (int) valueModeCase_;
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
          if (FieldPath.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(FieldPath);
          }
          if (HasOrder) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Order);
          }
          if (HasArrayConfig) {
            output.WriteRawTag(24);
            output.WriteEnum((int) ArrayConfig);
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
          if (FieldPath.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(FieldPath);
          }
          if (HasOrder) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Order);
          }
          if (HasArrayConfig) {
            output.WriteRawTag(24);
            output.WriteEnum((int) ArrayConfig);
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
          if (FieldPath.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(FieldPath);
          }
          if (HasOrder) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Order);
          }
          if (HasArrayConfig) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ArrayConfig);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(IndexField other) {
          if (other == null) {
            return;
          }
          if (other.FieldPath.Length != 0) {
            FieldPath = other.FieldPath;
          }
          switch (other.ValueModeCase) {
            case ValueModeOneofCase.Order:
              Order = other.Order;
              break;
            case ValueModeOneofCase.ArrayConfig:
              ArrayConfig = other.ArrayConfig;
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
                FieldPath = input.ReadString();
                break;
              }
              case 16: {
                valueMode_ = input.ReadEnum();
                valueModeCase_ = ValueModeOneofCase.Order;
                break;
              }
              case 24: {
                valueMode_ = input.ReadEnum();
                valueModeCase_ = ValueModeOneofCase.ArrayConfig;
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
                FieldPath = input.ReadString();
                break;
              }
              case 16: {
                valueMode_ = input.ReadEnum();
                valueModeCase_ = ValueModeOneofCase.Order;
                break;
              }
              case 24: {
                valueMode_ = input.ReadEnum();
                valueModeCase_ = ValueModeOneofCase.ArrayConfig;
                break;
              }
            }
          }
        }
        #endif

        #region Nested types
        /// <summary>Container for nested types declared in the IndexField message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types {
          /// <summary>
          /// The supported orderings.
          /// </summary>
          public enum Order {
            /// <summary>
            /// The ordering is unspecified. Not a valid option.
            /// </summary>
            [pbr::OriginalName("ORDER_UNSPECIFIED")] Unspecified = 0,
            /// <summary>
            /// The field is ordered by ascending field value.
            /// </summary>
            [pbr::OriginalName("ASCENDING")] Ascending = 1,
            /// <summary>
            /// The field is ordered by descending field value.
            /// </summary>
            [pbr::OriginalName("DESCENDING")] Descending = 2,
          }

          /// <summary>
          /// The supported array value configurations.
          /// </summary>
          public enum ArrayConfig {
            /// <summary>
            /// The index does not support additional array queries.
            /// </summary>
            [pbr::OriginalName("ARRAY_CONFIG_UNSPECIFIED")] Unspecified = 0,
            /// <summary>
            /// The index supports array containment queries.
            /// </summary>
            [pbr::OriginalName("CONTAINS")] Contains = 1,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
