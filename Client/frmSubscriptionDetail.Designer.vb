<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubscriptionDetail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPatient = New Client.ClassifierPicker()
        Me.bndSubscription = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPaymentType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtService = New DevExpress.XtraEditors.ButtonEdit()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPayDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdDetails = New Core.UI.CoreGrid()
        Me.bndDetails = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAppointment1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVisit1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtVisit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBay = New System.Windows.Forms.Button()
        Me.btnSetPayTime = New System.Windows.Forms.Button()
        Me.colSource = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVersion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsDirty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCanEdit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCanDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCanSave = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCanSee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleteNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleteTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsValid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVisit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAppointment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubscription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.txtPatient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndSubscription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVisit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Klients:"
        '
        'txtPatient
        '
        Me.txtPatient.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndSubscription, "Patient", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPatient.Location = New System.Drawing.Point(74, 19)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.PickerPresets = Nothing
        Me.txtPatient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPatient.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPatient.Size = New System.Drawing.Size(304, 20)
        Me.txtPatient.TabIndex = 1
        '
        'bndSubscription
        '
        Me.bndSubscription.DataSource = GetType(Entities.Subscription)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPaymentType)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtService)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPayDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPatient)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 167)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Abonements"
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.bndSubscription, "PaymentType", True))
        Me.cmbPaymentType.FormattingEnabled = True
        Me.cmbPaymentType.Location = New System.Drawing.Point(304, 71)
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.Size = New System.Drawing.Size(160, 21)
        Me.cmbPaymentType.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Apmaksu veids:"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(746, 71)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(118, 20)
        Me.TextBox5.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(701, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Statuss:"
        '
        'txtService
        '
        Me.txtService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtService.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndSubscription, "Service", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtService.Location = New System.Drawing.Point(482, 19)
        Me.txtService.Name = "txtService"
        Me.txtService.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtService.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtService.Size = New System.Drawing.Size(498, 20)
        Me.txtService.TabIndex = 16
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(267, 43)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Atjaunot"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSubscription, "Comment", True))
        Me.TextBox3.Location = New System.Drawing.Point(74, 100)
        Me.TextBox3.MaxLength = 500
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(906, 61)
        Me.TextBox3.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Piezīmes:"
        '
        'txtPayDate
        '
        Me.txtPayDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndSubscription, "PayTime", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPayDate.EditValue = Nothing
        Me.txtPayDate.Enabled = False
        Me.txtPayDate.Location = New System.Drawing.Point(110, 71)
        Me.txtPayDate.Name = "txtPayDate"
        Me.txtPayDate.Properties.DisplayFormat.FormatString = "G"
        Me.txtPayDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtPayDate.Properties.Mask.EditMask = "G"
        Me.txtPayDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPayDate.Size = New System.Drawing.Size(100, 20)
        Me.txtPayDate.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(470, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Apmaksu pieņēma:"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSubscription, "UserAcceptedPayment", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox4.Location = New System.Drawing.Point(570, 71)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(127, 20)
        Me.TextBox4.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Apmaksas datums:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Reižu skaits:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSubscription, "TimeCount", True))
        Me.TextBox2.Location = New System.Drawing.Point(216, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(45, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cena:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSubscription, "Price", True))
        Me.TextBox1.Location = New System.Drawing.Point(74, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(63, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pakalpojums:"
        '
        'grdDetails
        '
        Me.grdDetails.DataSource = Me.bndDetails
        Me.grdDetails.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdDetails.EmbeddedNavigator.Name = ""
        Me.grdDetails.EnforceCanEdit = False
        Me.grdDetails.Location = New System.Drawing.Point(0, 167)
        Me.grdDetails.MainView = Me.gvwDetails
        Me.grdDetails.Name = "grdDetails"
        Me.grdDetails.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtVisit})
        Me.grdDetails.ShowOnlyActive = False
        Me.grdDetails.Size = New System.Drawing.Size(992, 202)
        Me.grdDetails.TabIndex = 4
        Me.grdDetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwDetails})
        '
        'bndDetails
        '
        Me.bndDetails.DataSource = GetType(Entities.SubscriptionDetail)
        '
        'gvwDetails
        '
        Me.gvwDetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAppointment1, Me.colPrice1, Me.colService, Me.colVisit1})
        Me.gvwDetails.GridControl = Me.grdDetails
        Me.gvwDetails.Name = "gvwDetails"
        Me.gvwDetails.OptionsView.ColumnAutoWidth = False
        Me.gvwDetails.OptionsView.ShowFilterPanel = False
        Me.gvwDetails.OptionsView.ShowGroupPanel = False
        Me.gvwDetails.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colAppointment1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colAppointment1
        '
        Me.colAppointment1.Caption = "Apmeklējuma reize"
        Me.colAppointment1.FieldName = "Appointment"
        Me.colAppointment1.Name = "colAppointment1"
        Me.colAppointment1.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colAppointment1.Visible = True
        Me.colAppointment1.VisibleIndex = 0
        Me.colAppointment1.Width = 116
        '
        'colPrice1
        '
        Me.colPrice1.Caption = "Cena"
        Me.colPrice1.DisplayFormat.FormatString = "n2"
        Me.colPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrice1.FieldName = "Price"
        Me.colPrice1.Name = "colPrice1"
        Me.colPrice1.Visible = True
        Me.colPrice1.VisibleIndex = 1
        Me.colPrice1.Width = 57
        '
        'colService
        '
        Me.colService.Caption = "Pakalpojums"
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.OptionsColumn.ReadOnly = True
        Me.colService.Visible = True
        Me.colService.VisibleIndex = 2
        Me.colService.Width = 334
        '
        'colVisit1
        '
        Me.colVisit1.Caption = "Saistītā vizīte"
        Me.colVisit1.ColumnEdit = Me.txtVisit
        Me.colVisit1.FieldName = "VisitForDisplay"
        Me.colVisit1.Name = "colVisit1"
        Me.colVisit1.Visible = True
        Me.colVisit1.VisibleIndex = 3
        Me.colVisit1.Width = 439
        '
        'txtVisit
        '
        Me.txtVisit.AutoHeight = False
        Me.txtVisit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtVisit.Name = "txtVisit"
        Me.txtVisit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 369)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(992, 28)
        Me.SplitContainer1.SplitterDistance = 494
        Me.SplitContainer1.TabIndex = 5
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(494, 28)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBay)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSetPayTime)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(494, 28)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(416, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(335, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBay
        '
        Me.btnBay.Location = New System.Drawing.Point(254, 3)
        Me.btnBay.Name = "btnBay"
        Me.btnBay.Size = New System.Drawing.Size(75, 23)
        Me.btnBay.TabIndex = 3
        Me.btnBay.Text = "Pirkt"
        Me.btnBay.UseVisualStyleBackColor = True
        '
        'btnSetPayTime
        '
        Me.btnSetPayTime.AutoSize = True
        Me.btnSetPayTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSetPayTime.Location = New System.Drawing.Point(119, 3)
        Me.btnSetPayTime.Name = "btnSetPayTime"
        Me.btnSetPayTime.Size = New System.Drawing.Size(129, 23)
        Me.btnSetPayTime.TabIndex = 4
        Me.btnSetPayTime.Text = "Uzstādīt pirkšanas laiku"
        Me.btnSetPayTime.UseVisualStyleBackColor = True
        '
        'colSource
        '
        Me.colSource.Caption = "Source"
        Me.colSource.FieldName = "Source"
        Me.colSource.Name = "colSource"
        Me.colSource.Visible = True
        Me.colSource.VisibleIndex = 0
        '
        'colVersion
        '
        Me.colVersion.Caption = "Version"
        Me.colVersion.FieldName = "Version"
        Me.colVersion.Name = "colVersion"
        Me.colVersion.Visible = True
        Me.colVersion.VisibleIndex = 0
        '
        'colUpdateTime
        '
        Me.colUpdateTime.Caption = "UpdateTime"
        Me.colUpdateTime.FieldName = "UpdateTime"
        Me.colUpdateTime.Name = "colUpdateTime"
        Me.colUpdateTime.OptionsColumn.ReadOnly = True
        Me.colUpdateTime.Visible = True
        Me.colUpdateTime.VisibleIndex = 0
        '
        'colIsDirty
        '
        Me.colIsDirty.Caption = "IsDirty"
        Me.colIsDirty.FieldName = "IsDirty"
        Me.colIsDirty.Name = "colIsDirty"
        Me.colIsDirty.Visible = True
        Me.colIsDirty.VisibleIndex = 0
        '
        'colCanEdit
        '
        Me.colCanEdit.Caption = "CanEdit"
        Me.colCanEdit.FieldName = "CanEdit"
        Me.colCanEdit.Name = "colCanEdit"
        Me.colCanEdit.OptionsColumn.ReadOnly = True
        Me.colCanEdit.Visible = True
        Me.colCanEdit.VisibleIndex = 0
        '
        'colCanDelete
        '
        Me.colCanDelete.Caption = "CanDelete"
        Me.colCanDelete.FieldName = "CanDelete"
        Me.colCanDelete.Name = "colCanDelete"
        Me.colCanDelete.OptionsColumn.ReadOnly = True
        Me.colCanDelete.Visible = True
        Me.colCanDelete.VisibleIndex = 0
        '
        'colCanSave
        '
        Me.colCanSave.Caption = "CanSave"
        Me.colCanSave.FieldName = "CanSave"
        Me.colCanSave.Name = "colCanSave"
        Me.colCanSave.OptionsColumn.ReadOnly = True
        Me.colCanSave.Visible = True
        Me.colCanSave.VisibleIndex = 0
        '
        'colCanSee
        '
        Me.colCanSee.Caption = "CanSee"
        Me.colCanSee.FieldName = "CanSee"
        Me.colCanSee.Name = "colCanSee"
        Me.colCanSee.OptionsColumn.ReadOnly = True
        Me.colCanSee.Visible = True
        Me.colCanSee.VisibleIndex = 0
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        Me.colIsActive.Visible = True
        Me.colIsActive.VisibleIndex = 0
        '
        'colDeleteNotes
        '
        Me.colDeleteNotes.Caption = "DeleteNotes"
        Me.colDeleteNotes.FieldName = "DeleteNotes"
        Me.colDeleteNotes.Name = "colDeleteNotes"
        Me.colDeleteNotes.Visible = True
        Me.colDeleteNotes.VisibleIndex = 0
        '
        'colDeleteTime
        '
        Me.colDeleteTime.Caption = "DeleteTime"
        Me.colDeleteTime.FieldName = "DeleteTime"
        Me.colDeleteTime.Name = "colDeleteTime"
        Me.colDeleteTime.OptionsColumn.ReadOnly = True
        Me.colDeleteTime.Visible = True
        Me.colDeleteTime.VisibleIndex = 0
        '
        'colSelected
        '
        Me.colSelected.Caption = "Selected"
        Me.colSelected.FieldName = "Selected"
        Me.colSelected.Name = "colSelected"
        Me.colSelected.Visible = True
        Me.colSelected.VisibleIndex = 0
        '
        'colId
        '
        Me.colId.Caption = "Id"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colObject
        '
        Me.colObject.Caption = "Object"
        Me.colObject.FieldName = "Object"
        Me.colObject.Name = "colObject"
        Me.colObject.OptionsColumn.ReadOnly = True
        Me.colObject.Visible = True
        Me.colObject.VisibleIndex = 0
        '
        'colIsValid
        '
        Me.colIsValid.Caption = "IsValid"
        Me.colIsValid.FieldName = "IsValid"
        Me.colIsValid.Name = "colIsValid"
        Me.colIsValid.OptionsColumn.ReadOnly = True
        Me.colIsValid.Visible = True
        Me.colIsValid.VisibleIndex = 0
        '
        'colVisit
        '
        Me.colVisit.Caption = "Visit"
        Me.colVisit.FieldName = "Visit"
        Me.colVisit.Name = "colVisit"
        Me.colVisit.Visible = True
        Me.colVisit.VisibleIndex = 0
        '
        'colPrice
        '
        Me.colPrice.Caption = "Price"
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 0
        '
        'colAppointment
        '
        Me.colAppointment.Caption = "Appointment"
        Me.colAppointment.FieldName = "Appointment"
        Me.colAppointment.Name = "colAppointment"
        Me.colAppointment.Visible = True
        Me.colAppointment.VisibleIndex = 0
        '
        'colParent
        '
        Me.colParent.Caption = "Parent"
        Me.colParent.FieldName = "Parent"
        Me.colParent.Name = "colParent"
        Me.colParent.Visible = True
        Me.colParent.VisibleIndex = 0
        '
        'colSubscription
        '
        Me.colSubscription.Caption = "Subscription"
        Me.colSubscription.FieldName = "Subscription"
        Me.colSubscription.Name = "colSubscription"
        Me.colSubscription.Visible = True
        Me.colSubscription.VisibleIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndSubscription
        '
        'frmSubscriptionDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 397)
        Me.Controls.Add(Me.grdDetails)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimumSize = New System.Drawing.Size(1000, 375)
        Me.Name = "frmSubscriptionDetail"
        Me.Text = "Abonementa detaļas"
        CType(Me.txtPatient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndSubscription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVisit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPatient As Client.ClassifierPicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPayDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grdDetails As Core.UI.CoreGrid
    Friend WithEvents gvwDetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents bndSubscription As System.Windows.Forms.BindingSource
    Friend WithEvents bndDetails As System.Windows.Forms.BindingSource
    Friend WithEvents colAppointment1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVisit1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSource As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVersion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDirty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCanEdit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCanDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCanSave As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCanSee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleteNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleteTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsValid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVisit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAppointment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubscription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtService As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents btnBay As System.Windows.Forms.Button
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtVisit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnSetPayTime As System.Windows.Forms.Button
    Friend WithEvents cmbPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
