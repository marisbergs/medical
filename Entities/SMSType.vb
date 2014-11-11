
''' <summary>Nodarbinātības veidi</summary>
Public Enum SMSTypeEnum

    ''' <summary>Pirms noteiktā laika</summary>
    Before = 1
    ''' <summary>Pēc noteiktā laika</summary>
    After = 2
    ''' <summary>Grupu nodarbības</summary>
    GroupWork = 3
    ''' <summary>Vizītes rezervācija</summary>
    Reservation = 4
    ''' <summary>Paziņojums par iekļaušanu melnajā sarakstā</summary>
    BlackList = 5
    ''' <summary>Paziņojums par piešķirtiem bonusa punktiem</summary>
    BonusPointsAdded = 6
    ''' <summary>Dzimšanas dienas apsveikums</summary>
    BirthDay = 7
End Enum

Public Class SMSType
    Inherits Core.EnumWrapper(Of SMSTypeEnum)

    Sub New(ByVal value As SMSTypeEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub

    ''' <summary>Pirms noteiktā laika</summary>
    Public Shared ReadOnly Before As SMSType = New SMSType(SMSTypeEnum.Before)
    ''' <summary>Pēc noteiktā laika</summary>
    Public Shared ReadOnly After As SMSType = New SMSType(SMSTypeEnum.After)
    ''' <summary>Pēc noteiktā laika</summary>
    Public Shared ReadOnly GroupWork As SMSType = New SMSType(SMSTypeEnum.GroupWork)
    ''' <summary>Pēc noteiktā laika</summary>
    Public Shared ReadOnly Reservation As SMSType = New SMSType(SMSTypeEnum.Reservation)
    ''' <summary>Paziņojums par iekļaušanu melnajā sarakstā</summary>
    Public Shared ReadOnly BlackList As SMSType = New SMSType(SMSTypeEnum.BlackList)
    ''' <summary>Paziņojums par piešķirtiem bonusa punktiem</summary>
    Public Shared ReadOnly BonusPointsAdded As SMSType = New SMSType(SMSTypeEnum.BonusPointsAdded)
    ''' <summary>Dzimšanas dienas apsveikums</summary>
    Public Shared ReadOnly BirthDay As SMSType = New SMSType(SMSTypeEnum.BirthDay)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Before)
                _listHolder.Add(After)
                _listHolder.Add(GroupWork)
                _listHolder.Add(Reservation)
                _listHolder.Add(BlackList)
                _listHolder.Add(BonusPointsAdded)
                _listHolder.Add(BirthDay)
            End If
            Return _listHolder
        End Get
    End Property
End Class
