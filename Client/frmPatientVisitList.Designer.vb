<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientVisitList
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
        Me.grdVisit = New Core.UI.CoreGrid
        Me.gvwVisit = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnOk = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.VisitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDoctor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStartTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.grdVisit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwVisit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.VisitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdVisit
        '
        Me.grdVisit.DataSource = Me.VisitBindingSource
        Me.grdVisit.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdVisit.EmbeddedNavigator.Name = ""
        Me.grdVisit.EnforceCanEdit = False
        Me.grdVisit.Location = New System.Drawing.Point(0, 0)
        Me.grdVisit.MainView = Me.gvwVisit
        Me.grdVisit.Name = "grdVisit"
        Me.grdVisit.ShowOnlyActive = False
        Me.grdVisit.Size = New System.Drawing.Size(992, 260)
        Me.grdVisit.TabIndex = 0
        Me.grdVisit.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwVisit})
        '
        'gvwVisit
        '
        Me.gvwVisit.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStartTime, Me.colDoctor, Me.colService, Me.colNotes})
        Me.gvwVisit.GridControl = Me.grdVisit
        Me.gvwVisit.Name = "gvwVisit"
        Me.gvwVisit.OptionsBehavior.Editable = False
        Me.gvwVisit.OptionsView.ShowDetailButtons = False
        Me.gvwVisit.OptionsView.ShowFilterPanel = False
        Me.gvwVisit.OptionsView.ShowGroupPanel = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOk)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(492, 31)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(3, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "Labi"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 260)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(992, 31)
        Me.SplitContainer1.SplitterDistance = 492
        Me.SplitContainer1.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(496, 31)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(418, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'VisitBindingSource
        '
        Me.VisitBindingSource.DataSource = GetType(Entities.Visit)
        '
        'colDoctor
        '
        Me.colDoctor.Caption = "Ârsts"
        Me.colDoctor.FieldName = "Doctor"
        Me.colDoctor.Name = "colDoctor"
        Me.colDoctor.Visible = True
        Me.colDoctor.VisibleIndex = 0
        Me.colDoctor.Width = 194
        '
        'colService
        '
        Me.colService.Caption = "Pakalpojums"
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.Visible = True
        Me.colService.VisibleIndex = 1
        Me.colService.Width = 192
        '
        'colStartTime
        '
        Me.colStartTime.Caption = "Datums"
        Me.colStartTime.DisplayFormat.FormatString = "G"
        Me.colStartTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colStartTime.FieldName = "StartTime"
        Me.colStartTime.Name = "colStartTime"
        Me.colStartTime.Visible = True
        Me.colStartTime.VisibleIndex = 2
        Me.colStartTime.Width = 120
        '
        'colNotes
        '
        Me.colNotes.Caption = "Piezīmes"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 3
        Me.colNotes.Width = 273
        '
        'frmPatientVisitList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 291)
        Me.Controls.Add(Me.grdVisit)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimumSize = New System.Drawing.Size(1000, 325)
        Me.Name = "frmPatientVisitList"
        Me.Text = "Klienta vizīšu saraksts"
        CType(Me.grdVisit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwVisit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.VisitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdVisit As Core.UI.CoreGrid
    Friend WithEvents gvwVisit As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents VisitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colDoctor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn

End Class
