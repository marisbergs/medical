Imports Core.Dal
Imports Entities

Public Class ClassifierFind
    Inherits Core.Bll.BusinessObjectBase(Of Integer)
    Implements Core.Bll.ISearchObject

    Private _useCode As Boolean
    Private _useName As Boolean
    Private _useValidAt As Boolean
    Private _useActive As Boolean
    Private _useIsGroupWork As Boolean
    Private _code As String
    Private _name As String
    Private _validAt As Date
    Private _parent As Classifier
    Private _useInClassifier As Boolean
    Private _useInList As Boolean
    Private _useNotInClassifier As Boolean
    Private _useIsParent As Boolean
    Private _classifier As IList(Of Guid)
    Private _classifiersId As IList(Of Guid)
    Private _useMark As Boolean
    Private _useNotMark As Boolean

    Public Overridable Property UseCode() As Boolean
        Get
            Return _useCode
        End Get
        Set(ByVal value As Boolean)
            Me.Assign("UseCode", value, _useCode)
        End Set
    End Property

    Public Overridable Property UseName() As Boolean
        Get
            Return _useName
        End Get
        Set(ByVal value As Boolean)
            Me.Assign("UseName", value, _useName)
        End Set
    End Property

    Public Overridable Property UseValidAt() As Boolean
        Get
            Return _useValidAt
        End Get
        Set(ByVal value As Boolean)
            Me.Assign("UseValidAt", value, _useValidAt)
        End Set
    End Property

    Public Overridable Property UseIsGroupWork() As Boolean
        Get
            Return _useIsGroupWork
        End Get
        Set(ByVal value As Boolean)
            Me.Assign("UseIsGroupWork", value, _useIsGroupWork)
        End Set
    End Property

    Public Overridable Property UseActive() As Boolean
        Get
            Return _useActive
        End Get
        Set(ByVal value As Boolean)
            Me.Assign("UseActive", value, _useActive)
        End Set
    End Property

    Public Overridable Property UseMark() As Boolean
        Get
            Return _useMark
        End Get
        Set(ByVal value As Boolean)
            Me.Assign("UseMark", value, _useMark)
        End Set
    End Property

    Public Overridable Property UseNotMark() As Boolean
        Get
            Return _useNotMark
        End Get
        Set(ByVal value As Boolean)
            Me.Assign("UseNotMark", value, _useNotMark)
        End Set
    End Property

    ''' <summary>
    ''' vai iekļaut atlasē: tēmas 
    ''' </summary>
    Public Overridable Property UseInClassifier() As Boolean
        Get
            Return _useInClassifier
        End Get
        Set(ByVal value As Boolean)
            Assign("UseInClassifier", value, _useInClassifier)
        End Set
    End Property

    ''' <summary>
    ''' vai iekļaut atlasē: tēmas 
    ''' </summary>
    Public Overridable Property UseInList() As Boolean
        Get
            Return _useInList
        End Get
        Set(ByVal value As Boolean)
            Assign("UseInList", value, _useInList)
        End Set
    End Property


    ''' <summary>
    ''' vai iekļaut atlasē: tēmas 
    ''' </summary>
    Public Overridable Property UseIsParent() As Boolean
        Get
            Return _useIsParent
        End Get
        Set(ByVal value As Boolean)
            Assign("UseIsParent", value, _useIsParent)
        End Set
    End Property

    ''' <summary>
    ''' vai neiekļaut lietotājus atlasē
    ''' </summary>
    Public Overridable Property UseNotInClassifier() As Boolean
        Get
            Return _useNotInClassifier
        End Get
        Set(ByVal value As Boolean)
            Assign("UseNotInClassifier", value, _useNotInClassifier)
        End Set
    End Property

    ''' <summary>
    ''' Atlasē neiekļautie lietotāji; ieļautās tēmas
    ''' </summary>
    Public Overridable Property Classifier() As IList(Of Guid)
        Get
            Return _classifier
        End Get
        Set(ByVal value As IList(Of Guid))
            If _classifier Is Nothing Then _classifier = New List(Of Guid)
            Assign("Classifier", value, _classifier)
        End Set
    End Property

    ''' <summary>
    ''' Atlasē neiekļautie lietotāji; ieļautās tēmas
    ''' </summary>
    Public Overridable Property ClassifiersId() As IList(Of Guid)
        Get
            Return _classifiersId
        End Get
        Set(ByVal value As IList(Of Guid))
            If _classifiersId Is Nothing Then _classifiersId = New List(Of Guid)
            Assign("ClassifiersId", value, _classifiersId)
        End Set
    End Property

    Public Overridable Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            Assign("Code", value, _code)
        End Set
    End Property

    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            Assign("Name", value, _name)
        End Set
    End Property

    Public Overridable Property ValidAt() As Date
        Get
            Return _validAt
        End Get
        Set(ByVal value As Date)
            Assign("ValidAt", value, _validAt)
        End Set
    End Property

    Public Overridable Property Parent() As Classifier
        Get
            Return _parent
        End Get
        Set(ByVal value As Classifier)
            Me.Assign("Parent", value, _parent)
        End Set
    End Property

    Public Sub New(ByVal session As Core.Dal.ISession)
        ResetValues(session)
        Validator.AddBusinessRule("Code", AddressOf Core.Bll.CommonBusinessRules.CheckConditionalRequired, "UseCode", "Code")
        Validator.AddBusinessRule("Name", AddressOf Core.Bll.CommonBusinessRules.CheckConditionalRequired, "UseName", "Name")
    End Sub

    Private _excludeComputersInUse As Boolean = False
    ''' <summary>
    ''' Special property for computer lists
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Property ExcludeComputersInUse() As Boolean
        Get
            Return _excludeComputersInUse
        End Get
        Set(ByVal value As Boolean)
            _excludeComputersInUse = value
        End Set
    End Property

