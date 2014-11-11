<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSynchronizationProcess
    Inherits Core.frmBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSynchronizationProcess))
        Me.lblSynch_1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblSynch_2 = New System.Windows.Forms.Label
        Me.lblSynch_3 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblSynch_1
        '
        Me.lblSynch_1.AutoSize = True
        Me.lblSynch_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSynch_1.ImageIndex = 0
        Me.lblSynch_1.ImageList = Me.ImageList1
        Me.lblSynch_1.Location = New System.Drawing.Point(11, 9)
        Me.lblSynch_1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSynch_1.Name = "lblSynch_1"
        Me.lblSynch_1.Size = New System.Drawing.Size(143, 13)
        Me.lblSynch_1.TabIndex = 0
        Me.lblSynch_1.Text = "     Sinhronizēja klasifikatorus"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Magenta
        Me.ImageList1.Images.SetKeyName(0, "tick16_h.bmp")
        '
        'lblSynch_2
        '
        Me.lblSynch_2.AutoSize = True
        Me.lblSynch_2.Location = New System.Drawing.Point(11, 38)
        Me.lblSynch_2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSynch_2.Name = "lblSynch_2"
        Me.lblSynch_2.Size = New System.Drawing.Size(207, 13)
        Me.lblSynch_2.TabIndex = 1
        Me.lblSynch_2.Text = "     Sinhronizēja lietas no centrālā uz lokālo"
        '
        'lblSynch_3
        '
        Me.lblSynch_3.AutoSize = True
        Me.lblSynch_3.Location = New System.Drawing.Point(11, 67)
        Me.lblSynch_3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSynch_3.Name = "lblSynch_3"
        Me.lblSynch_3.Size = New System.Drawing.Size(207, 13)
        Me.lblSynch_3.TabIndex = 2
        Me.lblSynch_3.Text = "     Sinhronizēja lietas no lokālā uz centrālo"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(164, 96)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(56, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Atcelt"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmSynchronizationProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 130)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblSynch_3)
        Me.Controls.Add(Me.lblSynch_2)
        Me.Controls.Add(Me.lblSynch_1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSynchronizationProcess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sinhronizācijas process"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSynch_1 As System.Windows.Forms.Label
    Friend WithEvents lblSynch_2 As System.Windows.Forms.Label
    Friend WithEvents lblSynch_3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
