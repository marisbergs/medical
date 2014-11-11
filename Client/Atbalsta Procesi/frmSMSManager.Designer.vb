<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSManager
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
        Me.grdBefore = New Core.UI.CoreGrid
        Me.bndBefore = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwBefore = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colDaysBefore = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colMeesageText = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSendTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gbhBefore = New Core.UI.GridButtonHelper
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        CType(Me.grdBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdBefore
        '
        Me.grdBefore.DataSource = Me.bndBefore
        Me.grdBefore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdBefore.EmbeddedNavigator.Name = ""
        Me.grdBefore.EnforceCanEdit = False
        Me.grdBefore.Location = New System.Drawing.Point(0, 29)
        Me.grdBefore.MainView = Me.gvwBefore
        Me.grdBefore.Name = "grdBefore"
        Me.grdBefore.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemTimeEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemLookUpEdit1, Me.cmbType})
        Me.grdBefore.ShowOnlyActive = False
        Me.grdBefore.Size = New System.Drawing.Size(992, 352)
        Me.grdBefore.TabIndex = 1
        Me.grdBefore.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwBefore})
        '
        'bndBefore
        '
        Me.bndBefore.DataSource = GetType(Entities.SMSMessages)
        '
        'gvwBefore
        '
        Me.gvwBefore.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colType, Me.colDaysBefore, Me.colMeesageText, Me.colIsActive, Me.colSendTime})
        Me.gvwBefore.GridControl = Me.grdBefore
        Me.gvwBefore.Name = "gvwBefore"
        Me.gvwBefore.OptionsView.ShowDetailButtons = False
        Me.gvwBefore.OptionsView.ShowFilterPanel = False
        Me.gvwBefore.OptionsView.ShowGroupPanel = False
        '
        'colType
        '
        Me.colType.Caption = "Veids"
        Me.colType.ColumnEdit = Me.cmbType
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 0
        Me.colType.Width = 320
        '
        'cmbType
        '
        Me.cmbType.AutoHeight = False
        Me.cmbType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbType.Name = "cmbType"
        Me.cmbType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colDaysBefore
        '
        Me.colDaysBefore.Caption = "Dienas iepriekš"
        Me.colDaysBefore.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colDaysBefore.FieldName = "DaysBefore"
        Me.colDaysBefore.Name = "colDaysBefore"
        Me.colDaysBefore.Visible = True
        Me.colDaysBefore.VisibleIndex = 1
        Me.colDaysBefore.Width = 104
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'colMeesageText
        '
        Me.colMeesageText.Caption = "SMS teksts"
        Me.colMeesageText.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.colMeesageText.FieldName = "MeesageText"
        Me.colMeesageText.Name = "colMeesageText"
        Me.colMeesageText.Visible = True
        Me.colMeesageText.VisibleIndex = 3
        Me.colMeesageText.Width = 455
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemMemoExEdit1.MaxLength = 3000
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        '
        'colSendTime
        '
        Me.colSendTime.Caption = "Sûtīšanas laiks"
        Me.colSendTime.ColumnEdit = Me.RepositoryItemTimeEdit1
        Me.colSendTime.FieldName = "SendTime"
        Me.colSendTime.Name = "colSendTime"
        Me.colSendTime.Visible = True
        Me.colSendTime.VisibleIndex = 2
        Me.colSendTime.Width = 96
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'gbhBefore
        '
        Me.gbhBefore.AutoSize = True
        Me.gbhBefore.DeleteReason = False
        Me.gbhBefore.DeleteReasonColumn = Nothing
        Me.gbhBefore.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhBefore.Grid = Me.grdBefore
        Me.gbhBefore.GridDataSource = Me.bndBefore
        Me.gbhBefore.Location = New System.Drawing.Point(0, 0)
        Me.gbhBefore.Name = "gbhBefore"
        Me.gbhBefore.ShowActive = False
        Me.gbhBefore.ShowAdd = True
        Me.gbhBefore.ShowChk = True
        Me.gbhBefore.ShowDelete = True
        Me.gbhBefore.Size = New System.Drawing.Size(992, 29)
        Me.gbhBefore.TabIndex = 0
        Me.gbhBefore.UseCanDelete = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 381)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(992, 30)
        Me.SplitContainer2.SplitterDistance = 489
        Me.SplitContainer2.TabIndex = 5
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(499, 30)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(421, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(340, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmSMSManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 411)
        Me.Controls.Add(Me.grdBefore)
        Me.Controls.Add(Me.gbhBefore)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "frmSMSManager"
        Me.Text = "SMS īsziņu administrēšana"
        CType(Me.grdBefore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndBefore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwBefore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents grdBefore As Core.UI.CoreGrid
    Friend WithEvents gvwBefore As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbhBefore As Core.UI.GridButtonHelper
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents bndBefore As System.Windows.Forms.BindingSource
    Friend WithEvents colDaysBefore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colMeesageText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSendTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
