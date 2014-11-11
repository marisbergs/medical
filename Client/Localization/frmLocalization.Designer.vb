<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalization
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRenefreshControlList = New System.Windows.Forms.Button()
        Me.CoreGrid1 = New Core.UI.CoreGrid()
        Me.LocalizationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colForma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLabels = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.labosana = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colRus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEng = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.CoreGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalizationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labosana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnRenefreshControlList)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 273)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(984, 29)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(906, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(825, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRenefreshControlList
        '
        Me.btnRenefreshControlList.AutoSize = True
        Me.btnRenefreshControlList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRenefreshControlList.Location = New System.Drawing.Point(720, 3)
        Me.btnRenefreshControlList.Name = "btnRenefreshControlList"
        Me.btnRenefreshControlList.Size = New System.Drawing.Size(99, 23)
        Me.btnRenefreshControlList.TabIndex = 2
        Me.btnRenefreshControlList.Text = "Atjaunot sarakstu"
        Me.btnRenefreshControlList.UseVisualStyleBackColor = True
        '
        'CoreGrid1
        '
        Me.CoreGrid1.DataSource = Me.LocalizationBindingSource
        Me.CoreGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.CoreGrid1.EmbeddedNavigator.Name = ""
        Me.CoreGrid1.EnforceCanEdit = False
        Me.CoreGrid1.Location = New System.Drawing.Point(0, 0)
        Me.CoreGrid1.MainView = Me.GridView1
        Me.CoreGrid1.Name = "CoreGrid1"
        Me.CoreGrid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.labosana})
        Me.CoreGrid1.ShowOnlyActive = False
        Me.CoreGrid1.Size = New System.Drawing.Size(984, 273)
        Me.CoreGrid1.TabIndex = 1
        Me.CoreGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'LocalizationBindingSource
        '
        Me.LocalizationBindingSource.DataSource = GetType(Entities.Localization)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colForma, Me.colLabels, Me.colLv, Me.colRus, Me.colEng})
        Me.GridView1.GridControl = Me.CoreGrid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colForma
        '
        Me.colForma.Caption = "Forma"
        Me.colForma.FieldName = "Forma"
        Me.colForma.Name = "colForma"
        '
        'colLabels
        '
        Me.colLabels.Caption = "Labels"
        Me.colLabels.FieldName = "Labels"
        Me.colLabels.Name = "colLabels"
        '
        'colLv
        '
        Me.colLv.Caption = "Lvl"
        Me.colLv.ColumnEdit = Me.labosana
        Me.colLv.FieldName = "Lv"
        Me.colLv.Name = "colLv"
        Me.colLv.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLv.Visible = True
        Me.colLv.VisibleIndex = 0
        '
        'labosana
        '
        Me.labosana.AutoHeight = False
        Me.labosana.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.labosana.MaxLength = 1000
        Me.labosana.Name = "labosana"
        Me.labosana.ShowIcon = False
        '
        'colRus
        '
        Me.colRus.Caption = "Rus"
        Me.colRus.ColumnEdit = Me.labosana
        Me.colRus.FieldName = "Rus"
        Me.colRus.Name = "colRus"
        Me.colRus.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colRus.Visible = True
        Me.colRus.VisibleIndex = 1
        '
        'colEng
        '
        Me.colEng.Caption = "Eng"
        Me.colEng.ColumnEdit = Me.labosana
        Me.colEng.FieldName = "Eng"
        Me.colEng.Name = "colEng"
        Me.colEng.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colEng.Visible = True
        Me.colEng.VisibleIndex = 2
        '
        'frmLocalization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(984, 302)
        Me.Controls.Add(Me.CoreGrid1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(1000, 340)
        Me.Name = "frmLocalization"
        Me.Text = "Tulkojumi"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.CoreGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalizationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labosana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRenefreshControlList As System.Windows.Forms.Button
    Friend WithEvents CoreGrid1 As Core.UI.CoreGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LocalizationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colForma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLabels As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEng As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents labosana As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit

End Class
