// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/cx/v3/advanced_settings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Dialogflow.Cx.V3 {

  /// <summary>Holder for reflection information generated from google/cloud/dialogflow/cx/v3/advanced_settings.proto</summary>
  public static partial class AdvancedSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/dialogflow/cx/v3/advanced_settings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdvancedSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvY2xvdWQvZGlhbG9nZmxvdy9jeC92My9hZHZhbmNlZF9zZXR0",
            "aW5ncy5wcm90bxIdZ29vZ2xlLmNsb3VkLmRpYWxvZ2Zsb3cuY3gudjMaH2dv",
            "b2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aHmdvb2dsZS9wcm90b2J1",
            "Zi9kdXJhdGlvbi5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "byLIAQoQQWR2YW5jZWRTZXR0aW5ncxJZChBsb2dnaW5nX3NldHRpbmdzGAYg",
            "ASgLMj8uZ29vZ2xlLmNsb3VkLmRpYWxvZ2Zsb3cuY3gudjMuQWR2YW5jZWRT",
            "ZXR0aW5ncy5Mb2dnaW5nU2V0dGluZ3MaWQoPTG9nZ2luZ1NldHRpbmdzEiIK",
            "GmVuYWJsZV9zdGFja2RyaXZlcl9sb2dnaW5nGAIgASgIEiIKGmVuYWJsZV9p",
            "bnRlcmFjdGlvbl9sb2dnaW5nGAMgASgIQqUBCiFjb20uZ29vZ2xlLmNsb3Vk",
            "LmRpYWxvZ2Zsb3cuY3gudjNCFUFkdmFuY2VkU2V0dGluZ3NQcm90b1ABWj9n",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL2Rp",
            "YWxvZ2Zsb3cvY3gvdjM7Y3j4AQGiAgJERqoCHUdvb2dsZS5DbG91ZC5EaWFs",
            "b2dmbG93LkN4LlYzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings), global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Parser, new[]{ "LoggingSettings" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.LoggingSettings), global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.LoggingSettings.Parser, new[]{ "EnableStackdriverLogging", "EnableInteractionLogging" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Hierarchical advanced settings for agent/flow/page/fulfillment/parameter.
  /// Settings exposed at lower level overrides the settings exposed at higher
  /// level.
  ///
  /// Hierarchy: Agent->Flow->Page->Fulfillment/Parameter.
  /// </summary>
  public sealed partial class AdvancedSettings : pb::IMessage<AdvancedSettings>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdvancedSettings> _parser = new pb::MessageParser<AdvancedSettings>(() => new AdvancedSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdvancedSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvancedSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvancedSettings(AdvancedSettings other) : this() {
      loggingSettings_ = other.loggingSettings_ != null ? other.loggingSettings_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvancedSettings Clone() {
      return new AdvancedSettings(this);
    }

    /// <summary>Field number for the "logging_settings" field.</summary>
    public const int LoggingSettingsFieldNumber = 6;
    private global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.LoggingSettings loggingSettings_;
    /// <summary>
    /// Settings for logging.
    /// Settings for Dialogflow History, Contact Center messages, StackDriver logs,
    /// and speech logging.
    /// Exposed at the following levels:
    /// - Agent level.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.LoggingSettings LoggingSettings {
      get { return loggingSettings_; }
      set {
        loggingSettings_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdvancedSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdvancedSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(LoggingSettings, other.LoggingSettings)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (loggingSettings_ != null) hash ^= LoggingSettings.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (loggingSettings_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(LoggingSettings);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (loggingSettings_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(LoggingSettings);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (loggingSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LoggingSettings);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdvancedSettings other) {
      if (other == null) {
        return;
      }
      if (other.loggingSettings_ != null) {
        if (loggingSettings_ == null) {
          LoggingSettings = new global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.LoggingSettings();
        }
        LoggingSettings.MergeFrom(other.LoggingSettings);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 50: {
            if (loggingSettings_ == null) {
              LoggingSettings = new global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.LoggingSettings();
            }
            input.ReadMessage(LoggingSettings);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 50: {
            if (loggingSettings_ == null) {
              LoggingSettings = new global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.LoggingSettings();
            }
            input.ReadMessage(LoggingSettings);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AdvancedSettings message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Define behaviors on logging.
      /// </summary>
      public sealed partial class LoggingSettings : pb::IMessage<LoggingSettings>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<LoggingSettings> _parser = new pb::MessageParser<LoggingSettings>(() => new LoggingSettings());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<LoggingSettings> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public LoggingSettings() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public LoggingSettings(LoggingSettings other) : this() {
          enableStackdriverLogging_ = other.enableStackdriverLogging_;
          enableInteractionLogging_ = other.enableInteractionLogging_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public LoggingSettings Clone() {
          return new LoggingSettings(this);
        }

        /// <summary>Field number for the "enable_stackdriver_logging" field.</summary>
        public const int EnableStackdriverLoggingFieldNumber = 2;
        private bool enableStackdriverLogging_;
        /// <summary>
        /// If true, StackDriver logging is currently enabled.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool EnableStackdriverLogging {
          get { return enableStackdriverLogging_; }
          set {
            enableStackdriverLogging_ = value;
          }
        }

        /// <summary>Field number for the "enable_interaction_logging" field.</summary>
        public const int EnableInteractionLoggingFieldNumber = 3;
        private bool enableInteractionLogging_;
        /// <summary>
        /// If true, DF Interaction logging is currently enabled.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool EnableInteractionLogging {
          get { return enableInteractionLogging_; }
          set {
            enableInteractionLogging_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as LoggingSettings);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(LoggingSettings other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (EnableStackdriverLogging != other.EnableStackdriverLogging) return false;
          if (EnableInteractionLogging != other.EnableInteractionLogging) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (EnableStackdriverLogging != false) hash ^= EnableStackdriverLogging.GetHashCode();
          if (EnableInteractionLogging != false) hash ^= EnableInteractionLogging.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (EnableStackdriverLogging != false) {
            output.WriteRawTag(16);
            output.WriteBool(EnableStackdriverLogging);
          }
          if (EnableInteractionLogging != false) {
            output.WriteRawTag(24);
            output.WriteBool(EnableInteractionLogging);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (EnableStackdriverLogging != false) {
            output.WriteRawTag(16);
            output.WriteBool(EnableStackdriverLogging);
          }
          if (EnableInteractionLogging != false) {
            output.WriteRawTag(24);
            output.WriteBool(EnableInteractionLogging);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (EnableStackdriverLogging != false) {
            size += 1 + 1;
          }
          if (EnableInteractionLogging != false) {
            size += 1 + 1;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(LoggingSettings other) {
          if (other == null) {
            return;
          }
          if (other.EnableStackdriverLogging != false) {
            EnableStackdriverLogging = other.EnableStackdriverLogging;
          }
          if (other.EnableInteractionLogging != false) {
            EnableInteractionLogging = other.EnableInteractionLogging;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
              case 16: {
                EnableStackdriverLogging = input.ReadBool();
                break;
              }
              case 24: {
                EnableInteractionLogging = input.ReadBool();
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 16: {
                EnableStackdriverLogging = input.ReadBool();
                break;
              }
              case 24: {
                EnableInteractionLogging = input.ReadBool();
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
