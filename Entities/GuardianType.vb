''' <summary>Nodarbinātības veidi</summary>
Public Enum GuardianTypeEnum

    ''' <summary>Māte</summary>
    Mother = 1
    ''' <summary>Tēvs</summary>
    Father = 2
    ''' <summary>Aizbildnis</summary>
    Guardian = 3
End Enum


Public Class GuardianType
    Inherits Core.EnumWrapper(Of GuardianTypeEnum)

    Sub New(ByVal value As GuardianTypeEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Māte</summary>
    Public Shared ReadOnly Mother As GuardianType = New GuardianType(GuardianTypeEnum.Mother)
    ''' <summary>Tēvs</summary>
    Public Shared ReadOnly Father As GuardianType = New GuardianType(GuardianTypeEnum.Father)
    ''' <summary>Aizbildnis</summary>
    Public Shared ReadOnly Guardian As GuardianType = New GuardianType(GuardianTypeEnum.Guardian)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Mother)
                _listHolder.Add(Father)
                _listHolder.Add(Guardian)
            End If
            Return _listHolder
        End Get
    End Property

End Class
