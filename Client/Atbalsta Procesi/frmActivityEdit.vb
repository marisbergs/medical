Imports Core.Bll
Imports Core.UI
Imports Entities
Imports Core.Dal.Expressions
Imports NHibernate.Expression

Public Class frmActivityEdit
    Implements IEditForm

    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Private _activity As Activity
    Private _activityGroup As Entities(Of Activity)
    Public Visit As Visit

    Public Property DataIDs() As Dictionary(Of Type, Guid) Implements IEditForm.DataIDs
        Get
            Return _dataIDs
        End Get
        Set(ByVal value As Dictionary(Of Type, Guid))
            If Me.DesignMode Then Return
            If value(GetType(Activity)) = Guid.Empty Then 'add new activity
                _activityGroup = New Entities(Of Activity)()
                Dim forma As New frmActivityDateSelector()
                If forma.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim id As Guid = Guid.NewGuid
                    For Each time As Date In forma.SelectedDate
                        _activity = New Activity(Session)
                        _activity.ActivityDate = time
                        _activity.RemindDate = time.AddDays(-14)
                        _activity.Group = id
                        _activityGroup.Add(_activity)
                    Next
                Else
                    _activity = New Activity(Session)
                    _activityGroup.Add(_activity)
                End If
            Else 'edit existing User
                _activity = Session.Get(Of Activity)(value(GetType(Activity)))
                _activityGroup = Entities(Of Activity).GetAll(Session, New Eq("Group", _activity.Group))
            End If
            If Not Visit Is Nothing Then
                For Each activity As Activity In _activityGroup
                    activity.Patient = Visit.Patient
                    activity.Service = Visit.Service
                Next
            End If
            bndActivity.DataSource = _activityGroup
            GridButtonHelper1.ShowActive = True
        End Set
    End Property

    Public Property DataList() As IList Implements IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As IList)
            _dataList = value
        End Set
    End Property

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Function Save() As Boolean
        For Each o As Activity In bndActivity
            If Not o.IsValid Then
                MsgBox.HasErrorMessage()
                bndActivity.Position = bndActivity.IndexOf(o)
                Return False
            End If
        Next
        For Each p As Activity In bndActivity
            Session.SaveOrUpdate(p)
        Next
        Session.Commit()
        Return True
    End Function

    Private Sub ButtonEdit1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        If (bndActivity.Current Is Nothing) Then
            Return
        End If
        Dim frm As New frmPatients(Entities.ClassifierType.FromType(GetType(Patient), Session), Session, ClassifierListMode.SingleSelect)
        frm.gvwPatients.OptionsView.ShowAutoFilterRow = True
        frm.gvwPatients.Focus()
        frm.FormMode = ClassifierListMode.SingleSelect
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(bndActivity.Current, Activity).Patient = CType(frm.Selection, Patient)
        End If
        For Each o As Activity In bndActivity
            If o.Patient Is Nothing Then
                If MsgBox.Show("Vai vēlaties aizpildīt atlikušos tukšos ierakstus ar šo klientu?", MessageBoxButtons.YesNo, "Jautājums") = Windows.Forms.DialogResult.Yes Then
                    For Each oo As Activity In bndActivity
                        If oo.Patient Is Nothing Then
                            oo.Patient = CType(frm.Selection, Patient)
                        End If
                    Next
                    Return
                End If
            End If
        Next
    End Sub

    Private Sub GridButtonHelper1_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles GridButtonHelper1.OnAddNew
        Dim forma As New frmActivityDateSelector()
        If forma.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim id As Guid
            If bndActivity.Current Is Nothing Then
                id = Guid.NewGuid
            Else
                id = CType(bndActivity.Current, Activity).Group
            End If
            For Each time As Date In forma.SelectedDate
                _activity = New Activity(Session)
                _activity.ActivityDate = time
                _activity.RemindDate = time.AddDays(-14)
                _activity.Group = id
                _activityGroup.Add(_activity)
            Next
        End If
    End Sub

    Private Sub btnCreateVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateVisit.Click
        If bndActivity.Current Is Nothing Then
            Return
        End If
        Dim activity As Activity = CType(bndActivity.Current, Activity)
        If activity.IsDirty Then
            Core.UI.MsgBox.Show("Pirms izveidot vizīti lûdzu saglabājiet aktivitātes izmaiņas.")
            Return
        End If

    End Sub
End Class
