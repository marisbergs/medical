Imports Entities
Imports Core

Public Class MenuCreator
    Public Shared Function PerformDocumentMenu() As Dictionary(Of Type, Type)
        PerformDocumentMenu = New Dictionary(Of Type, Type)
        'PerformDocumentMenu.Add(GetType(ExciseGoods), GetType(frmExciseGoods))
        'PerformDocumentMenu.Add(GetType(Gambling), GetType(frmGambling))
        'PerformDocumentMenu.Add(GetType(Employer), GetType(frmEmployer))
        'PerformDocumentMenu.Add(GetType(DataCompare), GetType(frmDataCompare))
        'PerformDocumentMenu.Add(GetType(Fuel), GetType(frmFuel))
        'PerformDocumentMenu.Add(GetType(AccountingSimpleRecords), GetType(frmAccountingSimpleRecords))
        'PerformDocumentMenu.Add(GetType(FixedAsset), GetType(frmFixedAsset))
        'PerformDocumentMenu.Add(GetType(InfoAboutEmployer), GetType(frmInfoAboutEmployer))
        'PerformDocumentMenu.Add(GetType(CashOperation), GetType(frmCashOperation))
        'PerformDocumentMenu.Add(GetType(TimberStackMeasure), GetType(frmTimberStackMeasure))
        'PerformDocumentMenu.Add(GetType(TimberCheckOnRoad), GetType(frmTimberCheckOnRoad))
        'PerformDocumentMenu.Add(GetType(TimberStorageCheck), GetType(frmTimberStorageCheck))
        'PerformDocumentMenu.Add(GetType(Metal), GetType(frmMetal))
        'PerformDocumentMenu.Add(GetType(RealEstate), GetType(frmRealEstate))
        ''PerformDocumentMenu.Add(GetType(TimberSentDocument), GetType(frmTimberSentDocument))
        'PerformDocumentMenu.Add(GetType(Construction), GetType(frmConstruction))
        'PerformDocumentMenu.Add(GetType(Waybills), GetType(frmWaybills))
        'PerformDocumentMenu.Add(GetType(WholeSale), GetType(frmWholeSale))
        ''PerformDocumentMenu.Add(GetType(TimberReceivedDocument), GetType(frmTimberReceivedDocument))
        'PerformDocumentMenu.Add(GetType(DealCompare), GetType(frmDealCompare))
        'PerformDocumentMenu.Add(GetType(CashDeal), GetType(frmCashDeal))
        'PerformDocumentMenu.Add(GetType(MandatoryForm), GetType(frmMandatoryForm))
        'PerformDocumentMenu.Add(GetType(SrsNumber), GetType(frmSrsNumber))
        'PerformDocumentMenu.Add(GetType(TIEstablished), GetType(frmTIEstablished))
        'PerformDocumentMenu.Add(GetType(AccountingChecks), GetType(frmAccountingChecks))
        'PerformDocumentMenu.Add(GetType(RiskDuties), GetType(frmRiskDuties))
        'PerformDocumentMenu.Add(GetType(StateDuties), GetType(frmStateDuties))
    End Function
    Public Shared Function SpecialActResultDecisionMenu() As Dictionary(Of Type, Type)
        SpecialActResultDecisionMenu = New Dictionary(Of Type, Type)
        'SpecialActResultDecisionMenu.Add(GetType(EndDecisionHaltProlong), GetType(frmEndDecisionHaltProlong))
        'SpecialActResultDecisionMenu.Add(GetType(EndDecisionRestore), GetType(frmEndDecisionRestore))
        'SpecialActResultDecisionMenu.Add(GetType(EndDecisionResponsibility), GetType(frmEndDecisionResponsibility))
    End Function
    Public Shared Function TIActResultDecisionMenu() As Dictionary(Of Type, Type)
        TIActResultDecisionMenu = New Dictionary(Of Type, Type)
        'TIActResultDecisionMenu.Add(GetType(EndDecisionHaltWarning), GetType(frmEndDecisionHaltWarning))
        'TIActResultDecisionMenu.Add(GetType(EndDecisionHalt), GetType(frmEndDecisionHalt))
        ''TIActResultDecisionMenu.Add(GetType(EndDecisionFixedAsset), GetType(frmEndDecisionFixedAsset))
        ''TIActResultDecisionMenu.Add(GetType(EndDecisionCashDeal), GetType(frmEndDecisionCashDeal))
        'TIActResultDecisionMenu.Add(GetType(EndDecisionStateDuties), GetType(frmEndDecisionStateDuties))
        'TIActResultDecisionMenu.Add(GetType(EndDecisionResponsibility), GetType(frmEndDecisionResponsibility))
    End Function
    Public Shared Function StatementMenu() As Dictionary(Of Type, Type)
        StatementMenu = New Dictionary(Of Type, Type)
        'StatementMenu.Add(GetType(Statement), GetType(frmStatement))
        'StatementMenu.Add(GetType(CharacterStatement), GetType(frmCharacterStatement))
    End Function
End Class
