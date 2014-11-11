Option Strict On

Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Entities

Public Class Licence
    Inherits BusinessObjectBase(Of Guid)

#Region "Constructor"
    Private Sub AddBusinessRules()
        Validator.AddBusinessRule("Issuer", AddressOf CommonBusinessRules.CheckConditionalRequired, "FromWhForVlidation", "Issuer")
        Validator.AddBusinessRule("Type", AddressOf CommonBusinessRules.CheckConditionalRequired, "FromWhForVlidation", "Type")
        Validator.AddBusinessRule("LicDate", AddressOf CommonBusinessRules.CheckConditionalRequired, "FromWhForVlidation", "LicDate")
        Validator.AddBusinessRule("Number", AddressOf CommonBusinessRules.CheckConditionalRequired, "FromWhForVlidation", "Number")
        Validator.AddBusinessRule("From", AddressOf CommonBusinessRules.CheckConditionalRequired, "FromWhForVlidation", "From")

        Validator.AddBusinessRule("LicDate", AddressOf CommonBusinessRules.CheckDateInterval, "LicDate", "From")
        Validator.AddBusinessRule("From", AddressOf CommonBusinessRules.CheckDateInterval, "LicDate", "From")

        Validator.AddBusinessRule("From", AddressOf CommonBusinessRules.CheckDateInterval, "From", "Until")
        Validator.AddBusinessRule("Until", AddressOf CommonBusinessRules.CheckDateInterval, "From", "Until")
       

        Validator.AddBusinessRule("LicDate", AddressOf CommonBusinessRules.CheckDateValue, "LicDate", Now(), "Grt")
    End Sub
    Protected Sub New()
        AddBusinessRules()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        AddBusinessRules()
    End Sub
#End Region

#Region "Private members"
    Private _issuer As String
    Private _type As String
    Private _licDate As Nullable(Of Date)
    Private _number As String
    Private _from As Nullable(Of Date)
    Private _until As Nullable(Of Date)
    Private _fromWh As Boolean
#End Region


    ''' <summary>
    ''' Izsniedzējs
    ''' </summary>
    Public Overridable Property Issuer() As String
        Get
            Return _issuer
        End Get
        Set(ByVal value As String)
            Assign("Issuer", value, _issuer)
        End Set
    End Property

    ''' <summary>
    ''' Veids
    ''' </summary>
    Public Overridable Property Type() As String
        Get
            Return _Type
        End Get
        Set(ByVal value As string)
            Assign("Type", value, _Type)
        End Set
    End Property

    ''' <summary>
    ''' Datums
    ''' </summary>
    Public Overridable Property LicDate() As Nullable(Of Date)
        Get
            Return _licDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("LicDate", value, _licDate)
        End Set
    End Property

    ''' <summary>
    ''' Numurs
    ''' </summary>
    Public Overridable Property Number() As String
        Get
            Return _number
        End Get
        Set(ByVal value As string)
            Assign("Number", value, _number)
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    Public Overridable Property From() As Nullable(Of Date)
        Get
            Return _from
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("From", value, _from)
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    Public Overridable Property Until() As Nullable(Of Date)
        Get
            Return _until
        End Get
        Set(ByVal value As Nullable(Of Date))
            Assign("Until", value, _until)
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    Public Overridable Property FromWh() As Boolean
        Get
            Return _fromWh
        End Get
        Set(ByVal value As Boolean )
            Assign("FromWh", value, _fromWh)
        End Set
    End Property

    Public Overridable ReadOnly Property FromWhForVlidation() As Boolean
        Get
            Return Not _fromWh
        End Get
    End Property

    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
        End Get
    End Property

    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Return CanEdit
        End Get
    End Property

End Class

' Lūdzu, Юникод

