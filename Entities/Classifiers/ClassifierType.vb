Imports Core.Dal
Imports Core.Bll
Imports Core.UI

''' <summary>
''' Classifier of classifiers
''' </summary>
''' <remarks>
''' Provided together with the system, unchangeable, localizable.
''' Property "Value" contains corresponding class name
''' </remarks>
Public Class ClassifierType
    Inherits Core.Bll.DictionaryBase(Of String)

#Region "Private members"
    Private _kind As ClassifierKind
    Private _browseFormName As String
    Private _valuePrompt As String
    Private _codePrompt As String
    Private _memoPrompt As String
    Private _numberPrompt As String
    Private _decimalPlace As String
    Private _markPrompt As String
    Private _integerPrompt As String
    Private _secondIntegerPrompt As String
    Private _thirdIntegerPrompt As String
    Private _fourIntegerPrompt As String
    Private _secondMarkPrompt As String
    Private _commentPrompt As String
    Private _lookup As ClassifierType
    Private _reference As ClassifierType
    Private _referenceSecond As ClassifierType
    Private _referenceFourth As ClassifierType
    Private _referenceThird As ClassifierType
    Private _referenceFive As ClassifierType
    Private _referenceSix As ClassifierType
    Private Shared _ctCache As Dictionary(Of Type, ClassifierType) = New Dictionary(Of Type, ClassifierType)
    Private _materialCostPrompt As String
    Private _colorPrompt As String

#End Region

    Public Overridable ReadOnly Property Kind() As ClassifierKind
        Get
            Return _kind
        End Get
    End Property

    Public Overridable ReadOnly Property BrowseFormName() As String
        Get
            Return _browseFormName
        End Get
    End Property

    Public Overridable ReadOnly Property ValuePrompt() As String
        Get
            Return _valuePrompt
        End Get
    End Property

    Public Overridable ReadOnly Property CodePrompt() As String
        Get
            Return _codePrompt
        End Get
    End Property

    Public Overridable ReadOnly Property MemoPrompt() As String
        Get
            Return _memoPrompt
        End Get
    End Property

    Public Overridable ReadOnly Property IntegerPrompt() As String
        Get
            Return _integerPrompt
        End Get
    End Property

    Public Overridable ReadOnly Property SecondIntegerPrompt() As String
        Get
            Return _secondIntegerPrompt
        End Get
    End Property
    Public Overridable ReadOnly Property DecimalPlace() As String
        Get
            Return _decimalPlace
        End Get
    End Property

    Public Overridable ReadOnly Property ThirdIntegerPrompt() As String
        Get
            Return _thirdIntegerPrompt
        End Get
    End Property

    Public Overridable ReadOnly Property FourIntegerPrompt() As String
        Get
            Return _fourIntegerPrompt
        End Get
    End Property

    Public Overridable ReadOnly Property MaterialCostPrompt() As String
        Get
            Return _materialCostPrompt
        End Get
    End Property

    Public Overridable ReadOnly Property ColorPrompt() As String
        Get
            Return _colorPrompt
        End Get
    End Property


    ''' <summary>
    ''' Rādīt komentārus
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Property CommentPrompt() As String
        Get
            Return _commentPrompt
        End Get
        Set(ByVal value As String)
            Assign("CommentPrompt", value, _commentPrompt)
        End Set
    End Property

    Public Overridable ReadOnly Property NumberPrompt() As String
        Get
            Return _numberPrompt
        End Get
    End Property

    Public Overridable ReadOnly Property MarkPrompt() As String
        Get
            Return _markPrompt
        End Get
    End Property

    Public Overridable ReadOnly Property SecondMarkPrompt() As String
        Get
            Return _secondMarkPrompt
        End Get
    End Property

    Public Overridable ReadOnly Property Lookup() As ClassifierType
        Get
            Return _lookup
        End Get
    End Property

    Public Overridable ReadOnly Property Reference() As ClassifierType
        Get
            Return _reference
        End Get
    End Property

    Public Overridable ReadOnly Property ReferenceSecond() As ClassifierType
        Get
            Return _referenceSecond
        End Get
    End Property

    Public Overridable ReadOnly Property ReferenceThird() As ClassifierType
        Get
            Return _referenceThird
        End Get
    End Property

    Public Overridable ReadOnly Property ReferenceFourth() As ClassifierType
        Get
            Return _referenceFourth
        End Get
    End Property

    Public Overridable ReadOnly Property ReferenceFive() As ClassifierType
        Get
            Return _referenceFive
        End Get
    End Property

    Public Overridable ReadOnly Property ReferenceSix() As ClassifierType
        Get
            Return _referenceSix
        End Get
    End Property

    Public Overridable ReadOnly Property TypeObject() As Type
        Get
            Return Type.GetType("Entities." + Me.Id + ", Entities")
        End Get
    End Property

    Public Shared Function FromType(ByVal tp As Type, ByVal session As Core.Dal.ISession) As ClassifierType
        If Not _ctCache.ContainsKey(tp) Then
            _ctCache.Add(tp, session.Get(Of ClassifierType)(tp.Name))
        End If
        Return _ctCache(tp)
    End Function

    Public Overridable ReadOnly Property ObjectName() As String
        Get
            Return Core.Localization.Instance(CType(Me.Id, String))
        End Get
    End Property

    Public Overridable ReadOnly Property NewInstance() As Object
        Get
            Return Activator.CreateInstance(TypeObject)
        End Get
    End Property

    Public Overridable ReadOnly Property NewFormInstance(ByVal session As ISession, ByVal formMode As ClassifierListMode) As Core.UI.ISelectionForm
        Get
            Dim t As Type = Type.GetType("Client." + Me.BrowseFormName + ", Client")
            Return CType(Activator.CreateInstance(t, Me, session, formMode), Core.UI.ISelectionForm)
        End Get
    End Property

End Class
' Уныкоде