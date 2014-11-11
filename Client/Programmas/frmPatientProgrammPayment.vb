Imports Core
Imports Entities
Imports Core.UI
Imports Core.Dal
Imports Core.Bll

Public Class frmPatientProgrammPayment
    Implements IEditForm

    Private _edit As PatientProgrammPayment
    Private _dataList As IList
    Private _programma As PatientProgramm
    Private cash As PaymentType = Session.Get(Of PaymentType)(PaymentType.Cash)
    Private transfer As PaymentType = Session.Get(Of PaymentType)(PaymentType.Transfer)
    Private Kupons As PaymentType = Session.Get(Of PaymentType)(PaymentType.Kupons)

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return Nothing
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(PatientProgrammPayment)) = Guid.Empty Then 'add new
                _programma = Session.Get(Of PatientProgramm)(value(GetType(PatientProgramm)))
                _edit = New PatientProgrammPayment(Session, _programma)
            Else 'edit existing
                _edit = Session.Get(Of PatientProgrammPayment)(value(GetType(PatientProgrammPayment)))
            End If
            bndPatientProgramm.DataSource = _edit.PatientProgramm
            bndPatientProgrammPayment.DataSource = _edit
            bndPatientProgrammPaymentServices.DataSource = _edit.PaymentServices
            ''cmbPaymentType.Items.Add(Nothing)
            cmbPaymentType.Items.Add(cash)
            cmbPaymentType.Items.Add(transfer)
            cmbPaymentType.Items.Add(Kupons)
        End Set
    End Property

    Public Property DataList() As System.Collections.IList Implements Core.UI.IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As IList)
            _dataList = value
        End Set
    End Property

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not _edit.IsValid Then
            MsgBox.Show("Pirms saglabāt izlabojiet ievadlauku kļūdas.")
            Exit Sub
        End If
        Dim jauns As Boolean = _edit.Id = Guid.Empty
        Session.SaveOrUpdate(_edit)
        Session.Commit()
        If jauns Then
            DataList.Add(PartnerSession.Get(Of PatientProgrammPayment)(_edit.Id))
        End If
    End Sub

    Private Sub gbhPaymentService_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhPaymentService.OnAddNew
        ''sadabūjam programmas apmaksas pakalpojumus
        Dim itm As Entities(Of ProgrammTemplateService)
        itm = Entities(Of ProgrammTemplateService).GetAll(Session, New Expressions.Eq("ProgrammTemplate", _edit.PatientProgramm.ProgrammTemplate), New Expressions.Eq("PaymentGroup", True), New Expressions.IsNull("DeleteTime"))
        ''izveidojam id kolekciju kurā saliekam jau esošos izvelētos apmaksas pakalpojumus
        Dim obj As IList(Of Guid) = New List(Of Guid)
        ''saliekam tos pakalpojumus, no kuriem var izvēlētis
        For Each p As ProgrammTemplateService In itm
            obj.Add(p.Service.Id)
        Next
        ''izņemam ārā jau izvēlētos
        For Each x As PatientProgrammPaymentService In _edit.PaymentServices.ActiveItemsWithoutEmpty
            If obj.Contains(x.Service.Id) Then
                obj.Remove(x.Service.Id)
            End If
        Next
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseInClassifier", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each x As Services In CType(frm.Selection, Entities(Of Services))
                Dim o As New PatientProgrammPaymentService(Session)
                o.Service = x
                For Each p As ProgrammTemplateService In itm
                    If x.Id = p.Service.Id Then
                        o.Price = p.Price
                    End If
                Next
                _edit.PaymentServices.Add(o)
            Next
        End If
    End Sub

    Private Sub gbhPaymentService_OnDelete(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.DeleteEventArgs) Handles gbhPaymentService.OnDelete
        args.CancelDelete = True
        If bndPatientProgrammPaymentServices.Current Is Nothing Then
            Return
        End If
        If _edit.PaymentDate.HasValue Then
            MsgBox.Show("Ierakstu nevar dzēst jo ir veikta apmaksa!")
            Return
        End If
        If MsgBox.Show("Vai tiešām vēlaties dzēst apmaksas pakalpojumu?") = Windows.Forms.DialogResult.Yes Then
            Dim obj As PatientProgrammPaymentService = CType(bndPatientProgrammPaymentServices.Current, PatientProgrammPaymentService)
            obj.IsActive = False
        End If
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        If _edit Is Nothing Then
            Return
        End If
        ''pārbaudam vai nav izmaiņas, kas jāsaglabā pirms čeka izdrukas
        If (_edit.IsDirty) Then
            MsgBox.Show("Programmas apmaksas dati ir mainīti. Pirms drukāt čeku lūdzu saglabājiet izmaiņas.")
            Return
        End If
        For Each detail As PatientProgrammPaymentService In _edit.PaymentServices.ActiveItemsWithoutEmpty
            If (detail.IsDirty) Then
                MsgBox.Show("Programmas apmaksas dati ir mainīti. Pirms drukāt čeku lūdzu saglabājiet izmaiņas.")
                Return
            End If
        Next

        If Not Core.UI.MsgBox.Show("Vai tiešām vēlaties veikt apmaksu?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Return
        End If
        ''ja ir norādīts apmaksas datums tad muzskatam ka apmaksa jau ir veikta
        If _edit.PaymentDate.HasValue Then
            Core.UI.MsgBox.Show("Šim maksājuma apmaksa jau ir veikta " + _edit.PaymentDate.Value.ToShortDateString + ". Apmaksu pieņēma " + _edit.PaymentUser.FullName + ".")
            Return
        End If
        If (_edit.PaymentServices.ActiveItemsWithoutEmpty.Count = 0) Then
            Core.UI.MsgBox.Show("Nav norādīts neviens pakalpojums, kuram veikt apmaksu.")
            Return
        End If
        Dim file As String = System.IO.File.ReadAllText("C:\chd3550\fiscal\SALE.TXT")
        file = file.Replace("$vards", _edit.PatientProgramm.Patient.Name & IIf(String.IsNullOrEmpty(_edit.PatientProgramm.Patient.SecondName), "", " " & _edit.PatientProgramm.Patient.SecondName))
        file = file.Replace("$uzvards", _edit.PatientProgramm.Patient.Surname)
        file = file.Replace("$kods", _edit.PatientProgramm.Patient.Code)
        file = file.Replace("$adrese", IIf(String.IsNullOrEmpty(_edit.PatientProgramm.Patient.Address), "", _edit.PatientProgramm.Patient.Address))
        Dim start As Integer = file.IndexOf("$01")
        Dim beigas As Integer = file.IndexOf("$_")
        Dim str As String = file.Substring(start, beigas - start + 2)
        Dim res As New System.Text.StringBuilder()
        For Each x As PatientProgrammPaymentService In _edit.PaymentServices.ActiveItemsWithoutEmpty
            Dim temp As String
            Dim name As New System.Text.StringBuilder()
            If (x.Service.Value.Length <= 31) Then
                name.Append("Comment: Text = """ & x.Service.Value & """")
            Else
                For i As Integer = 0 To x.Service.Value.Length Step 31
                    If x.Service.Value.Length > i + 31 Then
                        name.AppendLine("Comment: Text = """ & x.Service.Value.Substring(i, 31) & """")
                    Else
                        name.Append("Comment: Text = """ & x.Service.Value.Substring(i) & """")
                    End If
                Next i
            End If
            temp = str.Replace("$pakalpojums", name.ToString())
            temp = temp.Replace("$_", "")
            temp = temp.Replace("$01", "")
            If x.Service.Reference Is Nothing Then
                temp = temp.Replace("$nodala", "5")
            Else
                temp = temp.Replace("$nodala", x.Service.Reference.Code)
            End If
            Dim t As String = temp
            Dim cena As String = x.Price.ToString()
            If x.Price > 0 Then
                If cena.Contains(".") OrElse cena.Contains(",") Then
                    If cena.Contains(",") Then
                        cena = cena.Replace(",", ".")
                    End If
                    If cena.Length - cena.IndexOf(".") < 3 Then
                        cena &= "0"
                    End If
                Else
                    cena &= ".00"
                End If
                temp = temp.Replace("$cena", cena)
                temp = temp.Replace("$PakalpojumaKods", x.Service.Code)
                res.AppendLine(temp)
            End If
        Next
        file = file.Replace(str, res.ToString().Trim())
        Dim path As String = "RECIPE.TXT"
        System.IO.File.WriteAllText("C:\chd3550\fiscal\" & path, file, System.Text.Encoding.Default)
        Dim command As New System.Text.StringBuilder()
        command.AppendLine("C:")
        command.AppendLine("cd \")
        command.AppendLine("cd chd3550")
        command.AppendLine("cd fiscal")
        command.AppendLine("chd_fdrv.exe " & path)
        System.IO.File.WriteAllText("C:\chd3550\fiscal\cmd.bat", command.ToString())
        Helper.RunShell("C:\chd3550\fiscal\cmd.bat")
        _edit.PaymentDate = Now
        _edit.PaymentUser = Context.Current.AuthenticatedUser
        _edit.PatientProgramm.ResetPaymentStatuss()
        btnSave_Click(btnSave, New EventArgs())
    End Sub

    Private Sub btnSetPayTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPayTime.Click
        If _edit Is Nothing Then
            Return
        End If
        If _edit.IsDirty Then
            MsgBox.Show("Pirms apmaksas laika iuzstādīšanas lūdzu saglabājiet ierakstu.")
            Return
        End If
        _edit.PatientProgramm.ResetPaymentStatuss()
        If _edit.PaymentDate.HasValue Then
            Dim answer As Windows.Forms.DialogResult = MsgBox.Show("Programmas apmaksa jau ir veikta. Vai vēlaties mainīt apmaksas datumu un laiku?", MessageBoxButtons.YesNo, "Jautājums")
            If answer = Windows.Forms.DialogResult.No Then
                Return
            End If
        End If
        Dim frm As New frmProgrammPaymentSet()
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        key.Add(GetType(PatientProgrammPayment), _edit.Id)
        frm.DataIDs = key
        frm.ShowDialog()
        Session.Refresh(_edit)
        If Not _edit.PaymentUser Is Nothing Then
            TextBox4.DataBindings("Text").ReadValue()
        End If
        If _edit.PaymentDate.HasValue Then
            TextBox3.DataBindings("Text").ReadValue()
        End If
        _edit.PatientProgramm.ResetPaymentStatuss()
    End Sub
End Class
