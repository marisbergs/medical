Imports Core
Imports Core.UI

''' <summary>
''' Bāzes kontrole visādiem tur searchiem
''' </summary>
''' <remarks>
''' Novietojiet uz tās savu TableLayout ar atlases kritērijiem (Dock: Fill).
''' Šo layoutu izvēlieties kontroles propertijā CriteriaTable
''' </remarks>
Public Class ctlFind

    Private _criteriaTable As System.Windows.Forms.TableLayoutPanel
    Private _criteriaDisplayStatus As Boolean = False

    <System.ComponentModel.Category("Behaviour")> _
    <System.ComponentModel.Description("Table layout with search criteria")> _
    Public Property CriteriaTable() As System.Windows.Forms.TableLayoutPanel
        Get
            Return _criteriaTable
        End Get
        Set(ByVal value As System.Windows.Forms.TableLayoutPanel)
            _criteriaTable = value
        End Set
    End Property

    Private Sub bndFind_DataSourceChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bndFind.DataSourceChanged
        BindByNamingConventions()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If bndFind.DataSource Is Nothing Then Return
        If Not (TypeOf bndFind.DataSource Is Core.Bll.ISearchObject) Then Return
        If (TypeOf bndFind.DataSource Is Core.Bll.IBusinessObjectBase) And Not CType(bndFind.DataSource, Core.Bll.IBusinessObjectBase).IsValid Then Return
        Dim criteria As IList(Of Core.Dal.Expressions.CriterionBase)
        criteria = CType(bndFind.DataSource, Core.Bll.ISearchObject).BuildCriteria()
        Dim eventArgs As New FindEventArgs(criteria)
        OnFind(eventArgs)
        If Not eventArgs.Cancel Then
            Me.Collapse()
            btnShowAll.Visible = True
            btnHideNonChecked.Visible = False
        End If
    End Sub

    Public Sub Search()
        btnSearch.PerformClick()
    End Sub
    

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        Me.Expand()
        btnShowAll.Visible = False
        btnHideNonChecked.Visible = True
    End Sub

    Private Sub btnHideNonChecked_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHideNonChecked.Click
        Me.Collapse()
        btnShowAll.Visible = True
        btnHideNonChecked.Visible = False
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        If DesignerDetector.IsComponentInDesignMode(Me) Then Return
        MyBase.OnLoad(e)
        If Not DesignMode AndAlso Tag Is Nothing Then
            Me.SetupEnabledWhenCheckedBindings()
            Dim pe As New GetPresetsEventArgs()
            OnGetPresets(pe)
            Core.ReflectionHelper.SetProperties(bndFind.DataSource, pe.Presets)
            btnSearch.PerformClick()
        End If
    End Sub

    Public Event GetPresets As GetPresetsEventHandler

    Protected Overridable Sub OnGetPresets(ByVal e As GetPresetsEventArgs)
        RaiseEvent GetPresets(Me, e)
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If Not (TypeOf bndFind.DataSource Is Core.Bll.ISearchObject) Then Return

        'Dim chk As Client.ClassifierPicker = _criteriaTable.GetControlFromPosition(1, 0)
        CType(bndFind.DataSource, Core.Bll.ISearchObject).ResetValues(CType(Me.FindForm(), Core.frmBase).Session)
        'chk.Refresh()

        Dim rowCount As Integer = _criteriaTable.GetRowHeights().Length
        Dim _listBox As DevExpress.XtraEditors.CheckedListBoxControl
        _criteriaTable.SuspendLayout()
        Try
            For r As Integer = 0 To rowCount - 1
                Dim cp As Control = _criteriaTable.GetControlFromPosition(1, r)
                If Not (cp Is Nothing) And (TypeOf cp Is Core.UI.ListPicker) Then
                    If TypeOf CType(cp, Core.UI.ListPicker).Properties.PopupControl.Controls.Item(0) Is DevExpress.XtraEditors.CheckedListBoxControl Then
                        _listBox = CType(CType(cp, Core.UI.ListPicker).Properties.PopupControl.Controls.Item(0), DevExpress.XtraEditors.CheckedListBoxControl)
                        For i As Integer = _listBox.CheckedIndices.Count - 1 To 0 Step -1
                            _listBox.SetItemChecked(_listBox.CheckedIndices(i), False)
                        Next
                    End If
                End If
            Next
        Finally
            _criteriaTable.ResumeLayout()
        End Try
        Me.Collapse()
        Me.btnReset.Focus()
        btnShowAll.Visible = True
        btnHideNonChecked.Visible = False
    End Sub

    Public Event Find As FindEventHandler

    Protected Overridable Sub OnFind(ByVal e As FindEventArgs)
        RaiseEvent Find(Me, e)
    End Sub

    Private Sub Collapse()
        Dim rowCount As Integer = _criteriaTable.GetRowHeights().Length
        Dim colCount As Integer = _criteriaTable.GetColumnWidths().Length
        _criteriaTable.SuspendLayout()
        Try
            For r As Integer = 0 To rowCount - 1
                Dim chk As Control = _criteriaTable.GetControlFromPosition(0, r)
                Dim cp As Control = _criteriaTable.GetControlFromPosition(1, r)
                If Not (chk Is Nothing) And (TypeOf chk Is CheckBox) Then
                    If Not (chk.Enabled And CType(chk, CheckBox).Checked) Then
                        For c As Integer = 0 To colCount - 1
                            Dim ctl As Control = _criteriaTable.GetControlFromPosition(c, r)
                            If Not ctl Is Nothing Then ctl.Visible = False
                        Next
                    End If
                End If
                If Not (cp Is Nothing) And (TypeOf cp Is Client.ClassifierPicker) Then
                    CType(cp, Client.ClassifierPicker).Refresh()
                    CType(cp, Client.ClassifierPicker).Select(0, 0)
                End If
            Next
        Finally
            _criteriaTable.ResumeLayout()
        End Try
        btnShowAll.Enabled = True
    End Sub

    Private Sub Expand()
        Dim rowCount As Integer = _criteriaTable.GetRowHeights().Length
        Dim colCount As Integer = _criteriaTable.GetColumnWidths().Length
        _criteriaTable.SuspendLayout()
        Try
            For r As Integer = rowCount - 1 To 0 Step -1
                Dim visible As Boolean = True
                ' Hide (or keep hidden) row if there is a disabled checkbox in column 0
                Dim chk As Control = _criteriaTable.GetControlFromPosition(0, r)
                If TypeOf chk Is CheckBox Then visible = CType(chk, CheckBox).Enabled
                For c As Integer = 0 To colCount - 1
                    Dim ctl As Control = _criteriaTable.GetControlFromPosition(c, r)
                    If Not ctl Is Nothing Then ctl.Visible = visible
                Next
            Next
        Finally
            _criteriaTable.ResumeLayout()
        End Try
        btnShowAll.Enabled = False
    End Sub

    Private Sub SetupEnabledWhenCheckedBindings()
        Dim rowCount As Integer = _criteriaTable.GetRowHeights().Length
        Dim colCount As Integer = _criteriaTable.GetColumnWidths().Length
        _criteriaTable.SuspendLayout()
        Try
            For r As Integer = 0 To rowCount - 1
                Dim chk As Control = _criteriaTable.GetControlFromPosition(0, r)
                If Not (chk Is Nothing) And (TypeOf chk Is CheckBox) Then
                    For c As Integer = 1 To colCount - 1
                        Dim ctl As Control = _criteriaTable.GetControlFromPosition(c, r)
                        If Not (ctl Is Nothing) Then
                            ctl.DataBindings.Add("Enabled", chk, "Checked")
                        End If
                    Next
                End If
            Next
        Finally
            _criteriaTable.ResumeLayout(False)
        End Try
    End Sub

    Private Sub BindByNamingConventions()

        If _criteriaTable Is Nothing Then Return
        If bndFind.DataSource Is Nothing Then Return
        If TypeOf bndFind.DataSource Is Type Then Return

        Dim rowCount As Integer = _criteriaTable.GetRowHeights().Length
        Dim colCount As Integer = _criteriaTable.GetColumnWidths().Length
        _criteriaTable.SuspendLayout()
        Try
            For r As Integer = 0 To rowCount - 1
                For c As Integer = 0 To colCount - 1
                    Dim ctl As Control = _criteriaTable.GetControlFromPosition(c, r)
                    If Not (ctl Is Nothing) Then
                        BindRecursive(ctl, "")
                    End If
                Next
            Next
        Finally
            _criteriaTable.ResumeLayout(False)
        End Try
        ' Don't forget about chkActive
        'If CType(FindForm(), ISelectionForm).FormMode = ClassifierListMode.Edit Then
        BindRecursive(chkActive, "")
        'End If
        bndFind.ResetBindings(True)
    End Sub

    Private Sub BindRecursive(ByVal ctl As Control, ByVal prefix As [String])
        If TypeOf ctl Is CheckBox And ctl.Name.Substring(0, 3) = "chk" Then
            AddBinding(ctl, "Checked", "Use" + prefix + ctl.Name.Substring(3), Nothing, False, DataSourceUpdateMode.OnPropertyChanged)
            AddBinding(ctl, "Enabled", "CanUse" + prefix + ctl.Name.Substring(3), Nothing, True, DataSourceUpdateMode.Never)
        ElseIf TypeOf ctl Is ClassifierPicker And ctl.Name.Substring(0, 3) = "txt" Then
            AddBinding(ctl, "EditValue", prefix + ctl.Name.Substring(3), , True, DataSourceUpdateMode.OnPropertyChanged) ' customFormat is bs
        ElseIf TypeOf ctl Is ListPicker And ctl.Name.Substring(0, 3) = "cmb" Then
            AddBinding(ctl, "EditValue", prefix + ctl.Name.Substring(3))
        ElseIf TypeOf ctl Is DevExpress.XtraEditors.ComboBoxEdit And ctl.Name.Substring(0, 3) = "cmb" Then
            AddBinding(ctl, "EditValue", prefix + ctl.Name.Substring(3))
        ElseIf TypeOf ctl Is DevExpress.XtraEditors.DateEdit And ctl.Name.Substring(0, 3) = "dtp" Then
            AddBinding(ctl, "EditValue", prefix + ctl.Name.Substring(3))
        ElseIf TypeOf ctl Is DevExpress.XtraEditors.DateEdit And ctl.Name.Substring(0, 3) = "dtp" Then
            AddBinding(ctl, "EditValue", prefix + ctl.Name.Substring(3))
        ElseIf TypeOf ctl Is DevExpress.XtraEditors.TimeEdit And ctl.Name.Substring(0, 3) = "dtp" Then
            AddBinding(ctl, "EditValue", prefix + ctl.Name.Substring(3))
        ElseIf TypeOf ctl Is DevExpress.XtraEditors.ButtonEdit And ctl.Name.Substring(0, 3) = "txt" Then
            AddBinding(ctl, "EditValue", prefix + ctl.Name.Substring(3), "1") ' customFormat is bs
        ElseIf TypeOf ctl Is TextBox And ctl.Name.Substring(0, 3) = "txt" Then
            AddBinding(ctl, "Text", prefix + ctl.Name.Substring(3))
        ElseIf TypeOf ctl Is Core.UI.TimeEdit And ctl.Name.Substring(0, 3) = "dtp" Then
            AddBinding(ctl, "EditValue", prefix + ctl.Name.Substring(3))
            '' ElseIf TypeOf ctl Is ComboBox And ctl.Name.Substring(0, 3) = "cmb" Then
            '' AddBinding(ctl, "SelectedValue", prefix + ctl.Name.Substring(3))
            'ElseIf TypeOf ctl Is DevExpress.XtraEditors.ComboBoxEdit And ctl.Name.Substring(0, 3) = "cmb" Then
            '    AddBinding(ctl, "EditValue", prefix + ctl.Name.Substring(3))
        Else
            For Each child As Control In ctl.Controls
                If child.Name.Length > 3 Then ' Ignore some internal components
                    BindRecursive(child, prefix + ctl.Name.Substring(3))
                End If
            Next child
        End If
    End Sub

    Private Sub AddBinding(ByVal ctl As Control, ByVal propertyName As String, ByVal dataMember As String, _
        Optional ByVal customFormat As String = Nothing, Optional ByVal suppressWarning As Boolean = False, Optional ByVal dsUpdateMode As DataSourceUpdateMode = DataSourceUpdateMode.OnValidation)
        If Core.ReflectionHelper.PropertyExists(bndFind.DataSource, dataMember) Then
            Try
                If customFormat Is Nothing Then
                    ctl.DataBindings.Add(propertyName, bndFind, dataMember, True, dsUpdateMode)
                Else
                    ctl.DataBindings.Add(propertyName, bndFind, dataMember, True, dsUpdateMode, Nothing, customFormat)
                End If
            Catch e As Exception
#If DEBUG Then
                MessageBox.Show(String.Format("Problem when binding {0}.{1} to {2} : {3}", ctl.Name, propertyName, dataMember, e.Message))
#End If
            End Try
        ElseIf Not suppressWarning Then
#If DEBUG Then
            MessageBox.Show(String.Format("Cannot find data member {2} for binding of {0}.{1}", ctl.Name, propertyName, dataMember))
#End If
        End If
    End Sub


    Public Sub SetDefaultParam(ByVal paramName As String, ByVal param As IList)
        CType(Me._criteriaTable.Controls("chk" & paramName), CheckBox).Checked = True
        CType(Me._criteriaTable.Controls("txt" & paramName), Client.ClassifierPicker).EditValue = param
    End Sub

End Class

Public Class FindEventArgs
    Inherits System.ComponentModel.CancelEventArgs

    Private _criteria As IList(Of Core.Dal.Expressions.CriterionBase)
    Public Property Criteria() As IList(Of Core.Dal.Expressions.CriterionBase)
        Get
            Return _criteria
        End Get
        Set(ByVal value As IList(Of Core.Dal.Expressions.CriterionBase))
            _criteria = value
        End Set
    End Property

    Public Sub New(ByVal criteria As IList(Of Core.Dal.Expressions.CriterionBase))
        Cancel = False
        _criteria = criteria
    End Sub

End Class

Public Delegate Sub FindEventHandler(ByVal sender As Object, ByVal e As FindEventArgs)

Public Class GetPresetsEventArgs
    Inherits System.EventArgs

    Private _presets As Queue(Of KeyValuePair(Of String, Object))
    Public Property Presets() As Queue(Of KeyValuePair(Of String, Object))
        Get
            Return _presets
        End Get
        Set(ByVal value As Queue(Of KeyValuePair(Of String, Object)))
            _presets = value
        End Set
    End Property

    Public Sub New()
        _presets = Nothing
    End Sub

End Class

Public Delegate Sub GetPresetsEventHandler(ByVal sender As Object, ByVal e As GetPresetsEventArgs)

' Lūdzu, Юникод!