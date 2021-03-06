''' <summary>DN pieprasоjumu statusu kodi</summary>
''' 
Public Enum WHRequestStatusEnum

    ''' <summary>Jauns</summary>
    Draft = 1
    ''' <summary>Izpildīts</summary>
    Ready = 2
    ''' <summary>Pieprasīts</summary>
    Sent = 3

End Enum

Public Class WHRequestStatus
    Inherits Core.EnumWrapper(Of WHRequestStatusEnum)

    Sub New(ByVal value As WHRequestStatusEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub

    ' Constant predefined values

    ''' <summary>Jauns</summary>
    Public Shared ReadOnly Draft As WHRequestStatus = New WHRequestStatus(WHRequestStatusEnum.Draft)
    ''' <summary>Izpildīts</summary>
    Public Shared ReadOnly Ready As WHRequestStatus = New WHRequestStatus(WHRequestStatusEnum.Ready)
    ''' <summary>Pieprasīts</summary>
    Public Shared ReadOnly Sent As WHRequestStatus = New WHRequestStatus(WHRequestStatusEnum.Sent)


    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Draft)
                _listHolder.Add(Ready)
            End If
            Return _listHolder
        End Get
    End Property

End Class
