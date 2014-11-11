Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Entities
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class ctlPatientCards
    Private list As Entities(Of Document)
    Private clickPlace As GridHitInfo

    Private Sub ctlPatientCards_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim parent As frmTree = CType(FindForm(), frmTree)
        If parent._patient Is Nothing Then Return

        list = Entities(Of Document).GetAll(parent.Session, New Expressions.Eq("DocType", DocumentType.DenticalCard), New Expressions.Eq("Patient", parent._patient))

        bndDocumentList.DataSource = list
    End Sub

    Private Sub grdPrescription_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        clickPlace = gvwRtgSummary.CalcHitInfo(e.X, e.Y)
    End Sub


    Private Sub Open()
        If bndDocumentList.Current Is Nothing Then
            Return
        End If
        Dim parent As frmTree = CType(FindForm(), frmTree)
        If parent._patient Is Nothing Then Return
        Dim doc As Document
        doc = CType(bndDocumentList.Current, Document)
        doc.ShowTrackedDocument(parent.Session)
    End Sub

    Private Sub grdRtgSummary_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRtgSummary.MouseMove
        clickPlace = gvwRtgSummary.CalcHitInfo(e.X, e.Y)
    End Sub
    Private Sub gvwRtgSummary_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvwRtgSummary.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        If clickPlace.HitTest = GridHitTest.RowCell Then
            Open()
        End If
    End Sub
End Class
