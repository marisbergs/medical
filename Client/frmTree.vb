Imports Core
Imports Core.UI
Imports Core.Dal
Imports Core.Bll
Imports Entities

Public Class frmTree
    Implements IEditForm

#Region "Data"
    Public _patient As Patient
    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Public NewForVisit As Boolean = False
    Public Visit As Visit

    Private previousNode As String = ""
    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            'Return Nothing
            Return _dataIDs
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(Patient)) = Guid.Empty Then 'add new User
                _patient = New Patient(Session)
                _patient.CreatePlace = LocalSettings.GetValueByKey(Session, SystemInformation.ComputerName).Value
                _patient.PatientStatus = "J"
            Else 'edit existing User
                _patient = Session.Get(Of Patient)(value(GetType(Patient)))
            End If
            Text = _patient.ToString & " " & _patient.Number
            Dim path As SystemParameter = Session.Get(Of SystemParameter)("ENC_PATH")
            btnSinchronization.Visible = System.IO.File.Exists(path.Value)
        End Set
    End Property
    Public Property DataList() As System.Collections.IList Implements Core.UI.IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As System.Collections.IList)
            _dataList = value
        End Set
    End Property
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmGynaecology
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        key.Add(GetType(Gynaecology), Guid.Empty)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not _patient.IsValid Then
            Core.UI.MsgBox.HasErrorMessage()
            Exit Sub
        End If

        Dim pat As Entities(Of Patient)
        pat = Entities(Of Patient).GetAll(Session, _
                New Expressions.NotEq("Id", _patient.Id), _
                New Expressions.IsNull("DeleteTime"), _
                New Expressions.Eq("Code", _patient.Code))
        If pat.Count > 0 Then
            MsgBox.Show("Citam klientam jau ir reģistrēts šāds personas kods.")
            Return
        End If

        Dim jauns As Boolean = (_patient.Id = Guid.Empty)
        If jauns Then
            AddTemporaryNumber()
            'Dim chars(26) As String
            'chars(1) = "A"
            'chars(2) = "B"
            'chars(3) = "C"
            'chars(4) = "D"
            'chars(5) = "E"
            'chars(6) = "F"
            'chars(7) = "G"
            'chars(8) = "H"
            'chars(9) = "I"
            'chars(10) = "J"
            'chars(11) = "K"
            'chars(12) = "L"
            'chars(13) = "M"
            'chars(14) = "N"
            'chars(15) = "O"
            'chars(16) = "P"
            'chars(17) = "Q"
            'chars(18) = "R"
            'chars(19) = "S"
            'chars(20) = "T"
            'chars(21) = "U"
            'chars(22) = "V"
            'chars(23) = "W"
            'chars(24) = "X"
            'chars(25) = "Y"
            'chars(26) = "Z"
            'Dim patients As Entities(Of Patient) = Entities(Of Patient).GetAllOrderBy(Session, New NHibernate.Expression.Order("Number", False))
            'If patients.Count > 0 Then
            '    Dim latest As String = patients(0).Number
            '    Dim start As String = latest.Substring(0, 2)
            '    Dim endNumber As Integer
            '    Integer.TryParse(latest.Substring(2), endNumber)
            '    If (endNumber < 99) Then
            '        If (endNumber + 1).ToString().Length = 1 Then
            '            _patient.Number = start & "0" & endNumber + 1
            '        Else
            '            _patient.Number = start & endNumber + 1
            '        End If
            '    Else
            '        Dim first As String = start.Substring(0, 1)
            '        Dim second As String = start.Substring(1)

            '        Dim current As Integer

            '        For i As Integer = 1 To chars.Length
            '            If chars(i) = second Then
            '                current = i
            '                Exit For
            '            End If
            '        Next

            '        If chars.Length - 1 > current Then
            '            second = chars(current + 1)
            '        Else
            '            For i As Integer = 1 To chars.Length
            '                If chars(i) = first Then
            '                    current = i
            '                    Exit For
            '                End If
            '            Next
            '            first = chars(current + 1)
            '            second = chars(1)
            '        End If
            '        _patient.Number = first & second & "01"
            '    End If
            'End If
        End If
        If (Not _patient.BonusPointsRecive Is Nothing) Then
            For Each x As BonusPoints In _patient.BonusPointsRecive.ActiveItemsWithoutEmpty
                If x.Id = Guid.Empty Then
                    Dim list As Entities(Of SMSMessages) = Entities(Of SMSMessages).GetAll(CType(FindForm(), frmBase).Session, New Expressions.Eq("Type", SMSType.BonusPointsAdded))
                    If (list.Count = 0) Then
                        MsgBox.Show("Nav nodefinēts isziņas teksts. Lai to izdarītu veiciet sekojošas darbības Administrēšana -> Îsziņu administrēšana. Pievienojiet jaunu ierakstu kur kā veidu norādiet " & SMSType.BonusPointsAdded.Name & ".")
                        Return
                    ElseIf (list.Count > 1) Then
                        MsgBox.Show("Îsziņu administrēšanā norādītas vairākas aktīvas īsziņas. Nevajadzīgos ierakstus jāizdzēš atstājot tikai vienu")
                        Return
                    Else
                        Dim sms As SMSMessages = list(0)
                        If sms.DaysBefore = 0 Then
                            If sms.SendTime.TimeOfDay.TotalMinutes >= DateTime.Now.TimeOfDay.TotalMinutes Then
                                Dim mesage As New SMSSendingList()
                                mesage.Patient = _patient
                                mesage.Sended = SmsSendStatus.NotSent
                                mesage.Message = String.Format(sms.MeesageText, x.Value, _patient.BonusPointsTotal)
                                mesage.SendTime = Now.Date.AddHours(sms.SendTime.Hour).AddMinutes(sms.SendTime.Minute)
                                CType(FindForm(), frmBase).Session.SaveOrUpdate(mesage)
                                CType(FindForm(), frmBase).Session.Commit()
                            Else
                                Dim mesage As New SMSSendingList()
                                mesage.Patient = _patient
                                mesage.Sended = SmsSendStatus.NotSent
                                mesage.Message = String.Format(sms.MeesageText, x.Value, _patient.BonusPointsTotal)
                                mesage.SendTime = Now.Date.AddDays(1).AddHours(sms.SendTime.Hour).AddMinutes(sms.SendTime.Minute)
                                CType(FindForm(), frmBase).Session.SaveOrUpdate(mesage)
                                CType(FindForm(), frmBase).Session.Commit()
                            End If
                        ElseIf sms.DaysBefore = -1 Then
                            Dim mesage As New SMSSendingList()
                            mesage.Patient = _patient
                            mesage.Sended = SmsSendStatus.NotSent
                            mesage.Message = String.Format(sms.MeesageText, x.Value, _patient.BonusPointsTotal)
                            mesage.SendTime = Now.AddMinutes(sms.SendTime.TimeOfDay.TotalMinutes)
                            CType(FindForm(), frmBase).Session.SaveOrUpdate(mesage)
                        End If
                    End If
                End If
            Next
        End If
        Session.SaveOrUpdate(_patient)
        Session.Commit()
        If jauns Then
            trvList.Enabled = True
            DataList.Add(PartnerSession.Get(Of Patient)(_patient.Id))
        End If
        If NewForVisit Then
            Visit.Patient = PartnerSession.Get(Of Patient)(_patient.Id)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub AddTemporaryNumber()
        If _patient Is Nothing Then
            Return
        End If

        ''atlasam visus pacientus, kuriem ir pagaidu numurs 
        Dim patients As Entities(Of Patient) = Entities(Of Patient).GetAllOrderBy(Session, New NHibernate.Expression.Order("NumberTemporary", True), New Expressions.IsNotNull("NumberTemporary"))

        Dim lst As New List(Of String)

        ''saliekam listā visus pagaidu numurus lai bûtu vieglāk atrast izmantojot contains metodi
        For Each patient As Patient In patients
            lst.Add(patient.NumberTemporary)
        Next
        Dim s As String = ""
        For c As Integer = 1 To 99999
            If c < 10 Then
                s = "0000"
            ElseIf c < 100 Then
                s = "000"
            ElseIf c < 1000 Then
                s = "00"
            ElseIf c < 10000 Then
                s = "0"
            End If
            If Not lst.Contains(s & c) Then
                _patient.NumberTemporary = s & c
                Return
            End If
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub trvList_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvList.AfterSelect
        If previousNode = e.Node.Name Then
            Return
        End If
        If e.Node.Name = "nodDefault" Then
            Dim ctl As New ctlPatientBasicInformation()
            ctl.Dock = DockStyle.Fill
            panControls.Controls.Clear()
            panControls.Controls.Add(ctl)
            ctl.cmbLanguage.Properties.Items.AddRange(Entities(Of Language).GetAll(Session, New Expressions.IsNull("DeleteTime")))
            ctl.cmbPatientType.Properties.Items.AddRange(Entities(Of PatientType).GetAll(Session, New Expressions.IsNull("DeleteTime")))
            ctl.bndPatient.DataSource = _patient
            SplitContainer1.Visible = True
            If _patient.Id = Guid.Empty Then
                ctl.Focus()
                trvList.Enabled = False
            End If
        ElseIf e.Node.Name = "nodNewVisits" Then
            Dim ctl As New ctlVisits(False)
            ctl.Dock = DockStyle.Fill
            panControls.Controls.Clear()
            panControls.Controls.Add(ctl)
            SplitContainer1.Visible = False
        ElseIf e.Node.Name = "nodPreviousVisits" Then
            Dim ctl As New ctlVisits(True)
            ctl.Dock = DockStyle.Fill
            panControls.Controls.Clear()
            panControls.Controls.Add(ctl)
            SplitContainer1.Visible = False
        ElseIf e.Node.Name = "nodPrescription" Then
            Dim ctl As New ctlPrescription
            ctl.Dock = DockStyle.Fill
            panControls.Controls.Clear()
            panControls.Controls.Add(ctl)
            SplitContainer1.Visible = False
        ElseIf e.Node.Name = "nodRtg" Then
            Dim ctl As New ctlRtgSummary
            ctl.Dock = DockStyle.Fill
            panControls.Controls.Clear()
            panControls.Controls.Add(ctl)
            SplitContainer1.Visible = False
        ElseIf e.Node.Name = "nodRefer" Then
            Dim ctl As New ctlRefer
            ctl.Dock = DockStyle.Fill
            panControls.Controls.Clear()
            panControls.Controls.Add(ctl)
            SplitContainer1.Visible = False
        ElseIf e.Node.Name = "nodAttachments" Then
            Dim ctl As New ctlAttachment
            ctl.Dock = DockStyle.Fill
            panControls.Controls.Clear()
            panControls.Controls.Add(ctl)
            SplitContainer1.Visible = False
        ElseIf e.Node.Name = "nodCheckUp" Then
            Dim ctl As New ctlCheckUp
            ctl.Dock = DockStyle.Fill
            panControls.Controls.Clear()
            panControls.Controls.Add(ctl)
            SplitContainer1.Visible = False
        ElseIf e.Node.Name = "nodPatientCard" Then
            Dim ctl As New ctlPatientCards
            ctl.Dock = DockStyle.Fill
            panControls.Controls.Clear()
            panControls.Controls.Add(ctl)
            SplitContainer1.Visible = False
        End If
        previousNode = e.Node.Name
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim template As Template
        If (_patient.BirthDate.HasValue AndAlso (Date.Now.Year - _patient.BirthDate.Value.Year) < 18) Then
            template = Session.Get(Of Template)(template.PatientRegistrationWithGuardians)
        ElseIf (_patient.BirthDate.HasValue AndAlso (Date.Now.Year - _patient.BirthDate.Value.Year) = 18 AndAlso Date.Now.DayOfYear < _patient.BirthDate.Value.DayOfYear) Then
            template = Session.Get(Of Template)(template.PatientRegistrationWithGuardians)
        Else
            template = Session.Get(Of Template)(template.PatientRegistration)
        End If
        _patient.GenerateDocument("D01", template)
    End Sub

    Private Sub itmNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmNew.Click
        Dim frm As New frmPrescription
        frm.Session = Nothing
        frm.PartnerSession = Session
        Dim data As New Dictionary(Of Type, Guid)
        data.Add(GetType(Prescription), Guid.Empty)
        'add parent CMCase id
        data.Add(GetType(Patient), _patient.Id)

        frm.DataIDs = data
        frm.DataList = CType(panControls.Controls(0), ctlPrescription).bndPrescription.List
        frmMain.AddChild(frm)
    End Sub

    Private Sub trvList_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles trvList.NodeMouseClick
        trvList.SelectedNode = e.Node
    End Sub

    Private Sub trvList_NodeMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles trvList.NodeMouseDoubleClick
        trvList.SelectedNode = e.Node
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim frm As frmPlanner = Nothing
        If _patient.BlackList Then
            MsgBox.Show("Klients(e) " & _patient.FullName & "  ir bloķēts un iekļauts melnajā sarakstā. Jaunu vizīti šim klientam nav iespējams ieplānot.")
            Return
        End If
        For Each x As Form In frmMain.MdiChildren
            If x.GetType().Name = GetType(frmPlanner).Name Then
                frm = x
                frm.SetPatient(_patient, Nothing, Nothing)
                frm.Activate()
            End If
        Next
        If frm Is Nothing Then
            frm = New frmPlanner()
            frm.SetPatient(_patient, Nothing, Nothing)
            frmMain.AddChild(frm)
        End If
    End Sub

    Private Sub btnSinchronization_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinchronization.Click
        If Not _patient.BirthDate.HasValue Then
            Core.UI.MsgBox.Show("Nav norādīts sinhronizācijai obligātais lauks dzimšanas datums")
            Return
        End If
        Dim path As SystemParameter = Session.Get(Of SystemParameter)("ENC_PATH")
        Dim connections As System.Configuration.ConnectionStringSettingsCollection = System.Configuration.ConfigurationManager.ConnectionStrings
        Dim conn As System.Configuration.ConnectionStringSettings = connections("Client.My.MySettings.TwinDataConnectionString")

        Dim con As New System.Data.OleDb.OleDbConnection(String.Format(conn.ConnectionString, path.Value))
        con.Open()
        Dim command As New System.Data.OleDb.OleDbCommand()
        command.Connection = con
        command.CommandType = CommandType.Text
        command.CommandText = "select * from Patients_1 where PatientID='" & _patient.Id.ToString() & "'"
        Dim reader As System.Data.OleDb.OleDbDataReader = command.ExecuteReader()
        If Not reader.HasRows() Then
            reader.Close()
            command.CommandText = "Insert Into Patients_1(PatientID, [Last Name_0001], [First Name_0002], [Date of Birth_0003])VALUES('" _
            & _patient.Id.ToString() & "', '" _
            & _patient.Surname & "', '" _
            & _patient.Name & "', '" _
            & _patient.BirthDate.Value.Year & "-" & IIf(_patient.BirthDate.Value.Month.ToString().Length = 1, "0" & _patient.BirthDate.Value.Month, _patient.BirthDate.Value.Month) & "-" & _patient.BirthDate.Value.Day & "')"
            command.ExecuteNonQuery()
            command.CommandText = "Insert Into Patients_2(PatientID, [Street Address_0007], [Phone Number_0013])VALUES('" _
            & _patient.Id.ToString() & "', '" _
            & _patient.Address & "', '" _
            & _patient.MobilePhone & "')"
            command.ExecuteNonQuery()
            command.CommandText = "Insert Into Patients_3(PatientID)VALUES('" _
            & _patient.Id.ToString() & "')"
            command.ExecuteNonQuery()
        End If
        con.Close()
        command.Cancel()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim frm As New frmAttachment
        frm.Session = Nothing
        frm.PartnerSession = Session
        Dim data As New Dictionary(Of Type, Guid)
        data.Add(GetType(PatientDocument), Guid.Empty)
        'add parent CMCase id
        data.Add(GetType(Patient), _patient.Id)

        frm.DataIDs = data
        frm.DataList = CType(panControls.Controls(0), ctlAttachment).bndDocumentList.List
        frmMain.AddChild(frm)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim frm As New frmRtgSummary
        frm.Session = Nothing
        frm.PartnerSession = Session
        Dim data As New Dictionary(Of Type, Guid)
        data.Add(GetType(RtgSummary), Guid.Empty)
        'add parent CMCase id
        data.Add(GetType(Patient), _patient.Id)

        frm.DataIDs = data
        frm.DataList = CType(panControls.Controls(0), ctlRtgSummary).bndRtgSummary.List
        frmMain.AddChild(frm)
    End Sub

    Private Sub itmPatientDentistCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmPatientDentistCard.Click
        Dim template As Template = Session.Get(Of Template)(template.DenticalCard)
        Dim doc As New DenticalCard(Session, _patient.Id)
        doc.Creator = Context.Current.AuthenticatedUser
        doc.GenerateDocument("D06", Session)
        Session.SaveOrUpdate(doc)
        Session.Commit()
    End Sub
End Class
