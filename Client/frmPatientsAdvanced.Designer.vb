<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientsAdvanced
    Inherits Client.frmUIBase
    'ёй
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
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnOpen = New System.Windows.Forms.Button
        Me.btnDisable = New System.Windows.Forms.Button
        Me.bndPatients = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnExportToExcel = New System.Windows.Forms.Button
        Me.pnlSearch = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.grdPatients = New Core.UI.CoreGrid
        Me.gvwPatients = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSelected = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colHasCard = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSurname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcolor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
        Me.colPatientStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.CtlPatientFind1 = New Client.ctlPatientFindAdvanced
        CType(Me.bndPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grdPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        Me.colIsActive.OptionsColumn.AllowEdit = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(920, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(84, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(69, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnDisable
        '
        Me.btnDisable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDisable.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndPatients, "CanRestore", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDisable.Location = New System.Drawing.Point(159, 3)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(69, 23)
        Me.btnDisable.TabIndex = 3
        Me.btnDisable.Text = "Atjaunot"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'bndPatients
        '
        Me.bndPatients.DataSource = GetType(Entities.Patient)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 433)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 33)
        Me.Panel1.TabIndex = 6
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOpen)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDisable)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExportToExcel)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(534, 29)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Pievienot"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndPatients, "CanDelete", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDelete.Location = New System.Drawing.Point(234, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Dzēst"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.AutoSize = True
        Me.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExport.Location = New System.Drawing.Point(315, 3)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(105, 23)
        Me.btnExport.TabIndex = 8
        Me.btnExport.Text = "Eksportēt uz Word"
        Me.btnExport.UseVisualStyleBackColor = True
        Me.btnExport.Visible = False
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.AutoSize = True
        Me.btnExportToExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExportToExcel.Location = New System.Drawing.Point(426, 3)
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(105, 23)
        Me.btnExportToExcel.TabIndex = 9
        Me.btnExportToExcel.Text = "Eksportēt uz Excel"
        Me.btnExportToExcel.UseVisualStyleBackColor = True
        Me.btnExportToExcel.Visible = False
        '
        'pnlSearch
        '
        Me.pnlSearch.AutoSize = True
        Me.pnlSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlSearch.Location = New System.Drawing.Point(236, 12)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(0, 0)
        Me.pnlSearch.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.grdPatients)
        Me.Panel2.Controls.Add(Me.CtlPatientFind1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(992, 433)
        Me.Panel2.TabIndex = 7
        '
        'grdPatients
        '
        Me.grdPatients.DataSource = Me.bndPatients
        Me.grdPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPatients.EmbeddedNavigator.Name = ""
        Me.grdPatients.EnforceCanEdit = False
        Me.grdPatients.Location = New System.Drawing.Point(0, 261)
        Me.grdPatients.MainView = Me.gvwPatients
        Me.grdPatients.Name = "grdPatients"
        Me.grdPatients.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemColorEdit1, Me.RepositoryItemCheckEdit1})
        Me.grdPatients.ShowOnlyActive = False
        Me.grdPatients.Size = New System.Drawing.Size(992, 172)
        Me.grdPatients.TabIndex = 6
        Me.grdPatients.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPatients})
        '
        'gvwPatients
        '
        Me.gvwPatients.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSelected, Me.colHasCard, Me.colIsActive, Me.colName, Me.colSurname, Me.colNumber, Me.colPhone, Me.colAddress, Me.colMail, Me.colFax, Me.colcolor, Me.colPatientStatus})
        Me.gvwPatients.GridControl = Me.grdPatients
        Me.gvwPatients.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Me.colNumber, "")})
        Me.gvwPatients.Name = "gvwPatients"
        Me.gvwPatients.OptionsView.ColumnAutoWidth = False
        Me.gvwPatients.OptionsView.ShowAutoFilterRow = True
        Me.gvwPatients.OptionsView.ShowDetailButtons = False
        Me.gvwPatients.OptionsView.ShowFilterPanel = False
        Me.gvwPatients.OptionsView.ShowFooter = True
        Me.gvwPatients.OptionsView.ShowGroupPanel = False
        Me.gvwPatients.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSurname, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSelected
        '
        Me.colSelected.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colSelected.FieldName = "Selected"
        Me.colSelected.Name = "colSelected"
        Me.colSelected.Visible = True
        Me.colSelected.VisibleIndex = 0
        Me.colSelected.Width = 33
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colHasCard
        '
        Me.colHasCard.Caption = "Kartiņa"
        Me.colHasCard.FieldName = "HasCard"
        Me.colHasCard.Name = "colHasCard"
        Me.colHasCard.Visible = True
        Me.colHasCard.VisibleIndex = 2
        Me.colHasCard.Width = 57
        '
        'colName
        '
        Me.colName.Caption = "Vārds"
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 4
        Me.colName.Width = 90
        '
        'colSurname
        '
        Me.colSurname.Caption = "Uzvārds"
        Me.colSurname.FieldName = "Surname"
        Me.colSurname.Name = "colSurname"
        Me.colSurname.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colSurname.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colSurname.Visible = True
        Me.colSurname.VisibleIndex = 5
        Me.colSurname.Width = 90
        '
        'colNumber
        '
        Me.colNumber.Caption = "Klienta nr"
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 3
        Me.colNumber.Width = 90
        '
        'colPhone
        '
        Me.colPhone.Caption = "Mobilais tālrunis"
        Me.colPhone.FieldName = "MobilePhone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 6
        Me.colPhone.Width = 97
        '
        'colAddress
        '
        Me.colAddress.Caption = "Adrese"
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 7
        Me.colAddress.Width = 176
        '
        'colMail
        '
        Me.colMail.Caption = "E-pasts"
        Me.colMail.FieldName = "Mail"
        Me.colMail.Name = "colMail"
        Me.colMail.Visible = True
        Me.colMail.VisibleIndex = 8
        Me.colMail.Width = 130
        '
        'colFax
        '
        Me.colFax.Caption = "Fakss"
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        Me.colFax.Visible = True
        Me.colFax.VisibleIndex = 9
        Me.colFax.Width = 83
        '
        'colcolor
        '
        Me.colcolor.ColumnEdit = Me.RepositoryItemColorEdit1
        Me.colcolor.FieldName = "color"
        Me.colcolor.Name = "colcolor"
        Me.colcolor.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colcolor.Visible = True
        Me.colcolor.VisibleIndex = 1
        Me.colcolor.Width = 34
        '
        'RepositoryItemColorEdit1
        '
        Me.RepositoryItemColorEdit1.AutoHeight = False
        Me.RepositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemColorEdit1.Name = "RepositoryItemColorEdit1"
        '
        'colPatientStatus
        '
        Me.colPatientStatus.Caption = "Statuss"
        Me.colPatientStatus.FieldName = "PatientStatus"
        Me.colPatientStatus.Name = "colPatientStatus"
        Me.colPatientStatus.Visible = True
        Me.colPatientStatus.VisibleIndex = 10
        Me.colPatientStatus.Width = 58
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'CtlPatientFind1
        '
        Me.CtlPatientFind1.AutoSize = True
        Me.CtlPatientFind1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CtlPatientFind1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlPatientFind1.Location = New System.Drawing.Point(0, 0)
        Me.CtlPatientFind1.MinimumSize = New System.Drawing.Size(403, 0)
        Me.CtlPatientFind1.Name = "CtlPatientFind1"
        Me.CtlPatientFind1.Size = New System.Drawing.Size(992, 261)
        Me.CtlPatientFind1.TabIndex = 7
        '
        'frmPatientsAdvanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 466)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSearch)
        Me.MinimumSize = New System.Drawing.Size(477, 434)
        Me.Name = "frmPatientsAdvanced"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Klientu saraksts"
        CType(Me.bndPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.grdPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnDisable As System.Windows.Forms.Button
    Friend WithEvents LastIPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsersIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReplaceToDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CertDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChangeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReplaceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CloseDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoleIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OtherNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NisIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents grdPatients As Core.UI.CoreGrid
    Friend WithEvents gvwPatients As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bndPatients As System.Windows.Forms.BindingSource
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSurname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHasCard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents CtlPatientFind1 As Client.ctlPatientFindAdvanced
    Friend WithEvents colcolor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnExportToExcel As System.Windows.Forms.Button
    Friend WithEvents colPatientStatus As DevExpress.XtraGrid.Columns.GridColumn
End Class
