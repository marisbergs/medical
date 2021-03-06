Imports Core.Bll

''' <summary>
''' KP lietas tematiskās pārbaudes tēmas
''' </summary>
Public Class UserServiceSalary
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

#Region "Constructor"
    Protected Sub New()
        MyBase.New()
        BusinessRule()
    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession)
        MyBase.New(session)
        BusinessRule()
    End Sub

    Private Sub BusinessRule()

    End Sub
#End Region

#Region "Private members"
    Private _userService As UserService
    Private _seleryType As SeleryType
    Private _seleryValue As Nullable(Of Decimal)
    Private _selery As Selery
    Private _validFrom As Nullable(Of DateTime)
    Private _validTo As Nullable(Of DateTime)
#End Region


    ''' <summary>
    ''' Ārsta pakalpojums
    ''' </summary>
    Public Overridable Property UserService() As UserService
        Get
            Return _userService
        End Get
        Set(ByVal value As UserService)
            Assign("UserService", value, _userService)
        End Set
    End Property

    ''' <summary>
    ''' Atalgojuma tips
    ''' </summary>
    Public Overridable Property SeleryType() As SeleryType
        Get
            Return _seleryType
        End Get
        Set(ByVal value As SeleryType)
            Assign("SeleryType", value, _seleryType)
        End Set
    End Property

    ''' <summary>
    ''' Atalgojuma apjoms
    ''' </summary>
    Public Overridable Property SeleryValue() As Nullable(Of Decimal)
        Get
            Return _seleryValue
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Assign("SeleryValue", value, _seleryValue)
        End Set
    End Property

    ''' <summary>
    ''' Atalgojuma aprēķina veids procenti vai Lati
    ''' </summary>
    Public Overridable Property Selery() As Selery
        Get
            Return _selery
        End Get
        Set(ByVal value As Selery)
            Assign("Selery", value, _selery)
        End Set
    End Property

    Public Overridable Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.UserService
        End Get
        Set(ByVal value As Object)
            Me.UserService = CType(value, UserService)
        End Set
    End Property

    Public Overridable Property ValidFrom() As Nullable(Of Date)
        Get
            Return _validFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
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
End Class
' Уныкоде