<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanner
    Inherits Client.frmUIBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Me.mcaThisMonth = New System.Windows.Forms.MonthCalendar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkDoublePatients = New System.Windows.Forms.CheckBox()
        Me.txtSpeciality = New DevExpress.XtraEditors.LookUpEdit()
        Me.bndSpeciality = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDoctor = New DevExpress.XtraEditors.LookUpEdit()
        Me.bndUser = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtService = New DevExpress.XtraEditors.LookUpEdit()
        Me.bndServices = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbt1 = New System.Windows.Forms.RadioButton()
        Me.rbt5 = New System.Windows.Forms.RadioButton()
        Me.rbt7 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bndData = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.grdPlanner = New Core.UI.CoreGrid()
        Me.gvwPlanner = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDoctor = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.colSundayvalue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.gbhPlanner = New Core.UI.GridButtonHelper()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.chkVisitPlaner = New System.Windows.Forms.CheckBox()
        Me.chkVisitStatusViewer = New System.Windows.Forms.CheckBox()
        Me.chkGroupPlaner = New System.Windows.Forms.CheckBox()
        Me.cmsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itmCalled = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmPatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDoctorMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itmDoctorCall = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmUserCard = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtSpeciality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndSpeciality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDoctor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.grdPlanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwPlanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbhPlanner.SuspendLayout()
        Me.cmsMenu.SuspendLayout()
        Me.cmsDoctorMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.mcaThisMonth)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(267, 473)
        Me.FlowLayoutPanel1.TabIndex = 1
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkDoublePatients)
        Me.Panel1.Controls.Add(Me.txtSpeciality)
        Me.Panel1.Controls.Add(Me.txtDoctor)
        Me.Panel1.Controls.Add(Me.txtService)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblService)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(267, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(725, 100)
        Me.Panel1.TabIndex = 57
        '
        'chkDoublePatients
        '
        Me.chkDoublePatients.AutoSize = True
        Me.chkDoublePatients.Location = New System.Drawing.Point(390, 10)
        Me.chkDoublePatients.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.chkDoublePatients.Name = "chkDoublePatients"
        Me.chkDoublePatients.Size = New System.Drawing.Size(184, 17)
        Me.chkDoublePatients.TabIndex = 134
        Me.chkDoublePatients.Text = "Izcelt klientus ar vairākām vizītēm"
        Me.chkDoublePatients.UseVisualStyleBackColor = True
        '
        'txtSpeciality
        '
        Me.txtSpeciality.Location = New System.Drawing.Point(95, 7)
        Me.txtSpeciality.Name = "txtSpeciality"
        Me.txtSpeciality.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtSpeciality.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Pakalpojums", 240)})
        Me.txtSpeciality.Properties.DataSource = Me.bndSpeciality
        Me.txtSpeciality.Properties.DisplayMember = "Value"
        Me.txtSpeciality.Properties.DropDownRows = 10
        Me.txtSpeciality.Properties.NullText = ""
        Me.txtSpeciality.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtSpeciality.Properties.ValueMember = "Id"
        Me.txtSpeciality.Size = New System.Drawing.Size(289, 20)
        Me.txtSpeciality.TabIndex = 133
        '
        'bndSpeciality
        '
        Me.bndSpeciality.DataSource = GetType(Entities.SpecialityGroups)
        '
        'txtDoctor
        '
        Me.txtDoctor.Location = New System.Drawing.Point(95, 61)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDoctor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Вrsts", 400)})
        Me.txtDoctor.Properties.DataSource = Me.bndUser
        Me.txtDoctor.Properties.DisplayMember = "FullName"
        Me.txtDoctor.Properties.DropDownRows = 20
        Me.txtDoctor.Properties.NullText = ""
        Me.txtDoctor.Properties.PopupWidth = 400
        Me.txtDoctor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtDoctor.Properties.ValueMember = "Id"
        Me.txtDoctor.Size = New System.Drawing.Size(289, 20)
        Me.txtDoctor.TabIndex = 132
        '
        'bndUser
        '
        Me.bndUser.DataSource = GetType(Entities.User)
        '
        'txtService
        '
        Me.txtService.Location = New System.Drawing.Point(95, 34)
        Me.txtService.Name = "txtService"
        Me.txtService.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtService.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Pakalpojums", 240), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DecimalValue", "Cena", 80, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IntegerValue", "Vizītes ilgums", 80)})
        Me.txtService.Properties.DataSource = Me.bndServices
        Me.txtService.Properties.DisplayMember = "Value"
        Me.txtService.Properties.DropDownRows = 20
        Me.txtService.Properties.NullText = ""
        Me.txtService.Properties.PopupWidth = 400
        Me.txtService.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtService.Properties.ValueMember = "Id"
        Me.txtService.Size = New System.Drawing.Size(289, 20)
        Me.txtService.TabIndex = 131
        '
        'bndServices
        '
        Me.bndServices.DataSource = GetType(Entities.Services)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-2, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Specialitāšu grupa:"
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Location = New System.Drawing.Point(-2, 39)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(70, 13)
        Me.lblService.TabIndex = 10
        Me.lblService.Text = "Pakalpojums:"
        '
        'btnSearch
        '
        Me.btnSearch.AutoEllipsis = True
        Me.btnSearch.Location = New System.Drawing.Point(390, 57)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Atlasīt"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel3.Controls.Add(Me.rbt1)
        Me.FlowLayoutPanel3.Controls.Add(Me.rbt5)
        Me.FlowLayoutPanel3.Controls.Add(Me.rbt7)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(524, 5)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(194, 27)
        Me.FlowLayoutPanel3.TabIndex = 4
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
        Me.rbt1.Size = New System.Drawing.Size(31, 17)
        Me.rbt1.TabIndex = 2
        Me.rbt1.Tag = "1"
        Me.rbt1.Text = "1"
        Me.rbt1.UseVisualStyleBackColor = True
        '
        'rbt5
        '
        Me.rbt5.AutoSize = True
        Me.rbt5.Location = New System.Drawing.Point(114, 3)
        Me.rbt5.Name = "rbt5"
        Me.rbt5.Size = New System.Drawing.Size(31, 17)
        Me.rbt5.TabIndex = 1
        Me.rbt5.Tag = "6"
        Me.rbt5.Text = "6"
        Me.rbt5.UseVisualStyleBackColor = True
        '
        'rbt7
        '
        Me.rbt7.AutoSize = True
        Me.rbt7.Location = New System.Drawing.Point(151, 3)
        Me.rbt7.Name = "rbt7"
        Me.rbt7.Size = New System.Drawing.Size(31, 17)
        Me.rbt7.TabIndex = 0
        Me.rbt7.Tag = "7"
        Me.rbt7.Text = "7"
        Me.rbt7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ārsts:"
        '
        'bndData
        '
        Me.bndData.DataSource = GetType(Entities.TimeTable)
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOK)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(267, 444)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(725, 29)
        Me.FlowLayoutPanel2.TabIndex = 121
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(642, 3)
        Me.btnClose.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.AutoSize = True
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(561, 3)
        Me.btnOK.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "Labi"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'grdPlanner
        '
        Me.grdPlanner.DataSource = Me.bndData
        Me.grdPlanner.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdPlanner.EmbeddedNavigator.Name = ""
        Me.grdPlanner.EnforceCanEdit = False
        Me.grdPlanner.Location = New System.Drawing.Point(267, 129)
        Me.grdPlanner.MainView = Me.gvwPlanner
        Me.grdPlanner.Name = "grdPlanner"
        Me.grdPlanner.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTimeEdit1, Me.RepositoryItemMemoEdit1})
        Me.grdPlanner.ShowOnlyActive = False
        Me.grdPlanner.Size = New System.Drawing.Size(725, 315)
        Me.grdPlanner.TabIndex = 122
        Me.grdPlanner.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPlanner})
        '
        'gvwPlanner
        '
        Me.gvwPlanner.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gvwPlanner.Appearance.GroupRow.Options.UseFont = True
        Me.gvwPlanner.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDoctor, Me.colMonday, Me.colMondayValue, Me.colTuesday, Me.colTuesdayValue, Me.colWednesday, Me.colWednesdayValue, Me.colThursday, Me.colThursdayValue, Me.colFriday, Me.colFridayValue, Me.colSaturday, Me.colSaturdayValue, Me.colSunday, Me.colSundayvalue})
        Me.gvwPlanner.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvwPlanner.GridControl = Me.grdPlanner
        Me.gvwPlanner.GroupCount = 1
        Me.gvwPlanner.Name = "gvwPlanner"
        Me.gvwPlanner.OptionsBehavior.Editable = False
        Me.gvwPlanner.OptionsView.AllowCellMerge = True
        Me.gvwPlanner.OptionsView.RowAutoHeight = True
        Me.gvwPlanner.OptionsView.ShowGroupPanel = False
        Me.gvwPlanner.OptionsView.ShowHorzLines = False
        Me.gvwPlanner.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDoctor, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colDoctor
        '
        Me.colDoctor.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.colDoctor.AppearanceCell.Options.UseFont = True
        Me.colDoctor.AppearanceHeader.Options.UseBorderColor = True
        Me.colDoctor.Caption = "Ārsts"
        Me.colDoctor.FieldName = "DoctorForDisplay"
        Me.colDoctor.Name = "colDoctor"
        Me.colDoctor.Visible = True
        Me.colDoctor.VisibleIndex = 0
        '
        'colMonday
        '
        Me.colMonday.AppearanceCell.Options.UseTextOptions = True
        Me.colMonday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMonday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMonday.AppearanceHeader.Options.UseBorderColor = True
        Me.colMonday.AppearanceHeader.Options.UseTextOptions = True
        Me.colMonday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMonday.Caption = "Monday"
        Me.colMonday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colMonday.FieldName = "Monday"
        Me.colMonday.Name = "colMonday"
        Me.colMonday.Width = 103
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colMondayValue
        '
        Me.colMondayValue.AppearanceHeader.Options.UseBorderColor = True
        Me.colMondayValue.Caption = "GridColumn1"
        Me.colMondayValue.FieldName = "MondayValue"
        Me.colMondayValue.Name = "colMondayValue"
        '
        'colTuesday
        '
        Me.colTuesday.AppearanceCell.Options.UseTextOptions = True
        Me.colTuesday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTuesday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTuesday.AppearanceHeader.Options.UseBorderColor = True
        Me.colTuesday.AppearanceHeader.Options.UseTextOptions = True
        Me.colTuesday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTuesday.Caption = "Tuesday"
        Me.colTuesday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colTuesday.FieldName = "Tuesday"
        Me.colTuesday.Name = "colTuesday"
        Me.colTuesday.Width = 103
        '
        'colTuesdayValue
        '
        Me.colTuesdayValue.AppearanceHeader.Options.UseBorderColor = True
        Me.colTuesdayValue.Caption = "GridColumn1"
        Me.colTuesdayValue.FieldName = "TuesdayValue"
        Me.colTuesdayValue.Name = "colTuesdayValue"
        '
        'colWednesday
        '
        Me.colWednesday.AppearanceCell.Options.UseTextOptions = True
        Me.colWednesday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWednesday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWednesday.AppearanceHeader.Options.UseBorderColor = True
        Me.colWednesday.AppearanceHeader.Options.UseTextOptions = True
        Me.colWednesday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWednesday.Caption = "Wednesday"
        Me.colWednesday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colWednesday.FieldName = "Wednesday"
        Me.colWednesday.Name = "colWednesday"
        Me.colWednesday.Width = 103
        '
        'colWednesdayValue
        '
        Me.colWednesdayValue.AppearanceHeader.Options.UseBorderColor = True
        Me.colWednesdayValue.Caption = "GridColumn2"
        Me.colWednesdayValue.FieldName = "WednesdayValue"
        Me.colWednesdayValue.Name = "colWednesdayValue"
        '
        'colThursday
        '
        Me.colThursday.AppearanceCell.Options.UseTextOptions = True
        Me.colThursday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colThursday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colThursday.AppearanceHeader.Options.UseBorderColor = True
        Me.colThursday.AppearanceHeader.Options.UseTextOptions = True
        Me.colThursday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colThursday.Caption = "Thursday"
        Me.colThursday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colThursday.FieldName = "Thursday"
        Me.colThursday.Name = "colThursday"
        Me.colThursday.Width = 103
        '
        'colThursdayValue
        '
        Me.colThursdayValue.AppearanceHeader.Options.UseBorderColor = True
        Me.colThursdayValue.Caption = "GridColumn3"
        Me.colThursdayValue.FieldName = "ThursdayValue"
        Me.colThursdayValue.Name = "colThursdayValue"
        '
        'colFriday
        '
        Me.colFriday.AppearanceCell.Options.UseTextOptions = True
        Me.colFriday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFriday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFriday.AppearanceHeader.Options.UseBorderColor = True
        Me.colFriday.AppearanceHeader.Options.UseTextOptions = True
        Me.colFriday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFriday.Caption = "Friday"
        Me.colFriday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colFriday.FieldName = "Friday"
        Me.colFriday.Name = "colFriday"
        Me.colFriday.Width = 103
        '
        'colFridayValue
        '
        Me.colFridayValue.AppearanceHeader.Options.UseBorderColor = True
        Me.colFridayValue.Caption = "GridColumn4"
        Me.colFridayValue.FieldName = "FridayValue"
        Me.colFridayValue.Name = "colFridayValue"
        '
        'colSaturday
        '
        Me.colSaturday.AppearanceCell.Options.UseTextOptions = True
        Me.colSaturday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSaturday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSaturday.AppearanceHeader.Options.UseBorderColor = True
        Me.colSaturday.AppearanceHeader.Options.UseTextOptions = True
        Me.colSaturday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSaturday.Caption = "Saturday"
        Me.colSaturday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colSaturday.FieldName = "Saturday"
        Me.colSaturday.Name = "colSaturday"
        Me.colSaturday.Width = 103
        '
        'colSaturdayValue
        '
        Me.colSaturdayValue.AppearanceHeader.Options.UseBorderColor = True
        Me.colSaturdayValue.Caption = "GridColumn5"
        Me.colSaturdayValue.FieldName = "SaturdayValue"
        Me.colSaturdayValue.Name = "colSaturdayValue"
        '
        'colSunday
        '
        Me.colSunday.AppearanceCell.Options.UseTextOptions = True
        Me.colSunday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSunday.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSunday.AppearanceHeader.Options.UseBorderColor = True
        Me.colSunday.AppearanceHeader.Options.UseTextOptions = True
        Me.colSunday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSunday.Caption = "Sunday"
        Me.colSunday.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colSunday.FieldName = "Sunday"
        Me.colSunday.Name = "colSunday"
        Me.colSunday.Width = 113
        '
        'colSundayvalue
        '
        Me.colSundayvalue.AppearanceHeader.Options.UseBorderColor = True
        Me.colSundayvalue.Caption = "GridColumn1"
        Me.colSundayvalue.FieldName = "SundayValue"
        Me.colSundayvalue.Name = "colSundayvalue"
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'gbhPlanner
        '
        Me.gbhPlanner.AutoSize = True
        Me.gbhPlanner.Controls.Add(Me.btnOpen)
        Me.gbhPlanner.Controls.Add(Me.btnNext)
        Me.gbhPlanner.Controls.Add(Me.chkVisitPlaner)
        Me.gbhPlanner.Controls.Add(Me.chkVisitStatusViewer)
        Me.gbhPlanner.Controls.Add(Me.chkGroupPlaner)
        Me.gbhPlanner.DeleteReason = False
        Me.gbhPlanner.DeleteReasonColumn = Nothing
        Me.gbhPlanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbhPlanner.Grid = Me.grdPlanner
        Me.gbhPlanner.GridDataSource = Me.bndData
        Me.gbhPlanner.Location = New System.Drawing.Point(267, 100)
        Me.gbhPlanner.Name = "gbhPlanner"
        Me.gbhPlanner.ShowActive = False
        Me.gbhPlanner.ShowAdd = True
        Me.gbhPlanner.ShowChk = False
        Me.gbhPlanner.ShowDelete = True
        Me.gbhPlanner.Size = New System.Drawing.Size(725, 29)
        Me.gbhPlanner.TabIndex = 123
        Me.gbhPlanner.UseCanDelete = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(165, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 124
        Me.btnOpen.Text = "Atvērt"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNext.Location = New System.Drawing.Point(246, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(116, 23)
        Me.btnNext.TabIndex = 125
        Me.btnNext.Text = "Nākamais pieejamais"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'chkVisitPlaner
        '
        Me.chkVisitPlaner.AutoSize = True
        Me.chkVisitPlaner.Checked = True
        Me.chkVisitPlaner.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVisitPlaner.Location = New System.Drawing.Point(368, 6)
        Me.chkVisitPlaner.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.chkVisitPlaner.Name = "chkVisitPlaner"
        Me.chkVisitPlaner.Size = New System.Drawing.Size(99, 17)
        Me.chkVisitPlaner.TabIndex = 126
        Me.chkVisitPlaner.Text = "Vizīšu plānotājs"
        Me.chkVisitPlaner.UseVisualStyleBackColor = True
        '
        'chkVisitStatusViewer
        '
        Me.chkVisitStatusViewer.AutoSize = True
        Me.chkVisitStatusViewer.Location = New System.Drawing.Point(473, 6)
        Me.chkVisitStatusViewer.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.chkVisitStatusViewer.Name = "chkVisitStatusViewer"
        Me.chkVisitStatusViewer.Size = New System.Drawing.Size(87, 17)
        Me.chkVisitStatusViewer.TabIndex = 127
        Me.chkVisitStatusViewer.Text = "Vizīšu statusi"
        Me.chkVisitStatusViewer.UseVisualStyleBackColor = True
        '
        'chkGroupPlaner
        '
        Me.chkGroupPlaner.AutoSize = True
        Me.chkGroupPlaner.Location = New System.Drawing.Point(566, 6)
        Me.chkGroupPlaner.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.chkGroupPlaner.Name = "chkGroupPlaner"
        Me.chkGroupPlaner.Size = New System.Drawing.Size(151, 17)
        Me.chkGroupPlaner.TabIndex = 128
        Me.chkGroupPlaner.Text = "Grupu nodarbību plānotājs"
        Me.chkGroupPlaner.UseVisualStyleBackColor = True
        '
        'cmsMenu
        '
        Me.cmsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmCalled, Me.itmPatient})
        Me.cmsMenu.Name = "cmsAttachDoc"
        Me.cmsMenu.Size = New System.Drawing.Size(150, 48)
        '
        'itmCalled
        '
        Me.itmCalled.Name = "itmCalled"
        Me.itmCalled.Size = New System.Drawing.Size(149, 22)
        Me.itmCalled.Text = "Atzvanīts"
        '
        'itmPatient
        '
        Me.itmPatient.Name = "itmPatient"
        Me.itmPatient.Size = New System.Drawing.Size(149, 22)
        Me.itmPatient.Text = "Klienta kartiņa"
        '
        'cmsDoctorMenu
        '
        Me.cmsDoctorMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmDoctorCall, Me.itmUserCard})
        Me.cmsDoctorMenu.Name = "cmsAttachDoc"
        Me.cmsDoctorMenu.Size = New System.Drawing.Size(168, 48)
        '
        'itmDoctorCall
        '
        Me.itmDoctorCall.Name = "itmDoctorCall"
        Me.itmDoctorCall.Size = New System.Drawing.Size(167, 22)
        Me.itmDoctorCall.Text = "Atzvanоts"
        '
        'itmUserCard
        '
        Me.itmUserCard.Name = "itmUserCard"
        Me.itmUserCard.Size = New System.Drawing.Size(167, 22)
        Me.itmUserCard.Text = "Darbinieka kartiтa"
        '
        'frmPlanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 473)
        Me.Controls.Add(Me.grdPlanner)
        Me.Controls.Add(Me.gbhPlanner)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(1000, 500)
        Me.Name = "frmPlanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vizīšu plānotājs"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtSpeciality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndSpeciality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDoctor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.bndData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.grdPlanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwPlanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbhPlanner.ResumeLayout(False)
        Me.gbhPlanner.PerformLayout()
        Me.cmsMenu.ResumeLayout(False)
        Me.cmsDoctorMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents mcaThisMonth As System.Windows.Forms.MonthCalendar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents rbt7 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents bndData As System.Windows.Forms.BindingSource
    Friend WithEvents grdPlanner As Core.UI.CoreGrid
    Friend WithEvents gvwPlanner As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMonday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTuesday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWednesday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThursday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFriday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaturday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSunday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents colMondayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTuesdayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWednesdayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThursdayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFridayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaturdayValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSundayvalue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colDoctor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblService As System.Windows.Forms.Label
    Friend WithEvents gbhPlanner As Core.UI.GridButtonHelper
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents chkVisitPlaner As System.Windows.Forms.CheckBox
    Friend WithEvents chkVisitStatusViewer As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroupPlaner As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bndSpeciality As System.Windows.Forms.BindingSource
    Friend WithEvents txtService As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bndServices As System.Windows.Forms.BindingSource
    Friend WithEvents cmsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents itmCalled As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmPatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDoctor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bndUser As System.Windows.Forms.BindingSource
    Friend WithEvents txtSpeciality As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cmsDoctorMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents itmDoctorCall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itmUserCard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkDoublePatients As System.Windows.Forms.CheckBox
End Class
