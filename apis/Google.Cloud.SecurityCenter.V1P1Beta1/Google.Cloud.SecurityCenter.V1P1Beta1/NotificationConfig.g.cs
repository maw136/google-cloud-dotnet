// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1p1beta1/notification_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1P1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1p1beta1/notification_config.proto</summary>
  public static partial class NotificationConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1p1beta1/notification_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NotificationConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjFwMWJldGExL25vdGlm",
            "aWNhdGlvbl9jb25maWcucHJvdG8SJWdvb2dsZS5jbG91ZC5zZWN1cml0eWNl",
            "bnRlci52MXAxYmV0YTEaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJv",
            "dG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8itgQKEk5vdGlmaWNhdGlv",
            "bkNvbmZpZxIMCgRuYW1lGAEgASgJEhMKC2Rlc2NyaXB0aW9uGAIgASgJElcK",
            "CmV2ZW50X3R5cGUYAyABKA4yQy5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50",
            "ZXIudjFwMWJldGExLk5vdGlmaWNhdGlvbkNvbmZpZy5FdmVudFR5cGUSNgoM",
            "cHVic3ViX3RvcGljGAQgASgJQiD6QR0KG3B1YnN1Yi5nb29nbGVhcGlzLmNv",
            "bS9Ub3BpYxIcCg9zZXJ2aWNlX2FjY291bnQYBSABKAlCA+BBAxJlChBzdHJl",
            "YW1pbmdfY29uZmlnGAYgASgLMkkuZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2Vu",
            "dGVyLnYxcDFiZXRhMS5Ob3RpZmljYXRpb25Db25maWcuU3RyZWFtaW5nQ29u",
            "ZmlnSAAaIQoPU3RyZWFtaW5nQ29uZmlnEg4KBmZpbHRlchgBIAEoCSI0CglF",
            "dmVudFR5cGUSGgoWRVZFTlRfVFlQRV9VTlNQRUNJRklFRBAAEgsKB0ZJTkRJ",
            "TkcQATp96kF6CjBzZWN1cml0eWNlbnRlci5nb29nbGVhcGlzLmNvbS9Ob3Rp",
            "ZmljYXRpb25Db25maWcSRm9yZ2FuaXphdGlvbnMve29yZ2FuaXphdGlvbn0v",
            "bm90aWZpY2F0aW9uQ29uZmlncy97bm90aWZpY2F0aW9uX2NvbmZpZ31CDwoN",
            "bm90aWZ5X2NvbmZpZ0K+AgopY29tLmdvb2dsZS5jbG91ZC5zZWN1cml0eWNl",
            "bnRlci52MXAxYmV0YTFQAVpRY2xvdWQuZ29vZ2xlLmNvbS9nby9zZWN1cml0",
            "eWNlbnRlci9hcGl2MXAxYmV0YTEvc2VjdXJpdHljZW50ZXJwYjtzZWN1cml0",
            "eWNlbnRlcnBiqgIlR29vZ2xlLkNsb3VkLlNlY3VyaXR5Q2VudGVyLlYxUDFC",
            "ZXRhMcoCJUdvb2dsZVxDbG91ZFxTZWN1cml0eUNlbnRlclxWMXAxYmV0YTHq",
            "AihHb29nbGU6OkNsb3VkOjpTZWN1cml0eUNlbnRlcjo6VjFwMWJldGEx6kFA",
            "ChtwdWJzdWIuZ29vZ2xlYXBpcy5jb20vVG9waWMSIXByb2plY3RzL3twcm9q",
            "ZWN0fS90b3BpY3Mve3RvcGljfWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig), global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Parser, new[]{ "Name", "Description", "EventType", "PubsubTopic", "ServiceAccount", "StreamingConfig" }, new[]{ "NotifyConfig" }, new[]{ typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.EventType) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.StreamingConfig), global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.StreamingConfig.Parser, new[]{ "Filter" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Security Command Center notification configs.
  ///
  /// A notification config is a Security Command Center resource that contains the
  /// configuration to send notifications for create/update events of findings,
  /// assets and etc.
  /// </summary>
  public sealed partial class NotificationConfig : pb::IMessage<NotificationConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NotificationConfig> _parser = new pb::MessageParser<NotificationConfig>(() => new NotificationConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NotificationConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NotificationConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NotificationConfig(NotificationConfig other) : this() {
      name_ = other.name_;
      description_ = other.description_;
      eventType_ = other.eventType_;
      pubsubTopic_ = other.pubsubTopic_;
      serviceAccount_ = other.serviceAccount_;
      switch (other.NotifyConfigCase) {
        case NotifyConfigOneofCase.StreamingConfig:
          StreamingConfig = other.StreamingConfig.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NotificationConfig Clone() {
      return new NotificationConfig(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The relative resource name of this notification config. See:
    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
    /// Example:
    /// "organizations/{organization_id}/notificationConfigs/notify_public_bucket".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    /// <summary>
    /// The description of the notification config (max of 1024 characters).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "event_type" field.</summary>
    public const int EventTypeFieldNumber = 3;
    private global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.EventType eventType_ = global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.EventType.Unspecified;
    /// <summary>
    /// The type of events the config is for, e.g. FINDING.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.EventType EventType {
      get { return eventType_; }
      set {
        eventType_ = value;
      }
    }

    /// <summary>Field number for the "pubsub_topic" field.</summary>
    public const int PubsubTopicFieldNumber = 4;
    private string pubsubTopic_ = "";
    /// <summary>
    /// The Pub/Sub topic to send notifications to. Its format is
    /// "projects/[project_id]/topics/[topic]".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PubsubTopic {
      get { return pubsubTopic_; }
      set {
        pubsubTopic_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "service_account" field.</summary>
    public const int ServiceAccountFieldNumber = 5;
    private string serviceAccount_ = "";
    /// <summary>
    /// Output only. The service account that needs "pubsub.topics.publish"
    /// permission to publish to the Pub/Sub topic.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ServiceAccount {
      get { return serviceAccount_; }
      set {
        serviceAccount_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "streaming_config" field.</summary>
    public const int StreamingConfigFieldNumber = 6;
    /// <summary>
    /// The config for triggering streaming-based notifications.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.StreamingConfig StreamingConfig {
      get { return notifyConfigCase_ == NotifyConfigOneofCase.StreamingConfig ? (global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.StreamingConfig) notifyConfig_ : null; }
      set {
        notifyConfig_ = value;
        notifyConfigCase_ = value == null ? NotifyConfigOneofCase.None : NotifyConfigOneofCase.StreamingConfig;
      }
    }

    private object notifyConfig_;
    /// <summary>Enum of possible cases for the "notify_config" oneof.</summary>
    public enum NotifyConfigOneofCase {
      None = 0,
      StreamingConfig = 6,
    }
    private NotifyConfigOneofCase notifyConfigCase_ = NotifyConfigOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NotifyConfigOneofCase NotifyConfigCase {
      get { return notifyConfigCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearNotifyConfig() {
      notifyConfigCase_ = NotifyConfigOneofCase.None;
      notifyConfig_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NotificationConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NotificationConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (EventType != other.EventType) return false;
      if (PubsubTopic != other.PubsubTopic) return false;
      if (ServiceAccount != other.ServiceAccount) return false;
      if (!object.Equals(StreamingConfig, other.StreamingConfig)) return false;
      if (NotifyConfigCase != other.NotifyConfigCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (EventType != global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.EventType.Unspecified) hash ^= EventType.GetHashCode();
      if (PubsubTopic.Length != 0) hash ^= PubsubTopic.GetHashCode();
      if (ServiceAccount.Length != 0) hash ^= ServiceAccount.GetHashCode();
      if (notifyConfigCase_ == NotifyConfigOneofCase.StreamingConfig) hash ^= StreamingConfig.GetHashCode();
      hash ^= (int) notifyConfigCase_;
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
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (EventType != global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.EventType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) EventType);
      }
      if (PubsubTopic.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PubsubTopic);
      }
      if (ServiceAccount.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ServiceAccount);
      }
      if (notifyConfigCase_ == NotifyConfigOneofCase.StreamingConfig) {
        output.WriteRawTag(50);
        output.WriteMessage(StreamingConfig);
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
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (EventType != global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.EventType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) EventType);
      }
      if (PubsubTopic.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PubsubTopic);
      }
      if (ServiceAccount.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ServiceAccount);
      }
      if (notifyConfigCase_ == NotifyConfigOneofCase.StreamingConfig) {
        output.WriteRawTag(50);
        output.WriteMessage(StreamingConfig);
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
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (EventType != global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.EventType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EventType);
      }
      if (PubsubTopic.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PubsubTopic);
      }
      if (ServiceAccount.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServiceAccount);
      }
      if (notifyConfigCase_ == NotifyConfigOneofCase.StreamingConfig) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StreamingConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NotificationConfig other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.EventType != global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.EventType.Unspecified) {
        EventType = other.EventType;
      }
      if (other.PubsubTopic.Length != 0) {
        PubsubTopic = other.PubsubTopic;
      }
      if (other.ServiceAccount.Length != 0) {
        ServiceAccount = other.ServiceAccount;
      }
      switch (other.NotifyConfigCase) {
        case NotifyConfigOneofCase.StreamingConfig:
          if (StreamingConfig == null) {
            StreamingConfig = new global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.StreamingConfig();
          }
          StreamingConfig.MergeFrom(other.StreamingConfig);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 24: {
            EventType = (global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.EventType) input.ReadEnum();
            break;
          }
          case 34: {
            PubsubTopic = input.ReadString();
            break;
          }
          case 42: {
            ServiceAccount = input.ReadString();
            break;
          }
          case 50: {
            global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.StreamingConfig subBuilder = new global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.StreamingConfig();
            if (notifyConfigCase_ == NotifyConfigOneofCase.StreamingConfig) {
              subBuilder.MergeFrom(StreamingConfig);
            }
            input.ReadMessage(subBuilder);
            StreamingConfig = subBuilder;
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
            Description = input.ReadString();
            break;
          }
          case 24: {
            EventType = (global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.EventType) input.ReadEnum();
            break;
          }
          case 34: {
            PubsubTopic = input.ReadString();
            break;
          }
          case 42: {
            ServiceAccount = input.ReadString();
            break;
          }
          case 50: {
            global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.StreamingConfig subBuilder = new global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Types.StreamingConfig();
            if (notifyConfigCase_ == NotifyConfigOneofCase.StreamingConfig) {
              subBuilder.MergeFrom(StreamingConfig);
            }
            input.ReadMessage(subBuilder);
            StreamingConfig = subBuilder;
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the NotificationConfig message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The type of events.
      /// </summary>
      public enum EventType {
        /// <summary>
        /// Unspecified event type.
        /// </summary>
        [pbr::OriginalName("EVENT_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Events for findings.
        /// </summary>
        [pbr::OriginalName("FINDING")] Finding = 1,
      }

      /// <summary>
      /// The config for streaming-based notifications, which send each event as soon
      /// as it is detected.
      /// </summary>
      public sealed partial class StreamingConfig : pb::IMessage<StreamingConfig>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<StreamingConfig> _parser = new pb::MessageParser<StreamingConfig>(() => new StreamingConfig());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<StreamingConfig> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.SecurityCenter.V1P1Beta1.NotificationConfig.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public StreamingConfig() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public StreamingConfig(StreamingConfig other) : this() {
          filter_ = other.filter_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public StreamingConfig Clone() {
          return new StreamingConfig(this);
        }

        /// <summary>Field number for the "filter" field.</summary>
        public const int FilterFieldNumber = 1;
        private string filter_ = "";
        /// <summary>
        /// Expression that defines the filter to apply across create/update events
        /// of assets or findings as specified by the event type. The expression is a
        /// list of zero or more restrictions combined via logical operators `AND`
        /// and `OR`. Parentheses are supported, and `OR` has higher precedence than
        /// `AND`.
        ///
        /// Restrictions have the form `&lt;field> &lt;operator> &lt;value>` and may have a
        /// `-` character in front of them to indicate negation. The fields map to
        /// those defined in the corresponding resource.
        ///
        /// The supported operators are:
        ///
        /// * `=` for all value types.
        /// * `>`, `&lt;`, `>=`, `&lt;=` for integer values.
        /// * `:`, meaning substring matching, for strings.
        ///
        /// The supported value types are:
        ///
        /// * string literals in quotes.
        /// * integer literals without quotes.
        /// * boolean literals `true` and `false` without quotes.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Filter {
          get { return filter_; }
          set {
            filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as StreamingConfig);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(StreamingConfig other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Filter != other.Filter) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Filter.Length != 0) hash ^= Filter.GetHashCode();
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
          if (Filter.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Filter);
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
          if (Filter.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Filter);
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
          if (Filter.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(StreamingConfig other) {
          if (other == null) {
            return;
          }
          if (other.Filter.Length != 0) {
            Filter = other.Filter;
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
                Filter = input.ReadString();
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
                Filter = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
