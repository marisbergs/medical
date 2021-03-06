Imports Core.Bll
Imports System.Drawing
Imports Core.Dal

Public Class Classifier
    Inherits DictionaryBase(Of Guid)


    Protected _validFrom As Nullable(Of DateTime)
    Protected _validUntil As Nullable(Of DateTime)
    Protected _text As String
    Protected _decimalValue As Double
    Protected _externalID As Nullable(Of Integer)
    Protected _type As ClassifierType
    Protected _mark As Boolean
    Protected _secondMark As Boolean
    Public Shared CanEditOnlyNotes As Boolean
    Private _returnStringValue As Boolean
    Private _notName As Boolean
    Private _nText As TextContent
    Private _comment As String
    Private _code As String
    Private _parent As Classifier
    Protected _integerValue As Nullable(Of Integer)
    Private _secondIntegerValue As Nullable(Of Integer)
    Private _thirdIntegerValue As Nullable(Of Integer)
    Private _fourIntegerValue As Nullable(Of Integer)
    Private _reference As Classifier
    Private _referenceSecond As Classifier
    Private _referenceThird As Classifier
    Private _referenceFourth As Classifier
    Private _referenceFive As Classifier
    Private _referenceSix As Classifier
    Private _color As String
    Private _canNotDelete As Boolean
    Private _materialCost As Nullable(Of Decimal)
    Private _valueRUS As String
    Private _valueENG As String

    Public Sub New()
        Validator.AddBusinessRule("Value", AddressOf CommonBusinessRules.CheckConditionalRequiredFromNot, "NotName", "Value")
        Validator.AddBusinessRule("Value", AddressOf CommonBusinessRules.CheckMaxLength, "Value", 500)
        'Validator.AddBusinessRule("ValidFrom", AddressOf CommonBusinessRules.CheckRequired, "ValidFrom")
        Validator.AddBusinessRule("ValidFrom", AddressOf CommonBusinessRules.CheckDateInterval, "ValidFrom", "ValidUntil")
        Validator.AddBusinessRule("ValidUntil", AddressOf CommonBusinessRules.CheckDateInterval, "ValidFrom", "ValidUntil")
        ValidFrom = DateTime.Today()
    End Sub

    Public Overridable Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            Assign("Code", value, _code)
        End Set
    End Property

    Public Overridable Property ValueRUS() As String
        Get
            Return _valueRUS
        End Get
        Set(ByVal value As String)
            Assign("ValueRUS", value, _valueRUS)
        End Set
    End Property

    Public Overridable Property ValueENG() As String
        Get
            Return _valueENG
        End Get
        Set(ByVal value As String)
            Assign("ValueENG", value, _valueENG)
        End Set
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

    Public Overridable Property Text() As String
        Get
            Return _text
        End Get
        Set(ByVal value As String)
            Assign("Text", value, _text)
        End Set
    End Property

    Public Overridable Property ColorinBing() As System.Drawing.Color
        Get
            If Color Is Nothing Then
                Return New Color()
            End If
            Return ColorTranslator.FromHtml(Color)
        End Get
        Set(ByVal value As System.Drawing.Color)
            Color = ColorTranslator.ToHtml(value)
        End Set
    End Property


    Public Overridable Property Color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            Assign("Color", value, _color)
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

    Public Overridable Property NText() As TextContent
        Get
            Return _nText
        End Get
        Set(ByVal value As TextContent)
            Assign("NText", value, _nText)
        End Set
    End Property

    Public Overridable Property DecimalValue() As Double
        Get
            Return _decimalValue
        End Get
        Set(ByVal value As Double)
            Assign("DecimalValue", value, _decimalValue)
        End Set
    End Property

    Public Overridable Property MaterialCost() As Nullable(Of Decimal)
        Get
            Return _materialCost
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Assign("MaterialCost", value, _materialCost)
        End Set
    End Property

    Public Overridable Property IntegerValue() As Nullable(Of Integer)
        Get
            Return _integerValue
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("IntegerValue", value, _integerValue)
        End Set
    End Property

    Public Overridable Property SecondIntegerValue() As Nullable(Of Integer)
        Get
            Return _secondIntegerValue
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("SecondIntegerValue", value, _secondIntegerValue)
        End Set
    End Property

    Public Overridable Property ThirdIntegerValue() As Nullable(Of Integer)
        Get
            Return _thirdIntegerValue
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("ThirdIntegerValue", value, _thirdIntegerValue)
        End Set
    End Property

    Public Overridable Property FourIntegerValue() As Nullable(Of Integer)
        Get
            Return _fourIntegerValue
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("FourIntegerValue", value, _fourIntegerValue)
        End Set
    End Property

    ''' <summary>
    ''' Pazīme
    ''' </summary>
    Public Overridable Property Mark() As Boolean
        Get
            Return _mark
        End Get
        Set(ByVal value As Boolean)
            Assign("Mark", value, _mark)
        End Set
    End Property

    ''' <summary>
    ''' otra pazīme Pazīme
    ''' </summary>
    Public Overridable Property SecondMark() As Boolean
        Get
            Return _secondMark
        End Get
        Set(ByVal value As Boolean)
            Assign("SecondMark", value, _secondMark)
        End Set
    End Property

    ''' <summary>
    ''' Ārējais ID
    ''' </summary>
    Public Overridable Property ExternalID() As Nullable(Of Integer)
        Get
            Return _externalID
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("ExternalID", value, _externalID)
        End Set
    End Property

    ''' <summary>
    ''' Saistītais klasifikators
    ''' </summary>
    Public Overridable Property Parent() As Classifier
        Get
            Return _parent
        End Get
        Set(ByVal value As Classifier)
            Assign("Parent", value, _parent)
        End Set
    End Property

    ''' <summary>
    ''' Saistītais klasifikators
    ''' </summary>
    Public Overridable Property Reference() As Classifier
        Get
            Return _reference
        End Get
        Set(ByVal value As Classifier)
            Assign("Reference", value, _reference)
        End Set
    End Property

    ''' <summary>
    ''' Saistītais klasifikators 2
    ''' </summary>
    Public Overridable Property ReferenceSecond() As Classifier
        Get
            Return _referenceSecond
        End Get
        Set(ByVal value As Classifier)
            Assign("ReferenceSecond", value, _referenceSecond)
        End Set
    End Property

    ''' <summary>
    ''' Saistītais klasifikators 3
    ''' </summary>
    Public Overridable Property ReferenceThird() As Classifier
        Get
            Return _referenceThird
        End Get
        Set(ByVal value As Classifier)
            Assign("ReferenceThird", value, _referenceThird)
        End Set
    End Property

    ''' <summary>
    ''' Saistītais klasifikators 4
    ''' </summary>
    Public Overridable Property ReferenceFourth() As Classifier
        Get
            Return _referenceFourth
        End Get
        Set(ByVal value As Classifier)
            Assign("ReferenceFourth", value, _referenceFourth)
        End Set
    End Property

    ''' <summary>
    ''' Saistītais klasifikators 5
    ''' </summary>
    Public Overridable Property ReferenceFive() As Classifier
        Get
            Return _referenceFive
        End Get
        Set(ByVal value As Classifier)
            Assign("ReferenceFive", value, _referenceFive)
        End Set
    End Property


    ''' <summary>
    ''' Saistītais klasifikators 5
    ''' </summary>
    Public Overridable Property ReferenceSix() As Classifier
        Get
            Return _referenceSix
        End Get
        Set(ByVal value As Classifier)
            Assign("ReferenceSix", value, _referenceSix)
        End Set
    End Property

    ''' <summary>
    ''' Klasifikatora tips
    ''' </summary>
    Public Overridable ReadOnly Property Type() As ClassifierType
        Get
            Return _type
        End Get
    End Property

    Public Overridable Property ReturnStringValue() As Boolean
        Get
            Return _returnStringValue
        End Get
        Set(ByVal value As Boolean)
            Assign("ReturnStringValue", value, _returnStringValue)
        End Set
    End Property

    ''' <summary>
    ''' Klasifikatoru nedrīkst dzēst
    ''' </summary>
    Public Overridable Property CanNotDelete() As Boolean
        Get
            Return _canNotDelete
        End Get
        Set(ByVal value As Boolean)
            Assign("CanNotDelete", value, _canNotDelete)
        End Set
    End Property

    ''' <summary>
    ''' Lai obligāta ieraksta zīme netiktu attēlota laukā, kur ieraksts var arī nebūt
    ''' </summary>
    Public Overridable ReadOnly Property NotName() As Boolean
        Get
            Return False
        End Get
    End Property
    ''' <summary>
    ''' Lai obligāta ieraksta zīme netiktu attēlota laukā, kur ieraksts var arī nebūt
    ''' </summary>
    Public Overridable ReadOnly Property DisplayValue() As String
        Get
            Return ToString()
        End Get
    End Property

    Public Overrides Function ToString() As String
        If Context.Current.AuthenticatedUser.InterfaceLanguage = "RUS" Then
            If Not String.IsNullOrEmpty(ValueRUS) Then
                Return ValueRUS
            End If
        ElseIf Context.Current.AuthenticatedUser.InterfaceLanguage = "ENG" Then
            If Not String.IsNullOrEmpty(ValueENG) Then
                Return ValueENG
            End If
        End If
        If (String.IsNullOrEmpty(Value)) Then
            Return ""
        Else
            Return Value
        End If
    End Function


