Imports Core
Imports Core.Dal
Imports Core.Bll
Imports Entities
Imports Core.UI


Public Class frmGynaecology
    Implements IEditForm

#Region "Data"
    Private _editedObject As Gynaecology
    Private _dataList As IList
    Private _dataIDs As New Dictionary(Of Type, Guid)
    Public Property DataIDs() As System.Collections.Generic.Dictionary(Of System.Type, System.Guid) Implements Core.UI.IEditForm.DataIDs
        Get
            'Return Nothing
            Return _dataIDs
        End Get
        Set(ByVal value As System.Collections.Generic.Dictionary(Of System.Type, System.Guid))
            If Me.DesignMode Then Return
            If value(GetType(Gynaecology)) = Guid.Empty Then 'add new
                _editedObject = New Gynaecology(Session)
            Else 'edit existing 
                _editedObject = Session.Get(Of Gynaecology)(value(GetType(Gynaecology)))
            End If

            ' fill bindingsources
            Me.bndGynaecology.DataSource = _editedObject
            Me.bndAllergy.DataSource = _editedObject.Allergies
            gbhAllergy.ShowActive = True
            Me.bndExtragenitalPathalogy.DataSource = _editedObject.ExtragenitalPathologys
            gbhExtragenitalPathalogy.ShowActive = True
            Me.bndOperations.DataSource = _editedObject.Operations
            gbhOperations.ShowActive = True
            Me.bndUsedMedicaments.DataSource = _editedObject.UseMedicaments
            gbhUsedMedicaments.ShowActive = True
            Me.bndEvolutionAnomaly.DataSource = _editedObject.EvolutionAnomalies
            gbhEvolutionAnomaly.ShowActive = True
            Me.bndHereditaryDsesase.DataSource = _editedObject.HereditaryDsesases
            gbhHereditaryDsesase.ShowActive = True
            Me.bndActyalMedicaments.DataSource = _editedObject.ActyalMedicamentsList
            gbhActyalMedicaments.ShowActive = True
            Me.bndIlness.DataSource = _editedObject.IlnessList
            gbhIlness.ShowActive = True
            Me.bndLabour.DataSource = _editedObject.Labour
            gbhLabour.ShowActive = True

            cmbHealth.Items.AddRange(Health.ListSource)
            cmbHealthNow.Items.AddRange(Health.ListSourceWellIll)
            cmbSex.Items.AddRange(Sex.ListSource)
        End Set
    End Property
    Public Property DataList() As System.Collections.IList Implements Core.UI.IEditForm.DataList
        Get
            Return _dataList
        End Get
        Set(ByVal value As System.Collections.IList)
            _dataList = value
        End Set
    End Property
#End Region

    Private Sub frmGynaecology_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gbhExtragenitalPathalogy.AddNewButton.DataBindings.Add("Enabled", bndGynaecology, "CanAddExtragenitalPathology", False, DataSourceUpdateMode.OnPropertyChanged)
        gbhOperations.AddNewButton.DataBindings.Add("Enabled", bndGynaecology, "CanAddOperation", False, DataSourceUpdateMode.OnPropertyChanged)
        gbhAllergy.AddNewButton.DataBindings.Add("Enabled", bndGynaecology, "CanAddAllergy", False, DataSourceUpdateMode.OnPropertyChanged)
        gbhUsedMedicaments.AddNewButton.DataBindings.Add("Enabled", bndGynaecology, "CanAddUseMedicament", False, DataSourceUpdateMode.OnPropertyChanged)
        gbhEvolutionAnomaly.AddNewButton.DataBindings.Add("Enabled", bndGynaecology, "CanAddEvolutionAnomaly", False, DataSourceUpdateMode.OnPropertyChanged)
        gbhHereditaryDsesase.AddNewButton.DataBindings.Add("Enabled", bndGynaecology, "CanAddHereditaryDsesase", False, DataSourceUpdateMode.OnPropertyChanged)
        gbhActyalMedicaments.AddNewButton.DataBindings.Add("Enabled", bndGynaecology, "CanAddActyalMedicaments", False, DataSourceUpdateMode.OnPropertyChanged)
        gbhIlness.AddNewButton.DataBindings.Add("Enabled", bndGynaecology, "CanAddIlness", False, DataSourceUpdateMode.OnPropertyChanged)
    End Sub

    Private Sub gbhExtragenitalPathalogy_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhExtragenitalPathalogy.OnAddNew
        Dim _obj As New AnamnesesExtragenitalPathalogy(Session)
        args.AddedObject = _obj
        _editedObject.ExtragenitalPathologys.Add(_obj)
    End Sub

    Private Sub gbhOperations_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhOperations.OnAddNew
        Dim _obj As New AnamnesesOperation(Session)
        args.AddedObject = _obj
        _editedObject.Operations.Add(_obj)
    End Sub

    Private Sub gbhAllergy_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhAllergy.OnAddNew
        Dim _obj As New AnamnesesAllergy(Session)
        args.AddedObject = _obj
        _editedObject.Allergies.Add(_obj)
    End Sub

    Private Sub gbhUsedMedicaments_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhUsedMedicaments.OnAddNew
        Dim _obj As New AnamnesesUsedMedicaments(Session)
        args.AddedObject = _obj
        _editedObject.UseMedicaments.Add(_obj)
    End Sub

    Private Sub gbhEvolutionAnomaly_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhEvolutionAnomaly.OnAddNew
        Dim _obj As New AnamnesesEvolutionAnomaly(Session)
        args.AddedObject = _obj
        _editedObject.EvolutionAnomalies.Add(_obj)
    End Sub

    Private Sub gbhHereditaryDsesase_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhHereditaryDsesase.OnAddNew
        Dim _obj As New AnamnesesHereditaryDsesase(Session)
        args.AddedObject = _obj
        _editedObject.HereditaryDsesases.Add(_obj)
    End Sub

    Private Sub gbhActyalMedicaments_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhActyalMedicaments.OnAddNew
        Dim _obj As New GynaecologyActualMedicaments(Session)
        args.AddedObject = _obj
        _editedObject.ActyalMedicamentsList.Add(_obj)
    End Sub

    Private Sub gbhIlness_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhIlness.OnAddNew
        Dim _obj As New GynaecologyIlness(Session)
        args.AddedObject = _obj
        _editedObject.IlnessList.Add(_obj)
    End Sub

    Private Sub gbhLabour_OnAddNew(ByVal sender As System.Object, ByVal args As Core.UI.GridButtonHelper.AddNewEventArgs) Handles gbhLabour.OnAddNew
        Dim _obj As New Labour(Session)
        args.AddedObject = _obj
        _editedObject.Labour.Add(_obj)
    End Sub
End Class