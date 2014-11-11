''' <summary>Dokumenta statusu kodi</summary>
Public Enum DocumentStatusEnum

    ''' <summary>Sagatavošanā</summary>
    Draft = 1
    ''' <summary>Gatavs</summary>
    Ready = 2
    ''' <summary>Pabeigts</summary>
    Complete = 3
    ''' <summary>Nosūtīts</summary>
    Sent = 4
    ''' <summary>Spēkā neesošs</summary>
    NotValid = 5
    ''' <summary>Anulēts</summary>
    Cancelled = 6
    ''' <summary>Pārsūdzības statuss: uzsākta</summary>
    AppealStarted = 7
    ''' <summary>Pārsūdzības statuss: pabeigta</summary>
    AppealCompleted = 8
    ''' <summary>Labošana</summary>
    Correction = 9

End Enum


''' <summary>
''' Dokumenta statusi
''' </summary>
Public Class DocumentStatus
    Inherits Core.EnumWrapper(Of DocumentStatusEnum)

    Sub New(ByVal value As DocumentStatusEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub

    ' Constant predefined values

    ''' <summary>Sagatavošanā</summary>
    Public Shared ReadOnly Draft As DocumentStatus = New DocumentStatus(DocumentStatusEnum.Draft)
    ''' <summary>Gatavs</summary>
    Public Shared ReadOnly Ready As DocumentStatus = New DocumentStatus(DocumentStatusEnum.Ready)
    ''' <summary>Pabeigts</summary>
    Public Shared ReadOnly Complete As DocumentStatus = New DocumentStatus(DocumentStatusEnum.Complete)
    ''' <summary>Nosūtīts</summary>
    Public Shared ReadOnly Sent As DocumentStatus = New DocumentStatus(DocumentStatusEnum.Sent)
    ''' <summary>Spēkā neesošs</summary>
    Public Shared ReadOnly NotValid As DocumentStatus = New DocumentStatus(DocumentStatusEnum.NotValid)
    ''' <summary>Anulēts</summary>
    Public Shared ReadOnly Cancelled As DocumentStatus = New DocumentStatus(DocumentStatusEnum.Cancelled)
    ''' <summary>Labošana</summary>
    Public Shared ReadOnly Correction As DocumentStatus = New DocumentStatus(DocumentStatusEnum.Correction)

    ''' <summary>Pārsūdzības statuss: uzsākta</summary>
    Public Shared ReadOnly AppealStarted As DocumentStatus = New DocumentStatus(DocumentStatusEnum.AppealStarted)
    ''' <summary>Pārsūdzības statuss: pabeigta</summary>
    Public Shared ReadOnly AppealCompleted As DocumentStatus = New DocumentStatus(DocumentStatusEnum.AppealCompleted)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder.Add(Draft)
                _listHolder.Add(Ready)
                _listHolder.Add(Complete)
                _listHolder.Add(Sent)
                _listHolder.Add(NotValid)
                _listHolder.Add(Cancelled)
                _listHolder.Add(Correction)
            End If
            Return _listHolder
        End Get
    End Property

    ''' <summary>
    ''' Pārsūdzības statusu saraksts
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSourceAppealStatuses() As IList
        Get
            Dim _list As New ArrayList
            _list.Add(AppealStarted)
            _list.Add(AppealCompleted)
            Return _list
        End Get
    End Property

    ''' <summary>
    ''' Aktīvu [nedzēstu] dokumenta statusu sarkasts
    ''' Draft, Ready, Complete, Sent, Correction
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListOfActiveStatuses() As IList(Of DocumentStatus)
        Get
            Dim _list As New List(Of DocumentStatus)
            _list.Add(Draft)
            _list.Add(Ready)
            _list.Add(Complete)
            _list.Add(Sent)
            _list.Add(Correction)
            Return _list
        End Get
    End Property

    ''' <summary>
    ''' Aktīvu, bet nenosūtītu dokumenta statusu saraksts
    ''' [Draft, Ready, Complete, Correction]
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListOfActiveNotSentStatuses() As IList(Of DocumentStatus)
        Get
            Dim _list As New List(Of DocumentStatus)
            _list.Add(Draft)
            _list.Add(Ready)
            _list.Add(Complete)
            _list.Add(Correction)
            Return _list
        End Get
    End Property
    ''' <summary>
    ''' Nepabeigtu dokumenta statusu saraksts
    ''' [Draft, Ready, Correction]
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListOfNotCompleteStatuses() As IList(Of DocumentStatus)
        Get
            Dim _list As New List(Of DocumentStatus)
            _list.Add(Draft)
            _list.Add(Ready)
            _list.Add(Correction)
            Return _list
        End Get
    End Property


    Public Overloads Shared ReadOnly Property TcdPlanStatus() As IList(Of DocumentStatus)
        Get
            Dim hasRule As Boolean = False
            Dim list As New List(Of DocumentStatus)
            If Core.Bll.PermissionsChecker.CanDo("TcdPlan.Access.Draft") Then
                list.Add(Draft)
                hasRule = True
            End If
            If Core.Bll.PermissionsChecker.CanDo("TcdPlan.Access.Ready") Then
                list.Add(Ready)
                hasRule = True
            End If
            If Core.Bll.PermissionsChecker.CanDo("TcdPlan.Access.Complete") Then
                list.Add(Complete)
                hasRule = True
            End If
            If Core.Bll.PermissionsChecker.CanDo("TcdPlan.Access.Sent") Then
                list.Add(Sent)
                hasRule = True
            End If
            If Not hasRule Then
                list.Add(Draft)
                list.Add(Ready)
                list.Add(Complete)
                list.Add(Sent)
                list.Add(NotValid)
                list.Add(Cancelled)
            End If
            Return list
        End Get
    End Property

End Class

' Уныкоде
