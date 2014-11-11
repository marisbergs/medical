Option Strict On

Imports Core.Bll
Imports Core.Dal
Imports System.Web.Services.Discovery

Public Class frmSystemParameters


    Dim systemParams As New Dictionary(Of String, Entities.SystemParameter)
    Dim coll As Entities(Of Entities.SystemParameter)
    Dim param As Entities.SystemParameter
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub frmSystemParameters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        coll = Entities(Of Entities.SystemParameter).GetAll(Session)
        For Each par As Entities.SystemParameter In coll
            systemParams.Add(par.Id, par)
        Next

        txtFrequence.EditValue = systemParams("USER_WORK_FREQUENCE").Value

        txtPlanerStartTime.EditValue = systemParams("PLANER_TIME_START").ParamDate
        txtPlanerEndTime.EditValue = systemParams("PLANER_TIME_END").ParamDate
        txtSMS.EditValue = systemParams("SMS_VISIT_TIME").ParamDate
        txtPath.Text = systemParams("ENC_PATH").Value
        'If Not systemParams.ContainsKey(SystemInformation.ComputerName) Then
        '    param = New Entities.SystemParameter()
        '    param.Id = SystemInformation.ComputerName
        '    systemParams.Add(param.Id, param)
        'End If
        'txtPlace.Text = systemParams(SystemInformation.ComputerName).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FetchValues()
        If Not txtPlanerStartTime.EditValue.HasValue Then
            Core.UI.MsgBox.Show("Nav norādīts klīnikas sākuma darba laiks.")
            Return
        End If
        If Not txtPlanerEndTime.EditValue.HasValue Then
            Core.UI.MsgBox.Show("Nav norādīts klīnikas darba laika beigas.")
            Return
        End If

        If CDate(txtPlanerStartTime.EditValue).TimeOfDay > CDate(txtPlanerEndTime.EditValue).TimeOfDay Then
            Core.UI.MsgBox.Show("Sākuma laiks nevar bût lielāks par beigu laiku.")
            Exit Sub
        End If
        If CInt(txtFrequence.EditValue) < 1 OrElse CInt(txtFrequence.EditValue) > 60 Then
            Core.UI.MsgBox.Show("Intervālam jābût robežās no 1 - 60.")
        End If
        systemParams("USER_WORK_FREQUENCE").Value = txtFrequence.EditValue.ToString()

        systemParams("PLANER_TIME_START").ParamDate = CDate(txtPlanerStartTime.EditValue)
        systemParams("PLANER_TIME_END").ParamDate = CDate(txtPlanerEndTime.EditValue)
        systemParams("SMS_VISIT_TIME").ParamDate = CDate(txtSMS.EditValue)
        systemParams("ENC_PATH").Value = txtPath.Text
        'systemParams(SystemInformation.ComputerName).Value = txtPlace.Text
    End Sub


    Private Sub frmSystemParameters_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FetchValues()
        If Not coll.IsDirty Then
            Return
        End If
        Select Case Core.UI.MsgBox.SaveMessage()
            Case Windows.Forms.DialogResult.Yes : Session.Commit()
            Case Windows.Forms.DialogResult.Cancel : e.Cancel = True
        End Select
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        FetchValues()
        'If Not param Is Nothing Then
        '    Session.SaveOrUpdate(param)
        'End If
        Session.Commit()
    End Sub
End Class