Imports System
Imports Core.Bll
Imports Core.dal

<Serializable()> _
Public Class Role
    Inherits Core.Bll.DictionaryBase(Of Guid)

    Public Shared ReadOnly AnalizeSectionWorker As New Guid("819D6F92-8E66-43A9-B3F3-15057FA61B0D")
    Public Shared ReadOnly TPDAssistent As New Guid("6DCE3C98-5BBC-49AB-8054-28642B5F3CF3")
    Public Shared ReadOnly Coordinator As New Guid("6FCDC07B-4245-4F06-9CAF-5D1AABE3BDE0")
    Public Shared ReadOnly TPDdirector As New Guid("44D2FEF3-1F17-4073-807A-C89C26052BFD")
    Public Shared ReadOnly Administrator As New Guid("3DB6296A-EA4F-490B-9C8B-E13E1B8AAF48")
    Public Shared ReadOnly Inspector As New Guid("C20C01EF-1F21-4457-AABA-9804016757BA")
    Public Shared ReadOnly CAEmployee As New Guid("D86C1F92-3246-4ABB-A016-1B702EE4110C")

    'HACK: jāuzliek atpakaļ ierobežojums uz defaulto lomu maiņu
    Private ImmutableRoleIds() As Guid = {} ' {AnalizeSectionWorker, TPDAssistent, Coordinator, TPDdirector, Administrator}

#Region "Private members"
    Private _permissions As Core.Dal.IChildCollection(Of Permission)
    Private _name As String
    Private _nameTouched As Boolean = False
    Private _oldName As String = String.Empty
    Private _activeUsers As IList(Of User)
    Private _mutexesInUse As New Dictionary(Of String, Permission)
    Private _wasJustDeleted As Boolean = False
    Private _permsChanged As Boolean = False
#End Region
#Region "Constructors"
    Protected Sub New()
        AddBusinessRules()
        _nameTouched = False
        _wasJustDeleted = False
        _oldName = String.Empty
        _permsChanged = False
    End Sub
    Public Sub New(ByVal session As ISession)
        Permissions = New Core.Dal.ChildCollection(Of Permission)
        _activeUsers = New List(Of User)
        AddBusinessRules()
        _nameTouched = False
        _wasJustDeleted = False
        _oldName = String.Empty
        _permsChanged = False
    End Sub
    Private Sub AddBusinessRules()
        Me.Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckRequired, "Name")
        Me.Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckMaxLength, "Name", 50)
    End Sub
#End Region

    Public Overrides Property IsActive() As Boolean
        Get
            Return MyBase.IsActive
        End Get
        Set(ByVal value As Boolean)
            If value <> Me.IsActive AndAlso value = False Then
                Me._wasJustDeleted = True
            Else
                Me._wasJustDeleted = False
            End If
            MyBase.IsActive = value
        End Set
    End Property
    ''' <summary>
    ''' For logging purposes only: used to determine if the entry has just been set inactive
    ''' </summary>
    Public Overridable Property WasJustDeleted() As Boolean
        Get
            Return Me._wasJustDeleted
        End Get
        Set(ByVal value As Boolean)
            _wasJustDeleted = value
        End Set
    End Property
    Public Overridable Property Permissions() As Core.Dal.IChildCollection(Of Permission)
        Get
            Return _permissions
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of Permission))
            '_permissions = value
            '_permissions.Parent = Me
            Assign("Permissions", value, _permissions)
        End Set
    End Property
    Public Overridable Property PermsChanged() As Boolean
        Get
            Return _permsChanged
        End Get
        Set(ByVal value As Boolean)
            _permsChanged = value
        End Set
    End Property

    ''' <summary>
    ''' Lomas nosaukums
    ''' </summary>
    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            If Me.Name <> value Then
                Me._nameTouched = True
                _oldName = Me.Name
            End If
            Assign("Name", value, _name)
        End Set
    End Property
    ''' <summary>
    ''' For logging purposes only: Name property has been changed
    ''' </summary>
    Public Overridable Property NameTouched() As Boolean
        Get
            Return Me._nameTouched
        End Get
        Set(ByVal value As Boolean)
            _nameTouched = value
        End Set
    End Property
    ''' <summary>
    ''' For logging purposes only: previous value of name property
    ''' </summary>
    Public Overridable Property OldName() As String
        Get
            Return _oldName
        End Get
        Set(ByVal value As String)
            _oldName = value
        End Set
    End Property

    ''' <summary>
    ''' Lomai piesaistītie lietotāji
    ''' </summary>
    Public Overridable Property ActiveUsers() As IList(Of User)
        Get
            Return _activeUsers
        End Get
        Set(ByVal value As IList(Of User))
            _activeUsers = value
        End Set
    End Property

    ''' <summary>
    ''' Vai lomai ir aktīvi lietotāji
    ''' </summary>
    Public Overridable ReadOnly Property HasUsers() As Boolean
        Get
            If Id = Guid.Empty Then
                Return False
            Else
                Return ActiveUsers.Count > 0
            End If
        End Get
    End Property

    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Dim result As Boolean = MyBase.CanEdit
            ' ToDo: Tiesību pārbaude
            If result Then result = Not IsImmutable
            Return result
        End Get
    End Property

    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Dim result As Boolean = MyBase.CanDelete
            If result Then result = Not IsImmutable
            Return result
        End Get
    End Property

    Private ReadOnly Property IsImmutable() As Boolean
        Get
#If Not Debug Then
                Return System.Array.IndexOf(ImmutableRoleIds, Me.Id) <> -1
#Else
            Return False
#End If
        End Get
    End Property

    Public Shared Function ListSource(ByVal session As Core.Dal.ISession) As IList(Of Role)
        Dim criteria As New List(Of Core.Dal.Expressions.CriterionBase)
        criteria.Add(New Core.Dal.Expressions.IsNull("DeleteTime"))
        Return session.CreateAndBuildCriteria(Of Role)(criteria).List(Of Role)()
    End Function

    Public Overrides Function ToString() As String
        Return Me.Name
    End Function

    Protected Overrides Sub OnSaveNew()
        MyBase.OnSaveNew()
        Core.Logger.DB.Log(GetSession, AuditMessage.RoleCreate, Me.Name)
    End Sub
End Class
