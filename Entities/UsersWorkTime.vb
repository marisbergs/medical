Imports Core.Bll
Imports Core.Dal

''' <summary>
''' KP lietas tematiskās pārbaudes tēmas
''' </summary>
Public Class UsersWorkTime
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

#Region "Constructor"
    Protected Sub New()
        MyBase.New()
        BusinessRule()
    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession, ByVal userId As Guid, ByVal _day As Day)
        MyBase.New(session)
        Me.User = session.Get(Of User)(userId)
        Me.DayOfWeek = _day
        Me.StartTime = Today
        Me.EndTime = Today
        _createDate = Now.Date
        BusinessRule()
    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession)
        MyBase.New(session)
        BusinessRule()
    End Sub

    Private Sub BusinessRule()
        Validator.AddBusinessRule("Room", AddressOf CommonBusinessRules.CheckRequired, "Room")
        Validator.AddBusinessRule("StartTime", AddressOf CommonBusinessRules.CheckRequired, "StartTime")
        Validator.AddBusinessRule("EndTime", AddressOf CommonBusinessRules.CheckRequired, "EndTime")
        Validator.AddBusinessRule("ValidFrom", AddressOf CommonBusinessRules.CheckRequired, "EndTime")
        Validator.AddBusinessRule("StartTime", AddressOf CommonBusinessRules.CheckTimeInterval, "StartTime", "EndTime")
        Validator.AddBusinessRule("ValidFrom", AddressOf CommonBusinessRules.CheckDateIntervalDateOnly, "ValidFrom", "ValidTo")
        Validator.AddBusinessRule("StartTime", AddressOf CommonBusinessRules.CheckTimeIntervalOverlap, "RoomId")
    End Sub
#End Region

#Region "Private members"
    Private _room As Room
    Private _startTime As DateTime
    Private _endTime As DateTime
    Private _user As User
    Private _dayOfWeek As Day
    Private _acyity As Boolean
    Private _createDate As DateTime
    Private _validFrom As Nullable(Of DateTime)
    Private _validTo As Nullable(Of DateTime)
    Private _workTime As IChildCollection(Of WorkTime)

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
    ''' kabineta Id priekš validācijas
    ''' </summary>
    Public Overridable ReadOnly Property RoomId() As String
        Get
            Dim _result As Entities(Of UsersWorkTime) = Entities(Of UsersWorkTime).GetAll(GetSession, New Core.Dal.Expressions.Eq("DayOfWeek", DayOfWeek), New Core.Dal.Expressions.Or(New Core.Dal.Expressions.Eq("Room", Room), New Core.Dal.Expressions.Eq("User", User)), New Core.Dal.Expressions.IsNull("DeleteTime"), New Core.Dal.Expressions.NotEq("Id", Id))
            For Each x As UsersWorkTime In _result
                If ((StartTime.TimeOfDay > x.StartTime.TimeOfDay AndAlso StartTime.TimeOfDay < x.EndTime.TimeOfDay) OrElse (EndTime.TimeOfDay > x.StartTime.TimeOfDay AndAlso EndTime.TimeOfDay < x.EndTime.TimeOfDay) OrElse (StartTime.TimeOfDay < x.StartTime.TimeOfDay AndAlso EndTime.TimeOfDay > x.EndTime.TimeOfDay) OrElse (StartTime.TimeOfDay = x.StartTime.TimeOfDay AndAlso EndTime.TimeOfDay = x.EndTime.TimeOfDay) OrElse (StartTime.TimeOfDay = x.StartTime.TimeOfDay AndAlso EndTime.TimeOfDay > x.EndTime.TimeOfDay) OrElse (StartTime.TimeOfDay = x.StartTime.TimeOfDay AndAlso EndTime.TimeOfDay < x.EndTime.TimeOfDay)) Then
                    Return x.User.FullName
                End If
            Next
            Return Nothing
        End Get
    End Property

    Public Overridable ReadOnly Property RoomOverlap() As Entities(Of UsersWorkTime)
        Get
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Uzsākšanas laiks
    ''' </summary>
    Public Overridable Property StartTime() As DateTime
        Get
            Return _startTime
        End Get
        Set(ByVal value As DateTime)
            value = New DateTime(1900, 1, 1, value.Hour, value.Minute, 0)
            Assign("StartTime", value, _startTime)
        End Set
    End Property

    ''' <summary>
    ''' Uzsākšanas laiks
    ''' </summary>
    Public Overridable Property StartTimeN() As Nullable(Of DateTime)
        Get
            Return New Nullable(Of DateTime)(_startTime)
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            If (value.HasValue) Then
                StartTime = value.Value
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
            value = New DateTime(1900, 1, 1, value.Hour, value.Minute, 0)
            Assign("EndTime", value, _endTime)
        End Set
    End Property

    ''' <summary>
    ''' Uzsākšanas laiks
    ''' </summary>
    Public Overridable Property EndTimeN() As Nullable(Of DateTime)
        Get
            Return New Nullable(Of DateTime)(_endTime)
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            If (value.HasValue) Then
                EndTime = value.Value
            End If
        End Set
    End Property

    Public Overridable Property ValidFrom() As Nullable(Of DateTime)
        Get
            Return _validFrom
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("ValidFrom", value, _validFrom)
        End Set
    End Property

    Public Overridable Property ValidTo() As Nullable(Of DateTime)
        Get
            Return _validTo
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("ValidTo", value, _validTo)
        End Set
    End Property

    ''' <summary>
    ''' Beigšanas laiks
    ''' </summary>
    Public Overridable Property DayOfWeek() As Day
        Get
            Return _dayOfWeek
        End Get
        Set(ByVal value As Day)
            Assign("DayOfWeek", value, _dayOfWeek)
        End Set
    End Property

    ''' <summary>
    ''' Saistītā KP lieta
    ''' </summary>
    Public Overridable Property User() As Entities.User
        Get
            Return _user
        End Get
        Set(ByVal value As Entities.User)
            Assign("User", value, _user)
        End Set
    End Property

    Public Overridable Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.User
        End Get
        Set(ByVal value As Object)
            Me.User = CType(value, User)
        End Set
    End Property

    Public Overridable Property Acyity() As Boolean
        Get
            Return _acyity
        End Get
        Set(ByVal value As Boolean)
            Assign("Acyity", value, _acyity)
        End Set
    End Property

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

    Public Overridable Property CreateDate() As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal value As DateTime)
            _createDate = value
        End Set
    End Property

    Public Overridable Property WorkTime() As Core.Dal.IChildCollection(Of WorkTime)
        Get
            Return _workTime
        End Get
        Protected Set(ByVal value As Core.Dal.IChildCollection(Of WorkTime))
            _workTime = value
            _workTime.Parent = Me
        End Set
    End Property

End Class
' Уныкоде