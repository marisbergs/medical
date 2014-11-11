<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresentCards
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnBay = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.bndData = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdPresentCards = New Core.UI.CoreGrid()
        Me.gvwPresentCards = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPayDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtpPayDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colValidTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNumber = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colServiceCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbState = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtService = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPrice = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.txtState = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gbhPresentCards = New Core.UI.GridButtonHelper()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPresentCards, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwPresentCards, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpPayDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnsave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBay)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOk)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 268)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(840, 29)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(762, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(681, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Saglabāt"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnBay
        '
        Me.btnBay.Location = New System.Drawing.Point(600, 3)
        Me.btnBay.Name = "btnBay"
        Me.btnBay.Size = New System.Drawing.Size(75, 23)
        Me.btnBay.TabIndex = 2
        Me.btnBay.Text = "Pirkt"
        Me.btnBay.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(519, 3)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Eksportēt"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(438, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Labi"
        Me.btnOk.UseVisualStyleBackColor = True
        Me.btnOk.Visible = False
        '
        'bndData
        '
        Me.bndData.DataSource = GetType(Entities.PresentCard)
        '
        'grdPresentCards
        '
        Me.grdPresentCards.DataSource = Me.bndData
        Me.grdPresentCards.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdPresentCards.EmbeddedNavigator.Name = ""
        Me.grdPresentCards.EnforceCanEdit = False
        Me.grdPresentCards.Location = New System.Drawing.Point(0, 29)
        Me.grdPresentCards.MainView = Me.gvwPresentCards
        Me.grdPresentCards.MinimumSize = New System.Drawing.Size(840, 239)
        Me.grdPresentCards.Name = "grdPresentCards"
        Me.grdPresentCards.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtService, Me.dtpPayDate, Me.txtNumber, Me.txtCode, Me.txtPrice, Me.txtState, Me.cmbState, Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoExEdit1})
        Me.grdPresentCards.ShowOnlyActive = False
        Me.grdPresentCards.Size = New System.Drawing.Size(840, 239)
        Me.grdPresentCards.TabIndex = 1
        Me.grdPresentCards.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPresentCards})
        '
        'gvwPresentCards
        '
        Me.gvwPresentCards.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPayDate, Me.colValidTo, Me.colNumber, Me.colServiceCode, Me.colStatus, Me.colService, Me.colPrice, Me.GridColumn1, Me.GridColumn2})
        Me.gvwPresentCards.GridControl = Me.grdPresentCards
        Me.gvwPresentCards.Name = "gvwPresentCards"
        Me.gvwPresentCards.OptionsView.ColumnAutoWidth = False
        Me.gvwPresentCards.OptionsView.ShowAutoFilterRow = True
        Me.gvwPresentCards.OptionsView.ShowFilterPanel = False
        Me.gvwPresentCards.OptionsView.ShowGroupPanel = False
        '
        'colPayDate
        '
        Me.colPayDate.Caption = "Iegādes datums"
        Me.colPayDate.ColumnEdit = Me.dtpPayDate
        Me.colPayDate.FieldName = "PayDate"
        Me.colPayDate.Name = "colPayDate"
        Me.colPayDate.Visible = True
        Me.colPayDate.VisibleIndex = 0
        Me.colPayDate.Width = 108
        '
        'dtpPayDate
        '
        Me.dtpPayDate.AutoHeight = False
        Me.dtpPayDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpPayDate.Name = "dtpPayDate"
        '
        'colValidTo
        '
        Me.colValidTo.Caption = "Spēkā līdz"
        Me.colValidTo.ColumnEdit = Me.dtpPayDate
        Me.colValidTo.FieldName = "ValidTo"
        Me.colValidTo.Name = "colValidTo"
        Me.colValidTo.Visible = True
        Me.colValidTo.VisibleIndex = 1
        Me.colValidTo.Width = 104
        '
        'colNumber
        '
        Me.colNumber.Caption = "Numurs"
        Me.colNumber.ColumnEdit = Me.txtNumber
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 2
        Me.colNumber.Width = 100
        '
        'txtNumber
        '
        Me.txtNumber.AutoHeight = False
        Me.txtNumber.MaxLength = 50
        Me.txtNumber.Name = "txtNumber"
        '
        'colServiceCode
        '
        Me.colServiceCode.Caption = "Kods"
        Me.colServiceCode.ColumnEdit = Me.txtCode
        Me.colServiceCode.FieldName = "ServiceCode"
        Me.colServiceCode.Name = "colServiceCode"
        Me.colServiceCode.Visible = True
        Me.colServiceCode.VisibleIndex = 3
        '
        'txtCode
        '
        Me.txtCode.AutoHeight = False
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.Caption = "Statuss"
        Me.colStatus.ColumnEdit = Me.cmbState
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 7
        Me.colStatus.Width = 103
        '
        'cmbState
        '
        Me.cmbState.AutoHeight = False
        Me.cmbState.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbState.Name = "cmbState"
        '
        'colService
        '
        Me.colService.Caption = "Nosaukums"
        Me.colService.ColumnEdit = Me.txtService
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.Visible = True
        Me.colService.VisibleIndex = 4
        Me.colService.Width = 176
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
        Me.colPrice.Caption = "Cena"
        Me.colPrice.ColumnEdit = Me.txtPrice
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 5
        Me.colPrice.Width = 62
        '
        'txtPrice
        '
        Me.txtPrice.AutoHeight = False
        Me.txtPrice.Mask.EditMask = "f"
        Me.txtPrice.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrice.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrice.Name = "txtPrice"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Piezīmes"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GridColumn1.FieldName = "Note"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        Me.GridColumn1.Width = 331
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.MaxLength = 1000
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'txtState
        '
        Me.txtState.AutoHeight = False
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.MaxLength = 1000
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'gbhPresentCards
        '
        Me.gbhPresentCards.AutoSize = True
        Me.gbhPresentCards.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhPresentCards.DeleteReason = False
        Me.gbhPresentCards.DeleteReasonColumn = Nothing
        Me.gbhPresentCards.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhPresentCards.Grid = Me.grdPresentCards
        Me.gbhPresentCards.GridDataSource = Me.bndData
        Me.gbhPresentCards.Location = New System.Drawing.Point(0, 0)
        Me.gbhPresentCards.Name = "gbhPresentCards"
        Me.gbhPresentCards.ShowActive = False
        Me.gbhPresentCards.ShowAdd = True
        Me.gbhPresentCards.ShowChk = True
        Me.gbhPresentCards.ShowDelete = True
        Me.gbhPresentCards.Size = New System.Drawing.Size(840, 29)
        Me.gbhPresentCards.TabIndex = 2
        Me.gbhPresentCards.UseCanDelete = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndData
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Atlikums"
        Me.GridColumn2.DisplayFormat.FormatString = "n2"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "SummLeft"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 6
        Me.GridColumn2.Width = 57
        '
        'frmPresentCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(840, 297)
        Me.Controls.Add(Me.grdPresentCards)
        Me.Controls.Add(Me.gbhPresentCards)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frmPresentCards"
        Me.Text = "Dāvanu kartes"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPresentCards, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwPresentCards, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpPayDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnBay As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents bndData As System.Windows.Forms.BindingSource
    Friend WithEvents grdPresentCards As Core.UI.CoreGrid
    Friend WithEvents gvwPresentCards As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPayDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiceCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gbhPresentCards As Core.UI.GridButtonHelper
    Friend WithEvents dtpPayDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtService As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents txtNumber As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPrice As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtState As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbState As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colValidTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

End Class
