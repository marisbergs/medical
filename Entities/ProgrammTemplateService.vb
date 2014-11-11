Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class ProgrammTemplateService
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
        Validator.AddBusinessRule("Price", AddressOf CommonBusinessRules.CheckConditionalRequired, "NeedFillpriceAndCount", "Price")
        Validator.AddBusinessRule("Count", AddressOf CommonBusinessRules.CheckConditionalRequired, "NeedFillpriceAndCount", "Count")
    End Sub

    Private _programmTemplate As ProgrammTemplate
    Private _service As Services
    Private _paymentGroup As Boolean
    Private _count As Nullable(Of Integer)
    Private _price As Nullable(Of Decimal)

    Public Overridable Property ProgrammTemplate() As ProgrammTemplate
        Get
            Return _programmTemplate
        End Get
        Set(ByVal value As ProgrammTemplate)
            Assign("ProgrammTemplate", value, _programmTemplate)
        End Set
    End Property

    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.ProgrammTemplate
        End Get
        Set(ByVal value As Object)
            Me.ProgrammTemplate = CType(value, ProgrammTemplate)
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
    Public Overridable ReadOnly Property NeedFillpriceAndCount() As Boolean
        Get
            Return Not PaymentGroup
        End Get
    End Property

    Public Overridable Property PaymentGroup() As Boolean
        Get
            Return _paymentGroup
        End Get
        Set(ByVal value As Boolean)
            Assign("PaymentGroup", value, _paymentGroup)
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

    Public Overridable Property Count() As Nullable(Of Integer)
        Get
            Return _count
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("Count", value, _count)
        End Set
    End Property

    Public Overridable ReadOnly Property PriceTotal() As Nullable(Of Decimal)
        Get
            If Count.HasValue AndAlso Price.HasValue Then
                Return Count.Value * Price.Value
            Else
                Return Nothing
            End If
        End Get
    End Property



    Public Overrides Property IsActive() As Boolean
        Get
            Return MyBase.IsActive AndAlso Not (Service.ValidUntil.HasValue AndAlso Service.ValidUntil.Value < DateTime.Now)
        End Get
        Set(ByVal value As Boolean)
            MyBase.IsActive = value
        End Set
    End Property

End Class
