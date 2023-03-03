// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/accelerator_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/accelerator_type.proto</summary>
  public static partial class AcceleratorTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/accelerator_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AcceleratorTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9hY2NlbGVyYXRvcl90eXBl",
            "LnByb3RvEhpnb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MSrgAQoPQWNjZWxl",
            "cmF0b3JUeXBlEiAKHEFDQ0VMRVJBVE9SX1RZUEVfVU5TUEVDSUZJRUQQABIU",
            "ChBOVklESUFfVEVTTEFfSzgwEAESFQoRTlZJRElBX1RFU0xBX1AxMDAQAhIV",
            "ChFOVklESUFfVEVTTEFfVjEwMBADEhMKD05WSURJQV9URVNMQV9QNBAEEhMK",
            "D05WSURJQV9URVNMQV9UNBAFEhUKEU5WSURJQV9URVNMQV9BMTAwEAgSCgoG",
            "VFBVX1YyEAYSCgoGVFBVX1YzEAcSDgoKVFBVX1Y0X1BPRBAKQtIBCh5jb20u",
            "Z29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjFCFEFjY2VsZXJhdG9yVHlwZVBy",
            "b3RvUAFaPmNsb3VkLmdvb2dsZS5jb20vZ28vYWlwbGF0Zm9ybS9hcGl2MS9h",
            "aXBsYXRmb3JtcGI7YWlwbGF0Zm9ybXBiqgIaR29vZ2xlLkNsb3VkLkFJUGxh",
            "dGZvcm0uVjHKAhpHb29nbGVcQ2xvdWRcQUlQbGF0Zm9ybVxWMeoCHUdvb2ds",
            "ZTo6Q2xvdWQ6OkFJUGxhdGZvcm06OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.AIPlatform.V1.AcceleratorType), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Represents a hardware accelerator type.
  /// NEXT ID: 11.
  /// </summary>
  public enum AcceleratorType {
    /// <summary>
    /// Unspecified accelerator type, which means no accelerator.
    /// </summary>
    [pbr::OriginalName("ACCELERATOR_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Nvidia Tesla K80 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_TESLA_K80")] NvidiaTeslaK80 = 1,
    /// <summary>
    /// Nvidia Tesla P100 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_TESLA_P100")] NvidiaTeslaP100 = 2,
    /// <summary>
    /// Nvidia Tesla V100 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_TESLA_V100")] NvidiaTeslaV100 = 3,
    /// <summary>
    /// Nvidia Tesla P4 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_TESLA_P4")] NvidiaTeslaP4 = 4,
    /// <summary>
    /// Nvidia Tesla T4 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_TESLA_T4")] NvidiaTeslaT4 = 5,
    /// <summary>
    /// Nvidia Tesla A100 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_TESLA_A100")] NvidiaTeslaA100 = 8,
    /// <summary>
    /// TPU v2.
    /// </summary>
    [pbr::OriginalName("TPU_V2")] TpuV2 = 6,
    /// <summary>
    /// TPU v3.
    /// </summary>
    [pbr::OriginalName("TPU_V3")] TpuV3 = 7,
    /// <summary>
    /// TPU v4.
    /// </summary>
    [pbr::OriginalName("TPU_V4_POD")] TpuV4Pod = 10,
  }

  #endregion

}

#endregion Designer generated code
