Imports System
Imports System.Collections.Generic
Imports NHibernate
Imports Core
'ёй
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPatientFindAdvanced
    Inherits ctlFind

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        If DesignMode Then Return
        If DesignerDetector.IsComponentInDesignMode(Me) Then Return
        ' Dim coll As New Core.Bll.BusinessCollectionBase(Of Entities.Position)


        '        coll.CriteriaDelegate = AddressOf Entities.Position.ApplyCriteriaAsc
        '       coll.FetchWithCriteria()

        ' bindFindUsers.DataSource = so
        ' bindPositions.DataSource = coll

        ' If coll.Count > 0 Then
        ' so.Position = coll.Item(0)
        ' End If

    End Sub


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
        Me.panTableLayout = New System.Windows.Forms.TableLayoutPanel
        Me.chkCode = New System.Windows.Forms.CheckBox
        Me.chkSurname = New System.Windows.Forms.CheckBox
        Me.chkUseSex = New System.Windows.Forms.CheckBox
        Me.chkNumber = New System.Windows.Forms.CheckBox
        Me.chkCreateDate = New System.Windows.Forms.CheckBox
        Me.chkCreatePlace = New System.Windows.Forms.CheckBox
        Me.chkBirthDate = New System.Windows.Forms.CheckBox
        Me.chkRecomend = New System.Windows.Forms.CheckBox
        Me.chkPatientStatus = New System.Windows.Forms.CheckBox
        Me.cmbSex = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTableLayout.SuspendLayout()
        CType(Me.cmbSex.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bndFind
        '
        Me.bndFind.DataSource = GetType(Entities.FindPatientsAdvanced)
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(408, 3)
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(277, 3)
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(489, 3)
        '
        'btnHideNonChecked
        '
        Me.btnHideNonChecked.Location = New System.Drawing.Point(129, 3)
        '
        'panTableLayout
        '
        Me.panTableLayout.AutoSize = True
        Me.panTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panTableLayout.ColumnCount = 2
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.panTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.panTableLayout.Controls.Add(Me.chkCode, 0, 6)
        Me.panTableLayout.Controls.Add(Me.chkSurname, 0, 2)
        Me.panTableLayout.Controls.Add(Me.chkUseSex, 0, 1)
        Me.panTableLayout.Controls.Add(Me.chkNumber, 0, 3)
        Me.panTableLayout.Controls.Add(Me.chkCreateDate, 0, 7)
        Me.panTableLayout.Controls.Add(Me.chkCreatePlace, 0, 8)
        Me.panTableLayout.Controls.Add(Me.chkBirthDate, 0, 5)
        Me.panTableLayout.Controls.Add(Me.chkRecomend, 0, 9)
        Me.panTableLayout.Controls.Add(Me.chkPatientStatus, 0, 4)
        Me.panTableLayout.Controls.Add(Me.cmbSex, 1, 1)
        Me.panTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.panTableLayout.Name = "panTableLayout"
        Me.panTableLayout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.panTableLayout.RowCount = 10
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.panTableLayout.Size = New System.Drawing.Size(662, 254)
        Me.panTableLayout.TabIndex = 2
        '
        'chkCode
        '
        Me.chkCode.AutoSize = True
        Me.chkCode.Location = New System.Drawing.Point(3, 121)
        Me.chkCode.Name = "chkCode"
        Me.chkCode.Size = New System.Drawing.Size(99, 17)
        Me.chkCode.TabIndex = 16
        Me.chkCode.Text = "Personas kods:"
        Me.chkCode.UseVisualStyleBackColor = True
        '
        'chkSurname
        '
        Me.chkSurname.AutoSize = True
        Me.chkSurname.Location = New System.Drawing.Point(3, 29)
        Me.chkSurname.Name = "chkSurname"
        Me.chkSurname.Size = New System.Drawing.Size(68, 17)
        Me.chkSurname.TabIndex = 10
        Me.chkSurname.Text = "Uzvārds:"
        Me.chkSurname.UseVisualStyleBackColor = True
        '
        'chkUseSex
        '
        Me.chkUseSex.AutoSize = True
        Me.chkUseSex.Location = New System.Drawing.Point(3, 3)
        Me.chkUseSex.Name = "chkUseSex"
        Me.chkUseSex.Size = New System.Drawing.Size(68, 17)
        Me.chkUseSex.TabIndex = 169
        Me.chkUseSex.Text = "Dzimums"
        Me.chkUseSex.UseVisualStyleBackColor = True
        '
        'chkNumber
        '
        Me.chkNumber.AutoSize = True
        Me.chkNumber.Location = New System.Drawing.Point(3, 52)
        Me.chkNumber.Name = "chkNumber"
        Me.chkNumber.Size = New System.Drawing.Size(78, 17)
        Me.chkNumber.TabIndex = 170
        Me.chkNumber.Text = "Klienta Nr.:"
        Me.chkNumber.UseVisualStyleBackColor = True
        '
        'chkCreateDate
        '
        Me.chkCreateDate.AutoSize = True
        Me.chkCreateDate.Location = New System.Drawing.Point(3, 144)
        Me.chkCreateDate.Name = "chkCreateDate"
        Me.chkCreateDate.Size = New System.Drawing.Size(102, 17)
        Me.chkCreateDate.TabIndex = 182
        Me.chkCreateDate.Text = "Izveides datums"
        Me.chkCreateDate.UseVisualStyleBackColor = True
        '
        'chkCreatePlace
        '
        Me.chkCreatePlace.AutoSize = True
        Me.chkCreatePlace.Location = New System.Drawing.Point(3, 167)
        Me.chkCreatePlace.Name = "chkCreatePlace"
        Me.chkCreatePlace.Size = New System.Drawing.Size(91, 17)
        Me.chkCreatePlace.TabIndex = 183
        Me.chkCreatePlace.Text = "Izveides vieta"
        Me.chkCreatePlace.UseVisualStyleBackColor = True
        '
        'chkBirthDate
        '
        Me.chkBirthDate.AutoSize = True
        Me.chkBirthDate.Location = New System.Drawing.Point(3, 98)
        Me.chkBirthDate.Name = "chkBirthDate"
        Me.chkBirthDate.Size = New System.Drawing.Size(97, 17)
        Me.chkBirthDate.TabIndex = 185
        Me.chkBirthDate.Text = "Dzimš. datums:"
        Me.chkBirthDate.UseVisualStyleBackColor = True
        '
        'chkRecomend
        '
        Me.chkRecomend.AutoSize = True
        Me.chkRecomend.Location = New System.Drawing.Point(3, 190)
        Me.chkRecomend.Name = "chkRecomend"
        Me.chkRecomend.Size = New System.Drawing.Size(58, 17)
        Me.chkRecomend.TabIndex = 186
        Me.chkRecomend.Text = "Ieteica"
        Me.chkRecomend.UseVisualStyleBackColor = True
        '
        'chkPatientStatus
        '
        Me.chkPatientStatus.AutoSize = True
        Me.chkPatientStatus.Location = New System.Drawing.Point(3, 75)
        Me.chkPatientStatus.Name = "chkPatientStatus"
        Me.chkPatientStatus.Size = New System.Drawing.Size(64, 17)
        Me.chkPatientStatus.TabIndex = 188
        Me.chkPatientStatus.Text = "Statuss:"
        Me.chkPatientStatus.UseVisualStyleBackColor = True
        '
        'cmbSex
        '
        Me.cmbSex.Location = New System.Drawing.Point(111, 3)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.cmbSex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbSex.Size = New System.Drawing.Size(100, 20)
        Me.cmbSex.TabIndex = 189
        '
        'ctlPatientFindAdvanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panTableLayout)
        Me.CriteriaTable = Me.panTableLayout
        Me.Name = "ctlPatientFindAdvanced"
        Me.Size = New System.Drawing.Size(662, 284)
        Me.Controls.SetChildIndex(Me.panTableLayout, 0)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTableLayout.ResumeLayout(False)
        Me.panTableLayout.PerformLayout()
        CType(Me.cmbSex.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkCode As System.Windows.Forms.CheckBox
    Friend WithEvents chkSurname As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseSex As System.Windows.Forms.CheckBox
    Friend WithEvents chkNumber As System.Windows.Forms.CheckBox
    Friend WithEvents chkCreateDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkCreatePlace As System.Windows.Forms.CheckBox
    Friend WithEvents chkBirthDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecomend As System.Windows.Forms.CheckBox
    Friend WithEvents chkPatientStatus As System.Windows.Forms.CheckBox
    Friend WithEvents cmbSex As DevExpress.XtraEditors.ComboBoxEdit

End Class
