// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/iam/v1/iam_policy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Iam.V1 {

  /// <summary>Holder for reflection information generated from google/iam/v1/iam_policy.proto</summary>
  public static partial class IamPolicyReflection {

    #region Descriptor
    /// <summary>File descriptor for google/iam/v1/iam_policy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IamPolicyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5nb29nbGUvaWFtL3YxL2lhbV9wb2xpY3kucHJvdG8SDWdvb2dsZS5pYW0u",
            "djEaG2dvb2dsZS9pYW0vdjEvb3B0aW9ucy5wcm90bxoaZ29vZ2xlL2lhbS92",
            "MS9wb2xpY3kucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8a",
            "F2dvb2dsZS9hcGkvY2xpZW50LnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2Jl",
            "aGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIl4KE1Nl",
            "dElhbVBvbGljeVJlcXVlc3QSGwoIcmVzb3VyY2UYASABKAlCCeBBAvpBAwoB",
            "KhIqCgZwb2xpY3kYAiABKAsyFS5nb29nbGUuaWFtLnYxLlBvbGljeUID4EEC",
            "ImQKE0dldElhbVBvbGljeVJlcXVlc3QSGwoIcmVzb3VyY2UYASABKAlCCeBB",
            "AvpBAwoBKhIwCgdvcHRpb25zGAIgASgLMh8uZ29vZ2xlLmlhbS52MS5HZXRQ",
            "b2xpY3lPcHRpb25zIlIKGVRlc3RJYW1QZXJtaXNzaW9uc1JlcXVlc3QSGwoI",
            "cmVzb3VyY2UYASABKAlCCeBBAvpBAwoBKhIYCgtwZXJtaXNzaW9ucxgCIAMo",
            "CUID4EECIjEKGlRlc3RJYW1QZXJtaXNzaW9uc1Jlc3BvbnNlEhMKC3Blcm1p",
            "c3Npb25zGAEgAygJMrQDCglJQU1Qb2xpY3kSdAoMU2V0SWFtUG9saWN5EiIu",
            "Z29vZ2xlLmlhbS52MS5TZXRJYW1Qb2xpY3lSZXF1ZXN0GhUuZ29vZ2xlLmlh",
            "bS52MS5Qb2xpY3kiKYLT5JMCIyIeL3YxL3tyZXNvdXJjZT0qKn06c2V0SWFt",
            "UG9saWN5OgEqEnQKDEdldElhbVBvbGljeRIiLmdvb2dsZS5pYW0udjEuR2V0",
            "SWFtUG9saWN5UmVxdWVzdBoVLmdvb2dsZS5pYW0udjEuUG9saWN5IimC0+ST",
            "AiMiHi92MS97cmVzb3VyY2U9Kip9OmdldElhbVBvbGljeToBKhKaAQoSVGVz",
            "dElhbVBlcm1pc3Npb25zEiguZ29vZ2xlLmlhbS52MS5UZXN0SWFtUGVybWlz",
            "c2lvbnNSZXF1ZXN0GikuZ29vZ2xlLmlhbS52MS5UZXN0SWFtUGVybWlzc2lv",
            "bnNSZXNwb25zZSIvgtPkkwIpIiQvdjEve3Jlc291cmNlPSoqfTp0ZXN0SWFt",
            "UGVybWlzc2lvbnM6ASoaHspBG2lhbS1tZXRhLWFwaS5nb29nbGVhcGlzLmNv",
            "bUKGAQoRY29tLmdvb2dsZS5pYW0udjFCDklhbVBvbGljeVByb3RvUAFaMGdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvaWFtL3YxO2lh",
            "bfgBAaoCE0dvb2dsZS5DbG91ZC5JYW0uVjHKAhNHb29nbGVcQ2xvdWRcSWFt",
            "XFYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.Iam.V1.OptionsReflection.Descriptor, global::Google.Cloud.Iam.V1.PolicyReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.SetIamPolicyRequest), global::Google.Cloud.Iam.V1.SetIamPolicyRequest.Parser, new[]{ "Resource", "Policy" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.GetIamPolicyRequest), global::Google.Cloud.Iam.V1.GetIamPolicyRequest.Parser, new[]{ "Resource", "Options" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest), global::Google.Cloud.Iam.V1.TestIamPermissionsRequest.Parser, new[]{ "Resource", "Permissions" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.TestIamPermissionsResponse), global::Google.Cloud.Iam.V1.TestIamPermissionsResponse.Parser, new[]{ "Permissions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for `SetIamPolicy` method.
  /// </summary>
  public sealed partial class SetIamPolicyRequest : pb::IMessage<SetIamPolicyRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetIamPolicyRequest> _parser = new pb::MessageParser<SetIamPolicyRequest>(() => new SetIamPolicyRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetIamPolicyRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetIamPolicyRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetIamPolicyRequest(SetIamPolicyRequest other) : this() {
      resource_ = other.resource_;
      policy_ = other.policy_ != null ? other.policy_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetIamPolicyRequest Clone() {
      return new SetIamPolicyRequest(this);
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 1;
    private string resource_ = "";
    /// <summary>
    /// REQUIRED: The resource for which the policy is being specified.
    /// See the operation documentation for the appropriate value for this field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Resource {
      get { return resource_; }
      set {
        resource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "policy" field.</summary>
    public const int PolicyFieldNumber = 2;
    private global::Google.Cloud.Iam.V1.Policy policy_;
    /// <summary>
    /// REQUIRED: The complete policy to be applied to the `resource`. The size of
    /// the policy is limited to a few 10s of KB. An empty policy is a
    /// valid policy but certain Cloud Platform services (such as Projects)
    /// might reject them.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Iam.V1.Policy Policy {
      get { return policy_; }
      set {
        policy_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetIamPolicyRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetIamPolicyRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Resource != other.Resource) return false;
      if (!object.Equals(Policy, other.Policy)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Resource.Length != 0) hash ^= Resource.GetHashCode();
      if (policy_ != null) hash ^= Policy.GetHashCode();
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
      if (Resource.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Resource);
      }
      if (policy_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Policy);
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
      if (Resource.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Resource);
      }
      if (policy_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Policy);
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
      if (Resource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Resource);
      }
      if (policy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Policy);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetIamPolicyRequest other) {
      if (other == null) {
        return;
      }
      if (other.Resource.Length != 0) {
        Resource = other.Resource;
      }
      if (other.policy_ != null) {
        if (policy_ == null) {
          Policy = new global::Google.Cloud.Iam.V1.Policy();
        }
        Policy.MergeFrom(other.Policy);
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
            Resource = input.ReadString();
            break;
          }
          case 18: {
            if (policy_ == null) {
              Policy = new global::Google.Cloud.Iam.V1.Policy();
            }
            input.ReadMessage(Policy);
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
            Resource = input.ReadString();
            break;
          }
          case 18: {
            if (policy_ == null) {
              Policy = new global::Google.Cloud.Iam.V1.Policy();
            }
            input.ReadMessage(Policy);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Request message for `GetIamPolicy` method.
  /// </summary>
  public sealed partial class GetIamPolicyRequest : pb::IMessage<GetIamPolicyRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetIamPolicyRequest> _parser = new pb::MessageParser<GetIamPolicyRequest>(() => new GetIamPolicyRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetIamPolicyRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetIamPolicyRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetIamPolicyRequest(GetIamPolicyRequest other) : this() {
      resource_ = other.resource_;
      options_ = other.options_ != null ? other.options_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetIamPolicyRequest Clone() {
      return new GetIamPolicyRequest(this);
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 1;
    private string resource_ = "";
    /// <summary>
    /// REQUIRED: The resource for which the policy is being requested.
    /// See the operation documentation for the appropriate value for this field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Resource {
      get { return resource_; }
      set {
        resource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "options" field.</summary>
    public const int OptionsFieldNumber = 2;
    private global::Google.Cloud.Iam.V1.GetPolicyOptions options_;
    /// <summary>
    /// OPTIONAL: A `GetPolicyOptions` object for specifying options to
    /// `GetIamPolicy`. This field is only used by Cloud IAM.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Iam.V1.GetPolicyOptions Options {
      get { return options_; }
      set {
        options_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetIamPolicyRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetIamPolicyRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Resource != other.Resource) return false;
      if (!object.Equals(Options, other.Options)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Resource.Length != 0) hash ^= Resource.GetHashCode();
      if (options_ != null) hash ^= Options.GetHashCode();
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
      if (Resource.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Resource);
      }
      if (options_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Options);
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
      if (Resource.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Resource);
      }
      if (options_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Options);
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
      if (Resource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Resource);
      }
      if (options_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Options);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetIamPolicyRequest other) {
      if (other == null) {
        return;
      }
      if (other.Resource.Length != 0) {
        Resource = other.Resource;
      }
      if (other.options_ != null) {
        if (options_ == null) {
          Options = new global::Google.Cloud.Iam.V1.GetPolicyOptions();
        }
        Options.MergeFrom(other.Options);
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
            Resource = input.ReadString();
            break;
          }
          case 18: {
            if (options_ == null) {
              Options = new global::Google.Cloud.Iam.V1.GetPolicyOptions();
            }
            input.ReadMessage(Options);
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
            Resource = input.ReadString();
            break;
          }
          case 18: {
            if (options_ == null) {
              Options = new global::Google.Cloud.Iam.V1.GetPolicyOptions();
            }
            input.ReadMessage(Options);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Request message for `TestIamPermissions` method.
  /// </summary>
  public sealed partial class TestIamPermissionsRequest : pb::IMessage<TestIamPermissionsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TestIamPermissionsRequest> _parser = new pb::MessageParser<TestIamPermissionsRequest>(() => new TestIamPermissionsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TestIamPermissionsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TestIamPermissionsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TestIamPermissionsRequest(TestIamPermissionsRequest other) : this() {
      resource_ = other.resource_;
      permissions_ = other.permissions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TestIamPermissionsRequest Clone() {
      return new TestIamPermissionsRequest(this);
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 1;
    private string resource_ = "";
    /// <summary>
    /// REQUIRED: The resource for which the policy detail is being requested.
    /// See the operation documentation for the appropriate value for this field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Resource {
      get { return resource_; }
      set {
        resource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "permissions" field.</summary>
    public const int PermissionsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_permissions_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> permissions_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The set of permissions to check for the `resource`. Permissions with
    /// wildcards (such as '*' or 'storage.*') are not allowed. For more
    /// information see
    /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Permissions {
      get { return permissions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TestIamPermissionsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TestIamPermissionsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Resource != other.Resource) return false;
      if(!permissions_.Equals(other.permissions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Resource.Length != 0) hash ^= Resource.GetHashCode();
      hash ^= permissions_.GetHashCode();
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
      if (Resource.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Resource);
      }
      permissions_.WriteTo(output, _repeated_permissions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Resource.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Resource);
      }
      permissions_.WriteTo(ref output, _repeated_permissions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Resource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Resource);
      }
      size += permissions_.CalculateSize(_repeated_permissions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TestIamPermissionsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Resource.Length != 0) {
        Resource = other.Resource;
      }
      permissions_.Add(other.permissions_);
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
            Resource = input.ReadString();
            break;
          }
          case 18: {
            permissions_.AddEntriesFrom(input, _repeated_permissions_codec);
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
            Resource = input.ReadString();
            break;
          }
          case 18: {
            permissions_.AddEntriesFrom(ref input, _repeated_permissions_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response message for `TestIamPermissions` method.
  /// </summary>
  public sealed partial class TestIamPermissionsResponse : pb::IMessage<TestIamPermissionsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TestIamPermissionsResponse> _parser = new pb::MessageParser<TestIamPermissionsResponse>(() => new TestIamPermissionsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TestIamPermissionsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TestIamPermissionsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TestIamPermissionsResponse(TestIamPermissionsResponse other) : this() {
      permissions_ = other.permissions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TestIamPermissionsResponse Clone() {
      return new TestIamPermissionsResponse(this);
    }

    /// <summary>Field number for the "permissions" field.</summary>
    public const int PermissionsFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_permissions_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> permissions_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A subset of `TestPermissionsRequest.permissions` that the caller is
    /// allowed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Permissions {
      get { return permissions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TestIamPermissionsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TestIamPermissionsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!permissions_.Equals(other.permissions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= permissions_.GetHashCode();
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
      permissions_.WriteTo(output, _repeated_permissions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      permissions_.WriteTo(ref output, _repeated_permissions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += permissions_.CalculateSize(_repeated_permissions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TestIamPermissionsResponse other) {
      if (other == null) {
        return;
      }
      permissions_.Add(other.permissions_);
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
            permissions_.AddEntriesFrom(input, _repeated_permissions_codec);
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
            permissions_.AddEntriesFrom(ref input, _repeated_permissions_codec);
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
