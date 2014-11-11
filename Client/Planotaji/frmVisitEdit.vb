Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.UI
Imports Entities
Imports System.IO
Imports NHibernate.Expression


Public Class frmVisitEdit

    Public visit As Visit
    Public serviceId As Guid
    Public patient1 As Patient
    Public patient2 As Patient
    Public patient3 As Patient
    Public tempVisit As Visit
    Private cash As PaymentType = Session.Get(Of PaymentType)(PaymentType.Cash)
    Private transfer As PaymentType = Session.Get(Of PaymentType)(PaymentType.Transfer)
    Private Abonements As PaymentType = Session.Get(Of PaymentType)(PaymentType.Abonements)
    Private Programma As PaymentType = Session.Get(Of PaymentType)(PaymentType.Programma)
    Private PAK As PaymentType = Session.Get(Of PaymentType)(PaymentType.PAK)
    Private Akcija As PaymentType = Session.Get(Of PaymentType)(PaymentType.Akcija)
    Private Barters As PaymentType = Session.Get(Of PaymentType)(PaymentType.Barters)
    Private Kupons As PaymentType = Session.Get(Of PaymentType)(PaymentType.Kupons)

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        gbhVisitServices.Controls.SetChildIndex(btnAddNewService, 1)
        gbhVisitServices.Controls.SetChildIndex(btnAddNewVisit, 2)
        gbhVisitServices.ShowActive = True

        cmbPaymentType.Items.Add(cash)
        cmbPaymentType.Items.Add(transfer)
        cmbPaymentType.Items.Add(Abonements)
        cmbPaymentType.Items.Add(Programma)
        cmbPaymentType.Items.Add(PAK)
        cmbPaymentType.Items.Add(Akcija)
        cmbPaymentType.Items.Add(Barters)
        cmbPaymentType.Items.Add(Kupons)
        cmbPaymentTypeRelatedSevice.Items.Add(cash)
        cmbPaymentTypeRelatedSevice.Items.Add(transfer)
        cmbPaymentTypeRelatedSevice.Items.Add(Abonements)
        cmbPaymentTypeRelatedSevice.Items.Add(Programma)
        cmbPaymentTypeRelatedSevice.Items.Add(PAK)
        cmbPaymentTypeRelatedSevice.Items.Add(Akcija)
        cmbPaymentTypeRelatedSevice.Items.Add(Barters)
        cmbPaymentTypeRelatedSevice.Items.Add(Kupons)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not visit.IsValid Then
            Core.UI.MsgBox.HasErrorMessage()
            Return
        End If
        If visit.Id = Guid.Empty Then
            If Not visit.Patient Is Nothing AndAlso visit.Patient.BlackList Then
                MsgBox.Show("Klients(e) " & visit.Patient.FullName & "  ir bloķēts un iekļauts melnajā sarakstā. Jaunu vizīti šim klientam nav iespējams ieplānot.")
                Return
            End If
            If Not visit.PatientSecond Is Nothing AndAlso visit.PatientSecond.BlackList Then
                MsgBox.Show("Klients(e) " & visit.PatientSecond.FullName & "  ir bloķēts un iekļauts melnajā sarakstā. Jaunu vizīti šim klientam nav iespējams ieplānot.")
                Return
            End If
            If Not visit.PatientThird Is Nothing AndAlso visit.PatientThird.BlackList Then
                MsgBox.Show("Klients(e) " & visit.PatientThird.FullName & "  ir bloķēts un iekļauts melnajā sarakstā. Jaunu vizīti šim klientam nav iespējams ieplānot.")
                Return
            End If
        End If
        For Each x As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
            If Not x.IsValid Then
                Core.UI.MsgBox.HasErrorMessage()
                Return
            End If
        Next
        If Not visit.Group Then
            If visit.CheckInterval = True Then
                Core.UI.MsgBox.Show("šis laiks jau ir aizņemts.")
                Return
            End If
        End If
        Dim worktimeList As Entities(Of WorkTime)
        worktimeList = Entities(Of WorkTime).GetAll(Session, New Expressions.Eq("Id", visit.ParentId))
        If worktimeList.Count > 0 Then
            If visit.StartTime < worktimeList(0).StartTime OrElse visit.EndTime > worktimeList(0).EndTime Then
                Core.UI.MsgBox.Show("Ârsta darba laiks ir no " & worktimeList(0).StartTime.ToShortDateString() & " " & worktimeList(0).StartTime.ToShortTimeString() & " līdz " & worktimeList(0).EndTime.ToShortDateString() & " " & worktimeList(0).StartTime.ToShortTimeString() & ".")
                Return
            End If
        End If
        Dim userWorkTime As Entities(Of UsersWorkTime)
        userWorkTime = Entities(Of UsersWorkTime).GetAll(Session, New Expressions.Eq("Id", visit.ParentId))
        If userWorkTime.Count > 0 Then
            If visit.StartTime.TimeOfDay < userWorkTime(0).StartTime.TimeOfDay OrElse visit.EndTime.TimeOfDay > userWorkTime(0).EndTime.TimeOfDay Then
                Core.UI.MsgBox.Show("Ârsta darba laiks ir no " & userWorkTime(0).StartTime.ToShortTimeString() & " līdz " & userWorkTime(0).EndTime.ToShortTimeString() & ".")
                Return
            End If
        End If

        Dim regVisits As Entities(Of Visit)
        regVisits = Entities(Of Visit).GetAll(Session, _
                New Expressions.Eq("Patient", visit.Patient), _
                New Expressions.NotEq("Id", visit.Id), _
                New Expressions.IsNull("DeleteTime"), _
                New Expressions.Not(New Expressions.Ge("StartTime", visit.EndTime)), _
                New Expressions.Not(New Expressions.Le("EndTime", visit.StartTime)))
        If regVisits.Count > 0 Then
            Core.UI.MsgBox.Show("Šim klientam jau ir ieplānota vizīte laikā no " & regVisits(0).StartTime.ToShortTimeString() & " līd " & regVisits(0).EndTime.ToShortTimeString())
            Return
        End If
        ''skatamies vai pakalpojumam ir piesaistīts resurss
        '' ja ir tad pārbaudam vai kāds no resursiem ir brīvs
        ''jāpārbauda jebkura vizīte kas iekrīt šinī laikā
        For Each vs As VisitService In visit.VisitServices
            If Not vs.Service.ReferenceFive Is Nothing Then
                Dim resurceVisits As Entities(Of Visit)
                Dim crit As New List(Of Expressions.CriterionBase)
                crit.Add(New Expressions.Eq("VisitServices.Service.ReferenceFive", vs.Service.ReferenceFive))
                crit.Add(New Expressions.Not(New Expressions.Ge("StartTime", visit.EndTime)))
                crit.Add(New Expressions.Not(New Expressions.Le("EndTime", visit.StartTime)))
                crit.Add(New Expressions.IsNull("DeleteTime"))
                crit.Add(New Expressions.NotEq("Id", visit.Id))
                resurceVisits = Entities(Of Visit).GetAll(Session, crit)
                If (resurceVisits.Count = vs.Service.ReferenceFive.SecondIntegerValue.Value) Then
                    MsgBox.Show("Nav brīva resursa (iekārtas) '" & vs.Service.ReferenceFive.Value & "', kas nepieciešama šai vizītei.")
                    Return
                End If

            End If
        Next
        If (visit.Patient.AviableBonusPoints(visit.Id) < visit.BonusPointsUsed) Then
            Core.UI.MsgBox.Show("Apmaksai izmatntoto bonusa punktu skaits ir lielāks nekā uzkrāts. Trûkst " & (visit.BonusPointsUsed - visit.Patient.AviableBonusPoints(visit.Id)) & " punkti.")
            Return
        End If
        If visit.BonusPointsUsed > 0 Then
            Dim bp As BonusPoints = Session.Get(Of BonusPoints)(visit.Id)
            Dim lstBP As Entities(Of BonusPoints)
            lstBP = Entities(Of BonusPoints).GetAll(Session, New Expressions.Eq("Visit.Id", visit.Id), New Expressions.IsNull("DeleteTime"), New Expressions.Eq("BonusPointType", BonusPointType.Use))
            If lstBP.Count > 0 Then
                lstBP(0).Value = visit.BonusPointsUsed
            ElseIf lstBP.Count = 0 Then
                bp = New BonusPoints(Session)
                bp.Value = visit.BonusPointsUsed
                bp.User = Context.Current.AuthenticatedUser
                bp.Visit = visit
                bp.BonusPointType = BonusPointType.Use
                bp.EventDate = Now
                visit.Patient.BonusPointsUse.Add(bp)
            End If
        End If
        Session.SaveOrUpdate(visit)
        For Each x As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
            Session.SaveOrUpdate(x)
        Next
        Session.Commit()
    End Sub

    Private Sub frmVisitEdit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Session.Clear()
    End Sub

    Private Sub frmVisitEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If visit Is Nothing Then
            Dim res As WorkTime = CType(Tag, WorkTime)
            visit = New Visit(Session)
            visit.Acyity = res.Acity
            visit.Room = res.Room
            visit.Doctor = res.User
            visit.EndT = res.EndTime
            If Not patient1 Is Nothing Then
                Session.Refresh(patient1)
            End If
            If Not patient2 Is Nothing Then
                Session.Refresh(patient2)
            End If
            If Not patient3 Is Nothing Then
                Session.Refresh(patient3)
            End If
            visit.Patient = patient1
            visit.PatientSecond = patient2
            visit.PatientThird = patient3
            visit.Service = Session.Get(Of Services)(serviceId)
            visit.CreatePlace = LocalSettings.GetValueByKey(Session, SystemInformation.ComputerName).Value
            visit.GroupId = Guid.NewGuid()
            AddService(visit.Service)

            Dim userServices As Entities(Of UserService) = Entities(Of UserService).GetAll(Session, New Expressions.Eq("User.Id", visit.Doctor.Id), New Expressions.Eq("Service.Id", visit.Service.Id))
            For Each x As UserService In userServices
                If x.ManualTime.HasValue Then
                    visit.Length = x.ManualTime.Value
                Else
                    visit.Length = visit.Service.IntegerValue
                End If
                If x.Service.SecondIntegerValue.HasValue Then
                    visit.LengthBefore = x.Service.SecondIntegerValue.Value
                End If
                If x.Service.ThirdIntegerValue.HasValue Then
                    visit.LengthAfter = x.Service.ThirdIntegerValue.Value
                End If
            Next
            visit.StartTime = res.StartTime
            visit.Start = res.StartTime
            If Not res.Id = Guid.Empty Then
                visit.ParentId = res.Id
            Else
                visit.ParentId = res.UserWorkTime.Id
            End If
        Else
            If Not visit.Id = Guid.Empty Then
                visit = Session.Get(Of Visit)(visit.Id)
            End If
            If Not visit.GroupWork Is Nothing Then
                TimeEdit1.Enabled = False
                TimeEdit2.Enabled = False
            Else
                If visit.Length = 0 OrElse visit.Id = Guid.Empty Then
                    Dim userServices As Entities(Of UserService) = Entities(Of UserService).GetAll(Session, New Expressions.Eq("User.Id", visit.Doctor.Id), New Expressions.Eq("Service.Id", visit.Service.Id))
                    For Each x As UserService In userServices
                        If x.ManualTime.HasValue Then
                            visit.Length = x.ManualTime.Value
                        Else
                            visit.Length = visit.Service.IntegerValue
                        End If
                        If x.Service.SecondIntegerValue.HasValue Then
                            visit.LengthBefore = x.Service.SecondIntegerValue.Value
                        End If
                        If x.Service.ThirdIntegerValue.HasValue Then
                            visit.LengthAfter = x.Service.ThirdIntegerValue.Value
                        End If
                    Next
                End If
            End If
        End If
        bndData.DataSource = visit
        Text += " " & visit.StartTime.Date.ToShortDateString
        If visit.Group Then
            TimeEdit1.Enabled = False
            TimeEdit2.Enabled = False
        End If
        If Not visit.GroupWork Is Nothing Then
            colGroupWork.Visible = True
            colService.Visible = False
            gbhVisitServices.Enabled = False
        Else
            colGroupWork.Visible = False
            colService.Visible = True
        End If
        If Not visit.Patient Is Nothing Then
            Dim v As Entities(Of Visit)
            Dim vs As New Entities(Of VisitService)
            v = Entities(Of Visit).GetAll(Session, New Expressions.NotEq("Id", visit.Id), New Expressions.Eq("Patient", visit.Patient), New Expressions.Between("StartTime", visit.StartTime.Date, visit.StartTime.Date.AddDays(1)), New Expressions.IsNull("DeleteTime"))
            For Each visit1 As Visit In v
                For Each service As VisitService In visit1.VisitServices.ActiveItemsWithoutEmpty
                    vs.Add(service)
                Next
            Next
            bndRelatedVisits.DataSource = vs
        End If
        colPayd.OptionsColumn.ReadOnly = Not PermissionsChecker.CanDo("Visit.CanAcceptPayment")
        BandedGridColumn26.OptionsColumn.ReadOnly = Not PermissionsChecker.CanDo("Visit.CanAcceptPayment")
        BandedGridColumn3.OptionsColumn.ReadOnly = Not PermissionsChecker.CanDo("Visit.ChangePayDate")
        BandedGridColumn4.OptionsColumn.ReadOnly = Not PermissionsChecker.CanDo("Visit.ChangePayDate")
        btnPay.Enabled = PermissionsChecker.CanDo("Visit.CanAcceptPayment")
        If Not visit.Patient Is Nothing Then
            PatientBindingSource.DataSource = visit.Patient
        End If
        ''pārbaudām vai klientam nav peisaistīta kāda akcija
        ReadCampaign()

    End Sub

    Private Sub ReadCampaign()
        If Not visit.Patient Is Nothing Then
            If visit.CampaignPatient Is Nothing Then
                Dim lst As Entities(Of CampaignPatient)
                lst = Entities(Of CampaignPatient).GetAll(Session, New Expressions.Le("ValidFrom", visit.StartTime.Date), New Expressions.Ge("ValidTo", visit.StartTime.Date), New Expressions.Eq("Patient", visit.Patient), New Expressions.IsNull("DeleteTime"))
                If lst.Count > 0 Then
                    'ja akcija norādīta ierobežojuma summa atrodam visas vizītes un saskaitam smmu
                    If lst(0).CampaignValue > 0 Then
                        lblCampaignSumm.Visible = True
                        txtCampaignSumm.Visible = True
                        Dim vizites As Entities(Of Visit)
                        vizites = Entities(Of Visit).GetAll(Session, New Expressions.Eq("CampaignPatient.Id", lst(0).Id), New Expressions.IsNull("DeleteTime"))
                        Dim summa As Decimal = 0
                        For Each visit1 As Visit In vizites
                            For Each _visitService As VisitService In visit1.VisitServices.ActiveItemsWithoutEmpty
                                ''ja pakalpojumam vēl nav pazīme, ka tas ir sniegts tad
                                If Not _visitService.ServiceGiven Then
                                    '' ja vizītes beigu laikam pieliekam 2 stundas un šis laiks vēl nav pagājis, 
                                    '' tad uzskatam ka pakalpojumu vēl ir iespējams sniegt un summējam klāt
                                    If visit1.EndTime.AddHours(2) >= Now Then
                                        summa += _visitService.Price
                                        '' ja laiks ir pagājis uzskatam ka pakalpojums nav sniegts un ņemam nākamo
                                    Else
                                        Exit For
                                    End If
                                End If
                                summa += _visitService.Price
                            Next
                        Next
                        txtCampaignSumm.Text = Decimal.Round(lst(0).CampaignValue - summa, 2)
                    Else
                        lblCampaignSumm.Visible = False
                        txtCampaignSumm.Visible = False
                    End If
                    chkCampaign.Visible = True
                    lblCampaignName.Text = String.Format(CStr(lblCampaignName.Tag), lst(0).Campaign.Name)
                    lblCampaignName.Visible = True
                Else
                    chkCampaign.Visible = False
                    lblCampaignSumm.Visible = False
                    txtCampaignSumm.Visible = False
                    lblCampaignName.Visible = False
                End If
            Else
                chkCampaign.Checked = True
                chkCampaign.Visible = True
                lblCampaignName.Text = String.Format(CStr(lblCampaignName.Tag), visit.CampaignPatient.Campaign.Name)
                lblCampaignName.Visible = True
                ''ja akcija norādīta ierobežojuma summa atrodam visas vizītes un saskaitam smmu
                If visit.CampaignPatient.CampaignValue > 0 Then
                    lblCampaignSumm.Visible = True
                    txtCampaignSumm.Visible = True
                    Dim vizites As Entities(Of Visit)
                    vizites = Entities(Of Visit).GetAll(Session, New Expressions.Eq("CampaignPatient.Id", visit.CampaignPatient.Id), New Expressions.IsNull("DeleteTime"))
                    Dim summa As Decimal = 0
                    For Each visit1 As Visit In vizites
                        'Session.Refresh(visit1)
                        For Each _visitService As VisitService In visit1.VisitServices.ActiveItemsWithoutEmpty
                            ''ja pakalpojumam vēl nav pazīme, ka tas ir sniegts tad
                            If Not _visitService.ServiceGiven Then
                                '' ja vizītes beigu laikam pieliekam 2 stundas un šis laiks vēl nav pagājis, 
                                '' tad uzskatam ka pakalpojumu vēl ir iespējams sniegt un summējam klāt
                                If visit1.EndTime.AddHours(2) >= Now Then
                                    summa += _visitService.Price
                                    '' ja laiks ir pagājis uzskatam ka pakalpojums nav sniegts un ņemam nākamo
                                Else
                                    Exit For
                                End If
                            End If
                            summa += _visitService.Price
                        Next
                    Next
                    txtCampaignSumm.Text = Decimal.Round(visit.CampaignPatient.CampaignValue - summa, 2)
                Else
                    lblCampaignSumm.Visible = False
                    txtCampaignSumm.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        If visit.CheckInterval = True Then
            Core.UI.MsgBox.Show("Šis laiks jau ir aizņemts.")
        Else
            Core.UI.MsgBox.Show("Norādītais laiks ir pieejams.")
        End If
    End Sub

    Private Sub txtDoctor_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDoctor.ButtonClick
        Dim frm As New frmUsers
        frm.FormMode = ClassifierListMode.SingleSelect

        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        obj.Add(visit.Service.Id)
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Services", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseServices", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif

        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
            visit.Doctor = CType(frm.Selection, User)
            Dim userServices As Entities(Of UserService) = Entities(Of UserService).GetAll(Session, New Expressions.Eq("User.Id", visit.Doctor.Id), New Expressions.Eq("Service.Id", visit.Service.Id))
            For Each x As UserService In userServices
                If x.ManualTime.HasValue Then
                    visit.Length = x.ManualTime.Value
                Else
                    visit.Length = x.Service.IntegerValue.Value
                End If
                If x.Service.SecondIntegerValue.HasValue Then
                    visit.LengthBefore = x.Service.SecondIntegerValue.Value
                Else
                    visit.LengthBefore = 0
                End If
                If x.Service.ThirdIntegerValue.HasValue Then
                    visit.LengthAfter = x.Service.ThirdIntegerValue.Value
                Else
                    visit.LengthBefore = 0
                End If
            Next
            visit.StartTime = visit.StartTime
        End If
    End Sub

    Private Sub btnOpenPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenPatient.Click
        If visit.Patient Is Nothing Then
            Return
        End If
        Dim frm As New frmTree
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        key.Add(GetType(Patient), visit.Patient.Id)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnState.Click
        Me.cmsState.Items.Clear()
        For Each status As Statuss In visit.Status.Status
            'If Not status.Value = DocumentStatusEnum.Draft And Not status.Value = DocumentStatusEnum.Sent Then
            Dim itm As New ToolStripMenuItem()
            itm.Tag = status
            itm.Name = status.Value
            itm.Text = status.Value
            Me.cmsState.Items.Add(itm)
            'End If
        Next

        Me.btnState.ContextMenuStrip = cmsState
        Me.btnState.ContextMenuStrip.Show(Me.btnState, 0, Me.btnState.Height)
        Me.btnState.ContextMenuStrip = Nothing
    End Sub

    Private Sub txtServiceCol_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtServiceCol.ButtonClick
        If visit.Group Then
            Return
        End If
        Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(Services), Session), Session, ClassifierListMode.SingleSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As UserService In visit.Doctor.UserServices.ActiveItemsWithoutEmpty
            If Not x.Service Is Nothing AndAlso Not obj.Contains(x.Service.Id) Then
                obj.Add(x.Service.Id)
            End If
        Next

        'For Each x As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
        '    If (obj.Contains(x.Service.Id)) Then
        '        obj.Remove(x.Service.Id)
        '    End If
        'Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseInClassifier", True))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("ValidAt", visit.StartTime.Date))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
            Dim v As Visit = CType(bndData.Current, Visit)
            Dim z As VisitService = CType(VisitServicesBindingSource.Current, VisitService)
            Dim x As Services = CType(frm.Selection, Services)
            If (z.Service.Id = v.Service.Id) Then
                v.Service = x
            End If
            z.Service = x
            If x.Reference Is Nothing Then
                z.Percentage = Nothing
            Else
                z.Percentage = x.Reference.DecimalValue
            End If
            Dim found As Boolean = False
            For Each j As UserService In visit.Doctor.UserServices.ActiveItemsWithoutEmpty
                If j.Service.Id = x.Id Then
                    found = True
                    If j.ManualPrice.HasValue Then
                        z.Price = j.ManualPrice.Value
                    Else
                        z.Price = x.DecimalValue
                    End If
                    Exit For
                End If
            Next
            If Not found Then
                z.Price = x.DecimalValue
            End If
            z.DefaultPrice = z.Price
        End If
    End Sub

    Private Sub txtServiceCol_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtServiceCol.KeyDown
        If e.KeyCode = Keys.Delete Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = Nothing
        End If
    End Sub

    Private Sub gbhVisitServices_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhVisitServices.OnAddNew
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As UserService In visit.Doctor.UserServices.ActiveItemsWithoutEmpty
            If Not x.Service Is Nothing AndAlso Not obj.Contains(x.Service.Id) Then
                obj.Add(x.Service.Id)
            End If
        Next
        'Dim services As Entities(Of Services) = Entities(Of Services).GetAll(Session, New Expressions.NotIn("ReferenceSecond.Id", ServiceTypes.DoctorVisit), New Expressions.IsNull("DeleteTime"))

        'For Each x As Services In services
        '    If (Not obj.Contains(x.Id)) Then
        '        obj.Add(x.Id)
        '    End If
        'Next

        'For Each x As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
        '    If (obj.Contains(x.Service.Id)) Then
        '        obj.Remove(x.Service.Id)
        '    End If
        'Next

        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseInClassifier", True))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("ValidAt", visit.StartTime.Date))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each x As Services In CType(frm.Selection, Entities(Of Services))
                AddService(x)
                FindProgramm()
            Next
        End If
    End Sub

    Private Sub AddService(ByVal x As Services)
        Dim item As New VisitService(Session)
        item.Service = x
        If x.Reference Is Nothing Then
            item.Percentage = Nothing
        Else
            item.Percentage = x.Reference.DecimalValue
        End If
        Dim found As Boolean = False
        For Each z As UserService In visit.Doctor.UserServices.ActiveItemsWithoutEmpty
            If z.Service.Id = x.Id Then
                found = True
                If z.ManualPrice.HasValue Then
                    item.Price = z.ManualPrice.Value
                Else
                    item.Price = x.DecimalValue
                End If
                Exit For
            End If
        Next
        If Not found Then
            item.Price = x.DecimalValue
        End If
        item.DefaultPrice = item.Price
        If (Not visit.Patient Is Nothing) Then
            If visit.Patient.Discount.HasValue AndAlso visit.Patient.Discount.Value > 0 Then
                item.Price = item.Price - (item.Price * (visit.Patient.Discount.Value / 100))
            End If
        End If
        visit.VisitServices.Add(item)
    End Sub

    Private Sub txtPatient_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtPatient.ButtonClick
        Dim frm As New frmPatients(Entities.ClassifierType.FromType(GetType(Patient), Session), Session, ClassifierListMode.MultiSelect)
        frm.gvwPatients.OptionsView.ShowAutoFilterRow = True
        frm.gvwPatients.Focus()
        frm.canAddNew = True
        frm.Visit = visit
        frm.FormMode = ClassifierListMode.MultiSelect
        Dim list As New Entities(Of Patient)
        If Not visit.Patient Is Nothing Then
            list.Add(visit.Patient)
        End If
        If Not visit.PatientSecond Is Nothing Then
            list.Add(visit.PatientSecond)
        End If
        If Not visit.PatientThird Is Nothing Then
            list.Add(visit.PatientThird)
        End If
        frm.selectedPatientList = list
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim i As Integer = 0
            For Each x As Patient In frm.Selection
                If x.BlackList Then
                    MsgBox.Show("Klients(e) " & x.FullName & "  ir bloķēts un iekļauts melnajā sarakstā. Jaunu vizīti šim klientam nav iespējams ieplānot.")
                    Continue For
                End If
                i += 1
                If i = 1 Then
                    visit.Patient = x
                    FindPatientProgramm()
                ElseIf i = 2 Then
                    visit.PatientSecond = x
                ElseIf i = 3 Then
                    visit.PatientThird = x
                ElseIf i > 3 Then
                    MsgBox.Show("Vizītei vienlaicīgi var pievienot tikai 3 klientus.")
                    Exit For
                End If
            Next
            If Not visit.Patient Is Nothing Then
                bndRelatedVisits.DataSource = Entities(Of VisitService).GetAll(Session, New Expressions.NotEq("Visit.Id", visit.Id), New Expressions.Eq("Visit.Patient.Id", visit.Patient.Id), New Expressions.Between("Visit.StartTime", visit.StartTime.Date, visit.StartTime.Date.AddDays(1)), New Expressions.IsNull("DeleteTime"))
                For Each item As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
                    If item.Price > 0 AndAlso visit.Patient.Discount.HasValue Then
                        item.Price = item.Price - (item.Price * (visit.Patient.Discount.Value / 100))
                    End If
                Next
            End If
            If Not visit.Patient Is Nothing Then
                PatientBindingSource.DataSource = visit.Patient
            End If
            ReadCampaign()
        End If
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click

        If Not Core.UI.MsgBox.Show("Vai tiešām vēlaties veikt apmaksu?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Return
        End If
        Dim count As Integer = 0
        For Each x As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
            If (x.Payd) Then
                count += 1
            End If
        Next x
        For Each x As VisitService In bndRelatedVisits.List
            If (x.Payd) Then
                count += 1
            End If
        Next x
        If count = (visit.VisitServices.ActiveItemsWithoutEmpty.Count + bndRelatedVisits.Count) Then
            MsgBox.Show("Visi pakalpojumi jau ir apmaksāti.")
            Return
        End If
        Dim file As String = System.IO.File.ReadAllText("C:\chd3550\fiscal\SALE.TXT")
        file = file.Replace("$vards", visit.Patient.Name & IIf(String.IsNullOrEmpty(visit.Patient.SecondName), "", " " & visit.Patient.SecondName))
        file = file.Replace("$uzvards", visit.Patient.Surname)
        file = file.Replace("$kods", visit.Patient.Code)
        file = file.Replace("$adrese", IIf(String.IsNullOrEmpty(visit.Patient.Address), "", visit.Patient.Address))
        Dim start As Integer = file.IndexOf("$01")
        Dim beigas As Integer = file.IndexOf("$_")
        Dim str As String = file.Substring(start, beigas - start + 2)
        Dim res As New System.Text.StringBuilder()
        For Each x As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
            If (Not x.Payd) Then
                If Not x.Price > 0 AndAlso Not x.Insurance.HasValue AndAlso x.Insurance.Value > 0 Then
                    x.Payd = True
                    Continue For
                End If
                Dim temp As String
                Dim name As New System.Text.StringBuilder()
                If (x.Service.Value.Length <= 31) Then
                    name.Append("Comment: Text = """ & x.Service.Value & """")
                Else
                    For i As Integer = 0 To x.Service.Value.Length Step 31
                        If x.Service.Value.Length > i + 31 Then
                            name.AppendLine("Comment: Text = """ & x.Service.Value.Substring(i, 31) & """")
                        Else
                            name.Append("Comment: Text = """ & x.Service.Value.Substring(i) & """")
                        End If
                    Next i
                End If
                temp = str.Replace("$pakalpojums", name.ToString())
                temp = temp.Replace("$_", "")
                temp = temp.Replace("$01", "")
                If x.Service.Reference Is Nothing Then
                    temp = temp.Replace("$nodala", "5")
                Else
                    temp = temp.Replace("$nodala", x.Service.Reference.Code)
                End If
                Dim t As String = temp
                Dim cena As String = x.Price.ToString()
                If x.Price > 0 Then
                    If cena.Contains(".") OrElse cena.Contains(",") Then
                        If cena.Contains(",") Then
                            cena = cena.Replace(",", ".")
                        End If
                        If cena.Length - cena.IndexOf(".") < 3 Then
                            cena &= "0"
                        End If
                    Else
                        cena &= ".00"
                    End If
                    temp = temp.Replace("$cena", cena)
                    temp = temp.Replace("$PakalpojumaKods", x.Service.Code)
                    res.AppendLine(temp)
                End If
                If (x.Insurance.HasValue AndAlso x.Insurance.Value > 0) Then
                    cena = x.Insurance.Value.ToString()
                    If cena.Contains(".") OrElse cena.Contains(",") Then
                        If cena.Contains(",") Then
                            cena = cena.Replace(",", ".")
                        End If
                        If cena.Length - cena.IndexOf(".") < 3 Then
                            cena &= "0"
                        End If
                    Else
                        cena &= ".00"
                    End If
                    t = t.Replace("$cena", cena)
                    t = t.Replace("$PakalpojumaKods", x.Service.Code)
                    res.AppendLine(t)
                End If
                x.Payd = True
                x.ServiceGiven = True
                x.PaymentType = Session.Get(Of PaymentType)(PaymentType.Cash)
            End If
        Next
        For Each x As VisitService In bndRelatedVisits
            If (Not x.Payd) Then
                If Not x.Price > 0 AndAlso Not x.Insurance.HasValue AndAlso x.Insurance.Value > 0 Then
                    x.Payd = True
                    Continue For
                End If
                Dim temp As String
                Dim name As New System.Text.StringBuilder()
                If (x.Service.Value.Length <= 31) Then
                    name.Append("Comment: Text = """ & x.Service.Value & """")
                Else
                    For i As Integer = 0 To x.Service.Value.Length Step 31
                        If x.Service.Value.Length > i + 31 Then
                            name.AppendLine("Comment: Text = """ & x.Service.Value.Substring(i, 31) & """")
                        Else
                            name.Append("Comment: Text = """ & x.Service.Value.Substring(i) & """")
                        End If
                    Next i
                End If
                temp = str.Replace("$pakalpojums", name.ToString())
                temp = temp.Replace("$_", "")
                temp = temp.Replace("$01", "")
                If x.Service.Reference Is Nothing Then
                    temp = temp.Replace("$nodala", "5")
                Else
                    temp = temp.Replace("$nodala", x.Service.Reference.Code)
                End If
                Dim t As String = temp
                Dim cena As String = x.Price.ToString()
                If x.Price > 0 Then
                    If cena.Contains(".") OrElse cena.Contains(",") Then
                        If cena.Contains(",") Then
                            cena = cena.Replace(",", ".")
                        End If
                        If cena.Length - cena.IndexOf(".") < 3 Then
                            cena &= "0"
                        End If
                    Else
                        cena &= ".00"
                    End If
                    temp = temp.Replace("$cena", cena)
                    temp = temp.Replace("$PakalpojumaKods", x.Service.Code)
                    res.AppendLine(temp)
                End If
                If (x.Insurance.HasValue AndAlso x.Insurance.Value > 0) Then
                    cena = x.Insurance.Value.ToString()
                    If cena.Contains(".") OrElse cena.Contains(",") Then
                        If cena.Contains(",") Then
                            cena = cena.Replace(",", ".")
                        End If
                        If cena.Length - cena.IndexOf(".") < 3 Then
                            cena &= "0"
                        End If
                    Else
                        cena &= ".00"
                    End If
                    t = t.Replace("$cena", cena)
                    t = t.Replace("$PakalpojumaKods", x.Service.Code)
                    res.AppendLine(t)
                End If
                x.Payd = True
                x.ServiceGiven = True
                x.PaymentType = Session.Get(Of PaymentType)(PaymentType.Cash)
            End If
        Next
        file = file.Replace(str, res.ToString().Trim())
        Dim path As String = "RECIPE.TXT"
        System.IO.File.WriteAllText("C:\chd3550\fiscal\" & path, file, System.Text.Encoding.Default)
        Dim command As New System.Text.StringBuilder()
        command.AppendLine("C:")
        command.AppendLine("cd \")
        command.AppendLine("cd chd3550")
        command.AppendLine("cd fiscal")
        command.AppendLine("chd_fdrv.exe " & path)
        System.IO.File.WriteAllText("C:\chd3550\fiscal\cmd.bat", command.ToString())
        Helper.RunShell("C:\chd3550\fiscal\cmd.bat")

        btnSave_Click(btnSave, New EventArgs())
    End Sub

    Private Sub txtService_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtService.ButtonClick
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.SingleSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseIsGroupWork", visit.Group))

        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("ValidAt", visit.StartTime.Date))

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim x As Services = CType(frm.Selection, Services)
            For Each z As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
                If z.Service.Id = visit.Service.Id Then
                    z.Service = x
                    If x.Reference Is Nothing Then
                        z.Percentage = Nothing
                    Else
                        z.Percentage = x.Reference.DecimalValue
                    End If
                    Dim found As Boolean = False
                    For Each j As UserService In visit.Doctor.UserServices.ActiveItemsWithoutEmpty
                        If j.Service.Id = x.Id Then
                            found = True
                            If j.ManualPrice.HasValue Then
                                z.Price = j.ManualPrice.Value
                            Else
                                z.Price = x.DecimalValue
                            End If
                            Exit For
                        End If
                    Next
                    If Not found Then
                        z.Price = x.DecimalValue
                    End If
                    z.DefaultPrice = z.Price
                End If
            Next
            visit.Service = x
        End If
    End Sub

    Private Sub cmsState_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles cmsState.ItemClicked
        visit.Status = CType(e.ClickedItem.Tag, Statuss)
    End Sub

    Private Sub btnAddNewService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewService.Click
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        Dim services As Entities(Of Services) = Entities(Of Services).GetAll(Session, New Expressions.NotIn("ReferenceSecond.Id", ServiceTypes.DoctorVisit), New Expressions.NotEq("ReferenceSecond.Mark", True), New Expressions.IsNull("DeleteTime"))

        For Each x As Services In services
            If (Not obj.Contains(x.Id)) Then
                obj.Add(x.Id)
            End If
        Next
        For Each x As UserService In visit.Doctor.UserServices.ActiveItemsWithoutEmpty
            If (obj.Contains(x.Service.Id)) Then
                obj.Remove(x.Service.Id)
            End If
        Next

        For Each x As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
            If (obj.Contains(x.Service.Id)) Then
                obj.Remove(x.Service.Id)
            End If
        Next

        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseInClassifier", True))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("ValidAt", visit.StartTime.Date))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each x As Services In CType(frm.Selection, Entities(Of Services))
                AddService(x)
            Next
        End If
    End Sub

    Private Sub btnAddNewVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewVisit.Click
        Dim frm As New frmPlanner
        frm.SetPatient(visit.Patient, visit.PatientSecond, visit.PatientThird)
        frm.mcaThisMonth.SetDate(visit.StartTime.Date)
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub VisitServicesBindingSource_ListChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles VisitServicesBindingSource.ListChanged, bndRelatedVisits.ListChanged
        If Not e.PropertyDescriptor Is Nothing AndAlso Not visit.Patient Is Nothing Then
            If e.PropertyDescriptor.Name = "BonusPoints" Then
                If visit.Patient.AviableBonusPoints(visit.Id) = 0 Then
                    Core.UI.MsgBox.Show("Nav bonusu punktu, ko varētu izmantot")
                    For Each x As VisitService In bndRelatedVisits
                        x.BonusPoints = Nothing
                    Next
                    For Each x As VisitService In VisitServicesBindingSource
                        x.BonusPoints = Nothing
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub AdvBandedGridView1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles AdvBandedGridView1.RowCellStyle
        If e.Column.Name = colPrice.Name OrElse e.Column.Name = colInsurance.Name OrElse e.Column.Name = colPresentCardSum.Name OrElse e.Column.Name = colBonusPoints.Name Then
            Dim price As Decimal = 0
            Dim x As VisitService = CType(AdvBandedGridView1.GetRow(e.RowHandle), VisitService)
            price += x.Price
            If x.Insurance.HasValue Then
                price += x.Insurance.Value
            End If
            If x.BonusPoints.HasValue Then
                price += x.BonusPoints.Value
            End If
            If x.PresentCardSum.HasValue Then
                price += x.PresentCardSum.Value
            End If
            If x.DefaultPrice <> price Then
                e.Appearance.BackColor = Color.LightSalmon
            End If
        End If
    End Sub

    Private Sub btnGenerateInsurance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateInsurance.Click
        Me.cmsInsuranceTemplates.Items.Clear()
        Dim templates As Entities(Of Template)
        templates = Entities(Of Template).GetAll(Session, New Expressions.Eq("Type.Id", TemplateType.Insurance), New Expressions.IsNull("DeleteTime"))
        For Each t As Template In templates
            Dim itm As New ToolStripMenuItem()
            itm.Tag = t
            itm.Name = t.Name
            itm.Text = t.Name
            Me.cmsInsuranceTemplates.Items.Add(itm)
        Next

        Me.btnGenerateInsurance.ContextMenuStrip = cmsInsuranceTemplates
        Me.btnGenerateInsurance.ContextMenuStrip.Show(Me.btnGenerateInsurance, 0, Me.btnGenerateInsurance.Height)
        Me.btnGenerateInsurance.ContextMenuStrip = Nothing
    End Sub

    Private Sub cmsInsuranceTemplates_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles cmsInsuranceTemplates.ItemClicked
        cmsInsuranceTemplates.Close()
        Dim template As Template = CType(e.ClickedItem.Tag, Template)
        Session.Refresh(template)
        Dim lst As New Dictionary(Of User, List(Of VisitService))
        For Each o As VisitService In VisitServicesBindingSource
            If o.Insurance.HasValue AndAlso o.IsActive Then
                If Not lst.ContainsKey(o.Visit.Doctor) Then
                    lst.Add(o.Visit.Doctor, New List(Of VisitService)())
                End If
                lst(o.Visit.Doctor).Add(o)
            End If
        Next
        For Each o As VisitService In bndRelatedVisits
            If o.Insurance.HasValue AndAlso o.IsActive Then
                If Not lst.ContainsKey(o.Visit.Doctor) Then
                    lst.Add(o.Visit.Doctor, New List(Of VisitService)())
                End If
                lst(o.Visit.Doctor).Add(o)
            End If
        Next
        For Each pair As KeyValuePair(Of User, List(Of VisitService)) In lst
            Dim templateStream As Stream = template.CurrentVersion.File.Content.GetAsStream()
            Dim context As New Hashtable
            visit.Patient.TotalInsuranceSumm = 0
            For Each service As VisitService In pair.Value
                visit.Patient.TotalInsuranceSumm += service.Insurance.Value
            Next
            context.Add("P1", visit.Patient)
            context.Add("A01", pair.Value)

            Dim fileName As String = Path.GetTempFileName() + ".rtf"
            Core.Reporting.Report.CreateReport(templateStream, fileName, context)
            Dim File As New BinaryFile(Session, fileName)
            If File Is Nothing Then
                Continue For
            End If
            Dim tempPath As String = System.IO.Path.GetTempPath + Guid.NewGuid().ToString() + File.Name
            File.Content.SaveToFile(tempPath)
            Core.Helper.RunShell(tempPath)
        Next
    End Sub

    Private Sub chkCampaign_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCampaign.CheckedChanged
        Dim lst As Entities(Of CampaignPatient)
        lst = Entities(Of CampaignPatient).GetAll(Session, New Expressions.Le("ValidFrom", visit.StartTime.Date), New Expressions.Ge("ValidTo", visit.StartTime.Date), New Expressions.Eq("Patient", visit.Patient), New Expressions.IsNull("DeleteTime"))
        If chkCampaign.Checked Then
            Dim jauna As Boolean = False
            If lst.Count > 0 Then
                If (visit.CampaignPatient Is Nothing) Then
                    visit.CampaignPatient = lst(0)
                    jauna = True
                End If
                ''ja akcija norādīta ierobežojuma summa atrodam visas vizītes un saskaitam smmu
                If visit.CampaignPatient.CampaignValue > 0 Then
                    lblCampaignSumm.Visible = True
                    txtCampaignSumm.Visible = True
                    Dim vizites As Entities(Of Visit)
                    vizites = Entities(Of Visit).GetAll(Session, New Expressions.Eq("CampaignPatient.Id", visit.CampaignPatient.Id), New Expressions.IsNull("DeleteTime"))
                    Dim summa As Decimal = 0
                    ''ejam cauri vizītēm un pakalpojumiem
                    For Each visit1 As Visit In vizites
                        For Each _visitService As VisitService In visit1.VisitServices.ActiveItemsWithoutEmpty
                            ''ja pakalpojumam vēl nav pazīme, ka tas ir sniegts tad
                            If Not _visitService.ServiceGiven Then
                                '' ja vizītes beigu laikam pieliekam 2 stundas un šis laiks vēl nav pagājis, 
                                '' tad uzskatam ka pakalpojumu vēl ir iespējams sniegt un summējam klāt
                                If visit1.EndTime.AddHours(2) >= Now Then
                                    summa += _visitService.Price
                                    '' ja laiks ir pagājis uzskatam ka pakalpojums nav sniegts un ņemam nākamo
                                Else
                                    Exit For
                                End If
                            End If
                            summa += _visitService.Price
                        Next
                    Next
                    For Each service As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
                        summa += service.Price
                        If jauna Then
                            service.Discount = visit.CampaignPatient.Discount
                        End If
                    Next
                    txtCampaignSumm.Text = Decimal.Round(visit.CampaignPatient.CampaignValue - summa, 2)
                Else
                    lblCampaignSumm.Visible = False
                    txtCampaignSumm.Visible = False
                End If
            End If
        Else
            If lst.Count > 0 Then
                visit.CampaignPatient = Nothing
                ''ja akcija norādīta ierobežojuma summa atrodam visas vizītes un saskaitam smmu
                If lst(0).CampaignValue > 0 Then
                    lblCampaignSumm.Visible = True
                    txtCampaignSumm.Visible = True
                    Dim vizites As Entities(Of Visit)
                    vizites = Entities(Of Visit).GetAll(Session, New Expressions.Eq("CampaignPatient.Id", lst(0).Id), New Expressions.IsNull("DeleteTime"))
                    Dim summa As Decimal = 0
                    For Each visit1 As Visit In vizites
                        For Each _visitService As VisitService In visit1.VisitServices.ActiveItemsWithoutEmpty
                            ''ja pakalpojumam vēl nav pazīme, ka tas ir sniegts tad
                            If Not _visitService.ServiceGiven Then
                                '' ja vizītes beigu laikam pieliekam 2 stundas un šis laiks vēl nav pagājis, 
                                '' tad uzskatam ka pakalpojumu vēl ir iespējams sniegt un summējam klāt
                                If visit1.EndTime.AddHours(2) >= Now Then
                                    summa += _visitService.Price
                                    '' ja laiks ir pagājis uzskatam ka pakalpojums nav sniegts un ņemam nākamo
                                Else
                                    Exit For
                                End If
                            End If
                            summa += _visitService.Price
                        Next
                    Next
                    For Each service As VisitService In visit.VisitServices.ActiveItemsWithoutEmpty
                        summa += service.Price
                        service.Discount = 0
                    Next
                    txtCampaignSumm.Text = Decimal.Round(lst(0).CampaignValue - summa, 2)
                Else
                    lblCampaignSumm.Visible = False
                    txtCampaignSumm.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub btnNewWisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewWisit.Click
        Dim frm As New frmPlanner()
        frm.patient1 = visit.Patient
        frm.patient2 = visit.PatientSecond
        frm.patient3 = visit.PatientThird
        frm.SetPatient(visit.Patient, visit.PatientSecond, visit.PatientThird)
        frm.selectedDoctor = visit.Doctor
        frm.Show()
    End Sub

    Private Sub FindProgramm()
        If visit.Patient Is Nothing Or VisitServicesBindingSource.Current Is Nothing Then
            Return
        End If
        ''meklējam programmas
        ''Dim lst As Entities(Of PatientProgramm)
        ''lst = Entities(Of PatientProgramm).GetAllOrderBy(Session, New Order("Payments.PaymentDate", False), New Expressions.Eq("Patient", visit.Patient), New Expressions.Eq("Services.Service.Id", CType(VisitServicesBindingSource.Current, VisitService).Service.Id))
    End Sub

    Private Sub FindPatientProgramm()
        If visit.Patient Is Nothing Then
            Return
        End If
        ''meklējam programmas
        'For Each o As VisitService In VisitServicesBindingSource
        '    Dim lst As Entities(Of PatientProgramm)
        '    Dim crit As New List(Of Expressions.CriterionBase)
        '    crit.Add(New Expressions.Eq("Patient", visit.Patient))
        '    crit.Add(New Expressions.Eq("Services.Service.Id", o.Service.Id))
        '    Session.CreateAndBuildCriteria(Of PatientProgramm)(crit).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(lst)
        'Next
        
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmActivityEdit
        frm.Visit = visit
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        key.Add(GetType(Activity), Guid.Empty)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub txtPresentCard_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtPresentCard.ButtonClick
        Dim frm As New frmPresentCards
        frm.SetSelectionMode()
        If frm.ShowDialog() = DialogResult.OK Then
            Dim vs As VisitService = CType(VisitServicesBindingSource.Current, VisitService)
            vs.PresentCard = frm.SelectedPresentCard
        End If
    End Sub

    Private Sub btnNorikojumi_Click(sender As System.Object, e As System.EventArgs) Handles btnNorikojumi.Click
        If visit.Patient Is Nothing Then
            Return
        End If
        Dim frm As New frmNorikojumi
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        key.Add(GetType(Patient), visit.Patient.Id)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub
End Class