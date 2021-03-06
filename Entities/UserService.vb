Imports Core.Bll
Imports Core.Dal

''' <summary>
''' KP lietas tematiskās pārbaudes tēmas
''' </summary>
Public Class UserService
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

#Region "Constructor"

    Private _isActive As Boolean

    Protected Sub New()
        MyBase.New()
        BusinessRule()
    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession)
        MyBase.New(session)
        BusinessRule()
    End Sub

    Private Sub BusinessRule()
        Validator.AddBusinessRule("Service", AddressOf CommonBusinessRules.CheckRequired, "Service")
    End Sub
#End Region

#Region "Private members"
    Private _service As Services
    Private _price As Double
    Private _manualPrice As Nullable(Of Double)
    Private _manualTime As Nullable(Of Integer)
    Private _user As User
    Private _seleryType As SeleryType
    Private _seleryValue As Nullable(Of Decimal)
    Private _selery As Selery
    Private _userServiceSelery As IChildCollection(Of UserServiceSalary)
    Private _removeVAT As Boolean
    Private _removeMaterials As Boolean
#End Region


    ''' <summary>
    ''' Specialitāte
    ''' </summary>
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

    ''' <summary>
    ''' manuāli norādītā cena, kas glabājas DB
    ''' </summary>
    Public Overridable Property ManualPrice() As Nullable(Of Double)
        Get
            Return _manualPrice
        End Get
        Set(ByVal value As Nullable(Of Double))
            Assign("ManualPrice", value, _manualPrice)
        End Set
    End Property


    ''' <summary>
    ''' cena, kas bindojās ar UI
    ''' </summary>
    Public Overridable Property Time() As Integer
        Get
            If ManualTime.HasValue Then
                Return ManualTime.Value
            Else
                If Service.IntegerValue.HasValue Then
                    Return Service.IntegerValue.Value
                Else
                    Return Nothing
                End If
            End If
        End Get
        Set(ByVal value As Integer)
            If Service.IntegerValue.HasValue Then
                If value <> Service.IntegerValue.Value AndAlso Not value = 0 Then
                    ManualTime = value
                Else
                    ManualTime = Nothing
                End If
            Else
                If Not value = 0 Then
                    ManualTime = value
                Else
                    ManualTime = Nothing
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' manuāli norādītais laiks, kas glabājas DB
    ''' </summary>
    Public Overridable Property ManualTime() As Nullable(Of Integer)
        Get
            Return _manualTime
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("ManualTime", value, _manualTime)
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


    ''' <summary>
    ''' cena, kas bindojās ar UI
    ''' </summary>
    Public Overridable Property Price() As Double
        Get
            If ManualPrice.HasValue Then
                Return ManualPrice.Value
            Else
                Return Service.DecimalValue
            End If
        End Get
        Set(ByVal value As Double)
            If value <> Service.DecimalValue AndAlso Not value = 0 Then
                ManualPrice = value
            Else
                ManualPrice = Nothing
            End If
        End Set
    End Property

    ''' <summary>
    ''' Ārsts
    ''' </summary>
    Public Overridable Property User() As Entities.User
        Get
            Return _user
        End Get
        Set(ByVal value As Entities.User)
            Assign("User", value, _user)
        End Set
    End Property

    Public Overridable Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.User
        End Get
        Set(ByVal value As Object)
            Me.User = CType(value, User)
        End Set
    End Property

    Public Overridable ReadOnly Property IsServiceDelete() As Boolean
        Get
            If Service Is Nothing Then
                Return False
            Else
                Return Not Service.IsActive Or (Service.ValidUntil.HasValue AndAlso Service.ValidUntil.Value < DateTime.Now)
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

    ''' <summary>
    ''' Return whether can delete CM case theme
    ''' </summary>
    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            If User Is Nothing Then
                Return False
            End If
            If Not Me.IsActive Then
                Return False
            End If
            Return User.CanAddDeleteSpeciality
        End Get
    End Property

    ''' <summary>
    ''' Return whether can edit CM case theme
    ''' </summary>
    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            If Me.IsActive Then
                Return True
            End If
            Return False
        End Get
    End Property

    Public Overrides Function ToString() As String
        If Me.Service Is Nothing Then Return ""
        Return Service.Value
    End Function

    Public Overridable ReadOnly Property Code() As String
        Get
            Dim res As String = ""
            If Not Service Is Nothing Then
                res &= Service.ReferenceSecond.Code & "-"
            End If
            If Not Speciality Is Nothing Then
                res &= Speciality.Code & "-"
            End If
            If Not User Is Nothing Then
                res &= User.Code & "-"
            End If
            If Not Service Is Nothing Then
                res &= Service.Code
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property Speciality() As Speciality
        Get
            Dim list As IList(Of Speciality) = New List(Of Speciality)
            For Each x As UsersSpecialities In User.UserSpecialities.ActiveItemsWithoutEmpty
                If (x.Speciality.Services.Contains(Service)) Then
                    list.Add(x.Speciality)
                End If
            Next
            If list.Count = 1 Then
                Return list(0)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property Specialities() As List(Of Speciality)
        Get
            Dim list As New List(Of Speciality)
            For Each x As UsersSpecialities In User.UserSpecialities.ActiveItemsWithoutEmpty
                If (x.Speciality.Services.Contains(Service)) Then
                    list.Add(x.Speciality)
                End If
            Next
            Return list
        End Get
    End Property

    Public Overridable ReadOnly Property ServiceType() As Classifier
        Get
            If Service.ReferenceSecond Is Nothing Then
                Return Nothing
            Else
                Return CType(Service.ReferenceSecond, Classifier)
            End If
        End Get
    End Property

    Public Overridable Property UserServiceSelery() As IChildCollection(Of UserServiceSalary)
        Get
            Return _userServiceSelery
        End Get
        Set(ByVal value As IChildCollection(Of UserServiceSalary))
            Assign("UserServiceSelery", value, _userServiceSelery)
        End Set
    End Property

    Public Overridable Property RemoveVAT() As Boolean
        Get
            Return _removeVAT
        End Get
        Set(ByVal value As Boolean)
            Assign("RemoveVAT", value, _removeVAT)
        End Set
    End Property

    Public Overridable Property RemoveMaterials() As Boolean
        Get
            Return _removeMaterials
        End Get
        Set(ByVal value As Boolean)
            Assign("RemoveMaterials", value, _removeMaterials)
        End Set
    End Property

End Class
' Уныкоде