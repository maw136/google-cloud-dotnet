// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/networksecurity/v1beta1/network_security.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.NetworkSecurity.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/networksecurity/v1beta1/network_security.proto</summary>
  public static partial class NetworkSecurityReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/networksecurity/v1beta1/network_security.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NetworkSecurityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvY2xvdWQvbmV0d29ya3NlY3VyaXR5L3YxYmV0YTEvbmV0d29y",
            "a19zZWN1cml0eS5wcm90bxIkZ29vZ2xlLmNsb3VkLm5ldHdvcmtzZWN1cml0",
            "eS52MWJldGExGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhdnb29n",
            "bGUvYXBpL2NsaWVudC5wcm90bxo/Z29vZ2xlL2Nsb3VkL25ldHdvcmtzZWN1",
            "cml0eS92MWJldGExL2F1dGhvcml6YXRpb25fcG9saWN5LnByb3RvGjxnb29n",
            "bGUvY2xvdWQvbmV0d29ya3NlY3VyaXR5L3YxYmV0YTEvY2xpZW50X3Rsc19w",
            "b2xpY3kucHJvdG8aPGdvb2dsZS9jbG91ZC9uZXR3b3Jrc2VjdXJpdHkvdjFi",
            "ZXRhMS9zZXJ2ZXJfdGxzX3BvbGljeS5wcm90bxojZ29vZ2xlL2xvbmdydW5u",
            "aW5nL29wZXJhdGlvbnMucHJvdG8y3iIKD05ldHdvcmtTZWN1cml0eRL9AQoZ",
            "TGlzdEF1dGhvcml6YXRpb25Qb2xpY2llcxJGLmdvb2dsZS5jbG91ZC5uZXR3",
            "b3Jrc2VjdXJpdHkudjFiZXRhMS5MaXN0QXV0aG9yaXphdGlvblBvbGljaWVz",
            "UmVxdWVzdBpHLmdvb2dsZS5jbG91ZC5uZXR3b3Jrc2VjdXJpdHkudjFiZXRh",
            "MS5MaXN0QXV0aG9yaXphdGlvblBvbGljaWVzUmVzcG9uc2UiT4LT5JMCQBI+",
            "L3YxYmV0YTEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9hdXRo",
            "b3JpemF0aW9uUG9saWNpZXPaQQZwYXJlbnQS5wEKFkdldEF1dGhvcml6YXRp",
            "b25Qb2xpY3kSQy5nb29nbGUuY2xvdWQubmV0d29ya3NlY3VyaXR5LnYxYmV0",
            "YTEuR2V0QXV0aG9yaXphdGlvblBvbGljeVJlcXVlc3QaOS5nb29nbGUuY2xv",
            "dWQubmV0d29ya3NlY3VyaXR5LnYxYmV0YTEuQXV0aG9yaXphdGlvblBvbGlj",
            "eSJNgtPkkwJAEj4vdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9u",
            "cy8qL2F1dGhvcml6YXRpb25Qb2xpY2llcy8qfdpBBG5hbWUS5wIKGUNyZWF0",
            "ZUF1dGhvcml6YXRpb25Qb2xpY3kSRi5nb29nbGUuY2xvdWQubmV0d29ya3Nl",
            "Y3VyaXR5LnYxYmV0YTEuQ3JlYXRlQXV0aG9yaXphdGlvblBvbGljeVJlcXVl",
            "c3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIuIBgtPkkwJWIj4v",
            "djFiZXRhMS97cGFyZW50PXByb2plY3RzLyovbG9jYXRpb25zLyp9L2F1dGhv",
            "cml6YXRpb25Qb2xpY2llczoUYXV0aG9yaXphdGlvbl9wb2xpY3naQTNwYXJl",
            "bnQsYXV0aG9yaXphdGlvbl9wb2xpY3ksYXV0aG9yaXphdGlvbl9wb2xpY3lf",
            "aWTKQU0KE0F1dGhvcml6YXRpb25Qb2xpY3kSNmdvb2dsZS5jbG91ZC5uZXR3",
            "b3Jrc2VjdXJpdHkudjFiZXRhMS5PcGVyYXRpb25NZXRhZGF0YRLpAgoZVXBk",
            "YXRlQXV0aG9yaXphdGlvblBvbGljeRJGLmdvb2dsZS5jbG91ZC5uZXR3b3Jr",
            "c2VjdXJpdHkudjFiZXRhMS5VcGRhdGVBdXRob3JpemF0aW9uUG9saWN5UmVx",
            "dWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24i5AGC0+STAmsy",
            "Uy92MWJldGExL3thdXRob3JpemF0aW9uX3BvbGljeS5uYW1lPXByb2plY3Rz",
            "LyovbG9jYXRpb25zLyovYXV0aG9yaXphdGlvblBvbGljaWVzLyp9OhRhdXRo",
            "b3JpemF0aW9uX3BvbGljedpBIGF1dGhvcml6YXRpb25fcG9saWN5LHVwZGF0",
            "ZV9tYXNrykFNChNBdXRob3JpemF0aW9uUG9saWN5EjZnb29nbGUuY2xvdWQu",
            "bmV0d29ya3NlY3VyaXR5LnYxYmV0YTEuT3BlcmF0aW9uTWV0YWRhdGESpAIK",
            "GURlbGV0ZUF1dGhvcml6YXRpb25Qb2xpY3kSRi5nb29nbGUuY2xvdWQubmV0",
            "d29ya3NlY3VyaXR5LnYxYmV0YTEuRGVsZXRlQXV0aG9yaXphdGlvblBvbGlj",
            "eVJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIp8BgtPk",
            "kwJAKj4vdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2F1",
            "dGhvcml6YXRpb25Qb2xpY2llcy8qfdpBBG5hbWXKQU8KFWdvb2dsZS5wcm90",
            "b2J1Zi5FbXB0eRI2Z29vZ2xlLmNsb3VkLm5ldHdvcmtzZWN1cml0eS52MWJl",
            "dGExLk9wZXJhdGlvbk1ldGFkYXRhEu0BChVMaXN0U2VydmVyVGxzUG9saWNp",
            "ZXMSQi5nb29nbGUuY2xvdWQubmV0d29ya3NlY3VyaXR5LnYxYmV0YTEuTGlz",
            "dFNlcnZlclRsc1BvbGljaWVzUmVxdWVzdBpDLmdvb2dsZS5jbG91ZC5uZXR3",
            "b3Jrc2VjdXJpdHkudjFiZXRhMS5MaXN0U2VydmVyVGxzUG9saWNpZXNSZXNw",
            "b25zZSJLgtPkkwI8EjovdjFiZXRhMS97cGFyZW50PXByb2plY3RzLyovbG9j",
            "YXRpb25zLyp9L3NlcnZlclRsc1BvbGljaWVz2kEGcGFyZW50EtcBChJHZXRT",
            "ZXJ2ZXJUbHNQb2xpY3kSPy5nb29nbGUuY2xvdWQubmV0d29ya3NlY3VyaXR5",
            "LnYxYmV0YTEuR2V0U2VydmVyVGxzUG9saWN5UmVxdWVzdBo1Lmdvb2dsZS5j",
            "bG91ZC5uZXR3b3Jrc2VjdXJpdHkudjFiZXRhMS5TZXJ2ZXJUbHNQb2xpY3ki",
            "SYLT5JMCPBI6L3YxYmV0YTEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMv",
            "Ki9zZXJ2ZXJUbHNQb2xpY2llcy8qfdpBBG5hbWUSzgIKFUNyZWF0ZVNlcnZl",
            "clRsc1BvbGljeRJCLmdvb2dsZS5jbG91ZC5uZXR3b3Jrc2VjdXJpdHkudjFi",
            "ZXRhMS5DcmVhdGVTZXJ2ZXJUbHNQb2xpY3lSZXF1ZXN0Gh0uZ29vZ2xlLmxv",
            "bmdydW5uaW5nLk9wZXJhdGlvbiLRAYLT5JMCTyI6L3YxYmV0YTEve3BhcmVu",
            "dD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9zZXJ2ZXJUbHNQb2xpY2llczoR",
            "c2VydmVyX3Rsc19wb2xpY3naQS1wYXJlbnQsc2VydmVyX3Rsc19wb2xpY3ks",
            "c2VydmVyX3Rsc19wb2xpY3lfaWTKQUkKD1NlcnZlclRsc1BvbGljeRI2Z29v",
            "Z2xlLmNsb3VkLm5ldHdvcmtzZWN1cml0eS52MWJldGExLk9wZXJhdGlvbk1l",
            "dGFkYXRhEtACChVVcGRhdGVTZXJ2ZXJUbHNQb2xpY3kSQi5nb29nbGUuY2xv",
            "dWQubmV0d29ya3NlY3VyaXR5LnYxYmV0YTEuVXBkYXRlU2VydmVyVGxzUG9s",
            "aWN5UmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24i0wGC",
            "0+STAmEyTC92MWJldGExL3tzZXJ2ZXJfdGxzX3BvbGljeS5uYW1lPXByb2pl",
            "Y3RzLyovbG9jYXRpb25zLyovc2VydmVyVGxzUG9saWNpZXMvKn06EXNlcnZl",
            "cl90bHNfcG9saWN52kEdc2VydmVyX3Rsc19wb2xpY3ksdXBkYXRlX21hc2vK",
            "QUkKD1NlcnZlclRsc1BvbGljeRI2Z29vZ2xlLmNsb3VkLm5ldHdvcmtzZWN1",
            "cml0eS52MWJldGExLk9wZXJhdGlvbk1ldGFkYXRhEpgCChVEZWxldGVTZXJ2",
            "ZXJUbHNQb2xpY3kSQi5nb29nbGUuY2xvdWQubmV0d29ya3NlY3VyaXR5LnYx",
            "YmV0YTEuRGVsZXRlU2VydmVyVGxzUG9saWN5UmVxdWVzdBodLmdvb2dsZS5s",
            "b25ncnVubmluZy5PcGVyYXRpb24imwGC0+STAjwqOi92MWJldGExL3tuYW1l",
            "PXByb2plY3RzLyovbG9jYXRpb25zLyovc2VydmVyVGxzUG9saWNpZXMvKn3a",
            "QQRuYW1lykFPChVnb29nbGUucHJvdG9idWYuRW1wdHkSNmdvb2dsZS5jbG91",
            "ZC5uZXR3b3Jrc2VjdXJpdHkudjFiZXRhMS5PcGVyYXRpb25NZXRhZGF0YRLt",
            "AQoVTGlzdENsaWVudFRsc1BvbGljaWVzEkIuZ29vZ2xlLmNsb3VkLm5ldHdv",
            "cmtzZWN1cml0eS52MWJldGExLkxpc3RDbGllbnRUbHNQb2xpY2llc1JlcXVl",
            "c3QaQy5nb29nbGUuY2xvdWQubmV0d29ya3NlY3VyaXR5LnYxYmV0YTEuTGlz",
            "dENsaWVudFRsc1BvbGljaWVzUmVzcG9uc2UiS4LT5JMCPBI6L3YxYmV0YTEv",
            "e3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9jbGllbnRUbHNQb2xp",
            "Y2llc9pBBnBhcmVudBLXAQoSR2V0Q2xpZW50VGxzUG9saWN5Ej8uZ29vZ2xl",
            "LmNsb3VkLm5ldHdvcmtzZWN1cml0eS52MWJldGExLkdldENsaWVudFRsc1Bv",
            "bGljeVJlcXVlc3QaNS5nb29nbGUuY2xvdWQubmV0d29ya3NlY3VyaXR5LnYx",
            "YmV0YTEuQ2xpZW50VGxzUG9saWN5IkmC0+STAjwSOi92MWJldGExL3tuYW1l",
            "PXByb2plY3RzLyovbG9jYXRpb25zLyovY2xpZW50VGxzUG9saWNpZXMvKn3a",
            "QQRuYW1lEs4CChVDcmVhdGVDbGllbnRUbHNQb2xpY3kSQi5nb29nbGUuY2xv",
            "dWQubmV0d29ya3NlY3VyaXR5LnYxYmV0YTEuQ3JlYXRlQ2xpZW50VGxzUG9s",
            "aWN5UmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24i0QGC",
            "0+STAk8iOi92MWJldGExL3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMv",
            "Kn0vY2xpZW50VGxzUG9saWNpZXM6EWNsaWVudF90bHNfcG9saWN52kEtcGFy",
            "ZW50LGNsaWVudF90bHNfcG9saWN5LGNsaWVudF90bHNfcG9saWN5X2lkykFJ",
            "Cg9DbGllbnRUbHNQb2xpY3kSNmdvb2dsZS5jbG91ZC5uZXR3b3Jrc2VjdXJp",
            "dHkudjFiZXRhMS5PcGVyYXRpb25NZXRhZGF0YRLQAgoVVXBkYXRlQ2xpZW50",
            "VGxzUG9saWN5EkIuZ29vZ2xlLmNsb3VkLm5ldHdvcmtzZWN1cml0eS52MWJl",
            "dGExLlVwZGF0ZUNsaWVudFRsc1BvbGljeVJlcXVlc3QaHS5nb29nbGUubG9u",
            "Z3J1bm5pbmcuT3BlcmF0aW9uItMBgtPkkwJhMkwvdjFiZXRhMS97Y2xpZW50",
            "X3Rsc19wb2xpY3kubmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NsaWVu",
            "dFRsc1BvbGljaWVzLyp9OhFjbGllbnRfdGxzX3BvbGljedpBHWNsaWVudF90",
            "bHNfcG9saWN5LHVwZGF0ZV9tYXNrykFJCg9DbGllbnRUbHNQb2xpY3kSNmdv",
            "b2dsZS5jbG91ZC5uZXR3b3Jrc2VjdXJpdHkudjFiZXRhMS5PcGVyYXRpb25N",
            "ZXRhZGF0YRKYAgoVRGVsZXRlQ2xpZW50VGxzUG9saWN5EkIuZ29vZ2xlLmNs",
            "b3VkLm5ldHdvcmtzZWN1cml0eS52MWJldGExLkRlbGV0ZUNsaWVudFRsc1Bv",
            "bGljeVJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIpsB",
            "gtPkkwI8KjovdjFiZXRhMS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8q",
            "L2NsaWVudFRsc1BvbGljaWVzLyp92kEEbmFtZcpBTwoVZ29vZ2xlLnByb3Rv",
            "YnVmLkVtcHR5EjZnb29nbGUuY2xvdWQubmV0d29ya3NlY3VyaXR5LnYxYmV0",
            "YTEuT3BlcmF0aW9uTWV0YWRhdGEaUspBHm5ldHdvcmtzZWN1cml0eS5nb29n",
            "bGVhcGlzLmNvbdJBLmh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgv",
            "Y2xvdWQtcGxhdGZvcm1C+QEKKGNvbS5nb29nbGUuY2xvdWQubmV0d29ya3Nl",
            "Y3VyaXR5LnYxYmV0YTFQAVpTZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9jbG91ZC9uZXR3b3Jrc2VjdXJpdHkvdjFiZXRhMTtuZXR3",
            "b3Jrc2VjdXJpdHmqAiRHb29nbGUuQ2xvdWQuTmV0d29ya1NlY3VyaXR5LlYx",
            "QmV0YTHKAiRHb29nbGVcQ2xvdWRcTmV0d29ya1NlY3VyaXR5XFYxYmV0YTHq",
            "AidHb29nbGU6OkNsb3VkOjpOZXR3b3JrU2VjdXJpdHk6OlYxYmV0YTFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Cloud.NetworkSecurity.V1Beta1.AuthorizationPolicyReflection.Descriptor, global::Google.Cloud.NetworkSecurity.V1Beta1.ClientTlsPolicyReflection.Descriptor, global::Google.Cloud.NetworkSecurity.V1Beta1.ServerTlsPolicyReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
