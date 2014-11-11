Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class PatientProgramm
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

    Protected Sub New()
        MyBase.New()
        BusinessRule()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        BusinessRule()
        Payments = New ChildCollection(Of PatientProgrammPayment)
        Services = New ChildCollection(Of PatientProgrammService)
        UsageStatus = UsageStatus.Created
        PaymentStatus = PaymentStatus.NotPayd
    End Sub

    Private Sub BusinessRule()
        Validator.AddBusinessRule("Patient", AddressOf CommonBusinessRules.CheckRequired, "Patient")
        Validator.AddBusinessRule("ProgrammTemplate", AddressOf CommonBusinessRules.CheckRequired, "ProgrammTemplate")
        Validator.AddBusinessRule("Price", AddressOf CommonBusinessRules.CheckRequired, "Price")
    End Sub

    Private _patient As Patient
    Private _price As Nullable(Of Decimal)
    Private _programmTemplate As ProgrammTemplate
    Private _usageStatus As UsageStatus
    Private _paymentStatus As PaymentStatus
    Private _programmIsLock As Boolean
    Private _payments As IChildCollection(Of PatientProgrammPayment)
    Private _services As IChildCollection(Of PatientProgrammService)
    Private _notes As String
    Private _needBillPrint As Boolean

    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            Assign("Patient", value, _patient)
        End Set
    End Property

    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.Patient
        End Get
        Set(ByVal value As Object)
            Me.Patient = CType(value, Patient)
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

    Public Overridable Property ProgrammTemplate() As ProgrammTemplate
        Get
            Return _programmTemplate
        End Get
        Set(ByVal value As ProgrammTemplate)
            Assign("ProgrammTemplate", value, _programmTemplate)
        End Set
    End Property

    Public Overridable Property Payments() As Core.Dal.IChildCollection(Of PatientProgrammPayment)
        Get
            Return _payments
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of PatientProgrammPayment))
            Assign("Payments", value, _payments)
        End Set
    End Property

    Public Overridable Property Services() As Core.Dal.IChildCollection(Of PatientProgrammService)
        Get
            Return _services
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of PatientProgrammService))
            Assign("Services", value, _services)
        End Set
    End Property

    Public Overridable Property UsageStatus() As UsageStatus
        Get
            Return _usageStatus
        End Get
        Set(ByVal value As UsageStatus)
            Assign("UsageStatus", value, _usageStatus)
        End Set
    End Property

    Public Overridable Property PaymentStatus() As PaymentStatus
        Get
            Return _paymentStatus
        End Get
        Set(ByVal value As PaymentStatus)
            Assign("PaymentStatus", value, _paymentStatus)
        End Set
    End Property

    Public Overridable ReadOnly Property PaymentDate() As Nullable(Of DateTime)
        Get
            Dim dat As Nullable(Of DateTime) = Nothing
            For Each p As PatientProgrammPayment In Payments.ActiveItemsWithoutEmpty
                If Not dat.HasValue And p.PaymentDate.HasValue Then
                    dat = p.PaymentDate
                End If
                If p.PaymentDate.HasValue AndAlso p.PaymentDate > dat Then
                    dat = p.PaymentDate.Value
                End If
            Next
            Return dat
        End Get
    End Property

    Public Overridable Property ProgrammIsLock() As Boolean
        Get
            Return _programmIsLock
        End Get
        Set(ByVal value As Boolean)
            Assign("ProgrammIsLock", value, _programmIsLock)
        End Set
    End Property

    Public Overridable Property NeedBillPrint() As Boolean
        Get
            Return _needBillPrint
        End Get
        Set(ByVal value As Boolean)
            Assign("NeedBillPrint", value, _needBillPrint)
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
            For Each s As PatientProgrammPayment In Payments.ActiveItemsWithoutEmpty
                If Not s.IsValid Then
                    Return False
                End If
            Next
            For Each s As PatientProgrammService In Services.ActiveItemsWithoutEmpty
                If Not s.IsValid Then
                    Return False
                End If
            Next
            Return MyBase.IsValid
        End Get
    End Property
    Public Overridable ReadOnly Property CanChangePatient() As Boolean
        Get
            Return UsageStatus = UsageStatus.Created AndAlso PaymentStatus = PaymentStatus.NotPayd
        End Get
    End Property

    Public Overridable Sub ResetPaymentStatuss()
        If Payments Is Nothing Then
            Exit Sub
        End If
        If Payments.ActiveItemsWithoutEmpty.Count = 0 Then
            PaymentStatus = PaymentStatus.NotPayd
        Else
            Dim samaksats As Decimal = 0
            For Each payment As PatientProgrammPayment In Payments.ActiveItemsWithoutEmpty
                If payment.PaymentDate.HasValue Then
                    For Each o As PatientProgrammPaymentService In payment.PaymentServices.ActiveItemsWithoutEmpty
                        samaksats += o.Price.Value
                    Next
                End If
            Next
            If samaksats = 0 Then
                PaymentStatus = PaymentStatus.NotPayd
            ElseIf samaksats < Price Then
                PaymentStatus = PaymentStatus.PaydPart
            Else
                PaymentStatus = PaymentStatus.PaydAll
            End If
        End If
    End Sub

End Class
