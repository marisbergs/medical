Imports Entities
Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Core.UI

Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmClassifierList
    Implements ISelectionForm
    Private clickPlace As GridHitInfo

#Region "Constructor"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal tp As Entities.ClassifierType, ByVal session As Core.Dal.ISession, ByVal formMode As ClassifierListMode)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.Session = session
        Me.grdClassifierList.DataSource = bndClassifiers
        AddHandler bndClassifiers.ListChanged, AddressOf bndClassifier_ListChanged
        AddHandler bndClassifiers.PositionChanged, AddressOf bndClassifier_PositionChanged
        InitUsingClassifierType(tp)
        clType = tp
        Me.FormMode = formMode
        'Get Classifier name, it is temporary code TODO: remove this code
        Me.Text = tp.Value

        'CanCreate new record & CanSave changes
        If tp.Kind.Value = ClassifierKindEnum.System Then
            btnAdd.Enabled = False
            btnSave.Enabled = True
        ElseIf tp.Kind.Value = ClassifierKindEnum.External Then
            btnAdd.Enabled = PermissionsChecker.CanDo("Classifier.External.Save")
            If Not PermissionsChecker.CanDo("Classifier.External.Save") And _
              Not tp.MemoPrompt Is Nothing And _
              PermissionsChecker.CanDo("Menu.ClassifierAdministration") Then
                'if external classifier have Notes then user can edit this record (only notes).
                btnSave.Enabled = True
                Return
            End If
            btnSave.Enabled = True
        Else
            btnAdd.Enabled = PermissionsChecker.CanDo("Menu.ClassifierAdministration")
            btnSave.Enabled = True
        End If
        If clType.CommentPrompt Is Nothing Then
            chkShowComments.Checked = False
        Else
            chkShowComments.Checked = True
        End If
        btnSendToCash.Visible = (tp.Id = "Services")
    End Sub

    Public Sub New(ByVal tp As Entities.ClassifierType)
        MyClass.New(tp, Nothing, ClassifierListMode.Edit)
        clType = tp

        'CanCreate new record
        If tp.Kind.Value = ClassifierKindEnum.System Then
            btnAdd.Enabled = False
        ElseIf tp.Kind.Value = ClassifierKindEnum.External Then
            btnAdd.Enabled = PermissionsChecker.CanDo("Classifier.External.Save")
        Else
            btnAdd.Enabled = PermissionsChecker.CanDo("Menu.ClassifierAdministration")
        End If
        If clType.CommentPrompt Is Nothing Then
            chkShowComments.Checked = False
        Else
            chkShowComments.Checked = True
        End If
    End Sub
#End Region

#Region "Variables"
    Dim bIsLoad As Boolean = False
    Public clType As ClassifierType
#End Region

#Region "Private methods"
    Private Function IsNull(ByVal x As Object, ByVal y As Object) As Object
        If IsNothing(x) Then Return y
        Return x
    End Function

    Private Function _SaveClassifier() As Boolean

        If Me.HasError() Then
            If CType(bndClassifiers.Current, Classifier).CanEdit Then
                ActivateErrorControls(Me.ErrorProvider1, Me)
                Core.UI.MsgBox.HasErrorMessage()
                Return False
            End If
        End If

        Try
            If Not Me.bndClassifiers.DataSource Is Nothing Then
                'Dim _list As Entities(Of Classifier) = Me.bndClassifiers.DataSource
                'Session.SaveOrUpdate(_list)
                For Each x As Object In bndClassifiers.List
                    Session.SaveOrUpdate(x)
                Next
                Session.Commit()
                colValue.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            End If
        Catch ex As Exception
            Core.UI.MsgBox.Show(Core.Err.CouldNotSave, MessageBoxButtons.OK)
            Return False
        End Try

        Return True
    End Function

    Private Sub ControlStates()
        If Not bIsLoad Then Exit Sub
        'Me.btnDelete.Enabled = IIf(Not IsNothing(CType(Me.bndClassifiers.Current, Classifier).ValidUntil), _
        '(CType(Me.bndClassifiers.Current, Classifier).ValidUntil.Value.Date > Now.Date), True)
    End Sub
