<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSale
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.bndSale = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPayDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPatient = New Client.ClassifierPicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBay = New System.Windows.Forms.Button()
        Me.gbhVisitServices = New Core.UI.GridButtonHelper()
        Me.grdVisitServices = New Core.UI.CoreGrid()
        Me.bndSaleProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtServiceCol = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colDefaultPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkPayd = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.txtPresentCard = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.cmbPaymentType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.bndSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.grdVisitServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndSaleProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServiceCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPayd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPresentCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtPayDate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPatient)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 115)
        Me.Panel1.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSale, "Notes", True))
        Me.TextBox3.Location = New System.Drawing.Point(106, 64)
        Me.TextBox3.MaxLength = 500
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(746, 45)
        Me.TextBox3.TabIndex = 22
        '
        'bndSale
        '
        Me.bndSale.DataSource = GetType(Entities.Sale)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Piezīmes:"
        '
        'txtPayDate
        '
        Me.txtPayDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndSale, "PaymentDate", True))
        Me.txtPayDate.EditValue = Nothing
        Me.txtPayDate.Enabled = False
        Me.txtPayDate.Location = New System.Drawing.Point(106, 38)
        Me.txtPayDate.Name = "txtPayDate"
        Me.txtPayDate.Properties.DisplayFormat.FormatString = "G"
        Me.txtPayDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtPayDate.Properties.Mask.EditMask = "G"
        Me.txtPayDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPayDate.Size = New System.Drawing.Size(100, 20)
        Me.txtPayDate.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Apmaksu pieņēma:"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSale, "PaymentUser", True))
        Me.TextBox4.Location = New System.Drawing.Point(312, 38)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(265, 20)
        Me.TextBox4.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Apmaksas datums:"
        '
        'txtPatient
        '
        Me.txtPatient.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndSale, "Patient", True))
        Me.txtPatient.Location = New System.Drawing.Point(106, 12)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.PickerPresets = Nothing
        Me.txtPatient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPatient.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPatient.Size = New System.Drawing.Size(471, 20)
        Me.txtPatient.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Klients:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBay)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 296)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(864, 30)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(786, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(705, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBay
        '
        Me.btnBay.Location = New System.Drawing.Point(624, 3)
        Me.btnBay.Name = "btnBay"
        Me.btnBay.Size = New System.Drawing.Size(75, 23)
        Me.btnBay.TabIndex = 4
        Me.btnBay.Text = "Pirkt"
        Me.btnBay.UseVisualStyleBackColor = True
        '
        'gbhVisitServices
        '
        Me.gbhVisitServices.AutoSize = True
        Me.gbhVisitServices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhVisitServices.DeleteReason = False
        Me.gbhVisitServices.DeleteReasonColumn = Nothing
        Me.gbhVisitServices.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhVisitServices.Grid = Me.grdVisitServices
        Me.gbhVisitServices.GridDataSource = Nothing
        Me.gbhVisitServices.Location = New System.Drawing.Point(0, 115)
        Me.gbhVisitServices.Name = "gbhVisitServices"
        Me.gbhVisitServices.ShowActive = False
        Me.gbhVisitServices.ShowAdd = True
        Me.gbhVisitServices.ShowChk = True
        Me.gbhVisitServices.ShowDelete = True
        Me.gbhVisitServices.Size = New System.Drawing.Size(864, 29)
        Me.gbhVisitServices.TabIndex = 137
        Me.gbhVisitServices.UseCanDelete = True
        '
        'grdVisitServices
        '
        Me.grdVisitServices.DataSource = Me.bndSaleProduct
        Me.grdVisitServices.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdVisitServices.EmbeddedNavigator.Name = ""
        Me.grdVisitServices.EnforceCanEdit = False
        Me.grdVisitServices.Location = New System.Drawing.Point(0, 144)
        Me.grdVisitServices.MainView = Me.gvwData
        Me.grdVisitServices.Name = "grdVisitServices"
        Me.grdVisitServices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtServiceCol, Me.chkPayd, Me.txtPresentCard, Me.RepositoryItemCheckEdit1, Me.RepositoryItemImageEdit1, Me.cmbPaymentType})
        Me.grdVisitServices.ShowOnlyActive = False
        Me.grdVisitServices.Size = New System.Drawing.Size(864, 152)
        Me.grdVisitServices.TabIndex = 138
        Me.grdVisitServices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwData})
        '
        'bndSaleProduct
        '
        Me.bndSaleProduct.DataSource = GetType(Entities.SaleProduct)
        '
        'gvwData
        '
        Me.gvwData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colService, Me.colDefaultPrice, Me.colPrice, Me.colPayd})
        Me.gvwData.GridControl = Me.grdVisitServices
        Me.gvwData.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", Nothing, "")})
        Me.gvwData.Name = "gvwData"
        Me.gvwData.OptionsView.ShowDetailButtons = False
        Me.gvwData.OptionsView.ShowFilterPanel = False
        Me.gvwData.OptionsView.ShowGroupPanel = False
        '
        'colCode
        '
        Me.colCode.Caption = "Kods"
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.OptionsColumn.AllowEdit = False
        Me.colCode.OptionsColumn.ReadOnly = True
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        Me.colCode.Width = 105
        '
        'colService
        '
        Me.colService.Caption = "Pakalpojums"
        Me.colService.ColumnEdit = Me.txtServiceCol
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.Visible = True
        Me.colService.VisibleIndex = 1
        Me.colService.Width = 295
        '
        'txtServiceCol
        '
        Me.txtServiceCol.AutoHeight = False
        Me.txtServiceCol.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtServiceCol.Name = "txtServiceCol"
        Me.txtServiceCol.ReadOnly = True
        '
        'colDefaultPrice
        '
        Me.colDefaultPrice.Caption = "Cena"
        Me.colDefaultPrice.DisplayFormat.FormatString = "n2"
        Me.colDefaultPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDefaultPrice.FieldName = "Price"
        Me.colDefaultPrice.Name = "colDefaultPrice"
        Me.colDefaultPrice.Visible = True
        Me.colDefaultPrice.VisibleIndex = 2
        Me.colDefaultPrice.Width = 110
        '
        'colPrice
        '
        Me.colPrice.Caption = "Summa"
        Me.colPrice.FieldName = "Count"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 3
        Me.colPrice.Width = 98
        '
        'colPayd
        '
        Me.colPayd.Caption = "Kopā"
        Me.colPayd.DisplayFormat.FormatString = "n2"
        Me.colPayd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPayd.FieldName = "Total"
        Me.colPayd.Name = "colPayd"
        Me.colPayd.ToolTip = "Apmaksāts"
        Me.colPayd.Visible = True
        Me.colPayd.VisibleIndex = 4
        Me.colPayd.Width = 245
        '
        'chkPayd
        '
        Me.chkPayd.AutoHeight = False
        Me.chkPayd.Name = "chkPayd"
        '
        'txtPresentCard
        '
        Me.txtPresentCard.AutoHeight = False
        Me.txtPresentCard.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPresentCard.Name = "txtPresentCard"
        Me.txtPresentCard.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.AutoHeight = False
        Me.cmbPaymentType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(864, 326)
        Me.Controls.Add(Me.grdVisitServices)
        Me.Controls.Add(Me.gbhVisitServices)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSale"
        Me.Text = "Pārdošana"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bndSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.grdVisitServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndSaleProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServiceCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPayd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPresentCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbhVisitServices As Core.UI.GridButtonHelper
    Friend WithEvents grdVisitServices As Core.UI.CoreGrid
    Friend WithEvents txtServiceCol As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents txtPresentCard As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents chkPayd As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmbPaymentType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents gvwData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bndSaleProduct As System.Windows.Forms.BindingSource
    Friend WithEvents btnBay As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPayDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPatient As Client.ClassifierPicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bndSale As System.Windows.Forms.BindingSource

End Class
