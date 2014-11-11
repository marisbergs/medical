Imports Entities
Imports Core.UI

Public Class frmUIBase
    Inherits Core.frmBase

    Private Sub frmUIBase_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        SaveLayout()
    End Sub

    Private Sub frmUIBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetGridLayout()
        If (Context.Current.Localization Is Nothing) Then
            Return
        End If
        Lokalizacija()
    End Sub

    Public Sub Lokalizacija()
        Dim tipi As New List(Of Type)
        tipi.Add((New Label).GetType())
        tipi.Add((New Button).GetType())
        tipi.Add((New CoreGrid).GetType())
        tipi.Add((New TabPage).GetType())
        tipi.Add((New GroupBox).GetType())
        tipi.Add((New CheckBox).GetType())
        tipi.Add((New ToolStripMenuItem).GetType())
        tipi.Add((New MenuStrip).GetType())

        Dim obj As New Localization
        obj.Forma = Me.GetType().Name
        obj.Labels = "Text"
        Dim lok As Localization = SamekletLokalizaciju(obj)
        If Not lok Is Nothing Then
            Text = lok.Aktuala
        End If
        Lokalizet(Me, tipi)
    End Sub

    Private Sub Lokalizet(controlis As Control, tipi As List(Of Type))
        For Each c As Control In controlis.Controls
            If (tipi.Contains(c.GetType())) Then
                If (c.GetType().Name = (New MenuStrip()).GetType().Name) Then
                    Dim menju As MenuStrip = CType(c, MenuStrip)
                    For Each itm As ToolStripMenuItem In menju.Items
                        Dim obj As New Localization
                        obj.Forma = Me.GetType().Name
                        obj.Labels = itm.Name
                        Dim lok As Localization = SamekletLokalizaciju(obj)
                        If Not lok Is Nothing Then
                            itm.Text = lok.Aktuala
                        End If
                        If itm.DropDownItems.Count > 0 Then
                            For Each item As ToolStripMenuItem In itm.DropDownItems
                                obj = New Localization
                                obj.Forma = Me.GetType().Name
                                obj.Labels = item.Name
                                Dim lok1 As Localization = SamekletLokalizaciju(obj)
                                If Not lok1 Is Nothing Then
                                    item.Text = lok1.Aktuala
                                End If
                                If item.DropDownItems.Count > 0 Then
                                    For Each item1 As ToolStripMenuItem In item.DropDownItems
                                        obj = New Localization
                                        obj.Forma = Me.GetType().Name
                                        obj.Labels = item1.Name
                                        Dim lok11 As Localization = SamekletLokalizaciju(obj)
                                        If Not lok11 Is Nothing Then
                                            item1.Text = lok11.Aktuala
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next
                ElseIf (c.GetType().Name = (New CoreGrid).GetType().Name) Then
                    For Each o As DevExpress.XtraGrid.Views.Grid.GridView In CType(c, CoreGrid).Views
                        For Each col As DevExpress.XtraGrid.Columns.GridColumn In o.Columns
                            Dim obj = New Localization
                            obj.Forma = Me.GetType().Name
                            obj.Labels = col.Name
                            Dim lok1 As Localization = SamekletLokalizaciju(obj)
                            If Not lok1 Is Nothing Then
                                col.Caption = lok1.Aktuala
                            End If
                        Next
                    Next
                Else
                    Dim obj = New Localization
                    obj.Forma = Me.GetType().Name
                    obj.Labels = c.Name
                    Dim lok1 As Localization = SamekletLokalizaciju(obj)
                    If Not lok1 Is Nothing Then
                        c.Text = lok1.Aktuala
                    End If
                End If
            End If
            If (c.Controls.Count > 0) Then
                Lokalizet(c, tipi)
            End If
        Next
    End Sub


    Private Function SamekletLokalizaciju(loc As Localization) As Localization
        For Each localization As Localization In Context.Current.Localization
            If localization.Forma = loc.Forma AndAlso localization.Labels = loc.Labels Then
                Return localization
            End If
        Next
        Return Nothing
    End Function

    Private _personalization As Personalization
    Public Overridable Property Personalization() As Entities.Personalization
        Get
            Return _personalization
        End Get
        Set(ByVal value As Entities.Personalization)
            _personalization = value
        End Set
    End Property

    Public Sub SetGridLayout()
        If Not Me.GetType().GetInterface("IPersonalization") Is Nothing Then
            Dim _layout As Core.Bll.Entities(Of Entities.Personalization)
            _layout = Core.Bll.Entities(Of Entities.Personalization).GetAll(Session, CType(Me, Entities.IPersonalization).Criteria)
            If _layout.Count > 0 Then
                Personalization = CType(_layout(0), Entities.Personalization)
                Dim filename As String = IO.Path.GetTempFileName() + ".xml"
                Dim xml As New Xml.XmlDocument()
                xml.LoadXml(Personalization.Content)
                xml.Save(filename)
                CType(Me, Entities.IPersonalization).SetLayout(filename)
            Else
                For Each x As Core.Dal.Expressions.Eq In CType(Me, Entities.IPersonalization).Criteria
                    If x.Value.ToString() = "nothing" Then
                        Exit Sub
                    End If
                Next
                Personalization = New Personalization(Session)
                For Each x As Core.Dal.Expressions.Eq In CType(Me, Entities.IPersonalization).Criteria
                    Core.ReflectionHelper.SetPropertyValue(Personalization, x.PropertyName, x.Value)
                Next
            End If
        End If
    End Sub

    Public Sub SaveLayout()
        Try
            If Not Me.GetType().GetInterface("IPersonalization") Is Nothing Then
                If Not Personalization Is Nothing Then
                    For Each x As Core.Dal.Expressions.Eq In CType(Me, Entities.IPersonalization).Criteria
                        If x.Value.ToString() = "nothing" Then
                            Exit Sub
                        End If
                    Next
                    Dim filename As String = IO.Path.GetTempFileName() + ".xml"
                    CType(Me, Entities.IPersonalization).ReadLayout(filename)
                    Dim xml As New Xml.XmlDocument()
                    xml.Load(filename)
                    Personalization.Content = xml.InnerXml()
                    Dim _personalizationSave As Core.Dal.ISession = Core.Dal.Manager.Instance.OpenSession(Core.Dal.ConnectionTarget.Central)
                    _personalizationSave.Clear()
                    If Not Personalization.Id = Guid.Empty Then
                        Personalization.User = _personalizationSave.Get(Of User)(Personalization.User.Id)
                        _personalizationSave.Replicate(Personalization, NHibernate.ReplicationMode.Overwrite)
                    Else
                        Dim newPersonalization As New Entities.Personalization(_personalizationSave)
                        newPersonalization.User = _personalizationSave.Get(Of User)(Personalization.User.Id)
                        newPersonalization.Form = Personalization.Form
                        newPersonalization.Table = Personalization.Table
                        newPersonalization.View = Personalization.View
                        newPersonalization.Content = Personalization.Content
                        _personalizationSave.SaveOrUpdate(newPersonalization)
                    End If
                    _personalizationSave.Flush()
                    _personalizationSave.Commit()
                End If
            End If
        Catch ex As Exception
            Core.UI.MsgBox.Show(ex.ToString(), MessageBoxButtons.OK)
        End Try
    End Sub
End Class