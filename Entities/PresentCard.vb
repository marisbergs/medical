Imports Core
Imports Core.Bll
Imports Core.Dal

Public Class PresentCard
    Inherits BusinessObjectBase(Of Guid)

    Public Sub New(ByVal session As ISession)
        MyBase.New(session)
        PayDate = Now.Date
        Status = PresentCardState.Izveidota
        AddBusinessRoles()
    End Sub
    Public Sub New()

    End Sub

    Private Sub AddBusinessRoles()
        Validator.AddBusinessRule("Service", AddressOf CommonBusinessRules.CheckRequired, "Service")
        Validator.AddBusinessRule("Number", AddressOf CommonBusinessRules.CheckRequired, "Number")
        Validator.AddBusinessRule("PayDate", AddressOf CommonBusinessRules.CheckRequired, "PayDate")
    End Sub

#Region "Private members"
    Private _payDate As DateTime
    Private _validTo As Nullable(Of DateTime)
    Private _number As String
    Private _status As PresentCardState
    Private _service As Services
    Private _price As Decimal
    Private _visitServices As IChildCollection(Of VisitService)
    Private _note As String
    Private _summLeft As Decimal
#End Region

#Region "Public member"


    Public Overridable Property PayDate() As Date
        Get
            Return _payDate
        End Get
        Set(ByVal value As Date)
            Assign("PayDate", value, _payDate)
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

    Public Overridable Property Number() As String
        Get
            Return _number
        End Get
        Set(ByVal value As String)
            Assign("Number", value, _number)
        End Set
    End Property

    Public Overridable Property Status() As PresentCardState
        Get
            Return _status
        End Get
        Set(ByVal value As PresentCardState)
            Assign("Status", value, _status)
        End Set
    End Property

    Public Overridable Property Service() As Services
        Get
            Return _service
        End Get
        Set(ByVal value As Services)
            Assign("Service", value, _service)
        End Set
    End Property

    Public Overridable Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(ByVal value As Decimal)
            Assign("Price", value, _price)
        End Set
    End Property

    Public Overridable Property Note() As String
        Get
            Return _note
        End Get
        Set(ByVal value As String)
            Assign("Note", value, _note)
        End Set
    End Property

    Public Overridable Property SummLeft() As Decimal
        Get
            Return _summLeft
        End Get
        Set(ByVal value As Decimal)
            Assign("SummLeft", value, _summLeft)
        End Set
    End Property

    Public Overridable ReadOnly Property ServiceCode() As String
        Get
            If Service Is Nothing Then
                Return ""
            End If
            Return Service.Code
        End Get
    End Property

    ReadOnly Overrides Public Property CanEdit() As Boolean
        Get
            If IsActive = False OrElse Not Status = PresentCardState.Izveidota Then
                Return False
            Else
                Return True
            End If
        End Get
    End Property

    Public Overridable Property VisitServices() As IChildCollection(Of VisitService)
        Get
            Return _visitServices
        End Get
        Set(ByVal value As IChildCollection(Of VisitService))
            Assign("VisitServices", value, _visitServices)
        End Set
    End Property

#End Region

End Class
