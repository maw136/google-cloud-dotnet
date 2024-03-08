// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v2/cloud_dlp_data_profile.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v2/cloud_dlp_data_profile.proto</summary>
  public static partial class CloudDlpDataProfileReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v2/cloud_dlp_data_profile.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CloudDlpDataProfileReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjIvY2xvdWRfZGxwX2Rh",
            "dGFfcHJvZmlsZS5wcm90bxIeZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVy",
            "LnYyGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIvQBChNDbG91ZERscERh",
            "dGFQcm9maWxlEj4KDGRhdGFfcHJvZmlsZRgBIAEoCUIo+kElCiNkbHAuZ29v",
            "Z2xlYXBpcy5jb20vVGFibGVEYXRhUHJvZmlsZRJTCgtwYXJlbnRfdHlwZRgC",
            "IAEoDjI+Lmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52Mi5DbG91ZERs",
            "cERhdGFQcm9maWxlLlBhcmVudFR5cGUiSAoKUGFyZW50VHlwZRIbChdQQVJF",
            "TlRfVFlQRV9VTlNQRUNJRklFRBAAEhAKDE9SR0FOSVpBVElPThABEgsKB1BS",
            "T0pFQ1QQAkKUAwoiY29tLmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52",
            "MkIYQ2xvdWREbHBEYXRhUHJvZmlsZVByb3RvUAFaSmNsb3VkLmdvb2dsZS5j",
            "b20vZ28vc2VjdXJpdHljZW50ZXIvYXBpdjIvc2VjdXJpdHljZW50ZXJwYjtz",
            "ZWN1cml0eWNlbnRlcnBiqgIeR29vZ2xlLkNsb3VkLlNlY3VyaXR5Q2VudGVy",
            "LlYyygIeR29vZ2xlXENsb3VkXFNlY3VyaXR5Q2VudGVyXFYy6gIhR29vZ2xl",
            "OjpDbG91ZDo6U2VjdXJpdHlDZW50ZXI6OlYy6kGeAQojZGxwLmdvb2dsZWFw",
            "aXMuY29tL1RhYmxlRGF0YVByb2ZpbGUSMHByb2plY3RzL3twcm9qZWN0fS90",
            "YWJsZVByb2ZpbGVzL3t0YWJsZV9wcm9maWxlfRJFcHJvamVjdHMve3Byb2pl",
            "Y3R9L2xvY2F0aW9ucy97bG9jYXRpb259L3RhYmxlUHJvZmlsZXMve3RhYmxl",
            "X3Byb2ZpbGV9YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile), global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Parser, new[]{ "DataProfile", "ParentType" }, null, new[]{ typeof(global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Types.ParentType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The [data profile](https://cloud.google.com/dlp/docs/data-profiles)
  /// associated with the finding.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CloudDlpDataProfile : pb::IMessage<CloudDlpDataProfile>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CloudDlpDataProfile> _parser = new pb::MessageParser<CloudDlpDataProfile>(() => new CloudDlpDataProfile());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CloudDlpDataProfile> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfileReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudDlpDataProfile() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudDlpDataProfile(CloudDlpDataProfile other) : this() {
      dataProfile_ = other.dataProfile_;
      parentType_ = other.parentType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CloudDlpDataProfile Clone() {
      return new CloudDlpDataProfile(this);
    }

    /// <summary>Field number for the "data_profile" field.</summary>
    public const int DataProfileFieldNumber = 1;
    private string dataProfile_ = "";
    /// <summary>
    /// Name of the data profile, for example,
    /// `projects/123/locations/europe/tableProfiles/8383929`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DataProfile {
      get { return dataProfile_; }
      set {
        dataProfile_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parent_type" field.</summary>
    public const int ParentTypeFieldNumber = 2;
    private global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Types.ParentType parentType_ = global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Types.ParentType.Unspecified;
    /// <summary>
    /// The resource hierarchy level at which the data profile was generated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Types.ParentType ParentType {
      get { return parentType_; }
      set {
        parentType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CloudDlpDataProfile);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CloudDlpDataProfile other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DataProfile != other.DataProfile) return false;
      if (ParentType != other.ParentType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DataProfile.Length != 0) hash ^= DataProfile.GetHashCode();
      if (ParentType != global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Types.ParentType.Unspecified) hash ^= ParentType.GetHashCode();
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
      if (DataProfile.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DataProfile);
      }
      if (ParentType != global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Types.ParentType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ParentType);
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
      if (DataProfile.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DataProfile);
      }
      if (ParentType != global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Types.ParentType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ParentType);
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
      if (DataProfile.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DataProfile);
      }
      if (ParentType != global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Types.ParentType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ParentType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CloudDlpDataProfile other) {
      if (other == null) {
        return;
      }
      if (other.DataProfile.Length != 0) {
        DataProfile = other.DataProfile;
      }
      if (other.ParentType != global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Types.ParentType.Unspecified) {
        ParentType = other.ParentType;
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
            DataProfile = input.ReadString();
            break;
          }
          case 16: {
            ParentType = (global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Types.ParentType) input.ReadEnum();
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
            DataProfile = input.ReadString();
            break;
          }
          case 16: {
            ParentType = (global::Google.Cloud.SecurityCenter.V2.CloudDlpDataProfile.Types.ParentType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CloudDlpDataProfile message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Parents for configurations that produce data profile findings.
      /// </summary>
      public enum ParentType {
        /// <summary>
        /// Unspecified parent type.
        /// </summary>
        [pbr::OriginalName("PARENT_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Organization-level configurations.
        /// </summary>
        [pbr::OriginalName("ORGANIZATION")] Organization = 1,
        /// <summary>
        /// Project-level configurations.
        /// </summary>
        [pbr::OriginalName("PROJECT")] Project = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
