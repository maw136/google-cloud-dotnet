// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/addressvalidation/v1/metadata.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.AddressValidation.V1 {

  /// <summary>Holder for reflection information generated from google/maps/addressvalidation/v1/metadata.proto</summary>
  public static partial class MetadataReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/addressvalidation/v1/metadata.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetadataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvbWFwcy9hZGRyZXNzdmFsaWRhdGlvbi92MS9tZXRhZGF0YS5w",
            "cm90bxIgZ29vZ2xlLm1hcHMuYWRkcmVzc3ZhbGlkYXRpb24udjEifwoPQWRk",
            "cmVzc01ldGFkYXRhEhUKCGJ1c2luZXNzGAIgASgISACIAQESEwoGcG9fYm94",
            "GAMgASgISAGIAQESGAoLcmVzaWRlbnRpYWwYBiABKAhIAogBAUILCglfYnVz",
            "aW5lc3NCCQoHX3BvX2JveEIOCgxfcmVzaWRlbnRpYWxCigIKJGNvbS5nb29n",
            "bGUubWFwcy5hZGRyZXNzdmFsaWRhdGlvbi52MUINTWV0YWRhdGFQcm90b1AB",
            "WlhjbG91ZC5nb29nbGUuY29tL2dvL21hcHMvYWRkcmVzc3ZhbGlkYXRpb24v",
            "YXBpdjEvYWRkcmVzc3ZhbGlkYXRpb25wYjthZGRyZXNzdmFsaWRhdGlvbnBi",
            "+AEBogIHR01QQVZWMaoCIEdvb2dsZS5NYXBzLkFkZHJlc3NWYWxpZGF0aW9u",
            "LlYxygIgR29vZ2xlXE1hcHNcQWRkcmVzc1ZhbGlkYXRpb25cVjHqAiNHb29n",
            "bGU6Ok1hcHM6OkFkZHJlc3NWYWxpZGF0aW9uOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.AddressValidation.V1.AddressMetadata), global::Google.Maps.AddressValidation.V1.AddressMetadata.Parser, new[]{ "Business", "PoBox", "Residential" }, new[]{ "Business", "PoBox", "Residential" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The metadata for the address.
  /// </summary>
  public sealed partial class AddressMetadata : pb::IMessage<AddressMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddressMetadata> _parser = new pb::MessageParser<AddressMetadata>(() => new AddressMetadata());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AddressMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.AddressValidation.V1.MetadataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressMetadata(AddressMetadata other) : this() {
      _hasBits0 = other._hasBits0;
      business_ = other.business_;
      poBox_ = other.poBox_;
      residential_ = other.residential_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressMetadata Clone() {
      return new AddressMetadata(this);
    }

    /// <summary>Field number for the "business" field.</summary>
    public const int BusinessFieldNumber = 2;
    private bool business_;
    /// <summary>
    /// Indicates that this is the address of a business.
    /// If unset, indicates that the value is unknown.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Business {
      get { if ((_hasBits0 & 1) != 0) { return business_; } else { return false; } }
      set {
        _hasBits0 |= 1;
        business_ = value;
      }
    }
    /// <summary>Gets whether the "business" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasBusiness {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "business" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBusiness() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "po_box" field.</summary>
    public const int PoBoxFieldNumber = 3;
    private bool poBox_;
    /// <summary>
    /// Indicates that the address of a PO box.
    /// If unset, indicates that the value is unknown.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PoBox {
      get { if ((_hasBits0 & 2) != 0) { return poBox_; } else { return false; } }
      set {
        _hasBits0 |= 2;
        poBox_ = value;
      }
    }
    /// <summary>Gets whether the "po_box" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPoBox {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "po_box" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPoBox() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "residential" field.</summary>
    public const int ResidentialFieldNumber = 6;
    private bool residential_;
    /// <summary>
    /// Indicates that this is the address of a residence.
    /// If unset, indicates that the value is unknown.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Residential {
      get { if ((_hasBits0 & 4) != 0) { return residential_; } else { return false; } }
      set {
        _hasBits0 |= 4;
        residential_ = value;
      }
    }
    /// <summary>Gets whether the "residential" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasResidential {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "residential" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearResidential() {
      _hasBits0 &= ~4;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AddressMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AddressMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Business != other.Business) return false;
      if (PoBox != other.PoBox) return false;
      if (Residential != other.Residential) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasBusiness) hash ^= Business.GetHashCode();
      if (HasPoBox) hash ^= PoBox.GetHashCode();
      if (HasResidential) hash ^= Residential.GetHashCode();
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
      if (HasBusiness) {
        output.WriteRawTag(16);
        output.WriteBool(Business);
      }
      if (HasPoBox) {
        output.WriteRawTag(24);
        output.WriteBool(PoBox);
      }
      if (HasResidential) {
        output.WriteRawTag(48);
        output.WriteBool(Residential);
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
      if (HasBusiness) {
        output.WriteRawTag(16);
        output.WriteBool(Business);
      }
      if (HasPoBox) {
        output.WriteRawTag(24);
        output.WriteBool(PoBox);
      }
      if (HasResidential) {
        output.WriteRawTag(48);
        output.WriteBool(Residential);
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
      if (HasBusiness) {
        size += 1 + 1;
      }
      if (HasPoBox) {
        size += 1 + 1;
      }
      if (HasResidential) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AddressMetadata other) {
      if (other == null) {
        return;
      }
      if (other.HasBusiness) {
        Business = other.Business;
      }
      if (other.HasPoBox) {
        PoBox = other.PoBox;
      }
      if (other.HasResidential) {
        Residential = other.Residential;
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
          case 16: {
            Business = input.ReadBool();
            break;
          }
          case 24: {
            PoBox = input.ReadBool();
            break;
          }
          case 48: {
            Residential = input.ReadBool();
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
          case 16: {
            Business = input.ReadBool();
            break;
          }
          case 24: {
            PoBox = input.ReadBool();
            break;
          }
          case 48: {
            Residential = input.ReadBool();
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
