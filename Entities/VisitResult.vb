Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class VisitResult
    Inherits BusinessObjectBase(Of Guid)

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        VisitResultAssignments = New ChildCollection(Of VisitResultAssignment)
        AddBusinessRoles()
    End Sub


    Public Sub New()
        VisitResultAssignments = New ChildCollection(Of VisitResultAssignment)
        AddBusinessRoles()
    End Sub

    Private Sub AddBusinessRoles()
        Validator.AddBusinessRule("Visit", AddressOf CommonBusinessRules.CheckRequired, "Visit")
    End Sub

#Region "Private members"
    Private _visit As Visit
    Private _notes As String
    Private _notNeedBloodTest As Boolean
    Private _visitResultAssignments As IChildCollection(Of VisitResultAssignment)

#End Region

#Region "Public member"
    
    Public Overridable Property Notes() As String
        Get
            Return _notes
        End Get
        Set(ByVal value As String)
            Assign("Notes", value, _notes)
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

    Public Overridable Property NotNeedBloodTest() As Boolean
        Get
            Return _notNeedBloodTest
        End Get
        Set(ByVal value As Boolean)
            Assign("NotNeedBloodTest", value, _notNeedBloodTest)
        End Set
    End Property


    Public Overridable Property VisitResultAssignments() As IChildCollection(Of VisitResultAssignment)
        Get
            Return _visitResultAssignments
        End Get
        Set(ByVal value As IChildCollection(Of VisitResultAssignment))
            Assign("VisitResultAssignments", value, _visitResultAssignments)
        End Set
    End Property
#End Region

End Class
