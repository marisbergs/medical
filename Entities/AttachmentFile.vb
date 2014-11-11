Imports Core.Bll

Public Class AttachmentFile
    Inherits Core.Bll.BusinessObjectBase(Of Guid)
    Implements Core.Dal.IHasParent
#Region "Constructor"
    Protected Sub New()
        AddBusinessRules()
    End Sub
    Public Sub New(ByVal session As Core.Dal.ISession) ', ByVal ParentID As Guid)
        MyBase.New(session)
        AddBusinessRules()
    End Sub
    Private Sub AddBusinessRules()
        Validator.AddBusinessRule("File", AddressOf CommonBusinessRules.CheckRequired, "File")
    End Sub
#End Region
#Region "private properties"
    Private _patientDocument As PatientDocument
    Private _file As BinaryFile
#End Region
#Region "Getters&setters"
    ''' <summary>
    ''' Dokuments - pārsûdzība
    ''' </summary>
    Public Overridable Property PatientDocument() As PatientDocument
        Get
            Return _patientDocument
        End Get
        Set(ByVal value As PatientDocument)
            Assign("PatientDocument", value, _patientDocument)
        End Set
    End Property
    ''' <summary>
    ''' Parents
    ''' </summary>
    Public Property Parent() As Object Implements Core.Dal.IHasParent.Parent
        Get
            Return PatientDocument
        End Get
        Set(ByVal value As Object)
            Me.PatientDocument = CType(value, PatientDocument)
        End Set
    End Property
    ''' <summary>
    ''' daokumenta fails
    ''' </summary>
    Public Overridable Property File() As BinaryFile
        Get
            Return _file
        End Get
        Set(ByVal value As BinaryFile)
            Assign("File", value, _file)
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
            Return Me.IsActive And Me.PatientDocument.CanEdit
        End Get
    End Property
#End Region
End Class
