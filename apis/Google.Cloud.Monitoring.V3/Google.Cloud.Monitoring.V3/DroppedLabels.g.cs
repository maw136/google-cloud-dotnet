// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/monitoring/v3/dropped_labels.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Monitoring.V3 {

  /// <summary>Holder for reflection information generated from google/monitoring/v3/dropped_labels.proto</summary>
  public static partial class DroppedLabelsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/monitoring/v3/dropped_labels.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DroppedLabelsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvbW9uaXRvcmluZy92My9kcm9wcGVkX2xhYmVscy5wcm90bxIU",
            "Z29vZ2xlLm1vbml0b3JpbmcudjMifAoNRHJvcHBlZExhYmVscxI9CgVsYWJl",
            "bBgBIAMoCzIuLmdvb2dsZS5tb25pdG9yaW5nLnYzLkRyb3BwZWRMYWJlbHMu",
            "TGFiZWxFbnRyeRosCgpMYWJlbEVudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1",
            "ZRgCIAEoCToCOAFCzQEKGGNvbS5nb29nbGUubW9uaXRvcmluZy52M0ISRHJv",
            "cHBlZExhYmVsc1Byb3RvUAFaQWNsb3VkLmdvb2dsZS5jb20vZ28vbW9uaXRv",
            "cmluZy9hcGl2My92Mi9tb25pdG9yaW5ncGI7bW9uaXRvcmluZ3BiqgIaR29v",
            "Z2xlLkNsb3VkLk1vbml0b3JpbmcuVjPKAhpHb29nbGVcQ2xvdWRcTW9uaXRv",
            "cmluZ1xWM+oCHUdvb2dsZTo6Q2xvdWQ6Ok1vbml0b3Jpbmc6OlYzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Monitoring.V3.DroppedLabels), global::Google.Cloud.Monitoring.V3.DroppedLabels.Parser, new[]{ "Label" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A set of (label, value) pairs that were removed from a Distribution
  /// time series during aggregation and then added as an attachment to a
  /// Distribution.Exemplar.
  ///
  /// The full label set for the exemplars is constructed by using the dropped
  /// pairs in combination with the label values that remain on the aggregated
  /// Distribution time series. The constructed full label set can be used to
  /// identify the specific entity, such as the instance or job, which might be
  /// contributing to a long-tail. However, with dropped labels, the storage
  /// requirements are reduced because only the aggregated distribution values for
  /// a large group of time series are stored.
  ///
  /// Note that there are no guarantees on ordering of the labels from
  /// exemplar-to-exemplar and from distribution-to-distribution in the same
  /// stream, and there may be duplicates.  It is up to clients to resolve any
  /// ambiguities.
  /// </summary>
  public sealed partial class DroppedLabels : pb::IMessage<DroppedLabels>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DroppedLabels> _parser = new pb::MessageParser<DroppedLabels>(() => new DroppedLabels());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DroppedLabels> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Monitoring.V3.DroppedLabelsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DroppedLabels() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DroppedLabels(DroppedLabels other) : this() {
      label_ = other.label_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DroppedLabels Clone() {
      return new DroppedLabels(this);
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 1;
    private static readonly pbc::MapField<string, string>.Codec _map_label_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 10);
    private readonly pbc::MapField<string, string> label_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Map from label to its value, for all labels dropped in any aggregation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Label {
      get { return label_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DroppedLabels);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DroppedLabels other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Label.Equals(other.Label)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Label.GetHashCode();
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
      label_.WriteTo(output, _map_label_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      label_.WriteTo(ref output, _map_label_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += label_.CalculateSize(_map_label_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DroppedLabels other) {
      if (other == null) {
        return;
      }
      label_.MergeFrom(other.label_);
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
            label_.AddEntriesFrom(input, _map_label_codec);
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
            label_.AddEntriesFrom(ref input, _map_label_codec);
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
