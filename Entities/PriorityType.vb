''' <summary>Prioritāte</summary>
Public Enum PriorityTypeEnum
    ''' <summary>Parasta</summary>
    Low = 1
    ''' <summary>Steidzama</summary>
    High = 2
End Enum

''' <summary>Prioritāte</summary>
Public Class PriorityType
    Inherits Core.EnumWrapper(Of PriorityTypeEnum)

    Sub New(ByVal value As PriorityTypeEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub

    ' Constant predefined values

    ''' <summary>Parasta</summary>
    Public Shared ReadOnly Low As PriorityType = New PriorityType(PriorityTypeEnum.Low)
    ''' <summary>Steidzama</summary>
    Public Shared ReadOnly High As PriorityType = New PriorityType(PriorityTypeEnum.High)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Low)
                _listHolder.Add(High)
            End If
            Return _listHolder
        End Get
    End Property

End Class
