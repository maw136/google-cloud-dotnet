// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/routing/v2/route_modifiers.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.Routing.V2 {

  /// <summary>Holder for reflection information generated from google/maps/routing/v2/route_modifiers.proto</summary>
  public static partial class RouteModifiersReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/routing/v2/route_modifiers.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RouteModifiersReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvbWFwcy9yb3V0aW5nL3YyL3JvdXRlX21vZGlmaWVycy5wcm90",
            "bxIWZ29vZ2xlLm1hcHMucm91dGluZy52MhooZ29vZ2xlL21hcHMvcm91dGlu",
            "Zy92Mi90b2xsX3Bhc3Nlcy5wcm90bxopZ29vZ2xlL21hcHMvcm91dGluZy92",
            "Mi92ZWhpY2xlX2luZm8ucHJvdG8i3AEKDlJvdXRlTW9kaWZpZXJzEhMKC2F2",
            "b2lkX3RvbGxzGAEgASgIEhYKDmF2b2lkX2hpZ2h3YXlzGAIgASgIEhUKDWF2",
            "b2lkX2ZlcnJpZXMYAyABKAgSFAoMYXZvaWRfaW5kb29yGAQgASgIEjkKDHZl",
            "aGljbGVfaW5mbxgFIAEoCzIjLmdvb2dsZS5tYXBzLnJvdXRpbmcudjIuVmVo",
            "aWNsZUluZm8SNQoLdG9sbF9wYXNzZXMYBiADKA4yIC5nb29nbGUubWFwcy5y",
            "b3V0aW5nLnYyLlRvbGxQYXNzQssBChpjb20uZ29vZ2xlLm1hcHMucm91dGlu",
            "Zy52MkITUm91dGVNb2RpZmllcnNQcm90b1ABWj1nb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL21hcHMvcm91dGluZy92Mjtyb3V0aW5n",
            "+AEBogIFR01SVjKqAhZHb29nbGUuTWFwcy5Sb3V0aW5nLlYyygIWR29vZ2xl",
            "XE1hcHNcUm91dGluZ1xWMuoCGUdvb2dsZTo6TWFwczo6Um91dGluZzo6VjJi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Maps.Routing.V2.TollPassesReflection.Descriptor, global::Google.Maps.Routing.V2.VehicleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.Routing.V2.RouteModifiers), global::Google.Maps.Routing.V2.RouteModifiers.Parser, new[]{ "AvoidTolls", "AvoidHighways", "AvoidFerries", "AvoidIndoor", "VehicleInfo", "TollPasses" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Encapsulates a set of optional conditions to satisfy when calculating the
  /// routes.
  /// </summary>
  public sealed partial class RouteModifiers : pb::IMessage<RouteModifiers>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RouteModifiers> _parser = new pb::MessageParser<RouteModifiers>(() => new RouteModifiers());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RouteModifiers> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.Routing.V2.RouteModifiersReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RouteModifiers() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RouteModifiers(RouteModifiers other) : this() {
      avoidTolls_ = other.avoidTolls_;
      avoidHighways_ = other.avoidHighways_;
      avoidFerries_ = other.avoidFerries_;
      avoidIndoor_ = other.avoidIndoor_;
      vehicleInfo_ = other.vehicleInfo_ != null ? other.vehicleInfo_.Clone() : null;
      tollPasses_ = other.tollPasses_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RouteModifiers Clone() {
      return new RouteModifiers(this);
    }

    /// <summary>Field number for the "avoid_tolls" field.</summary>
    public const int AvoidTollsFieldNumber = 1;
    private bool avoidTolls_;
    /// <summary>
    /// Specifies whether to avoid toll roads where reasonable. Preference will be
    /// given to routes not containing toll roads. Applies only to the `DRIVE` and
    /// `TWO_WHEELER` travel modes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AvoidTolls {
      get { return avoidTolls_; }
      set {
        avoidTolls_ = value;
      }
    }

    /// <summary>Field number for the "avoid_highways" field.</summary>
    public const int AvoidHighwaysFieldNumber = 2;
    private bool avoidHighways_;
    /// <summary>
    /// Specifies whether to avoid highways where reasonable. Preference will be
    /// given to routes not containing highways. Applies only to the `DRIVE` and
    /// `TWO_WHEELER` travel modes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AvoidHighways {
      get { return avoidHighways_; }
      set {
        avoidHighways_ = value;
      }
    }

    /// <summary>Field number for the "avoid_ferries" field.</summary>
    public const int AvoidFerriesFieldNumber = 3;
    private bool avoidFerries_;
    /// <summary>
    /// Specifies whether to avoid ferries where reasonable. Preference will be
    /// given to routes not containing travel by ferries.
    /// Applies only to the `DRIVE` and`TWO_WHEELER` travel modes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AvoidFerries {
      get { return avoidFerries_; }
      set {
        avoidFerries_ = value;
      }
    }

    /// <summary>Field number for the "avoid_indoor" field.</summary>
    public const int AvoidIndoorFieldNumber = 4;
    private bool avoidIndoor_;
    /// <summary>
    /// Specifies whether to avoid navigating indoors where reasonable. Preference
    /// will be given to routes not containing indoor navigation.
    /// Applies only to the `WALK` travel mode.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AvoidIndoor {
      get { return avoidIndoor_; }
      set {
        avoidIndoor_ = value;
      }
    }

    /// <summary>Field number for the "vehicle_info" field.</summary>
    public const int VehicleInfoFieldNumber = 5;
    private global::Google.Maps.Routing.V2.VehicleInfo vehicleInfo_;
    /// <summary>
    /// Specifies the vehicle information.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.Routing.V2.VehicleInfo VehicleInfo {
      get { return vehicleInfo_; }
      set {
        vehicleInfo_ = value;
      }
    }

    /// <summary>Field number for the "toll_passes" field.</summary>
    public const int TollPassesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Maps.Routing.V2.TollPass> _repeated_tollPasses_codec
        = pb::FieldCodec.ForEnum(50, x => (int) x, x => (global::Google.Maps.Routing.V2.TollPass) x);
    private readonly pbc::RepeatedField<global::Google.Maps.Routing.V2.TollPass> tollPasses_ = new pbc::RepeatedField<global::Google.Maps.Routing.V2.TollPass>();
    /// <summary>
    /// Encapsulates information about toll passes.
    /// If toll passes are provided, the API tries to return the pass price. If
    /// toll passes are not provided, the API treats the toll pass as unknown and
    /// tries to return the cash price.
    /// Applies only to the DRIVE and TWO_WHEELER travel modes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Maps.Routing.V2.TollPass> TollPasses {
      get { return tollPasses_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RouteModifiers);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RouteModifiers other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvoidTolls != other.AvoidTolls) return false;
      if (AvoidHighways != other.AvoidHighways) return false;
      if (AvoidFerries != other.AvoidFerries) return false;
      if (AvoidIndoor != other.AvoidIndoor) return false;
      if (!object.Equals(VehicleInfo, other.VehicleInfo)) return false;
      if(!tollPasses_.Equals(other.tollPasses_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvoidTolls != false) hash ^= AvoidTolls.GetHashCode();
      if (AvoidHighways != false) hash ^= AvoidHighways.GetHashCode();
      if (AvoidFerries != false) hash ^= AvoidFerries.GetHashCode();
      if (AvoidIndoor != false) hash ^= AvoidIndoor.GetHashCode();
      if (vehicleInfo_ != null) hash ^= VehicleInfo.GetHashCode();
      hash ^= tollPasses_.GetHashCode();
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
      if (AvoidTolls != false) {
        output.WriteRawTag(8);
        output.WriteBool(AvoidTolls);
      }
      if (AvoidHighways != false) {
        output.WriteRawTag(16);
        output.WriteBool(AvoidHighways);
      }
      if (AvoidFerries != false) {
        output.WriteRawTag(24);
        output.WriteBool(AvoidFerries);
      }
      if (AvoidIndoor != false) {
        output.WriteRawTag(32);
        output.WriteBool(AvoidIndoor);
      }
      if (vehicleInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(VehicleInfo);
      }
      tollPasses_.WriteTo(output, _repeated_tollPasses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (AvoidTolls != false) {
        output.WriteRawTag(8);
        output.WriteBool(AvoidTolls);
      }
      if (AvoidHighways != false) {
        output.WriteRawTag(16);
        output.WriteBool(AvoidHighways);
      }
      if (AvoidFerries != false) {
        output.WriteRawTag(24);
        output.WriteBool(AvoidFerries);
      }
      if (AvoidIndoor != false) {
        output.WriteRawTag(32);
        output.WriteBool(AvoidIndoor);
      }
      if (vehicleInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(VehicleInfo);
      }
      tollPasses_.WriteTo(ref output, _repeated_tollPasses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (AvoidTolls != false) {
        size += 1 + 1;
      }
      if (AvoidHighways != false) {
        size += 1 + 1;
      }
      if (AvoidFerries != false) {
        size += 1 + 1;
      }
      if (AvoidIndoor != false) {
        size += 1 + 1;
      }
      if (vehicleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VehicleInfo);
      }
      size += tollPasses_.CalculateSize(_repeated_tollPasses_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RouteModifiers other) {
      if (other == null) {
        return;
      }
      if (other.AvoidTolls != false) {
        AvoidTolls = other.AvoidTolls;
      }
      if (other.AvoidHighways != false) {
        AvoidHighways = other.AvoidHighways;
      }
      if (other.AvoidFerries != false) {
        AvoidFerries = other.AvoidFerries;
      }
      if (other.AvoidIndoor != false) {
        AvoidIndoor = other.AvoidIndoor;
      }
      if (other.vehicleInfo_ != null) {
        if (vehicleInfo_ == null) {
          VehicleInfo = new global::Google.Maps.Routing.V2.VehicleInfo();
        }
        VehicleInfo.MergeFrom(other.VehicleInfo);
      }
      tollPasses_.Add(other.tollPasses_);
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
            AvoidTolls = input.ReadBool();
            break;
          }
          case 16: {
            AvoidHighways = input.ReadBool();
            break;
          }
          case 24: {
            AvoidFerries = input.ReadBool();
            break;
          }
          case 32: {
            AvoidIndoor = input.ReadBool();
            break;
          }
          case 42: {
            if (vehicleInfo_ == null) {
              VehicleInfo = new global::Google.Maps.Routing.V2.VehicleInfo();
            }
            input.ReadMessage(VehicleInfo);
            break;
          }
          case 50:
          case 48: {
            tollPasses_.AddEntriesFrom(input, _repeated_tollPasses_codec);
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
            AvoidTolls = input.ReadBool();
            break;
          }
          case 16: {
            AvoidHighways = input.ReadBool();
            break;
          }
          case 24: {
            AvoidFerries = input.ReadBool();
            break;
          }
          case 32: {
            AvoidIndoor = input.ReadBool();
            break;
          }
          case 42: {
            if (vehicleInfo_ == null) {
              VehicleInfo = new global::Google.Maps.Routing.V2.VehicleInfo();
            }
            input.ReadMessage(VehicleInfo);
            break;
          }
          case 50:
          case 48: {
            tollPasses_.AddEntriesFrom(ref input, _repeated_tollPasses_codec);
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