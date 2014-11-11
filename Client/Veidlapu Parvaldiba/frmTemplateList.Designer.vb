<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemplateList
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemplateList))
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdTemplateList = New Core.UI.CoreGrid
        Me.bindTemplate = New System.Windows.Forms.BindingSource(Me.components)
        Me.vwMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValidUntil = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValidFrom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gbhTemplateList = New Core.UI.GridButtonHelper
        Me.btnSaveAll = New System.Windows.Forms.Button
        Me.panButtonClose = New System.Windows.Forms.Panel
        Me.panButtonOpen = New System.Windows.Forms.Panel
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.grdTemplateList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vwMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panButtonClose.SuspendLayout()
        Me.panButtonOpen.SuspendLayout()
        Me.SuspendLayout()
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        Me.colIsActive.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colIsActive.OptionsFilter.AllowAutoFilter = False
        Me.colIsActive.OptionsFilter.AllowFilter = False
        '
        'grdTemplateList
        '
        Me.grdTemplateList.DataSource = Me.bindTemplate
        Me.grdTemplateList.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdTemplateList.EmbeddedNavigator.Name = ""
        Me.grdTemplateList.EnforceCanEdit = False
        GridLevelNode1.RelationName = "Level1"
        Me.grdTemplateList.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdTemplateList.Location = New System.Drawing.Point(0, 31)
        Me.grdTemplateList.MainView = Me.vwMain
        Me.grdTemplateList.Name = "grdTemplateList"
        RepositoryItemTextEdit1.AutoHeight = False
        RepositoryItemTextEdit1.Mask.EditMask = "###########,##0.00"
        RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        RepositoryItemTextEdit1.Mask.ShowPlaceHolders = False
        RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.grdTemplateList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {RepositoryItemTextEdit1, Me.RepositoryItemGridLookUpEdit1})
        Me.grdTemplateList.ShowOnlyActive = False
        Me.grdTemplateList.Size = New System.Drawing.Size(556, 422)
        Me.grdTemplateList.TabIndex = 0
        Me.grdTemplateList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vwMain})
        '
        'bindTemplate
        '
        Me.bindTemplate.DataSource = GetType(Entities.Template)
        '
        'vwMain
        '
        Me.vwMain.Appearance.GroupRow.BackColor = System.Drawing.SystemColors.Window
        Me.vwMain.Appearance.GroupRow.Options.UseBackColor = True
        Me.vwMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colValidUntil, Me.colDescription, Me.colName, Me.colValidFrom, Me.colType, Me.colIsActive})
        Me.vwMain.GridControl = Me.grdTemplateList
        Me.vwMain.GroupCount = 1
        Me.vwMain.GroupFormat = "[#image]{1} {2}"
        Me.vwMain.MRUFilters.Add(CType(resources.GetObject("vwMain.MRUFilters"), DevExpress.XtraGrid.Views.Base.ViewFilter))
        Me.vwMain.Name = "vwMain"
        Me.vwMain.OptionsBehavior.AutoExpandAllGroups = True
        Me.vwMain.OptionsBehavior.Editable = False
        Me.vwMain.OptionsDetail.EnableMasterViewMode = False
        Me.vwMain.OptionsView.ColumnAutoWidth = False
        Me.vwMain.OptionsView.ShowDetailButtons = False
        Me.vwMain.OptionsView.ShowFilterPanel = False
        Me.vwMain.OptionsView.ShowGroupPanel = False
        Me.vwMain.OptionsView.ShowIndicator = False
        Me.vwMain.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colType, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCode
        '
        Me.colCode.Caption = "Kods"
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.OptionsColumn.AllowFocus = False
        Me.colCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        Me.colCode.Width = 99
        '
        'colValidUntil
        '
        Me.colValidUntil.Caption = "Slēgšanas datums"
        Me.colValidUntil.DisplayFormat.FormatString = "d"
        Me.colValidUntil.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colValidUntil.FieldName = "ValidUntil"
        Me.colValidUntil.Name = "colValidUntil"
        Me.colValidUntil.OptionsColumn.AllowFocus = False
        Me.colValidUntil.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colValidUntil.OptionsFilter.AllowAutoFilter = False
        Me.colValidUntil.OptionsFilter.AllowFilter = False
        Me.colValidUntil.Visible = True
        Me.colValidUntil.VisibleIndex = 4
        '
        'colDescription
        '
        Me.colDescription.Caption = "Apraksts"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowFocus = False
        Me.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDescription.OptionsFilter.AllowAutoFilter = False
        Me.colDescription.OptionsFilter.AllowFilter = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        Me.colDescription.Width = 103
        '
        'colName
        '
        Me.colName.Caption = "Nosaukums"
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.OptionsColumn.AllowFocus = False
        Me.colName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colName.OptionsFilter.AllowAutoFilter = False
        Me.colName.OptionsFilter.AllowFilter = False
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        Me.colName.Width = 197
        '
        'colValidFrom
        '
        Me.colValidFrom.Caption = "Izveidošanas datums"
        Me.colValidFrom.DisplayFormat.FormatString = "d"
        Me.colValidFrom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colValidFrom.FieldName = "ValidFrom"
        Me.colValidFrom.Name = "colValidFrom"
        Me.colValidFrom.OptionsColumn.AllowFocus = False
        Me.colValidFrom.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colValidFrom.OptionsFilter.AllowAutoFilter = False
        Me.colValidFrom.OptionsFilter.AllowFilter = False
        Me.colValidFrom.Visible = True
        Me.colValidFrom.VisibleIndex = 3
        '
        'colType
        '
        Me.colType.Caption = "Veidlapas tips"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colType.OptionsFilter.AllowAutoFilter = False
        Me.colType.OptionsFilter.AllowFilter = False
        Me.colType.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'gbhTemplateList
        '
        Me.gbhTemplateList.DeleteReason = False
        Me.gbhTemplateList.DeleteReasonColumn = Nothing
        Me.gbhTemplateList.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhTemplateList.Grid = Me.grdTemplateList
        Me.gbhTemplateList.GridDataSource = Me.bindTemplate
        Me.gbhTemplateList.Location = New System.Drawing.Point(0, 0)
        Me.gbhTemplateList.Name = "gbhTemplateList"
        Me.gbhTemplateList.ShowActive = False
        Me.gbhTemplateList.ShowAdd = True
        Me.gbhTemplateList.ShowChk = True
        Me.gbhTemplateList.ShowDelete = True
        Me.gbhTemplateList.Size = New System.Drawing.Size(556, 31)
        Me.gbhTemplateList.TabIndex = 2
        '
        'btnSaveAll
        '
        Me.btnSaveAll.Location = New System.Drawing.Point(478, 3)
        Me.btnSaveAll.Name = "btnSaveAll"
        Me.btnSaveAll.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveAll.TabIndex = 1
        Me.btnSaveAll.Text = "Aizvērt"
        Me.btnSaveAll.UseVisualStyleBackColor = True
        '
        'panButtonClose
        '
        Me.panButtonClose.Controls.Add(Me.panButtonOpen)
        Me.panButtonClose.Controls.Add(Me.btnClose)
        Me.panButtonClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panButtonClose.Location = New System.Drawing.Point(0, 453)
        Me.panButtonClose.Name = "panButtonClose"
        Me.panButtonClose.Size = New System.Drawing.Size(556, 32)
        Me.panButtonClose.TabIndex = 4
        '
        'panButtonOpen
        '
        Me.panButtonOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panButtonOpen.Controls.Add(Me.btnEdit)
        Me.panButtonOpen.Location = New System.Drawing.Point(0, 0)
        Me.panButtonOpen.Name = "panButtonOpen"
        Me.panButtonOpen.Size = New System.Drawing.Size(82, 32)
        Me.panButtonOpen.TabIndex = 3
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Atvērt"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(478, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmTemplateList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 485)
        Me.Controls.Add(Me.grdTemplateList)
        Me.Controls.Add(Me.panButtonClose)
        Me.Controls.Add(Me.gbhTemplateList)
        Me.MinimumSize = New System.Drawing.Size(564, 519)
        Me.Name = "frmTemplateList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Veidlapu saraksts"
        CType(RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTemplateList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vwMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panButtonClose.ResumeLayout(False)
        Me.panButtonOpen.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bindTemplate As System.Windows.Forms.BindingSource
    Friend WithEvents vwMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidUntil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdTemplateList As Core.UI.CoreGrid
    Friend WithEvents gbhTemplateList As Core.UI.GridButtonHelper
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSaveAll As System.Windows.Forms.Button
    Friend WithEvents panButtonClose As System.Windows.Forms.Panel
    Friend WithEvents panButtonOpen As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
