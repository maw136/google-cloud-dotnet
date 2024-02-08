// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/discoveryengine/v1/completion.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DiscoveryEngine.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/discoveryengine/v1/completion.proto</summary>
  public static partial class CompletionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/discoveryengine/v1/completion.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompletionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvY2xvdWQvZGlzY292ZXJ5ZW5naW5lL3YxL2NvbXBsZXRpb24u",
            "cHJvdG8SH2dvb2dsZS5jbG91ZC5kaXNjb3ZlcnllbmdpbmUudjEaH2dvb2ds",
            "ZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8i6QEKF1N1Z2dlc3Rpb25EZW55",
            "TGlzdEVudHJ5EhkKDGJsb2NrX3BocmFzZRgBIAEoCUID4EECEmMKDm1hdGNo",
            "X29wZXJhdG9yGAIgASgOMkYuZ29vZ2xlLmNsb3VkLmRpc2NvdmVyeWVuZ2lu",
            "ZS52MS5TdWdnZXN0aW9uRGVueUxpc3RFbnRyeS5NYXRjaE9wZXJhdG9yQgPg",
            "QQIiTgoNTWF0Y2hPcGVyYXRvchIeChpNQVRDSF9PUEVSQVRPUl9VTlNQRUNJ",
            "RklFRBAAEg8KC0VYQUNUX01BVENIEAESDAoIQ09OVEFJTlMQAkKCAgojY29t",
            "Lmdvb2dsZS5jbG91ZC5kaXNjb3ZlcnllbmdpbmUudjFCD0NvbXBsZXRpb25Q",
            "cm90b1ABWk1jbG91ZC5nb29nbGUuY29tL2dvL2Rpc2NvdmVyeWVuZ2luZS9h",
            "cGl2MS9kaXNjb3ZlcnllbmdpbmVwYjtkaXNjb3ZlcnllbmdpbmVwYqICD0RJ",
            "U0NPVkVSWUVOR0lORaoCH0dvb2dsZS5DbG91ZC5EaXNjb3ZlcnlFbmdpbmUu",
            "VjHKAh9Hb29nbGVcQ2xvdWRcRGlzY292ZXJ5RW5naW5lXFYx6gIiR29vZ2xl",
            "OjpDbG91ZDo6RGlzY292ZXJ5RW5naW5lOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry), global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Parser, new[]{ "BlockPhrase", "MatchOperator" }, null, new[]{ typeof(global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Types.MatchOperator) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Suggestion deny list entry identifying the phrase to block from suggestions
  /// and the applied operation for the phrase.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SuggestionDenyListEntry : pb::IMessage<SuggestionDenyListEntry>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SuggestionDenyListEntry> _parser = new pb::MessageParser<SuggestionDenyListEntry>(() => new SuggestionDenyListEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SuggestionDenyListEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DiscoveryEngine.V1.CompletionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestionDenyListEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestionDenyListEntry(SuggestionDenyListEntry other) : this() {
      blockPhrase_ = other.blockPhrase_;
      matchOperator_ = other.matchOperator_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestionDenyListEntry Clone() {
      return new SuggestionDenyListEntry(this);
    }

    /// <summary>Field number for the "block_phrase" field.</summary>
    public const int BlockPhraseFieldNumber = 1;
    private string blockPhrase_ = "";
    /// <summary>
    /// Required. Phrase to block from suggestions served. Can be maximum 125
    /// characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BlockPhrase {
      get { return blockPhrase_; }
      set {
        blockPhrase_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "match_operator" field.</summary>
    public const int MatchOperatorFieldNumber = 2;
    private global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Types.MatchOperator matchOperator_ = global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Types.MatchOperator.Unspecified;
    /// <summary>
    /// Required. The match operator to apply for this phrase. Whether to block the
    /// exact phrase, or block any suggestions containing this phrase.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Types.MatchOperator MatchOperator {
      get { return matchOperator_; }
      set {
        matchOperator_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SuggestionDenyListEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SuggestionDenyListEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BlockPhrase != other.BlockPhrase) return false;
      if (MatchOperator != other.MatchOperator) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BlockPhrase.Length != 0) hash ^= BlockPhrase.GetHashCode();
      if (MatchOperator != global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Types.MatchOperator.Unspecified) hash ^= MatchOperator.GetHashCode();
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
      if (BlockPhrase.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BlockPhrase);
      }
      if (MatchOperator != global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Types.MatchOperator.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) MatchOperator);
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
      if (BlockPhrase.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BlockPhrase);
      }
      if (MatchOperator != global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Types.MatchOperator.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) MatchOperator);
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
      if (BlockPhrase.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BlockPhrase);
      }
      if (MatchOperator != global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Types.MatchOperator.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MatchOperator);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SuggestionDenyListEntry other) {
      if (other == null) {
        return;
      }
      if (other.BlockPhrase.Length != 0) {
        BlockPhrase = other.BlockPhrase;
      }
      if (other.MatchOperator != global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Types.MatchOperator.Unspecified) {
        MatchOperator = other.MatchOperator;
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
            BlockPhrase = input.ReadString();
            break;
          }
          case 16: {
            MatchOperator = (global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Types.MatchOperator) input.ReadEnum();
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
            BlockPhrase = input.ReadString();
            break;
          }
          case 16: {
            MatchOperator = (global::Google.Cloud.DiscoveryEngine.V1.SuggestionDenyListEntry.Types.MatchOperator) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the SuggestionDenyListEntry message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Operator for matching with the generated suggestions.
      /// </summary>
      public enum MatchOperator {
        /// <summary>
        /// Default value. Should not be used
        /// </summary>
        [pbr::OriginalName("MATCH_OPERATOR_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// If the suggestion is an exact match to the block_phrase, then block it.
        /// </summary>
        [pbr::OriginalName("EXACT_MATCH")] ExactMatch = 1,
        /// <summary>
        /// If the suggestion contains the block_phrase, then block it.
        /// </summary>
        [pbr::OriginalName("CONTAINS")] Contains = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
