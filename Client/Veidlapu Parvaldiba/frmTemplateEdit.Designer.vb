<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemplateEdit
    Inherits Client.frmUIBase

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
        Me.components = New System.ComponentModel.Container
        Dim CodeLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim ValidFromLabel As System.Windows.Forms.Label
        Dim ValidUntilLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemplateEdit))
        Me.RepositoryItemTextEdit20 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colIsFileActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bndTemplate = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.pagFileList = New System.Windows.Forms.TabPage
        Me.grdFileList = New Core.UI.CoreGrid
        Me.FilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvFileList = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colVersionNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValidFrom1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.inplaceDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colValidUntil1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFile = New DevExpress.XtraGrid.Columns.GridColumn
        Me.inplaceFileOpenButton = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.gbhTemplateFile = New Core.UI.GridButtonHelper
        Me.CodeTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.NameTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ValidFromDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.ValidUntilDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bndTemplateType = New System.Windows.Forms.BindingSource(Me.components)
        Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTemplateGroup = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TypeLabel = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtType = New Client.ClassifierPicker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        CodeLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        ValidFromLabel = New System.Windows.Forms.Label
        ValidUntilLabel = New System.Windows.Forms.Label
        CType(Me.RepositoryItemTextEdit20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.pagFileList.SuspendLayout()
        CType(Me.grdFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inplaceDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inplaceFileOpenButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidFromDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidUntilDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndTemplateType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(6, 16)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(34, 13)
        CodeLabel.TabIndex = 1
        CodeLabel.Text = "Kods:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(199, 95)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(51, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Apraksts:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(6, 95)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(66, 13)
        NameLabel.TabIndex = 15
        NameLabel.Text = "Nosaukums:"
        '
        'ValidFromLabel
        '
        ValidFromLabel.AutoSize = True
        ValidFromLabel.Location = New System.Drawing.Point(6, 55)
        ValidFromLabel.Name = "ValidFromLabel"
        ValidFromLabel.Size = New System.Drawing.Size(109, 13)
        ValidFromLabel.TabIndex = 19
        ValidFromLabel.Text = "Izveidošanas datums:"
        '
        'ValidUntilLabel
        '
        ValidUntilLabel.AutoSize = True
        ValidUntilLabel.Location = New System.Drawing.Point(199, 55)
        ValidUntilLabel.Name = "ValidUntilLabel"
        ValidUntilLabel.Size = New System.Drawing.Size(96, 13)
        ValidUntilLabel.TabIndex = 21
        ValidUntilLabel.Text = "Slēgšanas datums:"
        '
        'RepositoryItemTextEdit20
        '
        Me.RepositoryItemTextEdit20.AutoHeight = False
        Me.RepositoryItemTextEdit20.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit20.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit20.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit20.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit20.Name = "RepositoryItemTextEdit20"
        '
        'RepositoryItemTextEdit16
        '
        Me.RepositoryItemTextEdit16.AutoHeight = False
        Me.RepositoryItemTextEdit16.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit16.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit16.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit16.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit16.Name = "RepositoryItemTextEdit16"
        '
        'RepositoryItemTextEdit13
        '
        Me.RepositoryItemTextEdit13.AutoHeight = False
        Me.RepositoryItemTextEdit13.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit13.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit13.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit13.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit13.Name = "RepositoryItemTextEdit13"
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.AutoHeight = False
        Me.RepositoryItemTextEdit10.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit10.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit10.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit10.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colIsFileActive
        '
        Me.colIsFileActive.Caption = "Aktīvs"
        Me.colIsFileActive.FieldName = "IsActive"
        Me.colIsFileActive.Name = "colIsFileActive"
        '
        'bndTemplate
        '
        Me.bndTemplate.DataSource = GetType(Entities.Template)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pagFileList)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(2, 153)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(444, 225)
        Me.TabControl1.TabIndex = 8
        '
        'pagFileList
        '
        Me.pagFileList.Controls.Add(Me.grdFileList)
        Me.pagFileList.Controls.Add(Me.gbhTemplateFile)
        Me.pagFileList.Location = New System.Drawing.Point(4, 22)
        Me.pagFileList.Name = "pagFileList"
        Me.pagFileList.Padding = New System.Windows.Forms.Padding(3)
        Me.pagFileList.Size = New System.Drawing.Size(436, 199)
        Me.pagFileList.TabIndex = 0
        Me.pagFileList.Text = "Failu saraksts"
        Me.pagFileList.UseVisualStyleBackColor = True
        '
        'grdFileList
        '
        Me.grdFileList.DataSource = Me.FilesBindingSource
        Me.grdFileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFileList.EmbeddedNavigator.Name = ""
        Me.grdFileList.EnforceCanEdit = False
        Me.grdFileList.Location = New System.Drawing.Point(3, 34)
        Me.grdFileList.MainView = Me.gvFileList
        Me.grdFileList.Name = "grdFileList"
        Me.grdFileList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit20, Me.RepositoryItemTextEdit16, Me.RepositoryItemTextEdit13, Me.RepositoryItemTextEdit10, Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.inplaceDateEdit, Me.inplaceFileOpenButton})
        Me.grdFileList.ShowOnlyActive = False
        Me.grdFileList.Size = New System.Drawing.Size(430, 162)
        Me.grdFileList.TabIndex = 10
        Me.grdFileList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFileList})
        '
        'FilesBindingSource
        '
        Me.FilesBindingSource.DataMember = "Files"
        Me.FilesBindingSource.DataSource = Me.bndTemplate
        '
        'gvFileList
        '
        Me.gvFileList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVersionNumber, Me.colValidFrom1, Me.colValidUntil1, Me.colComment, Me.colFile, Me.colIsFileActive})
        Me.gvFileList.GridControl = Me.grdFileList
        Me.gvFileList.MRUFilters.Add(CType(resources.GetObject("gvFileList.MRUFilters"), DevExpress.XtraGrid.Views.Base.ViewFilter))
        Me.gvFileList.Name = "gvFileList"
        Me.gvFileList.OptionsView.ColumnAutoWidth = False
        Me.gvFileList.OptionsView.ShowDetailButtons = False
        Me.gvFileList.OptionsView.ShowFilterPanel = False
        Me.gvFileList.OptionsView.ShowGroupPanel = False
        Me.gvFileList.OptionsView.ShowIndicator = False
        '
        'colVersionNumber
        '
        Me.colVersionNumber.Caption = "Versijas numurs"
        Me.colVersionNumber.FieldName = "VersionNumber"
        Me.colVersionNumber.Name = "colVersionNumber"
        Me.colVersionNumber.Visible = True
        Me.colVersionNumber.VisibleIndex = 1
        Me.colVersionNumber.Width = 100
        '
        'colValidFrom1
        '
        Me.colValidFrom1.Caption = "Spēkā no"
        Me.colValidFrom1.ColumnEdit = Me.inplaceDateEdit
        Me.colValidFrom1.FieldName = "ValidFrom"
        Me.colValidFrom1.Name = "colValidFrom1"
        Me.colValidFrom1.Visible = True
        Me.colValidFrom1.VisibleIndex = 2
        '
        'inplaceDateEdit
        '
        Me.inplaceDateEdit.AutoHeight = False
        Me.inplaceDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.inplaceDateEdit.Name = "inplaceDateEdit"
        '
        'colValidUntil1
        '
        Me.colValidUntil1.Caption = "Spēkā līdz"
        Me.colValidUntil1.ColumnEdit = Me.inplaceDateEdit
        Me.colValidUntil1.FieldName = "ValidUntil"
        Me.colValidUntil1.Name = "colValidUntil1"
        Me.colValidUntil1.Visible = True
        Me.colValidUntil1.VisibleIndex = 3
        '
        'colComment
        '
        Me.colComment.Caption = "Komentārs"
        Me.colComment.FieldName = "Comment"
        Me.colComment.Name = "colComment"
        Me.colComment.Visible = True
        Me.colComment.VisibleIndex = 4
        '
        'colFile
        '
        Me.colFile.Caption = "Faila nosaukums"
        Me.colFile.ColumnEdit = Me.inplaceFileOpenButton
        Me.colFile.FieldName = "File.Name"
        Me.colFile.Name = "colFile"
        Me.colFile.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colFile.Visible = True
        Me.colFile.VisibleIndex = 0
        Me.colFile.Width = 99
        '
        'inplaceFileOpenButton
        '
        Me.inplaceFileOpenButton.AutoHeight = False
        Me.inplaceFileOpenButton.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.inplaceFileOpenButton.Name = "inplaceFileOpenButton"
        Me.inplaceFileOpenButton.ReadOnly = True
        '
        'gbhTemplateFile
        '
        Me.gbhTemplateFile.DeleteReason = False
        Me.gbhTemplateFile.DeleteReasonColumn = Nothing
        Me.gbhTemplateFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhTemplateFile.Grid = Me.grdFileList
        Me.gbhTemplateFile.GridDataSource = Me.FilesBindingSource
        Me.gbhTemplateFile.Location = New System.Drawing.Point(3, 3)
        Me.gbhTemplateFile.Name = "gbhTemplateFile"
        Me.gbhTemplateFile.ShowActive = False
        Me.gbhTemplateFile.ShowAdd = True
        Me.gbhTemplateFile.ShowChk = True
        Me.gbhTemplateFile.ShowDelete = False
        Me.gbhTemplateFile.Size = New System.Drawing.Size(430, 31)
        Me.gbhTemplateFile.TabIndex = 9
        Me.gbhTemplateFile.UseCanDelete = True
        '
        'CodeTextEdit
        '
        Me.CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndTemplate, "Code", True))
        Me.CodeTextEdit.Location = New System.Drawing.Point(9, 32)
        Me.CodeTextEdit.Name = "CodeTextEdit"
        Me.CodeTextEdit.Properties.MaxLength = 50
        Me.CodeTextEdit.Size = New System.Drawing.Size(174, 20)
        Me.CodeTextEdit.TabIndex = 2
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndTemplate, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(202, 111)
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Properties.MaxLength = 250
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(227, 20)
        Me.DescriptionTextEdit.TabIndex = 7
        '
        'NameTextEdit
        '
        Me.NameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndTemplate, "Name", True))
        Me.NameTextEdit.Location = New System.Drawing.Point(9, 111)
        Me.NameTextEdit.Name = "NameTextEdit"
        Me.NameTextEdit.Properties.MaxLength = 250
        Me.NameTextEdit.Size = New System.Drawing.Size(177, 20)
        Me.NameTextEdit.TabIndex = 6
        '
        'ValidFromDateEdit
        '
        Me.ValidFromDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndTemplate, "ValidFrom", True))
        Me.ValidFromDateEdit.EditValue = Nothing
        Me.ValidFromDateEdit.Location = New System.Drawing.Point(9, 72)
        Me.ValidFromDateEdit.Name = "ValidFromDateEdit"
        Me.ValidFromDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.ValidFromDateEdit.Properties.MaxValue = New Date(9999, 12, 31, 0, 0, 0, 0)
        Me.ValidFromDateEdit.Properties.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ValidFromDateEdit.Properties.ReadOnly = True
        Me.ValidFromDateEdit.Size = New System.Drawing.Size(174, 20)
        Me.ValidFromDateEdit.TabIndex = 4
        '
        'ValidUntilDateEdit
        '
        Me.ValidUntilDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndTemplate, "ValidUntil", True))
        Me.ValidUntilDateEdit.EditValue = Nothing
        Me.ValidUntilDateEdit.Location = New System.Drawing.Point(202, 72)
        Me.ValidUntilDateEdit.Name = "ValidUntilDateEdit"
        Me.ValidUntilDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.ValidUntilDateEdit.Properties.MaxValue = New Date(9999, 12, 31, 0, 0, 0, 0)
        Me.ValidUntilDateEdit.Properties.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ValidUntilDateEdit.Size = New System.Drawing.Size(174, 20)
        Me.ValidUntilDateEdit.TabIndex = 5
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.DataSource = Me.bndTemplate
        '
        'bndTemplateType
        '
        Me.bndTemplateType.DataSource = GetType(Entities.TemplateType)
        '
        'colValue
        '
        Me.colValue.Caption = "Value"
        Me.colValue.FieldName = "Value"
        Me.colValue.Name = "colValue"
        Me.colValue.Visible = True
        Me.colValue.VisibleIndex = 0
        '
        'colTemplateGroup
        '
        Me.colTemplateGroup.Caption = "TemplateGroup"
        Me.colTemplateGroup.FieldName = "TemplateGroup"
        Me.colTemplateGroup.Name = "colTemplateGroup"
        Me.colTemplateGroup.Visible = True
        Me.colTemplateGroup.VisibleIndex = 1
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(199, 16)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(86, 13)
        Me.TypeLabel.TabIndex = 23
        Me.TypeLabel.Text = "Veidlapas grupa:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtType)
        Me.GroupBox1.Controls.Add(Me.TypeLabel)
        Me.GroupBox1.Controls.Add(CodeLabel)
        Me.GroupBox1.Controls.Add(Me.ValidUntilDateEdit)
        Me.GroupBox1.Controls.Add(ValidUntilLabel)
        Me.GroupBox1.Controls.Add(Me.CodeTextEdit)
        Me.GroupBox1.Controls.Add(Me.ValidFromDateEdit)
        Me.GroupBox1.Controls.Add(DescriptionLabel)
        Me.GroupBox1.Controls.Add(ValidFromLabel)
        Me.GroupBox1.Controls.Add(Me.DescriptionTextEdit)
        Me.GroupBox1.Controls.Add(Me.NameTextEdit)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 151)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pamatinformācija:"
        '
        'txtType
        '
        Me.txtType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndTemplate, "Type", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtType.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndTemplate, "CanChangeType", True))
        Me.txtType.EditValue = ""
        Me.txtType.Location = New System.Drawing.Point(202, 32)
        Me.txtType.Name = "txtType"
        Me.txtType.PickerPresets = Nothing
        Me.txtType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtType.Size = New System.Drawing.Size(227, 20)
        Me.txtType.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 378)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 29)
        Me.Panel1.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(281, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(362, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmTemplateEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(448, 409)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(456, 436)
        Me.Name = "frmTemplateEdit"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Veidlapas kartiņa"
        CType(Me.RepositoryItemTextEdit20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.pagFileList.ResumeLayout(False)
        CType(Me.grdFileList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFileList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inplaceDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inplaceFileOpenButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidFromDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidUntilDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndTemplateType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndTemplate As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents pagFileList As System.Windows.Forms.TabPage
    Friend WithEvents CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ValidFromDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ValidUntilDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents grdFileList As Core.UI.CoreGrid
    Friend WithEvents gvFileList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colVersionNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidUntil1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidFrom1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents inplaceDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents gbhTemplateFile As Core.UI.GridButtonHelper
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents bndTemplateType As System.Windows.Forms.BindingSource
    Friend WithEvents colValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTemplateGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TypeLabel As System.Windows.Forms.Label
    Friend WithEvents inplaceFileOpenButton As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents FilesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colIsFileActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtType As Client.ClassifierPicker
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit20 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
