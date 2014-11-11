Imports Core
Imports Core.Dal
Imports Core.Bll
Imports System.Diagnostics
Imports Entities
Imports Core.UI
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.IO
Imports System
Imports NHibernate
Imports System.Text
Imports System.Data.SqlTypes


Public Class frmVisits
    Private clickPlace As GridHitInfo

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenVisit()
    End Sub

    Private Sub OpenVisit()
        If bndPatients.Current Is Nothing Then Return
        If Not Context.Current.AuthenticatedUser.Position Is Nothing AndAlso Context.Current.AuthenticatedUser.Position.Mark AndAlso Context.Current.AuthenticatedUser.Id = CType(bndPatients.Current, Visit).Doctor.Id Then
            Dim frm As New frmNorikojumi
            frm.Visit = CType(bndPatients.Current, Visit)
            frm.Session = Nothing
            frm.PartnerSession = Session
            frm.DataIDs = New Dictionary(Of Type, Guid)()
            frmMain.AddChild(frm)
        Else
            Dim frm As New frmVisitEdit
            frm.visit = CType(bndPatients.Current, Visit)
            frm.Session = Nothing
            frm.PartnerSession = Session
            frmMain.AddChild(frm)

        End If
    End Sub

    Private _criteria As New List(Of Core.Dal.Expressions.CriterionBase)
    Private Sub CtlVisitsFinder1_Find(ByVal sender As System.Object, ByVal e As Client.FindEventArgs) Handles CtlVisitsFinder1.Find
        _criteria = CType(e.Criteria, List(Of Core.Dal.Expressions.CriterionBase))
        Dim visits As New Entities(Of Visit)
        Entities(Of Services).GetAll(Session, New Expressions.IsNull("DeleteTime"))
        Session.CreateAndBuildCriteria(Of Visit)(_criteria).SetResultTransformer(CriteriaUtil.DistinctRootEntity).List(visits) '.AddOrder(NHibernate.Expression.Order.Asc("Doctor")).AddOrder(NHibernate.Expression.Order.Asc("StartTime")).List(visits)

        For Each visit As Visit In visits
            Dim lst As List(Of Guid) = New List(Of Guid)
            Dim vss As IChildCollection(Of VisitService) = New ChildCollection(Of VisitService)
            For Each s As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
                If (Not lst.Contains(s.Id)) Then
                    lst.Add(s.Id)
                    vss.Add(s)
                End If
            Next
            If Not visit.VisitServices.ActiveItemsWithoutEmpty.Count = vss.Count Then
                visit.VisitServices.Clear()
                For Each o As VisitService In vss
                    visit.VisitServices.Add(o)
                Next
            End If
        Next

        bndPatients.Sort = "Doctor, StartTime"
        bndPatients.DataSource = visits
        colDeletedBy.Visible = Not CtlVisitsFinder1.chkActive.Checked
        Dim crit As Entities.VisitsFinder = CType(CtlVisitsFinder1.bndFind.Current, Entities.VisitsFinder)

        ''CAST(FLOOR(CAST(a.event_date AS FLOAT))AS DATETIME)
        ''citu dienu ieņēmumi
        Dim desc As New StringBuilder()
        Dim vis As New List(Of Guid)
        Try
            If crit.UseStartDate AndAlso PermissionsChecker.CanDo("Visit.ShowAllPrice") Then
                Dim c As New List(Of Core.Dal.Expressions.CriterionBase)
                c.Add(New Expressions.Eq("Payd", True))
                c.Add(New Expressions.IsNull("Visit.DeleteTime"))
                c.Add(New Expressions.Between("PaydDate", crit.DateTimeFrom, IIf(crit.DateTimeTo.HasValue, crit.DateTimeTo.Value.AddSeconds(-1), crit.DateTimeTo)))
                c.Add(New Expressions.Not( _
                New Expressions.Between("Visit.StartTime", crit.DateTimeFrom, IIf(crit.DateTimeTo.HasValue, crit.DateTimeTo.Value.AddSeconds(-1), crit.DateTimeTo))))
                'c.Add(New Expressions.Eq("Payd", True))
                'c.Add(New Expressions.IsNull("Visit.DeleteTime"))
                'c.Add(New Expressions.Between("PaydDate", crit.DateTimeFrom, crit.DateTimeTo))
                'c.Add(New Expressions.Between("Visit.StartTime", crit.DateTimeFrom, crit.DateTimeTo))
                'c.Add(New Expressions.Sql("CAST(FLOOR(CAST(this_.VSS_PAYD_DATE AS FLOAT))AS DATETIME) <> CAST(FLOOR(CAST(VIS_START_TIME AS FLOAT))AS DATETIME)"))
                Dim lst As Entities(Of VisitService)
                lst = Entities(Of VisitService).GetAll(Session, c)
                Dim sum As Decimal = 0
                For Each service As VisitService In lst
                    If service.PaymentType.Id = PaymentType.Cash Then
                        If (Not vis.Contains(service.Visit.Id)) Then
                            vis.Add(service.Visit.Id)
                            desc.AppendFormat("Vizītes datums: '{0}' klients: {1} ārsts: {2}", service.Visit.StartTime, service.Visit.Patient.FullName, service.Visit.Doctor)
                            desc.AppendLine()
                        End If
                        sum += service.Price
                        If service.Insurance.HasValue Then
                            sum += service.Insurance.Value
                        End If
                    End If
                Next
                If sum > 0 Then
                    lblSum.Text = "Ieņēmumi no citu dienu vizītēm: " & sum
                    ToolTipController1.SetToolTip(lblSum, desc.ToString())
                Else
                    lblSum.Text = "Ieņēmumi no citu dienu vizītēm: 0,00"
                    ToolTipController1.SetToolTip(lblSum, "")
                End If
            End If

        Catch ex As Exception
            lblSum.Text = "Aprēķins beidzās ar kļûdu"
        End Try

        ''ieņēmumi no abonementiem
        If crit.UseStartDate AndAlso PermissionsChecker.CanDo("Visit.ShowAllPrice") Then
            Dim c As New List(Of Core.Dal.Expressions.CriterionBase)
            If (crit.DateTimeTo.HasValue) Then
                c.Add(New Expressions.Between("PayTime", crit.DateTimeFrom, crit.DateTimeTo.Value.AddSeconds(-1)))
            Else
                c.Add(New Expressions.Between("PayTime", crit.DateTimeFrom, SqlDateTime.MaxValue.Value))
            End If
            c.Add(New Expressions.IsNull("DeleteTime"))
            Dim lst As Entities(Of Subscription)
            lst = Entities(Of Subscription).GetAll(Session, c)
            Dim s As Decimal = 0
            For Each subscription As Subscription In lst
                s += subscription.Price
            Next

            If s > 0 Then
                lblSubscription.Text = "Ieņēmumi no abonementiem: " & s
            Else
                lblSubscription.Text = "Ieņēmumi no abonementiem: 0,00"
            End If
        End If

        ''ieņēmumi no primārās aprûpes kartēm
        If crit.UseStartDate AndAlso PermissionsChecker.CanDo("Visit.ShowAllPrice") Then
            Dim c As New List(Of Core.Dal.Expressions.CriterionBase)
            If (crit.DateTimeTo.HasValue) Then
                c.Add(New Expressions.Between("PayDate", crit.DateTimeFrom, crit.DateTimeTo.Value.AddSeconds(-1)))
            Else
                c.Add(New Expressions.Between("PayDate", crit.DateTimeFrom, SqlDateTime.MaxValue.Value))
            End If
            c.Add(New Expressions.IsNull("DeleteTime"))
            Dim lst As Entities(Of PatientProfileDescription)
            lst = Entities(Of PatientProfileDescription).GetAll(Session, c)
            Dim s As Decimal = 0
            For Each prof As PatientProfileDescription In lst
                s += prof.Price
            Next

            If s > 0 Then
                lblPrimarasAprupesKartes.Text = "No PAK: " & s
            Else
                lblPrimarasAprupesKartes.Text = "No PAK: 0,00"
            End If
        End If

        ''ieņēmumi no dāvanu kartēm
        If crit.UseStartDate AndAlso PermissionsChecker.CanDo("Visit.ShowAllPrice") Then
            Dim c As New List(Of Core.Dal.Expressions.CriterionBase)
            If (crit.DateTimeTo.HasValue) Then
                c.Add(New Expressions.Between("PayDate", crit.DateTimeFrom, crit.DateTimeTo.Value.AddSeconds(-1)))
            Else
                c.Add(New Expressions.Between("PayDate", crit.DateTimeFrom, SqlDateTime.MaxValue.Value))
            End If
            c.Add(New Expressions.IsNull("DeleteTime"))
            Dim lst As Entities(Of PresentCard)
            lst = Entities(Of PresentCard).GetAll(Session, c)
            Dim s As Decimal = 0
            For Each prof As PresentCard In lst
                If (prof.Status = PresentCardState.Nopirkta) Then
                    s += prof.Price
                End If
            Next

            If s > 0 Then
                lblPresnetCards.Text = "No dāvanu kartēm: " & s
            Else
                lblPresnetCards.Text = "No dāvanu kartēm: 0,00"
            End If
        End If

        ''ieņēmumi no programmām
        If crit.UseStartDate AndAlso PermissionsChecker.CanDo("Visit.ShowAllPrice") Then
            Dim c As New List(Of Core.Dal.Expressions.CriterionBase)
            If (crit.DateTimeTo.HasValue) Then
                c.Add(New Expressions.Between("PaymentDate", crit.DateTimeFrom, crit.DateTimeTo.Value.AddSeconds(-1)))
            Else
                c.Add(New Expressions.Between("PaymentDate", crit.DateTimeFrom, SqlDateTime.MaxValue.Value))
            End If
            c.Add(New Expressions.IsNull("DeleteTime"))
            Dim lst As Entities(Of PatientProgrammPayment)
            lst = Entities(Of PatientProgrammPayment).GetAll(Session, c)
            Dim s As Decimal = 0
            For Each prof As PatientProgrammPayment In lst
                For Each ps As PatientProgrammPaymentService In prof.PaymentServices
                    If ps.Price.HasValue Then
                        s += ps.Price
                    End If
                Next
            Next

            If s > 0 Then
                lblProgramms.Text = "No programmām: " & s
            Else
                lblProgramms.Text = "No programmām: 0,00"
            End If
        End If

        ''ieņēmumi no kosmētikas
        If crit.UseStartDate AndAlso PermissionsChecker.CanDo("Visit.ShowAllPrice") Then
            Dim c As New List(Of Expressions.CriterionBase)
            If (crit.DateTimeTo.HasValue) Then
                c.Add(New Expressions.Between("PaymentDate", crit.DateTimeFrom, crit.DateTimeTo.Value.AddSeconds(-1)))
            Else
                c.Add(New Expressions.Between("PaymentDate", crit.DateTimeFrom, SqlDateTime.MaxValue.Value))
            End If
            c.Add(New Expressions.IsNull("DeleteTime"))
            Dim lst As Entities(Of Sale)
            lst = Entities(Of Sale).GetAll(Session, c)
            Dim s As Decimal = 0
            For Each prof As Sale In lst
                For Each o As SaleProduct In prof.Products
                    s += o.Total
                Next
            Next

            If s > 0 Then
                lblCosmetics.Text = "No kosmētikas: " & s
            Else
                lblCosmetics.Text = "No kosmētikas: 0,00"
            End If
        End If

    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        grdPatients.Export()
    End Sub

    Private Sub gvwPatients_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvwPatients.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            OpenVisit()
        End If
    End Sub

    Private Sub grdPatients_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdPatients.MouseMove
        clickPlace = gvwPatients.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub frmVisits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vis As Boolean = PermissionsChecker.CanDo("Visit.ShowAllPrice")
        'If vis Then
        '    gvwPatients.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        'Else
        '    gvwPatients.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden
        'End If
        colPrice.Visible = vis
        colPayd.Visible = vis
        colTotal.Visible = vis
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub rbtGroupByHour_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGroupByHour.CheckedChanged
        Group()
    End Sub

    Private Sub rbtGroupByDoctor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGroupByDoctor.CheckedChanged
        Group()
    End Sub

    Private Sub gvwPatients_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gvwPatients.RowStyle
        If e.RowHandle < 0 Then
            Return
        End If
        If Not CType(gvwPatients.GetRow(e.RowHandle), Visit).PrepareCard Then
            e.Appearance.BackColor = Color.Red
            e.Appearance.BackColor2 = Color.Red
            Return
        End If
        If Not chkColor.Checked Then
            Return
        End If
        If Not CType(gvwPatients.GetRow(e.RowHandle), Visit).PrepareCard Then
            e.Appearance.BackColor = Color.Red
            e.Appearance.BackColor2 = Color.Red
            Return
        End If
        If CType(gvwPatients.GetRow(e.RowHandle), Visit).EndTime < DateTime.Now Then
            e.Appearance.BackColor = Color.Gainsboro
            e.Appearance.BackColor2 = Color.Gainsboro
        ElseIf CType(gvwPatients.GetRow(e.RowHandle), Visit).StartTime < DateTime.Now AndAlso CType(gvwPatients.GetRow(e.RowHandle), Visit).EndTime > DateTime.Now Then
            e.Appearance.BackColor = Color.Yellow
            e.Appearance.BackColor2 = Color.Yellow
        Else
            e.Appearance.BackColor = Color.Transparent
            e.Appearance.BackColor2 = Color.Transparent
        End If
    End Sub

    Private Sub chkColor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkColor.CheckedChanged
        gvwPatients.Focus()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim template As Template = Session.Get(Of Template)(template.Visits)
        If template Is Nothing Then
            Return
        End If
        Session.Refresh(template)
        Dim templateStream As Stream = template.CurrentVersion.File.Content.GetAsStream()
        Dim context As New Hashtable
        Dim lst As New SortedDictionary(Of String, Entities(Of Visit))
        For Each _visit As Visit In bndPatients
            If Not lst.ContainsKey(_visit.Doctor.FullName) Then
                lst.Add(_visit.Doctor.FullName, New Entities(Of Visit)())
            End If
            lst(_visit.Doctor.FullName).Add(_visit)
        Next
        Dim vizites As New Entities(Of Visit)
        Dim zobarstaVizites As New Entities(Of Visit)
        For Each pair As KeyValuePair(Of String, Entities(Of Visit)) In lst
            For Each visit1 As Visit In pair.Value
                If (visit1.SplitServicesByType AndAlso visit1.Dentist.Count = 0) Then
                    vizites.Add(visit1)
                Else
                    zobarstaVizites.Add(visit1)
                End If
            Next
        Next

        context.Add("D04", New ExportCollection(vizites, zobarstaVizites))

        Dim vis As New Visit(Session)
        ''vis.StartTime

        Dim fileName As String = Path.GetTempFileName() + ".rtf"
        Core.Reporting.Report.CreateReport(templateStream, fileName, context)
        Dim File As BinaryFile = New BinaryFile(Session, fileName)
        Dim tempPath As String = System.IO.Path.GetTempPath + Guid.NewGuid().ToString() + File.Name
        File.Content.SaveToFile(tempPath)
        Core.Helper.RunShell(tempPath)
    End Sub

    Private Sub chkShowCreator_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowCreator.CheckedChanged
        colCreator.Visible = chkShowCreator.Checked
    End Sub

    Private Sub btnExportToWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportToWord.Click
        Dim list As New SortedDictionary(Of String, SortedDictionary(Of DateTime, List(Of Visit)))
        Dim data As New SortedDictionary(Of String, SortedDictionary(Of DateTime, List(Of Visit)))
        For Each visit As Visit In bndPatients
            If Not list.ContainsKey(Helper.ToRtfString(visit.Doctor.FullName)) Then
                list.Add(Helper.ToRtfString(visit.Doctor.FullName), New SortedDictionary(Of DateTime, List(Of Visit)))
            End If
            If Not list(Helper.ToRtfString(visit.Doctor.FullName)).ContainsKey(visit.StartTime) Then
                list(Helper.ToRtfString(visit.Doctor.FullName)).Add(visit.StartTime, New List(Of Visit))
            End If
            list(Helper.ToRtfString(visit.Doctor.FullName))(visit.StartTime).Add(visit)
        Next

        For Each o As KeyValuePair(Of String, SortedDictionary(Of DateTime, List(Of Visit))) In list
            Dim sum As Decimal = 0
            For Each x As KeyValuePair(Of DateTime, List(Of Visit)) In o.Value
                For Each v As Visit In x.Value
                    If v.Price.HasValue Then
                        sum += v.Price
                    End If
                Next
            Next
            data.Add(o.Key & Helper.ToRtfString(" - summa kopā: ") & New Visit(Session).FF(sum, "f"), o.Value)
        Next

        Dim template As Template = Session.Get(Of Template)(New Guid("A8953459-FABF-4D37-BC0F-9ACD0185BBC1"))
        Session.Refresh(template)

        Dim templateStream As IO.Stream = template.CurrentVersion.File.Content.GetAsStream()
        Dim context As New Hashtable
        context.Add("P05", data)

        Dim fileName As String = IO.Path.GetTempFileName() + ".rtf"
        Core.Reporting.Report.CreateReport(templateStream, fileName, context)
        Dim File As BinaryFile = New BinaryFile(Session, fileName)
        Dim tempPath As String = System.IO.Path.GetTempPath + Guid.NewGuid().ToString() + File.Name
        File.Content.SaveToFile(tempPath)
        Core.Helper.RunShell(tempPath)
    End Sub

    Private Sub rbtGroupByDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGroupByDay.CheckedChanged
        Group()
    End Sub

    Private Sub Group()
        If rbtGroupByDoctor.Checked Then
            colStundas.UnGroup()
            colStartTime.UnGroup()
            colDoctor.Group()
        ElseIf rbtGroupByHour.Checked Then
            colStundas.Group()
            colStartTime.UnGroup()
            colDoctor.UnGroup()
        ElseIf rbtGroupByDay.Checked Then
            colStundas.UnGroup()
            colStartTime.Group()
            colDoctor.UnGroup()
        ElseIf rbtRemoveGrouping.Checked Then
            colStundas.UnGroup()
            colStartTime.UnGroup()
            colDoctor.UnGroup()
            colPatientNumber.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        End If
    End Sub

    Private Sub itmPrepareCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmPrepareCard.Click
        If bndPatients.Current Is Nothing Then
            Return
        End If
        CType(bndPatients.Current, Visit).PrepareCard = True
        Session.SaveOrUpdate(bndPatients.Current)
        Session.Commit()
    End Sub

    Private Sub rbtRemoveGrouping_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtRemoveGrouping.CheckedChanged

    End Sub

    Private Sub chkPaymentDetails_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPaymentDetails.CheckedChanged
        colCatch.Visible = chkPaymentDetails.Checked
        colInsurance.Visible = chkPaymentDetails.Checked
        colInsuranceName.Visible = chkPaymentDetails.Checked
        colPresentCard.Visible = chkPaymentDetails.Checked
        colBonusPoints.Visible = chkPaymentDetails.Checked
    End Sub

    Private Sub chkVisitServices_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVisitServices.CheckedChanged
        gvwPatients.OptionsDetail.EnableMasterViewMode = chkVisitServices.Checked
        gvwPatients.OptionsView.ShowDetailButtons = chkVisitServices.Checked
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (bndPatients.Current Is Nothing) Then
            Exit Sub
        End If
        If (Not MsgBox.DeleteMessage() = Windows.Forms.DialogResult.Yes) Then
            Exit Sub
        End If
        Dim s As Dal.ISession = Manager.Instance.OpenSession()
        Dim vis As Visit = s.Get(Of Visit)(CType(bndPatients.Current, Visit).Id)
        For Each service As VisitService In vis.VisitServices
            service.IsActive = False
        Next
        vis.IsActive = False
        s.SaveOrUpdate(vis)
        s.Commit()
    End Sub

    Private Sub EksportētUzExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EksportētUzExcelToolStripMenuItem.Click
        grdPatients.Export()
    End Sub
End Class

Public Class ExportCollection

    Private _firstCollection As Entities(Of Visit)
    Private _secondCollection As Entities(Of Visit)

    Public Sub New(ByVal firstCollection As Entities(Of Visit), ByVal secondCollection As Entities(Of Visit))
        _firstCollection = firstCollection
        _secondCollection = secondCollection
    End Sub

    Public ReadOnly Property FirstCollection() As Entities(Of Visit)
        Get
            Return _firstCollection
        End Get
    End Property
    Public ReadOnly Property SecondCollection() As Entities(Of Visit)
        Get
            Return _secondCollection
        End Get
    End Property

End Class
