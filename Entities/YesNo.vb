''' <summary>Radiopogas vērtības</summary>
Public Enum YesNoEnum

    ''' <summary>Ir</summary>
    No = 0
    ''' <summary>Nav</summary>
    Yes = 1
    ''' <summary>Nevar konstatēt</summary>
    Ne = 2
    ''' <summary>Nav nepieciešams</summary>
    Ja = 3
    ''' <summary>Nevar uzrādīt</summary>
    NotPresent = 4
    ''' <summary>Nav nosûtīta</summary>
    NotSent = 5
    ''' <summary>Nav veikta</summary>
    NotExecuted = 6
    ''' <summary>Nevar veikt</summary>
    CantExecute = 7
    ''' <summary>Atrodas/ir veikts</summary>
    IsLocatedIsExecuted = 8
    ''' <summary>Neatrodas/nav veikts</summary>
    NotLocatedNotExecuted = 9
    ''' <summary>Neiepērk</summary>
    NotPurchase = 10
    ''' <summary>Neattiecas</summary>
    NotRefer = 11
    ''' <summary>Novirze lielāka</summary>
    ALossGreaterFLoss = 12
    ''' <summary>Novirze mazāka</summary>
    ALossLessFLoss = 13
    ''' <summary>Daļēji</summary>
    Partially = 14
    ''' <summary>Izlases kartība</summary>
    Loto = 15
    ''' <summary>Nē - iznomāts</summary>
    NoLease = 16
    ''' <summary>Nē - citādi atsavināts</summary>
    NoOtherForfeit = 17
    ''' <summary>Nē - nav uzstādīts</summary>
    NoNotAdjust = 18
    ''' <summary>Vīrietis</summary>
    Male = 19
    ''' <summary>Sieviete</summary>
    Female = 20
    ''' <summary>DpGreaterOrEquaD</summary>
    DpGreaterOrEqualD = 21
    ''' <summary>DpLessD</summary>
    DpLessD = 22
    '''<summary>Nevar uzrādīt pavaddokumentu</summary>
    NotDocument = 23
End Enum


Public Class YesNo
    Inherits Core.EnumWrapper(Of YesNoEnum)

    Sub New(ByVal value As YesNoEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Nē</summary>
    Public Shared ReadOnly No As YesNo = New YesNo(YesNoEnum.No)
    ''' <summary>Jā</summary>
    Public Shared ReadOnly Yes As YesNo = New YesNo(YesNoEnum.Yes)
    ''' <summary>Nevar konstatēt</summary>
    Public Shared ReadOnly Ne As YesNo = New YesNo(YesNoEnum.Ne)
    ''' <summary>Nav nepieciešams</summary>
    Public Shared ReadOnly Ja As YesNo = New YesNo(YesNoEnum.Ja)
    ''' <summary>Vīrietis</summary>
    Public Shared ReadOnly Male As YesNo = New YesNo(YesNoEnum.Male)
    ''' <summary>Sieviete</summary>
    Public Shared ReadOnly Female As YesNo = New YesNo(YesNoEnum.Female)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Yes)
                _listHolder.Add(No)
            End If
            Return _listHolder
        End Get
    End Property


End Class
