// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/talent/v4beta1/histogram.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Talent.V4Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/talent/v4beta1/histogram.proto</summary>
  public static partial class HistogramReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/talent/v4beta1/histogram.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HistogramReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citnb29nbGUvY2xvdWQvdGFsZW50L3Y0YmV0YTEvaGlzdG9ncmFtLnByb3Rv",
            "Ehtnb29nbGUuY2xvdWQudGFsZW50LnY0YmV0YTEiKQoOSGlzdG9ncmFtUXVl",
            "cnkSFwoPaGlzdG9ncmFtX3F1ZXJ5GAEgASgJIrYBChRIaXN0b2dyYW1RdWVy",
            "eVJlc3VsdBIXCg9oaXN0b2dyYW1fcXVlcnkYASABKAkSUwoJaGlzdG9ncmFt",
            "GAIgAygLMkAuZ29vZ2xlLmNsb3VkLnRhbGVudC52NGJldGExLkhpc3RvZ3Jh",
            "bVF1ZXJ5UmVzdWx0Lkhpc3RvZ3JhbUVudHJ5GjAKDkhpc3RvZ3JhbUVudHJ5",
            "EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoAzoCOAFCfAofY29tLmdvb2ds",
            "ZS5jbG91ZC50YWxlbnQudjRiZXRhMUIOSGlzdG9ncmFtUHJvdG9QAVpBZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC90YWxl",
            "bnQvdjRiZXRhMTt0YWxlbnSiAgNDVFNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.HistogramQuery), global::Google.Cloud.Talent.V4Beta1.HistogramQuery.Parser, new[]{ "HistogramQuery_" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.HistogramQueryResult), global::Google.Cloud.Talent.V4Beta1.HistogramQueryResult.Parser, new[]{ "HistogramQuery", "Histogram" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The histogram request.
  /// </summary>
  public sealed partial class HistogramQuery : pb::IMessage<HistogramQuery>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HistogramQuery> _parser = new pb::MessageParser<HistogramQuery>(() => new HistogramQuery());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HistogramQuery> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4Beta1.HistogramReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HistogramQuery() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HistogramQuery(HistogramQuery other) : this() {
      histogramQuery_ = other.histogramQuery_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HistogramQuery Clone() {
      return new HistogramQuery(this);
    }

    /// <summary>Field number for the "histogram_query" field.</summary>
    public const int HistogramQuery_FieldNumber = 1;
    private string histogramQuery_ = "";
    /// <summary>
    /// An expression specifies a histogram request against matching resources
    /// (for example, jobs, profiles) for searches.
    ///
    /// See [SearchJobsRequest.histogram_queries][google.cloud.talent.v4beta1.SearchJobsRequest.histogram_queries] and
    /// [SearchProfilesRequest.histogram_queries][google.cloud.talent.v4beta1.SearchProfilesRequest.histogram_queries] for details about syntax.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string HistogramQuery_ {
      get { return histogramQuery_; }
      set {
        histogramQuery_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HistogramQuery);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HistogramQuery other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HistogramQuery_ != other.HistogramQuery_) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HistogramQuery_.Length != 0) hash ^= HistogramQuery_.GetHashCode();
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
      if (HistogramQuery_.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(HistogramQuery_);
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
      if (HistogramQuery_.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(HistogramQuery_);
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
      if (HistogramQuery_.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HistogramQuery_);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HistogramQuery other) {
      if (other == null) {
        return;
      }
      if (other.HistogramQuery_.Length != 0) {
        HistogramQuery_ = other.HistogramQuery_;
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
            HistogramQuery_ = input.ReadString();
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
            HistogramQuery_ = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Histogram result that matches [HistogramQuery][google.cloud.talent.v4beta1.HistogramQuery] specified in searches.
  /// </summary>
  public sealed partial class HistogramQueryResult : pb::IMessage<HistogramQueryResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HistogramQueryResult> _parser = new pb::MessageParser<HistogramQueryResult>(() => new HistogramQueryResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HistogramQueryResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4Beta1.HistogramReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HistogramQueryResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HistogramQueryResult(HistogramQueryResult other) : this() {
      histogramQuery_ = other.histogramQuery_;
      histogram_ = other.histogram_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HistogramQueryResult Clone() {
      return new HistogramQueryResult(this);
    }

    /// <summary>Field number for the "histogram_query" field.</summary>
    public const int HistogramQueryFieldNumber = 1;
    private string histogramQuery_ = "";
    /// <summary>
    /// Requested histogram expression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string HistogramQuery {
      get { return histogramQuery_; }
      set {
        histogramQuery_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "histogram" field.</summary>
    public const int HistogramFieldNumber = 2;
    private static readonly pbc::MapField<string, long>.Codec _map_histogram_codec
        = new pbc::MapField<string, long>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForInt64(16, 0L), 18);
    private readonly pbc::MapField<string, long> histogram_ = new pbc::MapField<string, long>();
    /// <summary>
    /// A map from the values of the facet associated with distinct values to the
    /// number of matching entries with corresponding value.
    ///
    /// The key format is:
    ///
    /// * (for string histogram) string values stored in the field.
    /// * (for named numeric bucket) name specified in `bucket()` function, like
    ///   for `bucket(0, MAX, "non-negative")`, the key will be `non-negative`.
    /// * (for anonymous numeric bucket) range formatted as `&lt;low>-&lt;high>`, for
    ///   example, `0-1000`, `MIN-0`, and `0-MAX`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, long> Histogram {
      get { return histogram_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HistogramQueryResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HistogramQueryResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HistogramQuery != other.HistogramQuery) return false;
      if (!Histogram.Equals(other.Histogram)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HistogramQuery.Length != 0) hash ^= HistogramQuery.GetHashCode();
      hash ^= Histogram.GetHashCode();
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
      if (HistogramQuery.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(HistogramQuery);
      }
      histogram_.WriteTo(output, _map_histogram_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HistogramQuery.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(HistogramQuery);
      }
      histogram_.WriteTo(ref output, _map_histogram_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HistogramQuery.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HistogramQuery);
      }
      size += histogram_.CalculateSize(_map_histogram_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HistogramQueryResult other) {
      if (other == null) {
        return;
      }
      if (other.HistogramQuery.Length != 0) {
        HistogramQuery = other.HistogramQuery;
      }
      histogram_.Add(other.histogram_);
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
            HistogramQuery = input.ReadString();
            break;
          }
          case 18: {
            histogram_.AddEntriesFrom(input, _map_histogram_codec);
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
            HistogramQuery = input.ReadString();
            break;
          }
          case 18: {
            histogram_.AddEntriesFrom(ref input, _map_histogram_codec);
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
