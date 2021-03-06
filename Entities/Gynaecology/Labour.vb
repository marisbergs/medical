Imports Core.Bll

''' <summary>
''' Ikdienā lietojamie medikamenti
''' </summary>
Public Class Labour
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

#Region "Constructor"
    Protected Sub New()

    End Sub

    Public Sub New(ByVal session As Core.Dal.ISession)
        MyBase.New(session)
    End Sub
#End Region

#Region "Private members"
    Private _year As Nullable(Of Integer)
    Private _weight As Nullable(Of Integer)
    Private _sex As Sex
    Private _lactation As String
    Private _health As Health
    Private _healthNotes As TextContent
    Private _healthNow As Health
    Private _healthNowNotes As TextContent
    Private _gynaecology As Gynaecology
#End Region



    ''' <summary>
    ''' dzimšanas gads
    ''' </summary>
    Public Overridable Property Year() As Nullable(Of Integer)
        Get
            Return _year
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("Year", value, _year)
        End Set
    End Property

    ''' <summary>
    ''' Svars
    ''' </summary>
    Public Overridable Property Weight() As Nullable(Of Integer)
        Get
            Return _weight
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("Weight", value, _weight)
        End Set
    End Property

    ''' <summary>
    ''' Dzimums
    ''' </summary>
    Public Overridable Property Sex() As Sex
        Get
            Return _sex
        End Get
        Set(ByVal value As Sex)
            Assign("Sex", value, _sex)
        End Set
    End Property

    ''' <summary>
    ''' Laktācija
    ''' </summary>
    Public Overridable Property Lactation() As String
        Get
            Return _lactation
        End Get
        Set(ByVal value As String)
            Assign("Lactation", value, _lactation)
        End Set
    End Property


    ''' <summary>
    ''' veselības stāvoklis dzemdībās
    ''' </summary>
    Public Overridable Property Health() As Health
        Get
            Return _health
        End Get
        Set(ByVal value As Health)
            Assign("Health", value, _health)
        End Set
    End Property

    ''' <summary>
    ''' dzemdību apraksts
    ''' </summary>
    Public Overridable Property HealthNotes() As TextContent
        Get
            Return _healthNotes
        End Get
        Set(ByVal value As TextContent)
            Assign("HealthNotes", value, _healthNotes)
        End Set
    End Property

    ''' <summary>
    ''' Pāšreizējais veselības stāvoklis
    ''' </summary>
    Public Overridable Property HealthNow() As Health
        Get
            Return _healthNow
        End Get
        Set(ByVal value As Health)
            Assign("HealthNow", value, _healthNow)
        End Set
    End Property

    ''' <summary>
    ''' Pašreizējo slimību apraksts
    ''' </summary>
    Public Overridable Property HealthNowNotes() As TextContent
        Get
            Return _healthNowNotes
        End Get
        Set(ByVal value As TextContent)
            Assign("HealthNowNotes", value, _healthNowNotes)
        End Set
    End Property

    ''' <summary>
    ''' Ginekoloģijas karte
    ''' </summary>
    Public Overridable Property Gynaecology() As Gynaecology
        Get
            Return _gynaecology
        End Get
        Set(ByVal value As Gynaecology)
            Assign("Gynaecology", value, _gynaecology)
        End Set
    End Property

    Public Overridable Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.Gynaecology
        End Get
        Set(ByVal value As Object)
            Me.Gynaecology = CType(value, Gynaecology)
        End Set
    End Property

    ''' <summary>
    ''' Vai drīkst dzēst ierakstu
    ''' </summary>
    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            If Not Me.IsActive Then
                Return False
            End If
            Return True
        End Get
    End Property

    ''' <summary>
    ''' Vai drīkst labot ierakstu
    ''' </summary>
    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Return True
        End Get
    End Property
End Class
' Уныкоде