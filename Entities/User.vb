Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Collections
Imports core
Imports Core.Bll
Imports Entities
Imports Core.Dal
''' <summary>
''' Lietotājs
''' </summary>
<Serializable()> _
Public Class User
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements Core.Dal.ISynchronizesSeparately
#Region "Private members"
    Private _firstName As String
    Private _lastName As String
    Private _otherNames As String
    Private _signature As String
    Private _email As String
    Private _phone As String
    Private _cellPhone As String
    Private _position As Position
    Private _logon As String
    Private _role As Role
    Private _worksFrom As Nullable(Of DateTime)
    Private _workedUntil As Nullable(Of DateTime)
    Private _userSpecialities As IChildCollection(Of UsersSpecialities)
    Private _userServices As IChildCollection(Of UserService)
    Private _usersWorkTime As IChildCollection(Of UsersWorkTime)
    Private _userLanguage As IChildCollection(Of UserLanguage)
    Private _password As String
    Private _code As String
    Private _pK As String
    Private _salary As Nullable(Of Decimal)
    Private _userGrouping As EmployeGrouping
    Private _salaryNote As String
    Private _interfaceLanguage As String
#End Region
#Region "Constructors"
    Protected Sub New()
        AddBusinessRules()
    End Sub
    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        UserSpecialities = New ChildCollection(Of UsersSpecialities)
        UserServices = New ChildCollection(Of UserService)
        UsersWorkTime = New ChildCollection(Of UsersWorkTime)
        UserLanguage = New ChildCollection(Of UserLanguage)
        AddBusinessRules()
    End Sub
    Private Sub AddBusinessRules()
        'Validator.AddBusinessRule("UnavailableFrom", AddressOf CommonBusinessRules.CheckConditionalDateIntervalDateOnly, "UnavailableFromTouched", "Today", "UnavailableFrom")
        'Validator.AddBusinessRule("Organization", AddressOf CommonBusinessRules.CheckRequired, "Organization")
        Validator.AddBusinessRule("Position", AddressOf CommonBusinessRules.CheckRequired, "Position")

        Validator.AddBusinessRule("FirstName", AddressOf CommonBusinessRules.CheckRequired, "FirstName")
        Validator.AddBusinessRule("LastName", AddressOf CommonBusinessRules.CheckRequired, "LastName")
        'Validator.AddBusinessRule("PersonCode", AddressOf CommonBusinessRules.CheckRequired, "PersonCode")
        ''Validator.AddBusinessRule("PersonCode", AddressOf CommonBusinessRules.CheckMinLength, "PersonCode", 11)
        Validator.AddBusinessRule("WorksFrom", AddressOf CommonBusinessRules.CheckRequired, "WorksFrom")

        Validator.AddBusinessRule("WorksFrom", AddressOf CommonBusinessRules.CheckDateInterval, "WorksFrom", "WorkedUntil")
        Validator.AddBusinessRule("WorkedUntil", AddressOf CommonBusinessRules.CheckDateInterval, "WorksFrom", "WorkedUntil")

        'Validator.AddBusinessRule("UnavailableFrom", AddressOf CommonBusinessRules.CheckDateInterval, "UnavailableFrom", "UnavailableUntil")
        ''Validator.AddBusinessRule("UnavailableFrom", AddressOf CommonBusinessRules.CheckConditionalDateIntervalDateOnly, "UnavailableFromTouched", DateTime.Today, "UnavailableFrom")
        'Validator.AddBusinessRule("UnavailableUntil", AddressOf CommonBusinessRules.CheckDateInterval, "UnavailableFrom", "UnavailableUntil")

        Validator.AddBusinessRule("Logon", AddressOf CommonBusinessRules.CheckConditionalRequiredObj, "Role", "Logon")
        'Validator.AddBusinessRule("UnavailableUntil", AddressOf CommonBusinessRules.CheckConditionalRequiredObj, "UnavailableFrom", "UnavailableUntil")
        'Validator.AddBusinessRule("UnavailableFrom", AddressOf CommonBusinessRules.CheckConditionalRequiredObj, "UnavailableUntil", "UnavailableFrom")
        Validator.AddBusinessRule("Email", AddressOf CommonBusinessRules.CheckEmailFormat, "Email")
    End Sub
#End Region
#Region "Getters&Setters"

    ''' <summary>
    ''' Vārds
    ''' </summary>
    Public Overridable Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            Assign("FirstName", value, _firstName)
        End Set
    End Property

    ''' <summary>
    ''' Uzvārds
    ''' </summary>
    Public Overridable Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            Assign("LastName", value, _lastName)
        End Set
    End Property

    ''' <summary>
    ''' Otrs vārds
    ''' </summary>
    Public Overridable Property OtherNames() As String
        Get
            Return _otherNames
        End Get
        Set(ByVal value As String)
            Assign("OtherNames", value, _otherNames)
        End Set
    End Property

    ''' <summary>
    ''' Paraksts
    ''' </summary>
    Public Overridable Property Signature() As String
        Get
            Return _signature
        End Get
        Set(ByVal value As String)
            Assign("Signature", value, _signature)
        End Set
    End Property

    ''' <summary>
    ''' E-pasts
    ''' </summary>
    Public Overridable Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            Assign("Email", value, _email)
        End Set
    End Property

    ''' <summary>
    ''' Tālrunis
    ''' </summary>
    Public Overridable Property Phone() As String
        Get
            Return _phone
        End Get
        Set(ByVal value As String)
            Assign("Phone", value, _phone)
        End Set
    End Property

    ''' <summary>
    ''' Mob.tālrunis
    ''' </summary>
    Public Overridable Property CellPhone() As String
        Get
            Return _cellPhone
        End Get
        Set(ByVal value As String)
            Assign("CellPhone", value, _cellPhone)
        End Set
    End Property

    ''' <summary>
    ''' Darbinieka kods
    ''' </summary>
    Public Overridable Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            Assign("Code", value, _code)
        End Set
    End Property

    ''' <summary>
    ''' Piezīmes par darba līgumu un apmaksas noteikumiem
    ''' </summary>
    Public Overridable Property SalaryNote() As String
        Get
            Return _salaryNote
        End Get
        Set(ByVal value As String)
            Assign("SalaryNote", value, _salaryNote)
        End Set
    End Property

    Public Overridable Property InterfaceLanguage() As String
        Get
            Return _interfaceLanguage
        End Get
        Set(value As String)
            _interfaceLanguage = value
        End Set
    End Property

    ''' <summary>
    ''' Darbinieka personas kods
    ''' </summary>
    Public Overridable Property PK() As String
        Get
            Return _pk
        End Get
        Set(ByVal value As String)
            Assign("PK", value, _pk)
        End Set
    End Property

    ''' <summary>
    ''' Amats
    ''' </summary>
    Public Overridable Property Position() As Position
        Get
            Return _position
        End Get
        Set(ByVal value As Position)
            Assign("Position", value, _position)
        End Set
    End Property

    ''' <summary>
    ''' Lietotājs
    ''' </summary>
    Public Overridable Property Logon() As String
        Get
            Return _logon
        End Get
        Set(ByVal value As String)
            Assign("Logon", value, _logon)
        End Set
    End Property

    ''' <summary>
    ''' Parole
    ''' </summary>
    Public Overridable Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            If (Not value Is Nothing) Then
                value = Core.Dal.Manager.Encrypt(value)
            End If
            Assign("Password", value, _password)
        End Set
    End Property

    ''' <summary>
    ''' Loma
    ''' </summary>
    Public Overridable Property Role() As Role
        Get
            Return _role
        End Get
        Set(ByVal value As Role)
            Assign("Role", value, _role)
        End Set
    End Property

    ''' <summary>
    ''' Strādā no
    ''' </summary>
    Public Overridable Property WorksFrom() As Nullable(Of DateTime)
        Get
            Return _worksFrom
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("WorksFrom", value, _worksFrom)
        End Set
    End Property

    ''' <summary>
    ''' Strādāja līdz
    ''' </summary>
    Public Overridable Property WorkedUntil() As Nullable(Of DateTime)
        Get
            Return _workedUntil
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("WorkedUntil", value, _workedUntil)
        End Set
    End Property

    ''' <summary>
    ''' uzvārds, vārds
    ''' </summary>
    Public Overridable ReadOnly Property FullName() As String
        Get
            If _firstName Is Nothing And _lastName Is Nothing And _otherNames Is Nothing Then
                Return ""
            End If
            If Not _otherNames Is Nothing Then
                If _otherNames.Trim().Length > 0 Then
                    Return _lastName.Trim() & " " & _firstName.Trim() & " " & _otherNames.Trim()
                End If
            End If
            Return _lastName.Trim() & " " & _firstName.Trim()
        End Get
    End Property

    ''' <summary>
    ''' uzvārds, vārds
    ''' </summary>
    Public Overridable ReadOnly Property FullNameStartWithName() As String
        Get
            If _firstName Is Nothing And _lastName Is Nothing And _otherNames Is Nothing Then
                Return ""
            End If
            If Not _otherNames Is Nothing Then
                If _otherNames.Trim().Length > 0 Then
                    Return _firstName.Trim() & " " & _otherNames.Trim() & " " & _lastName.Trim()
                End If
            End If
            Return _firstName.Trim() & " " & _lastName.Trim()
        End Get
    End Property

    ''' <summary>
    ''' Ir sistēmas lietotājs
    ''' </summary>
    Public Overridable ReadOnly Property IsSystemUser() As Boolean
        Get
            If Not _role Is Nothing And Not _logon Is Nothing Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Overridable Property Salary() As Nullable(Of Decimal)
        Get
            Return _salary
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Assign("Salary", value, _salary)
        End Set
    End Property

    Public Overridable Property UserGrouping() As EmployeGrouping
        Get
            Return _userGrouping
        End Get
        Set(ByVal value As EmployeGrouping)
            Assign("UserGrouping", value, _userGrouping)
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.FullName
    End Function

    Public Overridable ReadOnly Property DoctorNameAndSpecialities() As String
        Get
            Return FullName & " " & Phone & " " & " -- " & Specialities
        End Get
    End Property

    Public Overridable Property UserSpecialities() As IChildCollection(Of UsersSpecialities)
        Get
            Return _userSpecialities
        End Get
        Set(ByVal value As IChildCollection(Of UsersSpecialities))
            Assign("UserSpecialities", value, _userSpecialities)
        End Set
    End Property

    Private _specialities As String
    Public Overridable Property Specialities() As String
        Get
            If (String.IsNullOrEmpty(_specialities)) Then
                Return ""
            End If
            Return _specialities.Trim().TrimEnd(CChar(";"))
        End Get
        Set(ByVal value As String)
            _specialities = value
        End Set
    End Property

    Private _languages As String
    Public Overridable ReadOnly Property Languages() As String
        Get
            Return _languages
        End Get
    End Property

    Public Overridable Property UserServices() As IChildCollection(Of UserService)
        Get
            Return _userServices
        End Get
        Set(ByVal value As IChildCollection(Of UserService))
            Assign("UserServices", value, _userServices)
        End Set
    End Property

    Public Overridable Property UsersWorkTime() As IChildCollection(Of UsersWorkTime)
        Get
            Return _usersWorkTime
        End Get
        Set(ByVal value As IChildCollection(Of UsersWorkTime))
            Assign("UsersWorkTime", value, _usersWorkTime)
        End Set
    End Property

    Public Overridable Property UserLanguage() As IChildCollection(Of UserLanguage)
        Get
            Return _userLanguage
        End Get
        Set(ByVal value As IChildCollection(Of UserLanguage))
            Assign("UserLanguage", value, _userLanguage)
        End Set
    End Property

    ''' <summary>
    ''' Šodiena
    ''' </summary>
    Public Overridable ReadOnly Property Today() As DateTime
        Get
            Return DateTime.Now
        End Get
    End Property

    Public Overridable Function CreateTable() As Entities(Of TimeTable)
        CreateTable = New Entities(Of TimeTable)
        If Not Me.UsersWorkTime Is Nothing Then
            Dim _obj As TimeTable
            Dim _startTime As DateTime = Now.Date
            Dim _start As SystemParameter = GetSession().Get(Of SystemParameter)("PLANER_TIME_START")
            Dim _end As SystemParameter = GetSession().Get(Of SystemParameter)("PLANER_TIME_END")
            For i As Integer = _start.ParamDate.Value.Hour To _end.ParamDate.Value.Hour
                For j As Integer = 0 To 59 Step Integer.Parse(GetSession().Get(Of SystemParameter)("USER_WORK_FREQUENCE").Value)
                    _obj = New TimeTable
                    _obj.Time = _startTime.AddHours(i).AddMinutes(j)
                    For Each x As UsersWorkTime In Me.UsersWorkTime.ActiveItemsWithoutEmpty
                        If x.StartTime.TimeOfDay <= _obj.Time.TimeOfDay AndAlso x.EndTime.TimeOfDay > _obj.Time.TimeOfDay Then
                            Select Case x.DayOfWeek
                                Case Day.Monday
                                    _obj.Monday = "Kabinets " & x.Room.ToString() & Chr(10) & " Laiks " & x.StartTime.ToShortTimeString() & " - " & x.EndTime.ToShortTimeString() & IIf(x.Acyity, Chr(10) & "Akūtās vizītes", "").ToString()
                                    _obj.MondayId = x.Id
                                    _obj.MondayAcyity = x.Acyity
                                Case Day.Tuesday
                                    _obj.Tuesday = "Kabinets " & x.Room.ToString() & Chr(10) & " Laiks " & x.StartTime.ToShortTimeString() & " - " & x.EndTime.ToShortTimeString() & IIf(x.Acyity, Chr(10) & "Akūtās vizītes", "").ToString()
                                    _obj.TuesdayId = x.Id
                                    _obj.TuesdayAcyity = x.Acyity
                                Case Day.Wednesday
                                    _obj.Wednesday = "Kabinets " & x.Room.ToString() & Chr(10) & " Laiks " & x.StartTime.ToShortTimeString() & " - " & x.EndTime.ToShortTimeString() & IIf(x.Acyity, Chr(10) & "Akūtās vizītes", "").ToString()
                                    _obj.WednesdayId = x.Id
                                    _obj.WednesdayAcyity = x.Acyity
                                Case Day.Thursday
                                    _obj.Thursday = "Kabinets " & x.Room.ToString() & Chr(10) & " Laiks " & x.StartTime.ToShortTimeString() & " - " & x.EndTime.ToShortTimeString() & IIf(x.Acyity, Chr(10) & "Akūtās vizītes", "").ToString()
                                    _obj.ThursdayId = x.Id
                                    _obj.ThursdayAcyity = x.Acyity
                                Case Day.Friday
                                    _obj.Friday = "Kabinets " & x.Room.ToString() & Chr(10) & " Laiks " & x.StartTime.ToShortTimeString() & " - " & x.EndTime.ToShortTimeString() & IIf(x.Acyity, Chr(10) & "Akūtās vizītes", "").ToString()
                                    _obj.FridayId = x.Id
                                    _obj.FridayAcyity = x.Acyity
                                Case Day.Saturday
                                    _obj.Saturday = "Kabinets " & x.Room.ToString() & Chr(10) & " Laiks " & x.StartTime.ToShortTimeString() & " - " & x.EndTime.ToShortTimeString() & IIf(x.Acyity, Chr(10) & "Akūtās vizītes", "").ToString()
                                    _obj.SaturdayId = x.Id
                                    _obj.SaturdayAcyity = x.Acyity
                                Case Day.Sanday
                                    _obj.Sunday = "Kabinets " & x.Room.ToString() & Chr(10) & " Laiks " & x.StartTime.ToShortTimeString() & " - " & x.EndTime.ToShortTimeString() & IIf(x.Acyity, Chr(10) & "Akūtās vizītes", "").ToString()
                                    _obj.SundayId = x.Id
                                    _obj.SundayAcyity = x.Acyity
                            End Select
                        End If
                    Next
                    CreateTable.Add(_obj)
                    If i = _end.ParamDate.Value.Hour Then
                        Exit For
                    End If
                Next
            Next
        End If
        Return CreateTable
    End Function

#End Region
#Region "Can-Do properties"
    Public Overridable ReadOnly Property CanAddDelete() As Boolean
        Get
            Return CanDo("User.AddDelete")
        End Get
    End Property

    Public Overridable ReadOnly Property CanAddDeleteSpeciality() As Boolean
        Get
            If Me.Position Is Nothing Then Return False
            Return CanDo("User.AddDeleteSpecaiality") And Me.Position.Mark
        End Get
    End Property

    Public Overridable ReadOnly Property CanAddDeleteWorkTime() As Boolean
        Get
            If Me.Position Is Nothing Then Return False
            Return CanDo("User.AddDeleteDeleteWorkTime") And Me.Position.Mark
        End Get
    End Property

    Public Overridable ReadOnly Property CanUnlock() As Boolean
        Get
            Return CanDo("User.Unlock")
        End Get
    End Property

    Public Overridable ReadOnly Property CanChangeBaseInfo() As Boolean
        Get
            Return CanDo("User.ChangeBaseInfo")
            'Return CanAddDelete OrElse CanDo("User.ChangeBaseInfo")
        End Get
    End Property

    Public Overridable ReadOnly Property CanChangeLogonRole() As Boolean
        Get
            'Return (CanAddDelete OrElse CanDo("User.ChangeLogonRole"))
            Return CanDo("User.ChangeLogonRole")
        End Get
    End Property

    Public Overridable ReadOnly Property CanChangeRole() As Boolean
        Get
            Return Me.CanChangeLogonRole And (Not Me.Logon = String.Empty)
        End Get
    End Property

    Public Overridable ReadOnly Property CanChangeOtherInfo() As Boolean
        Get
            Return CanDo("User.ChangeOtherInfo")
            'Return CanAddDelete OrElse CanDo("User.ChangeOtherInfo")
        End Get
    End Property

    Public Overridable ReadOnly Property CanEditPassword() As Boolean
        Get
            Return CanDo("User.ChangeLogonRole") And Id = Guid.Empty
            'Return CanAddDelete OrElse CanDo("User.ChangeOtherInfo")
        End Get
    End Property

    Public Overrides ReadOnly Property CanSave() As Boolean
        Get
            Return CanChangeBaseInfo OrElse _
                   CanChangeLogonRole OrElse CanChangeOtherInfo OrElse _
                   CanAddDelete
        End Get
    End Property

    Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
        MyBase.OnPropertyChanged(propertyName)
        Select Case propertyName
            Case "CanChangeLogonRole"
                OnPropertyChanged("CanChangeRole")
            Case "Position"
                OnPropertyChanged("CanAddDeleteSpeciality")
                OnPropertyChanged("CanAddDeleteWorkTime")
        End Select
    End Sub
#End Region
#Region "Actions"
    Protected Overrides Sub OnSaveNew()
        MyBase.OnSaveNew()
        Core.Logger.DB.Log(GetSession(), AuditMessage.UserAdd, Me)
    End Sub

    ''' <summary>
    ''' Revokes user's access to system by removing Role
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub LockOut()
        If Not Role Is Nothing Then
            Role = Nothing
        End If
    End Sub

    Public Overridable Sub Delete()
        If IsActive Then
            IsActive = False
        End If
    End Sub
#End Region
#Region "Save"
    Public Overrides Function Save() As Core.Result
        Dim result As Core.Result = MyBase.Save()
        If result.HasErrors Then Return result
        Return result
    End Function
#End Region
End Class

Public Class TimeTable
    Inherits BusinessObjectBase(Of Guid)
    Private _time As DateTime
    Private _monday As String
    Private _mondayId As Guid
    Private _mondayValue As Object
    Private _tuesday As String
    Private _tuesdayId As Guid
    Private _tuesdayValue As Object
    Private _wednesday As String
    Private _wednesdayId As Guid
    Private _wednesdayValue As Object
    Private _thursday As String
    Private _thursdayId As Guid
    Private _thursdayValue As Object
    Private _friday As String
    Private _fridayId As Guid
    Private _fridayValue As Object
    Private _saturday As String
    Private _saturdayId As Guid
    Private _saturdayValue As Object
    Private _sunday As String
    Private _sundayId As Guid
    Private _sundayValue As Object
    Private _mondayAcyity As Boolean
    Private _tuesdayAcyity As Boolean
    Private _wednesdayAcyity As Boolean
    Private _thursdayAcyity As Boolean
    Private _fridayAcyity As Boolean
    Private _saturdayAcyity As Boolean
    Private _sundayAcyity As Boolean
    Private _doctor As User
    Private _room As Room
    Private _speciality As Speciality
    Private _visiteType As VisitType
    Private _forVisits As Boolean
    Private _forHeder As Boolean

    Public Property Time() As DateTime
        Get
            Return _time
        End Get
        Set(ByVal value As DateTime)
            _time = value
        End Set
    End Property

    Public Property MondayAcyity() As Boolean
        Get
            Return _mondayAcyity
        End Get
        Set(ByVal value As Boolean)
            _mondayAcyity = value
        End Set
    End Property

    Public Property Monday() As String
        Get
            Return _monday
        End Get
        Set(ByVal value As String)
            _monday = value
        End Set
    End Property

    Public Property MondayId() As Guid
        Get
            Return _mondayId
        End Get
        Set(ByVal value As Guid)
            _mondayId = value
        End Set
    End Property

    Public Property MondayValue() As Object
        Get
            Return _mondayValue
        End Get
        Set(ByVal value As Object)
            _mondayValue = value
            If value Is Nothing Then
                _mondayAcyity = False
                _monday = ""
                Return
            End If
            If value.GetType().Name = "WorkTime" Then
                _mondayAcyity = CType(value, WorkTime).Acity
                _monday = CType(value, WorkTime).StringValue(_forVisits)
            End If
            If value.GetType().Name = "Visit" Then
                _mondayAcyity = CType(value, Visit).Acyity
                _monday = CType(value, Visit).ToString()
            End If
        End Set
    End Property


    Public Property Tuesday() As String
        Get
            Return _tuesday
        End Get
        Set(ByVal value As String)
            _tuesday = value
        End Set
    End Property

    Public Property TuesdayId() As Guid
        Get
            Return _tuesdayId
        End Get
        Set(ByVal value As Guid)
            _tuesdayId = value
        End Set
    End Property

    Public Property TuesdayValue() As Object
        Get
            Return _tuesdayValue
        End Get
        Set(ByVal value As Object)
            _tuesdayValue = value
            If value Is Nothing Then
                _tuesdayAcyity = False
                _tuesday = ""
                Return
            End If
            If value.GetType().Name = "WorkTime" Then
                _tuesdayAcyity = CType(value, WorkTime).Acity
                _tuesday = CType(value, WorkTime).StringValue(_forVisits)
            End If
            If value.GetType().Name = "Visit" Then
                _tuesdayAcyity = CType(value, Visit).Acyity
                _tuesday = CType(value, Visit).ToString()
            End If
        End Set
    End Property

    Public Property TuesdayAcyity() As Boolean
        Get
            Return _TuesdayAcyity
        End Get
        Set(ByVal value As Boolean)
            _TuesdayAcyity = value
        End Set
    End Property

    Public Property Wednesday() As String
        Get
            Return _wednesday
        End Get
        Set(ByVal value As String)
            _wednesday = value
        End Set
    End Property

    Public Property WednesdayAcyity() As Boolean
        Get
            Return _WednesdayAcyity
        End Get
        Set(ByVal value As Boolean)
            _WednesdayAcyity = value
        End Set
    End Property

    Public Property WednesdayValue() As Object
        Get
            Return _wednesdayValue
        End Get
        Set(ByVal value As Object)
            _wednesdayValue = value
            If value Is Nothing Then
                _wednesdayAcyity = False
                _wednesday = ""
                Return
            End If
            If value.GetType().Name = "WorkTime" Then
                _wednesdayAcyity = CType(value, WorkTime).Acity
                _wednesday = CType(value, WorkTime).StringValue(_forVisits)
            End If
            If value.GetType().Name = "Visit" Then
                _wednesdayAcyity = CType(value, Visit).Acyity
                _wednesday = CType(value, Visit).ToString()
            End If
        End Set
    End Property

    Public Property WednesdayId() As Guid
        Get
            Return _wednesdayId
        End Get
        Set(ByVal value As Guid)
            _wednesdayId = value
        End Set
    End Property

    Public Property Thursday() As String
        Get
            Return _thursday
        End Get
        Set(ByVal value As String)
            _thursday = value
        End Set
    End Property

    Public Property ThursdayId() As Guid
        Get
            Return _thursdayId
        End Get
        Set(ByVal value As Guid)
            _thursdayId = value
        End Set
    End Property

    Public Property ThursdayValue() As Object
        Get
            Return _thursdayValue
        End Get
        Set(ByVal value As Object)
            _thursdayValue = value
            If value Is Nothing Then
                _thursdayAcyity = False
                _thursday = ""
                Return
            End If
            If value.GetType().Name = "WorkTime" Then
                _thursdayAcyity = CType(value, WorkTime).Acity
                _thursday = CType(value, WorkTime).StringValue(_forVisits)
            End If
            If value.GetType().Name = "Visit" Then
                _thursdayAcyity = CType(value, Visit).Acyity
                _thursday = CType(value, Visit).ToString()
            End If
        End Set
    End Property

    Public Property ThursdayAcyity() As Boolean
        Get
            Return _thursdayAcyity
        End Get
        Set(ByVal value As Boolean)
            _thursdayAcyity = value
        End Set
    End Property

    Public Property Friday() As String
        Get
            Return _friday
        End Get
        Set(ByVal value As String)
            _friday = value
        End Set
    End Property

    Public Property FridayId() As Guid
        Get
            Return _fridayId
        End Get
        Set(ByVal value As Guid)
            _fridayId = value
        End Set
    End Property

    Public Property FridayValue() As Object
        Get
            Return _fridayValue
        End Get
        Set(ByVal value As Object)
            _fridayValue = value
            If value Is Nothing Then
                _fridayAcyity = False
                _friday = ""
                Return
            End If
            If value.GetType().Name = "WorkTime" Then
                _fridayAcyity = CType(value, WorkTime).Acity
                _friday = CType(value, WorkTime).StringValue(_forVisits)
            End If
            If value.GetType().Name = "Visit" Then
                _fridayAcyity = CType(value, Visit).Acyity
                _friday = CType(value, Visit).ToString()
            End If
        End Set
    End Property

    Public Property FridayAcyity() As Boolean
        Get
            Return _fridayAcyity
        End Get
        Set(ByVal value As Boolean)
            _fridayAcyity = value
        End Set
    End Property

    Public Property Saturday() As String
        Get
            Return _saturday
        End Get
        Set(ByVal value As String)
            _saturday = value
        End Set
    End Property

    Public Property SaturdayId() As Guid
        Get
            Return _saturdayId
        End Get
        Set(ByVal value As Guid)
            _saturdayId = value
        End Set
    End Property

    Public Property SaturdayValue() As Object
        Get
            Return _saturdayValue
        End Get
        Set(ByVal value As Object)
            _saturdayValue = value
            If value Is Nothing Then
                _saturdayAcyity = False
                _saturday = ""
                Return
            End If
            If value.GetType().Name = "WorkTime" Then
                _saturdayAcyity = CType(value, WorkTime).Acity
                _saturday = CType(value, WorkTime).StringValue(_forVisits)
            End If
            If value.GetType().Name = "Visit" Then
                _saturdayAcyity = CType(value, Visit).Acyity
                _saturday = CType(value, Visit).ToString()
            End If
        End Set
    End Property

    Public Property SaturdayAcyity() As Boolean
        Get
            Return _saturdayAcyity
        End Get
        Set(ByVal value As Boolean)
            _saturdayAcyity = value
        End Set
    End Property

    Public Property Sunday() As String
        Get
            Return _sunday
        End Get
        Set(ByVal value As String)
            _sunday = value
        End Set
    End Property

    Public Property SundayId() As Guid
        Get
            Return _sundayId
        End Get
        Set(ByVal value As Guid)
            _sundayId = value
        End Set
    End Property

    Public Property SundayValue() As Object
        Get
            Return _sundayValue
        End Get
        Set(ByVal value As Object)
            _sundayValue = value
            If value Is Nothing Then
                _sundayAcyity = False
                _sunday = ""
                Return
            End If
            If value.GetType().Name = "WorkTime" Then
                _sundayAcyity = CType(value, WorkTime).Acity
                _sunday = CType(value, WorkTime).StringValue(_forVisits)
            End If
            If value.GetType().Name = "Visit" Then
                _sundayAcyity = CType(value, Visit).Acyity
                _sunday = CType(value, Visit).ToString()
            End If
        End Set
    End Property

    Public Property SundayAcyity() As Boolean
        Get
            Return _saturdayAcyity
        End Get
        Set(ByVal value As Boolean)
            _sundayAcyity = value
        End Set
    End Property

    Public Property Doctor() As User
        Get
            Return _doctor
        End Get
        Set(ByVal value As User)
            _doctor = value
        End Set
    End Property

    Public Property Room() As Room
        Get
            Return _room
        End Get
        Set(ByVal value As Room)
            _room = value
        End Set
    End Property

    ''' <summary>
    ''' specialitāte
    ''' </summary>
    Public Overridable Property Speciality() As Entities.Speciality
        Get
            Return _speciality
        End Get
        Set(ByVal value As Entities.Speciality)
            Assign("Speciality", value, _speciality)
        End Set
    End Property

    ''' <summary>
    ''' ārsts
    ''' </summary>
    Public Overridable Property VisiteType() As Entities.VisitType
        Get
            Return _visiteType
        End Get
        Set(ByVal value As Entities.VisitType)
            Assign("VisiteType", value, _visiteType)
        End Set
    End Property

    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overridable Property ForVisit() As Boolean
        Get
            Return _forVisits
        End Get
        Set(ByVal value As Boolean)
            _forVisits = value
        End Set
    End Property

    Public Overridable Property ForHeder() As Boolean
        Get
            Return _forHeder
        End Get
        Set(ByVal value As Boolean)
            _forHeder = value
        End Set
    End Property

    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Return False
        End Get
    End Property

    Public Overridable ReadOnly Property DoctorForDisplay() As String
        Get
            If Doctor Is Nothing Then
                Return ""
            End If
            Return Doctor.DoctorNameAndSpecialities
        End Get
    End Property

End Class