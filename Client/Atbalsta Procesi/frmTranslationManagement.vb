Public Class frmTranslationManagement

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("a1"))
        dt.Columns.Add(New DataColumn("a2"))

        Dim row As DataRow

        row = dt.NewRow()
        row("a1") = "chkOrganization"
        row("a2") = "VID struktūrvienība:"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("a1") = "chkPosition"
        row("a2") = "Amats:"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("a1") = "chkName"
        row("a2") = "Vārds vai uzvārds:"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("a1") = "chkIsUser"
        row("a2") = "Ir sistēmas lietotājs:"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("a1") = "chkLogon"
        row("a2") = "Lietotāja konts:"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("a1") = "chkActive"
        row("a2") = "Tikai aktuālie"
        dt.Rows.Add(row)
        GridControl1.DataSource = dt


        row = dt.NewRow()
        row("a1") = "colLogon"
        row("a2") = "Lietotājs"
        dt.Rows.Add(row)
        GridControl1.DataSource = dt

        row = dt.NewRow()
        row("a1") = "colTelephone"
        row("a2") = "Tālrunis"
        dt.Rows.Add(row)
        GridControl1.DataSource = dt

        row = dt.NewRow()
        row("a1") = "colPosition"
        row("a2") = "Amats"
        dt.Rows.Add(row)
        GridControl1.DataSource = dt

        row = dt.NewRow()
        row("a1") = "colName"
        row("a2") = "Darbinieks"
        dt.Rows.Add(row)
        GridControl1.DataSource = dt

        row = dt.NewRow()
        row("a1") = "chkOrganization"
        row("a2") = "VID struktūrvienība"
        dt.Rows.Add(row)
        GridControl1.DataSource = dt




    End Sub
End Class
' Lūdzu, Юникод