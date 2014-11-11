Imports Core.Bll
Imports Entities
Imports Core.UI

Public Class frmSmsSending

    Private Sub GridButtonHelper1_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles GridButtonHelper1.OnAddNew
        Dim frm As New frmPatients(Entities.ClassifierType.FromType(GetType(Patient), Session), Session, ClassifierListMode.MultiSelect)
        frm.gvwPatients.OptionsView.ShowAutoFilterRow = True
        frm.gvwPatients.Focus()
        frm.FormMode = ClassifierListMode.MultiSelect
        frm.SetVisibleSelectDeselectAllButtonForMultiselect()
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each o As Object In frm.Selection
                If Not PatientBindingSource.Contains(o) Then
                    PatientBindingSource.Add(o)
                End If
            Next
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSmsText.TextChanged
        txtSimbolCount.Text = txtSmsText.Text.Length
    End Sub

    Private Sub frmSmsSending_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridButtonHelper1.DeleteButton.Text = "Izņemt"
        dtpSendDate.EditValue = Now.Date
        dtpSendTime.EditValue = Now
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If MsgBox.Show("Vai tiešām vēlaties izņemt šo klientu no saraksta?", MessageBoxButtons.YesNo, "Jautājums") = Windows.Forms.DialogResult.Yes Then
            PatientBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If (TextBox1.Text.Length = 0) Then
            MsgBox.Show("Nav aizpildīts grupas nosaukums. grupas nosaukumu izmantos lai pēc nosûtīšanas varētu atlasīt klientus kuriem tika nosûtīta kāda konkrēta īsziņa.")
            Return
        End If
        If (txtSmsText.Text.Length = 0) Then
            MsgBox.Show("Nav norādīts īsziņas teksts.")
            Return
        End If
        If dtpSendDate.EditValue Is Nothing OrElse dtpSendTime.EditValue Is Nothing Then
            MsgBox.Show("Nav norādīts nosûtīšanas datums vai laiks.")
            Return
        End If
        Dim fullInvalidPatientList As New Entities(Of Patient)
        Dim lst As New Entities(Of Patient)
        For Each patient1 As Patient In PatientBindingSource
            If (String.IsNullOrEmpty(patient1.MobilePhone)) Then
                lst.Add(patient1)
                fullInvalidPatientList.Add(patient1)
            End If
        Next
        If (lst.Count > 0) Then
            If MsgBox.Show(lst.Count & " klientiem nav telefona numuru un īsziņa netiks sûtīta. Vai vēlaties turpināt?", MessageBoxButtons.YesNo, "Jautājums") = Windows.Forms.DialogResult.No Then
                Return
            End If
        End If
        lst = New Entities(Of Patient)

        For Each patient1 As Patient In PatientBindingSource
            If Not String.IsNullOrEmpty(patient1.MobilePhone) Then
                If (patient1.MobilePhone.Length <> 8) Then
                    If (patient1.MobilePhone.Length < 8) Then
                        lst.Add(patient1)
                        If Not fullInvalidPatientList.Contains(patient1) Then
                            fullInvalidPatientList.Add(patient1)
                        End If
                    End If
                Else
                    Dim res As Int64
                    If Not Int64.TryParse(patient1.MobilePhone, res) Then
                        lst.Add(patient1)
                        If Not fullInvalidPatientList.Contains(patient1) Then
                            fullInvalidPatientList.Add(patient1)
                        End If
                    End If
                End If
            End If
        Next
        If (lst.Count > 0) Then
            If MsgBox.Show(lst.Count & " klientiem nav telefona numuri ir nekorekti. Vai vēlaties turpināt?", MessageBoxButtons.YesNo, "Jautājums") = Windows.Forms.DialogResult.No Then
                Return
            End If
        End If
        For Each patient1 As Patient In PatientBindingSource
            If Not fullInvalidPatientList.Contains(patient1) Then
                Dim sms As New SMSSendingList()
                sms.Patient = patient1
                sms.SMSSesion = TextBox1.Text
                sms.Message = txtSmsText.Text
                sms.Sended = SmsSendStatus.NotSent
                sms.SendTime = CDate(dtpSendDate.EditValue).Date.AddHours(CDate(dtpSendTime.EditValue).Hour).AddMinutes(CDate(dtpSendTime.EditValue).Minute)
                patient1.Sms.Add(sms)
                Session.SaveOrUpdate(sms)
                Session.Commit()
            End If
        Next
    End Sub
End Class
