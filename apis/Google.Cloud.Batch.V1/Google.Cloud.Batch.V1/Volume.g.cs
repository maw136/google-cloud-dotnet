// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/batch/v1/volume.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Batch.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/batch/v1/volume.proto</summary>
  public static partial class VolumeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/batch/v1/volume.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VolumeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJnb29nbGUvY2xvdWQvYmF0Y2gvdjEvdm9sdW1lLnByb3RvEhVnb29nbGUu",
            "Y2xvdWQuYmF0Y2gudjEiqgEKBlZvbHVtZRIpCgNuZnMYASABKAsyGi5nb29n",
            "bGUuY2xvdWQuYmF0Y2gudjEuTkZTSAASKQoDZ2NzGAMgASgLMhouZ29vZ2xl",
            "LmNsb3VkLmJhdGNoLnYxLkdDU0gAEhUKC2RldmljZV9uYW1lGAYgASgJSAAS",
            "EgoKbW91bnRfcGF0aBgEIAEoCRIVCg1tb3VudF9vcHRpb25zGAUgAygJQggK",
            "BnNvdXJjZSIqCgNORlMSDgoGc2VydmVyGAEgASgJEhMKC3JlbW90ZV9wYXRo",
            "GAIgASgJIhoKA0dDUxITCgtyZW1vdGVfcGF0aBgBIAEoCUK3AQoZY29tLmdv",
            "b2dsZS5jbG91ZC5iYXRjaC52MUILVm9sdW1lUHJvdG9QAVo6Z29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9iYXRjaC92MTti",
            "YXRjaKICA0dDQqoCFUdvb2dsZS5DbG91ZC5CYXRjaC5WMcoCFUdvb2dsZVxD",
            "bG91ZFxCYXRjaFxWMeoCGEdvb2dsZTo6Q2xvdWQ6OkJhdGNoOjpWMWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Batch.V1.Volume), global::Google.Cloud.Batch.V1.Volume.Parser, new[]{ "Nfs", "Gcs", "DeviceName", "MountPath", "MountOptions" }, new[]{ "Source" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Batch.V1.NFS), global::Google.Cloud.Batch.V1.NFS.Parser, new[]{ "Server", "RemotePath" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Batch.V1.GCS), global::Google.Cloud.Batch.V1.GCS.Parser, new[]{ "RemotePath" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Volume describes a volume and parameters for it to be mounted to a VM.
  /// </summary>
  public sealed partial class Volume : pb::IMessage<Volume>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Volume> _parser = new pb::MessageParser<Volume>(() => new Volume());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Volume> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Batch.V1.VolumeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Volume() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Volume(Volume other) : this() {
      mountPath_ = other.mountPath_;
      mountOptions_ = other.mountOptions_.Clone();
      switch (other.SourceCase) {
        case SourceOneofCase.Nfs:
          Nfs = other.Nfs.Clone();
          break;
        case SourceOneofCase.Gcs:
          Gcs = other.Gcs.Clone();
          break;
        case SourceOneofCase.DeviceName:
          DeviceName = other.DeviceName;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Volume Clone() {
      return new Volume(this);
    }

    /// <summary>Field number for the "nfs" field.</summary>
    public const int NfsFieldNumber = 1;
    /// <summary>
    /// A Network File System (NFS) volume. For example, a
    /// Filestore file share.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Batch.V1.NFS Nfs {
      get { return sourceCase_ == SourceOneofCase.Nfs ? (global::Google.Cloud.Batch.V1.NFS) source_ : null; }
      set {
        source_ = value;
        sourceCase_ = value == null ? SourceOneofCase.None : SourceOneofCase.Nfs;
      }
    }

    /// <summary>Field number for the "gcs" field.</summary>
    public const int GcsFieldNumber = 3;
    /// <summary>
    /// A Google Cloud Storage (GCS) volume.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Batch.V1.GCS Gcs {
      get { return sourceCase_ == SourceOneofCase.Gcs ? (global::Google.Cloud.Batch.V1.GCS) source_ : null; }
      set {
        source_ = value;
        sourceCase_ = value == null ? SourceOneofCase.None : SourceOneofCase.Gcs;
      }
    }

    /// <summary>Field number for the "device_name" field.</summary>
    public const int DeviceNameFieldNumber = 6;
    /// <summary>
    /// Device name of an attached disk volume, which should align with a
    /// device_name specified by
    /// job.allocation_policy.instances[0].policy.disks[i].device_name or
    /// defined by the given instance template in
    /// job.allocation_policy.instances[0].instance_template.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DeviceName {
      get { return sourceCase_ == SourceOneofCase.DeviceName ? (string) source_ : ""; }
      set {
        source_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        sourceCase_ = SourceOneofCase.DeviceName;
      }
    }

    /// <summary>Field number for the "mount_path" field.</summary>
    public const int MountPathFieldNumber = 4;
    private string mountPath_ = "";
    /// <summary>
    /// The mount path for the volume, e.g. /mnt/disks/share.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MountPath {
      get { return mountPath_; }
      set {
        mountPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mount_options" field.</summary>
    public const int MountOptionsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_mountOptions_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> mountOptions_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// For Google Cloud Storage (GCS), mount options are the options supported by
    /// the gcsfuse tool (https://github.com/GoogleCloudPlatform/gcsfuse).
    /// For existing persistent disks, mount options provided by the
    /// mount command (https://man7.org/linux/man-pages/man8/mount.8.html) except
    /// writing are supported. This is due to restrictions of multi-writer mode
    /// (https://cloud.google.com/compute/docs/disks/sharing-disks-between-vms).
    /// For other attached disks and Network File System (NFS), mount options are
    /// these supported by the mount command
    /// (https://man7.org/linux/man-pages/man8/mount.8.html).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> MountOptions {
      get { return mountOptions_; }
    }

    private object source_;
    /// <summary>Enum of possible cases for the "source" oneof.</summary>
    public enum SourceOneofCase {
      None = 0,
      Nfs = 1,
      Gcs = 3,
      DeviceName = 6,
    }
    private SourceOneofCase sourceCase_ = SourceOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SourceOneofCase SourceCase {
      get { return sourceCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSource() {
      sourceCase_ = SourceOneofCase.None;
      source_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Volume);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Volume other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Nfs, other.Nfs)) return false;
      if (!object.Equals(Gcs, other.Gcs)) return false;
      if (DeviceName != other.DeviceName) return false;
      if (MountPath != other.MountPath) return false;
      if(!mountOptions_.Equals(other.mountOptions_)) return false;
      if (SourceCase != other.SourceCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (sourceCase_ == SourceOneofCase.Nfs) hash ^= Nfs.GetHashCode();
      if (sourceCase_ == SourceOneofCase.Gcs) hash ^= Gcs.GetHashCode();
      if (sourceCase_ == SourceOneofCase.DeviceName) hash ^= DeviceName.GetHashCode();
      if (MountPath.Length != 0) hash ^= MountPath.GetHashCode();
      hash ^= mountOptions_.GetHashCode();
      hash ^= (int) sourceCase_;
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
      if (sourceCase_ == SourceOneofCase.Nfs) {
        output.WriteRawTag(10);
        output.WriteMessage(Nfs);
      }
      if (sourceCase_ == SourceOneofCase.Gcs) {
        output.WriteRawTag(26);
        output.WriteMessage(Gcs);
      }
      if (MountPath.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(MountPath);
      }
      mountOptions_.WriteTo(output, _repeated_mountOptions_codec);
      if (sourceCase_ == SourceOneofCase.DeviceName) {
        output.WriteRawTag(50);
        output.WriteString(DeviceName);
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
      if (sourceCase_ == SourceOneofCase.Nfs) {
        output.WriteRawTag(10);
        output.WriteMessage(Nfs);
      }
      if (sourceCase_ == SourceOneofCase.Gcs) {
        output.WriteRawTag(26);
        output.WriteMessage(Gcs);
      }
      if (MountPath.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(MountPath);
      }
      mountOptions_.WriteTo(ref output, _repeated_mountOptions_codec);
      if (sourceCase_ == SourceOneofCase.DeviceName) {
        output.WriteRawTag(50);
        output.WriteString(DeviceName);
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
      if (sourceCase_ == SourceOneofCase.Nfs) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Nfs);
      }
      if (sourceCase_ == SourceOneofCase.Gcs) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Gcs);
      }
      if (sourceCase_ == SourceOneofCase.DeviceName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceName);
      }
      if (MountPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MountPath);
      }
      size += mountOptions_.CalculateSize(_repeated_mountOptions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Volume other) {
      if (other == null) {
        return;
      }
      if (other.MountPath.Length != 0) {
        MountPath = other.MountPath;
      }
      mountOptions_.Add(other.mountOptions_);
      switch (other.SourceCase) {
        case SourceOneofCase.Nfs:
          if (Nfs == null) {
            Nfs = new global::Google.Cloud.Batch.V1.NFS();
          }
          Nfs.MergeFrom(other.Nfs);
          break;
        case SourceOneofCase.Gcs:
          if (Gcs == null) {
            Gcs = new global::Google.Cloud.Batch.V1.GCS();
          }
          Gcs.MergeFrom(other.Gcs);
          break;
        case SourceOneofCase.DeviceName:
          DeviceName = other.DeviceName;
          break;
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
            global::Google.Cloud.Batch.V1.NFS subBuilder = new global::Google.Cloud.Batch.V1.NFS();
            if (sourceCase_ == SourceOneofCase.Nfs) {
              subBuilder.MergeFrom(Nfs);
            }
            input.ReadMessage(subBuilder);
            Nfs = subBuilder;
            break;
          }
          case 26: {
            global::Google.Cloud.Batch.V1.GCS subBuilder = new global::Google.Cloud.Batch.V1.GCS();
            if (sourceCase_ == SourceOneofCase.Gcs) {
              subBuilder.MergeFrom(Gcs);
            }
            input.ReadMessage(subBuilder);
            Gcs = subBuilder;
            break;
          }
          case 34: {
            MountPath = input.ReadString();
            break;
          }
          case 42: {
            mountOptions_.AddEntriesFrom(input, _repeated_mountOptions_codec);
            break;
          }
          case 50: {
            DeviceName = input.ReadString();
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
            global::Google.Cloud.Batch.V1.NFS subBuilder = new global::Google.Cloud.Batch.V1.NFS();
            if (sourceCase_ == SourceOneofCase.Nfs) {
              subBuilder.MergeFrom(Nfs);
            }
            input.ReadMessage(subBuilder);
            Nfs = subBuilder;
            break;
          }
          case 26: {
            global::Google.Cloud.Batch.V1.GCS subBuilder = new global::Google.Cloud.Batch.V1.GCS();
            if (sourceCase_ == SourceOneofCase.Gcs) {
              subBuilder.MergeFrom(Gcs);
            }
            input.ReadMessage(subBuilder);
            Gcs = subBuilder;
            break;
          }
          case 34: {
            MountPath = input.ReadString();
            break;
          }
          case 42: {
            mountOptions_.AddEntriesFrom(ref input, _repeated_mountOptions_codec);
            break;
          }
          case 50: {
            DeviceName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Represents an NFS volume.
  /// </summary>
  public sealed partial class NFS : pb::IMessage<NFS>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NFS> _parser = new pb::MessageParser<NFS>(() => new NFS());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NFS> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Batch.V1.VolumeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NFS() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NFS(NFS other) : this() {
      server_ = other.server_;
      remotePath_ = other.remotePath_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NFS Clone() {
      return new NFS(this);
    }

    /// <summary>Field number for the "server" field.</summary>
    public const int ServerFieldNumber = 1;
    private string server_ = "";
    /// <summary>
    /// The IP address of the NFS.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Server {
      get { return server_; }
      set {
        server_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "remote_path" field.</summary>
    public const int RemotePathFieldNumber = 2;
    private string remotePath_ = "";
    /// <summary>
    /// Remote source path exported from the NFS, e.g., "/share".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RemotePath {
      get { return remotePath_; }
      set {
        remotePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NFS);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NFS other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Server != other.Server) return false;
      if (RemotePath != other.RemotePath) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Server.Length != 0) hash ^= Server.GetHashCode();
      if (RemotePath.Length != 0) hash ^= RemotePath.GetHashCode();
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
      if (Server.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Server);
      }
      if (RemotePath.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RemotePath);
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
      if (Server.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Server);
      }
      if (RemotePath.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RemotePath);
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
      if (Server.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Server);
      }
      if (RemotePath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemotePath);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NFS other) {
      if (other == null) {
        return;
      }
      if (other.Server.Length != 0) {
        Server = other.Server;
      }
      if (other.RemotePath.Length != 0) {
        RemotePath = other.RemotePath;
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
            Server = input.ReadString();
            break;
          }
          case 18: {
            RemotePath = input.ReadString();
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
            Server = input.ReadString();
            break;
          }
          case 18: {
            RemotePath = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Represents a Google Cloud Storage volume.
  /// </summary>
  public sealed partial class GCS : pb::IMessage<GCS>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCS> _parser = new pb::MessageParser<GCS>(() => new GCS());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCS> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Batch.V1.VolumeReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCS() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCS(GCS other) : this() {
      remotePath_ = other.remotePath_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCS Clone() {
      return new GCS(this);
    }

    /// <summary>Field number for the "remote_path" field.</summary>
    public const int RemotePathFieldNumber = 1;
    private string remotePath_ = "";
    /// <summary>
    /// Remote path, either a bucket name or a subdirectory of a bucket, e.g.:
    /// bucket_name, bucket_name/subdirectory/
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RemotePath {
      get { return remotePath_; }
      set {
        remotePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCS);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCS other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RemotePath != other.RemotePath) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RemotePath.Length != 0) hash ^= RemotePath.GetHashCode();
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
      if (RemotePath.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RemotePath);
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
      if (RemotePath.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RemotePath);
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
      if (RemotePath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemotePath);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCS other) {
      if (other == null) {
        return;
      }
      if (other.RemotePath.Length != 0) {
        RemotePath = other.RemotePath;
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
            RemotePath = input.ReadString();
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
            RemotePath = input.ReadString();
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
