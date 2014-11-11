''' <summary>Nodarbinātības veidi</summary>
Public Enum HealthEnum

    ''' <summary>Normāls</summary>
    Normal = 1
    ''' <summary>Pataloģisks</summary>
    Pathalogical = 2
    ''' <summary>S.C.</summary>
    SC = 3
    ''' <summary>Vesels</summary>
    Well = 4
    ''' <summary>Slims</summary>
    Ill = 5

End Enum


Public Class Health
    Inherits Core.EnumWrapper(Of HealthEnum)

    Sub New(ByVal value As HealthEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Normāls</summary>
    Public Shared ReadOnly Normal As Health = New Health(HealthEnum.Normal)
    ''' <summary>Pataloģisks</summary>
    Public Shared ReadOnly Pathalogical As Health = New Health(HealthEnum.Pathalogical)
    ''' <summary>S.C.</summary>
    Public Shared ReadOnly SC As Health = New Health(HealthEnum.SC)
    ''' <summary>Vesels</summary>
    Public Shared ReadOnly Well As Health = New Health(HealthEnum.Well)
    ''' <summary>Slims</summary>
    Public Shared ReadOnly Ill As Health = New Health(HealthEnum.Ill)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Normal)
                _listHolder.Add(Pathalogical)
                _listHolder.Add(SC)
            End If
            Return _listHolder
        End Get
    End Property

    ''' <summary>
    ''' Vesels slims
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSourceWellIll() As IList
        Get
            Dim _list As New ArrayList
            _list.Add(Well)
            _list.Add(Ill)
            Return _list
        End Get
    End Property

End Class
