<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampaign
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
        Me.grdCampaign = New Core.UI.CoreGrid
        Me.bndCampaign = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwCamiaign = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSelected = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNameForPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValidFrom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValidTo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colCreateUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCreateDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnOpen = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        CType(Me.grdCampaign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndCampaign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwCamiaign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdCampaign
        '
        Me.grdCampaign.DataSource = Me.bndCampaign
        Me.grdCampaign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCampaign.EmbeddedNavigator.Name = ""
        Me.grdCampaign.EnforceCanEdit = False
        Me.grdCampaign.Location = New System.Drawing.Point(0, 0)
        Me.grdCampaign.MainView = Me.gvwCamiaign
        Me.grdCampaign.Name = "grdCampaign"
        Me.grdCampaign.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1})
        Me.grdCampaign.ShowOnlyActive = False
        Me.grdCampaign.Size = New System.Drawing.Size(992, 407)
        Me.grdCampaign.TabIndex = 1
        Me.grdCampaign.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwCamiaign, Me.GridView2})
        '
        'bndCampaign
        '
        Me.bndCampaign.DataSource = GetType(Entities.Campaign)
        '
        'gvwCamiaign
        '
        Me.gvwCamiaign.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSelected, Me.colCode, Me.colName, Me.colNameForPrint, Me.colValidFrom, Me.colValidTo, Me.colDiscount, Me.colComment, Me.colCreateUser, Me.colCreateDate})
        Me.gvwCamiaign.GridControl = Me.grdCampaign
        Me.gvwCamiaign.Name = "gvwCamiaign"
        Me.gvwCamiaign.OptionsView.ColumnAutoWidth = False
        Me.gvwCamiaign.OptionsView.ShowDetailButtons = False
        Me.gvwCamiaign.OptionsView.ShowFilterPanel = False
        Me.gvwCamiaign.OptionsView.ShowGroupPanel = False
        '
        'colSelected
        '
        Me.colSelected.Caption = "Atzīmēt"
        Me.colSelected.FieldName = "Selected"
        Me.colSelected.Name = "colSelected"
        Me.colSelected.Visible = True
        Me.colSelected.VisibleIndex = 0
        Me.colSelected.Width = 58
        '
        'colCode
        '
        Me.colCode.Caption = "Kods"
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.OptionsColumn.AllowEdit = False
        Me.colCode.OptionsColumn.ReadOnly = True
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 1
        Me.colCode.Width = 42
        '
        'colName
        '
        Me.colName.Caption = "Nosaukums"
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.OptionsColumn.AllowEdit = False
        Me.colName.OptionsColumn.ReadOnly = True
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 2
        Me.colName.Width = 101
        '
        'colNameForPrint
        '
        Me.colNameForPrint.Caption = "Nosaukums izdrukai"
        Me.colNameForPrint.FieldName = "NameForPrint"
        Me.colNameForPrint.Name = "colNameForPrint"
        Me.colNameForPrint.OptionsColumn.AllowEdit = False
        Me.colNameForPrint.OptionsColumn.ReadOnly = True
        Me.colNameForPrint.Visible = True
        Me.colNameForPrint.VisibleIndex = 3
        Me.colNameForPrint.Width = 153
        '
        'colValidFrom
        '
        Me.colValidFrom.Caption = "Spēkā no"
        Me.colValidFrom.DisplayFormat.FormatString = "d"
        Me.colValidFrom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colValidFrom.FieldName = "ValidFrom"
        Me.colValidFrom.Name = "colValidFrom"
        Me.colValidFrom.OptionsColumn.AllowEdit = False
        Me.colValidFrom.OptionsColumn.ReadOnly = True
        Me.colValidFrom.Visible = True
        Me.colValidFrom.VisibleIndex = 4
        '
        'colValidTo
        '
        Me.colValidTo.Caption = "Spēkā līdz"
        Me.colValidTo.DisplayFormat.FormatString = "d"
        Me.colValidTo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colValidTo.FieldName = "ValidTo"
        Me.colValidTo.Name = "colValidTo"
        Me.colValidTo.OptionsColumn.AllowEdit = False
        Me.colValidTo.OptionsColumn.ReadOnly = True
        Me.colValidTo.Visible = True
        Me.colValidTo.VisibleIndex = 5
        '
        'colDiscount
        '
        Me.colDiscount.Caption = "Atlaide %"
        Me.colDiscount.DisplayFormat.FormatString = "n0"
        Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiscount.FieldName = "Discount"
        Me.colDiscount.Name = "colDiscount"
        Me.colDiscount.OptionsColumn.AllowEdit = False
        Me.colDiscount.OptionsColumn.ReadOnly = True
        Me.colDiscount.Visible = True
        Me.colDiscount.VisibleIndex = 6
        Me.colDiscount.Width = 66
        '
        'colComment
        '
        Me.colComment.Caption = "Piezīmes"
        Me.colComment.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.colComment.FieldName = "Comment"
        Me.colComment.Name = "colComment"
        Me.colComment.OptionsColumn.AllowEdit = False
        Me.colComment.OptionsColumn.ReadOnly = True
        Me.colComment.Visible = True
        Me.colComment.VisibleIndex = 7
        Me.colComment.Width = 96
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'colCreateUser
        '
        Me.colCreateUser.Caption = "Izveidoja"
        Me.colCreateUser.FieldName = "CreateUser"
        Me.colCreateUser.Name = "colCreateUser"
        Me.colCreateUser.OptionsColumn.AllowEdit = False
        Me.colCreateUser.OptionsColumn.ReadOnly = True
        Me.colCreateUser.Visible = True
        Me.colCreateUser.VisibleIndex = 8
        Me.colCreateUser.Width = 106
        '
        'colCreateDate
        '
        Me.colCreateDate.Caption = "Izveides datums"
        Me.colCreateDate.DisplayFormat.FormatString = "d"
        Me.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCreateDate.FieldName = "CreateDate"
        Me.colCreateDate.Name = "colCreateDate"
        Me.colCreateDate.OptionsColumn.AllowEdit = False
        Me.colCreateDate.OptionsColumn.ReadOnly = True
        Me.colCreateDate.Visible = True
        Me.colCreateDate.VisibleIndex = 9
        Me.colCreateDate.Width = 97
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grdCampaign
        Me.GridView2.Name = "GridView2"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(483, 30)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(405, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 407)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(992, 30)
        Me.SplitContainer1.SplitterDistance = 505
        Me.SplitContainer1.TabIndex = 3
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOpen)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOk)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(505, 30)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(3, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(84, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Pievienot"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(165, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Dzēst"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(246, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Labi"
        Me.btnOk.UseVisualStyleBackColor = True
        Me.btnOk.Visible = False
        '
        'frmCampaign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 437)
        Me.Controls.Add(Me.grdCampaign)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmCampaign"
        Me.Text = "Akcijas"
        CType(Me.grdCampaign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndCampaign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwCamiaign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdCampaign As Core.UI.CoreGrid
    Friend WithEvents gvwCamiaign As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents bndCampaign As System.Windows.Forms.BindingSource
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNameForPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents colSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
