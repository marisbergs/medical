Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class Activity
    Inherits BusinessObjectBase(Of Guid)

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        CreateDate = Now
        CreateUser = Context.Current.AuthenticatedUser
        AddBusinessRoles()
    End Sub
    Public Sub New()
        AddBusinessRoles()
    End Sub

    Private Sub AddBusinessRoles()
        Validator.AddBusinessRule("Patient", AddressOf CommonBusinessRules.CheckOneOfTwoRequired, "Patient", "User")
        Validator.AddBusinessRule("ActivityDate", AddressOf CommonBusinessRules.CheckRequired, "ActivityDate")
        Validator.AddBusinessRule("RemindDate", AddressOf CommonBusinessRules.CheckRequired, "RemindDate")
    End Sub

#Region "Private members"
    Private _patient As Patient
    Private _user As User
    Private _service As Services
    Private _revactinacion As Boolean
    Private _activityDate As Nullable(Of DateTime)
    Private _comments As String
    Private _createUser As User
    Private _createDate As DateTime
    Private _remindDate As DateTime
    Private _group As Guid
    Private _visit As Visit
    Private _sendSMS As Boolean

#End Region

#Region "Public member"

    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            Assign("Patient", value, _patient)
        End Set
    End Property

    Public Overridable Property User() As User
        Get
            Return _user
        End Get
        Set(ByVal value As User)
            Assign("User", value, _user)
        End Set
    End Property

    Public Overridable Property Service() As Services
        Get
            Return _service
        End Get
        Set(ByVal value As Services)
            Assign("Service", value, _service)
        End Set
    End Property

    Public Overridable Property Revactinacion() As Boolean
        Get
            Return _revactinacion
        End Get
        Set(ByVal value As Boolean)
            Assign("Revactinacion", value, _revactinacion)
        End Set
    End Property

    Public Overridable Property ActivityDate() As Nullable(Of Date)
        Get
            Return _activityDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("ActivityDate", value, _activityDate)
        End Set
    End Property

    Public Overridable Property Comments() As String
        Get
            Return _comments
        End Get
        Set(ByVal value As String)
            Assign("Comments", value, _comments)
        End Set
    End Property

    Public Overridable Property CreateUser() As User
        Get
            Return _createUser
        End Get
        Set(ByVal value As User)
            Assign("CreateUser", value, _createUser)
        End Set
    End Property

    Public Overridable Property CreateDate() As Date
        Get
            Return _createDate
        End Get
        Set(ByVal value As Date)
            Assign("CreateDate", value, _createDate)
        End Set
    End Property

    Public Overridable Property RemindDate() As Date
        Get
            Return _remindDate
        End Get
        Set(ByVal value As Date)
            Assign("RemindDate", value, _remindDate)
        End Set
    End Property

    Public Overridable Property Group() As Guid
        Get
            Return _group
        End Get
        Set(ByVal value As Guid)
            Assign("Group", value, _group)
        End Set
    End Property

    Public Overridable Property Visit() As Visit
        Get
            Return _visit
        End Get
        Set(ByVal value As Visit)
            Assign("Visit", value, _visit)
        End Set
    End Property

    Public Overridable Property SendSMS() As Boolean
        Get
            Return _sendSMS
        End Get
        Set(ByVal value As Boolean)
            Assign("SendSMS", value, _sendSMS)
        End Set
    End Property

#End Region

End Class
