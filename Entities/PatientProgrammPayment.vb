Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class PatientProgrammPayment
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

    Protected Sub New()
        MyBase.New()
        PaymentServices = New ChildCollection(Of PatientProgrammPaymentService)
        BusinessRule()
    End Sub

    Public Sub New(ByVal session As ISession, ByVal programma As PatientProgramm)
        MyBase.New(session)
        PatientProgramm = programma
        PaymentServices = New ChildCollection(Of PatientProgrammPaymentService)
        BusinessRule()
    End Sub

    Private Sub BusinessRule()
        Validator.AddBusinessRule("PatientProgramm", AddressOf CommonBusinessRules.CheckRequired, "PatientProgramm")
    End Sub

    Private _patientProgramm As PatientProgramm
    Private _price As Nullable(Of Decimal)
    Private _paymentDate As Nullable(Of DateTime)
    Private _paymentUser As User
    Private _paymentServices As IChildCollection(Of PatientProgrammPaymentService)
    Private _notes As String

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

    Public Overridable Property Price() As Nullable(Of Decimal)
        Get
            Return _price
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Assign("Price", value, _price)
        End Set
    End Property

    Public Overridable Property PaymentDate() As Nullable(Of DateTime)
        Get
            Return _paymentDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("PaymentDate", value, _paymentDate)
        End Set
    End Property

    Public Overridable Property PaymentUser() As User
        Get
            Return _paymentUser
        End Get
        Set(ByVal value As User)
            Assign("PaymentUser", value, _paymentUser)
        End Set
    End Property

    Public Overridable Property PaymentServices() As Core.Dal.IChildCollection(Of PatientProgrammPaymentService)
        Get
            Return _paymentServices
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of PatientProgrammPaymentService))
            Assign("PaymentServices", value, _paymentServices)
        End Set
    End Property

    Public Overridable Property Notes() As String
        Get
            Return _notes
        End Get
        Set(ByVal value As String)
            Assign("Notes", value, _notes)
        End Set
    End Property

    Public Overrides ReadOnly Property IsValid() As Boolean
        Get
            For Each o As PatientProgrammPaymentService In PaymentServices.ActiveItemsWithoutEmpty
                If Not o.IsValid Then
                    Return False
                End If
            Next
            Return MyBase.IsValid
        End Get
    End Property

    Public Overridable ReadOnly Property PaydTotal() As Decimal
        Get
            Dim summa As Decimal = 0
            If PaymentDate.HasValue Then
                For Each o As PatientProgrammPaymentService In PaymentServices.ActiveItemsWithoutEmpty
                    summa += o.Price.Value
                Next
            End If
            Return summa
        End Get
    End Property

End Class
