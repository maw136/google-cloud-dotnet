// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dataproc/v1/node_groups.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Dataproc.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/dataproc/v1/node_groups.proto</summary>
  public static partial class NodeGroupsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/dataproc/v1/node_groups.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NodeGroupsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipnb29nbGUvY2xvdWQvZGF0YXByb2MvdjEvbm9kZV9ncm91cHMucHJvdG8S",
            "GGdvb2dsZS5jbG91ZC5kYXRhcHJvYy52MRocZ29vZ2xlL2FwaS9hbm5vdGF0",
            "aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8aH2dvb2dsZS9h",
            "cGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2Uu",
            "cHJvdG8aJ2dvb2dsZS9jbG91ZC9kYXRhcHJvYy92MS9jbHVzdGVycy5wcm90",
            "bxojZ29vZ2xlL2xvbmdydW5uaW5nL29wZXJhdGlvbnMucHJvdG8aHmdvb2ds",
            "ZS9wcm90b2J1Zi9kdXJhdGlvbi5wcm90byLGAQoWQ3JlYXRlTm9kZUdyb3Vw",
            "UmVxdWVzdBI5CgZwYXJlbnQYASABKAlCKeBBAvpBIxIhZGF0YXByb2MuZ29v",
            "Z2xlYXBpcy5jb20vTm9kZUdyb3VwEjwKCm5vZGVfZ3JvdXAYAiABKAsyIy5n",
            "b29nbGUuY2xvdWQuZGF0YXByb2MudjEuTm9kZUdyb3VwQgPgQQISGgoNbm9k",
            "ZV9ncm91cF9pZBgEIAEoCUID4EEBEhcKCnJlcXVlc3RfaWQYAyABKAlCA+BB",
            "ASKeAQoWUmVzaXplTm9kZUdyb3VwUmVxdWVzdBIRCgRuYW1lGAEgASgJQgPg",
            "QQISEQoEc2l6ZRgCIAEoBUID4EECEhcKCnJlcXVlc3RfaWQYAyABKAlCA+BB",
            "ARJFCh1ncmFjZWZ1bF9kZWNvbW1pc3Npb25fdGltZW91dBgEIAEoCzIZLmdv",
            "b2dsZS5wcm90b2J1Zi5EdXJhdGlvbkID4EEBIk4KE0dldE5vZGVHcm91cFJl",
            "cXVlc3QSNwoEbmFtZRgBIAEoCUIp4EEC+kEjCiFkYXRhcHJvYy5nb29nbGVh",
            "cGlzLmNvbS9Ob2RlR3JvdXAypwYKE05vZGVHcm91cENvbnRyb2xsZXISlQIK",
            "D0NyZWF0ZU5vZGVHcm91cBIwLmdvb2dsZS5jbG91ZC5kYXRhcHJvYy52MS5D",
            "cmVhdGVOb2RlR3JvdXBSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5nLk9w",
            "ZXJhdGlvbiKwAYLT5JMCRSI3L3YxL3twYXJlbnQ9cHJvamVjdHMvKi9yZWdp",
            "b25zLyovY2x1c3RlcnMvKn0vbm9kZUdyb3VwczoKbm9kZV9ncm91cNpBH3Bh",
            "cmVudCxub2RlX2dyb3VwLG5vZGVfZ3JvdXBfaWTKQUAKCU5vZGVHcm91cBIz",
            "Z29vZ2xlLmNsb3VkLmRhdGFwcm9jLnYxLk5vZGVHcm91cE9wZXJhdGlvbk1l",
            "dGFkYXRhEv0BCg9SZXNpemVOb2RlR3JvdXASMC5nb29nbGUuY2xvdWQuZGF0",
            "YXByb2MudjEuUmVzaXplTm9kZUdyb3VwUmVxdWVzdBodLmdvb2dsZS5sb25n",
            "cnVubmluZy5PcGVyYXRpb24imAGC0+STAkMiPi92MS97bmFtZT1wcm9qZWN0",
            "cy8qL3JlZ2lvbnMvKi9jbHVzdGVycy8qL25vZGVHcm91cHMvKn06cmVzaXpl",
            "OgEq2kEJbmFtZSxzaXplykFACglOb2RlR3JvdXASM2dvb2dsZS5jbG91ZC5k",
            "YXRhcHJvYy52MS5Ob2RlR3JvdXBPcGVyYXRpb25NZXRhZGF0YRKqAQoMR2V0",
            "Tm9kZUdyb3VwEi0uZ29vZ2xlLmNsb3VkLmRhdGFwcm9jLnYxLkdldE5vZGVH",
            "cm91cFJlcXVlc3QaIy5nb29nbGUuY2xvdWQuZGF0YXByb2MudjEuTm9kZUdy",
            "b3VwIkaC0+STAjkSNy92MS97bmFtZT1wcm9qZWN0cy8qL3JlZ2lvbnMvKi9j",
            "bHVzdGVycy8qL25vZGVHcm91cHMvKn3aQQRuYW1lGkvKQRdkYXRhcHJvYy5n",
            "b29nbGVhcGlzLmNvbdJBLmh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1",
            "dGgvY2xvdWQtcGxhdGZvcm1C0AEKHGNvbS5nb29nbGUuY2xvdWQuZGF0YXBy",
            "b2MudjFCD05vZGVHcm91cHNQcm90b1ABWjtjbG91ZC5nb29nbGUuY29tL2dv",
            "L2RhdGFwcm9jL3YyL2FwaXYxL2RhdGFwcm9jcGI7ZGF0YXByb2NwYupBXwol",
            "ZGF0YXByb2MuZ29vZ2xlYXBpcy5jb20vQ2x1c3RlclJlZ2lvbhI2cHJvamVj",
            "dHMve3Byb2plY3R9L3JlZ2lvbnMve3JlZ2lvbn0vY2x1c3RlcnMve2NsdXN0",
            "ZXJ9YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Dataproc.V1.ClustersReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dataproc.V1.CreateNodeGroupRequest), global::Google.Cloud.Dataproc.V1.CreateNodeGroupRequest.Parser, new[]{ "Parent", "NodeGroup", "NodeGroupId", "RequestId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dataproc.V1.ResizeNodeGroupRequest), global::Google.Cloud.Dataproc.V1.ResizeNodeGroupRequest.Parser, new[]{ "Name", "Size", "RequestId", "GracefulDecommissionTimeout" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dataproc.V1.GetNodeGroupRequest), global::Google.Cloud.Dataproc.V1.GetNodeGroupRequest.Parser, new[]{ "Name" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A request to create a node group.
  /// </summary>
  public sealed partial class CreateNodeGroupRequest : pb::IMessage<CreateNodeGroupRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateNodeGroupRequest> _parser = new pb::MessageParser<CreateNodeGroupRequest>(() => new CreateNodeGroupRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateNodeGroupRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dataproc.V1.NodeGroupsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateNodeGroupRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateNodeGroupRequest(CreateNodeGroupRequest other) : this() {
      parent_ = other.parent_;
      nodeGroup_ = other.nodeGroup_ != null ? other.nodeGroup_.Clone() : null;
      nodeGroupId_ = other.nodeGroupId_;
      requestId_ = other.requestId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateNodeGroupRequest Clone() {
      return new CreateNodeGroupRequest(this);
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 1;
    private string parent_ = "";
    /// <summary>
    /// Required. The parent resource where this node group will be created.
    /// Format: `projects/{project}/regions/{region}/clusters/{cluster}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "node_group" field.</summary>
    public const int NodeGroupFieldNumber = 2;
    private global::Google.Cloud.Dataproc.V1.NodeGroup nodeGroup_;
    /// <summary>
    /// Required. The node group to create.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Dataproc.V1.NodeGroup NodeGroup {
      get { return nodeGroup_; }
      set {
        nodeGroup_ = value;
      }
    }

    /// <summary>Field number for the "node_group_id" field.</summary>
    public const int NodeGroupIdFieldNumber = 4;
    private string nodeGroupId_ = "";
    /// <summary>
    /// Optional. An optional node group ID. Generated if not specified.
    ///
    /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
    /// underscores (_), and hyphens (-). Cannot begin or end with underscore
    /// or hyphen. Must consist of from 3 to 33 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NodeGroupId {
      get { return nodeGroupId_; }
      set {
        nodeGroupId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 3;
    private string requestId_ = "";
    /// <summary>
    /// Optional. A unique ID used to identify the request. If the server receives
    /// two
    /// [CreateNodeGroupRequest](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#google.cloud.dataproc.v1.CreateNodeGroupRequests)
    /// with the same ID, the second request is ignored and the
    /// first [google.longrunning.Operation][google.longrunning.Operation] created
    /// and stored in the backend is returned.
    ///
    /// Recommendation: Set this value to a
    /// [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier).
    ///
    /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
    /// underscores (_), and hyphens (-). The maximum length is 40 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RequestId {
      get { return requestId_; }
      set {
        requestId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateNodeGroupRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateNodeGroupRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Parent != other.Parent) return false;
      if (!object.Equals(NodeGroup, other.NodeGroup)) return false;
      if (NodeGroupId != other.NodeGroupId) return false;
      if (RequestId != other.RequestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (nodeGroup_ != null) hash ^= NodeGroup.GetHashCode();
      if (NodeGroupId.Length != 0) hash ^= NodeGroupId.GetHashCode();
      if (RequestId.Length != 0) hash ^= RequestId.GetHashCode();
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
      if (nodeGroup_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(NodeGroup);
      }
      if (RequestId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RequestId);
      }
      if (NodeGroupId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(NodeGroupId);
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
      if (nodeGroup_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(NodeGroup);
      }
      if (RequestId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RequestId);
      }
      if (NodeGroupId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(NodeGroupId);
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
      if (nodeGroup_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NodeGroup);
      }
      if (NodeGroupId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NodeGroupId);
      }
      if (RequestId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RequestId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateNodeGroupRequest other) {
      if (other == null) {
        return;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.nodeGroup_ != null) {
        if (nodeGroup_ == null) {
          NodeGroup = new global::Google.Cloud.Dataproc.V1.NodeGroup();
        }
        NodeGroup.MergeFrom(other.NodeGroup);
      }
      if (other.NodeGroupId.Length != 0) {
        NodeGroupId = other.NodeGroupId;
      }
      if (other.RequestId.Length != 0) {
        RequestId = other.RequestId;
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
            if (nodeGroup_ == null) {
              NodeGroup = new global::Google.Cloud.Dataproc.V1.NodeGroup();
            }
            input.ReadMessage(NodeGroup);
            break;
          }
          case 26: {
            RequestId = input.ReadString();
            break;
          }
          case 34: {
            NodeGroupId = input.ReadString();
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
            if (nodeGroup_ == null) {
              NodeGroup = new global::Google.Cloud.Dataproc.V1.NodeGroup();
            }
            input.ReadMessage(NodeGroup);
            break;
          }
          case 26: {
            RequestId = input.ReadString();
            break;
          }
          case 34: {
            NodeGroupId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// A request to resize a node group.
  /// </summary>
  public sealed partial class ResizeNodeGroupRequest : pb::IMessage<ResizeNodeGroupRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResizeNodeGroupRequest> _parser = new pb::MessageParser<ResizeNodeGroupRequest>(() => new ResizeNodeGroupRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResizeNodeGroupRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dataproc.V1.NodeGroupsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResizeNodeGroupRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResizeNodeGroupRequest(ResizeNodeGroupRequest other) : this() {
      name_ = other.name_;
      size_ = other.size_;
      requestId_ = other.requestId_;
      gracefulDecommissionTimeout_ = other.gracefulDecommissionTimeout_ != null ? other.gracefulDecommissionTimeout_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResizeNodeGroupRequest Clone() {
      return new ResizeNodeGroupRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. The name of the node group to resize.
    /// Format:
    /// `projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{nodeGroup}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 2;
    private int size_;
    /// <summary>
    /// Required. The number of running instances for the node group to maintain.
    /// The group adds or removes instances to maintain the number of instances
    /// specified by this parameter.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 3;
    private string requestId_ = "";
    /// <summary>
    /// Optional. A unique ID used to identify the request. If the server receives
    /// two
    /// [ResizeNodeGroupRequest](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#google.cloud.dataproc.v1.ResizeNodeGroupRequests)
    /// with the same ID, the second request is ignored and the
    /// first [google.longrunning.Operation][google.longrunning.Operation] created
    /// and stored in the backend is returned.
    ///
    /// Recommendation: Set this value to a
    /// [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier).
    ///
    /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
    /// underscores (_), and hyphens (-). The maximum length is 40 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RequestId {
      get { return requestId_; }
      set {
        requestId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "graceful_decommission_timeout" field.</summary>
    public const int GracefulDecommissionTimeoutFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Duration gracefulDecommissionTimeout_;
    /// <summary>
    /// Optional. Timeout for graceful YARN decomissioning. [Graceful
    /// decommissioning]
    /// (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/scaling-clusters#graceful_decommissioning)
    /// allows the removal of nodes from the Compute Engine node group
    /// without interrupting jobs in progress. This timeout specifies how long to
    /// wait for jobs in progress to finish before forcefully removing nodes (and
    /// potentially interrupting jobs). Default timeout is 0 (for forceful
    /// decommission), and the maximum allowed timeout is 1 day. (see JSON
    /// representation of
    /// [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)).
    ///
    /// Only supported on Dataproc image versions 1.2 and higher.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration GracefulDecommissionTimeout {
      get { return gracefulDecommissionTimeout_; }
      set {
        gracefulDecommissionTimeout_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResizeNodeGroupRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResizeNodeGroupRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Size != other.Size) return false;
      if (RequestId != other.RequestId) return false;
      if (!object.Equals(GracefulDecommissionTimeout, other.GracefulDecommissionTimeout)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Size != 0) hash ^= Size.GetHashCode();
      if (RequestId.Length != 0) hash ^= RequestId.GetHashCode();
      if (gracefulDecommissionTimeout_ != null) hash ^= GracefulDecommissionTimeout.GetHashCode();
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
      if (Size != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Size);
      }
      if (RequestId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RequestId);
      }
      if (gracefulDecommissionTimeout_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GracefulDecommissionTimeout);
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
      if (Size != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Size);
      }
      if (RequestId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RequestId);
      }
      if (gracefulDecommissionTimeout_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GracefulDecommissionTimeout);
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
      if (Size != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Size);
      }
      if (RequestId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RequestId);
      }
      if (gracefulDecommissionTimeout_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GracefulDecommissionTimeout);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResizeNodeGroupRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Size != 0) {
        Size = other.Size;
      }
      if (other.RequestId.Length != 0) {
        RequestId = other.RequestId;
      }
      if (other.gracefulDecommissionTimeout_ != null) {
        if (gracefulDecommissionTimeout_ == null) {
          GracefulDecommissionTimeout = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        GracefulDecommissionTimeout.MergeFrom(other.GracefulDecommissionTimeout);
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
          case 16: {
            Size = input.ReadInt32();
            break;
          }
          case 26: {
            RequestId = input.ReadString();
            break;
          }
          case 34: {
            if (gracefulDecommissionTimeout_ == null) {
              GracefulDecommissionTimeout = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(GracefulDecommissionTimeout);
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
          case 16: {
            Size = input.ReadInt32();
            break;
          }
          case 26: {
            RequestId = input.ReadString();
            break;
          }
          case 34: {
            if (gracefulDecommissionTimeout_ == null) {
              GracefulDecommissionTimeout = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(GracefulDecommissionTimeout);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// A request to get a node group .
  /// </summary>
  public sealed partial class GetNodeGroupRequest : pb::IMessage<GetNodeGroupRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetNodeGroupRequest> _parser = new pb::MessageParser<GetNodeGroupRequest>(() => new GetNodeGroupRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetNodeGroupRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dataproc.V1.NodeGroupsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNodeGroupRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNodeGroupRequest(GetNodeGroupRequest other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNodeGroupRequest Clone() {
      return new GetNodeGroupRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. The name of the node group to retrieve.
    /// Format:
    /// `projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{nodeGroup}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetNodeGroupRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetNodeGroupRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetNodeGroupRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
