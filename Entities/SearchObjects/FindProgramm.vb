Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Collections
Imports Core.Dal
Imports Core.Bll
Imports Core.Dal.Expressions

Public Class FindProgramm
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements INotifyPropertyChanged
    Implements Core.Bll.ISearchObject

#Region "Private members"
    Private _useProgrammTemplate As Boolean
    Private _programmTemplate As IList(Of ProgrammTemplate)
    Private _usePatient As Boolean
    Private _patient As IList(Of Patient)
    Private _useActive As Boolean

#End Region

    Public Sub New(ByVal session As Core.Dal.ISession)
        ResetValues(session)
    End Sub


    ''' <summary>
    ''' vai izmantot pakalpojumu kā atlases kritēriju
    ''' </summary>
    Public Overridable Property UseProgrammTemplate() As Boolean
        Get
            Return _useProgrammTemplate
        End Get
        Set(ByVal value As Boolean)
            Assign("UseProgrammTemplate", value, _useProgrammTemplate)
        End Set
    End Property

    ''' <summary>
    ''' atlasē iekļautie pakalpojumi
    ''' </summary>
    Public Overridable Property ProgrammTemplate() As IList(Of ProgrammTemplate)
        Get
            Return _programmTemplate
        End Get
        Set(ByVal value As IList(Of ProgrammTemplate))
            Assign("ProgrammTemplate", value, _programmTemplate)
        End Set
    End Property


    ''' <summary>
    ''' vai izmantot klintu kā atlases kritēriju
    ''' </summary>
    Public Overridable Property UsePatient() As Boolean
        Get
            Return _usePatient
        End Get
        Set(ByVal value As Boolean)
            Assign("UsePatient", value, _usePatient)
        End Set
    End Property

    ''' <summary>
    ''' atlasē iekļautie klienti
    ''' </summary>
    Public Overridable Property Patient() As IList(Of Patient)
        Get
            Return _patient
        End Get
        Set(ByVal value As IList(Of Patient))
            Assign("Patient", value, _patient)
        End Set
    End Property

    ''' <summary>
    ''' vai atlasīt tikai aktīvos abonementus(tie kuri nav dzēsti
    ''' </summary>
    Public Overridable Property UseActive() As Boolean
        Get
            Return _useActive
        End Get
        Set(ByVal value As Boolean)
            Assign("UseActive", value, _useActive)
        End Set
    End Property



#Region "ISearchObject"
    Public Function BuildCriteria() As IList(Of Core.Dal.Expressions.CriterionBase) Implements Core.Bll.ISearchObject.BuildCriteria
        Dim result As New List(Of CriterionBase)

        ' TODO: nestrādā atlase pēc VID sr.v. un amata
        'todo: tiešām nestrādā atlase pēc VID srv
        'If Me.UseOrganization Then result.Add(CriteriaBuilder.IsInCollection("Organization", Me._organization))

        If UseProgrammTemplate Then result.Add(CriteriaBuilder.IsInCollection("ProgrammTemplate", ProgrammTemplate))
        If UsePatient Then result.Add(CriteriaBuilder.IsInCollection("Patient", Patient))

        If Me.UseActive Then result.Add(New [IsNull]("DeleteTime"))
        Return result
    End Function

    Public Sub ResetValues(ByVal session As Core.Dal.ISession) Implements Core.Bll.ISearchObject.ResetValues
        Me.UseActive = True
        Me.ProgrammTemplate = Nothing
        Me.Patient = Nothing
        UseProgrammTemplate = False
        UsePatient = False
    End Sub
#End Region

End Class
