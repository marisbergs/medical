Imports Core.Bll
Imports Entities
Imports Core.UI

Public Class frmLocalization
    Private tipi As List(Of Type)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LocalizationBindingSource.DataSource = Context.Current.Localization

        'sagatavojam sarakstu ar kontroļu tipiem kuriem ir nepiciešama lokalizācija
        tipi = New List(Of Type)()
        tipi.Add((New Label).GetType())
        tipi.Add((New Button).GetType())
        tipi.Add((New CoreGrid).GetType())
        tipi.Add((New TabPage).GetType())
        tipi.Add((New GroupBox).GetType())
        tipi.Add((New CheckBox).GetType())
        tipi.Add((New ToolStripMenuItem).GetType())
        tipi.Add((New MenuStrip).GetType())

    End Sub
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnRenefreshControlList_Click(sender As System.Object, e As System.EventArgs) Handles btnRenefreshControlList.Click
        'dabujam visas formas
        Dim formas As New List(Of Form)()
        Dim formType As Type = Me.GetType().BaseType().BaseType()
        For Each t As Type In Me.GetType().Assembly.GetTypes()
            If t.IsSubclassOf(formType) = True Then
                formas.Add(CType(Activator.CreateInstance(t), Form))
            End If
        Next
        Dim contr As New Entities(Of Localization)
        For Each forma As Form In formas
            Dim obj As New Localization
            obj.Forma = forma.GetType().Name
            obj.Labels = "Text"
            obj.Lv = forma.Text
            'sameklējam vai šāds ieraksts ir db saglabātajā kolekcijā
            If SamekletLokalizaciju(obj) Is Nothing Then
                SaglabatLokalizaciju(obj)
            End If
            If (forma.GetType().Name.ToLower() = "frmmain") Then
                GetFormControls(forma, obj.Forma)
            End If
            GetFormControls(forma, obj.Forma)
        Next
        For Each val As KeyValuePair(Of String,String) In Core.Localization.Instance.Dictionary
            Dim obj As New Localization
                        obj.Forma = "xml"
                        obj.Labels = val.Key
                        obj.Lv = val.Value
                        'sameklējam vai šāds ieraksts ir db saglabātajā kolekcijā
                        If SamekletLokalizaciju(obj) Is Nothing Then
                            SaglabatLokalizaciju(obj)
                        End If
        Next
        Session.Commit()
    End Sub

    Private Sub GetFormControls(control As Control, formasNosaukums As String)
        For Each o As Control In control.Controls
            GetFormControls(o, formasNosaukums)
            If (tipi.Contains(o.GetType())) Then
                'pārbaudam vai gadījumā nav menu tad jāčeko itemi
                If (o.GetType().Name = (New MenuStrip()).GetType().Name) Then
                    Dim menju As MenuStrip = CType(o, MenuStrip)
                    For Each itm As ToolStripMenuItem In menju.Items
                        Dim obj As New Localization
                        obj.Forma = formasNosaukums
                        obj.Labels = itm.Name
                        obj.Lv = itm.Text
                        'sameklējam vai šāds ieraksts ir db saglabātajā kolekcijā
                        If SamekletLokalizaciju(obj) Is Nothing Then
                            SaglabatLokalizaciju(obj)
                        End If
                        If itm.DropDownItems.Count > 0 Then
                            For Each item As ToolStripMenuItem In itm.DropDownItems
                                obj = New Localization
                                obj.Forma = formasNosaukums
                                obj.Labels = item.Name
                                obj.Lv = item.Text
                                'sameklējam vai šāds ieraksts ir db saglabātajā kolekcijā
                                If SamekletLokalizaciju(obj) Is Nothing Then
                                    SaglabatLokalizaciju(obj)
                                End If
                                If item.DropDownItems.Count > 0 Then
                                    For Each item1 As ToolStripMenuItem In item.DropDownItems
                                        obj = New Localization
                                        obj.Forma = formasNosaukums
                                        obj.Labels = item1.Name
                                        obj.Lv = item1.Text
                                        'sameklējam vai šāds ieraksts ir db saglabātajā kolekcijā
                                        If SamekletLokalizaciju(obj) Is Nothing Then
                                            SaglabatLokalizaciju(obj)
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next
                ElseIf (o.GetType().Name = (New CoreGrid).GetType().Name) Then
                    For Each oo As DevExpress.XtraGrid.Views.Grid.GridView In CType(o, CoreGrid).Views
                        For Each col As DevExpress.XtraGrid.Columns.GridColumn In oo.Columns
                            Dim obj = New Localization
                            obj.Forma = formasNosaukums
                            obj.Labels = col.Name
                            obj.Lv = col.Caption
                            'sameklējam vai šāds ieraksts ir db saglabātajā kolekcijā
                            If SamekletLokalizaciju(obj) Is Nothing Then
                                SaglabatLokalizaciju(obj)
                            End If
                        Next
                    Next
                Else
                    Dim obj As New Localization
                    obj.Forma = formasNosaukums
                    obj.Labels = o.Name
                    obj.Lv = o.Text
                    'sameklējam vai šāds ieraksts ir db saglabātajā kolekcijā
                    If SamekletLokalizaciju(obj) Is Nothing Then
                        SaglabatLokalizaciju(obj)
                    End If
                End If
            End If
        Next
    End Sub

    'Private Sub AtrastSubMenu(item As ToolStripItem, formasNosaukums As String)
    '    For Each itm As ToolStripItem In item.ToolTipText
    '        Dim obj As New Localization
    '        obj.Forma = formasNosaukums
    '        obj.Labels = itm.Name
    '        obj.Lv = itm.Text
    '        'sameklējam vai šāds ieraksts ir db saglabātajā kolekcijā
    '        If SamekletLokalizaciju(obj) Is Nothing Then
    '            SaglabatLokalizaciju(obj)
    '        End If
    '    Next
    'End Sub

    Private Function SamekletLokalizaciju(loc As Localization) As Localization
        For Each localization As Localization In Context.Current.Localization
            If localization.Forma = loc.Forma AndAlso localization.Labels = loc.Labels Then
                Return localization
            End If
        Next
        Return Nothing
    End Function

    Private Sub SaglabatLokalizaciju(obj As Localization)
        Session.SaveOrUpdate(obj)
        Context.Current.Localization.Add(obj)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        For Each localization As Localization In Context.Current.Localization
            If (localization.IsDirty) Then
                Session.SaveOrUpdate(localization)
            End If
        Next
        Session.Commit()
    End Sub
End Class
