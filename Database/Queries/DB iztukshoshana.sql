use tpais_prod
go
/*
select 'delete from ' + name
from sysobjects
where xtype = 'U'
order by name*/

set nocount on
--delete from _SynchroConfig
delete from _SynchroData
--delete from _SysParameters
update _SysParameters set prm_Value = '1.0.1.0' where prm_name = 'VERSION_APP'
update _SysParameters set prm_Value = '1' where prm_name = 'VERSION_CENTRAL_DB'
update _SysParameters set prm_Value = '1' where prm_name = 'VERSION_LOCAL_DB'
go

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
delete from ATS_IZM
delete from Attachments
delete from AuditLog
delete from AuditNotifications
delete from AuthorizationForProperty
delete from AuthorizationsVisitTaxPayer
delete from AVProtocols
delete from BILDES
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
delete from Veidlapu_IZM
delete from DOKUMENTS
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
delete from REDAKCIJA
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
delete from TP_SAITES_IZM
delete from UserReplacements
delete from ViolatedRules
delete from ViolationResponsibleRules
delete from ViolationThemes
delete from Violations
delete from WarehouseRequests
delete from Waybills
delete from WholesaleGoods
delete from Wholesale
delete from WithdrawalProtocols
delete from WWDocuments
delete from WWExtraCharges
delete from WWBase
go
delete from DocFileHistory
delete from DocOwnerHistory
delete from DocStatusHistory
go
delete from Documents where not DOC_CASE_ID is null
delete from CMCases
delete from TcdPlans
delete from Documents
go
delete from Users
go
--delete from Organizations
--delete from Permissions
--delete from Roles
--delete from RolesPermissions

-- select * from templates

delete from templates where not tpl__Delete_time is null
delete from templates where tpl_code like 'Other%' OR tpl_code like 'Letter%'

delete from templatefileversions where not tfv__Delete_time is null

/*
select tfv_template_id, count(*)
from TemplateFileVersions
group by tfv_template_id
having count(*) > 1

select * from TemplateFileVersions where TFV_TEMPLATE_ID ='A1BC4489-21C3-4497-8C35-502C114AB60A'
delete from TemplateFileVersions where TFV_TEMPLATE_ID ='A1BC4489-21C3-4497-8C35-502C114AB60A' and TFV_VERSION_NUMBER <> '1001'
select * from templates
*/
delete from TemplateSignatories
delete from TextContent
go


ALTER TABLE [dbo].[Organizations] DROP CONSTRAINT [FK_ORG_HEAD_ID]
GO
delete from Organizations where IsNull(ORG__EXTERNAL_ID, 0) <> -1
GO
ALTER TABLE [dbo].[Organizations] ADD CONSTRAINT [FK_ORG_HEAD_ID] FOREIGN KEY 
	(
		[ORG_HEAD_ID]
	) REFERENCES [Organizations] (
		[ORG_ID]
	)
GO

delete from binaryfiles
where bfi_id in (
select bfi_id
from TemplateFileVersions right join BinaryFiles
     on TemplateFileVersions.TFV_FILE_ID = BinaryFiles.BFI_ID
where TFV_ID is null
)
go

delete from TemplateThemes
go

