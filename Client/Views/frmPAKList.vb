Imports Core.Bll
Imports Entities
Imports Core.Dal

Public Class frmPAKList
    Private lst As Entities(Of PatientProfileDescription)
    Private Sub frmPAKList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _criteria As New List(Of Core.Dal.Expressions.CriterionBase)
        _criteria.Add(New Expressions.IsNull("DeleteTime"))
        lst = New Entities(Of PatientProfileDescription)
        Session.CreateAndBuildCriteria(Of PatientProfileDescription)(_criteria).AddOrder(New NHibernate.Expression.Order("CreateDate", False)).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(lst)
        bndPatientProgramms.DataSource = lst
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If bndPatientProgramms.Current Is Nothing Then
            Return
        End If
        Dim frm As New frmPatientProfileDescription
        frm.Session = Nothing
        frm.PartnerSession = Session
        Dim data As New Dictionary(Of Type, Guid)
        data.Add(GetType(PatientProfileDescription), CType(bndPatientProgramms.Current, PatientProfileDescription).Id)
        frm.DataIDs = data
        frmMain.AddChild(frm)
    End Sub
End Class
