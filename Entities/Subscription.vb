Imports Core.Bll
Imports Core.Dal

Public Class Subscription
    Inherits BusinessObjectBase(Of Guid)

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        SubscriptionDetail = New ChildCollection(Of SubscriptionDetail)
        AddBusinessRoles()
    End Sub
    Public Sub New()
        SubscriptionDetail = New ChildCollection(Of SubscriptionDetail)
        AddBusinessRoles()
    End Sub

    Private Sub AddBusinessRoles()
        Validator.AddBusinessRule("Patient", AddressOf CommonBusinessRules.CheckRequired, "Patient")
        Validator.AddBusinessRule("Service", AddressOf CommonBusinessRules.CheckRequired, "Service")
    End Sub

#Region "Private members"
    Private _patient As Patient
    Private _service As Services
    Private _price As Decimal
    Private _timeCount As Integer
    Private _comment As String
    Private _payTime As Nullable(Of DateTime)
    Private _paymentType As PaymentType
    Private _userAcceptedPayment As User
    Private _subscriptionDetail As IChildCollection(Of SubscriptionDetail)

#End Region

#Region "Public member"

    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            Assign("Patient", value, _patient)
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

    Public Overridable Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(ByVal value As Decimal)
            Assign("Price", value, _price)
        End Set
    End Property

    Public Overridable Property TimeCount() As Integer
        Get
            Return _timeCount
        End Get
        Set(ByVal value As Integer)
            Assign("TimeCount", value, _timeCount)
        End Set
    End Property

    Public Overridable Property Comment() As String
        Get
            Return _comment
        End Get
        Set(ByVal value As String)
            Assign("Comment", value, _comment)
        End Set
    End Property

    Public Overridable Property PayTime() As Nullable(Of DateTime)
        Get
            Return _payTime
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("PayTime", value, _payTime)
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

    Public Overridable Property UserAcceptedPayment() As User
        Get
            Return _userAcceptedPayment
        End Get
        Set(ByVal value As User)
            Assign("UserAcceptedPayment", value, _userAcceptedPayment)
        End Set
    End Property


    ''' <summary>
    ''' Dokumenta failu maiņas saraksts
    ''' </summary>
    Public Overridable Property SubscriptionDetail() As Core.Dal.IChildCollection(Of SubscriptionDetail)
        Get
            Return _subscriptionDetail
        End Get
        Protected Set(ByVal value As Core.Dal.IChildCollection(Of SubscriptionDetail))
            _subscriptionDetail = value
            _subscriptionDetail.Parent = Me
        End Set
    End Property

#End Region

End Class
