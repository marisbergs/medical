Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Core.Dal
Imports Core.Bll
Imports Core.Dal.Expressions

Public Class FindActivity
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements INotifyPropertyChanged
    Implements Core.Bll.ISearchObject

#Region "Private members"
    Private _useActive As Boolean

    Private _usePatientName As Boolean
    Private _patientName As String
    Private _usePatientSurname As Boolean
    Private _patientSurname As String
    Private _useUserName As Boolean
    Private _userName As String
    Private _useUserSurname As Boolean
    Private _userSurname As String
    Private _useService As Boolean
    Private _service As IList(Of Services)

    Private _useActivityDate As Boolean
    Private _timeTo As Nullable(Of Date)
    Private _dateTo As Nullable(Of Date)
    Private _timeFrom As Nullable(Of Date)
    Private _dateFrom As Nullable(Of Date)

    Private _useRemindDate As Boolean
    Private _remindTimeTo As Nullable(Of Date)
    Private _remindDateTo As Nullable(Of Date)
    Private _remindTimeFrom As Nullable(Of Date)
    Private _remindDateFrom As Nullable(Of Date)

#End Region

    Public Sub New(ByVal session As Core.Dal.ISession)
        ResetValues(session)
    End Sub


    Public Overridable Property UseActive() As Boolean
        Get
            Return _useActive
        End Get
        Set(ByVal value As Boolean)
            Assign("UseActive", value, _useActive)
        End Set
    End Property

    ''' <summary>
    ''' Meklēt pēc klienta vārda
    ''' </summary>
    Public Overridable Property UsePatientName() As Boolean
        Get
            Return _usePatientName
        End Get
        Set(ByVal value As Boolean)
            Assign("UsePatientName", value, _usePatientName)
        End Set
    End Property

    ''' <summary>
    ''' Klienta vārds
    ''' </summary>
    Public Overridable Property PatientName() As String
        Get
            Return _patientName
        End Get
        Set(ByVal value As String)
            Assign("PatientName", value, _patientName)
        End Set
    End Property

    ''' <summary>
    ''' Meklēt pāc klienta uzvārda
    ''' </summary>
    Public Overridable Property UsePatientSurname() As Boolean
        Get
            Return _usePatientSurname
        End Get
        Set(ByVal value As Boolean)
            Assign("UsePatientSurname", value, _usePatientSurname)
        End Set
    End Property

    ''' <summary>
    ''' Klienta uzvārds
    ''' </summary>
    Public Overridable Property PatientSurname() As String
        Get
            Return _patientSurname
        End Get
        Set(ByVal value As String)
            Assign("PatientSurname", value, _patientSurname)
        End Set
    End Property

    ''' <summary>
    ''' Meklēt pēc klienta vārda
    ''' </summary>
    Public Overridable Property UseUserName() As Boolean
        Get
            Return _useUserName
        End Get
        Set(ByVal value As Boolean)
            Assign("UseUserName", value, _useUserName)
        End Set
    End Property

    ''' <summary>
    ''' Klienta vārds
    ''' </summary>
    Public Overridable Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            Assign("UserName", value, _userName)
        End Set
    End Property

    ''' <summary>
    ''' Meklēt pāc klienta uzvārda
    ''' </summary>
    Public Overridable Property UseUserSurname() As Boolean
        Get
            Return _useUserSurname
        End Get
        Set(ByVal value As Boolean)
            Assign("UseUserSurname", value, _useUserSurname)
        End Set
    End Property

    ''' <summary>
    ''' Klienta uzvārds
    ''' </summary>
    Public Overridable Property UserSurname() As String
        Get
            Return _userSurname
        End Get
        Set(ByVal value As String)
            Assign("UserSurname", value, _userSurname)
        End Set
    End Property
    ''' <summary>
    ''' personas kods
    ''' </summary>
    Public Overridable Property UseService() As Boolean
        Get
            Return _useService
        End Get
        Set(ByVal value As Boolean)
            Assign("UseService", value, _useService)
        End Set
    End Property

    ''' <summary>
    ''' personas kods
    ''' </summary>
    Public Overridable Property Service() As IList(Of Services)
        Get
            Return _service
        End Get
        Set(ByVal value As IList(Of Services))
            Assign("Service", value, _service)
        End Set
    End Property


    Public Overridable Property UseActivityDate() As Boolean
        Get
            Return _useActivityDate
        End Get
        Set(ByVal value As Boolean)
            Assign("UseActivityDate", value, _useActivityDate)
        End Set
    End Property


    Public Overridable Property ActivityDateDateFrom() As Nullable(Of Date)
        Get
            Return _dateFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("ActivityDateDateFrom", value, _dateFrom)
            Assign("ActivityDateTimeFrom", value, _timeFrom)
            If Not _dateTo.HasValue AndAlso _dateFrom.HasValue Then
                ActivityDateDateUntil = _dateFrom.Value.AddDays(1)
            End If
            If _dateTo.HasValue AndAlso _dateFrom.HasValue AndAlso _dateTo.Value <= _dateFrom.Value Then
                ActivityDateDateUntil = _dateFrom.Value.AddDays(1)
            End If
        End Set
    End Property

    Public Overridable Property ActivityDateTimeFrom() As Nullable(Of Date)
        Get
            Return _timeFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("ActivityDateTimeFrom", value, _timeFrom)
        End Set
    End Property

    Public Overridable Property ActivityDateDateUntil() As Nullable(Of Date)
        Get
            Return _dateTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("ActivityDateDateUntil", value, _dateTo)
            Assign("ActivityDateTimeUntil", value, _timeTo)
        End Set
    End Property

    Public Overridable Property ActivityDateTimeUntil() As Nullable(Of Date)
        Get
            Return _timeTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("ActivityDateTimeUntil", value, _timeTo)
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


    Public Overridable Property UseRemindDate() As Boolean
        Get
            Return _useRemindDate
        End Get
        Set(ByVal value As Boolean)
            Assign("UseRemindDate", value, _useRemindDate)
        End Set
    End Property



    Public Overridable Property RemindDateDateFrom() As Nullable(Of Date)
        Get
            Return _remindDateFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("RemindDateDateFrom", value, _remindDateFrom)
            Assign("RemindDateTimeFrom", value, _remindTimeFrom)
            If Not _remindDateTo.HasValue AndAlso _remindDateFrom.HasValue Then
                RemindDateDateUntil = _remindDateFrom.Value.AddDays(1)
            End If
            If _remindDateTo.HasValue AndAlso _remindDateFrom.HasValue AndAlso _remindDateTo.Value <= _remindDateFrom.Value Then
                RemindDateDateUntil = _remindDateFrom.Value.AddDays(1)
            End If
        End Set
    End Property

    Public Overridable Property RemindDateTimeFrom() As Nullable(Of Date)
        Get
            Return _remindTimeFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("RemindDateTimeFrom", value, _remindTimeFrom)
        End Set
    End Property

    Public Overridable Property RemindDateDateUntil() As Nullable(Of Date)
        Get
            Return _dateTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("RemindDateDateUntil", value, _dateTo)
            Assign("RemindDateTimeUntil", value, _timeTo)
        End Set
    End Property

    Public Overridable Property RemindDateTimeUntil() As Nullable(Of Date)
        Get
            Return _timeTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("RemindDateTimeUntil", value, _timeTo)
        End Set
    End Property

    'Public Overridable ReadOnly Property RemindDateTimeFrom() As Nullable(Of DateTime)
    '    Get
    '        If _remindDateFrom.HasValue And _remindTimeFrom.HasValue Then
    '            Return DateAdd(DateInterval.Hour, Me._remindTimeFrom.Value.Hour, DateAdd(DateInterval.Minute, Me._remindTimeFrom.Value.Minute, Me._dateFrom.Value))
    '        ElseIf _remindDateFrom.HasValue Then
    '            Return _remindDateFrom
    '        End If
    '    End Get
    'End Property

    'Public Overridable ReadOnly Property RemindDateTimeTo() As Nullable(Of DateTime)
    '    Get
    '        If _remindDateTo.HasValue And _remindTimeTo.HasValue Then
    '            Return DateAdd(DateInterval.Hour, Me._remindTimeTo.Value.Hour, DateAdd(DateInterval.Minute, Me._remindTimeTo.Value.Minute, Me._remindDateTo.Value))
    '        ElseIf _dateFrom.HasValue Then
    '            Return _dateTo
    '        End If
    '    End Get
    'End Property


