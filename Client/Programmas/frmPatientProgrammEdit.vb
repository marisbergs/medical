Imports Entities
Imports Core.UI

Public Class frmPatientProgrammEdit
    Implements IEditForm

    Private _edit As PatientProgramm
    Private _dataList As IList
    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return Nothing
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(PatientProgramm)) = Guid.Empty Then 'add new
                _edit = New PatientProgramm(Session)
                chkNeedChecks.ForeColor = Color.Red
            Else 'edit existing
                _edit = Session.Get(Of PatientProgramm)(value(GetType(PatientProgramm)))
            End If
            bndPatientProgramm.DataSource = _edit
            bndPatientProgrammServices.DataSource = _edit.Services
            bndPatientProgrammPayment.DataSource = _edit.Payments
            gbhPaymentService.ShowActive = True
            gbhServices.ShowActive = True
            gbhPaymentService.Controls.SetChildIndex(btnOpenPaymentdetails, 2)
        End Set
    End Property

    Public Property DataList() As System.Collections.IList Implements Core.UI.IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As IList)
            _dataList = value
        End Set
    End Property

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not _edit.IsValid Then
            MsgBox.Show("Pirms saglabāšanas izlabojiet ievadlauku kļūdas.")
            Exit Sub
        End If
        Dim jauns As Boolean = False
        If _edit.Id = Guid.Empty Then
            jauns = True
        End If
        Session.SaveOrUpdate(_edit)
        Session.Commit()
        If jauns Then
            DataList.Add(PartnerSession.Get(Of PatientProgramm)(_edit.Id))
        End If
    End Sub

    Private Sub btnProgramma_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnProgramma.ButtonClick
        If (Not _edit.UsageStatus = UsageStatus.Created) Then
            MsgBox.Show("Programmu var mainīt tikai programmai ar statusu jauna.")
            Return
        End If
        If (_edit.Patient Is Nothing) Then
            MsgBox.Show("Pirms izvēlēties programmu norādiet klientu.")
            Return
        End If

        Dim frm As New frmProgrammTemplateList(True)
        frm.Session = Session
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            _edit.ProgrammTemplate = frm.SelectedProgramm
            ''aizpildam visu pakalpojumu sarakstu, reižuu skaitu un cenu
            _edit.Price = _edit.ProgrammTemplate.Price
            For Each s As ProgrammTemplateService In frm.SelectedProgramm.Servicves.ActiveItemsWithoutEmpty

                Dim obj As New PatientProgrammService(Session)
                obj.Service = s.Service
                obj.Price = s.Price
                obj.Count = s.Count
                _edit.Services.Add(obj)
            Next
        End If
    End Sub

    Private Sub btnOpenPaymentdetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenPaymentdetails.Click
        OpenPaymentDetail(False)
    End Sub
    Private Sub OpenPaymentDetail(ByVal newRecord As Boolean)
        If _edit.Id = Guid.Empty Then
            MsgBox.Show("Pirms pievienot maks'jumu saglabājiet izveidoto programmu.")
            Exit Sub
        End If
        Dim frm As New frmPatientProgrammPayment
        frm.Session = Nothing
        frm.PartnerSession = Session
        Dim data As New Dictionary(Of Type, Guid)
        data.Add(GetType(PatientProgramm), _edit.Id)
        If newRecord Then
            data.Add(GetType(PatientProgrammPayment), Guid.Empty)
        Else
            If bndPatientProgrammPayment.Current Is Nothing Then
                Exit Sub
            End If
            Dim _edits As PatientProgrammPayment = CType(bndPatientProgrammPayment.Current, PatientProgrammPayment)
            data.Add(GetType(PatientProgrammPayment), _edits.Id)
        End If
        frm.DataIDs = data
        frm.DataList = bndPatientProgrammPayment
        frmMain.AddChild(frm)
    End Sub

    Private Sub gbhPaymentService_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhPaymentService.OnAddNew
        If _edit.ProgrammTemplate Is Nothing Then
            Exit Sub
        End If
        OpenPaymentDetail(True)
    End Sub

    Private Sub gbhPaymentService_OnDelete(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.DeleteEventArgs) Handles gbhPaymentService.OnDelete
        If bndPatientProgrammPayment.Current Is Nothing Then
            Exit Sub
        End If
        Dim obj As PatientProgrammPayment = CType(bndPatientProgrammPayment.Current, PatientProgrammPayment)
        If obj.PaymentDate.HasValue Then
            MsgBox.Show("Apmaksātu maksājumu dzēst nevar.")
            args.CancelDelete = True
            Exit Sub
        End If
        args.CancelDelete = False
    End Sub

    Private Sub gbhServices_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhServices.OnAddNew
        'Dim frm As frmClassifierList
        'Dim EntityType As System.Type = GetType(Services)

        'frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session)
        'CType(frm, frmClassifierList).FormMode = ClassifierListMode.MultiSelect

        'Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        'Dim obj As IList(Of Guid) = New List(Of Guid)
        'For Each x As UserService In Visit.Doctor.UserServices.ActiveItemsWithoutEmpty
        '    If Not x.Service Is Nothing AndAlso Not obj.Contains(x.Service.Id) Then
        '        obj.Add(x.Service.Id)
        '    End If
        'Next
        ''Dim services As Entities(Of Services) = Entities(Of Services).GetAll(Session, New Expressions.NotIn("ReferenceSecond.Id", ServiceTypes.DoctorVisit), New Expressions.IsNull("DeleteTime"))

        ''For Each x As Services In services
        ''    If (Not obj.Contains(x.Id)) Then
        ''        obj.Add(x.Id)
        ''    End If
        ''Next

        'For Each x As VisitService In Visit.VisitServices.ActiveItemsWithoutEmpty
        '    If (obj.Contains(x.Service.Id)) Then
        '        obj.Remove(x.Service.Id)
        '    End If
        'Next

        'selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        'selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseInClassifier", True))
        'CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        'frm.Selection = Nothing
        'If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    For Each x As Services In CType(frm.Selection, Entities(Of Services))
        '        AddService(x)
        '    Next
        'End If
    End Sub
End Class
