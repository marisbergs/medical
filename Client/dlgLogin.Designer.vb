<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgLogin
    Inherits Core.frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.LanguagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.LanguagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        resources.ApplyResources(Me.UsernameLabel, "UsernameLabel")
        Me.UsernameLabel.Name = "UsernameLabel"
        '
        'PasswordLabel
        '
        resources.ApplyResources(Me.PasswordLabel, "PasswordLabel")
        Me.PasswordLabel.Name = "PasswordLabel"
        '
        'txtLogin
        '
        resources.ApplyResources(Me.txtLogin, "txtLogin")
        Me.txtLogin.Name = "txtLogin"
        '
        'txtPassword
        '
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.Name = "txtPassword"
        '
        'btnLogin
        '
        resources.ApplyResources(Me.btnLogin, "btnLogin")
        Me.btnLogin.Name = "btnLogin"
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Name = "btnCancel"
        '
        'FlowLayoutPanel1
        '
        resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCancel)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnLogin)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cmbLanguage
        '
        resources.ApplyResources(Me.cmbLanguage, "cmbLanguage")
        Me.cmbLanguage.DataSource = Me.LanguagesBindingSource
        Me.cmbLanguage.DisplayMember = "Name"
        Me.cmbLanguage.FormattingEnabled = True
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.ValueMember = "Code"
        '
        'LanguagesBindingSource
        '
        Me.LanguagesBindingSource.DataSource = GetType(Client.Languages)
        '
        'dlgLogin
        '
        Me.AcceptButton = Me.btnLogin
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmbLanguage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.LanguagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents LanguagesBindingSource As System.Windows.Forms.BindingSource
End Class
