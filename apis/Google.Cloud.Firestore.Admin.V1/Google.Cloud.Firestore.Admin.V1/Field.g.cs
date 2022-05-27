// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/firestore/admin/v1/field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Firestore.Admin.V1 {

  /// <summary>Holder for reflection information generated from google/firestore/admin/v1/field.proto</summary>
  public static partial class FieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/firestore/admin/v1/field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVnb29nbGUvZmlyZXN0b3JlL2FkbWluL3YxL2ZpZWxkLnByb3RvEhlnb29n",
            "bGUuZmlyZXN0b3JlLmFkbWluLnYxGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2",
            "aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGiVnb29nbGUv",
            "ZmlyZXN0b3JlL2FkbWluL3YxL2luZGV4LnByb3RvIsUECgVGaWVsZBIRCgRu",
            "YW1lGAEgASgJQgPgQQISQgoMaW5kZXhfY29uZmlnGAIgASgLMiwuZ29vZ2xl",
            "LmZpcmVzdG9yZS5hZG1pbi52MS5GaWVsZC5JbmRleENvbmZpZxI+Cgp0dGxf",
            "Y29uZmlnGAMgASgLMiouZ29vZ2xlLmZpcmVzdG9yZS5hZG1pbi52MS5GaWVs",
            "ZC5UdGxDb25maWcaiQEKC0luZGV4Q29uZmlnEjEKB2luZGV4ZXMYASADKAsy",
            "IC5nb29nbGUuZmlyZXN0b3JlLmFkbWluLnYxLkluZGV4EhwKFHVzZXNfYW5j",
            "ZXN0b3JfY29uZmlnGAIgASgIEhYKDmFuY2VzdG9yX2ZpZWxkGAMgASgJEhEK",
            "CXJldmVydGluZxgEIAEoCBqdAQoJVHRsQ29uZmlnEkQKBXN0YXRlGAEgASgO",
            "MjAuZ29vZ2xlLmZpcmVzdG9yZS5hZG1pbi52MS5GaWVsZC5UdGxDb25maWcu",
            "U3RhdGVCA+BBAyJKCgVTdGF0ZRIVChFTVEFURV9VTlNQRUNJRklFRBAAEgwK",
            "CENSRUFUSU5HEAESCgoGQUNUSVZFEAISEAoMTkVFRFNfUkVQQUlSEAM6eepB",
            "dgoeZmlyZXN0b3JlLmdvb2dsZWFwaXMuY29tL0ZpZWxkElRwcm9qZWN0cy97",
            "cHJvamVjdH0vZGF0YWJhc2VzL3tkYXRhYmFzZX0vY29sbGVjdGlvbkdyb3Vw",
            "cy97Y29sbGVjdGlvbn0vZmllbGRzL3tmaWVsZH1C3gEKHWNvbS5nb29nbGUu",
            "ZmlyZXN0b3JlLmFkbWluLnYxQgpGaWVsZFByb3RvUAFaPmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvZmlyZXN0b3JlL2FkbWluL3Yx",
            "O2FkbWluogIER0NGU6oCH0dvb2dsZS5DbG91ZC5GaXJlc3RvcmUuQWRtaW4u",
            "VjHKAh9Hb29nbGVcQ2xvdWRcRmlyZXN0b3JlXEFkbWluXFYx6gIjR29vZ2xl",
            "OjpDbG91ZDo6RmlyZXN0b3JlOjpBZG1pbjo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Firestore.Admin.V1.IndexReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Field), global::Google.Cloud.Firestore.Admin.V1.Field.Parser, new[]{ "Name", "IndexConfig", "TtlConfig" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Field.Types.IndexConfig), global::Google.Cloud.Firestore.Admin.V1.Field.Types.IndexConfig.Parser, new[]{ "Indexes", "UsesAncestorConfig", "AncestorField", "Reverting" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig), global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Parser, new[]{ "State" }, null, new[]{ typeof(global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Types.State) }, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a single field in the database.
  ///
  /// Fields are grouped by their "Collection Group", which represent all
  /// collections in the database with the same id.
  /// </summary>
  public sealed partial class Field : pb::IMessage<Field>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Field> _parser = new pb::MessageParser<Field>(() => new Field());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Field> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Firestore.Admin.V1.FieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Field() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Field(Field other) : this() {
      name_ = other.name_;
      indexConfig_ = other.indexConfig_ != null ? other.indexConfig_.Clone() : null;
      ttlConfig_ = other.ttlConfig_ != null ? other.ttlConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Field Clone() {
      return new Field(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. A field name of the form
    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_path}`
    ///
    /// A field path may be a simple field name, e.g. `address` or a path to fields
    /// within map_value , e.g. `address.city`,
    /// or a special field path. The only valid special field is `*`, which
    /// represents any field.
    ///
    /// Field paths may be quoted using ` (backtick). The only character that needs
    /// to be escaped within a quoted field path is the backtick character itself,
    /// escaped using a backslash. Special characters in field paths that
    /// must be quoted include: `*`, `.`,
    /// ``` (backtick), `[`, `]`, as well as any ascii symbolic characters.
    ///
    /// Examples:
    /// (Note: Comments here are written in markdown syntax, so there is an
    ///  additional layer of backticks to represent a code block)
    /// `\`address.city\`` represents a field named `address.city`, not the map key
    /// `city` in the field `address`.
    /// `\`*\`` represents a field named `*`, not any field.
    ///
    /// A special `Field` contains the default indexing settings for all fields.
    /// This field's resource name is:
    /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`
    /// Indexes defined on this `Field` will be applied to all fields which do not
    /// have their own `Field` index configuration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "index_config" field.</summary>
    public const int IndexConfigFieldNumber = 2;
    private global::Google.Cloud.Firestore.Admin.V1.Field.Types.IndexConfig indexConfig_;
    /// <summary>
    /// The index configuration for this field. If unset, field indexing will
    /// revert to the configuration defined by the `ancestor_field`. To
    /// explicitly remove all indexes for this field, specify an index config
    /// with an empty list of indexes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Firestore.Admin.V1.Field.Types.IndexConfig IndexConfig {
      get { return indexConfig_; }
      set {
        indexConfig_ = value;
      }
    }

    /// <summary>Field number for the "ttl_config" field.</summary>
    public const int TtlConfigFieldNumber = 3;
    private global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig ttlConfig_;
    /// <summary>
    /// The TTL configuration for this `Field`.
    /// Setting or unsetting this will enable or disable the TTL for
    /// documents that have this `Field`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig TtlConfig {
      get { return ttlConfig_; }
      set {
        ttlConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Field);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Field other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(IndexConfig, other.IndexConfig)) return false;
      if (!object.Equals(TtlConfig, other.TtlConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (indexConfig_ != null) hash ^= IndexConfig.GetHashCode();
      if (ttlConfig_ != null) hash ^= TtlConfig.GetHashCode();
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
      if (indexConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(IndexConfig);
      }
      if (ttlConfig_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TtlConfig);
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
      if (indexConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(IndexConfig);
      }
      if (ttlConfig_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TtlConfig);
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
      if (indexConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IndexConfig);
      }
      if (ttlConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TtlConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Field other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.indexConfig_ != null) {
        if (indexConfig_ == null) {
          IndexConfig = new global::Google.Cloud.Firestore.Admin.V1.Field.Types.IndexConfig();
        }
        IndexConfig.MergeFrom(other.IndexConfig);
      }
      if (other.ttlConfig_ != null) {
        if (ttlConfig_ == null) {
          TtlConfig = new global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig();
        }
        TtlConfig.MergeFrom(other.TtlConfig);
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
            if (indexConfig_ == null) {
              IndexConfig = new global::Google.Cloud.Firestore.Admin.V1.Field.Types.IndexConfig();
            }
            input.ReadMessage(IndexConfig);
            break;
          }
          case 26: {
            if (ttlConfig_ == null) {
              TtlConfig = new global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig();
            }
            input.ReadMessage(TtlConfig);
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
            if (indexConfig_ == null) {
              IndexConfig = new global::Google.Cloud.Firestore.Admin.V1.Field.Types.IndexConfig();
            }
            input.ReadMessage(IndexConfig);
            break;
          }
          case 26: {
            if (ttlConfig_ == null) {
              TtlConfig = new global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig();
            }
            input.ReadMessage(TtlConfig);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Field message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The index configuration for this field.
      /// </summary>
      public sealed partial class IndexConfig : pb::IMessage<IndexConfig>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<IndexConfig> _parser = new pb::MessageParser<IndexConfig>(() => new IndexConfig());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<IndexConfig> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Firestore.Admin.V1.Field.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public IndexConfig() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public IndexConfig(IndexConfig other) : this() {
          indexes_ = other.indexes_.Clone();
          usesAncestorConfig_ = other.usesAncestorConfig_;
          ancestorField_ = other.ancestorField_;
          reverting_ = other.reverting_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public IndexConfig Clone() {
          return new IndexConfig(this);
        }

        /// <summary>Field number for the "indexes" field.</summary>
        public const int IndexesFieldNumber = 1;
        private static readonly pb::FieldCodec<global::Google.Cloud.Firestore.Admin.V1.Index> _repeated_indexes_codec
            = pb::FieldCodec.ForMessage(10, global::Google.Cloud.Firestore.Admin.V1.Index.Parser);
        private readonly pbc::RepeatedField<global::Google.Cloud.Firestore.Admin.V1.Index> indexes_ = new pbc::RepeatedField<global::Google.Cloud.Firestore.Admin.V1.Index>();
        /// <summary>
        /// The indexes supported for this field.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::Google.Cloud.Firestore.Admin.V1.Index> Indexes {
          get { return indexes_; }
        }

        /// <summary>Field number for the "uses_ancestor_config" field.</summary>
        public const int UsesAncestorConfigFieldNumber = 2;
        private bool usesAncestorConfig_;
        /// <summary>
        /// Output only. When true, the `Field`'s index configuration is set from the
        /// configuration specified by the `ancestor_field`.
        /// When false, the `Field`'s index configuration is defined explicitly.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool UsesAncestorConfig {
          get { return usesAncestorConfig_; }
          set {
            usesAncestorConfig_ = value;
          }
        }

        /// <summary>Field number for the "ancestor_field" field.</summary>
        public const int AncestorFieldFieldNumber = 3;
        private string ancestorField_ = "";
        /// <summary>
        /// Output only. Specifies the resource name of the `Field` from which this field's
        /// index configuration is set (when `uses_ancestor_config` is true),
        /// or from which it *would* be set if this field had no index configuration
        /// (when `uses_ancestor_config` is false).
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string AncestorField {
          get { return ancestorField_; }
          set {
            ancestorField_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "reverting" field.</summary>
        public const int RevertingFieldNumber = 4;
        private bool reverting_;
        /// <summary>
        /// Output only
        /// When true, the `Field`'s index configuration is in the process of being
        /// reverted. Once complete, the index config will transition to the same
        /// state as the field specified by `ancestor_field`, at which point
        /// `uses_ancestor_config` will be `true` and `reverting` will be `false`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Reverting {
          get { return reverting_; }
          set {
            reverting_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as IndexConfig);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(IndexConfig other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!indexes_.Equals(other.indexes_)) return false;
          if (UsesAncestorConfig != other.UsesAncestorConfig) return false;
          if (AncestorField != other.AncestorField) return false;
          if (Reverting != other.Reverting) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= indexes_.GetHashCode();
          if (UsesAncestorConfig != false) hash ^= UsesAncestorConfig.GetHashCode();
          if (AncestorField.Length != 0) hash ^= AncestorField.GetHashCode();
          if (Reverting != false) hash ^= Reverting.GetHashCode();
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
          indexes_.WriteTo(output, _repeated_indexes_codec);
          if (UsesAncestorConfig != false) {
            output.WriteRawTag(16);
            output.WriteBool(UsesAncestorConfig);
          }
          if (AncestorField.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(AncestorField);
          }
          if (Reverting != false) {
            output.WriteRawTag(32);
            output.WriteBool(Reverting);
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
          indexes_.WriteTo(ref output, _repeated_indexes_codec);
          if (UsesAncestorConfig != false) {
            output.WriteRawTag(16);
            output.WriteBool(UsesAncestorConfig);
          }
          if (AncestorField.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(AncestorField);
          }
          if (Reverting != false) {
            output.WriteRawTag(32);
            output.WriteBool(Reverting);
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
          size += indexes_.CalculateSize(_repeated_indexes_codec);
          if (UsesAncestorConfig != false) {
            size += 1 + 1;
          }
          if (AncestorField.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(AncestorField);
          }
          if (Reverting != false) {
            size += 1 + 1;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(IndexConfig other) {
          if (other == null) {
            return;
          }
          indexes_.Add(other.indexes_);
          if (other.UsesAncestorConfig != false) {
            UsesAncestorConfig = other.UsesAncestorConfig;
          }
          if (other.AncestorField.Length != 0) {
            AncestorField = other.AncestorField;
          }
          if (other.Reverting != false) {
            Reverting = other.Reverting;
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
                indexes_.AddEntriesFrom(input, _repeated_indexes_codec);
                break;
              }
              case 16: {
                UsesAncestorConfig = input.ReadBool();
                break;
              }
              case 26: {
                AncestorField = input.ReadString();
                break;
              }
              case 32: {
                Reverting = input.ReadBool();
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
                indexes_.AddEntriesFrom(ref input, _repeated_indexes_codec);
                break;
              }
              case 16: {
                UsesAncestorConfig = input.ReadBool();
                break;
              }
              case 26: {
                AncestorField = input.ReadString();
                break;
              }
              case 32: {
                Reverting = input.ReadBool();
                break;
              }
            }
          }
        }
        #endif

      }

      /// <summary>
      /// The TTL (time-to-live) configuration for documents that have this `Field`
      /// set.
      /// Storing a timestamp value into a TTL-enabled field will be treated as
      /// the document's absolute expiration time. Using any other data type or
      /// leaving the field absent will disable the TTL for the individual document.
      /// </summary>
      public sealed partial class TtlConfig : pb::IMessage<TtlConfig>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<TtlConfig> _parser = new pb::MessageParser<TtlConfig>(() => new TtlConfig());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<TtlConfig> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Firestore.Admin.V1.Field.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public TtlConfig() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public TtlConfig(TtlConfig other) : this() {
          state_ = other.state_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public TtlConfig Clone() {
          return new TtlConfig(this);
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 1;
        private global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Types.State state_ = global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Types.State.Unspecified;
        /// <summary>
        /// Output only. The state of the TTL configuration.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Types.State State {
          get { return state_; }
          set {
            state_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as TtlConfig);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(TtlConfig other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (State != other.State) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (State != global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Types.State.Unspecified) hash ^= State.GetHashCode();
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
          if (State != global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Types.State.Unspecified) {
            output.WriteRawTag(8);
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
          if (State != global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Types.State.Unspecified) {
            output.WriteRawTag(8);
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
          if (State != global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Types.State.Unspecified) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(TtlConfig other) {
          if (other == null) {
            return;
          }
          if (other.State != global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Types.State.Unspecified) {
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
              case 8: {
                State = (global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Types.State) input.ReadEnum();
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
                State = (global::Google.Cloud.Firestore.Admin.V1.Field.Types.TtlConfig.Types.State) input.ReadEnum();
                break;
              }
            }
          }
        }
        #endif

        #region Nested types
        /// <summary>Container for nested types declared in the TtlConfig message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types {
          /// <summary>
          /// The state of applying the TTL configuration to all documents.
          /// </summary>
          public enum State {
            /// <summary>
            /// The state is unspecified or unknown.
            /// </summary>
            [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
            /// <summary>
            /// The TTL is being applied. There is an active long-running operation to
            /// track the change. Newly written documents will have TTLs applied as
            /// requested. Requested TTLs on existing documents are still being
            /// processed. When TTLs on all existing documents have been processed, the
            /// state will move to 'ACTIVE'.
            /// </summary>
            [pbr::OriginalName("CREATING")] Creating = 1,
            /// <summary>
            /// The TTL is active for all documents.
            /// </summary>
            [pbr::OriginalName("ACTIVE")] Active = 2,
            /// <summary>
            /// The TTL configuration could not be enabled for all existing documents.
            /// Newly written documents will continue to have their TTL applied.
            /// The LRO returned when last attempting to enable TTL for this `Field`
            /// has failed, and may have more details.
            /// </summary>
            [pbr::OriginalName("NEEDS_REPAIR")] NeedsRepair = 3,
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
