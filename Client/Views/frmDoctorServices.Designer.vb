<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoctorServices
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.CoreGrid1 = New Core.UI.CoreGrid
        Me.bndList = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSpeciality = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colServiceType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.CoreGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 241)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(788, 29)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(710, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(629, 3)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "Eksportēt"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'CoreGrid1
        '
        Me.CoreGrid1.DataSource = Me.bndList
        Me.CoreGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.CoreGrid1.EmbeddedNavigator.Name = ""
        Me.CoreGrid1.EnforceCanEdit = False
        Me.CoreGrid1.Location = New System.Drawing.Point(0, 0)
        Me.CoreGrid1.MainView = Me.GridView1
        Me.CoreGrid1.Name = "CoreGrid1"
        Me.CoreGrid1.ShowOnlyActive = False
        Me.CoreGrid1.Size = New System.Drawing.Size(788, 241)
        Me.CoreGrid1.TabIndex = 1
        Me.CoreGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bndList
        '
        Me.bndList.DataSource = GetType(Entities.UserService)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSpeciality, Me.colUser, Me.colServiceType, Me.colTime, Me.colService, Me.colPrice})
        Me.GridView1.GridControl = Me.CoreGrid1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colServiceType, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSpeciality
        '
        Me.colSpeciality.Caption = "Specialitāte"
        Me.colSpeciality.FieldName = "Speciality"
        Me.colSpeciality.Name = "colSpeciality"
        Me.colSpeciality.Visible = True
        Me.colSpeciality.VisibleIndex = 0
        Me.colSpeciality.Width = 237
        '
        'colUser
        '
        Me.colUser.Caption = "Ârsts"
        Me.colUser.FieldName = "User"
        Me.colUser.Name = "colUser"
        Me.colUser.Visible = True
        Me.colUser.VisibleIndex = 1
        Me.colUser.Width = 151
        '
        'colServiceType
        '
        Me.colServiceType.Caption = "Pakalpojuma veids"
        Me.colServiceType.FieldName = "ServiceType"
        Me.colServiceType.Name = "colServiceType"
        Me.colServiceType.Visible = True
        Me.colServiceType.VisibleIndex = 2
        '
        'colService
        '
        Me.colService.Caption = "Pakalpojums"
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.Visible = True
        Me.colService.VisibleIndex = 2
        Me.colService.Width = 274
        '
        'colPrice
        '
        Me.colPrice.Caption = "Cena"
        Me.colPrice.DisplayFormat.FormatString = "n2"
        Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 3
        Me.colPrice.Width = 81
        '
        'colTime
        '
        Me.colTime.Caption = "Pakalpojuma ilgums"
        Me.colTime.FieldName = "Time"
        Me.colTime.Name = "colTime"
        Me.colTime.Visible = True
        Me.colTime.VisibleIndex = 4
        '
        'frmDoctorServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(788, 270)
        Me.Controls.Add(Me.CoreGrid1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frmDoctorServices"
        Me.Text = "Ârstu sniegtie pakalpojumi"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.CoreGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents CoreGrid1 As Core.UI.CoreGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bndList As System.Windows.Forms.BindingSource
    Friend WithEvents colSpeciality As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiceType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTime As DevExpress.XtraGrid.Columns.GridColumn

End Class
