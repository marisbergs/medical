Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class BonusPoints
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        AddBusinessRoles()
    End Sub
    Public Sub New()
    End Sub

    Private Sub AddBusinessRoles()
        Validator.AddBusinessRule("Value", AddressOf CommonBusinessRules.CheckRequired, "Value")
    End Sub

#Region "Private members"
    Private _patient As Patient
    Private _patientTo As Patient
    Private _patientFrom As Patient
    Private _eventDate As DateTime
    Private _value As Decimal
    Private _comment As String
    Private _visit As Visit
    Private _user As User
    Private _bonusPointType As BonusPointType

#End Region

#Region "Public member"


    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            Assign("Patient", value, _patient)
        End Set
    End Property

    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.Patient
        End Get
        Set(ByVal value As Object)
            Me.Patient = CType(value, Patient)
        End Set
    End Property

    Public Overridable Property PatientTo() As Patient
        Get
            Return _patientTo
        End Get
        Set(ByVal value As Patient)
            Assign("PatientTo", value, _patientTo)
        End Set
    End Property

    Public Overridable Property PatientFrom() As Patient
        Get
            Return _patientFrom
        End Get
        Set(ByVal value As Patient)
            Assign("PatientFrom", value, _patientFrom)
        End Set
    End Property

    Public Overridable Property EventDate() As Date
        Get
            Return _eventDate
        End Get
        Set(ByVal value As Date)
            Assign("EventDate", value, _eventDate)
        End Set
    End Property

    Public Overridable Property Value() As Decimal
        Get
            Return _value
        End Get
        Set(ByVal value As Decimal)
            Assign("Value", value, _value)
        End Set
    End Property

    Public Overridable Property Comment() As String
        Get
            Return _comment
        End Get
        Set(ByVal value As String)
            Assign("Comment", value, _comment)
        End Set
    End Property

    Public Overridable Property Visit() As Visit
        Get
            Return _visit
        End Get
        Set(ByVal value As Visit)
            Assign("Visit", value, _visit)
        End Set
    End Property

    Public Overridable Property User() As User
        Get
            Return _user
        End Get
        Set(ByVal value As User)
            Assign("User", value, _user)
        End Set
    End Property

    Public Overridable Property BonusPointType() As BonusPointType
        Get
            Return _bonusPointType
        End Get
        Set(ByVal value As BonusPointType)
            Assign("BonusPointType", value, _bonusPointType)
        End Set
    End Property

    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Return PermissionsChecker.CanDo("Patient.ManageBonusPoints")
        End Get
    End Property

    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Return PermissionsChecker.CanDo("Patient.ManageBonusPoints")
        End Get
    End Property


#End Region

End Class
