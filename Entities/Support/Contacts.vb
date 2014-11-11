Public Class Contacts
    Inherits Core.Bll.BusinessObjectBase(Of Guid)

    Private _name As String
    Private _address As String
    Private _code As String
    Private _phone As String
    Private _fax As String
    Private _mail As String
    Private _bank As String
    Private _swift As String
    Private _account As String

    ''' <summary>
    ''' Nosaukums
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
    ''' NMR kods
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
    ''' Fakss
    ''' </summary>
    Public Overridable Property Fax() As String
        Get
            Return _fax
        End Get
        Set(ByVal value As String)
            Assign("Fax", value, _fax)
        End Set
    End Property

    ''' <summary>
    ''' E-pasts
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
    ''' Banka
    ''' </summary>
    Public Overridable Property Bank() As String
        Get
            Return _bank
        End Get
        Set(ByVal value As String)
            Assign("Bank", value, _bank)
        End Set
    End Property

    ''' <summary>
    ''' Bankas kods
    ''' </summary>
    Public Overridable Property Swift() As String
        Get
            Return _swift
        End Get
        Set(ByVal value As String)
            Assign("Swift", value, _swift)
        End Set
    End Property

    ''' <summary>
    ''' Konta numurs
    ''' </summary>
    Public Overridable Property Account() As String
        Get
            Return _account
        End Get
        Set(ByVal value As String)
            Assign("Account", value, _account)
        End Set
    End Property
End Class
