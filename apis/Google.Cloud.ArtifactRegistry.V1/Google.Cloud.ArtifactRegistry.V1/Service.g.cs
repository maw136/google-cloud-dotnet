// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/devtools/artifactregistry/v1/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ArtifactRegistry.V1 {

  /// <summary>Holder for reflection information generated from google/devtools/artifactregistry/v1/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/devtools/artifactregistry/v1/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvZGV2dG9vbHMvYXJ0aWZhY3RyZWdpc3RyeS92MS9zZXJ2aWNl",
            "LnByb3RvEiNnb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MRoc",
            "Z29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGll",
            "bnQucHJvdG8aNmdvb2dsZS9kZXZ0b29scy9hcnRpZmFjdHJlZ2lzdHJ5L3Yx",
            "L2FwdF9hcnRpZmFjdC5wcm90bxoyZ29vZ2xlL2RldnRvb2xzL2FydGlmYWN0",
            "cmVnaXN0cnkvdjEvYXJ0aWZhY3QucHJvdG8aLmdvb2dsZS9kZXZ0b29scy9h",
            "cnRpZmFjdHJlZ2lzdHJ5L3YxL2ZpbGUucHJvdG8aMWdvb2dsZS9kZXZ0b29s",
            "cy9hcnRpZmFjdHJlZ2lzdHJ5L3YxL3BhY2thZ2UucHJvdG8aNGdvb2dsZS9k",
            "ZXZ0b29scy9hcnRpZmFjdHJlZ2lzdHJ5L3YxL3JlcG9zaXRvcnkucHJvdG8a",
            "Mmdvb2dsZS9kZXZ0b29scy9hcnRpZmFjdHJlZ2lzdHJ5L3YxL3NldHRpbmdz",
            "LnByb3RvGi1nb29nbGUvZGV2dG9vbHMvYXJ0aWZhY3RyZWdpc3RyeS92MS90",
            "YWcucHJvdG8aMWdvb2dsZS9kZXZ0b29scy9hcnRpZmFjdHJlZ2lzdHJ5L3Yx",
            "L3ZlcnNpb24ucHJvdG8aNmdvb2dsZS9kZXZ0b29scy9hcnRpZmFjdHJlZ2lz",
            "dHJ5L3YxL3l1bV9hcnRpZmFjdC5wcm90bxoeZ29vZ2xlL2lhbS92MS9pYW1f",
            "cG9saWN5LnByb3RvGhpnb29nbGUvaWFtL3YxL3BvbGljeS5wcm90bxojZ29v",
            "Z2xlL2xvbmdydW5uaW5nL29wZXJhdGlvbnMucHJvdG8aG2dvb2dsZS9wcm90",
            "b2J1Zi9lbXB0eS5wcm90byITChFPcGVyYXRpb25NZXRhZGF0YTK4MAoQQXJ0",
            "aWZhY3RSZWdpc3RyeRLhAQoQTGlzdERvY2tlckltYWdlcxI8Lmdvb2dsZS5k",
            "ZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkxpc3REb2NrZXJJbWFnZXNS",
            "ZXF1ZXN0Gj0uZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEu",
            "TGlzdERvY2tlckltYWdlc1Jlc3BvbnNlIlCC0+STAkESPy92MS97cGFyZW50",
            "PXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyp9L2RvY2tl",
            "ckltYWdlc9pBBnBhcmVudBLOAQoOR2V0RG9ja2VySW1hZ2USOi5nb29nbGUu",
            "ZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5HZXREb2NrZXJJbWFnZVJl",
            "cXVlc3QaMC5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5E",
            "b2NrZXJJbWFnZSJOgtPkkwJBEj8vdjEve25hbWU9cHJvamVjdHMvKi9sb2Nh",
            "dGlvbnMvKi9yZXBvc2l0b3JpZXMvKi9kb2NrZXJJbWFnZXMvKn3aQQRuYW1l",
            "EssCChJJbXBvcnRBcHRBcnRpZmFjdHMSPi5nb29nbGUuZGV2dG9vbHMuYXJ0",
            "aWZhY3RyZWdpc3RyeS52MS5JbXBvcnRBcHRBcnRpZmFjdHNSZXF1ZXN0Gh0u",
            "Z29vZ2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiLVAYLT5JMCSyJGL3YxL3tw",
            "YXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKn0v",
            "YXB0QXJ0aWZhY3RzOmltcG9ydDoBKspBgAEKPmdvb2dsZS5kZXZ0b29scy5h",
            "cnRpZmFjdHJlZ2lzdHJ5LnYxLkltcG9ydEFwdEFydGlmYWN0c1Jlc3BvbnNl",
            "Ej5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5JbXBvcnRB",
            "cHRBcnRpZmFjdHNNZXRhZGF0YRLLAgoSSW1wb3J0WXVtQXJ0aWZhY3RzEj4u",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuSW1wb3J0WXVt",
            "QXJ0aWZhY3RzUmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRp",
            "b24i1QGC0+STAksiRi92MS97cGFyZW50PXByb2plY3RzLyovbG9jYXRpb25z",
            "LyovcmVwb3NpdG9yaWVzLyp9L3l1bUFydGlmYWN0czppbXBvcnQ6ASrKQYAB",
            "Cj5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5JbXBvcnRZ",
            "dW1BcnRpZmFjdHNSZXNwb25zZRI+Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0",
            "cmVnaXN0cnkudjEuSW1wb3J0WXVtQXJ0aWZhY3RzTWV0YWRhdGES0gEKEExp",
            "c3RSZXBvc2l0b3JpZXMSPC5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdp",
            "c3RyeS52MS5MaXN0UmVwb3NpdG9yaWVzUmVxdWVzdBo9Lmdvb2dsZS5kZXZ0",
            "b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkxpc3RSZXBvc2l0b3JpZXNSZXNw",
            "b25zZSJBgtPkkwIyEjAvdjEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9u",
            "cy8qfS9yZXBvc2l0b3JpZXPaQQZwYXJlbnQSvAEKDUdldFJlcG9zaXRvcnkS",
            "OS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5HZXRSZXBv",
            "c2l0b3J5UmVxdWVzdBovLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lz",
            "dHJ5LnYxLlJlcG9zaXRvcnkiP4LT5JMCMhIwL3YxL3tuYW1lPXByb2plY3Rz",
            "LyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyp92kEEbmFtZRLCAgoQQ3Jl",
            "YXRlUmVwb3NpdG9yeRI8Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lz",
            "dHJ5LnYxLkNyZWF0ZVJlcG9zaXRvcnlSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdy",
            "dW5uaW5nLk9wZXJhdGlvbiLQAYLT5JMCPiIwL3YxL3twYXJlbnQ9cHJvamVj",
            "dHMvKi9sb2NhdGlvbnMvKn0vcmVwb3NpdG9yaWVzOgpyZXBvc2l0b3J52kEf",
            "cGFyZW50LHJlcG9zaXRvcnkscmVwb3NpdG9yeV9pZMpBZwouZ29vZ2xlLmRl",
            "dnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuUmVwb3NpdG9yeRI1Z29vZ2xl",
            "LmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuT3BlcmF0aW9uTWV0YWRh",
            "dGES6wEKEFVwZGF0ZVJlcG9zaXRvcnkSPC5nb29nbGUuZGV2dG9vbHMuYXJ0",
            "aWZhY3RyZWdpc3RyeS52MS5VcGRhdGVSZXBvc2l0b3J5UmVxdWVzdBovLmdv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLlJlcG9zaXRvcnki",
            "aILT5JMCSTI7L3YxL3tyZXBvc2l0b3J5Lm5hbWU9cHJvamVjdHMvKi9sb2Nh",
            "dGlvbnMvKi9yZXBvc2l0b3JpZXMvKn06CnJlcG9zaXRvcnnaQRZyZXBvc2l0",
            "b3J5LHVwZGF0ZV9tYXNrEoICChBEZWxldGVSZXBvc2l0b3J5EjwuZ29vZ2xl",
            "LmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuRGVsZXRlUmVwb3NpdG9y",
            "eVJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIpABgtPk",
            "kwIyKjAvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0",
            "b3JpZXMvKn3aQQRuYW1lykFOChVnb29nbGUucHJvdG9idWYuRW1wdHkSNWdv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLk9wZXJhdGlvbk1l",
            "dGFkYXRhEtEBCgxMaXN0UGFja2FnZXMSOC5nb29nbGUuZGV2dG9vbHMuYXJ0",
            "aWZhY3RyZWdpc3RyeS52MS5MaXN0UGFja2FnZXNSZXF1ZXN0GjkuZ29vZ2xl",
            "LmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuTGlzdFBhY2thZ2VzUmVz",
            "cG9uc2UiTILT5JMCPRI7L3YxL3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlv",
            "bnMvKi9yZXBvc2l0b3JpZXMvKn0vcGFja2FnZXPaQQZwYXJlbnQSvgEKCkdl",
            "dFBhY2thZ2USNi5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52",
            "MS5HZXRQYWNrYWdlUmVxdWVzdBosLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFj",
            "dHJlZ2lzdHJ5LnYxLlBhY2thZ2UiSoLT5JMCPRI7L3YxL3tuYW1lPXByb2pl",
            "Y3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyovcGFja2FnZXMvKn3a",
            "QQRuYW1lEocCCg1EZWxldGVQYWNrYWdlEjkuZ29vZ2xlLmRldnRvb2xzLmFy",
            "dGlmYWN0cmVnaXN0cnkudjEuRGVsZXRlUGFja2FnZVJlcXVlc3QaHS5nb29n",
            "bGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIpsBgtPkkwI9KjsvdjEve25hbWU9",
            "cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKi9wYWNrYWdl",
            "cy8qfdpBBG5hbWXKQU4KFWdvb2dsZS5wcm90b2J1Zi5FbXB0eRI1Z29vZ2xl",
            "LmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuT3BlcmF0aW9uTWV0YWRh",
            "dGES3AEKDExpc3RWZXJzaW9ucxI4Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFj",
            "dHJlZ2lzdHJ5LnYxLkxpc3RWZXJzaW9uc1JlcXVlc3QaOS5nb29nbGUuZGV2",
            "dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5MaXN0VmVyc2lvbnNSZXNwb25z",
            "ZSJXgtPkkwJIEkYvdjEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8q",
            "L3JlcG9zaXRvcmllcy8qL3BhY2thZ2VzLyp9L3ZlcnNpb25z2kEGcGFyZW50",
            "EskBCgpHZXRWZXJzaW9uEjYuZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVn",
            "aXN0cnkudjEuR2V0VmVyc2lvblJlcXVlc3QaLC5nb29nbGUuZGV2dG9vbHMu",
            "YXJ0aWZhY3RyZWdpc3RyeS52MS5WZXJzaW9uIlWC0+STAkgSRi92MS97bmFt",
            "ZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qL3BhY2th",
            "Z2VzLyovdmVyc2lvbnMvKn3aQQRuYW1lEpICCg1EZWxldGVWZXJzaW9uEjku",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuRGVsZXRlVmVy",
            "c2lvblJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIqYB",
            "gtPkkwJIKkYvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBv",
            "c2l0b3JpZXMvKi9wYWNrYWdlcy8qL3ZlcnNpb25zLyp92kEEbmFtZcpBTgoV",
            "Z29vZ2xlLnByb3RvYnVmLkVtcHR5EjVnb29nbGUuZGV2dG9vbHMuYXJ0aWZh",
            "Y3RyZWdpc3RyeS52MS5PcGVyYXRpb25NZXRhZGF0YRLFAQoJTGlzdEZpbGVz",
            "EjUuZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuTGlzdEZp",
            "bGVzUmVxdWVzdBo2Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5",
            "LnYxLkxpc3RGaWxlc1Jlc3BvbnNlIkmC0+STAjoSOC92MS97cGFyZW50PXBy",
            "b2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyp9L2ZpbGVz2kEG",
            "cGFyZW50ErMBCgdHZXRGaWxlEjMuZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0",
            "cmVnaXN0cnkudjEuR2V0RmlsZVJlcXVlc3QaKS5nb29nbGUuZGV2dG9vbHMu",
            "YXJ0aWZhY3RyZWdpc3RyeS52MS5GaWxlIkiC0+STAjsSOS92MS97bmFtZT1w",
            "cm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qL2ZpbGVzLyoq",
            "fdpBBG5hbWUSzAEKCExpc3RUYWdzEjQuZ29vZ2xlLmRldnRvb2xzLmFydGlm",
            "YWN0cmVnaXN0cnkudjEuTGlzdFRhZ3NSZXF1ZXN0GjUuZ29vZ2xlLmRldnRv",
            "b2xzLmFydGlmYWN0cmVnaXN0cnkudjEuTGlzdFRhZ3NSZXNwb25zZSJTgtPk",
            "kwJEEkIvdjEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9z",
            "aXRvcmllcy8qL3BhY2thZ2VzLyp9L3RhZ3PaQQZwYXJlbnQSuQEKBkdldFRh",
            "ZxIyLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkdldFRh",
            "Z1JlcXVlc3QaKC5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52",
            "MS5UYWciUYLT5JMCRBJCL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25z",
            "LyovcmVwb3NpdG9yaWVzLyovcGFja2FnZXMvKi90YWdzLyp92kEEbmFtZRLR",
            "AQoJQ3JlYXRlVGFnEjUuZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0",
            "cnkudjEuQ3JlYXRlVGFnUmVxdWVzdBooLmdvb2dsZS5kZXZ0b29scy5hcnRp",
            "ZmFjdHJlZ2lzdHJ5LnYxLlRhZyJjgtPkkwJJIkIvdjEve3BhcmVudD1wcm9q",
            "ZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qL3BhY2thZ2VzLyp9",
            "L3RhZ3M6A3RhZ9pBEXBhcmVudCx0YWcsdGFnX2lkEtMBCglVcGRhdGVUYWcS",
            "NS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5VcGRhdGVU",
            "YWdSZXF1ZXN0GiguZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnku",
            "djEuVGFnImWC0+STAk0yRi92MS97dGFnLm5hbWU9cHJvamVjdHMvKi9sb2Nh",
            "dGlvbnMvKi9yZXBvc2l0b3JpZXMvKi9wYWNrYWdlcy8qL3RhZ3MvKn06A3Rh",
            "Z9pBD3RhZyx1cGRhdGVfbWFzaxKtAQoJRGVsZXRlVGFnEjUuZ29vZ2xlLmRl",
            "dnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuRGVsZXRlVGFnUmVxdWVzdBoW",
            "Lmdvb2dsZS5wcm90b2J1Zi5FbXB0eSJRgtPkkwJEKkIvdjEve25hbWU9cHJv",
            "amVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKi9wYWNrYWdlcy8q",
            "L3RhZ3MvKn3aQQRuYW1lEpcBCgxTZXRJYW1Qb2xpY3kSIi5nb29nbGUuaWFt",
            "LnYxLlNldElhbVBvbGljeVJlcXVlc3QaFS5nb29nbGUuaWFtLnYxLlBvbGlj",
            "eSJMgtPkkwJGIkEvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25z",
            "LyovcmVwb3NpdG9yaWVzLyp9OnNldElhbVBvbGljeToBKhKUAQoMR2V0SWFt",
            "UG9saWN5EiIuZ29vZ2xlLmlhbS52MS5HZXRJYW1Qb2xpY3lSZXF1ZXN0GhUu",
            "Z29vZ2xlLmlhbS52MS5Qb2xpY3kiSYLT5JMCQxJBL3YxL3tyZXNvdXJjZT1w",
            "cm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qfTpnZXRJYW1Q",
            "b2xpY3kSvQEKElRlc3RJYW1QZXJtaXNzaW9ucxIoLmdvb2dsZS5pYW0udjEu",
            "VGVzdElhbVBlcm1pc3Npb25zUmVxdWVzdBopLmdvb2dsZS5pYW0udjEuVGVz",
            "dElhbVBlcm1pc3Npb25zUmVzcG9uc2UiUoLT5JMCTCJHL3YxL3tyZXNvdXJj",
            "ZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qfTp0ZXN0",
            "SWFtUGVybWlzc2lvbnM6ASoSwAEKEkdldFByb2plY3RTZXR0aW5ncxI+Lmdv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkdldFByb2plY3RT",
            "ZXR0aW5nc1JlcXVlc3QaNC5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdp",
            "c3RyeS52MS5Qcm9qZWN0U2V0dGluZ3MiNILT5JMCJxIlL3YxL3tuYW1lPXBy",
            "b2plY3RzLyovcHJvamVjdFNldHRpbmdzfdpBBG5hbWUSgQIKFVVwZGF0ZVBy",
            "b2plY3RTZXR0aW5ncxJBLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lz",
            "dHJ5LnYxLlVwZGF0ZVByb2plY3RTZXR0aW5nc1JlcXVlc3QaNC5nb29nbGUu",
            "ZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5Qcm9qZWN0U2V0dGluZ3Mi",
            "b4LT5JMCSjI2L3YxL3twcm9qZWN0X3NldHRpbmdzLm5hbWU9cHJvamVjdHMv",
            "Ki9wcm9qZWN0U2V0dGluZ3N9OhBwcm9qZWN0X3NldHRpbmdz2kEccHJvamVj",
            "dF9zZXR0aW5ncyx1cGRhdGVfbWFzaxqMAcpBH2FydGlmYWN0cmVnaXN0cnku",
            "Z29vZ2xlYXBpcy5jb23SQWdodHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9h",
            "dXRoL2Nsb3VkLXBsYXRmb3JtLGh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29t",
            "L2F1dGgvY2xvdWQtcGxhdGZvcm0ucmVhZC1vbmx5QvoBCidjb20uZ29vZ2xl",
            "LmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFCDFNlcnZpY2VQcm90b1AB",
            "WlNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2RldnRv",
            "b2xzL2FydGlmYWN0cmVnaXN0cnkvdjE7YXJ0aWZhY3RyZWdpc3RyeaoCIEdv",
            "b2dsZS5DbG91ZC5BcnRpZmFjdFJlZ2lzdHJ5LlYxygIgR29vZ2xlXENsb3Vk",
            "XEFydGlmYWN0UmVnaXN0cnlcVjHqAiNHb29nbGU6OkNsb3VkOjpBcnRpZmFj",
            "dFJlZ2lzdHJ5OjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.AptArtifactReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.ArtifactReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.FileReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.PackageReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.RepositoryReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.SettingsReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.TagReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.VersionReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.YumArtifactReflection.Descriptor, global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor, global::Google.Cloud.Iam.V1.PolicyReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ArtifactRegistry.V1.OperationMetadata), global::Google.Cloud.ArtifactRegistry.V1.OperationMetadata.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Metadata type for longrunning-operations, currently empty.
  /// </summary>
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
      get { return global::Google.Cloud.ArtifactRegistry.V1.ServiceReflection.Descriptor.MessageTypes[0]; }
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
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata Clone() {
      return new OperationMetadata(this);
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
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