#Region "Can"

    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            If Not IsActive Then
                Return False
            End If
            CanEditOnlyNotes = False
            If ClassifierType.FromType(Me.GetType, GetSession()).Kind.Value = ClassifierKindEnum.System Then
                Return True
            End If

            If ClassifierType.FromType(Me.GetType, GetSession()).Kind.Value = ClassifierKindEnum.External Then
                If Not CanDo("Classifier.External.Save") And _
                   Not ClassifierType.FromType(Me.GetType, GetSession()).MemoPrompt Is Nothing And _
                   CanDo("Menu.ClassifierAdministration") Then
                    'if external classifier have Notes then user can edit this record (only notes). it is implement in form using CanEditOnlyNotes variable 
                    CanEditOnlyNotes = True
                    Return True
                End If
                Return CanDo("Classifier.External.Save")
            End If

            If ExternalID.HasValue AndAlso ExternalID.Value = -5 Then
                Return False
            End If

            Return CanDo("Menu.ClassifierAdministration")
        End Get
    End Property

    Public Overridable ReadOnly Property CanEditForReadOnly() As Boolean
        Get
            Return Not CanEdit
        End Get
    End Property

    Public Overridable ReadOnly Property CanEditNameForReadOnly() As Boolean
        Get
            If Not IsActive Then
                Return False
            End If
            CanEditOnlyNotes = False
            If ClassifierType.FromType(Me.GetType, GetSession()).Kind.Value = ClassifierKindEnum.System Then
                Return False
            End If

            If ClassifierType.FromType(Me.GetType, GetSession()).Kind.Value = ClassifierKindEnum.External Then
                If Not CanDo("Classifier.External.Save") And _
                   Not ClassifierType.FromType(Me.GetType, GetSession()).MemoPrompt Is Nothing And _
                   CanDo("Menu.ClassifierAdministration") Then
                    'if external classifier have Notes then user can edit this record (only notes). it is implement in form using CanEditOnlyNotes variable 
                    CanEditOnlyNotes = True
                    Return True
                End If
                Return CanDo("Classifier.External.Save")
            End If

            If ExternalID.HasValue AndAlso ExternalID.Value = -4 Then
                Return False
            End If

            Return Not CanDo("Menu.ClassifierAdministration")
        End Get
    End Property
    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            If Not IsActive OrElse CanNotDelete Then Return False
            If ClassifierType.FromType(Me.GetType, GetSession()).Kind.Value = ClassifierKindEnum.System Then
                Return False
            End If
            If ClassifierType.FromType(Me.GetType, GetSession()).Kind.Value = ClassifierKindEnum.External Then
                Return CanDo("Menu.ClassifierAdministration") And ValidUntil.HasValue AndAlso ValidUntil.Value <= Now.Date
            End If
            If ExternalID.HasValue AndAlso ExternalID.Value = -5 Then
                Return False
            End If
            Return CanDo("Menu.ClassifierAdministration")
        End Get
    End Property

    Public Overridable ReadOnly Property CanActivate() As Boolean
        Get
            If IsActive Then Return False
            Return CanDo("Menu.ClassifierAdministration") And ClassifierType.FromType(Me.GetType, GetSession()).Kind.Value = ClassifierKindEnum.External
        End Get
    End Property


