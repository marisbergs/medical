Imports Core
Imports Entities
Imports Core.Bll
Imports Core.Dal


Public Class frmDoctorServices

    Private Sub frmDoctorServices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Entities(Of Services).GetAll(Session, New Expressions.IsNull("DeleteTime"))
        Entities(Of User).GetAll(Session, New Expressions.IsNull("DeleteTime"))
        bndList.DataSource = Entities(Of UserService).GetAll(Session, New Expressions.IsNull("DeleteTime"), New Expressions.Or(New Expressions.IsNull("User.WorkedUntil"), New Expressions.Ge("User.WorkedUntil", Now.Date)))
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        CoreGrid1.Export()
    End Sub
End Class
