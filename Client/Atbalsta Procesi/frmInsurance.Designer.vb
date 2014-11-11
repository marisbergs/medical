<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsurance
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbInsuranceCompany = New DevExpress.XtraEditors.LookUpEdit
        Me.bndInsuranceCompany = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridButtonHelper1 = New Core.UI.GridButtonHelper
        Me.grdData = New Core.UI.CoreGrid
        Me.gvwData = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.bandService = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colServiceCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colServiceName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colServiceDefaultPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.cmbInsuranceCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndInsuranceCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbInsuranceCompany)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 31)
        Me.Panel1.TabIndex = 0
        '
        'cmbInsuranceCompany
        '
        Me.cmbInsuranceCompany.Location = New System.Drawing.Point(91, 5)
        Me.cmbInsuranceCompany.Name = "cmbInsuranceCompany"
        Me.cmbInsuranceCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbInsuranceCompany.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Apdrošinātājs", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbInsuranceCompany.Properties.DataSource = Me.bndInsuranceCompany
        Me.cmbInsuranceCompany.Properties.DisplayMember = "Value"
        Me.cmbInsuranceCompany.Properties.ValueMember = "Id"
        Me.cmbInsuranceCompany.Size = New System.Drawing.Size(287, 20)
        Me.cmbInsuranceCompany.TabIndex = 1
        '
        'bndInsuranceCompany
        '
        Me.bndInsuranceCompany.DataSource = GetType(Entities.HierClassifier)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apdrošinātājs:"
        '
        'GridButtonHelper1
        '
        Me.GridButtonHelper1.AutoSize = True
        Me.GridButtonHelper1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GridButtonHelper1.DeleteReason = False
        Me.GridButtonHelper1.DeleteReasonColumn = Nothing
        Me.GridButtonHelper1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridButtonHelper1.Grid = Nothing
        Me.GridButtonHelper1.GridDataSource = Nothing
        Me.GridButtonHelper1.Location = New System.Drawing.Point(0, 31)
        Me.GridButtonHelper1.Name = "GridButtonHelper1"
        Me.GridButtonHelper1.ShowActive = False
        Me.GridButtonHelper1.ShowAdd = True
        Me.GridButtonHelper1.ShowChk = True
        Me.GridButtonHelper1.ShowDelete = True
        Me.GridButtonHelper1.Size = New System.Drawing.Size(831, 29)
        Me.GridButtonHelper1.TabIndex = 1
        Me.GridButtonHelper1.UseCanDelete = True
        '
        'grdData
        '
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.EmbeddedNavigator.Name = ""
        Me.grdData.EnforceCanEdit = False
        Me.grdData.Location = New System.Drawing.Point(0, 60)
        Me.grdData.MainView = Me.gvwData
        Me.grdData.Name = "grdData"
        Me.grdData.ShowOnlyActive = False
        Me.grdData.Size = New System.Drawing.Size(831, 282)
        Me.grdData.TabIndex = 2
        Me.grdData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwData})
        '
        'gvwData
        '
        Me.gvwData.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bandService})
        Me.gvwData.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colServiceCode, Me.colServiceName, Me.colServiceDefaultPrice})
        Me.gvwData.GridControl = Me.grdData
        Me.gvwData.Name = "gvwData"
        Me.gvwData.OptionsView.ShowAutoFilterRow = True
        Me.gvwData.OptionsView.ShowDetailButtons = False
        Me.gvwData.OptionsView.ShowFilterPanel = False
        Me.gvwData.OptionsView.ShowGroupPanel = False
        '
        'bandService
        '
        Me.bandService.Caption = "Pakalpojums"
        Me.bandService.Columns.Add(Me.colServiceCode)
        Me.bandService.Columns.Add(Me.colServiceName)
        Me.bandService.Columns.Add(Me.colServiceDefaultPrice)
        Me.bandService.Name = "bandService"
        Me.bandService.Width = 519
        '
        'colServiceCode
        '
        Me.colServiceCode.Caption = "Kods"
        Me.colServiceCode.Name = "colServiceCode"
        Me.colServiceCode.OptionsColumn.ReadOnly = True
        Me.colServiceCode.Visible = True
        Me.colServiceCode.Width = 71
        '
        'colServiceName
        '
        Me.colServiceName.Caption = "Nosaukums"
        Me.colServiceName.Name = "colServiceName"
        Me.colServiceName.OptionsColumn.ReadOnly = True
        Me.colServiceName.Visible = True
        Me.colServiceName.Width = 374
        '
        'colServiceDefaultPrice
        '
        Me.colServiceDefaultPrice.Caption = "Pamatcena"
        Me.colServiceDefaultPrice.DisplayFormat.FormatString = "n2"
        Me.colServiceDefaultPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colServiceDefaultPrice.Name = "colServiceDefaultPrice"
        Me.colServiceDefaultPrice.OptionsColumn.ReadOnly = True
        Me.colServiceDefaultPrice.Visible = True
        Me.colServiceDefaultPrice.Width = 74
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 342)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(831, 29)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(753, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(672, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmInsurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(831, 371)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GridButtonHelper1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmInsurance"
        Me.Text = "Apdrošināšana"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmbInsuranceCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndInsuranceCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bndInsuranceCompany As System.Windows.Forms.BindingSource
    Friend WithEvents cmbInsuranceCompany As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridButtonHelper1 As Core.UI.GridButtonHelper
    Friend WithEvents grdData As Core.UI.CoreGrid
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents gvwData As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents bandService As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colServiceCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colServiceName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colServiceDefaultPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

End Class
