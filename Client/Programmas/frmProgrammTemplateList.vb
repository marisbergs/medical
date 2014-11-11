
Imports Entities
Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.Dal.Expressions
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmProgrammTemplateList

    Public SelectedProgramm As ProgrammTemplate
    Private clickPlace As GridHitInfo

    Public Sub New(ByVal selectProgramm As Boolean)
        InitializeComponent()
        If selectProgramm Then
            btnOk.Visible = True
            btnAdd.Visible = False
            btnDelete.Visible = False
            btnOpen.Visible = False
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmProgrammTemplateList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''bndProgrammTemplate.DataSource = Entities(Of ProgrammTemplate).GetAll(Session, New IsNull("DeleteTime"))
        Dim crit As New List(Of Core.Dal.Expressions.CriterionBase)
        crit.Add(New IsNull("DeleteTime"))
        Dim list As New Entities(Of ProgrammTemplate)
        Session.CreateAndBuildCriteria(Of ProgrammTemplate)(crit).SetFetchMode("PaymentServices", NHibernate.FetchMode.Join).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(list)
        bndProgrammTemplate.DataSource = list
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New frmProgrammTemplateEdit()
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(bndProgrammTemplate.DataSource, IList)
        key.Add(GetType(ProgrammTemplate), Guid.Empty)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If bndProgrammTemplate.Current Is Nothing Then
            Return
        End If
        Dim itm As ProgrammTemplate = CType(bndProgrammTemplate.Current, ProgrammTemplate)
        Dim frm As New frmProgrammTemplateEdit()
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(bndProgrammTemplate.DataSource, IList)
        key.Add(GetType(ProgrammTemplate), itm.Id)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bndProgrammTemplate.Current Is Nothing Then
            Return
        End If
        Dim answer As DialogResult = Core.UI.MsgBox.Show("Vai tiešām vēlaties dzēst šo programmas aprakstu?", MessageBoxButtons.YesNo, "Jautājums")
        If answer = Windows.Forms.DialogResult.Yes Then
            Dim obj As ProgrammTemplate = CType(bndProgrammTemplate.Current, ProgrammTemplate)
            obj.IsActive = False
            Session.SaveOrUpdate(obj)
            Session.Commit()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If bndProgrammTemplate.Current Is Nothing Then
            SelectedProgramm = Nothing
        Else
            SelectedProgramm = CType(bndProgrammTemplate.Current, ProgrammTemplate)
        End If
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub CoreGrid1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CoreGrid1.MouseMove
        clickPlace = GridView1.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            btnOpen.PerformClick()
        End If
    End Sub
End Class