#End Region

#Region "Public Property"
    Public Overrides Property FormMode() As ClassifierListMode
        Get
            Return _mode
        End Get
        Set(ByVal value As ClassifierListMode)
            _mode = value
            Select Case value
                Case ClassifierListMode.Edit
                    colSelected.Visible = False
                    btnAdd.Visible = True
                    btnDelete.Visible = True
                    If Not clType Is Nothing AndAlso Not clType.Kind Is Nothing Then
                        Me.btnActivate.Visible = (clType.Kind.Value = ClassifierKindEnum.External)
                    Else
                        Me.btnActivate.Visible = False
                    End If
                    btnOK.Visible = False
                    btnSave.Visible = True
                    grdClassifierList.SetEditMode()
                    ctlClassifierFind.chkActive.Enabled = True
                    chkShowComments.Visible = True
                    grdClassifierList.EnforceCanEdit = False
                    btnSendToCash.Visible = (clType.Id = "Services")
                    btnNextCode.Visible = (clType.Id = "Services")
                Case ClassifierListMode.MultiSelect
                        colSelected.Visible = True
                        btnAdd.Visible = False
                        btnDelete.Visible = False
                        btnActivate.Visible = False
                        btnOK.Visible = True
                        btnSave.Visible = False
                        grdClassifierList.SetListMode()
                        ctlClassifierFind.chkActive.Enabled = False
                        chkShowComments.Visible = False
                        btnExport.Visible = False
                        btnSendToCash.Visible = False
                        btnNextCode.Visible = False
                Case ClassifierListMode.SingleSelect
                        colSelected.Visible = False
                        btnAdd.Visible = False
                        btnDelete.Visible = False
                        btnActivate.Visible = False
                        btnOK.Visible = True
                        btnSave.Visible = False
                        grdClassifierList.SetListMode()
                        ctlClassifierFind.chkActive.Enabled = False
                        chkShowComments.Visible = False
                        btnExport.Visible = False
                        btnSendToCash.Visible = False
                        btnNextCode.Visible = False
            End Select
        End Set
    End Property

    Public Sub InitUsingClassifierType(ByVal typeEntity As Entities.ClassifierType)
        _typeEntity = typeEntity
        'colCode.Visible = Not typeEntity.CodePrompt Is Nothing
        colValue.Visible = Not typeEntity.ValuePrompt Is Nothing AndAlso FormMode = ClassifierListMode.Edit
        colValueEng.Visible = Not typeEntity.ValuePrompt Is Nothing AndAlso FormMode = ClassifierListMode.Edit
        colValueRus.Visible = Not typeEntity.ValuePrompt Is Nothing AndAlso FormMode = ClassifierListMode.Edit
        colDisplayValue.Visible = Not typeEntity.ValuePrompt Is Nothing AndAlso Not FormMode = ClassifierListMode.Edit
        colCode.Visible = Not typeEntity.CodePrompt Is Nothing
        colMemo.Visible = Not typeEntity.CommentPrompt Is Nothing
        colLookup.Visible = Not typeEntity.Lookup Is Nothing
        colReference.Visible = Not typeEntity.Reference Is Nothing
        colReference2.Visible = Not typeEntity.ReferenceSecond Is Nothing
        colReference3.Visible = Not typeEntity.ReferenceThird Is Nothing
        colReference4.Visible = Not typeEntity.ReferenceFourth Is Nothing
        colReference5.Visible = Not typeEntity.ReferenceFive Is Nothing
        colReference6.Visible = Not typeEntity.ReferenceFive Is Nothing
        colNumber.Visible = Not typeEntity.NumberPrompt Is Nothing
        colMark.Visible = Not typeEntity.MarkPrompt Is Nothing
        colMemoPrompt.Visible = Not typeEntity.MemoPrompt Is Nothing
        colSecondMark.Visible = Not typeEntity.SecondMarkPrompt Is Nothing
        colMaterialCost.Visible = Not typeEntity.MaterialCostPrompt Is Nothing
        colIntegerValue.Visible = (Not typeEntity.IntegerPrompt Is Nothing AndAlso Not typeEntity.IntegerPrompt = "Classifier.Color")
        colSecondIntegerValue.Visible = Not typeEntity.SecondIntegerPrompt Is Nothing
        colThirdIntegerValue.Visible = Not typeEntity.ThirdIntegerPrompt Is Nothing
        colFourIntegerValue.Visible = Not typeEntity.FourIntegerPrompt Is Nothing
        colColor.Visible = (Not typeEntity.IntegerPrompt Is Nothing AndAlso typeEntity.IntegerPrompt = "Classifier.Color")

        colCode.Caption = Core.Localization.Instance(typeEntity.CodePrompt)
        colMemo.Caption = Core.Localization.Instance(typeEntity.CommentPrompt)
        colValue.Caption = Core.Localization.Instance(typeEntity.ValuePrompt)
        colNumber.Caption = Core.Localization.Instance(typeEntity.NumberPrompt)
        colMark.Caption = Core.Localization.Instance(typeEntity.MarkPrompt)
        colSecondMark.Caption = Core.Localization.Instance(typeEntity.SecondMarkPrompt)
        colIntegerValue.Caption = Core.Localization.Instance(typeEntity.IntegerPrompt)
        colSecondIntegerValue.Caption = Core.Localization.Instance(typeEntity.SecondIntegerPrompt)
        colThirdIntegerValue.Caption = Core.Localization.Instance(typeEntity.ThirdIntegerPrompt)
        colFourIntegerValue.Caption = Core.Localization.Instance(typeEntity.FourIntegerPrompt)
        colMaterialCost.Caption = Core.Localization.Instance(typeEntity.MaterialCostPrompt)
        If colLookup.Visible Then colLookup.Caption = typeEntity.Lookup.Value
        If colReference.Visible Then colReference.Caption = Core.Localization.Instance("Classifier." & typeEntity.Reference.Id)
        If colReference2.Visible Then colReference2.Caption = Core.Localization.Instance("Classifier." & typeEntity.ReferenceSecond.Id)
        If colReference3.Visible Then colReference3.Caption = Core.Localization.Instance("Classifier." & typeEntity.ReferenceThird.Id)
        If colReference4.Visible Then colReference4.Caption = Core.Localization.Instance("Classifier." & typeEntity.ReferenceFourth.Id)
        If colReference5.Visible Then colReference5.Caption = Core.Localization.Instance("Classifier." & typeEntity.ReferenceFive.Id)
        If colReference6.Visible Then colReference6.Caption = Core.Localization.Instance("Classifier." & typeEntity.ReferenceSix.Id)
        Me.ctlClassifierFind.chkCode.Text = colCode.Caption
        Me.ctlClassifierFind.chkName.Text = colValue.Caption
        If colNumber.Visible Then
            txtDecimalValue.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txtDecimalValue.Mask.EditMask = "n" + typeEntity.DecimalPlace.Trim
            txtDecimalValue.Mask.UseMaskAsDisplayFormat = True
        End If


        Dim mi As MethodInfo = Me.GetType().GetMethod("GenericTrick")
        mi = mi.MakeGenericMethod(typeEntity.TypeObject)
        mi.Invoke(Me, Nothing)
    End Sub
