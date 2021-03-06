Imports Core.Bll
Imports Core.Dal
Imports Core

''' <summary>
''' 
''' </summary>
Public Class WorkTime
    Inherits BusinessObjectBase(Of Guid)

#Region "Constructor"
    Protected Sub New()
        MyBase.New()
        BusinessRule()
    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession, ByVal userId As Guid, ByVal _date As DateTime)
        MyBase.New(session)
        Me.User = session.Get(Of User)(userId)
        Me.StartTime = _date
        Me.EndTime = _date
        BusinessRule()
    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession, ByVal _date As DateTime)
        MyBase.New(session)
        Me.StartTime = _date
        Me.EndTime = _date
        BusinessRule()
    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession)
        MyBase.New(session)
        BusinessRule()
    End Sub

    Private Sub BusinessRule()
        Validator.AddBusinessRule("Room", AddressOf CommonBusinessRules.CheckRequired, "Room")
        Validator.AddBusinessRule("User", AddressOf CommonBusinessRules.CheckRequired, "User")
        Validator.AddBusinessRule("StartTime", AddressOf CommonBusinessRules.CheckRequired, "StartTime")
        Validator.AddBusinessRule("EndTime", AddressOf CommonBusinessRules.CheckRequired, "EndTime")
        Validator.AddBusinessRule("StartTime", AddressOf CommonBusinessRules.CheckTimeInterval, "StartTime", "EndTime")
    End Sub
#End Region

#Region "Private members"
    Private _room As Room
    Private _startTime As DateTime
    Private _endTime As DateTime
    Private _user As User
    Private _userWorkTime As UsersWorkTime
    Private _acity As Boolean
    Private _fromUserWorkTime As Boolean
    Private _usedTime As IList(Of Visit) = New List(Of Visit)
    Private _groupWork As Services
    Private _groupId As Nullable(Of Guid)
    Private _price As Nullable(Of Double)
    Private _patientCount As Nullable(Of Integer)
    Private _length As Nullable(Of Integer)
    Private _visits As Entities(Of Visit) = New Entities(Of Visit)
#End Region


    ''' <summary>
    ''' Kabinets
    ''' </summary>
    Public Overridable Property Room() As Room
        Get
            Return _room
        End Get
        Set(ByVal value As Room)
            Assign("Room", value, _room)
        End Set
    End Property

    ''' <summary>
    ''' Uzsākšanas laiks
    ''' </summary>
    Public Overridable Property StartDateTime() As DateTime
        Get
            Return StartTime
        End Get
        Set(ByVal value As DateTime)
            StartTime = StartTime.Date.AddHours(value.Hour).AddMinutes(value.Minute)
        End Set
    End Property

    ''' <summary>
    ''' Uzsākšanas laiks
    ''' </summary>
    Public Overridable Property StartTime() As DateTime
        Get
            Return _startTime
        End Get
        Set(ByVal value As DateTime)
            Assign("StartTime", value, _startTime)
            If Not value = Nothing AndAlso Not GroupWork Is Nothing AndAlso Length.HasValue Then
                EndTime = value.AddMinutes(Convert.ToInt32(Length.Value))
            End If
        End Set
    End Property

    ''' <summary>
    ''' Beigšanas laiks
    ''' </summary>
    Public Overridable Property EndTime() As DateTime
        Get
            Return _endTime
        End Get
        Set(ByVal value As DateTime)
            Assign("EndTime", value, _endTime)
        End Set
    End Property

    ''' <summary>
    ''' ārsts
    ''' </summary>
    Public Overridable Property User() As Entities.User
        Get
            Return _user
        End Get
        Set(ByVal value As Entities.User)
            Assign("User", value, _user)
        End Set
    End Property

    ''' <summary>
    ''' grupu nodarbība
    ''' </summary>
    Public Overridable Property GroupWork() As Services
        Get
            Return _groupWork
        End Get
        Set(ByVal value As Services)
            Assign("GroupWork", value, _groupWork)
            If value Is Nothing Then
                Price = Nothing
                Length = Nothing
                PatientCount = Nothing
            Else
                Price = value.DecimalValue
                Length = value.IntegerValue
                PatientCount = value.FourIntegerValue
            End If
        End Set
    End Property

    ''' <summary>
    ''' grupu nodarbība
    ''' </summary>
    Public Overridable Property GroupId() As Nullable(Of Guid)
        Get
            Return _groupId
        End Get
        Set(ByVal value As Nullable(Of Guid))
            Assign("GroupId", value, _groupId)
        End Set
    End Property

    ''' <summary>
    ''' Grupas nodarbības cena
    ''' </summary>
    Public Overridable Property Price() As Nullable(Of Double)
        Get
            Return _price
        End Get
        Set(ByVal value As Nullable(Of Double))
            Assign("Price", value, _price)
        End Set
    End Property

    ''' <summary>
    ''' Grupas nodarbības dalībnieku skaits
    ''' </summary>
    Public Overridable Property PatientCount() As Nullable(Of Integer)
        Get
            Return _patientCount
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("PatientCount", value, _patientCount)
        End Set
    End Property

    ''' <summary>
    ''' Grupas nodarbības ilgums
    ''' </summary>
    Public Overridable Property Length() As Nullable(Of Integer)
        Get
            Return _length
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("Length", value, _length)
        End Set
    End Property


    ''' <summary>
    ''' akūta vizīte
    ''' </summary>
    Public Overridable Property Acity() As Boolean
        Get
            Return _acity
        End Get
        Set(ByVal value As Boolean)
            Assign("Acity", value, _acity)
        End Set
    End Property

    ''' <summary>
    ''' darbinieka apamatnoslodze
    ''' </summary>
    Public Overridable Property UserWorkTime() As UsersWorkTime
        Get
            Return _userWorkTime
        End Get
        Set(ByVal value As UsersWorkTime)
            Assign("UserWorkTime", value, _userWorkTime)
        End Set
    End Property

    ''' <summary>
    ''' vai ieraksts ir ņemts no darbinieka pamatnodslodes
    ''' </summary>
    Public Overridable Property FromUserWorkTime() As Boolean
        Get
            Return _fromUserWorkTime
        End Get
        Set(ByVal value As Boolean)
            _fromUserWorkTime = value
        End Set
    End Property

    ''' <summary>
    ''' vai ieraksts ir ņemts no darbinieka pamatnodslodes
    ''' </summary>
    Public Overridable Property UsedTime() As IList(Of Visit)
        Get
            Return _usedTime
        End Get
        Set(ByVal value As IList(Of Visit))
            _usedTime = value
        End Set
    End Property

    Public Overridable Function StringValue(ByVal forvisit As Boolean) As String
        If User Is Nothing Then
            Return StartTime.ToShortTimeString() & " - " & EndTime.ToShortTimeString()
        Else
            If (forvisit) Then
                Dim str As String = ""
                If Not GroupWork Is Nothing Then
                    If Not PatientCount.HasValue Then
                        PatientCount = 0
                    End If
                    str = Chr(13) & Chr(10) & Visits.Count.ToString & "/" & PatientCount.Value.ToString() & Chr(13) & Chr(10) & GroupWork.Value
                End If
                Return User.FullName & Chr(13) & Chr(10) & " kabinets " & Room.Value & Chr(13) & Chr(10) & StartTime.ToShortTimeString() & " - " & EndTime.ToShortTimeString() & str
            Else
                Return User.FullName & Chr(13) & Chr(10) & StartTime.ToShortTimeString() & " - " & EndTime.ToShortTimeString()
            End If
        End If
    End Function

    ''' <summary>
    ''' Return whether can delete CM case theme
    ''' </summary>
    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            If User Is Nothing Then
                Return False
            End If
            If Not Me.IsActive Then
                Return False
            End If
            Return User.CanAddDeleteSpeciality
        End Get
    End Property

    ''' <summary>
    ''' Return whether can edit CM case theme
    ''' </summary>
    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            If Me.IsActive Then
                Return True
            End If
            Return False
        End Get
    End Property

    Public Overridable Property Visits() As Entities(Of Visit)
        Get
            Return _visits
        End Get
        Set(ByVal value As Entities(Of Visit))
            _visits = value
        End Set
    End Property


    Public Shared Function TimeTable(ByVal session As ISession, ByVal speciality As Guid, ByVal _date As DateTime) As System.Data.DataTable
        TimeTable = New System.Data.DataTable("Table")
        TimeTable.Columns.Add("Time", GetType(DateTime))
        Dim _list As Entities(Of RoomGroups) = Entities(Of RoomGroups).GetAll(session, New Expressions.IsNull("DeleteTime"), New Expressions.Eq("Specialities.Id", speciality), New Expressions.Eq("Mark", True))
        Dim _rooms As New Entities(Of Room)
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As RoomGroups In _list
            If Not obj.Contains(x.Id) Then
                obj.Add(x.Id)
            End If
        Next
        _rooms = Entities(Of Room).GetAllOrderBy(session, NHibernate.Expression.Order.Asc("Value"), CriteriaBuilder.IsInCollection("Parent.Id", obj))

        For Each x As Room In _rooms
            TimeTable.Columns.Add(x.Id.ToString(), GetType(String))
            TimeTable.Columns.Add(x.Id.ToString() & "Acity", GetType(Object))
        Next
        Dim _startTime As DateTime = _date.Date
        Dim _start As SystemParameter = session.Get(Of SystemParameter)("PLANER_TIME_START")
        Dim _end As SystemParameter = session.Get(Of SystemParameter)("PLANER_TIME_END")
        For i As Integer = _start.ParamDate.Value.Hour To _end.ParamDate.Value.Hour
            For j As Integer = 0 To 59 Step Integer.Parse(session.Get(Of SystemParameter)("PLANER_FREQUENCE").Value)
                TimeTable.Rows.Add(_startTime.AddHours(i).AddMinutes(j))
                If i = _end.ParamDate.Value.Hour Then
                    Exit For
                End If
            Next
        Next

        Return FillData(session, speciality, _date, TimeTable)
    End Function

    Public Shared Function getData(ByVal session As ISession, ByVal startDate As Date, ByVal dayCount As Integer, ByVal roomGroup As RoomGroups, ByVal user As User) As Entities(Of TimeTable)
        Dim workTime As Entities(Of WorkTime)
        Dim userWorkTime As Entities(Of UsersWorkTime)
        Dim work As IList(Of Guid) = New List(Of Guid)
        Dim roomsId As IList(Of Guid) = New List(Of Guid)
        Dim datums As Date
        Dim result As New Entities(Of TimeTable)
        Dim clinicStart As Date
        Dim clinicEnd As Date
        Dim succesfuli As Boolean
        Dim resultDictionary As New Dictionary(Of Room, List(Of TimeTable))
        Dim source As New SortedDictionary(Of Room, SortedDictionary(Of DateTime, WorkTime))

        If dayCount = 0 Then Return result

        Dim param As Entities(Of SystemParameter) = Entities(Of SystemParameter).GetAll(session)
        Dim systemParams As New Dictionary(Of String, SystemParameter)
        For Each par As Entities.SystemParameter In param
            systemParams.Add(par.Id, par)
        Next

        If systemParams("PLANER_TIME_START").ParamDate.HasValue Then
            clinicStart = systemParams("PLANER_TIME_START").ParamDate.Value
        End If

        If systemParams("PLANER_TIME_END").ParamDate.HasValue Then
            clinicEnd = systemParams("PLANER_TIME_END").ParamDate.Value
        End If
        Dim rooms As New Entities(Of Room)
        If roomGroup Is Nothing AndAlso user Is Nothing Then
            'nolasam visus kabinetus un izveidojam par katru jaunu ierakstu ar defaulto klīnikas darbalaiku visām dienām
            rooms = Entities(Of Room).GetAllOrderBy(session, NHibernate.Expression.Order.Asc("Value"), New Expressions.IsNull("DeleteTime"))
        ElseIf Not roomGroup Is Nothing Then
            rooms = Entities(Of Room).GetAllOrderBy(session, NHibernate.Expression.Order.Asc("Value"), New Expressions.IsNull("DeleteTime"), New Expressions.Eq("Parent.Id", roomGroup.Id))
        End If
        For Each x As Room In rooms
            If Not roomsId.Contains(x.Id) Then
                roomsId.Add(x.Id)
            End If
            Dim obj As New TimeTable
            obj.Room = x
            result.Add(obj)
            resultDictionary.Add(x, New List(Of TimeTable))
            resultDictionary(x).Add(obj)
            For i As Integer = 1 To dayCount
                datums = startDate.AddDays(i - 1)
                Dim rec As New WorkTime
                rec.Room = x
                rec.StartTime = datums.Date.AddHours(clinicStart.Hour).AddMinutes(clinicStart.Minute)
                rec.EndTime = datums.Date.AddHours(clinicEnd.Hour).AddMinutes(clinicEnd.Minute)
                ReflectionHelper.SetPropertyValue(obj, DayOfWeek.GetName(GetType(DayOfWeek), rec.StartTime.DayOfWeek) & "Value", rec)
            Next
        Next

        If roomGroup Is Nothing AndAlso user Is Nothing Then
            'atrodam visus izmainītos ierakstus un jaunos ieplānotos par šo laiku
            workTime = Entities(Of WorkTime).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("StartTime")}, New Expressions.Between("StartTime", startDate, startDate.AddDays(dayCount)))
        ElseIf Not roomGroup Is Nothing Then
            workTime = Entities(Of WorkTime).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("StartTime")}, New Expressions.Between("StartTime", startDate, startDate.AddDays(dayCount)), CriteriaBuilder.IsInCollection("Room.Id", roomsId))
        Else
            workTime = Entities(Of WorkTime).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("StartTime")}, New Expressions.Between("StartTime", startDate, startDate.AddDays(dayCount)), New Expressions.Eq("User.Id", user.Id))
        End If
        'salīdzinam kuri ieraksti ir mainīti un izmetam no ārstu saraksta, lai neveidojas dublikāti par vienu un to pašu laiku
        For Each y As WorkTime In workTime
            'ja ir aktīvs izmantojam
            If y.IsActive Then
                If source.ContainsKey(y.Room) Then
                    If Not source(y.Room).ContainsKey(y.StartTime) Then
                        source(y.Room).Add(y.StartTime, y)
                    End If
                Else
                    source.Add(y.Room, New SortedDictionary(Of Date, WorkTime))
                    source(y.Room).Add(y.StartTime, y)
                End If
            End If
            'pieliekam id kas nav jāmeklē
            If Not y.UserWorkTime Is Nothing Then
                work.Add(y.UserWorkTime.Id)
            End If
        Next

        'atrodam visus ierakstus, kas ir pie ārstiem par norādītajām dienām
        Dim days As IList(Of Day)
        days = New List(Of Day)
        For i As Integer = 1 To dayCount
            days.Add(Day.GetDay(startDate.AddDays(i - 1)))
        Next
        If roomGroup Is Nothing AndAlso user Is Nothing Then
            userWorkTime = Entities(Of UsersWorkTime).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("DayOfWeek"), NHibernate.Expression.Order.Asc("StartTime")}, New Expressions.Le("ValidFrom", startDate), CriteriaBuilder.IsInCollection("DayOfWeek", days), CriteriaBuilder.IsNotInCollection("Id", work), New Expressions.Or(New Expressions.IsNull("ValidTo"), New Expressions.Ge("ValidTo", startDate)))
        ElseIf Not roomGroup Is Nothing Then
            userWorkTime = Entities(Of UsersWorkTime).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("DayOfWeek"), NHibernate.Expression.Order.Asc("StartTime")}, New Expressions.Le("ValidFrom", startDate), CriteriaBuilder.IsInCollection("DayOfWeek", days), CriteriaBuilder.IsNotInCollection("Id", work), CriteriaBuilder.IsInCollection("Room.Id", roomsId), New Expressions.Or(New Expressions.IsNull("ValidTo"), New Expressions.Ge("ValidTo", startDate)))
        Else
            userWorkTime = Entities(Of UsersWorkTime).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("DayOfWeek"), NHibernate.Expression.Order.Asc("StartTime")}, New Expressions.Le("ValidFrom", startDate), CriteriaBuilder.IsInCollection("DayOfWeek", days), CriteriaBuilder.IsNotInCollection("Id", work), New Expressions.Eq("User.Id", user.Id), New Expressions.Or(New Expressions.IsNull("ValidTo"), New Expressions.Ge("ValidTo", startDate)))
        End If
        For Each x As UsersWorkTime In userWorkTime
            Dim obj As New WorkTime
            obj.Acity = x.Acyity
            If dayCount = 1 Then
                obj.EndTime = startDate.AddHours(x.EndTime.Hour).AddMinutes(x.EndTime.Minute)
                obj.StartTime = startDate.AddHours(x.StartTime.Hour).AddMinutes(x.StartTime.Minute)
            Else
                obj.EndTime = Day.GetDate(startDate, x.DayOfWeek).AddHours(x.EndTime.Hour).AddMinutes(x.EndTime.Minute)
                obj.StartTime = Day.GetDate(startDate, x.DayOfWeek).AddHours(x.StartTime.Hour).AddMinutes(x.StartTime.Minute)
            End If
            If Not x.IsActive Then
                If x.DeleteTime.Value < obj.StartTime Then
                    Continue For
                End If
            End If
            obj.FromUserWorkTime = True
            obj.Room = x.Room
            obj.User = x.User
            obj.UserWorkTime = x
            If Not source.ContainsKey(x.Room) Then
                source.Add(x.Room, New SortedDictionary(Of Date, WorkTime))
            End If
            If Not source(x.Room).ContainsKey(obj.StartTime) Then
                source(x.Room).Add(obj.StartTime, obj)
            Else

            End If
        Next

        For Each y As KeyValuePair(Of Room, SortedDictionary(Of Date, WorkTime)) In source
            If Not user Is Nothing AndAlso Not resultDictionary.ContainsKey(y.Key) Then
                Dim obj As New TimeTable
                obj.Room = y.Key
                result.Add(obj)
                resultDictionary.Add(y.Key, New List(Of TimeTable))
                resultDictionary(y.Key).Add(obj)
                For i As Integer = 1 To dayCount
                    datums = startDate.AddDays(i - 1)
                    Dim rec As New WorkTime
                    rec.Room = y.Key
                    rec.StartTime = datums.Date.AddHours(clinicStart.Hour).AddMinutes(clinicStart.Minute)
                    rec.EndTime = datums.Date.AddHours(clinicEnd.Hour).AddMinutes(clinicEnd.Minute)
                    ReflectionHelper.SetPropertyValue(obj, DayOfWeek.GetName(GetType(DayOfWeek), rec.StartTime.DayOfWeek) & "Value", rec)
                Next
            End If
            For Each x As KeyValuePair(Of DateTime, WorkTime) In y.Value
                AddRecord(x.Value, result, resultDictionary)
            Next
        Next

        Return result
    End Function

    Private Shared Function AddRecord(ByVal obj As WorkTime, ByVal target As Entities(Of TimeTable), ByVal targetDictionary As Dictionary(Of Room, List(Of TimeTable))) As Boolean
        Dim value As WorkTime = Nothing
        Dim previousValue As WorkTime = Nothing
        Dim tempValue As WorkTime
        Dim added As Boolean = False
        Dim i As Integer = obj.StartTime.DayOfWeek
        Dim y As Integer = 0
        If Not targetDictionary.ContainsKey(obj.Room) Then Exit Function
        For Each x As TimeTable In targetDictionary(obj.Room)
            y += 1
            value = CType(ReflectionHelper.GetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value"), WorkTime)
            If value Is Nothing Then Return False
            If Not value.FromUserWorkTime AndAlso value.Id = Guid.Empty Then
                'ja noklāj pilnībā tad piešķir visu vērtību un beidzam
                If value.StartTime = obj.StartTime AndAlso value.EndTime = obj.EndTime Then
                    'piešķiram jaunu vērtību un viss
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", obj)
                    Return True
                    'ja sakrīt sākums
                ElseIf value.StartTime = obj.StartTime AndAlso value.EndTime > obj.EndTime Then
                    'piešķiram jaunu vērtību
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", obj)
                    'esošajam ierakstam uzstādam jaunu sākuma termiņu
                    value.StartTime = obj.EndTime
                    Exit For
                    'ja sakrīt beigas
                ElseIf value.StartTime < obj.StartTime AndAlso value.EndTime = obj.EndTime Then
                    'uzstādam jauno vērtību kā beidzamo un viss
                    value.EndTime = obj.StartTime
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", value)
                    value = obj
                    Exit For
                ElseIf value.StartTime < obj.StartTime AndAlso value.EndTime > obj.EndTime Then
                    'izveidojam jaun u ierakstu kas būs kā sākums
                    previousValue = New WorkTime
                    previousValue.Room = value.Room
                    previousValue.StartTime = value.StartTime
                    previousValue.EndTime = obj.StartTime
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previousValue)
                    value.StartTime = obj.EndTime
                    Exit For
                End If
            End If
        Next

        'ja bija jāliek pa vidu tad ieliekam atdoto vērtību
        If Not previousValue Is Nothing Then
            For Each x As TimeTable In targetDictionary(obj.Room)
                tempValue = CType(ReflectionHelper.GetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value"), WorkTime)
                If tempValue Is Nothing Then
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", obj)
                    added = True
                    Exit For
                End If
            Next
        Else
            added = True
        End If

        'ja nav brīvas vietas veidojam jaunu ierakstu
        Dim rec As New TimeTable
        If Not added Then
            rec.Room = obj.Room
            ReflectionHelper.SetPropertyValue(rec, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", obj)
            target.Add(rec)
            targetDictionary(rec.Room).Add(rec)
        End If

        For Each x As TimeTable In targetDictionary(obj.Room)
            tempValue = CType(ReflectionHelper.GetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value"), WorkTime)
            If tempValue Is Nothing Then
                ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", value)
                Return True
            End If
        Next

        rec = New TimeTable
        rec.Room = obj.Room
        ReflectionHelper.SetPropertyValue(rec, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", value)
        target.Add(rec)
        targetDictionary(rec.Room).Add(rec)

    End Function

    Public Shared Function FillData(ByVal session As ISession, ByVal speciality As Guid, ByVal _date As DateTime, ByVal _table As Data.DataTable) As System.Data.DataTable
        Dim _workTime As Entities(Of WorkTime)
        Dim _userWorkTime As Entities(Of UsersWorkTime)
        Dim _room As Room
        Dim _work As IList(Of Guid) = New List(Of Guid)
        Dim _obj As WorkTime
        Dim _dayOfWeek As Day = Nothing
        Select Case (_date.DayOfWeek)
            Case DayOfWeek.Sunday
                _dayOfWeek = Day.Sanday
            Case DayOfWeek.Monday
                _dayOfWeek = Day.Monday
            Case DayOfWeek.Tuesday
                _dayOfWeek = Day.Tuesday
            Case DayOfWeek.Wednesday
                _dayOfWeek = Day.Wednesday
            Case DayOfWeek.Thursday
                _dayOfWeek = Day.Thursday
            Case DayOfWeek.Friday
                _dayOfWeek = Day.Friday
            Case DayOfWeek.Saturday
                _dayOfWeek = Day.Saturday
        End Select

        For Each x As Data.DataColumn In _table.Columns
            If Not x.ColumnName = "Time" AndAlso Not x.ColumnName.EndsWith("Acity") Then
                _room = session.Get(Of Room)(New Guid(x.ColumnName))
                _workTime = Entities(Of WorkTime).GetAll(session, New Expressions.Ge("StartTime", _date.Date), New Expressions.Le("EndTime", _date.Date.AddDays(1)), New Expressions.Eq("Room", _room), New Expressions.IsNull("DeleteTime"))

                For Each y As WorkTime In _workTime
                    If Not y.UserWorkTime Is Nothing Then
                        _work.Add(y.UserWorkTime.Id)
                    End If
                Next

                _userWorkTime = Entities(Of UsersWorkTime).GetAll(session, New Expressions.Eq("DayOfWeek", _dayOfWeek), New Expressions.Eq("Room", _room), CriteriaBuilder.IsNotInCollection("Id", _work))
                For Each y As UsersWorkTime In _userWorkTime
                    _obj = New WorkTime()
                    _obj.FromUserWorkTime = True
                    _obj.User = y.User
                    _obj.Room = y.Room
                    _obj.UserWorkTime = y
                    _obj.StartTime = _date.Date.AddHours(y.StartTime.TimeOfDay.Hours).AddMinutes(y.StartTime.TimeOfDay.Minutes)
                    _obj.EndTime = _date.Date.AddHours(y.EndTime.TimeOfDay.Hours).AddMinutes(y.EndTime.TimeOfDay.Minutes)
                    _obj.Acity = y.Acyity
                    _workTime.Add(_obj)
                Next
                'New Expressions.Gt("StartTime", _date.Date), New Expressions.Le("EndTime", _date.Date.AddDays(1)), 
                For Each y As WorkTime In _workTime
                    For Each z As Data.DataRow In _table.Rows
                        If y.StartTime.TimeOfDay <= CDate(z.Item("Time")).TimeOfDay AndAlso y.EndTime.TimeOfDay > CDate(z.Item("Time")).TimeOfDay Then
                            z.Item(x.ColumnName) = y.User.FullName & Chr(10) & " Laiks " & y.StartTime.ToShortTimeString() & " - " & y.EndTime.ToShortTimeString()
                            z.Item(x.ColumnName & "Acity") = y
                        End If
                    Next
                Next
            End If
        Next
        Return _table
    End Function

    Public Overridable Function ValidateTime(ByVal session As ISession) As KeyValuePair(Of Boolean, WorkTime)
        Dim _worktime As Entities(Of WorkTime)
        _worktime = Entities(Of WorkTime).GetAll(session, New Expressions.Or(New Expressions.Eq("Room", Room), New Expressions.Eq("User", User)), New Expressions.Not(New Expressions.Ge("StartTime", EndTime)), New Expressions.Not(New Expressions.Le("EndTime", StartTime)), New Expressions.IsNull("DeleteTime"), New Expressions.NotEq("Id", Id))

        If _worktime.Count > 0 Then
            Return New KeyValuePair(Of Boolean, WorkTime)(False, _worktime(0))
        End If
        Return New KeyValuePair(Of Boolean, WorkTime)(True, New WorkTime())
    End Function

    Public Overridable Function ValidateInDefaultWorkTime(ByVal session As ISession) As KeyValuePair(Of Boolean, UsersWorkTime)
        Dim _worktime As Entities(Of UsersWorkTime)
        Dim crit As New List(Of Expressions.CriterionBase)
        crit.Add(New Expressions.Or(New Expressions.Eq("Room", Room), New Expressions.Eq("User", User)))
        crit.Add(New Expressions.Eq("DayOfWeek", Day.GetDay(StartTime)))
        If Not UserWorkTime Is Nothing Then
            crit.Add(New Expressions.NotEq("Id", UserWorkTime.Id))
        End If
        crit.Add(New Expressions.IsNull("DeleteTime"))
        _worktime = Entities(Of UsersWorkTime).GetAll(session, crit)

        For Each time As UsersWorkTime In _worktime
            'noklusētā darba laika sākuma un beigu laiks laiks tiek likts pie plānotā darbalaika datuma lai varētu salīdzināt
            Dim sakumaLaiks As DateTime = StartTime.Date.AddHours(time.StartTime.Hour).AddMinutes(time.StartTime.Minute)
            Dim beiguLaiks As DateTime = EndTime.Date.AddHours(time.EndTime.Hour).AddMinutes(time.EndTime.Minute)
            'ja ir norādīts termiņš no kura ir spēkā noklusētais darba laiks
            If time.ValidFrom.HasValue Then
                'skatamies vai ir norādīts beigu termiņš 
                'un spēkā no ir mazāks par sākuma laiku
                'un spēkā līdz ir lielāks par sākuma laiku
                If (time.ValidTo.HasValue AndAlso time.ValidFrom.Value.Date <= sakumaLaiks.Date AndAlso time.ValidTo.Value.Date >= sakumaLaiks.Date) OrElse (Not time.ValidTo.HasValue AndAlso time.ValidFrom.Value.Date <= sakumaLaiks.Date) Then
                    If time.ValidFrom.Value.Date <= sakumaLaiks.Date Then
                        'pārbaudam vai gadījumā nav veikts pamatlaika labojums šinī dienā, ja ir
                        'tad pieprasījumam vajadzētu atgriezt vienu ierakstu
                        Dim lst As Entities(Of WorkTime)
                        lst = Entities(Of WorkTime).GetAll(session, New Expressions.Eq("UserWorkTime.Id", time.Id), New Expressions.Between("StartTime", StartTime.Date, StartTime.Date.AddDays(1)))
                        If (lst.Count > 0) Then
                            If (lst(0).IsActive) Then
                                'ja ieraksts ir aktīvs tad uzstādam sākuma un beigu laikus no labotā noklusētā darba laika
                                sakumaLaiks = StartTime.Date.AddHours(lst(0).StartTime.Hour).AddMinutes(lst(0).StartTime.Minute)
                                beiguLaiks = EndTime.Date.AddHours(lst(0).EndTime.Hour).AddMinutes(lst(0).EndTime.Minute)
                            Else
                                'ja ieraksts ir dzēsts tas nozīmē ka noklusētā darba laika nav un tiek uzstādīts sākuma un beigu laiks kā sākuma datums bez laika
                                sakumaLaiks = StartTime.Date
                                beiguLaiks = EndTime.Date
                            End If
                        End If
                        'ja definētais darba laiks ir beztermiņ skatamies vai sākuma datums ir mazāks vai vienāds ar plānošanas datumu
                        'pārbaudām vai nepārklājas laiks
                        'pārklājas pilnībā
                        If sakumaLaiks.TimeOfDay.TotalMinutes = StartTime.TimeOfDay.TotalMinutes AndAlso beiguLaiks.TimeOfDay.TotalMinutes = EndTime.TimeOfDay.TotalMinutes Then
                            'ja laiks pārklājas returnojam ka ir aizņemts 
                            Return New KeyValuePair(Of Boolean, UsersWorkTime)(False, time)
                        ElseIf (StartTime.TimeOfDay.TotalMinutes > sakumaLaiks.TimeOfDay.TotalMinutes AndAlso StartTime.TimeOfDay.TotalMinutes < beiguLaiks.TimeOfDay.TotalMinutes) Then
                            'ja sākuma laiks pārklājas
                            Return New KeyValuePair(Of Boolean, UsersWorkTime)(False, time)
                        ElseIf (EndTime.TimeOfDay.TotalMinutes > sakumaLaiks.TimeOfDay.TotalMinutes AndAlso EndTime.TimeOfDay.TotalMinutes < beiguLaiks.TimeOfDay.TotalMinutes) Then
                            'ja beigu laiks pārklājas
                            Return New KeyValuePair(Of Boolean, UsersWorkTime)(False, time)
                        End If

                    End If
                End If
            ElseIf time.IsActive Then
                'ja nav norādīts nolusētā darba laika termiņš bet darba laiks ir aktīvs
            Else
                'ja darba laiks vairs nav aktīvs
                'skatamies kad tika dēsts ja dzēšana notika pēc plānošanas datuma
                If time.DeleteTime.Value.Date > sakumaLaiks.Date Then

                End If
            End If

        Next
        Return New KeyValuePair(Of Boolean, UsersWorkTime)(True, New UsersWorkTime(session))
    End Function

    Public Overridable Function ValidateTimeChange(ByVal session As ISession) As KeyValuePair(Of Boolean, Visit)
        Dim visits As Entities(Of Visit)
        visits = Entities(Of Visit).GetAll(session, New Expressions.Eq("ParentId", Id), New Expressions.IsNull("DeleteTime"), New Expressions.Or(New Expressions.Lt("StartTime", StartTime), New Expressions.Gt("EndTime", EndTime)))
        If visits.Count > 0 Then
            Return New KeyValuePair(Of Boolean, Visit)(False, visits(0))
        End If
        Return New KeyValuePair(Of Boolean, Visit)(True, New Visit(session))
    End Function


End Class
' Уныкоде

Public Class Table
    Inherits BusinessObjectBase(Of Guid)

    Private _time As DateTime

    Public Property Time() As DateTime
        Get
            Return _time
        End Get
        Set(ByVal value As DateTime)
            _time = value
        End Set
    End Property
End Class