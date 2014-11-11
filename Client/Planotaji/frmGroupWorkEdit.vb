Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.UI
Imports Entities


Public Class frmGroupWorkEdit
    Implements IEditForm

    Private defaultWorktime As WorkTime
    Private _dataList As IList
    Private _list As Entities(Of WorkTime)

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return Nothing
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(WorkTime)) = Guid.Empty Then 'add new 
                defaultWorktime = New WorkTime(Session)
                defaultWorktime.GroupId = Guid.NewGuid()
            Else 'edit existing
                defaultWorktime = Session.Get(Of WorkTime)(value(GetType(WorkTime)))
            End If
            bndGroupWork.DataSource = defaultWorktime
            _list = Entities(Of WorkTime).GetAll(Session, New Expressions.Eq("GroupId", defaultWorktime.GroupId))
            bndGroupsWorks.DataSource = _list

            Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
            selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseDoctor", True))

            CType(txtDoctorSelector, Core.UI.IPickerSupportsPresets).PickerPresets = selClassif
            gbhGroupWork.ShowActive = True
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
        Save()
    End Sub

    Private Function Save() As Boolean
        For Each x As WorkTime In bndGroupsWorks
            If Not x.IsValid Then
                MsgBox.HasErrorMessage()
                Return False
            End If
            If x.GroupWork Is Nothing Then
                MsgBox.HasErrorMessage()
                Return False
            End If
            Dim res As KeyValuePair(Of Boolean, WorkTime)
            res = x.ValidateTime(Session)
            If Not res.Key Then
                Core.UI.MsgBox.Show("Šinī laikā kabinetā " & res.Value.Room.Value & " jau ir ieplānots laiks ārstei " & res.Value.User.FullName & " laikā no " & res.Value.StartTime.ToShortTimeString() & " līdz " & res.Value.EndTime.ToShortTimeString() & ".")
                Return False
            End If
        Next
        For Each x As WorkTime In bndGroupsWorks
            Dim vis As Entities(Of Visit) = Entities(Of Visit).GetAll(Session, New Expressions.Eq("ParentId", x.Id))
            For Each z As Visit In vis
                z.Length = x.Length
                z.StartTime = x.StartTime
                z.EndTime = z.StartTime.AddMinutes(z.Length)
                z.Service = x.GroupWork
                For Each n As VisitService In z.VisitServices.ActiveItemsWithoutEmpty
                    n.Service = x.GroupWork
                Next
                Session.SaveOrUpdate(z)
            Next
            Session.SaveOrUpdate(x)
        Next
        Session.Commit()
    End Function

    Private Sub gbhGroupWork_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhGroupWork.OnAddNew
        If txtGroupWork.EditValue Is Nothing OrElse Convert.IsDBNull(txtGroupWork.EditValue) Then
            MsgBox.Show("Izvēlieties kādu no grupas nodarbības veidiem")
            Return
        End If
        Dim workTime As New WorkTime(Session)
        workTime.User = defaultWorktime.User
        workTime.Room = defaultWorktime.Room
        workTime.GroupWork = defaultWorktime.GroupWork
        workTime.GroupId = defaultWorktime.GroupId
        bndGroupsWorks.Add(workTime)
        args.AddedObject = workTime
    End Sub

    Private Sub txtDoctor_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDoctor.ButtonClick
        Dim frm As New frmUsers
        frm.FormMode = ClassifierListMode.SingleSelect

        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseDoctor", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub txtRoom_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtRoom.ButtonClick
        Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(Room), Session), Session, ClassifierListMode.SingleSelect)
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub txtStartDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStartDate.Validating
        If bndGroupsWorks.Current Is Nothing Then Return
        Dim groupWork As WorkTime = CType(bndGroupsWorks.Current, WorkTime)

    End Sub

    Private Sub txtGroupWork_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtGroupWork.ButtonClick
        Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(Services), Session), Session, ClassifierListMode.SingleSelect)
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseIsGroupWork", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub
End Class
