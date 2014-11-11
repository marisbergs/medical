Imports Entities
Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.UI
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmCampaignPatients
    Implements IEditForm
    Public _campaign As Campaign
    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Private clickPlace As GridHitInfo

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            'Return Nothing
            Return _dataIDs
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(Campaign)) = Guid.Empty Then 'add new campaign
                _campaign = New Campaign(Session)
            Else 'edit existing User
                _campaign = Session.Get(Of Campaign)(value(GetType(Campaign)))
            End If
            bndCampaign.DataSource = _campaign
        End Set
    End Property
    Public Property DataList() As System.Collections.IList Implements Core.UI.IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As System.Collections.IList)
            _dataList = value
        End Set
    End Property

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not _campaign.IsValid Then
            Core.UI.MsgBox.HasErrorMessage()
            Return
        End If
        For Each p As CampaignPatient In _campaign.CampaignPatients
            If Not p.IsValid Then
                Core.UI.MsgBox.HasErrorMessage()
                CampaignPatientsBindingSource.Position = CampaignPatientsBindingSource.IndexOf(p)
                Return
            End If
        Next
        Dim jauns As Boolean = (_campaign.Id = Guid.Empty)
        If (jauns) Then
            _campaign.CreateDate = Now
            _campaign.CreateUser = Context.Current.AuthenticatedUser
        End If
        Session.SaveOrUpdate(_campaign)
        For Each patient1 As CampaignPatient In _campaign.CampaignPatients
            Session.SaveOrUpdate(patient1)
        Next
        Session.Commit()
        If (jauns AndAlso Not _dataList Is Nothing) Then
            _dataList.Add(PartnerSession.Get(Of Campaign)(_campaign.Id))
        End If
    End Sub

    Private Sub gbhCampaignPatients_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhCampaignPatients.OnAddNew
        Dim frm As New frmPatients(Entities.ClassifierType.FromType(GetType(Patient), Session), Session, ClassifierListMode.MultiSelect)
        frm.gvwPatients.OptionsView.ShowAutoFilterRow = True
        frm.gvwPatients.Focus()
        frm.FormMode = ClassifierListMode.MultiSelect
        frm.SetVisibleSelectDeselectAllButtonForMultiselect()
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each o As Patient In CType(frm.Selection, Entities(Of Patient))
                Dim eksiste As Boolean = False
                For Each o1 As CampaignPatient In _campaign.CampaignPatients.ActiveItemsWithoutEmpty
                    If Not o1.Patient Is Nothing AndAlso o1.Patient.Id = o.Id Then
                        eksiste = True
                    End If
                Next
                If (Not eksiste) Then
                    Dim obj As New CampaignPatient
                    obj.Patient = o
                    obj.Campaign = _campaign
                    obj.CampaignValue = _campaign.CampaignValue
                    obj.ValidFrom = _campaign.ValidFrom
                    obj.ValidTo = _campaign.ValidTo
                    obj.Discount = _campaign.Discount
                    obj.CreateUser = Context.Current.AuthenticatedUser
                    obj.CreateDate = Now
                    _campaign.CampaignPatients.Add(obj)
                End If
            Next
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        grdCampaignPatients.Export()
    End Sub

    Private Sub btnOpenPatientCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenPatientCard.Click
        Open()
    End Sub

    Private Sub gvwCampaignPatients_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvwCampaignPatients.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            Open()
        End If
    End Sub

    Private Sub gvwCampaignPatients_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvwCampaignPatients.MouseMove
        clickPlace = gvwCampaignPatients.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub Open()
        If CampaignPatientsBindingSource.Current Is Nothing Then
            Return
        End If
        Dim curr As CampaignPatient = CType(CampaignPatientsBindingSource.Current, CampaignPatient)
        Dim frm As New frmTree
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        key.Add(GetType(Patient), curr.Patient.Id)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnAddNewClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewClient.Click
        Dim frm As New frmTree
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = New List(Of Patient)
        key.Add(GetType(Patient), Guid.Empty)
        frm.DataIDs = key
        frm.ShowDialog()
        If Not frm._patient.Id = Guid.Empty AndAlso Not String.IsNullOrEmpty(frm._patient.NumberTemporary) Then
            Dim obj As New CampaignPatient
            obj.Patient = frm._patient
            obj.Campaign = _campaign
            obj.CampaignValue = _campaign.CampaignValue
            obj.ValidFrom = _campaign.ValidFrom
            obj.ValidTo = _campaign.ValidTo
            obj.Discount = _campaign.Discount
            obj.CreateUser = Context.Current.AuthenticatedUser
            obj.CreateDate = Now
            _campaign.CampaignPatients.Add(obj)
        End If
    End Sub
End Class