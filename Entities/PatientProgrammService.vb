Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class PatientProgrammService
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
        Validator.AddBusinessRule("Price", AddressOf CommonBusinessRules.CheckRequired, "Price")
        Validator.AddBusinessRule("Count", AddressOf CommonBusinessRules.CheckRequired, "Count")
    End Sub

    Private _patientProgramm As PatientProgramm
    Private _service As Services
    Private _count As Nullable(Of Integer)
    Private _countUsed As Nullable(Of Integer)
    Private _price As Nullable(Of Decimal)


    Public Overridable Property PatientProgramm() As PatientProgramm
        Get
            Return _patientProgramm
        End Get
        Set(ByVal value As PatientProgramm)
            Assign("PatientProgramm", value, _patientProgramm)
        End Set
    End Property



    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.PatientProgramm
        End Get
        Set(ByVal value As Object)
            Me.PatientProgramm = CType(value, PatientProgramm)
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

    Public Overridable Property Price() As Nullable(Of Decimal)
        Get
            Return _price
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Assign("Price", value, _price)
        End Set
    End Property

    Public Overridable Property Count() As Nullable(Of Integer)
        Get
            Return _count
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("Count", value, _count)
        End Set
    End Property

    Public Overridable Property CountUsed() As Nullable(Of Integer)
        Get
            Return _countUsed
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("CountUsed", value, _countUsed)
        End Set
    End Property

End Class
