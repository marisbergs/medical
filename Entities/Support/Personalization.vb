Imports Core.Bll
Imports Core.Dal
Imports System.Reflection
Imports System.ComponentModel

Public Class Personalization
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.ISynchronizesSeparately
#Region "Private members"
    Private _user As User
    Private _form As String
    Private _table As String
    Private _view As String
    Private _content As String
#End Region

#Region "Constructors"
    Protected Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
    End Sub
#End Region

#Region "Property"

    ''' <summary>
    ''' Lietotājs
    ''' </summary>
    Public Overridable Property User() As User
        Get
            Return _user
        End Get
        Set(ByVal value As User)
            Assign("User", value, _user)
        End Set
    End Property

    ''' <summary>
    ''' Formas nosaukums
    ''' </summary>
    Public Overridable Property Form() As String
        Get
            Return _form
        End Get
        Set(ByVal value As String)
            Assign("Form", value, _form)
        End Set
    End Property

    ''' <summary>
    ''' Tabulas nosaukums
    ''' </summary>
    Public Overridable Property Table() As String
        Get
            Return _table
        End Get
        Set(ByVal value As String)
            Assign("Table", value, _table)
        End Set
    End Property

    ''' <summary>
    ''' Skata nosaukums
    ''' </summary>
    Public Overridable Property View() As String
        Get
            Return _view
        End Get
        Set(ByVal value As String)
            Assign("View", value, _view)
        End Set
    End Property

    ''' <summary>
    ''' Izkārtojums
    ''' </summary>
    Public Overridable Property Content() As String
        Get
            Return _content
        End Get
        Set(ByVal value As String)
            Assign("Content", value, _content)
        End Set
    End Property
#End Region
End Class
