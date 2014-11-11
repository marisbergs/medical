Imports core
Imports Core.Dal
Imports Core.Bll
Imports System.IO
Imports System.Windows.Forms
Imports System

Public Class RtgSummaryRecord
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements IHasParent

    Private _rtgSummary As RtgSummary
    Private _rtgType As RtgType
    Private _rtgCreateDate As Nullable(Of Date)
    Private _rtgDescription As String
    Private _rtgSummaryText As String

    Protected Sub New()
        MyBase.New()
        AddBusinessRules()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        AddBusinessRules()
    End Sub

    Private Sub AddBusinessRules()
        'validation
        Validator.AddBusinessRule("RtgType", AddressOf CommonBusinessRules.CheckRequired, "RtgType")
        Validator.AddBusinessRule("RtgCreateDate", AddressOf CommonBusinessRules.CheckRequired, "RtgCreateDate")
        Validator.AddBusinessRule("RtgDescription", AddressOf CommonBusinessRules.CheckRequired, "RtgDescription")
    End Sub

    Public Overridable Property RtgSummary() As RtgSummary
        Get
            Return _rtgSummary
        End Get
        Set(ByVal value As RtgSummary)
            Assign("RtgSummary", value, _rtgSummary)
        End Set
    End Property
    ''' <summary>
    ''' Parents
    ''' </summary>
    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return RtgSummary
        End Get
        Set(ByVal value As Object)
            Me.RtgSummary = CType(value, RtgSummary)
        End Set
    End Property

    Public Overridable Property RtgType() As RtgType
        Get
            Return _rtgType
        End Get
        Set(ByVal value As RtgType)
            Assign("RtgType", value, _rtgType)
        End Set
    End Property

    Public Overridable Property RtgCreateDate() As Nullable(Of Date)
        Get
            Return _rtgCreateDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("RtgCreateDate", value, _rtgCreateDate)
        End Set
    End Property

    Public Overridable Property RtgDescription() As String
        Get
            Return _rtgDescription
        End Get
        Set(ByVal value As String)
            Assign("RtgDescription", value, _rtgDescription)
        End Set
    End Property

    Public Overridable Property RtgSummaryText() As String
        Get
            Return _rtgSummaryText
        End Get
        Set(ByVal value As String)
            Assign("RtgSummaryText", value, _rtgSummaryText)
        End Set
    End Property
End Class
