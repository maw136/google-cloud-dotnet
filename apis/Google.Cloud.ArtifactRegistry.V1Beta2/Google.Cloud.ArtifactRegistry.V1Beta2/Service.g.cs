// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/devtools/artifactregistry/v1beta2/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ArtifactRegistry.V1Beta2 {

  /// <summary>Holder for reflection information generated from google/devtools/artifactregistry/v1beta2/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/devtools/artifactregistry/v1beta2/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvZGV2dG9vbHMvYXJ0aWZhY3RyZWdpc3RyeS92MWJldGEyL3Nl",
            "cnZpY2UucHJvdG8SKGdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5",
            "LnYxYmV0YTIaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aF2dvb2ds",
            "ZS9hcGkvY2xpZW50LnByb3RvGjtnb29nbGUvZGV2dG9vbHMvYXJ0aWZhY3Ry",
            "ZWdpc3RyeS92MWJldGEyL2FwdF9hcnRpZmFjdC5wcm90bxozZ29vZ2xlL2Rl",
            "dnRvb2xzL2FydGlmYWN0cmVnaXN0cnkvdjFiZXRhMi9maWxlLnByb3RvGjZn",
            "b29nbGUvZGV2dG9vbHMvYXJ0aWZhY3RyZWdpc3RyeS92MWJldGEyL3BhY2th",
            "Z2UucHJvdG8aOWdvb2dsZS9kZXZ0b29scy9hcnRpZmFjdHJlZ2lzdHJ5L3Yx",
            "YmV0YTIvcmVwb3NpdG9yeS5wcm90bxo3Z29vZ2xlL2RldnRvb2xzL2FydGlm",
            "YWN0cmVnaXN0cnkvdjFiZXRhMi9zZXR0aW5ncy5wcm90bxoyZ29vZ2xlL2Rl",
            "dnRvb2xzL2FydGlmYWN0cmVnaXN0cnkvdjFiZXRhMi90YWcucHJvdG8aNmdv",
            "b2dsZS9kZXZ0b29scy9hcnRpZmFjdHJlZ2lzdHJ5L3YxYmV0YTIvdmVyc2lv",
            "bi5wcm90bxo7Z29vZ2xlL2RldnRvb2xzL2FydGlmYWN0cmVnaXN0cnkvdjFi",
            "ZXRhMi95dW1fYXJ0aWZhY3QucHJvdG8aHmdvb2dsZS9pYW0vdjEvaWFtX3Bv",
            "bGljeS5wcm90bxoaZ29vZ2xlL2lhbS92MS9wb2xpY3kucHJvdG8aI2dvb2ds",
            "ZS9sb25ncnVubmluZy9vcGVyYXRpb25zLnByb3RvGhtnb29nbGUvcHJvdG9i",
            "dWYvZW1wdHkucHJvdG8iEwoRT3BlcmF0aW9uTWV0YWRhdGEy5i8KEEFydGlm",
            "YWN0UmVnaXN0cnkS3wIKEkltcG9ydEFwdEFydGlmYWN0cxJDLmdvb2dsZS5k",
            "ZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuSW1wb3J0QXB0QXJ0",
            "aWZhY3RzUmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24i",
            "5AHKQYoBCkNnb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJl",
            "dGEyLkltcG9ydEFwdEFydGlmYWN0c1Jlc3BvbnNlEkNnb29nbGUuZGV2dG9v",
            "bHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLkltcG9ydEFwdEFydGlmYWN0",
            "c01ldGFkYXRhgtPkkwJQIksvdjFiZXRhMi97cGFyZW50PXByb2plY3RzLyov",
            "bG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyp9L2FwdEFydGlmYWN0czppbXBv",
            "cnQ6ASoS3wIKEkltcG9ydFl1bUFydGlmYWN0cxJDLmdvb2dsZS5kZXZ0b29s",
            "cy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuSW1wb3J0WXVtQXJ0aWZhY3Rz",
            "UmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24i5AHKQYoB",
            "CkNnb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLklt",
            "cG9ydFl1bUFydGlmYWN0c1Jlc3BvbnNlEkNnb29nbGUuZGV2dG9vbHMuYXJ0",
            "aWZhY3RyZWdpc3RyeS52MWJldGEyLkltcG9ydFl1bUFydGlmYWN0c01ldGFk",
            "YXRhgtPkkwJQIksvdjFiZXRhMi97cGFyZW50PXByb2plY3RzLyovbG9jYXRp",
            "b25zLyovcmVwb3NpdG9yaWVzLyp9L3l1bUFydGlmYWN0czppbXBvcnQ6ASoS",
            "4QEKEExpc3RSZXBvc2l0b3JpZXMSQS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZh",
            "Y3RyZWdpc3RyeS52MWJldGEyLkxpc3RSZXBvc2l0b3JpZXNSZXF1ZXN0GkIu",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5MaXN0",
            "UmVwb3NpdG9yaWVzUmVzcG9uc2UiRtpBBnBhcmVudILT5JMCNxI1L3YxYmV0",
            "YTIve3BhcmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9yZXBvc2l0b3Jp",
            "ZXMSywEKDUdldFJlcG9zaXRvcnkSPi5nb29nbGUuZGV2dG9vbHMuYXJ0aWZh",
            "Y3RyZWdpc3RyeS52MWJldGEyLkdldFJlcG9zaXRvcnlSZXF1ZXN0GjQuZ29v",
            "Z2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5SZXBvc2l0",
            "b3J5IkTaQQRuYW1lgtPkkwI3EjUvdjFiZXRhMi97bmFtZT1wcm9qZWN0cy8q",
            "L2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qfRLWAgoQQ3JlYXRlUmVwb3Np",
            "dG9yeRJBLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0",
            "YTIuQ3JlYXRlUmVwb3NpdG9yeVJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5p",
            "bmcuT3BlcmF0aW9uIt8BykFxCjNnb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3Ry",
            "ZWdpc3RyeS52MWJldGEyLlJlcG9zaXRvcnkSOmdvb2dsZS5kZXZ0b29scy5h",
            "cnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuT3BlcmF0aW9uTWV0YWRhdGHaQR9w",
            "YXJlbnQscmVwb3NpdG9yeSxyZXBvc2l0b3J5X2lkgtPkkwJDIjUvdjFiZXRh",
            "Mi97cGFyZW50PXByb2plY3RzLyovbG9jYXRpb25zLyp9L3JlcG9zaXRvcmll",
            "czoKcmVwb3NpdG9yeRL6AQoQVXBkYXRlUmVwb3NpdG9yeRJBLmdvb2dsZS5k",
            "ZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuVXBkYXRlUmVwb3Np",
            "dG9yeVJlcXVlc3QaNC5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3Ry",
            "eS52MWJldGEyLlJlcG9zaXRvcnkibdpBFnJlcG9zaXRvcnksdXBkYXRlX21h",
            "c2uC0+STAk4yQC92MWJldGEyL3tyZXBvc2l0b3J5Lm5hbWU9cHJvamVjdHMv",
            "Ki9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKn06CnJlcG9zaXRvcnkSkQIK",
            "EERlbGV0ZVJlcG9zaXRvcnkSQS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3Ry",
            "ZWdpc3RyeS52MWJldGEyLkRlbGV0ZVJlcG9zaXRvcnlSZXF1ZXN0Gh0uZ29v",
            "Z2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiKaAcpBUwoVZ29vZ2xlLnByb3Rv",
            "YnVmLkVtcHR5Ejpnb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52",
            "MWJldGEyLk9wZXJhdGlvbk1ldGFkYXRh2kEEbmFtZYLT5JMCNyo1L3YxYmV0",
            "YTIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMv",
            "Kn0S4AEKDExpc3RQYWNrYWdlcxI9Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFj",
            "dHJlZ2lzdHJ5LnYxYmV0YTIuTGlzdFBhY2thZ2VzUmVxdWVzdBo+Lmdvb2ds",
            "ZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuTGlzdFBhY2th",
            "Z2VzUmVzcG9uc2UiUdpBBnBhcmVudILT5JMCQhJAL3YxYmV0YTIve3BhcmVu",
            "dD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qfS9wYWNr",
            "YWdlcxLNAQoKR2V0UGFja2FnZRI7Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFj",
            "dHJlZ2lzdHJ5LnYxYmV0YTIuR2V0UGFja2FnZVJlcXVlc3QaMS5nb29nbGUu",
            "ZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLlBhY2thZ2UiT9pB",
            "BG5hbWWC0+STAkISQC92MWJldGEyL3tuYW1lPXByb2plY3RzLyovbG9jYXRp",
            "b25zLyovcmVwb3NpdG9yaWVzLyovcGFja2FnZXMvKn0SlgIKDURlbGV0ZVBh",
            "Y2thZ2USPi5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJl",
            "dGEyLkRlbGV0ZVBhY2thZ2VSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5n",
            "Lk9wZXJhdGlvbiKlAcpBUwoVZ29vZ2xlLnByb3RvYnVmLkVtcHR5Ejpnb29n",
            "bGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLk9wZXJhdGlv",
            "bk1ldGFkYXRh2kEEbmFtZYLT5JMCQipAL3YxYmV0YTIve25hbWU9cHJvamVj",
            "dHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKi9wYWNrYWdlcy8qfRLr",
            "AQoMTGlzdFZlcnNpb25zEj0uZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVn",
            "aXN0cnkudjFiZXRhMi5MaXN0VmVyc2lvbnNSZXF1ZXN0Gj4uZ29vZ2xlLmRl",
            "dnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5MaXN0VmVyc2lvbnNS",
            "ZXNwb25zZSJc2kEGcGFyZW50gtPkkwJNEksvdjFiZXRhMi97cGFyZW50PXBy",
            "b2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyovcGFja2FnZXMv",
            "Kn0vdmVyc2lvbnMS2AEKCkdldFZlcnNpb24SOy5nb29nbGUuZGV2dG9vbHMu",
            "YXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLkdldFZlcnNpb25SZXF1ZXN0GjEu",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5WZXJz",
            "aW9uIlraQQRuYW1lgtPkkwJNEksvdjFiZXRhMi97bmFtZT1wcm9qZWN0cy8q",
            "L2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qL3BhY2thZ2VzLyovdmVyc2lv",
            "bnMvKn0SoQIKDURlbGV0ZVZlcnNpb24SPi5nb29nbGUuZGV2dG9vbHMuYXJ0",
            "aWZhY3RyZWdpc3RyeS52MWJldGEyLkRlbGV0ZVZlcnNpb25SZXF1ZXN0Gh0u",
            "Z29vZ2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiKwAcpBUwoVZ29vZ2xlLnBy",
            "b3RvYnVmLkVtcHR5Ejpnb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3Ry",
            "eS52MWJldGEyLk9wZXJhdGlvbk1ldGFkYXRh2kEEbmFtZYLT5JMCTSpLL3Yx",
            "YmV0YTIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3Jp",
            "ZXMvKi9wYWNrYWdlcy8qL3ZlcnNpb25zLyp9EtQBCglMaXN0RmlsZXMSOi5n",
            "b29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLkxpc3RG",
            "aWxlc1JlcXVlc3QaOy5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3Ry",
            "eS52MWJldGEyLkxpc3RGaWxlc1Jlc3BvbnNlIk7aQQZwYXJlbnSC0+STAj8S",
            "PS92MWJldGEyL3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBv",
            "c2l0b3JpZXMvKn0vZmlsZXMSwgEKB0dldEZpbGUSOC5nb29nbGUuZGV2dG9v",
            "bHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLkdldEZpbGVSZXF1ZXN0Gi4u",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5GaWxl",
            "Ik3aQQRuYW1lgtPkkwJAEj4vdjFiZXRhMi97bmFtZT1wcm9qZWN0cy8qL2xv",
            "Y2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qL2ZpbGVzLyoqfRLbAQoITGlzdFRh",
            "Z3MSOS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEy",
            "Lkxpc3RUYWdzUmVxdWVzdBo6Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJl",
            "Z2lzdHJ5LnYxYmV0YTIuTGlzdFRhZ3NSZXNwb25zZSJY2kEGcGFyZW50gtPk",
            "kwJJEkcvdjFiZXRhMi97cGFyZW50PXByb2plY3RzLyovbG9jYXRpb25zLyov",
            "cmVwb3NpdG9yaWVzLyovcGFja2FnZXMvKn0vdGFncxLIAQoGR2V0VGFnEjcu",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5HZXRU",
            "YWdSZXF1ZXN0Gi0uZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnku",
            "djFiZXRhMi5UYWciVtpBBG5hbWWC0+STAkkSRy92MWJldGEyL3tuYW1lPXBy",
            "b2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyovcGFja2FnZXMv",
            "Ki90YWdzLyp9EuABCglDcmVhdGVUYWcSOi5nb29nbGUuZGV2dG9vbHMuYXJ0",
            "aWZhY3RyZWdpc3RyeS52MWJldGEyLkNyZWF0ZVRhZ1JlcXVlc3QaLS5nb29n",
            "bGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLlRhZyJo2kER",
            "cGFyZW50LHRhZyx0YWdfaWSC0+STAk4iRy92MWJldGEyL3twYXJlbnQ9cHJv",
            "amVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKi9wYWNrYWdlcy8q",
            "fS90YWdzOgN0YWcS4gEKCVVwZGF0ZVRhZxI6Lmdvb2dsZS5kZXZ0b29scy5h",
            "cnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuVXBkYXRlVGFnUmVxdWVzdBotLmdv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuVGFnImra",
            "QQ90YWcsdXBkYXRlX21hc2uC0+STAlIySy92MWJldGEyL3t0YWcubmFtZT1w",
            "cm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qL3BhY2thZ2Vz",
            "LyovdGFncy8qfToDdGFnErcBCglEZWxldGVUYWcSOi5nb29nbGUuZGV2dG9v",
            "bHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLkRlbGV0ZVRhZ1JlcXVlc3Qa",
            "Fi5nb29nbGUucHJvdG9idWYuRW1wdHkiVtpBBG5hbWWC0+STAkkqRy92MWJl",
            "dGEyL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9yaWVz",
            "LyovcGFja2FnZXMvKi90YWdzLyp9EpwBCgxTZXRJYW1Qb2xpY3kSIi5nb29n",
            "bGUuaWFtLnYxLlNldElhbVBvbGljeVJlcXVlc3QaFS5nb29nbGUuaWFtLnYx",
            "LlBvbGljeSJRgtPkkwJLIkYvdjFiZXRhMi97cmVzb3VyY2U9cHJvamVjdHMv",
            "Ki9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKn06c2V0SWFtUG9saWN5OgEq",
            "EpkBCgxHZXRJYW1Qb2xpY3kSIi5nb29nbGUuaWFtLnYxLkdldElhbVBvbGlj",
            "eVJlcXVlc3QaFS5nb29nbGUuaWFtLnYxLlBvbGljeSJOgtPkkwJIEkYvdjFi",
            "ZXRhMi97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0",
            "b3JpZXMvKn06Z2V0SWFtUG9saWN5EsIBChJUZXN0SWFtUGVybWlzc2lvbnMS",
            "KC5nb29nbGUuaWFtLnYxLlRlc3RJYW1QZXJtaXNzaW9uc1JlcXVlc3QaKS5n",
            "b29nbGUuaWFtLnYxLlRlc3RJYW1QZXJtaXNzaW9uc1Jlc3BvbnNlIleC0+ST",
            "AlEiTC92MWJldGEyL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8q",
            "L3JlcG9zaXRvcmllcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASoSzwEKEkdl",
            "dFByb2plY3RTZXR0aW5ncxJDLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJl",
            "Z2lzdHJ5LnYxYmV0YTIuR2V0UHJvamVjdFNldHRpbmdzUmVxdWVzdBo5Lmdv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuUHJvamVj",
            "dFNldHRpbmdzIjnaQQRuYW1lgtPkkwIsEiovdjFiZXRhMi97bmFtZT1wcm9q",
            "ZWN0cy8qL3Byb2plY3RTZXR0aW5nc30SkAIKFVVwZGF0ZVByb2plY3RTZXR0",
            "aW5ncxJGLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0",
            "YTIuVXBkYXRlUHJvamVjdFNldHRpbmdzUmVxdWVzdBo5Lmdvb2dsZS5kZXZ0",
            "b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuUHJvamVjdFNldHRpbmdz",
            "InTaQRxwcm9qZWN0X3NldHRpbmdzLHVwZGF0ZV9tYXNrgtPkkwJPMjsvdjFi",
            "ZXRhMi97cHJvamVjdF9zZXR0aW5ncy5uYW1lPXByb2plY3RzLyovcHJvamVj",
            "dFNldHRpbmdzfToQcHJvamVjdF9zZXR0aW5ncxqMAcpBH2FydGlmYWN0cmVn",
            "aXN0cnkuZ29vZ2xlYXBpcy5jb23SQWdodHRwczovL3d3dy5nb29nbGVhcGlz",
            "LmNvbS9hdXRoL2Nsb3VkLXBsYXRmb3JtLGh0dHBzOi8vd3d3Lmdvb2dsZWFw",
            "aXMuY29tL2F1dGgvY2xvdWQtcGxhdGZvcm0ucmVhZC1vbmx5QpACCixjb20u",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMkIMU2Vy",
            "dmljZVByb3RvUAFaVWNsb3VkLmdvb2dsZS5jb20vZ28vYXJ0aWZhY3RyZWdp",
            "c3RyeS9hcGl2MWJldGEyL2FydGlmYWN0cmVnaXN0cnlwYjthcnRpZmFjdHJl",
            "Z2lzdHJ5cGKqAiVHb29nbGUuQ2xvdWQuQXJ0aWZhY3RSZWdpc3RyeS5WMUJl",
            "dGEyygIlR29vZ2xlXENsb3VkXEFydGlmYWN0UmVnaXN0cnlcVjFiZXRhMuoC",
            "KEdvb2dsZTo6Q2xvdWQ6OkFydGlmYWN0UmVnaXN0cnk6OlYxYmV0YTJiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.AptArtifactReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.FileReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.PackageReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.RepositoryReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.SettingsReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.TagReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.VersionReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.YumArtifactReflection.Descriptor, global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor, global::Google.Cloud.Iam.V1.PolicyReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ArtifactRegistry.V1Beta2.OperationMetadata), global::Google.Cloud.ArtifactRegistry.V1Beta2.OperationMetadata.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Metadata type for longrunning-operations, currently empty.
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
      get { return global::Google.Cloud.ArtifactRegistry.V1Beta2.ServiceReflection.Descriptor.MessageTypes[0]; }
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
