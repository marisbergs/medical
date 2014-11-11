<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroupWorkEdit
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.bndGroupWork = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDoctorSelector = New Client.ClassifierPicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtGroupWork = New DevExpress.XtraEditors.ButtonEdit
        Me.txtRoomSelector = New Client.ClassifierPicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.gbhGroupWork = New Core.UI.GridButtonHelper
        Me.grdWorkGroup = New Core.UI.CoreGrid
        Me.bndGroupsWorks = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwWorkGroup = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colStartTime1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtStartDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colStartTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtStartTime = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colEndTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.colRoom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtRoom = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtDoctor = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPatientCount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        CType(Me.bndGroupWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDoctorSelector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtGroupWork.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomSelector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.grdWorkGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndGroupsWorks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwWorkGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Grupas nodarbība:"
        '
        'bndGroupWork
        '
        Me.bndGroupWork.DataSource = GetType(Entities.WorkTime)
        '
        'txtDoctorSelector
        '
        Me.txtDoctorSelector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDoctorSelector.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGroupWork, "User", True))
        Me.txtDoctorSelector.Location = New System.Drawing.Point(127, 38)
        Me.txtDoctorSelector.Name = "txtDoctorSelector"
        Me.txtDoctorSelector.PickerPresets = Nothing
        Me.txtDoctorSelector.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDoctorSelector.Size = New System.Drawing.Size(745, 22)
        Me.txtDoctorSelector.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ârsts:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtGroupWork)
        Me.Panel1.Controls.Add(Me.txtRoomSelector)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtDoctorSelector)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 95)
        Me.Panel1.TabIndex = 5
        '
        'txtGroupWork
        '
        Me.txtGroupWork.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGroupWork.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGroupWork, "GroupWork", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtGroupWork.Location = New System.Drawing.Point(127, 12)
        Me.txtGroupWork.Name = "txtGroupWork"
        Me.txtGroupWork.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtGroupWork.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtGroupWork.Size = New System.Drawing.Size(745, 22)
        Me.txtGroupWork.TabIndex = 7
        '
        'txtRoomSelector
        '
        Me.txtRoomSelector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRoomSelector.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGroupWork, "Room", True))
        Me.txtRoomSelector.Location = New System.Drawing.Point(127, 64)
        Me.txtRoomSelector.Name = "txtRoomSelector"
        Me.txtRoomSelector.PickerPresets = Nothing
        Me.txtRoomSelector.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtRoomSelector.Size = New System.Drawing.Size(745, 22)
        Me.txtRoomSelector.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kabinets:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 344)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(884, 29)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(806, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(725, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbhGroupWork
        '
        Me.gbhGroupWork.AutoSize = True
        Me.gbhGroupWork.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhGroupWork.DeleteReason = False
        Me.gbhGroupWork.DeleteReasonColumn = Nothing
        Me.gbhGroupWork.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhGroupWork.Grid = Me.grdWorkGroup
        Me.gbhGroupWork.GridDataSource = Me.bndGroupsWorks
        Me.gbhGroupWork.Location = New System.Drawing.Point(0, 95)
        Me.gbhGroupWork.Name = "gbhGroupWork"
        Me.gbhGroupWork.ShowActive = False
        Me.gbhGroupWork.ShowAdd = True
        Me.gbhGroupWork.ShowChk = True
        Me.gbhGroupWork.ShowDelete = True
        Me.gbhGroupWork.Size = New System.Drawing.Size(884, 29)
        Me.gbhGroupWork.TabIndex = 7
        Me.gbhGroupWork.UseCanDelete = True
        '
        'grdWorkGroup
        '
        Me.grdWorkGroup.DataSource = Me.bndGroupsWorks
        Me.grdWorkGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdWorkGroup.EmbeddedNavigator.Name = ""
        Me.grdWorkGroup.EnforceCanEdit = False
        Me.grdWorkGroup.Location = New System.Drawing.Point(0, 124)
        Me.grdWorkGroup.MainView = Me.gvwWorkGroup
        Me.grdWorkGroup.Name = "grdWorkGroup"
        Me.grdWorkGroup.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.txtStartDate, Me.RepositoryItemTimeEdit1, Me.txtRoom, Me.txtDoctor, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTimeEdit2, Me.txtStartTime})
        Me.grdWorkGroup.ShowOnlyActive = False
        Me.grdWorkGroup.Size = New System.Drawing.Size(884, 220)
        Me.grdWorkGroup.TabIndex = 8
        Me.grdWorkGroup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwWorkGroup})
        '
        'bndGroupsWorks
        '
        Me.bndGroupsWorks.DataSource = GetType(Entities.WorkTime)
        '
        'gvwWorkGroup
        '
        Me.gvwWorkGroup.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStartTime1, Me.colStartTime, Me.colEndTime, Me.colRoom, Me.colUser, Me.colIsActive, Me.colPatientCount, Me.colLength, Me.colPrice})
        Me.gvwWorkGroup.GridControl = Me.grdWorkGroup
        Me.gvwWorkGroup.Name = "gvwWorkGroup"
        Me.gvwWorkGroup.OptionsView.ColumnAutoWidth = False
        Me.gvwWorkGroup.OptionsView.ShowDetailButtons = False
        Me.gvwWorkGroup.OptionsView.ShowFilterPanel = False
        Me.gvwWorkGroup.OptionsView.ShowGroupPanel = False
        '
        'colStartTime1
        '
        Me.colStartTime1.Caption = "Datums"
        Me.colStartTime1.ColumnEdit = Me.txtStartDate
        Me.colStartTime1.FieldName = "StartTime"
        Me.colStartTime1.Name = "colStartTime1"
        Me.colStartTime1.Visible = True
        Me.colStartTime1.VisibleIndex = 3
        Me.colStartTime1.Width = 89
        '
        'txtStartDate
        '
        Me.txtStartDate.AutoHeight = False
        Me.txtStartDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtStartDate.Name = "txtStartDate"
        '
        'colStartTime
        '
        Me.colStartTime.Caption = "Sākuma laiks"
        Me.colStartTime.ColumnEdit = Me.txtStartTime
        Me.colStartTime.FieldName = "StartDateTime"
        Me.colStartTime.Name = "colStartTime"
        Me.colStartTime.Visible = True
        Me.colStartTime.VisibleIndex = 4
        Me.colStartTime.Width = 76
        '
        'txtStartTime
        '
        Me.txtStartTime.AutoHeight = False
        Me.txtStartTime.Mask.EditMask = "t"
        Me.txtStartTime.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.txtStartTime.Mask.UseMaskAsDisplayFormat = True
        Me.txtStartTime.Name = "txtStartTime"
        '
        'colEndTime
        '
        Me.colEndTime.Caption = "Beigu laiks"
        Me.colEndTime.ColumnEdit = Me.RepositoryItemTimeEdit2
        Me.colEndTime.FieldName = "EndTime"
        Me.colEndTime.Name = "colEndTime"
        Me.colEndTime.Visible = True
        Me.colEndTime.VisibleIndex = 5
        Me.colEndTime.Width = 65
        '
        'RepositoryItemTimeEdit2
        '
        Me.RepositoryItemTimeEdit2.AutoHeight = False
        Me.RepositoryItemTimeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit2.DisplayFormat.FormatString = "t"
        Me.RepositoryItemTimeEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeEdit2.EditFormat.FormatString = "t"
        Me.RepositoryItemTimeEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTimeEdit2.Mask.EditMask = "t"
        Me.RepositoryItemTimeEdit2.Name = "RepositoryItemTimeEdit2"
        '
        'colRoom
        '
        Me.colRoom.Caption = "Kabinets"
        Me.colRoom.ColumnEdit = Me.txtRoom
        Me.colRoom.FieldName = "Room"
        Me.colRoom.Name = "colRoom"
        Me.colRoom.Visible = True
        Me.colRoom.VisibleIndex = 6
        Me.colRoom.Width = 76
        '
        'txtRoom
        '
        Me.txtRoom.AutoHeight = False
        Me.txtRoom.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.ReadOnly = True
        '
        'colUser
        '
        Me.colUser.Caption = "Ârsts"
        Me.colUser.ColumnEdit = Me.txtDoctor
        Me.colUser.FieldName = "User"
        Me.colUser.Name = "colUser"
        Me.colUser.Visible = True
        Me.colUser.VisibleIndex = 7
        Me.colUser.Width = 220
        '
        'txtDoctor
        '
        Me.txtDoctor.AutoHeight = False
        Me.txtDoctor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.ReadOnly = True
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        '
        'colPatientCount
        '
        Me.colPatientCount.Caption = "Dalībnieku skaits"
        Me.colPatientCount.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colPatientCount.FieldName = "PatientCount"
        Me.colPatientCount.Name = "colPatientCount"
        Me.colPatientCount.Visible = True
        Me.colPatientCount.VisibleIndex = 0
        Me.colPatientCount.Width = 101
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "[1-9]|[1-9][0-9]|[1-9][0-9][0-9]"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.RepositoryItemTextEdit3.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'colLength
        '
        Me.colLength.Caption = "Nodarbības ilgums"
        Me.colLength.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colLength.FieldName = "Length"
        Me.colLength.Name = "colLength"
        Me.colLength.Visible = True
        Me.colLength.VisibleIndex = 1
        Me.colLength.Width = 106
        '
        'colPrice
        '
        Me.colPrice.Caption = "Nodarbības cena"
        Me.colPrice.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 2
        Me.colPrice.Width = 103
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "#,##0.00;"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "t"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.RepositoryItemTextEdit1.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit1.Mask.EditMask = "t"
        Me.RepositoryItemTimeEdit1.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTimeEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'frmGroupWorkEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(884, 373)
        Me.Controls.Add(Me.grdWorkGroup)
        Me.Controls.Add(Me.gbhGroupWork)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(700, 400)
        Me.Name = "frmGroupWorkEdit"
        Me.Text = "Grupu nodarbības"
        CType(Me.bndGroupWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDoctorSelector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtGroupWork.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoomSelector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.grdWorkGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndGroupsWorks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwWorkGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDoctorSelector As Client.ClassifierPicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbhGroupWork As Core.UI.GridButtonHelper
    Friend WithEvents grdWorkGroup As Core.UI.CoreGrid
    Friend WithEvents gvwWorkGroup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bndGroupsWorks As System.Windows.Forms.BindingSource
    Friend WithEvents colStartTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRoom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartTime1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtStartDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtRoom As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents txtRoomSelector As Client.ClassifierPicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bndGroupWork As System.Windows.Forms.BindingSource
    Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDoctor As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colPatientCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents txtStartTime As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtGroupWork As DevExpress.XtraEditors.ButtonEdit

End Class
