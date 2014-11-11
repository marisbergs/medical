Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class PatientProgrammPaymentService
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
        Validator.AddBusinessRule("PatientProgrammPayment", AddressOf CommonBusinessRules.CheckRequired, "PatientProgrammPayment")
        Validator.AddBusinessRule("Service", AddressOf CommonBusinessRules.CheckRequired, "Service")
        Validator.AddBusinessRule("Price", AddressOf CommonBusinessRules.CheckRequired, "Price")
    End Sub

    Private _patientProgrammPayment As PatientProgrammPayment
    Private _service As Services
    Private _price As Nullable(Of Decimal)

    Public Overridable Property PatientProgrammPayment() As PatientProgrammPayment
        Get
            Return _patientProgrammPayment
        End Get
        Set(ByVal value As PatientProgrammPayment)
            Assign("PatientProgrammPayment", value, _patientProgrammPayment)
        End Set
    End Property

    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.PatientProgrammPayment
        End Get
        Set(ByVal value As Object)
            Me.PatientProgrammPayment = CType(value, PatientProgrammPayment)
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

    Public Overridable Property Price() As Nullable(Of Decimal)
        Get
            Return _price
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Assign("Price", value, _price)
        End Set
    End Property

End Class