#End Region

#Region "Private events"

    Private Sub frmClassifierList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If FormMode <> ClassifierListMode.Edit Then
            Return
        End If
        Dim coll As ITracksDirty = CType(bndClassifiers.DataSource, ITracksDirty)
        If Me.bIsChanged Or coll.IsDirty Then
            Dim result As Windows.Forms.DialogResult = Core.UI.MsgBox.SaveMessage()
            If result = Windows.Forms.DialogResult.No Then Exit Sub
            If result = Windows.Forms.DialogResult.Cancel Then e.Cancel = True

            If Not Me._SaveClassifier() Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmClassifierList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '' Me.Text = InputBox("Virsraksts:", "Ekrānšāviņiem", Me.Text)
        '        Dim localizer As New Core.UI.DevExpressLocalizer()
        '        DevExpress.XtraEditors.Controls.Localizer.Active = localizer
        bIsLoad = True
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.colValue.SortOrder = DevExpress.Data.ColumnSortOrder.None
        Dim obj As Classifier = CType(bndClassifiers.AddNew(), Classifier)
        ''HACK: needed to save
        obj.Value = ""
        obj.ValidFrom = Date.Today
        'Session.Save(obj)
        Me.bIsChanged = True
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Core.UI.MsgBox.DeleteMessage() = Windows.Forms.DialogResult.No Then Exit Sub
        'CType(Me.bndClassifiers.Current, Classifier).IsActive = False
        If CType(Me.bndClassifiers.Current, Classifier).Id = Guid.Empty Then
            bndClassifiers.Remove(Me.bndClassifiers.Current)
        Else
            CType(Me.bndClassifiers.Current, Classifier).Delete()
        End If
        Me.bIsChanged = True
        grdClassifierList.UpdateReadonlyRowStatus()
    End Sub

    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        If Core.UI.MsgBox.Show(Msg.ActivateConfirmation, MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.No Then Exit Sub
        CType(Me.bndClassifiers.Current, Classifier).Activate()
        Me.bIsChanged = True
    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        Dim form As New frmClassifierList(_typeEntity.Lookup)
        If form.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim editor As DevExpress.XtraEditors.ButtonEdit = CType(sender, DevExpress.XtraEditors.ButtonEdit)
            editor.EditValue = form.bndClassifiers.Current
        End If
    End Sub

    Private Sub ctlClassifierFind_Find(ByVal sender As System.Object, ByVal e As Client.FindEventArgs) Handles ctlClassifierFind.Find
        Dim coll As ITracksDirty = CType(bndClassifiers.DataSource, ITracksDirty)
        If (Me.bIsChanged Or coll.IsDirty) And Me.FormMode = ClassifierListMode.Edit Then
            Dim result As Windows.Forms.DialogResult = Core.UI.MsgBox.SaveMessage()
            If result = Windows.Forms.DialogResult.Cancel Then e.Cancel = True
            If result = Windows.Forms.DialogResult.Yes Then
                If Not Me._SaveClassifier Then
                    e.Cancel = True
                End If
                Me.bIsChanged = False
            ElseIf result = Windows.Forms.DialogResult.No Then
                Me.bIsChanged = False
                Session.Clear()
            End If
        End If

        If Not e.Cancel Then
            _criterion = e.Criteria
            Dim mi As MethodInfo = Me.GetType().GetMethod("GenericTrick")
            mi = mi.MakeGenericMethod(_typeEntity.TypeObject)
            mi.Invoke(Me, Nothing)
        End If

        If Not Me.bndClassifiers.Current Is Nothing AndAlso CType(Me.bndClassifiers.Current, Classifier).CanEditOnlyNotes Then
            colCode.OptionsColumn.AllowEdit = False
            colCode.OptionsColumn.ReadOnly = True
            colCode.OptionsColumn.AllowFocus = False

            colValue.OptionsColumn.AllowEdit = False
            colValue.OptionsColumn.ReadOnly = True
            colValue.OptionsColumn.AllowFocus = False

            colValidFrom.OptionsColumn.AllowEdit = False
            colValidFrom.OptionsColumn.ReadOnly = True
            colValidFrom.OptionsColumn.AllowFocus = False

            colValidUntil.OptionsColumn.AllowEdit = False
            colValidUntil.OptionsColumn.ReadOnly = True
            colValidUntil.OptionsColumn.AllowFocus = False

            colLookup.OptionsColumn.AllowEdit = False
            colLookup.OptionsColumn.ReadOnly = True
            colLookup.OptionsColumn.AllowFocus = False

            colNumber.OptionsColumn.AllowEdit = False
            colNumber.OptionsColumn.ReadOnly = True
            colNumber.OptionsColumn.AllowFocus = False
        End If
    End Sub

    Private Sub CtlClassifierFind_GetPresets(ByVal sender As Object, ByVal e As GetPresetsEventArgs) Handles ctlClassifierFind.GetPresets
        e.Presets = _searchPresets
    End Sub

    Private Sub bndClassifier_CurrentItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndClassifiers.CurrentItemChanged
        ControlStates()
    End Sub

    Private _searchPresets As Queue(Of KeyValuePair(Of String, Object))

    Public Overrides WriteOnly Property SearchObjectPropertyPresets() As Queue(Of KeyValuePair(Of String, Object)) Implements ISelectionForm.SearchObjectPropertyPresets
        Set(ByVal value As Queue(Of KeyValuePair(Of String, Object)))
            _searchPresets = value
        End Set
    End Property

#End Region

    Private Sub chkShowComments_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowComments.Click
        If chkShowComments.Checked Then
            clType.CommentPrompt = "Classifier.CommentPrompt"
            colMemo.Visible = True
            colMemo.Caption = Core.Localization.Instance(clType.CommentPrompt)
            If Me.FormMode = ClassifierListMode.Edit Then
                Dim _session As Core.Dal.ISession = Manager.Instance.OpenSession()
                _session.Replicate(clType, NHibernate.ReplicationMode.Overwrite)
                _session.SaveOrUpdate(clType)
                _session.Commit()
            End If
        Else
            clType.CommentPrompt = Nothing
            colMemo.Visible = False
            If Me.FormMode = ClassifierListMode.Edit Then
                Dim _session As Core.Dal.ISession = Manager.Instance.OpenSession()
                _session.Replicate(clType, NHibernate.ReplicationMode.Overwrite)
                _session.SaveOrUpdate(clType)
                _session.Commit()
            End If
        End If
    End Sub

    Private Sub bndClassifier_ListChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs)
        EditComments()
    End Sub

    Private Sub bndClassifier_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        EditComments()
    End Sub

    Private Sub EditComments()
        If Me.FormMode = ClassifierListMode.Edit Then
            If Not bndClassifiers.Current Is Nothing Then
                GridView1.OptionsBehavior.Editable = True
                colCode.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).CanEdit
                colValue.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).CanEdit
                colValidFrom.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).CanEdit
                colValidUntil.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).CanEdit
                colMark.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).IsActive
                colNumber.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).CanEdit
                colIntegerValue.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).CanEdit
                colSecondIntegerValue.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).CanEdit
                colThirdIntegerValue.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).CanEdit
                colLookup.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).CanEdit
                colReference.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).CanEdit
                colMaterialCost.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).CanEdit
                colMemo.OptionsColumn.AllowEdit = CType(bndClassifiers.Current, Classifier).IsActive
            End If
        End If
    End Sub

    Private Sub txtClassifier_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtClassifier.ButtonClick
        Dim frm As New frmClassifierList(_typeEntity.Lookup, Session, ClassifierListMode.SingleSelect)
        frm.FormMode = ClassifierListMode.SingleSelect
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub txtReference_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtReference.ButtonClick
        Dim frm As New frmClassifierList(_typeEntity.Reference, Session, ClassifierListMode.SingleSelect)
        frm.FormMode = ClassifierListMode.SingleSelect
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub txtReference_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReference.KeyDown, txtClassifier.KeyDown, txtReference2.KeyDown
        If e.KeyCode = Keys.Delete Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = Nothing
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        grdClassifierList.Export()
    End Sub
    Private Sub txtReference2_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtReference2.ButtonClick
        Dim frm As New frmClassifierList(_typeEntity.ReferenceSecond, Session, ClassifierListMode.SingleSelect)
        frm.FormMode = ClassifierListMode.SingleSelect
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub grdClassifierList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdClassifierList.DoubleClick
        If clickPlace Is Nothing Then
            Return
        End If
        'If FindForm.GetType().ToString() = GetType(frmTPCaseTree).ToString() Then
        If clickPlace.HitTest = GridHitTest.RowCell Then
            If FormMode = ClassifierListMode.SingleSelect Then
                btnOK.PerformClick()
            End If
        End If
    End Sub

    Private Sub grdClassifierList_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdClassifierList.MouseMove
        clickPlace = GridView1.CalcHitInfo(e.X, e.Y)
    End Sub

    Private Sub txtReference3_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtReference3.ButtonClick
        Dim frm As New frmClassifierList(_typeEntity.ReferenceThird, Session, ClassifierListMode.SingleSelect)
        frm.FormMode = ClassifierListMode.SingleSelect
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub txtReference4_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtReference4.ButtonClick
        Dim frm As New frmClassifierList(_typeEntity.ReferenceFourth, Session, ClassifierListMode.SingleSelect)
        frm.FormMode = ClassifierListMode.SingleSelect
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub GridView1_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        If (GridView1.FocusedColumn.Name = colFourIntegerValue.Name) Then
            Dim res As Integer
            If String.IsNullOrEmpty(e.Value) OrElse Integer.TryParse(e.Value, res) Then
                e.Valid = True
            End If
        End If
    End Sub

    Private Sub btnSendToCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendToCash.Click
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("select a.cls_code +';'+ '0' +';" & Chr(34) & "'+ ISNULL(a.cls_text, '') +'" & Chr(34) & ";'+ ")
        sb.AppendLine("isnull(b.cls_code, '5')+';0;'+  ")
        sb.AppendLine("case b.cls_code when 2 then '1' when 3 then '2' when 4 then '3' else '0' end +';0;0;0;0;0;0;0;0'  ")
        sb.AppendLine("from classifiers a ")
        sb.AppendLine("left join classifiers b on a.cls_reference_id = b.cls_id  ")
        sb.AppendLine("where a.cls_type_id='services' and a.cls__delete_time is null ")
        sb.AppendLine("order by 1")
        Dim str As New System.Text.StringBuilder()
        Dim cmd As New System.Data.SqlClient.SqlCommand(sb.ToString(), Session.Connection)
        Dim dr As System.Data.SqlClient.SqlDataReader = cmd.ExecuteReader()
        With dr
            While dr.Read()
                str.AppendLine(dr.Item(0).ToString())
            End While
        End With
        dr.Close()
        System.IO.File.WriteAllText("C:\CHD3550\Standart PC\res.csv", str.ToString(), System.Text.Encoding.Default)
        System.IO.File.WriteAllText("C:\CHD3550\Standart PC\run.bat", "C:\CHD3550\Standa~1\chd_drv.exe 500 C:\CHD3550\Standa~1\res.csv", System.Text.Encoding.Default)
        Helper.RunShell("C:\CHD3550\Standart PC\run.bat")
    End Sub

    Private Sub btnNextCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextCode.Click
        If bndClassifiers.Current Is Nothing OrElse Not String.IsNullOrEmpty(CType(bndClassifiers.Current, Classifier).Code) Then
            Return
        End If
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("select max(cls_code)")
        sb.AppendLine("from classifiers ")
        sb.AppendLine("where cls_type_id='" & bndClassifiers.Current.GetType().Name & "' and cls__delete_time is null ")
        Dim str As New System.Text.StringBuilder()
        Dim cmd As New System.Data.SqlClient.SqlCommand(sb.ToString(), Session.Connection)
        Dim res As Object = cmd.ExecuteScalar()
        Dim newCode As Integer
        If Not res Is Nothing AndAlso Integer.TryParse(res.ToString(), newCode) Then
            CType(bndClassifiers.Current, Classifier).Code = newCode + 1
        End If

    End Sub

    Private Sub txtReference5_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtReference5.ButtonClick
        Dim frm As New frmClassifierList(_typeEntity.ReferenceFive, Session, ClassifierListMode.SingleSelect)
        frm.FormMode = ClassifierListMode.SingleSelect
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub txtReference6_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtReference6.ButtonClick
        Dim frm As New frmClassifierList(_typeEntity.ReferenceSix, Session, ClassifierListMode.SingleSelect)
        frm.FormMode = ClassifierListMode.SingleSelect
        frm.Selection = Nothing
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = frm.Selection
        End If
    End Sub

    Private Sub txtReference6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReference6.KeyDown
        If e.KeyCode = Keys.Delete Then
            CType(sender, DevExpress.XtraEditors.ButtonEdit).EditValue = Nothing
        End If
    End Sub
End Class



' Lūdzu, Юникод!
