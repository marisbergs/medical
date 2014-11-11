Imports Core.Bll
Imports Core.Dal

Public Class Localization
    Inherits BusinessObjectBase(Of Guid)
    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        AddBusinessRoles()
    End Sub
    Public Sub New()
        AddBusinessRoles()
    End Sub

    Private Sub AddBusinessRoles()
        'Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckRequired, "Name")
    End Sub


#Region "Private members"
    Private _forma As String
    Private _labels As String
    Private _lv As String
    Private _rus As String
    Private _eng As String

#End Region

#Region "Public member"

    Public Overridable Property Forma() As String
        Get
            Return _forma
        End Get
        Set(ByVal value As String)
            Assign("Forma", value, _forma)
        End Set
    End Property

    Public Overridable Property Labels() As String
        Get
            Return _labels
        End Get
        Set(ByVal value As String)
            Assign("Labels", value, _labels)
        End Set
    End Property

    Public Overridable Property Lv() As String
        Get
            Return _lv
        End Get
        Set(ByVal value As String)
            Assign("Lv", value, _lv)
        End Set
    End Property

    Public Overridable Property Rus() As String
        Get
            Return _rus
        End Get
        Set(ByVal value As String)
            Assign("Rus", value, _rus)
        End Set
    End Property

    Public Overridable Property Eng() As String
        Get
            Return _eng
        End Get
        Set(ByVal value As String)
            Assign("Eng", value, _eng)
        End Set
    End Property

    Public Overridable ReadOnly Property Aktuala() As String
        Get
            If Context.Current.AuthenticatedUser.InterfaceLanguage = "ENG" Then
                Return IIf(Eng Is Nothing, "!" & Lv, Eng).ToString()
            ElseIf Context.Current.AuthenticatedUser.InterfaceLanguage = "RUS" Then
                Return IIf(Rus Is Nothing, "!" & Lv, Rus).ToString()
            Else
                Return Lv
            End If
        End Get
    End Property

#End Region
End Class
