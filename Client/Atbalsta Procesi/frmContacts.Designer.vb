<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContacts
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
        Me.components = New System.ComponentModel.Container
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.lblCode = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.lblFax = New System.Windows.Forms.Label
        Me.txtMail = New System.Windows.Forms.TextBox
        Me.lblMail = New System.Windows.Forms.Label
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.lblBank = New System.Windows.Forms.Label
        Me.txtAccount = New System.Windows.Forms.TextBox
        Me.lblAccount = New System.Windows.Forms.Label
        Me.txtSwift = New System.Windows.Forms.TextBox
        Me.lblSwift = New System.Windows.Forms.Label
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.bndContact = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.bndContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(66, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Nosaukums:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndContact, "Name", True))
        Me.txtName.Location = New System.Drawing.Point(86, 12)
        Me.txtName.MaxLength = 100
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(408, 20)
        Me.txtName.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndContact, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(86, 38)
        Me.txtAddress.MaxLength = 250
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(408, 20)
        Me.txtAddress.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(7, 41)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(43, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Adrese:"
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndContact, "Code", True))
        Me.txtCode.Location = New System.Drawing.Point(86, 64)
        Me.txtCode.MaxLength = 20
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(150, 20)
        Me.txtCode.TabIndex = 5
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(7, 67)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(61, 13)
        Me.lblCode.TabIndex = 4
        Me.lblCode.Text = "NMR kods:"
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndContact, "Phone", True))
        Me.txtPhone.Location = New System.Drawing.Point(86, 90)
        Me.txtPhone.MaxLength = 50
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(150, 20)
        Me.txtPhone.TabIndex = 7
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(7, 93)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(51, 13)
        Me.lblPhone.TabIndex = 6
        Me.lblPhone.Text = "Telefons:"
        '
        'txtFax
        '
        Me.txtFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndContact, "Fax", True))
        Me.txtFax.Location = New System.Drawing.Point(285, 90)
        Me.txtFax.MaxLength = 50
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(209, 20)
        Me.txtFax.TabIndex = 9
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(241, 93)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(38, 13)
        Me.lblFax.TabIndex = 8
        Me.lblFax.Text = "Fakss:"
        '
        'txtMail
        '
        Me.txtMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndContact, "Mail", True))
        Me.txtMail.Location = New System.Drawing.Point(86, 116)
        Me.txtMail.MaxLength = 100
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(408, 20)
        Me.txtMail.TabIndex = 11
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(7, 119)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(45, 13)
        Me.lblMail.TabIndex = 10
        Me.lblMail.Text = "E-pasts:"
        '
        'txtBank
        '
        Me.txtBank.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndContact, "Bank", True))
        Me.txtBank.Location = New System.Drawing.Point(86, 142)
        Me.txtBank.MaxLength = 100
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(408, 20)
        Me.txtBank.TabIndex = 13
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Location = New System.Drawing.Point(7, 145)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(41, 13)
        Me.lblBank.TabIndex = 12
        Me.lblBank.Text = "Banka:"
        '
        'txtAccount
        '
        Me.txtAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndContact, "Account", True))
        Me.txtAccount.Location = New System.Drawing.Point(285, 168)
        Me.txtAccount.MaxLength = 50
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(209, 20)
        Me.txtAccount.TabIndex = 17
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(241, 171)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(37, 13)
        Me.lblAccount.TabIndex = 16
        Me.lblAccount.Text = "Konts:"
        '
        'txtSwift
        '
        Me.txtSwift.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndContact, "Swift", True))
        Me.txtSwift.Location = New System.Drawing.Point(86, 168)
        Me.txtSwift.MaxLength = 50
        Me.txtSwift.Name = "txtSwift"
        Me.txtSwift.Size = New System.Drawing.Size(150, 20)
        Me.txtSwift.TabIndex = 15
        '
        'lblSwift
        '
        Me.lblSwift.AutoSize = True
        Me.lblSwift.Location = New System.Drawing.Point(7, 171)
        Me.lblSwift.Name = "lblSwift"
        Me.lblSwift.Size = New System.Drawing.Size(72, 13)
        Me.lblSwift.TabIndex = 14
        Me.lblSwift.Text = "Bankas kods:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 195)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(504, 29)
        Me.FlowLayoutPanel1.TabIndex = 18
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(426, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Aizvērt"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(345, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'bndContact
        '
        Me.bndContact.DataSource = GetType(Entities.Contacts)
        '
        'frmContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(504, 224)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.txtSwift)
        Me.Controls.Add(Me.lblSwift)
        Me.Controls.Add(Me.txtBank)
        Me.Controls.Add(Me.lblBank)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.MinimumSize = New System.Drawing.Size(520, 260)
        Me.Name = "frmContacts"
        Me.Text = "Pamatinformācija"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.bndContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents txtSwift As System.Windows.Forms.TextBox
    Friend WithEvents lblSwift As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents bndContact As System.Windows.Forms.BindingSource

End Class
