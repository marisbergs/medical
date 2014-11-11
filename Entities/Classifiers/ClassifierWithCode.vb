Imports Core.Bll

''' <summary>
''' Bāzes klase visiem klasifikatoriem ar kodu
''' </summary>
''' <remarks></remarks>
Public Class ClassifierWithCode
    Inherits Classifier

    Private _code As String
    Private _parent As Classifier

    Public Sub New()
        'Validator.AddBusinessRule("Code", AddressOf CommonBusinessRules.CheckRequired, "Code")
        Validator.AddBusinessRule("Code", AddressOf CommonBusinessRules.CheckConditionalRequired, "CodeRequired", "Code")
        Validator.AddBusinessRule("Code", AddressOf CommonBusinessRules.CheckMaxLength, "Code", 50)
    End Sub

    Public Overridable Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            Assign("Code", value, _code)
        End Set
    End Property

    Public Overridable Property Parent() As Classifier
        Get
            Return _parent
        End Get
        Set(ByVal value As Classifier)
            Assign("Parent", value, _parent)
        End Set
    End Property

    Public Shared Function GetByCode(Of T As ClassifierWithCode)(ByVal code As String, ByVal session As Core.Dal.ISession) As T
        Dim list As IList(Of T)
        Dim criteria As IList(Of Core.Dal.Expressions.CriterionBase) = New List(Of Core.Dal.Expressions.CriterionBase)
        criteria.Add(New Core.Dal.Expressions.Eq("Code", code))
        criteria.Add(New Core.Dal.Expressions.IsNull("DeleteTime"))
        list = session.CreateAndBuildCriteria(Of T)(criteria).List(Of T)()
        If list.Count > 0 Then
            Return list(0)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Priekš validācijas -> CheckConditionalRequired 
    ''' </summary>
    Public Overridable ReadOnly Property CodeRequired() As Boolean
        Get
            Return Not (ClassifierType.FromType(Me.GetType, GetSession()).CodePrompt = Nothing) And Not (ClassifierType.FromType(Me.GetType, GetSession()).Kind.Value = ClassifierKindEnum.Internal)
        End Get
    End Property
End Class

Public Class ExternalOrganization : Inherits ClassifierWithCode : End Class

Public Class Nace
    Inherits ClassifierWithCode

    Public Overrides Function ToString() As String
        If Not Me.ReturnStringValue Then
            Return Me.Code
        Else
            Return Me.Code & " " & Me.Value
        End If
    End Function

End Class

''' <summary>
''' Kredītiestāžu klasifikators
''' </summary>
''' <remarks></remarks>
Public Class CreditInstitution : Inherits ClassifierWithCode : End Class

''' <summary>
''' īpašo pazīmju klasifikators
''' </summary>
''' <remarks></remarks>
Public Class SpecialMark : Inherits ClassifierWithCode : End Class

''' <summary>
''' NIS izziņas pārkāpums
''' </summary>
''' <remarks></remarks>
Public Class ExtViolation
    Inherits ClassifierWithCode

    Public Overrides Function ToString() As String
        If ReturnStringValue Then
            If Code = Nothing Then
                Return ""
            End If
            Return Code.ToString()
        Else
            If Value = Nothing Then
                Return ""
            End If
            Return Value.ToString()
        End If
    End Function

End Class

''' <summary>
''' Raksturojumu atcelšanas iemesli
''' </summary>
Public Class CharacterRejectReason : Inherits ClassifierWithCode : End Class

''' <summary>
''' Pārbaudes veikšanas vietas
''' </summary>
Public Class InspectionPlace : Inherits ClassifierWithCode : End Class

''' <summary>
''' NTP (neplānotu tematisko pārbaužu) iemeslu klasifikators
''' </summary>
''' <remarks></remarks>
Public Class NtiReason : Inherits ClassifierWithCode : End Class

''' <summary>
''' PTP (plānotu tematisko pārbaužu) iemeslu klasifikators
''' </summary>
''' <remarks></remarks>
Public Class PtiReason : Inherits ClassifierWithCode : End Class


''' <summary>
''' Darbības veidi pēc TP
''' </summary>
Public Class AfterAction : Inherits ClassifierWithCode : End Class

''' <summary> VID konti</summary>
Public Class SrsAccount
    Inherits ClassifierWithCode
    Public Overrides Function ToString() As String
        Return Code.ToString
    End Function

    Public Overrides ReadOnly Property NotName() As Boolean
        Get
            Return True
        End Get
    End Property
End Class

' Уныкоде
