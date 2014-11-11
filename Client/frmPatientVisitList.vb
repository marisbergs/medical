Imports Entities
Imports Core.Bll
Imports Core.Dal.Expressions
Imports Core.UI

Public Class frmPatientVisitList

    Private _patient As Patient
    Private _service As Services
    Public SelectedVisit As Visit

    Public Sub New(ByVal patient As Patient, ByVal service As Services)
        InitializeComponent()
        _patient = patient
        _service = service
        LoadData()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub LoadData()
        If _patient Is Nothing Then
            Return
        End If
        Dim visits As Entities(Of Visit)
        visits = Entities(Of Visit).GetAll(Session, New Eq("Patient", _patient), New IsNull("DeleteTime"), New Eq("VisitServices.Service", _service), New IsNull("VisitServices.DeleteTime"))
        VisitBindingSource.DataSource = visits
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If Not VisitBindingSource.Current Is Nothing Then
            SelectedVisit = CType(VisitBindingSource.Current, Visit)
            DialogResult = Windows.Forms.DialogResult.OK
            Close()
        Else
            MsgBox.Show("Nav izvēlēta neviena vizīte.")
        End If

    End Sub
End Class
