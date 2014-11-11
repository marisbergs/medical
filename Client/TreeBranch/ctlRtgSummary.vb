Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Entities
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class ctlRtgSummary
    Private list As Entities(Of RtgSummary)
    Private clickPlace As GridHitInfo

    Private Sub ctlRtgSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim parent As frmTree = CType(FindForm(), frmTree)
        If parent._patient Is Nothing Then Return

        list = Entities(Of RtgSummary).GetAll(parent.Session, New Expressions.Eq("DocType", DocumentType.RtgSummary), New Expressions.Eq("Patient", parent._patient))

        bndRtgSummary.DataSource = list
    End Sub

    Private Sub grdPrescription_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        clickPlace = gvwRtgSummary.CalcHitInfo(e.X, e.Y)
    End Sub


    Private Sub Open()
        If bndRtgSummary.Current Is Nothing Then
            Exit Sub
        End If
        Dim _edit As RtgSummary = CType(bndRtgSummary.Current, RtgSummary)
        Dim frm As New frmRtgSummary
        frm.Session = Nothing
        frm.PartnerSession = CType(FindForm(), frmBase).Session
        Dim data As New Dictionary(Of Type, Guid)
        data.Add(GetType(RtgSummary), _edit.Id)
        frm.DataIDs = data
        frmMain.AddChild(frm)
    End Sub

    Private Sub gvwAttachment_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            Open()
        End If
    End Sub

    Private Sub grdRtgSummary_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRtgSummary.MouseMove
        clickPlace = gvwRtgSummary.CalcHitInfo(e.X, e.Y)
    End Sub
    Private Sub gvwRtgSummary_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvwRtgSummary.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            Open()
        End If
    End Sub
End Class