---------- ârçjo klasifikatoru dzçðana --------------- 
-- select 'delete from Classifiers where CLS_TYPE_ID = ''' + CLT_ID + ''' AND CLS__EXTERNAL_ID <> -1' from Classifiertypes where clt_kind = 2
delete from Classifiers where CLS_TYPE_ID = 'AfterAction' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'CashRegisterModel'
delete from Classifiers where CLS_TYPE_ID = 'CharacterTheme' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'CreditInstitution' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'DecisionType' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'ExtArticle' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'ExtViolation' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'InitiatorRole' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'InspectionPlace' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'InspectionReason' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'Nace' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'PerformerMark' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'Place' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'Position' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'RefinancingRate' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'SpecialMark' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'Theme' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'TIReason' AND CLS__EXTERNAL_ID <> -1
delete from Classifiers where CLS_TYPE_ID = 'Unit' AND CLS__EXTERNAL_ID <> -1
go

-- select * from Classifiers where CLS_TYPE_ID = 'ActivityType' 
delete from Classifiers where CLS_TYPE_ID = 'ActivityType' AND not cls_id in (
'7E9CD948-95F8-4F4F-8A25-2809A4594E74', -- KP veikðana
'E81133DD-971F-4BE5-A37C-57FFCEEC44FA', -- veikðana pie NM
'CE406850-46EF-492C-AEAD-981601162F36', -- pârsûdzîba
'A3C22C6F-C345-46A4-B29E-983000C67D4D', -- jâiepazîstas ar novçrtçjumu
'21625B44-B164-415D-96E0-DAB250F0777D') -- akta sastâdîðana

delete from Roles where not RLE_ID in (
'819D6F92-8E66-43A9-B3F3-15057FA61B0D',
'D86C1F92-3246-4ABB-A016-1B702EE4110C',
'6DCE3C98-5BBC-49AB-8054-28642B5F3CF3',
'6FCDC07B-4245-4F06-9CAF-5D1AABE3BDE0',
'44D2FEF3-1F17-4073-807A-C89C26052BFD',
'3DB6296A-EA4F-490B-9C8B-E13E1B8AAF48')

------ INSERT User -----------
Declare @pos_id uniqueidentifier,
        @org_id uniqueidentifier
SELECT TOP 1 @pos_id = CLS_ID FROM Classifiers WHERE CLS_TYPE_ID = 'Position' AND CLS__EXTERNAL_ID = -1
SELECT TOP 1 @org_id = ORG_ID FROM Organizations WHERE ORG__EXTERNAL_ID = -1
insert into Users
  (usr_person_code, usr_first_name, usr_last_name,
   usr_position_id, usr_organization_id, usr_works_from,
   usr_logon, usr_role_id)
values
  ('11111122222', 'Administrators', 'Adiministrators',
   @pos_id, @org_id, getdate(),
   'VIDNT\TESTXP', '3DB6296A-EA4F-490B-9C8B-E13E1B8AAF48')
go
--select * from users

---- UPDATE synchro ------------
/*
select 'UPDATE ' + so.name + ' SET ' + sc.name + ' = ''CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'' WHERE IsNull(' + sc.name + ', newid()) <> ''CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'''
from sysobjects so inner join syscolumns sc
     on so.id = sc.id
WHERE so.xtype = 'U'
  AND sc.name like '%_SOURCE'
*/

