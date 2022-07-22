// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/bigquery_export.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/bigquery_export.proto</summary>
  public static partial class BigqueryExportReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/bigquery_export.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BigqueryExportReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEvYmlncXVlcnlfZXhw",
            "b3J0LnByb3RvEh5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIudjEaH2dv",
            "b2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVz",
            "b3VyY2UucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8i",
            "vQMKDkJpZ1F1ZXJ5RXhwb3J0EgwKBG5hbWUYASABKAkSEwoLZGVzY3JpcHRp",
            "b24YAiABKAkSDgoGZmlsdGVyGAMgASgJEg8KB2RhdGFzZXQYBCABKAkSNAoL",
            "Y3JlYXRlX3RpbWUYBSABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "QgPgQQMSNAoLdXBkYXRlX3RpbWUYBiABKAsyGi5nb29nbGUucHJvdG9idWYu",
            "VGltZXN0YW1wQgPgQQMSHwoSbW9zdF9yZWNlbnRfZWRpdG9yGAcgASgJQgPg",
            "QQMSFgoJcHJpbmNpcGFsGAggASgJQgPgQQM6wQHqQb0BCixzZWN1cml0eWNl",
            "bnRlci5nb29nbGVhcGlzLmNvbS9CaWdRdWVyeUV4cG9ydBI1b3JnYW5pemF0",
            "aW9ucy97b3JnYW5pemF0aW9ufS9iaWdRdWVyeUV4cG9ydHMve2V4cG9ydH0S",
            "KWZvbGRlcnMve2ZvbGRlcn0vYmlnUXVlcnlFeHBvcnRzL3tleHBvcnR9Eitw",
            "cm9qZWN0cy97cHJvamVjdH0vYmlnUXVlcnlFeHBvcnRzL3tleHBvcnR9Qu8B",
            "CiJjb20uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYxQhNCaWdRdWVy",
            "eUV4cG9ydFByb3RvUAFaTGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjE7c2VjdXJpdHljZW50",
            "ZXKqAh5Hb29nbGUuQ2xvdWQuU2VjdXJpdHlDZW50ZXIuVjHKAh5Hb29nbGVc",
            "Q2xvdWRcU2VjdXJpdHlDZW50ZXJcVjHqAiFHb29nbGU6OkNsb3VkOjpTZWN1",
            "cml0eUNlbnRlcjo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.BigQueryExport), global::Google.Cloud.SecurityCenter.V1.BigQueryExport.Parser, new[]{ "Name", "Description", "Filter", "Dataset", "CreateTime", "UpdateTime", "MostRecentEditor", "Principal" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configures how to deliver Findings to BigQuery Instance.
  /// </summary>
  public sealed partial class BigQueryExport : pb::IMessage<BigQueryExport>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BigQueryExport> _parser = new pb::MessageParser<BigQueryExport>(() => new BigQueryExport());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BigQueryExport> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.BigqueryExportReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BigQueryExport() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BigQueryExport(BigQueryExport other) : this() {
      name_ = other.name_;
      description_ = other.description_;
      filter_ = other.filter_;
      dataset_ = other.dataset_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      mostRecentEditor_ = other.mostRecentEditor_;
      principal_ = other.principal_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BigQueryExport Clone() {
      return new BigQueryExport(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The relative resource name of this export. See:
    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name.
    /// Example format:
    /// "organizations/{organization_id}/bigQueryExports/{export_id}" Example
    /// format: "folders/{folder_id}/bigQueryExports/{export_id}" Example format:
    /// "projects/{project_id}/bigQueryExports/{export_id}"
    /// This field is provided in responses, and is ignored when provided in create
    /// requests.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    /// <summary>
    /// The description of the export (max of 1024 characters).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 3;
    private string filter_ = "";
    /// <summary>
    /// Expression that defines the filter to apply across create/update events
    /// of findings. The expression is a list of zero or more restrictions combined
    /// via logical operators `AND` and `OR`. Parentheses are supported, and `OR`
    /// has higher precedence than `AND`.
    ///
    /// Restrictions have the form `&lt;field> &lt;operator> &lt;value>` and may have a
    /// `-` character in front of them to indicate negation. The fields map to
    /// those defined in the corresponding resource.
    ///
    /// The supported operators are:
    ///
    /// * `=` for all value types.
    /// * `>`, `&lt;`, `>=`, `&lt;=` for integer values.
    /// * `:`, meaning substring matching, for strings.
    ///
    /// The supported value types are:
    ///
    /// * string literals in quotes.
    /// * integer literals without quotes.
    /// * boolean literals `true` and `false` without quotes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dataset" field.</summary>
    public const int DatasetFieldNumber = 4;
    private string dataset_ = "";
    /// <summary>
    /// The dataset to write findings' updates to. Its format is
    /// "projects/[project_id]/datasets/[bigquery_dataset_id]".
    /// BigQuery Dataset unique ID  must contain only letters (a-z, A-Z), numbers
    /// (0-9), or underscores (_).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Dataset {
      get { return dataset_; }
      set {
        dataset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The time at which the big query export was created.
    /// This field is set by the server and will be ignored if provided on export
    /// on creation.
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
    public const int UpdateTimeFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. The most recent time at which the big export was updated.
    /// This field is set by the server and will be ignored if provided on export
    /// creation or update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "most_recent_editor" field.</summary>
    public const int MostRecentEditorFieldNumber = 7;
    private string mostRecentEditor_ = "";
    /// <summary>
    /// Output only. Email address of the user who last edited the big query export.
    /// This field is set by the server and will be ignored if provided on export
    /// creation or update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MostRecentEditor {
      get { return mostRecentEditor_; }
      set {
        mostRecentEditor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "principal" field.</summary>
    public const int PrincipalFieldNumber = 8;
    private string principal_ = "";
    /// <summary>
    /// Output only. The service account that needs permission to create table, upload data to
    /// the big query dataset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Principal {
      get { return principal_; }
      set {
        principal_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BigQueryExport);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BigQueryExport other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (Filter != other.Filter) return false;
      if (Dataset != other.Dataset) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (MostRecentEditor != other.MostRecentEditor) return false;
      if (Principal != other.Principal) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
      if (Dataset.Length != 0) hash ^= Dataset.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (MostRecentEditor.Length != 0) hash ^= MostRecentEditor.GetHashCode();
      if (Principal.Length != 0) hash ^= Principal.GetHashCode();
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
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Filter);
      }
      if (Dataset.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Dataset);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(UpdateTime);
      }
      if (MostRecentEditor.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(MostRecentEditor);
      }
      if (Principal.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Principal);
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
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Filter);
      }
      if (Dataset.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Dataset);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(UpdateTime);
      }
      if (MostRecentEditor.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(MostRecentEditor);
      }
      if (Principal.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Principal);
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
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      if (Dataset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Dataset);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (MostRecentEditor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MostRecentEditor);
      }
      if (Principal.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Principal);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BigQueryExport other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
      }
      if (other.Dataset.Length != 0) {
        Dataset = other.Dataset;
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
      if (other.MostRecentEditor.Length != 0) {
        MostRecentEditor = other.MostRecentEditor;
      }
      if (other.Principal.Length != 0) {
        Principal = other.Principal;
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
            Description = input.ReadString();
            break;
          }
          case 26: {
            Filter = input.ReadString();
            break;
          }
          case 34: {
            Dataset = input.ReadString();
            break;
          }
          case 42: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 50: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 58: {
            MostRecentEditor = input.ReadString();
            break;
          }
          case 66: {
            Principal = input.ReadString();
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
            Description = input.ReadString();
            break;
          }
          case 26: {
            Filter = input.ReadString();
            break;
          }
          case 34: {
            Dataset = input.ReadString();
            break;
          }
          case 42: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 50: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 58: {
            MostRecentEditor = input.ReadString();
            break;
          }
          case 66: {
            Principal = input.ReadString();
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
