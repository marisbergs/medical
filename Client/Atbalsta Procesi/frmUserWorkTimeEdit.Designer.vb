<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserWorkTimeEdit
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
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bndWorkTime = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtRoom = New Client.ClassifierPicker()
        Me.chkAcyity = New System.Windows.Forms.CheckBox()
        Me.TimeEdit1 = New Core.UI.TimeEdit()
        Me.TimeEdit2 = New Core.UI.TimeEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpValidFrom = New DevExpress.XtraEditors.DateEdit()
        Me.dtpValidTo = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndWorkTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpValidFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpValidTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 152)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(527, 29)
        Me.FlowLayoutPanel1.TabIndex = 55
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(444, 3)
        Me.btnClose.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(363, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Location = New System.Drawing.Point(253, 3)
        Me.Button1.MinimumSize = New System.Drawing.Size(75, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Kabineta noslodze"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Līdz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Laiks no:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Kabinets"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndWorkTime
        '
        'bndWorkTime
        '
        Me.bndWorkTime.DataSource = GetType(Entities.UsersWorkTime)
        '
        'txtRoom
        '
        Me.txtRoom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRoom.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndWorkTime, "Room", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ErrorProvider1.SetIconPadding(Me.txtRoom, -34)
        Me.txtRoom.Location = New System.Drawing.Point(86, 12)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.PickerPresets = Nothing
        Me.txtRoom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtRoom.Properties.ReadOnly = True
        Me.txtRoom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtRoom.Size = New System.Drawing.Size(434, 20)
        Me.txtRoom.TabIndex = 56
        '
        'chkAcyity
        '
        Me.chkAcyity.AutoSize = True
        Me.chkAcyity.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bndWorkTime, "Acyity", True))
        Me.chkAcyity.Location = New System.Drawing.Point(248, 40)
        Me.chkAcyity.Name = "chkAcyity"
        Me.chkAcyity.Size = New System.Drawing.Size(92, 17)
        Me.chkAcyity.TabIndex = 62
        Me.chkAcyity.Text = "Akûtas vizītes"
        Me.chkAcyity.UseVisualStyleBackColor = True
        '
        'TimeEdit1
        '
        Me.TimeEdit1.AutoSize = True
        Me.TimeEdit1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TimeEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndWorkTime, "StartTime", True))
        Me.TimeEdit1.EditValue = Nothing
        Me.TimeEdit1.Location = New System.Drawing.Point(86, 37)
        Me.TimeEdit1.Margin = New System.Windows.Forms.Padding(0)
        Me.TimeEdit1.Name = "TimeEdit1"
        Me.TimeEdit1.Size = New System.Drawing.Size(55, 20)
        Me.TimeEdit1.TabIndex = 63
        '
        'TimeEdit2
        '
        Me.TimeEdit2.AutoSize = True
        Me.TimeEdit2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TimeEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndWorkTime, "EndTime", True))
        Me.TimeEdit2.EditValue = Nothing
        Me.TimeEdit2.Location = New System.Drawing.Point(178, 37)
        Me.TimeEdit2.Margin = New System.Windows.Forms.Padding(0)
        Me.TimeEdit2.Name = "TimeEdit2"
        Me.TimeEdit2.Size = New System.Drawing.Size(55, 20)
        Me.TimeEdit2.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Spēkā no:"
        '
        'dtpValidFrom
        '
        Me.dtpValidFrom.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndWorkTime, "ValidFrom", True))
        Me.dtpValidFrom.EditValue = Nothing
        Me.dtpValidFrom.Location = New System.Drawing.Point(86, 63)
        Me.dtpValidFrom.Name = "dtpValidFrom"
        Me.dtpValidFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpValidFrom.Size = New System.Drawing.Size(100, 20)
        Me.dtpValidFrom.TabIndex = 66
        '
        'dtpValidTo
        '
        Me.dtpValidTo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndWorkTime, "ValidTo", True))
        Me.dtpValidTo.EditValue = Nothing
        Me.dtpValidTo.Location = New System.Drawing.Point(233, 63)
        Me.dtpValidTo.Name = "dtpValidTo"
        Me.dtpValidTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpValidTo.Size = New System.Drawing.Size(100, 20)
        Me.dtpValidTo.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "līdz:"
        '
        'frmUserWorkTimeEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(527, 181)
        Me.Controls.Add(Me.dtpValidTo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpValidFrom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TimeEdit2)
        Me.Controls.Add(Me.TimeEdit1)
        Me.Controls.Add(Me.chkAcyity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(350, 120)
        Me.Name = "frmUserWorkTimeEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Darba laiks"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndWorkTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpValidFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpValidTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtRoom As Client.ClassifierPicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bndWorkTime As System.Windows.Forms.BindingSource
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkAcyity As System.Windows.Forms.CheckBox
    Friend WithEvents TimeEdit2 As Core.UI.TimeEdit
    Friend WithEvents TimeEdit1 As Core.UI.TimeEdit
    Friend WithEvents dtpValidFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpValidTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
