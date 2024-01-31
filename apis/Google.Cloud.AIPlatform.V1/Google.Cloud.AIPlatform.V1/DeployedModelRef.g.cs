// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/deployed_model_ref.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/deployed_model_ref.proto</summary>
  public static partial class DeployedModelRefReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/deployed_model_ref.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeployedModelRefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9kZXBsb3llZF9tb2RlbF9y",
            "ZWYucHJvdG8SGmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxGh9nb29nbGUv",
            "YXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNl",
            "LnByb3RvInIKEERlcGxveWVkTW9kZWxSZWYSPQoIZW5kcG9pbnQYASABKAlC",
            "K+JBAQX6QSQKImFpcGxhdGZvcm0uZ29vZ2xlYXBpcy5jb20vRW5kcG9pbnQS",
            "HwoRZGVwbG95ZWRfbW9kZWxfaWQYAiABKAlCBOJBAQVC1AEKHmNvbS5nb29n",
            "bGUuY2xvdWQuYWlwbGF0Zm9ybS52MUIWRGVwbG95ZWRNb2RlbE5hbWVQcm90",
            "b1ABWj5jbG91ZC5nb29nbGUuY29tL2dvL2FpcGxhdGZvcm0vYXBpdjEvYWlw",
            "bGF0Zm9ybXBiO2FpcGxhdGZvcm1wYqoCGkdvb2dsZS5DbG91ZC5BSVBsYXRm",
            "b3JtLlYxygIaR29vZ2xlXENsb3VkXEFJUGxhdGZvcm1cVjHqAh1Hb29nbGU6",
            "OkNsb3VkOjpBSVBsYXRmb3JtOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.DeployedModelRef), global::Google.Cloud.AIPlatform.V1.DeployedModelRef.Parser, new[]{ "Endpoint", "DeployedModelId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Points to a DeployedModel.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DeployedModelRef : pb::IMessage<DeployedModelRef>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DeployedModelRef> _parser = new pb::MessageParser<DeployedModelRef>(() => new DeployedModelRef());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DeployedModelRef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.DeployedModelRefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeployedModelRef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeployedModelRef(DeployedModelRef other) : this() {
      endpoint_ = other.endpoint_;
      deployedModelId_ = other.deployedModelId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeployedModelRef Clone() {
      return new DeployedModelRef(this);
    }

    /// <summary>Field number for the "endpoint" field.</summary>
    public const int EndpointFieldNumber = 1;
    private string endpoint_ = "";
    /// <summary>
    /// Immutable. A resource name of an Endpoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Endpoint {
      get { return endpoint_; }
      set {
        endpoint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deployed_model_id" field.</summary>
    public const int DeployedModelIdFieldNumber = 2;
    private string deployedModelId_ = "";
    /// <summary>
    /// Immutable. An ID of a DeployedModel in the above Endpoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DeployedModelId {
      get { return deployedModelId_; }
      set {
        deployedModelId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DeployedModelRef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DeployedModelRef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Endpoint != other.Endpoint) return false;
      if (DeployedModelId != other.DeployedModelId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Endpoint.Length != 0) hash ^= Endpoint.GetHashCode();
      if (DeployedModelId.Length != 0) hash ^= DeployedModelId.GetHashCode();
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
      if (Endpoint.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Endpoint);
      }
      if (DeployedModelId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeployedModelId);
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
      if (Endpoint.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Endpoint);
      }
      if (DeployedModelId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeployedModelId);
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
      if (Endpoint.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Endpoint);
      }
      if (DeployedModelId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeployedModelId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DeployedModelRef other) {
      if (other == null) {
        return;
      }
      if (other.Endpoint.Length != 0) {
        Endpoint = other.Endpoint;
      }
      if (other.DeployedModelId.Length != 0) {
        DeployedModelId = other.DeployedModelId;
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
            Endpoint = input.ReadString();
            break;
          }
          case 18: {
            DeployedModelId = input.ReadString();
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
            Endpoint = input.ReadString();
            break;
          }
          case 18: {
            DeployedModelId = input.ReadString();
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
