// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/settings/v1beta1/sink_settings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.Settings.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/settings/v1beta1/sink_settings.proto</summary>
  public static partial class SinkSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/settings/v1beta1/sink_settings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SinkSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvc2V0dGluZ3MvdjFiZXRh",
            "MS9zaW5rX3NldHRpbmdzLnByb3RvEixnb29nbGUuY2xvdWQuc2VjdXJpdHlj",
            "ZW50ZXIuc2V0dGluZ3MudjFiZXRhMRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9u",
            "cy5wcm90byIsCgxTaW5rU2V0dGluZ3MSHAoUbG9nZ2luZ19zaW5rX3Byb2pl",
            "Y3QYASABKAlCqQIKMGNvbS5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIu",
            "c2V0dGluZ3MudjFiZXRhMUIJU2lua1Byb3RvUAFaVGdvb2dsZS5nb2xhbmcu",
            "b3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvc2VjdXJpdHljZW50ZXIv",
            "c2V0dGluZ3MvdjFiZXRhMTtzZXR0aW5nc/gBAaoCLEdvb2dsZS5DbG91ZC5T",
            "ZWN1cml0eUNlbnRlci5TZXR0aW5ncy5WMUJldGExygIsR29vZ2xlXENsb3Vk",
            "XFNlY3VyaXR5Q2VudGVyXFNldHRpbmdzXFYxYmV0YTHqAjBHb29nbGU6OkNs",
            "b3VkOjpTZWN1cml0eUNlbnRlcjo6U2V0dGluZ3M6OlYxYmV0YTFiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.Settings.V1Beta1.SinkSettings), global::Google.Cloud.SecurityCenter.Settings.V1Beta1.SinkSettings.Parser, new[]{ "LoggingSinkProject" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Sink Settings for Security Command Center
  /// </summary>
  public sealed partial class SinkSettings : pb::IMessage<SinkSettings>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SinkSettings> _parser = new pb::MessageParser<SinkSettings>(() => new SinkSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SinkSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.Settings.V1Beta1.SinkSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SinkSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SinkSettings(SinkSettings other) : this() {
      loggingSinkProject_ = other.loggingSinkProject_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SinkSettings Clone() {
      return new SinkSettings(this);
    }

    /// <summary>Field number for the "logging_sink_project" field.</summary>
    public const int LoggingSinkProjectFieldNumber = 1;
    private string loggingSinkProject_ = "";
    /// <summary>
    /// The resource name of the project to send logs to. This project must be
    /// part of the same organization where the Security Center API is
    /// enabled. The format is `projects/{project}`. If it is empty, we do
    /// not output logs. If a project ID is provided it will be normalized to a
    /// project number.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LoggingSinkProject {
      get { return loggingSinkProject_; }
      set {
        loggingSinkProject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SinkSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SinkSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LoggingSinkProject != other.LoggingSinkProject) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LoggingSinkProject.Length != 0) hash ^= LoggingSinkProject.GetHashCode();
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
      if (LoggingSinkProject.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LoggingSinkProject);
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
      if (LoggingSinkProject.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LoggingSinkProject);
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
      if (LoggingSinkProject.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LoggingSinkProject);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SinkSettings other) {
      if (other == null) {
        return;
      }
      if (other.LoggingSinkProject.Length != 0) {
        LoggingSinkProject = other.LoggingSinkProject;
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
            LoggingSinkProject = input.ReadString();
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
            LoggingSinkProject = input.ReadString();
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
