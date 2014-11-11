Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class Guardian
    Inherits BusinessObjectBase(Of Guid)

#Region "Private members"
    Private _patient As Patient
    Private _name As String
    Private _surname As String
    Private _code As String
    Private _address As String
    Private _mobilePhone As String
    Private _mail As String
    Private _type As GuardianType
#End Region

    ''' <summary>
    ''' Klients
    ''' </summary>
    Public Overridable Property Patient() As Patient
        Get
            Return _patient
        End Get
        Set(ByVal value As Patient)
            Assign("Patient", value, _patient)
        End Set
    End Property

    ''' <summary>
    ''' Vārds
    ''' </summary>
    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            Assign("Name", value, _name)
        End Set
    End Property

    ''' <summary>
    ''' Uzvārds
    ''' </summary>
    Public Overridable Property Surname() As String
        Get
            Return _surname
        End Get
        Set(ByVal value As String)
            Assign("Surname", value, _surname)
        End Set
    End Property

    ''' <summary>
    ''' personas kods
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
    ''' Adrese
    ''' </summary>
    Public Overridable Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            Assign("Address", value, _address)
        End Set
    End Property

    ''' <summary>
    ''' Mobilais telefons
    ''' </summary>
    Public Overridable Property MobilePhone() As String
        Get
            Return _mobilePhone
        End Get
        Set(ByVal value As String)
            Assign("MobilePhone", value, _mobilePhone)
        End Set
    End Property

    ''' <summary>
    ''' e-pasts
    ''' </summary>
    Public Overridable Property Mail() As String
        Get
            Return _mail
        End Get
        Set(ByVal value As String)
            Assign("Mail", value, _mail)
        End Set
    End Property

    ''' <summary>
    ''' Aizbilldnis
    ''' </summary>
    Public Overridable Property Type() As GuardianType
        Get
            Return _type
        End Get
        Set(ByVal value As GuardianType)
            Assign("Type", value, _type)
        End Set
    End Property

End Class
