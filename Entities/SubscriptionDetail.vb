Imports Core.Bll
Imports Core.Dal

Public Class SubscriptionDetail
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent


    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        AddBusinessRoles()
    End Sub
    Public Sub New()
        AddBusinessRoles()
    End Sub

    Private Sub AddBusinessRoles()
        Validator.AddBusinessRule("Subscription", AddressOf CommonBusinessRules.CheckRequired, "Subscription")
    End Sub

#Region "Private members"
    Private _subscription As Subscription
    Private _appointment As Integer
    Private _price As Decimal
    Private _service As Services
    Private _visit As Visit
#End Region

    Public Overridable Property Subscription() As Subscription
        Get
            Return _subscription
        End Get
        Set(ByVal value As Subscription)
            Assign("Subscription", value, _subscription)
        End Set
    End Property

    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Subscription
        End Get
        Set(ByVal value As Object)
            Subscription = CType(value, Subscription)
        End Set
    End Property

    Public Overridable Property Appointment() As Integer
        Get
            Return _appointment
        End Get
        Set(ByVal value As Integer)
            Assign("Appointment", value, _appointment)
        End Set
    End Property

    Public Overridable Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(ByVal value As Decimal)
            Assign("Price", value, _price)
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

    Public Overridable Property Visit() As Visit
        Get
            Return _visit
        End Get
        Set(ByVal value As Visit)
            Assign("Visit", value, _visit)
        End Set
    End Property

    Public Overridable Property VisitForDisplay() As String
        Get
            If Visit Is Nothing Then
                Return ""
            End If
            Return Visit.Doctor.FullName & " " & Visit.StartTime.ToString("dd.MM.yyyy HH:mm")
        End Get
        Set(ByVal value As String)

        End Set
    End Property
End Class
