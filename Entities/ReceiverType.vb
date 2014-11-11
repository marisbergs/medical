''' <summary>Piegādātāja veidi</summary>
Public Enum ReceiverTypeEnum

    ''' <summary>Kokmateriālu saņēmējs</summary>
    TimberReceiver = 1
    ''' <summary>Pakalpojumu saņēmējs</summary>
    ServiceReceiver = 2
End Enum

Public Class ReceiverType
    Inherits Core.EnumWrapper(Of ReceiverTypeEnum)

    Sub New(ByVal value As ReceiverTypeEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Kokmateriālu saņēmējs</summary>
    Public Shared ReadOnly TimberReceiver As ReceiverType = New ReceiverType(ReceiverTypeEnum.TimberReceiver)
    ''' <summary>Pakalpojumu saņēmējs</summary>
    Public Shared ReadOnly ServiceReceiver As ReceiverType = New ReceiverType(ReceiverTypeEnum.ServiceReceiver)
    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(TimberReceiver)
                _listHolder.Add(ServiceReceiver)
            End If
            Return _listHolder
        End Get
    End Property
End Class
