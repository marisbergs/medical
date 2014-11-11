Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports Core.Bll
Imports Core.Dal
Imports Entities
Imports NHibernate.Expression

Public Class frmInsurance
    Dim insuranceCompanu As New Entities(Of Insurance)
    Dim currentInsurance As Insurance
    Dim insuranceProgramms As Entities(Of Insurance)
    Dim data As New Dictionary(Of Insurance, DataTable)

    Private Sub frmInsurance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        insuranceCompanu = Entities(Of Insurance).GetAll(Session, New Expressions.IsNull("Parents"), New Expressions.IsNull("DeleteTime"))
        bndInsuranceCompany.DataSource = insuranceCompanu
    End Sub

    Private Sub cmbInsuranceCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbInsuranceCompany.EditValueChanged
        If (cmbInsuranceCompany.EditValue Is Nothing) Then
            Return
        End If
        currentInsurance = Session.Get(Of Insurance)(CType(cmbInsuranceCompany.EditValue, Guid))
        insuranceProgramms = Entities(Of Insurance).GetAll(Session, New Expressions.IsNull("DeleteTime"), New Expressions.Eq("Parents", currentInsurance))
        For Each o As GridBand In gvwData.Bands
            If Not o.Name = "bandService" Then
                o.Visible = False
            End If
        Next
        For Each _insurance As Insurance In insuranceProgramms
            Dim exists As Boolean = False
            For Each o2 As GridBand In gvwData.Bands
                If o2.Name = _insurance.Id.ToString Then
                    exists = True
                End If
            Next
            If Not exists Then
                Dim band As GridBand = gvwData.Bands.AddBand(_insurance.Value)
                band.Name = _insurance.Id.ToString()
                Dim col As BandedGridColumn
                col = New BandedGridColumn()
                col.Caption = "Apmaksā"
                col.Name = _insurance.Id.ToString & "_pay"
                band.Columns.Add(col)
                col = New BandedGridColumn()
                col.Caption = "Pakalpojuma cena"
                col.Name = _insurance.Id.ToString & "_total"
                band.Columns.Add(col)
                band.Columns.Item(1).Visible = True
                band.Columns.Item(0).Visible = True
                Dim dt As New DataTable
                dt.Columns.Add("colCode", System.Type.GetType("System.String"))
                dt.Columns.Add("colInsurance", System.Type.GetType("System.String"))
                data.Add(_insurance, dt)
            End If
        Next


    End Sub
End Class
