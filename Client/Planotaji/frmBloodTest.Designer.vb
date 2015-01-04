<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBloodTest
    Inherits Core.frmBase

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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tabBloodTest = New System.Windows.Forms.TabControl()
        Me.pageMain = New System.Windows.Forms.TabPage()
        Me.bndVisitBloadTest = New System.Windows.Forms.BindingSource(Me.components)
        Me.pageBloodTestGrid = New System.Windows.Forms.TabPage()
        Me.CoreGrid1 = New Core.UI.CoreGrid()
        Me.bndBloodTestGroups = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkSelect = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDecimalValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.tabBloodTest.SuspendLayout()
        Me.pageMain.SuspendLayout()
        CType(Me.bndVisitBloadTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageBloodTestGrid.SuspendLayout()
        CType(Me.CoreGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndBloodTestGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 314)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(947, 30)
        Me.SplitContainer1.SplitterDistance = 576
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(576, 30)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Summa kopā:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(367, 30)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(289, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Aizvērt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Saglabāt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(127, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Izdruka"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tabBloodTest
        '
        Me.tabBloodTest.Controls.Add(Me.pageMain)
        Me.tabBloodTest.Controls.Add(Me.pageBloodTestGrid)
        Me.tabBloodTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabBloodTest.Location = New System.Drawing.Point(0, 0)
        Me.tabBloodTest.Multiline = True
        Me.tabBloodTest.Name = "tabBloodTest"
        Me.tabBloodTest.SelectedIndex = 0
        Me.tabBloodTest.Size = New System.Drawing.Size(947, 314)
        Me.tabBloodTest.TabIndex = 1
        '
        'pageMain
        '
        Me.pageMain.Controls.Add(Me.ListBox1)
        Me.pageMain.Location = New System.Drawing.Point(4, 22)
        Me.pageMain.Name = "pageMain"
        Me.pageMain.Padding = New System.Windows.Forms.Padding(3)
        Me.pageMain.Size = New System.Drawing.Size(939, 288)
        Me.pageMain.TabIndex = 0
        Me.pageMain.Text = "Nozīmētās asins analīzes"
        Me.pageMain.UseVisualStyleBackColor = True
        '
        'bndVisitBloadTest
        '
        Me.bndVisitBloadTest.DataSource = GetType(Entities.BloodTest)
        '
        'pageBloodTestGrid
        '
        Me.pageBloodTestGrid.Controls.Add(Me.CoreGrid1)
        Me.pageBloodTestGrid.Location = New System.Drawing.Point(4, 22)
        Me.pageBloodTestGrid.Name = "pageBloodTestGrid"
        Me.pageBloodTestGrid.Padding = New System.Windows.Forms.Padding(3)
        Me.pageBloodTestGrid.Size = New System.Drawing.Size(939, 288)
        Me.pageBloodTestGrid.TabIndex = 1
        Me.pageBloodTestGrid.Text = "Nozīmēt analīzes"
        Me.pageBloodTestGrid.UseVisualStyleBackColor = True
        '
        'CoreGrid1
        '
        Me.CoreGrid1.DataSource = Me.bndBloodTestGroups
        Me.CoreGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.CoreGrid1.EmbeddedNavigator.Name = ""
        Me.CoreGrid1.EnforceCanEdit = False
        Me.CoreGrid1.Location = New System.Drawing.Point(3, 3)
        Me.CoreGrid1.MainView = Me.GridView1
        Me.CoreGrid1.Name = "CoreGrid1"
        Me.CoreGrid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSelect})
        Me.CoreGrid1.ShowOnlyActive = False
        Me.CoreGrid1.Size = New System.Drawing.Size(933, 282)
        Me.CoreGrid1.TabIndex = 0
        Me.CoreGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bndBloodTestGroups
        '
        Me.bndBloodTestGroups.DataSource = GetType(Entities.BloodTest)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSelected, Me.colCode, Me.colName, Me.colDecimalValue, Me.colGroup})
        Me.GridView1.GridControl = Me.CoreGrid1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGroup, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSelected
        '
        Me.colSelected.Caption = "Atzīmēt"
        Me.colSelected.ColumnEdit = Me.chkSelect
        Me.colSelected.FieldName = "Selected"
        Me.colSelected.Name = "colSelected"
        Me.colSelected.Visible = True
        Me.colSelected.VisibleIndex = 0
        Me.colSelected.Width = 58
        '
        'chkSelect
        '
        Me.chkSelect.AutoHeight = False
        Me.chkSelect.Name = "chkSelect"
        '
        'colCode
        '
        Me.colCode.Caption = "Kods"
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.OptionsColumn.AllowEdit = False
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 1
        Me.colCode.Width = 48
        '
        'colName
        '
        Me.colName.Caption = "Nosaukums"
        Me.colName.FieldName = "Value"
        Me.colName.Name = "colName"
        Me.colName.OptionsColumn.AllowEdit = False
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 2
        Me.colName.Width = 403
        '
        'colDecimalValue
        '
        Me.colDecimalValue.Caption = "Cena"
        Me.colDecimalValue.FieldName = "DecimalValue"
        Me.colDecimalValue.Name = "colDecimalValue"
        Me.colDecimalValue.OptionsColumn.AllowEdit = False
        Me.colDecimalValue.Visible = True
        Me.colDecimalValue.VisibleIndex = 3
        Me.colDecimalValue.Width = 403
        '
        'colGroup
        '
        Me.colGroup.FieldName = "Reference"
        Me.colGroup.Name = "colGroup"
        Me.colGroup.OptionsColumn.AllowEdit = False
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.bndVisitBloadTest
        Me.ListBox1.DisplayMember = "Code"
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(933, 282)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "Object"
        '
        'frmBloodTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(947, 344)
        Me.Controls.Add(Me.tabBloodTest)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmBloodTest"
        Me.Text = "Asins analīzes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.tabBloodTest.ResumeLayout(False)
        Me.pageMain.ResumeLayout(False)
        CType(Me.bndVisitBloadTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageBloodTestGrid.ResumeLayout(False)
        CType(Me.CoreGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndBloodTestGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tabBloodTest As System.Windows.Forms.TabControl
    Friend WithEvents pageMain As System.Windows.Forms.TabPage
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pageBloodTestGrid As System.Windows.Forms.TabPage
    Friend WithEvents CoreGrid1 As Core.UI.CoreGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bndBloodTestGroups As System.Windows.Forms.BindingSource
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDecimalValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkSelect As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents bndVisitBloadTest As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
