Imports core
Imports Core.Dal
Imports Core.Bll
Imports System.IO
Imports System.Windows.Forms
Imports System

Public Class RtgSummary
    Inherits Document
    Private _rtg As IChildCollection(Of RtgSummaryRecord)

    Protected Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal session As ISession, ByVal _patient As Guid)
        MyBase.New(session)
        Rtg = New ChildCollection(Of RtgSummaryRecord)
        DocType = New DocumentType(DocumentTypeEnum.RtgSummary)
        Template = session.Get(Of Template)(Entities.Template.RtgSummary)
        Patient = session.Get(Of Patient)(_patient)
    End Sub

    ''' <summary>
    ''' izmeklējumu ieraksti
    ''' </summary>
    Public Overridable Property Rtg() As IChildCollection(Of RtgSummaryRecord)
        Get
            Return _rtg
        End Get
        Set(ByVal value As IChildCollection(Of RtgSummaryRecord))
            Assign("Rtg", value, _rtg)
        End Set
    End Property

End Class
