<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisitEdit
    Inherits Client.frmUIBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnOpenPatient = New System.Windows.Forms.Button()
        Me.btnState = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnGenerateInsurance = New System.Windows.Forms.Button()
        Me.btnNewWisit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNorikojumi = New System.Windows.Forms.Button()
        Me.TimeEdit2 = New Core.UI.TimeEdit()
        Me.bndData = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimeEdit1 = New Core.UI.TimeEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtDoctor = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtService = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStatuss = New System.Windows.Forms.TextBox()
        Me.cmsState = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtPatient = New DevExpress.XtraEditors.ButtonEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.chkProgramm = New System.Windows.Forms.CheckBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblCampaignSumm = New System.Windows.Forms.Label()
        Me.txtCampaignSumm = New System.Windows.Forms.TextBox()
        Me.lblCampaignName = New System.Windows.Forms.Label()
        Me.chkCampaign = New System.Windows.Forms.CheckBox()
        Me.txtRelatedDoctor = New Client.ClassifierPicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBonusPoints = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkPrepareCard = New System.Windows.Forms.CheckBox()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCreator = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbhVisitServices = New Core.UI.GridButtonHelper()
        Me.btnAddNewService = New System.Windows.Forms.Button()
        Me.btnAddNewVisit = New System.Windows.Forms.Button()
        Me.grdVisitServices = New Core.UI.CoreGrid()
        Me.VisitServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colService = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.txtServiceCol = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colGroupWork = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colDefaultPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDiscount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDefaultPriceWithOutPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDefaultPercentagePrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPriceWithOutPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPercentagePrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colInsurance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPresentCardNumber = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.txtPresentCard = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colPresentCardSum = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colBonusPoints = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand10 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPayd = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.chkPayd = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.BandedGridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.cmbPaymentType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colServiceGiven = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grdRelatedVisits = New Core.UI.CoreGrid()
        Me.bndRelatedVisits = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwRelatedVisits = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand11 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colRelatedCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn12 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.BandedGridColumn13 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn14 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn15 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand12 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn16 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDiscount1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn17 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn18 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand13 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn19 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn20 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn21 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand14 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn22 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand15 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn23 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemButtonEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.BandedGridColumn24 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand16 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn25 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand17 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn26 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.BandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.cmbPaymentTypeRelatedSevice = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colServiceGiven1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.cmsInsuranceTemplates = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDoctor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtRelatedDoctor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbhVisitServices.SuspendLayout()
        CType(Me.grdVisitServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServiceCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPresentCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPayd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdRelatedVisits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndRelatedVisits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwRelatedVisits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPaymentTypeRelatedSevice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(0, 566)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Klients:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(789, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ārsts:"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnCheck)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOpenPatient)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnState)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnPay)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnGenerateInsurance)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnNewWisit)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnNorikojumi)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 537)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1184, 29)
        Me.FlowLayoutPanel2.TabIndex = 121
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(1101, 3)
        Me.btnClose.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.Location = New System.Drawing.Point(1020, 3)
        Me.btnSave.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.AutoSize = True
        Me.btnCheck.Location = New System.Drawing.Point(939, 3)
        Me.btnCheck.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 6
        Me.btnCheck.Text = "Pārbaudīt"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnOpenPatient
        '
        Me.btnOpenPatient.AutoSize = True
        Me.btnOpenPatient.Location = New System.Drawing.Point(809, 3)
        Me.btnOpenPatient.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnOpenPatient.Name = "btnOpenPatient"
        Me.btnOpenPatient.Size = New System.Drawing.Size(124, 23)
        Me.btnOpenPatient.TabIndex = 7
        Me.btnOpenPatient.Text = "Atvērt klienta kartiņu"
        Me.btnOpenPatient.UseVisualStyleBackColor = True
        '
        'btnState
        '
        Me.btnState.AutoSize = True
        Me.btnState.Location = New System.Drawing.Point(728, 3)
        Me.btnState.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnState.Name = "btnState"
        Me.btnState.Size = New System.Drawing.Size(75, 23)
        Me.btnState.TabIndex = 8
        Me.btnState.Text = "Statuss"
        Me.btnState.UseVisualStyleBackColor = True
        Me.btnState.Visible = False
        '
        'btnPay
        '
        Me.btnPay.AutoSize = True
        Me.btnPay.Location = New System.Drawing.Point(647, 3)
        Me.btnPay.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 9
        Me.btnPay.Text = "Apmaksāt"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnGenerateInsurance
        '
        Me.btnGenerateInsurance.AutoSize = True
        Me.btnGenerateInsurance.Location = New System.Drawing.Point(461, 3)
        Me.btnGenerateInsurance.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnGenerateInsurance.Name = "btnGenerateInsurance"
        Me.btnGenerateInsurance.Size = New System.Drawing.Size(180, 23)
        Me.btnGenerateInsurance.TabIndex = 10
        Me.btnGenerateInsurance.Text = "Ģenerēt apdrošināšanas veidlapas"
        Me.btnGenerateInsurance.UseVisualStyleBackColor = True
        Me.btnGenerateInsurance.Visible = False
        '
        'btnNewWisit
        '
        Me.btnNewWisit.AutoSize = True
        Me.btnNewWisit.Location = New System.Drawing.Point(347, 3)
        Me.btnNewWisit.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnNewWisit.Name = "btnNewWisit"
        Me.btnNewWisit.Size = New System.Drawing.Size(108, 23)
        Me.btnNewWisit.TabIndex = 11
        Me.btnNewWisit.Text = "Ieplānot jaunu vizīti"
        Me.btnNewWisit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Location = New System.Drawing.Point(264, 3)
        Me.Button1.MinimumSize = New System.Drawing.Size(75, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 23)
        Me.Button1.TabIndex = 138
        Me.Button1.Text = "Atgādinājumi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNorikojumi
        '
        Me.btnNorikojumi.AutoSize = True
        Me.btnNorikojumi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNorikojumi.Location = New System.Drawing.Point(145, 3)
        Me.btnNorikojumi.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnNorikojumi.Name = "btnNorikojumi"
        Me.btnNorikojumi.Size = New System.Drawing.Size(113, 23)
        Me.btnNorikojumi.TabIndex = 139
        Me.btnNorikojumi.Text = "Norīkojumi/Rezultāti"
        Me.btnNorikojumi.UseVisualStyleBackColor = True
        '
        'TimeEdit2
        '
        Me.TimeEdit2.AutoSize = True
        Me.TimeEdit2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TimeEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndData, "EndTime", True))
        Me.TimeEdit2.EditValue = Nothing
        Me.TimeEdit2.Location = New System.Drawing.Point(166, 61)
        Me.TimeEdit2.Margin = New System.Windows.Forms.Padding(0)
        Me.TimeEdit2.Name = "TimeEdit2"
        Me.TimeEdit2.Size = New System.Drawing.Size(55, 20)
        Me.TimeEdit2.TabIndex = 125
        '
        'bndData
        '
        Me.bndData.DataSource = GetType(Entities.Visit)
        '
        'TimeEdit1
        '
        Me.TimeEdit1.AutoSize = True
        Me.TimeEdit1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TimeEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndData, "StartTime", True))
        Me.TimeEdit1.EditValue = Nothing
        Me.TimeEdit1.Location = New System.Drawing.Point(82, 61)
        Me.TimeEdit1.Margin = New System.Windows.Forms.Padding(0)
        Me.TimeEdit1.Name = "TimeEdit1"
        Me.TimeEdit1.Size = New System.Drawing.Size(55, 20)
        Me.TimeEdit1.TabIndex = 124
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Laiks no:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Līdz"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndData
        '
        'txtDoctor
        '
        Me.txtDoctor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDoctor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndData, "Doctor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtDoctor.Location = New System.Drawing.Point(902, 35)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.txtDoctor.Properties.ReadOnly = True
        Me.txtDoctor.Size = New System.Drawing.Size(274, 20)
        Me.txtDoctor.TabIndex = 126
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndData, "Notes", True))
        Me.txtNotes.Location = New System.Drawing.Point(82, 88)
        Me.txtNotes.MaxLength = 1000
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(584, 66)
        Me.txtNotes.TabIndex = 128
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Piezīmes:"
        '
        'txtService
        '
        Me.txtService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtService.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndData, "Serv", True))
        Me.txtService.Location = New System.Drawing.Point(82, 35)
        Me.txtService.Name = "txtService"
        Me.txtService.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtService.Properties.ReadOnly = True
        Me.txtService.Size = New System.Drawing.Size(701, 20)
        Me.txtService.TabIndex = 131
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Pakalpojums:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(424, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 132
        Me.Label7.Text = "Statuss:"
        '
        'txtStatuss
        '
        Me.txtStatuss.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndData, "Status", True))
        Me.txtStatuss.Location = New System.Drawing.Point(475, 62)
        Me.txtStatuss.Name = "txtStatuss"
        Me.txtStatuss.ReadOnly = True
        Me.txtStatuss.Size = New System.Drawing.Size(87, 20)
        Me.txtStatuss.TabIndex = 133
        '
        'cmsState
        '
        Me.cmsState.Name = "ContextMenuStrip1"
        Me.cmsState.ShowImageMargin = False
        Me.cmsState.Size = New System.Drawing.Size(36, 4)
        '
        'txtPatient
        '
        Me.txtPatient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPatient.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndData, "PatientList", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPatient.Location = New System.Drawing.Point(82, 9)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPatient.Size = New System.Drawing.Size(618, 20)
        Me.txtPatient.TabIndex = 127
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.TextBox10)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.TextBox9)
        Me.Panel1.Controls.Add(Me.chkProgramm)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.lblCampaignSumm)
        Me.Panel1.Controls.Add(Me.txtCampaignSumm)
        Me.Panel1.Controls.Add(Me.lblCampaignName)
        Me.Panel1.Controls.Add(Me.chkCampaign)
        Me.Panel1.Controls.Add(Me.txtRelatedDoctor)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtBonusPoints)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.chkPrepareCard)
        Me.Panel1.Controls.Add(Me.TextEdit1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtCreator)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtPatient)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtStatuss)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtService)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TimeEdit1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TimeEdit2)
        Me.Panel1.Controls.Add(Me.txtNotes)
        Me.Panel1.Controls.Add(Me.txtDoctor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 213)
        Me.Panel1.TabIndex = 134
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(706, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 167
        Me.Label18.Text = "Grupa:"
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndData, "PatientGroup", True))
        Me.TextBox10.Location = New System.Drawing.Point(749, 9)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(31, 20)
        Me.TextBox10.TabIndex = 166
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndData, "IsActiveSubscription", True))
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bndData, "SetPAK", True))
        Me.CheckBox2.Location = New System.Drawing.Point(12, 186)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox2.TabIndex = 165
        Me.CheckBox2.Text = "Abonements:"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.Location = New System.Drawing.Point(106, 184)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(560, 20)
        Me.TextBox9.TabIndex = 164
        '
        'chkProgramm
        '
        Me.chkProgramm.AutoSize = True
        Me.chkProgramm.Location = New System.Drawing.Point(12, 160)
        Me.chkProgramm.Name = "chkProgramm"
        Me.chkProgramm.Size = New System.Drawing.Size(82, 17)
        Me.chkProgramm.TabIndex = 163
        Me.chkProgramm.Text = "Programma:"
        Me.chkProgramm.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.Location = New System.Drawing.Point(106, 158)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(560, 20)
        Me.TextBox8.TabIndex = 162
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bndData, "SetPAK", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndData, "IsActivePAK", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(675, 186)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox1.TabIndex = 161
        Me.CheckBox1.Text = "PAK:"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndData, "ActivePAK", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox7.Location = New System.Drawing.Point(751, 184)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(425, 20)
        Me.TextBox7.TabIndex = 160
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndData, "CreateDate", True))
        Me.TextBox6.Location = New System.Drawing.Point(355, 62)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(67, 20)
        Me.TextBox6.TabIndex = 158
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(302, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 157
        Me.Label17.Text = "Izveidoja:"
        Me.ToolTipController1.SetToolTip(Me.Label17, "Vizītes izveidošanas datums")
        '
        'lblCampaignSumm
        '
        Me.lblCampaignSumm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCampaignSumm.AutoSize = True
        Me.lblCampaignSumm.Location = New System.Drawing.Point(1029, 87)
        Me.lblCampaignSumm.Name = "lblCampaignSumm"
        Me.lblCampaignSumm.Size = New System.Drawing.Size(89, 13)
        Me.lblCampaignSumm.TabIndex = 156
        Me.lblCampaignSumm.Text = "Pieejamā summa:"
        Me.lblCampaignSumm.Visible = False
        '
        'txtCampaignSumm
        '
        Me.txtCampaignSumm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCampaignSumm.Location = New System.Drawing.Point(1122, 84)
        Me.txtCampaignSumm.Name = "txtCampaignSumm"
        Me.txtCampaignSumm.ReadOnly = True
        Me.txtCampaignSumm.Size = New System.Drawing.Size(54, 20)
        Me.txtCampaignSumm.TabIndex = 155
        Me.txtCampaignSumm.Visible = False
        '
        'lblCampaignName
        '
        Me.lblCampaignName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCampaignName.AutoSize = True
        Me.lblCampaignName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblCampaignName.ForeColor = System.Drawing.Color.Red
        Me.lblCampaignName.Location = New System.Drawing.Point(902, 109)
        Me.lblCampaignName.Name = "lblCampaignName"
        Me.lblCampaignName.Size = New System.Drawing.Size(46, 13)
        Me.lblCampaignName.TabIndex = 154
        Me.lblCampaignName.Tag = "Akcija: {0}"
        Me.lblCampaignName.Text = "Akcija:"
        Me.lblCampaignName.Visible = False
        '
        'chkCampaign
        '
        Me.chkCampaign.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCampaign.AutoSize = True
        Me.chkCampaign.Location = New System.Drawing.Point(905, 87)
        Me.chkCampaign.Name = "chkCampaign"
        Me.chkCampaign.Size = New System.Drawing.Size(101, 17)
        Me.chkCampaign.TabIndex = 153
        Me.chkCampaign.Text = "Piesaistīt akcijai"
        Me.chkCampaign.UseVisualStyleBackColor = True
        Me.chkCampaign.Visible = False
        '
        'txtRelatedDoctor
        '
        Me.txtRelatedDoctor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRelatedDoctor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndData, "RelatedDoctor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtRelatedDoctor.Location = New System.Drawing.Point(902, 9)
        Me.txtRelatedDoctor.Name = "txtRelatedDoctor"
        Me.txtRelatedDoctor.PickerPresets = Nothing
        Me.txtRelatedDoctor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtRelatedDoctor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtRelatedDoctor.Size = New System.Drawing.Size(274, 20)
        Me.txtRelatedDoctor.TabIndex = 152
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(786, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 151
        Me.Label16.Text = "Piesaistītais ārsts:"
        Me.ToolTipController1.SetToolTip(Me.Label16, "Piesaistītais ārsts tiks izmantots algu aprēķinos. Piemēram ārsts veic analīžu re" & _
        "zultātu apstrādi ārpus klīnikas.")
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "CurrentInsuranceNumber", True))
        Me.TextBox5.Location = New System.Drawing.Point(977, 158)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(199, 20)
        Me.TextBox5.TabIndex = 150
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataSource = GetType(Entities.Patient)
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(902, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 149
        Me.Label15.Text = "Numurs:"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "CurrentInsuranceValid", True))
        Me.TextBox4.Location = New System.Drawing.Point(751, 158)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(145, 20)
        Me.TextBox4.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(672, 161)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "Spēkā:"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "CurrentInsuranceProgramm", True))
        Me.TextBox3.Location = New System.Drawing.Point(977, 132)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(199, 20)
        Me.TextBox3.TabIndex = 146
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(902, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 145
        Me.Label13.Text = "Programma:"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "CurrentInsurance", True))
        Me.TextBox2.Location = New System.Drawing.Point(751, 132)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(145, 20)
        Me.TextBox2.TabIndex = 144
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(672, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 143
        Me.Label12.Text = "Apdrošinātājs:"
        '
        'txtBonusPoints
        '
        Me.txtBonusPoints.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBonusPoints.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndData, "BonusPoints", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBonusPoints.Location = New System.Drawing.Point(800, 106)
        Me.txtBonusPoints.Name = "txtBonusPoints"
        Me.txtBonusPoints.ReadOnly = True
        Me.txtBonusPoints.Size = New System.Drawing.Size(96, 20)
        Me.txtBonusPoints.TabIndex = 142
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(672, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 13)
        Me.Label11.TabIndex = 141
        Me.Label11.Text = "Pieejamie bonusa punkti:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndData, "CreatePlace", True))
        Me.TextBox1.Location = New System.Drawing.Point(863, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(33, 20)
        Me.TextBox1.TabIndex = 140
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(786, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 139
        Me.Label10.Text = "Izveides vieta:"
        '
        'chkPrepareCard
        '
        Me.chkPrepareCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPrepareCard.AutoSize = True
        Me.chkPrepareCard.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bndData, "PrepareCard", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkPrepareCard.Location = New System.Drawing.Point(672, 85)
        Me.chkPrepareCard.Name = "chkPrepareCard"
        Me.chkPrepareCard.Size = New System.Drawing.Size(116, 17)
        Me.chkPrepareCard.TabIndex = 138
        Me.chkPrepareCard.Text = "Sagatavota kartiņa"
        Me.chkPrepareCard.UseVisualStyleBackColor = True
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndData, "Length", True))
        Me.TextEdit1.Location = New System.Drawing.Point(260, 62)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Mask.EditMask = "n0"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Size = New System.Drawing.Size(40, 20)
        Me.TextEdit1.TabIndex = 137
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(221, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "Ilgums:"
        '
        'txtCreator
        '
        Me.txtCreator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCreator.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndData, "Creator", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtCreator.Location = New System.Drawing.Point(628, 61)
        Me.txtCreator.Name = "txtCreator"
        Me.txtCreator.ReadOnly = True
        Me.txtCreator.Size = New System.Drawing.Size(548, 20)
        Me.txtCreator.TabIndex = 135
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(564, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "Pievienoja:"
        '
        'gbhVisitServices
        '
        Me.gbhVisitServices.AutoSize = True
        Me.gbhVisitServices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhVisitServices.Controls.Add(Me.btnAddNewService)
        Me.gbhVisitServices.Controls.Add(Me.btnAddNewVisit)
        Me.gbhVisitServices.DeleteReason = False
        Me.gbhVisitServices.DeleteReasonColumn = Nothing
        Me.gbhVisitServices.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhVisitServices.Grid = Me.grdVisitServices
        Me.gbhVisitServices.GridDataSource = Me.VisitServicesBindingSource
        Me.gbhVisitServices.Location = New System.Drawing.Point(0, 213)
        Me.gbhVisitServices.Name = "gbhVisitServices"
        Me.gbhVisitServices.ShowActive = False
        Me.gbhVisitServices.ShowAdd = True
        Me.gbhVisitServices.ShowChk = True
        Me.gbhVisitServices.ShowDelete = True
        Me.gbhVisitServices.Size = New System.Drawing.Size(1184, 29)
        Me.gbhVisitServices.TabIndex = 135
        Me.gbhVisitServices.UseCanDelete = True
        '
        'btnAddNewService
        '
        Me.btnAddNewService.AutoSize = True
        Me.btnAddNewService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddNewService.Location = New System.Drawing.Point(260, 3)
        Me.btnAddNewService.Name = "btnAddNewService"
        Me.btnAddNewService.Size = New System.Drawing.Size(144, 23)
        Me.btnAddNewService.TabIndex = 4
        Me.btnAddNewService.Text = "Pievienot citu pakalpojumu"
        Me.btnAddNewService.UseVisualStyleBackColor = True
        '
        'btnAddNewVisit
        '
        Me.btnAddNewVisit.AutoSize = True
        Me.btnAddNewVisit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddNewVisit.Location = New System.Drawing.Point(410, 3)
        Me.btnAddNewVisit.Name = "btnAddNewVisit"
        Me.btnAddNewVisit.Size = New System.Drawing.Size(148, 23)
        Me.btnAddNewVisit.TabIndex = 5
        Me.btnAddNewVisit.Text = "Pievienot vizīti pie cita ārsta"
        Me.btnAddNewVisit.UseVisualStyleBackColor = True
        '
        'grdVisitServices
        '
        Me.grdVisitServices.DataSource = Me.VisitServicesBindingSource
        Me.grdVisitServices.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdVisitServices.EmbeddedNavigator.Name = ""
        Me.grdVisitServices.EnforceCanEdit = False
        Me.grdVisitServices.Location = New System.Drawing.Point(0, 0)
        Me.grdVisitServices.MainView = Me.AdvBandedGridView1
        Me.grdVisitServices.Name = "grdVisitServices"
        Me.grdVisitServices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtServiceCol, Me.chkPayd, Me.txtPresentCard, Me.RepositoryItemCheckEdit1, Me.RepositoryItemImageEdit1, Me.cmbPaymentType})
        Me.grdVisitServices.ShowOnlyActive = False
        Me.grdVisitServices.Size = New System.Drawing.Size(1184, 146)
        Me.grdVisitServices.TabIndex = 136
        Me.grdVisitServices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1})
        '
        'VisitServicesBindingSource
        '
        Me.VisitServicesBindingSource.DataMember = "VisitServices"
        Me.VisitServicesBindingSource.DataSource = Me.bndData
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand3, Me.GridBand2, Me.GridBand7, Me.GridBand8, Me.GridBand9, Me.GridBand10})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCode, Me.colServiceGiven, Me.colService, Me.colGroupWork, Me.colDefaultPrice, Me.colDefaultPercentagePrice, Me.colDefaultPriceWithOutPercentage, Me.colPrice, Me.colPercentage, Me.colPriceWithOutPercentage, Me.colPercentagePrice, Me.colPayd, Me.GridColumn1, Me.colInsurance, Me.colPresentCardNumber, Me.colPresentCardSum, Me.colBonusPoints, Me.BandedGridColumn1, Me.BandedGridColumn3, Me.colDiscount, Me.BandedGridColumn5})
        Me.AdvBandedGridView1.GridControl = Me.grdVisitServices
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsView.ShowDetailButtons = False
        Me.AdvBandedGridView1.OptionsView.ShowFilterPanel = False
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = " "
        Me.GridBand1.Columns.Add(Me.colCode)
        Me.GridBand1.Columns.Add(Me.colService)
        Me.GridBand1.Columns.Add(Me.colGroupWork)
        Me.GridBand1.Columns.Add(Me.colPercentage)
        Me.GridBand1.Columns.Add(Me.GridColumn1)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 295
        '
        'colCode
        '
        Me.colCode.Caption = "Kods"
        Me.colCode.FieldName = "ServiceCode"
        Me.colCode.Name = "colCode"
        Me.colCode.OptionsColumn.AllowEdit = False
        Me.colCode.OptionsColumn.ReadOnly = True
        Me.colCode.Visible = True
        Me.colCode.Width = 46
        '
        'colService
        '
        Me.colService.Caption = "Pakalpojums"
        Me.colService.ColumnEdit = Me.txtServiceCol
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.Visible = True
        Me.colService.Width = 249
        '
        'txtServiceCol
        '
        Me.txtServiceCol.AutoHeight = False
        Me.txtServiceCol.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtServiceCol.Name = "txtServiceCol"
        Me.txtServiceCol.ReadOnly = True
        '
        'colGroupWork
        '
        Me.colGroupWork.Caption = "Grupas nodarbība"
        Me.colGroupWork.FieldName = "GroupWork"
        Me.colGroupWork.Name = "colGroupWork"
        Me.colGroupWork.OptionsColumn.ReadOnly = True
        '
        'colPercentage
        '
        Me.colPercentage.Caption = "Procentu likme"
        Me.colPercentage.FieldName = "Percentage"
        Me.colPercentage.Name = "colPercentage"
        Me.colPercentage.Width = 91
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "IsActive"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "Pakalpojuma"
        Me.GridBand3.Columns.Add(Me.colDefaultPrice)
        Me.GridBand3.Columns.Add(Me.colDiscount)
        Me.GridBand3.Columns.Add(Me.colDefaultPriceWithOutPercentage)
        Me.GridBand3.Columns.Add(Me.colDefaultPercentagePrice)
        Me.GridBand3.MinWidth = 20
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 112
        '
        'colDefaultPrice
        '
        Me.colDefaultPrice.Caption = "Cena"
        Me.colDefaultPrice.FieldName = "DefaultPrice"
        Me.colDefaultPrice.Name = "colDefaultPrice"
        Me.colDefaultPrice.Visible = True
        Me.colDefaultPrice.Width = 45
        '
        'colDiscount
        '
        Me.colDiscount.Caption = "Atlaide %"
        Me.colDiscount.FieldName = "Discount"
        Me.colDiscount.Name = "colDiscount"
        Me.colDiscount.Visible = True
        Me.colDiscount.Width = 67
        '
        'colDefaultPriceWithOutPercentage
        '
        Me.colDefaultPriceWithOutPercentage.Caption = "Bez PVN"
        Me.colDefaultPriceWithOutPercentage.FieldName = "DefaultPriceWithOutPercentage"
        Me.colDefaultPriceWithOutPercentage.Name = "colDefaultPriceWithOutPercentage"
        '
        'colDefaultPercentagePrice
        '
        Me.colDefaultPercentagePrice.Caption = "PVN"
        Me.colDefaultPercentagePrice.FieldName = "DefaultPercentagePrice"
        Me.colDefaultPercentagePrice.Name = "colDefaultPercentagePrice"
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "Apmaksai"
        Me.GridBand2.Columns.Add(Me.colPrice)
        Me.GridBand2.Columns.Add(Me.colPriceWithOutPercentage)
        Me.GridBand2.Columns.Add(Me.colPercentagePrice)
        Me.GridBand2.MinWidth = 20
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 64
        '
        'colPrice
        '
        Me.colPrice.Caption = "Summa"
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.Width = 64
        '
        'colPriceWithOutPercentage
        '
        Me.colPriceWithOutPercentage.Caption = "Bez PVN"
        Me.colPriceWithOutPercentage.FieldName = "PriceWithOutPercentage"
        Me.colPriceWithOutPercentage.Name = "colPriceWithOutPercentage"
        Me.colPriceWithOutPercentage.Width = 62
        '
        'colPercentagePrice
        '
        Me.colPercentagePrice.Caption = "PVN"
        Me.colPercentagePrice.FieldName = "PercentagePrice"
        Me.colPercentagePrice.Name = "colPercentagePrice"
        Me.colPercentagePrice.Width = 39
        '
        'GridBand7
        '
        Me.GridBand7.Caption = "Apdrošināšana"
        Me.GridBand7.Columns.Add(Me.colInsurance)
        Me.GridBand7.MinWidth = 20
        Me.GridBand7.Name = "GridBand7"
        Me.GridBand7.Width = 81
        '
        'colInsurance
        '
        Me.colInsurance.Caption = "Summa"
        Me.colInsurance.FieldName = "Insurance"
        Me.colInsurance.Name = "colInsurance"
        Me.colInsurance.Visible = True
        Me.colInsurance.Width = 81
        '
        'GridBand8
        '
        Me.GridBand8.Caption = "Dāvanu karte"
        Me.GridBand8.Columns.Add(Me.colPresentCardNumber)
        Me.GridBand8.Columns.Add(Me.colPresentCardSum)
        Me.GridBand8.MinWidth = 20
        Me.GridBand8.Name = "GridBand8"
        Me.GridBand8.Width = 108
        '
        'colPresentCardNumber
        '
        Me.colPresentCardNumber.Caption = "Numurs"
        Me.colPresentCardNumber.ColumnEdit = Me.txtPresentCard
        Me.colPresentCardNumber.FieldName = "PresentCardNumber"
        Me.colPresentCardNumber.Name = "colPresentCardNumber"
        Me.colPresentCardNumber.Visible = True
        Me.colPresentCardNumber.Width = 55
        '
        'txtPresentCard
        '
        Me.txtPresentCard.AutoHeight = False
        Me.txtPresentCard.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPresentCard.Name = "txtPresentCard"
        Me.txtPresentCard.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colPresentCardSum
        '
        Me.colPresentCardSum.Caption = "Summa"
        Me.colPresentCardSum.FieldName = "PresentCardSum"
        Me.colPresentCardSum.Name = "colPresentCardSum"
        Me.colPresentCardSum.Visible = True
        Me.colPresentCardSum.Width = 53
        '
        'GridBand9
        '
        Me.GridBand9.Caption = "Bonusa punkti"
        Me.GridBand9.Columns.Add(Me.colBonusPoints)
        Me.GridBand9.MinWidth = 20
        Me.GridBand9.Name = "GridBand9"
        Me.GridBand9.Width = 80
        '
        'colBonusPoints
        '
        Me.colBonusPoints.Caption = "Summa"
        Me.colBonusPoints.FieldName = "BonusPoints"
        Me.colBonusPoints.Name = "colBonusPoints"
        Me.colBonusPoints.Visible = True
        Me.colBonusPoints.Width = 80
        '
        'GridBand10
        '
        Me.GridBand10.Caption = "     "
        Me.GridBand10.Columns.Add(Me.colPayd)
        Me.GridBand10.Columns.Add(Me.BandedGridColumn5)
        Me.GridBand10.Columns.Add(Me.colServiceGiven)
        Me.GridBand10.Columns.Add(Me.BandedGridColumn1)
        Me.GridBand10.Columns.Add(Me.BandedGridColumn3)
        Me.GridBand10.MinWidth = 20
        Me.GridBand10.Name = "GridBand10"
        Me.GridBand10.Width = 455
        '
        'colPayd
        '
        Me.colPayd.Caption = "Apm."
        Me.colPayd.ColumnEdit = Me.chkPayd
        Me.colPayd.FieldName = "Payd"
        Me.colPayd.Name = "colPayd"
        Me.colPayd.ToolTip = "Apmaksāts"
        Me.colPayd.Visible = True
        Me.colPayd.Width = 44
        '
        'chkPayd
        '
        Me.chkPayd.AutoHeight = False
        Me.chkPayd.Name = "chkPayd"
        '
        'BandedGridColumn5
        '
        Me.BandedGridColumn5.Caption = "Maks. veids"
        Me.BandedGridColumn5.ColumnEdit = Me.cmbPaymentType
        Me.BandedGridColumn5.FieldName = "PaymentType"
        Me.BandedGridColumn5.Name = "BandedGridColumn5"
        Me.BandedGridColumn5.Visible = True
        Me.BandedGridColumn5.Width = 99
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.AutoHeight = False
        Me.cmbPaymentType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colServiceGiven
        '
        Me.colServiceGiven.Caption = "Pak. sn."
        Me.colServiceGiven.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colServiceGiven.FieldName = "ServiceGiven"
        Me.colServiceGiven.Name = "colServiceGiven"
        Me.colServiceGiven.ToolTip = "Pakalpojums sniegts"
        Me.colServiceGiven.Visible = True
        Me.colServiceGiven.Width = 58
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.Caption = "Apmaksas statusu mainīja"
        Me.BandedGridColumn1.FieldName = "PaydStateChangedByUser"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn1.Visible = True
        Me.BandedGridColumn1.Width = 149
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.Caption = "Apmaksas datums"
        Me.BandedGridColumn3.FieldName = "PaydDate"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn3.Visible = True
        Me.BandedGridColumn3.Width = 105
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 242)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grdVisitServices)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdRelatedVisits)
        Me.SplitContainer1.Size = New System.Drawing.Size(1184, 295)
        Me.SplitContainer1.SplitterDistance = 146
        Me.SplitContainer1.TabIndex = 137
        '
        'grdRelatedVisits
        '
        Me.grdRelatedVisits.DataSource = Me.bndRelatedVisits
        Me.grdRelatedVisits.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdRelatedVisits.EmbeddedNavigator.Name = ""
        Me.grdRelatedVisits.EnforceCanEdit = False
        Me.grdRelatedVisits.Location = New System.Drawing.Point(0, 0)
        Me.grdRelatedVisits.MainView = Me.gvwRelatedVisits
        Me.grdRelatedVisits.Name = "grdRelatedVisits"
        Me.grdRelatedVisits.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit3, Me.RepositoryItemCheckEdit2, Me.RepositoryItemButtonEdit4, Me.RepositoryItemCheckEdit3, Me.cmbPaymentTypeRelatedSevice})
        Me.grdRelatedVisits.ShowOnlyActive = False
        Me.grdRelatedVisits.Size = New System.Drawing.Size(1184, 145)
        Me.grdRelatedVisits.TabIndex = 138
        Me.grdRelatedVisits.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwRelatedVisits})
        '
        'bndRelatedVisits
        '
        Me.bndRelatedVisits.DataSource = GetType(Entities.VisitService)
        '
        'gvwRelatedVisits
        '
        Me.gvwRelatedVisits.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand11, Me.GridBand12, Me.GridBand13, Me.GridBand14, Me.GridBand15, Me.GridBand16, Me.GridBand17})
        Me.gvwRelatedVisits.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colRelatedCode, Me.colServiceGiven1, Me.BandedGridColumn12, Me.BandedGridColumn13, Me.BandedGridColumn16, Me.BandedGridColumn18, Me.BandedGridColumn17, Me.BandedGridColumn19, Me.BandedGridColumn14, Me.BandedGridColumn20, Me.BandedGridColumn21, Me.BandedGridColumn26, Me.BandedGridColumn15, Me.BandedGridColumn22, Me.BandedGridColumn23, Me.BandedGridColumn24, Me.BandedGridColumn25, Me.BandedGridColumn2, Me.BandedGridColumn4, Me.colDiscount1, Me.BandedGridColumn6})
        Me.gvwRelatedVisits.GridControl = Me.grdRelatedVisits
        Me.gvwRelatedVisits.Name = "gvwRelatedVisits"
        Me.gvwRelatedVisits.OptionsView.ShowDetailButtons = False
        Me.gvwRelatedVisits.OptionsView.ShowFilterPanel = False
        Me.gvwRelatedVisits.OptionsView.ShowGroupPanel = False
        Me.gvwRelatedVisits.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.BandedGridColumn23, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand11
        '
        Me.GridBand11.Caption = " "
        Me.GridBand11.Columns.Add(Me.colRelatedCode)
        Me.GridBand11.Columns.Add(Me.BandedGridColumn12)
        Me.GridBand11.Columns.Add(Me.BandedGridColumn13)
        Me.GridBand11.Columns.Add(Me.BandedGridColumn14)
        Me.GridBand11.Columns.Add(Me.BandedGridColumn15)
        Me.GridBand11.MinWidth = 20
        Me.GridBand11.Name = "GridBand11"
        Me.GridBand11.Width = 292
        '
        'colRelatedCode
        '
        Me.colRelatedCode.Caption = "Kods"
        Me.colRelatedCode.FieldName = "ServiceCode"
        Me.colRelatedCode.Name = "colRelatedCode"
        Me.colRelatedCode.OptionsColumn.AllowEdit = False
        Me.colRelatedCode.OptionsColumn.ReadOnly = True
        Me.colRelatedCode.Visible = True
        Me.colRelatedCode.Width = 44
        '
        'BandedGridColumn12
        '
        Me.BandedGridColumn12.Caption = "Pakalpojums"
        Me.BandedGridColumn12.ColumnEdit = Me.RepositoryItemButtonEdit3
        Me.BandedGridColumn12.FieldName = "Service"
        Me.BandedGridColumn12.Name = "BandedGridColumn12"
        Me.BandedGridColumn12.Visible = True
        Me.BandedGridColumn12.Width = 248
        '
        'RepositoryItemButtonEdit3
        '
        Me.RepositoryItemButtonEdit3.AutoHeight = False
        Me.RepositoryItemButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit3.Name = "RepositoryItemButtonEdit3"
        Me.RepositoryItemButtonEdit3.ReadOnly = True
        '
        'BandedGridColumn13
        '
        Me.BandedGridColumn13.Caption = "Grupas nodarbība"
        Me.BandedGridColumn13.FieldName = "GroupWork"
        Me.BandedGridColumn13.Name = "BandedGridColumn13"
        Me.BandedGridColumn13.OptionsColumn.ReadOnly = True
        '
        'BandedGridColumn14
        '
        Me.BandedGridColumn14.Caption = "Procentu likme"
        Me.BandedGridColumn14.FieldName = "Percentage"
        Me.BandedGridColumn14.Name = "BandedGridColumn14"
        Me.BandedGridColumn14.Width = 91
        '
        'BandedGridColumn15
        '
        Me.BandedGridColumn15.Caption = "GridColumn1"
        Me.BandedGridColumn15.FieldName = "IsActive"
        Me.BandedGridColumn15.Name = "BandedGridColumn15"
        '
        'GridBand12
        '
        Me.GridBand12.Caption = "Pakalpojuma"
        Me.GridBand12.Columns.Add(Me.BandedGridColumn16)
        Me.GridBand12.Columns.Add(Me.colDiscount1)
        Me.GridBand12.Columns.Add(Me.BandedGridColumn17)
        Me.GridBand12.Columns.Add(Me.BandedGridColumn18)
        Me.GridBand12.MinWidth = 20
        Me.GridBand12.Name = "GridBand12"
        Me.GridBand12.Width = 115
        '
        'BandedGridColumn16
        '
        Me.BandedGridColumn16.Caption = "Cena"
        Me.BandedGridColumn16.FieldName = "DefaultPrice"
        Me.BandedGridColumn16.Name = "BandedGridColumn16"
        Me.BandedGridColumn16.Visible = True
        Me.BandedGridColumn16.Width = 45
        '
        'colDiscount1
        '
        Me.colDiscount1.Caption = "Atlaide %"
        Me.colDiscount1.FieldName = "Discount"
        Me.colDiscount1.Name = "colDiscount1"
        Me.colDiscount1.Visible = True
        Me.colDiscount1.Width = 70
        '
        'BandedGridColumn17
        '
        Me.BandedGridColumn17.Caption = "Bez PVN"
        Me.BandedGridColumn17.FieldName = "DefaultPriceWithOutPercentage"
        Me.BandedGridColumn17.Name = "BandedGridColumn17"
        '
        'BandedGridColumn18
        '
        Me.BandedGridColumn18.Caption = "PVN"
        Me.BandedGridColumn18.FieldName = "DefaultPercentagePrice"
        Me.BandedGridColumn18.Name = "BandedGridColumn18"
        '
        'GridBand13
        '
        Me.GridBand13.Caption = "Apmaksai"
        Me.GridBand13.Columns.Add(Me.BandedGridColumn19)
        Me.GridBand13.Columns.Add(Me.BandedGridColumn20)
        Me.GridBand13.Columns.Add(Me.BandedGridColumn21)
        Me.GridBand13.MinWidth = 20
        Me.GridBand13.Name = "GridBand13"
        Me.GridBand13.Width = 62
        '
        'BandedGridColumn19
        '
        Me.BandedGridColumn19.Caption = "Summa"
        Me.BandedGridColumn19.FieldName = "Price"
        Me.BandedGridColumn19.Name = "BandedGridColumn19"
        Me.BandedGridColumn19.Visible = True
        Me.BandedGridColumn19.Width = 62
        '
        'BandedGridColumn20
        '
        Me.BandedGridColumn20.Caption = "Bez PVN"
        Me.BandedGridColumn20.FieldName = "PriceWithOutPercentage"
        Me.BandedGridColumn20.Name = "BandedGridColumn20"
        Me.BandedGridColumn20.Width = 62
        '
        'BandedGridColumn21
        '
        Me.BandedGridColumn21.Caption = "PVN"
        Me.BandedGridColumn21.FieldName = "PercentagePrice"
        Me.BandedGridColumn21.Name = "BandedGridColumn21"
        Me.BandedGridColumn21.Width = 39
        '
        'GridBand14
        '
        Me.GridBand14.Caption = "Apdrošināšana"
        Me.GridBand14.Columns.Add(Me.BandedGridColumn22)
        Me.GridBand14.MinWidth = 20
        Me.GridBand14.Name = "GridBand14"
        Me.GridBand14.Width = 88
        '
        'BandedGridColumn22
        '
        Me.BandedGridColumn22.Caption = "Summa"
        Me.BandedGridColumn22.FieldName = "Insurance"
        Me.BandedGridColumn22.Name = "BandedGridColumn22"
        Me.BandedGridColumn22.Visible = True
        Me.BandedGridColumn22.Width = 88
        '
        'GridBand15
        '
        Me.GridBand15.Caption = "Dāvanu karte"
        Me.GridBand15.Columns.Add(Me.BandedGridColumn23)
        Me.GridBand15.Columns.Add(Me.BandedGridColumn24)
        Me.GridBand15.MinWidth = 20
        Me.GridBand15.Name = "GridBand15"
        Me.GridBand15.Width = 118
        '
        'BandedGridColumn23
        '
        Me.BandedGridColumn23.Caption = "Numurs"
        Me.BandedGridColumn23.ColumnEdit = Me.RepositoryItemButtonEdit4
        Me.BandedGridColumn23.FieldName = "PresentCardNumber"
        Me.BandedGridColumn23.Name = "BandedGridColumn23"
        Me.BandedGridColumn23.Visible = True
        Me.BandedGridColumn23.Width = 66
        '
        'RepositoryItemButtonEdit4
        '
        Me.RepositoryItemButtonEdit4.AutoHeight = False
        Me.RepositoryItemButtonEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit4.Name = "RepositoryItemButtonEdit4"
        Me.RepositoryItemButtonEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'BandedGridColumn24
        '
        Me.BandedGridColumn24.Caption = "Summa"
        Me.BandedGridColumn24.FieldName = "PresentCardSum"
        Me.BandedGridColumn24.Name = "BandedGridColumn24"
        Me.BandedGridColumn24.Visible = True
        Me.BandedGridColumn24.Width = 52
        '
        'GridBand16
        '
        Me.GridBand16.Caption = "Bonusa punkti"
        Me.GridBand16.Columns.Add(Me.BandedGridColumn25)
        Me.GridBand16.MinWidth = 20
        Me.GridBand16.Name = "GridBand16"
        Me.GridBand16.Width = 83
        '
        'BandedGridColumn25
        '
        Me.BandedGridColumn25.Caption = "Summa"
        Me.BandedGridColumn25.FieldName = "BonusPoints"
        Me.BandedGridColumn25.Name = "BandedGridColumn25"
        Me.BandedGridColumn25.Visible = True
        Me.BandedGridColumn25.Width = 83
        '
        'GridBand17
        '
        Me.GridBand17.Caption = "     "
        Me.GridBand17.Columns.Add(Me.BandedGridColumn26)
        Me.GridBand17.Columns.Add(Me.BandedGridColumn6)
        Me.GridBand17.Columns.Add(Me.colServiceGiven1)
        Me.GridBand17.Columns.Add(Me.BandedGridColumn2)
        Me.GridBand17.Columns.Add(Me.BandedGridColumn4)
        Me.GridBand17.MinWidth = 20
        Me.GridBand17.Name = "GridBand17"
        Me.GridBand17.Width = 452
        '
        'BandedGridColumn26
        '
        Me.BandedGridColumn26.Caption = "Apm."
        Me.BandedGridColumn26.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.BandedGridColumn26.FieldName = "Payd"
        Me.BandedGridColumn26.Name = "BandedGridColumn26"
        Me.BandedGridColumn26.ToolTip = "Apmaksāts"
        Me.BandedGridColumn26.Visible = True
        Me.BandedGridColumn26.Width = 55
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'BandedGridColumn6
        '
        Me.BandedGridColumn6.Caption = "Apm. veids"
        Me.BandedGridColumn6.ColumnEdit = Me.cmbPaymentTypeRelatedSevice
        Me.BandedGridColumn6.FieldName = "PaymentType"
        Me.BandedGridColumn6.Name = "BandedGridColumn6"
        Me.BandedGridColumn6.Visible = True
        Me.BandedGridColumn6.Width = 92
        '
        'cmbPaymentTypeRelatedSevice
        '
        Me.cmbPaymentTypeRelatedSevice.AutoHeight = False
        Me.cmbPaymentTypeRelatedSevice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbPaymentTypeRelatedSevice.Name = "cmbPaymentTypeRelatedSevice"
        Me.cmbPaymentTypeRelatedSevice.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colServiceGiven1
        '
        Me.colServiceGiven1.Caption = "Pak. sn."
        Me.colServiceGiven1.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.colServiceGiven1.FieldName = "ServiceGiven"
        Me.colServiceGiven1.Name = "colServiceGiven1"
        Me.colServiceGiven1.ToolTip = "Pakalpojums sniegts"
        Me.colServiceGiven1.Visible = True
        Me.colServiceGiven1.Width = 58
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.Caption = "Apmaksas statusu mainīja"
        Me.BandedGridColumn2.FieldName = "PaydStateChangedByUser"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.Width = 142
        '
        'BandedGridColumn4
        '
        Me.BandedGridColumn4.Caption = "Apmaksas datums"
        Me.BandedGridColumn4.FieldName = "PaydDate"
        Me.BandedGridColumn4.Name = "BandedGridColumn4"
        Me.BandedGridColumn4.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn4.Visible = True
        Me.BandedGridColumn4.Width = 105
        '
        'cmsInsuranceTemplates
        '
        Me.cmsInsuranceTemplates.Name = "ContextMenuStrip1"
        Me.cmsInsuranceTemplates.ShowImageMargin = False
        Me.cmsInsuranceTemplates.Size = New System.Drawing.Size(36, 4)
        '
        'frmVisitEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 566)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.gbhVisitServices)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(1200, 511)
        Me.Name = "frmVisitEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vizīte"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDoctor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtRelatedDoctor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbhVisitServices.ResumeLayout(False)
        Me.gbhVisitServices.PerformLayout()
        CType(Me.grdVisitServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServiceCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPresentCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPayd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdRelatedVisits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndRelatedVisits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwRelatedVisits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPaymentTypeRelatedSevice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents bndData As System.Windows.Forms.BindingSource
    Friend WithEvents TimeEdit2 As Core.UI.TimeEdit
    Friend WithEvents TimeEdit1 As Core.UI.TimeEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtDoctor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtPatient As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtService As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnOpenPatient As System.Windows.Forms.Button
    Friend WithEvents btnState As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStatuss As System.Windows.Forms.TextBox
    Friend WithEvents cmsState As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbhVisitServices As Core.UI.GridButtonHelper
    Friend WithEvents grdVisitServices As Core.UI.CoreGrid
    Friend WithEvents VisitServicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtServiceCol As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents chkPayd As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colService As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGroupWork As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPriceWithOutPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPercentagePrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPayd As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDefaultPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDefaultPercentagePrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDefaultPriceWithOutPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents txtCreator As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAddNewService As System.Windows.Forms.Button
    Friend WithEvents btnAddNewVisit As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents bndRelatedVisits As System.Windows.Forms.BindingSource
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkPrepareCard As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents colInsurance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPresentCardNumber As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPresentCardSum As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtPresentCard As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colBonusPoints As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand10 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents grdRelatedVisits As Core.UI.CoreGrid
    Friend WithEvents gvwRelatedVisits As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand11 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn12 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents BandedGridColumn13 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn14 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn15 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand12 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn16 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn17 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn18 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand13 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn19 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn20 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn21 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand14 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn22 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand15 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn23 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemButtonEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents BandedGridColumn24 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand16 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn25 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand17 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn26 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtBonusPoints As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnGenerateInsurance As System.Windows.Forms.Button
    Friend WithEvents cmsInsuranceTemplates As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colServiceGiven As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colServiceGiven1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRelatedCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtRelatedDoctor As Client.ClassifierPicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents colDiscount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDiscount1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents lblCampaignName As System.Windows.Forms.Label
    Friend WithEvents chkCampaign As System.Windows.Forms.CheckBox
    Friend WithEvents txtCampaignSumm As System.Windows.Forms.TextBox
    Friend WithEvents lblCampaignSumm As System.Windows.Forms.Label
    Friend WithEvents BandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbPaymentType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbPaymentTypeRelatedSevice As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents chkProgramm As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents btnNewWisit As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnNorikojumi As System.Windows.Forms.Button
End Class
