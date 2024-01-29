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
            "c19taWxsaXMYBCABKAIiOgoQQ29tbW9uVXNhZ2VTdGF0cxIXCgp2aWV3X2Nv",
            "dW50GAEgASgDSACIAQFCDQoLX3ZpZXdfY291bnQiowQKC1VzYWdlU2lnbmFs",
            "Ei8KC3VwZGF0ZV90aW1lGAEgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVz",
            "dGFtcBJpChd1c2FnZV93aXRoaW5fdGltZV9yYW5nZRgCIAMoCzJCLmdvb2ds",
            "ZS5jbG91ZC5kYXRhY2F0YWxvZy52MS5Vc2FnZVNpZ25hbC5Vc2FnZVdpdGhp",
            "blRpbWVSYW5nZUVudHJ5QgTiQQEDEnAKHmNvbW1vbl91c2FnZV93aXRoaW5f",
            "dGltZV9yYW5nZRgDIAMoCzJILmdvb2dsZS5jbG91ZC5kYXRhY2F0YWxvZy52",
            "MS5Vc2FnZVNpZ25hbC5Db21tb25Vc2FnZVdpdGhpblRpbWVSYW5nZUVudHJ5",
            "EhsKDmZhdm9yaXRlX2NvdW50GAQgASgDSACIAQEaZAoZVXNhZ2VXaXRoaW5U",
            "aW1lUmFuZ2VFbnRyeRILCgNrZXkYASABKAkSNgoFdmFsdWUYAiABKAsyJy5n",
            "b29nbGUuY2xvdWQuZGF0YWNhdGFsb2cudjEuVXNhZ2VTdGF0czoCOAEacAof",
            "Q29tbW9uVXNhZ2VXaXRoaW5UaW1lUmFuZ2VFbnRyeRILCgNrZXkYASABKAkS",
            "PAoFdmFsdWUYAiABKAsyLS5nb29nbGUuY2xvdWQuZGF0YWNhdGFsb2cudjEu",
            "Q29tbW9uVXNhZ2VTdGF0czoCOAFCEQoPX2Zhdm9yaXRlX2NvdW50QsYBCh9j",
            "b20uZ29vZ2xlLmNsb3VkLmRhdGFjYXRhbG9nLnYxUAFaQWNsb3VkLmdvb2ds",
            "ZS5jb20vZ28vZGF0YWNhdGFsb2cvYXBpdjEvZGF0YWNhdGFsb2dwYjtkYXRh",
            "Y2F0YWxvZ3Bi+AEBqgIbR29vZ2xlLkNsb3VkLkRhdGFDYXRhbG9nLlYxygIb",
            "R29vZ2xlXENsb3VkXERhdGFDYXRhbG9nXFYx6gIeR29vZ2xlOjpDbG91ZDo6",
            "RGF0YUNhdGFsb2c6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.UsageStats), global::Google.Cloud.DataCatalog.V1.UsageStats.Parser, new[]{ "TotalCompletions", "TotalFailures", "TotalCancellations", "TotalExecutionTimeForCompletionsMillis" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.CommonUsageStats), global::Google.Cloud.DataCatalog.V1.CommonUsageStats.Parser, new[]{ "ViewCount" }, new[]{ "ViewCount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.UsageSignal), global::Google.Cloud.DataCatalog.V1.UsageSignal.Parser, new[]{ "UpdateTime", "UsageWithinTimeRange", "CommonUsageWithinTimeRange", "FavoriteCount" }, new[]{ "FavoriteCount" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
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
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
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
  /// Common statistics on the entry's usage.
  ///
  /// They can be set on any system.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CommonUsageStats : pb::IMessage<CommonUsageStats>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CommonUsageStats> _parser = new pb::MessageParser<CommonUsageStats>(() => new CommonUsageStats());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CommonUsageStats> Parser { get { return _parser; } }

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
    public CommonUsageStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonUsageStats(CommonUsageStats other) : this() {
      _hasBits0 = other._hasBits0;
      viewCount_ = other.viewCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonUsageStats Clone() {
      return new CommonUsageStats(this);
    }

    /// <summary>Field number for the "view_count" field.</summary>
    public const int ViewCountFieldNumber = 1;
    private readonly static long ViewCountDefaultValue = 0L;

    private long viewCount_;
    /// <summary>
    /// View count in source system.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ViewCount {
      get { if ((_hasBits0 & 1) != 0) { return viewCount_; } else { return ViewCountDefaultValue; } }
      set {
        _hasBits0 |= 1;
        viewCount_ = value;
      }
    }
    /// <summary>Gets whether the "view_count" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasViewCount {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "view_count" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearViewCount() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CommonUsageStats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CommonUsageStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ViewCount != other.ViewCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasViewCount) hash ^= ViewCount.GetHashCode();
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
      if (HasViewCount) {
        output.WriteRawTag(8);
        output.WriteInt64(ViewCount);
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
      if (HasViewCount) {
        output.WriteRawTag(8);
        output.WriteInt64(ViewCount);
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
      if (HasViewCount) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ViewCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CommonUsageStats other) {
      if (other == null) {
        return;
      }
      if (other.HasViewCount) {
        ViewCount = other.ViewCount;
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
            ViewCount = input.ReadInt64();
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
            ViewCount = input.ReadInt64();
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
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UsageSignal : pb::IMessage<UsageSignal>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UsageSignal> _parser = new pb::MessageParser<UsageSignal>(() => new UsageSignal());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UsageSignal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.UsageReflection.Descriptor.MessageTypes[2]; }
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
      _hasBits0 = other._hasBits0;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      usageWithinTimeRange_ = other.usageWithinTimeRange_.Clone();
      commonUsageWithinTimeRange_ = other.commonUsageWithinTimeRange_.Clone();
      favoriteCount_ = other.favoriteCount_;
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
    /// Output only. BigQuery usage statistics over each of the predefined time
    /// ranges.
    ///
    /// Supported time ranges are `{"24H", "7D", "30D"}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Google.Cloud.DataCatalog.V1.UsageStats> UsageWithinTimeRange {
      get { return usageWithinTimeRange_; }
    }

    /// <summary>Field number for the "common_usage_within_time_range" field.</summary>
    public const int CommonUsageWithinTimeRangeFieldNumber = 3;
    private static readonly pbc::MapField<string, global::Google.Cloud.DataCatalog.V1.CommonUsageStats>.Codec _map_commonUsageWithinTimeRange_codec
        = new pbc::MapField<string, global::Google.Cloud.DataCatalog.V1.CommonUsageStats>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Google.Cloud.DataCatalog.V1.CommonUsageStats.Parser), 26);
    private readonly pbc::MapField<string, global::Google.Cloud.DataCatalog.V1.CommonUsageStats> commonUsageWithinTimeRange_ = new pbc::MapField<string, global::Google.Cloud.DataCatalog.V1.CommonUsageStats>();
    /// <summary>
    /// Common usage statistics over each of the predefined time ranges.
    ///
    /// Supported time ranges are `{"24H", "7D", "30D", "Lifetime"}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Google.Cloud.DataCatalog.V1.CommonUsageStats> CommonUsageWithinTimeRange {
      get { return commonUsageWithinTimeRange_; }
    }

    /// <summary>Field number for the "favorite_count" field.</summary>
    public const int FavoriteCountFieldNumber = 4;
    private readonly static long FavoriteCountDefaultValue = 0L;

    private long favoriteCount_;
    /// <summary>
    /// Favorite count in the source system.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long FavoriteCount {
      get { if ((_hasBits0 & 1) != 0) { return favoriteCount_; } else { return FavoriteCountDefaultValue; } }
      set {
        _hasBits0 |= 1;
        favoriteCount_ = value;
      }
    }
    /// <summary>Gets whether the "favorite_count" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasFavoriteCount {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "favorite_count" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFavoriteCount() {
      _hasBits0 &= ~1;
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
      if (!CommonUsageWithinTimeRange.Equals(other.CommonUsageWithinTimeRange)) return false;
      if (FavoriteCount != other.FavoriteCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      hash ^= UsageWithinTimeRange.GetHashCode();
      hash ^= CommonUsageWithinTimeRange.GetHashCode();
      if (HasFavoriteCount) hash ^= FavoriteCount.GetHashCode();
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
      commonUsageWithinTimeRange_.WriteTo(output, _map_commonUsageWithinTimeRange_codec);
      if (HasFavoriteCount) {
        output.WriteRawTag(32);
        output.WriteInt64(FavoriteCount);
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
      if (updateTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UpdateTime);
      }
      usageWithinTimeRange_.WriteTo(ref output, _map_usageWithinTimeRange_codec);
      commonUsageWithinTimeRange_.WriteTo(ref output, _map_commonUsageWithinTimeRange_codec);
      if (HasFavoriteCount) {
        output.WriteRawTag(32);
        output.WriteInt64(FavoriteCount);
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
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      size += usageWithinTimeRange_.CalculateSize(_map_usageWithinTimeRange_codec);
      size += commonUsageWithinTimeRange_.CalculateSize(_map_commonUsageWithinTimeRange_codec);
      if (HasFavoriteCount) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FavoriteCount);
      }
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
      usageWithinTimeRange_.MergeFrom(other.usageWithinTimeRange_);
      commonUsageWithinTimeRange_.MergeFrom(other.commonUsageWithinTimeRange_);
      if (other.HasFavoriteCount) {
        FavoriteCount = other.FavoriteCount;
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
          case 26: {
            commonUsageWithinTimeRange_.AddEntriesFrom(input, _map_commonUsageWithinTimeRange_codec);
            break;
          }
          case 32: {
            FavoriteCount = input.ReadInt64();
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
          case 26: {
            commonUsageWithinTimeRange_.AddEntriesFrom(ref input, _map_commonUsageWithinTimeRange_codec);
            break;
          }
          case 32: {
            FavoriteCount = input.ReadInt64();
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
