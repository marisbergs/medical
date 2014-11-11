Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class VisitResultAssignment
    Inherits BusinessObjectBase(Of Guid)

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        AddBusinessRoles()
    End Sub
    Public Sub New()

    End Sub

    Private Sub AddBusinessRoles()
        Validator.AddBusinessRule("Service", AddressOf CommonBusinessRules.CheckRequired, "Service")
        Validator.AddBusinessRule("Number", AddressOf CommonBusinessRules.CheckRequired, "Number")
        Validator.AddBusinessRule("PayDate", AddressOf CommonBusinessRules.CheckRequired, "PayDate")
    End Sub

#Region "Private members"
    Private _visitResult As VisitResult
    Private _asignment As Assignment
#End Region

#Region "Public member"
    Public Overridable Property VisitResult() As VisitResult
        Get
            Return _visitResult
        End Get
        Set(ByVal value As VisitResult)
            Assign("VisitResult", value, _visitResult)
        End Set
    End Property

    Public Overridable Property Asignment() As Assignment
        Get
            Return _asignment
        End Get
        Set(ByVal value As Assignment)
            Assign("Asignment", value, _asignment)
        End Set
    End Property
#End Region

End Class
