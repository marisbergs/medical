<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassifierEdit
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.bndHierClassifier = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtText = New DevExpress.XtraEditors.MemoExEdit()
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.lblDateUntil = New System.Windows.Forms.Label()
        Me.dtpDateUntil = New DevExpress.XtraEditors.DateEdit()
        Me.chkIsActive = New System.Windows.Forms.CheckBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.beParent = New DevExpress.XtraEditors.ButtonEdit()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtDecimalValue = New DevExpress.XtraEditors.SpinEdit()
        Me.lblDecimalValue = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkFastIntroduce = New System.Windows.Forms.CheckBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtColorEdit = New DevExpress.XtraEditors.ColorEdit()
        Me.lblMark = New System.Windows.Forms.Label()
        Me.chkMark = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dtpDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndHierClassifier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateUntil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beParent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDecimalValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.txtColorEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.23762!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.76238!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblParent, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDateFrom, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtText, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDateFrom, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDateUntil, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDateUntil, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.chkIsActive, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.lblText, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.beParent, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblValue, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCode, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtValue, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCode, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDecimalValue, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDecimalValue, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.lblColor, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtColorEdit, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMark, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.chkMark, 1, 8)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(505, 271)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblParent
        '
        Me.lblParent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblParent.AutoSize = True
        Me.lblParent.Location = New System.Drawing.Point(3, 0)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(72, 26)
        Me.lblParent.TabIndex = 4
        Me.lblParent.Text = "Parent:"
        Me.lblParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDateFrom.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndHierClassifier, "ValidFrom", True))
        Me.dtpDateFrom.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndHierClassifier, "CanEdit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpDateFrom.EditValue = Nothing
        Me.dtpDateFrom.Location = New System.Drawing.Point(81, 81)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpDateFrom.Size = New System.Drawing.Size(401, 20)
        Me.dtpDateFrom.TabIndex = 3
        '
        'bndHierClassifier
        '
        Me.bndHierClassifier.DataSource = GetType(Entities.HierClassifier)
        '
        'txtText
        '
        Me.txtText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtText.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndHierClassifier, "Comment", True))
        Me.txtText.Location = New System.Drawing.Point(81, 133)
        Me.txtText.Name = "txtText"
        Me.txtText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtText.Properties.MaxLength = 1000
        Me.txtText.Properties.PopupStartSize = New System.Drawing.Size(400, 150)
        Me.txtText.Properties.ShowIcon = False
        Me.txtText.Size = New System.Drawing.Size(401, 20)
        Me.txtText.TabIndex = 10
        '
        'lblDateFrom
        '
        Me.lblDateFrom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Location = New System.Drawing.Point(3, 78)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(72, 26)
        Me.lblDateFrom.TabIndex = 2
        Me.lblDateFrom.Text = "Datums no:"
        Me.lblDateFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateUntil
        '
        Me.lblDateUntil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateUntil.AutoSize = True
        Me.lblDateUntil.Location = New System.Drawing.Point(3, 104)
        Me.lblDateUntil.Name = "lblDateUntil"
        Me.lblDateUntil.Size = New System.Drawing.Size(72, 26)
        Me.lblDateUntil.TabIndex = 3
        Me.lblDateUntil.Text = "Datums līdz:"
        Me.lblDateUntil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDateUntil
        '
        Me.dtpDateUntil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDateUntil.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndHierClassifier, "ValidUntil", True))
        Me.dtpDateUntil.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndHierClassifier, "CanEdit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpDateUntil.EditValue = Nothing
        Me.dtpDateUntil.Location = New System.Drawing.Point(81, 107)
        Me.dtpDateUntil.Name = "dtpDateUntil"
        Me.dtpDateUntil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.dtpDateUntil.Size = New System.Drawing.Size(401, 20)
        Me.dtpDateUntil.TabIndex = 4
        '
        'chkIsActive
        '
        Me.chkIsActive.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIsActive.AutoSize = True
        Me.chkIsActive.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bndHierClassifier, "IsActive", True))
        Me.chkIsActive.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bndHierClassifier, "CanDelete", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkIsActive.Enabled = False
        Me.chkIsActive.Location = New System.Drawing.Point(3, 231)
        Me.chkIsActive.Name = "chkIsActive"
        Me.chkIsActive.Size = New System.Drawing.Size(72, 37)
        Me.chkIsActive.TabIndex = 7
        Me.chkIsActive.Text = "Ir aktuāls"
        Me.chkIsActive.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(3, 130)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(72, 26)
        Me.lblText.TabIndex = 12
        Me.lblText.Text = "Piezīmes:"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'beParent
        '
        Me.beParent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.beParent.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndHierClassifier, "CanEdit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.beParent.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndHierClassifier, "Parents", True))
        Me.beParent.Enabled = False
        Me.beParent.Location = New System.Drawing.Point(81, 3)
        Me.beParent.Name = "beParent"
        Me.beParent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.beParent.Properties.ReadOnly = True
        Me.beParent.Size = New System.Drawing.Size(401, 20)
        Me.beParent.TabIndex = 0
        '
        'lblValue
        '
        Me.lblValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(3, 52)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(72, 26)
        Me.lblValue.TabIndex = 1
        Me.lblValue.Text = "Nosaukums:"
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(3, 26)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(72, 26)
        Me.lblCode.TabIndex = 0
        Me.lblCode.Text = "Kods:"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtValue
        '
        Me.txtValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndHierClassifier, "Value", True))
        Me.txtValue.DataBindings.Add(New System.Windows.Forms.Binding("ReadOnly", Me.bndHierClassifier, "CanEditNameForReadOnly", True))
        Me.txtValue.Location = New System.Drawing.Point(81, 55)
        Me.txtValue.MaxLength = 500
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(401, 20)
        Me.txtValue.TabIndex = 2
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndHierClassifier, "Code", True))
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("ReadOnly", Me.bndHierClassifier, "CanEditForReadOnly", True))
        Me.txtCode.Location = New System.Drawing.Point(81, 29)
        Me.txtCode.MaxLength = 50
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(401, 20)
        Me.txtCode.TabIndex = 1
        '
        'txtDecimalValue
        '
        Me.txtDecimalValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDecimalValue.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndHierClassifier, "DecimalValue", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtDecimalValue.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.bndHierClassifier, "CanEdit", True))
        Me.txtDecimalValue.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDecimalValue.Location = New System.Drawing.Point(81, 159)
        Me.txtDecimalValue.Name = "txtDecimalValue"
        Me.txtDecimalValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDecimalValue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDecimalValue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDecimalValue.Properties.MaxValue = New Decimal(New Integer() {1874919423, 2328306, 0, 131072})
        Me.txtDecimalValue.Size = New System.Drawing.Size(401, 20)
        Me.txtDecimalValue.TabIndex = 6
        '
        'lblDecimalValue
        '
        Me.lblDecimalValue.AutoSize = True
        Me.lblDecimalValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDecimalValue.Location = New System.Drawing.Point(3, 156)
        Me.lblDecimalValue.Name = "lblDecimalValue"
        Me.lblDecimalValue.Size = New System.Drawing.Size(72, 26)
        Me.lblDecimalValue.TabIndex = 16
        Me.lblDecimalValue.Text = "Vērtība"
        Me.lblDecimalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkFastIntroduce)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(81, 231)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(401, 30)
        Me.FlowLayoutPanel1.TabIndex = 11
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(323, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Aizvērt"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(242, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Saglabāt"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkFastIntroduce
        '
        Me.chkFastIntroduce.AutoSize = True
        Me.chkFastIntroduce.Location = New System.Drawing.Point(9, 6)
        Me.chkFastIntroduce.Margin = New System.Windows.Forms.Padding(3, 6, 60, 3)
        Me.chkFastIntroduce.Name = "chkFastIntroduce"
        Me.chkFastIntroduce.Size = New System.Drawing.Size(170, 17)
        Me.chkFastIntroduce.TabIndex = 10
        Me.chkFastIntroduce.Text = "pievienot esošajam virslīmenim"
        Me.chkFastIntroduce.UseVisualStyleBackColor = True
        Me.chkFastIntroduce.Visible = False
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColor.Location = New System.Drawing.Point(3, 182)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(72, 26)
        Me.lblColor.TabIndex = 17
        Me.lblColor.Text = "Krāsa:"
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtColorEdit
        '
        Me.txtColorEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bndHierClassifier, "ColorinBing", True))
        Me.txtColorEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtColorEdit.EditValue = System.Drawing.Color.Empty
        Me.txtColorEdit.Location = New System.Drawing.Point(81, 185)
        Me.txtColorEdit.Name = "txtColorEdit"
        Me.txtColorEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txtColorEdit.Size = New System.Drawing.Size(401, 20)
        Me.txtColorEdit.TabIndex = 18
        '
        'lblMark
        '
        Me.lblMark.AutoSize = True
        Me.lblMark.Location = New System.Drawing.Point(3, 208)
        Me.lblMark.Name = "lblMark"
        Me.lblMark.Size = New System.Drawing.Size(42, 13)
        Me.lblMark.TabIndex = 19
        Me.lblMark.Text = "Pazīme"
        '
        'chkMark
        '
        Me.chkMark.AutoSize = True
        Me.chkMark.Location = New System.Drawing.Point(81, 211)
        Me.chkMark.Name = "chkMark"
        Me.chkMark.Size = New System.Drawing.Size(15, 14)
        Me.chkMark.TabIndex = 20
        Me.chkMark.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.bndHierClassifier
        '
        'frmClassifierEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(505, 271)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(511, 50)
        Me.Name = "frmClassifierEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Klasifikatora ieraksta labošana"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dtpDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndHierClassifier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateUntil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beParent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDecimalValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.txtColorEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents lblDateFrom As System.Windows.Forms.Label
    Friend WithEvents lblDateUntil As System.Windows.Forms.Label
    Friend WithEvents lblParent As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDateUntil As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents chkIsActive As System.Windows.Forms.CheckBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents bndHierClassifier As System.Windows.Forms.BindingSource
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents beParent As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtDecimalValue As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblDecimalValue As System.Windows.Forms.Label
    Friend WithEvents txtText As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents chkFastIntroduce As System.Windows.Forms.CheckBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents txtColorEdit As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents lblMark As System.Windows.Forms.Label
    Friend WithEvents chkMark As System.Windows.Forms.CheckBox
End Class
