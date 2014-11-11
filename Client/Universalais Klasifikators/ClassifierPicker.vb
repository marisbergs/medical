Imports System.ComponentModel

Imports Core.UI
Imports Entities
Imports Core.Dal


Public Class ClassifierPicker
    Inherits DevExpress.XtraEditors.ButtonEdit
    Implements Core.UI.IPickerSupportsPresets

    Private _multiSelect As Boolean
    Private _entityType As Type

    Friend Shadows WithEvents fProperties As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit

    Public Sub New()
        MyBase.New()
        AddHandler Me.DataBindings.CollectionChanged, New CollectionChangeEventHandler(AddressOf DataBindings_CollectionChanged)
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.fProperties = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        CType(Me.fProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fProperties
        '
        Me.fProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.fProperties.Name = "fProperties"
        Me.fProperties.ReadOnly = True
        '
        'ClassifierPicker
        '
        CType(Me.fProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub DataBindings_CollectionChanged(ByVal sender As Object, ByVal e As CollectionChangeEventArgs)
        If e.Action = CollectionChangeAction.Add OrElse e.Action = CollectionChangeAction.Refresh Then
            If Not e.Element Is Nothing AndAlso TypeOf e.Element Is Binding Then
                If CType(e.Element, Binding).PropertyName = "EditValue" Then
                    Dim b As Binding = Me.DataBindings("EditValue")
                    If Not b Is Nothing Then
                        Dim ds As Object = b.DataSource
                        If ds.GetType() Is GetType(BindingSource) Then
                            If Not CType(ds, BindingSource).DataSource Is Nothing Then
                                _entityType = BindingHelper.BoundTypeFinder(Me, "EditValue", _multiSelect)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ClassifierPicker_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles MyBase.ButtonClick
        If _entityType Is Nothing Then
            For Each x As Binding In Me.DataBindings
                If x.PropertyName = "EditValue" Then
                    Dim b As Binding = Me.DataBindings("EditValue")
                    If Not b Is Nothing Then
                        Dim ds As Object = b.DataSource
                        If ds.GetType() Is GetType(BindingSource) Then
                            If Not CType(ds, BindingSource).DataSource Is Nothing Then
                                _entityType = BindingHelper.BoundTypeFinder(Me, "EditValue", _multiSelect)
                            End If
                        End If
                    End If
                End If
            Next
            If _entityType Is Nothing Then
                Return
            End If
        End If

        Dim session As ISession = CType(FindForm(), Core.frmBase).Session
        Dim editor As DevExpress.XtraEditors.ButtonEdit = CType(sender, DevExpress.XtraEditors.ButtonEdit)
        Dim classifierType As Entities.ClassifierType = Entities.ClassifierType.FromType(_entityType, session)
        Dim form As ISelectionForm = classifierType.NewFormInstance(session, IIf(_multiSelect, ClassifierListMode.MultiSelect, ClassifierListMode.SingleSelect))
        form.FormMode = IIf(_multiSelect, ClassifierListMode.MultiSelect, ClassifierListMode.SingleSelect)
        form.Selection = editor.EditValue
        form.SearchObjectPropertyPresets = PickerPresets

        If (form.ShowDialog() = DialogResult.OK) Then
            If Not form.Selection Is Nothing Then
                If CType(form.Selection, Core.Bll.IBusinessObjectBase).Object.GetType().Name = "User" And form.FormMode = ClassifierListMode.SingleSelect And CObj(form).GetType.Name = "frmUsers" Then
                    If Not CType(form, frmUsers).Deputy Is Nothing Then
                        editor.EditValue = CType(form, frmUsers).Deputy
                        editor.Tag = form.Selection
                        If Not editor.DataBindings.Item("Tag") Is Nothing Then
                            editor.DataBindings.Item("Tag").WriteValue()
                        End If
                        Exit Sub
                    Else
                        editor.Tag = Nothing
                        If Not editor.DataBindings.Item("Tag") Is Nothing Then
                            editor.DataBindings.Item("Tag").WriteValue()
                        End If
                    End If
                End If
                editor.EditValue = form.Selection
            End If
        End If
    End Sub

    Private _pickerPresets As Queue(Of KeyValuePair(Of String, Object))

    <Browsable(False)> _
    Public Property PickerPresets() As Queue(Of KeyValuePair(Of String, Object)) Implements IPickerSupportsPresets.PickerPresets
        Get
            Return _pickerPresets
        End Get
        Set(ByVal value As Queue(Of KeyValuePair(Of String, Object)))
            _pickerPresets = value
        End Set
    End Property

    Private Sub ClassifierPicker_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Core.frmBase.DeleteKey Then
            Me.EditValue = Nothing
        End If
    End Sub
End Class
