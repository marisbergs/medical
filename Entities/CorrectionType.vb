''' <summary>Darījuma partnera veidi</summary>
Public Enum CorrectionTypeEnum

    ''' <summary>Labots->NM</summary>
    Copy = 1
    ''' <summary>Labots->DNS</summary>
    Edited = 2
    ''' <summary>Labots->NM, Labots->DNS</summary>
    Boath = 3
End Enum


Public Class CorrectionType
    Inherits Core.EnumWrapper(Of CorrectionTypeEnum)

    Sub New(ByVal value As CorrectionTypeEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Labots->NM</summary>
    Public Shared ReadOnly Copy As CorrectionType = New CorrectionType(CorrectionTypeEnum.Copy)
    ''' <summary>Labots->DNS</summary>
    Public Shared ReadOnly Edited As CorrectionType = New CorrectionType(CorrectionTypeEnum.Edited)
    ''' <summary>Labots->NM, Labots->DNS</summary>
    Public Shared ReadOnly Boath As CorrectionType = New CorrectionType(CorrectionTypeEnum.Boath)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Copy)
                _listHolder.Add(Edited)
                _listHolder.Add(Boath)
            End If
            Return _listHolder
        End Get
    End Property

End Class
