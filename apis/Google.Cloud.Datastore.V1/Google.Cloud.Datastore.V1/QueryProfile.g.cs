// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/datastore/v1/query_profile.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Datastore.V1 {

  /// <summary>Holder for reflection information generated from google/datastore/v1/query_profile.proto</summary>
  public static partial class QueryProfileReflection {

    #region Descriptor
    /// <summary>File descriptor for google/datastore/v1/query_profile.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryProfileReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidnb29nbGUvZGF0YXN0b3JlL3YxL3F1ZXJ5X3Byb2ZpbGUucHJvdG8SE2dv",
            "b2dsZS5kYXRhc3RvcmUudjEaHGdvb2dsZS9wcm90b2J1Zi9zdHJ1Y3QucHJv",
            "dG8iNwoJUXVlcnlQbGFuEioKCXBsYW5faW5mbxgBIAEoCzIXLmdvb2dsZS5w",
            "cm90b2J1Zi5TdHJ1Y3QicgoOUmVzdWx0U2V0U3RhdHMSMgoKcXVlcnlfcGxh",
            "bhgBIAEoCzIeLmdvb2dsZS5kYXRhc3RvcmUudjEuUXVlcnlQbGFuEiwKC3F1",
            "ZXJ5X3N0YXRzGAIgASgLMhcuZ29vZ2xlLnByb3RvYnVmLlN0cnVjdCouCglR",
            "dWVyeU1vZGUSCgoGTk9STUFMEAASCAoEUExBThABEgsKB1BST0ZJTEUQAkLD",
            "AQoXY29tLmdvb2dsZS5kYXRhc3RvcmUudjFCEVF1ZXJ5UHJvZmlsZVByb3Rv",
            "UAFaPGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvZGF0",
            "YXN0b3JlL3YxO2RhdGFzdG9yZaoCGUdvb2dsZS5DbG91ZC5EYXRhc3RvcmUu",
            "VjHKAhlHb29nbGVcQ2xvdWRcRGF0YXN0b3JlXFYx6gIcR29vZ2xlOjpDbG91",
            "ZDo6RGF0YXN0b3JlOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.Datastore.V1.QueryMode), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Datastore.V1.QueryPlan), global::Google.Cloud.Datastore.V1.QueryPlan.Parser, new[]{ "PlanInfo" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Datastore.V1.ResultSetStats), global::Google.Cloud.Datastore.V1.ResultSetStats.Parser, new[]{ "QueryPlan", "QueryStats" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The mode in which the query request must be processed.
  /// </summary>
  public enum QueryMode {
    /// <summary>
    /// The default mode. Only the query results are returned.
    /// </summary>
    [pbr::OriginalName("NORMAL")] Normal = 0,
    /// <summary>
    /// This mode returns only the query plan, without any results or execution
    /// statistics information.
    /// </summary>
    [pbr::OriginalName("PLAN")] Plan = 1,
    /// <summary>
    /// This mode returns both the query plan and the execution statistics along
    /// with the results.
    /// </summary>
    [pbr::OriginalName("PROFILE")] Profile = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Plan for the query.
  /// </summary>
  public sealed partial class QueryPlan : pb::IMessage<QueryPlan>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryPlan> _parser = new pb::MessageParser<QueryPlan>(() => new QueryPlan());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryPlan> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Datastore.V1.QueryProfileReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryPlan() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryPlan(QueryPlan other) : this() {
      planInfo_ = other.planInfo_ != null ? other.planInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryPlan Clone() {
      return new QueryPlan(this);
    }

    /// <summary>Field number for the "plan_info" field.</summary>
    public const int PlanInfoFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Struct planInfo_;
    /// <summary>
    /// Planning phase information for the query. It will include:
    ///
    /// {
    ///   "indexes_used": [
    ///     {"query_scope": "Collection", "properties": "(foo ASC, __name__ ASC)"},
    ///     {"query_scope": "Collection", "properties": "(bar ASC, __name__ ASC)"}
    ///   ]
    /// }
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Struct PlanInfo {
      get { return planInfo_; }
      set {
        planInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryPlan);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryPlan other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PlanInfo, other.PlanInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (planInfo_ != null) hash ^= PlanInfo.GetHashCode();
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
      if (planInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PlanInfo);
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
      if (planInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PlanInfo);
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
      if (planInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlanInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryPlan other) {
      if (other == null) {
        return;
      }
      if (other.planInfo_ != null) {
        if (planInfo_ == null) {
          PlanInfo = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        PlanInfo.MergeFrom(other.PlanInfo);
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
            if (planInfo_ == null) {
              PlanInfo = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(PlanInfo);
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
            if (planInfo_ == null) {
              PlanInfo = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(PlanInfo);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Planning and execution statistics for the query.
  /// </summary>
  public sealed partial class ResultSetStats : pb::IMessage<ResultSetStats>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResultSetStats> _parser = new pb::MessageParser<ResultSetStats>(() => new ResultSetStats());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResultSetStats> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Datastore.V1.QueryProfileReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResultSetStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResultSetStats(ResultSetStats other) : this() {
      queryPlan_ = other.queryPlan_ != null ? other.queryPlan_.Clone() : null;
      queryStats_ = other.queryStats_ != null ? other.queryStats_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResultSetStats Clone() {
      return new ResultSetStats(this);
    }

    /// <summary>Field number for the "query_plan" field.</summary>
    public const int QueryPlanFieldNumber = 1;
    private global::Google.Cloud.Datastore.V1.QueryPlan queryPlan_;
    /// <summary>
    /// Plan for the query.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Datastore.V1.QueryPlan QueryPlan {
      get { return queryPlan_; }
      set {
        queryPlan_ = value;
      }
    }

    /// <summary>Field number for the "query_stats" field.</summary>
    public const int QueryStatsFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Struct queryStats_;
    /// <summary>
    /// Aggregated statistics from the execution of the query.
    ///
    /// This will only be present when the request specifies `PROFILE` mode.
    /// For example, a query will return the statistics including:
    ///
    /// {
    ///   "results_returned": "20",
    ///   "documents_scanned": "20",
    ///   "indexes_entries_scanned": "10050",
    ///   "total_execution_time": "100.7 msecs"
    /// }
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Struct QueryStats {
      get { return queryStats_; }
      set {
        queryStats_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResultSetStats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResultSetStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(QueryPlan, other.QueryPlan)) return false;
      if (!object.Equals(QueryStats, other.QueryStats)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (queryPlan_ != null) hash ^= QueryPlan.GetHashCode();
      if (queryStats_ != null) hash ^= QueryStats.GetHashCode();
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
      if (queryPlan_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(QueryPlan);
      }
      if (queryStats_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(QueryStats);
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
      if (queryPlan_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(QueryPlan);
      }
      if (queryStats_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(QueryStats);
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
      if (queryPlan_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(QueryPlan);
      }
      if (queryStats_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(QueryStats);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResultSetStats other) {
      if (other == null) {
        return;
      }
      if (other.queryPlan_ != null) {
        if (queryPlan_ == null) {
          QueryPlan = new global::Google.Cloud.Datastore.V1.QueryPlan();
        }
        QueryPlan.MergeFrom(other.QueryPlan);
      }
      if (other.queryStats_ != null) {
        if (queryStats_ == null) {
          QueryStats = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        QueryStats.MergeFrom(other.QueryStats);
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
            if (queryPlan_ == null) {
              QueryPlan = new global::Google.Cloud.Datastore.V1.QueryPlan();
            }
            input.ReadMessage(QueryPlan);
            break;
          }
          case 18: {
            if (queryStats_ == null) {
              QueryStats = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(QueryStats);
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
            if (queryPlan_ == null) {
              QueryPlan = new global::Google.Cloud.Datastore.V1.QueryPlan();
            }
            input.ReadMessage(QueryPlan);
            break;
          }
          case 18: {
            if (queryStats_ == null) {
              QueryStats = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(QueryStats);
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
