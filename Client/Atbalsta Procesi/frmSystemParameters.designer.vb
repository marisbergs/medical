<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemParameters
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPlanerEndTime = New Core.UI.TimeEdit
        Me.txtPlanerStartTime = New Core.UI.TimeEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtFrequence = New Core.UI.CoreIntegerSpinEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtSMS = New Core.UI.TimeEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtFrequence.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 385)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(296, 32)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(218, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(137, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPlanerEndTime)
        Me.GroupBox1.Controls.Add(Me.txtPlanerStartTime)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 55)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Klīnikas darbalaiks"
        '
        'txtPlanerEndTime
        '
        Me.txtPlanerEndTime.AutoSize = True
        Me.txtPlanerEndTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtPlanerEndTime.EditValue = Nothing
        Me.txtPlanerEndTime.Location = New System.Drawing.Point(166, 25)
        Me.txtPlanerEndTime.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPlanerEndTime.Name = "txtPlanerEndTime"
        Me.txtPlanerEndTime.Size = New System.Drawing.Size(55, 22)
        Me.txtPlanerEndTime.TabIndex = 11
        '
        'txtPlanerStartTime
        '
        Me.txtPlanerStartTime.AutoSize = True
        Me.txtPlanerStartTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtPlanerStartTime.EditValue = Nothing
        Me.txtPlanerStartTime.Location = New System.Drawing.Point(72, 25)
        Me.txtPlanerStartTime.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPlanerStartTime.Name = "txtPlanerStartTime"
        Me.txtPlanerStartTime.Size = New System.Drawing.Size(55, 22)
        Me.txtPlanerStartTime.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "līdz"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Laiks no:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFrequence)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 55)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Darbinieka laika intervāls"
        '
        'txtFrequence
        '
        Me.txtFrequence.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtFrequence.Location = New System.Drawing.Point(93, 25)
        Me.txtFrequence.Name = "txtFrequence"
        Me.txtFrequence.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtFrequence.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFrequence.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtFrequence.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtFrequence.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.Utils.HorzAlignment.Center, Nothing)})
        Me.txtFrequence.Properties.Mask.EditMask = "######,###;"
        Me.txtFrequence.Properties.Mask.ShowPlaceHolders = False
        Me.txtFrequence.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFrequence.Properties.MaxValue = New Decimal(New Integer() {60, 0, 0, 0})
        Me.txtFrequence.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtFrequence.Size = New System.Drawing.Size(55, 22)
        Me.txtFrequence.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Laika intervāls:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSMS)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 47)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SMS īsziņu sūtīšanas vizītes robežlaiks"
        '
        'txtSMS
        '
        Me.txtSMS.AutoSize = True
        Me.txtSMS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtSMS.EditValue = Nothing
        Me.txtSMS.Location = New System.Drawing.Point(72, 16)
        Me.txtSMS.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSMS.Name = "txtSMS"
        Me.txtSMS.Size = New System.Drawing.Size(55, 22)
        Me.txtSMS.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Laiks:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtPath)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 157)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(296, 47)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datubāzes"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 17)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(272, 20)
        Me.txtPath.TabIndex = 0
        '
        'frmSystemParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 417)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frmSystemParameters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistēmas konfigurācija"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtFrequence.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPlanerEndTime As Core.UI.TimeEdit
    Friend WithEvents txtPlanerStartTime As Core.UI.TimeEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFrequence As Core.UI.CoreIntegerSpinEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSMS As Core.UI.TimeEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
End Class
