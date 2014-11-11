Imports Core
Imports Entities
Imports Core.Dal
Imports Core.Bll
Imports Core.UI


Imports System.Diagnostics
Public Class frmPrescription
    Implements IEditForm

    Private _edit As Prescription
    Private _dataList As IList

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Function Save() As Boolean
        Dim add As Boolean = (_edit.Id = Guid.Empty)
        If Not _edit.IsValid Then Return False
        Session.SaveOrUpdate(_edit)
        Session.Commit()
        If add Then
            DataList.Add(PartnerSession.Get(Of Prescription)(_edit.Id))
        End If
        Return True
    End Function

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return Nothing
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(Prescription)) = Guid.Empty Then 'add new TcdPlan
                _edit = New Prescription(Session, value(GetType(Patient)))
            Else 'edit existing
                _edit = Session.Get(Of Prescription)(value(GetType(Prescription)))
            End If
            bndPrescription.DataSource = _edit
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

    Private Sub frmPrescription_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If _edit.IsDirty Then
            Dim answer As DialogResult = MsgBox.SaveMessage()
            If answer = DialogResult.Yes Then
                If Not Save() Then
                    e.Cancel = True
                End If
            ElseIf answer = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        If _edit.IsValid Then
            If _edit.IsDirty Then
                If Core.UI.MsgBox.Show(Msg.CantGenerateUnlessSaved, MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                    Save()
                Else
                    Return
                End If
            End If

            If Not _edit.File Is Nothing Then
                If Core.UI.MsgBox.Show(Msg.GenerateAgain, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
            _edit.GenerateDocument("D03")
        Else
            Core.UI.MsgBox.HasErrorMessage()
        End If
        Save()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        _edit.ShowTrackedDocument()
    End Sub
End Class
