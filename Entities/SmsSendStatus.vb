''' <summary>Nodarbinātības veidi</summary>
Public Enum SmsSendStatusEnum

    ''' <summary>Jauns</summary>
    NotSent = 1
    ''' <summary>Nosûtīts</summary>
    Sent = 2
    ''' <summary>Kļûdains telefona numurs</summary>
    InvalidPhone = 3
End Enum


Public Class SmsSendStatus
    Inherits Core.EnumWrapper(Of SmsSendStatusEnum)

    Sub New(ByVal value As SmsSendStatusEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Jauns</summary>
    Public Shared ReadOnly NotSent As SmsSendStatus = New SmsSendStatus(SmsSendStatusEnum.NotSent)
    ''' <summary>Nosûtīts</summary>
    Public Shared ReadOnly Sent As SmsSendStatus = New SmsSendStatus(SmsSendStatusEnum.Sent)
    ''' <summary>Kļûdains telefona numurs</summary>
    Public Shared ReadOnly InvalidPhone As SmsSendStatus = New SmsSendStatus(SmsSendStatusEnum.InvalidPhone)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(NotSent)
                _listHolder.Add(Sent)
                _listHolder.Add(InvalidPhone)
            End If
            Return _listHolder
        End Get
    End Property

End Class
