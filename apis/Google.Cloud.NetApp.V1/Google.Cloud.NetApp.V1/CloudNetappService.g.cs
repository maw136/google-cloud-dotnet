// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/netapp/v1/cloud_netapp_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.NetApp.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/netapp/v1/cloud_netapp_service.proto</summary>
  public static partial class CloudNetappServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/netapp/v1/cloud_netapp_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CloudNetappServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvY2xvdWQvbmV0YXBwL3YxL2Nsb3VkX25ldGFwcF9zZXJ2aWNl",
            "LnByb3RvEhZnb29nbGUuY2xvdWQubmV0YXBwLnYxGhxnb29nbGUvYXBpL2Fu",
            "bm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90bxofZ29v",
            "Z2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNv",
            "dXJjZS5wcm90bxotZ29vZ2xlL2Nsb3VkL25ldGFwcC92MS9hY3RpdmVfZGly",
            "ZWN0b3J5LnByb3RvGiNnb29nbGUvY2xvdWQvbmV0YXBwL3YxL2JhY2t1cC5w",
            "cm90bxoqZ29vZ2xlL2Nsb3VkL25ldGFwcC92MS9iYWNrdXBfcG9saWN5LnBy",
            "b3RvGilnb29nbGUvY2xvdWQvbmV0YXBwL3YxL2JhY2t1cF92YXVsdC5wcm90",
            "bxogZ29vZ2xlL2Nsb3VkL25ldGFwcC92MS9rbXMucHJvdG8aKGdvb2dsZS9j",
            "bG91ZC9uZXRhcHAvdjEvcmVwbGljYXRpb24ucHJvdG8aJWdvb2dsZS9jbG91",
            "ZC9uZXRhcHAvdjEvc25hcHNob3QucHJvdG8aKWdvb2dsZS9jbG91ZC9uZXRh",
            "cHAvdjEvc3RvcmFnZV9wb29sLnByb3RvGiNnb29nbGUvY2xvdWQvbmV0YXBw",
            "L3YxL3ZvbHVtZS5wcm90bxojZ29vZ2xlL2xvbmdydW5uaW5nL29wZXJhdGlv",
            "bnMucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90bxofZ29vZ2xl",
            "L3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byKHAgoRT3BlcmF0aW9uTWV0YWRh",
            "dGESNQoLY3JlYXRlX3RpbWUYASABKAsyGi5nb29nbGUucHJvdG9idWYuVGlt",
            "ZXN0YW1wQgTiQQEDEjIKCGVuZF90aW1lGAIgASgLMhouZ29vZ2xlLnByb3Rv",
            "YnVmLlRpbWVzdGFtcEIE4kEBAxIUCgZ0YXJnZXQYAyABKAlCBOJBAQMSEgoE",
            "dmVyYhgEIAEoCUIE4kEBAxIcCg5zdGF0dXNfbWVzc2FnZRgFIAEoCUIE4kEB",
            "AxIkChZyZXF1ZXN0ZWRfY2FuY2VsbGF0aW9uGAYgASgIQgTiQQEDEhkKC2Fw",
            "aV92ZXJzaW9uGAcgASgJQgTiQQEDMuBUCgZOZXRBcHASuAEKEExpc3RTdG9y",
            "YWdlUG9vbHMSLy5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkxpc3RTdG9yYWdl",
            "UG9vbHNSZXF1ZXN0GjAuZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5MaXN0U3Rv",
            "cmFnZVBvb2xzUmVzcG9uc2UiQdpBBnBhcmVudILT5JMCMhIwL3YxL3twYXJl",
            "bnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vc3RvcmFnZVBvb2xzEvYBChFD",
            "cmVhdGVTdG9yYWdlUG9vbBIwLmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuQ3Jl",
            "YXRlU3RvcmFnZVBvb2xSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5nLk9w",
            "ZXJhdGlvbiKPAcpBIAoLU3RvcmFnZVBvb2wSEU9wZXJhdGlvbk1ldGFkYXRh",
            "2kEjcGFyZW50LHN0b3JhZ2VfcG9vbCxzdG9yYWdlX3Bvb2xfaWSC0+STAkAi",
            "MC92MS97cGFyZW50PXByb2plY3RzLyovbG9jYXRpb25zLyp9L3N0b3JhZ2VQ",
            "b29sczoMc3RvcmFnZV9wb29sEqUBCg5HZXRTdG9yYWdlUG9vbBItLmdvb2ds",
            "ZS5jbG91ZC5uZXRhcHAudjEuR2V0U3RvcmFnZVBvb2xSZXF1ZXN0GiMuZ29v",
            "Z2xlLmNsb3VkLm5ldGFwcC52MS5TdG9yYWdlUG9vbCI/2kEEbmFtZYLT5JMC",
            "MhIwL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovc3RvcmFnZVBv",
            "b2xzLyp9EvgBChFVcGRhdGVTdG9yYWdlUG9vbBIwLmdvb2dsZS5jbG91ZC5u",
            "ZXRhcHAudjEuVXBkYXRlU3RvcmFnZVBvb2xSZXF1ZXN0Gh0uZ29vZ2xlLmxv",
            "bmdydW5uaW5nLk9wZXJhdGlvbiKRAcpBIAoLU3RvcmFnZVBvb2wSEU9wZXJh",
            "dGlvbk1ldGFkYXRh2kEYc3RvcmFnZV9wb29sLHVwZGF0ZV9tYXNrgtPkkwJN",
            "Mj0vdjEve3N0b3JhZ2VfcG9vbC5uYW1lPXByb2plY3RzLyovbG9jYXRpb25z",
            "Lyovc3RvcmFnZVBvb2xzLyp9OgxzdG9yYWdlX3Bvb2wS0gEKEURlbGV0ZVN0",
            "b3JhZ2VQb29sEjAuZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5EZWxldGVTdG9y",
            "YWdlUG9vbFJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9u",
            "ImzKQSoKFWdvb2dsZS5wcm90b2J1Zi5FbXB0eRIRT3BlcmF0aW9uTWV0YWRh",
            "dGHaQQRuYW1lgtPkkwIyKjAvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlv",
            "bnMvKi9zdG9yYWdlUG9vbHMvKn0SpAEKC0xpc3RWb2x1bWVzEiouZ29vZ2xl",
            "LmNsb3VkLm5ldGFwcC52MS5MaXN0Vm9sdW1lc1JlcXVlc3QaKy5nb29nbGUu",
            "Y2xvdWQubmV0YXBwLnYxLkxpc3RWb2x1bWVzUmVzcG9uc2UiPNpBBnBhcmVu",
            "dILT5JMCLRIrL3YxL3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0v",
            "dm9sdW1lcxKRAQoJR2V0Vm9sdW1lEiguZ29vZ2xlLmNsb3VkLm5ldGFwcC52",
            "MS5HZXRWb2x1bWVSZXF1ZXN0Gh4uZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5W",
            "b2x1bWUiOtpBBG5hbWWC0+STAi0SKy92MS97bmFtZT1wcm9qZWN0cy8qL2xv",
            "Y2F0aW9ucy8qL3ZvbHVtZXMvKn0SzwEKDENyZWF0ZVZvbHVtZRIrLmdvb2ds",
            "ZS5jbG91ZC5uZXRhcHAudjEuQ3JlYXRlVm9sdW1lUmVxdWVzdBodLmdvb2ds",
            "ZS5sb25ncnVubmluZy5PcGVyYXRpb24ic8pBGwoGVm9sdW1lEhFPcGVyYXRp",
            "b25NZXRhZGF0YdpBF3BhcmVudCx2b2x1bWUsdm9sdW1lX2lkgtPkkwI1Iisv",
            "djEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS92b2x1bWVzOgZ2",
            "b2x1bWUS0QEKDFVwZGF0ZVZvbHVtZRIrLmdvb2dsZS5jbG91ZC5uZXRhcHAu",
            "djEuVXBkYXRlVm9sdW1lUmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5P",
            "cGVyYXRpb24idcpBGwoGVm9sdW1lEhFPcGVyYXRpb25NZXRhZGF0YdpBEnZv",
            "bHVtZSx1cGRhdGVfbWFza4LT5JMCPDIyL3YxL3t2b2x1bWUubmFtZT1wcm9q",
            "ZWN0cy8qL2xvY2F0aW9ucy8qL3ZvbHVtZXMvKn06BnZvbHVtZRLDAQoMRGVs",
            "ZXRlVm9sdW1lEisuZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5EZWxldGVWb2x1",
            "bWVSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiJnykEq",
            "ChVnb29nbGUucHJvdG9idWYuRW1wdHkSEU9wZXJhdGlvbk1ldGFkYXRh2kEE",
            "bmFtZYLT5JMCLSorL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyov",
            "dm9sdW1lcy8qfRK3AQoMUmV2ZXJ0Vm9sdW1lEisuZ29vZ2xlLmNsb3VkLm5l",
            "dGFwcC52MS5SZXZlcnRWb2x1bWVSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5u",
            "aW5nLk9wZXJhdGlvbiJbykEbCgZWb2x1bWUSEU9wZXJhdGlvbk1ldGFkYXRh",
            "gtPkkwI3IjIvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi92b2x1",
            "bWVzLyp9OnJldmVydDoBKhK2AQoNTGlzdFNuYXBzaG90cxIsLmdvb2dsZS5j",
            "bG91ZC5uZXRhcHAudjEuTGlzdFNuYXBzaG90c1JlcXVlc3QaLS5nb29nbGUu",
            "Y2xvdWQubmV0YXBwLnYxLkxpc3RTbmFwc2hvdHNSZXNwb25zZSJI2kEGcGFy",
            "ZW50gtPkkwI5EjcvdjEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8q",
            "L3ZvbHVtZXMvKn0vc25hcHNob3RzEqMBCgtHZXRTbmFwc2hvdBIqLmdvb2ds",
            "ZS5jbG91ZC5uZXRhcHAudjEuR2V0U25hcHNob3RSZXF1ZXN0GiAuZ29vZ2xl",
            "LmNsb3VkLm5ldGFwcC52MS5TbmFwc2hvdCJG2kEEbmFtZYLT5JMCORI3L3Yx",
            "L3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovdm9sdW1lcy8qL3NuYXBz",
            "aG90cy8qfRLoAQoOQ3JlYXRlU25hcHNob3QSLS5nb29nbGUuY2xvdWQubmV0",
            "YXBwLnYxLkNyZWF0ZVNuYXBzaG90UmVxdWVzdBodLmdvb2dsZS5sb25ncnVu",
            "bmluZy5PcGVyYXRpb24ihwHKQR0KCFNuYXBzaG90EhFPcGVyYXRpb25NZXRh",
            "ZGF0YdpBG3BhcmVudCxzbmFwc2hvdCxzbmFwc2hvdF9pZILT5JMCQyI3L3Yx",
            "L3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi92b2x1bWVzLyp9L3Nu",
            "YXBzaG90czoIc25hcHNob3QS0wEKDkRlbGV0ZVNuYXBzaG90Ei0uZ29vZ2xl",
            "LmNsb3VkLm5ldGFwcC52MS5EZWxldGVTbmFwc2hvdFJlcXVlc3QaHS5nb29n",
            "bGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uInPKQSoKFWdvb2dsZS5wcm90b2J1",
            "Zi5FbXB0eRIRT3BlcmF0aW9uTWV0YWRhdGHaQQRuYW1lgtPkkwI5KjcvdjEv",
            "e25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi92b2x1bWVzLyovc25hcHNo",
            "b3RzLyp9EuoBCg5VcGRhdGVTbmFwc2hvdBItLmdvb2dsZS5jbG91ZC5uZXRh",
            "cHAudjEuVXBkYXRlU25hcHNob3RSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5u",
            "aW5nLk9wZXJhdGlvbiKJAcpBHQoIU25hcHNob3QSEU9wZXJhdGlvbk1ldGFk",
            "YXRh2kEUc25hcHNob3QsdXBkYXRlX21hc2uC0+STAkwyQC92MS97c25hcHNo",
            "b3QubmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3ZvbHVtZXMvKi9zbmFw",
            "c2hvdHMvKn06CHNuYXBzaG90EswBChVMaXN0QWN0aXZlRGlyZWN0b3JpZXMS",
            "NC5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkxpc3RBY3RpdmVEaXJlY3Rvcmll",
            "c1JlcXVlc3QaNS5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkxpc3RBY3RpdmVE",
            "aXJlY3Rvcmllc1Jlc3BvbnNlIkbaQQZwYXJlbnSC0+STAjcSNS92MS97cGFy",
            "ZW50PXByb2plY3RzLyovbG9jYXRpb25zLyp9L2FjdGl2ZURpcmVjdG9yaWVz",
            "ErYBChJHZXRBY3RpdmVEaXJlY3RvcnkSMS5nb29nbGUuY2xvdWQubmV0YXBw",
            "LnYxLkdldEFjdGl2ZURpcmVjdG9yeVJlcXVlc3QaJy5nb29nbGUuY2xvdWQu",
            "bmV0YXBwLnYxLkFjdGl2ZURpcmVjdG9yeSJE2kEEbmFtZYLT5JMCNxI1L3Yx",
            "L3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovYWN0aXZlRGlyZWN0b3Jp",
            "ZXMvKn0SkwIKFUNyZWF0ZUFjdGl2ZURpcmVjdG9yeRI0Lmdvb2dsZS5jbG91",
            "ZC5uZXRhcHAudjEuQ3JlYXRlQWN0aXZlRGlyZWN0b3J5UmVxdWVzdBodLmdv",
            "b2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24ipAHKQSQKD0FjdGl2ZURpcmVj",
            "dG9yeRIRT3BlcmF0aW9uTWV0YWRhdGHaQStwYXJlbnQsYWN0aXZlX2RpcmVj",
            "dG9yeSxhY3RpdmVfZGlyZWN0b3J5X2lkgtPkkwJJIjUvdjEve3BhcmVudD1w",
            "cm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9hY3RpdmVEaXJlY3RvcmllczoQYWN0",
            "aXZlX2RpcmVjdG9yeRKVAgoVVXBkYXRlQWN0aXZlRGlyZWN0b3J5EjQuZ29v",
            "Z2xlLmNsb3VkLm5ldGFwcC52MS5VcGRhdGVBY3RpdmVEaXJlY3RvcnlSZXF1",
            "ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiKmAcpBJAoPQWN0",
            "aXZlRGlyZWN0b3J5EhFPcGVyYXRpb25NZXRhZGF0YdpBHGFjdGl2ZV9kaXJl",
            "Y3RvcnksdXBkYXRlX21hc2uC0+STAloyRi92MS97YWN0aXZlX2RpcmVjdG9y",
            "eS5uYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovYWN0aXZlRGlyZWN0b3Jp",
            "ZXMvKn06EGFjdGl2ZV9kaXJlY3RvcnkS3wEKFURlbGV0ZUFjdGl2ZURpcmVj",
            "dG9yeRI0Lmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuRGVsZXRlQWN0aXZlRGly",
            "ZWN0b3J5UmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24i",
            "ccpBKgoVZ29vZ2xlLnByb3RvYnVmLkVtcHR5EhFPcGVyYXRpb25NZXRhZGF0",
            "YdpBBG5hbWWC0+STAjcqNS92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9u",
            "cy8qL2FjdGl2ZURpcmVjdG9yaWVzLyp9ErABCg5MaXN0S21zQ29uZmlncxIt",
            "Lmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuTGlzdEttc0NvbmZpZ3NSZXF1ZXN0",
            "Gi4uZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5MaXN0S21zQ29uZmlnc1Jlc3Bv",
            "bnNlIj/aQQZwYXJlbnSC0+STAjASLi92MS97cGFyZW50PXByb2plY3RzLyov",
            "bG9jYXRpb25zLyp9L2ttc0NvbmZpZ3MS6AEKD0NyZWF0ZUttc0NvbmZpZxIu",
            "Lmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuQ3JlYXRlS21zQ29uZmlnUmVxdWVz",
            "dBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24ihQHKQR4KCUttc0Nv",
            "bmZpZxIRT3BlcmF0aW9uTWV0YWRhdGHaQR9wYXJlbnQsa21zX2NvbmZpZyxr",
            "bXNfY29uZmlnX2lkgtPkkwI8Ii4vdjEve3BhcmVudD1wcm9qZWN0cy8qL2xv",
            "Y2F0aW9ucy8qfS9rbXNDb25maWdzOgprbXNfY29uZmlnEp0BCgxHZXRLbXND",
            "b25maWcSKy5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkdldEttc0NvbmZpZ1Jl",
            "cXVlc3QaIS5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkttc0NvbmZpZyI92kEE",
            "bmFtZYLT5JMCMBIuL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyov",
            "a21zQ29uZmlncy8qfRLqAQoPVXBkYXRlS21zQ29uZmlnEi4uZ29vZ2xlLmNs",
            "b3VkLm5ldGFwcC52MS5VcGRhdGVLbXNDb25maWdSZXF1ZXN0Gh0uZ29vZ2xl",
            "LmxvbmdydW5uaW5nLk9wZXJhdGlvbiKHAcpBHgoJS21zQ29uZmlnEhFPcGVy",
            "YXRpb25NZXRhZGF0YdpBFmttc19jb25maWcsdXBkYXRlX21hc2uC0+STAkcy",
            "OS92MS97a21zX2NvbmZpZy5uYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyov",
            "a21zQ29uZmlncy8qfToKa21zX2NvbmZpZxLCAQoORW5jcnlwdFZvbHVtZXMS",
            "LS5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkVuY3J5cHRWb2x1bWVzUmVxdWVz",
            "dBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24iYspBHgoJS21zQ29u",
            "ZmlnEhFPcGVyYXRpb25NZXRhZGF0YYLT5JMCOyI2L3YxL3tuYW1lPXByb2pl",
            "Y3RzLyovbG9jYXRpb25zLyova21zQ29uZmlncy8qfTplbmNyeXB0OgEqErQB",
            "Cg9WZXJpZnlLbXNDb25maWcSLi5nb29nbGUuY2xvdWQubmV0YXBwLnYxLlZl",
            "cmlmeUttc0NvbmZpZ1JlcXVlc3QaLy5nb29nbGUuY2xvdWQubmV0YXBwLnYx",
            "LlZlcmlmeUttc0NvbmZpZ1Jlc3BvbnNlIkCC0+STAjoiNS92MS97bmFtZT1w",
            "cm9qZWN0cy8qL2xvY2F0aW9ucy8qL2ttc0NvbmZpZ3MvKn06dmVyaWZ5OgEq",
            "EswBCg9EZWxldGVLbXNDb25maWcSLi5nb29nbGUuY2xvdWQubmV0YXBwLnYx",
            "LkRlbGV0ZUttc0NvbmZpZ1JlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcu",
            "T3BlcmF0aW9uImrKQSoKFWdvb2dsZS5wcm90b2J1Zi5FbXB0eRIRT3BlcmF0",
            "aW9uTWV0YWRhdGHaQQRuYW1lgtPkkwIwKi4vdjEve25hbWU9cHJvamVjdHMv",
            "Ki9sb2NhdGlvbnMvKi9rbXNDb25maWdzLyp9EsIBChBMaXN0UmVwbGljYXRp",
            "b25zEi8uZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5MaXN0UmVwbGljYXRpb25z",
            "UmVxdWVzdBowLmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuTGlzdFJlcGxpY2F0",
            "aW9uc1Jlc3BvbnNlIkvaQQZwYXJlbnSC0+STAjwSOi92MS97cGFyZW50PXBy",
            "b2plY3RzLyovbG9jYXRpb25zLyovdm9sdW1lcy8qfS9yZXBsaWNhdGlvbnMS",
            "rwEKDkdldFJlcGxpY2F0aW9uEi0uZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5H",
            "ZXRSZXBsaWNhdGlvblJlcXVlc3QaIy5nb29nbGUuY2xvdWQubmV0YXBwLnYx",
            "LlJlcGxpY2F0aW9uIknaQQRuYW1lgtPkkwI8EjovdjEve25hbWU9cHJvamVj",
            "dHMvKi9sb2NhdGlvbnMvKi92b2x1bWVzLyovcmVwbGljYXRpb25zLyp9Ev0B",
            "ChFDcmVhdGVSZXBsaWNhdGlvbhIwLmdvb2dsZS5jbG91ZC5uZXRhcHAudjEu",
            "Q3JlYXRlUmVwbGljYXRpb25SZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5n",
            "Lk9wZXJhdGlvbiKWAcpBIAoLUmVwbGljYXRpb24SEU9wZXJhdGlvbk1ldGFk",
            "YXRh2kEhcGFyZW50LHJlcGxpY2F0aW9uLHJlcGxpY2F0aW9uX2lkgtPkkwJJ",
            "IjovdjEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3ZvbHVtZXMv",
            "Kn0vcmVwbGljYXRpb25zOgtyZXBsaWNhdGlvbhLcAQoRRGVsZXRlUmVwbGlj",
            "YXRpb24SMC5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkRlbGV0ZVJlcGxpY2F0",
            "aW9uUmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24idspB",
            "KgoVZ29vZ2xlLnByb3RvYnVmLkVtcHR5EhFPcGVyYXRpb25NZXRhZGF0YdpB",
            "BG5hbWWC0+STAjwqOi92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8q",
            "L3ZvbHVtZXMvKi9yZXBsaWNhdGlvbnMvKn0S/wEKEVVwZGF0ZVJlcGxpY2F0",
            "aW9uEjAuZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5VcGRhdGVSZXBsaWNhdGlv",
            "blJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIpgBykEg",
            "CgtSZXBsaWNhdGlvbhIRT3BlcmF0aW9uTWV0YWRhdGHaQRdyZXBsaWNhdGlv",
            "bix1cGRhdGVfbWFza4LT5JMCVTJGL3YxL3tyZXBsaWNhdGlvbi5uYW1lPXBy",
            "b2plY3RzLyovbG9jYXRpb25zLyovdm9sdW1lcy8qL3JlcGxpY2F0aW9ucy8q",
            "fToLcmVwbGljYXRpb24SzwEKD1N0b3BSZXBsaWNhdGlvbhIuLmdvb2dsZS5j",
            "bG91ZC5uZXRhcHAudjEuU3RvcFJlcGxpY2F0aW9uUmVxdWVzdBodLmdvb2ds",
            "ZS5sb25ncnVubmluZy5PcGVyYXRpb24ibcpBIAoLUmVwbGljYXRpb24SEU9w",
            "ZXJhdGlvbk1ldGFkYXRhgtPkkwJEIj8vdjEve25hbWU9cHJvamVjdHMvKi9s",
            "b2NhdGlvbnMvKi92b2x1bWVzLyovcmVwbGljYXRpb25zLyp9OnN0b3A6ASoS",
            "1QEKEVJlc3VtZVJlcGxpY2F0aW9uEjAuZ29vZ2xlLmNsb3VkLm5ldGFwcC52",
            "MS5SZXN1bWVSZXBsaWNhdGlvblJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5p",
            "bmcuT3BlcmF0aW9uIm/KQSAKC1JlcGxpY2F0aW9uEhFPcGVyYXRpb25NZXRh",
            "ZGF0YYLT5JMCRiJBL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyov",
            "dm9sdW1lcy8qL3JlcGxpY2F0aW9ucy8qfTpyZXN1bWU6ASoS8wEKG1JldmVy",
            "c2VSZXBsaWNhdGlvbkRpcmVjdGlvbhI6Lmdvb2dsZS5jbG91ZC5uZXRhcHAu",
            "djEuUmV2ZXJzZVJlcGxpY2F0aW9uRGlyZWN0aW9uUmVxdWVzdBodLmdvb2ds",
            "ZS5sb25ncnVubmluZy5PcGVyYXRpb24iecpBIAoLUmVwbGljYXRpb24SEU9w",
            "ZXJhdGlvbk1ldGFkYXRhgtPkkwJQIksvdjEve25hbWU9cHJvamVjdHMvKi9s",
            "b2NhdGlvbnMvKi92b2x1bWVzLyovcmVwbGljYXRpb25zLyp9OnJldmVyc2VE",
            "aXJlY3Rpb246ASoS9gEKEUNyZWF0ZUJhY2t1cFZhdWx0EjAuZ29vZ2xlLmNs",
            "b3VkLm5ldGFwcC52MS5DcmVhdGVCYWNrdXBWYXVsdFJlcXVlc3QaHS5nb29n",
            "bGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIo8BykEgCgtCYWNrdXBWYXVsdBIR",
            "T3BlcmF0aW9uTWV0YWRhdGHaQSNwYXJlbnQsYmFja3VwX3ZhdWx0LGJhY2t1",
            "cF92YXVsdF9pZILT5JMCQCIwL3YxL3twYXJlbnQ9cHJvamVjdHMvKi9sb2Nh",
            "dGlvbnMvKn0vYmFja3VwVmF1bHRzOgxiYWNrdXBfdmF1bHQSpQEKDkdldEJh",
            "Y2t1cFZhdWx0Ei0uZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5HZXRCYWNrdXBW",
            "YXVsdFJlcXVlc3QaIy5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkJhY2t1cFZh",
            "dWx0Ij/aQQRuYW1lgtPkkwIyEjAvdjEve25hbWU9cHJvamVjdHMvKi9sb2Nh",
            "dGlvbnMvKi9iYWNrdXBWYXVsdHMvKn0SuAEKEExpc3RCYWNrdXBWYXVsdHMS",
            "Ly5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkxpc3RCYWNrdXBWYXVsdHNSZXF1",
            "ZXN0GjAuZ29vZ2xlLmNsb3VkLm5ldGFwcC52MS5MaXN0QmFja3VwVmF1bHRz",
            "UmVzcG9uc2UiQdpBBnBhcmVudILT5JMCMhIwL3YxL3twYXJlbnQ9cHJvamVj",
            "dHMvKi9sb2NhdGlvbnMvKn0vYmFja3VwVmF1bHRzEvgBChFVcGRhdGVCYWNr",
            "dXBWYXVsdBIwLmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuVXBkYXRlQmFja3Vw",
            "VmF1bHRSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiKR",
            "AcpBIAoLQmFja3VwVmF1bHQSEU9wZXJhdGlvbk1ldGFkYXRh2kEYYmFja3Vw",
            "X3ZhdWx0LHVwZGF0ZV9tYXNrgtPkkwJNMj0vdjEve2JhY2t1cF92YXVsdC5u",
            "YW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovYmFja3VwVmF1bHRzLyp9Ogxi",
            "YWNrdXBfdmF1bHQS0gEKEURlbGV0ZUJhY2t1cFZhdWx0EjAuZ29vZ2xlLmNs",
            "b3VkLm5ldGFwcC52MS5EZWxldGVCYWNrdXBWYXVsdFJlcXVlc3QaHS5nb29n",
            "bGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uImzKQSoKFWdvb2dsZS5wcm90b2J1",
            "Zi5FbXB0eRIRT3BlcmF0aW9uTWV0YWRhdGHaQQRuYW1lgtPkkwIyKjAvdjEv",
            "e25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9iYWNrdXBWYXVsdHMvKn0S",
            "3wEKDENyZWF0ZUJhY2t1cBIrLmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuQ3Jl",
            "YXRlQmFja3VwUmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRp",
            "b24iggHKQRsKBkJhY2t1cBIRT3BlcmF0aW9uTWV0YWRhdGHaQRdwYXJlbnQs",
            "YmFja3VwLGJhY2t1cF9pZILT5JMCRCI6L3YxL3twYXJlbnQ9cHJvamVjdHMv",
            "Ki9sb2NhdGlvbnMvKi9iYWNrdXBWYXVsdHMvKn0vYmFja3VwczoGYmFja3Vw",
            "EqABCglHZXRCYWNrdXASKC5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkdldEJh",
            "Y2t1cFJlcXVlc3QaHi5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkJhY2t1cCJJ",
            "2kEEbmFtZYLT5JMCPBI6L3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25z",
            "LyovYmFja3VwVmF1bHRzLyovYmFja3Vwcy8qfRKzAQoLTGlzdEJhY2t1cHMS",
            "Ki5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkxpc3RCYWNrdXBzUmVxdWVzdBor",
            "Lmdvb2dsZS5jbG91ZC5uZXRhcHAudjEuTGlzdEJhY2t1cHNSZXNwb25zZSJL",
            "2kEGcGFyZW50gtPkkwI8EjovdjEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0",
            "aW9ucy8qL2JhY2t1cFZhdWx0cy8qfS9iYWNrdXBzEtIBCgxEZWxldGVCYWNr",
            "dXASKy5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkRlbGV0ZUJhY2t1cFJlcXVl",
            "c3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uInbKQSoKFWdvb2ds",
            "ZS5wcm90b2J1Zi5FbXB0eRIRT3BlcmF0aW9uTWV0YWRhdGHaQQRuYW1lgtPk",
            "kwI8KjovdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9iYWNrdXBW",
            "YXVsdHMvKi9iYWNrdXBzLyp9EuEBCgxVcGRhdGVCYWNrdXASKy5nb29nbGUu",
            "Y2xvdWQubmV0YXBwLnYxLlVwZGF0ZUJhY2t1cFJlcXVlc3QaHS5nb29nbGUu",
            "bG9uZ3J1bm5pbmcuT3BlcmF0aW9uIoQBykEbCgZCYWNrdXASEU9wZXJhdGlv",
            "bk1ldGFkYXRh2kESYmFja3VwLHVwZGF0ZV9tYXNrgtPkkwJLMkEvdjEve2Jh",
            "Y2t1cC5uYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovYmFja3VwVmF1bHRz",
            "LyovYmFja3Vwcy8qfToGYmFja3VwEv4BChJDcmVhdGVCYWNrdXBQb2xpY3kS",
            "MS5nb29nbGUuY2xvdWQubmV0YXBwLnYxLkNyZWF0ZUJhY2t1cFBvbGljeVJl",
            "cXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIpUBykEhCgxC",
            "YWNrdXBQb2xpY3kSEU9wZXJhdGlvbk1ldGFkYXRh2kElcGFyZW50LGJhY2t1",
            "cF9wb2xpY3ksYmFja3VwX3BvbGljeV9pZILT5JMCQyIyL3YxL3twYXJlbnQ9",
            "cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vYmFja3VwUG9saWNpZXM6DWJhY2t1",
            "cF9wb2xpY3kSqgEKD0dldEJhY2t1cFBvbGljeRIuLmdvb2dsZS5jbG91ZC5u",
            "ZXRhcHAudjEuR2V0QmFja3VwUG9saWN5UmVxdWVzdBokLmdvb2dsZS5jbG91",
            "ZC5uZXRhcHAudjEuQmFja3VwUG9saWN5IkHaQQRuYW1lgtPkkwI0EjIvdjEv",
            "e25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9iYWNrdXBQb2xpY2llcy8q",
            "fRLAAQoSTGlzdEJhY2t1cFBvbGljaWVzEjEuZ29vZ2xlLmNsb3VkLm5ldGFw",
            "cC52MS5MaXN0QmFja3VwUG9saWNpZXNSZXF1ZXN0GjIuZ29vZ2xlLmNsb3Vk",
            "Lm5ldGFwcC52MS5MaXN0QmFja3VwUG9saWNpZXNSZXNwb25zZSJD2kEGcGFy",
            "ZW50gtPkkwI0EjIvdjEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8q",
            "fS9iYWNrdXBQb2xpY2llcxKAAgoSVXBkYXRlQmFja3VwUG9saWN5EjEuZ29v",
            "Z2xlLmNsb3VkLm5ldGFwcC52MS5VcGRhdGVCYWNrdXBQb2xpY3lSZXF1ZXN0",
            "Gh0uZ29vZ2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiKXAcpBIQoMQmFja3Vw",
            "UG9saWN5EhFPcGVyYXRpb25NZXRhZGF0YdpBGWJhY2t1cF9wb2xpY3ksdXBk",
            "YXRlX21hc2uC0+STAlEyQC92MS97YmFja3VwX3BvbGljeS5uYW1lPXByb2pl",
            "Y3RzLyovbG9jYXRpb25zLyovYmFja3VwUG9saWNpZXMvKn06DWJhY2t1cF9w",
            "b2xpY3kS1gEKEkRlbGV0ZUJhY2t1cFBvbGljeRIxLmdvb2dsZS5jbG91ZC5u",
            "ZXRhcHAudjEuRGVsZXRlQmFja3VwUG9saWN5UmVxdWVzdBodLmdvb2dsZS5s",
            "b25ncnVubmluZy5PcGVyYXRpb24ibspBKgoVZ29vZ2xlLnByb3RvYnVmLkVt",
            "cHR5EhFPcGVyYXRpb25NZXRhZGF0YdpBBG5hbWWC0+STAjQqMi92MS97bmFt",
            "ZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2JhY2t1cFBvbGljaWVzLyp9GknK",
            "QRVuZXRhcHAuZ29vZ2xlYXBpcy5jb23SQS5odHRwczovL3d3dy5nb29nbGVh",
            "cGlzLmNvbS9hdXRoL2Nsb3VkLXBsYXRmb3JtQooCChpjb20uZ29vZ2xlLmNs",
            "b3VkLm5ldGFwcC52MUIXQ2xvdWROZXRhcHBTZXJ2aWNlUHJvdG9QAVoyY2xv",
            "dWQuZ29vZ2xlLmNvbS9nby9uZXRhcHAvYXBpdjEvbmV0YXBwcGI7bmV0YXBw",
            "cGKqAhZHb29nbGUuQ2xvdWQuTmV0QXBwLlYxygIWR29vZ2xlXENsb3VkXE5l",
            "dEFwcFxWMeoCGUdvb2dsZTo6Q2xvdWQ6Ok5ldEFwcDo6VjHqQU4KHmNvbXB1",
            "dGUuZ29vZ2xlYXBpcy5jb20vTmV0d29yaxIscHJvamVjdHMve3Byb2plY3R9",
            "L2dsb2JhbC9uZXR3b3Jrcy97bmV0d29ya31iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.NetApp.V1.ActiveDirectoryReflection.Descriptor, global::Google.Cloud.NetApp.V1.BackupReflection.Descriptor, global::Google.Cloud.NetApp.V1.BackupPolicyReflection.Descriptor, global::Google.Cloud.NetApp.V1.BackupVaultReflection.Descriptor, global::Google.Cloud.NetApp.V1.KmsReflection.Descriptor, global::Google.Cloud.NetApp.V1.ReplicationReflection.Descriptor, global::Google.Cloud.NetApp.V1.SnapshotReflection.Descriptor, global::Google.Cloud.NetApp.V1.StoragePoolReflection.Descriptor, global::Google.Cloud.NetApp.V1.VolumeReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.NetApp.V1.OperationMetadata), global::Google.Cloud.NetApp.V1.OperationMetadata.Parser, new[]{ "CreateTime", "EndTime", "Target", "Verb", "StatusMessage", "RequestedCancellation", "ApiVersion" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents the metadata of the long-running operation.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OperationMetadata : pb::IMessage<OperationMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OperationMetadata> _parser = new pb::MessageParser<OperationMetadata>(() => new OperationMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OperationMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.NetApp.V1.CloudNetappServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata(OperationMetadata other) : this() {
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      endTime_ = other.endTime_ != null ? other.endTime_.Clone() : null;
      target_ = other.target_;
      verb_ = other.verb_;
      statusMessage_ = other.statusMessage_;
      requestedCancellation_ = other.requestedCancellation_;
      apiVersion_ = other.apiVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata Clone() {
      return new OperationMetadata(this);
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The time the operation was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    /// Output only. The time the operation finished running.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 3;
    private string target_ = "";
    /// <summary>
    /// Output only. Server-defined resource path for the target of the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Target {
      get { return target_; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "verb" field.</summary>
    public const int VerbFieldNumber = 4;
    private string verb_ = "";
    /// <summary>
    /// Output only. Name of the verb executed by the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Verb {
      get { return verb_; }
      set {
        verb_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status_message" field.</summary>
    public const int StatusMessageFieldNumber = 5;
    private string statusMessage_ = "";
    /// <summary>
    /// Output only. Human-readable status of the operation, if any.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StatusMessage {
      get { return statusMessage_; }
      set {
        statusMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "requested_cancellation" field.</summary>
    public const int RequestedCancellationFieldNumber = 6;
    private bool requestedCancellation_;
    /// <summary>
    /// Output only. Identifies whether the user has requested cancellation
    /// of the operation. Operations that have been canceled successfully
    /// have [Operation.error][] value with a
    /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
    /// `Code.CANCELLED`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool RequestedCancellation {
      get { return requestedCancellation_; }
      set {
        requestedCancellation_ = value;
      }
    }

    /// <summary>Field number for the "api_version" field.</summary>
    public const int ApiVersionFieldNumber = 7;
    private string apiVersion_ = "";
    /// <summary>
    /// Output only. API version used to start the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ApiVersion {
      get { return apiVersion_; }
      set {
        apiVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OperationMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OperationMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      if (Target != other.Target) return false;
      if (Verb != other.Verb) return false;
      if (StatusMessage != other.StatusMessage) return false;
      if (RequestedCancellation != other.RequestedCancellation) return false;
      if (ApiVersion != other.ApiVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
      if (Target.Length != 0) hash ^= Target.GetHashCode();
      if (Verb.Length != 0) hash ^= Verb.GetHashCode();
      if (StatusMessage.Length != 0) hash ^= StatusMessage.GetHashCode();
      if (RequestedCancellation != false) hash ^= RequestedCancellation.GetHashCode();
      if (ApiVersion.Length != 0) hash ^= ApiVersion.GetHashCode();
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
      if (createTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreateTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EndTime);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Target);
      }
      if (Verb.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Verb);
      }
      if (StatusMessage.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StatusMessage);
      }
      if (RequestedCancellation != false) {
        output.WriteRawTag(48);
        output.WriteBool(RequestedCancellation);
      }
      if (ApiVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ApiVersion);
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
      if (createTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreateTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EndTime);
      }
      if (Target.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Target);
      }
      if (Verb.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Verb);
      }
      if (StatusMessage.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StatusMessage);
      }
      if (RequestedCancellation != false) {
        output.WriteRawTag(48);
        output.WriteBool(RequestedCancellation);
      }
      if (ApiVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ApiVersion);
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
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
      }
      if (Target.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Target);
      }
      if (Verb.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Verb);
      }
      if (StatusMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatusMessage);
      }
      if (RequestedCancellation != false) {
        size += 1 + 1;
      }
      if (ApiVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OperationMetadata other) {
      if (other == null) {
        return;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.endTime_ != null) {
        if (endTime_ == null) {
          EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndTime.MergeFrom(other.EndTime);
      }
      if (other.Target.Length != 0) {
        Target = other.Target;
      }
      if (other.Verb.Length != 0) {
        Verb = other.Verb;
      }
      if (other.StatusMessage.Length != 0) {
        StatusMessage = other.StatusMessage;
      }
      if (other.RequestedCancellation != false) {
        RequestedCancellation = other.RequestedCancellation;
      }
      if (other.ApiVersion.Length != 0) {
        ApiVersion = other.ApiVersion;
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
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 18: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 26: {
            Target = input.ReadString();
            break;
          }
          case 34: {
            Verb = input.ReadString();
            break;
          }
          case 42: {
            StatusMessage = input.ReadString();
            break;
          }
          case 48: {
            RequestedCancellation = input.ReadBool();
            break;
          }
          case 58: {
            ApiVersion = input.ReadString();
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
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 18: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 26: {
            Target = input.ReadString();
            break;
          }
          case 34: {
            Verb = input.ReadString();
            break;
          }
          case 42: {
            StatusMessage = input.ReadString();
            break;
          }
          case 48: {
            RequestedCancellation = input.ReadBool();
            break;
          }
          case 58: {
            ApiVersion = input.ReadString();
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
