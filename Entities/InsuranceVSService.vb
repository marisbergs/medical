Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class InsuranceVSService
    Inherits BusinessObjectBase(Of Guid)

#Region "Private members"
    Private _insurance As Insurance
    Private _service As Services
    Private _insuranceValue As Decimal
    Private _valueFrom As Decimal
    Private _validFrom As DateTime
    Private _validTo As Nullable(Of DateTime)
    Private _active As Boolean
    Private _createDate As DateTime
    Private _createUser As User
    Private _modifyDate As Nullable(Of DateTime)
    Private _modifyUser As User
    Private _deleteUser As User
#End Region

#Region "Property"

    Public Overridable Property Insurance() As Insurance
        Get
            Return _insurance
        End Get
        Set(ByVal value As Insurance)
            Assign("Insurance", value, _insurance)
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

    Public Overridable Property InsuranceValue() As Decimal
        Get
            Return _insuranceValue
        End Get
        Set(ByVal value As Decimal)
            Assign("InsuranceValue", value, _insuranceValue)
        End Set
    End Property

    Public Overridable Property ValueFrom() As Decimal
        Get
            Return _valueFrom
        End Get
        Set(ByVal value As Decimal)
            Assign("ValueFrom", value, _valueFrom)
        End Set
    End Property

    Public Overridable Property ValidFrom() As Date
        Get
            Return _validFrom
        End Get
        Set(ByVal value As Date)
            Assign("ValidFrom", value, _validFrom)
        End Set
    End Property

    Public Overridable Property ValidTo() As Nullable(Of Date)
        Get
            Return _validTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("ValidTo", value, _validTo)
        End Set
    End Property

    Public Overridable Property Active() As Boolean
        Get
            Return _active
        End Get
        Set(ByVal value As Boolean)
            Assign("Active", value, _active)
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

    Public Overridable Property CreateUser() As User
        Get
            Return _createUser
        End Get
        Set(ByVal value As User)
            Assign("CreateUser", value, _createUser)
        End Set
    End Property

    Public Overridable Property ModifyDate() As Nullable(Of Date)
        Get
            Return _modifyDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("ModifyDate", value, _modifyDate)
        End Set
    End Property

    Public Overridable Property ModifyUser() As User
        Get
            Return _modifyUser
        End Get
        Set(ByVal value As User)
            Assign("ModifyUser", value, _modifyUser)
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

#End Region

End Class
