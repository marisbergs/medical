Imports Core.Bll
Imports NVelocity.Runtime.Directive
Imports Entities
Imports Core.UI
Imports Core.Dal.Expressions
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmBloodTest
    Implements IEditForm

    Private _dataIDs As Dictionary(Of Type, Guid)
    Private _dataList As IList
    Private _norikojums As VisitResult
    Private pievienotieNorikojumi As New List(Of Assignment)
    Public Visit As Visit
    Private analizuGrupas As Entities(Of BloodTestGroup)
    Private analizes As Entities(Of BloodTest)
    Private veicamasAnalizes As Entities(Of VisitBloodTest)

    Public Property DataIDs() As Dictionary(Of Type, Guid) Implements IEditForm.DataIDs
        Get
            Return _dataIDs
        End Get
        Set(ByVal value As Dictionary(Of Type, Guid))
            ''Nolasam visas asinsa analīžu grupas
            ''analizuGrupas = Entities(Of BloodTestGroup).GetAll(Session)
            ''nolasam visus analīžu veidus
            analizes = Entities(Of BloodTest).GetAll(Session)
            bndBloodTestGroups.DataSource = analizes
            ''nolasam visus atzīmētos analīžu veidus
            veicamasAnalizes = Entities(Of VisitBloodTest).GetAll(Session, New Eq("Visit", Visit), New IsNull("DeleteTime"))
            For Each veicamasAnaliz As VisitBloodTest In veicamasAnalizes
                For Each an As BloodTest In analizes
                    If (veicamasAnaliz.Tests.Id = an.Id) Then
                        an.VisitBloodTest = veicamasAnaliz
                        Exit For
                    End If
                Next
            Next
            bndVisitBloadTest.DataSource = veicamasAnalizes
            'For Each grupa As BloodTestGroup In analizuGrupas
            '    Dim lapa = AddTabPage(grupa)
            'Next

            'Dim temp As Entities(Of VisitResult)
            'temp = Entities(Of VisitResult).GetAll(Session, New Eq("Visit", Visit))
            'If (temp.Count > 0) Then
            '    _norikojums = temp(0)
            'Else
            '    _norikojums = New VisitResult()
            '    _norikojums.Visit = Visit
            'End If
        End Set
    End Property


    Private Function AddTabPage(testGroup As BloodTestGroup) As TabPage
        ''izveidojam tabu
        Dim page As New TabPage(testGroup.Value)
        page.Tag = testGroup
        Dim obj As New FlowLayoutPanel()
        obj.FlowDirection = FlowDirection.TopDown
        obj.Dock = DockStyle.Fill
        page.Controls.Add(obj)
        ''izveidojam tabulu
        'Dim grd As CoreGrid = New CoreGrid()
        'Dim skats As DevExpress.XtraGrid.Views.Grid.GridView
        'skats = New GridView()
        'skats.OptionsView.ShowGroupPanel = False
        'grd.Dock = DockStyle.Fill
        ' ''izveidojam pogas
        'Dim pogas As GridButtonHelper = New GridButtonHelper()
        'pogas.Dock = DockStyle.Top
        'pogas.AutoSize = True
        'pogas.AutoSizeMode = AutoSizeMode.GrowAndShrink
        'page.Controls.Add(pogas)
        'page.Controls.Add(grd)
        'grd.BringToFront()
        'grd.MainView = skats
        tabBloodTest.TabPages.Add(page)
        Return page
    End Function

    Public Property DataList() As IList Implements IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As IList)
            _dataList = value
        End Set
    End Property

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub


    Private Sub chkSelect_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSelect.CheckedChanged
        If bndBloodTestGroups.Current Is Nothing Then
            Return
        End If
        Dim tests As BloodTest
        tests = CType(bndBloodTestGroups.Current, BloodTest)
        If tests.Selected Then
            ''ja ir ieselektēts tad insertojam
            tests.VisitBloodTest.IsActive = False
            veicamasAnalizes.Remove(tests.VisitBloodTest)
        Else
            ''ja nē dzēšam ārā
            tests.VisitBloodTest = New VisitBloodTest()
            tests.VisitBloodTest.Visit = Visit
            tests.VisitBloodTest.Tests = tests
            veicamasAnalizes.Add(tests.VisitBloodTest)
        End If
        Session.SaveOrUpdate(tests.VisitBloodTest)
        Session.Commit()
    End Sub
End Class
