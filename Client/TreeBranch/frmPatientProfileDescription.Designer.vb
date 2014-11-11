<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientProfileDescription
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
        Dim NumberLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtProfile = New DevExpress.XtraEditors.ButtonEdit
        Me.bndPatientProfileDescription = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateEdit4 = New DevExpress.XtraEditors.DateEdit
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.NumberTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bndProfileDescriptionFreeServices = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.grdFreeServices = New Core.UI.CoreGrid
        Me.gvwFreeServices = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtFreeServices = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gbhFreeServices = New Core.UI.GridButtonHelper
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        NumberLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label9 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtProfile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndPatientProfileDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndProfileDescriptionFreeServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdDiscountServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndProfileDescriptioDiscountServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwDiscountServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDefaultPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscountPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdFreeServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwFreeServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFreeServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumberLabel
        '
        NumberLabel.AutoSize = True
        NumberLabel.Location = New System.Drawing.Point(12, 42)
        NumberLabel.Name = "NumberLabel"
        NumberLabel.Size = New System.Drawing.Size(46, 13)
        NumberLabel.TabIndex = 2
        NumberLabel.Text = "Numurs:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(242, 42)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(24, 13)
        Label2.TabIndex = 5
        Label2.Text = "No:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(378, 42)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(30, 13)
        Label3.TabIndex = 7
        Label3.Text = "Līdz:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(520, 42)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(157, 13)
        Label4.TabIndex = 9
        Label4.Text = "Bezmaksas pakalpojumu skaits:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(748, 42)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(35, 13)
        Label5.TabIndex = 11
        Label5.Text = "Cena:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(12, 68)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(96, 13)
        Label6.TabIndex = 12
        Label6.Text = "Apmaksas datums:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(220, 68)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(97, 13)
        Label7.TabIndex = 15
        Label7.Text = "Apmaksu pieņēma:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(660, 68)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(59, 13)
        Label8.TabIndex = 19
        Label8.Text = "Pievienoja:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(489, 68)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(59, 13)
        Label9.TabIndex = 16
        Label9.Text = "Pievienots:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtProfile)
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Me.DateEdit4)
        Me.GroupBox1.Controls.Add(Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(Me.DateEdit3)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.SpinEdit2)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.SpinEdit1)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.DateEdit2)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.DateEdit1)
        Me.GroupBox1.Controls.Add(NumberLabel)
        Me.GroupBox1.Controls.Add(Me.NumberTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(895, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Primārās aprūpes karte"
        '
        'txtProfile
        '
        Me.txtProfile.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProfileDescription, "Profile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtProfile.Location = New System.Drawing.Point(114, 13)
        Me.txtProfile.Name = "txtProfile"
        Me.txtProfile.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtProfile.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtProfile.Size = New System.Drawing.Size(769, 20)
        Me.txtProfile.TabIndex = 1
        '
        'bndPatientProfileDescription
        '
        Me.bndPatientProfileDescription.DataSource = GetType(Entities.PatientProfileDescription)
        '
        'DateEdit4
        '
        Me.DateEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProfileDescription, "CreateDate", True))
        Me.DateEdit4.EditValue = Nothing
        Me.DateEdit4.Location = New System.Drawing.Point(554, 65)
        Me.DateEdit4.Name = "DateEdit4"
        Me.DateEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.DateEdit4.Properties.ReadOnly = True
        Me.DateEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DateEdit4.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit4.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndPatientProfileDescription, "CreateUser", True))
        Me.TextBox2.Location = New System.Drawing.Point(725, 65)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(158, 20)
        Me.TextBox2.TabIndex = 17
        '
        'DateEdit3
        '
        Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProfileDescription, "PayDate", True))
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Location = New System.Drawing.Point(114, 65)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.DateEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.DateEdit3.Properties.ReadOnly = True
        Me.DateEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DateEdit3.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit3.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndPatientProfileDescription, "PaymentAcceptedByUser", True))
        Me.TextBox1.Location = New System.Drawing.Point(323, 65)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 13
        '
        'SpinEdit2
        '
        Me.SpinEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProfileDescription, "Price", True))
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit2.Location = New System.Drawing.Point(783, 39)
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit2.Properties.DisplayFormat.FormatString = "n2"
        Me.SpinEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit2.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit2.TabIndex = 10
        '
        'SpinEdit1
        '
        Me.SpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProfileDescription, "Count", True))
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(683, 39)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Properties.DisplayFormat.FormatString = "n0"
        Me.SpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.EditFormat.FormatString = "n0"
        Me.SpinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Size = New System.Drawing.Size(59, 20)
        Me.SpinEdit1.TabIndex = 8
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProfileDescription, "EndDate", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(414, 39)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 6
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProfileDescription, "BeginDate", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(272, 39)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 4
        '
        'NumberTextBox
        '
        Me.NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndPatientProfileDescription, "Number", True))
        Me.NumberTextBox.Location = New System.Drawing.Point(114, 39)
        Me.NumberTextBox.MaxLength = 10
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(122, 20)
        Me.NumberTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Profila nosaukums:"
        '
        'bndProfileDescriptionFreeServices
        '
        Me.bndProfileDescriptionFreeServices.DataSource = GetType(Entities.PatientProfileDescriptionService)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdDiscountServices)
        Me.GroupBox2.Controls.Add(Me.SplitContainer2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(0, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(895, 246)
        Me.GroupBox2.TabIndex = 5
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
        Me.grdDiscountServices.Size = New System.Drawing.Size(889, 196)
        Me.grdDiscountServices.TabIndex = 1
        Me.grdDiscountServices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwDiscountServices})
        '
        'bndProfileDescriptioDiscountServices
        '
        Me.bndProfileDescriptioDiscountServices.DataSource = GetType(Entities.PatientProfileDescriptionService)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(889, 31)
        Me.SplitContainer2.SplitterDistance = 480
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
        Me.GridButtonHelper1.Size = New System.Drawing.Size(480, 31)
        Me.GridButtonHelper1.TabIndex = 0
        Me.GridButtonHelper1.UseCanDelete = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdFreeServices)
        Me.GroupBox3.Controls.Add(Me.SplitContainer1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(0, 93)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(895, 129)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Primārās aprūpes bezmaksas pakalpojumi"
        '
        'grdFreeServices
        '
        Me.grdFreeServices.DataSource = Me.bndProfileDescriptionFreeServices
        Me.grdFreeServices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFreeServices.EmbeddedNavigator.Name = ""
        Me.grdFreeServices.EnforceCanEdit = False
        Me.grdFreeServices.Location = New System.Drawing.Point(3, 47)
        Me.grdFreeServices.MainView = Me.gvwFreeServices
        Me.grdFreeServices.Name = "grdFreeServices"
        Me.grdFreeServices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtFreeServices})
        Me.grdFreeServices.ShowOnlyActive = False
        Me.grdFreeServices.Size = New System.Drawing.Size(889, 79)
        Me.grdFreeServices.TabIndex = 1
        Me.grdFreeServices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwFreeServices})
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
        Me.SplitContainer1.Size = New System.Drawing.Size(889, 31)
        Me.SplitContainer1.SplitterDistance = 480
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
        Me.gbhFreeServices.Size = New System.Drawing.Size(480, 31)
        Me.gbhFreeServices.TabIndex = 0
        Me.gbhFreeServices.UseCanDelete = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPrint)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 468)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(895, 29)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(817, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(736, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.AutoSize = True
        Me.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPrint.Location = New System.Drawing.Point(654, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(76, 23)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Drukāt čeku"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndPatientProfileDescription
        '
        'frmPatientProfileDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(895, 497)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPatientProfileDescription"
        Me.Text = "Primārās aprūpes karte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtProfile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndPatientProfileDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndProfileDescriptionFreeServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdDiscountServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndProfileDescriptioDiscountServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwDiscountServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDefaultPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscountPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdFreeServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwFreeServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFreeServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents bndPatientProfileDescription As System.Windows.Forms.BindingSource
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateEdit4 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtProfile As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents bndProfileDescriptionFreeServices As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdDiscountServices As Core.UI.CoreGrid
    Friend WithEvents bndProfileDescriptioDiscountServices As System.Windows.Forms.BindingSource
    Friend WithEvents gvwDiscountServices As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colService1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDefaultPrice As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDiscountPrice As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridButtonHelper1 As Core.UI.GridButtonHelper
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grdFreeServices As Core.UI.CoreGrid
    Friend WithEvents gvwFreeServices As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFreeServices As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbhFreeServices As Core.UI.GridButtonHelper
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
