''' <summary>Nodarbinātības veidi</summary>
Public Enum CycleEnum

    ''' <summary>Regulārs</summary>
    Regular = 1
    ''' <summary>Neregulārs</summary>
    Irregular = 2
End Enum


Public Class Cycle
    Inherits Core.EnumWrapper(Of CycleEnum)

    Sub New(ByVal value As CycleEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Strādā</summary>
    Public Shared ReadOnly Regular As Cycle = New Cycle(CycleEnum.Regular)
    ''' <summary>Students</summary>
    Public Shared ReadOnly Irregular As Cycle = New Cycle(CycleEnum.Irregular)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Regular)
                _listHolder.Add(Irregular)
            End If
            Return _listHolder
        End Get
    End Property

End Class
