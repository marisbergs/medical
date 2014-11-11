Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.UI
Imports Entities

Public Class frmPresentCards

    Dim list As Entities(Of PresentCard)
    Private visitList As Entities(Of Visit)

    Public SelectedPresentCard As PresentCard

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub gbhPresentCards_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhPresentCards.OnAddNew
        Dim card As New PresentCard(Session)
        list.Add(card)
    End Sub

    Private Sub frmPresentCards_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        list = Entities(Of PresentCard).GetAll(Session)
        bndData.DataSource = list
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Save()
    End Sub

    Public Sub SetSelectionMode()
        gbhPresentCards.Visible = False
        btnExport.Visible = False
        btnBay.Visible = False
        btnsave.Visible = False
        btnClose.Visible = False

        btnOk.Visible = True
        FlowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight


    End Sub

    Private Function Save() As Boolean
        For Each x As PresentCard In bndData
            If Not x.IsValid Then
                Core.UI.MsgBox.HasErrorMessage()
                Return False
            End If
        Next
        For Each x As PresentCard In bndData
            Session.SaveOrUpdate(x)
        Next
        Session.Commit()
    End Function

    Private Sub gbhPresentCards_OnDelete(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.DeleteEventArgs) Handles gbhPresentCards.OnDelete
        If Not bndData.Current Is Nothing AndAlso CType(bndData.Current, PresentCard).Status = PresentCardState.Izveidota Then
            If Core.UI.MsgBox.DeleteMessage() = Windows.Forms.DialogResult.Yes Then
                args.CancelDelete = False
            Else
                args.CancelDelete = True
            End If
        End If
    End Sub

    Private Sub txtService_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtService.ButtonClick
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.SingleSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseIsPresentCard", True))

        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim card As PresentCard = CType(bndData.Current, PresentCard)
            card.Service = CType(frm.Selection, Services)
            card.Price = card.Service.DecimalValue
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        grdPresentCards.Export()
    End Sub

    Private Sub btnBay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBay.Click

        If bndData.Current Is Nothing Then
            Return
        End If
        If Not Core.UI.MsgBox.Show("Vai tiešām vēlaties veikt apmaksu?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Return
        End If
        Dim card As PresentCard = bndData.Current
        If Not card.Status = PresentCardState.Izveidota Then
            Core.UI.MsgBox.Show("Apmaksu var veikt tikai dāvanu kartēm ar statusu Izveidota.")
            Return
        End If
        If (card.Service Is Nothing) Then
            Core.UI.MsgBox.Show("Nav izvēlēta dāvanu karte.")
            Return
        End If
        Dim file As String = System.IO.File.ReadAllText("C:\chd3550\fiscal\SALEPC.TXT")
        Dim temp As String
        Dim name As New System.Text.StringBuilder()
        If (card.Service.Value.Length <= 31) Then
            name.Append("Comment: Text = """ & card.Service.Value & """")
        Else
            For i As Integer = 0 To card.Service.Value.Length Step 31
                If card.Service.Value.Length > i + 31 Then
                    name.AppendLine("Comment: Text = """ & card.Service.Value.Substring(i, 31) & """")
                Else
                    name.Append("Comment: Text = """ & card.Service.Value.Substring(i) & """")
                End If
            Next i
        End If
        temp = file.Replace("$pakalpojums", name.ToString())
        Dim cena As String = card.Price.ToString()
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
        temp = temp.Replace("$PakalpojumaKods", card.Service.Code)
        If card.Service.Reference Is Nothing Then
            temp = temp.Replace("$nodala", "5")
        Else
            temp = temp.Replace("$nodala", card.Service.Reference.Code)
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
        card.Status = PresentCardState.Nopirkta
        Session.SaveOrUpdate(card)
        Session.Commit()
    End Sub

    Private Sub bndData_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndData.PositionChanged
        If bndData.Current Is Nothing Then
            Return
        End If
        cmbState.Items.Clear()
        Dim card As PresentCard = bndData.Current
        If card.Status = PresentCardState.Izveidota Or card.Status = PresentCardState.Nopirkta Or card.Status = PresentCardState.Bezmaksas Then
            cmbState.Items.Add(PresentCardState.Izveidota)
            cmbState.Items.Add(PresentCardState.Nopirkta)
            cmbState.Items.Add(PresentCardState.Bezmaksas)
        Else
            cmbState.Items.Add(card.Status)
        End If
    End Sub

    Private Sub GetVisits()
        If bndData.Current Is Nothing Then
            Return
        End If
        visitList = Entities(Of Visit).GetAll(Session, New Expressions.Eq("VisitServices.PresentCard", CType(bndData.Current, PresentCard).Id))
        For Each x As Visit In visitList

        Next
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        If bndData.Current Is Nothing Then
            DialogResult = DialogResult.Cancel
            Close()
        End If
        SelectedPresentCard = CType(bndData.Current, PresentCard)
        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class
