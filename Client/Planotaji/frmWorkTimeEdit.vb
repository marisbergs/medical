Imports Core
Imports Core.Bll
Imports Core.Dal
Imports Core.UI
Imports Entities
Imports DevExpress
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmWorkTimeEdit
    Implements IEditForm

    Private _editedObject As WorkTime
    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Private clickPlace As GridHitInfo
    Private workTimeEdit As WorkTime

    Public WorkDate As DateTime
    Public User As User
    Public Speciality As Speciality
    Public WorkTime As WorkTime
    Public Room As Guid

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return Nothing
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If Tag Is Nothing Then
                If value(GetType(WorkTime)) = Guid.Empty Then 'add new User
                    _editedObject = New WorkTime(Session, WorkDate)
                    If Not Room = Guid.Empty Then
                        _editedObject.Room = Session.Get(Of Room)(Room)
                    End If
                Else 'edit existing
                    _editedObject = Session.Get(Of WorkTime)(value(GetType(WorkTime)))
                End If
            Else
                workTimeEdit = CType(Tag, WorkTime)
                If workTimeEdit.FromUserWorkTime Or workTimeEdit.Id = Guid.Empty Then
                    _editedObject = workTimeEdit
                Else
                    _editedObject = Session.Get(Of WorkTime)(workTimeEdit.Id)
                End If
            End If
            bndWorkTime.DataSource = _editedObject
            txtRoom.DataBindings.Add("EditValue", bndWorkTime, "Room", True, DataSourceUpdateMode.OnPropertyChanged)
            txtUser.DataBindings.Add("EditValue", bndWorkTime, "User", True, DataSourceUpdateMode.OnPropertyChanged)
            TimeEdit1.DataBindings.Add("EditValue", bndWorkTime, "StartTime", True, DataSourceUpdateMode.OnPropertyChanged)
            TimeEdit2.DataBindings.Add("EditValue", bndWorkTime, "EndTime", True, DataSourceUpdateMode.OnPropertyChanged)
            chkAcyity.DataBindings.Add("Checked", bndWorkTime, "Acity", True, DataSourceUpdateMode.OnPropertyChanged)
            Text = _editedObject.StartTime.ToShortDateString()
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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If _editedObject.IsValid Then
            Dim res As KeyValuePair(Of Boolean, WorkTime)
            res = _editedObject.ValidateTime(Session)
            Dim res2 As KeyValuePair(Of Boolean, UsersWorkTime)
            res2 = _editedObject.ValidateInDefaultWorkTime(Session)
            Dim val As KeyValuePair(Of Boolean, Visit)
            val = _editedObject.ValidateTimeChange(Session)
            If Not res.Key Then
                Core.UI.MsgBox.Show("Šinī laikā kabinetā " & res.Value.Room.Value & " jau ir ieplānots laiks ārstam " & res.Value.User.FullName & " laikā no " & res.Value.StartTime.ToShortTimeString() & " līdz " & res.Value.EndTime.ToShortTimeString() & ".")
            ElseIf Not res2.Key Then
                Core.UI.MsgBox.Show("Šinī laikā kabinetā " & res2.Value.Room.Value & " jau ir ieplānots laiks ārstam " & res2.Value.User.FullName & " laikā no " & res2.Value.StartTime.ToShortTimeString() & " līdz " & res2.Value.EndTime.ToShortTimeString() & ".")
            ElseIf (Not val.Key) Then
                Core.UI.MsgBox.Show("Nevar veikt izmaiņas jo ir ieplānota vizīte no " & val.Value.StartTime.ToShortTimeString() & " līdz " & val.Value.EndTime.ToShortTimeString() & ".")
            Else
                Session.SaveOrUpdate(_editedObject)
                Session.Commit()
            End If
        Else
            Core.UI.MsgBox.HasErrorMessage()
        End If
    End Sub
End Class