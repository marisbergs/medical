<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkTimeEdit
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
        Me.components = New System.ComponentModel.Container()
        Me.chkAcyity = New System.Windows.Forms.CheckBox()
        Me.TimeEdit2 = New Core.UI.TimeEdit()
        Me.TimeEdit1 = New Core.UI.TimeEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bndWorkTime = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtUser = New Client.ClassifierPicker()
        Me.txtRoom = New Client.ClassifierPicker()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndWorkTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAcyity
        '
        Me.chkAcyity.AutoSize = True
        Me.chkAcyity.Location = New System.Drawing.Point(246, 58)
        Me.chkAcyity.Name = "chkAcyity"
        Me.chkAcyity.Size = New System.Drawing.Size(92, 17)
        Me.chkAcyity.TabIndex = 70
        Me.chkAcyity.Text = "Akûtas vizītes"
        Me.chkAcyity.UseVisualStyleBackColor = True
        '
        'TimeEdit2
        '
        Me.TimeEdit2.AutoSize = True
        Me.TimeEdit2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TimeEdit2.EditValue = Nothing
        Me.TimeEdit2.Location = New System.Drawing.Point(176, 55)
        Me.TimeEdit2.Margin = New System.Windows.Forms.Padding(0)
        Me.TimeEdit2.Name = "TimeEdit2"
        Me.TimeEdit2.Size = New System.Drawing.Size(55, 20)
        Me.TimeEdit2.TabIndex = 69
        '
        'TimeEdit1
        '
        Me.TimeEdit1.AutoSize = True
        Me.TimeEdit1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TimeEdit1.EditValue = Nothing
        Me.TimeEdit1.Location = New System.Drawing.Point(84, 55)
        Me.TimeEdit1.Margin = New System.Windows.Forms.Padding(0)
        Me.TimeEdit1.Name = "TimeEdit1"
        Me.TimeEdit1.Size = New System.Drawing.Size(55, 20)
        Me.TimeEdit1.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Kabinets:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Laiks no:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Līdz"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 86)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(351, 29)
        Me.FlowLayoutPanel1.TabIndex = 63
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(268, 3)
        Me.btnClose.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(187, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Ârsts:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndWorkTime
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUser.Location = New System.Drawing.Point(84, 30)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PickerPresets = Nothing
        Me.txtUser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtUser.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtUser.Size = New System.Drawing.Size(253, 20)
        Me.txtUser.TabIndex = 71
        '
        'txtRoom
        '
        Me.txtRoom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRoom.Location = New System.Drawing.Point(84, 6)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.PickerPresets = Nothing
        Me.txtRoom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtRoom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtRoom.Size = New System.Drawing.Size(253, 20)
        Me.txtRoom.TabIndex = 64
        '
        'frmWorkTimeEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 115)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.chkAcyity)
        Me.Controls.Add(Me.TimeEdit2)
        Me.Controls.Add(Me.TimeEdit1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frmWorkTimeEdit"
        Me.Text = "Darba laika labošana"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndWorkTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkAcyity As System.Windows.Forms.CheckBox
    Friend WithEvents TimeEdit2 As Core.UI.TimeEdit
    Friend WithEvents TimeEdit1 As Core.UI.TimeEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRoom As Client.ClassifierPicker
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUser As Client.ClassifierPicker
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents bndWorkTime As System.Windows.Forms.BindingSource
End Class
