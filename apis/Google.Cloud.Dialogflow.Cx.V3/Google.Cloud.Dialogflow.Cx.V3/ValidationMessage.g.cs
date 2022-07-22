// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/cx/v3/validation_message.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Dialogflow.Cx.V3 {

  /// <summary>Holder for reflection information generated from google/cloud/dialogflow/cx/v3/validation_message.proto</summary>
  public static partial class ValidationMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/dialogflow/cx/v3/validation_message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValidationMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvY2xvdWQvZGlhbG9nZmxvdy9jeC92My92YWxpZGF0aW9uX21l",
            "c3NhZ2UucHJvdG8SHWdvb2dsZS5jbG91ZC5kaWFsb2dmbG93LmN4LnYzIvgE",
            "ChFWYWxpZGF0aW9uTWVzc2FnZRJUCg1yZXNvdXJjZV90eXBlGAEgASgOMj0u",
            "Z29vZ2xlLmNsb3VkLmRpYWxvZ2Zsb3cuY3gudjMuVmFsaWRhdGlvbk1lc3Nh",
            "Z2UuUmVzb3VyY2VUeXBlEhUKCXJlc291cmNlcxgCIAMoCUICGAESQwoOcmVz",
            "b3VyY2VfbmFtZXMYBiADKAsyKy5nb29nbGUuY2xvdWQuZGlhbG9nZmxvdy5j",
            "eC52My5SZXNvdXJjZU5hbWUSSwoIc2V2ZXJpdHkYAyABKA4yOS5nb29nbGUu",
            "Y2xvdWQuZGlhbG9nZmxvdy5jeC52My5WYWxpZGF0aW9uTWVzc2FnZS5TZXZl",
            "cml0eRIOCgZkZXRhaWwYBCABKAkiiwIKDFJlc291cmNlVHlwZRIdChlSRVNP",
            "VVJDRV9UWVBFX1VOU1BFQ0lGSUVEEAASCQoFQUdFTlQQARIKCgZJTlRFTlQQ",
            "AhIaChZJTlRFTlRfVFJBSU5JTkdfUEhSQVNFEAgSFAoQSU5URU5UX1BBUkFN",
            "RVRFUhAJEgsKB0lOVEVOVFMQChIbChdJTlRFTlRfVFJBSU5JTkdfUEhSQVNF",
            "UxALEg8KC0VOVElUWV9UWVBFEAMSEAoMRU5USVRZX1RZUEVTEAwSCwoHV0VC",
            "SE9PSxAEEggKBEZMT1cQBRIICgRQQUdFEAYSCQoFUEFHRVMQDRIaChZUUkFO",
            "U0lUSU9OX1JPVVRFX0dST1VQEAciRgoIU2V2ZXJpdHkSGAoUU0VWRVJJVFlf",
            "VU5TUEVDSUZJRUQQABIICgRJTkZPEAESCwoHV0FSTklORxACEgkKBUVSUk9S",
            "EAMiMgoMUmVzb3VyY2VOYW1lEgwKBG5hbWUYASABKAkSFAoMZGlzcGxheV9u",
            "YW1lGAIgASgJQsoBCiFjb20uZ29vZ2xlLmNsb3VkLmRpYWxvZ2Zsb3cuY3gu",
            "djNCFlZhbGlkYXRpb25NZXNzYWdlUHJvdG9QAVo/Z29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9kaWFsb2dmbG93L2N4L3Yz",
            "O2N4+AEBogICREaqAh1Hb29nbGUuQ2xvdWQuRGlhbG9nZmxvdy5DeC5WM+oC",
            "IUdvb2dsZTo6Q2xvdWQ6OkRpYWxvZ2Zsb3c6OkNYOjpWM2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage), global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Parser, new[]{ "ResourceType", "Resources", "ResourceNames", "Severity", "Detail" }, null, new[]{ typeof(global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.ResourceType), typeof(global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.Severity) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.Cx.V3.ResourceName), global::Google.Cloud.Dialogflow.Cx.V3.ResourceName.Parser, new[]{ "Name", "DisplayName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Agent/flow validation message.
  /// </summary>
  public sealed partial class ValidationMessage : pb::IMessage<ValidationMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ValidationMessage> _parser = new pb::MessageParser<ValidationMessage>(() => new ValidationMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ValidationMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationMessage(ValidationMessage other) : this() {
      resourceType_ = other.resourceType_;
      resources_ = other.resources_.Clone();
      resourceNames_ = other.resourceNames_.Clone();
      severity_ = other.severity_;
      detail_ = other.detail_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValidationMessage Clone() {
      return new ValidationMessage(this);
    }

    /// <summary>Field number for the "resource_type" field.</summary>
    public const int ResourceTypeFieldNumber = 1;
    private global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.ResourceType resourceType_ = global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.ResourceType.Unspecified;
    /// <summary>
    /// The type of the resources where the message is found.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.ResourceType ResourceType {
      get { return resourceType_; }
      set {
        resourceType_ = value;
      }
    }

    /// <summary>Field number for the "resources" field.</summary>
    public const int ResourcesFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_resources_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> resources_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The names of the resources where the message is found.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Resources {
      get { return resources_; }
    }

    /// <summary>Field number for the "resource_names" field.</summary>
    public const int ResourceNamesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Cloud.Dialogflow.Cx.V3.ResourceName> _repeated_resourceNames_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Cloud.Dialogflow.Cx.V3.ResourceName.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Dialogflow.Cx.V3.ResourceName> resourceNames_ = new pbc::RepeatedField<global::Google.Cloud.Dialogflow.Cx.V3.ResourceName>();
    /// <summary>
    /// The resource names of the resources where the message is found.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.Dialogflow.Cx.V3.ResourceName> ResourceNames {
      get { return resourceNames_; }
    }

    /// <summary>Field number for the "severity" field.</summary>
    public const int SeverityFieldNumber = 3;
    private global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.Severity severity_ = global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.Severity.Unspecified;
    /// <summary>
    /// Indicates the severity of the message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.Severity Severity {
      get { return severity_; }
      set {
        severity_ = value;
      }
    }

    /// <summary>Field number for the "detail" field.</summary>
    public const int DetailFieldNumber = 4;
    private string detail_ = "";
    /// <summary>
    /// The message detail.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Detail {
      get { return detail_; }
      set {
        detail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ValidationMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ValidationMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceType != other.ResourceType) return false;
      if(!resources_.Equals(other.resources_)) return false;
      if(!resourceNames_.Equals(other.resourceNames_)) return false;
      if (Severity != other.Severity) return false;
      if (Detail != other.Detail) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceType != global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.ResourceType.Unspecified) hash ^= ResourceType.GetHashCode();
      hash ^= resources_.GetHashCode();
      hash ^= resourceNames_.GetHashCode();
      if (Severity != global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.Severity.Unspecified) hash ^= Severity.GetHashCode();
      if (Detail.Length != 0) hash ^= Detail.GetHashCode();
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
      if (ResourceType != global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.ResourceType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ResourceType);
      }
      resources_.WriteTo(output, _repeated_resources_codec);
      if (Severity != global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.Severity.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Severity);
      }
      if (Detail.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Detail);
      }
      resourceNames_.WriteTo(output, _repeated_resourceNames_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceType != global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.ResourceType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ResourceType);
      }
      resources_.WriteTo(ref output, _repeated_resources_codec);
      if (Severity != global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.Severity.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Severity);
      }
      if (Detail.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Detail);
      }
      resourceNames_.WriteTo(ref output, _repeated_resourceNames_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceType != global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.ResourceType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResourceType);
      }
      size += resources_.CalculateSize(_repeated_resources_codec);
      size += resourceNames_.CalculateSize(_repeated_resourceNames_codec);
      if (Severity != global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.Severity.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Severity);
      }
      if (Detail.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Detail);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ValidationMessage other) {
      if (other == null) {
        return;
      }
      if (other.ResourceType != global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.ResourceType.Unspecified) {
        ResourceType = other.ResourceType;
      }
      resources_.Add(other.resources_);
      resourceNames_.Add(other.resourceNames_);
      if (other.Severity != global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.Severity.Unspecified) {
        Severity = other.Severity;
      }
      if (other.Detail.Length != 0) {
        Detail = other.Detail;
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
            ResourceType = (global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.ResourceType) input.ReadEnum();
            break;
          }
          case 18: {
            resources_.AddEntriesFrom(input, _repeated_resources_codec);
            break;
          }
          case 24: {
            Severity = (global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.Severity) input.ReadEnum();
            break;
          }
          case 34: {
            Detail = input.ReadString();
            break;
          }
          case 50: {
            resourceNames_.AddEntriesFrom(input, _repeated_resourceNames_codec);
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
            ResourceType = (global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.ResourceType) input.ReadEnum();
            break;
          }
          case 18: {
            resources_.AddEntriesFrom(ref input, _repeated_resources_codec);
            break;
          }
          case 24: {
            Severity = (global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessage.Types.Severity) input.ReadEnum();
            break;
          }
          case 34: {
            Detail = input.ReadString();
            break;
          }
          case 50: {
            resourceNames_.AddEntriesFrom(ref input, _repeated_resourceNames_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ValidationMessage message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Resource types.
      /// </summary>
      public enum ResourceType {
        /// <summary>
        /// Unspecified.
        /// </summary>
        [pbr::OriginalName("RESOURCE_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Agent.
        /// </summary>
        [pbr::OriginalName("AGENT")] Agent = 1,
        /// <summary>
        /// Intent.
        /// </summary>
        [pbr::OriginalName("INTENT")] Intent = 2,
        /// <summary>
        /// Intent training phrase.
        /// </summary>
        [pbr::OriginalName("INTENT_TRAINING_PHRASE")] IntentTrainingPhrase = 8,
        /// <summary>
        /// Intent parameter.
        /// </summary>
        [pbr::OriginalName("INTENT_PARAMETER")] IntentParameter = 9,
        /// <summary>
        /// Multiple intents.
        /// </summary>
        [pbr::OriginalName("INTENTS")] Intents = 10,
        /// <summary>
        /// Multiple training phrases.
        /// </summary>
        [pbr::OriginalName("INTENT_TRAINING_PHRASES")] IntentTrainingPhrases = 11,
        /// <summary>
        /// Entity type.
        /// </summary>
        [pbr::OriginalName("ENTITY_TYPE")] EntityType = 3,
        /// <summary>
        /// Multiple entity types.
        /// </summary>
        [pbr::OriginalName("ENTITY_TYPES")] EntityTypes = 12,
        /// <summary>
        /// Webhook.
        /// </summary>
        [pbr::OriginalName("WEBHOOK")] Webhook = 4,
        /// <summary>
        /// Flow.
        /// </summary>
        [pbr::OriginalName("FLOW")] Flow = 5,
        /// <summary>
        /// Page.
        /// </summary>
        [pbr::OriginalName("PAGE")] Page = 6,
        /// <summary>
        /// Multiple pages.
        /// </summary>
        [pbr::OriginalName("PAGES")] Pages = 13,
        /// <summary>
        /// Transition route group.
        /// </summary>
        [pbr::OriginalName("TRANSITION_ROUTE_GROUP")] TransitionRouteGroup = 7,
      }

      /// <summary>
      /// Severity level.
      /// </summary>
      public enum Severity {
        /// <summary>
        /// Unspecified.
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
        /// The agent may experience failures.
        /// </summary>
        [pbr::OriginalName("ERROR")] Error = 3,
      }

    }
    #endregion

  }

  /// <summary>
  /// Resource name and display name.
  /// </summary>
  public sealed partial class ResourceName : pb::IMessage<ResourceName>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResourceName> _parser = new pb::MessageParser<ResourceName>(() => new ResourceName());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResourceName> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dialogflow.Cx.V3.ValidationMessageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceName() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceName(ResourceName other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceName Clone() {
      return new ResourceName(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Display name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResourceName);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResourceName other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
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
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResourceName other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
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
            DisplayName = input.ReadString();
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
            DisplayName = input.ReadString();
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
