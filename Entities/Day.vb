''' <summary>Nodarbinātības veidi</summary>
Public Enum DayEnum

    ''' <summary>Pirmdiena</summary>
    Monday = 1
    ''' <summary>Otrdiena</summary>
    Tuesday = 2
    ''' <summary>Trešdiena</summary>
    Wednesday = 3
    ''' <summary>Ceturtdiena</summary>
    Thursday = 4
    ''' <summary>Piektdiena</summary>
    Friday = 5
    ''' <summary>Sestdiena</summary>
    Saturday = 6
    ''' <summary>Svētdiena</summary>
    Sanday = 7
End Enum


Public Class Day
    Inherits Core.EnumWrapper(Of DayEnum)

    Sub New(ByVal value As DayEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Pirmdiena</summary>
    Public Shared ReadOnly Monday As Day = New Day(DayEnum.Monday)
    ''' <summary>Otrdiena</summary>
    Public Shared ReadOnly Tuesday As Day = New Day(DayEnum.Tuesday)
    ''' <summary>Trešdiena</summary>
    Public Shared ReadOnly Wednesday As Day = New Day(DayEnum.Wednesday)
    ''' <summary>Ceturtdiena</summary>
    Public Shared ReadOnly Thursday As Day = New Day(DayEnum.Thursday)
    ''' <summary>Piektdiena</summary>
    Public Shared ReadOnly Friday As Day = New Day(DayEnum.Friday)
    ''' <summary>Sestdiena</summary>
    Public Shared ReadOnly Saturday As Day = New Day(DayEnum.Saturday)
    ''' <summary>Svētdiena</summary>
    Public Shared ReadOnly Sanday As Day = New Day(DayEnum.Sanday)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Monday)
                _listHolder.Add(Tuesday)
                _listHolder.Add(Wednesday)
                _listHolder.Add(Thursday)
                _listHolder.Add(Friday)
                _listHolder.Add(Saturday)
                _listHolder.Add(Sanday)
            End If
            Return _listHolder
        End Get
    End Property

    Public Shared Function GetDay(ByVal datums As Date) As Day
        Dim i As Integer = datums.DayOfWeek
        Select Case i
            Case 0
                Return Sanday
            Case 1
                Return Monday
            Case 2
                Return Tuesday
            Case 3
                Return Wednesday
            Case 4
                Return Thursday
            Case 5
                Return Friday
            Case 6
                Return Saturday
        End Select
    End Function

    Public Shared Function GetDate(ByVal startDay As Date, ByVal dayOfWeek As Day) As Date
        Select Case dayOfWeek
            Case Monday
                Return startDay
            Case Tuesday
                Return startDay.AddDays(1)
            Case Wednesday
                Return startDay.AddDays(2)
            Case Thursday
                Return startDay.AddDays(3)
            Case Friday
                Return startDay.AddDays(4)
            Case Saturday
                Return startDay.AddDays(5)
            Case Saturday
                Return startDay.AddDays(6)
        End Select
    End Function

End Class
