Imports Core
Imports Core.UI
Imports Entities
Imports Core.Dal
Imports Core.Bll
Imports Core.Dal.Expressions

Public Class frmSubscriptionDetail
    Implements IEditForm

    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Private _subscription As Subscription
    Private cash As PaymentType = Session.Get(Of PaymentType)(PaymentType.Cash)
    Private transfer As PaymentType = Session.Get(Of PaymentType)(PaymentType.Transfer)
    Private Kupons As PaymentType = Session.Get(Of PaymentType)(PaymentType.Kupons)

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return _dataIDs
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(Subscription)) = Guid.Empty Then 'add new activity
                _subscription = New Subscription(Session)
            Else 'edit existing User
                _subscription = Session.Get(Of Subscription)(value(GetType(Subscription)))
            End If
            bndSubscription.DataSource = _subscription
            bndDetails.DataSource = _subscription.SubscriptionDetail
            cmbPaymentType.Items.Add(cash)
            cmbPaymentType.Items.Add(transfer)
            cmbPaymentType.Items.Add(Kupons)
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

    Private Sub txtService_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtService.ButtonClick
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.SingleSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseIsSubscription", True))

        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            _subscription.Service = CType(frm.Selection, Services)
            _subscription.Price = _subscription.Service.DecimalValue
            If _subscription.Service.FourIntegerValue.HasValue Then
                _subscription.TimeCount = _subscription.Service.FourIntegerValue.Value
            Else
                MsgBox.Show("Abonementam nav norādīts apmeklējuma reižu skaits.")
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub
    Private Function Save() As Boolean
        If Not _subscription.IsValid Then
            MsgBox.Show("Nav aizpildīti visi obligāti aizpildāmie lauki.")
            Return False
        End If
        Dim addNew As Boolean = False
        If _subscription.Id = Guid.Empty Then
            addNew = True
        End If
        Session.SaveOrUpdate(_subscription)
        Session.Commit()
        If addNew Then
            _dataList.Add(PartnerSession.Get(Of Subscription)(_subscription.Id))
        End If
        Return True
    End Function

    Private Sub btnBay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBay.Click

        If bndSubscription.Current Is Nothing Then
            Return
        End If
        ''pārbaudam vai nav izmaiņas, kas jāsaglabā pirms čeka izdrukas
        If (_subscription.IsDirty) Then
            MsgBox.Show("Abonementa dati ir mainīti. Pirms drukāt čeku lûdzu saglabājiet izmaiņas.")
            Return
        End If
        For Each detail As SubscriptionDetail In _subscription.SubscriptionDetail
            If (detail.IsDirty) Then
                MsgBox.Show("Abonementa dati ir mainīti. Pirms drukāt čeku lûdzu saglabājiet izmaiņas.")
                Return
            End If
        Next

        If Not Core.UI.MsgBox.Show("Vai tiešām vēlaties veikt apmaksu?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Return
        End If
        ''ja ir norādīts apmaksas datums tad muzskatam ka apmaksa jau ir veikta
        If _subscription.PayTime.HasValue Then
            Core.UI.MsgBox.Show("Šim abonementam apmaksa jau ir veikta " + _subscription.PayTime.Value.ToShortDateString + ". Apmaksu pieņēma " + _subscription.UserAcceptedPayment.FullName + ".")
            Return
        End If
        If (_subscription.Service Is Nothing) Then
            Core.UI.MsgBox.Show("Nav izvēlētS abonements.")
            Return
        End If
        Dim file As String = System.IO.File.ReadAllText("C:\chd3550\fiscal\SALEPC.TXT")
        Dim temp As String
        Dim name As New System.Text.StringBuilder()
        If (_subscription.Service.Value.Length <= 31) Then
            name.Append("Comment: Text = """ & _subscription.Service.Value & """")
        Else
            For i As Integer = 0 To _subscription.Service.Value.Length Step 31
                If _subscription.Service.Value.Length > i + 31 Then
                    name.AppendLine("Comment: Text = """ & _subscription.Service.Value.Substring(i, 31) & """")
                Else
                    name.Append("Comment: Text = """ & _subscription.Service.Value.Substring(i) & """")
                End If
            Next i
        End If
        temp = file.Replace("$pakalpojums", name.ToString())
        Dim cena As String = _subscription.Price.ToString()
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
        temp = temp.Replace("$PakalpojumaKods", _subscription.Service.Code)
        If _subscription.Service.Reference Is Nothing Then
            temp = temp.Replace("$nodala", "5")
        Else
            temp = temp.Replace("$nodala", _subscription.Service.Reference.Code)
        End If
        Dim path As String = "RECIPEPC.TXT"
        System.IO.File.WriteAllText("C:\chd3550\fiscal\" & path, temp, System.Text.Encoding.Default)
        Dim command As New System.Text.StringBuilder()
        command.AppendLine("C:")
        command.AppendLine("cd \")
        command.AppendLine("cd chd3550")
        command.AppendLine("cd fiscal")
        command.AppendLine("chd_fdrv.exe " & path)
        System.IO.File.WriteAllText("C:\chd3550\fiscal\cmd.bat", command.ToString())
        Helper.RunShell("C:\chd3550\fiscal\cmd.bat")
        _subscription.PayTime = Now
        _subscription.UserAcceptedPayment = Context.Current.AuthenticatedUser
        Session.SaveOrUpdate(_subscription)
        Session.Commit()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ''pārbaudam vai ir norādīts abonements
        If _subscription.Service Is Nothing Then
            MsgBox.Show("Pirms apmeklējuma reižu ģenerēšanas lûdzu norādiet abonementu.")
            Return
        End If
        ''pārbaudam vai kādam no pakalpojumiem nav piesaistīta vizīte
        ''ja ir tad atjaunot sarakstu nav iespējams
        For Each detail As SubscriptionDetail In _subscription.SubscriptionDetail
            If Not detail.Visit Is Nothing Then
                MsgBox.Show("Ajaunot abonementa apmeklējuma reižu sarakstu nav iespējams jo kāda no apmeklējuma reizēm jau ir piesaistīta vizītei.")
                Return
            End If
        Next
        '' atrodsam abonementam piesaistīto pakalpojumu sarakstu 
        Dim cls As Entities(Of Services)
        cls = Entities(Of Services).GetAll(Session, New Eq("ReferenceSix", _subscription.Service))
        If (cls.Count = 0) Then
            MsgBox.Show("Abonementam nav norādīts apakšpakalpojums, kas tiks piesaistīts vizītēm.")
            Return
        End If
        ''ja vizīte nav piesaistīta tad fiziski dzēšam ārā visus iepriekšējos ierakstus
        For Each detail As SubscriptionDetail In _subscription.SubscriptionDetail
            If Not detail.Id = Guid.Empty Then
                Session.Delete(detail)
            End If
        Next
        _subscription.SubscriptionDetail.Clear()
        Session.Commit()

        For i As Integer = 1 To _subscription.TimeCount
            Dim val As New SubscriptionDetail(Session)
            val.Appointment = i
            val.Price = cls(0).DecimalValue
            val.Service = cls(0)
            _subscription.SubscriptionDetail.Add(val)
        Next
        bndDetails.DataSource = _subscription.SubscriptionDetail
    End Sub

    Private Sub txtVisit_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtVisit.ButtonClick
        If bndDetails.Current Is Nothing Then
            Return
        End If
        If _subscription.Patient Is Nothing Then
            MsgBox.Show("Nav norādīts klients.")
            Return
        End If
        Dim frm As New frmPatientVisitList(_subscription.Patient, CType(bndDetails.Current, SubscriptionDetail).Service)

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CType(bndDetails.Current, SubscriptionDetail).Visit = frm.SelectedVisit
        End If
    End Sub

    Private Sub btnSetPayTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPayTime.Click
        If _subscription Is Nothing Then
            Return
        End If
        If _subscription.IsDirty Then
            MsgBox.Show("Pirms apmaksas laika iuzstādīšanas lûdzu saglabājiet ierakstu.")
            Return
        End If
        If _subscription.PayTime.HasValue Then
            Dim answer As Windows.Forms.DialogResult = MsgBox.Show("Abonementa apmaksa jau ir veikta. Vai vēlaties mainīt apmaksas datumu un laiku?", MessageBoxButtons.YesNo, "Jautājums")
            If answer = Windows.Forms.DialogResult.No Then
                Return
            End If
        End If
        Dim frm As New frmSubscriptionPaymentSet()
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        key.Add(GetType(Subscription), _subscription.Id)
        frm.DataIDs = key
        frm.ShowDialog()
        Session.Refresh(_subscription)
        If Not _subscription.UserAcceptedPayment Is Nothing Then
            TextBox4.DataBindings("Text").ReadValue()
        End If
        If _subscription.PayTime.HasValue Then
            txtPayDate.DataBindings("EditValue").ReadValue()
        End If

    End Sub
End Class
