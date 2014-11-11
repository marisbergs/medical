Imports Core
Imports Core.Dal
Imports Core.Bll


Public Class LocalSettings
    Inherits BusinessObjectBase(Of Guid)

    Private _key As String
    Private _value As String

    Public Overridable Property Key() As String
        Get
            Return _key
        End Get
        Set(ByVal value As String)
            Assign("Key", value, _key)
        End Set
    End Property

    Public Overridable Property Value() As String
        Get
            Return _value
        End Get
        Set(ByVal value As String)
            Assign("Value", value, _value)
        End Set
    End Property

    Public Shared Function GetValueByKey(ByVal session As ISession, ByVal key As String) As LocalSettings
        Dim list As Entities(Of LocalSettings)
        list = Entities(Of LocalSettings).GetAll(session, New Expressions.Eq("Key", key))
        If list.Count > 0 Then
            Return list(0)
        End If
        Return New LocalSettings
    End Function

End Class
