<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassifierTypeList
    Inherits Client.frmUIBase
    'žо

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
        Me.colKind = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdClassifierTypeList = New Core.UI.CoreGrid
        Me.bndClassifierType = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnOpen = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.ToolTip1 = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.grdClassifierTypeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndClassifierType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'colKind
        '
        Me.colKind.Caption = "Veids"
        Me.colKind.FieldName = "Kind"
        Me.colKind.Name = "colKind"
        Me.colKind.Visible = True
        Me.colKind.VisibleIndex = 1
        Me.colKind.Width = 144
        '
        'grdClassifierTypeList
        '
        Me.grdClassifierTypeList.DataSource = Me.bndClassifierType
        Me.grdClassifierTypeList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdClassifierTypeList.EmbeddedNavigator.Name = ""
        Me.grdClassifierTypeList.EnforceCanEdit = False
        Me.grdClassifierTypeList.Location = New System.Drawing.Point(0, 0)
        Me.grdClassifierTypeList.MainView = Me.GridView1
        Me.grdClassifierTypeList.Name = "grdClassifierTypeList"
        Me.grdClassifierTypeList.ShowOnlyActive = False
        Me.grdClassifierTypeList.Size = New System.Drawing.Size(392, 362)
        Me.grdClassifierTypeList.TabIndex = 0
        Me.grdClassifierTypeList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bndClassifierType
        '
        Me.bndClassifierType.DataSource = GetType(Entities.ClassifierType)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colValue, Me.colKind})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colKind
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = 1
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.grdClassifierTypeList
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.PaintStyleName = "WindowsXP"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colValue, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colValue
        '
        Me.colValue.Caption = "Nosaukums"
        Me.colValue.FieldName = "Value"
        Me.colValue.Name = "colValue"
        Me.colValue.OptionsColumn.AllowEdit = False
        Me.colValue.OptionsColumn.AllowFocus = False
        Me.colValue.Visible = True
        Me.colValue.VisibleIndex = 0
        Me.colValue.Width = 246
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(184, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(208, 30)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(130, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(3, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 362)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 30)
        Me.Panel1.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOpen)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(184, 30)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'frmClassifierTypeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 392)
        Me.Controls.Add(Me.grdClassifierTypeList)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(400, 426)
        Me.Name = "frmClassifierTypeList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Klasifikatoru saraksts"
        CType(Me.grdClassifierTypeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndClassifierType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdClassifierTypeList As Core.UI.CoreGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents bndClassifierType As System.Windows.Forms.BindingSource
    Friend WithEvents colValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolTip1 As DevExpress.Utils.ToolTipController
    Friend WithEvents colKind As DevExpress.XtraGrid.Columns.GridColumn
End Class
