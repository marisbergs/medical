ALTER TABLE Classifiers ADD
	CLS_MARK bit NULL Default 0
GO
exec sp_addextendedproperty N'MS_Description', N'Pazîme', N'user', N'dbo', N'table', N'Classifiers', N'column', N'CLS_MARK'
GO
ALTER TABLE ClassifierTypes ADD
	CLT_MARK_PROMPT nvarchar(50) NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Vai nepiecieðama pazîme', N'user', N'dbo', N'table', N'ClassifierTypes', N'column', N'CLT_MARK_PROMPT'
GO
ALTER TABLE Correspondence ADD
	COR_TEMPLATE_TYPE_ID uniqueidentifier NULL 
    constraint FK_COR_TEMPLATE_TYPE_ID references Classifiers(CLS_ID)
GO
exec sp_addextendedproperty N'MS_Description', N'Veidlapas tips TemplateType(Classifiers)', N'user', N'dbo', N'table', N'Correspondence', N'column', N'COR_TEMPLATE_TYPE_ID'
GO
ALTER TABLE Violations ADD
	VIO_VALID_FROM datetime NULL 
GO
exec sp_addextendedproperty N'MS_Description', N'Spçkâ no', N'user', N'dbo', N'table', N'Violations', N'column', N'VIO_VALID_FROM'
GO
ALTER TABLE Violations ADD
	VIO_VALID_UNTIL datetime NULL 
GO
exec sp_addextendedproperty N'MS_Description', N'Spçkâ lîdz', N'user', N'dbo', N'table', N'Violations', N'column', N'VIO_VALID_UNTIL'
GO
ALTER TABLE [dbo].[StateDutyServices] DROP CONSTRAINT [FK_SDS_VIOLATION_ID]
GO
UPDATE dbo.StateDutyServices SET SDS_VIOLATION_ID=NULL
GO
ALTER TABLE [dbo].[StateDutyServices] ADD CONSTRAINT [FK_SDS_VIOLATION_ID] FOREIGN KEY 
	(
		[SDS_VIOLATION_ID]
	) REFERENCES [CMCaseViolations] (
		[CVI_ID]
	)
GO
ALTER TABLE InspectionActs ADD
	INA_INSPECTION_REASON_ID uniqueidentifier NULL 
    constraint FK_INA_INSPECTION_REASON_ID references Classifiers(CLS_ID)
GO
exec sp_addextendedproperty N'MS_Description', N'Apsekoðanas iemesls', N'user', N'dbo', N'table', N'InspectionActs', N'column', N'INA_INSPECTION_REASON_ID'
GO
ALTER TABLE InfoAboutStatedReports ADD
	IAR_SRS_REPORT_ID uniqueidentifier NULL
	constraint FK_IAR_SRS_REPORT_ID references Classifiers(CLS_ID)
GO
exec sp_addextendedproperty N'MS_Description', N'Pârskata ID Classifier (TaxpayerInformed)', N'user', N'dbo', N'table', N'InfoAboutStatedReports', N'column', N'IAR_SRS_REPORT_ID'
GO
UPDATE _SysParameters SET PRM_VALUE = '21' WHERE PRM_NAME LIKE ('VERSION_%_DB')   