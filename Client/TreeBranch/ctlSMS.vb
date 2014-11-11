Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Entities
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class ctlSMS
    Private list As Entities(Of SMSSendingList)
    Private clickPlace As GridHitInfo

    Private previousVisits As Boolean
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal previous As Boolean)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        previousVisits = previous

    End Sub

    Private Sub ctlPrescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim parent As frmTree = CType(FindForm(), frmTree)
        If parent._patient Is Nothing Then Return

        Dim criteria As IList(Of Expressions.CriterionBase)
        criteria = New List(Of Expressions.CriterionBase)
        criteria.Add(New Expressions.Eq("Patient", parent._patient))
        criteria.Add(New Expressions.IsNull("DeleteTime"))

        list = Entities(Of SMSSendingList).GetAll(parent.Session, criteria)

        bndSMS.DataSource = list
        bndSMS.Sort = "SendTime desc"
    End Sub

    Private Sub grdPrescription_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdSMS.MouseMove
        clickPlace = gvwSMS.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub gvwPrescription_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvwSMS.DoubleClick
        'If clickPlace Is Nothing Then
        '    Return
        'End If
        ''If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        'If clickPlace.HitTest = GridHitTest.RowCell Then
        '    Open()
        'End If
    End Sub

    Private Sub Open()
        If bndSMS.Current Is Nothing Then
            Exit Sub
        End If
        Dim _edit As Visit = CType(bndSMS.Current, Visit)
        Dim frm As New frmVisitEdit
        frm.Session = Nothing
        frm.PartnerSession = CType(FindForm(), frmBase).Session
        frm.visit = _edit
        frmMain.AddChild(frm)
    End Sub
End Class
