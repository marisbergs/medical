<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgrammTemplateEdit
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bndProgrammTemplate = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdFreeServices = New Core.UI.CoreGrid()
        Me.bndProgrammTemplatePaymentService = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwFreeServices = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtFreeServices = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbgPaymentservices = New Core.UI.GridButtonHelper()
        Me.bndProgrammTemplateService = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdDiscountServices = New Core.UI.CoreGrid()
        Me.gvwDiscountServices = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colService1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDefaultPrice = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDiscountPrice = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colCount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCount = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.gbhServices = New Core.UI.GridButtonHelper()
        Me.chkPaymentFromDefaultPrice = New System.Windows.Forms.CheckBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndProgrammTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdFreeServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndProgrammTemplatePaymentService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwFreeServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFreeServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.bndProgrammTemplateService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdDiscountServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwDiscountServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDefaultPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscountPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndProgrammTemplate
        '
        'bndProgrammTemplate
        '
        Me.bndProgrammTemplate.DataSource = GetType(Entities.ProgrammTemplate)
        '
        'SpinEdit1
        '
        Me.SpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndProgrammTemplate, "Price", True))
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ErrorProvider1.SetIconAlignment(Me.SpinEdit1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.ErrorProvider1.SetIconPadding(Me.SpinEdit1, -16)
        Me.SpinEdit1.Location = New System.Drawing.Point(660, 3)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit1.Properties.DisplayFormat.FormatString = "n2"
        Me.SpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.EditFormat.FormatString = "n2"
        Me.SpinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit1.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndProgrammTemplate, "Name", True))
        Me.ErrorProvider1.SetIconPadding(Me.txtName, -16)
        Me.txtName.Location = New System.Drawing.Point(84, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(525, 20)
        Me.txtName.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nosaukums:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.grdFreeServices)
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(2, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1003, 130)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pakalpojumi, kas tiks izmantoti kā apmaksas templeiti"
        '
        'grdFreeServices
        '
        Me.grdFreeServices.DataSource = Me.bndProgrammTemplatePaymentService
        Me.grdFreeServices.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdFreeServices.EmbeddedNavigator.Name = ""
        Me.grdFreeServices.EnforceCanEdit = False
        Me.grdFreeServices.Location = New System.Drawing.Point(3, 47)
        Me.grdFreeServices.MainView = Me.gvwFreeServices
        Me.grdFreeServices.Name = "grdFreeServices"
        Me.grdFreeServices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtFreeServices, Me.RepositoryItemSpinEdit1})
        Me.grdFreeServices.ShowOnlyActive = False
        Me.grdFreeServices.Size = New System.Drawing.Size(997, 80)
        Me.grdFreeServices.TabIndex = 1
        Me.grdFreeServices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwFreeServices})
        '
        'bndProgrammTemplatePaymentService
        '
        Me.bndProgrammTemplatePaymentService.DataSource = GetType(Entities.ProgrammTemplateService)
        '
        'gvwFreeServices
        '
        Me.gvwFreeServices.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colService, Me.GridColumn3})
        Me.gvwFreeServices.GridControl = Me.grdFreeServices
        Me.gvwFreeServices.Name = "gvwFreeServices"
        Me.gvwFreeServices.OptionsView.ShowDetailButtons = False
        Me.gvwFreeServices.OptionsView.ShowFilterPanel = False
        Me.gvwFreeServices.OptionsView.ShowGroupPanel = False
        '
        'colService
        '
        Me.colService.Caption = "Pakalpojums"
        Me.colService.ColumnEdit = Me.txtFreeServices
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.OptionsColumn.AllowEdit = False
        Me.colService.Visible = True
        Me.colService.VisibleIndex = 0
        Me.colService.Width = 810
        '
        'txtFreeServices
        '
        Me.txtFreeServices.AutoHeight = False
        Me.txtFreeServices.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFreeServices.Name = "txtFreeServices"
        Me.txtFreeServices.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cena"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.GridColumn3.FieldName = "Price"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 176
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatString = "n2"
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbgPaymentservices)
        Me.SplitContainer1.Size = New System.Drawing.Size(997, 31)
        Me.SplitContainer1.SplitterDistance = 539
        Me.SplitContainer1.TabIndex = 2
        '
        'gbgPaymentservices
        '
        Me.gbgPaymentservices.AutoSize = True
        Me.gbgPaymentservices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbgPaymentservices.DeleteReason = False
        Me.gbgPaymentservices.DeleteReasonColumn = Nothing
        Me.gbgPaymentservices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbgPaymentservices.Grid = Me.grdFreeServices
        Me.gbgPaymentservices.GridDataSource = Me.bndProgrammTemplatePaymentService
        Me.gbgPaymentservices.Location = New System.Drawing.Point(0, 0)
        Me.gbgPaymentservices.Name = "gbgPaymentservices"
        Me.gbgPaymentservices.ShowActive = False
        Me.gbgPaymentservices.ShowAdd = True
        Me.gbgPaymentservices.ShowChk = True
        Me.gbgPaymentservices.ShowDelete = True
        Me.gbgPaymentservices.Size = New System.Drawing.Size(539, 31)
        Me.gbgPaymentservices.TabIndex = 0
        Me.gbgPaymentservices.UseCanDelete = True
        '
        'bndProgrammTemplateService
        '
        Me.bndProgrammTemplateService.DataSource = GetType(Entities.ProgrammTemplateService)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(615, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cena:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 428)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1011, 31)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(933, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(852, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.grdDiscountServices)
        Me.GroupBox2.Controls.Add(Me.SplitContainer2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(0, 162)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1008, 263)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Programmai piesaistītie pakalpojumi"
        '
        'grdDiscountServices
        '
        Me.grdDiscountServices.DataSource = Me.bndProgrammTemplateService
        Me.grdDiscountServices.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdDiscountServices.EmbeddedNavigator.Name = ""
        Me.grdDiscountServices.EnforceCanEdit = False
        Me.grdDiscountServices.Location = New System.Drawing.Point(3, 47)
        Me.grdDiscountServices.MainView = Me.gvwDiscountServices
        Me.grdDiscountServices.Name = "grdDiscountServices"
        Me.grdDiscountServices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDefaultPrice, Me.txtDiscountPrice, Me.txtCount})
        Me.grdDiscountServices.ShowOnlyActive = False
        Me.grdDiscountServices.Size = New System.Drawing.Size(1002, 213)
        Me.grdDiscountServices.TabIndex = 1
        Me.grdDiscountServices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwDiscountServices})
        '
        'gvwDiscountServices
        '
        Me.gvwDiscountServices.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colService1, Me.GridColumn1, Me.colPrice1, Me.colCount, Me.GridColumn2})
        Me.gvwDiscountServices.GridControl = Me.grdDiscountServices
        Me.gvwDiscountServices.Name = "gvwDiscountServices"
        Me.gvwDiscountServices.OptionsView.ShowDetailButtons = False
        Me.gvwDiscountServices.OptionsView.ShowFilterPanel = False
        Me.gvwDiscountServices.OptionsView.ShowFooter = True
        Me.gvwDiscountServices.OptionsView.ShowGroupPanel = False
        '
        'colService1
        '
        Me.colService1.Caption = "Pakalpojums"
        Me.colService1.FieldName = "Service"
        Me.colService1.Name = "colService1"
        Me.colService1.OptionsColumn.AllowEdit = False
        Me.colService1.Visible = True
        Me.colService1.VisibleIndex = 0
        Me.colService1.Width = 503
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Standartcena"
        Me.GridColumn1.ColumnEdit = Me.txtDefaultPrice
        Me.GridColumn1.FieldName = "ServicePice"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 97
        '
        'txtDefaultPrice
        '
        Me.txtDefaultPrice.AutoHeight = False
        Me.txtDefaultPrice.DisplayFormat.FormatString = "n2"
        Me.txtDefaultPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDefaultPrice.Name = "txtDefaultPrice"
        Me.txtDefaultPrice.ReadOnly = True
        '
        'colPrice1
        '
        Me.colPrice1.Caption = "Cena ar atlaidi"
        Me.colPrice1.ColumnEdit = Me.txtDiscountPrice
        Me.colPrice1.FieldName = "Price"
        Me.colPrice1.Name = "colPrice1"
        Me.colPrice1.Visible = True
        Me.colPrice1.VisibleIndex = 2
        Me.colPrice1.Width = 130
        '
        'txtDiscountPrice
        '
        Me.txtDiscountPrice.AutoHeight = False
        Me.txtDiscountPrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDiscountPrice.DisplayFormat.FormatString = "n2"
        Me.txtDiscountPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscountPrice.EditFormat.FormatString = "n2"
        Me.txtDiscountPrice.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscountPrice.Name = "txtDiscountPrice"
        '
        'colCount
        '
        Me.colCount.Caption = "Skaits"
        Me.colCount.ColumnEdit = Me.txtCount
        Me.colCount.FieldName = "Count"
        Me.colCount.Name = "colCount"
        Me.colCount.Visible = True
        Me.colCount.VisibleIndex = 3
        Me.colCount.Width = 105
        '
        'txtCount
        '
        Me.txtCount.AutoHeight = False
        Me.txtCount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCount.DisplayFormat.FormatString = "n0"
        Me.txtCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCount.EditFormat.FormatString = "n0"
        Me.txtCount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCount.Name = "txtCount"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Summa kopā"
        Me.GridColumn2.DisplayFormat.FormatString = "n2"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "PriceTotal"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.gbhServices)
        Me.SplitContainer2.Size = New System.Drawing.Size(1002, 31)
        Me.SplitContainer2.SplitterDistance = 541
        Me.SplitContainer2.TabIndex = 2
        '
        'gbhServices
        '
        Me.gbhServices.AutoSize = True
        Me.gbhServices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhServices.DeleteReason = False
        Me.gbhServices.DeleteReasonColumn = Nothing
        Me.gbhServices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbhServices.Grid = Me.grdDiscountServices
        Me.gbhServices.GridDataSource = Me.bndProgrammTemplateService
        Me.gbhServices.Location = New System.Drawing.Point(0, 0)
        Me.gbhServices.Name = "gbhServices"
        Me.gbhServices.ShowActive = False
        Me.gbhServices.ShowAdd = True
        Me.gbhServices.ShowChk = True
        Me.gbhServices.ShowDelete = True
        Me.gbhServices.Size = New System.Drawing.Size(541, 31)
        Me.gbhServices.TabIndex = 0
        Me.gbhServices.UseCanDelete = True
        '
        'chkPaymentFromDefaultPrice
        '
        Me.chkPaymentFromDefaultPrice.AutoSize = True
        Me.chkPaymentFromDefaultPrice.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bndProgrammTemplate, "PaymentFromDefaultPrice", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkPaymentFromDefaultPrice.Location = New System.Drawing.Point(766, 5)
        Me.chkPaymentFromDefaultPrice.Name = "chkPaymentFromDefaultPrice"
        Me.chkPaymentFromDefaultPrice.Size = New System.Drawing.Size(233, 17)
        Me.chkPaymentFromDefaultPrice.TabIndex = 11
        Me.chkPaymentFromDefaultPrice.Text = "Apmaksai izmantot pakalpojuma pamatcenu"
        Me.chkPaymentFromDefaultPrice.UseVisualStyleBackColor = True
        '
        'frmProgrammTemplateEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1011, 459)
        Me.Controls.Add(Me.chkPaymentFromDefaultPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SpinEdit1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmProgrammTemplateEdit"
        Me.Text = "Programmas apraksts"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndProgrammTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdFreeServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndProgrammTemplatePaymentService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwFreeServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFreeServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.bndProgrammTemplateService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdDiscountServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwDiscountServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDefaultPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscountPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdFreeServices As Core.UI.CoreGrid
    Friend WithEvents bndProgrammTemplateService As System.Windows.Forms.BindingSource
    Friend WithEvents gvwFreeServices As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFreeServices As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbgPaymentservices As Core.UI.GridButtonHelper
    Friend WithEvents bndProgrammTemplate As System.Windows.Forms.BindingSource
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdDiscountServices As Core.UI.CoreGrid
    Friend WithEvents bndProgrammTemplatePaymentService As System.Windows.Forms.BindingSource
    Friend WithEvents gvwDiscountServices As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colService1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDefaultPrice As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDiscountPrice As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbhServices As Core.UI.GridButtonHelper
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents colCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCount As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents chkPaymentFromDefaultPrice As System.Windows.Forms.CheckBox

End Class