#End Region

    Public Overridable Sub Delete()
        If Me.IsActive Then
            Me.IsActive = False
            If ClassifierType.FromType(Me.GetType, GetSession()).Kind.Value = ClassifierKindEnum.Internal And Not ValidUntil.HasValue Then ValidUntil = Now()
            Core.Logger.DB.Log(GetSession(), AuditMessage.ClassifierDelete, Context.Current.GetImpersonatedUser(GetSession()), Me.Id)
        End If
    End Sub

    Public Overridable Sub Activate()
        If Not Me.IsActive Then
            Me.IsActive = True
        End If
    End Sub

    Public Shared Function getClassifersByType(ByVal classifier As Type, ByVal _session As Core.Dal.ISession) As Entities(Of Classifier)
        Select Case classifier.Name
            Case "Position"
                Dim classif As Entities(Of Position)
                classif = Entities(Of Position).GetAll(_session, New Core.Dal.Expressions.IsNull("DeleteTime"))
                Dim returnClassifier As New Entities(Of Classifier)
                For Each x As Position In classif
                    returnClassifier.Add(CType(x, Classifier))
                Next
                Return returnClassifier
            Case "Speciality"
                Dim classif As Entities(Of Speciality)
                classif = Entities(Of Speciality).GetAll(_session, New Core.Dal.Expressions.Eq("Mark", False), New Core.Dal.Expressions.IsNull("DeleteTime"))
                Dim returnClassifier As New Entities(Of Classifier)
                For Each x As Speciality In classif
                    returnClassifier.Add(CType(x, Classifier))
                Next
                Return returnClassifier
            Case "SpecialityGroups"
                Dim classif As Entities(Of SpecialityGroups)
                classif = Entities(Of SpecialityGroups).GetAll(_session, New Core.Dal.Expressions.IsNull("DeleteTime"))
                Dim returnClassifier As New Entities(Of Classifier)
                For Each x As SpecialityGroups In classif
                    returnClassifier.Add(CType(x, Classifier))
                Next
                Return returnClassifier
            Case "Room"
                Dim classif As Entities(Of Room)
                classif = Entities(Of Room).GetAll(_session, New Core.Dal.Expressions.IsNull("DeleteTime"))
                Dim returnClassifier As New Entities(Of Classifier)
                For Each x As Room In classif
                    returnClassifier.Add(CType(x, Classifier))
                Next
                Return returnClassifier
            Case "RoomGroups"
                Dim classif As Entities(Of RoomGroups)
                classif = Entities(Of RoomGroups).GetAll(_session, New Core.Dal.Expressions.IsNull("DeleteTime"))
                Dim returnClassifier As New Entities(Of Classifier)
                For Each x As RoomGroups In classif
                    returnClassifier.Add(CType(x, Classifier))
                Next
                Return returnClassifier
            Case "VisitType"
                Dim classif As Entities(Of VisitType)
                classif = Entities(Of VisitType).GetAll(_session, New Core.Dal.Expressions.IsNull("DeleteTime"))
                Dim returnClassifier As New Entities(Of Classifier)
                For Each x As VisitType In classif
                    returnClassifier.Add(CType(x, Classifier))
                Next
                Return returnClassifier
            Case "Services"
                Dim classif As Entities(Of Services)
                classif = Entities(Of Services).GetAll(_session, New Core.Dal.Expressions.IsNull("DeleteTime"))
                Dim returnClassifier As New Entities(Of Classifier)
                For Each x As Services In classif
                    returnClassifier.Add(CType(x, Classifier))
                Next
                Return returnClassifier
            Case "Statuss"
                Dim classif As Entities(Of Statuss)
                classif = Entities(Of Statuss).GetAll(_session, New Core.Dal.Expressions.IsNull("DeleteTime"))
                Dim returnClassifier As New Entities(Of Classifier)
                For Each x As Statuss In classif
                    returnClassifier.Add(CType(x, Classifier))
                Next
                Return returnClassifier
        End Select
    End Function

