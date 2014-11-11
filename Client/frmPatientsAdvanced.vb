Option Strict On

Imports System
Imports System.Collections.Generic
Imports NHibernate
Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Entities
Imports Core.UI

Imports DevExpress
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.BandedGrid

Public Class frmPatientsAdvanced
    Inherits Client.frmUIBase
    Implements ISelectionForm


    Private _criteria As New List(Of Core.Dal.Expressions.CriterionBase)
    Public canAddNew As Boolean = False
    Public Visit As Visit
    Public selectedPatientList As Entities(Of Patient)
    Public NotUseDblClickAsAccept As Boolean = False

#Region "ISelectionForm implementation"

    Private _mode As ClassifierListMode

    Public Property FormMode() As ClassifierListMode Implements ISelectionForm.FormMode
        Get
            Return _mode
        End Get
        Set(ByVal value As ClassifierListMode)
            _mode = value
            'Select Case value
            '    Case ClassifierListMode.Edit
            '        Me.btnAdd.Visible = True
            '        Me.btnOpen.Visible = True
            '        Me.btnDelete.Visible = True
            '        Me.btnDisable.Visible = True
            '        Me.btnOK.Visible = False
            '        Dim grd As GridView = CType(Me.grdPatients.Views(0), GridView)
            '        grd.Columns(0).Visible = False
            '        btnExport.Visible = True
            '        btnExportToExcel.Visible = True
            '    Case ClassifierListMode.MultiSelect
            '        Me.btnOpen.Visible = False
            '        Me.btnDelete.Visible = False
            '        Me.btnDisable.Visible = False
            '        Me.btnOK.Visible = True
            '        Dim grd As GridView = CType(Me.grdPatients.Views(0), GridView)
            '        Me.btnAdd.Visible = canAddNew
            '        grd.Columns(0).Visible = True
            '    Case ClassifierListMode.SingleSelect
            '        Me.btnOpen.Visible = False
            '        Me.btnDelete.Visible = False
            '        Me.btnDisable.Visible = False
            '        Me.btnOK.Visible = True
            '        Me.btnAdd.Visible = canAddNew
            '        Dim grd As GridView = CType(Me.grdPatients.Views(0), GridView)
            'End Select
        End Set
    End Property

    Public Property Selection() As Object Implements ISelectionForm.Selection
        Get
            Select Case _mode
                Case ClassifierListMode.Edit
                    Return Nothing
                Case ClassifierListMode.MultiSelect
                    Dim list As New Entities(Of Patient)
                    If Not Me.bndPatients.DataSource Is Nothing Then
                        For Each org As Patient In Me.bndPatients.List
                            If org.Selected Then
                                list.Add(org)
                            End If
                        Next
                        If list.Count = 0 Then
                            list.Add(CType(Me.bndPatients.Current, Patient))
                        End If
                    End If
                    Return list
                Case ClassifierListMode.SingleSelect
                    If Me.bndPatients.DataSource Is Nothing Then Return Nothing
                    Return Me.bndPatients.Current
                Case Else
                    Return Nothing
            End Select
        End Get
        Set(ByVal value As Object)
            If Not Me.bndPatients.DataSource Is Nothing AndAlso Not value Is Nothing AndAlso value.GetType().Name = "Entities`1" Then
                For Each org As Patient In Me.bndPatients.List
                    org.Selected = False
                    For Each pat As Patient In CType(value, Entities(Of Patient))
                        If org.Id = pat.Id Then
                            org.Selected = True
                        End If
                    Next
                Next
            End If
        End Set
    End Property

    Public Function ShowDialog1() As System.Windows.Forms.DialogResult Implements Core.UI.ISelectionForm.ShowDialog
        Return Me.ShowDialog()
    End Function

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.grdPatients.SetListMode()
        AddHandler Session.AfterRefresh, AddressOf Users_Refresh
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Users_Refresh(ByVal sender As Core.Dal.ISession, ByVal e As System.EventArgs)
        gvwPatients.RefreshData()
    End Sub

    ' Required by ClassifierPicker
    Public Sub New(ByVal tp As Entities.ClassifierType, ByVal session As Core.Dal.ISession)
        Me.New()
        Me.Session = session
    End Sub

    Private _searchPresets As Queue(Of KeyValuePair(Of String, Object))
    Public WriteOnly Property SearchObjectPropertyPresets() As Queue(Of KeyValuePair(Of String, Object)) Implements ISelectionForm.SearchObjectPropertyPresets
        Set(ByVal value As Queue(Of KeyValuePair(Of String, Object)))
            _searchPresets = value
        End Set
    End Property

#End Region


    Private Sub CtlUsersFind_GetPresets(ByVal sender As Object, ByVal e As GetPresetsEventArgs)
        e.Presets = _searchPresets
    End Sub
    Private Sub CtlUsersFind_Find(ByVal sender As System.Object, ByVal e As Client.FindEventArgs)
        _criteria = CType(e.Criteria, List(Of Core.Dal.Expressions.CriterionBase))
        RefreshList()
    End Sub
