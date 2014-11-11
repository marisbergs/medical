
''' <summary>Atalgojuma veids</summary>
Public Enum SeleryTypeEnum

    ''' <summary>Nodarbība</summary>
    Time = 1
    ''' <summary>Procentu</summary>
    Percentage = 2
End Enum

''' <summary>Atalgojuma procentos vai latos</summary>
Public Enum SeleryEnum

    ''' <summary>Precentos</summary>
    Percentage = 1
    ''' <summary>Latos</summary>
    Ls = 2
End Enum

Public Class SeleryType
    Inherits Core.EnumWrapper(Of SeleryTypeEnum)
    Sub New(ByVal value As SeleryTypeEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Laika</summary>
    Public Shared ReadOnly Time As SeleryType = New SeleryType(SeleryTypeEnum.Time)
    ''' <summary>Procentu</summary>
    Public Shared ReadOnly Percentage As SeleryType = New SeleryType(SeleryTypeEnum.Percentage)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Time)
                _listHolder.Add(Percentage)
            End If
            Return _listHolder
        End Get
    End Property
End Class

Public Class Selery
    Inherits Core.EnumWrapper(Of SeleryEnum)
    Sub New(ByVal value As SeleryEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Laika</summary>
    Public Shared ReadOnly Percentage As Selery = New Selery(SeleryEnum.Percentage)
    ''' <summary>Procentu</summary>
    Public Shared ReadOnly Ls As Selery = New Selery(SeleryEnum.Ls)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Percentage)
                _listHolder.Add(Ls)
            End If
            Return _listHolder
        End Get
    End Property
End Class