Imports Core.Dal
Imports Core.Bll
Imports Entities
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTemplateList
    Private clickPlace As GridHitInfo

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.grdTemplateList.SetListMode()
    End Sub

    Private Sub frmTemplateList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CType(Me.bindTemplate.DataSource, Entities(Of Entities.Template)).IsDirty Then Session.Commit()
    End Sub

    Private Sub frmTemplateList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.gbhTemplateList.ShowActive = True
        Me.bindTemplate.DataSource = Entities(Of Entities.Template).GetAll(Session)
        btnEdit.Enabled = False
    End Sub

    Private Sub gbhTemplateList_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhTemplateList.OnAddNew
        Dim dlg As New frmTemplateEdit()
        Dim dataIDs As New Dictionary(Of Type, Guid)
        dataIDs.Add(GetType(Template), Guid.Empty)
        dlg.DataIDs = dataIDs
        Select Case dlg.ShowDialog()
            Case Windows.Forms.DialogResult.OK
                args.AddedObject = Session.Get(Of Template)(dlg.DataIDs(GetType(Template)))
                args.CancelAdd = False
            Case Else
                args.CancelAdd = True
        End Select
    End Sub

    Private Sub EditCurrent()
        If Not CType(bindTemplate.Current, Entities.Template).IsActive Then Return

        Dim dlg As New frmTemplateEdit()
        Dim dataIDs As New Dictionary(Of Type, Guid)
        dataIDs.Add(GetType(Template), Session.GetIdentifier(bindTemplate.Current))
        dlg.DataIDs = dataIDs
        dlg.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        EditCurrent()
    End Sub

    Private Sub grdTemplateList_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdTemplateList.MouseClick
        clickPlace = vwMain.CalcHitInfo(e.X, e.Y)
        showMenuInGrid(clickPlace)
    End Sub

    Private Sub grdTemplateList_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdTemplateList.MouseDoubleClick
        If btnEdit.Enabled Then
            EditCurrent()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub gbhTemplateList_OnDelete(ByVal sender As Object, ByVal args As Core.UI.GridButtonHelper.DeleteEventArgs) Handles gbhTemplateList.OnDelete
        If Me.bindTemplate.Current Is Nothing Then Exit Sub

        Dim tmpl As Template = CType(bindTemplate.Current, Entities.Template)

        If Not tmpl.IsActive Then
            Core.UI.MsgBox.Show(Core.Msg.EntryAlreadyDeleted, MessageBoxButtons.OK)
            Return
        End If

        If Core.UI.MsgBox.Show(Core.Msg.DeleteConfirmation, MessageBoxButtons.YesNo) <> Windows.Forms.DialogResult.Yes Then Exit Sub
        tmpl.Delete()

        Me.AcceptChanges()
        Me.bindTemplate.ResetBindings(False)

        args.CancelDelete = True
    End Sub

#Region "Private subs"
    Private Sub showMenuInGrid(ByVal chi As GridHitInfo)
        If Not bindTemplate.Current Is Nothing Then
            If (chi.HitTest = GridHitTest.RowCell) Then
                btnEdit.Enabled = CType(bindTemplate.Current, Entities.Template).IsActive
            ElseIf (chi.HitTest = GridHitTest.Row Or chi.HitTest = GridHitTest.RowGroupButton) And vwMain.IsGroupRow(vwMain.FocusedRowHandle) Then
                btnEdit.Enabled = False
            End If
        Else
            btnEdit.Enabled = False
        End If
    End Sub
#End Region
End Class
' Lūdzu, Юникод