End Class

''' <summary>KAmatu klasifikators</summary>
Public Class Position : Inherits Classifier : End Class

''' <summary>Veidlapu sagatavju grupas</summary>
Public Class TemplateType : Inherits Classifier
    Public Shared ReadOnly CheckUp As New Guid("8DAD1D83-5FD4-4FEE-BA8F-9B42012BE910")
    Public Shared ReadOnly Insurance As New Guid("674E0C9E-999E-4E8E-99CB-9B5F015633FB")

End Class

''' <summary>Valoda</summary>
Public Class Language : Inherits Classifier : End Class

''' <summary>Medicīniskā specializācija</summary>
Public Class Specialization : Inherits Classifier

    Public Shared ReadOnly VisparejaMedicina As New Guid("D9B4651C-EE51-48F9-BA85-9AAF0106757A")
    Public Shared ReadOnly Ginekologija As New Guid("7D0958B0-93E2-43A7-82B6-9AAF01068AAE")
    Public Shared ReadOnly Pediatrija As New Guid("15F0C03A-9FFD-4F11-81A5-9AAF01069B4A")
    Public Shared ReadOnly Vakcinacija As New Guid("11348402-25BA-424D-86E8-9AAF0106AE13")
    Public Shared ReadOnly KlaudijasHelasVecakuKlubins As New Guid("4E7FDAB4-A433-4C6D-9484-9AAF0106D1BA")
