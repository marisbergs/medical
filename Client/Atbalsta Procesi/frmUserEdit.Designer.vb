<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserEdit
    Inherits Client.frmUIBase
    'яā
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserEdit))
        Me.colTuesday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colMonday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWednesday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colThursday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFriday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaturday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSunday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblWorkFrom = New System.Windows.Forms.Label()
        Me.bndUser = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.chkActual = New System.Windows.Forms.CheckBox()
        Me.lblWorkTo = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblMobPhone = New System.Windows.Forms.Label()
        Me.lblSignature = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblActiveDirectory = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.bndRole = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.dtpWorksFrom = New DevExpress.XtraEditors.DateEdit()
        Me.dtpWorksUntil = New DevExpress.XtraEditors.DateEdit()
        Me.gbxBasicInfo = New System.Windows.Forms.GroupBox()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastName = New DevExpress.XtraEditors.TextEdit()
        Me.txtOtherNames = New DevExpress.XtraEditors.TextEdit()
        Me.txtFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.txtPosition = New Client.ClassifierPicker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPasswordDublicate = New DevExpress.XtraEditors.TextEdit()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblPasswordDublicate = New System.Windows.Forms.Label()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtCellPhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtPhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtSignature = New DevExpress.XtraEditors.TextEdit()
        Me.txtLogon = New DevExpress.XtraEditors.TextEdit()
        Me.btnDeleteRole = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grdSpeciality = New Core.UI.CoreGrid()
        Me.bndSpeciality = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwSpeciality = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSpeciality = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtSpeciality = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colUntil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gbhSpeciality = New Core.UI.GridButtonHelper()
        Me.tabServices = New System.Windows.Forms.TabPage()
        Me.grdServices = New Core.UI.CoreGrid()
        Me.cmsCopySalary = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itmCopyToEmpty = New System.Windows.Forms.ToolStripMenuItem()
        Me.bndServices = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwServices = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtService = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colServiceDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colSeleryType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbSeleryType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colSeleryValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSelery = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbSelery = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gbhServices = New Core.UI.GridButtonHelper()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.grdWorkTime = New Core.UI.CoreGrid()
        Me.bndWorkTime = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwWorkTime = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridButtonHelper1 = New Core.UI.GridButtonHelper()
        Me.btnDeleteRecords = New System.Windows.Forms.Button()
        Me.pagLanguage = New System.Windows.Forms.TabPage()
        Me.grdLanguage = New Core.UI.CoreGrid()
        Me.bndLanguage = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwLanguage = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLanguage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtLaguage = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colIsActive1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.gbhLanguage = New Core.UI.GridButtonHelper()
        Me.pagAccounting = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ClassifierPicker1 = New Client.ClassifierPicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSalary = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndRole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.dtpWorksFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpWorksUntil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBasicInfo.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherNames.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtPasswordDublicate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCellPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSignature.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLogon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.grdSpeciality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndSpeciality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwSpeciality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSpeciality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabServices.SuspendLayout()
        CType(Me.grdServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsCopySalary.SuspendLayout()
        CType(Me.bndServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSeleryType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSelery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.grdWorkTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndWorkTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwWorkTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridButtonHelper1.SuspendLayout()
        Me.pagLanguage.SuspendLayout()
        CType(Me.grdLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLaguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagAccounting.SuspendLayout()
        CType(Me.ClassifierPicker1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colTuesday
        '
        Me.colTuesday.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTuesday.AppearanceCell.Options.UseFont = True
        Me.colTuesday.AppearanceCell.Options.UseTextOptions = True
        Me.colTuesday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTuesday.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colTuesday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTuesday.Caption = "Otrdiena"
        Me.colTuesday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colTuesday.FieldName = "Tuesday"
        Me.colTuesday.Name = "colTuesday"
        Me.colTuesday.Visible = True
        Me.colTuesday.VisibleIndex = 2
        Me.colTuesday.Width = 105
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colMonday
        '
        Me.colMonday.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMonday.AppearanceCell.Options.UseFont = True
        Me.colMonday.AppearanceCell.Options.UseTextOptions = True
        Me.colMonday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMonday.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colMonday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMonday.Caption = "Pirmdiena"
        Me.colMonday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colMonday.FieldName = "Monday"
        Me.colMonday.Name = "colMonday"
        Me.colMonday.Visible = True
        Me.colMonday.VisibleIndex = 1
        Me.colMonday.Width = 105
        '
        'colWednesday
        '
        Me.colWednesday.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colWednesday.AppearanceCell.Options.UseFont = True
        Me.colWednesday.AppearanceCell.Options.UseTextOptions = True
        Me.colWednesday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWednesday.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colWednesday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWednesday.Caption = "Trešdiena"
        Me.colWednesday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colWednesday.FieldName = "Wednesday"
        Me.colWednesday.Name = "colWednesday"
        Me.colWednesday.Visible = True
        Me.colWednesday.VisibleIndex = 3
        Me.colWednesday.Width = 105
        '
        'colThursday
        '
        Me.colThursday.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colThursday.AppearanceCell.Options.UseFont = True
        Me.colThursday.AppearanceCell.Options.UseTextOptions = True
        Me.colThursday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colThursday.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colThursday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colThursday.Caption = "Ceturtdiena"
        Me.colThursday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colThursday.FieldName = "Thursday"
        Me.colThursday.Name = "colThursday"
        Me.colThursday.Visible = True
        Me.colThursday.VisibleIndex = 4
        Me.colThursday.Width = 105
        '
        'colFriday
        '
        Me.colFriday.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFriday.AppearanceCell.Options.UseFont = True
        Me.colFriday.AppearanceCell.Options.UseTextOptions = True
        Me.colFriday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFriday.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colFriday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFriday.Caption = "Piektdiena"
        Me.colFriday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colFriday.FieldName = "Friday"
        Me.colFriday.Name = "colFriday"
        Me.colFriday.Visible = True
        Me.colFriday.VisibleIndex = 5
        Me.colFriday.Width = 105
        '
        'colSaturday
        '
        Me.colSaturday.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSaturday.AppearanceCell.Options.UseFont = True
        Me.colSaturday.AppearanceCell.Options.UseTextOptions = True
        Me.colSaturday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSaturday.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colSaturday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSaturday.Caption = "Sestdiena"
        Me.colSaturday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colSaturday.FieldName = "Saturday"
        Me.colSaturday.Name = "colSaturday"
        Me.colSaturday.Visible = True
        Me.colSaturday.VisibleIndex = 6
        Me.colSaturday.Width = 105
        '
        'colSunday
        '
        Me.colSunday.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSunday.AppearanceCell.Options.UseFont = True
        Me.colSunday.AppearanceCell.Options.UseTextOptions = True
        Me.colSunday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSunday.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colSunday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSunday.Caption = "Svētdiena"
        Me.colSunday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colSunday.FieldName = "Sunday"
        Me.colSunday.Name = "colSunday"
        Me.colSunday.Visible = True
        Me.colSunday.VisibleIndex = 7
        Me.colSunday.Width = 112
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "GridColumn1"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(37, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Vārds:"
        '
        'lblWorkFrom
        '
        Me.lblWorkFrom.AutoSize = True
        Me.lblWorkFrom.Location = New System.Drawing.Point(9, 101)
        Me.lblWorkFrom.Name = "lblWorkFrom"
        Me.lblWorkFrom.Size = New System.Drawing.Size(56, 13)
        Me.lblWorkFrom.TabIndex = 5
        Me.lblWorkFrom.Text = "Strādā no:"
        '
        'bndUser
        '
        Me.bndUser.DataSource = GetType(Entities.User)
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(9, 22)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(39, 13)
        Me.lblPosition.TabIndex = 11
        Me.lblPosition.Text = "Amats:"
        '
        'chkActual
        '
        Me.chkActual.AutoSize = True
        Me.chkActual.Checked = True
        Me.chkActual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActual.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bndUser, "IsActive", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkActual.Enabled = False
        Me.chkActual.Location = New System.Drawing.Point(347, 100)
        Me.chkActual.Name = "chkActual"
        Me.chkActual.Size = New System.Drawing.Size(61, 17)
        Me.chkActual.TabIndex = 8
        Me.chkActual.TabStop = False
        Me.chkActual.Text = "Aktuāls"
        Me.chkActual.UseVisualStyleBackColor = True
        '
        'lblWorkTo
        '
        Me.lblWorkTo.AutoSize = True
        Me.lblWorkTo.Location = New System.Drawing.Point(209, 101)
        Me.lblWorkTo.Name = "lblWorkTo"
        Me.lblWorkTo.Size = New System.Drawing.Size(26, 13)
        Me.lblWorkTo.TabIndex = 17
        Me.lblWorkTo.Text = "līdz:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(5, 9)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(47, 13)
        Me.lblPhone.TabIndex = 21
        Me.lblPhone.Text = "Tālrunis:"
        '
        'lblMobPhone
        '
        Me.lblMobPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMobPhone.AutoSize = True
        Me.lblMobPhone.Location = New System.Drawing.Point(332, 9)
        Me.lblMobPhone.Name = "lblMobPhone"
        Me.lblMobPhone.Size = New System.Drawing.Size(70, 13)
        Me.lblMobPhone.TabIndex = 23
        Me.lblMobPhone.Text = "Mob. tālrunis:"
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.Location = New System.Drawing.Point(5, 61)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(51, 13)
        Me.lblSignature.TabIndex = 27
        Me.lblSignature.Text = "Paraksts:"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(5, 35)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(45, 13)
        Me.lblMail.TabIndex = 25
        Me.lblMail.Text = "E-pasts:"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(5, 113)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(36, 13)
        Me.lblRole.TabIndex = 37
        Me.lblRole.Text = "Loma:"
        '
        'lblActiveDirectory
        '
        Me.lblActiveDirectory.AutoSize = True
        Me.lblActiveDirectory.Location = New System.Drawing.Point(5, 87)
        Me.lblActiveDirectory.Name = "lblActiveDirectory"
        Me.lblActiveDirectory.Size = New System.Drawing.Size(79, 13)
        Me.lblActiveDirectory.TabIndex = 35
        Me.lblActiveDirectory.Text = "Lietotāja vārds:"
        '
        'cmbRole
        '
        Me.cmbRole.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRole.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.bndUser, "Role", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbRole.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeRole", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbRole.DataSource = Me.bndRole
        Me.cmbRole.DisplayMember = "Name"
        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(102, 110)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(641, 21)
        Me.cmbRole.TabIndex = 6
        Me.cmbRole.ValueMember = "Id"
        '
        'bndRole
        '
        Me.bndRole.DataSource = GetType(Entities.Role)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnChangePassword)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 343)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(784, 29)
        Me.FlowLayoutPanel1.TabIndex = 54
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(701, 3)
        Me.btnClose.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(620, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(539, 3)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(75, 23)
        Me.btnChangePassword.TabIndex = 6
        Me.btnChangePassword.Text = "Mainīt paroli"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(9, 75)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblSurname.TabIndex = 103
        Me.lblSurname.Text = "Uzvārds:"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(486, 48)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(58, 13)
        Me.lblMiddleName.TabIndex = 107
        Me.lblMiddleName.Text = "Otrs vārds:"
        '
        'dtpWorksFrom
        '
        Me.dtpWorksFrom.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndUser, "WorksFrom", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpWorksFrom.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeBaseInfo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpWorksFrom.EditValue = New Date(2005, 12, 6, 17, 55, 52, 0)
        Me.dtpWorksFrom.Location = New System.Drawing.Point(106, 98)
        Me.dtpWorksFrom.Name = "dtpWorksFrom"
        Me.dtpWorksFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.dtpWorksFrom.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.dtpWorksFrom.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpWorksFrom.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dtpWorksFrom.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dtpWorksFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpWorksFrom.Properties.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.dtpWorksFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpWorksFrom.Properties.MaxValue = New Date(9999, 12, 31, 0, 0, 0, 0)
        Me.dtpWorksFrom.Properties.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpWorksFrom.Size = New System.Drawing.Size(85, 20)
        Me.dtpWorksFrom.TabIndex = 6
        '
        'dtpWorksUntil
        '
        Me.dtpWorksUntil.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndUser, "WorkedUntil", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpWorksUntil.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeBaseInfo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpWorksUntil.EditValue = New Date(2006, 7, 14, 17, 56, 3, 0)
        Me.dtpWorksUntil.Location = New System.Drawing.Point(251, 98)
        Me.dtpWorksUntil.Name = "dtpWorksUntil"
        Me.dtpWorksUntil.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.dtpWorksUntil.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpWorksUntil.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dtpWorksUntil.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dtpWorksUntil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpWorksUntil.Properties.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.dtpWorksUntil.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpWorksUntil.Properties.EditFormat.FormatString = "dd.MM.yyyy"
        Me.dtpWorksUntil.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpWorksUntil.Properties.Mask.EditMask = "dd.MM.yyyy"
        Me.dtpWorksUntil.Properties.MaxValue = New Date(9999, 12, 31, 0, 0, 0, 0)
        Me.dtpWorksUntil.Properties.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpWorksUntil.Size = New System.Drawing.Size(85, 20)
        Me.dtpWorksUntil.TabIndex = 7
        '
        'gbxBasicInfo
        '
        Me.gbxBasicInfo.Controls.Add(Me.TextEdit2)
        Me.gbxBasicInfo.Controls.Add(Me.Label2)
        Me.gbxBasicInfo.Controls.Add(Me.TextEdit1)
        Me.gbxBasicInfo.Controls.Add(Me.Label1)
        Me.gbxBasicInfo.Controls.Add(Me.txtLastName)
        Me.gbxBasicInfo.Controls.Add(Me.txtOtherNames)
        Me.gbxBasicInfo.Controls.Add(Me.txtFirstName)
        Me.gbxBasicInfo.Controls.Add(Me.txtPosition)
        Me.gbxBasicInfo.Controls.Add(Me.lblName)
        Me.gbxBasicInfo.Controls.Add(Me.lblWorkFrom)
        Me.gbxBasicInfo.Controls.Add(Me.lblPosition)
        Me.gbxBasicInfo.Controls.Add(Me.dtpWorksUntil)
        Me.gbxBasicInfo.Controls.Add(Me.chkActual)
        Me.gbxBasicInfo.Controls.Add(Me.dtpWorksFrom)
        Me.gbxBasicInfo.Controls.Add(Me.lblWorkTo)
        Me.gbxBasicInfo.Controls.Add(Me.lblSurname)
        Me.gbxBasicInfo.Controls.Add(Me.lblMiddleName)
        Me.gbxBasicInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxBasicInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbxBasicInfo.Location = New System.Drawing.Point(1, 1)
        Me.gbxBasicInfo.Name = "gbxBasicInfo"
        Me.gbxBasicInfo.Size = New System.Drawing.Size(784, 126)
        Me.gbxBasicInfo.TabIndex = 120
        Me.gbxBasicInfo.TabStop = False
        Me.gbxBasicInfo.Text = "Pamatinformācija"
        '
        'TextEdit2
        '
        Me.TextEdit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeBaseInfo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndUser, "Code", True))
        Me.TextEdit2.Location = New System.Drawing.Point(573, 98)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.TextEdit2.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextEdit2.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.TextEdit2.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.TextEdit2.Properties.MaxLength = 50
        Me.TextEdit2.Size = New System.Drawing.Size(191, 20)
        Me.TextEdit2.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(486, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Kods:"
        '
        'TextEdit1
        '
        Me.TextEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeBaseInfo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndUser, "PK", True))
        Me.TextEdit1.Location = New System.Drawing.Point(573, 72)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.TextEdit1.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextEdit1.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.TextEdit1.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.TextEdit1.Properties.MaxLength = 50
        Me.TextEdit1.Size = New System.Drawing.Size(191, 20)
        Me.TextEdit1.TabIndex = 108
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(486, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Personas kods:"
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeBaseInfo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndUser, "LastName", True))
        Me.txtLastName.Location = New System.Drawing.Point(106, 72)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtLastName.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLastName.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtLastName.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtLastName.Properties.MaxLength = 50
        Me.txtLastName.Size = New System.Drawing.Size(374, 20)
        Me.txtLastName.TabIndex = 4
        '
        'txtOtherNames
        '
        Me.txtOtherNames.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOtherNames.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeBaseInfo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtOtherNames.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndUser, "OtherNames", True))
        Me.txtOtherNames.Location = New System.Drawing.Point(573, 45)
        Me.txtOtherNames.Name = "txtOtherNames"
        Me.txtOtherNames.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtOtherNames.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOtherNames.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtOtherNames.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtOtherNames.Properties.MaxLength = 100
        Me.txtOtherNames.Size = New System.Drawing.Size(191, 20)
        Me.txtOtherNames.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeBaseInfo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndUser, "FirstName", True))
        Me.txtFirstName.Location = New System.Drawing.Point(106, 45)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtFirstName.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFirstName.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtFirstName.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtFirstName.Properties.MaxLength = 50
        Me.txtFirstName.Size = New System.Drawing.Size(374, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtPosition
        '
        Me.txtPosition.AllowDrop = True
        Me.txtPosition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPosition.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndUser, "Position", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPosition.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeBaseInfo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPosition.Location = New System.Drawing.Point(106, 19)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.PickerPresets = Nothing
        Me.txtPosition.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtPosition.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPosition.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPosition.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPosition.Properties.ReadOnly = True
        Me.txtPosition.Size = New System.Drawing.Size(658, 20)
        Me.txtPosition.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.tabServices)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.pagLanguage)
        Me.TabControl1.Controls.Add(Me.pagAccounting)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(1, 127)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 216)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.txtCellPhone)
        Me.TabPage1.Controls.Add(Me.txtPhone)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtSignature)
        Me.TabPage1.Controls.Add(Me.txtLogon)
        Me.TabPage1.Controls.Add(Me.btnDeleteRole)
        Me.TabPage1.Controls.Add(Me.lblPhone)
        Me.TabPage1.Controls.Add(Me.cmbRole)
        Me.TabPage1.Controls.Add(Me.lblRole)
        Me.TabPage1.Controls.Add(Me.lblMobPhone)
        Me.TabPage1.Controls.Add(Me.lblActiveDirectory)
        Me.TabPage1.Controls.Add(Me.lblSignature)
        Me.TabPage1.Controls.Add(Me.lblMail)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(776, 190)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Papildinformācija"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtPasswordDublicate)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.lblPasswordDublicate)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Location = New System.Drawing.Point(0, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 24)
        Me.Panel1.TabIndex = 42
        Me.Panel1.Visible = False
        '
        'txtPasswordDublicate
        '
        Me.txtPasswordDublicate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPasswordDublicate.Location = New System.Drawing.Point(425, 2)
        Me.txtPasswordDublicate.Name = "txtPasswordDublicate"
        Me.txtPasswordDublicate.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtPasswordDublicate.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPasswordDublicate.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPasswordDublicate.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPasswordDublicate.Properties.MaxLength = 128
        Me.txtPasswordDublicate.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordDublicate.Size = New System.Drawing.Size(344, 20)
        Me.txtPasswordDublicate.TabIndex = 40
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(5, 5)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(40, 13)
        Me.lblPassword.TabIndex = 39
        Me.lblPassword.Text = "Parole:"
        '
        'lblPasswordDublicate
        '
        Me.lblPasswordDublicate.AutoSize = True
        Me.lblPasswordDublicate.Location = New System.Drawing.Point(338, 5)
        Me.lblPasswordDublicate.Name = "lblPasswordDublicate"
        Me.lblPasswordDublicate.Size = New System.Drawing.Size(81, 13)
        Me.lblPasswordDublicate.TabIndex = 41
        Me.lblPasswordDublicate.Text = "Parole atkārtoti:"
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndUser, "Password", True))
        Me.txtPassword.Location = New System.Drawing.Point(102, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtPassword.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPassword.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPassword.Properties.MaxLength = 128
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(230, 20)
        Me.txtPassword.TabIndex = 38
        '
        'txtCellPhone
        '
        Me.txtCellPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCellPhone.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeOtherInfo", True))
        Me.txtCellPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndUser, "CellPhone", True))
        Me.txtCellPhone.Location = New System.Drawing.Point(419, 6)
        Me.txtCellPhone.Name = "txtCellPhone"
        Me.txtCellPhone.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtCellPhone.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCellPhone.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCellPhone.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCellPhone.Properties.MaxLength = 30
        Me.txtCellPhone.Size = New System.Drawing.Size(351, 20)
        Me.txtCellPhone.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeOtherInfo", True))
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndUser, "Phone", True))
        Me.txtPhone.Location = New System.Drawing.Point(102, 6)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtPhone.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPhone.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPhone.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPhone.Properties.MaxLength = 30
        Me.txtPhone.Size = New System.Drawing.Size(224, 20)
        Me.txtPhone.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeOtherInfo", True))
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndUser, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(102, 32)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmail.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEmail.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtEmail.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtEmail.Properties.Mask.EditMask = "\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Me.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtEmail.Properties.Mask.ShowPlaceHolders = False
        Me.txtEmail.Properties.MaxLength = 100
        Me.txtEmail.Size = New System.Drawing.Size(668, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtSignature
        '
        Me.txtSignature.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSignature.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeOtherInfo", True))
        Me.txtSignature.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndUser, "Signature", True))
        Me.txtSignature.Location = New System.Drawing.Point(102, 58)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtSignature.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSignature.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtSignature.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtSignature.Properties.MaxLength = 50
        Me.txtSignature.Size = New System.Drawing.Size(668, 20)
        Me.txtSignature.TabIndex = 4
        '
        'txtLogon
        '
        Me.txtLogon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndUser, "Logon", True))
        Me.txtLogon.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeLogonRole", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtLogon.Location = New System.Drawing.Point(102, 84)
        Me.txtLogon.Name = "txtLogon"
        Me.txtLogon.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtLogon.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLogon.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtLogon.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtLogon.Properties.MaxLength = 128
        Me.txtLogon.Size = New System.Drawing.Size(668, 20)
        Me.txtLogon.TabIndex = 5
        '
        'btnDeleteRole
        '
        Me.btnDeleteRole.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteRole.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeRole", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDeleteRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.btnDeleteRole.Location = New System.Drawing.Point(749, 111)
        Me.btnDeleteRole.Name = "btnDeleteRole"
        Me.btnDeleteRole.Size = New System.Drawing.Size(21, 21)
        Me.btnDeleteRole.TabIndex = 7
        Me.btnDeleteRole.Text = "X"
        Me.btnDeleteRole.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdSpeciality)
        Me.TabPage2.Controls.Add(Me.gbhSpeciality)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 190)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Specialitātes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grdSpeciality
        '
        Me.grdSpeciality.DataSource = Me.bndSpeciality
        Me.grdSpeciality.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdSpeciality.EmbeddedNavigator.Name = ""
        Me.grdSpeciality.EnforceCanEdit = False
        Me.grdSpeciality.Location = New System.Drawing.Point(3, 31)
        Me.grdSpeciality.MainView = Me.gvwSpeciality
        Me.grdSpeciality.Name = "grdSpeciality"
        Me.grdSpeciality.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtSpeciality, Me.RepositoryItemDateEdit1})
        Me.grdSpeciality.ShowOnlyActive = False
        Me.grdSpeciality.Size = New System.Drawing.Size(770, 156)
        Me.grdSpeciality.TabIndex = 116
        Me.grdSpeciality.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSpeciality})
        '
        'bndSpeciality
        '
        Me.bndSpeciality.DataSource = GetType(Entities.UsersSpecialities)
        '
        'gvwSpeciality
        '
        Me.gvwSpeciality.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSpeciality, Me.colIsActive, Me.colNumber, Me.colFrom, Me.colUntil})
        Me.gvwSpeciality.GridControl = Me.grdSpeciality
        Me.gvwSpeciality.MRUFilters.Add(CType(resources.GetObject("gvwSpeciality.MRUFilters"), DevExpress.XtraGrid.Views.Base.ViewFilter))
        Me.gvwSpeciality.Name = "gvwSpeciality"
        Me.gvwSpeciality.OptionsView.ShowFilterPanel = False
        Me.gvwSpeciality.OptionsView.ShowGroupPanel = False
        Me.gvwSpeciality.OptionsView.ShowIndicator = False
        '
        'colSpeciality
        '
        Me.colSpeciality.Caption = "Specialitāte"
        Me.colSpeciality.ColumnEdit = Me.txtSpeciality
        Me.colSpeciality.FieldName = "Speciality"
        Me.colSpeciality.Name = "colSpeciality"
        Me.colSpeciality.Visible = True
        Me.colSpeciality.VisibleIndex = 0
        Me.colSpeciality.Width = 341
        '
        'txtSpeciality
        '
        Me.txtSpeciality.AutoHeight = False
        Me.txtSpeciality.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtSpeciality.Name = "txtSpeciality"
        Me.txtSpeciality.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colNumber
        '
        Me.colNumber.Caption = "Numurs"
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 1
        Me.colNumber.Width = 101
        '
        'colFrom
        '
        Me.colFrom.Caption = "Spēkā no"
        Me.colFrom.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colFrom.FieldName = "From"
        Me.colFrom.Name = "colFrom"
        Me.colFrom.Visible = True
        Me.colFrom.VisibleIndex = 2
        Me.colFrom.Width = 101
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colUntil
        '
        Me.colUntil.Caption = "Spēkā līdz"
        Me.colUntil.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colUntil.FieldName = "Until"
        Me.colUntil.Name = "colUntil"
        Me.colUntil.Visible = True
        Me.colUntil.VisibleIndex = 3
        Me.colUntil.Width = 103
        '
        'gbhSpeciality
        '
        Me.gbhSpeciality.DeleteReason = False
        Me.gbhSpeciality.DeleteReasonColumn = Nothing
        Me.gbhSpeciality.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhSpeciality.Grid = Me.grdSpeciality
        Me.gbhSpeciality.GridDataSource = Me.bndSpeciality
        Me.gbhSpeciality.Location = New System.Drawing.Point(3, 3)
        Me.gbhSpeciality.Name = "gbhSpeciality"
        Me.gbhSpeciality.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbhSpeciality.ShowActive = False
        Me.gbhSpeciality.ShowAdd = True
        Me.gbhSpeciality.ShowChk = True
        Me.gbhSpeciality.ShowDelete = True
        Me.gbhSpeciality.Size = New System.Drawing.Size(770, 28)
        Me.gbhSpeciality.TabIndex = 117
        Me.gbhSpeciality.UseCanDelete = True
        '
        'tabServices
        '
        Me.tabServices.Controls.Add(Me.grdServices)
        Me.tabServices.Controls.Add(Me.gbhServices)
        Me.tabServices.Location = New System.Drawing.Point(4, 22)
        Me.tabServices.Name = "tabServices"
        Me.tabServices.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServices.Size = New System.Drawing.Size(776, 190)
        Me.tabServices.TabIndex = 3
        Me.tabServices.Text = "Pakalpojumi"
        Me.tabServices.UseVisualStyleBackColor = True
        '
        'grdServices
        '
        Me.grdServices.ContextMenuStrip = Me.cmsCopySalary
        Me.grdServices.DataSource = Me.bndServices
        Me.grdServices.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdServices.EmbeddedNavigator.Name = ""
        Me.grdServices.EnforceCanEdit = False
        Me.grdServices.Location = New System.Drawing.Point(3, 31)
        Me.grdServices.MainView = Me.gvwServices
        Me.grdServices.Name = "grdServices"
        Me.grdServices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtService, Me.RepositoryItemSpinEdit1, Me.RepositoryItemTextEdit3, Me.RepositoryItemCheckEdit1, Me.cmbSeleryType, Me.cmbSelery})
        Me.grdServices.ShowOnlyActive = False
        Me.grdServices.Size = New System.Drawing.Size(770, 156)
        Me.grdServices.TabIndex = 118
        Me.grdServices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwServices})
        '
        'cmsCopySalary
        '
        Me.cmsCopySalary.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmCopyToEmpty})
        Me.cmsCopySalary.Name = "cmsCopySalary"
        Me.cmsCopySalary.Size = New System.Drawing.Size(381, 26)
        '
        'itmCopyToEmpty
        '
        Me.itmCopyToEmpty.Name = "itmCopyToEmpty"
        Me.itmCopyToEmpty.Size = New System.Drawing.Size(380, 22)
        Me.itmCopyToEmpty.Text = "Kopēt tekošā ieraksta datus uz visiem tukšajiem ierakstiem"
        '
        'bndServices
        '
        Me.bndServices.DataSource = GetType(Entities.UserService)
        '
        'gvwServices
        '
        Me.gvwServices.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colService, Me.colPrice, Me.colTime, Me.GridColumn3, Me.colServiceDelete, Me.colSeleryType, Me.colSeleryValue, Me.colSelery, Me.GridColumn5, Me.GridColumn6})
        Me.gvwServices.GridControl = Me.grdServices
        Me.gvwServices.Name = "gvwServices"
        Me.gvwServices.OptionsView.ShowDetailButtons = False
        Me.gvwServices.OptionsView.ShowFilterPanel = False
        Me.gvwServices.OptionsView.ShowGroupPanel = False
        Me.gvwServices.OptionsView.ShowIndicator = False
        '
        'colCode
        '
        Me.colCode.Caption = "Kods"
        Me.colCode.FieldName = "ServiceCode"
        Me.colCode.Name = "colCode"
        Me.colCode.OptionsColumn.ReadOnly = True
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        Me.colCode.Width = 56
        '
        'colService
        '
        Me.colService.Caption = "Pakalpojums"
        Me.colService.ColumnEdit = Me.txtService
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.Visible = True
        Me.colService.VisibleIndex = 1
        Me.colService.Width = 205
        '
        'txtService
        '
        Me.txtService.AutoHeight = False
        Me.txtService.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtService.Name = "txtService"
        Me.txtService.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colPrice
        '
        Me.colPrice.AppearanceCell.Options.UseTextOptions = True
        Me.colPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colPrice.Caption = "Cena"
        Me.colPrice.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 2
        Me.colPrice.Width = 41
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "n2"
        Me.RepositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'colTime
        '
        Me.colTime.AppearanceCell.Options.UseTextOptions = True
        Me.colTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colTime.Caption = "Ilgums min"
        Me.colTime.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colTime.FieldName = "Time"
        Me.colTime.Name = "colTime"
        Me.colTime.Visible = True
        Me.colTime.VisibleIndex = 3
        Me.colTime.Width = 65
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn1"
        Me.GridColumn3.FieldName = "IsActive"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'colServiceDelete
        '
        Me.colServiceDelete.Caption = "Pakalpojums dzēsts/neaktīvs"
        Me.colServiceDelete.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colServiceDelete.FieldName = "IsServiceDelete"
        Me.colServiceDelete.Name = "colServiceDelete"
        Me.colServiceDelete.OptionsColumn.ReadOnly = True
        Me.colServiceDelete.Visible = True
        Me.colServiceDelete.VisibleIndex = 4
        Me.colServiceDelete.Width = 108
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colSeleryType
        '
        Me.colSeleryType.Caption = "Atalgojums par"
        Me.colSeleryType.ColumnEdit = Me.cmbSeleryType
        Me.colSeleryType.FieldName = "SeleryType"
        Me.colSeleryType.Name = "colSeleryType"
        Me.colSeleryType.Visible = True
        Me.colSeleryType.VisibleIndex = 5
        Me.colSeleryType.Width = 51
        '
        'cmbSeleryType
        '
        Me.cmbSeleryType.AutoHeight = False
        Me.cmbSeleryType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbSeleryType.Name = "cmbSeleryType"
        Me.cmbSeleryType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colSeleryValue
        '
        Me.colSeleryValue.Caption = "Apjoms"
        Me.colSeleryValue.FieldName = "SeleryValue"
        Me.colSeleryValue.Name = "colSeleryValue"
        Me.colSeleryValue.Visible = True
        Me.colSeleryValue.VisibleIndex = 6
        Me.colSeleryValue.Width = 29
        '
        'colSelery
        '
        Me.colSelery.Caption = "Mērvienība"
        Me.colSelery.ColumnEdit = Me.cmbSelery
        Me.colSelery.FieldName = "Selery"
        Me.colSelery.Name = "colSelery"
        Me.colSelery.Visible = True
        Me.colSelery.VisibleIndex = 7
        Me.colSelery.Width = 45
        '
        'cmbSelery
        '
        Me.cmbSelery.AutoHeight = False
        Me.cmbSelery.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbSelery.Name = "cmbSelery"
        Me.cmbSelery.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Neiekļaut PVN"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn5.FieldName = "RemoveVAT"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 8
        Me.GridColumn5.Width = 66
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Neiekļaut materiālus"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn6.FieldName = "RemoveMaterials"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 9
        Me.GridColumn6.Width = 102
        '
        'gbhServices
        '
        Me.gbhServices.DeleteReason = False
        Me.gbhServices.DeleteReasonColumn = Nothing
        Me.gbhServices.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhServices.Grid = Me.grdServices
        Me.gbhServices.GridDataSource = Me.bndServices
        Me.gbhServices.Location = New System.Drawing.Point(3, 3)
        Me.gbhServices.Name = "gbhServices"
        Me.gbhServices.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbhServices.ShowActive = False
        Me.gbhServices.ShowAdd = True
        Me.gbhServices.ShowChk = True
        Me.gbhServices.ShowDelete = True
        Me.gbhServices.Size = New System.Drawing.Size(770, 28)
        Me.gbhServices.TabIndex = 119
        Me.gbhServices.UseCanDelete = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.grdWorkTime)
        Me.TabPage3.Controls.Add(Me.GridButtonHelper1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(776, 190)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Darba laiki"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'grdWorkTime
        '
        Me.grdWorkTime.DataSource = Me.bndWorkTime
        Me.grdWorkTime.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdWorkTime.EmbeddedNavigator.Name = ""
        Me.grdWorkTime.EnforceCanEdit = False
        Me.grdWorkTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.grdWorkTime.Location = New System.Drawing.Point(3, 31)
        Me.grdWorkTime.MainView = Me.gvwWorkTime
        Me.grdWorkTime.Name = "grdWorkTime"
        Me.grdWorkTime.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemMemoEdit1, Me.RepositoryItemGridLookUpEdit1})
        Me.grdWorkTime.ShowOnlyActive = False
        Me.grdWorkTime.Size = New System.Drawing.Size(770, 156)
        Me.grdWorkTime.TabIndex = 118
        Me.grdWorkTime.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwWorkTime})
        '
        'bndWorkTime
        '
        Me.bndWorkTime.DataSource = GetType(Entities.TimeTable)
        '
        'gvwWorkTime
        '
        Me.gvwWorkTime.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gvwWorkTime.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gvwWorkTime.Appearance.Row.BackColor = System.Drawing.Color.Silver
        Me.gvwWorkTime.Appearance.Row.Options.UseBackColor = True
        Me.gvwWorkTime.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colMonday, Me.colTuesday, Me.colWednesday, Me.colThursday, Me.colFriday, Me.colSaturday, Me.colSunday})
        Me.gvwWorkTime.GridControl = Me.grdWorkTime
        Me.gvwWorkTime.MRUFilters.Add(CType(resources.GetObject("gvwWorkTime.MRUFilters"), DevExpress.XtraGrid.Views.Base.ViewFilter))
        Me.gvwWorkTime.Name = "gvwWorkTime"
        Me.gvwWorkTime.OptionsBehavior.Editable = False
        Me.gvwWorkTime.OptionsCustomization.AllowColumnMoving = False
        Me.gvwWorkTime.OptionsCustomization.AllowFilter = False
        Me.gvwWorkTime.OptionsCustomization.AllowGroup = False
        Me.gvwWorkTime.OptionsCustomization.AllowSort = False
        Me.gvwWorkTime.OptionsSelection.InvertSelection = True
        Me.gvwWorkTime.OptionsView.AllowCellMerge = True
        Me.gvwWorkTime.OptionsView.ShowFilterPanel = False
        Me.gvwWorkTime.OptionsView.ShowGroupPanel = False
        Me.gvwWorkTime.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn1.FieldName = "Time"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowSize = False
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 38
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "HH:mm"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.RepositoryItemTextEdit1.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridButtonHelper1
        '
        Me.GridButtonHelper1.Controls.Add(Me.btnDeleteRecords)
        Me.GridButtonHelper1.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanAddDeleteWorkTime", True))
        Me.GridButtonHelper1.DeleteReason = False
        Me.GridButtonHelper1.DeleteReasonColumn = Nothing
        Me.GridButtonHelper1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridButtonHelper1.Grid = Me.grdWorkTime
        Me.GridButtonHelper1.GridDataSource = Me.bndWorkTime
        Me.GridButtonHelper1.Location = New System.Drawing.Point(3, 3)
        Me.GridButtonHelper1.Name = "GridButtonHelper1"
        Me.GridButtonHelper1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GridButtonHelper1.ShowActive = False
        Me.GridButtonHelper1.ShowAdd = True
        Me.GridButtonHelper1.ShowChk = False
        Me.GridButtonHelper1.ShowDelete = True
        Me.GridButtonHelper1.Size = New System.Drawing.Size(770, 28)
        Me.GridButtonHelper1.TabIndex = 119
        Me.GridButtonHelper1.UseCanDelete = True
        '
        'btnDeleteRecords
        '
        Me.btnDeleteRecords.AutoSize = True
        Me.btnDeleteRecords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDeleteRecords.Location = New System.Drawing.Point(165, 3)
        Me.btnDeleteRecords.Name = "btnDeleteRecords"
        Me.btnDeleteRecords.Size = New System.Drawing.Size(88, 23)
        Me.btnDeleteRecords.TabIndex = 4
        Me.btnDeleteRecords.Text = "Dzēstie ieraksti"
        Me.btnDeleteRecords.UseVisualStyleBackColor = True
        '
        'pagLanguage
        '
        Me.pagLanguage.Controls.Add(Me.grdLanguage)
        Me.pagLanguage.Controls.Add(Me.gbhLanguage)
        Me.pagLanguage.Location = New System.Drawing.Point(4, 22)
        Me.pagLanguage.Name = "pagLanguage"
        Me.pagLanguage.Padding = New System.Windows.Forms.Padding(3)
        Me.pagLanguage.Size = New System.Drawing.Size(776, 190)
        Me.pagLanguage.TabIndex = 4
        Me.pagLanguage.Text = "Valodas"
        Me.pagLanguage.UseVisualStyleBackColor = True
        '
        'grdLanguage
        '
        Me.grdLanguage.DataSource = Me.bndLanguage
        Me.grdLanguage.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdLanguage.EmbeddedNavigator.Name = ""
        Me.grdLanguage.EnforceCanEdit = False
        Me.grdLanguage.Location = New System.Drawing.Point(3, 31)
        Me.grdLanguage.MainView = Me.gvwLanguage
        Me.grdLanguage.Name = "grdLanguage"
        Me.grdLanguage.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit3, Me.txtLaguage})
        Me.grdLanguage.ShowOnlyActive = False
        Me.grdLanguage.Size = New System.Drawing.Size(770, 156)
        Me.grdLanguage.TabIndex = 118
        Me.grdLanguage.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwLanguage})
        '
        'bndLanguage
        '
        Me.bndLanguage.DataSource = GetType(Entities.UserLanguage)
        '
        'gvwLanguage
        '
        Me.gvwLanguage.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLanguage, Me.colIsActive1})
        Me.gvwLanguage.GridControl = Me.grdLanguage
        Me.gvwLanguage.MRUFilters.Add(CType(resources.GetObject("gvwLanguage.MRUFilters"), DevExpress.XtraGrid.Views.Base.ViewFilter))
        Me.gvwLanguage.Name = "gvwLanguage"
        Me.gvwLanguage.OptionsView.ShowFilterPanel = False
        Me.gvwLanguage.OptionsView.ShowGroupPanel = False
        Me.gvwLanguage.OptionsView.ShowIndicator = False
        '
        'colLanguage
        '
        Me.colLanguage.Caption = "Valoda"
        Me.colLanguage.ColumnEdit = Me.txtLaguage
        Me.colLanguage.FieldName = "Language"
        Me.colLanguage.Name = "colLanguage"
        Me.colLanguage.Visible = True
        Me.colLanguage.VisibleIndex = 0
        '
        'txtLaguage
        '
        Me.txtLaguage.AutoHeight = False
        Me.txtLaguage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtLaguage.Name = "txtLaguage"
        Me.txtLaguage.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colIsActive1
        '
        Me.colIsActive1.Caption = "IsActive"
        Me.colIsActive1.FieldName = "IsActive"
        Me.colIsActive1.Name = "colIsActive1"
        '
        'RepositoryItemButtonEdit3
        '
        Me.RepositoryItemButtonEdit3.AutoHeight = False
        Me.RepositoryItemButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit3.Name = "RepositoryItemButtonEdit3"
        Me.RepositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'gbhLanguage
        '
        Me.gbhLanguage.DeleteReason = False
        Me.gbhLanguage.DeleteReasonColumn = Nothing
        Me.gbhLanguage.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhLanguage.Grid = Me.grdLanguage
        Me.gbhLanguage.GridDataSource = Me.bndLanguage
        Me.gbhLanguage.Location = New System.Drawing.Point(3, 3)
        Me.gbhLanguage.Name = "gbhLanguage"
        Me.gbhLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbhLanguage.ShowActive = False
        Me.gbhLanguage.ShowAdd = True
        Me.gbhLanguage.ShowChk = True
        Me.gbhLanguage.ShowDelete = True
        Me.gbhLanguage.Size = New System.Drawing.Size(770, 28)
        Me.gbhLanguage.TabIndex = 119
        Me.gbhLanguage.UseCanDelete = True
        '
        'pagAccounting
        '
        Me.pagAccounting.Controls.Add(Me.TextBox1)
        Me.pagAccounting.Controls.Add(Me.Label5)
        Me.pagAccounting.Controls.Add(Me.ClassifierPicker1)
        Me.pagAccounting.Controls.Add(Me.Label4)
        Me.pagAccounting.Controls.Add(Me.txtSalary)
        Me.pagAccounting.Controls.Add(Me.Label3)
        Me.pagAccounting.Location = New System.Drawing.Point(4, 22)
        Me.pagAccounting.Name = "pagAccounting"
        Me.pagAccounting.Padding = New System.Windows.Forms.Padding(3)
        Me.pagAccounting.Size = New System.Drawing.Size(776, 190)
        Me.pagAccounting.TabIndex = 5
        Me.pagAccounting.Text = "Grāmatvedība"
        Me.pagAccounting.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndUser, "SalaryNote", True))
        Me.TextBox1.Location = New System.Drawing.Point(124, 66)
        Me.TextBox1.MaxLength = 1000
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(636, 106)
        Me.TextBox1.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Piezīmes:"
        '
        'ClassifierPicker1
        '
        Me.ClassifierPicker1.AllowDrop = True
        Me.ClassifierPicker1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClassifierPicker1.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndUser, "CanChangeBaseInfo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ClassifierPicker1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndUser, "UserGrouping", True))
        Me.ClassifierPicker1.Location = New System.Drawing.Point(124, 40)
        Me.ClassifierPicker1.Name = "ClassifierPicker1"
        Me.ClassifierPicker1.PickerPresets = Nothing
        Me.ClassifierPicker1.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.ClassifierPicker1.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ClassifierPicker1.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.ClassifierPicker1.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.ClassifierPicker1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ClassifierPicker1.Properties.ReadOnly = True
        Me.ClassifierPicker1.Size = New System.Drawing.Size(636, 20)
        Me.ClassifierPicker1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Darbinieku grupējums:"
        '
        'txtSalary
        '
        Me.txtSalary.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndUser, "Salary", True))
        Me.txtSalary.Location = New System.Drawing.Point(124, 16)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Properties.Mask.EditMask = "n2"
        Me.txtSalary.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtSalary.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Atalgojums:"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.DataSource = Me.bndUser
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn4})
        Me.GridView1.MRUFilters.Add(CType(resources.GetObject("GridView1.MRUFilters"), DevExpress.XtraGrid.Views.Base.ViewFilter))
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Specialitāte"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemButtonEdit2
        Me.GridColumn2.FieldName = "Speciality"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        Me.RepositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "GridColumn1"
        Me.GridColumn4.FieldName = "IsActive"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'frmUserEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 373)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.gbxBasicInfo)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "frmUserEdit"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Darbinieka kartiņa"
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndRole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.dtpWorksFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpWorksUntil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBasicInfo.ResumeLayout(False)
        Me.gbxBasicInfo.PerformLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherNames.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtPasswordDublicate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCellPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSignature.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLogon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.grdSpeciality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndSpeciality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwSpeciality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSpeciality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServices.ResumeLayout(False)
        CType(Me.grdServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsCopySalary.ResumeLayout(False)
        CType(Me.bndServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSeleryType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSelery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.grdWorkTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndWorkTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwWorkTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridButtonHelper1.ResumeLayout(False)
        Me.GridButtonHelper1.PerformLayout()
        Me.pagLanguage.ResumeLayout(False)
        CType(Me.grdLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLaguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagAccounting.ResumeLayout(False)
        Me.pagAccounting.PerformLayout()
        CType(Me.ClassifierPicker1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblWorkFrom As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents chkActual As System.Windows.Forms.CheckBox
    Friend WithEvents lblWorkTo As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblMobPhone As System.Windows.Forms.Label
    Friend WithEvents lblSignature As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents lblActiveDirectory As System.Windows.Forms.Label
    Friend WithEvents cmbRole As System.Windows.Forms.ComboBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dtpWorksFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpWorksUntil As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gbxBasicInfo As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grdSpeciality As Core.UI.CoreGrid
    Friend WithEvents gvwSpeciality As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbhSpeciality As Core.UI.GridButtonHelper
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents bndUser As System.Windows.Forms.BindingSource
    Friend WithEvents bndRole As System.Windows.Forms.BindingSource
    Friend WithEvents txtPosition As Client.ClassifierPicker
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDeleteRole As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtLogon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOtherNames As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSignature As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCellPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToolTip1 As DevExpress.Utils.ToolTipController
    Friend WithEvents colSpeciality As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSpeciality As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents bndSpeciality As System.Windows.Forms.BindingSource
    Friend WithEvents txtPasswordDublicate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPasswordDublicate As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents grdWorkTime As Core.UI.CoreGrid
    Friend WithEvents gvwWorkTime As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridButtonHelper1 As Core.UI.GridButtonHelper
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTuesday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWednesday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThursday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFriday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaturday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSunday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bndWorkTime As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabServices As System.Windows.Forms.TabPage
    Friend WithEvents grdServices As Core.UI.CoreGrid
    Friend WithEvents gvwServices As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtService As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gbhServices As Core.UI.GridButtonHelper
    Friend WithEvents bndServices As System.Windows.Forms.BindingSource
    Friend WithEvents colTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents pagLanguage As System.Windows.Forms.TabPage
    Friend WithEvents grdLanguage As Core.UI.CoreGrid
    Friend WithEvents gvwLanguage As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents gbhLanguage As Core.UI.GridButtonHelper
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bndLanguage As System.Windows.Forms.BindingSource
    Friend WithEvents colLanguage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtLaguage As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colIsActive1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiceDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colUntil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeleryType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeleryValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSelery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbSeleryType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmbSelery As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents pagAccounting As System.Windows.Forms.TabPage
    Friend WithEvents txtSalary As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmsCopySalary As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents itmCopyToEmpty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ClassifierPicker1 As Client.ClassifierPicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteRecords As System.Windows.Forms.Button
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
