Imports Entities
Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.UI

Public Class frmLocalSettings
    Dim list As Entities(Of LocalSettings)
    Dim location As LocalSettings

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SetValuesBack()
        Session.SaveOrUpdate(location)
        Session.Commit()
    End Sub

    Private Sub frmLocalSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        list = Entities(Of LocalSettings).GetAll(Session)
        Dim exist As Boolean = False
        For Each i As LocalSettings In list
            If i.Key = SystemInformation.ComputerName Then
                txtLocationPlace.Text = i.Value
                location = i
                exist = True
            End If
        Next
        If Not exist Then
            location = New LocalSettings()
            location.Key = SystemInformation.ComputerName
            list.Add(location)
        End If
        Dim b As BirthDateGenerator = New BirthDateGenerator()
        Dim d As KeyValuePair(Of Boolean, SMSMessages) = b.NeedGenerate(_session)
        If (d.Key) Then
            b.generateSms(_session, d.Value)
        End If
    End Sub

    Private Sub SetValuesBack()
        location.Value = txtLocationPlace.Text.Trim()
    End Sub
End Class
