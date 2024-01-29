// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/routing/v2/location.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.Routing.V2 {

  /// <summary>Holder for reflection information generated from google/maps/routing/v2/location.proto</summary>
  public static partial class LocationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/routing/v2/location.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVnb29nbGUvbWFwcy9yb3V0aW5nL3YyL2xvY2F0aW9uLnByb3RvEhZnb29n",
            "bGUubWFwcy5yb3V0aW5nLnYyGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMu",
            "cHJvdG8aGGdvb2dsZS90eXBlL2xhdGxuZy5wcm90byJeCghMb2NhdGlvbhIk",
            "CgdsYXRfbG5nGAEgASgLMhMuZ29vZ2xlLnR5cGUuTGF0TG5nEiwKB2hlYWRp",
            "bmcYAiABKAsyGy5nb29nbGUucHJvdG9idWYuSW50MzJWYWx1ZULCAQoaY29t",
            "Lmdvb2dsZS5tYXBzLnJvdXRpbmcudjJCDUxvY2F0aW9uUHJvdG9QAVo6Y2xv",
            "dWQuZ29vZ2xlLmNvbS9nby9tYXBzL3JvdXRpbmcvYXBpdjIvcm91dGluZ3Bi",
            "O3JvdXRpbmdwYvgBAaICBUdNUlYyqgIWR29vZ2xlLk1hcHMuUm91dGluZy5W",
            "MsoCFkdvb2dsZVxNYXBzXFJvdXRpbmdcVjLqAhlHb29nbGU6Ok1hcHM6OlJv",
            "dXRpbmc6OlYyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Type.LatlngReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.Routing.V2.Location), global::Google.Maps.Routing.V2.Location.Parser, new[]{ "LatLng", "Heading" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Encapsulates a location (a geographic point, and an optional heading).
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Location : pb::IMessage<Location>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Location> _parser = new pb::MessageParser<Location>(() => new Location());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Location> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.Routing.V2.LocationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Location() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Location(Location other) : this() {
      latLng_ = other.latLng_ != null ? other.latLng_.Clone() : null;
      Heading = other.Heading;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Location Clone() {
      return new Location(this);
    }

    /// <summary>Field number for the "lat_lng" field.</summary>
    public const int LatLngFieldNumber = 1;
    private global::Google.Type.LatLng latLng_;
    /// <summary>
    /// The waypoint's geographic coordinates.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Type.LatLng LatLng {
      get { return latLng_; }
      set {
        latLng_ = value;
      }
    }

    /// <summary>Field number for the "heading" field.</summary>
    public const int HeadingFieldNumber = 2;
    private static readonly pb::FieldCodec<int?> _single_heading_codec = pb::FieldCodec.ForStructWrapper<int>(18);
    private int? heading_;
    /// <summary>
    /// The compass heading associated with the direction of the flow of traffic.
    /// This value specifies the side of the road for pickup and drop-off. Heading
    /// values can be from 0 to 360, where 0 specifies a heading of due North, 90
    /// specifies a heading of due East, and so on. You can use this field only for
    /// `DRIVE` and `TWO_WHEELER`
    /// [RouteTravelMode][google.maps.routing.v2.RouteTravelMode].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int? Heading {
      get { return heading_; }
      set {
        heading_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Location);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Location other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(LatLng, other.LatLng)) return false;
      if (Heading != other.Heading) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (latLng_ != null) hash ^= LatLng.GetHashCode();
      if (heading_ != null) hash ^= Heading.GetHashCode();
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
      if (latLng_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(LatLng);
      }
      if (heading_ != null) {
        _single_heading_codec.WriteTagAndValue(output, Heading);
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
      if (latLng_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(LatLng);
      }
      if (heading_ != null) {
        _single_heading_codec.WriteTagAndValue(ref output, Heading);
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
      if (latLng_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LatLng);
      }
      if (heading_ != null) {
        size += _single_heading_codec.CalculateSizeWithTag(Heading);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Location other) {
      if (other == null) {
        return;
      }
      if (other.latLng_ != null) {
        if (latLng_ == null) {
          LatLng = new global::Google.Type.LatLng();
        }
        LatLng.MergeFrom(other.LatLng);
      }
      if (other.heading_ != null) {
        if (heading_ == null || other.Heading != 0) {
          Heading = other.Heading;
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
            if (latLng_ == null) {
              LatLng = new global::Google.Type.LatLng();
            }
            input.ReadMessage(LatLng);
            break;
          }
          case 18: {
            int? value = _single_heading_codec.Read(input);
            if (heading_ == null || value != 0) {
              Heading = value;
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
            if (latLng_ == null) {
              LatLng = new global::Google.Type.LatLng();
            }
            input.ReadMessage(LatLng);
            break;
          }
          case 18: {
            int? value = _single_heading_codec.Read(ref input);
            if (heading_ == null || value != 0) {
              Heading = value;
            }
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
