Imports Core.UI

Public Class ctlClassifierFind

    Private Sub ctlClassifierFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not DesignMode Then
            Dim obj As Windows.Forms.CheckBox
            obj = CType(Me.panButtonTable.Controls.Item(0), Windows.Forms.CheckBox)
            obj.Checked = True
            obj.Visible = False
            obj.Visible = Core.Bll.PermissionsChecker.CanDo("Menu.ClassifierAdministration")

            bndFind.DataSource = New Entities.ClassifierFind(CType(Me.FindForm(), Core.frmBase).Session)
        End If
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        If CType(Me.ParentForm, frmClassifierList).ClType.CodePrompt Is Nothing Then
            For Each Control As Control In Me.panTableLayout.Controls
                If TypeOf Control Is CheckBox And Control.Name = "chkCode" Then
                    Control.Visible = False
                End If
                If TypeOf Control Is TextBox And Control.Name = "txtCode" Then
                    Control.Visible = False
                End If
            Next
        End If
    End Sub
End Class

' Lūdzu, Юникод!