Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class SMSMessages
    Inherits BusinessObjectBase(Of Guid)

#Region "Private members"
    Private _meesageText As String
    Private _daysBefore As Integer
    Private _sendTime As DateTime
    Private _type As SMSType
#End Region

    Public Sub New()
        MyBase.new()
        AddBusinessRules()
    End Sub

    Private Sub AddBusinessRules()
        Validator.AddBusinessRule("MeesageText", AddressOf CommonBusinessRules.CheckRequired, "MeesageText")
    End Sub

    ''' <summary>
    ''' paziņojuma teksts
    ''' </summary>
    Public Overridable Property MeesageText() As String
        Get
            Return _meesageText
        End Get
        Set(ByVal value As String)
            Assign("MeesageText", value, _meesageText)
        End Set
    End Property

    ''' <summary>
    ''' cik dienas iepriekš
    ''' </summary>
    Public Overridable Property DaysBefore() As Integer
        Get
            Return _daysBefore
        End Get
        Set(ByVal value As Integer)
            Assign("DaysBefore", value, _daysBefore)
        End Set
    End Property

    ''' <summary>
    ''' sûtīšanas laiks
    ''' </summary>
    Public Overridable Property SendTime() As DateTime
        Get
            Return _sendTime
        End Get
        Set(ByVal value As DateTime)
            Assign("SendTime", value, _sendTime)
        End Set
    End Property

    ''' <summary>
    ''' sûtīšanas laiks
    ''' </summary>
    Public Overridable Property Type() As SMSType
        Get
            Return _type
        End Get
        Set(ByVal value As SMSType)
            Assign("Type", value, _type)
        End Set
    End Property
End Class
