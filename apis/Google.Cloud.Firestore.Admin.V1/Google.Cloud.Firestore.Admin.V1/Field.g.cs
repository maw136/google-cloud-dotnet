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
            "ZmlyZXN0b3JlL2FkbWluL3YxL2luZGV4LnByb3RvGhxnb29nbGUvYXBpL2Fu",
            "bm90YXRpb25zLnByb3RvIuUCCgVGaWVsZBIRCgRuYW1lGAEgASgJQgPgQQIS",
            "QgoMaW5kZXhfY29uZmlnGAIgASgLMiwuZ29vZ2xlLmZpcmVzdG9yZS5hZG1p",
            "bi52MS5GaWVsZC5JbmRleENvbmZpZxqJAQoLSW5kZXhDb25maWcSMQoHaW5k",
            "ZXhlcxgBIAMoCzIgLmdvb2dsZS5maXJlc3RvcmUuYWRtaW4udjEuSW5kZXgS",
            "HAoUdXNlc19hbmNlc3Rvcl9jb25maWcYAiABKAgSFgoOYW5jZXN0b3JfZmll",
            "bGQYAyABKAkSEQoJcmV2ZXJ0aW5nGAQgASgIOnnqQXYKHmZpcmVzdG9yZS5n",
            "b29nbGVhcGlzLmNvbS9GaWVsZBJUcHJvamVjdHMve3Byb2plY3R9L2RhdGFi",
            "YXNlcy97ZGF0YWJhc2V9L2NvbGxlY3Rpb25Hcm91cHMve2NvbGxlY3Rpb259",
            "L2ZpZWxkcy97ZmllbGR9Qt4BCh1jb20uZ29vZ2xlLmZpcmVzdG9yZS5hZG1p",
            "bi52MUIKRmllbGRQcm90b1ABWj5nb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2ZpcmVzdG9yZS9hZG1pbi92MTthZG1pbqICBEdDRlOq",
            "Ah9Hb29nbGUuQ2xvdWQuRmlyZXN0b3JlLkFkbWluLlYxygIfR29vZ2xlXENs",
            "b3VkXEZpcmVzdG9yZVxBZG1pblxWMeoCI0dvb2dsZTo6Q2xvdWQ6OkZpcmVz",
            "dG9yZTo6QWRtaW46OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Firestore.Admin.V1.IndexReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Field), global::Google.Cloud.Firestore.Admin.V1.Field.Parser, new[]{ "Name", "IndexConfig" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Field.Types.IndexConfig), global::Google.Cloud.Firestore.Admin.V1.Field.Types.IndexConfig.Parser, new[]{ "Indexes", "UsesAncestorConfig", "AncestorField", "Reverting" }, null, null, null, null)})
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
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (indexConfig_ != null) hash ^= IndexConfig.GetHashCode();
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

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
