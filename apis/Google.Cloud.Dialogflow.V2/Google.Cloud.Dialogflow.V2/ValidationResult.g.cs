// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/v2/validation_result.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Dialogflow.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/dialogflow/v2/validation_result.proto</summary>
  public static partial class ValidationResultReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/dialogflow/v2/validation_result.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValidationResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvY2xvdWQvZGlhbG9nZmxvdy92Mi92YWxpZGF0aW9uX3Jlc3Vs",
            "dC5wcm90bxIaZ29vZ2xlLmNsb3VkLmRpYWxvZ2Zsb3cudjIi1wEKD1ZhbGlk",
            "YXRpb25FcnJvchJGCghzZXZlcml0eRgBIAEoDjI0Lmdvb2dsZS5jbG91ZC5k",
            "aWFsb2dmbG93LnYyLlZhbGlkYXRpb25FcnJvci5TZXZlcml0eRIPCgdlbnRy",
            "aWVzGAMgAygJEhUKDWVycm9yX21lc3NhZ2UYBCABKAkiVAoIU2V2ZXJpdHkS",
            "GAoUU0VWRVJJVFlfVU5TUEVDSUZJRUQQABIICgRJTkZPEAESCwoHV0FSTklO",
            "RxACEgkKBUVSUk9SEAMSDAoIQ1JJVElDQUwQBCJaChBWYWxpZGF0aW9uUmVz",
            "dWx0EkYKEXZhbGlkYXRpb25fZXJyb3JzGAEgAygLMisuZ29vZ2xlLmNsb3Vk",
            "LmRpYWxvZ2Zsb3cudjIuVmFsaWRhdGlvbkVycm9yQp4BCh5jb20uZ29vZ2xl",
            "LmNsb3VkLmRpYWxvZ2Zsb3cudjJCFVZhbGlkYXRpb25SZXN1bHRQcm90b1AB",
            "Wj5jbG91ZC5nb29nbGUuY29tL2dvL2RpYWxvZ2Zsb3cvYXBpdjIvZGlhbG9n",
            "Zmxvd3BiO2RpYWxvZ2Zsb3dwYvgBAaICAkRGqgIaR29vZ2xlLkNsb3VkLkRp",
            "YWxvZ2Zsb3cuVjJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.V2.ValidationError), global::Google.Cloud.Dialogflow.V2.ValidationError.Parser, new[]{ "Severity", "Entries", "ErrorMessage" }, null, new[]{ typeof(global::Google.Cloud.Dialogflow.V2.ValidationError.Types.Severity) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.V2.ValidationResult), global::Google.Cloud.Dialogflow.V2.ValidationResult.Parser, new[]{ "ValidationErrors" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a single validation error.
  /// </summary>
  public sealed partial class ValidationError : pb::IMessage<ValidationError>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ValidationError> _parser = new pb::MessageParser<ValidationError>(() => new ValidationError());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ValidationError> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dialogflow.V2.ValidationResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationError() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationError(ValidationError other) : this() {
      severity_ = other.severity_;
      entries_ = other.entries_.Clone();
      errorMessage_ = other.errorMessage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationError Clone() {
      return new ValidationError(this);
    }

    /// <summary>Field number for the "severity" field.</summary>
    public const int SeverityFieldNumber = 1;
    private global::Google.Cloud.Dialogflow.V2.ValidationError.Types.Severity severity_ = global::Google.Cloud.Dialogflow.V2.ValidationError.Types.Severity.Unspecified;
    /// <summary>
    /// The severity of the error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Dialogflow.V2.ValidationError.Types.Severity Severity {
      get { return severity_; }
      set {
        severity_ = value;
      }
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_entries_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> entries_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The names of the entries that the error is associated with.
    /// Format:
    ///
    /// - "projects/&lt;Project ID>/agent", if the error is associated with the entire
    /// agent.
    /// - "projects/&lt;Project ID>/agent/intents/&lt;Intent ID>", if the error is
    /// associated with certain intents.
    /// - "projects/&lt;Project
    /// ID>/agent/intents/&lt;Intent Id>/trainingPhrases/&lt;Training Phrase ID>", if the
    /// error is associated with certain intent training phrases.
    /// - "projects/&lt;Project ID>/agent/intents/&lt;Intent Id>/parameters/&lt;Parameter
    /// ID>", if the error is associated with certain intent parameters.
    /// - "projects/&lt;Project ID>/agent/entities/&lt;Entity ID>", if the error is
    /// associated with certain entities.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Entries {
      get { return entries_; }
    }

    /// <summary>Field number for the "error_message" field.</summary>
    public const int ErrorMessageFieldNumber = 4;
    private string errorMessage_ = "";
    /// <summary>
    /// The detailed error message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ErrorMessage {
      get { return errorMessage_; }
      set {
        errorMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ValidationError);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ValidationError other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Severity != other.Severity) return false;
      if(!entries_.Equals(other.entries_)) return false;
      if (ErrorMessage != other.ErrorMessage) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Severity != global::Google.Cloud.Dialogflow.V2.ValidationError.Types.Severity.Unspecified) hash ^= Severity.GetHashCode();
      hash ^= entries_.GetHashCode();
      if (ErrorMessage.Length != 0) hash ^= ErrorMessage.GetHashCode();
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
      if (Severity != global::Google.Cloud.Dialogflow.V2.ValidationError.Types.Severity.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Severity);
      }
      entries_.WriteTo(output, _repeated_entries_codec);
      if (ErrorMessage.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ErrorMessage);
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
      if (Severity != global::Google.Cloud.Dialogflow.V2.ValidationError.Types.Severity.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Severity);
      }
      entries_.WriteTo(ref output, _repeated_entries_codec);
      if (ErrorMessage.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ErrorMessage);
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
      if (Severity != global::Google.Cloud.Dialogflow.V2.ValidationError.Types.Severity.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Severity);
      }
      size += entries_.CalculateSize(_repeated_entries_codec);
      if (ErrorMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ErrorMessage);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ValidationError other) {
      if (other == null) {
        return;
      }
      if (other.Severity != global::Google.Cloud.Dialogflow.V2.ValidationError.Types.Severity.Unspecified) {
        Severity = other.Severity;
      }
      entries_.Add(other.entries_);
      if (other.ErrorMessage.Length != 0) {
        ErrorMessage = other.ErrorMessage;
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
            Severity = (global::Google.Cloud.Dialogflow.V2.ValidationError.Types.Severity) input.ReadEnum();
            break;
          }
          case 26: {
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
            break;
          }
          case 34: {
            ErrorMessage = input.ReadString();
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
            Severity = (global::Google.Cloud.Dialogflow.V2.ValidationError.Types.Severity) input.ReadEnum();
            break;
          }
          case 26: {
            entries_.AddEntriesFrom(ref input, _repeated_entries_codec);
            break;
          }
          case 34: {
            ErrorMessage = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ValidationError message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Represents a level of severity.
      /// </summary>
      public enum Severity {
        /// <summary>
        /// Not specified. This value should never be used.
        /// </summary>
        [pbr::OriginalName("SEVERITY_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The agent doesn't follow Dialogflow best practices.
        /// </summary>
        [pbr::OriginalName("INFO")] Info = 1,
        /// <summary>
        /// The agent may not behave as expected.
        /// </summary>
        [pbr::OriginalName("WARNING")] Warning = 2,
        /// <summary>
        /// The agent may experience partial failures.
        /// </summary>
        [pbr::OriginalName("ERROR")] Error = 3,
        /// <summary>
        /// The agent may completely fail.
        /// </summary>
        [pbr::OriginalName("CRITICAL")] Critical = 4,
      }

    }
    #endregion

  }

  /// <summary>
  /// Represents the output of agent validation.
  /// </summary>
  public sealed partial class ValidationResult : pb::IMessage<ValidationResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ValidationResult> _parser = new pb::MessageParser<ValidationResult>(() => new ValidationResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ValidationResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dialogflow.V2.ValidationResultReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationResult(ValidationResult other) : this() {
      validationErrors_ = other.validationErrors_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationResult Clone() {
      return new ValidationResult(this);
    }

    /// <summary>Field number for the "validation_errors" field.</summary>
    public const int ValidationErrorsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Cloud.Dialogflow.V2.ValidationError> _repeated_validationErrors_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Cloud.Dialogflow.V2.ValidationError.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.ValidationError> validationErrors_ = new pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.ValidationError>();
    /// <summary>
    /// Contains all validation errors.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.ValidationError> ValidationErrors {
      get { return validationErrors_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ValidationResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ValidationResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!validationErrors_.Equals(other.validationErrors_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= validationErrors_.GetHashCode();
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
      validationErrors_.WriteTo(output, _repeated_validationErrors_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      validationErrors_.WriteTo(ref output, _repeated_validationErrors_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += validationErrors_.CalculateSize(_repeated_validationErrors_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ValidationResult other) {
      if (other == null) {
        return;
      }
      validationErrors_.Add(other.validationErrors_);
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
            validationErrors_.AddEntriesFrom(input, _repeated_validationErrors_codec);
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
            validationErrors_.AddEntriesFrom(ref input, _repeated_validationErrors_codec);
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
