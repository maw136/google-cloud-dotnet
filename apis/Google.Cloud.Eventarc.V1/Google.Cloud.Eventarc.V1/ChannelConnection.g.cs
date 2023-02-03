// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/eventarc/v1/channel_connection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Eventarc.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/eventarc/v1/channel_connection.proto</summary>
  public static partial class ChannelConnectionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/eventarc/v1/channel_connection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChannelConnectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvY2xvdWQvZXZlbnRhcmMvdjEvY2hhbm5lbF9jb25uZWN0aW9u",
            "LnByb3RvEhhnb29nbGUuY2xvdWQuZXZlbnRhcmMudjEaH2dvb2dsZS9hcGkv",
            "ZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJv",
            "dG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8ipwMKEUNoYW5u",
            "ZWxDb25uZWN0aW9uEhEKBG5hbWUYASABKAlCA+BBAhIQCgN1aWQYAiABKAlC",
            "A+BBAxI4CgdjaGFubmVsGAUgASgJQifgQQL6QSEKH2V2ZW50YXJjLmdvb2ds",
            "ZWFwaXMuY29tL0NoYW5uZWwSNAoLY3JlYXRlX3RpbWUYBiABKAsyGi5nb29n",
            "bGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMSNAoLdXBkYXRlX3RpbWUYByAB",
            "KAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMSHQoQYWN0aXZh",
            "dGlvbl90b2tlbhgIIAEoCUID4EEEOqcB6kGjAQopZXZlbnRhcmMuZ29vZ2xl",
            "YXBpcy5jb20vQ2hhbm5lbENvbm5lY3Rpb24ST3Byb2plY3RzL3twcm9qZWN0",
            "fS9sb2NhdGlvbnMve2xvY2F0aW9ufS9jaGFubmVsQ29ubmVjdGlvbnMve2No",
            "YW5uZWxfY29ubmVjdGlvbn0qEmNoYW5uZWxDb25uZWN0aW9uczIRY2hhbm5l",
            "bENvbm5lY3Rpb25CxgEKHGNvbS5nb29nbGUuY2xvdWQuZXZlbnRhcmMudjFC",
            "FkNoYW5uZWxDb25uZWN0aW9uUHJvdG9QAVo4Y2xvdWQuZ29vZ2xlLmNvbS9n",
            "by9ldmVudGFyYy9hcGl2MS9ldmVudGFyY3BiO2V2ZW50YXJjcGKqAhhHb29n",
            "bGUuQ2xvdWQuRXZlbnRhcmMuVjHKAhhHb29nbGVcQ2xvdWRcRXZlbnRhcmNc",
            "VjHqAhtHb29nbGU6OkNsb3VkOjpFdmVudGFyYzo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Eventarc.V1.ChannelConnection), global::Google.Cloud.Eventarc.V1.ChannelConnection.Parser, new[]{ "Name", "Uid", "Channel", "CreateTime", "UpdateTime", "ActivationToken" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A representation of the ChannelConnection resource.
  /// A ChannelConnection is a resource which event providers create during the
  /// activation process to establish a connection between the provider and the
  /// subscriber channel.
  /// </summary>
  public sealed partial class ChannelConnection : pb::IMessage<ChannelConnection>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChannelConnection> _parser = new pb::MessageParser<ChannelConnection>(() => new ChannelConnection());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChannelConnection> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Eventarc.V1.ChannelConnectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelConnection() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelConnection(ChannelConnection other) : this() {
      name_ = other.name_;
      uid_ = other.uid_;
      channel_ = other.channel_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      activationToken_ = other.activationToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelConnection Clone() {
      return new ChannelConnection(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. The name of the connection.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 2;
    private string uid_ = "";
    /// <summary>
    /// Output only. Server assigned ID of the resource.
    /// The server guarantees uniqueness and immutability until deleted.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Uid {
      get { return uid_; }
      set {
        uid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "channel" field.</summary>
    public const int ChannelFieldNumber = 5;
    private string channel_ = "";
    /// <summary>
    /// Required. The name of the connected subscriber Channel.
    /// This is a weak reference to avoid cross project and cross accounts
    /// references. This must be in
    /// `projects/{project}/location/{location}/channels/{channel_id}` format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Channel {
      get { return channel_; }
      set {
        channel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The creation time.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. The last-modified time.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "activation_token" field.</summary>
    public const int ActivationTokenFieldNumber = 8;
    private string activationToken_ = "";
    /// <summary>
    /// Input only. Activation token for the channel. The token will be used
    /// during the creation of ChannelConnection to bind the channel with the
    /// provider project. This field will not be stored in the provider resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ActivationToken {
      get { return activationToken_; }
      set {
        activationToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChannelConnection);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChannelConnection other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Uid != other.Uid) return false;
      if (Channel != other.Channel) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (ActivationToken != other.ActivationToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Uid.Length != 0) hash ^= Uid.GetHashCode();
      if (Channel.Length != 0) hash ^= Channel.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (ActivationToken.Length != 0) hash ^= ActivationToken.GetHashCode();
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
      if (Uid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uid);
      }
      if (Channel.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Channel);
      }
      if (createTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(UpdateTime);
      }
      if (ActivationToken.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ActivationToken);
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
      if (Uid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uid);
      }
      if (Channel.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Channel);
      }
      if (createTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(UpdateTime);
      }
      if (ActivationToken.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ActivationToken);
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
      if (Uid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uid);
      }
      if (Channel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Channel);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (ActivationToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ActivationToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChannelConnection other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Uid.Length != 0) {
        Uid = other.Uid;
      }
      if (other.Channel.Length != 0) {
        Channel = other.Channel;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.ActivationToken.Length != 0) {
        ActivationToken = other.ActivationToken;
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
          case 18: {
            Uid = input.ReadString();
            break;
          }
          case 42: {
            Channel = input.ReadString();
            break;
          }
          case 50: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 58: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 66: {
            ActivationToken = input.ReadString();
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
          case 18: {
            Uid = input.ReadString();
            break;
          }
          case 42: {
            Channel = input.ReadString();
            break;
          }
          case 50: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 58: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 66: {
            ActivationToken = input.ReadString();
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
