Imports Core.Bll

''' <summary>
''' KP lietas tematiskās pārbaudes tēmas
''' </summary>
Public Class TextContent
    Inherits BusinessObjectBase(Of Guid)

#Region "Constructor"
    Protected Sub New()

    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession)
        MyBase.New(session)
    End Sub
#End Region

#Region "Private members"
    Private _text As String
#End Region


    ''' <summary>
    ''' Tematiskās pārbaudes tēma
    ''' </summary>
    Public Overridable Property Text() As String
        Get
            Return _text
        End Get
        Set(ByVal value As String)
            Assign("Text", value, _text)
        End Set
    End Property

    Public Overrides Function ToString() As String
        If Text Is Nothing Then Return ""
        Return Text
    End Function
End Class
' Уныкоде