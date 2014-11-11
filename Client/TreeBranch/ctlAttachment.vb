Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Entities
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class ctlAttachment
    Private list As Entities(Of PatientDocument)
    Private clickPlace As GridHitInfo

    Private Sub ctlAttachment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim parent As frmTree = CType(FindForm(), frmTree)
        If parent._patient Is Nothing Then Return

        List = Entities(Of PatientDocument).GetAll(parent.Session, New Expressions.Eq("Patient", parent._patient))

        bndDocumentList.DataSource = list

    End Sub

    Private Sub grdPrescription_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdAttachment.MouseMove
        clickPlace = gvwAttachment.CalcHitInfo(e.X, e.Y)
    End Sub


    Private Sub Open()
        If bndDocumentList.Current Is Nothing Then
            Exit Sub
        End If
        Dim _edit As PatientDocument = CType(bndDocumentList.Current, PatientDocument)
        Dim frm As New frmAttachment
        frm.Session = Nothing
        frm.PartnerSession = CType(FindForm(), frmBase).Session
        Dim data As New Dictionary(Of Type, Guid)
        data.Add(GetType(PatientDocument), _edit.Id)
        frm.DataIDs = data
        frmMain.AddChild(frm)
    End Sub

    Private Sub gvwAttachment_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvwAttachment.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            Open()
        End If
    End Sub
End Class
