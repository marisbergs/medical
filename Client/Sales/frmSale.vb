
Imports Core
Imports Core.Bll
Imports Core.UI
Imports Entities

Public Class frmSale
    Implements IEditForm

    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Private _sale As Sale

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return _dataIDs
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(Sale)) = Guid.Empty Then 'add new activity
                _sale = New Sale(Session)
            Else 'edit existing User
                _sale = Session.Get(Of Sale)(value(GetType(Sale)))
            End If
            bndSale.DataSource = _sale
            bndSaleProduct.DataSource = _sale.Products
            gbhVisitServices.ShowActive = True
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

    Private Sub gbhVisitServices_OnAddNew(sender As System.Object, args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhVisitServices.OnAddNew
        Dim frm As frmClassifierList
        Dim EntityType As System.Type = GetType(Services)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)
        
        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each x As UserService In _sale.Products.ActiveItemsWithoutEmpty
            If Not x.Service Is Nothing AndAlso Not obj.Contains(x.Service.Id) Then
                obj.Add(x.Service.Id)
            End If
        Next
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotInClassifier", True))

        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim tem As SaleProduct
            For Each x As Services In CType(frm.Selection, Entities(Of Services))
                tem = New SaleProduct(Session)
                tem.Service = x
                tem.Price = x.DecimalValue
                tem.Sale = _sale
                args.AddedObject = tem
                _sale.Products.Add(tem)
            Next
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim newUser As Boolean = (_sale.Id = Guid.Empty)
        If Not _sale.CanSave Then Return
        If Not _sale.IsValid Then
            Core.UI.MsgBox.Show(Core.Err.CouldNotSave, MessageBoxButtons.OK)
            Return
        End If
        Session.SaveOrUpdate(_sale)
        Session.Commit()
        If newUser Then
            _dataIDs.Clear()
            _dataIDs.Add(GetType(Sale), _sale.Id)
            DataList.Add(PartnerSession.Get(Of Sale)(_sale.Id))
        End If
        Return
    End Sub

    Private Sub btnBay_Click(sender As System.Object, e As System.EventArgs) Handles btnBay.Click
        If bndSale.Current Is Nothing Then
            Return
        End If
        ''pārbaudam vai nav izmaiņas, kas jāsaglabā pirms čeka izdrukas
        If (_sale.IsDirty) Then
            MsgBox.Show("Pirkuma dati ir mainīti. Pirms drukāt čeku lûdzu saglabājiet izmaiņas.")
            Return
        End If
        For Each detail As SaleProduct In _sale.Products
            If (detail.IsDirty) Then
                MsgBox.Show("Pirkuma dati ir mainīti. Pirms drukāt čeku lûdzu saglabājiet izmaiņas.")
                Return
            End If
        Next

        If Not Core.UI.MsgBox.Show("Vai tiešām vēlaties veikt apmaksu?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Return
        End If
        ''ja ir norādīts apmaksas datums tad muzskatam ka apmaksa jau ir veikta
        If _sale.PaymentDate.HasValue Then
            Core.UI.MsgBox.Show("Šim abonementam apmaksa jau ir veikta " + _sale.PaymentDate.Value.ToShortDateString + ". Apmaksu pieņēma " + _sale.PaymentUser.FullName + ".")
            Return
        End If
        If (_sale.Products Is Nothing) Then
            Core.UI.MsgBox.Show("Nav nevienas preces ko pirkt.")
            Return
        End If
        Dim file As String = System.IO.File.ReadAllText("C:\chd3550\fiscal\SALE.TXT")
        If (_sale.Patient Is Nothing) Then
            file = file.Replace("$vards", "")
            file = file.Replace("$uzvards", "")
            file = file.Replace("$kods", "")
            file = file.Replace("$adrese", "")
        Else
            file = file.Replace("$vards", _sale.Patient.Name & IIf(String.IsNullOrEmpty(_sale.Patient.SecondName), "", " " & _sale.Patient.SecondName))
            file = file.Replace("$uzvards", _sale.Patient.Surname)
            file = file.Replace("$kods", _sale.Patient.Code)
            file = file.Replace("$adrese", IIf(String.IsNullOrEmpty(_sale.Patient.Address), "", _sale.Patient.Address))
        End If
        Dim start As Integer = file.IndexOf("$01")
        Dim beigas As Integer = file.IndexOf("$_")
        Dim str As String = file.Substring(start, beigas - start + 2)
        Dim res As New System.Text.StringBuilder()
        For Each x As SaleProduct In _sale.Products.ActiveItemsWithoutEmpty
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
            Dim cena As String = x.Total.ToString()
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
        _sale.PaymentDate = Now
        _sale.PaymentUser = Context.Current.AuthenticatedUser
        btnSave_Click(btnSave, New EventArgs())
    End Sub
End Class