End Class

''' <summary>RTG attēlu veidi</summary>
Public Class RtgType : Inherits Classifier : End Class

''' <summary>Biznesa grupējums</summary>
Public Class BusinessGroup : Inherits Classifier : End Class

''' <summary>Radniecība</summary>
Public Class Kindred : Inherits Classifier : End Class

''' <summary>Klientu veids</summary>
Public Class PatientType : Inherits Classifier : End Class


''' <summary>Vizītes statusi</summary>
Public Class Statuss
    Inherits Classifier

    ''' <summary>
    ''' Pieteikta
    ''' </summary>
    Public Shared ReadOnly Notify As New Guid("369C2808-4639-40F6-97F3-9A3F01615F79")

    Private _status As Core.Dal.IChildCollection(Of Statuss)
    Public Sub New()
        MyBase.New()

        Status = New Core.Dal.ChildCollection(Of Statuss)

    End Sub

    Public Overridable Property Status() As Core.Dal.IChildCollection(Of Statuss)
        Get
            Return _status
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of Statuss))
            Assign("Status", value, _status)
        End Set
    End Property

    Private _statusChanged As Boolean
    Public Overridable Property StatusChanged() As Boolean
        Get
            Return _statusChanged
        End Get
        Set(ByVal value As Boolean)
            _statusChanged = value
        End Set
    End Property
End Class

''' <summary>Specialitāšu klasifikators</summary>
Public Class Speciality
    Inherits Classifier
    Private _services As Core.Dal.IChildCollection(Of Services)

    Public Sub New()
        MyBase.New()

        Services = New Core.Dal.ChildCollection(Of Services)
    End Sub

    Public Overridable Property Services() As Core.Dal.IChildCollection(Of Services)
        Get
            Return _services
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of Services))
            Assign("Services", value, _services)
        End Set
    End Property

    Private _servicesChanged As Boolean
    Public Overridable Property ServicesChanged() As Boolean
        Get
            Return _servicesChanged
        End Get
        Set(ByVal value As Boolean)
            _servicesChanged = value
        End Set
    End Property

End Class

''' <summary>Kabinetu klasifikators</summary>
Public Class Room : Inherits Classifier : End Class

