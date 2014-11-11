Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Core.Dal
Imports Core.Bll
Imports Core.Dal.Expressions

Public Class FindPatientsAdvanced
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements INotifyPropertyChanged
    Implements Core.Bll.ISearchObject

#Region "Private members"
    Private _useSex As Boolean
    Private _sex As Sex
    Private _useNewClient As Boolean
    Private _newClient As YesNo
    Private _usePaydPriceGroup As Boolean
    Private _paydPriceGroup As String
    Private _useLastVisitGroup As Boolean
    Private _lastVisitGroup As String
    Private _useCheckUp As Boolean
    Private _checkUp As IList(Of Services)
    Private _useGinekologs As Boolean
    Private _ginekologs As IList(Of Services)
    Private _useUrolog As Boolean
    Private _urolog As IList(Of Services)
    Private _usePediatr As Boolean
    Private _pediatr As IList(Of Services)
    Private _useSkaistumkopsana As Boolean
    Private _skaistumkopsana As IList(Of Services)
    Private _useLanguage As Boolean
    Private _language As IList(Of Language)
#End Region

    Public Sub New(ByVal session As Core.Dal.ISession)
        ResetValues(session)
    End Sub

    ''' <summary>
    ''' Dzimums
    ''' </summary>
    Public Overridable Property UseSex() As Boolean
        Get
            Return _useSex
        End Get
        Set(ByVal value As Boolean)
            Assign("UseSex", value, _useSex)
        End Set
    End Property

    ''' <summary>
    ''' dzimums
    ''' </summary>
    Public Overridable Property Sex() As Sex
        Get
            Return _sex
        End Get
        Set(ByVal value As Sex)
            Assign("Sex", value, _sex)
        End Set
    End Property

    ''' <summary>
    ''' Dzimums
    ''' </summary>
    Public Overridable Property UseNewClient() As Boolean
        Get
            Return _useNewClient
        End Get
        Set(ByVal value As Boolean)
            Assign("UseNewClient", value, _useNewClient)
        End Set
    End Property

    ''' <summary>
    ''' dzimums
    ''' </summary>
    Public Overridable Property NewClient() As YesNo
        Get
            Return _newClient
        End Get
        Set(ByVal value As YesNo)
            Assign("NewClient", value, _newClient)
        End Set
    End Property


#Region "ISearchObject"
    Public Function BuildCriteria() As IList(Of Core.Dal.Expressions.CriterionBase) Implements Core.Bll.ISearchObject.BuildCriteria
        Dim result As New List(Of CriterionBase)

        If UseSex Then
            result.Add(New Expressions.Eq("Sex", Sex))
        End If
        'If Me.UseName Then result.Add(CriteriaBuilder.MultiValueLike("Name", Me._name & "%"))

        'If Me.UseSurname Then result.Add(CriteriaBuilder.MultiValueLike("Surname", Me._surname & "%"))
        'If Me.UsePatientStatus Then result.Add(CriteriaBuilder.MultiValueLike("PatientStatus", Me._patientStatus & "%"))

        'If Me.UseCode Then result.Add(CriteriaBuilder.MultiValueLike("Code", Me._code))
        'If Me.UseCreatePlace Then result.Add(CriteriaBuilder.MultiValueLike("CreatePlace", Me._createPlace))
        'If Me.UseNumber Then result.Add(CriteriaBuilder.MultiValueLike("Number", Me._number))
        'If Me.UseRecomend Then result.Add(New Expressions.Eq("Recomend", True))

        'If Me.UseActive Then result.Add(New Expressions.IsNull("DeleteTime"))
        'If Me.UseCreateDate Then result.Add(CriteriaBuilder.IntervalsOverlap("CreateDate", "CreateDate", _dateFrom, _dateTo))
        'If Me.UseBirthDate Then result.Add(CriteriaBuilder.IntervalsOverlap("BirthDate", "BirthDate", iodPickerFrom, iodPickerUntil))

        Return result
    End Function

    Public Sub ResetValues(ByVal session As Core.Dal.ISession) Implements Core.Bll.ISearchObject.ResetValues
        'Me.UseName = False
        'Me.UseSurname = False
        'Me.UseCode = False
        'Me.UseActive = True
        'Me.UsePatientStatus = False
        'Me.PatientStatus = "J | A | V | B"
    End Sub
#End Region

End Class
