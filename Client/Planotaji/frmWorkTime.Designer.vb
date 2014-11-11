<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkTime
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
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRoomGroup = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDoctor = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbt1 = New System.Windows.Forms.RadioButton()
        Me.rbt5 = New System.Windows.Forms.RadioButton()
        Me.rbt7 = New System.Windows.Forms.RadioButton()
        Me.bndData = New System.Windows.Forms.BindingSource(Me.components)
        Me.mcaThisMonth = New System.Windows.Forms.MonthCalendar()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.gbhWorkTime = New Core.UI.GridButtonHelper()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnAddGroupWork = New System.Windows.Forms.Button()
        Me.grdPlanner = New Core.UI.CoreGrid()
        Me.bndPlanner = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwPlanner = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRoom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMonday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colMondayValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTuesday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTuesdayValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWednesday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWednesdayValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colThursday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colThursdayValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFriday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFridayValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaturday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaturdayValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSunday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSundayValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itmCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtRoomGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDoctor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.gbhWorkTime.SuspendLayout()
        CType(Me.grdPlanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndPlanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwPlanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 535)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(984, 29)
        Me.FlowLayoutPanel2.TabIndex = 55
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(901, 3)
        Me.btnClose.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kabinetu grupa:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtRoomGroup)
        Me.Panel1.Controls.Add(Me.txtDoctor)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(267, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(717, 63)
        Me.Panel1.TabIndex = 56
        '
        'txtRoomGroup
        '
        Me.txtRoomGroup.Location = New System.Drawing.Point(94, 5)
        Me.txtRoomGroup.Name = "txtRoomGroup"
        Me.txtRoomGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtRoomGroup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Kabinetu grupa", 400)})
        Me.txtRoomGroup.Properties.DisplayMember = "Value"
        Me.txtRoomGroup.Properties.DropDownRows = 20
        Me.txtRoomGroup.Properties.NullText = ""
        Me.txtRoomGroup.Properties.PopupWidth = 400
        Me.txtRoomGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtRoomGroup.Properties.ValueMember = "Id"
        Me.txtRoomGroup.Size = New System.Drawing.Size(289, 20)
        Me.txtRoomGroup.TabIndex = 135
        '
        'txtDoctor
        '
        Me.txtDoctor.Location = New System.Drawing.Point(94, 33)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtDoctor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Ârsts", 400)})
        Me.txtDoctor.Properties.DisplayMember = "FullName"
        Me.txtDoctor.Properties.DropDownRows = 20
        Me.txtDoctor.Properties.NullText = ""
        Me.txtDoctor.Properties.PopupWidth = 400
        Me.txtDoctor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtDoctor.Properties.ValueMember = "Id"
        Me.txtDoctor.Size = New System.Drawing.Size(289, 20)
        Me.txtDoctor.TabIndex = 134
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Ârsts:"
        '
        'btnSearch
        '
        Me.btnSearch.AutoSize = True
        Me.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSearch.Location = New System.Drawing.Point(394, 6)
        Me.btnSearch.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 124
        Me.btnSearch.Text = "Pārlasīt"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel4.Controls.Add(Me.rbt1)
        Me.FlowLayoutPanel4.Controls.Add(Me.rbt5)
        Me.FlowLayoutPanel4.Controls.Add(Me.rbt7)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(404, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(300, 23)
        Me.FlowLayoutPanel4.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dienu skaits:"
        '
        'rbt1
        '
        Me.rbt1.AutoSize = True
        Me.rbt1.Location = New System.Drawing.Point(77, 3)
        Me.rbt1.Name = "rbt1"
        Me.rbt1.Size = New System.Drawing.Size(60, 17)
        Me.rbt1.TabIndex = 2
        Me.rbt1.Tag = "1"
        Me.rbt1.Text = "1 diena"
        Me.rbt1.UseVisualStyleBackColor = True
        '
        'rbt5
        '
        Me.rbt5.AutoSize = True
        Me.rbt5.Location = New System.Drawing.Point(143, 3)
        Me.rbt5.Name = "rbt5"
        Me.rbt5.Size = New System.Drawing.Size(65, 17)
        Me.rbt5.TabIndex = 1
        Me.rbt5.Tag = "6"
        Me.rbt5.Text = "6 dienas"
        Me.rbt5.UseVisualStyleBackColor = True
        '
        'rbt7
        '
        Me.rbt7.AutoSize = True
        Me.rbt7.Location = New System.Drawing.Point(214, 3)
        Me.rbt7.Name = "rbt7"
        Me.rbt7.Size = New System.Drawing.Size(65, 17)
        Me.rbt7.TabIndex = 0
        Me.rbt7.Tag = "7"
        Me.rbt7.Text = "7 dienas"
        Me.rbt7.UseVisualStyleBackColor = True
        '
        'bndData
        '
        Me.bndData.DataSource = GetType(Entities.WorkTime)
        '
        'mcaThisMonth
        '
        Me.mcaThisMonth.CalendarDimensions = New System.Drawing.Size(1, 3)
        Me.mcaThisMonth.Location = New System.Drawing.Point(9, 9)
        Me.mcaThisMonth.MaxSelectionCount = 1
        Me.mcaThisMonth.Name = "mcaThisMonth"
        Me.mcaThisMonth.ShowWeekNumbers = True
        Me.mcaThisMonth.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.mcaThisMonth)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(267, 535)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'gbhWorkTime
        '
        Me.gbhWorkTime.Controls.Add(Me.btnOpen)
        Me.gbhWorkTime.Controls.Add(Me.btnAddGroupWork)
        Me.gbhWorkTime.DeleteReason = False
        Me.gbhWorkTime.DeleteReasonColumn = Nothing
        Me.gbhWorkTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhWorkTime.Grid = Me.grdPlanner
        Me.gbhWorkTime.GridDataSource = Me.bndData
        Me.gbhWorkTime.Location = New System.Drawing.Point(267, 63)
        Me.gbhWorkTime.Name = "gbhWorkTime"
        Me.gbhWorkTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbhWorkTime.ShowActive = False
        Me.gbhWorkTime.ShowAdd = True
        Me.gbhWorkTime.ShowChk = False
        Me.gbhWorkTime.ShowDelete = True
        Me.gbhWorkTime.Size = New System.Drawing.Size(717, 28)
        Me.gbhWorkTime.TabIndex = 120
        Me.gbhWorkTime.UseCanDelete = False
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(165, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 4
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnAddGroupWork
        '
        Me.btnAddGroupWork.AutoSize = True
        Me.btnAddGroupWork.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddGroupWork.Location = New System.Drawing.Point(246, 3)
        Me.btnAddGroupWork.Name = "btnAddGroupWork"
        Me.btnAddGroupWork.Size = New System.Drawing.Size(142, 23)
        Me.btnAddGroupWork.TabIndex = 5
        Me.btnAddGroupWork.Text = "Pievienot grupu nodarbību"
        Me.btnAddGroupWork.UseVisualStyleBackColor = True
        '
        'grdPlanner
        '
        Me.grdPlanner.DataSource = Me.bndPlanner
        Me.grdPlanner.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdPlanner.EmbeddedNavigator.Name = ""
        Me.grdPlanner.EnforceCanEdit = False
        Me.grdPlanner.Location = New System.Drawing.Point(267, 91)
        Me.grdPlanner.MainView = Me.gvwPlanner
        Me.grdPlanner.Name = "grdPlanner"
        Me.grdPlanner.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemTextEdit1})
        Me.grdPlanner.ShowOnlyActive = False
        Me.grdPlanner.Size = New System.Drawing.Size(717, 444)
        Me.grdPlanner.TabIndex = 121
        Me.grdPlanner.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPlanner})
        '
        'bndPlanner
        '
        Me.bndPlanner.DataSource = GetType(Entities.TimeTable)
        '
        'gvwPlanner
        '
        Me.gvwPlanner.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRoom, Me.colMonday, Me.colMondayValue, Me.colTuesday, Me.colTuesdayValue, Me.colWednesday, Me.colWednesdayValue, Me.colThursday, Me.colThursdayValue, Me.colFriday, Me.colFridayValue, Me.colSaturday, Me.colSaturdayValue, Me.colSunday, Me.colSundayValue})
        Me.gvwPlanner.GridControl = Me.grdPlanner
        Me.gvwPlanner.GroupCount = 1
        Me.gvwPlanner.Name = "gvwPlanner"
        Me.gvwPlanner.OptionsBehavior.Editable = False
        Me.gvwPlanner.OptionsView.RowAutoHeight = True
        Me.gvwPlanner.OptionsView.ShowGroupPanel = False
        Me.gvwPlanner.OptionsView.ShowHorzLines = False
        Me.gvwPlanner.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRoom, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colRoom
        '
        Me.colRoom.AppearanceCell.Options.UseTextOptions = True
        Me.colRoom.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRoom.Caption = "Kabinets"
        Me.colRoom.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colRoom.FieldName = "Room"
        Me.colRoom.Name = "colRoom"
        Me.colRoom.Visible = True
        Me.colRoom.VisibleIndex = 0
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'colMonday
        '
        Me.colMonday.AppearanceCell.Options.UseTextOptions = True
        Me.colMonday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMonday.Caption = "Monday"
        Me.colMonday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colMonday.FieldName = "Monday"
        Me.colMonday.Name = "colMonday"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        Me.RepositoryItemMemoEdit1.ReadOnly = True
        '
        'colMondayValue
        '
        Me.colMondayValue.Caption = "MondayValue"
        Me.colMondayValue.FieldName = "MondayValue"
        Me.colMondayValue.Name = "colMondayValue"
        '
        'colTuesday
        '
        Me.colTuesday.AppearanceCell.Options.UseTextOptions = True
        Me.colTuesday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTuesday.Caption = "Tuesday"
        Me.colTuesday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colTuesday.FieldName = "Tuesday"
        Me.colTuesday.Name = "colTuesday"
        '
        'colTuesdayValue
        '
        Me.colTuesdayValue.Caption = "TuesdayValue"
        Me.colTuesdayValue.FieldName = "TuesdayValue"
        Me.colTuesdayValue.Name = "colTuesdayValue"
        '
        'colWednesday
        '
        Me.colWednesday.AppearanceCell.Options.UseTextOptions = True
        Me.colWednesday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWednesday.Caption = "Wednesday"
        Me.colWednesday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colWednesday.FieldName = "Wednesday"
        Me.colWednesday.Name = "colWednesday"
        '
        'colWednesdayValue
        '
        Me.colWednesdayValue.Caption = "WednesdayValue"
        Me.colWednesdayValue.FieldName = "WednesdayValue"
        Me.colWednesdayValue.Name = "colWednesdayValue"
        '
        'colThursday
        '
        Me.colThursday.AppearanceCell.Options.UseTextOptions = True
        Me.colThursday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colThursday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colThursday.Caption = "Thursday"
        Me.colThursday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colThursday.FieldName = "Thursday"
        Me.colThursday.Name = "colThursday"
        '
        'colThursdayValue
        '
        Me.colThursdayValue.Caption = "ThursdayValue"
        Me.colThursdayValue.FieldName = "ThursdayValue"
        Me.colThursdayValue.Name = "colThursdayValue"
        '
        'colFriday
        '
        Me.colFriday.AppearanceCell.Options.UseTextOptions = True
        Me.colFriday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFriday.Caption = "Friday"
        Me.colFriday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colFriday.FieldName = "Friday"
        Me.colFriday.Name = "colFriday"
        '
        'colFridayValue
        '
        Me.colFridayValue.Caption = "FridayValue"
        Me.colFridayValue.FieldName = "FridayValue"
        Me.colFridayValue.Name = "colFridayValue"
        '
        'colSaturday
        '
        Me.colSaturday.AppearanceCell.Options.UseTextOptions = True
        Me.colSaturday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSaturday.Caption = "Saturday"
        Me.colSaturday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colSaturday.FieldName = "Saturday"
        Me.colSaturday.Name = "colSaturday"
        '
        'colSaturdayValue
        '
        Me.colSaturdayValue.Caption = "SaturdayValue"
        Me.colSaturdayValue.FieldName = "SaturdayValue"
        Me.colSaturdayValue.Name = "colSaturdayValue"
        '
        'colSunday
        '
        Me.colSunday.AppearanceCell.Options.UseTextOptions = True
        Me.colSunday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSunday.Caption = "Sunday"
        Me.colSunday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colSunday.FieldName = "Sunday"
        Me.colSunday.Name = "colSunday"
        '
        'colSundayValue
        '
        Me.colSundayValue.Caption = "SundayValue"
        Me.colSundayValue.FieldName = "SundayValue"
        Me.colSundayValue.Name = "colSundayValue"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmCopy})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(106, 26)
        '
        'itmCopy
        '
        Me.itmCopy.Name = "itmCopy"
        Me.itmCopy.Size = New System.Drawing.Size(105, 22)
        Me.itmCopy.Text = "Kopēt"
        '
        'frmWorkTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(984, 564)
        Me.Controls.Add(Me.grdPlanner)
        Me.Controls.Add(Me.gbhWorkTime)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.MinimumSize = New System.Drawing.Size(887, 424)
        Me.Name = "frmWorkTime"
        Me.Text = "Plānotājs"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtRoomGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDoctor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.gbhWorkTime.ResumeLayout(False)
        Me.gbhWorkTime.PerformLayout()
        CType(Me.grdPlanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndPlanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwPlanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bndData As System.Windows.Forms.BindingSource
    Friend WithEvents mcaThisMonth As System.Windows.Forms.MonthCalendar
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents gbhWorkTime As Core.UI.GridButtonHelper
    Friend WithEvents grdPlanner As Core.UI.CoreGrid
    Friend WithEvents gvwPlanner As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bndPlanner As System.Windows.Forms.BindingSource
    Friend WithEvents colMonday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMondayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTuesday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTuesdayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWednesday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWednesdayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThursday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThursdayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFriday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFridayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaturday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaturdayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSunday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSundayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbt1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt7 As System.Windows.Forms.RadioButton
    Friend WithEvents colRoom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnAddGroupWork As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtRoomGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDoctor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents itmCopy As System.Windows.Forms.ToolStripMenuItem

End Class
