Imports System.IO
Imports Core.Bll

''' <summary>
''' Binary file types
''' </summary>
''' <remarks></remarks>
Public Enum BinaryFileType
    Other
    Word
    Excel
End Enum


''' <summary>
''' Faili (uzģenerētie, pievienotie, templeiti u.c.)
''' </summary>
Public Class BinaryFile
    Inherits BusinessObjectBase(Of Guid)

    Private _name As String

    ''' <summary>
    ''' Faila nosaukums
    ''' </summary>
    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            Assign("Name", value, _name)
        End Set
    End Property

    ''' <summary>
    ''' Faila veids.
    ''' </summary>
    ''' <returns>Faila veids, kas atbilst Name propertijā reģistrētā faila vārda paplašinājumam.</returns>
    Public Overridable ReadOnly Property FileType() As Nullable(Of BinaryFileType)
        Get
            If _name = "" Then
                Return Nothing
            Else
                Dim result As BinaryFileType = BinaryFileType.Other
                Dim extPos As Integer = InStrRev(_name, ".")
                If extPos > 0 Then
                    Select Case LCase(Mid(_name, extPos))
                        Case ".doc", ".rtf"
                            result = BinaryFileType.Word
                        Case ".xls"
                            result = BinaryFileType.Excel
                        Case Else
                            result = BinaryFileType.Other
                    End Select
                End If
                Return result
            End If
        End Get
    End Property

    Private _content As BinaryContent

    ''' <summary>
    ''' Faila saturs
    ''' </summary>
    Public Overridable ReadOnly Property Content() As BinaryContent
        Get
            Return _content
        End Get
    End Property

    Public Overridable Sub LoadFile(ByVal fileName As String)
        If Not IO.File.Exists(fileName) Then
            Throw New Core.CriticalException(fileName & " not found.")
        Else
            Name = IO.Path.GetFileName(fileName)
            Using fs As New IO.FileStream(fileName, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
                If _content Is Nothing Then _content = New BinaryContent()
                _content.SetFromStream(fs)
            End Using
        End If
    End Sub


    Private Sub AddBusinessRules()
        Me.Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckRequired, "Name")
    End Sub

    Public Sub New(ByVal session As Core.Dal.ISession)
        MyBase.New(session)
        _content = New BinaryContent()
        Documents = New Core.Dal.ChildCollection(Of Document)
        AddBusinessRules()
    End Sub

    ''' <summary>
    ''' Constructor from file
    ''' </summary>
    Public Sub New(ByVal session As Core.Dal.ISession, ByVal fileName As String)
        MyBase.New(session)
        Me.LoadFile(fileName)
        Documents = New Core.Dal.ChildCollection(Of Document)
        AddBusinessRules()
    End Sub

    ''' <summary>
    ''' Standard constructor
    ''' </summary>
    Protected Sub New()
        AddBusinessRules()
    End Sub


    Public Overrides Function ToString() As String
        Return Me.Name
    End Function

    Private _documents As Core.Dal.IChildCollection(Of Document)
    ''' <summary>
    ''' KP lietai pievienotie dokumenti
    ''' </summary>
    Public Overridable Property Documents() As Core.Dal.IChildCollection(Of Document)
        Get
            Return _documents
        End Get
        Protected Set(ByVal value As Core.Dal.IChildCollection(Of Document))
            Me._documents = value
            _documents.Parent = Me
        End Set
    End Property
End Class

''' <summary>
''' The compressed content of BinaryFile
''' </summary>
''' <remarks>Separated from BinaryFile to utilize lazy loading of large binary content.</remarks>
Public Class BinaryContent

    Private _id As Guid
    Private _compressedData As Byte()

    Public Overridable ReadOnly Property Id() As Guid
        Get
            Return _id
        End Get
    End Property

    Protected Overridable ReadOnly Property CompressedData() As Byte()
        Get
            Return _compressedData
        End Get
    End Property

    ''' <summary>
    ''' Returns a Stream for data access or Nothing (null) if there is no data
    ''' </summary>
    Public Overridable Function GetAsStream() As Stream
        If _compressedData Is Nothing Then
            Return Nothing
        Else
            Return New Compression.GZipStream(New MemoryStream(_compressedData), Compression.CompressionMode.Decompress)
        End If
    End Function


    Public Overridable Sub SaveToFile(ByVal fileName As String)
        If _compressedData Is Nothing Then Return
        Dim writer As New FileStream(fileName, FileMode.OpenOrCreate)
        Core.Helper.ReadWriteStream(GetAsStream(), writer)
    End Sub


    ''' <summary>
    ''' Passes data to store, as an input stream
    ''' <example>
    '''    Dim target As BinaryContent = New BinaryContent()
    '''    Dim inputStream As New FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read)
    '''    target.SetFromStream(inputStream)
    ''' </example>
    ''' </summary>
    ''' <param name="instream">Stream that contains the data to be stored</param>
    Public Overridable Sub SetFromStream(ByVal instream As Stream)
        Dim ms As New MemoryStream() ' Holds the compressed data
        Dim compressedStream As New Compression.GZipStream(ms, Compression.CompressionMode.Compress, True)

        Dim bufferSize As Integer = CType(instream.Length, Integer)
        If bufferSize = 0 Then
            bufferSize = 1
        End If
        Dim buffer(bufferSize - 1) As Byte

        instream.Seek(0, SeekOrigin.Begin)
        Do
            Dim bytesRead As Integer = instream.Read(buffer, 0, bufferSize)
            compressedStream.Write(buffer, 0, bytesRead)
            If bytesRead < bufferSize Then Exit Do
        Loop
        compressedStream.Close()
        ' Store compressed data
        _compressedData = New Byte(CType(ms.Length, Integer) - 1) {}
        ms.Seek(0, SeekOrigin.Begin)
        ms.Read(_compressedData, 0, _compressedData.Length)

        'Debug.WriteLine(String.Format("; Compressed size = {0}", _compressedData.Length))
    End Sub


End Class
' Уныкоде