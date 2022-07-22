// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/run/v2/traffic_target.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Run.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/run/v2/traffic_target.proto</summary>
  public static partial class TrafficTargetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/run/v2/traffic_target.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrafficTargetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvcnVuL3YyL3RyYWZmaWNfdGFyZ2V0LnByb3RvEhNn",
            "b29nbGUuY2xvdWQucnVuLnYyGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3Rv",
            "IqEBCg1UcmFmZmljVGFyZ2V0Ej4KBHR5cGUYASABKA4yMC5nb29nbGUuY2xv",
            "dWQucnVuLnYyLlRyYWZmaWNUYXJnZXRBbGxvY2F0aW9uVHlwZRIyCghyZXZp",
            "c2lvbhgCIAEoCUIg+kEdChtydW4uZ29vZ2xlYXBpcy5jb20vUmV2aXNpb24S",
            "DwoHcGVyY2VudBgDIAEoBRILCgN0YWcYBCABKAkitAEKE1RyYWZmaWNUYXJn",
            "ZXRTdGF0dXMSPgoEdHlwZRgBIAEoDjIwLmdvb2dsZS5jbG91ZC5ydW4udjIu",
            "VHJhZmZpY1RhcmdldEFsbG9jYXRpb25UeXBlEjIKCHJldmlzaW9uGAIgASgJ",
            "QiD6QR0KG3J1bi5nb29nbGVhcGlzLmNvbS9SZXZpc2lvbhIPCgdwZXJjZW50",
            "GAMgASgFEgsKA3RhZxgEIAEoCRILCgN1cmkYBSABKAkqpQEKG1RyYWZmaWNU",
            "YXJnZXRBbGxvY2F0aW9uVHlwZRIuCipUUkFGRklDX1RBUkdFVF9BTExPQ0FU",
            "SU9OX1RZUEVfVU5TUEVDSUZJRUQQABIpCiVUUkFGRklDX1RBUkdFVF9BTExP",
            "Q0FUSU9OX1RZUEVfTEFURVNUEAESKwonVFJBRkZJQ19UQVJHRVRfQUxMT0NB",
            "VElPTl9UWVBFX1JFVklTSU9OEAJCZwoXY29tLmdvb2dsZS5jbG91ZC5ydW4u",
            "djJCElRyYWZmaWNUYXJnZXRQcm90b1ABWjZnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL3J1bi92MjtydW5iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.Run.V2.TrafficTargetAllocationType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Run.V2.TrafficTarget), global::Google.Cloud.Run.V2.TrafficTarget.Parser, new[]{ "Type", "Revision", "Percent", "Tag" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Run.V2.TrafficTargetStatus), global::Google.Cloud.Run.V2.TrafficTargetStatus.Parser, new[]{ "Type", "Revision", "Percent", "Tag", "Uri" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The type of instance allocation.
  /// </summary>
  public enum TrafficTargetAllocationType {
    /// <summary>
    /// Unspecified instance allocation type.
    /// </summary>
    [pbr::OriginalName("TRAFFIC_TARGET_ALLOCATION_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Allocates instances to the Service's latest ready Revision.
    /// </summary>
    [pbr::OriginalName("TRAFFIC_TARGET_ALLOCATION_TYPE_LATEST")] Latest = 1,
    /// <summary>
    /// Allocates instances to a Revision by name.
    /// </summary>
    [pbr::OriginalName("TRAFFIC_TARGET_ALLOCATION_TYPE_REVISION")] Revision = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Holds a single traffic routing entry for the Service. Allocations can be done
  /// to a specific Revision name, or pointing to the latest Ready Revision.
  /// </summary>
  public sealed partial class TrafficTarget : pb::IMessage<TrafficTarget>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrafficTarget> _parser = new pb::MessageParser<TrafficTarget>(() => new TrafficTarget());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrafficTarget> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Run.V2.TrafficTargetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrafficTarget() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrafficTarget(TrafficTarget other) : this() {
      type_ = other.type_;
      revision_ = other.revision_;
      percent_ = other.percent_;
      tag_ = other.tag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrafficTarget Clone() {
      return new TrafficTarget(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Google.Cloud.Run.V2.TrafficTargetAllocationType type_ = global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified;
    /// <summary>
    /// The allocation type for this traffic target.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Run.V2.TrafficTargetAllocationType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "revision" field.</summary>
    public const int RevisionFieldNumber = 2;
    private string revision_ = "";
    /// <summary>
    /// Revision to which to send this portion of traffic, if traffic allocation is
    /// by revision.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Revision {
      get { return revision_; }
      set {
        revision_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "percent" field.</summary>
    public const int PercentFieldNumber = 3;
    private int percent_;
    /// <summary>
    /// Specifies percent of the traffic to this Revision.
    /// This defaults to zero if unspecified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Percent {
      get { return percent_; }
      set {
        percent_ = value;
      }
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 4;
    private string tag_ = "";
    /// <summary>
    /// Indicates a string to be part of the URI to exclusively reference this
    /// target.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrafficTarget);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrafficTarget other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Revision != other.Revision) return false;
      if (Percent != other.Percent) return false;
      if (Tag != other.Tag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified) hash ^= Type.GetHashCode();
      if (Revision.Length != 0) hash ^= Revision.GetHashCode();
      if (Percent != 0) hash ^= Percent.GetHashCode();
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
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
      if (Type != global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Revision.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Revision);
      }
      if (Percent != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Percent);
      }
      if (Tag.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Tag);
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
      if (Type != global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Revision.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Revision);
      }
      if (Percent != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Percent);
      }
      if (Tag.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Tag);
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
      if (Type != global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Revision.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Revision);
      }
      if (Percent != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Percent);
      }
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrafficTarget other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified) {
        Type = other.Type;
      }
      if (other.Revision.Length != 0) {
        Revision = other.Revision;
      }
      if (other.Percent != 0) {
        Percent = other.Percent;
      }
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
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
            Type = (global::Google.Cloud.Run.V2.TrafficTargetAllocationType) input.ReadEnum();
            break;
          }
          case 18: {
            Revision = input.ReadString();
            break;
          }
          case 24: {
            Percent = input.ReadInt32();
            break;
          }
          case 34: {
            Tag = input.ReadString();
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
            Type = (global::Google.Cloud.Run.V2.TrafficTargetAllocationType) input.ReadEnum();
            break;
          }
          case 18: {
            Revision = input.ReadString();
            break;
          }
          case 24: {
            Percent = input.ReadInt32();
            break;
          }
          case 34: {
            Tag = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Represents the observed state of a single `TrafficTarget` entry.
  /// </summary>
  public sealed partial class TrafficTargetStatus : pb::IMessage<TrafficTargetStatus>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrafficTargetStatus> _parser = new pb::MessageParser<TrafficTargetStatus>(() => new TrafficTargetStatus());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrafficTargetStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Run.V2.TrafficTargetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrafficTargetStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrafficTargetStatus(TrafficTargetStatus other) : this() {
      type_ = other.type_;
      revision_ = other.revision_;
      percent_ = other.percent_;
      tag_ = other.tag_;
      uri_ = other.uri_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrafficTargetStatus Clone() {
      return new TrafficTargetStatus(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Google.Cloud.Run.V2.TrafficTargetAllocationType type_ = global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified;
    /// <summary>
    /// The allocation type for this traffic target.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Run.V2.TrafficTargetAllocationType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "revision" field.</summary>
    public const int RevisionFieldNumber = 2;
    private string revision_ = "";
    /// <summary>
    /// Revision to which this traffic is sent.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Revision {
      get { return revision_; }
      set {
        revision_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "percent" field.</summary>
    public const int PercentFieldNumber = 3;
    private int percent_;
    /// <summary>
    /// Specifies percent of the traffic to this Revision.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Percent {
      get { return percent_; }
      set {
        percent_ = value;
      }
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 4;
    private string tag_ = "";
    /// <summary>
    /// Indicates the string used in the URI to exclusively reference this target.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uri" field.</summary>
    public const int UriFieldNumber = 5;
    private string uri_ = "";
    /// <summary>
    /// Displays the target URI.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Uri {
      get { return uri_; }
      set {
        uri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrafficTargetStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrafficTargetStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Revision != other.Revision) return false;
      if (Percent != other.Percent) return false;
      if (Tag != other.Tag) return false;
      if (Uri != other.Uri) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified) hash ^= Type.GetHashCode();
      if (Revision.Length != 0) hash ^= Revision.GetHashCode();
      if (Percent != 0) hash ^= Percent.GetHashCode();
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
      if (Uri.Length != 0) hash ^= Uri.GetHashCode();
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
      if (Type != global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Revision.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Revision);
      }
      if (Percent != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Percent);
      }
      if (Tag.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Tag);
      }
      if (Uri.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Uri);
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
      if (Type != global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Revision.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Revision);
      }
      if (Percent != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Percent);
      }
      if (Tag.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Tag);
      }
      if (Uri.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Uri);
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
      if (Type != global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Revision.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Revision);
      }
      if (Percent != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Percent);
      }
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (Uri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrafficTargetStatus other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::Google.Cloud.Run.V2.TrafficTargetAllocationType.Unspecified) {
        Type = other.Type;
      }
      if (other.Revision.Length != 0) {
        Revision = other.Revision;
      }
      if (other.Percent != 0) {
        Percent = other.Percent;
      }
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
      }
      if (other.Uri.Length != 0) {
        Uri = other.Uri;
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
            Type = (global::Google.Cloud.Run.V2.TrafficTargetAllocationType) input.ReadEnum();
            break;
          }
          case 18: {
            Revision = input.ReadString();
            break;
          }
          case 24: {
            Percent = input.ReadInt32();
            break;
          }
          case 34: {
            Tag = input.ReadString();
            break;
          }
          case 42: {
            Uri = input.ReadString();
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
            Type = (global::Google.Cloud.Run.V2.TrafficTargetAllocationType) input.ReadEnum();
            break;
          }
          case 18: {
            Revision = input.ReadString();
            break;
          }
          case 24: {
            Percent = input.ReadInt32();
            break;
          }
          case 34: {
            Tag = input.ReadString();
            break;
          }
          case 42: {
            Uri = input.ReadString();
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
