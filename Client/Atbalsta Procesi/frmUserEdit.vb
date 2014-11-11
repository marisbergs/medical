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

Public Class frmUserEdit
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
            Me.bndRole.DataSource = Core.Bll.Entities(Of Role).GetAll(Session, New [IsNull]("DeleteTime"))
            If value(GetType(User)) = Guid.Empty Then 'add new User
                _user = New User(Session)
                Panel1.Visible = True
            Else 'edit existing User
                _user = Session.Get(Of User)(value(GetType(User)))
            End If
            Me.bndUser.DataSource = _user
            Me.bndSpeciality.DataSource = _user.UserSpecialities
            Me.bndServices.DataSource = _user.UserServices
            Me.bndLanguage.DataSource = _user.UserLanguage
            Me.grdSpeciality.SetEditMode()
            Me.gbhSpeciality.ShowActive = True
            If _user.Role Is Nothing Then Me.cmbRole.DataSource = Nothing
            bndWorkTime.DataSource = _user.CreateTable
            gbhServices.ShowActive = True
            gbhSpeciality.ShowActive = True
            gbhLanguage.ShowActive = True
            cmbSeleryType.Items.Add(SeleryType.Percentage)
            cmbSeleryType.Items.Add(SeleryType.Time)
            cmbSelery.Items.Add(Selery.Percentage)
            cmbSelery.Items.Add(Selery.Ls)
            If Not PermissionsChecker.CanDo("User.Accounting") Then
                TabControl1.TabPages.Remove(pagAccounting)
            End If
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
#Region "Logon"
    Private Sub txtLogon_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        'TODO: aktīvās direktorijas konts
    End Sub
#End Region
    Private Sub txtUser_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        Dim frm As New frmUsers
        frm.FormMode = ClassifierListMode.SingleSelect
        frm.Selection = Me.Session

        Dim selUser As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        obj.Add(_user.Id)
        selUser.Enqueue(New KeyValuePair(Of String, Object)("User", obj))
        selUser.Enqueue(New KeyValuePair(Of String, Object)("UseNotInUser", True))
        frm.SearchObjectPropertyPresets = selUser

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim editor As DevExpress.XtraEditors.ButtonEdit = CType(sender, DevExpress.XtraEditors.ButtonEdit)
            editor.EditValue = frm.Selection
        End If
    End Sub
    Private Sub btnDeleteRole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRole.Click
        Me.cmbRole.DataSource = Nothing
        _user.Role = Nothing
    End Sub
    Private Sub cmbRole_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRole.Click
        Me.cmbRole.DataSource = Me.bndRole.DataSource
        Me.cmbRole.ValueMember = "Id"
        Me.cmbRole.DisplayMember = "Name"
    End Sub
#Region "Close&Save"
    Private Sub frmUserEdit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not CloseForm() Then e.Cancel = True
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Function HasError() As Boolean
        If Not _user.IsValid Then Return True
        Return False
    End Function
    Private Function SaveUser() As Boolean
        Dim newUser As Boolean = (_user.Id = Guid.Empty)
        If Not _user.CanSave Then Return True
        If newUser Then
            If Not String.IsNullOrEmpty(txtPassword.Text) Then
                If Not txtPassword.Text = txtPasswordDublicate.Text Then
                    Core.UI.MsgBox.Show(Core.Msg.IncorrectPassword)
                    txtPassword.Text = ""
                    txtPasswordDublicate.Text = ""
                End If
            End If
        End If
        If _user.Save.HasErrors Then
            Core.UI.MsgBox.Show(Core.Err.CouldNotSave, MessageBoxButtons.OK)
            Return False
        End If
        'Me.AcceptChanges()
        Session.Commit()
        If newUser Then
            Panel1.Visible = False
            _dataIDs.Clear()
            _dataIDs.Add(GetType(User), _user.Id)
            DataList.Add(PartnerSession.Get(Of User)(_user.Id))
        End If
        UpdateGrids()
        Return True
    End Function
    Private Function CloseForm() As Boolean
        If Not _user.CanSave Then Return True
        If _user.IsDirty Then
            Select Case Core.UI.MsgBox.SaveMessage
                Case Windows.Forms.DialogResult.Yes
                    If Me.HasError Then
                        ActivateErrorControls(Me.ErrorProvider, Me)
                        Core.UI.MsgBox.HasErrorMessage()
                        Return False
                    Else
                        If Not SaveUser() Then Return False
                        Return True
                    End If
                Case Windows.Forms.DialogResult.No
                    Return True
                Case Windows.Forms.DialogResult.Cancel
                    Return False
            End Select
        End If
        Return True
    End Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Me.HasError Then
            ActivateErrorControls(Me.ErrorProvider, Me)
            Core.UI.MsgBox.HasErrorMessage()
        Else
            SaveUser()
        End If
    End Sub
    Private Function LogonOK() As Boolean
        'Justine: a rough check to see that logons added are unique
        Dim list As Entities(Of User)
        Dim eCriteria As New System.Collections.Generic.List(Of Expressions.CriterionBase)
        eCriteria.Add(New Core.Dal.Expressions.Eq("Logon", _user.Logon))
        eCriteria.Add(New Core.Dal.Expressions.IsNull("DeleteTime"))
        eCriteria.Add(New Core.Dal.Expressions.NotEq("Id", _user.Id))
        'list = Core.Bll.Entities(Of User).GetAll(Session, New Core.Dal.Expressions.Eq("Logon", _user.Logon), New Core.Dal.Expressions.IsNull("DeleteTime"))
        list = Core.Bll.Entities(Of User).GetAll(Session, eCriteria)
        Return (list.Count = 0)
    End Function
