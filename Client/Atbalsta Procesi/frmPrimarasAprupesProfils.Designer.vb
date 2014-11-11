<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrimarasAprupesProfils
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdFreeServices = New Core.UI.CoreGrid
        Me.bndProfileDescriptionFreeServices = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwFreeServices = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtFreeServices = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gbhFreeServices = New Core.UI.GridButtonHelper
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit
        Me.bndProfileDescription = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtProfile = New Client.ClassifierPicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.grdDiscountServices = New Core.UI.CoreGrid
        Me.bndProfileDescriptioDiscountServices = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwDiscountServices = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colService1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtDefaultPrice = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colPrice1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtDiscountPrice = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridButtonHelper1 = New Core.UI.GridButtonHelper
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdFreeServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndProfileDescriptionFreeServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwFreeServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFreeServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndProfileDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProfile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdDiscountServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndProfileDescriptioDiscountServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwDiscountServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDefaultPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscountPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.grdFreeServices)
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(2, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(953, 185)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Primārās aprūpes bezmaksas pakalpojumi"
        '
        'grdFreeServices
        '
        Me.grdFreeServices.DataSource = Me.bndProfileDescriptionFreeServices
        Me.grdFreeServices.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdFreeServices.EmbeddedNavigator.Name = ""
        Me.grdFreeServices.EnforceCanEdit = False
        Me.grdFreeServices.Location = New System.Drawing.Point(3, 47)
        Me.grdFreeServices.MainView = Me.gvwFreeServices
        Me.grdFreeServices.Name = "grdFreeServices"
        Me.grdFreeServices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtFreeServices})
        Me.grdFreeServices.ShowOnlyActive = False
        Me.grdFreeServices.Size = New System.Drawing.Size(947, 135)
        Me.grdFreeServices.TabIndex = 1
        Me.grdFreeServices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwFreeServices})
        '
        'bndProfileDescriptionFreeServices
        '
        Me.bndProfileDescriptionFreeServices.DataSource = GetType(Entities.ProfileDescriptionService)
        '
        'gvwFreeServices
        '
        Me.gvwFreeServices.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colService})
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
        '
        'txtFreeServices
        '
        Me.txtFreeServices.AutoHeight = False
        Me.txtFreeServices.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFreeServices.Name = "txtFreeServices"
        Me.txtFreeServices.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbhFreeServices)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SpinEdit2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SpinEdit1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(947, 31)
        Me.SplitContainer1.SplitterDistance = 512
        Me.SplitContainer1.TabIndex = 2
        '
        'gbhFreeServices
        '
        Me.gbhFreeServices.AutoSize = True
        Me.gbhFreeServices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhFreeServices.DeleteReason = False
        Me.gbhFreeServices.DeleteReasonColumn = Nothing
        Me.gbhFreeServices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbhFreeServices.Grid = Me.grdFreeServices
        Me.gbhFreeServices.GridDataSource = Me.bndProfileDescriptionFreeServices
        Me.gbhFreeServices.Location = New System.Drawing.Point(0, 0)
        Me.gbhFreeServices.Name = "gbhFreeServices"
        Me.gbhFreeServices.ShowActive = False
        Me.gbhFreeServices.ShowAdd = True
        Me.gbhFreeServices.ShowChk = True
        Me.gbhFreeServices.ShowDelete = True
        Me.gbhFreeServices.Size = New System.Drawing.Size(512, 31)
        Me.gbhFreeServices.TabIndex = 0
        Me.gbhFreeServices.UseCanDelete = True
        '
        'SpinEdit2
        '
        Me.SpinEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndProfileDescription, "Count", True))
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit2.Location = New System.Drawing.Point(316, 5)
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit2.Properties.DisplayFormat.FormatString = "n0"
        Me.SpinEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit2.Properties.EditFormat.FormatString = "n0"
        Me.SpinEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit2.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit2.TabIndex = 3
        '
        'bndProfileDescription
        '
        Me.bndProfileDescription.DataSource = GetType(Entities.ProfileDescription)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bezmaksas pakalpojumu skaits:"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndProfileDescription, "Price", True))
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(47, 5)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Properties.DisplayFormat.FormatString = "n2"
        Me.SpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.EditFormat.FormatString = "n2"
        Me.SpinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cena:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Profils:"
        '
        'txtProfile
        '
        Me.txtProfile.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndProfileDescription, "Profile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtProfile.Location = New System.Drawing.Point(56, 6)
        Me.txtProfile.Name = "txtProfile"
        Me.txtProfile.PickerPresets = Nothing
        Me.txtProfile.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtProfile.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtProfile.Size = New System.Drawing.Size(888, 20)
        Me.txtProfile.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.grdDiscountServices)
        Me.GroupBox2.Controls.Add(Me.SplitContainer2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(0, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(953, 217)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Primārās aprūpespakalpojumi ar atlaidi"
        '
        'grdDiscountServices
        '
        Me.grdDiscountServices.DataSource = Me.bndProfileDescriptioDiscountServices
        Me.grdDiscountServices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDiscountServices.EmbeddedNavigator.Name = ""
        Me.grdDiscountServices.EnforceCanEdit = False
        Me.grdDiscountServices.Location = New System.Drawing.Point(3, 47)
        Me.grdDiscountServices.MainView = Me.gvwDiscountServices
        Me.grdDiscountServices.Name = "grdDiscountServices"
        Me.grdDiscountServices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDefaultPrice, Me.txtDiscountPrice})
        Me.grdDiscountServices.ShowOnlyActive = False
        Me.grdDiscountServices.Size = New System.Drawing.Size(947, 167)
        Me.grdDiscountServices.TabIndex = 1
        Me.grdDiscountServices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwDiscountServices})
        '
        'bndProfileDescriptioDiscountServices
        '
        Me.bndProfileDescriptioDiscountServices.DataSource = GetType(Entities.ProfileDescriptionService)
        '
        'gvwDiscountServices
        '
        Me.gvwDiscountServices.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colService1, Me.GridColumn1, Me.colPrice1})
        Me.gvwDiscountServices.GridControl = Me.grdDiscountServices
        Me.gvwDiscountServices.Name = "gvwDiscountServices"
        Me.gvwDiscountServices.OptionsView.ShowDetailButtons = False
        Me.gvwDiscountServices.OptionsView.ShowFilterPanel = False
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
        Me.colService1.Width = 684
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
        Me.GridColumn1.Width = 124
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
        Me.colPrice1.Width = 125
        '
        'txtDiscountPrice
        '
        Me.txtDiscountPrice.AutoHeight = False
        Me.txtDiscountPrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDiscountPrice.DisplayFormat.FormatString = "n2"
        Me.txtDiscountPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscountPrice.EditFormat.FormatString = "n2"
        Me.txtDiscountPrice.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscountPrice.Name = "txtDiscountPrice"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridButtonHelper1)
        Me.SplitContainer2.Size = New System.Drawing.Size(947, 31)
        Me.SplitContainer2.SplitterDistance = 512
        Me.SplitContainer2.TabIndex = 2
        '
        'GridButtonHelper1
        '
        Me.GridButtonHelper1.AutoSize = True
        Me.GridButtonHelper1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GridButtonHelper1.DeleteReason = False
        Me.GridButtonHelper1.DeleteReasonColumn = Nothing
        Me.GridButtonHelper1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridButtonHelper1.Grid = Me.grdDiscountServices
        Me.GridButtonHelper1.GridDataSource = Me.bndProfileDescriptioDiscountServices
        Me.GridButtonHelper1.Location = New System.Drawing.Point(0, 0)
        Me.GridButtonHelper1.Name = "GridButtonHelper1"
        Me.GridButtonHelper1.ShowActive = False
        Me.GridButtonHelper1.ShowAdd = True
        Me.GridButtonHelper1.ShowChk = True
        Me.GridButtonHelper1.ShowDelete = True
        Me.GridButtonHelper1.Size = New System.Drawing.Size(512, 31)
        Me.GridButtonHelper1.TabIndex = 0
        Me.GridButtonHelper1.UseCanDelete = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 443)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(956, 31)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(878, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(797, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndProfileDescription
        '
        'frmPrimarasAprupesProfils
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(956, 474)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtProfile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPrimarasAprupesProfils"
        Me.Text = "Primārās aprūpes profils"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdFreeServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndProfileDescriptionFreeServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwFreeServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFreeServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndProfileDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProfile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdDiscountServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndProfileDescriptioDiscountServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwDiscountServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDefaultPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscountPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbhFreeServices As Core.UI.GridButtonHelper
    Friend WithEvents grdFreeServices As Core.UI.CoreGrid
    Friend WithEvents gvwFreeServices As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProfile As Client.ClassifierPicker
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bndProfileDescription As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdDiscountServices As Core.UI.CoreGrid
    Friend WithEvents gvwDiscountServices As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridButtonHelper1 As Core.UI.GridButtonHelper
    Friend WithEvents bndProfileDescriptionFreeServices As System.Windows.Forms.BindingSource
    Friend WithEvents bndProfileDescriptioDiscountServices As System.Windows.Forms.BindingSource
    Friend WithEvents colService1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFreeServices As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDefaultPrice As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDiscountPrice As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
