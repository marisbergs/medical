Imports Core.UI

Public Class frmActivityDateSelector
    Public SelectedDate As List(Of Date)
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        ''MonthCalendar1.SelectionRange
        If DateNavigator1.Selection.Count > 0 Then
            SelectedDate = New List(Of Date)()
            For Each time As Date In DateNavigator1.Selection
                SelectedDate.Add(time)
            Next
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox.Show("Nav norādīts neviens aktivitātes datums")
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class
