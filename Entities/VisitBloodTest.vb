Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class VisitBloodTest
    Inherits BusinessObjectBase(Of Guid)

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        AddBusinessRoles()
    End Sub


    Public Sub New()
        AddBusinessRoles()
    End Sub

    Private Sub AddBusinessRoles()
        Validator.AddBusinessRule("Visit", AddressOf CommonBusinessRules.CheckRequired, "Visit")
    End Sub

#Region "Private members"
    Private _visit As Visit
    Private _tests As BloodTest

#End Region

#Region "Public member"

    Public Overridable Property Tests() As BloodTest
        Get
            Return _tests
        End Get
        Set(ByVal value As BloodTest)
            Assign("Tests", value, _tests)
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

#End Region

End Class
