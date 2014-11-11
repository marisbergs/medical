Imports Core
Imports Core.UI
Imports Core.Dal
Imports Core.Bll
Imports Entities

Public Class ctlEventFind

    Private Sub ctlEventFind_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.DesignMode Then Return
        Dim frm As Core.frmBase = Me.FindForm()
        cmbGroup.Properties.Items.Clear()
        ''cmbGroup.Properties.Items.Add(frm.Session.Get(Of AuditMessage)(New Guid("B31521E2-70D8-4503-86C7-416AC1D323FE")))
        ''cmbGroup.Properties.Items.Add(frm.Session.Get(Of AuditMessage)(New Guid("CEB45377-3F0C-4F1A-A6BC-8CC2953C4848")))
        ''cmbGroup.Properties.Items.Add(frm.Session.Get(Of AuditMessage)(New Guid("E01488EE-18D1-40F9-9D8A-EB2E16700B4B")))

        bndFind.DataSource = New Entities.EventFind(CType(Me.FindForm(), Core.frmBase).Session)
    End Sub

    Private Sub txtUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.Click
        Dim frm As New frmUsers
        frm.FormMode = ClassifierListMode.MultiSelect

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.bndFind.Current.User = frm.Selection
            Me.bndFind.ResetBindings(False)
        End If
    End Sub


End Class
' Lūdzu, Юникод
