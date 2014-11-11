Imports Core.Dal
Imports Core.Bll

''' <summary>
''' KP lietas tematiskās pārbaudes tēmas
''' </summary>
Public Class LatestCM
    Inherits BusinessObjectBase(Of Guid)

#Region "Constructor"
    Protected Sub New()

    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession)
        MyBase.New(session)
    End Sub
#End Region

#Region "Private members"
    Private _cMDate As DateTime
    Private _theme As String
    Private _reason As String
    Private _violation As Boolean
#End Region

    ''' <summary>
    ''' KP lietas veikšanas datums
    ''' </summary>
    Public Overridable Property CMDate() As DateTime
        Get
            Return _cMDate
        End Get
        Set(ByVal value As DateTime)
            Assign("CMDate", value, _cMDate)
        End Set
    End Property

    ''' <summary>
    ''' Tematiskās pārbaudes tēma
    ''' </summary>
    Public Overridable Property Theme() As String
        Get
            Return _theme
        End Get
        Set(ByVal value As String)
            Assign("Theme", value, _theme)
        End Set
    End Property

    ''' <summary>
    ''' Tematiskās pārbaudes iemesli
    ''' </summary>
    Public Overridable Property Reason() As String
        Get
            Return _reason
        End Get
        Set(ByVal value As String)
            Assign("Reason", value, _reason)
        End Set
    End Property

    ''' <summary>
    ''' KP lietā konstatēts pārkāpums
    ''' </summary>
    Public Overridable Property Violation() As Boolean
        Get
            Return _violation
        End Get
        Set(ByVal value As Boolean)
            Assign("Violation", value, _violation)
        End Set
    End Property
End Class
' Уныкоде