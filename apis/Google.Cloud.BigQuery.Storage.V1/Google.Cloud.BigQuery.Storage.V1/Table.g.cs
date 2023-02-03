// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/bigquery/storage/v1/table.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.BigQuery.Storage.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/bigquery/storage/v1/table.proto</summary>
  public static partial class TableReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/bigquery/storage/v1/table.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TableReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvY2xvdWQvYmlncXVlcnkvc3RvcmFnZS92MS90YWJsZS5wcm90",
            "bxIgZ29vZ2xlLmNsb3VkLmJpZ3F1ZXJ5LnN0b3JhZ2UudjEaH2dvb2dsZS9h",
            "cGkvZmllbGRfYmVoYXZpb3IucHJvdG8iUQoLVGFibGVTY2hlbWESQgoGZmll",
            "bGRzGAEgAygLMjIuZ29vZ2xlLmNsb3VkLmJpZ3F1ZXJ5LnN0b3JhZ2UudjEu",
            "VGFibGVGaWVsZFNjaGVtYSKFBQoQVGFibGVGaWVsZFNjaGVtYRIRCgRuYW1l",
            "GAEgASgJQgPgQQISSgoEdHlwZRgCIAEoDjI3Lmdvb2dsZS5jbG91ZC5iaWdx",
            "dWVyeS5zdG9yYWdlLnYxLlRhYmxlRmllbGRTY2hlbWEuVHlwZUID4EECEkoK",
            "BG1vZGUYAyABKA4yNy5nb29nbGUuY2xvdWQuYmlncXVlcnkuc3RvcmFnZS52",
            "MS5UYWJsZUZpZWxkU2NoZW1hLk1vZGVCA+BBARJHCgZmaWVsZHMYBCADKAsy",
            "Mi5nb29nbGUuY2xvdWQuYmlncXVlcnkuc3RvcmFnZS52MS5UYWJsZUZpZWxk",
            "U2NoZW1hQgPgQQESGAoLZGVzY3JpcHRpb24YBiABKAlCA+BBARIXCgptYXhf",
            "bGVuZ3RoGAcgASgDQgPgQQESFgoJcHJlY2lzaW9uGAggASgDQgPgQQESEgoF",
            "c2NhbGUYCSABKANCA+BBASLVAQoEVHlwZRIUChBUWVBFX1VOU1BFQ0lGSUVE",
            "EAASCgoGU1RSSU5HEAESCQoFSU5UNjQQAhIKCgZET1VCTEUQAxIKCgZTVFJV",
            "Q1QQBBIJCgVCWVRFUxAFEggKBEJPT0wQBhINCglUSU1FU1RBTVAQBxIICgRE",
            "QVRFEAgSCAoEVElNRRAJEgwKCERBVEVUSU1FEAoSDQoJR0VPR1JBUEhZEAsS",
            "CwoHTlVNRVJJQxAMEg4KCkJJR05VTUVSSUMQDRIMCghJTlRFUlZBTBAOEggK",
            "BEpTT04QDyJGCgRNb2RlEhQKEE1PREVfVU5TUEVDSUZJRUQQABIMCghOVUxM",
            "QUJMRRABEgwKCFJFUVVJUkVEEAISDAoIUkVQRUFURUQQA0K6AQokY29tLmdv",
            "b2dsZS5jbG91ZC5iaWdxdWVyeS5zdG9yYWdlLnYxQgpUYWJsZVByb3RvUAFa",
            "PmNsb3VkLmdvb2dsZS5jb20vZ28vYmlncXVlcnkvc3RvcmFnZS9hcGl2MS9z",
            "dG9yYWdlcGI7c3RvcmFnZXBiqgIgR29vZ2xlLkNsb3VkLkJpZ1F1ZXJ5LlN0",
            "b3JhZ2UuVjHKAiBHb29nbGVcQ2xvdWRcQmlnUXVlcnlcU3RvcmFnZVxWMWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.BigQuery.Storage.V1.TableSchema), global::Google.Cloud.BigQuery.Storage.V1.TableSchema.Parser, new[]{ "Fields" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema), global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Parser, new[]{ "Name", "Type", "Mode", "Fields", "Description", "MaxLength", "Precision", "Scale" }, null, new[]{ typeof(global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Type), typeof(global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Mode) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Schema of a table. This schema is a subset of
  /// google.cloud.bigquery.v2.TableSchema containing information necessary to
  /// generate valid message to write to BigQuery.
  /// </summary>
  public sealed partial class TableSchema : pb::IMessage<TableSchema>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TableSchema> _parser = new pb::MessageParser<TableSchema>(() => new TableSchema());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TableSchema> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.BigQuery.Storage.V1.TableReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TableSchema() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TableSchema(TableSchema other) : this() {
      fields_ = other.fields_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TableSchema Clone() {
      return new TableSchema(this);
    }

    /// <summary>Field number for the "fields" field.</summary>
    public const int FieldsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema> _repeated_fields_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema> fields_ = new pbc::RepeatedField<global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema>();
    /// <summary>
    /// Describes the fields in a table.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema> Fields {
      get { return fields_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TableSchema);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TableSchema other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!fields_.Equals(other.fields_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= fields_.GetHashCode();
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
      fields_.WriteTo(output, _repeated_fields_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      fields_.WriteTo(ref output, _repeated_fields_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += fields_.CalculateSize(_repeated_fields_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TableSchema other) {
      if (other == null) {
        return;
      }
      fields_.Add(other.fields_);
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
            fields_.AddEntriesFrom(input, _repeated_fields_codec);
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
            fields_.AddEntriesFrom(ref input, _repeated_fields_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// TableFieldSchema defines a single field/column within a table schema.
  /// </summary>
  public sealed partial class TableFieldSchema : pb::IMessage<TableFieldSchema>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TableFieldSchema> _parser = new pb::MessageParser<TableFieldSchema>(() => new TableFieldSchema());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TableFieldSchema> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.BigQuery.Storage.V1.TableReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TableFieldSchema() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TableFieldSchema(TableFieldSchema other) : this() {
      name_ = other.name_;
      type_ = other.type_;
      mode_ = other.mode_;
      fields_ = other.fields_.Clone();
      description_ = other.description_;
      maxLength_ = other.maxLength_;
      precision_ = other.precision_;
      scale_ = other.scale_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TableFieldSchema Clone() {
      return new TableFieldSchema(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. The field name. The name must contain only letters (a-z, A-Z),
    /// numbers (0-9), or underscores (_), and must start with a letter or
    /// underscore. The maximum length is 128 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Type type_ = global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Type.Unspecified;
    /// <summary>
    /// Required. The field data type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Type Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "mode" field.</summary>
    public const int ModeFieldNumber = 3;
    private global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Mode mode_ = global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Mode.Unspecified;
    /// <summary>
    /// Optional. The field mode. The default value is NULLABLE.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Mode Mode {
      get { return mode_; }
      set {
        mode_ = value;
      }
    }

    /// <summary>Field number for the "fields" field.</summary>
    public const int FieldsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema> _repeated_fields_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema> fields_ = new pbc::RepeatedField<global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema>();
    /// <summary>
    /// Optional. Describes the nested schema fields if the type property is set to
    /// STRUCT.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema> Fields {
      get { return fields_; }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 6;
    private string description_ = "";
    /// <summary>
    /// Optional. The field description. The maximum length is 1,024 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "max_length" field.</summary>
    public const int MaxLengthFieldNumber = 7;
    private long maxLength_;
    /// <summary>
    /// Optional. Maximum length of values of this field for STRINGS or BYTES.
    ///
    /// If max_length is not specified, no maximum length constraint is imposed
    /// on this field.
    ///
    /// If type = "STRING", then max_length represents the maximum UTF-8
    /// length of strings in this field.
    ///
    /// If type = "BYTES", then max_length represents the maximum number of
    /// bytes in this field.
    ///
    /// It is invalid to set this field if type is not "STRING" or "BYTES".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long MaxLength {
      get { return maxLength_; }
      set {
        maxLength_ = value;
      }
    }

    /// <summary>Field number for the "precision" field.</summary>
    public const int PrecisionFieldNumber = 8;
    private long precision_;
    /// <summary>
    /// Optional. Precision (maximum number of total digits in base 10) and scale
    /// (maximum number of digits in the fractional part in base 10) constraints
    /// for values of this field for NUMERIC or BIGNUMERIC.
    ///
    /// It is invalid to set precision or scale if type is not "NUMERIC" or
    /// "BIGNUMERIC".
    ///
    /// If precision and scale are not specified, no value range constraint is
    /// imposed on this field insofar as values are permitted by the type.
    ///
    /// Values of this NUMERIC or BIGNUMERIC field must be in this range when:
    ///
    /// * Precision (P) and scale (S) are specified:
    ///   [-10^(P-S) + 10^(-S), 10^(P-S) - 10^(-S)]
    /// * Precision (P) is specified but not scale (and thus scale is
    ///   interpreted to be equal to zero):
    ///   [-10^P + 1, 10^P - 1].
    ///
    /// Acceptable values for precision and scale if both are specified:
    ///
    /// * If type = "NUMERIC":
    ///   1 &lt;= precision - scale &lt;= 29 and 0 &lt;= scale &lt;= 9.
    /// * If type = "BIGNUMERIC":
    ///   1 &lt;= precision - scale &lt;= 38 and 0 &lt;= scale &lt;= 38.
    ///
    /// Acceptable values for precision if only precision is specified but not
    /// scale (and thus scale is interpreted to be equal to zero):
    ///
    /// * If type = "NUMERIC": 1 &lt;= precision &lt;= 29.
    /// * If type = "BIGNUMERIC": 1 &lt;= precision &lt;= 38.
    ///
    /// If scale is specified but not precision, then it is invalid.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Precision {
      get { return precision_; }
      set {
        precision_ = value;
      }
    }

    /// <summary>Field number for the "scale" field.</summary>
    public const int ScaleFieldNumber = 9;
    private long scale_;
    /// <summary>
    /// Optional. See documentation for precision.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Scale {
      get { return scale_; }
      set {
        scale_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TableFieldSchema);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TableFieldSchema other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      if (Mode != other.Mode) return false;
      if(!fields_.Equals(other.fields_)) return false;
      if (Description != other.Description) return false;
      if (MaxLength != other.MaxLength) return false;
      if (Precision != other.Precision) return false;
      if (Scale != other.Scale) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type != global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Type.Unspecified) hash ^= Type.GetHashCode();
      if (Mode != global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Mode.Unspecified) hash ^= Mode.GetHashCode();
      hash ^= fields_.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (MaxLength != 0L) hash ^= MaxLength.GetHashCode();
      if (Precision != 0L) hash ^= Precision.GetHashCode();
      if (Scale != 0L) hash ^= Scale.GetHashCode();
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
      if (Type != global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Type.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (Mode != global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Mode.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Mode);
      }
      fields_.WriteTo(output, _repeated_fields_codec);
      if (Description.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Description);
      }
      if (MaxLength != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(MaxLength);
      }
      if (Precision != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(Precision);
      }
      if (Scale != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(Scale);
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
      if (Type != global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Type.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (Mode != global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Mode.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Mode);
      }
      fields_.WriteTo(ref output, _repeated_fields_codec);
      if (Description.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Description);
      }
      if (MaxLength != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(MaxLength);
      }
      if (Precision != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(Precision);
      }
      if (Scale != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(Scale);
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
      if (Type != global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Type.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Mode != global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Mode.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Mode);
      }
      size += fields_.CalculateSize(_repeated_fields_codec);
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (MaxLength != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MaxLength);
      }
      if (Precision != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Precision);
      }
      if (Scale != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Scale);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TableFieldSchema other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type != global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Type.Unspecified) {
        Type = other.Type;
      }
      if (other.Mode != global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Mode.Unspecified) {
        Mode = other.Mode;
      }
      fields_.Add(other.fields_);
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.MaxLength != 0L) {
        MaxLength = other.MaxLength;
      }
      if (other.Precision != 0L) {
        Precision = other.Precision;
      }
      if (other.Scale != 0L) {
        Scale = other.Scale;
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
            Type = (global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Type) input.ReadEnum();
            break;
          }
          case 24: {
            Mode = (global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Mode) input.ReadEnum();
            break;
          }
          case 34: {
            fields_.AddEntriesFrom(input, _repeated_fields_codec);
            break;
          }
          case 50: {
            Description = input.ReadString();
            break;
          }
          case 56: {
            MaxLength = input.ReadInt64();
            break;
          }
          case 64: {
            Precision = input.ReadInt64();
            break;
          }
          case 72: {
            Scale = input.ReadInt64();
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
            Type = (global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Type) input.ReadEnum();
            break;
          }
          case 24: {
            Mode = (global::Google.Cloud.BigQuery.Storage.V1.TableFieldSchema.Types.Mode) input.ReadEnum();
            break;
          }
          case 34: {
            fields_.AddEntriesFrom(ref input, _repeated_fields_codec);
            break;
          }
          case 50: {
            Description = input.ReadString();
            break;
          }
          case 56: {
            MaxLength = input.ReadInt64();
            break;
          }
          case 64: {
            Precision = input.ReadInt64();
            break;
          }
          case 72: {
            Scale = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TableFieldSchema message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum Type {
        /// <summary>
        /// Illegal value
        /// </summary>
        [pbr::OriginalName("TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// 64K, UTF8
        /// </summary>
        [pbr::OriginalName("STRING")] String = 1,
        /// <summary>
        /// 64-bit signed
        /// </summary>
        [pbr::OriginalName("INT64")] Int64 = 2,
        /// <summary>
        /// 64-bit IEEE floating point
        /// </summary>
        [pbr::OriginalName("DOUBLE")] Double = 3,
        /// <summary>
        /// Aggregate type
        /// </summary>
        [pbr::OriginalName("STRUCT")] Struct = 4,
        /// <summary>
        /// 64K, Binary
        /// </summary>
        [pbr::OriginalName("BYTES")] Bytes = 5,
        /// <summary>
        /// 2-valued
        /// </summary>
        [pbr::OriginalName("BOOL")] Bool = 6,
        /// <summary>
        /// 64-bit signed usec since UTC epoch
        /// </summary>
        [pbr::OriginalName("TIMESTAMP")] Timestamp = 7,
        /// <summary>
        /// Civil date - Year, Month, Day
        /// </summary>
        [pbr::OriginalName("DATE")] Date = 8,
        /// <summary>
        /// Civil time - Hour, Minute, Second, Microseconds
        /// </summary>
        [pbr::OriginalName("TIME")] Time = 9,
        /// <summary>
        /// Combination of civil date and civil time
        /// </summary>
        [pbr::OriginalName("DATETIME")] Datetime = 10,
        /// <summary>
        /// Geography object
        /// </summary>
        [pbr::OriginalName("GEOGRAPHY")] Geography = 11,
        /// <summary>
        /// Numeric value
        /// </summary>
        [pbr::OriginalName("NUMERIC")] Numeric = 12,
        /// <summary>
        /// BigNumeric value
        /// </summary>
        [pbr::OriginalName("BIGNUMERIC")] Bignumeric = 13,
        /// <summary>
        /// Interval
        /// </summary>
        [pbr::OriginalName("INTERVAL")] Interval = 14,
        /// <summary>
        /// JSON, String
        /// </summary>
        [pbr::OriginalName("JSON")] Json = 15,
      }

      public enum Mode {
        /// <summary>
        /// Illegal value
        /// </summary>
        [pbr::OriginalName("MODE_UNSPECIFIED")] Unspecified = 0,
        [pbr::OriginalName("NULLABLE")] Nullable = 1,
        [pbr::OriginalName("REQUIRED")] Required = 2,
        [pbr::OriginalName("REPEATED")] Repeated = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
