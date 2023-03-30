// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/addressvalidation/v1/geocode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.AddressValidation.V1 {

  /// <summary>Holder for reflection information generated from google/maps/addressvalidation/v1/geocode.proto</summary>
  public static partial class GeocodeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/addressvalidation/v1/geocode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GeocodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvbWFwcy9hZGRyZXNzdmFsaWRhdGlvbi92MS9nZW9jb2RlLnBy",
            "b3RvEiBnb29nbGUubWFwcy5hZGRyZXNzdmFsaWRhdGlvbi52MRoeZ29vZ2xl",
            "L2dlby90eXBlL3ZpZXdwb3J0LnByb3RvGhhnb29nbGUvdHlwZS9sYXRsbmcu",
            "cHJvdG8i3gEKB0dlb2NvZGUSJQoIbG9jYXRpb24YASABKAsyEy5nb29nbGUu",
            "dHlwZS5MYXRMbmcSPQoJcGx1c19jb2RlGAIgASgLMiouZ29vZ2xlLm1hcHMu",
            "YWRkcmVzc3ZhbGlkYXRpb24udjEuUGx1c0NvZGUSKQoGYm91bmRzGAQgASgL",
            "MhkuZ29vZ2xlLmdlby50eXBlLlZpZXdwb3J0EhsKE2ZlYXR1cmVfc2l6ZV9t",
            "ZXRlcnMYBSABKAISEAoIcGxhY2VfaWQYBiABKAkSEwoLcGxhY2VfdHlwZXMY",
            "ByADKAkiNgoIUGx1c0NvZGUSEwoLZ2xvYmFsX2NvZGUYASABKAkSFQoNY29t",
            "cG91bmRfY29kZRgCIAEoCUKJAgokY29tLmdvb2dsZS5tYXBzLmFkZHJlc3N2",
            "YWxpZGF0aW9uLnYxQgxHZW9jb2RlUHJvdG9QAVpYY2xvdWQuZ29vZ2xlLmNv",
            "bS9nby9tYXBzL2FkZHJlc3N2YWxpZGF0aW9uL2FwaXYxL2FkZHJlc3N2YWxp",
            "ZGF0aW9ucGI7YWRkcmVzc3ZhbGlkYXRpb25wYvgBAaICB0dNUEFWVjGqAiBH",
            "b29nbGUuTWFwcy5BZGRyZXNzVmFsaWRhdGlvbi5WMcoCIEdvb2dsZVxNYXBz",
            "XEFkZHJlc3NWYWxpZGF0aW9uXFYx6gIjR29vZ2xlOjpNYXBzOjpBZGRyZXNz",
            "VmFsaWRhdGlvbjo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Geo.Type.ViewportReflection.Descriptor, global::Google.Type.LatlngReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.AddressValidation.V1.Geocode), global::Google.Maps.AddressValidation.V1.Geocode.Parser, new[]{ "Location", "PlusCode", "Bounds", "FeatureSizeMeters", "PlaceId", "PlaceTypes" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.AddressValidation.V1.PlusCode), global::Google.Maps.AddressValidation.V1.PlusCode.Parser, new[]{ "GlobalCode", "CompoundCode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Contains information about the place the input was geocoded to.
  /// </summary>
  public sealed partial class Geocode : pb::IMessage<Geocode>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Geocode> _parser = new pb::MessageParser<Geocode>(() => new Geocode());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Geocode> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.AddressValidation.V1.GeocodeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Geocode() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Geocode(Geocode other) : this() {
      location_ = other.location_ != null ? other.location_.Clone() : null;
      plusCode_ = other.plusCode_ != null ? other.plusCode_.Clone() : null;
      bounds_ = other.bounds_ != null ? other.bounds_.Clone() : null;
      featureSizeMeters_ = other.featureSizeMeters_;
      placeId_ = other.placeId_;
      placeTypes_ = other.placeTypes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Geocode Clone() {
      return new Geocode(this);
    }

    /// <summary>Field number for the "location" field.</summary>
    public const int LocationFieldNumber = 1;
    private global::Google.Type.LatLng location_;
    /// <summary>
    /// The geocoded location of the input.
    ///
    /// Using place IDs is preferred over using addresses,
    /// latitude/longitude coordinates, or plus codes. Using coordinates when
    /// routing or calculating driving directions will always result in the point
    /// being snapped to the road nearest to those coordinates. This may not be a
    /// road that will quickly or safely lead to the destination and may not be
    /// near an access point to the property. Additionally, when a location is
    /// reverse geocoded, there is no guarantee that the returned address will
    /// match the original.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Type.LatLng Location {
      get { return location_; }
      set {
        location_ = value;
      }
    }

    /// <summary>Field number for the "plus_code" field.</summary>
    public const int PlusCodeFieldNumber = 2;
    private global::Google.Maps.AddressValidation.V1.PlusCode plusCode_;
    /// <summary>
    /// The plus code corresponding to the `location`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.AddressValidation.V1.PlusCode PlusCode {
      get { return plusCode_; }
      set {
        plusCode_ = value;
      }
    }

    /// <summary>Field number for the "bounds" field.</summary>
    public const int BoundsFieldNumber = 4;
    private global::Google.Geo.Type.Viewport bounds_;
    /// <summary>
    /// The bounds of the geocoded place.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Geo.Type.Viewport Bounds {
      get { return bounds_; }
      set {
        bounds_ = value;
      }
    }

    /// <summary>Field number for the "feature_size_meters" field.</summary>
    public const int FeatureSizeMetersFieldNumber = 5;
    private float featureSizeMeters_;
    /// <summary>
    /// The size of the geocoded place, in meters. This is another measure of the
    /// coarseness of the geocoded location, but in physical size rather than in
    /// semantic meaning.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float FeatureSizeMeters {
      get { return featureSizeMeters_; }
      set {
        featureSizeMeters_ = value;
      }
    }

    /// <summary>Field number for the "place_id" field.</summary>
    public const int PlaceIdFieldNumber = 6;
    private string placeId_ = "";
    /// <summary>
    /// The PlaceID of the place this input geocodes to.
    ///
    /// For more information about Place IDs see
    /// [here](https://developers.google.com/maps/documentation/places/web-service/place-id).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PlaceId {
      get { return placeId_; }
      set {
        placeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "place_types" field.</summary>
    public const int PlaceTypesFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _repeated_placeTypes_codec
        = pb::FieldCodec.ForString(58);
    private readonly pbc::RepeatedField<string> placeTypes_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The type(s) of place that the input geocoded to. For example,
    /// `['locality', 'political']`. The full list of types can be found
    /// [here](https://developers.google.com/maps/documentation/geocoding/requests-geocoding#Types).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> PlaceTypes {
      get { return placeTypes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Geocode);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Geocode other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Location, other.Location)) return false;
      if (!object.Equals(PlusCode, other.PlusCode)) return false;
      if (!object.Equals(Bounds, other.Bounds)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FeatureSizeMeters, other.FeatureSizeMeters)) return false;
      if (PlaceId != other.PlaceId) return false;
      if(!placeTypes_.Equals(other.placeTypes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (location_ != null) hash ^= Location.GetHashCode();
      if (plusCode_ != null) hash ^= PlusCode.GetHashCode();
      if (bounds_ != null) hash ^= Bounds.GetHashCode();
      if (FeatureSizeMeters != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FeatureSizeMeters);
      if (PlaceId.Length != 0) hash ^= PlaceId.GetHashCode();
      hash ^= placeTypes_.GetHashCode();
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
      if (location_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Location);
      }
      if (plusCode_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PlusCode);
      }
      if (bounds_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Bounds);
      }
      if (FeatureSizeMeters != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(FeatureSizeMeters);
      }
      if (PlaceId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PlaceId);
      }
      placeTypes_.WriteTo(output, _repeated_placeTypes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (location_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Location);
      }
      if (plusCode_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PlusCode);
      }
      if (bounds_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Bounds);
      }
      if (FeatureSizeMeters != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(FeatureSizeMeters);
      }
      if (PlaceId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PlaceId);
      }
      placeTypes_.WriteTo(ref output, _repeated_placeTypes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (location_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Location);
      }
      if (plusCode_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlusCode);
      }
      if (bounds_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Bounds);
      }
      if (FeatureSizeMeters != 0F) {
        size += 1 + 4;
      }
      if (PlaceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlaceId);
      }
      size += placeTypes_.CalculateSize(_repeated_placeTypes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Geocode other) {
      if (other == null) {
        return;
      }
      if (other.location_ != null) {
        if (location_ == null) {
          Location = new global::Google.Type.LatLng();
        }
        Location.MergeFrom(other.Location);
      }
      if (other.plusCode_ != null) {
        if (plusCode_ == null) {
          PlusCode = new global::Google.Maps.AddressValidation.V1.PlusCode();
        }
        PlusCode.MergeFrom(other.PlusCode);
      }
      if (other.bounds_ != null) {
        if (bounds_ == null) {
          Bounds = new global::Google.Geo.Type.Viewport();
        }
        Bounds.MergeFrom(other.Bounds);
      }
      if (other.FeatureSizeMeters != 0F) {
        FeatureSizeMeters = other.FeatureSizeMeters;
      }
      if (other.PlaceId.Length != 0) {
        PlaceId = other.PlaceId;
      }
      placeTypes_.Add(other.placeTypes_);
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
            if (location_ == null) {
              Location = new global::Google.Type.LatLng();
            }
            input.ReadMessage(Location);
            break;
          }
          case 18: {
            if (plusCode_ == null) {
              PlusCode = new global::Google.Maps.AddressValidation.V1.PlusCode();
            }
            input.ReadMessage(PlusCode);
            break;
          }
          case 34: {
            if (bounds_ == null) {
              Bounds = new global::Google.Geo.Type.Viewport();
            }
            input.ReadMessage(Bounds);
            break;
          }
          case 45: {
            FeatureSizeMeters = input.ReadFloat();
            break;
          }
          case 50: {
            PlaceId = input.ReadString();
            break;
          }
          case 58: {
            placeTypes_.AddEntriesFrom(input, _repeated_placeTypes_codec);
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
            if (location_ == null) {
              Location = new global::Google.Type.LatLng();
            }
            input.ReadMessage(Location);
            break;
          }
          case 18: {
            if (plusCode_ == null) {
              PlusCode = new global::Google.Maps.AddressValidation.V1.PlusCode();
            }
            input.ReadMessage(PlusCode);
            break;
          }
          case 34: {
            if (bounds_ == null) {
              Bounds = new global::Google.Geo.Type.Viewport();
            }
            input.ReadMessage(Bounds);
            break;
          }
          case 45: {
            FeatureSizeMeters = input.ReadFloat();
            break;
          }
          case 50: {
            PlaceId = input.ReadString();
            break;
          }
          case 58: {
            placeTypes_.AddEntriesFrom(ref input, _repeated_placeTypes_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Plus code (http://plus.codes) is a location reference with two formats:
  /// global code defining a 14mx14m (1/8000th of a degree) or smaller rectangle,
  /// and compound code, replacing the prefix with a reference location.
  /// </summary>
  public sealed partial class PlusCode : pb::IMessage<PlusCode>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlusCode> _parser = new pb::MessageParser<PlusCode>(() => new PlusCode());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlusCode> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.AddressValidation.V1.GeocodeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlusCode() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlusCode(PlusCode other) : this() {
      globalCode_ = other.globalCode_;
      compoundCode_ = other.compoundCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlusCode Clone() {
      return new PlusCode(this);
    }

    /// <summary>Field number for the "global_code" field.</summary>
    public const int GlobalCodeFieldNumber = 1;
    private string globalCode_ = "";
    /// <summary>
    /// Place's global (full) code, such as "9FWM33GV+HQ", representing an
    /// 1/8000 by 1/8000 degree area (~14 by 14 meters).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GlobalCode {
      get { return globalCode_; }
      set {
        globalCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "compound_code" field.</summary>
    public const int CompoundCodeFieldNumber = 2;
    private string compoundCode_ = "";
    /// <summary>
    /// Place's compound code, such as "33GV+HQ, Ramberg, Norway", containing
    /// the suffix of the global code and replacing the prefix with a formatted
    /// name of a reference entity.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CompoundCode {
      get { return compoundCode_; }
      set {
        compoundCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlusCode);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlusCode other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GlobalCode != other.GlobalCode) return false;
      if (CompoundCode != other.CompoundCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GlobalCode.Length != 0) hash ^= GlobalCode.GetHashCode();
      if (CompoundCode.Length != 0) hash ^= CompoundCode.GetHashCode();
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
      if (GlobalCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GlobalCode);
      }
      if (CompoundCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CompoundCode);
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
      if (GlobalCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GlobalCode);
      }
      if (CompoundCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CompoundCode);
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
      if (GlobalCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GlobalCode);
      }
      if (CompoundCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CompoundCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlusCode other) {
      if (other == null) {
        return;
      }
      if (other.GlobalCode.Length != 0) {
        GlobalCode = other.GlobalCode;
      }
      if (other.CompoundCode.Length != 0) {
        CompoundCode = other.CompoundCode;
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
            GlobalCode = input.ReadString();
            break;
          }
          case 18: {
            CompoundCode = input.ReadString();
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
            GlobalCode = input.ReadString();
            break;
          }
          case 18: {
            CompoundCode = input.ReadString();
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
