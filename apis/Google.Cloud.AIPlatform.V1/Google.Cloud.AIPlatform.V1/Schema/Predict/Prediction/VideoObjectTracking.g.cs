// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/predict/prediction/video_object_tracking.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/predict/prediction/video_object_tracking.proto</summary>
  public static partial class VideoObjectTrackingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/predict/prediction/video_object_tracking.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VideoObjectTrackingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClBnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9w",
            "cmVkaWN0aW9uL3ZpZGVvX29iamVjdF90cmFja2luZy5wcm90bxI0Z29vZ2xl",
            "LmNsb3VkLmFpcGxhdGZvcm0udjEuc2NoZW1hLnByZWRpY3QucHJlZGljdGlv",
            "bhoeZ29vZ2xlL3Byb3RvYnVmL2R1cmF0aW9uLnByb3RvGh5nb29nbGUvcHJv",
            "dG9idWYvd3JhcHBlcnMucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8ivwQKI1ZpZGVvT2JqZWN0VHJhY2tpbmdQcmVkaWN0aW9uUmVzdWx0",
            "EgoKAmlkGAEgASgJEhQKDGRpc3BsYXlfbmFtZRgCIAEoCRI1ChJ0aW1lX3Nl",
            "Z21lbnRfc3RhcnQYAyABKAsyGS5nb29nbGUucHJvdG9idWYuRHVyYXRpb24S",
            "MwoQdGltZV9zZWdtZW50X2VuZBgEIAEoCzIZLmdvb2dsZS5wcm90b2J1Zi5E",
            "dXJhdGlvbhIvCgpjb25maWRlbmNlGAUgASgLMhsuZ29vZ2xlLnByb3RvYnVm",
            "LkZsb2F0VmFsdWUSbwoGZnJhbWVzGAYgAygLMl8uZ29vZ2xlLmNsb3VkLmFp",
            "cGxhdGZvcm0udjEuc2NoZW1hLnByZWRpY3QucHJlZGljdGlvbi5WaWRlb09i",
            "amVjdFRyYWNraW5nUHJlZGljdGlvblJlc3VsdC5GcmFtZRrnAQoFRnJhbWUS",
            "LgoLdGltZV9vZmZzZXQYASABKAsyGS5nb29nbGUucHJvdG9idWYuRHVyYXRp",
            "b24SKgoFeF9taW4YAiABKAsyGy5nb29nbGUucHJvdG9idWYuRmxvYXRWYWx1",
            "ZRIqCgV4X21heBgDIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5GbG9hdFZhbHVl",
            "EioKBXlfbWluGAQgASgLMhsuZ29vZ2xlLnByb3RvYnVmLkZsb2F0VmFsdWUS",
            "KgoFeV9tYXgYBSABKAsyGy5nb29nbGUucHJvdG9idWYuRmxvYXRWYWx1ZULx",
            "Ago4Y29tLmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxLnNjaGVtYS5wcmVk",
            "aWN0LnByZWRpY3Rpb25CKFZpZGVvT2JqZWN0VHJhY2tpbmdQcmVkaWN0aW9u",
            "UmVzdWx0UHJvdG9QAVpeZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9jbG91ZC9haXBsYXRmb3JtL3YxL3NjaGVtYS9wcmVkaWN0L3By",
            "ZWRpY3Rpb247cHJlZGljdGlvbqoCNEdvb2dsZS5DbG91ZC5BSVBsYXRmb3Jt",
            "LlYxLlNjaGVtYS5QcmVkaWN0LlByZWRpY3Rpb27KAjRHb29nbGVcQ2xvdWRc",
            "QUlQbGF0Zm9ybVxWMVxTY2hlbWFcUHJlZGljdFxQcmVkaWN0aW9u6gI6R29v",
            "Z2xlOjpDbG91ZDo6QUlQbGF0Zm9ybTo6VjE6OlNjaGVtYTo6UHJlZGljdDo6",
            "UHJlZGljdGlvbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoObjectTrackingPredictionResult), global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoObjectTrackingPredictionResult.Parser, new[]{ "Id", "DisplayName", "TimeSegmentStart", "TimeSegmentEnd", "Confidence", "Frames" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoObjectTrackingPredictionResult.Types.Frame), global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoObjectTrackingPredictionResult.Types.Frame.Parser, new[]{ "TimeOffset", "XMin", "XMax", "YMin", "YMax" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction output format for Video Object Tracking.
  /// </summary>
  public sealed partial class VideoObjectTrackingPredictionResult : pb::IMessage<VideoObjectTrackingPredictionResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VideoObjectTrackingPredictionResult> _parser = new pb::MessageParser<VideoObjectTrackingPredictionResult>(() => new VideoObjectTrackingPredictionResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VideoObjectTrackingPredictionResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoObjectTrackingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoObjectTrackingPredictionResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoObjectTrackingPredictionResult(VideoObjectTrackingPredictionResult other) : this() {
      id_ = other.id_;
      displayName_ = other.displayName_;
      timeSegmentStart_ = other.timeSegmentStart_ != null ? other.timeSegmentStart_.Clone() : null;
      timeSegmentEnd_ = other.timeSegmentEnd_ != null ? other.timeSegmentEnd_.Clone() : null;
      Confidence = other.Confidence;
      frames_ = other.frames_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VideoObjectTrackingPredictionResult Clone() {
      return new VideoObjectTrackingPredictionResult(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// The resource ID of the AnnotationSpec that had been identified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// The display name of the AnnotationSpec that had been identified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time_segment_start" field.</summary>
    public const int TimeSegmentStartFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration timeSegmentStart_;
    /// <summary>
    /// The beginning, inclusive, of the video's time segment in which the
    /// object instance has been detected. Expressed as a number of seconds as
    /// measured from the start of the video, with fractions up to a microsecond
    /// precision, and with "s" appended at the end.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration TimeSegmentStart {
      get { return timeSegmentStart_; }
      set {
        timeSegmentStart_ = value;
      }
    }

    /// <summary>Field number for the "time_segment_end" field.</summary>
    public const int TimeSegmentEndFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Duration timeSegmentEnd_;
    /// <summary>
    /// The end, inclusive, of the video's time segment in which the
    /// object instance has been detected. Expressed as a number of seconds as
    /// measured from the start of the video, with fractions up to a microsecond
    /// precision, and with "s" appended at the end.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration TimeSegmentEnd {
      get { return timeSegmentEnd_; }
      set {
        timeSegmentEnd_ = value;
      }
    }

    /// <summary>Field number for the "confidence" field.</summary>
    public const int ConfidenceFieldNumber = 5;
    private static readonly pb::FieldCodec<float?> _single_confidence_codec = pb::FieldCodec.ForStructWrapper<float>(42);
    private float? confidence_;
    /// <summary>
    /// The Model's confidence in correction of this prediction, higher
    /// value means higher confidence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float? Confidence {
      get { return confidence_; }
      set {
        confidence_ = value;
      }
    }


    /// <summary>Field number for the "frames" field.</summary>
    public const int FramesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoObjectTrackingPredictionResult.Types.Frame> _repeated_frames_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoObjectTrackingPredictionResult.Types.Frame.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoObjectTrackingPredictionResult.Types.Frame> frames_ = new pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoObjectTrackingPredictionResult.Types.Frame>();
    /// <summary>
    /// All of the frames of the video in which a single object instance has been
    /// detected. The bounding boxes in the frames identify the same object.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoObjectTrackingPredictionResult.Types.Frame> Frames {
      get { return frames_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VideoObjectTrackingPredictionResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VideoObjectTrackingPredictionResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (DisplayName != other.DisplayName) return false;
      if (!object.Equals(TimeSegmentStart, other.TimeSegmentStart)) return false;
      if (!object.Equals(TimeSegmentEnd, other.TimeSegmentEnd)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.Equals(Confidence, other.Confidence)) return false;
      if(!frames_.Equals(other.frames_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (timeSegmentStart_ != null) hash ^= TimeSegmentStart.GetHashCode();
      if (timeSegmentEnd_ != null) hash ^= TimeSegmentEnd.GetHashCode();
      if (confidence_ != null) hash ^= pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.GetHashCode(Confidence);
      hash ^= frames_.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (timeSegmentStart_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TimeSegmentStart);
      }
      if (timeSegmentEnd_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TimeSegmentEnd);
      }
      if (confidence_ != null) {
        _single_confidence_codec.WriteTagAndValue(output, Confidence);
      }
      frames_.WriteTo(output, _repeated_frames_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (timeSegmentStart_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TimeSegmentStart);
      }
      if (timeSegmentEnd_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TimeSegmentEnd);
      }
      if (confidence_ != null) {
        _single_confidence_codec.WriteTagAndValue(ref output, Confidence);
      }
      frames_.WriteTo(ref output, _repeated_frames_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (timeSegmentStart_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeSegmentStart);
      }
      if (timeSegmentEnd_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeSegmentEnd);
      }
      if (confidence_ != null) {
        size += _single_confidence_codec.CalculateSizeWithTag(Confidence);
      }
      size += frames_.CalculateSize(_repeated_frames_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VideoObjectTrackingPredictionResult other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.timeSegmentStart_ != null) {
        if (timeSegmentStart_ == null) {
          TimeSegmentStart = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        TimeSegmentStart.MergeFrom(other.TimeSegmentStart);
      }
      if (other.timeSegmentEnd_ != null) {
        if (timeSegmentEnd_ == null) {
          TimeSegmentEnd = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        TimeSegmentEnd.MergeFrom(other.TimeSegmentEnd);
      }
      if (other.confidence_ != null) {
        if (confidence_ == null || other.Confidence != 0F) {
          Confidence = other.Confidence;
        }
      }
      frames_.Add(other.frames_);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            if (timeSegmentStart_ == null) {
              TimeSegmentStart = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(TimeSegmentStart);
            break;
          }
          case 34: {
            if (timeSegmentEnd_ == null) {
              TimeSegmentEnd = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(TimeSegmentEnd);
            break;
          }
          case 42: {
            float? value = _single_confidence_codec.Read(input);
            if (confidence_ == null || value != 0F) {
              Confidence = value;
            }
            break;
          }
          case 50: {
            frames_.AddEntriesFrom(input, _repeated_frames_codec);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            if (timeSegmentStart_ == null) {
              TimeSegmentStart = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(TimeSegmentStart);
            break;
          }
          case 34: {
            if (timeSegmentEnd_ == null) {
              TimeSegmentEnd = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(TimeSegmentEnd);
            break;
          }
          case 42: {
            float? value = _single_confidence_codec.Read(ref input);
            if (confidence_ == null || value != 0F) {
              Confidence = value;
            }
            break;
          }
          case 50: {
            frames_.AddEntriesFrom(ref input, _repeated_frames_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the VideoObjectTrackingPredictionResult message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The fields `xMin`, `xMax`, `yMin`, and `yMax` refer to a bounding box,
      /// i.e. the rectangle over the video frame pinpointing the found
      /// AnnotationSpec. The coordinates are relative to the frame size, and the
      /// point 0,0 is in the top left of the frame.
      /// </summary>
      public sealed partial class Frame : pb::IMessage<Frame>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Frame> _parser = new pb::MessageParser<Frame>(() => new Frame());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Frame> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.VideoObjectTrackingPredictionResult.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Frame() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Frame(Frame other) : this() {
          timeOffset_ = other.timeOffset_ != null ? other.timeOffset_.Clone() : null;
          XMin = other.XMin;
          XMax = other.XMax;
          YMin = other.YMin;
          YMax = other.YMax;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Frame Clone() {
          return new Frame(this);
        }

        /// <summary>Field number for the "time_offset" field.</summary>
        public const int TimeOffsetFieldNumber = 1;
        private global::Google.Protobuf.WellKnownTypes.Duration timeOffset_;
        /// <summary>
        /// A time (frame) of a video in which the object has been detected.
        /// Expressed as a number of seconds as measured from the
        /// start of the video, with fractions up to a microsecond precision, and
        /// with "s" appended at the end.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Protobuf.WellKnownTypes.Duration TimeOffset {
          get { return timeOffset_; }
          set {
            timeOffset_ = value;
          }
        }

        /// <summary>Field number for the "x_min" field.</summary>
        public const int XMinFieldNumber = 2;
        private static readonly pb::FieldCodec<float?> _single_xMin_codec = pb::FieldCodec.ForStructWrapper<float>(18);
        private float? xMin_;
        /// <summary>
        /// The leftmost coordinate of the bounding box.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public float? XMin {
          get { return xMin_; }
          set {
            xMin_ = value;
          }
        }


        /// <summary>Field number for the "x_max" field.</summary>
        public const int XMaxFieldNumber = 3;
        private static readonly pb::FieldCodec<float?> _single_xMax_codec = pb::FieldCodec.ForStructWrapper<float>(26);
        private float? xMax_;
        /// <summary>
        /// The rightmost coordinate of the bounding box.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public float? XMax {
          get { return xMax_; }
          set {
            xMax_ = value;
          }
        }


        /// <summary>Field number for the "y_min" field.</summary>
        public const int YMinFieldNumber = 4;
        private static readonly pb::FieldCodec<float?> _single_yMin_codec = pb::FieldCodec.ForStructWrapper<float>(34);
        private float? yMin_;
        /// <summary>
        /// The topmost coordinate of the bounding box.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public float? YMin {
          get { return yMin_; }
          set {
            yMin_ = value;
          }
        }


        /// <summary>Field number for the "y_max" field.</summary>
        public const int YMaxFieldNumber = 5;
        private static readonly pb::FieldCodec<float?> _single_yMax_codec = pb::FieldCodec.ForStructWrapper<float>(42);
        private float? yMax_;
        /// <summary>
        /// The bottommost coordinate of the bounding box.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public float? YMax {
          get { return yMax_; }
          set {
            yMax_ = value;
          }
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Frame);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Frame other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(TimeOffset, other.TimeOffset)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.Equals(XMin, other.XMin)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.Equals(XMax, other.XMax)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.Equals(YMin, other.YMin)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.Equals(YMax, other.YMax)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (timeOffset_ != null) hash ^= TimeOffset.GetHashCode();
          if (xMin_ != null) hash ^= pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.GetHashCode(XMin);
          if (xMax_ != null) hash ^= pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.GetHashCode(XMax);
          if (yMin_ != null) hash ^= pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.GetHashCode(YMin);
          if (yMax_ != null) hash ^= pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.GetHashCode(YMax);
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
          if (timeOffset_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(TimeOffset);
          }
          if (xMin_ != null) {
            _single_xMin_codec.WriteTagAndValue(output, XMin);
          }
          if (xMax_ != null) {
            _single_xMax_codec.WriteTagAndValue(output, XMax);
          }
          if (yMin_ != null) {
            _single_yMin_codec.WriteTagAndValue(output, YMin);
          }
          if (yMax_ != null) {
            _single_yMax_codec.WriteTagAndValue(output, YMax);
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
          if (timeOffset_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(TimeOffset);
          }
          if (xMin_ != null) {
            _single_xMin_codec.WriteTagAndValue(ref output, XMin);
          }
          if (xMax_ != null) {
            _single_xMax_codec.WriteTagAndValue(ref output, XMax);
          }
          if (yMin_ != null) {
            _single_yMin_codec.WriteTagAndValue(ref output, YMin);
          }
          if (yMax_ != null) {
            _single_yMax_codec.WriteTagAndValue(ref output, YMax);
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
          if (timeOffset_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeOffset);
          }
          if (xMin_ != null) {
            size += _single_xMin_codec.CalculateSizeWithTag(XMin);
          }
          if (xMax_ != null) {
            size += _single_xMax_codec.CalculateSizeWithTag(XMax);
          }
          if (yMin_ != null) {
            size += _single_yMin_codec.CalculateSizeWithTag(YMin);
          }
          if (yMax_ != null) {
            size += _single_yMax_codec.CalculateSizeWithTag(YMax);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Frame other) {
          if (other == null) {
            return;
          }
          if (other.timeOffset_ != null) {
            if (timeOffset_ == null) {
              TimeOffset = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            TimeOffset.MergeFrom(other.TimeOffset);
          }
          if (other.xMin_ != null) {
            if (xMin_ == null || other.XMin != 0F) {
              XMin = other.XMin;
            }
          }
          if (other.xMax_ != null) {
            if (xMax_ == null || other.XMax != 0F) {
              XMax = other.XMax;
            }
          }
          if (other.yMin_ != null) {
            if (yMin_ == null || other.YMin != 0F) {
              YMin = other.YMin;
            }
          }
          if (other.yMax_ != null) {
            if (yMax_ == null || other.YMax != 0F) {
              YMax = other.YMax;
            }
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
                if (timeOffset_ == null) {
                  TimeOffset = new global::Google.Protobuf.WellKnownTypes.Duration();
                }
                input.ReadMessage(TimeOffset);
                break;
              }
              case 18: {
                float? value = _single_xMin_codec.Read(input);
                if (xMin_ == null || value != 0F) {
                  XMin = value;
                }
                break;
              }
              case 26: {
                float? value = _single_xMax_codec.Read(input);
                if (xMax_ == null || value != 0F) {
                  XMax = value;
                }
                break;
              }
              case 34: {
                float? value = _single_yMin_codec.Read(input);
                if (yMin_ == null || value != 0F) {
                  YMin = value;
                }
                break;
              }
              case 42: {
                float? value = _single_yMax_codec.Read(input);
                if (yMax_ == null || value != 0F) {
                  YMax = value;
                }
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
                if (timeOffset_ == null) {
                  TimeOffset = new global::Google.Protobuf.WellKnownTypes.Duration();
                }
                input.ReadMessage(TimeOffset);
                break;
              }
              case 18: {
                float? value = _single_xMin_codec.Read(ref input);
                if (xMin_ == null || value != 0F) {
                  XMin = value;
                }
                break;
              }
              case 26: {
                float? value = _single_xMax_codec.Read(ref input);
                if (xMax_ == null || value != 0F) {
                  XMax = value;
                }
                break;
              }
              case 34: {
                float? value = _single_yMin_codec.Read(ref input);
                if (yMin_ == null || value != 0F) {
                  YMin = value;
                }
                break;
              }
              case 42: {
                float? value = _single_yMax_codec.Read(ref input);
                if (yMax_ == null || value != 0F) {
                  YMax = value;
                }
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
