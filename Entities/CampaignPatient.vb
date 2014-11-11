Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class CampaignPatient
    Inherits BusinessObjectBase(Of Guid)

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
    Private _campaign As Campaign
    Private _patient As Patient
    Private _validFrom As Nullable(Of DateTime)
    Private _validTo As Nullable(Of DateTime)
    Private _discount As Integer
    Private _campaignValue As Decimal
    Private _comment As String
    Private _createUser As User
    Private _createDate As DateTime

#End Region

#Region "Public member"

    Public Overridable Property Campaign() As Campaign
        Get
            Return _campaign
        End Get
        Set(ByVal value As Campaign)
            Assign("Campaing", value, _campaign)
        End Set
    End Property

    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            Assign("Patient", value, _patient)
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

#End Region

End Class
