Imports System
Imports Core.Bll
Imports Core.Dal
Imports System.Xml.Serialization

'Audit notification management

<Serializable()> _
Public Class LogEntryConfig
    Inherits Core.Bll.BusinessObjectBase(Of Guid)

#Region "Private variables"

    Private _actionId As AuditMessage
    Private _currentUser As Integer
    Private _useForSend As Integer
    Private _isUseForSend As Boolean
    Private _eMails As String
    Private _user As User
    Private _role As Role

#End Region

#Region "Getter&Setters"

    ''' <summary>
    ''' Audita ziņojuma ID
    ''' </summary>
    <XmlIgnore()> _
    Public Overridable Property ActionId() As AuditMessage
        Get
            Return _actionId
        End Get
        Set(ByVal value As AuditMessage)
            Assign("ActionId", value, _actionId)
        End Set
    End Property

    ''' <summary>
    ''' Sūtīt ziņojumu lietotājam, kurš veicis labojumu
    ''' </summary>
    Public Overridable Property CurrentUser() As Integer
        Get
            Return _currentUser
        End Get
        Set(ByVal value As Integer)
            Assign("CurrentUser", value, _currentUser)
        End Set
    End Property


    Public Overridable Property UseForSend() As Integer
        Get
            Return _useForSend
        End Get
        Set(ByVal value As Integer)
            Assign("UseForSend", value, _useForSend)
        End Set
    End Property

    Public Overridable Property IsUseForSend() As Boolean
        Get
            If UseForSend = 0 Then _isUseForSend = False
            If UseForSend = 1 Then _isUseForSend = True
            Return _isUseForSend
        End Get
        Set(ByVal value As Boolean)
            _isUseForSend = value

            If _isUseForSend = False Then UseForSend = 0
            If _isUseForSend = True Then UseForSend = 1

        End Set
    End Property

    ''' <summary>
    ''' Sūtīt ziņojumu konkrētām e-pasta adresēm
    ''' </summary>
    Public Overridable Property EMails() As String
        Get
            Return _eMails
        End Get
        Set(ByVal value As String)
            Assign("EMails", value, _eMails)
        End Set
    End Property

    ''' <summary>
    ''' Sūtīt atgādinājumu konkrētam lietotājam
    ''' </summary>
    <XmlIgnore()> _
    Public Overridable Property User() As User
        Get
            Return _user
        End Get
        Set(ByVal value As User)
            Assign("User", value, _user)
        End Set
    End Property

    ''' <summary>
    ''' Sūtīt ziņojumu lietotājiem ar konkrētu lomu
    ''' </summary>
    <XmlIgnore()> _
    Public Overridable Property Role() As Role
        Get
            Return _role
        End Get
        Set(ByVal value As Role)
            Assign("Role", value, _role)
        End Set
    End Property
#End Region

    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Return CanDo("Logging.Management")
        End Get
    End Property

    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Return CanDo("Logging.Management")
        End Get
    End Property


End Class

<Serializable()> _
Public Class LogEntryConfigCurrentUser
    Inherits LogEntryConfig
    Private _isCurrentUser As Boolean
    Private _canEditData As Boolean
    Private _isUseForSend As Boolean

    Public Sub New()
        _isCurrentUser = False
    End Sub

    Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
        MyBase.OnPropertyChanged(propertyName)
        Select Case propertyName
            Case "IsCurrentUser"
                OnPropertyChanged("CanAddParameters")
        End Select
    End Sub

    Public Overridable ReadOnly Property CanAddParameters() As Boolean
        Get
            Return CanEdit And IsUseForSend
        End Get
    End Property


    Public Overridable Property IsCurrentUser() As Boolean
        Get
            If CurrentUser = 0 Then _isCurrentUser = False
            If CurrentUser = 1 Then _isCurrentUser = True
            Return _isCurrentUser
        End Get
        Set(ByVal value As Boolean)
            _isCurrentUser = value

            If _isCurrentUser = False Then CurrentUser = 0
            If _isCurrentUser = True Then CurrentUser = 1

        End Set
    End Property

    Public Overrides Property IsUseForSend() As Boolean
        Get
            If UseForSend = 0 Then _isUseForSend = False
            If UseForSend = 1 Then _isUseForSend = True
            Return _isUseForSend
        End Get
        Set(ByVal value As Boolean)
            _isUseForSend = value

            If _isUseForSend = False Then UseForSend = 0
            If _isUseForSend = True Then UseForSend = 1

            Dim eLogEntryConfigEmail As Entities(Of LogEntryConfigEmail) = Entities(Of LogEntryConfigEmail).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            For Each obj As LogEntryConfigEmail In eLogEntryConfigEmail
                If obj.IsActive Then obj.IsUseForSend = _isUseForSend
            Next

            Dim eLogEntryConfigPosition As Entities(Of LogEntryConfigPosition) = Entities(Of LogEntryConfigPosition).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            For Each obj As LogEntryConfigPosition In eLogEntryConfigPosition
                If obj.IsActive Then obj.IsUseForSend = _isUseForSend
            Next

            Dim eLogEntryConfigRole As Entities(Of LogEntryConfigRole) = Entities(Of LogEntryConfigRole).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            For Each obj As LogEntryConfigRole In eLogEntryConfigRole
                If obj.IsActive Then obj.IsUseForSend = _isUseForSend
            Next

            Dim eLogEntryConfigUser As Entities(Of LogEntryConfigUser) = Entities(Of LogEntryConfigUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            For Each obj As LogEntryConfigUser In eLogEntryConfigUser
                If obj.IsActive Then obj.IsUseForSend = _isUseForSend
            Next

        End Set
    End Property


    Public Shared Function FillCompulsoryCriterion(ByVal session As Core.Dal.ISession) As IList(Of Core.Dal.Expressions.CriterionBase)
        Dim result As New List(Of Core.Dal.Expressions.CriterionBase)
        result.Add(New Core.Dal.Expressions.IsNotNull("CurrentUser"))
        Return result
    End Function
End Class

<Serializable()> _
Public Class LogEntryConfigUser
    Inherits LogEntryConfig

    Public Sub New()
        Validator.AddBusinessRule("User", AddressOf CommonBusinessRules.CheckRequired, "User")

        'Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
        'If eLogEntryConfigCurrentUser.Count > 0 Then Me.IsUseForSend = eLogEntryConfigCurrentUser.Item(0).IsUseForSend

    End Sub

    Public Shared Function FillCompulsoryCriterion(ByVal session As Core.Dal.ISession) As IList(Of Core.Dal.Expressions.CriterionBase)
        Dim result As New List(Of Core.Dal.Expressions.CriterionBase)
        result.Add(New Core.Dal.Expressions.IsNotNull("User"))
        Return result
    End Function

    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            If eLogEntryConfigCurrentUser.Count > 0 Then Return eLogEntryConfigCurrentUser.Item(0).IsUseForSend And eLogEntryConfigCurrentUser.Item(0).CanEdit And Me.IsActive
            Return False
        End Get
    End Property

    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            If eLogEntryConfigCurrentUser.Count > 0 Then Return eLogEntryConfigCurrentUser.Item(0).IsUseForSend And eLogEntryConfigCurrentUser.Item(0).CanEdit And Me.IsActive
            Return False
        End Get
    End Property

    Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
        MyBase.OnPropertyChanged(propertyName)
        Select Case propertyName
            Case "IsCurrentUser"
                OnPropertyChanged("CanEditData")
            Case "CurrentUser"
                OnPropertyChanged("CanEditData")
            Case "IsCurrentUser"
                OnPropertyChanged("CanEdit")
                OnPropertyChanged("CanDelete")
        End Select
    End Sub

End Class

<Serializable()> _
Public Class LogEntryConfigRole
    Inherits LogEntryConfig

    Public Sub New()
        Validator.AddBusinessRule("Role", AddressOf CommonBusinessRules.CheckRequired, "Role")
        'Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
        'If eLogEntryConfigCurrentUser.Count > 0 Then Me.IsUseForSend = eLogEntryConfigCurrentUser.Item(0).IsUseForSend

    End Sub

    Public Shared Function FillCompulsoryCriterion(ByVal session As Core.Dal.ISession) As IList(Of Core.Dal.Expressions.CriterionBase)
        Dim result As New List(Of Core.Dal.Expressions.CriterionBase)
        result.Add(New Core.Dal.Expressions.IsNotNull("Role"))
        Return result
    End Function

    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            If eLogEntryConfigCurrentUser.Count > 0 Then Return eLogEntryConfigCurrentUser.Item(0).IsUseForSend And eLogEntryConfigCurrentUser.Item(0).CanEdit And Me.IsActive
            Return False
        End Get
    End Property

    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            If eLogEntryConfigCurrentUser.Count > 0 Then Return eLogEntryConfigCurrentUser.Item(0).IsUseForSend And eLogEntryConfigCurrentUser.Item(0).CanEdit And Me.IsActive
            Return False
        End Get
    End Property

    Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
        MyBase.OnPropertyChanged(propertyName)
        Select Case propertyName
            Case "IsCurrentUser"
                OnPropertyChanged("CanEditData")
            Case "CurrentUser"
                OnPropertyChanged("CanEditData")
            Case "IsCurrentUser"
                OnPropertyChanged("CanEdit")
                OnPropertyChanged("CanDelete")
        End Select
    End Sub


End Class

<Serializable()> _
Public Class LogEntryConfigPosition
    Inherits LogEntryConfig

    Public Sub New()
        Validator.AddBusinessRule("Position", AddressOf CommonBusinessRules.CheckRequired, "Position")

        'Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
        'If eLogEntryConfigCurrentUser.Count > 0 Then Me.IsUseForSend = eLogEntryConfigCurrentUser.Item(0).IsUseForSend

    End Sub

    Public Shared Function FillCompulsoryCriterion(ByVal session As Core.Dal.ISession) As IList(Of Core.Dal.Expressions.CriterionBase)
        Dim result As New List(Of Core.Dal.Expressions.CriterionBase)
        result.Add(New Core.Dal.Expressions.IsNotNull("Position"))
        Return result
    End Function

    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            If eLogEntryConfigCurrentUser.Count > 0 Then Return eLogEntryConfigCurrentUser.Item(0).IsUseForSend And eLogEntryConfigCurrentUser.Item(0).CanEdit And Me.IsActive
            Return False
        End Get
    End Property

    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            If eLogEntryConfigCurrentUser.Count > 0 Then Return eLogEntryConfigCurrentUser.Item(0).IsUseForSend And eLogEntryConfigCurrentUser.Item(0).CanEdit And Me.IsActive
            Return False
        End Get
    End Property

    Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
        MyBase.OnPropertyChanged(propertyName)
        Select Case propertyName
            Case "IsCurrentUser"
                OnPropertyChanged("CanEditData")
            Case "CurrentUser"
                OnPropertyChanged("CanEditData")
            Case "IsCurrentUser"
                OnPropertyChanged("CanEdit")
                OnPropertyChanged("CanDelete")
        End Select
    End Sub

End Class

<Serializable()> _
Public Class LogEntryConfigEmail
    Inherits LogEntryConfig

    Public Sub New()
        Validator.AddBusinessRule("EMails", AddressOf CommonBusinessRules.CheckRequired, "EMails")
        Validator.AddBusinessRule("EMails", AddressOf CommonBusinessRules.CheckEmailFormat, "EMails")
        'Validator.AddBusinessRule("EMail", AddressOf CommonBusinessRules.CheckEmailFormat, "EMail")
        'Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
        'If eLogEntryConfigCurrentUser.Count > 0 Then Me.IsUseForSend = eLogEntryConfigCurrentUser.Item(0).IsUseForSend

    End Sub

    Public Shared Function FillCompulsoryCriterion(ByVal session As Core.Dal.ISession) As IList(Of Core.Dal.Expressions.CriterionBase)
        Dim result As New List(Of Core.Dal.Expressions.CriterionBase)
        result.Add(New Core.Dal.Expressions.IsNotNull("EMails"))
        Return result
    End Function



    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            If eLogEntryConfigCurrentUser.Count > 0 Then Return eLogEntryConfigCurrentUser.Item(0).IsUseForSend And eLogEntryConfigCurrentUser.Item(0).CanEdit And Me.IsActive
            Return False
        End Get
    End Property

    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Dim eLogEntryConfigCurrentUser As Entities(Of LogEntryConfigCurrentUser) = Entities(Of LogEntryConfigCurrentUser).GetAll(Me.GetSession, New Core.Dal.Expressions.Eq("ActionId", ActionId))
            If eLogEntryConfigCurrentUser.Count > 0 Then Return eLogEntryConfigCurrentUser.Item(0).IsUseForSend And eLogEntryConfigCurrentUser.Item(0).CanEdit And Me.IsActive
            Return False
        End Get
    End Property

    Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
        MyBase.OnPropertyChanged(propertyName)
        Select Case propertyName
            Case "IsCurrentUser"
                OnPropertyChanged("CanEditData")
            Case "CurrentUser"
                OnPropertyChanged("CanEditData")
            Case "IsCurrentUser"
                OnPropertyChanged("CanEdit")
                OnPropertyChanged("CanDelete")
        End Select
    End Sub

End Class

' Уныкоде