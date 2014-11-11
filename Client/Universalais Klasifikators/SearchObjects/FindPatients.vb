Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Collections
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
    Private _useActive As Boolean
    Private _number As String
    Private _useNumber As Boolean
#End Region

    Public Sub New(ByVal session As Core.Dal.ISession)
        ResetValues(session)
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

    Public Overridable Property UseActive() As Boolean
        Get
            Return _useActive
        End Get
        Set(ByVal value As Boolean)
            Me.Assign("UseActive", value, _useActive)
        End Set
    End Property

#Region "ISearchObject"
    Public Function BuildCriteria() As IList(Of Core.Dal.Expressions.CriterionBase) Implements Core.Bll.ISearchObject.BuildCriteria
        Dim result As New List(Of CriterionBase)

        If Me.UseName Then result.Add(CriteriaBuilder.MultiValueLike("Name", Me._name & "%"))

        If Me.UseSurname Then result.Add(CriteriaBuilder.MultiValueLike("Surname", Me._surname & "%"))

        If Me.UseCode Then result.Add(CriteriaBuilder.MultiValueLike("Code", Me._code))
        If Me.UseNumber Then result.Add(CriteriaBuilder.MultiValueLike("Number", Me._number))

        If Me.UseActive Then result.Add(New Expressions.IsNull("DeleteTime"))

        Return result
    End Function

    Public Sub ResetValues(ByVal session As Core.Dal.ISession) Implements Core.Bll.ISearchObject.ResetValues
        Me.UseName = False
        Me.UseSurname = False
        Me.UseCode = False
        Me.UseActive = True
    End Sub
#End Region

End Class
