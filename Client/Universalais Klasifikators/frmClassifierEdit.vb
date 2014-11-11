Imports Entities
Imports Core
Imports Core.UI

Public Class frmClassifierEdit
    Inherits Client.frmUIBase
    Implements IEditForm

    Private _ct As ClassifierType
    Private _editedObject As HierClassifier
    Friend _wasSaved As Boolean = False
    Private _dataList As IList
    Private _validFrom As Nullable(Of DateTime)
    Private _validUntil As Nullable(Of DateTime)
    Private _parent As HierClassifier

    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            Return Nothing
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            Dim id As Guid = value(GetType(HierClassifier))
            If id = Guid.Empty Then
                _editedObject = New HierClassifier()
                _editedObject = _ct.NewInstance()
                Me.chkFastIntroduce.Visible = True
            Else
                _editedObject = Session.Get(Of HierClassifier)(id)
            End If
            bndHierClassifier.DataSource = _editedObject
        End Set
    End Property



    Public Sub ConfigureUsingClassifierType(ByVal ct As ClassifierType)

        If ct.CodePrompt Is Nothing Then
            txtCode.Visible = False
            lblCode.Visible = False
        End If
        If ct.CommentPrompt Is Nothing Then
            txtText.Visible = False
            lblText.Visible = False
        End If
        If ct.NumberPrompt Is Nothing Then
            txtDecimalValue.Visible = False
            lblDecimalValue.Visible = False
        End If
        lblCode.Text = Core.Localization.Instance(ct.CodePrompt)
        lblValue.Text = Core.Localization.Instance(ct.ValuePrompt)
        lblText.Text = Core.Localization.Instance(ct.CommentPrompt)
        lblParent.Text = Core.Localization.Instance("Classifier.ParentPrompt")
        lblColor.Text = Core.Localization.Instance(ct.ColorPrompt)
        If ct.ColorPrompt Is Nothing Then
            txtColorEdit.Visible = False
            lblColor.Visible = False
        End If

        lblMark.Text = Core.Localization.Instance(ct.MarkPrompt)
        If ct.ColorPrompt Is Nothing Then
            chkMark.Visible = False
            lblMark.Visible = False
        End If

        Text = ct.Value
        _ct = ct
    End Sub

    Public Property DataList() As System.Collections.IList Implements Core.UI.IEditForm.DataList
        Get
            'Dim res As New ArrayList()
            'res.Add(_editedObject)
            'Return res
            Return _dataList
        End Get
        Set(ByVal value As System.Collections.IList)
            _dataList = value
        End Set
    End Property

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Function Save() As Boolean
        If Not _editedObject.IsValid Then
            ActivateErrorControls(Me.ErrorProvider1, Me)
            Core.UI.MsgBox.HasErrorMessage()
            Return True
        Else
            Dim add As Boolean = (_editedObject.Id = Guid.Empty)
            Session.Save(_editedObject)
            Session.Commit()
            _wasSaved = True
            If add Then
                _dataList.Add(PartnerSession.Get(Of HierClassifier)(_editedObject.Id))
            End If
            If Me.chkFastIntroduce.Checked Then
                If _parent Is Nothing Then
                    _parent = _editedObject.Parents
                    _validFrom = _editedObject.ValidFrom
                    _validUntil = _editedObject.ValidUntil
                End If
                _editedObject = New HierClassifier()
                _editedObject = _ct.NewInstance()
                _editedObject.Parents = _parent
                _editedObject.ValidFrom = _validFrom
                _editedObject.ValidUntil = _validUntil
                Me.bndHierClassifier.DataSource = _editedObject
                _editedObject.IsDirty = False
            End If
            Return False
        End If
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmClassifierEdit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not _editedObject.IsDirty Then
            'HierClassifier._returnStringValue = False
            Return
        End If
        If Not _editedObject.IsDirty And chkFastIntroduce.Checked Then
            Return
        End If
        Select Case Core.UI.MsgBox.SaveMessage()
            Case Windows.Forms.DialogResult.Yes
                e.Cancel = Save()
            Case Windows.Forms.DialogResult.Cancel
                e.Cancel = True
        End Select
        'HierClassifier._returnStringValue = e.Cancel
    End Sub

    Private Sub beParent_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beParent.ButtonClick
        Dim _type As ClassifierType = ClassifierType.FromType(_editedObject.GetType(), Session)
        Dim frm As Core.UI.ISelectionForm = _type.NewFormInstance(Session, ClassifierListMode.SingleSelect)
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            _editedObject.Parents = CType(frm.Selection, HierClassifier)
        End If
    End Sub

    Private Sub beParent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles beParent.KeyDown
        If e.KeyCode = DeleteKey Then
            beParent.EditValue = Nothing
        End If
    End Sub
End Class
' Lūdzu, Юникод
