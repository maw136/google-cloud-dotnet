// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: grafeas/v1/dsse_attestation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grafeas.V1 {

  /// <summary>Holder for reflection information generated from grafeas/v1/dsse_attestation.proto</summary>
  public static partial class DsseAttestationReflection {

    #region Descriptor
    /// <summary>File descriptor for grafeas/v1/dsse_attestation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DsseAttestationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFncmFmZWFzL3YxL2Rzc2VfYXR0ZXN0YXRpb24ucHJvdG8SCmdyYWZlYXMu",
            "djEaF2dyYWZlYXMvdjEvY29tbW9uLnByb3RvGiFncmFmZWFzL3YxL2ludG90",
            "b19zdGF0ZW1lbnQucHJvdG8idgoTRFNTRUF0dGVzdGF0aW9uTm90ZRI2CgRo",
            "aW50GAEgASgLMiguZ3JhZmVhcy52MS5EU1NFQXR0ZXN0YXRpb25Ob3RlLkRT",
            "U0VIaW50GicKCERTU0VIaW50EhsKE2h1bWFuX3JlYWRhYmxlX25hbWUYASAB",
            "KAkiiAEKGURTU0VBdHRlc3RhdGlvbk9jY3VycmVuY2USJgoIZW52ZWxvcGUY",
            "ASABKAsyFC5ncmFmZWFzLnYxLkVudmVsb3BlEjAKCXN0YXRlbWVudBgCIAEo",
            "CzIbLmdyYWZlYXMudjEuSW5Ub3RvU3RhdGVtZW50SABCEQoPZGVjb2RlZF9w",
            "YXlsb2FkQlEKDWlvLmdyYWZlYXMudjFQAVo4Z29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9ncmFmZWFzL3YxO2dyYWZlYXOiAgNHUkFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Grafeas.V1.CommonReflection.Descriptor, global::Grafeas.V1.IntotoStatementReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.DSSEAttestationNote), global::Grafeas.V1.DSSEAttestationNote.Parser, new[]{ "Hint" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.DSSEAttestationNote.Types.DSSEHint), global::Grafeas.V1.DSSEAttestationNote.Types.DSSEHint.Parser, new[]{ "HumanReadableName" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.DSSEAttestationOccurrence), global::Grafeas.V1.DSSEAttestationOccurrence.Parser, new[]{ "Envelope", "Statement" }, new[]{ "DecodedPayload" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DSSEAttestationNote : pb::IMessage<DSSEAttestationNote>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DSSEAttestationNote> _parser = new pb::MessageParser<DSSEAttestationNote>(() => new DSSEAttestationNote());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DSSEAttestationNote> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.DsseAttestationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DSSEAttestationNote() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DSSEAttestationNote(DSSEAttestationNote other) : this() {
      hint_ = other.hint_ != null ? other.hint_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DSSEAttestationNote Clone() {
      return new DSSEAttestationNote(this);
    }

    /// <summary>Field number for the "hint" field.</summary>
    public const int HintFieldNumber = 1;
    private global::Grafeas.V1.DSSEAttestationNote.Types.DSSEHint hint_;
    /// <summary>
    /// DSSEHint hints at the purpose of the attestation authority.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Grafeas.V1.DSSEAttestationNote.Types.DSSEHint Hint {
      get { return hint_; }
      set {
        hint_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DSSEAttestationNote);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DSSEAttestationNote other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Hint, other.Hint)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (hint_ != null) hash ^= Hint.GetHashCode();
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
      if (hint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Hint);
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
      if (hint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Hint);
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
      if (hint_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Hint);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DSSEAttestationNote other) {
      if (other == null) {
        return;
      }
      if (other.hint_ != null) {
        if (hint_ == null) {
          Hint = new global::Grafeas.V1.DSSEAttestationNote.Types.DSSEHint();
        }
        Hint.MergeFrom(other.Hint);
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
            if (hint_ == null) {
              Hint = new global::Grafeas.V1.DSSEAttestationNote.Types.DSSEHint();
            }
            input.ReadMessage(Hint);
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
            if (hint_ == null) {
              Hint = new global::Grafeas.V1.DSSEAttestationNote.Types.DSSEHint();
            }
            input.ReadMessage(Hint);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DSSEAttestationNote message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// This submessage provides human-readable hints about the purpose of the
      /// authority. Because the name of a note acts as its resource reference, it is
      /// important to disambiguate the canonical name of the Note (which might be a
      /// UUID for security purposes) from "readable" names more suitable for debug
      /// output. Note that these hints should not be used to look up authorities in
      /// security sensitive contexts, such as when looking up attestations to
      /// verify.
      /// </summary>
      public sealed partial class DSSEHint : pb::IMessage<DSSEHint>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<DSSEHint> _parser = new pb::MessageParser<DSSEHint>(() => new DSSEHint());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<DSSEHint> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Grafeas.V1.DSSEAttestationNote.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DSSEHint() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DSSEHint(DSSEHint other) : this() {
          humanReadableName_ = other.humanReadableName_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DSSEHint Clone() {
          return new DSSEHint(this);
        }

        /// <summary>Field number for the "human_readable_name" field.</summary>
        public const int HumanReadableNameFieldNumber = 1;
        private string humanReadableName_ = "";
        /// <summary>
        /// Required. The human readable name of this attestation authority, for
        /// example "cloudbuild-prod".
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string HumanReadableName {
          get { return humanReadableName_; }
          set {
            humanReadableName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as DSSEHint);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(DSSEHint other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (HumanReadableName != other.HumanReadableName) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (HumanReadableName.Length != 0) hash ^= HumanReadableName.GetHashCode();
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
          if (HumanReadableName.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(HumanReadableName);
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
          if (HumanReadableName.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(HumanReadableName);
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
          if (HumanReadableName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(HumanReadableName);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(DSSEHint other) {
          if (other == null) {
            return;
          }
          if (other.HumanReadableName.Length != 0) {
            HumanReadableName = other.HumanReadableName;
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
                HumanReadableName = input.ReadString();
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
                HumanReadableName = input.ReadString();
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

  /// <summary>
  /// Deprecated. Prefer to use a regular Occurrence, and populate the
  /// Envelope at the top level of the Occurrence.
  /// </summary>
  public sealed partial class DSSEAttestationOccurrence : pb::IMessage<DSSEAttestationOccurrence>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DSSEAttestationOccurrence> _parser = new pb::MessageParser<DSSEAttestationOccurrence>(() => new DSSEAttestationOccurrence());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DSSEAttestationOccurrence> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.DsseAttestationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DSSEAttestationOccurrence() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DSSEAttestationOccurrence(DSSEAttestationOccurrence other) : this() {
      envelope_ = other.envelope_ != null ? other.envelope_.Clone() : null;
      switch (other.DecodedPayloadCase) {
        case DecodedPayloadOneofCase.Statement:
          Statement = other.Statement.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DSSEAttestationOccurrence Clone() {
      return new DSSEAttestationOccurrence(this);
    }

    /// <summary>Field number for the "envelope" field.</summary>
    public const int EnvelopeFieldNumber = 1;
    private global::Grafeas.V1.Envelope envelope_;
    /// <summary>
    /// If doing something security critical, make sure to verify the signatures in
    /// this metadata.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Grafeas.V1.Envelope Envelope {
      get { return envelope_; }
      set {
        envelope_ = value;
      }
    }

    /// <summary>Field number for the "statement" field.</summary>
    public const int StatementFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Grafeas.V1.InTotoStatement Statement {
      get { return decodedPayloadCase_ == DecodedPayloadOneofCase.Statement ? (global::Grafeas.V1.InTotoStatement) decodedPayload_ : null; }
      set {
        decodedPayload_ = value;
        decodedPayloadCase_ = value == null ? DecodedPayloadOneofCase.None : DecodedPayloadOneofCase.Statement;
      }
    }

    private object decodedPayload_;
    /// <summary>Enum of possible cases for the "decoded_payload" oneof.</summary>
    public enum DecodedPayloadOneofCase {
      None = 0,
      Statement = 2,
    }
    private DecodedPayloadOneofCase decodedPayloadCase_ = DecodedPayloadOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DecodedPayloadOneofCase DecodedPayloadCase {
      get { return decodedPayloadCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDecodedPayload() {
      decodedPayloadCase_ = DecodedPayloadOneofCase.None;
      decodedPayload_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DSSEAttestationOccurrence);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DSSEAttestationOccurrence other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Envelope, other.Envelope)) return false;
      if (!object.Equals(Statement, other.Statement)) return false;
      if (DecodedPayloadCase != other.DecodedPayloadCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (envelope_ != null) hash ^= Envelope.GetHashCode();
      if (decodedPayloadCase_ == DecodedPayloadOneofCase.Statement) hash ^= Statement.GetHashCode();
      hash ^= (int) decodedPayloadCase_;
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
      if (envelope_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Envelope);
      }
      if (decodedPayloadCase_ == DecodedPayloadOneofCase.Statement) {
        output.WriteRawTag(18);
        output.WriteMessage(Statement);
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
      if (envelope_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Envelope);
      }
      if (decodedPayloadCase_ == DecodedPayloadOneofCase.Statement) {
        output.WriteRawTag(18);
        output.WriteMessage(Statement);
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
      if (envelope_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Envelope);
      }
      if (decodedPayloadCase_ == DecodedPayloadOneofCase.Statement) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Statement);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DSSEAttestationOccurrence other) {
      if (other == null) {
        return;
      }
      if (other.envelope_ != null) {
        if (envelope_ == null) {
          Envelope = new global::Grafeas.V1.Envelope();
        }
        Envelope.MergeFrom(other.Envelope);
      }
      switch (other.DecodedPayloadCase) {
        case DecodedPayloadOneofCase.Statement:
          if (Statement == null) {
            Statement = new global::Grafeas.V1.InTotoStatement();
          }
          Statement.MergeFrom(other.Statement);
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
            if (envelope_ == null) {
              Envelope = new global::Grafeas.V1.Envelope();
            }
            input.ReadMessage(Envelope);
            break;
          }
          case 18: {
            global::Grafeas.V1.InTotoStatement subBuilder = new global::Grafeas.V1.InTotoStatement();
            if (decodedPayloadCase_ == DecodedPayloadOneofCase.Statement) {
              subBuilder.MergeFrom(Statement);
            }
            input.ReadMessage(subBuilder);
            Statement = subBuilder;
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
            if (envelope_ == null) {
              Envelope = new global::Grafeas.V1.Envelope();
            }
            input.ReadMessage(Envelope);
            break;
          }
          case 18: {
            global::Grafeas.V1.InTotoStatement subBuilder = new global::Grafeas.V1.InTotoStatement();
            if (decodedPayloadCase_ == DecodedPayloadOneofCase.Statement) {
              subBuilder.MergeFrom(Statement);
            }
            input.ReadMessage(subBuilder);
            Statement = subBuilder;
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
