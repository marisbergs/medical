Imports Core
Imports Core.Bll
Imports Core.Dal


''' <summary>
''' Primārās aprûpes karte PAK
''' </summary>
''' <remarks></remarks>
Public Class PatientProfileDescription
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

    Protected Sub New()
        MyBase.New()
        BusinessRule()
    End Sub

    Public Sub New(ByVal session As ISession, ByVal patient As Patient)
        MyBase.New(session)
        BusinessRule()
        Me.Patient = patient
        CreateUser = Context.Current.AuthenticatedUser
        CreateDate = DateTime.Now
        FreeService = New ChildCollection(Of PatientProfileDescriptionService)
        DiscountService = New ChildCollection(Of PatientProfileDescriptionService)
    End Sub

    Private Sub BusinessRule()
        Validator.AddBusinessRule("Profile", AddressOf CommonBusinessRules.CheckRequired, "Profile")
        Validator.AddBusinessRule("Price", AddressOf CommonBusinessRules.CheckRequired, "Price")
        Validator.AddBusinessRule("Count", AddressOf CommonBusinessRules.CheckRequired, "Count")
        Validator.AddBusinessRule("Number", AddressOf CommonBusinessRules.CheckRequired, "Number")
        Validator.AddBusinessRule("BeginDate", AddressOf CommonBusinessRules.CheckRequired, "BeginDate")
        Validator.AddBusinessRule("EndDate", AddressOf CommonBusinessRules.CheckRequired, "EndDate")
    End Sub

    Private _profile As Profile
    Private _patient As Patient
    Private _number As String
    Private _beginDate As Nullable(Of DateTime)
    Private _endDate As Nullable(Of DateTime)
    Private _price As Nullable(Of Decimal)
    Private _count As Nullable(Of Integer)
    Private _payDate As Nullable(Of DateTime)
    Private _paymentAcceptedByUser As User
    Private _createDate As Nullable(Of DateTime)
    Private _createUser As User
    Private _freeService As IChildCollection(Of PatientProfileDescriptionService)
    Private _discountService As IChildCollection(Of PatientProfileDescriptionService)

    Public Overridable Property Profile() As Profile
        Get
            Return _profile
        End Get
        Set(ByVal value As Profile)
            Assign("Profile", value, _profile)
        End Set
    End Property

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

    Public Overridable Property Number() As String
        Get
            Return _number
        End Get
        Set(ByVal value As String)
            Assign("Number", value, _number)
        End Set
    End Property

    Public Overridable Property BeginDate() As Nullable(Of DateTime)
        Get
            Return _beginDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("BeginDate", value, _beginDate)
            If value.HasValue Then
                EndDate = value.Value.AddYears(1)
            End If
        End Set
    End Property

    Public Overridable Property EndDate() As Nullable(Of DateTime)
        Get
            Return _endDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("EndDate", value, _endDate)
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

    Public Overridable Property PayDate() As Nullable(Of DateTime)
        Get
            Return _payDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("PayDate", value, _payDate)
        End Set
    End Property

    Public Overridable Property PaymentAcceptedByUser() As User
        Get
            Return _paymentAcceptedByUser
        End Get
        Set(ByVal value As User)
            Assign("PaymentAcceptedByUser", value, _paymentAcceptedByUser)
        End Set
    End Property

    Public Overridable Property CreateDate() As Nullable(Of DateTime)
        Get
            Return _createdate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("CreateDate", value, _createdate)
        End Set
    End Property

    Public Overridable Property CreateUser() As User
        Get
            Return _createUser
        End Get
        Set(ByVal value As User)
            Assign("CreateUser", value, _createUser)
        End Set
    End Property

    Public Overridable Property FreeService() As Core.Dal.IChildCollection(Of PatientProfileDescriptionService)
        Get
            Return _freeService
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of PatientProfileDescriptionService))
            Assign("FreeService", value, _freeService)
        End Set
    End Property

    Public Overridable Property DiscountService() As Core.Dal.IChildCollection(Of PatientProfileDescriptionService)
        Get
            Return _discountService
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of PatientProfileDescriptionService))
            Assign("DiscountService", value, _discountService)
        End Set
    End Property

    Public Overrides ReadOnly Property IsValid() As Boolean
        Get
            For Each profileDescriptionService As PatientProfileDescriptionService In FreeService.ActiveItemsWithoutEmpty
                If Not profileDescriptionService.IsValid Then
                    Return False
                End If
            Next
            For Each profileDescriptionService As PatientProfileDescriptionService In DiscountService.ActiveItemsWithoutEmpty
                If Not profileDescriptionService.IsValid Then
                    Return False
                End If
            Next
            Return MyBase.IsValid
        End Get
    End Property

    Public Overrides Function ToString() As String
        If Profile Is Nothing Then
            Return ""
        End If
        Return Profile.ToString()
    End Function

End Class
