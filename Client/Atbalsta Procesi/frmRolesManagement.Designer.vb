<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRolesManagement
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition8 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition9 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition10 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition11 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.grdRoles = New Core.UI.CoreGrid
        Me.bndRole = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtRoleName = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCopy = New System.Windows.Forms.Button
        Me.gbhRolePermision = New Core.UI.GridButtonHelper
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grdPermissions = New Core.UI.CoreGrid
        Me.bndPermissions = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSelected = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnCance = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoleName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdPermissions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndPermissions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "Aktīvs"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(772, 474)
        Me.SplitContainer1.SplitterDistance = 349
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdRoles)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 474)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lomas"
        '
        'grdRoles
        '
        Me.grdRoles.DataSource = Me.bndRole
        Me.grdRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRoles.EmbeddedNavigator.Name = ""
        Me.grdRoles.EnforceCanEdit = False
        Me.grdRoles.Location = New System.Drawing.Point(3, 48)
        Me.grdRoles.MainView = Me.GridView1
        Me.grdRoles.Name = "grdRoles"
        Me.grdRoles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtRoleName})
        Me.grdRoles.ShowOnlyActive = False
        Me.grdRoles.Size = New System.Drawing.Size(343, 423)
        Me.grdRoles.TabIndex = 0
        Me.grdRoles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bndRole
        '
        Me.bndRole.DataSource = GetType(Entities.Role)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIsActive, Me.colName})
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colIsActive
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = False
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colIsActive
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = False
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colIsActive
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = False
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colIsActive
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = False
        StyleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition5.Appearance.Options.UseForeColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.colIsActive
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Value1 = False
        StyleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition6.Appearance.Options.UseForeColor = True
        StyleFormatCondition6.ApplyToRow = True
        StyleFormatCondition6.Column = Me.colIsActive
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition6.Value1 = False
        StyleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition7.Appearance.Options.UseForeColor = True
        StyleFormatCondition7.ApplyToRow = True
        StyleFormatCondition7.Column = Me.colIsActive
        StyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition7.Value1 = False
        StyleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition8.Appearance.Options.UseForeColor = True
        StyleFormatCondition8.ApplyToRow = True
        StyleFormatCondition8.Column = Me.colIsActive
        StyleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition8.Value1 = False
        StyleFormatCondition9.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition9.Appearance.Options.UseForeColor = True
        StyleFormatCondition9.ApplyToRow = True
        StyleFormatCondition9.Column = Me.colIsActive
        StyleFormatCondition9.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition9.Value1 = False
        StyleFormatCondition10.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition10.Appearance.Options.UseForeColor = True
        StyleFormatCondition10.ApplyToRow = True
        StyleFormatCondition10.Column = Me.colIsActive
        StyleFormatCondition10.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition10.Value1 = False
        StyleFormatCondition11.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition11.Appearance.Options.UseForeColor = True
        StyleFormatCondition11.ApplyToRow = True
        StyleFormatCondition11.Column = Me.colIsActive
        StyleFormatCondition11.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition11.Value1 = False
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5, StyleFormatCondition6, StyleFormatCondition7, StyleFormatCondition8, StyleFormatCondition9, StyleFormatCondition10, StyleFormatCondition11})
        Me.GridView1.GridControl = Me.grdRoles
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colName
        '
        Me.colName.Caption = "Lomas nosaukums"
        Me.colName.ColumnEdit = Me.txtRoleName
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'txtRoleName
        '
        Me.txtRoleName.AutoHeight = False
        Me.txtRoleName.MaxLength = 50
        Me.txtRoleName.Name = "txtRoleName"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCopy)
        Me.Panel1.Controls.Add(Me.gbhRolePermision)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 32)
        Me.Panel1.TabIndex = 2
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(3, 3)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 1
        Me.btnCopy.Text = "Kopēt"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'gbhRolePermision
        '
        Me.gbhRolePermision.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbhRolePermision.DeleteReason = False
        Me.gbhRolePermision.DeleteReasonColumn = Nothing
        Me.gbhRolePermision.Grid = Me.grdRoles
        Me.gbhRolePermision.GridDataSource = Me.bndRole
        Me.gbhRolePermision.Location = New System.Drawing.Point(84, 0)
        Me.gbhRolePermision.Name = "gbhRolePermision"
        Me.gbhRolePermision.ShowActive = False
        Me.gbhRolePermision.ShowAdd = True
        Me.gbhRolePermision.ShowChk = True
        Me.gbhRolePermision.ShowDelete = True
        Me.gbhRolePermision.Size = New System.Drawing.Size(259, 26)
        Me.gbhRolePermision.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdPermissions)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 474)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lomas tiesības"
        '
        'grdPermissions
        '
        Me.grdPermissions.DataSource = Me.bndPermissions
        Me.grdPermissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPermissions.EmbeddedNavigator.Name = ""
        Me.grdPermissions.EnforceCanEdit = False
        Me.grdPermissions.Location = New System.Drawing.Point(3, 16)
        Me.grdPermissions.MainView = Me.GridView2
        Me.grdPermissions.Name = "grdPermissions"
        Me.grdPermissions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit})
        Me.grdPermissions.ShowOnlyActive = False
        Me.grdPermissions.Size = New System.Drawing.Size(413, 455)
        Me.grdPermissions.TabIndex = 0
        Me.grdPermissions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bndPermissions
        '
        Me.bndPermissions.AllowNew = False
        Me.bndPermissions.DataSource = GetType(Entities.Permission)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSelected, Me.colDescription})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(540, 474, 208, 156)
        Me.GridView2.GridControl = Me.grdPermissions
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsDetail.EnableMasterViewMode = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDescription, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSelected
        '
        Me.colSelected.AppearanceCell.Options.UseTextOptions = True
        Me.colSelected.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSelected.AppearanceHeader.Options.UseTextOptions = True
        Me.colSelected.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSelected.Caption = "Ir"
        Me.colSelected.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colSelected.FieldName = "Selected"
        Me.colSelected.Name = "colSelected"
        Me.colSelected.Visible = True
        Me.colSelected.VisibleIndex = 0
        Me.colSelected.Width = 30
        '
        'RepositoryItemCheckEdit
        '
        Me.RepositoryItemCheckEdit.AutoHeight = False
        Me.RepositoryItemCheckEdit.Name = "RepositoryItemCheckEdit"
        '
        'colDescription
        '
        Me.colDescription.Caption = "Tiesības apraksts"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.OptionsColumn.AllowFocus = False
        Me.colDescription.OptionsColumn.ReadOnly = True
        Me.colDescription.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 255
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 474)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 31)
        Me.Panel2.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(694, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Aizvērt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(613, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(537, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Aizvērt"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnCance
        '
        Me.btnCance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCance.Location = New System.Drawing.Point(537, 5)
        Me.btnCance.Name = "btnCance"
        Me.btnCance.Size = New System.Drawing.Size(75, 23)
        Me.btnCance.TabIndex = 1
        Me.btnCance.Text = "Aizvērt"
        Me.btnCance.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(456, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Saglabāt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.DataSource = Me.bndRole
        '
        'frmRolesManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 505)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmRolesManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lomu administrēšana"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoleName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdPermissions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndPermissions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grdRoles As Core.UI.CoreGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbhRolePermision As Core.UI.GridButtonHelper
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bndRole As System.Windows.Forms.BindingSource
    Friend WithEvents grdPermissions As Core.UI.CoreGrid
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnCance As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Private WithEvents bndPermissions As System.Windows.Forms.BindingSource
    Friend WithEvents colSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRoleName As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
