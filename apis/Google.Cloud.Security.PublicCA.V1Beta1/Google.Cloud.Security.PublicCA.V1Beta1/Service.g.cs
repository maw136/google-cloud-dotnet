// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/security/publicca/v1beta1/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Security.PublicCA.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/security/publicca/v1beta1/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/security/publicca/v1beta1/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvY2xvdWQvc2VjdXJpdHkvcHVibGljY2EvdjFiZXRhMS9zZXJ2",
            "aWNlLnByb3RvEiZnb29nbGUuY2xvdWQuc2VjdXJpdHkucHVibGljY2EudjFi",
            "ZXRhMRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2Fw",
            "aS9jbGllbnQucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJv",
            "dG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aNmdvb2dsZS9jbG91ZC9z",
            "ZWN1cml0eS9wdWJsaWNjYS92MWJldGExL3Jlc291cmNlcy5wcm90byLGAQof",
            "Q3JlYXRlRXh0ZXJuYWxBY2NvdW50S2V5UmVxdWVzdBJDCgZwYXJlbnQYASAB",
            "KAlCM+JBAQL6QSwSKnB1YmxpY2NhLmdvb2dsZWFwaXMuY29tL0V4dGVybmFs",
            "QWNjb3VudEtleRJeChRleHRlcm5hbF9hY2NvdW50X2tleRgCIAEoCzI6Lmdv",
            "b2dsZS5jbG91ZC5zZWN1cml0eS5wdWJsaWNjYS52MWJldGExLkV4dGVybmFs",
            "QWNjb3VudEtleUIE4kEBAjKMAwohUHVibGljQ2VydGlmaWNhdGVBdXRob3Jp",
            "dHlTZXJ2aWNlEpkCChhDcmVhdGVFeHRlcm5hbEFjY291bnRLZXkSRy5nb29n",
            "bGUuY2xvdWQuc2VjdXJpdHkucHVibGljY2EudjFiZXRhMS5DcmVhdGVFeHRl",
            "cm5hbEFjY291bnRLZXlSZXF1ZXN0GjouZ29vZ2xlLmNsb3VkLnNlY3VyaXR5",
            "LnB1YmxpY2NhLnYxYmV0YTEuRXh0ZXJuYWxBY2NvdW50S2V5InjaQRtwYXJl",
            "bnQsZXh0ZXJuYWxfYWNjb3VudF9rZXmC0+STAlQiPC92MWJldGExL3twYXJl",
            "bnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vZXh0ZXJuYWxBY2NvdW50S2V5",
            "czoUZXh0ZXJuYWxfYWNjb3VudF9rZXkaS8pBF3B1YmxpY2NhLmdvb2dsZWFw",
            "aXMuY29t0kEuaHR0cHM6Ly93d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9jbG91",
            "ZC1wbGF0Zm9ybUKGAgoqY29tLmdvb2dsZS5jbG91ZC5zZWN1cml0eS5wdWJs",
            "aWNjYS52MWJldGExQgxTZXJ2aWNlUHJvdG9QAVpGY2xvdWQuZ29vZ2xlLmNv",
            "bS9nby9zZWN1cml0eS9wdWJsaWNjYS9hcGl2MWJldGExL3B1YmxpY2NhcGI7",
            "cHVibGljY2FwYvgBAaoCJkdvb2dsZS5DbG91ZC5TZWN1cml0eS5QdWJsaWND",
            "QS5WMUJldGExygImR29vZ2xlXENsb3VkXFNlY3VyaXR5XFB1YmxpY0NBXFYx",
            "YmV0YTHqAipHb29nbGU6OkNsb3VkOjpTZWN1cml0eTo6UHVibGljQ0E6OlYx",
            "YmV0YTFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Security.PublicCA.V1Beta1.ResourcesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Security.PublicCA.V1Beta1.CreateExternalAccountKeyRequest), global::Google.Cloud.Security.PublicCA.V1Beta1.CreateExternalAccountKeyRequest.Parser, new[]{ "Parent", "ExternalAccountKey" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] in a given project.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CreateExternalAccountKeyRequest : pb::IMessage<CreateExternalAccountKeyRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateExternalAccountKeyRequest> _parser = new pb::MessageParser<CreateExternalAccountKeyRequest>(() => new CreateExternalAccountKeyRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateExternalAccountKeyRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Security.PublicCA.V1Beta1.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateExternalAccountKeyRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateExternalAccountKeyRequest(CreateExternalAccountKeyRequest other) : this() {
      parent_ = other.parent_;
      externalAccountKey_ = other.externalAccountKey_ != null ? other.externalAccountKey_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateExternalAccountKeyRequest Clone() {
      return new CreateExternalAccountKeyRequest(this);
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 1;
    private string parent_ = "";
    /// <summary>
    /// Required. The parent resource where this external_account_key will be created.
    /// Format: projects/[project_id]/locations/[location].
    /// At present only the "global" location is supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "external_account_key" field.</summary>
    public const int ExternalAccountKeyFieldNumber = 2;
    private global::Google.Cloud.Security.PublicCA.V1Beta1.ExternalAccountKey externalAccountKey_;
    /// <summary>
    /// Required. The external account key to create. This field only exists to future-proof
    /// the API. At present, all fields in ExternalAccountKey are output only and
    /// all values are ignored. For the purpose of the
    /// CreateExternalAccountKeyRequest, set it to a default/empty value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Security.PublicCA.V1Beta1.ExternalAccountKey ExternalAccountKey {
      get { return externalAccountKey_; }
      set {
        externalAccountKey_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateExternalAccountKeyRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateExternalAccountKeyRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Parent != other.Parent) return false;
      if (!object.Equals(ExternalAccountKey, other.ExternalAccountKey)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (externalAccountKey_ != null) hash ^= ExternalAccountKey.GetHashCode();
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
      if (externalAccountKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ExternalAccountKey);
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
      if (externalAccountKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ExternalAccountKey);
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
      if (externalAccountKey_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExternalAccountKey);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateExternalAccountKeyRequest other) {
      if (other == null) {
        return;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.externalAccountKey_ != null) {
        if (externalAccountKey_ == null) {
          ExternalAccountKey = new global::Google.Cloud.Security.PublicCA.V1Beta1.ExternalAccountKey();
        }
        ExternalAccountKey.MergeFrom(other.ExternalAccountKey);
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
          case 18: {
            if (externalAccountKey_ == null) {
              ExternalAccountKey = new global::Google.Cloud.Security.PublicCA.V1Beta1.ExternalAccountKey();
            }
            input.ReadMessage(ExternalAccountKey);
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
          case 18: {
            if (externalAccountKey_ == null) {
              ExternalAccountKey = new global::Google.Cloud.Security.PublicCA.V1Beta1.ExternalAccountKey();
            }
            input.ReadMessage(ExternalAccountKey);
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
