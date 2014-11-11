''' <summary>Dzimums</summary>
Public Enum SexEnum

    ''' <summary>Vīrietis</summary>
    Male = 1
    ''' <summary>Sieviete</summary>
    Female = 2
End Enum


Public Class Sex
    Inherits Core.EnumWrapper(Of SexEnum)

    Sub New(ByVal value As SexEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Vīrietis</summary>
    Public Shared ReadOnly Male As Sex = New Sex(SexEnum.Male)
    ''' <summary>Sieviete</summary>
    Public Shared ReadOnly Female As Sex = New Sex(SexEnum.Female)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Male)
                _listHolder.Add(Female)
            End If
            Return _listHolder
        End Get
    End Property

End Class
