ALTER TABLE [CMCases] ADD
CMC_REPORT_PENDING TINYINT CONSTRAINT DF_CMCases_CMC_REPORT_PENDING DEFAULT 0 CONSTRAINT NN_CMCases_CMC_REPORT_PENDING NOT NULL
GO

CREATE INDEX IX_CMCases_CMC_REPORT_PENDING ON CMCases(CMC_REPORT_PENDING)
GO

UPDATE CMCases SET CMC_REPORT_PENDING = 1 WHERE CMC_STATUS = 13
GO

ALTER TABLE [TcdPlans] ADD
TDP_REPORT_PENDING TINYINT CONSTRAINT DF_TcdPlans_TDP_REPORT_PENDING DEFAULT 0 CONSTRAINT NN_TcdPlans_TDP_REPORT_PENDING NOT NULL
GO

CREATE INDEX IX_TcdPlans_TDP_REPORT_PENDING ON TcdPlans(TDP_REPORT_PENDING)
GO

UPDATE TcdPlans SET TDP_REPORT_PENDING = 1 WHERE EXISTS (SELECT * FROM Documents WHERE DOC_ID = TDP_ID AND DOC_STATUS = 4)
GO

ALTER TABLE Acts ADD
  ACS_NEED_MORE_INFO bit not null constraint DF_Acts_ACS_NEED_MORE_INFO default (1)
GO

ALTER TABLE Organizations ADD
  ORG_DEPARTMENT_ID uniqueidentifier NULL 
    constraint FK_ORG_DEPARTMENT_ID references Organizations(ORG_ID)
GO

ALTER TABLE EndDecisions ADD
  END_ARGUMENTS varchar(500)
go

ALTER TABLE [dbo].[Documents] DROP CONSTRAINT [FK_DOC_FILE_ID]
GO

ALTER TABLE [dbo].[FuelLoss] DROP CONSTRAINT [FK_FUL_FUEL_MEASURE_ID]
GO

ALTER TABLE [dbo].[CodeCheck] DROP CONSTRAINT [FK_CCH_DOCUMENT_ID]
GO

exec sp_addextendedproperty N'MS_Description', N'TIN', N'user', N'dbo', N'table', N'Organizations', N'column', N'ORG_DEPARTMENT_ID'
GO

exec sp_addextendedproperty N'MS_Description', N'Pazîme "Nepiecieðama papildus informâcija"', N'user', N'dbo', N'table', N'Acts', N'column', N'ACS_NEED_MORE_INFO'
GO

exec sp_addextendedproperty N'MS_Description', N'Pazîme par XML pârskatu nosûtîðanu uz DNS un NIS', N'user', N'dbo', N'table', N'CMCases', N'column', N'CMC_REPORT_PENDING'
GO

exec sp_addextendedproperty N'MS_Description', N'Pazîme par XML pârskatu nosûtîðanu uz DNS un NIS', N'user', N'dbo', N'table', N'TcdPlans', N'column', N'TDP_REPORT_PENDING'
GO

exec sp_addextendedproperty N'MS_Description', N'Argumenti un fakti', N'user', N'dbo', N'table', N'EndDecisions', N'column', N'END_ARGUMENTS'
GO

UPDATE _SysParameters SET PRM_VALUE = '2' WHERE PRM_NAME LIKE ('VERSION_%_DB')
GO

