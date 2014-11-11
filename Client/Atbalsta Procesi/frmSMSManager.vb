Imports Core
Imports Core.Bll
Imports Entities
Imports Core.Dal
Imports Core.UI


Public Class frmSMSManager

    Private _time As SystemParameter = Session.Get(Of SystemParameter)("SMS_VISIT_TIME")
    Private _list As Entities(Of SMSMessages)

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        gbhBefore.ShowActive = True

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmSMSManager_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _list = Entities(Of SMSMessages).GetAll(Session)
        bndBefore.DataSource = _list
        For Each x As SMSType In SMSType.ListSource
            cmbType.Items.Add(x)
        Next
        Dim t As SystemParameter = Session.Get(Of SystemParameter)("SMS_VISIT_TIME")
        Text &= "(Robežlaiks " & t.ParamDate.Value.ToShortTimeString & ")"
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Function Save() As Boolean
        For Each x As SMSMessages In _list
            If Not x.IsValid Then
                Core.UI.MsgBox.HasErrorMessage()
                Return False
            End If
        Next
        For Each x As SMSMessages In _list
            Session.SaveOrUpdate(x)
        Next
        Session.Commit()
    End Function

    Private Sub gbhBefore_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhBefore.OnAddNew
        Dim item As New SMSMessages()
        item.SendTime = DateTime.Now.Date
        args.AddedObject = item
        _list.Add(item)
    End Sub

    Private Sub frmSMSManager_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        For Each x As SMSMessages In _list
            If x.IsDirty Then
                Dim answer As DialogResult = Core.UI.MsgBox.SaveMessage()
                If answer = DialogResult.Yes Then
                    If Not Save() Then
                        e.Cancel = True
                    End If
                ElseIf answer = DialogResult.Cancel Then
                    e.Cancel = True
                End If
                Exit Sub
            End If
        Next
    End Sub
End Class