<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivityEdit
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCreateVisit = New System.Windows.Forms.Button()
        Me.ButtonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
        Me.bndActivity = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClassifierPicker1 = New Client.ClassifierPicker()
        Me.ClassifierPicker2 = New Client.ClassifierPicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonEdit2 = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MemoExEdit1 = New DevExpress.XtraEditors.MemoExEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.grdData = New Core.UI.CoreGrid()
        Me.gvwData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPatient = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRevactinacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivityDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemindDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVisit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridButtonHelper1 = New Core.UI.GridButtonHelper()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassifierPicker1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassifierPicker2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoExEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCreateVisit)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 437)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(992, 29)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(914, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(833, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCreateVisit
        '
        Me.btnCreateVisit.AutoSize = True
        Me.btnCreateVisit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCreateVisit.Location = New System.Drawing.Point(749, 3)
        Me.btnCreateVisit.Name = "btnCreateVisit"
        Me.btnCreateVisit.Size = New System.Drawing.Size(78, 23)
        Me.btnCreateVisit.TabIndex = 2
        Me.btnCreateVisit.Text = "Izveidot vizīti"
        Me.btnCreateVisit.UseVisualStyleBackColor = True
        '
        'ButtonEdit1
        '
        Me.ButtonEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndActivity, "Patient", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonEdit1.Location = New System.Drawing.Point(88, 8)
        Me.ButtonEdit1.Name = "ButtonEdit1"
        Me.ButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ButtonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ButtonEdit1.Size = New System.Drawing.Size(892, 20)
        Me.ButtonEdit1.TabIndex = 1
        '
        'bndActivity
        '
        Me.bndActivity.DataSource = GetType(Entities.Activity)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Klients:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Darbinieks:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pakalpojums:"
        '
        'ClassifierPicker1
        '
        Me.ClassifierPicker1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClassifierPicker1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndActivity, "User", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ClassifierPicker1.Location = New System.Drawing.Point(88, 34)
        Me.ClassifierPicker1.Name = "ClassifierPicker1"
        Me.ClassifierPicker1.PickerPresets = Nothing
        Me.ClassifierPicker1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ClassifierPicker1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ClassifierPicker1.Size = New System.Drawing.Size(892, 20)
        Me.ClassifierPicker1.TabIndex = 7
        '
        'ClassifierPicker2
        '
        Me.ClassifierPicker2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClassifierPicker2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndActivity, "Service", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ClassifierPicker2.Location = New System.Drawing.Point(88, 60)
        Me.ClassifierPicker2.Name = "ClassifierPicker2"
        Me.ClassifierPicker2.PickerPresets = Nothing
        Me.ClassifierPicker2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ClassifierPicker2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ClassifierPicker2.Size = New System.Drawing.Size(792, 20)
        Me.ClassifierPicker2.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bndActivity, "Revactinacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(886, 62)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Revakcinācija"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndActivity, "ActivityDate", True))
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(88, 86)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.DateEdit1.Size = New System.Drawing.Size(80, 20)
        Me.DateEdit1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Datums:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(530, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Izveidots:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(665, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Izveidoja:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndActivity, "CreateDate", True))
        Me.TextBox1.Location = New System.Drawing.Point(588, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(71, 20)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndActivity, "CreateUser", True))
        Me.TextBox2.Location = New System.Drawing.Point(723, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(257, 20)
        Me.TextBox2.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(331, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Atgādinājuma datums:"
        '
        'DateEdit2
        '
        Me.DateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndActivity, "RemindDate", True))
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(446, 86)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.DateEdit2.Size = New System.Drawing.Size(80, 20)
        Me.DateEdit2.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Vizīte:"
        '
        'ButtonEdit2
        '
        Me.ButtonEdit2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndActivity, "Visit", True))
        Me.ButtonEdit2.Location = New System.Drawing.Point(88, 112)
        Me.ButtonEdit2.Name = "ButtonEdit2"
        Me.ButtonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ButtonEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ButtonEdit2.Size = New System.Drawing.Size(892, 20)
        Me.ButtonEdit2.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Piezīmes:"
        '
        'MemoExEdit1
        '
        Me.MemoExEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoExEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndActivity, "Comments", True))
        Me.MemoExEdit1.Location = New System.Drawing.Point(88, 138)
        Me.MemoExEdit1.Name = "MemoExEdit1"
        Me.MemoExEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.MemoExEdit1.Properties.MaxLength = 2000
        Me.MemoExEdit1.Properties.PopupStartSize = New System.Drawing.Size(892, 150)
        Me.MemoExEdit1.Properties.ShowIcon = False
        Me.MemoExEdit1.Size = New System.Drawing.Size(892, 20)
        Me.MemoExEdit1.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.ButtonEdit1)
        Me.Panel1.Controls.Add(Me.MemoExEdit1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ButtonEdit2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ClassifierPicker1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ClassifierPicker2)
        Me.Panel1.Controls.Add(Me.DateEdit2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.DateEdit1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 165)
        Me.Panel1.TabIndex = 22
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bndActivity, "SendSMS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(174, 88)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(152, 17)
        Me.CheckBox2.TabIndex = 22
        Me.CheckBox2.Text = "Sûtīt atgādinājumu ar SMS"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'grdData
        '
        Me.grdData.DataSource = Me.bndActivity
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdData.EmbeddedNavigator.Name = ""
        Me.grdData.EnforceCanEdit = False
        Me.grdData.Location = New System.Drawing.Point(3, 45)
        Me.grdData.MainView = Me.gvwData
        Me.grdData.Name = "grdData"
        Me.grdData.ShowOnlyActive = False
        Me.grdData.Size = New System.Drawing.Size(986, 224)
        Me.grdData.TabIndex = 23
        Me.grdData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwData})
        '
        'gvwData
        '
        Me.gvwData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPatient, Me.colUser, Me.colService, Me.colRevactinacion, Me.colActivityDate, Me.colRemindDate, Me.colComments, Me.colVisit})
        Me.gvwData.GridControl = Me.grdData
        Me.gvwData.Name = "gvwData"
        Me.gvwData.OptionsBehavior.Editable = False
        Me.gvwData.OptionsView.ShowDetailButtons = False
        Me.gvwData.OptionsView.ShowFilterPanel = False
        Me.gvwData.OptionsView.ShowGroupPanel = False
        Me.gvwData.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colActivityDate, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPatient
        '
        Me.colPatient.Caption = "Klients"
        Me.colPatient.FieldName = "Patient"
        Me.colPatient.Name = "colPatient"
        Me.colPatient.Visible = True
        Me.colPatient.VisibleIndex = 0
        Me.colPatient.Width = 120
        '
        'colUser
        '
        Me.colUser.Caption = "Darbinieks"
        Me.colUser.FieldName = "User"
        Me.colUser.Name = "colUser"
        Me.colUser.Visible = True
        Me.colUser.VisibleIndex = 1
        Me.colUser.Width = 120
        '
        'colService
        '
        Me.colService.Caption = "Pakalpojums"
        Me.colService.FieldName = "Service"
        Me.colService.Name = "colService"
        Me.colService.Visible = True
        Me.colService.VisibleIndex = 2
        Me.colService.Width = 170
        '
        'colRevactinacion
        '
        Me.colRevactinacion.Caption = "Revakcinācija"
        Me.colRevactinacion.FieldName = "Revactinacion"
        Me.colRevactinacion.Name = "colRevactinacion"
        Me.colRevactinacion.Visible = True
        Me.colRevactinacion.VisibleIndex = 3
        Me.colRevactinacion.Width = 84
        '
        'colActivityDate
        '
        Me.colActivityDate.Caption = "Aktivitātes dat."
        Me.colActivityDate.DisplayFormat.FormatString = "d"
        Me.colActivityDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colActivityDate.FieldName = "ActivityDate"
        Me.colActivityDate.Name = "colActivityDate"
        Me.colActivityDate.Visible = True
        Me.colActivityDate.VisibleIndex = 4
        Me.colActivityDate.Width = 89
        '
        'colRemindDate
        '
        Me.colRemindDate.Caption = "Atgādinājuma dat."
        Me.colRemindDate.DisplayFormat.FormatString = "d"
        Me.colRemindDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colRemindDate.FieldName = "RemindDate"
        Me.colRemindDate.Name = "colRemindDate"
        Me.colRemindDate.Visible = True
        Me.colRemindDate.VisibleIndex = 5
        Me.colRemindDate.Width = 96
        '
        'colComments
        '
        Me.colComments.Caption = "Piezīmes"
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 7
        Me.colComments.Width = 189
        '
        'colVisit
        '
        Me.colVisit.Caption = "Vizīte"
        Me.colVisit.FieldName = "Visit"
        Me.colVisit.Name = "colVisit"
        Me.colVisit.Visible = True
        Me.colVisit.VisibleIndex = 6
        Me.colVisit.Width = 104
        '
        'GridButtonHelper1
        '
        Me.GridButtonHelper1.AutoSize = True
        Me.GridButtonHelper1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GridButtonHelper1.DeleteReason = False
        Me.GridButtonHelper1.DeleteReasonColumn = Nothing
        Me.GridButtonHelper1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridButtonHelper1.Grid = Me.grdData
        Me.GridButtonHelper1.GridDataSource = Me.bndActivity
        Me.GridButtonHelper1.Location = New System.Drawing.Point(3, 16)
        Me.GridButtonHelper1.Name = "GridButtonHelper1"
        Me.GridButtonHelper1.ShowActive = False
        Me.GridButtonHelper1.ShowAdd = True
        Me.GridButtonHelper1.ShowChk = True
        Me.GridButtonHelper1.ShowDelete = True
        Me.GridButtonHelper1.Size = New System.Drawing.Size(986, 29)
        Me.GridButtonHelper1.TabIndex = 24
        Me.GridButtonHelper1.UseCanDelete = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdData)
        Me.GroupBox1.Controls.Add(Me.GridButtonHelper1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 272)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Saistītās aktivitātes"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndActivity
        '
        'frmActivityEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 466)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(770, 500)
        Me.Name = "frmActivityEdit"
        Me.Text = "Aktivitāte"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassifierPicker1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassifierPicker2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoExEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClassifierPicker1 As Client.ClassifierPicker
    Friend WithEvents ClassifierPicker2 As Client.ClassifierPicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents bndActivity As System.Windows.Forms.BindingSource
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonEdit2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MemoExEdit1 As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdData As Core.UI.CoreGrid
    Friend WithEvents gvwData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridButtonHelper1 As Core.UI.GridButtonHelper
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents colPatient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRevactinacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivityDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemindDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVisit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCreateVisit As System.Windows.Forms.Button

End Class
