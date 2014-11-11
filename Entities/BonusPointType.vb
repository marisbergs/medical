''' <summary>Dzimums</summary>
Public Enum BonusPointTypeEnum

    ''' <summary>Pievienoja</summary>
    Add = 1
    ''' <summary>Izmantoja</summary>
    Use = 2
End Enum


Public Class BonusPointType
    Inherits Core.EnumWrapper(Of BonusPointTypeEnum)

    Sub New(ByVal value As BonusPointTypeEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Pievienoja</summary>
    Public Shared ReadOnly Add As New BonusPointType(BonusPointTypeEnum.Add)
    ''' <summary>Izmantoja</summary>
    Public Shared ReadOnly Use As New BonusPointType(BonusPointTypeEnum.Use)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Add)
                _listHolder.Add(Use)
            End If
            Return _listHolder
        End Get
    End Property

End Class