#Region "ISearchObject"
    Public Sub ResetValues(ByVal session As Core.Dal.ISession) Implements Core.Bll.ISearchObject.ResetValues
        UseCode = False
        Code = ""
        UseName = False
        Name = ""
        UseValidAt = True
        ValidAt = DateTime.Today
        UseActive = True
    End Sub

    Public Function BuildCriteria() As IList(Of Core.Dal.Expressions.CriterionBase) Implements Core.Bll.ISearchObject.BuildCriteria
        Dim result As New List(Of Expressions.CriterionBase)
        If UseActive Then result.Add(New Expressions.IsNull("DeleteTime"))
        If UseMark Then result.Add(New Expressions.Eq("Mark", True))
        If UseNotMark Then result.Add(New Expressions.Eq("Mark", False))
        If UseCode Then result.Add(CriteriaBuilder.MultiValueLike("Code", Code))
        If UseName Then result.Add(CriteriaBuilder.MultiValueLike("Value", Name))
        If UseNotInClassifier Then result.Add(CriteriaBuilder.IsNotInCollection("Id", Me.Classifier))
        If UseInClassifier Then result.Add(CriteriaBuilder.IsInCollection("Id", Me.Classifier))
        If UseInList Then result.Add(CriteriaBuilder.IsInCollection("Id", Me.ClassifiersId))
        If UseIsParent Then result.Add(CriteriaBuilder.IsInCollection("Parent.Id", Me.Classifier))
        If UseValidAt Then result.Add(CriteriaBuilder.FullIntervalCoversValue("ValidFrom", "ValidUntil", ValidAt.Date))
        If ExcludeComputersInUse Then result.Add(New Expressions.Sql("NOT EXISTS(SELECT * FROM _SynchroData sd WHERE sd.SYD_WORKSTATION_ID = {alias}.CLS_ID)"))
        If UseIsGroupWork Then result.Add(New Expressions.Eq("ReferenceSecond.Mark", True))
        If Not Parent Is Nothing Then
            result.Add(New Expressions.Eq("Parent", Parent))
        End If
        Return result
    End Function

#End Region

End Class
