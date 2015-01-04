Imports DevExpress.XtraGrid.Views.BandedGrid
Imports Core.Bll
Imports Entities
Imports Core.UI
Imports Core.Dal.Expressions
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmNorikojumi
    Implements IEditForm

    Private _dataIDs As Dictionary(Of Type, Guid)
    Private _dataList As IList
    Private _norikojums As VisitResult
    Private pievienotieNorikojumi As New List(Of Assignment)
    Public Visit As Visit

    Public Property DataIDs() As Dictionary(Of Type, Guid) Implements IEditForm.DataIDs
        Get
            Return _dataIDs
        End Get
        Set(ByVal value As Dictionary(Of Type, Guid))
            ''pārbaudam vi vizīteri ir izveidots norīkojumu ieraksts
            Dim temp As Entities(Of VisitResult)
            temp = Entities(Of VisitResult).GetAll(Session, New Eq("Visit", Visit))
            If (temp.Count > 0) Then
                _norikojums = temp(0)
            Else
                _norikojums = New VisitResult()
                _norikojums.Visit = Visit
            End If
            For Each a As VisitResultAssignment In _norikojums.VisitResultAssignments.ActiveItemsWithoutEmpty
                AddTabPage(a)
                pievienotieNorikojumi.Add(a.Asignment)
            Next
            VisitResultBindingSource.DataSource = _norikojums
        End Set
    End Property

    Public Property DataList() As IList Implements IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As IList)
            _dataList = value
        End Set
    End Property

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnPievienotNorikojumus.Click
        Dim frm As frmClassifierList
        Dim EntityType As Type = GetType(Assignment)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)

        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each a As Assignment In pievienotieNorikojumi
            obj.Add(a.Id)
        Next

        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseNotInClassifier", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each x As Assignment In CType(frm.Selection, Entities(Of Assignment))
                Dim asig As New VisitResultAssignment
                asig.VisitResult = _norikojums
                asig.Asignment = x
                _norikojums.VisitResultAssignments.Add(asig)
                ''pievienojam tabu
                AddTabPage(asig)
                pievienotieNorikojumi.Add(x)
                ''izveidojam bindingu
            Next
        End If
    End Sub

    Private Sub btnNonemtNorikojumus_Click(sender As System.Object, e As System.EventArgs) Handles btnNonemtNorikojumus.Click
        Dim frm As frmClassifierList
        Dim EntityType As Type = GetType(Assignment)

        frm = New frmClassifierList(Entities.ClassifierType.FromType(EntityType, Session), Session, ClassifierListMode.MultiSelect)

        Dim selClassif As New Queue(Of KeyValuePair(Of String, Object))
        Dim obj As IList(Of Guid) = New List(Of Guid)
        For Each a As Assignment In pievienotieNorikojumi
            obj.Add(a.Id)
        Next

        selClassif.Enqueue(New KeyValuePair(Of String, Object)("Classifier", obj))
        selClassif.Enqueue(New KeyValuePair(Of String, Object)("UseInClassifier", True))
        CType(frm, ISelectionForm).SearchObjectPropertyPresets = selClassif
        frm.Selection = Nothing
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim nonemamaslapas As New List(Of TabPage)
            For Each x As Assignment In CType(frm.Selection, Entities(Of Assignment))
                For Each page As TabPage In tabNorikojumi.TabPages
                    If page.Tag Is Nothing Then
                        Continue For
                    End If
                    If x.Id = CType(page.Tag, VisitResultAssignment).Asignment.Id Then
                        nonemamaslapas.Add(page)
                        If CType(page.Tag, VisitResultAssignment).Id <> Guid.Empty Then
                            CType(page.Tag, VisitResultAssignment).IsActive = False
                        Else
                            _norikojums.VisitResultAssignments.Remove(CType(page.Tag, VisitResultAssignment))
                        End If
                    End If
                Next
            Next
            For Each page As TabPage In nonemamaslapas
                tabNorikojumi.TabPages.Remove(page)
            Next
        End If
    End Sub


    'Asins analīzes
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim frm As New frmBloodTest()
        frm.Session = Nothing
        frm.PartnerSession = Session
        Dim data As New System.Collections.Generic.Dictionary(Of System.Type, System.Guid)
        data.Add(GetType(WorkTime), Visit.Id)
        frm.Visit = Visit
        frm.DataIDs = data
        frm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Save()
    End Sub

    Private Function Save() As Boolean
        If Not _norikojums.IsValid Then
            MsgBox.Show("Pirms saglabāšanas izlabojiet ievadlauku kļūdas.")
            Return False
        End If
        Session.SaveOrUpdate(_norikojums)
        Session.Commit()
        Return True
    End Function

    Private Sub frmNorikojumi_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If _norikojums.IsDirty Then
            Dim answer As DialogResult = MsgBox.SaveMessage()
            If answer = DialogResult.Yes Then
                If Not Save() Then
                    e.Cancel = True
                End If
            ElseIf answer = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub AddTabPage(asignment As VisitResultAssignment)
        ''izveidojam tabu
        Dim page As New TabPage(asignment.Asignment.Value)
        page.Tag = asignment
        ''izveidojam tabulu
        Dim grd As CoreGrid = New CoreGrid()
        Dim skats As DevExpress.XtraGrid.Views.Grid.GridView
        skats = New GridView()
        skats.OptionsView.ShowGroupPanel = False
        grd.Dock = DockStyle.Fill
        ''izveidojam pogas
        Dim pogas As GridButtonHelper = New GridButtonHelper()
        pogas.Dock = DockStyle.Top
        pogas.AutoSize = True
        pogas.AutoSizeMode = AutoSizeMode.GrowAndShrink
        page.Controls.Add(pogas)
        page.Controls.Add(grd)
        grd.BringToFront()
        grd.MainView = skats
        tabNorikojumi.TabPages.Add(page)
    End Sub

    Private Sub btnPatientCard_Click(sender As System.Object, e As System.EventArgs) Handles btnPatientCard.Click
        If Visit.Patient Is Nothing Then
            Return
        End If
        Dim frm As New frmTree
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        key.Add(GetType(Patient), Visit.Patient.Id)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

Private Sub btnVisit_Click( sender As System.Object,  e As System.EventArgs) Handles btnVisit.Click
OpenVisit()
End Sub

    
    Private Sub OpenVisit()
        If visit Is Nothing Then Return
            Dim frm As New frmVisitEdit
            frm.visit = visit
            frm.Session = Nothing
            frm.PartnerSession = Session
            frmMain.AddChild(frm)
    End Sub
End Class
