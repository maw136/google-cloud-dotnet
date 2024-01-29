// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/geo/type/viewport.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Geo.Type {

  /// <summary>Holder for reflection information generated from google/geo/type/viewport.proto</summary>
  public static partial class ViewportReflection {

    #region Descriptor
    /// <summary>File descriptor for google/geo/type/viewport.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ViewportReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5nb29nbGUvZ2VvL3R5cGUvdmlld3BvcnQucHJvdG8SD2dvb2dsZS5nZW8u",
            "dHlwZRoYZ29vZ2xlL3R5cGUvbGF0bG5nLnByb3RvIk8KCFZpZXdwb3J0EiAK",
            "A2xvdxgBIAEoCzITLmdvb2dsZS50eXBlLkxhdExuZxIhCgRoaWdoGAIgASgL",
            "MhMuZ29vZ2xlLnR5cGUuTGF0TG5nQm8KE2NvbS5nb29nbGUuZ2VvLnR5cGVC",
            "DVZpZXdwb3J0UHJvdG9QAVpAZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9nZW8vdHlwZS92aWV3cG9ydDt2aWV3cG9ydKICBEdHVFBi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Type.LatlngReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Geo.Type.Viewport), global::Google.Geo.Type.Viewport.Parser, new[]{ "Low", "High" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A latitude-longitude viewport, represented as two diagonally opposite `low`
  /// and `high` points. A viewport is considered a closed region, i.e. it includes
  /// its boundary. The latitude bounds must range between -90 to 90 degrees
  /// inclusive, and the longitude bounds must range between -180 to 180 degrees
  /// inclusive. Various cases include:
  ///
  ///  - If `low` = `high`, the viewport consists of that single point.
  ///
  ///  - If `low.longitude` > `high.longitude`, the longitude range is inverted
  ///    (the viewport crosses the 180 degree longitude line).
  ///
  ///  - If `low.longitude` = -180 degrees and `high.longitude` = 180 degrees,
  ///    the viewport includes all longitudes.
  ///
  ///  - If `low.longitude` = 180 degrees and `high.longitude` = -180 degrees,
  ///    the longitude range is empty.
  ///
  ///  - If `low.latitude` > `high.latitude`, the latitude range is empty.
  ///
  /// Both `low` and `high` must be populated, and the represented box cannot be
  /// empty (as specified by the definitions above). An empty viewport will result
  /// in an error.
  ///
  /// For example, this viewport fully encloses New York City:
  ///
  /// {
  ///     "low": {
  ///         "latitude": 40.477398,
  ///         "longitude": -74.259087
  ///     },
  ///     "high": {
  ///         "latitude": 40.91618,
  ///         "longitude": -73.70018
  ///     }
  /// }
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Viewport : pb::IMessage<Viewport>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Viewport> _parser = new pb::MessageParser<Viewport>(() => new Viewport());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Viewport> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Geo.Type.ViewportReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Viewport() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Viewport(Viewport other) : this() {
      low_ = other.low_ != null ? other.low_.Clone() : null;
      high_ = other.high_ != null ? other.high_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Viewport Clone() {
      return new Viewport(this);
    }

    /// <summary>Field number for the "low" field.</summary>
    public const int LowFieldNumber = 1;
    private global::Google.Type.LatLng low_;
    /// <summary>
    /// Required. The low point of the viewport.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Type.LatLng Low {
      get { return low_; }
      set {
        low_ = value;
      }
    }

    /// <summary>Field number for the "high" field.</summary>
    public const int HighFieldNumber = 2;
    private global::Google.Type.LatLng high_;
    /// <summary>
    /// Required. The high point of the viewport.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Type.LatLng High {
      get { return high_; }
      set {
        high_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Viewport);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Viewport other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Low, other.Low)) return false;
      if (!object.Equals(High, other.High)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (low_ != null) hash ^= Low.GetHashCode();
      if (high_ != null) hash ^= High.GetHashCode();
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
      if (low_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Low);
      }
      if (high_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(High);
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
      if (low_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Low);
      }
      if (high_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(High);
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
      if (low_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Low);
      }
      if (high_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(High);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Viewport other) {
      if (other == null) {
        return;
      }
      if (other.low_ != null) {
        if (low_ == null) {
          Low = new global::Google.Type.LatLng();
        }
        Low.MergeFrom(other.Low);
      }
      if (other.high_ != null) {
        if (high_ == null) {
          High = new global::Google.Type.LatLng();
        }
        High.MergeFrom(other.High);
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
            if (low_ == null) {
              Low = new global::Google.Type.LatLng();
            }
            input.ReadMessage(Low);
            break;
          }
          case 18: {
            if (high_ == null) {
              High = new global::Google.Type.LatLng();
            }
            input.ReadMessage(High);
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
            if (low_ == null) {
              Low = new global::Google.Type.LatLng();
            }
            input.ReadMessage(Low);
            break;
          }
          case 18: {
            if (high_ == null) {
              High = new global::Google.Type.LatLng();
            }
            input.ReadMessage(High);
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
