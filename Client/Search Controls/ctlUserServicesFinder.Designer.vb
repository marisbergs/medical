Imports System
Imports System.Collections.Generic
Imports NHibernate
Imports Core
'ёй
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlUserServicesFinder
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
        Me.components = New System.ComponentModel.Container()
        Me.panTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.chkSpeciality = New System.Windows.Forms.CheckBox()
        Me.chkBussinesGroup = New System.Windows.Forms.CheckBox()
        Me.chkServiceType = New System.Windows.Forms.CheckBox()
        Me.txtServiceType = New Client.ClassifierPicker()
        Me.chkMedicalSpecialization = New System.Windows.Forms.CheckBox()
        Me.txtMedicalSpecialization = New Client.ClassifierPicker()
        Me.txtBussinesGroup = New Client.ClassifierPicker()
        Me.txtSpeciality = New Client.ClassifierPicker()
        Me.txtDoctor = New Client.ClassifierPicker()
        Me.chkDoctor = New System.Windows.Forms.CheckBox()
        Me.chkValidAt = New System.Windows.Forms.CheckBox()
        Me.dtpValidAt = New DevExpress.XtraEditors.DateEdit()
        Me.bndIsSystemUser = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTableLayout.SuspendLayout()
        CType(Me.txtServiceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedicalSpecialization.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBussinesGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSpeciality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDoctor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpValidAt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndIsSystemUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bndFind
        '
        Me.bndFind.DataSource = GetType(Entities.FindUsers)
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(292, 3)
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(161, 3)
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(373, 3)
        '
        'btnHideNonChecked
        '
        Me.btnHideNonChecked.Location = New System.Drawing.Point(13, 3)
        '
        'panTableLayout
        '
        Me.panTableLayout.AutoSize = True
        Me.panTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panTableLayout.ColumnCount = 2
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panTableLayout.Controls.Add(Me.chkSpeciality, 0, 3)
        Me.panTableLayout.Controls.Add(Me.chkBussinesGroup, 0, 2)
        Me.panTableLayout.Controls.Add(Me.chkServiceType, 0, 0)
        Me.panTableLayout.Controls.Add(Me.txtServiceType, 1, 0)
        Me.panTableLayout.Controls.Add(Me.chkMedicalSpecialization, 0, 1)
        Me.panTableLayout.Controls.Add(Me.txtMedicalSpecialization, 1, 1)
        Me.panTableLayout.Controls.Add(Me.txtBussinesGroup, 1, 2)
        Me.panTableLayout.Controls.Add(Me.txtSpeciality, 1, 3)
        Me.panTableLayout.Controls.Add(Me.txtDoctor, 1, 4)
        Me.panTableLayout.Controls.Add(Me.chkDoctor, 0, 4)
        Me.panTableLayout.Controls.Add(Me.chkValidAt, 0, 5)
        Me.panTableLayout.Controls.Add(Me.dtpValidAt, 1, 5)
        Me.panTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.panTableLayout.Name = "panTableLayout"
        Me.panTableLayout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.panTableLayout.RowCount = 9
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panTableLayout.Size = New System.Drawing.Size(546, 156)
        Me.panTableLayout.TabIndex = 2
        '
        'chkSpeciality
        '
        Me.chkSpeciality.AutoSize = True
        Me.chkSpeciality.Location = New System.Drawing.Point(3, 81)
        Me.chkSpeciality.Name = "chkSpeciality"
        Me.chkSpeciality.Size = New System.Drawing.Size(84, 17)
        Me.chkSpeciality.TabIndex = 7
        Me.chkSpeciality.Text = "Specialitāte:"
        Me.chkSpeciality.UseVisualStyleBackColor = True
        '
        'chkBussinesGroup
        '
        Me.chkBussinesGroup.AutoSize = True
        Me.chkBussinesGroup.Location = New System.Drawing.Point(3, 55)
        Me.chkBussinesGroup.Name = "chkBussinesGroup"
        Me.chkBussinesGroup.Size = New System.Drawing.Size(114, 17)
        Me.chkBussinesGroup.TabIndex = 10
        Me.chkBussinesGroup.Text = "Biznesa grupējums"
        Me.chkBussinesGroup.UseVisualStyleBackColor = True
        '
        'chkServiceType
        '
        Me.chkServiceType.AutoSize = True
        Me.chkServiceType.Location = New System.Drawing.Point(3, 3)
        Me.chkServiceType.Name = "chkServiceType"
        Me.chkServiceType.Size = New System.Drawing.Size(109, 17)
        Me.chkServiceType.TabIndex = 6
        Me.chkServiceType.Text = "Pakalpojuma tips:"
        Me.chkServiceType.UseVisualStyleBackColor = True
        '
        'txtServiceType
        '
        Me.txtServiceType.AllowDrop = True
        Me.txtServiceType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtServiceType.Location = New System.Drawing.Point(125, 3)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.PickerPresets = Nothing
        Me.txtServiceType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtServiceType.Properties.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(403, 20)
        Me.txtServiceType.TabIndex = 167
        '
        'chkMedicalSpecialization
        '
        Me.chkMedicalSpecialization.AutoSize = True
        Me.chkMedicalSpecialization.Location = New System.Drawing.Point(3, 29)
        Me.chkMedicalSpecialization.Name = "chkMedicalSpecialization"
        Me.chkMedicalSpecialization.Size = New System.Drawing.Size(116, 17)
        Me.chkMedicalSpecialization.TabIndex = 169
        Me.chkMedicalSpecialization.Text = "Medic. specializāc."
        Me.chkMedicalSpecialization.UseVisualStyleBackColor = True
        '
        'txtMedicalSpecialization
        '
        Me.txtMedicalSpecialization.AllowDrop = True
        Me.txtMedicalSpecialization.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMedicalSpecialization.Location = New System.Drawing.Point(125, 29)
        Me.txtMedicalSpecialization.Name = "txtMedicalSpecialization"
        Me.txtMedicalSpecialization.PickerPresets = Nothing
        Me.txtMedicalSpecialization.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtMedicalSpecialization.Properties.ReadOnly = True
        Me.txtMedicalSpecialization.Size = New System.Drawing.Size(403, 20)
        Me.txtMedicalSpecialization.TabIndex = 168
        '
        'txtBussinesGroup
        '
        Me.txtBussinesGroup.AllowDrop = True
        Me.txtBussinesGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBussinesGroup.Location = New System.Drawing.Point(125, 55)
        Me.txtBussinesGroup.Name = "txtBussinesGroup"
        Me.txtBussinesGroup.PickerPresets = Nothing
        Me.txtBussinesGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtBussinesGroup.Properties.ReadOnly = True
        Me.txtBussinesGroup.Size = New System.Drawing.Size(403, 20)
        Me.txtBussinesGroup.TabIndex = 174
        '
        'txtSpeciality
        '
        Me.txtSpeciality.AllowDrop = True
        Me.txtSpeciality.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSpeciality.Location = New System.Drawing.Point(125, 81)
        Me.txtSpeciality.Name = "txtSpeciality"
        Me.txtSpeciality.PickerPresets = Nothing
        Me.txtSpeciality.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtSpeciality.Properties.ReadOnly = True
        Me.txtSpeciality.Size = New System.Drawing.Size(403, 20)
        Me.txtSpeciality.TabIndex = 175
        '
        'txtDoctor
        '
        Me.txtDoctor.AllowDrop = True
        Me.txtDoctor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDoctor.Location = New System.Drawing.Point(125, 107)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.PickerPresets = Nothing
        Me.txtDoctor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDoctor.Properties.ReadOnly = True
        Me.txtDoctor.Size = New System.Drawing.Size(403, 20)
        Me.txtDoctor.TabIndex = 176
        '
        'chkDoctor
        '
        Me.chkDoctor.AutoSize = True
        Me.chkDoctor.Location = New System.Drawing.Point(3, 107)
        Me.chkDoctor.Name = "chkDoctor"
        Me.chkDoctor.Size = New System.Drawing.Size(52, 17)
        Me.chkDoctor.TabIndex = 177
        Me.chkDoctor.Text = "Ārsts:"
        Me.chkDoctor.UseVisualStyleBackColor = True
        '
        'chkValidAt
        '
        Me.chkValidAt.AutoSize = True
        Me.chkValidAt.Checked = True
        Me.chkValidAt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkValidAt.Location = New System.Drawing.Point(3, 133)
        Me.chkValidAt.Name = "chkValidAt"
        Me.chkValidAt.Size = New System.Drawing.Size(74, 17)
        Me.chkValidAt.TabIndex = 178
        Me.chkValidAt.Text = "Spēkā uz:"
        Me.chkValidAt.UseVisualStyleBackColor = True
        '
        'dtpValidAt
        '
        Me.dtpValidAt.EditValue = New Date(2006, 4, 6, 18, 47, 40, 0)
        Me.dtpValidAt.Location = New System.Drawing.Point(125, 133)
        Me.dtpValidAt.Name = "dtpValidAt"
        Me.dtpValidAt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpValidAt.Properties.MaxValue = New Date(9999, 12, 31, 0, 0, 0, 0)
        Me.dtpValidAt.Properties.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpValidAt.Size = New System.Drawing.Size(100, 20)
        Me.dtpValidAt.TabIndex = 179
        '
        'ctlUserServicesFinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.panTableLayout)
        Me.CriteriaTable = Me.panTableLayout
        Me.MinimumSize = New System.Drawing.Size(200, 0)
        Me.Name = "ctlUserServicesFinder"
        Me.Size = New System.Drawing.Size(546, 186)
        Me.Controls.SetChildIndex(Me.panTableLayout, 0)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTableLayout.ResumeLayout(False)
        Me.panTableLayout.PerformLayout()
        CType(Me.txtServiceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedicalSpecialization.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBussinesGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSpeciality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDoctor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpValidAt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndIsSystemUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkBussinesGroup As System.Windows.Forms.CheckBox
    Friend WithEvents chkServiceType As System.Windows.Forms.CheckBox
    Friend WithEvents txtServiceType As Client.ClassifierPicker
    Friend WithEvents bndIsSystemUser As System.Windows.Forms.BindingSource
    Friend WithEvents chkMedicalSpecialization As System.Windows.Forms.CheckBox
    Friend WithEvents txtMedicalSpecialization As Client.ClassifierPicker
    Friend WithEvents chkSpeciality As System.Windows.Forms.CheckBox
    Friend WithEvents txtBussinesGroup As Client.ClassifierPicker
    Friend WithEvents txtSpeciality As Client.ClassifierPicker
    Friend WithEvents txtDoctor As Client.ClassifierPicker
    Friend WithEvents chkDoctor As System.Windows.Forms.CheckBox
    Friend WithEvents chkValidAt As System.Windows.Forms.CheckBox
    Friend WithEvents dtpValidAt As DevExpress.XtraEditors.DateEdit

End Class
