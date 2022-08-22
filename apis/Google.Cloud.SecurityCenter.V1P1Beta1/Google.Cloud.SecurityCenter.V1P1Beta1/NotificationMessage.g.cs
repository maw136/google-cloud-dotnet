// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1p1beta1/notification_message.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1P1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1p1beta1/notification_message.proto</summary>
  public static partial class NotificationMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1p1beta1/notification_message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NotificationMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjFwMWJldGExL25vdGlm",
            "aWNhdGlvbl9tZXNzYWdlLnByb3RvEiVnb29nbGUuY2xvdWQuc2VjdXJpdHlj",
            "ZW50ZXIudjFwMWJldGExGjNnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIv",
            "djFwMWJldGExL2ZpbmRpbmcucHJvdG8aNGdvb2dsZS9jbG91ZC9zZWN1cml0",
            "eWNlbnRlci92MXAxYmV0YTEvcmVzb3VyY2UucHJvdG8ixgEKE05vdGlmaWNh",
            "dGlvbk1lc3NhZ2USIAoYbm90aWZpY2F0aW9uX2NvbmZpZ19uYW1lGAEgASgJ",
            "EkEKB2ZpbmRpbmcYAiABKAsyLi5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50",
            "ZXIudjFwMWJldGExLkZpbmRpbmdIABJBCghyZXNvdXJjZRgDIAEoCzIvLmdv",
            "b2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52MXAxYmV0YTEuUmVzb3VyY2VC",
            "BwoFZXZlbnRC/QEKKWNvbS5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIu",
            "djFwMWJldGExUAFaU2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjFwMWJldGExO3NlY3VyaXR5",
            "Y2VudGVyqgIlR29vZ2xlLkNsb3VkLlNlY3VyaXR5Q2VudGVyLlYxUDFCZXRh",
            "McoCJUdvb2dsZVxDbG91ZFxTZWN1cml0eUNlbnRlclxWMXAxYmV0YTHqAihH",
            "b29nbGU6OkNsb3VkOjpTZWN1cml0eUNlbnRlcjo6VjFwMWJldGExYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.SecurityCenter.V1P1Beta1.FindingReflection.Descriptor, global::Google.Cloud.SecurityCenter.V1P1Beta1.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationMessage), global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationMessage.Parser, new[]{ "NotificationConfigName", "Finding", "Resource" }, new[]{ "Event" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Security Command Center's Notification
  /// </summary>
  public sealed partial class NotificationMessage : pb::IMessage<NotificationMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NotificationMessage> _parser = new pb::MessageParser<NotificationMessage>(() => new NotificationMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NotificationMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NotificationMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NotificationMessage(NotificationMessage other) : this() {
      notificationConfigName_ = other.notificationConfigName_;
      resource_ = other.resource_ != null ? other.resource_.Clone() : null;
      switch (other.EventCase) {
        case EventOneofCase.Finding:
          Finding = other.Finding.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NotificationMessage Clone() {
      return new NotificationMessage(this);
    }

    /// <summary>Field number for the "notification_config_name" field.</summary>
    public const int NotificationConfigNameFieldNumber = 1;
    private string notificationConfigName_ = "";
    /// <summary>
    /// Name of the notification config that generated current notification.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NotificationConfigName {
      get { return notificationConfigName_; }
      set {
        notificationConfigName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "finding" field.</summary>
    public const int FindingFieldNumber = 2;
    /// <summary>
    /// If it's a Finding based notification config, this field will be
    /// populated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.V1P1Beta1.Finding Finding {
      get { return eventCase_ == EventOneofCase.Finding ? (global::Google.Cloud.SecurityCenter.V1P1Beta1.Finding) event_ : null; }
      set {
        event_ = value;
        eventCase_ = value == null ? EventOneofCase.None : EventOneofCase.Finding;
      }
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 3;
    private global::Google.Cloud.SecurityCenter.V1P1Beta1.Resource resource_;
    /// <summary>
    /// The Cloud resource tied to the notification.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.V1P1Beta1.Resource Resource {
      get { return resource_; }
      set {
        resource_ = value;
      }
    }

    private object event_;
    /// <summary>Enum of possible cases for the "event" oneof.</summary>
    public enum EventOneofCase {
      None = 0,
      Finding = 2,
    }
    private EventOneofCase eventCase_ = EventOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventOneofCase EventCase {
      get { return eventCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEvent() {
      eventCase_ = EventOneofCase.None;
      event_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NotificationMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NotificationMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NotificationConfigName != other.NotificationConfigName) return false;
      if (!object.Equals(Finding, other.Finding)) return false;
      if (!object.Equals(Resource, other.Resource)) return false;
      if (EventCase != other.EventCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NotificationConfigName.Length != 0) hash ^= NotificationConfigName.GetHashCode();
      if (eventCase_ == EventOneofCase.Finding) hash ^= Finding.GetHashCode();
      if (resource_ != null) hash ^= Resource.GetHashCode();
      hash ^= (int) eventCase_;
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
      if (NotificationConfigName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(NotificationConfigName);
      }
      if (eventCase_ == EventOneofCase.Finding) {
        output.WriteRawTag(18);
        output.WriteMessage(Finding);
      }
      if (resource_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Resource);
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
      if (NotificationConfigName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(NotificationConfigName);
      }
      if (eventCase_ == EventOneofCase.Finding) {
        output.WriteRawTag(18);
        output.WriteMessage(Finding);
      }
      if (resource_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Resource);
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
      if (NotificationConfigName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NotificationConfigName);
      }
      if (eventCase_ == EventOneofCase.Finding) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Finding);
      }
      if (resource_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Resource);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NotificationMessage other) {
      if (other == null) {
        return;
      }
      if (other.NotificationConfigName.Length != 0) {
        NotificationConfigName = other.NotificationConfigName;
      }
      if (other.resource_ != null) {
        if (resource_ == null) {
          Resource = new global::Google.Cloud.SecurityCenter.V1P1Beta1.Resource();
        }
        Resource.MergeFrom(other.Resource);
      }
      switch (other.EventCase) {
        case EventOneofCase.Finding:
          if (Finding == null) {
            Finding = new global::Google.Cloud.SecurityCenter.V1P1Beta1.Finding();
          }
          Finding.MergeFrom(other.Finding);
          break;
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
            NotificationConfigName = input.ReadString();
            break;
          }
          case 18: {
            global::Google.Cloud.SecurityCenter.V1P1Beta1.Finding subBuilder = new global::Google.Cloud.SecurityCenter.V1P1Beta1.Finding();
            if (eventCase_ == EventOneofCase.Finding) {
              subBuilder.MergeFrom(Finding);
            }
            input.ReadMessage(subBuilder);
            Finding = subBuilder;
            break;
          }
          case 26: {
            if (resource_ == null) {
              Resource = new global::Google.Cloud.SecurityCenter.V1P1Beta1.Resource();
            }
            input.ReadMessage(Resource);
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
            NotificationConfigName = input.ReadString();
            break;
          }
          case 18: {
            global::Google.Cloud.SecurityCenter.V1P1Beta1.Finding subBuilder = new global::Google.Cloud.SecurityCenter.V1P1Beta1.Finding();
            if (eventCase_ == EventOneofCase.Finding) {
              subBuilder.MergeFrom(Finding);
            }
            input.ReadMessage(subBuilder);
            Finding = subBuilder;
            break;
          }
          case 26: {
            if (resource_ == null) {
              Resource = new global::Google.Cloud.SecurityCenter.V1P1Beta1.Resource();
            }
            input.ReadMessage(Resource);
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
