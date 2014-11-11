Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class Visit
    Inherits BusinessObjectBase(Of Guid)

    Protected Sub New()
        MyBase.New()
        BusinessRule()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        BusinessRule()
        VisitStatus = New ChildCollection(Of VisitStatusHistory)
        Status = session.Get(Of Statuss)(Statuss.Notify)
        VisitServices = New ChildCollection(Of VisitService)
        Creator = Context.Current.AuthenticatedUser
    End Sub

    Private Sub BusinessRule()
        Validator.AddBusinessRule("Patient", AddressOf CommonBusinessRules.CheckRequired, "Patient")
        Validator.AddBusinessRule("Doctor", AddressOf CommonBusinessRules.CheckRequired, "Doctor")
    End Sub

    Private _patient As Patient
    Private _patientSecond As Patient
    Private _patientThird As Patient
    Private _doctor As User
    Private _room As Room
    Private _service As Services
    Private _groupWork As GroupsWork
    Private _length As Integer
    Private _lengthBefore As Integer
    Private _lengthAfter As Integer
    Private _startTime As DateTime
    Private _endTime As DateTime
    Private _acyity As Boolean
    Private _used As Boolean
    Private _start As DateTime
    Private _end As DateTime
    Private _parentId As Guid
    Private _notes As String
    Private _status As Statuss
    Private _visitServices As IChildCollection(Of VisitService)
    Private _called As Boolean
    Private _creator As User
    Private _deletedBy As User
    Private _group As Boolean
    Private _groupId As Guid
    Private _doctorVisit As IChildCollection(Of VisitService) = New ChildCollection(Of VisitService)
    Private _diagnostic As IChildCollection(Of VisitService) = New ChildCollection(Of VisitService)
    Private _laboratory As IChildCollection(Of VisitService) = New ChildCollection(Of VisitService)
    Private _manipulations As IChildCollection(Of VisitService) = New ChildCollection(Of VisitService)
    Private _vaccination As IChildCollection(Of VisitService) = New ChildCollection(Of VisitService)
    Private _dentist As IChildCollection(Of VisitService) = New ChildCollection(Of VisitService)
    Private _visitStatus As IChildCollection(Of VisitStatusHistory)
    Private _createDate As Nullable(Of DateTime)
    Private _createPlace As String
    Private _prepareCard As Boolean
    Private _splitServicesByType As Boolean
    Private _relatedVisits As Entities(Of VisitService)
    Private _relatedVisitsSecond As Entities(Of VisitService)
    Private _relatedVisitsThird As Entities(Of VisitService)
    Private _relatedDoctor As User
    Private _campaignPatient As CampaignPatient
    Private _canSetPAK As Boolean
    Private _canSetAbonemmet As Boolean
    Private _canSetProgramm As Boolean
    Private _activePAK As PatientProfileDescription
    Private _setPAK As Boolean

    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            If Not value Is Nothing Then
                value.VisitDate = StartTime.Date
            End If
            Assign("Patient", value, _patient)
        End Set
    End Property

    Public Overridable ReadOnly Property PatientGroup() As String
        Get
            If Patient Is Nothing Then
                Return ""
            Else
                Return Patient.IncomeGroup
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property PatientsNames() As String
        Get
            Dim res As String = ""
            If (Not Patient Is Nothing) Then
                res &= Patient.FullName
            End If
            If (Not PatientSecond Is Nothing) Then
                res &= "; " & PatientSecond.FullName
            End If
            If (Not PatientThird Is Nothing) Then
                res &= "; " & PatientThird.FullName
            End If
            Return res
        End Get
    End Property

    Public Overridable ReadOnly Property PatientIncomeGroup As String
        Get
            Dim res As String = ""
            If (Not Patient Is Nothing) Then
                res = Patient.IncomeGroup
            End If
            Return res
        End Get
    End Property


    Public Overridable Property PatientSecond() As Patient
        Get
            Return _patientSecond
        End Get
        Set(ByVal value As Patient)
            Assign("PatientSecond", value, _patientSecond)
        End Set
    End Property
    Public Overridable Property PatientThird() As Patient
        Get
            Return _patientThird
        End Get
        Set(ByVal value As Patient)
            Assign("PatientThird", value, _patientThird)
        End Set
    End Property

    Public Overridable ReadOnly Property PatientList() As String
        Get
            Dim res As String = ""
            If Not Patient Is Nothing Then
                res &= Patient.ToString()
            End If
            If Not PatientSecond Is Nothing Then
                res &= "; " & PatientSecond.ToString()
            End If
            If Not PatientThird Is Nothing Then
                res &= "; " & PatientThird.ToString()
            End If
            Return res
        End Get
    End Property

    Public Overridable ReadOnly Property Number() As String
        Get
            If Patient Is Nothing Then Return ""
            Return Patient.Number
        End Get
    End Property

    Public Overridable Property Doctor() As User
        Get
            Return _doctor
        End Get
        Set(ByVal value As User)
            Assign("Doctor", value, _doctor)
        End Set
    End Property

    Public Overridable Property RelatedDoctor() As User
        Get
            Return _relatedDoctor
        End Get
        Set(ByVal value As User)
            Assign("RelatedDoctor", value, _relatedDoctor)
        End Set
    End Property

    Public Overridable Property CampaignPatient() As CampaignPatient
        Get
            Return _campaignPatient
        End Get
        Set(ByVal value As CampaignPatient)
            Assign("CampaignPatient", value, _campaignPatient)
        End Set
    End Property

    Public Overridable Property Creator() As User
        Get
            Return _creator
        End Get
        Set(ByVal value As User)
            Assign("Creator", value, _creator)
        End Set
    End Property

    Public Overridable Property DeletedBy() As User
        Get
            Return _deletedBy
        End Get
        Set(ByVal value As User)
            Assign("DeletedBy", value, _deletedBy)
        End Set
    End Property

    Public Overridable Property Status() As Statuss
        Get
            Return _status
        End Get
        Set(ByVal value As Statuss)
            Assign("Status", value, _status)
            Dim newStatus As New VisitStatusHistory(value)
            VisitStatus.Add(newStatus)
        End Set
    End Property

    Public Overridable Property Group() As Boolean
        Get
            Return _group
        End Get
        Set(ByVal value As Boolean)
            Assign("Group", value, _group)
        End Set
    End Property

    Public Overridable Property GroupId() As Guid
        Get
            Return _groupId
        End Get
        Set(ByVal value As Guid)
            Assign("GroupId", value, _groupId)
        End Set
    End Property

    Public Overridable Property Room() As Room
        Get
            Return _room
        End Get
        Set(ByVal value As Room)
            Assign("Room", value, _room)
        End Set
    End Property

    Public Overridable Property Service() As Services
        Get
            Return _service
        End Get
        Set(ByVal value As Services)
            Assign("Service", value, _service)
        End Set
    End Property

    Public Overridable ReadOnly Property PaymentType() As PaymentType
        Get
            For Each vs As VisitService In VisitServices.ActiveItemsWithoutEmpty
                Return vs.PaymentType
            Next
            Return New PaymentType()
        End Get

    End Property

    Public Overridable Property GroupWork() As GroupsWork
        Get
            Return _groupWork
        End Get
        Set(ByVal value As GroupsWork)
            Assign("GroupWork", value, _groupWork)
        End Set
    End Property

    Public Overridable ReadOnly Property Serv() As String
        Get
            If Not Service Is Nothing Then
                Return Service.Value
            ElseIf Not GroupWork Is Nothing Then
                Return GroupWork.Value
            Else
                Return ""
            End If
        End Get
    End Property

    Public Overridable Property Length() As Integer
        Get
            Return _length
        End Get
        Set(ByVal value As Integer)
            Assign("Length", value, _length)
            StartTime = _startTime
        End Set
    End Property

    Public Overridable Property LengthBefore() As Integer
        Get
            Return _lengthBefore
        End Get
        Set(ByVal value As Integer)
            Assign("LengthBefore", value, _lengthBefore)
        End Set
    End Property

    Public Overridable Property LengthAfter() As Integer
        Get
            Return _lengthAfter
        End Get
        Set(ByVal value As Integer)
            Assign("LengthAfter", value, _lengthAfter)
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
            If Not Service Is Nothing AndAlso Not EndTime = StartTime.AddMinutes(Convert.ToDouble(Length)) Then
                EndTime = StartTime.AddMinutes(Convert.ToDouble(Length))
            End If
        End Set
    End Property

    Public Overridable ReadOnly Property VisitTime() As String
        Get
            Return StartTime.ToString("HH") & ":00"
        End Get
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
            If Not Service Is Nothing AndAlso Not EndTime = StartTime.AddMinutes(Convert.ToDouble(Length)) Then
                StartTime = EndTime.AddMinutes(Convert.ToDouble(Length) * -1)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Uzsākšanas laiks
    ''' </summary>
    Public Overridable Property Start() As DateTime
        Get
            Return _start
        End Get
        Set(ByVal value As DateTime)
            Assign("Start", value, _start)
        End Set
    End Property

    ''' <summary>
    ''' Beigšanas laiks
    ''' </summary>
    Public Overridable Property EndT() As DateTime
        Get
            Return _end
        End Get
        Set(ByVal value As DateTime)
            Assign("EndT", value, _end)
        End Set
    End Property


    ''' <summary>
    ''' Akûtā vizīte
    ''' </summary>
    Public Overridable Property Acyity() As Boolean
        Get
            Return _acyity
        End Get
        Set(ByVal value As Boolean)
            Assign("Acyity", value, _acyity)
        End Set
    End Property

    ''' <summary>
    ''' ieraksta izveides laiks
    ''' </summary>
    Public Overridable ReadOnly Property CreateDate() As Nullable(Of DateTime)
        Get
            Return _createDate
        End Get
    End Property

    ''' <summary>
    ''' Pazīme par to vai ieraksts jau ir piesaistīts kādam laika periodam
    ''' </summary>
    Public Overridable Property Used() As Boolean
        Get
            Return _used
        End Get
        Set(ByVal value As Boolean)
            _used = value
        End Set
    End Property

    Public Overridable Property Notes() As String
        Get
            Return _notes
        End Get
        Set(ByVal value As String)
            Assign("Notes", value, _notes)
        End Set
    End Property

    ''' <summary>
    ''' Pazīme par to vai ieraksts jau ir piesaistīts kādam laika periodam
    ''' </summary>
    Public Overridable Property ParentId() As Guid
        Get
            Return _parentId
        End Get
        Set(ByVal value As Guid)
            Assign("ParentId", value, _parentId)
        End Set
    End Property

    ''' <summary>
    ''' veikta atzvanīšana
    ''' </summary>
    Public Overridable Property Called() As Boolean
        Get
            Return _called
        End Get
        Set(ByVal value As Boolean)
            Assign("Called", value, _called)
        End Set
    End Property

    ''' <summary>
    ''' Ieraksta izveides vieta
    ''' </summary>
    Public Overridable Property CreatePlace() As String
        Get
            Return _createPlace
        End Get
        Set(ByVal value As String)
            Assign("CreatePlace", value, _createPlace)
        End Set
    End Property

    Public Overridable Property PrepareCard() As Boolean
        Get
            Return _prepareCard
        End Get
        Set(ByVal value As Boolean)
            Assign("PrepareCard", value, _prepareCard)
        End Set
    End Property

    Public Overridable ReadOnly Property PatientNumber() As String
        Get
            Dim res As String = ""
            If (Not Patient Is Nothing) Then
                res &= IIf(String.IsNullOrEmpty(Patient.Number), Patient.NumberTemporary, Patient.Number).ToString()
            End If
            If (Not PatientSecond Is Nothing) Then
                res &= "; " & PatientSecond.Number
            End If
            If (Not PatientThird Is Nothing) Then
                res &= "; " & PatientThird.Number
            End If
            Return res
        End Get
    End Property

    Public Overridable ReadOnly Property PatientCode() As String
        Get
            Dim res As String = ""
            If (Not Patient Is Nothing) Then
                res &= Patient.Code
            End If
            If (Not PatientSecond Is Nothing) Then
                res &= "; " & PatientSecond.Code
            End If
            If (Not PatientThird Is Nothing) Then
                res &= "; " & PatientThird.Code
            End If
            Return res
        End Get
    End Property

    Public Overridable ReadOnly Property PatientHasCard() As Boolean
        Get
            If Patient Is Nothing Then
                Return False
            Else
                Return Patient.HasCard
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property PatientMobile() As String
        Get
            If Patient Is Nothing OrElse Patient.MobilePhone Is Nothing Then
                Return ""
            Else
                Return Patient.MobilePhone
            End If
        End Get
    End Property


    Public Overridable ReadOnly Property BonusPoints() As Decimal
        Get
            If Patient Is Nothing Then
                Return 0
            Else
                Return Patient.BonusPointsTotal
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property BonusPointsUsed() As Decimal
        Get
            Dim count As Decimal = 0
            For Each x As VisitService In VisitServices
                If x.BonusPoints.HasValue Then
                    count += x.BonusPoints.Value
                End If
            Next
            Return count
        End Get
    End Property

    Public Overridable ReadOnly Property PatientMobileSecond() As String
        Get
            If PatientSecond Is Nothing OrElse PatientSecond.MobilePhone Is Nothing Then
                Return ""
            Else
                Return PatientSecond.MobilePhone
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property PatientMobileThird() As String
        Get
            If PatientThird Is Nothing OrElse PatientThird.MobilePhone Is Nothing Then
                Return ""
            Else
                Return PatientThird.MobilePhone
            End If
        End Get
    End Property


    ''' <summary>
    ''' Dokumenta failu maiņas saraksts
    ''' </summary>
    Public Overridable Property VisitServices() As Core.Dal.IChildCollection(Of VisitService)
        Get
            Return _visitServices
        End Get
        Protected Set(ByVal value As Core.Dal.IChildCollection(Of VisitService))
            _visitServices = value
            _visitServices.Parent = Me
        End Set
    End Property

    ''' <summary>
    ''' Vizītes statusu maiņas vēsture
    ''' </summary>
    Public Overridable Property VisitStatus() As Core.Dal.IChildCollection(Of VisitStatusHistory)
        Get
            Return _visitStatus
        End Get
        Protected Set(ByVal value As Core.Dal.IChildCollection(Of VisitStatusHistory))
            _visitStatus = value
            _visitStatus.Parent = Me
        End Set
    End Property

    Public Overrides Property IsActive() As Boolean
        Get
            Return MyBase.IsActive
        End Get
        Set(ByVal value As Boolean)
            MyBase.IsActive = value
            If value = False Then
                DeletedBy = Context.Current.AuthenticatedUser
            End If
        End Set
    End Property

    ''' <summary>
    ''' Ârsta apmeklējums
    ''' </summary>
    Public Overridable ReadOnly Property DoctorVisit() As Core.Dal.IChildCollection(Of VisitService)
        Get
            Return _doctorVisit
        End Get
    End Property
    ''' <summary>
    ''' Diagnostiskie izmeklējumi
    ''' </summary>
    Public Overridable ReadOnly Property Diagnostic() As Core.Dal.IChildCollection(Of VisitService)
        Get
            Return _diagnostic
        End Get
    End Property
    ''' <summary>
    ''' Laboratoriskie izmeklējumi
    ''' </summary>
    Public Overridable ReadOnly Property Laboratory() As Core.Dal.IChildCollection(Of VisitService)
        Get
            Return _laboratory
        End Get
    End Property
    ''' <summary>
    ''' Medicīniskās manipulācijas
    ''' </summary>
    Public Overridable ReadOnly Property Manipulations() As Core.Dal.IChildCollection(Of VisitService)
        Get
            Return _manipulations
        End Get
    End Property
    ''' <summary>
    ''' Vakcinācija
    ''' </summary>
    Public Overridable ReadOnly Property Vaccination() As Core.Dal.IChildCollection(Of VisitService)
        Get
            Return _vaccination
        End Get
    End Property
    ''' <summary>
    ''' Vakcinācija
    ''' </summary>
    Public Overridable ReadOnly Property Dentist() As Core.Dal.IChildCollection(Of VisitService)
        Get
            Return _dentist
        End Get
    End Property


    Public Overridable ReadOnly Property SplitServicesByType() As Boolean
        Get
            If Not _splitServicesByType Then
                For Each x As VisitService In VisitServices.ActiveItemsWithoutEmpty
                    If x.Service Is Nothing OrElse x.Service.ReferenceSecond Is Nothing Then
                        Continue For
                    End If
                    If x.Service.ReferenceSecond.Id = ServiceTypes.DoctorVisit Then
                        _doctorVisit.Add(x)
                    ElseIf x.Service.ReferenceSecond.Id = ServiceTypes.Diagnostic Then
                        _diagnostic.Add(x)
                    ElseIf x.Service.ReferenceSecond.Id = ServiceTypes.Laboratory Then
                        _laboratory.Add(x)
                    ElseIf x.Service.ReferenceSecond.Id = ServiceTypes.Manipulations Then
                        _manipulations.Add(x)
                    ElseIf x.Service.ReferenceSecond.Id = ServiceTypes.Vaccination Then
                        _vaccination.Add(x)
                    ElseIf x.Service.ReferenceSecond.Id = ServiceTypes.Dentist Then
                        _dentist.Add(x)
                    End If
                Next
                _splitServicesByType = True
            End If
            Return _splitServicesByType
        End Get
    End Property


    Public Overridable Function AvailableStatus() As Entities(Of Statuss)
        Dim _availableStatus As New Entities(Of Statuss)
        Return _availableStatus
    End Function

    Public Overrides Function ToString() As String
        Dim firstPatient As String = Patient.ToString() & IIf(Called, "", " " & PatientMobile).ToString()
        If (Not String.IsNullOrEmpty(Patient.Code)) Then
            If Patient.Code.Length > 6 Then
                firstPatient &= " (" & Patient.Code.Substring(0, 6) & ")"
            Else
                firstPatient &= " (" & Patient.Code & ")"
            End If
        End If
        Dim secondPatient As String = ""
        If Not PatientSecond Is Nothing Then
            secondPatient = Chr(13) & Chr(10) & PatientSecond.ToString() & IIf(Called, "", " " & PatientMobileSecond).ToString()
        End If
        Dim thirdPatient As String = ""
        If Not PatientThird Is Nothing Then
            thirdPatient = Chr(13) & Chr(10) & PatientThird.ToString() & IIf(Called, "", " " & PatientMobileThird).ToString()
        End If

        Return "Kabinets " & Room.ToString() & Chr(13) & Chr(10) & " Laiks " & StartTime.AddMinutes(-LengthBefore).ToShortTimeString() & " - " & EndTime.AddMinutes(LengthAfter).ToShortTimeString() & Chr(13) & Chr(10) & IIf(Acyity, " Akûtās vizītes", " ").ToString() & firstPatient & secondPatient & thirdPatient
    End Function

    Public Overridable ReadOnly Property CheckInterval() As Boolean
        Get
            If GroupWork Is Nothing Then
                Dim list As Entities(Of Visit)
                list = Entities(Of Visit).GetAll(GetSession, New Expressions.Eq("Doctor", Doctor), New Expressions.Not(New Expressions.Ge("StartTime", EndTime)), New Expressions.Not(New Expressions.Le("EndTime", StartTime)), New Expressions.NotEq("Id", Id), New Expressions.IsNull("DeleteTime"))
                Return list.Count > 0
            Else
                Return False
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property PaydAll() As Boolean
        Get
            Dim payd As Boolean = True
            For Each x As VisitService In VisitServices.ActiveItemsWithoutEmpty
                If (Not x.Payd) Then
                    payd = False
                End If
            Next
            Return payd
        End Get
    End Property



    Public Overridable ReadOnly Property ServiceGiven() As String
        Get
            Dim sniegts As Boolean = False
            Dim navSniegts As Boolean = False
            For Each x As VisitService In VisitServices.ActiveItemsWithoutEmpty
                If (Not x.ServiceGiven) Then
                    navSniegts = True
                Else
                    sniegts = True
                End If
            Next
            If (navSniegts And sniegts) Then
                Return "Daļēji"
            ElseIf navSniegts Then
                Return "Nav sniegti"
            Else
                Return "Sniegti"
            End If
        End Get
    End Property

    Public Shared Function GetData(ByVal session As ISession, ByVal startDate As Date, ByVal dayCount As Integer, ByVal service As Services, Optional ByVal user As User = Nothing, Optional ByVal specialityGroup As SpecialityGroups = Nothing) As Entities(Of TimeTable)
        Dim workTimes As Entities(Of WorkTime)
        Dim userWorkTime As Entities(Of UsersWorkTime)
        Dim work As IList(Of Guid) = New List(Of Guid)
        Dim result As New Entities(Of TimeTable)
        Dim resultDictionary As New Dictionary(Of User, List(Of TimeTable))
        Dim source As New SortedDictionary(Of User, SortedDictionary(Of DateTime, WorkTime))
        Dim visits As Entities(Of Visit)

        'ja dienu skaits ir nulle vai nav norādīts pakalpojums nedarām neko
        If dayCount = 0 Then Return result

        'atrodam visus kabinetus, kas atbilst pakalpojuma kabinetu grupai
        Dim roomsList As IList(Of Guid) = New List(Of Guid)
        Dim roomGroupList As IList(Of Guid) = New List(Of Guid)
        If Not service Is Nothing Then
            For Each x As RoomGroups In service.RoomGroup
                roomGroupList.Add(x.Id)
            Next
            Dim rooms As Entities(Of Room) = Entities(Of Room).GetAll(session, CriteriaBuilder.IsInCollection("Parent.Id", roomGroupList), New Expressions.IsNull("DeleteTime"))
            If rooms.Count = 0 Then Return result

            'sataisam listu priekš atlases kritērijiem lai visi laiki bûtu uz šiem kabinetiem
            For Each y As Room In rooms
                roomsList.Add(y.Id)
            Next
        End If

        Dim crit As New List(Of Expressions.CriterionBase)
        If roomsList.Count > 0 Then
            crit.Add(CriteriaBuilder.IsInCollection("Room.Id", roomsList))
        End If
        crit.Add(New Expressions.Between("StartTime", startDate, startDate.AddDays(dayCount)))
        'pakalpojumu iespējams pieteikt tikai tajos kabinetos, kuri ir piesaistīti pakalpojumam norādītajā kabinetu grupā

        'atrodam visas izmainītos ierakstus visiem arstiem, kuri snidz šo pakalpojumu
        If Not user Is Nothing Then
            crit.Add(New Expressions.Eq("User.Id", user.Id))
        End If
        If Not service Is Nothing Then
            crit.Add(New Expressions.Eq("User.UserServices.Service", service))
            crit.Add(New Expressions.IsNull("User.UserServices.DeleteTime"))
        End If
        Dim userIdLista As New List(Of Guid)
        If service Is Nothing AndAlso user Is Nothing AndAlso Not specialityGroup Is Nothing Then
            Dim spec As New List(Of Guid)
            For Each o As Speciality In specialityGroup.Specialities.ActiveItemsWithoutEmpty
                session.Refresh(o)
                spec.Add(o.Id)
            Next
            Dim usr As Entities(Of UsersSpecialities)
            usr = Entities(Of UsersSpecialities).GetAll(session, CriteriaBuilder.IsInCollection("Speciality.Id", spec), New Expressions.IsNull("DeleteTime"))

            For Each specialities As UsersSpecialities In usr
                If Not userIdLista.Contains(specialities.User.Id) Then
                    userIdLista.Add(specialities.User.Id)
                End If
            Next
            crit.Add(CriteriaBuilder.IsInCollection("User.Id", userIdLista))
        End If
        crit.Add(New Expressions.IsNull("GroupWork"))
        workTimes = Entities(Of WorkTime).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("StartTime")}, crit)

        'salīdzinam kuri ieraksti ir mainīti un izmetam no ārstu saraksta, lai neveidojas dublikāti par vienu un to pašu laiku
        For Each y As WorkTime In workTimes
            If y.IsActive Then
                If Not source.ContainsKey(y.User) Then
                    source.Add(y.User, New SortedDictionary(Of DateTime, WorkTime))
                End If
                If Not source(y.User).ContainsKey(y.StartTime) Then
                    source(y.User).Add(y.StartTime, y)
                End If
            End If
            If Not y.UserWorkTime Is Nothing Then
                work.Add(y.UserWorkTime.Id)
            End If
        Next

        Dim days As IList(Of Day)
        days = New List(Of Day)
        For i As Integer = 1 To dayCount
            days.Add(Day.GetDay(startDate.AddDays(i - 1)))
        Next

        Dim critUser As New List(Of Expressions.CriterionBase)
        If roomsList.Count > 0 Then
            critUser.Add(CriteriaBuilder.IsInCollection("Room.Id", roomsList))
        End If
        critUser.Add(CriteriaBuilder.IsInCollection("DayOfWeek", days))
        critUser.Add(CriteriaBuilder.IsNotInCollection("Id", work))

        If Not service Is Nothing Then
            critUser.Add(New Expressions.Eq("User.UserServices.Service", service))
            critUser.Add(New Expressions.IsNull("User.UserServices.DeleteTime"))
        End If

        If Not user Is Nothing Then
            critUser.Add(New Expressions.Eq("User", user))
        End If
        If service Is Nothing AndAlso user Is Nothing AndAlso Not specialityGroup Is Nothing Then
            critUser.Add(CriteriaBuilder.IsInCollection("User.Id", userIdLista))
        End If
        critUser.Add(New Expressions.Le("CreateDate", startDate))
        critUser.Add(New Expressions.Le("User.WorksFrom", startDate))
        userWorkTime = Entities(Of UsersWorkTime).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("DayOfWeek"), NHibernate.Expression.Order.Asc("StartTime")}, critUser)

        'salikeam listā visus iespējamos laikus sakārtotus pa kabinetiem un pēc laika
        For Each x As UsersWorkTime In userWorkTime
            Dim obj As New WorkTime(session, x.StartTime.Date)
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
            If Not source.ContainsKey(x.User) Then
                source.Add(x.User, New SortedDictionary(Of DateTime, WorkTime))
            End If
            If Not source(x.User).ContainsKey(obj.StartTime) Then
                source(x.User).Add(obj.StartTime, obj)
            End If
        Next
        'dabujama pamatnoslodzi visiem laikiem bez vizītēm
        For Each y As KeyValuePair(Of User, SortedDictionary(Of DateTime, WorkTime)) In source
            For Each z As KeyValuePair(Of DateTime, WorkTime) In y.Value
                AddRecord(z.Value, result, resultDictionary, session)
            Next
        Next
        If userIdLista.Count > 0 Then
            visits = Entities(Of Visit).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("StartTime")}, New Expressions.Between("StartTime", startDate, startDate.AddDays(dayCount)), New Expressions.IsNull("DeleteTime"), New Expressions.IsNotNull("Service"), CriteriaBuilder.IsInCollection("Doctor.Id", userIdLista))
        ElseIf user Is Nothing Then
            visits = Entities(Of Visit).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("StartTime")}, New Expressions.Between("StartTime", startDate, startDate.AddDays(dayCount)), New Expressions.IsNull("DeleteTime"), New Expressions.IsNotNull("Service"))
        Else
            visits = Entities(Of Visit).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("StartTime")}, New Expressions.Between("StartTime", startDate, startDate.AddDays(dayCount)), New Expressions.IsNull("DeleteTime"), New Expressions.IsNotNull("Service"), New Expressions.Eq("Doctor.Id", user.Id))
        End If

        For Each x As Visit In visits
            x.Start = x.StartTime
            x.EndT = x.EndTime
            AddVisitNew(x, result, resultDictionary, session)
        Next
        Return result
    End Function

    Private Shared Function AddVisitNew(ByVal obj As Visit, ByVal target As Entities(Of TimeTable), ByVal targetDictionary As Dictionary(Of User, List(Of TimeTable)), ByVal session As ISession) As Boolean
        If Not targetDictionary.ContainsKey(obj.Doctor) Then Return False
        Dim tempValue As Object
        Dim value As WorkTime = Nothing
        Dim found As Boolean = False
        Dim objAdded As Boolean = False
        Dim previous As Object
        Dim sec As Object = Nothing
        Dim visitAdded As Boolean
        For Each x As TimeTable In targetDictionary(obj.Doctor)
            If Not found Then
                tempValue = ReflectionHelper.GetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value")
                If tempValue Is Nothing Then Continue For
                If tempValue.GetType() Is GetType(Visit) Then Continue For
                value = CType(tempValue, WorkTime)
                If value Is Nothing Then
                    'kaut ko darīsim jo kļûda algoritmā
                    Return False
                Else
                    If (value.EndTime <= obj.StartTime) Then Continue For
                    If value.Id = obj.ParentId OrElse (Not value.UserWorkTime Is Nothing AndAlso value.UserWorkTime.Id = obj.ParentId) Then
                        found = True
                    End If
                End If
            End If
            If found And Not objAdded Then
                'ja atrastais pārklājās pilnībā
                If value.StartTime = obj.StartTime AndAlso value.EndTime = obj.EndTime Then
                    'aizvietojam ar vizīti
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", obj)
                    Return True
                    'ja vizīte sanāk pa vidu
                ElseIf obj.StartTime > value.StartTime AndAlso obj.EndTime < value.EndTime Then
                    'uzstādam brīvajam laikam pareizu beigu laiku
                    objAdded = True
                    previous = obj
                    Dim wt As New WorkTime(session, obj.StartTime.Date)
                    wt.User = value.User
                    wt.StartTime = obj.EndTime
                    wt.EndTime = value.EndTime
                    wt.FromUserWorkTime = value.FromUserWorkTime
                    wt.UserWorkTime = value.UserWorkTime
                    wt.Acity = value.Acity
                    wt.Room = value.Room
                    wt.Id = value.Id
                    sec = wt
                    value.EndTime = obj.StartTime
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", value)
                    Continue For
                    'ja vizīte ir ir sākumā
                ElseIf obj.StartTime = value.StartTime AndAlso obj.EndTime < value.EndTime Then
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", obj)
                    value.StartTime = obj.EndTime
                    visitAdded = True
                    objAdded = True
                    previous = value
                    Continue For
                    'ja vizīte ir beigās
                ElseIf obj.StartTime > value.StartTime AndAlso obj.EndTime = value.EndTime Then
                    value.EndTime = obj.StartTime
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", value)
                    previous = obj
                    objAdded = True
                    Continue For
                End If
            End If
            If found And objAdded Then
                tempValue = ReflectionHelper.GetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value")
                If sec Is Nothing Then
                    If tempValue Is Nothing Then
                        ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previous)
                        Return True
                    Else
                        ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previous)
                        previous = tempValue
                    End If
                Else
                    If tempValue Is Nothing Then
                        ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previous)
                        previous = sec
                        sec = Nothing
                    Else
                        ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previous)
                        previous = sec
                        sec = tempValue
                    End If
                End If

            End If
        Next
        If Not previous Is Nothing Then
            Dim rec As New TimeTable
            rec.ForVisit = True
            rec.Room = obj.Room
            If previous.GetType() Is GetType(Visit) Then
                rec.Doctor = CType(previous, Visit).Doctor
            End If
            If previous.GetType() Is GetType(WorkTime) Then
                rec.Doctor = CType(previous, WorkTime).User
            End If
            ReflectionHelper.SetPropertyValue(rec, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previous)
            target.Add(rec)
            targetDictionary(rec.Doctor).Add(rec)
        End If
        If Not sec Is Nothing Then
            Dim rec As New TimeTable
            rec.ForVisit = True
            rec.Room = obj.Room
            If sec.GetType() Is GetType(Visit) Then
                rec.Doctor = CType(sec, Visit).Doctor
            End If
            If sec.GetType() Is GetType(WorkTime) Then
                rec.Doctor = CType(sec, WorkTime).User
            End If
            ReflectionHelper.SetPropertyValue(rec, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", sec)
            target.Add(rec)
            targetDictionary(rec.Doctor).Add(rec)
        End If

    End Function

    Private Shared Function AddVisit(ByVal obj As Visit, ByVal target As Entities(Of TimeTable), ByVal targetDictionary As Dictionary(Of User, List(Of TimeTable)), ByVal session As ISession) As Boolean
        If Not targetDictionary.ContainsKey(obj.Doctor) Then Return False
        Dim tempValue As Object
        Dim value As WorkTime = Nothing
        Dim found As Boolean = False
        Dim objAdded As Boolean = False
        Dim previous As Object
        Dim sec As Object = Nothing
        Dim visitAdded As Boolean
        For Each x As TimeTable In targetDictionary(obj.Doctor)
            If Not found Then
                tempValue = ReflectionHelper.GetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value")
                If tempValue Is Nothing Then Continue For
                If tempValue.GetType() Is GetType(Visit) Then Continue For
                value = CType(tempValue, WorkTime)
                If value Is Nothing Then
                    'kaut ko darīsim jo kļûda algoritmā
                    Return False
                Else
                    If (value.EndTime <= obj.StartTime) Then Continue For
                    If value.Id = obj.ParentId OrElse (Not value.UserWorkTime Is Nothing AndAlso value.UserWorkTime.Id = obj.ParentId) Then
                        found = True
                    End If
                End If
            End If
            If found And Not objAdded Then
                'ja atrastais pārklājās pilnībā
                If value.StartTime = obj.StartTime AndAlso value.EndTime = obj.EndTime Then
                    'aizvietojam ar vizīti
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", obj)
                    Return True
                    'ja vizīte sanāk pa vidu
                ElseIf obj.StartTime > value.StartTime AndAlso obj.EndTime < value.EndTime Then
                    'uzstādam brīvajam laikam pareizu beigu laiku
                    objAdded = True
                    previous = obj
                    Dim wt As New WorkTime(session, obj.StartTime.Date)
                    wt.User = value.User
                    wt.StartTime = obj.EndTime
                    wt.EndTime = value.EndTime
                    wt.FromUserWorkTime = value.FromUserWorkTime
                    wt.UserWorkTime = value.UserWorkTime
                    wt.Acity = value.Acity
                    wt.Room = value.Room
                    wt.Id = value.Id
                    sec = wt
                    value.EndTime = obj.StartTime
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", value)
                    Continue For
                    'ja vizīte ir ir sākumā
                ElseIf obj.StartTime = value.StartTime AndAlso obj.EndTime < value.EndTime Then
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", obj)
                    value.StartTime = obj.EndTime
                    visitAdded = True
                    objAdded = True
                    previous = value
                    Continue For
                    'ja vizīte ir beigās
                ElseIf obj.StartTime > value.StartTime AndAlso obj.EndTime = value.EndTime Then
                    value.EndTime = obj.StartTime
                    ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", value)
                    previous = obj
                    objAdded = True
                End If
            End If
            If found And objAdded Then
                tempValue = ReflectionHelper.GetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value")
                If sec Is Nothing Then
                    If tempValue Is Nothing Then
                        ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previous)
                        Return True
                    Else
                        Do While Not tempValue Is Nothing
                            ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previous)
                            previous = tempValue
                        Loop
                    End If

                    'ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previous)
                    'previous = tempValue
                Else
                    If tempValue Is Nothing Then
                        ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previous)
                        previous = sec
                        sec = Nothing
                    Else
                        ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previous)
                        previous = sec
                        sec = tempValue
                    End If
                End If

            End If
        Next
        If Not previous Is Nothing Then
            Dim rec As New TimeTable
            rec.ForVisit = True
            rec.Room = obj.Room
            If previous.GetType() Is GetType(Visit) Then
                rec.Doctor = CType(previous, Visit).Doctor
            End If
            If previous.GetType() Is GetType(WorkTime) Then
                rec.Doctor = CType(previous, WorkTime).User
            End If
            ReflectionHelper.SetPropertyValue(rec, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", previous)
            target.Add(rec)
            targetDictionary(rec.Doctor).Add(rec)
        End If
        If Not sec Is Nothing Then
            Dim rec As New TimeTable
            rec.ForVisit = True
            rec.Room = obj.Room
            If sec.GetType() Is GetType(Visit) Then
                rec.Doctor = CType(previous, Visit).Doctor
            End If
            If sec.GetType() Is GetType(WorkTime) Then
                rec.Doctor = CType(sec, WorkTime).User
            End If
            ReflectionHelper.SetPropertyValue(rec, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", sec)
            target.Add(rec)
            targetDictionary(rec.Doctor).Add(rec)
        End If

    End Function

    Private Shared Function AddRecord(ByVal obj As WorkTime, ByVal target As Entities(Of TimeTable), ByVal targetDictionary As Dictionary(Of User, List(Of TimeTable)), ByVal session As ISession) As Boolean
        Dim value As WorkTime = Nothing
        Dim previousValue As WorkTime = Nothing
        Dim tempValue As WorkTime
        Dim added As Boolean = False
        Dim i As Integer = obj.StartTime.DayOfWeek
        Dim y As Integer = 0
        If Not targetDictionary.ContainsKey(obj.User) Then
            targetDictionary.Add(obj.User, New List(Of TimeTable))
        End If

        'ja nav brīvas vietas veidojam jaunu ierakstu
        Dim rec As New TimeTable

        For Each x As TimeTable In targetDictionary(obj.User)
            tempValue = CType(ReflectionHelper.GetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value"), WorkTime)
            If tempValue Is Nothing Then
                ReflectionHelper.SetPropertyValue(x, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", obj)
                Return True
            End If
        Next
        rec.ForVisit = True
        rec.Doctor = obj.User
        ReflectionHelper.SetPropertyValue(rec, DayOfWeek.GetName(GetType(DayOfWeek), obj.StartTime.DayOfWeek) & "Value", obj)
        target.Add(rec)
        targetDictionary(rec.Doctor).Add(rec)

    End Function

    Public Shared Function GetGroupWorkData(ByVal session As ISession, ByVal startDate As Date, ByVal dayCount As Integer, ByVal groupWork As GroupsWork, Optional ByVal user As User = Nothing) As Entities(Of TimeTable)
        Dim workTimes As Entities(Of WorkTime)
        Dim work As IList(Of Guid) = New List(Of Guid)
        Dim result As New Entities(Of TimeTable)
        Dim resultDictionary As New Dictionary(Of User, List(Of TimeTable))
        Dim source As New SortedDictionary(Of User, SortedDictionary(Of DateTime, WorkTime))
        Dim visits As Entities(Of Visit)

        'ja dienu skaits ir nulle vai nav norādīts pakalpojums nedarām neko
        If dayCount = 0 Then Return result

        Dim crit As New List(Of Expressions.CriterionBase)
        crit.Add(New Expressions.Between("StartTime", startDate, startDate.AddDays(dayCount)))

        If Not user Is Nothing Then
            crit.Add(New Expressions.Eq("User.Id", user.Id))
        End If
        If Not groupWork Is Nothing Then
            crit.Add(New Expressions.Eq("GroupWork.Id", groupWork.Id))
        Else
            crit.Add(New Expressions.IsNotNull("GroupWork"))
        End If
        crit.Add(New Expressions.IsNull("DeleteTime"))
        workTimes = Entities(Of WorkTime).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("StartTime")}, crit)

        For Each y As WorkTime In workTimes
            If y.IsActive Then
                If Not source.ContainsKey(y.User) Then
                    source.Add(y.User, New SortedDictionary(Of DateTime, WorkTime))
                End If
                If Not source(y.User).ContainsKey(y.StartTime) Then
                    source(y.User).Add(y.StartTime, y)
                End If
                crit = New List(Of Expressions.CriterionBase)
                crit.Add(New Expressions.Between("StartTime", startDate, startDate.AddDays(dayCount)))
                crit.Add(New Expressions.IsNull("DeleteTime"))
                crit.Add(New Expressions.Eq("ParentId", y.Id))
                y.Visits = Entities(Of Visit).GetAllOrderBy(session, New NHibernate.Expression.Order() {NHibernate.Expression.Order.Asc("Room"), NHibernate.Expression.Order.Asc("StartTime")}, crit)
            End If
        Next

        'dabujama pamatnoslodzi visiem laikiem bez vizītēm
        For Each y As KeyValuePair(Of User, SortedDictionary(Of DateTime, WorkTime)) In source
            For Each z As KeyValuePair(Of DateTime, WorkTime) In y.Value
                AddRecord(z.Value, result, resultDictionary, session)
            Next
        Next
        Return result
    End Function

    Public Overridable ReadOnly Property Price() As Nullable(Of Decimal)
        Get
            If VisitServices.ActiveItemsWithoutEmpty.Count = 0 Then
                Return Nothing
            Else
                Dim _price As Decimal = 0
                For Each vs As VisitService In VisitServices.ActiveItemsWithoutEmpty
                    If vs.Payd Then
                        If Not vs.Service.ReferenceSecond Is Nothing AndAlso vs.Service.ReferenceSecond.Mark Then
                            Continue For
                        End If
                        For Each service1 As UserService In Doctor.UserServices
                            If service1.Service.Id = vs.Service.Id Then
                                If Not service1.DeleteTime.HasValue Then
                                    _price += vs.DefaultPrice
                                    Exit For
                                ElseIf service1.DeleteTime.Value <= vs.Visit.StartTime Then
                                    _price += vs.DefaultPrice
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                Next
                Return _price
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property Total() As Nullable(Of Decimal)
        Get
            If VisitServices.ActiveItemsWithoutEmpty.Count = 0 Then
                Return Nothing
            Else
                Dim _price As Decimal = 0
                For Each vs As VisitService In VisitServices.ActiveItemsWithoutEmpty
                    If vs.Payd Then
                        _price += vs.DefaultPrice
                    End If
                Next
                Return _price
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property Payd() As Nullable(Of Decimal)
        Get
            If VisitServices.ActiveItemsWithoutEmpty.Count = 0 Then
                Return Nothing
            Else
                Dim _price As Decimal = 0
                For Each vs As VisitService In VisitServices.ActiveItemsWithoutEmpty
                    If vs.Payd Then
                        If vs.PaydDate.HasValue AndAlso vs.PaydDate.Value.Date <> StartTime.Date Then
                            Continue For
                        End If
                        If vs.PaymentType Is Nothing OrElse vs.PaymentType.Id = PaymentType.Cash Then
                            _price += vs.Price
                            If vs.Insurance.HasValue Then
                                _price += vs.Insurance.Value
                            End If
                        End If
                    End If
                Next
                Return _price
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property Catchs() As Nullable(Of Decimal)
        Get
            If VisitServices.ActiveItemsWithoutEmpty.Count = 0 Then
                Return Nothing
            Else
                Dim _price As Decimal = 0
                For Each vs As VisitService In VisitServices.ActiveItemsWithoutEmpty
                    If vs.Payd OrElse vs.ServiceGiven Then
                        _price += vs.Price
                    End If
                Next
                Return _price
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property Insurance() As Nullable(Of Decimal)
        Get
            If VisitServices.ActiveItemsWithoutEmpty.Count = 0 Then
                Return Nothing
            Else
                Dim _price As Decimal = 0
                For Each vs As VisitService In VisitServices.ActiveItemsWithoutEmpty
                    If (vs.Payd OrElse vs.ServiceGiven) AndAlso vs.Insurance.HasValue Then
                        _price += vs.Insurance.Value
                    End If
                Next
                Return _price
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property InsuranceName() As Insurance
        Get
            If VisitServices.ActiveItemsWithoutEmpty.Count = 0 Then
                Return Nothing
            Else
                For Each vs As VisitService In VisitServices.ActiveItemsWithoutEmpty
                    If (vs.Payd OrElse vs.ServiceGiven) AndAlso vs.Insurance.HasValue Then
                        If Not Patient Is Nothing AndAlso Not Patient.CurrentInsurance Is Nothing Then
                            Return Patient.CurrentInsurance
                        End If
                    End If
                Next
                Return Nothing
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property PresentCard() As Nullable(Of Decimal)
        Get
            If VisitServices.ActiveItemsWithoutEmpty.Count = 0 Then
                Return Nothing
            Else
                Dim _price As Decimal = 0
                For Each vs As VisitService In VisitServices.ActiveItemsWithoutEmpty
                    If (vs.Payd OrElse vs.ServiceGiven) AndAlso vs.PresentCardSum.HasValue Then
                        _price += vs.PresentCardSum.Value
                    End If
                Next
                Return _price
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property BonusPointSum() As Nullable(Of Decimal)
        Get
            If VisitServices.ActiveItemsWithoutEmpty.Count = 0 Then
                Return Nothing
            Else
                Dim _price As Decimal = 0
                For Each vs As VisitService In VisitServices.ActiveItemsWithoutEmpty
                    If (vs.Payd OrElse vs.ServiceGiven) AndAlso vs.BonusPoints.HasValue Then
                        _price += vs.BonusPoints.Value
                    End If
                Next
                Return _price
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property PriceWithOutPercentage() As Nullable(Of Decimal)
        Get
            If VisitServices.ActiveItemsWithoutEmpty.Count = 0 Then
                Return Nothing
            Else
                Dim _price As Decimal = 0
                For Each vs As VisitService In VisitServices.ActiveItemsWithoutEmpty
                    If vs.PriceWithOutPercentage.HasValue AndAlso vs.Payd Then
                        _price += vs.PriceWithOutPercentage.Value
                    End If
                Next
                Return _price
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property PercentagePrice() As Nullable(Of Decimal)
        Get
            If VisitServices.ActiveItemsWithoutEmpty.Count = 0 Then
                Return Nothing
            Else
                Dim _price As Decimal = 0
                For Each vs As VisitService In VisitServices.ActiveItemsWithoutEmpty
                    If vs.PercentagePrice.HasValue AndAlso vs.Payd Then
                        _price += vs.PercentagePrice.Value
                    End If
                Next
                Return _price
            End If
        End Get
    End Property

    Public Overridable Property RelatedVisits() As Entities(Of VisitService)
        Get
            If (_relatedVisits Is Nothing) Then
                _relatedVisits = New Entities(Of VisitService)
            End If
            Return _relatedVisits
        End Get
        Set(ByVal value As Entities(Of VisitService))
            _relatedVisits = value
        End Set
    End Property

    Public Overridable Property RelatedVisitsSecond() As Entities(Of VisitService)
        Get
            If (_relatedVisitsSecond Is Nothing) Then
                _relatedVisitsSecond = New Entities(Of VisitService)
            End If
            Return _relatedVisitsSecond
        End Get
        Set(ByVal value As Entities(Of VisitService))
            _relatedVisitsSecond = value
        End Set
    End Property

    Public Overridable Property RelatedVisitsThird() As Entities(Of VisitService)
        Get
            If (_relatedVisitsThird Is Nothing) Then
                _relatedVisitsThird = New Entities(Of VisitService)
            End If
            Return _relatedVisitsThird
        End Get
        Set(ByVal value As Entities(Of VisitService))
            _relatedVisitsThird = value
        End Set
    End Property

    Public Overridable ReadOnly Property IsActivePAK() As Boolean
        Get
            If Patient Is Nothing Then
                Return False
            End If
            If Patient.PatientProfileDetails.ActiveItemsWithoutEmpty.Count > 0 Then
                For Each o As PatientProfileDescription In Patient.PatientProfileDetails.ActiveItemsWithoutEmpty
                    If o.BeginDate <= StartTime.Date AndAlso StartTime.Date <= o.EndDate Then
                        Return True
                    End If
                Next
            Else
                Return False
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property IsActiveSubscription() As Boolean
        Get
            If Patient Is Nothing Then
                Return False
            End If
            If Patient.Abonementi.ActiveItemsWithoutEmpty.Count > 0 Then
                For Each o As Subscription In Patient.Abonementi.ActiveItemsWithoutEmpty
                    For Each detail As SubscriptionDetail In o.SubscriptionDetail
                        If detail.Visit Is Nothing Then
                            Return True
                        End If
                    Next
                Next
                Return False
            Else
                Return False
            End If
        End Get
    End Property

    Public Overridable Property ActivePAK() As PatientProfileDescription
        Get
            Return _activePAK
        End Get
        Set(ByVal value As PatientProfileDescription)
            Assign("ActivePAK", value, _activePAK)
        End Set
    End Property

    Public Overridable Property SetPAK() As Boolean
        Get
            If IsActivePAK AndAlso Not ActivePAK Is Nothing Then
                _setPAK = True
            Else
                _setPAK = False
            End If
            Return _setPAK
        End Get
        Set(ByVal value As Boolean)
            Assign("SetPAK", value, _setPAK)
            If value AndAlso Not Patient Is Nothing Then
                ActivePAK = Patient.GetActivePAK(StartTime)
            Else
                ActivePAK = Nothing
            End If
        End Set
    End Property

    Public Overridable Property SetSusbscription() As Boolean
        Get
            If IsActivePAK AndAlso Not ActivePAK Is Nothing Then
                _setPAK = True
            Else
                _setPAK = False
            End If
            Return _setPAK
        End Get
        Set(ByVal value As Boolean)
            Assign("SetPAK", value, _setPAK)
            If value AndAlso Not Patient Is Nothing Then
                ActivePAK = Patient.GetActivePAK(StartTime)
            Else
                ActivePAK = Nothing
            End If
        End Set
    End Property




End Class
