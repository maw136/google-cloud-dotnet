// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/routing/v2/maneuver.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.Routing.V2 {

  /// <summary>Holder for reflection information generated from google/maps/routing/v2/maneuver.proto</summary>
  public static partial class ManeuverReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/routing/v2/maneuver.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ManeuverReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVnb29nbGUvbWFwcy9yb3V0aW5nL3YyL21hbmV1dmVyLnByb3RvEhZnb29n",
            "bGUubWFwcy5yb3V0aW5nLnYyKtoCCghNYW5ldXZlchIYChRNQU5FVVZFUl9V",
            "TlNQRUNJRklFRBAAEhQKEFRVUk5fU0xJR0hUX0xFRlQQARITCg9UVVJOX1NI",
            "QVJQX0xFRlQQAhIOCgpVVFVSTl9MRUZUEAMSDQoJVFVSTl9MRUZUEAQSFQoR",
            "VFVSTl9TTElHSFRfUklHSFQQBRIUChBUVVJOX1NIQVJQX1JJR0hUEAYSDwoL",
            "VVRVUk5fUklHSFQQBxIOCgpUVVJOX1JJR0hUEAgSDAoIU1RSQUlHSFQQCRIN",
            "CglSQU1QX0xFRlQQChIOCgpSQU1QX1JJR0hUEAsSCQoFTUVSR0UQDBINCglG",
            "T1JLX0xFRlQQDRIOCgpGT1JLX1JJR0hUEA4SCQoFRkVSUlkQDxIPCgtGRVJS",
            "WV9UUkFJThAQEhMKD1JPVU5EQUJPVVRfTEVGVBAREhQKEFJPVU5EQUJPVVRf",
            "UklHSFQQEkLFAQoaY29tLmdvb2dsZS5tYXBzLnJvdXRpbmcudjJCDU1hbmV1",
            "dmVyUHJvdG9QAVo9Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9tYXBzL3JvdXRpbmcvdjI7cm91dGluZ/gBAaICBUdNUlYyqgIWR29v",
            "Z2xlLk1hcHMuUm91dGluZy5WMsoCFkdvb2dsZVxNYXBzXFJvdXRpbmdcVjLq",
            "AhlHb29nbGU6Ok1hcHM6OlJvdXRpbmc6OlYyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Maps.Routing.V2.Maneuver), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// A set of values that specify the navigation action to take for the current
  /// step (e.g., turn left, merge, straight, etc.).
  /// </summary>
  public enum Maneuver {
    /// <summary>
    /// Not used.
    /// </summary>
    [pbr::OriginalName("MANEUVER_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Turn slightly to the left.
    /// </summary>
    [pbr::OriginalName("TURN_SLIGHT_LEFT")] TurnSlightLeft = 1,
    /// <summary>
    /// Turn sharply to the left.
    /// </summary>
    [pbr::OriginalName("TURN_SHARP_LEFT")] TurnSharpLeft = 2,
    /// <summary>
    /// Make a left u-turn.
    /// </summary>
    [pbr::OriginalName("UTURN_LEFT")] UturnLeft = 3,
    /// <summary>
    /// Turn left.
    /// </summary>
    [pbr::OriginalName("TURN_LEFT")] TurnLeft = 4,
    /// <summary>
    /// Turn slightly to the right.
    /// </summary>
    [pbr::OriginalName("TURN_SLIGHT_RIGHT")] TurnSlightRight = 5,
    /// <summary>
    /// Turn sharply to the right.
    /// </summary>
    [pbr::OriginalName("TURN_SHARP_RIGHT")] TurnSharpRight = 6,
    /// <summary>
    /// Make a right u-turn.
    /// </summary>
    [pbr::OriginalName("UTURN_RIGHT")] UturnRight = 7,
    /// <summary>
    /// Turn right.
    /// </summary>
    [pbr::OriginalName("TURN_RIGHT")] TurnRight = 8,
    /// <summary>
    /// Go straight.
    /// </summary>
    [pbr::OriginalName("STRAIGHT")] Straight = 9,
    /// <summary>
    /// Take the left ramp.
    /// </summary>
    [pbr::OriginalName("RAMP_LEFT")] RampLeft = 10,
    /// <summary>
    /// Take the right ramp.
    /// </summary>
    [pbr::OriginalName("RAMP_RIGHT")] RampRight = 11,
    /// <summary>
    /// Merge into traffic.
    /// </summary>
    [pbr::OriginalName("MERGE")] Merge = 12,
    /// <summary>
    /// Take the left fork.
    /// </summary>
    [pbr::OriginalName("FORK_LEFT")] ForkLeft = 13,
    /// <summary>
    /// Take the right fork.
    /// </summary>
    [pbr::OriginalName("FORK_RIGHT")] ForkRight = 14,
    /// <summary>
    /// Take the ferry.
    /// </summary>
    [pbr::OriginalName("FERRY")] Ferry = 15,
    /// <summary>
    /// Take the train leading onto the ferry.
    /// </summary>
    [pbr::OriginalName("FERRY_TRAIN")] FerryTrain = 16,
    /// <summary>
    /// Turn left at the roundabout.
    /// </summary>
    [pbr::OriginalName("ROUNDABOUT_LEFT")] RoundaboutLeft = 17,
    /// <summary>
    /// Turn right at the roundabout.
    /// </summary>
    [pbr::OriginalName("ROUNDABOUT_RIGHT")] RoundaboutRight = 18,
  }

  #endregion

}

#endregion Designer generated code
