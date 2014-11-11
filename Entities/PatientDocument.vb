Imports Core.Bll
Imports Core
Imports Core.Dal

Public Class PatientDocument
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent
#Region "Constructor"
    Protected Sub New()
        AddBusinessRules()
    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession) ', ByVal ParentID As Guid)
        MyBase.New(session)
        Files = New ChildCollection(Of AttachmentFile)
        Creator = Context.Current.AuthenticatedUser
        CreateDate = DateTime.Now.Date
        AddBusinessRules()
    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession, ByVal patientId As Guid) ', ByVal ParentID As Guid)
        MyBase.New(session)
        Files = New ChildCollection(Of AttachmentFile)
        Patient = session.Get(Of Patient)(patientId)
        Creator = Context.Current.AuthenticatedUser
        CreateDate = DateTime.Now.Date
        AddBusinessRules()
    End Sub
    Private Sub AddBusinessRules()
        Validator.AddBusinessRule("DocType", AddressOf CommonBusinessRules.CheckRequired, "DocType")
    End Sub
#End Region
#Region "private properties"
    Private _patient As Patient
    Private _docType As DocType
    Private _files As IChildCollection(Of AttachmentFile)
    Private _createDate As DateTime
    Private _creator As User
#End Region
#Region "Getters&setters"
    ''' <summary>
    ''' Dokuments - pārsûdzība
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
    ''' Parents
    ''' </summary>
    Public Overridable Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return Patient
        End Get
        Set(ByVal value As Object)
            Me.Patient = CType(value, Patient)
        End Set
    End Property

    ''' <summary>
    ''' dokumenta tips
    ''' </summary>
    Public Overridable Property DocType() As DocType
        Get
            Return _DocType
        End Get
        Set(ByVal value As DocType)
            Assign("DocType", value, _DocType)
        End Set
    End Property

    ''' <summary>
    ''' daokumenta fails
    ''' </summary>
    Public Overridable Property CreateDate() As DateTime
        Get
            Return _createDate
        End Get
        Set(ByVal value As DateTime)
            Assign("CreateDate", value, _createDate)
        End Set
    End Property

    ''' <summary>
    ''' daokumenta fails
    ''' </summary>
    Public Overridable Property Creator() As User
        Get
            Return _creator
        End Get
        Set(ByVal value As User)
            Assign("Creator", value, _creator)
        End Set
    End Property

    ''' <summary>
    ''' daokumenta fails
    ''' </summary>
    Public Overridable Property Files() As IChildCollection(Of AttachmentFile)
        Get
            Return _files
        End Get
        Set(ByVal value As IChildCollection(Of AttachmentFile))
            Assign("Files", value, _files)
        End Set
    End Property
#End Region
#Region "CanEdit&Delete"
    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Return Me.IsActive 'And Me.Document.CanEdit
        End Get
    End Property
    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Return Me.IsActive And Me.Patient.CanEdit
        End Get
    End Property
#End Region
End Class
