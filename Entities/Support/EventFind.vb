Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Collections
Imports Core.Dal.Expressions
Imports Core.Bll

Public Class EventFind
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements Core.Bll.ISearchObject

    Public Sub New(ByVal session As Core.Dal.ISession)
        ResetValues(session)
        Validator.AddBusinessRule("User", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseUser", "User")
        Validator.AddBusinessRule("ErrorCode", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseErrorCode", "ErrorCode")
        Validator.AddBusinessRule("CMCaseNo", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseCMCaseNo", "CMCaseNo")
        Validator.AddBusinessRule("iodWithTimePickerDateFrom", AddressOf CommonBusinessRules.CheckConditionalDateInterval, "UseStartDate", "iodWithTimePickerDateFrom", "iodWithTimePickerDateUntil")
        Validator.AddBusinessRule("iodWithTimePickerDateUntil", AddressOf CommonBusinessRules.CheckConditionalDateInterval, "UseStartDate", "iodWithTimePickerDateFrom", "iodWithTimePickerDateUntil")
        Validator.AddBusinessRule("Group", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseGroup", "Group")
    End Sub

    Private _useUser As Boolean

    Public Overridable Property UseUser() As Boolean
        Get
            Return _useUser
        End Get
        Set(ByVal value As Boolean)
            Assign("UseUser", value, _useUser)
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

    Private _useCMCaseNo As Boolean

    Public Overridable Property UseCMCaseNo() As Boolean
        Get
            Return _useCMCaseNo
        End Get
        Set(ByVal value As Boolean)
            Assign("UseCMCaseNo", value, _useCMCaseNo)
        End Set
    End Property

    Private _useErrorCode As Boolean

    Public Overridable Property UseErrorCode() As Boolean
        Get
            Return _useErrorCode
        End Get
        Set(ByVal value As Boolean)
            Assign("UseErrorCode", value, _useErrorCode)
        End Set
    End Property

    Private _useGroup As Boolean

    Public Overridable Property UseGroup() As Boolean
        Get
            Return _useGroup
        End Get
        Set(ByVal value As Boolean)
            Assign("UseGroup", value, _useGroup)
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

    Private _User As Entities(Of User)

    Public Overridable Property User() As Entities(Of User)
        Get
            Return _User
        End Get
        Set(ByVal value As Entities(Of User))
            Assign("User", value, _User)
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

    Private _CMCaseNo As String

    Public Overridable Property CMCaseNo() As String
        Get
            Return _CMCaseNo
        End Get
        Set(ByVal value As String)
            Assign("CMCaseNo", value, _CMCaseNo)
        End Set
    End Property

    Private _ErrorCode As String

    Public Overridable Property ErrorCode() As String
        Get
            Return _ErrorCode
        End Get
        Set(ByVal value As String)
            Assign("ErrorCode", value, _ErrorCode)
        End Set
    End Property

    Private _Group As AuditMessage

    Public Overridable Property Group() As AuditMessage
        Get
            Return _Group
        End Get
        Set(ByVal value As AuditMessage)
            Assign("Group", value, _Group)
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
        If Me.UseUser Then result.Add(Core.Dal.CriteriaBuilder.IsInCollection("User", Me._User))
        If Me.UseStartDate Then result.Add(Core.Dal.CriteriaBuilder.IntervalsOverlap("AudDate", "AudDate", DateTimeFrom, DateTimeTo))
        If Me.UseGroup Then result.Add(New Core.Dal.Expressions.Eq("AuditMessage.Parent", Me._Group))
        If Me.UseErrorCode Then result.Add(Core.Dal.CriteriaBuilder.MultiValueLike("AuditMessage.Code", Me._ErrorCode))
        'If Me.UseErrorCode Then result.Add(Core.Dal.CriteriaBuilder.MultiValueLike("AuditMessageCodeWPrefix", Me._ErrorCode))
        If Me.UseCMCaseNo Then result.Add(Core.Dal.CriteriaBuilder.MultiValueLike("CMCase.Number", Me._CMCaseNo))

        If Me.UseActive Then result.Add(New [IsNull]("DeleteTime"))
        Return result
    End Function

    Public Sub ResetValues(ByVal session As Core.Dal.ISession) Implements Core.Bll.ISearchObject.ResetValues
        Me.UseUser = False
        Me.UseStartDate = False
        Me.UseGroup = False
        Me.UseCMCaseNo = False
        Me.UseErrorCode = False
        Me.UseActive = True

        Me.User = Nothing
        Me.iodWithTimePickerDateFrom = Nothing
        Me.iodWithTimePickerDateUntil = Nothing
        Me.Group = Nothing
        Me.CMCaseNo = Nothing
        Me.ErrorCode = Nothing
    End Sub

End Class
