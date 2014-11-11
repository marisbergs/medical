Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class ProgrammTemplate
    Inherits BusinessObjectBase(Of Guid)

    Protected Sub New()
        MyBase.New()
        BusinessRule()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        BusinessRule()
        PaymentServices = New ChildCollection(Of ProgrammTemplateService)
        Servicves = New ChildCollection(Of ProgrammTemplateService)
    End Sub

    Private Sub BusinessRule()
        Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckRequired, "Name")
        Validator.AddBusinessRule("Price", AddressOf CommonBusinessRules.CheckRequired, "Price")
    End Sub

    Private _name As String
    Private _price As Nullable(Of Decimal)
    Private _paymentFromDefaultPrice As Boolean
    Private _paymentServices As IChildCollection(Of ProgrammTemplateService)
    Private _services As IChildCollection(Of ProgrammTemplateService)

    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            Assign("Name", value, _name)
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

    Public Overridable Property PaymentFromDefaultPrice As Boolean
        Get
            Return _paymentFromDefaultPrice
        End Get
        Set(ByVal value As Boolean)
            Assign("PaymentFromDefaultPrice", value, _paymentFromDefaultPrice)
        End Set
    End Property

    Public Overridable Property PaymentServices() As Core.Dal.IChildCollection(Of ProgrammTemplateService)
        Get
            Return _paymentServices
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of ProgrammTemplateService))
            Assign("PaymentServices", value, _paymentServices)
        End Set
    End Property

    Public Overridable Property Servicves() As Core.Dal.IChildCollection(Of ProgrammTemplateService)
        Get
            Return _services
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of ProgrammTemplateService))
            Assign("Servicves", value, _services)
        End Set
    End Property

    Public Overrides ReadOnly Property IsValid() As Boolean
        Get
            For Each s As ProgrammTemplateService In PaymentServices.ActiveItemsWithoutEmpty
                If Not s.IsValid Then
                    Return False
                End If
            Next
            For Each s As ProgrammTemplateService In Servicves.ActiveItemsWithoutEmpty
                If Not s.IsValid Then
                    Return False
                End If
            Next
            Return MyBase.IsValid
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Name
    End Function

End Class
