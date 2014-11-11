Imports Core
Imports Core.Dal
Imports Entities
Imports Core.Bll

Public Class ctlCheckUp

    Dim Session As ISession
    Private Sub ctlCheckUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Session = CType(FindForm(), frmBase).Session
        Dim templates As Entities(Of Template)
        templates = Entities(Of Template).GetAll(Session, New Expressions.Eq("Type.Id", TemplateType.CheckUp), New Expressions.IsNull("DeleteTime"))
        For Each x As Template In templates
            Dim chk As New CheckBox
            chk.Text = x.Name
            chk.AutoSize = True
            chk.Tag = x
            panTemplates.Controls.Add(chk)
        Next
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim parent As frmTree = CType(FindForm(), frmTree)
        If parent._patient Is Nothing Then Return
        Dim _patient As Patient = parent._patient
        For Each x As Control In panTemplates.Controls
            If Not x.GetType.Name = "CheckBox" Then
                Continue For
            End If
            Dim chk As CheckBox = CType(x, CheckBox)
            If Not chk.Checked Then
                Continue For
            End If
            Dim t As Template = CType(x.Tag, Template)
            _patient.GenerateDocument("D" & t.Code, t)
        Next
    End Sub
End Class
