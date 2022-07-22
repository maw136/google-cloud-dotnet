// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/recommendationengine/v1beta1/common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.RecommendationEngine.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/recommendationengine/v1beta1/common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/recommendationengine/v1beta1/common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvY2xvdWQvcmVjb21tZW5kYXRpb25lbmdpbmUvdjFiZXRhMS9j",
            "b21tb24ucHJvdG8SKWdvb2dsZS5jbG91ZC5yZWNvbW1lbmRhdGlvbmVuZ2lu",
            "ZS52MWJldGExGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpYECgpG",
            "ZWF0dXJlTWFwEmwKFGNhdGVnb3JpY2FsX2ZlYXR1cmVzGAEgAygLMk4uZ29v",
            "Z2xlLmNsb3VkLnJlY29tbWVuZGF0aW9uZW5naW5lLnYxYmV0YTEuRmVhdHVy",
            "ZU1hcC5DYXRlZ29yaWNhbEZlYXR1cmVzRW50cnkSaAoSbnVtZXJpY2FsX2Zl",
            "YXR1cmVzGAIgAygLMkwuZ29vZ2xlLmNsb3VkLnJlY29tbWVuZGF0aW9uZW5n",
            "aW5lLnYxYmV0YTEuRmVhdHVyZU1hcC5OdW1lcmljYWxGZWF0dXJlc0VudHJ5",
            "GhsKClN0cmluZ0xpc3QSDQoFdmFsdWUYASADKAkaGgoJRmxvYXRMaXN0Eg0K",
            "BXZhbHVlGAEgAygCGnwKGENhdGVnb3JpY2FsRmVhdHVyZXNFbnRyeRILCgNr",
            "ZXkYASABKAkSTwoFdmFsdWUYAiABKAsyQC5nb29nbGUuY2xvdWQucmVjb21t",
            "ZW5kYXRpb25lbmdpbmUudjFiZXRhMS5GZWF0dXJlTWFwLlN0cmluZ0xpc3Q6",
            "AjgBGnkKFk51bWVyaWNhbEZlYXR1cmVzRW50cnkSCwoDa2V5GAEgASgJEk4K",
            "BXZhbHVlGAIgASgLMj8uZ29vZ2xlLmNsb3VkLnJlY29tbWVuZGF0aW9uZW5n",
            "aW5lLnYxYmV0YTEuRmVhdHVyZU1hcC5GbG9hdExpc3Q6AjgBQp8CCi1jb20u",
            "Z29vZ2xlLmNsb3VkLnJlY29tbWVuZGF0aW9uZW5naW5lLnYxYmV0YTFQAVpd",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9y",
            "ZWNvbW1lbmRhdGlvbmVuZ2luZS92MWJldGExO3JlY29tbWVuZGF0aW9uZW5n",
            "aW5logIFUkVDQUmqAilHb29nbGUuQ2xvdWQuUmVjb21tZW5kYXRpb25Fbmdp",
            "bmUuVjFCZXRhMcoCKUdvb2dsZVxDbG91ZFxSZWNvbW1lbmRhdGlvbkVuZ2lu",
            "ZVxWMWJldGEx6gIsR29vZ2xlOjpDbG91ZDo6UmVjb21tZW5kYXRpb25Fbmdp",
            "bmU6OlYxYmV0YTFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap), global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Parser, new[]{ "CategoricalFeatures", "NumericalFeatures" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.StringList), global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.StringList.Parser, new[]{ "Value" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.FloatList), global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.FloatList.Parser, new[]{ "Value" }, null, null, null, null),
            null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// FeatureMap represents extra features that customers want to include in the
  /// recommendation model for catalogs/user events as categorical/numerical
  /// features.
  /// </summary>
  public sealed partial class FeatureMap : pb::IMessage<FeatureMap>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeatureMap> _parser = new pb::MessageParser<FeatureMap>(() => new FeatureMap());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeatureMap> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.RecommendationEngine.V1Beta1.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureMap() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureMap(FeatureMap other) : this() {
      categoricalFeatures_ = other.categoricalFeatures_.Clone();
      numericalFeatures_ = other.numericalFeatures_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureMap Clone() {
      return new FeatureMap(this);
    }

    /// <summary>Field number for the "categorical_features" field.</summary>
    public const int CategoricalFeaturesFieldNumber = 1;
    private static readonly pbc::MapField<string, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.StringList>.Codec _map_categoricalFeatures_codec
        = new pbc::MapField<string, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.StringList>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.StringList.Parser), 10);
    private readonly pbc::MapField<string, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.StringList> categoricalFeatures_ = new pbc::MapField<string, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.StringList>();
    /// <summary>
    /// Categorical features that can take on one of a limited number of possible
    /// values. Some examples would be the brand/maker of a product, or country of
    /// a customer.
    ///
    /// Feature names and values must be UTF-8 encoded strings.
    ///
    /// For example: `{ "colors": {"value": ["yellow", "green"]},
    ///                 "sizes": {"value":["S", "M"]}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.StringList> CategoricalFeatures {
      get { return categoricalFeatures_; }
    }

    /// <summary>Field number for the "numerical_features" field.</summary>
    public const int NumericalFeaturesFieldNumber = 2;
    private static readonly pbc::MapField<string, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.FloatList>.Codec _map_numericalFeatures_codec
        = new pbc::MapField<string, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.FloatList>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.FloatList.Parser), 18);
    private readonly pbc::MapField<string, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.FloatList> numericalFeatures_ = new pbc::MapField<string, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.FloatList>();
    /// <summary>
    /// Numerical features. Some examples would be the height/weight of a product,
    /// or age of a customer.
    ///
    /// Feature names must be UTF-8 encoded strings.
    ///
    /// For example: `{ "lengths_cm": {"value":[2.3, 15.4]},
    ///                 "heights_cm": {"value":[8.1, 6.4]} }`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Types.FloatList> NumericalFeatures {
      get { return numericalFeatures_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeatureMap);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeatureMap other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!CategoricalFeatures.Equals(other.CategoricalFeatures)) return false;
      if (!NumericalFeatures.Equals(other.NumericalFeatures)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= CategoricalFeatures.GetHashCode();
      hash ^= NumericalFeatures.GetHashCode();
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
      categoricalFeatures_.WriteTo(output, _map_categoricalFeatures_codec);
      numericalFeatures_.WriteTo(output, _map_numericalFeatures_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      categoricalFeatures_.WriteTo(ref output, _map_categoricalFeatures_codec);
      numericalFeatures_.WriteTo(ref output, _map_numericalFeatures_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += categoricalFeatures_.CalculateSize(_map_categoricalFeatures_codec);
      size += numericalFeatures_.CalculateSize(_map_numericalFeatures_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeatureMap other) {
      if (other == null) {
        return;
      }
      categoricalFeatures_.Add(other.categoricalFeatures_);
      numericalFeatures_.Add(other.numericalFeatures_);
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
            categoricalFeatures_.AddEntriesFrom(input, _map_categoricalFeatures_codec);
            break;
          }
          case 18: {
            numericalFeatures_.AddEntriesFrom(input, _map_numericalFeatures_codec);
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
            categoricalFeatures_.AddEntriesFrom(ref input, _map_categoricalFeatures_codec);
            break;
          }
          case 18: {
            numericalFeatures_.AddEntriesFrom(ref input, _map_numericalFeatures_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the FeatureMap message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// A list of string features.
      /// </summary>
      public sealed partial class StringList : pb::IMessage<StringList>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<StringList> _parser = new pb::MessageParser<StringList>(() => new StringList());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<StringList> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public StringList() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public StringList(StringList other) : this() {
          value_ = other.value_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public StringList Clone() {
          return new StringList(this);
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 1;
        private static readonly pb::FieldCodec<string> _repeated_value_codec
            = pb::FieldCodec.ForString(10);
        private readonly pbc::RepeatedField<string> value_ = new pbc::RepeatedField<string>();
        /// <summary>
        /// String feature value with a length limit of 128 bytes.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<string> Value {
          get { return value_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as StringList);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(StringList other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!value_.Equals(other.value_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= value_.GetHashCode();
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
          value_.WriteTo(output, _repeated_value_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          value_.WriteTo(ref output, _repeated_value_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          size += value_.CalculateSize(_repeated_value_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(StringList other) {
          if (other == null) {
            return;
          }
          value_.Add(other.value_);
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
                value_.AddEntriesFrom(input, _repeated_value_codec);
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
                value_.AddEntriesFrom(ref input, _repeated_value_codec);
                break;
              }
            }
          }
        }
        #endif

      }

      /// <summary>
      /// A list of float features.
      /// </summary>
      public sealed partial class FloatList : pb::IMessage<FloatList>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<FloatList> _parser = new pb::MessageParser<FloatList>(() => new FloatList());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<FloatList> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.RecommendationEngine.V1Beta1.FeatureMap.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public FloatList() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public FloatList(FloatList other) : this() {
          value_ = other.value_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public FloatList Clone() {
          return new FloatList(this);
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 1;
        private static readonly pb::FieldCodec<float> _repeated_value_codec
            = pb::FieldCodec.ForFloat(10);
        private readonly pbc::RepeatedField<float> value_ = new pbc::RepeatedField<float>();
        /// <summary>
        /// Float feature value.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<float> Value {
          get { return value_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as FloatList);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(FloatList other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!value_.Equals(other.value_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= value_.GetHashCode();
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
          value_.WriteTo(output, _repeated_value_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          value_.WriteTo(ref output, _repeated_value_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          size += value_.CalculateSize(_repeated_value_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(FloatList other) {
          if (other == null) {
            return;
          }
          value_.Add(other.value_);
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
              case 10:
              case 13: {
                value_.AddEntriesFrom(input, _repeated_value_codec);
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
              case 10:
              case 13: {
                value_.AddEntriesFrom(ref input, _repeated_value_codec);
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
