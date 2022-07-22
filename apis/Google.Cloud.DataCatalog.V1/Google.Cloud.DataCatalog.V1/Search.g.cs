// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/datacatalog/v1/search.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DataCatalog.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/datacatalog/v1/search.proto</summary>
  public static partial class SearchReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/datacatalog/v1/search.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SearchReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvZGF0YWNhdGFsb2cvdjEvc2VhcmNoLnByb3RvEhtn",
            "b29nbGUuY2xvdWQuZGF0YWNhdGFsb2cudjEaH2dvb2dsZS9hcGkvZmllbGRf",
            "YmVoYXZpb3IucHJvdG8aKGdvb2dsZS9jbG91ZC9kYXRhY2F0YWxvZy92MS9j",
            "b21tb24ucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8i",
            "rgMKE1NlYXJjaENhdGFsb2dSZXN1bHQSSQoSc2VhcmNoX3Jlc3VsdF90eXBl",
            "GAEgASgOMi0uZ29vZ2xlLmNsb3VkLmRhdGFjYXRhbG9nLnYxLlNlYXJjaFJl",
            "c3VsdFR5cGUSHQoVc2VhcmNoX3Jlc3VsdF9zdWJ0eXBlGAIgASgJEh4KFnJl",
            "bGF0aXZlX3Jlc291cmNlX25hbWUYAyABKAkSFwoPbGlua2VkX3Jlc291cmNl",
            "GAQgASgJEi8KC21vZGlmeV90aW1lGAcgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcBJPChFpbnRlZ3JhdGVkX3N5c3RlbRgIIAEoDjItLmdvb2ds",
            "ZS5jbG91ZC5kYXRhY2F0YWxvZy52MS5JbnRlZ3JhdGVkU3lzdGVtQgPgQQNI",
            "ABIfChV1c2VyX3NwZWNpZmllZF9zeXN0ZW0YCSABKAlIABIcChRmdWxseV9x",
            "dWFsaWZpZWRfbmFtZRgKIAEoCRIUCgxkaXNwbGF5X25hbWUYDCABKAkSEwoL",
            "ZGVzY3JpcHRpb24YDSABKAlCCAoGc3lzdGVtKmQKEFNlYXJjaFJlc3VsdFR5",
            "cGUSIgoeU0VBUkNIX1JFU1VMVF9UWVBFX1VOU1BFQ0lGSUVEEAASCQoFRU5U",
            "UlkQARIQCgxUQUdfVEVNUExBVEUQAhIPCgtFTlRSWV9HUk9VUBADQssBCh9j",
            "b20uZ29vZ2xlLmNsb3VkLmRhdGFjYXRhbG9nLnYxUAFaRmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvZGF0YWNhdGFsb2cv",
            "djE7ZGF0YWNhdGFsb2f4AQGqAhtHb29nbGUuQ2xvdWQuRGF0YUNhdGFsb2cu",
            "VjHKAhtHb29nbGVcQ2xvdWRcRGF0YUNhdGFsb2dcVjHqAh5Hb29nbGU6OkNs",
            "b3VkOjpEYXRhQ2F0YWxvZzo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Cloud.DataCatalog.V1.CommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.DataCatalog.V1.SearchResultType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.SearchCatalogResult), global::Google.Cloud.DataCatalog.V1.SearchCatalogResult.Parser, new[]{ "SearchResultType", "SearchResultSubtype", "RelativeResourceName", "LinkedResource", "ModifyTime", "IntegratedSystem", "UserSpecifiedSystem", "FullyQualifiedName", "DisplayName", "Description" }, new[]{ "System" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The resource types that can be returned in search results.
  /// </summary>
  public enum SearchResultType {
    /// <summary>
    /// Default unknown type.
    /// </summary>
    [pbr::OriginalName("SEARCH_RESULT_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// An [Entry][google.cloud.datacatalog.v1.Entry].
    /// </summary>
    [pbr::OriginalName("ENTRY")] Entry = 1,
    /// <summary>
    /// A [TagTemplate][google.cloud.datacatalog.v1.TagTemplate].
    /// </summary>
    [pbr::OriginalName("TAG_TEMPLATE")] TagTemplate = 2,
    /// <summary>
    /// An [EntryGroup][google.cloud.datacatalog.v1.EntryGroup].
    /// </summary>
    [pbr::OriginalName("ENTRY_GROUP")] EntryGroup = 3,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Result in the response to a search request.
  ///
  /// Each result captures details of one entry that matches the search.
  /// </summary>
  public sealed partial class SearchCatalogResult : pb::IMessage<SearchCatalogResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SearchCatalogResult> _parser = new pb::MessageParser<SearchCatalogResult>(() => new SearchCatalogResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SearchCatalogResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.SearchReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SearchCatalogResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SearchCatalogResult(SearchCatalogResult other) : this() {
      searchResultType_ = other.searchResultType_;
      searchResultSubtype_ = other.searchResultSubtype_;
      relativeResourceName_ = other.relativeResourceName_;
      linkedResource_ = other.linkedResource_;
      modifyTime_ = other.modifyTime_ != null ? other.modifyTime_.Clone() : null;
      fullyQualifiedName_ = other.fullyQualifiedName_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      switch (other.SystemCase) {
        case SystemOneofCase.IntegratedSystem:
          IntegratedSystem = other.IntegratedSystem;
          break;
        case SystemOneofCase.UserSpecifiedSystem:
          UserSpecifiedSystem = other.UserSpecifiedSystem;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SearchCatalogResult Clone() {
      return new SearchCatalogResult(this);
    }

    /// <summary>Field number for the "search_result_type" field.</summary>
    public const int SearchResultTypeFieldNumber = 1;
    private global::Google.Cloud.DataCatalog.V1.SearchResultType searchResultType_ = global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified;
    /// <summary>
    /// Type of the search result.
    ///
    /// You can use this field to determine which get method to call to fetch the
    /// full resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DataCatalog.V1.SearchResultType SearchResultType {
      get { return searchResultType_; }
      set {
        searchResultType_ = value;
      }
    }

    /// <summary>Field number for the "search_result_subtype" field.</summary>
    public const int SearchResultSubtypeFieldNumber = 2;
    private string searchResultSubtype_ = "";
    /// <summary>
    /// Sub-type of the search result.
    ///
    /// A dot-delimited full type of the resource. The same type you
    /// specify in the `type` search predicate.
    ///
    /// Examples: `entry.table`, `entry.dataStream`, `tagTemplate`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SearchResultSubtype {
      get { return searchResultSubtype_; }
      set {
        searchResultSubtype_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "relative_resource_name" field.</summary>
    public const int RelativeResourceNameFieldNumber = 3;
    private string relativeResourceName_ = "";
    /// <summary>
    /// The relative name of the resource in URL format.
    ///
    /// Examples:
    ///
    ///  * `projects/{PROJECT_ID}/locations/{LOCATION_ID}/entryGroups/{ENTRY_GROUP_ID}/entries/{ENTRY_ID}`
    ///  * `projects/{PROJECT_ID}/tagTemplates/{TAG_TEMPLATE_ID}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RelativeResourceName {
      get { return relativeResourceName_; }
      set {
        relativeResourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "linked_resource" field.</summary>
    public const int LinkedResourceFieldNumber = 4;
    private string linkedResource_ = "";
    /// <summary>
    /// The full name of the Google Cloud resource the entry belongs to.
    ///
    /// For more information, see [Full Resource Name]
    /// (/apis/design/resource_names#full_resource_name).
    ///
    /// Example:
    ///
    /// `//bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LinkedResource {
      get { return linkedResource_; }
      set {
        linkedResource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "modify_time" field.</summary>
    public const int ModifyTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp modifyTime_;
    /// <summary>
    /// The last modification timestamp of the entry in the source system.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ModifyTime {
      get { return modifyTime_; }
      set {
        modifyTime_ = value;
      }
    }

    /// <summary>Field number for the "integrated_system" field.</summary>
    public const int IntegratedSystemFieldNumber = 8;
    /// <summary>
    /// Output only. The source system that Data Catalog automatically integrates  with, such
    /// as BigQuery, Cloud Pub/Sub, or Dataproc Metastore.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DataCatalog.V1.IntegratedSystem IntegratedSystem {
      get { return systemCase_ == SystemOneofCase.IntegratedSystem ? (global::Google.Cloud.DataCatalog.V1.IntegratedSystem) system_ : global::Google.Cloud.DataCatalog.V1.IntegratedSystem.Unspecified; }
      set {
        system_ = value;
        systemCase_ = SystemOneofCase.IntegratedSystem;
      }
    }

    /// <summary>Field number for the "user_specified_system" field.</summary>
    public const int UserSpecifiedSystemFieldNumber = 9;
    /// <summary>
    /// Custom source system that you can manually integrate Data Catalog with.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserSpecifiedSystem {
      get { return systemCase_ == SystemOneofCase.UserSpecifiedSystem ? (string) system_ : ""; }
      set {
        system_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        systemCase_ = SystemOneofCase.UserSpecifiedSystem;
      }
    }

    /// <summary>Field number for the "fully_qualified_name" field.</summary>
    public const int FullyQualifiedNameFieldNumber = 10;
    private string fullyQualifiedName_ = "";
    /// <summary>
    /// Fully qualified name (FQN) of the resource.
    ///
    /// FQNs take two forms:
    ///
    /// * For non-regionalized resources:
    ///
    ///   `{SYSTEM}:{PROJECT}.{PATH_TO_RESOURCE_SEPARATED_WITH_DOTS}`
    ///
    /// * For regionalized resources:
    ///
    ///   `{SYSTEM}:{PROJECT}.{LOCATION_ID}.{PATH_TO_RESOURCE_SEPARATED_WITH_DOTS}`
    ///
    /// Example for a DPMS table:
    ///
    /// `dataproc_metastore:PROJECT_ID.LOCATION_ID.INSTANCE_ID.DATABASE_ID.TABLE_ID`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FullyQualifiedName {
      get { return fullyQualifiedName_; }
      set {
        fullyQualifiedName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 12;
    private string displayName_ = "";
    /// <summary>
    /// The display name of the result.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 13;
    private string description_ = "";
    /// <summary>
    /// Entry description that can consist of several sentences or paragraphs that
    /// describe entry contents.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private object system_;
    /// <summary>Enum of possible cases for the "system" oneof.</summary>
    public enum SystemOneofCase {
      None = 0,
      IntegratedSystem = 8,
      UserSpecifiedSystem = 9,
    }
    private SystemOneofCase systemCase_ = SystemOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SystemOneofCase SystemCase {
      get { return systemCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSystem() {
      systemCase_ = SystemOneofCase.None;
      system_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SearchCatalogResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SearchCatalogResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SearchResultType != other.SearchResultType) return false;
      if (SearchResultSubtype != other.SearchResultSubtype) return false;
      if (RelativeResourceName != other.RelativeResourceName) return false;
      if (LinkedResource != other.LinkedResource) return false;
      if (!object.Equals(ModifyTime, other.ModifyTime)) return false;
      if (IntegratedSystem != other.IntegratedSystem) return false;
      if (UserSpecifiedSystem != other.UserSpecifiedSystem) return false;
      if (FullyQualifiedName != other.FullyQualifiedName) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Description != other.Description) return false;
      if (SystemCase != other.SystemCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SearchResultType != global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified) hash ^= SearchResultType.GetHashCode();
      if (SearchResultSubtype.Length != 0) hash ^= SearchResultSubtype.GetHashCode();
      if (RelativeResourceName.Length != 0) hash ^= RelativeResourceName.GetHashCode();
      if (LinkedResource.Length != 0) hash ^= LinkedResource.GetHashCode();
      if (modifyTime_ != null) hash ^= ModifyTime.GetHashCode();
      if (systemCase_ == SystemOneofCase.IntegratedSystem) hash ^= IntegratedSystem.GetHashCode();
      if (systemCase_ == SystemOneofCase.UserSpecifiedSystem) hash ^= UserSpecifiedSystem.GetHashCode();
      if (FullyQualifiedName.Length != 0) hash ^= FullyQualifiedName.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      hash ^= (int) systemCase_;
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
      if (SearchResultType != global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) SearchResultType);
      }
      if (SearchResultSubtype.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SearchResultSubtype);
      }
      if (RelativeResourceName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RelativeResourceName);
      }
      if (LinkedResource.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LinkedResource);
      }
      if (modifyTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ModifyTime);
      }
      if (systemCase_ == SystemOneofCase.IntegratedSystem) {
        output.WriteRawTag(64);
        output.WriteEnum((int) IntegratedSystem);
      }
      if (systemCase_ == SystemOneofCase.UserSpecifiedSystem) {
        output.WriteRawTag(74);
        output.WriteString(UserSpecifiedSystem);
      }
      if (FullyQualifiedName.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(FullyQualifiedName);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(Description);
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
      if (SearchResultType != global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) SearchResultType);
      }
      if (SearchResultSubtype.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SearchResultSubtype);
      }
      if (RelativeResourceName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RelativeResourceName);
      }
      if (LinkedResource.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LinkedResource);
      }
      if (modifyTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ModifyTime);
      }
      if (systemCase_ == SystemOneofCase.IntegratedSystem) {
        output.WriteRawTag(64);
        output.WriteEnum((int) IntegratedSystem);
      }
      if (systemCase_ == SystemOneofCase.UserSpecifiedSystem) {
        output.WriteRawTag(74);
        output.WriteString(UserSpecifiedSystem);
      }
      if (FullyQualifiedName.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(FullyQualifiedName);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(Description);
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
      if (SearchResultType != global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SearchResultType);
      }
      if (SearchResultSubtype.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SearchResultSubtype);
      }
      if (RelativeResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RelativeResourceName);
      }
      if (LinkedResource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LinkedResource);
      }
      if (modifyTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModifyTime);
      }
      if (systemCase_ == SystemOneofCase.IntegratedSystem) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) IntegratedSystem);
      }
      if (systemCase_ == SystemOneofCase.UserSpecifiedSystem) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserSpecifiedSystem);
      }
      if (FullyQualifiedName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FullyQualifiedName);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SearchCatalogResult other) {
      if (other == null) {
        return;
      }
      if (other.SearchResultType != global::Google.Cloud.DataCatalog.V1.SearchResultType.Unspecified) {
        SearchResultType = other.SearchResultType;
      }
      if (other.SearchResultSubtype.Length != 0) {
        SearchResultSubtype = other.SearchResultSubtype;
      }
      if (other.RelativeResourceName.Length != 0) {
        RelativeResourceName = other.RelativeResourceName;
      }
      if (other.LinkedResource.Length != 0) {
        LinkedResource = other.LinkedResource;
      }
      if (other.modifyTime_ != null) {
        if (modifyTime_ == null) {
          ModifyTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ModifyTime.MergeFrom(other.ModifyTime);
      }
      if (other.FullyQualifiedName.Length != 0) {
        FullyQualifiedName = other.FullyQualifiedName;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      switch (other.SystemCase) {
        case SystemOneofCase.IntegratedSystem:
          IntegratedSystem = other.IntegratedSystem;
          break;
        case SystemOneofCase.UserSpecifiedSystem:
          UserSpecifiedSystem = other.UserSpecifiedSystem;
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
            SearchResultType = (global::Google.Cloud.DataCatalog.V1.SearchResultType) input.ReadEnum();
            break;
          }
          case 18: {
            SearchResultSubtype = input.ReadString();
            break;
          }
          case 26: {
            RelativeResourceName = input.ReadString();
            break;
          }
          case 34: {
            LinkedResource = input.ReadString();
            break;
          }
          case 58: {
            if (modifyTime_ == null) {
              ModifyTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ModifyTime);
            break;
          }
          case 64: {
            system_ = input.ReadEnum();
            systemCase_ = SystemOneofCase.IntegratedSystem;
            break;
          }
          case 74: {
            UserSpecifiedSystem = input.ReadString();
            break;
          }
          case 82: {
            FullyQualifiedName = input.ReadString();
            break;
          }
          case 98: {
            DisplayName = input.ReadString();
            break;
          }
          case 106: {
            Description = input.ReadString();
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
            SearchResultType = (global::Google.Cloud.DataCatalog.V1.SearchResultType) input.ReadEnum();
            break;
          }
          case 18: {
            SearchResultSubtype = input.ReadString();
            break;
          }
          case 26: {
            RelativeResourceName = input.ReadString();
            break;
          }
          case 34: {
            LinkedResource = input.ReadString();
            break;
          }
          case 58: {
            if (modifyTime_ == null) {
              ModifyTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ModifyTime);
            break;
          }
          case 64: {
            system_ = input.ReadEnum();
            systemCase_ = SystemOneofCase.IntegratedSystem;
            break;
          }
          case 74: {
            UserSpecifiedSystem = input.ReadString();
            break;
          }
          case 82: {
            FullyQualifiedName = input.ReadString();
            break;
          }
          case 98: {
            DisplayName = input.ReadString();
            break;
          }
          case 106: {
            Description = input.ReadString();
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
