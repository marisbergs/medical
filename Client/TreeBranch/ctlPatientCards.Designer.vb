<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPatientCards
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
        Me.bndDocumentList = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdRtgSummary = New Core.UI.CoreGrid
        Me.gvwRtgSummary = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDocDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCreator = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        CType(Me.bndDocumentList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRtgSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwRtgSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bndDocumentList
        '
        Me.bndDocumentList.DataSource = GetType(Entities.PatientDocument)
        '
        'grdRtgSummary
        '
        Me.grdRtgSummary.DataSource = Me.bndDocumentList
        Me.grdRtgSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRtgSummary.EmbeddedNavigator.Name = ""
        Me.grdRtgSummary.EnforceCanEdit = False
        Me.grdRtgSummary.Location = New System.Drawing.Point(0, 0)
        Me.grdRtgSummary.MainView = Me.gvwRtgSummary
        Me.grdRtgSummary.Name = "grdRtgSummary"
        Me.grdRtgSummary.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.grdRtgSummary.ShowOnlyActive = False
        Me.grdRtgSummary.Size = New System.Drawing.Size(546, 335)
        Me.grdRtgSummary.TabIndex = 1
        Me.grdRtgSummary.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwRtgSummary})
        '
        'gvwRtgSummary
        '
        Me.gvwRtgSummary.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName, Me.colIsActive, Me.colDocDate, Me.colCreator})
        Me.gvwRtgSummary.GridControl = Me.grdRtgSummary
        Me.gvwRtgSummary.Name = "gvwRtgSummary"
        Me.gvwRtgSummary.OptionsBehavior.Editable = False
        Me.gvwRtgSummary.OptionsView.ShowDetailButtons = False
        Me.gvwRtgSummary.OptionsView.ShowFilterPanel = False
        Me.gvwRtgSummary.OptionsView.ShowGroupPanel = False
        '
        'colName
        '
        Me.colName.Caption = "Dokumenta nosaukums"
        Me.colName.FieldName = "DocType"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "IsActive"
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.Name = "colIsActive"
        '
        'colDocDate
        '
        Me.colDocDate.Caption = "Izveides datums"
        Me.colDocDate.FieldName = "CreationDate"
        Me.colDocDate.Name = "colDocDate"
        Me.colDocDate.Visible = True
        Me.colDocDate.VisibleIndex = 1
        '
        'colCreator
        '
        Me.colCreator.Caption = "Izveidoja"
        Me.colCreator.FieldName = "Creator"
        Me.colCreator.Name = "colCreator"
        Me.colCreator.Visible = True
        Me.colCreator.VisibleIndex = 2
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'ctlPatientCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grdRtgSummary)
        Me.Name = "ctlPatientCards"
        Me.Size = New System.Drawing.Size(546, 335)
        CType(Me.bndDocumentList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRtgSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwRtgSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bndDocumentList As System.Windows.Forms.BindingSource
    Friend WithEvents grdRtgSummary As Core.UI.CoreGrid
    Friend WithEvents gvwRtgSummary As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colDocDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreator As DevExpress.XtraGrid.Columns.GridColumn

End Class
