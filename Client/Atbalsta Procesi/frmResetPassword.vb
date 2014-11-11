Option Strict On
Imports Entities
Imports Core.Bll
Imports Core.Dal
Imports Core.Dal.Expressions
Imports DevExpress
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports Core.UI

Public Class frmResetPassword
    Implements IEditForm

#Region "Data"
    Private _user As User
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
            _user = Session.Get(Of User)(value(GetType(User)))
            Me.bndUser.DataSource = _user
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
#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Function SaveUser() As Boolean
        If Not String.IsNullOrEmpty(txtPassword.Text) Then
            If Not txtPassword.Text = txtPasswordDublicate.Text Then
                Core.UI.MsgBox.Show(Core.Msg.IncorrectPassword)
                txtPassword.Text = ""
                txtPasswordDublicate.Text = ""
                Exit Function
            End If
        End If
        _user.Password = txtPassword.Text
        If _user.Save.HasErrors Then
            Core.UI.MsgBox.Show(Core.Err.CouldNotSave, MessageBoxButtons.OK)
            Return False
        End If
        'Me.AcceptChanges()
        Session.Commit()
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveUser()
    End Sub
End Class