Imports Core.Bll
Imports Core.Dal
Imports Entities

''' <summary>
''' NM amatpersona (pārstāvis)
''' </summary>
Public Class TaxpayerMember
    Inherits BusinessObjectBase(Of Guid)

#Region "Private members"
    Private _code As String
    Private _name As String
    Private _position As String
    Private _codeWh As Boolean
    Private _nameWh As Boolean
    Private _positionWh As Boolean
    Private _documentPresented As PresentedDocument
    Private _notes As String
#End Region

#Region "Constructor"
    Private Sub AddBusinessRules()
        Validator.AddBusinessRule("Code", AddressOf CommonBusinessRules.CheckRequired, "Code")
        Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckRequired, "Name")
        Validator.AddBusinessRule("Position", AddressOf CommonBusinessRules.CheckConditionalRequired, "PositionValidation", "Position")
        Validator.AddBusinessRule("DocumentPresented", AddressOf CommonBusinessRules.CheckConditionalRequired, "DocumentPresentedValidation", "DocumentPresented")
        'TF bug: 2623
        'Validator.AddBusinessRule("Code", AddressOf CommonBusinessRules.CheckMinLength, "Code", 11)
    End Sub

    Protected Sub New()
        AddBusinessRules()
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        AddBusinessRules()
    End Sub
#End Region

    ''' <summary>
    ''' Personas kods
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
    ''' Vārds, uzvārds
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
    ''' Amats
    ''' </summary>
    Public Overridable Property Position() As String
        Get
            Return _position
        End Get
        Set(ByVal value As String)
            Assign("Position", value, _position)
        End Set
    End Property

    ''' <summary>
    ''' Peronas kods no DNS
    ''' </summary>
    Public Overridable Property CodeWh() As Boolean
        Get
            Return _codeWh
        End Get
        Set(ByVal value As Boolean)
            Assign("CodeWh", value, _codeWh)
        End Set
    End Property

    ''' <summary>
    ''' Vārds, uzvārds no DNS
    ''' </summary>
    Public Overridable Property NameWh() As Boolean
        Get
            Return _nameWh
        End Get
        Set(ByVal value As Boolean)
            Assign("NameWh", value, _nameWh)
        End Set
    End Property

    ''' <summary>
    ''' Amats no DNS
    ''' </summary>
    Public Overridable Property PositionWh() As Boolean
        Get
            Return _positionWh
        End Get
        Set(ByVal value As Boolean)
            Assign("PositionWh", value, _positionWh)
        End Set
    End Property

    ''' <summary>
    ''' Uzrādīja
    ''' </summary>
    Public Overridable Property DocumentPresented() As PresentedDocument
        Get
            Return _documentPresented
        End Get
        Set(ByVal value As PresentedDocument)
            Assign("DocumentPresented", value, _documentPresented)
        End Set
    End Property

    ''' <summary>
    ''' Konstatēts
    ''' </summary>
    Public Overridable Property Notes() As String
        Get
            Return _notes
        End Get
        Set(ByVal value As String)
            Assign("Notes", value, _notes)
        End Set
    End Property

    ''' <summary>
    ''' Uzrādīja (for report)
    ''' </summary>
    Public Overridable ReadOnly Property DocumentPresentedForReport() As String
        Get
            If Not Me.DocumentPresented Is Nothing Then
                If Me.DocumentPresented = PresentedDocument.OtherAccuse Then
                    If Not String.IsNullOrEmpty(Me.Notes) Then
                        Return Me.Notes
                    Else
                        Return ""
                    End If
                Else
                    If Not String.IsNullOrEmpty(Me.Notes) Then
                        Return Me.DocumentPresented.ToString & " " & Me.Notes
                    Else
                        Return Me.DocumentPresented.ToString
                    End If
                End If
            Else
                Return Nothing
            End If
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
