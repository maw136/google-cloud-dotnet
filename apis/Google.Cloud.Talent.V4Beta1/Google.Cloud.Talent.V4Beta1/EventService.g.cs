// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/talent/v4beta1/event_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Talent.V4Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/talent/v4beta1/event_service.proto</summary>
  public static partial class EventServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/talent/v4beta1/event_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvdGFsZW50L3Y0YmV0YTEvZXZlbnRfc2VydmljZS5w",
            "cm90bxIbZ29vZ2xlLmNsb3VkLnRhbGVudC52NGJldGExGhxnb29nbGUvYXBp",
            "L2Fubm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90bxof",
            "Z29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9y",
            "ZXNvdXJjZS5wcm90bxonZ29vZ2xlL2Nsb3VkL3RhbGVudC92NGJldGExL2V2",
            "ZW50LnByb3RvIpQBChhDcmVhdGVDbGllbnRFdmVudFJlcXVlc3QSMwoGcGFy",
            "ZW50GAEgASgJQiPgQQL6QR0SG2pvYnMuZ29vZ2xlYXBpcy5jb20vQ29tcGFu",
            "eRJDCgxjbGllbnRfZXZlbnQYAiABKAsyKC5nb29nbGUuY2xvdWQudGFsZW50",
            "LnY0YmV0YTEuQ2xpZW50RXZlbnRCA+BBAjL6AgoMRXZlbnRTZXJ2aWNlEvsB",
            "ChFDcmVhdGVDbGllbnRFdmVudBI1Lmdvb2dsZS5jbG91ZC50YWxlbnQudjRi",
            "ZXRhMS5DcmVhdGVDbGllbnRFdmVudFJlcXVlc3QaKC5nb29nbGUuY2xvdWQu",
            "dGFsZW50LnY0YmV0YTEuQ2xpZW50RXZlbnQihAGC0+STAmgiMy92NGJldGEx",
            "L3twYXJlbnQ9cHJvamVjdHMvKi90ZW5hbnRzLyp9L2NsaWVudEV2ZW50czoB",
            "KlouIikvdjRiZXRhMS97cGFyZW50PXByb2plY3RzLyp9L2NsaWVudEV2ZW50",
            "czoBKtpBE3BhcmVudCxjbGllbnRfZXZlbnQabMpBE2pvYnMuZ29vZ2xlYXBp",
            "cy5jb23SQVNodHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2Nsb3Vk",
            "LXBsYXRmb3JtLGh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvam9i",
            "c0J/Ch9jb20uZ29vZ2xlLmNsb3VkLnRhbGVudC52NGJldGExQhFFdmVudFNl",
            "cnZpY2VQcm90b1ABWkFnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2Nsb3VkL3RhbGVudC92NGJldGExO3RhbGVudKICA0NUU2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Talent.V4Beta1.EventReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest), global::Google.Cloud.Talent.V4Beta1.CreateClientEventRequest.Parser, new[]{ "Parent", "ClientEvent" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The report event request.
  /// </summary>
  public sealed partial class CreateClientEventRequest : pb::IMessage<CreateClientEventRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateClientEventRequest> _parser = new pb::MessageParser<CreateClientEventRequest>(() => new CreateClientEventRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateClientEventRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4Beta1.EventServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClientEventRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClientEventRequest(CreateClientEventRequest other) : this() {
      parent_ = other.parent_;
      clientEvent_ = other.clientEvent_ != null ? other.clientEvent_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClientEventRequest Clone() {
      return new CreateClientEventRequest(this);
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 1;
    private string parent_ = "";
    /// <summary>
    /// Required. Resource name of the tenant under which the event is created.
    ///
    /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
    /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
    /// is created, for example, "projects/foo".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_event" field.</summary>
    public const int ClientEventFieldNumber = 2;
    private global::Google.Cloud.Talent.V4Beta1.ClientEvent clientEvent_;
    /// <summary>
    /// Required. Events issued when end user interacts with customer's application that
    /// uses Cloud Talent Solution.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Talent.V4Beta1.ClientEvent ClientEvent {
      get { return clientEvent_; }
      set {
        clientEvent_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateClientEventRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateClientEventRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Parent != other.Parent) return false;
      if (!object.Equals(ClientEvent, other.ClientEvent)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (clientEvent_ != null) hash ^= ClientEvent.GetHashCode();
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
      if (clientEvent_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ClientEvent);
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
      if (clientEvent_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ClientEvent);
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
      if (clientEvent_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClientEvent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateClientEventRequest other) {
      if (other == null) {
        return;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.clientEvent_ != null) {
        if (clientEvent_ == null) {
          ClientEvent = new global::Google.Cloud.Talent.V4Beta1.ClientEvent();
        }
        ClientEvent.MergeFrom(other.ClientEvent);
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
            if (clientEvent_ == null) {
              ClientEvent = new global::Google.Cloud.Talent.V4Beta1.ClientEvent();
            }
            input.ReadMessage(ClientEvent);
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
            if (clientEvent_ == null) {
              ClientEvent = new global::Google.Cloud.Talent.V4Beta1.ClientEvent();
            }
            input.ReadMessage(ClientEvent);
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
