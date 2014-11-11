''' <summary>Nodarbinātības veidi</summary>
Public Enum PresentCardStateEnum

    ''' <summary>Izveidota</summary>
    Izveidota = 1
    ''' <summary>Nopirkta</summary>
    Nopirkta = 2
    ''' <summary>Daļēji izmantota</summary>
    DalejiIzmantota = 3
    ''' <summary>Pilnībā izmantota</summary>
    PilnibaIzmantota = 4
    ''' <summary>Bezmaksas</summary>
    Bezmaksas = 5
End Enum


Public Class PresentCardState
    Inherits Core.EnumWrapper(Of PresentCardStateEnum)

    Sub New(ByVal value As PresentCardStateEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>izveidota</summary>
    Public Shared ReadOnly Izveidota As PresentCardState = New PresentCardState(PresentCardStateEnum.Izveidota)
    ''' <summary>Nopirkta</summary>
    Public Shared ReadOnly Nopirkta As PresentCardState = New PresentCardState(PresentCardStateEnum.Nopirkta)
    ''' <summary>Bezmaksas</summary>
    Public Shared ReadOnly Bezmaksas As PresentCardState = New PresentCardState(PresentCardStateEnum.Bezmaksas)
    ''' <summary>Daļēji izmantota</summary>
    Public Shared ReadOnly DalejiIzmantota As PresentCardState = New PresentCardState(PresentCardStateEnum.DalejiIzmantota)
    ''' <summary>Pilnībā izmantota</summary>
    Public Shared ReadOnly PilnibaIzmantota As PresentCardState = New PresentCardState(PresentCardStateEnum.PilnibaIzmantota)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Izveidota)
                _listHolder.Add(Nopirkta)
                _listHolder.Add(Bezmaksas)
                _listHolder.Add(DalejiIzmantota)
                _listHolder.Add(PilnibaIzmantota)
            End If
            Return _listHolder
        End Get
    End Property

End Class