#Region "ISearchObject"
    Public Function BuildCriteria() As IList(Of Core.Dal.Expressions.CriterionBase) Implements Core.Bll.ISearchObject.BuildCriteria
        Dim result As New List(Of CriterionBase)

        If Me.UseActive Then result.Add(New Core.Dal.Expressions.IsNull("DeleteTime"))

        If Me.UsePatientName Then result.Add(CriteriaBuilder.MultiValueLike("Patient.Name", Me.PatientName & "%"))
        If Me.UsePatientSurname Then result.Add(CriteriaBuilder.MultiValueLike("Patient.Surname", Me.PatientSurname & "%"))
        If Me.UseUserName Then result.Add(CriteriaBuilder.MultiValueLike("User.FirstName", Me.UserName & "%"))
        If Me.UseUserSurname Then result.Add(CriteriaBuilder.MultiValueLike("User.LastName", Me.UserSurname & "%"))

        If Me.UseService Then result.Add(CriteriaBuilder.IsInCollection("Service", Me.Service))


        If Me.UseActivityDate Then result.Add(CriteriaBuilder.IntervalsOverlap("ActivityDate", "ActivityDate", _dateFrom, _dateTo))
        If Me.UseRemindDate Then result.Add(CriteriaBuilder.IntervalsOverlap("RemindDate", "RemindDate", _remindDateFrom, _remindDateTo))

        Return result
    End Function

    Public Sub ResetValues(ByVal session As Core.Dal.ISession) Implements Core.Bll.ISearchObject.ResetValues
        UseActive = True
        UseActivityDate = True
        ActivityDateDateFrom = Now.Date
        ActivityDateDateUntil = Now.Date.AddDays(1)
        RemindDateDateFrom = Now.Date
        RemindDateDateUntil = Now.Date.AddDays(1)
    End Sub
#End Region

End Class
