<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlClassifierFind
    Inherits ctlFind

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
        Me.chkCode = New System.Windows.Forms.CheckBox
        Me.chkValidAt = New System.Windows.Forms.CheckBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.chkName = New System.Windows.Forms.CheckBox
        Me.dtpValidAt = New DevExpress.XtraEditors.DateEdit
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTableLayout.SuspendLayout()
        CType(Me.dtpValidAt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(149, 3)
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(18, 3)
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(230, 3)
        '
        'btnHideNonChecked
        '
        Me.btnHideNonChecked.Location = New System.Drawing.Point(163, 32)
        '
        'panTableLayout
        '
        Me.panTableLayout.AutoSize = True
        Me.panTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panTableLayout.ColumnCount = 2
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panTableLayout.Controls.Add(Me.chkCode, 0, 0)
        Me.panTableLayout.Controls.Add(Me.chkValidAt, 0, 2)
        Me.panTableLayout.Controls.Add(Me.txtName, 1, 1)
        Me.panTableLayout.Controls.Add(Me.txtCode, 1, 0)
        Me.panTableLayout.Controls.Add(Me.chkName, 0, 1)
        Me.panTableLayout.Controls.Add(Me.dtpValidAt, 1, 2)
        Me.panTableLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.panTableLayout.Name = "panTableLayout"
        Me.panTableLayout.RowCount = 3
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.Size = New System.Drawing.Size(403, 78)
        Me.panTableLayout.TabIndex = 153
        '
        'chkCode
        '
        Me.chkCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkCode.AutoSize = True
        Me.chkCode.Location = New System.Drawing.Point(3, 3)
        Me.chkCode.Name = "chkCode"
        Me.chkCode.Size = New System.Drawing.Size(53, 20)
        Me.chkCode.TabIndex = 164
        Me.chkCode.Text = "Kods:"
        Me.chkCode.UseVisualStyleBackColor = True
        '
        'chkValidAt
        '
        Me.chkValidAt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkValidAt.AutoSize = True
        Me.chkValidAt.Location = New System.Drawing.Point(3, 55)
        Me.chkValidAt.Name = "chkValidAt"
        Me.chkValidAt.Size = New System.Drawing.Size(74, 20)
        Me.chkValidAt.TabIndex = 162
        Me.chkValidAt.Text = "Spēkā uz:"
        Me.chkValidAt.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(94, 29)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 3, 17, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(292, 20)
        Me.txtName.TabIndex = 113
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.Location = New System.Drawing.Point(94, 3)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(3, 3, 17, 3)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(292, 20)
        Me.txtCode.TabIndex = 117
        '
        'chkName
        '
        Me.chkName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkName.AutoSize = True
        Me.chkName.Location = New System.Drawing.Point(3, 29)
        Me.chkName.Name = "chkName"
        Me.chkName.Size = New System.Drawing.Size(85, 20)
        Me.chkName.TabIndex = 166
        Me.chkName.Text = "Nosaukums:"
        Me.chkName.UseVisualStyleBackColor = True
        '
        'dtpValidAt
        '
        Me.dtpValidAt.EditValue = New Date(2006, 4, 6, 18, 47, 40, 0)
        Me.dtpValidAt.Location = New System.Drawing.Point(94, 55)
        Me.dtpValidAt.Name = "dtpValidAt"
        Me.dtpValidAt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpValidAt.Properties.MaxValue = New Date(9999, 12, 31, 0, 0, 0, 0)
        Me.dtpValidAt.Properties.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpValidAt.Size = New System.Drawing.Size(80, 20)
        Me.dtpValidAt.TabIndex = 167
        '
        'ctlClassifierFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.panTableLayout)
        Me.CriteriaTable = Me.panTableLayout
        Me.MaximumSize = New System.Drawing.Size(0, 109)
        Me.Name = "ctlClassifierFind"
        Me.Size = New System.Drawing.Size(403, 108)
        Me.Controls.SetChildIndex(Me.panTableLayout, 0)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTableLayout.ResumeLayout(False)
        Me.panTableLayout.PerformLayout()
        CType(Me.dtpValidAt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents panTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkValidAt As System.Windows.Forms.CheckBox
    Friend WithEvents chkCode As System.Windows.Forms.CheckBox
    Friend WithEvents chkName As System.Windows.Forms.CheckBox
    Friend WithEvents dtpValidAt As DevExpress.XtraEditors.DateEdit

End Class
