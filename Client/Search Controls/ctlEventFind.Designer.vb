<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlEventFind
    Inherits ctlFind

    'яā
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
        Me.panTableLayout = New System.Windows.Forms.TableLayoutPanel
        Me.txtCMCaseNo = New System.Windows.Forms.TextBox
        Me.chkUser = New System.Windows.Forms.CheckBox
        Me.chkGroup = New System.Windows.Forms.CheckBox
        Me.chkStartDate = New System.Windows.Forms.CheckBox
        Me.txtErrorCode = New System.Windows.Forms.TextBox
        Me.PeriodWithTimePicker = New Core.UI.PeriodWithTimePicker
        Me.chkErrorCode = New System.Windows.Forms.CheckBox
        Me.chkCMCaseNo = New System.Windows.Forms.CheckBox
        Me.txtUser = New DevExpress.XtraEditors.ButtonEdit
        Me.cmbGroup = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTableLayout.SuspendLayout()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(240, 3)
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(109, 3)
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(321, 3)
        '
        'btnHideNonChecked
        '
        Me.btnHideNonChecked.Location = New System.Drawing.Point(254, 32)
        '
        'panTableLayout
        '
        Me.panTableLayout.AutoSize = True
        Me.panTableLayout.ColumnCount = 2
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.panTableLayout.Controls.Add(Me.txtCMCaseNo, 1, 4)
        Me.panTableLayout.Controls.Add(Me.chkUser, 0, 0)
        Me.panTableLayout.Controls.Add(Me.chkGroup, 0, 2)
        Me.panTableLayout.Controls.Add(Me.chkStartDate, 0, 1)
        Me.panTableLayout.Controls.Add(Me.txtErrorCode, 1, 3)
        Me.panTableLayout.Controls.Add(Me.PeriodWithTimePicker, 1, 1)
        Me.panTableLayout.Controls.Add(Me.chkErrorCode, 0, 3)
        Me.panTableLayout.Controls.Add(Me.chkCMCaseNo, 0, 4)
        Me.panTableLayout.Controls.Add(Me.txtUser, 1, 0)
        Me.panTableLayout.Controls.Add(Me.cmbGroup, 1, 2)
        Me.panTableLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panTableLayout.Location = New System.Drawing.Point(0, -5)
        Me.panTableLayout.Name = "panTableLayout"
        Me.panTableLayout.RowCount = 6
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.Size = New System.Drawing.Size(494, 136)
        Me.panTableLayout.TabIndex = 2
        '
        'txtCMCaseNo
        '
        Me.txtCMCaseNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCMCaseNo.Location = New System.Drawing.Point(126, 113)
        Me.txtCMCaseNo.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.txtCMCaseNo.Name = "txtCMCaseNo"
        Me.txtCMCaseNo.Size = New System.Drawing.Size(365, 20)
        Me.txtCMCaseNo.TabIndex = 9
        '
        'chkUser
        '
        Me.chkUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkUser.AutoSize = True
        Me.chkUser.Checked = True
        Me.chkUser.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUser.Location = New System.Drawing.Point(3, 3)
        Me.chkUser.Name = "chkUser"
        Me.chkUser.Size = New System.Drawing.Size(65, 22)
        Me.chkUser.TabIndex = 0
        Me.chkUser.Text = "Lietotājs"
        Me.chkUser.UseVisualStyleBackColor = True
        '
        'chkGroup
        '
        Me.chkGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkGroup.AutoSize = True
        Me.chkGroup.Location = New System.Drawing.Point(3, 59)
        Me.chkGroup.Name = "chkGroup"
        Me.chkGroup.Size = New System.Drawing.Size(58, 22)
        Me.chkGroup.TabIndex = 4
        Me.chkGroup.Text = "Grupa:"
        Me.chkGroup.UseVisualStyleBackColor = True
        '
        'chkStartDate
        '
        Me.chkStartDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkStartDate.AutoSize = True
        Me.chkStartDate.Location = New System.Drawing.Point(3, 31)
        Me.chkStartDate.Name = "chkStartDate"
        Me.chkStartDate.Size = New System.Drawing.Size(117, 22)
        Me.chkStartDate.TabIndex = 2
        Me.chkStartDate.Text = "Veikšanas laiks no:"
        Me.chkStartDate.UseVisualStyleBackColor = True
        '
        'txtErrorCode
        '
        Me.txtErrorCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtErrorCode.Location = New System.Drawing.Point(126, 87)
        Me.txtErrorCode.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.txtErrorCode.Name = "txtErrorCode"
        Me.txtErrorCode.Size = New System.Drawing.Size(365, 20)
        Me.txtErrorCode.TabIndex = 7
        '
        'PeriodWithTimePicker
        '
        Me.PeriodWithTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PeriodWithTimePicker.AutoSize = True
        Me.PeriodWithTimePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PeriodWithTimePicker.Location = New System.Drawing.Point(126, 31)
        Me.PeriodWithTimePicker.Name = "PeriodWithTimePicker"
        Me.PeriodWithTimePicker.Size = New System.Drawing.Size(377, 22)
        Me.PeriodWithTimePicker.TabIndex = 3
        '
        'chkErrorCode
        '
        Me.chkErrorCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkErrorCode.AutoSize = True
        Me.chkErrorCode.Location = New System.Drawing.Point(3, 87)
        Me.chkErrorCode.Name = "chkErrorCode"
        Me.chkErrorCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkErrorCode.Size = New System.Drawing.Size(53, 20)
        Me.chkErrorCode.TabIndex = 6
        Me.chkErrorCode.Text = "Kods:"
        Me.chkErrorCode.UseVisualStyleBackColor = True
        '
        'chkCMCaseNo
        '
        Me.chkCMCaseNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkCMCaseNo.AutoSize = True
        Me.chkCMCaseNo.Location = New System.Drawing.Point(3, 113)
        Me.chkCMCaseNo.Name = "chkCMCaseNo"
        Me.chkCMCaseNo.Size = New System.Drawing.Size(87, 20)
        Me.chkCMCaseNo.TabIndex = 8
        Me.chkCMCaseNo.Text = "KP lietas Nr.:"
        Me.chkCMCaseNo.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUser.Location = New System.Drawing.Point(126, 3)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtUser.Properties.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(365, 22)
        Me.txtUser.TabIndex = 1
        '
        'cmbGroup
        '
        Me.cmbGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGroup.Location = New System.Drawing.Point(126, 59)
        Me.cmbGroup.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbGroup.Size = New System.Drawing.Size(365, 22)
        Me.cmbGroup.TabIndex = 5
        '
        'ctlEventFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panTableLayout)
        Me.CriteriaTable = Me.panTableLayout
        Me.MaximumSize = New System.Drawing.Size(0, 170)
        Me.MinimumSize = New System.Drawing.Size(494, 0)
        Me.Name = "ctlEventFind"
        Me.Size = New System.Drawing.Size(494, 161)
        Me.Controls.SetChildIndex(Me.panTableLayout, 0)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTableLayout.ResumeLayout(False)
        Me.panTableLayout.PerformLayout()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkCMCaseNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkUser As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroup As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartDate As System.Windows.Forms.CheckBox
    Friend WithEvents txtErrorCode As System.Windows.Forms.TextBox
    Friend WithEvents PeriodWithTimePicker As Core.UI.PeriodWithTimePicker
    Friend WithEvents chkErrorCode As System.Windows.Forms.CheckBox
    Friend WithEvents txtCMCaseNo As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents cmbGroup As DevExpress.XtraEditors.ComboBoxEdit

End Class
