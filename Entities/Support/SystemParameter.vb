Imports Core.Bll
Imports Core.Dal
Imports System.Globalization


Public Class SystemParameter
    Inherits BusinessObjectBase(Of String)

    Private _value As String
    Private _paramDate As Nullable(Of DateTime)

    Public Overridable Property Value() As String
        Get
            Return _value
        End Get
        Set(ByVal value As String)
            Assign("Value", value, _value)
        End Set
    End Property

    Public Overridable Property ParamDate() As Nullable(Of DateTime)
        Get
            Return _paramDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("ParamDate", value, _paramDate)
        End Set
    End Property

    Public Overridable Function ParsedValue(Of tp)() As tp
        Return CType(Convert.ChangeType(_value, GetType(tp)), tp)
    End Function

    Public Overridable Sub SetValue(Of tp)(ByVal value As tp)
        Me.Value = value.ToString()
    End Sub
End Class
