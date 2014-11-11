<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroupWorkVisitsEdit
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
        Me.bndGroupWork = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grdVisits = New Core.UI.CoreGrid
        Me.bndVisits = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwVisits = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPatient = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtPatient = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.txtRoom = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.txtDoctor = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.gbhVisits = New Core.UI.GridButtonHelper
        Me.btnOpen = New System.Windows.Forms.Button
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        CType(Me.bndGroupWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grdVisits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndVisits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwVisits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbhVisits.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bndGroupWork
        '
        Me.bndGroupWork.DataSource = GetType(Entities.WorkTime)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(428, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Kabinets:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Grupas nodarbība:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ârsts:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nodarbības datums:"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGroupWork, "StartTime", True))
        Me.TextEdit1.Location = New System.Drawing.Point(118, 58)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "d"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TextEdit1.Properties.EditFormat.FormatString = "d"
        Me.TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit1.TabIndex = 14
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGroupWork, "User", True))
        Me.TextEdit2.Location = New System.Drawing.Point(118, 32)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(304, 22)
        Me.TextEdit2.TabIndex = 15
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGroupWork, "GroupWork", True))
        Me.TextEdit3.Location = New System.Drawing.Point(118, 6)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.TextEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(583, 22)
        Me.TextEdit3.TabIndex = 16
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGroupWork, "Room", True))
        Me.TextEdit4.Location = New System.Drawing.Point(485, 32)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.TextEdit4.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(216, 22)
        Me.TextEdit4.TabIndex = 17
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGroupWork, "StartTime", True))
        Me.TextEdit5.Location = New System.Drawing.Point(279, 58)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.TextEdit5.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit5.Properties.DisplayFormat.FormatString = "t"
        Me.TextEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TextEdit5.Properties.EditFormat.FormatString = "t"
        Me.TextEdit5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(56, 22)
        Me.TextEdit5.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Laiks no:"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGroupWork, "EndTime", True))
        Me.TextEdit6.Location = New System.Drawing.Point(366, 58)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.TextEdit6.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit6.Properties.DisplayFormat.FormatString = "t"
        Me.TextEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TextEdit6.Properties.EditFormat.FormatString = "t"
        Me.TextEdit6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.Size = New System.Drawing.Size(56, 22)
        Me.TextEdit6.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(338, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "līdz"
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndGroupWork, "PatientCount", True))
        Me.TextEdit7.Location = New System.Drawing.Point(526, 58)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.TextEdit7.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.Size = New System.Drawing.Size(56, 22)
        Me.TextEdit7.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(429, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Dalībnieku skaits:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextEdit3)
        Me.Panel1.Controls.Add(Me.TextEdit7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextEdit6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextEdit5)
        Me.Panel1.Controls.Add(Me.TextEdit1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextEdit2)
        Me.Panel1.Controls.Add(Me.TextEdit4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 84)
        Me.Panel1.TabIndex = 24
        '
        'grdVisits
        '
        Me.grdVisits.DataSource = Me.bndVisits
        Me.grdVisits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdVisits.EmbeddedNavigator.Name = ""
        Me.grdVisits.EnforceCanEdit = False
        Me.grdVisits.Location = New System.Drawing.Point(0, 113)
        Me.grdVisits.MainView = Me.gvwVisits
        Me.grdVisits.Name = "grdVisits"
        Me.grdVisits.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemTimeEdit1, Me.txtRoom, Me.txtDoctor, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.txtPatient})
        Me.grdVisits.ShowOnlyActive = False
        Me.grdVisits.Size = New System.Drawing.Size(715, 204)
        Me.grdVisits.TabIndex = 27
        Me.grdVisits.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwVisits})
        '
        'bndVisits
        '
        Me.bndVisits.DataSource = GetType(Entities.Visit)
        '
        'gvwVisits
        '
        Me.gvwVisits.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumber, Me.colPatient, Me.colIsActive})
        Me.gvwVisits.GridControl = Me.grdVisits
        Me.gvwVisits.Name = "gvwVisits"
        Me.gvwVisits.OptionsView.ShowDetailButtons = False
        Me.gvwVisits.OptionsView.ShowFilterPanel = False
        Me.gvwVisits.OptionsView.ShowGroupPanel = False
        '
        'colNumber
        '
        Me.colNumber.Caption = "Klienta numurs"
        Me.colNumber.FieldName = "Number"
        Me.colNumber.Name = "colNumber"
        Me.colNumber.Visible = True
        Me.colNumber.VisibleIndex = 0
        Me.colNumber.Width = 91
        '
        'colPatient
        '
        Me.colPatient.Caption = "Klients"
        Me.colPatient.ColumnEdit = Me.txtPatient
        Me.colPatient.FieldName = "Patient"
        Me.colPatient.Name = "colPatient"
        Me.colPatient.Visible = True
        Me.colPatient.VisibleIndex = 1
        Me.colPatient.Width = 607
        '
        'txtPatient
        '
        Me.txtPatient.AutoHeight = False
        Me.txtPatient.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.ReadOnly = True
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
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
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
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
        'txtRoom
        '
        Me.txtRoom.AutoHeight = False
        Me.txtRoom.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.ReadOnly = True
        '
        'txtDoctor
        '
        Me.txtDoctor.AutoHeight = False
        Me.txtDoctor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.ReadOnly = True
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
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "[1-9]|[1-9][0-9]|[1-9][0-9][0-9]"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.RepositoryItemTextEdit3.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'gbhVisits
        '
        Me.gbhVisits.AutoSize = True
        Me.gbhVisits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbhVisits.Controls.Add(Me.btnOpen)
        Me.gbhVisits.DeleteReason = False
        Me.gbhVisits.DeleteReasonColumn = Nothing
        Me.gbhVisits.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhVisits.Grid = Me.grdVisits
        Me.gbhVisits.GridDataSource = Me.bndVisits
        Me.gbhVisits.Location = New System.Drawing.Point(0, 84)
        Me.gbhVisits.Name = "gbhVisits"
        Me.gbhVisits.ShowActive = False
        Me.gbhVisits.ShowAdd = True
        Me.gbhVisits.ShowChk = True
        Me.gbhVisits.ShowDelete = True
        Me.gbhVisits.Size = New System.Drawing.Size(715, 29)
        Me.gbhVisits.TabIndex = 26
        Me.gbhVisits.UseCanDelete = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(260, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 4
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 317)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(715, 29)
        Me.FlowLayoutPanel1.TabIndex = 25
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(637, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(556, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmGroupWorkVisitsEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(715, 346)
        Me.Controls.Add(Me.grdVisits)
        Me.Controls.Add(Me.gbhVisits)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmGroupWorkVisitsEdit"
        Me.Text = "Grupas nodarbības"
        CType(Me.bndGroupWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grdVisits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndVisits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwVisits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbhVisits.ResumeLayout(False)
        Me.gbhVisits.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bndGroupWork As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdVisits As Core.UI.CoreGrid
    Friend WithEvents gvwVisits As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtRoom As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents txtDoctor As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gbhVisits As Core.UI.GridButtonHelper
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents bndVisits As System.Windows.Forms.BindingSource
    Friend WithEvents colPatient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPatient As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents colNumber As DevExpress.XtraGrid.Columns.GridColumn

End Class
