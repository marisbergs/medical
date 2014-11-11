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
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmUsers
    Inherits Client.frmUIBase
    Implements ISelectionForm


    Private _criteria As New List(Of Core.Dal.Expressions.CriterionBase)
    Private _deputy As User
    Private clickPlace As GridHitInfo

#Region "ISelectionForm implementation"

    Private _mode As ClassifierListMode

    Public Property FormMode() As ClassifierListMode Implements ISelectionForm.FormMode
        Get
            Return _mode
        End Get
        Set(ByVal value As ClassifierListMode)
            _mode = value
            Select Case value
                Case ClassifierListMode.Edit
                    Me.btnAdd.Visible = True
                    Me.btnOpen.Visible = True
                    Me.btnDelete.Visible = True
                    Me.btnDisable.Visible = True
                    Me.btnOK.Visible = False
                    Dim grd As GridView = CType(Me.grdUser.Views(0), GridView)
                    grd.Columns(0).Visible = False
                    Me.CtlUsersFind.chkActive.Enabled = True
                    Me.Button1.Visible = True
                    Me.Button2.Visible = True
                Case ClassifierListMode.MultiSelect
                    Me.btnAdd.Visible = False
                    Me.btnOpen.Visible = False
                    Me.btnDelete.Visible = False
                    Me.btnDisable.Visible = False
                    Me.btnOK.Visible = True
                    Dim grd As GridView = CType(Me.grdUser.Views(0), GridView)
                    grd.Columns(0).Visible = True
                    Me.CtlUsersFind.chkActive.Enabled = False
                Case ClassifierListMode.SingleSelect
                    Me.btnAdd.Visible = False
                    Me.btnOpen.Visible = False
                    Me.btnDelete.Visible = False
                    Me.btnDisable.Visible = False
                    Me.btnOK.Visible = True
                    Dim grd As GridView = CType(Me.grdUser.Views(0), GridView)
                    grd.Columns(0).Visible = False
                    Me.CtlUsersFind.chkActive.Enabled = False
            End Select
        End Set
    End Property

    Public Property Selection() As Object Implements ISelectionForm.Selection
        Get
            Select Case _mode
                Case ClassifierListMode.Edit
                    Return Nothing
                Case ClassifierListMode.MultiSelect
                    Dim list As New Entities(Of User)
                    If Not Me.bndUsers.DataSource Is Nothing Then
                        For Each org As User In Me.bndUsers.List
                            If org.Selected Then
                                list.Add(org)
                            End If
                        Next
                    End If
                    Return list
                Case ClassifierListMode.SingleSelect
                    If Me.bndUsers.DataSource Is Nothing Then Return Nothing
                    Return Me.bndUsers.Current
                Case Else
                    Return Nothing
            End Select
        End Get
        Set(ByVal value As Object)

        End Set
    End Property

    Public Function ShowDialog1() As System.Windows.Forms.DialogResult Implements Core.UI.ISelectionForm.ShowDialog
        Return Me.ShowDialog()
    End Function

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.grdUser.SetListMode()
        _deputy = Nothing
        AddHandler Session.AfterRefresh, AddressOf Users_Refresh
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Users_Refresh(ByVal sender As Core.Dal.ISession, ByVal e As System.EventArgs)
        GridView1.RefreshData()
    End Sub

    ' Required by ClassifierPicker
    Public Sub New(ByVal tp As Entities.ClassifierType, ByVal session As Core.Dal.ISession, ByVal mode As ClassifierListMode)
        Me.New()
        Me.Session = session
        FormMode = mode
    End Sub

    Private _searchPresets As Queue(Of KeyValuePair(Of String, Object))
    Public WriteOnly Property SearchObjectPropertyPresets() As Queue(Of KeyValuePair(Of String, Object)) Implements ISelectionForm.SearchObjectPropertyPresets
        Set(ByVal value As Queue(Of KeyValuePair(Of String, Object)))
            _searchPresets = value
        End Set
    End Property

#End Region

    Public Property Deputy() As User
        Get
            Return _deputy
        End Get
        Set(ByVal value As User)
            _deputy = value
        End Set
    End Property

    Private Sub CtlUsersFind_GetPresets(ByVal sender As Object, ByVal e As GetPresetsEventArgs) Handles CtlUsersFind.GetPresets
        e.Presets = _searchPresets
    End Sub
    Private Sub CtlUsersFind_Find(ByVal sender As System.Object, ByVal e As Client.FindEventArgs) Handles CtlUsersFind.Find
        _criteria = CType(e.Criteria, List(Of Core.Dal.Expressions.CriterionBase))
        RefreshList()
    End Sub
