Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.UI
Imports Entities
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmSubscription

    Dim list As Entities(Of PresentCard)
    Private visitList As Entities(Of Visit)
    Private clickPlace As Object

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmSubscription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New frmSubscriptionDetail
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(bndData.DataSource, IList)
        key.Add(GetType(Subscription), Guid.Empty)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub txtService_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.SingleSelect)

        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseIsPresentCard", True))

        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim card As PresentCard = CType(bndData.Current, PresentCard)
            card.Service = CType(frm.Selection, Services)
            card.Price = card.Service.DecimalValue
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        grdData.Export()
    End Sub

    Private Sub CtlSubscriptionFind1_Find(ByVal sender As System.Object, ByVal e As Client.FindEventArgs) Handles CtlSubscriptionFind1.Find
        _criteria = CType(e.Criteria, List(Of Core.Dal.Expressions.CriterionBase))
        Dim _subscription As New Entities(Of Subscription)
        Session.CreateAndBuildCriteria(Of Subscription)(_criteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).SetFetchMode("UserAcceptedPayment.Position", NHibernate.FetchMode.Select).List(_subscription)
        bndData.DataSource = _subscription
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenSubscription()
    End Sub
    Private Sub OpenSubscription()
        If bndData.Current Is Nothing Then
            Return
        End If
        Dim frm As New frmSubscriptionDetail
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(bndData.DataSource, IList)
        key.Add(GetType(Subscription), CType(Me.bndData.Current, Subscription).Id)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub grdData_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdData.MouseMove
        clickPlace = gvwSubscription.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub gvwSubscription_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvwSubscription.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            OpenSubscription()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bndData.Current Is Nothing Then
            Return
        End If
        Dim _subscription As Subscription = CType(bndData.Current, Subscription)
        If _subscription.PayTime.HasValue AndAlso Not _subscription.UserAcceptedPayment Is Nothing Then
            If MsgBox.Show("Abonementam jau ir veikta apmaksa. Vai tiešām vēlaties to dzēst?", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If
        End If
        For Each detail As SubscriptionDetail In _subscription.SubscriptionDetail
            If Not detail.Visit Is Nothing Then
                MsgBox.Show("Abonementu nav iespējams dzēst jo kāda no abonementa reizēm jau ir piesaistīta vizītei.")
                Return
            End If
        Next
        If Not MsgBox.DeleteMessage = DialogResult.Yes Then
            Return
        End If

        _subscription.IsActive = False
        Session.SaveOrUpdate(_subscription)

        For Each detail As SubscriptionDetail In _subscription.SubscriptionDetail
            detail.IsActive = False
            Session.SaveOrUpdate(detail)
        Next

        Session.Commit()
    End Sub
End Class
