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
            "dHJ5L3YxL3ZwY3NjX2NvbmZpZy5wcm90bxo2Z29vZ2xlL2RldnRvb2xzL2Fy",
            "dGlmYWN0cmVnaXN0cnkvdjEveXVtX2FydGlmYWN0LnByb3RvGh5nb29nbGUv",
            "aWFtL3YxL2lhbV9wb2xpY3kucHJvdG8aGmdvb2dsZS9pYW0vdjEvcG9saWN5",
            "LnByb3RvGiNnb29nbGUvbG9uZ3J1bm5pbmcvb3BlcmF0aW9ucy5wcm90bxob",
            "Z29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvIhMKEU9wZXJhdGlvbk1ldGFk",
            "YXRhMqI+ChBBcnRpZmFjdFJlZ2lzdHJ5EuEBChBMaXN0RG9ja2VySW1hZ2Vz",
            "EjwuZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuTGlzdERv",
            "Y2tlckltYWdlc1JlcXVlc3QaPS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3Ry",
            "ZWdpc3RyeS52MS5MaXN0RG9ja2VySW1hZ2VzUmVzcG9uc2UiUILT5JMCQRI/",
            "L3YxL3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3Jp",
            "ZXMvKn0vZG9ja2VySW1hZ2Vz2kEGcGFyZW50Es4BCg5HZXREb2NrZXJJbWFn",
            "ZRI6Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkdldERv",
            "Y2tlckltYWdlUmVxdWVzdBowLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJl",
            "Z2lzdHJ5LnYxLkRvY2tlckltYWdlIk6C0+STAkESPy92MS97bmFtZT1wcm9q",
            "ZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qL2RvY2tlckltYWdl",
            "cy8qfdpBBG5hbWUS6QEKEkxpc3RNYXZlbkFydGlmYWN0cxI+Lmdvb2dsZS5k",
            "ZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkxpc3RNYXZlbkFydGlmYWN0",
            "c1JlcXVlc3QaPy5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52",
            "MS5MaXN0TWF2ZW5BcnRpZmFjdHNSZXNwb25zZSJSgtPkkwJDEkEvdjEve3Bh",
            "cmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qfS9t",
            "YXZlbkFydGlmYWN0c9pBBnBhcmVudBLWAQoQR2V0TWF2ZW5BcnRpZmFjdBI8",
            "Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkdldE1hdmVu",
            "QXJ0aWZhY3RSZXF1ZXN0GjIuZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVn",
            "aXN0cnkudjEuTWF2ZW5BcnRpZmFjdCJQgtPkkwJDEkEvdjEve25hbWU9cHJv",
            "amVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKi9tYXZlbkFydGlm",
            "YWN0cy8qfdpBBG5hbWUS3QEKD0xpc3ROcG1QYWNrYWdlcxI7Lmdvb2dsZS5k",
            "ZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkxpc3ROcG1QYWNrYWdlc1Jl",
            "cXVlc3QaPC5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5M",
            "aXN0TnBtUGFja2FnZXNSZXNwb25zZSJPgtPkkwJAEj4vdjEve3BhcmVudD1w",
            "cm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qfS9ucG1QYWNr",
            "YWdlc9pBBnBhcmVudBLKAQoNR2V0TnBtUGFja2FnZRI5Lmdvb2dsZS5kZXZ0",
            "b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkdldE5wbVBhY2thZ2VSZXF1ZXN0",
            "Gi8uZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuTnBtUGFj",
            "a2FnZSJNgtPkkwJAEj4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMv",
            "Ki9yZXBvc2l0b3JpZXMvKi9ucG1QYWNrYWdlcy8qfdpBBG5hbWUS6QEKEkxp",
            "c3RQeXRob25QYWNrYWdlcxI+Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJl",
            "Z2lzdHJ5LnYxLkxpc3RQeXRob25QYWNrYWdlc1JlcXVlc3QaPy5nb29nbGUu",
            "ZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5MaXN0UHl0aG9uUGFja2Fn",
            "ZXNSZXNwb25zZSJSgtPkkwJDEkEvdjEve3BhcmVudD1wcm9qZWN0cy8qL2xv",
            "Y2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qfS9weXRob25QYWNrYWdlc9pBBnBh",
            "cmVudBLWAQoQR2V0UHl0aG9uUGFja2FnZRI8Lmdvb2dsZS5kZXZ0b29scy5h",
            "cnRpZmFjdHJlZ2lzdHJ5LnYxLkdldFB5dGhvblBhY2thZ2VSZXF1ZXN0GjIu",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuUHl0aG9uUGFj",
            "a2FnZSJQgtPkkwJDEkEvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMv",
            "Ki9yZXBvc2l0b3JpZXMvKi9weXRob25QYWNrYWdlcy8qfdpBBG5hbWUSywIK",
            "EkltcG9ydEFwdEFydGlmYWN0cxI+Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFj",
            "dHJlZ2lzdHJ5LnYxLkltcG9ydEFwdEFydGlmYWN0c1JlcXVlc3QaHS5nb29n",
            "bGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uItUBgtPkkwJLIkYvdjEve3BhcmVu",
            "dD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qfS9hcHRB",
            "cnRpZmFjdHM6aW1wb3J0OgEqykGAAQo+Z29vZ2xlLmRldnRvb2xzLmFydGlm",
            "YWN0cmVnaXN0cnkudjEuSW1wb3J0QXB0QXJ0aWZhY3RzUmVzcG9uc2USPmdv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkltcG9ydEFwdEFy",
            "dGlmYWN0c01ldGFkYXRhEssCChJJbXBvcnRZdW1BcnRpZmFjdHMSPi5nb29n",
            "bGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5JbXBvcnRZdW1BcnRp",
            "ZmFjdHNSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiLV",
            "AYLT5JMCSyJGL3YxL3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9y",
            "ZXBvc2l0b3JpZXMvKn0veXVtQXJ0aWZhY3RzOmltcG9ydDoBKspBgAEKPmdv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkltcG9ydFl1bUFy",
            "dGlmYWN0c1Jlc3BvbnNlEj5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdp",
            "c3RyeS52MS5JbXBvcnRZdW1BcnRpZmFjdHNNZXRhZGF0YRLSAQoQTGlzdFJl",
            "cG9zaXRvcmllcxI8Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5",
            "LnYxLkxpc3RSZXBvc2l0b3JpZXNSZXF1ZXN0Gj0uZ29vZ2xlLmRldnRvb2xz",
            "LmFydGlmYWN0cmVnaXN0cnkudjEuTGlzdFJlcG9zaXRvcmllc1Jlc3BvbnNl",
            "IkGC0+STAjISMC92MS97cGFyZW50PXByb2plY3RzLyovbG9jYXRpb25zLyp9",
            "L3JlcG9zaXRvcmllc9pBBnBhcmVudBK8AQoNR2V0UmVwb3NpdG9yeRI5Lmdv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkdldFJlcG9zaXRv",
            "cnlSZXF1ZXN0Gi8uZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnku",
            "djEuUmVwb3NpdG9yeSI/gtPkkwIyEjAvdjEve25hbWU9cHJvamVjdHMvKi9s",
            "b2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKn3aQQRuYW1lEsICChBDcmVhdGVS",
            "ZXBvc2l0b3J5EjwuZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnku",
            "djEuQ3JlYXRlUmVwb3NpdG9yeVJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5p",
            "bmcuT3BlcmF0aW9uItABgtPkkwI+IjAvdjEve3BhcmVudD1wcm9qZWN0cy8q",
            "L2xvY2F0aW9ucy8qfS9yZXBvc2l0b3JpZXM6CnJlcG9zaXRvcnnaQR9wYXJl",
            "bnQscmVwb3NpdG9yeSxyZXBvc2l0b3J5X2lkykFnCi5nb29nbGUuZGV2dG9v",
            "bHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5SZXBvc2l0b3J5EjVnb29nbGUuZGV2",
            "dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5PcGVyYXRpb25NZXRhZGF0YRLr",
            "AQoQVXBkYXRlUmVwb3NpdG9yeRI8Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFj",
            "dHJlZ2lzdHJ5LnYxLlVwZGF0ZVJlcG9zaXRvcnlSZXF1ZXN0Gi8uZ29vZ2xl",
            "LmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuUmVwb3NpdG9yeSJogtPk",
            "kwJJMjsvdjEve3JlcG9zaXRvcnkubmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9u",
            "cy8qL3JlcG9zaXRvcmllcy8qfToKcmVwb3NpdG9yedpBFnJlcG9zaXRvcnks",
            "dXBkYXRlX21hc2sSggIKEERlbGV0ZVJlcG9zaXRvcnkSPC5nb29nbGUuZGV2",
            "dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5EZWxldGVSZXBvc2l0b3J5UmVx",
            "dWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24ikAGC0+STAjIq",
            "MC92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmll",
            "cy8qfdpBBG5hbWXKQU4KFWdvb2dsZS5wcm90b2J1Zi5FbXB0eRI1Z29vZ2xl",
            "LmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuT3BlcmF0aW9uTWV0YWRh",
            "dGES0QEKDExpc3RQYWNrYWdlcxI4Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFj",
            "dHJlZ2lzdHJ5LnYxLkxpc3RQYWNrYWdlc1JlcXVlc3QaOS5nb29nbGUuZGV2",
            "dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5MaXN0UGFja2FnZXNSZXNwb25z",
            "ZSJMgtPkkwI9EjsvdjEve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8q",
            "L3JlcG9zaXRvcmllcy8qfS9wYWNrYWdlc9pBBnBhcmVudBK+AQoKR2V0UGFj",
            "a2FnZRI2Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkdl",
            "dFBhY2thZ2VSZXF1ZXN0GiwuZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVn",
            "aXN0cnkudjEuUGFja2FnZSJKgtPkkwI9EjsvdjEve25hbWU9cHJvamVjdHMv",
            "Ki9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKi9wYWNrYWdlcy8qfdpBBG5h",
            "bWUShwIKDURlbGV0ZVBhY2thZ2USOS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZh",
            "Y3RyZWdpc3RyeS52MS5EZWxldGVQYWNrYWdlUmVxdWVzdBodLmdvb2dsZS5s",
            "b25ncnVubmluZy5PcGVyYXRpb24imwGC0+STAj0qOy92MS97bmFtZT1wcm9q",
            "ZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qL3BhY2thZ2VzLyp9",
            "2kEEbmFtZcpBTgoVZ29vZ2xlLnByb3RvYnVmLkVtcHR5EjVnb29nbGUuZGV2",
            "dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5PcGVyYXRpb25NZXRhZGF0YRLc",
            "AQoMTGlzdFZlcnNpb25zEjguZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVn",
            "aXN0cnkudjEuTGlzdFZlcnNpb25zUmVxdWVzdBo5Lmdvb2dsZS5kZXZ0b29s",
            "cy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkxpc3RWZXJzaW9uc1Jlc3BvbnNlIleC",
            "0+STAkgSRi92MS97cGFyZW50PXByb2plY3RzLyovbG9jYXRpb25zLyovcmVw",
            "b3NpdG9yaWVzLyovcGFja2FnZXMvKn0vdmVyc2lvbnPaQQZwYXJlbnQSyQEK",
            "CkdldFZlcnNpb24SNi5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3Ry",
            "eS52MS5HZXRWZXJzaW9uUmVxdWVzdBosLmdvb2dsZS5kZXZ0b29scy5hcnRp",
            "ZmFjdHJlZ2lzdHJ5LnYxLlZlcnNpb24iVYLT5JMCSBJGL3YxL3tuYW1lPXBy",
            "b2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyovcGFja2FnZXMv",
            "Ki92ZXJzaW9ucy8qfdpBBG5hbWUSkgIKDURlbGV0ZVZlcnNpb24SOS5nb29n",
            "bGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5EZWxldGVWZXJzaW9u",
            "UmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24ipgGC0+ST",
            "AkgqRi92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRv",
            "cmllcy8qL3BhY2thZ2VzLyovdmVyc2lvbnMvKn3aQQRuYW1lykFOChVnb29n",
            "bGUucHJvdG9idWYuRW1wdHkSNWdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJl",
            "Z2lzdHJ5LnYxLk9wZXJhdGlvbk1ldGFkYXRhEsUBCglMaXN0RmlsZXMSNS5n",
            "b29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5MaXN0RmlsZXNS",
            "ZXF1ZXN0GjYuZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEu",
            "TGlzdEZpbGVzUmVzcG9uc2UiSYLT5JMCOhI4L3YxL3twYXJlbnQ9cHJvamVj",
            "dHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKn0vZmlsZXPaQQZwYXJl",
            "bnQSswEKB0dldEZpbGUSMy5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdp",
            "c3RyeS52MS5HZXRGaWxlUmVxdWVzdBopLmdvb2dsZS5kZXZ0b29scy5hcnRp",
            "ZmFjdHJlZ2lzdHJ5LnYxLkZpbGUiSILT5JMCOxI5L3YxL3tuYW1lPXByb2pl",
            "Y3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyovZmlsZXMvKip92kEE",
            "bmFtZRLMAQoITGlzdFRhZ3MSNC5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3Ry",
            "ZWdpc3RyeS52MS5MaXN0VGFnc1JlcXVlc3QaNS5nb29nbGUuZGV2dG9vbHMu",
            "YXJ0aWZhY3RyZWdpc3RyeS52MS5MaXN0VGFnc1Jlc3BvbnNlIlOC0+STAkQS",
            "Qi92MS97cGFyZW50PXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9y",
            "aWVzLyovcGFja2FnZXMvKn0vdGFnc9pBBnBhcmVudBK5AQoGR2V0VGFnEjIu",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuR2V0VGFnUmVx",
            "dWVzdBooLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLlRh",
            "ZyJRgtPkkwJEEkIvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9y",
            "ZXBvc2l0b3JpZXMvKi9wYWNrYWdlcy8qL3RhZ3MvKn3aQQRuYW1lEtEBCglD",
            "cmVhdGVUYWcSNS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52",
            "MS5DcmVhdGVUYWdSZXF1ZXN0GiguZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0",
            "cmVnaXN0cnkudjEuVGFnImOC0+STAkkiQi92MS97cGFyZW50PXByb2plY3Rz",
            "LyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyovcGFja2FnZXMvKn0vdGFn",
            "czoDdGFn2kERcGFyZW50LHRhZyx0YWdfaWQS0wEKCVVwZGF0ZVRhZxI1Lmdv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLlVwZGF0ZVRhZ1Jl",
            "cXVlc3QaKC5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5U",
            "YWciZYLT5JMCTTJGL3YxL3t0YWcubmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9u",
            "cy8qL3JlcG9zaXRvcmllcy8qL3BhY2thZ2VzLyovdGFncy8qfToDdGFn2kEP",
            "dGFnLHVwZGF0ZV9tYXNrEq0BCglEZWxldGVUYWcSNS5nb29nbGUuZGV2dG9v",
            "bHMuYXJ0aWZhY3RyZWdpc3RyeS52MS5EZWxldGVUYWdSZXF1ZXN0GhYuZ29v",
            "Z2xlLnByb3RvYnVmLkVtcHR5IlGC0+STAkQqQi92MS97bmFtZT1wcm9qZWN0",
            "cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qL3BhY2thZ2VzLyovdGFn",
            "cy8qfdpBBG5hbWUSlwEKDFNldElhbVBvbGljeRIiLmdvb2dsZS5pYW0udjEu",
            "U2V0SWFtUG9saWN5UmVxdWVzdBoVLmdvb2dsZS5pYW0udjEuUG9saWN5IkyC",
            "0+STAkYiQS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9y",
            "ZXBvc2l0b3JpZXMvKn06c2V0SWFtUG9saWN5OgEqEpQBCgxHZXRJYW1Qb2xp",
            "Y3kSIi5nb29nbGUuaWFtLnYxLkdldElhbVBvbGljeVJlcXVlc3QaFS5nb29n",
            "bGUuaWFtLnYxLlBvbGljeSJJgtPkkwJDEkEvdjEve3Jlc291cmNlPXByb2pl",
            "Y3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyp9OmdldElhbVBvbGlj",
            "eRK9AQoSVGVzdElhbVBlcm1pc3Npb25zEiguZ29vZ2xlLmlhbS52MS5UZXN0",
            "SWFtUGVybWlzc2lvbnNSZXF1ZXN0GikuZ29vZ2xlLmlhbS52MS5UZXN0SWFt",
            "UGVybWlzc2lvbnNSZXNwb25zZSJSgtPkkwJMIkcvdjEve3Jlc291cmNlPXBy",
            "b2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyp9OnRlc3RJYW1Q",
            "ZXJtaXNzaW9uczoBKhLAAQoSR2V0UHJvamVjdFNldHRpbmdzEj4uZ29vZ2xl",
            "LmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEuR2V0UHJvamVjdFNldHRp",
            "bmdzUmVxdWVzdBo0Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5",
            "LnYxLlByb2plY3RTZXR0aW5ncyI0gtPkkwInEiUvdjEve25hbWU9cHJvamVj",
            "dHMvKi9wcm9qZWN0U2V0dGluZ3N92kEEbmFtZRKBAgoVVXBkYXRlUHJvamVj",
            "dFNldHRpbmdzEkEuZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnku",
            "djEuVXBkYXRlUHJvamVjdFNldHRpbmdzUmVxdWVzdBo0Lmdvb2dsZS5kZXZ0",
            "b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLlByb2plY3RTZXR0aW5ncyJvgtPk",
            "kwJKMjYvdjEve3Byb2plY3Rfc2V0dGluZ3MubmFtZT1wcm9qZWN0cy8qL3By",
            "b2plY3RTZXR0aW5nc306EHByb2plY3Rfc2V0dGluZ3PaQRxwcm9qZWN0X3Nl",
            "dHRpbmdzLHVwZGF0ZV9tYXNrErwBCg5HZXRWUENTQ0NvbmZpZxI6Lmdvb2ds",
            "ZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxLkdldFZQQ1NDQ29uZmln",
            "UmVxdWVzdBowLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYx",
            "LlZQQ1NDQ29uZmlnIjyC0+STAi8SLS92MS97bmFtZT1wcm9qZWN0cy8qL2xv",
            "Y2F0aW9ucy8qL3ZwY3NjQ29uZmlnfdpBBG5hbWUS8QEKEVVwZGF0ZVZQQ1ND",
            "Q29uZmlnEj0uZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjEu",
            "VXBkYXRlVlBDU0NDb25maWdSZXF1ZXN0GjAuZ29vZ2xlLmRldnRvb2xzLmFy",
            "dGlmYWN0cmVnaXN0cnkudjEuVlBDU0NDb25maWcia4LT5JMCSjI6L3YxL3t2",
            "cGNzY19jb25maWcubmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3ZwY3Nj",
            "Q29uZmlnfToMdnBjc2NfY29uZmln2kEYdnBjc2NfY29uZmlnLHVwZGF0ZV9t",
            "YXNrGowBykEfYXJ0aWZhY3RyZWdpc3RyeS5nb29nbGVhcGlzLmNvbdJBZ2h0",
            "dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvY2xvdWQtcGxhdGZvcm0s",
            "aHR0cHM6Ly93d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9jbG91ZC1wbGF0Zm9y",
            "bS5yZWFkLW9ubHlC9wEKJ2NvbS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3Ry",
            "ZWdpc3RyeS52MUIMU2VydmljZVByb3RvUAFaUGNsb3VkLmdvb2dsZS5jb20v",
            "Z28vYXJ0aWZhY3RyZWdpc3RyeS9hcGl2MS9hcnRpZmFjdHJlZ2lzdHJ5cGI7",
            "YXJ0aWZhY3RyZWdpc3RyeXBiqgIgR29vZ2xlLkNsb3VkLkFydGlmYWN0UmVn",
            "aXN0cnkuVjHKAiBHb29nbGVcQ2xvdWRcQXJ0aWZhY3RSZWdpc3RyeVxWMeoC",
            "I0dvb2dsZTo6Q2xvdWQ6OkFydGlmYWN0UmVnaXN0cnk6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.AptArtifactReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.ArtifactReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.FileReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.PackageReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.RepositoryReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.SettingsReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.TagReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.VersionReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.VpcscConfigReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1.YumArtifactReflection.Descriptor, global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor, global::Google.Cloud.Iam.V1.PolicyReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
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
