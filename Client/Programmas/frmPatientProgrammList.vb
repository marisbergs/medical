Imports Core
Imports Core.UI
Imports Entities
Imports Core.Dal
Imports Core.Bll
Imports Core.Dal.Expressions
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmPatientProgrammList
    Private _criteria As List(Of CriterionBase)
    Private clickPlace As GridHitInfo

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New frmPatientProgrammEdit
        frm.Session = Nothing
        frm.PartnerSession = Session
        Dim data As New Dictionary(Of Type, Guid)
        data.Add(GetType(PatientProgramm), Guid.Empty)
        frm.DataIDs = data
        frm.DataList = bndPatientProgramms
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Open()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bndPatientProgramms.Current Is Nothing Then
            Return
        End If
        Dim o As PatientProgramm = CType(bndPatientProgramms.Current, PatientProgramm)
        If o.CanDelete Then
            If MsgBox.DeleteMessage = Windows.Forms.DialogResult.Yes Then
                o.IsActive = False
                Session.SaveOrUpdate(o)
                Session.Commit()
            End If
        Else
            MsgBox.Show("Klienta programm unav iespējams izdzēst.")
        End If
    End Sub

    Private Sub CtlProgrammFind1_Find(ByVal sender As System.Object, ByVal e As Client.FindEventArgs)
        _criteria = CType(e.Criteria, List(Of Core.Dal.Expressions.CriterionBase))
        Dim programms As New Entities(Of PatientProgramm)
        Session.CreateAndBuildCriteria(Of PatientProgramm)(_criteria).SetFetchMode("Payments", NHibernate.FetchMode.Join).SetFetchMode("Payments", NHibernate.FetchMode.Join).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(programms)
        bndPatientProgramms.DataSource = programms
    End Sub

    Private Sub grdProgramms_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdProgramms.MouseMove
        clickPlace = gvwProgramms.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub gvwProgramms_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvwProgramms.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            Open()
        End If
    End Sub

    Private Sub Open()
        If bndPatientProgramms.Current Is Nothing Then
            Exit Sub
        End If
        Dim _edit As PatientProgramm = CType(bndPatientProgramms.Current, PatientProgramm)
        Dim frm As New frmPatientProgrammEdit
        frm.Session = Nothing
        frm.PartnerSession = Session
        Dim data As New Dictionary(Of Type, Guid)
        data.Add(GetType(PatientProgramm), _edit.Id)
        frm.DataIDs = data
        frmMain.AddChild(frm)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmPatientProgrammList_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Dim crit As List(Of CriterionBase) = New List(Of CriterionBase)()
        crit.Add(New IsNull("DeleteTime"))
        Dim programms As New Entities(Of PatientProgramm)
        Session.CreateAndBuildCriteria(Of PatientProgramm)(crit).SetFetchMode("Payments", NHibernate.FetchMode.Join).SetFetchMode("Payments", NHibernate.FetchMode.Join).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(programms)
        bndPatientProgramms.DataSource = programms
    End Sub
End Class
