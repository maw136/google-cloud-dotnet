// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/pipeline_failure_policy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/pipeline_failure_policy.proto</summary>
  public static partial class PipelineFailurePolicyReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/pipeline_failure_policy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PipelineFailurePolicyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9waXBlbGluZV9mYWlsdXJl",
            "X3BvbGljeS5wcm90bxIaZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjEqjgEK",
            "FVBpcGVsaW5lRmFpbHVyZVBvbGljeRInCiNQSVBFTElORV9GQUlMVVJFX1BP",
            "TElDWV9VTlNQRUNJRklFRBAAEiUKIVBJUEVMSU5FX0ZBSUxVUkVfUE9MSUNZ",
            "X0ZBSUxfU0xPVxABEiUKIVBJUEVMSU5FX0ZBSUxVUkVfUE9MSUNZX0ZBSUxf",
            "RkFTVBACQt4BCh5jb20uZ29vZ2xlLmNsb3VkLmFpcGxhdGZvcm0udjFCGlBp",
            "cGVsaW5lRmFpbHVyZVBvbGljeVByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvYWlwbGF0Zm9ybS92MTthaXBs",
            "YXRmb3JtqgIaR29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0uVjHKAhpHb29nbGVc",
            "Q2xvdWRcQUlQbGF0Zm9ybVxWMeoCHUdvb2dsZTo6Q2xvdWQ6OkFJUGxhdGZv",
            "cm06OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.AIPlatform.V1.PipelineFailurePolicy), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Represents the failure policy of a pipeline. Currently, the default of a
  /// pipeline is that the pipeline will continue to run until no more tasks can be
  /// executed, also known as PIPELINE_FAILURE_POLICY_FAIL_SLOW. However, if a
  /// pipeline is set to PIPELINE_FAILURE_POLICY_FAIL_FAST, it will stop scheduling
  /// any new tasks when a task has failed. Any scheduled tasks will continue to
  /// completion.
  /// </summary>
  public enum PipelineFailurePolicy {
    /// <summary>
    /// Default value, and follows fail slow behavior.
    /// </summary>
    [pbr::OriginalName("PIPELINE_FAILURE_POLICY_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Indicates that the pipeline should continue to run until all possible
    /// tasks have been scheduled and completed.
    /// </summary>
    [pbr::OriginalName("PIPELINE_FAILURE_POLICY_FAIL_SLOW")] FailSlow = 1,
    /// <summary>
    /// Indicates that the pipeline should stop scheduling new tasks after a task
    /// has failed.
    /// </summary>
    [pbr::OriginalName("PIPELINE_FAILURE_POLICY_FAIL_FAST")] FailFast = 2,
  }

  #endregion

}

#endregion Designer generated code
