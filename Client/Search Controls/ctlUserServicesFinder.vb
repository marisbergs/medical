Imports Core
Imports Core.UI
Imports Core.Dal
Imports Core.Bll
Imports Entities

Public Class ctlUserServicesFinder

    Private Sub ctlUserServicesFinder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.DesignMode Then Return
        bndFind.DataSource = New Entities.UserServicesFinder(CType(Me.FindForm(), Core.frmBase).Session)
    End Sub
End Class

' Lūdzu, Юникод!
