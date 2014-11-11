Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Core.Dal
Imports Core.Bll
Imports Core.Dal.Expressions

Public Class FindPatients
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements INotifyPropertyChanged
    Implements Core.Bll.ISearchObject

#Region "Private members"
    Private _useName As Boolean
    Private _name As String
    Private _useSurname As Boolean
    Private _surname As String
    Private _useCode As Boolean
    Private _code As String
    Private _useCreatePlace As Boolean
    Private _createPlace As String
    Private _useActive As Boolean
    Private _number As String
    Private _useNumber As Boolean
    Private _useRecomend As Boolean
    Private _useCampaigns As Boolean
    Private _campaigns As IList(Of Campaign)

    Private _useCreateDate As Boolean

    Private _timeTo As Nullable(Of Date)
    Private _dateTo As Nullable(Of Date)
    Private _timeFrom As Nullable(Of Date)
    Private _dateFrom As Nullable(Of Date)

    Private _useVisitDate As Boolean

    Private _visitTimeTo As Nullable(Of Date)
    Private _visitDateTo As Nullable(Of Date)
    Private _visitTimeFrom As Nullable(Of Date)
    Private _visitDateFrom As Nullable(Of Date)

    Private _useBirthDate As Boolean
    Private _birthDateTo As Nullable(Of Date)
    Private _birthDateFrom As Nullable(Of Date)
    Private _patientStatus As String
    Private _usePatientStatus As Boolean

    Private _useDiagnoze As Boolean
    Private _diagnoze As IList(Of Diagnoze)
    Private _sesija As Core.Dal.ISession

