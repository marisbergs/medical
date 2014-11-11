Imports Entities
Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.UI

Public Class frmCampaign
    Implements ISelectionForm
    Dim lst As Entities(Of Campaign)


    Public Sub New()
        InitializeComponent()

    End Sub

    ' Required by ClassifierPicker
    Public Sub New(ByVal tp As Entities.ClassifierType, ByVal session As Core.Dal.ISession)
        Me.New()
        Me.Session = session
        colSelected.Visible = True
        btnOpen.Visible = False
        btnAdd.Visible = False
        btnDelete.Visible = False
        btnOk.Visible = True
    End Sub

    Public Sub New(ByVal canSelect As Boolean)
        InitializeComponent()
        colSelected.Visible = canSelect
    End Sub

    Private Sub frmCampaign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lst = Entities(Of Campaign).GetAll(Session)
        bndCampaign.DataSource = lst
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New frmCampaignPatients
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(bndCampaign.DataSource, IList)
        key.Add(GetType(Campaign), Guid.Empty)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If bndCampaign.Current Is Nothing Then
            Return
        End If
        Dim frm As New frmCampaignPatients
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(bndCampaign.DataSource, IList)
        key.Add(GetType(Campaign), CType(bndCampaign.Current, Campaign).Id)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bndCampaign.Current Is Nothing Then
            Return
        End If
        If Not CType(bndCampaign.Current, Campaign).IsActive Then
            Return
        End If
        If Core.UI.MsgBox.DeleteMessage() = Windows.Forms.DialogResult.Yes Then
            CType(bndCampaign.Current, Campaign).IsActive = False
            For Each patient1 As CampaignPatient In CType(bndCampaign.Current, Campaign).CampaignPatients
                patient1.IsActive = False
                Session.SaveOrUpdate(patient1)
            Next
            Session.SaveOrUpdate(bndCampaign.Current)
            Session.Commit()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Public Function ShowDialog1() As DialogResult Implements ISelectionForm.ShowDialog
        Return Me.ShowDialog()
    End Function

    Public Property Selection() As Object Implements ISelectionForm.Selection
        Get
            Dim list As New Entities(Of Campaign)
            If Not Me.bndCampaign.DataSource Is Nothing Then
                For Each org As Campaign In Me.bndCampaign.List
                    If org.Selected Then
                        list.Add(org)
                    End If
                Next
            End If
            Return list
        End Get
        Set (ByVal value As Object)

        End Set
    End Property

    Public Property FormMode() As ClassifierListMode Implements ISelectionForm.FormMode
        Get
            Return Nothing
        End Get
        Set (ByVal value As ClassifierListMode)

        End Set
    End Property

    Private _searchPresets As Queue(Of KeyValuePair(Of String, Object))
    Public WriteOnly Property SearchObjectPropertyPresets() As Queue(Of KeyValuePair(Of String,Object)) Implements ISelectionForm.SearchObjectPropertyPresets
        Set (ByVal value As Queue(Of KeyValuePair(Of String,Object)))
            _searchPresets = value
        End Set
    End Property

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class