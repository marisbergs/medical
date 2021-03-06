alter table Classifiers alter column CLS_TEXT nvarchar(3350)
GO

alter table StatementDecisions drop column STD_DECISION
GO

alter table StatementDecisions add
  STD_DECISION_ID uniqueidentifier NULL
  constraint FK_STD_DECISION_ID references Classifiers(CLS_ID)
GO

create index IX_StatementDecisions_STD_DECISION_ID on StatementDecisions(STD_DECISION_ID)
GO

exec sp_addextendedproperty N'MS_Description', N'Lēmuma ID (klasifikators SrsDecision)', N'user', N'dbo', N'table', N'StatementDecisions', N'column', N'STD_DECISION_ID'
GO


UPDATE _SysParameters SET PRM_VALUE = '5' WHERE PRM_NAME LIKE ('VERSION_%_DB')
GO
-- Lūdzu, Юникод