Imports System
Imports System.Collections.Generic
Imports NHibernate
Imports Core
'ёй
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlUsersFind
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
        Me.txtSpecialities = New Client.ClassifierPicker()
        Me.chkSpecialities = New System.Windows.Forms.CheckBox()
        Me.chkValidAt = New System.Windows.Forms.CheckBox()
        Me.chkLogon = New System.Windows.Forms.CheckBox()
        Me.chkIsUser = New System.Windows.Forms.CheckBox()
        Me.chkPosition = New System.Windows.Forms.CheckBox()
        Me.txtLogon = New System.Windows.Forms.TextBox()
        Me.txtPosition = New Client.ClassifierPicker()
        Me.cmbIsUser = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtpValidAt = New DevExpress.XtraEditors.DateEdit()
        Me.bndIsSystemUser = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTableLayout.SuspendLayout()
        CType(Me.txtSpecialities.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbIsUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panTableLayout.Controls.Add(Me.txtSpecialities, 1, 3)
        Me.panTableLayout.Controls.Add(Me.chkSpecialities, 0, 3)
        Me.panTableLayout.Controls.Add(Me.chkValidAt, 0, 7)
        Me.panTableLayout.Controls.Add(Me.chkLogon, 0, 5)
        Me.panTableLayout.Controls.Add(Me.chkIsUser, 0, 4)
        Me.panTableLayout.Controls.Add(Me.chkPosition, 0, 0)
        Me.panTableLayout.Controls.Add(Me.txtLogon, 1, 5)
        Me.panTableLayout.Controls.Add(Me.txtPosition, 1, 0)
        Me.panTableLayout.Controls.Add(Me.cmbIsUser, 1, 4)
        Me.panTableLayout.Controls.Add(Me.dtpValidAt, 1, 7)
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
        Me.panTableLayout.Size = New System.Drawing.Size(546, 130)
        Me.panTableLayout.TabIndex = 2
        '
        'txtSpecialities
        '
        Me.txtSpecialities.AllowDrop = True
        Me.txtSpecialities.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSpecialities.Location = New System.Drawing.Point(125, 29)
        Me.txtSpecialities.Name = "txtSpecialities"
        Me.txtSpecialities.PickerPresets = Nothing
        Me.txtSpecialities.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtSpecialities.Properties.ReadOnly = True
        Me.txtSpecialities.Size = New System.Drawing.Size(403, 20)
        Me.txtSpecialities.TabIndex = 168
        '
        'chkSpecialities
        '
        Me.chkSpecialities.AutoSize = True
        Me.chkSpecialities.Location = New System.Drawing.Point(3, 29)
        Me.chkSpecialities.Name = "chkSpecialities"
        Me.chkSpecialities.Size = New System.Drawing.Size(84, 17)
        Me.chkSpecialities.TabIndex = 7
        Me.chkSpecialities.Text = "Specialitāte:"
        Me.chkSpecialities.UseVisualStyleBackColor = True
        '
        'chkValidAt
        '
        Me.chkValidAt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkValidAt.AutoSize = True
        Me.chkValidAt.Checked = True
        Me.chkValidAt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkValidAt.Location = New System.Drawing.Point(3, 107)
        Me.chkValidAt.Name = "chkValidAt"
        Me.chkValidAt.Size = New System.Drawing.Size(74, 20)
        Me.chkValidAt.TabIndex = 172
        Me.chkValidAt.Text = "Spēkā uz:"
        Me.chkValidAt.UseVisualStyleBackColor = True
        '
        'chkLogon
        '
        Me.chkLogon.AutoSize = True
        Me.chkLogon.Location = New System.Drawing.Point(3, 81)
        Me.chkLogon.Name = "chkLogon"
        Me.chkLogon.Size = New System.Drawing.Size(98, 17)
        Me.chkLogon.TabIndex = 16
        Me.chkLogon.Text = "Lietotāja konts:"
        Me.chkLogon.UseVisualStyleBackColor = True
        '
        'chkIsUser
        '
        Me.chkIsUser.AutoSize = True
        Me.chkIsUser.Checked = True
        Me.chkIsUser.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsUser.Location = New System.Drawing.Point(3, 55)
        Me.chkIsUser.Name = "chkIsUser"
        Me.chkIsUser.Size = New System.Drawing.Size(116, 17)
        Me.chkIsUser.TabIndex = 8
        Me.chkIsUser.Text = "Ir sistēmas lietotājs:"
        Me.chkIsUser.UseVisualStyleBackColor = True
        '
        'chkPosition
        '
        Me.chkPosition.AutoSize = True
        Me.chkPosition.Location = New System.Drawing.Point(3, 3)
        Me.chkPosition.Name = "chkPosition"
        Me.chkPosition.Size = New System.Drawing.Size(58, 17)
        Me.chkPosition.TabIndex = 6
        Me.chkPosition.Text = "Amats:"
        Me.chkPosition.UseVisualStyleBackColor = True
        '
        'txtLogon
        '
        Me.txtLogon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLogon.Location = New System.Drawing.Point(125, 81)
        Me.txtLogon.Name = "txtLogon"
        Me.txtLogon.Size = New System.Drawing.Size(403, 20)
        Me.txtLogon.TabIndex = 17
        '
        'txtPosition
        '
        Me.txtPosition.AllowDrop = True
        Me.txtPosition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPosition.Location = New System.Drawing.Point(125, 3)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.PickerPresets = Nothing
        Me.txtPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPosition.Properties.ReadOnly = True
        Me.txtPosition.Size = New System.Drawing.Size(403, 20)
        Me.txtPosition.TabIndex = 167
        '
        'cmbIsUser
        '
        Me.cmbIsUser.Location = New System.Drawing.Point(125, 55)
        Me.cmbIsUser.Name = "cmbIsUser"
        Me.cmbIsUser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbIsUser.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbIsUser.Size = New System.Drawing.Size(100, 20)
        Me.cmbIsUser.TabIndex = 171
        '
        'dtpValidAt
        '
        Me.dtpValidAt.EditValue = New Date(2006, 4, 6, 18, 47, 40, 0)
        Me.dtpValidAt.Location = New System.Drawing.Point(125, 107)
        Me.dtpValidAt.Name = "dtpValidAt"
        Me.dtpValidAt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpValidAt.Properties.MaxValue = New Date(9999, 12, 31, 0, 0, 0, 0)
        Me.dtpValidAt.Properties.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpValidAt.Size = New System.Drawing.Size(100, 20)
        Me.dtpValidAt.TabIndex = 173
        '
        'ctlUsersFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.panTableLayout)
        Me.CriteriaTable = Me.panTableLayout
        Me.MinimumSize = New System.Drawing.Size(200, 0)
        Me.Name = "ctlUsersFind"
        Me.Size = New System.Drawing.Size(546, 160)
        Me.Controls.SetChildIndex(Me.panTableLayout, 0)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTableLayout.ResumeLayout(False)
        Me.panTableLayout.PerformLayout()
        CType(Me.txtSpecialities.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbIsUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpValidAt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndIsSystemUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkLogon As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsUser As System.Windows.Forms.CheckBox
    Friend WithEvents chkPosition As System.Windows.Forms.CheckBox
    Friend WithEvents txtLogon As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As Client.ClassifierPicker
    Friend WithEvents bndIsSystemUser As System.Windows.Forms.BindingSource
    Friend WithEvents cmbIsUser As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkValidAt As System.Windows.Forms.CheckBox
    Friend WithEvents dtpValidAt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtSpecialities As Client.ClassifierPicker
    Friend WithEvents chkSpecialities As System.Windows.Forms.CheckBox

End Class
