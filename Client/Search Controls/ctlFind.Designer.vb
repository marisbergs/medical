<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlFind
    Inherits System.Windows.Forms.UserControl

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
        Me.components = New System.ComponentModel.Container
        Dim panButtons As System.Windows.Forms.FlowLayoutPanel
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnShowAll = New System.Windows.Forms.Button
        Me.btnHideNonChecked = New System.Windows.Forms.Button
        Me.panButtonTable = New System.Windows.Forms.TableLayoutPanel
        Me.chkActive = New System.Windows.Forms.CheckBox
        Me.bndFind = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        panButtons = New System.Windows.Forms.FlowLayoutPanel
        panButtons.SuspendLayout()
        Me.panButtonTable.SuspendLayout()
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panButtons
        '
        panButtons.AutoSize = True
        panButtons.Controls.Add(Me.btnSearch)
        panButtons.Controls.Add(Me.btnReset)
        panButtons.Controls.Add(Me.btnShowAll)
        panButtons.Controls.Add(Me.btnHideNonChecked)
        panButtons.Dock = System.Windows.Forms.DockStyle.Fill
        panButtons.Location = New System.Drawing.Point(95, 0)
        panButtons.Margin = New System.Windows.Forms.Padding(0)
        panButtons.Name = "panButtons"
        panButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        panButtons.Size = New System.Drawing.Size(559, 30)
        panButtons.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(481, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Atlasīt"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(400, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Notīrīt"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowAll.Location = New System.Drawing.Point(269, 3)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(125, 23)
        Me.btnShowAll.TabIndex = 1
        Me.btnShowAll.Text = "Rādīt visus kritērijus"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnHideNonChecked
        '
        Me.btnHideNonChecked.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHideNonChecked.AutoSize = True
        Me.btnHideNonChecked.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHideNonChecked.Location = New System.Drawing.Point(121, 3)
        Me.btnHideNonChecked.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnHideNonChecked.Name = "btnHideNonChecked"
        Me.btnHideNonChecked.Size = New System.Drawing.Size(142, 23)
        Me.btnHideNonChecked.TabIndex = 0
        Me.btnHideNonChecked.Text = "Slēpt neatzīmētos kritērijus"
        Me.btnHideNonChecked.UseVisualStyleBackColor = True
        Me.btnHideNonChecked.Visible = False
        '
        'panButtonTable
        '
        Me.panButtonTable.AutoSize = True
        Me.panButtonTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panButtonTable.ColumnCount = 2
        Me.panButtonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.panButtonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panButtonTable.Controls.Add(Me.chkActive, 0, 0)
        Me.panButtonTable.Controls.Add(panButtons, 1, 0)
        Me.panButtonTable.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panButtonTable.Location = New System.Drawing.Point(0, 40)
        Me.panButtonTable.Name = "panButtonTable"
        Me.panButtonTable.RowCount = 1
        Me.panButtonTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panButtonTable.Size = New System.Drawing.Size(654, 30)
        Me.panButtonTable.TabIndex = 0
        '
        'chkActive
        '
        Me.chkActive.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(3, 3)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(89, 24)
        Me.chkActive.TabIndex = 0
        Me.chkActive.Text = "Tikai aktuālie"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'bndFind
        '
        Me.bndFind.AllowNew = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.DataSource = Me.bndFind
        '
        'ctlFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.panButtonTable)
        Me.MinimumSize = New System.Drawing.Size(403, 0)
        Me.Name = "ctlFind"
        Me.Size = New System.Drawing.Size(654, 70)
        panButtons.ResumeLayout(False)
        panButtons.PerformLayout()
        Me.panButtonTable.ResumeLayout(False)
        Me.panButtonTable.PerformLayout()
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Protected Friend WithEvents bndFind As System.Windows.Forms.BindingSource
    Friend WithEvents panButtonTable As System.Windows.Forms.TableLayoutPanel
    Protected Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Protected WithEvents btnReset As System.Windows.Forms.Button
    Protected WithEvents btnShowAll As System.Windows.Forms.Button
    Protected WithEvents btnSearch As System.Windows.Forms.Button
    Protected WithEvents btnHideNonChecked As System.Windows.Forms.Button

End Class