#Region "Bottom Buttons"
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'if no permissions, button will be disabled
        AddPatient()
    End Sub
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenPatient()
    End Sub
    Private Sub btnDisable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisable.Click
        'if no permissions, button will be disabled
        If Me.bndPatients.Current Is Nothing Then Exit Sub
        Dim pat As Patient = CType(Me.bndPatients.Current, Patient)
        pat.IsActive = True
        Session.SaveOrUpdate(pat)
        Session.Commit()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'if no permissions, button will be disabled
        If Me.bndPatients.Current Is Nothing Then Return
        Dim user As Patient = CType(Me.bndPatients.Current, Patient)
        If Not user.IsActive Then
            Core.UI.MsgBox.Show(Core.Msg.EntryAlreadyDeleted, MessageBoxButtons.OK)
            Return
        End If
        If Core.UI.MsgBox.Show(Core.Msg.DeleteConfirmation, MessageBoxButtons.YesNo) <> Windows.Forms.DialogResult.Yes Then Exit Sub
        user.IsActive = False

        'Save changes
        Try
            Session.Commit()
        Catch ex As Exception
            Core.UI.MsgBox.Show(Core.Err.CouldNotDelete, MessageBoxButtons.OK)
            Return
        End Try
        Me.RefreshList()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Me.bndPatients.Current Is Nothing Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
#End Region
    Private Sub grdUser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPatients.DoubleClick
        OpenPatient()
    End Sub
    Private Sub RefreshList()
        'bndUsers.DataSource = Entities(Of User).GetAll(Session, _criteria)
        Dim users As New Entities(Of Patient)
        Session.CreateAndBuildCriteria(Of Patient)(_criteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(users)
        bndPatients.DataSource = users
    End Sub
    Private Sub OpenPatient()
        If Not Me._mode = ClassifierListMode.MultiSelect And Not Me._mode = ClassifierListMode.SingleSelect Then
            If Me.bndPatients.Current Is Nothing Then Return
            Dim frm As New frmTree
            Dim key As New Dictionary(Of Type, Guid)
            frm.PartnerSession = Me.Session
            frm.Session = Nothing
            frm.DataList = CType(bndPatients.DataSource, IList)
            key.Add(GetType(Patient), CType(Me.bndPatients.Current, Patient).Id)
            frm.DataIDs = key
            frmMain.AddChild(frm)
        ElseIf Not NotUseDblClickAsAccept Then
            If Me.bndPatients.Current Is Nothing Then Return
            'btnOK.PerformClick()
        End If
    End Sub
    Private Sub AddPatient()
        Dim frm As New frmTree
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        If bndPatients.Current Is Nothing Then
            frm.DataList = New List(Of Patient)
        Else
            frm.DataList = CType(bndPatients.DataSource, IList)
        End If
        key.Add(GetType(Patient), Guid.Empty)
        frm.DataIDs = key
        If (canAddNew) Then
            frm.Visit = Visit
            frm.NewForVisit = True
            frm.ShowDialog()
            frm.Close()
            Close()
        Else
            frmMain.AddChild(frm)
        End If
    End Sub
    Private Sub frmUsers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.btnAdd.Enabled = PermissionsChecker.CanDo("Patient.CanAdd")
        Me.btnDelete.Enabled = PermissionsChecker.CanDo("User.AddDelete")
        Me.btnDisable.Enabled = PermissionsChecker.CanDo("User.Unlock")
        'reset controls property
        Me._mode = Me._mode
    End Sub

    Private Sub CtlPatientFind1_Find(ByVal sender As System.Object, ByVal e As Client.FindEventArgs) Handles CtlPatientFind1.Find
        _criteria = CType(e.Criteria, List(Of Core.Dal.Expressions.CriterionBase))
        Dim patients As New Entities(Of Patient)
        Session.CreateAndBuildCriteria(Of Patient)(_criteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(patients)
        bndPatients.DataSource = patients
        If Not selectedPatientList Is Nothing Then
            Selection = selectedPatientList
            selectedPatientList = Nothing
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim list As New ChildCollection(Of Patient)
        bndPatients.Sort = "Surname"
        For Each x As Patient In bndPatients
            list.Add(x)
        Next

        Dim template As Template = Session.Get(Of Template)(template.PatientList)
        If template Is Nothing Then
            Return
        End If
        Dim templateStream As IO.Stream = template.CurrentVersion.File.Content.GetAsStream()
        Dim context As New Hashtable
        context.Add("P02", list)

        Dim vis As New Visit(Session)
        ''vis.StartTime

        Dim fileName As String = IO.Path.GetTempFileName() + ".rtf"
        Core.Reporting.Report.CreateReport(templateStream, fileName, context)
        Dim File As BinaryFile = New BinaryFile(Session, fileName)
        Dim tempPath As String = System.IO.Path.GetTempPath + Guid.NewGuid().ToString() + File.Name
        File.Content.SaveToFile(tempPath)
        Core.Helper.RunShell(tempPath)
    End Sub

    Private Sub btnExportToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportToExcel.Click
        grdPatients.Export()
    End Sub


End Class
' Lūdzu, Юникод