// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/notebook.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/notebook.proto</summary>
  public static partial class NotebookReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/notebook.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NotebookReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEvbm90ZWJvb2sucHJv",
            "dG8SHmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52MRofZ29vZ2xlL3By",
            "b3RvYnVmL3RpbWVzdGFtcC5wcm90byJ4CghOb3RlYm9vaxIMCgRuYW1lGAEg",
            "ASgJEg8KB3NlcnZpY2UYAiABKAkSEwoLbGFzdF9hdXRob3IYAyABKAkSOAoU",
            "bm90ZWJvb2tfdXBkYXRlX3RpbWUYBCABKAsyGi5nb29nbGUucHJvdG9idWYu",
            "VGltZXN0YW1wQucBCiJjb20uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVy",
            "LnYxQg1Ob3RlYm9va1Byb3RvUAFaSmNsb3VkLmdvb2dsZS5jb20vZ28vc2Vj",
            "dXJpdHljZW50ZXIvYXBpdjEvc2VjdXJpdHljZW50ZXJwYjtzZWN1cml0eWNl",
            "bnRlcnBiqgIeR29vZ2xlLkNsb3VkLlNlY3VyaXR5Q2VudGVyLlYxygIeR29v",
            "Z2xlXENsb3VkXFNlY3VyaXR5Q2VudGVyXFYx6gIhR29vZ2xlOjpDbG91ZDo6",
            "U2VjdXJpdHlDZW50ZXI6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.Notebook), global::Google.Cloud.SecurityCenter.V1.Notebook.Parser, new[]{ "Name", "Service", "LastAuthor", "NotebookUpdateTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a Jupyter notebook IPYNB file, such as a [Colab Enterprise
  /// notebook](https://cloud.google.com/colab/docs/introduction) file, that is
  /// associated with a finding.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Notebook : pb::IMessage<Notebook>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Notebook> _parser = new pb::MessageParser<Notebook>(() => new Notebook());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Notebook> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.NotebookReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Notebook() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Notebook(Notebook other) : this() {
      name_ = other.name_;
      service_ = other.service_;
      lastAuthor_ = other.lastAuthor_;
      notebookUpdateTime_ = other.notebookUpdateTime_ != null ? other.notebookUpdateTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Notebook Clone() {
      return new Notebook(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of the notebook.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "service" field.</summary>
    public const int ServiceFieldNumber = 2;
    private string service_ = "";
    /// <summary>
    /// The source notebook service, for example, "Colab Enterprise".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Service {
      get { return service_; }
      set {
        service_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_author" field.</summary>
    public const int LastAuthorFieldNumber = 3;
    private string lastAuthor_ = "";
    /// <summary>
    /// The user ID of the latest author to modify the notebook.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LastAuthor {
      get { return lastAuthor_; }
      set {
        lastAuthor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "notebook_update_time" field.</summary>
    public const int NotebookUpdateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp notebookUpdateTime_;
    /// <summary>
    /// The most recent time the notebook was updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp NotebookUpdateTime {
      get { return notebookUpdateTime_; }
      set {
        notebookUpdateTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Notebook);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Notebook other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Service != other.Service) return false;
      if (LastAuthor != other.LastAuthor) return false;
      if (!object.Equals(NotebookUpdateTime, other.NotebookUpdateTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Service.Length != 0) hash ^= Service.GetHashCode();
      if (LastAuthor.Length != 0) hash ^= LastAuthor.GetHashCode();
      if (notebookUpdateTime_ != null) hash ^= NotebookUpdateTime.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Service.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Service);
      }
      if (LastAuthor.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LastAuthor);
      }
      if (notebookUpdateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(NotebookUpdateTime);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Service.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Service);
      }
      if (LastAuthor.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LastAuthor);
      }
      if (notebookUpdateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(NotebookUpdateTime);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Service.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Service);
      }
      if (LastAuthor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastAuthor);
      }
      if (notebookUpdateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NotebookUpdateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Notebook other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Service.Length != 0) {
        Service = other.Service;
      }
      if (other.LastAuthor.Length != 0) {
        LastAuthor = other.LastAuthor;
      }
      if (other.notebookUpdateTime_ != null) {
        if (notebookUpdateTime_ == null) {
          NotebookUpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        NotebookUpdateTime.MergeFrom(other.NotebookUpdateTime);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Service = input.ReadString();
            break;
          }
          case 26: {
            LastAuthor = input.ReadString();
            break;
          }
          case 34: {
            if (notebookUpdateTime_ == null) {
              NotebookUpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(NotebookUpdateTime);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Service = input.ReadString();
            break;
          }
          case 26: {
            LastAuthor = input.ReadString();
            break;
          }
          case 34: {
            if (notebookUpdateTime_ == null) {
              NotebookUpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(NotebookUpdateTime);
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
