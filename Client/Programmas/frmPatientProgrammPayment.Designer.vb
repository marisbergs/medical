<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientProgrammPayment
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
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnSetPayTime = New System.Windows.Forms.Button()
        Me.bndPatientProgramm = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New DevExpress.XtraEditors.SpinEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbPaymentType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.bndPatientProgrammPayment = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdPaymentService = New Core.UI.CoreGrid()
        Me.bndPatientProgrammPaymentServices = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwPayments = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gbhPaymentService = New Core.UI.GridButtonHelper()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.bndPatientProgramm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.bndPatientProgrammPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdPaymentService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndPatientProgrammPaymentServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 321)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(860, 29)
        Me.SplitContainer1.SplitterDistance = 434
        Me.SplitContainer1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(434, 29)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnPayment)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSetPayTime)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(422, 29)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(344, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(263, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(182, 3)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(75, 23)
        Me.btnPayment.TabIndex = 2
        Me.btnPayment.Text = "Apmaksa"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnSetPayTime
        '
        Me.btnSetPayTime.AutoSize = True
        Me.btnSetPayTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSetPayTime.Location = New System.Drawing.Point(47, 3)
        Me.btnSetPayTime.Name = "btnSetPayTime"
        Me.btnSetPayTime.Size = New System.Drawing.Size(129, 23)
        Me.btnSetPayTime.TabIndex = 5
        Me.btnSetPayTime.Text = "Uzstādīt pirkšanas laiku"
        Me.btnSetPayTime.UseVisualStyleBackColor = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 13)
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
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(107, 36)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPrice.Properties.DisplayFormat.FormatString = "n2"
        Me.txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrice.Properties.EditFormat.FormatString = "n2"
        Me.txtPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrice.Properties.ReadOnly = True
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(498, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Apmaksas statuss:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbPaymentType)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 133)
        Me.Panel1.TabIndex = 12
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.FormattingEnabled = True
        Me.cmbPaymentType.Location = New System.Drawing.Point(330, 62)
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.Size = New System.Drawing.Size(160, 21)
        Me.cmbPaymentType.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(242, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Apmaksu veids:"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndPatientProgramm, "PaymentStatus", True))
        Me.TextBox7.Location = New System.Drawing.Point(599, 36)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(256, 20)
        Me.TextBox7.TabIndex = 20
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndPatientProgramm, "UsageStatus", True))
        Me.TextBox6.Location = New System.Drawing.Point(303, 36)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(189, 20)
        Me.TextBox6.TabIndex = 19
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndPatientProgrammPayment, "Notes", True))
        Me.TextBox5.Location = New System.Drawing.Point(107, 88)
        Me.TextBox5.MaxLength = 1000
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox5.Size = New System.Drawing.Size(748, 39)
        Me.TextBox5.TabIndex = 18
        '
        'bndPatientProgrammPayment
        '
        Me.bndPatientProgrammPayment.DataSource = GetType(Entities.PatientProgrammPayment)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Piezīmes:"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndPatientProgrammPayment, "PaymentUser", True))
        Me.TextBox4.Location = New System.Drawing.Point(599, 62)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(256, 20)
        Me.TextBox4.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(496, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Apmaksu pieņēma:"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndPatientProgrammPayment, "PaymentDate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Location = New System.Drawing.Point(107, 62)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(129, 20)
        Me.TextBox3.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Apmaksas datums:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndPatientProgramm, "Patient", True))
        Me.TextBox2.Location = New System.Drawing.Point(50, 10)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(244, 20)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndPatientProgramm, "ProgrammTemplate", True))
        Me.TextBox1.Location = New System.Drawing.Point(370, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(485, 20)
        Me.TextBox1.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdPaymentService)
        Me.GroupBox1.Controls.Add(Me.gbhPaymentService)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 188)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Apmaksa"
        '
        'grdPaymentService
        '
        Me.grdPaymentService.DataSource = Me.bndPatientProgrammPaymentServices
        Me.grdPaymentService.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdPaymentService.EmbeddedNavigator.Name = ""
        Me.grdPaymentService.EnforceCanEdit = False
        Me.grdPaymentService.Location = New System.Drawing.Point(3, 45)
        Me.grdPaymentService.MainView = Me.gvwPayments
        Me.grdPaymentService.Name = "grdPaymentService"
        Me.grdPaymentService.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1})
        Me.grdPaymentService.ShowOnlyActive = False
        Me.grdPaymentService.Size = New System.Drawing.Size(854, 140)
        Me.grdPaymentService.TabIndex = 1
        Me.grdPaymentService.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPayments})
        '
        'bndPatientProgrammPaymentServices
        '
        Me.bndPatientProgrammPaymentServices.DataSource = GetType(Entities.PatientProgrammPaymentService)
        '
        'gvwPayments
        '
        Me.gvwPayments.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colService, Me.colPrice})
        Me.gvwPayments.GridControl = Me.grdPaymentService
        Me.gvwPayments.Name = "gvwPayments"
        Me.gvwPayments.OptionsView.ColumnAutoWidth = False
        Me.gvwPayments.OptionsView.ShowDetailButtons = False
        Me.gvwPayments.OptionsView.ShowFilterPanel = False
        Me.gvwPayments.OptionsView.ShowFooter = True
        Me.gvwPayments.OptionsView.ShowGroupPanel = False
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
        Me.colService.Width = 435
        '
        'colPrice
        '
        Me.colPrice.Caption = "Cena"
        Me.colPrice.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colPrice.DisplayFormat.FormatString = "n2"
        Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 1
        Me.colPrice.Width = 99
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'gbhPaymentService
        '
        Me.gbhPaymentService.AutoSize = True
        Me.gbhPaymentService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhPaymentService.DeleteReason = False
        Me.gbhPaymentService.DeleteReasonColumn = Nothing
        Me.gbhPaymentService.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhPaymentService.Grid = Me.grdPaymentService
        Me.gbhPaymentService.GridDataSource = Me.bndPatientProgrammPaymentServices
        Me.gbhPaymentService.Location = New System.Drawing.Point(3, 16)
        Me.gbhPaymentService.Name = "gbhPaymentService"
        Me.gbhPaymentService.ShowActive = False
        Me.gbhPaymentService.ShowAdd = True
        Me.gbhPaymentService.ShowChk = True
        Me.gbhPaymentService.ShowDelete = True
        Me.gbhPaymentService.Size = New System.Drawing.Size(854, 29)
        Me.gbhPaymentService.TabIndex = 0
        Me.gbhPaymentService.UseCanDelete = True
        '
        'frmPatientProgrammPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(860, 350)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmPatientProgrammPayment"
        Me.Text = "Programmas apmaksa"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.bndPatientProgramm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bndPatientProgrammPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdPaymentService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndPatientProgrammPaymentServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndPatientProgramm As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbhPaymentService As Core.UI.GridButtonHelper
    Friend WithEvents grdPaymentService As Core.UI.CoreGrid
    Friend WithEvents gvwPayments As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bndPatientProgrammPayment As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents bndPatientProgrammPaymentServices As System.Windows.Forms.BindingSource
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents cmbPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSetPayTime As System.Windows.Forms.Button

End Class
