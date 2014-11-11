Imports Entities
Imports System.IO
Imports Core.Dal
Imports Core.Bll
Imports Core.UI
Imports System.Collections.Generic
Imports Core


Public Class frmAttachment
    Implements IEditForm

    Private _edit As PatientDocument
    Private _dataList As IList


    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return Nothing
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(PatientDocument)) = Guid.Empty Then 'add new TcdPlan
                _edit = New PatientDocument(Session, value(GetType(Patient)))
            Else 'edit existing
                _edit = Session.Get(Of PatientDocument)(value(GetType(PatientDocument)))
            End If
            bndPatientDocument.DataSource = _edit
            gbhAppealFiles.ShowActive = True
        End Set
    End Property

    Public Property DataList() As System.Collections.IList Implements Core.UI.IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As IList)
            _dataList = value
        End Set
    End Property

    Private Function Save() As Boolean
        Dim add As Boolean = (_edit.Id = Guid.Empty)
        If Not _edit.IsValid Then
            MsgBox.HasErrorMessage()
            Return False
        End If
        Session.SaveOrUpdate(_edit)
        Session.Commit()
        If add Then
            DataList.Add(PartnerSession.Get(Of PatientDocument)(_edit.Id))
        End If
        Return True
    End Function


    Private Sub frmAttachment_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If _edit.IsDirty Then
            Dim answer As DialogResult = MsgBox.SaveMessage()
            If answer = DialogResult.Yes Then
                If Not Save() Then
                    e.Cancel = True
                End If
            ElseIf answer = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub gbhAppealFiles_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhAppealFiles.OnAddNew
        'on adding new entry to grid, open win open dialog
        Dim obj As New AttachmentFile(Session)
        obj.Parent = CType(_edit, PatientDocument)
        Dim dlg As New OpenFileDialog()
        dlg.CheckFileExists = True
        dlg.CheckPathExists = True
        dlg.Multiselect = False
        dlg.DefaultExt = "doc"
        dlg.Multiselect = True
        dlg.Filter = "doc files (*.doc)|*.doc|rtf files (*.rtf)|*.rtf|txt files (*.txt)|*.txt|All files (*.*)|*.*"
        Select Case dlg.ShowDialog(Me)
            Case Windows.Forms.DialogResult.Cancel
                args.CancelAdd = True
                Return
            Case Windows.Forms.DialogResult.OK
                For Each x As String In dlg.FileNames
                    obj = New AttachmentFile(Session)
                    obj.File = New BinaryFile(Me.Session, x)
                    _edit.Files.Add(obj)
                Next
        End Select
        Me.bndFiles.Position = Me.bndFiles.IndexOf(obj)
    End Sub

    Private Sub btnAddFile_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnAddFile.ButtonClick
        If Me.bndFiles.Current Is Nothing Then Return
        Dim _file As AttachmentFile = CType(Me.bndFiles.Current, AttachmentFile)
        Dim _FileName As String = Path.GetTempPath + "\" + Guid.NewGuid().ToString() + _file.File.Name
        Core.Helper.ReadWriteStream(_file.File.Content.GetAsStream(), New FileStream(_FileName, FileMode.Create))
        Core.Helper.RunShell(_FileName)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
