// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/apps/script/type/sheets/sheets_addon_manifest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Apps.Script.Type.Sheets {

  /// <summary>Holder for reflection information generated from google/apps/script/type/sheets/sheets_addon_manifest.proto</summary>
  public static partial class SheetsAddonManifestReflection {

    #region Descriptor
    /// <summary>File descriptor for google/apps/script/type/sheets/sheets_addon_manifest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SheetsAddonManifestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYXBwcy9zY3JpcHQvdHlwZS9zaGVldHMvc2hlZXRzX2FkZG9u",
            "X21hbmlmZXN0LnByb3RvEh5nb29nbGUuYXBwcy5zY3JpcHQudHlwZS5zaGVl",
            "dHMaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aLWdvb2dsZS9h",
            "cHBzL3NjcmlwdC90eXBlL2V4dGVuc2lvbl9wb2ludC5wcm90byK9AQoTU2hl",
            "ZXRzQWRkT25NYW5pZmVzdBJJChBob21lcGFnZV90cmlnZ2VyGAMgASgLMi8u",
            "Z29vZ2xlLmFwcHMuc2NyaXB0LnR5cGUuSG9tZXBhZ2VFeHRlbnNpb25Qb2lu",
            "dBJbCh1vbl9maWxlX3Njb3BlX2dyYW50ZWRfdHJpZ2dlchgFIAEoCzI0Lmdv",
            "b2dsZS5hcHBzLnNjcmlwdC50eXBlLnNoZWV0cy5TaGVldHNFeHRlbnNpb25Q",
            "b2ludCIxChRTaGVldHNFeHRlbnNpb25Qb2ludBIZCgxydW5fZnVuY3Rpb24Y",
            "ASABKAlCA+BBAkLmAQoiY29tLmdvb2dsZS5hcHBzLnNjcmlwdC50eXBlLnNo",
            "ZWV0c0IYU2hlZXRzQWRkT25NYW5pZmVzdFByb3RvUAFaPWdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYXBwcy9zY3JpcHQvdHlwZS9z",
            "aGVldHOqAh5Hb29nbGUuQXBwcy5TY3JpcHQuVHlwZS5TaGVldHPKAh5Hb29n",
            "bGVcQXBwc1xTY3JpcHRcVHlwZVxTaGVldHPqAiJHb29nbGU6OkFwcHM6OlNj",
            "cmlwdDo6VHlwZTo6U2hlZXRzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Apps.Script.Type.ExtensionPointReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Apps.Script.Type.Sheets.SheetsAddOnManifest), global::Google.Apps.Script.Type.Sheets.SheetsAddOnManifest.Parser, new[]{ "HomepageTrigger", "OnFileScopeGrantedTrigger" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Apps.Script.Type.Sheets.SheetsExtensionPoint), global::Google.Apps.Script.Type.Sheets.SheetsExtensionPoint.Parser, new[]{ "RunFunction" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Sheets add-on manifest.
  /// </summary>
  public sealed partial class SheetsAddOnManifest : pb::IMessage<SheetsAddOnManifest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SheetsAddOnManifest> _parser = new pb::MessageParser<SheetsAddOnManifest>(() => new SheetsAddOnManifest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SheetsAddOnManifest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Apps.Script.Type.Sheets.SheetsAddonManifestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SheetsAddOnManifest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SheetsAddOnManifest(SheetsAddOnManifest other) : this() {
      homepageTrigger_ = other.homepageTrigger_ != null ? other.homepageTrigger_.Clone() : null;
      onFileScopeGrantedTrigger_ = other.onFileScopeGrantedTrigger_ != null ? other.onFileScopeGrantedTrigger_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SheetsAddOnManifest Clone() {
      return new SheetsAddOnManifest(this);
    }

    /// <summary>Field number for the "homepage_trigger" field.</summary>
    public const int HomepageTriggerFieldNumber = 3;
    private global::Google.Apps.Script.Type.HomepageExtensionPoint homepageTrigger_;
    /// <summary>
    /// If present, this overrides the configuration from
    /// `addOns.common.homepageTrigger`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Apps.Script.Type.HomepageExtensionPoint HomepageTrigger {
      get { return homepageTrigger_; }
      set {
        homepageTrigger_ = value;
      }
    }

    /// <summary>Field number for the "on_file_scope_granted_trigger" field.</summary>
    public const int OnFileScopeGrantedTriggerFieldNumber = 5;
    private global::Google.Apps.Script.Type.Sheets.SheetsExtensionPoint onFileScopeGrantedTrigger_;
    /// <summary>
    /// Endpoint to execute when file scope authorization is granted
    /// for this document/user pair.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Apps.Script.Type.Sheets.SheetsExtensionPoint OnFileScopeGrantedTrigger {
      get { return onFileScopeGrantedTrigger_; }
      set {
        onFileScopeGrantedTrigger_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SheetsAddOnManifest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SheetsAddOnManifest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(HomepageTrigger, other.HomepageTrigger)) return false;
      if (!object.Equals(OnFileScopeGrantedTrigger, other.OnFileScopeGrantedTrigger)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (homepageTrigger_ != null) hash ^= HomepageTrigger.GetHashCode();
      if (onFileScopeGrantedTrigger_ != null) hash ^= OnFileScopeGrantedTrigger.GetHashCode();
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
      if (homepageTrigger_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HomepageTrigger);
      }
      if (onFileScopeGrantedTrigger_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(OnFileScopeGrantedTrigger);
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
      if (homepageTrigger_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HomepageTrigger);
      }
      if (onFileScopeGrantedTrigger_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(OnFileScopeGrantedTrigger);
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
      if (homepageTrigger_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HomepageTrigger);
      }
      if (onFileScopeGrantedTrigger_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OnFileScopeGrantedTrigger);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SheetsAddOnManifest other) {
      if (other == null) {
        return;
      }
      if (other.homepageTrigger_ != null) {
        if (homepageTrigger_ == null) {
          HomepageTrigger = new global::Google.Apps.Script.Type.HomepageExtensionPoint();
        }
        HomepageTrigger.MergeFrom(other.HomepageTrigger);
      }
      if (other.onFileScopeGrantedTrigger_ != null) {
        if (onFileScopeGrantedTrigger_ == null) {
          OnFileScopeGrantedTrigger = new global::Google.Apps.Script.Type.Sheets.SheetsExtensionPoint();
        }
        OnFileScopeGrantedTrigger.MergeFrom(other.OnFileScopeGrantedTrigger);
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
          case 26: {
            if (homepageTrigger_ == null) {
              HomepageTrigger = new global::Google.Apps.Script.Type.HomepageExtensionPoint();
            }
            input.ReadMessage(HomepageTrigger);
            break;
          }
          case 42: {
            if (onFileScopeGrantedTrigger_ == null) {
              OnFileScopeGrantedTrigger = new global::Google.Apps.Script.Type.Sheets.SheetsExtensionPoint();
            }
            input.ReadMessage(OnFileScopeGrantedTrigger);
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
          case 26: {
            if (homepageTrigger_ == null) {
              HomepageTrigger = new global::Google.Apps.Script.Type.HomepageExtensionPoint();
            }
            input.ReadMessage(HomepageTrigger);
            break;
          }
          case 42: {
            if (onFileScopeGrantedTrigger_ == null) {
              OnFileScopeGrantedTrigger = new global::Google.Apps.Script.Type.Sheets.SheetsExtensionPoint();
            }
            input.ReadMessage(OnFileScopeGrantedTrigger);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Common format for declaring a Sheets add-on's triggers.
  /// </summary>
  public sealed partial class SheetsExtensionPoint : pb::IMessage<SheetsExtensionPoint>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SheetsExtensionPoint> _parser = new pb::MessageParser<SheetsExtensionPoint>(() => new SheetsExtensionPoint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SheetsExtensionPoint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Apps.Script.Type.Sheets.SheetsAddonManifestReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SheetsExtensionPoint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SheetsExtensionPoint(SheetsExtensionPoint other) : this() {
      runFunction_ = other.runFunction_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SheetsExtensionPoint Clone() {
      return new SheetsExtensionPoint(this);
    }

    /// <summary>Field number for the "run_function" field.</summary>
    public const int RunFunctionFieldNumber = 1;
    private string runFunction_ = "";
    /// <summary>
    /// Required. The endpoint to execute when this extension point is activated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RunFunction {
      get { return runFunction_; }
      set {
        runFunction_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SheetsExtensionPoint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SheetsExtensionPoint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RunFunction != other.RunFunction) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RunFunction.Length != 0) hash ^= RunFunction.GetHashCode();
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
      if (RunFunction.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RunFunction);
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
      if (RunFunction.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RunFunction);
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
      if (RunFunction.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RunFunction);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SheetsExtensionPoint other) {
      if (other == null) {
        return;
      }
      if (other.RunFunction.Length != 0) {
        RunFunction = other.RunFunction;
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
            RunFunction = input.ReadString();
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
            RunFunction = input.ReadString();
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
