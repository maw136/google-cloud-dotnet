// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/trainingjob/definition/export_evaluated_data_items_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/trainingjob/definition/export_evaluated_data_items_config.proto</summary>
  public static partial class ExportEvaluatedDataItemsConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/trainingjob/definition/export_evaluated_data_items_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExportEvaluatedDataItemsConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CmFnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvdHJhaW5pbmdq",
            "b2IvZGVmaW5pdGlvbi9leHBvcnRfZXZhbHVhdGVkX2RhdGFfaXRlbXNfY29u",
            "ZmlnLnByb3RvEjhnb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5zY2hlbWEu",
            "dHJhaW5pbmdqb2IuZGVmaW5pdGlvbiJjCh5FeHBvcnRFdmFsdWF0ZWREYXRh",
            "SXRlbXNDb25maWcSIAoYZGVzdGluYXRpb25fYmlncXVlcnlfdXJpGAEgASgJ",
            "Eh8KF292ZXJyaWRlX2V4aXN0aW5nX3RhYmxlGAIgASgIQvoCCjxjb20uZ29v",
            "Z2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuc2NoZW1hLnRyYWluaW5nam9iLmRl",
            "ZmluaXRpb25CI0V4cG9ydEV2YWx1YXRlZERhdGFJdGVtc0NvbmZpZ1Byb3Rv",
            "UAFaXGNsb3VkLmdvb2dsZS5jb20vZ28vYWlwbGF0Zm9ybS9hcGl2MS9zY2hl",
            "bWEvdHJhaW5pbmdqb2IvZGVmaW5pdGlvbi9kZWZpbml0aW9ucGI7ZGVmaW5p",
            "dGlvbnBiqgI4R29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0uVjEuU2NoZW1hLlRy",
            "YWluaW5nSm9iLkRlZmluaXRpb27KAjhHb29nbGVcQ2xvdWRcQUlQbGF0Zm9y",
            "bVxWMVxTY2hlbWFcVHJhaW5pbmdKb2JcRGVmaW5pdGlvbuoCPkdvb2dsZTo6",
            "Q2xvdWQ6OkFJUGxhdGZvcm06OlYxOjpTY2hlbWE6OlRyYWluaW5nSm9iOjpE",
            "ZWZpbml0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.ExportEvaluatedDataItemsConfig), global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.ExportEvaluatedDataItemsConfig.Parser, new[]{ "DestinationBigqueryUri", "OverrideExistingTable" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration for exporting test set predictions to a BigQuery table.
  /// </summary>
  public sealed partial class ExportEvaluatedDataItemsConfig : pb::IMessage<ExportEvaluatedDataItemsConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExportEvaluatedDataItemsConfig> _parser = new pb::MessageParser<ExportEvaluatedDataItemsConfig>(() => new ExportEvaluatedDataItemsConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExportEvaluatedDataItemsConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition.ExportEvaluatedDataItemsConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExportEvaluatedDataItemsConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExportEvaluatedDataItemsConfig(ExportEvaluatedDataItemsConfig other) : this() {
      destinationBigqueryUri_ = other.destinationBigqueryUri_;
      overrideExistingTable_ = other.overrideExistingTable_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExportEvaluatedDataItemsConfig Clone() {
      return new ExportEvaluatedDataItemsConfig(this);
    }

    /// <summary>Field number for the "destination_bigquery_uri" field.</summary>
    public const int DestinationBigqueryUriFieldNumber = 1;
    private string destinationBigqueryUri_ = "";
    /// <summary>
    /// URI of desired destination BigQuery table. Expected format:
    /// bq://&lt;project_id>:&lt;dataset_id>:&lt;table>
    ///
    /// If not specified, then results are exported to the following auto-created
    /// BigQuery table:
    /// &lt;project_id>:export_evaluated_examples_&lt;model_name>_&lt;yyyy_MM_dd'T'HH_mm_ss_SSS'Z'>.evaluated_examples
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DestinationBigqueryUri {
      get { return destinationBigqueryUri_; }
      set {
        destinationBigqueryUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "override_existing_table" field.</summary>
    public const int OverrideExistingTableFieldNumber = 2;
    private bool overrideExistingTable_;
    /// <summary>
    /// If true and an export destination is specified, then the contents of the
    /// destination are overwritten. Otherwise, if the export destination already
    /// exists, then the export operation fails.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OverrideExistingTable {
      get { return overrideExistingTable_; }
      set {
        overrideExistingTable_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExportEvaluatedDataItemsConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExportEvaluatedDataItemsConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DestinationBigqueryUri != other.DestinationBigqueryUri) return false;
      if (OverrideExistingTable != other.OverrideExistingTable) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DestinationBigqueryUri.Length != 0) hash ^= DestinationBigqueryUri.GetHashCode();
      if (OverrideExistingTable != false) hash ^= OverrideExistingTable.GetHashCode();
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
      if (DestinationBigqueryUri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DestinationBigqueryUri);
      }
      if (OverrideExistingTable != false) {
        output.WriteRawTag(16);
        output.WriteBool(OverrideExistingTable);
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
      if (DestinationBigqueryUri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DestinationBigqueryUri);
      }
      if (OverrideExistingTable != false) {
        output.WriteRawTag(16);
        output.WriteBool(OverrideExistingTable);
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
      if (DestinationBigqueryUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DestinationBigqueryUri);
      }
      if (OverrideExistingTable != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExportEvaluatedDataItemsConfig other) {
      if (other == null) {
        return;
      }
      if (other.DestinationBigqueryUri.Length != 0) {
        DestinationBigqueryUri = other.DestinationBigqueryUri;
      }
      if (other.OverrideExistingTable != false) {
        OverrideExistingTable = other.OverrideExistingTable;
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
            DestinationBigqueryUri = input.ReadString();
            break;
          }
          case 16: {
            OverrideExistingTable = input.ReadBool();
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
            DestinationBigqueryUri = input.ReadString();
            break;
          }
          case 16: {
            OverrideExistingTable = input.ReadBool();
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
