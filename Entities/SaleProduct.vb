Imports Core.Bll
Imports Core.Dal

Public Class SaleProduct
    Inherits BusinessObjectBase(Of Guid)

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        AddBusinessRoles()
        Count = 1
    End Sub
    Public Sub New()
        AddBusinessRoles()
    End Sub

    Private Sub AddBusinessRoles()

    End Sub

#Region "Private members"
    Private _sale As Sale
    Private _service As Services
    Private _price As Decimal
    Private _count As Integer
    Private _total As Decimal

#End Region

#Region "Public member"

    Public Overridable Property Sale() As Sale
        Get
            Return _sale
        End Get
        Set(ByVal value As Sale)
            Assign("Sale", value, _sale)
        End Set
    End Property

    Public Overridable ReadOnly Property Code() As String
        Get
            Return CStr(IIf(Service Is Nothing, "", Service.Code))
        End Get
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

    Public Overridable Property Count() As Integer
        Get
            Return _count
        End Get
        Set(ByVal value As Integer)
            Assign("Count", value, _count)
        End Set
    End Property

    Public Overridable ReadOnly Property Total() As Decimal
        Get
            Return Price * Count
        End Get
    End Property
#End Region

End Class