''' <summary>Kabinetu grupu klasifikators</summary>
Public Class RoomGroups
    Inherits Classifier
    Private _Specialities As Core.Dal.IChildCollection(Of Speciality)

    Public Sub New()
        MyBase.New()

        Specialities = New Core.Dal.ChildCollection(Of Speciality)
    End Sub

    Public Overridable Property Specialities() As Core.Dal.IChildCollection(Of Speciality)
        Get
            Return _Specialities
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of Speciality))
            Assign("Specialities", value, _Specialities)
        End Set
    End Property

    Private _specialitiesChanged As Boolean
    Public Overridable Property SpecialitiesChanged() As Boolean
        Get
            Return _specialitiesChanged
        End Get
        Set(ByVal value As Boolean)
            _specialitiesChanged = value
        End Set
    End Property

End Class


''' <summary>Kabinetu grupu klasifikators</summary>
Public Class SpecialityGroups
    Inherits Classifier
    Private _specialities As Core.Dal.IChildCollection(Of Speciality)

    Public Sub New()
        MyBase.New()

        Specialities = New Core.Dal.ChildCollection(Of Speciality)
    End Sub

    Public Overridable Property Specialities() As Core.Dal.IChildCollection(Of Speciality)
        Get
            Return _specialities
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of Speciality))
            Assign("Specialities", value, _specialities)
        End Set
    End Property

    Private _specialitiesChanged As Boolean
    Public Overridable Property SpecialitiesChanged() As Boolean
        Get
            Return _specialitiesChanged
        End Get
        Set(ByVal value As Boolean)
            _specialitiesChanged = value
        End Set
    End Property

End Class

''' <summary>Vizīšu tipu klasifikators</summary>
Public Class VisitType
    Inherits Classifier

    Public Overrides Function ToString() As String
        Return Value & " (" & DecimalValue.ToString() & ")"
    End Function


End Class


''' <summary>
''' specialitātes veids Pieaugušo Bērnu
''' </summary>
''' <remarks></remarks>
Public Class SpecialityType
    Inherits Classifier
End Class

''' <summary>
''' Klientu programmu profili
''' </summary>
''' <remarks></remarks>
Public Class Profile
    Inherits Classifier
End Class


''' <summary>
''' Maksājuma veids (skaidrā naudā, ar pārskaitījumu)
''' </summary>
''' <remarks></remarks>
Public Class PaymentType
    Inherits Classifier
    Public Shared ReadOnly Cash As New Guid("4994C29E-E193-42E0-8583-9CC60182C0F6")
    Public Shared ReadOnly Transfer As New Guid("6938F254-5ECF-4FAE-ABF9-9CC60182C0F6")
    Public Shared ReadOnly Abonements As New Guid("79222BBC-B3AB-4E14-A304-9EEE00E18F02")
    Public Shared ReadOnly Programma As New Guid("2DBFCCCD-3AC9-4186-A699-9EEE00E1CDFB")
    Public Shared ReadOnly PAK As New Guid("FC02AB9A-2C4D-44C9-AD8B-9EEE00E1CDFB")
    Public Shared ReadOnly Akcija As New Guid("E5B862AA-FAB5-46FC-B770-9F1E00DFD3E9")
    Public Shared ReadOnly Barters As New Guid("FFD74721-7EFB-4C01-8F94-A0B400E99156")
    Public Shared ReadOnly Kupons As New Guid("288a54cc-5815-4502-917e-a1a90119b6cd")
End Class

''' <summary>Pakalpojuma veidu klasifikators</summary>
Public Class ServiceTypes
    Inherits Classifier
    Public Shared ReadOnly DoctorVisit As New Guid("FA68712C-82E3-4502-9284-9A57001BDDE6")
    Public Shared ReadOnly Diagnostic As New Guid("FC14CCF4-CEFF-43CD-933B-9A57001BDDE5")
    Public Shared ReadOnly Laboratory As New Guid("ADC76A69-79B3-475E-BED0-9A850006995A")
    Public Shared ReadOnly Manipulations As New Guid("AD925806-DED1-4620-B825-9A8500069960")
    Public Shared ReadOnly Vaccination As New Guid("78BB4E9C-8EA6-484D-8FA6-9A8500069961")
    Public Shared ReadOnly Dentist As New Guid("AB57F1D6-B188-438D-AE5B-9FB800078B2D")
