Imports Core.Bll

''' <summary>
''' KP lietas tematiskās pārbaudes tēmas
''' </summary>
Public Class UserLanguage
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
        Validator.AddBusinessRule("Language", AddressOf CommonBusinessRules.CheckRequired, "Language")
    End Sub
#End Region

#Region "Private members"
    Private _language As Language
    Private _user As User
#End Region


    ''' <summary>
    ''' Valoda
    ''' </summary>
    Public Overridable Property Language() As Language
        Get
            Return _language
        End Get
        Set(ByVal value As Language)
            Assign("Language", value, _language)
        End Set
    End Property

    ''' <summary>
    ''' Ārsts
    ''' </summary>
    Public Overridable Property User() As Entities.User
        Get
            Return _user
        End Get
        Set(ByVal value As Entities.User)
            Assign("User", value, _user)
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
        If Me.Language Is Nothing Then Return ""
        Return Language.Value
    End Function
End Class
' Уныкоде