UPDATE QualityNotes SET QLN__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(QLN__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TextContent SET TXT__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(TXT__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TimberSentDocumentDetails SET SDD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(SDD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE EAAct2Inventories SET EAI__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(EAI__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE ConstructionMaterials SET CMA__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CMA__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE LatestCM SET LCM__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(LCM__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE WWDocuments SET WHD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(WHD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE EAAct2Journals SET EAJ__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(EAJ__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE DataCompareDetails SET DCD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DCD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TimberStackMeasureDetails SET SMD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(SMD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE StatementAfterActions SET SAA__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(SAA__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE RelatedCMCases SET RLC__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(RLC__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TimberIncompleteWaybills SET TIW__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(TIW__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE WholesaleGoods SET WHG__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(WHG__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE DealCompareDocuments SET DED__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DED__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE InvitationDocuments SET IND__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(IND__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CMCaseViolatedRules SET CVR__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CVR__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE ATS_IZM SET ATS__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(ATS__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE BILDES SET BILD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(BILD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TimberRegisterResponsibles SET TRR__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(TRR__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE WWExtraCharges SET WHE__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(WHE__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE DOKUMENTS SET DOK__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DOK__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE EAAct3ReceiptsBefore SET ERB__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(ERB__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE REDAKCIJA SET RED__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(RED__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CMCaseComments SET COM__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(COM__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TP_SAITES_IZM SET DTP__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DTP__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE DealCompareAccounts SET DCA__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DCA__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Veidlapu_IZM SET DVL__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DVL__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE EAAct3ReceiptsAfter SET ERA__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(ERA__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE StatusChanges SET SCH__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(SCH__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Documents SET DOC__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DOC__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Users SET USR__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(USR__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE StatementViolationDetails SET SVD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(SVD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE SrsNumberDetails SET SRD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(SRD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Resources SET RES__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(RES__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE ViolationThemes SET VTH__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(VTH__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE StatementViolations SET STV__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(STV__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TemplateThemes SET TET__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(TET__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE MetalLEDeals SET MLE__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(MLE__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE MandatoryFormDetails SET MFD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(MFD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Performers SET PER__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(PER__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE MetalPEDeals SET MPE__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(MPE__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE GambleEquipments SET GME__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(GME__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE DutyInspections SET DUT__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DUT__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Licences SET LIC__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(LIC__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE InfoAboutStatedCashRegisters SET IAC__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(IAC__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Employees SET EME__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(EME__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Templates SET TPL__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(TPL__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE FixedAssetsAccounting SET FAC__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(FAC__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Violations SET VIO__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(VIO__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE QualityDetails SET QLD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(QLD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE AuditLog SET AUD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(AUD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE QualityAcquaintances SET QLI__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(QLI__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TaxpayerInform SET TPI__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(TPI__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE RiskDutyDetails SET RDT__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(RDT__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Numerators SET NUM__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(NUM__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE BinaryFiles SET BFI__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(BFI__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TimberEquipments SET TIQ__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(TIQ__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE FixedAssetsWarehouse SET FIW__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(FIW__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE DealDocuments SET ADL__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(ADL__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE UndeclaredAccounts SET UNA__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(UNA__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CashDealDetails SET CDD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CDD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE InfoAboutStatedEmployees SET IAE__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(IAE__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Activities SET ACT__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(ACT__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Patents SET PAT__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(PAT__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Partners SET PAR__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(PAR__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CharacterStatementDetails SET CHD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CHD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CashRegister SET ECR__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(ECR__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE InfoAboutStatedNaturalResources SET IAN__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(IAN__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE UserReplacements SET URP__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(URP__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Permissions SET PRM__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(PRM__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE ClassifierTypes SET CLT__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CLT__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE AccountingSoftware SET ASW__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(ASW__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE ActPartners SET ACP__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(ACP__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Classifiers SET CLS__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CLS__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE ViolationResponsibleRules SET VRR__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(VRR__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE DocFileHistory SET DFH__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DFH__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CMCaseViolations SET CVI__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CVI__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE StateDutyDocuments SET SDO__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(SDO__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE InfoAboutStatedReports SET IAR__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(IAR__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CMCaseRisks SET CRI__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CRI__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE AccountingRegisters SET ACR__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(ACR__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE InfoAboutStatedAccounts SET IAA__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(IAA__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CMCaseViolationResponsibleRules SET CRR__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CRR__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TemplateFileVersions SET TFV__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(TFV__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE StateDutyServices SET SDS__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(SDS__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE ViolatedRules SET VRL__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(VRL__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE FuelMeasures SET FUM__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(FUM__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Roles SET RLE__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(RLE__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE AuditNotifications SET AAN__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(AAN__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TaxpayerMembers SET TPM__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(TPM__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CashOperationGoods SET COG__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(COG__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CodeCheck SET CCH__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CCH__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TemplateSignatories SET TSG__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(TSG__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE AccountingDocuments SET ACD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(ACD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE StatementSpecialMarks SET SSM__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(SSM__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CashOperationRequisites SET COQ__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(COQ__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE ExciseGoodsNumbers SET EGN__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(EGN__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE DocStatusHistory SET DSH__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DSH__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE WarehouseRequests SET WHR__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(WHR__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE StatementPenalties SET STP__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(STP__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE DocOwnerHistory SET DOH__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DOH__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE RealEstateTaxpayers SET RET__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(RET__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE Organizations SET ORG__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(ORG__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CMCaseSpecialMarks SET CSM__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CSM__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE StatementPenaltyRules SET SPL__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(SPL__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE TimberReceivedDocumentDetails SET RDD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(RDD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE ExternalPersons SET EXP__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(EXP__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CMCases SET CMC__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CMC__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE EAAct2ZX SET AZX__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(AZX__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE DocumentPerformers SET DPF__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(DPF__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CMCaseThemes SET CTH__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(CTH__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE StatementDecisions SET STD__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(STD__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE ConstructionContractors SET COC__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(COC__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
UPDATE CashOperationMoney SET COU__SOURCE = 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' WHERE IsNull(COU__SOURCE, newid()) <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'
go

/*
select 'UPDATE ' + so.name + ' SET ' + sc.name + ' = 1 WHERE ' + sc.name + ' <> 1'
from sysobjects so inner join syscolumns sc
     on so.id = sc.id
WHERE so.xtype = 'U'
  AND sc.name like '%_VERSION'
  AND NOT sc.name like '%LOCK_VERSION'
  AND so.name <> '_SynchroConfig'
*/

UPDATE QualityNotes SET QLN__VERSION = 1 WHERE QLN__VERSION <> 1
UPDATE CashOperationMoney SET COU__VERSION = 1 WHERE COU__VERSION <> 1
UPDATE TimberSentDocumentDetails SET SDD__VERSION = 1 WHERE SDD__VERSION <> 1
UPDATE EAAct2Inventories SET EAI__VERSION = 1 WHERE EAI__VERSION <> 1
UPDATE ConstructionMaterials SET CMA__VERSION = 1 WHERE CMA__VERSION <> 1
UPDATE LatestCM SET LCM__VERSION = 1 WHERE LCM__VERSION <> 1
UPDATE WWDocuments SET WHD__VERSION = 1 WHERE WHD__VERSION <> 1
UPDATE EAAct2Journals SET EAJ__VERSION = 1 WHERE EAJ__VERSION <> 1
UPDATE DataCompareDetails SET DCD__VERSION = 1 WHERE DCD__VERSION <> 1
UPDATE TimberStackMeasureDetails SET SMD__VERSION = 1 WHERE SMD__VERSION <> 1
UPDATE StatementAfterActions SET SAA__VERSION = 1 WHERE SAA__VERSION <> 1
UPDATE RelatedCMCases SET RLC__VERSION = 1 WHERE RLC__VERSION <> 1
UPDATE TimberIncompleteWaybills SET TIW__VERSION = 1 WHERE TIW__VERSION <> 1
UPDATE WholesaleGoods SET WHG__VERSION = 1 WHERE WHG__VERSION <> 1
UPDATE DealCompareDocuments SET DED__VERSION = 1 WHERE DED__VERSION <> 1
UPDATE InvitationDocuments SET IND__VERSION = 1 WHERE IND__VERSION <> 1
UPDATE CMCaseViolatedRules SET CVR__VERSION = 1 WHERE CVR__VERSION <> 1
UPDATE ATS_IZM SET ATS__VERSION = 1 WHERE ATS__VERSION <> 1
UPDATE BILDES SET BILD__VERSION = 1 WHERE BILD__VERSION <> 1
UPDATE TimberRegisterResponsibles SET TRR__VERSION = 1 WHERE TRR__VERSION <> 1
UPDATE WWExtraCharges SET WHE__VERSION = 1 WHERE WHE__VERSION <> 1
UPDATE DOKUMENTS SET DOK__VERSION = 1 WHERE DOK__VERSION <> 1
UPDATE EAAct3ReceiptsBefore SET ERB__VERSION = 1 WHERE ERB__VERSION <> 1
UPDATE REDAKCIJA SET RED__VERSION = 1 WHERE RED__VERSION <> 1
UPDATE CMCaseComments SET COM__VERSION = 1 WHERE COM__VERSION <> 1
UPDATE TP_SAITES_IZM SET DTP__VERSION = 1 WHERE DTP__VERSION <> 1
UPDATE DealCompareAccounts SET DCA__VERSION = 1 WHERE DCA__VERSION <> 1
UPDATE Veidlapu_IZM SET DVL__VERSION = 1 WHERE DVL__VERSION <> 1
UPDATE EAAct3ReceiptsAfter SET ERA__VERSION = 1 WHERE ERA__VERSION <> 1
UPDATE StatusChanges SET SCH__VERSION = 1 WHERE SCH__VERSION <> 1
UPDATE Documents SET DOC__VERSION = 1 WHERE DOC__VERSION <> 1
UPDATE Documents SET DOC_FILE_VERSION = 1 WHERE DOC_FILE_VERSION <> 1
UPDATE Users SET USR__VERSION = 1 WHERE USR__VERSION <> 1
UPDATE StatementViolationDetails SET SVD__VERSION = 1 WHERE SVD__VERSION <> 1
UPDATE SrsNumberDetails SET SRD__VERSION = 1 WHERE SRD__VERSION <> 1
UPDATE Resources SET RES__VERSION = 1 WHERE RES__VERSION <> 1
UPDATE ViolationThemes SET VTH__VERSION = 1 WHERE VTH__VERSION <> 1
UPDATE StatementViolations SET STV__VERSION = 1 WHERE STV__VERSION <> 1
UPDATE TemplateThemes SET TET__VERSION = 1 WHERE TET__VERSION <> 1
UPDATE MetalLEDeals SET MLE__VERSION = 1 WHERE MLE__VERSION <> 1
UPDATE MandatoryFormDetails SET MFD__VERSION = 1 WHERE MFD__VERSION <> 1
UPDATE Performers SET PER__VERSION = 1 WHERE PER__VERSION <> 1
UPDATE TextContent SET TXT__VERSION = 1 WHERE TXT__VERSION <> 1
UPDATE MetalPEDeals SET MPE__VERSION = 1 WHERE MPE__VERSION <> 1
UPDATE GambleEquipments SET GME__VERSION = 1 WHERE GME__VERSION <> 1
UPDATE DutyInspections SET DUT__VERSION = 1 WHERE DUT__VERSION <> 1
UPDATE Licences SET LIC__VERSION = 1 WHERE LIC__VERSION <> 1
UPDATE InfoAboutStatedCashRegisters SET IAC__VERSION = 1 WHERE IAC__VERSION <> 1
UPDATE Employees SET EME__VERSION = 1 WHERE EME__VERSION <> 1
UPDATE Templates SET TPL__VERSION = 1 WHERE TPL__VERSION <> 1
UPDATE FixedAssetsAccounting SET FAC__VERSION = 1 WHERE FAC__VERSION <> 1
UPDATE Violations SET VIO__VERSION = 1 WHERE VIO__VERSION <> 1
UPDATE QualityDetails SET QLD__VERSION = 1 WHERE QLD__VERSION <> 1
UPDATE AuditLog SET AUD__VERSION = 1 WHERE AUD__VERSION <> 1
UPDATE QualityAcquaintances SET QLI__VERSION = 1 WHERE QLI__VERSION <> 1
UPDATE TaxpayerInform SET TPI__VERSION = 1 WHERE TPI__VERSION <> 1
UPDATE RiskDutyDetails SET RDT__VERSION = 1 WHERE RDT__VERSION <> 1
UPDATE Numerators SET NUM__VERSION = 1 WHERE NUM__VERSION <> 1
UPDATE BinaryFiles SET BFI__VERSION = 1 WHERE BFI__VERSION <> 1
UPDATE TimberEquipments SET TIQ__VERSION = 1 WHERE TIQ__VERSION <> 1
UPDATE FixedAssetsWarehouse SET FIW__VERSION = 1 WHERE FIW__VERSION <> 1
UPDATE DealDocuments SET ADL__VERSION = 1 WHERE ADL__VERSION <> 1
UPDATE UndeclaredAccounts SET UNA__VERSION = 1 WHERE UNA__VERSION <> 1
UPDATE CashDealDetails SET CDD__VERSION = 1 WHERE CDD__VERSION <> 1
UPDATE InfoAboutStatedEmployees SET IAE__VERSION = 1 WHERE IAE__VERSION <> 1
UPDATE Activities SET ACT__VERSION = 1 WHERE ACT__VERSION <> 1
UPDATE Patents SET PAT__VERSION = 1 WHERE PAT__VERSION <> 1
UPDATE Partners SET PAR__VERSION = 1 WHERE PAR__VERSION <> 1
UPDATE CharacterStatementDetails SET CHD__VERSION = 1 WHERE CHD__VERSION <> 1
UPDATE CashRegister SET ECR__VERSION = 1 WHERE ECR__VERSION <> 1
UPDATE InfoAboutStatedNaturalResources SET IAN__VERSION = 1 WHERE IAN__VERSION <> 1
UPDATE UserReplacements SET URP__VERSION = 1 WHERE URP__VERSION <> 1
UPDATE Permissions SET PRM__VERSION = 1 WHERE PRM__VERSION <> 1
UPDATE ClassifierTypes SET CLT__VERSION = 1 WHERE CLT__VERSION <> 1
UPDATE AccountingSoftware SET ASW__VERSION = 1 WHERE ASW__VERSION <> 1
UPDATE ActPartners SET ACP__VERSION = 1 WHERE ACP__VERSION <> 1
UPDATE Classifiers SET CLS__VERSION = 1 WHERE CLS__VERSION <> 1
UPDATE ViolationResponsibleRules SET VRR__VERSION = 1 WHERE VRR__VERSION <> 1
UPDATE DocFileHistory SET DFH__VERSION = 1 WHERE DFH__VERSION <> 1
UPDATE CMCaseViolations SET CVI__VERSION = 1 WHERE CVI__VERSION <> 1
UPDATE StateDutyDocuments SET SDO__VERSION = 1 WHERE SDO__VERSION <> 1
UPDATE InfoAboutStatedReports SET IAR__VERSION = 1 WHERE IAR__VERSION <> 1
UPDATE CMCaseRisks SET CRI__VERSION = 1 WHERE CRI__VERSION <> 1
UPDATE AccountingRegisters SET ACR__VERSION = 1 WHERE ACR__VERSION <> 1
UPDATE InfoAboutStatedAccounts SET IAA__VERSION = 1 WHERE IAA__VERSION <> 1
UPDATE CMCaseViolationResponsibleRules SET CRR__VERSION = 1 WHERE CRR__VERSION <> 1
UPDATE TemplateFileVersions SET TFV__VERSION = 1 WHERE TFV__VERSION <> 1
UPDATE StateDutyServices SET SDS__VERSION = 1 WHERE SDS__VERSION <> 1
UPDATE ViolatedRules SET VRL__VERSION = 1 WHERE VRL__VERSION <> 1
UPDATE FuelMeasures SET FUM__VERSION = 1 WHERE FUM__VERSION <> 1
UPDATE Roles SET RLE__VERSION = 1 WHERE RLE__VERSION <> 1
UPDATE AuditNotifications SET AAN__VERSION = 1 WHERE AAN__VERSION <> 1
UPDATE TaxpayerMembers SET TPM__VERSION = 1 WHERE TPM__VERSION <> 1
UPDATE CashOperationGoods SET COG__VERSION = 1 WHERE COG__VERSION <> 1
UPDATE CodeCheck SET CCH__VERSION = 1 WHERE CCH__VERSION <> 1
UPDATE TemplateSignatories SET TSG__VERSION = 1 WHERE TSG__VERSION <> 1
UPDATE AccountingDocuments SET ACD__VERSION = 1 WHERE ACD__VERSION <> 1
UPDATE StatementSpecialMarks SET SSM__VERSION = 1 WHERE SSM__VERSION <> 1
UPDATE CashOperationRequisites SET COQ__VERSION = 1 WHERE COQ__VERSION <> 1
UPDATE ExciseGoodsNumbers SET EGN__VERSION = 1 WHERE EGN__VERSION <> 1
UPDATE DocStatusHistory SET DSH__VERSION = 1 WHERE DSH__VERSION <> 1
UPDATE WarehouseRequests SET WHR__VERSION = 1 WHERE WHR__VERSION <> 1
UPDATE StatementPenalties SET STP__VERSION = 1 WHERE STP__VERSION <> 1
UPDATE DocOwnerHistory SET DOH__VERSION = 1 WHERE DOH__VERSION <> 1
UPDATE RealEstateTaxpayers SET RET__VERSION = 1 WHERE RET__VERSION <> 1
UPDATE Organizations SET ORG__VERSION = 1 WHERE ORG__VERSION <> 1
UPDATE CMCaseSpecialMarks SET CSM__VERSION = 1 WHERE CSM__VERSION <> 1
UPDATE StatementPenaltyRules SET SPL__VERSION = 1 WHERE SPL__VERSION <> 1
UPDATE TimberReceivedDocumentDetails SET RDD__VERSION = 1 WHERE RDD__VERSION <> 1
UPDATE ExternalPersons SET EXP__VERSION = 1 WHERE EXP__VERSION <> 1
UPDATE CMCases SET CMC__VERSION = 1 WHERE CMC__VERSION <> 1
UPDATE EAAct2ZX SET AZX__VERSION = 1 WHERE AZX__VERSION <> 1
UPDATE DocumentPerformers SET DPF__VERSION = 1 WHERE DPF__VERSION <> 1
UPDATE CMCaseThemes SET CTH__VERSION = 1 WHERE CTH__VERSION <> 1
UPDATE StatementDecisions SET STD__VERSION = 1 WHERE STD__VERSION <> 1
UPDATE ConstructionContractors SET COC__VERSION = 1 WHERE COC__VERSION <> 1
go

--select * from _synchroconfig

UPDATE _SynchroConfig SET SYC_CURRENT_VERSION = 2
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

DBCC UPDATEUSAGE (tpais_prod)
go

backup log tpais_prod with truncate_only
go

DBCC SHRINKFILE ('TPAIS_Large', 30)
go

DBCC SHRINKFILE ('TPAIS_Primary', 20)
go

DBCC SHRINKFILE ('TPAIS_log')
go


--select * from Classifiers order by CLS_TYPE_ID
-- jâizmet jûzeri visi 