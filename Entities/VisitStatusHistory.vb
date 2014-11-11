Imports Core
Imports Core.Bll
Imports Core.Dal


Public Class VisitStatusHistory
    Inherits BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent

    Private _visit As Visit
    Private _user As User
    Private _status As Statuss
    Private _changeDate As Nullable(Of DateTime)

    Protected Sub New()

    End Sub

    Public Sub New(ByVal status As Statuss)
        Me.Status = status
        Me.User = Context.Current.AuthenticatedUser
        ChangeDate = DateTime.Now
    End Sub

    ''' <summary>
    ''' Vizīte
    ''' </summary>
    Public Overridable Property Visit() As Visit
        Get
            Return _visit
        End Get
        Set(ByVal value As Visit)
            Assign("Visit", value, _visit)
        End Set
    End Property

    ''' <summary>
    ''' Lietotājs, kas veicis statusa maiņu
    ''' </summary>
    Public Overridable Property User() As User
        Get
            Return _user
        End Get
        Set(ByVal value As User)
            Assign("User", value, _user)
        End Set
    End Property

    ''' <summary>
    ''' status uz kuru veikta nomaiņa
    ''' </summary>
    Public Overridable Property Status() As Statuss
        Get
            Return _status
        End Get
        Set(ByVal value As Statuss)
            Assign("Status", value, _status)
        End Set
    End Property

    ''' <summary>
    ''' statusa maiņas laiks
    ''' </summary>
    Public Overridable Property ChangeDate() As Nullable(Of DateTime)
        Get
            Return _changeDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("ChangeDate", value, _changeDate)
        End Set
    End Property

    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Me.Visit
        End Get
        Set(ByVal value As Object)
            Me.Visit = CType(value, Visit)
        End Set
    End Property
End Class
