''' <summary>Nodarbinātības veidi</summary>
Public Enum WorkingEnum

    ''' <summary>Strādā</summary>
    Work = 1
    ''' <summary>Students</summary>
    Student = 2
    ''' <summary>Bezdarbnieks</summary>
    Unwork = 3
    ''' <summary>Bērns</summary>
    Children = 4
    ''' <summary>Pensionārs</summary>
    Senior = 5
End Enum


Public Class Working
    Inherits Core.EnumWrapper(Of WorkingEnum)

    Sub New(ByVal value As WorkingEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Strādā</summary>
    Public Shared ReadOnly Work As Working = New Working(WorkingEnum.Work)
    ''' <summary>Students</summary>
    Public Shared ReadOnly Student As Working = New Working(WorkingEnum.Student)
    ''' <summary>Bezdarbnieks</summary>
    Public Shared ReadOnly Unwork As Working = New Working(WorkingEnum.Unwork)
    ''' <summary>Bērns</summary>
    Public Shared ReadOnly Children As Working = New Working(WorkingEnum.Children)
    ''' <summary>Pensionārs</summary>
    Public Shared ReadOnly Senior As Working = New Working(WorkingEnum.Senior)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(Children)
                _listHolder.Add(Work)
                _listHolder.Add(Student)
                _listHolder.Add(Unwork)
                _listHolder.Add(Senior)
            End If
            Return _listHolder
        End Get
    End Property

End Class
