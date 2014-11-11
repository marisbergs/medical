Imports Core.Dal
Imports Core.Bll
Imports System

Public Class VisitService
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

    Private _visit As Visit
    Private _service As Services
    Private _groupWork As GroupsWork
    Private _payd As Boolean
    Private _paydStateChangedByUser As User
    Private _price As Decimal
    Private _defaultPrice As Decimal
    Private _percentage As Nullable(Of Integer)
    Private _insurance As Nullable(Of Decimal)
    Private _presentCard As PresentCard
    Private _presentCardSum As Nullable(Of Decimal)
    Private _bonusPoints As Nullable(Of Decimal)
    Private _paydDate As Nullable(Of DateTime)
    Private _serviceGiven As Boolean
    Private _discount As Integer
    Private _paymentType As PaymentType
    Private _abonements As Subscription
    Private _pak As PatientProfileDescription
    Private _programma As PatientProgrammService

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        BusinessRule()
    End Sub
    Private Sub BusinessRule()
        Validator.AddBusinessRule("Service", AddressOf CommonBusinessRules.CheckConditionalRequired, "NeedService", "Service")
    End Sub

    Public Overridable Property Visit() As Visit
        Get
            Return _visit
        End Get
        Set(ByVal value As Visit)
            Assign("Visit", value, _visit)
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

    Public Overridable ReadOnly Property ServiceCode() As String
        Get
            If Service Is Nothing Then
                Return ""
            Else
                Return Service.Code
            End If
        End Get
    End Property

    Public Overridable Property GroupWork() As GroupsWork
        Get
            Return _groupWork
        End Get
        Set(ByVal value As GroupsWork)
            Assign("GroupWork", value, _groupWork)
        End Set
    End Property

    Public Overridable ReadOnly Property Serv() As String
        Get
            If Not Service Is Nothing Then
                Return Service.Value
            ElseIf Not GroupWork Is Nothing Then
                Return GroupWork.Value
            Else
                Return ""
            End If
        End Get
    End Property

    Public Overridable Property Payd() As Boolean
        Get
            Return _payd
        End Get
        Set(ByVal value As Boolean)
            If _payd <> value Then
                PaydStateChangedByUser = Context.Current.AuthenticatedUser
            End If
            Assign("Service", value, _payd)
            If _payd Then
                PaydDate = Now
            Else
                PaydDate = Nothing
            End If
        End Set
    End Property

    Public Overridable Property PaydStateChangedByUser() As User
        Get
            Return _paydStateChangedByUser
        End Get
        Set(ByVal value As User)
            Assign("PaydStateChangedByUser", value, _paydStateChangedByUser)
        End Set
    End Property

    Public Overridable ReadOnly Property PriceNullable() As Nullable(Of Decimal)
        Get
            If Price > 0 Then
                Return Price
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public Overridable Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(ByVal value As Decimal)
            Assign("Price", value, _price)
        End Set
    End Property

    Public Overridable Property DefaultPrice() As Decimal
        Get
            Return _defaultPrice
        End Get
        Set(ByVal value As Decimal)
            Assign("DefaultPrice", value, _defaultPrice)
            If (_discount = 0) Then
                Price = DefaultPrice
            Else
                Price = DefaultPrice - (DefaultPrice / 100 * _discount)
            End If
        End Set
    End Property

    Public Overridable Property Percentage() As Nullable(Of Integer)
        Get
            Return _percentage
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("Percentage", value, _percentage)
        End Set
    End Property

    Public Overridable Property PaymentType() As PaymentType
        Get
            Return _paymentType
        End Get
        Set(ByVal value As PaymentType)
            Assign("PaymentType", value, _paymentType)
        End Set
    End Property

    Public Overridable Property ServiceGiven() As Boolean
        Get
            Return _serviceGiven
        End Get
        Set(ByVal value As Boolean)
            Assign("ServiceGiven", value, _serviceGiven)
        End Set
    End Property

    Public Overridable ReadOnly Property PriceWithOutPercentage() As Nullable(Of Decimal)
        Get
            If Not Percentage.HasValue Then
                Return Nothing
            End If
            Return Decimal.Round(CDec(Price / (1 + (Percentage.Value / 100))), 2)
        End Get
    End Property

    Public Overridable ReadOnly Property PercentagePrice() As Nullable(Of Decimal)
        Get
            If Not PriceWithOutPercentage.HasValue Then
                Return Nothing
            End If
            Return Price - PriceWithOutPercentage.Value
        End Get
    End Property

    Public Overridable ReadOnly Property DefaultPriceWithOutPercentage() As Nullable(Of Decimal)
        Get
            If Not Percentage.HasValue Then
                Return Nothing
            End If
            Return Decimal.Round(CDec(DefaultPrice / (1 + (Percentage.Value / 100))), 2)
        End Get
    End Property

    Public Overridable ReadOnly Property DefaultPercentagePrice() As Nullable(Of Decimal)
        Get
            If Not DefaultPriceWithOutPercentage.HasValue Then
                Return Nothing
            End If
            Return DefaultPrice - DefaultPriceWithOutPercentage.Value
        End Get
    End Property

    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.Visit
        End Get
        Set(ByVal value As Object)
            Me.Visit = CType(value, Visit)
        End Set
    End Property
    Public Overridable ReadOnly Property NeedService() As Boolean
        Get
            If GroupWork Is Nothing Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Overridable Property Insurance() As Nullable(Of Decimal)
        Get
            Return _insurance
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Assign("Insurance", value, _insurance)
        End Set
    End Property

    Public Overridable Property PresentCard() As PresentCard
        Get
            Return _presentCard
        End Get
        Set(ByVal value As PresentCard)
            Assign("PresentCard", value, _presentCard)
        End Set
    End Property

    Public Overridable ReadOnly Property PresentCardNumber() As String
        Get
            If PresentCard Is Nothing Then
                Return ""
            Else
                Return PresentCard.Number
            End If
        End Get
    End Property

    Public Overridable Property PresentCardSum() As Nullable(Of Decimal)
        Get
            Return _presentCardSum
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Assign("PresentCardSum", value, _presentCardSum)
        End Set
    End Property

    Public Overridable Property BonusPoints() As Nullable(Of Decimal)
        Get
            Return _bonusPoints
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Assign("BonusPoints", value, _bonusPoints)
        End Set
    End Property

    Public Overridable Property PaydDate() As Nullable(Of DateTime)
        Get
            Return _paydDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("PaydDate", value, _paydDate)
        End Set
    End Property

    Public Overridable Property Discount() As Integer
        Get
            Return _discount
        End Get
        Set(ByVal value As Integer)
            Assign("Discount", value, _discount)
            If (_discount = 0) Then
                Price = DefaultPrice
            Else
                Price = DefaultPrice - (DefaultPrice / 100 * _discount)
            End If
        End Set
    End Property


    Public Overridable Property Abonements() As Subscription
        Get
            Return _abonements
        End Get
        Set(ByVal value As Subscription)
            Assign("Abonements", value, _abonements)
        End Set
    End Property


    Public Overridable Property Programma() As PatientProgrammService
        Get
            Return _programma
        End Get
        Set(ByVal value As PatientProgrammService)
            Assign("Programma", value, _programma)
        End Set
    End Property
End Class
