// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/documentai/v1/processor_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DocumentAI.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/documentai/v1/processor_type.proto</summary>
  public static partial class ProcessorTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/documentai/v1/processor_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProcessorTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvZG9jdW1lbnRhaS92MS9wcm9jZXNzb3JfdHlwZS5w",
            "cm90bxIaZ29vZ2xlLmNsb3VkLmRvY3VtZW50YWkudjEaHWdvb2dsZS9hcGkv",
            "bGF1bmNoX3N0YWdlLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3Rv",
            "IpMDCg1Qcm9jZXNzb3JUeXBlEgwKBG5hbWUYASABKAkSDAoEdHlwZRgCIAEo",
            "CRIQCghjYXRlZ29yeRgDIAEoCRJTChNhdmFpbGFibGVfbG9jYXRpb25zGAQg",
            "AygLMjYuZ29vZ2xlLmNsb3VkLmRvY3VtZW50YWkudjEuUHJvY2Vzc29yVHlw",
            "ZS5Mb2NhdGlvbkluZm8SFgoOYWxsb3dfY3JlYXRpb24YBiABKAgSLQoMbGF1",
            "bmNoX3N0YWdlGAggASgOMhcuZ29vZ2xlLmFwaS5MYXVuY2hTdGFnZRIcChRz",
            "YW1wbGVfZG9jdW1lbnRfdXJpcxgJIAMoCRojCgxMb2NhdGlvbkluZm8SEwoL",
            "bG9jYXRpb25faWQYASABKAk6depBcgonZG9jdW1lbnRhaS5nb29nbGVhcGlz",
            "LmNvbS9Qcm9jZXNzb3JUeXBlEkdwcm9qZWN0cy97cHJvamVjdH0vbG9jYXRp",
            "b25zL3tsb2NhdGlvbn0vcHJvY2Vzc29yVHlwZXMve3Byb2Nlc3Nvcl90eXBl",
            "fULVAQoeY29tLmdvb2dsZS5jbG91ZC5kb2N1bWVudGFpLnYxQhdEb2N1bWVu",
            "dEFpUHJvY2Vzc29yVHlwZVABWj5jbG91ZC5nb29nbGUuY29tL2dvL2RvY3Vt",
            "ZW50YWkvYXBpdjEvZG9jdW1lbnRhaXBiO2RvY3VtZW50YWlwYqoCGkdvb2ds",
            "ZS5DbG91ZC5Eb2N1bWVudEFJLlYxygIaR29vZ2xlXENsb3VkXERvY3VtZW50",
            "QUlcVjHqAh1Hb29nbGU6OkNsb3VkOjpEb2N1bWVudEFJOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.LaunchStageReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DocumentAI.V1.ProcessorType), global::Google.Cloud.DocumentAI.V1.ProcessorType.Parser, new[]{ "Name", "Type", "Category", "AvailableLocations", "AllowCreation", "LaunchStage", "SampleDocumentUris" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DocumentAI.V1.ProcessorType.Types.LocationInfo), global::Google.Cloud.DocumentAI.V1.ProcessorType.Types.LocationInfo.Parser, new[]{ "LocationId" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A processor type is responsible for performing a certain document
  /// understanding task on a certain type of document.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ProcessorType : pb::IMessage<ProcessorType>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProcessorType> _parser = new pb::MessageParser<ProcessorType>(() => new ProcessorType());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProcessorType> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DocumentAI.V1.ProcessorTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProcessorType() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProcessorType(ProcessorType other) : this() {
      name_ = other.name_;
      type_ = other.type_;
      category_ = other.category_;
      availableLocations_ = other.availableLocations_.Clone();
      allowCreation_ = other.allowCreation_;
      launchStage_ = other.launchStage_;
      sampleDocumentUris_ = other.sampleDocumentUris_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProcessorType Clone() {
      return new ProcessorType(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The resource name of the processor type.
    /// Format: `projects/{project}/processorTypes/{processor_type}`
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
    private string type_ = "";
    /// <summary>
    /// The processor type, such as: `OCR_PROCESSOR`, `INVOICE_PROCESSOR`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 3;
    private string category_ = "";
    /// <summary>
    /// The processor category, used by UI to group processor types.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Category {
      get { return category_; }
      set {
        category_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "available_locations" field.</summary>
    public const int AvailableLocationsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Cloud.DocumentAI.V1.ProcessorType.Types.LocationInfo> _repeated_availableLocations_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Cloud.DocumentAI.V1.ProcessorType.Types.LocationInfo.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.DocumentAI.V1.ProcessorType.Types.LocationInfo> availableLocations_ = new pbc::RepeatedField<global::Google.Cloud.DocumentAI.V1.ProcessorType.Types.LocationInfo>();
    /// <summary>
    /// The locations in which this processor is available.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.DocumentAI.V1.ProcessorType.Types.LocationInfo> AvailableLocations {
      get { return availableLocations_; }
    }

    /// <summary>Field number for the "allow_creation" field.</summary>
    public const int AllowCreationFieldNumber = 6;
    private bool allowCreation_;
    /// <summary>
    /// Whether the processor type allows creation. If true, users can create a
    /// processor of this processor type. Otherwise, users need to request access.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AllowCreation {
      get { return allowCreation_; }
      set {
        allowCreation_ = value;
      }
    }

    /// <summary>Field number for the "launch_stage" field.</summary>
    public const int LaunchStageFieldNumber = 8;
    private global::Google.Api.LaunchStage launchStage_ = global::Google.Api.LaunchStage.Unspecified;
    /// <summary>
    /// Launch stage of the processor type
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Api.LaunchStage LaunchStage {
      get { return launchStage_; }
      set {
        launchStage_ = value;
      }
    }

    /// <summary>Field number for the "sample_document_uris" field.</summary>
    public const int SampleDocumentUrisFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _repeated_sampleDocumentUris_codec
        = pb::FieldCodec.ForString(74);
    private readonly pbc::RepeatedField<string> sampleDocumentUris_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A set of Cloud Storage URIs of sample documents for this processor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> SampleDocumentUris {
      get { return sampleDocumentUris_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProcessorType);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProcessorType other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      if (Category != other.Category) return false;
      if(!availableLocations_.Equals(other.availableLocations_)) return false;
      if (AllowCreation != other.AllowCreation) return false;
      if (LaunchStage != other.LaunchStage) return false;
      if(!sampleDocumentUris_.Equals(other.sampleDocumentUris_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Category.Length != 0) hash ^= Category.GetHashCode();
      hash ^= availableLocations_.GetHashCode();
      if (AllowCreation != false) hash ^= AllowCreation.GetHashCode();
      if (LaunchStage != global::Google.Api.LaunchStage.Unspecified) hash ^= LaunchStage.GetHashCode();
      hash ^= sampleDocumentUris_.GetHashCode();
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
      if (Type.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
      if (Category.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Category);
      }
      availableLocations_.WriteTo(output, _repeated_availableLocations_codec);
      if (AllowCreation != false) {
        output.WriteRawTag(48);
        output.WriteBool(AllowCreation);
      }
      if (LaunchStage != global::Google.Api.LaunchStage.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) LaunchStage);
      }
      sampleDocumentUris_.WriteTo(output, _repeated_sampleDocumentUris_codec);
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
      if (Type.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
      if (Category.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Category);
      }
      availableLocations_.WriteTo(ref output, _repeated_availableLocations_codec);
      if (AllowCreation != false) {
        output.WriteRawTag(48);
        output.WriteBool(AllowCreation);
      }
      if (LaunchStage != global::Google.Api.LaunchStage.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) LaunchStage);
      }
      sampleDocumentUris_.WriteTo(ref output, _repeated_sampleDocumentUris_codec);
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
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Category.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Category);
      }
      size += availableLocations_.CalculateSize(_repeated_availableLocations_codec);
      if (AllowCreation != false) {
        size += 1 + 1;
      }
      if (LaunchStage != global::Google.Api.LaunchStage.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LaunchStage);
      }
      size += sampleDocumentUris_.CalculateSize(_repeated_sampleDocumentUris_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProcessorType other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Category.Length != 0) {
        Category = other.Category;
      }
      availableLocations_.Add(other.availableLocations_);
      if (other.AllowCreation != false) {
        AllowCreation = other.AllowCreation;
      }
      if (other.LaunchStage != global::Google.Api.LaunchStage.Unspecified) {
        LaunchStage = other.LaunchStage;
      }
      sampleDocumentUris_.Add(other.sampleDocumentUris_);
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
            Type = input.ReadString();
            break;
          }
          case 26: {
            Category = input.ReadString();
            break;
          }
          case 34: {
            availableLocations_.AddEntriesFrom(input, _repeated_availableLocations_codec);
            break;
          }
          case 48: {
            AllowCreation = input.ReadBool();
            break;
          }
          case 64: {
            LaunchStage = (global::Google.Api.LaunchStage) input.ReadEnum();
            break;
          }
          case 74: {
            sampleDocumentUris_.AddEntriesFrom(input, _repeated_sampleDocumentUris_codec);
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
            Type = input.ReadString();
            break;
          }
          case 26: {
            Category = input.ReadString();
            break;
          }
          case 34: {
            availableLocations_.AddEntriesFrom(ref input, _repeated_availableLocations_codec);
            break;
          }
          case 48: {
            AllowCreation = input.ReadBool();
            break;
          }
          case 64: {
            LaunchStage = (global::Google.Api.LaunchStage) input.ReadEnum();
            break;
          }
          case 74: {
            sampleDocumentUris_.AddEntriesFrom(ref input, _repeated_sampleDocumentUris_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ProcessorType message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The location information about where the processor is available.
      /// </summary>
      [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
      public sealed partial class LocationInfo : pb::IMessage<LocationInfo>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<LocationInfo> _parser = new pb::MessageParser<LocationInfo>(() => new LocationInfo());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<LocationInfo> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.DocumentAI.V1.ProcessorType.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public LocationInfo() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public LocationInfo(LocationInfo other) : this() {
          locationId_ = other.locationId_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public LocationInfo Clone() {
          return new LocationInfo(this);
        }

        /// <summary>Field number for the "location_id" field.</summary>
        public const int LocationIdFieldNumber = 1;
        private string locationId_ = "";
        /// <summary>
        /// The location ID. For supported locations, refer to [regional and
        /// multi-regional support](/document-ai/docs/regions).
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string LocationId {
          get { return locationId_; }
          set {
            locationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as LocationInfo);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(LocationInfo other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (LocationId != other.LocationId) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (LocationId.Length != 0) hash ^= LocationId.GetHashCode();
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
          if (LocationId.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(LocationId);
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
          if (LocationId.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(LocationId);
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
          if (LocationId.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(LocationId);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(LocationInfo other) {
          if (other == null) {
            return;
          }
          if (other.LocationId.Length != 0) {
            LocationId = other.LocationId;
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
                LocationId = input.ReadString();
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
                LocationId = input.ReadString();
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

  #endregion

}

#endregion Designer generated code
