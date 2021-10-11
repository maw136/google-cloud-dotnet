// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/notebooks/v1/schedule.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Notebooks.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/notebooks/v1/schedule.proto</summary>
  public static partial class ScheduleReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/notebooks/v1/schedule.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScheduleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvbm90ZWJvb2tzL3YxL3NjaGVkdWxlLnByb3RvEhln",
            "b29nbGUuY2xvdWQubm90ZWJvb2tzLnYxGh9nb29nbGUvYXBpL2ZpZWxkX2Jl",
            "aGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGilnb29n",
            "bGUvY2xvdWQvbm90ZWJvb2tzL3YxL2V4ZWN1dGlvbi5wcm90bxofZ29vZ2xl",
            "L3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byKMBQoIU2NoZWR1bGUSEQoEbmFt",
            "ZRgBIAEoCUID4EEDEhkKDGRpc3BsYXlfbmFtZRgCIAEoCUID4EEDEhMKC2Rl",
            "c2NyaXB0aW9uGAMgASgJEjgKBXN0YXRlGAQgASgOMikuZ29vZ2xlLmNsb3Vk",
            "Lm5vdGVib29rcy52MS5TY2hlZHVsZS5TdGF0ZRIVCg1jcm9uX3NjaGVkdWxl",
            "GAUgASgJEhEKCXRpbWVfem9uZRgGIAEoCRI0CgtjcmVhdGVfdGltZRgHIAEo",
            "CzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCA+BBAxI0Cgt1cGRhdGVf",
            "dGltZRgIIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCA+BBAxJI",
            "ChJleGVjdXRpb25fdGVtcGxhdGUYCSABKAsyLC5nb29nbGUuY2xvdWQubm90",
            "ZWJvb2tzLnYxLkV4ZWN1dGlvblRlbXBsYXRlEkQKEXJlY2VudF9leGVjdXRp",
            "b25zGAogAygLMiQuZ29vZ2xlLmNsb3VkLm5vdGVib29rcy52MS5FeGVjdXRp",
            "b25CA+BBAyJ4CgVTdGF0ZRIVChFTVEFURV9VTlNQRUNJRklFRBAAEgsKB0VO",
            "QUJMRUQQARIKCgZQQVVTRUQQAhIMCghESVNBQkxFRBADEhEKDVVQREFURV9G",
            "QUlMRUQQBBIQCgxJTklUSUFMSVpJTkcQBRIMCghERUxFVElORxAGOmPqQWAK",
            "IW5vdGVib29rcy5nb29nbGVhcGlzLmNvbS9TY2hlZHVsZRI7cHJvamVjdHMv",
            "e3Byb2plY3R9L2xvY2F0aW9uL3tsb2NhdGlvbn0vc2NoZWR1bGVzL3tzY2hl",
            "ZHVsZX1CdAodY29tLmdvb2dsZS5jbG91ZC5ub3RlYm9va3MudjFCDVNjaGVk",
            "dWxlUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9jbG91ZC9ub3RlYm9va3MvdjE7bm90ZWJvb2tzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Notebooks.V1.ExecutionReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Notebooks.V1.Schedule), global::Google.Cloud.Notebooks.V1.Schedule.Parser, new[]{ "Name", "DisplayName", "Description", "State", "CronSchedule", "TimeZone", "CreateTime", "UpdateTime", "ExecutionTemplate", "RecentExecutions" }, null, new[]{ typeof(global::Google.Cloud.Notebooks.V1.Schedule.Types.State) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The definition of a schedule.
  /// </summary>
  public sealed partial class Schedule : pb::IMessage<Schedule>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Schedule> _parser = new pb::MessageParser<Schedule>(() => new Schedule());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Schedule> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Notebooks.V1.ScheduleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Schedule() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Schedule(Schedule other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      state_ = other.state_;
      cronSchedule_ = other.cronSchedule_;
      timeZone_ = other.timeZone_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      executionTemplate_ = other.executionTemplate_ != null ? other.executionTemplate_.Clone() : null;
      recentExecutions_ = other.recentExecutions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Schedule Clone() {
      return new Schedule(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. The name of this schedule. Format:
    /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Output only. Display name used for UI purposes.
    /// Name can only contain alphanumeric characters, hyphens '-',
    /// and underscores '_'.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    /// A brief description of this environment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private global::Google.Cloud.Notebooks.V1.Schedule.Types.State state_ = global::Google.Cloud.Notebooks.V1.Schedule.Types.State.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Notebooks.V1.Schedule.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "cron_schedule" field.</summary>
    public const int CronScheduleFieldNumber = 5;
    private string cronSchedule_ = "";
    /// <summary>
    /// Cron-tab formatted schedule by which the job will execute
    /// Format: minute, hour, day of month, month, day of week
    /// e.g. 0 0 * * WED = every Wednesday
    /// More examples: https://crontab.guru/examples.html
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CronSchedule {
      get { return cronSchedule_; }
      set {
        cronSchedule_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time_zone" field.</summary>
    public const int TimeZoneFieldNumber = 6;
    private string timeZone_ = "";
    /// <summary>
    /// Timezone on which the cron_schedule.
    /// The value of this field must be a time zone name from the tz database.
    /// TZ Database: https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
    ///
    /// Note that some time zones include a provision for daylight savings time.
    /// The rules for daylight saving time are determined by the chosen tz.
    /// For UTC use the string "utc". If a time zone is not specified,
    /// the default will be in UTC (also known as GMT).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TimeZone {
      get { return timeZone_; }
      set {
        timeZone_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Time the schedule was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 8;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Time the schedule was last updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "execution_template" field.</summary>
    public const int ExecutionTemplateFieldNumber = 9;
    private global::Google.Cloud.Notebooks.V1.ExecutionTemplate executionTemplate_;
    /// <summary>
    /// Notebook Execution Template corresponding to this schedule.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Notebooks.V1.ExecutionTemplate ExecutionTemplate {
      get { return executionTemplate_; }
      set {
        executionTemplate_ = value;
      }
    }

    /// <summary>Field number for the "recent_executions" field.</summary>
    public const int RecentExecutionsFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Google.Cloud.Notebooks.V1.Execution> _repeated_recentExecutions_codec
        = pb::FieldCodec.ForMessage(82, global::Google.Cloud.Notebooks.V1.Execution.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Notebooks.V1.Execution> recentExecutions_ = new pbc::RepeatedField<global::Google.Cloud.Notebooks.V1.Execution>();
    /// <summary>
    /// Output only. The most recent execution names triggered from this schedule and their
    /// corresponding states.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Notebooks.V1.Execution> RecentExecutions {
      get { return recentExecutions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Schedule);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Schedule other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Description != other.Description) return false;
      if (State != other.State) return false;
      if (CronSchedule != other.CronSchedule) return false;
      if (TimeZone != other.TimeZone) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!object.Equals(ExecutionTemplate, other.ExecutionTemplate)) return false;
      if(!recentExecutions_.Equals(other.recentExecutions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (State != global::Google.Cloud.Notebooks.V1.Schedule.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (CronSchedule.Length != 0) hash ^= CronSchedule.GetHashCode();
      if (TimeZone.Length != 0) hash ^= TimeZone.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (executionTemplate_ != null) hash ^= ExecutionTemplate.GetHashCode();
      hash ^= recentExecutions_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (State != global::Google.Cloud.Notebooks.V1.Schedule.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      if (CronSchedule.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CronSchedule);
      }
      if (TimeZone.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TimeZone);
      }
      if (createTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(UpdateTime);
      }
      if (executionTemplate_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ExecutionTemplate);
      }
      recentExecutions_.WriteTo(output, _repeated_recentExecutions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (State != global::Google.Cloud.Notebooks.V1.Schedule.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      if (CronSchedule.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CronSchedule);
      }
      if (TimeZone.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TimeZone);
      }
      if (createTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(UpdateTime);
      }
      if (executionTemplate_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ExecutionTemplate);
      }
      recentExecutions_.WriteTo(ref output, _repeated_recentExecutions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (State != global::Google.Cloud.Notebooks.V1.Schedule.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (CronSchedule.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CronSchedule);
      }
      if (TimeZone.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeZone);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (executionTemplate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExecutionTemplate);
      }
      size += recentExecutions_.CalculateSize(_repeated_recentExecutions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Schedule other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.State != global::Google.Cloud.Notebooks.V1.Schedule.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.CronSchedule.Length != 0) {
        CronSchedule = other.CronSchedule;
      }
      if (other.TimeZone.Length != 0) {
        TimeZone = other.TimeZone;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.executionTemplate_ != null) {
        if (executionTemplate_ == null) {
          ExecutionTemplate = new global::Google.Cloud.Notebooks.V1.ExecutionTemplate();
        }
        ExecutionTemplate.MergeFrom(other.ExecutionTemplate);
      }
      recentExecutions_.Add(other.recentExecutions_);
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 32: {
            State = (global::Google.Cloud.Notebooks.V1.Schedule.Types.State) input.ReadEnum();
            break;
          }
          case 42: {
            CronSchedule = input.ReadString();
            break;
          }
          case 50: {
            TimeZone = input.ReadString();
            break;
          }
          case 58: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 66: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 74: {
            if (executionTemplate_ == null) {
              ExecutionTemplate = new global::Google.Cloud.Notebooks.V1.ExecutionTemplate();
            }
            input.ReadMessage(ExecutionTemplate);
            break;
          }
          case 82: {
            recentExecutions_.AddEntriesFrom(input, _repeated_recentExecutions_codec);
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 32: {
            State = (global::Google.Cloud.Notebooks.V1.Schedule.Types.State) input.ReadEnum();
            break;
          }
          case 42: {
            CronSchedule = input.ReadString();
            break;
          }
          case 50: {
            TimeZone = input.ReadString();
            break;
          }
          case 58: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 66: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 74: {
            if (executionTemplate_ == null) {
              ExecutionTemplate = new global::Google.Cloud.Notebooks.V1.ExecutionTemplate();
            }
            input.ReadMessage(ExecutionTemplate);
            break;
          }
          case 82: {
            recentExecutions_.AddEntriesFrom(ref input, _repeated_recentExecutions_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Schedule message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// State of the job.
      /// </summary>
      public enum State {
        /// <summary>
        /// Unspecified state.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The job is executing normally.
        /// </summary>
        [pbr::OriginalName("ENABLED")] Enabled = 1,
        /// <summary>
        /// The job is paused by the user. It will not execute. A user can
        /// intentionally pause the job using
        /// [PauseJobRequest][].
        /// </summary>
        [pbr::OriginalName("PAUSED")] Paused = 2,
        /// <summary>
        /// The job is disabled by the system due to error. The user
        /// cannot directly set a job to be disabled.
        /// </summary>
        [pbr::OriginalName("DISABLED")] Disabled = 3,
        /// <summary>
        /// The job state resulting from a failed [CloudScheduler.UpdateJob][]
        /// operation. To recover a job from this state, retry
        /// [CloudScheduler.UpdateJob][] until a successful response is received.
        /// </summary>
        [pbr::OriginalName("UPDATE_FAILED")] UpdateFailed = 4,
        /// <summary>
        /// The schedule resource is being created.
        /// </summary>
        [pbr::OriginalName("INITIALIZING")] Initializing = 5,
        /// <summary>
        /// The schedule resource is being deleted.
        /// </summary>
        [pbr::OriginalName("DELETING")] Deleting = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
