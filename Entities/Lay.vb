''' <summary>Nodarbinātības veidi</summary>
Public Enum LayEnum

    ''' <summary>Viens</summary>
    One = 1
    ''' <summary>Vairāki</summary>
    Many = 2
End Enum


Public Class Lay
    Inherits Core.EnumWrapper(Of LayEnum)

    Sub New(ByVal value As LayEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Viens</summary>
    Public Shared ReadOnly One As Lay = New Lay(LayEnum.One)
    ''' <summary>Vairāki</summary>
    Public Shared ReadOnly Many As Lay = New Lay(LayEnum.Many)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(One)
                _listHolder.Add(Many)
            End If
            Return _listHolder
        End Get
    End Property

End Class
