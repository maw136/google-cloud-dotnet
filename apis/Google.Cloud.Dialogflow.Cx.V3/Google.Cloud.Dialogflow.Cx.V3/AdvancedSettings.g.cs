// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/cx/v3/advanced_settings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
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
            "b2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aJ2dvb2dsZS9jbG91ZC9k",
            "aWFsb2dmbG93L2N4L3YzL2djcy5wcm90byK9AwoQQWR2YW5jZWRTZXR0aW5n",
            "cxJTChxhdWRpb19leHBvcnRfZ2NzX2Rlc3RpbmF0aW9uGAIgASgLMi0uZ29v",
            "Z2xlLmNsb3VkLmRpYWxvZ2Zsb3cuY3gudjMuR2NzRGVzdGluYXRpb24SUwoN",
            "ZHRtZl9zZXR0aW5ncxgFIAEoCzI8Lmdvb2dsZS5jbG91ZC5kaWFsb2dmbG93",
            "LmN4LnYzLkFkdmFuY2VkU2V0dGluZ3MuRHRtZlNldHRpbmdzElkKEGxvZ2dp",
            "bmdfc2V0dGluZ3MYBiABKAsyPy5nb29nbGUuY2xvdWQuZGlhbG9nZmxvdy5j",
            "eC52My5BZHZhbmNlZFNldHRpbmdzLkxvZ2dpbmdTZXR0aW5ncxpJCgxEdG1m",
            "U2V0dGluZ3MSDwoHZW5hYmxlZBgBIAEoCBISCgptYXhfZGlnaXRzGAIgASgF",
            "EhQKDGZpbmlzaF9kaWdpdBgDIAEoCRpZCg9Mb2dnaW5nU2V0dGluZ3MSIgoa",
            "ZW5hYmxlX3N0YWNrZHJpdmVyX2xvZ2dpbmcYAiABKAgSIgoaZW5hYmxlX2lu",
            "dGVyYWN0aW9uX2xvZ2dpbmcYAyABKAhCuwEKIWNvbS5nb29nbGUuY2xvdWQu",
            "ZGlhbG9nZmxvdy5jeC52M0IVQWR2YW5jZWRTZXR0aW5nc1Byb3RvUAFaMWNs",
            "b3VkLmdvb2dsZS5jb20vZ28vZGlhbG9nZmxvdy9jeC9hcGl2My9jeHBiO2N4",
            "cGL4AQGiAgJERqoCHUdvb2dsZS5DbG91ZC5EaWFsb2dmbG93LkN4LlYz6gIh",
            "R29vZ2xlOjpDbG91ZDo6RGlhbG9nZmxvdzo6Q1g6OlYzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Cloud.Dialogflow.Cx.V3.GcsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings), global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Parser, new[]{ "AudioExportGcsDestination", "DtmfSettings", "LoggingSettings" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.DtmfSettings), global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.DtmfSettings.Parser, new[]{ "Enabled", "MaxDigits", "FinishDigit" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.LoggingSettings), global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.LoggingSettings.Parser, new[]{ "EnableStackdriverLogging", "EnableInteractionLogging" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Hierarchical advanced settings for agent/flow/page/fulfillment/parameter.
  /// Settings exposed at lower level overrides the settings exposed at higher
  /// level. Overriding occurs at the sub-setting level. For example, the
  /// playback_interruption_settings at fulfillment level only overrides the
  /// playback_interruption_settings at the agent level, leaving other settings
  /// at the agent level unchanged.
  ///
  /// DTMF settings does not override each other. DTMF settings set at different
  /// levels define DTMF detections running in parallel.
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdvancedSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdvancedSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdvancedSettings(AdvancedSettings other) : this() {
      audioExportGcsDestination_ = other.audioExportGcsDestination_ != null ? other.audioExportGcsDestination_.Clone() : null;
      dtmfSettings_ = other.dtmfSettings_ != null ? other.dtmfSettings_.Clone() : null;
      loggingSettings_ = other.loggingSettings_ != null ? other.loggingSettings_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdvancedSettings Clone() {
      return new AdvancedSettings(this);
    }

    /// <summary>Field number for the "audio_export_gcs_destination" field.</summary>
    public const int AudioExportGcsDestinationFieldNumber = 2;
    private global::Google.Cloud.Dialogflow.Cx.V3.GcsDestination audioExportGcsDestination_;
    /// <summary>
    /// If present, incoming audio is exported by Dialogflow to the configured
    /// Google Cloud Storage destination.
    /// Exposed at the following levels:
    /// - Agent level
    /// - Flow level
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Dialogflow.Cx.V3.GcsDestination AudioExportGcsDestination {
      get { return audioExportGcsDestination_; }
      set {
        audioExportGcsDestination_ = value;
      }
    }

    /// <summary>Field number for the "dtmf_settings" field.</summary>
    public const int DtmfSettingsFieldNumber = 5;
    private global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.DtmfSettings dtmfSettings_;
    /// <summary>
    /// Settings for DTMF.
    /// Exposed at the following levels:
    /// - Agent level
    /// - Flow level
    /// - Page level
    /// - Parameter level.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.DtmfSettings DtmfSettings {
      get { return dtmfSettings_; }
      set {
        dtmfSettings_ = value;
      }
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.LoggingSettings LoggingSettings {
      get { return loggingSettings_; }
      set {
        loggingSettings_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdvancedSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdvancedSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AudioExportGcsDestination, other.AudioExportGcsDestination)) return false;
      if (!object.Equals(DtmfSettings, other.DtmfSettings)) return false;
      if (!object.Equals(LoggingSettings, other.LoggingSettings)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (audioExportGcsDestination_ != null) hash ^= AudioExportGcsDestination.GetHashCode();
      if (dtmfSettings_ != null) hash ^= DtmfSettings.GetHashCode();
      if (loggingSettings_ != null) hash ^= LoggingSettings.GetHashCode();
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
      if (audioExportGcsDestination_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AudioExportGcsDestination);
      }
      if (dtmfSettings_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(DtmfSettings);
      }
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (audioExportGcsDestination_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AudioExportGcsDestination);
      }
      if (dtmfSettings_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(DtmfSettings);
      }
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (audioExportGcsDestination_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AudioExportGcsDestination);
      }
      if (dtmfSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DtmfSettings);
      }
      if (loggingSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LoggingSettings);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdvancedSettings other) {
      if (other == null) {
        return;
      }
      if (other.audioExportGcsDestination_ != null) {
        if (audioExportGcsDestination_ == null) {
          AudioExportGcsDestination = new global::Google.Cloud.Dialogflow.Cx.V3.GcsDestination();
        }
        AudioExportGcsDestination.MergeFrom(other.AudioExportGcsDestination);
      }
      if (other.dtmfSettings_ != null) {
        if (dtmfSettings_ == null) {
          DtmfSettings = new global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.DtmfSettings();
        }
        DtmfSettings.MergeFrom(other.DtmfSettings);
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
          case 18: {
            if (audioExportGcsDestination_ == null) {
              AudioExportGcsDestination = new global::Google.Cloud.Dialogflow.Cx.V3.GcsDestination();
            }
            input.ReadMessage(AudioExportGcsDestination);
            break;
          }
          case 42: {
            if (dtmfSettings_ == null) {
              DtmfSettings = new global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.DtmfSettings();
            }
            input.ReadMessage(DtmfSettings);
            break;
          }
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            if (audioExportGcsDestination_ == null) {
              AudioExportGcsDestination = new global::Google.Cloud.Dialogflow.Cx.V3.GcsDestination();
            }
            input.ReadMessage(AudioExportGcsDestination);
            break;
          }
          case 42: {
            if (dtmfSettings_ == null) {
              DtmfSettings = new global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Types.DtmfSettings();
            }
            input.ReadMessage(DtmfSettings);
            break;
          }
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Define behaviors for DTMF (dual tone multi frequency).
      /// </summary>
      public sealed partial class DtmfSettings : pb::IMessage<DtmfSettings>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<DtmfSettings> _parser = new pb::MessageParser<DtmfSettings>(() => new DtmfSettings());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<DtmfSettings> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DtmfSettings() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DtmfSettings(DtmfSettings other) : this() {
          enabled_ = other.enabled_;
          maxDigits_ = other.maxDigits_;
          finishDigit_ = other.finishDigit_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DtmfSettings Clone() {
          return new DtmfSettings(this);
        }

        /// <summary>Field number for the "enabled" field.</summary>
        public const int EnabledFieldNumber = 1;
        private bool enabled_;
        /// <summary>
        /// If true, incoming audio is processed for DTMF (dual tone multi frequency)
        /// events. For example, if the caller presses a button on their telephone
        /// keypad and DTMF processing is enabled, Dialogflow will detect the
        /// event (e.g. a "3" was pressed) in the incoming audio and pass the event
        /// to the bot to drive business logic (e.g. when 3 is pressed, return the
        /// account balance).
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Enabled {
          get { return enabled_; }
          set {
            enabled_ = value;
          }
        }

        /// <summary>Field number for the "max_digits" field.</summary>
        public const int MaxDigitsFieldNumber = 2;
        private int maxDigits_;
        /// <summary>
        /// Max length of DTMF digits.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int MaxDigits {
          get { return maxDigits_; }
          set {
            maxDigits_ = value;
          }
        }

        /// <summary>Field number for the "finish_digit" field.</summary>
        public const int FinishDigitFieldNumber = 3;
        private string finishDigit_ = "";
        /// <summary>
        /// The digit that terminates a DTMF digit sequence.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string FinishDigit {
          get { return finishDigit_; }
          set {
            finishDigit_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as DtmfSettings);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(DtmfSettings other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Enabled != other.Enabled) return false;
          if (MaxDigits != other.MaxDigits) return false;
          if (FinishDigit != other.FinishDigit) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Enabled != false) hash ^= Enabled.GetHashCode();
          if (MaxDigits != 0) hash ^= MaxDigits.GetHashCode();
          if (FinishDigit.Length != 0) hash ^= FinishDigit.GetHashCode();
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
          if (Enabled != false) {
            output.WriteRawTag(8);
            output.WriteBool(Enabled);
          }
          if (MaxDigits != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(MaxDigits);
          }
          if (FinishDigit.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(FinishDigit);
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
          if (Enabled != false) {
            output.WriteRawTag(8);
            output.WriteBool(Enabled);
          }
          if (MaxDigits != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(MaxDigits);
          }
          if (FinishDigit.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(FinishDigit);
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
          if (Enabled != false) {
            size += 1 + 1;
          }
          if (MaxDigits != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxDigits);
          }
          if (FinishDigit.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(FinishDigit);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(DtmfSettings other) {
          if (other == null) {
            return;
          }
          if (other.Enabled != false) {
            Enabled = other.Enabled;
          }
          if (other.MaxDigits != 0) {
            MaxDigits = other.MaxDigits;
          }
          if (other.FinishDigit.Length != 0) {
            FinishDigit = other.FinishDigit;
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
              case 8: {
                Enabled = input.ReadBool();
                break;
              }
              case 16: {
                MaxDigits = input.ReadInt32();
                break;
              }
              case 26: {
                FinishDigit = input.ReadString();
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
                Enabled = input.ReadBool();
                break;
              }
              case 16: {
                MaxDigits = input.ReadInt32();
                break;
              }
              case 26: {
                FinishDigit = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

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
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<LoggingSettings> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Dialogflow.Cx.V3.AdvancedSettings.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public LoggingSettings() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public LoggingSettings(LoggingSettings other) : this() {
          enableStackdriverLogging_ = other.enableStackdriverLogging_;
          enableInteractionLogging_ = other.enableInteractionLogging_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool EnableInteractionLogging {
          get { return enableInteractionLogging_; }
          set {
            enableInteractionLogging_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as LoggingSettings);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
