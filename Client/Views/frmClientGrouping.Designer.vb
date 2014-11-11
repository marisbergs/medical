<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientGrouping
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBorderSumm = New DevExpress.XtraEditors.SpinEdit()
        Me.btnAverageSumm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalCount = New System.Windows.Forms.TextBox()
        Me.txtTotalSumm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtAborderPercentage = New DevExpress.XtraEditors.SpinEdit()
        Me.txtBborderPercentage = New DevExpress.XtraEditors.SpinEdit()
        Me.txtBborderSumm = New DevExpress.XtraEditors.SpinEdit()
        Me.txtAborderSumm = New DevExpress.XtraEditors.SpinEdit()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbtUsePercentage = New System.Windows.Forms.RadioButton()
        Me.rbtUseValue = New System.Windows.Forms.RadioButton()
        CType(Me.txtBorderSumm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAborderPercentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBborderPercentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBborderSumm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAborderSumm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Robežsumma:"
        '
        'txtBorderSumm
        '
        Me.txtBorderSumm.EditValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.txtBorderSumm.Location = New System.Drawing.Point(92, 8)
        Me.txtBorderSumm.Name = "txtBorderSumm"
        Me.txtBorderSumm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtBorderSumm.Properties.DisplayFormat.FormatString = "n0"
        Me.txtBorderSumm.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBorderSumm.Properties.EditFormat.FormatString = "n0"
        Me.txtBorderSumm.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBorderSumm.Size = New System.Drawing.Size(51, 20)
        Me.txtBorderSumm.TabIndex = 1
        '
        'btnAverageSumm
        '
        Me.btnAverageSumm.Location = New System.Drawing.Point(149, 6)
        Me.btnAverageSumm.Name = "btnAverageSumm"
        Me.btnAverageSumm.Size = New System.Drawing.Size(75, 23)
        Me.btnAverageSumm.TabIndex = 2
        Me.btnAverageSumm.Text = "Aprēķināt"
        Me.btnAverageSumm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Klientu skaits:"
        '
        'txtTotalCount
        '
        Me.txtTotalCount.Location = New System.Drawing.Point(308, 8)
        Me.txtTotalCount.Name = "txtTotalCount"
        Me.txtTotalCount.ReadOnly = True
        Me.txtTotalCount.Size = New System.Drawing.Size(83, 20)
        Me.txtTotalCount.TabIndex = 4
        '
        'txtTotalSumm
        '
        Me.txtTotalSumm.Location = New System.Drawing.Point(482, 8)
        Me.txtTotalSumm.Name = "txtTotalSumm"
        Me.txtTotalSumm.ReadOnly = True
        Me.txtTotalSumm.Size = New System.Drawing.Size(93, 20)
        Me.txtTotalSumm.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(397, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kopējā summa:"
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(676, 8)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(94, 20)
        Me.txtAverage.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(581, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Vidēji: uz klientu:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Procentuālais sadalījums:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "A"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(234, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "B"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(324, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "C"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Pēdējās vizītes datums:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(349, 37)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(59, 20)
        Me.TextBox3.TabIndex = 22
        Me.TextBox3.Text = "100%"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(349, 89)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(59, 20)
        Me.TextBox4.TabIndex = 28
        Me.TextBox4.Text = ">24m"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(259, 89)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(59, 20)
        Me.TextBox5.TabIndex = 27
        Me.TextBox5.Text = "12-24m"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(165, 89)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(59, 20)
        Me.TextBox6.TabIndex = 26
        Me.TextBox6.Text = "0-12m"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(324, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(234, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(144, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "0"
        '
        'btnCalc
        '
        Me.btnCalc.AutoSize = True
        Me.btnCalc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCalc.Location = New System.Drawing.Point(414, 87)
        Me.btnCalc.MinimumSize = New System.Drawing.Size(75, 23)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 29
        Me.btnCalc.Text = "Aprēķināt"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtAborderPercentage
        '
        Me.txtAborderPercentage.EditValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.txtAborderPercentage.Location = New System.Drawing.Point(165, 37)
        Me.txtAborderPercentage.Name = "txtAborderPercentage"
        Me.txtAborderPercentage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtAborderPercentage.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAborderPercentage.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAborderPercentage.Properties.EditFormat.FormatString = "n0"
        Me.txtAborderPercentage.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAborderPercentage.Size = New System.Drawing.Size(59, 20)
        Me.txtAborderPercentage.TabIndex = 30
        '
        'txtBborderPercentage
        '
        Me.txtBborderPercentage.EditValue = New Decimal(New Integer() {80, 0, 0, 0})
        Me.txtBborderPercentage.Location = New System.Drawing.Point(259, 37)
        Me.txtBborderPercentage.Name = "txtBborderPercentage"
        Me.txtBborderPercentage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtBborderPercentage.Properties.DisplayFormat.FormatString = "n0"
        Me.txtBborderPercentage.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBborderPercentage.Properties.EditFormat.FormatString = "n0"
        Me.txtBborderPercentage.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBborderPercentage.Size = New System.Drawing.Size(59, 20)
        Me.txtBborderPercentage.TabIndex = 31
        '
        'txtBborderSumm
        '
        Me.txtBborderSumm.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBborderSumm.Location = New System.Drawing.Point(259, 63)
        Me.txtBborderSumm.Name = "txtBborderSumm"
        Me.txtBborderSumm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtBborderSumm.Properties.DisplayFormat.FormatString = "n2"
        Me.txtBborderSumm.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBborderSumm.Properties.EditFormat.FormatString = "n2"
        Me.txtBborderSumm.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBborderSumm.Size = New System.Drawing.Size(59, 20)
        Me.txtBborderSumm.TabIndex = 38
        '
        'txtAborderSumm
        '
        Me.txtAborderSumm.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAborderSumm.Location = New System.Drawing.Point(165, 63)
        Me.txtAborderSumm.Name = "txtAborderSumm"
        Me.txtAborderSumm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtAborderSumm.Properties.DisplayFormat.FormatString = "n2"
        Me.txtAborderSumm.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAborderSumm.Properties.EditFormat.FormatString = "n2"
        Me.txtAborderSumm.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAborderSumm.Size = New System.Drawing.Size(59, 20)
        Me.txtAborderSumm.TabIndex = 37
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(349, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(59, 20)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.Text = "100%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(324, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "C"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(234, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "B"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(144, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "A"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Summārais sadalījums:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.rbtUsePercentage)
        Me.FlowLayoutPanel1.Controls.Add(Me.rbtUseValue)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(414, 37)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(24, 46)
        Me.FlowLayoutPanel1.TabIndex = 39
        '
        'rbtUsePercentage
        '
        Me.rbtUsePercentage.AutoSize = True
        Me.rbtUsePercentage.Checked = True
        Me.rbtUsePercentage.Location = New System.Drawing.Point(3, 5)
        Me.rbtUsePercentage.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.rbtUsePercentage.Name = "rbtUsePercentage"
        Me.rbtUsePercentage.Size = New System.Drawing.Size(14, 13)
        Me.rbtUsePercentage.TabIndex = 0
        Me.rbtUsePercentage.TabStop = True
        Me.rbtUsePercentage.UseVisualStyleBackColor = True
        '
        'rbtUseValue
        '
        Me.rbtUseValue.AutoSize = True
        Me.rbtUseValue.Location = New System.Drawing.Point(3, 29)
        Me.rbtUseValue.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.rbtUseValue.Name = "rbtUseValue"
        Me.rbtUseValue.Size = New System.Drawing.Size(14, 13)
        Me.rbtUseValue.TabIndex = 1
        Me.rbtUseValue.TabStop = True
        Me.rbtUseValue.UseVisualStyleBackColor = True
        '
        'frmClientGrouping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(782, 270)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.txtBborderSumm)
        Me.Controls.Add(Me.txtAborderSumm)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtBborderPercentage)
        Me.Controls.Add(Me.txtAborderPercentage)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalSumm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAverageSumm)
        Me.Controls.Add(Me.txtBorderSumm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmClientGrouping"
        Me.Text = "Klientu grupēšana"
        CType(Me.txtBorderSumm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAborderPercentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBborderPercentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBborderSumm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAborderSumm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBorderSumm As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnAverageSumm As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalSumm As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents txtAborderPercentage As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtBborderPercentage As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtBborderSumm As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtAborderSumm As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents rbtUsePercentage As System.Windows.Forms.RadioButton
    Friend WithEvents rbtUseValue As System.Windows.Forms.RadioButton

End Class
