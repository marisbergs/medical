''' <summary>Izlietojuma statusi</summary>
Public Enum UsageStatusEnum

    ''' <summary>Jauns</summary>
    Created = 1
    ''' <summary>Uzsākts izmantot</summary>
    StartUsed = 2
    ''' <summary>Izmantots pilnībā</summary>
    Used = 3
End Enum


Public Class UsageStatus
    Inherits Core.EnumWrapper(Of UsageStatusEnum)

    Sub New(ByVal value As UsageStatusEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Jauns</summary>
    Public Shared ReadOnly Created As UsageStatus = New UsageStatus(UsageStatusEnum.Created)
    ''' <summary>Uzsākts izmantot</summary>
    Public Shared ReadOnly StartUsed As UsageStatus = New UsageStatus(UsageStatusEnum.StartUsed)
    ''' <summary>Izmantots pilnībā</summary>
    Public Shared ReadOnly Used As UsageStatus = New UsageStatus(UsageStatusEnum.Used)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Created)
                _listHolder.Add(StartUsed)
                _listHolder.Add(Used)
            End If
            Return _listHolder
        End Get
    End Property

End Class
