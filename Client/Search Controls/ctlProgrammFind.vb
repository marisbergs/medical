Imports Core
Imports Core.UI
Imports Core.Dal
Imports Core.Bll
Imports Entities

Public Class ctlProgrammFind

    Private Sub ctlPatientFind_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.DesignMode Then Return
        bndFind.DataSource = New Entities.FindProgramm(CType(Me.FindForm(), Core.frmBase).Session)
    End Sub

    Private Sub chkSurname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPatient.CheckedChanged

    End Sub
End Class

' Lūdzu, Юникод!
