Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.UI
Imports Entities
Imports DevExpress
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class frmWorkTime

    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Private _dataSource As DataTable
    Private _list As IList(Of WorkTime) = New List(Of WorkTime)
    Private clickPlace As GridHitInfo
    Private dayCount As Integer
    Private startDate As Date

    Private Sub frmWorkTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbhWorkTime.Controls.SetChildIndex(btnOpen, 0)
        txtRoomGroup.Properties.DataSource = Entities(Of RoomGroups).GetAllOrderBy(Session, NHibernate.Expression.Order.Asc("Value"), New Expressions.IsNull("DeleteTime"))
        rbt5.Checked = True
        SetColumnCaptions()
        txtDoctor.Properties.DataSource = Entities(Of User).GetAllOrderBy(Session, NHibernate.Expression.Order.Asc("LastName"), New Expressions.IsNull("DeleteTime"), New Expressions.Eq("Position.Mark", True), New Expressions.And(New Expressions.Le("WorksFrom", startDate), New Expressions.Or(New Expressions.IsNull("WorkedUntil"), New Expressions.Ge("WorkedUntil", startDate))))
    End Sub

    'Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSpeciality.ButtonClick
    '    Dim frm As frmClassifierList
    '    Dim EntityType As System.Type = GetType(Speciality)

    '    frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session)
    '    CType(frm, frmClassifierList).FormMode = ClassifierListMode.SingleSelect

    '    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        txtSpeciality.EditValue = frm.Selection
    '        'Notīram iepriekš pievienotos kabinetus
    '        Dim col As XtraGrid.Columns.GridColumn
    '        For i As Integer = gvwWorkTime.Columns.Count - 1 To 0 Step -1
    '            col = gvwWorkTime.Columns(i)
    '            If Not col.Name = "colTime" Then
    '                gvwWorkTime.Columns.RemoveAt(i)
    '            End If
    '        Next
    '        _dataSource = WorkTime.TimeTable(Session, CType(txtSpeciality.EditValue, Speciality).Id, mcaThisMonth.SelectionStart)

    '        Dim _room As Room

    '        For Each x As System.Data.DataColumn In _dataSource.Columns
    '            If Not x.ColumnName = "Time" AndAlso Not x.ColumnName.EndsWith("Acity") Then

    '                _room = Session.Get(Of Room)(New Guid(x.ColumnName))
    '                col = New XtraGrid.Columns.GridColumn()
    '                col.AppearanceCell.TextOptions.VAlignment = Utils.VertAlignment.Center
    '                col.AppearanceCell.TextOptions.HAlignment = Utils.VertAlignment.Center
    '                col.ColumnEdit = txtMemo
    '                col.Name = x.ColumnName
    '                col.FieldName = x.ColumnName
    '                col.Caption = _room.Value
    '                col.Visible = True
    '                col.VisibleIndex = gvwWorkTime.Columns.Count
    '                col.Width = 100
    '                gvwWorkTime.Columns.Add(col)
    '            End If
    '        Next
    '        bndData.DataSource = _dataSource
    '    End If
    'End Sub

    Private Sub mcaThisMonth_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mcaThisMonth.DateChanged
        SetColumnCaptions()
        txtDoctor.Properties.DataSource = Entities(Of User).GetAllOrderBy(Session, NHibernate.Expression.Order.Asc("LastName"), New Expressions.IsNull("DeleteTime"), New Expressions.Eq("Position.Mark", True), New Expressions.And(New Expressions.Le("WorksFrom", startDate), New Expressions.Or(New Expressions.IsNull("WorkedUntil"), New Expressions.Ge("WorkedUntil", startDate))))
        GetData()
    End Sub

    Private Sub OpenWorkTimeEdit(Optional ByVal add As Boolean = False)
        If bndPlanner.Current Is Nothing Then Return
        Dim obj As TimeTable
        Dim res As WorkTime
        obj = CType(bndPlanner.Current, TimeTable)
        res = ReflectionHelper.GetPropertyValue(obj, gvwPlanner.FocusedColumn.Name.Substring(3) & "Value")
        If res Is Nothing Then
            MsgBox.Show("Iezīmējiet ierakstu kuram ir norādīts laiks")
            Exit Sub
        End If
        'If Not res.FromUserWorkTime AndAlso res.Id = Guid.Empty AndAlso res.StartTime < DateTime.Now Then
        '    MsgBox.Show("Nevar ieplānot darba laiku ar iepriekšēju datumu.")
        '    Exit Sub
        'End If
        If Not res.GroupWork Is Nothing Then
            Dim frm As New frmGroupWorkEdit()
            frm.Session = Nothing
            frm.PartnerSession = Session
            Dim data As New System.Collections.Generic.Dictionary(Of System.Type, System.Guid)
            data.Add(GetType(WorkTime), res.Id)
            frm.DataIDs = data
            frm.ShowDialog()
        Else
            Dim frm As New frmWorkTimeEdit()
            frm.Session = Nothing
            frm.PartnerSession = Session
            frm.Tag = res

            Dim _data As New Dictionary(Of Type, Guid)
            _data.Add(GetType(WorkTime), Guid.Empty)
            frm.DataIDs = _data
            frm.ShowDialog()
        End If
        GetData()
    End Sub

    Private Sub GetData()
        Dim _list As Entities(Of TimeTable)
        If txtRoomGroup.EditValue Is Nothing AndAlso txtDoctor.EditValue Is Nothing Then
            _list = WorkTime.getData(Session, startDate, dayCount, Nothing, Nothing)
        ElseIf Not txtRoomGroup.EditValue Is Nothing Then
            _list = WorkTime.getData(Session, startDate, dayCount, Session.Get(Of RoomGroups)(CType(txtRoomGroup.EditValue, Guid)), Nothing)
        Else
            _list = WorkTime.getData(Session, startDate, dayCount, Nothing, Session.Get(Of User)(CType(txtDoctor.EditValue, Guid)))
        End If
        bndPlanner.DataSource = _list
    End Sub

    Private Sub gvwWorkTime_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvwPlanner.DoubleClick
        OpenWorkTimeEdit()
    End Sub

    Private Sub grdWorkTime_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdPlanner.MouseClick
        clickPlace = gvwPlanner.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub rbt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt1.CheckedChanged, rbt5.CheckedChanged, rbt7.CheckedChanged

        SetColumnCaptions()
        If rbt1.Checked Then
            dayCount = 1
        ElseIf rbt5.Checked Then
            colTuesday.Visible = True
            colWednesday.Visible = True
            colThursday.Visible = True
            colFriday.Visible = True
            colSaturday.Visible = True
            colSunday.Visible = False
            colMonday.VisibleIndex = 1
            colTuesday.VisibleIndex = 2
            colWednesday.VisibleIndex = 3
            colThursday.VisibleIndex = 4
            colFriday.VisibleIndex = 5
            colSaturday.VisibleIndex = 6
            dayCount = 6
        Else
            colTuesday.Visible = True
            colWednesday.Visible = True
            colThursday.Visible = True
            colFriday.Visible = True
            colSaturday.Visible = True
            colSunday.Visible = True
            colMonday.VisibleIndex = 1
            colTuesday.VisibleIndex = 2
            colWednesday.VisibleIndex = 3
            colThursday.VisibleIndex = 4
            colFriday.VisibleIndex = 5
            colSaturday.VisibleIndex = 6
            colSunday.VisibleIndex = 7
            dayCount = 7
        End If
        GetData()
    End Sub

    Private Function SetColumnCaptions(Optional ByVal _date As Date = Nothing) As Boolean

        If _date = Nothing Then
            Dim i As Integer = mcaThisMonth.SelectionStart.DayOfWeek
            If rbt1.Checked Then
                colMonday.Visible = False
                colTuesday.Visible = False
                colWednesday.Visible = False
                colThursday.Visible = False
                colFriday.Visible = False
                colSaturday.Visible = False
                colSunday.Visible = False
                Dim col As String = [Enum].GetName(GetType(DayOfWeek), mcaThisMonth.SelectionStart.DayOfWeek)
                gvwPlanner.Columns(col).Caption = mcaThisMonth.SelectionStart.ToShortDateString()
                gvwPlanner.Columns(col).Tag = mcaThisMonth.SelectionStart
                gvwPlanner.Columns(col).Visible = True
                gvwPlanner.Columns(col).VisibleIndex = 1
                startDate = mcaThisMonth.SelectionStart
                Return True
            Else
                If i = 0 Then
                    _date = mcaThisMonth.SelectionStart.AddDays(-6)
                Else
                    _date = mcaThisMonth.SelectionStart.AddDays(-i + 1)
                End If
            End If
        End If

        startDate = _date
        If Not rbt1.Checked And Not rbt5.Checked And Not rbt7.Checked Then Return False
        colMonday.Caption = _date.ToShortDateString()
        colMonday.Tag = _date.Date
        colTuesday.Caption = _date.AddDays(1).ToShortDateString()
        colTuesday.Tag = _date.AddDays(1).Date
        colWednesday.Caption = _date.AddDays(2).ToShortDateString()
        colWednesday.Tag = _date.AddDays(2).Date
        colThursday.Caption = _date.AddDays(3).ToShortDateString()
        colThursday.Tag = _date.AddDays(3).Date
        colFriday.Caption = _date.AddDays(4).ToShortDateString()
        colFriday.Tag = _date.AddDays(4).Date
        colSaturday.Caption = _date.AddDays(5).ToShortDateString()
        colSaturday.Tag = _date.AddDays(5).Date
        colSunday.Caption = _date.AddDays(6).ToShortDateString()
        colSunday.Tag = _date.AddDays(6).Date
        Return True
    End Function

    Private Sub gvwPlanner_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gvwPlanner.RowCellStyle

        Dim row As TimeTable = gvwPlanner.GetRow(e.RowHandle)
        Dim obj As WorkTime = ReflectionHelper.GetPropertyValue(row, e.Column.Name.Substring(3) & "Value")
        If obj Is Nothing Then
            Return
        End If
        If Not obj.User Is Nothing Then
            If obj.Acity Then
                e.Appearance.BackColor = Color.YellowGreen
                e.Appearance.BackColor2 = Color.YellowGreen
            ElseIf Not obj.GroupWork Is Nothing Then
                e.Appearance.BackColor = Color.LimeGreen
                e.Appearance.BackColor2 = Color.LimeGreen
            Else
                e.Appearance.BackColor = Color.Yellow
                e.Appearance.BackColor2 = Color.Yellow
            End If
        Else
            e.Appearance.BackColor = Color.Gray
            e.Appearance.BackColor2 = Color.Gray
        End If
        e.Appearance.ForeColor = Color.Black
    End Sub

    Private Sub bndPlanner_DataSourceChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndPlanner.DataSourceChanged
        If gvwPlanner.RowCount > 0 Then
            For i As Integer = 0 To gvwPlanner.RowCount - 1
                gvwPlanner.ExpandAllGroups()
            Next
        End If
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenWorkTimeEdit()
    End Sub

    Private Sub gbhWorkTime_OnDelete(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.DeleteEventArgs) Handles gbhWorkTime.OnDelete
        If bndPlanner.Current Is Nothing Then Return
        Dim obj As TimeTable
        Dim res As WorkTime
        obj = CType(bndPlanner.Current, TimeTable)
        res = ReflectionHelper.GetPropertyValue(obj, gvwPlanner.FocusedColumn.Name.Substring(3) & "Value")
        If res Is Nothing AndAlso res.User Is Nothing Then
            MsgBox.Show("Iezīmējiet ierakstu kuram ir norādīts laiks un ārsts")
            Exit Sub
        End If
        If MsgBox.DeleteMessage() = Windows.Forms.DialogResult.Yes Then
            Dim id As Guid
            If res.Id = Guid.Empty Then
                id = res.UserWorkTime.Id
            Else
                id = res.Id
            End If
            Dim visits As Entities(Of Visit) = Entities(Of Visit).GetAll(Session, New Expressions.Eq("Doctor", res.User), New Expressions.Eq("ParentId", id), New Expressions.Between("StartTime", res.StartTime, res.EndTime), New Expressions.IsNull("DeleteTime"))
            If visits.Count > 0 Then
                Core.UI.MsgBox.Show("Nav iespējams dzēst, jo šinī laikā ir ieplānotas vizītes." & visits.ToString())
                Exit Sub
            End If
            res.IsActive = False
            Session.SaveOrUpdate(res)
            Session.Commit()
            GetData()
        End If
    End Sub

    Private Sub gbhWorkTime_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhWorkTime.OnAddNew
        OpenWorkTimeEdit(True)
    End Sub

    Private Sub btnAddGroupWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddGroupWork.Click
        Dim frm As New frmGroupWorkEdit()
        frm.Session = Nothing
        frm.PartnerSession = Session
        Dim data As New System.Collections.Generic.Dictionary(Of System.Type, System.Guid)
        data.Add(GetType(WorkTime), Guid.Empty)
        frm.DataIDs = data
        frm.ShowDialog()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txtRoomGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomGroup.EditValueChanged
        If Not txtRoomGroup.EditValue Is Nothing Then
            txtDoctor.EditValue = Nothing
        End If
    End Sub

    Private Sub txtDoctor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDoctor.EditValueChanged
        If Not txtDoctor.EditValue Is Nothing Then
            txtRoomGroup.EditValue = Nothing
        End If
    End Sub

    Private Sub txtRoomGroup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRoomGroup.KeyDown
        If e.KeyCode = Keys.Delete Then
            txtRoomGroup.EditValue = Nothing
        ElseIf e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub txtDoctor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDoctor.KeyDown
        If e.KeyCode = Keys.Delete Then
            txtDoctor.EditValue = Nothing
        ElseIf e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        GetData()
    End Sub

    Private Sub gvwPlanner_ShowGridMenu(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs) Handles gvwPlanner.ShowGridMenu
        Dim View As GridView = CType(sender, GridView)
        Dim HitInfo As XtraGrid.Views.Grid.ViewInfo.GridHitInfo
        HitInfo = View.CalcHitInfo(e.Point)
        If HitInfo.InRowCell Then
            If bndPlanner.Current Is Nothing Then Exit Sub
            Dim obj As TimeTable
            Dim res As WorkTime
            obj = CType(bndPlanner.Current, TimeTable)
            res = ReflectionHelper.GetPropertyValue(obj, gvwPlanner.FocusedColumn.Name.Substring(3) & "Value")
            If res Is Nothing OrElse res.Id = Guid.Empty Then
                Exit Sub
            End If
            'If Not res.FromUserWorkTime AndAlso res.Id = Guid.Empty AndAlso res.StartTime < DateTime.Now Then
            '    MsgBox.Show("Nevar ieplānot darba laiku ar iepriekšēju datumu.")
            '    Exit Sub
            'End If
            If Not res.GroupWork Is Nothing Then
                Exit Sub
            Else
                ContextMenuStrip1.Show(View.GridControl, e.Point)
            End If

        End If
    End Sub

    Private Sub itmCopy_Click(sender As System.Object, e As System.EventArgs) Handles itmCopy.Click
        Dim frm As New frmActivityDateSelector()
        If (frm.ShowDialog() = DialogResult.OK) Then
            If bndPlanner.Current Is Nothing Then Exit Sub
            Dim obj As TimeTable
            Dim res As WorkTime
            obj = CType(bndPlanner.Current, TimeTable)
            res = ReflectionHelper.GetPropertyValue(obj, gvwPlanner.FocusedColumn.Name.Substring(3) & "Value")
            If res Is Nothing OrElse res.Id = Guid.Empty Then
                Exit Sub
            End If
            frmWorkTimeEdit.btnSave.PerformClick()
        End If
    End Sub
End Class
