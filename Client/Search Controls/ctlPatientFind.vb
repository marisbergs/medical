Imports Core
Imports Core.UI
Imports Core.Dal
Imports Core.Bll
Imports Entities

Public Class ctlPatientFind

    Private Sub ctlPatientFind_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.DesignMode Then Return
        bndFind.DataSource = New Entities.FindPatients(CType(Me.FindForm(), Core.frmBase).Session)
    End Sub

    Private Sub chkLogon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

' Lūdzu, Юникод!
