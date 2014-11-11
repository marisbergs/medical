Imports Core.Dal
Imports Core.Bll
Imports System.IO

Public Class Patient
    Inherits BusinessObjectBase(Of Guid)

    Private _name As String 'vārds
    Private _secondName As String 'vārds
    Private _surname As String 'uzvārds
    Private _code As String 'personas kods
    Private _birthDate As Nullable(Of DateTime) 'dzimšanas datums
    Private _address As String 'adrese
    Private _postIndex As String 'adrese
    Private _declaredAddress As String ' deklarētā adrese
    Private _familyStatus As String 'ģimenes statuss
    Private _phone As String 'telefons
    Private _workPhone As String 'darba telefons
    Private _mobilePhone As String
    Private _fax As String 'fakss
    Private _mail As String 'e-pasts
    Private _work As Working 'strādā nestrādā students
    Private _sex As Sex 'dzimums
    Private _pasportSeries As String
    Private _pasportIsuer As String
    Private _pasportNumber As String
    Private _pasportIsueDate As Nullable(Of DateTime)
    Private _childrens As String 'bērni
    Private _language As Language 'valoda
    Private _patientType As PatientType
    Private _workPlace As String 'darba vieta
    Private _position As String 'amats
    Private _familyDoctorName As String
    Private _familyDoctorSurname As String
    Private _familyDoctorPhone As String
    Private _year As Integer
    Private _month As Integer
    Private _day As Integer
    Private _username As String
    Private _password As String
    Private _number As String
    Private _numberTemporary As String
    Private _notes As String
    Private File As BinaryFile
    Private _guardian As IChildCollection(Of Guardian)
    Private _patientDocuments As IChildCollection(Of PatientDocument)
    Private _patientFamily As IChildCollection(Of PatientFamily)
    Private _patientCommercInformation As IChildCollection(Of PatientCommercInformation)
    Private _patientProfileDetails As IChildCollection(Of PatientProfileDescription)
    Private _bonusPointsRecive As IChildCollection(Of BonusPoints)
    Private _bonusPointsUse As IChildCollection(Of BonusPoints)
    Private _insurance As IChildCollection(Of PatientInsurance)
    Private _visits As IChildCollection(Of Visit)
    Private _abonementi As IChildCollection(Of Subscription)
    Private _confirmationCode As String
    Private _confirmed As Boolean
    Private _hasCard As Boolean
    Private _createDate As Nullable(Of DateTime)
    Private _vip As Boolean
    Private _biz As Boolean
    Private _employe As Boolean
    Private _employeId As User
    Private _blackList As Boolean
    Private _relation As Boolean
    Private _relationUser As User
    Private _relationType As Kindred
    Private _createPlace As String
    Private _recomend As Boolean
    Private _recomendComment As String
    Private _media As Boolean
    Private _mediaComment As String
    Private _other As Boolean
    Private _otherComment As String
    Private _discount As Nullable(Of Integer)
    Private _totalInsuranceSumm As Decimal
    Private _sms As IChildCollection(Of SMSSendingList)
    Private _patientStatus As String
    Private _birthdateGreetingsSend As Int16
    Private _newClient As String
    Private _incomeGroup As String
    Private _lastvisitgroup As String
    Private _visitDate As Nullable(Of DateTime)
    Private _campaigans As IChildCollection(Of CampaignPatient)
    Private _country As String
    Private _city As String
    Private _diagnoze As Diagnoze


    Public Sub New()
        MyBase.New()
        AddBusinessRoles()
    End Sub

    Private Sub AddBusinessRoles()
        Validator.AddBusinessRule("Name", AddressOf CommonBusinessRules.CheckRequired, "Name")
        Validator.AddBusinessRule("Surname", AddressOf CommonBusinessRules.CheckRequired, "Surname")
        Validator.AddBusinessRule("Code", AddressOf CommonBusinessRules.CheckRequired, "Code")
    End Sub

    Public Sub New(ByVal session As ISession)
        MyBase.New()
        AddBusinessRoles()
        Guardian = New ChildCollection(Of Guardian)
        PatientDocuments = New ChildCollection(Of PatientDocument)
        PatientFamily = New ChildCollection(Of PatientFamily)
        PatientCommercInformation = New ChildCollection(Of PatientCommercInformation)
        PatientProfileDetails = New ChildCollection(Of PatientProfileDescription)
        BonusPointsRecive = New ChildCollection(Of BonusPoints)
        BonusPointsUse = New ChildCollection(Of BonusPoints)
        Insurance = New ChildCollection(Of PatientInsurance)
        Campaigans = New ChildCollection(Of CampaignPatient)
        Visits = New ChildCollection(Of Visit)
    End Sub

    ''' <summary>
    ''' Vārds
    ''' </summary>
    Public Overridable Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            Assign("Name", value, _name)
        End Set
    End Property
    ''' <summary>
    ''' Otrais vārds
    ''' </summary>
    Public Overridable Property SecondName() As String
        Get
            Return _secondName
        End Get
        Set(ByVal value As String)
            Assign("SecondName", value, _secondName)
        End Set
    End Property

    ''' <summary>
    ''' Uzvārds
    ''' </summary>
    Public Overridable Property Surname() As String
        Get
            Return _surname
        End Get
        Set(ByVal value As String)
            Assign("Surname", value, _surname)
        End Set
    End Property

    ''' <summary>
    ''' personas kods
    ''' </summary>
    Public Overridable Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            Assign("Code", value, _code)
            If Code.Length >= 6 Then
                Dim str As String = _code.Substring(0, 6)
                Dim day As String = str.Substring(0, 2)
                Dim month As String = str.Substring(2, 2)
                Dim year As String = str.Substring(4, 2)
                Dim d As Integer
                Dim m As Integer
                Dim y As Integer
                If Integer.TryParse(day, d) Then
                    If Integer.TryParse(month, m) Then
                        If Integer.TryParse(year, y) Then
                            If y > (Date.Now.Year - 2000) Then
                                Try
                                    BirthDate = New DateTime((y + 1900), m, d)
                                Catch ex As ArgumentOutOfRangeException
                                End Try
                            Else
                                Try
                                    BirthDate = New DateTime((y + 2000), m, d)
                                Catch ex As ArgumentOutOfRangeException
                                End Try
                            End If
                        End If
                    End If
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' dzimšanas datums
    ''' </summary>
    Public Overridable Property BirthDate() As Nullable(Of DateTime)
        Get
            Return _BirthDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("BirthDate", value, _BirthDate)
        End Set
    End Property

    Public Overridable Property BirthdateGreetingsSend() As Int16
        Get
            Return _birthdateGreetingsSend
        End Get
        Set(ByVal value As Int16)
            Assign("BirthdateGreetingsSend", value, _birthdateGreetingsSend)
        End Set
    End Property

    Public Overridable Property NewClient() As String
        Get
            Return _newClient
        End Get
        Set(ByVal value As String)
            Assign("NewClient", value, _newClient)
        End Set
    End Property

    Public Overridable Property IncomeGroup() As String
        Get
            Return _incomeGroup
        End Get
        Set(ByVal value As String)
            Assign("IncomeGroup", value, _incomeGroup)
        End Set
    End Property

    Public Overridable Property Lastvisitgroup() As String
        Get
            Return _lastvisitgroup
        End Get
        Set(ByVal value As String)
            Assign("Lastvisitgroup", value, _lastvisitgroup)
        End Set
    End Property

    Public Overridable Property Year() As Integer
        Get
            Return _year
        End Get
        Set(ByVal value As Integer)
            _year = value
        End Set
    End Property

    Public Overridable Property Month() As Integer
        Get
            Return _month
        End Get
        Set(ByVal value As Integer)
            _month = value
        End Set
    End Property

    Public Overridable Property Day() As Integer
        Get
            Return _day
        End Get
        Set(ByVal value As Integer)
            _day = value
        End Set
    End Property

    ''' <summary>
    ''' Adrese
    ''' </summary>
    Public Overridable Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            Assign("Address", value, _address)
        End Set
    End Property

    ''' <summary>
    ''' Pasta indekss
    ''' </summary>
    Public Overridable Property PostIndex() As String
        Get
            Return _postIndex
        End Get
        Set(ByVal value As String)
            Assign("PostIndex", value, _postIndex)
        End Set
    End Property

    ''' <summary>
    ''' deklarētā adrese
    ''' </summary>
    Public Overridable Property DeclaredAddress() As String
        Get
            Return _declaredAddress
        End Get
        Set(ByVal value As String)
            Assign("DeclaredAddress", value, _declaredAddress)
        End Set
    End Property

    ''' <summary>
    ''' pases izdevējiestāde
    ''' </summary>
    Public Overridable Property PasportIsuer() As String
        Get
            Return _pasportIsuer
        End Get
        Set(ByVal value As String)
            Assign("PasportIsuer", value, _pasportIsuer)
        End Set
    End Property

    ''' <summary>
    ''' pases sērija
    ''' </summary>
    Public Overridable Property PasportSeries() As String
        Get
            Return _pasportSeries
        End Get
        Set(ByVal value As String)
            Assign("PasportSeries", value, _pasportSeries)
        End Set
    End Property

    ''' <summary>
    ''' pases numurs
    ''' </summary>
    Public Overridable Property PasportNumber() As String
        Get
            Return _pasportNumber
        End Get
        Set(ByVal value As String)
            Assign("PasportNumber", value, _pasportNumber)
        End Set
    End Property


    ''' <summary>
    ''' pases numurs
    ''' </summary>
    Public Overridable Property PasportIsueDate() As Nullable(Of DateTime)
        Get
            Return _pasportIsueDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Assign("PasportIsueDate", value, _pasportIsueDate)
        End Set
    End Property


    ''' <summary>
    ''' Ìimenes stāvoklis
    ''' </summary>
    Public Overridable Property FamilyStatus() As String
        Get
            Return _familyStatus
        End Get
        Set(ByVal value As String)
            Assign("FamilyStatus", value, _familyStatus)
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
    ''' Bērni
    ''' </summary>
    Public Overridable Property Childrens() As String
        Get
            Return _childrens
        End Get
        Set(ByVal value As String)
            Assign("Childrens", value, _childrens)
        End Set
    End Property

    ''' <summary>
    ''' klienta numurs
    ''' </summary>
    Public Overridable Property Number() As String
        Get
            Return _number
        End Get
        Set(ByVal value As String)
            Assign("Number", value, _number)
        End Set
    End Property

    ''' <summary>
    ''' klienta pagaidu numurs
    ''' </summary>
    Public Overridable Property NumberTemporary() As String
        Get
            Return _numberTemporary
        End Get
        Set(ByVal value As String)
            Assign("NumberTemporary", value, _numberTemporary)
        End Set
    End Property

    Public Overridable ReadOnly Property NumberAddRemoveButtonCaption() As String
        Get
            If Not String.IsNullOrEmpty(Number) Then
                Return "Noņemt klienta Nr."
            ElseIf Not String.IsNullOrEmpty(NumberTemporary) Then
                Return "Noņemt pagaidu Nr."
            Else
                Return "Uzstādīt Nr."
            End If
        End Get
    End Property

    ''' <summary>
    ''' Piezīmes
    ''' </summary>
    Public Overridable Property Notes() As String
        Get
            Return _notes
        End Get
        Set(ByVal value As String)
            Assign("Notes", value, _notes)
        End Set
    End Property

    ''' <summary>
    ''' vēlamā sarunvaloda
    ''' </summary>
    Public Overridable Property Language() As Language
        Get
            Return _language
        End Get
        Set(ByVal value As Language)
            Assign("Language", value, _language)
        End Set
    End Property

    ''' <summary>
    ''' Klienta veids
    ''' </summary>
    Public Overridable Property PatientType() As PatientType
        Get
            Return _patientType
        End Get
        Set(ByVal value As PatientType)
            Assign("PatientType", value, _patientType)
        End Set
    End Property

    ''' <summary>
    ''' Tālrunis
    ''' </summary>
    Public Overridable Property Phone() As String
        Get
            Return _phone
        End Get
        Set(ByVal value As String)
            Assign("Phone", value, _phone)
        End Set
    End Property

    ''' <summary>
    ''' Darba tālrunis
    ''' </summary>
    Public Overridable Property WorkPhone() As String
        Get
            Return _workPhone
        End Get
        Set(ByVal value As String)
            Assign("WorkPhone", value, _workPhone)
        End Set
    End Property

    ''' <summary>
    ''' Mobilāis tālrunis
    ''' </summary>
    Public Overridable Property MobilePhone() As String
        Get
            Return _mobilePhone
        End Get
        Set(ByVal value As String)
            Assign("MobilePhone", value, _mobilePhone)
        End Set
    End Property

    ''' <summary>
    ''' Fakss
    ''' </summary>
    Public Overridable Property Fax() As String
        Get
            Return _fax
        End Get
        Set(ByVal value As String)
            Assign("Fax", value, _fax)
        End Set
    End Property

    ''' <summary>
    ''' E-pasts
    ''' </summary>
    Public Overridable Property Mail() As String
        Get
            Return _mail
        End Get
        Set(ByVal value As String)
            Assign("Mail", value, _mail)
        End Set
    End Property

    ''' <summary>
    ''' Nodarbošanās
    ''' </summary>
    Public Overridable Property Work() As Working
        Get
            Return _work
        End Get
        Set(ByVal value As Working)
            Assign("Work", value, _work)
        End Set
    End Property

    ''' <summary>
    ''' Darbavieta
    ''' </summary>
    Public Overridable Property WorkPlace() As String
        Get
            Return _workPlace
        End Get
        Set(ByVal value As String)
            Assign("WorkPlace", value, _workPlace)
        End Set
    End Property

    ''' <summary>
    ''' Amats
    ''' </summary>
    Public Overridable Property Position() As String
        Get
            Return _position
        End Get
        Set(ByVal value As String)
            Assign("Position", value, _position)
        End Set
    End Property

    ''' <summary>
    ''' Aizbildnis
    ''' </summary>
    Public Overridable Property Guardian() As IChildCollection(Of Guardian)
        Get
            Return _guardian
        End Get
        Set(ByVal value As IChildCollection(Of Guardian))
            Assign("Guardian", value, _guardian)
        End Set
    End Property

    ''' <summary>
    ''' SMS
    ''' </summary>
    Public Overridable Property Sms() As IChildCollection(Of SMSSendingList)
        Get
            Return _sms
        End Get
        Set(ByVal value As IChildCollection(Of SMSSendingList))
            Assign("Sms", value, _sms)
        End Set
    End Property

    ''' <summary>
    ''' Pievienotie dokumenti 
    ''' </summary>
    Public Overridable Property PatientDocuments() As IChildCollection(Of PatientDocument)
        Get
            Return _patientDocuments
        End Get
        Set(ByVal value As IChildCollection(Of PatientDocument))
            Assign("PatientDocuments", value, _patientDocuments)
        End Set
    End Property

    ''' <summary>
    ''' Klienta ģimene
    ''' </summary>
    Public Overridable Property PatientFamily() As IChildCollection(Of PatientFamily)
        Get
            Return _patientFamily
        End Get
        Set(ByVal value As IChildCollection(Of PatientFamily))
            Assign("PatientFamily", value, _patientFamily)
        End Set
    End Property

    ''' <summary>
    ''' Klienta ģimene
    ''' </summary>
    Public Overridable Property PatientCommercInformation() As IChildCollection(Of PatientCommercInformation)
        Get
            Return _patientCommercInformation
        End Get
        Set(ByVal value As IChildCollection(Of PatientCommercInformation))
            Assign("PatientCommercInformation", value, _patientCommercInformation)
        End Set
    End Property

    ''' <summary>
    ''' Primārās aprûpes kartes
    ''' </summary>
    Public Overridable Property PatientProfileDetails() As IChildCollection(Of PatientProfileDescription)
        Get
            Return _patientProfileDetails
        End Get
        Set(ByVal value As IChildCollection(Of PatientProfileDescription))
            Assign("PatientProfileDetails", value, _patientProfileDetails)
        End Set
    End Property

    ''' <summary>
    ''' Klienta abonementi
    ''' </summary>
    Public Overridable Property Abonementi() As IChildCollection(Of Subscription)
        Get
            Return _abonementi
        End Get
        Set(ByVal value As IChildCollection(Of Subscription))
            Assign("Abonementi", value, _abonementi)
        End Set
    End Property

    ''' <summary>
    ''' Klienta saņemtie bonusa punkti
    ''' </summary>
    Public Overridable Property BonusPointsRecive() As IChildCollection(Of BonusPoints)
        Get
            Return _bonusPointsRecive
        End Get
        Set(ByVal value As IChildCollection(Of BonusPoints))
            Assign("BonusPointsRecive", value, _bonusPointsRecive)
        End Set
    End Property

    ''' <summary>
    ''' Klienta izlietotie bonusa punkti
    ''' </summary>
    Public Overridable Property BonusPointsUse() As IChildCollection(Of BonusPoints)
        Get
            Return _bonusPointsUse
        End Get
        Set(ByVal value As IChildCollection(Of BonusPoints))
            Assign("BonusPointsUse", value, _bonusPointsUse)
        End Set
    End Property

    ''' <summary>
    ''' Klienta apdrošināsanas polises
    ''' </summary>
    Public Overridable Property Insurance() As IChildCollection(Of PatientInsurance)
        Get
            Return _insurance
        End Get
        Set(ByVal value As IChildCollection(Of PatientInsurance))
            Assign("Insurance", value, _insurance)
        End Set
    End Property

    Public Overridable Property VisitDate() As Nullable(Of DateTime)
        Get
            If _visitDate.HasValue Then
                Return _visitDate.Value
            Else
                Return DateTime.Now
            End If
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _visitDate = value
        End Set
    End Property


    Public Overridable ReadOnly Property CurrentInsurance() As Insurance
        Get
            If (Insurance Is Nothing) Then
                Return Nothing
            End If
            For Each o As PatientInsurance In Insurance.ActiveItemsWithoutEmpty
                If o.ValidFrom.HasValue AndAlso o.ValidTo.HasValue AndAlso o.ValidFrom.Value.Date <= VisitDate.Value AndAlso o.ValidTo.Value.Date >= VisitDate.Value Then
                    Return o.Insurance
                ElseIf Not o.ValidFrom.HasValue AndAlso Not o.ValidTo.HasValue Then
                    Return o.Insurance
                End If
            Next
            Return Nothing
        End Get
    End Property

    Public Overridable ReadOnly Property CurrentInsuranceProgramm() As Insurance
        Get
            If (Insurance Is Nothing) Then
                Return Nothing
            End If
            For Each o As PatientInsurance In Insurance.ActiveItemsWithoutEmpty
                If o.ValidFrom.HasValue AndAlso o.ValidTo.HasValue AndAlso o.ValidFrom.Value.Date <= VisitDate.Value AndAlso o.ValidTo.Value.Date >= VisitDate.Value Then
                    Return o.Program
                ElseIf Not o.ValidFrom.HasValue AndAlso Not o.ValidTo.HasValue Then
                    Return o.Program
                End If
            Next
            Return Nothing
        End Get
    End Property

    Public Overridable ReadOnly Property CurrentInsuranceNumber() As String
        Get
            If (Insurance Is Nothing) Then
                Return ""
            End If
            For Each o As PatientInsurance In Insurance.ActiveItemsWithoutEmpty
                If o.ValidFrom.HasValue AndAlso o.ValidTo.HasValue AndAlso o.ValidFrom.Value.Date <= VisitDate.Value AndAlso o.ValidTo.Value.Date >= VisitDate.Value Then
                    Return o.Number
                ElseIf Not o.ValidFrom.HasValue AndAlso Not o.ValidTo.HasValue Then
                    Return o.Number
                End If
            Next
            Return ""
        End Get
    End Property

    Public Overridable ReadOnly Property CurrentInsuranceValid() As String
        Get
            If (Insurance Is Nothing) Then
                Return ""
            End If
            For Each o As PatientInsurance In Insurance.ActiveItemsWithoutEmpty
                If o.ValidFrom.HasValue AndAlso o.ValidTo.HasValue AndAlso o.ValidFrom.Value.Date <= VisitDate.Value AndAlso o.ValidTo.Value.Date >= VisitDate.Value Then
                    Return o.ValidFrom.Value.ToShortDateString() & " - " & o.ValidTo.Value.ToShortDateString()
                End If
            Next
            Return ""
        End Get
    End Property

    Public Overridable ReadOnly Property CurrentInsuranceProgrammAndNumber() As String
        Get
            If (CurrentInsuranceProgramm Is Nothing) Then
                Return ""
            End If
            Return CurrentInsuranceProgramm.Value & "/" & CurrentInsuranceNumber
        End Get
    End Property


    Public Overridable Property TotalInsuranceSumm() As Decimal
        Get
            Return _totalInsuranceSumm
        End Get
        Set(ByVal value As Decimal)
            _totalInsuranceSumm = value
        End Set
    End Property



    Public Overridable ReadOnly Property BonusPointsTotal() As Decimal
        Get
            Dim recived As Decimal = 0
            Dim used As Decimal = 0
            Const currency As Decimal = CDec(0.702804)
            For Each x As BonusPoints In BonusPointsRecive.ActiveItemsWithoutEmpty
                Dim v As Decimal = x.Value
                'If (x.EventDate < New DateTime(2014, 1, 1)) Then
                '    v = Decimal.Round(v / currency, 2)
                'End If
                recived += v
            Next

            For Each x As BonusPoints In BonusPointsUse.ActiveItemsWithoutEmpty
                Dim v As Decimal = x.Value
                'If (x.EventDate < New DateTime(2014, 1, 1)) Then
                '    v = Decimal.Round(v / currency, 2)
                'End If
                used += v
            Next
            Return recived - used
        End Get
    End Property

    Public Overridable Function AviableBonusPoints(ByVal visitId As Guid) As Decimal

        Dim recived As Decimal = 0
        Dim used As Decimal = 0

        For Each x As BonusPoints In BonusPointsRecive.ActiveItemsWithoutEmpty
            recived += x.Value
        Next

        For Each x As BonusPoints In BonusPointsUse.ActiveItemsWithoutEmpty
            'bonusa punkti nosûtīti citam klientam
            If (x.Visit Is Nothing) Then
                used += x.Value
            ElseIf (x.Visit.Id <> visitId) Then
                'bonusa punktus izmantoja vizītes apamaksai
                used += x.Value
            End If
        Next
        Return recived - used
    End Function

    ''' <summary>
    ''' Ìimenes ārsta vārds
    ''' </summary>
    Public Overridable Property FamilyDoctorName() As String
        Get
            Return _familyDoctorName
        End Get
        Set(ByVal value As String)
            Assign("FamilyDoctorName", value, _familyDoctorName)
        End Set
    End Property

    ''' <summary>
    ''' Ìimenes ārsta uzvārds
    ''' </summary>
    Public Overridable Property FamilyDoctorSurname() As String
        Get
            Return _familyDoctorSurname
        End Get
        Set(ByVal value As String)
            Assign("FamilyDoctorSurname", value, _familyDoctorSurname)
        End Set
    End Property

    ''' <summary>
    ''' Ìimenes ārsta telefons
    ''' </summary>
    Public Overridable Property FamilyDoctorPhone() As String
        Get
            Return _familyDoctorPhone
        End Get
        Set(ByVal value As String)
            Assign("FamilyDoctorPhone", value, _familyDoctorPhone)
        End Set
    End Property

    ''' <summary>
    ''' Lietotāja vārds interneta reģistrācijai
    ''' </summary>
    Public Overridable Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            Assign("Username", value, _username)
        End Set
    End Property

    ''' <summary>
    ''' parole interneta reģistrācijai
    ''' </summary>
    Public Overridable Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            Assign("Password", value, _password)
        End Set
    End Property

    ''' <summary>
    ''' ieraksta izveides laiks
    ''' </summary>
    Public Overridable ReadOnly Property CreateDate() As Nullable(Of DateTime)
        Get
            Return _createDate
        End Get
    End Property

    ''' <summary>
    ''' Apstiprinājuma kods lietotājam no interneta lai piereģistrētos sistēmā
    ''' </summary>
    Public Overridable Property ConfirmationCode() As String
        Get
            Return _confirmationCode
        End Get
        Set(ByVal value As String)
            Assign("ConfirmationCode", value, _confirmationCode)
        End Set
    End Property

    ''' <summary>
    ''' Apstiprinājuma kods pieņemts
    ''' </summary>
    Public Overridable Property Confirmed() As Boolean
        Get
            Return _confirmed
        End Get
        Set(ByVal value As Boolean)
            Assign("Confirmed", value, _confirmed)
        End Set
    End Property

    ''' <summary>
    ''' Ir kartiņa
    ''' </summary>
    Public Overridable Property HasCard() As Boolean
        Get
            Return _hasCard
        End Get
        Set(ByVal value As Boolean)
            Assign("HasCard", value, _hasCard)
        End Set
    End Property


    ''' <summary>
    ''' Valsts
    ''' </summary>
    Public Overridable Property Country() As String
        Get
            Return _country
        End Get
        Set(ByVal value As String)
            Assign("Country", value, _country)
        End Set
    End Property

    ''' <summary>
    ''' Pilsēta
    ''' </summary>
    Public Overridable Property City() As String
        Get
            Return _city
        End Get
        Set(ByVal value As String)
            Assign("City", value, _city)
        End Set
    End Property

    ''' <summary>
    ''' Diagnoze
    ''' </summary>
    Public Overridable Property Diagnoze() As Diagnoze
        Get
            Return _diagnoze
        End Get
        Set(ByVal value As Diagnoze)
            Assign("Diagnoze", value, _diagnoze)
        End Set
    End Property

    Public Overridable ReadOnly Property color() As Drawing.Color
        Get
            If Diagnoze Is Nothing Then
                Return Nothing
            Else
                Return Diagnoze.ColorinBing
            End If
        End Get
    End Property

    Public Overridable Property Vip() As Boolean
        Get
            Return _vip
        End Get
        Set(ByVal value As Boolean)
            Assign("Vip", value, _vip)
        End Set
    End Property

    Public Overridable Property Biz() As Boolean
        Get
            Return _biz
        End Get
        Set(ByVal value As Boolean)
            Assign("Biz", value, _biz)
        End Set
    End Property

    Public Overridable ReadOnly Property Employe() As Boolean
        Get
            If Not EmployeId Is Nothing AndAlso Not EmployeId.Id = Guid.Empty Then
                Return True
            End If
            Return False
        End Get
    End Property

    Public Overridable Property EmployeId() As User
        Get
            Return _employeId
        End Get
        Set(ByVal value As User)
            Assign("EmployeId", value, _employeId)
        End Set
    End Property

    Public Overridable Property BlackList() As Boolean
        Get
            Return _blackList
        End Get
        Set(ByVal value As Boolean)
            Assign("BlackList", value, _blackList)
        End Set
    End Property

    Public Overridable Property Relation() As Boolean
        Get
            Return _relation
        End Get
        Set(ByVal value As Boolean)
            Assign("Relation", value, _relation)
            If Not _relation Then
                RelationUser = Nothing
                RelationType = Nothing
            End If
        End Set
    End Property

    Public Overridable Property RelationUser() As User
        Get
            Return _relationUser
        End Get
        Set(ByVal value As User)
            Assign("RelationUser", value, _relationUser)
        End Set
    End Property

    Public Overridable Property RelationType() As Kindred
        Get
            Return _relationType
        End Get
        Set(ByVal value As Kindred)
            Assign("RelationType", value, _relationType)
        End Set
    End Property

    Public Overridable Property CreatePlace() As String
        Get
            Return _createPlace
        End Get
        Set(ByVal value As String)
            Assign("CreatePlace", value, _createPlace)
        End Set
    End Property

    Public Overridable Property Recomend() As Boolean
        Get
            Return _recomend
        End Get
        Set(ByVal value As Boolean)
            Assign("Recomend", value, _recomend)
        End Set
    End Property

    Public Overridable Property RecomendComment() As String
        Get
            Return _recomendComment
        End Get
        Set(ByVal value As String)
            Assign("RecomendComment", value, _recomendComment)
        End Set
    End Property

    Public Overridable Property Media() As Boolean
        Get
            Return _media
        End Get
        Set(ByVal value As Boolean)
            Assign("Media", value, _media)
        End Set
    End Property

    Public Overridable Property MediaComment() As String
        Get
            Return _mediaComment
        End Get
        Set(ByVal value As String)
            Assign("MediaComment", value, _mediaComment)
        End Set
    End Property

    Public Overridable Property PatientStatus() As String
        Get
            Return _patientStatus
        End Get
        Set(ByVal value As String)
            Assign("PatientStatus", value, _patientStatus)
        End Set
    End Property

    Public Overridable Property Other() As Boolean
        Get
            Return _other
        End Get
        Set(ByVal value As Boolean)
            Assign("Other", value, _other)
        End Set
    End Property

    Public Overridable Property OtherComment() As String
        Get
            Return _otherComment
        End Get
        Set(ByVal value As String)
            Assign("OtherComment", value, _otherComment)
        End Set
    End Property

    Public Overridable Property Discount() As Nullable(Of Integer)
        Get
            Return _discount
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Assign("Discount", value, _discount)
        End Set
    End Property

    Public Overridable ReadOnly Property CanEditDiscount() As Boolean
        Get
            Return Not PermissionsChecker.CanDo("Patient.ViewAndEditDiscount")
        End Get
    End Property

    Public Overridable ReadOnly Property CanSeeDiscount() As Boolean
        Get
            Return PermissionsChecker.CanDo("Patient.ViewAndEditDiscount") OrElse PermissionsChecker.CanDo("Patient.ViewDiscount")
        End Get
    End Property

    Public Overridable Property Campaigans() As IChildCollection(Of CampaignPatient)
        Get
            Return _campaigans
        End Get
        Set(ByVal value As IChildCollection(Of CampaignPatient))
            Assign("Campaigans", value, _campaigans)
        End Set
    End Property


    Public Overridable Property Visits() As IChildCollection(Of Visit)
        Get
            Return _visits
        End Get
        Set(ByVal value As IChildCollection(Of Visit))
            Assign("Visits", value, _visits)
        End Set
    End Property

    Public Overridable Sub SetConfirmationCode()
        Dim x As New System.Random()
    End Sub

    Public Overrides Function ToString() As String
        If Not String.IsNullOrEmpty(Name) AndAlso Not String.IsNullOrEmpty(Surname) Then
            Return Surname & " " & Name
        ElseIf String.IsNullOrEmpty(Name) Then
            Return Surname
        Else
            Return Surname
        End If
    End Function

    Public Overrides ReadOnly Property CanDelete() As Boolean
        Get
            Return (IsActive And PermissionsChecker.CanDo("Patient.CanDelete"))
        End Get
    End Property

    Public Overridable ReadOnly Property CanRestore() As Boolean
        Get
            Return (Not IsActive And PermissionsChecker.CanDo("Patient.CanDelete"))
        End Get
    End Property

    Public Overridable ReadOnly Property FullName() As String
        Get
            If Not String.IsNullOrEmpty(Name) AndAlso Not String.IsNullOrEmpty(Surname) Then
                Return Surname & " " & Name & IIf(String.IsNullOrEmpty(SecondName), "", " " & SecondName).ToString()
            ElseIf String.IsNullOrEmpty(Name) Then
                Return Surname & IIf(String.IsNullOrEmpty(SecondName), "", " " & SecondName).ToString()
            Else
                Return Surname & IIf(String.IsNullOrEmpty(SecondName), "", " " & SecondName).ToString()
            End If
        End Get
    End Property



    Public Overridable Function GetActivePAK(ByVal visitDate As DateTime) As PatientProfileDescription
        If PatientProfileDetails.ActiveItemsWithoutEmpty.Count > 0 Then
            For Each o As PatientProfileDescription In PatientProfileDetails.ActiveItemsWithoutEmpty
                If o.BeginDate <= visitDate.Date AndAlso visitDate.Date <= o.EndDate Then
                    Return o
                End If
            Next
        Else
            Return Nothing
        End If
    End Function


    Public Overridable Sub SetNumber(ByVal session As ISession)
        Dim chars(26) As String
        chars(1) = "A"
        chars(2) = "B"
        chars(3) = "C"
        chars(4) = "D"
        chars(5) = "E"
        chars(6) = "F"
        chars(7) = "G"
        chars(8) = "H"
        chars(9) = "I"
        chars(10) = "J"
        chars(11) = "K"
        chars(12) = "L"
        chars(13) = "M"
        chars(14) = "N"
        chars(15) = "O"
        chars(16) = "P"
        chars(17) = "Q"
        chars(18) = "R"
        chars(19) = "S"
        chars(20) = "T"
        chars(21) = "U"
        chars(22) = "V"
        chars(23) = "W"
        chars(24) = "X"
        chars(25) = "Y"
        chars(26) = "Z"
        Dim patients As Entities(Of Patient) = Entities(Of Patient).GetAllOrderBy(session, New NHibernate.Expression.Order("Number", False))
        If patients.Count > 0 Then
            Dim latest As String = patients(0).Number
            Dim start As String = latest.Substring(0, 2)
            Dim endNumber As Integer
            Integer.TryParse(latest.Substring(2), endNumber)
            If (endNumber < 99) Then
                If (endNumber + 1).ToString().Length = 1 Then
                    Number = start & "0" & endNumber + 1
                Else
                    Number = start & endNumber + 1
                End If
            Else
                Dim first As String = start.Substring(0, 1)
                Dim second As String = start.Substring(1)

                Dim current As Integer

                For i As Integer = 1 To chars.Length
                    If chars(i) = second Then
                        current = i
                        Exit For
                    End If
                Next

                If chars.Length > current Then
                    second = chars(current + 1)
                Else
                    For i As Integer = 1 To chars.Length
                        If chars(i) = first Then
                            current = i
                            Exit For
                        End If
                    Next
                    first = chars(current + 1)
                End If
                Number = first & second & "01"
            End If
        End If
    End Sub

    Public Overridable Sub FilBirthday()
        BirthDate = New DateTime(Year, Month, Day)
    End Sub

    Public Overridable Sub FilBirthdaySeperate()
        If BirthDate.HasValue Then
            Year = BirthDate.Value.Year
            Month = BirthDate.Value.Month
            Day = BirthDate.Value.Day
        End If
    End Sub

    Public Overridable Sub GenerateDocument(ByVal tagName As String, ByVal template As Template)
        If template Is Nothing OrElse template.CurrentVersion Is Nothing Then
            Return
        End If


        Dim templateStream As Stream = template.CurrentVersion.File.Content.GetAsStream()
        Dim context As New Hashtable
        context.Add(tagName, Me)
        context.Add("P1", Me)

        Dim fileName As String = Path.GetTempFileName() + ".rtf"
        Core.Reporting.Report.CreateReport(templateStream, fileName, context)
        File = New BinaryFile(GetSession(), fileName)
        ShowTrackedDocument()
    End Sub

    Public Overridable Sub ShowTrackedDocument()
        If File Is Nothing Then Return

        Dim tempPath As String = System.IO.Path.GetTempPath + Guid.NewGuid().ToString() + File.Name
        File.Content.SaveToFile(tempPath)
        Core.Helper.RunShell(tempPath)

    End Sub

End Class
