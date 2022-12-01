// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/orchestration/airflow/service/v1/image_versions.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Orchestration.Airflow.Service.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/orchestration/airflow/service/v1/image_versions.proto</summary>
  public static partial class ImageVersionsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/orchestration/airflow/service/v1/image_versions.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImageVersionsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvY2xvdWQvb3JjaGVzdHJhdGlvbi9haXJmbG93L3NlcnZpY2Uv",
            "djEvaW1hZ2VfdmVyc2lvbnMucHJvdG8SLWdvb2dsZS5jbG91ZC5vcmNoZXN0",
            "cmF0aW9uLmFpcmZsb3cuc2VydmljZS52MRocZ29vZ2xlL2FwaS9hbm5vdGF0",
            "aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8aFmdvb2dsZS90",
            "eXBlL2RhdGUucHJvdG8icAoYTGlzdEltYWdlVmVyc2lvbnNSZXF1ZXN0Eg4K",
            "BnBhcmVudBgBIAEoCRIRCglwYWdlX3NpemUYAiABKAUSEgoKcGFnZV90b2tl",
            "bhgDIAEoCRIdChVpbmNsdWRlX3Bhc3RfcmVsZWFzZXMYBCABKAgiiQEKGUxp",
            "c3RJbWFnZVZlcnNpb25zUmVzcG9uc2USUwoOaW1hZ2VfdmVyc2lvbnMYASAD",
            "KAsyOy5nb29nbGUuY2xvdWQub3JjaGVzdHJhdGlvbi5haXJmbG93LnNlcnZp",
            "Y2UudjEuSW1hZ2VWZXJzaW9uEhcKD25leHRfcGFnZV90b2tlbhgCIAEoCSK9",
            "AQoMSW1hZ2VWZXJzaW9uEhgKEGltYWdlX3ZlcnNpb25faWQYASABKAkSEgoK",
            "aXNfZGVmYXVsdBgCIAEoCBIhChlzdXBwb3J0ZWRfcHl0aG9uX3ZlcnNpb25z",
            "GAMgAygJEicKDHJlbGVhc2VfZGF0ZRgEIAEoCzIRLmdvb2dsZS50eXBlLkRh",
            "dGUSGQoRY3JlYXRpb25fZGlzYWJsZWQYBSABKAgSGAoQdXBncmFkZV9kaXNh",
            "YmxlZBgGIAEoCDLJAgoNSW1hZ2VWZXJzaW9ucxLqAQoRTGlzdEltYWdlVmVy",
            "c2lvbnMSRy5nb29nbGUuY2xvdWQub3JjaGVzdHJhdGlvbi5haXJmbG93LnNl",
            "cnZpY2UudjEuTGlzdEltYWdlVmVyc2lvbnNSZXF1ZXN0GkguZ29vZ2xlLmNs",
            "b3VkLm9yY2hlc3RyYXRpb24uYWlyZmxvdy5zZXJ2aWNlLnYxLkxpc3RJbWFn",
            "ZVZlcnNpb25zUmVzcG9uc2UiQoLT5JMCMxIxL3YxL3twYXJlbnQ9cHJvamVj",
            "dHMvKi9sb2NhdGlvbnMvKn0vaW1hZ2VWZXJzaW9uc9pBBnBhcmVudBpLykEX",
            "Y29tcG9zZXIuZ29vZ2xlYXBpcy5jb23SQS5odHRwczovL3d3dy5nb29nbGVh",
            "cGlzLmNvbS9hdXRoL2Nsb3VkLXBsYXRmb3JtQosBCjFjb20uZ29vZ2xlLmNs",
            "b3VkLm9yY2hlc3RyYXRpb24uYWlyZmxvdy5zZXJ2aWNlLnYxUAFaVGdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvb3JjaGVz",
            "dHJhdGlvbi9haXJmbG93L3NlcnZpY2UvdjE7c2VydmljZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Type.DateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Orchestration.Airflow.Service.V1.ListImageVersionsRequest), global::Google.Cloud.Orchestration.Airflow.Service.V1.ListImageVersionsRequest.Parser, new[]{ "Parent", "PageSize", "PageToken", "IncludePastReleases" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Orchestration.Airflow.Service.V1.ListImageVersionsResponse), global::Google.Cloud.Orchestration.Airflow.Service.V1.ListImageVersionsResponse.Parser, new[]{ "ImageVersions", "NextPageToken" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Orchestration.Airflow.Service.V1.ImageVersion), global::Google.Cloud.Orchestration.Airflow.Service.V1.ImageVersion.Parser, new[]{ "ImageVersionId", "IsDefault", "SupportedPythonVersions", "ReleaseDate", "CreationDisabled", "UpgradeDisabled" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// List ImageVersions in a project and location.
  /// </summary>
  public sealed partial class ListImageVersionsRequest : pb::IMessage<ListImageVersionsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListImageVersionsRequest> _parser = new pb::MessageParser<ListImageVersionsRequest>(() => new ListImageVersionsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListImageVersionsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Orchestration.Airflow.Service.V1.ImageVersionsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListImageVersionsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListImageVersionsRequest(ListImageVersionsRequest other) : this() {
      parent_ = other.parent_;
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
      includePastReleases_ = other.includePastReleases_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListImageVersionsRequest Clone() {
      return new ListImageVersionsRequest(this);
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 1;
    private string parent_ = "";
    /// <summary>
    /// List ImageVersions in the given project and location, in the form:
    /// "projects/{projectId}/locations/{locationId}"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 2;
    private int pageSize_;
    /// <summary>
    /// The maximum number of image_versions to return.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 3;
    private string pageToken_ = "";
    /// <summary>
    /// The next_page_token value returned from a previous List request, if any.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "include_past_releases" field.</summary>
    public const int IncludePastReleasesFieldNumber = 4;
    private bool includePastReleases_;
    /// <summary>
    /// Whether or not image versions from old releases should be included.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IncludePastReleases {
      get { return includePastReleases_; }
      set {
        includePastReleases_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListImageVersionsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListImageVersionsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Parent != other.Parent) return false;
      if (PageSize != other.PageSize) return false;
      if (PageToken != other.PageToken) return false;
      if (IncludePastReleases != other.IncludePastReleases) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      if (IncludePastReleases != false) hash ^= IncludePastReleases.GetHashCode();
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (IncludePastReleases != false) {
        output.WriteRawTag(32);
        output.WriteBool(IncludePastReleases);
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (IncludePastReleases != false) {
        output.WriteRawTag(32);
        output.WriteBool(IncludePastReleases);
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
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      if (IncludePastReleases != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ListImageVersionsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
      if (other.IncludePastReleases != false) {
        IncludePastReleases = other.IncludePastReleases;
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
            Parent = input.ReadString();
            break;
          }
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
          case 32: {
            IncludePastReleases = input.ReadBool();
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
            Parent = input.ReadString();
            break;
          }
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
          case 32: {
            IncludePastReleases = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The ImageVersions in a project and location.
  /// </summary>
  public sealed partial class ListImageVersionsResponse : pb::IMessage<ListImageVersionsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListImageVersionsResponse> _parser = new pb::MessageParser<ListImageVersionsResponse>(() => new ListImageVersionsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListImageVersionsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Orchestration.Airflow.Service.V1.ImageVersionsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListImageVersionsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListImageVersionsResponse(ListImageVersionsResponse other) : this() {
      imageVersions_ = other.imageVersions_.Clone();
      nextPageToken_ = other.nextPageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListImageVersionsResponse Clone() {
      return new ListImageVersionsResponse(this);
    }

    /// <summary>Field number for the "image_versions" field.</summary>
    public const int ImageVersionsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Cloud.Orchestration.Airflow.Service.V1.ImageVersion> _repeated_imageVersions_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Cloud.Orchestration.Airflow.Service.V1.ImageVersion.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Orchestration.Airflow.Service.V1.ImageVersion> imageVersions_ = new pbc::RepeatedField<global::Google.Cloud.Orchestration.Airflow.Service.V1.ImageVersion>();
    /// <summary>
    /// The list of supported ImageVersions in a location.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.Orchestration.Airflow.Service.V1.ImageVersion> ImageVersions {
      get { return imageVersions_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    /// The page token used to query for the next page if one exists.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListImageVersionsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListImageVersionsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!imageVersions_.Equals(other.imageVersions_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= imageVersions_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
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
      imageVersions_.WriteTo(output, _repeated_imageVersions_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
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
      imageVersions_.WriteTo(ref output, _repeated_imageVersions_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
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
      size += imageVersions_.CalculateSize(_repeated_imageVersions_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ListImageVersionsResponse other) {
      if (other == null) {
        return;
      }
      imageVersions_.Add(other.imageVersions_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
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
            imageVersions_.AddEntriesFrom(input, _repeated_imageVersions_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
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
            imageVersions_.AddEntriesFrom(ref input, _repeated_imageVersions_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// ImageVersion information
  /// </summary>
  public sealed partial class ImageVersion : pb::IMessage<ImageVersion>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ImageVersion> _parser = new pb::MessageParser<ImageVersion>(() => new ImageVersion());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ImageVersion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Orchestration.Airflow.Service.V1.ImageVersionsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageVersion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageVersion(ImageVersion other) : this() {
      imageVersionId_ = other.imageVersionId_;
      isDefault_ = other.isDefault_;
      supportedPythonVersions_ = other.supportedPythonVersions_.Clone();
      releaseDate_ = other.releaseDate_ != null ? other.releaseDate_.Clone() : null;
      creationDisabled_ = other.creationDisabled_;
      upgradeDisabled_ = other.upgradeDisabled_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageVersion Clone() {
      return new ImageVersion(this);
    }

    /// <summary>Field number for the "image_version_id" field.</summary>
    public const int ImageVersionIdFieldNumber = 1;
    private string imageVersionId_ = "";
    /// <summary>
    /// The string identifier of the ImageVersion, in the form:
    /// "composer-x.y.z-airflow-a.b.c"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ImageVersionId {
      get { return imageVersionId_; }
      set {
        imageVersionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_default" field.</summary>
    public const int IsDefaultFieldNumber = 2;
    private bool isDefault_;
    /// <summary>
    /// Whether this is the default ImageVersion used by Composer during
    /// environment creation if no input ImageVersion is specified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDefault {
      get { return isDefault_; }
      set {
        isDefault_ = value;
      }
    }

    /// <summary>Field number for the "supported_python_versions" field.</summary>
    public const int SupportedPythonVersionsFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_supportedPythonVersions_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> supportedPythonVersions_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// supported python versions
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> SupportedPythonVersions {
      get { return supportedPythonVersions_; }
    }

    /// <summary>Field number for the "release_date" field.</summary>
    public const int ReleaseDateFieldNumber = 4;
    private global::Google.Type.Date releaseDate_;
    /// <summary>
    /// The date of the version release.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Type.Date ReleaseDate {
      get { return releaseDate_; }
      set {
        releaseDate_ = value;
      }
    }

    /// <summary>Field number for the "creation_disabled" field.</summary>
    public const int CreationDisabledFieldNumber = 5;
    private bool creationDisabled_;
    /// <summary>
    /// Whether it is impossible to create an environment with the image version.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CreationDisabled {
      get { return creationDisabled_; }
      set {
        creationDisabled_ = value;
      }
    }

    /// <summary>Field number for the "upgrade_disabled" field.</summary>
    public const int UpgradeDisabledFieldNumber = 6;
    private bool upgradeDisabled_;
    /// <summary>
    /// Whether it is impossible to upgrade an environment running with the image
    /// version.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UpgradeDisabled {
      get { return upgradeDisabled_; }
      set {
        upgradeDisabled_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ImageVersion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ImageVersion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ImageVersionId != other.ImageVersionId) return false;
      if (IsDefault != other.IsDefault) return false;
      if(!supportedPythonVersions_.Equals(other.supportedPythonVersions_)) return false;
      if (!object.Equals(ReleaseDate, other.ReleaseDate)) return false;
      if (CreationDisabled != other.CreationDisabled) return false;
      if (UpgradeDisabled != other.UpgradeDisabled) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ImageVersionId.Length != 0) hash ^= ImageVersionId.GetHashCode();
      if (IsDefault != false) hash ^= IsDefault.GetHashCode();
      hash ^= supportedPythonVersions_.GetHashCode();
      if (releaseDate_ != null) hash ^= ReleaseDate.GetHashCode();
      if (CreationDisabled != false) hash ^= CreationDisabled.GetHashCode();
      if (UpgradeDisabled != false) hash ^= UpgradeDisabled.GetHashCode();
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
      if (ImageVersionId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ImageVersionId);
      }
      if (IsDefault != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsDefault);
      }
      supportedPythonVersions_.WriteTo(output, _repeated_supportedPythonVersions_codec);
      if (releaseDate_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ReleaseDate);
      }
      if (CreationDisabled != false) {
        output.WriteRawTag(40);
        output.WriteBool(CreationDisabled);
      }
      if (UpgradeDisabled != false) {
        output.WriteRawTag(48);
        output.WriteBool(UpgradeDisabled);
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
      if (ImageVersionId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ImageVersionId);
      }
      if (IsDefault != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsDefault);
      }
      supportedPythonVersions_.WriteTo(ref output, _repeated_supportedPythonVersions_codec);
      if (releaseDate_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ReleaseDate);
      }
      if (CreationDisabled != false) {
        output.WriteRawTag(40);
        output.WriteBool(CreationDisabled);
      }
      if (UpgradeDisabled != false) {
        output.WriteRawTag(48);
        output.WriteBool(UpgradeDisabled);
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
      if (ImageVersionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageVersionId);
      }
      if (IsDefault != false) {
        size += 1 + 1;
      }
      size += supportedPythonVersions_.CalculateSize(_repeated_supportedPythonVersions_codec);
      if (releaseDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReleaseDate);
      }
      if (CreationDisabled != false) {
        size += 1 + 1;
      }
      if (UpgradeDisabled != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ImageVersion other) {
      if (other == null) {
        return;
      }
      if (other.ImageVersionId.Length != 0) {
        ImageVersionId = other.ImageVersionId;
      }
      if (other.IsDefault != false) {
        IsDefault = other.IsDefault;
      }
      supportedPythonVersions_.Add(other.supportedPythonVersions_);
      if (other.releaseDate_ != null) {
        if (releaseDate_ == null) {
          ReleaseDate = new global::Google.Type.Date();
        }
        ReleaseDate.MergeFrom(other.ReleaseDate);
      }
      if (other.CreationDisabled != false) {
        CreationDisabled = other.CreationDisabled;
      }
      if (other.UpgradeDisabled != false) {
        UpgradeDisabled = other.UpgradeDisabled;
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
            ImageVersionId = input.ReadString();
            break;
          }
          case 16: {
            IsDefault = input.ReadBool();
            break;
          }
          case 26: {
            supportedPythonVersions_.AddEntriesFrom(input, _repeated_supportedPythonVersions_codec);
            break;
          }
          case 34: {
            if (releaseDate_ == null) {
              ReleaseDate = new global::Google.Type.Date();
            }
            input.ReadMessage(ReleaseDate);
            break;
          }
          case 40: {
            CreationDisabled = input.ReadBool();
            break;
          }
          case 48: {
            UpgradeDisabled = input.ReadBool();
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
            ImageVersionId = input.ReadString();
            break;
          }
          case 16: {
            IsDefault = input.ReadBool();
            break;
          }
          case 26: {
            supportedPythonVersions_.AddEntriesFrom(ref input, _repeated_supportedPythonVersions_codec);
            break;
          }
          case 34: {
            if (releaseDate_ == null) {
              ReleaseDate = new global::Google.Type.Date();
            }
            input.ReadMessage(ReleaseDate);
            break;
          }
          case 40: {
            CreationDisabled = input.ReadBool();
            break;
          }
          case 48: {
            UpgradeDisabled = input.ReadBool();
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
