drop index InfoAboutStatedRisks.IX_InfoAboutStatedRisks_IAI_RISK_ID
go

alter table InfoAboutStatedRisks drop constraint FK_IAI_RISK_ID
go

alter table InfoAboutStatedRisks drop column IAI_RISK_ID
go

alter table InfoAboutStatedRisks add IAI_RISK nvarchar(250)
go

alter table StatementPenaltyRules
  add SPL_FINAL bit not null constraint DF_StatementPenaltyRules_SPL_FINAL default(0)
go

exec sp_addextendedproperty N'MS_Description', N'Pazīme "Galīgais lēmums"', N'user', N'dbo', N'table', N'StatementPenaltyRules', N'column', N'SPL_FINAL'
go

exec sp_addextendedproperty N'MS_Description', N'Risks', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI_RISK'
go

UPDATE _SysParameters SET PRM_VALUE = '4' WHERE PRM_NAME LIKE ('VERSION_%_DB')
GO
