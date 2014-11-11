<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmsSending
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
        Me.GridButtonHelper1 = New Core.UI.GridButtonHelper
        Me.btnRemove = New System.Windows.Forms.Button
        Me.grdPatients = New Core.UI.CoreGrid
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwPatients = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSurname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcolor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSimbolCount = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSmsText = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpSendTime = New DevExpress.XtraEditors.TimeEdit
        Me.dtpSendDate = New DevExpress.XtraEditors.DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSend = New System.Windows.Forms.Button
        Me.GridButtonHelper1.SuspendLayout()
        CType(Me.grdPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dtpSendTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpSendDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridButtonHelper1
        '
        Me.GridButtonHelper1.AutoSize = True
        Me.GridButtonHelper1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GridButtonHelper1.Controls.Add(Me.btnRemove)
        Me.GridButtonHelper1.DeleteReason = False
        Me.GridButtonHelper1.DeleteReasonColumn = Nothing
        Me.GridButtonHelper1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridButtonHelper1.Grid = Me.grdPatients
        Me.GridButtonHelper1.GridDataSource = Me.PatientBindingSource
        Me.GridButtonHelper1.Location = New System.Drawing.Point(0, 79)
        Me.GridButtonHelper1.Name = "GridButtonHelper1"
        Me.GridButtonHelper1.ShowActive = False
        Me.GridButtonHelper1.ShowAdd = True
        Me.GridButtonHelper1.ShowChk = False
        Me.GridButtonHelper1.ShowDelete = False
        Me.GridButtonHelper1.Size = New System.Drawing.Size(992, 29)
        Me.GridButtonHelper1.TabIndex = 0
        Me.GridButtonHelper1.UseCanDelete = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(84, 3)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Izņemt"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'grdPatients
        '
        Me.grdPatients.DataSource = Me.PatientBindingSource
        Me.grdPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPatients.EmbeddedNavigator.Name = ""
        Me.grdPatients.EnforceCanEdit = False
        Me.grdPatients.Location = New System.Drawing.Point(0, 108)
        Me.grdPatients.MainView = Me.gvwPatients
        Me.grdPatients.Name = "grdPatients"
        Me.grdPatients.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemColorEdit1, Me.RepositoryItemCheckEdit1})
        Me.grdPatients.ShowOnlyActive = False
        Me.grdPatients.Size = New System.Drawing.Size(992, 330)
        Me.grdPatients.TabIndex = 7
        Me.grdPatients.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPatients})
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataSource = GetType(Entities.Patient)
        '
        'gvwPatients
        '
        Me.gvwPatients.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIsActive, Me.colName, Me.colSurname, Me.colNumber, Me.colPhone, Me.colAddress, Me.colMail, Me.colFax, Me.colcolor})
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
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        Me.colIsActive.OptionsColumn.AllowEdit = False
        Me.colIsActive.OptionsColumn.ReadOnly = True
        '
        'colName
        '
        Me.colName.Caption = "Vārds"
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.OptionsColumn.ReadOnly = True
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 2
        Me.colName.Width = 154
        '
        'colSurname
        '
        Me.colSurname.Caption = "Uzvārds"
        Me.colSurname.FieldName = "Surname"
        Me.colSurname.Name = "colSurname"
        Me.colSurname.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colSurname.OptionsColumn.ReadOnly = True
        Me.colSurname.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colSurname.Visible = True
        Me.colSurname.VisibleIndex = 3
        Me.colSurname.Width = 134
        '
        'colNumber
        '
        Me.colNumber.Caption = "Klienta nr"
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.OptionsColumn.ReadOnly = True
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 1
        Me.colNumber.Width = 90
        '
        'colPhone
        '
        Me.colPhone.Caption = "Mobilais tālrunis"
        Me.colPhone.FieldName = "MobilePhone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.OptionsColumn.ReadOnly = True
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 4
        Me.colPhone.Width = 94
        '
        'colAddress
        '
        Me.colAddress.Caption = "Adrese"
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.OptionsColumn.ReadOnly = True
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 5
        Me.colAddress.Width = 226
        '
        'colMail
        '
        Me.colMail.Caption = "E-pasts"
        Me.colMail.FieldName = "Mail"
        Me.colMail.Name = "colMail"
        Me.colMail.OptionsColumn.ReadOnly = True
        Me.colMail.Visible = True
        Me.colMail.VisibleIndex = 6
        Me.colMail.Width = 121
        '
        'colFax
        '
        Me.colFax.Caption = "Fakss"
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        Me.colFax.OptionsColumn.ReadOnly = True
        Me.colFax.Visible = True
        Me.colFax.VisibleIndex = 7
        Me.colFax.Width = 99
        '
        'colcolor
        '
        Me.colcolor.ColumnEdit = Me.RepositoryItemColorEdit1
        Me.colcolor.FieldName = "color"
        Me.colcolor.Name = "colcolor"
        Me.colcolor.OptionsColumn.ReadOnly = True
        Me.colcolor.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colcolor.Visible = True
        Me.colcolor.VisibleIndex = 0
        Me.colcolor.Width = 34
        '
        'RepositoryItemColorEdit1
        '
        Me.RepositoryItemColorEdit1.AutoHeight = False
        Me.RepositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemColorEdit1.Name = "RepositoryItemColorEdit1"
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
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSimbolCount)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtSmsText)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpSendTime)
        Me.Panel1.Controls.Add(Me.dtpSendDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 79)
        Me.Panel1.TabIndex = 1
        '
        'txtSimbolCount
        '
        Me.txtSimbolCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSimbolCount.Location = New System.Drawing.Point(903, 51)
        Me.txtSimbolCount.Name = "txtSimbolCount"
        Me.txtSimbolCount.ReadOnly = True
        Me.txtSimbolCount.Size = New System.Drawing.Size(77, 20)
        Me.txtSimbolCount.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(903, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Simbolu skaits:"
        '
        'txtSmsText
        '
        Me.txtSmsText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSmsText.Location = New System.Drawing.Point(112, 32)
        Me.txtSmsText.Multiline = True
        Me.txtSmsText.Name = "txtSmsText"
        Me.txtSmsText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSmsText.Size = New System.Drawing.Size(785, 39)
        Me.txtSmsText.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SMS teksts:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(420, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(560, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Grupas nosaukums:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "plkst.:"
        '
        'dtpSendTime
        '
        Me.dtpSendTime.EditValue = New Date(2009, 4, 1, 0, 0, 0, 0)
        Me.dtpSendTime.Location = New System.Drawing.Point(259, 6)
        Me.dtpSendTime.Name = "dtpSendTime"
        Me.dtpSendTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpSendTime.Properties.Mask.EditMask = "t"
        Me.dtpSendTime.Size = New System.Drawing.Size(48, 20)
        Me.dtpSendTime.TabIndex = 2
        '
        'dtpSendDate
        '
        Me.dtpSendDate.EditValue = Nothing
        Me.dtpSendDate.Location = New System.Drawing.Point(112, 6)
        Me.dtpSendDate.Name = "dtpSendDate"
        Me.dtpSendDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpSendDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpSendDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sûtīšanas datums:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSend)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 438)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(992, 31)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(914, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(833, 3)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Sûtīt īsziņas"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'frmSmsSending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 469)
        Me.Controls.Add(Me.grdPatients)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GridButtonHelper1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSmsSending"
        Me.Text = "Îsziņu sûtīšana"
        Me.GridButtonHelper1.ResumeLayout(False)
        Me.GridButtonHelper1.PerformLayout()
        CType(Me.grdPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtpSendTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpSendDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridButtonHelper1 As Core.UI.GridButtonHelper
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpSendTime As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents dtpSendDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSmsText As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSimbolCount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents PatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grdPatients As Core.UI.CoreGrid
    Friend WithEvents gvwPatients As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSurname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcolor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnRemove As System.Windows.Forms.Button

End Class
