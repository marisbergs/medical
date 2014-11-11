<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientProgrammEdit
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.bndPatientProgramm = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClassifierPicker1 = New Client.ClassifierPicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New DevExpress.XtraEditors.SpinEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsedStatus = New Core.UI.ListPicker()
        Me.txtPaymentStatus = New Core.UI.ListPicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkProgrammIsLocked = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkNeedChecks = New System.Windows.Forms.CheckBox()
        Me.btnProgramma = New DevExpress.XtraEditors.ButtonEdit()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdPaymentService = New Core.UI.CoreGrid()
        Me.bndPatientProgrammPayment = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwPayments = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gbhPaymentService = New Core.UI.GridButtonHelper()
        Me.btnOpenPaymentdetails = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdServices = New Core.UI.CoreGrid()
        Me.bndPatientProgrammServices = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwServices = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountUsed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gbhServices = New Core.UI.GridButtonHelper()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.bndPatientProgramm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassifierPicker1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsedStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaymentStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnProgramma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdPaymentService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndPatientProgrammPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbhPaymentService.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndPatientProgrammServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 498)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(992, 29)
        Me.SplitContainer1.SplitterDistance = 501
        Me.SplitContainer1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(501, 29)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(487, 29)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(409, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(328, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'bndPatientProgramm
        '
        Me.bndPatientProgramm.DataSource = GetType(Entities.PatientProgramm)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Klients:"
        '
        'ClassifierPicker1
        '
        Me.ClassifierPicker1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProgramm, "Patient", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ClassifierPicker1.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndPatientProgramm, "CanChangePatient", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ClassifierPicker1.Location = New System.Drawing.Point(107, 10)
        Me.ClassifierPicker1.Name = "ClassifierPicker1"
        Me.ClassifierPicker1.PickerPresets = Nothing
        Me.ClassifierPicker1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ClassifierPicker1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ClassifierPicker1.Size = New System.Drawing.Size(349, 20)
        Me.ClassifierPicker1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Programma:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Programmas cena:"
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProgramm, "Price", True))
        Me.txtPrice.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrice.Location = New System.Drawing.Point(107, 36)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPrice.Properties.DisplayFormat.FormatString = "n2"
        Me.txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrice.Properties.EditFormat.FormatString = "n2"
        Me.txtPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrice.Size = New System.Drawing.Size(89, 20)
        Me.txtPrice.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(202, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Izlietojuma statuss:"
        '
        'txtUsedStatus
        '
        Me.txtUsedStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProgramm, "UsageStatus", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtUsedStatus.Enabled = False
        Me.txtUsedStatus.Location = New System.Drawing.Point(303, 36)
        Me.txtUsedStatus.Name = "txtUsedStatus"
        Me.txtUsedStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtUsedStatus.Properties.PopupFormWidth = 189
        Me.txtUsedStatus.Properties.PopupSizeable = False
        Me.txtUsedStatus.Properties.ShowPopupCloseButton = False
        Me.txtUsedStatus.Size = New System.Drawing.Size(189, 20)
        Me.txtUsedStatus.TabIndex = 8
        '
        'txtPaymentStatus
        '
        Me.txtPaymentStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProgramm, "PaymentStatus", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPaymentStatus.Enabled = False
        Me.txtPaymentStatus.Location = New System.Drawing.Point(599, 36)
        Me.txtPaymentStatus.Name = "txtPaymentStatus"
        Me.txtPaymentStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtPaymentStatus.Properties.PopupFormWidth = 256
        Me.txtPaymentStatus.Properties.PopupSizeable = False
        Me.txtPaymentStatus.Properties.ShowPopupCloseButton = False
        Me.txtPaymentStatus.Size = New System.Drawing.Size(256, 20)
        Me.txtPaymentStatus.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(498, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Apmaksas statuss:"
        '
        'chkProgrammIsLocked
        '
        Me.chkProgrammIsLocked.AutoSize = True
        Me.chkProgrammIsLocked.Location = New System.Drawing.Point(861, 38)
        Me.chkProgrammIsLocked.Name = "chkProgrammIsLocked"
        Me.chkProgrammIsLocked.Size = New System.Drawing.Size(110, 17)
        Me.chkProgrammIsLocked.TabIndex = 11
        Me.chkProgrammIsLocked.Text = "Programma slēgta"
        Me.chkProgrammIsLocked.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkNeedChecks)
        Me.Panel1.Controls.Add(Me.btnProgramma)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.chkProgrammIsLocked)
        Me.Panel1.Controls.Add(Me.ClassifierPicker1)
        Me.Panel1.Controls.Add(Me.txtPaymentStatus)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtUsedStatus)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 86)
        Me.Panel1.TabIndex = 12
        '
        'chkNeedChecks
        '
        Me.chkNeedChecks.AutoSize = True
        Me.chkNeedChecks.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bndPatientProgramm, "NeedBillPrint", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkNeedChecks.Location = New System.Drawing.Point(13, 63)
        Me.chkNeedChecks.Name = "chkNeedChecks"
        Me.chkNeedChecks.Size = New System.Drawing.Size(186, 17)
        Me.chkNeedChecks.TabIndex = 13
        Me.chkNeedChecks.Text = "Nepieciešami čeki apdrošināšanai"
        Me.chkNeedChecks.UseVisualStyleBackColor = True
        '
        'btnProgramma
        '
        Me.btnProgramma.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndPatientProgramm, "ProgrammTemplate", True))
        Me.btnProgramma.Location = New System.Drawing.Point(531, 10)
        Me.btnProgramma.Name = "btnProgramma"
        Me.btnProgramma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnProgramma.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.btnProgramma.Size = New System.Drawing.Size(449, 20)
        Me.btnProgramma.TabIndex = 12
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 86)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(992, 412)
        Me.SplitContainer2.SplitterDistance = 155
        Me.SplitContainer2.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdPaymentService)
        Me.GroupBox1.Controls.Add(Me.gbhPaymentService)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Apmaksa"
        '
        'grdPaymentService
        '
        Me.grdPaymentService.DataSource = Me.bndPatientProgrammPayment
        Me.grdPaymentService.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdPaymentService.EmbeddedNavigator.Name = ""
        Me.grdPaymentService.EnforceCanEdit = False
        Me.grdPaymentService.Location = New System.Drawing.Point(3, 45)
        Me.grdPaymentService.MainView = Me.gvwPayments
        Me.grdPaymentService.Name = "grdPaymentService"
        Me.grdPaymentService.ShowOnlyActive = False
        Me.grdPaymentService.Size = New System.Drawing.Size(986, 107)
        Me.grdPaymentService.TabIndex = 1
        Me.grdPaymentService.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPayments})
        '
        'bndPatientProgrammPayment
        '
        Me.bndPatientProgrammPayment.DataSource = GetType(Entities.PatientProgrammPayment)
        '
        'gvwPayments
        '
        Me.gvwPayments.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrice1, Me.colPaymentDate, Me.colPaymentUser, Me.colNotes})
        Me.gvwPayments.GridControl = Me.grdPaymentService
        Me.gvwPayments.Name = "gvwPayments"
        Me.gvwPayments.OptionsBehavior.Editable = False
        Me.gvwPayments.OptionsView.ColumnAutoWidth = False
        Me.gvwPayments.OptionsView.ShowDetailButtons = False
        Me.gvwPayments.OptionsView.ShowFilterPanel = False
        Me.gvwPayments.OptionsView.ShowFooter = True
        Me.gvwPayments.OptionsView.ShowGroupPanel = False
        '
        'colPrice1
        '
        Me.colPrice1.Caption = "Apmaksāts"
        Me.colPrice1.FieldName = "PaydTotal"
        Me.colPrice1.Name = "colPrice1"
        Me.colPrice1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colPrice1.Visible = True
        Me.colPrice1.VisibleIndex = 0
        '
        'colPaymentDate
        '
        Me.colPaymentDate.Caption = "Apmaksas datums"
        Me.colPaymentDate.FieldName = "PaymentDate"
        Me.colPaymentDate.Name = "colPaymentDate"
        Me.colPaymentDate.Visible = True
        Me.colPaymentDate.VisibleIndex = 1
        Me.colPaymentDate.Width = 129
        '
        'colPaymentUser
        '
        Me.colPaymentUser.Caption = "Apmaksu pieņēma"
        Me.colPaymentUser.FieldName = "PaymentUser"
        Me.colPaymentUser.Name = "colPaymentUser"
        Me.colPaymentUser.Visible = True
        Me.colPaymentUser.VisibleIndex = 2
        Me.colPaymentUser.Width = 146
        '
        'colNotes
        '
        Me.colNotes.Caption = "Piezīmes"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 3
        Me.colNotes.Width = 593
        '
        'gbhPaymentService
        '
        Me.gbhPaymentService.AutoSize = True
        Me.gbhPaymentService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhPaymentService.Controls.Add(Me.btnOpenPaymentdetails)
        Me.gbhPaymentService.DeleteReason = False
        Me.gbhPaymentService.DeleteReasonColumn = Nothing
        Me.gbhPaymentService.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhPaymentService.Grid = Me.grdPaymentService
        Me.gbhPaymentService.GridDataSource = Me.bndPatientProgrammPayment
        Me.gbhPaymentService.Location = New System.Drawing.Point(3, 16)
        Me.gbhPaymentService.Name = "gbhPaymentService"
        Me.gbhPaymentService.ShowActive = False
        Me.gbhPaymentService.ShowAdd = True
        Me.gbhPaymentService.ShowChk = True
        Me.gbhPaymentService.ShowDelete = True
        Me.gbhPaymentService.Size = New System.Drawing.Size(986, 29)
        Me.gbhPaymentService.TabIndex = 0
        Me.gbhPaymentService.UseCanDelete = True
        '
        'btnOpenPaymentdetails
        '
        Me.btnOpenPaymentdetails.Location = New System.Drawing.Point(260, 3)
        Me.btnOpenPaymentdetails.Name = "btnOpenPaymentdetails"
        Me.btnOpenPaymentdetails.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenPaymentdetails.TabIndex = 4
        Me.btnOpenPaymentdetails.Text = "Atvērt"
        Me.btnOpenPaymentdetails.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdServices)
        Me.GroupBox2.Controls.Add(Me.gbhServices)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(992, 253)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pakalpojumi"
        '
        'grdServices
        '
        Me.grdServices.DataSource = Me.bndPatientProgrammServices
        Me.grdServices.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdServices.EmbeddedNavigator.Name = ""
        Me.grdServices.EnforceCanEdit = False
        Me.grdServices.Location = New System.Drawing.Point(3, 45)
        Me.grdServices.MainView = Me.gvwServices
        Me.grdServices.Name = "grdServices"
        Me.grdServices.ShowOnlyActive = False
        Me.grdServices.Size = New System.Drawing.Size(986, 205)
        Me.grdServices.TabIndex = 2
        Me.grdServices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwServices})
        '
        'bndPatientProgrammServices
        '
        Me.bndPatientProgrammServices.DataSource = GetType(Entities.PatientProgrammService)
        '
        'gvwServices
        '
        Me.gvwServices.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colService, Me.colPrice, Me.colCount, Me.colCountUsed})
        Me.gvwServices.GridControl = Me.grdServices
        Me.gvwServices.Name = "gvwServices"
        Me.gvwServices.OptionsView.ColumnAutoWidth = False
        Me.gvwServices.OptionsView.ShowDetailButtons = False
        Me.gvwServices.OptionsView.ShowFilterPanel = False
        Me.gvwServices.OptionsView.ShowGroupPanel = False
        '
        'colService
        '
        Me.colService.Caption = "Pakalpojums"
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.OptionsColumn.AllowEdit = False
        Me.colService.OptionsColumn.ReadOnly = True
        Me.colService.Visible = True
        Me.colService.VisibleIndex = 0
        Me.colService.Width = 554
        '
        'colPrice
        '
        Me.colPrice.Caption = "Cena"
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 1
        '
        'colCount
        '
        Me.colCount.Caption = "Pakalpojumu skaits"
        Me.colCount.FieldName = "Count"
        Me.colCount.Name = "colCount"
        Me.colCount.Visible = True
        Me.colCount.VisibleIndex = 2
        Me.colCount.Width = 112
        '
        'colCountUsed
        '
        Me.colCountUsed.Caption = "Izmantoto pakalpojumu skaits"
        Me.colCountUsed.FieldName = "CountUsed"
        Me.colCountUsed.Name = "colCountUsed"
        Me.colCountUsed.OptionsColumn.AllowEdit = False
        Me.colCountUsed.OptionsColumn.ReadOnly = True
        Me.colCountUsed.Visible = True
        Me.colCountUsed.VisibleIndex = 3
        Me.colCountUsed.Width = 164
        '
        'gbhServices
        '
        Me.gbhServices.AutoSize = True
        Me.gbhServices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhServices.DeleteReason = False
        Me.gbhServices.DeleteReasonColumn = Nothing
        Me.gbhServices.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhServices.Grid = Me.grdServices
        Me.gbhServices.GridDataSource = Me.bndPatientProgrammServices
        Me.gbhServices.Location = New System.Drawing.Point(3, 16)
        Me.gbhServices.Name = "gbhServices"
        Me.gbhServices.ShowActive = False
        Me.gbhServices.ShowAdd = True
        Me.gbhServices.ShowChk = True
        Me.gbhServices.ShowDelete = True
        Me.gbhServices.Size = New System.Drawing.Size(986, 29)
        Me.gbhServices.TabIndex = 1
        Me.gbhServices.UseCanDelete = True
        '
        'frmPatientProgrammEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 527)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimumSize = New System.Drawing.Size(1000, 500)
        Me.Name = "frmPatientProgrammEdit"
        Me.Text = "Programma"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.bndPatientProgramm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassifierPicker1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsedStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaymentStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnProgramma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdPaymentService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndPatientProgrammPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbhPaymentService.ResumeLayout(False)
        Me.gbhPaymentService.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndPatientProgrammServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndPatientProgramm As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClassifierPicker1 As Client.ClassifierPicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsedStatus As Core.UI.ListPicker
    Friend WithEvents txtPaymentStatus As Core.UI.ListPicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkProgrammIsLocked As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbhPaymentService As Core.UI.GridButtonHelper
    Friend WithEvents gbhServices As Core.UI.GridButtonHelper
    Friend WithEvents grdPaymentService As Core.UI.CoreGrid
    Friend WithEvents gvwPayments As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdServices As Core.UI.CoreGrid
    Friend WithEvents gvwServices As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnProgramma As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents bndPatientProgrammServices As System.Windows.Forms.BindingSource
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountUsed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bndPatientProgrammPayment As System.Windows.Forms.BindingSource
    Friend WithEvents colPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnOpenPaymentdetails As System.Windows.Forms.Button
    Friend WithEvents chkNeedChecks As System.Windows.Forms.CheckBox

End Class
