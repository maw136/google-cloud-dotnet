// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/hyperparameter_tuning_job.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/hyperparameter_tuning_job.proto</summary>
  public static partial class HyperparameterTuningJobReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/hyperparameter_tuning_job.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HyperparameterTuningJobReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9oeXBlcnBhcmFtZXRlcl90",
            "dW5pbmdfam9iLnByb3RvEhpnb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MRof",
            "Z29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9y",
            "ZXNvdXJjZS5wcm90bxorZ29vZ2xlL2Nsb3VkL2FpcGxhdGZvcm0vdjEvY3Vz",
            "dG9tX2pvYi5wcm90bxowZ29vZ2xlL2Nsb3VkL2FpcGxhdGZvcm0vdjEvZW5j",
            "cnlwdGlvbl9zcGVjLnByb3RvGipnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92",
            "MS9qb2Jfc3RhdGUucHJvdG8aJmdvb2dsZS9jbG91ZC9haXBsYXRmb3JtL3Yx",
            "L3N0dWR5LnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3Rv",
            "Ghdnb29nbGUvcnBjL3N0YXR1cy5wcm90byL7BwoXSHlwZXJwYXJhbWV0ZXJU",
            "dW5pbmdKb2ISEQoEbmFtZRgBIAEoCUID4EEDEhkKDGRpc3BsYXlfbmFtZRgC",
            "IAEoCUID4EECEj4KCnN0dWR5X3NwZWMYBCABKAsyJS5nb29nbGUuY2xvdWQu",
            "YWlwbGF0Zm9ybS52MS5TdHVkeVNwZWNCA+BBAhIcCg9tYXhfdHJpYWxfY291",
            "bnQYBSABKAVCA+BBAhIhChRwYXJhbGxlbF90cmlhbF9jb3VudBgGIAEoBUID",
            "4EECEh4KFm1heF9mYWlsZWRfdHJpYWxfY291bnQYByABKAUSRgoOdHJpYWxf",
            "am9iX3NwZWMYCCABKAsyKS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5D",
            "dXN0b21Kb2JTcGVjQgPgQQISNgoGdHJpYWxzGAkgAygLMiEuZ29vZ2xlLmNs",
            "b3VkLmFpcGxhdGZvcm0udjEuVHJpYWxCA+BBAxI4CgVzdGF0ZRgKIAEoDjIk",
            "Lmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxLkpvYlN0YXRlQgPgQQMSNAoL",
            "Y3JlYXRlX3RpbWUYCyABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "QgPgQQMSMwoKc3RhcnRfdGltZRgMIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5U",
            "aW1lc3RhbXBCA+BBAxIxCghlbmRfdGltZRgNIAEoCzIaLmdvb2dsZS5wcm90",
            "b2J1Zi5UaW1lc3RhbXBCA+BBAxI0Cgt1cGRhdGVfdGltZRgOIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCA+BBAxImCgVlcnJvchgPIAEoCzIS",
            "Lmdvb2dsZS5ycGMuU3RhdHVzQgPgQQMSTwoGbGFiZWxzGBAgAygLMj8uZ29v",
            "Z2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuSHlwZXJwYXJhbWV0ZXJUdW5pbmdK",
            "b2IuTGFiZWxzRW50cnkSQwoPZW5jcnlwdGlvbl9zcGVjGBEgASgLMiouZ29v",
            "Z2xlLmNsb3VkLmFpcGxhdGZvcm0udjEuRW5jcnlwdGlvblNwZWMaLQoLTGFi",
            "ZWxzRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ATqVAepB",
            "kQEKMWFpcGxhdGZvcm0uZ29vZ2xlYXBpcy5jb20vSHlwZXJwYXJhbWV0ZXJU",
            "dW5pbmdKb2ISXHByb2plY3RzL3twcm9qZWN0fS9sb2NhdGlvbnMve2xvY2F0",
            "aW9ufS9oeXBlcnBhcmFtZXRlclR1bmluZ0pvYnMve2h5cGVycGFyYW1ldGVy",
            "X3R1bmluZ19qb2J9QuABCh5jb20uZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0u",
            "djFCHEh5cGVycGFyYW1ldGVyVHVuaW5nSm9iUHJvdG9QAVpEZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9haXBsYXRmb3Jt",
            "L3YxO2FpcGxhdGZvcm2qAhpHb29nbGUuQ2xvdWQuQUlQbGF0Zm9ybS5WMcoC",
            "Gkdvb2dsZVxDbG91ZFxBSVBsYXRmb3JtXFYx6gIdR29vZ2xlOjpDbG91ZDo6",
            "QUlQbGF0Zm9ybTo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.CustomJobReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.EncryptionSpecReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.JobStateReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.StudyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.HyperparameterTuningJob), global::Google.Cloud.AIPlatform.V1.HyperparameterTuningJob.Parser, new[]{ "Name", "DisplayName", "StudySpec", "MaxTrialCount", "ParallelTrialCount", "MaxFailedTrialCount", "TrialJobSpec", "Trials", "State", "CreateTime", "StartTime", "EndTime", "UpdateTime", "Error", "Labels", "EncryptionSpec" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a HyperparameterTuningJob. A HyperparameterTuningJob
  /// has a Study specification and multiple CustomJobs with identical
  /// CustomJob specification.
  /// </summary>
  public sealed partial class HyperparameterTuningJob : pb::IMessage<HyperparameterTuningJob>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HyperparameterTuningJob> _parser = new pb::MessageParser<HyperparameterTuningJob>(() => new HyperparameterTuningJob());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HyperparameterTuningJob> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.HyperparameterTuningJobReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HyperparameterTuningJob() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HyperparameterTuningJob(HyperparameterTuningJob other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      studySpec_ = other.studySpec_ != null ? other.studySpec_.Clone() : null;
      maxTrialCount_ = other.maxTrialCount_;
      parallelTrialCount_ = other.parallelTrialCount_;
      maxFailedTrialCount_ = other.maxFailedTrialCount_;
      trialJobSpec_ = other.trialJobSpec_ != null ? other.trialJobSpec_.Clone() : null;
      trials_ = other.trials_.Clone();
      state_ = other.state_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      startTime_ = other.startTime_ != null ? other.startTime_.Clone() : null;
      endTime_ = other.endTime_ != null ? other.endTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      error_ = other.error_ != null ? other.error_.Clone() : null;
      labels_ = other.labels_.Clone();
      encryptionSpec_ = other.encryptionSpec_ != null ? other.encryptionSpec_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HyperparameterTuningJob Clone() {
      return new HyperparameterTuningJob(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Resource name of the HyperparameterTuningJob.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
    /// Required. The display name of the HyperparameterTuningJob.
    /// The name can be up to 128 characters long and can be consist of any UTF-8
    /// characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "study_spec" field.</summary>
    public const int StudySpecFieldNumber = 4;
    private global::Google.Cloud.AIPlatform.V1.StudySpec studySpec_;
    /// <summary>
    /// Required. Study configuration of the HyperparameterTuningJob.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.StudySpec StudySpec {
      get { return studySpec_; }
      set {
        studySpec_ = value;
      }
    }

    /// <summary>Field number for the "max_trial_count" field.</summary>
    public const int MaxTrialCountFieldNumber = 5;
    private int maxTrialCount_;
    /// <summary>
    /// Required. The desired total number of Trials.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxTrialCount {
      get { return maxTrialCount_; }
      set {
        maxTrialCount_ = value;
      }
    }

    /// <summary>Field number for the "parallel_trial_count" field.</summary>
    public const int ParallelTrialCountFieldNumber = 6;
    private int parallelTrialCount_;
    /// <summary>
    /// Required. The desired number of Trials to run in parallel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ParallelTrialCount {
      get { return parallelTrialCount_; }
      set {
        parallelTrialCount_ = value;
      }
    }

    /// <summary>Field number for the "max_failed_trial_count" field.</summary>
    public const int MaxFailedTrialCountFieldNumber = 7;
    private int maxFailedTrialCount_;
    /// <summary>
    /// The number of failed Trials that need to be seen before failing
    /// the HyperparameterTuningJob.
    ///
    /// If set to 0, Vertex AI decides how many Trials must fail
    /// before the whole job fails.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxFailedTrialCount {
      get { return maxFailedTrialCount_; }
      set {
        maxFailedTrialCount_ = value;
      }
    }

    /// <summary>Field number for the "trial_job_spec" field.</summary>
    public const int TrialJobSpecFieldNumber = 8;
    private global::Google.Cloud.AIPlatform.V1.CustomJobSpec trialJobSpec_;
    /// <summary>
    /// Required. The spec of a trial job. The same spec applies to the CustomJobs created
    /// in all the trials.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.CustomJobSpec TrialJobSpec {
      get { return trialJobSpec_; }
      set {
        trialJobSpec_ = value;
      }
    }

    /// <summary>Field number for the "trials" field.</summary>
    public const int TrialsFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Google.Cloud.AIPlatform.V1.Trial> _repeated_trials_codec
        = pb::FieldCodec.ForMessage(74, global::Google.Cloud.AIPlatform.V1.Trial.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.Trial> trials_ = new pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.Trial>();
    /// <summary>
    /// Output only. Trials of the HyperparameterTuningJob.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.Trial> Trials {
      get { return trials_; }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 10;
    private global::Google.Cloud.AIPlatform.V1.JobState state_ = global::Google.Cloud.AIPlatform.V1.JobState.Unspecified;
    /// <summary>
    /// Output only. The detailed state of the job.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.JobState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 11;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Time when the HyperparameterTuningJob was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 12;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startTime_;
    /// <summary>
    /// Output only. Time when the HyperparameterTuningJob for the first time entered the
    /// `JOB_STATE_RUNNING` state.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 13;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    /// Output only. Time when the HyperparameterTuningJob entered any of the following states:
    /// `JOB_STATE_SUCCEEDED`, `JOB_STATE_FAILED`, `JOB_STATE_CANCELLED`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 14;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Time when the HyperparameterTuningJob was most recently updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 15;
    private global::Google.Rpc.Status error_;
    /// <summary>
    /// Output only. Only populated when job's state is JOB_STATE_FAILED or
    /// JOB_STATE_CANCELLED.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Rpc.Status Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 16;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 130);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// The labels with user-defined metadata to organize HyperparameterTuningJobs.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    ///
    /// See https://goo.gl/xmQnxf for more information and examples of labels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "encryption_spec" field.</summary>
    public const int EncryptionSpecFieldNumber = 17;
    private global::Google.Cloud.AIPlatform.V1.EncryptionSpec encryptionSpec_;
    /// <summary>
    /// Customer-managed encryption key options for a HyperparameterTuningJob.
    /// If this is set, then all resources created by the HyperparameterTuningJob
    /// will be encrypted with the provided encryption key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1.EncryptionSpec EncryptionSpec {
      get { return encryptionSpec_; }
      set {
        encryptionSpec_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HyperparameterTuningJob);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HyperparameterTuningJob other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (!object.Equals(StudySpec, other.StudySpec)) return false;
      if (MaxTrialCount != other.MaxTrialCount) return false;
      if (ParallelTrialCount != other.ParallelTrialCount) return false;
      if (MaxFailedTrialCount != other.MaxFailedTrialCount) return false;
      if (!object.Equals(TrialJobSpec, other.TrialJobSpec)) return false;
      if(!trials_.Equals(other.trials_)) return false;
      if (State != other.State) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(StartTime, other.StartTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!object.Equals(Error, other.Error)) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (!object.Equals(EncryptionSpec, other.EncryptionSpec)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (studySpec_ != null) hash ^= StudySpec.GetHashCode();
      if (MaxTrialCount != 0) hash ^= MaxTrialCount.GetHashCode();
      if (ParallelTrialCount != 0) hash ^= ParallelTrialCount.GetHashCode();
      if (MaxFailedTrialCount != 0) hash ^= MaxFailedTrialCount.GetHashCode();
      if (trialJobSpec_ != null) hash ^= TrialJobSpec.GetHashCode();
      hash ^= trials_.GetHashCode();
      if (State != global::Google.Cloud.AIPlatform.V1.JobState.Unspecified) hash ^= State.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (startTime_ != null) hash ^= StartTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (error_ != null) hash ^= Error.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (encryptionSpec_ != null) hash ^= EncryptionSpec.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (studySpec_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(StudySpec);
      }
      if (MaxTrialCount != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MaxTrialCount);
      }
      if (ParallelTrialCount != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(ParallelTrialCount);
      }
      if (MaxFailedTrialCount != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(MaxFailedTrialCount);
      }
      if (trialJobSpec_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(TrialJobSpec);
      }
      trials_.WriteTo(output, _repeated_trials_codec);
      if (State != global::Google.Cloud.AIPlatform.V1.JobState.Unspecified) {
        output.WriteRawTag(80);
        output.WriteEnum((int) State);
      }
      if (createTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CreateTime);
      }
      if (startTime_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(EndTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(UpdateTime);
      }
      if (error_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Error);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (encryptionSpec_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(EncryptionSpec);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (studySpec_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(StudySpec);
      }
      if (MaxTrialCount != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MaxTrialCount);
      }
      if (ParallelTrialCount != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(ParallelTrialCount);
      }
      if (MaxFailedTrialCount != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(MaxFailedTrialCount);
      }
      if (trialJobSpec_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(TrialJobSpec);
      }
      trials_.WriteTo(ref output, _repeated_trials_codec);
      if (State != global::Google.Cloud.AIPlatform.V1.JobState.Unspecified) {
        output.WriteRawTag(80);
        output.WriteEnum((int) State);
      }
      if (createTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CreateTime);
      }
      if (startTime_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(EndTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(UpdateTime);
      }
      if (error_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Error);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (encryptionSpec_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(EncryptionSpec);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (studySpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StudySpec);
      }
      if (MaxTrialCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxTrialCount);
      }
      if (ParallelTrialCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ParallelTrialCount);
      }
      if (MaxFailedTrialCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxFailedTrialCount);
      }
      if (trialJobSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TrialJobSpec);
      }
      size += trials_.CalculateSize(_repeated_trials_codec);
      if (State != global::Google.Cloud.AIPlatform.V1.JobState.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (startTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (error_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Error);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (encryptionSpec_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(EncryptionSpec);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HyperparameterTuningJob other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.studySpec_ != null) {
        if (studySpec_ == null) {
          StudySpec = new global::Google.Cloud.AIPlatform.V1.StudySpec();
        }
        StudySpec.MergeFrom(other.StudySpec);
      }
      if (other.MaxTrialCount != 0) {
        MaxTrialCount = other.MaxTrialCount;
      }
      if (other.ParallelTrialCount != 0) {
        ParallelTrialCount = other.ParallelTrialCount;
      }
      if (other.MaxFailedTrialCount != 0) {
        MaxFailedTrialCount = other.MaxFailedTrialCount;
      }
      if (other.trialJobSpec_ != null) {
        if (trialJobSpec_ == null) {
          TrialJobSpec = new global::Google.Cloud.AIPlatform.V1.CustomJobSpec();
        }
        TrialJobSpec.MergeFrom(other.TrialJobSpec);
      }
      trials_.Add(other.trials_);
      if (other.State != global::Google.Cloud.AIPlatform.V1.JobState.Unspecified) {
        State = other.State;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.startTime_ != null) {
        if (startTime_ == null) {
          StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartTime.MergeFrom(other.StartTime);
      }
      if (other.endTime_ != null) {
        if (endTime_ == null) {
          EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndTime.MergeFrom(other.EndTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.error_ != null) {
        if (error_ == null) {
          Error = new global::Google.Rpc.Status();
        }
        Error.MergeFrom(other.Error);
      }
      labels_.Add(other.labels_);
      if (other.encryptionSpec_ != null) {
        if (encryptionSpec_ == null) {
          EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
        }
        EncryptionSpec.MergeFrom(other.EncryptionSpec);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 34: {
            if (studySpec_ == null) {
              StudySpec = new global::Google.Cloud.AIPlatform.V1.StudySpec();
            }
            input.ReadMessage(StudySpec);
            break;
          }
          case 40: {
            MaxTrialCount = input.ReadInt32();
            break;
          }
          case 48: {
            ParallelTrialCount = input.ReadInt32();
            break;
          }
          case 56: {
            MaxFailedTrialCount = input.ReadInt32();
            break;
          }
          case 66: {
            if (trialJobSpec_ == null) {
              TrialJobSpec = new global::Google.Cloud.AIPlatform.V1.CustomJobSpec();
            }
            input.ReadMessage(TrialJobSpec);
            break;
          }
          case 74: {
            trials_.AddEntriesFrom(input, _repeated_trials_codec);
            break;
          }
          case 80: {
            State = (global::Google.Cloud.AIPlatform.V1.JobState) input.ReadEnum();
            break;
          }
          case 90: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 98: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 106: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 114: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 122: {
            if (error_ == null) {
              Error = new global::Google.Rpc.Status();
            }
            input.ReadMessage(Error);
            break;
          }
          case 130: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 138: {
            if (encryptionSpec_ == null) {
              EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
            }
            input.ReadMessage(EncryptionSpec);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 34: {
            if (studySpec_ == null) {
              StudySpec = new global::Google.Cloud.AIPlatform.V1.StudySpec();
            }
            input.ReadMessage(StudySpec);
            break;
          }
          case 40: {
            MaxTrialCount = input.ReadInt32();
            break;
          }
          case 48: {
            ParallelTrialCount = input.ReadInt32();
            break;
          }
          case 56: {
            MaxFailedTrialCount = input.ReadInt32();
            break;
          }
          case 66: {
            if (trialJobSpec_ == null) {
              TrialJobSpec = new global::Google.Cloud.AIPlatform.V1.CustomJobSpec();
            }
            input.ReadMessage(TrialJobSpec);
            break;
          }
          case 74: {
            trials_.AddEntriesFrom(ref input, _repeated_trials_codec);
            break;
          }
          case 80: {
            State = (global::Google.Cloud.AIPlatform.V1.JobState) input.ReadEnum();
            break;
          }
          case 90: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 98: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 106: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 114: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 122: {
            if (error_ == null) {
              Error = new global::Google.Rpc.Status();
            }
            input.ReadMessage(Error);
            break;
          }
          case 130: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 138: {
            if (encryptionSpec_ == null) {
              EncryptionSpec = new global::Google.Cloud.AIPlatform.V1.EncryptionSpec();
            }
            input.ReadMessage(EncryptionSpec);
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