#End Region

    Public Sub New(ByVal session As Core.Dal.ISession)
        ResetValues(session)
        _sesija = session
        Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseName", "Name")
        Validator.AddBusinessRule("Surname", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseLastName", "LastName")
        Validator.AddBusinessRule("Code", AddressOf CommonBusinessRules.CheckConditionalRequired, "UseCode", "Code")
    End Sub

    ''' <summary>
    ''' Vārds
    ''' </summary>
    Public Overridable Property UseName() As Boolean
        Get
            UseName = _useName
        End Get
        Set(ByVal value As Boolean)
            Assign("UseName", value, _useName)
        End Set
    End Property

    ''' <summary>
    ''' Vārds
    ''' </summary>
    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            Assign("Name", value, _name)
        End Set
    End Property

    ''' <summary>
    ''' Uzvārds
    ''' </summary>
    Public Overridable Property UseSurname() As Boolean
        Get
            UseSurname = _useSurname
        End Get
        Set(ByVal value As Boolean)
            Assign("UseSurname", value, _useSurname)
        End Set
    End Property

    ''' <summary>
    ''' Uzvārds
    ''' </summary>
    Public Overridable Property Surname() As String
        Get
            Return _surname
        End Get
        Set(ByVal value As String)
            Assign("Surname", value, _surname)
        End Set
    End Property

    ''' <summary>
    ''' personas kods
    ''' </summary>
    Public Overridable Property UseCode() As Boolean
        Get
            Return _useCode
        End Get
        Set(ByVal value As Boolean)
            Assign("UseCode", value, _useCode)
        End Set
    End Property

    ''' <summary>
    ''' personas kods
    ''' </summary>
    Public Overridable Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            Assign("Code", value, _code)
        End Set
    End Property


    ''' <summary>
    ''' Vārds
    ''' </summary>
    Public Overridable Property UsePatientStatus() As Boolean
        Get
            Return _usePatientStatus
        End Get
        Set(ByVal value As Boolean)
            Assign("UsePatientStatus", value, _usePatientStatus)
        End Set
    End Property

    ''' <summary>
    ''' Vārds
    ''' </summary>
    Public Overridable Property PatientStatus() As String
        Get
            Return _patientStatus
        End Get
        Set(ByVal value As String)
            Assign("PatientStatus", value, _patientStatus)
        End Set
    End Property

    ''' <summary>
    ''' izveides vieta
    ''' </summary>
    Public Overridable Property UseCreatePlace() As Boolean
        Get
            Return _useCreatePlace
        End Get
        Set(ByVal value As Boolean)
            Assign("UseCreatePlace", value, _useCreatePlace)
        End Set
    End Property

    ''' <summary>
    ''' izveides vieta
    ''' </summary>
    Public Overridable Property CreatePlace() As String
        Get
            Return _createPlace
        End Get
        Set(ByVal value As String)
            Assign("CreatePlace", value, _createPlace)
        End Set
    End Property

    ''' <summary>
    ''' klienta numurs
    ''' </summary>
    Public Overridable Property UseNumber() As Boolean
        Get
            Return _useNumber
        End Get
        Set(ByVal value As Boolean)
            Assign("UseNumber", value, _useNumber)
        End Set
    End Property

    ''' <summary>
    ''' klienta numurs
    ''' </summary>
    Public Overridable Property Number() As String
        Get
            Return _number
        End Get
        Set(ByVal value As String)
            Assign("Number", value, _number)
        End Set
    End Property

    ''' <summary>
    ''' Izmantot akciju kā atlases kritēriju
    ''' </summary>
    Public Overridable Property UseCampaigns() As Boolean
        Get
            Return _useCampaigns
        End Get
        Set(ByVal value As Boolean)
            Assign("UseCampaigns", value, _useCampaigns)
        End Set
    End Property

    ''' <summary>
    ''' Akciju saraksts kā atlases kritēriji
    ''' </summary>
    Public Overridable Property Campaigns() As IList(Of Campaign)
        Get
            Return _campaigns
        End Get
        Set(ByVal value As IList(Of Campaign))
            Assign("Campaigns", value, _campaigns)
        End Set
    End Property




    ''' <summary>
    ''' Izmantot diagnozi kā atlases kritēriju
    ''' </summary>
    Public Overridable Property UseDiagnoze() As Boolean
        Get
            Return _useDiagnoze
        End Get
        Set(ByVal value As Boolean)
            Assign("UseDiagnoze", value, _useDiagnoze)
        End Set
    End Property

    ''' <summary>
    ''' Diagnožu saraksts kā atlases kritēriji
    ''' </summary>
    Public Overridable Property Diagnoze() As IList(Of Diagnoze)
        Get
            Return _diagnoze
        End Get
        Set(ByVal value As IList(Of Diagnoze))
            Assign("Diagnoze", value, _diagnoze)
        End Set
    End Property


    ''' <summary>
    ''' Ieteica cita persona
    ''' </summary>
    Public Overridable Property UseRecomend() As Boolean
        Get
            Return _useRecomend
        End Get
        Set(ByVal value As Boolean)
            Assign("UseRecomend", value, _useRecomend)
        End Set
    End Property

    Public Overridable Property UseActive() As Boolean
        Get
            Return _useActive
        End Get
        Set(ByVal value As Boolean)
            Me.Assign("UseActive", value, _useActive)
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


    Public Overridable Property UseBirthDate() As Boolean
        Get
            Return _useBirthDate
        End Get
        Set(ByVal value As Boolean)
            Assign("UseBirthDate", value, _useBirthDate)
        End Set
    End Property

    Public Overridable Property iodPickerFrom() As Nullable(Of Date)
        Get
            Return _birthDateFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("iodPickerFrom", value, _birthDateFrom)
        End Set
    End Property

    Public Overridable Property iodPickerUntil() As Nullable(Of Date)
        Get
            Return _birthDateTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("iodPickerUntil", value, _birthDateTo)
        End Set
    End Property


    Public Overridable Property UseVisitDate() As Boolean
        Get
            Return _useVisitDate
        End Get
        Set(ByVal value As Boolean)
            Assign("UseVisitDate", value, _useVisitDate)
        End Set
    End Property

    Public Overridable Property VisitDateDateFrom() As Nullable(Of Date)
        Get
            Return _visitDateFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("VisitDateDateFrom", value, _visitDateFrom)
            Assign("VisitDateTimeFrom", value, _visitTimeFrom)
            If Not _visitDateTo.HasValue AndAlso _visitDateFrom.HasValue Then
                VisitDateDateUntil = _visitDateFrom.Value.AddDays(1)
            End If
            If _visitDateTo.HasValue AndAlso _visitDateFrom.HasValue AndAlso _visitDateTo.Value <= _visitDateFrom.Value Then
                VisitDateDateUntil = _visitDateFrom.Value.AddDays(1)
            End If
        End Set
    End Property

    Public Overridable Property VisitDateTimeFrom() As Nullable(Of Date)
        Get
            Return _visitTimeFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("VisitDateTimeFrom", value, _visitTimeFrom)
        End Set
    End Property

    Public Overridable Property VisitDateDateUntil() As Nullable(Of Date)
        Get
            Return _visitDateTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("VisitDateDateUntil", value, _visitDateTo)
            Assign("VisitDateTimeUntil", value, _visitTimeTo)
        End Set
    End Property

    Public Overridable Property VisitDateTimeUntil() As Nullable(Of Date)
        Get
            Return _visitTimeTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("VisitDateTimeUntil", value, _visitTimeTo)
        End Set
    End Property

    Public Overridable ReadOnly Property VisitDateTimeFroms() As Nullable(Of DateTime)
        Get
            If _visitDateFrom.HasValue And _visitTimeFrom.HasValue Then
                Return DateAdd(DateInterval.Hour, Me._visitTimeFrom.Value.Hour, DateAdd(DateInterval.Minute, Me._visitTimeFrom.Value.Minute, Me._visitDateFrom.Value))
            ElseIf _dateFrom.HasValue Then
                Return _dateFrom
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property VisitDateTimeTos() As Nullable(Of DateTime)
        Get
            If _visitDateTo.HasValue And _visitTimeTo.HasValue Then
                Return DateAdd(DateInterval.Hour, Me._visitTimeTo.Value.Hour, DateAdd(DateInterval.Minute, Me._visitTimeTo.Value.Minute, Me._visitDateTo.Value))
            ElseIf _visitDateFrom.HasValue Then
                Return _visitDateTo
            End If
        End Get
    End Property


#Region "ISearchObject"
    Public Function BuildCriteria() As IList(Of Core.Dal.Expressions.CriterionBase) Implements Core.Bll.ISearchObject.BuildCriteria
        Dim result As New List(Of CriterionBase)

        If Me.UseName Then result.Add(CriteriaBuilder.MultiValueLike("Name", Me._name & "%"))

        If Me.UseSurname Then result.Add(CriteriaBuilder.MultiValueLike("Surname", Me._surname & "%"))
        If Me.UsePatientStatus Then result.Add(CriteriaBuilder.MultiValueLike("PatientStatus", Me._patientStatus & "%"))

        If Me.UseCode Then result.Add(CriteriaBuilder.MultiValueLike("Code", Me._code))
        If Me.UseCreatePlace Then result.Add(CriteriaBuilder.MultiValueLike("CreatePlace", Me._createPlace))
        If Me.UseNumber Then result.Add(CriteriaBuilder.MultiValueLike("Number", Me._number))
        If Me.UseRecomend Then result.Add(New Expressions.Eq("Recomend", True))
        If UseCampaigns Then
            result.Add(CriteriaBuilder.IsInCollection("Campaigans.Campaign", _campaigns))
            result.Add(New Expressions.IsNull("Campaigans.DeleteTime"))
        End If
        If UseDiagnoze AndAlso Diagnoze.Count > 0 Then
            'sameklējam visus chaildus hierarhiskajam klasifikatora ierakstam
            Dim sar As New List(Of HierClassifier)
            For Each diagnoz As Diagnoze In Diagnoze
                sar.Add(diagnoz)
                diagnoz.GetChildrens(diagnoz, sar, _sesija)
            Next
            result.Add(CriteriaBuilder.IsInCollection("Diagnoze", sar))
            result.Add(New Expressions.IsNull("Diagnoze.DeleteTime"))
        End If

        If Me.UseActive Then result.Add(New Expressions.IsNull("DeleteTime"))
        If Me.UseVisitDate Then
            result.Add(CriteriaBuilder.IntervalsOverlap("Visits.StartTime", "Visits.StartTime", VisitDateTimeFroms, VisitDateTimeTos))
            result.Add(New Expressions.Eq("Visits.VisitServices.ServiceGiven", True))
        End If
        If Me.UseCreateDate Then result.Add(CriteriaBuilder.IntervalsOverlap("CreateDate", "CreateDate", _dateFrom, _dateTo))
        If Me.UseBirthDate Then result.Add(CriteriaBuilder.IntervalsOverlap("BirthDate", "BirthDate", iodPickerFrom, iodPickerUntil))

        Return result
    End Function

    Public Sub ResetValues(ByVal session As Core.Dal.ISession) Implements Core.Bll.ISearchObject.ResetValues
        Me.UseName = False
        Me.UseSurname = False
        Me.UseCode = False
        Me.UseActive = True
        Me.UsePatientStatus = False
        Me.PatientStatus = "J | A | V | B"
    End Sub
#End Region

End Class
