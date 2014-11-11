Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class PatientProfileDescriptionService
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

    Protected Sub New()
        MyBase.New()
        BusinessRule()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        BusinessRule()
    End Sub

    Private Sub BusinessRule()
        Validator.AddBusinessRule("Service", AddressOf CommonBusinessRules.CheckRequired, "Service")
    End Sub

    Private _profileDescription As PatientProfileDescription
    Private _service As Services
    Private _freeGroup As Boolean
    Private _price As Nullable(Of Decimal)

    Public Overridable Property ProfileDescription() As PatientProfileDescription
        Get
            Return _profileDescription
        End Get
        Set(ByVal value As PatientProfileDescription)
            Assign("ProfileDescription", value, _profileDescription)
        End Set
    End Property

    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.ProfileDescription
        End Get
        Set(ByVal value As Object)
            Me.ProfileDescription = CType(value, PatientProfileDescription)
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

    Public Overridable ReadOnly Property ServicePice() As Double
        Get
            If Not Service Is Nothing Then
                Return Service.DecimalValue
            Else
                Return 0
            End If
        End Get
    End Property

    Public Overridable Property FreeGroup() As Boolean
        Get
            Return _freeGroup
        End Get
        Set(ByVal value As Boolean)
            Assign("FreeGroup", value, _freeGroup)
        End Set
    End Property

    Public Overridable Property Price() As Nullable(Of Decimal)
        Get
            Return _price
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Assign("Price", value, _price)
        End Set
    End Property

End Class
