// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/v2beta1/conversation_event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Dialogflow.V2Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/dialogflow/v2beta1/conversation_event.proto</summary>
  public static partial class ConversationEventReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/dialogflow/v2beta1/conversation_event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversationEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvY2xvdWQvZGlhbG9nZmxvdy92MmJldGExL2NvbnZlcnNhdGlv",
            "bl9ldmVudC5wcm90bxIfZ29vZ2xlLmNsb3VkLmRpYWxvZ2Zsb3cudjJiZXRh",
            "MRoxZ29vZ2xlL2Nsb3VkL2RpYWxvZ2Zsb3cvdjJiZXRhMS9wYXJ0aWNpcGFu",
            "dC5wcm90bxoXZ29vZ2xlL3JwYy9zdGF0dXMucHJvdG8iiwMKEUNvbnZlcnNh",
            "dGlvbkV2ZW50EhQKDGNvbnZlcnNhdGlvbhgBIAEoCRJFCgR0eXBlGAIgASgO",
            "MjcuZ29vZ2xlLmNsb3VkLmRpYWxvZ2Zsb3cudjJiZXRhMS5Db252ZXJzYXRp",
            "b25FdmVudC5UeXBlEigKDGVycm9yX3N0YXR1cxgDIAEoCzISLmdvb2dsZS5y",
            "cGMuU3RhdHVzEkcKE25ld19tZXNzYWdlX3BheWxvYWQYBCABKAsyKC5nb29n",
            "bGUuY2xvdWQuZGlhbG9nZmxvdy52MmJldGExLk1lc3NhZ2VIACKaAQoEVHlw",
            "ZRIUChBUWVBFX1VOU1BFQ0lGSUVEEAASGAoUQ09OVkVSU0FUSU9OX1NUQVJU",
            "RUQQARIZChVDT05WRVJTQVRJT05fRklOSVNIRUQQAhIdChlIVU1BTl9JTlRF",
            "UlZFTlRJT05fTkVFREVEEAMSDwoLTkVXX01FU1NBR0UQBRIXChNVTlJFQ09W",
            "RVJBQkxFX0VSUk9SEARCCQoHcGF5bG9hZEKuAQojY29tLmdvb2dsZS5jbG91",
            "ZC5kaWFsb2dmbG93LnYyYmV0YTFCFkNvbnZlcnNhdGlvbkV2ZW50UHJvdG9Q",
            "AVpDY2xvdWQuZ29vZ2xlLmNvbS9nby9kaWFsb2dmbG93L2FwaXYyYmV0YTEv",
            "ZGlhbG9nZmxvd3BiO2RpYWxvZ2Zsb3dwYvgBAaICAkRGqgIfR29vZ2xlLkNs",
            "b3VkLkRpYWxvZ2Zsb3cuVjJCZXRhMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.Dialogflow.V2Beta1.ParticipantReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent), global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Parser, new[]{ "Conversation", "Type", "ErrorStatus", "NewMessagePayload" }, new[]{ "Payload" }, new[]{ typeof(global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Types.Type) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a notification sent to Pub/Sub subscribers for conversation
  /// lifecycle events.
  /// </summary>
  public sealed partial class ConversationEvent : pb::IMessage<ConversationEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversationEvent> _parser = new pb::MessageParser<ConversationEvent>(() => new ConversationEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversationEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dialogflow.V2Beta1.ConversationEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversationEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversationEvent(ConversationEvent other) : this() {
      conversation_ = other.conversation_;
      type_ = other.type_;
      errorStatus_ = other.errorStatus_ != null ? other.errorStatus_.Clone() : null;
      switch (other.PayloadCase) {
        case PayloadOneofCase.NewMessagePayload:
          NewMessagePayload = other.NewMessagePayload.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversationEvent Clone() {
      return new ConversationEvent(this);
    }

    /// <summary>Field number for the "conversation" field.</summary>
    public const int ConversationFieldNumber = 1;
    private string conversation_ = "";
    /// <summary>
    /// Required. The unique identifier of the conversation this notification
    /// refers to.
    /// Format: `projects/&lt;Project ID>/conversations/&lt;Conversation ID>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Conversation {
      get { return conversation_; }
      set {
        conversation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Types.Type type_ = global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Types.Type.Unspecified;
    /// <summary>
    /// Required. The type of the event that this notification refers to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Types.Type Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "error_status" field.</summary>
    public const int ErrorStatusFieldNumber = 3;
    private global::Google.Rpc.Status errorStatus_;
    /// <summary>
    /// Optional. More detailed information about an error. Only set for type
    /// UNRECOVERABLE_ERROR_IN_PHONE_CALL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Rpc.Status ErrorStatus {
      get { return errorStatus_; }
      set {
        errorStatus_ = value;
      }
    }

    /// <summary>Field number for the "new_message_payload" field.</summary>
    public const int NewMessagePayloadFieldNumber = 4;
    /// <summary>
    /// Payload of NEW_MESSAGE event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Dialogflow.V2Beta1.Message NewMessagePayload {
      get { return payloadCase_ == PayloadOneofCase.NewMessagePayload ? (global::Google.Cloud.Dialogflow.V2Beta1.Message) payload_ : null; }
      set {
        payload_ = value;
        payloadCase_ = value == null ? PayloadOneofCase.None : PayloadOneofCase.NewMessagePayload;
      }
    }

    private object payload_;
    /// <summary>Enum of possible cases for the "payload" oneof.</summary>
    public enum PayloadOneofCase {
      None = 0,
      NewMessagePayload = 4,
    }
    private PayloadOneofCase payloadCase_ = PayloadOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PayloadOneofCase PayloadCase {
      get { return payloadCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPayload() {
      payloadCase_ = PayloadOneofCase.None;
      payload_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversationEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversationEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Conversation != other.Conversation) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(ErrorStatus, other.ErrorStatus)) return false;
      if (!object.Equals(NewMessagePayload, other.NewMessagePayload)) return false;
      if (PayloadCase != other.PayloadCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Conversation.Length != 0) hash ^= Conversation.GetHashCode();
      if (Type != global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Types.Type.Unspecified) hash ^= Type.GetHashCode();
      if (errorStatus_ != null) hash ^= ErrorStatus.GetHashCode();
      if (payloadCase_ == PayloadOneofCase.NewMessagePayload) hash ^= NewMessagePayload.GetHashCode();
      hash ^= (int) payloadCase_;
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
      if (Conversation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Conversation);
      }
      if (Type != global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Types.Type.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (errorStatus_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ErrorStatus);
      }
      if (payloadCase_ == PayloadOneofCase.NewMessagePayload) {
        output.WriteRawTag(34);
        output.WriteMessage(NewMessagePayload);
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
      if (Conversation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Conversation);
      }
      if (Type != global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Types.Type.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (errorStatus_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ErrorStatus);
      }
      if (payloadCase_ == PayloadOneofCase.NewMessagePayload) {
        output.WriteRawTag(34);
        output.WriteMessage(NewMessagePayload);
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
      if (Conversation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Conversation);
      }
      if (Type != global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Types.Type.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (errorStatus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ErrorStatus);
      }
      if (payloadCase_ == PayloadOneofCase.NewMessagePayload) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NewMessagePayload);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ConversationEvent other) {
      if (other == null) {
        return;
      }
      if (other.Conversation.Length != 0) {
        Conversation = other.Conversation;
      }
      if (other.Type != global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Types.Type.Unspecified) {
        Type = other.Type;
      }
      if (other.errorStatus_ != null) {
        if (errorStatus_ == null) {
          ErrorStatus = new global::Google.Rpc.Status();
        }
        ErrorStatus.MergeFrom(other.ErrorStatus);
      }
      switch (other.PayloadCase) {
        case PayloadOneofCase.NewMessagePayload:
          if (NewMessagePayload == null) {
            NewMessagePayload = new global::Google.Cloud.Dialogflow.V2Beta1.Message();
          }
          NewMessagePayload.MergeFrom(other.NewMessagePayload);
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
            Conversation = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Types.Type) input.ReadEnum();
            break;
          }
          case 26: {
            if (errorStatus_ == null) {
              ErrorStatus = new global::Google.Rpc.Status();
            }
            input.ReadMessage(ErrorStatus);
            break;
          }
          case 34: {
            global::Google.Cloud.Dialogflow.V2Beta1.Message subBuilder = new global::Google.Cloud.Dialogflow.V2Beta1.Message();
            if (payloadCase_ == PayloadOneofCase.NewMessagePayload) {
              subBuilder.MergeFrom(NewMessagePayload);
            }
            input.ReadMessage(subBuilder);
            NewMessagePayload = subBuilder;
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
            Conversation = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Google.Cloud.Dialogflow.V2Beta1.ConversationEvent.Types.Type) input.ReadEnum();
            break;
          }
          case 26: {
            if (errorStatus_ == null) {
              ErrorStatus = new global::Google.Rpc.Status();
            }
            input.ReadMessage(ErrorStatus);
            break;
          }
          case 34: {
            global::Google.Cloud.Dialogflow.V2Beta1.Message subBuilder = new global::Google.Cloud.Dialogflow.V2Beta1.Message();
            if (payloadCase_ == PayloadOneofCase.NewMessagePayload) {
              subBuilder.MergeFrom(NewMessagePayload);
            }
            input.ReadMessage(subBuilder);
            NewMessagePayload = subBuilder;
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ConversationEvent message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enumeration of the types of events available.
      /// </summary>
      public enum Type {
        /// <summary>
        /// Type not set.
        /// </summary>
        [pbr::OriginalName("TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// A new conversation has been opened. This is fired when a telephone call
        /// is answered, or a conversation is created via the API.
        /// </summary>
        [pbr::OriginalName("CONVERSATION_STARTED")] ConversationStarted = 1,
        /// <summary>
        /// An existing conversation has closed. This is fired when a telephone call
        /// is terminated, or a conversation is closed via the API.
        /// </summary>
        [pbr::OriginalName("CONVERSATION_FINISHED")] ConversationFinished = 2,
        /// <summary>
        /// An existing conversation has received notification from Dialogflow that
        /// human intervention is required.
        /// </summary>
        [pbr::OriginalName("HUMAN_INTERVENTION_NEEDED")] HumanInterventionNeeded = 3,
        /// <summary>
        /// An existing conversation has received a new message, either from API or
        /// telephony. It is configured in
        /// [ConversationProfile.new_message_event_notification_config][google.cloud.dialogflow.v2beta1.ConversationProfile.new_message_event_notification_config]
        /// </summary>
        [pbr::OriginalName("NEW_MESSAGE")] NewMessage = 5,
        /// <summary>
        /// Unrecoverable error during a telephone call.
        ///
        /// In general non-recoverable errors only occur if something was
        /// misconfigured in the ConversationProfile corresponding to the call. After
        /// a non-recoverable error, Dialogflow may stop responding.
        ///
        /// We don't fire this event:
        ///
        /// * in an API call because we can directly return the error, or,
        /// * when we can recover from an error.
        /// </summary>
        [pbr::OriginalName("UNRECOVERABLE_ERROR")] UnrecoverableError = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