End Class

''' <summary>
''' Dokumentu veids
''' </summary>
''' <remarks></remarks>
Public Class DocType
    Inherits Classifier
End Class


''' <summary>
''' Darbinieku grupējums
''' </summary>
Public Class EmployeGrouping
    Inherits Classifier
End Class

''' <summary>
''' Klīnikas resursu (iekārtu) klasifikators
''' </summary>
Public Class Resource
    Inherits Classifier
End Class

''' <summary>
''' Norīkojumu klasifikators
''' </summary>
Public Class Assignment
    Inherits Classifier
End Class

''' <summary>
''' Asins analīžu grupas
''' </summary>
Public Class BloodTestGroup
    Inherits Classifier

    Private _bloodTests As IChildCollection(Of BloodTest)

    Public Overridable Property BloodTests() As Core.Dal.IChildCollection(Of BloodTest)
        Get
            Return _bloodTests
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of BloodTest))
            Assign("BloodTests", value, _bloodTests)
        End Set
    End Property

End Class

''' <summary>
''' Asins analīzes
''' </summary>
Public Class BloodTest
    Inherits Classifier

    Dim _visitBloodTest As Entities.VisitBloodTest

    Public Overridable Property VisitBloodTest() As VisitBloodTest
        Get
            Return _visitBloodTest
        End Get
        Set(ByVal value As VisitBloodTest)
            Assign("VisitBloodTest", value, _visitBloodTest)
        End Set
    End Property

    Public Overridable ReadOnly Property CodeWithName() As String
        Get
            Return Code & " " & Value
        End Get
    End Property
End Class



''' <summary>Pakalpojumu klasifikators</summary>
Public Class Services
    Inherits Classifier
    Private _roomGroup As Core.Dal.IChildCollection(Of RoomGroups)

    Public Sub New()
        MyBase.New()
        Validator.AddBusinessRule("IntegerValue", AddressOf CommonBusinessRules.CheckRequired, "IntegerValue")
        Validator.AddBusinessRule("DecimalValue", AddressOf CommonBusinessRules.CheckRequired, "DecimalValue")
        RoomGroup = New Core.Dal.ChildCollection(Of RoomGroups)
    End Sub

    Public Overridable Property RoomGroup() As Core.Dal.IChildCollection(Of RoomGroups)
        Get
            Return _roomGroup
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of RoomGroups))
            Assign("RoomGroup", value, _roomGroup)
        End Set
    End Property

    Private _roomGroupsChanged As Boolean
    Public Overridable Property RoomGroumsChanged() As Boolean
        Get
            Return _roomGroupsChanged
        End Get
        Set(ByVal value As Boolean)
            _roomGroupsChanged = value
        End Set
    End Property

    Public Overridable Sub SetPriceandTime(ByVal price As Nullable(Of Double), ByVal length As Nullable(Of Integer))
        If price.HasValue Then
            _decimalValue = price.Value
        End If
        If length.HasValue Then
            _integerValue = length
        End If
    End Sub

End Class

''' <summary>Grupu nodarbību klasifikators</summary>
Public Class GroupsWork
    Inherits Classifier

    Public Sub New()
        MyBase.New()
        Validator.AddBusinessRule("IntegerValue", AddressOf CommonBusinessRules.CheckRequired, "IntegerValue")
        Validator.AddBusinessRule("DecimalValue", AddressOf CommonBusinessRules.CheckRequired, "DecimalValue")
    End Sub

End Class

''' <summary>Asinsgrupu klasifikators</summary>
Public Class BloodGroup : Inherits Classifier : End Class

''' <summary>Procentu likmes</summary>
Public Class Percentage
    Inherits Classifier

    Public Sub New()
        MyBase.New()
        Validator.AddBusinessRule("DecimalValue", AddressOf CommonBusinessRules.CheckRequired, "DecimalValue")
    End Sub
End Class

' Уныкоде

