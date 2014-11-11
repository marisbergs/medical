Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Collections
Imports Core.Dal.Expressions
Imports Core.Bll
Imports Entities

Public Class VisitsFinder
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements Core.Bll.ISearchObject

    Public Sub New(ByVal session As Core.Dal.ISession)
        ResetValues(session)
        Validator.AddBusinessRule("Doctor", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseDoctor", "Doctor")
        Validator.AddBusinessRule("Service", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseService", "Service")
        Validator.AddBusinessRule("iodWithTimePickerDateFrom", AddressOf CommonBusinessRules.CheckConditionalDateInterval, "UseStartDate", "iodWithTimePickerDateFrom", "iodWithTimePickerDateUntil")
        Validator.AddBusinessRule("iodWithTimePickerDateUntil", AddressOf CommonBusinessRules.CheckConditionalDateInterval, "UseStartDate", "iodWithTimePickerDateFrom", "iodWithTimePickerDateUntil")
        Validator.AddBusinessRule("Room", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseRoom", "Room")
    End Sub

    Private _useDoctor As Boolean

    Public Overridable Property UseDoctor() As Boolean
        Get
            Return _useDoctor
        End Get
        Set(ByVal value As Boolean)
            Assign("UseDoctor", value, _useDoctor)
        End Set
    End Property

    Private _useStartDate As Boolean

    Public Overridable Property UseStartDate() As Boolean
        Get
            Return _useStartDate
        End Get
        Set(ByVal value As Boolean)
            Assign("UseStartDate", value, _useStartDate)
        End Set
    End Property

    Private _useService As Boolean

    Public Overridable Property UseService() As Boolean
        Get
            Return _useService
        End Get
        Set(ByVal value As Boolean)
            Assign("UseService", value, _useService)
        End Set
    End Property

    Private _useRoom As Boolean

    Public Overridable Property UseRoom() As Boolean
        Get
            Return _useRoom
        End Get
        Set(ByVal value As Boolean)
            Assign("UseRoom", value, _useRoom)
        End Set
    End Property

    Private _useActive As Boolean

    Public Overridable Property UseActive() As Boolean
        Get
            Return _useActive
        End Get
        Set(ByVal value As Boolean)
            Assign("UseActive", value, _useActive)
        End Set
    End Property

    Private _dateFrom As Nullable(Of Date)

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

    Private _timeFrom As Nullable(Of Date)

    Public Overridable Property iodWithTimePickerTimeFrom() As Nullable(Of Date)
        Get
            Return _timeFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("iodWithTimePickerTimeFrom", value, _timeFrom)
        End Set
    End Property

    Private _dateTo As Nullable(Of Date)

    Public Overridable Property iodWithTimePickerDateUntil() As Nullable(Of Date)
        Get
            Return _dateTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("iodWithTimePickerDateUntil", value, _dateTo)
            Assign("iodWithTimePickerTimeUntil", value, _timeTo)
        End Set
    End Property

    Private _timeTo As Nullable(Of Date)

    Public Overridable Property iodWithTimePickerTimeUntil() As Nullable(Of Date)
        Get
            Return _timeTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("iodWithTimePickerTimeUntil", value, _timeTo)
        End Set
    End Property

    Private _doctor As Entities(Of User)

    Public Overridable Property Doctor() As Entities(Of User)
        Get
            Return _doctor
        End Get
        Set(ByVal value As Entities(Of User))
            Assign("Doctor", value, _doctor)
        End Set
    End Property

    Private _service As Entities(Of Services)

    Public Overridable Property Service() As Entities(Of Services)
        Get
            Return _service
        End Get
        Set(ByVal value As Entities(Of Services))
            Assign("Service", value, _service)
        End Set
    End Property

    Private _Room As Entities(Of Room)

    Public Overridable Property Room() As Entities(Of Room)
        Get
            Return _Room
        End Get
        Set(ByVal value As Entities(Of Room))
            Assign("Room", value, _Room)
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

    Public Function BuildCriteria() As IList(Of Core.Dal.Expressions.CriterionBase) Implements Core.Bll.ISearchObject.BuildCriteria
        Dim result As New List(Of CriterionBase)
        If Me.UseDoctor Then result.Add(Core.Dal.CriteriaBuilder.IsInCollection("Doctor", Me._doctor))
        If Me.UseStartDate Then result.Add(Core.Dal.CriteriaBuilder.IntervalsOverlap("StartTime", "StartTime", DateTimeFrom, DateTimeTo))
        If Me.UseRoom Then result.Add(Core.Dal.CriteriaBuilder.IsInCollection("Room", Me._Room))
        If Me.UseService Then result.Add(Core.Dal.CriteriaBuilder.IsInCollection("Service", Me._service))

        If Me.UseActive Then result.Add(New Core.Dal.Expressions.IsNull("DeleteTime"))
        Return result
    End Function

    Public Sub ResetValues(ByVal session As Core.Dal.ISession) Implements Core.Bll.ISearchObject.ResetValues
        Me.UseStartDate = True
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


        Me.iodWithTimePickerDateFrom = Date.Now.Date
        Me.iodWithTimePickerDateUntil = Date.Now.Date.AddDays(1)
        Me.Room = Nothing
        Me.Service = Nothing
    End Sub

End Class

