<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassifierList
    Inherits frmUniversalClassifierBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ctlClassifierFind = New Client.ctlClassifierFind()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnSendToCash = New System.Windows.Forms.Button()
        Me.btnNextCode = New System.Windows.Forms.Button()
        Me.grdClassifierList = New Core.UI.CoreGrid()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtValue = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colValueRus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValueEng = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterialCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDecimalValue = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colMemoPrompt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtColor = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
        Me.colFourIntegerValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colValidFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colValidUntil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colSecondMark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colMark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLookup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtClassifier = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntegerValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colReference = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtReference = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colReference2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtReference2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colReference3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtReference3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colReference4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtReference4 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colReference5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtReference5 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colReference6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtReference6 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSecondIntegerValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colThirdIntegerValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkShowComments = New System.Windows.Forms.CheckBox()
        Me.colDisplayValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.bndClassifiers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.grdClassifierList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDecimalValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClassifier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel3)
        Me.Panel1.Location = New System.Drawing.Point(0, 542)
        Me.Panel1.Size = New System.Drawing.Size(912, 31)
        Me.Panel1.Controls.SetChildIndex(Me.FlowLayoutPanel3, 0)
        '
        'bndClassifiers
        '
        '
        'colSelected
        '
        Me.colSelected.Caption = "Izvēlēts"
        Me.colSelected.FieldName = "Selected"
        Me.colSelected.Name = "colSelected"
        Me.colSelected.Visible = True
        Me.colSelected.VisibleIndex = 0
        Me.colSelected.Width = 48
        '
        'ctlClassifierFind
        '
        Me.ctlClassifierFind.AutoSize = True
        Me.ctlClassifierFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctlClassifierFind.Dock = System.Windows.Forms.DockStyle.Top
        Me.ctlClassifierFind.Location = New System.Drawing.Point(0, 0)
        Me.ctlClassifierFind.MaximumSize = New System.Drawing.Size(0, 155)
        Me.ctlClassifierFind.MinimumSize = New System.Drawing.Size(403, 0)
        Me.ctlClassifierFind.Name = "ctlClassifierFind"
        Me.ctlClassifierFind.Size = New System.Drawing.Size(912, 108)
        Me.ctlClassifierFind.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(243, 29)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.btnOK)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnActivate)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnExport)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnSendToCash)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnNextCode)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(743, 31)
        Me.FlowLayoutPanel3.TabIndex = 2
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Labi"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(84, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Pievienot"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndClassifiers, "CanDelete", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDelete.Location = New System.Drawing.Point(165, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Dzēst"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnActivate
        '
        Me.btnActivate.AutoSize = True
        Me.btnActivate.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndClassifiers, "CanActivate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnActivate.Location = New System.Drawing.Point(246, 3)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(75, 23)
        Me.btnActivate.TabIndex = 3
        Me.btnActivate.Text = "Atjaunot"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.AutoSize = True
        Me.btnExport.Location = New System.Drawing.Point(327, 3)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "Eksportēt"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnSendToCash
        '
        Me.btnSendToCash.AutoSize = True
        Me.btnSendToCash.Location = New System.Drawing.Point(408, 3)
        Me.btnSendToCash.Name = "btnSendToCash"
        Me.btnSendToCash.Size = New System.Drawing.Size(232, 23)
        Me.btnSendToCash.TabIndex = 5
        Me.btnSendToCash.Text = "Atjaunot kases aparāta pakalpojumu sarakstu"
        Me.btnSendToCash.UseVisualStyleBackColor = True
        '
        'btnNextCode
        '
        Me.btnNextCode.AutoSize = True
        Me.btnNextCode.Location = New System.Drawing.Point(646, 3)
        Me.btnNextCode.Name = "btnNextCode"
        Me.btnNextCode.Size = New System.Drawing.Size(90, 23)
        Me.btnNextCode.TabIndex = 6
        Me.btnNextCode.Text = "Nākamais kods"
        Me.btnNextCode.UseVisualStyleBackColor = True
        '
        'grdClassifierList
        '
        Me.grdClassifierList.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdClassifierList.EmbeddedNavigator.Name = ""
        Me.grdClassifierList.EnforceCanEdit = False
        Me.grdClassifierList.Location = New System.Drawing.Point(0, 133)
        Me.grdClassifierList.MainView = Me.GridView1
        Me.grdClassifierList.Name = "grdClassifierList"
        Me.grdClassifierList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1, Me.txtClassifier, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.txtDecimalValue, Me.txtCode, Me.RepositoryItemCheckEdit1, Me.txtValue, Me.txtReference, Me.RepositoryItemTextEdit1, Me.txtColor, Me.txtReference2, Me.txtReference3, Me.txtReference4, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.txtReference5, Me.txtReference6})
        Me.grdClassifierList.ShowOnlyActive = False
        Me.grdClassifierList.Size = New System.Drawing.Size(912, 409)
        Me.grdClassifierList.TabIndex = 5
        Me.grdClassifierList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSelected, Me.colCode, Me.colValue, Me.colValueRus, Me.colValueEng, Me.colDisplayValue, Me.colMaterialCost, Me.colMemoPrompt, Me.colColor, Me.colFourIntegerValue, Me.colValidFrom, Me.colValidUntil, Me.colMemo, Me.colSecondMark, Me.colMark, Me.colLookup, Me.colNumber, Me.colIntegerValue, Me.colReference, Me.colReference2, Me.colReference3, Me.colReference4, Me.colReference5, Me.colReference6, Me.GridColumn1, Me.colSecondIntegerValue, Me.colThirdIntegerValue})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colSelected
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.grdClassifierList
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.PaintStyleName = "MixedXP"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colValue, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCode
        '
        Me.colCode.Caption = "Kods"
        Me.colCode.ColumnEdit = Me.txtCode
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 1
        '
        'txtCode
        '
        Me.txtCode.AutoHeight = False
        Me.txtCode.MaxLength = 50
        Me.txtCode.Name = "txtCode"
        '
        'colValue
        '
        Me.colValue.Caption = "Nosaukums"
        Me.colValue.ColumnEdit = Me.txtValue
        Me.colValue.FieldName = "Value"
        Me.colValue.Name = "colValue"
        Me.colValue.Visible = True
        Me.colValue.VisibleIndex = 2
        Me.colValue.Width = 185
        '
        'txtValue
        '
        Me.txtValue.Name = "txtValue"
        '
        'colValueRus
        '
        Me.colValueRus.Caption = "Nosaukums RUS"
        Me.colValueRus.ColumnEdit = Me.txtValue
        Me.colValueRus.FieldName = "ValueRUS"
        Me.colValueRus.Name = "colValueRus"
        Me.colValueRus.Visible = True
        Me.colValueRus.VisibleIndex = 3
        Me.colValueRus.Width = 145
        '
        'colValueEng
        '
        Me.colValueEng.Caption = "Nosaukums ENG"
        Me.colValueEng.ColumnEdit = Me.txtValue
        Me.colValueEng.FieldName = "ValueENG"
        Me.colValueEng.Name = "colValueEng"
        Me.colValueEng.Visible = True
        Me.colValueEng.VisibleIndex = 4
        Me.colValueEng.Width = 149
        '
        'colMaterialCost
        '
        Me.colMaterialCost.Caption = "GridColumn2"
        Me.colMaterialCost.ColumnEdit = Me.txtDecimalValue
        Me.colMaterialCost.FieldName = "MaterialCost"
        Me.colMaterialCost.Name = "colMaterialCost"
        Me.colMaterialCost.Visible = True
        Me.colMaterialCost.VisibleIndex = 9
        '
        'txtDecimalValue
        '
        Me.txtDecimalValue.AutoHeight = False
        Me.txtDecimalValue.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDecimalValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDecimalValue.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDecimalValue.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 131072})
        Me.txtDecimalValue.MinValue = New Decimal(New Integer() {9999999, 0, 0, -2147352576})
        Me.txtDecimalValue.Name = "txtDecimalValue"
        '
        'colMemoPrompt
        '
        Me.colMemoPrompt.Caption = "Īsais nosaukums"
        Me.colMemoPrompt.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colMemoPrompt.FieldName = "Text"
        Me.colMemoPrompt.Name = "colMemoPrompt"
        Me.colMemoPrompt.Visible = True
        Me.colMemoPrompt.VisibleIndex = 6
        Me.colMemoPrompt.Width = 108
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.MaxLength = 18
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'colColor
        '
        Me.colColor.Caption = "Krāsa"
        Me.colColor.ColumnEdit = Me.txtColor
        Me.colColor.FieldName = "IntegerValue"
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 10
        Me.colColor.Width = 46
        '
        'txtColor
        '
        Me.txtColor.AutoHeight = False
        Me.txtColor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtColor.ColorText = DevExpress.XtraEditors.Controls.ColorText.[Integer]
        Me.txtColor.Name = "txtColor"
        Me.txtColor.ShowColorDialog = False
        Me.txtColor.ShowCustomColors = False
        Me.txtColor.ShowSystemColors = False
        Me.txtColor.StoreColorAsInteger = True
        '
        'colFourIntegerValue
        '
        Me.colFourIntegerValue.Caption = "GridColumn2"
        Me.colFourIntegerValue.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colFourIntegerValue.FieldName = "FourIntegerValue"
        Me.colFourIntegerValue.Name = "colFourIntegerValue"
        Me.colFourIntegerValue.Visible = True
        Me.colFourIntegerValue.VisibleIndex = 8
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "^[1-9]|[1-9][0-9]"
        Me.RepositoryItemTextEdit2.Mask.IgnoreMaskBlank = False
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.RepositoryItemTextEdit2.Mask.SaveLiteral = False
        Me.RepositoryItemTextEdit2.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colValidFrom
        '
        Me.colValidFrom.Caption = "Datums no"
        Me.colValidFrom.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colValidFrom.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.colValidFrom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colValidFrom.FieldName = "ValidFrom"
        Me.colValidFrom.Name = "colValidFrom"
        Me.colValidFrom.Visible = True
        Me.colValidFrom.VisibleIndex = 14
        Me.colValidFrom.Width = 87
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colValidUntil
        '
        Me.colValidUntil.Caption = "Datums līdz"
        Me.colValidUntil.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.colValidUntil.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.colValidUntil.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colValidUntil.FieldName = "ValidUntil"
        Me.colValidUntil.Name = "colValidUntil"
        Me.colValidUntil.Visible = True
        Me.colValidUntil.VisibleIndex = 15
        Me.colValidUntil.Width = 90
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'colMemo
        '
        Me.colMemo.Caption = "memodefault"
        Me.colMemo.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.colMemo.FieldName = "Comment"
        Me.colMemo.Name = "colMemo"
        Me.colMemo.Width = 181
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemMemoExEdit1.MaxLength = 1000
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'colSecondMark
        '
        Me.colSecondMark.Caption = "SecondMark"
        Me.colSecondMark.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colSecondMark.FieldName = "SecondMark"
        Me.colSecondMark.Name = "colSecondMark"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colMark
        '
        Me.colMark.Caption = "Mark"
        Me.colMark.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colMark.FieldName = "Mark"
        Me.colMark.Name = "colMark"
        Me.colMark.Width = 110
        '
        'colLookup
        '
        Me.colLookup.Caption = "beditdefault"
        Me.colLookup.ColumnEdit = Me.txtClassifier
        Me.colLookup.FieldName = "Parent"
        Me.colLookup.Name = "colLookup"
        Me.colLookup.Width = 173
        '
        'txtClassifier
        '
        Me.txtClassifier.AutoHeight = False
        Me.txtClassifier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtClassifier.Name = "txtClassifier"
        Me.txtClassifier.ReadOnly = True
        '
        'colNumber
        '
        Me.colNumber.Caption = "Vērtība"
        Me.colNumber.ColumnEdit = Me.txtDecimalValue
        Me.colNumber.FieldName = "DecimalValue"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 7
        '
        'colIntegerValue
        '
        Me.colIntegerValue.Caption = "GridColumn1"
        Me.colIntegerValue.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colIntegerValue.FieldName = "IntegerValue"
        Me.colIntegerValue.Name = "colIntegerValue"
        Me.colIntegerValue.Visible = True
        Me.colIntegerValue.VisibleIndex = 12
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "([1-9]|[1-9][0-9]|[1-9][0-9][0-9])"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colReference
        '
        Me.colReference.Caption = "GridColumn1"
        Me.colReference.ColumnEdit = Me.txtReference
        Me.colReference.FieldName = "Reference"
        Me.colReference.Name = "colReference"
        Me.colReference.Width = 120
        '
        'txtReference
        '
        Me.txtReference.AutoHeight = False
        Me.txtReference.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtReference.Name = "txtReference"
        Me.txtReference.ReadOnly = True
        '
        'colReference2
        '
        Me.colReference2.Caption = "GridColumn2"
        Me.colReference2.ColumnEdit = Me.txtReference2
        Me.colReference2.FieldName = "ReferenceSecond"
        Me.colReference2.Name = "colReference2"
        Me.colReference2.Width = 120
        '
        'txtReference2
        '
        Me.txtReference2.AutoHeight = False
        Me.txtReference2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtReference2.Name = "txtReference2"
        Me.txtReference2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colReference3
        '
        Me.colReference3.Caption = "GridColumn3"
        Me.colReference3.ColumnEdit = Me.txtReference3
        Me.colReference3.FieldName = "ReferenceThird"
        Me.colReference3.Name = "colReference3"
        '
        'txtReference3
        '
        Me.txtReference3.AutoHeight = False
        Me.txtReference3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtReference3.Name = "txtReference3"
        '
        'colReference4
        '
        Me.colReference4.Caption = "GridColumn2"
        Me.colReference4.ColumnEdit = Me.txtReference4
        Me.colReference4.FieldName = "ReferenceFourth"
        Me.colReference4.Name = "colReference4"
        '
        'txtReference4
        '
        Me.txtReference4.AutoHeight = False
        Me.txtReference4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtReference4.Name = "txtReference4"
        '
        'colReference5
        '
        Me.colReference5.Caption = "GridColumn2"
        Me.colReference5.ColumnEdit = Me.txtReference5
        Me.colReference5.FieldName = "ReferenceFive"
        Me.colReference5.Name = "colReference5"
        Me.colReference5.Visible = True
        Me.colReference5.VisibleIndex = 16
        '
        'txtReference5
        '
        Me.txtReference5.AutoHeight = False
        Me.txtReference5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtReference5.Name = "txtReference5"
        '
        'colReference6
        '
        Me.colReference6.Caption = "GridColumn2"
        Me.colReference6.ColumnEdit = Me.txtReference6
        Me.colReference6.FieldName = "ReferenceSix"
        Me.colReference6.Name = "colReference6"
        Me.colReference6.Visible = True
        Me.colReference6.VisibleIndex = 17
        '
        'txtReference6
        '
        Me.txtReference6.AutoHeight = False
        Me.txtReference6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtReference6.Name = "txtReference6"
        Me.txtReference6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "IsActive"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colSecondIntegerValue
        '
        Me.colSecondIntegerValue.Caption = "GridColumn2"
        Me.colSecondIntegerValue.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colSecondIntegerValue.FieldName = "SecondIntegerValue"
        Me.colSecondIntegerValue.Name = "colSecondIntegerValue"
        Me.colSecondIntegerValue.Visible = True
        Me.colSecondIntegerValue.VisibleIndex = 11
        '
        'colThirdIntegerValue
        '
        Me.colThirdIntegerValue.Caption = "GridColumn3"
        Me.colThirdIntegerValue.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colThirdIntegerValue.FieldName = "ThirdIntegerValue"
        Me.colThirdIntegerValue.Name = "colThirdIntegerValue"
        Me.colThirdIntegerValue.Visible = True
        Me.colThirdIntegerValue.VisibleIndex = 13
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.chkShowComments)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(912, 25)
        Me.Panel2.TabIndex = 6
        '
        'chkShowComments
        '
        Me.chkShowComments.AutoSize = True
        Me.chkShowComments.Location = New System.Drawing.Point(3, 5)
        Me.chkShowComments.Name = "chkShowComments"
        Me.chkShowComments.Size = New System.Drawing.Size(96, 17)
        Me.chkShowComments.TabIndex = 0
        Me.chkShowComments.Text = "Rādīt piezīmes"
        Me.chkShowComments.UseVisualStyleBackColor = True
        '
        'colDisplayValue
        '
        Me.colDisplayValue.Caption = "Nosaukums"
        Me.colDisplayValue.FieldName = "DisplayValue"
        Me.colDisplayValue.Name = "colDisplayValue"
        Me.colDisplayValue.Visible = True
        Me.colDisplayValue.VisibleIndex = 5
        Me.colDisplayValue.Width = 169
        '
        'frmClassifierList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 573)
        Me.Controls.Add(Me.grdClassifierList)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ctlClassifierFind)
        Me.MinimumSize = New System.Drawing.Size(645, 409)
        Me.Name = "frmClassifierList"
        Me.Text = "Klasifikatoru saraksts"
        Me.Controls.SetChildIndex(Me.ctlClassifierFind, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.grdClassifierList, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.bndClassifiers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.grdClassifierList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDecimalValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClassifier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ctlClassifierFind As Client.ctlClassifierFind
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents grdClassifierList As Core.UI.CoreGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidUntil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colLookup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtClassifier As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents txtDecimalValue As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chkShowComments As System.Windows.Forms.CheckBox
    Friend WithEvents txtValue As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colReference As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtReference As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colSecondMark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntegerValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSecondIntegerValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThirdIntegerValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtColor As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents colReference2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtReference2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colReference3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtReference3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colReference4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtReference4 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colFourIntegerValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMemoPrompt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnSendToCash As System.Windows.Forms.Button
    Friend WithEvents btnNextCode As System.Windows.Forms.Button
    Friend WithEvents colReference5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtReference5 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colReference6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtReference6 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colMaterialCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValueRus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValueEng As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisplayValue As DevExpress.XtraGrid.Columns.GridColumn
End Class
' Lūdzu, Юникод!