Imports System
Imports System.Collections.Generic
Imports NHibernate
Imports Core
'ёй
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlVisitsFinder
    Inherits ctlFind

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        If DesignMode Then Return
        If DesignerDetector.IsComponentInDesignMode(Me) Then Return
        ' Dim coll As New Core.Bll.BusinessCollectionBase(Of Entities.Position)


        '        coll.CriteriaDelegate = AddressOf Entities.Position.ApplyCriteriaAsc
        '       coll.FetchWithCriteria()

        ' bindFindUsers.DataSource = so
        ' bindPositions.DataSource = coll

        ' If coll.Count > 0 Then
        ' so.Position = coll.Item(0)
        ' End If

    End Sub


    'UserControl overrides dispose to clean up the component list.
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
        Me.panTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.chkCreatePlace = New System.Windows.Forms.CheckBox()
        Me.txtRoom = New Client.ClassifierPicker()
        Me.chkRoom = New System.Windows.Forms.CheckBox()
        Me.chkStartDate = New System.Windows.Forms.CheckBox()
        Me.chkDoctor = New System.Windows.Forms.CheckBox()
        Me.txtDoctor = New Client.ClassifierPicker()
        Me.PeriodWithTimePicker = New Core.UI.PeriodWithTimePicker()
        Me.chkService = New System.Windows.Forms.CheckBox()
        Me.txtService = New Client.ClassifierPicker()
        Me.chkServiceType = New System.Windows.Forms.CheckBox()
        Me.chkMedicalSpecialization = New System.Windows.Forms.CheckBox()
        Me.chkBussinesGroup = New System.Windows.Forms.CheckBox()
        Me.txtServiceType = New Client.ClassifierPicker()
        Me.txtMedicalSpecialization = New Client.ClassifierPicker()
        Me.txtBussinesGroup = New Client.ClassifierPicker()
        Me.chkCreateDate = New System.Windows.Forms.CheckBox()
        Me.iodWithTimePicker = New Core.UI.PeriodWithTimePickerSecond()
        Me.txtCreatePlace = New System.Windows.Forms.TextBox()
        Me.txtUserGrouping = New Client.ClassifierPicker()
        Me.chkUserGrouping = New System.Windows.Forms.CheckBox()
        Me.txtPatient = New Client.ClassifierPicker()
        Me.chkPatient = New System.Windows.Forms.CheckBox()
        Me.txtPaymentType = New Client.ClassifierPicker()
        Me.chkPaymentType = New System.Windows.Forms.CheckBox()
        Me.txtCampaigns = New Client.ClassifierPicker()
        Me.chkCampaigns = New System.Windows.Forms.CheckBox()
        Me.txtPatientGroup = New System.Windows.Forms.TextBox()
        Me.chkPatientGroup = New System.Windows.Forms.CheckBox()
        Me.txtSpeciality = New Client.ClassifierPicker()
        Me.chkSpeciality = New System.Windows.Forms.CheckBox()
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTableLayout.SuspendLayout()
        CType(Me.txtRoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDoctor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServiceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedicalSpecialization.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBussinesGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserGrouping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaymentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCampaigns.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSpeciality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bndFind
        '
        Me.bndFind.DataSource = GetType(Entities.VisitsFinder)
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(440, 3)
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(309, 3)
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(521, 3)
        '
        'btnHideNonChecked
        '
        Me.btnHideNonChecked.Location = New System.Drawing.Point(161, 3)
        '
        'panTableLayout
        '
        Me.panTableLayout.AutoSize = True
        Me.panTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panTableLayout.ColumnCount = 2
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panTableLayout.Controls.Add(Me.chkCreatePlace, 0, 8)
        Me.panTableLayout.Controls.Add(Me.txtRoom, 1, 5)
        Me.panTableLayout.Controls.Add(Me.chkRoom, 0, 5)
        Me.panTableLayout.Controls.Add(Me.chkStartDate, 0, 6)
        Me.panTableLayout.Controls.Add(Me.chkDoctor, 0, 0)
        Me.panTableLayout.Controls.Add(Me.txtDoctor, 1, 0)
        Me.panTableLayout.Controls.Add(Me.PeriodWithTimePicker, 1, 6)
        Me.panTableLayout.Controls.Add(Me.chkService, 0, 1)
        Me.panTableLayout.Controls.Add(Me.txtService, 1, 1)
        Me.panTableLayout.Controls.Add(Me.chkServiceType, 0, 2)
        Me.panTableLayout.Controls.Add(Me.chkMedicalSpecialization, 0, 3)
        Me.panTableLayout.Controls.Add(Me.chkBussinesGroup, 0, 4)
        Me.panTableLayout.Controls.Add(Me.txtServiceType, 1, 2)
        Me.panTableLayout.Controls.Add(Me.txtMedicalSpecialization, 1, 3)
        Me.panTableLayout.Controls.Add(Me.txtBussinesGroup, 1, 4)
        Me.panTableLayout.Controls.Add(Me.chkCreateDate, 0, 7)
        Me.panTableLayout.Controls.Add(Me.iodWithTimePicker, 1, 7)
        Me.panTableLayout.Controls.Add(Me.txtCreatePlace, 1, 8)
        Me.panTableLayout.Controls.Add(Me.txtUserGrouping, 1, 10)
        Me.panTableLayout.Controls.Add(Me.chkUserGrouping, 0, 10)
        Me.panTableLayout.Controls.Add(Me.txtPatient, 1, 11)
        Me.panTableLayout.Controls.Add(Me.chkPatient, 0, 11)
        Me.panTableLayout.Controls.Add(Me.txtPaymentType, 1, 12)
        Me.panTableLayout.Controls.Add(Me.chkPaymentType, 0, 12)
        Me.panTableLayout.Controls.Add(Me.txtCampaigns, 1, 13)
        Me.panTableLayout.Controls.Add(Me.chkCampaigns, 0, 13)
        Me.panTableLayout.Controls.Add(Me.txtPatientGroup, 1, 14)
        Me.panTableLayout.Controls.Add(Me.chkPatientGroup, 0, 14)
        Me.panTableLayout.Controls.Add(Me.txtSpeciality, 1, 15)
        Me.panTableLayout.Controls.Add(Me.chkSpeciality, 0, 15)
        Me.panTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.panTableLayout.Name = "panTableLayout"
        Me.panTableLayout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.panTableLayout.RowCount = 16
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.Size = New System.Drawing.Size(694, 394)
        Me.panTableLayout.TabIndex = 3
        '
        'chkCreatePlace
        '
        Me.chkCreatePlace.AutoSize = True
        Me.chkCreatePlace.Location = New System.Drawing.Point(3, 215)
        Me.chkCreatePlace.Name = "chkCreatePlace"
        Me.chkCreatePlace.Size = New System.Drawing.Size(91, 17)
        Me.chkCreatePlace.TabIndex = 181
        Me.chkCreatePlace.Text = "Izveides vieta"
        Me.chkCreatePlace.UseVisualStyleBackColor = True
        '
        'txtRoom
        '
        Me.txtRoom.AllowDrop = True
        Me.txtRoom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRoom.Location = New System.Drawing.Point(137, 133)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.PickerPresets = Nothing
        Me.txtRoom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtRoom.Properties.ReadOnly = True
        Me.txtRoom.Size = New System.Drawing.Size(539, 20)
        Me.txtRoom.TabIndex = 168
        '
        'chkRoom
        '
        Me.chkRoom.AutoSize = True
        Me.chkRoom.Location = New System.Drawing.Point(3, 133)
        Me.chkRoom.Name = "chkRoom"
        Me.chkRoom.Size = New System.Drawing.Size(67, 17)
        Me.chkRoom.TabIndex = 7
        Me.chkRoom.Text = "Kabinets"
        Me.chkRoom.UseVisualStyleBackColor = True
        '
        'chkStartDate
        '
        Me.chkStartDate.AutoSize = True
        Me.chkStartDate.Location = New System.Drawing.Point(3, 159)
        Me.chkStartDate.Name = "chkStartDate"
        Me.chkStartDate.Size = New System.Drawing.Size(109, 17)
        Me.chkStartDate.TabIndex = 8
        Me.chkStartDate.Text = "Vizītes datums no"
        Me.chkStartDate.UseVisualStyleBackColor = True
        '
        'chkDoctor
        '
        Me.chkDoctor.AutoSize = True
        Me.chkDoctor.Location = New System.Drawing.Point(3, 3)
        Me.chkDoctor.Name = "chkDoctor"
        Me.chkDoctor.Size = New System.Drawing.Size(49, 17)
        Me.chkDoctor.TabIndex = 6
        Me.chkDoctor.Text = "Ārsts"
        Me.chkDoctor.UseVisualStyleBackColor = True
        '
        'txtDoctor
        '
        Me.txtDoctor.AllowDrop = True
        Me.txtDoctor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDoctor.Location = New System.Drawing.Point(137, 3)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.PickerPresets = Nothing
        Me.txtDoctor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDoctor.Properties.ReadOnly = True
        Me.txtDoctor.Size = New System.Drawing.Size(539, 20)
        Me.txtDoctor.TabIndex = 167
        '
        'PeriodWithTimePicker
        '
        Me.PeriodWithTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PeriodWithTimePicker.AutoSize = True
        Me.PeriodWithTimePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PeriodWithTimePicker.Location = New System.Drawing.Point(137, 159)
        Me.PeriodWithTimePicker.Name = "PeriodWithTimePicker"
        Me.PeriodWithTimePicker.Size = New System.Drawing.Size(539, 20)
        Me.PeriodWithTimePicker.TabIndex = 169
        '
        'chkService
        '
        Me.chkService.AutoSize = True
        Me.chkService.Location = New System.Drawing.Point(3, 29)
        Me.chkService.Name = "chkService"
        Me.chkService.Size = New System.Drawing.Size(86, 17)
        Me.chkService.TabIndex = 170
        Me.chkService.Text = "Pakalpojums"
        Me.chkService.UseVisualStyleBackColor = True
        '
        'txtService
        '
        Me.txtService.AllowDrop = True
        Me.txtService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtService.Location = New System.Drawing.Point(137, 29)
        Me.txtService.Name = "txtService"
        Me.txtService.PickerPresets = Nothing
        Me.txtService.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtService.Properties.ReadOnly = True
        Me.txtService.Size = New System.Drawing.Size(539, 20)
        Me.txtService.TabIndex = 171
        '
        'chkServiceType
        '
        Me.chkServiceType.AutoSize = True
        Me.chkServiceType.Location = New System.Drawing.Point(3, 55)
        Me.chkServiceType.Name = "chkServiceType"
        Me.chkServiceType.Size = New System.Drawing.Size(106, 17)
        Me.chkServiceType.TabIndex = 172
        Me.chkServiceType.Text = "Pakalpojuma tips"
        Me.chkServiceType.UseVisualStyleBackColor = True
        '
        'chkMedicalSpecialization
        '
        Me.chkMedicalSpecialization.AutoSize = True
        Me.chkMedicalSpecialization.Location = New System.Drawing.Point(3, 81)
        Me.chkMedicalSpecialization.Name = "chkMedicalSpecialization"
        Me.chkMedicalSpecialization.Size = New System.Drawing.Size(116, 17)
        Me.chkMedicalSpecialization.TabIndex = 173
        Me.chkMedicalSpecialization.Text = "Medic. specializāc."
        Me.chkMedicalSpecialization.UseVisualStyleBackColor = True
        '
        'chkBussinesGroup
        '
        Me.chkBussinesGroup.AutoSize = True
        Me.chkBussinesGroup.Location = New System.Drawing.Point(3, 107)
        Me.chkBussinesGroup.Name = "chkBussinesGroup"
        Me.chkBussinesGroup.Size = New System.Drawing.Size(114, 17)
        Me.chkBussinesGroup.TabIndex = 174
        Me.chkBussinesGroup.Text = "Biznesa grupējums"
        Me.chkBussinesGroup.UseVisualStyleBackColor = True
        '
        'txtServiceType
        '
        Me.txtServiceType.AllowDrop = True
        Me.txtServiceType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtServiceType.Location = New System.Drawing.Point(137, 55)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.PickerPresets = Nothing
        Me.txtServiceType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtServiceType.Properties.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(539, 20)
        Me.txtServiceType.TabIndex = 175
        '
        'txtMedicalSpecialization
        '
        Me.txtMedicalSpecialization.AllowDrop = True
        Me.txtMedicalSpecialization.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMedicalSpecialization.Location = New System.Drawing.Point(137, 81)
        Me.txtMedicalSpecialization.Name = "txtMedicalSpecialization"
        Me.txtMedicalSpecialization.PickerPresets = Nothing
        Me.txtMedicalSpecialization.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtMedicalSpecialization.Properties.ReadOnly = True
        Me.txtMedicalSpecialization.Size = New System.Drawing.Size(539, 20)
        Me.txtMedicalSpecialization.TabIndex = 176
        '
        'txtBussinesGroup
        '
        Me.txtBussinesGroup.AllowDrop = True
        Me.txtBussinesGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBussinesGroup.Location = New System.Drawing.Point(137, 107)
        Me.txtBussinesGroup.Name = "txtBussinesGroup"
        Me.txtBussinesGroup.PickerPresets = Nothing
        Me.txtBussinesGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtBussinesGroup.Properties.ReadOnly = True
        Me.txtBussinesGroup.Size = New System.Drawing.Size(539, 20)
        Me.txtBussinesGroup.TabIndex = 177
        '
        'chkCreateDate
        '
        Me.chkCreateDate.AutoSize = True
        Me.chkCreateDate.Location = New System.Drawing.Point(3, 185)
        Me.chkCreateDate.Name = "chkCreateDate"
        Me.chkCreateDate.Size = New System.Drawing.Size(102, 17)
        Me.chkCreateDate.TabIndex = 178
        Me.chkCreateDate.Text = "Izveides datums"
        Me.chkCreateDate.UseVisualStyleBackColor = True
        '
        'iodWithTimePicker
        '
        Me.iodWithTimePicker.Location = New System.Drawing.Point(137, 185)
        Me.iodWithTimePicker.Name = "iodWithTimePicker"
        Me.iodWithTimePicker.Size = New System.Drawing.Size(403, 24)
        Me.iodWithTimePicker.TabIndex = 179
        '
        'txtCreatePlace
        '
        Me.txtCreatePlace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCreatePlace.Location = New System.Drawing.Point(137, 215)
        Me.txtCreatePlace.Name = "txtCreatePlace"
        Me.txtCreatePlace.Size = New System.Drawing.Size(539, 20)
        Me.txtCreatePlace.TabIndex = 180
        '
        'txtUserGrouping
        '
        Me.txtUserGrouping.AllowDrop = True
        Me.txtUserGrouping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUserGrouping.Location = New System.Drawing.Point(137, 241)
        Me.txtUserGrouping.Name = "txtUserGrouping"
        Me.txtUserGrouping.PickerPresets = Nothing
        Me.txtUserGrouping.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtUserGrouping.Properties.ReadOnly = True
        Me.txtUserGrouping.Size = New System.Drawing.Size(539, 20)
        Me.txtUserGrouping.TabIndex = 183
        '
        'chkUserGrouping
        '
        Me.chkUserGrouping.AutoSize = True
        Me.chkUserGrouping.Location = New System.Drawing.Point(3, 241)
        Me.chkUserGrouping.Name = "chkUserGrouping"
        Me.chkUserGrouping.Size = New System.Drawing.Size(128, 17)
        Me.chkUserGrouping.TabIndex = 182
        Me.chkUserGrouping.Text = "Darbinieku grupējums"
        Me.chkUserGrouping.UseVisualStyleBackColor = True
        '
        'txtPatient
        '
        Me.txtPatient.AllowDrop = True
        Me.txtPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPatient.Location = New System.Drawing.Point(137, 267)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.PickerPresets = Nothing
        Me.txtPatient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPatient.Properties.ReadOnly = True
        Me.txtPatient.Size = New System.Drawing.Size(539, 20)
        Me.txtPatient.TabIndex = 185
        '
        'chkPatient
        '
        Me.chkPatient.AutoSize = True
        Me.chkPatient.Location = New System.Drawing.Point(3, 267)
        Me.chkPatient.Name = "chkPatient"
        Me.chkPatient.Size = New System.Drawing.Size(57, 17)
        Me.chkPatient.TabIndex = 184
        Me.chkPatient.Text = "Klients"
        Me.chkPatient.UseVisualStyleBackColor = True
        '
        'txtPaymentType
        '
        Me.txtPaymentType.AllowDrop = True
        Me.txtPaymentType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPaymentType.Location = New System.Drawing.Point(137, 293)
        Me.txtPaymentType.Name = "txtPaymentType"
        Me.txtPaymentType.PickerPresets = Nothing
        Me.txtPaymentType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPaymentType.Properties.ReadOnly = True
        Me.txtPaymentType.Size = New System.Drawing.Size(539, 20)
        Me.txtPaymentType.TabIndex = 187
        '
        'chkPaymentType
        '
        Me.chkPaymentType.AutoSize = True
        Me.chkPaymentType.Location = New System.Drawing.Point(3, 293)
        Me.chkPaymentType.Name = "chkPaymentType"
        Me.chkPaymentType.Size = New System.Drawing.Size(103, 17)
        Me.chkPaymentType.TabIndex = 186
        Me.chkPaymentType.Text = "Apmaksas veids"
        Me.chkPaymentType.UseVisualStyleBackColor = True
        '
        'txtCampaigns
        '
        Me.txtCampaigns.AllowDrop = True
        Me.txtCampaigns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCampaigns.Location = New System.Drawing.Point(137, 319)
        Me.txtCampaigns.Name = "txtCampaigns"
        Me.txtCampaigns.PickerPresets = Nothing
        Me.txtCampaigns.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCampaigns.Properties.ReadOnly = True
        Me.txtCampaigns.Size = New System.Drawing.Size(539, 20)
        Me.txtCampaigns.TabIndex = 192
        '
        'chkCampaigns
        '
        Me.chkCampaigns.AutoSize = True
        Me.chkCampaigns.Location = New System.Drawing.Point(3, 319)
        Me.chkCampaigns.Name = "chkCampaigns"
        Me.chkCampaigns.Size = New System.Drawing.Size(63, 17)
        Me.chkCampaigns.TabIndex = 191
        Me.chkCampaigns.Text = "Akcijas:"
        Me.chkCampaigns.UseVisualStyleBackColor = True
        '
        'txtPatientGroup
        '
        Me.txtPatientGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPatientGroup.Location = New System.Drawing.Point(137, 345)
        Me.txtPatientGroup.Name = "txtPatientGroup"
        Me.txtPatientGroup.Size = New System.Drawing.Size(539, 20)
        Me.txtPatientGroup.TabIndex = 194
        '
        'chkPatientGroup
        '
        Me.chkPatientGroup.AutoSize = True
        Me.chkPatientGroup.Location = New System.Drawing.Point(3, 345)
        Me.chkPatientGroup.Name = "chkPatientGroup"
        Me.chkPatientGroup.Size = New System.Drawing.Size(91, 17)
        Me.chkPatientGroup.TabIndex = 193
        Me.chkPatientGroup.Text = "Klienta grupa:"
        Me.chkPatientGroup.UseVisualStyleBackColor = True
        '
        'txtSpeciality
        '
        Me.txtSpeciality.AllowDrop = True
        Me.txtSpeciality.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSpeciality.Location = New System.Drawing.Point(137, 371)
        Me.txtSpeciality.Name = "txtSpeciality"
        Me.txtSpeciality.PickerPresets = Nothing
        Me.txtSpeciality.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtSpeciality.Properties.ReadOnly = True
        Me.txtSpeciality.Size = New System.Drawing.Size(539, 20)
        Me.txtSpeciality.TabIndex = 196
        '
        'chkSpeciality
        '
        Me.chkSpeciality.AutoSize = True
        Me.chkSpeciality.Location = New System.Drawing.Point(3, 371)
        Me.chkSpeciality.Name = "chkSpeciality"
        Me.chkSpeciality.Size = New System.Drawing.Size(84, 17)
        Me.chkSpeciality.TabIndex = 195
        Me.chkSpeciality.Text = "Specialitāte:"
        Me.chkSpeciality.UseVisualStyleBackColor = True
        '
        'ctlVisitsFinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.panTableLayout)
        Me.CriteriaTable = Me.panTableLayout
        Me.Name = "ctlVisitsFinder"
        Me.Size = New System.Drawing.Size(694, 424)
        Me.Controls.SetChildIndex(Me.panTableLayout, 0)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTableLayout.ResumeLayout(False)
        Me.panTableLayout.PerformLayout()
        CType(Me.txtRoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDoctor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServiceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedicalSpecialization.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBussinesGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaymentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCampaigns.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSpeciality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtRoom As Client.ClassifierPicker
    Friend WithEvents chkRoom As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkDoctor As System.Windows.Forms.CheckBox
    Friend WithEvents txtDoctor As Client.ClassifierPicker
    Friend WithEvents PeriodWithTimePicker As Core.UI.PeriodWithTimePicker
    Friend WithEvents chkService As System.Windows.Forms.CheckBox
    Friend WithEvents txtService As Client.ClassifierPicker
    Friend WithEvents chkServiceType As System.Windows.Forms.CheckBox
    Friend WithEvents chkMedicalSpecialization As System.Windows.Forms.CheckBox
    Friend WithEvents chkBussinesGroup As System.Windows.Forms.CheckBox
    Friend WithEvents txtServiceType As Client.ClassifierPicker
    Friend WithEvents txtMedicalSpecialization As Client.ClassifierPicker
    Friend WithEvents txtBussinesGroup As Client.ClassifierPicker
    Friend WithEvents chkCreateDate As System.Windows.Forms.CheckBox
    Friend WithEvents iodWithTimePicker As Core.UI.PeriodWithTimePickerSecond
    Friend WithEvents chkCreatePlace As System.Windows.Forms.CheckBox
    Friend WithEvents txtCreatePlace As System.Windows.Forms.TextBox
    Friend WithEvents chkUserGrouping As System.Windows.Forms.CheckBox
    Friend WithEvents txtUserGrouping As Client.ClassifierPicker
    Friend WithEvents txtPatient As Client.ClassifierPicker
    Friend WithEvents chkPatient As System.Windows.Forms.CheckBox
    Friend WithEvents txtPaymentType As Client.ClassifierPicker
    Friend WithEvents chkPaymentType As System.Windows.Forms.CheckBox
    Friend WithEvents chkCampaigns As System.Windows.Forms.CheckBox
    Friend WithEvents txtCampaigns As Client.ClassifierPicker
    Friend WithEvents chkPatientGroup As System.Windows.Forms.CheckBox
    Friend WithEvents txtPatientGroup As System.Windows.Forms.TextBox
    Friend WithEvents txtSpeciality As Client.ClassifierPicker
    Friend WithEvents chkSpeciality As System.Windows.Forms.CheckBox

End Class
