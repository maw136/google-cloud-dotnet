// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: grafeas/v1/intoto_statement.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grafeas.V1 {

  /// <summary>Holder for reflection information generated from grafeas/v1/intoto_statement.proto</summary>
  public static partial class IntotoStatementReflection {

    #region Descriptor
    /// <summary>File descriptor for grafeas/v1/intoto_statement.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IntotoStatementReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFncmFmZWFzL3YxL2ludG90b19zdGF0ZW1lbnQucHJvdG8SCmdyYWZlYXMu",
            "djEaImdyYWZlYXMvdjEvaW50b3RvX3Byb3ZlbmFuY2UucHJvdG8aIGdyYWZl",
            "YXMvdjEvc2xzYV9wcm92ZW5hbmNlLnByb3RvGilncmFmZWFzL3YxL3Nsc2Ff",
            "cHJvdmVuYW5jZV96ZXJvX3R3by5wcm90byKjAgoPSW5Ub3RvU3RhdGVtZW50",
            "EhMKBHR5cGUYASABKAlSBV90eXBlEiQKB3N1YmplY3QYAiADKAsyEy5ncmFm",
            "ZWFzLnYxLlN1YmplY3QSFgoOcHJlZGljYXRlX3R5cGUYAyABKAkSMgoKcHJv",
            "dmVuYW5jZRgEIAEoCzIcLmdyYWZlYXMudjEuSW5Ub3RvUHJvdmVuYW5jZUgA",
            "EjUKD3Nsc2FfcHJvdmVuYW5jZRgFIAEoCzIaLmdyYWZlYXMudjEuU2xzYVBy",
            "b3ZlbmFuY2VIABJFChhzbHNhX3Byb3ZlbmFuY2VfemVyb190d28YBiABKAsy",
            "IS5ncmFmZWFzLnYxLlNsc2FQcm92ZW5hbmNlWmVyb1R3b0gAQgsKCXByZWRp",
            "Y2F0ZSJ3CgdTdWJqZWN0EgwKBG5hbWUYASABKAkSLwoGZGlnZXN0GAIgAygL",
            "Mh8uZ3JhZmVhcy52MS5TdWJqZWN0LkRpZ2VzdEVudHJ5Gi0KC0RpZ2VzdEVu",
            "dHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAFCZwoNaW8uZ3Jh",
            "ZmVhcy52MUIUSW5Ub3RvU3RhdGVtZW50UHJvdG9QAVo4Z29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9ncmFmZWFzL3YxO2dyYWZlYXOi",
            "AgNHUkFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Grafeas.V1.IntotoProvenanceReflection.Descriptor, global::Grafeas.V1.SlsaProvenanceReflection.Descriptor, global::Grafeas.V1.SlsaProvenanceZeroTwoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.InTotoStatement), global::Grafeas.V1.InTotoStatement.Parser, new[]{ "Type", "Subject", "PredicateType", "Provenance", "SlsaProvenance", "SlsaProvenanceZeroTwo" }, new[]{ "Predicate" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.Subject), global::Grafeas.V1.Subject.Parser, new[]{ "Name", "Digest" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Spec defined at
  /// https://github.com/in-toto/attestation/tree/main/spec#statement The
  /// serialized InTotoStatement will be stored as Envelope.payload.
  /// Envelope.payloadType is always "application/vnd.in-toto+json".
  /// </summary>
  public sealed partial class InTotoStatement : pb::IMessage<InTotoStatement>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InTotoStatement> _parser = new pb::MessageParser<InTotoStatement>(() => new InTotoStatement());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InTotoStatement> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.IntotoStatementReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InTotoStatement() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InTotoStatement(InTotoStatement other) : this() {
      type_ = other.type_;
      subject_ = other.subject_.Clone();
      predicateType_ = other.predicateType_;
      switch (other.PredicateCase) {
        case PredicateOneofCase.Provenance:
          Provenance = other.Provenance.Clone();
          break;
        case PredicateOneofCase.SlsaProvenance:
          SlsaProvenance = other.SlsaProvenance.Clone();
          break;
        case PredicateOneofCase.SlsaProvenanceZeroTwo:
          SlsaProvenanceZeroTwo = other.SlsaProvenanceZeroTwo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InTotoStatement Clone() {
      return new InTotoStatement(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private string type_ = "";
    /// <summary>
    /// Always `https://in-toto.io/Statement/v0.1`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "subject" field.</summary>
    public const int SubjectFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Grafeas.V1.Subject> _repeated_subject_codec
        = pb::FieldCodec.ForMessage(18, global::Grafeas.V1.Subject.Parser);
    private readonly pbc::RepeatedField<global::Grafeas.V1.Subject> subject_ = new pbc::RepeatedField<global::Grafeas.V1.Subject>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Grafeas.V1.Subject> Subject {
      get { return subject_; }
    }

    /// <summary>Field number for the "predicate_type" field.</summary>
    public const int PredicateTypeFieldNumber = 3;
    private string predicateType_ = "";
    /// <summary>
    /// `https://slsa.dev/provenance/v0.1` for SlsaProvenance.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PredicateType {
      get { return predicateType_; }
      set {
        predicateType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "provenance" field.</summary>
    public const int ProvenanceFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Grafeas.V1.InTotoProvenance Provenance {
      get { return predicateCase_ == PredicateOneofCase.Provenance ? (global::Grafeas.V1.InTotoProvenance) predicate_ : null; }
      set {
        predicate_ = value;
        predicateCase_ = value == null ? PredicateOneofCase.None : PredicateOneofCase.Provenance;
      }
    }

    /// <summary>Field number for the "slsa_provenance" field.</summary>
    public const int SlsaProvenanceFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Grafeas.V1.SlsaProvenance SlsaProvenance {
      get { return predicateCase_ == PredicateOneofCase.SlsaProvenance ? (global::Grafeas.V1.SlsaProvenance) predicate_ : null; }
      set {
        predicate_ = value;
        predicateCase_ = value == null ? PredicateOneofCase.None : PredicateOneofCase.SlsaProvenance;
      }
    }

    /// <summary>Field number for the "slsa_provenance_zero_two" field.</summary>
    public const int SlsaProvenanceZeroTwoFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Grafeas.V1.SlsaProvenanceZeroTwo SlsaProvenanceZeroTwo {
      get { return predicateCase_ == PredicateOneofCase.SlsaProvenanceZeroTwo ? (global::Grafeas.V1.SlsaProvenanceZeroTwo) predicate_ : null; }
      set {
        predicate_ = value;
        predicateCase_ = value == null ? PredicateOneofCase.None : PredicateOneofCase.SlsaProvenanceZeroTwo;
      }
    }

    private object predicate_;
    /// <summary>Enum of possible cases for the "predicate" oneof.</summary>
    public enum PredicateOneofCase {
      None = 0,
      Provenance = 4,
      SlsaProvenance = 5,
      SlsaProvenanceZeroTwo = 6,
    }
    private PredicateOneofCase predicateCase_ = PredicateOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PredicateOneofCase PredicateCase {
      get { return predicateCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPredicate() {
      predicateCase_ = PredicateOneofCase.None;
      predicate_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InTotoStatement);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InTotoStatement other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if(!subject_.Equals(other.subject_)) return false;
      if (PredicateType != other.PredicateType) return false;
      if (!object.Equals(Provenance, other.Provenance)) return false;
      if (!object.Equals(SlsaProvenance, other.SlsaProvenance)) return false;
      if (!object.Equals(SlsaProvenanceZeroTwo, other.SlsaProvenanceZeroTwo)) return false;
      if (PredicateCase != other.PredicateCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      hash ^= subject_.GetHashCode();
      if (PredicateType.Length != 0) hash ^= PredicateType.GetHashCode();
      if (predicateCase_ == PredicateOneofCase.Provenance) hash ^= Provenance.GetHashCode();
      if (predicateCase_ == PredicateOneofCase.SlsaProvenance) hash ^= SlsaProvenance.GetHashCode();
      if (predicateCase_ == PredicateOneofCase.SlsaProvenanceZeroTwo) hash ^= SlsaProvenanceZeroTwo.GetHashCode();
      hash ^= (int) predicateCase_;
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
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      subject_.WriteTo(output, _repeated_subject_codec);
      if (PredicateType.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PredicateType);
      }
      if (predicateCase_ == PredicateOneofCase.Provenance) {
        output.WriteRawTag(34);
        output.WriteMessage(Provenance);
      }
      if (predicateCase_ == PredicateOneofCase.SlsaProvenance) {
        output.WriteRawTag(42);
        output.WriteMessage(SlsaProvenance);
      }
      if (predicateCase_ == PredicateOneofCase.SlsaProvenanceZeroTwo) {
        output.WriteRawTag(50);
        output.WriteMessage(SlsaProvenanceZeroTwo);
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
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      subject_.WriteTo(ref output, _repeated_subject_codec);
      if (PredicateType.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PredicateType);
      }
      if (predicateCase_ == PredicateOneofCase.Provenance) {
        output.WriteRawTag(34);
        output.WriteMessage(Provenance);
      }
      if (predicateCase_ == PredicateOneofCase.SlsaProvenance) {
        output.WriteRawTag(42);
        output.WriteMessage(SlsaProvenance);
      }
      if (predicateCase_ == PredicateOneofCase.SlsaProvenanceZeroTwo) {
        output.WriteRawTag(50);
        output.WriteMessage(SlsaProvenanceZeroTwo);
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
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      size += subject_.CalculateSize(_repeated_subject_codec);
      if (PredicateType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PredicateType);
      }
      if (predicateCase_ == PredicateOneofCase.Provenance) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Provenance);
      }
      if (predicateCase_ == PredicateOneofCase.SlsaProvenance) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SlsaProvenance);
      }
      if (predicateCase_ == PredicateOneofCase.SlsaProvenanceZeroTwo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SlsaProvenanceZeroTwo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InTotoStatement other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      subject_.Add(other.subject_);
      if (other.PredicateType.Length != 0) {
        PredicateType = other.PredicateType;
      }
      switch (other.PredicateCase) {
        case PredicateOneofCase.Provenance:
          if (Provenance == null) {
            Provenance = new global::Grafeas.V1.InTotoProvenance();
          }
          Provenance.MergeFrom(other.Provenance);
          break;
        case PredicateOneofCase.SlsaProvenance:
          if (SlsaProvenance == null) {
            SlsaProvenance = new global::Grafeas.V1.SlsaProvenance();
          }
          SlsaProvenance.MergeFrom(other.SlsaProvenance);
          break;
        case PredicateOneofCase.SlsaProvenanceZeroTwo:
          if (SlsaProvenanceZeroTwo == null) {
            SlsaProvenanceZeroTwo = new global::Grafeas.V1.SlsaProvenanceZeroTwo();
          }
          SlsaProvenanceZeroTwo.MergeFrom(other.SlsaProvenanceZeroTwo);
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
            Type = input.ReadString();
            break;
          }
          case 18: {
            subject_.AddEntriesFrom(input, _repeated_subject_codec);
            break;
          }
          case 26: {
            PredicateType = input.ReadString();
            break;
          }
          case 34: {
            global::Grafeas.V1.InTotoProvenance subBuilder = new global::Grafeas.V1.InTotoProvenance();
            if (predicateCase_ == PredicateOneofCase.Provenance) {
              subBuilder.MergeFrom(Provenance);
            }
            input.ReadMessage(subBuilder);
            Provenance = subBuilder;
            break;
          }
          case 42: {
            global::Grafeas.V1.SlsaProvenance subBuilder = new global::Grafeas.V1.SlsaProvenance();
            if (predicateCase_ == PredicateOneofCase.SlsaProvenance) {
              subBuilder.MergeFrom(SlsaProvenance);
            }
            input.ReadMessage(subBuilder);
            SlsaProvenance = subBuilder;
            break;
          }
          case 50: {
            global::Grafeas.V1.SlsaProvenanceZeroTwo subBuilder = new global::Grafeas.V1.SlsaProvenanceZeroTwo();
            if (predicateCase_ == PredicateOneofCase.SlsaProvenanceZeroTwo) {
              subBuilder.MergeFrom(SlsaProvenanceZeroTwo);
            }
            input.ReadMessage(subBuilder);
            SlsaProvenanceZeroTwo = subBuilder;
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
            Type = input.ReadString();
            break;
          }
          case 18: {
            subject_.AddEntriesFrom(ref input, _repeated_subject_codec);
            break;
          }
          case 26: {
            PredicateType = input.ReadString();
            break;
          }
          case 34: {
            global::Grafeas.V1.InTotoProvenance subBuilder = new global::Grafeas.V1.InTotoProvenance();
            if (predicateCase_ == PredicateOneofCase.Provenance) {
              subBuilder.MergeFrom(Provenance);
            }
            input.ReadMessage(subBuilder);
            Provenance = subBuilder;
            break;
          }
          case 42: {
            global::Grafeas.V1.SlsaProvenance subBuilder = new global::Grafeas.V1.SlsaProvenance();
            if (predicateCase_ == PredicateOneofCase.SlsaProvenance) {
              subBuilder.MergeFrom(SlsaProvenance);
            }
            input.ReadMessage(subBuilder);
            SlsaProvenance = subBuilder;
            break;
          }
          case 50: {
            global::Grafeas.V1.SlsaProvenanceZeroTwo subBuilder = new global::Grafeas.V1.SlsaProvenanceZeroTwo();
            if (predicateCase_ == PredicateOneofCase.SlsaProvenanceZeroTwo) {
              subBuilder.MergeFrom(SlsaProvenanceZeroTwo);
            }
            input.ReadMessage(subBuilder);
            SlsaProvenanceZeroTwo = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Subject : pb::IMessage<Subject>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Subject> _parser = new pb::MessageParser<Subject>(() => new Subject());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Subject> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.IntotoStatementReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Subject() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Subject(Subject other) : this() {
      name_ = other.name_;
      digest_ = other.digest_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Subject Clone() {
      return new Subject(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "digest" field.</summary>
    public const int DigestFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_digest_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 18);
    private readonly pbc::MapField<string, string> digest_ = new pbc::MapField<string, string>();
    /// <summary>
    /// `"&lt;ALGORITHM>": "&lt;HEX_VALUE>"`
    /// Algorithms can be e.g. sha256, sha512
    /// See
    /// https://github.com/in-toto/attestation/blob/main/spec/field_types.md#DigestSet
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Digest {
      get { return digest_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Subject);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Subject other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!Digest.Equals(other.Digest)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= Digest.GetHashCode();
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
      digest_.WriteTo(output, _map_digest_codec);
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
      digest_.WriteTo(ref output, _map_digest_codec);
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
      size += digest_.CalculateSize(_map_digest_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Subject other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      digest_.MergeFrom(other.digest_);
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
            digest_.AddEntriesFrom(input, _map_digest_codec);
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
            digest_.AddEntriesFrom(ref input, _map_digest_codec);
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
