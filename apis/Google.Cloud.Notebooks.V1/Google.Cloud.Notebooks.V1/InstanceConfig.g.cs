// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/notebooks/v1/instance_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Notebooks.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/notebooks/v1/instance_config.proto</summary>
  public static partial class InstanceConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/notebooks/v1/instance_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InstanceConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvbm90ZWJvb2tzL3YxL2luc3RhbmNlX2NvbmZpZy5w",
            "cm90bxIZZ29vZ2xlLmNsb3VkLm5vdGVib29rcy52MSJVCg5JbnN0YW5jZUNv",
            "bmZpZxIhChlub3RlYm9va191cGdyYWRlX3NjaGVkdWxlGAEgASgJEiAKGGVu",
            "YWJsZV9oZWFsdGhfbW9uaXRvcmluZxgCIAEoCELKAQodY29tLmdvb2dsZS5j",
            "bG91ZC5ub3RlYm9va3MudjFCE0luc3RhbmNlQ29uZmlnUHJvdG9QAVo7Y2xv",
            "dWQuZ29vZ2xlLmNvbS9nby9ub3RlYm9va3MvYXBpdjEvbm90ZWJvb2tzcGI7",
            "bm90ZWJvb2tzcGKqAhlHb29nbGUuQ2xvdWQuTm90ZWJvb2tzLlYxygIZR29v",
            "Z2xlXENsb3VkXE5vdGVib29rc1xWMeoCHEdvb2dsZTo6Q2xvdWQ6Ok5vdGVi",
            "b29rczo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Notebooks.V1.InstanceConfig), global::Google.Cloud.Notebooks.V1.InstanceConfig.Parser, new[]{ "NotebookUpgradeSchedule", "EnableHealthMonitoring" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Notebook instance configurations that can be updated.
  /// </summary>
  public sealed partial class InstanceConfig : pb::IMessage<InstanceConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InstanceConfig> _parser = new pb::MessageParser<InstanceConfig>(() => new InstanceConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InstanceConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Notebooks.V1.InstanceConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InstanceConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InstanceConfig(InstanceConfig other) : this() {
      notebookUpgradeSchedule_ = other.notebookUpgradeSchedule_;
      enableHealthMonitoring_ = other.enableHealthMonitoring_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InstanceConfig Clone() {
      return new InstanceConfig(this);
    }

    /// <summary>Field number for the "notebook_upgrade_schedule" field.</summary>
    public const int NotebookUpgradeScheduleFieldNumber = 1;
    private string notebookUpgradeSchedule_ = "";
    /// <summary>
    /// Cron expression in UTC timezone, used to schedule instance auto upgrade.
    /// Please follow the [cron format](https://en.wikipedia.org/wiki/Cron).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NotebookUpgradeSchedule {
      get { return notebookUpgradeSchedule_; }
      set {
        notebookUpgradeSchedule_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "enable_health_monitoring" field.</summary>
    public const int EnableHealthMonitoringFieldNumber = 2;
    private bool enableHealthMonitoring_;
    /// <summary>
    /// Verifies core internal services are running.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EnableHealthMonitoring {
      get { return enableHealthMonitoring_; }
      set {
        enableHealthMonitoring_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InstanceConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InstanceConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NotebookUpgradeSchedule != other.NotebookUpgradeSchedule) return false;
      if (EnableHealthMonitoring != other.EnableHealthMonitoring) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NotebookUpgradeSchedule.Length != 0) hash ^= NotebookUpgradeSchedule.GetHashCode();
      if (EnableHealthMonitoring != false) hash ^= EnableHealthMonitoring.GetHashCode();
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
      if (NotebookUpgradeSchedule.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(NotebookUpgradeSchedule);
      }
      if (EnableHealthMonitoring != false) {
        output.WriteRawTag(16);
        output.WriteBool(EnableHealthMonitoring);
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
      if (NotebookUpgradeSchedule.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(NotebookUpgradeSchedule);
      }
      if (EnableHealthMonitoring != false) {
        output.WriteRawTag(16);
        output.WriteBool(EnableHealthMonitoring);
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
      if (NotebookUpgradeSchedule.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NotebookUpgradeSchedule);
      }
      if (EnableHealthMonitoring != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InstanceConfig other) {
      if (other == null) {
        return;
      }
      if (other.NotebookUpgradeSchedule.Length != 0) {
        NotebookUpgradeSchedule = other.NotebookUpgradeSchedule;
      }
      if (other.EnableHealthMonitoring != false) {
        EnableHealthMonitoring = other.EnableHealthMonitoring;
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
            NotebookUpgradeSchedule = input.ReadString();
            break;
          }
          case 16: {
            EnableHealthMonitoring = input.ReadBool();
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
            NotebookUpgradeSchedule = input.ReadString();
            break;
          }
          case 16: {
            EnableHealthMonitoring = input.ReadBool();
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
