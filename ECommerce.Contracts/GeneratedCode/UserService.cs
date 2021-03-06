// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: UserService.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ECommerce.Contracts {

  /// <summary>Holder for reflection information generated from UserService.proto</summary>
  public static partial class UserServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for UserService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFVc2VyU2VydmljZS5wcm90bxITRUNvbW1lcmNlLkNvbnRyYWN0cyIgCg5H",
            "ZXRVc2VyUmVxdWVzdBIOCgZVc2VySWQYASABKAMijAEKD0dldFVzZXJSZXNw",
            "b25zZRIPCgdJc0ZvdW5kGAEgASgIEg4KBlVzZXJJZBgCIAEoAxIRCglGaXJz",
            "dE5hbWUYAyABKAkSEAoITGFzdE5hbWUYBCABKAkSMwoLRGF0ZU9mQmlydGgY",
            "BSABKAsyHi5FQ29tbWVyY2UuQ29udHJhY3RzLlRpbWVzdGFtcCIaCglUaW1l",
            "c3RhbXASDQoFRXBvY2gYASABKAMyaQoLVXNlclNlcnZpY2USWgoLR2V0VXNl",
            "ckJ5SWQSIy5FQ29tbWVyY2UuQ29udHJhY3RzLkdldFVzZXJSZXF1ZXN0GiQu",
            "RUNvbW1lcmNlLkNvbnRyYWN0cy5HZXRVc2VyUmVzcG9uc2UiAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ECommerce.Contracts.GetUserRequest), global::ECommerce.Contracts.GetUserRequest.Parser, new[]{ "UserId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ECommerce.Contracts.GetUserResponse), global::ECommerce.Contracts.GetUserResponse.Parser, new[]{ "IsFound", "UserId", "FirstName", "LastName", "DateOfBirth" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ECommerce.Contracts.Timestamp), global::ECommerce.Contracts.Timestamp.Parser, new[]{ "Epoch" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetUserRequest : pb::IMessage<GetUserRequest> {
    private static readonly pb::MessageParser<GetUserRequest> _parser = new pb::MessageParser<GetUserRequest>(() => new GetUserRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetUserRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ECommerce.Contracts.UserServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserRequest(GetUserRequest other) : this() {
      userId_ = other.userId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserRequest Clone() {
      return new GetUserRequest(this);
    }

    /// <summary>Field number for the "UserId" field.</summary>
    public const int UserIdFieldNumber = 1;
    private long userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetUserRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetUserRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0L) hash ^= UserId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(UserId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetUserRequest other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0L) {
        UserId = other.UserId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            UserId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetUserResponse : pb::IMessage<GetUserResponse> {
    private static readonly pb::MessageParser<GetUserResponse> _parser = new pb::MessageParser<GetUserResponse>(() => new GetUserResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetUserResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ECommerce.Contracts.UserServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserResponse(GetUserResponse other) : this() {
      isFound_ = other.isFound_;
      userId_ = other.userId_;
      firstName_ = other.firstName_;
      lastName_ = other.lastName_;
      DateOfBirth = other.dateOfBirth_ != null ? other.DateOfBirth.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserResponse Clone() {
      return new GetUserResponse(this);
    }

    /// <summary>Field number for the "IsFound" field.</summary>
    public const int IsFoundFieldNumber = 1;
    private bool isFound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsFound {
      get { return isFound_; }
      set {
        isFound_ = value;
      }
    }

    /// <summary>Field number for the "UserId" field.</summary>
    public const int UserIdFieldNumber = 2;
    private long userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "FirstName" field.</summary>
    public const int FirstNameFieldNumber = 3;
    private string firstName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LastName" field.</summary>
    public const int LastNameFieldNumber = 4;
    private string lastName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DateOfBirth" field.</summary>
    public const int DateOfBirthFieldNumber = 5;
    private global::ECommerce.Contracts.Timestamp dateOfBirth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ECommerce.Contracts.Timestamp DateOfBirth {
      get { return dateOfBirth_; }
      set {
        dateOfBirth_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetUserResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetUserResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsFound != other.IsFound) return false;
      if (UserId != other.UserId) return false;
      if (FirstName != other.FirstName) return false;
      if (LastName != other.LastName) return false;
      if (!object.Equals(DateOfBirth, other.DateOfBirth)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsFound != false) hash ^= IsFound.GetHashCode();
      if (UserId != 0L) hash ^= UserId.GetHashCode();
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
      if (dateOfBirth_ != null) hash ^= DateOfBirth.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IsFound != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsFound);
      }
      if (UserId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(UserId);
      }
      if (FirstName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LastName);
      }
      if (dateOfBirth_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(DateOfBirth);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsFound != false) {
        size += 1 + 1;
      }
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (dateOfBirth_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateOfBirth);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetUserResponse other) {
      if (other == null) {
        return;
      }
      if (other.IsFound != false) {
        IsFound = other.IsFound;
      }
      if (other.UserId != 0L) {
        UserId = other.UserId;
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
      }
      if (other.dateOfBirth_ != null) {
        if (dateOfBirth_ == null) {
          dateOfBirth_ = new global::ECommerce.Contracts.Timestamp();
        }
        DateOfBirth.MergeFrom(other.DateOfBirth);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            IsFound = input.ReadBool();
            break;
          }
          case 16: {
            UserId = input.ReadInt64();
            break;
          }
          case 26: {
            FirstName = input.ReadString();
            break;
          }
          case 34: {
            LastName = input.ReadString();
            break;
          }
          case 42: {
            if (dateOfBirth_ == null) {
              dateOfBirth_ = new global::ECommerce.Contracts.Timestamp();
            }
            input.ReadMessage(dateOfBirth_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Timestamp : pb::IMessage<Timestamp> {
    private static readonly pb::MessageParser<Timestamp> _parser = new pb::MessageParser<Timestamp>(() => new Timestamp());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Timestamp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ECommerce.Contracts.UserServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Timestamp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Timestamp(Timestamp other) : this() {
      epoch_ = other.epoch_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Timestamp Clone() {
      return new Timestamp(this);
    }

    /// <summary>Field number for the "Epoch" field.</summary>
    public const int EpochFieldNumber = 1;
    private long epoch_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Epoch {
      get { return epoch_; }
      set {
        epoch_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Timestamp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Timestamp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Epoch != other.Epoch) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Epoch != 0L) hash ^= Epoch.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Epoch != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Epoch);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Epoch != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Epoch);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Timestamp other) {
      if (other == null) {
        return;
      }
      if (other.Epoch != 0L) {
        Epoch = other.Epoch;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Epoch = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
