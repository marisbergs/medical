Imports Core.Dal.Expressions
Imports Entities
Imports Core.UI

Public Class frmClassifierTypeList

    Dim _classifierList As Core.Bll.Entities(Of Entities.ClassifierType)


#Region "Constructor"
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        _classifierList = Core.Bll.Entities(Of Entities.ClassifierType).GetAll(Session, New NotEq("Kind", New ClassifierKind(ClassifierKindEnum.NotAClassifier)))
        bndClassifierType.DataSource = _classifierList

    End Sub
#End Region

#Region "Private Methods"
    Private Sub _classifierOpen()
        Dim currentClassifier As ClassifierType = CType(bndClassifierType.Current, ClassifierType)
        Dim form As ISelectionForm = currentClassifier.NewFormInstance(Core.Dal.Manager.Instance.OpenSession(), Core.UI.ClassifierListMode.Edit)
        
        CType(form, Form).MdiParent = Me.MdiParent
        CType(form, Form).Show()
    End Sub
#End Region

#Region "Private Events"
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        _classifierOpen()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub grdClassifierTypeList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdClassifierTypeList.KeyDown
        If e.KeyCode = Keys.Enter Then
            _classifierOpen()
        End If
    End Sub

    Private Sub grdClassifierTypeList_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdClassifierTypeList.MouseDoubleClick
        _classifierOpen()
    End Sub
#End Region

End Class