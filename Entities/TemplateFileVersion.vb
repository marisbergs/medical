Imports Core.Dal
Imports Core.Bll

Public Class TemplateFileVersion
    Inherits BusinessObjectBase(Of Guid)
    Implements IHasParent

#Region "Private members"
    Private _template As Template
    Private _versionNumber As Integer
    Private _validFrom As Nullable(Of DateTime)
    Private _validUntil As Nullable(Of DateTime)
    Private _comment As String
    Private _file As BinaryFile
#End Region

    ''' <summary>
    ''' Veidlapa
    ''' </summary>
    Public Overridable Property Template() As Template
        Get
            Return _template
        End Get
        Set(ByVal value As Template)
            Assign("Template", value, _template)
        End Set
    End Property

    ''' <summary>
    ''' Parent
    ''' </summary>
    Public Overridable Property Parent() As Object Implements IHasParent.Parent
        Get
            Return Template
        End Get
        Set(ByVal value As Object)
            Template = CType(value, Template)
        End Set
    End Property

    Public Overridable ReadOnly Property VersionNumber() As Integer
        Get
            Return _versionNumber
        End Get
    End Property

    Public Overridable Property ValidFrom() As Nullable(Of DateTime)
        Get
            Return _validFrom
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("ValidFrom", value, _validFrom)
        End Set
    End Property

    Public Overridable Property ValidUntil() As Nullable(Of DateTime)
        Get
            Return _validUntil
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("ValidUntil", value, _validUntil)
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

    Public Overridable ReadOnly Property File() As BinaryFile
        Get
            Return _file
        End Get
    End Property

    Private Sub AddBusinessRules()
        Me.Validator.AddBusinessRule("File", AddressOf CommonBusinessRules.CheckRequired, "File")
        Me.Validator.AddBusinessRule("VersionNumber", AddressOf CommonBusinessRules.CheckRequired, "VersionNumber")
        Me.Validator.AddBusinessRule("ValidFrom", AddressOf CommonBusinessRules.CheckRequired, "ValidFrom")
        Me.Validator.AddBusinessRule("ValidUntil", AddressOf CommonBusinessRules.CheckDateInterval, "ValidFrom", "ValidUntil")
        Me.Validator.AddBusinessRule("ValidFrom", AddressOf CommonBusinessRules.CheckDateInterval, "ValidFrom", "ValidUntil")
    End Sub

    Protected Sub New()
        AddBusinessRules()
    End Sub


    Public Sub New(ByVal session As ISession)
        MyBase.New(Session)

        _validFrom = DateTime.Today
        _file = New BinaryFile(Session)
        _versionNumber = 1
        AddBusinessRules()
    End Sub

    Public Sub New(ByVal session As ISession, ByVal fileName As String, ByVal versionNumber As Integer)
        MyBase.New(session)

        _validFrom = DateTime.Today
        _file = New BinaryFile(session, fileName)
        _versionNumber = versionNumber

        AddBusinessRules()
    End Sub

End Class
' Уныкоде