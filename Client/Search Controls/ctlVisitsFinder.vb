Imports Core
Imports Core.UI
Imports Core.Dal
Imports Core.Bll
Imports Entities

Public Class ctlVisitsFinder

    Private Sub ctlVisitsFinder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.DesignMode Then Return
        bndFind.DataSource = New Entities.VisitsFinder(CType(Me.FindForm(), Core.frmBase).Session)
    End Sub

    Private Sub panTableLayout_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panTableLayout.Paint

    End Sub
End Class

' Lūdzu, Юникод!
