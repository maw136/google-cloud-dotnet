// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/servicecontrol/v1/check_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ServiceControl.V1 {

  /// <summary>Holder for reflection information generated from google/api/servicecontrol/v1/check_error.proto</summary>
  public static partial class CheckErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/servicecontrol/v1/check_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheckErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvYXBpL3NlcnZpY2Vjb250cm9sL3YxL2NoZWNrX2Vycm9yLnBy",
            "b3RvEhxnb29nbGUuYXBpLnNlcnZpY2Vjb250cm9sLnYxGhdnb29nbGUvcnBj",
            "L3N0YXR1cy5wcm90byKuBQoKQ2hlY2tFcnJvchI7CgRjb2RlGAEgASgOMi0u",
            "Z29vZ2xlLmFwaS5zZXJ2aWNlY29udHJvbC52MS5DaGVja0Vycm9yLkNvZGUS",
            "DwoHc3ViamVjdBgEIAEoCRIOCgZkZXRhaWwYAiABKAkSIgoGc3RhdHVzGAMg",
            "ASgLMhIuZ29vZ2xlLnJwYy5TdGF0dXMinQQKBENvZGUSGgoWRVJST1JfQ09E",
            "RV9VTlNQRUNJRklFRBAAEg0KCU5PVF9GT1VORBAFEhUKEVBFUk1JU1NJT05f",
            "REVOSUVEEAcSFgoSUkVTT1VSQ0VfRVhIQVVTVEVEEAgSGQoVU0VSVklDRV9O",
            "T1RfQUNUSVZBVEVEEGgSFAoQQklMTElOR19ESVNBQkxFRBBrEhMKD1BST0pF",
            "Q1RfREVMRVRFRBBsEhMKD1BST0pFQ1RfSU5WQUxJRBByEhQKEENPTlNVTUVS",
            "X0lOVkFMSUQQfRIWChJJUF9BRERSRVNTX0JMT0NLRUQQbRITCg9SRUZFUkVS",
            "X0JMT0NLRUQQbhIWChJDTElFTlRfQVBQX0JMT0NLRUQQbxIWChJBUElfVEFS",
            "R0VUX0JMT0NLRUQQehITCg9BUElfS0VZX0lOVkFMSUQQaRITCg9BUElfS0VZ",
            "X0VYUElSRUQQcBIVChFBUElfS0VZX05PVF9GT1VORBBxEhYKEklOVkFMSURf",
            "Q1JFREVOVElBTBB7EiEKHE5BTUVTUEFDRV9MT09LVVBfVU5BVkFJTEFCTEUQ",
            "rAISHwoaU0VSVklDRV9TVEFUVVNfVU5BVkFJTEFCTEUQrQISHwoaQklMTElO",
            "R19TVEFUVVNfVU5BVkFJTEFCTEUQrgISLwoqQ0xPVURfUkVTT1VSQ0VfTUFO",
            "QUdFUl9CQUNLRU5EX1VOQVZBSUxBQkxFELECQuoBCiBjb20uZ29vZ2xlLmFw",
            "aS5zZXJ2aWNlY29udHJvbC52MUIPQ2hlY2tFcnJvclByb3RvUAFaSmNsb3Vk",
            "Lmdvb2dsZS5jb20vZ28vc2VydmljZWNvbnRyb2wvYXBpdjEvc2VydmljZWNv",
            "bnRyb2xwYjtzZXJ2aWNlY29udHJvbHBi+AEBqgIeR29vZ2xlLkNsb3VkLlNl",
            "cnZpY2VDb250cm9sLlYxygIeR29vZ2xlXENsb3VkXFNlcnZpY2VDb250cm9s",
            "XFYx6gIhR29vZ2xlOjpDbG91ZDo6U2VydmljZUNvbnRyb2w6OlYxYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Rpc.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ServiceControl.V1.CheckError), global::Google.Cloud.ServiceControl.V1.CheckError.Parser, new[]{ "Code", "Subject", "Detail", "Status" }, null, new[]{ typeof(global::Google.Cloud.ServiceControl.V1.CheckError.Types.Code) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Defines the errors to be returned in
  /// [google.api.servicecontrol.v1.CheckResponse.check_errors][google.api.servicecontrol.v1.CheckResponse.check_errors].
  /// </summary>
  public sealed partial class CheckError : pb::IMessage<CheckError>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CheckError> _parser = new pb::MessageParser<CheckError>(() => new CheckError());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CheckError> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ServiceControl.V1.CheckErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckError() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckError(CheckError other) : this() {
      code_ = other.code_;
      subject_ = other.subject_;
      detail_ = other.detail_;
      status_ = other.status_ != null ? other.status_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckError Clone() {
      return new CheckError(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private global::Google.Cloud.ServiceControl.V1.CheckError.Types.Code code_ = global::Google.Cloud.ServiceControl.V1.CheckError.Types.Code.ErrorCodeUnspecified;
    /// <summary>
    /// The error code.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.ServiceControl.V1.CheckError.Types.Code Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "subject" field.</summary>
    public const int SubjectFieldNumber = 4;
    private string subject_ = "";
    /// <summary>
    /// Subject to whom this error applies. See the specific code enum for more
    /// details on this field. For example:
    ///
    /// - "project:&lt;project-id or project-number>"
    /// - "folder:&lt;folder-id>"
    /// - "organization:&lt;organization-id>"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Subject {
      get { return subject_; }
      set {
        subject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "detail" field.</summary>
    public const int DetailFieldNumber = 2;
    private string detail_ = "";
    /// <summary>
    /// Free-form text providing details on the error cause of the error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Detail {
      get { return detail_; }
      set {
        detail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::Google.Rpc.Status status_;
    /// <summary>
    /// Contains public information about the check error. If available,
    /// `status.code` will be non zero and client can propagate it out as public
    /// error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Rpc.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CheckError);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CheckError other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (Subject != other.Subject) return false;
      if (Detail != other.Detail) return false;
      if (!object.Equals(Status, other.Status)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != global::Google.Cloud.ServiceControl.V1.CheckError.Types.Code.ErrorCodeUnspecified) hash ^= Code.GetHashCode();
      if (Subject.Length != 0) hash ^= Subject.GetHashCode();
      if (Detail.Length != 0) hash ^= Detail.GetHashCode();
      if (status_ != null) hash ^= Status.GetHashCode();
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
      if (Code != global::Google.Cloud.ServiceControl.V1.CheckError.Types.Code.ErrorCodeUnspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
      if (Detail.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Detail);
      }
      if (status_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Status);
      }
      if (Subject.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Subject);
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
      if (Code != global::Google.Cloud.ServiceControl.V1.CheckError.Types.Code.ErrorCodeUnspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
      if (Detail.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Detail);
      }
      if (status_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Status);
      }
      if (Subject.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Subject);
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
      if (Code != global::Google.Cloud.ServiceControl.V1.CheckError.Types.Code.ErrorCodeUnspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
      }
      if (Subject.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Subject);
      }
      if (Detail.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Detail);
      }
      if (status_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CheckError other) {
      if (other == null) {
        return;
      }
      if (other.Code != global::Google.Cloud.ServiceControl.V1.CheckError.Types.Code.ErrorCodeUnspecified) {
        Code = other.Code;
      }
      if (other.Subject.Length != 0) {
        Subject = other.Subject;
      }
      if (other.Detail.Length != 0) {
        Detail = other.Detail;
      }
      if (other.status_ != null) {
        if (status_ == null) {
          Status = new global::Google.Rpc.Status();
        }
        Status.MergeFrom(other.Status);
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
            Code = (global::Google.Cloud.ServiceControl.V1.CheckError.Types.Code) input.ReadEnum();
            break;
          }
          case 18: {
            Detail = input.ReadString();
            break;
          }
          case 26: {
            if (status_ == null) {
              Status = new global::Google.Rpc.Status();
            }
            input.ReadMessage(Status);
            break;
          }
          case 34: {
            Subject = input.ReadString();
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
            Code = (global::Google.Cloud.ServiceControl.V1.CheckError.Types.Code) input.ReadEnum();
            break;
          }
          case 18: {
            Detail = input.ReadString();
            break;
          }
          case 26: {
            if (status_ == null) {
              Status = new global::Google.Rpc.Status();
            }
            input.ReadMessage(Status);
            break;
          }
          case 34: {
            Subject = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CheckError message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Error codes for Check responses.
      /// </summary>
      public enum Code {
        /// <summary>
        /// This is never used in `CheckResponse`.
        /// </summary>
        [pbr::OriginalName("ERROR_CODE_UNSPECIFIED")] ErrorCodeUnspecified = 0,
        /// <summary>
        /// The consumer's project id, network container, or resource container was
        /// not found. Same as [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND].
        /// </summary>
        [pbr::OriginalName("NOT_FOUND")] NotFound = 5,
        /// <summary>
        /// The consumer doesn't have access to the specified resource.
        /// Same as [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED].
        /// </summary>
        [pbr::OriginalName("PERMISSION_DENIED")] PermissionDenied = 7,
        /// <summary>
        /// Quota check failed. Same as [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED].
        /// </summary>
        [pbr::OriginalName("RESOURCE_EXHAUSTED")] ResourceExhausted = 8,
        /// <summary>
        /// The consumer hasn't activated the service.
        /// </summary>
        [pbr::OriginalName("SERVICE_NOT_ACTIVATED")] ServiceNotActivated = 104,
        /// <summary>
        /// The consumer cannot access the service because billing is disabled.
        /// </summary>
        [pbr::OriginalName("BILLING_DISABLED")] BillingDisabled = 107,
        /// <summary>
        /// The consumer's project has been marked as deleted (soft deletion).
        /// </summary>
        [pbr::OriginalName("PROJECT_DELETED")] ProjectDeleted = 108,
        /// <summary>
        /// The consumer's project number or id does not represent a valid project.
        /// </summary>
        [pbr::OriginalName("PROJECT_INVALID")] ProjectInvalid = 114,
        /// <summary>
        /// The input consumer info does not represent a valid consumer folder or
        /// organization.
        /// </summary>
        [pbr::OriginalName("CONSUMER_INVALID")] ConsumerInvalid = 125,
        /// <summary>
        /// The IP address of the consumer is invalid for the specific consumer
        /// project.
        /// </summary>
        [pbr::OriginalName("IP_ADDRESS_BLOCKED")] IpAddressBlocked = 109,
        /// <summary>
        /// The referer address of the consumer request is invalid for the specific
        /// consumer project.
        /// </summary>
        [pbr::OriginalName("REFERER_BLOCKED")] RefererBlocked = 110,
        /// <summary>
        /// The client application of the consumer request is invalid for the
        /// specific consumer project.
        /// </summary>
        [pbr::OriginalName("CLIENT_APP_BLOCKED")] ClientAppBlocked = 111,
        /// <summary>
        /// The API targeted by this request is invalid for the specified consumer
        /// project.
        /// </summary>
        [pbr::OriginalName("API_TARGET_BLOCKED")] ApiTargetBlocked = 122,
        /// <summary>
        /// The consumer's API key is invalid.
        /// </summary>
        [pbr::OriginalName("API_KEY_INVALID")] ApiKeyInvalid = 105,
        /// <summary>
        /// The consumer's API Key has expired.
        /// </summary>
        [pbr::OriginalName("API_KEY_EXPIRED")] ApiKeyExpired = 112,
        /// <summary>
        /// The consumer's API Key was not found in config record.
        /// </summary>
        [pbr::OriginalName("API_KEY_NOT_FOUND")] ApiKeyNotFound = 113,
        /// <summary>
        /// The credential in the request can not be verified.
        /// </summary>
        [pbr::OriginalName("INVALID_CREDENTIAL")] InvalidCredential = 123,
        /// <summary>
        /// The backend server for looking up project id/number is unavailable.
        /// </summary>
        [pbr::OriginalName("NAMESPACE_LOOKUP_UNAVAILABLE")] NamespaceLookupUnavailable = 300,
        /// <summary>
        /// The backend server for checking service status is unavailable.
        /// </summary>
        [pbr::OriginalName("SERVICE_STATUS_UNAVAILABLE")] ServiceStatusUnavailable = 301,
        /// <summary>
        /// The backend server for checking billing status is unavailable.
        /// </summary>
        [pbr::OriginalName("BILLING_STATUS_UNAVAILABLE")] BillingStatusUnavailable = 302,
        /// <summary>
        /// Cloud Resource Manager backend server is unavailable.
        /// </summary>
        [pbr::OriginalName("CLOUD_RESOURCE_MANAGER_BACKEND_UNAVAILABLE")] CloudResourceManagerBackendUnavailable = 305,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
