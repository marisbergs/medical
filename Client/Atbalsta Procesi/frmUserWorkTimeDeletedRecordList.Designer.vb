<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserWorkTimeDeletedRecordList
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
        Me.CoreGrid1 = New Core.UI.CoreGrid
        Me.gvwData = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.UsersWorkTimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colStartTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValidFrom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValidTo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRoom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEndTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDayOfWeek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.CoreGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersWorkTimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 236)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(732, 28)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(654, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'CoreGrid1
        '
        Me.CoreGrid1.DataSource = Me.UsersWorkTimeBindingSource
        Me.CoreGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.CoreGrid1.EmbeddedNavigator.Name = ""
        Me.CoreGrid1.EnforceCanEdit = False
        Me.CoreGrid1.Location = New System.Drawing.Point(0, 0)
        Me.CoreGrid1.MainView = Me.gvwData
        Me.CoreGrid1.Name = "CoreGrid1"
        Me.CoreGrid1.ShowOnlyActive = False
        Me.CoreGrid1.Size = New System.Drawing.Size(732, 236)
        Me.CoreGrid1.TabIndex = 1
        Me.CoreGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwData})
        '
        'gvwData
        '
        Me.gvwData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStartTime, Me.colEndTime, Me.colValidFrom, Me.colValidTo, Me.colRoom, Me.colDayOfWeek})
        Me.gvwData.GridControl = Me.CoreGrid1
        Me.gvwData.Name = "gvwData"
        Me.gvwData.OptionsView.ColumnAutoWidth = False
        Me.gvwData.OptionsView.ShowDetailButtons = False
        Me.gvwData.OptionsView.ShowFilterPanel = False
        Me.gvwData.OptionsView.ShowGroupPanel = False
        '
        'UsersWorkTimeBindingSource
        '
        Me.UsersWorkTimeBindingSource.DataSource = GetType(Entities.UsersWorkTime)
        '
        'colStartTime
        '
        Me.colStartTime.Caption = "Sākuma laiks"
        Me.colStartTime.DisplayFormat.FormatString = "T"
        Me.colStartTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colStartTime.FieldName = "StartTime"
        Me.colStartTime.Name = "colStartTime"
        Me.colStartTime.Visible = True
        Me.colStartTime.VisibleIndex = 0
        Me.colStartTime.Width = 104
        '
        'colValidFrom
        '
        Me.colValidFrom.Caption = "Spēkā no"
        Me.colValidFrom.DisplayFormat.FormatString = "d"
        Me.colValidFrom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colValidFrom.FieldName = "ValidFrom"
        Me.colValidFrom.Name = "colValidFrom"
        Me.colValidFrom.Visible = True
        Me.colValidFrom.VisibleIndex = 2
        '
        'colValidTo
        '
        Me.colValidTo.Caption = "Spēkā līdz"
        Me.colValidTo.DisplayFormat.FormatString = "d"
        Me.colValidTo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colValidTo.FieldName = "ValidTo"
        Me.colValidTo.Name = "colValidTo"
        Me.colValidTo.Visible = True
        Me.colValidTo.VisibleIndex = 3
        '
        'colRoom
        '
        Me.colRoom.Caption = "Kabinets"
        Me.colRoom.FieldName = "Room"
        Me.colRoom.Name = "colRoom"
        Me.colRoom.Visible = True
        Me.colRoom.VisibleIndex = 4
        Me.colRoom.Width = 94
        '
        'colEndTime
        '
        Me.colEndTime.Caption = "Beigu laiks"
        Me.colEndTime.DisplayFormat.FormatString = "T"
        Me.colEndTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEndTime.FieldName = "EndTime"
        Me.colEndTime.Name = "colEndTime"
        Me.colEndTime.Visible = True
        Me.colEndTime.VisibleIndex = 1
        Me.colEndTime.Width = 97
        '
        'colDayOfWeek
        '
        Me.colDayOfWeek.Caption = "Nedēļas diena"
        Me.colDayOfWeek.FieldName = "DayOfWeek"
        Me.colDayOfWeek.Name = "colDayOfWeek"
        Me.colDayOfWeek.Visible = True
        Me.colDayOfWeek.VisibleIndex = 5
        Me.colDayOfWeek.Width = 131
        '
        'frmUserWorkTimeDeletedRecordList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(732, 264)
        Me.Controls.Add(Me.CoreGrid1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frmUserWorkTimeDeletedRecordList"
        Me.Text = "Dzēstie darbalaiki"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.CoreGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersWorkTimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents CoreGrid1 As Core.UI.CoreGrid
    Friend WithEvents gvwData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UsersWorkTimeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colStartTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRoom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDayOfWeek As DevExpress.XtraGrid.Columns.GridColumn

End Class
