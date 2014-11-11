Imports Entities
Imports Core.Bll
Imports Core.Dal

Public Class frmUserWorkTimeEdit
    Implements Core.UI.IEditForm
    Private _userWorkTime As UsersWorkTime
    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return Nothing
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(UsersWorkTime)) = Guid.Empty Then 'add new 
                _userWorkTime = New UsersWorkTime(Session, value(GetType(User)), CType(Me.Tag, Day))
            Else 'edit existing User
                _userWorkTime = Session.Get(Of UsersWorkTime)(value(GetType(UsersWorkTime)))
            End If

            Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
            Dim obj As IList(Of Guid) = New List(Of Guid)
            Dim _list As IList(Of Guid) = New List(Of Guid)
            For Each x As UsersSpecialities In _userWorkTime.User.UserSpecialities.ActiveItemsWithoutEmpty
                Dim l As Entities(Of RoomGroups)
                l = Entities(Of RoomGroups).GetAll(Session, New Expressions.Eq("Specialities.Id", x.Speciality.Id))
                For Each o As RoomGroups In l
                    If Not obj.Contains(o.Id) Then
                        obj.Add(o.Id)
                    End If
                Next
            Next
            'Dim temp As Entities(Of RoomGroups) = Entities(Of RoomGroups).GetAll(Session, CriteriaBuilder.IsInCollection("Specialities.Id", obj), New Expressions.Eq("Mark", True))
            'For Each x As RoomGroups In temp
            '    If x.IsActive And Not _list.Contains(x.Id) Then
            '        _list.Add(x.Id)
            '    End If
            'Next
            selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
            selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseIsParent", True))

            CType(txtRoom, Core.UI.IPickerSupportsPresets).PickerPresets = selClassif
            bndWorkTime.DataSource = _userWorkTime
            'txtRoom.DataBindings.Add("EditValue", bndWorkTime, "Room", False, DataSourceUpdateMode.OnPropertyChanged)
            'TimeEdit1.DataBindings.Add("EditValue", bndWorkTime, "StartTimeN", False, DataSourceUpdateMode.OnPropertyChanged)
            'TimeEdit2.DataBindings.Add("EditValue", bndWorkTime, "EndTimeN", False, DataSourceUpdateMode.OnPropertyChanged)
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

    Private Function Save() As Boolean
        If Not _userWorkTime.IsValid Then
            Core.UI.MsgBox.HasErrorMessage()
            Return False
        End If
        Dim add As Boolean = (_userWorkTime.Id = Guid.Empty)

        'Session.Save(_editedObject)
        _userWorkTime.Save()
        Session.Commit()

        If add Then DataList.Add(PartnerSession.Get(Of UsersWorkTime)(_userWorkTime.Id))

        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub
End Class
