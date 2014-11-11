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


Public Class frmPlanner

    Private dayCount As Integer
    Private startDate As Date
    Public patient1 As Patient
    Public patient2 As Patient
    Public patient3 As Patient
    Public selectedDoctor As User
    Public grupuNodarbibas As Boolean
    Dim length As Integer = 0
    Private clickPlace As GridHitInfo
    Private selectedWorkTime As WorkTime
    Private visit As Visit
    Private doubleVisitPatMonday As List(Of Patient)
    Private doubleVisitPatTyesday As List(Of Patient)
    Private doubleVisitPatWednesday As List(Of Patient)
    Private doubleVisitPatThursday As List(Of Patient)
    Private doubleVisitPatFriday As List(Of Patient)
    Private doubleVisitPatSaturday As List(Of Patient)
    Private doubleVisitPatSunday As List(Of Patient)

    Private doublePatientsCollected As Boolean = False

    Private Sub mcaThisMonth_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mcaThisMonth.DateSelected
        SetColumnCaptions()
        mcaThisMonth.SelectionRange.Start = startDate
        mcaThisMonth.SelectionRange.End = startDate.AddDays(dayCount)
        ReadData()
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
        'Dim list As Entities(Of TimeTable) = Visit.GetData(Session, startDate, dayCount, CType(txtService.EditValue, Services), CType(txtDoctor.EditValue, User))
        'bndData.DataSource = list
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

    Private Sub frmPlanner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = Now.DayOfWeek
        Dim startDate As Date
        If rbt1.Checked Then
            colMonday.Caption = Now.ToShortDateString()
            colMonday.Tag = Now.Date
        Else
            If i = 0 Then
                startDate = Now.AddDays(-6)
            Else
                startDate = Now.AddDays(-i + 1)
            End If
            SetColumnCaptions(startDate)
        End If
        gbhPlanner.Controls.SetChildIndex(btnOpen, 0)
        grdPlanner.EnforceCanEdit = False
        rbt5.Checked = True
        EnableControls()
        bndSpeciality.DataSource = Entities(Of SpecialityGroups).GetAllOrderBy(Session, NHibernate.Expression.Order.Asc("Value"), New Expressions.IsNull("DeleteTime"))
        RefreshServices()
        RefreshDoctor()
    End Sub

    Private Sub RefreshServices()
        If chkVisitPlaner.Checked Then
            Dim criteria As New List(Of Expressions.CriterionBase)
            If Not txtDoctor.EditValue Is Nothing Then
                Dim obj As IList(Of Guid) = New List(Of Guid)

                For Each x As UserService In Session.Get(Of User)(CType(txtDoctor.EditValue, Guid)).UserServices.ActiveItemsWithoutEmpty
                    obj.Add(x.Service.Id)
                Next
                criteria.Add(CriteriaBuilder.IsInCollection("Id", obj))
            End If
            If Not txtSpeciality.EditValue Is Nothing AndAlso txtDoctor.EditValue Is Nothing AndAlso txtService.EditValue Is Nothing Then
                Dim obj As IList(Of Guid) = New List(Of Guid)
                Dim sp As SpecialityGroups = Session.Get(Of SpecialityGroups)(CType(txtSpeciality.EditValue, Guid))
                For Each z As Speciality In sp.Specialities
                    For Each j As Services In z.Services
                        If Not obj.Contains(j.Id) Then
                            obj.Add(j.Id)
                        End If
                    Next
                Next
                criteria.Add(CriteriaBuilder.IsInCollection("Id", obj))
            End If
            criteria.Add(New Expressions.IsNull("DeleteTime"))
            bndServices.DataSource = Entities(Of Services).GetAll(Session, criteria)

            If Not txtDoctor.EditValue Is Nothing Then
                Dim usr = Session.Get(Of User)(CType(txtDoctor.EditValue, Guid))
                For Each service As Services In bndServices
                    For Each userService1 As UserService In usr.UserServices.ActiveItemsWithoutEmpty
                        If service.Id = userService1.Service.Id Then
                            service.SetPriceandTime(userService1.ManualPrice, userService1.ManualTime)
                            Exit For
                        End If
                    Next
                Next
            End If

        ElseIf chkGroupPlaner.Checked Then
            bndServices.DataSource = Entities(Of GroupsWork).GetAllOrderBy(Session, NHibernate.Expression.Order.Asc("Value"), New Expressions.IsNull("DeleteTime"))
        End If
    End Sub

    Private Sub txtDoctor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDoctor.KeyDown
        If e.KeyCode = Keys.Delete Then
            txtDoctor.EditValue = Nothing
            RefreshServices()
            ReadData()
        ElseIf e.KeyCode = Keys.Enter Then
            RefreshServices()
            ReadData()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ReadData()
    End Sub

    Public Sub Read(ByVal speciality As Speciality, ByVal visitType As VisitType, ByVal user As User, ByVal dataSource As IList(Of TimeTable), ByVal startDate As DateTime, ByVal dayCount As Integer)
        Dim specialityExp As Expressions.CriterionBase
        Dim userExp As Expressions.CriterionBase
        Dim onDate As DateTime = startDate.Date
        Dim _work As IList(Of Guid) = New List(Of Guid)
        Dim _userWorkTime As Entities(Of UsersWorkTime)
        Dim _dayOfWeek As Day = Nothing
        If Not speciality Is Nothing Then
            specialityExp = New Expressions.Eq("Speciality", speciality)
        End If
        If Not user Is Nothing Then
            userExp = New Expressions.Eq("User", user)
        End If
        dataSource.Clear()

        If user Is Nothing Then
            Dim users As Entities(Of User)
            users = Entities(Of User).GetAll(Session, New Expressions.Eq("Position.Mark", True), New Expressions.Eq("UserSpecialities.Speciality.Id", speciality.Id), New Expressions.IsNull("UserSpecialities.DeleteTime"))
            For Each u As User In users

                Dim worktime As Entities(Of WorkTime)
                worktime = Entities(Of WorkTime).GetAll(Session, New Expressions.Eq("User.Id", u.Id), New Expressions.And(New Expressions.Ge("StartTime", startDate), New Expressions.Le("EndTime", startDate.AddDays(dayCount))))
                For Each y As WorkTime In worktime
                    If Not y.UserWorkTime Is Nothing Then
                        _work.Add(y.UserWorkTime.Id)
                    End If
                Next

                For z As Integer = 0 To dayCount - 1
                    onDate = startDate.Date.AddDays(z)
                    Select Case (onDate.DayOfWeek)
                        Case DayOfWeek.Sunday
                            _dayOfWeek = Day.Sanday
                        Case DayOfWeek.Monday
                            _dayOfWeek = Day.Monday
                        Case DayOfWeek.Tuesday
                            _dayOfWeek = Day.Tuesday
                        Case DayOfWeek.Wednesday
                            _dayOfWeek = Day.Wednesday
                        Case DayOfWeek.Friday
                            _dayOfWeek = Day.Friday
                        Case DayOfWeek.Saturday
                            _dayOfWeek = Day.Saturday
                    End Select
                    _userWorkTime = Entities(Of UsersWorkTime).GetAll(Session, New Expressions.Eq("User.Id", u.Id), New Expressions.Eq("DayOfWeek", _dayOfWeek), CriteriaBuilder.IsNotInCollection("Id", _work))
                    For Each y As UsersWorkTime In _userWorkTime
                        Dim _uwt = New WorkTime(Session, onDate)
                        _uwt.FromUserWorkTime = True
                        _uwt.User = y.User
                        _uwt.Room = y.Room
                        _uwt.UserWorkTime = y
                        _uwt.StartTime = startDate.Date.AddHours(y.StartTime.Hour).AddMinutes(y.StartTime.Minute)
                        _uwt.EndTime = startDate.Date.AddHours(y.EndTime.Hour).AddMinutes(y.EndTime.Minute)
                        _uwt.Acity = y.Acyity
                        worktime.Add(_uwt)
                    Next
                Next

                Dim visits As Entities(Of Visit) = Entities(Of Visit).GetAll(Session, New Expressions.Eq("Doctor.Id", u.Id), New Expressions.And(New Expressions.Ge("StartTime", startDate), New Expressions.Le("EndTime", startDate.AddDays(dayCount))))

                For Each m As WorkTime In worktime
                    For Each n As Visit In visits
                        If n.Used = False AndAlso m.StartTime.Date = n.StartTime.Date AndAlso m.User.Id = n.Doctor.Id Then
                            If FreePlace(m.StartTime, m.EndTime, n.StartTime, n.EndTime, m.UsedTime) Then
                                m.UsedTime.Add(n)
                                n.Used = True
                            End If
                        End If
                    Next
                Next
                Dim listByDate As Dictionary(Of DateTime, SortedList(Of DateTime, WorkTime)) = New Dictionary(Of DateTime, SortedList(Of DateTime, WorkTime))
                For Each x As WorkTime In worktime
                    If Not listByDate.ContainsKey(x.StartTime.Date) Then
                        listByDate.Add(x.StartTime.Date, New SortedList(Of DateTime, WorkTime))
                    End If
                    listByDate(x.StartTime.Date).Add(x.StartTime, x)
                Next

                Dim currentTime As DateTime

                Dim timeDiagramm As Dictionary(Of DateTime, List(Of KeyValuePair(Of DateTime, DateTime))) = New Dictionary(Of DateTime, List(Of KeyValuePair(Of DateTime, DateTime)))
                For Each x As KeyValuePair(Of DateTime, SortedList(Of DateTime, WorkTime)) In listByDate
                    If Not timeDiagramm.ContainsKey(x.Key) Then
                        timeDiagramm.Add(x.Key, New List(Of KeyValuePair(Of DateTime, DateTime)))
                    End If
                    For Each y As WorkTime In x.Value.Values
                        currentTime = y.StartTime
                        If y.UsedTime.Count = 0 Then
                            Dim _obj As New TimeTable()
                            _obj.Monday = "Kabinets " & y.Room.ToString() & " Laiks " & y.StartTime.ToShortTimeString() & " - " & y.EndTime.ToShortTimeString() & IIf(y.Acity, " Akûtās vizītes", "").ToString()
                            Dim temp As New Visit(Session)
                            temp.Doctor = y.User
                            temp.Start = y.StartTime
                            temp.StartTime = y.StartTime
                            temp.EndT = y.EndTime
                            temp.EndTime = temp.StartTime.AddMinutes(visitType.DecimalValue)
                            'temp.VisitType = visitType
                            _obj.MondayValue = temp
                            _obj.MondayAcyity = y.Acity
                            _obj.Doctor = y.User
                            dataSource.Add(_obj)
                        Else
                            For Each j As Visit In y.UsedTime
                                j.Used = False
                            Next
                            Dim dict As New SortedDictionary(Of DateTime, Visit)
                            For Each j As Visit In y.UsedTime
                                dict.Add(j.StartTime, j)
                            Next

                            For Each time As KeyValuePair(Of DateTime, Visit) In dict
                                If currentTime.TimeOfDay = time.Key.TimeOfDay Then
                                    Dim _obj As New TimeTable()
                                    _obj.Monday = "Kabinets " & y.Room.ToString() & " Laiks " & time.Value.StartTime.ToShortTimeString() & " - " & time.Value.EndTime.ToShortTimeString() & IIf(time.Value.Acyity, " Akûtās vizītes", " ").ToString() & time.Value.Patient.ToString()
                                    _obj.MondayValue = time.Value
                                    _obj.MondayAcyity = time.Value.Acyity
                                    _obj.Doctor = time.Value.Doctor
                                    time.Value.Start = time.Value.StartTime
                                    time.Value.EndT = time.Value.EndTime
                                    dataSource.Add(_obj)
                                    currentTime = time.Value.EndTime
                                Else
                                    Dim _obj As New TimeTable()
                                    _obj.Monday = "Kabinets " & y.Room.ToString() & " Laiks " & currentTime.ToShortTimeString() & " - " & time.Value.StartTime.ToShortTimeString() & IIf(time.Value.Acyity, " Akûtās vizītes", "").ToString()
                                    Dim temp As New Visit(Session)
                                    temp.Doctor = y.User
                                    temp.Start = currentTime
                                    temp.StartTime = currentTime
                                    temp.EndTime = temp.StartTime.AddMinutes(visitType.DecimalValue)
                                    temp.EndT = time.Value.StartTime
                                    'temp.VisitType = visitType
                                    _obj.MondayValue = temp
                                    _obj.MondayAcyity = y.Acity
                                    _obj.Doctor = y.User
                                    dataSource.Add(_obj)
                                End If
                            Next
                            If currentTime < y.EndTime Then
                                Dim _obj As New TimeTable()
                                _obj.Monday = "Kabinets " & y.Room.ToString() & " Laiks " & currentTime.ToShortTimeString() & " - " & y.EndTime.ToShortTimeString() & IIf(y.Acity, " Akûtās vizītes", "").ToString()
                                Dim temp As New Visit(Session)
                                temp.Doctor = y.User
                                temp.Start = currentTime
                                temp.EndT = y.EndTime
                                temp.StartTime = currentTime
                                temp.EndTime = temp.StartTime.AddMinutes(visitType.DecimalValue)
                                'temp.VisitType = visitType
                                _obj.MondayValue = temp
                                _obj.MondayAcyity = y.Acity
                                _obj.Doctor = y.User
                                dataSource.Add(_obj)
                            End If
                        End If

                    Next
                Next
            Next
        End If

    End Sub

    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gvwPlanner.RowCellStyle
        If (Not doublePatientsCollected) Then
            CollectDoublePatients()
        End If
        Dim row As TimeTable = gvwPlanner.GetRow(e.RowHandle)
        Dim tempObj As Object = ReflectionHelper.GetPropertyValue(row, e.Column.Name.Substring(3) & "Value")
        If tempObj Is Nothing Then
            Return
        End If
        If tempObj.GetType().Name = "WorkTime" Then
            Dim obj As WorkTime = CType(tempObj, WorkTime)
            If obj.EndTime < DateTime.Now Then
                e.Appearance.BackColor = Color.DarkGray
                e.Appearance.BackColor2 = Color.DarkGray
                Return
            End If
            If Not obj.User Is Nothing Then
                If Not txtService.EditValue Is Nothing AndAlso chkVisitPlaner.Checked Then

                    Dim service As Services = Nothing
                    If Not txtService.EditValue Is Nothing Then
                        service = Session.Get(Of Services)(CType(txtService.EditValue, Guid))
                    End If
                    Dim userServices As Entities(Of UserService) = Entities(Of UserService).GetAll(Session, New Expressions.IsNull("DeleteTime"), New Expressions.Eq("User.Id", obj.User.Id), New Expressions.Eq("Service.Id", CType(txtService.EditValue, Guid)))
                    For Each x As UserService In userServices
                        If x.ManualTime.HasValue Then
                            length = x.ManualTime.Value
                        Else
                            length = service.IntegerValue
                        End If
                    Next
                Else
                    length = 0
                End If
                If obj.Acity Then
                    If (obj.EndTime.TimeOfDay.TotalMinutes - obj.StartTime.TimeOfDay.TotalMinutes) >= length Then
                        e.Appearance.BackColor = Color.YellowGreen
                        e.Appearance.BackColor2 = Color.YellowGreen
                    Else
                        e.Appearance.BackColor = Color.Red
                        e.Appearance.BackColor2 = Color.Red
                    End If
                Else
                    If (obj.EndTime.TimeOfDay.TotalMinutes - obj.StartTime.TimeOfDay.TotalMinutes) >= length Then
                        e.Appearance.BackColor = Color.Yellow
                        e.Appearance.BackColor2 = Color.Yellow
                    Else
                        e.Appearance.BackColor = Color.Red
                        e.Appearance.BackColor2 = Color.Red
                    End If
                End If
            Else
                e.Appearance.BackColor = Color.Gray
                e.Appearance.BackColor2 = Color.Gray
            End If
        End If
        If tempObj.GetType().Name = "Visit" Then
            If (e.Column.Name = "colMonday") Then

            End If
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.BackColor2 = Color.LightGray
            If Not e.Column.Tag Is Nothing Then
                Dim datums As DateTime = CDate(e.Column.Tag)
                Select Case (datums.DayOfWeek)
                    Case DayOfWeek.Monday
                        Dim tp As Visit = CType(tempObj, Visit)
                        If doubleVisitPatMonday.Contains(tp.Patient) Then
                            e.Appearance.BackColor = Color.LightPink
                            e.Appearance.BackColor2 = Color.LightPink
                        End If
                    Case DayOfWeek.Tuesday
                        Dim tp As Visit = CType(tempObj, Visit)
                        If doubleVisitPatTyesday.Contains(tp.Patient) Then
                            e.Appearance.BackColor = Color.LightPink
                            e.Appearance.BackColor2 = Color.LightPink
                        End If
                    Case DayOfWeek.Wednesday
                        Dim tp As Visit = CType(tempObj, Visit)
                        If doubleVisitPatWednesday.Contains(tp.Patient) Then
                            e.Appearance.BackColor = Color.LightPink
                            e.Appearance.BackColor2 = Color.LightPink
                        End If
                    Case DayOfWeek.Thursday
                        Dim tp As Visit = CType(tempObj, Visit)
                        If doubleVisitPatThursday.Contains(tp.Patient) Then
                            e.Appearance.BackColor = Color.LightPink
                            e.Appearance.BackColor2 = Color.LightPink
                        End If
                    Case DayOfWeek.Friday
                        Dim tp As Visit = CType(tempObj, Visit)
                        If doubleVisitPatFriday.Contains(tp.Patient) Then
                            e.Appearance.BackColor = Color.LightPink
                            e.Appearance.BackColor2 = Color.LightPink
                        End If
                    Case DayOfWeek.Saturday
                        Dim tp As Visit = CType(tempObj, Visit)
                        If doubleVisitPatSaturday.Contains(tp.Patient) Then
                            e.Appearance.BackColor = Color.LightPink
                            e.Appearance.BackColor2 = Color.LightPink
                        End If
                    Case DayOfWeek.Sunday
                        Dim tp As Visit = CType(tempObj, Visit)
                        If doubleVisitPatSunday.Contains(tp.Patient) Then
                            e.Appearance.BackColor = Color.LightPink
                            e.Appearance.BackColor2 = Color.LightPink
                        End If
                End Select
            End If
        End If
    End Sub

    Public Function FreePlace(ByVal baseStart As DateTime, ByVal baseEnd As DateTime, ByVal objStart As DateTime, ByVal objEnd As DateTime, ByVal list As IList(Of Visit)) As Boolean
        If list.Count = 0 AndAlso baseStart.TimeOfDay <= objStart.TimeOfDay AndAlso baseEnd.TimeOfDay >= objEnd.TimeOfDay Then
            Return True
        End If

        For Each x As Visit In list
            If (x.StartTime.TimeOfDay >= objStart.TimeOfDay AndAlso x.StartTime.TimeOfDay < objEnd.TimeOfDay) Then
                Return False
            End If
            If (x.EndTime.TimeOfDay > objStart.TimeOfDay AndAlso x.EndTime.TimeOfDay < objEnd.TimeOfDay) Then
                Return False
            End If
            If (x.StartTime.TimeOfDay <= objStart.TimeOfDay AndAlso x.EndTime.TimeOfDay >= objEnd.TimeOfDay) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub gvwPlanner_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvwPlanner.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        If clickPlace.HitTest = GridHitTest.RowCell Then
            If bndData.Current Is Nothing Then Return
            Dim obj As Object = ReflectionHelper.GetPropertyValue(bndData.Current, Mid(gvwPlanner.FocusedColumn.Name, 4) & "Value")
            If obj Is Nothing Then
                Return
            End If
            If chkVisitPlaner.Checked Then
                If obj.GetType().Name = "Visit" Then
                    OpenVisit()
                ElseIf obj.GetType.Name = "WorkTime" Then
                    AddVisit()
                End If
            End If
            If chkGroupPlaner.Checked Then
                OpenGroupWorkVists()
            End If
        End If
    End Sub

    Private Sub bndData_DataSourceChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndData.DataSourceChanged
        If gvwPlanner.RowCount > 0 Then
            For i As Integer = 0 To gvwPlanner.RowCount - 1
                gvwPlanner.ExpandAllGroups()
            Next
        End If
    End Sub

    'Private Sub txtService_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtService.ButtonClick
    '    If chkGroupPlaner.Checked Then
    '        Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(GroupsWork), Session), Session)
    '        frm.FormMode = ClassifierListMode.SingleSelect

    '        frm.Selection = Nothing
    '        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
    '            bndData.DataSource = New Entities(Of TimeTable)
    '        End If
    '    Else
    '        Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(Services), Session), Session)
    '        frm.FormMode = ClassifierListMode.SingleSelect
    '        Dim obj As IList(Of Guid) = New List(Of Guid)

    '        If Not txtDoctor.EditValue Is Nothing Then
    '            For Each x As UserService In CType(txtDoctor.EditValue, User).UserServices.ActiveItemsWithoutEmpty
    '                obj.Add(x.Service.Id)
    '            Next
    '        Else
    '            Dim list As IChildCollection(Of Services) = CType(bndSpeciality.Current, Speciality).Services
    '            For Each x As Services In list.ActiveItemsWithoutEmpty
    '                obj.Add(x.Id)
    '            Next
    '        End If
    '        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
    '        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
    '        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseInClassifier", True))
    '        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif

    '        frm.Selection = Nothing
    '        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
    '            bndData.DataSource = New Entities(Of TimeTable)
    '        End If
    '    End If
    '    ReadData()
    'End Sub

    Private Sub gbhPlanner_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhPlanner.OnAddNew
        If txtService.EditValue Is Nothing Then
            MsgBox.Show("Nav norādīts pakalpojums, kas tiks sniegts vizītes laikā.")
        Else
            AddVisit()
        End If
    End Sub

    Private Sub AddVisit()
        If bndData.Current Is Nothing Then Return
        Dim obj As TimeTable
        Dim res As WorkTime
        obj = CType(bndData.Current, TimeTable)
        Dim o As Object = ReflectionHelper.GetPropertyValue(obj, gvwPlanner.FocusedColumn.Name.Substring(3) & "Value")
        If o Is Nothing Then Return
        If o.GetType().Name = "Visit" Then
            Return
        End If
        res = CType(o, WorkTime)
        If txtService.EditValue Is Nothing Then
            SetService(res)
            ReadData()
            Return
        End If
        If Not (res.EndTime.TimeOfDay.TotalMinutes - res.StartTime.TimeOfDay.TotalMinutes) >= length Then
            Core.UI.MsgBox.Show("Nav iespējams ieplānot vizīti jo atlikušais laiks ir pārāk īsss")
            Exit Sub
        End If

        Dim frm As New frmVisitEdit()
        frm.Session = Nothing
        frm.PartnerSession = Session
        frm.serviceId = CType(txtService.EditValue, Guid)
        frm.visit = Nothing
        frm.Tag = res
        frm.patient1 = patient1
        frm.patient2 = patient2
        frm.patient3 = patient3
        frm.tempVisit = visit

        frm.ShowDialog()
        ReadData()

    End Sub

    Private Sub SetService(ByVal wt As WorkTime)
        If wt.User Is Nothing Then Return
        Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(Services), Session), Session, ClassifierListMode.SingleSelect)
        Dim obj As IList(Of Guid) = New List(Of Guid)

        For Each x As UserService In wt.User.UserServices.ActiveItemsWithoutEmpty
            obj.Add(x.Service.Id)
        Next

        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseInClassifier", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif

        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDoctor.ItemIndex = bndUser.IndexOf(wt.User)
            RefreshServices()
            bndServices.Position = bndServices.IndexOf(frm.Selection)
            txtService.ItemIndex = bndServices.Position
        End If
    End Sub

    'Private Sub txtService_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtService.KeyDown
    '    If (e.KeyCode = Keys.Delete) Then
    '        txtService.EditValue = Nothing
    '        ReadData()
    '    End If
    'End Sub

    Private Sub ReadData()
        Session.Clear()
        Entities(Of Room).GetAll(Session)
        Entities(Of Speciality).GetAll(Session)
        Entities(Of SpecialityGroups).GetAll(Session)
        doublePatientsCollected = False
        Dim user As User = Nothing
        If Not txtDoctor.EditValue Is Nothing Then
            user = Session.Get(Of User)(CType(txtDoctor.EditValue, Guid))
        End If
        Dim service As Services = Nothing
        If Not txtService.EditValue Is Nothing Then
            service = Session.Get(Of Services)(CType(txtService.EditValue, Guid))
        End If
        Dim specilaityGroup As SpecialityGroups = Nothing
        If Not txtSpeciality.EditValue Is Nothing Then
            specilaityGroup = Session.Get(Of SpecialityGroups)(CType(txtSpeciality.EditValue, Guid))
        End If
        grdPlanner.EnforceCanEdit = False
        If chkVisitPlaner.Checked Then
            bndData.DataSource = Visit.GetData(Session, startDate, dayCount, service, user, specilaityGroup)
            EnableControls()
        ElseIf chkGroupPlaner.Checked Then
            Dim groupsWork As GroupsWork = Nothing
            If Not txtService.EditValue Is Nothing Then
                groupsWork = Session.Get(Of GroupsWork)(CType(txtService.EditValue, Guid))
            End If
            bndData.DataSource = Visit.GetGroupWorkData(Session, startDate, dayCount, groupsWork, user)
            EnableControls()
        ElseIf chkVisitStatusViewer.Checked Then
            bndData.DataSource = New Entities(Of TimeTable)
        Else
            bndData.DataSource = New Entities(Of TimeTable)
        End If
        colMonday.BestFit()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If chkVisitPlaner.Checked Then
            OpenVisit()
        End If
        If chkGroupPlaner.Checked Then
            OpenGroupWorkVists()
        End If
    End Sub

    Private Sub CollectDoublePatients()
        doubleVisitPatMonday = New List(Of Patient)()
        doubleVisitPatTyesday = New List(Of Patient)
        doubleVisitPatWednesday = New List(Of Patient)
        doubleVisitPatThursday = New List(Of Patient)
        doubleVisitPatFriday = New List(Of Patient)
        doubleVisitPatSaturday = New List(Of Patient)
        doubleVisitPatSunday = New List(Of Patient)

        Dim tmpMonday As New List(Of Patient)()
        Dim tmpTyesday As New List(Of Patient)()
        Dim tmpWednesday As New List(Of Patient)()
        Dim tmpThursday As New List(Of Patient)()
        Dim tmpFriday As New List(Of Patient)()
        Dim tmpSaturday As New List(Of Patient)()
        Dim tmpSunday As New List(Of Patient)()

        If chkDoublePatients.Checked Then
            For Each o As TimeTable In bndData
                Dim usr As Patient
                If (Not o.MondayValue Is Nothing AndAlso o.MondayValue.GetType().Name = "Visit") Then
                    usr = CType(o.MondayValue, Visit).Patient
                    If (Not usr Is Nothing AndAlso tmpMonday.Contains(usr)) Then
                        doubleVisitPatMonday.Add(usr)
                    Else
                        tmpMonday.Add(usr)
                    End If
                End If
                usr = Nothing
                If (Not o.TuesdayValue Is Nothing AndAlso o.TuesdayValue.GetType().Name = "Visit") Then
                    usr = CType(o.TuesdayValue, Visit).Patient
                    If (Not usr Is Nothing AndAlso tmpTyesday.Contains(usr)) Then
                        doubleVisitPatTyesday.Add(usr)
                    Else
                        tmpTyesday.Add(usr)
                    End If
                End If
                usr = Nothing
                If (Not o.WednesdayValue Is Nothing AndAlso o.WednesdayValue.GetType().Name = "Visit") Then
                    usr = CType(o.WednesdayValue, Visit).Patient
                    If (Not usr Is Nothing AndAlso tmpWednesday.Contains(usr)) Then
                        doubleVisitPatWednesday.Add(usr)
                    Else
                        tmpWednesday.Add(usr)
                    End If
                End If
                usr = Nothing
                If (Not o.ThursdayValue Is Nothing AndAlso o.ThursdayValue.GetType().Name = "Visit") Then
                    usr = CType(o.ThursdayValue, Visit).Patient

                    If (Not usr Is Nothing AndAlso tmpThursday.Contains(usr)) Then
                        doubleVisitPatThursday.Add(usr)
                    Else
                        tmpThursday.Add(usr)
                    End If
                End If
                usr = Nothing
                If (Not o.FridayValue Is Nothing AndAlso o.FridayValue.GetType().Name = "Visit") Then
                    usr = CType(o.FridayValue, Visit).Patient
                    If (Not usr Is Nothing AndAlso tmpFriday.Contains(usr)) Then
                        doubleVisitPatFriday.Add(usr)
                    Else
                        tmpFriday.Add(usr)
                    End If
                End If
                usr = Nothing
                If (Not o.SaturdayValue Is Nothing AndAlso o.SaturdayValue.GetType().Name = "Visit") Then
                    usr = CType(o.SaturdayValue, Visit).Patient
                    If (Not usr Is Nothing AndAlso tmpSaturday.Contains(usr)) Then
                        doubleVisitPatSaturday.Add(usr)
                    Else
                        tmpSaturday.Add(usr)
                    End If
                End If
                usr = Nothing
                If (Not o.SundayValue Is Nothing AndAlso o.SundayValue.GetType().Name = "Visit") Then
                    usr = CType(o.SundayValue, Visit).Patient
                    If (Not usr Is Nothing AndAlso tmpSunday.Contains(usr)) Then
                        doubleVisitPatSunday.Add(usr)
                    Else
                        tmpSunday.Add(usr)
                    End If
                End If
                usr = Nothing
            Next
        End If
        doublePatientsCollected = True
    End Sub

    Private Sub OpenVisit()
        If bndData.Current Is Nothing Then Return
        Dim obj As TimeTable
        Dim res As Visit
        obj = CType(bndData.Current, TimeTable)
        If ReflectionHelper.GetPropertyValue(obj, gvwPlanner.FocusedColumn.Name.Substring(3) & "Value").GetType().Name = "WorkTime" Then
            Return
        End If
        res = ReflectionHelper.GetPropertyValue(obj, gvwPlanner.FocusedColumn.Name.Substring(3) & "Value")
        If res Is Nothing Then
            MsgBox.Show("Iezīmējiet ierakstu kuram ir norādīts laiks un kabinets.")
            Exit Sub
        End If
        Dim frm As New frmVisitEdit()
        frm.Session = Nothing
        frm.PartnerSession = Session
        frm.visit = res
        frm.Tag = res

        frm.ShowDialog()
        ReadData()
    End Sub

    Private Sub OpenGroupWorkVists()
        If bndData.Current Is Nothing Then Return
        Dim obj As TimeTable
        Dim res As WorkTime
        obj = CType(bndData.Current, TimeTable)
        If Not ReflectionHelper.GetPropertyValue(obj, gvwPlanner.FocusedColumn.Name.Substring(3) & "Value").GetType().Name = "WorkTime" Then
            Return
        End If
        res = ReflectionHelper.GetPropertyValue(obj, gvwPlanner.FocusedColumn.Name.Substring(3) & "Value")
        If res Is Nothing Then
            MsgBox.Show("Iezīmējiet ierakstu kuram ir norādīts laiks un kabinets.")
            Exit Sub
        End If
        Dim frm As New frmGroupWorkVisitsEdit()
        frm.Session = Nothing
        frm.PartnerSession = Session

        Dim _data As New Dictionary(Of Type, Guid)
        _data.Add(GetType(WorkTime), res.Id)
        frm.DataIDs = _data
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

    End Sub

    Private Sub gbhPlanner_OnDelete(ByVal sender As Object, ByVal args As Core.UI.GridButtonHelper.DeleteEventArgs) Handles gbhPlanner.OnDelete
        grdPlanner.EnforceCanEdit = False
        If bndData.Current Is Nothing Then Return
        Dim obj As Object = ReflectionHelper.GetPropertyValue(bndData.Current, Mid(gvwPlanner.FocusedColumn.Name, 4) & "Value")
        If obj Is Nothing Then
            Return
        End If
        If obj.GetType().Name = "Visit" Then
            If Core.UI.MsgBox.DeleteMessage() = Windows.Forms.DialogResult.Yes Then
                Dim jaunasesija As ISession = Dal.Manager.Instance.OpenSession()
                Dim vis As Visit = jaunasesija.Get(Of Visit)(CType(obj, Visit).Id)
                vis.IsActive = False
                jaunasesija.SaveOrUpdate(vis)
                jaunasesija.Commit()
                ReadData()
            End If
        ElseIf obj.GetType.Name = "WorkTime" Then
            Core.UI.MsgBox.Show("Dzēst iespējams tikai vizītis.")
        End If
    End Sub

    Private Sub gvwPlanner_FocusedColumnChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles gvwPlanner.FocusedColumnChanged
        EnableControls()
    End Sub

    Private Sub gvwPlanner_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvwPlanner.FocusedRowChanged
        EnableControls()
    End Sub

    Private Sub EnableControls()
        If bndData.Current Is Nothing Then
            gbhPlanner.AddNewButton.Enabled = False
            gbhPlanner.DeleteButton.Enabled = False
            btnOpen.Enabled = False
            Return
        End If
        Dim obj As Object = ReflectionHelper.GetPropertyValue(bndData.Current, Mid(gvwPlanner.FocusedColumn.Name, 4) & "Value")

        If obj Is Nothing Then
            gbhPlanner.DeleteButton.Enabled = False
            btnOpen.Enabled = False
            gbhPlanner.AddNewButton.Enabled = False
            Return
        End If
        If chkVisitPlaner.Checked Then
            If obj.GetType.Name = "Visit" Then
                btnOpen.Enabled = True
                gbhPlanner.DeleteButton.Enabled = True
            Else
                If txtService.EditValue Is Nothing Then
                    gbhPlanner.AddNewButton.Enabled = False
                Else
                    gbhPlanner.AddNewButton.Enabled = True
                End If
                gbhPlanner.DeleteButton.Enabled = False
                btnOpen.Enabled = False
            End If
        End If
        If chkGroupPlaner.Checked Then
            gbhPlanner.AddNewButton.Enabled = False
            gbhPlanner.DeleteButton.Enabled = False
            btnOpen.Enabled = True
        End If
    End Sub

    Private Sub chkVisitPlaner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVisitPlaner.CheckedChanged
        If chkVisitPlaner.Checked Then
            chkVisitStatusViewer.Checked = False
            chkGroupPlaner.Checked = False
            lblService.Text = "Pakalpojums:"
            txtService.EditValue = Nothing
            txtSpeciality.Enabled = True
            RefreshServices()
        End If
    End Sub

    Private Sub chkVisitStatusViewer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVisitStatusViewer.CheckedChanged
        If chkVisitStatusViewer.Checked Then
            chkVisitPlaner.Checked = False
            chkGroupPlaner.Checked = False
            RefreshServices()
        End If
    End Sub

    Private Sub chkGroupPlaner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroupPlaner.CheckedChanged
        If chkGroupPlaner.Checked Then
            chkVisitStatusViewer.Checked = False
            chkVisitPlaner.Checked = False
            lblService.Text = "Grupas nodarbība:"
            txtService.EditValue = Nothing
            txtSpeciality.Enabled = False
            RefreshServices()
        End If
    End Sub

    Public Sub SetPatient(ByVal _patient1 As Patient, ByVal _patient2 As Patient, ByVal _patient3 As Patient)
        'patient1 = _patient1
        'patient2 = _patient2
        'patient2 = _patient3
        'Dim str As String = ""
        'If Not patient1 Is Nothing Then
        '    str = patient1.FullName
        'End If
        'If Not patient2 Is Nothing Then
        '    str &= "; " & patient2.FullName
        'End If
        'If Not patient3 Is Nothing Then
        '    str &= "; " & patient3.FullName
        'End If
        'lblPatientName.Text = str
        'gbxPatient.Visible = True
    End Sub

    Private Sub btnClearPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'patient1 = Nothing
        'patient2 = Nothing
        'patient3 = Nothing
        'lblPatientName.Text = ""
        'gbxPatient.Visible = True
    End Sub

    Private Sub LookUpEdit1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtService.ButtonClick
        'txtService.CancelPopup()
        If chkGroupPlaner.Checked Then
            Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(GroupsWork), Session), Session, ClassifierListMode.SingleSelect)
            
            frm.Selection = Nothing
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
                bndData.DataSource = New Entities(Of TimeTable)
            End If
        Else
            Dim frm As New frmClassifierList(Entities.ClassifierType.FromType(GetType(Services), Session), Session, ClassifierListMode.SingleSelect)
            Dim obj As IList(Of Guid) = New List(Of Guid)

            If Not txtDoctor.EditValue Is Nothing Then
                Session.Refresh(bndUser.Current)
                For Each x As UserService In Session.Get(Of User)(CType(txtDoctor.EditValue, Guid)).UserServices.ActiveItemsWithoutEmpty
                    obj.Add(x.Service.Id)
                Next
            End If
            If Not txtSpeciality.EditValue Is Nothing AndAlso txtDoctor.EditValue Is Nothing AndAlso txtService.EditValue Is Nothing Then
                Dim sp As SpecialityGroups = Session.Get(Of SpecialityGroups)(CType(txtSpeciality.EditValue, Guid))
                For Each z As Speciality In sp.Specialities
                    For Each j As Services In z.Services
                        If Not obj.Contains(j.Id) Then
                            obj.Add(j.Id)
                        End If
                    Next
                Next
            End If
            If obj.Count > 0 Then
                Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
                selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
                selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseInClassifier", True))
                CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
            Else
                Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
                selClassif.Enqueue(New KeyValuePair(Of String, Object)("ValidAt", startDate))
                CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
            End If

            frm.Selection = Nothing
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                For Each o As Services In bndServices
                    If o.Id = CType(frm.Selection, Services).Id Then
                        CType(sender, DevExpress.XtraEditors.LookUpEdit).ItemIndex = bndServices.IndexOf(o)
                    End If
                Next
                RefreshDoctor()
                ReadData()
            End If
        End If
    End Sub

    Private Sub LookUpEdit1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtService.KeyDown
        If e.KeyCode = Keys.Delete Then
            txtService.EditValue = Nothing
            RefreshDoctor()
            ReadData()
        End If
    End Sub

    Private Sub txtService_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtService.QueryPopUp
        'e.Cancel = True
    End Sub

    Private Sub grdPlanner_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdPlanner.MouseClick
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            Dim obj As Object = ReflectionHelper.GetPropertyValue(bndData.Current, Mid(gvwPlanner.FocusedColumn.Name, 4) & "Value")
            If obj Is Nothing Then
                Return
            End If
            If chkVisitPlaner.Checked Then
                If obj.GetType().Name = "Visit" Then

                End If
            End If
        End If
    End Sub

    Private Sub grdPlanner_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdPlanner.MouseMove
        clickPlace = gvwPlanner.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub itmPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmPatient.Click
        Dim obj As Object = ReflectionHelper.GetPropertyValue(bndData.Current, Mid(gvwPlanner.FocusedColumn.Name, 4) & "Value")
        If obj Is Nothing Then
            Return
        End If
        If chkVisitPlaner.Checked Then
            If obj.GetType().Name = "Visit" Then
                Dim frm As New frmTree
                Dim key As New Dictionary(Of Type, Guid)
                frm.PartnerSession = Me.Session
                frm.Session = Nothing
                key.Add(GetType(Patient), CType(obj, Visit).Patient.Id)
                frm.DataIDs = key
                frmMain.AddChild(frm)
            End If
        End If
    End Sub

    Private Sub showMenuInGrid(ByVal chi As GridHitInfo)
        If (chi.HitTest = GridHitTest.RowCell) Then
            Dim obj As Object = ReflectionHelper.GetPropertyValue(bndData.Current, Mid(gvwPlanner.FocusedColumn.Name, 4) & "Value")
            If obj Is Nothing Then
                grdPlanner.ContextMenuStrip = Nothing
            End If
            If chkVisitPlaner.Checked Then
                If obj.GetType().Name = "Visit" Then
                    itmCalled.Enabled = Not CType(obj, Visit).Called
                    grdPlanner.ContextMenuStrip = cmsMenu
                    Return
                End If
            End If
            grdPlanner.ContextMenuStrip = Nothing
            'ElseIf chi.HitTest = GridHitTest.Row Then
            '    grdPlanner.ContextMenuStrip = cmsDoctorMenu
        Else
            grdPlanner.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub gvwPlanner_ShowGridMenu(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs) Handles gvwPlanner.ShowGridMenu
        showMenuInGrid(e.HitInfo)
    End Sub

    Private Sub itmCalled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmCalled.Click
        Dim obj As Object = ReflectionHelper.GetPropertyValue(bndData.Current, Mid(gvwPlanner.FocusedColumn.Name, 4) & "Value")
        If obj Is Nothing Then
            Return
        End If
        If chkVisitPlaner.Checked Then
            If obj.GetType().Name = "Visit" Then
                Dim frm As New frmVisitEdit()
                frm.Session = Nothing
                frm.PartnerSession = Session
                frm.visit = frm.Session.Get(Of Visit)(CType(obj, Visit).Id)
                frm.Tag = frm.Session.Get(Of Visit)(CType(obj, Visit).Id)
                frm.visit.Called = True
                frm.Session.SaveOrUpdate(frm.visit)
                frm.Session.Commit()
                frm.Close()
                Dim v As Entities(Of Visit)
                v = Entities(Of Visit).GetAll(Session, New Expressions.NotEq("Id", CType(obj, Visit).Id), New Expressions.Eq("Patient", CType(obj, Visit).Patient), New Expressions.Between("StartTime", CType(obj, Visit).StartTime.Date, CType(obj, Visit).StartTime.Date.AddDays(1)), New Expressions.IsNull("DeleteTime"))
                For Each visit1 As Visit In v
                    frm = New frmVisitEdit()
                    frm.Session = Nothing
                    frm.PartnerSession = Session
                    frm.visit = frm.Session.Get(Of Visit)(visit1.Id)
                    frm.Tag = frm.Session.Get(Of Visit)(visit1.Id)
                    frm.visit.Called = True
                    frm.Session.SaveOrUpdate(frm.visit)
                    frm.Session.Commit()
                    frm.Close()
                Next
                ReadData()
            End If
        End If
    End Sub

    Private Sub txtDoctor_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDoctor.ButtonClick
        txtDoctor.CancelPopup()
        Dim frm As New frmUsers(Entities.ClassifierType.FromType(GetType(User), Session), Session, ClassifierListMode.SingleSelect)
        frm.FormMode = ClassifierListMode.SingleSelect

        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        If chkVisitPlaner.Checked Then
            If Not txtSpeciality.EditValue Is Nothing AndAlso txtDoctor.EditValue Is Nothing AndAlso txtService.EditValue Is Nothing Then
                Dim sp As SpecialityGroups = Session.Get(Of SpecialityGroups)(CType(txtSpeciality.EditValue, Guid))
                Dim obj As IList(Of Guid) = New List(Of Guid)
                For Each z As Speciality In sp.Specialities
                    For Each j As Services In z.Services
                        If Not obj.Contains(j.Id) Then
                            obj.Add(j.Id)
                        End If
                    Next
                Next
                selClassif.Enqueue(New KeyValuePair(Of String, Object)("Services", obj))
                selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseServices", True))
            End If
            If Not txtService.EditValue Is Nothing Then
                Dim obj As IList(Of Guid) = New List(Of Guid)
                obj.Add(CType(txtService.EditValue, Guid))
                selClassif.Enqueue(New KeyValuePair(Of String, Object)("Services", obj))
                selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseServices", True))
            End If
        End If
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseDoctor", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.LookUpEdit).ItemIndex = bndUser.IndexOf(frm.Selection)
            RefreshServices()
            ReadData()
        End If
    End Sub
    Private Sub RefreshDoctor()
        If chkVisitPlaner.Checked Then
            Dim criteria As IList(Of Expressions.CriterionBase) = New List(Of Expressions.CriterionBase)
            If Not txtSpeciality.EditValue Is Nothing AndAlso txtDoctor.EditValue Is Nothing AndAlso txtService.EditValue Is Nothing Then
                Dim obj As IList(Of Guid) = New List(Of Guid)
                Dim sp As SpecialityGroups = Session.Get(Of SpecialityGroups)(CType(txtSpeciality.EditValue, Guid))
                For Each z As Speciality In sp.Specialities.ActiveItemsWithoutEmpty
                    For Each j As Services In z.Services
                        If Not obj.Contains(j.Id) Then
                            obj.Add(j.Id)
                        End If
                    Next
                Next
                criteria.Add(CriteriaBuilder.IsInCollection("UserServices.Service.Id", obj))
            End If
            If txtService.EditValue Is Nothing Then
                criteria.Add(New Expressions.IsNull("DeleteTime"))
                criteria.Add(New Expressions.Eq("Position.Mark", True))
                criteria.Add(New Expressions.And(New Expressions.Le("WorksFrom", startDate.AddDays(dayCount + 1)), New Expressions.Or(New Expressions.IsNull("WorkedUntil"), New Expressions.Ge("WorkedUntil", startDate.AddDays(dayCount + 1)))))
            Else
                Dim obj As IList(Of Guid) = New List(Of Guid)
                obj.Add(CType(txtService.EditValue, Guid))
                criteria.Add(CriteriaBuilder.IsInCollection("UserServices.Service.Id", obj))
                criteria.Add(New Expressions.IsNull("UserServices.DeleteTime"))
            End If
            Dim order(0) As NHibernate.Expression.Order
            order(0) = NHibernate.Expression.Order.Asc("LastName")
            bndUser.DataSource = Entities(Of User).GetAllOrderBy(Session, order, criteria)
        ElseIf chkGroupPlaner.Checked Then
            bndUser.DataSource = Entities(Of User).GetAllOrderBy(Session, NHibernate.Expression.Order.Asc("LastName"), New Expressions.IsNull("DeleteTime"), New Expressions.And(New Expressions.Le("WorksFrom", startDate.AddDays(dayCount + 1)), New Expressions.Or(New Expressions.IsNull("WorkedUntil"), New Expressions.Ge("WorkedUntil", startDate.AddDays(dayCount + 1)))))
        End If
    End Sub

    Private Sub txtService_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtService.EditValueChanged
        RefreshDoctor()
        'ReadData()
    End Sub

    Private Sub txtSpeciality_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSpeciality.KeyDown
        If e.KeyCode = Keys.Delete Then
            txtSpeciality.EditValue = Nothing
            RefreshServices()
            RefreshDoctor()
            ReadData()
        End If
    End Sub

    Private Sub txtSpeciality_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSpeciality.EditValueChanged
        RefreshServices()
        RefreshDoctor()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If bndData.Current Is Nothing Then Return
        Dim obj As Object = ReflectionHelper.GetPropertyValue(bndData.Current, Mid(gvwPlanner.FocusedColumn.Name, 4) & "Value")
        If obj Is Nothing Then
            Return
        End If
        If chkVisitPlaner.Checked Then
            If obj.GetType().Name = "Visit" Then
                Core.UI.MsgBox.Show("Izvēlieties kādu no brīvajiem laikiem.")
                Exit Sub
            ElseIf obj.GetType.Name = "WorkTime" Then
                AddVisit()
            End If
        End If
    End Sub

    Private Sub itmUserCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmUserCard.Click

    End Sub

    Private Sub btnPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmPatients(Entities.ClassifierType.FromType(GetType(Patient), Session), Session)
        'frm.gvwPatients.OptionsView.ShowAutoFilterRow = True
        'frm.gvwPatients.Focus()
        'frm.canAddNew = True
        'visit = New Visit(Session)
        'frm.Visit = visit
        'frm.FormMode = ClassifierListMode.MultiSelect
        'Dim list As New Entities(Of Patient)
        'If Not patient1 Is Nothing Then
        '    list.Add(patient1)
        'End If
        'If Not patient2 Is Nothing Then
        '    list.Add(patient2)
        'End If
        'If Not patient3 Is Nothing Then
        '    list.Add(patient3)
        'End If
        'frm.selectedPatientList = list
        'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    Dim i As Integer = 0
        '    Dim str As String = ""
        '    For Each x As Patient In frm.Selection
        '        i += 1
        '        If i = 1 Then
        '            patient1 = x
        '            str &= x.FullName
        '        ElseIf i = 2 Then
        '            patient2 = x
        '            str &= "; " & x.FullName
        '        ElseIf i = 3 Then
        '            str &= "; " & x.FullName
        '            patient3 = x
        '        ElseIf i > 3 Then
        '            MsgBox.Show("Vizītei vienlaicīgi var pievienot tikai 3 klientus.")
        '            Exit For
        '        End If
        '    Next
        '    lblPatientName.Text = str
        'End If
    End Sub

    Private Sub txtDoctor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDoctor.EditValueChanged
        RefreshServices()
    End Sub

    Private Sub frmPlanner_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If (Not selectedDoctor Is Nothing) Then
            CType(txtDoctor, DevExpress.XtraEditors.LookUpEdit).ItemIndex = bndUser.IndexOf(selectedDoctor)
            selectedDoctor = Nothing
            LookUpEdit1_ButtonClick(txtService, New DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(txtService.Properties.Buttons.Item(0)))
        End If
    End Sub
End Class