Imports Microsoft.VisualBasic

Public Class Patient

    Private _name As String
    Private _surname As String
    Private _code As String


    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Overridable Property Surname() As String
        Get
            Return _surname
        End Get
        Set(ByVal value As String)
            _surname = value
        End Set
    End Property

    Public Overridable Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property


    Public Shared Function GetPatient() As Patient
        Return New Patient()
    End Function

    Public Shared Sub SetPatient(ByVal patient As Patient)

    End Sub

End Class
