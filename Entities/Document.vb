Imports core
Imports Core.Dal
Imports Core.Bll
Imports System.IO
Imports System.Windows.Forms
Imports System

''' <summary>
''' Dokumenta bāzes klase
''' </summary>
Public Class Document
    Inherits Core.Bll.BusinessObjectBase(Of Guid)

    Protected Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        CreationDate = DateTime.Now
        Creator = Context.Current.AuthenticatedUser
        DocFileHistory = New Core.Dal.ChildCollection(Of DocFileHistory)
    End Sub

#Region "Private members"
    Private _docType As DocumentType
    Private _patient As Patient
    Private _docNumber As String
    Private _docDate As Nullable(Of DateTime)
    Private _recordNumber As String
    Private _recordDate As Nullable(Of DateTime)
    Private _name As String
    Private _creator As User
    Private _creationDate As DateTime
    Private _template As Template
    Private _owner As User
    Private _ownerDate As DateTime
    Private _file As BinaryFile
    Private _notes As String
    Private _currentVersion As Integer = 0
    Private _documentWatcher As DocumentWatcher
    Private _docFileHistory As Core.Dal.IChildCollection(Of DocFileHistory)
#End Region


    ''' <summary>
    ''' Dokumenta veids
    ''' </summary>
    Public Overridable Property DocType() As DocumentType
        Get
            Return _docType
        End Get
        Set(ByVal value As DocumentType)
            Assign("DocType", value, _docType)
        End Set
    End Property

    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            Assign("Patient", value, _patient)
        End Set
    End Property

    ''' <summary>
    ''' Dokumenta nr.
    ''' </summary>
    Public Overridable Property DocNumber() As String
        Get
            Return _docNumber
        End Get
        Set(ByVal value As String)
            Assign("DocNumber", value, _docNumber)
        End Set
    End Property

    ''' <summary>
    ''' Dokumenta datums
    ''' </summary>
    Public Overridable Property DocDate() As Nullable(Of Date)
        Get
            Return _docDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("DocDate", value, _docDate)
        End Set
    End Property

    ''' <summary>
    ''' Lietvedības nr.
    ''' </summary>
    Public Overridable Property RecordNumber() As String
        Get
            Return _recordNumber
        End Get
        Set(ByVal value As String)
            Assign("RecordNumber", value, _recordNumber)
        End Set
    End Property

    ''' <summary>
    ''' Lietvedības datums
    ''' </summary>
    Public Overridable Property RecordDate() As Nullable(Of Date)
        Get
            Return _recordDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("RecordDate", value, _recordDate)
        End Set
    End Property

    ''' <summary>
    ''' Nosaukums
    ''' </summary>
    Public Overridable Property Name() As String
        Get
            If String.IsNullOrEmpty(_name) AndAlso Not DocType Is Nothing Then
                Return DocType.Name
            End If
            Return _name
        End Get
        Set(ByVal value As String)
            Assign("Name", value, _name)
            OnPropertyChanged("FormName")
        End Set
    End Property

    ''' <summary>
    ''' Lietotājs, kur pievienojis dokumentu
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
    ''' Dokumenta pievienošanas datums
    ''' </summary>
    Public Overridable Property CreationDate() As Date
        Get
            Return _creationDate
        End Get
        Set(ByVal value As Date)
            Assign("CreationDate", value, _creationDate)
        End Set
    End Property

    ''' <summary>
    ''' Veidlapa, no kuras ģenerēts dokuments
    ''' </summary>
    Public Overridable Property Template() As Template
        Get
            Return _template
        End Get
        Set(ByVal value As Template)
            Assign("Template", value, _template)
        End Set
    End Property

    ''' <summary>
    ''' Piezīmes
    ''' </summary>
    Public Overridable Property Notes() As String
        Get
            Return _notes
        End Get
        Set(ByVal value As String)
            Assign("Notes", value, _notes)
        End Set
    End Property


    ''' <summary>
    ''' Ģenerētais vai piesaistītais fails
    ''' </summary>
    Public Overridable Property File() As BinaryFile
        Get
            Return _file
        End Get
        Set(ByVal value As BinaryFile)
            Assign("File", value, _file)
            CreateFileHistoryEntry(_file)
        End Set
    End Property

    Private Sub CreateFileHistoryEntry(ByVal file As BinaryFile)
        CurrentVersion = CurrentVersion + 1
    End Sub


    Public Overridable Property CurrentVersion() As Integer
        Get
            Return _currentVersion
        End Get
        Set(ByVal value As Integer)
            Assign("CurrentVersion", value, _currentVersion)
        End Set
    End Property

    ''' <summary>
    ''' Dokumenta failu maiņas saraksts
    ''' </summary>
    Public Overridable Property DocFileHistory() As Core.Dal.IChildCollection(Of DocFileHistory)
        Get
            Return _docFileHistory
        End Get
        Protected Set(ByVal value As Core.Dal.IChildCollection(Of DocFileHistory))
            'Assign("DocFileHistory", value, _docFileHistory)
            _docFileHistory = value
            _docFileHistory.Parent = Me
        End Set
    End Property

    Public Overridable Sub GenerateDocument(ByVal tagName As String)
        If Template Is Nothing OrElse Template.CurrentVersion Is Nothing Then
            Return
        End If


        Dim templateStream As Stream = Template.CurrentVersion.File.Content.GetAsStream()
        Dim context As New Hashtable
        context.Add(tagName, Me)
        context.Add("P1", Me.Patient)

        Dim fileName As String = Path.GetTempFileName() + ".rtf"
        Core.Reporting.Report.CreateReport(templateStream, fileName, context)
        File = New BinaryFile(GetSession(), fileName)
        ShowTrackedDocument()
    End Sub

    Public Overridable Sub GenerateDocument(ByVal tagName As String, ByVal session As ISession)
        If Template Is Nothing OrElse Template.CurrentVersion Is Nothing Then
            Return
        End If


        Dim templateStream As Stream = Template.CurrentVersion.File.Content.GetAsStream()
        Dim context As New Hashtable
        context.Add(tagName, Me)
        context.Add("P1", Me.Patient)

        Dim fileName As String = Path.GetTempFileName() + ".rtf"
        Core.Reporting.Report.CreateReport(templateStream, fileName, context)
        File = New BinaryFile(GetSession(), fileName)
        ShowTrackedDocument(session)
    End Sub


    Public Overridable Sub ShowTrackedDocument(ByVal session As ISession)
        If File Is Nothing Then Return

        Dim tempPath As String = System.IO.Path.GetTempPath + Guid.NewGuid().ToString() + File.Name
        File.Content.SaveToFile(tempPath)
        _documentWatcher = New DocumentWatcher(Me, tempPath, True, session)
        Core.Helper.RunShell(tempPath)
    End Sub


    Public Overridable Sub ShowTrackedDocument()
        If File Is Nothing Then Return

        Dim tempPath As String = System.IO.Path.GetTempPath + Guid.NewGuid().ToString() + File.Name
        File.Content.SaveToFile(tempPath)
        _documentWatcher = New DocumentWatcher(Me, tempPath, False, Nothing)
        Core.Helper.RunShell(tempPath)
    End Sub

End Class


