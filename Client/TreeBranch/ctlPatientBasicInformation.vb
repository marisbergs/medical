Imports Entities
Imports Core
Imports Core.UI
Imports Core.Bll
Imports Core.Dal
Imports System.Threading
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class ctlPatientBasicInformation
    Private clickPlace As GridHitInfo


    Private Sub gbhPatientFamily_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhPatientFamily.OnAddNew
        Dim parentForm As frmTree = CType(FindForm(), frmTree)
        Dim frm As New frmPatients(Entities.ClassifierType.FromType(GetType(Patient), CType(FindForm(), frmBase).Session), CType(FindForm(), frmBase).Session, ClassifierListMode.MultiSelect)
        frm.gvwPatients.OptionsView.ShowAutoFilterRow = True
        frm.gvwPatients.Focus()
        frm.canAddNew = False
        frm.FormMode = ClassifierListMode.MultiSelect
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim i As Integer = 0
            For Each x As Patient In frm.Selection
                Dim obj As New PatientFamily(CType(FindForm(), frmBase).Session)
                obj.PatientRelated = x
                parentForm._patient.PatientFamily.Add(obj)
                Dim obj1 As New PatientFamily(CType(FindForm(), frmBase).Session)
                obj1.PatientRelated = parentForm._patient
                x.PatientFamily.Add(obj1)
            Next
        End If
    End Sub

    Private Sub txtKindred_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtKindred.ButtonClick
        Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(Kindred), CType(FindForm(), frmBase).Session), CType(FindForm(), frmBase).Session, ClassifierListMode.SingleSelect)
        frm.FormMode = ClassifierListMode.SingleSelect
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub ctlPatientBasicInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbhPatientFamily.ShowActive = True
        gbhInsurance.ShowActive = True
    End Sub

    Private Sub gbhInfo_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs)
        Dim parentForm As frmTree = CType(FindForm(), frmTree)
        Dim frm As New frmPatientProfileDescription
        frm.Session = Nothing
        frm.PartnerSession = parentForm.Session
        Dim data As New Dictionary(Of Type, Guid)
        data.Add(GetType(PatientProfileDescription), Guid.Empty)

        data.Add(GetType(Patient), CType(bndPatient.Current, Patient).Id)

        frm.DataIDs = data
        frm.DataList = bndPatientCommercInformation.List
        frmMain.AddChild(frm)
    End Sub

    'Private Sub txtUser_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
    '    Dim parentForm As frmTree = CType(FindForm(), frmTree)
    '    Dim frm As New frmUsers(Entities.ClassifierType.FromType(GetType(User), CType(FindForm(), frmBase).Session), CType(FindForm(), frmBase).Session)
    '    frm.GridView1.OptionsView.ShowAutoFilterRow = True
    '    frm.GridView1.Focus()
    '    frm.FormMode = ClassifierListMode.SingleSelect
    '    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
    '    End If
    'End Sub

    Private Sub gbhBPRecive_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs)
        Dim parentForm As frmTree = CType(FindForm(), frmTree)
        Dim bp As New BonusPoints(CType(FindForm(), frmBase).Session)
        bp.BonusPointType = BonusPointType.Add
        bp.User = Context.Current.AuthenticatedUser
        bp.EventDate = DateTime.Now
        parentForm._patient.BonusPointsRecive.Add(bp)
        args.AddedObject = bp
    End Sub

    Private Sub txtInsurance_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtInsurance.ButtonClick
        If (bndInsurance.Current Is Nothing) Then
            Return
        End If
        Dim cur As PatientInsurance = CType(bndInsurance.Current, PatientInsurance)
        Dim frm As New frmHierClassifierList(Entities.ClassifierType.FromType(GetType(Insurance), CType(FindForm(), frmBase).Session), CType(FindForm(), frmBase).Session, ClassifierListMode.SingleSelect)
    frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
            cur.Program = Nothing
            cmbProgram.Items.Clear()
            Dim ins As Insurance = CType(frm.Selection, Insurance)
            cur.Insurance = ins
            Dim lst As Entities(Of Insurance)
            lst = Entities(Of Insurance).GetAll(CType(FindForm(), frmBase).Session, New Expressions.Eq("Parents.Id", ins.Id), New Expressions.IsNull("DeleteTime"))
            For Each x As Insurance In lst
                cmbProgram.Items.Add(x)
            Next
        End If
    End Sub

    Private Sub gbhInsurance_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhInsurance.OnAddNew
        Dim obj As New PatientInsurance(CType(FindForm(), frmBase).Session)
        Dim parentForm As frmTree = CType(FindForm(), frmTree)
        parentForm._patient.Insurance.Add(obj)
        args.AddedObject = obj
    End Sub

    Private Sub cmbPatientType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPatientType.KeyDown
        If e.KeyCode = Keys.Delete AndAlso Not bndPatient.Current Is Nothing Then
            Dim patient As Patient = CType(bndPatient.Current, Patient)
            patient.PatientType = Nothing
        End If
    End Sub

    Private Sub cmbLanguage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbLanguage.KeyDown
        If e.KeyCode = Keys.Delete AndAlso Not bndPatient.Current Is Nothing Then
            Dim patient As Patient = CType(bndPatient.Current, Patient)
            patient.Language = Nothing
        End If
    End Sub

    Private Sub gvwPrimarasAprupesKarte_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            Dim parentForm As frmTree = CType(FindForm(), frmTree)
            Dim frm As New frmPatientProfileDescription
            frm.Session = Nothing
            frm.PartnerSession = parentForm.Session
            Dim data As New Dictionary(Of Type, Guid)
            data.Add(GetType(PatientProfileDescription), CType(bndPatientCommercInformation.Current, PatientProfileDescription).Id)
            frm.DataIDs = data
            frm.DataList = bndPatientCommercInformation.List
            frmMain.AddChild(frm)
        End If
    End Sub

End Class
