Imports Core.Bll
Imports Entities
Imports Core.Dal
Imports Core.UI

Public Class frmPrimarasAprupesProfiluSaraksts

    Public Selected As ProfileDescription

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmPrimarasAprupesProfiluSaraksts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bndProfileDescription.DataSource = Entities(Of ProfileDescription).GetAll(Session, New Expressions.IsNull("DeleteTime"))
    End Sub

    Public Sub SetSelectionMode()
        btnDelete.Visible = False
        btnAdd.Visible = False
        btnOpen.Visible = False
        btnOk.Visible = True
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New frmPrimarasAprupesProfils()
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(bndProfileDescription.DataSource, IList)
        key.Add(GetType(ProfileDescription), Guid.Empty)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bndProfileDescription.Current Is Nothing Then
            Return
        End If
        Dim answer As DialogResult = Core.UI.MsgBox.Show("Vai tiešām vēlaties dzēst šo primārās aprūpes profilu?", MessageBoxButtons.YesNo, "Jautājums")
        If answer = Windows.Forms.DialogResult.Yes Then
            Dim obj As ProfileDescription = CType(bndProfileDescription.Current, ProfileDescription)
            obj.IsActive = False
            Session.SaveOrUpdate(obj)
            Session.Commit()
        End If
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If bndProfileDescription.Current Is Nothing Then
            Return
        End If
        Dim itm As ProfileDescription = CType(bndProfileDescription.Current, ProfileDescription)
        Dim frm As New frmPrimarasAprupesProfils()
        Dim key As New Dictionary(Of Type, Guid)
        frm.PartnerSession = Me.Session
        frm.Session = Nothing
        frm.DataList = CType(bndProfileDescription.DataSource, IList)
        key.Add(GetType(ProfileDescription), itm.Id)
        frm.DataIDs = key
        frmMain.AddChild(frm)
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If bndProfileDescription.Current Is Nothing Then
            Selected = Nothing
            DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Selected = CType(bndProfileDescription.Current, ProfileDescription)
            DialogResult = Windows.Forms.DialogResult.OK
        End If
        Close()
    End Sub
End Class
