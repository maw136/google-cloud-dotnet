// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/iam/credentials/v1/iamcredentials.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Iam.Credentials.V1 {

  /// <summary>Holder for reflection information generated from google/iam/credentials/v1/iamcredentials.proto</summary>
  public static partial class IamcredentialsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/iam/credentials/v1/iamcredentials.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IamcredentialsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvaWFtL2NyZWRlbnRpYWxzL3YxL2lhbWNyZWRlbnRpYWxzLnBy",
            "b3RvEhlnb29nbGUuaWFtLmNyZWRlbnRpYWxzLnYxGhxnb29nbGUvYXBpL2Fu",
            "bm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90bxomZ29v",
            "Z2xlL2lhbS9jcmVkZW50aWFscy92MS9jb21tb24ucHJvdG8yrQcKDklBTUNy",
            "ZWRlbnRpYWxzEuwBChNHZW5lcmF0ZUFjY2Vzc1Rva2VuEjUuZ29vZ2xlLmlh",
            "bS5jcmVkZW50aWFscy52MS5HZW5lcmF0ZUFjY2Vzc1Rva2VuUmVxdWVzdBo2",
            "Lmdvb2dsZS5pYW0uY3JlZGVudGlhbHMudjEuR2VuZXJhdGVBY2Nlc3NUb2tl",
            "blJlc3BvbnNlImbaQR1uYW1lLGRlbGVnYXRlcyxzY29wZSxsaWZldGltZYLT",
            "5JMCQCI7L3YxL3tuYW1lPXByb2plY3RzLyovc2VydmljZUFjY291bnRzLyp9",
            "OmdlbmVyYXRlQWNjZXNzVG9rZW46ASoS5AEKD0dlbmVyYXRlSWRUb2tlbhIx",
            "Lmdvb2dsZS5pYW0uY3JlZGVudGlhbHMudjEuR2VuZXJhdGVJZFRva2VuUmVx",
            "dWVzdBoyLmdvb2dsZS5pYW0uY3JlZGVudGlhbHMudjEuR2VuZXJhdGVJZFRv",
            "a2VuUmVzcG9uc2UiatpBJW5hbWUsZGVsZWdhdGVzLGF1ZGllbmNlLGluY2x1",
            "ZGVfZW1haWyC0+STAjwiNy92MS97bmFtZT1wcm9qZWN0cy8qL3NlcnZpY2VB",
            "Y2NvdW50cy8qfTpnZW5lcmF0ZUlkVG9rZW46ASoSuQEKCFNpZ25CbG9iEiou",
            "Z29vZ2xlLmlhbS5jcmVkZW50aWFscy52MS5TaWduQmxvYlJlcXVlc3QaKy5n",
            "b29nbGUuaWFtLmNyZWRlbnRpYWxzLnYxLlNpZ25CbG9iUmVzcG9uc2UiVNpB",
            "Fm5hbWUsZGVsZWdhdGVzLHBheWxvYWSC0+STAjUiMC92MS97bmFtZT1wcm9q",
            "ZWN0cy8qL3NlcnZpY2VBY2NvdW50cy8qfTpzaWduQmxvYjoBKhK1AQoHU2ln",
            "bkp3dBIpLmdvb2dsZS5pYW0uY3JlZGVudGlhbHMudjEuU2lnbkp3dFJlcXVl",
            "c3QaKi5nb29nbGUuaWFtLmNyZWRlbnRpYWxzLnYxLlNpZ25Kd3RSZXNwb25z",
            "ZSJT2kEWbmFtZSxkZWxlZ2F0ZXMscGF5bG9hZILT5JMCNCIvL3YxL3tuYW1l",
            "PXByb2plY3RzLyovc2VydmljZUFjY291bnRzLyp9OnNpZ25Kd3Q6ASoaUcpB",
            "HWlhbWNyZWRlbnRpYWxzLmdvb2dsZWFwaXMuY29t0kEuaHR0cHM6Ly93d3cu",
            "Z29vZ2xlYXBpcy5jb20vYXV0aC9jbG91ZC1wbGF0Zm9ybULKAQojY29tLmdv",
            "b2dsZS5jbG91ZC5pYW0uY3JlZGVudGlhbHMudjFCE0lBTUNyZWRlbnRpYWxz",
            "UHJvdG9QAVpFY2xvdWQuZ29vZ2xlLmNvbS9nby9pYW0vY3JlZGVudGlhbHMv",
            "YXBpdjEvY3JlZGVudGlhbHNwYjtjcmVkZW50aWFsc3Bi+AEBqgIfR29vZ2xl",
            "LkNsb3VkLklhbS5DcmVkZW50aWFscy5WMcoCH0dvb2dsZVxDbG91ZFxJYW1c",
            "Q3JlZGVudGlhbHNcVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Cloud.Iam.Credentials.V1.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
