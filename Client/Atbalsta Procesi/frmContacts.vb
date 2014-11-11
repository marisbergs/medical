Imports Entities
Imports Core.Bll
Imports Core.Dal
Imports Core

Public Class frmContacts
    Dim _dataEdit As Contacts

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim _list As Entities(Of Contacts) = Entities(Of Contacts).GetAll(Session)
        If _list.Count > 0 Then
            _dataEdit = CType(_list.Item(0), Contacts)
        Else
            _dataEdit = New Contacts()
        End If
        bndContact.DataSource = _dataEdit
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmContacts_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _dataEdit.IsDirty Then
            Return
        End If
        Select Case Core.UI.MsgBox.SaveMessage()
            Case Windows.Forms.DialogResult.Yes : Session.Commit()
            Case Windows.Forms.DialogResult.Cancel : e.Cancel = True
        End Select
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Session.SaveOrUpdate(_dataEdit)
        Session.Commit()
    End Sub
End Class
