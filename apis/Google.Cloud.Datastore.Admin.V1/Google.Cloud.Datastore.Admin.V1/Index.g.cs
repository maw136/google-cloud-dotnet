// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/datastore/admin/v1/index.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Datastore.Admin.V1 {

  /// <summary>Holder for reflection information generated from google/datastore/admin/v1/index.proto</summary>
  public static partial class IndexReflection {

    #region Descriptor
    /// <summary>File descriptor for google/datastore/admin/v1/index.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IndexReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVnb29nbGUvZGF0YXN0b3JlL2FkbWluL3YxL2luZGV4LnByb3RvEhlnb29n",
            "bGUuZGF0YXN0b3JlLmFkbWluLnYxGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2",
            "aW9yLnByb3RvIuYECgVJbmRleBIXCgpwcm9qZWN0X2lkGAEgASgJQgPgQQMS",
            "FQoIaW5kZXhfaWQYAyABKAlCA+BBAxIRCgRraW5kGAQgASgJQgPgQQISRAoI",
            "YW5jZXN0b3IYBSABKA4yLS5nb29nbGUuZGF0YXN0b3JlLmFkbWluLnYxLklu",
            "ZGV4LkFuY2VzdG9yTW9kZUID4EECEkkKCnByb3BlcnRpZXMYBiADKAsyMC5n",
            "b29nbGUuZGF0YXN0b3JlLmFkbWluLnYxLkluZGV4LkluZGV4ZWRQcm9wZXJ0",
            "eUID4EECEjoKBXN0YXRlGAcgASgOMiYuZ29vZ2xlLmRhdGFzdG9yZS5hZG1p",
            "bi52MS5JbmRleC5TdGF0ZUID4EEDGmgKD0luZGV4ZWRQcm9wZXJ0eRIRCgRu",
            "YW1lGAEgASgJQgPgQQISQgoJZGlyZWN0aW9uGAIgASgOMiouZ29vZ2xlLmRh",
            "dGFzdG9yZS5hZG1pbi52MS5JbmRleC5EaXJlY3Rpb25CA+BBAiJKCgxBbmNl",
            "c3Rvck1vZGUSHQoZQU5DRVNUT1JfTU9ERV9VTlNQRUNJRklFRBAAEggKBE5P",
            "TkUQARIRCg1BTExfQU5DRVNUT1JTEAIiRQoJRGlyZWN0aW9uEhkKFURJUkVD",
            "VElPTl9VTlNQRUNJRklFRBAAEg0KCUFTQ0VORElORxABEg4KCkRFU0NFTkRJ",
            "TkcQAiJQCgVTdGF0ZRIVChFTVEFURV9VTlNQRUNJRklFRBAAEgwKCENSRUFU",
            "SU5HEAESCQoFUkVBRFkQAhIMCghERUxFVElORxADEgkKBUVSUk9SEARC0gEK",
            "HWNvbS5nb29nbGUuZGF0YXN0b3JlLmFkbWluLnYxQgpJbmRleFByb3RvUAFa",
            "OWNsb3VkLmdvb2dsZS5jb20vZ28vZGF0YXN0b3JlL2FkbWluL2FwaXYxL2Fk",
            "bWlucGI7YWRtaW5wYqoCH0dvb2dsZS5DbG91ZC5EYXRhc3RvcmUuQWRtaW4u",
            "VjHKAh9Hb29nbGVcQ2xvdWRcRGF0YXN0b3JlXEFkbWluXFYx6gIjR29vZ2xl",
            "OjpDbG91ZDo6RGF0YXN0b3JlOjpBZG1pbjo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Datastore.Admin.V1.Index), global::Google.Cloud.Datastore.Admin.V1.Index.Parser, new[]{ "ProjectId", "IndexId", "Kind", "Ancestor", "Properties", "State" }, null, new[]{ typeof(global::Google.Cloud.Datastore.Admin.V1.Index.Types.AncestorMode), typeof(global::Google.Cloud.Datastore.Admin.V1.Index.Types.Direction), typeof(global::Google.Cloud.Datastore.Admin.V1.Index.Types.State) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Datastore.Admin.V1.Index.Types.IndexedProperty), global::Google.Cloud.Datastore.Admin.V1.Index.Types.IndexedProperty.Parser, new[]{ "Name", "Direction" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Datastore composite index definition.
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
      get { return global::Google.Cloud.Datastore.Admin.V1.IndexReflection.Descriptor.MessageTypes[0]; }
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
      projectId_ = other.projectId_;
      indexId_ = other.indexId_;
      kind_ = other.kind_;
      ancestor_ = other.ancestor_;
      properties_ = other.properties_.Clone();
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Index Clone() {
      return new Index(this);
    }

    /// <summary>Field number for the "project_id" field.</summary>
    public const int ProjectIdFieldNumber = 1;
    private string projectId_ = "";
    /// <summary>
    /// Output only. Project ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProjectId {
      get { return projectId_; }
      set {
        projectId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "index_id" field.</summary>
    public const int IndexIdFieldNumber = 3;
    private string indexId_ = "";
    /// <summary>
    /// Output only. The resource ID of the index.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IndexId {
      get { return indexId_; }
      set {
        indexId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "kind" field.</summary>
    public const int KindFieldNumber = 4;
    private string kind_ = "";
    /// <summary>
    /// Required. The entity kind to which this index applies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Kind {
      get { return kind_; }
      set {
        kind_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ancestor" field.</summary>
    public const int AncestorFieldNumber = 5;
    private global::Google.Cloud.Datastore.Admin.V1.Index.Types.AncestorMode ancestor_ = global::Google.Cloud.Datastore.Admin.V1.Index.Types.AncestorMode.Unspecified;
    /// <summary>
    /// Required. The index's ancestor mode.  Must not be
    /// ANCESTOR_MODE_UNSPECIFIED.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Datastore.Admin.V1.Index.Types.AncestorMode Ancestor {
      get { return ancestor_; }
      set {
        ancestor_ = value;
      }
    }

    /// <summary>Field number for the "properties" field.</summary>
    public const int PropertiesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Cloud.Datastore.Admin.V1.Index.Types.IndexedProperty> _repeated_properties_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Cloud.Datastore.Admin.V1.Index.Types.IndexedProperty.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Datastore.Admin.V1.Index.Types.IndexedProperty> properties_ = new pbc::RepeatedField<global::Google.Cloud.Datastore.Admin.V1.Index.Types.IndexedProperty>();
    /// <summary>
    /// Required. An ordered sequence of property names and their index attributes.
    ///
    /// Requires:
    ///
    /// * A maximum of 100 properties.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.Datastore.Admin.V1.Index.Types.IndexedProperty> Properties {
      get { return properties_; }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 7;
    private global::Google.Cloud.Datastore.Admin.V1.Index.Types.State state_ = global::Google.Cloud.Datastore.Admin.V1.Index.Types.State.Unspecified;
    /// <summary>
    /// Output only. The state of the index.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Datastore.Admin.V1.Index.Types.State State {
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
      if (ProjectId != other.ProjectId) return false;
      if (IndexId != other.IndexId) return false;
      if (Kind != other.Kind) return false;
      if (Ancestor != other.Ancestor) return false;
      if(!properties_.Equals(other.properties_)) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ProjectId.Length != 0) hash ^= ProjectId.GetHashCode();
      if (IndexId.Length != 0) hash ^= IndexId.GetHashCode();
      if (Kind.Length != 0) hash ^= Kind.GetHashCode();
      if (Ancestor != global::Google.Cloud.Datastore.Admin.V1.Index.Types.AncestorMode.Unspecified) hash ^= Ancestor.GetHashCode();
      hash ^= properties_.GetHashCode();
      if (State != global::Google.Cloud.Datastore.Admin.V1.Index.Types.State.Unspecified) hash ^= State.GetHashCode();
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
      if (ProjectId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProjectId);
      }
      if (IndexId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(IndexId);
      }
      if (Kind.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Kind);
      }
      if (Ancestor != global::Google.Cloud.Datastore.Admin.V1.Index.Types.AncestorMode.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Ancestor);
      }
      properties_.WriteTo(output, _repeated_properties_codec);
      if (State != global::Google.Cloud.Datastore.Admin.V1.Index.Types.State.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) State);
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
      if (ProjectId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProjectId);
      }
      if (IndexId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(IndexId);
      }
      if (Kind.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Kind);
      }
      if (Ancestor != global::Google.Cloud.Datastore.Admin.V1.Index.Types.AncestorMode.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Ancestor);
      }
      properties_.WriteTo(ref output, _repeated_properties_codec);
      if (State != global::Google.Cloud.Datastore.Admin.V1.Index.Types.State.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) State);
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
      if (ProjectId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProjectId);
      }
      if (IndexId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IndexId);
      }
      if (Kind.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Kind);
      }
      if (Ancestor != global::Google.Cloud.Datastore.Admin.V1.Index.Types.AncestorMode.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Ancestor);
      }
      size += properties_.CalculateSize(_repeated_properties_codec);
      if (State != global::Google.Cloud.Datastore.Admin.V1.Index.Types.State.Unspecified) {
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
      if (other.ProjectId.Length != 0) {
        ProjectId = other.ProjectId;
      }
      if (other.IndexId.Length != 0) {
        IndexId = other.IndexId;
      }
      if (other.Kind.Length != 0) {
        Kind = other.Kind;
      }
      if (other.Ancestor != global::Google.Cloud.Datastore.Admin.V1.Index.Types.AncestorMode.Unspecified) {
        Ancestor = other.Ancestor;
      }
      properties_.Add(other.properties_);
      if (other.State != global::Google.Cloud.Datastore.Admin.V1.Index.Types.State.Unspecified) {
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
            ProjectId = input.ReadString();
            break;
          }
          case 26: {
            IndexId = input.ReadString();
            break;
          }
          case 34: {
            Kind = input.ReadString();
            break;
          }
          case 40: {
            Ancestor = (global::Google.Cloud.Datastore.Admin.V1.Index.Types.AncestorMode) input.ReadEnum();
            break;
          }
          case 50: {
            properties_.AddEntriesFrom(input, _repeated_properties_codec);
            break;
          }
          case 56: {
            State = (global::Google.Cloud.Datastore.Admin.V1.Index.Types.State) input.ReadEnum();
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
            ProjectId = input.ReadString();
            break;
          }
          case 26: {
            IndexId = input.ReadString();
            break;
          }
          case 34: {
            Kind = input.ReadString();
            break;
          }
          case 40: {
            Ancestor = (global::Google.Cloud.Datastore.Admin.V1.Index.Types.AncestorMode) input.ReadEnum();
            break;
          }
          case 50: {
            properties_.AddEntriesFrom(ref input, _repeated_properties_codec);
            break;
          }
          case 56: {
            State = (global::Google.Cloud.Datastore.Admin.V1.Index.Types.State) input.ReadEnum();
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
      /// For an ordered index, specifies whether each of the entity's ancestors
      /// will be included.
      /// </summary>
      public enum AncestorMode {
        /// <summary>
        /// The ancestor mode is unspecified.
        /// </summary>
        [pbr::OriginalName("ANCESTOR_MODE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Do not include the entity's ancestors in the index.
        /// </summary>
        [pbr::OriginalName("NONE")] None = 1,
        /// <summary>
        /// Include all the entity's ancestors in the index.
        /// </summary>
        [pbr::OriginalName("ALL_ANCESTORS")] AllAncestors = 2,
      }

      /// <summary>
      /// The direction determines how a property is indexed.
      /// </summary>
      public enum Direction {
        /// <summary>
        /// The direction is unspecified.
        /// </summary>
        [pbr::OriginalName("DIRECTION_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The property's values are indexed so as to support sequencing in
        /// ascending order and also query by &lt;, >, &lt;=, >=, and =.
        /// </summary>
        [pbr::OriginalName("ASCENDING")] Ascending = 1,
        /// <summary>
        /// The property's values are indexed so as to support sequencing in
        /// descending order and also query by &lt;, >, &lt;=, >=, and =.
        /// </summary>
        [pbr::OriginalName("DESCENDING")] Descending = 2,
      }

      /// <summary>
      /// The possible set of states of an index.
      /// </summary>
      public enum State {
        /// <summary>
        /// The state is unspecified.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The index is being created, and cannot be used by queries.
        /// There is an active long-running operation for the index.
        /// The index is updated when writing an entity.
        /// Some index data may exist.
        /// </summary>
        [pbr::OriginalName("CREATING")] Creating = 1,
        /// <summary>
        /// The index is ready to be used.
        /// The index is updated when writing an entity.
        /// The index is fully populated from all stored entities it applies to.
        /// </summary>
        [pbr::OriginalName("READY")] Ready = 2,
        /// <summary>
        /// The index is being deleted, and cannot be used by queries.
        /// There is an active long-running operation for the index.
        /// The index is not updated when writing an entity.
        /// Some index data may exist.
        /// </summary>
        [pbr::OriginalName("DELETING")] Deleting = 3,
        /// <summary>
        /// The index was being created or deleted, but something went wrong.
        /// The index cannot by used by queries.
        /// There is no active long-running operation for the index,
        /// and the most recently finished long-running operation failed.
        /// The index is not updated when writing an entity.
        /// Some index data may exist.
        /// </summary>
        [pbr::OriginalName("ERROR")] Error = 4,
      }

      /// <summary>
      /// A property of an index.
      /// </summary>
      public sealed partial class IndexedProperty : pb::IMessage<IndexedProperty>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<IndexedProperty> _parser = new pb::MessageParser<IndexedProperty>(() => new IndexedProperty());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<IndexedProperty> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Datastore.Admin.V1.Index.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public IndexedProperty() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public IndexedProperty(IndexedProperty other) : this() {
          name_ = other.name_;
          direction_ = other.direction_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public IndexedProperty Clone() {
          return new IndexedProperty(this);
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// Required. The property name to index.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Name {
          get { return name_; }
          set {
            name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "direction" field.</summary>
        public const int DirectionFieldNumber = 2;
        private global::Google.Cloud.Datastore.Admin.V1.Index.Types.Direction direction_ = global::Google.Cloud.Datastore.Admin.V1.Index.Types.Direction.Unspecified;
        /// <summary>
        /// Required. The indexed property's direction.  Must not be
        /// DIRECTION_UNSPECIFIED.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Cloud.Datastore.Admin.V1.Index.Types.Direction Direction {
          get { return direction_; }
          set {
            direction_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as IndexedProperty);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(IndexedProperty other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Name != other.Name) return false;
          if (Direction != other.Direction) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Name.Length != 0) hash ^= Name.GetHashCode();
          if (Direction != global::Google.Cloud.Datastore.Admin.V1.Index.Types.Direction.Unspecified) hash ^= Direction.GetHashCode();
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
          if (Direction != global::Google.Cloud.Datastore.Admin.V1.Index.Types.Direction.Unspecified) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Direction);
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
          if (Direction != global::Google.Cloud.Datastore.Admin.V1.Index.Types.Direction.Unspecified) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Direction);
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
          if (Direction != global::Google.Cloud.Datastore.Admin.V1.Index.Types.Direction.Unspecified) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Direction);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(IndexedProperty other) {
          if (other == null) {
            return;
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
          }
          if (other.Direction != global::Google.Cloud.Datastore.Admin.V1.Index.Types.Direction.Unspecified) {
            Direction = other.Direction;
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
                Direction = (global::Google.Cloud.Datastore.Admin.V1.Index.Types.Direction) input.ReadEnum();
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
                Direction = (global::Google.Cloud.Datastore.Admin.V1.Index.Types.Direction) input.ReadEnum();
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
