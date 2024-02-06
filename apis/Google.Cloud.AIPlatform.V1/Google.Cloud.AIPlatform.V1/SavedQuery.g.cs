// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/saved_query.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/saved_query.proto</summary>
  public static partial class SavedQueryReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/saved_query.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SavedQueryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zYXZlZF9xdWVyeS5wcm90",
            "bxIaZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEaH2dvb2dsZS9hcGkvZmll",
            "bGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8a",
            "HGdvb2dsZS9wcm90b2J1Zi9zdHJ1Y3QucHJvdG8aH2dvb2dsZS9wcm90b2J1",
            "Zi90aW1lc3RhbXAucHJvdG8i5gMKClNhdmVkUXVlcnkSEQoEbmFtZRgBIAEo",
            "CUID4EEDEhkKDGRpc3BsYXlfbmFtZRgCIAEoCUID4EECEigKCG1ldGFkYXRh",
            "GAwgASgLMhYuZ29vZ2xlLnByb3RvYnVmLlZhbHVlEjQKC2NyZWF0ZV90aW1l",
            "GAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEID4EEDEjQKC3Vw",
            "ZGF0ZV90aW1lGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEID",
            "4EEDEh4KEWFubm90YXRpb25fZmlsdGVyGAUgASgJQgPgQQMSGQoMcHJvYmxl",
            "bV90eXBlGAYgASgJQgPgQQISIgoVYW5ub3RhdGlvbl9zcGVjX2NvdW50GAog",
            "ASgFQgPgQQMSDAoEZXRhZxgIIAEoCRIkChdzdXBwb3J0X2F1dG9tbF90cmFp",
            "bmluZxgJIAEoCEID4EEDOoAB6kF9CiRhaXBsYXRmb3JtLmdvb2dsZWFwaXMu",
            "Y29tL1NhdmVkUXVlcnkSVXByb2plY3RzL3twcm9qZWN0fS9sb2NhdGlvbnMv",
            "e2xvY2F0aW9ufS9kYXRhc2V0cy97ZGF0YXNldH0vc2F2ZWRRdWVyaWVzL3tz",
            "YXZlZF9xdWVyeX1CzQEKHmNvbS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52",
            "MUIPU2F2ZWRRdWVyeVByb3RvUAFaPmNsb3VkLmdvb2dsZS5jb20vZ28vYWlw",
            "bGF0Zm9ybS9hcGl2MS9haXBsYXRmb3JtcGI7YWlwbGF0Zm9ybXBiqgIaR29v",
            "Z2xlLkNsb3VkLkFJUGxhdGZvcm0uVjHKAhpHb29nbGVcQ2xvdWRcQUlQbGF0",
            "Zm9ybVxWMeoCHUdvb2dsZTo6Q2xvdWQ6OkFJUGxhdGZvcm06OlYxYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.SavedQuery), global::Google.Cloud.AIPlatform.V1.SavedQuery.Parser, new[]{ "Name", "DisplayName", "Metadata", "CreateTime", "UpdateTime", "AnnotationFilter", "ProblemType", "AnnotationSpecCount", "Etag", "SupportAutomlTraining" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A SavedQuery is a view of the dataset. It references a subset of annotations
  /// by problem type and filters.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SavedQuery : pb::IMessage<SavedQuery>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SavedQuery> _parser = new pb::MessageParser<SavedQuery>(() => new SavedQuery());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SavedQuery> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.SavedQueryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SavedQuery() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SavedQuery(SavedQuery other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      annotationFilter_ = other.annotationFilter_;
      problemType_ = other.problemType_;
      annotationSpecCount_ = other.annotationSpecCount_;
      etag_ = other.etag_;
      supportAutomlTraining_ = other.supportAutomlTraining_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SavedQuery Clone() {
      return new SavedQuery(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Resource name of the SavedQuery.
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
    /// Required. The user-defined name of the SavedQuery.
    /// The name can be up to 128 characters long and can consist of any UTF-8
    /// characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 12;
    private global::Google.Protobuf.WellKnownTypes.Value metadata_;
    /// <summary>
    /// Some additional information about the SavedQuery.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Value Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this SavedQuery was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Timestamp when SavedQuery was last updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "annotation_filter" field.</summary>
    public const int AnnotationFilterFieldNumber = 5;
    private string annotationFilter_ = "";
    /// <summary>
    /// Output only. Filters on the Annotations in the dataset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AnnotationFilter {
      get { return annotationFilter_; }
      set {
        annotationFilter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "problem_type" field.</summary>
    public const int ProblemTypeFieldNumber = 6;
    private string problemType_ = "";
    /// <summary>
    /// Required. Problem type of the SavedQuery.
    /// Allowed values:
    ///
    /// * IMAGE_CLASSIFICATION_SINGLE_LABEL
    /// * IMAGE_CLASSIFICATION_MULTI_LABEL
    /// * IMAGE_BOUNDING_POLY
    /// * IMAGE_BOUNDING_BOX
    /// * TEXT_CLASSIFICATION_SINGLE_LABEL
    /// * TEXT_CLASSIFICATION_MULTI_LABEL
    /// * TEXT_EXTRACTION
    /// * TEXT_SENTIMENT
    /// * VIDEO_CLASSIFICATION
    /// * VIDEO_OBJECT_TRACKING
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProblemType {
      get { return problemType_; }
      set {
        problemType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "annotation_spec_count" field.</summary>
    public const int AnnotationSpecCountFieldNumber = 10;
    private int annotationSpecCount_;
    /// <summary>
    /// Output only. Number of AnnotationSpecs in the context of the SavedQuery.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int AnnotationSpecCount {
      get { return annotationSpecCount_; }
      set {
        annotationSpecCount_ = value;
      }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 8;
    private string etag_ = "";
    /// <summary>
    /// Used to perform a consistent read-modify-write update. If not set, a blind
    /// "overwrite" update happens.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "support_automl_training" field.</summary>
    public const int SupportAutomlTrainingFieldNumber = 9;
    private bool supportAutomlTraining_;
    /// <summary>
    /// Output only. If the Annotations belonging to the SavedQuery can be used for
    /// AutoML training.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SupportAutomlTraining {
      get { return supportAutomlTraining_; }
      set {
        supportAutomlTraining_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SavedQuery);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SavedQuery other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (AnnotationFilter != other.AnnotationFilter) return false;
      if (ProblemType != other.ProblemType) return false;
      if (AnnotationSpecCount != other.AnnotationSpecCount) return false;
      if (Etag != other.Etag) return false;
      if (SupportAutomlTraining != other.SupportAutomlTraining) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (AnnotationFilter.Length != 0) hash ^= AnnotationFilter.GetHashCode();
      if (ProblemType.Length != 0) hash ^= ProblemType.GetHashCode();
      if (AnnotationSpecCount != 0) hash ^= AnnotationSpecCount.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      if (SupportAutomlTraining != false) hash ^= SupportAutomlTraining.GetHashCode();
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
      if (createTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
      }
      if (AnnotationFilter.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(AnnotationFilter);
      }
      if (ProblemType.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ProblemType);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Etag);
      }
      if (SupportAutomlTraining != false) {
        output.WriteRawTag(72);
        output.WriteBool(SupportAutomlTraining);
      }
      if (AnnotationSpecCount != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(AnnotationSpecCount);
      }
      if (metadata_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Metadata);
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
      if (createTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
      }
      if (AnnotationFilter.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(AnnotationFilter);
      }
      if (ProblemType.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ProblemType);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Etag);
      }
      if (SupportAutomlTraining != false) {
        output.WriteRawTag(72);
        output.WriteBool(SupportAutomlTraining);
      }
      if (AnnotationSpecCount != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(AnnotationSpecCount);
      }
      if (metadata_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Metadata);
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
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (AnnotationFilter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AnnotationFilter);
      }
      if (ProblemType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProblemType);
      }
      if (AnnotationSpecCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AnnotationSpecCount);
      }
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      if (SupportAutomlTraining != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SavedQuery other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          Metadata = new global::Google.Protobuf.WellKnownTypes.Value();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.AnnotationFilter.Length != 0) {
        AnnotationFilter = other.AnnotationFilter;
      }
      if (other.ProblemType.Length != 0) {
        ProblemType = other.ProblemType;
      }
      if (other.AnnotationSpecCount != 0) {
        AnnotationSpecCount = other.AnnotationSpecCount;
      }
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      if (other.SupportAutomlTraining != false) {
        SupportAutomlTraining = other.SupportAutomlTraining;
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
          case 26: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 34: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 42: {
            AnnotationFilter = input.ReadString();
            break;
          }
          case 50: {
            ProblemType = input.ReadString();
            break;
          }
          case 66: {
            Etag = input.ReadString();
            break;
          }
          case 72: {
            SupportAutomlTraining = input.ReadBool();
            break;
          }
          case 80: {
            AnnotationSpecCount = input.ReadInt32();
            break;
          }
          case 98: {
            if (metadata_ == null) {
              Metadata = new global::Google.Protobuf.WellKnownTypes.Value();
            }
            input.ReadMessage(Metadata);
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
          case 26: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 34: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 42: {
            AnnotationFilter = input.ReadString();
            break;
          }
          case 50: {
            ProblemType = input.ReadString();
            break;
          }
          case 66: {
            Etag = input.ReadString();
            break;
          }
          case 72: {
            SupportAutomlTraining = input.ReadBool();
            break;
          }
          case 80: {
            AnnotationSpecCount = input.ReadInt32();
            break;
          }
          case 98: {
            if (metadata_ == null) {
              Metadata = new global::Google.Protobuf.WellKnownTypes.Value();
            }
            input.ReadMessage(Metadata);
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
