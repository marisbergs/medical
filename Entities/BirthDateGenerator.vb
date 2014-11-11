Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class BirthDateGenerator
    Inherits BusinessObjectBase(Of Guid)

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        AddBusinessRoles()
    End Sub
    Public Sub New()
    End Sub

    Private Sub AddBusinessRoles()

    End Sub

#Region "Private members"
    Private _datums As DateTime
    Private _generated As Boolean
#End Region

#Region "Public member"

    Public Overridable Property Datums() As DateTime
        Get
            Return _datums
        End Get
        Set(ByVal value As DateTime)
            Assign("Datums", value, _datums)
        End Set
    End Property

    Public Overridable Property Generated() As Boolean
        Get
            Return _generated
        End Get
        Set(ByVal value As Boolean)
            Assign("Generated", value, _generated)
        End Set
    End Property

    Public Overridable Function NeedGenerate(ByVal Session As ISession) As KeyValuePair(Of Boolean, SMSMessages)
        ''atrodam vai ir īsziņas teksts ko sûtīt
        Dim list As Entities(Of SMSMessages) = Entities(Of SMSMessages).GetAll(Session, New Expressions.Eq("Type", SMSType.BirthDay))
        ''ja neatrodam nevienu ierakstu tad ģenerēšanu atceļam
        If list.Count = 0 Then
            Return New KeyValuePair(Of Boolean, SMSMessages)(False, New SMSMessages)
        Else
            ''ja atrodam tekstu ko sûtīt
            Dim sms As SMSMessages = list(0)
            Dim datumsT As DateTime
            ''atrodam cikos ir jāsûta apsveikumi
            If sms.DaysBefore = 0 Then
                datumsT = Now.Date.AddHours(sms.SendTime.Hour).AddMinutes(sms.SendTime.Minute)
            End If
            ''ja sûtīšanas laiks ir pienācis apstiprinam sûtīšaunu
            ''ja nē atceļam
            ''ja divu stundu laikā nav izdevies nosûtīt tad arī atceļam.
            If Now > datumsT AndAlso Now < datumsT.AddHours(2) Then
                Return New KeyValuePair(Of Boolean, SMSMessages)(True, sms)
            Else
                Return New KeyValuePair(Of Boolean, SMSMessages)(False, New SMSMessages)
            End If
        End If
    End Function

    Public Overridable Function generateSms(ByVal session As ISession, ByVal sms As SMSMessages) As Entities(Of Patient)
        Dim res As New Entities(Of Patient)
        Dim lst As Entities(Of Patient) = Entities(Of Patient).GetAll(session, New Expressions.IsNull("DeleteTime"), New Expressions.Eq("BirthdateGreetingsSend", (Now.Year - 1)))
        For Each patient1 As Patient In lst
            If patient1.BirthDate.HasValue AndAlso patient1.BirthDate.Value.Month = Now.Month AndAlso patient1.BirthDate.Value.Day = Now.Day Then
                res.Add(patient1)
            End If
        Next
        Return res
    End Function

#End Region

End Class
