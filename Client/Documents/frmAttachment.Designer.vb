Imports Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttachment
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbxFiles = New System.Windows.Forms.GroupBox()
        Me.grdFiles = New Core.UI.CoreGrid()
        Me.bndFiles = New System.Windows.Forms.BindingSource(Me.components)
        Me.bndPatientDocument = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwFiles = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAddFile = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.IsActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit19 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit18 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.gbhAppealFiles = New Core.UI.GridButtonHelper()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClassifierPicker1 = New Client.ClassifierPicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPatient = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.gbxFiles.SuspendLayout()
        CType(Me.grdFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndPatientDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ClassifierPicker1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 278)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(596, 28)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 11
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(266, 28)
        Me.FlowLayoutPanel2.TabIndex = 11
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(326, 28)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(248, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(167, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbxFiles
        '
        Me.gbxFiles.Controls.Add(Me.grdFiles)
        Me.gbxFiles.Controls.Add(Me.gbhAppealFiles)
        Me.gbxFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxFiles.ForeColor = System.Drawing.SystemColors.WindowText
        Me.gbxFiles.Location = New System.Drawing.Point(0, 60)
        Me.gbxFiles.Name = "gbxFiles"
        Me.gbxFiles.Size = New System.Drawing.Size(596, 218)
        Me.gbxFiles.TabIndex = 356
        Me.gbxFiles.TabStop = False
        Me.gbxFiles.Text = "Pievienotie dokumenti"
        '
        'grdFiles
        '
        Me.grdFiles.DataSource = Me.bndFiles
        Me.grdFiles.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdFiles.EmbeddedNavigator.Name = ""
        Me.grdFiles.EnforceCanEdit = False
        Me.grdFiles.Location = New System.Drawing.Point(3, 45)
        Me.grdFiles.MainView = Me.gvwFiles
        Me.grdFiles.Name = "grdFiles"
        Me.grdFiles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit19, Me.RepositoryItemTextEdit18, Me.RepositoryItemTextEdit17, Me.RepositoryItemTextEdit15, Me.RepositoryItemTextEdit16, Me.RepositoryItemTextEdit14, Me.RepositoryItemTextEdit13, Me.RepositoryItemTextEdit11, Me.RepositoryItemTextEdit12, Me.RepositoryItemTextEdit10, Me.RepositoryItemTextEdit8, Me.RepositoryItemTextEdit9, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit7, Me.btnAddFile})
        Me.grdFiles.ShowOnlyActive = False
        Me.grdFiles.Size = New System.Drawing.Size(590, 170)
        Me.grdFiles.TabIndex = 1
        Me.grdFiles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwFiles})
        '
        'bndFiles
        '
        Me.bndFiles.DataMember = "Files"
        Me.bndFiles.DataSource = Me.bndPatientDocument
        '
        'bndPatientDocument
        '
        Me.bndPatientDocument.DataSource = GetType(Entities.PatientDocument)
        '
        'gvwFiles
        '
        Me.gvwFiles.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFile, Me.IsActive})
        Me.gvwFiles.GridControl = Me.grdFiles
        Me.gvwFiles.Name = "gvwFiles"
        Me.gvwFiles.OptionsView.ColumnAutoWidth = False
        Me.gvwFiles.OptionsView.ShowDetailButtons = False
        Me.gvwFiles.OptionsView.ShowFilterPanel = False
        Me.gvwFiles.OptionsView.ShowGroupPanel = False
        '
        'colFile
        '
        Me.colFile.Caption = "Nosaukums"
        Me.colFile.ColumnEdit = Me.btnAddFile
        Me.colFile.FieldName = "File"
        Me.colFile.Name = "colFile"
        Me.colFile.Visible = True
        Me.colFile.VisibleIndex = 0
        Me.colFile.Width = 553
        '
        'btnAddFile
        '
        Me.btnAddFile.AutoHeight = False
        Me.btnAddFile.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'IsActive
        '
        Me.IsActive.Caption = "IsActive"
        Me.IsActive.FieldName = "IsActive"
        Me.IsActive.Name = "IsActive"
        '
        'RepositoryItemTextEdit19
        '
        Me.RepositoryItemTextEdit19.AutoHeight = False
        Me.RepositoryItemTextEdit19.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit19.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit19.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit19.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit19.Name = "RepositoryItemTextEdit19"
        '
        'RepositoryItemTextEdit18
        '
        Me.RepositoryItemTextEdit18.AutoHeight = False
        Me.RepositoryItemTextEdit18.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit18.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit18.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit18.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit18.Name = "RepositoryItemTextEdit18"
        '
        'RepositoryItemTextEdit17
        '
        Me.RepositoryItemTextEdit17.AutoHeight = False
        Me.RepositoryItemTextEdit17.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit17.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit17.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit17.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit17.Name = "RepositoryItemTextEdit17"
        '
        'RepositoryItemTextEdit15
        '
        Me.RepositoryItemTextEdit15.AutoHeight = False
        Me.RepositoryItemTextEdit15.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit15.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit15.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit15.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit15.Name = "RepositoryItemTextEdit15"
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
        'RepositoryItemTextEdit14
        '
        Me.RepositoryItemTextEdit14.AutoHeight = False
        Me.RepositoryItemTextEdit14.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit14.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit14.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit14.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit14.Name = "RepositoryItemTextEdit14"
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
        'RepositoryItemTextEdit11
        '
        Me.RepositoryItemTextEdit11.AutoHeight = False
        Me.RepositoryItemTextEdit11.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit11.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit11.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit11.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit11.Name = "RepositoryItemTextEdit11"
        '
        'RepositoryItemTextEdit12
        '
        Me.RepositoryItemTextEdit12.AutoHeight = False
        Me.RepositoryItemTextEdit12.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit12.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit12.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit12.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit12.Name = "RepositoryItemTextEdit12"
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
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.AutoHeight = False
        Me.RepositoryItemTextEdit9.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit9.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit9.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
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
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.MaxLength = 120
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'gbhAppealFiles
        '
        Me.gbhAppealFiles.DeleteReason = False
        Me.gbhAppealFiles.DeleteReasonColumn = Nothing
        Me.gbhAppealFiles.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhAppealFiles.Grid = Me.grdFiles
        Me.gbhAppealFiles.GridDataSource = Me.bndFiles
        Me.gbhAppealFiles.Location = New System.Drawing.Point(3, 16)
        Me.gbhAppealFiles.Name = "gbhAppealFiles"
        Me.gbhAppealFiles.ShowActive = False
        Me.gbhAppealFiles.ShowAdd = True
        Me.gbhAppealFiles.ShowChk = True
        Me.gbhAppealFiles.ShowDelete = True
        Me.gbhAppealFiles.Size = New System.Drawing.Size(590, 29)
        Me.gbhAppealFiles.TabIndex = 0
        Me.gbhAppealFiles.UseCanDelete = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ClassifierPicker1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPatient)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 60)
        Me.Panel1.TabIndex = 357
        '
        'ClassifierPicker1
        '
        Me.ClassifierPicker1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientDocument, "DocType", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ClassifierPicker1.Location = New System.Drawing.Point(104, 27)
        Me.ClassifierPicker1.Name = "ClassifierPicker1"
        Me.ClassifierPicker1.PickerPresets = Nothing
        Me.ClassifierPicker1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ClassifierPicker1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ClassifierPicker1.Size = New System.Drawing.Size(489, 20)
        Me.ClassifierPicker1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dokumenta veids:"
        '
        'txtPatient
        '
        Me.txtPatient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPatient.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndPatientDocument, "Patient", True))
        Me.txtPatient.Location = New System.Drawing.Point(104, 3)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.ReadOnly = True
        Me.txtPatient.Size = New System.Drawing.Size(489, 20)
        Me.txtPatient.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Klients:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndPatientDocument
        '
        'frmAttachment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 306)
        Me.Controls.Add(Me.gbxFiles)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAttachment"
        Me.Text = "Pievienotie dokumenti"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.gbxFiles.ResumeLayout(False)
        CType(Me.grdFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndPatientDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ClassifierPicker1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbxFiles As System.Windows.Forms.GroupBox
    Friend WithEvents grdFiles As Core.UI.CoreGrid
    Friend WithEvents gvwFiles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAddFile As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents IsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit19 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit18 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gbhAppealFiles As Core.UI.GridButtonHelper
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ClassifierPicker1 As Client.ClassifierPicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPatient As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bndPatientDocument As System.Windows.Forms.BindingSource
    Friend WithEvents bndFiles As System.Windows.Forms.BindingSource
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
