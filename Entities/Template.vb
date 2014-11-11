Imports Core.Dal
Imports Core.Bll
Imports Core.Dal.Expressions

Public Class Template
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.ISynchronizesSeparately

    Public Shared ReadOnly PatientRegistrationWithGuardians As New Guid("9A4238B9-A9B2-47F8-8476-9A3A016A11B8")
    Public Shared ReadOnly PatientRegistration As New Guid("F38D4CFD-7DCB-4525-B589-9A3B000AD5BF")
    Public Shared ReadOnly Prescription As New Guid("B5135A49-24F9-4633-938F-9A4500108CF8")
    Public Shared ReadOnly RtgSummary As New Guid("c43f6f58-0abd-4549-a92a-9d21001c2ec6")
    Public Shared ReadOnly Visits As New Guid("A18968E3-2982-41B5-AD04-9A840188F7EA")
    Public Shared ReadOnly DoctorList As New Guid("F793D3FB-A3DF-453D-8EDB-9A9E009F44A2")
    Public Shared ReadOnly PatientList As New Guid("340AEB8F-313F-48A4-AD10-9A9F015B3AD9")
    Public Shared ReadOnly PricelistWithoutCode As New Guid("31784AA0-4048-48B2-B475-9ABD01838385")
    Public Shared ReadOnly PricelistWithCode As New Guid("527F91E2-2D30-421C-98EE-9ABB00D977BB")
    Public Shared ReadOnly DenticalCard As New Guid("F3A28BEB-673E-4498-B8CD-9F9C00F67E90")

#Region "Private members"
    Private _type As TemplateType
    Private _code As String
    Private _name As String
    Private _description As String
    Private _validFrom As Nullable(Of DateTime)
    Private _validUntil As Nullable(Of DateTime)
    Private _currentVersion As TemplateFileVersion = Nothing
    Private _files As IChildCollection(Of TemplateFileVersion)
#End Region

    Public Overridable Property Type() As TemplateType
        Get
            Return _type
        End Get
        Set(ByVal value As TemplateType)
            If CanChangeType Then
                Assign("Type", value, _type)
            Else
                Throw New Core.CriticalException("Invalid attempt to change Type property of Template object")
            End If
        End Set
    End Property

    Public Overridable Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            If CanChangeTypeOrCode Then
                Assign("Code", value, _code)
            Else
                Throw New Core.CriticalException("Invalid attempt to change Code property of Template object")
            End If
        End Set
    End Property

    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            Assign("Name", value, _name)
        End Set
    End Property

    Public Overridable Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            Assign("Description", value, _description)
        End Set
    End Property

    Public Overridable Property ValidFrom() As Nullable(Of DateTime)
        Get
            Return _validFrom
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("ValidFrom", value, _validFrom)
        End Set
    End Property

    Public Overridable Property ValidUntil() As Nullable(Of DateTime)
        Get
            Return _validUntil
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("ValidUntil", value, _validUntil)
        End Set
    End Property

    Public Overridable Property Files() As IChildCollection(Of TemplateFileVersion)
        Get
            Return _files
        End Get
        Protected Set(ByVal value As IChildCollection(Of TemplateFileVersion))
            Assign("Files", value, _files)
        End Set
    End Property

    Public Overridable ReadOnly Property CurrentVersion() As TemplateFileVersion
        Get
            If (_currentVersion Is Nothing OrElse _currentVersion.IsActive = False) AndAlso Files.Count > 0 Then
                Dim maxVersion As Integer = -1
                For Each tfv As TemplateFileVersion In Files
                    If tfv.IsActive Then
                        If Not tfv.ValidFrom.HasValue OrElse tfv.ValidFrom.Value.Date <= DateTime.Today Then
                            If Not tfv.ValidUntil.HasValue OrElse DateTime.Today <= tfv.ValidUntil.Value.Date Then
                                If tfv.VersionNumber > maxVersion Then
                                    maxVersion = tfv.VersionNumber
                                    _currentVersion = tfv
                                End If
                            End If
                        End If
                    End If
                Next
            End If
            Return _currentVersion
        End Get
    End Property

    Public Overrides ReadOnly Property IsValid() As Boolean
        Get
            Return MyBase.IsValid AndAlso Files.IsValid
        End Get
    End Property


    Private Sub AddBusinessRules()
        Me.Validator.AddBusinessRule("Type", AddressOf CommonBusinessRules.CheckRequired, "Type")
        Me.Validator.AddBusinessRule("Code", AddressOf CommonBusinessRules.CheckRequired, "Code")
        Me.Validator.AddBusinessRule("Code", AddressOf CommonBusinessRules.CheckMaxLength, "Code", 50)
        Me.Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckRequired, "Name")
        Me.Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckMaxLength, "Name", 250)
        Me.Validator.AddBusinessRule("Description", AddressOf CommonBusinessRules.CheckMaxLength, "Description", 250)
        Me.Validator.AddBusinessRule("ValidFrom", AddressOf CommonBusinessRules.CheckRequired, "ValidFrom")
        Me.Validator.AddBusinessRule("ValidUntil", AddressOf CommonBusinessRules.CheckDateInterval, "ValidFrom", "ValidUntil")
        Me.Validator.AddBusinessRule("ValidFrom", AddressOf CommonBusinessRules.CheckDateInterval, "ValidFrom", "ValidUntil")
    End Sub

    Protected Sub New()
        AddBusinessRules()
    End Sub

    Public Sub New(ByVal session As Core.Dal.ISession)
        MyBase.New(session)

        'Name = Type.Value
        ValidFrom = DateTime.Today

        Files = New ChildCollection(Of TemplateFileVersion)

        AddBusinessRules()
    End Sub

#Region "Dynamic permissions"

    Public Overridable ReadOnly Property CanChangeType() As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overridable ReadOnly Property CanChangeTypeOrCode() As Boolean
        Get
            Return Id = Guid.Empty
        End Get
    End Property

    Public Overridable ReadOnly Property CanCreate() As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Return IsActive
        End Get
    End Property

    Public Overridable ReadOnly Property CanAccess() As Boolean
        Get
            Return True
        End Get
    End Property

#End Region

    Public Overridable Function SaveTemplate(ByVal isNew As Boolean) As Core.Result
        Dim result As Core.Result = MyBase.Save()
        If result.HasErrors Then Return result
        If isNew Then
            Core.Logger.DB.Log(GetSession(), AuditMessage.TemplateCreate, Nothing, Me.Code)
        Else
            If Me.IsActive Then
                Core.Logger.DB.Log(GetSession(), AuditMessage.TemplateChange, Nothing, Me.Code)
            End If
        End If
        OnPropertyChanged("CanChangeTypeOrCode")
        Return result
    End Function

    Public Overridable Sub Delete()
        If Me.IsActive Then
            Me.IsActive = False
            Core.Logger.DB.Log(GetSession(), AuditMessage.TemplateDelete, Nothing, Me.Code)
        End If
    End Sub

End Class

' Уныкоде