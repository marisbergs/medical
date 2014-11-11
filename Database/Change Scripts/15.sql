ALTER TABLE Acts ADD
  ACS_PATENT_ID uniqueidentifier NULL 
    constraint FK_ACS_PATENT_ID references Patents(PAT_ID)
GO
ALTER TABLE CMCases ADD
  CMC_PATENT_ID uniqueidentifier NULL 
    constraint FK_CMC_PATENT_ID references Patents(PAT_ID)
GO
ALTER TABLE CMCaseViolationResponsibleRules ADD
  CRR_QUOTE_ID uniqueidentifier NULL 
    constraint FK_CRR_QUOTE_ID references TextContent(TXT_ID)
GO
ALTER TABLE CMCases ADD
  CMC_INITIATOR_ROLE_ID uniqueidentifier NULL 
    constraint FK_CMC_INITIATOR_ROLE_ID references Roles(RLE_ID)
GO
ALTER TABLE AccountingSoftware ADD ASW_SOFTWARE_NAME nvarchar(250) NULL 
GO
DROP index Patents.IX_Patents_PAT_CASE_ID
GO
ALTER TABLE Patents DROP constraint [FK_PAT_CASE_ID]
GO
ALTER TABLE Patents DROP column PAT_CASE_ID
GO
ALTER TABLE CMCaseViolationResponsibleRules DROP column CRR_QUOTE
GO
ALTER TABLE Patents ALTER column PAT_NAME nvarchar(250) NULL
GO
ALTER TABLE Patents ALTER column PAT_NUMBER nvarchar(50) NULL
GO
ALTER TABLE Patents ALTER column PAT_FROM datetime NULL
GO
ALTER TABLE Patents ALTER column PAT_TO datetime NULL
GO
ALTER TABLE TIActs ALTER column TIA_THEME_NOTES nvarchar(1024) NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Patents (Patents)', N'user', N'dbo', N'table', N'Acts', N'column', N'ACS_PATENT_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Patents (Patents)', N'user', N'dbo', N'table', N'CMCases', N'column', N'CMC_PATENT_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Datorprogrammas nosaukums', N'user', N'dbo', N'table', N'AccountingSoftware', N'column', N'ASW_SOFTWARE_NAME'
GO
exec sp_addextendedproperty N'MS_Description', N'Citâts (TextContent)', N'user', N'dbo', N'table', N'CMCaseViolationResponsibleRules', N'column', N'CRR_QUOTE_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Iniciatora loma', N'user', N'dbo', N'table', N'CMCases', N'column', N'CMC_INITIATOR_ROLE_ID'
GO
UPDATE _SysParameters SET PRM_VALUE = '15' WHERE PRM_NAME LIKE ('VERSION_%_DB')