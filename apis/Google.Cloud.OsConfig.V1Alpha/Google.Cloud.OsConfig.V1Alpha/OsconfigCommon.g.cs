// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/osconfig/v1alpha/osconfig_common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.OsConfig.V1Alpha {

  /// <summary>Holder for reflection information generated from google/cloud/osconfig/v1alpha/osconfig_common.proto</summary>
  public static partial class OsconfigCommonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/osconfig/v1alpha/osconfig_common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OsconfigCommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvb3Njb25maWcvdjFhbHBoYS9vc2NvbmZpZ19jb21t",
            "b24ucHJvdG8SHWdvb2dsZS5jbG91ZC5vc2NvbmZpZy52MWFscGhhIjwKDkZp",
            "eGVkT3JQZXJjZW50Eg8KBWZpeGVkGAEgASgFSAASEQoHcGVyY2VudBgCIAEo",
            "BUgAQgYKBG1vZGVCzwEKIWNvbS5nb29nbGUuY2xvdWQub3Njb25maWcudjFh",
            "bHBoYUIGQ29tbW9uUAFaPWNsb3VkLmdvb2dsZS5jb20vZ28vb3Njb25maWcv",
            "YXBpdjFhbHBoYS9vc2NvbmZpZ3BiO29zY29uZmlncGKqAh1Hb29nbGUuQ2xv",
            "dWQuT3NDb25maWcuVjFBbHBoYcoCHUdvb2dsZVxDbG91ZFxPc0NvbmZpZ1xW",
            "MWFscGhh6gIgR29vZ2xlOjpDbG91ZDo6T3NDb25maWc6OlYxYWxwaGFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.OsConfig.V1Alpha.FixedOrPercent), global::Google.Cloud.OsConfig.V1Alpha.FixedOrPercent.Parser, new[]{ "Fixed", "Percent" }, new[]{ "Mode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message encapsulating a value that can be either absolute ("fixed") or
  /// relative ("percent") to a value.
  /// </summary>
  public sealed partial class FixedOrPercent : pb::IMessage<FixedOrPercent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FixedOrPercent> _parser = new pb::MessageParser<FixedOrPercent>(() => new FixedOrPercent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FixedOrPercent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.OsConfig.V1Alpha.OsconfigCommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FixedOrPercent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FixedOrPercent(FixedOrPercent other) : this() {
      switch (other.ModeCase) {
        case ModeOneofCase.Fixed:
          Fixed = other.Fixed;
          break;
        case ModeOneofCase.Percent:
          Percent = other.Percent;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FixedOrPercent Clone() {
      return new FixedOrPercent(this);
    }

    /// <summary>Field number for the "fixed" field.</summary>
    public const int FixedFieldNumber = 1;
    /// <summary>
    /// Specifies a fixed value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Fixed {
      get { return modeCase_ == ModeOneofCase.Fixed ? (int) mode_ : 0; }
      set {
        mode_ = value;
        modeCase_ = ModeOneofCase.Fixed;
      }
    }

    /// <summary>Field number for the "percent" field.</summary>
    public const int PercentFieldNumber = 2;
    /// <summary>
    /// Specifies the relative value defined as a percentage, which will be
    /// multiplied by a reference value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Percent {
      get { return modeCase_ == ModeOneofCase.Percent ? (int) mode_ : 0; }
      set {
        mode_ = value;
        modeCase_ = ModeOneofCase.Percent;
      }
    }

    private object mode_;
    /// <summary>Enum of possible cases for the "mode" oneof.</summary>
    public enum ModeOneofCase {
      None = 0,
      Fixed = 1,
      Percent = 2,
    }
    private ModeOneofCase modeCase_ = ModeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModeOneofCase ModeCase {
      get { return modeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMode() {
      modeCase_ = ModeOneofCase.None;
      mode_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FixedOrPercent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FixedOrPercent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Fixed != other.Fixed) return false;
      if (Percent != other.Percent) return false;
      if (ModeCase != other.ModeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (modeCase_ == ModeOneofCase.Fixed) hash ^= Fixed.GetHashCode();
      if (modeCase_ == ModeOneofCase.Percent) hash ^= Percent.GetHashCode();
      hash ^= (int) modeCase_;
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
      if (modeCase_ == ModeOneofCase.Fixed) {
        output.WriteRawTag(8);
        output.WriteInt32(Fixed);
      }
      if (modeCase_ == ModeOneofCase.Percent) {
        output.WriteRawTag(16);
        output.WriteInt32(Percent);
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
      if (modeCase_ == ModeOneofCase.Fixed) {
        output.WriteRawTag(8);
        output.WriteInt32(Fixed);
      }
      if (modeCase_ == ModeOneofCase.Percent) {
        output.WriteRawTag(16);
        output.WriteInt32(Percent);
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
      if (modeCase_ == ModeOneofCase.Fixed) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fixed);
      }
      if (modeCase_ == ModeOneofCase.Percent) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Percent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FixedOrPercent other) {
      if (other == null) {
        return;
      }
      switch (other.ModeCase) {
        case ModeOneofCase.Fixed:
          Fixed = other.Fixed;
          break;
        case ModeOneofCase.Percent:
          Percent = other.Percent;
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
          case 8: {
            Fixed = input.ReadInt32();
            break;
          }
          case 16: {
            Percent = input.ReadInt32();
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
            Fixed = input.ReadInt32();
            break;
          }
          case 16: {
            Percent = input.ReadInt32();
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
