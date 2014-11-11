Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Collections
Imports Core.Dal.Expressions
Imports Core.Bll

Public Class UserServicesFinder
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements Core.Bll.ISearchObject

    Public Sub New(ByVal session As Core.Dal.ISession)
        ResetValues(session)
        Validator.AddBusinessRule("Doctor", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseDoctor", "Doctor")
        Validator.AddBusinessRule("Service", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseService", "Service")
        Validator.AddBusinessRule("Room", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseRoom", "Room")
    End Sub

    Private _useDoctor As Boolean
    Private _useSpeciality As Boolean
    Private _useRoom As Boolean
    Private _useStartDate As Boolean
    Private _useCreateDate As Boolean
    Private _useService As Boolean
    Private _timeTo As Nullable(Of Date)
    Private _dateTo As Nullable(Of Date)
    Private _timeFrom As Nullable(Of Date)
    Private _dateFrom As Nullable(Of Date)
    Private _useBussinesGroup As Boolean
    Private _useMedicalSpecialization As Boolean
    Private _useServiceType As Boolean
    Private _useActive As Boolean
    Private _useCreatePlace As Boolean
    Private _createPlace As String

    Private _timeToSecond As Nullable(Of Date)
    Private _dateToSecond As Nullable(Of Date)
    Private _timeFromSecond As Nullable(Of Date)
    Private _dateFromSecond As Nullable(Of Date)

    Private _doctor As Entities(Of User)
    Private _speciality As Entities(Of Speciality)
    Private _serviceType As Entities(Of ServiceTypes)
    Private _medicalSpecialization As Entities(Of Specialization)
    Private _bussinesGroup As Entities(Of BusinessGroup)
    Private _service As Entities(Of Services)
    Private _Room As Entities(Of Room)
    Private _useUserGrouping As Boolean
    Private _userGrouping As Entities(Of EmployeGrouping)

    Private _useValidAt As Boolean
    Private _validAt As Date


    Public Overridable Property UseDoctor() As Boolean
        Get
            Return _useDoctor
        End Get
        Set(ByVal value As Boolean)
            Assign("UseDoctor", value, _useDoctor)
        End Set
    End Property

    Public Overridable Property UseSpeciality() As Boolean
        Get
            Return _useSpeciality
        End Get
        Set(ByVal value As Boolean)
            Assign("UseSpeciality", value, _useSpeciality)
        End Set
    End Property

    Public Overridable Property UseUserGrouping() As Boolean
        Get
            Return _useUserGrouping
        End Get
        Set(ByVal value As Boolean)
            Assign("UseUserGrouping", value, _useUserGrouping)
        End Set
    End Property

    Public Overridable Property UseStartDate() As Boolean
        Get
            Return _useStartDate
        End Get
        Set(ByVal value As Boolean)
            Assign("UseStartDate", value, _useStartDate)
        End Set
    End Property

    Public Overridable Property UseCreateDate() As Boolean
        Get
            Return _useCreateDate
        End Get
        Set(ByVal value As Boolean)
            Assign("UseCreateDate", value, _useCreateDate)
        End Set
    End Property


    Public Overridable Property UseCreatePlace() As Boolean
        Get
            Return _useCreatePlace
        End Get
        Set(ByVal value As Boolean)
            Assign("UseCreatePlace", value, _useCreatePlace)
        End Set
    End Property


    Public Overridable Property UseService() As Boolean
        Get
            Return _useService
        End Get
        Set(ByVal value As Boolean)
            Assign("UseService", value, _useService)
        End Set
    End Property

    Public Overridable Property UseRoom() As Boolean
        Get
            Return _useRoom
        End Get
        Set(ByVal value As Boolean)
            Assign("UseRoom", value, _useRoom)
        End Set
    End Property


    Public Overridable Property UseActive() As Boolean
        Get
            Return _useActive
        End Get
        Set(ByVal value As Boolean)
            Assign("UseActive", value, _useActive)
        End Set
    End Property


    Public Overridable Property UseServiceType() As Boolean
        Get
            Return _useServiceType
        End Get
        Set(ByVal value As Boolean)
            Assign("UseServiceType", value, _useServiceType)
        End Set
    End Property

    Public Overridable Property UseMedicalSpecialization() As Boolean
        Get
            Return _useMedicalSpecialization
        End Get
        Set(ByVal value As Boolean)
            Assign("UseMedicalSpecialization", value, _useMedicalSpecialization)
        End Set
    End Property


    Public Overridable Property UseBussinesGroup() As Boolean
        Get
            Return _useBussinesGroup
        End Get
        Set(ByVal value As Boolean)
            Assign("UseBussinesGroup", value, _useBussinesGroup)
        End Set
    End Property

    Public Overridable Property WithTimePickerDateFromSecond() As Nullable(Of Date)
        Get
            Return _dateFromSecond
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("WithTimePickerDateFromSecond", value, _dateFromSecond)
            Assign("WithTimePickerDateFromSecond", value, _timeFromSecond)
            If Not _dateToSecond.HasValue AndAlso _dateFromSecond.HasValue Then
                WithTimePickerDateUntilSecond = _dateFromSecond.Value.AddDays(1)
            End If
            If _dateToSecond.HasValue AndAlso _dateFromSecond.HasValue AndAlso _dateToSecond.Value <= _dateFromSecond.Value Then
                WithTimePickerDateUntilSecond = _dateFromSecond.Value.AddDays(1)
            End If
        End Set
    End Property

    Public Overridable Property WithTimePickerTimeFromSecond() As Nullable(Of Date)
        Get
            Return _timeFromSecond
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("WithTimePickerTimeFromSecond", value, _timeFromSecond)
        End Set
    End Property

    Public Overridable Property WithTimePickerDateUntilSecond() As Nullable(Of Date)
        Get
            Return _dateToSecond
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("WithTimePickerDateUntilSecond", value, _dateToSecond)
            Assign("WithTimePickerDateUntilSecond", value, _timeToSecond)
        End Set
    End Property

    Public Overridable Property WithTimePickerTimeUntilSecond() As Nullable(Of Date)
        Get
            Return _timeTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("WithTimePickerTimeUntilSecond", value, _timeToSecond)
        End Set
    End Property

    Public Overridable Property iodWithTimePickerDateFrom() As Nullable(Of Date)
        Get
            Return _dateFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("iodWithTimePickerDateFrom", value, _dateFrom)
            Assign("iodWithTimePickerTimeFrom", value, _timeFrom)
            If Not _dateTo.HasValue AndAlso _dateFrom.HasValue Then
                iodWithTimePickerDateUntil = _dateFrom.Value.AddDays(1)
            End If
            If _dateTo.HasValue AndAlso _dateFrom.HasValue AndAlso _dateTo.Value <= _dateFrom.Value Then
                iodWithTimePickerDateUntil = _dateFrom.Value.AddDays(1)
            End If
        End Set
    End Property

    Public Overridable Property iodWithTimePickerTimeFrom() As Nullable(Of Date)
        Get
            Return _timeFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("iodWithTimePickerTimeFrom", value, _timeFrom)
        End Set
    End Property

    Public Overridable Property iodWithTimePickerDateUntil() As Nullable(Of Date)
        Get
            Return _dateTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("iodWithTimePickerDateUntil", value, _dateTo)
            Assign("iodWithTimePickerTimeUntil", value, _timeTo)
        End Set
    End Property

    Public Overridable Property iodWithTimePickerTimeUntil() As Nullable(Of Date)
        Get
            Return _timeTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("iodWithTimePickerTimeUntil", value, _timeTo)
        End Set
    End Property

    Public Overridable Property Doctor() As Entities(Of User)
        Get
            Return _doctor
        End Get
        Set(ByVal value As Entities(Of User))
            Assign("Doctor", value, _doctor)
        End Set
    End Property

    Public Overridable Property Speciality() As Entities(Of Speciality)
        Get
            Return _speciality
        End Get
        Set(ByVal value As Entities(Of Speciality))
            Assign("Speciality", value, _speciality)
        End Set
    End Property

    Public Overridable Property UserGrouping() As Entities(Of EmployeGrouping)
        Get
            Return _userGrouping
        End Get
        Set(ByVal value As Entities(Of EmployeGrouping))
            Assign("UserGrouping", value, _userGrouping)
        End Set
    End Property

    Public Overridable Property ServiceType() As Entities(Of ServiceTypes)
        Get
            Return _serviceType
        End Get
        Set(ByVal value As Entities(Of ServiceTypes))
            Assign("ServiceType", value, _serviceType)
        End Set
    End Property

    Public Overridable Property MedicalSpecialization() As Entities(Of Specialization)
        Get
            Return _medicalSpecialization
        End Get
        Set(ByVal value As Entities(Of Specialization))
            Assign("MedicalSpecialization", value, _medicalSpecialization)
        End Set
    End Property

    Public Overridable Property BussinesGroup() As Entities(Of BusinessGroup)
        Get
            Return _bussinesGroup
        End Get
        Set(ByVal value As Entities(Of BusinessGroup))
            Assign("BussinesGroup", value, _bussinesGroup)
        End Set
    End Property

    Public Overridable Property Service() As Entities(Of Services)
        Get
            Return _service
        End Get
        Set(ByVal value As Entities(Of Services))
            Assign("Service", value, _service)
        End Set
    End Property

    Public Overridable Property Room() As Entities(Of Room)
        Get
            Return _Room
        End Get
        Set(ByVal value As Entities(Of Room))
            Assign("Room", value, _Room)
        End Set
    End Property

    Public Overridable Property CreatePlace() As String
        Get
            Return _createPlace
        End Get
        Set(ByVal value As String)
            Assign("CreatePlace", value, _createPlace)
        End Set
    End Property

    Public Overridable ReadOnly Property DateTimeFrom() As Nullable(Of DateTime)
        Get
            If _dateFrom.HasValue And _timeFrom.HasValue Then
                Return DateAdd(DateInterval.Hour, Me._timeFrom.Value.Hour, DateAdd(DateInterval.Minute, Me._timeFrom.Value.Minute, Me._dateFrom.Value))
            ElseIf _dateFrom.HasValue Then
                Return _dateFrom
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property DateTimeTo() As Nullable(Of DateTime)
        Get
            If _dateTo.HasValue And _timeTo.HasValue Then
                Return DateAdd(DateInterval.Hour, Me._timeTo.Value.Hour, DateAdd(DateInterval.Minute, Me._timeTo.Value.Minute, Me._dateTo.Value))
            ElseIf _dateFrom.HasValue Then
                Return _dateTo
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property DateTimeFromSecond() As Nullable(Of DateTime)
        Get
            If _dateFromSecond.HasValue And _timeFromSecond.HasValue Then
                Return DateAdd(DateInterval.Hour, Me._timeFromSecond.Value.Hour, DateAdd(DateInterval.Minute, Me._timeFromSecond.Value.Minute, Me._dateFromSecond.Value))
            ElseIf _dateFromSecond.HasValue Then
                Return _dateFromSecond
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property DateTimeToSecond() As Nullable(Of DateTime)
        Get
            If _dateToSecond.HasValue And _timeToSecond.HasValue Then
                Return DateAdd(DateInterval.Hour, Me._timeToSecond.Value.Hour, DateAdd(DateInterval.Minute, Me._timeToSecond.Value.Minute, Me._dateToSecond.Value))
            ElseIf _dateFromSecond.HasValue Then
                Return _dateToSecond
            End If
        End Get
    End Property

    Public Overridable Property UseValidAt() As Boolean
        Get
            Return _useValidAt
        End Get
        Set(ByVal value As Boolean)
            Me.Assign("UseValidAt", value, _useValidAt)
        End Set
    End Property

    Public Overridable Property ValidAt() As Date
        Get
            Return _validAt
        End Get
        Set(ByVal value As Date)
            Assign("ValidAt", value, _validAt)
        End Set
    End Property

    Public Function BuildCriteria() As IList(Of Core.Dal.Expressions.CriterionBase) Implements Core.Bll.ISearchObject.BuildCriteria
        Dim result As New List(Of CriterionBase)
        If Me.UseDoctor Then result.Add(Core.Dal.CriteriaBuilder.IsInCollection("User", Me._doctor))

        If Me.UseServiceType Then result.Add(Core.Dal.CriteriaBuilder.IsInCollection("Service.ReferenceSecond", Me._serviceType))
        If Me.UseMedicalSpecialization Then result.Add(Core.Dal.CriteriaBuilder.IsInCollection("Service.ReferenceThird", Me._medicalSpecialization))
        If Me.UseBussinesGroup Then result.Add(Core.Dal.CriteriaBuilder.IsInCollection("Service.ReferenceFourth", Me._bussinesGroup))
        result.Add(New IsNull("DeleteTime"))
        result.Add(New IsNull("Service.DeleteTime"))

        If Me.UseValidAt Then
            result.Add(New Core.Dal.Expressions.Or(New Core.Dal.Expressions.IsNull("Service.ValidUntil"), New Core.Dal.Expressions.Ge("Service.ValidUntil", ValidAt.Date)))
            result.Add(New IsNull("User.DeleteTime"))
            result.Add(New Core.Dal.Expressions.Le("User.WorksFrom", ValidAt.Date))
            result.Add(New Core.Dal.Expressions.Or(New IsNull("User.WorkedUntil"), New Core.Dal.Expressions.Ge("User.WorkedUntil", ValidAt.Date)))
        Else
            result.Add(New Core.Dal.Expressions.Or(New Core.Dal.Expressions.IsNull("Service.ValidUntil"), New Core.Dal.Expressions.Ge("Service.ValidUntil", Now.Date)))
            result.Add(New IsNull("User.DeleteTime"))
            result.Add(New Core.Dal.Expressions.Le("User.WorksFrom", Now.Date))
            result.Add(New Core.Dal.Expressions.Or(New IsNull("User.WorkedUntil"), New Core.Dal.Expressions.Ge("User.WorkedUntil", Now.Date)))
        End If
        Return result
    End Function

    Public Sub ResetValues(ByVal session As Core.Dal.ISession) Implements Core.Bll.ISearchObject.ResetValues
        Me.UseRoom = False
        If Context.Current.AuthenticatedUser.Position.Mark Then
            Me.UseDoctor = True
            Me.Doctor = New Entities(Of User)
            Me.Doctor.Add(Context.Current.AuthenticatedUser)
        Else
            Me.UseDoctor = False
            Me.Doctor = Nothing
        End If
        Me.UseService = False
        Me.UseActive = True
        Me.UseBussinesGroup = False
        Me.UseCreateDate = False
        Me.UseUserGrouping = False

        Me.Room = Nothing
        Me.Service = Nothing
    End Sub

End Class

