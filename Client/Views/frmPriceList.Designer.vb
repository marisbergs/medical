<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceList
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.CtlUserServicesFinder1 = New Client.ctlUserServicesFinder()
        Me.grdData = New Core.UI.CoreGrid()
        Me.gvwData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 447)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(895, 29)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(817, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(736, 3)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "Eksportēt"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'CtlUserServicesFinder1
        '
        Me.CtlUserServicesFinder1.AutoSize = True
        Me.CtlUserServicesFinder1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CtlUserServicesFinder1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUserServicesFinder1.Location = New System.Drawing.Point(0, 0)
        Me.CtlUserServicesFinder1.MinimumSize = New System.Drawing.Size(200, 0)
        Me.CtlUserServicesFinder1.Name = "CtlUserServicesFinder1"
        Me.CtlUserServicesFinder1.Size = New System.Drawing.Size(895, 186)
        Me.CtlUserServicesFinder1.TabIndex = 0
        Me.CtlUserServicesFinder1.Tag = "True"
        '
        'grdData
        '
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdData.EmbeddedNavigator.Name = ""
        Me.grdData.EnforceCanEdit = False
        Me.grdData.Location = New System.Drawing.Point(0, 186)
        Me.grdData.MainView = Me.gvwData
        Me.grdData.Name = "grdData"
        Me.grdData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.grdData.ShowOnlyActive = False
        Me.grdData.Size = New System.Drawing.Size(895, 261)
        Me.grdData.TabIndex = 2
        Me.grdData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwData})
        '
        'gvwData
        '
        Me.gvwData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.gvwData.GridControl = Me.grdData
        Me.gvwData.Name = "gvwData"
        Me.gvwData.OptionsBehavior.Editable = False
        Me.gvwData.OptionsDetail.EnableMasterViewMode = False
        Me.gvwData.OptionsDetail.ShowDetailTabs = False
        Me.gvwData.OptionsView.AllowCellMerge = True
        Me.gvwData.OptionsView.ColumnAutoWidth = False
        Me.gvwData.OptionsView.ShowFilterPanel = False
        Me.gvwData.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Specialitāte / Pakalpojums"
        Me.GridColumn1.FieldName = "colSpeciality"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 227
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ârsts"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GridColumn2.FieldName = "colUser"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 179
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        Me.RepositoryItemMemoEdit1.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Pakalpojums"
        Me.GridColumn3.FieldName = "colService"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 285
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cena"
        Me.GridColumn4.FieldName = "colPrice"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Vizītes ilgums"
        Me.GridColumn5.FieldName = "colTime"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'frmPriceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(895, 476)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.CtlUserServicesFinder1)
        Me.Name = "frmPriceList"
        Me.Text = "Pakalpojumu cenu lapa"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtlUserServicesFinder1 As Client.ctlUserServicesFinder
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents grdData As Core.UI.CoreGrid
    Friend WithEvents gvwData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

End Class
