Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class Campaign
    Inherits BusinessObjectBase(Of Guid)

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        AddBusinessRoles()
    End Sub
    Public Sub New()
        AddBusinessRoles()
    End Sub

    Private Sub AddBusinessRoles()
        Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckRequired, "Name")
        Validator.AddBusinessRule("ValidFrom", AddressOf CommonBusinessRules.CheckRequired, "ValidFrom")
        Validator.AddBusinessRule("ValidTo", AddressOf CommonBusinessRules.CheckRequired, "ValidTo")
        Validator.AddBusinessRule("Code", AddressOf CommonBusinessRules.CheckRequired, "Code")
        Validator.AddBusinessRule("ValidFrom", AddressOf CommonBusinessRules.CheckDateInterval, "ValidFrom", "ValidTo")
    End Sub

#Region "Private members"
    Private _name As String
    Private _nameForPrint As String
    Private _validFrom As Nullable(Of DateTime)
    Private _validTo As Nullable(Of DateTime)
    Private _discount As Integer
    Private _code As String
    Private _comment As String
    Private _createUser As User
    Private _createDate As DateTime
    Private _campaignValue As Decimal
    Private _campaignPatients As IChildCollection(Of CampaignPatient) = New ChildCollection(Of CampaignPatient)

#End Region

#Region "Public member"

    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            Assign("Name", value, _name)
        End Set
    End Property

    Public Overridable Property NameForPrint() As String
        Get
            Return _nameForPrint
        End Get
        Set(ByVal value As String)
            Assign("NameForPrint", value, _nameForPrint)
        End Set
    End Property

    Public Overridable Property ValidFrom() As Nullable(Of Date)
        Get
            Return _validFrom
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("ValidFrom", value, _validFrom)
        End Set
    End Property

    Public Overridable Property ValidTo() As Nullable(Of Date)
        Get
            Return _validTo
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("ValidTo", value, _validTo)
        End Set
    End Property

    Public Overridable Property Discount() As Integer
        Get
            Return _discount
        End Get
        Set(ByVal value As Integer)
            Assign("Discount", value, _discount)
        End Set
    End Property

    Public Overridable Property CampaignValue() As Decimal
        Get
            Return _campaignValue
        End Get
        Set(ByVal value As Decimal)
            Assign("CampaignValue", value, _campaignValue)
        End Set
    End Property

    Public Overridable Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            Assign("Code", value, _code)
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

    Public Overridable Property CreateUser() As User
        Get
            Return _createUser
        End Get
        Set(ByVal value As User)
            Assign("CreateUser", value, _createUser)
        End Set
    End Property

    Public Overridable Property CreateDate() As Date
        Get
            Return _createDate
        End Get
        Set(ByVal value As Date)
            Assign("CreateDate", value, _createDate)
        End Set
    End Property

    Public Overridable Property CampaignPatients() As Core.Dal.IChildCollection(Of CampaignPatient)
        Get
            Return _campaignPatients
        End Get
        Protected Set(ByVal value As Core.Dal.IChildCollection(Of CampaignPatient))
            _campaignPatients = value
            _campaignPatients.Parent = Me
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return CStr(IIf(Name Is Nothing, "", Name))
    End Function

#End Region

End Class
