<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampaignPatients
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
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.bndCampaign = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.dteValidFrom = New DevExpress.XtraEditors.DateEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdCampaignPatients = New Core.UI.CoreGrid
        Me.CampaignPatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwCampaignPatients = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnOpenPatientCard = New System.Windows.Forms.Button
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.gbhCampaignPatients = New Core.UI.GridButtonHelper
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnAddNewClient = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.bndCampaign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteValidFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCampaignPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CampaignPatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwCampaignPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.gbhCampaignPatients.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DateEdit1)
        Me.Panel1.Controls.Add(Me.dteValidFrom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 159)
        Me.Panel1.TabIndex = 0
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCampaign, "Comment", True))
        Me.TextBox4.Location = New System.Drawing.Point(126, 90)
        Me.TextBox4.MaxLength = 1000
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(740, 63)
        Me.TextBox4.TabIndex = 15
        '
        'bndCampaign
        '
        Me.bndCampaign.DataSource = GetType(Entities.Campaign)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Piezīmes:"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCampaign, "CampaignValue", True))
        Me.TextBox3.Location = New System.Drawing.Point(614, 64)
        Me.TextBox3.MaxLength = 50
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(531, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Akcijas summa"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCampaign, "Discount", True))
        Me.TextBox2.Location = New System.Drawing.Point(425, 64)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Atlaide:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Akcija spēkā no:"
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndCampaign, "ValidTo", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(264, 64)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.DateEdit1.Properties.MaxValue = New Date(3000, 11, 5, 0, 0, 0, 0)
        Me.DateEdit1.Properties.MinValue = New Date(2000, 11, 5, 0, 0, 0, 0)
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 8
        '
        'dteValidFrom
        '
        Me.dteValidFrom.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndCampaign, "ValidFrom", True))
        Me.dteValidFrom.EditValue = Nothing
        Me.dteValidFrom.Location = New System.Drawing.Point(126, 64)
        Me.dteValidFrom.Name = "dteValidFrom"
        Me.dteValidFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dteValidFrom.Properties.MaxValue = New Date(3000, 11, 5, 0, 0, 0, 0)
        Me.dteValidFrom.Properties.MinValue = New Date(2000, 11, 5, 0, 0, 0, 0)
        Me.dteValidFrom.Size = New System.Drawing.Size(100, 20)
        Me.dteValidFrom.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "līdz:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCampaign, "NameForPrint", True))
        Me.TextBox1.Location = New System.Drawing.Point(126, 38)
        Me.TextBox1.MaxLength = 1000
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(740, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nosaukums izdrukās:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCampaign, "Name", True))
        Me.txtName.Location = New System.Drawing.Point(230, 12)
        Me.txtName.MaxLength = 1000
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(636, 20)
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nosaukums:"
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCampaign, "Code", True))
        Me.txtCode.Location = New System.Drawing.Point(52, 12)
        Me.txtCode.MaxLength = 50
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kods:"
        '
        'grdCampaignPatients
        '
        Me.grdCampaignPatients.DataSource = Me.CampaignPatientsBindingSource
        Me.grdCampaignPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCampaignPatients.EmbeddedNavigator.Name = ""
        Me.grdCampaignPatients.EnforceCanEdit = False
        Me.grdCampaignPatients.Location = New System.Drawing.Point(0, 188)
        Me.grdCampaignPatients.MainView = Me.gvwCampaignPatients
        Me.grdCampaignPatients.Name = "grdCampaignPatients"
        Me.grdCampaignPatients.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemMemoExEdit1})
        Me.grdCampaignPatients.ShowOnlyActive = False
        Me.grdCampaignPatients.Size = New System.Drawing.Size(878, 215)
        Me.grdCampaignPatients.TabIndex = 1
        Me.grdCampaignPatients.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwCampaignPatients, Me.GridView2})
        '
        'CampaignPatientsBindingSource
        '
        Me.CampaignPatientsBindingSource.DataMember = "CampaignPatients"
        Me.CampaignPatientsBindingSource.DataSource = Me.bndCampaign
        '
        'gvwCampaignPatients
        '
        Me.gvwCampaignPatients.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.gvwCampaignPatients.GridControl = Me.grdCampaignPatients
        Me.gvwCampaignPatients.Name = "gvwCampaignPatients"
        Me.gvwCampaignPatients.OptionsView.ColumnAutoWidth = False
        Me.gvwCampaignPatients.OptionsView.ShowDetailButtons = False
        Me.gvwCampaignPatients.OptionsView.ShowFilterPanel = False
        Me.gvwCampaignPatients.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Klients"
        Me.GridColumn1.FieldName = "Patient"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 145
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Spēkā no"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn2.FieldName = "ValidFrom"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Spēkā līdz"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn3.FieldName = "ValidTo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Atlaide %"
        Me.GridColumn4.FieldName = "Discount"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Summa"
        Me.GridColumn5.FieldName = "CampaignValue"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Piezīmes"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn6.FieldName = "Comment"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 175
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Izveidoja"
        Me.GridColumn7.FieldName = "CreateUser"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 132
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Izveides datums"
        Me.GridColumn8.DisplayFormat.FormatString = "d"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn8.FieldName = "CreateDate"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 97
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grdCampaignPatients
        Me.GridView2.Name = "GridView2"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 403)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(878, 30)
        Me.SplitContainer1.SplitterDistance = 392
        Me.SplitContainer1.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOpenPatientCard)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(392, 30)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'btnOpenPatientCard
        '
        Me.btnOpenPatientCard.AutoSize = True
        Me.btnOpenPatientCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOpenPatientCard.Location = New System.Drawing.Point(3, 3)
        Me.btnOpenPatientCard.Name = "btnOpenPatientCard"
        Me.btnOpenPatientCard.Size = New System.Drawing.Size(114, 23)
        Me.btnOpenPatientCard.TabIndex = 3
        Me.btnOpenPatientCard.Text = "Atvērt klienta kartiņu"
        Me.btnOpenPatientCard.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(482, 30)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(404, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(323, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.AutoSize = True
        Me.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExport.Location = New System.Drawing.Point(212, 3)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(105, 23)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "Eksportēt uz Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'gbhCampaignPatients
        '
        Me.gbhCampaignPatients.AutoSize = True
        Me.gbhCampaignPatients.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhCampaignPatients.Controls.Add(Me.btnAddNewClient)
        Me.gbhCampaignPatients.DeleteReason = False
        Me.gbhCampaignPatients.DeleteReasonColumn = Nothing
        Me.gbhCampaignPatients.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhCampaignPatients.Grid = Me.grdCampaignPatients
        Me.gbhCampaignPatients.GridDataSource = Me.CampaignPatientsBindingSource
        Me.gbhCampaignPatients.Location = New System.Drawing.Point(0, 159)
        Me.gbhCampaignPatients.Name = "gbhCampaignPatients"
        Me.gbhCampaignPatients.ShowActive = False
        Me.gbhCampaignPatients.ShowAdd = True
        Me.gbhCampaignPatients.ShowChk = True
        Me.gbhCampaignPatients.ShowDelete = True
        Me.gbhCampaignPatients.Size = New System.Drawing.Size(878, 29)
        Me.gbhCampaignPatients.TabIndex = 3
        Me.gbhCampaignPatients.UseCanDelete = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndCampaign
        '
        'btnAddNewClient
        '
        Me.btnAddNewClient.AutoSize = True
        Me.btnAddNewClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddNewClient.Location = New System.Drawing.Point(84, 3)
        Me.btnAddNewClient.Name = "btnAddNewClient"
        Me.btnAddNewClient.Size = New System.Drawing.Size(124, 23)
        Me.btnAddNewClient.TabIndex = 4
        Me.btnAddNewClient.Text = "Pievienot jaunu klientu"
        Me.btnAddNewClient.UseVisualStyleBackColor = True
        '
        'frmCampaignPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 433)
        Me.Controls.Add(Me.grdCampaignPatients)
        Me.Controls.Add(Me.gbhCampaignPatients)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCampaignPatients"
        Me.Text = "Akcijas klienti"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bndCampaign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteValidFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCampaignPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CampaignPatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwCampaignPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.gbhCampaignPatients.ResumeLayout(False)
        Me.gbhCampaignPatients.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdCampaignPatients As Core.UI.CoreGrid
    Friend WithEvents gvwCampaignPatients As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbhCampaignPatients As Core.UI.GridButtonHelper
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dteValidFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bndCampaign As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CampaignPatientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnOpenPatientCard As System.Windows.Forms.Button
    Friend WithEvents btnAddNewClient As System.Windows.Forms.Button
End Class
