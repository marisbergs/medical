 use tpais_local
go

set nocount on
--delete from _SynchroConfig
delete from _SynchroData
--delete from _SysParameters


--update _SysParameters set prm_Value = '1.0.1.33' where prm_name = 'VERSION_APP'
--update _SysParameters set prm_Value = '1' where prm_name = 'VERSION_CENTRAL_DB'
--update _SysParameters set prm_Value = '1' where prm_name = 'VERSION_LOCAL_DB'
--go


delete from AccountingChecks
delete from AccountingDocuments
delete from AccountingRegisters
delete from AccountingSimpleRecords
delete from AccountingSoftware
delete from Resources
delete from DocumentPerformers
delete from Performers
delete from Activities
delete from ActPartners
delete from Licences
delete from TaxpayerInform
delete from UndeclaredAccounts
delete from TaxpayerMembers
delete from ExternalPersons
delete from InvitationDocuments
delete from InspectionActs
delete from DealDocuments
delete from ObservationActs
delete from EAAct2Inventories
delete from EAAct2Journals
delete from EAAct2ZX
delete from EAAct2
delete from EAAct1_4
delete from EAAct3ReceiptsAfter
delete from EAAct3ReceiptsBefore
delete from EAAct3
delete from CashRegister
delete from SpecialActEnd
delete from SpecialActs
delete from TIEstablished
delete from TIActEnd
delete from TIActs
delete from Acts
delete from Appeals
--delete from ATS_IZM
delete from Attachments
delete from AuditLog
delete from AuditNotifications
--delete from AuthorizationForProperty
delete from AuthorizationsVisitTaxPayer
delete from AVProtocols
--delete from BILDES
delete from CashDealDetails
delete from CashDeals
delete from CashOperationGoods
delete from CashOperationMoney
delete from CashOperationRequisites
delete from CashOperations
delete from CharacterStatementDetails
delete from CharacterStatements
go
--delete from Classifiers
--delete from ClassifierTypes

delete from CMCaseComments
delete from CMCaseRisks
delete from CMCaseSpecialMarks
delete from CMCaseThemes
delete from CMCaseViolatedRules
delete from CMCaseViolationResponsibleRules
delete from CMCaseViolations
delete from CodeCheck
delete from ConstructionContractors
delete from ConstructionMaterials
delete from Constructions
delete from Correspondence
delete from DataCompareDetails
delete from DataCompare
delete from DealCompareAccounts
delete from DealCompareDocuments
delete from DealCompare
delete from DutyInspections
delete from Partners
delete from Decisions
delete from Employees
delete from Employers
--delete from Veidlapu_IZM
--delete from DOKUMENTS
delete from EndDecisionCashDeals
delete from EndDecisionFixedAssets
delete from EndDecisionHaltProlongs
delete from EndDecisionHalts
delete from EndDecisionHaltWarnings
delete from EndDecisionResponsibilities
delete from EndDecisionRestores
delete from EndDecisionStateDuties
delete from StatementAfterActions
delete from StatementDecisions
delete from StatementPenaltyRules
delete from StatementPenalties
delete from StatementSpecialMarks
delete from StatementViolationDetails
delete from StatementViolations
delete from Statements
delete from EndDecisions
delete from ExciseGoodsNumbers
delete from ExciseGoods
delete from FixedAssetsAccounting
delete from FixedAssetsWarehouse
delete from FixedAssets
delete from FuelLoss
delete from FuelMeasures
delete from Fuel
delete from GambleEquipments
delete from Gambles
delete from InfoAboutStatedAccounts
delete from InfoAboutStatedCashRegisters
delete from InfoAboutStatedEmployees
delete from InfoAboutStatedNaturalResources
delete from InfoAboutStatedReports
delete from InfoAboutStated
delete from LatestCM
delete from MandatoryFormDetails
delete from MandatoryForms
delete from MetalLEDeals
delete from MetalPEDeals
delete from Metals
delete from NoticePenalties
delete from NoticeViolations
delete from Numerators
delete from Patents
delete from PendingEmails
delete from QualityAcquaintances
delete from QualityDetails
delete from QualityNotes
delete from Quality
delete from RealEstateTaxpayers
delete from RealEstate
--delete from REDAKCIJA
delete from RelatedCMCases
delete from RiskDutyDetails
delete from RiskDuties
delete from SrsNumberDetails
delete from SrsNumbers
delete from StateDutyDocuments
delete from StateDutyServices
delete from StateDuties
delete from StatusChanges
delete from TimberCheckOnRoad
delete from TimberEquipments
delete from TimberIncompleteWaybills
delete from TimberReceivedDocumentDetails
delete from TimberReceivedDocuments
delete from TimberRegisterResponsibles
delete from TimberSentDocumentDetails
delete from TimberSentDocuments
delete from TimberStackMeasureDetails
delete from TimberStackMeasures
delete from TimberStorageCheck
--delete from TP_SAITES_IZM
--delete from UserReplacements
--delete from ViolatedRules
--delete from ViolationResponsibleRules
--delete from ViolationThemes
--delete from Violations
delete from WarehouseRequests
delete from Waybills
delete from WholesaleGoods
delete from Wholesale
delete from WithdrawalProtocols
delete from WWDocuments
delete from WWExtraCharges
delete from WWBase
go
delete from DocFileHistory where not exists (select * from AuthorizationForProperty where afp_id = dfh_document_id)
delete from DocOwnerHistory where not exists (select * from AuthorizationForProperty where afp_id = doh_document_id)
delete from DocStatusHistory where not exists (select * from AuthorizationForProperty where afp_id = dsh_document_id)
go
delete from Documents where not DOC_CASE_ID is null and not exists (select * from AuthorizationForProperty where doc_id = afp_id)
-- update documents set doc_Case_id = null where doc_type_id = 'AuthorizationForProperty'
--select * from documents
delete from CMCases
delete from TcdPlans
delete from Documents where DOC_TYPE_ID <> 'AuthorizationForProperty'
go
--delete from Users
--go
--delete from Organizations
--delete from Permissions
--delete from Roles
--delete from RolesPermissions

