Imports System
Imports System.Collections.Generic
Imports NHibernate
Imports Core
'ёй
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlProgrammFind
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
        Me.chkPatient = New System.Windows.Forms.CheckBox
        Me.chkProgrammTemplate = New System.Windows.Forms.CheckBox
        Me.txtProgrammTemplate = New Client.ClassifierPicker
        Me.txtPatient = New Client.ClassifierPicker
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTableLayout.SuspendLayout()
        CType(Me.txtProgrammTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bndFind
        '
        Me.bndFind.DataSource = GetType(Entities.FindProgramm)
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
        Me.panTableLayout.Controls.Add(Me.chkPatient, 0, 2)
        Me.panTableLayout.Controls.Add(Me.chkProgrammTemplate, 0, 1)
        Me.panTableLayout.Controls.Add(Me.txtProgrammTemplate, 1, 1)
        Me.panTableLayout.Controls.Add(Me.txtPatient, 1, 2)
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
        Me.panTableLayout.Size = New System.Drawing.Size(662, 57)
        Me.panTableLayout.TabIndex = 2
        '
        'chkPatient
        '
        Me.chkPatient.AutoSize = True
        Me.chkPatient.Location = New System.Drawing.Point(3, 29)
        Me.chkPatient.Name = "chkPatient"
        Me.chkPatient.Size = New System.Drawing.Size(57, 17)
        Me.chkPatient.TabIndex = 10
        Me.chkPatient.Text = "Klients"
        Me.chkPatient.UseVisualStyleBackColor = True
        '
        'chkProgrammTemplate
        '
        Me.chkProgrammTemplate.AutoSize = True
        Me.chkProgrammTemplate.Location = New System.Drawing.Point(3, 3)
        Me.chkProgrammTemplate.Name = "chkProgrammTemplate"
        Me.chkProgrammTemplate.Size = New System.Drawing.Size(79, 17)
        Me.chkProgrammTemplate.TabIndex = 169
        Me.chkProgrammTemplate.Text = "Programma"
        Me.chkProgrammTemplate.UseVisualStyleBackColor = True
        '
        'txtProgrammTemplate
        '
        Me.txtProgrammTemplate.AllowDrop = True
        Me.txtProgrammTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProgrammTemplate.Location = New System.Drawing.Point(88, 3)
        Me.txtProgrammTemplate.Name = "txtProgrammTemplate"
        Me.txtProgrammTemplate.PickerPresets = Nothing
        Me.txtProgrammTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtProgrammTemplate.Properties.ReadOnly = True
        Me.txtProgrammTemplate.Size = New System.Drawing.Size(556, 20)
        Me.txtProgrammTemplate.TabIndex = 190
        '
        'txtPatient
        '
        Me.txtPatient.AllowDrop = True
        Me.txtPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPatient.Location = New System.Drawing.Point(88, 29)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.PickerPresets = Nothing
        Me.txtPatient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtPatient.Properties.ReadOnly = True
        Me.txtPatient.Size = New System.Drawing.Size(556, 20)
        Me.txtPatient.TabIndex = 191
        '
        'ctlProgrammFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panTableLayout)
        Me.CriteriaTable = Me.panTableLayout
        Me.Name = "ctlProgrammFind"
        Me.Size = New System.Drawing.Size(662, 87)
        Me.Controls.SetChildIndex(Me.panTableLayout, 0)
        CType(Me.bndFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTableLayout.ResumeLayout(False)
        Me.panTableLayout.PerformLayout()
        CType(Me.txtProgrammTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkPatient As System.Windows.Forms.CheckBox
    Friend WithEvents chkProgrammTemplate As System.Windows.Forms.CheckBox
    Friend WithEvents txtProgrammTemplate As Client.ClassifierPicker
    Friend WithEvents txtPatient As Client.ClassifierPicker

End Class
