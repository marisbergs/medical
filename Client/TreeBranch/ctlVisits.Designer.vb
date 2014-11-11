<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlVisits
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.bndVisits = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdVisits = New Core.UI.CoreGrid
        Me.gvwVisits = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiagnosisCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsueDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPayd = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.bndVisits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdVisits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwVisits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bndVisits
        '
        Me.bndVisits.DataSource = GetType(Entities.Visit)
        '
        'grdVisits
        '
        Me.grdVisits.DataSource = Me.bndVisits
        Me.grdVisits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdVisits.EmbeddedNavigator.Name = ""
        Me.grdVisits.EnforceCanEdit = False
        Me.grdVisits.Location = New System.Drawing.Point(0, 0)
        Me.grdVisits.MainView = Me.gvwVisits
        Me.grdVisits.Name = "grdVisits"
        Me.grdVisits.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.grdVisits.ShowOnlyActive = False
        Me.grdVisits.Size = New System.Drawing.Size(597, 330)
        Me.grdVisits.TabIndex = 1
        Me.grdVisits.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwVisits})
        '
        'gvwVisits
        '
        Me.gvwVisits.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName, Me.colDiagnosisCode, Me.colIsActive, Me.colNotes, Me.colIsueDate, Me.colTotal, Me.colPayd})
        Me.gvwVisits.GridControl = Me.grdVisits
        Me.gvwVisits.Name = "gvwVisits"
        Me.gvwVisits.OptionsBehavior.Editable = False
        Me.gvwVisits.OptionsSelection.MultiSelect = True
        Me.gvwVisits.OptionsView.ShowDetailButtons = False
        Me.gvwVisits.OptionsView.ShowFilterPanel = False
        Me.gvwVisits.OptionsView.ShowFooter = True
        Me.gvwVisits.OptionsView.ShowGroupPanel = False
        Me.gvwVisits.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colIsueDate, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colName
        '
        Me.colName.Caption = "Vizītes sākums"
        Me.colName.DisplayFormat.FormatString = "g"
        Me.colName.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colName.FieldName = "StartTime"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colDiagnosisCode
        '
        Me.colDiagnosisCode.Caption = "Statuss"
        Me.colDiagnosisCode.Name = "colDiagnosisCode"
        Me.colDiagnosisCode.Visible = True
        Me.colDiagnosisCode.VisibleIndex = 1
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        '
        'colNotes
        '
        Me.colNotes.Caption = "Pakalpojums"
        Me.colNotes.FieldName = "Service"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 3
        '
        'colIsueDate
        '
        Me.colIsueDate.Caption = "Ârsts"
        Me.colIsueDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colIsueDate.DisplayFormat.FormatString = "d"
        Me.colIsueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colIsueDate.FieldName = "Doctor"
        Me.colIsueDate.Name = "colIsueDate"
        Me.colIsueDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colIsueDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.colIsueDate.Visible = True
        Me.colIsueDate.VisibleIndex = 2
        Me.colIsueDate.Width = 99
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colTotal
        '
        Me.colTotal.Caption = "Kopā"
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 4
        '
        'colPayd
        '
        Me.colPayd.Caption = "Samaksāts"
        Me.colPayd.FieldName = "Payd"
        Me.colPayd.Name = "colPayd"
        Me.colPayd.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colPayd.Visible = True
        Me.colPayd.VisibleIndex = 5
        '
        'ctlVisits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grdVisits)
        Me.Name = "ctlVisits"
        Me.Size = New System.Drawing.Size(597, 330)
        CType(Me.bndVisits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdVisits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwVisits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndVisits As System.Windows.Forms.BindingSource
    Friend WithEvents grdVisits As Core.UI.CoreGrid
    Friend WithEvents gvwVisits As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiagnosisCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayd As DevExpress.XtraGrid.Columns.GridColumn

End Class
