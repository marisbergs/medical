<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPrescription
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
        Me.grdPrescription = New Core.UI.CoreGrid
        Me.bndPrescription = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvwPrescription = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiagnosisCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsueDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        CType(Me.grdPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPrescription
        '
        Me.grdPrescription.DataSource = Me.bndPrescription
        Me.grdPrescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPrescription.EmbeddedNavigator.Name = ""
        Me.grdPrescription.EnforceCanEdit = False
        Me.grdPrescription.Location = New System.Drawing.Point(0, 0)
        Me.grdPrescription.MainView = Me.gvwPrescription
        Me.grdPrescription.Name = "grdPrescription"
        Me.grdPrescription.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.grdPrescription.ShowOnlyActive = False
        Me.grdPrescription.Size = New System.Drawing.Size(474, 314)
        Me.grdPrescription.TabIndex = 0
        Me.grdPrescription.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPrescription})
        '
        'bndPrescription
        '
        Me.bndPrescription.DataSource = GetType(Entities.Prescription)
        '
        'gvwPrescription
        '
        Me.gvwPrescription.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName, Me.colDiagnosisCode, Me.colIsActive, Me.colNotes, Me.colIsueDate})
        Me.gvwPrescription.GridControl = Me.grdPrescription
        Me.gvwPrescription.Name = "gvwPrescription"
        Me.gvwPrescription.OptionsBehavior.Editable = False
        Me.gvwPrescription.OptionsView.ShowDetailButtons = False
        Me.gvwPrescription.OptionsView.ShowFilterPanel = False
        Me.gvwPrescription.OptionsView.ShowGroupPanel = False
        Me.gvwPrescription.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colIsueDate, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colName
        '
        Me.colName.Caption = "Dokumenta nosaukums"
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colDiagnosisCode
        '
        Me.colDiagnosisCode.Caption = "Diagnozes kods"
        Me.colDiagnosisCode.FieldName = "DiagnosisCode"
        Me.colDiagnosisCode.Name = "colDiagnosisCode"
        Me.colDiagnosisCode.Visible = True
        Me.colDiagnosisCode.VisibleIndex = 2
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        '
        'colNotes
        '
        Me.colNotes.Caption = "Apraksts"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 3
        '
        'colIsueDate
        '
        Me.colIsueDate.Caption = "Datums"
        Me.colIsueDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colIsueDate.DisplayFormat.FormatString = "d"
        Me.colIsueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colIsueDate.FieldName = "IsueDate"
        Me.colIsueDate.Name = "colIsueDate"
        Me.colIsueDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colIsueDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.colIsueDate.Visible = True
        Me.colIsueDate.VisibleIndex = 1
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'ctlPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grdPrescription)
        Me.Name = "ctlPrescription"
        Me.Size = New System.Drawing.Size(474, 314)
        CType(Me.grdPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdPrescription As Core.UI.CoreGrid
    Friend WithEvents gvwPrescription As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bndPrescription As System.Windows.Forms.BindingSource
    Friend WithEvents colDiagnosisCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

End Class
