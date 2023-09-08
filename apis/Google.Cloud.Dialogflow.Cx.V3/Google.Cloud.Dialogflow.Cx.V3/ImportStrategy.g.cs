// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/cx/v3/import_strategy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Dialogflow.Cx.V3 {

  /// <summary>Holder for reflection information generated from google/cloud/dialogflow/cx/v3/import_strategy.proto</summary>
  public static partial class ImportStrategyReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/dialogflow/cx/v3/import_strategy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImportStrategyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvZGlhbG9nZmxvdy9jeC92My9pbXBvcnRfc3RyYXRl",
            "Z3kucHJvdG8SHWdvb2dsZS5jbG91ZC5kaWFsb2dmbG93LmN4LnYzKsQBCg5J",
            "bXBvcnRTdHJhdGVneRIfChtJTVBPUlRfU1RSQVRFR1lfVU5TUEVDSUZJRUQQ",
            "ABIeChpJTVBPUlRfU1RSQVRFR1lfQ1JFQVRFX05FVxABEhsKF0lNUE9SVF9T",
            "VFJBVEVHWV9SRVBMQUNFEAISGAoUSU1QT1JUX1NUUkFURUdZX0tFRVAQAxIZ",
            "ChVJTVBPUlRfU1RSQVRFR1lfTUVSR0UQBBIfChtJTVBPUlRfU1RSQVRFR1lf",
            "VEhST1dfRVJST1IQBUK5AQohY29tLmdvb2dsZS5jbG91ZC5kaWFsb2dmbG93",
            "LmN4LnYzQhNJbXBvcnRTdHJhdGVneVByb3RvUAFaMWNsb3VkLmdvb2dsZS5j",
            "b20vZ28vZGlhbG9nZmxvdy9jeC9hcGl2My9jeHBiO2N4cGL4AQGiAgJERqoC",
            "HUdvb2dsZS5DbG91ZC5EaWFsb2dmbG93LkN4LlYz6gIhR29vZ2xlOjpDbG91",
            "ZDo6RGlhbG9nZmxvdzo6Q1g6OlYzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.Dialogflow.Cx.V3.ImportStrategy), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Import strategies for the conflict resolution of resources (i.e. intents,
  /// entities, and webhooks) with identical display names during import
  /// operations.
  /// </summary>
  public enum ImportStrategy {
    /// <summary>
    /// Unspecified. Treated as 'CREATE_NEW'.
    /// </summary>
    [pbr::OriginalName("IMPORT_STRATEGY_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Create a new resource with a numeric suffix appended to the end of the
    /// existing display name.
    /// </summary>
    [pbr::OriginalName("IMPORT_STRATEGY_CREATE_NEW")] CreateNew = 1,
    /// <summary>
    /// Replace existing resource with incoming resource in the content to be
    /// imported.
    /// </summary>
    [pbr::OriginalName("IMPORT_STRATEGY_REPLACE")] Replace = 2,
    /// <summary>
    /// Keep existing resource and discard incoming resource in the content to be
    /// imported.
    /// </summary>
    [pbr::OriginalName("IMPORT_STRATEGY_KEEP")] Keep = 3,
    /// <summary>
    /// Combine existing and incoming resources when a conflict is encountered.
    /// </summary>
    [pbr::OriginalName("IMPORT_STRATEGY_MERGE")] Merge = 4,
    /// <summary>
    /// Throw error if a conflict is encountered.
    /// </summary>
    [pbr::OriginalName("IMPORT_STRATEGY_THROW_ERROR")] ThrowError = 5,
  }

  #endregion

}

#endregion Designer generated code
