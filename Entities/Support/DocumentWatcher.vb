Imports System.IO
Imports Core.Dal

Public Class DocumentWatcher
    Inherits FileSystemWatcher


    Public Sub New(ByVal doc As Document, ByVal fileName As String, ByVal autosave As Boolean, ByVal session As ISession)
        MyBase.New(System.IO.Path.GetDirectoryName(fileName), "*.rtf")
        trackedFileName = fileName
        document = doc
        AddHandler Me.Renamed, AddressOf OnRenamed
        AddHandler Me.Deleted, AddressOf OnChanged
        EnableRaisingEvents = True
        _state = WatcherState.Active
        _autosave = autosave
        _session = session
    End Sub

    Private trackedFileName As String
    Private document As Document
    Private lastTempName As String
    Private _state As WatcherState
    Private _autosave As Boolean = False
    Private _session As ISession = Nothing

    Public ReadOnly Property State() As WatcherState
        Get
            Return _state
        End Get
    End Property

    Private Shared Shadows Sub OnChanged(ByVal source As Object, ByVal e As FileSystemEventArgs)
        Dim dw As DocumentWatcher = CType(source, DocumentWatcher)
        dw.EnableRaisingEvents = False
        dw._state = WatcherState.Inactive
        'Try
        '    File.Delete(dw.trackedFileName)
        'Catch ex As Exception
        '    For i As Int16 = 1 To 1000

        '    Next
        '    File.Delete(dw.trackedFileName)
        'End Try

    End Sub



    Private Shared Shadows Sub OnRenamed(ByVal source As Object, ByVal e As RenamedEventArgs)
        Dim dw As DocumentWatcher = CType(source, DocumentWatcher)
        If (e.FullPath = dw.trackedFileName) And Not dw.lastTempName = e.OldName Then
            dw.lastTempName = e.OldName
            If Core.UI.MsgBox.Show(Core.Msg.SaveNewVersion, Windows.Forms.MessageBoxButtons.YesNo, "PreMedic", True) = Windows.Forms.DialogResult.Yes Then
                Dim myTempName As String = dw.Path + "\" + dw.document.File.Name
                If File.Exists(myTempName) Then
                    File.Delete(myTempName)
                End If
                File.Copy(dw.trackedFileName, myTempName)
                dw.document.File = New BinaryFile(dw.document.GetSession(), myTempName)
                If dw._autosave Then
                    dw._session.SaveOrUpdate(dw.document)
                    dw._session.SaveOrUpdate(dw.document.File)
                    dw._session.Commit()
                End If
                File.Delete(myTempName)
            End If
        End If
    End Sub
End Class

Public Enum WatcherState
    Active
    Inactive
End Enum