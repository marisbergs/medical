<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
    Inherits Client.frmUIBase
    'ёй
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition8 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition9 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition10 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition11 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition12 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition13 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition14 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition15 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition16 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.bndUsers = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.CtlUsersFind = New Client.ctlUsersFind()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grdUser = New Core.UI.CoreGrid()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPosition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpecialities = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLanguages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSystemUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grdUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        Me.colIsActive.OptionsColumn.AllowEdit = False
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "\d{0,10}(\R.\d{0,2})?"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.RepositoryItemTextEdit2.Mask.SaveLiteral = False
        Me.RepositoryItemTextEdit2.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "###########,##0.00"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.ShowPlaceHolders = False
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(790, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
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
        'btnDisable
        '
        Me.btnDisable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDisable.Location = New System.Drawing.Point(159, 3)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(69, 23)
        Me.btnDisable.TabIndex = 3
        Me.btnDisable.Text = "Atslēgt"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'bndUsers
        '
        Me.bndUsers.DataSource = GetType(Entities.User)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 374)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 33)
        Me.Panel1.TabIndex = 6
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOpen)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDisable)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOK)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(615, 29)
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
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(234, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Dzēst"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(315, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "Labi"
        Me.btnOK.UseVisualStyleBackColor = True
        Me.btnOK.Visible = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Location = New System.Drawing.Point(396, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Eksportēt uz Word"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Location = New System.Drawing.Point(507, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Eksportēt uz Excel"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'pnlSearch
        '
        Me.pnlSearch.AutoSize = True
        Me.pnlSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlSearch.Location = New System.Drawing.Point(236, 12)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(0, 0)
        Me.pnlSearch.TabIndex = 0
        '
        'CtlUsersFind
        '
        Me.CtlUsersFind.AutoSize = True
        Me.CtlUsersFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CtlUsersFind.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUsersFind.Location = New System.Drawing.Point(0, 0)
        Me.CtlUsersFind.MinimumSize = New System.Drawing.Size(403, 0)
        Me.CtlUsersFind.Name = "CtlUsersFind"
        Me.CtlUsersFind.Size = New System.Drawing.Size(862, 212)
        Me.CtlUsersFind.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.grdUser)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 212)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(862, 162)
        Me.Panel2.TabIndex = 7
        '
        'grdUser
        '
        Me.grdUser.DataSource = Me.bndUsers
        Me.grdUser.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.grdUser.EmbeddedNavigator.Name = ""
        Me.grdUser.EnforceCanEdit = False
        Me.grdUser.Location = New System.Drawing.Point(0, 0)
        Me.grdUser.MainView = Me.GridView1
        Me.grdUser.Name = "grdUser"
        Me.grdUser.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.grdUser.ShowOnlyActive = False
        Me.grdUser.Size = New System.Drawing.Size(862, 162)
        Me.grdUser.TabIndex = 6
        Me.grdUser.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSelected, Me.colFullName, Me.colPosition, Me.colSpecialities, Me.colLanguages, Me.colPhone, Me.colEmail, Me.colIsSystemUser, Me.colIsActive, Me.colPK, Me.colCode, Me.GridColumn1})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Crimson
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colIsActive
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = False
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Crimson
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colIsActive
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = False
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Crimson
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colIsActive
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = False
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Crimson
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colIsActive
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = False
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.Crimson
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.colIsActive
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Value1 = False
        StyleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition6.Appearance.Options.UseForeColor = True
        StyleFormatCondition6.ApplyToRow = True
        StyleFormatCondition6.Column = Me.colIsActive
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition6.Value1 = False
        StyleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition7.Appearance.Options.UseForeColor = True
        StyleFormatCondition7.ApplyToRow = True
        StyleFormatCondition7.Column = Me.colIsActive
        StyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition7.Value1 = False
        StyleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition8.Appearance.Options.UseForeColor = True
        StyleFormatCondition8.ApplyToRow = True
        StyleFormatCondition8.Column = Me.colIsActive
        StyleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition8.Value1 = False
        StyleFormatCondition9.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition9.Appearance.Options.UseForeColor = True
        StyleFormatCondition9.ApplyToRow = True
        StyleFormatCondition9.Column = Me.colIsActive
        StyleFormatCondition9.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition9.Value1 = False
        StyleFormatCondition10.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition10.Appearance.Options.UseForeColor = True
        StyleFormatCondition10.ApplyToRow = True
        StyleFormatCondition10.Column = Me.colIsActive
        StyleFormatCondition10.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition10.Value1 = False
        StyleFormatCondition11.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition11.Appearance.Options.UseForeColor = True
        StyleFormatCondition11.ApplyToRow = True
        StyleFormatCondition11.Column = Me.colIsActive
        StyleFormatCondition11.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition11.Value1 = False
        StyleFormatCondition12.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition12.Appearance.Options.UseForeColor = True
        StyleFormatCondition12.ApplyToRow = True
        StyleFormatCondition12.Column = Me.colIsActive
        StyleFormatCondition12.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition12.Value1 = False
        StyleFormatCondition13.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition13.Appearance.Options.UseForeColor = True
        StyleFormatCondition13.ApplyToRow = True
        StyleFormatCondition13.Column = Me.colIsActive
        StyleFormatCondition13.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition13.Value1 = False
        StyleFormatCondition14.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition14.Appearance.Options.UseForeColor = True
        StyleFormatCondition14.ApplyToRow = True
        StyleFormatCondition14.Column = Me.colIsActive
        StyleFormatCondition14.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition14.Value1 = False
        StyleFormatCondition15.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition15.Appearance.Options.UseForeColor = True
        StyleFormatCondition15.ApplyToRow = True
        StyleFormatCondition15.Column = Me.colIsActive
        StyleFormatCondition15.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition15.Value1 = False
        StyleFormatCondition16.Appearance.ForeColor = System.Drawing.Color.SaddleBrown
        StyleFormatCondition16.Appearance.Options.UseForeColor = True
        StyleFormatCondition16.ApplyToRow = True
        StyleFormatCondition16.Column = Me.colIsActive
        StyleFormatCondition16.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition16.Value1 = False
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5, StyleFormatCondition6, StyleFormatCondition7, StyleFormatCondition8, StyleFormatCondition9, StyleFormatCondition10, StyleFormatCondition11, StyleFormatCondition12, StyleFormatCondition13, StyleFormatCondition14, StyleFormatCondition15, StyleFormatCondition16})
        Me.GridView1.GridControl = Me.grdUser
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFullName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSelected
        '
        Me.colSelected.FieldName = "Selected"
        Me.colSelected.Name = "colSelected"
        Me.colSelected.Width = 20
        '
        'colFullName
        '
        Me.colFullName.Caption = "Darbinieks"
        Me.colFullName.FieldName = "FullName"
        Me.colFullName.Name = "colFullName"
        Me.colFullName.OptionsColumn.AllowEdit = False
        Me.colFullName.OptionsColumn.ReadOnly = True
        Me.colFullName.Visible = True
        Me.colFullName.VisibleIndex = 0
        Me.colFullName.Width = 239
        '
        'colPosition
        '
        Me.colPosition.Caption = "Amats"
        Me.colPosition.FieldName = "Position"
        Me.colPosition.Name = "colPosition"
        Me.colPosition.OptionsColumn.AllowEdit = False
        Me.colPosition.OptionsColumn.ReadOnly = True
        Me.colPosition.Visible = True
        Me.colPosition.VisibleIndex = 2
        Me.colPosition.Width = 178
        '
        'colSpecialities
        '
        Me.colSpecialities.Caption = "Specialitātes"
        Me.colSpecialities.FieldName = "Specialities"
        Me.colSpecialities.Name = "colSpecialities"
        Me.colSpecialities.Visible = True
        Me.colSpecialities.VisibleIndex = 3
        Me.colSpecialities.Width = 209
        '
        'colLanguages
        '
        Me.colLanguages.Caption = "Valodas"
        Me.colLanguages.FieldName = "Languages"
        Me.colLanguages.Name = "colLanguages"
        Me.colLanguages.Width = 121
        '
        'colPhone
        '
        Me.colPhone.Caption = "Tālrunis"
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.OptionsColumn.AllowEdit = False
        Me.colPhone.OptionsColumn.ReadOnly = True
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 4
        Me.colPhone.Width = 94
        '
        'colEmail
        '
        Me.colEmail.Caption = "E-pasts"
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 5
        Me.colEmail.Width = 148
        '
        'colIsSystemUser
        '
        Me.colIsSystemUser.Caption = "Lietotājs"
        Me.colIsSystemUser.FieldName = "IsSystemUser"
        Me.colIsSystemUser.Name = "colIsSystemUser"
        Me.colIsSystemUser.OptionsColumn.AllowEdit = False
        Me.colIsSystemUser.OptionsColumn.ReadOnly = True
        Me.colIsSystemUser.Visible = True
        Me.colIsSystemUser.VisibleIndex = 7
        Me.colIsSystemUser.Width = 71
        '
        'colPK
        '
        Me.colPK.Caption = "PK"
        Me.colPK.FieldName = "PK"
        Me.colPK.Name = "colPK"
        '
        'colCode
        '
        Me.colCode.Caption = "P.k."
        Me.colCode.FieldName = "PK"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 1
        Me.colCode.Width = 122
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Veids"
        Me.GridColumn1.FieldName = "UserGrouping"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 123
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 407)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CtlUsersFind)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSearch)
        Me.MinimumSize = New System.Drawing.Size(477, 434)
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Darbinieku saraksts"
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.grdUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnDisable As System.Windows.Forms.Button
    Friend WithEvents LastIPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsersIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReplaceToDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CertDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChangeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReplaceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CloseDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoleIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OtherNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NisIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtlUsersFind As Client.ctlUsersFind
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents grdUser As Core.UI.CoreGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPosition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents bndUsers As System.Windows.Forms.BindingSource
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSystemUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colSpecialities As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLanguages As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
