// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/channel/v1/subscriber_event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Channel.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/channel/v1/subscriber_event.proto</summary>
  public static partial class SubscriberEventReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/channel/v1/subscriber_event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SubscriberEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvY2xvdWQvY2hhbm5lbC92MS9zdWJzY3JpYmVyX2V2ZW50LnBy",
            "b3RvEhdnb29nbGUuY2xvdWQuY2hhbm5lbC52MRoZZ29vZ2xlL2FwaS9yZXNv",
            "dXJjZS5wcm90byLkAQoNQ3VzdG9tZXJFdmVudBI7CghjdXN0b21lchgBIAEo",
            "CUIp+kEmCiRjbG91ZGNoYW5uZWwuZ29vZ2xlYXBpcy5jb20vQ3VzdG9tZXIS",
            "PwoKZXZlbnRfdHlwZRgCIAEoDjIrLmdvb2dsZS5jbG91ZC5jaGFubmVsLnYx",
            "LkN1c3RvbWVyRXZlbnQuVHlwZSJVCgRUeXBlEhQKEFRZUEVfVU5TUEVDSUZJ",
            "RUQQABIaChZQUklNQVJZX0RPTUFJTl9DSEFOR0VEEAESGwoXUFJJTUFSWV9E",
            "T01BSU5fVkVSSUZJRUQQAiKxAwoQRW50aXRsZW1lbnRFdmVudBJBCgtlbnRp",
            "dGxlbWVudBgBIAEoCUIs+kEpCidjbG91ZGNoYW5uZWwuZ29vZ2xlYXBpcy5j",
            "b20vRW50aXRsZW1lbnQSQgoKZXZlbnRfdHlwZRgCIAEoDjIuLmdvb2dsZS5j",
            "bG91ZC5jaGFubmVsLnYxLkVudGl0bGVtZW50RXZlbnQuVHlwZSKVAgoEVHlw",
            "ZRIUChBUWVBFX1VOU1BFQ0lGSUVEEAASCwoHQ1JFQVRFRBABEhcKE1BSSUNF",
            "X1BMQU5fU1dJVENIRUQQAxIWChJDT01NSVRNRU5UX0NIQU5HRUQQBBILCgdS",
            "RU5FV0VEEAUSDQoJU1VTUEVOREVEEAYSDQoJQUNUSVZBVEVEEAcSDQoJQ0FO",
            "Q0VMTEVEEAgSDwoLU0tVX0NIQU5HRUQQCRIbChdSRU5FV0FMX1NFVFRJTkdf",
            "Q0hBTkdFRBAKEhgKFFBBSURfU0VSVklDRV9TVEFSVEVEEAsSHgoaTElDRU5T",
            "RV9BU1NJR05NRU5UX0NIQU5HRUQQDBIXChNMSUNFTlNFX0NBUF9DSEFOR0VE",
            "EA0ipAEKD1N1YnNjcmliZXJFdmVudBJACg5jdXN0b21lcl9ldmVudBgBIAEo",
            "CzImLmdvb2dsZS5jbG91ZC5jaGFubmVsLnYxLkN1c3RvbWVyRXZlbnRIABJG",
            "ChFlbnRpdGxlbWVudF9ldmVudBgCIAEoCzIpLmdvb2dsZS5jbG91ZC5jaGFu",
            "bmVsLnYxLkVudGl0bGVtZW50RXZlbnRIAEIHCgVldmVudEJ1Chtjb20uZ29v",
            "Z2xlLmNsb3VkLmNoYW5uZWwudjFCFFN1YnNjcmliZXJFdmVudFByb3RvUAFa",
            "Pmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQv",
            "Y2hhbm5lbC92MTtjaGFubmVsYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Channel.V1.CustomerEvent), global::Google.Cloud.Channel.V1.CustomerEvent.Parser, new[]{ "Customer", "EventType" }, null, new[]{ typeof(global::Google.Cloud.Channel.V1.CustomerEvent.Types.Type) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Channel.V1.EntitlementEvent), global::Google.Cloud.Channel.V1.EntitlementEvent.Parser, new[]{ "Entitlement", "EventType" }, null, new[]{ typeof(global::Google.Cloud.Channel.V1.EntitlementEvent.Types.Type) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Channel.V1.SubscriberEvent), global::Google.Cloud.Channel.V1.SubscriberEvent.Parser, new[]{ "CustomerEvent", "EntitlementEvent" }, new[]{ "Event" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents Pub/Sub message content describing customer update.
  /// </summary>
  public sealed partial class CustomerEvent : pb::IMessage<CustomerEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerEvent> _parser = new pb::MessageParser<CustomerEvent>(() => new CustomerEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Channel.V1.SubscriberEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerEvent(CustomerEvent other) : this() {
      customer_ = other.customer_;
      eventType_ = other.eventType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerEvent Clone() {
      return new CustomerEvent(this);
    }

    /// <summary>Field number for the "customer" field.</summary>
    public const int CustomerFieldNumber = 1;
    private string customer_ = "";
    /// <summary>
    /// Resource name of the customer.
    /// Format: accounts/{account_id}/customers/{customer_id}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Customer {
      get { return customer_; }
      set {
        customer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "event_type" field.</summary>
    public const int EventTypeFieldNumber = 2;
    private global::Google.Cloud.Channel.V1.CustomerEvent.Types.Type eventType_ = global::Google.Cloud.Channel.V1.CustomerEvent.Types.Type.Unspecified;
    /// <summary>
    /// Type of event which happened on the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Channel.V1.CustomerEvent.Types.Type EventType {
      get { return eventType_; }
      set {
        eventType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Customer != other.Customer) return false;
      if (EventType != other.EventType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Customer.Length != 0) hash ^= Customer.GetHashCode();
      if (EventType != global::Google.Cloud.Channel.V1.CustomerEvent.Types.Type.Unspecified) hash ^= EventType.GetHashCode();
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
      if (Customer.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Customer);
      }
      if (EventType != global::Google.Cloud.Channel.V1.CustomerEvent.Types.Type.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) EventType);
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
      if (Customer.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Customer);
      }
      if (EventType != global::Google.Cloud.Channel.V1.CustomerEvent.Types.Type.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) EventType);
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
      if (Customer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Customer);
      }
      if (EventType != global::Google.Cloud.Channel.V1.CustomerEvent.Types.Type.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EventType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerEvent other) {
      if (other == null) {
        return;
      }
      if (other.Customer.Length != 0) {
        Customer = other.Customer;
      }
      if (other.EventType != global::Google.Cloud.Channel.V1.CustomerEvent.Types.Type.Unspecified) {
        EventType = other.EventType;
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
            Customer = input.ReadString();
            break;
          }
          case 16: {
            EventType = (global::Google.Cloud.Channel.V1.CustomerEvent.Types.Type) input.ReadEnum();
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
            Customer = input.ReadString();
            break;
          }
          case 16: {
            EventType = (global::Google.Cloud.Channel.V1.CustomerEvent.Types.Type) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CustomerEvent message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Type of customer event.
      /// </summary>
      public enum Type {
        /// <summary>
        /// Not used.
        /// </summary>
        [pbr::OriginalName("TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Primary domain for customer was changed.
        /// </summary>
        [pbr::OriginalName("PRIMARY_DOMAIN_CHANGED")] PrimaryDomainChanged = 1,
        /// <summary>
        /// Primary domain of the customer has been verified.
        /// </summary>
        [pbr::OriginalName("PRIMARY_DOMAIN_VERIFIED")] PrimaryDomainVerified = 2,
      }

    }
    #endregion

  }

  /// <summary>
  /// Represents Pub/Sub message content describing entitlement update.
  /// </summary>
  public sealed partial class EntitlementEvent : pb::IMessage<EntitlementEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntitlementEvent> _parser = new pb::MessageParser<EntitlementEvent>(() => new EntitlementEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntitlementEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Channel.V1.SubscriberEventReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntitlementEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntitlementEvent(EntitlementEvent other) : this() {
      entitlement_ = other.entitlement_;
      eventType_ = other.eventType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntitlementEvent Clone() {
      return new EntitlementEvent(this);
    }

    /// <summary>Field number for the "entitlement" field.</summary>
    public const int EntitlementFieldNumber = 1;
    private string entitlement_ = "";
    /// <summary>
    /// Resource name of an entitlement of the form:
    /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Entitlement {
      get { return entitlement_; }
      set {
        entitlement_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "event_type" field.</summary>
    public const int EventTypeFieldNumber = 2;
    private global::Google.Cloud.Channel.V1.EntitlementEvent.Types.Type eventType_ = global::Google.Cloud.Channel.V1.EntitlementEvent.Types.Type.Unspecified;
    /// <summary>
    /// Type of event which happened on the entitlement.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Channel.V1.EntitlementEvent.Types.Type EventType {
      get { return eventType_; }
      set {
        eventType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntitlementEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntitlementEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Entitlement != other.Entitlement) return false;
      if (EventType != other.EventType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Entitlement.Length != 0) hash ^= Entitlement.GetHashCode();
      if (EventType != global::Google.Cloud.Channel.V1.EntitlementEvent.Types.Type.Unspecified) hash ^= EventType.GetHashCode();
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
      if (Entitlement.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Entitlement);
      }
      if (EventType != global::Google.Cloud.Channel.V1.EntitlementEvent.Types.Type.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) EventType);
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
      if (Entitlement.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Entitlement);
      }
      if (EventType != global::Google.Cloud.Channel.V1.EntitlementEvent.Types.Type.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) EventType);
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
      if (Entitlement.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Entitlement);
      }
      if (EventType != global::Google.Cloud.Channel.V1.EntitlementEvent.Types.Type.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EventType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntitlementEvent other) {
      if (other == null) {
        return;
      }
      if (other.Entitlement.Length != 0) {
        Entitlement = other.Entitlement;
      }
      if (other.EventType != global::Google.Cloud.Channel.V1.EntitlementEvent.Types.Type.Unspecified) {
        EventType = other.EventType;
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
            Entitlement = input.ReadString();
            break;
          }
          case 16: {
            EventType = (global::Google.Cloud.Channel.V1.EntitlementEvent.Types.Type) input.ReadEnum();
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
            Entitlement = input.ReadString();
            break;
          }
          case 16: {
            EventType = (global::Google.Cloud.Channel.V1.EntitlementEvent.Types.Type) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EntitlementEvent message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Type of entitlement event.
      /// </summary>
      public enum Type {
        /// <summary>
        /// Not used.
        /// </summary>
        [pbr::OriginalName("TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// A new entitlement was created.
        /// </summary>
        [pbr::OriginalName("CREATED")] Created = 1,
        /// <summary>
        /// The offer type associated with an entitlement was changed.
        /// This is not triggered if an entitlement converts from a commit offer to a
        /// flexible offer as part of a renewal.
        /// </summary>
        [pbr::OriginalName("PRICE_PLAN_SWITCHED")] PricePlanSwitched = 3,
        /// <summary>
        /// Annual commitment for a commit plan was changed.
        /// </summary>
        [pbr::OriginalName("COMMITMENT_CHANGED")] CommitmentChanged = 4,
        /// <summary>
        /// An annual entitlement was renewed.
        /// </summary>
        [pbr::OriginalName("RENEWED")] Renewed = 5,
        /// <summary>
        /// Entitlement was suspended.
        /// </summary>
        [pbr::OriginalName("SUSPENDED")] Suspended = 6,
        /// <summary>
        /// Entitlement was unsuspended.
        /// </summary>
        [pbr::OriginalName("ACTIVATED")] Activated = 7,
        /// <summary>
        /// Entitlement was cancelled.
        /// </summary>
        [pbr::OriginalName("CANCELLED")] Cancelled = 8,
        /// <summary>
        /// Entitlement was upgraded or downgraded (e.g. from Google Workspace
        /// Business Standard to Google Workspace Business Plus).
        /// </summary>
        [pbr::OriginalName("SKU_CHANGED")] SkuChanged = 9,
        /// <summary>
        /// The renewal settings of an entitlement has changed.
        /// </summary>
        [pbr::OriginalName("RENEWAL_SETTING_CHANGED")] RenewalSettingChanged = 10,
        /// <summary>
        /// Paid service has started on trial entitlement.
        /// </summary>
        [pbr::OriginalName("PAID_SERVICE_STARTED")] PaidServiceStarted = 11,
        /// <summary>
        /// License was assigned to or revoked from a user.
        /// </summary>
        [pbr::OriginalName("LICENSE_ASSIGNMENT_CHANGED")] LicenseAssignmentChanged = 12,
        /// <summary>
        /// License cap was changed for the entitlement.
        /// </summary>
        [pbr::OriginalName("LICENSE_CAP_CHANGED")] LicenseCapChanged = 13,
      }

    }
    #endregion

  }

  /// <summary>
  /// Represents information which resellers will get as part of notification from
  /// Pub/Sub.
  /// </summary>
  public sealed partial class SubscriberEvent : pb::IMessage<SubscriberEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SubscriberEvent> _parser = new pb::MessageParser<SubscriberEvent>(() => new SubscriberEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SubscriberEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Channel.V1.SubscriberEventReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubscriberEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubscriberEvent(SubscriberEvent other) : this() {
      switch (other.EventCase) {
        case EventOneofCase.CustomerEvent:
          CustomerEvent = other.CustomerEvent.Clone();
          break;
        case EventOneofCase.EntitlementEvent:
          EntitlementEvent = other.EntitlementEvent.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubscriberEvent Clone() {
      return new SubscriberEvent(this);
    }

    /// <summary>Field number for the "customer_event" field.</summary>
    public const int CustomerEventFieldNumber = 1;
    /// <summary>
    /// Customer event sent as part of Pub/Sub event to partners.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Channel.V1.CustomerEvent CustomerEvent {
      get { return eventCase_ == EventOneofCase.CustomerEvent ? (global::Google.Cloud.Channel.V1.CustomerEvent) event_ : null; }
      set {
        event_ = value;
        eventCase_ = value == null ? EventOneofCase.None : EventOneofCase.CustomerEvent;
      }
    }

    /// <summary>Field number for the "entitlement_event" field.</summary>
    public const int EntitlementEventFieldNumber = 2;
    /// <summary>
    /// Entitlement event sent as part of Pub/Sub event to partners.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Channel.V1.EntitlementEvent EntitlementEvent {
      get { return eventCase_ == EventOneofCase.EntitlementEvent ? (global::Google.Cloud.Channel.V1.EntitlementEvent) event_ : null; }
      set {
        event_ = value;
        eventCase_ = value == null ? EventOneofCase.None : EventOneofCase.EntitlementEvent;
      }
    }

    private object event_;
    /// <summary>Enum of possible cases for the "event" oneof.</summary>
    public enum EventOneofCase {
      None = 0,
      CustomerEvent = 1,
      EntitlementEvent = 2,
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
      return Equals(other as SubscriberEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SubscriberEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CustomerEvent, other.CustomerEvent)) return false;
      if (!object.Equals(EntitlementEvent, other.EntitlementEvent)) return false;
      if (EventCase != other.EventCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (eventCase_ == EventOneofCase.CustomerEvent) hash ^= CustomerEvent.GetHashCode();
      if (eventCase_ == EventOneofCase.EntitlementEvent) hash ^= EntitlementEvent.GetHashCode();
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
      if (eventCase_ == EventOneofCase.CustomerEvent) {
        output.WriteRawTag(10);
        output.WriteMessage(CustomerEvent);
      }
      if (eventCase_ == EventOneofCase.EntitlementEvent) {
        output.WriteRawTag(18);
        output.WriteMessage(EntitlementEvent);
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
      if (eventCase_ == EventOneofCase.CustomerEvent) {
        output.WriteRawTag(10);
        output.WriteMessage(CustomerEvent);
      }
      if (eventCase_ == EventOneofCase.EntitlementEvent) {
        output.WriteRawTag(18);
        output.WriteMessage(EntitlementEvent);
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
      if (eventCase_ == EventOneofCase.CustomerEvent) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomerEvent);
      }
      if (eventCase_ == EventOneofCase.EntitlementEvent) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntitlementEvent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SubscriberEvent other) {
      if (other == null) {
        return;
      }
      switch (other.EventCase) {
        case EventOneofCase.CustomerEvent:
          if (CustomerEvent == null) {
            CustomerEvent = new global::Google.Cloud.Channel.V1.CustomerEvent();
          }
          CustomerEvent.MergeFrom(other.CustomerEvent);
          break;
        case EventOneofCase.EntitlementEvent:
          if (EntitlementEvent == null) {
            EntitlementEvent = new global::Google.Cloud.Channel.V1.EntitlementEvent();
          }
          EntitlementEvent.MergeFrom(other.EntitlementEvent);
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
            global::Google.Cloud.Channel.V1.CustomerEvent subBuilder = new global::Google.Cloud.Channel.V1.CustomerEvent();
            if (eventCase_ == EventOneofCase.CustomerEvent) {
              subBuilder.MergeFrom(CustomerEvent);
            }
            input.ReadMessage(subBuilder);
            CustomerEvent = subBuilder;
            break;
          }
          case 18: {
            global::Google.Cloud.Channel.V1.EntitlementEvent subBuilder = new global::Google.Cloud.Channel.V1.EntitlementEvent();
            if (eventCase_ == EventOneofCase.EntitlementEvent) {
              subBuilder.MergeFrom(EntitlementEvent);
            }
            input.ReadMessage(subBuilder);
            EntitlementEvent = subBuilder;
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
            global::Google.Cloud.Channel.V1.CustomerEvent subBuilder = new global::Google.Cloud.Channel.V1.CustomerEvent();
            if (eventCase_ == EventOneofCase.CustomerEvent) {
              subBuilder.MergeFrom(CustomerEvent);
            }
            input.ReadMessage(subBuilder);
            CustomerEvent = subBuilder;
            break;
          }
          case 18: {
            global::Google.Cloud.Channel.V1.EntitlementEvent subBuilder = new global::Google.Cloud.Channel.V1.EntitlementEvent();
            if (eventCase_ == EventOneofCase.EntitlementEvent) {
              subBuilder.MergeFrom(EntitlementEvent);
            }
            input.ReadMessage(subBuilder);
            EntitlementEvent = subBuilder;
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