#End Region
#Region "Grid stuff -- on add new"
    Private Sub gbhSpeciality_OnAddNew(ByVal sender As Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhSpeciality.OnAddNew
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Speciality)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As UsersSpecialities In _user.UserSpecialities.ActiveItemsWithoutEmpty
            If Not x.Speciality Is Nothing AndAlso Not obj.Contains(x.Speciality.Id) Then
                obj.Add(x.Speciality.Id)
            End If
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotInClassifier", True))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotMark", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim tem As UsersSpecialities
            For Each x As Speciality In CType(frm.Selection, Entities(Of Speciality))
                tem = New UsersSpecialities(Session)
                tem.Speciality = x
                args.AddedObject = tem
                _user.UserSpecialities.Add(tem)
            Next
        End If
    End Sub
    Private Sub UpdateGrids()
        Me.grdSpeciality.UpdateReadonlyRowStatus()
    End Sub
#End Region

    Private Sub frmUserEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.gbhSpeciality.AddNewButton.DataBindings.Add("Enabled", _user, "CanAddDeleteSpeciality", True, DataSourceUpdateMode.OnPropertyChanged)
    End Sub

    Private Sub txtSpeciality_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSpeciality.ButtonClick
        Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(Speciality), Session), Session, ClassifierListMode.SingleSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As UsersSpecialities In _user.UserSpecialities.ActiveItemsWithoutEmpty
            If Not x.Speciality Is Nothing AndAlso Not obj.Contains(x.Speciality.Id) Then
                obj.Add(x.Speciality.Id)
            End If
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotInClassifier", True))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotMark", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub grdWorkTime_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdWorkTime.DoubleClick
        OpenWorkTime()
    End Sub

    Private Sub grdWorkTime_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdWorkTime.MouseClick
        clickPlace = gvwWorkTime.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub GridButtonHelper1_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles GridButtonHelper1.OnAddNew
        Dim frm As New frmUserWorkTimeEdit
        frm.Session = Nothing
        frm.PartnerSession = Me.Session
        Dim _data As New Dictionary(Of Type, Guid)
        Dim _selected As TimeTable = CType(bndWorkTime.Current, TimeTable)
        frm.Text = gvwWorkTime.FocusedColumn.Caption
        Select Case gvwWorkTime.FocusedColumn.FieldName
            Case "Monday"
                _data.Add(GetType(UsersWorkTime), Guid.Empty)
                _data.Add(GetType(User), _user.Id)
                frm.Tag = Day.Monday
            Case "Tuesday"
                _data.Add(GetType(UsersWorkTime), Guid.Empty)
                _data.Add(GetType(User), _user.Id)
                frm.Tag = Day.Tuesday
            Case "Wednesday"
                _data.Add(GetType(UsersWorkTime), Guid.Empty)
                _data.Add(GetType(User), _user.Id)
                frm.Tag = Day.Wednesday
            Case "Thursday"
                _data.Add(GetType(UsersWorkTime), Guid.Empty)
                _data.Add(GetType(User), _user.Id)
                frm.Tag = Day.Thursday
            Case "Friday"
                _data.Add(GetType(UsersWorkTime), Guid.Empty)
                _data.Add(GetType(User), _user.Id)
                frm.Tag = Day.Friday
            Case "Saturday"
                _data.Add(GetType(UsersWorkTime), Guid.Empty)
                _data.Add(GetType(User), _user.Id)
                frm.Tag = Day.Saturday
            Case "Sunday"
                _data.Add(GetType(UsersWorkTime), Guid.Empty)
                _data.Add(GetType(User), _user.Id)
                frm.Tag = Day.Sanday
        End Select
        If _data.Count = 0 Then
            Exit Sub
        End If
        frm.DataIDs = _data
        frm.DataList = _user.UsersWorkTime
        frm.ShowDialog()
        bndWorkTime.DataSource = _user.CreateTable()
    End Sub

    Private Sub OpenWorkTime()
        If clickPlace Is Nothing Then
            Return
        End If

        If Not clickPlace.HitTest = GridHitTest.RowCell Then
            Return
        End If
        Dim frm As New frmUserWorkTimeEdit
        frm.Session = Nothing
        frm.PartnerSession = Me.Session
        Dim _data As New Dictionary(Of Type, Guid)
        Dim _selected As TimeTable = CType(bndWorkTime.Current, TimeTable)
        frm.Text = gvwWorkTime.FocusedColumn.Caption
        Select Case gvwWorkTime.FocusedColumn.FieldName
            Case "Monday"
                If Not _selected.MondayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.MondayId)
                Else
                    _data.Add(GetType(UsersWorkTime), Guid.Empty)
                    _data.Add(GetType(User), _user.Id)
                    frm.Tag = Day.Monday
                End If
            Case "Tuesday"
                If Not _selected.TuesdayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.TuesdayId)
                Else
                    _data.Add(GetType(UsersWorkTime), Guid.Empty)
                    _data.Add(GetType(User), _user.Id)
                    frm.Tag = Day.Tuesday
                End If
            Case "Wednesday"
                If Not _selected.WednesdayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.WednesdayId)
                Else
                    _data.Add(GetType(UsersWorkTime), Guid.Empty)
                    _data.Add(GetType(User), _user.Id)
                    frm.Tag = Day.Wednesday
                End If
            Case "Thursday"
                If Not _selected.ThursdayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.ThursdayId)
                Else
                    _data.Add(GetType(UsersWorkTime), Guid.Empty)
                    _data.Add(GetType(User), _user.Id)
                    frm.Tag = Day.Thursday
                End If
            Case "Friday"
                If Not _selected.FridayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.FridayId)
                Else
                    _data.Add(GetType(UsersWorkTime), Guid.Empty)
                    _data.Add(GetType(User), _user.Id)
                    frm.Tag = Day.Friday
                End If
            Case "Saturday"
                If Not _selected.SaturdayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.SaturdayId)
                Else
                    _data.Add(GetType(UsersWorkTime), Guid.Empty)
                    _data.Add(GetType(User), _user.Id)
                    frm.Tag = Day.Saturday
                End If
            Case "Sunday"
                If Not _selected.SundayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.SundayId)
                Else
                    _data.Add(GetType(UsersWorkTime), Guid.Empty)
                    _data.Add(GetType(User), _user.Id)
                    frm.Tag = Day.Sanday
                End If
        End Select
        If _data.Count = 0 Then
            Exit Sub
        End If
        frm.DataIDs = _data
        frm.DataList = _user.UsersWorkTime
        frm.ShowDialog()
        bndWorkTime.DataSource = _user.CreateTable()

        'Dim isActiveStyle As New DevExpress.XtraGrid.StyleFormatCondition
        'isActiveStyle.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        'isActiveStyle.Value1 = False
        'isActiveStyle.ApplyToRow = True
        'isActiveStyle.Appearance.ForeColor = Color.Goldenrod
        'isActiveStyle.Appearance.Options.UseForeColor = True
        'Dim val As Object
        'Dim rowVal As TimeTable
        'For i As Integer = 0 To gvwWorkTime.RowCount - 1
        '    rowVal = CType(gvwWorkTime.GetRow(i), TimeTable)
        '    For Each j As DevExpress.XtraGrid.Columns.GridColumn In gvwWorkTime.Columns
        '        If rowVal.MondayAcyity Then

        '        End If
        '        If Not String.IsNullOrEmpty(rowVal.Tuesday) Then
        '            If rowVal.TuesdayAcyity Then
        '                j.
        '            End If
        '        End If
        '    Next
        'Next


    End Sub

    Private Sub GridButtonHelper1_OnDelete(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.DeleteEventArgs) Handles GridButtonHelper1.OnDelete
        Dim _selected As TimeTable = CType(bndWorkTime.Current, TimeTable)
        Dim _data As New Dictionary(Of Type, Guid)
        Select Case gvwWorkTime.FocusedColumn.FieldName
            Case "Monday"
                If Not _selected.MondayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.MondayId)
                End If
            Case "Tuesday"
                If Not _selected.TuesdayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.TuesdayId)
                End If
            Case "Wednesday"
                If Not _selected.WednesdayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.WednesdayId)
                End If
            Case "Thursday"
                If Not _selected.ThursdayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.ThursdayId)
                End If
            Case "Friday"
                If Not _selected.FridayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.FridayId)
                End If
            Case "Saturday"
                If Not _selected.SaturdayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.SaturdayId)
                End If
            Case "Sunday"
                If Not _selected.SundayId = Guid.Empty Then
                    _data.Add(GetType(UsersWorkTime), _selected.SundayId)
                End If
        End Select
        If _data.Count > 0 Then
            If Core.UI.MsgBox.DeleteMessage = Windows.Forms.DialogResult.Yes Then
                For Each x As UsersWorkTime In _user.UsersWorkTime.ActiveItemsWithoutEmpty
                    If x.Id = _data(GetType(UsersWorkTime)) Then
                        x.IsActive = False
                    End If
                Next
                bndWorkTime.DataSource = _user.CreateTable()
            End If
        End If
    End Sub

    Private Sub btnChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePassword.Click
        Dim frm As New frmResetPassword
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        key.Add(GetType(User), _user.Id)
        frm.DataIDs = key
        frm.ShowDialog()
    End Sub

    Private Sub gvwWorkTime_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gvwWorkTime.RowCellStyle
        Dim wt As TimeTable = CType(gvwWorkTime.GetRow(e.RowHandle), TimeTable)
        Select Case e.Column.Name
            Case colMonday.Name
                If wt.MondayAcyity Then
                    e.Appearance.BackColor = Color.YellowGreen
                    e.Appearance.ForeColor = Color.Black
                ElseIf Not String.IsNullOrEmpty(wt.Monday) Then
                    e.Appearance.BackColor = Color.Yellow
                    e.Appearance.ForeColor = Color.Black
                End If
            Case colTuesday.Name
                If wt.TuesdayAcyity Then
                    e.Appearance.BackColor = Color.YellowGreen
                    e.Appearance.ForeColor = Color.Black
                ElseIf Not String.IsNullOrEmpty(wt.Tuesday) Then
                    e.Appearance.BackColor = Color.Yellow
                    e.Appearance.ForeColor = Color.Black
                End If
            Case colWednesday.Name
                If wt.WednesdayAcyity Then
                    e.Appearance.BackColor = Color.YellowGreen
                    e.Appearance.ForeColor = Color.Black
                ElseIf Not String.IsNullOrEmpty(wt.Wednesday) Then
                    e.Appearance.BackColor = Color.Yellow
                    e.Appearance.ForeColor = Color.Black
                End If
            Case colThursday.Name
                If wt.ThursdayAcyity Then
                    e.Appearance.BackColor = Color.YellowGreen
                    e.Appearance.ForeColor = Color.Black
                ElseIf Not String.IsNullOrEmpty(wt.Thursday) Then
                    e.Appearance.BackColor = Color.Yellow
                    e.Appearance.ForeColor = Color.Black
                End If
            Case colFriday.Name
                If wt.FridayAcyity Then
                    e.Appearance.BackColor = Color.YellowGreen
                    e.Appearance.ForeColor = Color.Black
                ElseIf Not String.IsNullOrEmpty(wt.Friday) Then
                    e.Appearance.BackColor = Color.Yellow
                    e.Appearance.ForeColor = Color.Black
                End If
            Case colSaturday.Name
                If wt.SaturdayAcyity Then
                    e.Appearance.BackColor = Color.YellowGreen
                    e.Appearance.ForeColor = Color.Black
                ElseIf Not String.IsNullOrEmpty(wt.Saturday) Then
                    e.Appearance.BackColor = Color.Yellow
                    e.Appearance.ForeColor = Color.Black
                End If
            Case colSunday.Name
                If wt.SundayAcyity Then
                    e.Appearance.BackColor = Color.YellowGreen
                    e.Appearance.ForeColor = Color.Black
                ElseIf Not String.IsNullOrEmpty(wt.Sunday) Then
                    e.Appearance.BackColor = Color.Yellow
                    e.Appearance.ForeColor = Color.Black
                End If
        End Select
    End Sub

    Private Sub gbhServices_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhServices.OnAddNew
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As UserService In _user.UserServices.ActiveItemsWithoutEmpty
            If Not x.Service Is Nothing AndAlso Not obj.Contains(x.Service.Id) Then
                obj.Add(x.Service.Id)
            End If
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotInClassifier", True))

        Dim obj2 As IList(Of Guid) = New List(Of Guid)
        For Each x As UsersSpecialities In _user.UserSpecialities.ActiveItemsWithoutEmpty
            For Each z As Services In x.Speciality.Services
                If Not obj2.Contains(z.Id) Then
                    obj2.Add(z.Id)
                End If
            Next
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("ClassifiersId", obj2))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseInList", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim tem As UserService
            For Each x As Services In CType(frm.Selection, Entities(Of Services))
                tem = New UserService(Session)
                tem.Service = x
                args.AddedObject = tem
                _user.UserServices.Add(tem)
            Next
        End If
    End Sub

    Private Sub txtService_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtService.ButtonClick
        Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(Services), Session), Session, ClassifierListMode.SingleSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As UserService In _user.UserServices.ActiveItemsWithoutEmpty
            If Not x.Service Is Nothing AndAlso Not obj.Contains(x.Service.Id) Then
                obj.Add(x.Service.Id)
            End If
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotInClassifier", True))

        Dim obj2 As IList(Of Guid) = New List(Of Guid)
        For Each x As UsersSpecialities In _user.UserSpecialities.ActiveItemsWithoutEmpty
            For Each z As Services In x.Speciality.Services
                If Not obj2.Contains(z.Id) Then
                    obj2.Add(z.Id)
                End If
            Next
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("ClassifiersId", obj2))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseInList", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub txtLaguage_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtLaguage.ButtonClick
        Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(Language), Session), Session, ClassifierListMode.SingleSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As UserLanguage In _user.UserLanguage.ActiveItemsWithoutEmpty
            If Not x.Language Is Nothing AndAlso Not obj.Contains(x.Language.Id) Then
                obj.Add(x.Language.Id)
            End If
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotInClassifier", True))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotMark", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub gbhLanguage_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhLanguage.OnAddNew
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Language)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As UserLanguage In _user.UserLanguage.ActiveItemsWithoutEmpty
            If Not x.Language Is Nothing AndAlso Not obj.Contains(x.Language.Id) Then
                obj.Add(x.Language.Id)
            End If
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotInClassifier", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim item As UserLanguage
            For Each x As Language In CType(frm.Selection, Entities(Of Language))
                item = New UserLanguage(Session)
                item.Language = x
                args.AddedObject = item
                _user.UserLanguage.Add(item)
            Next
        End If
    End Sub

    Private Sub itmCopyToEmpty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmCopyToEmpty.Click
        If bndServices.Current Is Nothing Then
            Return
        End If
        Dim srv As UserService = CType(bndServices.Current, UserService)
        If (srv.Selery Is Nothing AndAlso srv.SeleryType Is Nothing AndAlso Not srv.SeleryValue.HasValue) Then
            Return
        Else
            For Each service As UserService In bndServices
                If Not service.IsActive Then
                    Continue For
                End If
                If (service.Selery Is Nothing AndAlso service.SeleryType Is Nothing AndAlso Not service.SeleryValue.HasValue) Then
                    If service.Service.ReferenceSecond.Mark = srv.Service.ReferenceSecond.Mark Then
                        service.Selery = srv.Selery
                        service.SeleryType = srv.SeleryType
                        service.SeleryValue = srv.SeleryValue
                    End If
                End If
            Next
        End If
    End Sub
End Class