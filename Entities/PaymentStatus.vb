''' <summary>Apmaksas statusi</summary>
Public Enum PaymentStatusEnum

    ''' <summary>Apmaksa nav veikta</summary>
    NotPayd = 1
    ''' <summary>Apmaksāts daļēji</summary>
    PaydPart = 2
    ''' <summary>Apmaksāts pilnībā</summary>
    PaydAll = 3
End Enum


Public Class PaymentStatus
    Inherits Core.EnumWrapper(Of PaymentStatusEnum)

    Sub New(ByVal value As PaymentStatusEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Apmaksa nav veikta</summary>
    Public Shared ReadOnly NotPayd As PaymentStatus = New PaymentStatus(PaymentStatusEnum.NotPayd)
    ''' <summary>Apmaksāts daļēji</summary>
    Public Shared ReadOnly PaydPart As PaymentStatus = New PaymentStatus(PaymentStatusEnum.PaydPart)
    ''' <summary>Apmaksāts pilnībā</summary>
    Public Shared ReadOnly PaydAll As PaymentStatus = New PaymentStatus(PaymentStatusEnum.PaydAll)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(NotPayd)
                _listHolder.Add(PaydPart)
                _listHolder.Add(PaydAll)
            End If
            Return _listHolder
        End Get
    End Property

End Class
