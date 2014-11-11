Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.Dal.Expressions


Public Class Gynaecology
    Inherits BusinessObjectBase(Of Guid)

    Protected Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal _session As ISession)
        MyBase.New(_session)
        ExtragenitalPathologys = New ChildCollection(Of AnamnesesExtragenitalPathalogy)
        Operations = New ChildCollection(Of AnamnesesOperation)
        Allergies = New ChildCollection(Of AnamnesesAllergy)
        UseMedicaments = New ChildCollection(Of AnamnesesUsedMedicaments)
        EvolutionAnomalies = New ChildCollection(Of AnamnesesEvolutionAnomaly)
        HereditaryDsesases = New ChildCollection(Of AnamnesesHereditaryDsesase)
        ActyalMedicamentsList = New ChildCollection(Of GynaecologyActualMedicaments)
        IlnessList = New ChildCollection(Of GynaecologyIlness)
        Labour = New ChildCollection(Of Labour)
    End Sub

    Private _doctor As User
    Private _fillDate As Nullable(Of DateTime)
    Private _height As Nullable(Of Integer)
    Private _weight As Nullable(Of Decimal)
    Private _bloodGroup As BloodGroup
    Private _bloodPressure As String
    Private _extragenitalPathology As YesNo
    Private _extragenitalPathologys As IChildCollection(Of AnamnesesExtragenitalPathalogy)
    Private _operation As YesNo
    Private _operations As IChildCollection(Of AnamnesesOperation)
    Private _allergy As YesNo
    Private _allergies As IChildCollection(Of AnamnesesAllergy)
    Private _useMedicament As YesNo
    Private _useMedicaments As IChildCollection(Of AnamnesesUsedMedicaments)
    Private _evolutionAnomaly As YesNo
    Private _evolutionAnomalies As IChildCollection(Of AnamnesesEvolutionAnomaly)
    Private _hereditaryDsesase As YesNo
    Private _hereditaryDsesases As IChildCollection(Of AnamnesesHereditaryDsesase)
    Private _menarhe As Nullable(Of Integer)
    Private _cycle As Cycle
    Private _periodicity As String
    Private _length As String
    Private _notes As TextContent
    Private _menopause As Nullable(Of Integer)
    Private _sexLifeStart As Nullable(Of Integer)
    Private _sexLifeFrequence As Cycle
    Private _sexLifeNotes As TextContent
    Private _lay As Lay
    Private _layCount As Nullable(Of Integer)
    Private _layAge As Nullable(Of Integer)
    Private _layWorkPlace As String
    Private _smoking As YesNo
    Private _useAlcohol As YesNo
    Private _medicaments As YesNo
    Private _actyalMedicamentsList As IChildCollection(Of GynaecologyActualMedicaments)
    Private _ilness As YesNo
    Private _ilnessList As IChildCollection(Of GynaecologyIlness)
    Private _labour As IChildCollection(Of Labour)




    ''' <summary>
    ''' Ârsts
    ''' </summary>
    Public Overridable Property Doctor() As User
        Get
            Return _doctor
        End Get
        Set(ByVal value As User)
            Assign("Doctor", value, _doctor)
        End Set
    End Property

    ''' <summary>
    ''' Aizpildīšanas datums
    ''' </summary>
    Public Overridable Property FillDate() As Nullable(Of DateTime)
        Get
            Return _fillDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("FillDate", value, _fillDate)
        End Set
    End Property

    ''' <summary>
    ''' Augums
    ''' </summary>
    Public Overridable Property Height() As Nullable(Of Integer)
        Get
            Return _height
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("Height", value, _height)
        End Set
    End Property

    ''' <summary>
    ''' Svars
    ''' </summary>
    Public Overridable Property Weight() As Nullable(Of Decimal)
        Get
            Return _weight
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Assign("Weight", value, _weight)
        End Set
    End Property

    ''' <summary>
    ''' Asins grupa
    ''' </summary>
    Public Overridable Property BloodGroup() As BloodGroup
        Get
            Return _bloodGroup
        End Get
        Set(ByVal value As BloodGroup)
            Assign("BloodGroup", value, _bloodGroup)
        End Set
    End Property

    ''' <summary>
    ''' Asinsspiediens
    ''' </summary>
    Public Overridable Property BloodPressure() As String
        Get
            Return _bloodPressure
        End Get
        Set(ByVal value As String)
            Assign("BloodPressure", value, _bloodPressure)
        End Set
    End Property

    ''' <summary>
    ''' Ekstraģenitālā pataloģija(diagnozes): Ir/Nav
    ''' </summary>
    Public Overridable Property ExtragenitalPathology() As YesNo
        Get
            Return _extragenitalPathology
        End Get
        Set(ByVal value As YesNo)
            Assign("ExtragenitalPathology", value, _extragenitalPathology)
            If ExtragenitalPathologys.Count > 0 Then
                Dim _obj As AnamnesesExtragenitalPathalogy
                For i As Integer = ExtragenitalPathologys.Count - 1 To 0 Step -1
                    _obj = CType(ExtragenitalPathologys.Item(i), AnamnesesExtragenitalPathalogy)
                    If Not _obj.IsActive Then Continue For
                    If _obj.Id = Guid.Empty Then
                        ExtragenitalPathologys.Remove(_obj)
                        Continue For
                    End If
                    _obj.IsActive = False
                Next
            End If
        End Set
    End Property

    Public Overridable Property ExtragenitalPathologys() As IChildCollection(Of AnamnesesExtragenitalPathalogy)
        Get
            Return _extragenitalPathologys
        End Get
        Set(ByVal value As IChildCollection(Of AnamnesesExtragenitalPathalogy))
            Assign("ExtragenitalPathologys", value, _extragenitalPathologys)
        End Set
    End Property

    ''' <summary>
    ''' Operācijas: Ir/Nav
    ''' </summary>
    Public Overridable Property Operation() As YesNo
        Get
            Return _operation
        End Get
        Set(ByVal value As YesNo)
            Assign("Operation", value, _operation)
            If Operations.Count > 0 Then
                Dim _obj As AnamnesesOperation
                For i As Integer = Operations.Count - 1 To 0 Step -1
                    _obj = CType(Operations.Item(i), AnamnesesOperation)
                    If Not _obj.IsActive Then Continue For
                    If _obj.Id = Guid.Empty Then
                        Operations.Remove(_obj)
                        Continue For
                    End If
                    _obj.IsActive = False
                Next
            End If
        End Set
    End Property

    Public Overridable Property Operations() As IChildCollection(Of AnamnesesOperation)
        Get
            Return _operations
        End Get
        Set(ByVal value As IChildCollection(Of AnamnesesOperation))
            Assign("Operations", value, _operations)
        End Set
    End Property

    ''' <summary>
    ''' Alerģija: Ir/Nav
    ''' </summary>
    Public Overridable Property Allergy() As YesNo
        Get
            Return _allergy
        End Get
        Set(ByVal value As YesNo)
            Assign("Allergy", value, _allergy)
            If Allergies.Count > 0 Then
                Dim _obj As AnamnesesAllergy
                For i As Integer = Allergies.Count - 1 To 0 Step -1
                    _obj = CType(Allergies.Item(i), AnamnesesAllergy)
                    If Not _obj.IsActive Then Continue For
                    If _obj.Id = Guid.Empty Then
                        Allergies.Remove(_obj)
                        Continue For
                    End If
                    _obj.IsActive = False
                Next
            End If
        End Set
    End Property

    Public Overridable Property Allergies() As IChildCollection(Of AnamnesesAllergy)
        Get
            Return _allergies
        End Get
        Set(ByVal value As IChildCollection(Of AnamnesesAllergy))
            Assign("Allergies", value, _allergies)
        End Set
    End Property

    ''' <summary>
    ''' Ikdienā lietojamie medikamenti: Ir/Nav
    ''' </summary>
    Public Overridable Property UseMedicament() As YesNo
        Get
            Return _useMedicament
        End Get
        Set(ByVal value As YesNo)
            Assign("UseMedicament", value, _useMedicament)
            If UseMedicaments.Count > 0 Then
                Dim _obj As AnamnesesUsedMedicaments
                For i As Integer = UseMedicaments.Count - 1 To 0 Step -1
                    _obj = CType(UseMedicaments.Item(i), AnamnesesUsedMedicaments)
                    If Not _obj.IsActive Then Continue For
                    If _obj.Id = Guid.Empty Then
                        UseMedicaments.Remove(_obj)
                        Continue For
                    End If
                    _obj.IsActive = False
                Next
            End If
        End Set
    End Property

    Public Overridable Property UseMedicaments() As IChildCollection(Of AnamnesesUsedMedicaments)
        Get
            Return _useMedicaments
        End Get
        Set(ByVal value As IChildCollection(Of AnamnesesUsedMedicaments))
            Assign("UseMedicaments", value, _useMedicaments)
        End Set
    End Property

    ''' <summary>
    ''' Attīstības anomālijas:  Ir/Nav
    ''' </summary>
    Public Overridable Property EvolutionAnomaly() As YesNo
        Get
            Return _evolutionAnomaly
        End Get
        Set(ByVal value As YesNo)
            Assign("EvolutionAnomaly", value, _evolutionAnomaly)
            If EvolutionAnomalies.Count > 0 Then
                Dim _obj As AnamnesesEvolutionAnomaly
                For i As Integer = EvolutionAnomalies.Count - 1 To 0 Step -1
                    _obj = CType(EvolutionAnomalies.Item(i), AnamnesesEvolutionAnomaly)
                    If Not _obj.IsActive Then Continue For
                    If _obj.Id = Guid.Empty Then
                        EvolutionAnomalies.Remove(_obj)
                        Continue For
                    End If
                    _obj.IsActive = False
                Next
            End If
        End Set
    End Property

    Public Overridable Property EvolutionAnomalies() As IChildCollection(Of AnamnesesEvolutionAnomaly)
        Get
            Return _evolutionAnomalies
        End Get
        Set(ByVal value As IChildCollection(Of AnamnesesEvolutionAnomaly))
            Assign("EvolutionAnomalies", value, _evolutionAnomalies)
        End Set
    End Property

    ''' <summary>
    ''' AIedzimtās slimības:  Ir/Nav
    ''' </summary>
    Public Overridable Property HereditaryDsesase() As YesNo
        Get
            Return _hereditaryDsesase
        End Get
        Set(ByVal value As YesNo)
            Assign("HereditaryDsesase", value, _hereditaryDsesase)
            If HereditaryDsesases.Count > 0 Then
                Dim _obj As AnamnesesHereditaryDsesase
                For i As Integer = HereditaryDsesases.Count - 1 To 0 Step -1
                    _obj = CType(HereditaryDsesases.Item(i), AnamnesesHereditaryDsesase)
                    If Not _obj.IsActive Then Continue For
                    If _obj.Id = Guid.Empty Then
                        HereditaryDsesases.Remove(_obj)
                        Continue For
                    End If
                    _obj.IsActive = False
                Next
            End If
        End Set
    End Property

    ''' <summary>
    ''' AIedzimtās slimības
    ''' </summary>
    Public Overridable Property HereditaryDsesases() As IChildCollection(Of AnamnesesHereditaryDsesase)
        Get
            Return _hereditaryDsesases
        End Get
        Set(ByVal value As IChildCollection(Of AnamnesesHereditaryDsesase))
            Assign("HereditaryDsesases", value, _hereditaryDsesases)
        End Set
    End Property

    ''' <summary>
    ''' Menarhe
    ''' </summary>
    Public Overridable Property Menarhe() As Nullable(Of Integer)
        Get
            Return _menarhe
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("Menarhe", value, _menarhe)
        End Set
    End Property

    ''' <summary>
    ''' Cikls regulārs/neregulārs
    ''' </summary>
    Public Overridable Property Cycle() As Cycle
        Get
            Return _cycle
        End Get
        Set(ByVal value As Cycle)
            Assign("Cycle", value, _cycle)
        End Set
    End Property

    ''' <summary>
    ''' Periodiskums dienās
    ''' </summary>
    Public Overridable Property Periodicity() As String
        Get
            Return _periodicity
        End Get
        Set(ByVal value As String)
            Assign("Periodicity", value, _periodicity)
        End Set
    End Property

    ''' <summary>
    ''' ilgums
    ''' </summary>
    Public Overridable Property Length() As String
        Get
            Return _length
        End Get
        Set(ByVal value As String)
            Assign("Length", value, _length)
        End Set
    End Property

    ''' <summary>
    ''' piezīmes
    ''' </summary>
    Public Overridable Property Notes() As TextContent
        Get
            Return _notes
        End Get
        Set(ByVal value As TextContent)
            Assign("Notes", value, _notes)
        End Set
    End Property

    ''' <summary>
    ''' Menopauze
    ''' </summary>
    Public Overridable Property Menopause() As Nullable(Of Integer)
        Get
            Return _menopause
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("Menopause", value, _menopause)
        End Set
    End Property

    ''' <summary>
    ''' Seksuālās attiecības uzsāktas
    ''' </summary>
    Public Overridable Property SexLifeStart() As Nullable(Of Integer)
        Get
            Return _sexLifeStart
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("SexLifeStart", value, _sexLifeStart)
        End Set
    End Property

    ''' <summary>
    ''' seksuālās attiecībasregulāras/neregulāras
    ''' </summary>
    Public Overridable Property SexLifeFrequence() As Cycle
        Get
            Return _sexLifeFrequence
        End Get
        Set(ByVal value As Cycle)
            Assign("SexLifeFrequence", value, _sexLifeFrequence)
        End Set
    End Property

    ''' <summary>
    ''' piezīmes
    ''' </summary>
    Public Overridable Property SexLifeNotes() As TextContent
        Get
            Return _sexLifeNotes
        End Get
        Set(ByVal value As TextContent)
            Assign("SexLifeNotes", value, _sexLifeNotes)
        End Set
    End Property

    ''' <summary>
    ''' dzimumpartneri
    ''' </summary>
    Public Overridable Property Lay() As Lay
        Get
            Return _lay
        End Get
        Set(ByVal value As Lay)
            Assign("Lay", value, _lay)
        End Set
    End Property

    ''' <summary>
    ''' dzimumpartneru skaits
    ''' </summary>
    Public Overridable Property LayCount() As Nullable(Of Integer)
        Get
            Return _layCount
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("LayCount", value, _layCount)
        End Set
    End Property

    ''' <summary>
    ''' dzimumpartnera vecums
    ''' </summary>
    Public Overridable Property LayAge() As Nullable(Of Integer)
        Get
            Return _layAge
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("LayAge", value, _layAge)
        End Set
    End Property

    ''' <summary>
    ''' dzimumpartnera darbavieta
    ''' </summary>
    Public Overridable Property LayWorkPlace() As String
        Get
            Return _layWorkPlace
        End Get
        Set(ByVal value As String)
            Assign("LayWorkPlace", value, _layWorkPlace)
        End Set
    End Property

    ''' <summary>
    ''' dzimumpertneris smēķē
    ''' </summary>
    Public Overridable Property Smoking() As YesNo
        Get
            Return _smoking
        End Get
        Set(ByVal value As YesNo)
            Assign("Smoking", value, _smoking)
        End Set
    End Property

    ''' <summary>
    ''' dzimumpartners lieto alkaholu
    ''' </summary>
    Public Overridable Property UseAlcohol() As YesNo
        Get
            Return _useAlcohol
        End Get
        Set(ByVal value As YesNo)
            Assign("UseAlcohol", value, _useAlcohol)
        End Set
    End Property

    ''' <summary>
    ''' lieto medikamentus
    ''' </summary>
    Public Overridable Property Medicaments() As YesNo
        Get
            Return _medicaments
        End Get
        Set(ByVal value As YesNo)
            Assign("Medicaments", value, _medicaments)
            If ActyalMedicamentsList.Count > 0 Then
                Dim _obj As GynaecologyActualMedicaments
                For i As Integer = ActyalMedicamentsList.Count - 1 To 0 Step -1
                    _obj = CType(ActyalMedicamentsList.Item(i), GynaecologyActualMedicaments)
                    If Not _obj.IsActive Then Continue For
                    If _obj.Id = Guid.Empty Then
                        ActyalMedicamentsList.Remove(_obj)
                        Continue For
                    End If
                    _obj.IsActive = False
                Next
            End If
        End Set
    End Property

    ''' <summary>
    ''' Medikamenti
    ''' </summary>
    Public Overridable Property ActyalMedicamentsList() As IChildCollection(Of GynaecologyActualMedicaments)
        Get
            Return _actyalMedicamentsList
        End Get
        Set(ByVal value As IChildCollection(Of GynaecologyActualMedicaments))
            Assign("ActyalMedicamentsList", value, _actyalMedicamentsList)
        End Set
    End Property

    ''' <summary>
    ''' lieto medikamentus
    ''' </summary>
    Public Overridable Property Ilness() As YesNo
        Get
            Return _ilness
        End Get
        Set(ByVal value As YesNo)
            Assign("Ilness", value, _ilness)
            If IlnessList.Count > 0 Then
                Dim _obj As GynaecologyIlness
                For i As Integer = IlnessList.Count - 1 To 0 Step -1
                    _obj = CType(IlnessList.Item(i), GynaecologyIlness)
                    If Not _obj.IsActive Then Continue For
                    If _obj.Id = Guid.Empty Then
                        IlnessList.Remove(_obj)
                        Continue For
                    End If
                    _obj.IsActive = False
                Next
            End If
        End Set
    End Property

    ''' <summary>
    ''' slimības
    ''' </summary>
    Public Overridable Property IlnessList() As IChildCollection(Of GynaecologyIlness)
        Get
            Return _ilnessList
        End Get
        Set(ByVal value As IChildCollection(Of GynaecologyIlness))
            Assign("IlnessList", value, _ilnessList)
        End Set
    End Property

    ''' <summary>
    ''' Dzemdības
    ''' </summary>
    Public Overridable Property Labour() As IChildCollection(Of Labour)
        Get
            Return _labour
        End Get
        Set(ByVal value As IChildCollection(Of Labour))
            Assign("IlnessList", value, _labour)
        End Set
    End Property


    Public Overridable ReadOnly Property CanAddOperation() As Boolean
        Get
            Return (Operation = YesNo.Yes)
        End Get
    End Property

    Public Overridable ReadOnly Property CanAddExtragenitalPathology() As Boolean
        Get
            Return (ExtragenitalPathology = YesNo.Yes)
        End Get
    End Property

    Public Overridable ReadOnly Property CanAddAllergy() As Boolean
        Get
            Return (Allergy = YesNo.Yes)
        End Get
    End Property

    Public Overridable ReadOnly Property CanAddUseMedicament() As Boolean
        Get
            Return (UseMedicament = YesNo.Yes)
        End Get
    End Property

    Public Overridable ReadOnly Property CanAddEvolutionAnomaly() As Boolean
        Get
            Return (EvolutionAnomaly = YesNo.Yes)
        End Get
    End Property

    Public Overridable ReadOnly Property CanAddHereditaryDsesase() As Boolean
        Get
            Return (HereditaryDsesase = YesNo.Yes)
        End Get
    End Property

    Public Overridable ReadOnly Property CanAddActyalMedicaments() As Boolean
        Get
            Return (Medicaments = YesNo.Ja)
        End Get
    End Property

    Public Overridable ReadOnly Property CanAddIlness() As Boolean
        Get
            Return (Ilness = YesNo.Yes)
        End Get
    End Property
End Class
