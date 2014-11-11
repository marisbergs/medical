<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetPassword
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
        Me.components = New System.ComponentModel.Container
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit
        Me.txtPasswordDublicate = New DevExpress.XtraEditors.TextEdit
        Me.lblPasswordDublicate = New System.Windows.Forms.Label
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.bndUser = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPasswordDublicate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.bndUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(5, 15)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(40, 13)
        Me.lblPassword.TabIndex = 41
        Me.lblPassword.Text = "Parole:"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Location = New System.Drawing.Point(98, 12)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtPassword.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPassword.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPassword.Properties.MaxLength = 128
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(286, 20)
        Me.txtPassword.TabIndex = 40
        '
        'txtPasswordDublicate
        '
        Me.txtPasswordDublicate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPasswordDublicate.Location = New System.Drawing.Point(98, 38)
        Me.txtPasswordDublicate.Name = "txtPasswordDublicate"
        Me.txtPasswordDublicate.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.txtPasswordDublicate.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPasswordDublicate.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPasswordDublicate.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPasswordDublicate.Properties.MaxLength = 128
        Me.txtPasswordDublicate.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordDublicate.Size = New System.Drawing.Size(286, 20)
        Me.txtPasswordDublicate.TabIndex = 42
        '
        'lblPasswordDublicate
        '
        Me.lblPasswordDublicate.AutoSize = True
        Me.lblPasswordDublicate.Location = New System.Drawing.Point(5, 41)
        Me.lblPasswordDublicate.Name = "lblPasswordDublicate"
        Me.lblPasswordDublicate.Size = New System.Drawing.Size(81, 13)
        Me.lblPasswordDublicate.TabIndex = 43
        Me.lblPasswordDublicate.Text = "Parole atkārtoti:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCancel)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 85)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(396, 28)
        Me.FlowLayoutPanel1.TabIndex = 44
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(318, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Atcelt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(237, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'bndUser
        '
        Me.bndUser.DataSource = GetType(Entities.User)
        '
        'frmResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 113)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.txtPasswordDublicate)
        Me.Controls.Add(Me.lblPasswordDublicate)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Name = "frmResetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mainīt paroli"
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPasswordDublicate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.bndUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPasswordDublicate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPasswordDublicate As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents bndUser As System.Windows.Forms.BindingSource
End Class
