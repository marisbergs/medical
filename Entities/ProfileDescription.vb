Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class ProfileDescription
    Inherits BusinessObjectBase(Of Guid)

    Protected Sub New()
        MyBase.New()
        BusinessRule()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        BusinessRule()
        FreeService = New ChildCollection(Of ProfileDescriptionService)
        DiscountService = New ChildCollection(Of ProfileDescriptionService)
    End Sub

    Private Sub BusinessRule()
        Validator.AddBusinessRule("Profile", AddressOf CommonBusinessRules.CheckRequired, "Profile")
        Validator.AddBusinessRule("Price", AddressOf CommonBusinessRules.CheckRequired, "Price")
        Validator.AddBusinessRule("Count", AddressOf CommonBusinessRules.CheckRequired, "Count")
    End Sub

    Private _profile As Profile
    Private _price As Nullable(Of Decimal)
    Private _count As Nullable(Of Integer)
    Private _freeService As IChildCollection(Of ProfileDescriptionService)
    Private _discountService As IChildCollection(Of ProfileDescriptionService)

    Public Overridable Property Profile() As Profile
        Get
            Return _profile
        End Get
        Set(ByVal value As Profile)
            Assign("Profile", value, _profile)
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

    Public Overridable Property FreeService() As Core.Dal.IChildCollection(Of ProfileDescriptionService)
        Get
            Return _freeService
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of ProfileDescriptionService))
            Assign("FreeService", value, _freeService)
        End Set
    End Property

    Public Overridable Property DiscountService() As Core.Dal.IChildCollection(Of ProfileDescriptionService)
        Get
            Return _discountService
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of ProfileDescriptionService))
            Assign("DiscountService", value, _discountService)
        End Set
    End Property

    Public Overrides ReadOnly Property IsValid() As Boolean
        Get
            For Each profileDescriptionService As ProfileDescriptionService In FreeService.ActiveItemsWithoutEmpty
                If Not profileDescriptionService.IsValid Then
                    Return False
                End If
            Next
            For Each profileDescriptionService As ProfileDescriptionService In DiscountService.ActiveItemsWithoutEmpty
                If Not profileDescriptionService.IsValid Then
                    Return False
                End If
            Next
            Return MyBase.IsValid
        End Get
    End Property

End Class