#Region "Bottom Buttons"
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'if no permissions, button will be disabled
        AddUser()
    End Sub
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenUser()
    End Sub
    Private Sub btnDisable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisable.Click
        'if no permissions, button will be disabled
        If Me.bndUsers.Current Is Nothing Then Exit Sub
        Dim user As User = CType(Me.bndUsers.Current, User)
        If user.Role Is Nothing Then Exit Sub
        If Core.UI.MsgBox.Show(Msg.UserConfirmLockout, MessageBoxButtons.YesNo) <> Windows.Forms.DialogResult.Yes Then Exit Sub
        user.LockOut()
        AcceptChanges()
        Me.RefreshList()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'if no permissions, button will be disabled
        If Me.bndUsers.Current Is Nothing Then Return
        Dim user As User = CType(Me.bndUsers.Current, User)
        If Not user.IsActive Then
            Core.UI.MsgBox.Show(Core.Msg.EntryAlreadyDeleted, MessageBoxButtons.OK)
            Return
        End If
        If Core.UI.MsgBox.Show(Core.Msg.DeleteConfirmation, MessageBoxButtons.YesNo) <> Windows.Forms.DialogResult.Yes Then Exit Sub
        user.Delete()
        Me.AcceptChanges()
        'Save changes
        Try
            Session.Commit(PartnerSession)
        Catch ex As Exception
            Core.UI.MsgBox.Show(Core.Err.CouldNotDelete, MessageBoxButtons.OK)
            Return
        End Try
        Me.RefreshList()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Not Me.bndUsers.Current Is Nothing Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
#End Region
    Private Sub grdUser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdUser.DoubleClick
        OpenUser()
    End Sub
    Private Sub RefreshList()
        'bndUsers.DataSource = Entities(Of User).GetAll(Session, _criteria)
        Dim users As New Entities(Of User)
        Session.CreateAndBuildCriteria(Of User)(_criteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(users)
        bndUsers.DataSource = users
    End Sub
    Private Sub OpenUser()
        If bndUsers.Current Is Nothing Then Return
        'TODO: pārbauda tiesības, vai drīkst vērt vaļā formu
        'justine: when choosing a user from classifier picker, cannot open useredit
        If Not Me._mode = ClassifierListMode.MultiSelect And Not Me._mode = ClassifierListMode.SingleSelect Then
            If Me.bndUsers.Current Is Nothing Then Return
            Dim frm As New frmUserEdit
            Dim key As New Dictionary(Of Type, Guid)
            frm.PartnerSession = Me.Session
            frm.Session = Nothing
            frm.DataList = CType(bndUsers.DataSource, IList)
            key.Add(GetType(User), CType(Me.bndUsers.Current, User).Id)
            frm.DataIDs = key
            frmMain.AddChild(frm)
        End If
        If FormMode = ClassifierListMode.SingleSelect Then
            If clickPlace Is Nothing Then
                Return
            End If
            'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
            If clickPlace.HitTest = GridHitTest.RowCell Then
                btnOK.PerformClick()
            End If
        End If
    End Sub
    Private Sub AddUser()
        Dim frm As New frmUserEdit
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(bndUsers.DataSource, IList)
        key.Add(GetType(User), Guid.Empty)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub
    Private Sub frmUsers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.btnAdd.Enabled = PermissionsChecker.CanDo("User.AddDelete")
        Me.btnDelete.Enabled = PermissionsChecker.CanDo("User.AddDelete")
        Me.btnDisable.Enabled = PermissionsChecker.CanDo("User.Unlock")
        'reset controls property
        Me._mode = Me._mode
    End Sub

    Private Sub grdUser_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdUser.MouseMove
        clickPlace = GridView1.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim list As New ChildCollection(Of User)
        For Each x As User In bndUsers
            list.Add(x)
        Next

        Dim template As Template = Session.Get(Of Template)(template.DoctorList)
        If template Is Nothing Then
            Return
        End If
        Dim templateStream As IO.Stream = template.CurrentVersion.File.Content.GetAsStream()
        Dim context As New Hashtable
        context.Add("P01", list)

        Dim vis As New Visit(Session)
        ''vis.StartTime

        Dim fileName As String = IO.Path.GetTempFileName() + ".rtf"
        Core.Reporting.Report.CreateReport(templateStream, fileName, context)
        Dim File As BinaryFile = New BinaryFile(Session, fileName)
        Dim tempPath As String = System.IO.Path.GetTempPath + Guid.NewGuid().ToString() + File.Name
        File.Content.SaveToFile(tempPath)
        Core.Helper.RunShell(tempPath)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        grdUser.Export()
    End Sub
End Class
' Lūdzu, Юникод