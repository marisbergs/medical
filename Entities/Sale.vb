Imports Core.Bll
Imports Core.Dal

Public Class Sale
    Inherits BusinessObjectBase(Of Guid)

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        CreateDate = Now
        CreateUser = Context.Current.AuthenticatedUser
        Products = New ChildCollection(Of SaleProduct)
        AddBusinessRoles()
    End Sub
    Public Sub New()
        AddBusinessRoles()
    End Sub

    Private Sub AddBusinessRoles()

    End Sub

#Region "Private members"
    Private _patient As Patient
    Private _paymentDate As Nullable(Of DateTime)
    Private _paymentUser As User
    Private _notes As String
    Private _createDate As DateTime
    Private _createUser As User
    Private _deleteUser As User
    Private _products As IChildCollection(Of SaleProduct)

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

    Public Overridable Property CreateUser() As User
        Get
            Return _createUser
        End Get
        Set(ByVal value As User)
            Assign("CreateUser", value, _createUser)
        End Set
    End Property

    Public Overridable Property CreateDate() As Date
        Get
            Return _createDate
        End Get
        Set(ByVal value As Date)
            Assign("CreateDate", value, _createDate)
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

    Public Overridable Property DeleteUser() As User
        Get
            Return _deleteUser
        End Get
        Set(ByVal value As User)
            Assign("DeleteUser", value, _deleteUser)
        End Set
    End Property

    Public Overridable Property Products() As IChildCollection(Of SaleProduct)
        Get
            Return _products
        End Get
        Set(ByVal value As IChildCollection(Of SaleProduct))
            Assign("Products", value, _products)
        End Set
    End Property

#End Region

End Class
