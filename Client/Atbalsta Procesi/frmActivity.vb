Imports Core.Bll
Imports Entities
Imports Core.UI
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmActivity
    Private _criteria As New List(Of Core.Dal.Expressions.CriterionBase)
    Private clickPlace As Object

    Private Sub frmActivity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CtlActivityFind1_Find(ByVal sender As System.Object, ByVal e As Client.FindEventArgs) Handles CtlActivityFind1.Find
        _criteria = CType(e.Criteria, List(Of Core.Dal.Expressions.CriterionBase))
        Dim activity As New Entities(Of Activity)
        Session.CreateAndBuildCriteria(Of Activity)(_criteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(activity)
        bndActivitu.DataSource = activity
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New frmActivityEdit
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(bndActivitu.DataSource, IList)
        key.Add(GetType(Activity), Guid.Empty)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenActivity()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bndActivitu.Current Is Nothing Then
            Return
        End If
        Dim activity As Activity = CType(bndActivitu.Current, Activity)
        If Not activity.IsActive Then
            MsgBox.Show("Šī aktivitāte jau ir dzēsta.")
            Return
        End If
        If MsgBox.DeleteMessage = Windows.Forms.DialogResult.Yes Then
            activity.IsActive = False
            Session.SaveOrUpdate(activity)
            Session.Commit()
        End If
    End Sub

    Private Sub OpenActivity()
        If bndActivitu.Current Is Nothing Then
            Return
        End If
        Dim frm As New frmActivityEdit
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(bndActivitu.DataSource, IList)
        key.Add(GetType(Activity), CType(Me.bndActivitu.Current, Activity).Id)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub grdActivity_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdActivity.MouseMove
        clickPlace = gvwActivity.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub gvwActivity_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvwActivity.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            OpenActivity()
        End If
    End Sub
End Class
