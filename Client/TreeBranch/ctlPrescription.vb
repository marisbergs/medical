Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Entities
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class ctlPrescription
    Private list As Entities(Of Prescription)
    Private clickPlace As GridHitInfo

    Private Sub ctlPrescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim parent As frmTree = CType(FindForm(), frmTree)
        If parent._patient Is Nothing Then Return

        list = Entities(Of Prescription).GetAll(parent.Session, New Expressions.Eq("DocType", DocumentType.Prescription), New Expressions.Eq("Patient", parent._patient))

        bndPrescription.DataSource = list
    End Sub

    Private Sub grdPrescription_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdPrescription.MouseMove
        clickPlace = gvwPrescription.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub gvwPrescription_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvwPrescription.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            Open()
        End If
    End Sub

    Private Sub Open()
        If bndPrescription.Current Is Nothing Then
            Exit Sub
        End If
        Dim _edit As Prescription = CType(bndPrescription.Current, Prescription)
        Dim frm As New frmPrescription
        frm.Session = Nothing
        frm.PartnerSession = CType(FindForm(), frmBase).Session
        Dim data As New Dictionary(Of Type, Guid)
        data.Add(GetType(Prescription), _edit.Id)
        frm.DataIDs = data
        frmMain.AddChild(frm)
    End Sub
End Class
