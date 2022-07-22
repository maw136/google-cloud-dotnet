// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/policytroubleshooter/v1/checker.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.PolicyTroubleshooter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/policytroubleshooter/v1/checker.proto</summary>
  public static partial class CheckerReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/policytroubleshooter/v1/checker.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheckerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvY2xvdWQvcG9saWN5dHJvdWJsZXNob290ZXIvdjEvY2hlY2tl",
            "ci5wcm90bxIkZ29vZ2xlLmNsb3VkLnBvbGljeXRyb3VibGVzaG9vdGVyLnYx",
            "Gjdnb29nbGUvY2xvdWQvcG9saWN5dHJvdWJsZXNob290ZXIvdjEvZXhwbGFu",
            "YXRpb25zLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhdn",
            "b29nbGUvYXBpL2NsaWVudC5wcm90byJnChxUcm91Ymxlc2hvb3RJYW1Qb2xp",
            "Y3lSZXF1ZXN0EkcKDGFjY2Vzc190dXBsZRgBIAEoCzIxLmdvb2dsZS5jbG91",
            "ZC5wb2xpY3l0cm91Ymxlc2hvb3Rlci52MS5BY2Nlc3NUdXBsZSK1AQodVHJv",
            "dWJsZXNob290SWFtUG9saWN5UmVzcG9uc2USQQoGYWNjZXNzGAEgASgOMjEu",
            "Z29vZ2xlLmNsb3VkLnBvbGljeXRyb3VibGVzaG9vdGVyLnYxLkFjY2Vzc1N0",
            "YXRlElEKEmV4cGxhaW5lZF9wb2xpY2llcxgCIAMoCzI1Lmdvb2dsZS5jbG91",
            "ZC5wb2xpY3l0cm91Ymxlc2hvb3Rlci52MS5FeHBsYWluZWRQb2xpY3kyqQIK",
            "CklhbUNoZWNrZXISwQEKFVRyb3VibGVzaG9vdElhbVBvbGljeRJCLmdvb2ds",
            "ZS5jbG91ZC5wb2xpY3l0cm91Ymxlc2hvb3Rlci52MS5Ucm91Ymxlc2hvb3RJ",
            "YW1Qb2xpY3lSZXF1ZXN0GkMuZ29vZ2xlLmNsb3VkLnBvbGljeXRyb3VibGVz",
            "aG9vdGVyLnYxLlRyb3VibGVzaG9vdElhbVBvbGljeVJlc3BvbnNlIh+C0+ST",
            "AhkiFC92MS9pYW06dHJvdWJsZXNob290OgEqGlfKQSNwb2xpY3l0cm91Ymxl",
            "c2hvb3Rlci5nb29nbGVhcGlzLmNvbdJBLmh0dHBzOi8vd3d3Lmdvb2dsZWFw",
            "aXMuY29tL2F1dGgvY2xvdWQtcGxhdGZvcm1CkgIKKGNvbS5nb29nbGUuY2xv",
            "dWQucG9saWN5dHJvdWJsZXNob290ZXIudjFCD0lBTUNoZWNrZXJQcm90b1AB",
            "Wlhnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3Vk",
            "L3BvbGljeXRyb3VibGVzaG9vdGVyL3YxO3BvbGljeXRyb3VibGVzaG9vdGVy",
            "+AEBqgIkR29vZ2xlLkNsb3VkLlBvbGljeVRyb3VibGVzaG9vdGVyLlYxygIk",
            "R29vZ2xlXENsb3VkXFBvbGljeVRyb3VibGVzaG9vdGVyXFYx6gInR29vZ2xl",
            "OjpDbG91ZDo6UG9saWN5VHJvdWJsZXNob290ZXI6OlYxUABiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.PolicyTroubleshooter.V1.ExplanationsReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.PolicyTroubleshooter.V1.TroubleshootIamPolicyRequest), global::Google.Cloud.PolicyTroubleshooter.V1.TroubleshootIamPolicyRequest.Parser, new[]{ "AccessTuple" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.PolicyTroubleshooter.V1.TroubleshootIamPolicyResponse), global::Google.Cloud.PolicyTroubleshooter.V1.TroubleshootIamPolicyResponse.Parser, new[]{ "Access", "ExplainedPolicies" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request for [TroubleshootIamPolicy][google.cloud.policytroubleshooter.v1.IamChecker.TroubleshootIamPolicy].
  /// </summary>
  public sealed partial class TroubleshootIamPolicyRequest : pb::IMessage<TroubleshootIamPolicyRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TroubleshootIamPolicyRequest> _parser = new pb::MessageParser<TroubleshootIamPolicyRequest>(() => new TroubleshootIamPolicyRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TroubleshootIamPolicyRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.PolicyTroubleshooter.V1.CheckerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TroubleshootIamPolicyRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TroubleshootIamPolicyRequest(TroubleshootIamPolicyRequest other) : this() {
      accessTuple_ = other.accessTuple_ != null ? other.accessTuple_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TroubleshootIamPolicyRequest Clone() {
      return new TroubleshootIamPolicyRequest(this);
    }

    /// <summary>Field number for the "access_tuple" field.</summary>
    public const int AccessTupleFieldNumber = 1;
    private global::Google.Cloud.PolicyTroubleshooter.V1.AccessTuple accessTuple_;
    /// <summary>
    /// The information to use for checking whether a member has a permission for a
    /// resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.PolicyTroubleshooter.V1.AccessTuple AccessTuple {
      get { return accessTuple_; }
      set {
        accessTuple_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TroubleshootIamPolicyRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TroubleshootIamPolicyRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AccessTuple, other.AccessTuple)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (accessTuple_ != null) hash ^= AccessTuple.GetHashCode();
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
      if (accessTuple_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessTuple);
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
      if (accessTuple_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessTuple);
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
      if (accessTuple_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccessTuple);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TroubleshootIamPolicyRequest other) {
      if (other == null) {
        return;
      }
      if (other.accessTuple_ != null) {
        if (accessTuple_ == null) {
          AccessTuple = new global::Google.Cloud.PolicyTroubleshooter.V1.AccessTuple();
        }
        AccessTuple.MergeFrom(other.AccessTuple);
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
            if (accessTuple_ == null) {
              AccessTuple = new global::Google.Cloud.PolicyTroubleshooter.V1.AccessTuple();
            }
            input.ReadMessage(AccessTuple);
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
            if (accessTuple_ == null) {
              AccessTuple = new global::Google.Cloud.PolicyTroubleshooter.V1.AccessTuple();
            }
            input.ReadMessage(AccessTuple);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response for [TroubleshootIamPolicy][google.cloud.policytroubleshooter.v1.IamChecker.TroubleshootIamPolicy].
  /// </summary>
  public sealed partial class TroubleshootIamPolicyResponse : pb::IMessage<TroubleshootIamPolicyResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TroubleshootIamPolicyResponse> _parser = new pb::MessageParser<TroubleshootIamPolicyResponse>(() => new TroubleshootIamPolicyResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TroubleshootIamPolicyResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.PolicyTroubleshooter.V1.CheckerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TroubleshootIamPolicyResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TroubleshootIamPolicyResponse(TroubleshootIamPolicyResponse other) : this() {
      access_ = other.access_;
      explainedPolicies_ = other.explainedPolicies_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TroubleshootIamPolicyResponse Clone() {
      return new TroubleshootIamPolicyResponse(this);
    }

    /// <summary>Field number for the "access" field.</summary>
    public const int AccessFieldNumber = 1;
    private global::Google.Cloud.PolicyTroubleshooter.V1.AccessState access_ = global::Google.Cloud.PolicyTroubleshooter.V1.AccessState.Unspecified;
    /// <summary>
    /// Indicates whether the member has the specified permission for the specified
    /// resource, based on evaluating all of the applicable IAM policies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.PolicyTroubleshooter.V1.AccessState Access {
      get { return access_; }
      set {
        access_ = value;
      }
    }

    /// <summary>Field number for the "explained_policies" field.</summary>
    public const int ExplainedPoliciesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Cloud.PolicyTroubleshooter.V1.ExplainedPolicy> _repeated_explainedPolicies_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Cloud.PolicyTroubleshooter.V1.ExplainedPolicy.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.PolicyTroubleshooter.V1.ExplainedPolicy> explainedPolicies_ = new pbc::RepeatedField<global::Google.Cloud.PolicyTroubleshooter.V1.ExplainedPolicy>();
    /// <summary>
    /// List of IAM policies that were evaluated to check the member's permissions,
    /// with annotations to indicate how each policy contributed to the final
    /// result.
    ///
    /// The list of policies can include the policy for the resource itself. It can
    /// also include policies that are inherited from higher levels of the resource
    /// hierarchy, including the organization, the folder, and the project.
    ///
    /// To learn more about the resource hierarchy, see
    /// https://cloud.google.com/iam/help/resource-hierarchy.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.PolicyTroubleshooter.V1.ExplainedPolicy> ExplainedPolicies {
      get { return explainedPolicies_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TroubleshootIamPolicyResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TroubleshootIamPolicyResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Access != other.Access) return false;
      if(!explainedPolicies_.Equals(other.explainedPolicies_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Access != global::Google.Cloud.PolicyTroubleshooter.V1.AccessState.Unspecified) hash ^= Access.GetHashCode();
      hash ^= explainedPolicies_.GetHashCode();
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
      if (Access != global::Google.Cloud.PolicyTroubleshooter.V1.AccessState.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Access);
      }
      explainedPolicies_.WriteTo(output, _repeated_explainedPolicies_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Access != global::Google.Cloud.PolicyTroubleshooter.V1.AccessState.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Access);
      }
      explainedPolicies_.WriteTo(ref output, _repeated_explainedPolicies_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Access != global::Google.Cloud.PolicyTroubleshooter.V1.AccessState.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Access);
      }
      size += explainedPolicies_.CalculateSize(_repeated_explainedPolicies_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TroubleshootIamPolicyResponse other) {
      if (other == null) {
        return;
      }
      if (other.Access != global::Google.Cloud.PolicyTroubleshooter.V1.AccessState.Unspecified) {
        Access = other.Access;
      }
      explainedPolicies_.Add(other.explainedPolicies_);
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
            Access = (global::Google.Cloud.PolicyTroubleshooter.V1.AccessState) input.ReadEnum();
            break;
          }
          case 18: {
            explainedPolicies_.AddEntriesFrom(input, _repeated_explainedPolicies_codec);
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
            Access = (global::Google.Cloud.PolicyTroubleshooter.V1.AccessState) input.ReadEnum();
            break;
          }
          case 18: {
            explainedPolicies_.AddEntriesFrom(ref input, _repeated_explainedPolicies_codec);
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
