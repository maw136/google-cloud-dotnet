// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/datacatalog/v1/usage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DataCatalog.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/datacatalog/v1/usage.proto</summary>
  public static partial class UsageReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/datacatalog/v1/usage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UsageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidnb29nbGUvY2xvdWQvZGF0YWNhdGFsb2cvdjEvdXNhZ2UucHJvdG8SG2dv",
            "b2dsZS5jbG91ZC5kYXRhY2F0YWxvZy52MRofZ29vZ2xlL2FwaS9maWVsZF9i",
            "ZWhhdmlvci5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90",
            "byKRAQoKVXNhZ2VTdGF0cxIZChF0b3RhbF9jb21wbGV0aW9ucxgBIAEoAhIW",
            "Cg50b3RhbF9mYWlsdXJlcxgCIAEoAhIbChN0b3RhbF9jYW5jZWxsYXRpb25z",
            "GAMgASgCEjMKK3RvdGFsX2V4ZWN1dGlvbl90aW1lX2Zvcl9jb21wbGV0aW9u",
            "c19taWxsaXMYBCABKAIijgIKC1VzYWdlU2lnbmFsEi8KC3VwZGF0ZV90aW1l",
            "GAEgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBJoChd1c2FnZV93",
            "aXRoaW5fdGltZV9yYW5nZRgCIAMoCzJCLmdvb2dsZS5jbG91ZC5kYXRhY2F0",
            "YWxvZy52MS5Vc2FnZVNpZ25hbC5Vc2FnZVdpdGhpblRpbWVSYW5nZUVudHJ5",
            "QgPgQQMaZAoZVXNhZ2VXaXRoaW5UaW1lUmFuZ2VFbnRyeRILCgNrZXkYASAB",
            "KAkSNgoFdmFsdWUYAiABKAsyJy5nb29nbGUuY2xvdWQuZGF0YWNhdGFsb2cu",
            "djEuVXNhZ2VTdGF0czoCOAFCywEKH2NvbS5nb29nbGUuY2xvdWQuZGF0YWNh",
            "dGFsb2cudjFQAVpGZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9jbG91ZC9kYXRhY2F0YWxvZy92MTtkYXRhY2F0YWxvZ/gBAaoCG0dv",
            "b2dsZS5DbG91ZC5EYXRhQ2F0YWxvZy5WMcoCG0dvb2dsZVxDbG91ZFxEYXRh",
            "Q2F0YWxvZ1xWMeoCHkdvb2dsZTo6Q2xvdWQ6OkRhdGFDYXRhbG9nOjpWMWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.UsageStats), global::Google.Cloud.DataCatalog.V1.UsageStats.Parser, new[]{ "TotalCompletions", "TotalFailures", "TotalCancellations", "TotalExecutionTimeForCompletionsMillis" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.UsageSignal), global::Google.Cloud.DataCatalog.V1.UsageSignal.Parser, new[]{ "UpdateTime", "UsageWithinTimeRange" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Detailed statistics on the entry's usage.
  ///
  /// Usage statistics have the following limitations:
  ///
  /// - Only BigQuery tables have them.
  /// - They only include BigQuery query jobs.
  /// - They might be underestimated because wildcard table references
  ///   are not yet counted. For more information, see
  ///   [Querying multiple tables using a wildcard table]
  ///   (https://cloud.google.com/bigquery/docs/querying-wildcard-tables)
  /// </summary>
  public sealed partial class UsageStats : pb::IMessage<UsageStats>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UsageStats> _parser = new pb::MessageParser<UsageStats>(() => new UsageStats());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UsageStats> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.UsageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UsageStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UsageStats(UsageStats other) : this() {
      totalCompletions_ = other.totalCompletions_;
      totalFailures_ = other.totalFailures_;
      totalCancellations_ = other.totalCancellations_;
      totalExecutionTimeForCompletionsMillis_ = other.totalExecutionTimeForCompletionsMillis_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UsageStats Clone() {
      return new UsageStats(this);
    }

    /// <summary>Field number for the "total_completions" field.</summary>
    public const int TotalCompletionsFieldNumber = 1;
    private float totalCompletions_;
    /// <summary>
    /// The number of successful uses of the underlying entry.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float TotalCompletions {
      get { return totalCompletions_; }
      set {
        totalCompletions_ = value;
      }
    }

    /// <summary>Field number for the "total_failures" field.</summary>
    public const int TotalFailuresFieldNumber = 2;
    private float totalFailures_;
    /// <summary>
    /// The number of failed attempts to use the underlying entry.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float TotalFailures {
      get { return totalFailures_; }
      set {
        totalFailures_ = value;
      }
    }

    /// <summary>Field number for the "total_cancellations" field.</summary>
    public const int TotalCancellationsFieldNumber = 3;
    private float totalCancellations_;
    /// <summary>
    /// The number of cancelled attempts to use the underlying entry.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float TotalCancellations {
      get { return totalCancellations_; }
      set {
        totalCancellations_ = value;
      }
    }

    /// <summary>Field number for the "total_execution_time_for_completions_millis" field.</summary>
    public const int TotalExecutionTimeForCompletionsMillisFieldNumber = 4;
    private float totalExecutionTimeForCompletionsMillis_;
    /// <summary>
    /// Total time spent only on successful uses, in milliseconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float TotalExecutionTimeForCompletionsMillis {
      get { return totalExecutionTimeForCompletionsMillis_; }
      set {
        totalExecutionTimeForCompletionsMillis_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UsageStats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UsageStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalCompletions, other.TotalCompletions)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalFailures, other.TotalFailures)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalCancellations, other.TotalCancellations)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalExecutionTimeForCompletionsMillis, other.TotalExecutionTimeForCompletionsMillis)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TotalCompletions != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalCompletions);
      if (TotalFailures != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalFailures);
      if (TotalCancellations != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalCancellations);
      if (TotalExecutionTimeForCompletionsMillis != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalExecutionTimeForCompletionsMillis);
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
      if (TotalCompletions != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(TotalCompletions);
      }
      if (TotalFailures != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(TotalFailures);
      }
      if (TotalCancellations != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(TotalCancellations);
      }
      if (TotalExecutionTimeForCompletionsMillis != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(TotalExecutionTimeForCompletionsMillis);
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
      if (TotalCompletions != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(TotalCompletions);
      }
      if (TotalFailures != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(TotalFailures);
      }
      if (TotalCancellations != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(TotalCancellations);
      }
      if (TotalExecutionTimeForCompletionsMillis != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(TotalExecutionTimeForCompletionsMillis);
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
      if (TotalCompletions != 0F) {
        size += 1 + 4;
      }
      if (TotalFailures != 0F) {
        size += 1 + 4;
      }
      if (TotalCancellations != 0F) {
        size += 1 + 4;
      }
      if (TotalExecutionTimeForCompletionsMillis != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UsageStats other) {
      if (other == null) {
        return;
      }
      if (other.TotalCompletions != 0F) {
        TotalCompletions = other.TotalCompletions;
      }
      if (other.TotalFailures != 0F) {
        TotalFailures = other.TotalFailures;
      }
      if (other.TotalCancellations != 0F) {
        TotalCancellations = other.TotalCancellations;
      }
      if (other.TotalExecutionTimeForCompletionsMillis != 0F) {
        TotalExecutionTimeForCompletionsMillis = other.TotalExecutionTimeForCompletionsMillis;
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
          case 13: {
            TotalCompletions = input.ReadFloat();
            break;
          }
          case 21: {
            TotalFailures = input.ReadFloat();
            break;
          }
          case 29: {
            TotalCancellations = input.ReadFloat();
            break;
          }
          case 37: {
            TotalExecutionTimeForCompletionsMillis = input.ReadFloat();
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
          case 13: {
            TotalCompletions = input.ReadFloat();
            break;
          }
          case 21: {
            TotalFailures = input.ReadFloat();
            break;
          }
          case 29: {
            TotalCancellations = input.ReadFloat();
            break;
          }
          case 37: {
            TotalExecutionTimeForCompletionsMillis = input.ReadFloat();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The set of all usage signals that Data Catalog stores.
  ///
  /// Note: Usually, these signals are updated daily. In rare cases, an update may
  /// fail but will be performed again on the next day.
  /// </summary>
  public sealed partial class UsageSignal : pb::IMessage<UsageSignal>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UsageSignal> _parser = new pb::MessageParser<UsageSignal>(() => new UsageSignal());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UsageSignal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.UsageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UsageSignal() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UsageSignal(UsageSignal other) : this() {
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      usageWithinTimeRange_ = other.usageWithinTimeRange_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UsageSignal Clone() {
      return new UsageSignal(this);
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// The end timestamp of the duration of usage statistics.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "usage_within_time_range" field.</summary>
    public const int UsageWithinTimeRangeFieldNumber = 2;
    private static readonly pbc::MapField<string, global::Google.Cloud.DataCatalog.V1.UsageStats>.Codec _map_usageWithinTimeRange_codec
        = new pbc::MapField<string, global::Google.Cloud.DataCatalog.V1.UsageStats>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Google.Cloud.DataCatalog.V1.UsageStats.Parser), 18);
    private readonly pbc::MapField<string, global::Google.Cloud.DataCatalog.V1.UsageStats> usageWithinTimeRange_ = new pbc::MapField<string, global::Google.Cloud.DataCatalog.V1.UsageStats>();
    /// <summary>
    /// Output only. BigQuery usage statistics over each of the predefined time ranges.
    ///
    /// Supported time ranges are `{"24H", "7D", "30D"}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Google.Cloud.DataCatalog.V1.UsageStats> UsageWithinTimeRange {
      get { return usageWithinTimeRange_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UsageSignal);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UsageSignal other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!UsageWithinTimeRange.Equals(other.UsageWithinTimeRange)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      hash ^= UsageWithinTimeRange.GetHashCode();
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
      if (updateTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UpdateTime);
      }
      usageWithinTimeRange_.WriteTo(output, _map_usageWithinTimeRange_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (updateTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UpdateTime);
      }
      usageWithinTimeRange_.WriteTo(ref output, _map_usageWithinTimeRange_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      size += usageWithinTimeRange_.CalculateSize(_map_usageWithinTimeRange_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UsageSignal other) {
      if (other == null) {
        return;
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      usageWithinTimeRange_.Add(other.usageWithinTimeRange_);
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
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 18: {
            usageWithinTimeRange_.AddEntriesFrom(input, _map_usageWithinTimeRange_codec);
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
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 18: {
            usageWithinTimeRange_.AddEntriesFrom(ref input, _map_usageWithinTimeRange_codec);
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