-- select * from templates

--delete from templates where not tpl__Delete_time is null
--delete from templates where tpl_code like 'Other%' OR tpl_code like 'Letter%'

--delete from templatefileversions where not tfv__Delete_time is null

/*
select tfv_template_id, count(*)
from TemplateFileVersions
group by tfv_template_id
having count(*) > 1

select * from TemplateFileVersions where TFV_TEMPLATE_ID ='A1BC4489-21C3-4497-8C35-502C114AB60A'
delete from TemplateFileVersions where TFV_TEMPLATE_ID ='A1BC4489-21C3-4497-8C35-502C114AB60A' and TFV_VERSION_NUMBER <> '1001'
select * from templates
*/
-- delete from TemplateSignatories
delete from TextContent
go

delete from binaryfiles
where bfi_id in (
select bfi_id
from TemplateFileVersions right join BinaryFiles
     on TemplateFileVersions.TFV_FILE_ID = BinaryFiles.BFI_ID
where TFV_ID is null
)
go

UPDATE _SynchroConfig SET SYC_WORKSTATION_ID = NULL
go
update _synchroconfig set syc_current_version = syc_current_version -1
go


-- select 'DBCC DBREINDEX(' + name + ')' from sysobjects where xtype='U'

DBCC DBREINDEX(WithdrawalProtocols)
DBCC DBREINDEX(QualityNotes)
DBCC DBREINDEX(TextContent)
DBCC DBREINDEX(MetalPEDeals)
DBCC DBREINDEX(GambleEquipments)
DBCC DBREINDEX(DutyInspections)
DBCC DBREINDEX(Statements)
DBCC DBREINDEX(Constructions)
DBCC DBREINDEX(Licences)
DBCC DBREINDEX(InfoAboutStatedCashRegisters)
DBCC DBREINDEX(Employees)
DBCC DBREINDEX(Templates)
DBCC DBREINDEX(RolesPermissions)
DBCC DBREINDEX(FixedAssetsAccounting)
DBCC DBREINDEX(Violations)
DBCC DBREINDEX(QualityDetails)
DBCC DBREINDEX(_SysParameters)
DBCC DBREINDEX(RiskDuties)
DBCC DBREINDEX(AuditLog)
DBCC DBREINDEX(ObservationActs)
DBCC DBREINDEX(QualityAcquaintances)
DBCC DBREINDEX(TaxpayerInform)
DBCC DBREINDEX(BinaryContent)
DBCC DBREINDEX(RiskDutyDetails)
DBCC DBREINDEX(Numerators)
DBCC DBREINDEX(BinaryFiles)
DBCC DBREINDEX(TimberEquipments)
DBCC DBREINDEX(FixedAssetsWarehouse)
DBCC DBREINDEX(TIEstablished)
DBCC DBREINDEX(Metals)
DBCC DBREINDEX(DealDocuments)
DBCC DBREINDEX(UndeclaredAccounts)
DBCC DBREINDEX(CashDealDetails)
DBCC DBREINDEX(InfoAboutStatedEmployees)
DBCC DBREINDEX(Activities)
DBCC DBREINDEX(Patents)
DBCC DBREINDEX(Partners)
DBCC DBREINDEX(CharacterStatementDetails)
DBCC DBREINDEX(TimberStorageCheck)
DBCC DBREINDEX(CashRegister)
DBCC DBREINDEX(InfoAboutStatedNaturalResources)
DBCC DBREINDEX(UserReplacements)
DBCC DBREINDEX(Permissions)
DBCC DBREINDEX(InspectionActs)
DBCC DBREINDEX(ClassifierTypes)
DBCC DBREINDEX(Correspondence)
DBCC DBREINDEX(AccountingSoftware)
DBCC DBREINDEX(StateDuties)
DBCC DBREINDEX(DataCompare)
DBCC DBREINDEX(ActPartners)
DBCC DBREINDEX(Classifiers)
DBCC DBREINDEX(ViolationResponsibleRules)
DBCC DBREINDEX(DocFileHistory)
DBCC DBREINDEX(CMCaseViolations)
DBCC DBREINDEX(StateDutyDocuments)
DBCC DBREINDEX(RealEstate)
DBCC DBREINDEX(Decisions)
DBCC DBREINDEX(InfoAboutStatedReports)
DBCC DBREINDEX(FixedAssets)
DBCC DBREINDEX(TcdPlans)
DBCC DBREINDEX(CMCaseRisks)
DBCC DBREINDEX(AccountingRegisters)
DBCC DBREINDEX(InfoAboutStatedAccounts)
DBCC DBREINDEX(CMCaseViolationResponsibleRules)
DBCC DBREINDEX(TemplateFileVersions)
DBCC DBREINDEX(Fuel)
DBCC DBREINDEX(AuthorizationsVisitTaxPayer)
DBCC DBREINDEX(StateDutyServices)
DBCC DBREINDEX(Employers)
DBCC DBREINDEX(ViolatedRules)
DBCC DBREINDEX(FuelMeasures)
DBCC DBREINDEX(Roles)
DBCC DBREINDEX(AuditNotifications)
DBCC DBREINDEX(CashOperations)
DBCC DBREINDEX(TaxpayerMembers)
DBCC DBREINDEX(CashOperationGoods)
DBCC DBREINDEX(CodeCheck)
DBCC DBREINDEX(TemplateSignatories)
DBCC DBREINDEX(AccountingDocuments)
DBCC DBREINDEX(StatementSpecialMarks)
DBCC DBREINDEX(CashOperationRequisites)
DBCC DBREINDEX(ExciseGoodsNumbers)
DBCC DBREINDEX(DocStatusHistory)
DBCC DBREINDEX(TIActEnd)
DBCC DBREINDEX(WarehouseRequests)
DBCC DBREINDEX(StatementPenalties)
DBCC DBREINDEX(SpecialActEnd)
DBCC DBREINDEX(DocOwnerHistory)
DBCC DBREINDEX(RealEstateTaxpayers)
DBCC DBREINDEX(Organizations)
DBCC DBREINDEX(TimberSentDocuments)
DBCC DBREINDEX(EAAct2)
DBCC DBREINDEX(CMCaseSpecialMarks)
DBCC DBREINDEX(StatementPenaltyRules)
DBCC DBREINDEX(TimberReceivedDocumentDetails)
DBCC DBREINDEX(Quality)
DBCC DBREINDEX(ExternalPersons)
DBCC DBREINDEX(CMCases)
DBCC DBREINDEX(EAAct2ZX)
DBCC DBREINDEX(EAAct1_4)
DBCC DBREINDEX(DocumentPerformers)
DBCC DBREINDEX(CMCaseThemes)
DBCC DBREINDEX(StatementDecisions)
DBCC DBREINDEX(ConstructionContractors)
DBCC DBREINDEX(CashOperationMoney)
DBCC DBREINDEX(TimberSentDocumentDetails)
DBCC DBREINDEX(EAAct2Inventories)
DBCC DBREINDEX(NoticeViolations)
DBCC DBREINDEX(ConstructionMaterials)
DBCC DBREINDEX(EndDecisionCashDeals)
DBCC DBREINDEX(LatestCM)
DBCC DBREINDEX(TIActs)
DBCC DBREINDEX(EndDecisionFixedAssets)
DBCC DBREINDEX(WWDocuments)
DBCC DBREINDEX(NoticePenalties)
DBCC DBREINDEX(TimberStackMeasures)
DBCC DBREINDEX(EAAct2Journals)
DBCC DBREINDEX(EndDecisionStateDuties)
DBCC DBREINDEX(_SynchroConfig)
DBCC DBREINDEX(DataCompareDetails)
DBCC DBREINDEX(TimberStackMeasureDetails)
DBCC DBREINDEX(StatementAfterActions)
DBCC DBREINDEX(RelatedCMCases)
DBCC DBREINDEX(EndDecisionHaltWarnings)
DBCC DBREINDEX(TimberIncompleteWaybills)
DBCC DBREINDEX(_SynchroData)
DBCC DBREINDEX(WholesaleGoods)
DBCC DBREINDEX(EndDecisionHalts)
DBCC DBREINDEX(AuthorizationForProperty)
DBCC DBREINDEX(DealCompareDocuments)
DBCC DBREINDEX(InvitationDocuments)
DBCC DBREINDEX(EAAct3)
DBCC DBREINDEX(CMCaseViolatedRules)
DBCC DBREINDEX(EndDecisionRestores)
DBCC DBREINDEX(ATS_IZM)
DBCC DBREINDEX(BILDES)
DBCC DBREINDEX(TimberRegisterResponsibles)
DBCC DBREINDEX(WWExtraCharges)
DBCC DBREINDEX(EndDecisionHaltProlongs)
DBCC DBREINDEX(DOKUMENTS)
DBCC DBREINDEX(EAAct3ReceiptsBefore)
DBCC DBREINDEX(Attachments)
DBCC DBREINDEX(REDAKCIJA)
DBCC DBREINDEX(CMCaseComments)
DBCC DBREINDEX(AVProtocols)
DBCC DBREINDEX(TP_SAITES_IZM)
DBCC DBREINDEX(DealCompareAccounts)
DBCC DBREINDEX(EndDecisionResponsibilities)
DBCC DBREINDEX(Veidlapu_IZM)
DBCC DBREINDEX(FuelLoss)
DBCC DBREINDEX(AccountingSimpleRecords)
DBCC DBREINDEX(CharacterStatements)
DBCC DBREINDEX(ExciseGoods)
DBCC DBREINDEX(SrsNumbers)
DBCC DBREINDEX(EAAct3ReceiptsAfter)
DBCC DBREINDEX(StatusChanges)
DBCC DBREINDEX(Documents)
DBCC DBREINDEX(CashDeals)
DBCC DBREINDEX(Users)
DBCC DBREINDEX(DealCompare)
DBCC DBREINDEX(AccountingChecks)
DBCC DBREINDEX(Acts)
DBCC DBREINDEX(StatementViolationDetails)
DBCC DBREINDEX(Appeals)
DBCC DBREINDEX(SrsNumberDetails)
DBCC DBREINDEX(PendingEmails)
DBCC DBREINDEX(dtproperties)
DBCC DBREINDEX(Resources)
DBCC DBREINDEX(ViolationThemes)
DBCC DBREINDEX(StatementViolations)
DBCC DBREINDEX(MandatoryForms)
DBCC DBREINDEX(TimberCheckOnRoad)
DBCC DBREINDEX(TemplateThemes)
DBCC DBREINDEX(InfoAboutStated)
DBCC DBREINDEX(SpecialActs)
DBCC DBREINDEX(MetalLEDeals)
DBCC DBREINDEX(MandatoryFormDetails)
DBCC DBREINDEX(Gambles)
DBCC DBREINDEX(TimberReceivedDocuments)
DBCC DBREINDEX(Wholesale)
DBCC DBREINDEX(Performers)
DBCC DBREINDEX(EndDecisions)
DBCC DBREINDEX(WWBase)
DBCC DBREINDEX(Waybills)
go

DBCC UPDATEUSAGE (tpais_local)
go

backup log tpais_local with truncate_only
go

DBCC SHRINKFILE ('TPAIS_Large', 30)
go

DBCC SHRINKFILE ('TPAIS_Primary', 20)
go

DBCC SHRINKFILE ('TPAIS_log')
go


-- use master
-- go
-- sp_Detach_db TPAIS_local
-- go

--select * from Classifiers order by CLS_TYPE_ID

-- select * from classifiers where cls_type_id = 'whreport' and cls_parent_id = '9F3CC901-D50A-40A3-B324-1E3444EE02E3'

-- jâizmet jûzeri visi