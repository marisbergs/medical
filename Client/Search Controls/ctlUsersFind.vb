Imports Core
Imports Core.UI
Imports Core.Dal
Imports Core.Bll
Imports Entities

Public Class ctlUsersFind

    Private Sub ctlUsersFind_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.DesignMode Then Return

        'Dim table As New DataTable("table")
        'Dim colID As New DataColumn("colID", Type.GetType("System.String"))
        'Dim colValue As New DataColumn("colValue", Type.GetType("System.String"))
        'table.Columns.Add(colID)
        'table.Columns.Add(colValue)

        'table.Rows.Add("Yes", "Jā")
        'table.Rows.Add("No", "Nē")

        'Me.cmbIsUser.DataSource = table
        'Me.cmbIsUser.DisplayMember = "colValue"
        'Me.cmbIsUser.ValueMember = "colID"

        cmbIsUser.Properties.Items.AddRange(YesNo.ListSource)
        bndFind.DataSource = New Entities.FindUsers(CType(Me.FindForm(), Core.frmBase).Session)

        'VID struktūrvienības laukā iemet tekošā lietotāja str.v.
        'If currentUserOrg.Count = 0 Then
        '    Me.chkOrganization.Checked = False
        'Else
        '    Me.chkOrganization.Checked = True
        '    Me.bndFind.Current.organization = currentUserOrg
        'End If
    End Sub
End Class

' Lūdzu, Юникод!
