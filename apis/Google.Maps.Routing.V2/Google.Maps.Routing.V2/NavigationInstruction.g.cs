// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/routing/v2/navigation_instruction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.Routing.V2 {

  /// <summary>Holder for reflection information generated from google/maps/routing/v2/navigation_instruction.proto</summary>
  public static partial class NavigationInstructionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/routing/v2/navigation_instruction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NavigationInstructionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvbWFwcy9yb3V0aW5nL3YyL25hdmlnYXRpb25faW5zdHJ1Y3Rp",
            "b24ucHJvdG8SFmdvb2dsZS5tYXBzLnJvdXRpbmcudjIaJWdvb2dsZS9tYXBz",
            "L3JvdXRpbmcvdjIvbWFuZXV2ZXIucHJvdG8iYQoVTmF2aWdhdGlvbkluc3Ry",
            "dWN0aW9uEjIKCG1hbmV1dmVyGAEgASgOMiAuZ29vZ2xlLm1hcHMucm91dGlu",
            "Zy52Mi5NYW5ldXZlchIUCgxpbnN0cnVjdGlvbnMYAiABKAlC0gEKGmNvbS5n",
            "b29nbGUubWFwcy5yb3V0aW5nLnYyQhpOYXZpZ2F0aW9uSW5zdHJ1Y3Rpb25Q",
            "cm90b1ABWj1nb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L21hcHMvcm91dGluZy92Mjtyb3V0aW5n+AEBogIFR01SVjKqAhZHb29nbGUu",
            "TWFwcy5Sb3V0aW5nLlYyygIWR29vZ2xlXE1hcHNcUm91dGluZ1xWMuoCGUdv",
            "b2dsZTo6TWFwczo6Um91dGluZzo6VjJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Maps.Routing.V2.ManeuverReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.Routing.V2.NavigationInstruction), global::Google.Maps.Routing.V2.NavigationInstruction.Parser, new[]{ "Maneuver", "Instructions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Encapsulates navigation instructions for a
  /// [RouteLegStep][google.maps.routing.v2.RouteLegStep]
  /// </summary>
  public sealed partial class NavigationInstruction : pb::IMessage<NavigationInstruction>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NavigationInstruction> _parser = new pb::MessageParser<NavigationInstruction>(() => new NavigationInstruction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NavigationInstruction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.Routing.V2.NavigationInstructionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NavigationInstruction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NavigationInstruction(NavigationInstruction other) : this() {
      maneuver_ = other.maneuver_;
      instructions_ = other.instructions_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NavigationInstruction Clone() {
      return new NavigationInstruction(this);
    }

    /// <summary>Field number for the "maneuver" field.</summary>
    public const int ManeuverFieldNumber = 1;
    private global::Google.Maps.Routing.V2.Maneuver maneuver_ = global::Google.Maps.Routing.V2.Maneuver.Unspecified;
    /// <summary>
    /// Encapsulates the navigation instructions for the current step (e.g., turn
    /// left, merge, straight, etc.). This field determines which icon to display.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.Routing.V2.Maneuver Maneuver {
      get { return maneuver_; }
      set {
        maneuver_ = value;
      }
    }

    /// <summary>Field number for the "instructions" field.</summary>
    public const int InstructionsFieldNumber = 2;
    private string instructions_ = "";
    /// <summary>
    /// Instructions for navigating this step.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Instructions {
      get { return instructions_; }
      set {
        instructions_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NavigationInstruction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NavigationInstruction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Maneuver != other.Maneuver) return false;
      if (Instructions != other.Instructions) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Maneuver != global::Google.Maps.Routing.V2.Maneuver.Unspecified) hash ^= Maneuver.GetHashCode();
      if (Instructions.Length != 0) hash ^= Instructions.GetHashCode();
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
      if (Maneuver != global::Google.Maps.Routing.V2.Maneuver.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Maneuver);
      }
      if (Instructions.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Instructions);
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
      if (Maneuver != global::Google.Maps.Routing.V2.Maneuver.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Maneuver);
      }
      if (Instructions.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Instructions);
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
      if (Maneuver != global::Google.Maps.Routing.V2.Maneuver.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Maneuver);
      }
      if (Instructions.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Instructions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NavigationInstruction other) {
      if (other == null) {
        return;
      }
      if (other.Maneuver != global::Google.Maps.Routing.V2.Maneuver.Unspecified) {
        Maneuver = other.Maneuver;
      }
      if (other.Instructions.Length != 0) {
        Instructions = other.Instructions;
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
            Maneuver = (global::Google.Maps.Routing.V2.Maneuver) input.ReadEnum();
            break;
          }
          case 18: {
            Instructions = input.ReadString();
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
            Maneuver = (global::Google.Maps.Routing.V2.Maneuver) input.ReadEnum();
            break;
          }
          case 18: {
            Instructions = input.ReadString();
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
