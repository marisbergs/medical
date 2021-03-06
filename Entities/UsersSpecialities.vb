Imports Core.Bll

''' <summary>
''' KP lietas tematiskās pārbaudes tēmas
''' </summary>
Public Class UsersSpecialities
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

#Region "Constructor"
    Protected Sub New()
        MyBase.New()
        BusinessRule()
    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession)
        MyBase.New(session)
        BusinessRule()
    End Sub

    Private Sub BusinessRule()
        Validator.AddBusinessRule("Speciality", AddressOf CommonBusinessRules.CheckRequired, "Speciality")
        Validator.AddBusinessRule("From", AddressOf CommonBusinessRules.CheckDateInterval, "From", "Until")
    End Sub
#End Region

#Region "Private members"
    Private _speciality As Speciality
    Private _user As User
    Private _from As Nullable(Of DateTime)
    Private _until As Nullable(Of DateTime)
    Private _number As String
#End Region


    ''' <summary>
    ''' Specialitāte
    ''' </summary>
    Public Overridable Property Speciality() As Speciality
        Get
            Return _speciality
        End Get
        Set(ByVal value As Speciality)
            Assign("Speciality", value, _speciality)
        End Set
    End Property

    ''' <summary>
    ''' Saistītā KP lieta
    ''' </summary>
    Public Overridable Property User() As Entities.User
        Get
            Return _user
        End Get
        Set(ByVal value As Entities.User)
            Assign("User", value, _user)
        End Set
    End Property

    ''' <summary>
    ''' Sertifikāts derīgs no
    ''' </summary>
    Public Overridable Property From() As Nullable(Of DateTime)
        Get
            Return _from
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("From", value, _from)
        End Set
    End Property

    ''' <summary>
    ''' Sertifikāta numurs
    ''' </summary>
    Public Overridable Property Number() As String
        Get
            Return _number
        End Get
        Set(ByVal value As String)
            Assign("Number", value, _number)
        End Set
    End Property


    ''' <summary>
    ''' Sertifikāts derīgs līdz
    ''' </summary>
    Public Overridable Property Until() As Nullable(Of DateTime)
        Get
            Return _until
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("Until", value, _until)
        End Set
    End Property

    Public Overridable Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.User
        End Get
        Set(ByVal value As Object)
            Me.User = CType(value, User)
        End Set
    End Property

    ''' <summary>
    ''' Return whether can delete CM case theme
    ''' </summary>
    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            If User Is Nothing Then
                Return False
            End If
            If Not Me.IsActive Then
                Return False
            End If
            Return User.CanAddDeleteSpeciality
        End Get
    End Property

    ''' <summary>
    ''' Return whether can edit CM case theme
    ''' </summary>
    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            If Me.IsActive Then
                Return True
            End If
            Return False
        End Get
    End Property

    Public Overrides Function ToString() As String
        If Me.Speciality Is Nothing Then Return ""
        Return Speciality.Value
    End Function
End Class
' Уныкоде