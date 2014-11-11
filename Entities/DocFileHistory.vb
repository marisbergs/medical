Imports Core.Bll
Imports System.IO

''' <summary>
''' Ģenerēto dokumentu versijas
''' </summary>
Public Class DocFileHistory
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

#Region "Private members"
    Private _document As Document
    Private _file As BinaryFile
    Private _creator As User
    Private _creationDate As DateTime
    Private _versionNumber As Integer
#End Region
#Region "Getters&Setters"
    ''' <summary>
    ''' Dokuments
    ''' </summary>
    Public Overridable Property Document() As Document
        Get
            Return _document
        End Get
        Set(ByVal value As Document)
            Assign("Document", value, _document)
        End Set
    End Property
    ''' <summary>
    ''' Fails
    ''' </summary>
    Public Overridable Property File() As BinaryFile
        Get
            Return _file
        End Get
        Set(ByVal value As BinaryFile)
            Assign("File", value, _file)
        End Set
    End Property
    ''' <summary>
    ''' Lietotājs, kurš ģenerējis/pievienojis failu
    ''' </summary>
    Public Overridable Property Creator() As User
        Get
            Return _creator
        End Get
        Set(ByVal value As User)
            Assign("Creator", value, _creator)
        End Set
    End Property
    ''' <summary>
    ''' Izveidošanas datums
    ''' </summary>
    Public Overridable Property CreationDate() As DateTime
        Get
            Return _creationDate
        End Get
        Set(ByVal value As DateTime)
            Assign("CreationDate", value, _creationDate)
        End Set
    End Property
    ''' <summary>
    ''' Faila versijas nr.
    ''' </summary>
    Public Overridable Property VersionNumber() As Integer
        Get
            Return _versionNumber
        End Get
        Set(ByVal value As Integer)
            Assign("VersionNumber", value, _versionNumber)
        End Set
    End Property

    Public Overridable Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.Document
        End Get
        Set(ByVal value As Object)
            Me.Document = CType(value, Document)
        End Set
    End Property

#End Region

    Public Sub New(ByVal session As Core.Dal.ISession, ByVal file As BinaryFile, ByVal versionNumber As Integer)
        MyBase.New(session)
        _creationDate = DateTime.Now
        _creator = Context.Current.GetAuthenticatedUser(session)
        _file = file
        _versionNumber = versionNumber
    End Sub

    Protected Sub New()
    End Sub

End Class
' Уныкоде