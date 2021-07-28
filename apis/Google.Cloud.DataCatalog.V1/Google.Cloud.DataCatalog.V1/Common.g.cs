// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/datacatalog/v1/common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DataCatalog.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/datacatalog/v1/common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/datacatalog/v1/common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvZGF0YWNhdGFsb2cvdjEvY29tbW9uLnByb3RvEhtn",
            "b29nbGUuY2xvdWQuZGF0YWNhdGFsb2cudjEqbQoQSW50ZWdyYXRlZFN5c3Rl",
            "bRIhCh1JTlRFR1JBVEVEX1NZU1RFTV9VTlNQRUNJRklFRBAAEgwKCEJJR1FV",
            "RVJZEAESEAoMQ0xPVURfUFVCU1VCEAISFgoSREFUQVBST0NfTUVUQVNUT1JF",
            "EANCywEKH2NvbS5nb29nbGUuY2xvdWQuZGF0YWNhdGFsb2cudjFQAVpGZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9kYXRh",
            "Y2F0YWxvZy92MTtkYXRhY2F0YWxvZ/gBAaoCG0dvb2dsZS5DbG91ZC5EYXRh",
            "Q2F0YWxvZy5WMcoCG0dvb2dsZVxDbG91ZFxEYXRhQ2F0YWxvZ1xWMeoCHkdv",
            "b2dsZTo6Q2xvdWQ6OkRhdGFDYXRhbG9nOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.DataCatalog.V1.IntegratedSystem), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// This enum lists all the systems that Data Catalog integrates with.
  /// </summary>
  public enum IntegratedSystem {
    /// <summary>
    /// Default unknown system.
    /// </summary>
    [pbr::OriginalName("INTEGRATED_SYSTEM_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// BigQuery.
    /// </summary>
    [pbr::OriginalName("BIGQUERY")] Bigquery = 1,
    /// <summary>
    /// Cloud Pub/Sub.
    /// </summary>
    [pbr::OriginalName("CLOUD_PUBSUB")] CloudPubsub = 2,
    /// <summary>
    /// Dataproc Metastore.
    /// </summary>
    [pbr::OriginalName("DATAPROC_METASTORE")] DataprocMetastore = 3,
  }

  #endregion

}

#endregion Designer generated code
