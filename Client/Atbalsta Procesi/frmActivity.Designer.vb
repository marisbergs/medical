Imports Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivity
    Inherits frmUIBase

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
        Me.CtlActivityFind1 = New Client.ctlActivityFind()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.grdActivity = New Core.UI.CoreGrid()
        Me.bndActivitu = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwActivity = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPatient = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRevactinacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemindDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivityDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreateUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreateDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.grdActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndActivitu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CtlActivityFind1
        '
        Me.CtlActivityFind1.AutoSize = True
        Me.CtlActivityFind1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CtlActivityFind1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlActivityFind1.Location = New System.Drawing.Point(0, 0)
        Me.CtlActivityFind1.MinimumSize = New System.Drawing.Size(200, 0)
        Me.CtlActivityFind1.Name = "CtlActivityFind1"
        Me.CtlActivityFind1.Size = New System.Drawing.Size(992, 212)
        Me.CtlActivityFind1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 419)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 33)
        Me.Panel1.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(920, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOpen)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(237, 29)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Pievienot"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(84, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(69, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(159, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Dzēst"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'grdActivity
        '
        Me.grdActivity.DataSource = Me.bndActivitu
        Me.grdActivity.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdActivity.EmbeddedNavigator.Name = ""
        Me.grdActivity.EnforceCanEdit = False
        Me.grdActivity.Location = New System.Drawing.Point(0, 212)
        Me.grdActivity.MainView = Me.gvwActivity
        Me.grdActivity.Name = "grdActivity"
        Me.grdActivity.ShowOnlyActive = False
        Me.grdActivity.Size = New System.Drawing.Size(992, 207)
        Me.grdActivity.TabIndex = 8
        Me.grdActivity.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwActivity})
        '
        'bndActivitu
        '
        Me.bndActivitu.DataSource = GetType(Entities.Activity)
        '
        'gvwActivity
        '
        Me.gvwActivity.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPatient, Me.colUser, Me.colService, Me.colRevactinacion, Me.colRemindDate, Me.colActivityDate, Me.colComments, Me.colCreateUser, Me.colCreateDate})
        Me.gvwActivity.GridControl = Me.grdActivity
        Me.gvwActivity.Name = "gvwActivity"
        Me.gvwActivity.OptionsBehavior.Editable = False
        Me.gvwActivity.OptionsView.ColumnAutoWidth = False
        Me.gvwActivity.OptionsView.ShowDetailButtons = False
        Me.gvwActivity.OptionsView.ShowFilterPanel = False
        Me.gvwActivity.OptionsView.ShowGroupPanel = False
        Me.gvwActivity.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRemindDate, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPatient
        '
        Me.colPatient.Caption = "Klients"
        Me.colPatient.FieldName = "Patient"
        Me.colPatient.Name = "colPatient"
        Me.colPatient.ToolTip = "Klients, kuram piesaistīta aktivitāte"
        Me.colPatient.Visible = True
        Me.colPatient.VisibleIndex = 0
        Me.colPatient.Width = 127
        '
        'colUser
        '
        Me.colUser.Caption = "Darbinieks"
        Me.colUser.FieldName = "User"
        Me.colUser.Name = "colUser"
        Me.colUser.ToolTip = "Darbienieks, kuram piesaistīta aktivitāte"
        Me.colUser.Visible = True
        Me.colUser.VisibleIndex = 1
        Me.colUser.Width = 135
        '
        'colService
        '
        Me.colService.Caption = "Pakalpojums"
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.Visible = True
        Me.colService.VisibleIndex = 2
        '
        'colRevactinacion
        '
        Me.colRevactinacion.Caption = "Revakcinācija"
        Me.colRevactinacion.FieldName = "Revactinacion"
        Me.colRevactinacion.Name = "colRevactinacion"
        Me.colRevactinacion.Visible = True
        Me.colRevactinacion.VisibleIndex = 3
        '
        'colRemindDate
        '
        Me.colRemindDate.Caption = "Atg. dat."
        Me.colRemindDate.FieldName = "RemindDate"
        Me.colRemindDate.Name = "colRemindDate"
        Me.colRemindDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colRemindDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colRemindDate.ToolTip = "Atgādinājuma dtumns kurā tis nosûtīts atgādinājum par aktivitāti"
        Me.colRemindDate.Visible = True
        Me.colRemindDate.VisibleIndex = 8
        Me.colRemindDate.Width = 71
        '
        'colActivityDate
        '
        Me.colActivityDate.Caption = "Aktivitātes dat."
        Me.colActivityDate.FieldName = "ActivityDate"
        Me.colActivityDate.Name = "colActivityDate"
        Me.colActivityDate.ToolTip = "Aktivitātes datums kad jāveic ieplānotais darbs"
        Me.colActivityDate.Visible = True
        Me.colActivityDate.VisibleIndex = 4
        '
        'colComments
        '
        Me.colComments.Caption = "Piezīmes"
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 5
        Me.colComments.Width = 127
        '
        'colCreateUser
        '
        Me.colCreateUser.Caption = "Izveidoja"
        Me.colCreateUser.FieldName = "CreateUser"
        Me.colCreateUser.Name = "colCreateUser"
        Me.colCreateUser.ToolTip = "Darbinieks kas izveidoja aktivitāti"
        Me.colCreateUser.Visible = True
        Me.colCreateUser.VisibleIndex = 6
        Me.colCreateUser.Width = 120
        '
        'colCreateDate
        '
        Me.colCreateDate.Caption = "Izv. dat."
        Me.colCreateDate.FieldName = "CreateDate"
        Me.colCreateDate.Name = "colCreateDate"
        Me.colCreateDate.ToolTip = "Izveidošanas datums"
        Me.colCreateDate.Visible = True
        Me.colCreateDate.VisibleIndex = 7
        Me.colCreateDate.Width = 70
        '
        'frmActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 452)
        Me.Controls.Add(Me.grdActivity)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CtlActivityFind1)
        Me.Name = "frmActivity"
        Me.Text = "Aktivitātes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.grdActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndActivitu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtlActivityFind1 As Client.ctlActivityFind
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents grdActivity As Core.UI.CoreGrid
    Friend WithEvents gvwActivity As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bndActivitu As System.Windows.Forms.BindingSource
    Friend WithEvents colPatient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRevactinacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemindDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivityDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateDate As DevExpress.XtraGrid.Columns.GridColumn

End Class
