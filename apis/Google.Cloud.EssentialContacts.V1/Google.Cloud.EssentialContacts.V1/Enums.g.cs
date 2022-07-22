// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/essentialcontacts/v1/enums.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.EssentialContacts.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/essentialcontacts/v1/enums.proto</summary>
  public static partial class EnumsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/essentialcontacts/v1/enums.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnumsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvY2xvdWQvZXNzZW50aWFsY29udGFjdHMvdjEvZW51bXMucHJv",
            "dG8SIWdvb2dsZS5jbG91ZC5lc3NlbnRpYWxjb250YWN0cy52MSq5AQoUTm90",
            "aWZpY2F0aW9uQ2F0ZWdvcnkSJQohTk9USUZJQ0FUSU9OX0NBVEVHT1JZX1VO",
            "U1BFQ0lGSUVEEAASBwoDQUxMEAISDgoKU1VTUEVOU0lPThADEgwKCFNFQ1VS",
            "SVRZEAUSDQoJVEVDSE5JQ0FMEAYSCwoHQklMTElORxAHEgkKBUxFR0FMEAgS",
            "EwoPUFJPRFVDVF9VUERBVEVTEAkSFwoTVEVDSE5JQ0FMX0lOQ0lERU5UUxAK",
            "KksKD1ZhbGlkYXRpb25TdGF0ZRIgChxWQUxJREFUSU9OX1NUQVRFX1VOU1BF",
            "Q0lGSUVEEAASCQoFVkFMSUQQARILCgdJTlZBTElEEAJC+AEKJWNvbS5nb29n",
            "bGUuY2xvdWQuZXNzZW50aWFsY29udGFjdHMudjFCCkVudW1zUHJvdG9QAVpS",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9l",
            "c3NlbnRpYWxjb250YWN0cy92MTtlc3NlbnRpYWxjb250YWN0c6oCIUdvb2ds",
            "ZS5DbG91ZC5Fc3NlbnRpYWxDb250YWN0cy5WMcoCIUdvb2dsZVxDbG91ZFxF",
            "c3NlbnRpYWxDb250YWN0c1xWMeoCJEdvb2dsZTo6Q2xvdWQ6OkVzc2VudGlh",
            "bENvbnRhY3RzOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.EssentialContacts.V1.NotificationCategory), typeof(global::Google.Cloud.EssentialContacts.V1.ValidationState), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The notification categories that an essential contact can be subscribed to.
  /// Each notification will be categorized by the sender into one of the following
  /// categories. All contacts that are subscribed to that category will receive
  /// the notification.
  /// </summary>
  public enum NotificationCategory {
    /// <summary>
    /// Notification category is unrecognized or unspecified.
    /// </summary>
    [pbr::OriginalName("NOTIFICATION_CATEGORY_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// All notifications related to the resource, including notifications
    /// pertaining to categories added in the future.
    /// </summary>
    [pbr::OriginalName("ALL")] All = 2,
    /// <summary>
    /// Notifications related to imminent account suspension.
    /// </summary>
    [pbr::OriginalName("SUSPENSION")] Suspension = 3,
    /// <summary>
    /// Notifications related to security/privacy incidents, notifications, and
    /// vulnerabilities.
    /// </summary>
    [pbr::OriginalName("SECURITY")] Security = 5,
    /// <summary>
    /// Notifications related to technical events and issues such as outages,
    /// errors, or bugs.
    /// </summary>
    [pbr::OriginalName("TECHNICAL")] Technical = 6,
    /// <summary>
    /// Notifications related to billing and payments notifications, price updates,
    /// errors, or credits.
    /// </summary>
    [pbr::OriginalName("BILLING")] Billing = 7,
    /// <summary>
    /// Notifications related to enforcement actions, regulatory compliance, or
    /// government notices.
    /// </summary>
    [pbr::OriginalName("LEGAL")] Legal = 8,
    /// <summary>
    /// Notifications related to new versions, product terms updates, or
    /// deprecations.
    /// </summary>
    [pbr::OriginalName("PRODUCT_UPDATES")] ProductUpdates = 9,
    /// <summary>
    /// Child category of TECHNICAL. If assigned, technical incident notifications
    /// will go to these contacts instead of TECHNICAL.
    /// </summary>
    [pbr::OriginalName("TECHNICAL_INCIDENTS")] TechnicalIncidents = 10,
  }

  /// <summary>
  /// A contact's validation state indicates whether or not it is the correct
  /// contact to be receiving notifications for a particular resource.
  /// </summary>
  public enum ValidationState {
    /// <summary>
    /// The validation state is unknown or unspecified.
    /// </summary>
    [pbr::OriginalName("VALIDATION_STATE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The contact is marked as valid. This is usually done manually by the
    /// contact admin. All new contacts begin in the valid state.
    /// </summary>
    [pbr::OriginalName("VALID")] Valid = 1,
    /// <summary>
    /// The contact is considered invalid. This may become the state if the
    /// contact's email is found to be unreachable.
    /// </summary>
    [pbr::OriginalName("INVALID")] Invalid = 2,
  }

  #endregion

}

#endregion Designer generated code
