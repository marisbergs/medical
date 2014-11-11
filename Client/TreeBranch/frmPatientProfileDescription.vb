Imports Core
Imports Core.UI
Imports Entities

Public Class frmPatientProfileDescription
    Implements IEditForm

    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Private _editedObject As PatientProfileDescription

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return Nothing
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(PatientProfileDescription)) = Guid.Empty Then 'add new User
                Dim patient As Patient = Session.Get(Of Patient)(value(GetType(Patient)))
                _editedObject = New PatientProfileDescription(Session, patient)
            Else 'edit existing
                _editedObject = Session.Get(Of PatientProfileDescription)(value(GetType(PatientProfileDescription)))
            End If
            bndPatientProfileDescription.DataSource = _editedObject
            bndProfileDescriptioDiscountServices.DataSource = _editedObject.DiscountService
            bndProfileDescriptionFreeServices.DataSource = _editedObject.FreeService
            gbhFreeServices.ShowActive = True
            GridButtonHelper1.ShowActive = True
            If _editedObject.Profile Is Nothing Then
                SetPermissions(False)
            End If
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

    Private Sub SetPermissions(ByVal can As Boolean)
        GroupBox2.Enabled = can
        GroupBox3.Enabled = can
        NumberTextBox.Enabled = can
        DateEdit1.Enabled = can
        DateEdit2.Enabled = can
        DateEdit3.Enabled = can
        DateEdit4.Enabled = can
        SpinEdit1.Enabled = can
        SpinEdit2.Enabled = can
    End Sub

    Private Sub txtProfile_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtProfile.ButtonClick
        Dim frm As New frmPrimarasAprupesProfiluSaraksts()
        frm.SetSelectionMode()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim obj As ProfileDescription = Session.Get(Of ProfileDescription)(frm.Selected.Id)
            _editedObject.Profile = obj.Profile
            _editedObject.Count = obj.Count
            _editedObject.Price = obj.Price

            '/dzēšam ārā vecos ierakstus
            For i As Integer = (_editedObject.FreeService.ActiveItemsWithoutEmpty.Count - 1) To 0 Step -1
                If CType(_editedObject.FreeService(i), PatientProfileDescriptionService).Id = Guid.Empty Then
                    _editedObject.FreeService.RemoveAt(i)
                Else
                    CType(_editedObject.FreeService(i), PatientProfileDescriptionService).IsActive = False
                End If
            Next

            For i As Integer = (_editedObject.DiscountService.ActiveItemsWithoutEmpty.Count - 1) To 0 Step -1
                If CType(_editedObject.DiscountService(i), PatientProfileDescriptionService).Id = Guid.Empty Then
                    _editedObject.DiscountService.RemoveAt(i)
                Else
                    CType(_editedObject.DiscountService(i), PatientProfileDescriptionService).IsActive = False
                End If
            Next

            For Each itm As ProfileDescriptionService In obj.FreeService.ActiveItemsWithoutEmpty
                Dim o As New PatientProfileDescriptionService(Session)
                o.Service = itm.Service
                o.FreeGroup = 1
                _editedObject.FreeService.Add(o)
            Next

            For Each itm As ProfileDescriptionService In obj.DiscountService.ActiveItemsWithoutEmpty
                Dim o As New PatientProfileDescriptionService(Session)
                o.Service = itm.Service
                o.FreeGroup = 0
                o.Price = itm.Price
                _editedObject.DiscountService.Add(o)
            Next
            SetPermissions(True)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not _editedObject.IsValid Then
            Core.UI.MsgBox.Show("Pierms sadlabāšanas aizpildiet visus obligāti aizpildāmos laukus.")
            Return
        End If
        Dim jauns As Boolean = _editedObject.Id = Guid.Empty
        Session.SaveOrUpdate(_editedObject)
        Session.Commit()
        If jauns Then
            DataList.Add(PartnerSession.Get(Of PatientProfileDescription)(_editedObject.Id))
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If bndPatientProfileDescription.Current Is Nothing Then
            Return
        End If
        ''pārbaudam vai nav izmaiņas, kas jāsaglabā pirms čeka izdrukas
        If (_editedObject.IsDirty) Then
            MsgBox.Show("Primārās aprūpes kartes dati ir mainīti. Pirms drukāt čeku lūdzu saglabājiet izmaiņas.")
            Return
        End If
        For Each detail As PatientProfileDescriptionService In _editedObject.FreeService.ActiveItemsWithoutEmpty
            If (detail.IsDirty) Then
                MsgBox.Show("Primārās aprūpes kartes dati ir mainīti. Pirms drukāt čeku lūdzu saglabājiet izmaiņas.")
                Return
            End If
        Next
        For Each detail As PatientProfileDescriptionService In _editedObject.DiscountService.ActiveItemsWithoutEmpty
            If (detail.IsDirty) Then
                MsgBox.Show("Primārās aprūpes kartes dati ir mainīti. Pirms drukāt čeku lūdzu saglabājiet izmaiņas.")
                Return
            End If
        Next

        If Not Core.UI.MsgBox.Show("Vai tiešām vēlaties veikt apmaksu?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Return
        End If
        ''ja ir norādīts apmaksas datums tad muzskatam ka apmaksa jau ir veikta
        If _editedObject.PayDate.HasValue Then
            Core.UI.MsgBox.Show("Šai primārās aprūpes kartei apmaksa jau ir veikta " + _editedObject.PayDate.Value.ToShortDateString + ".")
            Return
        End If
        If (_editedObject.Profile Is Nothing) Then
            Core.UI.MsgBox.Show("Nav izvēlētS primārās aprūpes kartes veids.")
            Return
        End If
        Dim file As String = System.IO.File.ReadAllText("C:\chd3550\fiscal\SALEPC.TXT")
        Dim temp As String
        Dim name As New System.Text.StringBuilder()
        If (_editedObject.Profile.Value.Length <= 31) Then
            name.Append("Comment: Text = """ & _editedObject.Profile.Value & """")
        Else
            For i As Integer = 0 To _editedObject.Profile.Value.Length Step 31
                If _editedObject.Profile.Value.Length > i + 31 Then
                    name.AppendLine("Comment: Text = """ & _editedObject.Profile.Value.Substring(i, 31) & """")
                Else
                    name.Append("Comment: Text = """ & _editedObject.Profile.Value.Substring(i) & """")
                End If
            Next i
        End If
        temp = file.Replace("$pakalpojums", name.ToString())
        Dim cena As String = _editedObject.Price.ToString()
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
        temp = temp.Replace("$PakalpojumaKods", _editedObject.Profile.Code)
        If _editedObject.Profile.Reference Is Nothing Then
            temp = temp.Replace("$nodala", "5")
        Else
            temp = temp.Replace("$nodala", _editedObject.Profile.Reference.Code)
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
        _editedObject.PayDate = Now
        _editedObject.PaymentAcceptedByUser = Context.Current.AuthenticatedUser
        Session.SaveOrUpdate(_editedObject)
        Session.Commit()
    End Sub
End Class
