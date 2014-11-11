
Imports Core.Bll
Imports Entities
Imports Core.Dal.Expressions
Imports Core.UI

Public Class frmSalesList
    Private dati As Entities(Of Sale)

    Private Sub frmSalesList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''atlasam datus
        dati = Entities(Of Sale).GetAll(Session, New IsNull("DeleteTime"))
        SaleBindingSource.DataSource = dati
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Dim frm As New frmSale
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(dati, IList)
        key.Add(GetType(Sale), Guid.Empty)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        If SaleBindingSource.Current Is Nothing Then
            Return
        End If
        Dim frm As New frmSale
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(dati, IList)
        key.Add(GetType(Sale), CType(SaleBindingSource.Current, Sale).Id)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If SaleBindingSource.Current Is Nothing Then
            Return
        End If
        Dim _sale As Sale = CType(SaleBindingSource.Current, Sale)
        If MsgBox.DeleteMessage() = DialogResult.Yes Then
            _sale.IsActive = False
            Session.SaveOrUpdate(_sale)
            Session.Commit()
        End If
    End Sub
End Class
