// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v2/database.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v2/database.proto</summary>
  public static partial class DatabaseReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v2/database.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DatabaseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjIvZGF0YWJhc2UucHJv",
            "dG8SHmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52MiJzCghEYXRhYmFz",
            "ZRIMCgRuYW1lGAEgASgJEhQKDGRpc3BsYXlfbmFtZRgCIAEoCRIRCgl1c2Vy",
            "X25hbWUYAyABKAkSDQoFcXVlcnkYBCABKAkSEAoIZ3JhbnRlZXMYBSADKAkS",
            "DwoHdmVyc2lvbhgGIAEoCULnAQoiY29tLmdvb2dsZS5jbG91ZC5zZWN1cml0",
            "eWNlbnRlci52MkINRGF0YWJhc2VQcm90b1ABWkpjbG91ZC5nb29nbGUuY29t",
            "L2dvL3NlY3VyaXR5Y2VudGVyL2FwaXYyL3NlY3VyaXR5Y2VudGVycGI7c2Vj",
            "dXJpdHljZW50ZXJwYqoCHkdvb2dsZS5DbG91ZC5TZWN1cml0eUNlbnRlci5W",
            "MsoCHkdvb2dsZVxDbG91ZFxTZWN1cml0eUNlbnRlclxWMuoCIUdvb2dsZTo6",
            "Q2xvdWQ6OlNlY3VyaXR5Q2VudGVyOjpWMmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V2.Database), global::Google.Cloud.SecurityCenter.V2.Database.Parser, new[]{ "Name", "DisplayName", "UserName", "Query", "Grantees", "Version" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents database access information, such as queries. A database may be a
  /// sub-resource of an instance (as in the case of Cloud SQL instances or Cloud
  /// Spanner instances), or the database instance itself. Some database resources
  /// might not have the [full resource
  /// name](https://google.aip.dev/122#full-resource-names) populated because these
  /// resource types, such as Cloud SQL databases, are not yet supported by Cloud
  /// Asset Inventory. In these cases only the display name is provided.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Database : pb::IMessage<Database>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Database> _parser = new pb::MessageParser<Database>(() => new Database());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Database> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V2.DatabaseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Database() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Database(Database other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      userName_ = other.userName_;
      query_ = other.query_;
      grantees_ = other.grantees_.Clone();
      version_ = other.version_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Database Clone() {
      return new Database(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Some database resources may not have the [full resource
    /// name](https://google.aip.dev/122#full-resource-names) populated because
    /// these resource types are not yet supported by Cloud Asset Inventory (e.g.
    /// Cloud SQL databases). In these cases only the display name will be
    /// provided.
    /// The [full resource name](https://google.aip.dev/122#full-resource-names) of
    /// the database that the user connected to, if it is supported by Cloud Asset
    /// Inventory.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// The human-readable name of the database that the user connected to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_name" field.</summary>
    public const int UserNameFieldNumber = 3;
    private string userName_ = "";
    /// <summary>
    /// The username used to connect to the database. The username might not be an
    /// IAM principal and does not have a set format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserName {
      get { return userName_; }
      set {
        userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "query" field.</summary>
    public const int QueryFieldNumber = 4;
    private string query_ = "";
    /// <summary>
    /// The SQL statement that is associated with the database access.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Query {
      get { return query_; }
      set {
        query_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "grantees" field.</summary>
    public const int GranteesFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_grantees_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> grantees_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The target usernames, roles, or groups of an SQL privilege grant, which is
    /// not an IAM policy change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Grantees {
      get { return grantees_; }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 6;
    private string version_ = "";
    /// <summary>
    /// The version of the database, for example, POSTGRES_14.
    /// See [the complete
    /// list](https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/SqlDatabaseVersion).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Database);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Database other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (UserName != other.UserName) return false;
      if (Query != other.Query) return false;
      if(!grantees_.Equals(other.grantees_)) return false;
      if (Version != other.Version) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (UserName.Length != 0) hash ^= UserName.GetHashCode();
      if (Query.Length != 0) hash ^= Query.GetHashCode();
      hash ^= grantees_.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (UserName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UserName);
      }
      if (Query.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Query);
      }
      grantees_.WriteTo(output, _repeated_grantees_codec);
      if (Version.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Version);
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (UserName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UserName);
      }
      if (Query.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Query);
      }
      grantees_.WriteTo(ref output, _repeated_grantees_codec);
      if (Version.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Version);
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
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (UserName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserName);
      }
      if (Query.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Query);
      }
      size += grantees_.CalculateSize(_repeated_grantees_codec);
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Database other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.UserName.Length != 0) {
        UserName = other.UserName;
      }
      if (other.Query.Length != 0) {
        Query = other.Query;
      }
      grantees_.Add(other.grantees_);
      if (other.Version.Length != 0) {
        Version = other.Version;
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
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            UserName = input.ReadString();
            break;
          }
          case 34: {
            Query = input.ReadString();
            break;
          }
          case 42: {
            grantees_.AddEntriesFrom(input, _repeated_grantees_codec);
            break;
          }
          case 50: {
            Version = input.ReadString();
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
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            UserName = input.ReadString();
            break;
          }
          case 34: {
            Query = input.ReadString();
            break;
          }
          case 42: {
            grantees_.AddEntriesFrom(ref input, _repeated_grantees_codec);
            break;
          }
          case 50: {
            Version = input.ReadString();
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
